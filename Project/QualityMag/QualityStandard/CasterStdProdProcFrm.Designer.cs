namespace QualityMag.QualityStandard
{
    partial class CasterStdProdProcFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasterStdProdProcFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.bsProdProc = new System.Windows.Forms.BindingSource(this.components);
            this.dsProdProc = new AppSvrHMI.L3DataSet();
            this.schemadsProdProc = new System.Data.DataTable();
            this.coldsProdProcL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableName = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableSpec_Seq = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableWidth_Min = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableWidth_Max = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableThickness_Min = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableThickness_Max = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableLength_Min = new System.Data.DataColumn();
            this.coldsProdProcL3DataTableLength_Max = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCasterID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtCasterID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.hmiRootPanelProdProc = new HMIBase.HMIRootPanel();
            this.dvProdProc = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCasterID = new AppSvrHMI.L3DataSet();
            this.schemadsCasterID = new System.Data.DataTable();
            this.coldsCasterIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.specSeqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsUnitName = new AppSvrHMI.L3DataSet();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableName = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code = new System.Data.DataColumn();
            this.coldsSteelGradeIndexL3DataTableFirst_Flag = new System.Data.DataColumn();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProdProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.hmiRootPanelProdProc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProdProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitName)).BeginInit();
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
            this.Adapter.SetAccessRight(this.btnAdd, "btnCCMProcessStd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnCCMProcessStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnCCMProcessStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnCCMProcessStd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnCCMProcessStd");
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
            // bsProdProc
            // 
            this.bsProdProc.DataMember = "L3DataTable";
            this.bsProdProc.DataSource = this.dsProdProc;
            // 
            // dsProdProc
            // 
            this.dsProdProc.AutoLoad = true;
            this.dsProdProc.AutoSubscribe = false;
            this.dsProdProc.DataSetName = "L3DataSet";
            this.dsProdProc.DeleteMethod = null;
            this.dsProdProc.InsertMethod = null;
            this.dsProdProc.L3DataAdapter = this.Adapter;
            this.dsProdProc.LoadEvent = "Click";
            this.dsProdProc.LoadTrigger = null;
            this.dsProdProc.RefreshValve = 1000;
            this.dsProdProc.SourceCommand = null;
            this.dsProdProc.SourceCondition = "1=2";
            this.dsProdProc.SourceMethod = "";
            this.dsProdProc.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProdProc.SourceURI = "XGMESLogic\\QualityMag\\CQA_Caster_Std_ProdProc";
            this.dsProdProc.SubscribeTarget = null;
            this.dsProdProc.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProdProc});
            this.dsProdProc.UpdateEvent = "Click";
            this.dsProdProc.UpdateMethod = null;
            this.dsProdProc.UpdateTrigger = null;
            // 
            // schemadsProdProc
            // 
            this.schemadsProdProc.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProdProcL3DataTableGUID,
            this.coldsProdProcL3DataTableName,
            this.coldsProdProcL3DataTableSteelGradeIndex,
            this.coldsProdProcL3DataTableCasterID,
            this.coldsProdProcL3DataTableSpec_Seq,
            this.coldsProdProcL3DataTableWidth_Min,
            this.coldsProdProcL3DataTableWidth_Max,
            this.coldsProdProcL3DataTableThickness_Min,
            this.coldsProdProcL3DataTableThickness_Max,
            this.coldsProdProcL3DataTableLength_Min,
            this.coldsProdProcL3DataTableLength_Max});
            this.schemadsProdProc.TableName = "L3DataTable";
            // 
            // coldsProdProcL3DataTableGUID
            // 
            this.coldsProdProcL3DataTableGUID.Caption = "GUID";
            this.coldsProdProcL3DataTableGUID.ColumnName = "GUID";
            this.coldsProdProcL3DataTableGUID.Namespace = "";
            // 
            // coldsProdProcL3DataTableName
            // 
            this.coldsProdProcL3DataTableName.Caption = "Name";
            this.coldsProdProcL3DataTableName.ColumnName = "Name";
            this.coldsProdProcL3DataTableName.Namespace = "";
            // 
            // coldsProdProcL3DataTableSteelGradeIndex
            // 
            this.coldsProdProcL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsProdProcL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsProdProcL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsProdProcL3DataTableCasterID
            // 
            this.coldsProdProcL3DataTableCasterID.Caption = "CasterID";
            this.coldsProdProcL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsProdProcL3DataTableCasterID.Namespace = "";
            // 
            // coldsProdProcL3DataTableSpec_Seq
            // 
            this.coldsProdProcL3DataTableSpec_Seq.Caption = "Spec_Seq";
            this.coldsProdProcL3DataTableSpec_Seq.ColumnName = "Spec_Seq";
            this.coldsProdProcL3DataTableSpec_Seq.DataType = typeof(int);
            this.coldsProdProcL3DataTableSpec_Seq.Namespace = "";
            // 
            // coldsProdProcL3DataTableWidth_Min
            // 
            this.coldsProdProcL3DataTableWidth_Min.Caption = "Width_Min";
            this.coldsProdProcL3DataTableWidth_Min.ColumnName = "Width_Min";
            this.coldsProdProcL3DataTableWidth_Min.DataType = typeof(int);
            this.coldsProdProcL3DataTableWidth_Min.Namespace = "";
            // 
            // coldsProdProcL3DataTableWidth_Max
            // 
            this.coldsProdProcL3DataTableWidth_Max.Caption = "Width_Max";
            this.coldsProdProcL3DataTableWidth_Max.ColumnName = "Width_Max";
            this.coldsProdProcL3DataTableWidth_Max.DataType = typeof(int);
            this.coldsProdProcL3DataTableWidth_Max.Namespace = "";
            // 
            // coldsProdProcL3DataTableThickness_Min
            // 
            this.coldsProdProcL3DataTableThickness_Min.Caption = "Thickness_Min";
            this.coldsProdProcL3DataTableThickness_Min.ColumnName = "Thickness_Min";
            this.coldsProdProcL3DataTableThickness_Min.DataType = typeof(int);
            this.coldsProdProcL3DataTableThickness_Min.Namespace = "";
            // 
            // coldsProdProcL3DataTableThickness_Max
            // 
            this.coldsProdProcL3DataTableThickness_Max.Caption = "Thickness_Max";
            this.coldsProdProcL3DataTableThickness_Max.ColumnName = "Thickness_Max";
            this.coldsProdProcL3DataTableThickness_Max.DataType = typeof(int);
            this.coldsProdProcL3DataTableThickness_Max.Namespace = "";
            // 
            // coldsProdProcL3DataTableLength_Min
            // 
            this.coldsProdProcL3DataTableLength_Min.Caption = "Length_Min";
            this.coldsProdProcL3DataTableLength_Min.ColumnName = "Length_Min";
            this.coldsProdProcL3DataTableLength_Min.DataType = typeof(int);
            this.coldsProdProcL3DataTableLength_Min.Namespace = "";
            // 
            // coldsProdProcL3DataTableLength_Max
            // 
            this.coldsProdProcL3DataTableLength_Max.Caption = "Length_Max";
            this.coldsProdProcL3DataTableLength_Max.ColumnName = "Length_Max";
            this.coldsProdProcL3DataTableLength_Max.DataType = typeof(int);
            this.coldsProdProcL3DataTableLength_Max.Namespace = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsProdProc;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.btnQuery,
            this.cmbSteelGradeIndex,
            this.toolStripLabel6,
            this.toolStripLabel1,
            this.cmbCasterID,
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
            this.txtCasterID,
            this.toolStripLabel2,
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
            // cmbSteelGradeIndex
            // 
            this.cmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSteelGradeIndex.Name = "cmbSteelGradeIndex";
            this.cmbSteelGradeIndex.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.AutoSize = false;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabel6.Text = " ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "炼钢记号:";
            // 
            // cmbCasterID
            // 
            this.cmbCasterID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCasterID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCasterID.Name = "cmbCasterID";
            this.cmbCasterID.Size = new System.Drawing.Size(121, 25);
            this.cmbCasterID.SelectedIndexChanged += new System.EventHandler(this.cmbCasterID_SelectedIndexChanged);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel7.Text = "铸机:";
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
            // txtCasterID
            // 
            this.txtCasterID.Name = "txtCasterID";
            this.txtCasterID.Size = new System.Drawing.Size(100, 25);
            this.txtCasterID.Visible = false;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel2.Text = "钢种";
            // 
            // txtSteelGrade
            // 
            this.txtSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.ReadOnly = true;
            this.txtSteelGrade.Size = new System.Drawing.Size(100, 25);
            // 
            // hmiRootPanelProdProc
            // 
            this.hmiRootPanelProdProc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelProdProc.Controls.Add(this.dvProdProc);
            this.hmiRootPanelProdProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelProdProc.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanelProdProc.Name = "hmiRootPanelProdProc";
            this.hmiRootPanelProdProc.Size = new System.Drawing.Size(1020, 612);
            this.hmiRootPanelProdProc.TabIndex = 18;
            // 
            // dvProdProc
            // 
            this.dvProdProc.AllowUserToAddRows = false;
            this.dvProdProc.AllowUserToDeleteRows = false;
            this.dvProdProc.AutoGenerateColumns = false;
            this.dvProdProc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvProdProc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvProdProc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProdProc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.casterIDDataGridViewTextBoxColumn,
            this.specSeqDataGridViewTextBoxColumn,
            this.widthMinDataGridViewTextBoxColumn,
            this.widthMaxDataGridViewTextBoxColumn,
            this.thicknessMinDataGridViewTextBoxColumn,
            this.thicknessMaxDataGridViewTextBoxColumn,
            this.lengthMinDataGridViewTextBoxColumn,
            this.lengthMaxDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvProdProc.DataSource = this.bsProdProc;
            this.dvProdProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProdProc.Location = new System.Drawing.Point(0, 0);
            this.dvProdProc.Name = "dvProdProc";
            this.dvProdProc.RowTemplate.Height = 23;
            this.dvProdProc.Size = new System.Drawing.Size(1016, 608);
            this.dvProdProc.TabIndex = 0;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.DataSource = this.dsCasterID;
            this.casterIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "连铸机号(PK1)";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.casterIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.casterIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.casterIDDataGridViewTextBoxColumn.Width = 108;
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
            this.dsCasterID.SourceCondition = "CODE_GROUP = \'Caster\'";
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
            // specSeqDataGridViewTextBoxColumn
            // 
            this.specSeqDataGridViewTextBoxColumn.DataPropertyName = "Spec_Seq";
            this.specSeqDataGridViewTextBoxColumn.HeaderText = "规格序号(PK2)";
            this.specSeqDataGridViewTextBoxColumn.Name = "specSeqDataGridViewTextBoxColumn";
            this.specSeqDataGridViewTextBoxColumn.Width = 108;
            // 
            // widthMinDataGridViewTextBoxColumn
            // 
            this.widthMinDataGridViewTextBoxColumn.DataPropertyName = "Width_Min";
            this.widthMinDataGridViewTextBoxColumn.HeaderText = "宽度最小值";
            this.widthMinDataGridViewTextBoxColumn.Name = "widthMinDataGridViewTextBoxColumn";
            this.widthMinDataGridViewTextBoxColumn.Width = 90;
            // 
            // widthMaxDataGridViewTextBoxColumn
            // 
            this.widthMaxDataGridViewTextBoxColumn.DataPropertyName = "Width_Max";
            this.widthMaxDataGridViewTextBoxColumn.HeaderText = "宽度最大值";
            this.widthMaxDataGridViewTextBoxColumn.Name = "widthMaxDataGridViewTextBoxColumn";
            this.widthMaxDataGridViewTextBoxColumn.Width = 90;
            // 
            // thicknessMinDataGridViewTextBoxColumn
            // 
            this.thicknessMinDataGridViewTextBoxColumn.DataPropertyName = "Thickness_Min";
            this.thicknessMinDataGridViewTextBoxColumn.HeaderText = "厚度最小值";
            this.thicknessMinDataGridViewTextBoxColumn.Name = "thicknessMinDataGridViewTextBoxColumn";
            this.thicknessMinDataGridViewTextBoxColumn.Width = 90;
            // 
            // thicknessMaxDataGridViewTextBoxColumn
            // 
            this.thicknessMaxDataGridViewTextBoxColumn.DataPropertyName = "Thickness_Max";
            this.thicknessMaxDataGridViewTextBoxColumn.HeaderText = "厚度最大值";
            this.thicknessMaxDataGridViewTextBoxColumn.Name = "thicknessMaxDataGridViewTextBoxColumn";
            this.thicknessMaxDataGridViewTextBoxColumn.Width = 90;
            // 
            // lengthMinDataGridViewTextBoxColumn
            // 
            this.lengthMinDataGridViewTextBoxColumn.DataPropertyName = "Length_Min";
            this.lengthMinDataGridViewTextBoxColumn.HeaderText = "长度最小值";
            this.lengthMinDataGridViewTextBoxColumn.Name = "lengthMinDataGridViewTextBoxColumn";
            this.lengthMinDataGridViewTextBoxColumn.Width = 90;
            // 
            // lengthMaxDataGridViewTextBoxColumn
            // 
            this.lengthMaxDataGridViewTextBoxColumn.DataPropertyName = "Length_Max";
            this.lengthMaxDataGridViewTextBoxColumn.HeaderText = "长度最大值";
            this.lengthMaxDataGridViewTextBoxColumn.Name = "lengthMaxDataGridViewTextBoxColumn";
            this.lengthMaxDataGridViewTextBoxColumn.Width = 90;
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
            this.dsUnitName.SourceCondition = null;
            this.dsUnitName.SourceMethod = null;
            this.dsUnitName.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsUnitName.SourceURI = null;
            this.dsUnitName.SubscribeTarget = null;
            this.dsUnitName.UpdateEvent = "Click";
            this.dsUnitName.UpdateMethod = null;
            this.dsUnitName.UpdateTrigger = null;
            // 
            // dsSteelGradeIndex
            // 
            this.dsSteelGradeIndex.AutoLoad = true;
            this.dsSteelGradeIndex.AutoSubscribe = false;
            this.dsSteelGradeIndex.DataSetName = "L3DataSet";
            this.dsSteelGradeIndex.DeleteMethod = null;
            this.dsSteelGradeIndex.InsertMethod = null;
            this.dsSteelGradeIndex.L3DataAdapter = this.Adapter;
            this.dsSteelGradeIndex.LoadEvent = "Click";
            this.dsSteelGradeIndex.LoadTrigger = null;
            this.dsSteelGradeIndex.RefreshValve = 1000;
            this.dsSteelGradeIndex.SourceCommand = null;
            this.dsSteelGradeIndex.SourceCondition = "steelgradeindex is not null order by SteelGradeIndex";
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
            this.coldsSteelGradeIndexL3DataTableGUID,
            this.coldsSteelGradeIndexL3DataTableName,
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex,
            this.coldsSteelGradeIndexL3DataTableSteelGrade,
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code,
            this.coldsSteelGradeIndexL3DataTableFirst_Flag});
            this.schemadsSteelGradeIndex.TableName = "L3DataTable";
            // 
            // coldsSteelGradeIndexL3DataTableGUID
            // 
            this.coldsSteelGradeIndexL3DataTableGUID.Caption = "GUID";
            this.coldsSteelGradeIndexL3DataTableGUID.ColumnName = "GUID";
            this.coldsSteelGradeIndexL3DataTableGUID.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableName
            // 
            this.coldsSteelGradeIndexL3DataTableName.Caption = "Name";
            this.coldsSteelGradeIndexL3DataTableName.ColumnName = "Name";
            this.coldsSteelGradeIndexL3DataTableName.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGradeIndex
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableSteelGrade
            // 
            this.coldsSteelGradeIndexL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeIndexL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeIndexL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableGrade_Group_Code
            // 
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code.Caption = "Grade_Group_Code";
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code.ColumnName = "Grade_Group_Code";
            this.coldsSteelGradeIndexL3DataTableGrade_Group_Code.Namespace = "";
            // 
            // coldsSteelGradeIndexL3DataTableFirst_Flag
            // 
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.Caption = "First_Flag";
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.ColumnName = "First_Flag";
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.DataType = typeof(int);
            this.coldsSteelGradeIndexL3DataTableFirst_Flag.Namespace = "";
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoLoad = true;
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
            // CasterStdProdProcFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.hmiRootPanelProdProc);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CasterStdProdProcFrm";
            this.TabText = "铸机制程标准维护";
            this.Text = "铸机制程标准维护";
            this.Load += new System.EventHandler(this.CasterStdProdProcFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CasterStdProdProcFrm_FormClosing_1);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProdProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProdProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.hmiRootPanelProdProc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvProdProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitName)).EndInit();
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
        private System.Windows.Forms.BindingSource bsProdProc;
        private AppSvrHMI.L3DataSet dsProdProc;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbCasterID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private HMIBase.HMIRootPanel hmiRootPanelProdProc;
        private System.Windows.Forms.DataGridView dvProdProc;
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
        private AppSvrHMI.L3DataSet dsUnitName;
        private System.Data.DataTable schemadsProdProc;
        private System.Data.DataColumn coldsProdProcL3DataTableGUID;
        private System.Data.DataColumn coldsProdProcL3DataTableName;
        private System.Data.DataColumn coldsProdProcL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsProdProcL3DataTableCasterID;
        private System.Data.DataColumn coldsProdProcL3DataTableSpec_Seq;
        private System.Data.DataColumn coldsProdProcL3DataTableWidth_Min;
        private System.Data.DataColumn coldsProdProcL3DataTableWidth_Max;
        private System.Data.DataColumn coldsProdProcL3DataTableThickness_Min;
        private System.Data.DataColumn coldsProdProcL3DataTableThickness_Max;
        private System.Data.DataColumn coldsProdProcL3DataTableLength_Min;
        private System.Data.DataColumn coldsProdProcL3DataTableLength_Max;
        private AppSvrHMI.L3DataSet dsCasterID;
        private System.Data.DataTable schemadsCasterID;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode;
        private System.Data.DataColumn coldsCasterIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripTextBox txtCasterID;
        private System.Windows.Forms.ToolStripComboBox cmbSteelGradeIndex;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableGUID;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableName;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGrade;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableGrade_Group_Code;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableFirst_Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn casterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specSeqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
    }
}