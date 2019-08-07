namespace QualityMag.QualityStandard
{
    partial class UnitRouteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitRouteFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bsUnitRoute = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnitRoute = new AppSvrHMI.L3DataSet();
            this.schemadsUnitRoute = new System.Data.DataTable();
            this.coldsUnitRouteL3DataTableGUID = new System.Data.DataColumn();
            this.coldsUnitRouteL3DataTableName = new System.Data.DataColumn();
            this.coldsUnitRouteL3DataTableLev_Type = new System.Data.DataColumn();
            this.coldsUnitRouteL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsUnitRouteL3DataTableLFID = new System.Data.DataColumn();
            this.coldsUnitRouteL3DataTableRHID = new System.Data.DataColumn();
            this.coldsUnitRouteL3DataTableCasterID = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hmiRootPanelUnitRoute = new HMIBase.HMIRootPanel();
            this.dvUnitRoute = new System.Windows.Forms.DataGridView();
            this.levTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBOFID = new AppSvrHMI.L3DataSet();
            this.schemadsBOFID = new System.Data.DataTable();
            this.coldsBOFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.lFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLFID = new AppSvrHMI.L3DataSet();
            this.schemadsLFID = new System.Data.DataTable();
            this.coldsLFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsLFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.rHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsRHID = new AppSvrHMI.L3DataSet();
            this.schemadsRHID = new System.Data.DataTable();
            this.coldsRHIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsRHIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelUnitRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvUnitRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnRoutMaint");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnRoutMaint");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.toolStripMain.Size = new System.Drawing.Size(1020, 43);
            this.toolStripMain.TabIndex = 14;
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
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            this.toolStripSeparator2.Visible = false;
            // 
            // bsUnitRoute
            // 
            this.bsUnitRoute.DataMember = "L3DataTable";
            this.bsUnitRoute.DataSource = this.dsUnitRoute;
            // 
            // dsUnitRoute
            // 
            this.dsUnitRoute.AutoLoad = true;
            this.dsUnitRoute.AutoSubscribe = true;
            this.dsUnitRoute.DataSetName = "L3DataSet";
            this.dsUnitRoute.DeleteMethod = null;
            this.dsUnitRoute.InsertMethod = null;
            this.dsUnitRoute.L3DataAdapter = this.Adapter;
            this.dsUnitRoute.LoadEvent = "Click";
            this.dsUnitRoute.LoadTrigger = null;
            this.dsUnitRoute.RefreshValve = 1000;
            this.dsUnitRoute.SourceCommand = null;
            this.dsUnitRoute.SourceCondition = "CasterID is not null order by CasterID";
            this.dsUnitRoute.SourceMethod = "";
            this.dsUnitRoute.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitRoute.SourceURI = "XGMESLogic\\QualityMag\\CQA_Unit_Route";
            this.dsUnitRoute.SubscribeTarget = null;
            this.dsUnitRoute.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitRoute});
            this.dsUnitRoute.UpdateEvent = "Click";
            this.dsUnitRoute.UpdateMethod = null;
            this.dsUnitRoute.UpdateTrigger = null;
            // 
            // schemadsUnitRoute
            // 
            this.schemadsUnitRoute.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitRouteL3DataTableGUID,
            this.coldsUnitRouteL3DataTableName,
            this.coldsUnitRouteL3DataTableLev_Type,
            this.coldsUnitRouteL3DataTableBOFID,
            this.coldsUnitRouteL3DataTableLFID,
            this.coldsUnitRouteL3DataTableRHID,
            this.coldsUnitRouteL3DataTableCasterID});
            this.schemadsUnitRoute.TableName = "L3DataTable";
            // 
            // coldsUnitRouteL3DataTableGUID
            // 
            this.coldsUnitRouteL3DataTableGUID.Caption = "GUID";
            this.coldsUnitRouteL3DataTableGUID.ColumnName = "GUID";
            this.coldsUnitRouteL3DataTableGUID.Namespace = "";
            // 
            // coldsUnitRouteL3DataTableName
            // 
            this.coldsUnitRouteL3DataTableName.Caption = "Name";
            this.coldsUnitRouteL3DataTableName.ColumnName = "Name";
            this.coldsUnitRouteL3DataTableName.Namespace = "";
            // 
            // coldsUnitRouteL3DataTableLev_Type
            // 
            this.coldsUnitRouteL3DataTableLev_Type.Caption = "Lev_Type";
            this.coldsUnitRouteL3DataTableLev_Type.ColumnName = "Lev_Type";
            this.coldsUnitRouteL3DataTableLev_Type.DataType = typeof(int);
            this.coldsUnitRouteL3DataTableLev_Type.Namespace = "";
            // 
            // coldsUnitRouteL3DataTableBOFID
            // 
            this.coldsUnitRouteL3DataTableBOFID.Caption = "BOFID";
            this.coldsUnitRouteL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsUnitRouteL3DataTableBOFID.Namespace = "";
            // 
            // coldsUnitRouteL3DataTableLFID
            // 
            this.coldsUnitRouteL3DataTableLFID.Caption = "LFID";
            this.coldsUnitRouteL3DataTableLFID.ColumnName = "LFID";
            this.coldsUnitRouteL3DataTableLFID.Namespace = "";
            // 
            // coldsUnitRouteL3DataTableRHID
            // 
            this.coldsUnitRouteL3DataTableRHID.Caption = "RHID";
            this.coldsUnitRouteL3DataTableRHID.ColumnName = "RHID";
            this.coldsUnitRouteL3DataTableRHID.Namespace = "";
            // 
            // coldsUnitRouteL3DataTableCasterID
            // 
            this.coldsUnitRouteL3DataTableCasterID.Caption = "CasterID";
            this.coldsUnitRouteL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsUnitRouteL3DataTableCasterID.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsUnitRoute;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripButton4,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1020, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel5.Text = "　";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到上一条记录";
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到下一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hmiRootPanelUnitRoute
            // 
            this.hmiRootPanelUnitRoute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelUnitRoute.Controls.Add(this.dvUnitRoute);
            this.hmiRootPanelUnitRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelUnitRoute.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelUnitRoute.Name = "hmiRootPanelUnitRoute";
            this.hmiRootPanelUnitRoute.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelUnitRoute.TabIndex = 18;
            // 
            // dvUnitRoute
            // 
            this.dvUnitRoute.AllowUserToAddRows = false;
            this.dvUnitRoute.AllowUserToDeleteRows = false;
            this.dvUnitRoute.AutoGenerateColumns = false;
            this.dvUnitRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvUnitRoute.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvUnitRoute.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvUnitRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.levTypeDataGridViewTextBoxColumn,
            this.bOFIDDataGridViewTextBoxColumn,
            this.lFIDDataGridViewTextBoxColumn,
            this.rHIDDataGridViewTextBoxColumn,
            this.casterIDDataGridViewTextBoxColumn});
            this.dvUnitRoute.DataSource = this.bsUnitRoute;
            this.dvUnitRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvUnitRoute.Location = new System.Drawing.Point(0, 0);
            this.dvUnitRoute.Name = "dvUnitRoute";
            this.dvUnitRoute.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvUnitRoute.RowTemplate.Height = 23;
            this.dvUnitRoute.Size = new System.Drawing.Size(1016, 608);
            this.dvUnitRoute.TabIndex = 0;
            this.dvUnitRoute.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvUnitRoute_DataError);
            // 
            // levTypeDataGridViewTextBoxColumn
            // 
            this.levTypeDataGridViewTextBoxColumn.DataPropertyName = "Lev_Type";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.levTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.levTypeDataGridViewTextBoxColumn.HeaderText = "优先级";
            this.levTypeDataGridViewTextBoxColumn.Name = "levTypeDataGridViewTextBoxColumn";
            this.levTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.DataSource = this.dsBOFID;
            this.bOFIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.bOFIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "转炉炉座";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bOFIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bOFIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsBOFID
            // 
            this.dsBOFID.AutoLoad = true;
            this.dsBOFID.AutoSubscribe = false;
            this.dsBOFID.DataSetName = "L3DataSet";
            this.dsBOFID.DeleteMethod = null;
            this.dsBOFID.InsertMethod = null;
            this.dsBOFID.L3DataAdapter = this.Adapter;
            this.dsBOFID.LoadEvent = "Click";
            this.dsBOFID.LoadTrigger = null;
            this.dsBOFID.RefreshValve = 1000;
            this.dsBOFID.SourceCommand = null;
            this.dsBOFID.SourceCondition = "CODE_GROUP = \'BOF\' ORDER BY CODE";
            this.dsBOFID.SourceMethod = "";
            this.dsBOFID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFID.SubscribeTarget = null;
            this.dsBOFID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFID});
            this.dsBOFID.UpdateEvent = "Click";
            this.dsBOFID.UpdateMethod = null;
            this.dsBOFID.UpdateTrigger = null;
            // 
            // schemadsBOFID
            // 
            this.schemadsBOFID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFIDL3DataTableCode,
            this.coldsBOFIDL3DataTableCode_Des});
            this.schemadsBOFID.TableName = "L3DataTable";
            // 
            // coldsBOFIDL3DataTableCode
            // 
            this.coldsBOFIDL3DataTableCode.Caption = "Code";
            this.coldsBOFIDL3DataTableCode.ColumnName = "Code";
            this.coldsBOFIDL3DataTableCode.Namespace = "";
            // 
            // coldsBOFIDL3DataTableCode_Des
            // 
            this.coldsBOFIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.Namespace = "";
            // 
            // lFIDDataGridViewTextBoxColumn
            // 
            this.lFIDDataGridViewTextBoxColumn.DataPropertyName = "LFID";
            this.lFIDDataGridViewTextBoxColumn.DataSource = this.dsLFID;
            this.lFIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.lFIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lFIDDataGridViewTextBoxColumn.HeaderText = "LF炉座";
            this.lFIDDataGridViewTextBoxColumn.Name = "lFIDDataGridViewTextBoxColumn";
            this.lFIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lFIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lFIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsLFID
            // 
            this.dsLFID.AutoLoad = true;
            this.dsLFID.AutoSubscribe = false;
            this.dsLFID.DataSetName = "L3DataSet";
            this.dsLFID.DeleteMethod = null;
            this.dsLFID.InsertMethod = null;
            this.dsLFID.L3DataAdapter = this.Adapter;
            this.dsLFID.LoadEvent = "Click";
            this.dsLFID.LoadTrigger = null;
            this.dsLFID.RefreshValve = 1000;
            this.dsLFID.SourceCommand = null;
            this.dsLFID.SourceCondition = "CODE_GROUP = \'LF_CHANGE\'  ORDER BY CODE";
            this.dsLFID.SourceMethod = "";
            this.dsLFID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLFID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLFID.SubscribeTarget = null;
            this.dsLFID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLFID});
            this.dsLFID.UpdateEvent = "Click";
            this.dsLFID.UpdateMethod = null;
            this.dsLFID.UpdateTrigger = null;
            // 
            // schemadsLFID
            // 
            this.schemadsLFID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLFIDL3DataTableCode,
            this.coldsLFIDL3DataTableCode_Des});
            this.schemadsLFID.TableName = "L3DataTable";
            // 
            // coldsLFIDL3DataTableCode
            // 
            this.coldsLFIDL3DataTableCode.Caption = "Code";
            this.coldsLFIDL3DataTableCode.ColumnName = "Code";
            this.coldsLFIDL3DataTableCode.Namespace = "";
            // 
            // coldsLFIDL3DataTableCode_Des
            // 
            this.coldsLFIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLFIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLFIDL3DataTableCode_Des.Namespace = "";
            // 
            // rHIDDataGridViewTextBoxColumn
            // 
            this.rHIDDataGridViewTextBoxColumn.DataPropertyName = "RHID";
            this.rHIDDataGridViewTextBoxColumn.DataSource = this.dsRHID;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.rHIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.rHIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.rHIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.rHIDDataGridViewTextBoxColumn.HeaderText = "RH炉座";
            this.rHIDDataGridViewTextBoxColumn.Name = "rHIDDataGridViewTextBoxColumn";
            this.rHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rHIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rHIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rHIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsRHID
            // 
            this.dsRHID.AutoLoad = true;
            this.dsRHID.AutoSubscribe = false;
            this.dsRHID.DataSetName = "L3DataSet";
            this.dsRHID.DeleteMethod = null;
            this.dsRHID.InsertMethod = null;
            this.dsRHID.L3DataAdapter = this.Adapter;
            this.dsRHID.LoadEvent = "Click";
            this.dsRHID.LoadTrigger = null;
            this.dsRHID.RefreshValve = 1000;
            this.dsRHID.SourceCommand = null;
            this.dsRHID.SourceCondition = "CODE_GROUP = \'RH_CHANGE\'  ORDER BY CODE";
            this.dsRHID.SourceMethod = "";
            this.dsRHID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRHID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRHID.SubscribeTarget = null;
            this.dsRHID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRHID});
            this.dsRHID.UpdateEvent = "Click";
            this.dsRHID.UpdateMethod = null;
            this.dsRHID.UpdateTrigger = null;
            // 
            // schemadsRHID
            // 
            this.schemadsRHID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRHIDL3DataTableCode,
            this.coldsRHIDL3DataTableCode_Des});
            this.schemadsRHID.TableName = "L3DataTable";
            // 
            // coldsRHIDL3DataTableCode
            // 
            this.coldsRHIDL3DataTableCode.Caption = "Code";
            this.coldsRHIDL3DataTableCode.ColumnName = "Code";
            this.coldsRHIDL3DataTableCode.Namespace = "";
            // 
            // coldsRHIDL3DataTableCode_Des
            // 
            this.coldsRHIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRHIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRHIDL3DataTableCode_Des.Namespace = "";
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.DataSource = this.dsCasterID;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.casterIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.casterIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.casterIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.casterIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.casterIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.casterIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsCasterID
            // 
            this.dsCasterID.AutoLoad = true;
            this.dsCasterID.AutoSubscribe = false;
            this.dsCasterID.DataSetName = "L3DataSet";
            this.dsCasterID.DeleteMethod = null;
            this.dsCasterID.InsertMethod = null;
            this.dsCasterID.L3DataAdapter = this.Adapter;
            this.dsCasterID.LoadEvent = "Click";
            this.dsCasterID.LoadTrigger = null;
            this.dsCasterID.RefreshValve = 1000;
            this.dsCasterID.SourceCommand = null;
            this.dsCasterID.SourceCondition = "CODE_GROUP = \'Caster\'  ORDER BY CODE";
            this.dsCasterID.SourceMethod = "";
            this.dsCasterID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCasterID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCasterID.SubscribeTarget = null;
            this.dsCasterID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCasterID});
            this.dsCasterID.UpdateEvent = "Click";
            this.dsCasterID.UpdateMethod = null;
            this.dsCasterID.UpdateTrigger = null;
            // 
            // schemadsCasterID
            // 
            this.schemadsCasterID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterIDL3DataTableCode,
            this.coldsCasterIDL3DataTableCode_Des});
            this.schemadsCasterID.TableName = "L3DataTable";
            // 
            // coldsCasterIDL3DataTableCode
            // 
            this.coldsCasterIDL3DataTableCode.Caption = "Code";
            this.coldsCasterIDL3DataTableCode.ColumnName = "Code";
            this.coldsCasterIDL3DataTableCode.Namespace = "";
            // 
            // coldsCasterIDL3DataTableCode_Des
            // 
            this.coldsCasterIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterIDL3DataTableCode_Des.Namespace = "";
            // 
            // UnitRouteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelUnitRoute);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnitRouteFrm";
            this.TabText = "工艺路径维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnitRouteFrm_FormClosing);
            this.Load += new System.EventHandler(this.UnitRouteFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelUnitRoute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvUnitRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRHID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRHID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource bsUnitRoute;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private HMIBase.HMIRootPanel hmiRootPanelUnitRoute;
        private System.Windows.Forms.DataGridView dvUnitRoute;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private AppSvrHMI.L3DataSet dsBOFID;
        private System.Data.DataTable schemadsBOFID;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsLFID;
        private System.Data.DataTable schemadsLFID;
        private System.Data.DataColumn coldsLFIDL3DataTableCode;
        private System.Data.DataColumn coldsLFIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsRHID;
        private System.Data.DataTable schemadsRHID;
        private System.Data.DataColumn coldsRHIDL3DataTableCode;
        private System.Data.DataColumn coldsRHIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsUnitRoute;
        private System.Data.DataTable schemadsUnitRoute;
        private System.Data.DataColumn coldsUnitRouteL3DataTableGUID;
        private System.Data.DataColumn coldsUnitRouteL3DataTableName;
        private System.Data.DataColumn coldsUnitRouteL3DataTableLev_Type;
        private System.Data.DataColumn coldsUnitRouteL3DataTableBOFID;
        private System.Data.DataColumn coldsUnitRouteL3DataTableLFID;
        private System.Data.DataColumn coldsUnitRouteL3DataTableRHID;
        private System.Data.DataColumn coldsUnitRouteL3DataTableCasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn levTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn casterIDDataGridViewTextBoxColumn;
    }
}