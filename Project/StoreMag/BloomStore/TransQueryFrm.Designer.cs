namespace StoreMag.BloomStore
{
    partial class TransQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBloomArea = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBloomArea = new System.Data.DataTable();
            this.coldsBloomAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBloomAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.curPileIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCurPileID = new AppSvrHMI.L3DataSet();
            this.schemadsCurPileID = new System.Data.DataTable();
            this.coldsCurPileIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCurPileIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.curLayerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.targetPileIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.targetLayerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTrans = new System.Windows.Forms.BindingSource(this.components);
            this.dsTrans = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableName = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAmount = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableOperator = new System.Data.DataColumn();
            this.coldsTransL3DataTableSourceID = new System.Data.DataColumn();
            this.coldsTransL3DataTableTargetID = new System.Data.DataColumn();
            this.coldsTransL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsTransL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsTransL3DataTableTrans_Date = new System.Data.DataColumn();
            this.coldsTransL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsTransL3DataTableCur_Pile_ID = new System.Data.DataColumn();
            this.coldsTransL3DataTableCur_Layer_ID = new System.Data.DataColumn();
            this.coldsTransL3DataTableTarget_Pile_ID = new System.Data.DataColumn();
            this.coldsTransL3DataTableTarget_Layer_ID = new System.Data.DataColumn();
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
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCurPileID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCurPileID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrans)).BeginInit();
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
            this.hmiRootPanel1.Size = new System.Drawing.Size(887, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.materialIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.sourceIDDataGridViewTextBoxColumn,
            this.curPileIDDataGridViewTextBoxColumn,
            this.curLayerIDDataGridViewTextBoxColumn,
            this.targetIDDataGridViewTextBoxColumn,
            this.targetPileIDDataGridViewTextBoxColumn,
            this.targetLayerIDDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.materialTypeDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsTrans;
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
            // materialIDDataGridViewTextBoxColumn
            // 
            this.materialIDDataGridViewTextBoxColumn.DataPropertyName = "MaterialID";
            this.materialIDDataGridViewTextBoxColumn.HeaderText = "材料号";
            this.materialIDDataGridViewTextBoxColumn.Name = "materialIDDataGridViewTextBoxColumn";
            this.materialIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceIDDataGridViewTextBoxColumn
            // 
            this.sourceIDDataGridViewTextBoxColumn.DataPropertyName = "SourceID";
            this.sourceIDDataGridViewTextBoxColumn.DataSource = this.dsBloomArea;
            this.sourceIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sourceIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sourceIDDataGridViewTextBoxColumn.HeaderText = "原库区";
            this.sourceIDDataGridViewTextBoxColumn.Name = "sourceIDDataGridViewTextBoxColumn";
            this.sourceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sourceIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsBloomArea
            // 
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
            // curPileIDDataGridViewTextBoxColumn
            // 
            this.curPileIDDataGridViewTextBoxColumn.DataPropertyName = "Cur_Pile_ID";
            this.curPileIDDataGridViewTextBoxColumn.DataSource = this.dsCurPileID;
            this.curPileIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.curPileIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.curPileIDDataGridViewTextBoxColumn.HeaderText = "原垛位";
            this.curPileIDDataGridViewTextBoxColumn.Name = "curPileIDDataGridViewTextBoxColumn";
            this.curPileIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.curPileIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.curPileIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.curPileIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsCurPileID
            // 
            this.dsCurPileID.AutoSubscribe = false;
            this.dsCurPileID.DataSetName = "L3DataSet";
            this.dsCurPileID.DeleteMethod = null;
            this.dsCurPileID.InsertMethod = null;
            this.dsCurPileID.L3DataAdapter = this.Adapter;
            this.dsCurPileID.LoadEvent = "Click";
            this.dsCurPileID.LoadTrigger = null;
            this.dsCurPileID.RefreshValve = 1000;
            this.dsCurPileID.SourceCommand = null;
            this.dsCurPileID.SourceCondition = "CODE_GROUP = \'BLOOM_SPILE\' or CODE_GROUP = \'KEEP_SPILE\' ";
            this.dsCurPileID.SourceMethod = "";
            this.dsCurPileID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCurPileID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCurPileID.SubscribeTarget = null;
            this.dsCurPileID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCurPileID});
            this.dsCurPileID.UpdateEvent = "Click";
            this.dsCurPileID.UpdateMethod = null;
            this.dsCurPileID.UpdateTrigger = null;
            // 
            // schemadsCurPileID
            // 
            this.schemadsCurPileID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCurPileIDL3DataTableCode,
            this.coldsCurPileIDL3DataTableCode_Des});
            this.schemadsCurPileID.TableName = "L3DataTable";
            // 
            // coldsCurPileIDL3DataTableCode
            // 
            this.coldsCurPileIDL3DataTableCode.Caption = "Code";
            this.coldsCurPileIDL3DataTableCode.ColumnName = "Code";
            this.coldsCurPileIDL3DataTableCode.Namespace = "";
            // 
            // coldsCurPileIDL3DataTableCode_Des
            // 
            this.coldsCurPileIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCurPileIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCurPileIDL3DataTableCode_Des.Namespace = "";
            // 
            // curLayerIDDataGridViewTextBoxColumn
            // 
            this.curLayerIDDataGridViewTextBoxColumn.DataPropertyName = "Cur_Layer_ID";
            this.curLayerIDDataGridViewTextBoxColumn.HeaderText = "原层";
            this.curLayerIDDataGridViewTextBoxColumn.Name = "curLayerIDDataGridViewTextBoxColumn";
            this.curLayerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // targetIDDataGridViewTextBoxColumn
            // 
            this.targetIDDataGridViewTextBoxColumn.DataPropertyName = "TargetID";
            this.targetIDDataGridViewTextBoxColumn.DataSource = this.dsBloomArea;
            this.targetIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.targetIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.targetIDDataGridViewTextBoxColumn.HeaderText = "目标库区";
            this.targetIDDataGridViewTextBoxColumn.Name = "targetIDDataGridViewTextBoxColumn";
            this.targetIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.targetIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.targetIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.targetIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // targetPileIDDataGridViewTextBoxColumn
            // 
            this.targetPileIDDataGridViewTextBoxColumn.DataPropertyName = "Target_Pile_ID";
            this.targetPileIDDataGridViewTextBoxColumn.DataSource = this.dsCurPileID;
            this.targetPileIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.targetPileIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.targetPileIDDataGridViewTextBoxColumn.HeaderText = "目标垛位";
            this.targetPileIDDataGridViewTextBoxColumn.Name = "targetPileIDDataGridViewTextBoxColumn";
            this.targetPileIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.targetPileIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.targetPileIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.targetPileIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // targetLayerIDDataGridViewTextBoxColumn
            // 
            this.targetLayerIDDataGridViewTextBoxColumn.DataPropertyName = "Target_Layer_ID";
            this.targetLayerIDDataGridViewTextBoxColumn.HeaderText = "目标层";
            this.targetLayerIDDataGridViewTextBoxColumn.Name = "targetLayerIDDataGridViewTextBoxColumn";
            this.targetLayerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作人员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
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
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "Trans_Date";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "转移日期";
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            this.transDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialTypeDataGridViewTextBoxColumn
            // 
            this.materialTypeDataGridViewTextBoxColumn.DataPropertyName = "MaterialType";
            this.materialTypeDataGridViewTextBoxColumn.HeaderText = "材料类型";
            this.materialTypeDataGridViewTextBoxColumn.Name = "materialTypeDataGridViewTextBoxColumn";
            this.materialTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsTrans
            // 
            this.bsTrans.DataMember = "L3DataTable";
            this.bsTrans.DataSource = this.dsTrans;
            // 
            // dsTrans
            // 
            this.dsTrans.AutoSubscribe = false;
            this.dsTrans.DataSetName = "L3DataSet";
            this.dsTrans.DeleteMethod = null;
            this.dsTrans.InsertMethod = null;
            this.dsTrans.L3DataAdapter = null;
            this.dsTrans.LoadEvent = "Click";
            this.dsTrans.LoadTrigger = null;
            this.dsTrans.RefreshValve = 1000;
            this.dsTrans.SourceCommand = null;
            this.dsTrans.SourceCondition = "1=2";
            this.dsTrans.SourceMethod = "";
            this.dsTrans.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTrans.SourceURI = "XGMESLogic\\BloomStoreMag\\CBloom_Trans_Log";
            this.dsTrans.SubscribeTarget = "";
            this.dsTrans.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsTrans.UpdateEvent = "Click";
            this.dsTrans.UpdateMethod = null;
            this.dsTrans.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableGUID,
            this.coldsInStoreL3DataTableName,
            this.coldsInStoreL3DataTableMaterialID,
            this.coldsInStoreL3DataTableAmount,
            this.coldsInStoreL3DataTableOperator,
            this.coldsTransL3DataTableSourceID,
            this.coldsTransL3DataTableTargetID,
            this.coldsTransL3DataTableTeamID,
            this.coldsTransL3DataTableShiftID,
            this.coldsTransL3DataTableTrans_Date,
            this.coldsTransL3DataTableMaterialType,
            this.coldsTransL3DataTableCur_Pile_ID,
            this.coldsTransL3DataTableCur_Layer_ID,
            this.coldsTransL3DataTableTarget_Pile_ID,
            this.coldsTransL3DataTableTarget_Layer_ID});
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
            // coldsInStoreL3DataTableMaterialID
            // 
            this.coldsInStoreL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsInStoreL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsInStoreL3DataTableMaterialID.Namespace = "";
            // 
            // coldsInStoreL3DataTableAmount
            // 
            this.coldsInStoreL3DataTableAmount.Caption = "Amount";
            this.coldsInStoreL3DataTableAmount.ColumnName = "Amount";
            this.coldsInStoreL3DataTableAmount.Namespace = "";
            // 
            // coldsInStoreL3DataTableOperator
            // 
            this.coldsInStoreL3DataTableOperator.Caption = "Operator";
            this.coldsInStoreL3DataTableOperator.ColumnName = "Operator";
            this.coldsInStoreL3DataTableOperator.Namespace = "";
            // 
            // coldsTransL3DataTableSourceID
            // 
            this.coldsTransL3DataTableSourceID.Caption = "SourceID";
            this.coldsTransL3DataTableSourceID.ColumnName = "SourceID";
            this.coldsTransL3DataTableSourceID.Namespace = "";
            // 
            // coldsTransL3DataTableTargetID
            // 
            this.coldsTransL3DataTableTargetID.Caption = "TargetID";
            this.coldsTransL3DataTableTargetID.ColumnName = "TargetID";
            this.coldsTransL3DataTableTargetID.Namespace = "";
            // 
            // coldsTransL3DataTableTeamID
            // 
            this.coldsTransL3DataTableTeamID.Caption = "TeamID";
            this.coldsTransL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsTransL3DataTableTeamID.Namespace = "";
            // 
            // coldsTransL3DataTableShiftID
            // 
            this.coldsTransL3DataTableShiftID.Caption = "ShiftID";
            this.coldsTransL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsTransL3DataTableShiftID.Namespace = "";
            // 
            // coldsTransL3DataTableTrans_Date
            // 
            this.coldsTransL3DataTableTrans_Date.Caption = "Trans_Date";
            this.coldsTransL3DataTableTrans_Date.ColumnName = "Trans_Date";
            this.coldsTransL3DataTableTrans_Date.Namespace = "";
            // 
            // coldsTransL3DataTableMaterialType
            // 
            this.coldsTransL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsTransL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsTransL3DataTableMaterialType.Namespace = "";
            // 
            // coldsTransL3DataTableCur_Pile_ID
            // 
            this.coldsTransL3DataTableCur_Pile_ID.Caption = "Cur_Pile_ID";
            this.coldsTransL3DataTableCur_Pile_ID.ColumnName = "Cur_Pile_ID";
            this.coldsTransL3DataTableCur_Pile_ID.Namespace = "";
            // 
            // coldsTransL3DataTableCur_Layer_ID
            // 
            this.coldsTransL3DataTableCur_Layer_ID.Caption = "Cur_Layer_ID";
            this.coldsTransL3DataTableCur_Layer_ID.ColumnName = "Cur_Layer_ID";
            this.coldsTransL3DataTableCur_Layer_ID.DataType = typeof(int);
            this.coldsTransL3DataTableCur_Layer_ID.Namespace = "";
            // 
            // coldsTransL3DataTableTarget_Pile_ID
            // 
            this.coldsTransL3DataTableTarget_Pile_ID.Caption = "Target_Pile_ID";
            this.coldsTransL3DataTableTarget_Pile_ID.ColumnName = "Target_Pile_ID";
            this.coldsTransL3DataTableTarget_Pile_ID.Namespace = "";
            // 
            // coldsTransL3DataTableTarget_Layer_ID
            // 
            this.coldsTransL3DataTableTarget_Layer_ID.Caption = "Target_Layer_ID";
            this.coldsTransL3DataTableTarget_Layer_ID.ColumnName = "Target_Layer_ID";
            this.coldsTransL3DataTableTarget_Layer_ID.DataType = typeof(int);
            this.coldsTransL3DataTableTarget_Layer_ID.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsTrans;
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
            this.toolStripLabel6.Text = "转库日期:";
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
            // TransQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "TransQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "钢坯转库查询";
            this.Text = "转库查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.TransQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBloomArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBloomArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCurPileID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCurPileID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrans)).EndInit();
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
        private AppSvrHMI.L3DataSet dsTrans;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableGUID;
        private System.Data.DataColumn coldsInStoreL3DataTableName;
        private System.Data.DataColumn coldsInStoreL3DataTableMaterialID;
        private System.Data.DataColumn coldsInStoreL3DataTableAmount;
        private System.Data.DataColumn coldsInStoreL3DataTableOperator;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsTrans;
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
        private System.Data.DataColumn coldsTransL3DataTableSourceID;
        private System.Data.DataColumn coldsTransL3DataTableTargetID;
        private System.Data.DataColumn coldsTransL3DataTableTeamID;
        private System.Data.DataColumn coldsTransL3DataTableShiftID;
        private System.Data.DataColumn coldsTransL3DataTableTrans_Date;
        private System.Data.DataColumn coldsTransL3DataTableMaterialType;
        private System.Data.DataColumn coldsTransL3DataTableCur_Pile_ID;
        private System.Data.DataColumn coldsTransL3DataTableCur_Layer_ID;
        private System.Data.DataColumn coldsTransL3DataTableTarget_Pile_ID;
        private System.Data.DataColumn coldsTransL3DataTableTarget_Layer_ID;
        private AppSvrHMI.L3DataSet dsBloomArea;
        private AppSvrHMI.L3DataSet dsCurPileID;
        private System.Data.DataTable schemadsBloomArea;
        private System.Data.DataColumn coldsBloomAreaL3DataTableCode;
        private System.Data.DataColumn coldsBloomAreaL3DataTableCode_Des;
        private System.Data.DataTable schemadsCurPileID;
        private System.Data.DataColumn coldsCurPileIDL3DataTableCode;
        private System.Data.DataColumn coldsCurPileIDL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sourceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn curPileIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn curLayerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn targetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn targetPileIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetLayerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialTypeDataGridViewTextBoxColumn;
    }
}