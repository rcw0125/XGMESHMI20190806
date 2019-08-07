namespace BaseDataMag
{
    partial class SteelGradeStandardMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelGradeStandardMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.bnCostStandardRate = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmdpMatPrice = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvCostStandardRate = new System.Windows.Forms.DataGridView();
            this.costItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsItem = new AppSvrHMI.L3DataSet();
            this.schemadsMedium = new System.Data.DataTable();
            this.coldsMediumL3DataTableCode = new System.Data.DataColumn();
            this.coldsMediumL3DataTableCode_Des = new System.Data.DataColumn();
            this.costCenterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCostCenter = new AppSvrHMI.L3DataSet();
            this.schemadsCostCenter = new System.Data.DataTable();
            this.coldsCostCenterL3DataTableCode = new System.Data.DataColumn();
            this.coldsCostCenterL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCostCenterL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsCostCenterL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCostStandardRate = new System.Windows.Forms.BindingSource(this.components);
            this.dsCostStandardRate = new AppSvrHMI.L3DataSet();
            this.schemadsCostMedium = new System.Data.DataTable();
            this.coldsCostMediumL3DataTableGUID = new System.Data.DataColumn();
            this.coldsCostMediumL3DataTableName = new System.Data.DataColumn();
            this.coldsCostMediumL3DataTableCost_Center = new System.Data.DataColumn();
            this.coldsCostMediumL3DataTableStandard_Cost = new System.Data.DataColumn();
            this.coldsCostStandardRateL3DataTableCost_Item = new System.Data.DataColumn();
            this.coldsCostStandardRateL3DataTablePro_type = new System.Data.DataColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCostStandardRate)).BeginInit();
            this.bnCostStandardRate.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCostStandardRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCostCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostStandardRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostStandardRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCostMedium)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator5,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 43);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // bnCostStandardRate
            // 
            this.bnCostStandardRate.AddNewItem = null;
            this.bnCostStandardRate.AutoSize = false;
            this.bnCostStandardRate.CountItem = this.bindingNavigatorCountItem;
            this.bnCostStandardRate.DeleteItem = null;
            this.bnCostStandardRate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.bnCostStandardRate.Location = new System.Drawing.Point(0, 43);
            this.bnCostStandardRate.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCostStandardRate.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCostStandardRate.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCostStandardRate.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCostStandardRate.Name = "bnCostStandardRate";
            this.bnCostStandardRate.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCostStandardRate.Size = new System.Drawing.Size(1000, 25);
            this.bnCostStandardRate.TabIndex = 25;
            this.bnCostStandardRate.Text = "bindingNavigator1";
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
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // cmdpMatPrice
            // 
            this.cmdpMatPrice.AcceptAfterExecuted = false;
            this.cmdpMatPrice.ConstantValue = null;
            this.cmdpMatPrice.MergeTarget = false;
            this.cmdpMatPrice.SourceFilter = null;
            this.cmdpMatPrice.SourceObject = null;
            this.cmdpMatPrice.SourceProperty = null;
            this.cmdpMatPrice.TargetObject = null;
            this.cmdpMatPrice.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvCostStandardRate);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 26;
            // 
            // dvCostStandardRate
            // 
            this.dvCostStandardRate.AllowUserToAddRows = false;
            this.dvCostStandardRate.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvCostStandardRate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvCostStandardRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCostStandardRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costItemDataGridViewTextBoxColumn,
            this.costCenterDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.protypeDataGridViewTextBoxColumn,
            this.standardCostDataGridViewTextBoxColumn});
            this.dvCostStandardRate.DataSource = this.bsCostStandardRate;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvCostStandardRate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvCostStandardRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCostStandardRate.Location = new System.Drawing.Point(0, 0);
            this.dvCostStandardRate.Name = "dvCostStandardRate";
            this.dvCostStandardRate.RowTemplate.Height = 23;
            this.dvCostStandardRate.Size = new System.Drawing.Size(1000, 632);
            this.dvCostStandardRate.TabIndex = 0;
            this.dvCostStandardRate.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMatPrice_DataError);
            // 
            // costItemDataGridViewTextBoxColumn
            // 
            this.costItemDataGridViewTextBoxColumn.DataPropertyName = "Cost_Item";
            this.costItemDataGridViewTextBoxColumn.DataSource = this.dsItem;
            this.costItemDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.costItemDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.costItemDataGridViewTextBoxColumn.HeaderText = "成本项目";
            this.costItemDataGridViewTextBoxColumn.Name = "costItemDataGridViewTextBoxColumn";
            this.costItemDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.costItemDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.costItemDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsItem
            // 
            this.dsItem.AutoLoad = true;
            this.dsItem.AutoSubscribe = false;
            this.dsItem.DataSetName = "L3DataSet";
            this.dsItem.DeleteMethod = "";
            this.dsItem.InsertMethod = "";
            this.dsItem.L3DataAdapter = this.Adapter;
            this.dsItem.LoadEvent = "";
            this.dsItem.LoadTrigger = null;
            this.dsItem.RefreshValve = 1000;
            this.dsItem.SourceCommand = null;
            this.dsItem.SourceCondition = "code_group = \'Cost_Item\' and code is not null order by code_des";
            this.dsItem.SourceMethod = "";
            this.dsItem.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsItem.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsItem.SubscribeTarget = "";
            this.dsItem.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMedium});
            this.dsItem.UpdateEvent = "";
            this.dsItem.UpdateMethod = "";
            this.dsItem.UpdateTrigger = null;
            // 
            // schemadsMedium
            // 
            this.schemadsMedium.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMediumL3DataTableCode,
            this.coldsMediumL3DataTableCode_Des});
            this.schemadsMedium.TableName = "L3DataTable";
            // 
            // coldsMediumL3DataTableCode
            // 
            this.coldsMediumL3DataTableCode.Caption = "Code";
            this.coldsMediumL3DataTableCode.ColumnName = "Code";
            this.coldsMediumL3DataTableCode.Namespace = "";
            // 
            // coldsMediumL3DataTableCode_Des
            // 
            this.coldsMediumL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMediumL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMediumL3DataTableCode_Des.Namespace = "";
            // 
            // costCenterDataGridViewTextBoxColumn
            // 
            this.costCenterDataGridViewTextBoxColumn.DataPropertyName = "Cost_Center";
            this.costCenterDataGridViewTextBoxColumn.DataSource = this.dsCostCenter;
            this.costCenterDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.costCenterDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.costCenterDataGridViewTextBoxColumn.HeaderText = "成本中心";
            this.costCenterDataGridViewTextBoxColumn.Name = "costCenterDataGridViewTextBoxColumn";
            this.costCenterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.costCenterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.costCenterDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsCostCenter
            // 
            this.dsCostCenter.AutoLoad = true;
            this.dsCostCenter.AutoSubscribe = false;
            this.dsCostCenter.DataSetName = "L3DataSet";
            this.dsCostCenter.DeleteMethod = "";
            this.dsCostCenter.InsertMethod = "";
            this.dsCostCenter.L3DataAdapter = this.Adapter;
            this.dsCostCenter.LoadEvent = "";
            this.dsCostCenter.LoadTrigger = null;
            this.dsCostCenter.RefreshValve = 1000;
            this.dsCostCenter.SourceCommand = null;
            this.dsCostCenter.SourceCondition = "code_group = \'Caster\' and code is not null order by code";
            this.dsCostCenter.SourceMethod = "";
            this.dsCostCenter.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCostCenter.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCostCenter.SubscribeTarget = "";
            this.dsCostCenter.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCostCenter});
            this.dsCostCenter.UpdateEvent = "";
            this.dsCostCenter.UpdateMethod = "";
            this.dsCostCenter.UpdateTrigger = null;
            // 
            // schemadsCostCenter
            // 
            this.schemadsCostCenter.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCostCenterL3DataTableCode,
            this.coldsCostCenterL3DataTableCode_Des,
            this.coldsCostCenterL3DataTableCode_Group,
            this.coldsCostCenterL3DataTableCode_Val_Long});
            this.schemadsCostCenter.TableName = "L3DataTable";
            // 
            // coldsCostCenterL3DataTableCode
            // 
            this.coldsCostCenterL3DataTableCode.Caption = "Code";
            this.coldsCostCenterL3DataTableCode.ColumnName = "Code";
            this.coldsCostCenterL3DataTableCode.Namespace = "";
            // 
            // coldsCostCenterL3DataTableCode_Des
            // 
            this.coldsCostCenterL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCostCenterL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCostCenterL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCostCenterL3DataTableCode_Group
            // 
            this.coldsCostCenterL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsCostCenterL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsCostCenterL3DataTableCode_Group.Namespace = "";
            // 
            // coldsCostCenterL3DataTableCode_Val_Long
            // 
            this.coldsCostCenterL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCostCenterL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCostCenterL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsCostCenterL3DataTableCode_Val_Long.Namespace = "";
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // protypeDataGridViewTextBoxColumn
            // 
            this.protypeDataGridViewTextBoxColumn.DataPropertyName = "Pro_type";
            this.protypeDataGridViewTextBoxColumn.HeaderText = "产品类";
            this.protypeDataGridViewTextBoxColumn.Name = "protypeDataGridViewTextBoxColumn";
            this.protypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // standardCostDataGridViewTextBoxColumn
            // 
            this.standardCostDataGridViewTextBoxColumn.DataPropertyName = "Standard_Cost";
            this.standardCostDataGridViewTextBoxColumn.HeaderText = "标准费用";
            this.standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
            // 
            // bsCostStandardRate
            // 
            this.bsCostStandardRate.DataMember = "L3DataTable";
            this.bsCostStandardRate.DataSource = this.dsCostStandardRate;
            this.bsCostStandardRate.Sort = "Cost_Item,Cost_Center";
            // 
            // dsCostStandardRate
            // 
            this.dsCostStandardRate.AutoLoad = true;
            this.dsCostStandardRate.AutoSubscribe = true;
            this.dsCostStandardRate.DataSetName = "L3DataSet";
            this.dsCostStandardRate.DeleteMethod = "";
            this.dsCostStandardRate.InsertMethod = "";
            this.dsCostStandardRate.L3DataAdapter = this.Adapter;
            this.dsCostStandardRate.LoadEvent = "";
            this.dsCostStandardRate.LoadTrigger = null;
            this.dsCostStandardRate.RefreshValve = 1000;
            this.dsCostStandardRate.SourceCommand = null;
            this.dsCostStandardRate.SourceCondition = "";
            this.dsCostStandardRate.SourceMethod = "";
            this.dsCostStandardRate.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCostStandardRate.SourceURI = "XGMESLogic\\BaseDataMag\\CCost_Standard_Rate";
            this.dsCostStandardRate.SubscribeTarget = "";
            this.dsCostStandardRate.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCostMedium});
            this.dsCostStandardRate.UpdateEvent = "";
            this.dsCostStandardRate.UpdateMethod = "";
            this.dsCostStandardRate.UpdateTrigger = null;
            // 
            // schemadsCostMedium
            // 
            this.schemadsCostMedium.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCostMediumL3DataTableGUID,
            this.coldsCostMediumL3DataTableName,
            this.coldsCostMediumL3DataTableCost_Center,
            this.coldsCostMediumL3DataTableStandard_Cost,
            this.coldsCostStandardRateL3DataTableCost_Item,
            this.coldsCostStandardRateL3DataTablePro_type});
            this.schemadsCostMedium.TableName = "L3DataTable";
            // 
            // coldsCostMediumL3DataTableGUID
            // 
            this.coldsCostMediumL3DataTableGUID.Caption = "GUID";
            this.coldsCostMediumL3DataTableGUID.ColumnName = "GUID";
            this.coldsCostMediumL3DataTableGUID.Namespace = "";
            // 
            // coldsCostMediumL3DataTableName
            // 
            this.coldsCostMediumL3DataTableName.Caption = "Name";
            this.coldsCostMediumL3DataTableName.ColumnName = "Name";
            this.coldsCostMediumL3DataTableName.Namespace = "";
            // 
            // coldsCostMediumL3DataTableCost_Center
            // 
            this.coldsCostMediumL3DataTableCost_Center.Caption = "Cost_Center";
            this.coldsCostMediumL3DataTableCost_Center.ColumnName = "Cost_Center";
            this.coldsCostMediumL3DataTableCost_Center.Namespace = "";
            // 
            // coldsCostMediumL3DataTableStandard_Cost
            // 
            this.coldsCostMediumL3DataTableStandard_Cost.Caption = "Standard_Cost";
            this.coldsCostMediumL3DataTableStandard_Cost.ColumnName = "Standard_Cost";
            this.coldsCostMediumL3DataTableStandard_Cost.DataType = typeof(float);
            this.coldsCostMediumL3DataTableStandard_Cost.Namespace = "";
            // 
            // coldsCostStandardRateL3DataTableCost_Item
            // 
            this.coldsCostStandardRateL3DataTableCost_Item.Caption = "Cost_Item";
            this.coldsCostStandardRateL3DataTableCost_Item.ColumnName = "Cost_Item";
            this.coldsCostStandardRateL3DataTableCost_Item.Namespace = "";
            // 
            // coldsCostStandardRateL3DataTablePro_type
            // 
            this.coldsCostStandardRateL3DataTablePro_type.Caption = "Pro_type";
            this.coldsCostStandardRateL3DataTablePro_type.ColumnName = "Pro_type";
            this.coldsCostStandardRateL3DataTablePro_type.Namespace = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pro_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "产品类";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Standard_Cost";
            this.dataGridViewTextBoxColumn4.HeaderText = "标准费用";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // CostStandardRateMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bnCostStandardRate);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CostStandardRateMagFrm";
            this.TabText = "标准费率管理";
            this.Text = "标准费率管理";
            this.Load += new System.EventHandler(this.CostStandardRateMagFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnCostStandardRate)).EndInit();
            this.bnCostStandardRate.ResumeLayout(false);
            this.bnCostStandardRate.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCostStandardRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCostCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostStandardRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostStandardRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCostMedium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.BindingNavigator bnCostStandardRate;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvCostStandardRate;
        private AppSvrHMI.L3CommandParameter cmdpMatPrice;
        private AppSvrHMI.L3DataSet dsCostStandardRate;
        private System.Data.DataTable schemadsCostMedium;
        private System.Windows.Forms.BindingSource bsCostStandardRate;
        private System.Data.DataColumn coldsCostMediumL3DataTableGUID;
        private System.Data.DataColumn coldsCostMediumL3DataTableName;
        private System.Data.DataColumn coldsCostMediumL3DataTableCost_Center;
        private System.Data.DataColumn coldsCostMediumL3DataTableStandard_Cost;
        private AppSvrHMI.L3DataSet dsItem;
        private System.Data.DataTable schemadsMedium;
        private System.Data.DataColumn coldsMediumL3DataTableCode;
        private System.Data.DataColumn coldsMediumL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCostCenter;
        private System.Data.DataTable schemadsCostCenter;
        private System.Data.DataColumn coldsCostCenterL3DataTableCode;
        private System.Data.DataColumn coldsCostCenterL3DataTableCode_Des;
        private System.Data.DataColumn coldsCostCenterL3DataTableCode_Group;
        private System.Data.DataColumn coldsCostCenterL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsCostStandardRateL3DataTableCost_Item;
        private System.Data.DataColumn coldsCostStandardRateL3DataTablePro_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn costItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn costCenterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
    }
}