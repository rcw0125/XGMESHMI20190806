namespace QualityMag.QualityStandard
{
    partial class LFStdMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LFStdMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOK = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelLadle = new System.Windows.Forms.ToolStripButton();
            this.btnAddLadle = new System.Windows.Forms.ToolStripButton();
            this.btnDelSlag = new System.Windows.Forms.ToolStripButton();
            this.btnAddSlag = new System.Windows.Forms.ToolStripButton();
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
            this.coldsFeedL3DataTableC_Absorption_Rate = new System.Data.DataColumn();
            this.coldsFeedL3DataTableAl_Absorption_Rate = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProc_Code1 = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Max = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Min = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Max = new System.Data.DataColumn();
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Min = new System.Data.DataColumn();
            this.coldsFeedL3DataTableOxy_Flag = new System.Data.DataColumn();
            this.coldsFeedL3DataTableGUID = new System.Data.DataColumn();
            this.bsSlag = new System.Windows.Forms.BindingSource(this.components);
            this.dsSlag = new AppSvrHMI.L3DataSet();
            this.schemadsSlag = new System.Data.DataTable();
            this.coldsSlagL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSlagL3DataTableSlag_Code = new System.Data.DataColumn();
            this.coldsSlagL3DataTableSlag_Weight = new System.Data.DataColumn();
            this.AcoldsSlagL3DataTableGUID = new System.Data.DataColumn();
            this.bsLadle = new System.Windows.Forms.BindingSource(this.components);
            this.dsLadle = new AppSvrHMI.L3DataSet();
            this.schemadsLadle = new System.Data.DataTable();
            this.coldsLadleL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Name = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Min = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Max = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Aim = new System.Data.DataColumn();
            this.coldsLadleL3DataTableGUID = new System.Data.DataColumn();
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
            this.coldsProcL3DataTableSample_Flag = new System.Data.DataColumn();
            this.coldsProcL3DataTableSoft_Blow_Time_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableHot_Time_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableHot_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableHot_Ar_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableHot_Ar_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableSoft_Ar_Min = new System.Data.DataColumn();
            this.coldsProcL3DataTableSoft_Ar_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableHold_Steel_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableStay_Steel_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableRefine_Time_Max = new System.Data.DataColumn();
            this.coldsProcL3DataTableRefine_Time_Min = new System.Data.DataColumn();
            this.dsSlagEle = new AppSvrHMI.L3DataSet();
            this.schemadsSlagEle = new System.Data.DataTable();
            this.coldsSlagEleL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableName = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableCaO_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableCaO_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableSiO2_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableSiO2_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableMgO_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableMgO_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableAl2O3_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableAl2O3_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableS_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableS_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableP_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableP_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableMnO_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableMnO_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableTiO2_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableTiO2_Min = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableFeO_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableFeO_Min = new System.Data.DataColumn();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.bsProc = new System.Windows.Forms.BindingSource(this.components);
            this.bsSlagEle = new System.Windows.Forms.BindingSource(this.components);
            this.tabSlagEle = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.txtFeOMax = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtPMax = new PxDataValid.PxTextBox();
            this.txtTiO2Max = new PxDataValid.PxTextBox();
            this.txtSMax = new PxDataValid.PxTextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.txtMnOMax = new PxDataValid.PxTextBox();
            this.txtFeOMin = new PxDataValid.PxTextBox();
            this.txtAl2O3Max = new PxDataValid.PxTextBox();
            this.txtPMin = new PxDataValid.PxTextBox();
            this.txtTiO2Min = new PxDataValid.PxTextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.txtSMin = new PxDataValid.PxTextBox();
            this.txtMnOMin = new PxDataValid.PxTextBox();
            this.txtMgOMax = new PxDataValid.PxTextBox();
            this.txtAl2O3Min = new PxDataValid.PxTextBox();
            this.txtCaOMin = new PxDataValid.PxTextBox();
            this.txtMgOMin = new PxDataValid.PxTextBox();
            this.txtSiO2Max = new PxDataValid.PxTextBox();
            this.txtSiO2Min = new PxDataValid.PxTextBox();
            this.txtCaOMax = new PxDataValid.PxTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSteelGradeIndexSlagEle = new PxDataValid.PxTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tabLadle = new System.Windows.Forms.TabPage();
            this.hmiRootPanelLadle = new HMIBase.HMIRootPanel();
            this.dvLadle = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNavigatorLadle = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tabSlag = new System.Windows.Forms.TabPage();
            this.hmiRootPanelSlag = new HMIBase.HMIRootPanel();
            this.dvSlag = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slagCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slagWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID_Slag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNavigatorSlag = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.hmiRootPanelFeed = new HMIBase.HMIRootPanel();
            this.dvFeed = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAbsorptionRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alAbsorptionRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcCode1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcFirCode1WeightMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcFirCode1WeightMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcCode1WeightMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caProcCode1WeightMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxyFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabProc = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtHotArmax = new PxDataValid.PxTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHotTimeMax = new PxDataValid.PxTextBox();
            this.txtRefineTimeMax = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSoftArMax = new PxDataValid.PxTextBox();
            this.txtRefineTimeMin = new PxDataValid.PxTextBox();
            this.txtHoldSteelTimeMax = new PxDataValid.PxTextBox();
            this.txtHoldSteelTimeMin = new PxDataValid.PxTextBox();
            this.txtHotTimeMin = new PxDataValid.PxTextBox();
            this.txtSoftArMin = new PxDataValid.PxTextBox();
            this.txtHotArMin = new PxDataValid.PxTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLeaFirTempAim = new PxDataValid.PxTextBox();
            this.txtLeaTempAim = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLeaTempMin = new PxDataValid.PxTextBox();
            this.txtLeaTempMax = new PxDataValid.PxTextBox();
            this.txtLeaFirTempMin = new PxDataValid.PxTextBox();
            this.txtLeaFirTempMax = new PxDataValid.PxTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSampleFlag = new PxDataValid.PxComboBox();
            this.txtSoftBlowTimeMin = new PxDataValid.PxTextBox();
            this.txtSteelGradeIndexProc = new PxDataValid.PxTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.dtValidDate = new System.Windows.Forms.DateTimePicker();
            this.txtNewCode = new PxDataValid.PxTextBox();
            this.txtSteelGradeIndexBase = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.coldsSlagL3DataTableGUID = new System.Data.DataColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlagEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlagEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSlagEle)).BeginInit();
            this.tabSlagEle.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabLadle.SuspendLayout();
            this.hmiRootPanelLadle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorLadle)).BeginInit();
            this.bNavigatorLadle.SuspendLayout();
            this.tabSlag.SuspendLayout();
            this.hmiRootPanelSlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorSlag)).BeginInit();
            this.bNavigatorSlag.SuspendLayout();
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
            this.tabProc.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabBase.SuspendLayout();
            this.tabControlMain.SuspendLayout();
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
            this.Adapter.SetAccessRight(this.btnDel, "btnLFStd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnLFStd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOK
            // 
            this.Adapter.SetAccessRight(this.btnOK, "btnLFStd");
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 40);
            this.btnOK.Text = "确认";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "btnLFStd");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelLadle
            // 
            this.Adapter.SetAccessRight(this.btnDelLadle, "btnLFStd");
            this.btnDelLadle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelLadle.Image = ((System.Drawing.Image)(resources.GetObject("btnDelLadle.Image")));
            this.btnDelLadle.Name = "btnDelLadle";
            this.btnDelLadle.RightToLeftAutoMirrorImage = true;
            this.btnDelLadle.Size = new System.Drawing.Size(23, 22);
            this.btnDelLadle.Text = "删除";
            this.btnDelLadle.Click += new System.EventHandler(this.btnDelLadle_Click);
            // 
            // btnAddLadle
            // 
            this.Adapter.SetAccessRight(this.btnAddLadle, "btnLFStd");
            this.btnAddLadle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddLadle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLadle.Image")));
            this.btnAddLadle.Name = "btnAddLadle";
            this.btnAddLadle.RightToLeftAutoMirrorImage = true;
            this.btnAddLadle.Size = new System.Drawing.Size(23, 22);
            this.btnAddLadle.Text = "新添";
            this.btnAddLadle.Click += new System.EventHandler(this.btnAddLadle_Click);
            // 
            // btnDelSlag
            // 
            this.Adapter.SetAccessRight(this.btnDelSlag, "btnLFStd");
            this.btnDelSlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelSlag.Image = ((System.Drawing.Image)(resources.GetObject("btnDelSlag.Image")));
            this.btnDelSlag.Name = "btnDelSlag";
            this.btnDelSlag.RightToLeftAutoMirrorImage = true;
            this.btnDelSlag.Size = new System.Drawing.Size(23, 22);
            this.btnDelSlag.Text = "删除";
            this.btnDelSlag.Click += new System.EventHandler(this.btnDelSlag_Click);
            // 
            // btnAddSlag
            // 
            this.Adapter.SetAccessRight(this.btnAddSlag, "btnLFStd");
            this.btnAddSlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSlag.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSlag.Image")));
            this.btnAddSlag.Name = "btnAddSlag";
            this.btnAddSlag.RightToLeftAutoMirrorImage = true;
            this.btnAddSlag.Size = new System.Drawing.Size(23, 22);
            this.btnAddSlag.Text = "新添";
            this.btnAddSlag.Click += new System.EventHandler(this.btnAddSlag_Click);
            // 
            // btnDelFeed
            // 
            this.Adapter.SetAccessRight(this.btnDelFeed, "btnLFStd");
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
            this.Adapter.SetAccessRight(this.btnAddFeed, "btnLFStd");
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
            this.Adapter.SetAccessRight(this.btnDelAlloy, "btnLFStd");
            this.btnDelAlloy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelAlloy.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAlloy.Image")));
            this.btnDelAlloy.Name = "btnDelAlloy";
            this.btnDelAlloy.RightToLeftAutoMirrorImage = true;
            this.btnDelAlloy.Size = new System.Drawing.Size(23, 22);
            this.btnDelAlloy.Text = "删除";
            this.btnDelAlloy.Click += new System.EventHandler(this.btnDelAlloy_Click);
            // 
            // btnAddAlloy
            // 
            this.Adapter.SetAccessRight(this.btnAddAlloy, "btnLFStd");
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
            this.tscmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.dsAlloy.SourceURI = "XGMESLogic\\QualityMag\\CQA_LF_Std_Alloy";
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
            this.dsFeed.SourceURI = "XGMESLogic\\QualityMag\\CQA_LF_Std_Feed";
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
            this.coldsFeedL3DataTableC_Absorption_Rate,
            this.coldsFeedL3DataTableAl_Absorption_Rate,
            this.coldsFeedL3DataTableCaProc_Code1,
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Max,
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Min,
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Max,
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Min,
            this.coldsFeedL3DataTableOxy_Flag,
            this.coldsFeedL3DataTableGUID});
            this.schemadsFeed.TableName = "L3DataTable";
            // 
            // coldsFeedL3DataTableSteelGradeIndex
            // 
            this.coldsFeedL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsFeedL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsFeedL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsFeedL3DataTableC_Absorption_Rate
            // 
            this.coldsFeedL3DataTableC_Absorption_Rate.Caption = "C_Absorption_Rate";
            this.coldsFeedL3DataTableC_Absorption_Rate.ColumnName = "C_Absorption_Rate";
            this.coldsFeedL3DataTableC_Absorption_Rate.Namespace = "";
            // 
            // coldsFeedL3DataTableAl_Absorption_Rate
            // 
            this.coldsFeedL3DataTableAl_Absorption_Rate.Caption = "Al_Absorption_Rate";
            this.coldsFeedL3DataTableAl_Absorption_Rate.ColumnName = "Al_Absorption_Rate";
            this.coldsFeedL3DataTableAl_Absorption_Rate.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProc_Code1
            // 
            this.coldsFeedL3DataTableCaProc_Code1.Caption = "CaProc_Code1";
            this.coldsFeedL3DataTableCaProc_Code1.ColumnName = "CaProc_Code1";
            this.coldsFeedL3DataTableCaProc_Code1.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProcFir_Code1_Weight_Max
            // 
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Max.Caption = "CaProcFir_Code1_Weight_Max";
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Max.ColumnName = "CaProcFir_Code1_Weight_Max";
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Max.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProcFir_Code1_Weight_Min
            // 
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Min.Caption = "CaProcFir_Code1_Weight_Min";
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Min.ColumnName = "CaProcFir_Code1_Weight_Min";
            this.coldsFeedL3DataTableCaProcFir_Code1_Weight_Min.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProc_Code1_Weight_Max
            // 
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Max.Caption = "CaProc_Code1_Weight_Max";
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Max.ColumnName = "CaProc_Code1_Weight_Max";
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Max.Namespace = "";
            // 
            // coldsFeedL3DataTableCaProc_Code1_Weight_Min
            // 
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Min.Caption = "CaProc_Code1_Weight_Min";
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Min.ColumnName = "CaProc_Code1_Weight_Min";
            this.coldsFeedL3DataTableCaProc_Code1_Weight_Min.Namespace = "";
            // 
            // coldsFeedL3DataTableOxy_Flag
            // 
            this.coldsFeedL3DataTableOxy_Flag.Caption = "Oxy_Flag";
            this.coldsFeedL3DataTableOxy_Flag.ColumnName = "Oxy_Flag";
            this.coldsFeedL3DataTableOxy_Flag.DataType = typeof(int);
            this.coldsFeedL3DataTableOxy_Flag.Namespace = "";
            // 
            // coldsFeedL3DataTableGUID
            // 
            this.coldsFeedL3DataTableGUID.Caption = "GUID";
            this.coldsFeedL3DataTableGUID.ColumnName = "GUID";
            this.coldsFeedL3DataTableGUID.Namespace = "";
            // 
            // bsSlag
            // 
            this.bsSlag.DataMember = "L3DataTable";
            this.bsSlag.DataSource = this.dsSlag;
            // 
            // dsSlag
            // 
            this.dsSlag.AutoLoad = true;
            this.dsSlag.AutoSubscribe = false;
            this.dsSlag.DataSetName = "L3DataSet";
            this.dsSlag.DeleteMethod = null;
            this.dsSlag.InsertMethod = null;
            this.dsSlag.L3DataAdapter = this.Adapter;
            this.dsSlag.LoadEvent = "Click";
            this.dsSlag.LoadTrigger = null;
            this.dsSlag.RefreshValve = 1000;
            this.dsSlag.SourceCommand = null;
            this.dsSlag.SourceCondition = "1=2";
            this.dsSlag.SourceMethod = "";
            this.dsSlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSlag.SourceURI = "XGMESLogic\\QualityMag\\CQA_LF_Std_Slag";
            this.dsSlag.SubscribeTarget = null;
            this.dsSlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSlag});
            this.dsSlag.UpdateEvent = "Click";
            this.dsSlag.UpdateMethod = null;
            this.dsSlag.UpdateTrigger = null;
            // 
            // schemadsSlag
            // 
            this.schemadsSlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSlagL3DataTableSteelGradeIndex,
            this.coldsSlagL3DataTableSlag_Code,
            this.coldsSlagL3DataTableSlag_Weight,
            this.AcoldsSlagL3DataTableGUID});
            this.schemadsSlag.TableName = "L3DataTable";
            // 
            // coldsSlagL3DataTableSteelGradeIndex
            // 
            this.coldsSlagL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSlagL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSlagL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSlagL3DataTableSlag_Code
            // 
            this.coldsSlagL3DataTableSlag_Code.Caption = "Slag_Code";
            this.coldsSlagL3DataTableSlag_Code.ColumnName = "Slag_Code";
            this.coldsSlagL3DataTableSlag_Code.Namespace = "";
            // 
            // coldsSlagL3DataTableSlag_Weight
            // 
            this.coldsSlagL3DataTableSlag_Weight.Caption = "Slag_Weight";
            this.coldsSlagL3DataTableSlag_Weight.ColumnName = "Slag_Weight";
            this.coldsSlagL3DataTableSlag_Weight.Namespace = "";
            // 
            // AcoldsSlagL3DataTableGUID
            // 
            this.AcoldsSlagL3DataTableGUID.Caption = "GUID";
            this.AcoldsSlagL3DataTableGUID.ColumnName = "GUID";
            this.AcoldsSlagL3DataTableGUID.Namespace = "";
            // 
            // bsLadle
            // 
            this.bsLadle.DataMember = "L3DataTable";
            this.bsLadle.DataSource = this.dsLadle;
            // 
            // dsLadle
            // 
            this.dsLadle.AutoLoad = true;
            this.dsLadle.AutoSubscribe = false;
            this.dsLadle.DataSetName = "L3DataSet";
            this.dsLadle.DeleteMethod = null;
            this.dsLadle.InsertMethod = null;
            this.dsLadle.L3DataAdapter = this.Adapter;
            this.dsLadle.LoadEvent = "Click";
            this.dsLadle.LoadTrigger = null;
            this.dsLadle.RefreshValve = 1000;
            this.dsLadle.SourceCommand = null;
            this.dsLadle.SourceCondition = "1=2";
            this.dsLadle.SourceMethod = "";
            this.dsLadle.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadle.SourceURI = "XGMESLogic\\QualityMag\\CQA_LF_Std_Ladle";
            this.dsLadle.SubscribeTarget = null;
            this.dsLadle.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadle});
            this.dsLadle.UpdateEvent = "Click";
            this.dsLadle.UpdateMethod = null;
            this.dsLadle.UpdateTrigger = null;
            // 
            // schemadsLadle
            // 
            this.schemadsLadle.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleL3DataTableSteelGradeIndex,
            this.coldsLadleL3DataTableLadle_Mat_Name,
            this.coldsLadleL3DataTableLadle_Mat_Min,
            this.coldsLadleL3DataTableLadle_Mat_Max,
            this.coldsLadleL3DataTableLadle_Mat_Aim,
            this.coldsLadleL3DataTableGUID});
            this.schemadsLadle.TableName = "L3DataTable";
            // 
            // coldsLadleL3DataTableSteelGradeIndex
            // 
            this.coldsLadleL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsLadleL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsLadleL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsLadleL3DataTableLadle_Mat_Name
            // 
            this.coldsLadleL3DataTableLadle_Mat_Name.Caption = "Ladle_Mat_Name";
            this.coldsLadleL3DataTableLadle_Mat_Name.ColumnName = "Ladle_Mat_Name";
            this.coldsLadleL3DataTableLadle_Mat_Name.Namespace = "";
            // 
            // coldsLadleL3DataTableLadle_Mat_Min
            // 
            this.coldsLadleL3DataTableLadle_Mat_Min.Caption = "Ladle_Mat_Min";
            this.coldsLadleL3DataTableLadle_Mat_Min.ColumnName = "Ladle_Mat_Min";
            this.coldsLadleL3DataTableLadle_Mat_Min.Namespace = "";
            // 
            // coldsLadleL3DataTableLadle_Mat_Max
            // 
            this.coldsLadleL3DataTableLadle_Mat_Max.Caption = "Ladle_Mat_Max";
            this.coldsLadleL3DataTableLadle_Mat_Max.ColumnName = "Ladle_Mat_Max";
            this.coldsLadleL3DataTableLadle_Mat_Max.Namespace = "";
            // 
            // coldsLadleL3DataTableLadle_Mat_Aim
            // 
            this.coldsLadleL3DataTableLadle_Mat_Aim.Caption = "Ladle_Mat_Aim";
            this.coldsLadleL3DataTableLadle_Mat_Aim.ColumnName = "Ladle_Mat_Aim";
            this.coldsLadleL3DataTableLadle_Mat_Aim.Namespace = "";
            // 
            // coldsLadleL3DataTableGUID
            // 
            this.coldsLadleL3DataTableGUID.Caption = "GUID";
            this.coldsLadleL3DataTableGUID.ColumnName = "GUID";
            this.coldsLadleL3DataTableGUID.Namespace = "";
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
            this.dsBase.AutoSubscribe = false;
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
            this.dsBase.SourceURI = "XGMESLogic\\QualityMag\\CQA_LF_Std_Base";
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
            this.dsProc.SourceURI = "XGMESLogic\\QualityMag\\CQA_LF_Std_Proc";
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
            this.coldsProcL3DataTableSample_Flag,
            this.coldsProcL3DataTableSoft_Blow_Time_Min,
            this.coldsProcL3DataTableHot_Time_Min,
            this.coldsProcL3DataTableHot_Time_Max,
            this.coldsProcL3DataTableHot_Ar_Min,
            this.coldsProcL3DataTableHot_Ar_Max,
            this.coldsProcL3DataTableSoft_Ar_Min,
            this.coldsProcL3DataTableSoft_Ar_Max,
            this.coldsProcL3DataTableHold_Steel_Time_Max,
            this.coldsProcL3DataTableStay_Steel_Time_Max,
            this.coldsProcL3DataTableRefine_Time_Max,
            this.coldsProcL3DataTableRefine_Time_Min});
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
            // coldsProcL3DataTableSample_Flag
            // 
            this.coldsProcL3DataTableSample_Flag.Caption = "Sample_Flag";
            this.coldsProcL3DataTableSample_Flag.ColumnName = "Sample_Flag";
            this.coldsProcL3DataTableSample_Flag.DataType = typeof(int);
            this.coldsProcL3DataTableSample_Flag.Namespace = "";
            // 
            // coldsProcL3DataTableSoft_Blow_Time_Min
            // 
            this.coldsProcL3DataTableSoft_Blow_Time_Min.Caption = "Soft_Blow_Time_Min";
            this.coldsProcL3DataTableSoft_Blow_Time_Min.ColumnName = "Soft_Blow_Time_Min";
            this.coldsProcL3DataTableSoft_Blow_Time_Min.DataType = typeof(int);
            this.coldsProcL3DataTableSoft_Blow_Time_Min.Namespace = "";
            // 
            // coldsProcL3DataTableHot_Time_Min
            // 
            this.coldsProcL3DataTableHot_Time_Min.Caption = "Hot_Time_Min";
            this.coldsProcL3DataTableHot_Time_Min.ColumnName = "Hot_Time_Min";
            this.coldsProcL3DataTableHot_Time_Min.DataType = typeof(int);
            this.coldsProcL3DataTableHot_Time_Min.Namespace = "";
            // 
            // coldsProcL3DataTableHot_Time_Max
            // 
            this.coldsProcL3DataTableHot_Time_Max.Caption = "Hot_Time_Max";
            this.coldsProcL3DataTableHot_Time_Max.ColumnName = "Hot_Time_Max";
            this.coldsProcL3DataTableHot_Time_Max.DataType = typeof(int);
            this.coldsProcL3DataTableHot_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTableHot_Ar_Min
            // 
            this.coldsProcL3DataTableHot_Ar_Min.Caption = "Hot_Ar_Min";
            this.coldsProcL3DataTableHot_Ar_Min.ColumnName = "Hot_Ar_Min";
            this.coldsProcL3DataTableHot_Ar_Min.Namespace = "";
            // 
            // coldsProcL3DataTableHot_Ar_Max
            // 
            this.coldsProcL3DataTableHot_Ar_Max.Caption = "Hot_Ar_Max";
            this.coldsProcL3DataTableHot_Ar_Max.ColumnName = "Hot_Ar_Max";
            this.coldsProcL3DataTableHot_Ar_Max.Namespace = "";
            // 
            // coldsProcL3DataTableSoft_Ar_Min
            // 
            this.coldsProcL3DataTableSoft_Ar_Min.Caption = "Soft_Ar_Min";
            this.coldsProcL3DataTableSoft_Ar_Min.ColumnName = "Soft_Ar_Min";
            this.coldsProcL3DataTableSoft_Ar_Min.Namespace = "";
            // 
            // coldsProcL3DataTableSoft_Ar_Max
            // 
            this.coldsProcL3DataTableSoft_Ar_Max.Caption = "Soft_Ar_Max";
            this.coldsProcL3DataTableSoft_Ar_Max.ColumnName = "Soft_Ar_Max";
            this.coldsProcL3DataTableSoft_Ar_Max.Namespace = "";
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
            // coldsProcL3DataTableRefine_Time_Max
            // 
            this.coldsProcL3DataTableRefine_Time_Max.Caption = "Refine_Time_Max";
            this.coldsProcL3DataTableRefine_Time_Max.ColumnName = "Refine_Time_Max";
            this.coldsProcL3DataTableRefine_Time_Max.Namespace = "";
            // 
            // coldsProcL3DataTableRefine_Time_Min
            // 
            this.coldsProcL3DataTableRefine_Time_Min.Caption = "Refine_Time_Min";
            this.coldsProcL3DataTableRefine_Time_Min.ColumnName = "Refine_Time_Min";
            this.coldsProcL3DataTableRefine_Time_Min.Namespace = "";
            // 
            // dsSlagEle
            // 
            this.dsSlagEle.AutoLoad = true;
            this.dsSlagEle.AutoSubscribe = false;
            this.dsSlagEle.DataSetName = "L3DataSet";
            this.dsSlagEle.DeleteMethod = null;
            this.dsSlagEle.InsertMethod = null;
            this.dsSlagEle.L3DataAdapter = this.Adapter;
            this.dsSlagEle.LoadEvent = "Click";
            this.dsSlagEle.LoadTrigger = null;
            this.dsSlagEle.RefreshValve = 1000;
            this.dsSlagEle.SourceCommand = null;
            this.dsSlagEle.SourceCondition = "1=2";
            this.dsSlagEle.SourceMethod = "";
            this.dsSlagEle.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSlagEle.SourceURI = "XGMESLogic\\QualityMag\\CQA_LF_Std_Slag_Ele";
            this.dsSlagEle.SubscribeTarget = null;
            this.dsSlagEle.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSlagEle});
            this.dsSlagEle.UpdateEvent = "Click";
            this.dsSlagEle.UpdateMethod = null;
            this.dsSlagEle.UpdateTrigger = null;
            // 
            // schemadsSlagEle
            // 
            this.schemadsSlagEle.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSlagEleL3DataTableGUID,
            this.coldsSlagEleL3DataTableName,
            this.coldsSlagEleL3DataTableSteelGradeIndex,
            this.coldsSlagEleL3DataTableCaO_Max,
            this.coldsSlagEleL3DataTableCaO_Min,
            this.coldsSlagEleL3DataTableSiO2_Max,
            this.coldsSlagEleL3DataTableSiO2_Min,
            this.coldsSlagEleL3DataTableMgO_Max,
            this.coldsSlagEleL3DataTableMgO_Min,
            this.coldsSlagEleL3DataTableAl2O3_Max,
            this.coldsSlagEleL3DataTableAl2O3_Min,
            this.coldsSlagEleL3DataTableS_Max,
            this.coldsSlagEleL3DataTableS_Min,
            this.coldsSlagEleL3DataTableP_Max,
            this.coldsSlagEleL3DataTableP_Min,
            this.coldsSlagEleL3DataTableMnO_Max,
            this.coldsSlagEleL3DataTableMnO_Min,
            this.coldsSlagEleL3DataTableTiO2_Max,
            this.coldsSlagEleL3DataTableTiO2_Min,
            this.coldsSlagEleL3DataTableFeO_Max,
            this.coldsSlagEleL3DataTableFeO_Min});
            this.schemadsSlagEle.TableName = "L3DataTable";
            // 
            // coldsSlagEleL3DataTableGUID
            // 
            this.coldsSlagEleL3DataTableGUID.Caption = "GUID";
            this.coldsSlagEleL3DataTableGUID.ColumnName = "GUID";
            this.coldsSlagEleL3DataTableGUID.Namespace = "";
            // 
            // coldsSlagEleL3DataTableName
            // 
            this.coldsSlagEleL3DataTableName.Caption = "Name";
            this.coldsSlagEleL3DataTableName.ColumnName = "Name";
            this.coldsSlagEleL3DataTableName.Namespace = "";
            // 
            // coldsSlagEleL3DataTableSteelGradeIndex
            // 
            this.coldsSlagEleL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsSlagEleL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsSlagEleL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsSlagEleL3DataTableCaO_Max
            // 
            this.coldsSlagEleL3DataTableCaO_Max.Caption = "CaO_Max";
            this.coldsSlagEleL3DataTableCaO_Max.ColumnName = "CaO_Max";
            this.coldsSlagEleL3DataTableCaO_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableCaO_Min
            // 
            this.coldsSlagEleL3DataTableCaO_Min.Caption = "CaO_Min";
            this.coldsSlagEleL3DataTableCaO_Min.ColumnName = "CaO_Min";
            this.coldsSlagEleL3DataTableCaO_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableSiO2_Max
            // 
            this.coldsSlagEleL3DataTableSiO2_Max.Caption = "SiO2_Max";
            this.coldsSlagEleL3DataTableSiO2_Max.ColumnName = "SiO2_Max";
            this.coldsSlagEleL3DataTableSiO2_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableSiO2_Min
            // 
            this.coldsSlagEleL3DataTableSiO2_Min.Caption = "SiO2_Min";
            this.coldsSlagEleL3DataTableSiO2_Min.ColumnName = "SiO2_Min";
            this.coldsSlagEleL3DataTableSiO2_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableMgO_Max
            // 
            this.coldsSlagEleL3DataTableMgO_Max.Caption = "MgO_Max";
            this.coldsSlagEleL3DataTableMgO_Max.ColumnName = "MgO_Max";
            this.coldsSlagEleL3DataTableMgO_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableMgO_Min
            // 
            this.coldsSlagEleL3DataTableMgO_Min.Caption = "MgO_Min";
            this.coldsSlagEleL3DataTableMgO_Min.ColumnName = "MgO_Min";
            this.coldsSlagEleL3DataTableMgO_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableAl2O3_Max
            // 
            this.coldsSlagEleL3DataTableAl2O3_Max.Caption = "Al2O3_Max";
            this.coldsSlagEleL3DataTableAl2O3_Max.ColumnName = "Al2O3_Max";
            this.coldsSlagEleL3DataTableAl2O3_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableAl2O3_Min
            // 
            this.coldsSlagEleL3DataTableAl2O3_Min.Caption = "Al2O3_Min";
            this.coldsSlagEleL3DataTableAl2O3_Min.ColumnName = "Al2O3_Min";
            this.coldsSlagEleL3DataTableAl2O3_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableS_Max
            // 
            this.coldsSlagEleL3DataTableS_Max.Caption = "S_Max";
            this.coldsSlagEleL3DataTableS_Max.ColumnName = "S_Max";
            this.coldsSlagEleL3DataTableS_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableS_Min
            // 
            this.coldsSlagEleL3DataTableS_Min.Caption = "S_Min";
            this.coldsSlagEleL3DataTableS_Min.ColumnName = "S_Min";
            this.coldsSlagEleL3DataTableS_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableP_Max
            // 
            this.coldsSlagEleL3DataTableP_Max.Caption = "P_Max";
            this.coldsSlagEleL3DataTableP_Max.ColumnName = "P_Max";
            this.coldsSlagEleL3DataTableP_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableP_Min
            // 
            this.coldsSlagEleL3DataTableP_Min.Caption = "P_Min";
            this.coldsSlagEleL3DataTableP_Min.ColumnName = "P_Min";
            this.coldsSlagEleL3DataTableP_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableMnO_Max
            // 
            this.coldsSlagEleL3DataTableMnO_Max.Caption = "MnO_Max";
            this.coldsSlagEleL3DataTableMnO_Max.ColumnName = "MnO_Max";
            this.coldsSlagEleL3DataTableMnO_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableMnO_Min
            // 
            this.coldsSlagEleL3DataTableMnO_Min.Caption = "MnO_Min";
            this.coldsSlagEleL3DataTableMnO_Min.ColumnName = "MnO_Min";
            this.coldsSlagEleL3DataTableMnO_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableTiO2_Max
            // 
            this.coldsSlagEleL3DataTableTiO2_Max.Caption = "TiO2_Max";
            this.coldsSlagEleL3DataTableTiO2_Max.ColumnName = "TiO2_Max";
            this.coldsSlagEleL3DataTableTiO2_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableTiO2_Min
            // 
            this.coldsSlagEleL3DataTableTiO2_Min.Caption = "TiO2_Min";
            this.coldsSlagEleL3DataTableTiO2_Min.ColumnName = "TiO2_Min";
            this.coldsSlagEleL3DataTableTiO2_Min.Namespace = "";
            // 
            // coldsSlagEleL3DataTableFeO_Max
            // 
            this.coldsSlagEleL3DataTableFeO_Max.Caption = "FeO_Max";
            this.coldsSlagEleL3DataTableFeO_Max.ColumnName = "FeO_Max";
            this.coldsSlagEleL3DataTableFeO_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableFeO_Min
            // 
            this.coldsSlagEleL3DataTableFeO_Min.Caption = "FeO_Min";
            this.coldsSlagEleL3DataTableFeO_Min.ColumnName = "FeO_Min";
            this.coldsSlagEleL3DataTableFeO_Min.Namespace = "";
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
            // bsSlagEle
            // 
            this.bsSlagEle.DataMember = "L3DataTable";
            this.bsSlagEle.DataSource = this.dsSlagEle;
            // 
            // tabSlagEle
            // 
            this.tabSlagEle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSlagEle.Controls.Add(this.groupBox17);
            this.tabSlagEle.Controls.Add(this.groupBox6);
            this.tabSlagEle.Location = new System.Drawing.Point(4, 21);
            this.tabSlagEle.Name = "tabSlagEle";
            this.tabSlagEle.Size = new System.Drawing.Size(1012, 587);
            this.tabSlagEle.TabIndex = 8;
            this.tabSlagEle.Text = "炉后渣样信息";
            this.tabSlagEle.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label39);
            this.groupBox17.Controls.Add(this.label40);
            this.groupBox17.Controls.Add(this.label77);
            this.groupBox17.Controls.Add(this.label37);
            this.groupBox17.Controls.Add(this.label103);
            this.groupBox17.Controls.Add(this.label36);
            this.groupBox17.Controls.Add(this.label78);
            this.groupBox17.Controls.Add(this.label35);
            this.groupBox17.Controls.Add(this.label79);
            this.groupBox17.Controls.Add(this.txtFeOMax);
            this.groupBox17.Controls.Add(this.txtPMax);
            this.groupBox17.Controls.Add(this.txtTiO2Max);
            this.groupBox17.Controls.Add(this.txtSMax);
            this.groupBox17.Controls.Add(this.label83);
            this.groupBox17.Controls.Add(this.txtMnOMax);
            this.groupBox17.Controls.Add(this.txtFeOMin);
            this.groupBox17.Controls.Add(this.txtAl2O3Max);
            this.groupBox17.Controls.Add(this.txtPMin);
            this.groupBox17.Controls.Add(this.txtTiO2Min);
            this.groupBox17.Controls.Add(this.label102);
            this.groupBox17.Controls.Add(this.txtSMin);
            this.groupBox17.Controls.Add(this.txtMnOMin);
            this.groupBox17.Controls.Add(this.txtMgOMax);
            this.groupBox17.Controls.Add(this.txtAl2O3Min);
            this.groupBox17.Controls.Add(this.txtCaOMin);
            this.groupBox17.Controls.Add(this.txtMgOMin);
            this.groupBox17.Controls.Add(this.txtSiO2Max);
            this.groupBox17.Controls.Add(this.txtSiO2Min);
            this.groupBox17.Controls.Add(this.txtCaOMax);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox17.Location = new System.Drawing.Point(0, 54);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1010, 101);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "精炼渣";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 75);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 12);
            this.label39.TabIndex = 2;
            this.label39.Text = "最小:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 44);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 12);
            this.label40.TabIndex = 2;
            this.label40.Text = "最大:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(92, 22);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(23, 12);
            this.label77.TabIndex = 2;
            this.label77.Text = "CaO";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(940, 21);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 12);
            this.label37.TabIndex = 2;
            this.label37.Text = "FeO";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(628, 21);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(11, 12);
            this.label103.TabIndex = 2;
            this.label103.Text = "P";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(831, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(29, 12);
            this.label36.TabIndex = 2;
            this.label36.Text = "TiO2";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(522, 21);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(11, 12);
            this.label78.TabIndex = 2;
            this.label78.Text = "S";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(728, 21);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(23, 12);
            this.label35.TabIndex = 2;
            this.label35.Text = "MnO";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(404, 21);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(35, 12);
            this.label79.TabIndex = 2;
            this.label79.Text = "Al2O3";
            // 
            // txtFeOMax
            // 
            this.txtFeOMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "FeO_Max", true));
            //
            this.txtFeOMax.EnableNull = true;
            this.txtFeOMax.ErropPr = this.errorProvider1;
            //
            this.txtFeOMax.Length = 0;
            this.txtFeOMax.Location = new System.Drawing.Point(901, 40);
            this.txtFeOMax.Max = 999;
            ////
            //
            this.txtFeOMax.MaxStrLength = 0;
            this.txtFeOMax.Min = 0;
            ////
            //
            this.txtFeOMax.MinStrLength = 0;
            this.txtFeOMax.Name = "txtFeOMax";
            this.txtFeOMax.Precision = 0;
            //
            this.txtFeOMax.Size = new System.Drawing.Size(100, 21);
            this.txtFeOMax.TabIndex = 16;
            this.txtFeOMax.ToolTipValid = this.toolTip1;
          //
            this.txtFeOMax.ValidEable = true;
            this.txtFeOMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
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
            // txtPMax
            // 
            this.txtPMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "P_Max", true));
            //
            this.txtPMax.EnableNull = true;
            this.txtPMax.ErropPr = this.errorProvider1;
            //
            this.txtPMax.Length = 0;
            this.txtPMax.Location = new System.Drawing.Point(583, 40);
            this.txtPMax.Max = 999;
            ////
            //
            this.txtPMax.MaxStrLength = 0;
            this.txtPMax.Min = 0;
            ////
            //
            this.txtPMax.MinStrLength = 0;
            this.txtPMax.Name = "txtPMax";
            this.txtPMax.Precision = 0;
            //
            this.txtPMax.Size = new System.Drawing.Size(100, 21);
            this.txtPMax.TabIndex = 10;
            this.txtPMax.ToolTipValid = this.toolTip1;
          //
            this.txtPMax.ValidEable = true;
            this.txtPMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTiO2Max
            // 
            this.txtTiO2Max.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "TiO2_Max", true));
            //
            this.txtTiO2Max.EnableNull = true;
            this.txtTiO2Max.ErropPr = this.errorProvider1;
            //
            this.txtTiO2Max.Length = 0;
            this.txtTiO2Max.Location = new System.Drawing.Point(795, 40);
            this.txtTiO2Max.Max = 999;
            ////
            //
            this.txtTiO2Max.MaxStrLength = 0;
            this.txtTiO2Max.Min = 0;
            ////
            //
            this.txtTiO2Max.MinStrLength = 0;
            this.txtTiO2Max.Name = "txtTiO2Max";
            this.txtTiO2Max.Precision = 0;
            //
            this.txtTiO2Max.Size = new System.Drawing.Size(100, 21);
            this.txtTiO2Max.TabIndex = 14;
            this.txtTiO2Max.ToolTipValid = this.toolTip1;
          //
            this.txtTiO2Max.ValidEable = true;
            this.txtTiO2Max.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtSMax
            // 
            this.txtSMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "S_Max", true));
            //
            this.txtSMax.EnableNull = true;
            this.txtSMax.ErropPr = this.errorProvider1;
            //
            this.txtSMax.Length = 0;
            this.txtSMax.Location = new System.Drawing.Point(477, 40);
            this.txtSMax.Max = 999;
            ////
            //
            this.txtSMax.MaxStrLength = 0;
            this.txtSMax.Min = 0;
            ////
            //
            this.txtSMax.MinStrLength = 0;
            this.txtSMax.Name = "txtSMax";
            this.txtSMax.Precision = 0;
            //
            this.txtSMax.Size = new System.Drawing.Size(100, 21);
            this.txtSMax.TabIndex = 8;
            this.txtSMax.ToolTipValid = this.toolTip1;
          //
            this.txtSMax.ValidEable = true;
            this.txtSMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(304, 22);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(23, 12);
            this.label83.TabIndex = 2;
            this.label83.Text = "MgO";
            // 
            // txtMnOMax
            // 
            this.txtMnOMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "MnO_Max", true));
            //
            this.txtMnOMax.EnableNull = true;
            this.txtMnOMax.ErropPr = this.errorProvider1;
            //
            this.txtMnOMax.Length = 0;
            this.txtMnOMax.Location = new System.Drawing.Point(689, 40);
            this.txtMnOMax.Max = 999;
            ////
            //
            this.txtMnOMax.MaxStrLength = 0;
            this.txtMnOMax.Min = 0;
            ////
            //
            this.txtMnOMax.MinStrLength = 0;
            this.txtMnOMax.Name = "txtMnOMax";
            this.txtMnOMax.Precision = 0;
            //
            this.txtMnOMax.Size = new System.Drawing.Size(100, 21);
            this.txtMnOMax.TabIndex = 12;
            this.txtMnOMax.ToolTipValid = this.toolTip1;
          //
            this.txtMnOMax.ValidEable = true;
            this.txtMnOMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtFeOMin
            // 
            this.txtFeOMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "FeO_Min", true));
            //
            this.txtFeOMin.EnableNull = true;
            this.txtFeOMin.ErropPr = this.errorProvider1;
            //
            this.txtFeOMin.Length = 0;
            this.txtFeOMin.Location = new System.Drawing.Point(901, 71);
            this.txtFeOMin.Max = 999;
            ////
            //
            this.txtFeOMin.MaxStrLength = 0;
            this.txtFeOMin.Min = 0;
            ////
            //
            this.txtFeOMin.MinStrLength = 0;
            this.txtFeOMin.Name = "txtFeOMin";
            this.txtFeOMin.Precision = 0;
            //
            this.txtFeOMin.Size = new System.Drawing.Size(100, 21);
            this.txtFeOMin.TabIndex = 17;
            this.txtFeOMin.ToolTipValid = this.toolTip1;
          //
            this.txtFeOMin.ValidEable = true;
            this.txtFeOMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtAl2O3Max
            // 
            this.txtAl2O3Max.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "Al2O3_Max", true));
            //
            this.txtAl2O3Max.EnableNull = true;
            this.txtAl2O3Max.ErropPr = this.errorProvider1;
            //
            this.txtAl2O3Max.Length = 0;
            this.txtAl2O3Max.Location = new System.Drawing.Point(371, 40);
            this.txtAl2O3Max.Max = 999;
            ////
            //
            this.txtAl2O3Max.MaxStrLength = 0;
            this.txtAl2O3Max.Min = 0;
            ////
            //
            this.txtAl2O3Max.MinStrLength = 0;
            this.txtAl2O3Max.Name = "txtAl2O3Max";
            this.txtAl2O3Max.Precision = 0;
            //
            this.txtAl2O3Max.Size = new System.Drawing.Size(100, 21);
            this.txtAl2O3Max.TabIndex = 6;
            this.txtAl2O3Max.ToolTipValid = this.toolTip1;
          //
            this.txtAl2O3Max.ValidEable = true;
            this.txtAl2O3Max.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPMin
            // 
            this.txtPMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "P_Min", true));
            //
            this.txtPMin.EnableNull = true;
            this.txtPMin.ErropPr = this.errorProvider1;
            //
            this.txtPMin.Length = 0;
            this.txtPMin.Location = new System.Drawing.Point(583, 71);
            this.txtPMin.Max = 999;
            ////
            //
            this.txtPMin.MaxStrLength = 0;
            this.txtPMin.Min = 0;
            ////
            //
            this.txtPMin.MinStrLength = 0;
            this.txtPMin.Name = "txtPMin";
            this.txtPMin.Precision = 0;
            //
            this.txtPMin.Size = new System.Drawing.Size(100, 21);
            this.txtPMin.TabIndex = 11;
            this.txtPMin.ToolTipValid = this.toolTip1;
          //
            this.txtPMin.ValidEable = true;
            this.txtPMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTiO2Min
            // 
            this.txtTiO2Min.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "TiO2_Min", true));
            //
            this.txtTiO2Min.EnableNull = true;
            this.txtTiO2Min.ErropPr = this.errorProvider1;
            //
            this.txtTiO2Min.Length = 0;
            this.txtTiO2Min.Location = new System.Drawing.Point(795, 71);
            this.txtTiO2Min.Max = 999;
            ////
            //
            this.txtTiO2Min.MaxStrLength = 0;
            this.txtTiO2Min.Min = 0;
            ////
            //
            this.txtTiO2Min.MinStrLength = 0;
            this.txtTiO2Min.Name = "txtTiO2Min";
            this.txtTiO2Min.Precision = 0;
            //
            this.txtTiO2Min.Size = new System.Drawing.Size(100, 21);
            this.txtTiO2Min.TabIndex = 15;
            this.txtTiO2Min.ToolTipValid = this.toolTip1;
          //
            this.txtTiO2Min.ValidEable = true;
            this.txtTiO2Min.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(195, 22);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(29, 12);
            this.label102.TabIndex = 2;
            this.label102.Text = "SiO2";
            // 
            // txtSMin
            // 
            this.txtSMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "S_Min", true));
            //
            this.txtSMin.EnableNull = true;
            this.txtSMin.ErropPr = this.errorProvider1;
            //
            this.txtSMin.Length = 0;
            this.txtSMin.Location = new System.Drawing.Point(477, 71);
            this.txtSMin.Max = 999;
            ////
            //
            this.txtSMin.MaxStrLength = 0;
            this.txtSMin.Min = 0;
            ////
            //
            this.txtSMin.MinStrLength = 0;
            this.txtSMin.Name = "txtSMin";
            this.txtSMin.Precision = 0;
            //
            this.txtSMin.Size = new System.Drawing.Size(100, 21);
            this.txtSMin.TabIndex = 9;
            this.txtSMin.ToolTipValid = this.toolTip1;
          //
            this.txtSMin.ValidEable = true;
            this.txtSMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtMnOMin
            // 
            this.txtMnOMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "MnO_Min", true));
            //
            this.txtMnOMin.EnableNull = true;
            this.txtMnOMin.ErropPr = this.errorProvider1;
            //
            this.txtMnOMin.Length = 0;
            this.txtMnOMin.Location = new System.Drawing.Point(689, 71);
            this.txtMnOMin.Max = 999;
            ////
            //
            this.txtMnOMin.MaxStrLength = 0;
            this.txtMnOMin.Min = 0;
            ////
            //
            this.txtMnOMin.MinStrLength = 0;
            this.txtMnOMin.Name = "txtMnOMin";
            this.txtMnOMin.Precision = 0;
            //
            this.txtMnOMin.Size = new System.Drawing.Size(100, 21);
            this.txtMnOMin.TabIndex = 13;
            this.txtMnOMin.ToolTipValid = this.toolTip1;
          //
            this.txtMnOMin.ValidEable = true;
            this.txtMnOMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtMgOMax
            // 
            this.txtMgOMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "MgO_Max", true));
            //
            this.txtMgOMax.EnableNull = true;
            this.txtMgOMax.ErropPr = this.errorProvider1;
            //
            this.txtMgOMax.Length = 0;
            this.txtMgOMax.Location = new System.Drawing.Point(265, 40);
            this.txtMgOMax.Max = 999;
            ////
            //
            this.txtMgOMax.MaxStrLength = 0;
            this.txtMgOMax.Min = 0;
           // //
            //
            this.txtMgOMax.MinStrLength = 0;
            this.txtMgOMax.Name = "txtMgOMax";
            this.txtMgOMax.Precision = 0;
            //
            this.txtMgOMax.Size = new System.Drawing.Size(100, 21);
            this.txtMgOMax.TabIndex = 4;
            this.txtMgOMax.ToolTipValid = this.toolTip1;
          //
            this.txtMgOMax.ValidEable = true;
            this.txtMgOMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtAl2O3Min
            // 
            this.txtAl2O3Min.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "Al2O3_Min", true));
            //
            this.txtAl2O3Min.EnableNull = true;
            this.txtAl2O3Min.ErropPr = this.errorProvider1;
            //
            this.txtAl2O3Min.Length = 0;
            this.txtAl2O3Min.Location = new System.Drawing.Point(371, 71);
            this.txtAl2O3Min.Max = 999;
            ////
            //
            this.txtAl2O3Min.MaxStrLength = 0;
            this.txtAl2O3Min.Min = 0;
            ////
            //
            this.txtAl2O3Min.MinStrLength = 0;
            this.txtAl2O3Min.Name = "txtAl2O3Min";
            this.txtAl2O3Min.Precision = 0;
            //
            this.txtAl2O3Min.Size = new System.Drawing.Size(100, 21);
            this.txtAl2O3Min.TabIndex = 7;
            this.txtAl2O3Min.ToolTipValid = this.toolTip1;
          //
            this.txtAl2O3Min.ValidEable = true;
            this.txtAl2O3Min.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCaOMin
            // 
            this.txtCaOMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "CaO_Min", true));
            //
            this.txtCaOMin.EnableNull = true;
            this.txtCaOMin.ErropPr = this.errorProvider1;
            //
            this.txtCaOMin.Length = 0;
            this.txtCaOMin.Location = new System.Drawing.Point(53, 71);
            this.txtCaOMin.Max = 999;
            ////
            //
            this.txtCaOMin.MaxStrLength = 0;
            this.txtCaOMin.Min = 0;
            ////
            //
            this.txtCaOMin.MinStrLength = 0;
            this.txtCaOMin.Name = "txtCaOMin";
            this.txtCaOMin.Precision = 0;
            //
            this.txtCaOMin.Size = new System.Drawing.Size(100, 21);
            this.txtCaOMin.TabIndex = 1;
            this.txtCaOMin.ToolTipValid = this.toolTip1;
          //
            this.txtCaOMin.ValidEable = true;
            this.txtCaOMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtMgOMin
            // 
            this.txtMgOMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "MgO_Min", true));
            //
            this.txtMgOMin.EnableNull = true;
            this.txtMgOMin.ErropPr = this.errorProvider1;
            //
            this.txtMgOMin.Length = 0;
            this.txtMgOMin.Location = new System.Drawing.Point(265, 71);
            this.txtMgOMin.Max = 999;
            ////
            //
            this.txtMgOMin.MaxStrLength = 0;
            this.txtMgOMin.Min = 0;
            ////
            //
            this.txtMgOMin.MinStrLength = 0;
            this.txtMgOMin.Name = "txtMgOMin";
            this.txtMgOMin.Precision = 0;
            //
            this.txtMgOMin.Size = new System.Drawing.Size(100, 21);
            this.txtMgOMin.TabIndex = 5;
            this.txtMgOMin.ToolTipValid = this.toolTip1;
          //
            this.txtMgOMin.ValidEable = true;
            this.txtMgOMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtSiO2Max
            // 
            this.txtSiO2Max.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "SiO2_Max", true));
            //
            this.txtSiO2Max.EnableNull = true;
            this.txtSiO2Max.ErropPr = this.errorProvider1;
            //
            this.txtSiO2Max.Length = 0;
            this.txtSiO2Max.Location = new System.Drawing.Point(159, 40);
            this.txtSiO2Max.Max = 999;
            ////
            //
            this.txtSiO2Max.MaxStrLength = 0;
            this.txtSiO2Max.Min = 0;
            ////
            //
            this.txtSiO2Max.MinStrLength = 0;
            this.txtSiO2Max.Name = "txtSiO2Max";
            this.txtSiO2Max.Precision = 0;
            //
            this.txtSiO2Max.Size = new System.Drawing.Size(100, 21);
            this.txtSiO2Max.TabIndex = 2;
            this.txtSiO2Max.ToolTipValid = this.toolTip1;
          //
            this.txtSiO2Max.ValidEable = true;
            this.txtSiO2Max.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtSiO2Min
            // 
            this.txtSiO2Min.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "SiO2_Min", true));
            //
            this.txtSiO2Min.EnableNull = true;
            this.txtSiO2Min.ErropPr = this.errorProvider1;
            //
            this.txtSiO2Min.Length = 0;
            this.txtSiO2Min.Location = new System.Drawing.Point(159, 71);
            this.txtSiO2Min.Max = 999;
            ////
            //
            this.txtSiO2Min.MaxStrLength = 0;
            this.txtSiO2Min.Min = 0;
            ////
            //
            this.txtSiO2Min.MinStrLength = 0;
            this.txtSiO2Min.Name = "txtSiO2Min";
            this.txtSiO2Min.Precision = 0;
            //
            this.txtSiO2Min.Size = new System.Drawing.Size(100, 21);
            this.txtSiO2Min.TabIndex = 3;
            this.txtSiO2Min.ToolTipValid = this.toolTip1;
          //
            this.txtSiO2Min.ValidEable = true;
            this.txtSiO2Min.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCaOMax
            // 
            this.txtCaOMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "CaO_Max", true));
            //
            this.txtCaOMax.EnableNull = true;
            this.txtCaOMax.ErropPr = this.errorProvider1;
            //
            this.txtCaOMax.Length = 0;
            this.txtCaOMax.Location = new System.Drawing.Point(53, 40);
            this.txtCaOMax.Max = 999;
            ////
            //
            this.txtCaOMax.MaxStrLength = 0;
            this.txtCaOMax.Min = 0;
            ////
            //
            this.txtCaOMax.MinStrLength = 0;
            this.txtCaOMax.Name = "txtCaOMax";
            this.txtCaOMax.Precision = 0;
            //
            this.txtCaOMax.Size = new System.Drawing.Size(100, 21);
            this.txtCaOMax.TabIndex = 0;
            this.txtCaOMax.ToolTipValid = this.toolTip1;
          //
            this.txtCaOMax.ValidEable = true;
            this.txtCaOMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtSteelGradeIndexSlagEle);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1010, 54);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // txtSteelGradeIndexSlagEle
            // 
            this.txtSteelGradeIndexSlagEle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexSlagEle.EnableNull = false;
            this.txtSteelGradeIndexSlagEle.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexSlagEle.Length = 0;
            this.txtSteelGradeIndexSlagEle.Location = new System.Drawing.Point(98, 17);
            this.txtSteelGradeIndexSlagEle.Max = 0;
            ////
            //
            this.txtSteelGradeIndexSlagEle.MaxStrLength = 0;
            this.txtSteelGradeIndexSlagEle.Min = 0;
           // //
            //
            this.txtSteelGradeIndexSlagEle.MinStrLength = 0;
            this.txtSteelGradeIndexSlagEle.Name = "txtSteelGradeIndexSlagEle";
            this.txtSteelGradeIndexSlagEle.Precision = 0;
            this.txtSteelGradeIndexSlagEle.ReadOnly = true;
            //
            this.txtSteelGradeIndexSlagEle.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexSlagEle.TabIndex = 0;
            this.txtSteelGradeIndexSlagEle.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexSlagEle.ValidEable = true;
            this.txtSteelGradeIndexSlagEle.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(33, 20);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(59, 12);
            this.label38.TabIndex = 14;
            this.label38.Text = "炼钢记号:";
            // 
            // tabLadle
            // 
            this.tabLadle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLadle.Controls.Add(this.hmiRootPanelLadle);
            this.tabLadle.Location = new System.Drawing.Point(4, 21);
            this.tabLadle.Name = "tabLadle";
            this.tabLadle.Size = new System.Drawing.Size(1012, 587);
            this.tabLadle.TabIndex = 7;
            this.tabLadle.Text = "钢包覆盖剂信息";
            this.tabLadle.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanelLadle
            // 
            this.hmiRootPanelLadle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelLadle.Controls.Add(this.dvLadle);
            this.hmiRootPanelLadle.Controls.Add(this.bNavigatorLadle);
            this.hmiRootPanelLadle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelLadle.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanelLadle.Name = "hmiRootPanelLadle";
            this.hmiRootPanelLadle.Size = new System.Drawing.Size(1010, 585);
            this.hmiRootPanelLadle.TabIndex = 29;
            // 
            // dvLadle
            // 
            this.dvLadle.AllowUserToAddRows = false;
            this.dvLadle.AutoGenerateColumns = false;
            this.dvLadle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvLadle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvLadle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvLadle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn3,
            this.ladleMatNameDataGridViewTextBoxColumn,
            this.ladleMatMinDataGridViewTextBoxColumn,
            this.ladleMatMaxDataGridViewTextBoxColumn,
            this.ladleMatAimDataGridViewTextBoxColumn});
            this.dvLadle.DataSource = this.bsLadle;
            this.dvLadle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvLadle.Location = new System.Drawing.Point(0, 25);
            this.dvLadle.Name = "dvLadle";
            this.dvLadle.RowTemplate.Height = 23;
            this.dvLadle.Size = new System.Drawing.Size(1006, 556);
            this.dvLadle.TabIndex = 1;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn3
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn3.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn3.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn3.Name = "steelGradeIndexDataGridViewTextBoxColumn3";
            this.steelGradeIndexDataGridViewTextBoxColumn3.Width = 78;
            // 
            // ladleMatNameDataGridViewTextBoxColumn
            // 
            this.ladleMatNameDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Mat_Name";
            this.ladleMatNameDataGridViewTextBoxColumn.HeaderText = "钢包物料名称";
            this.ladleMatNameDataGridViewTextBoxColumn.Name = "ladleMatNameDataGridViewTextBoxColumn";
            this.ladleMatNameDataGridViewTextBoxColumn.Width = 102;
            // 
            // ladleMatMinDataGridViewTextBoxColumn
            // 
            this.ladleMatMinDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Mat_Min";
            this.ladleMatMinDataGridViewTextBoxColumn.HeaderText = "钢包物料数量最小";
            this.ladleMatMinDataGridViewTextBoxColumn.Name = "ladleMatMinDataGridViewTextBoxColumn";
            this.ladleMatMinDataGridViewTextBoxColumn.Width = 126;
            // 
            // ladleMatMaxDataGridViewTextBoxColumn
            // 
            this.ladleMatMaxDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Mat_Max";
            this.ladleMatMaxDataGridViewTextBoxColumn.HeaderText = "钢包物料数量最大";
            this.ladleMatMaxDataGridViewTextBoxColumn.Name = "ladleMatMaxDataGridViewTextBoxColumn";
            this.ladleMatMaxDataGridViewTextBoxColumn.Width = 126;
            // 
            // ladleMatAimDataGridViewTextBoxColumn
            // 
            this.ladleMatAimDataGridViewTextBoxColumn.DataPropertyName = "Ladle_Mat_Aim";
            this.ladleMatAimDataGridViewTextBoxColumn.HeaderText = "钢包物料数量目标";
            this.ladleMatAimDataGridViewTextBoxColumn.Name = "ladleMatAimDataGridViewTextBoxColumn";
            this.ladleMatAimDataGridViewTextBoxColumn.Width = 126;
            // 
            // bNavigatorLadle
            // 
            this.bNavigatorLadle.AddNewItem = null;
            this.bNavigatorLadle.BindingSource = this.bsLadle;
            this.bNavigatorLadle.CountItem = this.bindingNavigatorCountItem2;
            this.bNavigatorLadle.DeleteItem = null;
            this.bNavigatorLadle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.btnAddLadle,
            this.btnDelLadle});
            this.bNavigatorLadle.Location = new System.Drawing.Point(0, 0);
            this.bNavigatorLadle.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bNavigatorLadle.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bNavigatorLadle.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bNavigatorLadle.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bNavigatorLadle.Name = "bNavigatorLadle";
            this.bNavigatorLadle.PositionItem = this.bindingNavigatorPositionItem2;
            this.bNavigatorLadle.Size = new System.Drawing.Size(1006, 25);
            this.bNavigatorLadle.TabIndex = 0;
            this.bNavigatorLadle.Text = "bindingNavigator3";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem2.Text = "/ {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "位置";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tabSlag
            // 
            this.tabSlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSlag.Controls.Add(this.hmiRootPanelSlag);
            this.tabSlag.Location = new System.Drawing.Point(4, 21);
            this.tabSlag.Name = "tabSlag";
            this.tabSlag.Size = new System.Drawing.Size(1012, 587);
            this.tabSlag.TabIndex = 11;
            this.tabSlag.Text = "渣料信息";
            this.tabSlag.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanelSlag
            // 
            this.hmiRootPanelSlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelSlag.Controls.Add(this.dvSlag);
            this.hmiRootPanelSlag.Controls.Add(this.bNavigatorSlag);
            this.hmiRootPanelSlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelSlag.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanelSlag.Name = "hmiRootPanelSlag";
            this.hmiRootPanelSlag.Size = new System.Drawing.Size(1010, 585);
            this.hmiRootPanelSlag.TabIndex = 30;
            // 
            // dvSlag
            // 
            this.dvSlag.AllowUserToAddRows = false;
            this.dvSlag.AutoGenerateColumns = false;
            this.dvSlag.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSlag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSlag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn2,
            this.slagCodeDataGridViewTextBoxColumn,
            this.slagWeightDataGridViewTextBoxColumn,
            this.GUID_Slag});
            this.dvSlag.DataSource = this.bsSlag;
            this.dvSlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSlag.Location = new System.Drawing.Point(0, 25);
            this.dvSlag.Name = "dvSlag";
            this.dvSlag.RowTemplate.Height = 23;
            this.dvSlag.Size = new System.Drawing.Size(1006, 556);
            this.dvSlag.TabIndex = 1;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn2
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn2.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn2.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn2.Name = "steelGradeIndexDataGridViewTextBoxColumn2";
            // 
            // slagCodeDataGridViewTextBoxColumn
            // 
            this.slagCodeDataGridViewTextBoxColumn.DataPropertyName = "Slag_Code";
            this.slagCodeDataGridViewTextBoxColumn.HeaderText = "渣料牌号";
            this.slagCodeDataGridViewTextBoxColumn.Name = "slagCodeDataGridViewTextBoxColumn";
            // 
            // slagWeightDataGridViewTextBoxColumn
            // 
            this.slagWeightDataGridViewTextBoxColumn.DataPropertyName = "Slag_Weight";
            this.slagWeightDataGridViewTextBoxColumn.HeaderText = "渣料加入量";
            this.slagWeightDataGridViewTextBoxColumn.Name = "slagWeightDataGridViewTextBoxColumn";
            // 
            // GUID_Slag
            // 
            this.GUID_Slag.DataPropertyName = "GUID";
            this.GUID_Slag.HeaderText = "GUID";
            this.GUID_Slag.Name = "GUID_Slag";
            this.GUID_Slag.Visible = false;
            // 
            // bNavigatorSlag
            // 
            this.bNavigatorSlag.AddNewItem = null;
            this.bNavigatorSlag.BindingSource = this.bsSlag;
            this.bNavigatorSlag.CountItem = this.toolStripLabel3;
            this.bNavigatorSlag.DeleteItem = null;
            this.bNavigatorSlag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator5,
            this.btnAddSlag,
            this.btnDelSlag});
            this.bNavigatorSlag.Location = new System.Drawing.Point(0, 0);
            this.bNavigatorSlag.MoveFirstItem = this.toolStripButton3;
            this.bNavigatorSlag.MoveLastItem = this.toolStripButton6;
            this.bNavigatorSlag.MoveNextItem = this.toolStripButton5;
            this.bNavigatorSlag.MovePreviousItem = this.toolStripButton4;
            this.bNavigatorSlag.Name = "bNavigatorSlag";
            this.bNavigatorSlag.PositionItem = this.toolStripTextBox1;
            this.bNavigatorSlag.Size = new System.Drawing.Size(1006, 25);
            this.bNavigatorSlag.TabIndex = 0;
            this.bNavigatorSlag.Text = "bindingNavigator3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "/ {0}";
            this.toolStripLabel3.ToolTipText = "总项数";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到第一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到上一条记录";
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
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到下一条记录";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到最后一条记录";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            this.cAbsorptionRateDataGridViewTextBoxColumn,
            this.alAbsorptionRateDataGridViewTextBoxColumn,
            this.caProcCode1DataGridViewTextBoxColumn,
            this.caProcFirCode1WeightMaxDataGridViewTextBoxColumn,
            this.caProcFirCode1WeightMinDataGridViewTextBoxColumn,
            this.caProcCode1WeightMaxDataGridViewTextBoxColumn,
            this.caProcCode1WeightMinDataGridViewTextBoxColumn,
            this.oxyFlagDataGridViewTextBoxColumn});
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
            this.steelGradeIndexDataGridViewTextBoxColumn1.Width = 78;
            // 
            // cAbsorptionRateDataGridViewTextBoxColumn
            // 
            this.cAbsorptionRateDataGridViewTextBoxColumn.DataPropertyName = "C_Absorption_Rate";
            this.cAbsorptionRateDataGridViewTextBoxColumn.HeaderText = "碳线中碳吸收率";
            this.cAbsorptionRateDataGridViewTextBoxColumn.Name = "cAbsorptionRateDataGridViewTextBoxColumn";
            this.cAbsorptionRateDataGridViewTextBoxColumn.Width = 114;
            // 
            // alAbsorptionRateDataGridViewTextBoxColumn
            // 
            this.alAbsorptionRateDataGridViewTextBoxColumn.DataPropertyName = "Al_Absorption_Rate";
            this.alAbsorptionRateDataGridViewTextBoxColumn.HeaderText = "铝线中铝吸收率";
            this.alAbsorptionRateDataGridViewTextBoxColumn.Name = "alAbsorptionRateDataGridViewTextBoxColumn";
            this.alAbsorptionRateDataGridViewTextBoxColumn.Width = 114;
            // 
            // caProcCode1DataGridViewTextBoxColumn
            // 
            this.caProcCode1DataGridViewTextBoxColumn.DataPropertyName = "CaProc_Code1";
            this.caProcCode1DataGridViewTextBoxColumn.HeaderText = "Ca处理喂丝线";
            this.caProcCode1DataGridViewTextBoxColumn.Name = "caProcCode1DataGridViewTextBoxColumn";
            this.caProcCode1DataGridViewTextBoxColumn.Width = 102;
            // 
            // caProcFirCode1WeightMaxDataGridViewTextBoxColumn
            // 
            this.caProcFirCode1WeightMaxDataGridViewTextBoxColumn.DataPropertyName = "CaProcFir_Code1_Weight_Max";
            this.caProcFirCode1WeightMaxDataGridViewTextBoxColumn.HeaderText = "Ca处理喂线喂入量最大(连铸第一炉)";
            this.caProcFirCode1WeightMaxDataGridViewTextBoxColumn.Name = "caProcFirCode1WeightMaxDataGridViewTextBoxColumn";
            this.caProcFirCode1WeightMaxDataGridViewTextBoxColumn.Width = 222;
            // 
            // caProcFirCode1WeightMinDataGridViewTextBoxColumn
            // 
            this.caProcFirCode1WeightMinDataGridViewTextBoxColumn.DataPropertyName = "CaProcFir_Code1_Weight_Min";
            this.caProcFirCode1WeightMinDataGridViewTextBoxColumn.HeaderText = "Ca处理喂线喂入量最小(连铸第一炉)";
            this.caProcFirCode1WeightMinDataGridViewTextBoxColumn.Name = "caProcFirCode1WeightMinDataGridViewTextBoxColumn";
            this.caProcFirCode1WeightMinDataGridViewTextBoxColumn.Width = 222;
            // 
            // caProcCode1WeightMaxDataGridViewTextBoxColumn
            // 
            this.caProcCode1WeightMaxDataGridViewTextBoxColumn.DataPropertyName = "CaProc_Code1_Weight_Max";
            this.caProcCode1WeightMaxDataGridViewTextBoxColumn.HeaderText = "Ca处理喂线喂入量最大(连浇炉)";
            this.caProcCode1WeightMaxDataGridViewTextBoxColumn.Name = "caProcCode1WeightMaxDataGridViewTextBoxColumn";
            this.caProcCode1WeightMaxDataGridViewTextBoxColumn.Width = 198;
            // 
            // caProcCode1WeightMinDataGridViewTextBoxColumn
            // 
            this.caProcCode1WeightMinDataGridViewTextBoxColumn.DataPropertyName = "CaProc_Code1_Weight_Min";
            this.caProcCode1WeightMinDataGridViewTextBoxColumn.HeaderText = "Ca处理喂线喂入量最小(连浇炉)";
            this.caProcCode1WeightMinDataGridViewTextBoxColumn.Name = "caProcCode1WeightMinDataGridViewTextBoxColumn";
            this.caProcCode1WeightMinDataGridViewTextBoxColumn.Width = 198;
            // 
            // oxyFlagDataGridViewTextBoxColumn
            // 
            this.oxyFlagDataGridViewTextBoxColumn.DataPropertyName = "Oxy_Flag";
            this.oxyFlagDataGridViewTextBoxColumn.HeaderText = "定氧否";
            this.oxyFlagDataGridViewTextBoxColumn.Name = "oxyFlagDataGridViewTextBoxColumn";
            this.oxyFlagDataGridViewTextBoxColumn.Width = 66;
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
            this.dvAlloy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAlloy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // 
            // alloyFlagDataGridViewTextBoxColumn
            // 
            this.alloyFlagDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Flag";
            this.alloyFlagDataGridViewTextBoxColumn.HeaderText = "合金化否";
            this.alloyFlagDataGridViewTextBoxColumn.Name = "alloyFlagDataGridViewTextBoxColumn";
            // 
            // alloyCodeDataGridViewTextBoxColumn
            // 
            this.alloyCodeDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Code";
            this.alloyCodeDataGridViewTextBoxColumn.HeaderText = "合金牌号";
            this.alloyCodeDataGridViewTextBoxColumn.Name = "alloyCodeDataGridViewTextBoxColumn";
            // 
            // alloyYieldDataGridViewTextBoxColumn
            // 
            this.alloyYieldDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Yield";
            this.alloyYieldDataGridViewTextBoxColumn.HeaderText = "合金收得率";
            this.alloyYieldDataGridViewTextBoxColumn.Name = "alloyYieldDataGridViewTextBoxColumn";
            // 
            // bNavigatorAlloy
            // 
            this.bNavigatorAlloy.AddNewItem = null;
            this.bNavigatorAlloy.BindingSource = this.bsAlloy;
            this.bNavigatorAlloy.CountItem = this.bindingNavigatorCountItem;
            this.bNavigatorAlloy.DeleteItem = null;
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
            // tabProc
            // 
            this.tabProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProc.Controls.Add(this.groupBox3);
            this.tabProc.Controls.Add(this.groupBox1);
            this.tabProc.Controls.Add(this.groupBox2);
            this.tabProc.Location = new System.Drawing.Point(4, 21);
            this.tabProc.Name = "tabProc";
            this.tabProc.Size = new System.Drawing.Size(1012, 587);
            this.tabProc.TabIndex = 10;
            this.tabProc.Text = "处理信息";
            this.tabProc.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtHotArmax);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtHotTimeMax);
            this.groupBox3.Controls.Add(this.txtRefineTimeMax);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtSoftArMax);
            this.groupBox3.Controls.Add(this.txtRefineTimeMin);
            this.groupBox3.Controls.Add(this.txtHoldSteelTimeMax);
            this.groupBox3.Controls.Add(this.txtHoldSteelTimeMin);
            this.groupBox3.Controls.Add(this.txtHotTimeMin);
            this.groupBox3.Controls.Add(this.txtSoftArMin);
            this.groupBox3.Controls.Add(this.txtHotArMin);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 94);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(45, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "最小:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(45, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "最大:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(110, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "加热时间";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(534, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "精炼时间";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(416, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "进站压钢时间";
            // 
            // txtHotArmax
            // 
            this.txtHotArmax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Hot_Ar_Max", true));
            //
            this.txtHotArmax.EnableNull = false;
            this.txtHotArmax.ErropPr = this.errorProvider1;
            //
            this.txtHotArmax.Length = 0;
            this.txtHotArmax.Location = new System.Drawing.Point(192, 68);
            this.txtHotArmax.Max = 9999;
            ////
            //
            this.txtHotArmax.MaxStrLength = 0;
            this.txtHotArmax.Min = 0;
            ////
            //
            this.txtHotArmax.MinStrLength = 0;
            this.txtHotArmax.Name = "txtHotArmax";
            this.txtHotArmax.Precision = 0;
            //
            this.txtHotArmax.Size = new System.Drawing.Size(100, 21);
            this.txtHotArmax.TabIndex = 3;
            this.txtHotArmax.ToolTipValid = this.toolTip1;
          //
            this.txtHotArmax.ValidEable = true;
            this.txtHotArmax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(316, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "软吹吹氩量";
            // 
            // txtHotTimeMax
            // 
            this.txtHotTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Hot_Time_Max", true));
            //
            this.txtHotTimeMax.EnableNull = false;
            this.txtHotTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtHotTimeMax.Length = 0;
            this.txtHotTimeMax.Location = new System.Drawing.Point(86, 68);
            this.txtHotTimeMax.Max = 9999;
            ////
            //
            this.txtHotTimeMax.MaxStrLength = 0;
            this.txtHotTimeMax.Min = 0;
            ////
            //
            this.txtHotTimeMax.MinStrLength = 0;
            this.txtHotTimeMax.Name = "txtHotTimeMax";
            this.txtHotTimeMax.Precision = 0;
            //
            this.txtHotTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtHotTimeMax.TabIndex = 1;
            this.txtHotTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtHotTimeMax.ValidEable = true;
            this.txtHotTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtRefineTimeMax
            // 
            this.txtRefineTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Refine_Time_Max", true));
            //
            this.txtRefineTimeMax.EnableNull = false;
            this.txtRefineTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtRefineTimeMax.Length = 0;
            this.txtRefineTimeMax.Location = new System.Drawing.Point(510, 68);
            this.txtRefineTimeMax.Max = 9999;
            ////
            //
            this.txtRefineTimeMax.MaxStrLength = 0;
            this.txtRefineTimeMax.Min = 0;
            ////
            //
            this.txtRefineTimeMax.MinStrLength = 0;
            this.txtRefineTimeMax.Name = "txtRefineTimeMax";
            this.txtRefineTimeMax.Precision = 0;
            //
            this.txtRefineTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtRefineTimeMax.TabIndex = 9;
            this.txtRefineTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtRefineTimeMax.ValidEable = true;
            this.txtRefineTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(210, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "加热吹氩量";
            // 
            // txtSoftArMax
            // 
            this.txtSoftArMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Soft_Ar_Max", true));
            //
            this.txtSoftArMax.EnableNull = false;
            this.txtSoftArMax.ErropPr = this.errorProvider1;
            //
            this.txtSoftArMax.Length = 0;
            this.txtSoftArMax.Location = new System.Drawing.Point(298, 68);
            this.txtSoftArMax.Max = 9999;
            ////
            //
            this.txtSoftArMax.MaxStrLength = 0;
            this.txtSoftArMax.Min = 0;
            ////
            //
            this.txtSoftArMax.MinStrLength = 0;
            this.txtSoftArMax.Name = "txtSoftArMax";
            this.txtSoftArMax.Precision = 0;
            //
            this.txtSoftArMax.Size = new System.Drawing.Size(100, 21);
            this.txtSoftArMax.TabIndex = 5;
            this.txtSoftArMax.ToolTipValid = this.toolTip1;
          //
            this.txtSoftArMax.ValidEable = true;
            this.txtSoftArMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtRefineTimeMin
            // 
            this.txtRefineTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Refine_Time_Min", true));
            //
            this.txtRefineTimeMin.EnableNull = false;
            this.txtRefineTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtRefineTimeMin.Length = 0;
            this.txtRefineTimeMin.Location = new System.Drawing.Point(510, 41);
            this.txtRefineTimeMin.Max = 9999;
            ////
            //
            this.txtRefineTimeMin.MaxStrLength = 0;
            this.txtRefineTimeMin.Min = 0;
            ////
            //
            this.txtRefineTimeMin.MinStrLength = 0;
            this.txtRefineTimeMin.Name = "txtRefineTimeMin";
            this.txtRefineTimeMin.Precision = 0;
            //
            this.txtRefineTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtRefineTimeMin.TabIndex = 8;
            this.txtRefineTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtRefineTimeMin.ValidEable = true;
            this.txtRefineTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtHoldSteelTimeMax
            // 
            this.txtHoldSteelTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Stay_Steel_Time_Max", true));
            //
            this.txtHoldSteelTimeMax.EnableNull = false;
            this.txtHoldSteelTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtHoldSteelTimeMax.Length = 0;
            this.txtHoldSteelTimeMax.Location = new System.Drawing.Point(404, 68);
            this.txtHoldSteelTimeMax.Max = 9999;
            ////
            //
            this.txtHoldSteelTimeMax.MaxStrLength = 0;
            this.txtHoldSteelTimeMax.Min = 0;
            ////
            //
            this.txtHoldSteelTimeMax.MinStrLength = 0;
            this.txtHoldSteelTimeMax.Name = "txtHoldSteelTimeMax";
            this.txtHoldSteelTimeMax.Precision = 0;
            //
            this.txtHoldSteelTimeMax.Size = new System.Drawing.Size(100, 21);
            this.txtHoldSteelTimeMax.TabIndex = 7;
            this.txtHoldSteelTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtHoldSteelTimeMax.ValidEable = true;
            this.txtHoldSteelTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtHoldSteelTimeMin
            // 
            this.txtHoldSteelTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Hold_Steel_Time_Max", true));
            //
            this.txtHoldSteelTimeMin.EnableNull = false;
            this.txtHoldSteelTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtHoldSteelTimeMin.Length = 0;
            this.txtHoldSteelTimeMin.Location = new System.Drawing.Point(404, 41);
            this.txtHoldSteelTimeMin.Max = 9999;
            ////
            //
            this.txtHoldSteelTimeMin.MaxStrLength = 0;
            this.txtHoldSteelTimeMin.Min = 0;
            ////
            //
            this.txtHoldSteelTimeMin.MinStrLength = 0;
            this.txtHoldSteelTimeMin.Name = "txtHoldSteelTimeMin";
            this.txtHoldSteelTimeMin.Precision = 0;
            //
            this.txtHoldSteelTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtHoldSteelTimeMin.TabIndex = 6;
            this.txtHoldSteelTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtHoldSteelTimeMin.ValidEable = true;
            this.txtHoldSteelTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtHotTimeMin
            // 
            this.txtHotTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Hot_Time_Min", true));
            //
            this.txtHotTimeMin.EnableNull = false;
            this.txtHotTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtHotTimeMin.Length = 0;
            this.txtHotTimeMin.Location = new System.Drawing.Point(86, 41);
            this.txtHotTimeMin.Max = 9999;
            ////
            //
            this.txtHotTimeMin.MaxStrLength = 0;
            this.txtHotTimeMin.Min = 0;
            ////
            //
            this.txtHotTimeMin.MinStrLength = 0;
            this.txtHotTimeMin.Name = "txtHotTimeMin";
            this.txtHotTimeMin.Precision = 0;
            //
            this.txtHotTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtHotTimeMin.TabIndex = 0;
            this.txtHotTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtHotTimeMin.ValidEable = true;
            this.txtHotTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtSoftArMin
            // 
            this.txtSoftArMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Soft_Ar_Min", true));
            //
            this.txtSoftArMin.EnableNull = false;
            this.txtSoftArMin.ErropPr = this.errorProvider1;
            //
            this.txtSoftArMin.Length = 0;
            this.txtSoftArMin.Location = new System.Drawing.Point(298, 41);
            this.txtSoftArMin.Max = 9999;
            ////
            //
            this.txtSoftArMin.MaxStrLength = 0;
            this.txtSoftArMin.Min = 0;
           // //
            //
            this.txtSoftArMin.MinStrLength = 0;
            this.txtSoftArMin.Name = "txtSoftArMin";
            this.txtSoftArMin.Precision = 0;
            //
            this.txtSoftArMin.Size = new System.Drawing.Size(100, 21);
            this.txtSoftArMin.TabIndex = 4;
            this.txtSoftArMin.ToolTipValid = this.toolTip1;
          //
            this.txtSoftArMin.ValidEable = true;
            this.txtSoftArMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtHotArMin
            // 
            this.txtHotArMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Hot_Ar_Min", true));
            //
            this.txtHotArMin.EnableNull = false;
            this.txtHotArMin.ErropPr = this.errorProvider1;
            //
            this.txtHotArMin.Length = 0;
            this.txtHotArMin.Location = new System.Drawing.Point(192, 41);
            this.txtHotArMin.Max = 9999;
            ////
            //
            this.txtHotArMin.MaxStrLength = 0;
            this.txtHotArMin.Min = 0;
           // //
            //
            this.txtHotArMin.MinStrLength = 0;
            this.txtHotArMin.Name = "txtHotArMin";
            this.txtHotArMin.Precision = 0;
            //
            this.txtHotArMin.Size = new System.Drawing.Size(100, 21);
            this.txtHotArMin.TabIndex = 2;
            this.txtHotArMin.ToolTipValid = this.toolTip1;
          //
            this.txtHotArMin.ValidEable = true;
            this.txtHotArMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtLeaFirTempAim);
            this.groupBox1.Controls.Add(this.txtLeaTempAim);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtLeaTempMin);
            this.groupBox1.Controls.Add(this.txtLeaTempMax);
            this.groupBox1.Controls.Add(this.txtLeaFirTempMin);
            this.groupBox1.Controls.Add(this.txtLeaFirTempMax);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LF离站温度";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(122, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "目标";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "最小";
            // 
            // txtLeaFirTempAim
            // 
            this.txtLeaFirTempAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "LeaFir_Temp_Aim", true));
            //
            this.txtLeaFirTempAim.EnableNull = false;
            this.txtLeaFirTempAim.ErropPr = this.errorProvider1;
            //
            this.txtLeaFirTempAim.Length = 0;
            this.txtLeaFirTempAim.Location = new System.Drawing.Point(86, 39);
            this.txtLeaFirTempAim.Max = 2000;
            ////
            //
            this.txtLeaFirTempAim.MaxStrLength = 0;
            this.txtLeaFirTempAim.Min = 0;
            ////
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
            this.txtLeaTempAim.Location = new System.Drawing.Point(86, 66);
            this.txtLeaTempAim.Max = 2000;
            ////
            //
            this.txtLeaTempAim.MaxStrLength = 0;
            this.txtLeaTempAim.Min = 0;
            ////
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(334, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "最大";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "连铸第一炉:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "连浇炉:";
            // 
            // txtLeaTempMin
            // 
            this.txtLeaTempMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Lea_Temp_Min", true));
            //
            this.txtLeaTempMin.EnableNull = false;
            this.txtLeaTempMin.ErropPr = this.errorProvider1;
            //
            this.txtLeaTempMin.Length = 0;
            this.txtLeaTempMin.Location = new System.Drawing.Point(192, 67);
            this.txtLeaTempMin.Max = 2000;
            ////
            //
            this.txtLeaTempMin.MaxStrLength = 0;
            this.txtLeaTempMin.Min = 0;
           // //
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
            this.txtLeaTempMax.Location = new System.Drawing.Point(298, 67);
            this.txtLeaTempMax.Max = 2000;
            ////
            //
            this.txtLeaTempMax.MaxStrLength = 0;
            this.txtLeaTempMax.Min = 0;
            ////
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
            this.txtLeaFirTempMin.Location = new System.Drawing.Point(192, 40);
            this.txtLeaFirTempMin.Max = 2000;
            ////
            //
            this.txtLeaFirTempMin.MaxStrLength = 0;
            this.txtLeaFirTempMin.Min = 0;
            ////
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
            this.txtLeaFirTempMax.Location = new System.Drawing.Point(298, 40);
            this.txtLeaFirTempMax.Max = 2000;
            ////
            //
            this.txtLeaFirTempMax.MaxStrLength = 0;
            this.txtLeaFirTempMax.Min = 0;
            ////
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbSampleFlag);
            this.groupBox2.Controls.Add(this.txtSoftBlowTimeMin);
            this.groupBox2.Controls.Add(this.txtSteelGradeIndexProc);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 69);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "炼钢记号:";
            // 
            // cmbSampleFlag
            // 
            this.cmbSampleFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSampleFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSampleFlag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSampleFlag.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsProc, "Sample_Flag", true));
            this.cmbSampleFlag.EnableNull = true;
            this.cmbSampleFlag.ErropPr = null;
            this.cmbSampleFlag.FormattingEnabled = true;
            this.cmbSampleFlag.Location = new System.Drawing.Point(364, 23);
            this.cmbSampleFlag.Name = "cmbSampleFlag";
            //
            this.cmbSampleFlag.Size = new System.Drawing.Size(121, 20);
            this.cmbSampleFlag.TabIndex = 1;
            //
            this.cmbSampleFlag.ToolTipValid = null;
            this.cmbSampleFlag.ValidEable = false;
            // 
            // txtSoftBlowTimeMin
            // 
            this.txtSoftBlowTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "Soft_Blow_Time_Min", true));
            //
            this.txtSoftBlowTimeMin.EnableNull = false;
            this.txtSoftBlowTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtSoftBlowTimeMin.Length = 0;
            this.txtSoftBlowTimeMin.Location = new System.Drawing.Point(586, 23);
            this.txtSoftBlowTimeMin.Max = 9999;
            ////
            //
            this.txtSoftBlowTimeMin.MaxStrLength = 0;
            this.txtSoftBlowTimeMin.Min = 0;
            ////
            //
            this.txtSoftBlowTimeMin.MinStrLength = 0;
            this.txtSoftBlowTimeMin.Name = "txtSoftBlowTimeMin";
            this.txtSoftBlowTimeMin.Precision = 0;
            //
            this.txtSoftBlowTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtSoftBlowTimeMin.TabIndex = 2;
            this.txtSoftBlowTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtSoftBlowTimeMin.ValidEable = true;
            this.txtSoftBlowTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtSteelGradeIndexProc
            // 
            this.txtSteelGradeIndexProc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProc, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexProc.EnableNull = false;
            this.txtSteelGradeIndexProc.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexProc.Length = 8;
            this.txtSteelGradeIndexProc.Location = new System.Drawing.Point(86, 23);
            this.txtSteelGradeIndexProc.Max = 0;
            this.txtSteelGradeIndexProc.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexProc.MaxStrLength = 0;
            this.txtSteelGradeIndexProc.Min = 0;
            ////
            //
            this.txtSteelGradeIndexProc.MinStrLength = 0;
            this.txtSteelGradeIndexProc.Name = "txtSteelGradeIndexProc";
            this.txtSteelGradeIndexProc.Precision = 0;
            this.txtSteelGradeIndexProc.ReadOnly = true;
            //
            this.txtSteelGradeIndexProc.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexProc.TabIndex = 0;
            this.txtSteelGradeIndexProc.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexProc.ValidEable = true;
            this.txtSteelGradeIndexProc.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "到站取样:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(497, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 12);
            this.label25.TabIndex = 2;
            this.label25.Text = "最小软吹时间:";
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
            this.rtxtNote.Location = new System.Drawing.Point(115, 100);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(866, 449);
            this.rtxtNote.TabIndex = 3;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // dtValidDate
            // 
            this.dtValidDate.CustomFormat = "yyyy-MM-dd";
            this.dtValidDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Valid_Date", true));
            this.dtValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtValidDate.Location = new System.Drawing.Point(115, 45);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(181, 21);
            this.dtValidDate.TabIndex = 1;
            // 
            // txtNewCode
            // 
            //
            this.txtNewCode.EnableNull = true;
            this.txtNewCode.ErropPr = null;
            //
            this.txtNewCode.Length = 0;
            this.txtNewCode.Location = new System.Drawing.Point(115, 72);
            this.txtNewCode.Max = 0;
            ////
            //
            this.txtNewCode.MaxStrLength = 0;
            this.txtNewCode.Min = 0;
           // //
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
            this.txtSteelGradeIndexBase.Location = new System.Drawing.Point(115, 17);
            this.txtSteelGradeIndexBase.Max = 0;
            this.txtSteelGradeIndexBase.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexBase.MaxStrLength = 0;
            this.txtSteelGradeIndexBase.Min = 0;
            ////
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
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "生效日期:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "说明:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "New_Code", true));
            this.label4.Location = new System.Drawing.Point(54, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "新试号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
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
            this.tabControlMain.Controls.Add(this.tabSlag);
            this.tabControlMain.Controls.Add(this.tabLadle);
            this.tabControlMain.Controls.Add(this.tabSlagEle);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 68);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1020, 612);
            this.tabControlMain.TabIndex = 2;
            // 
            // coldsSlagL3DataTableGUID
            // 
            this.coldsSlagL3DataTableGUID.Caption = "GUID";
            this.coldsSlagL3DataTableGUID.ColumnName = "GUID";
            this.coldsSlagL3DataTableGUID.Namespace = "";
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
            // LFStdMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LFStdMaintenFrm";
            this.TabText = "LF炉制造标准维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LFStdMaintenFrm_FormClosing);
            this.Load += new System.EventHandler(this.LFStdMaintenFrm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.bsSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlagEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlagEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSlagEle)).EndInit();
            this.tabSlagEle.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabLadle.ResumeLayout(false);
            this.hmiRootPanelLadle.ResumeLayout(false);
            this.hmiRootPanelLadle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorLadle)).EndInit();
            this.bNavigatorLadle.ResumeLayout(false);
            this.bNavigatorLadle.PerformLayout();
            this.tabSlag.ResumeLayout(false);
            this.hmiRootPanelSlag.ResumeLayout(false);
            this.hmiRootPanelSlag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorSlag)).EndInit();
            this.bNavigatorSlag.ResumeLayout(false);
            this.bNavigatorSlag.PerformLayout();
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
            this.tabProc.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
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
        private AppSvrHMI.L3DataSet dsSlag;
        private AppSvrHMI.L3DataSet dsLadle;
        private AppSvrHMI.L3DataSet dsSlagEle;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingSource bsProc;
        private System.Windows.Forms.BindingSource bsAlloy;
        private System.Windows.Forms.BindingSource bsFeed;
        private System.Windows.Forms.BindingSource bsSlag;
        private System.Windows.Forms.BindingSource bsLadle;
        private System.Windows.Forms.BindingSource bsSlagEle;
        private System.Windows.Forms.TabPage tabSlagEle;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label79;
        private PxDataValid.PxTextBox txtFeOMax;
        private PxDataValid.PxTextBox txtPMax;
        private PxDataValid.PxTextBox txtTiO2Max;
        private PxDataValid.PxTextBox txtSMax;
        private System.Windows.Forms.Label label83;
        private PxDataValid.PxTextBox txtMnOMax;
        private PxDataValid.PxTextBox txtFeOMin;
        private PxDataValid.PxTextBox txtAl2O3Max;
        private PxDataValid.PxTextBox txtPMin;
        private PxDataValid.PxTextBox txtTiO2Min;
        private System.Windows.Forms.Label label102;
        private PxDataValid.PxTextBox txtSMin;
        private PxDataValid.PxTextBox txtMnOMin;
        private PxDataValid.PxTextBox txtMgOMax;
        private PxDataValid.PxTextBox txtAl2O3Min;
        private PxDataValid.PxTextBox txtCaOMin;
        private PxDataValid.PxTextBox txtMgOMin;
        private PxDataValid.PxTextBox txtSiO2Max;
        private PxDataValid.PxTextBox txtSiO2Min;
        private PxDataValid.PxTextBox txtCaOMax;
        private System.Windows.Forms.GroupBox groupBox6;
        private PxDataValid.PxTextBox txtSteelGradeIndexSlagEle;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TabPage tabLadle;
        private HMIBase.HMIRootPanel hmiRootPanelLadle;
        private System.Windows.Forms.DataGridView dvLadle;
        private System.Windows.Forms.BindingNavigator bNavigatorLadle;
        private System.Windows.Forms.ToolStripButton btnAddLadle;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton btnDelLadle;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.TabPage tabSlag;
        private HMIBase.HMIRootPanel hmiRootPanelSlag;
        private System.Windows.Forms.DataGridView dvSlag;
        private System.Windows.Forms.BindingNavigator bNavigatorSlag;
        private System.Windows.Forms.ToolStripButton btnAddSlag;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnDelSlag;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
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
        private System.Windows.Forms.TabPage tabProc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private PxDataValid.PxTextBox txtHotArmax;
        private System.Windows.Forms.Label label15;
        private PxDataValid.PxTextBox txtHotTimeMax;
        private PxDataValid.PxTextBox txtRefineTimeMax;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxTextBox txtSoftArMax;
        private PxDataValid.PxTextBox txtRefineTimeMin;
        private PxDataValid.PxTextBox txtHoldSteelTimeMax;
        private PxDataValid.PxTextBox txtHoldSteelTimeMin;
        private PxDataValid.PxTextBox txtHotTimeMin;
        private PxDataValid.PxTextBox txtSoftArMin;
        private PxDataValid.PxTextBox txtHotArMin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private PxDataValid.PxTextBox txtLeaFirTempAim;
        private PxDataValid.PxTextBox txtLeaTempAim;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private PxDataValid.PxTextBox txtLeaTempMin;
        private PxDataValid.PxTextBox txtLeaTempMax;
        private PxDataValid.PxTextBox txtLeaFirTempMin;
        private PxDataValid.PxTextBox txtLeaFirTempMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxComboBox cmbSampleFlag;
        private PxDataValid.PxTextBox txtSoftBlowTimeMin;
        private PxDataValid.PxTextBox txtSteelGradeIndexProc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label25;
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
        private System.Data.DataColumn coldsProcL3DataTableSample_Flag;
        private System.Data.DataColumn coldsProcL3DataTableSoft_Blow_Time_Min;
        private System.Data.DataColumn coldsProcL3DataTableHot_Time_Min;
        private System.Data.DataColumn coldsProcL3DataTableHot_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableHot_Ar_Min;
        private System.Data.DataColumn coldsProcL3DataTableHot_Ar_Max;
        private System.Data.DataColumn coldsProcL3DataTableSoft_Ar_Min;
        private System.Data.DataColumn coldsProcL3DataTableSoft_Ar_Max;
        private System.Data.DataColumn coldsProcL3DataTableHold_Steel_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableStay_Steel_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableRefine_Time_Max;
        private System.Data.DataColumn coldsProcL3DataTableRefine_Time_Min;
        private System.Data.DataTable schemadsAlloy;
        private System.Data.DataColumn coldsAlloyL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsAlloyL3DataTableAlloy_Flag;
        private System.Data.DataColumn coldsAlloyL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsAlloyL3DataTableAlloy_Yield;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyYieldDataGridViewTextBoxColumn;
        private System.Data.DataTable schemadsFeed;
        private System.Data.DataColumn coldsFeedL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsFeedL3DataTableC_Absorption_Rate;
        private System.Data.DataColumn coldsFeedL3DataTableAl_Absorption_Rate;
        private System.Data.DataColumn coldsFeedL3DataTableCaProc_Code1;
        private System.Data.DataColumn coldsFeedL3DataTableCaProcFir_Code1_Weight_Max;
        private System.Data.DataColumn coldsFeedL3DataTableCaProcFir_Code1_Weight_Min;
        private System.Data.DataColumn coldsFeedL3DataTableCaProc_Code1_Weight_Max;
        private System.Data.DataColumn coldsFeedL3DataTableCaProc_Code1_Weight_Min;
        private System.Data.DataColumn coldsFeedL3DataTableOxy_Flag;
        private System.Data.DataTable schemadsSlag;
        private System.Data.DataColumn coldsSlagL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSlagL3DataTableSlag_Code;
        private System.Data.DataColumn coldsSlagL3DataTableSlag_Weight;
        private System.Data.DataTable schemadsLadle;
        private System.Data.DataColumn coldsLadleL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsLadleL3DataTableLadle_Mat_Name;
        private System.Data.DataColumn coldsLadleL3DataTableLadle_Mat_Min;
        private System.Data.DataColumn coldsLadleL3DataTableLadle_Mat_Max;
        private System.Data.DataColumn coldsLadleL3DataTableLadle_Mat_Aim;
        private System.Data.DataTable schemadsSlagEle;
        private System.Data.DataColumn coldsSlagEleL3DataTableGUID;
        private System.Data.DataColumn coldsSlagEleL3DataTableName;
        private System.Data.DataColumn coldsSlagEleL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSlagEleL3DataTableCaO_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableCaO_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableSiO2_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableSiO2_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableMgO_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableMgO_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableAl2O3_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableAl2O3_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableS_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableS_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableP_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableP_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableMnO_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableMnO_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableTiO2_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableTiO2_Min;
        private System.Data.DataColumn coldsSlagEleL3DataTableFeO_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableFeO_Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatAimDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsLadleL3DataTableGUID;
        private System.Data.DataColumn coldsSlagL3DataTableGUID;
        private System.Data.DataColumn coldsFeedL3DataTableGUID;
        private System.Data.DataColumn coldsAlloyL3DataTableGUID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
        private System.Data.DataColumn AcoldsSlagL3DataTableGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn slagCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slagWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID_Slag;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAbsorptionRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alAbsorptionRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcCode1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcFirCode1WeightMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcFirCode1WeightMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcCode1WeightMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caProcCode1WeightMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oxyFlagDataGridViewTextBoxColumn;
    }
}