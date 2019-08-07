namespace EquipMag.AlarmMag
{
    partial class AlarmMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmMagFrm));
            this.bsUse = new System.Windows.Forms.BindingSource(this.components);
            this.dsUse = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdUse = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsUseL3DataTableUSE_DATE = new System.Data.DataColumn();
            this.coldsUseL3DataTableLADLE_AGE = new System.Data.DataColumn();
            this.coldsUseL3DataTableSTEEL_GRADE = new System.Data.DataColumn();
            this.coldsUseL3DataTableSEAT_OK_TIME = new System.Data.DataColumn();
            this.coldsUseL3DataTableTAP_TIME = new System.Data.DataColumn();
            this.coldsUseL3DataTableOFF_LADLE_TIME = new System.Data.DataColumn();
            this.coldsUseL3DataTableARRIVE_TIME = new System.Data.DataColumn();
            this.coldsUseL3DataTableCOMPLETE_TIME = new System.Data.DataColumn();
            this.coldsUseL3DataTableFIRE_TIME_LEN = new System.Data.DataColumn();
            this.coldsUseL3DataTableSTOP_TIME_LEN = new System.Data.DataColumn();
            this.coldsUseL3DataTableLADLE_CHECK = new System.Data.DataColumn();
            this.coldsUseL3DataTableOFF_REASON = new System.Data.DataColumn();
            this.coldsUseL3DataTableSK_BOARD_KEEP = new System.Data.DataColumn();
            this.coldsUseL3DataTableLADLE_GRADE = new System.Data.DataColumn();
            this.coldsUseL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsUseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsUseL3DataTableHot_Time = new System.Data.DataColumn();
            this.coldsUseL3DataTableFrame = new System.Data.DataColumn();
            this.coldsUseL3DataTableSplint = new System.Data.DataColumn();
            this.coldsUseL3DataTableSpringBox = new System.Data.DataColumn();
            this.coldsUseL3DataTableJoint = new System.Data.DataColumn();
            this.coldsUseL3DataTableJoint_Safety_Pin = new System.Data.DataColumn();
            this.coldsUseL3DataTableLong_Axes = new System.Data.DataColumn();
            this.coldsUseL3DataTableShort_Axes = new System.Data.DataColumn();
            this.coldsUseL3DataTableChassis = new System.Data.DataColumn();
            this.coldsUseL3DataTableProtect_Board = new System.Data.DataColumn();
            this.coldsUseL3DataTableUp_Tighten_Machine = new System.Data.DataColumn();
            this.coldsUseL3DataTableBreathe_Bri_Up = new System.Data.DataColumn();
            this.coldsUseL3DataTableBreathe_Bri_Low = new System.Data.DataColumn();
            this.coldsUseL3DataTableWater_Gap = new System.Data.DataColumn();
            this.coldsUseL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsUseL3DataTableIrr_Start_Time = new System.Data.DataColumn();
            this.coldsUseL3DataTableIrr_End_Time = new System.Data.DataColumn();
            this.coldsUseL3DataTableRemnantWT = new System.Data.DataColumn();
            this.coldsUseL3DataTableComFlag = new System.Data.DataColumn();
            this.coldsUseL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.coldsUseL3DataTableAct_Ladle_Grade = new System.Data.DataColumn();
            this.AcoldsUseL3DataTableNewLadleFirst = new System.Data.DataColumn();
            this.coldsUseL3DataTableNewLadleSecond = new System.Data.DataColumn();
            this.coldsUseL3DataTableFireLadleFirst = new System.Data.DataColumn();
            this.coldsUseL3DataTableFireLadleSecond = new System.Data.DataColumn();
            this.coldsUseL3DataTableReturnLadle = new System.Data.DataColumn();
            this.coldsUseL3DataTableHookEdgeLadle = new System.Data.DataColumn();
            this.coldsUseL3DataTableRemnantLadle = new System.Data.DataColumn();
            this.coldsUseL3DataTableLadle_Check1 = new System.Data.DataColumn();
            this.coldsUseL3DataTableWall_Temp = new System.Data.DataColumn();
            this.coldsUseL3DataTableNewLadleFirst = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
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
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbWorkID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnDataConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGBXXQuery = new System.Windows.Forms.ToolStripButton();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dvUse = new System.Windows.Forms.DataGridView();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelgradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmcontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realyvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAlarmMessage = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlarmMessage = new AppSvrHMI.L3DataSet();
            this.schemadsAlarmMessage = new System.Data.DataTable();
            this.coldsAlarmMessageL3DataTableteam = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTablesteelgrade = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTableworkid = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTablealarm_content = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTablealarm_name = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTabletundish_num = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTablerealy_value = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTablelow_value = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTableup_value = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTablealarm_time = new System.Data.DataColumn();
            this.coldsAlarmMessageL3DataTablealarm_level = new System.Data.DataColumn();
            this.dsLadleChcke = new AppSvrHMI.L3DataSet();
            this.schemadsLadleChcke = new System.Data.DataTable();
            this.coldsLadleChckeL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleChckeL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsLadleChcke1 = new AppSvrHMI.L3DataSet();
            this.schemadsLadleChcke1 = new System.Data.DataTable();
            this.coldsLadleChcke1L3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleChcke1L3DataTableCode_Des = new System.Data.DataColumn();
            this.dsLadleThrow = new AppSvrHMI.L3DataSet();
            this.schemadsLadleThrow = new System.Data.DataTable();
            this.coldsLadleThrowL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleThrowL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.dsUnitType = new AppSvrHMI.L3DataSet();
            this.schemadsUnitType = new System.Data.DataTable();
            this.coldsUnitTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlarmMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlarmMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlarmMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).BeginInit();
            this.SuspendLayout();
            // 
            // bsUse
            // 
            this.bsUse.DataMember = "L3DataTable";
            this.bsUse.DataSource = this.dsUse;
            // 
            // dsUse
            // 
            this.dsUse.AutoLoad = true;
            this.dsUse.AutoSubscribe = false;
            this.dsUse.DataSetName = "L3DataSet";
            this.dsUse.DeleteMethod = "DeleteLadleUseInfos";
            this.dsUse.InsertMethod = "InsertLadleUseInfos";
            this.dsUse.L3DataAdapter = this.Adapter;
            this.dsUse.LoadEvent = "Click";
            this.dsUse.LoadTrigger = null;
            this.dsUse.RefreshValve = 1000;
            this.dsUse.SourceCommand = this.cmdUse;
            this.dsUse.SourceCondition = "1=2";
            this.dsUse.SourceMethod = "";
            this.dsUse.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUse.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Use";
            this.dsUse.SubscribeTarget = null;
            this.dsUse.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsUse.UpdateEvent = "Click";
            this.dsUse.UpdateMethod = "UpdateLadleUseInfos";
            this.dsUse.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdUse
            // 
            this.cmdUse.Adapter = null;
            this.cmdUse.MergeReturnTarget = false;
            this.cmdUse.Method = null;
            this.cmdUse.Object = null;
            this.cmdUse.Parameters.Add(this.l3CommandParameter1);
            this.cmdUse.ReturnTarget = null;
            this.cmdUse.ReturnTargetProperty = null;
            this.cmdUse.Trigger = null;
            this.cmdUse.TriggerEvent = "Click";
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
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableNAME,
            this.coldsMainL3DataTableINPUT_TIME,
            this.coldsMainL3DataTableLADLEID,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableOPERATOR,
            this.coldsMainL3DataTableNOTE,
            this.coldsUseL3DataTableUSE_DATE,
            this.coldsUseL3DataTableLADLE_AGE,
            this.coldsUseL3DataTableSTEEL_GRADE,
            this.coldsUseL3DataTableSEAT_OK_TIME,
            this.coldsUseL3DataTableTAP_TIME,
            this.coldsUseL3DataTableOFF_LADLE_TIME,
            this.coldsUseL3DataTableARRIVE_TIME,
            this.coldsUseL3DataTableCOMPLETE_TIME,
            this.coldsUseL3DataTableFIRE_TIME_LEN,
            this.coldsUseL3DataTableSTOP_TIME_LEN,
            this.coldsUseL3DataTableLADLE_CHECK,
            this.coldsUseL3DataTableOFF_REASON,
            this.coldsUseL3DataTableSK_BOARD_KEEP,
            this.coldsUseL3DataTableLADLE_GRADE,
            this.coldsUseL3DataTableBOFID,
            this.coldsUseL3DataTableHeatID,
            this.coldsUseL3DataTableHot_Time,
            this.coldsUseL3DataTableFrame,
            this.coldsUseL3DataTableSplint,
            this.coldsUseL3DataTableSpringBox,
            this.coldsUseL3DataTableJoint,
            this.coldsUseL3DataTableJoint_Safety_Pin,
            this.coldsUseL3DataTableLong_Axes,
            this.coldsUseL3DataTableShort_Axes,
            this.coldsUseL3DataTableChassis,
            this.coldsUseL3DataTableProtect_Board,
            this.coldsUseL3DataTableUp_Tighten_Machine,
            this.coldsUseL3DataTableBreathe_Bri_Up,
            this.coldsUseL3DataTableBreathe_Bri_Low,
            this.coldsUseL3DataTableWater_Gap,
            this.coldsUseL3DataTableWorkID,
            this.coldsUseL3DataTableIrr_Start_Time,
            this.coldsUseL3DataTableIrr_End_Time,
            this.coldsUseL3DataTableRemnantWT,
            this.coldsUseL3DataTableComFlag,
            this.coldsUseL3DataTableConfirm_Flag,
            this.coldsUseL3DataTableAct_Ladle_Grade,
            this.AcoldsUseL3DataTableNewLadleFirst,
            this.coldsUseL3DataTableNewLadleSecond,
            this.coldsUseL3DataTableFireLadleFirst,
            this.coldsUseL3DataTableFireLadleSecond,
            this.coldsUseL3DataTableReturnLadle,
            this.coldsUseL3DataTableHookEdgeLadle,
            this.coldsUseL3DataTableRemnantLadle,
            this.coldsUseL3DataTableLadle_Check1,
            this.coldsUseL3DataTableWall_Temp});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableNAME
            // 
            this.coldsMainL3DataTableNAME.Caption = "Name";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableINPUT_TIME
            // 
            this.coldsMainL3DataTableINPUT_TIME.Caption = "Input_Time";
            this.coldsMainL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableLADLEID
            // 
            this.coldsMainL3DataTableLADLEID.Caption = "LadleID";
            this.coldsMainL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsMainL3DataTableLADLEID.Namespace = "";
            // 
            // coldsMainL3DataTableTEAMID
            // 
            this.coldsMainL3DataTableTEAMID.Caption = "TeamID";
            this.coldsMainL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsMainL3DataTableTEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableSHIFTID
            // 
            this.coldsMainL3DataTableSHIFTID.Caption = "ShiftID";
            this.coldsMainL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableOPERATOR
            // 
            this.coldsMainL3DataTableOPERATOR.Caption = "Operator";
            this.coldsMainL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "Note";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // coldsUseL3DataTableUSE_DATE
            // 
            this.coldsUseL3DataTableUSE_DATE.Caption = "Use_Date";
            this.coldsUseL3DataTableUSE_DATE.ColumnName = "USE_DATE";
            this.coldsUseL3DataTableUSE_DATE.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableUSE_DATE.Namespace = "";
            // 
            // coldsUseL3DataTableLADLE_AGE
            // 
            this.coldsUseL3DataTableLADLE_AGE.Caption = "Ladle_Age";
            this.coldsUseL3DataTableLADLE_AGE.ColumnName = "LADLE_AGE";
            this.coldsUseL3DataTableLADLE_AGE.DataType = typeof(int);
            this.coldsUseL3DataTableLADLE_AGE.Namespace = "";
            // 
            // coldsUseL3DataTableSTEEL_GRADE
            // 
            this.coldsUseL3DataTableSTEEL_GRADE.Caption = "Steel_Grade";
            this.coldsUseL3DataTableSTEEL_GRADE.ColumnName = "STEEL_GRADE";
            this.coldsUseL3DataTableSTEEL_GRADE.Namespace = "";
            // 
            // coldsUseL3DataTableSEAT_OK_TIME
            // 
            this.coldsUseL3DataTableSEAT_OK_TIME.Caption = "Seat_OK_Time";
            this.coldsUseL3DataTableSEAT_OK_TIME.ColumnName = "SEAT_OK_TIME";
            this.coldsUseL3DataTableSEAT_OK_TIME.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableSEAT_OK_TIME.Namespace = "";
            // 
            // coldsUseL3DataTableTAP_TIME
            // 
            this.coldsUseL3DataTableTAP_TIME.Caption = "Tap_Time";
            this.coldsUseL3DataTableTAP_TIME.ColumnName = "TAP_TIME";
            this.coldsUseL3DataTableTAP_TIME.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableTAP_TIME.Namespace = "";
            // 
            // coldsUseL3DataTableOFF_LADLE_TIME
            // 
            this.coldsUseL3DataTableOFF_LADLE_TIME.Caption = "Off_Ladle_Time";
            this.coldsUseL3DataTableOFF_LADLE_TIME.ColumnName = "OFF_LADLE_TIME";
            this.coldsUseL3DataTableOFF_LADLE_TIME.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableOFF_LADLE_TIME.Namespace = "";
            // 
            // coldsUseL3DataTableARRIVE_TIME
            // 
            this.coldsUseL3DataTableARRIVE_TIME.Caption = "Arrive_Time";
            this.coldsUseL3DataTableARRIVE_TIME.ColumnName = "ARRIVE_TIME";
            this.coldsUseL3DataTableARRIVE_TIME.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableARRIVE_TIME.Namespace = "";
            // 
            // coldsUseL3DataTableCOMPLETE_TIME
            // 
            this.coldsUseL3DataTableCOMPLETE_TIME.Caption = "Complete_Time";
            this.coldsUseL3DataTableCOMPLETE_TIME.ColumnName = "COMPLETE_TIME";
            this.coldsUseL3DataTableCOMPLETE_TIME.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableCOMPLETE_TIME.Namespace = "";
            // 
            // coldsUseL3DataTableFIRE_TIME_LEN
            // 
            this.coldsUseL3DataTableFIRE_TIME_LEN.Caption = "Fire_Time_Len";
            this.coldsUseL3DataTableFIRE_TIME_LEN.ColumnName = "FIRE_TIME_LEN";
            this.coldsUseL3DataTableFIRE_TIME_LEN.DataType = typeof(double);
            this.coldsUseL3DataTableFIRE_TIME_LEN.Namespace = "";
            // 
            // coldsUseL3DataTableSTOP_TIME_LEN
            // 
            this.coldsUseL3DataTableSTOP_TIME_LEN.Caption = "Stop_Time_Len";
            this.coldsUseL3DataTableSTOP_TIME_LEN.ColumnName = "STOP_TIME_LEN";
            this.coldsUseL3DataTableSTOP_TIME_LEN.DataType = typeof(double);
            this.coldsUseL3DataTableSTOP_TIME_LEN.Namespace = "";
            // 
            // coldsUseL3DataTableLADLE_CHECK
            // 
            this.coldsUseL3DataTableLADLE_CHECK.Caption = "Ladle_Check";
            this.coldsUseL3DataTableLADLE_CHECK.ColumnName = "LADLE_CHECK";
            this.coldsUseL3DataTableLADLE_CHECK.Namespace = "";
            // 
            // coldsUseL3DataTableOFF_REASON
            // 
            this.coldsUseL3DataTableOFF_REASON.Caption = "Off_Reason";
            this.coldsUseL3DataTableOFF_REASON.ColumnName = "OFF_REASON";
            this.coldsUseL3DataTableOFF_REASON.Namespace = "";
            // 
            // coldsUseL3DataTableSK_BOARD_KEEP
            // 
            this.coldsUseL3DataTableSK_BOARD_KEEP.Caption = "Sk_Board_Keep";
            this.coldsUseL3DataTableSK_BOARD_KEEP.ColumnName = "SK_BOARD_KEEP";
            this.coldsUseL3DataTableSK_BOARD_KEEP.Namespace = "";
            // 
            // coldsUseL3DataTableLADLE_GRADE
            // 
            this.coldsUseL3DataTableLADLE_GRADE.Caption = "Ladle_Grade";
            this.coldsUseL3DataTableLADLE_GRADE.ColumnName = "LADLE_GRADE";
            this.coldsUseL3DataTableLADLE_GRADE.Namespace = "";
            // 
            // coldsUseL3DataTableBOFID
            // 
            this.coldsUseL3DataTableBOFID.Caption = "BOFID";
            this.coldsUseL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsUseL3DataTableBOFID.Namespace = "";
            // 
            // coldsUseL3DataTableHeatID
            // 
            this.coldsUseL3DataTableHeatID.Caption = "HeatID";
            this.coldsUseL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsUseL3DataTableHeatID.Namespace = "";
            // 
            // coldsUseL3DataTableHot_Time
            // 
            this.coldsUseL3DataTableHot_Time.Caption = "Hot_Time";
            this.coldsUseL3DataTableHot_Time.ColumnName = "Hot_Time";
            this.coldsUseL3DataTableHot_Time.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableHot_Time.Namespace = "";
            // 
            // coldsUseL3DataTableFrame
            // 
            this.coldsUseL3DataTableFrame.Caption = "Frame";
            this.coldsUseL3DataTableFrame.ColumnName = "Frame";
            this.coldsUseL3DataTableFrame.DataType = typeof(int);
            this.coldsUseL3DataTableFrame.Namespace = "";
            // 
            // coldsUseL3DataTableSplint
            // 
            this.coldsUseL3DataTableSplint.Caption = "Splint";
            this.coldsUseL3DataTableSplint.ColumnName = "Splint";
            this.coldsUseL3DataTableSplint.DataType = typeof(int);
            this.coldsUseL3DataTableSplint.Namespace = "";
            // 
            // coldsUseL3DataTableSpringBox
            // 
            this.coldsUseL3DataTableSpringBox.Caption = "SpringBox";
            this.coldsUseL3DataTableSpringBox.ColumnName = "SpringBox";
            this.coldsUseL3DataTableSpringBox.DataType = typeof(int);
            this.coldsUseL3DataTableSpringBox.Namespace = "";
            // 
            // coldsUseL3DataTableJoint
            // 
            this.coldsUseL3DataTableJoint.Caption = "Joint";
            this.coldsUseL3DataTableJoint.ColumnName = "Joint";
            this.coldsUseL3DataTableJoint.DataType = typeof(int);
            this.coldsUseL3DataTableJoint.Namespace = "";
            // 
            // coldsUseL3DataTableJoint_Safety_Pin
            // 
            this.coldsUseL3DataTableJoint_Safety_Pin.Caption = "Joint_Safety_Pin";
            this.coldsUseL3DataTableJoint_Safety_Pin.ColumnName = "Joint_Safety_Pin";
            this.coldsUseL3DataTableJoint_Safety_Pin.DataType = typeof(int);
            this.coldsUseL3DataTableJoint_Safety_Pin.Namespace = "";
            // 
            // coldsUseL3DataTableLong_Axes
            // 
            this.coldsUseL3DataTableLong_Axes.Caption = "Long_Axes";
            this.coldsUseL3DataTableLong_Axes.ColumnName = "Long_Axes";
            this.coldsUseL3DataTableLong_Axes.DataType = typeof(int);
            this.coldsUseL3DataTableLong_Axes.Namespace = "";
            // 
            // coldsUseL3DataTableShort_Axes
            // 
            this.coldsUseL3DataTableShort_Axes.Caption = "Short_Axes";
            this.coldsUseL3DataTableShort_Axes.ColumnName = "Short_Axes";
            this.coldsUseL3DataTableShort_Axes.DataType = typeof(int);
            this.coldsUseL3DataTableShort_Axes.Namespace = "";
            // 
            // coldsUseL3DataTableChassis
            // 
            this.coldsUseL3DataTableChassis.Caption = "Chassis";
            this.coldsUseL3DataTableChassis.ColumnName = "Chassis";
            this.coldsUseL3DataTableChassis.DataType = typeof(int);
            this.coldsUseL3DataTableChassis.Namespace = "";
            // 
            // coldsUseL3DataTableProtect_Board
            // 
            this.coldsUseL3DataTableProtect_Board.Caption = "Protect_Board";
            this.coldsUseL3DataTableProtect_Board.ColumnName = "Protect_Board";
            this.coldsUseL3DataTableProtect_Board.DataType = typeof(int);
            this.coldsUseL3DataTableProtect_Board.Namespace = "";
            // 
            // coldsUseL3DataTableUp_Tighten_Machine
            // 
            this.coldsUseL3DataTableUp_Tighten_Machine.Caption = "Up_Tighten_Machine";
            this.coldsUseL3DataTableUp_Tighten_Machine.ColumnName = "Up_Tighten_Machine";
            this.coldsUseL3DataTableUp_Tighten_Machine.DataType = typeof(int);
            this.coldsUseL3DataTableUp_Tighten_Machine.Namespace = "";
            // 
            // coldsUseL3DataTableBreathe_Bri_Up
            // 
            this.coldsUseL3DataTableBreathe_Bri_Up.Caption = "Breathe_Bri_Up";
            this.coldsUseL3DataTableBreathe_Bri_Up.ColumnName = "Breathe_Bri_Up";
            this.coldsUseL3DataTableBreathe_Bri_Up.DataType = typeof(int);
            this.coldsUseL3DataTableBreathe_Bri_Up.Namespace = "";
            // 
            // coldsUseL3DataTableBreathe_Bri_Low
            // 
            this.coldsUseL3DataTableBreathe_Bri_Low.Caption = "Breathe_Bri_Low";
            this.coldsUseL3DataTableBreathe_Bri_Low.ColumnName = "Breathe_Bri_Low";
            this.coldsUseL3DataTableBreathe_Bri_Low.DataType = typeof(int);
            this.coldsUseL3DataTableBreathe_Bri_Low.Namespace = "";
            // 
            // coldsUseL3DataTableWater_Gap
            // 
            this.coldsUseL3DataTableWater_Gap.Caption = "Water_Gap";
            this.coldsUseL3DataTableWater_Gap.ColumnName = "Water_Gap";
            this.coldsUseL3DataTableWater_Gap.DataType = typeof(int);
            this.coldsUseL3DataTableWater_Gap.Namespace = "";
            // 
            // coldsUseL3DataTableWorkID
            // 
            this.coldsUseL3DataTableWorkID.Caption = "WorkID";
            this.coldsUseL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsUseL3DataTableWorkID.Namespace = "";
            // 
            // coldsUseL3DataTableIrr_Start_Time
            // 
            this.coldsUseL3DataTableIrr_Start_Time.Caption = "Irr_Start_Time";
            this.coldsUseL3DataTableIrr_Start_Time.ColumnName = "Irr_Start_Time";
            this.coldsUseL3DataTableIrr_Start_Time.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableIrr_Start_Time.Namespace = "";
            // 
            // coldsUseL3DataTableIrr_End_Time
            // 
            this.coldsUseL3DataTableIrr_End_Time.Caption = "Irr_End_Time";
            this.coldsUseL3DataTableIrr_End_Time.ColumnName = "Irr_End_Time";
            this.coldsUseL3DataTableIrr_End_Time.DataType = typeof(System.DateTime);
            this.coldsUseL3DataTableIrr_End_Time.Namespace = "";
            // 
            // coldsUseL3DataTableRemnantWT
            // 
            this.coldsUseL3DataTableRemnantWT.Caption = "RemnantWT";
            this.coldsUseL3DataTableRemnantWT.ColumnName = "RemnantWT";
            this.coldsUseL3DataTableRemnantWT.DataType = typeof(double);
            this.coldsUseL3DataTableRemnantWT.Namespace = "";
            // 
            // coldsUseL3DataTableComFlag
            // 
            this.coldsUseL3DataTableComFlag.Caption = "ComFlag";
            this.coldsUseL3DataTableComFlag.ColumnName = "ComFlag";
            this.coldsUseL3DataTableComFlag.DataType = typeof(int);
            this.coldsUseL3DataTableComFlag.Namespace = "";
            // 
            // coldsUseL3DataTableConfirm_Flag
            // 
            this.coldsUseL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsUseL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsUseL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsUseL3DataTableConfirm_Flag.Namespace = "";
            // 
            // coldsUseL3DataTableAct_Ladle_Grade
            // 
            this.coldsUseL3DataTableAct_Ladle_Grade.Caption = "Act_Ladle_Grade";
            this.coldsUseL3DataTableAct_Ladle_Grade.ColumnName = "Act_Ladle_Grade";
            this.coldsUseL3DataTableAct_Ladle_Grade.Namespace = "";
            // 
            // AcoldsUseL3DataTableNewLadleFirst
            // 
            this.AcoldsUseL3DataTableNewLadleFirst.Caption = "NewLadleFirst";
            this.AcoldsUseL3DataTableNewLadleFirst.ColumnName = "NewLadleFirst";
            this.AcoldsUseL3DataTableNewLadleFirst.DataType = typeof(int);
            this.AcoldsUseL3DataTableNewLadleFirst.Namespace = "";
            // 
            // coldsUseL3DataTableNewLadleSecond
            // 
            this.coldsUseL3DataTableNewLadleSecond.Caption = "NewLadleSecond";
            this.coldsUseL3DataTableNewLadleSecond.ColumnName = "NewLadleSecond";
            this.coldsUseL3DataTableNewLadleSecond.DataType = typeof(int);
            this.coldsUseL3DataTableNewLadleSecond.Namespace = "";
            // 
            // coldsUseL3DataTableFireLadleFirst
            // 
            this.coldsUseL3DataTableFireLadleFirst.Caption = "FireLadleFirst";
            this.coldsUseL3DataTableFireLadleFirst.ColumnName = "FireLadleFirst";
            this.coldsUseL3DataTableFireLadleFirst.DataType = typeof(int);
            this.coldsUseL3DataTableFireLadleFirst.Namespace = "";
            // 
            // coldsUseL3DataTableFireLadleSecond
            // 
            this.coldsUseL3DataTableFireLadleSecond.Caption = "FireLadleSecond";
            this.coldsUseL3DataTableFireLadleSecond.ColumnName = "FireLadleSecond";
            this.coldsUseL3DataTableFireLadleSecond.DataType = typeof(int);
            this.coldsUseL3DataTableFireLadleSecond.Namespace = "";
            // 
            // coldsUseL3DataTableReturnLadle
            // 
            this.coldsUseL3DataTableReturnLadle.Caption = "ReturnLadle";
            this.coldsUseL3DataTableReturnLadle.ColumnName = "ReturnLadle";
            this.coldsUseL3DataTableReturnLadle.DataType = typeof(int);
            this.coldsUseL3DataTableReturnLadle.Namespace = "";
            // 
            // coldsUseL3DataTableHookEdgeLadle
            // 
            this.coldsUseL3DataTableHookEdgeLadle.Caption = "HookEdgeLadle";
            this.coldsUseL3DataTableHookEdgeLadle.ColumnName = "HookEdgeLadle";
            this.coldsUseL3DataTableHookEdgeLadle.DataType = typeof(int);
            this.coldsUseL3DataTableHookEdgeLadle.Namespace = "";
            // 
            // coldsUseL3DataTableRemnantLadle
            // 
            this.coldsUseL3DataTableRemnantLadle.Caption = "RemnantLadle";
            this.coldsUseL3DataTableRemnantLadle.ColumnName = "RemnantLadle";
            this.coldsUseL3DataTableRemnantLadle.DataType = typeof(int);
            this.coldsUseL3DataTableRemnantLadle.Namespace = "";
            // 
            // coldsUseL3DataTableLadle_Check1
            // 
            this.coldsUseL3DataTableLadle_Check1.Caption = "Ladle_Check1";
            this.coldsUseL3DataTableLadle_Check1.ColumnName = "Ladle_Check1";
            this.coldsUseL3DataTableLadle_Check1.Namespace = "";
            // 
            // coldsUseL3DataTableWall_Temp
            // 
            this.coldsUseL3DataTableWall_Temp.Caption = "Wall_Temp";
            this.coldsUseL3DataTableWall_Temp.ColumnName = "Wall_Temp";
            this.coldsUseL3DataTableWall_Temp.DataType = typeof(int);
            this.coldsUseL3DataTableWall_Temp.Namespace = "";
            // 
            // coldsUseL3DataTableNewLadleFirst
            // 
            this.coldsUseL3DataTableNewLadleFirst.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsUseL3DataTableNewLadleFirst.ColumnName = "NewLadleFirst";
            this.coldsUseL3DataTableNewLadleFirst.DataType = typeof(int);
            this.coldsUseL3DataTableNewLadleFirst.DefaultValue = 0;
            this.coldsUseL3DataTableNewLadleFirst.Namespace = "";
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
            this.dsShiftID.SourceCondition = null;
            this.dsShiftID.SourceMethod = null;
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsShiftID.SourceURI = null;
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
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
            this.dsTeamID.SourceCondition = null;
            this.dsTeamID.SourceMethod = null;
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsTeamID.SourceURI = null;
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
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
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1143, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsUse;
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
            this.toolStripLabel5,
            this.cmbWorkID,
            this.toolStripLabel2,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel3,
            this.btnDataConfirm,
            this.toolStripSeparator1,
            this.btnGBXXQuery});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1143, 25);
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
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
            // 
            // cmbWorkID
            // 
            this.cmbWorkID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbWorkID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWorkID.Name = "cmbWorkID";
            this.cmbWorkID.Size = new System.Drawing.Size(121, 25);
            this.cmbWorkID.DropDownClosed += new System.EventHandler(this.cmbLadleID_DropDownClosed);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel2.Text = "工 序:";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGBXXQuery
            // 
            this.btnGBXXQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnGBXXQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnGBXXQuery.Image")));
            this.btnGBXXQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGBXXQuery.Name = "btnGBXXQuery";
            this.btnGBXXQuery.Size = new System.Drawing.Size(97, 22);
            this.btnGBXXQuery.Text = "下线钢包查询";
            this.btnGBXXQuery.Click += new System.EventHandler(this.btnGBXXQuery_Click);
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnConfirm,
            this.toolStripSeparator3,
            this.btnOutPut,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripTextBox4});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1143, 43);
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
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.Red;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(20, 43);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 43);
            this.toolStripTextBox2.Text = "一级报警";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(20, 43);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 43);
            this.toolStripTextBox4.Text = "二级报警";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.checkBox1);
            this.hmiRootPanel1.Controls.Add(this.dvUse);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1143, 632);
            this.hmiRootPanel1.TabIndex = 28;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(315, -21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dvUse
            // 
            this.dvUse.AllowUserToAddRows = false;
            this.dvUse.AutoGenerateColumns = false;
            this.dvUse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvUse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDataGridViewTextBoxColumn,
            this.hEATIDDataGridViewTextBoxColumn,
            this.steelgradeDataGridViewTextBoxColumn,
            this.workidDataGridViewTextBoxColumn,
            this.alarmcontentDataGridViewTextBoxColumn,
            this.alarmnameDataGridViewTextBoxColumn,
            this.tundishnumDataGridViewTextBoxColumn,
            this.realyvalueDataGridViewTextBoxColumn,
            this.lowvalueDataGridViewTextBoxColumn,
            this.upvalueDataGridViewTextBoxColumn,
            this.alarmtimeDataGridViewTextBoxColumn,
            this.alarmlevelDataGridViewTextBoxColumn});
            this.dvUse.DataSource = this.bsAlarmMessage;
            this.dvUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvUse.Location = new System.Drawing.Point(0, 0);
            this.dvUse.Margin = new System.Windows.Forms.Padding(0);
            this.dvUse.Name = "dvUse";
            this.dvUse.ReadOnly = true;
            this.dvUse.RowTemplate.Height = 23;
            this.dvUse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvUse.Size = new System.Drawing.Size(1143, 632);
            this.dvUse.TabIndex = 31;
            this.dvUse.Sorted += new System.EventHandler(this.dvUse_Sorted);
            this.dvUse.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dvUse_CellPainting);
            this.dvUse.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            this.dvUse.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvUse_DataError);
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "班组";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // steelgradeDataGridViewTextBoxColumn
            // 
            this.steelgradeDataGridViewTextBoxColumn.DataPropertyName = "steelgrade";
            this.steelgradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelgradeDataGridViewTextBoxColumn.Name = "steelgradeDataGridViewTextBoxColumn";
            this.steelgradeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workidDataGridViewTextBoxColumn
            // 
            this.workidDataGridViewTextBoxColumn.DataPropertyName = "workid";
            this.workidDataGridViewTextBoxColumn.HeaderText = "工序";
            this.workidDataGridViewTextBoxColumn.Name = "workidDataGridViewTextBoxColumn";
            this.workidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmcontentDataGridViewTextBoxColumn
            // 
            this.alarmcontentDataGridViewTextBoxColumn.DataPropertyName = "alarm_content";
            this.alarmcontentDataGridViewTextBoxColumn.HeaderText = "报警内容";
            this.alarmcontentDataGridViewTextBoxColumn.Name = "alarmcontentDataGridViewTextBoxColumn";
            this.alarmcontentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmnameDataGridViewTextBoxColumn
            // 
            this.alarmnameDataGridViewTextBoxColumn.DataPropertyName = "alarm_name";
            this.alarmnameDataGridViewTextBoxColumn.HeaderText = "指标名称";
            this.alarmnameDataGridViewTextBoxColumn.Name = "alarmnameDataGridViewTextBoxColumn";
            this.alarmnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tundishnumDataGridViewTextBoxColumn
            // 
            this.tundishnumDataGridViewTextBoxColumn.DataPropertyName = "tundish_num";
            this.tundishnumDataGridViewTextBoxColumn.HeaderText = "包次号";
            this.tundishnumDataGridViewTextBoxColumn.Name = "tundishnumDataGridViewTextBoxColumn";
            this.tundishnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realyvalueDataGridViewTextBoxColumn
            // 
            this.realyvalueDataGridViewTextBoxColumn.DataPropertyName = "realy_value";
            this.realyvalueDataGridViewTextBoxColumn.HeaderText = "实际值";
            this.realyvalueDataGridViewTextBoxColumn.Name = "realyvalueDataGridViewTextBoxColumn";
            this.realyvalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lowvalueDataGridViewTextBoxColumn
            // 
            this.lowvalueDataGridViewTextBoxColumn.DataPropertyName = "low_value";
            this.lowvalueDataGridViewTextBoxColumn.HeaderText = "下限";
            this.lowvalueDataGridViewTextBoxColumn.Name = "lowvalueDataGridViewTextBoxColumn";
            this.lowvalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // upvalueDataGridViewTextBoxColumn
            // 
            this.upvalueDataGridViewTextBoxColumn.DataPropertyName = "up_value";
            this.upvalueDataGridViewTextBoxColumn.HeaderText = "上限";
            this.upvalueDataGridViewTextBoxColumn.Name = "upvalueDataGridViewTextBoxColumn";
            this.upvalueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmtimeDataGridViewTextBoxColumn
            // 
            this.alarmtimeDataGridViewTextBoxColumn.DataPropertyName = "alarm_time";
            this.alarmtimeDataGridViewTextBoxColumn.HeaderText = "报警时间";
            this.alarmtimeDataGridViewTextBoxColumn.Name = "alarmtimeDataGridViewTextBoxColumn";
            this.alarmtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alarmlevelDataGridViewTextBoxColumn
            // 
            this.alarmlevelDataGridViewTextBoxColumn.DataPropertyName = "alarm_level";
            this.alarmlevelDataGridViewTextBoxColumn.HeaderText = "报警等级";
            this.alarmlevelDataGridViewTextBoxColumn.Name = "alarmlevelDataGridViewTextBoxColumn";
            this.alarmlevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsAlarmMessage
            // 
            this.bsAlarmMessage.DataMember = "L3DataTable";
            this.bsAlarmMessage.DataSource = this.dsAlarmMessage;
            // 
            // dsAlarmMessage
            // 
            this.dsAlarmMessage.AutoLoad = true;
            this.dsAlarmMessage.AutoSubscribe = false;
            this.dsAlarmMessage.DataSetName = "L3DataSet";
            this.dsAlarmMessage.DeleteMethod = null;
            this.dsAlarmMessage.InsertMethod = null;
            this.dsAlarmMessage.L3DataAdapter = this.Adapter;
            this.dsAlarmMessage.LoadEvent = "Click";
            this.dsAlarmMessage.LoadTrigger = null;
            this.dsAlarmMessage.RefreshValve = 1000;
            this.dsAlarmMessage.SourceCommand = null;
            this.dsAlarmMessage.SourceCondition = "";
            this.dsAlarmMessage.SourceMethod = "";
            this.dsAlarmMessage.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsAlarmMessage.SourceURI = "";
            this.dsAlarmMessage.SubscribeTarget = null;
            this.dsAlarmMessage.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlarmMessage});
            this.dsAlarmMessage.UpdateEvent = "Click";
            this.dsAlarmMessage.UpdateMethod = null;
            this.dsAlarmMessage.UpdateTrigger = null;
            // 
            // schemadsAlarmMessage
            // 
            this.schemadsAlarmMessage.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlarmMessageL3DataTableteam,
            this.coldsAlarmMessageL3DataTableHEATID,
            this.coldsAlarmMessageL3DataTablesteelgrade,
            this.coldsAlarmMessageL3DataTableworkid,
            this.coldsAlarmMessageL3DataTablealarm_content,
            this.coldsAlarmMessageL3DataTablealarm_name,
            this.coldsAlarmMessageL3DataTabletundish_num,
            this.coldsAlarmMessageL3DataTablerealy_value,
            this.coldsAlarmMessageL3DataTablelow_value,
            this.coldsAlarmMessageL3DataTableup_value,
            this.coldsAlarmMessageL3DataTablealarm_time,
            this.coldsAlarmMessageL3DataTablealarm_level});
            this.schemadsAlarmMessage.TableName = "L3DataTable";
            // 
            // coldsAlarmMessageL3DataTableteam
            // 
            this.coldsAlarmMessageL3DataTableteam.Caption = "team";
            this.coldsAlarmMessageL3DataTableteam.ColumnName = "team";
            this.coldsAlarmMessageL3DataTableteam.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTableHEATID
            // 
            this.coldsAlarmMessageL3DataTableHEATID.Caption = "HEATID";
            this.coldsAlarmMessageL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsAlarmMessageL3DataTableHEATID.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTablesteelgrade
            // 
            this.coldsAlarmMessageL3DataTablesteelgrade.Caption = "steelgrade";
            this.coldsAlarmMessageL3DataTablesteelgrade.ColumnName = "steelgrade";
            this.coldsAlarmMessageL3DataTablesteelgrade.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTableworkid
            // 
            this.coldsAlarmMessageL3DataTableworkid.Caption = "workid";
            this.coldsAlarmMessageL3DataTableworkid.ColumnName = "workid";
            this.coldsAlarmMessageL3DataTableworkid.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTablealarm_content
            // 
            this.coldsAlarmMessageL3DataTablealarm_content.Caption = "alarm_content";
            this.coldsAlarmMessageL3DataTablealarm_content.ColumnName = "alarm_content";
            this.coldsAlarmMessageL3DataTablealarm_content.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTablealarm_name
            // 
            this.coldsAlarmMessageL3DataTablealarm_name.Caption = "alarm_name";
            this.coldsAlarmMessageL3DataTablealarm_name.ColumnName = "alarm_name";
            this.coldsAlarmMessageL3DataTablealarm_name.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTabletundish_num
            // 
            this.coldsAlarmMessageL3DataTabletundish_num.Caption = "tundish_num";
            this.coldsAlarmMessageL3DataTabletundish_num.ColumnName = "tundish_num";
            this.coldsAlarmMessageL3DataTabletundish_num.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTablerealy_value
            // 
            this.coldsAlarmMessageL3DataTablerealy_value.Caption = "realy_value";
            this.coldsAlarmMessageL3DataTablerealy_value.ColumnName = "realy_value";
            this.coldsAlarmMessageL3DataTablerealy_value.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTablelow_value
            // 
            this.coldsAlarmMessageL3DataTablelow_value.Caption = "low_value";
            this.coldsAlarmMessageL3DataTablelow_value.ColumnName = "low_value";
            this.coldsAlarmMessageL3DataTablelow_value.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTableup_value
            // 
            this.coldsAlarmMessageL3DataTableup_value.Caption = "up_value";
            this.coldsAlarmMessageL3DataTableup_value.ColumnName = "up_value";
            this.coldsAlarmMessageL3DataTableup_value.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTablealarm_time
            // 
            this.coldsAlarmMessageL3DataTablealarm_time.Caption = "alarm_time";
            this.coldsAlarmMessageL3DataTablealarm_time.ColumnName = "alarm_time";
            this.coldsAlarmMessageL3DataTablealarm_time.Namespace = "";
            // 
            // coldsAlarmMessageL3DataTablealarm_level
            // 
            this.coldsAlarmMessageL3DataTablealarm_level.Caption = "alarm_level";
            this.coldsAlarmMessageL3DataTablealarm_level.ColumnName = "alarm_level";
            this.coldsAlarmMessageL3DataTablealarm_level.Namespace = "";
            // 
            // dsLadleChcke
            // 
            this.dsLadleChcke.AutoLoad = true;
            this.dsLadleChcke.AutoSubscribe = false;
            this.dsLadleChcke.DataSetName = "L3DataSet";
            this.dsLadleChcke.DeleteMethod = null;
            this.dsLadleChcke.InsertMethod = null;
            this.dsLadleChcke.L3DataAdapter = this.Adapter;
            this.dsLadleChcke.LoadEvent = "Click";
            this.dsLadleChcke.LoadTrigger = null;
            this.dsLadleChcke.RefreshValve = 1000;
            this.dsLadleChcke.SourceCommand = null;
            this.dsLadleChcke.SourceCondition = "Code_Group = \'LadleChcke\' order by Code";
            this.dsLadleChcke.SourceMethod = "";
            this.dsLadleChcke.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleChcke.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleChcke.SubscribeTarget = null;
            this.dsLadleChcke.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleChcke});
            this.dsLadleChcke.UpdateEvent = "Click";
            this.dsLadleChcke.UpdateMethod = null;
            this.dsLadleChcke.UpdateTrigger = null;
            // 
            // schemadsLadleChcke
            // 
            this.schemadsLadleChcke.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleChckeL3DataTableCode,
            this.coldsLadleChckeL3DataTableCode_Des});
            this.schemadsLadleChcke.TableName = "L3DataTable";
            // 
            // coldsLadleChckeL3DataTableCode
            // 
            this.coldsLadleChckeL3DataTableCode.Caption = "Code";
            this.coldsLadleChckeL3DataTableCode.ColumnName = "Code";
            this.coldsLadleChckeL3DataTableCode.Namespace = "";
            // 
            // coldsLadleChckeL3DataTableCode_Des
            // 
            this.coldsLadleChckeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleChckeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleChckeL3DataTableCode_Des.Namespace = "";
            // 
            // dsLadleChcke1
            // 
            this.dsLadleChcke1.AutoLoad = true;
            this.dsLadleChcke1.AutoSubscribe = false;
            this.dsLadleChcke1.DataSetName = "L3DataSet";
            this.dsLadleChcke1.DeleteMethod = null;
            this.dsLadleChcke1.InsertMethod = null;
            this.dsLadleChcke1.L3DataAdapter = this.Adapter;
            this.dsLadleChcke1.LoadEvent = "Click";
            this.dsLadleChcke1.LoadTrigger = null;
            this.dsLadleChcke1.RefreshValve = 1000;
            this.dsLadleChcke1.SourceCommand = null;
            this.dsLadleChcke1.SourceCondition = "Code_Group = \'LadleChcke1\' order by Code";
            this.dsLadleChcke1.SourceMethod = "";
            this.dsLadleChcke1.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleChcke1.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleChcke1.SubscribeTarget = null;
            this.dsLadleChcke1.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleChcke1});
            this.dsLadleChcke1.UpdateEvent = "Click";
            this.dsLadleChcke1.UpdateMethod = null;
            this.dsLadleChcke1.UpdateTrigger = null;
            // 
            // schemadsLadleChcke1
            // 
            this.schemadsLadleChcke1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleChcke1L3DataTableCode,
            this.coldsLadleChcke1L3DataTableCode_Des});
            this.schemadsLadleChcke1.TableName = "L3DataTable";
            // 
            // coldsLadleChcke1L3DataTableCode
            // 
            this.coldsLadleChcke1L3DataTableCode.Caption = "Code";
            this.coldsLadleChcke1L3DataTableCode.ColumnName = "Code";
            this.coldsLadleChcke1L3DataTableCode.Namespace = "";
            // 
            // coldsLadleChcke1L3DataTableCode_Des
            // 
            this.coldsLadleChcke1L3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleChcke1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleChcke1L3DataTableCode_Des.Namespace = "";
            // 
            // dsLadleThrow
            // 
            this.dsLadleThrow.AutoLoad = true;
            this.dsLadleThrow.AutoSubscribe = false;
            this.dsLadleThrow.DataSetName = "L3DataSet";
            this.dsLadleThrow.DeleteMethod = null;
            this.dsLadleThrow.InsertMethod = null;
            this.dsLadleThrow.L3DataAdapter = this.Adapter;
            this.dsLadleThrow.LoadEvent = "Click";
            this.dsLadleThrow.LoadTrigger = null;
            this.dsLadleThrow.RefreshValve = 1000;
            this.dsLadleThrow.SourceCommand = null;
            this.dsLadleThrow.SourceCondition = "Code_Group = \'ComLadleThrow\' or Code_Group = \'FinLadleThrow\'";
            this.dsLadleThrow.SourceMethod = "";
            this.dsLadleThrow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleThrow.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleThrow.SubscribeTarget = null;
            this.dsLadleThrow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleThrow});
            this.dsLadleThrow.UpdateEvent = "Click";
            this.dsLadleThrow.UpdateMethod = null;
            this.dsLadleThrow.UpdateTrigger = null;
            // 
            // schemadsLadleThrow
            // 
            this.schemadsLadleThrow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleThrowL3DataTableCode,
            this.coldsLadleThrowL3DataTableCode_Des});
            this.schemadsLadleThrow.TableName = "L3DataTable";
            // 
            // coldsLadleThrowL3DataTableCode
            // 
            this.coldsLadleThrowL3DataTableCode.Caption = "Code";
            this.coldsLadleThrowL3DataTableCode.ColumnName = "Code";
            this.coldsLadleThrowL3DataTableCode.Namespace = "";
            // 
            // coldsLadleThrowL3DataTableCode_Des
            // 
            this.coldsLadleThrowL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleThrowL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleThrowL3DataTableCode_Des.Namespace = "";
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoLoad = true;
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
            this.dsLadleID.SubscribeTarget = null;
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
            // dsUnitType
            // 
            this.dsUnitType.AutoLoad = true;
            this.dsUnitType.AutoSubscribe = false;
            this.dsUnitType.DataSetName = "L3DataSet";
            this.dsUnitType.DeleteMethod = null;
            this.dsUnitType.InsertMethod = null;
            this.dsUnitType.L3DataAdapter = this.Adapter;
            this.dsUnitType.LoadEvent = "Click";
            this.dsUnitType.LoadTrigger = null;
            this.dsUnitType.RefreshValve = 1000;
            this.dsUnitType.SourceCommand = null;
            this.dsUnitType.SourceCondition = "CODE_GROUP=\'UnitType\' AND (CODE=\'1\'OR CODE=\'2\'OR CODE=\'4\'OR CODE=\'5\'OR CODE=\'6\'OR" +
                " CODE=\'10\'OR CODE=\'11\')";
            this.dsUnitType.SourceMethod = "";
            this.dsUnitType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitType.SubscribeTarget = null;
            this.dsUnitType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitType});
            this.dsUnitType.UpdateEvent = "Click";
            this.dsUnitType.UpdateMethod = null;
            this.dsUnitType.UpdateTrigger = null;
            // 
            // schemadsUnitType
            // 
            this.schemadsUnitType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitTypeL3DataTableCode_Des});
            this.schemadsUnitType.TableName = "L3DataTable";
            // 
            // coldsUnitTypeL3DataTableCode_Des
            // 
            this.coldsUnitTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitTypeL3DataTableCode_Des.Namespace = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "team";
            this.dataGridViewTextBoxColumn1.HeaderText = "班组";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SteelGrade";
            this.dataGridViewTextBoxColumn2.HeaderText = "钢种";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tundish_num";
            this.dataGridViewTextBoxColumn4.HeaderText = "包次号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "WorkID";
            this.dataGridViewTextBoxColumn5.HeaderText = "工序";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "realy_value";
            this.dataGridViewTextBoxColumn6.HeaderText = "实际值";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "low_value";
            this.dataGridViewTextBoxColumn7.HeaderText = "下限";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "up_value";
            this.dataGridViewTextBoxColumn8.HeaderText = "上限";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "alarm_time";
            this.dataGridViewTextBoxColumn9.HeaderText = "报警时间";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "alarm_level";
            this.dataGridViewTextBoxColumn10.HeaderText = "报警等级";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Alarm_Content";
            this.dataGridViewTextBoxColumn11.HeaderText = "报警内容";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Alarm_Name";
            this.dataGridViewTextBoxColumn12.HeaderText = "指标名称";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // AlarmMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmMagFrm";
            this.TabText = "报警信息";
            this.Load += new System.EventHandler(this.AlarmMagFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmMagFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.hmiRootPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlarmMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlarmMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlarmMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsUse;
       
        private System.Windows.Forms.BindingSource bsUse;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvUse;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbWorkID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private AppSvrHMI.L3DataSet dsLadleID;
        private AppSvrHMI.L3Command cmdUse;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableLADLEID;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableOPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsUseL3DataTableUSE_DATE;
        private System.Data.DataColumn coldsUseL3DataTableLADLE_AGE;
        private System.Data.DataColumn coldsUseL3DataTableSTEEL_GRADE;
        private System.Data.DataColumn coldsUseL3DataTableSEAT_OK_TIME;
        private System.Data.DataColumn coldsUseL3DataTableTAP_TIME;
        private System.Data.DataColumn coldsUseL3DataTableOFF_LADLE_TIME;
        private System.Data.DataColumn coldsUseL3DataTableARRIVE_TIME;
        private System.Data.DataColumn coldsUseL3DataTableCOMPLETE_TIME;
        private System.Data.DataColumn coldsUseL3DataTableFIRE_TIME_LEN;
        private System.Data.DataColumn coldsUseL3DataTableSTOP_TIME_LEN;
        private System.Data.DataColumn coldsUseL3DataTableLADLE_CHECK;
        private System.Data.DataColumn coldsUseL3DataTableOFF_REASON;
        private System.Data.DataColumn coldsUseL3DataTableSK_BOARD_KEEP;
        private System.Data.DataColumn coldsUseL3DataTableLADLE_GRADE;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private System.Data.DataColumn coldsUseL3DataTableBOFID;
        private System.Data.DataColumn coldsUseL3DataTableHeatID;
        private System.Data.DataColumn coldsUseL3DataTableHot_Time;
        private System.Data.DataColumn coldsUseL3DataTableFrame;
        private System.Data.DataColumn coldsUseL3DataTableSplint;
        private System.Data.DataColumn coldsUseL3DataTableSpringBox;
        private System.Data.DataColumn coldsUseL3DataTableJoint;
        private System.Data.DataColumn coldsUseL3DataTableJoint_Safety_Pin;
        private System.Data.DataColumn coldsUseL3DataTableLong_Axes;
        private System.Data.DataColumn coldsUseL3DataTableShort_Axes;
        private System.Data.DataColumn coldsUseL3DataTableChassis;
        private System.Data.DataColumn coldsUseL3DataTableProtect_Board;
        private System.Data.DataColumn coldsUseL3DataTableUp_Tighten_Machine;
        private System.Data.DataColumn coldsUseL3DataTableBreathe_Bri_Up;
        private System.Data.DataColumn coldsUseL3DataTableBreathe_Bri_Low;
        private System.Data.DataColumn coldsUseL3DataTableWater_Gap;
        private System.Data.DataColumn coldsUseL3DataTableWorkID;
        private System.Data.DataColumn coldsUseL3DataTableIrr_Start_Time;
        private System.Data.DataColumn coldsUseL3DataTableIrr_End_Time;
        private System.Data.DataColumn coldsUseL3DataTableNewLadleFirst;
        private System.Data.DataColumn coldsUseL3DataTableRemnantWT;
        private System.Data.DataColumn coldsUseL3DataTableComFlag;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private AppSvrHMI.L3DataSet dsLadleChcke;
        private System.Data.DataTable schemadsLadleChcke;
        private System.Data.DataColumn coldsLadleChckeL3DataTableCode;
        private AppSvrHMI.L3DataSet dsLadleThrow;
        private System.Data.DataTable schemadsLadleThrow;
        private System.Data.DataColumn coldsLadleThrowL3DataTableCode;
        private System.Data.DataColumn coldsLadleThrowL3DataTableCode_Des;
        private System.Data.DataColumn coldsLadleChckeL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnDataConfirm;
        private System.Data.DataColumn coldsUseL3DataTableConfirm_Flag;
        private System.Data.DataColumn coldsUseL3DataTableAct_Ladle_Grade;
        private AppSvrHMI.L3DataSet dsLadleChcke1;
        private System.Data.DataColumn AcoldsUseL3DataTableNewLadleFirst;
        private System.Data.DataColumn coldsUseL3DataTableNewLadleSecond;
        private System.Data.DataColumn coldsUseL3DataTableFireLadleFirst;
        private System.Data.DataColumn coldsUseL3DataTableFireLadleSecond;
        private System.Data.DataColumn coldsUseL3DataTableReturnLadle;
        private System.Data.DataColumn coldsUseL3DataTableHookEdgeLadle;
        private System.Data.DataColumn coldsUseL3DataTableRemnantLadle;
        private System.Data.DataColumn coldsUseL3DataTableLadle_Check1;
        private System.Data.DataTable schemadsLadleChcke1;
        private System.Data.DataColumn coldsLadleChcke1L3DataTableCode;
        private System.Data.DataColumn coldsLadleChcke1L3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnGBXXQuery;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Data.DataColumn coldsUseL3DataTableWall_Temp;
        private AppSvrHMI.L3DataSet dsUnitType;
        private System.Data.DataTable schemadsUnitType;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsAlarmMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn team;
        private System.Windows.Forms.DataGridViewTextBoxColumn SteelGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundish_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn realy_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn low_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn up_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarm_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarm_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alarm_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alarm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private AppSvrHMI.L3DataSet dsAlarmMessage;
        private System.Data.DataTable schemadsAlarmMessage;
        private System.Data.DataColumn coldsAlarmMessageL3DataTableteam;
        private System.Data.DataColumn coldsAlarmMessageL3DataTableHEATID;
        private System.Data.DataColumn coldsAlarmMessageL3DataTablesteelgrade;
        private System.Data.DataColumn coldsAlarmMessageL3DataTableworkid;
        private System.Data.DataColumn coldsAlarmMessageL3DataTablealarm_content;
        private System.Data.DataColumn coldsAlarmMessageL3DataTablealarm_name;
        private System.Data.DataColumn coldsAlarmMessageL3DataTabletundish_num;
        private System.Data.DataColumn coldsAlarmMessageL3DataTablerealy_value;
        private System.Data.DataColumn coldsAlarmMessageL3DataTablelow_value;
        private System.Data.DataColumn coldsAlarmMessageL3DataTableup_value;
        private System.Data.DataColumn coldsAlarmMessageL3DataTablealarm_time;
        private System.Data.DataColumn coldsAlarmMessageL3DataTablealarm_level;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelgradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmcontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realyvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmlevelDataGridViewTextBoxColumn;
    }
}