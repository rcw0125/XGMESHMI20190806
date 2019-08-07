namespace QualityMag.QualityStandard
{
    partial class ProcTimeStdMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcTimeStdMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsProcTime = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcTime = new AppSvrHMI.L3DataSet();
            this.schemadsProcTime = new System.Data.DataTable();
            this.coldsProcTimeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableName = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableBOF_Proc_Time = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableLF_Proc_Time = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableRH_Proc_Time = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableCaster_Proc_Time = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableTapped_Proc_Time = new System.Data.DataColumn();
            this.coldsProcTimeL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanelProcTime = new HMIBase.HMIRootPanel();
            this.dvProcTime = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFProcTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFProcTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHProcTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterProcTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tappedProcTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelProcTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProcTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnUnitPoecessTimeStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnUnitPoecessTimeStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnUnitPoecessTimeStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnUnitPoecessTimeStd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnUnitPoecessTimeStd");
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
            // bsProcTime
            // 
            this.bsProcTime.DataMember = "L3DataTable";
            this.bsProcTime.DataSource = this.dsProcTime;
            // 
            // dsProcTime
            // 
            this.dsProcTime.AutoSubscribe = false;
            this.dsProcTime.DataSetName = "L3DataSet";
            this.dsProcTime.DeleteMethod = null;
            this.dsProcTime.InsertMethod = null;
            this.dsProcTime.L3DataAdapter = this.Adapter;
            this.dsProcTime.LoadEvent = "Click";
            this.dsProcTime.LoadTrigger = null;
            this.dsProcTime.RefreshValve = 1000;
            this.dsProcTime.SourceCommand = null;
            this.dsProcTime.SourceCondition = "1=2";
            this.dsProcTime.SourceMethod = "";
            this.dsProcTime.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcTime.SourceURI = "XGMESLogic\\QualityMag\\CQA_Unit_Proc_Time";
            this.dsProcTime.SubscribeTarget = null;
            this.dsProcTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcTime});
            this.dsProcTime.UpdateEvent = "Click";
            this.dsProcTime.UpdateMethod = null;
            this.dsProcTime.UpdateTrigger = null;
            // 
            // schemadsProcTime
            // 
            this.schemadsProcTime.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcTimeL3DataTableGUID,
            this.coldsProcTimeL3DataTableName,
            this.coldsProcTimeL3DataTableSteelGradeIndex,
            this.coldsProcTimeL3DataTableBOF_Proc_Time,
            this.coldsProcTimeL3DataTableLF_Proc_Time,
            this.coldsProcTimeL3DataTableRH_Proc_Time,
            this.coldsProcTimeL3DataTableCaster_Proc_Time,
            this.coldsProcTimeL3DataTableTapped_Proc_Time,
            this.coldsProcTimeL3DataTableCheckFlag});
            this.schemadsProcTime.TableName = "L3DataTable";
            // 
            // coldsProcTimeL3DataTableGUID
            // 
            this.coldsProcTimeL3DataTableGUID.Caption = "GUID";
            this.coldsProcTimeL3DataTableGUID.ColumnName = "GUID";
            this.coldsProcTimeL3DataTableGUID.Namespace = "";
            // 
            // coldsProcTimeL3DataTableName
            // 
            this.coldsProcTimeL3DataTableName.Caption = "Name";
            this.coldsProcTimeL3DataTableName.ColumnName = "Name";
            this.coldsProcTimeL3DataTableName.Namespace = "";
            // 
            // coldsProcTimeL3DataTableSteelGradeIndex
            // 
            this.coldsProcTimeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsProcTimeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsProcTimeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsProcTimeL3DataTableBOF_Proc_Time
            // 
            this.coldsProcTimeL3DataTableBOF_Proc_Time.Caption = "BOF_Proc_Time";
            this.coldsProcTimeL3DataTableBOF_Proc_Time.ColumnName = "BOF_Proc_Time";
            this.coldsProcTimeL3DataTableBOF_Proc_Time.DataType = typeof(int);
            this.coldsProcTimeL3DataTableBOF_Proc_Time.Namespace = "";
            // 
            // coldsProcTimeL3DataTableLF_Proc_Time
            // 
            this.coldsProcTimeL3DataTableLF_Proc_Time.Caption = "LF_Proc_Time";
            this.coldsProcTimeL3DataTableLF_Proc_Time.ColumnName = "LF_Proc_Time";
            this.coldsProcTimeL3DataTableLF_Proc_Time.DataType = typeof(int);
            this.coldsProcTimeL3DataTableLF_Proc_Time.Namespace = "";
            // 
            // coldsProcTimeL3DataTableRH_Proc_Time
            // 
            this.coldsProcTimeL3DataTableRH_Proc_Time.Caption = "RH_Proc_Time";
            this.coldsProcTimeL3DataTableRH_Proc_Time.ColumnName = "RH_Proc_Time";
            this.coldsProcTimeL3DataTableRH_Proc_Time.DataType = typeof(int);
            this.coldsProcTimeL3DataTableRH_Proc_Time.Namespace = "";
            // 
            // coldsProcTimeL3DataTableCaster_Proc_Time
            // 
            this.coldsProcTimeL3DataTableCaster_Proc_Time.Caption = "Caster_Proc_Time";
            this.coldsProcTimeL3DataTableCaster_Proc_Time.ColumnName = "Caster_Proc_Time";
            this.coldsProcTimeL3DataTableCaster_Proc_Time.DataType = typeof(int);
            this.coldsProcTimeL3DataTableCaster_Proc_Time.Namespace = "";
            // 
            // coldsProcTimeL3DataTableTapped_Proc_Time
            // 
            this.coldsProcTimeL3DataTableTapped_Proc_Time.Caption = "Tapped_Proc_Time";
            this.coldsProcTimeL3DataTableTapped_Proc_Time.ColumnName = "Tapped_Proc_Time";
            this.coldsProcTimeL3DataTableTapped_Proc_Time.DataType = typeof(int);
            this.coldsProcTimeL3DataTableTapped_Proc_Time.Namespace = "";
            // 
            // coldsProcTimeL3DataTableCheckFlag
            // 
            this.coldsProcTimeL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsProcTimeL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsProcTimeL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsProcTimeL3DataTableCheckFlag.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsProcTime;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btnQuery,
            this.toolStripLabel6,
            this.cmbSteelGradeIndex,
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
            this.toolStripLabel1,
            this.txtSteelGrade});
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
            // cmbSteelGradeIndex
            // 
            this.cmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSteelGradeIndex.Name = "cmbSteelGradeIndex";
            this.cmbSteelGradeIndex.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel7.Text = "炼钢记号:";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "钢种";
            // 
            // txtSteelGrade
            // 
            this.txtSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.ReadOnly = true;
            this.txtSteelGrade.Size = new System.Drawing.Size(100, 25);
            // 
            // hmiRootPanelProcTime
            // 
            this.hmiRootPanelProcTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelProcTime.Controls.Add(this.dvProcTime);
            this.hmiRootPanelProcTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelProcTime.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelProcTime.Name = "hmiRootPanelProcTime";
            this.hmiRootPanelProcTime.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelProcTime.TabIndex = 18;
            // 
            // dvProcTime
            // 
            this.dvProcTime.AllowUserToAddRows = false;
            this.dvProcTime.AutoGenerateColumns = false;
            this.dvProcTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvProcTime.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvProcTime.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProcTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.bOFProcTimeDataGridViewTextBoxColumn,
            this.lFProcTimeDataGridViewTextBoxColumn,
            this.rHProcTimeDataGridViewTextBoxColumn,
            this.casterProcTimeDataGridViewTextBoxColumn,
            this.tappedProcTimeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvProcTime.DataSource = this.bsProcTime;
            this.dvProcTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProcTime.Location = new System.Drawing.Point(0, 0);
            this.dvProcTime.Name = "dvProcTime";
            this.dvProcTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvProcTime.RowTemplate.Height = 23;
            this.dvProcTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvProcTime.Size = new System.Drawing.Size(1016, 608);
            this.dvProcTime.TabIndex = 0;
            this.dvProcTime.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvProcTime_DataError);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            // 
            // bOFProcTimeDataGridViewTextBoxColumn
            // 
            this.bOFProcTimeDataGridViewTextBoxColumn.DataPropertyName = "BOF_Proc_Time";
            this.bOFProcTimeDataGridViewTextBoxColumn.HeaderText = "转炉作业时间";
            this.bOFProcTimeDataGridViewTextBoxColumn.Name = "bOFProcTimeDataGridViewTextBoxColumn";
            // 
            // lFProcTimeDataGridViewTextBoxColumn
            // 
            this.lFProcTimeDataGridViewTextBoxColumn.DataPropertyName = "LF_Proc_Time";
            this.lFProcTimeDataGridViewTextBoxColumn.HeaderText = "LF炉作业时间";
            this.lFProcTimeDataGridViewTextBoxColumn.Name = "lFProcTimeDataGridViewTextBoxColumn";
            // 
            // rHProcTimeDataGridViewTextBoxColumn
            // 
            this.rHProcTimeDataGridViewTextBoxColumn.DataPropertyName = "RH_Proc_Time";
            this.rHProcTimeDataGridViewTextBoxColumn.HeaderText = "RH炉作业时间";
            this.rHProcTimeDataGridViewTextBoxColumn.Name = "rHProcTimeDataGridViewTextBoxColumn";
            // 
            // casterProcTimeDataGridViewTextBoxColumn
            // 
            this.casterProcTimeDataGridViewTextBoxColumn.DataPropertyName = "Caster_Proc_Time";
            this.casterProcTimeDataGridViewTextBoxColumn.HeaderText = "铸机作业时间";
            this.casterProcTimeDataGridViewTextBoxColumn.Name = "casterProcTimeDataGridViewTextBoxColumn";
            // 
            // tappedProcTimeDataGridViewTextBoxColumn
            // 
            this.tappedProcTimeDataGridViewTextBoxColumn.DataPropertyName = "Tapped_Proc_Time";
            this.tappedProcTimeDataGridViewTextBoxColumn.HeaderText = "炉后作业时间";
            this.tappedProcTimeDataGridViewTextBoxColumn.Name = "tappedProcTimeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsSteelGradeIndex
            // 
            this.dsSteelGradeIndex.AutoSubscribe = false;
            this.dsSteelGradeIndex.DataSetName = "L3DataSet";
            this.dsSteelGradeIndex.DeleteMethod = null;
            this.dsSteelGradeIndex.InsertMethod = null;
            this.dsSteelGradeIndex.L3DataAdapter = this.Adapter;
            this.dsSteelGradeIndex.LoadEvent = "Click";
            this.dsSteelGradeIndex.LoadTrigger = null;
            this.dsSteelGradeIndex.RefreshValve = 1000;
            this.dsSteelGradeIndex.SourceCommand = null;
            this.dsSteelGradeIndex.SourceCondition = "SteelGradeIndex is not null order by SteelGradeIndex";
            this.dsSteelGradeIndex.SourceMethod = "";
            this.dsSteelGradeIndex.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGradeIndex.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGradeIndex.SubscribeTarget = null;
            this.dsSteelGradeIndex.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGradeIndex});
            this.dsSteelGradeIndex.UpdateEvent = "Click";
            this.dsSteelGradeIndex.UpdateMethod = null;
            this.dsSteelGradeIndex.UpdateTrigger = null;
            // 
            // schemadsSteelGradeIndex
            // 
            this.schemadsSteelGradeIndex.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex});
            this.schemadsSteelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoSubscribe = false;
            this.dsSteelGrade.DataSetName = "L3DataSet";
            this.dsSteelGrade.DeleteMethod = "";
            this.dsSteelGrade.InsertMethod = "";
            this.dsSteelGrade.L3DataAdapter = this.Adapter;
            this.dsSteelGrade.LoadEvent = "";
            this.dsSteelGrade.LoadTrigger = null;
            this.dsSteelGrade.RefreshValve = 1000;
            this.dsSteelGrade.SourceCommand = null;
            this.dsSteelGrade.SourceCondition = "1=2";
            this.dsSteelGrade.SourceMethod = "";
            this.dsSteelGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelGrade.SourceURI = "XGMESLogic\\QualityMag\\CQA_SteelGradeIndex_R";
            this.dsSteelGrade.SubscribeTarget = null;
            this.dsSteelGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGrade});
            this.dsSteelGrade.UpdateEvent = "";
            this.dsSteelGrade.UpdateMethod = "";
            this.dsSteelGrade.UpdateTrigger = null;
            // 
            // schemadsSteelGrade
            // 
            this.schemadsSteelGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeL3DataTableSteelGradeIndex,
            this.coldsSteelGradeL3DataTableSteelGrade});
            this.schemadsSteelGrade.TableName = "L3DataTable";
            // 
            // coldsSteelGradeL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeL3DataTableSteelGrade
            // 
            this.coldsSteelGradeL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.Namespace = "";
            // 
            // ProcTimeStdMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelProcTime);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcTimeStdMaintenFrm";
            this.TabText = "工序内作业时间标准维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcTimeStdMaintenFrm_FormClosing);
            this.Load += new System.EventHandler(this.ProcTimeStdMaintenFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelProcTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvProcTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
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
        private System.Windows.Forms.BindingSource bsProcTime;
        private AppSvrHMI.L3DataSet dsProcTime;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbSteelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private HMIBase.HMIRootPanel hmiRootPanelProcTime;
        private System.Windows.Forms.DataGridView dvProcTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Data.DataTable schemadsProcTime;
        private System.Data.DataColumn coldsProcTimeL3DataTableGUID;
        private System.Data.DataColumn coldsProcTimeL3DataTableName;
        private System.Data.DataColumn coldsProcTimeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsProcTimeL3DataTableBOF_Proc_Time;
        private System.Data.DataColumn coldsProcTimeL3DataTableLF_Proc_Time;
        private System.Data.DataColumn coldsProcTimeL3DataTableRH_Proc_Time;
        private System.Data.DataColumn coldsProcTimeL3DataTableCaster_Proc_Time;
        private System.Data.DataColumn coldsProcTimeL3DataTableTapped_Proc_Time;
        private System.Data.DataColumn coldsProcTimeL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFProcTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFProcTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHProcTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterProcTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tappedProcTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
    }
}