namespace DispatchMag
{
    partial class SteelExchangeQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelExchangeQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appUnitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appSteelWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelChangeReason = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSteelChangeReason = new System.Data.DataTable();
            this.coldsSteelChangeReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelChangeReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.exTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelExange = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelExchange = new AppSvrHMI.L3DataSet();
            this.schemadsSteelExchange = new System.Data.DataTable();
            this.coldsSteelExchangeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableName = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEx_Time = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEx_Operator = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEx_Flag = new System.Data.DataColumn();
            this.coldsSteelExchangeL3DataTableEx_SteelGradeIndex = new System.Data.DataColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelExange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelExchange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelExchange)).BeginInit();
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
            this.hmiRootPanel1.Size = new System.Drawing.Size(1012, 376);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvInStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preHeatIDDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.appUnitIDDataGridViewTextBoxColumn,
            this.appTimeDataGridViewTextBoxColumn,
            this.appSteelWeightDataGridViewTextBoxColumn,
            this.appOperatorDataGridViewTextBoxColumn,
            this.appReasonDataGridViewTextBoxColumn,
            this.exTimeDataGridViewTextBoxColumn,
            this.exOperatorDataGridViewTextBoxColumn,
            this.exFlagDataGridViewTextBoxColumn,
            this.exSteelGradeIndexDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsSteelExange;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(1012, 351);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appUnitIDDataGridViewTextBoxColumn
            // 
            this.appUnitIDDataGridViewTextBoxColumn.DataPropertyName = "App_UnitID";
            this.appUnitIDDataGridViewTextBoxColumn.HeaderText = "申请工序";
            this.appUnitIDDataGridViewTextBoxColumn.Name = "appUnitIDDataGridViewTextBoxColumn";
            this.appUnitIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appTimeDataGridViewTextBoxColumn
            // 
            this.appTimeDataGridViewTextBoxColumn.DataPropertyName = "App_Time";
            this.appTimeDataGridViewTextBoxColumn.HeaderText = "申请时刻";
            this.appTimeDataGridViewTextBoxColumn.Name = "appTimeDataGridViewTextBoxColumn";
            this.appTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appSteelWeightDataGridViewTextBoxColumn
            // 
            this.appSteelWeightDataGridViewTextBoxColumn.DataPropertyName = "App_Steel_Weight";
            this.appSteelWeightDataGridViewTextBoxColumn.HeaderText = "申请钢量";
            this.appSteelWeightDataGridViewTextBoxColumn.Name = "appSteelWeightDataGridViewTextBoxColumn";
            this.appSteelWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appOperatorDataGridViewTextBoxColumn
            // 
            this.appOperatorDataGridViewTextBoxColumn.DataPropertyName = "App_Operator";
            this.appOperatorDataGridViewTextBoxColumn.HeaderText = "申请人";
            this.appOperatorDataGridViewTextBoxColumn.Name = "appOperatorDataGridViewTextBoxColumn";
            this.appOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appReasonDataGridViewTextBoxColumn
            // 
            this.appReasonDataGridViewTextBoxColumn.DataPropertyName = "App_Reason";
            this.appReasonDataGridViewTextBoxColumn.DataSource = this.dsSteelChangeReason;
            this.appReasonDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.appReasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.appReasonDataGridViewTextBoxColumn.HeaderText = "申请原因";
            this.appReasonDataGridViewTextBoxColumn.Name = "appReasonDataGridViewTextBoxColumn";
            this.appReasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.appReasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.appReasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.appReasonDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsSteelChangeReason
            // 
            this.dsSteelChangeReason.DataSetName = "L3DataSet";
            this.dsSteelChangeReason.DeleteMethod = null;
            this.dsSteelChangeReason.InsertMethod = null;
            this.dsSteelChangeReason.L3DataAdapter = this.Adapter;
            this.dsSteelChangeReason.LoadEvent = "Click";
            this.dsSteelChangeReason.LoadTrigger = null;
            this.dsSteelChangeReason.RefreshValve = 1000;
            this.dsSteelChangeReason.SourceCommand = null;
            this.dsSteelChangeReason.SourceCondition = "CODE_GROUP = \'SteelChangeReason\'";
            this.dsSteelChangeReason.SourceMethod = "";
            this.dsSteelChangeReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelChangeReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelChangeReason.SubscribeTarget = null;
            this.dsSteelChangeReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelChangeReason});
            this.dsSteelChangeReason.UpdateEvent = "Click";
            this.dsSteelChangeReason.UpdateMethod = null;
            this.dsSteelChangeReason.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSteelChangeReason
            // 
            this.schemadsSteelChangeReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelChangeReasonL3DataTableCode,
            this.coldsSteelChangeReasonL3DataTableCode_Des});
            this.schemadsSteelChangeReason.TableName = "L3DataTable";
            // 
            // coldsSteelChangeReasonL3DataTableCode
            // 
            this.coldsSteelChangeReasonL3DataTableCode.Caption = "Code";
            this.coldsSteelChangeReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSteelChangeReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSteelChangeReasonL3DataTableCode_Des
            // 
            this.coldsSteelChangeReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelChangeReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelChangeReasonL3DataTableCode_Des.Namespace = "";
            // 
            // exTimeDataGridViewTextBoxColumn
            // 
            this.exTimeDataGridViewTextBoxColumn.DataPropertyName = "Ex_Time";
            this.exTimeDataGridViewTextBoxColumn.HeaderText = "改钢时刻";
            this.exTimeDataGridViewTextBoxColumn.Name = "exTimeDataGridViewTextBoxColumn";
            this.exTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exOperatorDataGridViewTextBoxColumn
            // 
            this.exOperatorDataGridViewTextBoxColumn.DataPropertyName = "Ex_Operator";
            this.exOperatorDataGridViewTextBoxColumn.HeaderText = "改钢人";
            this.exOperatorDataGridViewTextBoxColumn.Name = "exOperatorDataGridViewTextBoxColumn";
            this.exOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exFlagDataGridViewTextBoxColumn
            // 
            this.exFlagDataGridViewTextBoxColumn.DataPropertyName = "Ex_Flag";
            this.exFlagDataGridViewTextBoxColumn.HeaderText = "改钢标志";
            this.exFlagDataGridViewTextBoxColumn.Name = "exFlagDataGridViewTextBoxColumn";
            this.exFlagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.exSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Ex_SteelGradeIndex";
            this.exSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.exSteelGradeIndexDataGridViewTextBoxColumn.Name = "exSteelGradeIndexDataGridViewTextBoxColumn";
            this.exSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsSteelExange
            // 
            this.bsSteelExange.DataMember = "L3DataTable";
            this.bsSteelExange.DataSource = this.dsSteelExchange;
            // 
            // dsSteelExchange
            // 
            this.dsSteelExchange.DataSetName = "L3DataSet";
            this.dsSteelExchange.DeleteMethod = "";
            this.dsSteelExchange.InsertMethod = "";
            this.dsSteelExchange.L3DataAdapter = this.Adapter;
            this.dsSteelExchange.LoadEvent = "Click";
            this.dsSteelExchange.LoadTrigger = null;
            this.dsSteelExchange.RefreshValve = 1000;
            this.dsSteelExchange.SourceCommand = null;
            this.dsSteelExchange.SourceCondition = "1=2";
            this.dsSteelExchange.SourceMethod = "";
            this.dsSteelExchange.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelExchange.SourceURI = "XGMESLogic\\DispatchMag\\CDisp_SteelExchange_App";
            this.dsSteelExchange.SubscribeTarget = null;
            this.dsSteelExchange.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelExchange});
            this.dsSteelExchange.UpdateEvent = "Click";
            this.dsSteelExchange.UpdateMethod = "";
            this.dsSteelExchange.UpdateTrigger = null;
            // 
            // schemadsSteelExchange
            // 
            this.schemadsSteelExchange.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelExchangeL3DataTableGUID,
            this.coldsSteelExchangeL3DataTableName,
            this.coldsSteelExchangeL3DataTableObjectID,
            this.coldsSteelExchangeL3DataTablePreHeatID,
            this.coldsSteelExchangeL3DataTableSteelGradeIndex,
            this.coldsSteelExchangeL3DataTableHeatID,
            this.coldsSteelExchangeL3DataTableApp_UnitID,
            this.coldsSteelExchangeL3DataTableApp_Time,
            this.coldsSteelExchangeL3DataTableApp_Steel_Weight,
            this.coldsSteelExchangeL3DataTableApp_Operator,
            this.coldsSteelExchangeL3DataTableApp_Reason,
            this.coldsSteelExchangeL3DataTableEx_Time,
            this.coldsSteelExchangeL3DataTableEx_Operator,
            this.coldsSteelExchangeL3DataTableEx_Flag,
            this.coldsSteelExchangeL3DataTableEx_SteelGradeIndex});
            this.schemadsSteelExchange.TableName = "L3DataTable";
            // 
            // coldsSteelExchangeL3DataTableGUID
            // 
            this.coldsSteelExchangeL3DataTableGUID.Caption = "GUID";
            this.coldsSteelExchangeL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelExchangeL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableName
            // 
            this.coldsSteelExchangeL3DataTableName.Caption = "Name";
            this.coldsSteelExchangeL3DataTableName.ColumnName = "Name";
            this.coldsSteelExchangeL3DataTableName.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableObjectID
            // 
            this.coldsSteelExchangeL3DataTableObjectID.Caption = "ObjectID";
            this.coldsSteelExchangeL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsSteelExchangeL3DataTableObjectID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTablePreHeatID
            // 
            this.coldsSteelExchangeL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsSteelExchangeL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsSteelExchangeL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableSteelGradeIndex
            // 
            this.coldsSteelExchangeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelExchangeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelExchangeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableHeatID
            // 
            this.coldsSteelExchangeL3DataTableHeatID.Caption = "HeatID";
            this.coldsSteelExchangeL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSteelExchangeL3DataTableHeatID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableApp_UnitID
            // 
            this.coldsSteelExchangeL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsSteelExchangeL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsSteelExchangeL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableApp_Time
            // 
            this.coldsSteelExchangeL3DataTableApp_Time.Caption = "App_Time";
            this.coldsSteelExchangeL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsSteelExchangeL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsSteelExchangeL3DataTableApp_Time.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableApp_Steel_Weight
            // 
            this.coldsSteelExchangeL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsSteelExchangeL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsSteelExchangeL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsSteelExchangeL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableApp_Operator
            // 
            this.coldsSteelExchangeL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsSteelExchangeL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsSteelExchangeL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableApp_Reason
            // 
            this.coldsSteelExchangeL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsSteelExchangeL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsSteelExchangeL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEx_Time
            // 
            this.coldsSteelExchangeL3DataTableEx_Time.Caption = "Ex_Time";
            this.coldsSteelExchangeL3DataTableEx_Time.ColumnName = "Ex_Time";
            this.coldsSteelExchangeL3DataTableEx_Time.DataType = typeof(System.DateTime);
            this.coldsSteelExchangeL3DataTableEx_Time.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEx_Operator
            // 
            this.coldsSteelExchangeL3DataTableEx_Operator.Caption = "Ex_Operator";
            this.coldsSteelExchangeL3DataTableEx_Operator.ColumnName = "Ex_Operator";
            this.coldsSteelExchangeL3DataTableEx_Operator.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEx_Flag
            // 
            this.coldsSteelExchangeL3DataTableEx_Flag.Caption = "Ex_Flag";
            this.coldsSteelExchangeL3DataTableEx_Flag.ColumnName = "Ex_Flag";
            this.coldsSteelExchangeL3DataTableEx_Flag.DataType = typeof(int);
            this.coldsSteelExchangeL3DataTableEx_Flag.Namespace = "";
            // 
            // coldsSteelExchangeL3DataTableEx_SteelGradeIndex
            // 
            this.coldsSteelExchangeL3DataTableEx_SteelGradeIndex.Caption = "Ex_SteelGradeIndex";
            this.coldsSteelExchangeL3DataTableEx_SteelGradeIndex.ColumnName = "Ex_SteelGradeIndex";
            this.coldsSteelExchangeL3DataTableEx_SteelGradeIndex.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsSteelExange;
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
            this.bdN1.Size = new System.Drawing.Size(1012, 25);
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
            this.toolStripLabel6.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel6.Text = "改钢申请日期:";
            // 
            // SteelExchangeQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 376);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteelExchangeQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "改钢申请查询";
            this.Text = "改钢申请查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteelExchangeQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.SteelExchangeQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelExange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelExchange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelExchange)).EndInit();
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
        private AppSvrHMI.L3DataSet dsSteelExchange;
        private System.Data.DataTable schemadsSteelExchange;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableGUID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableName;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableObjectID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTablePreHeatID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableHeatID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableApp_Time;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableApp_Operator;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableApp_Reason;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEx_Time;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEx_Operator;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEx_Flag;
        private System.Data.DataColumn coldsSteelExchangeL3DataTableEx_SteelGradeIndex;
        private System.Windows.Forms.BindingSource bsSteelExange;
        private AppSvrHMI.L3DataSet dsSteelChangeReason;
        private System.Data.DataTable schemadsSteelChangeReason;
        private System.Data.DataColumn coldsSteelChangeReasonL3DataTableCode;
        private System.Data.DataColumn coldsSteelChangeReasonL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appUnitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appSteelWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn appReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exSteelGradeIndexDataGridViewTextBoxColumn;
    }
}