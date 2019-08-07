namespace EquipMag.LadleMag
{
    partial class LadleUseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadleUseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.coldsUseL3DataTableAuto_Flow = new System.Data.DataColumn();
            this.coldsUseL3DataTableTime_After_Steel = new System.Data.DataColumn();
            this.coldsUseL3DataTableTime_Ladle_Casting = new System.Data.DataColumn();
            this.coldsUseL3DataTableDump_LadleID = new System.Data.DataColumn();
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
            this.cmbLadleID = new System.Windows.Forms.ToolStripComboBox();
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
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dvUse = new System.Windows.Forms.DataGridView();
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
            this.dsAutoFlow = new AppSvrHMI.L3DataSet();
            this.schemadsAutoFlow = new System.Data.DataTable();
            this.coldsAutoFlowL3DataTableCode = new System.Data.DataColumn();
            this.coldsAutoFlowL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LADLE_GRADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Act_Ladle_Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irrEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAPTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_After_Steel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Ladle_Casting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOPTIMELENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEATOKTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFLADLETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRIVETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPLETETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRETIMELENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLECHECKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ladle_Check1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oFFREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Dump_LadleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKBOARDKEEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.springBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jointSafetyPinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longAxesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortAxesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protectBoardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upTightenMachineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breatheBriUpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breatheBriLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterGapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irrStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remnantWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wall_Temp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auto_Flow = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
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
            this.coldsUseL3DataTableWall_Temp,
            this.coldsUseL3DataTableAuto_Flow,
            this.coldsUseL3DataTableTime_After_Steel,
            this.coldsUseL3DataTableTime_Ladle_Casting,
            this.coldsUseL3DataTableDump_LadleID});
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
            // coldsUseL3DataTableAuto_Flow
            // 
            this.coldsUseL3DataTableAuto_Flow.Caption = "Auto_Flow";
            this.coldsUseL3DataTableAuto_Flow.ColumnName = "Auto_Flow";
            this.coldsUseL3DataTableAuto_Flow.DataType = typeof(short);
            this.coldsUseL3DataTableAuto_Flow.Namespace = "";
            // 
            // coldsUseL3DataTableTime_After_Steel
            // 
            this.coldsUseL3DataTableTime_After_Steel.Caption = "Time_After_Steel";
            this.coldsUseL3DataTableTime_After_Steel.ColumnName = "Time_After_Steel";
            this.coldsUseL3DataTableTime_After_Steel.DataType = typeof(double);
            this.coldsUseL3DataTableTime_After_Steel.Namespace = "";
            // 
            // coldsUseL3DataTableTime_Ladle_Casting
            // 
            this.coldsUseL3DataTableTime_Ladle_Casting.Caption = "Time_Ladle_Casting";
            this.coldsUseL3DataTableTime_Ladle_Casting.ColumnName = "Time_Ladle_Casting";
            this.coldsUseL3DataTableTime_Ladle_Casting.DataType = typeof(double);
            this.coldsUseL3DataTableTime_Ladle_Casting.Namespace = "";
            // 
            // coldsUseL3DataTableDump_LadleID
            // 
            this.coldsUseL3DataTableDump_LadleID.Caption = "Dump_LadleID";
            this.coldsUseL3DataTableDump_LadleID.ColumnName = "Dump_LadleID";
            this.coldsUseL3DataTableDump_LadleID.Namespace = "";
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
            this.cmbLadleID,
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
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
            this.toolStripLabel4.Size = new System.Drawing.Size(13, 22);
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
            this.btnDataConfirm.Size = new System.Drawing.Size(76, 22);
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
            this.btnGBXXQuery.Size = new System.Drawing.Size(100, 22);
            this.btnGBXXQuery.Text = "下线钢包查询";
            this.btnGBXXQuery.Click += new System.EventHandler(this.btnGBXXQuery_Click);
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
            this.btnExit.Size = new System.Drawing.Size(68, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 40);
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
            this.btnConfirm.Size = new System.Drawing.Size(68, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 40);
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
            this.btnOutPut.Size = new System.Drawing.Size(109, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
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
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.uSEDATEDataGridViewTextBoxColumn,
            this.lADLEIDDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.lADLEAGEDataGridViewTextBoxColumn,
            this.LADLE_GRADE,
            this.Act_Ladle_Grade,
            this.bOFIDDataGridViewTextBoxColumn,
            this.sTEELGRADEDataGridViewTextBoxColumn,
            this.irrEndTimeDataGridViewTextBoxColumn,
            this.tAPTIMEDataGridViewTextBoxColumn,
            this.Time_After_Steel,
            this.Time_Ladle_Casting,
            this.sTOPTIMELENDataGridViewTextBoxColumn,
            this.sEATOKTIMEDataGridViewTextBoxColumn,
            this.oFFLADLETIMEDataGridViewTextBoxColumn,
            this.aRRIVETIMEDataGridViewTextBoxColumn,
            this.cOMPLETETIMEDataGridViewTextBoxColumn,
            this.fIRETIMELENDataGridViewTextBoxColumn,
            this.lADLECHECKDataGridViewTextBoxColumn,
            this.Ladle_Check1,
            this.oFFREASONDataGridViewTextBoxColumn,
            this.Dump_LadleID,
            this.sKBOARDKEEPDataGridViewTextBoxColumn,
            this.hotTimeDataGridViewTextBoxColumn,
            this.frameDataGridViewTextBoxColumn,
            this.splintDataGridViewTextBoxColumn,
            this.springBoxDataGridViewTextBoxColumn,
            this.jointDataGridViewTextBoxColumn,
            this.jointSafetyPinDataGridViewTextBoxColumn,
            this.longAxesDataGridViewTextBoxColumn,
            this.shortAxesDataGridViewTextBoxColumn,
            this.chassisDataGridViewTextBoxColumn,
            this.protectBoardDataGridViewTextBoxColumn,
            this.upTightenMachineDataGridViewTextBoxColumn,
            this.breatheBriUpDataGridViewTextBoxColumn,
            this.breatheBriLowDataGridViewTextBoxColumn,
            this.waterGapDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.irrStartTimeDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.remnantWTDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.ComFlag,
            this.Wall_Temp,
            this.Auto_Flow});
            this.dvUse.DataSource = this.bsUse;
            this.dvUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvUse.Location = new System.Drawing.Point(0, 0);
            this.dvUse.Margin = new System.Windows.Forms.Padding(0);
            this.dvUse.Name = "dvUse";
            this.dvUse.ReadOnly = true;
            this.dvUse.RowTemplate.Height = 23;
            this.dvUse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvUse.Size = new System.Drawing.Size(1143, 632);
            this.dvUse.TabIndex = 31;
            this.dvUse.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            this.dvUse.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvUse_DataError);
            this.dvUse.Sorted += new System.EventHandler(this.dvUse_Sorted);
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
            // dsAutoFlow
            // 
            this.dsAutoFlow.AutoLoad = true;
            this.dsAutoFlow.AutoSubscribe = false;
            this.dsAutoFlow.DataSetName = "L3DataSet";
            this.dsAutoFlow.DeleteMethod = null;
            this.dsAutoFlow.InsertMethod = null;
            this.dsAutoFlow.L3DataAdapter = this.Adapter;
            this.dsAutoFlow.LoadEvent = "Click";
            this.dsAutoFlow.LoadTrigger = null;
            this.dsAutoFlow.RefreshValve = 1000;
            this.dsAutoFlow.SourceCommand = null;
            this.dsAutoFlow.SourceCondition = "Code_Group = \'CCM_AutoFlow\' order by Code";
            this.dsAutoFlow.SourceMethod = "";
            this.dsAutoFlow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAutoFlow.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAutoFlow.SubscribeTarget = null;
            this.dsAutoFlow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAutoFlow});
            this.dsAutoFlow.UpdateEvent = "Click";
            this.dsAutoFlow.UpdateMethod = null;
            this.dsAutoFlow.UpdateTrigger = null;
            // 
            // schemadsAutoFlow
            // 
            this.schemadsAutoFlow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAutoFlowL3DataTableCode,
            this.coldsAutoFlowL3DataTableCode_Des});
            this.schemadsAutoFlow.TableName = "L3DataTable";
            // 
            // coldsAutoFlowL3DataTableCode
            // 
            this.coldsAutoFlowL3DataTableCode.Caption = "Code";
            this.coldsAutoFlowL3DataTableCode.ColumnName = "Code";
            this.coldsAutoFlowL3DataTableCode.Namespace = "";
            // 
            // coldsAutoFlowL3DataTableCode_Des
            // 
            this.coldsAutoFlowL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAutoFlowL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAutoFlowL3DataTableCode_Des.Namespace = "";
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
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSEDATEDataGridViewTextBoxColumn
            // 
            this.uSEDATEDataGridViewTextBoxColumn.DataPropertyName = "USE_DATE";
            this.uSEDATEDataGridViewTextBoxColumn.HeaderText = "使用日期";
            this.uSEDATEDataGridViewTextBoxColumn.Name = "uSEDATEDataGridViewTextBoxColumn";
            this.uSEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSEDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // lADLEIDDataGridViewTextBoxColumn
            // 
            this.lADLEIDDataGridViewTextBoxColumn.DataPropertyName = "LADLEID";
            this.lADLEIDDataGridViewTextBoxColumn.HeaderText = "包号";
            this.lADLEIDDataGridViewTextBoxColumn.Name = "lADLEIDDataGridViewTextBoxColumn";
            this.lADLEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // lADLEAGEDataGridViewTextBoxColumn
            // 
            this.lADLEAGEDataGridViewTextBoxColumn.DataPropertyName = "LADLE_AGE";
            this.lADLEAGEDataGridViewTextBoxColumn.HeaderText = "包龄";
            this.lADLEAGEDataGridViewTextBoxColumn.Name = "lADLEAGEDataGridViewTextBoxColumn";
            this.lADLEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEAGEDataGridViewTextBoxColumn.Width = 54;
            // 
            // LADLE_GRADE
            // 
            this.LADLE_GRADE.DataPropertyName = "LADLE_GRADE";
            this.LADLE_GRADE.HeaderText = "包况";
            this.LADLE_GRADE.Name = "LADLE_GRADE";
            this.LADLE_GRADE.ReadOnly = true;
            // 
            // Act_Ladle_Grade
            // 
            this.Act_Ladle_Grade.DataPropertyName = "Act_Ladle_Grade";
            this.Act_Ladle_Grade.HeaderText = "实际包况";
            this.Act_Ladle_Grade.Name = "Act_Ladle_Grade";
            this.Act_Ladle_Grade.ReadOnly = true;
            this.Act_Ladle_Grade.Width = 78;
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "炉座";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOFIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // sTEELGRADEDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "STEEL_GRADE";
            this.sTEELGRADEDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.sTEELGRADEDataGridViewTextBoxColumn.Name = "sTEELGRADEDataGridViewTextBoxColumn";
            this.sTEELGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTEELGRADEDataGridViewTextBoxColumn.Width = 54;
            // 
            // irrEndTimeDataGridViewTextBoxColumn
            // 
            this.irrEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Irr_End_Time";
            this.irrEndTimeDataGridViewTextBoxColumn.HeaderText = "停浇时间";
            this.irrEndTimeDataGridViewTextBoxColumn.Name = "irrEndTimeDataGridViewTextBoxColumn";
            this.irrEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tAPTIMEDataGridViewTextBoxColumn
            // 
            this.tAPTIMEDataGridViewTextBoxColumn.DataPropertyName = "TAP_TIME";
            this.tAPTIMEDataGridViewTextBoxColumn.HeaderText = "出钢时间";
            this.tAPTIMEDataGridViewTextBoxColumn.Name = "tAPTIMEDataGridViewTextBoxColumn";
            this.tAPTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Time_After_Steel
            // 
            this.Time_After_Steel.DataPropertyName = "Time_After_Steel";
            this.Time_After_Steel.HeaderText = "钢包过钢时间";
            this.Time_After_Steel.Name = "Time_After_Steel";
            this.Time_After_Steel.ReadOnly = true;
            // 
            // Time_Ladle_Casting
            // 
            this.Time_Ladle_Casting.DataPropertyName = "Time_Ladle_Casting";
            this.Time_Ladle_Casting.HeaderText = "引流沙过钢时间";
            this.Time_Ladle_Casting.Name = "Time_Ladle_Casting";
            this.Time_Ladle_Casting.ReadOnly = true;
            // 
            // sTOPTIMELENDataGridViewTextBoxColumn
            // 
            this.sTOPTIMELENDataGridViewTextBoxColumn.DataPropertyName = "STOP_TIME_LEN";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.sTOPTIMELENDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.sTOPTIMELENDataGridViewTextBoxColumn.HeaderText = "停用时长";
            this.sTOPTIMELENDataGridViewTextBoxColumn.Name = "sTOPTIMELENDataGridViewTextBoxColumn";
            this.sTOPTIMELENDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOPTIMELENDataGridViewTextBoxColumn.Width = 78;
            // 
            // sEATOKTIMEDataGridViewTextBoxColumn
            // 
            this.sEATOKTIMEDataGridViewTextBoxColumn.DataPropertyName = "SEAT_OK_TIME";
            this.sEATOKTIMEDataGridViewTextBoxColumn.HeaderText = "座好包时间";
            this.sEATOKTIMEDataGridViewTextBoxColumn.Name = "sEATOKTIMEDataGridViewTextBoxColumn";
            this.sEATOKTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oFFLADLETIMEDataGridViewTextBoxColumn
            // 
            this.oFFLADLETIMEDataGridViewTextBoxColumn.DataPropertyName = "OFF_LADLE_TIME";
            this.oFFLADLETIMEDataGridViewTextBoxColumn.HeaderText = "下包时间";
            this.oFFLADLETIMEDataGridViewTextBoxColumn.Name = "oFFLADLETIMEDataGridViewTextBoxColumn";
            this.oFFLADLETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aRRIVETIMEDataGridViewTextBoxColumn
            // 
            this.aRRIVETIMEDataGridViewTextBoxColumn.DataPropertyName = "ARRIVE_TIME";
            this.aRRIVETIMEDataGridViewTextBoxColumn.HeaderText = "到上件时间";
            this.aRRIVETIMEDataGridViewTextBoxColumn.Name = "aRRIVETIMEDataGridViewTextBoxColumn";
            this.aRRIVETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPLETETIMEDataGridViewTextBoxColumn
            // 
            this.cOMPLETETIMEDataGridViewTextBoxColumn.DataPropertyName = "COMPLETE_TIME";
            this.cOMPLETETIMEDataGridViewTextBoxColumn.HeaderText = "上好件时间";
            this.cOMPLETETIMEDataGridViewTextBoxColumn.Name = "cOMPLETETIMEDataGridViewTextBoxColumn";
            this.cOMPLETETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIRETIMELENDataGridViewTextBoxColumn
            // 
            this.fIRETIMELENDataGridViewTextBoxColumn.DataPropertyName = "FIRE_TIME_LEN";
            this.fIRETIMELENDataGridViewTextBoxColumn.HeaderText = "烘烤时长";
            this.fIRETIMELENDataGridViewTextBoxColumn.Name = "fIRETIMELENDataGridViewTextBoxColumn";
            this.fIRETIMELENDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRETIMELENDataGridViewTextBoxColumn.Width = 78;
            // 
            // lADLECHECKDataGridViewTextBoxColumn
            // 
            this.lADLECHECKDataGridViewTextBoxColumn.DataPropertyName = "LADLE_CHECK";
            this.lADLECHECKDataGridViewTextBoxColumn.DataSource = this.dsLadleChcke;
            this.lADLECHECKDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.lADLECHECKDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lADLECHECKDataGridViewTextBoxColumn.HeaderText = "钢包包衬检查";
            this.lADLECHECKDataGridViewTextBoxColumn.Name = "lADLECHECKDataGridViewTextBoxColumn";
            this.lADLECHECKDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLECHECKDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lADLECHECKDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lADLECHECKDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.lADLECHECKDataGridViewTextBoxColumn.Width = 78;
            // 
            // Ladle_Check1
            // 
            this.Ladle_Check1.DataPropertyName = "Ladle_Check1";
            this.Ladle_Check1.DataSource = this.dsLadleChcke1;
            this.Ladle_Check1.DisplayMember = "L3DataTable.Code_Des";
            this.Ladle_Check1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Ladle_Check1.HeaderText = "钢包外部检查";
            this.Ladle_Check1.Name = "Ladle_Check1";
            this.Ladle_Check1.ReadOnly = true;
            this.Ladle_Check1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ladle_Check1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ladle_Check1.ValueMember = "L3DataTable.Code";
            // 
            // oFFREASONDataGridViewTextBoxColumn
            // 
            this.oFFREASONDataGridViewTextBoxColumn.DataPropertyName = "OFF_REASON";
            this.oFFREASONDataGridViewTextBoxColumn.DataSource = this.dsLadleThrow;
            this.oFFREASONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.oFFREASONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oFFREASONDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.oFFREASONDataGridViewTextBoxColumn.Name = "oFFREASONDataGridViewTextBoxColumn";
            this.oFFREASONDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFREASONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oFFREASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oFFREASONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.oFFREASONDataGridViewTextBoxColumn.Width = 78;
            // 
            // Dump_LadleID
            // 
            this.Dump_LadleID.DataPropertyName = "Dump_LadleID";
            this.Dump_LadleID.HeaderText = "甩包号";
            this.Dump_LadleID.Name = "Dump_LadleID";
            this.Dump_LadleID.ReadOnly = true;
            // 
            // sKBOARDKEEPDataGridViewTextBoxColumn
            // 
            this.sKBOARDKEEPDataGridViewTextBoxColumn.DataPropertyName = "SK_BOARD_KEEP";
            this.sKBOARDKEEPDataGridViewTextBoxColumn.HeaderText = "滑板连用";
            this.sKBOARDKEEPDataGridViewTextBoxColumn.Name = "sKBOARDKEEPDataGridViewTextBoxColumn";
            this.sKBOARDKEEPDataGridViewTextBoxColumn.ReadOnly = true;
            this.sKBOARDKEEPDataGridViewTextBoxColumn.Width = 78;
            // 
            // hotTimeDataGridViewTextBoxColumn
            // 
            this.hotTimeDataGridViewTextBoxColumn.DataPropertyName = "Hot_Time";
            this.hotTimeDataGridViewTextBoxColumn.HeaderText = "去烘烤时间";
            this.hotTimeDataGridViewTextBoxColumn.Name = "hotTimeDataGridViewTextBoxColumn";
            this.hotTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotTimeDataGridViewTextBoxColumn.Width = 90;
            // 
            // frameDataGridViewTextBoxColumn
            // 
            this.frameDataGridViewTextBoxColumn.DataPropertyName = "Frame";
            this.frameDataGridViewTextBoxColumn.HeaderText = "框架";
            this.frameDataGridViewTextBoxColumn.Name = "frameDataGridViewTextBoxColumn";
            this.frameDataGridViewTextBoxColumn.ReadOnly = true;
            this.frameDataGridViewTextBoxColumn.Width = 54;
            // 
            // splintDataGridViewTextBoxColumn
            // 
            this.splintDataGridViewTextBoxColumn.DataPropertyName = "Splint";
            this.splintDataGridViewTextBoxColumn.HeaderText = "托板";
            this.splintDataGridViewTextBoxColumn.Name = "splintDataGridViewTextBoxColumn";
            this.splintDataGridViewTextBoxColumn.ReadOnly = true;
            this.splintDataGridViewTextBoxColumn.Width = 54;
            // 
            // springBoxDataGridViewTextBoxColumn
            // 
            this.springBoxDataGridViewTextBoxColumn.DataPropertyName = "SpringBox";
            this.springBoxDataGridViewTextBoxColumn.HeaderText = "簧盒";
            this.springBoxDataGridViewTextBoxColumn.Name = "springBoxDataGridViewTextBoxColumn";
            this.springBoxDataGridViewTextBoxColumn.ReadOnly = true;
            this.springBoxDataGridViewTextBoxColumn.Width = 54;
            // 
            // jointDataGridViewTextBoxColumn
            // 
            this.jointDataGridViewTextBoxColumn.DataPropertyName = "Joint";
            this.jointDataGridViewTextBoxColumn.HeaderText = "关节";
            this.jointDataGridViewTextBoxColumn.Name = "jointDataGridViewTextBoxColumn";
            this.jointDataGridViewTextBoxColumn.ReadOnly = true;
            this.jointDataGridViewTextBoxColumn.Width = 54;
            // 
            // jointSafetyPinDataGridViewTextBoxColumn
            // 
            this.jointSafetyPinDataGridViewTextBoxColumn.DataPropertyName = "Joint_Safety_Pin";
            this.jointSafetyPinDataGridViewTextBoxColumn.HeaderText = "关节保险销";
            this.jointSafetyPinDataGridViewTextBoxColumn.Name = "jointSafetyPinDataGridViewTextBoxColumn";
            this.jointSafetyPinDataGridViewTextBoxColumn.ReadOnly = true;
            this.jointSafetyPinDataGridViewTextBoxColumn.Width = 90;
            // 
            // longAxesDataGridViewTextBoxColumn
            // 
            this.longAxesDataGridViewTextBoxColumn.DataPropertyName = "Long_Axes";
            this.longAxesDataGridViewTextBoxColumn.HeaderText = "长轴";
            this.longAxesDataGridViewTextBoxColumn.Name = "longAxesDataGridViewTextBoxColumn";
            this.longAxesDataGridViewTextBoxColumn.ReadOnly = true;
            this.longAxesDataGridViewTextBoxColumn.Width = 54;
            // 
            // shortAxesDataGridViewTextBoxColumn
            // 
            this.shortAxesDataGridViewTextBoxColumn.DataPropertyName = "Short_Axes";
            this.shortAxesDataGridViewTextBoxColumn.HeaderText = "短轴";
            this.shortAxesDataGridViewTextBoxColumn.Name = "shortAxesDataGridViewTextBoxColumn";
            this.shortAxesDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortAxesDataGridViewTextBoxColumn.Width = 54;
            // 
            // chassisDataGridViewTextBoxColumn
            // 
            this.chassisDataGridViewTextBoxColumn.DataPropertyName = "Chassis";
            this.chassisDataGridViewTextBoxColumn.HeaderText = "底盘";
            this.chassisDataGridViewTextBoxColumn.Name = "chassisDataGridViewTextBoxColumn";
            this.chassisDataGridViewTextBoxColumn.ReadOnly = true;
            this.chassisDataGridViewTextBoxColumn.Width = 54;
            // 
            // protectBoardDataGridViewTextBoxColumn
            // 
            this.protectBoardDataGridViewTextBoxColumn.DataPropertyName = "Protect_Board";
            this.protectBoardDataGridViewTextBoxColumn.HeaderText = "护板";
            this.protectBoardDataGridViewTextBoxColumn.Name = "protectBoardDataGridViewTextBoxColumn";
            this.protectBoardDataGridViewTextBoxColumn.ReadOnly = true;
            this.protectBoardDataGridViewTextBoxColumn.Width = 54;
            // 
            // upTightenMachineDataGridViewTextBoxColumn
            // 
            this.upTightenMachineDataGridViewTextBoxColumn.DataPropertyName = "Up_Tighten_Machine";
            this.upTightenMachineDataGridViewTextBoxColumn.HeaderText = "顶紧器";
            this.upTightenMachineDataGridViewTextBoxColumn.Name = "upTightenMachineDataGridViewTextBoxColumn";
            this.upTightenMachineDataGridViewTextBoxColumn.ReadOnly = true;
            this.upTightenMachineDataGridViewTextBoxColumn.Width = 66;
            // 
            // breatheBriUpDataGridViewTextBoxColumn
            // 
            this.breatheBriUpDataGridViewTextBoxColumn.DataPropertyName = "Breathe_Bri_Up";
            this.breatheBriUpDataGridViewTextBoxColumn.HeaderText = "透气砖上";
            this.breatheBriUpDataGridViewTextBoxColumn.Name = "breatheBriUpDataGridViewTextBoxColumn";
            this.breatheBriUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.breatheBriUpDataGridViewTextBoxColumn.Width = 78;
            // 
            // breatheBriLowDataGridViewTextBoxColumn
            // 
            this.breatheBriLowDataGridViewTextBoxColumn.DataPropertyName = "Breathe_Bri_Low";
            this.breatheBriLowDataGridViewTextBoxColumn.HeaderText = "透气砖下";
            this.breatheBriLowDataGridViewTextBoxColumn.Name = "breatheBriLowDataGridViewTextBoxColumn";
            this.breatheBriLowDataGridViewTextBoxColumn.ReadOnly = true;
            this.breatheBriLowDataGridViewTextBoxColumn.Width = 78;
            // 
            // waterGapDataGridViewTextBoxColumn
            // 
            this.waterGapDataGridViewTextBoxColumn.DataPropertyName = "Water_Gap";
            this.waterGapDataGridViewTextBoxColumn.HeaderText = "上水口";
            this.waterGapDataGridViewTextBoxColumn.Name = "waterGapDataGridViewTextBoxColumn";
            this.waterGapDataGridViewTextBoxColumn.ReadOnly = true;
            this.waterGapDataGridViewTextBoxColumn.Width = 66;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // irrStartTimeDataGridViewTextBoxColumn
            // 
            this.irrStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Irr_Start_Time";
            this.irrStartTimeDataGridViewTextBoxColumn.HeaderText = "开浇时间";
            this.irrStartTimeDataGridViewTextBoxColumn.Name = "irrStartTimeDataGridViewTextBoxColumn";
            this.irrStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.irrStartTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 54;
            // 
            // remnantWTDataGridViewTextBoxColumn
            // 
            this.remnantWTDataGridViewTextBoxColumn.DataPropertyName = "RemnantWT";
            this.remnantWTDataGridViewTextBoxColumn.HeaderText = "包底重量";
            this.remnantWTDataGridViewTextBoxColumn.Name = "remnantWTDataGridViewTextBoxColumn";
            this.remnantWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.remnantWTDataGridViewTextBoxColumn.Width = 78;
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
            // ComFlag
            // 
            this.ComFlag.DataPropertyName = "ComFlag";
            this.ComFlag.HeaderText = "完成标志";
            this.ComFlag.Name = "ComFlag";
            this.ComFlag.ReadOnly = true;
            this.ComFlag.Width = 78;
            // 
            // Wall_Temp
            // 
            this.Wall_Temp.DataPropertyName = "Wall_Temp";
            dataGridViewCellStyle2.NullValue = "0";
            this.Wall_Temp.DefaultCellStyle = dataGridViewCellStyle2;
            this.Wall_Temp.HeaderText = "出钢前包壁温度";
            this.Wall_Temp.Name = "Wall_Temp";
            this.Wall_Temp.ReadOnly = true;
            // 
            // Auto_Flow
            // 
            this.Auto_Flow.DataPropertyName = "Auto_Flow";
            this.Auto_Flow.DataSource = this.dsAutoFlow;
            this.Auto_Flow.DisplayMember = "L3DataTable.Code_Des";
            this.Auto_Flow.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Auto_Flow.HeaderText = "是否自动开浇";
            this.Auto_Flow.Name = "Auto_Flow";
            this.Auto_Flow.ReadOnly = true;
            this.Auto_Flow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Auto_Flow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Auto_Flow.ValueMember = "L3DataTable.Code";
            // 
            // LadleUseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LadleUseMagFrm";
            this.TabText = "钢包使用实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LadleUseMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LadleUseMagFrm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvUse;
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
        private AppSvrHMI.L3DataSet dsAutoFlow;
        private System.Data.DataColumn coldsUseL3DataTableAuto_Flow;
        private System.Data.DataTable schemadsAutoFlow;
        private System.Data.DataColumn coldsAutoFlowL3DataTableCode;
        private System.Data.DataColumn coldsAutoFlowL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEGRADEDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsUseL3DataTableDump_LadleID;
        private System.Data.DataColumn coldsUseL3DataTableTime_After_Steel;
        private System.Data.DataColumn coldsUseL3DataTableTime_Ladle_Casting;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LADLE_GRADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Act_Ladle_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irrEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAPTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_After_Steel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Ladle_Casting;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOPTIMELENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEATOKTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFLADLETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRIVETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPLETETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRETIMELENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lADLECHECKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ladle_Check1;
        private System.Windows.Forms.DataGridViewComboBoxColumn oFFREASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dump_LadleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKBOARDKEEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn splintDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn springBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jointSafetyPinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longAxesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortAxesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protectBoardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upTightenMachineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breatheBriUpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breatheBriLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterGapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn irrStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remnantWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wall_Temp;
        private System.Windows.Forms.DataGridViewComboBoxColumn Auto_Flow;
    }
}