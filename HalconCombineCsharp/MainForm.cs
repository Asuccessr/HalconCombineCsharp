using HalconCombineCsharp.attrs;
using HalconDotNet;
using System;
using System.Windows.Forms;

namespace HalconCombineCsharp
{
    public partial class PG : Form
    {
        private HWindow window_handle;
        private HImage ho_Image;

        // 只保留流水线上下游需要传递的【结果变量】，中间临时区域不再放全局
        private HObject GrayImage;
        private HObject thRegions;
        private HObject ReConnections;
        private HObject selectedRegions;
        private HObject regionOpening; // 给后面仿射变换使用
        private HObject imageAffine;
        private HObject regionAffine;
        private HObject reducedImage;
        private HObject cropImage;

        public PG()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        #region 工具方法
        /// <summary>
        /// 切换功能：清空PropertyGrid全部事件，防止事件叠加，多个回调同时执行
        /// </summary>
        private void ClearProGEvent()
        {
            ProG.SelectedGridItemChanged -= ProG_SelectedGridItemChanged;
            ProG.PropertyValueChanged -= ProG_PropertyValueChanged;
            ProG.PropertyValueChanged -= ProG_PropertyValueChanged_Radius;
        }

        /// <summary>
        /// 安全赋值HObject：赋值前先释放旧对象，避免内存泄漏、野指针
        /// </summary>
        private void SafeAssignHObject(ref HObject globalObj, HObject newObj)
        {
            if (globalObj != null)
            {
                globalObj.Dispose();
            }
            if (newObj != null && !HObjectIsEmpty(newObj))
            {
                globalObj = newObj.CopyObj(1, -1);
            }
            else
            {
                globalObj = new HObject();
            }
        }
        #endregion

        #region 主窗口加载后执行的逻辑
        private void MainForm_Load(object? sender, EventArgs e)
        {
            window_handle = myHsmartWindowControl1.HalconWindow;
            //注册鼠标滚轮事件
            myHsmartWindowControl1.MouseWheel += MyHsmartWindowControl1_MouseWheel;
        }
        #endregion

        #region 完成显示空间内的图像缩放操作
        private void MyHsmartWindowControl1_MouseWheel(object? sender, MouseEventArgs e)
        {
            myHsmartWindowControl1.HSmartWindowControl_MouseWheel(sender, e);
        }
        #endregion

        #region 采集图像（本地图像）
        private void btnGrabImage_Click(object sender, EventArgs e)
        {
            //清空控件信息
            window_handle.ClearWindow();
            //创建资源对话框
            var dialog = new OpenFileDialog();
            dialog.Filter = "图像文件|*.bmp;*.jpg;*.png;*.tif;*.jpeg";
            dialog.RestoreDirectory = true;//设置对话框是否记忆上次打开的目录
            //判断对话框是否正常打开
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取图像路径
                string imagePath = dialog.FileName;
                //创建halcon图像对象
                ho_Image = new HImage(imagePath);
                //显示图像
                window_handle.DispObj(ho_Image);
                //实现图像自适应窗口大小
                myHsmartWindowControl1.SetFullImagePart();
            }
        }
        #endregion

        #region 灰度化图像
        private void btnGrayImage_Click(object sender, EventArgs e)
        {
            if (ho_Image == null || HObjectIsEmpty(ho_Image))
            {
                MessageBox.Show("请先采集图像！");
                return;
            }
            HObject tempGray = new HObject();
            try
            {
                HOperatorSet.Rgb1ToGray(ho_Image, out tempGray);
                SafeAssignHObject(ref GrayImage, tempGray);
                window_handle.DispObj(GrayImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"灰度化异常：{ex.Message}");
            }
            finally
            {
                tempGray.Dispose();
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region 图像二值化操作
        private void btnThreshold_Click(object sender, EventArgs e)
        {
            ClearProGEvent();
            if (GrayImage == null || HObjectIsEmpty(GrayImage))
            {
                MessageBox.Show("请先灰度化！");
                return;
            }
            ProG.SelectedObject = new Threshold();
            ProG.SelectedGridItemChanged += ProG_SelectedGridItemChanged;
        }

        private void ProG_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            var threshold = ((PropertyGrid)sender).SelectedObject as Threshold;
            if (threshold == null) return;

            var minGray = threshold.MinGray < 0 ? 0 : (threshold.MinGray > 255 ? 255 : threshold.MinGray);
            var maxGray = threshold.MaxGray < 0 ? 0 : (threshold.MaxGray > 255 ? 255 : threshold.MaxGray);
            minGray = Math.Min(minGray, maxGray);
            threshold.MinGray = minGray;
            threshold.MaxGray = maxGray;
            ProG.SelectedObject = threshold;

            HObject tempTh = new HObject();
            try
            {
                HOperatorSet.Threshold(GrayImage, out tempTh, minGray, maxGray);
                SafeAssignHObject(ref thRegions, tempTh);

                window_handle.ClearWindow();
                window_handle.SetColor("red");
                window_handle.DispObj(GrayImage);
                window_handle.DispObj(thRegions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"二值化异常：{ex.Message}");
            }
            finally
            {
                tempTh.Dispose();
            }
        }
        #endregion

        #region 区域分割
        private void BtnConnection_Click(object sender, EventArgs e)
        {
            //清空事件，防止事件叠加
            ClearProGEvent();
            if (thRegions == null || HObjectIsEmpty(thRegions))
            {
                MessageBox.Show("请先二值化！");
                return;
            }
            HObject tempConn = new HObject();
            try
            {
                HOperatorSet.Connection(thRegions, out tempConn);
                SafeAssignHObject(ref ReConnections, tempConn);

                window_handle.SetColored(12);
                window_handle.DispObj(GrayImage);
                window_handle.DispObj(ReConnections);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"连通域分割异常：{ex.Message}");
            }
            finally
            {
                tempConn.Dispose();
            }
        }
        #endregion

        #region 特征筛选
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            ClearProGEvent();
            if (ReConnections == null || HObjectIsEmpty(ReConnections))
            {
                MessageBox.Show("请先做区域分割！");
                return;
            }
            ProG.SelectedObject = new Feature();
            ProG.PropertyValueChanged += ProG_PropertyValueChanged;
        }

        private void ProG_PropertyValueChanged(object? sender, PropertyValueChangedEventArgs e)
        {
            var pg = sender as PropertyGrid;
            if (pg == null) return;
            var feature = pg.SelectedObject as Feature;
            if (feature == null) return;

            var min = feature.Min < 0 ? 0 : feature.Min;
            var max = feature.Max < 0 ? 0 : feature.Max;
            // 确保min不大于max
            min = Math.Min(min, max);
            feature.Min = min;
            feature.Max = max;
            // 重新设置SelectedObject，确保PropertyGrid显示更新后的值
            ProG.SelectedObject = feature;

            // 执行特征筛选
            HObject tempSelect = new HObject();
            try
            {
                HOperatorSet.SelectShape(ReConnections, out tempSelect, feature.FeatureName, feature.Operation, min, max);
                SafeAssignHObject(ref selectedRegions, tempSelect);

                window_handle.ClearWindow();
                window_handle.SetColored(12);
                window_handle.DispObj(selectedRegions);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"特征筛选异常：{ex.Message}");
            }
            finally
            {
                tempSelect.Dispose();
            }
        }
        #endregion

        #region 形态学操作
        private void BtnOpening_Click(object sender, EventArgs e)
        {
            ClearProGEvent();
            if (selectedRegions == null || HObjectIsEmpty(selectedRegions))
            {
                MessageBox.Show("请先完成特征筛选！");
                return;
            }
            ProG.SelectedObject = new Radius();
            ProG.PropertyValueChanged += ProG_PropertyValueChanged_Radius;
        }

        private void ProG_PropertyValueChanged_Radius(object? s, PropertyValueChangedEventArgs e)
        {
            var pg = s as PropertyGrid;
            if (pg == null) return;
            var radius = pg.SelectedObject as Radius;
            if (radius == null) return;

            if (radius.RadiusValue <= 0)
            {
                MessageBox.Show("半径必须大于0！");
                return;
            }

            HObject filledRegions = new HObject();
            HObject regionOpeningTemp = new HObject();
            HObject regionRect = new HObject();

            // 执行开运算
            try
            {
                HOperatorSet.FillUp(selectedRegions, out filledRegions);
                HOperatorSet.OpeningCircle(filledRegions, out regionOpeningTemp, radius.RadiusValue);
                HOperatorSet.ShapeTrans(regionOpeningTemp, out regionRect, "rectangle2");

                // 保存矩形结果给后面仿射变换使用
                SafeAssignHObject(ref regionOpening, regionRect);

                window_handle.ClearWindow();
                window_handle.SetColor("red");
                window_handle.DispObj(regionRect);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"开运算异常：{ex.Message}");
            }
            finally
            {
                filledRegions.Dispose();
                regionOpeningTemp.Dispose();
                regionRect.Dispose();
            }
        }
        #endregion

        #region 反射变换（刚性仿射摆正，自动判断是否翻转180°）
        private void BtnVector_Click(object sender, EventArgs e)
        {
            ClearProGEvent();
            if (regionOpening == null || HObjectIsEmpty(regionOpening))
            {
                MessageBox.Show("请先做形态学开运算！");
                return;
            }
            try
            {
                HOperatorSet.AreaCenter(regionOpening, out HTuple area, out HTuple row, out HTuple column);
                HOperatorSet.OrientationRegion(regionOpening, out HTuple phi);

                // ========== 核心:判断是否需要翻转180度 ==========
                double phiVal = phi.D;
                double targetAngle = 0;
                // 角度绝对值大于90°（π/2）代表颠倒，目标角度设180°
                if (Math.Abs(phiVal) > Math.PI / 2)
                {
                    targetAngle = Math.PI;
                }
                // ======================================================

                // 创建刚性仿射变换矩阵
                HOperatorSet.VectorAngleToRigid(row, column, phi, row, column, targetAngle, out HTuple homMat2D);

                // 执行仿射变换
                HObject tempImgAffine = new HObject();
                HObject tempRegAffine = new HObject();
                try
                {
                    HOperatorSet.AffineTransImage(GrayImage, out tempImgAffine, homMat2D, "constant", "false");
                    HOperatorSet.AffineTransRegion(regionOpening, out tempRegAffine, homMat2D, "nearest_neighbor");
                    //校验变量没问题后
                    // 保存仿射变换结果给全局，供后续使用
                    SafeAssignHObject(ref imageAffine, tempImgAffine);
                    SafeAssignHObject(ref regionAffine, tempRegAffine);

                    window_handle.ClearWindow();
                    window_handle.SetColor("red");
                    window_handle.DispObj(imageAffine);
                    window_handle.DispObj(regionAffine);
                }
                finally
                {
                    tempImgAffine.Dispose();
                    tempRegAffine.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"仿射摆正异常：{ex.Message}");
            }
        }
        #endregion


        #region 提取目标区域
        private void BtnReduce_Click(object sender, EventArgs e)
        {
            ClearProGEvent();
            if (imageAffine == null || HObjectIsEmpty(imageAffine) || regionAffine == null || HObjectIsEmpty(regionAffine))
            {
                MessageBox.Show("请先做仿射变换！");
                return;
            }
            HObject tempReduce = new HObject();
            HObject tempCrop = new HObject();
            try
            {
                HOperatorSet.ReduceDomain(imageAffine, regionAffine, out tempReduce);
                HOperatorSet.CropDomain(tempReduce, out tempCrop);
                SafeAssignHObject(ref cropImage, tempCrop);

                window_handle.ClearWindow();
                window_handle.DispObj(ho_Image);
                window_handle.DispObj(cropImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"抠图异常：{ex.Message}");
            }
            finally
            {
                tempReduce.Dispose();
                tempCrop.Dispose();
            }
        }
        #endregion

        /// <summary>判断HObject里面有没有对象（0=空）</summary>
        private bool HObjectIsEmpty(HObject ho)
        {
            if (ho == null) return true;
            HOperatorSet.CountObj(ho, out HTuple count);
            return count.I == 0;
        }

    }
}
