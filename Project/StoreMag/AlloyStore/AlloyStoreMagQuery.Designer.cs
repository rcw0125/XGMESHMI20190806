namespace StoreMag.AlloyStore
{
    partial class AlloyStoreMagQuery
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
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvMatStoreEmpt = new System.Windows.Forms.DataGridView();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAlloyArea = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsAlloyArea = new System.Data.DataTable();
            this.coldsAlloyAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newOldFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsOperator = new AppSvrHMI.L3DataSet();
            this.schemadsOperator = new System.Data.DataTable();
            this.coldsOperatorL3DataTableOperator = new System.Data.DataColumn();
            this.coldsOperatorL3DataTableOperator_Name = new System.Data.DataColumn();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMatSotreEmpt = new System.Windows.Forms.BindingSource(this.components);
            this.dsMatStoreEmpt = new AppSvrHMI.L3DataSet();
            this.schemadsMatStoreEmpt = new System.Data.DataTable();
            this.coldsMatStoreEmptL3DataTablePosition = new System.Data.DataColumn();
            this.coldsMatStoreEmptL3DataTableID = new System.Data.DataColumn();
            this.coldsMatStoreEmptL3DataTableNewOldFlag = new System.Data.DataColumn();
            this.coldsMatStoreEmptL3DataTableAmount = new System.Data.DataColumn();
            this.coldsMatStoreEmptL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMatStoreEmptL3DataTableLogDate = new System.Data.DataColumn();
            this.dvStore = new System.Windows.Forms.DataGridView();
            this.storeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.beforMaterialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCODE = new System.Data.DataColumn();
            this.afterMaterialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeMaterialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterMaterialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operateModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAlloyMainInfoQuery = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlloyMainInfoQuery = new AppSvrHMI.L3DataSet();
            this.schemadsStore = new System.Data.DataTable();
            this.coldsAlloyMainInfoQueryL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableName = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableStoreID = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableBeforeMaterialID = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableBeforMaterialName = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableOperateMode = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableOperater = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableOperatorTime = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialID = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialName = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableBeforeWeight = new System.Data.DataColumn();
            this.coldsAlloyMainInfoQueryL3DataTableAfterWeight = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripToriDateTimePicker1 = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dsMaterial = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableStoreID = new System.Data.DataColumn();
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
            this.dsTempt = new AppSvrHMI.L3DataSet();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMatStoreEmpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatSotreEmpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatStoreEmpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatStoreEmpt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyMainInfoQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyMainInfoQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempt)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvMatStoreEmpt);
            this.hmiRootPanel1.Controls.Add(this.dvStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(924, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvMatStoreEmpt
            // 
            this.dvMatStoreEmpt.AllowUserToAddRows = false;
            this.dvMatStoreEmpt.AutoGenerateColumns = false;
            this.dvMatStoreEmpt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.newOldFlagDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.logDateDataGridViewTextBoxColumn});
            this.dvMatStoreEmpt.DataSource = this.bsMatSotreEmpt;
            this.dvMatStoreEmpt.Location = new System.Drawing.Point(23, 254);
            this.dvMatStoreEmpt.Name = "dvMatStoreEmpt";
            this.dvMatStoreEmpt.ReadOnly = true;
            this.dvMatStoreEmpt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvMatStoreEmpt.RowTemplate.Height = 23;
            this.dvMatStoreEmpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvMatStoreEmpt.Size = new System.Drawing.Size(788, 150);
            this.dvMatStoreEmpt.TabIndex = 30;
            this.dvMatStoreEmpt.Visible = false;
            this.dvMatStoreEmpt.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMatStoreEmpt_DataError);
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.DataSource = this.dsAlloyArea;
            this.positionDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.positionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.positionDataGridViewTextBoxColumn.HeaderText = "料仓仓位";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.positionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.positionDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsAlloyArea
            // 
            this.dsAlloyArea.AutoLoad = true;
            this.dsAlloyArea.AutoSubscribe = true;
            this.dsAlloyArea.DataSetName = "L3DataSet";
            this.dsAlloyArea.DeleteMethod = null;
            this.dsAlloyArea.InsertMethod = null;
            this.dsAlloyArea.L3DataAdapter = this.Adapter;
            this.dsAlloyArea.LoadEvent = "Click";
            this.dsAlloyArea.LoadTrigger = null;
            this.dsAlloyArea.RefreshValve = 1000;
            this.dsAlloyArea.SourceCommand = null;
            this.dsAlloyArea.SourceCondition = "(CODE_GROUP = \'AlloyArea\' or CODE_GROUP = \'AlloyGround\' or code_group = \'AlloyWir" +
                "e\') and CODE is not null";
            this.dsAlloyArea.SourceMethod = "";
            this.dsAlloyArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyArea.SubscribeTarget = null;
            this.dsAlloyArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyArea});
            this.dsAlloyArea.UpdateEvent = "Click";
            this.dsAlloyArea.UpdateMethod = null;
            this.dsAlloyArea.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsAlloyArea
            // 
            this.schemadsAlloyArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyAreaL3DataTableCode,
            this.coldsAlloyAreaL3DataTableCode_Des});
            this.schemadsAlloyArea.TableName = "L3DataTable";
            // 
            // coldsAlloyAreaL3DataTableCode
            // 
            this.coldsAlloyAreaL3DataTableCode.Caption = "Code";
            this.coldsAlloyAreaL3DataTableCode.ColumnName = "Code";
            this.coldsAlloyAreaL3DataTableCode.Namespace = "";
            // 
            // coldsAlloyAreaL3DataTableCode_Des
            // 
            this.coldsAlloyAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAlloyAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyAreaL3DataTableCode_Des.Namespace = "";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "物料编码";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // newOldFlagDataGridViewTextBoxColumn
            // 
            this.newOldFlagDataGridViewTextBoxColumn.DataPropertyName = "NewOldFlag";
            this.newOldFlagDataGridViewTextBoxColumn.HeaderText = "NewOldFlag";
            this.newOldFlagDataGridViewTextBoxColumn.Name = "newOldFlagDataGridViewTextBoxColumn";
            this.newOldFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.newOldFlagDataGridViewTextBoxColumn.Visible = false;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "料仓重量(清零前)";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 138;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.DataSource = this.dsOperator;
            this.operatorDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Operator_Name";
            this.operatorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.operatorDataGridViewTextBoxColumn.HeaderText = "维护责任人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.operatorDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Operator";
            // 
            // dsOperator
            // 
            this.dsOperator.AutoLoad = true;
            this.dsOperator.AutoSubscribe = false;
            this.dsOperator.DataSetName = "L3DataSet";
            this.dsOperator.DeleteMethod = "";
            this.dsOperator.InsertMethod = "";
            this.dsOperator.L3DataAdapter = this.Adapter;
            this.dsOperator.LoadEvent = "";
            this.dsOperator.LoadTrigger = null;
            this.dsOperator.RefreshValve = 1000;
            this.dsOperator.SourceCommand = null;
            this.dsOperator.SourceCondition = "";
            this.dsOperator.SourceMethod = "";
            this.dsOperator.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOperator.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Operator_ID";
            this.dsOperator.SubscribeTarget = null;
            this.dsOperator.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOperator});
            this.dsOperator.UpdateEvent = "";
            this.dsOperator.UpdateMethod = "";
            this.dsOperator.UpdateTrigger = null;
            // 
            // schemadsOperator
            // 
            this.schemadsOperator.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOperatorL3DataTableOperator,
            this.coldsOperatorL3DataTableOperator_Name});
            this.schemadsOperator.TableName = "L3DataTable";
            // 
            // coldsOperatorL3DataTableOperator
            // 
            this.coldsOperatorL3DataTableOperator.Caption = "Operator";
            this.coldsOperatorL3DataTableOperator.ColumnName = "Operator";
            this.coldsOperatorL3DataTableOperator.Namespace = "";
            // 
            // coldsOperatorL3DataTableOperator_Name
            // 
            this.coldsOperatorL3DataTableOperator_Name.Caption = "Operator_Name";
            this.coldsOperatorL3DataTableOperator_Name.ColumnName = "Operator_Name";
            this.coldsOperatorL3DataTableOperator_Name.Namespace = "";
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "维护日期";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsMatSotreEmpt
            // 
            this.bsMatSotreEmpt.DataMember = "L3DataTable";
            this.bsMatSotreEmpt.DataSource = this.dsMatStoreEmpt;
            this.bsMatSotreEmpt.Filter = "NewOldFlag= 2";
            // 
            // dsMatStoreEmpt
            // 
            this.dsMatStoreEmpt.AutoLoad = true;
            this.dsMatStoreEmpt.AutoSubscribe = false;
            this.dsMatStoreEmpt.DataSetName = "L3DataSet";
            this.dsMatStoreEmpt.DeleteMethod = "";
            this.dsMatStoreEmpt.InsertMethod = "";
            this.dsMatStoreEmpt.L3DataAdapter = this.Adapter;
            this.dsMatStoreEmpt.LoadEvent = "";
            this.dsMatStoreEmpt.LoadTrigger = null;
            this.dsMatStoreEmpt.RefreshValve = 1000;
            this.dsMatStoreEmpt.SourceCommand = null;
            this.dsMatStoreEmpt.SourceCondition = "1=1 order by LogDate desc";
            this.dsMatStoreEmpt.SourceMethod = "";
            this.dsMatStoreEmpt.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatStoreEmpt.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_PropChange_Log";
            this.dsMatStoreEmpt.SubscribeTarget = null;
            this.dsMatStoreEmpt.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatStoreEmpt});
            this.dsMatStoreEmpt.UpdateEvent = "";
            this.dsMatStoreEmpt.UpdateMethod = "";
            this.dsMatStoreEmpt.UpdateTrigger = null;
            // 
            // schemadsMatStoreEmpt
            // 
            this.schemadsMatStoreEmpt.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatStoreEmptL3DataTablePosition,
            this.coldsMatStoreEmptL3DataTableID,
            this.coldsMatStoreEmptL3DataTableNewOldFlag,
            this.coldsMatStoreEmptL3DataTableAmount,
            this.coldsMatStoreEmptL3DataTableOperator,
            this.coldsMatStoreEmptL3DataTableLogDate});
            this.schemadsMatStoreEmpt.TableName = "L3DataTable";
            // 
            // coldsMatStoreEmptL3DataTablePosition
            // 
            this.coldsMatStoreEmptL3DataTablePosition.Caption = "Position";
            this.coldsMatStoreEmptL3DataTablePosition.ColumnName = "Position";
            this.coldsMatStoreEmptL3DataTablePosition.Namespace = "";
            // 
            // coldsMatStoreEmptL3DataTableID
            // 
            this.coldsMatStoreEmptL3DataTableID.Caption = "ID";
            this.coldsMatStoreEmptL3DataTableID.ColumnName = "ID";
            this.coldsMatStoreEmptL3DataTableID.Namespace = "";
            // 
            // coldsMatStoreEmptL3DataTableNewOldFlag
            // 
            this.coldsMatStoreEmptL3DataTableNewOldFlag.Caption = "NewOldFlag";
            this.coldsMatStoreEmptL3DataTableNewOldFlag.ColumnName = "NewOldFlag";
            this.coldsMatStoreEmptL3DataTableNewOldFlag.DataType = typeof(int);
            this.coldsMatStoreEmptL3DataTableNewOldFlag.Namespace = "";
            // 
            // coldsMatStoreEmptL3DataTableAmount
            // 
            this.coldsMatStoreEmptL3DataTableAmount.Caption = "Amount";
            this.coldsMatStoreEmptL3DataTableAmount.ColumnName = "Amount";
            this.coldsMatStoreEmptL3DataTableAmount.DataType = typeof(double);
            this.coldsMatStoreEmptL3DataTableAmount.Namespace = "";
            // 
            // coldsMatStoreEmptL3DataTableOperator
            // 
            this.coldsMatStoreEmptL3DataTableOperator.Caption = "Operator";
            this.coldsMatStoreEmptL3DataTableOperator.ColumnName = "Operator";
            this.coldsMatStoreEmptL3DataTableOperator.Namespace = "";
            // 
            // coldsMatStoreEmptL3DataTableLogDate
            // 
            this.coldsMatStoreEmptL3DataTableLogDate.Caption = "LogDate";
            this.coldsMatStoreEmptL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsMatStoreEmptL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsMatStoreEmptL3DataTableLogDate.Namespace = "";
            // 
            // dvStore
            // 
            this.dvStore.AllowUserToAddRows = false;
            this.dvStore.AutoGenerateColumns = false;
            this.dvStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeIDDataGridViewTextBoxColumn,
            this.beforMaterialNameDataGridViewTextBoxColumn,
            this.afterMaterialNameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.beforeMaterialIDDataGridViewTextBoxColumn,
            this.afterMaterialIDDataGridViewTextBoxColumn,
            this.operateModeDataGridViewTextBoxColumn,
            this.beforeWeightDataGridViewTextBoxColumn,
            this.afterWeightDataGridViewTextBoxColumn,
            this.operaterDataGridViewTextBoxColumn,
            this.operatorTimeDataGridViewTextBoxColumn});
            this.dvStore.DataSource = this.bsAlloyMainInfoQuery;
            this.dvStore.Location = new System.Drawing.Point(0, 25);
            this.dvStore.Name = "dvStore";
            this.dvStore.ReadOnly = true;
            this.dvStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvStore.RowTemplate.Height = 23;
            this.dvStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvStore.Size = new System.Drawing.Size(836, 136);
            this.dvStore.TabIndex = 29;
            this.dvStore.Visible = false;
            // 
            // storeIDDataGridViewTextBoxColumn
            // 
            this.storeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.storeIDDataGridViewTextBoxColumn.DataPropertyName = "StoreID";
            this.storeIDDataGridViewTextBoxColumn.DataSource = this.dsAlloyArea;
            this.storeIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.storeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.storeIDDataGridViewTextBoxColumn.HeaderText = "料仓仓位";
            this.storeIDDataGridViewTextBoxColumn.Name = "storeIDDataGridViewTextBoxColumn";
            this.storeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.storeIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.storeIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // beforMaterialNameDataGridViewTextBoxColumn
            // 
            this.beforMaterialNameDataGridViewTextBoxColumn.DataPropertyName = "BeforMaterialName";
            this.beforMaterialNameDataGridViewTextBoxColumn.DataSource = this.dsAlloyCode;
            this.beforMaterialNameDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.beforMaterialNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.beforMaterialNameDataGridViewTextBoxColumn.HeaderText = "物料(维护前)";
            this.beforMaterialNameDataGridViewTextBoxColumn.Name = "beforMaterialNameDataGridViewTextBoxColumn";
            this.beforMaterialNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.beforMaterialNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.beforMaterialNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.beforMaterialNameDataGridViewTextBoxColumn.ValueMember = "L3DataTable.CODE";
            this.beforMaterialNameDataGridViewTextBoxColumn.Width = 102;
            // 
            // dsAlloyCode
            // 
            this.dsAlloyCode.AutoLoad = true;
            this.dsAlloyCode.AutoSubscribe = true;
            this.dsAlloyCode.DataSetName = "L3DataSet";
            this.dsAlloyCode.DeleteMethod = "";
            this.dsAlloyCode.InsertMethod = "";
            this.dsAlloyCode.L3DataAdapter = this.Adapter;
            this.dsAlloyCode.LoadEvent = "Click";
            this.dsAlloyCode.LoadTrigger = null;
            this.dsAlloyCode.RefreshValve = 1000;
            this.dsAlloyCode.SourceCommand = null;
            this.dsAlloyCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\'";
            this.dsAlloyCode.SourceMethod = "";
            this.dsAlloyCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyCode.SubscribeTarget = "";
            this.dsAlloyCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyCode});
            this.dsAlloyCode.UpdateEvent = "Click";
            this.dsAlloyCode.UpdateMethod = "";
            this.dsAlloyCode.UpdateTrigger = null;
            // 
            // schemadsAlloyCode
            // 
            this.schemadsAlloyCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyCodeL3DataTableCode_Des,
            this.coldsAlloyCodeL3DataTableCODE});
            this.schemadsAlloyCode.TableName = "L3DataTable";
            // 
            // coldsAlloyCodeL3DataTableCode_Des
            // 
            this.coldsAlloyCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAlloyCodeL3DataTableCODE
            // 
            this.coldsAlloyCodeL3DataTableCODE.Caption = "Code";
            this.coldsAlloyCodeL3DataTableCODE.ColumnName = "CODE";
            this.coldsAlloyCodeL3DataTableCODE.Namespace = "";
            // 
            // afterMaterialNameDataGridViewTextBoxColumn
            // 
            this.afterMaterialNameDataGridViewTextBoxColumn.DataPropertyName = "AfterMaterialName";
            this.afterMaterialNameDataGridViewTextBoxColumn.DataSource = this.dsAlloyCode;
            this.afterMaterialNameDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.afterMaterialNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.afterMaterialNameDataGridViewTextBoxColumn.HeaderText = "物料(维护后)";
            this.afterMaterialNameDataGridViewTextBoxColumn.Name = "afterMaterialNameDataGridViewTextBoxColumn";
            this.afterMaterialNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.afterMaterialNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.afterMaterialNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.afterMaterialNameDataGridViewTextBoxColumn.ValueMember = "L3DataTable.CODE";
            this.afterMaterialNameDataGridViewTextBoxColumn.Width = 102;
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
            // beforeMaterialIDDataGridViewTextBoxColumn
            // 
            this.beforeMaterialIDDataGridViewTextBoxColumn.DataPropertyName = "BeforeMaterialID";
            this.beforeMaterialIDDataGridViewTextBoxColumn.HeaderText = "BeforeMaterialID";
            this.beforeMaterialIDDataGridViewTextBoxColumn.Name = "beforeMaterialIDDataGridViewTextBoxColumn";
            this.beforeMaterialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.beforeMaterialIDDataGridViewTextBoxColumn.Visible = false;
            this.beforeMaterialIDDataGridViewTextBoxColumn.Width = 126;
            // 
            // afterMaterialIDDataGridViewTextBoxColumn
            // 
            this.afterMaterialIDDataGridViewTextBoxColumn.DataPropertyName = "AfterMaterialID";
            this.afterMaterialIDDataGridViewTextBoxColumn.HeaderText = "AfterMaterialID";
            this.afterMaterialIDDataGridViewTextBoxColumn.Name = "afterMaterialIDDataGridViewTextBoxColumn";
            this.afterMaterialIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.afterMaterialIDDataGridViewTextBoxColumn.Visible = false;
            this.afterMaterialIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // operateModeDataGridViewTextBoxColumn
            // 
            this.operateModeDataGridViewTextBoxColumn.DataPropertyName = "OperateMode";
            this.operateModeDataGridViewTextBoxColumn.HeaderText = "操作方式";
            this.operateModeDataGridViewTextBoxColumn.Name = "operateModeDataGridViewTextBoxColumn";
            this.operateModeDataGridViewTextBoxColumn.ReadOnly = true;
            this.operateModeDataGridViewTextBoxColumn.Width = 78;
            // 
            // beforeWeightDataGridViewTextBoxColumn
            // 
            this.beforeWeightDataGridViewTextBoxColumn.DataPropertyName = "BeforeWeight";
            this.beforeWeightDataGridViewTextBoxColumn.HeaderText = "重量(料仓清零前)";
            this.beforeWeightDataGridViewTextBoxColumn.Name = "beforeWeightDataGridViewTextBoxColumn";
            this.beforeWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.beforeWeightDataGridViewTextBoxColumn.Visible = false;
            this.beforeWeightDataGridViewTextBoxColumn.Width = 126;
            // 
            // afterWeightDataGridViewTextBoxColumn
            // 
            this.afterWeightDataGridViewTextBoxColumn.DataPropertyName = "AfterWeight";
            this.afterWeightDataGridViewTextBoxColumn.HeaderText = "重量(料仓清零前)";
            this.afterWeightDataGridViewTextBoxColumn.Name = "afterWeightDataGridViewTextBoxColumn";
            this.afterWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.afterWeightDataGridViewTextBoxColumn.Visible = false;
            this.afterWeightDataGridViewTextBoxColumn.Width = 126;
            // 
            // operaterDataGridViewTextBoxColumn
            // 
            this.operaterDataGridViewTextBoxColumn.DataPropertyName = "Operater";
            this.operaterDataGridViewTextBoxColumn.HeaderText = "维护责任人";
            this.operaterDataGridViewTextBoxColumn.Name = "operaterDataGridViewTextBoxColumn";
            this.operaterDataGridViewTextBoxColumn.ReadOnly = true;
            this.operaterDataGridViewTextBoxColumn.Width = 90;
            // 
            // operatorTimeDataGridViewTextBoxColumn
            // 
            this.operatorTimeDataGridViewTextBoxColumn.DataPropertyName = "OperatorTime";
            this.operatorTimeDataGridViewTextBoxColumn.HeaderText = "维护日期";
            this.operatorTimeDataGridViewTextBoxColumn.Name = "operatorTimeDataGridViewTextBoxColumn";
            this.operatorTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // bsAlloyMainInfoQuery
            // 
            this.bsAlloyMainInfoQuery.DataMember = "L3DataTable";
            this.bsAlloyMainInfoQuery.DataSource = this.dsAlloyMainInfoQuery;
            this.bsAlloyMainInfoQuery.Filter = "";
            // 
            // dsAlloyMainInfoQuery
            // 
            this.dsAlloyMainInfoQuery.AutoLoad = true;
            this.dsAlloyMainInfoQuery.AutoSubscribe = false;
            this.dsAlloyMainInfoQuery.DataSetName = "L3DataSet";
            this.dsAlloyMainInfoQuery.DeleteMethod = "";
            this.dsAlloyMainInfoQuery.InsertMethod = "";
            this.dsAlloyMainInfoQuery.L3DataAdapter = this.Adapter;
            this.dsAlloyMainInfoQuery.LoadEvent = "";
            this.dsAlloyMainInfoQuery.LoadTrigger = null;
            this.dsAlloyMainInfoQuery.RefreshValve = 1000;
            this.dsAlloyMainInfoQuery.SourceCommand = null;
            this.dsAlloyMainInfoQuery.SourceCondition = "1=1 order by OperatorTime desc";
            this.dsAlloyMainInfoQuery.SourceMethod = "";
            this.dsAlloyMainInfoQuery.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyMainInfoQuery.SourceURI = "XGMESLogic\\AlloyStoreMag\\CStoreOperateLog";
            this.dsAlloyMainInfoQuery.SubscribeTarget = null;
            this.dsAlloyMainInfoQuery.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStore});
            this.dsAlloyMainInfoQuery.UpdateEvent = "";
            this.dsAlloyMainInfoQuery.UpdateMethod = "";
            this.dsAlloyMainInfoQuery.UpdateTrigger = null;
            // 
            // schemadsStore
            // 
            this.schemadsStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyMainInfoQueryL3DataTableGUID,
            this.coldsAlloyMainInfoQueryL3DataTableName,
            this.coldsAlloyMainInfoQueryL3DataTableStoreID,
            this.coldsAlloyMainInfoQueryL3DataTableBeforeMaterialID,
            this.coldsAlloyMainInfoQueryL3DataTableBeforMaterialName,
            this.coldsAlloyMainInfoQueryL3DataTableOperateMode,
            this.coldsAlloyMainInfoQueryL3DataTableOperater,
            this.coldsAlloyMainInfoQueryL3DataTableOperatorTime,
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialID,
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialName,
            this.coldsAlloyMainInfoQueryL3DataTableBeforeWeight,
            this.coldsAlloyMainInfoQueryL3DataTableAfterWeight});
            this.schemadsStore.TableName = "L3DataTable";
            // 
            // coldsAlloyMainInfoQueryL3DataTableGUID
            // 
            this.coldsAlloyMainInfoQueryL3DataTableGUID.Caption = "GUID";
            this.coldsAlloyMainInfoQueryL3DataTableGUID.ColumnName = "GUID";
            this.coldsAlloyMainInfoQueryL3DataTableGUID.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableName
            // 
            this.coldsAlloyMainInfoQueryL3DataTableName.Caption = "Name";
            this.coldsAlloyMainInfoQueryL3DataTableName.ColumnName = "Name";
            this.coldsAlloyMainInfoQueryL3DataTableName.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableStoreID
            // 
            this.coldsAlloyMainInfoQueryL3DataTableStoreID.Caption = "StoreID";
            this.coldsAlloyMainInfoQueryL3DataTableStoreID.ColumnName = "StoreID";
            this.coldsAlloyMainInfoQueryL3DataTableStoreID.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableBeforeMaterialID
            // 
            this.coldsAlloyMainInfoQueryL3DataTableBeforeMaterialID.Caption = "BeforeMaterialID";
            this.coldsAlloyMainInfoQueryL3DataTableBeforeMaterialID.ColumnName = "BeforeMaterialID";
            this.coldsAlloyMainInfoQueryL3DataTableBeforeMaterialID.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableBeforMaterialName
            // 
            this.coldsAlloyMainInfoQueryL3DataTableBeforMaterialName.Caption = "BeforMaterialName";
            this.coldsAlloyMainInfoQueryL3DataTableBeforMaterialName.ColumnName = "BeforMaterialName";
            this.coldsAlloyMainInfoQueryL3DataTableBeforMaterialName.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableOperateMode
            // 
            this.coldsAlloyMainInfoQueryL3DataTableOperateMode.Caption = "OperateMode";
            this.coldsAlloyMainInfoQueryL3DataTableOperateMode.ColumnName = "OperateMode";
            this.coldsAlloyMainInfoQueryL3DataTableOperateMode.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableOperater
            // 
            this.coldsAlloyMainInfoQueryL3DataTableOperater.Caption = "Operater";
            this.coldsAlloyMainInfoQueryL3DataTableOperater.ColumnName = "Operater";
            this.coldsAlloyMainInfoQueryL3DataTableOperater.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableOperatorTime
            // 
            this.coldsAlloyMainInfoQueryL3DataTableOperatorTime.Caption = "OperatorTime";
            this.coldsAlloyMainInfoQueryL3DataTableOperatorTime.ColumnName = "OperatorTime";
            this.coldsAlloyMainInfoQueryL3DataTableOperatorTime.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableAfterMaterialID
            // 
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialID.Caption = "AfterMaterialID";
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialID.ColumnName = "AfterMaterialID";
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialID.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableAfterMaterialName
            // 
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialName.Caption = "AfterMaterialName";
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialName.ColumnName = "AfterMaterialName";
            this.coldsAlloyMainInfoQueryL3DataTableAfterMaterialName.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableBeforeWeight
            // 
            this.coldsAlloyMainInfoQueryL3DataTableBeforeWeight.Caption = "BeforeWeight";
            this.coldsAlloyMainInfoQueryL3DataTableBeforeWeight.ColumnName = "BeforeWeight";
            this.coldsAlloyMainInfoQueryL3DataTableBeforeWeight.Namespace = "";
            // 
            // coldsAlloyMainInfoQueryL3DataTableAfterWeight
            // 
            this.coldsAlloyMainInfoQueryL3DataTableAfterWeight.Caption = "AfterWeight";
            this.coldsAlloyMainInfoQueryL3DataTableAfterWeight.ColumnName = "AfterWeight";
            this.coldsAlloyMainInfoQueryL3DataTableAfterWeight.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
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
            this.toolStripToriDateTimePicker1,
            this.toolStripLabel2,
            this.tsCmbType,
            this.toolStripLabel1});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(924, 25);
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
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
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
            this.btnOutput.Image = global::StoreMag.Properties.Resources.导出到excel;
            this.btnOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // toolStripToriDateTimePicker1
            // 
            this.toolStripToriDateTimePicker1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripToriDateTimePicker1.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.toolStripToriDateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripToriDateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.toolStripToriDateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.toolStripToriDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toolStripToriDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.toolStripToriDateTimePicker1.MaximumSize = new System.Drawing.Size(0, 0);
            this.toolStripToriDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.toolStripToriDateTimePicker1.MinimumSize = new System.Drawing.Size(0, 0);
            this.toolStripToriDateTimePicker1.Name = "toolStripToriDateTimePicker1";
            this.toolStripToriDateTimePicker1.Size = new System.Drawing.Size(168, 22);
            this.toolStripToriDateTimePicker1.Text = "2011-03-18";
            this.toolStripToriDateTimePicker1.Value = new System.DateTime(2011, 3, 18, 10, 40, 22, 234);
            this.toolStripToriDateTimePicker1.TextChanged += new System.EventHandler(this.toolStripToriDateTimePicker1_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel2.Text = "  按时间查询:";
            // 
            // tsCmbType
            // 
            this.tsCmbType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsCmbType.Items.AddRange(new object[] {
            "",
            "物料维护",
            "料仓清零"});
            this.tsCmbType.Name = "tsCmbType";
            this.tsCmbType.Size = new System.Drawing.Size(121, 25);
            this.tsCmbType.SelectedIndexChanged += new System.EventHandler(this.tsCmbType_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "选择查询类型:";
            // 
            // dsMaterial
            // 
            this.dsMaterial.AutoLoad = true;
            this.dsMaterial.AutoSubscribe = false;
            this.dsMaterial.DataSetName = "L3DataSet";
            this.dsMaterial.DeleteMethod = "";
            this.dsMaterial.InsertMethod = "";
            this.dsMaterial.L3DataAdapter = this.Adapter;
            this.dsMaterial.LoadEvent = "";
            this.dsMaterial.LoadTrigger = null;
            this.dsMaterial.RefreshValve = 1000;
            this.dsMaterial.SourceCommand = null;
            this.dsMaterial.SourceCondition = "";
            this.dsMaterial.SourceMethod = "";
            this.dsMaterial.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMaterial.SourceURI = "XGMESLogic\\AlloyStoreMag\\CStoreOperateLog";
            this.dsMaterial.SubscribeTarget = null;
            this.dsMaterial.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsMaterial.UpdateEvent = "";
            this.dsMaterial.UpdateMethod = "";
            this.dsMaterial.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableStoreID});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableStoreID
            // 
            this.coll3DataSet1L3DataTableStoreID.Caption = "StoreID";
            this.coll3DataSet1L3DataTableStoreID.ColumnName = "StoreID";
            this.coll3DataSet1L3DataTableStoreID.Namespace = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NewOldFlag";
            this.dataGridViewTextBoxColumn1.HeaderText = "NewOldFlag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "料仓重量(清零前)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 138;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LogDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "维护日期";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn4.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BeforeMaterialID";
            this.dataGridViewTextBoxColumn6.HeaderText = "BeforeMaterialID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 126;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AfterMaterialID";
            this.dataGridViewTextBoxColumn7.HeaderText = "AfterMaterialID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OperateMode";
            this.dataGridViewTextBoxColumn8.HeaderText = "操作方式";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "BeforeWeight";
            this.dataGridViewTextBoxColumn9.HeaderText = "重量(料仓清零前)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 126;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AfterWeight";
            this.dataGridViewTextBoxColumn10.HeaderText = "重量(料仓清零前)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 126;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Operater";
            this.dataGridViewTextBoxColumn11.HeaderText = "维护责任人";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OperatorTime";
            this.dataGridViewTextBoxColumn12.HeaderText = "维护日期";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 78;
            // 
            // dsTempt
            // 
            this.dsTempt.AutoLoad = true;
            this.dsTempt.AutoSubscribe = false;
            this.dsTempt.DataSetName = "dsTempt";
            this.dsTempt.DeleteMethod = "";
            this.dsTempt.InsertMethod = "";
            this.dsTempt.L3DataAdapter = this.Adapter;
            this.dsTempt.LoadEvent = "";
            this.dsTempt.LoadTrigger = null;
            this.dsTempt.RefreshValve = 1000;
            this.dsTempt.SourceCommand = null;
            this.dsTempt.SourceCondition = "";
            this.dsTempt.SourceMethod = "";
            this.dsTempt.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTempt.SourceURI = "XGMESLogic\\AlloyStoreMag\\CStoreOperateLog";
            this.dsTempt.SubscribeTarget = null;
            this.dsTempt.UpdateEvent = "";
            this.dsTempt.UpdateMethod = "";
            this.dsTempt.UpdateTrigger = null;
            // 
            // AlloyStoreMagQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "AlloyStoreMagQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "合金料仓料种维护信息查询";
            this.Text = "合金料仓料种维护信息查询";
            this.Load += new System.EventHandler(this.AlloyStoreMagQuery_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMatStoreEmpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatSotreEmpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatStoreEmpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatStoreEmpt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyMainInfoQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyMainInfoQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempt)).EndInit();
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
        private System.Windows.Forms.DataGridView dvStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.BindingSource bsAlloyMainInfoQuery;
        private AppSvrHMI.L3DataSet dsAlloyMainInfoQuery;
        private System.Data.DataTable schemadsStore;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableGUID;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableName;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableStoreID;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableBeforeMaterialID;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableBeforMaterialName;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableOperateMode;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableOperater;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableOperatorTime;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableAfterMaterialID;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableAfterMaterialName;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableBeforeWeight;
        private System.Data.DataColumn coldsAlloyMainInfoQueryL3DataTableAfterWeight;
        private AppSvrHMI.L3DataSet dsMaterial;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableStoreID;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private AppSvrHMI.L3DataSet dsAlloyArea;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private System.Data.DataTable schemadsAlloyArea;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode_Des;
        private buttonHide.ToolStripToriDateTimePicker toolStripToriDateTimePicker1;
        private System.Windows.Forms.BindingSource bsMatSotreEmpt;
        private AppSvrHMI.L3DataSet dsMatStoreEmpt;
        private System.Data.DataTable schemadsMatStoreEmpt;
        private System.Data.DataColumn coldsMatStoreEmptL3DataTablePosition;
        private System.Data.DataColumn coldsMatStoreEmptL3DataTableID;
        private System.Data.DataColumn coldsMatStoreEmptL3DataTableNewOldFlag;
        private System.Data.DataColumn coldsMatStoreEmptL3DataTableAmount;
        private System.Data.DataColumn coldsMatStoreEmptL3DataTableOperator;
        private System.Data.DataColumn coldsMatStoreEmptL3DataTableLogDate;
        private System.Windows.Forms.DataGridView dvMatStoreEmpt;
        private AppSvrHMI.L3DataSet dsOperator;
        private System.Data.DataTable schemadsOperator;
        private System.Data.DataColumn coldsOperatorL3DataTableOperator;
        private System.Data.DataColumn coldsOperatorL3DataTableOperator_Name;
        private System.Windows.Forms.ToolStripComboBox tsCmbType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCODE;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn storeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn beforMaterialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn afterMaterialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeMaterialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterMaterialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operateModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorTimeDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsTempt;
        private System.Windows.Forms.DataGridViewComboBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newOldFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
    }
}