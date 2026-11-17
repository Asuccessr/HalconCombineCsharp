using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalconCombineCsharp.tools
{
    public class BlobDetects
    {
        /// <summary>
        /// Blob主处理函数
        /// </summary>
        /// <param name="grayImage">输入灰度图</param>
        /// <param name="regionBin">二值化后的区域（thRegions）</param>
        /// <param name="param">Blob配置参数 BlobParam</param>
        /// <param name="outOkUnionRegion">【out输出】所有OK区域合并后的区域</param>
        /// <returns>每个Blob的明细结果列表</returns>
        public List<BlobResultItem> RunBlob(HObject grayImage, HObject regionBin, BlobParam param, out HObject outOkUnionRegion) 
        {
            List<BlobResultItem> blobResults = new List<BlobResultItem>();
            outOkUnionRegion = new HObject();

            //临时变量（形态学后的区域）
            HObject regionMorph = new HObject();
            //复制一份原始二值化区域，避免直接修改原始区域
            HOperatorSet.CopyObj(regionBin, out regionMorph, 1,1);

            //-  ① 形态学分支判断：开 / 闭 / 腐蚀 / 膨胀 / 不处理
            if (param.MorphType == "Opening") { 
                HOperatorSet.OpeningCircle(regionMorph, out regionMorph, param.MorphKernel);
            }
            else if (param.MorphType == "Closing")
            {
                HOperatorSet.ClosingCircle(regionMorph, out regionMorph, param.MorphKernel);
            }
            else if (param.MorphType == "Erosion")
            {
                HOperatorSet.ErosionCircle(regionMorph, out regionMorph, param.MorphKernel);
            }
            else if (param.MorphType == "Dilation")
            {
                HOperatorSet.DilationCircle(regionMorph, out regionMorph, param.MorphKernel);
            }

            //-  ② Connection 连通域分割
            HObject connectRegion;
            HOperatorSet.Connection(regionMorph, out connectRegion);
            //-  ③ CountObj 获取连通域总数，循环遍历每一个 Blob
            HOperatorSet.CountObj(connectRegion, out HTuple blobTotal);
            //-  ④ 循环内依次计算：AreaCenter、Roundness、Rectangularity、孔洞数量
            for (int i = 1; i <= blobTotal; i++)
            {
                HObject singleRegion;
                HOperatorSet.CopyObj(connectRegion, out singleRegion, i , 1);

                //计算面积、中心点、圆度
                HOperatorSet.AreaCenter(singleRegion, out HTuple area, out HTuple row, out HTuple col);
                HOperatorSet.Roundness(singleRegion, out HTuple distance, out HTuple sigma, out HTuple roundness, out HTuple distMean);
                //计算矩形度
                HOperatorSet.Rectangularity(singleRegion, out HTuple rectangularity);
                //计算孔洞数量
                HTuple numConnects;
                HOperatorSet.ConnectAndHoles(singleRegion,out numConnects,out HTuple holeCount);

                //-  ⑤ 写 NG 判定逻辑：任意一项不满足阈值 → NG
                bool isNg = false;
                if(area < param.AreaMin || area > param.AreaMax) isNg = true;
                if (roundness < param.RoundnessMin) isNg = true;
                if (rectangularity < param.RectMin) isNg = true;
                if (holeCount > param.HoleMaxCount) isNg = true;

                //将结果封装到BlobResultItem对象中
                BlobResultItem item = new BlobResultItem()
                {
                    Id = i,
                    Row = row,
                    Col = col,
                    Area = area,
                    Roundness = roundness,
                    RectFactor = rectangularity,
                    HoleCount = holeCount,
                    IsNG = isNg ? "NG" : "OK"
                };
                blobResults.Add(item);

                //释放临时对象
                singleRegion.Dispose();
                numConnects.Dispose();

            }

            //-  ⑥ SelectShape 批量筛选合格区域
            HObject ok1, ok2;
            HOperatorSet.SelectShape(connectRegion, out ok1, "area", "and", param.AreaMin, param.AreaMax);
            HOperatorSet.SelectShape(ok1, out ok2, "roundness", "and", param.RoundnessMin, 1.0);
            HOperatorSet.SelectShape(ok2, out HObject okRegion, "rectangularity", "and", param.RectMin, 1.0);
            ok2.Dispose();
            ok1.Dispose();
            //-  ⑦ Union1 合并合格区域作为输出区域
            // 1. 先 union 到内部临时区域
            HObject unionRegion;
            HOperatorSet.Union1(okRegion, out unionRegion);
            // 2. 复制一份独立对象，交给 out —— 这份归外部窗体管理
            HOperatorSet.CopyObj(unionRegion, out outOkUnionRegion,1,1);
            unionRegion.Dispose();
            okRegion.Dispose();
            regionMorph.Dispose();
            connectRegion.Dispose();

            //返回明细列表
            return blobResults;
        }


    }
}
