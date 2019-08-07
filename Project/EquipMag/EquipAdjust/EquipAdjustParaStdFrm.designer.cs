namespace EquipMag.EquipAdjust
{
    partial class EquipAdjustParaStdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipAdjustParaStdFrm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsAdjustSet = new System.Windows.Forms.BindingSource(this.components);
            this.dsAdjustSet = new AppSvrHMI.L3DataSet();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableAdjustType = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableAdjustObject = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableItems = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableStandard = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableValidFlag = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvAdjustSet = new System.Windows.Forms.DataGridView();
            this.adjustTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAdjustType = new AppSvrHMI.L3DataSet();
            this.schemadsSort = new System.Data.DataTable();
            this.coldsAdjustTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAdjustTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdjustTypeL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsAdjustTypeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsEquipID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.adjustObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAdjustObject = new AppSvrHMI.L3DataSet();
            this.schemadsStrandNo = new System.Data.DataTable();
            this.coldsAdjustObjectL3DataTableCode = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsAdjustObjectL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsItems = new AppSvrHMI.L3DataSet();
            this.schemadsProject = new System.Data.DataTable();
            this.coldsItemsL3DataTableCode = new System.Data.DataColumn();
            this.coldsItemsL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsItemsL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsItemsL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.standardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.coldsEquipIDL3DataTableFlag = new System.Data.DataColumn();
            this.coldsStrandNoL3DataTableFlag = new System.Data.DataColumn();
            this.coldsProjectL3DataTableSort = new System.Data.DataColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEquipID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustObject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStrandNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProject)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1000, 43);
            this.toolStripMain.TabIndex = 15;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnEquipAdjustParaStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnEquipAdjustParaStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnEquipAdjustParaStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnEquipAdjustParaStd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsAdjustSet;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsAdjustSet
            // 
            this.bsAdjustSet.DataMember = "L3DataTable";
            this.bsAdjustSet.DataSource = this.dsAdjustSet;
            // 
            // dsAdjustSet
            // 
            this.dsAdjustSet.AutoSubscribe = false;
            this.dsAdjustSet.DataSetName = "L3DataSet";
            this.dsAdjustSet.DeleteMethod = "";
            this.dsAdjustSet.InsertMethod = "";
            this.dsAdjustSet.L3DataAdapter = this.Adapter;
            this.dsAdjustSet.LoadEvent = "";
            this.dsAdjustSet.LoadTrigger = null;
            this.dsAdjustSet.RefreshValve = 1000;
            this.dsAdjustSet.SourceCommand = null;
            this.dsAdjustSet.SourceCondition = "AdjustType is not null order by AdjustType,UnitID,AdjustObject";
            this.dsAdjustSet.SourceMethod = "";
            this.dsAdjustSet.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustSet.SourceURI = "XGMESLogic\\EquipMag\\CEupip_Adjust_Std";
            this.dsAdjustSet.SubscribeTarget = null;
            this.dsAdjustSet.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsAdjustSet.UpdateEvent = "";
            this.dsAdjustSet.UpdateMethod = "";
            this.dsAdjustSet.UpdateTrigger = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsAdjustSetL3DataTableAdjustType,
            this.coldsAdjustSetL3DataTableUnitID,
            this.coldsAdjustSetL3DataTableAdjustObject,
            this.coldsAdjustSetL3DataTableItems,
            this.coldsAdjustSetL3DataTableStandard,
            this.coldsAdjustSetL3DataTableValidFlag});
            this.schemadsEnergyData.TableName = "L3DataTable";
            // 
            // coldsEnergyDataL3DataTableGUID
            // 
            this.coldsEnergyDataL3DataTableGUID.Caption = "GUID";
            this.coldsEnergyDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsEnergyDataL3DataTableGUID.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableName
            // 
            this.coldsEnergyDataL3DataTableName.Caption = "Name";
            this.coldsEnergyDataL3DataTableName.ColumnName = "Name";
            this.coldsEnergyDataL3DataTableName.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableAdjustType
            // 
            this.coldsAdjustSetL3DataTableAdjustType.Caption = "AdjustType";
            this.coldsAdjustSetL3DataTableAdjustType.ColumnName = "AdjustType";
            this.coldsAdjustSetL3DataTableAdjustType.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableUnitID
            // 
            this.coldsAdjustSetL3DataTableUnitID.Caption = "UnitID";
            this.coldsAdjustSetL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsAdjustSetL3DataTableUnitID.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableAdjustObject
            // 
            this.coldsAdjustSetL3DataTableAdjustObject.Caption = "AdjustObject";
            this.coldsAdjustSetL3DataTableAdjustObject.ColumnName = "AdjustObject";
            this.coldsAdjustSetL3DataTableAdjustObject.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableItems
            // 
            this.coldsAdjustSetL3DataTableItems.Caption = "Items";
            this.coldsAdjustSetL3DataTableItems.ColumnName = "Items";
            this.coldsAdjustSetL3DataTableItems.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableStandard
            // 
            this.coldsAdjustSetL3DataTableStandard.Caption = "Standard";
            this.coldsAdjustSetL3DataTableStandard.ColumnName = "Standard";
            this.coldsAdjustSetL3DataTableStandard.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableValidFlag
            // 
            this.coldsAdjustSetL3DataTableValidFlag.Caption = "ValidFlag";
            this.coldsAdjustSetL3DataTableValidFlag.ColumnName = "ValidFlag";
            this.coldsAdjustSetL3DataTableValidFlag.DataType = typeof(int);
            this.coldsAdjustSetL3DataTableValidFlag.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到第一条记录";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到上一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到下一条记录";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dvAdjustSet
            // 
            this.dvAdjustSet.AllowUserToAddRows = false;
            this.dvAdjustSet.AllowUserToDeleteRows = false;
            this.dvAdjustSet.AllowUserToResizeRows = false;
            this.dvAdjustSet.AutoGenerateColumns = false;
            this.dvAdjustSet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAdjustSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAdjustSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adjustTypeDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.adjustObjectDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.standardDataGridViewTextBoxColumn,
            this.validFlagDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvAdjustSet.DataSource = this.bsAdjustSet;
            this.dvAdjustSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAdjustSet.Location = new System.Drawing.Point(0, 68);
            this.dvAdjustSet.MultiSelect = false;
            this.dvAdjustSet.Name = "dvAdjustSet";
            this.dvAdjustSet.RowTemplate.Height = 23;
            this.dvAdjustSet.Size = new System.Drawing.Size(1000, 532);
            this.dvAdjustSet.TabIndex = 20;
            this.dvAdjustSet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvAdjustSet_DataError);
            // 
            // adjustTypeDataGridViewTextBoxColumn
            // 
            this.adjustTypeDataGridViewTextBoxColumn.DataPropertyName = "AdjustType";
            this.adjustTypeDataGridViewTextBoxColumn.DataSource = this.dsAdjustType;
            this.adjustTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.adjustTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.adjustTypeDataGridViewTextBoxColumn.HeaderText = "分类";
            this.adjustTypeDataGridViewTextBoxColumn.MaxDropDownItems = 10;
            this.adjustTypeDataGridViewTextBoxColumn.Name = "adjustTypeDataGridViewTextBoxColumn";
            this.adjustTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adjustTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.adjustTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.adjustTypeDataGridViewTextBoxColumn.Width = 199;
            // 
            // dsAdjustType
            // 
            this.dsAdjustType.AutoSubscribe = false;
            this.dsAdjustType.DataSetName = "L3DataSet";
            this.dsAdjustType.DeleteMethod = "";
            this.dsAdjustType.InsertMethod = "";
            this.dsAdjustType.L3DataAdapter = this.Adapter;
            this.dsAdjustType.LoadEvent = "Click";
            this.dsAdjustType.LoadTrigger = null;
            this.dsAdjustType.RefreshValve = 1000;
            this.dsAdjustType.SourceCommand = null;
            this.dsAdjustType.SourceCondition = "Code_Group = \'AdjustType\' order by Code";
            this.dsAdjustType.SourceMethod = "";
            this.dsAdjustType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAdjustType.SubscribeTarget = "";
            this.dsAdjustType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSort});
            this.dsAdjustType.UpdateEvent = "Click";
            this.dsAdjustType.UpdateMethod = "";
            this.dsAdjustType.UpdateTrigger = null;
            // 
            // schemadsSort
            // 
            this.schemadsSort.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdjustTypeL3DataTableCode,
            this.coldsAdjustTypeL3DataTableCode_Des,
            this.coldsAdjustTypeL3DataTableCode_Group,
            this.coldsAdjustTypeL3DataTableCode_Group_Des});
            this.schemadsSort.TableName = "L3DataTable";
            // 
            // coldsAdjustTypeL3DataTableCode
            // 
            this.coldsAdjustTypeL3DataTableCode.Caption = "Code";
            this.coldsAdjustTypeL3DataTableCode.ColumnName = "Code";
            this.coldsAdjustTypeL3DataTableCode.Namespace = "";
            // 
            // coldsAdjustTypeL3DataTableCode_Des
            // 
            this.coldsAdjustTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAdjustTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAdjustTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAdjustTypeL3DataTableCode_Group
            // 
            this.coldsAdjustTypeL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsAdjustTypeL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsAdjustTypeL3DataTableCode_Group.Namespace = "";
            // 
            // coldsAdjustTypeL3DataTableCode_Group_Des
            // 
            this.coldsAdjustTypeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsAdjustTypeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsAdjustTypeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.DataSource = this.dsUnitID;
            this.unitIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.unitIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoSubscribe = false;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "Click";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "Code_Group = \'UnitID\' order by Code";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitID.SubscribeTarget = "";
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEquipID});
            this.dsUnitID.UpdateEvent = "Click";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // schemadsEquipID
            // 
            this.schemadsEquipID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTableCode,
            this.coldsUnitIDL3DataTableCode_Des,
            this.coldsUnitIDL3DataTableCode_Group,
            this.coldsUnitIDL3DataTableCode_Group_Des});
            this.schemadsEquipID.TableName = "L3DataTable";
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
            // coldsUnitIDL3DataTableCode_Group
            // 
            this.coldsUnitIDL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsUnitIDL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsUnitIDL3DataTableCode_Group.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Group_Des
            // 
            this.coldsUnitIDL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsUnitIDL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsUnitIDL3DataTableCode_Group_Des.Namespace = "";
            // 
            // adjustObjectDataGridViewTextBoxColumn
            // 
            this.adjustObjectDataGridViewTextBoxColumn.DataPropertyName = "AdjustObject";
            this.adjustObjectDataGridViewTextBoxColumn.DataSource = this.dsAdjustObject;
            this.adjustObjectDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.adjustObjectDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.adjustObjectDataGridViewTextBoxColumn.HeaderText = "对象";
            this.adjustObjectDataGridViewTextBoxColumn.Name = "adjustObjectDataGridViewTextBoxColumn";
            this.adjustObjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.adjustObjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.adjustObjectDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsAdjustObject
            // 
            this.dsAdjustObject.AutoSubscribe = false;
            this.dsAdjustObject.DataSetName = "L3DataSet";
            this.dsAdjustObject.DeleteMethod = "";
            this.dsAdjustObject.InsertMethod = "";
            this.dsAdjustObject.L3DataAdapter = this.Adapter;
            this.dsAdjustObject.LoadEvent = "Click";
            this.dsAdjustObject.LoadTrigger = null;
            this.dsAdjustObject.RefreshValve = 1000;
            this.dsAdjustObject.SourceCommand = null;
            this.dsAdjustObject.SourceCondition = "Code_Group = \'AdjustObject\' order by Code";
            this.dsAdjustObject.SourceMethod = "";
            this.dsAdjustObject.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdjustObject.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAdjustObject.SubscribeTarget = "";
            this.dsAdjustObject.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStrandNo});
            this.dsAdjustObject.UpdateEvent = "Click";
            this.dsAdjustObject.UpdateMethod = "";
            this.dsAdjustObject.UpdateTrigger = null;
            // 
            // schemadsStrandNo
            // 
            this.schemadsStrandNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdjustObjectL3DataTableCode,
            this.coldsAdjustObjectL3DataTableCode_Des,
            this.coldsAdjustObjectL3DataTableCode_Group,
            this.coldsAdjustObjectL3DataTableCode_Group_Des});
            this.schemadsStrandNo.TableName = "L3DataTable";
            // 
            // coldsAdjustObjectL3DataTableCode
            // 
            this.coldsAdjustObjectL3DataTableCode.Caption = "Code";
            this.coldsAdjustObjectL3DataTableCode.ColumnName = "Code";
            this.coldsAdjustObjectL3DataTableCode.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Des
            // 
            this.coldsAdjustObjectL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAdjustObjectL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAdjustObjectL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Group
            // 
            this.coldsAdjustObjectL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsAdjustObjectL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsAdjustObjectL3DataTableCode_Group.Namespace = "";
            // 
            // coldsAdjustObjectL3DataTableCode_Group_Des
            // 
            this.coldsAdjustObjectL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsAdjustObjectL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsAdjustObjectL3DataTableCode_Group_Des.Namespace = "";
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.DataSource = this.dsItems;
            this.itemsDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.itemsDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemsDataGridViewTextBoxColumn.HeaderText = "项目";
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemsDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.itemsDataGridViewTextBoxColumn.Width = 250;
            // 
            // dsItems
            // 
            this.dsItems.AutoSubscribe = false;
            this.dsItems.DataSetName = "L3DataSet";
            this.dsItems.DeleteMethod = "";
            this.dsItems.InsertMethod = "";
            this.dsItems.L3DataAdapter = this.Adapter;
            this.dsItems.LoadEvent = "Click";
            this.dsItems.LoadTrigger = null;
            this.dsItems.RefreshValve = 1000;
            this.dsItems.SourceCommand = null;
            this.dsItems.SourceCondition = "Code_Group = \'Items\' order by Code";
            this.dsItems.SourceMethod = "";
            this.dsItems.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsItems.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsItems.SubscribeTarget = "";
            this.dsItems.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProject});
            this.dsItems.UpdateEvent = "Click";
            this.dsItems.UpdateMethod = "";
            this.dsItems.UpdateTrigger = null;
            // 
            // schemadsProject
            // 
            this.schemadsProject.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsItemsL3DataTableCode,
            this.coldsItemsL3DataTableCode_Des,
            this.coldsItemsL3DataTableCode_Group,
            this.coldsItemsL3DataTableCode_Group_Des});
            this.schemadsProject.TableName = "L3DataTable";
            // 
            // coldsItemsL3DataTableCode
            // 
            this.coldsItemsL3DataTableCode.Caption = "Code";
            this.coldsItemsL3DataTableCode.ColumnName = "Code";
            this.coldsItemsL3DataTableCode.Namespace = "";
            // 
            // coldsItemsL3DataTableCode_Des
            // 
            this.coldsItemsL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsItemsL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsItemsL3DataTableCode_Des.Namespace = "";
            // 
            // coldsItemsL3DataTableCode_Group
            // 
            this.coldsItemsL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsItemsL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsItemsL3DataTableCode_Group.Namespace = "";
            // 
            // coldsItemsL3DataTableCode_Group_Des
            // 
            this.coldsItemsL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsItemsL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsItemsL3DataTableCode_Group_Des.Namespace = "";
            // 
            // standardDataGridViewTextBoxColumn
            // 
            this.standardDataGridViewTextBoxColumn.DataPropertyName = "Standard";
            this.standardDataGridViewTextBoxColumn.HeaderText = "标准";
            this.standardDataGridViewTextBoxColumn.Name = "standardDataGridViewTextBoxColumn";
            this.standardDataGridViewTextBoxColumn.Width = 199;
            // 
            // validFlagDataGridViewTextBoxColumn
            // 
            this.validFlagDataGridViewTextBoxColumn.DataPropertyName = "ValidFlag";
            this.validFlagDataGridViewTextBoxColumn.HeaderText = "ValidFlag";
            this.validFlagDataGridViewTextBoxColumn.Name = "validFlagDataGridViewTextBoxColumn";
            this.validFlagDataGridViewTextBoxColumn.Visible = false;
            this.validFlagDataGridViewTextBoxColumn.Width = 82;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 52;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 52;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // coldsEquipIDL3DataTableFlag
            // 
            this.coldsEquipIDL3DataTableFlag.Caption = "Flag";
            this.coldsEquipIDL3DataTableFlag.ColumnName = "Flag";
            this.coldsEquipIDL3DataTableFlag.Namespace = "";
            // 
            // coldsStrandNoL3DataTableFlag
            // 
            this.coldsStrandNoL3DataTableFlag.Caption = "Flag";
            this.coldsStrandNoL3DataTableFlag.ColumnName = "Flag";
            this.coldsStrandNoL3DataTableFlag.Namespace = "";
            // 
            // coldsProjectL3DataTableSort
            // 
            this.coldsProjectL3DataTableSort.Caption = "Sort";
            this.coldsProjectL3DataTableSort.ColumnName = "Sort";
            this.coldsProjectL3DataTableSort.Namespace = "";
            // 
            // EquipAdjustParaStdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvAdjustSet);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipAdjustParaStdFrm";
            this.TabText = "设备校准参数标准";
            this.Text = "设备校准参数标准";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEquipID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdjustObject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStrandNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dvAdjustSet;
        private AppSvrHMI.L3DataSet dsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Windows.Forms.BindingSource bsAdjustSet;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsAdjustSetL3DataTableAdjustType;
        private System.Data.DataColumn coldsAdjustSetL3DataTableUnitID;
        private System.Data.DataColumn coldsAdjustSetL3DataTableAdjustObject;
        private System.Data.DataColumn coldsAdjustSetL3DataTableItems;
        private System.Data.DataColumn coldsAdjustSetL3DataTableStandard;
        private System.Data.DataColumn coldsAdjustSetL3DataTableValidFlag;
        private AppSvrHMI.L3DataSet dsAdjustType;
        private System.Data.DataTable schemadsSort;
        private System.Data.DataColumn coldsEquipIDL3DataTableFlag;
        private System.Data.DataColumn coldsStrandNoL3DataTableFlag;
        private System.Data.DataColumn coldsProjectL3DataTableSort;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsEquipID;
        private AppSvrHMI.L3DataSet dsAdjustObject;
        private System.Data.DataTable schemadsStrandNo;
        private AppSvrHMI.L3DataSet dsItems;
        private System.Data.DataTable schemadsProject;
        private System.Data.DataColumn coldsAdjustTypeL3DataTableCode;
        private System.Data.DataColumn coldsAdjustTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdjustTypeL3DataTableCode_Group;
        private System.Data.DataColumn coldsAdjustTypeL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Group;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Group;
        private System.Data.DataColumn coldsAdjustObjectL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsItemsL3DataTableCode;
        private System.Data.DataColumn coldsItemsL3DataTableCode_Des;
        private System.Data.DataColumn coldsItemsL3DataTableCode_Group;
        private System.Data.DataColumn coldsItemsL3DataTableCode_Group_Des;
        private System.Windows.Forms.DataGridViewComboBoxColumn adjustTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn adjustObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}