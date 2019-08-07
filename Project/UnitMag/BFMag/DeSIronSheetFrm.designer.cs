namespace UnitMag.BFMag
{
    partial class DeSIronSheetFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myLine1 = new buttonHide.MyLine();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHeatName = new System.Windows.Forms.Label();
            this.cmbBFID = new PxDataValid.PxComboBox();
            this.cmbTpcNo = new PxDataValid.PxComboBox();
            this.bsTpcNo = new System.Windows.Forms.BindingSource(this.components);
            this.dsTpcNo = new AppSvrHMI.L3DataSet();
            this.schemadsTpcNo = new System.Data.DataTable();
            this.coldsTpcNoL3DataTableTpc_No = new System.Data.DataColumn();
            this.cmbTapNo = new PxDataValid.PxComboBox();
            this.bsTapNo = new System.Windows.Forms.BindingSource(this.components);
            this.dsTapNo = new AppSvrHMI.L3DataSet();
            this.schemadsTapNo = new System.Data.DataTable();
            this.coldsTapNoL3DataTableTAP_No = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsSend = new AppSvrHMI.L3DataSet();
            this.schemadsSend = new System.Data.DataTable();
            this.coldsSendL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsSendL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsSendL3DataTableMode = new System.Data.DataColumn();
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableBFID = new System.Data.DataColumn();
            this.coldsMainL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsMainL3DataTableTPC_No = new System.Data.DataColumn();
            this.cmdSend = new AppSvrHMI.L3Command(this.components);
            this.cmdpSend = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTpcNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTpcNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTpcNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(306, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(225, 10);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 205);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbHeatName);
            this.tabPage1.Controls.Add(this.cmbBFID);
            this.tabPage1.Controls.Add(this.cmbTpcNo);
            this.tabPage1.Controls.Add(this.cmbTapNo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "申请信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(142, 133);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(153, 2);
            this.myLine1.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(224, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "脱硫后样";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(142, 116);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "脱硫前样";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "铁水罐号:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "铁次号:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbHeatName
            // 
            this.lbHeatName.AutoSize = true;
            this.lbHeatName.Location = new System.Drawing.Point(75, 19);
            this.lbHeatName.Name = "lbHeatName";
            this.lbHeatName.Size = new System.Drawing.Size(59, 12);
            this.lbHeatName.TabIndex = 4;
            this.lbHeatName.Text = "高炉炉号:";
            this.lbHeatName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbBFID
            // 
            this.cmbBFID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBFID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBFID.EnableNull = true;
            this.cmbBFID.ErropPr = null;
            this.cmbBFID.FormattingEnabled = true;
            this.cmbBFID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbBFID.Location = new System.Drawing.Point(142, 16);
            this.cmbBFID.Name = "cmbBFID";
            //
            this.cmbBFID.Size = new System.Drawing.Size(153, 20);
            this.cmbBFID.TabIndex = 0;
            //
            this.cmbBFID.ToolTipValid = null;
            this.cmbBFID.ValidEable = true;
            this.cmbBFID.SelectedIndexChanged += new System.EventHandler(this.cmbBFID_SelectedIndexChanged);
            // 
            // cmbTpcNo
            // 
            this.cmbTpcNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTpcNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTpcNo.DataSource = this.bsTpcNo;
            this.cmbTpcNo.DisplayMember = "Tpc_No";
            this.cmbTpcNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTpcNo.EnableNull = true;
            this.cmbTpcNo.ErropPr = null;
            this.cmbTpcNo.FormattingEnabled = true;
            this.cmbTpcNo.Location = new System.Drawing.Point(142, 80);
            this.cmbTpcNo.Name = "cmbTpcNo";
            //
            this.cmbTpcNo.Size = new System.Drawing.Size(153, 20);
            this.cmbTpcNo.TabIndex = 0;
            //
            this.cmbTpcNo.ToolTipValid = null;
            this.cmbTpcNo.ValidEable = true;
            this.cmbTpcNo.ValueMember = "Tpc_No";
            this.cmbTpcNo.SelectedIndexChanged += new System.EventHandler(this.cmbTpcNo_SelectedIndexChanged);
            // 
            // bsTpcNo
            // 
            this.bsTpcNo.DataMember = "L3DataTable";
            this.bsTpcNo.DataSource = this.dsTpcNo;
            this.bsTpcNo.Sort = "Tpc_No";
            // 
            // dsTpcNo
            // 
            this.dsTpcNo.AutoLoad = true;
            this.dsTpcNo.AutoSubscribe = false;
            this.dsTpcNo.DataSetName = "L3DataSet";
            this.dsTpcNo.DeleteMethod = "";
            this.dsTpcNo.InsertMethod = "";
            this.dsTpcNo.L3DataAdapter = null;
            this.dsTpcNo.LoadEvent = "";
            this.dsTpcNo.LoadTrigger = null;
            this.dsTpcNo.RefreshValve = 1000;
            this.dsTpcNo.SourceCommand = null;
            this.dsTpcNo.SourceCondition = "";
            this.dsTpcNo.SourceMethod = "";
            this.dsTpcNo.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsTpcNo.SourceURI = "";
            this.dsTpcNo.SubscribeTarget = null;
            this.dsTpcNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTpcNo});
            this.dsTpcNo.UpdateEvent = "";
            this.dsTpcNo.UpdateMethod = "";
            this.dsTpcNo.UpdateTrigger = null;
            // 
            // schemadsTpcNo
            // 
            this.schemadsTpcNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTpcNoL3DataTableTpc_No});
            this.schemadsTpcNo.TableName = "L3DataTable";
            // 
            // coldsTpcNoL3DataTableTpc_No
            // 
            this.coldsTpcNoL3DataTableTpc_No.Caption = "Tpc_No";
            this.coldsTpcNoL3DataTableTpc_No.ColumnName = "Tpc_No";
            this.coldsTpcNoL3DataTableTpc_No.Namespace = "";
            // 
            // cmbTapNo
            // 
            this.cmbTapNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTapNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTapNo.DataSource = this.bsTapNo;
            this.cmbTapNo.DisplayMember = "TAP_No";
            this.cmbTapNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTapNo.EnableNull = true;
            this.cmbTapNo.ErropPr = null;
            this.cmbTapNo.FormattingEnabled = true;
            this.cmbTapNo.Location = new System.Drawing.Point(142, 48);
            this.cmbTapNo.Name = "cmbTapNo";
            //
            this.cmbTapNo.Size = new System.Drawing.Size(153, 20);
            this.cmbTapNo.TabIndex = 0;
            //
            this.cmbTapNo.ToolTipValid = null;
            this.cmbTapNo.ValidEable = true;
            this.cmbTapNo.ValueMember = "TAP_No";
            this.cmbTapNo.SelectedIndexChanged += new System.EventHandler(this.cmbTapNo_SelectedIndexChanged);
            // 
            // bsTapNo
            // 
            this.bsTapNo.DataMember = "L3DataTable";
            this.bsTapNo.DataSource = this.dsTapNo;
            this.bsTapNo.Sort = "TAP_No";
            // 
            // dsTapNo
            // 
            this.dsTapNo.AutoLoad = true;
            this.dsTapNo.AutoSubscribe = false;
            this.dsTapNo.DataSetName = "L3DataSet";
            this.dsTapNo.DeleteMethod = "";
            this.dsTapNo.InsertMethod = "";
            this.dsTapNo.L3DataAdapter = null;
            this.dsTapNo.LoadEvent = "";
            this.dsTapNo.LoadTrigger = null;
            this.dsTapNo.RefreshValve = 1000;
            this.dsTapNo.SourceCommand = null;
            this.dsTapNo.SourceCondition = "";
            this.dsTapNo.SourceMethod = "";
            this.dsTapNo.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsTapNo.SourceURI = "";
            this.dsTapNo.SubscribeTarget = null;
            this.dsTapNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapNo});
            this.dsTapNo.UpdateEvent = "";
            this.dsTapNo.UpdateMethod = "";
            this.dsTapNo.UpdateTrigger = null;
            // 
            // schemadsTapNo
            // 
            this.schemadsTapNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTapNoL3DataTableTAP_No});
            this.schemadsTapNo.TableName = "L3DataTable";
            // 
            // coldsTapNoL3DataTableTAP_No
            // 
            this.coldsTapNoL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsTapNoL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsTapNoL3DataTableTAP_No.Namespace = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "脱硫样式:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dsSend
            // 
            this.dsSend.AutoLoad = true;
            this.dsSend.AutoSubscribe = false;
            this.dsSend.DataSetName = "L3DataSet";
            this.dsSend.DeleteMethod = "";
            this.dsSend.InsertMethod = "";
            this.dsSend.L3DataAdapter = null;
            this.dsSend.LoadEvent = "";
            this.dsSend.LoadTrigger = null;
            this.dsSend.RefreshValve = 1000;
            this.dsSend.SourceCommand = null;
            this.dsSend.SourceCondition = "";
            this.dsSend.SourceMethod = "";
            this.dsSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsSend.SourceURI = "";
            this.dsSend.SubscribeTarget = null;
            this.dsSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSend});
            this.dsSend.UpdateEvent = "";
            this.dsSend.UpdateMethod = "";
            this.dsSend.UpdateTrigger = null;
            // 
            // schemadsSend
            // 
            this.schemadsSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSendL3DataTableTAP_No,
            this.coldsSendL3DataTableTPC_No,
            this.coldsSendL3DataTableMode});
            this.schemadsSend.TableName = "L3DataTable";
            // 
            // coldsSendL3DataTableTAP_No
            // 
            this.coldsSendL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsSendL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsSendL3DataTableTAP_No.Namespace = "";
            // 
            // coldsSendL3DataTableTPC_No
            // 
            this.coldsSendL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsSendL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsSendL3DataTableTPC_No.Namespace = "";
            // 
            // coldsSendL3DataTableMode
            // 
            this.coldsSendL3DataTableMode.Caption = "Mode";
            this.coldsSendL3DataTableMode.ColumnName = "Mode";
            this.coldsSendL3DataTableMode.DataType = typeof(short);
            this.coldsSendL3DataTableMode.Namespace = "";
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableBFID,
            this.coldsMainL3DataTableTAP_No,
            this.coldsMainL3DataTableTPC_No});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableBFID
            // 
            this.coldsMainL3DataTableBFID.Caption = "BFID";
            this.coldsMainL3DataTableBFID.ColumnName = "BFID";
            this.coldsMainL3DataTableBFID.DefaultValue = "";
            this.coldsMainL3DataTableBFID.Namespace = "";
            // 
            // coldsMainL3DataTableTAP_No
            // 
            this.coldsMainL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsMainL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsMainL3DataTableTAP_No.DefaultValue = "";
            this.coldsMainL3DataTableTAP_No.Namespace = "";
            // 
            // coldsMainL3DataTableTPC_No
            // 
            this.coldsMainL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsMainL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsMainL3DataTableTPC_No.DefaultValue = "";
            this.coldsMainL3DataTableTPC_No.Namespace = "";
            // 
            // cmdSend
            // 
            this.cmdSend.Adapter = this.Adapter;
            this.cmdSend.MergeReturnTarget = false;
            this.cmdSend.Method = "NewDeSIronSheet";
            this.cmdSend.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdSend.Parameters.Add(this.cmdpSend);
            this.cmdSend.ReturnTarget = null;
            this.cmdSend.ReturnTargetProperty = null;
            this.cmdSend.Trigger = null;
            this.cmdSend.TriggerEvent = "Click";
            // 
            // cmdpSend
            // 
            this.cmdpSend.AcceptAfterExecuted = false;
            this.cmdpSend.ConstantValue = null;
            this.cmdpSend.MergeTarget = false;
            this.cmdpSend.SourceFilter = null;
            this.cmdpSend.SourceObject = null;
            this.cmdpSend.SourceProperty = null;
            this.cmdpSend.TargetObject = null;
            this.cmdpSend.TargetProperty = null;
            // 
            // DeSIronSheetFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 250);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeSIronSheetFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "制定委托单";
            this.Load += new System.EventHandler(this.DeSIronSheetFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTpcNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTpcNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTpcNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbHeatName;
        private PxDataValid.PxComboBox cmbTapNo;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxComboBox cmbBFID;
        private PxDataValid.PxComboBox cmbTpcNo;
        private AppSvrHMI.L3DataSet dsSend;
        private System.Data.DataTable schemadsSend;
        private System.Data.DataColumn coldsSendL3DataTableTAP_No;
        private System.Data.DataColumn coldsSendL3DataTableTPC_No;
        private System.Data.DataColumn coldsSendL3DataTableMode;
        private buttonHide.MyLine myLine1;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableBFID;
        private System.Data.DataColumn coldsMainL3DataTableTAP_No;
        private System.Data.DataColumn coldsMainL3DataTableTPC_No;
        private AppSvrHMI.L3DataSet dsTapNo;
        private AppSvrHMI.L3DataSet dsTpcNo;
        private System.Data.DataTable schemadsTapNo;
        private System.Data.DataColumn coldsTapNoL3DataTableTAP_No;
        private System.Windows.Forms.BindingSource bsTapNo;
        private System.Data.DataTable schemadsTpcNo;
        private System.Data.DataColumn coldsTpcNoL3DataTableTpc_No;
        private System.Windows.Forms.BindingSource bsTpcNo;
        private AppSvrHMI.L3Command cmdSend;
        private AppSvrHMI.L3CommandParameter cmdpSend;
    }
}