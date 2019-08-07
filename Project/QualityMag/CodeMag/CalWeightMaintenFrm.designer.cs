namespace QualityMag.CodeMag
{
    partial class CalWeightMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalWeightMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsCalWeightMainten = new System.Windows.Forms.BindingSource(this.components);
            this.dsCalWeightMainten = new AppSvrHMI.L3DataSet();
            this.schemadsCalWeightMainten = new System.Data.DataTable();
            this.coldsCalWeightMaintenL3DataTableLength = new System.Data.DataColumn();
            this.coldsCalWeightMaintenL3DataTableWeight = new System.Data.DataColumn();
            this.coldsCalWeightMaintenL3DataTableGUID = new System.Data.DataColumn();
            this.coldsCalWeightMaintenL3DataTableName = new System.Data.DataColumn();
            this.coldsCalWeightMaintenL3DataTableSpec = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.txtLength = new System.Windows.Forms.ToolStripTextBox();
            this.lblLength = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanelCalWeightMainten = new HMIBase.HMIRootPanel();
            this.dvCalWeightMainten = new System.Windows.Forms.DataGridView();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsMainL3DataTableLength = new System.Data.DataColumn();
            this.coldsMainL3DataTableWeight = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpec = new System.Data.DataColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalWeightMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalWeightMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCalWeightMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelCalWeightMainten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCalWeightMainten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnWeightStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnWeightStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnWeightStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOK
            // 
            this.Adapter.SetAccessRight(this.btnOK, "btnWeightStd");
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 40);
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnWeightStd");
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
            this.btnOK,
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
            // bsCalWeightMainten
            // 
            this.bsCalWeightMainten.DataMember = "L3DataTable";
            this.bsCalWeightMainten.DataSource = this.dsCalWeightMainten;
            // 
            // dsCalWeightMainten
            // 
            this.dsCalWeightMainten.AutoSubscribe = false;
            this.dsCalWeightMainten.DataSetName = "L3DataSet";
            this.dsCalWeightMainten.DeleteMethod = null;
            this.dsCalWeightMainten.InsertMethod = null;
            this.dsCalWeightMainten.L3DataAdapter = this.Adapter;
            this.dsCalWeightMainten.LoadEvent = "Click";
            this.dsCalWeightMainten.LoadTrigger = null;
            this.dsCalWeightMainten.RefreshValve = 1000;
            this.dsCalWeightMainten.SourceCommand = null;
            this.dsCalWeightMainten.SourceCondition = "1=2";
            this.dsCalWeightMainten.SourceMethod = "";
            this.dsCalWeightMainten.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCalWeightMainten.SourceURI = "XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std";
            this.dsCalWeightMainten.SubscribeTarget = null;
            this.dsCalWeightMainten.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCalWeightMainten});
            this.dsCalWeightMainten.UpdateEvent = "Click";
            this.dsCalWeightMainten.UpdateMethod = null;
            this.dsCalWeightMainten.UpdateTrigger = null;
            // 
            // schemadsCalWeightMainten
            // 
            this.schemadsCalWeightMainten.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCalWeightMaintenL3DataTableLength,
            this.coldsCalWeightMaintenL3DataTableWeight,
            this.coldsCalWeightMaintenL3DataTableGUID,
            this.coldsCalWeightMaintenL3DataTableName,
            this.coldsCalWeightMaintenL3DataTableSpec});
            this.schemadsCalWeightMainten.TableName = "L3DataTable";
            // 
            // coldsCalWeightMaintenL3DataTableLength
            // 
            this.coldsCalWeightMaintenL3DataTableLength.Caption = "Length";
            this.coldsCalWeightMaintenL3DataTableLength.ColumnName = "Length";
            this.coldsCalWeightMaintenL3DataTableLength.DataType = typeof(int);
            this.coldsCalWeightMaintenL3DataTableLength.Namespace = "";
            // 
            // coldsCalWeightMaintenL3DataTableWeight
            // 
            this.coldsCalWeightMaintenL3DataTableWeight.Caption = "Weight";
            this.coldsCalWeightMaintenL3DataTableWeight.ColumnName = "Weight";
            this.coldsCalWeightMaintenL3DataTableWeight.DataType = typeof(double);
            this.coldsCalWeightMaintenL3DataTableWeight.Namespace = "";
            // 
            // coldsCalWeightMaintenL3DataTableGUID
            // 
            this.coldsCalWeightMaintenL3DataTableGUID.Caption = "GUID";
            this.coldsCalWeightMaintenL3DataTableGUID.ColumnName = "GUID";
            this.coldsCalWeightMaintenL3DataTableGUID.Namespace = "";
            // 
            // coldsCalWeightMaintenL3DataTableName
            // 
            this.coldsCalWeightMaintenL3DataTableName.Caption = "Name";
            this.coldsCalWeightMaintenL3DataTableName.ColumnName = "Name";
            this.coldsCalWeightMaintenL3DataTableName.Namespace = "";
            // 
            // coldsCalWeightMaintenL3DataTableSpec
            // 
            this.coldsCalWeightMaintenL3DataTableSpec.Caption = "Spec";
            this.coldsCalWeightMaintenL3DataTableSpec.ColumnName = "Spec";
            this.coldsCalWeightMaintenL3DataTableSpec.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsCalWeightMainten;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.btnQuery,
            this.toolStripLabel3,
            this.txtLength,
            this.lblLength});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1020, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.toolStripLabel2.Text = "　";
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel3.Text = " ";
            // 
            // txtLength
            // 
            this.txtLength.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 25);
            // 
            // lblLength
            // 
            this.lblLength.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(59, 22);
            this.lblLength.Text = "定尺长度:";
            // 
            // hmiRootPanelCalWeightMainten
            // 
            this.hmiRootPanelCalWeightMainten.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelCalWeightMainten.Controls.Add(this.dvCalWeightMainten);
            this.hmiRootPanelCalWeightMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelCalWeightMainten.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelCalWeightMainten.Name = "hmiRootPanelCalWeightMainten";
            this.hmiRootPanelCalWeightMainten.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelCalWeightMainten.TabIndex = 17;
            // 
            // dvCalWeightMainten
            // 
            this.dvCalWeightMainten.AllowUserToAddRows = false;
            this.dvCalWeightMainten.AutoGenerateColumns = false;
            this.dvCalWeightMainten.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCalWeightMainten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCalWeightMainten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectIDDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.specDataGridViewTextBoxColumn});
            this.dvCalWeightMainten.DataSource = this.bsMain;
            this.dvCalWeightMainten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCalWeightMainten.Location = new System.Drawing.Point(0, 0);
            this.dvCalWeightMainten.Name = "dvCalWeightMainten";
            this.dvCalWeightMainten.RowTemplate.Height = 23;
            this.dvCalWeightMainten.Size = new System.Drawing.Size(1016, 608);
            this.dvCalWeightMainten.TabIndex = 0;
            // 
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "主键";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "定尺[mm]";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "重量[t]";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // specDataGridViewTextBoxColumn
            // 
            this.specDataGridViewTextBoxColumn.DataPropertyName = "Spec";
            this.specDataGridViewTextBoxColumn.HeaderText = "规格[mm*mm]";
            this.specDataGridViewTextBoxColumn.Name = "specDataGridViewTextBoxColumn";
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "1=2";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\QualityMag\\CQA_Cal_Weight_Std";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableObjectID,
            this.coldsMainL3DataTableSteelGrade,
            this.coldsMainL3DataTableLength,
            this.coldsMainL3DataTableWeight,
            this.coldsMainL3DataTableSpec});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableObjectID
            // 
            this.coldsMainL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMainL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMainL3DataTableObjectID.Namespace = "";
            // 
            // coldsMainL3DataTableSteelGrade
            // 
            this.coldsMainL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsMainL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsMainL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsMainL3DataTableLength
            // 
            this.coldsMainL3DataTableLength.Caption = "Length";
            this.coldsMainL3DataTableLength.ColumnName = "Length";
            this.coldsMainL3DataTableLength.DataType = typeof(int);
            this.coldsMainL3DataTableLength.Namespace = "";
            // 
            // coldsMainL3DataTableWeight
            // 
            this.coldsMainL3DataTableWeight.Caption = "Weight";
            this.coldsMainL3DataTableWeight.ColumnName = "Weight";
            this.coldsMainL3DataTableWeight.DataType = typeof(double);
            this.coldsMainL3DataTableWeight.Namespace = "";
            // 
            // coldsMainL3DataTableSpec
            // 
            this.coldsMainL3DataTableSpec.Caption = "Spec";
            this.coldsMainL3DataTableSpec.ColumnName = "Spec";
            this.coldsMainL3DataTableSpec.Namespace = "";
            // 
            // CalWeightMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelCalWeightMainten);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalWeightMaintenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "铸坯重量长度关系维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalWeightMaintenFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCalWeightMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalWeightMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCalWeightMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelCalWeightMainten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCalWeightMainten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingSource bsCalWeightMainten;
        private AppSvrHMI.L3DataSet dsCalWeightMainten;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblLength;
        private HMIBase.HMIRootPanel hmiRootPanelCalWeightMainten;
        private System.Windows.Forms.DataGridView dvCalWeightMainten;
        private System.Windows.Forms.ToolStripTextBox txtLength;
        private System.Data.DataTable schemadsCalWeightMainten;
        private System.Data.DataColumn coldsCalWeightMaintenL3DataTableLength;
        private System.Data.DataColumn coldsCalWeightMaintenL3DataTableWeight;
        private System.Data.DataColumn coldsCalWeightMaintenL3DataTableGUID;
        private System.Data.DataColumn coldsCalWeightMaintenL3DataTableName;
        private System.Data.DataColumn coldsCalWeightMaintenL3DataTableSpec;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableObjectID;
        private System.Data.DataColumn coldsMainL3DataTableSteelGrade;
        private System.Data.DataColumn coldsMainL3DataTableLength;
        private System.Data.DataColumn coldsMainL3DataTableWeight;
        private System.Data.DataColumn coldsMainL3DataTableSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsMain;
    }
}