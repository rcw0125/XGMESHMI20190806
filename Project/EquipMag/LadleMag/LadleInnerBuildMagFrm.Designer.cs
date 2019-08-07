namespace EquipMag.LadleMag
{
    partial class LadleInnerBuildMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadleInnerBuildMagFrm));
            this.bsInnerBuildInfos = new System.Windows.Forms.BindingSource(this.components);
            this.dsInnerBuildInfos = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdInnerBuildInfos = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsInnerBuildInfos = new System.Data.DataTable();
            this.coldsInnerBuildInfosL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableNAME = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableINNERID = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableBUILD_START_TIME = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableBUILD_END_TIME = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsInnerBuildInfosL3DataTableNOTE = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bnInnerBuildInfos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbLadleID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnDataConfirm = new System.Windows.Forms.ToolStripButton();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTOLIGCASTFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTOLIGCASTWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hARDFIADIBOAFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hARDFIADIBOAWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPINELCASTFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPINELCASTWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMGBRICKFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMGBRICKWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGFIRECALYFACTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGFIRECALYWASTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuildInfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerBuildInfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerBuildInfos)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnInnerBuildInfos)).BeginInit();
            this.bnInnerBuildInfos.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInnerBuildInfos
            // 
            this.bsInnerBuildInfos.DataMember = "L3DataTable";
            this.bsInnerBuildInfos.DataSource = this.dsInnerBuildInfos;
            // 
            // dsInnerBuildInfos
            // 
            this.dsInnerBuildInfos.AutoSubscribe = false;
            this.dsInnerBuildInfos.DataSetName = "L3DataSet";
            this.dsInnerBuildInfos.DeleteMethod = "DeleteInnerBuildInfos";
            this.dsInnerBuildInfos.InsertMethod = "InsertInnerBuildInfos";
            this.dsInnerBuildInfos.L3DataAdapter = this.Adapter;
            this.dsInnerBuildInfos.LoadEvent = "Click";
            this.dsInnerBuildInfos.LoadTrigger = null;
            this.dsInnerBuildInfos.RefreshValve = 1000;
            this.dsInnerBuildInfos.SourceCommand = this.cmdInnerBuildInfos;
            this.dsInnerBuildInfos.SourceCondition = null;
            this.dsInnerBuildInfos.SourceMethod = "GetInnerBuildInfos";
            this.dsInnerBuildInfos.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsInnerBuildInfos.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.dsInnerBuildInfos.SubscribeTarget = null;
            this.dsInnerBuildInfos.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInnerBuildInfos});
            this.dsInnerBuildInfos.UpdateEvent = "Click";
            this.dsInnerBuildInfos.UpdateMethod = "UpdateInnerBuildInfos";
            this.dsInnerBuildInfos.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdInnerBuildInfos
            // 
            this.cmdInnerBuildInfos.Adapter = null;
            this.cmdInnerBuildInfos.MergeReturnTarget = false;
            this.cmdInnerBuildInfos.Method = null;
            this.cmdInnerBuildInfos.Object = null;
            this.cmdInnerBuildInfos.Parameters.Add(this.l3CommandParameter1);
            this.cmdInnerBuildInfos.ReturnTarget = null;
            this.cmdInnerBuildInfos.ReturnTargetProperty = null;
            this.cmdInnerBuildInfos.Trigger = null;
            this.cmdInnerBuildInfos.TriggerEvent = "Click";
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
            // schemadsInnerBuildInfos
            // 
            this.schemadsInnerBuildInfos.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInnerBuildInfosL3DataTableGUID,
            this.coldsInnerBuildInfosL3DataTableNAME,
            this.coldsInnerBuildInfosL3DataTableINPUT_TIME,
            this.coldsInnerBuildInfosL3DataTableINNERID,
            this.coldsInnerBuildInfosL3DataTableLADLEID,
            this.coldsInnerBuildInfosL3DataTableBUILD_START_TIME,
            this.coldsInnerBuildInfosL3DataTableBUILD_END_TIME,
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC,
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST,
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC,
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST,
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC,
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST,
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC,
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST,
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT,
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST,
            this.coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT,
            this.coldsInnerBuildInfosL3DataTableTEAMID,
            this.coldsInnerBuildInfosL3DataTableSHIFTID,
            this.coldsInnerBuildInfosL3DataTableOPERATOR,
            this.coldsInnerBuildInfosL3DataTableNOTE});
            this.schemadsInnerBuildInfos.TableName = "L3DataTable";
            // 
            // coldsInnerBuildInfosL3DataTableGUID
            // 
            this.coldsInnerBuildInfosL3DataTableGUID.Caption = "GUID";
            this.coldsInnerBuildInfosL3DataTableGUID.ColumnName = "GUID";
            this.coldsInnerBuildInfosL3DataTableGUID.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableGUID.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableNAME
            // 
            this.coldsInnerBuildInfosL3DataTableNAME.Caption = "NAME";
            this.coldsInnerBuildInfosL3DataTableNAME.ColumnName = "NAME";
            this.coldsInnerBuildInfosL3DataTableNAME.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableNAME.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableINPUT_TIME
            // 
            this.coldsInnerBuildInfosL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsInnerBuildInfosL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsInnerBuildInfosL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsInnerBuildInfosL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableINNERID
            // 
            this.coldsInnerBuildInfosL3DataTableINNERID.Caption = "INNERID";
            this.coldsInnerBuildInfosL3DataTableINNERID.ColumnName = "INNERID";
            this.coldsInnerBuildInfosL3DataTableINNERID.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableINNERID.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableLADLEID
            // 
            this.coldsInnerBuildInfosL3DataTableLADLEID.Caption = "LADLEID";
            this.coldsInnerBuildInfosL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsInnerBuildInfosL3DataTableLADLEID.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableLADLEID.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableBUILD_START_TIME
            // 
            this.coldsInnerBuildInfosL3DataTableBUILD_START_TIME.Caption = "BUILD_START_TIME";
            this.coldsInnerBuildInfosL3DataTableBUILD_START_TIME.ColumnName = "BUILD_START_TIME";
            this.coldsInnerBuildInfosL3DataTableBUILD_START_TIME.DataType = typeof(System.DateTime);
            this.coldsInnerBuildInfosL3DataTableBUILD_START_TIME.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableBUILD_END_TIME
            // 
            this.coldsInnerBuildInfosL3DataTableBUILD_END_TIME.Caption = "BUILD_END_TIME";
            this.coldsInnerBuildInfosL3DataTableBUILD_END_TIME.ColumnName = "BUILD_END_TIME";
            this.coldsInnerBuildInfosL3DataTableBUILD_END_TIME.DataType = typeof(System.DateTime);
            this.coldsInnerBuildInfosL3DataTableBUILD_END_TIME.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC
            // 
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC.Caption = "ATO_LIG_CAST_FAC";
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC.ColumnName = "ATO_LIG_CAST_FAC";
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST
            // 
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST.Caption = "ATO_LIG_CAST_WAST";
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST.ColumnName = "ATO_LIG_CAST_WAST";
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST.DataType = typeof(double);
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST.DefaultValue = 0;
            this.coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC
            // 
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC.Caption = "HARD_FI_ADI_BOA_FAC";
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC.ColumnName = "HARD_FI_ADI_BOA_FAC";
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST
            // 
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST.Caption = "HARD_FI_ADI_BOA_WAST";
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST.ColumnName = "HARD_FI_ADI_BOA_WAST";
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST.DataType = typeof(double);
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST.DefaultValue = 0;
            this.coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC
            // 
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC.Caption = "SPINEL_CAST_FAC";
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC.ColumnName = "SPINEL_CAST_FAC";
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST
            // 
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST.Caption = "SPINEL_CAST_WAST";
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST.ColumnName = "SPINEL_CAST_WAST";
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST.DataType = typeof(double);
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST.DefaultValue = 0;
            this.coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC
            // 
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC.Caption = "AL_MG_BRICK_FAC";
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC.ColumnName = "AL_MG_BRICK_FAC";
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST
            // 
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST.Caption = "AL_MG_BRICK_WAST";
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST.ColumnName = "AL_MG_BRICK_WAST";
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST.DataType = typeof(double);
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST.DefaultValue = 0;
            this.coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT
            // 
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT.Caption = "MG_FIRECALY_FACT";
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT.ColumnName = "MG_FIRECALY_FACT";
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST
            // 
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST.Caption = "MG_FIRECALY_WAST";
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST.ColumnName = "MG_FIRECALY_WAST";
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST.DataType = typeof(double);
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST.DefaultValue = 0;
            this.coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT
            // 
            this.coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT.Caption = "LADLE_INNER_USE_COUNT";
            this.coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT.ColumnName = "LADLE_INNER_USE_COUNT";
            this.coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT.DataType = typeof(int);
            this.coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT.DefaultValue = 0;
            this.coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableTEAMID
            // 
            this.coldsInnerBuildInfosL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsInnerBuildInfosL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsInnerBuildInfosL3DataTableTEAMID.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableTEAMID.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableSHIFTID
            // 
            this.coldsInnerBuildInfosL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsInnerBuildInfosL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsInnerBuildInfosL3DataTableSHIFTID.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableOPERATOR
            // 
            this.coldsInnerBuildInfosL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsInnerBuildInfosL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsInnerBuildInfosL3DataTableOPERATOR.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsInnerBuildInfosL3DataTableNOTE
            // 
            this.coldsInnerBuildInfosL3DataTableNOTE.Caption = "NOTE";
            this.coldsInnerBuildInfosL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsInnerBuildInfosL3DataTableNOTE.DefaultValue = "";
            this.coldsInnerBuildInfosL3DataTableNOTE.Namespace = "";
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bnInnerBuildInfos, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bnInnerBuildInfos
            // 
            this.bnInnerBuildInfos.AddNewItem = null;
            this.bnInnerBuildInfos.AutoSize = false;
            this.bnInnerBuildInfos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnInnerBuildInfos.BackgroundImage")));
            this.bnInnerBuildInfos.BindingSource = this.bsInnerBuildInfos;
            this.bnInnerBuildInfos.CountItem = this.bindingNavigatorCountItem;
            this.bnInnerBuildInfos.DeleteItem = null;
            this.bnInnerBuildInfos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel5,
            this.cmbLadleID,
            this.toolStripLabel2,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel3,
            this.btnDataConfirm});
            this.bnInnerBuildInfos.Location = new System.Drawing.Point(0, 43);
            this.bnInnerBuildInfos.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnInnerBuildInfos.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnInnerBuildInfos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnInnerBuildInfos.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnInnerBuildInfos.Name = "bnInnerBuildInfos";
            this.bnInnerBuildInfos.PositionItem = this.bindingNavigatorPositionItem;
            this.bnInnerBuildInfos.Size = new System.Drawing.Size(1000, 25);
            this.bnInnerBuildInfos.TabIndex = 27;
            this.bnInnerBuildInfos.Text = "bindingNavigator1";
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
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(121, 25);
            this.cmbLadleID.DropDownClosed += new System.EventHandler(this.cmbLadleID_DropDownClosed);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "钢包号:";
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "录入日期:";
            // 
            // btnDataConfirm
            // 
            this.btnDataConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnDataConfirm.Image")));
            this.btnDataConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDataConfirm.Name = "btnDataConfirm";
            this.btnDataConfirm.Size = new System.Drawing.Size(73, 22);
            this.btnDataConfirm.Text = "数据确认";
            this.btnDataConfirm.Visible = false;
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
            this.iNNERIDDataGridViewTextBoxColumn,
            this.lADLEIDDataGridViewTextBoxColumn,
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn,
            this.bUILDENDTIMEDataGridViewTextBoxColumn,
            this.aTOLIGCASTFACDataGridViewTextBoxColumn,
            this.aTOLIGCASTWASTDataGridViewTextBoxColumn,
            this.hARDFIADIBOAFACDataGridViewTextBoxColumn,
            this.hARDFIADIBOAWASTDataGridViewTextBoxColumn,
            this.sPINELCASTFACDataGridViewTextBoxColumn,
            this.sPINELCASTWASTDataGridViewTextBoxColumn,
            this.aLMGBRICKFACDataGridViewTextBoxColumn,
            this.aLMGBRICKWASTDataGridViewTextBoxColumn,
            this.mGFIRECALYFACTDataGridViewTextBoxColumn,
            this.mGFIRECALYWASTDataGridViewTextBoxColumn,
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsInnerBuildInfos;
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
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoSubscribe = false;
            this.dsLadleID.DataSetName = "L3DataSet";
            this.dsLadleID.DeleteMethod = null;
            this.dsLadleID.InsertMethod = null;
            this.dsLadleID.L3DataAdapter = this.Adapter;
            this.dsLadleID.LoadEvent = "Click";
            this.dsLadleID.LoadTrigger = null;
            this.dsLadleID.RefreshValve = 1000;
            this.dsLadleID.SourceCommand = null;
            this.dsLadleID.SourceCondition = "LadleID is not null order by LadleID";
            this.dsLadleID.SourceMethod = "";
            this.dsLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleID.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
            this.dsLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleID});
            this.dsLadleID.UpdateEvent = "Click";
            this.dsLadleID.UpdateMethod = null;
            this.dsLadleID.UpdateTrigger = null;
            // 
            // schemadsLadleID
            // 
            this.schemadsLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleIDL3DataTableLadleID});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableLadleID
            // 
            this.coldsLadleIDL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.Namespace = "";
            // 
            // dsShiftID
            // 
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
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // iNNERIDDataGridViewTextBoxColumn
            // 
            this.iNNERIDDataGridViewTextBoxColumn.DataPropertyName = "INNERID";
            this.iNNERIDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.iNNERIDDataGridViewTextBoxColumn.Name = "iNNERIDDataGridViewTextBoxColumn";
            this.iNNERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNNERIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // lADLEIDDataGridViewTextBoxColumn
            // 
            this.lADLEIDDataGridViewTextBoxColumn.DataPropertyName = "LADLEID";
            this.lADLEIDDataGridViewTextBoxColumn.HeaderText = "包号";
            this.lADLEIDDataGridViewTextBoxColumn.Name = "lADLEIDDataGridViewTextBoxColumn";
            this.lADLEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // bUILDSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "BUILD_START_TIME";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "开始砌筑时间";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.Name = "bUILDSTARTTIMEDataGridViewTextBoxColumn";
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUILDSTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // bUILDENDTIMEDataGridViewTextBoxColumn
            // 
            this.bUILDENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "BUILD_END_TIME";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.HeaderText = "结束砌筑时间";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.Name = "bUILDENDTIMEDataGridViewTextBoxColumn";
            this.bUILDENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUILDENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // aTOLIGCASTFACDataGridViewTextBoxColumn
            // 
            this.aTOLIGCASTFACDataGridViewTextBoxColumn.DataPropertyName = "ATO_LIG_CAST_FAC";
            this.aTOLIGCASTFACDataGridViewTextBoxColumn.HeaderText = "微孔轻质浇铸料厂家";
            this.aTOLIGCASTFACDataGridViewTextBoxColumn.Name = "aTOLIGCASTFACDataGridViewTextBoxColumn";
            this.aTOLIGCASTFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.aTOLIGCASTFACDataGridViewTextBoxColumn.Width = 138;
            // 
            // aTOLIGCASTWASTDataGridViewTextBoxColumn
            // 
            this.aTOLIGCASTWASTDataGridViewTextBoxColumn.DataPropertyName = "ATO_LIG_CAST_WAST";
            this.aTOLIGCASTWASTDataGridViewTextBoxColumn.HeaderText = "微孔轻质浇铸料消耗量[t]";
            this.aTOLIGCASTWASTDataGridViewTextBoxColumn.Name = "aTOLIGCASTWASTDataGridViewTextBoxColumn";
            this.aTOLIGCASTWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aTOLIGCASTWASTDataGridViewTextBoxColumn.Width = 168;
            // 
            // hARDFIADIBOAFACDataGridViewTextBoxColumn
            // 
            this.hARDFIADIBOAFACDataGridViewTextBoxColumn.DataPropertyName = "HARD_FI_ADI_BOA_FAC";
            this.hARDFIADIBOAFACDataGridViewTextBoxColumn.HeaderText = "硬质纤维隔热板厂家";
            this.hARDFIADIBOAFACDataGridViewTextBoxColumn.Name = "hARDFIADIBOAFACDataGridViewTextBoxColumn";
            this.hARDFIADIBOAFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.hARDFIADIBOAFACDataGridViewTextBoxColumn.Width = 138;
            // 
            // hARDFIADIBOAWASTDataGridViewTextBoxColumn
            // 
            this.hARDFIADIBOAWASTDataGridViewTextBoxColumn.DataPropertyName = "HARD_FI_ADI_BOA_WAST";
            this.hARDFIADIBOAWASTDataGridViewTextBoxColumn.HeaderText = "硬质纤维隔热板消耗量[m2]";
            this.hARDFIADIBOAWASTDataGridViewTextBoxColumn.Name = "hARDFIADIBOAWASTDataGridViewTextBoxColumn";
            this.hARDFIADIBOAWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.hARDFIADIBOAWASTDataGridViewTextBoxColumn.Width = 174;
            // 
            // sPINELCASTFACDataGridViewTextBoxColumn
            // 
            this.sPINELCASTFACDataGridViewTextBoxColumn.DataPropertyName = "SPINEL_CAST_FAC";
            this.sPINELCASTFACDataGridViewTextBoxColumn.HeaderText = "尖晶石浇铸料厂家";
            this.sPINELCASTFACDataGridViewTextBoxColumn.Name = "sPINELCASTFACDataGridViewTextBoxColumn";
            this.sPINELCASTFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPINELCASTFACDataGridViewTextBoxColumn.Width = 126;
            // 
            // sPINELCASTWASTDataGridViewTextBoxColumn
            // 
            this.sPINELCASTWASTDataGridViewTextBoxColumn.DataPropertyName = "SPINEL_CAST_WAST";
            this.sPINELCASTWASTDataGridViewTextBoxColumn.HeaderText = "尖晶石浇铸料消耗量[t]";
            this.sPINELCASTWASTDataGridViewTextBoxColumn.Name = "sPINELCASTWASTDataGridViewTextBoxColumn";
            this.sPINELCASTWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPINELCASTWASTDataGridViewTextBoxColumn.Width = 156;
            // 
            // aLMGBRICKFACDataGridViewTextBoxColumn
            // 
            this.aLMGBRICKFACDataGridViewTextBoxColumn.DataPropertyName = "AL_MG_BRICK_FAC";
            this.aLMGBRICKFACDataGridViewTextBoxColumn.HeaderText = "铝镁砖厂家";
            this.aLMGBRICKFACDataGridViewTextBoxColumn.Name = "aLMGBRICKFACDataGridViewTextBoxColumn";
            this.aLMGBRICKFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLMGBRICKFACDataGridViewTextBoxColumn.Width = 90;
            // 
            // aLMGBRICKWASTDataGridViewTextBoxColumn
            // 
            this.aLMGBRICKWASTDataGridViewTextBoxColumn.DataPropertyName = "AL_MG_BRICK_WAST";
            this.aLMGBRICKWASTDataGridViewTextBoxColumn.HeaderText = "铝镁砖消耗量[t]";
            this.aLMGBRICKWASTDataGridViewTextBoxColumn.Name = "aLMGBRICKWASTDataGridViewTextBoxColumn";
            this.aLMGBRICKWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.aLMGBRICKWASTDataGridViewTextBoxColumn.Width = 120;
            // 
            // mGFIRECALYFACTDataGridViewTextBoxColumn
            // 
            this.mGFIRECALYFACTDataGridViewTextBoxColumn.DataPropertyName = "MG_FIRECALY_FACT";
            this.mGFIRECALYFACTDataGridViewTextBoxColumn.HeaderText = "镁火泥厂家";
            this.mGFIRECALYFACTDataGridViewTextBoxColumn.Name = "mGFIRECALYFACTDataGridViewTextBoxColumn";
            this.mGFIRECALYFACTDataGridViewTextBoxColumn.ReadOnly = true;
            this.mGFIRECALYFACTDataGridViewTextBoxColumn.Width = 90;
            // 
            // mGFIRECALYWASTDataGridViewTextBoxColumn
            // 
            this.mGFIRECALYWASTDataGridViewTextBoxColumn.DataPropertyName = "MG_FIRECALY_WAST";
            this.mGFIRECALYWASTDataGridViewTextBoxColumn.HeaderText = "镁火泥消耗量[t]";
            this.mGFIRECALYWASTDataGridViewTextBoxColumn.Name = "mGFIRECALYWASTDataGridViewTextBoxColumn";
            this.mGFIRECALYWASTDataGridViewTextBoxColumn.ReadOnly = true;
            this.mGFIRECALYWASTDataGridViewTextBoxColumn.Width = 120;
            // 
            // lADLEINNERUSECOUNTDataGridViewTextBoxColumn
            // 
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.DataPropertyName = "LADLE_INNER_USE_COUNT";
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.HeaderText = "永久层使用次数";
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.Name = "lADLEINNERUSECOUNTDataGridViewTextBoxColumn";
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEINNERUSECOUNTDataGridViewTextBoxColumn.Width = 114;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 54;
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
            // LadleInnerBuildMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LadleInnerBuildMagFrm";
            this.TabText = "钢包永久层砌筑实绩管理";
            this.Text = "钢包永久层砌筑实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LadleInnerBuildMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LadleInnerBuildMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuildInfos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerBuildInfos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerBuildInfos)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnInnerBuildInfos)).EndInit();
            this.bnInnerBuildInfos.ResumeLayout(false);
            this.bnInnerBuildInfos.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsInnerBuildInfos;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bnInnerBuildInfos;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private AppSvrHMI.L3Command cmdInnerBuildInfos;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbLadleID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsInnerBuildInfos;
        private System.Data.DataTable schemadsInnerBuildInfos;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableGUID;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableNAME;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableINNERID;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableLADLEID;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableBUILD_START_TIME;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableBUILD_END_TIME;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableATO_LIG_CAST_FAC;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableATO_LIG_CAST_WAST;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_FAC;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableHARD_FI_ADI_BOA_WAST;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableSPINEL_CAST_FAC;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableSPINEL_CAST_WAST;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableAL_MG_BRICK_FAC;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableAL_MG_BRICK_WAST;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableMG_FIRECALY_FACT;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableMG_FIRECALY_WAST;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableLADLE_INNER_USE_COUNT;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableTEAMID;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableSHIFTID;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableOPERATOR;
        private System.Data.DataColumn coldsInnerBuildInfosL3DataTableNOTE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.ToolStripButton btnDataConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTOLIGCASTFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTOLIGCASTWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARDFIADIBOAFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARDFIADIBOAWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPINELCASTFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPINELCASTWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLMGBRICKFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLMGBRICKWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGFIRECALYFACTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mGFIRECALYWASTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEINNERUSECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
    }
}