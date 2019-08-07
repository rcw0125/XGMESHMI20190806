namespace UnitMag.CCMMag
{
    partial class CCMTCDataFrm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dbxTreatNO = new AppSvrHMI.L3DataBox();
            this.txtCCMID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bsProcessData = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcessData = new AppSvrHMI.L3DataSet();
            this.schemadsProcessData = new System.Data.DataTable();
            this.coldsProcessDataL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsProcessDataL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProcessDataL3DataTableCastingNo = new System.Data.DataColumn();
            this.coldsProcessDataL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsProcessDataL3DataTableTundishNo = new System.Data.DataColumn();
            this.coldsProcessDataL3DataTableTundishCar_Type = new System.Data.DataColumn();
            this.coldsProcessDataL3DataTableCasting_HeatNum = new System.Data.DataColumn();
            this.coldsProcessDataL3DataTableTundish_HeatNum = new System.Data.DataColumn();
            this.l3cmdpdsRefra = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myLine = new buttonHide.MyLine();
            this.txtHeatID = new System.Windows.Forms.TextBox();
            this.txtTundishHeatNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCastingHeatNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTundishNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCastingNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcessData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcessData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcessData)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(276, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 75;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dbxTreatNO);
            this.panel3.Controls.Add(this.txtCCMID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 29);
            this.panel3.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 76;
            this.label2.Text = "处理号:";
            // 
            // dbxTreatNO
            // 
            this.dbxTreatNO.DataFormat = null;
            this.dbxTreatNO.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.dbxTreatNO.DataProperty = "TreatNo";
            this.dbxTreatNO.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxTreatNO.L3DataAdapter = this.Adapter;
            this.dbxTreatNO.Location = new System.Drawing.Point(269, 4);
            this.dbxTreatNO.Name = "dbxTreatNO";
            this.dbxTreatNO.ReadOnly = true;
            this.dbxTreatNO.Size = new System.Drawing.Size(100, 21);
            this.dbxTreatNO.TabIndex = 75;
            this.dbxTreatNO.Value = null;
            // 
            // txtCCMID
            // 
            this.txtCCMID.Location = new System.Drawing.Point(110, 4);
            this.txtCCMID.Name = "txtCCMID";
            this.txtCCMID.ReadOnly = true;
            this.txtCCMID.Size = new System.Drawing.Size(100, 21);
            this.txtCCMID.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(60, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "铸机号:";
            // 
            // bsProcessData
            // 
            this.bsProcessData.DataMember = "L3DataTable";
            this.bsProcessData.DataSource = this.dsProcessData;
            // 
            // dsProcessData
            // 
            this.dsProcessData.AutoLoad = true;
            this.dsProcessData.AutoSubscribe = false;
            this.dsProcessData.DataSetName = "L3DataSet";
            this.dsProcessData.DeleteMethod = "";
            this.dsProcessData.InsertMethod = "";
            this.dsProcessData.L3DataAdapter = this.Adapter;
            this.dsProcessData.LoadEvent = "";
            this.dsProcessData.LoadTrigger = null;
            this.dsProcessData.RefreshValve = 1000;
            this.dsProcessData.SourceCommand = null;
            this.dsProcessData.SourceCondition = "1=2";
            this.dsProcessData.SourceMethod = "";
            this.dsProcessData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcessData.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Process_Data";
            this.dsProcessData.SubscribeTarget = "";
            this.dsProcessData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcessData});
            this.dsProcessData.UpdateEvent = "";
            this.dsProcessData.UpdateMethod = "";
            this.dsProcessData.UpdateTrigger = null;
            // 
            // schemadsProcessData
            // 
            this.schemadsProcessData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcessDataL3DataTableTreatNo,
            this.coldsProcessDataL3DataTableHeatID,
            this.coldsProcessDataL3DataTableCastingNo,
            this.coldsProcessDataL3DataTableCCMID,
            this.coldsProcessDataL3DataTableTundishNo,
            this.coldsProcessDataL3DataTableTundishCar_Type,
            this.coldsProcessDataL3DataTableCasting_HeatNum,
            this.coldsProcessDataL3DataTableTundish_HeatNum});
            this.schemadsProcessData.TableName = "L3DataTable";
            // 
            // coldsProcessDataL3DataTableTreatNo
            // 
            this.coldsProcessDataL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsProcessDataL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsProcessDataL3DataTableTreatNo.Namespace = "";
            // 
            // coldsProcessDataL3DataTableHeatID
            // 
            this.coldsProcessDataL3DataTableHeatID.Caption = "HeatID";
            this.coldsProcessDataL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProcessDataL3DataTableHeatID.Namespace = "";
            // 
            // coldsProcessDataL3DataTableCastingNo
            // 
            this.coldsProcessDataL3DataTableCastingNo.Caption = "CastingNo";
            this.coldsProcessDataL3DataTableCastingNo.ColumnName = "CastingNo";
            this.coldsProcessDataL3DataTableCastingNo.Namespace = "";
            // 
            // coldsProcessDataL3DataTableCCMID
            // 
            this.coldsProcessDataL3DataTableCCMID.Caption = "CCMID";
            this.coldsProcessDataL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsProcessDataL3DataTableCCMID.Namespace = "";
            // 
            // coldsProcessDataL3DataTableTundishNo
            // 
            this.coldsProcessDataL3DataTableTundishNo.Caption = "TundishNo";
            this.coldsProcessDataL3DataTableTundishNo.ColumnName = "TundishNo";
            this.coldsProcessDataL3DataTableTundishNo.Namespace = "";
            // 
            // coldsProcessDataL3DataTableTundishCar_Type
            // 
            this.coldsProcessDataL3DataTableTundishCar_Type.Caption = "TundishCar_Type";
            this.coldsProcessDataL3DataTableTundishCar_Type.ColumnName = "TundishCar_Type";
            this.coldsProcessDataL3DataTableTundishCar_Type.Namespace = "";
            // 
            // coldsProcessDataL3DataTableCasting_HeatNum
            // 
            this.coldsProcessDataL3DataTableCasting_HeatNum.Caption = "Casting_HeatNum";
            this.coldsProcessDataL3DataTableCasting_HeatNum.ColumnName = "Casting_HeatNum";
            this.coldsProcessDataL3DataTableCasting_HeatNum.DataType = typeof(int);
            this.coldsProcessDataL3DataTableCasting_HeatNum.Namespace = "";
            // 
            // coldsProcessDataL3DataTableTundish_HeatNum
            // 
            this.coldsProcessDataL3DataTableTundish_HeatNum.Caption = "Tundish_HeatNum";
            this.coldsProcessDataL3DataTableTundish_HeatNum.ColumnName = "Tundish_HeatNum";
            this.coldsProcessDataL3DataTableTundish_HeatNum.DataType = typeof(int);
            this.coldsProcessDataL3DataTableTundish_HeatNum.Namespace = "";
            // 
            // l3cmdpdsRefra
            // 
            this.l3cmdpdsRefra.AcceptAfterExecuted = false;
            this.l3cmdpdsRefra.ConstantValue = null;
            this.l3cmdpdsRefra.MergeTarget = false;
            this.l3cmdpdsRefra.SourceFilter = null;
            this.l3cmdpdsRefra.SourceObject = null;
            this.l3cmdpdsRefra.SourceProperty = "";
            this.l3cmdpdsRefra.TargetObject = null;
            this.l3cmdpdsRefra.TargetProperty = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 252);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 43);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 223);
            this.tabControl1.TabIndex = 84;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.myLine);
            this.tabPage1.Controls.Add(this.txtHeatID);
            this.tabPage1.Controls.Add(this.txtTundishHeatNum);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCastingHeatNum);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTundishNo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCastingNo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "连铸实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myLine
            // 
            this.myLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.myLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myLine.Location = new System.Drawing.Point(61, 25);
            this.myLine.Name = "myLine";
            this.myLine.Size = new System.Drawing.Size(300, 3);
            this.myLine.TabIndex = 5;
            // 
            // txtHeatID
            // 
            this.txtHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcessData, "HeatID", true));
            this.txtHeatID.Location = new System.Drawing.Point(157, 34);
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.ReadOnly = true;
            this.txtHeatID.Size = new System.Drawing.Size(185, 21);
            this.txtHeatID.TabIndex = 3;
            // 
            // txtTundishHeatNum
            // 
            this.txtTundishHeatNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcessData, "Tundish_HeatNum", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtTundishHeatNum.Location = new System.Drawing.Point(157, 138);
            this.txtTundishHeatNum.Name = "txtTundishHeatNum";
            this.txtTundishHeatNum.Size = new System.Drawing.Size(185, 21);
            this.txtTundishHeatNum.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "包次内炉数:";
            // 
            // txtCastingHeatNum
            // 
            this.txtCastingHeatNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcessData, "Casting_HeatNum", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtCastingHeatNum.Location = new System.Drawing.Point(157, 112);
            this.txtCastingHeatNum.Name = "txtCastingHeatNum";
            this.txtCastingHeatNum.Size = new System.Drawing.Size(185, 21);
            this.txtCastingHeatNum.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "浇次内炉数:";
            // 
            // txtTundishNo
            // 
            this.txtTundishNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcessData, "TundishNo", true));
            this.txtTundishNo.Location = new System.Drawing.Point(157, 86);
            this.txtTundishNo.Name = "txtTundishNo";
            this.txtTundishNo.ReadOnly = true;
            this.txtTundishNo.Size = new System.Drawing.Size(185, 21);
            this.txtTundishNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "包次号:";
            // 
            // txtCastingNo
            // 
            this.txtCastingNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcessData, "CastingNo", true));
            this.txtCastingNo.Location = new System.Drawing.Point(157, 60);
            this.txtCastingNo.Name = "txtCastingNo";
            this.txtCastingNo.ReadOnly = true;
            this.txtCastingNo.Size = new System.Drawing.Size(185, 21);
            this.txtCastingNo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "浇次号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "炉号:";
            // 
            // CCMTCDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 295);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CCMTCDataFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "连铸实绩包次浇次内炉数修正";
            this.Load += new System.EventHandler(this.CCMTCDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcessData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcessData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcessData)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private AppSvrHMI.L3CommandParameter l3cmdpdsRefra;
        private System.Windows.Forms.TextBox txtCCMID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCastingNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeatID;
        private System.Windows.Forms.Label label1;
        private buttonHide.MyLine myLine;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataBox dbxTreatNO;
        private AppSvrHMI.L3DataSet dsProcessData;
        private System.Windows.Forms.TextBox txtTundishHeatNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCastingHeatNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTundishNo;
        private System.Windows.Forms.Label label3;
        private System.Data.DataTable schemadsProcessData;
        private System.Data.DataColumn coldsProcessDataL3DataTableTreatNo;
        private System.Data.DataColumn coldsProcessDataL3DataTableHeatID;
        private System.Data.DataColumn coldsProcessDataL3DataTableCastingNo;
        private System.Data.DataColumn coldsProcessDataL3DataTableCCMID;
        private System.Data.DataColumn coldsProcessDataL3DataTableTundishNo;
        private System.Data.DataColumn coldsProcessDataL3DataTableTundishCar_Type;
        private System.Data.DataColumn coldsProcessDataL3DataTableCasting_HeatNum;
        private System.Data.DataColumn coldsProcessDataL3DataTableTundish_HeatNum;
        private System.Windows.Forms.BindingSource bsProcessData;
    }
}