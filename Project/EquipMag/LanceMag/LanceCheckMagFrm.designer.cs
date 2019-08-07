namespace EquipMag.LanceMag
{
    partial class LanceCheckMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanceCheckMagFrm));
            this.bsM = new System.Windows.Forms.BindingSource(this.components);
            this.dsM = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdM = new AppSvrHMI.L3Command(this.components);
            this.l3cmdP = new AppSvrHMI.L3CommandParameter();
            this.schemadsM = new System.Data.DataTable();
            this.coldsML3DataTableGUID = new System.Data.DataColumn();
            this.coldsML3DataTableNAME = new System.Data.DataColumn();
            this.coldsML3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsML3DataTableLANCEID = new System.Data.DataColumn();
            this.coldsML3DataTableLANCE_HEAD_TYPE = new System.Data.DataColumn();
            this.coldsML3DataTableNOZZLE_FACTURY = new System.Data.DataColumn();
            this.coldsML3DataTableNOZZLE_THROAT_DIA = new System.Data.DataColumn();
            this.coldsML3DataTableNOZZLE_ANGLE = new System.Data.DataColumn();
            this.coldsML3DataTableOFF_DATE = new System.Data.DataColumn();
            this.coldsML3DataTableNASAL_EROSION = new System.Data.DataColumn();
            this.coldsML3DataTableEXIT_SHAPE = new System.Data.DataColumn();
            this.coldsML3DataTableNOZZLE_ASSEMBLY_DATE = new System.Data.DataColumn();
            this.coldsML3DataTableLANCE_BODY_SHAP = new System.Data.DataColumn();
            this.coldsML3DataTableIN_MID_OUT_REPLACE = new System.Data.DataColumn();
            this.coldsML3DataTableWELD_CHECK = new System.Data.DataColumn();
            this.coldsML3DataTableN2_AND_BAFFLE_CHECK = new System.Data.DataColumn();
            this.coldsML3DataTableRING_CHECK = new System.Data.DataColumn();
            this.coldsML3DataTableTEST_WATER_PRESSURE = new System.Data.DataColumn();
            this.coldsML3DataTableKEEP_PRESSURE_TIME = new System.Data.DataColumn();
            this.coldsML3DataTableTEST_WATER_RESULT = new System.Data.DataColumn();
            this.coldsML3DataTableTEST_WATER_OPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableRISE_LANCE_DATE = new System.Data.DataColumn();
            this.coldsML3DataTableON_LANCE_OPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableOFF_LANCE_OPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsML3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsML3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableNOTE = new System.Data.DataColumn();
            this.coldsML3DataTableBOFID = new System.Data.DataColumn();
            this.coldsML3DataTableMakeID = new System.Data.DataColumn();
            this.coldsML3DataTableFLANGE_CHECK = new System.Data.DataColumn();
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
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEHEADTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOZZLEFACTURYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOZZLETHROATDIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOZZLEANGLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nASALEROSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCommonYesNo = new AppSvrHMI.L3DataSet();
            this.schemadsCommonYesNo = new System.Data.DataTable();
            this.coldsCommonYesNoL3DataTableCode_des = new System.Data.DataColumn();
            this.coldsCommonYesNoL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.eXITSHAPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEBODYSHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wELDCHECKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsNormal = new AppSvrHMI.L3DataSet();
            this.schemadsNormal = new System.Data.DataTable();
            this.coldsNormalL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsNormalL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rINGCHECKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FLANGE_CHECK = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kEEPPRESSURETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTWATERRESULTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsGood = new AppSvrHMI.L3DataSet();
            this.schemadsGood = new System.Data.DataTable();
            this.coldsGoodL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsGoodL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.tESTWATEROPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rISELANCEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNLANCEOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFLANCEOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsCommonYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCommonYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).BeginInit();
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
            this.dsM.DeleteMethod = "DeleteLanceCheckInfo";
            this.dsM.InsertMethod = "InsertLanceCheckInfo";
            this.dsM.L3DataAdapter = this.Adapter;
            this.dsM.LoadEvent = "Click";
            this.dsM.LoadTrigger = null;
            this.dsM.RefreshValve = 1000;
            this.dsM.SourceCommand = this.cmdM;
            this.dsM.SourceCondition = null;
            this.dsM.SourceMethod = "GetLanceCheckInfo";
            this.dsM.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsM.SourceURI = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.dsM.SubscribeTarget = null;
            this.dsM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsM});
            this.dsM.UpdateEvent = "Click";
            this.dsM.UpdateMethod = "UpdateLanceCheckInfo";
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
            this.cmdM.Parameters.Add(this.l3cmdP);
            this.cmdM.ReturnTarget = null;
            this.cmdM.ReturnTargetProperty = null;
            this.cmdM.Trigger = null;
            this.cmdM.TriggerEvent = "Click";
            // 
            // l3cmdP
            // 
            this.l3cmdP.AcceptAfterExecuted = false;
            this.l3cmdP.ConstantValue = null;
            this.l3cmdP.MergeTarget = false;
            this.l3cmdP.SourceFilter = null;
            this.l3cmdP.SourceObject = null;
            this.l3cmdP.SourceProperty = null;
            this.l3cmdP.TargetObject = null;
            this.l3cmdP.TargetProperty = null;
            // 
            // schemadsM
            // 
            this.schemadsM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsML3DataTableGUID,
            this.coldsML3DataTableNAME,
            this.coldsML3DataTableINPUT_TIME,
            this.coldsML3DataTableLANCEID,
            this.coldsML3DataTableLANCE_HEAD_TYPE,
            this.coldsML3DataTableNOZZLE_FACTURY,
            this.coldsML3DataTableNOZZLE_THROAT_DIA,
            this.coldsML3DataTableNOZZLE_ANGLE,
            this.coldsML3DataTableOFF_DATE,
            this.coldsML3DataTableNASAL_EROSION,
            this.coldsML3DataTableEXIT_SHAPE,
            this.coldsML3DataTableNOZZLE_ASSEMBLY_DATE,
            this.coldsML3DataTableLANCE_BODY_SHAP,
            this.coldsML3DataTableIN_MID_OUT_REPLACE,
            this.coldsML3DataTableWELD_CHECK,
            this.coldsML3DataTableN2_AND_BAFFLE_CHECK,
            this.coldsML3DataTableRING_CHECK,
            this.coldsML3DataTableTEST_WATER_PRESSURE,
            this.coldsML3DataTableKEEP_PRESSURE_TIME,
            this.coldsML3DataTableTEST_WATER_RESULT,
            this.coldsML3DataTableTEST_WATER_OPERATOR,
            this.coldsML3DataTableRISE_LANCE_DATE,
            this.coldsML3DataTableON_LANCE_OPERATOR,
            this.coldsML3DataTableOFF_LANCE_OPERATOR,
            this.coldsML3DataTableTEAMID,
            this.coldsML3DataTableSHIFTID,
            this.coldsML3DataTableOPERATOR,
            this.coldsML3DataTableNOTE,
            this.coldsML3DataTableBOFID,
            this.coldsML3DataTableMakeID,
            this.coldsML3DataTableFLANGE_CHECK});
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
            // coldsML3DataTableLANCE_HEAD_TYPE
            // 
            this.coldsML3DataTableLANCE_HEAD_TYPE.Caption = "LANCE_HEAD_TYPE";
            this.coldsML3DataTableLANCE_HEAD_TYPE.ColumnName = "LANCE_HEAD_TYPE";
            this.coldsML3DataTableLANCE_HEAD_TYPE.DefaultValue = "";
            this.coldsML3DataTableLANCE_HEAD_TYPE.Namespace = "";
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
            // coldsML3DataTableOFF_DATE
            // 
            this.coldsML3DataTableOFF_DATE.Caption = "OFF_DATE";
            this.coldsML3DataTableOFF_DATE.ColumnName = "OFF_DATE";
            this.coldsML3DataTableOFF_DATE.DataType = typeof(System.DateTime);
            this.coldsML3DataTableOFF_DATE.Namespace = "";
            // 
            // coldsML3DataTableNASAL_EROSION
            // 
            this.coldsML3DataTableNASAL_EROSION.Caption = "NASAL_EROSION";
            this.coldsML3DataTableNASAL_EROSION.ColumnName = "NASAL_EROSION";
            this.coldsML3DataTableNASAL_EROSION.DataType = typeof(int);
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
            // coldsML3DataTableNOZZLE_ASSEMBLY_DATE
            // 
            this.coldsML3DataTableNOZZLE_ASSEMBLY_DATE.Caption = "NOZZLE_ASSEMBLY_DATE";
            this.coldsML3DataTableNOZZLE_ASSEMBLY_DATE.ColumnName = "NOZZLE_ASSEMBLY_DATE";
            this.coldsML3DataTableNOZZLE_ASSEMBLY_DATE.DataType = typeof(System.DateTime);
            this.coldsML3DataTableNOZZLE_ASSEMBLY_DATE.Namespace = "";
            // 
            // coldsML3DataTableLANCE_BODY_SHAP
            // 
            this.coldsML3DataTableLANCE_BODY_SHAP.Caption = "LANCE_BODY_SHAP";
            this.coldsML3DataTableLANCE_BODY_SHAP.ColumnName = "LANCE_BODY_SHAP";
            this.coldsML3DataTableLANCE_BODY_SHAP.DataType = typeof(int);
            this.coldsML3DataTableLANCE_BODY_SHAP.DefaultValue = 0;
            this.coldsML3DataTableLANCE_BODY_SHAP.Namespace = "";
            // 
            // coldsML3DataTableIN_MID_OUT_REPLACE
            // 
            this.coldsML3DataTableIN_MID_OUT_REPLACE.Caption = "IN_MID_OUT_REPLACE";
            this.coldsML3DataTableIN_MID_OUT_REPLACE.ColumnName = "IN_MID_OUT_REPLACE";
            this.coldsML3DataTableIN_MID_OUT_REPLACE.DataType = typeof(int);
            this.coldsML3DataTableIN_MID_OUT_REPLACE.DefaultValue = 0;
            this.coldsML3DataTableIN_MID_OUT_REPLACE.Namespace = "";
            // 
            // coldsML3DataTableWELD_CHECK
            // 
            this.coldsML3DataTableWELD_CHECK.Caption = "WELD_CHECK";
            this.coldsML3DataTableWELD_CHECK.ColumnName = "WELD_CHECK";
            this.coldsML3DataTableWELD_CHECK.DataType = typeof(int);
            this.coldsML3DataTableWELD_CHECK.DefaultValue = 0;
            this.coldsML3DataTableWELD_CHECK.Namespace = "";
            // 
            // coldsML3DataTableN2_AND_BAFFLE_CHECK
            // 
            this.coldsML3DataTableN2_AND_BAFFLE_CHECK.Caption = "N2_AND_BAFFLE_CHECK";
            this.coldsML3DataTableN2_AND_BAFFLE_CHECK.ColumnName = "N2_AND_BAFFLE_CHECK";
            this.coldsML3DataTableN2_AND_BAFFLE_CHECK.DataType = typeof(int);
            this.coldsML3DataTableN2_AND_BAFFLE_CHECK.DefaultValue = 0;
            this.coldsML3DataTableN2_AND_BAFFLE_CHECK.Namespace = "";
            // 
            // coldsML3DataTableRING_CHECK
            // 
            this.coldsML3DataTableRING_CHECK.Caption = "RING_CHECK";
            this.coldsML3DataTableRING_CHECK.ColumnName = "RING_CHECK";
            this.coldsML3DataTableRING_CHECK.DataType = typeof(int);
            this.coldsML3DataTableRING_CHECK.DefaultValue = 0;
            this.coldsML3DataTableRING_CHECK.Namespace = "";
            // 
            // coldsML3DataTableTEST_WATER_PRESSURE
            // 
            this.coldsML3DataTableTEST_WATER_PRESSURE.Caption = "TEST_WATER_PRESSURE";
            this.coldsML3DataTableTEST_WATER_PRESSURE.ColumnName = "TEST_WATER_PRESSURE";
            this.coldsML3DataTableTEST_WATER_PRESSURE.DataType = typeof(double);
            this.coldsML3DataTableTEST_WATER_PRESSURE.DefaultValue = 0;
            this.coldsML3DataTableTEST_WATER_PRESSURE.Namespace = "";
            // 
            // coldsML3DataTableKEEP_PRESSURE_TIME
            // 
            this.coldsML3DataTableKEEP_PRESSURE_TIME.Caption = "KEEP_PRESSURE_TIME";
            this.coldsML3DataTableKEEP_PRESSURE_TIME.ColumnName = "KEEP_PRESSURE_TIME";
            this.coldsML3DataTableKEEP_PRESSURE_TIME.DataType = typeof(double);
            this.coldsML3DataTableKEEP_PRESSURE_TIME.DefaultValue = 0;
            this.coldsML3DataTableKEEP_PRESSURE_TIME.Namespace = "";
            // 
            // coldsML3DataTableTEST_WATER_RESULT
            // 
            this.coldsML3DataTableTEST_WATER_RESULT.Caption = "TEST_WATER_RESULT";
            this.coldsML3DataTableTEST_WATER_RESULT.ColumnName = "TEST_WATER_RESULT";
            this.coldsML3DataTableTEST_WATER_RESULT.DataType = typeof(int);
            this.coldsML3DataTableTEST_WATER_RESULT.DefaultValue = 0;
            this.coldsML3DataTableTEST_WATER_RESULT.Namespace = "";
            // 
            // coldsML3DataTableTEST_WATER_OPERATOR
            // 
            this.coldsML3DataTableTEST_WATER_OPERATOR.Caption = "TEST_WATER_OPERATOR";
            this.coldsML3DataTableTEST_WATER_OPERATOR.ColumnName = "TEST_WATER_OPERATOR";
            this.coldsML3DataTableTEST_WATER_OPERATOR.DefaultValue = "";
            this.coldsML3DataTableTEST_WATER_OPERATOR.Namespace = "";
            // 
            // coldsML3DataTableRISE_LANCE_DATE
            // 
            this.coldsML3DataTableRISE_LANCE_DATE.Caption = "RISE_LANCE_DATE";
            this.coldsML3DataTableRISE_LANCE_DATE.ColumnName = "RISE_LANCE_DATE";
            this.coldsML3DataTableRISE_LANCE_DATE.DataType = typeof(System.DateTime);
            this.coldsML3DataTableRISE_LANCE_DATE.Namespace = "";
            // 
            // coldsML3DataTableON_LANCE_OPERATOR
            // 
            this.coldsML3DataTableON_LANCE_OPERATOR.Caption = "ON_LANCE_OPERATOR";
            this.coldsML3DataTableON_LANCE_OPERATOR.ColumnName = "ON_LANCE_OPERATOR";
            this.coldsML3DataTableON_LANCE_OPERATOR.DefaultValue = "";
            this.coldsML3DataTableON_LANCE_OPERATOR.Namespace = "";
            // 
            // coldsML3DataTableOFF_LANCE_OPERATOR
            // 
            this.coldsML3DataTableOFF_LANCE_OPERATOR.Caption = "OFF_LANCE_OPERATOR";
            this.coldsML3DataTableOFF_LANCE_OPERATOR.ColumnName = "OFF_LANCE_OPERATOR";
            this.coldsML3DataTableOFF_LANCE_OPERATOR.DefaultValue = "";
            this.coldsML3DataTableOFF_LANCE_OPERATOR.Namespace = "";
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
            // coldsML3DataTableBOFID
            // 
            this.coldsML3DataTableBOFID.Caption = "BOFID";
            this.coldsML3DataTableBOFID.ColumnName = "BOFID";
            this.coldsML3DataTableBOFID.Namespace = "";
            // 
            // coldsML3DataTableMakeID
            // 
            this.coldsML3DataTableMakeID.Caption = "MakeID";
            this.coldsML3DataTableMakeID.ColumnName = "MakeID";
            this.coldsML3DataTableMakeID.Namespace = "";
            // 
            // coldsML3DataTableFLANGE_CHECK
            // 
            this.coldsML3DataTableFLANGE_CHECK.Caption = "FLANGE_CHECK";
            this.coldsML3DataTableFLANGE_CHECK.ColumnName = "FLANGE_CHECK";
            this.coldsML3DataTableFLANGE_CHECK.DataType = typeof(int);
            this.coldsML3DataTableFLANGE_CHECK.DefaultValue = 0;
            this.coldsML3DataTableFLANGE_CHECK.Namespace = "";
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
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
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
            this.toolStripLabel3.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel3.Text = "氧枪号:";
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
            this.lANCEIDDataGridViewTextBoxColumn,
            this.lANCEHEADTYPEDataGridViewTextBoxColumn,
            this.MakeID,
            this.nOZZLEFACTURYDataGridViewTextBoxColumn,
            this.nOZZLETHROATDIADataGridViewTextBoxColumn,
            this.nOZZLEANGLEDataGridViewTextBoxColumn,
            this.oFFDATEDataGridViewTextBoxColumn,
            this.nASALEROSIONDataGridViewTextBoxColumn,
            this.eXITSHAPEDataGridViewTextBoxColumn,
            this.nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn,
            this.lANCEBODYSHAPDataGridViewTextBoxColumn,
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn,
            this.wELDCHECKDataGridViewTextBoxColumn,
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn,
            this.rINGCHECKDataGridViewTextBoxColumn,
            this.FLANGE_CHECK,
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn,
            this.kEEPPRESSURETIMEDataGridViewTextBoxColumn,
            this.tESTWATERRESULTDataGridViewTextBoxColumn,
            this.tESTWATEROPERATORDataGridViewTextBoxColumn,
            this.rISELANCEDATEDataGridViewTextBoxColumn,
            this.oNLANCEOPERATORDataGridViewTextBoxColumn,
            this.oFFLANCEOPERATORDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.bOFIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
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
            this.dvM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            this.dvM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvM_CellContentClick);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入日期";
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
            // lANCEHEADTYPEDataGridViewTextBoxColumn
            // 
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.DataPropertyName = "LANCE_HEAD_TYPE";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Frozen = true;
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.HeaderText = "枪头型号";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Name = "lANCEHEADTYPEDataGridViewTextBoxColumn";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Width = 78;
            // 
            // MakeID
            // 
            this.MakeID.DataPropertyName = "MakeID";
            this.MakeID.Frozen = true;
            this.MakeID.HeaderText = "氧枪制作编号";
            this.MakeID.Name = "MakeID";
            this.MakeID.ReadOnly = true;
            this.MakeID.Width = 102;
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
            // oFFDATEDataGridViewTextBoxColumn
            // 
            this.oFFDATEDataGridViewTextBoxColumn.DataPropertyName = "OFF_DATE";
            this.oFFDATEDataGridViewTextBoxColumn.HeaderText = "下线日期";
            this.oFFDATEDataGridViewTextBoxColumn.Name = "oFFDATEDataGridViewTextBoxColumn";
            this.oFFDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // nASALEROSIONDataGridViewTextBoxColumn
            // 
            this.nASALEROSIONDataGridViewTextBoxColumn.DataPropertyName = "NASAL_EROSION";
            this.nASALEROSIONDataGridViewTextBoxColumn.DataSource = this.dsCommonYesNo;
            this.nASALEROSIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_des";
            this.nASALEROSIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.nASALEROSIONDataGridViewTextBoxColumn.HeaderText = "鼻区是否腐蚀";
            this.nASALEROSIONDataGridViewTextBoxColumn.Name = "nASALEROSIONDataGridViewTextBoxColumn";
            this.nASALEROSIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.nASALEROSIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nASALEROSIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nASALEROSIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.nASALEROSIONDataGridViewTextBoxColumn.Width = 102;
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
            this.coldsCommonYesNoL3DataTableCode_des,
            this.coldsCommonYesNoL3DataTableCode_Val_Long});
            this.schemadsCommonYesNo.TableName = "L3DataTable";
            // 
            // coldsCommonYesNoL3DataTableCode_des
            // 
            this.coldsCommonYesNoL3DataTableCode_des.Caption = "Code_des";
            this.coldsCommonYesNoL3DataTableCode_des.ColumnName = "Code_des";
            this.coldsCommonYesNoL3DataTableCode_des.Namespace = "";
            // 
            // coldsCommonYesNoL3DataTableCode_Val_Long
            // 
            this.coldsCommonYesNoL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCommonYesNoL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCommonYesNoL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsCommonYesNoL3DataTableCode_Val_Long.DefaultValue = 0;
            this.coldsCommonYesNoL3DataTableCode_Val_Long.Namespace = "";
            // 
            // eXITSHAPEDataGridViewTextBoxColumn
            // 
            this.eXITSHAPEDataGridViewTextBoxColumn.DataPropertyName = "EXIT_SHAPE";
            this.eXITSHAPEDataGridViewTextBoxColumn.DataSource = this.dsCommonYesNo;
            this.eXITSHAPEDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_des";
            this.eXITSHAPEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.eXITSHAPEDataGridViewTextBoxColumn.HeaderText = "出口是否变形";
            this.eXITSHAPEDataGridViewTextBoxColumn.Name = "eXITSHAPEDataGridViewTextBoxColumn";
            this.eXITSHAPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eXITSHAPEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eXITSHAPEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eXITSHAPEDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.eXITSHAPEDataGridViewTextBoxColumn.Width = 102;
            // 
            // nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn
            // 
            this.nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn.DataPropertyName = "NOZZLE_ASSEMBLY_DATE";
            this.nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn.HeaderText = "喷头装配日期";
            this.nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn.Name = "nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn";
            this.nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn.Width = 102;
            // 
            // lANCEBODYSHAPDataGridViewTextBoxColumn
            // 
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.DataPropertyName = "LANCE_BODY_SHAP";
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.DataSource = this.dsCommonYesNo;
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_des";
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.HeaderText = "枪身是否变形";
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.Name = "lANCEBODYSHAPDataGridViewTextBoxColumn";
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.lANCEBODYSHAPDataGridViewTextBoxColumn.Width = 102;
            // 
            // iNMIDOUTREPLACEDataGridViewTextBoxColumn
            // 
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.DataPropertyName = "IN_MID_OUT_REPLACE";
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.DataSource = this.dsCommonYesNo;
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_des";
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.HeaderText = "内、中、外管是否更换";
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.Name = "iNMIDOUTREPLACEDataGridViewTextBoxColumn";
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.iNMIDOUTREPLACEDataGridViewTextBoxColumn.Width = 150;
            // 
            // wELDCHECKDataGridViewTextBoxColumn
            // 
            this.wELDCHECKDataGridViewTextBoxColumn.DataPropertyName = "WELD_CHECK";
            this.wELDCHECKDataGridViewTextBoxColumn.DataSource = this.dsNormal;
            this.wELDCHECKDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.wELDCHECKDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wELDCHECKDataGridViewTextBoxColumn.HeaderText = "焊缝检查";
            this.wELDCHECKDataGridViewTextBoxColumn.Name = "wELDCHECKDataGridViewTextBoxColumn";
            this.wELDCHECKDataGridViewTextBoxColumn.ReadOnly = true;
            this.wELDCHECKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wELDCHECKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wELDCHECKDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.wELDCHECKDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsNormal
            // 
            this.dsNormal.AutoLoad = true;
            this.dsNormal.AutoSubscribe = false;
            this.dsNormal.DataSetName = "L3DataSet";
            this.dsNormal.DeleteMethod = "";
            this.dsNormal.InsertMethod = "";
            this.dsNormal.L3DataAdapter = this.Adapter;
            this.dsNormal.LoadEvent = "";
            this.dsNormal.LoadTrigger = null;
            this.dsNormal.RefreshValve = 1000;
            this.dsNormal.SourceCommand = null;
            this.dsNormal.SourceCondition = "Code_Group = \'CommonNormal\'";
            this.dsNormal.SourceMethod = "";
            this.dsNormal.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNormal.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsNormal.SubscribeTarget = "";
            this.dsNormal.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsNormal});
            this.dsNormal.UpdateEvent = "";
            this.dsNormal.UpdateMethod = "";
            this.dsNormal.UpdateTrigger = null;
            // 
            // schemadsNormal
            // 
            this.schemadsNormal.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNormalL3DataTableCode_Des,
            this.coldsNormalL3DataTableCode_Val_Long});
            this.schemadsNormal.TableName = "L3DataTable";
            // 
            // coldsNormalL3DataTableCode_Des
            // 
            this.coldsNormalL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsNormalL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsNormalL3DataTableCode_Des.Namespace = "";
            // 
            // coldsNormalL3DataTableCode_Val_Long
            // 
            this.coldsNormalL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsNormalL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsNormalL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsNormalL3DataTableCode_Val_Long.DefaultValue = 0;
            this.coldsNormalL3DataTableCode_Val_Long.Namespace = "";
            // 
            // n2ANDBAFFLECHECKDataGridViewTextBoxColumn
            // 
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.DataPropertyName = "N2_AND_BAFFLE_CHECK";
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.DataSource = this.dsNormal;
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.HeaderText = "氮封孔及挡块检查";
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.Name = "n2ANDBAFFLECHECKDataGridViewTextBoxColumn";
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.ReadOnly = true;
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.n2ANDBAFFLECHECKDataGridViewTextBoxColumn.Width = 126;
            // 
            // rINGCHECKDataGridViewTextBoxColumn
            // 
            this.rINGCHECKDataGridViewTextBoxColumn.DataPropertyName = "RING_CHECK";
            this.rINGCHECKDataGridViewTextBoxColumn.DataSource = this.dsNormal;
            this.rINGCHECKDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.rINGCHECKDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rINGCHECKDataGridViewTextBoxColumn.HeaderText = "吊挂检查";
            this.rINGCHECKDataGridViewTextBoxColumn.Name = "rINGCHECKDataGridViewTextBoxColumn";
            this.rINGCHECKDataGridViewTextBoxColumn.ReadOnly = true;
            this.rINGCHECKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rINGCHECKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rINGCHECKDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.rINGCHECKDataGridViewTextBoxColumn.Width = 78;
            // 
            // FLANGE_CHECK
            // 
            this.FLANGE_CHECK.DataPropertyName = "FLANGE_CHECK";
            this.FLANGE_CHECK.DataSource = this.dsNormal;
            this.FLANGE_CHECK.DisplayMember = "L3DataTable.Code_Des";
            this.FLANGE_CHECK.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.FLANGE_CHECK.HeaderText = "法兰检查";
            this.FLANGE_CHECK.Name = "FLANGE_CHECK";
            this.FLANGE_CHECK.ReadOnly = true;
            this.FLANGE_CHECK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FLANGE_CHECK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FLANGE_CHECK.ValueMember = "L3DataTable.Code_Val_Long";
            this.FLANGE_CHECK.Width = 78;
            // 
            // tESTWATERPRESSUREDataGridViewTextBoxColumn
            // 
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.DataPropertyName = "TEST_WATER_PRESSURE";
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.HeaderText = "试水压力[MPa]";
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.Name = "tESTWATERPRESSUREDataGridViewTextBoxColumn";
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.ReadOnly = true;
            this.tESTWATERPRESSUREDataGridViewTextBoxColumn.Width = 108;
            // 
            // kEEPPRESSURETIMEDataGridViewTextBoxColumn
            // 
            this.kEEPPRESSURETIMEDataGridViewTextBoxColumn.DataPropertyName = "KEEP_PRESSURE_TIME";
            this.kEEPPRESSURETIMEDataGridViewTextBoxColumn.HeaderText = "保压时间";
            this.kEEPPRESSURETIMEDataGridViewTextBoxColumn.Name = "kEEPPRESSURETIMEDataGridViewTextBoxColumn";
            this.kEEPPRESSURETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.kEEPPRESSURETIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // tESTWATERRESULTDataGridViewTextBoxColumn
            // 
            this.tESTWATERRESULTDataGridViewTextBoxColumn.DataPropertyName = "TEST_WATER_RESULT";
            this.tESTWATERRESULTDataGridViewTextBoxColumn.DataSource = this.dsGood;
            this.tESTWATERRESULTDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tESTWATERRESULTDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tESTWATERRESULTDataGridViewTextBoxColumn.HeaderText = "试水作业结果";
            this.tESTWATERRESULTDataGridViewTextBoxColumn.Name = "tESTWATERRESULTDataGridViewTextBoxColumn";
            this.tESTWATERRESULTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tESTWATERRESULTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tESTWATERRESULTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tESTWATERRESULTDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.tESTWATERRESULTDataGridViewTextBoxColumn.Width = 102;
            // 
            // dsGood
            // 
            this.dsGood.AutoLoad = true;
            this.dsGood.AutoSubscribe = false;
            this.dsGood.DataSetName = "L3DataSet";
            this.dsGood.DeleteMethod = "";
            this.dsGood.InsertMethod = "";
            this.dsGood.L3DataAdapter = this.Adapter;
            this.dsGood.LoadEvent = "";
            this.dsGood.LoadTrigger = null;
            this.dsGood.RefreshValve = 1000;
            this.dsGood.SourceCommand = null;
            this.dsGood.SourceCondition = "Code_Group = \'CommonGood\'";
            this.dsGood.SourceMethod = "";
            this.dsGood.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGood.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsGood.SubscribeTarget = "";
            this.dsGood.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGood});
            this.dsGood.UpdateEvent = "";
            this.dsGood.UpdateMethod = "";
            this.dsGood.UpdateTrigger = null;
            // 
            // schemadsGood
            // 
            this.schemadsGood.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGoodL3DataTableCode_Des,
            this.coldsGoodL3DataTableCode_Val_Long});
            this.schemadsGood.TableName = "L3DataTable";
            // 
            // coldsGoodL3DataTableCode_Des
            // 
            this.coldsGoodL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsGoodL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsGoodL3DataTableCode_Des.Namespace = "";
            // 
            // coldsGoodL3DataTableCode_Val_Long
            // 
            this.coldsGoodL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsGoodL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsGoodL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsGoodL3DataTableCode_Val_Long.Namespace = "";
            // 
            // tESTWATEROPERATORDataGridViewTextBoxColumn
            // 
            this.tESTWATEROPERATORDataGridViewTextBoxColumn.DataPropertyName = "TEST_WATER_OPERATOR";
            this.tESTWATEROPERATORDataGridViewTextBoxColumn.HeaderText = "试水作业人";
            this.tESTWATEROPERATORDataGridViewTextBoxColumn.Name = "tESTWATEROPERATORDataGridViewTextBoxColumn";
            this.tESTWATEROPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.tESTWATEROPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // rISELANCEDATEDataGridViewTextBoxColumn
            // 
            this.rISELANCEDATEDataGridViewTextBoxColumn.DataPropertyName = "RISE_LANCE_DATE";
            this.rISELANCEDATEDataGridViewTextBoxColumn.HeaderText = "上枪日期";
            this.rISELANCEDATEDataGridViewTextBoxColumn.Name = "rISELANCEDATEDataGridViewTextBoxColumn";
            this.rISELANCEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rISELANCEDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // oNLANCEOPERATORDataGridViewTextBoxColumn
            // 
            this.oNLANCEOPERATORDataGridViewTextBoxColumn.DataPropertyName = "ON_LANCE_OPERATOR";
            this.oNLANCEOPERATORDataGridViewTextBoxColumn.HeaderText = "上枪作业人员";
            this.oNLANCEOPERATORDataGridViewTextBoxColumn.Name = "oNLANCEOPERATORDataGridViewTextBoxColumn";
            this.oNLANCEOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oNLANCEOPERATORDataGridViewTextBoxColumn.Width = 102;
            // 
            // oFFLANCEOPERATORDataGridViewTextBoxColumn
            // 
            this.oFFLANCEOPERATORDataGridViewTextBoxColumn.DataPropertyName = "OFF_LANCE_OPERATOR";
            this.oFFLANCEOPERATORDataGridViewTextBoxColumn.HeaderText = "下枪作业人员";
            this.oFFLANCEOPERATORDataGridViewTextBoxColumn.Name = "oFFLANCEOPERATORDataGridViewTextBoxColumn";
            this.oFFLANCEOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFLANCEOPERATORDataGridViewTextBoxColumn.Width = 102;
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
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "使用转炉";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOFIDDataGridViewTextBoxColumn.Width = 78;
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
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
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
            // LanceCheckMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LanceCheckMagFrm";
            this.TabText = "氧枪检查实绩管理";
            this.Text = "氧枪检查实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanceCheckMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LanceCheckMagFrm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsCommonYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCommonYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).EndInit();
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
        private System.Windows.Forms.ToolStripComboBox cmbLanceID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsLanceID;
        private System.Data.DataTable schemadsLanceID;
        private System.Data.DataColumn coldsLanceIDL3DataTableLanceID;
        private AppSvrHMI.L3Command cmdM;
        private AppSvrHMI.L3CommandParameter l3cmdP;
        private System.Data.DataTable schemadsM;
        private System.Data.DataColumn coldsML3DataTableGUID;
        private System.Data.DataColumn coldsML3DataTableNAME;
        private System.Data.DataColumn coldsML3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsML3DataTableLANCEID;
        private System.Data.DataColumn coldsML3DataTableLANCE_HEAD_TYPE;
        private System.Data.DataColumn coldsML3DataTableNOZZLE_FACTURY;
        private System.Data.DataColumn coldsML3DataTableNOZZLE_THROAT_DIA;
        private System.Data.DataColumn coldsML3DataTableNOZZLE_ANGLE;
        private System.Data.DataColumn coldsML3DataTableOFF_DATE;
        private System.Data.DataColumn coldsML3DataTableNASAL_EROSION;
        private System.Data.DataColumn coldsML3DataTableEXIT_SHAPE;
        private System.Data.DataColumn coldsML3DataTableNOZZLE_ASSEMBLY_DATE;
        private System.Data.DataColumn coldsML3DataTableLANCE_BODY_SHAP;
        private System.Data.DataColumn coldsML3DataTableIN_MID_OUT_REPLACE;
        private System.Data.DataColumn coldsML3DataTableWELD_CHECK;
        private System.Data.DataColumn coldsML3DataTableN2_AND_BAFFLE_CHECK;
        private System.Data.DataColumn coldsML3DataTableRING_CHECK;
        private System.Data.DataColumn coldsML3DataTableTEST_WATER_PRESSURE;
        private System.Data.DataColumn coldsML3DataTableKEEP_PRESSURE_TIME;
        private System.Data.DataColumn coldsML3DataTableTEST_WATER_RESULT;
        private System.Data.DataColumn coldsML3DataTableTEST_WATER_OPERATOR;
        private System.Data.DataColumn coldsML3DataTableRISE_LANCE_DATE;
        private System.Data.DataColumn coldsML3DataTableON_LANCE_OPERATOR;
        private System.Data.DataColumn coldsML3DataTableOFF_LANCE_OPERATOR;
        private System.Data.DataColumn coldsML3DataTableTEAMID;
        private System.Data.DataColumn coldsML3DataTableSHIFTID;
        private System.Data.DataColumn coldsML3DataTableOPERATOR;
        private System.Data.DataColumn coldsML3DataTableNOTE;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsML3DataTableBOFID;
        private System.Data.DataColumn coldsML3DataTableMakeID;
        private System.Data.DataColumn coldsML3DataTableFLANGE_CHECK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private AppSvrHMI.L3DataSet dsCommonYesNo;
        private System.Data.DataTable schemadsCommonYesNo;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode_des;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsGood;
        private System.Data.DataTable schemadsGood;
        private System.Data.DataColumn coldsGoodL3DataTableCode_Des;
        private System.Data.DataColumn coldsGoodL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsNormal;
        private System.Data.DataTable schemadsNormal;
        private System.Data.DataColumn coldsNormalL3DataTableCode_Des;
        private System.Data.DataColumn coldsNormalL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEHEADTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOZZLEFACTURYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOZZLETHROATDIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOZZLEANGLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nASALEROSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn eXITSHAPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOZZLEASSEMBLYDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lANCEBODYSHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iNMIDOUTREPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wELDCHECKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn n2ANDBAFFLECHECKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rINGCHECKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn FLANGE_CHECK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTWATERPRESSUREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kEEPPRESSURETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tESTWATERRESULTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTWATEROPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rISELANCEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNLANCEOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFLANCEOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
    }
}