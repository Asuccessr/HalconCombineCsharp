namespace HalconCombineCsharp
{
    partial class PG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            myHsmartWindowControl1 = new HalconCombineCsharp.myControls.myHsmartWindowControl();
            groupBox3 = new GroupBox();
            HelpFunction = new GroupBox();
            detectCon = new Button();
            clearDraw = new Button();
            SaveParameter = new Button();
            executMsm = new Button();
            drawCalliper = new Button();
            executMatch = new Button();
            BlobAnalyse = new GroupBox();
            loadTemplate = new Button();
            TrainTemplate = new Button();
            SelectArithmetic = new Button();
            executeBlob = new Button();
            BtnBlobParam = new Button();
            groupBox4 = new GroupBox();
            ImageBasic = new GroupBox();
            btnGray = new Button();
            BtnReduce = new Button();
            btnGrabImage = new Button();
            BtnVector = new Button();
            btnThreshold = new Button();
            BtnOpening = new Button();
            BtnConnection = new Button();
            BtnSelect = new Button();
            tabControl1 = new TabControl();
            detectResult = new TabPage();
            dataGridView1 = new DataGridView();
            propPram = new TabPage();
            groupBox2 = new GroupBox();
            ProG = new PropertyGrid();
            logInformation = new TabPage();
            txtLog = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            HelpFunction.SuspendLayout();
            BlobAnalyse.SuspendLayout();
            ImageBasic.SuspendLayout();
            tabControl1.SuspendLayout();
            detectResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            propPram.SuspendLayout();
            groupBox2.SuspendLayout();
            logInformation.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(myHsmartWindowControl1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 568);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "可视化窗口";
            // 
            // myHsmartWindowControl1
            // 
            myHsmartWindowControl1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            myHsmartWindowControl1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            myHsmartWindowControl1.HDoubleClickToFitContent = true;
            myHsmartWindowControl1.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            myHsmartWindowControl1.HImagePart = new Rectangle(-407, -404, 1454, 1288);
            myHsmartWindowControl1.HKeepAspectRatio = true;
            myHsmartWindowControl1.HMoveContent = true;
            myHsmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            myHsmartWindowControl1.Location = new Point(-37, 0);
            myHsmartWindowControl1.Margin = new Padding(0);
            myHsmartWindowControl1.Name = "myHsmartWindowControl1";
            myHsmartWindowControl1.Size = new Size(619, 713);
            myHsmartWindowControl1.TabIndex = 0;
            myHsmartWindowControl1.WindowSize = new Size(619, 713);
            myHsmartWindowControl1.Load += myHsmartWindowControl1_Load;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(HelpFunction);
            groupBox3.Controls.Add(BlobAnalyse);
            groupBox3.Controls.Add(ImageBasic);
            groupBox3.Location = new Point(942, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 740);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "功能窗口";
            // 
            // HelpFunction
            // 
            HelpFunction.Controls.Add(detectCon);
            HelpFunction.Controls.Add(clearDraw);
            HelpFunction.Controls.Add(SaveParameter);
            HelpFunction.Controls.Add(executMsm);
            HelpFunction.Controls.Add(drawCalliper);
            HelpFunction.Controls.Add(executMatch);
            HelpFunction.Location = new Point(26, 452);
            HelpFunction.Name = "HelpFunction";
            HelpFunction.Size = new Size(377, 210);
            HelpFunction.TabIndex = 10;
            HelpFunction.TabStop = false;
            HelpFunction.Text = "辅助功能";
            // 
            // detectCon
            // 
            detectCon.BackColor = Color.PowderBlue;
            detectCon.ForeColor = SystemColors.ActiveCaptionText;
            detectCon.Location = new Point(195, 125);
            detectCon.Name = "detectCon";
            detectCon.Size = new Size(132, 40);
            detectCon.TabIndex = 5;
            detectCon.Text = "连续检测";
            detectCon.UseVisualStyleBackColor = false;
            // 
            // clearDraw
            // 
            clearDraw.BackColor = Color.DarkTurquoise;
            clearDraw.ForeColor = SystemColors.ControlText;
            clearDraw.Location = new Point(20, 125);
            clearDraw.Name = "clearDraw";
            clearDraw.Size = new Size(132, 40);
            clearDraw.TabIndex = 4;
            clearDraw.Text = "清空绘制";
            clearDraw.UseVisualStyleBackColor = false;
            // 
            // SaveParameter
            // 
            SaveParameter.BackColor = Color.PaleTurquoise;
            SaveParameter.ForeColor = SystemColors.ActiveCaptionText;
            SaveParameter.Location = new Point(195, 79);
            SaveParameter.Name = "SaveParameter";
            SaveParameter.Size = new Size(132, 40);
            SaveParameter.TabIndex = 3;
            SaveParameter.Text = "参数保存";
            SaveParameter.UseVisualStyleBackColor = false;
            // 
            // executMsm
            // 
            executMsm.BackColor = Color.MediumTurquoise;
            executMsm.ForeColor = SystemColors.ActiveCaptionText;
            executMsm.Location = new Point(20, 79);
            executMsm.Name = "executMsm";
            executMsm.Size = new Size(132, 40);
            executMsm.TabIndex = 2;
            executMsm.Text = "执行测量";
            executMsm.UseVisualStyleBackColor = false;
            // 
            // drawCalliper
            // 
            drawCalliper.ForeColor = SystemColors.ActiveCaptionText;
            drawCalliper.Location = new Point(195, 27);
            drawCalliper.Name = "drawCalliper";
            drawCalliper.Size = new Size(129, 40);
            drawCalliper.TabIndex = 1;
            drawCalliper.Text = "绘制卡尺ROI";
            drawCalliper.UseVisualStyleBackColor = true;
            // 
            // executMatch
            // 
            executMatch.BackColor = Color.Turquoise;
            executMatch.ForeColor = SystemColors.ActiveCaptionText;
            executMatch.Location = new Point(20, 27);
            executMatch.Name = "executMatch";
            executMatch.Size = new Size(132, 40);
            executMatch.TabIndex = 0;
            executMatch.Text = "执行匹配";
            executMatch.UseVisualStyleBackColor = false;
            executMatch.Click += button2_Click;
            // 
            // BlobAnalyse
            // 
            BlobAnalyse.Controls.Add(loadTemplate);
            BlobAnalyse.Controls.Add(TrainTemplate);
            BlobAnalyse.Controls.Add(SelectArithmetic);
            BlobAnalyse.Controls.Add(executeBlob);
            BlobAnalyse.Controls.Add(BtnBlobParam);
            BlobAnalyse.Controls.Add(groupBox4);
            BlobAnalyse.Location = new Point(26, 252);
            BlobAnalyse.Name = "BlobAnalyse";
            BlobAnalyse.Size = new Size(373, 185);
            BlobAnalyse.TabIndex = 9;
            BlobAnalyse.TabStop = false;
            BlobAnalyse.Text = "Blob分析";
            // 
            // loadTemplate
            // 
            loadTemplate.BackColor = Color.Azure;
            loadTemplate.FlatStyle = FlatStyle.Flat;
            loadTemplate.ForeColor = SystemColors.ActiveCaptionText;
            loadTemplate.Location = new Point(195, 134);
            loadTemplate.Name = "loadTemplate";
            loadTemplate.Size = new Size(129, 43);
            loadTemplate.TabIndex = 15;
            loadTemplate.Text = "加载模板";
            loadTemplate.UseVisualStyleBackColor = false;
            // 
            // TrainTemplate
            // 
            TrainTemplate.BackColor = Color.SkyBlue;
            TrainTemplate.FlatStyle = FlatStyle.Flat;
            TrainTemplate.ForeColor = SystemColors.ButtonHighlight;
            TrainTemplate.Location = new Point(20, 134);
            TrainTemplate.Name = "TrainTemplate";
            TrainTemplate.Size = new Size(123, 43);
            TrainTemplate.TabIndex = 14;
            TrainTemplate.Text = "训练模板";
            TrainTemplate.UseVisualStyleBackColor = false;
            // 
            // SelectArithmetic
            // 
            SelectArithmetic.BackColor = Color.MintCream;
            SelectArithmetic.FlatStyle = FlatStyle.Flat;
            SelectArithmetic.ForeColor = Color.Teal;
            SelectArithmetic.Location = new Point(20, 85);
            SelectArithmetic.Name = "SelectArithmetic";
            SelectArithmetic.Size = new Size(304, 43);
            SelectArithmetic.TabIndex = 13;
            SelectArithmetic.Text = "算法选择";
            SelectArithmetic.UseVisualStyleBackColor = false;
            // 
            // executeBlob
            // 
            executeBlob.BackColor = Color.MintCream;
            executeBlob.FlatStyle = FlatStyle.Flat;
            executeBlob.ForeColor = Color.Teal;
            executeBlob.Location = new Point(195, 36);
            executeBlob.Name = "executeBlob";
            executeBlob.Size = new Size(129, 43);
            executeBlob.TabIndex = 12;
            executeBlob.Text = "执行Blob检测";
            executeBlob.UseVisualStyleBackColor = false;
            executeBlob.Click += executeBlob_Click;
            // 
            // BtnBlobParam
            // 
            BtnBlobParam.BackColor = Color.MediumTurquoise;
            BtnBlobParam.FlatStyle = FlatStyle.Flat;
            BtnBlobParam.ForeColor = SystemColors.ButtonHighlight;
            BtnBlobParam.Location = new Point(20, 36);
            BtnBlobParam.Name = "BtnBlobParam";
            BtnBlobParam.Size = new Size(123, 43);
            BtnBlobParam.TabIndex = 11;
            BtnBlobParam.Text = "Blob参数";
            BtnBlobParam.UseVisualStyleBackColor = false;
            BtnBlobParam.Click += BtnBlobParam_Click;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(0, 185);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(365, 201);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // ImageBasic
            // 
            ImageBasic.Controls.Add(btnGray);
            ImageBasic.Controls.Add(BtnReduce);
            ImageBasic.Controls.Add(btnGrabImage);
            ImageBasic.Controls.Add(BtnVector);
            ImageBasic.Controls.Add(btnThreshold);
            ImageBasic.Controls.Add(BtnOpening);
            ImageBasic.Controls.Add(BtnConnection);
            ImageBasic.Controls.Add(BtnSelect);
            ImageBasic.Location = new Point(26, 27);
            ImageBasic.Name = "ImageBasic";
            ImageBasic.Size = new Size(373, 219);
            ImageBasic.TabIndex = 8;
            ImageBasic.TabStop = false;
            ImageBasic.Text = "图像基础";
            ImageBasic.Enter += groupBox4_Enter;
            // 
            // btnGray
            // 
            btnGray.BackColor = Color.LightSeaGreen;
            btnGray.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGray.ForeColor = SystemColors.ControlLightLight;
            btnGray.Location = new Point(0, 71);
            btnGray.Name = "btnGray";
            btnGray.Size = new Size(143, 37);
            btnGray.TabIndex = 3;
            btnGray.Text = "灰度化";
            btnGray.UseVisualStyleBackColor = false;
            btnGray.Click += btnGrayImage_Click;
            // 
            // BtnReduce
            // 
            BtnReduce.BackColor = Color.LightSeaGreen;
            BtnReduce.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReduce.ForeColor = SystemColors.ControlLightLight;
            BtnReduce.Location = new Point(195, 158);
            BtnReduce.Name = "BtnReduce";
            BtnReduce.Size = new Size(175, 30);
            BtnReduce.TabIndex = 7;
            BtnReduce.Text = "提取目标区域";
            BtnReduce.UseVisualStyleBackColor = false;
            BtnReduce.Click += BtnReduce_Click;
            // 
            // btnGrabImage
            // 
            btnGrabImage.BackColor = Color.LightSeaGreen;
            btnGrabImage.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrabImage.ForeColor = SystemColors.ControlLightLight;
            btnGrabImage.Location = new Point(0, 28);
            btnGrabImage.Name = "btnGrabImage";
            btnGrabImage.Size = new Size(143, 38);
            btnGrabImage.TabIndex = 0;
            btnGrabImage.Text = "采集图像";
            btnGrabImage.UseVisualStyleBackColor = false;
            btnGrabImage.Click += btnGrabImage_Click;
            // 
            // BtnVector
            // 
            BtnVector.BackColor = Color.LightSeaGreen;
            BtnVector.FlatStyle = FlatStyle.Flat;
            BtnVector.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVector.ForeColor = SystemColors.ControlLightLight;
            BtnVector.Location = new Point(0, 158);
            BtnVector.Name = "BtnVector";
            BtnVector.Size = new Size(143, 30);
            BtnVector.TabIndex = 6;
            BtnVector.Text = "反射变换";
            BtnVector.UseVisualStyleBackColor = false;
            BtnVector.Click += BtnVector_Click;
            // 
            // btnThreshold
            // 
            btnThreshold.BackColor = Color.LightSeaGreen;
            btnThreshold.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThreshold.ForeColor = SystemColors.ControlLightLight;
            btnThreshold.Location = new Point(195, 28);
            btnThreshold.Name = "btnThreshold";
            btnThreshold.Size = new Size(163, 37);
            btnThreshold.TabIndex = 1;
            btnThreshold.Text = "二值化";
            btnThreshold.UseVisualStyleBackColor = false;
            btnThreshold.Click += btnThreshold_Click;
            // 
            // BtnOpening
            // 
            BtnOpening.BackColor = Color.LightSeaGreen;
            BtnOpening.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnOpening.ForeColor = SystemColors.ControlLightLight;
            BtnOpening.Location = new Point(195, 114);
            BtnOpening.Name = "BtnOpening";
            BtnOpening.Size = new Size(172, 38);
            BtnOpening.TabIndex = 5;
            BtnOpening.Text = "形态学处理";
            BtnOpening.UseVisualStyleBackColor = false;
            BtnOpening.Click += BtnOpening_Click;
            // 
            // BtnConnection
            // 
            BtnConnection.BackColor = Color.LightSeaGreen;
            BtnConnection.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConnection.ForeColor = SystemColors.ControlLightLight;
            BtnConnection.Location = new Point(195, 71);
            BtnConnection.Name = "BtnConnection";
            BtnConnection.Size = new Size(172, 37);
            BtnConnection.TabIndex = 2;
            BtnConnection.Text = "区域分割";
            BtnConnection.UseVisualStyleBackColor = false;
            BtnConnection.Click += BtnConnection_Click;
            // 
            // BtnSelect
            // 
            BtnSelect.BackColor = Color.LightSeaGreen;
            BtnSelect.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSelect.ForeColor = SystemColors.ControlLightLight;
            BtnSelect.Location = new Point(0, 114);
            BtnSelect.Name = "BtnSelect";
            BtnSelect.Size = new Size(143, 35);
            BtnSelect.TabIndex = 4;
            BtnSelect.Text = "特征筛选";
            BtnSelect.UseVisualStyleBackColor = false;
            BtnSelect.Click += BtnSelect_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(detectResult);
            tabControl1.Controls.Add(propPram);
            tabControl1.Controls.Add(logInformation);
            tabControl1.Location = new Point(615, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(311, 568);
            tabControl1.TabIndex = 4;
            // 
            // detectResult
            // 
            detectResult.Controls.Add(dataGridView1);
            detectResult.Location = new Point(4, 30);
            detectResult.Name = "detectResult";
            detectResult.Padding = new Padding(3);
            detectResult.Size = new Size(303, 534);
            detectResult.TabIndex = 0;
            detectResult.Text = "检测结果";
            detectResult.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(297, 528);
            dataGridView1.TabIndex = 0;
            // 
            // propPram
            // 
            propPram.Controls.Add(groupBox2);
            propPram.Location = new Point(4, 26);
            propPram.Name = "propPram";
            propPram.Padding = new Padding(3);
            propPram.Size = new Size(303, 538);
            propPram.TabIndex = 1;
            propPram.Text = "参数配置";
            propPram.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ProG);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 532);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // ProG
            // 
            ProG.BackColor = SystemColors.Control;
            ProG.Dock = DockStyle.Fill;
            ProG.Location = new Point(3, 24);
            ProG.Name = "ProG";
            ProG.Size = new Size(291, 505);
            ProG.TabIndex = 0;
            // 
            // logInformation
            // 
            logInformation.Controls.Add(txtLog);
            logInformation.Location = new Point(4, 30);
            logInformation.Name = "logInformation";
            logInformation.Size = new Size(303, 534);
            logInformation.TabIndex = 2;
            logInformation.Text = "日志信息";
            logInformation.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            txtLog.Dock = DockStyle.Fill;
            txtLog.Location = new Point(0, 0);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(303, 534);
            txtLog.TabIndex = 0;
            // 
            // PG
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 775);
            Controls.Add(tabControl1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PG";
            Text = "Halcon联合C#变成的基础实战";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            HelpFunction.ResumeLayout(false);
            BlobAnalyse.ResumeLayout(false);
            ImageBasic.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            detectResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            propPram.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            logInformation.ResumeLayout(false);
            logInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }









        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnGrabImage;
        private Button btnThreshold;
        private Button BtnSelect;
        private Button btnGray;
        private Button BtnConnection;
        private Button BtnReduce;
        private Button BtnVector;
        private Button BtnOpening;
        private myControls.myHsmartWindowControl myHsmartWindowControl1;
        private GroupBox ImageBasic;
        private GroupBox BlobAnalyse;
        private GroupBox groupBox4;
        private GroupBox HelpFunction;
        private Button BtnBlobParam;
        private Button loadTemplate;
        private Button TrainTemplate;
        private Button SelectArithmetic;
        private Button executeBlob;
        private Button executMatch;
        private Button drawCalliper;
        private Button detectCon;
        private Button clearDraw;
        private Button SaveParameter;
        private Button executMsm;
        private TabControl tabControl1;
        private TabPage detectResult;
        private TabPage propPram;
        private TabPage logInformation;
        private TextBox txtLog;
        private GroupBox groupBox2;
        private PropertyGrid ProG;
        private DataGridView dataGridView1;
    }
}
