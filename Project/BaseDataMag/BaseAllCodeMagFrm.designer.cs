namespace BaseDataMag
{
    partial class BaseAllCodeMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseAllCodeMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBase = new System.Windows.Forms.DataGridView();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCode_Function_Group = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNC_Code = new System.Data.DataColumn();
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCodeGroup = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.dsCodeGroup = new AppSvrHMI.L3DataSet();
            this.schemadsCodeGroup = new System.Data.DataTable();
            this.coldsCodeGroupL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsCodeGroupL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Val_Str = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Val_Long = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Val_Double = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NC_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeGroupDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeFunctionGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID_All_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCodeGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnBaseAllCode");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnBaseAllCode");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnBaseAllCode");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBase);
            this.hmiRootPanel1.Controls.Add(this.bnM);
            this.hmiRootPanel1.Controls.Add(this.tSp1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 650);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvBase
            // 
            this.dvBase.AllowUserToAddRows = false;
            this.dvBase.AutoGenerateColumns = false;
            this.dvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvBase.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.codeDesDataGridViewTextBoxColumn,
            this.Code_Val_Str,
            this.Code_Val_Long,
            this.Code_Val_Double,
            this.NC_Code,
            this.codeGroupDataGridViewTextBoxColumn,
            this.codeGroupDesDataGridViewTextBoxColumn,
            this.codeFunctionGroupDataGridViewTextBoxColumn,
            this.GUID_All_Code,
            this.nameDataGridViewTextBoxColumn});
            this.dvBase.DataSource = this.bsBase;
            this.dvBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBase.Location = new System.Drawing.Point(0, 68);
            this.dvBase.MultiSelect = false;
            this.dvBase.Name = "dvBase";
            this.dvBase.RowTemplate.Height = 23;
            this.dvBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvBase.Size = new System.Drawing.Size(1000, 582);
            this.dvBase.TabIndex = 30;
            this.dvBase.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvBase_DataBindingComplete);
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoLoad = true;
            this.dsBase.AutoSubscribe = true;
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = null;
            this.dsBase.InsertMethod = null;
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = "1=2";
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableGUID,
            this.coldsBaseL3DataTableName,
            this.coldsBaseL3DataTableCode,
            this.coldsBaseL3DataTableCode_Des,
            this.coldsBaseL3DataTableCode_Group,
            this.coldsBaseL3DataTableCode_Group_Des,
            this.coldsBaseL3DataTableCode_Val_Str,
            this.coldsBaseL3DataTableCode_Val_Long,
            this.coldsBaseL3DataTableCode_Val_Double,
            this.coldsBaseL3DataTableCode_Function_Group,
            this.coldsBaseL3DataTableNC_Code});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableGUID
            // 
            this.coldsBaseL3DataTableGUID.Caption = "GUID";
            this.coldsBaseL3DataTableGUID.ColumnName = "GUID";
            this.coldsBaseL3DataTableGUID.Namespace = "";
            // 
            // coldsBaseL3DataTableName
            // 
            this.coldsBaseL3DataTableName.Caption = "Name";
            this.coldsBaseL3DataTableName.ColumnName = "Name";
            this.coldsBaseL3DataTableName.Namespace = "";
            // 
            // coldsBaseL3DataTableCode
            // 
            this.coldsBaseL3DataTableCode.Caption = "Code";
            this.coldsBaseL3DataTableCode.ColumnName = "Code";
            this.coldsBaseL3DataTableCode.Namespace = "";
            // 
            // coldsBaseL3DataTableCode_Des
            // 
            this.coldsBaseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBaseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBaseL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBaseL3DataTableCode_Group
            // 
            this.coldsBaseL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsBaseL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsBaseL3DataTableCode_Group.Namespace = "";
            // 
            // coldsBaseL3DataTableCode_Group_Des
            // 
            this.coldsBaseL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsBaseL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsBaseL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsBaseL3DataTableCode_Val_Str
            // 
            this.coldsBaseL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsBaseL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsBaseL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsBaseL3DataTableCode_Val_Long
            // 
            this.coldsBaseL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBaseL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBaseL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsBaseL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsBaseL3DataTableCode_Val_Double
            // 
            this.coldsBaseL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsBaseL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsBaseL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsBaseL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsBaseL3DataTableCode_Function_Group
            // 
            this.coldsBaseL3DataTableCode_Function_Group.Caption = "Code_Function_Group";
            this.coldsBaseL3DataTableCode_Function_Group.ColumnName = "Code_Function_Group";
            this.coldsBaseL3DataTableCode_Function_Group.Namespace = "";
            // 
            // coldsBaseL3DataTableNC_Code
            // 
            this.coldsBaseL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsBaseL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsBaseL3DataTableNC_Code.Namespace = "";
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
            this.bnM.BindingSource = this.bsBase;
            this.bnM.CountItem = this.bindingNavigatorCountItem;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.cmbCodeGroup,
            this.toolStripLabel1});
            this.bnM.Location = new System.Drawing.Point(0, 43);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(1000, 25);
            this.bnM.TabIndex = 29;
            this.bnM.Text = "bindingNavigator1";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // cmbCodeGroup
            // 
            this.cmbCodeGroup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCodeGroup.DropDownHeight = 200;
            this.cmbCodeGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodeGroup.DropDownWidth = 150;
            this.cmbCodeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbCodeGroup.IntegralHeight = false;
            this.cmbCodeGroup.Name = "cmbCodeGroup";
            this.cmbCodeGroup.Size = new System.Drawing.Size(121, 25);
            this.cmbCodeGroup.SelectedIndexChanged += new System.EventHandler(this.cmbCodeGroup_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel1.Text = "代码组:";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 28;
            this.tSp1.Text = "toolStrip1";
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
            // dsCodeGroup
            // 
            this.dsCodeGroup.AutoLoad = true;
            this.dsCodeGroup.AutoSubscribe = true;
            this.dsCodeGroup.DataSetName = "L3DataSet";
            this.dsCodeGroup.DeleteMethod = null;
            this.dsCodeGroup.InsertMethod = null;
            this.dsCodeGroup.L3DataAdapter = this.Adapter;
            this.dsCodeGroup.LoadEvent = "Click";
            this.dsCodeGroup.LoadTrigger = null;
            this.dsCodeGroup.RefreshValve = 1000;
            this.dsCodeGroup.SourceCommand = null;
            this.dsCodeGroup.SourceCondition = "";
            this.dsCodeGroup.SourceMethod = "";
            this.dsCodeGroup.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsCodeGroup.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCodeGroup.SubscribeTarget = null;
            this.dsCodeGroup.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCodeGroup});
            this.dsCodeGroup.UpdateEvent = "Click";
            this.dsCodeGroup.UpdateMethod = null;
            this.dsCodeGroup.UpdateTrigger = null;
            // 
            // schemadsCodeGroup
            // 
            this.schemadsCodeGroup.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCodeGroupL3DataTableCode_Group,
            this.coldsCodeGroupL3DataTableCode_Group_Des});
            this.schemadsCodeGroup.TableName = "L3DataTable";
            // 
            // coldsCodeGroupL3DataTableCode_Group
            // 
            this.coldsCodeGroupL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsCodeGroupL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsCodeGroupL3DataTableCode_Group.Namespace = "";
            // 
            // coldsCodeGroupL3DataTableCode_Group_Des
            // 
            this.coldsCodeGroupL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsCodeGroupL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsCodeGroupL3DataTableCode_Group_Des.Namespace = "";
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Code.DefaultCellStyle = dataGridViewCellStyle1;
            this.Code.HeaderText = "代码";
            this.Code.Name = "Code";
            // 
            // codeDesDataGridViewTextBoxColumn
            // 
            this.codeDesDataGridViewTextBoxColumn.DataPropertyName = "Code_Des";
            this.codeDesDataGridViewTextBoxColumn.HeaderText = "代码描述";
            this.codeDesDataGridViewTextBoxColumn.Name = "codeDesDataGridViewTextBoxColumn";
            // 
            // Code_Val_Str
            // 
            this.Code_Val_Str.DataPropertyName = "Code_Val_Str";
            this.Code_Val_Str.HeaderText = "代码值(串)";
            this.Code_Val_Str.Name = "Code_Val_Str";
            // 
            // Code_Val_Long
            // 
            this.Code_Val_Long.DataPropertyName = "Code_Val_Long";
            this.Code_Val_Long.HeaderText = "代码值(整数)";
            this.Code_Val_Long.Name = "Code_Val_Long";
            // 
            // Code_Val_Double
            // 
            this.Code_Val_Double.DataPropertyName = "Code_Val_Double";
            this.Code_Val_Double.HeaderText = "代码值(浮点)";
            this.Code_Val_Double.Name = "Code_Val_Double";
            // 
            // NC_Code
            // 
            this.NC_Code.DataPropertyName = "NC_Code";
            this.NC_Code.HeaderText = "NC编码";
            this.NC_Code.Name = "NC_Code";
            // 
            // codeGroupDataGridViewTextBoxColumn
            // 
            this.codeGroupDataGridViewTextBoxColumn.DataPropertyName = "Code_Group";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.codeGroupDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codeGroupDataGridViewTextBoxColumn.HeaderText = "代码组";
            this.codeGroupDataGridViewTextBoxColumn.Name = "codeGroupDataGridViewTextBoxColumn";
            this.codeGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeGroupDesDataGridViewTextBoxColumn
            // 
            this.codeGroupDesDataGridViewTextBoxColumn.DataPropertyName = "Code_Group_Des";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.codeGroupDesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.codeGroupDesDataGridViewTextBoxColumn.HeaderText = "代码组描述";
            this.codeGroupDesDataGridViewTextBoxColumn.Name = "codeGroupDesDataGridViewTextBoxColumn";
            this.codeGroupDesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeFunctionGroupDataGridViewTextBoxColumn
            // 
            this.codeFunctionGroupDataGridViewTextBoxColumn.DataPropertyName = "Code_Function_Group";
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.codeFunctionGroupDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.codeFunctionGroupDataGridViewTextBoxColumn.HeaderText = "功能分组";
            this.codeFunctionGroupDataGridViewTextBoxColumn.Name = "codeFunctionGroupDataGridViewTextBoxColumn";
            this.codeFunctionGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GUID_All_Code
            // 
            this.GUID_All_Code.DataPropertyName = "GUID";
            this.GUID_All_Code.HeaderText = "GUID";
            this.GUID_All_Code.Name = "GUID_All_Code";
            this.GUID_All_Code.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // BaseAllCodeMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseAllCodeMagFrm";
            this.TabText = "MES系统编码查询";
            this.Text = "BaseAllCodeMagFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseAllCodeMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.BaseAllCodeMagFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCodeGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.DataGridView dvBase;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableCode;
        private System.Data.DataColumn coldsBaseL3DataTableCode_Des;
        private System.Data.DataColumn coldsBaseL3DataTableCode_Group;
        private System.Data.DataColumn coldsBaseL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsBaseL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsBaseL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsBaseL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsBaseL3DataTableCode_Function_Group;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbCodeGroup;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private AppSvrHMI.L3DataSet dsCodeGroup;
        private System.Data.DataTable schemadsCodeGroup;
        private System.Data.DataColumn coldsCodeGroupL3DataTableCode_Group;
        private System.Data.DataColumn coldsCodeGroupL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsBaseL3DataTableNC_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Val_Str;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Val_Double;
        private System.Windows.Forms.DataGridViewTextBoxColumn NC_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeGroupDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeFunctionGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID_All_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}