namespace QualityMag.QualityStandard
{
    partial class TransTimeStdMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransTimeStdMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsTransTime = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransTime = new AppSvrHMI.L3DataSet();
            this.schemadsTransTime = new System.Data.DataTable();
            this.coldsTransTimeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTransTimeL3DataTableName = new System.Data.DataColumn();
            this.coldsTransTimeL3DataTableStart_Unit = new System.Data.DataColumn();
            this.coldsTransTimeL3DataTableEnd_Unit = new System.Data.DataColumn();
            this.coldsTransTimeL3DataTableTransport_Time = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbEndUnit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbStartUnit = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtStartUnit = new System.Windows.Forms.ToolStripTextBox();
            this.txtEndUnit = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanelTransTime = new HMIBase.HMIRootPanel();
            this.dvTransTime = new System.Windows.Forms.DataGridView();
            this.startUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitName = new AppSvrHMI.L3DataSet();
            this.schemadsUnitName = new System.Data.DataTable();
            this.coldsUnitNameL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.endUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.transportTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTransTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelTransTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTransTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitName)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnTransTimeStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnTransTimeStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnTransTimeStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnTransTimeStd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnTransTimeStd");
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
            // bsTransTime
            // 
            this.bsTransTime.DataMember = "L3DataTable";
            this.bsTransTime.DataSource = this.dsTransTime;
            // 
            // dsTransTime
            // 
            this.dsTransTime.AutoLoad = true;
            this.dsTransTime.AutoSubscribe = false;
            this.dsTransTime.DataSetName = "L3DataSet";
            this.dsTransTime.DeleteMethod = null;
            this.dsTransTime.InsertMethod = null;
            this.dsTransTime.L3DataAdapter = this.Adapter;
            this.dsTransTime.LoadEvent = "Click";
            this.dsTransTime.LoadTrigger = null;
            this.dsTransTime.RefreshValve = 1000;
            this.dsTransTime.SourceCommand = null;
            this.dsTransTime.SourceCondition = "1=2";
            this.dsTransTime.SourceMethod = "";
            this.dsTransTime.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTransTime.SourceURI = "XGMESLogic\\QualityMag\\CQA_Unit_Trans_Time";
            this.dsTransTime.SubscribeTarget = null;
            this.dsTransTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTransTime});
            this.dsTransTime.UpdateEvent = "Click";
            this.dsTransTime.UpdateMethod = null;
            this.dsTransTime.UpdateTrigger = null;
            // 
            // schemadsTransTime
            // 
            this.schemadsTransTime.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTransTimeL3DataTableGUID,
            this.coldsTransTimeL3DataTableName,
            this.coldsTransTimeL3DataTableStart_Unit,
            this.coldsTransTimeL3DataTableEnd_Unit,
            this.coldsTransTimeL3DataTableTransport_Time});
            this.schemadsTransTime.TableName = "L3DataTable";
            // 
            // coldsTransTimeL3DataTableGUID
            // 
            this.coldsTransTimeL3DataTableGUID.Caption = "GUID";
            this.coldsTransTimeL3DataTableGUID.ColumnName = "GUID";
            this.coldsTransTimeL3DataTableGUID.Namespace = "";
            // 
            // coldsTransTimeL3DataTableName
            // 
            this.coldsTransTimeL3DataTableName.Caption = "Name";
            this.coldsTransTimeL3DataTableName.ColumnName = "Name";
            this.coldsTransTimeL3DataTableName.Namespace = "";
            // 
            // coldsTransTimeL3DataTableStart_Unit
            // 
            this.coldsTransTimeL3DataTableStart_Unit.Caption = "Start_Unit";
            this.coldsTransTimeL3DataTableStart_Unit.ColumnName = "Start_Unit";
            this.coldsTransTimeL3DataTableStart_Unit.Namespace = "";
            // 
            // coldsTransTimeL3DataTableEnd_Unit
            // 
            this.coldsTransTimeL3DataTableEnd_Unit.Caption = "End_Unit";
            this.coldsTransTimeL3DataTableEnd_Unit.ColumnName = "End_Unit";
            this.coldsTransTimeL3DataTableEnd_Unit.Namespace = "";
            // 
            // coldsTransTimeL3DataTableTransport_Time
            // 
            this.coldsTransTimeL3DataTableTransport_Time.Caption = "Transport_Time";
            this.coldsTransTimeL3DataTableTransport_Time.ColumnName = "Transport_Time";
            this.coldsTransTimeL3DataTableTransport_Time.DataType = typeof(int);
            this.coldsTransTimeL3DataTableTransport_Time.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsTransTime;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btnQuery,
            this.toolStripLabel6,
            this.cmbEndUnit,
            this.toolStripLabel1,
            this.cmbStartUnit,
            this.toolStripLabel7,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripButton4,
            this.bindingNavigatorSeparator2,
            this.txtStartUnit,
            this.txtEndUnit});
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
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel6.Text = " ";
            // 
            // cmbEndUnit
            // 
            this.cmbEndUnit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbEndUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEndUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEndUnit.Name = "cmbEndUnit";
            this.cmbEndUnit.Size = new System.Drawing.Size(121, 25);
            this.cmbEndUnit.SelectedIndexChanged += new System.EventHandler(this.cmbEndUnit_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "结束工位:";
            // 
            // cmbStartUnit
            // 
            this.cmbStartUnit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbStartUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartUnit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStartUnit.Name = "cmbStartUnit";
            this.cmbStartUnit.Size = new System.Drawing.Size(121, 25);
            this.cmbStartUnit.SelectedIndexChanged += new System.EventHandler(this.cmbStartUnit_SelectedIndexChanged);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "起始工位:";
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
            // txtStartUnit
            // 
            this.txtStartUnit.Name = "txtStartUnit";
            this.txtStartUnit.Size = new System.Drawing.Size(100, 25);
            this.txtStartUnit.Visible = false;
            // 
            // txtEndUnit
            // 
            this.txtEndUnit.Name = "txtEndUnit";
            this.txtEndUnit.Size = new System.Drawing.Size(100, 25);
            this.txtEndUnit.Visible = false;
            // 
            // hmiRootPanelTransTime
            // 
            this.hmiRootPanelTransTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelTransTime.Controls.Add(this.dvTransTime);
            this.hmiRootPanelTransTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelTransTime.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelTransTime.Name = "hmiRootPanelTransTime";
            this.hmiRootPanelTransTime.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelTransTime.TabIndex = 18;
            // 
            // dvTransTime
            // 
            this.dvTransTime.AllowUserToAddRows = false;
            this.dvTransTime.AllowUserToDeleteRows = false;
            this.dvTransTime.AutoGenerateColumns = false;
            this.dvTransTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvTransTime.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvTransTime.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTransTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startUnitDataGridViewTextBoxColumn,
            this.endUnitDataGridViewTextBoxColumn,
            this.transportTimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvTransTime.DataSource = this.bsTransTime;
            this.dvTransTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTransTime.Location = new System.Drawing.Point(0, 0);
            this.dvTransTime.Name = "dvTransTime";
            this.dvTransTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dvTransTime.RowTemplate.Height = 23;
            this.dvTransTime.Size = new System.Drawing.Size(1016, 608);
            this.dvTransTime.TabIndex = 0;
            this.dvTransTime.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvTransTime_DataError);
            // 
            // startUnitDataGridViewTextBoxColumn
            // 
            this.startUnitDataGridViewTextBoxColumn.DataPropertyName = "Start_Unit";
            this.startUnitDataGridViewTextBoxColumn.DataSource = this.dsUnitName;
            this.startUnitDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.startUnitDataGridViewTextBoxColumn.HeaderText = "起始工位";
            this.startUnitDataGridViewTextBoxColumn.Name = "startUnitDataGridViewTextBoxColumn";
            this.startUnitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startUnitDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.startUnitDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsUnitName
            // 
            this.dsUnitName.AutoLoad = true;
            this.dsUnitName.AutoSubscribe = false;
            this.dsUnitName.DataSetName = "L3DataSet";
            this.dsUnitName.DeleteMethod = null;
            this.dsUnitName.InsertMethod = null;
            this.dsUnitName.L3DataAdapter = this.Adapter;
            this.dsUnitName.LoadEvent = "Click";
            this.dsUnitName.LoadTrigger = null;
            this.dsUnitName.RefreshValve = 1000;
            this.dsUnitName.SourceCommand = null;
            this.dsUnitName.SourceCondition = "(CODE_GROUP = \'BOF\' or CODE_GROUP = \'Caster\' or CODE_GROUP = \'LF\' or CODE_GROUP =" +
                " \'RH\') and code is not null order by Code";
            this.dsUnitName.SourceMethod = "";
            this.dsUnitName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitName.SubscribeTarget = null;
            this.dsUnitName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitName});
            this.dsUnitName.UpdateEvent = "Click";
            this.dsUnitName.UpdateMethod = null;
            this.dsUnitName.UpdateTrigger = null;
            // 
            // schemadsUnitName
            // 
            this.schemadsUnitName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitNameL3DataTableCode,
            this.coldsUnitNameL3DataTableCode_Des});
            this.schemadsUnitName.TableName = "L3DataTable";
            // 
            // coldsUnitNameL3DataTableCode
            // 
            this.coldsUnitNameL3DataTableCode.Caption = "Code";
            this.coldsUnitNameL3DataTableCode.ColumnName = "Code";
            this.coldsUnitNameL3DataTableCode.Namespace = "";
            // 
            // coldsUnitNameL3DataTableCode_Des
            // 
            this.coldsUnitNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitNameL3DataTableCode_Des.Namespace = "";
            // 
            // endUnitDataGridViewTextBoxColumn
            // 
            this.endUnitDataGridViewTextBoxColumn.DataPropertyName = "End_Unit";
            this.endUnitDataGridViewTextBoxColumn.DataSource = this.dsUnitName;
            this.endUnitDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.endUnitDataGridViewTextBoxColumn.HeaderText = "结束工位";
            this.endUnitDataGridViewTextBoxColumn.Name = "endUnitDataGridViewTextBoxColumn";
            this.endUnitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endUnitDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.endUnitDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // transportTimeDataGridViewTextBoxColumn
            // 
            this.transportTimeDataGridViewTextBoxColumn.DataPropertyName = "Transport_Time";
            this.transportTimeDataGridViewTextBoxColumn.HeaderText = "运输时间";
            this.transportTimeDataGridViewTextBoxColumn.Name = "transportTimeDataGridViewTextBoxColumn";
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
            // TransTimeStdMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelTransTime);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TransTimeStdMaintenFrm";
            this.TabText = "工序间运输时间标准维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransTimeStdMaintenFrm_FormClosing);
            this.Load += new System.EventHandler(this.TransTimeStdMaintenFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTransTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelTransTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTransTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitName)).EndInit();
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
        private System.Windows.Forms.BindingSource bsTransTime;
        private AppSvrHMI.L3DataSet dsTransTime;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbStartUnit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private HMIBase.HMIRootPanel hmiRootPanelTransTime;
        private System.Windows.Forms.DataGridView dvTransTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cmbEndUnit;
        private AppSvrHMI.L3DataSet dsUnitName;
        private System.Data.DataTable schemadsTransTime;
        private System.Data.DataColumn coldsTransTimeL3DataTableGUID;
        private System.Data.DataColumn coldsTransTimeL3DataTableName;
        private System.Data.DataColumn coldsTransTimeL3DataTableStart_Unit;
        private System.Data.DataColumn coldsTransTimeL3DataTableEnd_Unit;
        private System.Data.DataColumn coldsTransTimeL3DataTableTransport_Time;
        private System.Data.DataTable schemadsUnitName;
        private System.Data.DataColumn coldsUnitNameL3DataTableCode;
        private System.Data.DataColumn coldsUnitNameL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripTextBox txtStartUnit;
        private System.Windows.Forms.ToolStripTextBox txtEndUnit;
        private System.Windows.Forms.DataGridViewComboBoxColumn startUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn endUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
    }
}