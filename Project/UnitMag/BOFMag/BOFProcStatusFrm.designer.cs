namespace UnitMag.BOFMag
{
    partial class BOFProcStatusFrm
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
            this.lbHeatID = new System.Windows.Forms.Label();
            this.bsBOF = new System.Windows.Forms.BindingSource(this.components);
            this.dsBOF = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBOF = new System.Data.DataTable();
            this.coldsBOFL3DataTableName = new System.Data.DataColumn();
            this.coldsBOFL3DataTableOwner = new System.Data.DataColumn();
            this.coldsBOFL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFL3DataTableDescription = new System.Data.DataColumn();
            this.coldsBOFL3DataTableWorkShop = new System.Data.DataColumn();
            this.coldsBOFL3DataTableSequenceNo = new System.Data.DataColumn();
            this.coldsBOFL3DataTableMaterialProcessed = new System.Data.DataColumn();
            this.coldsBOFL3DataTableMaterialFeeded = new System.Data.DataColumn();
            this.coldsBOFL3DataTableMaterialDeliveried = new System.Data.DataColumn();
            this.coldsBOFL3DataTablePlanChanged = new System.Data.DataColumn();
            this.coldsBOFL3DataTableDeviceChanged = new System.Data.DataColumn();
            this.coldsBOFL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBOFL3DataTableNextHeatID = new System.Data.DataColumn();
            this.coldsBOFL3DataTableStatus = new System.Data.DataColumn();
            this.coldsBOFL3DataTableDeviceStatus = new System.Data.DataColumn();
            this.coldsBOFL3DataTableLanceAge = new System.Data.DataColumn();
            this.coldsBOFL3DataTableFurnaceAge = new System.Data.DataColumn();
            this.coldsBOFL3DataTableCampaign = new System.Data.DataColumn();
            this.coldsBOFL3DataTableAddition_Type = new System.Data.DataColumn();
            this.coldsBOFL3DataTableTemp = new System.Data.DataColumn();
            this.coldsBOFL3DataTableTopFlow = new System.Data.DataColumn();
            this.coldsBOFL3DataTableTopPressure = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomFlow1 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomPressure1 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomFlow2 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomPressure2 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomFlow3 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomPressure3 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomFlow4 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomPressure4 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomFlow5 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomPressure5 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomFlow6 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBottomPressure6 = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBlowingEvent = new System.Data.DataColumn();
            this.coldsBOFL3DataTableReSampleEvent = new System.Data.DataColumn();
            this.coldsBOFL3DataTableUndoApplyEvent = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnFeedIron = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNextHeatID = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdFeedIron = new AppSvrHMI.L3Command(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lbHeatID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 29);
            this.panel3.TabIndex = 80;
            // 
            // lbHeatID
            // 
            this.lbHeatID.AutoSize = true;
            this.lbHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBOF, "HeatID", true));
            this.lbHeatID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbHeatID.Location = new System.Drawing.Point(108, 9);
            this.lbHeatID.Name = "lbHeatID";
            this.lbHeatID.Size = new System.Drawing.Size(59, 12);
            this.lbHeatID.TabIndex = 74;
            this.lbHeatID.Text = "#########";
            // 
            // bsBOF
            // 
            this.bsBOF.DataMember = "L3DataTable";
            this.bsBOF.DataSource = this.dsBOF;
            // 
            // dsBOF
            // 
            this.dsBOF.DataSetName = "L3DataSet";
            this.dsBOF.DeleteMethod = null;
            this.dsBOF.InsertMethod = null;
            this.dsBOF.L3DataAdapter = this.Adapter;
            this.dsBOF.LoadEvent = "Click";
            this.dsBOF.LoadTrigger = null;
            this.dsBOF.RefreshValve = 1000;
            this.dsBOF.SourceCommand = null;
            this.dsBOF.SourceCondition = "Name = \'{BOFID}\'";
            this.dsBOF.SourceMethod = "";
            this.dsBOF.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOF.SourceURI = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag";
            this.dsBOF.SubscribeTarget = null;
            this.dsBOF.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOF});
            this.dsBOF.UpdateEvent = "Click";
            this.dsBOF.UpdateMethod = null;
            this.dsBOF.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBOF
            // 
            this.schemadsBOF.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFL3DataTableName,
            this.coldsBOFL3DataTableOwner,
            this.coldsBOFL3DataTableCode,
            this.coldsBOFL3DataTableDescription,
            this.coldsBOFL3DataTableWorkShop,
            this.coldsBOFL3DataTableSequenceNo,
            this.coldsBOFL3DataTableMaterialProcessed,
            this.coldsBOFL3DataTableMaterialFeeded,
            this.coldsBOFL3DataTableMaterialDeliveried,
            this.coldsBOFL3DataTablePlanChanged,
            this.coldsBOFL3DataTableDeviceChanged,
            this.coldsBOFL3DataTableHeatID,
            this.coldsBOFL3DataTableNextHeatID,
            this.coldsBOFL3DataTableStatus,
            this.coldsBOFL3DataTableDeviceStatus,
            this.coldsBOFL3DataTableLanceAge,
            this.coldsBOFL3DataTableFurnaceAge,
            this.coldsBOFL3DataTableCampaign,
            this.coldsBOFL3DataTableAddition_Type,
            this.coldsBOFL3DataTableTemp,
            this.coldsBOFL3DataTableTopFlow,
            this.coldsBOFL3DataTableTopPressure,
            this.coldsBOFL3DataTableBottomFlow1,
            this.coldsBOFL3DataTableBottomPressure1,
            this.coldsBOFL3DataTableBottomFlow2,
            this.coldsBOFL3DataTableBottomPressure2,
            this.coldsBOFL3DataTableBottomFlow3,
            this.coldsBOFL3DataTableBottomPressure3,
            this.coldsBOFL3DataTableBottomFlow4,
            this.coldsBOFL3DataTableBottomPressure4,
            this.coldsBOFL3DataTableBottomFlow5,
            this.coldsBOFL3DataTableBottomPressure5,
            this.coldsBOFL3DataTableBottomFlow6,
            this.coldsBOFL3DataTableBottomPressure6,
            this.coldsBOFL3DataTableBlowingEvent,
            this.coldsBOFL3DataTableReSampleEvent,
            this.coldsBOFL3DataTableUndoApplyEvent});
            this.schemadsBOF.TableName = "L3DataTable";
            // 
            // coldsBOFL3DataTableName
            // 
            this.coldsBOFL3DataTableName.Caption = "Name";
            this.coldsBOFL3DataTableName.ColumnName = "Name";
            this.coldsBOFL3DataTableName.Namespace = "";
            // 
            // coldsBOFL3DataTableOwner
            // 
            this.coldsBOFL3DataTableOwner.Caption = "Owner";
            this.coldsBOFL3DataTableOwner.ColumnName = "Owner";
            this.coldsBOFL3DataTableOwner.Namespace = "";
            // 
            // coldsBOFL3DataTableCode
            // 
            this.coldsBOFL3DataTableCode.Caption = "Code";
            this.coldsBOFL3DataTableCode.ColumnName = "Code";
            this.coldsBOFL3DataTableCode.Namespace = "";
            // 
            // coldsBOFL3DataTableDescription
            // 
            this.coldsBOFL3DataTableDescription.Caption = "Description";
            this.coldsBOFL3DataTableDescription.ColumnName = "Description";
            this.coldsBOFL3DataTableDescription.Namespace = "";
            // 
            // coldsBOFL3DataTableWorkShop
            // 
            this.coldsBOFL3DataTableWorkShop.Caption = "WorkShop";
            this.coldsBOFL3DataTableWorkShop.ColumnName = "WorkShop";
            this.coldsBOFL3DataTableWorkShop.Namespace = "";
            // 
            // coldsBOFL3DataTableSequenceNo
            // 
            this.coldsBOFL3DataTableSequenceNo.Caption = "SequenceNo";
            this.coldsBOFL3DataTableSequenceNo.ColumnName = "SequenceNo";
            this.coldsBOFL3DataTableSequenceNo.DataType = typeof(int);
            this.coldsBOFL3DataTableSequenceNo.Namespace = "";
            // 
            // coldsBOFL3DataTableMaterialProcessed
            // 
            this.coldsBOFL3DataTableMaterialProcessed.Caption = "MaterialProcessed";
            this.coldsBOFL3DataTableMaterialProcessed.ColumnName = "MaterialProcessed";
            this.coldsBOFL3DataTableMaterialProcessed.DataType = typeof(int);
            this.coldsBOFL3DataTableMaterialProcessed.Namespace = "";
            // 
            // coldsBOFL3DataTableMaterialFeeded
            // 
            this.coldsBOFL3DataTableMaterialFeeded.Caption = "MaterialFeeded";
            this.coldsBOFL3DataTableMaterialFeeded.ColumnName = "MaterialFeeded";
            this.coldsBOFL3DataTableMaterialFeeded.DataType = typeof(int);
            this.coldsBOFL3DataTableMaterialFeeded.Namespace = "";
            // 
            // coldsBOFL3DataTableMaterialDeliveried
            // 
            this.coldsBOFL3DataTableMaterialDeliveried.Caption = "MaterialDeliveried";
            this.coldsBOFL3DataTableMaterialDeliveried.ColumnName = "MaterialDeliveried";
            this.coldsBOFL3DataTableMaterialDeliveried.DataType = typeof(int);
            this.coldsBOFL3DataTableMaterialDeliveried.Namespace = "";
            // 
            // coldsBOFL3DataTablePlanChanged
            // 
            this.coldsBOFL3DataTablePlanChanged.Caption = "PlanChanged";
            this.coldsBOFL3DataTablePlanChanged.ColumnName = "PlanChanged";
            this.coldsBOFL3DataTablePlanChanged.DataType = typeof(int);
            this.coldsBOFL3DataTablePlanChanged.Namespace = "";
            // 
            // coldsBOFL3DataTableDeviceChanged
            // 
            this.coldsBOFL3DataTableDeviceChanged.Caption = "DeviceChanged";
            this.coldsBOFL3DataTableDeviceChanged.ColumnName = "DeviceChanged";
            this.coldsBOFL3DataTableDeviceChanged.DataType = typeof(int);
            this.coldsBOFL3DataTableDeviceChanged.Namespace = "";
            // 
            // coldsBOFL3DataTableHeatID
            // 
            this.coldsBOFL3DataTableHeatID.Caption = "HeatID";
            this.coldsBOFL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBOFL3DataTableHeatID.Namespace = "";
            // 
            // coldsBOFL3DataTableNextHeatID
            // 
            this.coldsBOFL3DataTableNextHeatID.Caption = "NextHeatID";
            this.coldsBOFL3DataTableNextHeatID.ColumnName = "NextHeatID";
            this.coldsBOFL3DataTableNextHeatID.Namespace = "";
            // 
            // coldsBOFL3DataTableStatus
            // 
            this.coldsBOFL3DataTableStatus.Caption = "Status";
            this.coldsBOFL3DataTableStatus.ColumnName = "Status";
            this.coldsBOFL3DataTableStatus.DataType = typeof(int);
            this.coldsBOFL3DataTableStatus.Namespace = "";
            // 
            // coldsBOFL3DataTableDeviceStatus
            // 
            this.coldsBOFL3DataTableDeviceStatus.Caption = "DeviceStatus";
            this.coldsBOFL3DataTableDeviceStatus.ColumnName = "DeviceStatus";
            this.coldsBOFL3DataTableDeviceStatus.DataType = typeof(int);
            this.coldsBOFL3DataTableDeviceStatus.Namespace = "";
            // 
            // coldsBOFL3DataTableLanceAge
            // 
            this.coldsBOFL3DataTableLanceAge.Caption = "LanceAge";
            this.coldsBOFL3DataTableLanceAge.ColumnName = "LanceAge";
            this.coldsBOFL3DataTableLanceAge.DataType = typeof(int);
            this.coldsBOFL3DataTableLanceAge.Namespace = "";
            // 
            // coldsBOFL3DataTableFurnaceAge
            // 
            this.coldsBOFL3DataTableFurnaceAge.Caption = "FurnaceAge";
            this.coldsBOFL3DataTableFurnaceAge.ColumnName = "FurnaceAge";
            this.coldsBOFL3DataTableFurnaceAge.DataType = typeof(int);
            this.coldsBOFL3DataTableFurnaceAge.Namespace = "";
            // 
            // coldsBOFL3DataTableCampaign
            // 
            this.coldsBOFL3DataTableCampaign.Caption = "Campaign";
            this.coldsBOFL3DataTableCampaign.ColumnName = "Campaign";
            this.coldsBOFL3DataTableCampaign.DataType = typeof(int);
            this.coldsBOFL3DataTableCampaign.Namespace = "";
            // 
            // coldsBOFL3DataTableAddition_Type
            // 
            this.coldsBOFL3DataTableAddition_Type.Caption = "Addition_Type";
            this.coldsBOFL3DataTableAddition_Type.ColumnName = "Addition_Type";
            this.coldsBOFL3DataTableAddition_Type.DataType = typeof(int);
            this.coldsBOFL3DataTableAddition_Type.Namespace = "";
            // 
            // coldsBOFL3DataTableTemp
            // 
            this.coldsBOFL3DataTableTemp.Caption = "Temp";
            this.coldsBOFL3DataTableTemp.ColumnName = "Temp";
            this.coldsBOFL3DataTableTemp.DataType = typeof(int);
            this.coldsBOFL3DataTableTemp.Namespace = "";
            // 
            // coldsBOFL3DataTableTopFlow
            // 
            this.coldsBOFL3DataTableTopFlow.Caption = "TopFlow";
            this.coldsBOFL3DataTableTopFlow.ColumnName = "TopFlow";
            this.coldsBOFL3DataTableTopFlow.DataType = typeof(double);
            this.coldsBOFL3DataTableTopFlow.Namespace = "";
            // 
            // coldsBOFL3DataTableTopPressure
            // 
            this.coldsBOFL3DataTableTopPressure.Caption = "TopPressure";
            this.coldsBOFL3DataTableTopPressure.ColumnName = "TopPressure";
            this.coldsBOFL3DataTableTopPressure.DataType = typeof(double);
            this.coldsBOFL3DataTableTopPressure.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomFlow1
            // 
            this.coldsBOFL3DataTableBottomFlow1.Caption = "BottomFlow1";
            this.coldsBOFL3DataTableBottomFlow1.ColumnName = "BottomFlow1";
            this.coldsBOFL3DataTableBottomFlow1.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomFlow1.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomPressure1
            // 
            this.coldsBOFL3DataTableBottomPressure1.Caption = "BottomPressure1";
            this.coldsBOFL3DataTableBottomPressure1.ColumnName = "BottomPressure1";
            this.coldsBOFL3DataTableBottomPressure1.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomPressure1.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomFlow2
            // 
            this.coldsBOFL3DataTableBottomFlow2.Caption = "BottomFlow2";
            this.coldsBOFL3DataTableBottomFlow2.ColumnName = "BottomFlow2";
            this.coldsBOFL3DataTableBottomFlow2.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomFlow2.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomPressure2
            // 
            this.coldsBOFL3DataTableBottomPressure2.Caption = "BottomPressure2";
            this.coldsBOFL3DataTableBottomPressure2.ColumnName = "BottomPressure2";
            this.coldsBOFL3DataTableBottomPressure2.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomPressure2.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomFlow3
            // 
            this.coldsBOFL3DataTableBottomFlow3.Caption = "BottomFlow3";
            this.coldsBOFL3DataTableBottomFlow3.ColumnName = "BottomFlow3";
            this.coldsBOFL3DataTableBottomFlow3.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomFlow3.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomPressure3
            // 
            this.coldsBOFL3DataTableBottomPressure3.Caption = "BottomPressure3";
            this.coldsBOFL3DataTableBottomPressure3.ColumnName = "BottomPressure3";
            this.coldsBOFL3DataTableBottomPressure3.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomPressure3.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomFlow4
            // 
            this.coldsBOFL3DataTableBottomFlow4.Caption = "BottomFlow4";
            this.coldsBOFL3DataTableBottomFlow4.ColumnName = "BottomFlow4";
            this.coldsBOFL3DataTableBottomFlow4.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomFlow4.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomPressure4
            // 
            this.coldsBOFL3DataTableBottomPressure4.Caption = "BottomPressure4";
            this.coldsBOFL3DataTableBottomPressure4.ColumnName = "BottomPressure4";
            this.coldsBOFL3DataTableBottomPressure4.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomPressure4.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomFlow5
            // 
            this.coldsBOFL3DataTableBottomFlow5.Caption = "BottomFlow5";
            this.coldsBOFL3DataTableBottomFlow5.ColumnName = "BottomFlow5";
            this.coldsBOFL3DataTableBottomFlow5.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomFlow5.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomPressure5
            // 
            this.coldsBOFL3DataTableBottomPressure5.Caption = "BottomPressure5";
            this.coldsBOFL3DataTableBottomPressure5.ColumnName = "BottomPressure5";
            this.coldsBOFL3DataTableBottomPressure5.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomPressure5.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomFlow6
            // 
            this.coldsBOFL3DataTableBottomFlow6.Caption = "BottomFlow6";
            this.coldsBOFL3DataTableBottomFlow6.ColumnName = "BottomFlow6";
            this.coldsBOFL3DataTableBottomFlow6.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomFlow6.Namespace = "";
            // 
            // coldsBOFL3DataTableBottomPressure6
            // 
            this.coldsBOFL3DataTableBottomPressure6.Caption = "BottomPressure6";
            this.coldsBOFL3DataTableBottomPressure6.ColumnName = "BottomPressure6";
            this.coldsBOFL3DataTableBottomPressure6.DataType = typeof(double);
            this.coldsBOFL3DataTableBottomPressure6.Namespace = "";
            // 
            // coldsBOFL3DataTableBlowingEvent
            // 
            this.coldsBOFL3DataTableBlowingEvent.Caption = "BlowingEvent";
            this.coldsBOFL3DataTableBlowingEvent.ColumnName = "BlowingEvent";
            this.coldsBOFL3DataTableBlowingEvent.DataType = typeof(int);
            this.coldsBOFL3DataTableBlowingEvent.Namespace = "";
            // 
            // coldsBOFL3DataTableReSampleEvent
            // 
            this.coldsBOFL3DataTableReSampleEvent.Caption = "ReSampleEvent";
            this.coldsBOFL3DataTableReSampleEvent.ColumnName = "ReSampleEvent";
            this.coldsBOFL3DataTableReSampleEvent.DataType = typeof(int);
            this.coldsBOFL3DataTableReSampleEvent.Namespace = "";
            // 
            // coldsBOFL3DataTableUndoApplyEvent
            // 
            this.coldsBOFL3DataTableUndoApplyEvent.Caption = "UndoApplyEvent";
            this.coldsBOFL3DataTableUndoApplyEvent.ColumnName = "UndoApplyEvent";
            this.coldsBOFL3DataTableUndoApplyEvent.DataType = typeof(int);
            this.coldsBOFL3DataTableUndoApplyEvent.Namespace = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 73;
            this.label1.Text = "当前炉号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 73;
            this.label2.Text = "下一炉号:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 242);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 37);
            this.flowLayoutPanel1.TabIndex = 82;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(379, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(298, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 22);
            this.btnConfirm.TabIndex = 84;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 213);
            this.tabControl1.TabIndex = 83;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnFeedIron);
            this.tabPage1.Controls.Add(this.cmbStatus);
            this.tabPage1.Controls.Add(this.txtNextHeatID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(449, 188);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "状态信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnFeedIron
            // 
            this.btnFeedIron.Location = new System.Drawing.Point(345, 14);
            this.btnFeedIron.Name = "btnFeedIron";
            this.btnFeedIron.Size = new System.Drawing.Size(75, 23);
            this.btnFeedIron.TabIndex = 76;
            this.btnFeedIron.Text = "兑铁";
            this.btnFeedIron.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBOF, "Status", true));
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBOF, "Status", true));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(101, 47);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(128, 21);
            this.cmbStatus.TabIndex = 75;
            // 
            // txtNextHeatID
            // 
            this.txtNextHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBOF, "NextHeatID", true));
            this.txtNextHeatID.EnableNull = false;
            this.txtNextHeatID.ErropPr = this.errorProvider1;
            this.txtNextHeatID.Length = 0;
            this.txtNextHeatID.Location = new System.Drawing.Point(101, 20);
            this.txtNextHeatID.Max = 0;
            this.txtNextHeatID.MaxStrLength = 0;
            this.txtNextHeatID.Min = 0;
            this.txtNextHeatID.MinStrLength = 0;
            this.txtNextHeatID.Name = "txtNextHeatID";
            this.txtNextHeatID.Precision = 0;
            this.txtNextHeatID.Size = new System.Drawing.Size(128, 21);
            this.txtNextHeatID.TabIndex = 74;
            this.txtNextHeatID.ToolTipValid = this.toolTip1;
            this.txtNextHeatID.ValidEable = true;
            this.txtNextHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(24, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 73;
            this.label3.Text = "当前状态:";
            // 
            // cmdFeedIron
            // 
            this.cmdFeedIron.Adapter = this.Adapter;
            this.cmdFeedIron.MergeReturnTarget = false;
            this.cmdFeedIron.Method = "FeedIrons";
            this.cmdFeedIron.Object = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\{BOFID}";
            this.cmdFeedIron.ReturnTarget = null;
            this.cmdFeedIron.ReturnTargetProperty = null;
            this.cmdFeedIron.Trigger = this.btnFeedIron;
            this.cmdFeedIron.TriggerEvent = "Click";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BOFProcStatusFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 279);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.Name = "BOFProcStatusFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉次作业状态维护";
            this.Load += new System.EventHandler(this.BOFProcStatusFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataSet dsBOF;
        private System.Windows.Forms.Label lbHeatID;
        private System.Data.DataTable schemadsBOF;
        private System.Data.DataColumn coldsBOFL3DataTableName;
        private System.Data.DataColumn coldsBOFL3DataTableOwner;
        private System.Data.DataColumn coldsBOFL3DataTableCode;
        private System.Data.DataColumn coldsBOFL3DataTableDescription;
        private System.Data.DataColumn coldsBOFL3DataTableWorkShop;
        private System.Data.DataColumn coldsBOFL3DataTableSequenceNo;
        private System.Data.DataColumn coldsBOFL3DataTableMaterialProcessed;
        private System.Data.DataColumn coldsBOFL3DataTableMaterialFeeded;
        private System.Data.DataColumn coldsBOFL3DataTableMaterialDeliveried;
        private System.Data.DataColumn coldsBOFL3DataTablePlanChanged;
        private System.Data.DataColumn coldsBOFL3DataTableDeviceChanged;
        private System.Data.DataColumn coldsBOFL3DataTableHeatID;
        private System.Data.DataColumn coldsBOFL3DataTableNextHeatID;
        private System.Data.DataColumn coldsBOFL3DataTableStatus;
        private System.Data.DataColumn coldsBOFL3DataTableDeviceStatus;
        private System.Data.DataColumn coldsBOFL3DataTableLanceAge;
        private System.Data.DataColumn coldsBOFL3DataTableFurnaceAge;
        private System.Data.DataColumn coldsBOFL3DataTableCampaign;
        private System.Data.DataColumn coldsBOFL3DataTableAddition_Type;
        private System.Data.DataColumn coldsBOFL3DataTableTemp;
        private System.Data.DataColumn coldsBOFL3DataTableTopFlow;
        private System.Data.DataColumn coldsBOFL3DataTableTopPressure;
        private System.Data.DataColumn coldsBOFL3DataTableBottomFlow1;
        private System.Data.DataColumn coldsBOFL3DataTableBottomPressure1;
        private System.Data.DataColumn coldsBOFL3DataTableBottomFlow2;
        private System.Data.DataColumn coldsBOFL3DataTableBottomPressure2;
        private System.Data.DataColumn coldsBOFL3DataTableBottomFlow3;
        private System.Data.DataColumn coldsBOFL3DataTableBottomPressure3;
        private System.Data.DataColumn coldsBOFL3DataTableBottomFlow4;
        private System.Data.DataColumn coldsBOFL3DataTableBottomPressure4;
        private System.Data.DataColumn coldsBOFL3DataTableBottomFlow5;
        private System.Data.DataColumn coldsBOFL3DataTableBottomPressure5;
        private System.Data.DataColumn coldsBOFL3DataTableBottomFlow6;
        private System.Data.DataColumn coldsBOFL3DataTableBottomPressure6;
        private System.Data.DataColumn coldsBOFL3DataTableBlowingEvent;
        private System.Data.DataColumn coldsBOFL3DataTableReSampleEvent;
        private System.Data.DataColumn coldsBOFL3DataTableUndoApplyEvent;
        private System.Windows.Forms.BindingSource bsBOF;
        private System.Windows.Forms.ComboBox cmbStatus;
        private PxDataValid.PxTextBox　txtNextHeatID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFeedIron;
        private AppSvrHMI.L3Command cmdFeedIron;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}