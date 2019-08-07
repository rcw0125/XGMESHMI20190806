namespace DispatchMag
{
    partial class SteelTurnQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelTurnQuery));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appUnitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appSteelWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelTrunReason = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSteelTrunReason = new System.Data.DataTable();
            this.coldsSteelTrunReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelTrunReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.turnTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allTurnFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelTurn = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelTurn = new AppSvrHMI.L3DataSet();
            this.schemadsSteelTurn = new System.Data.DataTable();
            this.coldsSteelTurnL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableName = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableTurn_Time = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableTurn_Operator = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableTurn_Flag = new System.Data.DataColumn();
            this.coldsSteelTurnL3DataTableAll_Turn_Flag = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtNoteEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtNoteData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTrunReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTrunReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTurn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1020, 376);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preHeatIDDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.appTimeDataGridViewTextBoxColumn,
            this.appUnitIDDataGridViewTextBoxColumn,
            this.appSteelWeightDataGridViewTextBoxColumn,
            this.appOperatorDataGridViewTextBoxColumn,
            this.appReasonDataGridViewTextBoxColumn,
            this.turnTimeDataGridViewTextBoxColumn,
            this.turnOperatorDataGridViewTextBoxColumn,
            this.turnFlagDataGridViewTextBoxColumn,
            this.allTurnFlagDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsSteelTurn;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(1020, 351);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.preHeatIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // appTimeDataGridViewTextBoxColumn
            // 
            this.appTimeDataGridViewTextBoxColumn.DataPropertyName = "App_Time";
            this.appTimeDataGridViewTextBoxColumn.HeaderText = "申请时刻";
            this.appTimeDataGridViewTextBoxColumn.Name = "appTimeDataGridViewTextBoxColumn";
            this.appTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.appTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // appUnitIDDataGridViewTextBoxColumn
            // 
            this.appUnitIDDataGridViewTextBoxColumn.DataPropertyName = "App_UnitID";
            this.appUnitIDDataGridViewTextBoxColumn.HeaderText = "申请工序";
            this.appUnitIDDataGridViewTextBoxColumn.Name = "appUnitIDDataGridViewTextBoxColumn";
            this.appUnitIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.appUnitIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // appSteelWeightDataGridViewTextBoxColumn
            // 
            this.appSteelWeightDataGridViewTextBoxColumn.DataPropertyName = "App_Steel_Weight";
            this.appSteelWeightDataGridViewTextBoxColumn.HeaderText = "申请钢量";
            this.appSteelWeightDataGridViewTextBoxColumn.Name = "appSteelWeightDataGridViewTextBoxColumn";
            this.appSteelWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.appSteelWeightDataGridViewTextBoxColumn.Width = 78;
            // 
            // appOperatorDataGridViewTextBoxColumn
            // 
            this.appOperatorDataGridViewTextBoxColumn.DataPropertyName = "App_Operator";
            this.appOperatorDataGridViewTextBoxColumn.HeaderText = "申请人";
            this.appOperatorDataGridViewTextBoxColumn.Name = "appOperatorDataGridViewTextBoxColumn";
            this.appOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.appOperatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // appReasonDataGridViewTextBoxColumn
            // 
            this.appReasonDataGridViewTextBoxColumn.DataPropertyName = "App_Reason";
            this.appReasonDataGridViewTextBoxColumn.DataSource = this.dsSteelTrunReason;
            this.appReasonDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.appReasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.appReasonDataGridViewTextBoxColumn.HeaderText = "申请原因";
            this.appReasonDataGridViewTextBoxColumn.Name = "appReasonDataGridViewTextBoxColumn";
            this.appReasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.appReasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.appReasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.appReasonDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.appReasonDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsSteelTrunReason
            // 
            this.dsSteelTrunReason.DataSetName = "L3DataSet";
            this.dsSteelTrunReason.DeleteMethod = null;
            this.dsSteelTrunReason.InsertMethod = null;
            this.dsSteelTrunReason.L3DataAdapter = this.Adapter;
            this.dsSteelTrunReason.LoadEvent = "Click";
            this.dsSteelTrunReason.LoadTrigger = null;
            this.dsSteelTrunReason.RefreshValve = 1000;
            this.dsSteelTrunReason.SourceCommand = null;
            this.dsSteelTrunReason.SourceCondition = "CODE_GROUP = \'SteelTrunReason\'";
            this.dsSteelTrunReason.SourceMethod = "";
            this.dsSteelTrunReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelTrunReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelTrunReason.SubscribeTarget = null;
            this.dsSteelTrunReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelTrunReason});
            this.dsSteelTrunReason.UpdateEvent = "Click";
            this.dsSteelTrunReason.UpdateMethod = null;
            this.dsSteelTrunReason.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSteelTrunReason
            // 
            this.schemadsSteelTrunReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelTrunReasonL3DataTableCode,
            this.coldsSteelTrunReasonL3DataTableCode_Des});
            this.schemadsSteelTrunReason.TableName = "L3DataTable";
            // 
            // coldsSteelTrunReasonL3DataTableCode
            // 
            this.coldsSteelTrunReasonL3DataTableCode.Caption = "Code";
            this.coldsSteelTrunReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSteelTrunReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSteelTrunReasonL3DataTableCode_Des
            // 
            this.coldsSteelTrunReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelTrunReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelTrunReasonL3DataTableCode_Des.Namespace = "";
            // 
            // turnTimeDataGridViewTextBoxColumn
            // 
            this.turnTimeDataGridViewTextBoxColumn.DataPropertyName = "Turn_Time";
            this.turnTimeDataGridViewTextBoxColumn.HeaderText = "回炉时刻";
            this.turnTimeDataGridViewTextBoxColumn.Name = "turnTimeDataGridViewTextBoxColumn";
            this.turnTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // turnOperatorDataGridViewTextBoxColumn
            // 
            this.turnOperatorDataGridViewTextBoxColumn.DataPropertyName = "Turn_Operator";
            this.turnOperatorDataGridViewTextBoxColumn.HeaderText = "回炉人";
            this.turnOperatorDataGridViewTextBoxColumn.Name = "turnOperatorDataGridViewTextBoxColumn";
            this.turnOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnOperatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // turnFlagDataGridViewTextBoxColumn
            // 
            this.turnFlagDataGridViewTextBoxColumn.DataPropertyName = "Turn_Flag";
            this.turnFlagDataGridViewTextBoxColumn.HeaderText = "回炉标志";
            this.turnFlagDataGridViewTextBoxColumn.Name = "turnFlagDataGridViewTextBoxColumn";
            this.turnFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.turnFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // allTurnFlagDataGridViewTextBoxColumn
            // 
            this.allTurnFlagDataGridViewTextBoxColumn.DataPropertyName = "All_Turn_Flag";
            this.allTurnFlagDataGridViewTextBoxColumn.HeaderText = "全回炉标志";
            this.allTurnFlagDataGridViewTextBoxColumn.Name = "allTurnFlagDataGridViewTextBoxColumn";
            this.allTurnFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.allTurnFlagDataGridViewTextBoxColumn.Width = 90;
            // 
            // bsSteelTurn
            // 
            this.bsSteelTurn.DataMember = "L3DataTable";
            this.bsSteelTurn.DataSource = this.dsSteelTurn;
            // 
            // dsSteelTurn
            // 
            this.dsSteelTurn.DataSetName = "L3DataSet";
            this.dsSteelTurn.DeleteMethod = "";
            this.dsSteelTurn.InsertMethod = "";
            this.dsSteelTurn.L3DataAdapter = this.Adapter;
            this.dsSteelTurn.LoadEvent = "Click";
            this.dsSteelTurn.LoadTrigger = null;
            this.dsSteelTurn.RefreshValve = 1000;
            this.dsSteelTurn.SourceCommand = null;
            this.dsSteelTurn.SourceCondition = "1=2";
            this.dsSteelTurn.SourceMethod = "";
            this.dsSteelTurn.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelTurn.SourceURI = "XGMESLogic\\DispatchMag\\CDisp_SteelTurn_App";
            this.dsSteelTurn.SubscribeTarget = null;
            this.dsSteelTurn.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelTurn});
            this.dsSteelTurn.UpdateEvent = "Click";
            this.dsSteelTurn.UpdateMethod = "";
            this.dsSteelTurn.UpdateTrigger = null;
            // 
            // schemadsSteelTurn
            // 
            this.schemadsSteelTurn.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelTurnL3DataTableGUID,
            this.coldsSteelTurnL3DataTableName,
            this.coldsSteelTurnL3DataTableObjectID,
            this.coldsSteelTurnL3DataTablePreHeatID,
            this.coldsSteelTurnL3DataTableSteelGradeIndex,
            this.coldsSteelTurnL3DataTableHeatID,
            this.coldsSteelTurnL3DataTableApp_Time,
            this.coldsSteelTurnL3DataTableApp_UnitID,
            this.coldsSteelTurnL3DataTableApp_Steel_Weight,
            this.coldsSteelTurnL3DataTableApp_Operator,
            this.coldsSteelTurnL3DataTableApp_Reason,
            this.coldsSteelTurnL3DataTableTurn_Time,
            this.coldsSteelTurnL3DataTableTurn_Operator,
            this.coldsSteelTurnL3DataTableTurn_Flag,
            this.coldsSteelTurnL3DataTableAll_Turn_Flag});
            this.schemadsSteelTurn.TableName = "L3DataTable";
            // 
            // coldsSteelTurnL3DataTableGUID
            // 
            this.coldsSteelTurnL3DataTableGUID.Caption = "GUID";
            this.coldsSteelTurnL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelTurnL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableName
            // 
            this.coldsSteelTurnL3DataTableName.Caption = "Name";
            this.coldsSteelTurnL3DataTableName.ColumnName = "Name";
            this.coldsSteelTurnL3DataTableName.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableObjectID
            // 
            this.coldsSteelTurnL3DataTableObjectID.Caption = "ObjectID";
            this.coldsSteelTurnL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsSteelTurnL3DataTableObjectID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTablePreHeatID
            // 
            this.coldsSteelTurnL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsSteelTurnL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsSteelTurnL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableSteelGradeIndex
            // 
            this.coldsSteelTurnL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelTurnL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelTurnL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableHeatID
            // 
            this.coldsSteelTurnL3DataTableHeatID.Caption = "HeatID";
            this.coldsSteelTurnL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSteelTurnL3DataTableHeatID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableApp_Time
            // 
            this.coldsSteelTurnL3DataTableApp_Time.Caption = "App_Time";
            this.coldsSteelTurnL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsSteelTurnL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsSteelTurnL3DataTableApp_Time.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableApp_UnitID
            // 
            this.coldsSteelTurnL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsSteelTurnL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsSteelTurnL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableApp_Steel_Weight
            // 
            this.coldsSteelTurnL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsSteelTurnL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsSteelTurnL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsSteelTurnL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableApp_Operator
            // 
            this.coldsSteelTurnL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsSteelTurnL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsSteelTurnL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableApp_Reason
            // 
            this.coldsSteelTurnL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsSteelTurnL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsSteelTurnL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableTurn_Time
            // 
            this.coldsSteelTurnL3DataTableTurn_Time.Caption = "Turn_Time";
            this.coldsSteelTurnL3DataTableTurn_Time.ColumnName = "Turn_Time";
            this.coldsSteelTurnL3DataTableTurn_Time.DataType = typeof(System.DateTime);
            this.coldsSteelTurnL3DataTableTurn_Time.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableTurn_Operator
            // 
            this.coldsSteelTurnL3DataTableTurn_Operator.Caption = "Turn_Operator";
            this.coldsSteelTurnL3DataTableTurn_Operator.ColumnName = "Turn_Operator";
            this.coldsSteelTurnL3DataTableTurn_Operator.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableTurn_Flag
            // 
            this.coldsSteelTurnL3DataTableTurn_Flag.Caption = "Turn_Flag";
            this.coldsSteelTurnL3DataTableTurn_Flag.ColumnName = "Turn_Flag";
            this.coldsSteelTurnL3DataTableTurn_Flag.DataType = typeof(int);
            this.coldsSteelTurnL3DataTableTurn_Flag.Namespace = "";
            // 
            // coldsSteelTurnL3DataTableAll_Turn_Flag
            // 
            this.coldsSteelTurnL3DataTableAll_Turn_Flag.Caption = "All_Turn_Flag";
            this.coldsSteelTurnL3DataTableAll_Turn_Flag.ColumnName = "All_Turn_Flag";
            this.coldsSteelTurnL3DataTableAll_Turn_Flag.DataType = typeof(int);
            this.coldsSteelTurnL3DataTableAll_Turn_Flag.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsSteelTurn;
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
            this.btnOutput,
            this.toolStripLabel1,
            this.btnQuery,
            this.dtNoteEndData,
            this.toolStripLabel3,
            this.dtNoteData,
            this.toolStripLabel6});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1020, 25);
            this.bdN1.TabIndex = 28;
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
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
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
            // dtNoteEndData
            // 
            this.dtNoteEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtNoteEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtNoteEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtNoteEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtNoteEndData.CustomFormat = "yyyy-MM-dd";
            this.dtNoteEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNoteEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNoteEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtNoteEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNoteEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtNoteEndData.Name = "dtNoteEndData";
            this.dtNoteEndData.Size = new System.Drawing.Size(100, 22);
            this.dtNoteEndData.Text = "2009-01-04";
            this.dtNoteEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel3.Text = "－";
            // 
            // dtNoteData
            // 
            this.dtNoteData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtNoteData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtNoteData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtNoteData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtNoteData.CustomFormat = "yyyy-MM-dd";
            this.dtNoteData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNoteData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNoteData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtNoteData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNoteData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtNoteData.Name = "dtNoteData";
            this.dtNoteData.Size = new System.Drawing.Size(100, 22);
            this.dtNoteData.Text = "2008-11-16";
            this.dtNoteData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "申请日期:";
            // 
            // SteelTurnQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 376);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteelTurnQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢水回炉申请查询";
            this.Text = "钢水回炉申请查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteelTurnQuery_FormClosing);
            this.Load += new System.EventHandler(this.SteelTurnQuery_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTrunReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTrunReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtNoteData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtNoteEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.BindingSource bsSteelTurn;
        private AppSvrHMI.L3DataSet dsSteelTurn;
        private System.Data.DataTable schemadsSteelTurn;
        private System.Data.DataColumn coldsSteelTurnL3DataTableGUID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableName;
        private System.Data.DataColumn coldsSteelTurnL3DataTableObjectID;
        private System.Data.DataColumn coldsSteelTurnL3DataTablePreHeatID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelTurnL3DataTableHeatID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableApp_Time;
        private System.Data.DataColumn coldsSteelTurnL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsSteelTurnL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsSteelTurnL3DataTableApp_Operator;
        private System.Data.DataColumn coldsSteelTurnL3DataTableApp_Reason;
        private System.Data.DataColumn coldsSteelTurnL3DataTableTurn_Time;
        private System.Data.DataColumn coldsSteelTurnL3DataTableTurn_Operator;
        private System.Data.DataColumn coldsSteelTurnL3DataTableTurn_Flag;
        private System.Data.DataColumn coldsSteelTurnL3DataTableAll_Turn_Flag;
        private AppSvrHMI.L3DataSet dsSteelTrunReason;
        private System.Data.DataTable schemadsSteelTrunReason;
        private System.Data.DataColumn coldsSteelTrunReasonL3DataTableCode;
        private System.Data.DataColumn coldsSteelTrunReasonL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appUnitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appSteelWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn appReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allTurnFlagDataGridViewTextBoxColumn;
    }
}