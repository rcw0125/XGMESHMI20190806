namespace StoreMag.BulkStore
{
    partial class BalanceQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBulkArea = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBulkArea = new System.Data.DataTable();
            this.coldsBulkAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newOldFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsModify = new AppSvrHMI.L3DataSet();
            this.schemadsModify = new System.Data.DataTable();
            this.coldsModifyL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsModifyL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBalance = new System.Windows.Forms.BindingSource(this.components);
            this.dsBalance = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableName = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAmount = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePosition = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableNewOldFlag = new System.Data.DataColumn();
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
            this.dtOutStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtOutStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(887, 533);
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
            this.logDateDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.newOldFlagDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsBalance;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInStore.Size = new System.Drawing.Size(887, 508);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "出库日期";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.logDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.DataSource = this.dsBulkArea;
            this.positionDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.positionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.positionDataGridViewTextBoxColumn.HeaderText = "库区";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.positionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.positionDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.positionDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsBulkArea
            // 
            this.dsBulkArea.AutoSubscribe = true;
            this.dsBulkArea.DataSetName = "L3DataSet";
            this.dsBulkArea.DeleteMethod = null;
            this.dsBulkArea.InsertMethod = null;
            this.dsBulkArea.L3DataAdapter = this.Adapter;
            this.dsBulkArea.LoadEvent = "Click";
            this.dsBulkArea.LoadTrigger = null;
            this.dsBulkArea.RefreshValve = 1000;
            this.dsBulkArea.SourceCommand = null;
            this.dsBulkArea.SourceCondition = "CODE_GROUP = \'BulkArea\'";
            this.dsBulkArea.SourceMethod = "";
            this.dsBulkArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkArea.SubscribeTarget = null;
            this.dsBulkArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkArea});
            this.dsBulkArea.UpdateEvent = "Click";
            this.dsBulkArea.UpdateMethod = null;
            this.dsBulkArea.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBulkArea
            // 
            this.schemadsBulkArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkAreaL3DataTableCode,
            this.coldsBulkAreaL3DataTableCode_Des});
            this.schemadsBulkArea.TableName = "L3DataTable";
            // 
            // coldsBulkAreaL3DataTableCode
            // 
            this.coldsBulkAreaL3DataTableCode.Caption = "Code";
            this.coldsBulkAreaL3DataTableCode.ColumnName = "Code";
            this.coldsBulkAreaL3DataTableCode.Namespace = "";
            // 
            // coldsBulkAreaL3DataTableCode_Des
            // 
            this.coldsBulkAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.Namespace = "";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "材料量";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 66;
            // 
            // newOldFlagDataGridViewTextBoxColumn
            // 
            this.newOldFlagDataGridViewTextBoxColumn.DataPropertyName = "NewOldFlag";
            this.newOldFlagDataGridViewTextBoxColumn.DataSource = this.dsModify;
            this.newOldFlagDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.newOldFlagDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.newOldFlagDataGridViewTextBoxColumn.HeaderText = "数据类型";
            this.newOldFlagDataGridViewTextBoxColumn.Name = "newOldFlagDataGridViewTextBoxColumn";
            this.newOldFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.newOldFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.newOldFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.newOldFlagDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.newOldFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsModify
            // 
            this.dsModify.AutoSubscribe = true;
            this.dsModify.DataSetName = "L3DataSet";
            this.dsModify.DeleteMethod = null;
            this.dsModify.InsertMethod = null;
            this.dsModify.L3DataAdapter = this.Adapter;
            this.dsModify.LoadEvent = "Click";
            this.dsModify.LoadTrigger = null;
            this.dsModify.RefreshValve = 1000;
            this.dsModify.SourceCommand = null;
            this.dsModify.SourceCondition = "CODE_GROUP = \'MODIFY_TYPE\'";
            this.dsModify.SourceMethod = "";
            this.dsModify.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsModify.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsModify.SubscribeTarget = null;
            this.dsModify.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsModify});
            this.dsModify.UpdateEvent = "Click";
            this.dsModify.UpdateMethod = null;
            this.dsModify.UpdateTrigger = null;
            // 
            // schemadsModify
            // 
            this.schemadsModify.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsModifyL3DataTableCode_Des,
            this.coldsModifyL3DataTableCode_Val_Long});
            this.schemadsModify.TableName = "L3DataTable";
            // 
            // coldsModifyL3DataTableCode_Des
            // 
            this.coldsModifyL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsModifyL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsModifyL3DataTableCode_Des.Namespace = "";
            // 
            // coldsModifyL3DataTableCode_Val_Long
            // 
            this.coldsModifyL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsModifyL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsModifyL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsModifyL3DataTableCode_Val_Long.Namespace = "";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "修改人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 42;
            // 
            // bsBalance
            // 
            this.bsBalance.DataMember = "L3DataTable";
            this.bsBalance.DataSource = this.dsBalance;
            // 
            // dsBalance
            // 
            this.dsBalance.AutoSubscribe = true;
            this.dsBalance.DataSetName = "L3DataSet";
            this.dsBalance.DeleteMethod = null;
            this.dsBalance.InsertMethod = null;
            this.dsBalance.L3DataAdapter = null;
            this.dsBalance.LoadEvent = "Click";
            this.dsBalance.LoadTrigger = null;
            this.dsBalance.RefreshValve = 1000;
            this.dsBalance.SourceCommand = null;
            this.dsBalance.SourceCondition = "1=2";
            this.dsBalance.SourceMethod = "";
            this.dsBalance.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBalance.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_PropChange_Log";
            this.dsBalance.SubscribeTarget = "";
            this.dsBalance.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsBalance.UpdateEvent = "Click";
            this.dsBalance.UpdateMethod = null;
            this.dsBalance.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableGUID,
            this.coldsInStoreL3DataTableName,
            this.coldsInStoreL3DataTableAmount,
            this.coldsInStoreL3DataTableOperator,
            this.coldsBalanceL3DataTableLogDate,
            this.coldsBalanceL3DataTablePosition,
            this.coldsBalanceL3DataTableID,
            this.coldsBalanceL3DataTableNewOldFlag});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsInStoreL3DataTableGUID
            // 
            this.coldsInStoreL3DataTableGUID.Caption = "GUID";
            this.coldsInStoreL3DataTableGUID.ColumnName = "GUID";
            this.coldsInStoreL3DataTableGUID.Namespace = "";
            // 
            // coldsInStoreL3DataTableName
            // 
            this.coldsInStoreL3DataTableName.Caption = "Name";
            this.coldsInStoreL3DataTableName.ColumnName = "Name";
            this.coldsInStoreL3DataTableName.Namespace = "";
            // 
            // coldsInStoreL3DataTableAmount
            // 
            this.coldsInStoreL3DataTableAmount.Caption = "Amount";
            this.coldsInStoreL3DataTableAmount.ColumnName = "Amount";
            this.coldsInStoreL3DataTableAmount.DataType = typeof(double);
            this.coldsInStoreL3DataTableAmount.Namespace = "";
            // 
            // coldsInStoreL3DataTableOperator
            // 
            this.coldsInStoreL3DataTableOperator.Caption = "Operator";
            this.coldsInStoreL3DataTableOperator.ColumnName = "Operator";
            this.coldsInStoreL3DataTableOperator.Namespace = "";
            // 
            // coldsBalanceL3DataTableLogDate
            // 
            this.coldsBalanceL3DataTableLogDate.Caption = "LogDate";
            this.coldsBalanceL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsBalanceL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsBalanceL3DataTableLogDate.Namespace = "";
            // 
            // coldsBalanceL3DataTablePosition
            // 
            this.coldsBalanceL3DataTablePosition.Caption = "Position";
            this.coldsBalanceL3DataTablePosition.ColumnName = "Position";
            this.coldsBalanceL3DataTablePosition.Namespace = "";
            // 
            // coldsBalanceL3DataTableID
            // 
            this.coldsBalanceL3DataTableID.Caption = "ID";
            this.coldsBalanceL3DataTableID.ColumnName = "ID";
            this.coldsBalanceL3DataTableID.Namespace = "";
            // 
            // coldsBalanceL3DataTableNewOldFlag
            // 
            this.coldsBalanceL3DataTableNewOldFlag.Caption = "NewOldFlag";
            this.coldsBalanceL3DataTableNewOldFlag.ColumnName = "NewOldFlag";
            this.coldsBalanceL3DataTableNewOldFlag.DataType = typeof(int);
            this.coldsBalanceL3DataTableNewOldFlag.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsBalance;
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
            this.dtOutStoreEndData,
            this.toolStripLabel2,
            this.dtOutStoreData,
            this.toolStripLabel6,
            this.btnOutput});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(887, 25);
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
            // dtOutStoreEndData
            // 
            this.dtOutStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreEndData.Name = "dtOutStoreEndData";
            this.dtOutStoreEndData.Size = new System.Drawing.Size(100, 22);
            this.dtOutStoreEndData.Text = "2009-01-04";
            this.dtOutStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtOutStoreData
            // 
            this.dtOutStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtOutStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStoreData.Name = "dtOutStoreData";
            this.dtOutStoreData.Size = new System.Drawing.Size(100, 22);
            this.dtOutStoreData.Text = "2008-11-16";
            this.dtOutStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "盘库日期:";
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
            // dsTeamID
            // 
            this.dsTeamID.AutoSubscribe = true;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
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
            this.dsShiftID.AutoSubscribe = true;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\'";
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
            // BalanceQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "BalanceQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "散状料盘库查询";
            this.Text = "盘库查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BalanceQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.BalanceQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
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
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsBalance;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableGUID;
        private System.Data.DataColumn coldsInStoreL3DataTableName;
        private System.Data.DataColumn coldsInStoreL3DataTableAmount;
        private System.Data.DataColumn coldsInStoreL3DataTableOperator;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsBalance;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Data.DataColumn coldsBalanceL3DataTableLogDate;
        private System.Data.DataColumn coldsBalanceL3DataTablePosition;
        private System.Data.DataColumn coldsBalanceL3DataTableID;
        private System.Data.DataColumn coldsBalanceL3DataTableNewOldFlag;
        private AppSvrHMI.L3DataSet dsModify;
        private System.Data.DataTable schemadsModify;
        private System.Data.DataColumn coldsModifyL3DataTableCode_Des;
        private System.Data.DataColumn coldsModifyL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsBulkArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn newOldFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}