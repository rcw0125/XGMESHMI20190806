namespace StoreMag.AlloyStore
{
    partial class InStoreQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InStoreQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.MaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alloy_Code = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAreaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStoreArea = new AppSvrHMI.L3DataSet();
            this.schemadsStoreArea = new System.Data.DataTable();
            this.coldsStoreAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.alloyConfirmManDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopConfirmManDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsInStore = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet9 = new System.Data.DataTable();
            this.coll3DataSet9L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableMaterialType = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableMaterialID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableLogDate = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableAmount = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableType = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableReason = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableSource = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableOperator = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableShift = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableTeam = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableBatch_ID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableAlloy_Confirm_Man = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableShop_Confirm_Man = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtInStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtInStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.cmbAlloyCode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).BeginInit();
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
            this.hmiRootPanel1.Size = new System.Drawing.Size(887, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialType,
            this.materialIDDataGridViewTextBoxColumn,
            this.Alloy_Code,
            this.batchIDDataGridViewTextBoxColumn,
            this.LogDate,
            this.amountDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.storeAreaIDDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.alloyConfirmManDataGridViewTextBoxColumn,
            this.shopConfirmManDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.Name1});
            this.dvInStore.DataSource = this.bsInStore;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInStore.Size = new System.Drawing.Size(887, 508);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvInStore_DataBindingComplete);
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // MaterialType
            // 
            this.MaterialType.DataPropertyName = "MaterialType";
            this.MaterialType.HeaderText = "入库的材料类型";
            this.MaterialType.Name = "MaterialType";
            this.MaterialType.Visible = false;
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "入库的材料编码";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Alloy_Code
            // 
            this.Alloy_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Alloy_Code.DataPropertyName = "Alloy_Code";
            this.Alloy_Code.DataSource = this.dsAlloyCode;
            this.Alloy_Code.DisplayMember = "L3DataTable.Code_Des";
            this.Alloy_Code.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Alloy_Code.HeaderText = "合金编码";
            this.Alloy_Code.Name = "Alloy_Code";
            this.Alloy_Code.ReadOnly = true;
            this.Alloy_Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Alloy_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Alloy_Code.ValueMember = "L3DataTable.Code";
            this.Alloy_Code.Width = 78;
            // 
            // dsAlloyCode
            // 
            this.dsAlloyCode.AutoLoad = true;
            this.dsAlloyCode.AutoSubscribe = false;
            this.dsAlloyCode.DataSetName = "L3DataSet";
            this.dsAlloyCode.DeleteMethod = null;
            this.dsAlloyCode.InsertMethod = null;
            this.dsAlloyCode.L3DataAdapter = this.Adapter;
            this.dsAlloyCode.LoadEvent = "Click";
            this.dsAlloyCode.LoadTrigger = null;
            this.dsAlloyCode.RefreshValve = 1000;
            this.dsAlloyCode.SourceCommand = null;
            this.dsAlloyCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\' order by code_des";
            this.dsAlloyCode.SourceMethod = "";
            this.dsAlloyCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyCode.SubscribeTarget = null;
            this.dsAlloyCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyCode});
            this.dsAlloyCode.UpdateEvent = "Click";
            this.dsAlloyCode.UpdateMethod = null;
            this.dsAlloyCode.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "BOFbtnConfirm");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(73, 22);
            this.btnConfirm.Text = "实绩确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // schemadsAlloyCode
            // 
            this.schemadsAlloyCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyCodeL3DataTableCode,
            this.coldsAlloyCodeL3DataTableCode_Des});
            this.schemadsAlloyCode.TableName = "L3DataTable";
            // 
            // coldsAlloyCodeL3DataTableCode
            // 
            this.coldsAlloyCodeL3DataTableCode.Caption = "Code";
            this.coldsAlloyCodeL3DataTableCode.ColumnName = "Code";
            this.coldsAlloyCodeL3DataTableCode.Namespace = "";
            // 
            // coldsAlloyCodeL3DataTableCode_Des
            // 
            this.coldsAlloyCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.Namespace = "";
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "Batch_ID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LogDate
            // 
            this.LogDate.DataPropertyName = "LogDate";
            this.LogDate.HeaderText = "入库日期";
            this.LogDate.Name = "LogDate";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "入库量";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "入库类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // storeAreaIDDataGridViewTextBoxColumn
            // 
            this.storeAreaIDDataGridViewTextBoxColumn.DataPropertyName = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.DataSource = this.dsStoreArea;
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.storeAreaIDDataGridViewTextBoxColumn.HeaderText = "库位";
            this.storeAreaIDDataGridViewTextBoxColumn.Name = "storeAreaIDDataGridViewTextBoxColumn";
            this.storeAreaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeAreaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeAreaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.storeAreaIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsStoreArea
            // 
            this.dsStoreArea.AutoLoad = true;
            this.dsStoreArea.AutoSubscribe = false;
            this.dsStoreArea.DataSetName = "L3DataSet";
            this.dsStoreArea.DeleteMethod = null;
            this.dsStoreArea.InsertMethod = null;
            this.dsStoreArea.L3DataAdapter = this.Adapter;
            this.dsStoreArea.LoadEvent = "Click";
            this.dsStoreArea.LoadTrigger = null;
            this.dsStoreArea.RefreshValve = 1000;
            this.dsStoreArea.SourceCommand = null;
            this.dsStoreArea.SourceCondition = "CODE_GROUP = \'AlloyArea\'  or Code_Group = \'AlloyGround\' or code_group = \'AlloyWir" +
                "e\'";
            this.dsStoreArea.SourceMethod = "";
            this.dsStoreArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreArea.SubscribeTarget = null;
            this.dsStoreArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreArea});
            this.dsStoreArea.UpdateEvent = "Click";
            this.dsStoreArea.UpdateMethod = null;
            this.dsStoreArea.UpdateTrigger = null;
            // 
            // schemadsStoreArea
            // 
            this.schemadsStoreArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreAreaL3DataTableCode,
            this.coldsStoreAreaL3DataTableCode_Des});
            this.schemadsStoreArea.TableName = "L3DataTable";
            // 
            // coldsStoreAreaL3DataTableCode
            // 
            this.coldsStoreAreaL3DataTableCode.Caption = "Code";
            this.coldsStoreAreaL3DataTableCode.ColumnName = "Code";
            this.coldsStoreAreaL3DataTableCode.Namespace = "";
            // 
            // coldsStoreAreaL3DataTableCode_Des
            // 
            this.coldsStoreAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreAreaL3DataTableCode_Des.Namespace = "";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "入库原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "材料的来源";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceDataGridViewTextBoxColumn.Visible = false;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作人员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // alloyConfirmManDataGridViewTextBoxColumn
            // 
            this.alloyConfirmManDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Confirm_Man";
            this.alloyConfirmManDataGridViewTextBoxColumn.HeaderText = "炉前确认";
            this.alloyConfirmManDataGridViewTextBoxColumn.Name = "alloyConfirmManDataGridViewTextBoxColumn";
            this.alloyConfirmManDataGridViewTextBoxColumn.Visible = false;
            // 
            // shopConfirmManDataGridViewTextBoxColumn
            // 
            this.shopConfirmManDataGridViewTextBoxColumn.DataPropertyName = "Shop_Confirm_Man";
            this.shopConfirmManDataGridViewTextBoxColumn.HeaderText = "车间确认";
            this.shopConfirmManDataGridViewTextBoxColumn.Name = "shopConfirmManDataGridViewTextBoxColumn";
            this.shopConfirmManDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name";
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.Visible = false;
            this.Name1.Width = 54;
            // 
            // bsInStore
            // 
            this.bsInStore.DataMember = "L3DataTable";
            this.bsInStore.DataSource = this.dsInStore;
            // 
            // dsInStore
            // 
            this.dsInStore.AutoLoad = true;
            this.dsInStore.AutoSubscribe = false;
            this.dsInStore.DataSetName = "L3DataSet";
            this.dsInStore.DeleteMethod = null;
            this.dsInStore.InsertMethod = null;
            this.dsInStore.L3DataAdapter = this.Adapter;
            this.dsInStore.LoadEvent = "Click";
            this.dsInStore.LoadTrigger = null;
            this.dsInStore.RefreshValve = 1000;
            this.dsInStore.SourceCommand = null;
            this.dsInStore.SourceCondition = "1=2";
            this.dsInStore.SourceMethod = "";
            this.dsInStore.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInStore.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Input_Log";
            this.dsInStore.SubscribeTarget = null;
            this.dsInStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet9});
            this.dsInStore.UpdateEvent = "Click";
            this.dsInStore.UpdateMethod = null;
            this.dsInStore.UpdateTrigger = null;
            // 
            // schemal3DataSet9
            // 
            this.schemal3DataSet9.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet9L3DataTableGUID,
            this.coll3DataSet9L3DataTableName,
            this.coll3DataSet9L3DataTableMaterialType,
            this.coll3DataSet9L3DataTableMaterialID,
            this.coll3DataSet9L3DataTableLogDate,
            this.coll3DataSet9L3DataTableAmount,
            this.coll3DataSet9L3DataTableType,
            this.coll3DataSet9L3DataTableStoreAreaID,
            this.coll3DataSet9L3DataTableReason,
            this.coll3DataSet9L3DataTableSource,
            this.coll3DataSet9L3DataTableOperator,
            this.coll3DataSet9L3DataTableShift,
            this.coll3DataSet9L3DataTableTeam,
            this.coll3DataSet9L3DataTableBatch_ID,
            this.coll3DataSet9L3DataTableAlloy_Code,
            this.coll3DataSet9L3DataTableAlloy_Confirm_Man,
            this.coll3DataSet9L3DataTableShop_Confirm_Man});
            this.schemal3DataSet9.TableName = "L3DataTable";
            // 
            // coll3DataSet9L3DataTableGUID
            // 
            this.coll3DataSet9L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet9L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet9L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet9L3DataTableName
            // 
            this.coll3DataSet9L3DataTableName.Caption = "Name";
            this.coll3DataSet9L3DataTableName.ColumnName = "Name";
            this.coll3DataSet9L3DataTableName.Namespace = "";
            // 
            // coll3DataSet9L3DataTableMaterialType
            // 
            this.coll3DataSet9L3DataTableMaterialType.Caption = "MaterialType";
            this.coll3DataSet9L3DataTableMaterialType.ColumnName = "MaterialType";
            this.coll3DataSet9L3DataTableMaterialType.Namespace = "";
            // 
            // coll3DataSet9L3DataTableMaterialID
            // 
            this.coll3DataSet9L3DataTableMaterialID.Caption = "MaterialID";
            this.coll3DataSet9L3DataTableMaterialID.ColumnName = "MaterialID";
            this.coll3DataSet9L3DataTableMaterialID.Namespace = "";
            // 
            // coll3DataSet9L3DataTableLogDate
            // 
            this.coll3DataSet9L3DataTableLogDate.Caption = "LogDate";
            this.coll3DataSet9L3DataTableLogDate.ColumnName = "LogDate";
            this.coll3DataSet9L3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coll3DataSet9L3DataTableLogDate.Namespace = "";
            // 
            // coll3DataSet9L3DataTableAmount
            // 
            this.coll3DataSet9L3DataTableAmount.Caption = "Amount";
            this.coll3DataSet9L3DataTableAmount.ColumnName = "Amount";
            this.coll3DataSet9L3DataTableAmount.DataType = typeof(double);
            this.coll3DataSet9L3DataTableAmount.Namespace = "";
            // 
            // coll3DataSet9L3DataTableType
            // 
            this.coll3DataSet9L3DataTableType.Caption = "Type";
            this.coll3DataSet9L3DataTableType.ColumnName = "Type";
            this.coll3DataSet9L3DataTableType.DataType = typeof(int);
            this.coll3DataSet9L3DataTableType.Namespace = "";
            // 
            // coll3DataSet9L3DataTableStoreAreaID
            // 
            this.coll3DataSet9L3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coll3DataSet9L3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coll3DataSet9L3DataTableStoreAreaID.Namespace = "";
            // 
            // coll3DataSet9L3DataTableReason
            // 
            this.coll3DataSet9L3DataTableReason.Caption = "Reason";
            this.coll3DataSet9L3DataTableReason.ColumnName = "Reason";
            this.coll3DataSet9L3DataTableReason.Namespace = "";
            // 
            // coll3DataSet9L3DataTableSource
            // 
            this.coll3DataSet9L3DataTableSource.Caption = "Source";
            this.coll3DataSet9L3DataTableSource.ColumnName = "Source";
            this.coll3DataSet9L3DataTableSource.Namespace = "";
            // 
            // coll3DataSet9L3DataTableOperator
            // 
            this.coll3DataSet9L3DataTableOperator.Caption = "Operator";
            this.coll3DataSet9L3DataTableOperator.ColumnName = "Operator";
            this.coll3DataSet9L3DataTableOperator.Namespace = "";
            // 
            // coll3DataSet9L3DataTableShift
            // 
            this.coll3DataSet9L3DataTableShift.Caption = "Shift";
            this.coll3DataSet9L3DataTableShift.ColumnName = "Shift";
            this.coll3DataSet9L3DataTableShift.Namespace = "";
            // 
            // coll3DataSet9L3DataTableTeam
            // 
            this.coll3DataSet9L3DataTableTeam.Caption = "Team";
            this.coll3DataSet9L3DataTableTeam.ColumnName = "Team";
            this.coll3DataSet9L3DataTableTeam.Namespace = "";
            // 
            // coll3DataSet9L3DataTableBatch_ID
            // 
            this.coll3DataSet9L3DataTableBatch_ID.Caption = "Batch_ID";
            this.coll3DataSet9L3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coll3DataSet9L3DataTableBatch_ID.Namespace = "";
            // 
            // coll3DataSet9L3DataTableAlloy_Code
            // 
            this.coll3DataSet9L3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coll3DataSet9L3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coll3DataSet9L3DataTableAlloy_Code.Namespace = "";
            // 
            // coll3DataSet9L3DataTableAlloy_Confirm_Man
            // 
            this.coll3DataSet9L3DataTableAlloy_Confirm_Man.Caption = "Alloy_Confirm_Man";
            this.coll3DataSet9L3DataTableAlloy_Confirm_Man.ColumnName = "Alloy_Confirm_Man";
            this.coll3DataSet9L3DataTableAlloy_Confirm_Man.Namespace = "";
            // 
            // coll3DataSet9L3DataTableShop_Confirm_Man
            // 
            this.coll3DataSet9L3DataTableShop_Confirm_Man.Caption = "Shop_Confirm_Man";
            this.coll3DataSet9L3DataTableShop_Confirm_Man.ColumnName = "Shop_Confirm_Man";
            this.coll3DataSet9L3DataTableShop_Confirm_Man.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsInStore;
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
            this.btnQuery,
            this.dtInStoreEndData,
            this.toolStripLabel2,
            this.dtInStoreData,
            this.toolStripLabel6,
            this.btnOutput,
            this.btnConfirm,
            this.cmbAlloyCode,
            this.toolStripLabel3});
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
            // dtInStoreEndData
            // 
            this.dtInStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.Name = "dtInStoreEndData";
            this.dtInStoreEndData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreEndData.Text = "2009-01-04";
            this.dtInStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtInStoreData
            // 
            this.dtInStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.Name = "dtInStoreData";
            this.dtInStoreData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreData.Text = "2008-11-16";
            this.dtInStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "入库日期:";
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
            // cmbAlloyCode
            // 
            this.cmbAlloyCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbAlloyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlloyCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAlloyCode.Name = "cmbAlloyCode";
            this.cmbAlloyCode.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "合金名称:";
            // 
            // InStoreQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "InStoreQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "合金入库查询";
            this.Text = "入库查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InStoreQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.InStoreQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtInStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsInStore;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsStoreArea;
        private System.Data.DataTable schemadsStoreArea;
        private System.Data.DataColumn coldsStoreAreaL3DataTableCode;
        private System.Data.DataColumn coldsStoreAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private AppSvrHMI.L3DataSet dsInStore;
        private System.Data.DataTable schemal3DataSet9;
        private System.Data.DataColumn coll3DataSet9L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet9L3DataTableName;
        private System.Data.DataColumn coll3DataSet9L3DataTableMaterialType;
        private System.Data.DataColumn coll3DataSet9L3DataTableMaterialID;
        private System.Data.DataColumn coll3DataSet9L3DataTableLogDate;
        private System.Data.DataColumn coll3DataSet9L3DataTableAmount;
        private System.Data.DataColumn coll3DataSet9L3DataTableType;
        private System.Data.DataColumn coll3DataSet9L3DataTableStoreAreaID;
        private System.Data.DataColumn coll3DataSet9L3DataTableReason;
        private System.Data.DataColumn coll3DataSet9L3DataTableSource;
        private System.Data.DataColumn coll3DataSet9L3DataTableOperator;
        private System.Data.DataColumn coll3DataSet9L3DataTableShift;
        private System.Data.DataColumn coll3DataSet9L3DataTableTeam;
        private System.Data.DataColumn coll3DataSet9L3DataTableBatch_ID;
        private System.Data.DataColumn coll3DataSet9L3DataTableAlloy_Code;
        private System.Data.DataColumn coll3DataSet9L3DataTableAlloy_Confirm_Man;
        private System.Data.DataColumn coll3DataSet9L3DataTableShop_Confirm_Man;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtInStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Alloy_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeAreaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyConfirmManDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopConfirmManDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbAlloyCode;
    }
}