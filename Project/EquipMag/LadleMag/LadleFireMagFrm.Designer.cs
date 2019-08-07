namespace EquipMag.LadleMag
{
    partial class LadleFireMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LadleFireMagFrm));
            this.bsFire = new System.Windows.Forms.BindingSource(this.components);
            this.dsFire = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdFire = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableFIRE_TYPE = new System.Data.DataColumn();
            this.coldsMainL3DataTableROASTER_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSTART_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableSTART_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_ONE_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_ONE_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_TWO_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_TWO_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_THREE_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_THREE_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_FOUR_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableSET_FOUR_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableEND_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableEND_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableSUSPEND_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableSUSPEND_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsFireL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsFireL3DataTableFireNote = new System.Data.DataColumn();
            this.coldsFireL3DataTableFireID = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
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
            this.cmbFireEquID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbLadleID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnDataConfirm = new System.Windows.Forms.ToolStripButton();
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
            this.dvFire = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLadleFireType = new AppSvrHMI.L3DataSet();
            this.schemadsLadleFireType = new System.Data.DataTable();
            this.coldsLadleFireTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleFireTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.FireNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOASTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTARTOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETONETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETONEOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETTWOTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETTWOOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETTHREETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETTHREEOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETFOURTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETFOUROPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUSPENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUSPENDOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.dsLadleFireEqu = new AppSvrHMI.L3DataSet();
            this.schemadsLadleFireEqu = new System.Data.DataTable();
            this.coldsLadleFireEquL3DataTableCode = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireEqu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireEqu)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFire
            // 
            this.bsFire.DataMember = "L3DataTable";
            this.bsFire.DataSource = this.dsFire;
            // 
            // dsFire
            // 
            this.dsFire.AutoLoad = true;
            this.dsFire.AutoSubscribe = false;
            this.dsFire.DataSetName = "L3DataSet";
            this.dsFire.DeleteMethod = "DeleteFireInfos";
            this.dsFire.InsertMethod = "InsertFireInfos";
            this.dsFire.L3DataAdapter = this.Adapter;
            this.dsFire.LoadEvent = "Click";
            this.dsFire.LoadTrigger = null;
            this.dsFire.RefreshValve = 1000;
            this.dsFire.SourceCommand = this.cmdFire;
            this.dsFire.SourceCondition = null;
            this.dsFire.SourceMethod = "GetFireInfos";
            this.dsFire.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsFire.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.dsFire.SubscribeTarget = null;
            this.dsFire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsFire.UpdateEvent = "Click";
            this.dsFire.UpdateMethod = "UpdateFireInfos";
            this.dsFire.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdFire
            // 
            this.cmdFire.Adapter = null;
            this.cmdFire.MergeReturnTarget = false;
            this.cmdFire.Method = null;
            this.cmdFire.Object = null;
            this.cmdFire.Parameters.Add(this.l3CommandParameter1);
            this.cmdFire.ReturnTarget = null;
            this.cmdFire.ReturnTargetProperty = null;
            this.cmdFire.Trigger = null;
            this.cmdFire.TriggerEvent = "Click";
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
            this.coldsMainL3DataTableFIRE_TYPE,
            this.coldsMainL3DataTableROASTER_ID,
            this.coldsMainL3DataTableLADLEID,
            this.coldsMainL3DataTableSTART_TIME,
            this.coldsMainL3DataTableSTART_OPERATOR,
            this.coldsMainL3DataTableSET_ONE_TIME,
            this.coldsMainL3DataTableSET_ONE_OPERATOR,
            this.coldsMainL3DataTableSET_TWO_TIME,
            this.coldsMainL3DataTableSET_TWO_OPERATOR,
            this.coldsMainL3DataTableSET_THREE_TIME,
            this.coldsMainL3DataTableSET_THREE_OPERATOR,
            this.coldsMainL3DataTableSET_FOUR_TIME,
            this.coldsMainL3DataTableSET_FOUR_OPERATOR,
            this.coldsMainL3DataTableEND_TIME,
            this.coldsMainL3DataTableEND_OPERATOR,
            this.coldsMainL3DataTableSUSPEND_TIME,
            this.coldsMainL3DataTableSUSPEND_OPERATOR,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableOPERATOR,
            this.coldsMainL3DataTableNOTE,
            this.coldsFireL3DataTableWorkID,
            this.coldsFireL3DataTableFireNote,
            this.coldsFireL3DataTableFireID});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.DefaultValue = "";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableNAME
            // 
            this.coldsMainL3DataTableNAME.Caption = "NAME";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.DefaultValue = "";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableINPUT_TIME
            // 
            this.coldsMainL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableFIRE_TYPE
            // 
            this.coldsMainL3DataTableFIRE_TYPE.Caption = "FIRE_TYPE";
            this.coldsMainL3DataTableFIRE_TYPE.ColumnName = "FIRE_TYPE";
            this.coldsMainL3DataTableFIRE_TYPE.DefaultValue = "";
            this.coldsMainL3DataTableFIRE_TYPE.Namespace = "";
            // 
            // coldsMainL3DataTableROASTER_ID
            // 
            this.coldsMainL3DataTableROASTER_ID.Caption = "ROASTER_ID";
            this.coldsMainL3DataTableROASTER_ID.ColumnName = "ROASTER_ID";
            this.coldsMainL3DataTableROASTER_ID.DefaultValue = "";
            this.coldsMainL3DataTableROASTER_ID.Namespace = "";
            // 
            // coldsMainL3DataTableLADLEID
            // 
            this.coldsMainL3DataTableLADLEID.Caption = "LADLEID";
            this.coldsMainL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsMainL3DataTableLADLEID.DefaultValue = "";
            this.coldsMainL3DataTableLADLEID.Namespace = "";
            // 
            // coldsMainL3DataTableSTART_TIME
            // 
            this.coldsMainL3DataTableSTART_TIME.Caption = "START_TIME";
            this.coldsMainL3DataTableSTART_TIME.ColumnName = "START_TIME";
            this.coldsMainL3DataTableSTART_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSTART_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableSTART_OPERATOR
            // 
            this.coldsMainL3DataTableSTART_OPERATOR.Caption = "START_OPERATOR";
            this.coldsMainL3DataTableSTART_OPERATOR.ColumnName = "START_OPERATOR";
            this.coldsMainL3DataTableSTART_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableSTART_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableSET_ONE_TIME
            // 
            this.coldsMainL3DataTableSET_ONE_TIME.Caption = "SET_ONE_TIME";
            this.coldsMainL3DataTableSET_ONE_TIME.ColumnName = "SET_ONE_TIME";
            this.coldsMainL3DataTableSET_ONE_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSET_ONE_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableSET_ONE_OPERATOR
            // 
            this.coldsMainL3DataTableSET_ONE_OPERATOR.Caption = "SET_ONE_OPERATOR";
            this.coldsMainL3DataTableSET_ONE_OPERATOR.ColumnName = "SET_ONE_OPERATOR";
            this.coldsMainL3DataTableSET_ONE_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableSET_ONE_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableSET_TWO_TIME
            // 
            this.coldsMainL3DataTableSET_TWO_TIME.Caption = "SET_TWO_TIME";
            this.coldsMainL3DataTableSET_TWO_TIME.ColumnName = "SET_TWO_TIME";
            this.coldsMainL3DataTableSET_TWO_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSET_TWO_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableSET_TWO_OPERATOR
            // 
            this.coldsMainL3DataTableSET_TWO_OPERATOR.Caption = "SET_TWO_OPERATOR";
            this.coldsMainL3DataTableSET_TWO_OPERATOR.ColumnName = "SET_TWO_OPERATOR";
            this.coldsMainL3DataTableSET_TWO_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableSET_TWO_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableSET_THREE_TIME
            // 
            this.coldsMainL3DataTableSET_THREE_TIME.Caption = "SET_THREE_TIME";
            this.coldsMainL3DataTableSET_THREE_TIME.ColumnName = "SET_THREE_TIME";
            this.coldsMainL3DataTableSET_THREE_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSET_THREE_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableSET_THREE_OPERATOR
            // 
            this.coldsMainL3DataTableSET_THREE_OPERATOR.Caption = "SET_THREE_OPERATOR";
            this.coldsMainL3DataTableSET_THREE_OPERATOR.ColumnName = "SET_THREE_OPERATOR";
            this.coldsMainL3DataTableSET_THREE_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableSET_THREE_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableSET_FOUR_TIME
            // 
            this.coldsMainL3DataTableSET_FOUR_TIME.Caption = "SET_FOUR_TIME";
            this.coldsMainL3DataTableSET_FOUR_TIME.ColumnName = "SET_FOUR_TIME";
            this.coldsMainL3DataTableSET_FOUR_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSET_FOUR_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableSET_FOUR_OPERATOR
            // 
            this.coldsMainL3DataTableSET_FOUR_OPERATOR.Caption = "SET_FOUR_OPERATOR";
            this.coldsMainL3DataTableSET_FOUR_OPERATOR.ColumnName = "SET_FOUR_OPERATOR";
            this.coldsMainL3DataTableSET_FOUR_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableSET_FOUR_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableEND_TIME
            // 
            this.coldsMainL3DataTableEND_TIME.Caption = "END_TIME";
            this.coldsMainL3DataTableEND_TIME.ColumnName = "END_TIME";
            this.coldsMainL3DataTableEND_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableEND_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableEND_OPERATOR
            // 
            this.coldsMainL3DataTableEND_OPERATOR.Caption = "END_OPERATOR";
            this.coldsMainL3DataTableEND_OPERATOR.ColumnName = "END_OPERATOR";
            this.coldsMainL3DataTableEND_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableEND_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableSUSPEND_TIME
            // 
            this.coldsMainL3DataTableSUSPEND_TIME.Caption = "SUSPEND_TIME";
            this.coldsMainL3DataTableSUSPEND_TIME.ColumnName = "SUSPEND_TIME";
            this.coldsMainL3DataTableSUSPEND_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableSUSPEND_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableSUSPEND_OPERATOR
            // 
            this.coldsMainL3DataTableSUSPEND_OPERATOR.Caption = "SUSPEND_OPERATOR";
            this.coldsMainL3DataTableSUSPEND_OPERATOR.ColumnName = "SUSPEND_OPERATOR";
            this.coldsMainL3DataTableSUSPEND_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableSUSPEND_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableTEAMID
            // 
            this.coldsMainL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsMainL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsMainL3DataTableTEAMID.DefaultValue = "";
            this.coldsMainL3DataTableTEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableSHIFTID
            // 
            this.coldsMainL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.DefaultValue = "";
            this.coldsMainL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableOPERATOR
            // 
            this.coldsMainL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "NOTE";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.DefaultValue = "";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // coldsFireL3DataTableWorkID
            // 
            this.coldsFireL3DataTableWorkID.Caption = "WorkID";
            this.coldsFireL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsFireL3DataTableWorkID.Namespace = "";
            // 
            // coldsFireL3DataTableFireNote
            // 
            this.coldsFireL3DataTableFireNote.Caption = "FireNote";
            this.coldsFireL3DataTableFireNote.ColumnName = "FireNote";
            this.coldsFireL3DataTableFireNote.Namespace = "";
            // 
            // coldsFireL3DataTableFireID
            // 
            this.coldsFireL3DataTableFireID.Caption = "FireID";
            this.coldsFireL3DataTableFireID.ColumnName = "FireID";
            this.coldsFireL3DataTableFireID.Namespace = "";
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
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsFire;
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
            this.cmbFireEquID,
            this.toolStripLabel6,
            this.cmbLadleID,
            this.toolStripLabel2,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel3,
            this.btnDataConfirm});
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
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
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
            // cmbFireEquID
            // 
            this.cmbFireEquID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbFireEquID.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbFireEquID.Name = "cmbFireEquID";
            this.cmbFireEquID.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel6.Text = "烘烤器:";
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(80, 25);
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
            this.hmiRootPanel1.Controls.Add(this.dvFire);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(3, 71);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(994, 626);
            this.hmiRootPanel1.TabIndex = 28;
            // 
            // dvFire
            // 
            this.dvFire.AllowUserToAddRows = false;
            this.dvFire.AutoGenerateColumns = false;
            this.dvFire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvFire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvFire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.fIRETYPEDataGridViewTextBoxColumn,
            this.FireNote,
            this.rOASTERIDDataGridViewTextBoxColumn,
            this.lADLEIDDataGridViewTextBoxColumn,
            this.WorkID,
            this.sTARTTIMEDataGridViewTextBoxColumn,
            this.sTARTOPERATORDataGridViewTextBoxColumn,
            this.sETONETIMEDataGridViewTextBoxColumn,
            this.sETONEOPERATORDataGridViewTextBoxColumn,
            this.sETTWOTIMEDataGridViewTextBoxColumn,
            this.sETTWOOPERATORDataGridViewTextBoxColumn,
            this.sETTHREETIMEDataGridViewTextBoxColumn,
            this.sETTHREEOPERATORDataGridViewTextBoxColumn,
            this.sETFOURTIMEDataGridViewTextBoxColumn,
            this.sETFOUROPERATORDataGridViewTextBoxColumn,
            this.eNDTIMEDataGridViewTextBoxColumn,
            this.eNDOPERATORDataGridViewTextBoxColumn,
            this.sUSPENDTIMEDataGridViewTextBoxColumn,
            this.sUSPENDOPERATORDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvFire.DataSource = this.bsFire;
            this.dvFire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFire.Location = new System.Drawing.Point(0, 0);
            this.dvFire.Margin = new System.Windows.Forms.Padding(0);
            this.dvFire.Name = "dvFire";
            this.dvFire.ReadOnly = true;
            this.dvFire.RowTemplate.Height = 23;
            this.dvFire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvFire.Size = new System.Drawing.Size(994, 626);
            this.dvFire.TabIndex = 31;
            this.dvFire.Sorted += new System.EventHandler(this.dvFire_Sorted);
            this.dvFire.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            this.dvFire.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // fIRETYPEDataGridViewTextBoxColumn
            // 
            this.fIRETYPEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_TYPE";
            this.fIRETYPEDataGridViewTextBoxColumn.DataSource = this.dsLadleFireType;
            this.fIRETYPEDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.fIRETYPEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fIRETYPEDataGridViewTextBoxColumn.HeaderText = "烘烤类别";
            this.fIRETYPEDataGridViewTextBoxColumn.Name = "fIRETYPEDataGridViewTextBoxColumn";
            this.fIRETYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRETYPEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fIRETYPEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fIRETYPEDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.fIRETYPEDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsLadleFireType
            // 
            this.dsLadleFireType.AutoLoad = true;
            this.dsLadleFireType.AutoSubscribe = false;
            this.dsLadleFireType.DataSetName = "L3DataSet";
            this.dsLadleFireType.DeleteMethod = null;
            this.dsLadleFireType.InsertMethod = null;
            this.dsLadleFireType.L3DataAdapter = this.Adapter;
            this.dsLadleFireType.LoadEvent = "Click";
            this.dsLadleFireType.LoadTrigger = null;
            this.dsLadleFireType.RefreshValve = 1000;
            this.dsLadleFireType.SourceCommand = null;
            this.dsLadleFireType.SourceCondition = "CODE_GROUP = \'LadleFireType\' order by CODE";
            this.dsLadleFireType.SourceMethod = "";
            this.dsLadleFireType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleFireType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleFireType.SubscribeTarget = null;
            this.dsLadleFireType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleFireType});
            this.dsLadleFireType.UpdateEvent = "Click";
            this.dsLadleFireType.UpdateMethod = null;
            this.dsLadleFireType.UpdateTrigger = null;
            // 
            // schemadsLadleFireType
            // 
            this.schemadsLadleFireType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleFireTypeL3DataTableCode,
            this.coldsLadleFireTypeL3DataTableCode_Des});
            this.schemadsLadleFireType.TableName = "L3DataTable";
            // 
            // coldsLadleFireTypeL3DataTableCode
            // 
            this.coldsLadleFireTypeL3DataTableCode.Caption = "Code";
            this.coldsLadleFireTypeL3DataTableCode.ColumnName = "Code";
            this.coldsLadleFireTypeL3DataTableCode.Namespace = "";
            // 
            // coldsLadleFireTypeL3DataTableCode_Des
            // 
            this.coldsLadleFireTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleFireTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleFireTypeL3DataTableCode_Des.Namespace = "";
            // 
            // FireNote
            // 
            this.FireNote.DataPropertyName = "FireNote";
            this.FireNote.HeaderText = "烘烤备注";
            this.FireNote.Name = "FireNote";
            this.FireNote.ReadOnly = true;
            this.FireNote.Width = 78;
            // 
            // rOASTERIDDataGridViewTextBoxColumn
            // 
            this.rOASTERIDDataGridViewTextBoxColumn.DataPropertyName = "ROASTER_ID";
            this.rOASTERIDDataGridViewTextBoxColumn.HeaderText = "烘烤器台号";
            this.rOASTERIDDataGridViewTextBoxColumn.Name = "rOASTERIDDataGridViewTextBoxColumn";
            this.rOASTERIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rOASTERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rOASTERIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // lADLEIDDataGridViewTextBoxColumn
            // 
            this.lADLEIDDataGridViewTextBoxColumn.DataPropertyName = "LADLEID";
            this.lADLEIDDataGridViewTextBoxColumn.HeaderText = "钢包号";
            this.lADLEIDDataGridViewTextBoxColumn.Name = "lADLEIDDataGridViewTextBoxColumn";
            this.lADLEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lADLEIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lADLEIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // WorkID
            // 
            this.WorkID.DataPropertyName = "WorkID";
            this.WorkID.HeaderText = "工作层编号";
            this.WorkID.Name = "WorkID";
            this.WorkID.ReadOnly = true;
            this.WorkID.Width = 90;
            // 
            // sTARTTIMEDataGridViewTextBoxColumn
            // 
            this.sTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "START_TIME";
            this.sTARTTIMEDataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.sTARTTIMEDataGridViewTextBoxColumn.Name = "sTARTTIMEDataGridViewTextBoxColumn";
            this.sTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTARTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sTARTOPERATORDataGridViewTextBoxColumn
            // 
            this.sTARTOPERATORDataGridViewTextBoxColumn.DataPropertyName = "START_OPERATOR";
            this.sTARTOPERATORDataGridViewTextBoxColumn.HeaderText = "开始操作员";
            this.sTARTOPERATORDataGridViewTextBoxColumn.Name = "sTARTOPERATORDataGridViewTextBoxColumn";
            this.sTARTOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTARTOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // sETONETIMEDataGridViewTextBoxColumn
            // 
            this.sETONETIMEDataGridViewTextBoxColumn.DataPropertyName = "SET_ONE_TIME";
            this.sETONETIMEDataGridViewTextBoxColumn.HeaderText = "调一时间";
            this.sETONETIMEDataGridViewTextBoxColumn.Name = "sETONETIMEDataGridViewTextBoxColumn";
            this.sETONETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETONETIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sETONEOPERATORDataGridViewTextBoxColumn
            // 
            this.sETONEOPERATORDataGridViewTextBoxColumn.DataPropertyName = "SET_ONE_OPERATOR";
            this.sETONEOPERATORDataGridViewTextBoxColumn.HeaderText = "调一操作员";
            this.sETONEOPERATORDataGridViewTextBoxColumn.Name = "sETONEOPERATORDataGridViewTextBoxColumn";
            this.sETONEOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETONEOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // sETTWOTIMEDataGridViewTextBoxColumn
            // 
            this.sETTWOTIMEDataGridViewTextBoxColumn.DataPropertyName = "SET_TWO_TIME";
            this.sETTWOTIMEDataGridViewTextBoxColumn.HeaderText = "调二时间";
            this.sETTWOTIMEDataGridViewTextBoxColumn.Name = "sETTWOTIMEDataGridViewTextBoxColumn";
            this.sETTWOTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETTWOTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sETTWOOPERATORDataGridViewTextBoxColumn
            // 
            this.sETTWOOPERATORDataGridViewTextBoxColumn.DataPropertyName = "SET_TWO_OPERATOR";
            this.sETTWOOPERATORDataGridViewTextBoxColumn.HeaderText = "调二操作员";
            this.sETTWOOPERATORDataGridViewTextBoxColumn.Name = "sETTWOOPERATORDataGridViewTextBoxColumn";
            this.sETTWOOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETTWOOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // sETTHREETIMEDataGridViewTextBoxColumn
            // 
            this.sETTHREETIMEDataGridViewTextBoxColumn.DataPropertyName = "SET_THREE_TIME";
            this.sETTHREETIMEDataGridViewTextBoxColumn.HeaderText = "调三时间";
            this.sETTHREETIMEDataGridViewTextBoxColumn.Name = "sETTHREETIMEDataGridViewTextBoxColumn";
            this.sETTHREETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETTHREETIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sETTHREEOPERATORDataGridViewTextBoxColumn
            // 
            this.sETTHREEOPERATORDataGridViewTextBoxColumn.DataPropertyName = "SET_THREE_OPERATOR";
            this.sETTHREEOPERATORDataGridViewTextBoxColumn.HeaderText = "调三操作员";
            this.sETTHREEOPERATORDataGridViewTextBoxColumn.Name = "sETTHREEOPERATORDataGridViewTextBoxColumn";
            this.sETTHREEOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETTHREEOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // sETFOURTIMEDataGridViewTextBoxColumn
            // 
            this.sETFOURTIMEDataGridViewTextBoxColumn.DataPropertyName = "SET_FOUR_TIME";
            this.sETFOURTIMEDataGridViewTextBoxColumn.HeaderText = "调四时间";
            this.sETFOURTIMEDataGridViewTextBoxColumn.Name = "sETFOURTIMEDataGridViewTextBoxColumn";
            this.sETFOURTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETFOURTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sETFOUROPERATORDataGridViewTextBoxColumn
            // 
            this.sETFOUROPERATORDataGridViewTextBoxColumn.DataPropertyName = "SET_FOUR_OPERATOR";
            this.sETFOUROPERATORDataGridViewTextBoxColumn.HeaderText = "调四操作员";
            this.sETFOUROPERATORDataGridViewTextBoxColumn.Name = "sETFOUROPERATORDataGridViewTextBoxColumn";
            this.sETFOUROPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sETFOUROPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // eNDTIMEDataGridViewTextBoxColumn
            // 
            this.eNDTIMEDataGridViewTextBoxColumn.DataPropertyName = "END_TIME";
            this.eNDTIMEDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.eNDTIMEDataGridViewTextBoxColumn.Name = "eNDTIMEDataGridViewTextBoxColumn";
            this.eNDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNDTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // eNDOPERATORDataGridViewTextBoxColumn
            // 
            this.eNDOPERATORDataGridViewTextBoxColumn.DataPropertyName = "END_OPERATOR";
            this.eNDOPERATORDataGridViewTextBoxColumn.HeaderText = "结束操作员";
            this.eNDOPERATORDataGridViewTextBoxColumn.Name = "eNDOPERATORDataGridViewTextBoxColumn";
            this.eNDOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNDOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // sUSPENDTIMEDataGridViewTextBoxColumn
            // 
            this.sUSPENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "SUSPEND_TIME";
            this.sUSPENDTIMEDataGridViewTextBoxColumn.HeaderText = "吊包时间";
            this.sUSPENDTIMEDataGridViewTextBoxColumn.Name = "sUSPENDTIMEDataGridViewTextBoxColumn";
            this.sUSPENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUSPENDTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sUSPENDOPERATORDataGridViewTextBoxColumn
            // 
            this.sUSPENDOPERATORDataGridViewTextBoxColumn.DataPropertyName = "SUSPEND_OPERATOR";
            this.sUSPENDOPERATORDataGridViewTextBoxColumn.HeaderText = "吊包操作员";
            this.sUSPENDOPERATORDataGridViewTextBoxColumn.Name = "sUSPENDOPERATORDataGridViewTextBoxColumn";
            this.sUSPENDOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUSPENDOPERATORDataGridViewTextBoxColumn.Width = 90;
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
            // dsLadleFireEqu
            // 
            this.dsLadleFireEqu.AutoLoad = true;
            this.dsLadleFireEqu.AutoSubscribe = false;
            this.dsLadleFireEqu.DataSetName = "L3DataSet";
            this.dsLadleFireEqu.DeleteMethod = null;
            this.dsLadleFireEqu.InsertMethod = null;
            this.dsLadleFireEqu.L3DataAdapter = this.Adapter;
            this.dsLadleFireEqu.LoadEvent = "Click";
            this.dsLadleFireEqu.LoadTrigger = null;
            this.dsLadleFireEqu.RefreshValve = 1000;
            this.dsLadleFireEqu.SourceCommand = null;
            this.dsLadleFireEqu.SourceCondition = "CODE_GROUP = \'LadleFireEqu\' order by CODE_Val_Str";
            this.dsLadleFireEqu.SourceMethod = "";
            this.dsLadleFireEqu.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleFireEqu.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleFireEqu.SubscribeTarget = null;
            this.dsLadleFireEqu.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleFireEqu});
            this.dsLadleFireEqu.UpdateEvent = "Click";
            this.dsLadleFireEqu.UpdateMethod = null;
            this.dsLadleFireEqu.UpdateTrigger = null;
            // 
            // schemadsLadleFireEqu
            // 
            this.schemadsLadleFireEqu.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleFireEquL3DataTableCode});
            this.schemadsLadleFireEqu.TableName = "L3DataTable";
            // 
            // coldsLadleFireEquL3DataTableCode
            // 
            this.coldsLadleFireEquL3DataTableCode.Caption = "Code";
            this.coldsLadleFireEquL3DataTableCode.ColumnName = "Code";
            this.coldsLadleFireEquL3DataTableCode.Namespace = "";
            // 
            // LadleFireMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LadleFireMagFrm";
            this.TabText = "钢包烘烤实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LadleFireMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LadleFireMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleFireEqu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleFireEqu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsFire;
        private System.Windows.Forms.BindingSource bsFire;
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
        private System.Windows.Forms.DataGridView dvFire;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbLadleID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private AppSvrHMI.L3Command cmdFire;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableFIRE_TYPE;
        private System.Data.DataColumn coldsMainL3DataTableROASTER_ID;
        private System.Data.DataColumn coldsMainL3DataTableLADLEID;
        private System.Data.DataColumn coldsMainL3DataTableSTART_TIME;
        private System.Data.DataColumn coldsMainL3DataTableSTART_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableSET_ONE_TIME;
        private System.Data.DataColumn coldsMainL3DataTableSET_ONE_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableSET_TWO_TIME;
        private System.Data.DataColumn coldsMainL3DataTableSET_TWO_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableSET_THREE_TIME;
        private System.Data.DataColumn coldsMainL3DataTableSET_THREE_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableSET_FOUR_TIME;
        private System.Data.DataColumn coldsMainL3DataTableSET_FOUR_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableEND_TIME;
        private System.Data.DataColumn coldsMainL3DataTableEND_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableSUSPEND_TIME;
        private System.Data.DataColumn coldsMainL3DataTableSUSPEND_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableOPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private System.Data.DataColumn coldsFireL3DataTableWorkID;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private AppSvrHMI.L3DataSet dsLadleFireType;
        private System.Data.DataTable schemadsLadleFireType;
        private System.Data.DataColumn coldsLadleFireTypeL3DataTableCode;
        private System.Data.DataColumn coldsLadleFireTypeL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.ToolStripButton btnDataConfirm;
        private System.Data.DataColumn coldsFireL3DataTableFireNote;
        private System.Data.DataColumn coldsFireL3DataTableFireID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fIRETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FireNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOASTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTARTOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETONETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETONEOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETTWOTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETTWOOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETTHREETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETTHREEOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETFOURTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETFOUROPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUSPENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUSPENDOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbFireEquID;
        private AppSvrHMI.L3DataSet dsLadleFireEqu;
        private System.Data.DataTable schemadsLadleFireEqu;
        private System.Data.DataColumn coldsLadleFireEquL3DataTableCode;
    }
}