namespace DispatchMag
{
    partial class DispExceptionalFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispExceptionalFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.cmdpMain = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableIDObject = new System.Data.DataColumn();
            this.coldsMainL3DataTableCreateDate = new System.Data.DataColumn();
            this.coldsMainL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShift = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeam = new System.Data.DataColumn();
            this.coldsMainL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSendFlag = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetail = new AppSvrHMI.L3DataSet();
            this.cmdDetail = new AppSvrHMI.L3Command(this.components);
            this.cmdpDetail = new AppSvrHMI.L3CommandParameter();
            this.schemadsDetail = new System.Data.DataTable();
            this.coldsDetailL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDetailL3DataTableName = new System.Data.DataColumn();
            this.coldsDetailL3DataTableIDObject = new System.Data.DataColumn();
            this.coldsDetailL3DataTableItems = new System.Data.DataColumn();
            this.coldsDetailL3DataTableBeginTime = new System.Data.DataColumn();
            this.coldsDetailL3DataTableEndTime = new System.Data.DataColumn();
            this.coldsDetailL3DataTableTimeSpan = new System.Data.DataColumn();
            this.coldsDetailL3DataTableNote = new System.Data.DataColumn();
            this.coldsDetailL3DataTableCreateTime = new System.Data.DataColumn();
            this.AcoldsDetailL3DataTableUnitID = new System.Data.DataColumn();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.IDObject_Main = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsUnitID1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTablepk_center = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTablecenter_name = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTablecenter_code = new System.Data.DataColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsShiftNC = new System.Windows.Forms.BindingSource(this.components);
            this.dsShiftNC = new AppSvrHMI.L3DataSet();
            this.schemadsShiftNC = new System.Data.DataTable();
            this.coldsShiftNCL3DataTablepk_shift = new System.Data.DataColumn();
            this.coldsShiftNCL3DataTableshift_code = new System.Data.DataColumn();
            this.coldsShiftNCL3DataTableshift_name = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsTeamNC = new System.Windows.Forms.BindingSource(this.components);
            this.dsTeamNC = new AppSvrHMI.L3DataSet();
            this.schemadsTeamNC = new System.Data.DataTable();
            this.coldsTeamNCL3DataTablepk_team = new System.Data.DataColumn();
            this.coldsTeamNCL3DataTableteam_code = new System.Data.DataColumn();
            this.coldsTeamNCL3DataTableteam_name = new System.Data.DataColumn();
            this.coldsTeamNCL3DataTablepk_center = new System.Data.DataColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvDetail = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsUnitID2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsException = new AppSvrHMI.L3DataSet();
            this.schemadsException = new System.Data.DataTable();
            this.coldsExceptionL3DataTablePk_Exception = new System.Data.DataColumn();
            this.coldsExceptionL3DataTableException_Name = new System.Data.DataColumn();
            this.beginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdNP = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDelDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmDetail = new System.Windows.Forms.ToolStripButton();
            this.btnCancelDetail = new System.Windows.Forms.ToolStripButton();
            this.tSpM = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAddMainAll = new System.Windows.Forms.ToolStripButton();
            this.btnAddMain = new System.Windows.Forms.ToolStripButton();
            this.btnDelMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirmMain = new System.Windows.Forms.ToolStripButton();
            this.btnCancelMain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMainDataToNC = new System.Windows.Forms.ToolStripButton();
            this.btnSend = new System.Windows.Forms.ToolStripButton();
            this.bnMain = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbUnitID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.cmbShiftID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.dsItems = new AppSvrHMI.L3DataSet();
            this.schemadsItems = new System.Data.DataTable();
            this.coldsItemsL3DataTablepk_exception = new System.Data.DataColumn();
            this.coldsItemsL3DataTableexception_code = new System.Data.DataColumn();
            this.coldsItemsL3DataTableexception_name = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.coldsDetailL3DataTableUnitID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeamNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamNC)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsException)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsException)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdNP)).BeginInit();
            this.bdNP.SuspendLayout();
            this.tSpM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).BeginInit();
            this.bnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Enabled = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(23, 22);
            this.toolStripLabel2.Text = "/ 0";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(73, 22);
            this.toolStripLabel4.Text = " ****信息 ";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel5.Text = "  ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 43);
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            this.bsMain.CurrentChanged += new System.EventHandler(this.bsMain_CurrentChanged);
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "DeleteDisExceptional";
            this.dsMain.InsertMethod = "AddDisExceptional";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = this.cmdMain;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "GetDispExceData";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMain.SourceURI = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = null;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = null;
            this.cmdMain.Object = null;
            this.cmdMain.Parameters.Add(this.cmdpMain);
            this.cmdMain.ReturnTarget = null;
            this.cmdMain.ReturnTargetProperty = null;
            this.cmdMain.Trigger = null;
            this.cmdMain.TriggerEvent = "Click";
            // 
            // cmdpMain
            // 
            this.cmdpMain.AcceptAfterExecuted = false;
            this.cmdpMain.ConstantValue = null;
            this.cmdpMain.MergeTarget = false;
            this.cmdpMain.SourceFilter = null;
            this.cmdpMain.SourceObject = null;
            this.cmdpMain.SourceProperty = null;
            this.cmdpMain.TargetObject = null;
            this.cmdpMain.TargetProperty = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableIDObject,
            this.coldsMainL3DataTableCreateDate,
            this.coldsMainL3DataTableUnitID,
            this.coldsMainL3DataTableShift,
            this.coldsMainL3DataTableTeam,
            this.coldsMainL3DataTableCreateTime,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableSendFlag});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.DefaultValue = "";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableName
            // 
            this.coldsMainL3DataTableName.Caption = "NAME";
            this.coldsMainL3DataTableName.ColumnName = "Name";
            this.coldsMainL3DataTableName.DefaultValue = "";
            this.coldsMainL3DataTableName.Namespace = "";
            // 
            // coldsMainL3DataTableIDObject
            // 
            this.coldsMainL3DataTableIDObject.Caption = "IDOBJECT";
            this.coldsMainL3DataTableIDObject.ColumnName = "IDObject";
            this.coldsMainL3DataTableIDObject.DefaultValue = "";
            this.coldsMainL3DataTableIDObject.Namespace = "";
            // 
            // coldsMainL3DataTableCreateDate
            // 
            this.coldsMainL3DataTableCreateDate.Caption = "CREATEDATE";
            this.coldsMainL3DataTableCreateDate.ColumnName = "CreateDate";
            this.coldsMainL3DataTableCreateDate.DefaultValue = "";
            this.coldsMainL3DataTableCreateDate.Namespace = "";
            // 
            // coldsMainL3DataTableUnitID
            // 
            this.coldsMainL3DataTableUnitID.Caption = "UNITID";
            this.coldsMainL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsMainL3DataTableUnitID.DefaultValue = "";
            this.coldsMainL3DataTableUnitID.Namespace = "";
            // 
            // coldsMainL3DataTableShift
            // 
            this.coldsMainL3DataTableShift.Caption = "SHIFT";
            this.coldsMainL3DataTableShift.ColumnName = "Shift";
            this.coldsMainL3DataTableShift.DefaultValue = "";
            this.coldsMainL3DataTableShift.Namespace = "";
            // 
            // coldsMainL3DataTableTeam
            // 
            this.coldsMainL3DataTableTeam.Caption = "TEAM";
            this.coldsMainL3DataTableTeam.ColumnName = "Team";
            this.coldsMainL3DataTableTeam.DefaultValue = "";
            this.coldsMainL3DataTableTeam.Namespace = "";
            // 
            // coldsMainL3DataTableCreateTime
            // 
            this.coldsMainL3DataTableCreateTime.Caption = "CREATETIME";
            this.coldsMainL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsMainL3DataTableCreateTime.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "OPERATOR";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.DefaultValue = "";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // coldsMainL3DataTableSendFlag
            // 
            this.coldsMainL3DataTableSendFlag.Caption = "SENDFLAG";
            this.coldsMainL3DataTableSendFlag.ColumnName = "SendFlag";
            this.coldsMainL3DataTableSendFlag.DataType = typeof(int);
            this.coldsMainL3DataTableSendFlag.DefaultValue = 0;
            this.coldsMainL3DataTableSendFlag.Namespace = "";
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
            // bsDetail
            // 
            this.bsDetail.DataMember = "L3DataTable";
            this.bsDetail.DataSource = this.dsDetail;
            // 
            // dsDetail
            // 
            this.dsDetail.AutoLoad = true;
            this.dsDetail.AutoSubscribe = true;
            this.dsDetail.DataSetName = "L3DataSet";
            this.dsDetail.DeleteMethod = "DelDisExceptionalItems";
            this.dsDetail.InsertMethod = "AddDisExceptionalItems";
            this.dsDetail.L3DataAdapter = this.Adapter;
            this.dsDetail.LoadEvent = "";
            this.dsDetail.LoadTrigger = null;
            this.dsDetail.RefreshValve = 1000;
            this.dsDetail.SourceCommand = this.cmdDetail;
            this.dsDetail.SourceCondition = "";
            this.dsDetail.SourceMethod = "GetDispExceItemData";
            this.dsDetail.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsDetail.SourceURI = "XGMESLogic\\DispatchMag\\CDispatch_Mag\\Dispatch_Mag";
            this.dsDetail.SubscribeTarget = "";
            this.dsDetail.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDetail});
            this.dsDetail.UpdateEvent = "";
            this.dsDetail.UpdateMethod = "ModifyDisExceptionalItems";
            this.dsDetail.UpdateTrigger = null;
            // 
            // cmdDetail
            // 
            this.cmdDetail.Adapter = null;
            this.cmdDetail.MergeReturnTarget = false;
            this.cmdDetail.Method = null;
            this.cmdDetail.Object = null;
            this.cmdDetail.Parameters.Add(this.cmdpDetail);
            this.cmdDetail.ReturnTarget = null;
            this.cmdDetail.ReturnTargetProperty = null;
            this.cmdDetail.Trigger = null;
            this.cmdDetail.TriggerEvent = "Click";
            // 
            // cmdpDetail
            // 
            this.cmdpDetail.AcceptAfterExecuted = false;
            this.cmdpDetail.ConstantValue = null;
            this.cmdpDetail.MergeTarget = false;
            this.cmdpDetail.SourceFilter = null;
            this.cmdpDetail.SourceObject = null;
            this.cmdpDetail.SourceProperty = null;
            this.cmdpDetail.TargetObject = null;
            this.cmdpDetail.TargetProperty = null;
            // 
            // schemadsDetail
            // 
            this.schemadsDetail.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDetailL3DataTableGUID,
            this.coldsDetailL3DataTableName,
            this.coldsDetailL3DataTableIDObject,
            this.coldsDetailL3DataTableItems,
            this.coldsDetailL3DataTableBeginTime,
            this.coldsDetailL3DataTableEndTime,
            this.coldsDetailL3DataTableTimeSpan,
            this.coldsDetailL3DataTableNote,
            this.coldsDetailL3DataTableCreateTime,
            this.AcoldsDetailL3DataTableUnitID});
            this.schemadsDetail.TableName = "L3DataTable";
            // 
            // coldsDetailL3DataTableGUID
            // 
            this.coldsDetailL3DataTableGUID.Caption = "GUID";
            this.coldsDetailL3DataTableGUID.ColumnName = "GUID";
            this.coldsDetailL3DataTableGUID.DefaultValue = "";
            this.coldsDetailL3DataTableGUID.Namespace = "";
            // 
            // coldsDetailL3DataTableName
            // 
            this.coldsDetailL3DataTableName.Caption = "NAME";
            this.coldsDetailL3DataTableName.ColumnName = "Name";
            this.coldsDetailL3DataTableName.DefaultValue = "";
            this.coldsDetailL3DataTableName.Namespace = "";
            // 
            // coldsDetailL3DataTableIDObject
            // 
            this.coldsDetailL3DataTableIDObject.Caption = "IDOBJECT";
            this.coldsDetailL3DataTableIDObject.ColumnName = "IDObject";
            this.coldsDetailL3DataTableIDObject.DefaultValue = "";
            this.coldsDetailL3DataTableIDObject.Namespace = "";
            // 
            // coldsDetailL3DataTableItems
            // 
            this.coldsDetailL3DataTableItems.Caption = "ITEMS";
            this.coldsDetailL3DataTableItems.ColumnName = "Items";
            this.coldsDetailL3DataTableItems.DefaultValue = "";
            this.coldsDetailL3DataTableItems.Namespace = "";
            // 
            // coldsDetailL3DataTableBeginTime
            // 
            this.coldsDetailL3DataTableBeginTime.Caption = "BEGINTIME";
            this.coldsDetailL3DataTableBeginTime.ColumnName = "BeginTime";
            this.coldsDetailL3DataTableBeginTime.Namespace = "";
            // 
            // coldsDetailL3DataTableEndTime
            // 
            this.coldsDetailL3DataTableEndTime.Caption = "ENDTIME";
            this.coldsDetailL3DataTableEndTime.ColumnName = "EndTime";
            this.coldsDetailL3DataTableEndTime.Namespace = "";
            // 
            // coldsDetailL3DataTableTimeSpan
            // 
            this.coldsDetailL3DataTableTimeSpan.Caption = "TIMESPAN";
            this.coldsDetailL3DataTableTimeSpan.ColumnName = "TimeSpan";
            this.coldsDetailL3DataTableTimeSpan.DataType = typeof(int);
            this.coldsDetailL3DataTableTimeSpan.DefaultValue = 0;
            this.coldsDetailL3DataTableTimeSpan.Namespace = "";
            // 
            // coldsDetailL3DataTableNote
            // 
            this.coldsDetailL3DataTableNote.Caption = "NOTE";
            this.coldsDetailL3DataTableNote.ColumnName = "Note";
            this.coldsDetailL3DataTableNote.DefaultValue = "";
            this.coldsDetailL3DataTableNote.Namespace = "";
            // 
            // coldsDetailL3DataTableCreateTime
            // 
            this.coldsDetailL3DataTableCreateTime.Caption = "CREATETIME";
            this.coldsDetailL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsDetailL3DataTableCreateTime.Namespace = "";
            // 
            // AcoldsDetailL3DataTableUnitID
            // 
            this.AcoldsDetailL3DataTableUnitID.Caption = "UnitID";
            this.AcoldsDetailL3DataTableUnitID.ColumnName = "UnitID";
            this.AcoldsDetailL3DataTableUnitID.Namespace = "";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tableLayoutPanel1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 700);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dvMain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tSpM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bnMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 700);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDObject_Main,
            this.createDateDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.sendFlagDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(3, 71);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMain.Size = new System.Drawing.Size(994, 275);
            this.dvMain.TabIndex = 28;
            this.dvMain.Sorted += new System.EventHandler(this.dvMain_Sorted);
            this.dvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvMain_CellMouseDoubleClick);
            this.dvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
            this.dvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvMain_DataBindingComplete);
            // 
            // IDObject_Main
            // 
            this.IDObject_Main.DataPropertyName = "IDObject";
            this.IDObject_Main.HeaderText = "主键";
            this.IDObject_Main.Name = "IDObject_Main";
            this.IDObject_Main.ReadOnly = true;
            this.IDObject_Main.Visible = false;
            this.IDObject_Main.Width = 54;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 54;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.DataSource = this.bsUnitID1;
            this.unitIDDataGridViewTextBoxColumn.DisplayMember = "center_code";
            this.unitIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工作中心";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIDDataGridViewTextBoxColumn.ValueMember = "pk_center";
            this.unitIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // bsUnitID1
            // 
            this.bsUnitID1.DataMember = "L3DataTable";
            this.bsUnitID1.DataSource = this.dsUnitID;
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoLoad = true;
            this.dsUnitID.AutoSubscribe = false;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsUnitID.SourceURI = "";
            this.dsUnitID.SubscribeTarget = "";
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTablepk_center,
            this.coldsUnitIDL3DataTablecenter_name,
            this.coldsUnitIDL3DataTablecenter_code});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTablepk_center
            // 
            this.coldsUnitIDL3DataTablepk_center.Caption = "pk_center";
            this.coldsUnitIDL3DataTablepk_center.ColumnName = "pk_center";
            this.coldsUnitIDL3DataTablepk_center.Namespace = "";
            // 
            // coldsUnitIDL3DataTablecenter_name
            // 
            this.coldsUnitIDL3DataTablecenter_name.Caption = "center_name";
            this.coldsUnitIDL3DataTablecenter_name.ColumnName = "center_name";
            this.coldsUnitIDL3DataTablecenter_name.Namespace = "";
            // 
            // coldsUnitIDL3DataTablecenter_code
            // 
            this.coldsUnitIDL3DataTablecenter_code.Caption = "center_code";
            this.coldsUnitIDL3DataTablecenter_code.ColumnName = "center_code";
            this.coldsUnitIDL3DataTablecenter_code.Namespace = "";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.bsShiftNC;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "shift_name";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "pk_shift";
            this.shiftDataGridViewTextBoxColumn.Width = 54;
            // 
            // bsShiftNC
            // 
            this.bsShiftNC.DataMember = "L3DataTable";
            this.bsShiftNC.DataSource = this.dsShiftNC;
            // 
            // dsShiftNC
            // 
            this.dsShiftNC.AutoLoad = true;
            this.dsShiftNC.AutoSubscribe = false;
            this.dsShiftNC.DataSetName = "L3DataSet";
            this.dsShiftNC.DeleteMethod = "";
            this.dsShiftNC.InsertMethod = "";
            this.dsShiftNC.L3DataAdapter = this.Adapter;
            this.dsShiftNC.LoadEvent = "";
            this.dsShiftNC.LoadTrigger = null;
            this.dsShiftNC.RefreshValve = 1000;
            this.dsShiftNC.SourceCommand = null;
            this.dsShiftNC.SourceCondition = "";
            this.dsShiftNC.SourceMethod = "";
            this.dsShiftNC.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsShiftNC.SourceURI = "";
            this.dsShiftNC.SubscribeTarget = "";
            this.dsShiftNC.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftNC});
            this.dsShiftNC.UpdateEvent = "";
            this.dsShiftNC.UpdateMethod = "";
            this.dsShiftNC.UpdateTrigger = null;
            // 
            // schemadsShiftNC
            // 
            this.schemadsShiftNC.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftNCL3DataTablepk_shift,
            this.coldsShiftNCL3DataTableshift_code,
            this.coldsShiftNCL3DataTableshift_name});
            this.schemadsShiftNC.TableName = "L3DataTable";
            // 
            // coldsShiftNCL3DataTablepk_shift
            // 
            this.coldsShiftNCL3DataTablepk_shift.Caption = "pk_shift";
            this.coldsShiftNCL3DataTablepk_shift.ColumnName = "pk_shift";
            this.coldsShiftNCL3DataTablepk_shift.Namespace = "";
            // 
            // coldsShiftNCL3DataTableshift_code
            // 
            this.coldsShiftNCL3DataTableshift_code.Caption = "shift_code";
            this.coldsShiftNCL3DataTableshift_code.ColumnName = "shift_code";
            this.coldsShiftNCL3DataTableshift_code.Namespace = "";
            // 
            // coldsShiftNCL3DataTableshift_name
            // 
            this.coldsShiftNCL3DataTableshift_name.Caption = "shift_name";
            this.coldsShiftNCL3DataTableshift_name.ColumnName = "shift_name";
            this.coldsShiftNCL3DataTableshift_name.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.bsTeamNC;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "team_name";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "pk_team";
            this.teamDataGridViewTextBoxColumn.Width = 54;
            // 
            // bsTeamNC
            // 
            this.bsTeamNC.DataMember = "L3DataTable";
            this.bsTeamNC.DataSource = this.dsTeamNC;
            // 
            // dsTeamNC
            // 
            this.dsTeamNC.AutoLoad = true;
            this.dsTeamNC.AutoSubscribe = false;
            this.dsTeamNC.DataSetName = "L3DataSet";
            this.dsTeamNC.DeleteMethod = "";
            this.dsTeamNC.InsertMethod = "";
            this.dsTeamNC.L3DataAdapter = this.Adapter;
            this.dsTeamNC.LoadEvent = "";
            this.dsTeamNC.LoadTrigger = null;
            this.dsTeamNC.RefreshValve = 1000;
            this.dsTeamNC.SourceCommand = null;
            this.dsTeamNC.SourceCondition = "";
            this.dsTeamNC.SourceMethod = "";
            this.dsTeamNC.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsTeamNC.SourceURI = "";
            this.dsTeamNC.SubscribeTarget = "";
            this.dsTeamNC.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamNC});
            this.dsTeamNC.UpdateEvent = "";
            this.dsTeamNC.UpdateMethod = "";
            this.dsTeamNC.UpdateTrigger = null;
            // 
            // schemadsTeamNC
            // 
            this.schemadsTeamNC.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamNCL3DataTablepk_team,
            this.coldsTeamNCL3DataTableteam_code,
            this.coldsTeamNCL3DataTableteam_name,
            this.coldsTeamNCL3DataTablepk_center});
            this.schemadsTeamNC.TableName = "L3DataTable";
            // 
            // coldsTeamNCL3DataTablepk_team
            // 
            this.coldsTeamNCL3DataTablepk_team.Caption = "pk_team";
            this.coldsTeamNCL3DataTablepk_team.ColumnName = "pk_team";
            this.coldsTeamNCL3DataTablepk_team.Namespace = "";
            // 
            // coldsTeamNCL3DataTableteam_code
            // 
            this.coldsTeamNCL3DataTableteam_code.Caption = "team_code";
            this.coldsTeamNCL3DataTableteam_code.ColumnName = "team_code";
            this.coldsTeamNCL3DataTableteam_code.Namespace = "";
            // 
            // coldsTeamNCL3DataTableteam_name
            // 
            this.coldsTeamNCL3DataTableteam_name.Caption = "team_name";
            this.coldsTeamNCL3DataTableteam_name.ColumnName = "team_name";
            this.coldsTeamNCL3DataTableteam_name.Namespace = "";
            // 
            // coldsTeamNCL3DataTablepk_center
            // 
            this.coldsTeamNCL3DataTablepk_center.Caption = "pk_center";
            this.coldsTeamNCL3DataTablepk_center.ColumnName = "pk_center";
            this.coldsTeamNCL3DataTablepk_center.Namespace = "";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时间";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作者";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // sendFlagDataGridViewTextBoxColumn
            // 
            this.sendFlagDataGridViewTextBoxColumn.DataPropertyName = "SendFlag";
            this.sendFlagDataGridViewTextBoxColumn.HeaderText = "上传NC标志";
            this.sendFlagDataGridViewTextBoxColumn.Name = "sendFlagDataGridViewTextBoxColumn";
            this.sendFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.sendFlagDataGridViewTextBoxColumn.Visible = false;
            this.sendFlagDataGridViewTextBoxColumn.Width = 90;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 349);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 351);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvDetail);
            this.tabPage1.Controls.Add(this.bdNP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(992, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "详细信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvDetail
            // 
            this.dvDetail.AllowUserToAddRows = false;
            this.dvDetail.AutoGenerateColumns = false;
            this.dvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.iDObjectDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn1,
            this.unitIDDataGridViewTextBoxColumn1,
            this.itemsDataGridViewTextBoxColumn,
            this.beginTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.timeSpanDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dvDetail.DataSource = this.bsDetail;
            this.dvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDetail.Location = new System.Drawing.Point(0, 25);
            this.dvDetail.Margin = new System.Windows.Forms.Padding(0);
            this.dvDetail.Name = "dvDetail";
            this.dvDetail.ReadOnly = true;
            this.dvDetail.RowTemplate.Height = 23;
            this.dvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDetail.Size = new System.Drawing.Size(992, 300);
            this.dvDetail.TabIndex = 24;
            this.dvDetail.Sorted += new System.EventHandler(this.dvDetail_Sorted);
            this.dvDetail.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvDetail_CellMouseDoubleClick);
            this.dvDetail.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDetail_DataError);
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
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            this.nameDataGridViewTextBoxColumn1.Width = 54;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "IDObject";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "IDObject";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            this.iDObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDObjectDataGridViewTextBoxColumn.Visible = false;
            this.iDObjectDataGridViewTextBoxColumn.Width = 78;
            // 
            // createTimeDataGridViewTextBoxColumn1
            // 
            this.createTimeDataGridViewTextBoxColumn1.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn1.HeaderText = "创建时间";
            this.createTimeDataGridViewTextBoxColumn1.Name = "createTimeDataGridViewTextBoxColumn1";
            this.createTimeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // unitIDDataGridViewTextBoxColumn1
            // 
            this.unitIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.DataSource = this.bsUnitID2;
            this.unitIDDataGridViewTextBoxColumn1.DisplayMember = "center_code";
            this.unitIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIDDataGridViewTextBoxColumn1.HeaderText = "工作中心";
            this.unitIDDataGridViewTextBoxColumn1.Name = "unitIDDataGridViewTextBoxColumn1";
            this.unitIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIDDataGridViewTextBoxColumn1.ValueMember = "pk_center";
            this.unitIDDataGridViewTextBoxColumn1.Width = 78;
            // 
            // bsUnitID2
            // 
            this.bsUnitID2.DataMember = "L3DataTable";
            this.bsUnitID2.DataSource = this.dsUnitID;
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.DataSource = this.dsException;
            this.itemsDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Exception_Name";
            this.itemsDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemsDataGridViewTextBoxColumn.HeaderText = "异常项目";
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemsDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Exception";
            this.itemsDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsException
            // 
            this.dsException.AutoLoad = true;
            this.dsException.AutoSubscribe = false;
            this.dsException.DataSetName = "L3DataSet";
            this.dsException.DeleteMethod = "";
            this.dsException.InsertMethod = "";
            this.dsException.L3DataAdapter = this.Adapter;
            this.dsException.LoadEvent = "";
            this.dsException.LoadTrigger = null;
            this.dsException.RefreshValve = 1000;
            this.dsException.SourceCommand = null;
            this.dsException.SourceCondition = "";
            this.dsException.SourceMethod = "";
            this.dsException.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsException.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Excep_Infor";
            this.dsException.SubscribeTarget = "";
            this.dsException.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsException});
            this.dsException.UpdateEvent = "";
            this.dsException.UpdateMethod = "";
            this.dsException.UpdateTrigger = null;
            // 
            // schemadsException
            // 
            this.schemadsException.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptionL3DataTablePk_Exception,
            this.coldsExceptionL3DataTableException_Name});
            this.schemadsException.TableName = "L3DataTable";
            // 
            // coldsExceptionL3DataTablePk_Exception
            // 
            this.coldsExceptionL3DataTablePk_Exception.Caption = "Pk_Exception";
            this.coldsExceptionL3DataTablePk_Exception.ColumnName = "Pk_Exception";
            this.coldsExceptionL3DataTablePk_Exception.Namespace = "";
            // 
            // coldsExceptionL3DataTableException_Name
            // 
            this.coldsExceptionL3DataTableException_Name.Caption = "Exception_Name";
            this.coldsExceptionL3DataTableException_Name.ColumnName = "Exception_Name";
            this.coldsExceptionL3DataTableException_Name.Namespace = "";
            // 
            // beginTimeDataGridViewTextBoxColumn
            // 
            this.beginTimeDataGridViewTextBoxColumn.DataPropertyName = "BeginTime";
            this.beginTimeDataGridViewTextBoxColumn.HeaderText = "开始时刻";
            this.beginTimeDataGridViewTextBoxColumn.Name = "beginTimeDataGridViewTextBoxColumn";
            this.beginTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.beginTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "结束时刻";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // timeSpanDataGridViewTextBoxColumn
            // 
            this.timeSpanDataGridViewTextBoxColumn.DataPropertyName = "TimeSpan";
            this.timeSpanDataGridViewTextBoxColumn.HeaderText = "TimeSpan";
            this.timeSpanDataGridViewTextBoxColumn.Name = "timeSpanDataGridViewTextBoxColumn";
            this.timeSpanDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeSpanDataGridViewTextBoxColumn.Visible = false;
            this.timeSpanDataGridViewTextBoxColumn.Width = 78;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 54;
            // 
            // bdNP
            // 
            this.bdNP.AddNewItem = null;
            this.bdNP.AutoSize = false;
            this.bdNP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdNP.BackgroundImage")));
            this.bdNP.BindingSource = this.bsDetail;
            this.bdNP.CountItem = null;
            this.bdNP.DeleteItem = null;
            this.bdNP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDetail,
            this.btnDelDetail,
            this.toolStripSeparator5,
            this.btnConfirmDetail,
            this.btnCancelDetail});
            this.bdNP.Location = new System.Drawing.Point(0, 0);
            this.bdNP.MoveFirstItem = null;
            this.bdNP.MoveLastItem = null;
            this.bdNP.MoveNextItem = null;
            this.bdNP.MovePreviousItem = null;
            this.bdNP.Name = "bdNP";
            this.bdNP.Padding = new System.Windows.Forms.Padding(0);
            this.bdNP.PositionItem = null;
            this.bdNP.Size = new System.Drawing.Size(992, 25);
            this.bdNP.TabIndex = 22;
            this.bdNP.Text = "bindingNavigator2";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDetail.Image")));
            this.btnAddDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(52, 22);
            this.btnAddDetail.Text = "新增";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnDelDetail
            // 
            this.btnDelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnDelDetail.Image")));
            this.btnDelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelDetail.Name = "btnDelDetail";
            this.btnDelDetail.Size = new System.Drawing.Size(52, 22);
            this.btnDelDetail.Text = "删除";
            this.btnDelDetail.Click += new System.EventHandler(this.btnDelDetail_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnConfirmDetail
            // 
            this.btnConfirmDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmDetail.Image")));
            this.btnConfirmDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmDetail.Name = "btnConfirmDetail";
            this.btnConfirmDetail.Size = new System.Drawing.Size(56, 22);
            this.btnConfirmDetail.Text = "确定 ";
            this.btnConfirmDetail.Click += new System.EventHandler(this.btnConfirmDetail_Click);
            // 
            // btnCancelDetail
            // 
            this.btnCancelDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDetail.Image")));
            this.btnCancelDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelDetail.Name = "btnCancelDetail";
            this.btnCancelDetail.Size = new System.Drawing.Size(52, 22);
            this.btnCancelDetail.Text = "取消";
            this.btnCancelDetail.Click += new System.EventHandler(this.btnCancelDetail_Click);
            // 
            // tSpM
            // 
            this.tSpM.AutoSize = false;
            this.tSpM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSpM.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSpM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAddMainAll,
            this.btnAddMain,
            this.btnDelMain,
            this.toolStripSeparator10,
            this.btnConfirmMain,
            this.btnCancelMain,
            this.toolStripSeparator1,
            this.btnMainDataToNC,
            this.btnSend});
            this.tSpM.Location = new System.Drawing.Point(0, 0);
            this.tSpM.Name = "tSpM";
            this.tSpM.Size = new System.Drawing.Size(1000, 43);
            this.tSpM.TabIndex = 15;
            this.tSpM.Text = "toolStrip1";
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
            // btnAddMainAll
            // 
            this.btnAddMainAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMainAll.Image")));
            this.btnAddMainAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMainAll.Name = "btnAddMainAll";
            this.btnAddMainAll.Size = new System.Drawing.Size(92, 40);
            this.btnAddMainAll.Text = "完全新增";
            this.btnAddMainAll.Click += new System.EventHandler(this.btnAddMainAll_Click);
            // 
            // btnAddMain
            // 
            this.btnAddMain.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMain.Image")));
            this.btnAddMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMain.Name = "btnAddMain";
            this.btnAddMain.Size = new System.Drawing.Size(68, 40);
            this.btnAddMain.Text = "新增";
            this.btnAddMain.Visible = false;
            this.btnAddMain.Click += new System.EventHandler(this.btnAddMain_Click);
            // 
            // btnDelMain
            // 
            this.btnDelMain.Image = ((System.Drawing.Image)(resources.GetObject("btnDelMain.Image")));
            this.btnDelMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelMain.Name = "btnDelMain";
            this.btnDelMain.Size = new System.Drawing.Size(68, 40);
            this.btnDelMain.Text = "删除";
            this.btnDelMain.Click += new System.EventHandler(this.btnDelMain_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirmMain
            // 
            this.btnConfirmMain.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmMain.Image")));
            this.btnConfirmMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmMain.Name = "btnConfirmMain";
            this.btnConfirmMain.Size = new System.Drawing.Size(68, 40);
            this.btnConfirmMain.Text = "确定";
            this.btnConfirmMain.Click += new System.EventHandler(this.btnConfirmMain_Click);
            // 
            // btnCancelMain
            // 
            this.btnCancelMain.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelMain.Image")));
            this.btnCancelMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelMain.Name = "btnCancelMain";
            this.btnCancelMain.Size = new System.Drawing.Size(68, 40);
            this.btnCancelMain.Text = "取消";
            this.btnCancelMain.Click += new System.EventHandler(this.btnCancelMain_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnMainDataToNC
            // 
            this.btnMainDataToNC.Image = ((System.Drawing.Image)(resources.GetObject("btnMainDataToNC.Image")));
            this.btnMainDataToNC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMainDataToNC.Name = "btnMainDataToNC";
            this.btnMainDataToNC.Size = new System.Drawing.Size(134, 40);
            this.btnMainDataToNC.Text = "发送全数据到NC";
            this.btnMainDataToNC.Click += new System.EventHandler(this.btnMainDataToNC_Click);
            // 
            // btnSend
            // 
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 40);
            this.btnSend.Text = "发送到NC";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bnMain
            // 
            this.bnMain.AddNewItem = null;
            this.bnMain.AutoSize = false;
            this.bnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnMain.BackgroundImage")));
            this.bnMain.BindingSource = this.bsMain;
            this.bnMain.CountItem = this.bindingNavigatorCountItem;
            this.bnMain.DeleteItem = null;
            this.bnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel6,
            this.cmbUnitID,
            this.toolStripLabel7,
            this.cmbShiftID,
            this.toolStripLabel10,
            this.dtStart,
            this.toolStripLabel9});
            this.bnMain.Location = new System.Drawing.Point(0, 43);
            this.bnMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnMain.Name = "bnMain";
            this.bnMain.PositionItem = this.bindingNavigatorPositionItem;
            this.bnMain.Size = new System.Drawing.Size(1000, 25);
            this.bnMain.TabIndex = 22;
            this.bnMain.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel3.Text = "主实绩";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(130, 25);
            this.cmbUnitID.Visible = false;
            this.cmbUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbUnitID_SelectedIndexChanged);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "工作中心:";
            this.toolStripLabel7.Visible = false;
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(100, 25);
            this.cmbShiftID.SelectedIndexChanged += new System.EventHandler(this.cmbShiftID_SelectedIndexChanged);
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel10.Text = "班次:";
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
            // toolStripLabel9
            // 
            this.toolStripLabel9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel9.Text = "日期:";
            // 
            // dsItems
            // 
            this.dsItems.AutoLoad = true;
            this.dsItems.AutoSubscribe = false;
            this.dsItems.DataSetName = "L3DataSet";
            this.dsItems.DeleteMethod = "";
            this.dsItems.InsertMethod = "";
            this.dsItems.L3DataAdapter = this.Adapter;
            this.dsItems.LoadEvent = "";
            this.dsItems.LoadTrigger = null;
            this.dsItems.RefreshValve = 1000;
            this.dsItems.SourceCommand = null;
            this.dsItems.SourceCondition = "";
            this.dsItems.SourceMethod = "";
            this.dsItems.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsItems.SourceURI = "";
            this.dsItems.SubscribeTarget = "";
            this.dsItems.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsItems});
            this.dsItems.UpdateEvent = "";
            this.dsItems.UpdateMethod = "";
            this.dsItems.UpdateTrigger = null;
            // 
            // schemadsItems
            // 
            this.schemadsItems.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsItemsL3DataTablepk_exception,
            this.coldsItemsL3DataTableexception_code,
            this.coldsItemsL3DataTableexception_name});
            this.schemadsItems.TableName = "L3DataTable";
            // 
            // coldsItemsL3DataTablepk_exception
            // 
            this.coldsItemsL3DataTablepk_exception.Caption = "pk_exception";
            this.coldsItemsL3DataTablepk_exception.ColumnName = "pk_exception";
            this.coldsItemsL3DataTablepk_exception.Namespace = "";
            // 
            // coldsItemsL3DataTableexception_code
            // 
            this.coldsItemsL3DataTableexception_code.Caption = "exception_code";
            this.coldsItemsL3DataTableexception_code.ColumnName = "exception_code";
            this.coldsItemsL3DataTableexception_code.Namespace = "";
            // 
            // coldsItemsL3DataTableexception_name
            // 
            this.coldsItemsL3DataTableexception_name.Caption = "exception_name";
            this.coldsItemsL3DataTableexception_name.ColumnName = "exception_name";
            this.coldsItemsL3DataTableexception_name.Namespace = "";
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
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Enabled = false;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到第一条记录";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到上一条记录";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Enabled = false;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到下一条记录";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Enabled = false;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到最后一条记录";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton1.Text = "退出";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(71, 40);
            this.toolStripButton3.Text = "功能1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton4.Text = "确认";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton5.Text = "取消";
            // 
            // coldsDetailL3DataTableUnitID
            // 
            this.coldsDetailL3DataTableUnitID.Caption = "UnitID";
            this.coldsDetailL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsDetailL3DataTableUnitID.Namespace = "";
            // 
            // DispExceptionalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DispExceptionalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "设备异常管理";
            this.Text = "设备异常管理";
            this.Load += new System.EventHandler(this.DispExceptionalFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DispExceptionalFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDetail)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShiftNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeamNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamNC)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsException)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsException)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdNP)).EndInit();
            this.bdNP.ResumeLayout(false);
            this.bdNP.PerformLayout();
            this.tSpM.ResumeLayout(false);
            this.tSpM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnMain)).EndInit();
            this.bnMain.ResumeLayout(false);
            this.bnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsDetail;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dvMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dvDetail;
        private System.Windows.Forms.BindingNavigator bdNP;
        private System.Windows.Forms.ToolStripButton btnAddDetail;
        private System.Windows.Forms.ToolStripButton btnDelDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirmDetail;
        private System.Windows.Forms.ToolStripButton btnCancelDetail;
        private System.Windows.Forms.ToolStrip tSpM;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAddMain;
        private System.Windows.Forms.ToolStripButton btnDelMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton btnConfirmMain;
        private System.Windows.Forms.ToolStripButton btnCancelMain;
        private System.Windows.Forms.BindingNavigator bnMain;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbUnitID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableIDObject;
        private System.Data.DataColumn coldsMainL3DataTableCreateDate;
        private System.Data.DataColumn coldsMainL3DataTableUnitID;
        private System.Data.DataColumn coldsMainL3DataTableShift;
        private System.Data.DataColumn coldsMainL3DataTableTeam;
        private System.Data.DataColumn coldsMainL3DataTableCreateTime;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableSendFlag;
        private AppSvrHMI.L3DataSet dsDetail;
        private System.Data.DataTable schemadsDetail;
        private System.Data.DataColumn coldsDetailL3DataTableGUID;
        private System.Data.DataColumn coldsDetailL3DataTableName;
        private System.Data.DataColumn coldsDetailL3DataTableIDObject;
        private System.Data.DataColumn coldsDetailL3DataTableItems;
        private System.Data.DataColumn coldsDetailL3DataTableBeginTime;
        private System.Data.DataColumn coldsDetailL3DataTableEndTime;
        private System.Data.DataColumn coldsDetailL3DataTableTimeSpan;
        private System.Data.DataColumn coldsDetailL3DataTableNote;
        private System.Data.DataColumn coldsDetailL3DataTableCreateTime;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTablepk_center;
        private System.Data.DataColumn coldsUnitIDL3DataTablecenter_name;
        private System.Data.DataColumn coldsUnitIDL3DataTablecenter_code;
        private AppSvrHMI.L3DataSet dsShiftNC;
        private AppSvrHMI.L3DataSet dsTeamNC;
        private System.Data.DataTable schemadsShiftNC;
        private System.Data.DataColumn coldsShiftNCL3DataTablepk_shift;
        private System.Data.DataColumn coldsShiftNCL3DataTableshift_code;
        private System.Data.DataColumn coldsShiftNCL3DataTableshift_name;
        private System.Data.DataTable schemadsTeamNC;
        private System.Data.DataColumn coldsTeamNCL3DataTablepk_team;
        private System.Data.DataColumn coldsTeamNCL3DataTableteam_code;
        private System.Data.DataColumn coldsTeamNCL3DataTableteam_name;
        private System.Data.DataColumn coldsTeamNCL3DataTablepk_center;
        private System.Windows.Forms.BindingSource bsShiftNC;
        private System.Windows.Forms.BindingSource bsTeamNC;
        private AppSvrHMI.L3Command cmdMain;
        private AppSvrHMI.L3Command cmdDetail;
        private AppSvrHMI.L3CommandParameter cmdpMain;
        private AppSvrHMI.L3CommandParameter cmdpDetail;
        private System.Windows.Forms.ToolStripButton btnAddMainAll;
        private System.Windows.Forms.ToolStripButton btnSend;
        private AppSvrHMI.L3DataSet dsItems;
        private System.Data.DataTable schemadsItems;
        private System.Data.DataColumn coldsItemsL3DataTablepk_exception;
        private System.Data.DataColumn coldsItemsL3DataTableexception_code;
        private System.Data.DataColumn coldsItemsL3DataTableexception_name;
        private System.Data.DataColumn coldsDetailL3DataTableUnitID;
        private System.Windows.Forms.ToolStripButton btnMainDataToNC;
        private System.Data.DataColumn AcoldsDetailL3DataTableUnitID;
        private System.Windows.Forms.BindingSource bsUnitID1;
        private System.Windows.Forms.BindingSource bsUnitID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDObject_Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsException;
        private System.Data.DataTable schemadsException;
        private System.Data.DataColumn coldsExceptionL3DataTablePk_Exception;
        private System.Data.DataColumn coldsExceptionL3DataTableException_Name;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripComboBox cmbShiftID;
    }
}