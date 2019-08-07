namespace EquipMag.MoldMag
{
    partial class MoldPipeParUseShowFrm
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
            this.bsUseInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsUseInfo = new AppSvrHMI.L3DataSet();
            this.schemadsUseInfo = new System.Data.DataTable();
            this.coldsUseInfoL3DataTableGUID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableNAME = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableMOLDID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableCOPPER_ID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableCOPPER_FAC = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableCUR_USE_COUNT = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableTOTAL_USE_COUNT = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableCUR_PULL_MEA = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableTOTAL_PULL_MEA = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableCAST_ID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableFLOWID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableSTOP_REASON = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableRULER = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableOnLine_Flag = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableOnLine_Time = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableOffLine_Flag = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableOffLine_Time = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableInStallID = new System.Data.DataColumn();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbCopperFac = new PxDataValid.PxComboBox();
            this.dsCopperFac = new AppSvrHMI.L3DataSet();
            this.schemadsCopperFac = new System.Data.DataTable();
            this.coldsCopperFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCopperID = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbStopReason = new PxDataValid.PxComboBox();
            this.dsMoldStopReason = new AppSvrHMI.L3DataSet();
            this.schemadsMoldStopReason = new System.Data.DataTable();
            this.coldsMoldStopReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsMoldStopReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbFlowID = new PxDataValid.PxComboBox();
            this.cmbCastID = new PxDataValid.PxComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPullMea = new PxDataValid.PxTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMoldID = new PxDataValid.PxComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtOffLine = new System.Windows.Forms.DateTimePicker();
            this.dtOnLine = new System.Windows.Forms.DateTimePicker();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dsJ06 = new AppSvrHMI.L3DataSet();
            this.schemadsJ06 = new System.Data.DataTable();
            this.coldsJ06L3DataTableMoldID = new System.Data.DataColumn();
            this.dsJ09 = new AppSvrHMI.L3DataSet();
            this.schemadsJ09 = new System.Data.DataTable();
            this.coldsJ09L3DataTableMoldID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsUseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldStopReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldStopReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJ06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJ06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJ09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJ09)).BeginInit();
            this.SuspendLayout();
            // 
            // bsUseInfo
            // 
            this.bsUseInfo.DataMember = "L3DataTable";
            this.bsUseInfo.DataSource = this.dsUseInfo;
            // 
            // dsUseInfo
            // 
            this.dsUseInfo.AutoLoad = true;
            this.dsUseInfo.AutoSubscribe = false;
            this.dsUseInfo.DataSetName = "L3DataSet";
            this.dsUseInfo.DeleteMethod = "";
            this.dsUseInfo.InsertMethod = "";
            this.dsUseInfo.L3DataAdapter = null;
            this.dsUseInfo.LoadEvent = "Click";
            this.dsUseInfo.LoadTrigger = null;
            this.dsUseInfo.RefreshValve = 1000;
            this.dsUseInfo.SourceCommand = null;
            this.dsUseInfo.SourceCondition = "";
            this.dsUseInfo.SourceMethod = "";
            this.dsUseInfo.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsUseInfo.SourceURI = "";
            this.dsUseInfo.SubscribeTarget = "";
            this.dsUseInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUseInfo});
            this.dsUseInfo.UpdateEvent = "Click";
            this.dsUseInfo.UpdateMethod = "";
            this.dsUseInfo.UpdateTrigger = null;
            // 
            // schemadsUseInfo
            // 
            this.schemadsUseInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUseInfoL3DataTableGUID,
            this.coldsUseInfoL3DataTableNAME,
            this.coldsUseInfoL3DataTableINPUT_TIME,
            this.coldsUseInfoL3DataTableMOLDID,
            this.coldsUseInfoL3DataTableCOPPER_ID,
            this.coldsUseInfoL3DataTableCOPPER_FAC,
            this.coldsUseInfoL3DataTableCUR_USE_COUNT,
            this.coldsUseInfoL3DataTableTOTAL_USE_COUNT,
            this.coldsUseInfoL3DataTableCUR_PULL_MEA,
            this.coldsUseInfoL3DataTableTOTAL_PULL_MEA,
            this.coldsUseInfoL3DataTableCAST_ID,
            this.coldsUseInfoL3DataTableFLOWID,
            this.coldsUseInfoL3DataTableSTOP_REASON,
            this.coldsUseInfoL3DataTableRULER,
            this.coldsUseInfoL3DataTableTEAMID,
            this.coldsUseInfoL3DataTableSHIFTID,
            this.coldsUseInfoL3DataTableOPERATOR,
            this.coldsUseInfoL3DataTableNOTE,
            this.coldsUseInfoL3DataTableOnLine_Flag,
            this.coldsUseInfoL3DataTableOnLine_Time,
            this.coldsUseInfoL3DataTableOffLine_Flag,
            this.coldsUseInfoL3DataTableOffLine_Time,
            this.coldsUseInfoL3DataTableInStallID});
            this.schemadsUseInfo.TableName = "L3DataTable";
            // 
            // coldsUseInfoL3DataTableGUID
            // 
            this.coldsUseInfoL3DataTableGUID.Caption = "GUID";
            this.coldsUseInfoL3DataTableGUID.ColumnName = "GUID";
            this.coldsUseInfoL3DataTableGUID.DefaultValue = "";
            this.coldsUseInfoL3DataTableGUID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableNAME
            // 
            this.coldsUseInfoL3DataTableNAME.Caption = "NAME";
            this.coldsUseInfoL3DataTableNAME.ColumnName = "NAME";
            this.coldsUseInfoL3DataTableNAME.DefaultValue = "";
            this.coldsUseInfoL3DataTableNAME.Namespace = "";
            // 
            // coldsUseInfoL3DataTableINPUT_TIME
            // 
            this.coldsUseInfoL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsUseInfoL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsUseInfoL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsUseInfoL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsUseInfoL3DataTableMOLDID
            // 
            this.coldsUseInfoL3DataTableMOLDID.Caption = "MOLDID";
            this.coldsUseInfoL3DataTableMOLDID.ColumnName = "MOLDID";
            this.coldsUseInfoL3DataTableMOLDID.DefaultValue = "";
            this.coldsUseInfoL3DataTableMOLDID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableCOPPER_ID
            // 
            this.coldsUseInfoL3DataTableCOPPER_ID.Caption = "COPPER_ID";
            this.coldsUseInfoL3DataTableCOPPER_ID.ColumnName = "COPPER_ID";
            this.coldsUseInfoL3DataTableCOPPER_ID.DefaultValue = "";
            this.coldsUseInfoL3DataTableCOPPER_ID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableCOPPER_FAC
            // 
            this.coldsUseInfoL3DataTableCOPPER_FAC.Caption = "COPPER_FAC";
            this.coldsUseInfoL3DataTableCOPPER_FAC.ColumnName = "COPPER_FAC";
            this.coldsUseInfoL3DataTableCOPPER_FAC.DefaultValue = "";
            this.coldsUseInfoL3DataTableCOPPER_FAC.Namespace = "";
            // 
            // coldsUseInfoL3DataTableCUR_USE_COUNT
            // 
            this.coldsUseInfoL3DataTableCUR_USE_COUNT.Caption = "CUR_USE_COUNT";
            this.coldsUseInfoL3DataTableCUR_USE_COUNT.ColumnName = "CUR_USE_COUNT";
            this.coldsUseInfoL3DataTableCUR_USE_COUNT.DataType = typeof(int);
            this.coldsUseInfoL3DataTableCUR_USE_COUNT.DefaultValue = 0;
            this.coldsUseInfoL3DataTableCUR_USE_COUNT.Namespace = "";
            // 
            // coldsUseInfoL3DataTableTOTAL_USE_COUNT
            // 
            this.coldsUseInfoL3DataTableTOTAL_USE_COUNT.Caption = "TOTAL_USE_COUNT";
            this.coldsUseInfoL3DataTableTOTAL_USE_COUNT.ColumnName = "TOTAL_USE_COUNT";
            this.coldsUseInfoL3DataTableTOTAL_USE_COUNT.DataType = typeof(int);
            this.coldsUseInfoL3DataTableTOTAL_USE_COUNT.DefaultValue = 0;
            this.coldsUseInfoL3DataTableTOTAL_USE_COUNT.Namespace = "";
            // 
            // coldsUseInfoL3DataTableCUR_PULL_MEA
            // 
            this.coldsUseInfoL3DataTableCUR_PULL_MEA.Caption = "CUR_PULL_MEA";
            this.coldsUseInfoL3DataTableCUR_PULL_MEA.ColumnName = "CUR_PULL_MEA";
            this.coldsUseInfoL3DataTableCUR_PULL_MEA.DataType = typeof(double);
            this.coldsUseInfoL3DataTableCUR_PULL_MEA.DefaultValue = 0;
            this.coldsUseInfoL3DataTableCUR_PULL_MEA.Namespace = "";
            // 
            // coldsUseInfoL3DataTableTOTAL_PULL_MEA
            // 
            this.coldsUseInfoL3DataTableTOTAL_PULL_MEA.Caption = "TOTAL_PULL_MEA";
            this.coldsUseInfoL3DataTableTOTAL_PULL_MEA.ColumnName = "TOTAL_PULL_MEA";
            this.coldsUseInfoL3DataTableTOTAL_PULL_MEA.DataType = typeof(double);
            this.coldsUseInfoL3DataTableTOTAL_PULL_MEA.DefaultValue = 0;
            this.coldsUseInfoL3DataTableTOTAL_PULL_MEA.Namespace = "";
            // 
            // coldsUseInfoL3DataTableCAST_ID
            // 
            this.coldsUseInfoL3DataTableCAST_ID.Caption = "CAST_ID";
            this.coldsUseInfoL3DataTableCAST_ID.ColumnName = "CAST_ID";
            this.coldsUseInfoL3DataTableCAST_ID.DefaultValue = "";
            this.coldsUseInfoL3DataTableCAST_ID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableFLOWID
            // 
            this.coldsUseInfoL3DataTableFLOWID.Caption = "FLOWID";
            this.coldsUseInfoL3DataTableFLOWID.ColumnName = "FLOWID";
            this.coldsUseInfoL3DataTableFLOWID.DefaultValue = "";
            this.coldsUseInfoL3DataTableFLOWID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableSTOP_REASON
            // 
            this.coldsUseInfoL3DataTableSTOP_REASON.Caption = "STOP_REASON";
            this.coldsUseInfoL3DataTableSTOP_REASON.ColumnName = "STOP_REASON";
            this.coldsUseInfoL3DataTableSTOP_REASON.DefaultValue = "";
            this.coldsUseInfoL3DataTableSTOP_REASON.Namespace = "";
            // 
            // coldsUseInfoL3DataTableRULER
            // 
            this.coldsUseInfoL3DataTableRULER.Caption = "RULER";
            this.coldsUseInfoL3DataTableRULER.ColumnName = "RULER";
            this.coldsUseInfoL3DataTableRULER.DataType = typeof(double);
            this.coldsUseInfoL3DataTableRULER.DefaultValue = 0;
            this.coldsUseInfoL3DataTableRULER.Namespace = "";
            // 
            // coldsUseInfoL3DataTableTEAMID
            // 
            this.coldsUseInfoL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsUseInfoL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsUseInfoL3DataTableTEAMID.DefaultValue = "";
            this.coldsUseInfoL3DataTableTEAMID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableSHIFTID
            // 
            this.coldsUseInfoL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsUseInfoL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsUseInfoL3DataTableSHIFTID.DefaultValue = "";
            this.coldsUseInfoL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableOPERATOR
            // 
            this.coldsUseInfoL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsUseInfoL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsUseInfoL3DataTableOPERATOR.DefaultValue = "";
            this.coldsUseInfoL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsUseInfoL3DataTableNOTE
            // 
            this.coldsUseInfoL3DataTableNOTE.Caption = "NOTE";
            this.coldsUseInfoL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsUseInfoL3DataTableNOTE.DefaultValue = "";
            this.coldsUseInfoL3DataTableNOTE.Namespace = "";
            // 
            // coldsUseInfoL3DataTableOnLine_Flag
            // 
            this.coldsUseInfoL3DataTableOnLine_Flag.Caption = "OnLine_Flag";
            this.coldsUseInfoL3DataTableOnLine_Flag.ColumnName = "OnLine_Flag";
            this.coldsUseInfoL3DataTableOnLine_Flag.DataType = typeof(int);
            this.coldsUseInfoL3DataTableOnLine_Flag.Namespace = "";
            // 
            // coldsUseInfoL3DataTableOnLine_Time
            // 
            this.coldsUseInfoL3DataTableOnLine_Time.Caption = "OnLine_Time";
            this.coldsUseInfoL3DataTableOnLine_Time.ColumnName = "OnLine_Time";
            this.coldsUseInfoL3DataTableOnLine_Time.DataType = typeof(System.DateTime);
            this.coldsUseInfoL3DataTableOnLine_Time.Namespace = "";
            // 
            // coldsUseInfoL3DataTableOffLine_Flag
            // 
            this.coldsUseInfoL3DataTableOffLine_Flag.Caption = "OffLine_Flag";
            this.coldsUseInfoL3DataTableOffLine_Flag.ColumnName = "OffLine_Flag";
            this.coldsUseInfoL3DataTableOffLine_Flag.DataType = typeof(int);
            this.coldsUseInfoL3DataTableOffLine_Flag.Namespace = "";
            // 
            // coldsUseInfoL3DataTableOffLine_Time
            // 
            this.coldsUseInfoL3DataTableOffLine_Time.Caption = "OffLine_Time";
            this.coldsUseInfoL3DataTableOffLine_Time.ColumnName = "OffLine_Time";
            this.coldsUseInfoL3DataTableOffLine_Time.DataType = typeof(System.DateTime);
            this.coldsUseInfoL3DataTableOffLine_Time.Namespace = "";
            // 
            // coldsUseInfoL3DataTableInStallID
            // 
            this.coldsUseInfoL3DataTableInStallID.Caption = "InStallID";
            this.coldsUseInfoL3DataTableInStallID.ColumnName = "InStallID";
            this.coldsUseInfoL3DataTableInStallID.Namespace = "";
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(463, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(382, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsCasterID
            // 
            this.dsCasterID.AutoLoad = true;
            this.dsCasterID.AutoSubscribe = false;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "Code_Group = \'Caster\' and Code <> \'S65\' order by Code";
            this.dsCasterID.SourceMethod = "";
            this.dsCasterID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCasterID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCasterID.SubscribeTarget = null;
            this.dsCasterID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCasterID});
            this.dsCasterID.UpdateEvent = "Click";
            this.dsCasterID.UpdateMethod = null;
            this.dsCasterID.UpdateTrigger = null;
            // 
            // schemadsCasterID
            // 
            this.schemadsCasterID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterIDL3DataTableCode,
            this.coldsCasterIDL3DataTableCode_Des});
            this.schemadsCasterID.TableName = "L3DataTable";
            // 
            // coldsCasterIDL3DataTableCode
            // 
            this.coldsCasterIDL3DataTableCode.Caption = "Code";
            this.coldsCasterIDL3DataTableCode.ColumnName = "Code";
            this.coldsCasterIDL3DataTableCode.Namespace = "";
            // 
            // coldsCasterIDL3DataTableCode_Des
            // 
            this.coldsCasterIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.Namespace = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 278);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(541, 57);
            this.flowLayoutPanel1.TabIndex = 78;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 278);
            this.tabControl1.TabIndex = 79;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.cmbCopperFac);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtCopperID);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbStopReason);
            this.tabPage1.Controls.Add(this.cmbFlowID);
            this.tabPage1.Controls.Add(this.cmbCastID);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTotalPullMea);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbMoldID);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtOffLine);
            this.tabPage1.Controls.Add(this.dtOnLine);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(533, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "铜管使用信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUseInfo, "NOTE", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(86, 183);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(425, 54);
            this.rtxtNote.TabIndex = 32;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbCopperFac
            // 
            this.cmbCopperFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCopperFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCopperFac.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUseInfo, "COPPER_FAC", true));
            this.cmbCopperFac.DataSource = this.dsCopperFac;
            this.cmbCopperFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbCopperFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopperFac.EnableNull = true;
            this.cmbCopperFac.ErropPr = null;
            this.cmbCopperFac.FormattingEnabled = true;
            this.cmbCopperFac.Location = new System.Drawing.Point(86, 132);
            this.cmbCopperFac.Name = "cmbCopperFac";
            this.cmbCopperFac.ReadOnly = false;
            this.cmbCopperFac.Size = new System.Drawing.Size(141, 20);
            this.cmbCopperFac.TabIndex = 2;
            this.cmbCopperFac.TMpEnabled = true;
            this.cmbCopperFac.ToolTipValid = null;
            this.cmbCopperFac.ValidEable = true;
            this.cmbCopperFac.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsCopperFac
            // 
            this.dsCopperFac.AutoLoad = true;
            this.dsCopperFac.AutoSubscribe = false;
            this.dsCopperFac.DataSetName = "L3DataSet";
            this.dsCopperFac.DeleteMethod = null;
            this.dsCopperFac.InsertMethod = null;
            this.dsCopperFac.L3DataAdapter = this.Adapter;
            this.dsCopperFac.LoadEvent = "Click";
            this.dsCopperFac.LoadTrigger = null;
            this.dsCopperFac.RefreshValve = 1000;
            this.dsCopperFac.SourceCommand = null;
            this.dsCopperFac.SourceCondition = "MATGROUP_CODE = \'MoldFac\' and MATNAME = \'铜管\'";
            this.dsCopperFac.SourceMethod = "";
            this.dsCopperFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCopperFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCopperFac.SubscribeTarget = null;
            this.dsCopperFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCopperFac});
            this.dsCopperFac.UpdateEvent = "Click";
            this.dsCopperFac.UpdateMethod = null;
            this.dsCopperFac.UpdateTrigger = null;
            // 
            // schemadsCopperFac
            // 
            this.schemadsCopperFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCopperFacL3DataTableMatFactory});
            this.schemadsCopperFac.TableName = "L3DataTable";
            // 
            // coldsCopperFacL3DataTableMatFactory
            // 
            this.coldsCopperFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.Namespace = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(24, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 18;
            this.label19.Text = "铜管厂家:";
            // 
            // txtCopperID
            // 
            this.txtCopperID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUseInfo, "COPPER_ID", true));
            this.txtCopperID.DisplayPrecision = 0;
            this.txtCopperID.EnableNull = false;
            this.txtCopperID.ErropPr = this.errorProvider1;
            this.txtCopperID.FixedLength = 0;
            this.txtCopperID.Length = 0;
            this.txtCopperID.Location = new System.Drawing.Point(86, 156);
            this.txtCopperID.Max = 0;
            this.txtCopperID.MaxNull = 0;
            this.txtCopperID.MaxStringLength = 0;
            this.txtCopperID.MaxStrLength = 0;
            this.txtCopperID.Min = 0;
            this.txtCopperID.MinNull = 0;
            this.txtCopperID.MinStringLength = 0;
            this.txtCopperID.MinStrLength = 0;
            this.txtCopperID.Name = "txtCopperID";
            this.txtCopperID.Precision = 0;
            this.txtCopperID.Regex = "";
            this.txtCopperID.Size = new System.Drawing.Size(141, 21);
            this.txtCopperID.TabIndex = 3;
            this.txtCopperID.ToolTipValid = this.toolTip1;
            this.txtCopperID.VaildWarning = "";
            this.txtCopperID.ValidEable = true;
            this.txtCopperID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(24, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 19;
            this.label21.Text = "铜管编号:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(48, 187);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 24;
            this.label46.Text = "备注:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUseInfo, "SHIFTID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(370, 130);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.ReadOnly = false;
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 13;
            this.cmbShiftID.TMpEnabled = true;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUseInfo, "TEAMID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(370, 107);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.ReadOnly = false;
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 12;
            this.cmbTeamID.TMpEnabled = true;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUseInfo, "OPERATOR", true));
            this.txtOperator.DisplayPrecision = 0;
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.FixedLength = 0;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(86, 84);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxNull = 0;
            this.txtOperator.MaxStringLength = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinNull = 0;
            this.txtOperator.MinStringLength = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Regex = "";
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 14;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.VaildWarning = "";
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(329, 136);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 30;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(329, 112);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 29;
            this.label45.Text = "班别:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(36, 88);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 31;
            this.label47.Text = "责任人:";
            // 
            // cmbStopReason
            // 
            this.cmbStopReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStopReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStopReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUseInfo, "STOP_REASON", true));
            this.cmbStopReason.DataSource = this.dsMoldStopReason;
            this.cmbStopReason.DisplayMember = "L3DataTable.Code_Des";
            this.cmbStopReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopReason.EnableNull = true;
            this.cmbStopReason.ErropPr = null;
            this.cmbStopReason.FormattingEnabled = true;
            this.cmbStopReason.Location = new System.Drawing.Point(370, 84);
            this.cmbStopReason.Name = "cmbStopReason";
            this.cmbStopReason.ReadOnly = false;
            this.cmbStopReason.Size = new System.Drawing.Size(141, 20);
            this.cmbStopReason.TabIndex = 6;
            this.cmbStopReason.TMpEnabled = true;
            this.cmbStopReason.ToolTipValid = null;
            this.cmbStopReason.ValidEable = true;
            this.cmbStopReason.ValueMember = "L3DataTable.Code";
            // 
            // dsMoldStopReason
            // 
            this.dsMoldStopReason.AutoLoad = true;
            this.dsMoldStopReason.AutoSubscribe = false;
            this.dsMoldStopReason.DataSetName = "L3DataSet";
            this.dsMoldStopReason.DeleteMethod = null;
            this.dsMoldStopReason.InsertMethod = null;
            this.dsMoldStopReason.L3DataAdapter = this.Adapter;
            this.dsMoldStopReason.LoadEvent = "Click";
            this.dsMoldStopReason.LoadTrigger = null;
            this.dsMoldStopReason.RefreshValve = 1000;
            this.dsMoldStopReason.SourceCommand = null;
            this.dsMoldStopReason.SourceCondition = "CODE_GROUP = \'MoldStopReason\'";
            this.dsMoldStopReason.SourceMethod = "";
            this.dsMoldStopReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMoldStopReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMoldStopReason.SubscribeTarget = null;
            this.dsMoldStopReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMoldStopReason});
            this.dsMoldStopReason.UpdateEvent = "Click";
            this.dsMoldStopReason.UpdateMethod = null;
            this.dsMoldStopReason.UpdateTrigger = null;
            // 
            // schemadsMoldStopReason
            // 
            this.schemadsMoldStopReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldStopReasonL3DataTableCode,
            this.coldsMoldStopReasonL3DataTableCode_Des});
            this.schemadsMoldStopReason.TableName = "L3DataTable";
            // 
            // coldsMoldStopReasonL3DataTableCode
            // 
            this.coldsMoldStopReasonL3DataTableCode.Caption = "Code";
            this.coldsMoldStopReasonL3DataTableCode.ColumnName = "Code";
            this.coldsMoldStopReasonL3DataTableCode.Namespace = "";
            // 
            // coldsMoldStopReasonL3DataTableCode_Des
            // 
            this.coldsMoldStopReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMoldStopReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMoldStopReasonL3DataTableCode_Des.Namespace = "";
            // 
            // cmbFlowID
            // 
            this.cmbFlowID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFlowID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFlowID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUseInfo, "FLOWID", true));
            this.cmbFlowID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlowID.EnableNull = true;
            this.cmbFlowID.ErropPr = null;
            this.cmbFlowID.FormattingEnabled = true;
            this.cmbFlowID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbFlowID.Location = new System.Drawing.Point(86, 60);
            this.cmbFlowID.Name = "cmbFlowID";
            this.cmbFlowID.ReadOnly = false;
            this.cmbFlowID.Size = new System.Drawing.Size(141, 20);
            this.cmbFlowID.TabIndex = 5;
            this.cmbFlowID.TMpEnabled = true;
            this.cmbFlowID.ToolTipValid = null;
            this.cmbFlowID.ValidEable = true;
            // 
            // cmbCastID
            // 
            this.cmbCastID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCastID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCastID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUseInfo, "CAST_ID", true));
            this.cmbCastID.DataSource = this.dsCasterID;
            this.cmbCastID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCastID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCastID.EnableNull = true;
            this.cmbCastID.ErropPr = this.errorProvider1;
            this.cmbCastID.FormattingEnabled = true;
            this.cmbCastID.Location = new System.Drawing.Point(86, 36);
            this.cmbCastID.Name = "cmbCastID";
            this.cmbCastID.ReadOnly = false;
            this.cmbCastID.Size = new System.Drawing.Size(141, 20);
            this.cmbCastID.TabIndex = 4;
            this.cmbCastID.TMpEnabled = true;
            this.cmbCastID.ToolTipValid = this.toolTip1;
            this.cmbCastID.ValidEable = true;
            this.cmbCastID.ValueMember = "L3DataTable.Code";
            this.cmbCastID.TextChanged += new System.EventHandler(this.cmbCastID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(305, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "下线原因:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "流号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "铸机号:";
            // 
            // txtTotalPullMea
            // 
            this.txtTotalPullMea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUseInfo, "TOTAL_PULL_MEA", true));
            this.txtTotalPullMea.DisplayPrecision = 0;
            this.txtTotalPullMea.EnableNull = false;
            this.txtTotalPullMea.ErropPr = this.errorProvider1;
            this.txtTotalPullMea.FixedLength = 0;
            this.txtTotalPullMea.Length = 0;
            this.txtTotalPullMea.Location = new System.Drawing.Point(370, 12);
            this.txtTotalPullMea.Max = 0;
            this.txtTotalPullMea.MaxNull = 0;
            this.txtTotalPullMea.MaxStringLength = 0;
            this.txtTotalPullMea.MaxStrLength = 0;
            this.txtTotalPullMea.Min = -0.99;
            this.txtTotalPullMea.MinNull = -0.99;
            this.txtTotalPullMea.MinStringLength = 0;
            this.txtTotalPullMea.MinStrLength = 0;
            this.txtTotalPullMea.Name = "txtTotalPullMea";
            this.txtTotalPullMea.Precision = 0;
            this.txtTotalPullMea.Regex = "";
            this.txtTotalPullMea.Size = new System.Drawing.Size(141, 21);
            this.txtTotalPullMea.TabIndex = 11;
            this.txtTotalPullMea.ToolTipValid = this.toolTip1;
            this.txtTotalPullMea.VaildWarning = "";
            this.txtTotalPullMea.ValidEable = true;
            this.txtTotalPullMea.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtTotalPullMea.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(305, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "上线时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(305, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "下线时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(293, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "拉钢量累计:";
            // 
            // cmbMoldID
            // 
            this.cmbMoldID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMoldID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMoldID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsUseInfo, "MOLDID", true));
            this.cmbMoldID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoldID.EnableNull = false;
            this.cmbMoldID.ErropPr = this.errorProvider1;
            this.cmbMoldID.FormattingEnabled = true;
            this.cmbMoldID.Location = new System.Drawing.Point(86, 108);
            this.cmbMoldID.Name = "cmbMoldID";
            this.cmbMoldID.ReadOnly = false;
            this.cmbMoldID.Size = new System.Drawing.Size(141, 20);
            this.cmbMoldID.TabIndex = 1;
            this.cmbMoldID.TMpEnabled = true;
            this.cmbMoldID.ToolTipValid = this.toolTip1;
            this.cmbMoldID.ValidEable = true;
            this.cmbMoldID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(12, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "结晶器编号:";
            // 
            // dtOffLine
            // 
            this.dtOffLine.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtOffLine.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsUseInfo, "OffLine_Time", true));
            this.dtOffLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOffLine.Location = new System.Drawing.Point(370, 60);
            this.dtOffLine.Name = "dtOffLine";
            this.dtOffLine.Size = new System.Drawing.Size(141, 21);
            this.dtOffLine.TabIndex = 0;
            // 
            // dtOnLine
            // 
            this.dtOnLine.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtOnLine.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsUseInfo, "OnLine_Time", true));
            this.dtOnLine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOnLine.Location = new System.Drawing.Point(370, 36);
            this.dtOnLine.Name = "dtOnLine";
            this.dtOnLine.Size = new System.Drawing.Size(141, 21);
            this.dtOnLine.TabIndex = 0;
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsUseInfo, "INPUT_TIME", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(86, 12);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(24, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "录入时间:";
            // 
            // dsJ06
            // 
            this.dsJ06.AutoLoad = true;
            this.dsJ06.AutoSubscribe = false;
            this.dsJ06.DataSetName = "L3DataSet";
            this.dsJ06.DeleteMethod = null;
            this.dsJ06.InsertMethod = null;
            this.dsJ06.L3DataAdapter = this.Adapter;
            this.dsJ06.LoadEvent = "Click";
            this.dsJ06.LoadTrigger = null;
            this.dsJ06.RefreshValve = 1000;
            this.dsJ06.SourceCommand = null;
            this.dsJ06.SourceCondition = "MoldID like \'J06%\'";
            this.dsJ06.SourceMethod = "";
            this.dsJ06.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsJ06.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsJ06.SubscribeTarget = null;
            this.dsJ06.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsJ06});
            this.dsJ06.UpdateEvent = "Click";
            this.dsJ06.UpdateMethod = null;
            this.dsJ06.UpdateTrigger = null;
            // 
            // schemadsJ06
            // 
            this.schemadsJ06.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsJ06L3DataTableMoldID});
            this.schemadsJ06.TableName = "L3DataTable";
            // 
            // coldsJ06L3DataTableMoldID
            // 
            this.coldsJ06L3DataTableMoldID.Caption = "MoldID";
            this.coldsJ06L3DataTableMoldID.ColumnName = "MoldID";
            this.coldsJ06L3DataTableMoldID.Namespace = "";
            // 
            // dsJ09
            // 
            this.dsJ09.AutoLoad = true;
            this.dsJ09.AutoSubscribe = false;
            this.dsJ09.DataSetName = "L3DataSet";
            this.dsJ09.DeleteMethod = null;
            this.dsJ09.InsertMethod = null;
            this.dsJ09.L3DataAdapter = this.Adapter;
            this.dsJ09.LoadEvent = "Click";
            this.dsJ09.LoadTrigger = null;
            this.dsJ09.RefreshValve = 1000;
            this.dsJ09.SourceCommand = null;
            this.dsJ09.SourceCondition = "MoldID Like \'J0%\' or MoldID Like \'J9%\' order by MoldID ASC";
            //this.dsJ09.SourceCondition = "MoldID like \'J09%\'";
            this.dsJ09.SourceMethod = "";
            this.dsJ09.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsJ09.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsJ09.SubscribeTarget = null;
            this.dsJ09.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsJ09});
            this.dsJ09.UpdateEvent = "Click";
            this.dsJ09.UpdateMethod = null;
            this.dsJ09.UpdateTrigger = null;
            // 
            // schemadsJ09
            // 
            this.schemadsJ09.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsJ09L3DataTableMoldID});
            this.schemadsJ09.TableName = "L3DataTable";
            // 
            // coldsJ09L3DataTableMoldID
            // 
            this.coldsJ09L3DataTableMoldID.Caption = "MoldID";
            this.coldsJ09L3DataTableMoldID.ColumnName = "MoldID";
            this.coldsJ09L3DataTableMoldID.Namespace = "";
            // 
            // MoldPipeParUseShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 335);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MoldPipeParUseShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结晶器铜管使用信息";
            this.Load += new System.EventHandler(this.MoldPipeParUseShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsUseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldStopReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldStopReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJ06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJ06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJ09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJ09)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsUseInfo;
        private AppSvrHMI.L3DataSet dsUseInfo;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsUseInfo;
        private System.Data.DataColumn coldsUseInfoL3DataTableGUID;
        private System.Data.DataColumn coldsUseInfoL3DataTableNAME;
        private System.Data.DataColumn coldsUseInfoL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsUseInfoL3DataTableMOLDID;
        private System.Data.DataColumn coldsUseInfoL3DataTableCOPPER_ID;
        private System.Data.DataColumn coldsUseInfoL3DataTableCOPPER_FAC;
        private System.Data.DataColumn coldsUseInfoL3DataTableCUR_USE_COUNT;
        private System.Data.DataColumn coldsUseInfoL3DataTableTOTAL_USE_COUNT;
        private System.Data.DataColumn coldsUseInfoL3DataTableCUR_PULL_MEA;
        private System.Data.DataColumn coldsUseInfoL3DataTableTOTAL_PULL_MEA;
        private System.Data.DataColumn coldsUseInfoL3DataTableCAST_ID;
        private System.Data.DataColumn coldsUseInfoL3DataTableFLOWID;
        private System.Data.DataColumn coldsUseInfoL3DataTableSTOP_REASON;
        private System.Data.DataColumn coldsUseInfoL3DataTableRULER;
        private System.Data.DataColumn coldsUseInfoL3DataTableTEAMID;
        private System.Data.DataColumn coldsUseInfoL3DataTableSHIFTID;
        private System.Data.DataColumn coldsUseInfoL3DataTableOPERATOR;
        private System.Data.DataColumn coldsUseInfoL3DataTableNOTE;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbCopperFac;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxTextBox txtCopperID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxComboBox cmbStopReason;
        private PxDataValid.PxComboBox cmbFlowID;
        private PxDataValid.PxComboBox cmbCastID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox txtTotalPullMea;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxComboBox cmbMoldID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label9;
        private AppSvrHMI.L3DataSet dsJ06;
        private System.Data.DataTable schemadsJ06;
        private System.Data.DataColumn coldsJ06L3DataTableMoldID;
        private AppSvrHMI.L3DataSet dsJ09;
        private System.Data.DataTable schemadsJ09;
        private System.Data.DataColumn coldsJ09L3DataTableMoldID;
        private AppSvrHMI.L3DataSet dsMoldStopReason;
        private System.Data.DataTable schemadsMoldStopReason;
        private System.Data.DataColumn coldsMoldStopReasonL3DataTableCode;
        private System.Data.DataColumn coldsMoldStopReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCopperFac;
        private System.Data.DataTable schemadsCopperFac;
        private System.Data.DataColumn coldsCopperFacL3DataTableMatFactory;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtOffLine;
        private System.Windows.Forms.DateTimePicker dtOnLine;
        private System.Data.DataColumn coldsUseInfoL3DataTableOnLine_Flag;
        private System.Data.DataColumn coldsUseInfoL3DataTableOnLine_Time;
        private System.Data.DataColumn coldsUseInfoL3DataTableOffLine_Flag;
        private System.Data.DataColumn coldsUseInfoL3DataTableOffLine_Time;
        private System.Data.DataColumn coldsUseInfoL3DataTableInStallID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}