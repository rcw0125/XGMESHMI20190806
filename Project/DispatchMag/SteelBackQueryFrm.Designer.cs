namespace DispatchMag
{
    partial class SteelBackQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelBackQueryFrm));
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
            this.dsSteelBackReason = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSteelBackReason = new System.Data.DataTable();
            this.coldsSteelBackReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelBackReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.backUnitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSteelBack = new System.Windows.Forms.BindingSource(this.components);
            this.dsSteelBack = new AppSvrHMI.L3DataSet();
            this.schemadsSteelBack = new System.Data.DataTable();
            this.coldsSteelBackL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableName = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableApp_Steel_Weight = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableApp_Reason = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBack_UnitID = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBack_Time = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBack_Operator = new System.Data.DataColumn();
            this.coldsSteelBackL3DataTableBack_Flag = new System.Data.DataColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBackReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBackReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBack)).BeginInit();
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
            this.hmiRootPanel1.Size = new System.Drawing.Size(926, 376);
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
            this.backUnitIDDataGridViewTextBoxColumn,
            this.backTimeDataGridViewTextBoxColumn,
            this.backOperatorDataGridViewTextBoxColumn,
            this.backFlagDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsSteelBack;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(926, 351);
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
            this.appReasonDataGridViewTextBoxColumn.DataSource = this.dsSteelBackReason;
            this.appReasonDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.appReasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.appReasonDataGridViewTextBoxColumn.HeaderText = "申请原因";
            this.appReasonDataGridViewTextBoxColumn.Name = "appReasonDataGridViewTextBoxColumn";
            this.appReasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.appReasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.appReasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.appReasonDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsSteelBackReason
            // 
            this.dsSteelBackReason.DataSetName = "L3DataSet";
            this.dsSteelBackReason.DeleteMethod = null;
            this.dsSteelBackReason.InsertMethod = null;
            this.dsSteelBackReason.L3DataAdapter = this.Adapter;
            this.dsSteelBackReason.LoadEvent = "Click";
            this.dsSteelBackReason.LoadTrigger = null;
            this.dsSteelBackReason.RefreshValve = 1000;
            this.dsSteelBackReason.SourceCommand = null;
            this.dsSteelBackReason.SourceCondition = "CODE_GROUP = \'SteelBackReason\'";
            this.dsSteelBackReason.SourceMethod = "";
            this.dsSteelBackReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelBackReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelBackReason.SubscribeTarget = null;
            this.dsSteelBackReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelBackReason});
            this.dsSteelBackReason.UpdateEvent = "Click";
            this.dsSteelBackReason.UpdateMethod = null;
            this.dsSteelBackReason.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSteelBackReason
            // 
            this.schemadsSteelBackReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelBackReasonL3DataTableCode,
            this.coldsSteelBackReasonL3DataTableCode_Des});
            this.schemadsSteelBackReason.TableName = "L3DataTable";
            // 
            // coldsSteelBackReasonL3DataTableCode
            // 
            this.coldsSteelBackReasonL3DataTableCode.Caption = "Code";
            this.coldsSteelBackReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSteelBackReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSteelBackReasonL3DataTableCode_Des
            // 
            this.coldsSteelBackReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelBackReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelBackReasonL3DataTableCode_Des.Namespace = "";
            // 
            // backUnitIDDataGridViewTextBoxColumn
            // 
            this.backUnitIDDataGridViewTextBoxColumn.DataPropertyName = "Back_UnitID";
            this.backUnitIDDataGridViewTextBoxColumn.HeaderText = "返送工序";
            this.backUnitIDDataGridViewTextBoxColumn.Name = "backUnitIDDataGridViewTextBoxColumn";
            this.backUnitIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backTimeDataGridViewTextBoxColumn
            // 
            this.backTimeDataGridViewTextBoxColumn.DataPropertyName = "Back_Time";
            this.backTimeDataGridViewTextBoxColumn.HeaderText = "返送时刻";
            this.backTimeDataGridViewTextBoxColumn.Name = "backTimeDataGridViewTextBoxColumn";
            this.backTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backOperatorDataGridViewTextBoxColumn
            // 
            this.backOperatorDataGridViewTextBoxColumn.DataPropertyName = "Back_Operator";
            this.backOperatorDataGridViewTextBoxColumn.HeaderText = "返送人";
            this.backOperatorDataGridViewTextBoxColumn.Name = "backOperatorDataGridViewTextBoxColumn";
            this.backOperatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // backFlagDataGridViewTextBoxColumn
            // 
            this.backFlagDataGridViewTextBoxColumn.DataPropertyName = "Back_Flag";
            this.backFlagDataGridViewTextBoxColumn.HeaderText = "返送标志";
            this.backFlagDataGridViewTextBoxColumn.Name = "backFlagDataGridViewTextBoxColumn";
            this.backFlagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsSteelBack
            // 
            this.bsSteelBack.DataMember = "L3DataTable";
            this.bsSteelBack.DataSource = this.dsSteelBack;
            // 
            // dsSteelBack
            // 
            this.dsSteelBack.DataSetName = "L3DataSet";
            this.dsSteelBack.DeleteMethod = "";
            this.dsSteelBack.InsertMethod = "";
            this.dsSteelBack.L3DataAdapter = this.Adapter;
            this.dsSteelBack.LoadEvent = "Click";
            this.dsSteelBack.LoadTrigger = null;
            this.dsSteelBack.RefreshValve = 1000;
            this.dsSteelBack.SourceCommand = null;
            this.dsSteelBack.SourceCondition = "　";
            this.dsSteelBack.SourceMethod = "";
            this.dsSteelBack.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelBack.SourceURI = "XGMESLogic\\DispatchMag\\CDisp_SteelBack_App";
            this.dsSteelBack.SubscribeTarget = null;
            this.dsSteelBack.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelBack});
            this.dsSteelBack.UpdateEvent = "Click";
            this.dsSteelBack.UpdateMethod = "";
            this.dsSteelBack.UpdateTrigger = null;
            // 
            // schemadsSteelBack
            // 
            this.schemadsSteelBack.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelBackL3DataTableGUID,
            this.coldsSteelBackL3DataTableName,
            this.coldsSteelBackL3DataTableObjectID,
            this.coldsSteelBackL3DataTablePreHeatID,
            this.coldsSteelBackL3DataTableSteelGradeIndex,
            this.coldsSteelBackL3DataTableHeatID,
            this.coldsSteelBackL3DataTableApp_UnitID,
            this.coldsSteelBackL3DataTableApp_Time,
            this.coldsSteelBackL3DataTableApp_Steel_Weight,
            this.coldsSteelBackL3DataTableApp_Operator,
            this.coldsSteelBackL3DataTableApp_Reason,
            this.coldsSteelBackL3DataTableBack_UnitID,
            this.coldsSteelBackL3DataTableBack_Time,
            this.coldsSteelBackL3DataTableBack_Operator,
            this.coldsSteelBackL3DataTableBack_Flag});
            this.schemadsSteelBack.TableName = "L3DataTable";
            // 
            // coldsSteelBackL3DataTableGUID
            // 
            this.coldsSteelBackL3DataTableGUID.Caption = "GUID";
            this.coldsSteelBackL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelBackL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableName
            // 
            this.coldsSteelBackL3DataTableName.Caption = "Name";
            this.coldsSteelBackL3DataTableName.ColumnName = "Name";
            this.coldsSteelBackL3DataTableName.Namespace = "";
            // 
            // coldsSteelBackL3DataTableObjectID
            // 
            this.coldsSteelBackL3DataTableObjectID.Caption = "ObjectID";
            this.coldsSteelBackL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsSteelBackL3DataTableObjectID.Namespace = "";
            // 
            // coldsSteelBackL3DataTablePreHeatID
            // 
            this.coldsSteelBackL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsSteelBackL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsSteelBackL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableSteelGradeIndex
            // 
            this.coldsSteelBackL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelBackL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelBackL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelBackL3DataTableHeatID
            // 
            this.coldsSteelBackL3DataTableHeatID.Caption = "HeatID";
            this.coldsSteelBackL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSteelBackL3DataTableHeatID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableApp_UnitID
            // 
            this.coldsSteelBackL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsSteelBackL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsSteelBackL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableApp_Time
            // 
            this.coldsSteelBackL3DataTableApp_Time.Caption = "App_Time";
            this.coldsSteelBackL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsSteelBackL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsSteelBackL3DataTableApp_Time.Namespace = "";
            // 
            // coldsSteelBackL3DataTableApp_Steel_Weight
            // 
            this.coldsSteelBackL3DataTableApp_Steel_Weight.Caption = "App_Steel_Weight";
            this.coldsSteelBackL3DataTableApp_Steel_Weight.ColumnName = "App_Steel_Weight";
            this.coldsSteelBackL3DataTableApp_Steel_Weight.DataType = typeof(double);
            this.coldsSteelBackL3DataTableApp_Steel_Weight.Namespace = "";
            // 
            // coldsSteelBackL3DataTableApp_Operator
            // 
            this.coldsSteelBackL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsSteelBackL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsSteelBackL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsSteelBackL3DataTableApp_Reason
            // 
            this.coldsSteelBackL3DataTableApp_Reason.Caption = "App_Reason";
            this.coldsSteelBackL3DataTableApp_Reason.ColumnName = "App_Reason";
            this.coldsSteelBackL3DataTableApp_Reason.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBack_UnitID
            // 
            this.coldsSteelBackL3DataTableBack_UnitID.Caption = "Back_UnitID";
            this.coldsSteelBackL3DataTableBack_UnitID.ColumnName = "Back_UnitID";
            this.coldsSteelBackL3DataTableBack_UnitID.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBack_Time
            // 
            this.coldsSteelBackL3DataTableBack_Time.Caption = "Back_Time";
            this.coldsSteelBackL3DataTableBack_Time.ColumnName = "Back_Time";
            this.coldsSteelBackL3DataTableBack_Time.DataType = typeof(System.DateTime);
            this.coldsSteelBackL3DataTableBack_Time.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBack_Operator
            // 
            this.coldsSteelBackL3DataTableBack_Operator.Caption = "Back_Operator";
            this.coldsSteelBackL3DataTableBack_Operator.ColumnName = "Back_Operator";
            this.coldsSteelBackL3DataTableBack_Operator.Namespace = "";
            // 
            // coldsSteelBackL3DataTableBack_Flag
            // 
            this.coldsSteelBackL3DataTableBack_Flag.Caption = "Back_Flag";
            this.coldsSteelBackL3DataTableBack_Flag.ColumnName = "Back_Flag";
            this.coldsSteelBackL3DataTableBack_Flag.DataType = typeof(int);
            this.coldsSteelBackL3DataTableBack_Flag.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsSteelBack;
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
            this.bdN1.Size = new System.Drawing.Size(926, 25);
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
            // SteelBackQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 376);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteelBackQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢水饭送申请查询";
            this.Text = "钢水饭送申请查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SteelBackQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.SteelBackQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBackReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBackReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSteelBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelBack)).EndInit();
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
        private System.Windows.Forms.BindingSource bsSteelBack;
        private AppSvrHMI.L3DataSet dsSteelBack;
        private System.Data.DataTable schemadsSteelBack;
        private System.Data.DataColumn coldsSteelBackL3DataTableGUID;
        private System.Data.DataColumn coldsSteelBackL3DataTableName;
        private System.Data.DataColumn coldsSteelBackL3DataTableObjectID;
        private System.Data.DataColumn coldsSteelBackL3DataTablePreHeatID;
        private System.Data.DataColumn coldsSteelBackL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelBackL3DataTableHeatID;
        private System.Data.DataColumn coldsSteelBackL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsSteelBackL3DataTableApp_Time;
        private System.Data.DataColumn coldsSteelBackL3DataTableApp_Steel_Weight;
        private System.Data.DataColumn coldsSteelBackL3DataTableApp_Operator;
        private System.Data.DataColumn coldsSteelBackL3DataTableApp_Reason;
        private System.Data.DataColumn coldsSteelBackL3DataTableBack_UnitID;
        private System.Data.DataColumn coldsSteelBackL3DataTableBack_Time;
        private System.Data.DataColumn coldsSteelBackL3DataTableBack_Operator;
        private System.Data.DataColumn coldsSteelBackL3DataTableBack_Flag;
        private AppSvrHMI.L3DataSet dsSteelBackReason;
        private System.Data.DataTable schemadsSteelBackReason;
        private System.Data.DataColumn coldsSteelBackReasonL3DataTableCode;
        private System.Data.DataColumn coldsSteelBackReasonL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appUnitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appSteelWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn appReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backUnitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backFlagDataGridViewTextBoxColumn;
    }
}