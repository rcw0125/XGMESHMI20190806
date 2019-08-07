namespace EquipMag.LanceMag
{
    partial class LanceDefendMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanceDefendMagFrm));
            this.bsM = new System.Windows.Forms.BindingSource(this.components);
            this.dsM = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdM = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpM = new AppSvrHMI.L3CommandParameter();
            this.schemadsM = new System.Data.DataTable();
            this.coldsML3DataTableGUID = new System.Data.DataColumn();
            this.coldsML3DataTableNAME = new System.Data.DataColumn();
            this.coldsML3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsML3DataTableLANCEID = new System.Data.DataColumn();
            this.coldsML3DataTableCHECK_DATE = new System.Data.DataColumn();
            this.coldsML3DataTableLANCE_HEAD_TYPE = new System.Data.DataColumn();
            this.coldsML3DataTableMAKEID = new System.Data.DataColumn();
            this.coldsML3DataTableNOZZLE_FACTURY = new System.Data.DataColumn();
            this.coldsML3DataTableNOZZLE_THROAT_DIA = new System.Data.DataColumn();
            this.coldsML3DataTableNOZZLE_ANGLE = new System.Data.DataColumn();
            this.coldsML3DataTableWELD_OPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableSUPPRESS_OPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableTEST_WATER_PRESSURE = new System.Data.DataColumn();
            this.coldsML3DataTableASSEMBLY_STARTE_TIME = new System.Data.DataColumn();
            this.coldsML3DataTableASSEMBLY_END_TIME = new System.Data.DataColumn();
            this.coldsML3DataTableNASAL_EROSION = new System.Data.DataColumn();
            this.coldsML3DataTableEXIT_SHAPE = new System.Data.DataColumn();
            this.coldsML3DataTableSUNDRY = new System.Data.DataColumn();
            this.coldsML3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsML3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsML3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableNOTE = new System.Data.DataColumn();
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
            this.cmbLanceID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEHEADTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOZZLEFACTURYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOZZLETHROATDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOZZLEANGLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wELDOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUPPRESSOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSEMBLYENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASALEROSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvP = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEHEADTYPEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKDATEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKEIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASALEROSIONDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXITSHAPEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCommonYesNo = new AppSvrHMI.L3DataSet();
            this.schemadsCommonYesNo = new System.Data.DataTable();
            this.coldsCommonYesNoL3DataTableCode = new System.Data.DataColumn();
            this.coldsCommonYesNoL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCommonYesNoL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.sUNDRYDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsP = new System.Windows.Forms.BindingSource(this.components);
            this.dsP = new AppSvrHMI.L3DataSet();
            this.cmdP = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpP = new AppSvrHMI.L3CommandParameter();
            this.schemadsP = new System.Data.DataTable();
            this.coldsPL3DataTableGUID = new System.Data.DataColumn();
            this.coldsPL3DataTableNAME = new System.Data.DataColumn();
            this.coldsPL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsPL3DataTableLANCEID = new System.Data.DataColumn();
            this.coldsPL3DataTableCHECK_DATE = new System.Data.DataColumn();
            this.coldsPL3DataTableMAKEID = new System.Data.DataColumn();
            this.coldsPL3DataTableTEST_WATER_PRESSURE = new System.Data.DataColumn();
            this.coldsPL3DataTableNASAL_EROSION = new System.Data.DataColumn();
            this.coldsPL3DataTableEXIT_SHAPE = new System.Data.DataColumn();
            this.coldsPL3DataTableSUNDRY = new System.Data.DataColumn();
            this.coldsPL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsPL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsPL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsPL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsPL3DataTableLANCE_HEAD_TYPE = new System.Data.DataColumn();
            this.bdN2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddP = new System.Windows.Forms.ToolStripButton();
            this.btnDelP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmP = new System.Windows.Forms.ToolStripButton();
            this.btnCancelP = new System.Windows.Forms.ToolStripButton();
            this.dsLanceID = new AppSvrHMI.L3DataSet();
            this.schemadsLanceID = new System.Data.DataTable();
            this.coldsLanceIDL3DataTableLanceID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommonYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCommonYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN2)).BeginInit();
            this.bdN2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsM
            // 
            this.bsM.DataMember = "L3DataTable";
            this.bsM.DataSource = this.dsM;
            this.bsM.CurrentChanged += new System.EventHandler(this.bsM_CurrentChanged);
            // 
            // dsM
            // 
            this.dsM.AutoLoad = true;
            this.dsM.AutoSubscribe = true;
            this.dsM.DataSetName = "L3DataSet";
            this.dsM.DeleteMethod = "DeleteLanceMakeInfo";
            this.dsM.InsertMethod = "InsertLanceMakeInfo";
            this.dsM.L3DataAdapter = this.Adapter;
            this.dsM.LoadEvent = "Click";
            this.dsM.LoadTrigger = null;
            this.dsM.RefreshValve = 1000;
            this.dsM.SourceCommand = this.cmdM;
            this.dsM.SourceCondition = null;
            this.dsM.SourceMethod = "GetLanceMakeInfo";
            this.dsM.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsM.SourceURI = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.dsM.SubscribeTarget = null;
            this.dsM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsM});
            this.dsM.UpdateEvent = "Click";
            this.dsM.UpdateMethod = "UpdateLanceMakeInfo";
            this.dsM.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            this.coldsML3DataTableLANCEID,
            this.coldsML3DataTableCHECK_DATE,
            this.coldsML3DataTableLANCE_HEAD_TYPE,
            this.coldsML3DataTableMAKEID,
            this.coldsML3DataTableNOZZLE_FACTURY,
            this.coldsML3DataTableNOZZLE_THROAT_DIA,
            this.coldsML3DataTableNOZZLE_ANGLE,
            this.coldsML3DataTableWELD_OPERATOR,
            this.coldsML3DataTableSUPPRESS_OPERATOR,
            this.coldsML3DataTableTEST_WATER_PRESSURE,
            this.coldsML3DataTableASSEMBLY_STARTE_TIME,
            this.coldsML3DataTableASSEMBLY_END_TIME,
            this.coldsML3DataTableNASAL_EROSION,
            this.coldsML3DataTableEXIT_SHAPE,
            this.coldsML3DataTableSUNDRY,
            this.coldsML3DataTableTEAMID,
            this.coldsML3DataTableSHIFTID,
            this.coldsML3DataTableOPERATOR,
            this.coldsML3DataTableNOTE});
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
            // coldsML3DataTableLANCEID
            // 
            this.coldsML3DataTableLANCEID.Caption = "LANCEID";
            this.coldsML3DataTableLANCEID.ColumnName = "LANCEID";
            this.coldsML3DataTableLANCEID.DefaultValue = "";
            this.coldsML3DataTableLANCEID.Namespace = "";
            // 
            // coldsML3DataTableCHECK_DATE
            // 
            this.coldsML3DataTableCHECK_DATE.Caption = "CHECK_DATE";
            this.coldsML3DataTableCHECK_DATE.ColumnName = "CHECK_DATE";
            this.coldsML3DataTableCHECK_DATE.DataType = typeof(System.DateTime);
            this.coldsML3DataTableCHECK_DATE.Namespace = "";
            // 
            // coldsML3DataTableLANCE_HEAD_TYPE
            // 
            this.coldsML3DataTableLANCE_HEAD_TYPE.Caption = "LANCE_HEAD_TYPE";
            this.coldsML3DataTableLANCE_HEAD_TYPE.ColumnName = "LANCE_HEAD_TYPE";
            this.coldsML3DataTableLANCE_HEAD_TYPE.DefaultValue = "";
            this.coldsML3DataTableLANCE_HEAD_TYPE.Namespace = "";
            // 
            // coldsML3DataTableMAKEID
            // 
            this.coldsML3DataTableMAKEID.Caption = "MAKEID";
            this.coldsML3DataTableMAKEID.ColumnName = "MAKEID";
            this.coldsML3DataTableMAKEID.DefaultValue = "";
            this.coldsML3DataTableMAKEID.Namespace = "";
            // 
            // coldsML3DataTableNOZZLE_FACTURY
            // 
            this.coldsML3DataTableNOZZLE_FACTURY.Caption = "NOZZLE_FACTURY";
            this.coldsML3DataTableNOZZLE_FACTURY.ColumnName = "NOZZLE_FACTURY";
            this.coldsML3DataTableNOZZLE_FACTURY.DefaultValue = "";
            this.coldsML3DataTableNOZZLE_FACTURY.Namespace = "";
            // 
            // coldsML3DataTableNOZZLE_THROAT_DIA
            // 
            this.coldsML3DataTableNOZZLE_THROAT_DIA.Caption = "NOZZLE_THROAT_DIA";
            this.coldsML3DataTableNOZZLE_THROAT_DIA.ColumnName = "NOZZLE_THROAT_DIA";
            this.coldsML3DataTableNOZZLE_THROAT_DIA.DataType = typeof(double);
            this.coldsML3DataTableNOZZLE_THROAT_DIA.DefaultValue = 0;
            this.coldsML3DataTableNOZZLE_THROAT_DIA.Namespace = "";
            // 
            // coldsML3DataTableNOZZLE_ANGLE
            // 
            this.coldsML3DataTableNOZZLE_ANGLE.Caption = "NOZZLE_ANGLE";
            this.coldsML3DataTableNOZZLE_ANGLE.ColumnName = "NOZZLE_ANGLE";
            this.coldsML3DataTableNOZZLE_ANGLE.DataType = typeof(double);
            this.coldsML3DataTableNOZZLE_ANGLE.DefaultValue = 0;
            this.coldsML3DataTableNOZZLE_ANGLE.Namespace = "";
            // 
            // coldsML3DataTableWELD_OPERATOR
            // 
            this.coldsML3DataTableWELD_OPERATOR.Caption = "WELD_OPERATOR";
            this.coldsML3DataTableWELD_OPERATOR.ColumnName = "WELD_OPERATOR";
            this.coldsML3DataTableWELD_OPERATOR.DefaultValue = "";
            this.coldsML3DataTableWELD_OPERATOR.Namespace = "";
            // 
            // coldsML3DataTableSUPPRESS_OPERATOR
            // 
            this.coldsML3DataTableSUPPRESS_OPERATOR.Caption = "SUPPRESS_OPERATOR";
            this.coldsML3DataTableSUPPRESS_OPERATOR.ColumnName = "SUPPRESS_OPERATOR";
            this.coldsML3DataTableSUPPRESS_OPERATOR.DefaultValue = "";
            this.coldsML3DataTableSUPPRESS_OPERATOR.Namespace = "";
            // 
            // coldsML3DataTableTEST_WATER_PRESSURE
            // 
            this.coldsML3DataTableTEST_WATER_PRESSURE.Caption = "TEST_WATER_PRESSURE";
            this.coldsML3DataTableTEST_WATER_PRESSURE.ColumnName = "TEST_WATER_PRESSURE";
            this.coldsML3DataTableTEST_WATER_PRESSURE.DataType = typeof(double);
            this.coldsML3DataTableTEST_WATER_PRESSURE.DefaultValue = 0;
            this.coldsML3DataTableTEST_WATER_PRESSURE.Namespace = "";
            // 
            // coldsML3DataTableASSEMBLY_STARTE_TIME
            // 
            this.coldsML3DataTableASSEMBLY_STARTE_TIME.Caption = "ASSEMBLY_STARTE_TIME";
            this.coldsML3DataTableASSEMBLY_STARTE_TIME.ColumnName = "ASSEMBLY_STARTE_TIME";
            this.coldsML3DataTableASSEMBLY_STARTE_TIME.DataType = typeof(System.DateTime);
            this.coldsML3DataTableASSEMBLY_STARTE_TIME.Namespace = "";
            // 
            // coldsML3DataTableASSEMBLY_END_TIME
            // 
            this.coldsML3DataTableASSEMBLY_END_TIME.Caption = "ASSEMBLY_END_TIME";
            this.coldsML3DataTableASSEMBLY_END_TIME.ColumnName = "ASSEMBLY_END_TIME";
            this.coldsML3DataTableASSEMBLY_END_TIME.DataType = typeof(System.DateTime);
            this.coldsML3DataTableASSEMBLY_END_TIME.Namespace = "";
            // 
            // coldsML3DataTableNASAL_EROSION
            // 
            this.coldsML3DataTableNASAL_EROSION.Caption = "NASAL_EROSION";
            this.coldsML3DataTableNASAL_EROSION.ColumnName = "NASAL_EROSION";
            this.coldsML3DataTableNASAL_EROSION.DataType = typeof(double);
            this.coldsML3DataTableNASAL_EROSION.DefaultValue = 0;
            this.coldsML3DataTableNASAL_EROSION.Namespace = "";
            // 
            // coldsML3DataTableEXIT_SHAPE
            // 
            this.coldsML3DataTableEXIT_SHAPE.Caption = "EXIT_SHAPE";
            this.coldsML3DataTableEXIT_SHAPE.ColumnName = "EXIT_SHAPE";
            this.coldsML3DataTableEXIT_SHAPE.DataType = typeof(int);
            this.coldsML3DataTableEXIT_SHAPE.DefaultValue = 0;
            this.coldsML3DataTableEXIT_SHAPE.Namespace = "";
            // 
            // coldsML3DataTableSUNDRY
            // 
            this.coldsML3DataTableSUNDRY.Caption = "SUNDRY";
            this.coldsML3DataTableSUNDRY.ColumnName = "SUNDRY";
            this.coldsML3DataTableSUNDRY.DataType = typeof(int);
            this.coldsML3DataTableSUNDRY.DefaultValue = 0;
            this.coldsML3DataTableSUNDRY.Namespace = "";
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
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
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
            this.cmbLanceID,
            this.toolStripLabel3,
            this.toolStripLabel5,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel6});
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
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
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
            // cmbLanceID
            // 
            this.cmbLanceID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbLanceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLanceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLanceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanceID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLanceID.Name = "cmbLanceID";
            this.cmbLanceID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "氧枪编号:";
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
            this.dtEnd.Size = new System.Drawing.Size(100, 22);
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
            this.dtStart.Size = new System.Drawing.Size(100, 22);
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
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Controls.Add(this.tabControl1);
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
            this.lANCEIDDataGridViewTextBoxColumn,
            this.cHECKDATEDataGridViewTextBoxColumn,
            this.lANCEHEADTYPEDataGridViewTextBoxColumn,
            this.mAKEIDDataGridViewTextBoxColumn,
            this.nOZZLEFACTURYDataGridViewTextBoxColumn,
            this.nOZZLETHROATDIADataGridViewTextBoxColumn,
            this.nOZZLEANGLEDataGridViewTextBoxColumn,
            this.wELDOPERATORDataGridViewTextBoxColumn,
            this.sUPPRESSOPERATORDataGridViewTextBoxColumn,
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn,
            this.aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn,
            this.aSSEMBLYENDTIMEDataGridViewTextBoxColumn,
            this.nASALEROSIONDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsM;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.Margin = new System.Windows.Forms.Padding(0);
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(1000, 378);
            this.dvM.TabIndex = 33;
            this.dvM.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvM_DataBindingComplete);
            this.dvM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // lANCEIDDataGridViewTextBoxColumn
            // 
            this.lANCEIDDataGridViewTextBoxColumn.DataPropertyName = "LANCEID";
            this.lANCEIDDataGridViewTextBoxColumn.Frozen = true;
            this.lANCEIDDataGridViewTextBoxColumn.HeaderText = "枪号";
            this.lANCEIDDataGridViewTextBoxColumn.Name = "lANCEIDDataGridViewTextBoxColumn";
            this.lANCEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANCEIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // cHECKDATEDataGridViewTextBoxColumn
            // 
            this.cHECKDATEDataGridViewTextBoxColumn.DataPropertyName = "CHECK_DATE";
            this.cHECKDATEDataGridViewTextBoxColumn.Frozen = true;
            this.cHECKDATEDataGridViewTextBoxColumn.HeaderText = "检查日期";
            this.cHECKDATEDataGridViewTextBoxColumn.Name = "cHECKDATEDataGridViewTextBoxColumn";
            this.cHECKDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHECKDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // lANCEHEADTYPEDataGridViewTextBoxColumn
            // 
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.DataPropertyName = "LANCE_HEAD_TYPE";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Frozen = true;
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.HeaderText = "枪头型号";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Name = "lANCEHEADTYPEDataGridViewTextBoxColumn";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Width = 78;
            // 
            // mAKEIDDataGridViewTextBoxColumn
            // 
            this.mAKEIDDataGridViewTextBoxColumn.DataPropertyName = "MAKEID";
            this.mAKEIDDataGridViewTextBoxColumn.Frozen = true;
            this.mAKEIDDataGridViewTextBoxColumn.HeaderText = "氧枪制作编号";
            this.mAKEIDDataGridViewTextBoxColumn.Name = "mAKEIDDataGridViewTextBoxColumn";
            this.mAKEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAKEIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // nOZZLEFACTURYDataGridViewTextBoxColumn
            // 
            this.nOZZLEFACTURYDataGridViewTextBoxColumn.DataPropertyName = "NOZZLE_FACTURY";
            this.nOZZLEFACTURYDataGridViewTextBoxColumn.HeaderText = "喷头厂家";
            this.nOZZLEFACTURYDataGridViewTextBoxColumn.Name = "nOZZLEFACTURYDataGridViewTextBoxColumn";
            this.nOZZLEFACTURYDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOZZLEFACTURYDataGridViewTextBoxColumn.Width = 78;
            // 
            // nOZZLETHROATDIADataGridViewTextBoxColumn
            // 
            this.nOZZLETHROATDIADataGridViewTextBoxColumn.DataPropertyName = "NOZZLE_THROAT_DIA";
            this.nOZZLETHROATDIADataGridViewTextBoxColumn.HeaderText = "喷头喉口直径[mm]";
            this.nOZZLETHROATDIADataGridViewTextBoxColumn.Name = "nOZZLETHROATDIADataGridViewTextBoxColumn";
            this.nOZZLETHROATDIADataGridViewTextBoxColumn.ReadOnly = true;
            this.nOZZLETHROATDIADataGridViewTextBoxColumn.Width = 126;
            // 
            // nOZZLEANGLEDataGridViewTextBoxColumn
            // 
            this.nOZZLEANGLEDataGridViewTextBoxColumn.DataPropertyName = "NOZZLE_ANGLE";
            this.nOZZLEANGLEDataGridViewTextBoxColumn.HeaderText = "喷头夹角[°]";
            this.nOZZLEANGLEDataGridViewTextBoxColumn.Name = "nOZZLEANGLEDataGridViewTextBoxColumn";
            this.nOZZLEANGLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOZZLEANGLEDataGridViewTextBoxColumn.Width = 102;
            // 
            // wELDOPERATORDataGridViewTextBoxColumn
            // 
            this.wELDOPERATORDataGridViewTextBoxColumn.DataPropertyName = "WELD_OPERATOR";
            this.wELDOPERATORDataGridViewTextBoxColumn.HeaderText = "装配焊接人";
            this.wELDOPERATORDataGridViewTextBoxColumn.Name = "wELDOPERATORDataGridViewTextBoxColumn";
            this.wELDOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.wELDOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // sUPPRESSOPERATORDataGridViewTextBoxColumn
            // 
            this.sUPPRESSOPERATORDataGridViewTextBoxColumn.DataPropertyName = "SUPPRESS_OPERATOR";
            this.sUPPRESSOPERATORDataGridViewTextBoxColumn.HeaderText = "装配打压人";
            this.sUPPRESSOPERATORDataGridViewTextBoxColumn.Name = "sUPPRESSOPERATORDataGridViewTextBoxColumn";
            this.sUPPRESSOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUPPRESSOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // tESTWATERPRESSUREDataGridViewTextBoxColumn
            // 
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.DataPropertyName = "TEST_WATER_PRESSURE";
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.HeaderText = "试水压力[MPa]";
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.Name = "tESTWATERPRESSUREDataGridViewTextBoxColumn";
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.ReadOnly = true;
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.Width = 108;
            // 
            // aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn
            // 
            this.aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn.DataPropertyName = "ASSEMBLY_STARTE_TIME";
            this.aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn.HeaderText = "制作开始时间";
            this.aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn.Name = "aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn";
            this.aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // aSSEMBLYENDTIMEDataGridViewTextBoxColumn
            // 
            this.aSSEMBLYENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "ASSEMBLY_END_TIME";
            this.aSSEMBLYENDTIMEDataGridViewTextBoxColumn.HeaderText = "制作结束时间";
            this.aSSEMBLYENDTIMEDataGridViewTextBoxColumn.Name = "aSSEMBLYENDTIMEDataGridViewTextBoxColumn";
            this.aSSEMBLYENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSSEMBLYENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // nASALEROSIONDataGridViewTextBoxColumn
            // 
            this.nASALEROSIONDataGridViewTextBoxColumn.DataPropertyName = "NASAL_EROSION";
            this.nASALEROSIONDataGridViewTextBoxColumn.HeaderText = "鼻区侵蚀[mm]";
            this.nASALEROSIONDataGridViewTextBoxColumn.Name = "nASALEROSIONDataGridViewTextBoxColumn";
            this.nASALEROSIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.nASALEROSIONDataGridViewTextBoxColumn.Width = 102;
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
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn.Width = 66;
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
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            this.nAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 378);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 254);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dvP);
            this.tabPage1.Controls.Add(this.bdN2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(992, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "再次上线枪头维护";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvP
            // 
            this.dvP.AllowUserToAddRows = false;
            this.dvP.AutoGenerateColumns = false;
            this.dvP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn1,
            this.lANCEIDDataGridViewTextBoxColumn1,
            this.lANCEHEADTYPEDataGridViewTextBoxColumn1,
            this.cHECKDATEDataGridViewTextBoxColumn1,
            this.mAKEIDDataGridViewTextBoxColumn1,
            this.nASALEROSIONDataGridViewTextBoxColumn1,
            this.eXITSHAPEDataGridViewTextBoxColumn1,
            this.sUNDRYDataGridViewTextBoxColumn1,
            this.tEAMIDDataGridViewTextBoxColumn1,
            this.sHIFTIDDataGridViewTextBoxColumn1,
            this.oPERATORDataGridViewTextBoxColumn1,
            this.nOTEDataGridViewTextBoxColumn1,
            this.gUIDDataGridViewTextBoxColumn1,
            this.nAMEDataGridViewTextBoxColumn1});
            this.dvP.DataSource = this.bsP;
            this.dvP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvP.Location = new System.Drawing.Point(0, 25);
            this.dvP.Name = "dvP";
            this.dvP.ReadOnly = true;
            this.dvP.RowTemplate.Height = 23;
            this.dvP.Size = new System.Drawing.Size(990, 202);
            this.dvP.TabIndex = 1;
            this.dvP.Sorted += new System.EventHandler(this.dvP_Sorted);
            this.dvP.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvP_CellMouseDoubleClick);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn1
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn1.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Name = "iNPUTTIMEDataGridViewTextBoxColumn1";
            this.iNPUTTIMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn1.Width = 61;
            // 
            // lANCEIDDataGridViewTextBoxColumn1
            // 
            this.lANCEIDDataGridViewTextBoxColumn1.DataPropertyName = "LANCEID";
            this.lANCEIDDataGridViewTextBoxColumn1.HeaderText = "枪号";
            this.lANCEIDDataGridViewTextBoxColumn1.Name = "lANCEIDDataGridViewTextBoxColumn1";
            this.lANCEIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lANCEIDDataGridViewTextBoxColumn1.Width = 51;
            // 
            // lANCEHEADTYPEDataGridViewTextBoxColumn1
            // 
            this.lANCEHEADTYPEDataGridViewTextBoxColumn1.DataPropertyName = "LANCE_HEAD_TYPE";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn1.HeaderText = "枪头型号";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn1.Name = "lANCEHEADTYPEDataGridViewTextBoxColumn1";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.lANCEHEADTYPEDataGridViewTextBoxColumn1.Width = 61;
            // 
            // cHECKDATEDataGridViewTextBoxColumn1
            // 
            this.cHECKDATEDataGridViewTextBoxColumn1.DataPropertyName = "CHECK_DATE";
            this.cHECKDATEDataGridViewTextBoxColumn1.HeaderText = "检查日期";
            this.cHECKDATEDataGridViewTextBoxColumn1.Name = "cHECKDATEDataGridViewTextBoxColumn1";
            this.cHECKDATEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cHECKDATEDataGridViewTextBoxColumn1.Width = 61;
            // 
            // mAKEIDDataGridViewTextBoxColumn1
            // 
            this.mAKEIDDataGridViewTextBoxColumn1.DataPropertyName = "MAKEID";
            this.mAKEIDDataGridViewTextBoxColumn1.HeaderText = "氧枪制作编号";
            this.mAKEIDDataGridViewTextBoxColumn1.Name = "mAKEIDDataGridViewTextBoxColumn1";
            this.mAKEIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.mAKEIDDataGridViewTextBoxColumn1.Width = 72;
            // 
            // nASALEROSIONDataGridViewTextBoxColumn1
            // 
            this.nASALEROSIONDataGridViewTextBoxColumn1.DataPropertyName = "NASAL_EROSION";
            this.nASALEROSIONDataGridViewTextBoxColumn1.HeaderText = "鼻区侵蚀[mm]";
            this.nASALEROSIONDataGridViewTextBoxColumn1.Name = "nASALEROSIONDataGridViewTextBoxColumn1";
            this.nASALEROSIONDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nASALEROSIONDataGridViewTextBoxColumn1.Width = 72;
            // 
            // eXITSHAPEDataGridViewTextBoxColumn1
            // 
            this.eXITSHAPEDataGridViewTextBoxColumn1.DataPropertyName = "EXIT_SHAPE";
            this.eXITSHAPEDataGridViewTextBoxColumn1.DataSource = this.dsCommonYesNo;
            this.eXITSHAPEDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.eXITSHAPEDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.eXITSHAPEDataGridViewTextBoxColumn1.HeaderText = "出口是否变形";
            this.eXITSHAPEDataGridViewTextBoxColumn1.Name = "eXITSHAPEDataGridViewTextBoxColumn1";
            this.eXITSHAPEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.eXITSHAPEDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eXITSHAPEDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eXITSHAPEDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code_Val_Long";
            this.eXITSHAPEDataGridViewTextBoxColumn1.Width = 72;
            // 
            // dsCommonYesNo
            // 
            this.dsCommonYesNo.AutoLoad = true;
            this.dsCommonYesNo.AutoSubscribe = false;
            this.dsCommonYesNo.DataSetName = "L3DataSet";
            this.dsCommonYesNo.DeleteMethod = "";
            this.dsCommonYesNo.InsertMethod = "";
            this.dsCommonYesNo.L3DataAdapter = this.Adapter;
            this.dsCommonYesNo.LoadEvent = "";
            this.dsCommonYesNo.LoadTrigger = null;
            this.dsCommonYesNo.RefreshValve = 1000;
            this.dsCommonYesNo.SourceCommand = null;
            this.dsCommonYesNo.SourceCondition = "Code_Group = \'COMMON_YESNO\'";
            this.dsCommonYesNo.SourceMethod = "";
            this.dsCommonYesNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCommonYesNo.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCommonYesNo.SubscribeTarget = "";
            this.dsCommonYesNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCommonYesNo});
            this.dsCommonYesNo.UpdateEvent = "";
            this.dsCommonYesNo.UpdateMethod = "";
            this.dsCommonYesNo.UpdateTrigger = null;
            // 
            // schemadsCommonYesNo
            // 
            this.schemadsCommonYesNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCommonYesNoL3DataTableCode,
            this.coldsCommonYesNoL3DataTableCode_Des,
            this.coldsCommonYesNoL3DataTableCode_Val_Long});
            this.schemadsCommonYesNo.TableName = "L3DataTable";
            // 
            // coldsCommonYesNoL3DataTableCode
            // 
            this.coldsCommonYesNoL3DataTableCode.Caption = "Code";
            this.coldsCommonYesNoL3DataTableCode.ColumnName = "Code";
            this.coldsCommonYesNoL3DataTableCode.Namespace = "";
            // 
            // coldsCommonYesNoL3DataTableCode_Des
            // 
            this.coldsCommonYesNoL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCommonYesNoL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCommonYesNoL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCommonYesNoL3DataTableCode_Val_Long
            // 
            this.coldsCommonYesNoL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCommonYesNoL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCommonYesNoL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsCommonYesNoL3DataTableCode_Val_Long.Namespace = "";
            // 
            // sUNDRYDataGridViewTextBoxColumn1
            // 
            this.sUNDRYDataGridViewTextBoxColumn1.DataPropertyName = "SUNDRY";
            this.sUNDRYDataGridViewTextBoxColumn1.DataSource = this.dsCommonYesNo;
            this.sUNDRYDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.sUNDRYDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sUNDRYDataGridViewTextBoxColumn1.HeaderText = "喷口内是否有杂物";
            this.sUNDRYDataGridViewTextBoxColumn1.Name = "sUNDRYDataGridViewTextBoxColumn1";
            this.sUNDRYDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sUNDRYDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sUNDRYDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sUNDRYDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code_Val_Long";
            this.sUNDRYDataGridViewTextBoxColumn1.Width = 83;
            // 
            // tEAMIDDataGridViewTextBoxColumn1
            // 
            this.tEAMIDDataGridViewTextBoxColumn1.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn1.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn1.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn1.Name = "tEAMIDDataGridViewTextBoxColumn1";
            this.tEAMIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.tEAMIDDataGridViewTextBoxColumn1.Width = 51;
            // 
            // sHIFTIDDataGridViewTextBoxColumn1
            // 
            this.sHIFTIDDataGridViewTextBoxColumn1.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn1.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn1.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn1.Name = "sHIFTIDDataGridViewTextBoxColumn1";
            this.sHIFTIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            this.sHIFTIDDataGridViewTextBoxColumn1.Width = 51;
            // 
            // oPERATORDataGridViewTextBoxColumn1
            // 
            this.oPERATORDataGridViewTextBoxColumn1.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn1.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn1.Name = "oPERATORDataGridViewTextBoxColumn1";
            this.oPERATORDataGridViewTextBoxColumn1.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn1.Width = 61;
            // 
            // nOTEDataGridViewTextBoxColumn1
            // 
            this.nOTEDataGridViewTextBoxColumn1.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn1.Name = "nOTEDataGridViewTextBoxColumn1";
            this.nOTEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn1.Width = 51;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            this.gUIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // nAMEDataGridViewTextBoxColumn1
            // 
            this.nAMEDataGridViewTextBoxColumn1.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn1.Name = "nAMEDataGridViewTextBoxColumn1";
            this.nAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn1.Visible = false;
            this.nAMEDataGridViewTextBoxColumn1.Width = 54;
            // 
            // bsP
            // 
            this.bsP.DataMember = "L3DataTable";
            this.bsP.DataSource = this.dsP;
            // 
            // dsP
            // 
            this.dsP.AutoLoad = true;
            this.dsP.AutoSubscribe = true;
            this.dsP.DataSetName = "L3DataSet";
            this.dsP.DeleteMethod = "DeleteLanceDefendInfo";
            this.dsP.InsertMethod = "InsertLanceDefendInfo";
            this.dsP.L3DataAdapter = this.Adapter;
            this.dsP.LoadEvent = "Click";
            this.dsP.LoadTrigger = null;
            this.dsP.RefreshValve = 1000;
            this.dsP.SourceCommand = this.cmdP;
            this.dsP.SourceCondition = null;
            this.dsP.SourceMethod = "GetLanceDefendInfo";
            this.dsP.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsP.SourceURI = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.dsP.SubscribeTarget = null;
            this.dsP.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsP});
            this.dsP.UpdateEvent = "Click";
            this.dsP.UpdateMethod = "UpdateLanceDefendInfo";
            this.dsP.UpdateTrigger = null;
            // 
            // cmdP
            // 
            this.cmdP.Adapter = null;
            this.cmdP.MergeReturnTarget = false;
            this.cmdP.Method = null;
            this.cmdP.Object = null;
            this.cmdP.Parameters.Add(this.l3cmdpP);
            this.cmdP.ReturnTarget = null;
            this.cmdP.ReturnTargetProperty = null;
            this.cmdP.Trigger = null;
            this.cmdP.TriggerEvent = "Click";
            // 
            // l3cmdpP
            // 
            this.l3cmdpP.AcceptAfterExecuted = false;
            this.l3cmdpP.ConstantValue = null;
            this.l3cmdpP.MergeTarget = false;
            this.l3cmdpP.SourceFilter = null;
            this.l3cmdpP.SourceObject = null;
            this.l3cmdpP.SourceProperty = null;
            this.l3cmdpP.TargetObject = null;
            this.l3cmdpP.TargetProperty = null;
            // 
            // schemadsP
            // 
            this.schemadsP.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPL3DataTableGUID,
            this.coldsPL3DataTableNAME,
            this.coldsPL3DataTableINPUT_TIME,
            this.coldsPL3DataTableLANCEID,
            this.coldsPL3DataTableCHECK_DATE,
            this.coldsPL3DataTableMAKEID,
            this.coldsPL3DataTableTEST_WATER_PRESSURE,
            this.coldsPL3DataTableNASAL_EROSION,
            this.coldsPL3DataTableEXIT_SHAPE,
            this.coldsPL3DataTableSUNDRY,
            this.coldsPL3DataTableTEAMID,
            this.coldsPL3DataTableSHIFTID,
            this.coldsPL3DataTableOPERATOR,
            this.coldsPL3DataTableNOTE,
            this.coldsPL3DataTableLANCE_HEAD_TYPE});
            this.schemadsP.TableName = "L3DataTable";
            // 
            // coldsPL3DataTableGUID
            // 
            this.coldsPL3DataTableGUID.Caption = "GUID";
            this.coldsPL3DataTableGUID.ColumnName = "GUID";
            this.coldsPL3DataTableGUID.DefaultValue = "";
            this.coldsPL3DataTableGUID.Namespace = "";
            // 
            // coldsPL3DataTableNAME
            // 
            this.coldsPL3DataTableNAME.Caption = "NAME";
            this.coldsPL3DataTableNAME.ColumnName = "NAME";
            this.coldsPL3DataTableNAME.DefaultValue = "";
            this.coldsPL3DataTableNAME.Namespace = "";
            // 
            // coldsPL3DataTableINPUT_TIME
            // 
            this.coldsPL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsPL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsPL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsPL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsPL3DataTableLANCEID
            // 
            this.coldsPL3DataTableLANCEID.Caption = "LANCEID";
            this.coldsPL3DataTableLANCEID.ColumnName = "LANCEID";
            this.coldsPL3DataTableLANCEID.DefaultValue = "";
            this.coldsPL3DataTableLANCEID.Namespace = "";
            // 
            // coldsPL3DataTableCHECK_DATE
            // 
            this.coldsPL3DataTableCHECK_DATE.Caption = "CHECK_DATE";
            this.coldsPL3DataTableCHECK_DATE.ColumnName = "CHECK_DATE";
            this.coldsPL3DataTableCHECK_DATE.DataType = typeof(System.DateTime);
            this.coldsPL3DataTableCHECK_DATE.Namespace = "";
            // 
            // coldsPL3DataTableMAKEID
            // 
            this.coldsPL3DataTableMAKEID.Caption = "MAKEID";
            this.coldsPL3DataTableMAKEID.ColumnName = "MAKEID";
            this.coldsPL3DataTableMAKEID.DefaultValue = "";
            this.coldsPL3DataTableMAKEID.Namespace = "";
            // 
            // coldsPL3DataTableTEST_WATER_PRESSURE
            // 
            this.coldsPL3DataTableTEST_WATER_PRESSURE.Caption = "TEST_WATER_PRESSURE";
            this.coldsPL3DataTableTEST_WATER_PRESSURE.ColumnName = "TEST_WATER_PRESSURE";
            this.coldsPL3DataTableTEST_WATER_PRESSURE.DataType = typeof(double);
            this.coldsPL3DataTableTEST_WATER_PRESSURE.DefaultValue = 0;
            this.coldsPL3DataTableTEST_WATER_PRESSURE.Namespace = "";
            // 
            // coldsPL3DataTableNASAL_EROSION
            // 
            this.coldsPL3DataTableNASAL_EROSION.Caption = "NASAL_EROSION";
            this.coldsPL3DataTableNASAL_EROSION.ColumnName = "NASAL_EROSION";
            this.coldsPL3DataTableNASAL_EROSION.DataType = typeof(double);
            this.coldsPL3DataTableNASAL_EROSION.DefaultValue = 0;
            this.coldsPL3DataTableNASAL_EROSION.Namespace = "";
            // 
            // coldsPL3DataTableEXIT_SHAPE
            // 
            this.coldsPL3DataTableEXIT_SHAPE.Caption = "EXIT_SHAPE";
            this.coldsPL3DataTableEXIT_SHAPE.ColumnName = "EXIT_SHAPE";
            this.coldsPL3DataTableEXIT_SHAPE.DataType = typeof(int);
            this.coldsPL3DataTableEXIT_SHAPE.DefaultValue = 0;
            this.coldsPL3DataTableEXIT_SHAPE.Namespace = "";
            // 
            // coldsPL3DataTableSUNDRY
            // 
            this.coldsPL3DataTableSUNDRY.Caption = "SUNDRY";
            this.coldsPL3DataTableSUNDRY.ColumnName = "SUNDRY";
            this.coldsPL3DataTableSUNDRY.DataType = typeof(int);
            this.coldsPL3DataTableSUNDRY.DefaultValue = 0;
            this.coldsPL3DataTableSUNDRY.Namespace = "";
            // 
            // coldsPL3DataTableTEAMID
            // 
            this.coldsPL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsPL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsPL3DataTableTEAMID.DefaultValue = "";
            this.coldsPL3DataTableTEAMID.Namespace = "";
            // 
            // coldsPL3DataTableSHIFTID
            // 
            this.coldsPL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsPL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsPL3DataTableSHIFTID.DefaultValue = "";
            this.coldsPL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsPL3DataTableOPERATOR
            // 
            this.coldsPL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsPL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsPL3DataTableOPERATOR.DefaultValue = "";
            this.coldsPL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsPL3DataTableNOTE
            // 
            this.coldsPL3DataTableNOTE.Caption = "NOTE";
            this.coldsPL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsPL3DataTableNOTE.DefaultValue = "";
            this.coldsPL3DataTableNOTE.Namespace = "";
            // 
            // coldsPL3DataTableLANCE_HEAD_TYPE
            // 
            this.coldsPL3DataTableLANCE_HEAD_TYPE.Caption = "LANCE_HEAD_TYPE";
            this.coldsPL3DataTableLANCE_HEAD_TYPE.ColumnName = "LANCE_HEAD_TYPE";
            this.coldsPL3DataTableLANCE_HEAD_TYPE.Namespace = "";
            // 
            // bdN2
            // 
            this.bdN2.AddNewItem = null;
            this.bdN2.BindingSource = this.bsP;
            this.bdN2.CountItem = this.bindingNavigatorCountItem1;
            this.bdN2.DeleteItem = null;
            this.bdN2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator3,
            this.btnAddP,
            this.btnDelP,
            this.toolStripSeparator4,
            this.btnConfirmP,
            this.btnCancelP});
            this.bdN2.Location = new System.Drawing.Point(0, 0);
            this.bdN2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bdN2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bdN2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bdN2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bdN2.Name = "bdN2";
            this.bdN2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bdN2.Size = new System.Drawing.Size(990, 25);
            this.bdN2.TabIndex = 0;
            this.bdN2.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "/ {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "位置";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddP
            // 
            this.btnAddP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddP.Image = ((System.Drawing.Image)(resources.GetObject("btnAddP.Image")));
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.RightToLeftAutoMirrorImage = true;
            this.btnAddP.Size = new System.Drawing.Size(23, 22);
            this.btnAddP.Text = "新添";
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // btnDelP
            // 
            this.btnDelP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelP.Image = ((System.Drawing.Image)(resources.GetObject("btnDelP.Image")));
            this.btnDelP.Name = "btnDelP";
            this.btnDelP.RightToLeftAutoMirrorImage = true;
            this.btnDelP.Size = new System.Drawing.Size(23, 22);
            this.btnDelP.Text = "删除";
            this.btnDelP.Click += new System.EventHandler(this.btnDelP_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfirmP
            // 
            this.btnConfirmP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfirmP.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmP.Image")));
            this.btnConfirmP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmP.Name = "btnConfirmP";
            this.btnConfirmP.Size = new System.Drawing.Size(23, 22);
            this.btnConfirmP.Text = "保存";
            this.btnConfirmP.Click += new System.EventHandler(this.btnConfirmP_Click);
            // 
            // btnCancelP
            // 
            this.btnCancelP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelP.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelP.Image")));
            this.btnCancelP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelP.Name = "btnCancelP";
            this.btnCancelP.Size = new System.Drawing.Size(23, 22);
            this.btnCancelP.Text = "取消";
            this.btnCancelP.Click += new System.EventHandler(this.btnCancelP_Click);
            // 
            // dsLanceID
            // 
            this.dsLanceID.AutoLoad = true;
            this.dsLanceID.AutoSubscribe = true;
            this.dsLanceID.DataSetName = "L3DataSet";
            this.dsLanceID.DeleteMethod = null;
            this.dsLanceID.InsertMethod = null;
            this.dsLanceID.L3DataAdapter = this.Adapter;
            this.dsLanceID.LoadEvent = "Click";
            this.dsLanceID.LoadTrigger = null;
            this.dsLanceID.RefreshValve = 1000;
            this.dsLanceID.SourceCommand = null;
            this.dsLanceID.SourceCondition = null;
            this.dsLanceID.SourceMethod = "";
            this.dsLanceID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLanceID.SourceURI = "XGMESLogic\\LanceMag\\CLance_Base";
            this.dsLanceID.SubscribeTarget = null;
            this.dsLanceID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLanceID});
            this.dsLanceID.UpdateEvent = "Click";
            this.dsLanceID.UpdateMethod = null;
            this.dsLanceID.UpdateTrigger = null;
            // 
            // schemadsLanceID
            // 
            this.schemadsLanceID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceIDL3DataTableLanceID});
            this.schemadsLanceID.TableName = "L3DataTable";
            // 
            // coldsLanceIDL3DataTableLanceID
            // 
            this.coldsLanceIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.Namespace = "";
            // 
            // LanceDefendMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LanceDefendMagFrm";
            this.TabText = "氧枪维护实绩管理";
            this.Text = "氧枪维护实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanceDefendMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LanceDefendMagFrm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommonYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCommonYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN2)).EndInit();
            this.bdN2.ResumeLayout(false);
            this.bdN2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox cmbLanceID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3Command cmdM;
        private AppSvrHMI.L3CommandParameter l3cmdpM;
        private AppSvrHMI.L3DataSet dsTeamID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsLanceID;
        private System.Data.DataTable schemadsLanceID;
        private System.Data.DataColumn coldsLanceIDL3DataTableLanceID;
        private System.Windows.Forms.DataGridView dvM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvP;
        private System.Windows.Forms.BindingNavigator bdN2;
        private System.Windows.Forms.ToolStripButton btnAddP;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton btnDelP;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.BindingSource bsP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnConfirmP;
        private System.Windows.Forms.ToolStripButton btnCancelP;
        private AppSvrHMI.L3DataSet dsM;
        private System.Data.DataTable schemadsM;
        private System.Data.DataColumn coldsML3DataTableGUID;
        private System.Data.DataColumn coldsML3DataTableNAME;
        private System.Data.DataColumn coldsML3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsML3DataTableLANCEID;
        private System.Data.DataColumn coldsML3DataTableCHECK_DATE;
        private System.Data.DataColumn coldsML3DataTableLANCE_HEAD_TYPE;
        private System.Data.DataColumn coldsML3DataTableMAKEID;
        private System.Data.DataColumn coldsML3DataTableNOZZLE_FACTURY;
        private System.Data.DataColumn coldsML3DataTableNOZZLE_THROAT_DIA;
        private System.Data.DataColumn coldsML3DataTableNOZZLE_ANGLE;
        private System.Data.DataColumn coldsML3DataTableWELD_OPERATOR;
        private System.Data.DataColumn coldsML3DataTableSUPPRESS_OPERATOR;
        private System.Data.DataColumn coldsML3DataTableTEST_WATER_PRESSURE;
        private System.Data.DataColumn coldsML3DataTableASSEMBLY_STARTE_TIME;
        private System.Data.DataColumn coldsML3DataTableASSEMBLY_END_TIME;
        private System.Data.DataColumn coldsML3DataTableNASAL_EROSION;
        private System.Data.DataColumn coldsML3DataTableEXIT_SHAPE;
        private System.Data.DataColumn coldsML3DataTableSUNDRY;
        private System.Data.DataColumn coldsML3DataTableTEAMID;
        private System.Data.DataColumn coldsML3DataTableSHIFTID;
        private System.Data.DataColumn coldsML3DataTableOPERATOR;
        private System.Data.DataColumn coldsML3DataTableNOTE;
        private AppSvrHMI.L3Command cmdP;
        private AppSvrHMI.L3CommandParameter l3cmdpP;
        private AppSvrHMI.L3DataSet dsP;
        private System.Data.DataTable schemadsP;
        private System.Data.DataColumn coldsPL3DataTableGUID;
        private System.Data.DataColumn coldsPL3DataTableNAME;
        private System.Data.DataColumn coldsPL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsPL3DataTableLANCEID;
        private System.Data.DataColumn coldsPL3DataTableCHECK_DATE;
        private System.Data.DataColumn coldsPL3DataTableMAKEID;
        private System.Data.DataColumn coldsPL3DataTableTEST_WATER_PRESSURE;
        private System.Data.DataColumn coldsPL3DataTableNASAL_EROSION;
        private System.Data.DataColumn coldsPL3DataTableEXIT_SHAPE;
        private System.Data.DataColumn coldsPL3DataTableSUNDRY;
        private System.Data.DataColumn coldsPL3DataTableTEAMID;
        private System.Data.DataColumn coldsPL3DataTableSHIFTID;
        private System.Data.DataColumn coldsPL3DataTableOPERATOR;
        private System.Data.DataColumn coldsPL3DataTableNOTE;
        private System.Data.DataColumn coldsPL3DataTableLANCE_HEAD_TYPE;
        private AppSvrHMI.L3DataSet dsCommonYesNo;
        private System.Data.DataTable schemadsCommonYesNo;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode_Des;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEHEADTYPEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHECKDATEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKEIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nASALEROSIONDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn eXITSHAPEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sUNDRYDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHECKDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEHEADTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOZZLEFACTURYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOZZLETHROATDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOZZLEANGLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wELDOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUPPRESSOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTWATERPRESSUREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSEMBLYSTARTETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSEMBLYENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nASALEROSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
    }
}