namespace StoreMag.AlloyStore
{
    partial class OutStoreQueryFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutStoreQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.alloyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.storeAreaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStoreArea = new AppSvrHMI.L3DataSet();
            this.schemadsStoreArea = new System.Data.DataTable();
            this.coldsStoreAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OutType = new AppSvrHMI.L3DataSet();
            this.schemaOutType = new System.Data.DataTable();
            this.colOutTypeL3DataTableCode = new System.Data.DataColumn();
            this.colOutTypeL3DataTablecode_val_long = new System.Data.DataColumn();
            this.colOutTypeL3DataTablecode_des = new System.Data.DataColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsOutStore = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableName = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAmount = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableType = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableReason = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableShift = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableTeam = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableNo = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableTarget = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableUnitID = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtOutStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtOutStore = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.cmbUnitID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtUnitID = new System.Windows.Forms.ToolStripTextBox();
            this.cmbType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.cmbAlloyCode = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaOutType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
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
            this.hmiRootPanel1.Size = new System.Drawing.Size(1028, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alloyCodeDataGridViewTextBoxColumn,
            this.storeAreaIDDataGridViewTextBoxColumn,
            this.batchIDDataGridViewTextBoxColumn,
            this.UnitID,
            this.Target,
            this.LogDate,
            this.amountDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.Name1});
            this.dvInStore.DataSource = this.bsOutStore;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.MultiSelect = false;
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInStore.Size = new System.Drawing.Size(1028, 508);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            this.dvInStore.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvInStore_DataBindingComplete);
            // 
            // alloyCodeDataGridViewTextBoxColumn
            // 
            this.alloyCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alloyCodeDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Code";
            this.alloyCodeDataGridViewTextBoxColumn.DataSource = this.dsAlloyCode;
            this.alloyCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.alloyCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.alloyCodeDataGridViewTextBoxColumn.HeaderText = "出库合金";
            this.alloyCodeDataGridViewTextBoxColumn.Name = "alloyCodeDataGridViewTextBoxColumn";
            this.alloyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.alloyCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alloyCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alloyCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.alloyCodeDataGridViewTextBoxColumn.Width = 78;
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
            this.btnConfirm.Size = new System.Drawing.Size(23, 22);
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
            // storeAreaIDDataGridViewTextBoxColumn
            // 
            this.storeAreaIDDataGridViewTextBoxColumn.DataPropertyName = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.DataSource = this.dsStoreArea;
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.storeAreaIDDataGridViewTextBoxColumn.HeaderText = "出库地";
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
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "Batch_ID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            this.batchIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.DataSource = this.dsUnitID;
            this.UnitID.DisplayMember = "L3DataTable.Code_Des";
            this.UnitID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UnitID.HeaderText = "机组";
            this.UnitID.Name = "UnitID";
            this.UnitID.ReadOnly = true;
            this.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitID.ValueMember = "L3DataTable.Code";
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoLoad = true;
            this.dsUnitID.AutoSubscribe = true;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "CODE_GROUP IN (\'BOF\',\'LF\',\'RH\')  and code is not null order by code";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
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
            this.coldsUnitIDL3DataTableCode,
            this.coldsUnitIDL3DataTableCode_Des});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTableCode
            // 
            this.coldsUnitIDL3DataTableCode.Caption = "Code";
            this.coldsUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Des
            // 
            this.coldsUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // Target
            // 
            this.Target.DataPropertyName = "Target";
            this.Target.HeaderText = "炉号";
            this.Target.Name = "Target";
            this.Target.ReadOnly = true;
            // 
            // LogDate
            // 
            this.LogDate.DataPropertyName = "LogDate";
            this.LogDate.HeaderText = "出库日期";
            this.LogDate.Name = "LogDate";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.amountDataGridViewTextBoxColumn.HeaderText = "出库量[Kg]";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.OutType;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.typeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewTextBoxColumn.HeaderText = "出库类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code_val_long";
            // 
            // OutType
            // 
            this.OutType.AutoLoad = true;
            this.OutType.AutoSubscribe = false;
            this.OutType.DataSetName = "L3DataSet";
            this.OutType.DeleteMethod = "";
            this.OutType.InsertMethod = "";
            this.OutType.L3DataAdapter = this.Adapter;
            this.OutType.LoadEvent = "";
            this.OutType.LoadTrigger = null;
            this.OutType.RefreshValve = 1000;
            this.OutType.SourceCommand = null;
            this.OutType.SourceCondition = "code_group = \'OutStoreType\'";
            this.OutType.SourceMethod = "";
            this.OutType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.OutType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.OutType.SubscribeTarget = null;
            this.OutType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemaOutType});
            this.OutType.UpdateEvent = "";
            this.OutType.UpdateMethod = "";
            this.OutType.UpdateTrigger = null;
            // 
            // schemaOutType
            // 
            this.schemaOutType.Columns.AddRange(new System.Data.DataColumn[] {
            this.colOutTypeL3DataTableCode,
            this.colOutTypeL3DataTablecode_val_long,
            this.colOutTypeL3DataTablecode_des});
            this.schemaOutType.TableName = "L3DataTable";
            // 
            // colOutTypeL3DataTableCode
            // 
            this.colOutTypeL3DataTableCode.Caption = "Code";
            this.colOutTypeL3DataTableCode.ColumnName = "Code";
            this.colOutTypeL3DataTableCode.Namespace = "";
            // 
            // colOutTypeL3DataTablecode_val_long
            // 
            this.colOutTypeL3DataTablecode_val_long.Caption = "code_val_long";
            this.colOutTypeL3DataTablecode_val_long.ColumnName = "code_val_long";
            this.colOutTypeL3DataTablecode_val_long.DataType = typeof(int);
            this.colOutTypeL3DataTablecode_val_long.Namespace = "";
            // 
            // colOutTypeL3DataTablecode_des
            // 
            this.colOutTypeL3DataTablecode_des.Caption = "code_des";
            this.colOutTypeL3DataTablecode_des.ColumnName = "code_des";
            this.colOutTypeL3DataTablecode_des.Namespace = "";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "出库原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.Visible = false;
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
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "入库的材料编码";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "入库的材料类型";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.Visible = false;
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
            // bsOutStore
            // 
            this.bsOutStore.DataMember = "L3DataTable";
            this.bsOutStore.DataSource = this.dsOutStore;
            // 
            // dsOutStore
            // 
            this.dsOutStore.AutoLoad = true;
            this.dsOutStore.AutoSubscribe = false;
            this.dsOutStore.DataSetName = "L3DataSet";
            this.dsOutStore.DeleteMethod = null;
            this.dsOutStore.InsertMethod = null;
            this.dsOutStore.L3DataAdapter = this.Adapter;
            this.dsOutStore.LoadEvent = "Click";
            this.dsOutStore.LoadTrigger = null;
            this.dsOutStore.RefreshValve = 1000;
            this.dsOutStore.SourceCommand = null;
            this.dsOutStore.SourceCondition = "1=2";
            this.dsOutStore.SourceMethod = "";
            this.dsOutStore.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOutStore.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Output_Log";
            this.dsOutStore.SubscribeTarget = null;
            this.dsOutStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsOutStore.UpdateEvent = "Click";
            this.dsOutStore.UpdateMethod = null;
            this.dsOutStore.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableGUID,
            this.coldsInStoreL3DataTableName,
            this.coldsInStoreL3DataTableMaterialType,
            this.coldsInStoreL3DataTableMaterialID,
            this.coldsInStoreL3DataTableLogDate,
            this.coldsInStoreL3DataTableAmount,
            this.coldsInStoreL3DataTableType,
            this.coldsInStoreL3DataTableStoreAreaID,
            this.coldsInStoreL3DataTableReason,
            this.coldsInStoreL3DataTableOperator,
            this.coldsInStoreL3DataTableShift,
            this.coldsInStoreL3DataTableTeam,
            this.coldsInStoreL3DataTableBatch_ID,
            this.coldsInStoreL3DataTableAlloy_Code,
            this.coldsOutStoreL3DataTableNo,
            this.coldsOutStoreL3DataTableTarget,
            this.coldsOutStoreL3DataTableUnitID});
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
            // coldsInStoreL3DataTableMaterialType
            // 
            this.coldsInStoreL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsInStoreL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsInStoreL3DataTableMaterialType.Namespace = "";
            // 
            // coldsInStoreL3DataTableMaterialID
            // 
            this.coldsInStoreL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsInStoreL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsInStoreL3DataTableMaterialID.Namespace = "";
            // 
            // coldsInStoreL3DataTableLogDate
            // 
            this.coldsInStoreL3DataTableLogDate.Caption = "LogDate";
            this.coldsInStoreL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsInStoreL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableLogDate.Namespace = "";
            // 
            // coldsInStoreL3DataTableAmount
            // 
            this.coldsInStoreL3DataTableAmount.Caption = "Amount";
            this.coldsInStoreL3DataTableAmount.ColumnName = "Amount";
            this.coldsInStoreL3DataTableAmount.DataType = typeof(double);
            this.coldsInStoreL3DataTableAmount.Namespace = "";
            // 
            // coldsInStoreL3DataTableType
            // 
            this.coldsInStoreL3DataTableType.Caption = "Type";
            this.coldsInStoreL3DataTableType.ColumnName = "Type";
            this.coldsInStoreL3DataTableType.DataType = typeof(int);
            this.coldsInStoreL3DataTableType.Namespace = "";
            // 
            // coldsInStoreL3DataTableStoreAreaID
            // 
            this.coldsInStoreL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsInStoreL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsInStoreL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsInStoreL3DataTableReason
            // 
            this.coldsInStoreL3DataTableReason.Caption = "Reason";
            this.coldsInStoreL3DataTableReason.ColumnName = "Reason";
            this.coldsInStoreL3DataTableReason.Namespace = "";
            // 
            // coldsInStoreL3DataTableOperator
            // 
            this.coldsInStoreL3DataTableOperator.Caption = "Operator";
            this.coldsInStoreL3DataTableOperator.ColumnName = "Operator";
            this.coldsInStoreL3DataTableOperator.Namespace = "";
            // 
            // coldsInStoreL3DataTableShift
            // 
            this.coldsInStoreL3DataTableShift.Caption = "Shift";
            this.coldsInStoreL3DataTableShift.ColumnName = "Shift";
            this.coldsInStoreL3DataTableShift.Namespace = "";
            // 
            // coldsInStoreL3DataTableTeam
            // 
            this.coldsInStoreL3DataTableTeam.Caption = "Team";
            this.coldsInStoreL3DataTableTeam.ColumnName = "Team";
            this.coldsInStoreL3DataTableTeam.Namespace = "";
            // 
            // coldsInStoreL3DataTableBatch_ID
            // 
            this.coldsInStoreL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsInStoreL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsInStoreL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsInStoreL3DataTableAlloy_Code
            // 
            this.coldsInStoreL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsInStoreL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsInStoreL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsOutStoreL3DataTableNo
            // 
            this.coldsOutStoreL3DataTableNo.Caption = "No";
            this.coldsOutStoreL3DataTableNo.ColumnName = "No";
            this.coldsOutStoreL3DataTableNo.Namespace = "";
            // 
            // coldsOutStoreL3DataTableTarget
            // 
            this.coldsOutStoreL3DataTableTarget.Caption = "Target";
            this.coldsOutStoreL3DataTableTarget.ColumnName = "Target";
            this.coldsOutStoreL3DataTableTarget.Namespace = "";
            // 
            // coldsOutStoreL3DataTableUnitID
            // 
            this.coldsOutStoreL3DataTableUnitID.Caption = "UnitID";
            this.coldsOutStoreL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsOutStoreL3DataTableUnitID.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsOutStore;
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
            this.dtOutStoreEndData,
            this.toolStripLabel2,
            this.dtOutStore,
            this.toolStripLabel6,
            this.btnOutput,
            this.btnConfirm,
            this.cmbUnitID,
            this.toolStripLabel3,
            this.txtUnitID,
            this.cmbType,
            this.toolStripLabel5,
            this.txtHeatID,
            this.toolStripLabel4,
            this.cmbAlloyCode,
            this.toolStripLabel1});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1028, 25);
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
            // dtOutStoreEndData
            // 
            this.dtOutStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStoreEndData.AutoSize = false;
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
            this.dtOutStoreEndData.Size = new System.Drawing.Size(85, 22);
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
            // dtOutStore
            // 
            this.dtOutStore.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtOutStore.AutoSize = false;
            this.dtOutStore.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtOutStore.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtOutStore.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtOutStore.CustomFormat = "yyyy-MM-dd";
            this.dtOutStore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOutStore.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtOutStore.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtOutStore.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtOutStore.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtOutStore.Name = "dtOutStore";
            this.dtOutStore.Size = new System.Drawing.Size(85, 22);
            this.dtOutStore.Text = "2008-11-16";
            this.dtOutStore.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "出库日期:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(23, 22);
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbUnitID.AutoSize = false;
            this.cmbUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(50, 20);
            this.cmbUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbUnitID_SelectedIndexChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "机组:";
            // 
            // txtUnitID
            // 
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(100, 25);
            this.txtUnitID.Visible = false;
            // 
            // cmbType
            // 
            this.cmbType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel5.Text = "出库类型:";
            // 
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(60, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "炉号:";
            // 
            // cmbAlloyCode
            // 
            this.cmbAlloyCode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbAlloyCode.AutoSize = false;
            this.cmbAlloyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlloyCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbAlloyCode.Name = "cmbAlloyCode";
            this.cmbAlloyCode.Size = new System.Drawing.Size(100, 20);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "合金名称:";
            // 
            // OutStoreQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "OutStoreQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "合金出库查询";
            this.Text = "出库查询";
            this.Load += new System.EventHandler(this.OutStoreQueryFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutStoreQueryFrm_FormClosing);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaOutType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
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
        private buttonHide.ToolStripToriDateTimePicker dtOutStore;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsOutStore;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableGUID;
        private System.Data.DataColumn coldsInStoreL3DataTableName;
        private System.Data.DataColumn coldsInStoreL3DataTableMaterialType;
        private System.Data.DataColumn coldsInStoreL3DataTableMaterialID;
        private System.Data.DataColumn coldsInStoreL3DataTableLogDate;
        private System.Data.DataColumn coldsInStoreL3DataTableAmount;
        private System.Data.DataColumn coldsInStoreL3DataTableType;
        private System.Data.DataColumn coldsInStoreL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsInStoreL3DataTableReason;
        private System.Data.DataColumn coldsInStoreL3DataTableOperator;
        private System.Data.DataColumn coldsInStoreL3DataTableShift;
        private System.Data.DataColumn coldsInStoreL3DataTableTeam;
        private System.Data.DataColumn coldsInStoreL3DataTableBatch_ID;
        private System.Data.DataColumn coldsInStoreL3DataTableAlloy_Code;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTableNo;
        private System.Data.DataColumn coldsOutStoreL3DataTableTarget;
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
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsOutStoreL3DataTableUnitID;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private AppSvrHMI.L3DataSet OutType;
        private System.Data.DataTable schemaOutType;
        private System.Data.DataColumn colOutTypeL3DataTableCode;
        private System.Data.DataColumn colOutTypeL3DataTablecode_val_long;
        private System.Data.DataColumn colOutTypeL3DataTablecode_des;
        private System.Windows.Forms.ToolStripComboBox cmbUnitID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtUnitID;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewComboBoxColumn alloyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeAreaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.ToolStripComboBox cmbType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbAlloyCode;
    }
}