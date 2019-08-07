namespace EquipMag.TundishMag
{
    partial class TundishTFFHotFireMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishTFFHotFireMagFrm));
            this.bsFireInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsFireInfo = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsFireInfo = new System.Data.DataTable();
            this.coldsFireInfoL3DataTableGUID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableNAME = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableCAST_ID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableFIRST_FRA_ID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableSECOND_FRA_ID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableTHIRD_FRA_ID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableFOURTH_FRA_ID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableSMALL_END_TIME = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableMID_END_TIME = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableBIG_END_TIME = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableSEV_WALL_TEMP = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableSEV_GAP_TEMP = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableVehicleID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableCrane_TeamID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableSmall_Start_Time = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableMid_Start_Time = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableBig_Start_Time = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableConfirm_Flag = new System.Data.DataColumn();
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
            this.bndsInnerFire = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTundishID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvFireInfo = new System.Windows.Forms.DataGridView();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_des = new System.Data.DataColumn();
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            this.tundishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTFRAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sECONDFRAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHIRDFRAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOURTHFRAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMALLENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIGENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEVWALLTEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEVGAPTEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.craneTeamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bigStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndsInnerFire)).BeginInit();
            this.bndsInnerFire.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFireInfo
            // 
            this.bsFireInfo.DataMember = "L3DataTable";
            this.bsFireInfo.DataSource = this.dsFireInfo;
            // 
            // dsFireInfo
            // 
            this.dsFireInfo.AutoSubscribe = false;
            this.dsFireInfo.DataSetName = "L3DataSet";
            this.dsFireInfo.DeleteMethod = "";
            this.dsFireInfo.InsertMethod = "";
            this.dsFireInfo.L3DataAdapter = this.Adapter;
            this.dsFireInfo.LoadEvent = "Click";
            this.dsFireInfo.LoadTrigger = null;
            this.dsFireInfo.RefreshValve = 1000;
            this.dsFireInfo.SourceCommand = null;
            this.dsFireInfo.SourceCondition = "1=2";
            this.dsFireInfo.SourceMethod = "";
            this.dsFireInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFireInfo.SourceURI = "XGMESLogic\\TundishMag\\CTundish_TFF_Hot_Fire";
            this.dsFireInfo.SubscribeTarget = null;
            this.dsFireInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFireInfo});
            this.dsFireInfo.UpdateEvent = "Click";
            this.dsFireInfo.UpdateMethod = "";
            this.dsFireInfo.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsFireInfo
            // 
            this.schemadsFireInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFireInfoL3DataTableGUID,
            this.coldsFireInfoL3DataTableNAME,
            this.coldsFireInfoL3DataTableTundishID,
            this.coldsFireInfoL3DataTableCAST_ID,
            this.coldsFireInfoL3DataTableNOTE,
            this.coldsFireInfoL3DataTableTEAMID,
            this.coldsFireInfoL3DataTableSHIFTID,
            this.coldsFireInfoL3DataTableOPERATOR,
            this.coldsFireInfoL3DataTableFIRST_FRA_ID,
            this.coldsFireInfoL3DataTableSECOND_FRA_ID,
            this.coldsFireInfoL3DataTableTHIRD_FRA_ID,
            this.coldsFireInfoL3DataTableFOURTH_FRA_ID,
            this.coldsFireInfoL3DataTableSMALL_END_TIME,
            this.coldsFireInfoL3DataTableMID_END_TIME,
            this.coldsFireInfoL3DataTableBIG_END_TIME,
            this.coldsFireInfoL3DataTableSEV_WALL_TEMP,
            this.coldsFireInfoL3DataTableSEV_GAP_TEMP,
            this.coldsFireInfoL3DataTableWorkID,
            this.coldsFireInfoL3DataTableVehicleID,
            this.coldsFireInfoL3DataTableCrane_TeamID,
            this.coldsFireInfoL3DataTableSmall_Start_Time,
            this.coldsFireInfoL3DataTableMid_Start_Time,
            this.coldsFireInfoL3DataTableBig_Start_Time,
            this.coldsFireInfoL3DataTableConfirm_Flag});
            this.schemadsFireInfo.TableName = "L3DataTable";
            // 
            // coldsFireInfoL3DataTableGUID
            // 
            this.coldsFireInfoL3DataTableGUID.Caption = "GUID";
            this.coldsFireInfoL3DataTableGUID.ColumnName = "GUID";
            this.coldsFireInfoL3DataTableGUID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableNAME
            // 
            this.coldsFireInfoL3DataTableNAME.Caption = "Name";
            this.coldsFireInfoL3DataTableNAME.ColumnName = "NAME";
            this.coldsFireInfoL3DataTableNAME.Namespace = "";
            // 
            // coldsFireInfoL3DataTableTundishID
            // 
            this.coldsFireInfoL3DataTableTundishID.Caption = "TundishID";
            this.coldsFireInfoL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsFireInfoL3DataTableTundishID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableCAST_ID
            // 
            this.coldsFireInfoL3DataTableCAST_ID.Caption = "Cast_ID";
            this.coldsFireInfoL3DataTableCAST_ID.ColumnName = "CAST_ID";
            this.coldsFireInfoL3DataTableCAST_ID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableNOTE
            // 
            this.coldsFireInfoL3DataTableNOTE.Caption = "Note";
            this.coldsFireInfoL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsFireInfoL3DataTableNOTE.Namespace = "";
            // 
            // coldsFireInfoL3DataTableTEAMID
            // 
            this.coldsFireInfoL3DataTableTEAMID.Caption = "TeamID";
            this.coldsFireInfoL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsFireInfoL3DataTableTEAMID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableSHIFTID
            // 
            this.coldsFireInfoL3DataTableSHIFTID.Caption = "ShiftID";
            this.coldsFireInfoL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsFireInfoL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableOPERATOR
            // 
            this.coldsFireInfoL3DataTableOPERATOR.Caption = "Operator";
            this.coldsFireInfoL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsFireInfoL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsFireInfoL3DataTableFIRST_FRA_ID
            // 
            this.coldsFireInfoL3DataTableFIRST_FRA_ID.Caption = "First_Fra_ID";
            this.coldsFireInfoL3DataTableFIRST_FRA_ID.ColumnName = "FIRST_FRA_ID";
            this.coldsFireInfoL3DataTableFIRST_FRA_ID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableSECOND_FRA_ID
            // 
            this.coldsFireInfoL3DataTableSECOND_FRA_ID.Caption = "Second_Fra_ID";
            this.coldsFireInfoL3DataTableSECOND_FRA_ID.ColumnName = "SECOND_FRA_ID";
            this.coldsFireInfoL3DataTableSECOND_FRA_ID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableTHIRD_FRA_ID
            // 
            this.coldsFireInfoL3DataTableTHIRD_FRA_ID.Caption = "Third_Fra_ID";
            this.coldsFireInfoL3DataTableTHIRD_FRA_ID.ColumnName = "THIRD_FRA_ID";
            this.coldsFireInfoL3DataTableTHIRD_FRA_ID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableFOURTH_FRA_ID
            // 
            this.coldsFireInfoL3DataTableFOURTH_FRA_ID.Caption = "Fourth_Fra_ID";
            this.coldsFireInfoL3DataTableFOURTH_FRA_ID.ColumnName = "FOURTH_FRA_ID";
            this.coldsFireInfoL3DataTableFOURTH_FRA_ID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableSMALL_END_TIME
            // 
            this.coldsFireInfoL3DataTableSMALL_END_TIME.Caption = "Small_End_Time";
            this.coldsFireInfoL3DataTableSMALL_END_TIME.ColumnName = "SMALL_END_TIME";
            this.coldsFireInfoL3DataTableSMALL_END_TIME.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableSMALL_END_TIME.Namespace = "";
            // 
            // coldsFireInfoL3DataTableMID_END_TIME
            // 
            this.coldsFireInfoL3DataTableMID_END_TIME.Caption = "Mid_End_Time";
            this.coldsFireInfoL3DataTableMID_END_TIME.ColumnName = "MID_END_TIME";
            this.coldsFireInfoL3DataTableMID_END_TIME.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableMID_END_TIME.Namespace = "";
            // 
            // coldsFireInfoL3DataTableBIG_END_TIME
            // 
            this.coldsFireInfoL3DataTableBIG_END_TIME.Caption = "Big_End_Time";
            this.coldsFireInfoL3DataTableBIG_END_TIME.ColumnName = "BIG_END_TIME";
            this.coldsFireInfoL3DataTableBIG_END_TIME.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableBIG_END_TIME.Namespace = "";
            // 
            // coldsFireInfoL3DataTableSEV_WALL_TEMP
            // 
            this.coldsFireInfoL3DataTableSEV_WALL_TEMP.Caption = "Sev_Wall_Temp";
            this.coldsFireInfoL3DataTableSEV_WALL_TEMP.ColumnName = "SEV_WALL_TEMP";
            this.coldsFireInfoL3DataTableSEV_WALL_TEMP.DataType = typeof(double);
            this.coldsFireInfoL3DataTableSEV_WALL_TEMP.Namespace = "";
            // 
            // coldsFireInfoL3DataTableSEV_GAP_TEMP
            // 
            this.coldsFireInfoL3DataTableSEV_GAP_TEMP.Caption = "Sev_Gap_Temp";
            this.coldsFireInfoL3DataTableSEV_GAP_TEMP.ColumnName = "SEV_GAP_TEMP";
            this.coldsFireInfoL3DataTableSEV_GAP_TEMP.DataType = typeof(double);
            this.coldsFireInfoL3DataTableSEV_GAP_TEMP.Namespace = "";
            // 
            // coldsFireInfoL3DataTableWorkID
            // 
            this.coldsFireInfoL3DataTableWorkID.Caption = "WorkID";
            this.coldsFireInfoL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsFireInfoL3DataTableWorkID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableVehicleID
            // 
            this.coldsFireInfoL3DataTableVehicleID.Caption = "VehicleID";
            this.coldsFireInfoL3DataTableVehicleID.ColumnName = "VehicleID";
            this.coldsFireInfoL3DataTableVehicleID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableCrane_TeamID
            // 
            this.coldsFireInfoL3DataTableCrane_TeamID.Caption = "Crane_TeamID";
            this.coldsFireInfoL3DataTableCrane_TeamID.ColumnName = "Crane_TeamID";
            this.coldsFireInfoL3DataTableCrane_TeamID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableSmall_Start_Time
            // 
            this.coldsFireInfoL3DataTableSmall_Start_Time.Caption = "Small_Start_Time";
            this.coldsFireInfoL3DataTableSmall_Start_Time.ColumnName = "Small_Start_Time";
            this.coldsFireInfoL3DataTableSmall_Start_Time.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableSmall_Start_Time.Namespace = "";
            // 
            // coldsFireInfoL3DataTableMid_Start_Time
            // 
            this.coldsFireInfoL3DataTableMid_Start_Time.Caption = "Mid_Start_Time";
            this.coldsFireInfoL3DataTableMid_Start_Time.ColumnName = "Mid_Start_Time";
            this.coldsFireInfoL3DataTableMid_Start_Time.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableMid_Start_Time.Namespace = "";
            // 
            // coldsFireInfoL3DataTableBig_Start_Time
            // 
            this.coldsFireInfoL3DataTableBig_Start_Time.Caption = "Big_Start_Time";
            this.coldsFireInfoL3DataTableBig_Start_Time.ColumnName = "Big_Start_Time";
            this.coldsFireInfoL3DataTableBig_Start_Time.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableBig_Start_Time.Namespace = "";
            // 
            // coldsFireInfoL3DataTableConfirm_Flag
            // 
            this.coldsFireInfoL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsFireInfoL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsFireInfoL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsFireInfoL3DataTableConfirm_Flag.Namespace = "";
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
            this.tbLPM.Controls.Add(this.bndsInnerFire, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 1);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 2;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 2;
            // 
            // bndsInnerFire
            // 
            this.bndsInnerFire.AddNewItem = null;
            this.bndsInnerFire.AutoSize = false;
            this.bndsInnerFire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bndsInnerFire.BackgroundImage")));
            this.bndsInnerFire.BindingSource = this.bsFireInfo;
            this.bndsInnerFire.CountItem = this.bindingNavigatorCountItem;
            this.bndsInnerFire.DeleteItem = null;
            this.bndsInnerFire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel4,
            this.dtEnd,
            this.toolStripLabel3,
            this.dtStart,
            this.toolStripLabel5,
            this.cmbTundishID,
            this.toolStripLabel6,
            this.btnOutput});
            this.bndsInnerFire.Location = new System.Drawing.Point(0, 0);
            this.bndsInnerFire.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndsInnerFire.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndsInnerFire.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndsInnerFire.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndsInnerFire.Name = "bndsInnerFire";
            this.bndsInnerFire.PositionItem = this.bindingNavigatorPositionItem;
            this.bndsInnerFire.Size = new System.Drawing.Size(1000, 25);
            this.bndsInnerFire.TabIndex = 27;
            this.bndsInnerFire.Text = "bindingNavigator1";
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = "  ";
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
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel5.Text = "录入日期:";
            // 
            // cmbTundishID
            // 
            this.cmbTundishID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTundishID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTundishID.Name = "cmbTundishID";
            this.cmbTundishID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel6.Text = "中包号:";
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
            this.hmiRootPanel1.Controls.Add(this.dvFireInfo);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 675);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvFireInfo
            // 
            this.dvFireInfo.AllowUserToAddRows = false;
            this.dvFireInfo.AutoGenerateColumns = false;
            this.dvFireInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvFireInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvFireInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tundishIDDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.cASTIDDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.fIRSTFRAIDDataGridViewTextBoxColumn,
            this.sECONDFRAIDDataGridViewTextBoxColumn,
            this.tHIRDFRAIDDataGridViewTextBoxColumn,
            this.fOURTHFRAIDDataGridViewTextBoxColumn,
            this.sMALLENDTIMEDataGridViewTextBoxColumn,
            this.mIDENDTIMEDataGridViewTextBoxColumn,
            this.bIGENDTIMEDataGridViewTextBoxColumn,
            this.sEVWALLTEMPDataGridViewTextBoxColumn,
            this.sEVGAPTEMPDataGridViewTextBoxColumn,
            this.craneTeamIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.smallStartTimeDataGridViewTextBoxColumn,
            this.midStartTimeDataGridViewTextBoxColumn,
            this.bigStartTimeDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.confirmFlagDataGridViewTextBoxColumn});
            this.dvFireInfo.DataSource = this.bsFireInfo;
            this.dvFireInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFireInfo.Location = new System.Drawing.Point(0, 0);
            this.dvFireInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dvFireInfo.Name = "dvFireInfo";
            this.dvFireInfo.ReadOnly = true;
            this.dvFireInfo.RowTemplate.Height = 23;
            this.dvFireInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvFireInfo.Size = new System.Drawing.Size(1000, 675);
            this.dvFireInfo.TabIndex = 31;
            this.dvFireInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFireInfo_DataError);
            // 
            // dsCasterID
            // 
            this.dsCasterID.AutoSubscribe = false;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "code_group = \'Caster\'";
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
            this.coldsCasterIDL3DataTableCode_des});
            this.schemadsCasterID.TableName = "L3DataTable";
            // 
            // coldsCasterIDL3DataTableCode
            // 
            this.coldsCasterIDL3DataTableCode.Caption = "Code";
            this.coldsCasterIDL3DataTableCode.ColumnName = "Code";
            this.coldsCasterIDL3DataTableCode.Namespace = "";
            // 
            // coldsCasterIDL3DataTableCode_des
            // 
            this.coldsCasterIDL3DataTableCode_des.Caption = "Code_des";
            this.coldsCasterIDL3DataTableCode_des.ColumnName = "Code_des";
            this.coldsCasterIDL3DataTableCode_des.Namespace = "";
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
            this.tundishIDDataGridViewTextBoxColumn.HeaderText = "包号";
            this.tundishIDDataGridViewTextBoxColumn.Name = "tundishIDDataGridViewTextBoxColumn";
            this.tundishIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tundishIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // cASTIDDataGridViewTextBoxColumn
            // 
            this.cASTIDDataGridViewTextBoxColumn.DataPropertyName = "CAST_ID";
            this.cASTIDDataGridViewTextBoxColumn.HeaderText = "铸机";
            this.cASTIDDataGridViewTextBoxColumn.Name = "cASTIDDataGridViewTextBoxColumn";
            this.cASTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cASTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cASTIDDataGridViewTextBoxColumn.Width = 54;
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
            // fIRSTFRAIDDataGridViewTextBoxColumn
            // 
            this.fIRSTFRAIDDataGridViewTextBoxColumn.DataPropertyName = "FIRST_FRA_ID";
            this.fIRSTFRAIDDataGridViewTextBoxColumn.HeaderText = "1流机构编号";
            this.fIRSTFRAIDDataGridViewTextBoxColumn.Name = "fIRSTFRAIDDataGridViewTextBoxColumn";
            this.fIRSTFRAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRSTFRAIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // sECONDFRAIDDataGridViewTextBoxColumn
            // 
            this.sECONDFRAIDDataGridViewTextBoxColumn.DataPropertyName = "SECOND_FRA_ID";
            this.sECONDFRAIDDataGridViewTextBoxColumn.HeaderText = "2流机构编号";
            this.sECONDFRAIDDataGridViewTextBoxColumn.Name = "sECONDFRAIDDataGridViewTextBoxColumn";
            this.sECONDFRAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sECONDFRAIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // tHIRDFRAIDDataGridViewTextBoxColumn
            // 
            this.tHIRDFRAIDDataGridViewTextBoxColumn.DataPropertyName = "THIRD_FRA_ID";
            this.tHIRDFRAIDDataGridViewTextBoxColumn.HeaderText = "3流机构编号";
            this.tHIRDFRAIDDataGridViewTextBoxColumn.Name = "tHIRDFRAIDDataGridViewTextBoxColumn";
            this.tHIRDFRAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tHIRDFRAIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // fOURTHFRAIDDataGridViewTextBoxColumn
            // 
            this.fOURTHFRAIDDataGridViewTextBoxColumn.DataPropertyName = "FOURTH_FRA_ID";
            this.fOURTHFRAIDDataGridViewTextBoxColumn.HeaderText = "4流机构编号";
            this.fOURTHFRAIDDataGridViewTextBoxColumn.Name = "fOURTHFRAIDDataGridViewTextBoxColumn";
            this.fOURTHFRAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fOURTHFRAIDDataGridViewTextBoxColumn.Width = 96;
            // 
            // sMALLENDTIMEDataGridViewTextBoxColumn
            // 
            this.sMALLENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "SMALL_END_TIME";
            this.sMALLENDTIMEDataGridViewTextBoxColumn.HeaderText = "小火结束时间";
            this.sMALLENDTIMEDataGridViewTextBoxColumn.Name = "sMALLENDTIMEDataGridViewTextBoxColumn";
            this.sMALLENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sMALLENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // mIDENDTIMEDataGridViewTextBoxColumn
            // 
            this.mIDENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "MID_END_TIME";
            this.mIDENDTIMEDataGridViewTextBoxColumn.HeaderText = "中火结束时间";
            this.mIDENDTIMEDataGridViewTextBoxColumn.Name = "mIDENDTIMEDataGridViewTextBoxColumn";
            this.mIDENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mIDENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // bIGENDTIMEDataGridViewTextBoxColumn
            // 
            this.bIGENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "BIG_END_TIME";
            this.bIGENDTIMEDataGridViewTextBoxColumn.HeaderText = "大火结束时间";
            this.bIGENDTIMEDataGridViewTextBoxColumn.Name = "bIGENDTIMEDataGridViewTextBoxColumn";
            this.bIGENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIGENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // sEVWALLTEMPDataGridViewTextBoxColumn
            // 
            this.sEVWALLTEMPDataGridViewTextBoxColumn.DataPropertyName = "SEV_WALL_TEMP";
            this.sEVWALLTEMPDataGridViewTextBoxColumn.HeaderText = "包壁温度";
            this.sEVWALLTEMPDataGridViewTextBoxColumn.Name = "sEVWALLTEMPDataGridViewTextBoxColumn";
            this.sEVWALLTEMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEVWALLTEMPDataGridViewTextBoxColumn.Width = 78;
            // 
            // sEVGAPTEMPDataGridViewTextBoxColumn
            // 
            this.sEVGAPTEMPDataGridViewTextBoxColumn.DataPropertyName = "SEV_GAP_TEMP";
            this.sEVGAPTEMPDataGridViewTextBoxColumn.HeaderText = "水口温度";
            this.sEVGAPTEMPDataGridViewTextBoxColumn.Name = "sEVGAPTEMPDataGridViewTextBoxColumn";
            this.sEVGAPTEMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEVGAPTEMPDataGridViewTextBoxColumn.Width = 78;
            // 
            // craneTeamIDDataGridViewTextBoxColumn
            // 
            this.craneTeamIDDataGridViewTextBoxColumn.DataPropertyName = "Crane_TeamID";
            this.craneTeamIDDataGridViewTextBoxColumn.HeaderText = "吊包班组";
            this.craneTeamIDDataGridViewTextBoxColumn.Name = "craneTeamIDDataGridViewTextBoxColumn";
            this.craneTeamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.craneTeamIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "中包车号";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // smallStartTimeDataGridViewTextBoxColumn
            // 
            this.smallStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Small_Start_Time";
            this.smallStartTimeDataGridViewTextBoxColumn.HeaderText = "小火开始时间";
            this.smallStartTimeDataGridViewTextBoxColumn.Name = "smallStartTimeDataGridViewTextBoxColumn";
            this.smallStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.smallStartTimeDataGridViewTextBoxColumn.Width = 102;
            // 
            // midStartTimeDataGridViewTextBoxColumn
            // 
            this.midStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Mid_Start_Time";
            this.midStartTimeDataGridViewTextBoxColumn.HeaderText = "中火开始时间";
            this.midStartTimeDataGridViewTextBoxColumn.Name = "midStartTimeDataGridViewTextBoxColumn";
            this.midStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.midStartTimeDataGridViewTextBoxColumn.Width = 102;
            // 
            // bigStartTimeDataGridViewTextBoxColumn
            // 
            this.bigStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Big_Start_Time";
            this.bigStartTimeDataGridViewTextBoxColumn.HeaderText = "大火开始时间";
            this.bigStartTimeDataGridViewTextBoxColumn.Name = "bigStartTimeDataGridViewTextBoxColumn";
            this.bigStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bigStartTimeDataGridViewTextBoxColumn.Width = 102;
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
            this.confirmFlagDataGridViewTextBoxColumn.HeaderText = "Confirm_Flag";
            this.confirmFlagDataGridViewTextBoxColumn.Name = "confirmFlagDataGridViewTextBoxColumn";
            this.confirmFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.confirmFlagDataGridViewTextBoxColumn.Visible = false;
            this.confirmFlagDataGridViewTextBoxColumn.Width = 102;
            // 
            // TundishTFFHotFireMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishTFFHotFireMagFrm";
            this.TabText = "3/4/5/7#铸机中间包热备烘烤实绩";
            this.Text = "中包工作层烘烤实绩查询";
            this.Load += new System.EventHandler(this.TundishTFFHotFireMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bndsInnerFire)).EndInit();
            this.bndsInnerFire.ResumeLayout(false);
            this.bndsInnerFire.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsFireInfo;
        private System.Windows.Forms.BindingSource bsFireInfo;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bndsInnerFire;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvFireInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Data.DataTable schemadsFireInfo;
        private System.Data.DataColumn coldsFireInfoL3DataTableGUID;
        private System.Data.DataColumn coldsFireInfoL3DataTableNAME;
        private System.Data.DataColumn coldsFireInfoL3DataTableTundishID;
        private System.Data.DataColumn coldsFireInfoL3DataTableCAST_ID;
        private System.Data.DataColumn coldsFireInfoL3DataTableNOTE;
        private System.Data.DataColumn coldsFireInfoL3DataTableTEAMID;
        private System.Data.DataColumn coldsFireInfoL3DataTableSHIFTID;
        private System.Data.DataColumn coldsFireInfoL3DataTableOPERATOR;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_des;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private System.Data.DataColumn coldsFireInfoL3DataTableFIRST_FRA_ID;
        private System.Data.DataColumn coldsFireInfoL3DataTableSECOND_FRA_ID;
        private System.Data.DataColumn coldsFireInfoL3DataTableTHIRD_FRA_ID;
        private System.Data.DataColumn coldsFireInfoL3DataTableFOURTH_FRA_ID;
        private System.Data.DataColumn coldsFireInfoL3DataTableSMALL_END_TIME;
        private System.Data.DataColumn coldsFireInfoL3DataTableMID_END_TIME;
        private System.Data.DataColumn coldsFireInfoL3DataTableBIG_END_TIME;
        private System.Data.DataColumn coldsFireInfoL3DataTableSEV_WALL_TEMP;
        private System.Data.DataColumn coldsFireInfoL3DataTableSEV_GAP_TEMP;
        private System.Windows.Forms.ToolStripComboBox cmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private System.Data.DataColumn coldsFireInfoL3DataTableWorkID;
        private System.Data.DataColumn coldsFireInfoL3DataTableVehicleID;
        private System.Data.DataColumn coldsFireInfoL3DataTableCrane_TeamID;
        private System.Data.DataColumn coldsFireInfoL3DataTableSmall_Start_Time;
        private System.Data.DataColumn coldsFireInfoL3DataTableMid_Start_Time;
        private System.Data.DataColumn coldsFireInfoL3DataTableBig_Start_Time;
        private System.Data.DataColumn coldsFireInfoL3DataTableConfirm_Flag;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTFRAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECONDFRAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHIRDFRAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOURTHFRAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMALLENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIGENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEVWALLTEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEVGAPTEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn craneTeamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bigStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmFlagDataGridViewTextBoxColumn;
    }
}