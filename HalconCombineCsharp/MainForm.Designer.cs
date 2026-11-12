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
            groupBox2 = new GroupBox();
            ProG = new PropertyGrid();
            groupBox3 = new GroupBox();
            BtnReduce = new Button();
            BtnVector = new Button();
            BtnOpening = new Button();
            BtnSelect = new Button();
            btnGray = new Button();
            BtnConnection = new Button();
            btnThreshold = new Button();
            btnGrabImage = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            myHsmartWindowControl1.HImagePart = new Rectangle(-364, -249, 1368, 978);
            myHsmartWindowControl1.HKeepAspectRatio = true;
            myHsmartWindowControl1.HMoveContent = true;
            myHsmartWindowControl1.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            myHsmartWindowControl1.Location = new Point(3, 24);
            myHsmartWindowControl1.Margin = new Padding(0);
            myHsmartWindowControl1.Name = "myHsmartWindowControl1";
            myHsmartWindowControl1.Size = new Size(582, 541);
            myHsmartWindowControl1.TabIndex = 0;
            myHsmartWindowControl1.WindowSize = new Size(582, 541);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ProG);
            groupBox2.Location = new Point(597, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 571);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "属性设置窗口";
            // 
            // ProG
            // 
            ProG.BackColor = SystemColors.Control;
            ProG.Dock = DockStyle.Fill;
            ProG.Location = new Point(3, 24);
            ProG.Name = "ProG";
            ProG.Size = new Size(299, 544);
            ProG.TabIndex = 0;
            ProG.SelectedGridItemChanged += ProG_SelectedGridItemChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnReduce);
            groupBox3.Controls.Add(BtnVector);
            groupBox3.Controls.Add(BtnOpening);
            groupBox3.Controls.Add(BtnSelect);
            groupBox3.Controls.Add(btnGray);
            groupBox3.Controls.Add(BtnConnection);
            groupBox3.Controls.Add(btnThreshold);
            groupBox3.Controls.Add(btnGrabImage);
            groupBox3.Location = new Point(901, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(279, 571);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "功能窗口";
            // 
            // BtnReduce
            // 
            BtnReduce.BackColor = Color.LightSeaGreen;
            BtnReduce.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReduce.ForeColor = SystemColors.ControlLightLight;
            BtnReduce.Location = new Point(29, 520);
            BtnReduce.Name = "BtnReduce";
            BtnReduce.Size = new Size(196, 52);
            BtnReduce.TabIndex = 7;
            BtnReduce.Text = "提取目标区域";
            BtnReduce.UseVisualStyleBackColor = false;
            BtnReduce.Click += BtnReduce_Click;
            // 
            // BtnVector
            // 
            BtnVector.BackColor = Color.LightSeaGreen;
            BtnVector.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnVector.ForeColor = SystemColors.ControlLightLight;
            BtnVector.Location = new Point(29, 452);
            BtnVector.Name = "BtnVector";
            BtnVector.Size = new Size(196, 52);
            BtnVector.TabIndex = 6;
            BtnVector.Text = "反射变换";
            BtnVector.UseVisualStyleBackColor = false;
            BtnVector.Click += BtnVector_Click;
            // 
            // BtnOpening
            // 
            BtnOpening.BackColor = Color.LightSeaGreen;
            BtnOpening.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnOpening.ForeColor = SystemColors.ControlLightLight;
            BtnOpening.Location = new Point(29, 384);
            BtnOpening.Name = "BtnOpening";
            BtnOpening.Size = new Size(196, 52);
            BtnOpening.TabIndex = 5;
            BtnOpening.Text = "形态学处理";
            BtnOpening.UseVisualStyleBackColor = false;
            BtnOpening.Click += BtnOpening_Click;
            // 
            // BtnSelect
            // 
            BtnSelect.BackColor = Color.LightSeaGreen;
            BtnSelect.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSelect.ForeColor = SystemColors.ControlLightLight;
            BtnSelect.Location = new Point(29, 310);
            BtnSelect.Name = "BtnSelect";
            BtnSelect.Size = new Size(196, 52);
            BtnSelect.TabIndex = 4;
            BtnSelect.Text = "特征筛选";
            BtnSelect.UseVisualStyleBackColor = false;
            BtnSelect.Click += BtnSelect_Click;
            // 
            // btnGray
            // 
            btnGray.BackColor = Color.LightSeaGreen;
            btnGray.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGray.ForeColor = SystemColors.ControlLightLight;
            btnGray.Location = new Point(29, 117);
            btnGray.Name = "btnGray";
            btnGray.Size = new Size(196, 52);
            btnGray.TabIndex = 3;
            btnGray.Text = "灰度化";
            btnGray.UseVisualStyleBackColor = false;
            btnGray.Click += btnGrayImage_Click;
            // 
            // BtnConnection
            // 
            BtnConnection.BackColor = Color.LightSeaGreen;
            BtnConnection.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnConnection.ForeColor = SystemColors.ControlLightLight;
            BtnConnection.Location = new Point(29, 252);
            BtnConnection.Name = "BtnConnection";
            BtnConnection.Size = new Size(196, 52);
            BtnConnection.TabIndex = 2;
            BtnConnection.Text = "区域分割";
            BtnConnection.UseVisualStyleBackColor = false;
            BtnConnection.Click += BtnConnection_Click;
            // 
            // btnThreshold
            // 
            btnThreshold.BackColor = Color.LightSeaGreen;
            btnThreshold.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThreshold.ForeColor = SystemColors.ControlLightLight;
            btnThreshold.Location = new Point(29, 184);
            btnThreshold.Name = "btnThreshold";
            btnThreshold.Size = new Size(196, 52);
            btnThreshold.TabIndex = 1;
            btnThreshold.Text = "二值化";
            btnThreshold.UseVisualStyleBackColor = false;
            btnThreshold.Click += btnThreshold_Click;
            // 
            // btnGrabImage
            // 
            btnGrabImage.BackColor = Color.LightSeaGreen;
            btnGrabImage.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGrabImage.ForeColor = SystemColors.ControlLightLight;
            btnGrabImage.Location = new Point(29, 47);
            btnGrabImage.Name = "btnGrabImage";
            btnGrabImage.Size = new Size(196, 52);
            btnGrabImage.TabIndex = 0;
            btnGrabImage.Text = "采集图像";
            btnGrabImage.UseVisualStyleBackColor = false;
            btnGrabImage.Click += btnGrabImage_Click;
            // 
            // PG
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 775);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PG";
            Text = "Halcon联合C#变成的基础实战";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }









        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PropertyGrid ProG;
        private Button btnGrabImage;
        private Button btnThreshold;
        private Button BtnSelect;
        private Button btnGray;
        private Button BtnConnection;
        private Button BtnReduce;
        private Button BtnVector;
        private Button BtnOpening;
        private myControls.myHsmartWindowControl myHsmartWindowControl1;
    }
}
