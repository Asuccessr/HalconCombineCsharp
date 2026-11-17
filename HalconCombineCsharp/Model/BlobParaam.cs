using System.ComponentModel;

namespace HalconCombineCsharp
{
    /// <summary>
    /// Blob检测参数，给PropertyGrid调参、JSON保存方案
    /// </summary>
    public class BlobParam
    {
        [Category("面积筛选")]
        [Description("Blob最小面积，小于该值会被过滤")]
        public double AreaMin { get; set; } = 50;

        [Category("面积筛选")]
        [Description("Blob最大面积，大于该值会被过滤")]
        public double AreaMax { get; set; } = 999999;

        [Category("形状筛选")]
        [Description("圆度下限，范围0~1，越接近1越接近正圆")]
        public double RoundnessMin { get; set; } = 0;

        [Category("形状筛选")]
        [Description("矩形度下限，范围0~1，越接近1越接近标准矩形")]
        public double RectMin { get; set; } = 0;

        [Category("孔洞筛选")]
        [Description("允许的最大孔洞数量，超过则判定NG")]
        public int HoleMaxCount { get; set; } = 99;

        [Category("形态学预处理")]
        [Description("形态学操作：None不处理 / Opening开运算 / Closing闭运算 / Erosion腐蚀 / Dilation膨胀")]
        public string MorphType { get; set; } = "None";

        [Category("形态学预处理")]
        [Description("圆形结构元半径，必须是奇数")]
        public int MorphKernel { get; set; } = 3;
    }

    /// <summary>
    /// 单个Blob结果项，用于DataGridView表格展示
    /// </summary>
    public class BlobResultItem
    {
        [DisplayName("序号")]
        public int Id { get; set; }

        [DisplayName("中心Row")]
        public double Row { get; set; }

        [DisplayName("中心Col")]
        public double Col { get; set; }

        [DisplayName("面积")]
        public double Area { get; set; }

        [DisplayName("圆度")]
        public double Roundness { get; set; }

        [DisplayName("矩形度")]
        public double RectFactor { get; set; }

        [DisplayName("孔洞数量")]
        public int HoleCount { get; set; }

        [DisplayName("判定结果")]
        public string IsNG { get; set; }
    }
}
