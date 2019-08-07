namespace QualityMag.QualityStandard
{
    partial class RHStdMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RHStdMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelFeed = new System.Windows.Forms.ToolStripButton();
            this.btnAddFeed = new System.Windows.Forms.ToolStripButton();
            this.btnDelAlloy = new System.Windows.Forms.ToolStripButton();
            this.btnAddAlloy = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tscmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.bsAlloy = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlloy = new AppSvrHMI.L3DataSet();
            this.schemadsAlloy = new System.Data.DataTable();
            this.coldsAlloyL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsAlloyL3DataTableAlloy_Flag = new System.Data.DataColumn();
            this.coldsAlloyL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsAlloyL3DataTableAlloy_Yield = new System.Data.DataColumn();
            this.coldsAlloyL3DataTableGUID = new System.Data.DataColumn();
            this.bsFeed = new System.Windows.Forms.BindingSource(this.components);
            this.dsFeed = new AppSvrHMI.L3DataSet();
            this.schemadsFeed = new System.Data.DataTable();
            this.coldsFeedL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProc_Code = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProc_Code_Weight_Max = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProc_Code_Weight_Min = new System.Data.DataColumn();
            this.coldsFeedL3DataTableGUID = new System.Data.DataColumn();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTableValid_Date = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNew_Code = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNote = new System.Data.DataColumn();
            this.dsProc = new AppSvrHMI.L3DataSet();
            this.schemadsProc = new System.Data.DataTable();
            this.coldsProcL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcL3DataTableName = new System.Data.DataColumn();
            this.coldsProcL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsProcL3DataTableLeaFir_Temp_Aim = new System.Data.DataColumn();
            this.coldsProcL3DataTableLeaFir_Temp_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableLeaFir_Temp_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableLea_Temp_Aim = new System.Data.DataColumn();
            this.coldsProcL3DataTableLea_Temp_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableLea_Temp_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableDepth_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableDepth_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableVacuum_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableVacuum_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableUp_Blow_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableUp_Blow_Aim = new System.Data.DataColumn();
            this.coldsProcL3DataTableUp_Blow_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableDec_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableDec_Time_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableDec_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTablePure_Time_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTablePure_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableVacuum_Time_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableProc_Time_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableOxy_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableH_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableSoft_Blow_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableCalm_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableAl_Hot_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableCold_Mat_Add = new System.Data.DataColumn();
            this.coldsProcL3DataTableHold_Steel_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableStay_Steel_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTablePure_DeO_Time_Min = new System.Data.DataColumn();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.bsProc = new System.Windows.Forms.BindingSource(this.components);
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.hmiRootPanelFeed = new HMIBase.HMIRootPanel();
            this.dvFeed = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcCodeWeightMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcCodeWeightMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNavigatorFeed = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabAlloy = new System.Windows.Forms.TabPage();
            this.hmiRootPanelAlloy = new HMIBase.HMIRootPanel();
            this.dvAlloy = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alloyFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alloyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alloyYieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNavigatorAlloy = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtValidDate = new System.Windows.Forms.DateTimePicker();
            this.txtNewCode = new PxDataValid.PxTextBox();
            this.txtSteelGradeIndexBase = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabProc = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStaySteelTimeMax = new PxDataValid.PxTextBox();
            this.txtPureDeOTimeMin = new PxDataValid.PxTextBox();
            this.txtHoldSteelTimeMax = new PxDataValid.PxTextBox();
            this.txtColdMatAdd = new PxDataValid.PxTextBox();
            this.txtProcTimeMin = new PxDataValid.PxTextBox();
            this.txtVacuumTimeMin = new PxDataValid.PxTextBox();
            this.txtPureTimeMax = new PxDataValid.PxTextBox();
            this.txtPureTimeMin = new PxDataValid.PxTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.cmbAlHotFlag = new PxDataValid.PxComboBox();
            this.cmbCalm_Flag = new PxDataValid.PxComboBox();
            this.cmbSoftBlowFlag = new PxDataValid.PxComboBox();
            this.cmbHFlag = new PxDataValid.PxComboBox();
            this.cmbOxyFlag = new PxDataValid.PxComboBox();
            this.cmbDec_Flag = new PxDataValid.PxComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtDecTimeMax = new PxDataValid.PxTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtDecTimeMin = new PxDataValid.PxTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtVacuumMax = new PxDataValid.PxTextBox();
            this.txtUpBlowAim = new PxDataValid.PxTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtDepthMax = new PxDataValid.PxTextBox();
            this.txtUpBlowMax = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpBlowMin = new PxDataValid.PxTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.txtVacuumMin = new PxDataValid.PxTextBox();
            this.txtDepthMin = new PxDataValid.PxTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLeaFirTempAim = new PxDataValid.PxTextBox();
            this.txtLeaTempAim = new PxDataValid.PxTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtLeaTempMin = new PxDataValid.PxTextBox();
            this.txtLeaTempMax = new PxDataValid.PxTextBox();
            this.txtLeaFirTempMin = new PxDataValid.PxTextBox();
            this.txtLeaFirTempMax = new PxDataValid.PxTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSteelGradeIndexPrco = new PxDataValid.PxTextBox();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.toolStripMain.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProc)).BeginInit();
            this.tabFeed.SuspendLayout();
            this.hmiRootPanelFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorFeed)).BeginInit();
            this.bNavigatorFeed.SuspendLayout();
            this.tabAlloy.SuspendLayout();
            this.hmiRootPanelAlloy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorAlloy)).BeginInit();
            this.bNavigatorAlloy.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabProc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnRHStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnRHStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOK
            // 
            this.Adapter.SetAccessRight(this.btnOK, "btnRHStd");
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 40);
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnRHStd");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelFeed
            // 
            this.Adapter.SetAccessRight(this.btnDelFeed, "btnRHStd");
            this.btnDelFeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelFeed.Image = ((System.Drawing.Image)(resources.GetObject("btnDelFeed.Image")));
            this.btnDelFeed.Name = "btnDelFeed";
            this.btnDelFeed.RightToLeftAutoMirrorImage = true;
            this.btnDelFeed.Size = new System.Drawing.Size(23, 22);
            this.btnDelFeed.Text = "删除";
            this.btnDelFeed.Click += new System.EventHandler(this.btnDelFeed_Click);
            // 
            // btnAddFeed
            // 
            this.Adapter.SetAccessRight(this.btnAddFeed, "btnRHStd");
            this.btnAddFeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFeed.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFeed.Image")));
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.RightToLeftAutoMirrorImage = true;
            this.btnAddFeed.Size = new System.Drawing.Size(23, 22);
            this.btnAddFeed.Text = "新添";
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // btnDelAlloy
            // 
            this.Adapter.SetAccessRight(this.btnDelAlloy, "btnRHStd");
            this.btnDelAlloy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelAlloy.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAlloy.Image")));
            this.btnDelAlloy.Name = "btnDelAlloy";
            this.btnDelAlloy.RightToLeftAutoMirrorImage = true;
            this.btnDelAlloy.Size = new System.Drawing.Size(23, 22);
            this.btnDelAlloy.Text = "删除";
            // 
            // btnAddAlloy
            // 
            this.Adapter.SetAccessRight(this.btnAddAlloy, "btnRHStd");
            this.btnAddAlloy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddAlloy.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAlloy.Image")));
            this.btnAddAlloy.Name = "btnAddAlloy";
            this.btnAddAlloy.RightToLeftAutoMirrorImage = true;
            this.btnAddAlloy.Size = new System.Drawing.Size(23, 22);
            this.btnAddAlloy.Text = "新添";
            this.btnAddAlloy.Click += new System.EventHandler(this.btnAddAlloy_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnOK,
            this.btnCancel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1020, 43);
            this.toolStripMain.TabIndex = 0;
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
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnQuery,
            this.tscmbSteelGradeIndex,
            this.toolStripLabel1,
            this.toolStripLabel5,
            this.toolStripLabel4,
            this.txtSteelGrade});
            this.toolStrip2.Location = new System.Drawing.Point(0, 43);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1020, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
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
            // tscmbSteelGradeIndex
            // 
            this.tscmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscmbSteelGradeIndex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tscmbSteelGradeIndex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tscmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscmbSteelGradeIndex.Name = "tscmbSteelGradeIndex";
            this.tscmbSteelGradeIndex.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "炼钢记号:";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel5.Text = "        ";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel4.Text = "钢种";
            // 
            // txtSteelGrade
            // 
            this.txtSteelGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.ReadOnly = true;
            this.txtSteelGrade.Size = new System.Drawing.Size(100, 25);
            // 
            // bsAlloy
            // 
            this.bsAlloy.DataMember = "L3DataTable";
            this.bsAlloy.DataSource = this.dsAlloy;
            // 
            // dsAlloy
            // 
            this.dsAlloy.AutoLoad = true;
            this.dsAlloy.AutoSubscribe = false;
            this.dsAlloy.DataSetName = "L3DataSet";
            this.dsAlloy.DeleteMethod = null;
            this.dsAlloy.InsertMethod = null;
            this.dsAlloy.L3DataAdapter = this.Adapter;
            this.dsAlloy.LoadEvent = "Click";
            this.dsAlloy.LoadTrigger = null;
            this.dsAlloy.RefreshValve = 1000;
            this.dsAlloy.SourceCommand = null;
            this.dsAlloy.SourceCondition = "1=2";
            this.dsAlloy.SourceMethod = "";
            this.dsAlloy.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloy.SourceURI = "XGMESLogic\\QualityMag\\CQA_RH_Std_Alloy";
            this.dsAlloy.SubscribeTarget = null;
            this.dsAlloy.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloy});
            this.dsAlloy.UpdateEvent = "Click";
            this.dsAlloy.UpdateMethod = null;
            this.dsAlloy.UpdateTrigger = null;
            // 
            // schemadsAlloy
            // 
            this.schemadsAlloy.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyL3DataTableSteelGradeIndex,
            this.coldsAlloyL3DataTableAlloy_Flag,
            this.coldsAlloyL3DataTableAlloy_Code,
            this.coldsAlloyL3DataTableAlloy_Yield,
            this.coldsAlloyL3DataTableGUID});
            this.schemadsAlloy.TableName = "L3DataTable";
            // 
            // coldsAlloyL3DataTableSteelGradeIndex
            // 
            this.coldsAlloyL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsAlloyL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsAlloyL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsAlloyL3DataTableAlloy_Flag
            // 
            this.coldsAlloyL3DataTableAlloy_Flag.Caption = "Alloy_Flag";
            this.coldsAlloyL3DataTableAlloy_Flag.ColumnName = "Alloy_Flag";
            this.coldsAlloyL3DataTableAlloy_Flag.DataType = typeof(int);
            this.coldsAlloyL3DataTableAlloy_Flag.Namespace = "";
            // 
            // coldsAlloyL3DataTableAlloy_Code
            // 
            this.coldsAlloyL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsAlloyL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsAlloyL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsAlloyL3DataTableAlloy_Yield
            // 
            this.coldsAlloyL3DataTableAlloy_Yield.Caption = "Alloy_Yield";
            this.coldsAlloyL3DataTableAlloy_Yield.ColumnName = "Alloy_Yield";
            this.coldsAlloyL3DataTableAlloy_Yield.Namespace = "";
            // 
            // coldsAlloyL3DataTableGUID
            // 
            this.coldsAlloyL3DataTableGUID.Caption = "GUID";
            this.coldsAlloyL3DataTableGUID.ColumnName = "GUID";
            this.coldsAlloyL3DataTableGUID.Namespace = "";
            // 
            // bsFeed
            // 
            this.bsFeed.DataMember = "L3DataTable";
            this.bsFeed.DataSource = this.dsFeed;
            // 
            // dsFeed
            // 
            this.dsFeed.AutoLoad = true;
            this.dsFeed.AutoSubscribe = false;
            this.dsFeed.DataSetName = "L3DataSet";
            this.dsFeed.DeleteMethod = null;
            this.dsFeed.InsertMethod = null;
            this.dsFeed.L3DataAdapter = this.Adapter;
            this.dsFeed.LoadEvent = "Click";
            this.dsFeed.LoadTrigger = null;
            this.dsFeed.RefreshValve = 1000;
            this.dsFeed.SourceCommand = null;
            this.dsFeed.SourceCondition = "1=2";
            this.dsFeed.SourceMethod = "";
            this.dsFeed.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFeed.SourceURI = "XGMESLogic\\QualityMag\\CQA_RH_Std_Feed";
            this.dsFeed.SubscribeTarget = null;
            this.dsFeed.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFeed});
            this.dsFeed.UpdateEvent = "Click";
            this.dsFeed.UpdateMethod = null;
            this.dsFeed.UpdateTrigger = null;
            // 
            // schemadsFeed
            // 
            this.schemadsFeed.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFeedL3DataTableSteelGradeIndex,
            this.coldsFeedL3DataTableCaProc_Code,
            this.coldsFeedL3DataTableCaProc_Code_Weight_Max,
            this.coldsFeedL3DataTableCaProc_Code_Weight_Min,
            this.coldsFeedL3DataTableGUID});
            this.schemadsFeed.TableName = "L3DataTable";
            // 
            // coldsFeedL3DataTableSteelGradeIndex
            // 
            this.coldsFeedL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsFeedL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsFeedL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProc_Code
            // 
            this.coldsFeedL3DataTableCaProc_Code.Caption = "CaProc_Code";
            this.coldsFeedL3DataTableCaProc_Code.ColumnName = "CaProc_Code";
            this.coldsFeedL3DataTableCaProc_Code.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProc_Code_Weight_Max
            // 
            this.coldsFeedL3DataTableCaProc_Code_Weight_Max.Caption = "CaProc_Code_Weight_Max";
            this.coldsFeedL3DataTableCaProc_Code_Weight_Max.ColumnName = "CaProc_Code_Weight_Max";
            this.coldsFeedL3DataTableCaProc_Code_Weight_Max.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProc_Code_Weight_Min
            // 
            this.coldsFeedL3DataTableCaProc_Code_Weight_Min.Caption = "CaProc_Code_Weight_Min";
            this.coldsFeedL3DataTableCaProc_Code_Weight_Min.ColumnName = "CaProc_Code_Weight_Min";
            this.coldsFeedL3DataTableCaProc_Code_Weight_Min.Namespace = "";
            // 
            // coldsFeedL3DataTableGUID
            // 
            this.coldsFeedL3DataTableGUID.Caption = "GUID";
            this.coldsFeedL3DataTableGUID.ColumnName = "GUID";
            this.coldsFeedL3DataTableGUID.Namespace = "";
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
            this.dsBase.SourceURI = "XGMESLogic\\QualityMag\\CQA_RH_Std_Base";
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
            this.coldsBaseL3DataTableSteelGradeIndex,
            this.coldsBaseL3DataTableValid_Date,
            this.coldsBaseL3DataTableNew_Code,
            this.coldsBaseL3DataTableNote});
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
            // coldsBaseL3DataTableSteelGradeIndex
            // 
            this.coldsBaseL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBaseL3DataTableValid_Date
            // 
            this.coldsBaseL3DataTableValid_Date.Caption = "Valid_Date";
            this.coldsBaseL3DataTableValid_Date.ColumnName = "Valid_Date";
            this.coldsBaseL3DataTableValid_Date.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableValid_Date.Namespace = "";
            // 
            // coldsBaseL3DataTableNew_Code
            // 
            this.coldsBaseL3DataTableNew_Code.Caption = "New_Code";
            this.coldsBaseL3DataTableNew_Code.ColumnName = "New_Code";
            this.coldsBaseL3DataTableNew_Code.Namespace = "";
            // 
            // coldsBaseL3DataTableNote
            // 
            this.coldsBaseL3DataTableNote.Caption = "Note";
            this.coldsBaseL3DataTableNote.ColumnName = "Note";
            this.coldsBaseL3DataTableNote.Namespace = "";
            // 
            // dsProc
            // 
            this.dsProc.AutoLoad = true;
            this.dsProc.AutoSubscribe = false;
            this.dsProc.DataSetName = "L3DataSet";
            this.dsProc.DeleteMethod = null;
            this.dsProc.InsertMethod = null;
            this.dsProc.L3DataAdapter = this.Adapter;
            this.dsProc.LoadEvent = "Click";
            this.dsProc.LoadTrigger = null;
            this.dsProc.RefreshValve = 1000;
            this.dsProc.SourceCommand = null;
            this.dsProc.SourceCondition = "1=2";
            this.dsProc.SourceMethod = "";
            this.dsProc.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProc.SourceURI = "XGMESLogic\\QualityMag\\CQA_RH_Std_Proc";
            this.dsProc.SubscribeTarget = null;
            this.dsProc.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProc});
            this.dsProc.UpdateEvent = "Click";
            this.dsProc.UpdateMethod = null;
            this.dsProc.UpdateTrigger = null;
            // 
            // schemadsProc
            // 
            this.schemadsProc.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcL3DataTableGUID,
            this.coldsProcL3DataTableName,
            this.coldsProcL3DataTableSteelGradeIndex,
            this.coldsProcL3DataTableLeaFir_Temp_Aim,
            this.coldsProcL3DataTableLeaFir_Temp_Min,
            this.coldsProcL3DataTableLeaFir_Temp_Max,
            this.coldsProcL3DataTableLea_Temp_Aim,
            this.coldsProcL3DataTableLea_Temp_Min,
            this.coldsProcL3DataTableLea_Temp_Max,
            this.coldsProcL3DataTableDepth_Min,
            this.coldsProcL3DataTableDepth_Max,
            this.coldsProcL3DataTableVacuum_Min,
            this.coldsProcL3DataTableVacuum_Max,
            this.coldsProcL3DataTableUp_Blow_Min,
            this.coldsProcL3DataTableUp_Blow_Aim,
            this.coldsProcL3DataTableUp_Blow_Max,
            this.coldsProcL3DataTableDec_Flag,
            this.coldsProcL3DataTableDec_Time_Min,
            this.coldsProcL3DataTableDec_Time_Max,
            this.coldsProcL3DataTablePure_Time_Min,
            this.coldsProcL3DataTablePure_Time_Max,
            this.coldsProcL3DataTableVacuum_Time_Min,
            this.coldsProcL3DataTableProc_Time_Min,
            this.coldsProcL3DataTableOxy_Flag,
            this.coldsProcL3DataTableH_Flag,
            this.coldsProcL3DataTableSoft_Blow_Flag,
            this.coldsProcL3DataTableCalm_Flag,
            this.coldsProcL3DataTableAl_Hot_Flag,
            this.coldsProcL3DataTableCold_Mat_Add,
            this.coldsProcL3DataTableHold_Steel_Time_Max,
            this.coldsProcL3DataTableStay_Steel_Time_Max,
            this.coldsProcL3DataTablePure_DeO_Time_Min});
            this.schemadsProc.TableName = "L3DataTable";
            // 
            // coldsProcL3DataTableGUID
            // 
            this.coldsProcL3DataTableGUID.Caption = "GUID";
            this.coldsProcL3DataTableGUID.ColumnName = "GUID";
            this.coldsProcL3DataTableGUID.Namespace = "";
            // 
            // coldsProcL3DataTableName
            // 
            this.coldsProcL3DataTableName.Caption = "Name";
            this.coldsProcL3DataTableName.ColumnName = "Name";
            this.coldsProcL3DataTableName.Namespace = "";
            // 
            // coldsProcL3DataTableSteelGradeIndex
            // 
            this.coldsProcL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsProcL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsProcL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsProcL3DataTableLeaFir_Temp_Aim
            // 
            this.coldsProcL3DataTableLeaFir_Temp_Aim.Caption = "LeaFir_Temp_Aim";
            this.coldsProcL3DataTableLeaFir_Temp_Aim.ColumnName = "LeaFir_Temp_Aim";
            this.coldsProcL3DataTableLeaFir_Temp_Aim.DataType = typeof(int);
            this.coldsProcL3DataTableLeaFir_Temp_Aim.Namespace = "";
            // 
            // coldsProcL3DataTableLeaFir_Temp_Min
            // 
            this.coldsProcL3DataTableLeaFir_Temp_Min.Caption = "LeaFir_Temp_Min";
            this.coldsProcL3DataTableLeaFir_Temp_Min.ColumnName = "LeaFir_Temp_Min";
            this.coldsProcL3DataTableLeaFir_Temp_Min.DataType = typeof(int);
            this.coldsProcL3DataTableLeaFir_Temp_Min.Namespace = "";
            // 
            // coldsProcL3DataTableLeaFir_Temp_Max
            // 
            this.coldsProcL3DataTableLeaFir_Temp_Max.Caption = "LeaFir_Temp_Max";
            this.coldsProcL3DataTableLeaFir_Temp_Max.ColumnName = "LeaFir_Temp_Max";
            this.coldsProcL3DataTableLeaFir_Temp_Max.DataType = typeof(int);
            this.coldsProcL3DataTableLeaFir_Temp_Max.Namespace = "";
            // 
            // coldsProcL3DataTableLea_Temp_Aim
            // 
            this.coldsProcL3DataTableLea_Temp_Aim.Caption = "Lea_Temp_Aim";
            this.coldsProcL3DataTableLea_Temp_Aim.ColumnName = "Lea_Temp_Aim";
            this.coldsProcL3DataTableLea_Temp_Aim.DataType = typeof(int);
            this.coldsProcL3DataTableLea_Temp_Aim.Namespace = "";
            // 
            // coldsProcL3DataTableLea_Temp_Min
            // 
            this.coldsProcL3DataTableLea_Temp_Min.Caption = "Lea_Temp_Min";
            this.coldsProcL3DataTableLea_Temp_Min.ColumnName = "Lea_Temp_Min";
            this.coldsProcL3DataTableLea_Temp_Min.DataType = typeof(int);
            this.coldsProcL3DataTableLea_Temp_Min.Namespace = "";
            // 
            // coldsProcL3DataTableLea_Temp_Max
            // 
            this.coldsProcL3DataTableLea_Temp_Max.Caption = "Lea_Temp_Max";
            this.coldsProcL3DataTableLea_Temp_Max.ColumnName = "Lea_Temp_Max";
            this.coldsProcL3DataTableLea_Temp_Max.DataType = typeof(int);
            this.coldsProcL3DataTableLea_Temp_Max.Namespace = "";
            // 
            // coldsProcL3DataTableDepth_Min
            // 
            this.coldsProcL3DataTableDepth_Min.Caption = "Depth_Min";
            this.coldsProcL3DataTableDepth_Min.ColumnName = "Depth_Min";
            this.coldsProcL3DataTableDepth_Min.Namespace = "";
            // 
            // coldsProcL3DataTableDepth_Max
            // 
            this.coldsProcL3DataTableDepth_Max.Caption = "Depth_Max";
            this.coldsProcL3DataTableDepth_Max.ColumnName = "Depth_Max";
            this.coldsProcL3DataTableDepth_Max.Namespace = "";
            // 
            // coldsProcL3DataTableVacuum_Min
            // 
            this.coldsProcL3DataTableVacuum_Min.Caption = "Vacuum_Min";
            this.coldsProcL3DataTableVacuum_Min.ColumnName = "Vacuum_Min";
            this.coldsProcL3DataTableVacuum_Min.Namespace = "";
            // 
            // coldsProcL3DataTableVacuum_Max
            // 
            this.coldsProcL3DataTableVacuum_Max.Caption = "Vacuum_Max";
            this.coldsProcL3DataTableVacuum_Max.ColumnName = "Vacuum_Max";
            this.coldsProcL3DataTableVacuum_Max.Namespace = "";
            // 
            // coldsProcL3DataTableUp_Blow_Min
            // 
            this.coldsProcL3DataTableUp_Blow_Min.Caption = "Up_Blow_Min";
            this.coldsProcL3DataTableUp_Blow_Min.ColumnName = "Up_Blow_Min";
            this.coldsProcL3DataTableUp_Blow_Min.Namespace = "";
            // 
            // coldsProcL3DataTableUp_Blow_Aim
            // 
            this.coldsProcL3DataTableUp_Blow_Aim.Caption = "Up_Blow_Aim";
            this.coldsProcL3DataTableUp_Blow_Aim.ColumnName = "Up_Blow_Aim";
            this.coldsProcL3DataTableUp_Blow_Aim.Namespace = "";
            // 
            // coldsProcL3DataTableUp_Blow_Max
            // 
            this.coldsProcL3DataTableUp_Blow_Max.Caption = "Up_Blow_Max";
            this.coldsProcL3DataTableUp_Blow_Max.ColumnName = "Up_Blow_Max";
            this.coldsProcL3DataTableUp_Blow_Max.Namespace = "";
            // 
            // coldsProcL3DataTableDec_Flag
            // 
            this.coldsProcL3DataTableDec_Flag.Caption = "Dec_Flag";
            this.coldsProcL3DataTableDec_Flag.ColumnName = "Dec_Flag";
            this.coldsProcL3DataTableDec_Flag.DataType = typeof(int);
            this.coldsProcL3DataTableDec_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableDec_Time_Min
            // 
            this.coldsProcL3DataTableDec_Time_Min.Caption = "Dec_Time_Min";
            this.coldsProcL3DataTableDec_Time_Min.ColumnName = "Dec_Time_Min";
            this.coldsProcL3DataTableDec_Time_Min.DataType = typeof(int);
            this.coldsProcL3DataTableDec_Time_Min.Namespace = "";
            // 
            // coldsProcL3DataTableDec_Time_Max
            // 
            this.coldsProcL3DataTableDec_Time_Max.Caption = "Dec_Time_Max";
            this.coldsProcL3DataTableDec_Time_Max.ColumnName = "Dec_Time_Max";
            this.coldsProcL3DataTableDec_Time_Max.DataType = typeof(int);
            this.coldsProcL3DataTableDec_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTablePure_Time_Min
            // 
            this.coldsProcL3DataTablePure_Time_Min.Caption = "Pure_Time_Min";
            this.coldsProcL3DataTablePure_Time_Min.ColumnName = "Pure_Time_Min";
            this.coldsProcL3DataTablePure_Time_Min.DataType = typeof(int);
            this.coldsProcL3DataTablePure_Time_Min.Namespace = "";
            // 
            // coldsProcL3DataTablePure_Time_Max
            // 
            this.coldsProcL3DataTablePure_Time_Max.Caption = "Pure_Time_Max";
            this.coldsProcL3DataTablePure_Time_Max.ColumnName = "Pure_Time_Max";
            this.coldsProcL3DataTablePure_Time_Max.DataType = typeof(int);
            this.coldsProcL3DataTablePure_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTableVacuum_Time_Min
            // 
            this.coldsProcL3DataTableVacuum_Time_Min.Caption = "Vacuum_Time_Min";
            this.coldsProcL3DataTableVacuum_Time_Min.ColumnName = "Vacuum_Time_Min";
            this.coldsProcL3DataTableVacuum_Time_Min.DataType = typeof(int);
            this.coldsProcL3DataTableVacuum_Time_Min.Namespace = "";
            // 
            // coldsProcL3DataTableProc_Time_Min
            // 
            this.coldsProcL3DataTableProc_Time_Min.Caption = "Proc_Time_Min";
            this.coldsProcL3DataTableProc_Time_Min.ColumnName = "Proc_Time_Min";
            this.coldsProcL3DataTableProc_Time_Min.DataType = typeof(int);
            this.coldsProcL3DataTableProc_Time_Min.Namespace = "";
            // 
            // coldsProcL3DataTableOxy_Flag
            // 
            this.coldsProcL3DataTableOxy_Flag.Caption = "Oxy_Flag";
            this.coldsProcL3DataTableOxy_Flag.ColumnName = "Oxy_Flag";
            this.coldsProcL3DataTableOxy_Flag.DataType = typeof(int);
            this.coldsProcL3DataTableOxy_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableH_Flag
            // 
            this.coldsProcL3DataTableH_Flag.Caption = "H_Flag";
            this.coldsProcL3DataTableH_Flag.ColumnName = "H_Flag";
            this.coldsProcL3DataTableH_Flag.DataType = typeof(int);
            this.coldsProcL3DataTableH_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableSoft_Blow_Flag
            // 
            this.coldsProcL3DataTableSoft_Blow_Flag.Caption = "Soft_Blow_Flag";
            this.coldsProcL3DataTableSoft_Blow_Flag.ColumnName = "Soft_Blow_Flag";
            this.coldsProcL3DataTableSoft_Blow_Flag.DataType = typeof(int);
            this.coldsProcL3DataTableSoft_Blow_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableCalm_Flag
            // 
            this.coldsProcL3DataTableCalm_Flag.Caption = "Calm_Flag";
            this.coldsProcL3DataTableCalm_Flag.ColumnName = "Calm_Flag";
            this.coldsProcL3DataTableCalm_Flag.DataType = typeof(int);
            this.coldsProcL3DataTableCalm_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableAl_Hot_Flag
            // 
            this.coldsProcL3DataTableAl_Hot_Flag.Caption = "Al_Hot_Flag";
            this.coldsProcL3DataTableAl_Hot_Flag.ColumnName = "Al_Hot_Flag";
            this.coldsProcL3DataTableAl_Hot_Flag.DataType = typeof(int);
            this.coldsProcL3DataTableAl_Hot_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableCold_Mat_Add
            // 
            this.coldsProcL3DataTableCold_Mat_Add.Caption = "Cold_Mat_Add";
            this.coldsProcL3DataTableCold_Mat_Add.ColumnName = "Cold_Mat_Add";
            this.coldsProcL3DataTableCold_Mat_Add.Namespace = "";
            // 
            // coldsProcL3DataTableHold_Steel_Time_Max
            // 
            this.coldsProcL3DataTableHold_Steel_Time_Max.Caption = "Hold_Steel_Time_Max";
            this.coldsProcL3DataTableHold_Steel_Time_Max.ColumnName = "Hold_Steel_Time_Max";
            this.coldsProcL3DataTableHold_Steel_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTableStay_Steel_Time_Max
            // 
            this.coldsProcL3DataTableStay_Steel_Time_Max.Caption = "Stay_Steel_Time_Max";
            this.coldsProcL3DataTableStay_Steel_Time_Max.ColumnName = "Stay_Steel_Time_Max";
            this.coldsProcL3DataTableStay_Steel_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTablePure_DeO_Time_Min
            // 
            this.coldsProcL3DataTablePure_DeO_Time_Min.Caption = "Pure_DeO_Time_Min";
            this.coldsProcL3DataTablePure_DeO_Time_Min.ColumnName = "Pure_DeO_Time_Min";
            this.coldsProcL3DataTablePure_DeO_Time_Min.DataType = typeof(int);
            this.coldsProcL3DataTablePure_DeO_Time_Min.Namespace = "";
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // bsProc
            // 
            this.bsProc.DataMember = "L3DataTable";
            this.bsProc.DataSource = this.dsProc;
            // 
            // tabFeed
            // 
            this.tabFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabFeed.Controls.Add(this.hmiRootPanelFeed);
            this.tabFeed.Location = new System.Drawing.Point(4, 21);
            this.tabFeed.Name = "tabFeed";
            this.tabFeed.Size = new System.Drawing.Size(1012, 587);
            this.tabFeed.TabIndex = 4;
            this.tabFeed.Text = "炉后喂丝信息";
            this.tabFeed.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanelFeed
            // 
            this.hmiRootPanelFeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelFeed.Controls.Add(this.dvFeed);
            this.hmiRootPanelFeed.Controls.Add(this.bNavigatorFeed);
            this.hmiRootPanelFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelFeed.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanelFeed.Name = "hmiRootPanelFeed";
            this.hmiRootPanelFeed.Size = new System.Drawing.Size(1010, 585);
            this.hmiRootPanelFeed.TabIndex = 27;
            // 
            // dvFeed
            // 
            this.dvFeed.AllowUserToAddRows = false;
            this.dvFeed.AutoGenerateColumns = false;
            this.dvFeed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvFeed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvFeed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn1,
            this.caProcCodeDataGridViewTextBoxColumn,
            this.caProcCodeWeightMaxDataGridViewTextBoxColumn,
            this.caProcCodeWeightMinDataGridViewTextBoxColumn});
            this.dvFeed.DataSource = this.bsFeed;
            this.dvFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFeed.Location = new System.Drawing.Point(0, 25);
            this.dvFeed.Name = "dvFeed";
            this.dvFeed.RowTemplate.Height = 23;
            this.dvFeed.Size = new System.Drawing.Size(1006, 556);
            this.dvFeed.TabIndex = 1;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn1
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn1.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn1.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn1.Name = "steelGradeIndexDataGridViewTextBoxColumn1";
            this.steelGradeIndexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn1.Width = 78;
            // 
            // caProcCodeDataGridViewTextBoxColumn
            // 
            this.caProcCodeDataGridViewTextBoxColumn.DataPropertyName = "CaProc_Code";
            this.caProcCodeDataGridViewTextBoxColumn.HeaderText = "Ca处理喂丝线";
            this.caProcCodeDataGridViewTextBoxColumn.Name = "caProcCodeDataGridViewTextBoxColumn";
            this.caProcCodeDataGridViewTextBoxColumn.Width = 102;
            // 
            // caProcCodeWeightMaxDataGridViewTextBoxColumn
            // 
            this.caProcCodeWeightMaxDataGridViewTextBoxColumn.DataPropertyName = "CaProc_Code_Weight_Max";
            this.caProcCodeWeightMaxDataGridViewTextBoxColumn.HeaderText = "Ca处理喂线喂入量最大";
            this.caProcCodeWeightMaxDataGridViewTextBoxColumn.Name = "caProcCodeWeightMaxDataGridViewTextBoxColumn";
            this.caProcCodeWeightMaxDataGridViewTextBoxColumn.Width = 150;
            // 
            // caProcCodeWeightMinDataGridViewTextBoxColumn
            // 
            this.caProcCodeWeightMinDataGridViewTextBoxColumn.DataPropertyName = "CaProc_Code_Weight_Min";
            this.caProcCodeWeightMinDataGridViewTextBoxColumn.HeaderText = "Ca处理喂线喂入量最小";
            this.caProcCodeWeightMinDataGridViewTextBoxColumn.Name = "caProcCodeWeightMinDataGridViewTextBoxColumn";
            this.caProcCodeWeightMinDataGridViewTextBoxColumn.Width = 150;
            // 
            // bNavigatorFeed
            // 
            this.bNavigatorFeed.AddNewItem = null;
            this.bNavigatorFeed.BindingSource = this.bsFeed;
            this.bNavigatorFeed.CountItem = this.bindingNavigatorCountItem1;
            this.bNavigatorFeed.DeleteItem = null;
            this.bNavigatorFeed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.btnAddFeed,
            this.btnDelFeed});
            this.bNavigatorFeed.Location = new System.Drawing.Point(0, 0);
            this.bNavigatorFeed.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bNavigatorFeed.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bNavigatorFeed.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bNavigatorFeed.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bNavigatorFeed.Name = "bNavigatorFeed";
            this.bNavigatorFeed.PositionItem = this.bindingNavigatorPositionItem1;
            this.bNavigatorFeed.Size = new System.Drawing.Size(1006, 25);
            this.bNavigatorFeed.TabIndex = 0;
            this.bNavigatorFeed.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "/ {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "位置";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tabAlloy
            // 
            this.tabAlloy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAlloy.Controls.Add(this.hmiRootPanelAlloy);
            this.tabAlloy.Location = new System.Drawing.Point(4, 21);
            this.tabAlloy.Name = "tabAlloy";
            this.tabAlloy.Size = new System.Drawing.Size(1012, 587);
            this.tabAlloy.TabIndex = 3;
            this.tabAlloy.Text = "合金信息";
            this.tabAlloy.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanelAlloy
            // 
            this.hmiRootPanelAlloy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelAlloy.Controls.Add(this.dvAlloy);
            this.hmiRootPanelAlloy.Controls.Add(this.bNavigatorAlloy);
            this.hmiRootPanelAlloy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelAlloy.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanelAlloy.Name = "hmiRootPanelAlloy";
            this.hmiRootPanelAlloy.Size = new System.Drawing.Size(1010, 585);
            this.hmiRootPanelAlloy.TabIndex = 25;
            // 
            // dvAlloy
            // 
            this.dvAlloy.AllowUserToAddRows = false;
            this.dvAlloy.AutoGenerateColumns = false;
            this.dvAlloy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvAlloy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvAlloy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAlloy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.alloyFlagDataGridViewTextBoxColumn,
            this.alloyCodeDataGridViewTextBoxColumn,
            this.alloyYieldDataGridViewTextBoxColumn});
            this.dvAlloy.DataSource = this.bsAlloy;
            this.dvAlloy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAlloy.Location = new System.Drawing.Point(0, 25);
            this.dvAlloy.Name = "dvAlloy";
            this.dvAlloy.RowTemplate.Height = 23;
            this.dvAlloy.Size = new System.Drawing.Size(1006, 556);
            this.dvAlloy.TabIndex = 1;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // alloyFlagDataGridViewTextBoxColumn
            // 
            this.alloyFlagDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Flag";
            this.alloyFlagDataGridViewTextBoxColumn.HeaderText = "合金化否";
            this.alloyFlagDataGridViewTextBoxColumn.Name = "alloyFlagDataGridViewTextBoxColumn";
            this.alloyFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // alloyCodeDataGridViewTextBoxColumn
            // 
            this.alloyCodeDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Code";
            this.alloyCodeDataGridViewTextBoxColumn.HeaderText = "合金牌号";
            this.alloyCodeDataGridViewTextBoxColumn.Name = "alloyCodeDataGridViewTextBoxColumn";
            this.alloyCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // alloyYieldDataGridViewTextBoxColumn
            // 
            this.alloyYieldDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Yield";
            this.alloyYieldDataGridViewTextBoxColumn.HeaderText = "合金收得率";
            this.alloyYieldDataGridViewTextBoxColumn.Name = "alloyYieldDataGridViewTextBoxColumn";
            this.alloyYieldDataGridViewTextBoxColumn.Width = 90;
            // 
            // bNavigatorAlloy
            // 
            this.bNavigatorAlloy.AddNewItem = null;
            this.bNavigatorAlloy.BindingSource = this.bsAlloy;
            this.bNavigatorAlloy.CountItem = this.bindingNavigatorCountItem;
            this.bNavigatorAlloy.DeleteItem = this.btnDelAlloy;
            this.bNavigatorAlloy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAddAlloy,
            this.btnDelAlloy});
            this.bNavigatorAlloy.Location = new System.Drawing.Point(0, 0);
            this.bNavigatorAlloy.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigatorAlloy.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigatorAlloy.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNavigatorAlloy.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNavigatorAlloy.Name = "bNavigatorAlloy";
            this.bNavigatorAlloy.PositionItem = this.bindingNavigatorPositionItem;
            this.bNavigatorAlloy.Size = new System.Drawing.Size(1006, 25);
            this.bNavigatorAlloy.TabIndex = 0;
            this.bNavigatorAlloy.Text = "bindingNavigator1";
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
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.rtxtNote);
            this.tabBase.Controls.Add(this.dtValidDate);
            this.tabBase.Controls.Add(this.txtNewCode);
            this.tabBase.Controls.Add(this.txtSteelGradeIndexBase);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.label1);
            this.tabBase.Location = new System.Drawing.Point(4, 21);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(1012, 587);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本信息";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(137, 100);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(866, 449);
            this.rtxtNote.TabIndex = 3;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // dtValidDate
            // 
            this.dtValidDate.CustomFormat = "yyyy-MM-dd";
            this.dtValidDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBase, "Valid_Date", true));
            this.dtValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtValidDate.Location = new System.Drawing.Point(137, 45);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(181, 21);
            this.dtValidDate.TabIndex = 1;
            // 
            // txtNewCode
            // 
            this.txtNewCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "New_Code", true));
            //
            this.txtNewCode.EnableNull = true;
            this.txtNewCode.ErropPr = null;
            //
            this.txtNewCode.Length = 0;
            this.txtNewCode.Location = new System.Drawing.Point(137, 72);
            this.txtNewCode.Max = 0;
            //
            //
            this.txtNewCode.MaxStrLength = 0;
            this.txtNewCode.Min = 0;
            //
            //
            this.txtNewCode.MinStrLength = 0;
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Precision = 0;
            //
            this.txtNewCode.Size = new System.Drawing.Size(181, 21);
            this.txtNewCode.TabIndex = 2;
            this.txtNewCode.ToolTipValid = null;
          //
            this.txtNewCode.ValidEable = true;
            this.txtNewCode.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSteelGradeIndexBase
            // 
            this.txtSteelGradeIndexBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexBase.EnableNull = false;
            this.txtSteelGradeIndexBase.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexBase.Length = 8;
            this.txtSteelGradeIndexBase.Location = new System.Drawing.Point(137, 17);
            this.txtSteelGradeIndexBase.Max = 0;
            this.txtSteelGradeIndexBase.MaxLength = 8;
            //
            //
            this.txtSteelGradeIndexBase.MaxStrLength = 0;
            this.txtSteelGradeIndexBase.Min = 0;
            //
            //
            this.txtSteelGradeIndexBase.MinStrLength = 0;
            this.txtSteelGradeIndexBase.Name = "txtSteelGradeIndexBase";
            this.txtSteelGradeIndexBase.Precision = 0;
            this.txtSteelGradeIndexBase.ReadOnly = true;
            //
            this.txtSteelGradeIndexBase.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexBase.TabIndex = 0;
            this.txtSteelGradeIndexBase.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexBase.ValidEable = true;
            this.txtSteelGradeIndexBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "生效日期:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "说明:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "新试号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炼钢记号:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabBase);
            this.tabControlMain.Controls.Add(this.tabProc);
            this.tabControlMain.Controls.Add(this.tabAlloy);
            this.tabControlMain.Controls.Add(this.tabFeed);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 68);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1020, 612);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabProc
            // 
            this.tabProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProc.Controls.Add(this.groupBox1);
            this.tabProc.Controls.Add(this.panel1);
            this.tabProc.Controls.Add(this.groupBox6);
            this.tabProc.Location = new System.Drawing.Point(4, 21);
            this.tabProc.Name = "tabProc";
            this.tabProc.Size = new System.Drawing.Size(1012, 587);
            this.tabProc.TabIndex = 12;
            this.tabProc.Text = "处理信息";
            this.tabProc.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStaySteelTimeMax);
            this.groupBox1.Controls.Add(this.txtPureDeOTimeMin);
            this.groupBox1.Controls.Add(this.txtHoldSteelTimeMax);
            this.groupBox1.Controls.Add(this.txtColdMatAdd);
            this.groupBox1.Controls.Add(this.txtProcTimeMin);
            this.groupBox1.Controls.Add(this.txtVacuumTimeMin);
            this.groupBox1.Controls.Add(this.txtPureTimeMax);
            this.groupBox1.Controls.Add(this.txtPureTimeMin);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.cmbAlHotFlag);
            this.groupBox1.Controls.Add(this.cmbCalm_Flag);
            this.groupBox1.Controls.Add(this.cmbSoftBlowFlag);
            this.groupBox1.Controls.Add(this.cmbHFlag);
            this.groupBox1.Controls.Add(this.cmbOxyFlag);
            this.groupBox1.Controls.Add(this.cmbDec_Flag);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.txtDecTimeMax);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.txtDecTimeMin);
            this.groupBox1.Controls.Add(this.label37);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtStaySteelTimeMax
            // 
            this.txtStaySteelTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Stay_Steel_Time_Max", true));
            //
            this.txtStaySteelTimeMax.EnableNull = false;
            this.txtStaySteelTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtStaySteelTimeMax.Length = 0;
            this.txtStaySteelTimeMax.Location = new System.Drawing.Point(854, 65);
            this.txtStaySteelTimeMax.Max = 9999;
            //
            //
            this.txtStaySteelTimeMax.MaxStrLength = 0;
            this.txtStaySteelTimeMax.Min = 0;
            //
            //
            this.txtStaySteelTimeMax.MinStrLength = 0;
            this.txtStaySteelTimeMax.Name = "txtStaySteelTimeMax";
            this.txtStaySteelTimeMax.Precision = 0;
            //
            this.txtStaySteelTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtStaySteelTimeMax.TabIndex = 14;
            this.txtStaySteelTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtStaySteelTimeMax.ValidEable = true;
            this.txtStaySteelTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPureDeOTimeMin
            // 
            this.txtPureDeOTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Pure_DeO_Time_Min", true));
            //
            this.txtPureDeOTimeMin.EnableNull = false;
            this.txtPureDeOTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtPureDeOTimeMin.Length = 0;
            this.txtPureDeOTimeMin.Location = new System.Drawing.Point(854, 91);
            this.txtPureDeOTimeMin.Max = 9999;
            //
            //
            this.txtPureDeOTimeMin.MaxStrLength = 0;
            this.txtPureDeOTimeMin.Min = 0;
            //
            //
            this.txtPureDeOTimeMin.MinStrLength = 0;
            this.txtPureDeOTimeMin.Name = "txtPureDeOTimeMin";
            this.txtPureDeOTimeMin.Precision = 0;
            //
            this.txtPureDeOTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtPureDeOTimeMin.TabIndex = 15;
            this.txtPureDeOTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtPureDeOTimeMin.ValidEable = true;
            this.txtPureDeOTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtHoldSteelTimeMax
            // 
            this.txtHoldSteelTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Hold_Steel_Time_Max", true));
            //
            this.txtHoldSteelTimeMax.EnableNull = false;
            this.txtHoldSteelTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtHoldSteelTimeMax.Length = 0;
            this.txtHoldSteelTimeMax.Location = new System.Drawing.Point(854, 39);
            this.txtHoldSteelTimeMax.Max = 9999;
            //
            //
            this.txtHoldSteelTimeMax.MaxStrLength = 0;
            this.txtHoldSteelTimeMax.Min = 0;
            //
            //
            this.txtHoldSteelTimeMax.MinStrLength = 0;
            this.txtHoldSteelTimeMax.Name = "txtHoldSteelTimeMax";
            this.txtHoldSteelTimeMax.Precision = 0;
            //
            this.txtHoldSteelTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtHoldSteelTimeMax.TabIndex = 13;
            this.txtHoldSteelTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtHoldSteelTimeMax.ValidEable = true;
            this.txtHoldSteelTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtColdMatAdd
            // 
            this.txtColdMatAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Cold_Mat_Add", true));
            //
            this.txtColdMatAdd.EnableNull = false;
            this.txtColdMatAdd.ErropPr = this.errorProvider1;
            //
            this.txtColdMatAdd.Length = 0;
            this.txtColdMatAdd.Location = new System.Drawing.Point(854, 13);
            this.txtColdMatAdd.Max = 9999;
            //
            //
            this.txtColdMatAdd.MaxStrLength = 0;
            this.txtColdMatAdd.Min = 0;
            //
            //
            this.txtColdMatAdd.MinStrLength = 0;
            this.txtColdMatAdd.Name = "txtColdMatAdd";
            this.txtColdMatAdd.Precision = 0;
            //
            this.txtColdMatAdd.Size = new System.Drawing.Size(100, 21);
            this.txtColdMatAdd.TabIndex = 12;
            this.txtColdMatAdd.ToolTipValid = this.toolTip1;
          //
            this.txtColdMatAdd.ValidEable = true;
            this.txtColdMatAdd.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtProcTimeMin
            // 
            this.txtProcTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Proc_Time_Min", true));
            //
            this.txtProcTimeMin.EnableNull = false;
            this.txtProcTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtProcTimeMin.Length = 0;
            this.txtProcTimeMin.Location = new System.Drawing.Point(346, 65);
            this.txtProcTimeMin.Max = 9999;
            //
            //
            this.txtProcTimeMin.MaxStrLength = 0;
            this.txtProcTimeMin.Min = 0;
            //
            //
            this.txtProcTimeMin.MinStrLength = 0;
            this.txtProcTimeMin.Name = "txtProcTimeMin";
            this.txtProcTimeMin.Precision = 0;
            //
            this.txtProcTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtProcTimeMin.TabIndex = 6;
            this.txtProcTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtProcTimeMin.ValidEable = true;
            this.txtProcTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtVacuumTimeMin
            // 
            this.txtVacuumTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Vacuum_Time_Min", true));
            //
            this.txtVacuumTimeMin.EnableNull = false;
            this.txtVacuumTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtVacuumTimeMin.Length = 0;
            this.txtVacuumTimeMin.Location = new System.Drawing.Point(346, 39);
            this.txtVacuumTimeMin.Max = 9999;
            //
            //
            this.txtVacuumTimeMin.MaxStrLength = 0;
            this.txtVacuumTimeMin.Min = 0;
            //
            //
            this.txtVacuumTimeMin.MinStrLength = 0;
            this.txtVacuumTimeMin.Name = "txtVacuumTimeMin";
            this.txtVacuumTimeMin.Precision = 0;
            //
            this.txtVacuumTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtVacuumTimeMin.TabIndex = 5;
            this.txtVacuumTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtVacuumTimeMin.ValidEable = true;
            this.txtVacuumTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtPureTimeMax
            // 
            this.txtPureTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Pure_Time_Max", true));
            //
            this.txtPureTimeMax.EnableNull = false;
            this.txtPureTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtPureTimeMax.Length = 0;
            this.txtPureTimeMax.Location = new System.Drawing.Point(346, 13);
            this.txtPureTimeMax.Max = 9999;
            //
            //
            this.txtPureTimeMax.MaxStrLength = 0;
            this.txtPureTimeMax.Min = 0;
            //
            //
            this.txtPureTimeMax.MinStrLength = 0;
            this.txtPureTimeMax.Name = "txtPureTimeMax";
            this.txtPureTimeMax.Precision = 0;
            //
            this.txtPureTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtPureTimeMax.TabIndex = 4;
            this.txtPureTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtPureTimeMax.ValidEable = true;
            this.txtPureTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtPureTimeMax.TextChanged += new System.EventHandler(this.txtPureTimeMax_TextChanged);
            // 
            // txtPureTimeMin
            // 
            this.txtPureTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Pure_Time_Min", true));
            //
            this.txtPureTimeMin.EnableNull = false;
            this.txtPureTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtPureTimeMin.Length = 0;
            this.txtPureTimeMin.Location = new System.Drawing.Point(101, 94);
            this.txtPureTimeMin.Max = 9999;
            //
            //
            this.txtPureTimeMin.MaxStrLength = 0;
            this.txtPureTimeMin.Min = 0;
            //
            //
            this.txtPureTimeMin.MinStrLength = 0;
            this.txtPureTimeMin.Name = "txtPureTimeMin";
            this.txtPureTimeMin.Precision = 0;
            //
            this.txtPureTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtPureTimeMin.TabIndex = 3;
            this.txtPureTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtPureTimeMin.ValidEable = true;
            this.txtPureTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(245, 17);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(95, 12);
            this.label46.TabIndex = 2;
            this.label46.Text = "纯处理时间最大:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(753, 95);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(95, 12);
            this.label41.TabIndex = 2;
            this.label41.Text = "纯脱气时间最小:";
            // 
            // cmbAlHotFlag
            // 
            this.cmbAlHotFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAlHotFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlHotFlag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAlHotFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Al_Hot_Flag", true));
            this.cmbAlHotFlag.EnableNull = false;
            this.cmbAlHotFlag.ErropPr = this.errorProvider1;
            this.cmbAlHotFlag.FormattingEnabled = true;
            this.cmbAlHotFlag.Location = new System.Drawing.Point(563, 91);
            this.cmbAlHotFlag.Name = "cmbAlHotFlag";
            //
            this.cmbAlHotFlag.Size = new System.Drawing.Size(100, 20);
            this.cmbAlHotFlag.TabIndex = 11;
            //
            this.cmbAlHotFlag.ToolTipValid = this.toolTip1;
            this.cmbAlHotFlag.ValidEable = true;
            // 
            // cmbCalm_Flag
            // 
            this.cmbCalm_Flag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCalm_Flag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCalm_Flag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbCalm_Flag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Calm_Flag", true));
            this.cmbCalm_Flag.EnableNull = false;
            this.cmbCalm_Flag.ErropPr = this.errorProvider1;
            this.cmbCalm_Flag.FormattingEnabled = true;
            this.cmbCalm_Flag.Location = new System.Drawing.Point(563, 65);
            this.cmbCalm_Flag.Name = "cmbCalm_Flag";
            //
            this.cmbCalm_Flag.Size = new System.Drawing.Size(100, 20);
            this.cmbCalm_Flag.TabIndex = 10;
            //
            this.cmbCalm_Flag.ToolTipValid = this.toolTip1;
            this.cmbCalm_Flag.ValidEable = true;
            // 
            // cmbSoftBlowFlag
            // 
            this.cmbSoftBlowFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSoftBlowFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSoftBlowFlag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSoftBlowFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Soft_Blow_Flag", true));
            this.cmbSoftBlowFlag.EnableNull = false;
            this.cmbSoftBlowFlag.ErropPr = this.errorProvider1;
            this.cmbSoftBlowFlag.FormattingEnabled = true;
            this.cmbSoftBlowFlag.Location = new System.Drawing.Point(563, 39);
            this.cmbSoftBlowFlag.Name = "cmbSoftBlowFlag";
            //
            this.cmbSoftBlowFlag.Size = new System.Drawing.Size(100, 20);
            this.cmbSoftBlowFlag.TabIndex = 9;
            //
            this.cmbSoftBlowFlag.ToolTipValid = this.toolTip1;
            this.cmbSoftBlowFlag.ValidEable = true;
            // 
            // cmbHFlag
            // 
            this.cmbHFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHFlag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbHFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "H_Flag", true));
            this.cmbHFlag.EnableNull = false;
            this.cmbHFlag.ErropPr = this.errorProvider1;
            this.cmbHFlag.FormattingEnabled = true;
            this.cmbHFlag.Location = new System.Drawing.Point(563, 13);
            this.cmbHFlag.Name = "cmbHFlag";
            //
            this.cmbHFlag.Size = new System.Drawing.Size(100, 20);
            this.cmbHFlag.TabIndex = 8;
            //
            this.cmbHFlag.ToolTipValid = this.toolTip1;
            this.cmbHFlag.ValidEable = true;
            // 
            // cmbOxyFlag
            // 
            this.cmbOxyFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOxyFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOxyFlag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbOxyFlag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Oxy_Flag", true));
            this.cmbOxyFlag.EnableNull = false;
            this.cmbOxyFlag.ErropPr = this.errorProvider1;
            this.cmbOxyFlag.FormattingEnabled = true;
            this.cmbOxyFlag.Location = new System.Drawing.Point(346, 91);
            this.cmbOxyFlag.Name = "cmbOxyFlag";
            //
            this.cmbOxyFlag.Size = new System.Drawing.Size(100, 20);
            this.cmbOxyFlag.TabIndex = 7;
            //
            this.cmbOxyFlag.ToolTipValid = this.toolTip1;
            this.cmbOxyFlag.ValidEable = true;
            // 
            // cmbDec_Flag
            // 
            this.cmbDec_Flag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDec_Flag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDec_Flag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbDec_Flag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Dec_Flag", true));
            this.cmbDec_Flag.EnableNull = false;
            this.cmbDec_Flag.ErropPr = this.errorProvider1;
            this.cmbDec_Flag.FormattingEnabled = true;
            this.cmbDec_Flag.Location = new System.Drawing.Point(101, 14);
            this.cmbDec_Flag.Name = "cmbDec_Flag";
            //
            this.cmbDec_Flag.Size = new System.Drawing.Size(100, 20);
            this.cmbDec_Flag.TabIndex = 0;
            //
            this.cmbDec_Flag.ToolTipValid = this.toolTip1;
            this.cmbDec_Flag.ValidEable = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(741, 69);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(107, 12);
            this.label40.TabIndex = 2;
            this.label40.Text = "进站等钢时间最大:";
            // 
            // txtDecTimeMax
            // 
            this.txtDecTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Dec_Time_Max", true));
            //
            this.txtDecTimeMax.EnableNull = false;
            this.txtDecTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtDecTimeMax.Length = 0;
            this.txtDecTimeMax.Location = new System.Drawing.Point(101, 67);
            this.txtDecTimeMax.Max = 9999;
            //
            //
            this.txtDecTimeMax.MaxStrLength = 0;
            this.txtDecTimeMax.Min = 0;
            //
            //
            this.txtDecTimeMax.MinStrLength = 0;
            this.txtDecTimeMax.Name = "txtDecTimeMax";
            this.txtDecTimeMax.Precision = 0;
            //
            this.txtDecTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtDecTimeMax.TabIndex = 2;
            this.txtDecTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtDecTimeMax.ValidEable = true;
            this.txtDecTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(741, 43);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(107, 12);
            this.label39.TabIndex = 2;
            this.label39.Text = "进站压钢时间最大:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(753, 17);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(95, 12);
            this.label38.TabIndex = 2;
            this.label38.Text = "冷料加入量基准:";
            // 
            // txtDecTimeMin
            // 
            this.txtDecTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Dec_Time_Min", true));
            //
            this.txtDecTimeMin.EnableNull = false;
            this.txtDecTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtDecTimeMin.Length = 0;
            this.txtDecTimeMin.Location = new System.Drawing.Point(101, 40);
            this.txtDecTimeMin.Max = 9999;
            //
            //
            this.txtDecTimeMin.MaxStrLength = 0;
            this.txtDecTimeMin.Min = 0;
            //
            //
            this.txtDecTimeMin.MinStrLength = 0;
            this.txtDecTimeMin.Name = "txtDecTimeMin";
            this.txtDecTimeMin.Precision = 0;
            //
            this.txtDecTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtDecTimeMin.TabIndex = 1;
            this.txtDecTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtDecTimeMin.ValidEable = true;
            this.txtDecTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(474, 95);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(83, 12);
            this.label37.TabIndex = 2;
            this.label37.Text = "允许AL加热否:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "纯处理时间最小:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(510, 69);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 12);
            this.label36.TabIndex = 2;
            this.label36.Text = "镇静否:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(41, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 2;
            this.label29.Text = "氧脱碳否:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(510, 43);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(47, 12);
            this.label35.TabIndex = 2;
            this.label35.Text = "软吹否:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "脱碳时间最小:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "定氢否:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(17, 69);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(83, 12);
            this.label45.TabIndex = 2;
            this.label45.Text = "脱碳时间最大:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(293, 95);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(47, 12);
            this.label33.TabIndex = 2;
            this.label33.Text = "定氧否:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(221, 43);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 12);
            this.label31.TabIndex = 2;
            this.label31.Text = "最低真空度保持时间:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(257, 69);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "处理时间最小:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 108);
            this.panel1.TabIndex = 10;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtVacuumMax);
            this.groupBox7.Controls.Add(this.txtUpBlowAim);
            this.groupBox7.Controls.Add(this.label30);
            this.groupBox7.Controls.Add(this.txtDepthMax);
            this.groupBox7.Controls.Add(this.txtUpBlowMax);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.txtUpBlowMin);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Controls.Add(this.txtVacuumMin);
            this.groupBox7.Controls.Add(this.txtDepthMin);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(403, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(607, 108);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // txtVacuumMax
            // 
            this.txtVacuumMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Vacuum_Max", true));
            //
            this.txtVacuumMax.EnableNull = false;
            this.txtVacuumMax.ErropPr = this.errorProvider1;
            //
            this.txtVacuumMax.Length = 0;
            this.txtVacuumMax.Location = new System.Drawing.Point(260, 71);
            this.txtVacuumMax.Max = 9999;
            //
            //
            this.txtVacuumMax.MaxStrLength = 0;
            this.txtVacuumMax.Min = 0;
            //
            //
            this.txtVacuumMax.MinStrLength = 0;
            this.txtVacuumMax.Name = "txtVacuumMax";
            this.txtVacuumMax.Precision = 0;
            //
            this.txtVacuumMax.Size = new System.Drawing.Size(100, 21);
            this.txtVacuumMax.TabIndex = 3;
            this.txtVacuumMax.ToolTipValid = this.toolTip1;
          //
            this.txtVacuumMax.ValidEable = true;
            this.txtVacuumMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtUpBlowAim
            // 
            this.txtUpBlowAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Up_Blow_Aim", true));
            //
            this.txtUpBlowAim.EnableNull = false;
            this.txtUpBlowAim.ErropPr = this.errorProvider1;
            //
            this.txtUpBlowAim.Length = 0;
            this.txtUpBlowAim.Location = new System.Drawing.Point(479, 43);
            this.txtUpBlowAim.Max = 99999;
            //
            //
            this.txtUpBlowAim.MaxStrLength = 0;
            this.txtUpBlowAim.Min = 0;
            //
            //
            this.txtUpBlowAim.MinStrLength = 0;
            this.txtUpBlowAim.Name = "txtUpBlowAim";
            this.txtUpBlowAim.Precision = 0;
            //
            this.txtUpBlowAim.Size = new System.Drawing.Size(100, 21);
            this.txtUpBlowAim.TabIndex = 5;
            this.txtUpBlowAim.ToolTipValid = this.toolTip1;
          //
            this.txtUpBlowAim.ValidEable = true;
            this.txtUpBlowAim.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(1, 75);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 12);
            this.label30.TabIndex = 2;
            this.label30.Text = "插入深度最大:";
            // 
            // txtDepthMax
            // 
            this.txtDepthMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Depth_Max", true));
            //
            this.txtDepthMax.EnableNull = false;
            this.txtDepthMax.ErropPr = this.errorProvider1;
            //
            this.txtDepthMax.Length = 0;
            this.txtDepthMax.Location = new System.Drawing.Point(84, 71);
            this.txtDepthMax.Max = 9999;
            //
            //
            this.txtDepthMax.MaxStrLength = 0;
            this.txtDepthMax.Min = 0;
            //
            //
            this.txtDepthMax.MinStrLength = 0;
            this.txtDepthMax.Name = "txtDepthMax";
            this.txtDepthMax.Precision = 0;
            //
            this.txtDepthMax.Size = new System.Drawing.Size(100, 21);
            this.txtDepthMax.TabIndex = 1;
            this.txtDepthMax.ToolTipValid = this.toolTip1;
          //
            this.txtDepthMax.ValidEable = true;
            this.txtDepthMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtUpBlowMax
            // 
            this.txtUpBlowMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Up_Blow_Max", true));
            //
            this.txtUpBlowMax.EnableNull = false;
            this.txtUpBlowMax.ErropPr = this.errorProvider1;
            //
            this.txtUpBlowMax.Length = 0;
            this.txtUpBlowMax.Location = new System.Drawing.Point(479, 70);
            this.txtUpBlowMax.Max = 99999;
            //
            //
            this.txtUpBlowMax.MaxStrLength = 0;
            this.txtUpBlowMax.Min = 0;
            //
            //
            this.txtUpBlowMax.MinStrLength = 0;
            this.txtUpBlowMax.Name = "txtUpBlowMax";
            this.txtUpBlowMax.Precision = 0;
            //
            this.txtUpBlowMax.Size = new System.Drawing.Size(100, 21);
            this.txtUpBlowMax.TabIndex = 6;
            this.txtUpBlowMax.ToolTipValid = this.toolTip1;
          //
            this.txtUpBlowMax.ValidEable = true;
            this.txtUpBlowMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "插入深度最小:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(187, 75);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 12);
            this.label42.TabIndex = 2;
            this.label42.Text = "真空度最大:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "真空度最小:";
            // 
            // txtUpBlowMin
            // 
            this.txtUpBlowMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Up_Blow_Min", true));
            //
            this.txtUpBlowMin.EnableNull = false;
            this.txtUpBlowMin.ErropPr = this.errorProvider1;
            //
            this.txtUpBlowMin.Length = 0;
            this.txtUpBlowMin.Location = new System.Drawing.Point(479, 15);
            this.txtUpBlowMin.Max = 99999;
            //
            //
            this.txtUpBlowMin.MaxStrLength = 0;
            this.txtUpBlowMin.Min = 0;
            //
            //
            this.txtUpBlowMin.MinStrLength = 0;
            this.txtUpBlowMin.Name = "txtUpBlowMin";
            this.txtUpBlowMin.Precision = 0;
            //
            this.txtUpBlowMin.Size = new System.Drawing.Size(100, 21);
            this.txtUpBlowMin.TabIndex = 4;
            this.txtUpBlowMin.ToolTipValid = this.toolTip1;
          //
            this.txtUpBlowMin.ValidEable = true;
            this.txtUpBlowMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "提升气体流量最小:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(366, 74);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(107, 12);
            this.label43.TabIndex = 2;
            this.label43.Text = "提升气体流量最大:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(366, 47);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(107, 12);
            this.label44.TabIndex = 2;
            this.label44.Text = "提升气体流量目标:";
            // 
            // txtVacuumMin
            // 
            this.txtVacuumMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Vacuum_Min", true));
            //
            this.txtVacuumMin.EnableNull = false;
            this.txtVacuumMin.ErropPr = this.errorProvider1;
            //
            this.txtVacuumMin.Length = 0;
            this.txtVacuumMin.Location = new System.Drawing.Point(260, 43);
            this.txtVacuumMin.Max = 9999;
            //
            //
            this.txtVacuumMin.MaxStrLength = 0;
            this.txtVacuumMin.Min = 0;
            //
            //
            this.txtVacuumMin.MinStrLength = 0;
            this.txtVacuumMin.Name = "txtVacuumMin";
            this.txtVacuumMin.Precision = 0;
            //
            this.txtVacuumMin.Size = new System.Drawing.Size(100, 21);
            this.txtVacuumMin.TabIndex = 2;
            this.txtVacuumMin.ToolTipValid = this.toolTip1;
          //
            this.txtVacuumMin.ValidEable = true;
            this.txtVacuumMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtDepthMin
            // 
            this.txtDepthMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Depth_Min", true));
            //
            this.txtDepthMin.EnableNull = false;
            this.txtDepthMin.ErropPr = this.errorProvider1;
            //
            this.txtDepthMin.Length = 0;
            this.txtDepthMin.Location = new System.Drawing.Point(84, 43);
            this.txtDepthMin.Max = 9999;
            //
            //
            this.txtDepthMin.MaxStrLength = 0;
            this.txtDepthMin.Min = 0;
            //
            //
            this.txtDepthMin.MinStrLength = 0;
            this.txtDepthMin.Name = "txtDepthMin";
            this.txtDepthMin.Precision = 0;
            //
            this.txtDepthMin.Size = new System.Drawing.Size(100, 21);
            this.txtDepthMin.TabIndex = 0;
            this.txtDepthMin.ToolTipValid = this.toolTip1;
          //
            this.txtDepthMin.ValidEable = true;
            this.txtDepthMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtLeaFirTempAim);
            this.groupBox5.Controls.Add(this.txtLeaTempAim);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.txtLeaTempMin);
            this.groupBox5.Controls.Add(this.txtLeaTempMax);
            this.groupBox5.Controls.Add(this.txtLeaFirTempMin);
            this.groupBox5.Controls.Add(this.txtLeaFirTempMax);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(403, 108);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RH离站温度";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "目标";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "最小";
            // 
            // txtLeaFirTempAim
            // 
            this.txtLeaFirTempAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "LeaFir_Temp_Aim", true));
            //
            this.txtLeaFirTempAim.EnableNull = false;
            this.txtLeaFirTempAim.ErropPr = this.errorProvider1;
            //
            this.txtLeaFirTempAim.Length = 0;
            this.txtLeaFirTempAim.Location = new System.Drawing.Point(86, 43);
            this.txtLeaFirTempAim.Max = 2000;
            //
            //
            this.txtLeaFirTempAim.MaxStrLength = 0;
            this.txtLeaFirTempAim.Min = 0;
            //
            //
            this.txtLeaFirTempAim.MinStrLength = 0;
            this.txtLeaFirTempAim.Name = "txtLeaFirTempAim";
            this.txtLeaFirTempAim.Precision = 0;
            //
            this.txtLeaFirTempAim.Size = new System.Drawing.Size(100, 21);
            this.txtLeaFirTempAim.TabIndex = 0;
            this.txtLeaFirTempAim.ToolTipValid = this.toolTip1;
          //
            this.txtLeaFirTempAim.ValidEable = true;
            this.txtLeaFirTempAim.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLeaTempAim
            // 
            this.txtLeaTempAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Lea_Temp_Aim", true));
            //
            this.txtLeaTempAim.EnableNull = false;
            this.txtLeaTempAim.ErropPr = this.errorProvider1;
            //
            this.txtLeaTempAim.Length = 0;
            this.txtLeaTempAim.Location = new System.Drawing.Point(86, 70);
            this.txtLeaTempAim.Max = 2000;
            //
            //
            this.txtLeaTempAim.MaxStrLength = 0;
            this.txtLeaTempAim.Min = 0;
            //
            //
            this.txtLeaTempAim.MinStrLength = 0;
            this.txtLeaTempAim.Name = "txtLeaTempAim";
            this.txtLeaTempAim.Precision = 0;
            //
            this.txtLeaTempAim.Size = new System.Drawing.Size(100, 21);
            this.txtLeaTempAim.TabIndex = 1;
            this.txtLeaTempAim.ToolTipValid = this.toolTip1;
          //
            this.txtLeaTempAim.ValidEable = true;
            this.txtLeaTempAim.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "最大";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 12);
            this.label26.TabIndex = 2;
            this.label26.Text = "连铸第一炉:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(33, 74);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 12);
            this.label27.TabIndex = 2;
            this.label27.Text = "连浇炉:";
            // 
            // txtLeaTempMin
            // 
            this.txtLeaTempMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Lea_Temp_Min", true));
            //
            this.txtLeaTempMin.EnableNull = false;
            this.txtLeaTempMin.ErropPr = this.errorProvider1;
            //
            this.txtLeaTempMin.Length = 0;
            this.txtLeaTempMin.Location = new System.Drawing.Point(192, 71);
            this.txtLeaTempMin.Max = 2000;
            //
            //
            this.txtLeaTempMin.MaxStrLength = 0;
            this.txtLeaTempMin.Min = 0;
            //
            //
            this.txtLeaTempMin.MinStrLength = 0;
            this.txtLeaTempMin.Name = "txtLeaTempMin";
            this.txtLeaTempMin.Precision = 0;
            //
            this.txtLeaTempMin.Size = new System.Drawing.Size(100, 21);
            this.txtLeaTempMin.TabIndex = 3;
            this.txtLeaTempMin.ToolTipValid = this.toolTip1;
          //
            this.txtLeaTempMin.ValidEable = true;
            this.txtLeaTempMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLeaTempMax
            // 
            this.txtLeaTempMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Lea_Temp_Max", true));
            //
            this.txtLeaTempMax.EnableNull = false;
            this.txtLeaTempMax.ErropPr = this.errorProvider1;
            //
            this.txtLeaTempMax.Length = 0;
            this.txtLeaTempMax.Location = new System.Drawing.Point(298, 71);
            this.txtLeaTempMax.Max = 2000;
            //
            //
            this.txtLeaTempMax.MaxStrLength = 0;
            this.txtLeaTempMax.Min = 0;
            //
            //
            this.txtLeaTempMax.MinStrLength = 0;
            this.txtLeaTempMax.Name = "txtLeaTempMax";
            this.txtLeaTempMax.Precision = 0;
            //
            this.txtLeaTempMax.Size = new System.Drawing.Size(100, 21);
            this.txtLeaTempMax.TabIndex = 5;
            this.txtLeaTempMax.ToolTipValid = this.toolTip1;
          //
            this.txtLeaTempMax.ValidEable = true;
            this.txtLeaTempMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLeaFirTempMin
            // 
            this.txtLeaFirTempMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "LeaFir_Temp_Min", true));
            //
            this.txtLeaFirTempMin.EnableNull = false;
            this.txtLeaFirTempMin.ErropPr = this.errorProvider1;
            //
            this.txtLeaFirTempMin.Length = 0;
            this.txtLeaFirTempMin.Location = new System.Drawing.Point(192, 44);
            this.txtLeaFirTempMin.Max = 2000;
            //
            //
            this.txtLeaFirTempMin.MaxStrLength = 0;
            this.txtLeaFirTempMin.Min = 0;
            //
            //
            this.txtLeaFirTempMin.MinStrLength = 0;
            this.txtLeaFirTempMin.Name = "txtLeaFirTempMin";
            this.txtLeaFirTempMin.Precision = 0;
            //
            this.txtLeaFirTempMin.Size = new System.Drawing.Size(100, 21);
            this.txtLeaFirTempMin.TabIndex = 2;
            this.txtLeaFirTempMin.ToolTipValid = this.toolTip1;
          //
            this.txtLeaFirTempMin.ValidEable = true;
            this.txtLeaFirTempMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLeaFirTempMax
            // 
            this.txtLeaFirTempMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "LeaFir_Temp_Max", true));
            //
            this.txtLeaFirTempMax.EnableNull = false;
            this.txtLeaFirTempMax.ErropPr = this.errorProvider1;
            //
            this.txtLeaFirTempMax.Length = 0;
            this.txtLeaFirTempMax.Location = new System.Drawing.Point(298, 44);
            this.txtLeaFirTempMax.Max = 2000;
            //
            //
            this.txtLeaFirTempMax.MaxStrLength = 0;
            this.txtLeaFirTempMax.Min = 0;
            //
            //
            this.txtLeaFirTempMax.MinStrLength = 0;
            this.txtLeaFirTempMax.Name = "txtLeaFirTempMax";
            this.txtLeaFirTempMax.Precision = 0;
            //
            this.txtLeaFirTempMax.Size = new System.Drawing.Size(100, 21);
            this.txtLeaFirTempMax.TabIndex = 4;
            this.txtLeaFirTempMax.ToolTipValid = this.toolTip1;
          //
            this.txtLeaFirTempMax.ValidEable = true;
            this.txtLeaFirTempMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.txtSteelGradeIndexPrco);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1010, 69);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 24);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "炼钢记号:";
            // 
            // txtSteelGradeIndexPrco
            // 
            this.txtSteelGradeIndexPrco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexPrco.EnableNull = false;
            this.txtSteelGradeIndexPrco.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexPrco.Length = 0;
            this.txtSteelGradeIndexPrco.Location = new System.Drawing.Point(86, 20);
            this.txtSteelGradeIndexPrco.Max = 0;
            //
            //
            this.txtSteelGradeIndexPrco.MaxStrLength = 0;
            this.txtSteelGradeIndexPrco.Min = 0;
            //
            //
            this.txtSteelGradeIndexPrco.MinStrLength = 0;
            this.txtSteelGradeIndexPrco.Name = "txtSteelGradeIndexPrco";
            this.txtSteelGradeIndexPrco.Precision = 0;
            this.txtSteelGradeIndexPrco.ReadOnly = true;
            //
            this.txtSteelGradeIndexPrco.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexPrco.TabIndex = 0;
            this.txtSteelGradeIndexPrco.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexPrco.ValidEable = true;
            this.txtSteelGradeIndexPrco.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
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
            // RHStdMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RHStdMaintenFrm";
            this.TabText = "RH炉制造标准维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RHStdMaintenFrm_FormClosing);
            this.Load += new System.EventHandler(this.RHStdMaintenFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProc)).EndInit();
            this.tabFeed.ResumeLayout(false);
            this.hmiRootPanelFeed.ResumeLayout(false);
            this.hmiRootPanelFeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorFeed)).EndInit();
            this.bNavigatorFeed.ResumeLayout(false);
            this.bNavigatorFeed.PerformLayout();
            this.tabAlloy.ResumeLayout(false);
            this.hmiRootPanelAlloy.ResumeLayout(false);
            this.hmiRootPanelAlloy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorAlloy)).EndInit();
            this.bNavigatorAlloy.ResumeLayout(false);
            this.bNavigatorAlloy.PerformLayout();
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabProc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnOK;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscmbSteelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private AppSvrHMI.L3DataSet dsBase;
        private AppSvrHMI.L3DataSet dsProc;
        private AppSvrHMI.L3DataSet dsAlloy;
        private AppSvrHMI.L3DataSet dsFeed;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingSource bsProc;
        private System.Windows.Forms.BindingSource bsAlloy;
        private System.Windows.Forms.BindingSource bsFeed;
        private System.Windows.Forms.TabPage tabFeed;
        private HMIBase.HMIRootPanel hmiRootPanelFeed;
        private System.Windows.Forms.DataGridView dvFeed;
        private System.Windows.Forms.BindingNavigator bNavigatorFeed;
        private System.Windows.Forms.ToolStripButton btnAddFeed;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton btnDelFeed;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TabPage tabAlloy;
        private HMIBase.HMIRootPanel hmiRootPanelAlloy;
        private System.Windows.Forms.DataGridView dvAlloy;
        private System.Windows.Forms.BindingNavigator bNavigatorAlloy;
        private System.Windows.Forms.ToolStripButton btnAddAlloy;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDelAlloy;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabPage tabBase;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.DateTimePicker dtValidDate;
        private PxDataValid.PxTextBox txtNewCode;
        private PxDataValid.PxTextBox txtSteelGradeIndexBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabProc;
        private System.Windows.Forms.GroupBox groupBox1;
        private PxDataValid.PxTextBox txtStaySteelTimeMax;
        private PxDataValid.PxTextBox txtPureDeOTimeMin;
        private PxDataValid.PxTextBox txtHoldSteelTimeMax;
        private PxDataValid.PxTextBox txtColdMatAdd;
        private PxDataValid.PxTextBox txtProcTimeMin;
        private PxDataValid.PxTextBox txtVacuumTimeMin;
        private PxDataValid.PxTextBox txtPureTimeMax;
        private PxDataValid.PxTextBox txtPureTimeMin;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label41;
        private PxDataValid.PxComboBox cmbOxyFlag;
        private PxDataValid.PxComboBox cmbDec_Flag;
        private System.Windows.Forms.Label label40;
        private PxDataValid.PxTextBox txtDecTimeMax;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private PxDataValid.PxTextBox txtDecTimeMin;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private PxDataValid.PxTextBox txtVacuumMax;
        private PxDataValid.PxTextBox txtUpBlowAim;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxTextBox txtDepthMax;
        private PxDataValid.PxTextBox txtUpBlowMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label10;
        private PxDataValid.PxTextBox txtUpBlowMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private PxDataValid.PxTextBox txtVacuumMin;
        private PxDataValid.PxTextBox txtDepthMin;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private PxDataValid.PxTextBox txtLeaFirTempAim;
        private PxDataValid.PxTextBox txtLeaTempAim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private PxDataValid.PxTextBox txtLeaTempMin;
        private PxDataValid.PxTextBox txtLeaTempMax;
        private PxDataValid.PxTextBox txtLeaFirTempMin;
        private PxDataValid.PxTextBox txtLeaFirTempMax;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label28;
        private PxDataValid.PxTextBox txtSteelGradeIndexPrco;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTableValid_Date;
        private System.Data.DataColumn coldsBaseL3DataTableNew_Code;
        private System.Data.DataColumn coldsBaseL3DataTableNote;
        private System.Data.DataTable schemadsProc;
        private System.Data.DataColumn coldsProcL3DataTableGUID;
        private System.Data.DataColumn coldsProcL3DataTableName;
        private System.Data.DataColumn coldsProcL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsProcL3DataTableLeaFir_Temp_Aim;
        private System.Data.DataColumn coldsProcL3DataTableLeaFir_Temp_Min;
        private System.Data.DataColumn coldsProcL3DataTableLeaFir_Temp_Max;
        private System.Data.DataColumn coldsProcL3DataTableLea_Temp_Aim;
        private System.Data.DataColumn coldsProcL3DataTableLea_Temp_Min;
        private System.Data.DataColumn coldsProcL3DataTableLea_Temp_Max;
        private System.Data.DataColumn coldsProcL3DataTableDepth_Min;
        private System.Data.DataColumn coldsProcL3DataTableDepth_Max;
        private System.Data.DataColumn coldsProcL3DataTableVacuum_Min;
        private System.Data.DataColumn coldsProcL3DataTableVacuum_Max;
        private System.Data.DataColumn coldsProcL3DataTableUp_Blow_Min;
        private System.Data.DataColumn coldsProcL3DataTableUp_Blow_Aim;
        private System.Data.DataColumn coldsProcL3DataTableUp_Blow_Max;
        private System.Data.DataColumn coldsProcL3DataTableDec_Flag;
        private System.Data.DataColumn coldsProcL3DataTableDec_Time_Min;
        private System.Data.DataColumn coldsProcL3DataTableDec_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTablePure_Time_Min;
        private System.Data.DataColumn coldsProcL3DataTablePure_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableVacuum_Time_Min;
        private System.Data.DataColumn coldsProcL3DataTableProc_Time_Min;
        private System.Data.DataColumn coldsProcL3DataTableOxy_Flag;
        private System.Data.DataColumn coldsProcL3DataTableH_Flag;
        private System.Data.DataColumn coldsProcL3DataTableSoft_Blow_Flag;
        private System.Data.DataColumn coldsProcL3DataTableCalm_Flag;
        private System.Data.DataColumn coldsProcL3DataTableAl_Hot_Flag;
        private System.Data.DataColumn coldsProcL3DataTableCold_Mat_Add;
        private System.Data.DataColumn coldsProcL3DataTableHold_Steel_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableStay_Steel_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTablePure_DeO_Time_Min;
        private System.Data.DataTable schemadsAlloy;
        private System.Data.DataColumn coldsAlloyL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsAlloyL3DataTableAlloy_Flag;
        private System.Data.DataColumn coldsAlloyL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsAlloyL3DataTableAlloy_Yield;
        private System.Data.DataTable schemadsFeed;
        private System.Data.DataColumn coldsFeedL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsFeedL3DataTableCaProc_Code;
        private System.Data.DataColumn coldsFeedL3DataTableCaProc_Code_Weight_Max;
        private System.Data.DataColumn coldsFeedL3DataTableCaProc_Code_Weight_Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcCodeWeightMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcCodeWeightMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyYieldDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsAlloyL3DataTableGUID;
        private System.Data.DataColumn coldsFeedL3DataTableGUID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxComboBox cmbAlHotFlag;
        private PxDataValid.PxComboBox cmbCalm_Flag;
        private PxDataValid.PxComboBox cmbSoftBlowFlag;
        private PxDataValid.PxComboBox cmbHFlag;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
    }
}