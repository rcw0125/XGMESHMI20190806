namespace EquipMag.MoldMag
{
    partial class MoldPipeParUseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoldPipeParUseMagFrm));
            this.bsM = new System.Windows.Forms.BindingSource(this.components);
            this.dsM = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.cmdM = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpM = new AppSvrHMI.L3CommandParameter();
            this.schemadsM = new System.Data.DataTable();
            this.coldsML3DataTableGUID = new System.Data.DataColumn();
            this.coldsML3DataTableNAME = new System.Data.DataColumn();
            this.coldsML3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsML3DataTableMOLDID = new System.Data.DataColumn();
            this.coldsML3DataTableCOPPER_ID = new System.Data.DataColumn();
            this.coldsML3DataTableCOPPER_FAC = new System.Data.DataColumn();
            this.coldsML3DataTableCUR_USE_COUNT = new System.Data.DataColumn();
            this.coldsML3DataTableTOTAL_USE_COUNT = new System.Data.DataColumn();
            this.coldsML3DataTableCUR_PULL_MEA = new System.Data.DataColumn();
            this.coldsML3DataTableTOTAL_PULL_MEA = new System.Data.DataColumn();
            this.coldsML3DataTableCAST_ID = new System.Data.DataColumn();
            this.coldsML3DataTableFLOWID = new System.Data.DataColumn();
            this.coldsML3DataTableSTOP_REASON = new System.Data.DataColumn();
            this.coldsML3DataTableRULER = new System.Data.DataColumn();
            this.coldsML3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsML3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsML3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableNOTE = new System.Data.DataColumn();
            this.coldsML3DataTableOnLine_Flag = new System.Data.DataColumn();
            this.coldsML3DataTableOnLine_Time = new System.Data.DataColumn();
            this.coldsML3DataTableOffLine_Flag = new System.Data.DataColumn();
            this.coldsML3DataTableOffLine_Time = new System.Data.DataColumn();
            this.coldsML3DataTableInStallID = new System.Data.DataColumn();
            this.coldsML3DataTableConfirmFlag = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmbMoldID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLOWIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOLDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStallID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOPPERFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOPPERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURUSECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALUSECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURPULLMEADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALPULLMEADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnLine_Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnLine_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOPREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMoldStopReason = new AppSvrHMI.L3DataSet();
            this.schemadsMoldStopReason = new System.Data.DataTable();
            this.coldsMoldStopReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsMoldStopReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.OffLine_Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffLine_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rULERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsMoldID = new AppSvrHMI.L3DataSet();
            this.schemadsMoldID = new System.Data.DataTable();
            this.coldsMoldIDL3DataTableMoldID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldStopReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldStopReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsM
            // 
            this.bsM.DataMember = "L3DataTable";
            this.bsM.DataSource = this.dsM;
            // 
            // dsM
            // 
            this.dsM.AutoLoad = true;
            this.dsM.AutoSubscribe = true;
            this.dsM.DataSetName = "L3DataSet";
            this.dsM.DeleteMethod = "DeletePipeUseInfo";
            this.dsM.InsertMethod = "InsertPipeUseInfo";
            this.dsM.L3DataAdapter = this.Adapter;
            this.dsM.LoadEvent = "Click";
            this.dsM.LoadTrigger = null;
            this.dsM.RefreshValve = 1000;
            this.dsM.SourceCommand = this.cmdM;
            this.dsM.SourceCondition = null;
            this.dsM.SourceMethod = "GetPipeUseInfo";
            this.dsM.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsM.SourceURI = "XGMESLogic\\MoldMag\\CMold_Mag\\MoldMag";
            this.dsM.SubscribeTarget = null;
            this.dsM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsM});
            this.dsM.UpdateEvent = "Click";
            this.dsM.UpdateMethod = "UpdatePipeUseInfo";
            this.dsM.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "MoldPipeParUsebtnAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "MoldPipeParUsebtnDel");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "MoldPipeParUsebtnAdd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "MoldPipeParUsebtnConfirm");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdM
            // 
            this.cmdM.Adapter = null;
            this.cmdM.MergeReturnTarget = false;
            this.cmdM.Method = null;
            this.cmdM.Object = null;
            this.cmdM.Parameters.Add(this.l3cmdpM);
            this.cmdM.ReturnTarget = null;
            this.cmdM.ReturnTargetProperty = null;
            this.cmdM.Trigger = null;
            this.cmdM.TriggerEvent = "Click";
            // 
            // l3cmdpM
            // 
            this.l3cmdpM.AcceptAfterExecuted = false;
            this.l3cmdpM.ConstantValue = null;
            this.l3cmdpM.MergeTarget = false;
            this.l3cmdpM.SourceFilter = null;
            this.l3cmdpM.SourceObject = null;
            this.l3cmdpM.SourceProperty = null;
            this.l3cmdpM.TargetObject = null;
            this.l3cmdpM.TargetProperty = null;
            // 
            // schemadsM
            // 
            this.schemadsM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsML3DataTableGUID,
            this.coldsML3DataTableNAME,
            this.coldsML3DataTableINPUT_TIME,
            this.coldsML3DataTableMOLDID,
            this.coldsML3DataTableCOPPER_ID,
            this.coldsML3DataTableCOPPER_FAC,
            this.coldsML3DataTableCUR_USE_COUNT,
            this.coldsML3DataTableTOTAL_USE_COUNT,
            this.coldsML3DataTableCUR_PULL_MEA,
            this.coldsML3DataTableTOTAL_PULL_MEA,
            this.coldsML3DataTableCAST_ID,
            this.coldsML3DataTableFLOWID,
            this.coldsML3DataTableSTOP_REASON,
            this.coldsML3DataTableRULER,
            this.coldsML3DataTableTEAMID,
            this.coldsML3DataTableSHIFTID,
            this.coldsML3DataTableOPERATOR,
            this.coldsML3DataTableNOTE,
            this.coldsML3DataTableOnLine_Flag,
            this.coldsML3DataTableOnLine_Time,
            this.coldsML3DataTableOffLine_Flag,
            this.coldsML3DataTableOffLine_Time,
            this.coldsML3DataTableInStallID,
            this.coldsML3DataTableConfirmFlag});
            this.schemadsM.TableName = "L3DataTable";
            // 
            // coldsML3DataTableGUID
            // 
            this.coldsML3DataTableGUID.Caption = "GUID";
            this.coldsML3DataTableGUID.ColumnName = "GUID";
            this.coldsML3DataTableGUID.DefaultValue = "";
            this.coldsML3DataTableGUID.Namespace = "";
            // 
            // coldsML3DataTableNAME
            // 
            this.coldsML3DataTableNAME.Caption = "NAME";
            this.coldsML3DataTableNAME.ColumnName = "NAME";
            this.coldsML3DataTableNAME.DefaultValue = "";
            this.coldsML3DataTableNAME.Namespace = "";
            // 
            // coldsML3DataTableINPUT_TIME
            // 
            this.coldsML3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsML3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsML3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsML3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsML3DataTableMOLDID
            // 
            this.coldsML3DataTableMOLDID.Caption = "MOLDID";
            this.coldsML3DataTableMOLDID.ColumnName = "MOLDID";
            this.coldsML3DataTableMOLDID.DefaultValue = "";
            this.coldsML3DataTableMOLDID.Namespace = "";
            // 
            // coldsML3DataTableCOPPER_ID
            // 
            this.coldsML3DataTableCOPPER_ID.Caption = "COPPER_ID";
            this.coldsML3DataTableCOPPER_ID.ColumnName = "COPPER_ID";
            this.coldsML3DataTableCOPPER_ID.DefaultValue = "";
            this.coldsML3DataTableCOPPER_ID.Namespace = "";
            // 
            // coldsML3DataTableCOPPER_FAC
            // 
            this.coldsML3DataTableCOPPER_FAC.Caption = "COPPER_FAC";
            this.coldsML3DataTableCOPPER_FAC.ColumnName = "COPPER_FAC";
            this.coldsML3DataTableCOPPER_FAC.DefaultValue = "";
            this.coldsML3DataTableCOPPER_FAC.Namespace = "";
            // 
            // coldsML3DataTableCUR_USE_COUNT
            // 
            this.coldsML3DataTableCUR_USE_COUNT.Caption = "CUR_USE_COUNT";
            this.coldsML3DataTableCUR_USE_COUNT.ColumnName = "CUR_USE_COUNT";
            this.coldsML3DataTableCUR_USE_COUNT.DataType = typeof(int);
            this.coldsML3DataTableCUR_USE_COUNT.DefaultValue = 0;
            this.coldsML3DataTableCUR_USE_COUNT.Namespace = "";
            // 
            // coldsML3DataTableTOTAL_USE_COUNT
            // 
            this.coldsML3DataTableTOTAL_USE_COUNT.Caption = "TOTAL_USE_COUNT";
            this.coldsML3DataTableTOTAL_USE_COUNT.ColumnName = "TOTAL_USE_COUNT";
            this.coldsML3DataTableTOTAL_USE_COUNT.DataType = typeof(int);
            this.coldsML3DataTableTOTAL_USE_COUNT.DefaultValue = 0;
            this.coldsML3DataTableTOTAL_USE_COUNT.Namespace = "";
            // 
            // coldsML3DataTableCUR_PULL_MEA
            // 
            this.coldsML3DataTableCUR_PULL_MEA.Caption = "CUR_PULL_MEA";
            this.coldsML3DataTableCUR_PULL_MEA.ColumnName = "CUR_PULL_MEA";
            this.coldsML3DataTableCUR_PULL_MEA.DataType = typeof(double);
            this.coldsML3DataTableCUR_PULL_MEA.DefaultValue = 0;
            this.coldsML3DataTableCUR_PULL_MEA.Namespace = "";
            // 
            // coldsML3DataTableTOTAL_PULL_MEA
            // 
            this.coldsML3DataTableTOTAL_PULL_MEA.Caption = "TOTAL_PULL_MEA";
            this.coldsML3DataTableTOTAL_PULL_MEA.ColumnName = "TOTAL_PULL_MEA";
            this.coldsML3DataTableTOTAL_PULL_MEA.DataType = typeof(double);
            this.coldsML3DataTableTOTAL_PULL_MEA.DefaultValue = 0;
            this.coldsML3DataTableTOTAL_PULL_MEA.Namespace = "";
            // 
            // coldsML3DataTableCAST_ID
            // 
            this.coldsML3DataTableCAST_ID.Caption = "CAST_ID";
            this.coldsML3DataTableCAST_ID.ColumnName = "CAST_ID";
            this.coldsML3DataTableCAST_ID.DefaultValue = "";
            this.coldsML3DataTableCAST_ID.Namespace = "";
            // 
            // coldsML3DataTableFLOWID
            // 
            this.coldsML3DataTableFLOWID.Caption = "FLOWID";
            this.coldsML3DataTableFLOWID.ColumnName = "FLOWID";
            this.coldsML3DataTableFLOWID.DefaultValue = "";
            this.coldsML3DataTableFLOWID.Namespace = "";
            // 
            // coldsML3DataTableSTOP_REASON
            // 
            this.coldsML3DataTableSTOP_REASON.Caption = "STOP_REASON";
            this.coldsML3DataTableSTOP_REASON.ColumnName = "STOP_REASON";
            this.coldsML3DataTableSTOP_REASON.DefaultValue = "";
            this.coldsML3DataTableSTOP_REASON.Namespace = "";
            // 
            // coldsML3DataTableRULER
            // 
            this.coldsML3DataTableRULER.Caption = "RULER";
            this.coldsML3DataTableRULER.ColumnName = "RULER";
            this.coldsML3DataTableRULER.DataType = typeof(double);
            this.coldsML3DataTableRULER.DefaultValue = 0;
            this.coldsML3DataTableRULER.Namespace = "";
            // 
            // coldsML3DataTableTEAMID
            // 
            this.coldsML3DataTableTEAMID.Caption = "TEAMID";
            this.coldsML3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsML3DataTableTEAMID.DefaultValue = "";
            this.coldsML3DataTableTEAMID.Namespace = "";
            // 
            // coldsML3DataTableSHIFTID
            // 
            this.coldsML3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsML3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsML3DataTableSHIFTID.DefaultValue = "";
            this.coldsML3DataTableSHIFTID.Namespace = "";
            // 
            // coldsML3DataTableOPERATOR
            // 
            this.coldsML3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsML3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsML3DataTableOPERATOR.DefaultValue = "";
            this.coldsML3DataTableOPERATOR.Namespace = "";
            // 
            // coldsML3DataTableNOTE
            // 
            this.coldsML3DataTableNOTE.Caption = "NOTE";
            this.coldsML3DataTableNOTE.ColumnName = "NOTE";
            this.coldsML3DataTableNOTE.DefaultValue = "";
            this.coldsML3DataTableNOTE.Namespace = "";
            // 
            // coldsML3DataTableOnLine_Flag
            // 
            this.coldsML3DataTableOnLine_Flag.Caption = "OnLine_Flag";
            this.coldsML3DataTableOnLine_Flag.ColumnName = "OnLine_Flag";
            this.coldsML3DataTableOnLine_Flag.DataType = typeof(int);
            this.coldsML3DataTableOnLine_Flag.Namespace = "";
            // 
            // coldsML3DataTableOnLine_Time
            // 
            this.coldsML3DataTableOnLine_Time.Caption = "OnLine_Time";
            this.coldsML3DataTableOnLine_Time.ColumnName = "OnLine_Time";
            this.coldsML3DataTableOnLine_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableOnLine_Time.Namespace = "";
            // 
            // coldsML3DataTableOffLine_Flag
            // 
            this.coldsML3DataTableOffLine_Flag.Caption = "OffLine_Flag";
            this.coldsML3DataTableOffLine_Flag.ColumnName = "OffLine_Flag";
            this.coldsML3DataTableOffLine_Flag.DataType = typeof(int);
            this.coldsML3DataTableOffLine_Flag.Namespace = "";
            // 
            // coldsML3DataTableOffLine_Time
            // 
            this.coldsML3DataTableOffLine_Time.Caption = "OffLine_Time";
            this.coldsML3DataTableOffLine_Time.ColumnName = "OffLine_Time";
            this.coldsML3DataTableOffLine_Time.DataType = typeof(System.DateTime);
            this.coldsML3DataTableOffLine_Time.Namespace = "";
            // 
            // coldsML3DataTableInStallID
            // 
            this.coldsML3DataTableInStallID.Caption = "InStallID";
            this.coldsML3DataTableInStallID.ColumnName = "InStallID";
            this.coldsML3DataTableInStallID.Namespace = "";
            // 
            // coldsML3DataTableConfirmFlag
            // 
            this.coldsML3DataTableConfirmFlag.Caption = "ConfirmFlag";
            this.coldsML3DataTableConfirmFlag.ColumnName = "ConfirmFlag";
            this.coldsML3DataTableConfirmFlag.DataType = typeof(int);
            this.coldsML3DataTableConfirmFlag.Namespace = "";
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bdN1, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsM;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.cmbMoldID,
            this.toolStripLabel3,
            this.toolStripLabel5,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel6,
            this.cmbCasterID,
            this.toolStripLabel2});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 27;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbMoldID
            // 
            this.cmbMoldID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbMoldID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMoldID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMoldID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoldID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMoldID.Name = "cmbMoldID";
            this.cmbMoldID.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "结晶器号:";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
            // 
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(85, 22);
            this.dtEnd.Text = "2008-11-16";
            this.dtEnd.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 884);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel4.Text = "-";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(85, 22);
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "录入日期:";
            // 
            // cmbCasterID
            // 
            this.cmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCasterID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCasterID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCasterID.Items.AddRange(new object[] {
            "",
            "S61",
            "S62",
            "S63",
            "S64",
            "S65",
            "S67",
            "S66"});
            this.cmbCasterID.Name = "cmbCasterID";
            this.cmbCasterID.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "铸机号:";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 26;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvM
            // 
            this.dvM.AllowUserToAddRows = false;
            this.dvM.AutoGenerateColumns = false;
            this.dvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.cASTIDDataGridViewTextBoxColumn,
            this.fLOWIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.mOLDIDDataGridViewTextBoxColumn,
            this.InStallID,
            this.cOPPERFACDataGridViewTextBoxColumn,
            this.cOPPERIDDataGridViewTextBoxColumn,
            this.cURUSECOUNTDataGridViewTextBoxColumn,
            this.tOTALUSECOUNTDataGridViewTextBoxColumn,
            this.cURPULLMEADataGridViewTextBoxColumn,
            this.tOTALPULLMEADataGridViewTextBoxColumn,
            this.OnLine_Flag,
            this.OnLine_Time,
            this.sTOPREASONDataGridViewTextBoxColumn,
            this.OffLine_Flag,
            this.OffLine_Time,
            this.rULERDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.ConfirmFlag,
            this.nAMEDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsM;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.Margin = new System.Windows.Forms.Padding(0);
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(1000, 632);
            this.dvM.TabIndex = 31;
            this.dvM.Sorted += new System.EventHandler(this.dvM_Sorted);
            this.dvM.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvM_CellContentDoubleClick);
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "日期";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // cASTIDDataGridViewTextBoxColumn
            // 
            this.cASTIDDataGridViewTextBoxColumn.DataPropertyName = "CAST_ID";
            this.cASTIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cASTIDDataGridViewTextBoxColumn.Name = "cASTIDDataGridViewTextBoxColumn";
            this.cASTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // fLOWIDDataGridViewTextBoxColumn
            // 
            this.fLOWIDDataGridViewTextBoxColumn.DataPropertyName = "FLOWID";
            this.fLOWIDDataGridViewTextBoxColumn.HeaderText = "流号";
            this.fLOWIDDataGridViewTextBoxColumn.Name = "fLOWIDDataGridViewTextBoxColumn";
            this.fLOWIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fLOWIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn.Width = 66;
            // 
            // mOLDIDDataGridViewTextBoxColumn
            // 
            this.mOLDIDDataGridViewTextBoxColumn.DataPropertyName = "MOLDID";
            this.mOLDIDDataGridViewTextBoxColumn.HeaderText = "结晶器编号";
            this.mOLDIDDataGridViewTextBoxColumn.Name = "mOLDIDDataGridViewTextBoxColumn";
            this.mOLDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mOLDIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // InStallID
            // 
            this.InStallID.DataPropertyName = "InStallID";
            this.InStallID.HeaderText = "装配编号";
            this.InStallID.Name = "InStallID";
            this.InStallID.ReadOnly = true;
            this.InStallID.Width = 78;
            // 
            // cOPPERFACDataGridViewTextBoxColumn
            // 
            this.cOPPERFACDataGridViewTextBoxColumn.DataPropertyName = "COPPER_FAC";
            this.cOPPERFACDataGridViewTextBoxColumn.HeaderText = "铜管厂家";
            this.cOPPERFACDataGridViewTextBoxColumn.Name = "cOPPERFACDataGridViewTextBoxColumn";
            this.cOPPERFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOPPERFACDataGridViewTextBoxColumn.Width = 78;
            // 
            // cOPPERIDDataGridViewTextBoxColumn
            // 
            this.cOPPERIDDataGridViewTextBoxColumn.DataPropertyName = "COPPER_ID";
            this.cOPPERIDDataGridViewTextBoxColumn.HeaderText = "铜管编号";
            this.cOPPERIDDataGridViewTextBoxColumn.Name = "cOPPERIDDataGridViewTextBoxColumn";
            this.cOPPERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOPPERIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // cURUSECOUNTDataGridViewTextBoxColumn
            // 
            this.cURUSECOUNTDataGridViewTextBoxColumn.DataPropertyName = "CUR_USE_COUNT";
            this.cURUSECOUNTDataGridViewTextBoxColumn.HeaderText = "当班使用次数";
            this.cURUSECOUNTDataGridViewTextBoxColumn.Name = "cURUSECOUNTDataGridViewTextBoxColumn";
            this.cURUSECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURUSECOUNTDataGridViewTextBoxColumn.Visible = false;
            this.cURUSECOUNTDataGridViewTextBoxColumn.Width = 102;
            // 
            // tOTALUSECOUNTDataGridViewTextBoxColumn
            // 
            this.tOTALUSECOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_USE_COUNT";
            this.tOTALUSECOUNTDataGridViewTextBoxColumn.HeaderText = "使用次数累计";
            this.tOTALUSECOUNTDataGridViewTextBoxColumn.Name = "tOTALUSECOUNTDataGridViewTextBoxColumn";
            this.tOTALUSECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALUSECOUNTDataGridViewTextBoxColumn.Visible = false;
            this.tOTALUSECOUNTDataGridViewTextBoxColumn.Width = 102;
            // 
            // cURPULLMEADataGridViewTextBoxColumn
            // 
            this.cURPULLMEADataGridViewTextBoxColumn.DataPropertyName = "CUR_PULL_MEA";
            this.cURPULLMEADataGridViewTextBoxColumn.HeaderText = "当班拉钢量";
            this.cURPULLMEADataGridViewTextBoxColumn.Name = "cURPULLMEADataGridViewTextBoxColumn";
            this.cURPULLMEADataGridViewTextBoxColumn.ReadOnly = true;
            this.cURPULLMEADataGridViewTextBoxColumn.Visible = false;
            this.cURPULLMEADataGridViewTextBoxColumn.Width = 90;
            // 
            // tOTALPULLMEADataGridViewTextBoxColumn
            // 
            this.tOTALPULLMEADataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PULL_MEA";
            this.tOTALPULLMEADataGridViewTextBoxColumn.HeaderText = "拉钢量累计";
            this.tOTALPULLMEADataGridViewTextBoxColumn.Name = "tOTALPULLMEADataGridViewTextBoxColumn";
            this.tOTALPULLMEADataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALPULLMEADataGridViewTextBoxColumn.Width = 90;
            // 
            // OnLine_Flag
            // 
            this.OnLine_Flag.DataPropertyName = "OnLine_Flag";
            this.OnLine_Flag.HeaderText = "上线标志";
            this.OnLine_Flag.Name = "OnLine_Flag";
            this.OnLine_Flag.ReadOnly = true;
            this.OnLine_Flag.Visible = false;
            this.OnLine_Flag.Width = 78;
            // 
            // OnLine_Time
            // 
            this.OnLine_Time.DataPropertyName = "OnLine_Time";
            this.OnLine_Time.HeaderText = "上线时间";
            this.OnLine_Time.Name = "OnLine_Time";
            this.OnLine_Time.ReadOnly = true;
            this.OnLine_Time.Width = 78;
            // 
            // sTOPREASONDataGridViewTextBoxColumn
            // 
            this.sTOPREASONDataGridViewTextBoxColumn.DataPropertyName = "STOP_REASON";
            this.sTOPREASONDataGridViewTextBoxColumn.DataSource = this.dsMoldStopReason;
            this.sTOPREASONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sTOPREASONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sTOPREASONDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.sTOPREASONDataGridViewTextBoxColumn.Name = "sTOPREASONDataGridViewTextBoxColumn";
            this.sTOPREASONDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOPREASONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sTOPREASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sTOPREASONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sTOPREASONDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsMoldStopReason
            // 
            this.dsMoldStopReason.AutoLoad = true;
            this.dsMoldStopReason.AutoSubscribe = true;
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
            // OffLine_Flag
            // 
            this.OffLine_Flag.DataPropertyName = "OffLine_Flag";
            this.OffLine_Flag.HeaderText = "下线标志";
            this.OffLine_Flag.Name = "OffLine_Flag";
            this.OffLine_Flag.ReadOnly = true;
            this.OffLine_Flag.Visible = false;
            this.OffLine_Flag.Width = 78;
            // 
            // OffLine_Time
            // 
            this.OffLine_Time.DataPropertyName = "OffLine_Time";
            this.OffLine_Time.HeaderText = "下线时间";
            this.OffLine_Time.Name = "OffLine_Time";
            this.OffLine_Time.ReadOnly = true;
            this.OffLine_Time.Width = 78;
            // 
            // rULERDataGridViewTextBoxColumn
            // 
            this.rULERDataGridViewTextBoxColumn.DataPropertyName = "RULER";
            this.rULERDataGridViewTextBoxColumn.HeaderText = "定尺[mm]";
            this.rULERDataGridViewTextBoxColumn.Name = "rULERDataGridViewTextBoxColumn";
            this.rULERDataGridViewTextBoxColumn.ReadOnly = true;
            this.rULERDataGridViewTextBoxColumn.Visible = false;
            this.rULERDataGridViewTextBoxColumn.Width = 78;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.tEAMIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = true;
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
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = true;
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
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 54;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // ConfirmFlag
            // 
            this.ConfirmFlag.DataPropertyName = "ConfirmFlag";
            this.ConfirmFlag.HeaderText = "实绩确认标志";
            this.ConfirmFlag.Name = "ConfirmFlag";
            this.ConfirmFlag.ReadOnly = true;
            this.ConfirmFlag.Visible = false;
            this.ConfirmFlag.Width = 102;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            this.nAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsMoldID
            // 
            this.dsMoldID.AutoLoad = true;
            this.dsMoldID.AutoSubscribe = true;
            this.dsMoldID.DataSetName = "L3DataSet";
            this.dsMoldID.DeleteMethod = null;
            this.dsMoldID.InsertMethod = null;
            this.dsMoldID.L3DataAdapter = this.Adapter;
            this.dsMoldID.LoadEvent = "Click";
            this.dsMoldID.LoadTrigger = null;
            this.dsMoldID.RefreshValve = 1000;
            this.dsMoldID.SourceCommand = null;
            this.dsMoldID.SourceCondition = "MoldID Like \'J0%\' or MoldID Like \'J9%\' order by MoldID ASC";
            this.dsMoldID.SourceMethod = "";
            this.dsMoldID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMoldID.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsMoldID.SubscribeTarget = null;
            this.dsMoldID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMoldID});
            this.dsMoldID.UpdateEvent = "Click";
            this.dsMoldID.UpdateMethod = null;
            this.dsMoldID.UpdateTrigger = null;
            // 
            // schemadsMoldID
            // 
            this.schemadsMoldID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldIDL3DataTableMoldID});
            this.schemadsMoldID.TableName = "L3DataTable";
            // 
            // coldsMoldIDL3DataTableMoldID
            // 
            this.coldsMoldIDL3DataTableMoldID.Caption = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.Namespace = "";
            // 
            // MoldPipeParUseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoldPipeParUseMagFrm";
            this.TabText = "结晶器铜管使用实绩管理";
            this.Load += new System.EventHandler(this.MoldPipeParUseMagFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoldPipeParUseMagFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldStopReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldStopReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsM;
        private System.Windows.Forms.BindingSource bsM;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbMoldID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsMoldID;
        private AppSvrHMI.L3Command cmdM;
        private System.Data.DataTable schemadsM;
        private System.Data.DataColumn coldsML3DataTableGUID;
        private System.Data.DataColumn coldsML3DataTableNAME;
        private System.Data.DataColumn coldsML3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsML3DataTableMOLDID;
        private System.Data.DataColumn coldsML3DataTableCOPPER_ID;
        private System.Data.DataColumn coldsML3DataTableCOPPER_FAC;
        private System.Data.DataColumn coldsML3DataTableCUR_USE_COUNT;
        private System.Data.DataColumn coldsML3DataTableTOTAL_USE_COUNT;
        private System.Data.DataColumn coldsML3DataTableCUR_PULL_MEA;
        private System.Data.DataColumn coldsML3DataTableTOTAL_PULL_MEA;
        private System.Data.DataColumn coldsML3DataTableCAST_ID;
        private System.Data.DataColumn coldsML3DataTableFLOWID;
        private System.Data.DataColumn coldsML3DataTableSTOP_REASON;
        private System.Data.DataColumn coldsML3DataTableRULER;
        private System.Data.DataColumn coldsML3DataTableTEAMID;
        private System.Data.DataColumn coldsML3DataTableSHIFTID;
        private System.Data.DataColumn coldsML3DataTableOPERATOR;
        private System.Data.DataColumn coldsML3DataTableNOTE;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsMoldID;
        private System.Data.DataColumn coldsMoldIDL3DataTableMoldID;
        private AppSvrHMI.L3CommandParameter l3cmdpM;
        private AppSvrHMI.L3DataSet dsMoldStopReason;
        private System.Data.DataTable schemadsMoldStopReason;
        private System.Data.DataColumn coldsMoldStopReasonL3DataTableCode;
        private System.Data.DataColumn coldsMoldStopReasonL3DataTableCode_Des;
        private System.Data.DataColumn coldsML3DataTableOnLine_Flag;
        private System.Data.DataColumn coldsML3DataTableOnLine_Time;
        private System.Data.DataColumn coldsML3DataTableOffLine_Flag;
        private System.Data.DataColumn coldsML3DataTableOffLine_Time;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Data.DataColumn coldsML3DataTableInStallID;
        private System.Data.DataColumn coldsML3DataTableConfirmFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLOWIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOLDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStallID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOPPERFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOPPERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURUSECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALUSECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURPULLMEADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALPULLMEADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnLine_Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnLine_Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn sTOPREASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffLine_Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffLine_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn rULERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripComboBox cmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}