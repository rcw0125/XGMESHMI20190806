namespace EnergyMag
{
    partial class FireDataFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxSlag = new System.Windows.Forms.GroupBox();
            this.gbxTransition = new System.Windows.Forms.GroupBox();
            this.gbxSide4 = new System.Windows.Forms.GroupBox();
            this.gbxMIF = new System.Windows.Forms.GroupBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxCCM5 = new System.Windows.Forms.GroupBox();
            this.gbxCCMHotFire = new System.Windows.Forms.GroupBox();
            this.energyMeter19 = new EnergyMag.EnergyMeter1();
            this.energyMeter18 = new EnergyMag.EnergyMeter1();
            this.energyMeter17 = new EnergyMag.EnergyMeter1();
            this.energyMeter1 = new EnergyMag.EnergyMeter();
            this.energyMeter13 = new EnergyMag.EnergyMeter1();
            this.energyMeter12 = new EnergyMag.EnergyMeter1();
            this.energyMeter123 = new EnergyMag.EnergyMeter1();
            this.energyMeter127 = new EnergyMag.EnergyMeter1();
            this.energyMeter124 = new EnergyMag.EnergyMeter1();
            this.energyMeter125 = new EnergyMag.EnergyMeter1();
            this.energyMeter126 = new EnergyMag.EnergyMeter1();
            this.energyMeter122 = new EnergyMag.EnergyMeter1();
            this.energyMeter11 = new EnergyMag.EnergyMeter1();
            this.energyMeter121 = new EnergyMag.EnergyMeter1();
            this.energyMeter120 = new EnergyMag.EnergyMeter1();
            this.energyMeter14 = new EnergyMag.EnergyMeter1();
            this.energyMeter119 = new EnergyMag.EnergyMeter1();
            this.energyMeter16 = new EnergyMag.EnergyMeter1();
            this.energyMeter15 = new EnergyMag.EnergyMeter1();
            this.energyMeter115 = new EnergyMag.EnergyMeter1();
            this.energyMeter114 = new EnergyMag.EnergyMeter1();
            this.energyMeter113 = new EnergyMag.EnergyMeter1();
            this.energyMeter112 = new EnergyMag.EnergyMeter1();
            this.energyMeter111 = new EnergyMag.EnergyMeter1();
            this.energyMeter118 = new EnergyMag.EnergyMeter1();
            this.energyMeter117 = new EnergyMag.EnergyMeter1();
            this.energyMeter116 = new EnergyMag.EnergyMeter1();
            this.energyMeter110 = new EnergyMag.EnergyMeter1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxSlag.SuspendLayout();
            this.gbxTransition.SuspendLayout();
            this.gbxSide4.SuspendLayout();
            this.gbxMIF.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxCCM5.SuspendLayout();
            this.gbxCCMHotFire.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbxSlag
            // 
            this.gbxSlag.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxSlag.Controls.Add(this.energyMeter115);
            this.gbxSlag.Controls.Add(this.energyMeter114);
            this.gbxSlag.Controls.Add(this.energyMeter113);
            this.gbxSlag.Controls.Add(this.energyMeter112);
            this.gbxSlag.Controls.Add(this.energyMeter111);
            this.gbxSlag.Controls.Add(this.energyMeter118);
            this.gbxSlag.Controls.Add(this.energyMeter117);
            this.gbxSlag.Controls.Add(this.energyMeter116);
            this.gbxSlag.Controls.Add(this.energyMeter110);
            this.gbxSlag.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxSlag.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxSlag.Location = new System.Drawing.Point(0, 0);
            this.gbxSlag.Margin = new System.Windows.Forms.Padding(0);
            this.gbxSlag.Name = "gbxSlag";
            this.gbxSlag.Padding = new System.Windows.Forms.Padding(0);
            this.gbxSlag.Size = new System.Drawing.Size(1020, 236);
            this.gbxSlag.TabIndex = 30;
            this.gbxSlag.TabStop = false;
            this.gbxSlag.Text = "渣跨";
            // 
            // gbxTransition
            // 
            this.gbxTransition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxTransition.Controls.Add(this.energyMeter14);
            this.gbxTransition.Controls.Add(this.energyMeter119);
            this.gbxTransition.Controls.Add(this.energyMeter16);
            this.gbxTransition.Controls.Add(this.energyMeter15);
            this.gbxTransition.Location = new System.Drawing.Point(0, 237);
            this.gbxTransition.Margin = new System.Windows.Forms.Padding(0);
            this.gbxTransition.Name = "gbxTransition";
            this.gbxTransition.Padding = new System.Windows.Forms.Padding(0);
            this.gbxTransition.Size = new System.Drawing.Size(661, 128);
            this.gbxTransition.TabIndex = 31;
            this.gbxTransition.TabStop = false;
            this.gbxTransition.Text = "过渡跨";
            // 
            // gbxSide4
            // 
            this.gbxSide4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxSide4.Controls.Add(this.energyMeter122);
            this.gbxSide4.Controls.Add(this.energyMeter11);
            this.gbxSide4.Controls.Add(this.energyMeter121);
            this.gbxSide4.Controls.Add(this.energyMeter120);
            this.gbxSide4.Location = new System.Drawing.Point(0, 366);
            this.gbxSide4.Margin = new System.Windows.Forms.Padding(0);
            this.gbxSide4.Name = "gbxSide4";
            this.gbxSide4.Padding = new System.Windows.Forms.Padding(0);
            this.gbxSide4.Size = new System.Drawing.Size(661, 128);
            this.gbxSide4.TabIndex = 32;
            this.gbxSide4.TabStop = false;
            this.gbxSide4.Text = "4#炉后";
            // 
            // gbxMIF
            // 
            this.gbxMIF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxMIF.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxMIF.Controls.Add(this.energyMeter13);
            this.gbxMIF.Controls.Add(this.energyMeter12);
            this.gbxMIF.Location = new System.Drawing.Point(661, 366);
            this.gbxMIF.Margin = new System.Windows.Forms.Padding(0);
            this.gbxMIF.Name = "gbxMIF";
            this.gbxMIF.Padding = new System.Windows.Forms.Padding(0);
            this.gbxMIF.Size = new System.Drawing.Size(356, 128);
            this.gbxMIF.TabIndex = 33;
            this.gbxMIF.TabStop = false;
            this.gbxMIF.Text = "混铁炉";
            // 
            // groupBox24
            // 
            this.groupBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox24.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox24.Controls.Add(this.energyMeter18);
            this.groupBox24.Controls.Add(this.energyMeter17);
            this.groupBox24.Controls.Add(this.groupBox1);
            this.groupBox24.Location = new System.Drawing.Point(661, 237);
            this.groupBox24.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox24.Size = new System.Drawing.Size(359, 128);
            this.groupBox24.TabIndex = 34;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "精整垮";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.energyMeter1);
            this.groupBox1.Location = new System.Drawing.Point(558, -232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 105);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "南中包预热站烘烤器";
            // 
            // gbxCCM5
            // 
            this.gbxCCM5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCCM5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxCCM5.Controls.Add(this.energyMeter19);
            this.gbxCCM5.Location = new System.Drawing.Point(835, 495);
            this.gbxCCM5.Margin = new System.Windows.Forms.Padding(0);
            this.gbxCCM5.Name = "gbxCCM5";
            this.gbxCCM5.Padding = new System.Windows.Forms.Padding(0);
            this.gbxCCM5.Size = new System.Drawing.Size(176, 129);
            this.gbxCCM5.TabIndex = 35;
            this.gbxCCM5.TabStop = false;
            this.gbxCCM5.Text = "5#机";
            // 
            // gbxCCMHotFire
            // 
            this.gbxCCMHotFire.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbxCCMHotFire.Controls.Add(this.energyMeter123);
            this.gbxCCMHotFire.Controls.Add(this.energyMeter127);
            this.gbxCCMHotFire.Controls.Add(this.energyMeter124);
            this.gbxCCMHotFire.Controls.Add(this.energyMeter125);
            this.gbxCCMHotFire.Controls.Add(this.energyMeter126);
            this.gbxCCMHotFire.Location = new System.Drawing.Point(0, 495);
            this.gbxCCMHotFire.Margin = new System.Windows.Forms.Padding(0);
            this.gbxCCMHotFire.Name = "gbxCCMHotFire";
            this.gbxCCMHotFire.Padding = new System.Windows.Forms.Padding(0);
            this.gbxCCMHotFire.Size = new System.Drawing.Size(835, 129);
            this.gbxCCMHotFire.TabIndex = 32;
            this.gbxCCMHotFire.TabStop = false;
            this.gbxCCMHotFire.Text = "铸机中包烘烤器东(西)煤气流量";
            // 
            // energyMeter19
            // 
            this.energyMeter19.Adapter = this.Adapter;
            this.energyMeter19.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter19.Flow = 40F;
            this.energyMeter19.FlowProp = "Flow";
            this.energyMeter19.gbxNameText = "AB跨中包预热站烘烤器";
            this.energyMeter19.HighFlow = 80F;
            this.energyMeter19.HighFlowProp = "F_High";
            this.energyMeter19.HighPressure = 80F;
            this.energyMeter19.HighPressureProp = "P_High";
            this.energyMeter19.Location = new System.Drawing.Point(14, 14);
            this.energyMeter19.LowFlow = 10F;
            this.energyMeter19.LowFlowProp = "F_Low";
            this.energyMeter19.LowPressure = 10F;
            this.energyMeter19.LowPressureProp = "P_Low";
            this.energyMeter19.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter19.MaxFlow = 100F;
            this.energyMeter19.MaxFlowProp = "F_Max";
            this.energyMeter19.MaxPressure = 100F;
            this.energyMeter19.MaxPressureProp = "P_Max";
            this.energyMeter19.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1022";
            this.energyMeter19.MinFlow = 0F;
            this.energyMeter19.MinFlowProp = "F_Min";
            this.energyMeter19.MinPressure = 0F;
            this.energyMeter19.MinPressureProp = "P_Min";
            this.energyMeter19.Name = "energyMeter19";
            this.energyMeter19.Pressure = 40F;
            this.energyMeter19.PressureProp = "Pressure";
            this.energyMeter19.Size = new System.Drawing.Size(148, 106);
            this.energyMeter19.TabIndex = 30;
            this.energyMeter19.Tag = "1022";
            this.energyMeter19.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter18
            // 
            this.energyMeter18.Adapter = this.Adapter;
            this.energyMeter18.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter18.Flow = 40F;
            this.energyMeter18.FlowProp = "Flow";
            this.energyMeter18.gbxNameText = "北中包预热站烘烤器";
            this.energyMeter18.HighFlow = 80F;
            this.energyMeter18.HighFlowProp = "F_High";
            this.energyMeter18.HighPressure = 80F;
            this.energyMeter18.HighPressureProp = "P_High";
            this.energyMeter18.Location = new System.Drawing.Point(188, 14);
            this.energyMeter18.LowFlow = 10F;
            this.energyMeter18.LowFlowProp = "F_Low";
            this.energyMeter18.LowPressure = 10F;
            this.energyMeter18.LowPressureProp = "P_Low";
            this.energyMeter18.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter18.MaxFlow = 100F;
            this.energyMeter18.MaxFlowProp = "F_Max";
            this.energyMeter18.MaxPressure = 100F;
            this.energyMeter18.MaxPressureProp = "P_Max";
            this.energyMeter18.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1021";
            this.energyMeter18.MinFlow = 0F;
            this.energyMeter18.MinFlowProp = "F_Min";
            this.energyMeter18.MinPressure = 0F;
            this.energyMeter18.MinPressureProp = "P_Min";
            this.energyMeter18.Name = "energyMeter18";
            this.energyMeter18.Pressure = 40F;
            this.energyMeter18.PressureProp = "Pressure";
            this.energyMeter18.Size = new System.Drawing.Size(148, 106);
            this.energyMeter18.TabIndex = 30;
            this.energyMeter18.Tag = "1021";
            this.energyMeter18.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter17
            // 
            this.energyMeter17.Adapter = this.Adapter;
            this.energyMeter17.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter17.Flow = 40F;
            this.energyMeter17.FlowProp = "Flow";
            this.energyMeter17.gbxNameText = "南中包预热站烘烤器";
            this.energyMeter17.HighFlow = 80F;
            this.energyMeter17.HighFlowProp = "F_High";
            this.energyMeter17.HighPressure = 80F;
            this.energyMeter17.HighPressureProp = "P_High";
            this.energyMeter17.Location = new System.Drawing.Point(8, 14);
            this.energyMeter17.LowFlow = 10F;
            this.energyMeter17.LowFlowProp = "F_Low";
            this.energyMeter17.LowPressure = 10F;
            this.energyMeter17.LowPressureProp = "P_Low";
            this.energyMeter17.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter17.MaxFlow = 100F;
            this.energyMeter17.MaxFlowProp = "F_Max";
            this.energyMeter17.MaxPressure = 100F;
            this.energyMeter17.MaxPressureProp = "P_Max";
            this.energyMeter17.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1020";
            this.energyMeter17.MinFlow = 0F;
            this.energyMeter17.MinFlowProp = "F_Min";
            this.energyMeter17.MinPressure = 0F;
            this.energyMeter17.MinPressureProp = "P_Min";
            this.energyMeter17.Name = "energyMeter17";
            this.energyMeter17.Pressure = 40F;
            this.energyMeter17.PressureProp = "Pressure";
            this.energyMeter17.Size = new System.Drawing.Size(148, 106);
            this.energyMeter17.TabIndex = 30;
            this.energyMeter17.Tag = "1020";
            this.energyMeter17.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter1
            // 
            this.energyMeter1.Adapter = null;
            this.energyMeter1.BackColor = System.Drawing.Color.Gainsboro;
            this.energyMeter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.energyMeter1.Flow = 40F;
            this.energyMeter1.FlowProp = "Flow";
            this.energyMeter1.gbxNameText = "名称";
            this.energyMeter1.HighFlow = 80F;
            this.energyMeter1.HighFlowProp = "F_High";
            this.energyMeter1.HighPressure = 80F;
            this.energyMeter1.HighPressureProp = "P_High";
            this.energyMeter1.Location = new System.Drawing.Point(3, 17);
            this.energyMeter1.LowFlow = 10F;
            this.energyMeter1.LowFlowProp = "F_Low";
            this.energyMeter1.LowPressure = 10F;
            this.energyMeter1.LowPressureProp = "P_Low";
            this.energyMeter1.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter1.MaxFlow = 100F;
            this.energyMeter1.MaxFlowProp = "F_Max";
            this.energyMeter1.MaxPressure = 100F;
            this.energyMeter1.MaxPressureProp = "P_Max";
            this.energyMeter1.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1020";
            this.energyMeter1.MinFlow = 0F;
            this.energyMeter1.MinFlowProp = "F_Min";
            this.energyMeter1.MinPressure = 0F;
            this.energyMeter1.MinPressureProp = "P_Min";
            this.energyMeter1.Name = "energyMeter1";
            this.energyMeter1.Pressure = 40F;
            this.energyMeter1.PressureProp = "Pressure";
            this.energyMeter1.Size = new System.Drawing.Size(127, 85);
            this.energyMeter1.TabIndex = 0;
            this.energyMeter1.Tag = "1020";
            this.energyMeter1.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter13
            // 
            this.energyMeter13.Adapter = this.Adapter;
            this.energyMeter13.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter13.Flow = 40F;
            this.energyMeter13.FlowProp = "Flow";
            this.energyMeter13.gbxNameText = "西铁包烘烤器";
            this.energyMeter13.HighFlow = 80F;
            this.energyMeter13.HighFlowProp = "F_High";
            this.energyMeter13.HighPressure = 80F;
            this.energyMeter13.HighPressureProp = "P_High";
            this.energyMeter13.Location = new System.Drawing.Point(188, 17);
            this.energyMeter13.LowFlow = 10F;
            this.energyMeter13.LowFlowProp = "F_Low";
            this.energyMeter13.LowPressure = 10F;
            this.energyMeter13.LowPressureProp = "P_Low";
            this.energyMeter13.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter13.MaxFlow = 100F;
            this.energyMeter13.MaxFlowProp = "F_Max";
            this.energyMeter13.MaxPressure = 100F;
            this.energyMeter13.MaxPressureProp = "P_Max";
            this.energyMeter13.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1019";
            this.energyMeter13.MinFlow = 0F;
            this.energyMeter13.MinFlowProp = "F_Min";
            this.energyMeter13.MinPressure = 0F;
            this.energyMeter13.MinPressureProp = "P_Min";
            this.energyMeter13.Name = "energyMeter13";
            this.energyMeter13.Pressure = 40F;
            this.energyMeter13.PressureProp = "Pressure";
            this.energyMeter13.Size = new System.Drawing.Size(148, 106);
            this.energyMeter13.TabIndex = 30;
            this.energyMeter13.Tag = "1019";
            this.energyMeter13.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter12
            // 
            this.energyMeter12.Adapter = this.Adapter;
            this.energyMeter12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter12.Flow = 40F;
            this.energyMeter12.FlowProp = "Flow";
            this.energyMeter12.gbxNameText = "东铁包烘烤器";
            this.energyMeter12.HighFlow = 80F;
            this.energyMeter12.HighFlowProp = "F_High";
            this.energyMeter12.HighPressure = 80F;
            this.energyMeter12.HighPressureProp = "P_High";
            this.energyMeter12.Location = new System.Drawing.Point(8, 17);
            this.energyMeter12.LowFlow = 10F;
            this.energyMeter12.LowFlowProp = "F_Low";
            this.energyMeter12.LowPressure = 10F;
            this.energyMeter12.LowPressureProp = "P_Low";
            this.energyMeter12.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter12.MaxFlow = 100F;
            this.energyMeter12.MaxFlowProp = "F_Max";
            this.energyMeter12.MaxPressure = 100F;
            this.energyMeter12.MaxPressureProp = "P_Max";
            this.energyMeter12.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1018";
            this.energyMeter12.MinFlow = 0F;
            this.energyMeter12.MinFlowProp = "F_Min";
            this.energyMeter12.MinPressure = 0F;
            this.energyMeter12.MinPressureProp = "P_Min";
            this.energyMeter12.Name = "energyMeter12";
            this.energyMeter12.Pressure = 40F;
            this.energyMeter12.PressureProp = "Pressure";
            this.energyMeter12.Size = new System.Drawing.Size(148, 106);
            this.energyMeter12.TabIndex = 30;
            this.energyMeter12.Tag = "1018";
            this.energyMeter12.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter123
            // 
            this.energyMeter123.Adapter = this.Adapter;
            this.energyMeter123.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter123.Flow = 40F;
            this.energyMeter123.FlowProp = "Flow";
            this.energyMeter123.gbxNameText = "1#铸机";
            this.energyMeter123.HighFlow = 80F;
            this.energyMeter123.HighFlowProp = "F_High";
            this.energyMeter123.HighPressure = 80F;
            this.energyMeter123.HighPressureProp = "P_High";
            this.energyMeter123.Location = new System.Drawing.Point(21, 15);
            this.energyMeter123.LowFlow = 10F;
            this.energyMeter123.LowFlowProp = "F_Low";
            this.energyMeter123.LowPressure = 10F;
            this.energyMeter123.LowPressureProp = "P_Low";
            this.energyMeter123.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter123.MaxFlow = 100F;
            this.energyMeter123.MaxFlowProp = "F_Max";
            this.energyMeter123.MaxPressure = 100F;
            this.energyMeter123.MaxPressureProp = "P_Max";
            this.energyMeter123.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1023";
            this.energyMeter123.MinFlow = 0F;
            this.energyMeter123.MinFlowProp = "F_Min";
            this.energyMeter123.MinPressure = 0F;
            this.energyMeter123.MinPressureProp = "P_Min";
            this.energyMeter123.Name = "energyMeter123";
            this.energyMeter123.Pressure = 40F;
            this.energyMeter123.PressureProp = "Pressure";
            this.energyMeter123.Size = new System.Drawing.Size(148, 106);
            this.energyMeter123.TabIndex = 30;
            this.energyMeter123.Tag = "1023";
            this.energyMeter123.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter127
            // 
            this.energyMeter127.Adapter = this.Adapter;
            this.energyMeter127.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter127.Flow = 40F;
            this.energyMeter127.FlowProp = "Flow";
            this.energyMeter127.gbxNameText = "5#铸机";
            this.energyMeter127.HighFlow = 80F;
            this.energyMeter127.HighFlowProp = "F_High";
            this.energyMeter127.HighPressure = 80F;
            this.energyMeter127.HighPressureProp = "P_High";
            this.energyMeter127.Location = new System.Drawing.Point(669, 16);
            this.energyMeter127.LowFlow = 10F;
            this.energyMeter127.LowFlowProp = "F_Low";
            this.energyMeter127.LowPressure = 10F;
            this.energyMeter127.LowPressureProp = "P_Low";
            this.energyMeter127.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter127.MaxFlow = 100F;
            this.energyMeter127.MaxFlowProp = "F_Max";
            this.energyMeter127.MaxPressure = 100F;
            this.energyMeter127.MaxPressureProp = "P_Max";
            this.energyMeter127.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1027";
            this.energyMeter127.MinFlow = 0F;
            this.energyMeter127.MinFlowProp = "F_Min";
            this.energyMeter127.MinPressure = 0F;
            this.energyMeter127.MinPressureProp = "P_Min";
            this.energyMeter127.Name = "energyMeter127";
            this.energyMeter127.Pressure = 40F;
            this.energyMeter127.PressureProp = "Pressure";
            this.energyMeter127.Size = new System.Drawing.Size(148, 106);
            this.energyMeter127.TabIndex = 30;
            this.energyMeter127.Tag = "1027";
            this.energyMeter127.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter124
            // 
            this.energyMeter124.Adapter = this.Adapter;
            this.energyMeter124.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter124.Flow = 40F;
            this.energyMeter124.FlowProp = "Flow";
            this.energyMeter124.gbxNameText = "4#铸机";
            this.energyMeter124.HighFlow = 80F;
            this.energyMeter124.HighFlowProp = "F_High";
            this.energyMeter124.HighPressure = 80F;
            this.energyMeter124.HighPressureProp = "P_High";
            this.energyMeter124.Location = new System.Drawing.Point(507, 16);
            this.energyMeter124.LowFlow = 10F;
            this.energyMeter124.LowFlowProp = "F_Low";
            this.energyMeter124.LowPressure = 10F;
            this.energyMeter124.LowPressureProp = "P_Low";
            this.energyMeter124.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter124.MaxFlow = 100F;
            this.energyMeter124.MaxFlowProp = "F_Max";
            this.energyMeter124.MaxPressure = 100F;
            this.energyMeter124.MaxPressureProp = "P_Max";
            this.energyMeter124.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1026";
            this.energyMeter124.MinFlow = 0F;
            this.energyMeter124.MinFlowProp = "F_Min";
            this.energyMeter124.MinPressure = 0F;
            this.energyMeter124.MinPressureProp = "P_Min";
            this.energyMeter124.Name = "energyMeter124";
            this.energyMeter124.Pressure = 40F;
            this.energyMeter124.PressureProp = "Pressure";
            this.energyMeter124.Size = new System.Drawing.Size(148, 106);
            this.energyMeter124.TabIndex = 30;
            this.energyMeter124.Tag = "1026";
            this.energyMeter124.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter125
            // 
            this.energyMeter125.Adapter = this.Adapter;
            this.energyMeter125.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter125.Flow = 40F;
            this.energyMeter125.FlowProp = "Flow";
            this.energyMeter125.gbxNameText = "3#铸机";
            this.energyMeter125.HighFlow = 80F;
            this.energyMeter125.HighFlowProp = "F_High";
            this.energyMeter125.HighPressure = 80F;
            this.energyMeter125.HighPressureProp = "P_High";
            this.energyMeter125.Location = new System.Drawing.Point(345, 16);
            this.energyMeter125.LowFlow = 10F;
            this.energyMeter125.LowFlowProp = "F_Low";
            this.energyMeter125.LowPressure = 10F;
            this.energyMeter125.LowPressureProp = "P_Low";
            this.energyMeter125.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter125.MaxFlow = 100F;
            this.energyMeter125.MaxFlowProp = "F_Max";
            this.energyMeter125.MaxPressure = 100F;
            this.energyMeter125.MaxPressureProp = "P_Max";
            this.energyMeter125.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1025";
            this.energyMeter125.MinFlow = 0F;
            this.energyMeter125.MinFlowProp = "F_Min";
            this.energyMeter125.MinPressure = 0F;
            this.energyMeter125.MinPressureProp = "P_Min";
            this.energyMeter125.Name = "energyMeter125";
            this.energyMeter125.Pressure = 40F;
            this.energyMeter125.PressureProp = "Pressure";
            this.energyMeter125.Size = new System.Drawing.Size(148, 106);
            this.energyMeter125.TabIndex = 30;
            this.energyMeter125.Tag = "1025";
            this.energyMeter125.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter126
            // 
            this.energyMeter126.Adapter = this.Adapter;
            this.energyMeter126.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter126.Flow = 40F;
            this.energyMeter126.FlowProp = "Flow";
            this.energyMeter126.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.energyMeter126.gbxNameText = "2#铸机";
            this.energyMeter126.HighFlow = 80F;
            this.energyMeter126.HighFlowProp = "F_High";
            this.energyMeter126.HighPressure = 80F;
            this.energyMeter126.HighPressureProp = "P_High";
            this.energyMeter126.Location = new System.Drawing.Point(183, 16);
            this.energyMeter126.LowFlow = 10F;
            this.energyMeter126.LowFlowProp = "F_Low";
            this.energyMeter126.LowPressure = 10F;
            this.energyMeter126.LowPressureProp = "P_Low";
            this.energyMeter126.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter126.MaxFlow = 100F;
            this.energyMeter126.MaxFlowProp = "F_Max";
            this.energyMeter126.MaxPressure = 100F;
            this.energyMeter126.MaxPressureProp = "P_Max";
            this.energyMeter126.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1024";
            this.energyMeter126.MinFlow = 0F;
            this.energyMeter126.MinFlowProp = "F_Min";
            this.energyMeter126.MinPressure = 0F;
            this.energyMeter126.MinPressureProp = "P_Min";
            this.energyMeter126.Name = "energyMeter126";
            this.energyMeter126.Pressure = 40F;
            this.energyMeter126.PressureProp = "Pressure";
            this.energyMeter126.Size = new System.Drawing.Size(148, 106);
            this.energyMeter126.TabIndex = 30;
            this.energyMeter126.Tag = "1024";
            this.energyMeter126.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter122
            // 
            this.energyMeter122.Adapter = this.Adapter;
            this.energyMeter122.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter122.Flow = 40F;
            this.energyMeter122.FlowProp = "Flow";
            this.energyMeter122.gbxNameText = "11#大包烘烤器";
            this.energyMeter122.HighFlow = 80F;
            this.energyMeter122.HighFlowProp = "F_High";
            this.energyMeter122.HighPressure = 80F;
            this.energyMeter122.HighPressureProp = "P_High";
            this.energyMeter122.Location = new System.Drawing.Point(21, 15);
            this.energyMeter122.LowFlow = 10F;
            this.energyMeter122.LowFlowProp = "F_Low";
            this.energyMeter122.LowPressure = 10F;
            this.energyMeter122.LowPressureProp = "P_Low";
            this.energyMeter122.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter122.MaxFlow = 100F;
            this.energyMeter122.MaxFlowProp = "F_Max";
            this.energyMeter122.MaxPressure = 100F;
            this.energyMeter122.MaxPressureProp = "P_Max";
            this.energyMeter122.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1011";
            this.energyMeter122.MinFlow = 0F;
            this.energyMeter122.MinFlowProp = "F_Min";
            this.energyMeter122.MinPressure = 0F;
            this.energyMeter122.MinPressureProp = "P_Min";
            this.energyMeter122.Name = "energyMeter122";
            this.energyMeter122.Pressure = 40F;
            this.energyMeter122.PressureProp = "Pressure";
            this.energyMeter122.Size = new System.Drawing.Size(148, 106);
            this.energyMeter122.TabIndex = 30;
            this.energyMeter122.Tag = "1011";
            this.energyMeter122.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter11
            // 
            this.energyMeter11.Adapter = this.Adapter;
            this.energyMeter11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter11.Flow = 40F;
            this.energyMeter11.FlowProp = "Flow";
            this.energyMeter11.gbxNameText = "17#大包烘烤器";
            this.energyMeter11.HighFlow = 80F;
            this.energyMeter11.HighFlowProp = "F_High";
            this.energyMeter11.HighPressure = 80F;
            this.energyMeter11.HighPressureProp = "P_High";
            this.energyMeter11.Location = new System.Drawing.Point(507, 15);
            this.energyMeter11.LowFlow = 10F;
            this.energyMeter11.LowFlowProp = "F_Low";
            this.energyMeter11.LowPressure = 10F;
            this.energyMeter11.LowPressureProp = "P_Low";
            this.energyMeter11.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter11.MaxFlow = 100F;
            this.energyMeter11.MaxFlowProp = "F_Max";
            this.energyMeter11.MaxPressure = 100F;
            this.energyMeter11.MaxPressureProp = "P_Max";
            this.energyMeter11.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1017";
            this.energyMeter11.MinFlow = 0F;
            this.energyMeter11.MinFlowProp = "F_Min";
            this.energyMeter11.MinPressure = 0F;
            this.energyMeter11.MinPressureProp = "P_Min";
            this.energyMeter11.Name = "energyMeter11";
            this.energyMeter11.Pressure = 40F;
            this.energyMeter11.PressureProp = "Pressure";
            this.energyMeter11.Size = new System.Drawing.Size(148, 106);
            this.energyMeter11.TabIndex = 30;
            this.energyMeter11.Tag = "1017";
            this.energyMeter11.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter121
            // 
            this.energyMeter121.Adapter = this.Adapter;
            this.energyMeter121.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter121.Flow = 40F;
            this.energyMeter121.FlowProp = "Flow";
            this.energyMeter121.gbxNameText = "13#大包烘烤器";
            this.energyMeter121.HighFlow = 80F;
            this.energyMeter121.HighFlowProp = "F_High";
            this.energyMeter121.HighPressure = 80F;
            this.energyMeter121.HighPressureProp = "P_High";
            this.energyMeter121.Location = new System.Drawing.Point(345, 15);
            this.energyMeter121.LowFlow = 10F;
            this.energyMeter121.LowFlowProp = "F_Low";
            this.energyMeter121.LowPressure = 10F;
            this.energyMeter121.LowPressureProp = "P_Low";
            this.energyMeter121.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter121.MaxFlow = 100F;
            this.energyMeter121.MaxFlowProp = "F_Max";
            this.energyMeter121.MaxPressure = 100F;
            this.energyMeter121.MaxPressureProp = "P_Max";
            this.energyMeter121.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1013";
            this.energyMeter121.MinFlow = 0F;
            this.energyMeter121.MinFlowProp = "F_Min";
            this.energyMeter121.MinPressure = 0F;
            this.energyMeter121.MinPressureProp = "P_Min";
            this.energyMeter121.Name = "energyMeter121";
            this.energyMeter121.Pressure = 40F;
            this.energyMeter121.PressureProp = "Pressure";
            this.energyMeter121.Size = new System.Drawing.Size(148, 106);
            this.energyMeter121.TabIndex = 30;
            this.energyMeter121.Tag = "1013";
            this.energyMeter121.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter120
            // 
            this.energyMeter120.Adapter = this.Adapter;
            this.energyMeter120.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter120.Flow = 40F;
            this.energyMeter120.FlowProp = "Flow";
            this.energyMeter120.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.energyMeter120.gbxNameText = "12#大包烘烤器";
            this.energyMeter120.HighFlow = 80F;
            this.energyMeter120.HighFlowProp = "F_High";
            this.energyMeter120.HighPressure = 80F;
            this.energyMeter120.HighPressureProp = "P_High";
            this.energyMeter120.Location = new System.Drawing.Point(183, 15);
            this.energyMeter120.LowFlow = 10F;
            this.energyMeter120.LowFlowProp = "F_Low";
            this.energyMeter120.LowPressure = 10F;
            this.energyMeter120.LowPressureProp = "P_Low";
            this.energyMeter120.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter120.MaxFlow = 100F;
            this.energyMeter120.MaxFlowProp = "F_Max";
            this.energyMeter120.MaxPressure = 100F;
            this.energyMeter120.MaxPressureProp = "P_Max";
            this.energyMeter120.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1012";
            this.energyMeter120.MinFlow = 0F;
            this.energyMeter120.MinFlowProp = "F_Min";
            this.energyMeter120.MinPressure = 0F;
            this.energyMeter120.MinPressureProp = "P_Min";
            this.energyMeter120.Name = "energyMeter120";
            this.energyMeter120.Pressure = 40F;
            this.energyMeter120.PressureProp = "Pressure";
            this.energyMeter120.Size = new System.Drawing.Size(148, 106);
            this.energyMeter120.TabIndex = 30;
            this.energyMeter120.Tag = "1012";
            this.energyMeter120.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter14
            // 
            this.energyMeter14.Adapter = this.Adapter;
            this.energyMeter14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter14.Flow = 40F;
            this.energyMeter14.FlowProp = "Flow";
            this.energyMeter14.gbxNameText = "7#大包烘烤器";
            this.energyMeter14.HighFlow = 80F;
            this.energyMeter14.HighFlowProp = "F_High";
            this.energyMeter14.HighPressure = 80F;
            this.energyMeter14.HighPressureProp = "P_High";
            this.energyMeter14.Location = new System.Drawing.Point(21, 15);
            this.energyMeter14.LowFlow = 10F;
            this.energyMeter14.LowFlowProp = "F_Low";
            this.energyMeter14.LowPressure = 10F;
            this.energyMeter14.LowPressureProp = "P_Low";
            this.energyMeter14.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter14.MaxFlow = 100F;
            this.energyMeter14.MaxFlowProp = "F_Max";
            this.energyMeter14.MaxPressure = 100F;
            this.energyMeter14.MaxPressureProp = "P_Max";
            this.energyMeter14.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1007";
            this.energyMeter14.MinFlow = 0F;
            this.energyMeter14.MinFlowProp = "F_Min";
            this.energyMeter14.MinPressure = 0F;
            this.energyMeter14.MinPressureProp = "P_Min";
            this.energyMeter14.Name = "energyMeter14";
            this.energyMeter14.Pressure = 40F;
            this.energyMeter14.PressureProp = "Pressure";
            this.energyMeter14.Size = new System.Drawing.Size(148, 106);
            this.energyMeter14.TabIndex = 30;
            this.energyMeter14.Tag = "1007";
            this.energyMeter14.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter119
            // 
            this.energyMeter119.Adapter = this.Adapter;
            this.energyMeter119.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter119.Flow = 40F;
            this.energyMeter119.FlowProp = "Flow";
            this.energyMeter119.gbxNameText = "10#大包烘烤器";
            this.energyMeter119.HighFlow = 80F;
            this.energyMeter119.HighFlowProp = "F_High";
            this.energyMeter119.HighPressure = 80F;
            this.energyMeter119.HighPressureProp = "P_High";
            this.energyMeter119.Location = new System.Drawing.Point(507, 15);
            this.energyMeter119.LowFlow = 10F;
            this.energyMeter119.LowFlowProp = "F_Low";
            this.energyMeter119.LowPressure = 10F;
            this.energyMeter119.LowPressureProp = "P_Low";
            this.energyMeter119.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter119.MaxFlow = 100F;
            this.energyMeter119.MaxFlowProp = "F_Max";
            this.energyMeter119.MaxPressure = 100F;
            this.energyMeter119.MaxPressureProp = "P_Max";
            this.energyMeter119.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1010";
            this.energyMeter119.MinFlow = 0F;
            this.energyMeter119.MinFlowProp = "F_Min";
            this.energyMeter119.MinPressure = 0F;
            this.energyMeter119.MinPressureProp = "P_Min";
            this.energyMeter119.Name = "energyMeter119";
            this.energyMeter119.Pressure = 40F;
            this.energyMeter119.PressureProp = "Pressure";
            this.energyMeter119.Size = new System.Drawing.Size(148, 106);
            this.energyMeter119.TabIndex = 30;
            this.energyMeter119.Tag = "1010";
            this.energyMeter119.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter16
            // 
            this.energyMeter16.Adapter = this.Adapter;
            this.energyMeter16.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter16.Flow = 40F;
            this.energyMeter16.FlowProp = "Flow";
            this.energyMeter16.gbxNameText = "09#大包烘烤器";
            this.energyMeter16.HighFlow = 80F;
            this.energyMeter16.HighFlowProp = "F_High";
            this.energyMeter16.HighPressure = 80F;
            this.energyMeter16.HighPressureProp = "P_High";
            this.energyMeter16.Location = new System.Drawing.Point(345, 15);
            this.energyMeter16.LowFlow = 10F;
            this.energyMeter16.LowFlowProp = "F_Low";
            this.energyMeter16.LowPressure = 10F;
            this.energyMeter16.LowPressureProp = "P_Low";
            this.energyMeter16.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter16.MaxFlow = 100F;
            this.energyMeter16.MaxFlowProp = "F_Max";
            this.energyMeter16.MaxPressure = 100F;
            this.energyMeter16.MaxPressureProp = "P_Max";
            this.energyMeter16.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1009";
            this.energyMeter16.MinFlow = 0F;
            this.energyMeter16.MinFlowProp = "F_Min";
            this.energyMeter16.MinPressure = 0F;
            this.energyMeter16.MinPressureProp = "P_Min";
            this.energyMeter16.Name = "energyMeter16";
            this.energyMeter16.Pressure = 40F;
            this.energyMeter16.PressureProp = "Pressure";
            this.energyMeter16.Size = new System.Drawing.Size(148, 106);
            this.energyMeter16.TabIndex = 30;
            this.energyMeter16.Tag = "1009";
            this.energyMeter16.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter15
            // 
            this.energyMeter15.Adapter = this.Adapter;
            this.energyMeter15.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter15.Flow = 40F;
            this.energyMeter15.FlowProp = "Flow";
            this.energyMeter15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.energyMeter15.gbxNameText = "08#大包烘烤器";
            this.energyMeter15.HighFlow = 80F;
            this.energyMeter15.HighFlowProp = "F_High";
            this.energyMeter15.HighPressure = 80F;
            this.energyMeter15.HighPressureProp = "P_High";
            this.energyMeter15.Location = new System.Drawing.Point(183, 15);
            this.energyMeter15.LowFlow = 10F;
            this.energyMeter15.LowFlowProp = "F_Low";
            this.energyMeter15.LowPressure = 10F;
            this.energyMeter15.LowPressureProp = "P_Low";
            this.energyMeter15.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter15.MaxFlow = 100F;
            this.energyMeter15.MaxFlowProp = "F_Max";
            this.energyMeter15.MaxPressure = 100F;
            this.energyMeter15.MaxPressureProp = "P_Max";
            this.energyMeter15.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1008";
            this.energyMeter15.MinFlow = 0F;
            this.energyMeter15.MinFlowProp = "F_Min";
            this.energyMeter15.MinPressure = 0F;
            this.energyMeter15.MinPressureProp = "P_Min";
            this.energyMeter15.Name = "energyMeter15";
            this.energyMeter15.Pressure = 40F;
            this.energyMeter15.PressureProp = "Pressure";
            this.energyMeter15.Size = new System.Drawing.Size(148, 106);
            this.energyMeter15.TabIndex = 30;
            this.energyMeter15.Tag = "1008";
            this.energyMeter15.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter115
            // 
            this.energyMeter115.Adapter = this.Adapter;
            this.energyMeter115.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter115.Flow = 40F;
            this.energyMeter115.FlowProp = "Flow";
            this.energyMeter115.gbxNameText = "6#大包烘烤器";
            this.energyMeter115.HighFlow = 80F;
            this.energyMeter115.HighFlowProp = "F_High";
            this.energyMeter115.HighPressure = 80F;
            this.energyMeter115.HighPressureProp = "P_High";
            this.energyMeter115.Location = new System.Drawing.Point(21, 125);
            this.energyMeter115.LowFlow = 10F;
            this.energyMeter115.LowFlowProp = "F_Low";
            this.energyMeter115.LowPressure = 10F;
            this.energyMeter115.LowPressureProp = "P_Low";
            this.energyMeter115.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter115.MaxFlow = 100F;
            this.energyMeter115.MaxFlowProp = "F_Max";
            this.energyMeter115.MaxPressure = 100F;
            this.energyMeter115.MaxPressureProp = "P_Max";
            this.energyMeter115.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1006";
            this.energyMeter115.MinFlow = 0F;
            this.energyMeter115.MinFlowProp = "F_Min";
            this.energyMeter115.MinPressure = 0F;
            this.energyMeter115.MinPressureProp = "P_Min";
            this.energyMeter115.Name = "energyMeter115";
            this.energyMeter115.Pressure = 40F;
            this.energyMeter115.PressureProp = "Pressure";
            this.energyMeter115.Size = new System.Drawing.Size(148, 106);
            this.energyMeter115.TabIndex = 30;
            this.energyMeter115.Tag = "1006";
            this.energyMeter115.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter114
            // 
            this.energyMeter114.Adapter = this.Adapter;
            this.energyMeter114.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter114.Flow = 40F;
            this.energyMeter114.FlowProp = "Flow";
            this.energyMeter114.gbxNameText = "5#大包烘烤器";
            this.energyMeter114.HighFlow = 80F;
            this.energyMeter114.HighFlowProp = "F_High";
            this.energyMeter114.HighPressure = 80F;
            this.energyMeter114.HighPressureProp = "P_High";
            this.energyMeter114.Location = new System.Drawing.Point(669, 19);
            this.energyMeter114.LowFlow = 10F;
            this.energyMeter114.LowFlowProp = "F_Low";
            this.energyMeter114.LowPressure = 10F;
            this.energyMeter114.LowPressureProp = "P_Low";
            this.energyMeter114.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter114.MaxFlow = 100F;
            this.energyMeter114.MaxFlowProp = "F_Max";
            this.energyMeter114.MaxPressure = 100F;
            this.energyMeter114.MaxPressureProp = "P_Max";
            this.energyMeter114.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1005";
            this.energyMeter114.MinFlow = 0F;
            this.energyMeter114.MinFlowProp = "F_Min";
            this.energyMeter114.MinPressure = 0F;
            this.energyMeter114.MinPressureProp = "P_Min";
            this.energyMeter114.Name = "energyMeter114";
            this.energyMeter114.Pressure = 40F;
            this.energyMeter114.PressureProp = "Pressure";
            this.energyMeter114.Size = new System.Drawing.Size(148, 106);
            this.energyMeter114.TabIndex = 30;
            this.energyMeter114.Tag = "1005";
            this.energyMeter114.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter113
            // 
            this.energyMeter113.Adapter = this.Adapter;
            this.energyMeter113.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter113.Flow = 40F;
            this.energyMeter113.FlowProp = "Flow";
            this.energyMeter113.gbxNameText = "4#大包烘烤器";
            this.energyMeter113.HighFlow = 80F;
            this.energyMeter113.HighFlowProp = "F_High";
            this.energyMeter113.HighPressure = 80F;
            this.energyMeter113.HighPressureProp = "P_High";
            this.energyMeter113.Location = new System.Drawing.Point(507, 19);
            this.energyMeter113.LowFlow = 10F;
            this.energyMeter113.LowFlowProp = "F_Low";
            this.energyMeter113.LowPressure = 10F;
            this.energyMeter113.LowPressureProp = "P_Low";
            this.energyMeter113.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter113.MaxFlow = 100F;
            this.energyMeter113.MaxFlowProp = "F_Max";
            this.energyMeter113.MaxPressure = 100F;
            this.energyMeter113.MaxPressureProp = "P_Max";
            this.energyMeter113.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1004";
            this.energyMeter113.MinFlow = 0F;
            this.energyMeter113.MinFlowProp = "F_Min";
            this.energyMeter113.MinPressure = 0F;
            this.energyMeter113.MinPressureProp = "P_Min";
            this.energyMeter113.Name = "energyMeter113";
            this.energyMeter113.Pressure = 40F;
            this.energyMeter113.PressureProp = "Pressure";
            this.energyMeter113.Size = new System.Drawing.Size(148, 106);
            this.energyMeter113.TabIndex = 30;
            this.energyMeter113.Tag = "1004";
            this.energyMeter113.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter112
            // 
            this.energyMeter112.Adapter = this.Adapter;
            this.energyMeter112.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter112.Flow = 40F;
            this.energyMeter112.FlowProp = "Flow";
            this.energyMeter112.gbxNameText = "3#大包烘烤器";
            this.energyMeter112.HighFlow = 80F;
            this.energyMeter112.HighFlowProp = "F_High";
            this.energyMeter112.HighPressure = 80F;
            this.energyMeter112.HighPressureProp = "P_High";
            this.energyMeter112.Location = new System.Drawing.Point(345, 19);
            this.energyMeter112.LowFlow = 10F;
            this.energyMeter112.LowFlowProp = "F_Low";
            this.energyMeter112.LowPressure = 10F;
            this.energyMeter112.LowPressureProp = "P_Low";
            this.energyMeter112.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter112.MaxFlow = 100F;
            this.energyMeter112.MaxFlowProp = "F_Max";
            this.energyMeter112.MaxPressure = 100F;
            this.energyMeter112.MaxPressureProp = "P_Max";
            this.energyMeter112.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1003";
            this.energyMeter112.MinFlow = 0F;
            this.energyMeter112.MinFlowProp = "F_Min";
            this.energyMeter112.MinPressure = 0F;
            this.energyMeter112.MinPressureProp = "P_Min";
            this.energyMeter112.Name = "energyMeter112";
            this.energyMeter112.Pressure = 40F;
            this.energyMeter112.PressureProp = "Pressure";
            this.energyMeter112.Size = new System.Drawing.Size(148, 106);
            this.energyMeter112.TabIndex = 30;
            this.energyMeter112.Tag = "1003";
            this.energyMeter112.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter111
            // 
            this.energyMeter111.Adapter = this.Adapter;
            this.energyMeter111.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter111.Flow = 40F;
            this.energyMeter111.FlowProp = "Flow";
            this.energyMeter111.gbxNameText = "2#大包烘烤器";
            this.energyMeter111.HighFlow = 80F;
            this.energyMeter111.HighFlowProp = "F_High";
            this.energyMeter111.HighPressure = 80F;
            this.energyMeter111.HighPressureProp = "P_High";
            this.energyMeter111.Location = new System.Drawing.Point(183, 19);
            this.energyMeter111.LowFlow = 10F;
            this.energyMeter111.LowFlowProp = "F_Low";
            this.energyMeter111.LowPressure = 10F;
            this.energyMeter111.LowPressureProp = "P_Low";
            this.energyMeter111.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter111.MaxFlow = 100F;
            this.energyMeter111.MaxFlowProp = "F_Max";
            this.energyMeter111.MaxPressure = 100F;
            this.energyMeter111.MaxPressureProp = "P_Max";
            this.energyMeter111.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1002";
            this.energyMeter111.MinFlow = 0F;
            this.energyMeter111.MinFlowProp = "F_Min";
            this.energyMeter111.MinPressure = 0F;
            this.energyMeter111.MinPressureProp = "P_Min";
            this.energyMeter111.Name = "energyMeter111";
            this.energyMeter111.Pressure = 40F;
            this.energyMeter111.PressureProp = "Pressure";
            this.energyMeter111.Size = new System.Drawing.Size(148, 106);
            this.energyMeter111.TabIndex = 30;
            this.energyMeter111.Tag = "1002";
            this.energyMeter111.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter118
            // 
            this.energyMeter118.Adapter = this.Adapter;
            this.energyMeter118.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter118.Flow = 40F;
            this.energyMeter118.FlowProp = "Flow";
            this.energyMeter118.gbxNameText = "16#大包烘烤器";
            this.energyMeter118.HighFlow = 80F;
            this.energyMeter118.HighFlowProp = "F_High";
            this.energyMeter118.HighPressure = 80F;
            this.energyMeter118.HighPressureProp = "P_High";
            this.energyMeter118.Location = new System.Drawing.Point(507, 125);
            this.energyMeter118.LowFlow = 10F;
            this.energyMeter118.LowFlowProp = "F_Low";
            this.energyMeter118.LowPressure = 10F;
            this.energyMeter118.LowPressureProp = "P_Low";
            this.energyMeter118.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter118.MaxFlow = 100F;
            this.energyMeter118.MaxFlowProp = "F_Max";
            this.energyMeter118.MaxPressure = 100F;
            this.energyMeter118.MaxPressureProp = "P_Max";
            this.energyMeter118.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1016";
            this.energyMeter118.MinFlow = 0F;
            this.energyMeter118.MinFlowProp = "F_Min";
            this.energyMeter118.MinPressure = 0F;
            this.energyMeter118.MinPressureProp = "P_Min";
            this.energyMeter118.Name = "energyMeter118";
            this.energyMeter118.Pressure = 40F;
            this.energyMeter118.PressureProp = "Pressure";
            this.energyMeter118.Size = new System.Drawing.Size(148, 106);
            this.energyMeter118.TabIndex = 30;
            this.energyMeter118.Tag = "1016";
            this.energyMeter118.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter117
            // 
            this.energyMeter117.Adapter = this.Adapter;
            this.energyMeter117.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter117.Flow = 40F;
            this.energyMeter117.FlowProp = "Flow";
            this.energyMeter117.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.energyMeter117.gbxNameText = "15#大包烘烤器";
            this.energyMeter117.HighFlow = 80F;
            this.energyMeter117.HighFlowProp = "F_High";
            this.energyMeter117.HighPressure = 80F;
            this.energyMeter117.HighPressureProp = "P_High";
            this.energyMeter117.Location = new System.Drawing.Point(345, 125);
            this.energyMeter117.LowFlow = 10F;
            this.energyMeter117.LowFlowProp = "F_Low";
            this.energyMeter117.LowPressure = 10F;
            this.energyMeter117.LowPressureProp = "P_Low";
            this.energyMeter117.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter117.MaxFlow = 100F;
            this.energyMeter117.MaxFlowProp = "F_Max";
            this.energyMeter117.MaxPressure = 100F;
            this.energyMeter117.MaxPressureProp = "P_Max";
            this.energyMeter117.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1015";
            this.energyMeter117.MinFlow = 0F;
            this.energyMeter117.MinFlowProp = "F_Min";
            this.energyMeter117.MinPressure = 0F;
            this.energyMeter117.MinPressureProp = "P_Min";
            this.energyMeter117.Name = "energyMeter117";
            this.energyMeter117.Pressure = 40F;
            this.energyMeter117.PressureProp = "Pressure";
            this.energyMeter117.Size = new System.Drawing.Size(148, 106);
            this.energyMeter117.TabIndex = 30;
            this.energyMeter117.Tag = "1015";
            this.energyMeter117.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter116
            // 
            this.energyMeter116.Adapter = this.Adapter;
            this.energyMeter116.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter116.Flow = 40F;
            this.energyMeter116.FlowProp = "Flow";
            this.energyMeter116.gbxNameText = "14#大包烘烤器";
            this.energyMeter116.HighFlow = 80F;
            this.energyMeter116.HighFlowProp = "F_High";
            this.energyMeter116.HighPressure = 80F;
            this.energyMeter116.HighPressureProp = "P_High";
            this.energyMeter116.Location = new System.Drawing.Point(183, 124);
            this.energyMeter116.LowFlow = 10F;
            this.energyMeter116.LowFlowProp = "F_Low";
            this.energyMeter116.LowPressure = 10F;
            this.energyMeter116.LowPressureProp = "P_Low";
            this.energyMeter116.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter116.MaxFlow = 100F;
            this.energyMeter116.MaxFlowProp = "F_Max";
            this.energyMeter116.MaxPressure = 100F;
            this.energyMeter116.MaxPressureProp = "P_Max";
            this.energyMeter116.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1014";
            this.energyMeter116.MinFlow = 0F;
            this.energyMeter116.MinFlowProp = "F_Min";
            this.energyMeter116.MinPressure = 0F;
            this.energyMeter116.MinPressureProp = "P_Min";
            this.energyMeter116.Name = "energyMeter116";
            this.energyMeter116.Pressure = 40F;
            this.energyMeter116.PressureProp = "Pressure";
            this.energyMeter116.Size = new System.Drawing.Size(148, 106);
            this.energyMeter116.TabIndex = 30;
            this.energyMeter116.Tag = "1014";
            this.energyMeter116.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // energyMeter110
            // 
            this.energyMeter110.Adapter = this.Adapter;
            this.energyMeter110.BackColor = System.Drawing.SystemColors.ControlDark;
            this.energyMeter110.Flow = 40F;
            this.energyMeter110.FlowProp = "Flow";
            this.energyMeter110.gbxNameText = "1#大包烘烤器";
            this.energyMeter110.HighFlow = 80F;
            this.energyMeter110.HighFlowProp = "F_High";
            this.energyMeter110.HighPressure = 80F;
            this.energyMeter110.HighPressureProp = "P_High";
            this.energyMeter110.Location = new System.Drawing.Point(21, 19);
            this.energyMeter110.LowFlow = 10F;
            this.energyMeter110.LowFlowProp = "F_Low";
            this.energyMeter110.LowPressure = 10F;
            this.energyMeter110.LowPressureProp = "P_Low";
            this.energyMeter110.Margin = new System.Windows.Forms.Padding(0);
            this.energyMeter110.MaxFlow = 100F;
            this.energyMeter110.MaxFlowProp = "F_Max";
            this.energyMeter110.MaxPressure = 100F;
            this.energyMeter110.MaxPressureProp = "P_Max";
            this.energyMeter110.MeterObject = "XGMESLogic\\EnergyMag\\CEnergyRunTimeData\\1001";
            this.energyMeter110.MinFlow = 0F;
            this.energyMeter110.MinFlowProp = "F_Min";
            this.energyMeter110.MinPressure = 0F;
            this.energyMeter110.MinPressureProp = "P_Min";
            this.energyMeter110.Name = "energyMeter110";
            this.energyMeter110.Pressure = 40F;
            this.energyMeter110.PressureProp = "Pressure";
            this.energyMeter110.Size = new System.Drawing.Size(148, 106);
            this.energyMeter110.TabIndex = 30;
            this.energyMeter110.Tag = "1001";
            this.energyMeter110.UserBtn_DoubleClick += new System.EventHandler(this.energyMeter_UserBtn_DoubleClick);
            // 
            // FireDataFrm
            // 
            this.Adapter.SetAccessRight(this, "EnergyMain");
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 650);
            this.Controls.Add(this.gbxCCM5);
            this.Controls.Add(this.groupBox24);
            this.Controls.Add(this.gbxMIF);
            this.Controls.Add(this.gbxCCMHotFire);
            this.Controls.Add(this.gbxSide4);
            this.Controls.Add(this.gbxTransition);
            this.Controls.Add(this.gbxSlag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FireDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "烘烤流量监视";
            this.Text = "烘烤流量监视";
            this.Load += new System.EventHandler(this.FireDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxSlag.ResumeLayout(false);
            this.gbxTransition.ResumeLayout(false);
            this.gbxSide4.ResumeLayout(false);
            this.gbxMIF.ResumeLayout(false);
            this.groupBox24.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbxCCM5.ResumeLayout(false);
            this.gbxCCMHotFire.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxSlag;
        private System.Windows.Forms.GroupBox gbxTransition;
        private System.Windows.Forms.GroupBox gbxSide4;
        private System.Windows.Forms.GroupBox gbxMIF;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.GroupBox gbxCCM5;
        private EnergyMeter1 energyMeter110;
        private EnergyMeter1 energyMeter111;
        private EnergyMeter1 energyMeter115;
        private EnergyMeter1 energyMeter114;
        private EnergyMeter1 energyMeter113;
        private EnergyMeter1 energyMeter112;
        private EnergyMeter1 energyMeter118;
        private EnergyMeter1 energyMeter117;
        private EnergyMeter1 energyMeter116;
        private EnergyMeter1 energyMeter14;
        private EnergyMeter1 energyMeter119;
        private EnergyMeter1 energyMeter16;
        private EnergyMeter1 energyMeter15;
        private EnergyMeter1 energyMeter122;
        private EnergyMeter1 energyMeter11;
        private EnergyMeter1 energyMeter121;
        private EnergyMeter1 energyMeter120;
        private EnergyMeter1 energyMeter13;
        private EnergyMeter1 energyMeter12;
        private EnergyMeter1 energyMeter17;
        private System.Windows.Forms.GroupBox groupBox1;
        private EnergyMeter energyMeter1;
        private EnergyMeter1 energyMeter19;
        private EnergyMeter1 energyMeter18;
        private System.Windows.Forms.GroupBox gbxCCMHotFire;
        private EnergyMeter1 energyMeter123;
        private EnergyMeter1 energyMeter127;
        private EnergyMeter1 energyMeter124;
        private EnergyMeter1 energyMeter125;
        private EnergyMeter1 energyMeter126;
    }
}