namespace StoreMag.BloomStore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutStoreQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeAreaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBloomArea = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBloomArea = new System.Data.DataTable();
            this.coldsBloomAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBloomAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.targetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cal_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waster_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waster_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrong_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrong_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width_Bloom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsOffLineReason = new AppSvrHMI.L3DataSet();
            this.schemadsOffLineReason = new System.Data.DataTable();
            this.coldsOffLineReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsOffLineReasonL3DataTableCode_Des = new System.Data.DataColumn();
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
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD_HEATID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD_HEATID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADD_BLOOM_COUNT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_Div_HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Div_Bloom_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.coldsOutStoreL3DataTableNo = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableTarget = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableLength = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWidth = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableThickness = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCal_Weight = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableRight_Weight = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWrong_Weight = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableBloom_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableWrong_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableRight_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTabletotalweight = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableAdd_Bloom_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableDiv_Bloom_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTablePlan_Bloom_Count = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableAdd_Div_HeatID = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableADD_HEATID1 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableADD_HEATID2 = new System.Data.DataColumn();
            this.coldsOutStoreL3DataTableADD_BLOOM_COUNT2 = new System.Data.DataColumn();
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
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).BeginInit();
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
            this.materialIDDataGridViewTextBoxColumn,
            this.CasterID,
            this.logDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.storeAreaIDDataGridViewTextBoxColumn,
            this.targetDataGridViewTextBoxColumn,
            this.Length,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.Bloom_Count,
            this.totalweight,
            this.Cal_Weight,
            this.Right_Count,
            this.Right_Weight,
            this.Waster_Count,
            this.Waster_Weight,
            this.Wrong_Count,
            this.Wrong_Weight,
            this.Width_Bloom,
            this.Thickness,
            this.reasonDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn,
            this.Plan_Bloom_Count,
            this.ADD_HEATID1,
            this.Add_Bloom_Count,
            this.ADD_HEATID2,
            this.ADD_BLOOM_COUNT2,
            this.Add_Div_HeatID,
            this.Div_Bloom_Count});
            this.dvInStore.DataSource = this.bsOutStore;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(1028, 508);
            this.dvInStore.TabIndex = 29;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.Frozen = true;
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CasterID
            // 
            this.CasterID.DataPropertyName = "CasterID";
            this.CasterID.HeaderText = "铸机号";
            this.CasterID.Name = "CasterID";
            this.CasterID.ReadOnly = true;
            // 
            // logDateDataGridViewTextBoxColumn
            // 
            this.logDateDataGridViewTextBoxColumn.DataPropertyName = "LogDate";
            this.logDateDataGridViewTextBoxColumn.HeaderText = "出库日期";
            this.logDateDataGridViewTextBoxColumn.Name = "logDateDataGridViewTextBoxColumn";
            this.logDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "钢坯炉数";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "出库类型";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storeAreaIDDataGridViewTextBoxColumn
            // 
            this.storeAreaIDDataGridViewTextBoxColumn.DataPropertyName = "StoreAreaID";
            this.storeAreaIDDataGridViewTextBoxColumn.DataSource = this.dsBloomArea;
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.storeAreaIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.storeAreaIDDataGridViewTextBoxColumn.HeaderText = "出库地";
            this.storeAreaIDDataGridViewTextBoxColumn.Name = "storeAreaIDDataGridViewTextBoxColumn";
            this.storeAreaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeAreaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.storeAreaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.storeAreaIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsBloomArea
            // 
            this.dsBloomArea.AutoLoad = true;
            this.dsBloomArea.AutoSubscribe = false;
            this.dsBloomArea.DataSetName = "L3DataSet";
            this.dsBloomArea.DeleteMethod = null;
            this.dsBloomArea.InsertMethod = null;
            this.dsBloomArea.L3DataAdapter = this.Adapter;
            this.dsBloomArea.LoadEvent = "Click";
            this.dsBloomArea.LoadTrigger = null;
            this.dsBloomArea.RefreshValve = 1000;
            this.dsBloomArea.SourceCommand = null;
            this.dsBloomArea.SourceCondition = "CODE_GROUP = \'BloomArea\'";
            this.dsBloomArea.SourceMethod = "";
            this.dsBloomArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBloomArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBloomArea.SubscribeTarget = null;
            this.dsBloomArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBloomArea});
            this.dsBloomArea.UpdateEvent = "Click";
            this.dsBloomArea.UpdateMethod = null;
            this.dsBloomArea.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBloomArea
            // 
            this.schemadsBloomArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBloomAreaL3DataTableCode,
            this.coldsBloomAreaL3DataTableCode_Des});
            this.schemadsBloomArea.TableName = "L3DataTable";
            // 
            // coldsBloomAreaL3DataTableCode
            // 
            this.coldsBloomAreaL3DataTableCode.Caption = "Code";
            this.coldsBloomAreaL3DataTableCode.ColumnName = "Code";
            this.coldsBloomAreaL3DataTableCode.Namespace = "";
            // 
            // coldsBloomAreaL3DataTableCode_Des
            // 
            this.coldsBloomAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBloomAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBloomAreaL3DataTableCode_Des.Namespace = "";
            // 
            // targetDataGridViewTextBoxColumn
            // 
            this.targetDataGridViewTextBoxColumn.DataPropertyName = "Target";
            this.targetDataGridViewTextBoxColumn.HeaderText = "目的地";
            this.targetDataGridViewTextBoxColumn.Name = "targetDataGridViewTextBoxColumn";
            this.targetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.DataPropertyName = "Length";
            dataGridViewCellStyle1.NullValue = null;
            this.Length.DefaultCellStyle = dataGridViewCellStyle1;
            this.Length.HeaderText = "定尺";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Bloom_Count
            // 
            this.Bloom_Count.DataPropertyName = "Bloom_Count";
            this.Bloom_Count.HeaderText = "钢坯枝数";
            this.Bloom_Count.Name = "Bloom_Count";
            this.Bloom_Count.ReadOnly = true;
            // 
            // totalweight
            // 
            this.totalweight.DataPropertyName = "totalweight";
            this.totalweight.HeaderText = "出坯总重量[t]";
            this.totalweight.Name = "totalweight";
            this.totalweight.ReadOnly = true;
            // 
            // Cal_Weight
            // 
            this.Cal_Weight.DataPropertyName = "Cal_Weight";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.Cal_Weight.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cal_Weight.HeaderText = "理论重量[t]";
            this.Cal_Weight.Name = "Cal_Weight";
            this.Cal_Weight.ReadOnly = true;
            // 
            // Right_Count
            // 
            this.Right_Count.DataPropertyName = "Right_Count";
            this.Right_Count.HeaderText = "合格钢坯枝数";
            this.Right_Count.Name = "Right_Count";
            this.Right_Count.ReadOnly = true;
            // 
            // Right_Weight
            // 
            this.Right_Weight.DataPropertyName = "Right_Weight";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.Right_Weight.DefaultCellStyle = dataGridViewCellStyle3;
            this.Right_Weight.HeaderText = "合格重量[t]";
            this.Right_Weight.Name = "Right_Weight";
            this.Right_Weight.ReadOnly = true;
            // 
            // Waster_Count
            // 
            this.Waster_Count.DataPropertyName = "Waster_Count";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.Waster_Count.DefaultCellStyle = dataGridViewCellStyle4;
            this.Waster_Count.HeaderText = "甩废钢坯长度";
            this.Waster_Count.Name = "Waster_Count";
            this.Waster_Count.ReadOnly = true;
            // 
            // Waster_Weight
            // 
            this.Waster_Weight.DataPropertyName = "Waster_Weight";
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.Waster_Weight.DefaultCellStyle = dataGridViewCellStyle5;
            this.Waster_Weight.HeaderText = "甩废总重量[t]";
            this.Waster_Weight.Name = "Waster_Weight";
            this.Waster_Weight.ReadOnly = true;
            // 
            // Wrong_Count
            // 
            this.Wrong_Count.DataPropertyName = "Wrong_Count";
            this.Wrong_Count.HeaderText = "不合格钢坯枝数";
            this.Wrong_Count.Name = "Wrong_Count";
            this.Wrong_Count.ReadOnly = true;
            this.Wrong_Count.Width = 110;
            // 
            // Wrong_Weight
            // 
            this.Wrong_Weight.DataPropertyName = "Wrong_Weight";
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = null;
            this.Wrong_Weight.DefaultCellStyle = dataGridViewCellStyle6;
            this.Wrong_Weight.HeaderText = "不合格总重量[t]";
            this.Wrong_Weight.Name = "Wrong_Weight";
            this.Wrong_Weight.ReadOnly = true;
            this.Wrong_Weight.Width = 110;
            // 
            // Width_Bloom
            // 
            this.Width_Bloom.DataPropertyName = "Width";
            this.Width_Bloom.HeaderText = "宽度";
            this.Width_Bloom.Name = "Width_Bloom";
            this.Width_Bloom.ReadOnly = true;
            // 
            // Thickness
            // 
            this.Thickness.DataPropertyName = "Thickness";
            this.Thickness.HeaderText = "厚度";
            this.Thickness.Name = "Thickness";
            this.Thickness.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.DataSource = this.dsOffLineReason;
            this.reasonDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.reasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.reasonDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reasonDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.reasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsOffLineReason
            // 
            this.dsOffLineReason.AutoLoad = true;
            this.dsOffLineReason.AutoSubscribe = false;
            this.dsOffLineReason.DataSetName = "L3DataSet";
            this.dsOffLineReason.DeleteMethod = null;
            this.dsOffLineReason.InsertMethod = null;
            this.dsOffLineReason.L3DataAdapter = this.Adapter;
            this.dsOffLineReason.LoadEvent = "Click";
            this.dsOffLineReason.LoadTrigger = null;
            this.dsOffLineReason.RefreshValve = 1000;
            this.dsOffLineReason.SourceCommand = null;
            this.dsOffLineReason.SourceCondition = "CODE_GROUP = \'OFFLINE_REASON_CODE\'";
            this.dsOffLineReason.SourceMethod = "";
            this.dsOffLineReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOffLineReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsOffLineReason.SubscribeTarget = null;
            this.dsOffLineReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOffLineReason});
            this.dsOffLineReason.UpdateEvent = "Click";
            this.dsOffLineReason.UpdateMethod = null;
            this.dsOffLineReason.UpdateTrigger = null;
            // 
            // schemadsOffLineReason
            // 
            this.schemadsOffLineReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOffLineReasonL3DataTableCode,
            this.coldsOffLineReasonL3DataTableCode_Des});
            this.schemadsOffLineReason.TableName = "L3DataTable";
            // 
            // coldsOffLineReasonL3DataTableCode
            // 
            this.coldsOffLineReasonL3DataTableCode.Caption = "Code";
            this.coldsOffLineReasonL3DataTableCode.ColumnName = "Code";
            this.coldsOffLineReasonL3DataTableCode.Namespace = "";
            // 
            // coldsOffLineReasonL3DataTableCode_Des
            // 
            this.coldsOffLineReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.Namespace = "";
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
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "材料类型";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Plan_Bloom_Count
            // 
            this.Plan_Bloom_Count.DataPropertyName = "Plan_Bloom_Count";
            this.Plan_Bloom_Count.HeaderText = "计划钢坯支数";
            this.Plan_Bloom_Count.Name = "Plan_Bloom_Count";
            this.Plan_Bloom_Count.ReadOnly = true;
            // 
            // ADD_HEATID1
            // 
            this.ADD_HEATID1.DataPropertyName = "ADD_HEATID1";
            this.ADD_HEATID1.HeaderText = "拨入炉号1";
            this.ADD_HEATID1.Name = "ADD_HEATID1";
            this.ADD_HEATID1.ReadOnly = true;
            // 
            // Add_Bloom_Count
            // 
            this.Add_Bloom_Count.DataPropertyName = "Add_Bloom_Count";
            this.Add_Bloom_Count.HeaderText = "拨入钢坯支数1";
            this.Add_Bloom_Count.Name = "Add_Bloom_Count";
            this.Add_Bloom_Count.ReadOnly = true;
            // 
            // ADD_HEATID2
            // 
            this.ADD_HEATID2.DataPropertyName = "ADD_HEATID2";
            this.ADD_HEATID2.HeaderText = "拨入炉号2";
            this.ADD_HEATID2.Name = "ADD_HEATID2";
            this.ADD_HEATID2.ReadOnly = true;
            // 
            // ADD_BLOOM_COUNT2
            // 
            this.ADD_BLOOM_COUNT2.DataPropertyName = "ADD_BLOOM_COUNT2";
            this.ADD_BLOOM_COUNT2.HeaderText = "拨入钢坯支数2";
            this.ADD_BLOOM_COUNT2.Name = "ADD_BLOOM_COUNT2";
            this.ADD_BLOOM_COUNT2.ReadOnly = true;
            // 
            // Add_Div_HeatID
            // 
            this.Add_Div_HeatID.DataPropertyName = "Add_Div_HeatID";
            this.Add_Div_HeatID.HeaderText = "拨出炉号";
            this.Add_Div_HeatID.Name = "Add_Div_HeatID";
            this.Add_Div_HeatID.ReadOnly = true;
            // 
            // Div_Bloom_Count
            // 
            this.Div_Bloom_Count.DataPropertyName = "Div_Bloom_Count";
            this.Div_Bloom_Count.HeaderText = "拨出钢坯支数";
            this.Div_Bloom_Count.Name = "Div_Bloom_Count";
            this.Div_Bloom_Count.ReadOnly = true;
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
            this.dsOutStore.SourceCondition = "";
            this.dsOutStore.SourceMethod = "";
            this.dsOutStore.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsOutStore.SourceURI = "";
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
            this.coldsOutStoreL3DataTableNo,
            this.coldsOutStoreL3DataTableTarget,
            this.coldsOutStoreL3DataTableSteelGradeIndex,
            this.coldsOutStoreL3DataTableLength,
            this.coldsOutStoreL3DataTableWidth,
            this.coldsOutStoreL3DataTableThickness,
            this.coldsOutStoreL3DataTableCal_Weight,
            this.coldsOutStoreL3DataTableRight_Weight,
            this.coldsOutStoreL3DataTableWaster_Weight,
            this.coldsOutStoreL3DataTableWrong_Weight,
            this.coldsOutStoreL3DataTableBloom_Count,
            this.coldsOutStoreL3DataTableWaster_Count,
            this.coldsOutStoreL3DataTableWrong_Count,
            this.coldsOutStoreL3DataTableRight_Count,
            this.coldsOutStoreL3DataTabletotalweight,
            this.coldsOutStoreL3DataTableCasterID,
            this.coldsOutStoreL3DataTableAdd_Bloom_Count,
            this.coldsOutStoreL3DataTableDiv_Bloom_Count,
            this.coldsOutStoreL3DataTablePlan_Bloom_Count,
            this.coldsOutStoreL3DataTableAdd_Div_HeatID,
            this.coldsOutStoreL3DataTableADD_HEATID1,
            this.coldsOutStoreL3DataTableADD_HEATID2,
            this.coldsOutStoreL3DataTableADD_BLOOM_COUNT2});
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
            // coldsOutStoreL3DataTableSteelGradeIndex
            // 
            this.coldsOutStoreL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsOutStoreL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsOutStoreL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsOutStoreL3DataTableLength
            // 
            this.coldsOutStoreL3DataTableLength.Caption = "Length";
            this.coldsOutStoreL3DataTableLength.ColumnName = "Length";
            this.coldsOutStoreL3DataTableLength.DataType = typeof(int);
            this.coldsOutStoreL3DataTableLength.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWidth
            // 
            this.coldsOutStoreL3DataTableWidth.Caption = "Width";
            this.coldsOutStoreL3DataTableWidth.ColumnName = "Width";
            this.coldsOutStoreL3DataTableWidth.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWidth.Namespace = "";
            // 
            // coldsOutStoreL3DataTableThickness
            // 
            this.coldsOutStoreL3DataTableThickness.Caption = "Thickness";
            this.coldsOutStoreL3DataTableThickness.ColumnName = "Thickness";
            this.coldsOutStoreL3DataTableThickness.DataType = typeof(int);
            this.coldsOutStoreL3DataTableThickness.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCal_Weight
            // 
            this.coldsOutStoreL3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coldsOutStoreL3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coldsOutStoreL3DataTableCal_Weight.DataType = typeof(double);
            this.coldsOutStoreL3DataTableCal_Weight.Namespace = "";
            // 
            // coldsOutStoreL3DataTableRight_Weight
            // 
            this.coldsOutStoreL3DataTableRight_Weight.Caption = "Right_Weight";
            this.coldsOutStoreL3DataTableRight_Weight.ColumnName = "Right_Weight";
            this.coldsOutStoreL3DataTableRight_Weight.DataType = typeof(double);
            this.coldsOutStoreL3DataTableRight_Weight.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWaster_Weight
            // 
            this.coldsOutStoreL3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coldsOutStoreL3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coldsOutStoreL3DataTableWaster_Weight.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWaster_Weight.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWrong_Weight
            // 
            this.coldsOutStoreL3DataTableWrong_Weight.Caption = "Wrong_Weight";
            this.coldsOutStoreL3DataTableWrong_Weight.ColumnName = "Wrong_Weight";
            this.coldsOutStoreL3DataTableWrong_Weight.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWrong_Weight.Namespace = "";
            // 
            // coldsOutStoreL3DataTableBloom_Count
            // 
            this.coldsOutStoreL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsOutStoreL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsOutStoreL3DataTableBloom_Count.DataType = typeof(int);
            this.coldsOutStoreL3DataTableBloom_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWaster_Count
            // 
            this.coldsOutStoreL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsOutStoreL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsOutStoreL3DataTableWaster_Count.DataType = typeof(double);
            this.coldsOutStoreL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTableWrong_Count
            // 
            this.coldsOutStoreL3DataTableWrong_Count.Caption = "Wrong_Count";
            this.coldsOutStoreL3DataTableWrong_Count.ColumnName = "Wrong_Count";
            this.coldsOutStoreL3DataTableWrong_Count.DataType = typeof(int);
            this.coldsOutStoreL3DataTableWrong_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTableRight_Count
            // 
            this.coldsOutStoreL3DataTableRight_Count.Caption = "Right_Count";
            this.coldsOutStoreL3DataTableRight_Count.ColumnName = "Right_Count";
            this.coldsOutStoreL3DataTableRight_Count.DataType = typeof(int);
            this.coldsOutStoreL3DataTableRight_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTabletotalweight
            // 
            this.coldsOutStoreL3DataTabletotalweight.Caption = "totalweight";
            this.coldsOutStoreL3DataTabletotalweight.ColumnName = "totalweight";
            this.coldsOutStoreL3DataTabletotalweight.DataType = typeof(double);
            this.coldsOutStoreL3DataTabletotalweight.Namespace = "";
            // 
            // coldsOutStoreL3DataTableCasterID
            // 
            this.coldsOutStoreL3DataTableCasterID.Caption = "CasterID";
            this.coldsOutStoreL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsOutStoreL3DataTableCasterID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableAdd_Bloom_Count
            // 
            this.coldsOutStoreL3DataTableAdd_Bloom_Count.Caption = "Add_Bloom_Count";
            this.coldsOutStoreL3DataTableAdd_Bloom_Count.ColumnName = "Add_Bloom_Count";
            this.coldsOutStoreL3DataTableAdd_Bloom_Count.DataType = typeof(int);
            this.coldsOutStoreL3DataTableAdd_Bloom_Count.DefaultValue = 0;
            this.coldsOutStoreL3DataTableAdd_Bloom_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTableDiv_Bloom_Count
            // 
            this.coldsOutStoreL3DataTableDiv_Bloom_Count.Caption = "Div_Bloom_Count";
            this.coldsOutStoreL3DataTableDiv_Bloom_Count.ColumnName = "Div_Bloom_Count";
            this.coldsOutStoreL3DataTableDiv_Bloom_Count.DataType = typeof(int);
            this.coldsOutStoreL3DataTableDiv_Bloom_Count.DefaultValue = 0;
            this.coldsOutStoreL3DataTableDiv_Bloom_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTablePlan_Bloom_Count
            // 
            this.coldsOutStoreL3DataTablePlan_Bloom_Count.Caption = "Plan_Bloom_Count";
            this.coldsOutStoreL3DataTablePlan_Bloom_Count.ColumnName = "Plan_Bloom_Count";
            this.coldsOutStoreL3DataTablePlan_Bloom_Count.DataType = typeof(int);
            this.coldsOutStoreL3DataTablePlan_Bloom_Count.DefaultValue = 0;
            this.coldsOutStoreL3DataTablePlan_Bloom_Count.Namespace = "";
            // 
            // coldsOutStoreL3DataTableAdd_Div_HeatID
            // 
            this.coldsOutStoreL3DataTableAdd_Div_HeatID.Caption = "Add_Div_HeatID";
            this.coldsOutStoreL3DataTableAdd_Div_HeatID.ColumnName = "Add_Div_HeatID";
            this.coldsOutStoreL3DataTableAdd_Div_HeatID.Namespace = "";
            // 
            // coldsOutStoreL3DataTableADD_HEATID1
            // 
            this.coldsOutStoreL3DataTableADD_HEATID1.Caption = "ADD_HEATID1";
            this.coldsOutStoreL3DataTableADD_HEATID1.ColumnName = "ADD_HEATID1";
            this.coldsOutStoreL3DataTableADD_HEATID1.Namespace = "";
            // 
            // coldsOutStoreL3DataTableADD_HEATID2
            // 
            this.coldsOutStoreL3DataTableADD_HEATID2.Caption = "ADD_HEATID2";
            this.coldsOutStoreL3DataTableADD_HEATID2.ColumnName = "ADD_HEATID2";
            this.coldsOutStoreL3DataTableADD_HEATID2.Namespace = "";
            // 
            // coldsOutStoreL3DataTableADD_BLOOM_COUNT2
            // 
            this.coldsOutStoreL3DataTableADD_BLOOM_COUNT2.Caption = "ADD_BLOOM_COUNT2";
            this.coldsOutStoreL3DataTableADD_BLOOM_COUNT2.ColumnName = "ADD_BLOOM_COUNT2";
            this.coldsOutStoreL3DataTableADD_BLOOM_COUNT2.DataType = typeof(int);
            this.coldsOutStoreL3DataTableADD_BLOOM_COUNT2.DefaultValue = 0;
            this.coldsOutStoreL3DataTableADD_BLOOM_COUNT2.Namespace = "";
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
            this.toolStripLabel1,
            this.btnQuery,
            this.dtOutStoreEndData,
            this.toolStripLabel2,
            this.dtOutStoreData,
            this.toolStripLabel6,
            this.btnOutput,
            this.txtHeatID,
            this.toolStripLabel3,
            this.cmbCasterID,
            this.toolStripLabel4});
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
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
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 22);
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
            this.toolStripLabel6.Text = "出库日期:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(93, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "炉号:";
            // 
            // cmbCasterID
            // 
            this.cmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCasterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCasterID.Items.AddRange(new object[] {
            "",
            "S63",
            "S64",
            "S65",
            "S67",
            "S66"});
            this.cmbCasterID.Name = "cmbCasterID";
            this.cmbCasterID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(47, 17);
            this.toolStripLabel4.Text = "铸机号:";
            // 
            // OutStoreQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "OutStoreQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢坯出库查询";
            this.Text = "出库查询";
            this.Load += new System.EventHandler(this.OutStoreQueryFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OutStoreQueryFrm_FormClosing);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreData;
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
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsOutStore;
        private System.Data.DataColumn coldsOutStoreL3DataTableNo;
        private System.Data.DataColumn coldsOutStoreL3DataTableTarget;
        private System.Data.DataColumn coldsOutStoreL3DataTableSteelGradeIndex;
        private AppSvrHMI.L3DataSet dsBloomArea;
        private System.Data.DataTable schemadsBloomArea;
        private System.Data.DataColumn coldsBloomAreaL3DataTableCode;
        private System.Data.DataColumn coldsBloomAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private AppSvrHMI.L3DataSet dsOffLineReason;
        private System.Data.DataTable schemadsOffLineReason;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtOutStoreEndData;
        private System.Data.DataColumn coldsOutStoreL3DataTableLength;
        private System.Data.DataColumn coldsOutStoreL3DataTableWidth;
        private System.Data.DataColumn coldsOutStoreL3DataTableThickness;
        private System.Data.DataColumn coldsOutStoreL3DataTableCal_Weight;
        private System.Data.DataColumn coldsOutStoreL3DataTableRight_Weight;
        private System.Data.DataColumn coldsOutStoreL3DataTableWaster_Weight;
        private System.Data.DataColumn coldsOutStoreL3DataTableWrong_Weight;
        private System.Data.DataColumn coldsOutStoreL3DataTableBloom_Count;
        private System.Data.DataColumn coldsOutStoreL3DataTableWaster_Count;
        private System.Data.DataColumn coldsOutStoreL3DataTableWrong_Count;
        private System.Data.DataColumn coldsOutStoreL3DataTableRight_Count;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Data.DataColumn coldsOutStoreL3DataTabletotalweight;
        private System.Windows.Forms.ToolStripComboBox cmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Data.DataColumn coldsOutStoreL3DataTableCasterID;
        private System.Data.DataColumn coldsOutStoreL3DataTableAdd_Bloom_Count;
        private System.Data.DataColumn coldsOutStoreL3DataTableDiv_Bloom_Count;
        private System.Data.DataColumn coldsOutStoreL3DataTablePlan_Bloom_Count;
        private System.Data.DataColumn coldsOutStoreL3DataTableAdd_Div_HeatID;
        private System.Data.DataColumn coldsOutStoreL3DataTableADD_HEATID1;
        private System.Data.DataColumn coldsOutStoreL3DataTableADD_HEATID2;
        private System.Data.DataColumn coldsOutStoreL3DataTableADD_BLOOM_COUNT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn storeAreaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cal_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waster_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waster_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wrong_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wrong_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width_Bloom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thickness;
        private System.Windows.Forms.DataGridViewComboBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADD_HEATID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Bloom_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADD_HEATID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADD_BLOOM_COUNT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Add_Div_HeatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Div_Bloom_Count;
    }
}