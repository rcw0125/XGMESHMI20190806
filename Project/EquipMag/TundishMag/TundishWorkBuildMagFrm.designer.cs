namespace EquipMag.TundishMag
{
    partial class TundishWorkBuildMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishWorkBuildMagFrm));
            this.bsDaub = new System.Windows.Forms.BindingSource(this.components);
            this.dsDaub = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsDaub = new System.Data.DataTable();
            this.coldsDaubL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableNAME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableCAST_ID = new System.Data.DataColumn();
            this.coldsDaubL3DataTablePROJECT = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGAP_BRI_FAC = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGAP_BRI_CONSUME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableWARD_DREGS_FAC = new System.Data.DataColumn();
            this.coldsDaubL3DataTableWARD_DREGS_CONSUME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTRANQ_FAC = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTRANQ_CONSUME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDAUB_FAC = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDAUB_CONSUME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDRY_FLAP_FAC = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDRY_FLAP_CONSUME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGLUEMUD_FAC = new System.Data.DataColumn();
            this.coldsDaubL3DataTableGLUEMUD_CONSUME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDAUB_START_TIME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableDAUB_END_TIME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableFIRE_START_TIME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableFIRE_END_TIME = new System.Data.DataColumn();
            this.coldsDaubL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsDaubL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsDaubL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsDaubL3DataTableInner_Use_Count = new System.Data.DataColumn();
            this.coldsDaubL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bdDaub = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTundishID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvDaub = new System.Windows.Forms.DataGridView();
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            this.tundishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerUseCountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROJECTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAPBRIFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAPBRICONSUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wARDDREGSFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wARDDREGSCONSUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANQFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANQCONSUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUBFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUBCONSUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRYFLAPFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dRYFLAPCONSUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLUEMUDFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gLUEMUDCONSUMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUBSTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUBENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIREENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdDaub)).BeginInit();
            this.bdDaub.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDaub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsDaub
            // 
            this.bsDaub.DataMember = "L3DataTable";
            this.bsDaub.DataSource = this.dsDaub;
            // 
            // dsDaub
            // 
            this.dsDaub.AutoSubscribe = false;
            this.dsDaub.DataSetName = "L3DataSet";
            this.dsDaub.DeleteMethod = "";
            this.dsDaub.InsertMethod = "";
            this.dsDaub.L3DataAdapter = this.Adapter;
            this.dsDaub.LoadEvent = "Click";
            this.dsDaub.LoadTrigger = null;
            this.dsDaub.RefreshValve = 1000;
            this.dsDaub.SourceCommand = null;
            this.dsDaub.SourceCondition = "1=2";
            this.dsDaub.SourceMethod = "";
            this.dsDaub.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDaub.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Daub";
            this.dsDaub.SubscribeTarget = null;
            this.dsDaub.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDaub});
            this.dsDaub.UpdateEvent = "Click";
            this.dsDaub.UpdateMethod = "";
            this.dsDaub.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsDaub
            // 
            this.schemadsDaub.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDaubL3DataTableGUID,
            this.coldsDaubL3DataTableNAME,
            this.coldsDaubL3DataTableTundishID,
            this.coldsDaubL3DataTableCAST_ID,
            this.coldsDaubL3DataTablePROJECT,
            this.coldsDaubL3DataTableGAP_BRI_FAC,
            this.coldsDaubL3DataTableGAP_BRI_CONSUME,
            this.coldsDaubL3DataTableWARD_DREGS_FAC,
            this.coldsDaubL3DataTableWARD_DREGS_CONSUME,
            this.coldsDaubL3DataTableTRANQ_FAC,
            this.coldsDaubL3DataTableTRANQ_CONSUME,
            this.coldsDaubL3DataTableDAUB_FAC,
            this.coldsDaubL3DataTableDAUB_CONSUME,
            this.coldsDaubL3DataTableDRY_FLAP_FAC,
            this.coldsDaubL3DataTableDRY_FLAP_CONSUME,
            this.coldsDaubL3DataTableGLUEMUD_FAC,
            this.coldsDaubL3DataTableGLUEMUD_CONSUME,
            this.coldsDaubL3DataTableDAUB_START_TIME,
            this.coldsDaubL3DataTableDAUB_END_TIME,
            this.coldsDaubL3DataTableFIRE_START_TIME,
            this.coldsDaubL3DataTableFIRE_END_TIME,
            this.coldsDaubL3DataTableTEAMID,
            this.coldsDaubL3DataTableSHIFTID,
            this.coldsDaubL3DataTableOPERATOR,
            this.coldsDaubL3DataTableNOTE,
            this.coldsDaubL3DataTableWorkID,
            this.coldsDaubL3DataTableInnerID,
            this.coldsDaubL3DataTableInner_Use_Count,
            this.coldsDaubL3DataTableConfirm_Flag});
            this.schemadsDaub.TableName = "L3DataTable";
            // 
            // coldsDaubL3DataTableGUID
            // 
            this.coldsDaubL3DataTableGUID.Caption = "GUID";
            this.coldsDaubL3DataTableGUID.ColumnName = "GUID";
            this.coldsDaubL3DataTableGUID.Namespace = "";
            // 
            // coldsDaubL3DataTableNAME
            // 
            this.coldsDaubL3DataTableNAME.Caption = "Name";
            this.coldsDaubL3DataTableNAME.ColumnName = "NAME";
            this.coldsDaubL3DataTableNAME.Namespace = "";
            // 
            // coldsDaubL3DataTableTundishID
            // 
            this.coldsDaubL3DataTableTundishID.Caption = "TundishID";
            this.coldsDaubL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsDaubL3DataTableTundishID.Namespace = "";
            // 
            // coldsDaubL3DataTableCAST_ID
            // 
            this.coldsDaubL3DataTableCAST_ID.Caption = "Cast_ID";
            this.coldsDaubL3DataTableCAST_ID.ColumnName = "CAST_ID";
            this.coldsDaubL3DataTableCAST_ID.Namespace = "";
            // 
            // coldsDaubL3DataTablePROJECT
            // 
            this.coldsDaubL3DataTablePROJECT.Caption = "Project";
            this.coldsDaubL3DataTablePROJECT.ColumnName = "PROJECT";
            this.coldsDaubL3DataTablePROJECT.Namespace = "";
            // 
            // coldsDaubL3DataTableGAP_BRI_FAC
            // 
            this.coldsDaubL3DataTableGAP_BRI_FAC.Caption = "Gap_Bri_Fac";
            this.coldsDaubL3DataTableGAP_BRI_FAC.ColumnName = "GAP_BRI_FAC";
            this.coldsDaubL3DataTableGAP_BRI_FAC.Namespace = "";
            // 
            // coldsDaubL3DataTableGAP_BRI_CONSUME
            // 
            this.coldsDaubL3DataTableGAP_BRI_CONSUME.Caption = "Gap_Bri_Consume";
            this.coldsDaubL3DataTableGAP_BRI_CONSUME.ColumnName = "GAP_BRI_CONSUME";
            this.coldsDaubL3DataTableGAP_BRI_CONSUME.DataType = typeof(double);
            this.coldsDaubL3DataTableGAP_BRI_CONSUME.Namespace = "";
            // 
            // coldsDaubL3DataTableWARD_DREGS_FAC
            // 
            this.coldsDaubL3DataTableWARD_DREGS_FAC.Caption = "Ward_Dregs_Fac";
            this.coldsDaubL3DataTableWARD_DREGS_FAC.ColumnName = "WARD_DREGS_FAC";
            this.coldsDaubL3DataTableWARD_DREGS_FAC.Namespace = "";
            // 
            // coldsDaubL3DataTableWARD_DREGS_CONSUME
            // 
            this.coldsDaubL3DataTableWARD_DREGS_CONSUME.Caption = "Ward_Dregs_Consume";
            this.coldsDaubL3DataTableWARD_DREGS_CONSUME.ColumnName = "WARD_DREGS_CONSUME";
            this.coldsDaubL3DataTableWARD_DREGS_CONSUME.DataType = typeof(double);
            this.coldsDaubL3DataTableWARD_DREGS_CONSUME.Namespace = "";
            // 
            // coldsDaubL3DataTableTRANQ_FAC
            // 
            this.coldsDaubL3DataTableTRANQ_FAC.Caption = "Tranq_Fac";
            this.coldsDaubL3DataTableTRANQ_FAC.ColumnName = "TRANQ_FAC";
            this.coldsDaubL3DataTableTRANQ_FAC.Namespace = "";
            // 
            // coldsDaubL3DataTableTRANQ_CONSUME
            // 
            this.coldsDaubL3DataTableTRANQ_CONSUME.Caption = "Tranq_Consume";
            this.coldsDaubL3DataTableTRANQ_CONSUME.ColumnName = "TRANQ_CONSUME";
            this.coldsDaubL3DataTableTRANQ_CONSUME.DataType = typeof(double);
            this.coldsDaubL3DataTableTRANQ_CONSUME.Namespace = "";
            // 
            // coldsDaubL3DataTableDAUB_FAC
            // 
            this.coldsDaubL3DataTableDAUB_FAC.Caption = "Daub_Fac";
            this.coldsDaubL3DataTableDAUB_FAC.ColumnName = "DAUB_FAC";
            this.coldsDaubL3DataTableDAUB_FAC.Namespace = "";
            // 
            // coldsDaubL3DataTableDAUB_CONSUME
            // 
            this.coldsDaubL3DataTableDAUB_CONSUME.Caption = "Daub_Consume";
            this.coldsDaubL3DataTableDAUB_CONSUME.ColumnName = "DAUB_CONSUME";
            this.coldsDaubL3DataTableDAUB_CONSUME.DataType = typeof(double);
            this.coldsDaubL3DataTableDAUB_CONSUME.Namespace = "";
            // 
            // coldsDaubL3DataTableDRY_FLAP_FAC
            // 
            this.coldsDaubL3DataTableDRY_FLAP_FAC.Caption = "Dry_Flap_Fac";
            this.coldsDaubL3DataTableDRY_FLAP_FAC.ColumnName = "DRY_FLAP_FAC";
            this.coldsDaubL3DataTableDRY_FLAP_FAC.Namespace = "";
            // 
            // coldsDaubL3DataTableDRY_FLAP_CONSUME
            // 
            this.coldsDaubL3DataTableDRY_FLAP_CONSUME.Caption = "Dry_Flap_Consume";
            this.coldsDaubL3DataTableDRY_FLAP_CONSUME.ColumnName = "DRY_FLAP_CONSUME";
            this.coldsDaubL3DataTableDRY_FLAP_CONSUME.DataType = typeof(double);
            this.coldsDaubL3DataTableDRY_FLAP_CONSUME.Namespace = "";
            // 
            // coldsDaubL3DataTableGLUEMUD_FAC
            // 
            this.coldsDaubL3DataTableGLUEMUD_FAC.Caption = "Gluemud_Fac";
            this.coldsDaubL3DataTableGLUEMUD_FAC.ColumnName = "GLUEMUD_FAC";
            this.coldsDaubL3DataTableGLUEMUD_FAC.Namespace = "";
            // 
            // coldsDaubL3DataTableGLUEMUD_CONSUME
            // 
            this.coldsDaubL3DataTableGLUEMUD_CONSUME.Caption = "Gluemud_Consume";
            this.coldsDaubL3DataTableGLUEMUD_CONSUME.ColumnName = "GLUEMUD_CONSUME";
            this.coldsDaubL3DataTableGLUEMUD_CONSUME.DataType = typeof(double);
            this.coldsDaubL3DataTableGLUEMUD_CONSUME.Namespace = "";
            // 
            // coldsDaubL3DataTableDAUB_START_TIME
            // 
            this.coldsDaubL3DataTableDAUB_START_TIME.Caption = "Daub_Start_Time";
            this.coldsDaubL3DataTableDAUB_START_TIME.ColumnName = "DAUB_START_TIME";
            this.coldsDaubL3DataTableDAUB_START_TIME.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableDAUB_START_TIME.Namespace = "";
            // 
            // coldsDaubL3DataTableDAUB_END_TIME
            // 
            this.coldsDaubL3DataTableDAUB_END_TIME.Caption = "Daub_End_Time";
            this.coldsDaubL3DataTableDAUB_END_TIME.ColumnName = "DAUB_END_TIME";
            this.coldsDaubL3DataTableDAUB_END_TIME.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableDAUB_END_TIME.Namespace = "";
            // 
            // coldsDaubL3DataTableFIRE_START_TIME
            // 
            this.coldsDaubL3DataTableFIRE_START_TIME.Caption = "Fire_Start_Time";
            this.coldsDaubL3DataTableFIRE_START_TIME.ColumnName = "FIRE_START_TIME";
            this.coldsDaubL3DataTableFIRE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableFIRE_START_TIME.Namespace = "";
            // 
            // coldsDaubL3DataTableFIRE_END_TIME
            // 
            this.coldsDaubL3DataTableFIRE_END_TIME.Caption = "Fire_End_Time";
            this.coldsDaubL3DataTableFIRE_END_TIME.ColumnName = "FIRE_END_TIME";
            this.coldsDaubL3DataTableFIRE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsDaubL3DataTableFIRE_END_TIME.Namespace = "";
            // 
            // coldsDaubL3DataTableTEAMID
            // 
            this.coldsDaubL3DataTableTEAMID.Caption = "TeamID";
            this.coldsDaubL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsDaubL3DataTableTEAMID.Namespace = "";
            // 
            // coldsDaubL3DataTableSHIFTID
            // 
            this.coldsDaubL3DataTableSHIFTID.Caption = "ShiftID";
            this.coldsDaubL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsDaubL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsDaubL3DataTableOPERATOR
            // 
            this.coldsDaubL3DataTableOPERATOR.Caption = "Operator";
            this.coldsDaubL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsDaubL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsDaubL3DataTableNOTE
            // 
            this.coldsDaubL3DataTableNOTE.Caption = "Note";
            this.coldsDaubL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsDaubL3DataTableNOTE.Namespace = "";
            // 
            // coldsDaubL3DataTableWorkID
            // 
            this.coldsDaubL3DataTableWorkID.Caption = "WorkID";
            this.coldsDaubL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsDaubL3DataTableWorkID.Namespace = "";
            // 
            // coldsDaubL3DataTableInnerID
            // 
            this.coldsDaubL3DataTableInnerID.Caption = "InnerID";
            this.coldsDaubL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsDaubL3DataTableInnerID.Namespace = "";
            // 
            // coldsDaubL3DataTableInner_Use_Count
            // 
            this.coldsDaubL3DataTableInner_Use_Count.Caption = "Inner_Use_Count";
            this.coldsDaubL3DataTableInner_Use_Count.ColumnName = "Inner_Use_Count";
            this.coldsDaubL3DataTableInner_Use_Count.DataType = typeof(short);
            this.coldsDaubL3DataTableInner_Use_Count.Namespace = "";
            // 
            // coldsDaubL3DataTableConfirm_Flag
            // 
            this.coldsDaubL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsDaubL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsDaubL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsDaubL3DataTableConfirm_Flag.Namespace = "";
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
            this.dsShiftID.SourceCondition = "code_group = \'ShiftID\'";
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
            this.dsTeamID.SourceCondition = "code_group = \'TeamID\'";
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
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bdDaub, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 1);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 2;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdDaub
            // 
            this.bdDaub.AddNewItem = null;
            this.bdDaub.AutoSize = false;
            this.bdDaub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdDaub.BackgroundImage")));
            this.bdDaub.BindingSource = this.bsDaub;
            this.bdDaub.CountItem = this.bindingNavigatorCountItem;
            this.bdDaub.DeleteItem = null;
            this.bdDaub.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel4,
            this.dtEnd,
            this.toolStripLabel3,
            this.dtStart,
            this.toolStripLabel2,
            this.cmbTundishID,
            this.toolStripLabel5,
            this.btnOutput});
            this.bdDaub.Location = new System.Drawing.Point(0, 0);
            this.bdDaub.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdDaub.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdDaub.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdDaub.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdDaub.Name = "bdDaub";
            this.bdDaub.PositionItem = this.bindingNavigatorPositionItem;
            this.bdDaub.Size = new System.Drawing.Size(1000, 25);
            this.bdDaub.TabIndex = 27;
            this.bdDaub.Text = "bindingNavigator1";
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
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel4.Text = " ";
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
            this.dtEnd.Text = "2008-11-18";
            this.dtEnd.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 197);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel3.Text = "-";
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
            this.dtStart.Text = "2008-11-18";
            this.dtStart.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 147);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "录入日期:";
            // 
            // cmbTundishID
            // 
            this.cmbTundishID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTundishID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTundishID.Name = "cmbTundishID";
            this.cmbTundishID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel5.Text = "中包号:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvDaub);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 675);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvDaub
            // 
            this.dvDaub.AllowUserToAddRows = false;
            this.dvDaub.AutoGenerateColumns = false;
            this.dvDaub.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvDaub.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDaub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tundishIDDataGridViewTextBoxColumn,
            this.innerIDDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.innerUseCountDataGridViewCheckBoxColumn,
            this.cASTIDDataGridViewTextBoxColumn,
            this.pROJECTDataGridViewTextBoxColumn,
            this.gAPBRIFACDataGridViewTextBoxColumn,
            this.gAPBRICONSUMEDataGridViewTextBoxColumn,
            this.wARDDREGSFACDataGridViewTextBoxColumn,
            this.wARDDREGSCONSUMEDataGridViewTextBoxColumn,
            this.tRANQFACDataGridViewTextBoxColumn,
            this.tRANQCONSUMEDataGridViewTextBoxColumn,
            this.dAUBFACDataGridViewTextBoxColumn,
            this.dAUBCONSUMEDataGridViewTextBoxColumn,
            this.dRYFLAPFACDataGridViewTextBoxColumn,
            this.dRYFLAPCONSUMEDataGridViewTextBoxColumn,
            this.gLUEMUDFACDataGridViewTextBoxColumn,
            this.gLUEMUDCONSUMEDataGridViewTextBoxColumn,
            this.dAUBSTARTTIMEDataGridViewTextBoxColumn,
            this.dAUBENDTIMEDataGridViewTextBoxColumn,
            this.fIRESTARTTIMEDataGridViewTextBoxColumn,
            this.fIREENDTIMEDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.confirmFlagDataGridViewTextBoxColumn});
            this.dvDaub.DataSource = this.bsDaub;
            this.dvDaub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDaub.Location = new System.Drawing.Point(0, 0);
            this.dvDaub.Margin = new System.Windows.Forms.Padding(0);
            this.dvDaub.Name = "dvDaub";
            this.dvDaub.ReadOnly = true;
            this.dvDaub.RowTemplate.Height = 23;
            this.dvDaub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDaub.Size = new System.Drawing.Size(1000, 675);
            this.dvDaub.TabIndex = 31;
            this.dvDaub.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDaub_DataError);
            // 
            // dsTundishID
            // 
            this.dsTundishID.AutoSubscribe = false;
            this.dsTundishID.DataSetName = "L3DataSet";
            this.dsTundishID.DeleteMethod = null;
            this.dsTundishID.InsertMethod = null;
            this.dsTundishID.L3DataAdapter = this.Adapter;
            this.dsTundishID.LoadEvent = "Click";
            this.dsTundishID.LoadTrigger = null;
            this.dsTundishID.RefreshValve = 1000;
            this.dsTundishID.SourceCommand = null;
            this.dsTundishID.SourceCondition = "";
            this.dsTundishID.SourceMethod = "";
            this.dsTundishID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishID.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Base";
            this.dsTundishID.SubscribeTarget = null;
            this.dsTundishID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundishID});
            this.dsTundishID.UpdateEvent = "Click";
            this.dsTundishID.UpdateMethod = null;
            this.dsTundishID.UpdateTrigger = null;
            // 
            // schemadsTundishID
            // 
            this.schemadsTundishID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishIDL3DataTableTundishID});
            this.schemadsTundishID.TableName = "L3DataTable";
            // 
            // coldsTundishIDL3DataTableTundishID
            // 
            this.coldsTundishIDL3DataTableTundishID.Caption = "TundishID";
            this.coldsTundishIDL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsTundishIDL3DataTableTundishID.Namespace = "";
            // 
            // tundishIDDataGridViewTextBoxColumn
            // 
            this.tundishIDDataGridViewTextBoxColumn.DataPropertyName = "TundishID";
            this.tundishIDDataGridViewTextBoxColumn.Frozen = true;
            this.tundishIDDataGridViewTextBoxColumn.HeaderText = "中包号";
            this.tundishIDDataGridViewTextBoxColumn.Name = "tundishIDDataGridViewTextBoxColumn";
            this.tundishIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tundishIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // innerIDDataGridViewTextBoxColumn
            // 
            this.innerIDDataGridViewTextBoxColumn.DataPropertyName = "InnerID";
            this.innerIDDataGridViewTextBoxColumn.HeaderText = "永久层编号";
            this.innerIDDataGridViewTextBoxColumn.Name = "innerIDDataGridViewTextBoxColumn";
            this.innerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // innerUseCountDataGridViewCheckBoxColumn
            // 
            this.innerUseCountDataGridViewCheckBoxColumn.DataPropertyName = "Inner_Use_Count";
            this.innerUseCountDataGridViewCheckBoxColumn.HeaderText = "永久层使用次数";
            this.innerUseCountDataGridViewCheckBoxColumn.Name = "innerUseCountDataGridViewCheckBoxColumn";
            this.innerUseCountDataGridViewCheckBoxColumn.ReadOnly = true;
            this.innerUseCountDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.innerUseCountDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.innerUseCountDataGridViewCheckBoxColumn.Width = 95;
            // 
            // cASTIDDataGridViewTextBoxColumn
            // 
            this.cASTIDDataGridViewTextBoxColumn.DataPropertyName = "CAST_ID";
            this.cASTIDDataGridViewTextBoxColumn.HeaderText = "铸机";
            this.cASTIDDataGridViewTextBoxColumn.Name = "cASTIDDataGridViewTextBoxColumn";
            this.cASTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // pROJECTDataGridViewTextBoxColumn
            // 
            this.pROJECTDataGridViewTextBoxColumn.DataPropertyName = "PROJECT";
            this.pROJECTDataGridViewTextBoxColumn.HeaderText = "项目";
            this.pROJECTDataGridViewTextBoxColumn.Name = "pROJECTDataGridViewTextBoxColumn";
            this.pROJECTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROJECTDataGridViewTextBoxColumn.Width = 54;
            // 
            // gAPBRIFACDataGridViewTextBoxColumn
            // 
            this.gAPBRIFACDataGridViewTextBoxColumn.DataPropertyName = "GAP_BRI_FAC";
            this.gAPBRIFACDataGridViewTextBoxColumn.HeaderText = "座砖厂家";
            this.gAPBRIFACDataGridViewTextBoxColumn.Name = "gAPBRIFACDataGridViewTextBoxColumn";
            this.gAPBRIFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.gAPBRIFACDataGridViewTextBoxColumn.Width = 78;
            // 
            // gAPBRICONSUMEDataGridViewTextBoxColumn
            // 
            this.gAPBRICONSUMEDataGridViewTextBoxColumn.DataPropertyName = "GAP_BRI_CONSUME";
            this.gAPBRICONSUMEDataGridViewTextBoxColumn.HeaderText = "座砖消耗量";
            this.gAPBRICONSUMEDataGridViewTextBoxColumn.Name = "gAPBRICONSUMEDataGridViewTextBoxColumn";
            this.gAPBRICONSUMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.gAPBRICONSUMEDataGridViewTextBoxColumn.Width = 90;
            // 
            // wARDDREGSFACDataGridViewTextBoxColumn
            // 
            this.wARDDREGSFACDataGridViewTextBoxColumn.DataPropertyName = "WARD_DREGS_FAC";
            this.wARDDREGSFACDataGridViewTextBoxColumn.HeaderText = "挡渣墙厂家";
            this.wARDDREGSFACDataGridViewTextBoxColumn.Name = "wARDDREGSFACDataGridViewTextBoxColumn";
            this.wARDDREGSFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.wARDDREGSFACDataGridViewTextBoxColumn.Width = 90;
            // 
            // wARDDREGSCONSUMEDataGridViewTextBoxColumn
            // 
            this.wARDDREGSCONSUMEDataGridViewTextBoxColumn.DataPropertyName = "WARD_DREGS_CONSUME";
            this.wARDDREGSCONSUMEDataGridViewTextBoxColumn.HeaderText = "挡渣墙消耗量";
            this.wARDDREGSCONSUMEDataGridViewTextBoxColumn.Name = "wARDDREGSCONSUMEDataGridViewTextBoxColumn";
            this.wARDDREGSCONSUMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.wARDDREGSCONSUMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // tRANQFACDataGridViewTextBoxColumn
            // 
            this.tRANQFACDataGridViewTextBoxColumn.DataPropertyName = "TRANQ_FAC";
            this.tRANQFACDataGridViewTextBoxColumn.HeaderText = "紊流器厂家";
            this.tRANQFACDataGridViewTextBoxColumn.Name = "tRANQFACDataGridViewTextBoxColumn";
            this.tRANQFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRANQFACDataGridViewTextBoxColumn.Width = 90;
            // 
            // tRANQCONSUMEDataGridViewTextBoxColumn
            // 
            this.tRANQCONSUMEDataGridViewTextBoxColumn.DataPropertyName = "TRANQ_CONSUME";
            this.tRANQCONSUMEDataGridViewTextBoxColumn.HeaderText = "紊流器消耗量";
            this.tRANQCONSUMEDataGridViewTextBoxColumn.Name = "tRANQCONSUMEDataGridViewTextBoxColumn";
            this.tRANQCONSUMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tRANQCONSUMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // dAUBFACDataGridViewTextBoxColumn
            // 
            this.dAUBFACDataGridViewTextBoxColumn.DataPropertyName = "DAUB_FAC";
            this.dAUBFACDataGridViewTextBoxColumn.HeaderText = "涂抹料厂家";
            this.dAUBFACDataGridViewTextBoxColumn.Name = "dAUBFACDataGridViewTextBoxColumn";
            this.dAUBFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAUBFACDataGridViewTextBoxColumn.Width = 90;
            // 
            // dAUBCONSUMEDataGridViewTextBoxColumn
            // 
            this.dAUBCONSUMEDataGridViewTextBoxColumn.DataPropertyName = "DAUB_CONSUME";
            this.dAUBCONSUMEDataGridViewTextBoxColumn.HeaderText = "涂抹料消耗量";
            this.dAUBCONSUMEDataGridViewTextBoxColumn.Name = "dAUBCONSUMEDataGridViewTextBoxColumn";
            this.dAUBCONSUMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAUBCONSUMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // dRYFLAPFACDataGridViewTextBoxColumn
            // 
            this.dRYFLAPFACDataGridViewTextBoxColumn.DataPropertyName = "DRY_FLAP_FAC";
            this.dRYFLAPFACDataGridViewTextBoxColumn.HeaderText = "干振料厂家";
            this.dRYFLAPFACDataGridViewTextBoxColumn.Name = "dRYFLAPFACDataGridViewTextBoxColumn";
            this.dRYFLAPFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRYFLAPFACDataGridViewTextBoxColumn.Width = 90;
            // 
            // dRYFLAPCONSUMEDataGridViewTextBoxColumn
            // 
            this.dRYFLAPCONSUMEDataGridViewTextBoxColumn.DataPropertyName = "DRY_FLAP_CONSUME";
            this.dRYFLAPCONSUMEDataGridViewTextBoxColumn.HeaderText = "干振料消耗量";
            this.dRYFLAPCONSUMEDataGridViewTextBoxColumn.Name = "dRYFLAPCONSUMEDataGridViewTextBoxColumn";
            this.dRYFLAPCONSUMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dRYFLAPCONSUMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // gLUEMUDFACDataGridViewTextBoxColumn
            // 
            this.gLUEMUDFACDataGridViewTextBoxColumn.DataPropertyName = "GLUEMUD_FAC";
            this.gLUEMUDFACDataGridViewTextBoxColumn.HeaderText = "胶泥厂家";
            this.gLUEMUDFACDataGridViewTextBoxColumn.Name = "gLUEMUDFACDataGridViewTextBoxColumn";
            this.gLUEMUDFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.gLUEMUDFACDataGridViewTextBoxColumn.Width = 78;
            // 
            // gLUEMUDCONSUMEDataGridViewTextBoxColumn
            // 
            this.gLUEMUDCONSUMEDataGridViewTextBoxColumn.DataPropertyName = "GLUEMUD_CONSUME";
            this.gLUEMUDCONSUMEDataGridViewTextBoxColumn.HeaderText = "胶泥消耗量";
            this.gLUEMUDCONSUMEDataGridViewTextBoxColumn.Name = "gLUEMUDCONSUMEDataGridViewTextBoxColumn";
            this.gLUEMUDCONSUMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.gLUEMUDCONSUMEDataGridViewTextBoxColumn.Width = 90;
            // 
            // dAUBSTARTTIMEDataGridViewTextBoxColumn
            // 
            this.dAUBSTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "DAUB_START_TIME";
            this.dAUBSTARTTIMEDataGridViewTextBoxColumn.HeaderText = "涂抹(干振)开始时间";
            this.dAUBSTARTTIMEDataGridViewTextBoxColumn.Name = "dAUBSTARTTIMEDataGridViewTextBoxColumn";
            this.dAUBSTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAUBSTARTTIMEDataGridViewTextBoxColumn.Width = 138;
            // 
            // dAUBENDTIMEDataGridViewTextBoxColumn
            // 
            this.dAUBENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "DAUB_END_TIME";
            this.dAUBENDTIMEDataGridViewTextBoxColumn.HeaderText = "涂抹(干振)结束时间";
            this.dAUBENDTIMEDataGridViewTextBoxColumn.Name = "dAUBENDTIMEDataGridViewTextBoxColumn";
            this.dAUBENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAUBENDTIMEDataGridViewTextBoxColumn.Width = 138;
            // 
            // fIRESTARTTIMEDataGridViewTextBoxColumn
            // 
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_START_TIME";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤开始时间";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Name = "fIRESTARTTIMEDataGridViewTextBoxColumn";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // fIREENDTIMEDataGridViewTextBoxColumn
            // 
            this.fIREENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_END_TIME";
            this.fIREENDTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤结束时间";
            this.fIREENDTIMEDataGridViewTextBoxColumn.Name = "fIREENDTIMEDataGridViewTextBoxColumn";
            this.fIREENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIREENDTIMEDataGridViewTextBoxColumn.Width = 102;
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
            // confirmFlagDataGridViewTextBoxColumn
            // 
            this.confirmFlagDataGridViewTextBoxColumn.DataPropertyName = "Confirm_Flag";
            this.confirmFlagDataGridViewTextBoxColumn.HeaderText = "实绩确认标志";
            this.confirmFlagDataGridViewTextBoxColumn.Name = "confirmFlagDataGridViewTextBoxColumn";
            this.confirmFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.confirmFlagDataGridViewTextBoxColumn.Visible = false;
            this.confirmFlagDataGridViewTextBoxColumn.Width = 102;
            // 
            // TundishWorkBuildMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishWorkBuildMagFrm";
            this.TabText = "中包工作层涂抹/干振实绩管理";
            this.Text = "中包工作层涂抹/干振实绩查询";
            this.Load += new System.EventHandler(this.TundishWorkBuildMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDaub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDaub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDaub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdDaub)).EndInit();
            this.bdDaub.ResumeLayout(false);
            this.bdDaub.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDaub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsDaub;
        private System.Windows.Forms.BindingSource bsDaub;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdDaub;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvDaub;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataTable schemadsDaub;
        private System.Data.DataColumn coldsDaubL3DataTableGUID;
        private System.Data.DataColumn coldsDaubL3DataTableNAME;
        private System.Data.DataColumn coldsDaubL3DataTableTundishID;
        private System.Data.DataColumn coldsDaubL3DataTableCAST_ID;
        private System.Data.DataColumn coldsDaubL3DataTablePROJECT;
        private System.Data.DataColumn coldsDaubL3DataTableGAP_BRI_FAC;
        private System.Data.DataColumn coldsDaubL3DataTableGAP_BRI_CONSUME;
        private System.Data.DataColumn coldsDaubL3DataTableWARD_DREGS_FAC;
        private System.Data.DataColumn coldsDaubL3DataTableWARD_DREGS_CONSUME;
        private System.Data.DataColumn coldsDaubL3DataTableTRANQ_FAC;
        private System.Data.DataColumn coldsDaubL3DataTableTRANQ_CONSUME;
        private System.Data.DataColumn coldsDaubL3DataTableDAUB_FAC;
        private System.Data.DataColumn coldsDaubL3DataTableDAUB_CONSUME;
        private System.Data.DataColumn coldsDaubL3DataTableDRY_FLAP_FAC;
        private System.Data.DataColumn coldsDaubL3DataTableDRY_FLAP_CONSUME;
        private System.Data.DataColumn coldsDaubL3DataTableGLUEMUD_FAC;
        private System.Data.DataColumn coldsDaubL3DataTableGLUEMUD_CONSUME;
        private System.Data.DataColumn coldsDaubL3DataTableDAUB_START_TIME;
        private System.Data.DataColumn coldsDaubL3DataTableDAUB_END_TIME;
        private System.Data.DataColumn coldsDaubL3DataTableFIRE_START_TIME;
        private System.Data.DataColumn coldsDaubL3DataTableFIRE_END_TIME;
        private System.Data.DataColumn coldsDaubL3DataTableTEAMID;
        private System.Data.DataColumn coldsDaubL3DataTableSHIFTID;
        private System.Data.DataColumn coldsDaubL3DataTableOPERATOR;
        private System.Data.DataColumn coldsDaubL3DataTableNOTE;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Data.DataColumn coldsDaubL3DataTableWorkID;
        private System.Data.DataColumn coldsDaubL3DataTableInnerID;
        private System.Data.DataColumn coldsDaubL3DataTableInner_Use_Count;
        private System.Data.DataColumn coldsDaubL3DataTableConfirm_Flag;
        private System.Windows.Forms.ToolStripComboBox cmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerUseCountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROJECTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAPBRIFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAPBRICONSUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wARDDREGSFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wARDDREGSCONSUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANQFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANQCONSUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAUBFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAUBCONSUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRYFLAPFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dRYFLAPCONSUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLUEMUDFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gLUEMUDCONSUMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAUBSTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAUBENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIREENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmFlagDataGridViewTextBoxColumn;
    }
}