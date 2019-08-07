namespace EquipMag.TundishMag
{
    partial class TundishInnerFireMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishInnerFireMagFrm));
            this.bsInnerFire = new System.Windows.Forms.BindingSource(this.components);
            this.dsTundishInnerFire = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsTundishInnerFire = new System.Data.DataTable();
            this.coldsTundishInnerFireL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableName = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Time = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Operator = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableMid_Fire_Time = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableMid_Fire_Operator = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableBig_Fire_Time = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableBig_Fire_Operator = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableClose_Fire_Time = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableClose_Fire_Operator = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableOperator = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableNote = new System.Data.DataColumn();
            this.coldsTundishInnerFireL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.cmdInnerFire = new AppSvrHMI.L3Command(this.components);
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
            this.bnInnerFire = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dvInnerFire = new System.Windows.Forms.DataGridView();
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            this.tundishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallFireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallFireOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midFireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midFireOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bigFireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bigFireOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeFireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeFireOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishInnerFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishInnerFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnInnerFire)).BeginInit();
            this.bnInnerFire.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInnerFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInnerFire
            // 
            this.bsInnerFire.DataMember = "L3DataTable";
            this.bsInnerFire.DataSource = this.dsTundishInnerFire;
            // 
            // dsTundishInnerFire
            // 
            this.dsTundishInnerFire.AutoSubscribe = false;
            this.dsTundishInnerFire.DataSetName = "L3DataSet";
            this.dsTundishInnerFire.DeleteMethod = "";
            this.dsTundishInnerFire.InsertMethod = "";
            this.dsTundishInnerFire.L3DataAdapter = this.Adapter;
            this.dsTundishInnerFire.LoadEvent = "";
            this.dsTundishInnerFire.LoadTrigger = null;
            this.dsTundishInnerFire.RefreshValve = 1000;
            this.dsTundishInnerFire.SourceCommand = null;
            this.dsTundishInnerFire.SourceCondition = "1=2";
            this.dsTundishInnerFire.SourceMethod = "";
            this.dsTundishInnerFire.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishInnerFire.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Inner_Fire";
            this.dsTundishInnerFire.SubscribeTarget = null;
            this.dsTundishInnerFire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundishInnerFire});
            this.dsTundishInnerFire.UpdateEvent = "";
            this.dsTundishInnerFire.UpdateMethod = "";
            this.dsTundishInnerFire.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsTundishInnerFire
            // 
            this.schemadsTundishInnerFire.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishInnerFireL3DataTableGUID,
            this.coldsTundishInnerFireL3DataTableName,
            this.coldsTundishInnerFireL3DataTableTundishID,
            this.coldsTundishInnerFireL3DataTableInnerID,
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Time,
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Operator,
            this.coldsTundishInnerFireL3DataTableMid_Fire_Time,
            this.coldsTundishInnerFireL3DataTableMid_Fire_Operator,
            this.coldsTundishInnerFireL3DataTableBig_Fire_Time,
            this.coldsTundishInnerFireL3DataTableBig_Fire_Operator,
            this.coldsTundishInnerFireL3DataTableClose_Fire_Time,
            this.coldsTundishInnerFireL3DataTableClose_Fire_Operator,
            this.coldsTundishInnerFireL3DataTableTeamID,
            this.coldsTundishInnerFireL3DataTableShiftID,
            this.coldsTundishInnerFireL3DataTableOperator,
            this.coldsTundishInnerFireL3DataTableNote,
            this.coldsTundishInnerFireL3DataTableConfirm_Flag});
            this.schemadsTundishInnerFire.TableName = "L3DataTable";
            // 
            // coldsTundishInnerFireL3DataTableGUID
            // 
            this.coldsTundishInnerFireL3DataTableGUID.Caption = "GUID";
            this.coldsTundishInnerFireL3DataTableGUID.ColumnName = "GUID";
            this.coldsTundishInnerFireL3DataTableGUID.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableName
            // 
            this.coldsTundishInnerFireL3DataTableName.Caption = "Name";
            this.coldsTundishInnerFireL3DataTableName.ColumnName = "Name";
            this.coldsTundishInnerFireL3DataTableName.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableTundishID
            // 
            this.coldsTundishInnerFireL3DataTableTundishID.Caption = "TundishID";
            this.coldsTundishInnerFireL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsTundishInnerFireL3DataTableTundishID.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableInnerID
            // 
            this.coldsTundishInnerFireL3DataTableInnerID.Caption = "InnerID";
            this.coldsTundishInnerFireL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsTundishInnerFireL3DataTableInnerID.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableSmall_Fire_Time
            // 
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Time.Caption = "Small_Fire_Time";
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Time.ColumnName = "Small_Fire_Time";
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Time.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableSmall_Fire_Operator
            // 
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Operator.Caption = "Small_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Operator.ColumnName = "Small_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableSmall_Fire_Operator.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableMid_Fire_Time
            // 
            this.coldsTundishInnerFireL3DataTableMid_Fire_Time.Caption = "Mid_Fire_Time";
            this.coldsTundishInnerFireL3DataTableMid_Fire_Time.ColumnName = "Mid_Fire_Time";
            this.coldsTundishInnerFireL3DataTableMid_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsTundishInnerFireL3DataTableMid_Fire_Time.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableMid_Fire_Operator
            // 
            this.coldsTundishInnerFireL3DataTableMid_Fire_Operator.Caption = "Mid_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableMid_Fire_Operator.ColumnName = "Mid_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableMid_Fire_Operator.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableBig_Fire_Time
            // 
            this.coldsTundishInnerFireL3DataTableBig_Fire_Time.Caption = "Big_Fire_Time";
            this.coldsTundishInnerFireL3DataTableBig_Fire_Time.ColumnName = "Big_Fire_Time";
            this.coldsTundishInnerFireL3DataTableBig_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsTundishInnerFireL3DataTableBig_Fire_Time.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableBig_Fire_Operator
            // 
            this.coldsTundishInnerFireL3DataTableBig_Fire_Operator.Caption = "Big_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableBig_Fire_Operator.ColumnName = "Big_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableBig_Fire_Operator.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableClose_Fire_Time
            // 
            this.coldsTundishInnerFireL3DataTableClose_Fire_Time.Caption = "Close_Fire_Time";
            this.coldsTundishInnerFireL3DataTableClose_Fire_Time.ColumnName = "Close_Fire_Time";
            this.coldsTundishInnerFireL3DataTableClose_Fire_Time.DataType = typeof(System.DateTime);
            this.coldsTundishInnerFireL3DataTableClose_Fire_Time.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableClose_Fire_Operator
            // 
            this.coldsTundishInnerFireL3DataTableClose_Fire_Operator.Caption = "Close_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableClose_Fire_Operator.ColumnName = "Close_Fire_Operator";
            this.coldsTundishInnerFireL3DataTableClose_Fire_Operator.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableTeamID
            // 
            this.coldsTundishInnerFireL3DataTableTeamID.Caption = "TeamID";
            this.coldsTundishInnerFireL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsTundishInnerFireL3DataTableTeamID.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableShiftID
            // 
            this.coldsTundishInnerFireL3DataTableShiftID.Caption = "ShiftID";
            this.coldsTundishInnerFireL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsTundishInnerFireL3DataTableShiftID.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableOperator
            // 
            this.coldsTundishInnerFireL3DataTableOperator.Caption = "Operator";
            this.coldsTundishInnerFireL3DataTableOperator.ColumnName = "Operator";
            this.coldsTundishInnerFireL3DataTableOperator.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableNote
            // 
            this.coldsTundishInnerFireL3DataTableNote.Caption = "Note";
            this.coldsTundishInnerFireL3DataTableNote.ColumnName = "Note";
            this.coldsTundishInnerFireL3DataTableNote.Namespace = "";
            // 
            // coldsTundishInnerFireL3DataTableConfirm_Flag
            // 
            this.coldsTundishInnerFireL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsTundishInnerFireL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsTundishInnerFireL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsTundishInnerFireL3DataTableConfirm_Flag.Namespace = "";
            // 
            // cmdInnerFire
            // 
            this.cmdInnerFire.Adapter = null;
            this.cmdInnerFire.MergeReturnTarget = false;
            this.cmdInnerFire.Method = null;
            this.cmdInnerFire.Object = null;
            this.cmdInnerFire.Parameters.Add(this.l3CommandParameter1);
            this.cmdInnerFire.ReturnTarget = null;
            this.cmdInnerFire.ReturnTargetProperty = null;
            this.cmdInnerFire.Trigger = null;
            this.cmdInnerFire.TriggerEvent = "Click";
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
            this.tbLPM.Controls.Add(this.bnInnerFire, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 1);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 2;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bnInnerFire
            // 
            this.bnInnerFire.AddNewItem = null;
            this.bnInnerFire.AutoSize = false;
            this.bnInnerFire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnInnerFire.BackgroundImage")));
            this.bnInnerFire.BindingSource = this.bsInnerFire;
            this.bnInnerFire.CountItem = this.bindingNavigatorCountItem;
            this.bnInnerFire.DeleteItem = null;
            this.bnInnerFire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnInnerFire.Location = new System.Drawing.Point(0, 0);
            this.bnInnerFire.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnInnerFire.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnInnerFire.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnInnerFire.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnInnerFire.Name = "bnInnerFire";
            this.bnInnerFire.PositionItem = this.bindingNavigatorPositionItem;
            this.bnInnerFire.Size = new System.Drawing.Size(1000, 25);
            this.bnInnerFire.TabIndex = 27;
            this.bnInnerFire.Text = "bindingNavigator1";
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
            this.hmiRootPanel1.Controls.Add(this.dvInnerFire);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 675);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvInnerFire
            // 
            this.dvInnerFire.AllowUserToAddRows = false;
            this.dvInnerFire.AutoGenerateColumns = false;
            this.dvInnerFire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInnerFire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInnerFire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tundishIDDataGridViewTextBoxColumn,
            this.innerIDDataGridViewTextBoxColumn,
            this.smallFireTimeDataGridViewTextBoxColumn,
            this.smallFireOperatorDataGridViewTextBoxColumn,
            this.midFireTimeDataGridViewTextBoxColumn,
            this.midFireOperatorDataGridViewTextBoxColumn,
            this.bigFireTimeDataGridViewTextBoxColumn,
            this.bigFireOperatorDataGridViewTextBoxColumn,
            this.closeFireTimeDataGridViewTextBoxColumn,
            this.closeFireOperatorDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.confirmFlagDataGridViewTextBoxColumn});
            this.dvInnerFire.DataSource = this.bsInnerFire;
            this.dvInnerFire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInnerFire.Location = new System.Drawing.Point(0, 0);
            this.dvInnerFire.Margin = new System.Windows.Forms.Padding(0);
            this.dvInnerFire.Name = "dvInnerFire";
            this.dvInnerFire.ReadOnly = true;
            this.dvInnerFire.RowTemplate.Height = 23;
            this.dvInnerFire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInnerFire.Size = new System.Drawing.Size(1000, 675);
            this.dvInnerFire.TabIndex = 31;
            this.dvInnerFire.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInnerFire_DataError);
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
            // innerIDDataGridViewTextBoxColumn
            // 
            this.innerIDDataGridViewTextBoxColumn.DataPropertyName = "InnerID";
            this.innerIDDataGridViewTextBoxColumn.HeaderText = "永久层编号";
            this.innerIDDataGridViewTextBoxColumn.Name = "innerIDDataGridViewTextBoxColumn";
            this.innerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // smallFireTimeDataGridViewTextBoxColumn
            // 
            this.smallFireTimeDataGridViewTextBoxColumn.DataPropertyName = "Small_Fire_Time";
            this.smallFireTimeDataGridViewTextBoxColumn.HeaderText = "小火时间";
            this.smallFireTimeDataGridViewTextBoxColumn.Name = "smallFireTimeDataGridViewTextBoxColumn";
            this.smallFireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.smallFireTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // smallFireOperatorDataGridViewTextBoxColumn
            // 
            this.smallFireOperatorDataGridViewTextBoxColumn.DataPropertyName = "Small_Fire_Operator";
            this.smallFireOperatorDataGridViewTextBoxColumn.HeaderText = "小火操作者";
            this.smallFireOperatorDataGridViewTextBoxColumn.Name = "smallFireOperatorDataGridViewTextBoxColumn";
            this.smallFireOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.smallFireOperatorDataGridViewTextBoxColumn.Width = 90;
            // 
            // midFireTimeDataGridViewTextBoxColumn
            // 
            this.midFireTimeDataGridViewTextBoxColumn.DataPropertyName = "Mid_Fire_Time";
            this.midFireTimeDataGridViewTextBoxColumn.HeaderText = "中火时间";
            this.midFireTimeDataGridViewTextBoxColumn.Name = "midFireTimeDataGridViewTextBoxColumn";
            this.midFireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.midFireTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // midFireOperatorDataGridViewTextBoxColumn
            // 
            this.midFireOperatorDataGridViewTextBoxColumn.DataPropertyName = "Mid_Fire_Operator";
            this.midFireOperatorDataGridViewTextBoxColumn.HeaderText = "中火操作者";
            this.midFireOperatorDataGridViewTextBoxColumn.Name = "midFireOperatorDataGridViewTextBoxColumn";
            this.midFireOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.midFireOperatorDataGridViewTextBoxColumn.Width = 90;
            // 
            // bigFireTimeDataGridViewTextBoxColumn
            // 
            this.bigFireTimeDataGridViewTextBoxColumn.DataPropertyName = "Big_Fire_Time";
            this.bigFireTimeDataGridViewTextBoxColumn.HeaderText = "大火时间";
            this.bigFireTimeDataGridViewTextBoxColumn.Name = "bigFireTimeDataGridViewTextBoxColumn";
            this.bigFireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bigFireTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // bigFireOperatorDataGridViewTextBoxColumn
            // 
            this.bigFireOperatorDataGridViewTextBoxColumn.DataPropertyName = "Big_Fire_Operator";
            this.bigFireOperatorDataGridViewTextBoxColumn.HeaderText = "大火操作者";
            this.bigFireOperatorDataGridViewTextBoxColumn.Name = "bigFireOperatorDataGridViewTextBoxColumn";
            this.bigFireOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.bigFireOperatorDataGridViewTextBoxColumn.Width = 90;
            // 
            // closeFireTimeDataGridViewTextBoxColumn
            // 
            this.closeFireTimeDataGridViewTextBoxColumn.DataPropertyName = "Close_Fire_Time";
            this.closeFireTimeDataGridViewTextBoxColumn.HeaderText = "停火时间";
            this.closeFireTimeDataGridViewTextBoxColumn.Name = "closeFireTimeDataGridViewTextBoxColumn";
            this.closeFireTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.closeFireTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // closeFireOperatorDataGridViewTextBoxColumn
            // 
            this.closeFireOperatorDataGridViewTextBoxColumn.DataPropertyName = "Close_Fire_Operator";
            this.closeFireOperatorDataGridViewTextBoxColumn.HeaderText = "停火操作者";
            this.closeFireOperatorDataGridViewTextBoxColumn.Name = "closeFireOperatorDataGridViewTextBoxColumn";
            this.closeFireOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.closeFireOperatorDataGridViewTextBoxColumn.Width = 90;
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // shiftIDDataGridViewTextBoxColumn
            // 
            this.shiftIDDataGridViewTextBoxColumn.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftIDDataGridViewTextBoxColumn.Name = "shiftIDDataGridViewTextBoxColumn";
            this.shiftIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 54;
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
            // TundishInnerFireMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishInnerFireMagFrm";
            this.TabText = "中包永久层烘烤实绩管理";
            this.Text = "中包永久层烘烤实绩查询";
            this.Load += new System.EventHandler(this.TundishInnerFireMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishInnerFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishInnerFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnInnerFire)).EndInit();
            this.bnInnerFire.ResumeLayout(false);
            this.bnInnerFire.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInnerFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsInnerFire;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bnInnerFire;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvInnerFire;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private AppSvrHMI.L3Command cmdInnerFire;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsTundishInnerFire;
        private System.Data.DataTable schemadsTundishInnerFire;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableGUID;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableName;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableTundishID;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableInnerID;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableSmall_Fire_Time;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableSmall_Fire_Operator;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableMid_Fire_Time;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableMid_Fire_Operator;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableBig_Fire_Time;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableBig_Fire_Operator;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableClose_Fire_Time;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableClose_Fire_Operator;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableTeamID;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableShiftID;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableOperator;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableNote;
        private System.Data.DataColumn coldsTundishInnerFireL3DataTableConfirm_Flag;
        private System.Windows.Forms.ToolStripComboBox cmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallFireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallFireOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midFireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midFireOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bigFireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bigFireOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeFireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeFireOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmFlagDataGridViewTextBoxColumn;
    }
}