namespace BOFL2Mag
{
    partial class ModelGradeIndexFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelGradeIndexFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsModelGradeIndexRelation = new System.Windows.Forms.BindingSource(this.components);
            this.dsModelGradeIndexRelation = new AppSvrHMI.L3DataSet();
            this.schemadsModelGradeIndexRelation = new System.Data.DataTable();
            this.coldsModelGradeIndexRelationL3DataTableModelGradeIndex = new System.Data.DataColumn();
            this.coldsModelGradeIndexRelationL3DataTableUse_Flag = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbModelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hmiRootPanelProcTime = new HMIBase.HMIRootPanel();
            this.dvModelGradeIndexRelation = new System.Windows.Forms.DataGridView();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ModelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUse_Flag = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsModelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsModelGradeIndex = new System.Data.DataTable();
            this.coldsModelGradeIndexL3DataTableGUID = new System.Data.DataColumn();
            this.coldsModelGradeIndexL3DataTableModelGradeIndex = new System.Data.DataColumn();
            this.dsFlag = new AppSvrHMI.L3DataSet();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelProcTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvModelGradeIndexRelation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnBOFStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnBOFStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnBOFStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnBOFStd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnBOFStd");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "btnBOFStd");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
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
            this.btnCancel,
            this.toolStripSeparator5});
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
            // bsModelGradeIndexRelation
            // 
            this.bsModelGradeIndexRelation.DataMember = "L3DataTable";
            this.bsModelGradeIndexRelation.DataSource = this.dsModelGradeIndexRelation;
            // 
            // dsModelGradeIndexRelation
            // 
            this.dsModelGradeIndexRelation.AutoLoad = true;
            this.dsModelGradeIndexRelation.AutoSubscribe = false;
            this.dsModelGradeIndexRelation.DataSetName = "L3DataSet";
            this.dsModelGradeIndexRelation.DeleteMethod = null;
            this.dsModelGradeIndexRelation.InsertMethod = null;
            this.dsModelGradeIndexRelation.L3DataAdapter = this.Adapter;
            this.dsModelGradeIndexRelation.LoadEvent = "Click";
            this.dsModelGradeIndexRelation.LoadTrigger = null;
            this.dsModelGradeIndexRelation.RefreshValve = 1000;
            this.dsModelGradeIndexRelation.SourceCommand = null;
            this.dsModelGradeIndexRelation.SourceCondition = "1=2";
            this.dsModelGradeIndexRelation.SourceMethod = "";
            this.dsModelGradeIndexRelation.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsModelGradeIndexRelation.SourceURI = "XGMESLogic\\BOFL2Mag\\BOFL2_ModelGradeIndex";
            this.dsModelGradeIndexRelation.SubscribeTarget = null;
            this.dsModelGradeIndexRelation.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsModelGradeIndexRelation});
            this.dsModelGradeIndexRelation.UpdateEvent = "Click";
            this.dsModelGradeIndexRelation.UpdateMethod = null;
            this.dsModelGradeIndexRelation.UpdateTrigger = null;
            // 
            // schemadsModelGradeIndexRelation
            // 
            this.schemadsModelGradeIndexRelation.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsModelGradeIndexRelationL3DataTableModelGradeIndex,
            this.coldsModelGradeIndexRelationL3DataTableUse_Flag});
            this.schemadsModelGradeIndexRelation.TableName = "L3DataTable";
            // 
            // coldsModelGradeIndexRelationL3DataTableModelGradeIndex
            // 
            this.coldsModelGradeIndexRelationL3DataTableModelGradeIndex.Caption = "ModelGradeIndex";
            this.coldsModelGradeIndexRelationL3DataTableModelGradeIndex.ColumnName = "ModelGradeIndex";
            this.coldsModelGradeIndexRelationL3DataTableModelGradeIndex.Namespace = "";
            // 
            // coldsModelGradeIndexRelationL3DataTableUse_Flag
            // 
            this.coldsModelGradeIndexRelationL3DataTableUse_Flag.Caption = "Use_Flag";
            this.coldsModelGradeIndexRelationL3DataTableUse_Flag.ColumnName = "Use_Flag";
            this.coldsModelGradeIndexRelationL3DataTableUse_Flag.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsModelGradeIndexRelation;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btnQuery,
            this.toolStripLabel6,
            this.cmbModelGradeIndex,
            this.toolStripLabel7,
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
            // cmbModelGradeIndex
            // 
            this.cmbModelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbModelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbModelGradeIndex.Name = "cmbModelGradeIndex";
            this.cmbModelGradeIndex.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "模型名称:";
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
            // hmiRootPanelProcTime
            // 
            this.hmiRootPanelProcTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelProcTime.Controls.Add(this.dvModelGradeIndexRelation);
            this.hmiRootPanelProcTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelProcTime.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelProcTime.Name = "hmiRootPanelProcTime";
            this.hmiRootPanelProcTime.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelProcTime.TabIndex = 18;
            // 
            // dvModelGradeIndexRelation
            // 
            this.dvModelGradeIndexRelation.AllowUserToAddRows = false;
            this.dvModelGradeIndexRelation.AllowUserToDeleteRows = false;
            this.dvModelGradeIndexRelation.AutoGenerateColumns = false;
            this.dvModelGradeIndexRelation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvModelGradeIndexRelation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.ModelGradeIndexDataGridViewTextBoxColumn,
            this.cmbUse_Flag});
            this.dvModelGradeIndexRelation.DataSource = this.bsModelGradeIndexRelation;
            this.dvModelGradeIndexRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvModelGradeIndexRelation.Location = new System.Drawing.Point(0, 0);
            this.dvModelGradeIndexRelation.MultiSelect = false;
            this.dvModelGradeIndexRelation.Name = "dvModelGradeIndexRelation";
            this.dvModelGradeIndexRelation.RowTemplate.Height = 23;
            this.dvModelGradeIndexRelation.Size = new System.Drawing.Size(1016, 608);
            this.dvModelGradeIndexRelation.TabIndex = 0;
           
            // 
            // CheckFlag
            // 
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Visible = false;
            this.CheckFlag.Width = 20;
            // 
            // ModelGradeIndexDataGridViewTextBoxColumn
            // 
            this.ModelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "ModelGradeIndex";
            this.ModelGradeIndexDataGridViewTextBoxColumn.HeaderText = "模型名称";
            this.ModelGradeIndexDataGridViewTextBoxColumn.Name = "ModelGradeIndexDataGridViewTextBoxColumn";
            // 
            // cmbUse_Flag
            // 
            this.cmbUse_Flag.DataPropertyName = "Use_Flag";
            this.cmbUse_Flag.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cmbUse_Flag.HeaderText = "使用标志";
            this.cmbUse_Flag.Name = "cmbUse_Flag";
            this.cmbUse_Flag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbUse_Flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dsModelGradeIndex
            // 
            this.dsModelGradeIndex.AutoLoad = true;
            this.dsModelGradeIndex.AutoSubscribe = false;
            this.dsModelGradeIndex.DataSetName = "L3DataSet";
            this.dsModelGradeIndex.DeleteMethod = null;
            this.dsModelGradeIndex.InsertMethod = null;
            this.dsModelGradeIndex.L3DataAdapter = this.Adapter;
            this.dsModelGradeIndex.LoadEvent = "Click";
            this.dsModelGradeIndex.LoadTrigger = null;
            this.dsModelGradeIndex.RefreshValve = 1000;
            this.dsModelGradeIndex.SourceCommand = null;
            this.dsModelGradeIndex.SourceCondition = "modelgradeindex is not null order by ModelGradeIndex";
            this.dsModelGradeIndex.SourceMethod = "";
            this.dsModelGradeIndex.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsModelGradeIndex.SourceURI = "XGMESLogic\\BOFL2Mag\\BOFL2_ModelGradeIndex";
            this.dsModelGradeIndex.SubscribeTarget = null;
            this.dsModelGradeIndex.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsModelGradeIndex});
            this.dsModelGradeIndex.UpdateEvent = "Click";
            this.dsModelGradeIndex.UpdateMethod = null;
            this.dsModelGradeIndex.UpdateTrigger = null;
            // 
            // schemadsModelGradeIndex
            // 
            this.schemadsModelGradeIndex.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsModelGradeIndexL3DataTableGUID,
            this.coldsModelGradeIndexL3DataTableModelGradeIndex});
            this.schemadsModelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsModelGradeIndexL3DataTableGUID
            // 
            this.coldsModelGradeIndexL3DataTableGUID.Caption = "GUID";
            this.coldsModelGradeIndexL3DataTableGUID.ColumnName = "GUID";
            this.coldsModelGradeIndexL3DataTableGUID.Namespace = "";
            // 
            // coldsModelGradeIndexL3DataTableModelGradeIndex
            // 
            this.coldsModelGradeIndexL3DataTableModelGradeIndex.Caption = "ModelGradeIndex";
            this.coldsModelGradeIndexL3DataTableModelGradeIndex.ColumnName = "ModelGradeIndex";
            this.coldsModelGradeIndexL3DataTableModelGradeIndex.Namespace = "";
            // 
            // dsFlag
            // 
            this.dsFlag.AutoLoad = true;
            this.dsFlag.AutoSubscribe = false;
            this.dsFlag.DataSetName = "L3DataSet";
            this.dsFlag.DeleteMethod = null;
            this.dsFlag.InsertMethod = null;
            this.dsFlag.L3DataAdapter = this.Adapter;
            this.dsFlag.LoadEvent = "Click";
            this.dsFlag.LoadTrigger = null;
            this.dsFlag.RefreshValve = 1000;
            this.dsFlag.SourceCommand = null;
            this.dsFlag.SourceCondition = "";
            this.dsFlag.SourceMethod = "";
            this.dsFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFlag.SourceURI = "";
            this.dsFlag.SubscribeTarget = null;
            this.dsFlag.UpdateEvent = "Click";
            this.dsFlag.UpdateMethod = null;
            this.dsFlag.UpdateTrigger = null;
            // 
            // ModelGradeIndexFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelProcTime);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModelGradeIndexFrm";
            this.TabText = "模型名称维护";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.ModelGradeIndexFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelGradeIndexFrm_FormClosing);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsModelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelProcTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvModelGradeIndexRelation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsModelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).EndInit();
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
        private System.Windows.Forms.BindingSource bsModelGradeIndexRelation;
        private AppSvrHMI.L3DataSet dsModelGradeIndexRelation;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbModelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private HMIBase.HMIRootPanel hmiRootPanelProcTime;
        private System.Windows.Forms.DataGridView dvModelGradeIndexRelation;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Data.DataTable schemadsModelGradeIndexRelation;
        private System.Data.DataColumn coldsModelGradeIndexRelationL3DataTableModelGradeIndex;
        private AppSvrHMI.L3DataSet dsModelGradeIndex;
        private System.Data.DataTable schemadsModelGradeIndex;
        private System.Data.DataColumn coldsModelGradeIndexL3DataTableGUID;
        private System.Data.DataColumn coldsModelGradeIndexL3DataTableModelGradeIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private AppSvrHMI.L3DataSet dsFlag;
        private System.Data.DataColumn coldsModelGradeIndexRelationL3DataTableUse_Flag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbUse_Flag;
    }
}