namespace QualityMag.QualityStandard
{
    partial class BOFStdMaintenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BOFStdMaintenFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnDelBulk = new System.Windows.Forms.ToolStripButton();
            this.btnAddBulk = new System.Windows.Forms.ToolStripButton();
            this.btnDelFeed = new System.Windows.Forms.ToolStripButton();
            this.btnAddFeed = new System.Windows.Forms.ToolStripButton();
            this.btnDelLadle = new System.Windows.Forms.ToolStripButton();
            this.btnAddLadle = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.tscmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtSteelGrade = new System.Windows.Forms.ToolStripTextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTableValid_Date = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNew_Code = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNote = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtValidDate = new System.Windows.Forms.DateTimePicker();
            this.txtNewCode = new PxDataValid.PxTextBox();
            this.txtSteelGradeIndexBase = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAr = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBeArOxyMax = new PxDataValid.PxTextBox();
            this.bsAr = new System.Windows.Forms.BindingSource(this.components);
            this.dsAr = new AppSvrHMI.L3DataSet();
            this.schemadsAr = new System.Data.DataTable();
            this.coldsArL3DataTableGUID = new System.Data.DataColumn();
            this.coldsArL3DataTableName = new System.Data.DataColumn();
            this.coldsArL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Max = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Min = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Aim = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_SteelTemp_Max = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_SteelTemp_Min = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_SteelTemp_Aim = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Max = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Min = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Aim = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_SteelTemp_Max = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_SteelTemp_Min = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_SteelTemp_Aim = new System.Data.DataColumn();
            this.coldsArL3DataTableOxy_Flag = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_Oxy_Max = new System.Data.DataColumn();
            this.coldsArL3DataTablePreAr_Oxy_Min = new System.Data.DataColumn();
            this.coldsArL3DataTableAr_Time_UpLimit = new System.Data.DataColumn();
            this.coldsArL3DataTableAr_Time_LowLimit = new System.Data.DataColumn();
            this.coldsArL3DataTableAr_Press_Max = new System.Data.DataColumn();
            this.coldsArL3DataTableAr_Press_Min = new System.Data.DataColumn();
            this.coldsArL3DataTableAr_Blow_Max = new System.Data.DataColumn();
            this.coldsArL3DataTableAr_Blow_Min = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_Oxy_Max = new System.Data.DataColumn();
            this.coldsArL3DataTableBeAr_Oxy_Min = new System.Data.DataColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.txtArBlowMax = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBeArOxyMin = new PxDataValid.PxTextBox();
            this.txtArPressMax = new PxDataValid.PxTextBox();
            this.txtArBlowMin = new PxDataValid.PxTextBox();
            this.txtPreArOxyMin = new PxDataValid.PxTextBox();
            this.txtArPressMin = new PxDataValid.PxTextBox();
            this.txtArTimeUpLimit = new PxDataValid.PxTextBox();
            this.txtArTimeLowLimit = new PxDataValid.PxTextBox();
            this.txtPreArOxyMax = new PxDataValid.PxTextBox();
            this.gbxTemp = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBeArAim = new PxDataValid.PxTextBox();
            this.txtPreArAim = new PxDataValid.PxTextBox();
            this.txtBeArFirAim = new PxDataValid.PxTextBox();
            this.txtPreArFirAim = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBeArFirMin = new PxDataValid.PxTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBeArMax = new PxDataValid.PxTextBox();
            this.txtPreArFirMin = new PxDataValid.PxTextBox();
            this.txtBeArMin = new PxDataValid.PxTextBox();
            this.txtPreArMax = new PxDataValid.PxTextBox();
            this.txtBeArFirMax = new PxDataValid.PxTextBox();
            this.txtPreArMin = new PxDataValid.PxTextBox();
            this.txtPreArFirMax = new PxDataValid.PxTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOxyFlag = new PxDataValid.PxComboBox();
            this.txtSteelGradeIndexAr = new PxDataValid.PxTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabBlow = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSteelGradeIndexBlow = new PxDataValid.PxTextBox();
            this.bsBlow = new System.Windows.Forms.BindingSource(this.components);
            this.dsBlow = new AppSvrHMI.L3DataSet();
            this.schemadsBlow = new System.Data.DataTable();
            this.coldsBlowL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBlowL3DataTableName = new System.Data.DataColumn();
            this.coldsBlowL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBlowL3DataTableReBlow_Cnt_Max = new System.Data.DataColumn();
            this.coldsBlowL3DataTableCatch_C_Temp_Min = new System.Data.DataColumn();
            this.coldsBlowL3DataTableReBlow_Time_Max = new System.Data.DataColumn();
            this.coldsBlowL3DataTableBottom_Blow_Base = new System.Data.DataColumn();
            this.txtBottomBlowBase = new PxDataValid.PxTextBox();
            this.txtReBlowCntMax = new PxDataValid.PxTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReBlowTimeMax = new PxDataValid.PxTextBox();
            this.txtCatchCTempMin = new PxDataValid.PxTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabBlowO2 = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSteelGradeIndexBlowO2 = new PxDataValid.PxTextBox();
            this.bsBlowO2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBlowO2 = new AppSvrHMI.L3DataSet();
            this.schemadsBlowO2 = new System.Data.DataTable();
            this.coldsBlowO2L3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBlowO2L3DataTableGUID = new System.Data.DataColumn();
            this.coldsBlowO2L3DataTableName = new System.Data.DataColumn();
            this.coldsBlowO2L3DataTableTotal_O2_Press_Ctr = new System.Data.DataColumn();
            this.coldsBlowO2L3DataTableWork_O2_Press_Ctr = new System.Data.DataColumn();
            this.coldsBlowO2L3DataTableO2_Blow_Ctr = new System.Data.DataColumn();
            this.txtO2BlowCtr = new PxDataValid.PxTextBox();
            this.txtTotalO2PressCtr = new PxDataValid.PxTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtWorkO2PressCtr = new PxDataValid.PxTextBox();
            this.tabBulk = new System.Windows.Forms.TabPage();
            this.hmiRootPanelBulk = new HMIBase.HMIRootPanel();
            this.dvBulk = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkWeightMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulkWeightMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBulk = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulk = new AppSvrHMI.L3DataSet();
            this.schemadsBulk = new System.Data.DataTable();
            this.coldsBulkL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBulkL3DataTableName = new System.Data.DataColumn();
            this.coldsBulkL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBulkL3DataTableBulk_Code = new System.Data.DataColumn();
            this.coldsBulkL3DataTableBulk_Weight_Min = new System.Data.DataColumn();
            this.coldsBulkL3DataTableBulk_Weight_Max = new System.Data.DataColumn();
            this.bNavigatorBulk = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabFeed = new System.Windows.Forms.TabPage();
            this.hmiRootPanelFeed = new HMIBase.HMIRootPanel();
            this.dvFeed = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedWeightMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedWeightMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFeed = new System.Windows.Forms.BindingSource(this.components);
            this.dsFeed = new AppSvrHMI.L3DataSet();
            this.schemadsFeed = new System.Data.DataTable();
            this.coldsFeedL3DataTableGUID = new System.Data.DataColumn();
            this.coldsFeedL3DataTableName = new System.Data.DataColumn();
            this.coldsFeedL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsFeedL3DataTableFeed_Code = new System.Data.DataColumn();
            this.coldsFeedL3DataTableFeed_Weight_Min = new System.Data.DataColumn();
            this.coldsFeedL3DataTableFeed_Weight_Max = new System.Data.DataColumn();
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
            this.tabInToConver = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.txtScrapWeightMax = new PxDataValid.PxTextBox();
            this.bsInToConver = new System.Windows.Forms.BindingSource(this.components);
            this.dsInToConver = new AppSvrHMI.L3DataSet();
            this.schemadsInToConver = new System.Data.DataTable();
            this.coldsInToConverL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableName = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Temp_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Temp_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Weight_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Weight_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_S_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_S_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_P_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_P_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Si_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Si_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Ti_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableIron_Ti_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableScrap_Type = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableScrap_Weight_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableScrap_Weight_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTablePigIron_Weight_Max = new System.Data.DataColumn();
            this.coldsInToConverL3DataTablePigIron_Weight_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableTotal_Weight_Min = new System.Data.DataColumn();
            this.coldsInToConverL3DataTableTotal_Weight_Max = new System.Data.DataColumn();
            this.txtPigIronWeightMax = new PxDataValid.PxTextBox();
            this.txtScrapWeightMin = new PxDataValid.PxTextBox();
            this.txtPigIronWeightMin = new PxDataValid.PxTextBox();
            this.txtTotalWeightMax = new PxDataValid.PxTextBox();
            this.txtTotalWeightMin = new PxDataValid.PxTextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.txtIronTiMax = new PxDataValid.PxTextBox();
            this.txtIronSiMax = new PxDataValid.PxTextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.txtIronPMax = new PxDataValid.PxTextBox();
            this.txtIronTiMin = new PxDataValid.PxTextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.txtIronSiMin = new PxDataValid.PxTextBox();
            this.txtIronSMax = new PxDataValid.PxTextBox();
            this.txtIronPMin = new PxDataValid.PxTextBox();
            this.txtIronTempMin = new PxDataValid.PxTextBox();
            this.txtIronSMin = new PxDataValid.PxTextBox();
            this.txtIronWeightMax = new PxDataValid.PxTextBox();
            this.txtIronWeightMin = new PxDataValid.PxTextBox();
            this.txtIronTempMax = new PxDataValid.PxTextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cmbScrapType = new PxDataValid.PxComboBox();
            this.label73 = new System.Windows.Forms.Label();
            this.txtSteelGradeIndexInToConver = new PxDataValid.PxTextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.tabLadle = new System.Windows.Forms.TabPage();
            this.hmiRootPanelLadle = new HMIBase.HMIRootPanel();
            this.dvLadle = new System.Windows.Forms.DataGridView();
            this.steelGradeIndexDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatMaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleMatAimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLadle = new System.Windows.Forms.BindingSource(this.components);
            this.dsLadle = new AppSvrHMI.L3DataSet();
            this.schemadsLadle = new System.Data.DataTable();
            this.coldsLadleL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLadleL3DataTableName = new System.Data.DataColumn();
            this.coldsLadleL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Name = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Min = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Max = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadle_Mat_Aim = new System.Data.DataColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabSlagEle = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.txtTFeMax = new PxDataValid.PxTextBox();
            this.bsSlagEle = new System.Windows.Forms.BindingSource(this.components);
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
            this.coldsSlagEleL3DataTableTFe_Max = new System.Data.DataColumn();
            this.coldsSlagEleL3DataTableTFe_Min = new System.Data.DataColumn();
            this.label102 = new System.Windows.Forms.Label();
            this.txtMgOMax = new PxDataValid.PxTextBox();
            this.txtTFeMin = new PxDataValid.PxTextBox();
            this.txtCaOMin = new PxDataValid.PxTextBox();
            this.txtMgOMin = new PxDataValid.PxTextBox();
            this.txtSiO2Max = new PxDataValid.PxTextBox();
            this.txtSiO2Min = new PxDataValid.PxTextBox();
            this.txtCaOMax = new PxDataValid.PxTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtSteelGradeIndexSlagEle = new PxDataValid.PxTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tabTap = new System.Windows.Forms.TabPage();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.txtTapArBlowMin = new PxDataValid.PxTextBox();
            this.bsTap = new System.Windows.Forms.BindingSource(this.components);
            this.dsTap = new AppSvrHMI.L3DataSet();
            this.schemadsTap = new System.Data.DataTable();
            this.coldsTapL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTapL3DataTableName = new System.Data.DataColumn();
            this.coldsTapL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsTapL3DataTableTapping_Temp_Min = new System.Data.DataColumn();
            this.coldsTapL3DataTableTapping_Time_Min = new System.Data.DataColumn();
            this.coldsTapL3DataTableEnd_O2_UpLimit = new System.Data.DataColumn();
            this.coldsTapL3DataTableEnd_C_UpLimit = new System.Data.DataColumn();
            this.coldsTapL3DataTableEnd_C_LowLimit = new System.Data.DataColumn();
            this.coldsTapL3DataTableEnd_S_UpLimit = new System.Data.DataColumn();
            this.coldsTapL3DataTableEnd_P_UpLimit = new System.Data.DataColumn();
            this.coldsTapL3DataTableEnd_Mn_UpLimit = new System.Data.DataColumn();
            this.coldsTapL3DataTableAr_Press_Max = new System.Data.DataColumn();
            this.coldsTapL3DataTableAr_Press_Min = new System.Data.DataColumn();
            this.coldsTapL3DataTableAr_Blow_Max = new System.Data.DataColumn();
            this.coldsTapL3DataTableAr_Blow_Min = new System.Data.DataColumn();
            this.txtTapArPressMin = new PxDataValid.PxTextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.txtEndPUpLimit = new PxDataValid.PxTextBox();
            this.txtTapArBlowMax = new PxDataValid.PxTextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.txtTapArPressMax = new PxDataValid.PxTextBox();
            this.txtEndCUpLimit = new PxDataValid.PxTextBox();
            this.txtEndMnUpLimit = new PxDataValid.PxTextBox();
            this.txtTappingTimeMin = new PxDataValid.PxTextBox();
            this.txtEndCLowLimit = new PxDataValid.PxTextBox();
            this.txtEndO2UpLimit = new PxDataValid.PxTextBox();
            this.txtEndSUpLimit = new PxDataValid.PxTextBox();
            this.txtTappingTempMin = new PxDataValid.PxTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtSteelGradeIndexTap = new PxDataValid.PxTextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.l3Command1 = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabAr.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAr)).BeginInit();
            this.gbxTemp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabBlow.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlow)).BeginInit();
            this.tabBlowO2.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlowO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlowO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlowO2)).BeginInit();
            this.tabBulk.SuspendLayout();
            this.hmiRootPanelBulk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBulk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorBulk)).BeginInit();
            this.bNavigatorBulk.SuspendLayout();
            this.tabFeed.SuspendLayout();
            this.hmiRootPanelFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorFeed)).BeginInit();
            this.bNavigatorFeed.SuspendLayout();
            this.tabInToConver.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInToConver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInToConver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInToConver)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tabLadle.SuspendLayout();
            this.hmiRootPanelLadle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabSlagEle.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSlagEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlagEle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlagEle)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabTap.SuspendLayout();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTap)).BeginInit();
            this.groupBox9.SuspendLayout();
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
            // btnDelBulk
            // 
            this.Adapter.SetAccessRight(this.btnDelBulk, "btnBOFStd");
            this.btnDelBulk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelBulk.Enabled = false;
            this.btnDelBulk.Image = ((System.Drawing.Image)(resources.GetObject("btnDelBulk.Image")));
            this.btnDelBulk.Name = "btnDelBulk";
            this.btnDelBulk.RightToLeftAutoMirrorImage = true;
            this.btnDelBulk.Size = new System.Drawing.Size(23, 22);
            this.btnDelBulk.Text = "删除";
            this.btnDelBulk.Click += new System.EventHandler(this.btnDelBulk_Click);
            // 
            // btnAddBulk
            // 
            this.Adapter.SetAccessRight(this.btnAddBulk, "btnBOFStd");
            this.btnAddBulk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddBulk.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBulk.Image")));
            this.btnAddBulk.Name = "btnAddBulk";
            this.btnAddBulk.RightToLeftAutoMirrorImage = true;
            this.btnAddBulk.Size = new System.Drawing.Size(23, 22);
            this.btnAddBulk.Text = "新添";
            this.btnAddBulk.Click += new System.EventHandler(this.btnAddBulk_Click);
            // 
            // btnDelFeed
            // 
            this.Adapter.SetAccessRight(this.btnDelFeed, "btnBOFStd");
            this.btnDelFeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelFeed.Enabled = false;
            this.btnDelFeed.Image = ((System.Drawing.Image)(resources.GetObject("btnDelFeed.Image")));
            this.btnDelFeed.Name = "btnDelFeed";
            this.btnDelFeed.RightToLeftAutoMirrorImage = true;
            this.btnDelFeed.Size = new System.Drawing.Size(23, 22);
            this.btnDelFeed.Text = "删除";
            this.btnDelFeed.Click += new System.EventHandler(this.btnDelFeed_Click);
            // 
            // btnAddFeed
            // 
            this.Adapter.SetAccessRight(this.btnAddFeed, "btnBOFStd");
            this.btnAddFeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFeed.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFeed.Image")));
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.RightToLeftAutoMirrorImage = true;
            this.btnAddFeed.Size = new System.Drawing.Size(23, 22);
            this.btnAddFeed.Text = "新添";
            this.btnAddFeed.Click += new System.EventHandler(this.btnAddFeed_Click);
            // 
            // btnDelLadle
            // 
            this.Adapter.SetAccessRight(this.btnDelLadle, "btnBOFStd");
            this.btnDelLadle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelLadle.Enabled = false;
            this.btnDelLadle.Image = ((System.Drawing.Image)(resources.GetObject("btnDelLadle.Image")));
            this.btnDelLadle.Name = "btnDelLadle";
            this.btnDelLadle.RightToLeftAutoMirrorImage = true;
            this.btnDelLadle.Size = new System.Drawing.Size(23, 22);
            this.btnDelLadle.Text = "删除";
            this.btnDelLadle.Click += new System.EventHandler(this.btnDelLadle_Click);
            // 
            // btnAddLadle
            // 
            this.Adapter.SetAccessRight(this.btnAddLadle, "btnBOFStd");
            this.btnAddLadle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddLadle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLadle.Image")));
            this.btnAddLadle.Name = "btnAddLadle";
            this.btnAddLadle.RightToLeftAutoMirrorImage = true;
            this.btnAddLadle.Size = new System.Drawing.Size(23, 22);
            this.btnAddLadle.Text = "新添";
            this.btnAddLadle.Click += new System.EventHandler(this.btnAddLadle_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
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
            this.toolStripLabel5,
            this.toolStripLabel2,
            this.btnQuery,
            this.tscmbSteelGradeIndex,
            this.toolStripLabel1,
            this.toolStripLabel4,
            this.txtSteelGrade});
            this.toolStrip2.Location = new System.Drawing.Point(0, 43);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1020, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel5.Text = "        ";
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
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabBase);
            this.tabControlMain.Controls.Add(this.tabAr);
            this.tabControlMain.Controls.Add(this.tabBlow);
            this.tabControlMain.Controls.Add(this.tabBlowO2);
            this.tabControlMain.Controls.Add(this.tabBulk);
            this.tabControlMain.Controls.Add(this.tabFeed);
            this.tabControlMain.Controls.Add(this.tabInToConver);
            this.tabControlMain.Controls.Add(this.tabLadle);
            this.tabControlMain.Controls.Add(this.tabSlagEle);
            this.tabControlMain.Controls.Add(this.tabTap);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 68);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1020, 612);
            this.tabControlMain.TabIndex = 2;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
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
            this.rtxtNote.Location = new System.Drawing.Point(113, 100);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(866, 449);
            this.rtxtNote.TabIndex = 3;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
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
            this.dsBase.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Base";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = this.btnConfirm;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtValidDate
            // 
            this.dtValidDate.CustomFormat = "yyyy-MM-dd";
            this.dtValidDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Valid_Date", true));
            this.dtValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtValidDate.Location = new System.Drawing.Point(113, 45);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(181, 21);
            this.dtValidDate.TabIndex = 2;
            // 
            // txtNewCode
            // 
            this.txtNewCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "New_Code", true));
            //
            this.txtNewCode.EnableNull = true;
            this.txtNewCode.ErropPr = null;
            //
            this.txtNewCode.Length = 0;
            this.txtNewCode.Location = new System.Drawing.Point(113, 72);
            this.txtNewCode.Max = 0;
            ////
            //
            this.txtNewCode.MaxStrLength = 0;
            this.txtNewCode.Min = 0;
            ////
            //
            this.txtNewCode.MinStrLength = 0;
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.Precision = 0;
            //
            this.txtNewCode.Size = new System.Drawing.Size(181, 21);
            this.txtNewCode.TabIndex = 1;
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
            this.txtSteelGradeIndexBase.Location = new System.Drawing.Point(113, 17);
            this.txtSteelGradeIndexBase.Max = 0;
            this.txtSteelGradeIndexBase.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexBase.MaxStrLength = 0;
            this.txtSteelGradeIndexBase.Min = 0;
           // //
            //
            this.txtSteelGradeIndexBase.MinStrLength = 0;
            this.txtSteelGradeIndexBase.Name = "txtSteelGradeIndexBase";
            this.txtSteelGradeIndexBase.Precision = 0;
            this.txtSteelGradeIndexBase.ReadOnly = true;
            //
            this.txtSteelGradeIndexBase.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexBase.TabIndex = 1;
            this.txtSteelGradeIndexBase.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexBase.ValidEable = true;
            this.txtSteelGradeIndexBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "生效日期:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "说明:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "新试号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炼钢记号:";
            // 
            // tabAr
            // 
            this.tabAr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAr.Controls.Add(this.groupBox3);
            this.tabAr.Controls.Add(this.gbxTemp);
            this.tabAr.Controls.Add(this.groupBox2);
            this.tabAr.Location = new System.Drawing.Point(4, 21);
            this.tabAr.Name = "tabAr";
            this.tabAr.Size = new System.Drawing.Size(1012, 587);
            this.tabAr.TabIndex = 10;
            this.tabAr.Text = "炉后吹氩信息";
            this.tabAr.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtBeArOxyMax);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtArBlowMax);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtBeArOxyMin);
            this.groupBox3.Controls.Add(this.txtArPressMax);
            this.groupBox3.Controls.Add(this.txtArBlowMin);
            this.groupBox3.Controls.Add(this.txtPreArOxyMin);
            this.groupBox3.Controls.Add(this.txtArPressMin);
            this.groupBox3.Controls.Add(this.txtArTimeUpLimit);
            this.groupBox3.Controls.Add(this.txtArTimeLowLimit);
            this.groupBox3.Controls.Add(this.txtPreArOxyMax);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "最小:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 2;
            this.label17.Text = "最大:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(73, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 12);
            this.label18.TabIndex = 2;
            this.label18.Text = "氩前定氧氧含量";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(559, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 12);
            this.label24.TabIndex = 2;
            this.label24.Text = "氩后定氧氧含量";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(445, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "炉后吹氩流量";
            // 
            // txtBeArOxyMax
            // 
            this.txtBeArOxyMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_Oxy_Max", true));
            //
            this.txtBeArOxyMax.EnableNull = false;
            this.txtBeArOxyMax.ErropPr = this.errorProvider1;
            //
            this.txtBeArOxyMax.Length = 0;
            this.txtBeArOxyMax.Location = new System.Drawing.Point(553, 40);
            this.txtBeArOxyMax.Max = 999;
            ////
            //
            this.txtBeArOxyMax.MaxStrLength = 0;
            this.txtBeArOxyMax.Min = 0;
            ////
            //
            this.txtBeArOxyMax.MinStrLength = 0;
            this.txtBeArOxyMax.Name = "txtBeArOxyMax";
            this.txtBeArOxyMax.Precision = 0;
            //
            this.txtBeArOxyMax.Size = new System.Drawing.Size(100, 21);
            this.txtBeArOxyMax.TabIndex = 8;
            this.txtBeArOxyMax.ToolTipValid = this.toolTip1;
          //
            this.txtBeArOxyMax.ValidEable = true;
            this.txtBeArOxyMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // bsAr
            // 
            this.bsAr.DataMember = "L3DataTable";
            this.bsAr.DataSource = this.dsAr;
            // 
            // dsAr
            // 
            this.dsAr.AutoLoad = true;
            this.dsAr.AutoSubscribe = false;
            this.dsAr.DataSetName = "L3DataSet";
            this.dsAr.DeleteMethod = null;
            this.dsAr.InsertMethod = null;
            this.dsAr.L3DataAdapter = this.Adapter;
            this.dsAr.LoadEvent = "Click";
            this.dsAr.LoadTrigger = null;
            this.dsAr.RefreshValve = 1000;
            this.dsAr.SourceCommand = null;
            this.dsAr.SourceCondition = "1=2";
            this.dsAr.SourceMethod = "";
            this.dsAr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAr.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Ar";
            this.dsAr.SubscribeTarget = null;
            this.dsAr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAr});
            this.dsAr.UpdateEvent = "Click";
            this.dsAr.UpdateMethod = null;
            this.dsAr.UpdateTrigger = null;
            // 
            // schemadsAr
            // 
            this.schemadsAr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsArL3DataTableGUID,
            this.coldsArL3DataTableName,
            this.coldsArL3DataTableSteelGradeIndex,
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Max,
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Min,
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Aim,
            this.coldsArL3DataTablePreAr_SteelTemp_Max,
            this.coldsArL3DataTablePreAr_SteelTemp_Min,
            this.coldsArL3DataTablePreAr_SteelTemp_Aim,
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Max,
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Min,
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Aim,
            this.coldsArL3DataTableBeAr_SteelTemp_Max,
            this.coldsArL3DataTableBeAr_SteelTemp_Min,
            this.coldsArL3DataTableBeAr_SteelTemp_Aim,
            this.coldsArL3DataTableOxy_Flag,
            this.coldsArL3DataTablePreAr_Oxy_Max,
            this.coldsArL3DataTablePreAr_Oxy_Min,
            this.coldsArL3DataTableAr_Time_UpLimit,
            this.coldsArL3DataTableAr_Time_LowLimit,
            this.coldsArL3DataTableAr_Press_Max,
            this.coldsArL3DataTableAr_Press_Min,
            this.coldsArL3DataTableAr_Blow_Max,
            this.coldsArL3DataTableAr_Blow_Min,
            this.coldsArL3DataTableBeAr_Oxy_Max,
            this.coldsArL3DataTableBeAr_Oxy_Min});
            this.schemadsAr.TableName = "L3DataTable";
            // 
            // coldsArL3DataTableGUID
            // 
            this.coldsArL3DataTableGUID.Caption = "GUID";
            this.coldsArL3DataTableGUID.ColumnName = "GUID";
            this.coldsArL3DataTableGUID.Namespace = "";
            // 
            // coldsArL3DataTableName
            // 
            this.coldsArL3DataTableName.Caption = "Name";
            this.coldsArL3DataTableName.ColumnName = "Name";
            this.coldsArL3DataTableName.Namespace = "";
            // 
            // coldsArL3DataTableSteelGradeIndex
            // 
            this.coldsArL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsArL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsArL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_SteelTemp_Fir_Max
            // 
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Max.Caption = "PreAr_SteelTemp_Fir_Max";
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Max.ColumnName = "PreAr_SteelTemp_Fir_Max";
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Max.DataType = typeof(int);
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Max.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_SteelTemp_Fir_Min
            // 
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Min.Caption = "PreAr_SteelTemp_Fir_Min";
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Min.ColumnName = "PreAr_SteelTemp_Fir_Min";
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Min.DataType = typeof(int);
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Min.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_SteelTemp_Fir_Aim
            // 
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Aim.Caption = "PreAr_SteelTemp_Fir_Aim";
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Aim.ColumnName = "PreAr_SteelTemp_Fir_Aim";
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Aim.DataType = typeof(int);
            this.coldsArL3DataTablePreAr_SteelTemp_Fir_Aim.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_SteelTemp_Max
            // 
            this.coldsArL3DataTablePreAr_SteelTemp_Max.Caption = "PreAr_SteelTemp_Max";
            this.coldsArL3DataTablePreAr_SteelTemp_Max.ColumnName = "PreAr_SteelTemp_Max";
            this.coldsArL3DataTablePreAr_SteelTemp_Max.DataType = typeof(int);
            this.coldsArL3DataTablePreAr_SteelTemp_Max.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_SteelTemp_Min
            // 
            this.coldsArL3DataTablePreAr_SteelTemp_Min.Caption = "PreAr_SteelTemp_Min";
            this.coldsArL3DataTablePreAr_SteelTemp_Min.ColumnName = "PreAr_SteelTemp_Min";
            this.coldsArL3DataTablePreAr_SteelTemp_Min.DataType = typeof(int);
            this.coldsArL3DataTablePreAr_SteelTemp_Min.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_SteelTemp_Aim
            // 
            this.coldsArL3DataTablePreAr_SteelTemp_Aim.Caption = "PreAr_SteelTemp_Aim";
            this.coldsArL3DataTablePreAr_SteelTemp_Aim.ColumnName = "PreAr_SteelTemp_Aim";
            this.coldsArL3DataTablePreAr_SteelTemp_Aim.DataType = typeof(int);
            this.coldsArL3DataTablePreAr_SteelTemp_Aim.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_SteelTemp_Fir_Max
            // 
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Max.Caption = "BeAr_SteelTemp_Fir_Max";
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Max.ColumnName = "BeAr_SteelTemp_Fir_Max";
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Max.DataType = typeof(int);
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Max.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_SteelTemp_Fir_Min
            // 
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Min.Caption = "BeAr_SteelTemp_Fir_Min";
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Min.ColumnName = "BeAr_SteelTemp_Fir_Min";
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Min.DataType = typeof(int);
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Min.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_SteelTemp_Fir_Aim
            // 
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Aim.Caption = "BeAr_SteelTemp_Fir_Aim";
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Aim.ColumnName = "BeAr_SteelTemp_Fir_Aim";
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Aim.DataType = typeof(int);
            this.coldsArL3DataTableBeAr_SteelTemp_Fir_Aim.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_SteelTemp_Max
            // 
            this.coldsArL3DataTableBeAr_SteelTemp_Max.Caption = "BeAr_SteelTemp_Max";
            this.coldsArL3DataTableBeAr_SteelTemp_Max.ColumnName = "BeAr_SteelTemp_Max";
            this.coldsArL3DataTableBeAr_SteelTemp_Max.DataType = typeof(int);
            this.coldsArL3DataTableBeAr_SteelTemp_Max.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_SteelTemp_Min
            // 
            this.coldsArL3DataTableBeAr_SteelTemp_Min.Caption = "BeAr_SteelTemp_Min";
            this.coldsArL3DataTableBeAr_SteelTemp_Min.ColumnName = "BeAr_SteelTemp_Min";
            this.coldsArL3DataTableBeAr_SteelTemp_Min.DataType = typeof(int);
            this.coldsArL3DataTableBeAr_SteelTemp_Min.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_SteelTemp_Aim
            // 
            this.coldsArL3DataTableBeAr_SteelTemp_Aim.Caption = "BeAr_SteelTemp_Aim";
            this.coldsArL3DataTableBeAr_SteelTemp_Aim.ColumnName = "BeAr_SteelTemp_Aim";
            this.coldsArL3DataTableBeAr_SteelTemp_Aim.DataType = typeof(int);
            this.coldsArL3DataTableBeAr_SteelTemp_Aim.Namespace = "";
            // 
            // coldsArL3DataTableOxy_Flag
            // 
            this.coldsArL3DataTableOxy_Flag.Caption = "Oxy_Flag";
            this.coldsArL3DataTableOxy_Flag.ColumnName = "Oxy_Flag";
            this.coldsArL3DataTableOxy_Flag.DataType = typeof(int);
            this.coldsArL3DataTableOxy_Flag.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_Oxy_Max
            // 
            this.coldsArL3DataTablePreAr_Oxy_Max.Caption = "PreAr_Oxy_Max";
            this.coldsArL3DataTablePreAr_Oxy_Max.ColumnName = "PreAr_Oxy_Max";
            this.coldsArL3DataTablePreAr_Oxy_Max.Namespace = "";
            // 
            // coldsArL3DataTablePreAr_Oxy_Min
            // 
            this.coldsArL3DataTablePreAr_Oxy_Min.Caption = "PreAr_Oxy_Min";
            this.coldsArL3DataTablePreAr_Oxy_Min.ColumnName = "PreAr_Oxy_Min";
            this.coldsArL3DataTablePreAr_Oxy_Min.Namespace = "";
            // 
            // coldsArL3DataTableAr_Time_UpLimit
            // 
            this.coldsArL3DataTableAr_Time_UpLimit.Caption = "Ar_Time_UpLimit";
            this.coldsArL3DataTableAr_Time_UpLimit.ColumnName = "Ar_Time_UpLimit";
            this.coldsArL3DataTableAr_Time_UpLimit.DataType = typeof(int);
            this.coldsArL3DataTableAr_Time_UpLimit.Namespace = "";
            // 
            // coldsArL3DataTableAr_Time_LowLimit
            // 
            this.coldsArL3DataTableAr_Time_LowLimit.Caption = "Ar_Time_LowLimit";
            this.coldsArL3DataTableAr_Time_LowLimit.ColumnName = "Ar_Time_LowLimit";
            this.coldsArL3DataTableAr_Time_LowLimit.DataType = typeof(int);
            this.coldsArL3DataTableAr_Time_LowLimit.Namespace = "";
            // 
            // coldsArL3DataTableAr_Press_Max
            // 
            this.coldsArL3DataTableAr_Press_Max.Caption = "Ar_Press_Max";
            this.coldsArL3DataTableAr_Press_Max.ColumnName = "Ar_Press_Max";
            this.coldsArL3DataTableAr_Press_Max.DataType = typeof(int);
            this.coldsArL3DataTableAr_Press_Max.Namespace = "";
            // 
            // coldsArL3DataTableAr_Press_Min
            // 
            this.coldsArL3DataTableAr_Press_Min.Caption = "Ar_Press_Min";
            this.coldsArL3DataTableAr_Press_Min.ColumnName = "Ar_Press_Min";
            this.coldsArL3DataTableAr_Press_Min.DataType = typeof(int);
            this.coldsArL3DataTableAr_Press_Min.Namespace = "";
            // 
            // coldsArL3DataTableAr_Blow_Max
            // 
            this.coldsArL3DataTableAr_Blow_Max.Caption = "Ar_Blow_Max";
            this.coldsArL3DataTableAr_Blow_Max.ColumnName = "Ar_Blow_Max";
            this.coldsArL3DataTableAr_Blow_Max.Namespace = "";
            // 
            // coldsArL3DataTableAr_Blow_Min
            // 
            this.coldsArL3DataTableAr_Blow_Min.Caption = "Ar_Blow_Min";
            this.coldsArL3DataTableAr_Blow_Min.ColumnName = "Ar_Blow_Min";
            this.coldsArL3DataTableAr_Blow_Min.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_Oxy_Max
            // 
            this.coldsArL3DataTableBeAr_Oxy_Max.Caption = "BeAr_Oxy_Max";
            this.coldsArL3DataTableBeAr_Oxy_Max.ColumnName = "BeAr_Oxy_Max";
            this.coldsArL3DataTableBeAr_Oxy_Max.Namespace = "";
            // 
            // coldsArL3DataTableBeAr_Oxy_Min
            // 
            this.coldsArL3DataTableBeAr_Oxy_Min.Caption = "BeAr_Oxy_Min";
            this.coldsArL3DataTableBeAr_Oxy_Min.ColumnName = "BeAr_Oxy_Min";
            this.coldsArL3DataTableBeAr_Oxy_Min.Namespace = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(323, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "炉后吹氩压力";
            // 
            // txtArBlowMax
            // 
            this.txtArBlowMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "Ar_Blow_Max", true));
            //
            this.txtArBlowMax.EnableNull = false;
            this.txtArBlowMax.ErropPr = this.errorProvider1;
            //
            this.txtArBlowMax.Length = 0;
            this.txtArBlowMax.Location = new System.Drawing.Point(433, 40);
            this.txtArBlowMax.Max = 99999;
            ////
            //
            this.txtArBlowMax.MaxStrLength = 0;
            this.txtArBlowMax.Min = 0;
            ////
            //
            this.txtArBlowMax.MinStrLength = 0;
            this.txtArBlowMax.Name = "txtArBlowMax";
            this.txtArBlowMax.Precision = 0;
            //
            this.txtArBlowMax.Size = new System.Drawing.Size(100, 21);
            this.txtArBlowMax.TabIndex = 6;
            this.txtArBlowMax.ToolTipValid = this.toolTip1;
          //
            this.txtArBlowMax.ValidEable = true;
            this.txtArBlowMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(201, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "炉后吹氩时间";
            // 
            // txtBeArOxyMin
            // 
            this.txtBeArOxyMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_Oxy_Min", true));
            //
            this.txtBeArOxyMin.EnableNull = false;
            this.txtBeArOxyMin.ErropPr = this.errorProvider1;
            //
            this.txtBeArOxyMin.Length = 0;
            this.txtBeArOxyMin.Location = new System.Drawing.Point(553, 72);
            this.txtBeArOxyMin.Max = 999;
            ////
            //
            this.txtBeArOxyMin.MaxStrLength = 0;
            this.txtBeArOxyMin.Min = 0;
            ////
            //
            this.txtBeArOxyMin.MinStrLength = 0;
            this.txtBeArOxyMin.Name = "txtBeArOxyMin";
            this.txtBeArOxyMin.Precision = 0;
            //
            this.txtBeArOxyMin.Size = new System.Drawing.Size(100, 21);
            this.txtBeArOxyMin.TabIndex = 9;
            this.txtBeArOxyMin.ToolTipValid = this.toolTip1;
          //
            this.txtBeArOxyMin.ValidEable = true;
            this.txtBeArOxyMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtArPressMax
            // 
            this.txtArPressMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "Ar_Press_Max", true));
            //
            this.txtArPressMax.EnableNull = false;
            this.txtArPressMax.ErropPr = this.errorProvider1;
            //
            this.txtArPressMax.Length = 0;
            this.txtArPressMax.Location = new System.Drawing.Point(311, 40);
            this.txtArPressMax.Max = 9999;
            ////
            //
            this.txtArPressMax.MaxStrLength = 0;
            this.txtArPressMax.Min = 0;
            ////
            //
            this.txtArPressMax.MinStrLength = 0;
            this.txtArPressMax.Name = "txtArPressMax";
            this.txtArPressMax.Precision = 0;
            //
            this.txtArPressMax.Size = new System.Drawing.Size(100, 21);
            this.txtArPressMax.TabIndex = 4;
            this.txtArPressMax.ToolTipValid = this.toolTip1;
          //
            this.txtArPressMax.ValidEable = true;
            this.txtArPressMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtArBlowMin
            // 
            this.txtArBlowMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "Ar_Blow_Min", true));
            //
            this.txtArBlowMin.EnableNull = false;
            this.txtArBlowMin.ErropPr = this.errorProvider1;
            //
            this.txtArBlowMin.Length = 0;
            this.txtArBlowMin.Location = new System.Drawing.Point(433, 72);
            this.txtArBlowMin.Max = 99999;
            ////
            //
            this.txtArBlowMin.MaxStrLength = 0;
            this.txtArBlowMin.Min = 0;
            ////
            //
            this.txtArBlowMin.MinStrLength = 0;
            this.txtArBlowMin.Name = "txtArBlowMin";
            this.txtArBlowMin.Precision = 0;
            //
            this.txtArBlowMin.Size = new System.Drawing.Size(100, 21);
            this.txtArBlowMin.TabIndex = 7;
            this.txtArBlowMin.ToolTipValid = this.toolTip1;
          //
            this.txtArBlowMin.ValidEable = true;
            this.txtArBlowMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPreArOxyMin
            // 
            this.txtPreArOxyMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_Oxy_Min", true));
            //
            this.txtPreArOxyMin.EnableNull = false;
            this.txtPreArOxyMin.ErropPr = this.errorProvider1;
            //
            this.txtPreArOxyMin.Length = 0;
            this.txtPreArOxyMin.Location = new System.Drawing.Point(67, 72);
            this.txtPreArOxyMin.Max = 999;
            ////
            //
            this.txtPreArOxyMin.MaxStrLength = 0;
            this.txtPreArOxyMin.Min = 0;
            ////
            //
            this.txtPreArOxyMin.MinStrLength = 0;
            this.txtPreArOxyMin.Name = "txtPreArOxyMin";
            this.txtPreArOxyMin.Precision = 0;
            //
            this.txtPreArOxyMin.Size = new System.Drawing.Size(100, 21);
            this.txtPreArOxyMin.TabIndex = 1;
            this.txtPreArOxyMin.ToolTipValid = this.toolTip1;
          //
            this.txtPreArOxyMin.ValidEable = true;
            this.txtPreArOxyMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtArPressMin
            // 
            this.txtArPressMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "Ar_Press_Min", true));
            //
            this.txtArPressMin.EnableNull = false;
            this.txtArPressMin.ErropPr = this.errorProvider1;
            //
            this.txtArPressMin.Length = 0;
            this.txtArPressMin.Location = new System.Drawing.Point(311, 72);
            this.txtArPressMin.Max = 9999;
            ////
            //
            this.txtArPressMin.MaxStrLength = 0;
            this.txtArPressMin.Min = 0;
            ////
            //
            this.txtArPressMin.MinStrLength = 0;
            this.txtArPressMin.Name = "txtArPressMin";
            this.txtArPressMin.Precision = 0;
            //
            this.txtArPressMin.Size = new System.Drawing.Size(100, 21);
            this.txtArPressMin.TabIndex = 5;
            this.txtArPressMin.ToolTipValid = this.toolTip1;
          //
            this.txtArPressMin.ValidEable = true;
            this.txtArPressMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtArTimeUpLimit
            // 
            this.txtArTimeUpLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "Ar_Time_UpLimit", true));
            //
            this.txtArTimeUpLimit.EnableNull = false;
            this.txtArTimeUpLimit.ErropPr = this.errorProvider1;
            //
            this.txtArTimeUpLimit.Length = 0;
            this.txtArTimeUpLimit.Location = new System.Drawing.Point(189, 40);
            this.txtArTimeUpLimit.Max = 999;
            ////
            //
            this.txtArTimeUpLimit.MaxStrLength = 0;
            this.txtArTimeUpLimit.Min = 0;
            ////
            //
            this.txtArTimeUpLimit.MinStrLength = 0;
            this.txtArTimeUpLimit.Name = "txtArTimeUpLimit";
            this.txtArTimeUpLimit.Precision = 0;
            //
            this.txtArTimeUpLimit.Size = new System.Drawing.Size(100, 21);
            this.txtArTimeUpLimit.TabIndex = 2;
            this.txtArTimeUpLimit.ToolTipValid = this.toolTip1;
          //
            this.txtArTimeUpLimit.ValidEable = true;
            this.txtArTimeUpLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtArTimeLowLimit
            // 
            this.txtArTimeLowLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "Ar_Time_LowLimit", true));
            //
            this.txtArTimeLowLimit.EnableNull = false;
            this.txtArTimeLowLimit.ErropPr = this.errorProvider1;
            //
            this.txtArTimeLowLimit.Length = 0;
            this.txtArTimeLowLimit.Location = new System.Drawing.Point(189, 72);
            this.txtArTimeLowLimit.Max = 999;
            ////
            //
            this.txtArTimeLowLimit.MaxStrLength = 0;
            this.txtArTimeLowLimit.Min = 0;
            ////
            //
            this.txtArTimeLowLimit.MinStrLength = 0;
            this.txtArTimeLowLimit.Name = "txtArTimeLowLimit";
            this.txtArTimeLowLimit.Precision = 0;
            //
            this.txtArTimeLowLimit.Size = new System.Drawing.Size(100, 21);
            this.txtArTimeLowLimit.TabIndex = 3;
            this.txtArTimeLowLimit.ToolTipValid = this.toolTip1;
          //
            this.txtArTimeLowLimit.ValidEable = true;
            this.txtArTimeLowLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPreArOxyMax
            // 
            this.txtPreArOxyMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_Oxy_Max", true));
            //
            this.txtPreArOxyMax.EnableNull = false;
            this.txtPreArOxyMax.ErropPr = this.errorProvider1;
            //
            this.txtPreArOxyMax.Length = 0;
            this.txtPreArOxyMax.Location = new System.Drawing.Point(67, 40);
            this.txtPreArOxyMax.Max = 999;
            ////
            //
            this.txtPreArOxyMax.MaxStrLength = 0;
            this.txtPreArOxyMax.Min = 0;
            ////
            //
            this.txtPreArOxyMax.MinStrLength = 0;
            this.txtPreArOxyMax.Name = "txtPreArOxyMax";
            this.txtPreArOxyMax.Precision = 0;
            //
            this.txtPreArOxyMax.Size = new System.Drawing.Size(100, 21);
            this.txtPreArOxyMax.TabIndex = 0;
            this.txtPreArOxyMax.ToolTipValid = this.toolTip1;
          //
            this.txtPreArOxyMax.ValidEable = true;
            this.txtPreArOxyMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // gbxTemp
            // 
            this.gbxTemp.Controls.Add(this.label23);
            this.gbxTemp.Controls.Add(this.label22);
            this.gbxTemp.Controls.Add(this.txtBeArAim);
            this.gbxTemp.Controls.Add(this.txtPreArAim);
            this.gbxTemp.Controls.Add(this.txtBeArFirAim);
            this.gbxTemp.Controls.Add(this.txtPreArFirAim);
            this.gbxTemp.Controls.Add(this.label21);
            this.gbxTemp.Controls.Add(this.label26);
            this.gbxTemp.Controls.Add(this.label25);
            this.gbxTemp.Controls.Add(this.label7);
            this.gbxTemp.Controls.Add(this.txtBeArFirMin);
            this.gbxTemp.Controls.Add(this.label13);
            this.gbxTemp.Controls.Add(this.txtBeArMax);
            this.gbxTemp.Controls.Add(this.txtPreArFirMin);
            this.gbxTemp.Controls.Add(this.txtBeArMin);
            this.gbxTemp.Controls.Add(this.txtPreArMax);
            this.gbxTemp.Controls.Add(this.txtBeArFirMax);
            this.gbxTemp.Controls.Add(this.txtPreArMin);
            this.gbxTemp.Controls.Add(this.txtPreArFirMax);
            this.gbxTemp.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxTemp.Location = new System.Drawing.Point(0, 69);
            this.gbxTemp.Name = "gbxTemp";
            this.gbxTemp.Size = new System.Drawing.Size(1010, 132);
            this.gbxTemp.TabIndex = 1;
            this.gbxTemp.TabStop = false;
            this.gbxTemp.Text = "钢水温度";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "目标:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 12);
            this.label22.TabIndex = 2;
            this.label22.Text = "最小:";
            // 
            // txtBeArAim
            // 
            this.txtBeArAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_SteelTemp_Aim", true));
            //
            this.txtBeArAim.EnableNull = false;
            this.txtBeArAim.ErropPr = this.errorProvider1;
            //
            this.txtBeArAim.Length = 0;
            this.txtBeArAim.Location = new System.Drawing.Point(433, 101);
            this.txtBeArAim.Max = 2000;
            ////
            //
            this.txtBeArAim.MaxStrLength = 0;
            this.txtBeArAim.Min = 0;
           // //
            //
            this.txtBeArAim.MinStrLength = 0;
            this.txtBeArAim.Name = "txtBeArAim";
            this.txtBeArAim.Precision = 0;
            //
            this.txtBeArAim.Size = new System.Drawing.Size(100, 21);
            this.txtBeArAim.TabIndex = 11;
            this.txtBeArAim.ToolTipValid = this.toolTip1;
          //
            this.txtBeArAim.ValidEable = true;
            this.txtBeArAim.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtBeArAim.TextChanged += new System.EventHandler(this.txtBeArAim_TextChanged);
            // 
            // txtPreArAim
            // 
            this.txtPreArAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_SteelTemp_Aim", true));
            //
            this.txtPreArAim.EnableNull = false;
            this.txtPreArAim.ErropPr = this.errorProvider1;
            //
            this.txtPreArAim.Length = 0;
            this.txtPreArAim.Location = new System.Drawing.Point(189, 101);
            this.txtPreArAim.Max = 2000;
            ////
            //
            this.txtPreArAim.MaxStrLength = 0;
            this.txtPreArAim.Min = 0;
            ////
            //
            this.txtPreArAim.MinStrLength = 0;
            this.txtPreArAim.Name = "txtPreArAim";
            this.txtPreArAim.Precision = 0;
            //
            this.txtPreArAim.Size = new System.Drawing.Size(100, 21);
            this.txtPreArAim.TabIndex = 5;
            this.txtPreArAim.ToolTipValid = this.toolTip1;
          //
            this.txtPreArAim.ValidEable = true;
            this.txtPreArAim.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtBeArFirAim
            // 
            this.txtBeArFirAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_SteelTemp_Fir_Aim", true));
            //
            this.txtBeArFirAim.EnableNull = false;
            this.txtBeArFirAim.ErropPr = this.errorProvider1;
            //
            this.txtBeArFirAim.Length = 0;
            this.txtBeArFirAim.Location = new System.Drawing.Point(311, 101);
            this.txtBeArFirAim.Max = 2000;
            ////
            //
            this.txtBeArFirAim.MaxStrLength = 0;
            this.txtBeArFirAim.Min = 0;
            ////
            //
            this.txtBeArFirAim.MinStrLength = 0;
            this.txtBeArFirAim.Name = "txtBeArFirAim";
            this.txtBeArFirAim.Precision = 0;
            //
            this.txtBeArFirAim.Size = new System.Drawing.Size(100, 21);
            this.txtBeArFirAim.TabIndex = 8;
            this.txtBeArFirAim.ToolTipValid = this.toolTip1;
          //
            this.txtBeArFirAim.ValidEable = true;
            this.txtBeArFirAim.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPreArFirAim
            // 
            this.txtPreArFirAim.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_SteelTemp_Fir_Aim", true));
            //
            this.txtPreArFirAim.EnableNull = false;
            this.txtPreArFirAim.ErropPr = this.errorProvider1;
            //
            this.txtPreArFirAim.Length = 0;
            this.txtPreArFirAim.Location = new System.Drawing.Point(67, 101);
            this.txtPreArFirAim.Max = 2000;
            ////
            //
            this.txtPreArFirAim.MaxStrLength = 0;
            this.txtPreArFirAim.Min = 0;
            ////
            //
            this.txtPreArFirAim.MinStrLength = 0;
            this.txtPreArFirAim.Name = "txtPreArFirAim";
            this.txtPreArFirAim.Precision = 0;
            //
            this.txtPreArFirAim.Size = new System.Drawing.Size(100, 21);
            this.txtPreArFirAim.TabIndex = 2;
            this.txtPreArFirAim.ToolTipValid = this.toolTip1;
          //
            this.txtPreArFirAim.ValidEable = true;
            this.txtPreArFirAim.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(22, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 2;
            this.label21.Text = "最大:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(317, 17);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 12);
            this.label26.TabIndex = 2;
            this.label26.Text = "氩后连铸第一炉";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(451, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 2;
            this.label25.Text = "氩后连铸炉";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "氩前连铸第一炉";
            // 
            // txtBeArFirMin
            // 
            this.txtBeArFirMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_SteelTemp_Fir_Min", true));
            //
            this.txtBeArFirMin.EnableNull = false;
            this.txtBeArFirMin.ErropPr = this.errorProvider1;
            //
            this.txtBeArFirMin.Length = 0;
            this.txtBeArFirMin.Location = new System.Drawing.Point(311, 71);
            this.txtBeArFirMin.Max = 2000;
            ////
            //
            this.txtBeArFirMin.MaxStrLength = 0;
            this.txtBeArFirMin.Min = 0;
            ////
            //
            this.txtBeArFirMin.MinStrLength = 0;
            this.txtBeArFirMin.Name = "txtBeArFirMin";
            this.txtBeArFirMin.Precision = 0;
            //
            this.txtBeArFirMin.Size = new System.Drawing.Size(100, 21);
            this.txtBeArFirMin.TabIndex = 7;
            this.txtBeArFirMin.ToolTipValid = this.toolTip1;
          //
            this.txtBeArFirMin.ValidEable = true;
            this.txtBeArFirMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "氩前连铸炉";
            // 
            // txtBeArMax
            // 
            this.txtBeArMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_SteelTemp_Max", true));
            //
            this.txtBeArMax.EnableNull = false;
            this.txtBeArMax.ErropPr = this.errorProvider1;
            //
            this.txtBeArMax.Length = 0;
            this.txtBeArMax.Location = new System.Drawing.Point(433, 42);
            this.txtBeArMax.Max = 2000;
           // //
            //
            this.txtBeArMax.MaxStrLength = 0;
            this.txtBeArMax.Min = 0;
            ////
            //
            this.txtBeArMax.MinStrLength = 0;
            this.txtBeArMax.Name = "txtBeArMax";
            this.txtBeArMax.Precision = 0;
            //
            this.txtBeArMax.Size = new System.Drawing.Size(100, 21);
            this.txtBeArMax.TabIndex = 9;
            this.txtBeArMax.ToolTipValid = this.toolTip1;
          //
            this.txtBeArMax.ValidEable = true;
            this.txtBeArMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPreArFirMin
            // 
            this.txtPreArFirMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_SteelTemp_Fir_Min", true));
            //
            this.txtPreArFirMin.EnableNull = false;
            this.txtPreArFirMin.ErropPr = this.errorProvider1;
            //
            this.txtPreArFirMin.Length = 0;
            this.txtPreArFirMin.Location = new System.Drawing.Point(67, 71);
            this.txtPreArFirMin.Max = 2000;
            ////
            //
            this.txtPreArFirMin.MaxStrLength = 0;
            this.txtPreArFirMin.Min = 0;
            ////
            //
            this.txtPreArFirMin.MinStrLength = 0;
            this.txtPreArFirMin.Name = "txtPreArFirMin";
            this.txtPreArFirMin.Precision = 0;
            //
            this.txtPreArFirMin.Size = new System.Drawing.Size(100, 21);
            this.txtPreArFirMin.TabIndex = 1;
            this.txtPreArFirMin.ToolTipValid = this.toolTip1;
          //
            this.txtPreArFirMin.ValidEable = true;
            this.txtPreArFirMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtBeArMin
            // 
            this.txtBeArMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_SteelTemp_Min", true));
            //
            this.txtBeArMin.EnableNull = false;
            this.txtBeArMin.ErropPr = this.errorProvider1;
            //
            this.txtBeArMin.Length = 0;
            this.txtBeArMin.Location = new System.Drawing.Point(433, 71);
            this.txtBeArMin.Max = 2000;
            ////
            //
            this.txtBeArMin.MaxStrLength = 0;
            this.txtBeArMin.Min = 0;
            ////
            //
            this.txtBeArMin.MinStrLength = 0;
            this.txtBeArMin.Name = "txtBeArMin";
            this.txtBeArMin.Precision = 0;
            //
            this.txtBeArMin.Size = new System.Drawing.Size(100, 21);
            this.txtBeArMin.TabIndex = 10;
            this.txtBeArMin.ToolTipValid = this.toolTip1;
          //
            this.txtBeArMin.ValidEable = true;
            this.txtBeArMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPreArMax
            // 
            this.txtPreArMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_SteelTemp_Max", true));
            //
            this.txtPreArMax.EnableNull = false;
            this.txtPreArMax.ErropPr = this.errorProvider1;
            //
            this.txtPreArMax.Length = 0;
            this.txtPreArMax.Location = new System.Drawing.Point(189, 42);
            this.txtPreArMax.Max = 2000;
            ////
            //
            this.txtPreArMax.MaxStrLength = 0;
            this.txtPreArMax.Min = 0;
            ////
            //
            this.txtPreArMax.MinStrLength = 0;
            this.txtPreArMax.Name = "txtPreArMax";
            this.txtPreArMax.Precision = 0;
            //
            this.txtPreArMax.Size = new System.Drawing.Size(100, 21);
            this.txtPreArMax.TabIndex = 3;
            this.txtPreArMax.ToolTipValid = this.toolTip1;
          //
            this.txtPreArMax.ValidEable = true;
            this.txtPreArMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtBeArFirMax
            // 
            this.txtBeArFirMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "BeAr_SteelTemp_Fir_Max", true));
            //
            this.txtBeArFirMax.EnableNull = false;
            this.txtBeArFirMax.ErropPr = this.errorProvider1;
            //
            this.txtBeArFirMax.Length = 0;
            this.txtBeArFirMax.Location = new System.Drawing.Point(311, 42);
            this.txtBeArFirMax.Max = 2000;
            ////
            //
            this.txtBeArFirMax.MaxStrLength = 0;
            this.txtBeArFirMax.Min = 0;
            ////
            //
            this.txtBeArFirMax.MinStrLength = 0;
            this.txtBeArFirMax.Name = "txtBeArFirMax";
            this.txtBeArFirMax.Precision = 0;
            //
            this.txtBeArFirMax.Size = new System.Drawing.Size(100, 21);
            this.txtBeArFirMax.TabIndex = 6;
            this.txtBeArFirMax.ToolTipValid = this.toolTip1;
          //
            this.txtBeArFirMax.ValidEable = true;
            this.txtBeArFirMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPreArMin
            // 
            this.txtPreArMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_SteelTemp_Min", true));
            //
            this.txtPreArMin.EnableNull = false;
            this.txtPreArMin.ErropPr = this.errorProvider1;
            //
            this.txtPreArMin.Length = 0;
            this.txtPreArMin.Location = new System.Drawing.Point(189, 71);
            this.txtPreArMin.Max = 2000;
           // //
            //
            this.txtPreArMin.MaxStrLength = 0;
            this.txtPreArMin.Min = 0;
           // //
            //
            this.txtPreArMin.MinStrLength = 0;
            this.txtPreArMin.Name = "txtPreArMin";
            this.txtPreArMin.Precision = 0;
            //
            this.txtPreArMin.Size = new System.Drawing.Size(100, 21);
            this.txtPreArMin.TabIndex = 4;
            this.txtPreArMin.ToolTipValid = this.toolTip1;
          //
            this.txtPreArMin.ValidEable = true;
            this.txtPreArMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPreArFirMax
            // 
            this.txtPreArFirMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "PreAr_SteelTemp_Fir_Max", true));
            //
            this.txtPreArFirMax.EnableNull = false;
            this.txtPreArFirMax.ErropPr = this.errorProvider1;
            //
            this.txtPreArFirMax.Length = 0;
            this.txtPreArFirMax.Location = new System.Drawing.Point(67, 42);
            this.txtPreArFirMax.Max = 2000;
            ////
            //
            this.txtPreArFirMax.MaxStrLength = 0;
            this.txtPreArFirMax.Min = 0;
           // //
            //
            this.txtPreArFirMax.MinStrLength = 0;
            this.txtPreArFirMax.Name = "txtPreArFirMax";
            this.txtPreArFirMax.Precision = 0;
            //
            this.txtPreArFirMax.Size = new System.Drawing.Size(100, 21);
            this.txtPreArFirMax.TabIndex = 0;
            this.txtPreArFirMax.ToolTipValid = this.toolTip1;
          //
            this.txtPreArFirMax.ValidEable = true;
            this.txtPreArFirMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbOxyFlag);
            this.groupBox2.Controls.Add(this.txtSteelGradeIndexAr);
            this.groupBox2.Controls.Add(this.label14);
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
            // cmbOxyFlag
            // 
            this.cmbOxyFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOxyFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOxyFlag.BackColor = System.Drawing.SystemColors.Window;
            this.cmbOxyFlag.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsAr, "Oxy_Flag", true));
            this.cmbOxyFlag.EnableNull = true;
            this.cmbOxyFlag.ErropPr = null;
            this.cmbOxyFlag.FormattingEnabled = true;
            this.cmbOxyFlag.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbOxyFlag.Location = new System.Drawing.Point(364, 23);
            this.cmbOxyFlag.Name = "cmbOxyFlag";
            //
            this.cmbOxyFlag.Size = new System.Drawing.Size(121, 20);
            this.cmbOxyFlag.TabIndex = 1;
            //
            this.cmbOxyFlag.ToolTipValid = null;
            this.cmbOxyFlag.ValidEable = false;
            this.cmbOxyFlag.SelectedIndexChanged += new System.EventHandler(this.cmbOxyFlag_SelectedIndexChanged);
            // 
            // txtSteelGradeIndexAr
            // 
            this.txtSteelGradeIndexAr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAr, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexAr.EnableNull = false;
            this.txtSteelGradeIndexAr.ErropPr = null;
            //
            this.txtSteelGradeIndexAr.Length = 8;
            this.txtSteelGradeIndexAr.Location = new System.Drawing.Point(86, 23);
            this.txtSteelGradeIndexAr.Max = 0;
            this.txtSteelGradeIndexAr.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexAr.MaxStrLength = 0;
            this.txtSteelGradeIndexAr.Min = 0;
           // //
            //
            this.txtSteelGradeIndexAr.MinStrLength = 0;
            this.txtSteelGradeIndexAr.Name = "txtSteelGradeIndexAr";
            this.txtSteelGradeIndexAr.Precision = 0;
            this.txtSteelGradeIndexAr.ReadOnly = true;
            //
            this.txtSteelGradeIndexAr.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexAr.TabIndex = 0;
            this.txtSteelGradeIndexAr.ToolTipValid = null;
          //
            this.txtSteelGradeIndexAr.ValidEable = true;
            this.txtSteelGradeIndexAr.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "炉后定氧否:";
            // 
            // tabBlow
            // 
            this.tabBlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBlow.Controls.Add(this.groupBox19);
            this.tabBlow.Location = new System.Drawing.Point(4, 21);
            this.tabBlow.Name = "tabBlow";
            this.tabBlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBlow.Size = new System.Drawing.Size(1012, 587);
            this.tabBlow.TabIndex = 1;
            this.tabBlow.Text = "吹炼信息";
            this.tabBlow.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label8);
            this.groupBox19.Controls.Add(this.label12);
            this.groupBox19.Controls.Add(this.txtSteelGradeIndexBlow);
            this.groupBox19.Controls.Add(this.txtBottomBlowBase);
            this.groupBox19.Controls.Add(this.txtReBlowCntMax);
            this.groupBox19.Controls.Add(this.label11);
            this.groupBox19.Controls.Add(this.label9);
            this.groupBox19.Controls.Add(this.txtReBlowTimeMax);
            this.groupBox19.Controls.Add(this.txtCatchCTempMin);
            this.groupBox19.Controls.Add(this.label10);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox19.Location = new System.Drawing.Point(3, 3);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1004, 172);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "炼钢记号:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(65, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "底吹基准:";
            // 
            // txtSteelGradeIndexBlow
            // 
            this.txtSteelGradeIndexBlow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlow, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexBlow.EnableNull = false;
            this.txtSteelGradeIndexBlow.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexBlow.Length = 8;
            this.txtSteelGradeIndexBlow.Location = new System.Drawing.Point(130, 20);
            this.txtSteelGradeIndexBlow.Max = 0;
            this.txtSteelGradeIndexBlow.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexBlow.MaxStrLength = 0;
            this.txtSteelGradeIndexBlow.Min = 0;
            ////
            //
            this.txtSteelGradeIndexBlow.MinStrLength = 0;
            this.txtSteelGradeIndexBlow.Name = "txtSteelGradeIndexBlow";
            this.txtSteelGradeIndexBlow.Precision = 0;
            this.txtSteelGradeIndexBlow.ReadOnly = true;
            //
            this.txtSteelGradeIndexBlow.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexBlow.TabIndex = 0;
            this.txtSteelGradeIndexBlow.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexBlow.ValidEable = true;
            this.txtSteelGradeIndexBlow.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // bsBlow
            // 
            this.bsBlow.DataMember = "L3DataTable";
            this.bsBlow.DataSource = this.dsBlow;
            // 
            // dsBlow
            // 
            this.dsBlow.AutoLoad = true;
            this.dsBlow.AutoSubscribe = false;
            this.dsBlow.DataSetName = "L3DataSet";
            this.dsBlow.DeleteMethod = null;
            this.dsBlow.InsertMethod = null;
            this.dsBlow.L3DataAdapter = this.Adapter;
            this.dsBlow.LoadEvent = "Click";
            this.dsBlow.LoadTrigger = null;
            this.dsBlow.RefreshValve = 1000;
            this.dsBlow.SourceCommand = null;
            this.dsBlow.SourceCondition = "1=2";
            this.dsBlow.SourceMethod = "";
            this.dsBlow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBlow.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Blow";
            this.dsBlow.SubscribeTarget = "";
            this.dsBlow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBlow});
            this.dsBlow.UpdateEvent = "Click";
            this.dsBlow.UpdateMethod = null;
            this.dsBlow.UpdateTrigger = null;
            // 
            // schemadsBlow
            // 
            this.schemadsBlow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBlowL3DataTableGUID,
            this.coldsBlowL3DataTableName,
            this.coldsBlowL3DataTableSteelGradeIndex,
            this.coldsBlowL3DataTableReBlow_Cnt_Max,
            this.coldsBlowL3DataTableCatch_C_Temp_Min,
            this.coldsBlowL3DataTableReBlow_Time_Max,
            this.coldsBlowL3DataTableBottom_Blow_Base});
            this.schemadsBlow.TableName = "L3DataTable";
            // 
            // coldsBlowL3DataTableGUID
            // 
            this.coldsBlowL3DataTableGUID.Caption = "GUID";
            this.coldsBlowL3DataTableGUID.ColumnName = "GUID";
            this.coldsBlowL3DataTableGUID.Namespace = "";
            // 
            // coldsBlowL3DataTableName
            // 
            this.coldsBlowL3DataTableName.Caption = "Name";
            this.coldsBlowL3DataTableName.ColumnName = "Name";
            this.coldsBlowL3DataTableName.Namespace = "";
            // 
            // coldsBlowL3DataTableSteelGradeIndex
            // 
            this.coldsBlowL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBlowL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBlowL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBlowL3DataTableReBlow_Cnt_Max
            // 
            this.coldsBlowL3DataTableReBlow_Cnt_Max.Caption = "ReBlow_Cnt_Max";
            this.coldsBlowL3DataTableReBlow_Cnt_Max.ColumnName = "ReBlow_Cnt_Max";
            this.coldsBlowL3DataTableReBlow_Cnt_Max.DataType = typeof(int);
            this.coldsBlowL3DataTableReBlow_Cnt_Max.Namespace = "";
            // 
            // coldsBlowL3DataTableCatch_C_Temp_Min
            // 
            this.coldsBlowL3DataTableCatch_C_Temp_Min.Caption = "Catch_C_Temp_Min";
            this.coldsBlowL3DataTableCatch_C_Temp_Min.ColumnName = "Catch_C_Temp_Min";
            this.coldsBlowL3DataTableCatch_C_Temp_Min.DataType = typeof(int);
            this.coldsBlowL3DataTableCatch_C_Temp_Min.Namespace = "";
            // 
            // coldsBlowL3DataTableReBlow_Time_Max
            // 
            this.coldsBlowL3DataTableReBlow_Time_Max.Caption = "ReBlow_Time_Max";
            this.coldsBlowL3DataTableReBlow_Time_Max.ColumnName = "ReBlow_Time_Max";
            this.coldsBlowL3DataTableReBlow_Time_Max.DataType = typeof(int);
            this.coldsBlowL3DataTableReBlow_Time_Max.Namespace = "";
            // 
            // coldsBlowL3DataTableBottom_Blow_Base
            // 
            this.coldsBlowL3DataTableBottom_Blow_Base.Caption = "Bottom_Blow_Base";
            this.coldsBlowL3DataTableBottom_Blow_Base.ColumnName = "Bottom_Blow_Base";
            this.coldsBlowL3DataTableBottom_Blow_Base.Namespace = "";
            // 
            // txtBottomBlowBase
            // 
            this.txtBottomBlowBase.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlow, "Bottom_Blow_Base", true));
            //
            this.txtBottomBlowBase.EnableNull = false;
            this.txtBottomBlowBase.ErropPr = null;
            //
            this.txtBottomBlowBase.Length = 0;
            this.txtBottomBlowBase.Location = new System.Drawing.Point(130, 140);
            this.txtBottomBlowBase.Max = 0;
            ////
            //
            this.txtBottomBlowBase.MaxStrLength = 0;
            this.txtBottomBlowBase.Min = 0;
           // //
            //
            this.txtBottomBlowBase.MinStrLength = 0;
            this.txtBottomBlowBase.Name = "txtBottomBlowBase";
            this.txtBottomBlowBase.Precision = 0;
            //
            this.txtBottomBlowBase.Size = new System.Drawing.Size(181, 21);
            this.txtBottomBlowBase.TabIndex = 4;
            this.txtBottomBlowBase.ToolTipValid = null;
          //
            this.txtBottomBlowBase.ValidEable = true;
            this.txtBottomBlowBase.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtReBlowCntMax
            // 
            this.txtReBlowCntMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlow, "ReBlow_Cnt_Max", true));
            //
            this.txtReBlowCntMax.EnableNull = false;
            this.txtReBlowCntMax.ErropPr = this.errorProvider1;
            //
            this.txtReBlowCntMax.Length = 0;
            this.txtReBlowCntMax.Location = new System.Drawing.Point(130, 50);
            this.txtReBlowCntMax.Max = 99;
            ////
            //
            this.txtReBlowCntMax.MaxStrLength = 0;
            this.txtReBlowCntMax.Min = 0;
           // //
            //
            this.txtReBlowCntMax.MinStrLength = 0;
            this.txtReBlowCntMax.Name = "txtReBlowCntMax";
            this.txtReBlowCntMax.Precision = 0;
            //
            this.txtReBlowCntMax.Size = new System.Drawing.Size(181, 21);
            this.txtReBlowCntMax.TabIndex = 1;
            this.txtReBlowCntMax.ToolTipValid = this.toolTip1;
          //
            this.txtReBlowCntMax.ValidEable = true;
            this.txtReBlowCntMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "补吹时间最大:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "补吹次数最大:";
            // 
            // txtReBlowTimeMax
            // 
            this.txtReBlowTimeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlow, "ReBlow_Time_Max", true));
            //
            this.txtReBlowTimeMax.EnableNull = false;
            this.txtReBlowTimeMax.ErropPr = this.errorProvider1;
            //
            this.txtReBlowTimeMax.Length = 0;
            this.txtReBlowTimeMax.Location = new System.Drawing.Point(130, 110);
            this.txtReBlowTimeMax.Max = 999;
           // //
            //
            this.txtReBlowTimeMax.MaxStrLength = 0;
            this.txtReBlowTimeMax.Min = 0;
           // //
            //
            this.txtReBlowTimeMax.MinStrLength = 0;
            this.txtReBlowTimeMax.Name = "txtReBlowTimeMax";
            this.txtReBlowTimeMax.Precision = 0;
            //
            this.txtReBlowTimeMax.Size = new System.Drawing.Size(181, 21);
            this.txtReBlowTimeMax.TabIndex = 3;
            this.txtReBlowTimeMax.ToolTipValid = this.toolTip1;
          //
            this.txtReBlowTimeMax.ValidEable = true;
            this.txtReBlowTimeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCatchCTempMin
            // 
            this.txtCatchCTempMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlow, "Catch_C_Temp_Min", true));
            //
            this.txtCatchCTempMin.EnableNull = false;
            this.txtCatchCTempMin.ErropPr = this.errorProvider1;
            //
            this.txtCatchCTempMin.Length = 0;
            this.txtCatchCTempMin.Location = new System.Drawing.Point(130, 80);
            this.txtCatchCTempMin.Max = 9999;
            ////
            //
            this.txtCatchCTempMin.MaxStrLength = 0;
            this.txtCatchCTempMin.Min = 0;
           // //
            //
            this.txtCatchCTempMin.MinStrLength = 0;
            this.txtCatchCTempMin.Name = "txtCatchCTempMin";
            this.txtCatchCTempMin.Precision = 0;
            //
            this.txtCatchCTempMin.Size = new System.Drawing.Size(181, 21);
            this.txtCatchCTempMin.TabIndex = 2;
            this.txtCatchCTempMin.ToolTipValid = this.toolTip1;
          //
            this.txtCatchCTempMin.ValidEable = true;
            this.txtCatchCTempMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "拉碳温度最小:";
            // 
            // tabBlowO2
            // 
            this.tabBlowO2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBlowO2.Controls.Add(this.groupBox20);
            this.tabBlowO2.Location = new System.Drawing.Point(4, 21);
            this.tabBlowO2.Name = "tabBlowO2";
            this.tabBlowO2.Size = new System.Drawing.Size(1012, 587);
            this.tabBlowO2.TabIndex = 2;
            this.tabBlowO2.Text = "吹氧信息";
            this.tabBlowO2.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.label30);
            this.groupBox20.Controls.Add(this.label27);
            this.groupBox20.Controls.Add(this.txtSteelGradeIndexBlowO2);
            this.groupBox20.Controls.Add(this.txtO2BlowCtr);
            this.groupBox20.Controls.Add(this.txtTotalO2PressCtr);
            this.groupBox20.Controls.Add(this.label28);
            this.groupBox20.Controls.Add(this.label29);
            this.groupBox20.Controls.Add(this.txtWorkO2PressCtr);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox20.Location = new System.Drawing.Point(0, 0);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(1010, 147);
            this.groupBox20.TabIndex = 0;
            this.groupBox20.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(82, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 12);
            this.label30.TabIndex = 6;
            this.label30.Text = "炼钢记号:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(34, 113);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(107, 12);
            this.label27.TabIndex = 9;
            this.label27.Text = "氧气流量控制基准:";
            // 
            // txtSteelGradeIndexBlowO2
            // 
            this.txtSteelGradeIndexBlowO2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlowO2, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexBlowO2.EnableNull = false;
            this.txtSteelGradeIndexBlowO2.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexBlowO2.Length = 8;
            this.txtSteelGradeIndexBlowO2.Location = new System.Drawing.Point(147, 20);
            this.txtSteelGradeIndexBlowO2.Max = 0;
            this.txtSteelGradeIndexBlowO2.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexBlowO2.MaxStrLength = 0;
            this.txtSteelGradeIndexBlowO2.Min = 0;
           // //
            //
            this.txtSteelGradeIndexBlowO2.MinStrLength = 0;
            this.txtSteelGradeIndexBlowO2.Name = "txtSteelGradeIndexBlowO2";
            this.txtSteelGradeIndexBlowO2.Precision = 0;
            this.txtSteelGradeIndexBlowO2.ReadOnly = true;
            //
            this.txtSteelGradeIndexBlowO2.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexBlowO2.TabIndex = 0;
            this.txtSteelGradeIndexBlowO2.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexBlowO2.ValidEable = true;
            this.txtSteelGradeIndexBlowO2.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // bsBlowO2
            // 
            this.bsBlowO2.DataMember = "L3DataTable";
            this.bsBlowO2.DataSource = this.dsBlowO2;
            // 
            // dsBlowO2
            // 
            this.dsBlowO2.AutoLoad = true;
            this.dsBlowO2.AutoSubscribe = false;
            this.dsBlowO2.DataSetName = "L3DataSet";
            this.dsBlowO2.DeleteMethod = null;
            this.dsBlowO2.InsertMethod = null;
            this.dsBlowO2.L3DataAdapter = this.Adapter;
            this.dsBlowO2.LoadEvent = "Click";
            this.dsBlowO2.LoadTrigger = null;
            this.dsBlowO2.RefreshValve = 1000;
            this.dsBlowO2.SourceCommand = null;
            this.dsBlowO2.SourceCondition = "1=2";
            this.dsBlowO2.SourceMethod = "";
            this.dsBlowO2.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBlowO2.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_BlowO2";
            this.dsBlowO2.SubscribeTarget = null;
            this.dsBlowO2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBlowO2});
            this.dsBlowO2.UpdateEvent = "Click";
            this.dsBlowO2.UpdateMethod = null;
            this.dsBlowO2.UpdateTrigger = null;
            // 
            // schemadsBlowO2
            // 
            this.schemadsBlowO2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBlowO2L3DataTableSteelGradeIndex,
            this.coldsBlowO2L3DataTableGUID,
            this.coldsBlowO2L3DataTableName,
            this.coldsBlowO2L3DataTableTotal_O2_Press_Ctr,
            this.coldsBlowO2L3DataTableWork_O2_Press_Ctr,
            this.coldsBlowO2L3DataTableO2_Blow_Ctr});
            this.schemadsBlowO2.TableName = "L3DataTable";
            // 
            // coldsBlowO2L3DataTableSteelGradeIndex
            // 
            this.coldsBlowO2L3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBlowO2L3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBlowO2L3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBlowO2L3DataTableGUID
            // 
            this.coldsBlowO2L3DataTableGUID.Caption = "GUID";
            this.coldsBlowO2L3DataTableGUID.ColumnName = "GUID";
            this.coldsBlowO2L3DataTableGUID.Namespace = "";
            // 
            // coldsBlowO2L3DataTableName
            // 
            this.coldsBlowO2L3DataTableName.Caption = "Name";
            this.coldsBlowO2L3DataTableName.ColumnName = "Name";
            this.coldsBlowO2L3DataTableName.Namespace = "";
            // 
            // coldsBlowO2L3DataTableTotal_O2_Press_Ctr
            // 
            this.coldsBlowO2L3DataTableTotal_O2_Press_Ctr.Caption = "Total_O2_Press_Ctr";
            this.coldsBlowO2L3DataTableTotal_O2_Press_Ctr.ColumnName = "Total_O2_Press_Ctr";
            this.coldsBlowO2L3DataTableTotal_O2_Press_Ctr.Namespace = "";
            // 
            // coldsBlowO2L3DataTableWork_O2_Press_Ctr
            // 
            this.coldsBlowO2L3DataTableWork_O2_Press_Ctr.Caption = "Work_O2_Press_Ctr";
            this.coldsBlowO2L3DataTableWork_O2_Press_Ctr.ColumnName = "Work_O2_Press_Ctr";
            this.coldsBlowO2L3DataTableWork_O2_Press_Ctr.Namespace = "";
            // 
            // coldsBlowO2L3DataTableO2_Blow_Ctr
            // 
            this.coldsBlowO2L3DataTableO2_Blow_Ctr.Caption = "O2_Blow_Ctr";
            this.coldsBlowO2L3DataTableO2_Blow_Ctr.ColumnName = "O2_Blow_Ctr";
            this.coldsBlowO2L3DataTableO2_Blow_Ctr.Namespace = "";
            // 
            // txtO2BlowCtr
            // 
            this.txtO2BlowCtr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlowO2, "O2_Blow_Ctr", true));
            //
            this.txtO2BlowCtr.EnableNull = false;
            this.txtO2BlowCtr.ErropPr = this.errorProvider1;
            //
            this.txtO2BlowCtr.Length = 0;
            this.txtO2BlowCtr.Location = new System.Drawing.Point(147, 110);
            this.txtO2BlowCtr.Max = 0;
            ////
            //
            this.txtO2BlowCtr.MaxStrLength = 0;
            this.txtO2BlowCtr.Min = 0;
           // //
            //
            this.txtO2BlowCtr.MinStrLength = 0;
            this.txtO2BlowCtr.Name = "txtO2BlowCtr";
            this.txtO2BlowCtr.Precision = 0;
            //
            this.txtO2BlowCtr.Size = new System.Drawing.Size(181, 21);
            this.txtO2BlowCtr.TabIndex = 3;
            this.txtO2BlowCtr.ToolTipValid = this.toolTip1;
          //
            this.txtO2BlowCtr.ValidEable = true;
            this.txtO2BlowCtr.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTotalO2PressCtr
            // 
            this.txtTotalO2PressCtr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlowO2, "Total_O2_Press_Ctr", true));
            //
            this.txtTotalO2PressCtr.EnableNull = false;
            this.txtTotalO2PressCtr.ErropPr = this.errorProvider1;
            //
            this.txtTotalO2PressCtr.Length = 0;
            this.txtTotalO2PressCtr.Location = new System.Drawing.Point(147, 50);
            this.txtTotalO2PressCtr.Max = 0;
           // //
            //
            this.txtTotalO2PressCtr.MaxStrLength = 0;
            this.txtTotalO2PressCtr.Min = 0;
           // //
            //
            this.txtTotalO2PressCtr.MinStrLength = 0;
            this.txtTotalO2PressCtr.Name = "txtTotalO2PressCtr";
            this.txtTotalO2PressCtr.Precision = 0;
            //
            this.txtTotalO2PressCtr.Size = new System.Drawing.Size(181, 21);
            this.txtTotalO2PressCtr.TabIndex = 1;
            this.txtTotalO2PressCtr.ToolTipValid = this.toolTip1;
          //
            this.txtTotalO2PressCtr.ValidEable = true;
            this.txtTotalO2PressCtr.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(34, 83);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 12);
            this.label28.TabIndex = 8;
            this.label28.Text = "工作氧压控制基准:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(34, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 12);
            this.label29.TabIndex = 7;
            this.label29.Text = "总管氧压控制基准:";
            // 
            // txtWorkO2PressCtr
            // 
            this.txtWorkO2PressCtr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBlowO2, "Work_O2_Press_Ctr", true));
            //
            this.txtWorkO2PressCtr.EnableNull = false;
            this.txtWorkO2PressCtr.ErropPr = this.errorProvider1;
            //
            this.txtWorkO2PressCtr.Length = 0;
            this.txtWorkO2PressCtr.Location = new System.Drawing.Point(147, 80);
            this.txtWorkO2PressCtr.Max = 0;
           // //
            //
            this.txtWorkO2PressCtr.MaxStrLength = 0;
            this.txtWorkO2PressCtr.Min = 0;
            ////
            //
            this.txtWorkO2PressCtr.MinStrLength = 0;
            this.txtWorkO2PressCtr.Name = "txtWorkO2PressCtr";
            this.txtWorkO2PressCtr.Precision = 0;
            //
            this.txtWorkO2PressCtr.Size = new System.Drawing.Size(181, 21);
            this.txtWorkO2PressCtr.TabIndex = 2;
            this.txtWorkO2PressCtr.ToolTipValid = this.toolTip1;
          //
            this.txtWorkO2PressCtr.ValidEable = true;
            this.txtWorkO2PressCtr.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // tabBulk
            // 
            this.tabBulk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBulk.Controls.Add(this.hmiRootPanelBulk);
            this.tabBulk.Location = new System.Drawing.Point(4, 21);
            this.tabBulk.Name = "tabBulk";
            this.tabBulk.Size = new System.Drawing.Size(1012, 587);
            this.tabBulk.TabIndex = 3;
            this.tabBulk.Text = "散状料信息";
            this.tabBulk.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanelBulk
            // 
            this.hmiRootPanelBulk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelBulk.Controls.Add(this.dvBulk);
            this.hmiRootPanelBulk.Controls.Add(this.bNavigatorBulk);
            this.hmiRootPanelBulk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanelBulk.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanelBulk.Name = "hmiRootPanelBulk";
            this.hmiRootPanelBulk.Size = new System.Drawing.Size(1010, 585);
            this.hmiRootPanelBulk.TabIndex = 25;
            // 
            // dvBulk
            // 
            this.dvBulk.AllowUserToAddRows = false;
            this.dvBulk.AutoGenerateColumns = false;
            this.dvBulk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvBulk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvBulk.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBulk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.bulkCodeDataGridViewTextBoxColumn,
            this.bulkWeightMinDataGridViewTextBoxColumn,
            this.bulkWeightMaxDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn});
            this.dvBulk.DataSource = this.bsBulk;
            this.dvBulk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBulk.Location = new System.Drawing.Point(0, 25);
            this.dvBulk.Name = "dvBulk";
            this.dvBulk.RowTemplate.Height = 23;
            this.dvBulk.Size = new System.Drawing.Size(1006, 556);
            this.dvBulk.TabIndex = 1;
            this.dvBulk.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dv_DataBindingComplete);
            this.dvBulk.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBulk_DataError);
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // bulkCodeDataGridViewTextBoxColumn
            // 
            this.bulkCodeDataGridViewTextBoxColumn.DataPropertyName = "Bulk_Code";
            this.bulkCodeDataGridViewTextBoxColumn.HeaderText = "散状料名称";
            this.bulkCodeDataGridViewTextBoxColumn.Name = "bulkCodeDataGridViewTextBoxColumn";
            this.bulkCodeDataGridViewTextBoxColumn.Width = 90;
            // 
            // bulkWeightMinDataGridViewTextBoxColumn
            // 
            this.bulkWeightMinDataGridViewTextBoxColumn.DataPropertyName = "Bulk_Weight_Min";
            this.bulkWeightMinDataGridViewTextBoxColumn.HeaderText = "散状料1加入量最小";
            this.bulkWeightMinDataGridViewTextBoxColumn.Name = "bulkWeightMinDataGridViewTextBoxColumn";
            this.bulkWeightMinDataGridViewTextBoxColumn.Width = 132;
            // 
            // bulkWeightMaxDataGridViewTextBoxColumn
            // 
            this.bulkWeightMaxDataGridViewTextBoxColumn.DataPropertyName = "Bulk_Weight_Max";
            this.bulkWeightMaxDataGridViewTextBoxColumn.HeaderText = "散状料1加入量最大";
            this.bulkWeightMaxDataGridViewTextBoxColumn.Name = "bulkWeightMaxDataGridViewTextBoxColumn";
            this.bulkWeightMaxDataGridViewTextBoxColumn.Width = 132;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // bsBulk
            // 
            this.bsBulk.DataMember = "L3DataTable";
            this.bsBulk.DataSource = this.dsBulk;
            // 
            // dsBulk
            // 
            this.dsBulk.AutoLoad = true;
            this.dsBulk.AutoSubscribe = false;
            this.dsBulk.DataSetName = "L3DataSet";
            this.dsBulk.DeleteMethod = null;
            this.dsBulk.InsertMethod = null;
            this.dsBulk.L3DataAdapter = this.Adapter;
            this.dsBulk.LoadEvent = "Click";
            this.dsBulk.LoadTrigger = null;
            this.dsBulk.RefreshValve = 1000;
            this.dsBulk.SourceCommand = null;
            this.dsBulk.SourceCondition = "1=2";
            this.dsBulk.SourceMethod = "";
            this.dsBulk.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulk.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Bulk";
            this.dsBulk.SubscribeTarget = null;
            this.dsBulk.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulk});
            this.dsBulk.UpdateEvent = "Click";
            this.dsBulk.UpdateMethod = null;
            this.dsBulk.UpdateTrigger = null;
            // 
            // schemadsBulk
            // 
            this.schemadsBulk.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkL3DataTableGUID,
            this.coldsBulkL3DataTableName,
            this.coldsBulkL3DataTableSteelGradeIndex,
            this.coldsBulkL3DataTableBulk_Code,
            this.coldsBulkL3DataTableBulk_Weight_Min,
            this.coldsBulkL3DataTableBulk_Weight_Max});
            this.schemadsBulk.TableName = "L3DataTable";
            // 
            // coldsBulkL3DataTableGUID
            // 
            this.coldsBulkL3DataTableGUID.Caption = "GUID";
            this.coldsBulkL3DataTableGUID.ColumnName = "GUID";
            this.coldsBulkL3DataTableGUID.Namespace = "";
            // 
            // coldsBulkL3DataTableName
            // 
            this.coldsBulkL3DataTableName.Caption = "Name";
            this.coldsBulkL3DataTableName.ColumnName = "Name";
            this.coldsBulkL3DataTableName.Namespace = "";
            // 
            // coldsBulkL3DataTableSteelGradeIndex
            // 
            this.coldsBulkL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBulkL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBulkL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBulkL3DataTableBulk_Code
            // 
            this.coldsBulkL3DataTableBulk_Code.Caption = "Bulk_Code";
            this.coldsBulkL3DataTableBulk_Code.ColumnName = "Bulk_Code";
            this.coldsBulkL3DataTableBulk_Code.Namespace = "";
            // 
            // coldsBulkL3DataTableBulk_Weight_Min
            // 
            this.coldsBulkL3DataTableBulk_Weight_Min.Caption = "Bulk_Weight_Min";
            this.coldsBulkL3DataTableBulk_Weight_Min.ColumnName = "Bulk_Weight_Min";
            this.coldsBulkL3DataTableBulk_Weight_Min.Namespace = "";
            // 
            // coldsBulkL3DataTableBulk_Weight_Max
            // 
            this.coldsBulkL3DataTableBulk_Weight_Max.Caption = "Bulk_Weight_Max";
            this.coldsBulkL3DataTableBulk_Weight_Max.ColumnName = "Bulk_Weight_Max";
            this.coldsBulkL3DataTableBulk_Weight_Max.Namespace = "";
            // 
            // bNavigatorBulk
            // 
            this.bNavigatorBulk.AddNewItem = null;
            this.bNavigatorBulk.BindingSource = this.bsBulk;
            this.bNavigatorBulk.CountItem = this.bindingNavigatorCountItem;
            this.bNavigatorBulk.DeleteItem = null;
            this.bNavigatorBulk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAddBulk,
            this.btnDelBulk});
            this.bNavigatorBulk.Location = new System.Drawing.Point(0, 0);
            this.bNavigatorBulk.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavigatorBulk.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavigatorBulk.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNavigatorBulk.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNavigatorBulk.Name = "bNavigatorBulk";
            this.bNavigatorBulk.PositionItem = this.bindingNavigatorPositionItem;
            this.bNavigatorBulk.Size = new System.Drawing.Size(1006, 25);
            this.bNavigatorBulk.TabIndex = 0;
            this.bNavigatorBulk.Text = "bindingNavigator1";
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
            this.feedCodeDataGridViewTextBoxColumn,
            this.feedWeightMinDataGridViewTextBoxColumn,
            this.feedWeightMaxDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1});
            this.dvFeed.DataSource = this.bsFeed;
            this.dvFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFeed.Location = new System.Drawing.Point(0, 25);
            this.dvFeed.Name = "dvFeed";
            this.dvFeed.RowTemplate.Height = 23;
            this.dvFeed.Size = new System.Drawing.Size(1006, 556);
            this.dvFeed.TabIndex = 1;
            this.dvFeed.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dv_DataBindingComplete);
            this.dvFeed.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBulk_DataError);
            // 
            // steelGradeIndexDataGridViewTextBoxColumn1
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn1.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn1.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn1.Name = "steelGradeIndexDataGridViewTextBoxColumn1";
            this.steelGradeIndexDataGridViewTextBoxColumn1.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn1.Width = 78;
            // 
            // feedCodeDataGridViewTextBoxColumn
            // 
            this.feedCodeDataGridViewTextBoxColumn.DataPropertyName = "Feed_Code";
            this.feedCodeDataGridViewTextBoxColumn.HeaderText = "喂丝线名称";
            this.feedCodeDataGridViewTextBoxColumn.Name = "feedCodeDataGridViewTextBoxColumn";
            this.feedCodeDataGridViewTextBoxColumn.Width = 90;
            // 
            // feedWeightMinDataGridViewTextBoxColumn
            // 
            this.feedWeightMinDataGridViewTextBoxColumn.DataPropertyName = "Feed_Weight_Min";
            this.feedWeightMinDataGridViewTextBoxColumn.HeaderText = "喂丝线用量最小";
            this.feedWeightMinDataGridViewTextBoxColumn.Name = "feedWeightMinDataGridViewTextBoxColumn";
            this.feedWeightMinDataGridViewTextBoxColumn.Width = 114;
            // 
            // feedWeightMaxDataGridViewTextBoxColumn
            // 
            this.feedWeightMaxDataGridViewTextBoxColumn.DataPropertyName = "Feed_Weight_Max";
            this.feedWeightMaxDataGridViewTextBoxColumn.HeaderText = "喂丝线加入量最大";
            this.feedWeightMaxDataGridViewTextBoxColumn.Name = "feedWeightMaxDataGridViewTextBoxColumn";
            this.feedWeightMaxDataGridViewTextBoxColumn.Width = 126;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            this.gUIDDataGridViewTextBoxColumn1.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            this.nameDataGridViewTextBoxColumn1.Width = 54;
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
            this.dsFeed.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Feed";
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
            this.coldsFeedL3DataTableGUID,
            this.coldsFeedL3DataTableName,
            this.coldsFeedL3DataTableSteelGradeIndex,
            this.coldsFeedL3DataTableFeed_Code,
            this.coldsFeedL3DataTableFeed_Weight_Min,
            this.coldsFeedL3DataTableFeed_Weight_Max});
            this.schemadsFeed.TableName = "L3DataTable";
            // 
            // coldsFeedL3DataTableGUID
            // 
            this.coldsFeedL3DataTableGUID.Caption = "GUID";
            this.coldsFeedL3DataTableGUID.ColumnName = "GUID";
            this.coldsFeedL3DataTableGUID.Namespace = "";
            // 
            // coldsFeedL3DataTableName
            // 
            this.coldsFeedL3DataTableName.Caption = "Name";
            this.coldsFeedL3DataTableName.ColumnName = "Name";
            this.coldsFeedL3DataTableName.Namespace = "";
            // 
            // coldsFeedL3DataTableSteelGradeIndex
            // 
            this.coldsFeedL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsFeedL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsFeedL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsFeedL3DataTableFeed_Code
            // 
            this.coldsFeedL3DataTableFeed_Code.Caption = "Feed_Code";
            this.coldsFeedL3DataTableFeed_Code.ColumnName = "Feed_Code";
            this.coldsFeedL3DataTableFeed_Code.Namespace = "";
            // 
            // coldsFeedL3DataTableFeed_Weight_Min
            // 
            this.coldsFeedL3DataTableFeed_Weight_Min.Caption = "Feed_Weight_Min";
            this.coldsFeedL3DataTableFeed_Weight_Min.ColumnName = "Feed_Weight_Min";
            this.coldsFeedL3DataTableFeed_Weight_Min.Namespace = "";
            // 
            // coldsFeedL3DataTableFeed_Weight_Max
            // 
            this.coldsFeedL3DataTableFeed_Weight_Max.Caption = "Feed_Weight_Max";
            this.coldsFeedL3DataTableFeed_Weight_Max.ColumnName = "Feed_Weight_Max";
            this.coldsFeedL3DataTableFeed_Weight_Max.Namespace = "";
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
            // tabInToConver
            // 
            this.tabInToConver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabInToConver.Controls.Add(this.groupBox12);
            this.tabInToConver.Controls.Add(this.groupBox13);
            this.tabInToConver.Controls.Add(this.groupBox14);
            this.tabInToConver.Location = new System.Drawing.Point(4, 21);
            this.tabInToConver.Name = "tabInToConver";
            this.tabInToConver.Size = new System.Drawing.Size(1012, 587);
            this.tabInToConver.TabIndex = 11;
            this.tabInToConver.Text = "入炉信息";
            this.tabInToConver.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label58);
            this.groupBox12.Controls.Add(this.label61);
            this.groupBox12.Controls.Add(this.label62);
            this.groupBox12.Controls.Add(this.label63);
            this.groupBox12.Controls.Add(this.label64);
            this.groupBox12.Controls.Add(this.txtScrapWeightMax);
            this.groupBox12.Controls.Add(this.txtPigIronWeightMax);
            this.groupBox12.Controls.Add(this.txtScrapWeightMin);
            this.groupBox12.Controls.Add(this.txtPigIronWeightMin);
            this.groupBox12.Controls.Add(this.txtTotalWeightMax);
            this.groupBox12.Controls.Add(this.txtTotalWeightMin);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(650, 54);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(360, 531);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "废钢区";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(74, 18);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(65, 12);
            this.label58.TabIndex = 5;
            this.label58.Text = "废钢装入量";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(170, 18);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(65, 12);
            this.label61.TabIndex = 5;
            this.label61.Text = "铁块装入量";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(13, 75);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(35, 12);
            this.label62.TabIndex = 2;
            this.label62.Text = "最小:";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(272, 18);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(53, 12);
            this.label63.TabIndex = 5;
            this.label63.Text = "总装入量";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(13, 44);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(35, 12);
            this.label64.TabIndex = 2;
            this.label64.Text = "最大:";
            // 
            // txtScrapWeightMax
            // 
            this.txtScrapWeightMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Scrap_Weight_Max", true));
            //
            this.txtScrapWeightMax.EnableNull = false;
            this.txtScrapWeightMax.ErropPr = this.errorProvider1;
            //
            this.txtScrapWeightMax.Length = 0;
            this.txtScrapWeightMax.Location = new System.Drawing.Point(65, 41);
            this.txtScrapWeightMax.Max = 99;
            ////
            //
            this.txtScrapWeightMax.MaxStrLength = 0;
            this.txtScrapWeightMax.Min = 0;
            ////
            //
            this.txtScrapWeightMax.MinStrLength = 0;
            this.txtScrapWeightMax.Name = "txtScrapWeightMax";
            this.txtScrapWeightMax.Precision = 0;
            //
            this.txtScrapWeightMax.Size = new System.Drawing.Size(82, 21);
            this.txtScrapWeightMax.TabIndex = 0;
            this.txtScrapWeightMax.ToolTipValid = this.toolTip1;
          //
            this.txtScrapWeightMax.ValidEable = true;
            this.txtScrapWeightMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // bsInToConver
            // 
            this.bsInToConver.DataMember = "L3DataTable";
            this.bsInToConver.DataSource = this.dsInToConver;
            // 
            // dsInToConver
            // 
            this.dsInToConver.AutoLoad = true;
            this.dsInToConver.AutoSubscribe = false;
            this.dsInToConver.DataSetName = "L3DataSet";
            this.dsInToConver.DeleteMethod = null;
            this.dsInToConver.InsertMethod = null;
            this.dsInToConver.L3DataAdapter = this.Adapter;
            this.dsInToConver.LoadEvent = "Click";
            this.dsInToConver.LoadTrigger = null;
            this.dsInToConver.RefreshValve = 1000;
            this.dsInToConver.SourceCommand = null;
            this.dsInToConver.SourceCondition = "1=2";
            this.dsInToConver.SourceMethod = "";
            this.dsInToConver.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInToConver.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_InToConver";
            this.dsInToConver.SubscribeTarget = null;
            this.dsInToConver.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInToConver});
            this.dsInToConver.UpdateEvent = "Click";
            this.dsInToConver.UpdateMethod = null;
            this.dsInToConver.UpdateTrigger = null;
            // 
            // schemadsInToConver
            // 
            this.schemadsInToConver.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInToConverL3DataTableGUID,
            this.coldsInToConverL3DataTableName,
            this.coldsInToConverL3DataTableSteelGradeIndex,
            this.coldsInToConverL3DataTableIron_Temp_Min,
            this.coldsInToConverL3DataTableIron_Temp_Max,
            this.coldsInToConverL3DataTableIron_Weight_Max,
            this.coldsInToConverL3DataTableIron_Weight_Min,
            this.coldsInToConverL3DataTableIron_S_Max,
            this.coldsInToConverL3DataTableIron_S_Min,
            this.coldsInToConverL3DataTableIron_P_Max,
            this.coldsInToConverL3DataTableIron_P_Min,
            this.coldsInToConverL3DataTableIron_Si_Max,
            this.coldsInToConverL3DataTableIron_Si_Min,
            this.coldsInToConverL3DataTableIron_Ti_Min,
            this.coldsInToConverL3DataTableIron_Ti_Max,
            this.coldsInToConverL3DataTableScrap_Type,
            this.coldsInToConverL3DataTableScrap_Weight_Max,
            this.coldsInToConverL3DataTableScrap_Weight_Min,
            this.coldsInToConverL3DataTablePigIron_Weight_Max,
            this.coldsInToConverL3DataTablePigIron_Weight_Min,
            this.coldsInToConverL3DataTableTotal_Weight_Min,
            this.coldsInToConverL3DataTableTotal_Weight_Max});
            this.schemadsInToConver.TableName = "L3DataTable";
            // 
            // coldsInToConverL3DataTableGUID
            // 
            this.coldsInToConverL3DataTableGUID.Caption = "GUID";
            this.coldsInToConverL3DataTableGUID.ColumnName = "GUID";
            this.coldsInToConverL3DataTableGUID.Namespace = "";
            // 
            // coldsInToConverL3DataTableName
            // 
            this.coldsInToConverL3DataTableName.Caption = "Name";
            this.coldsInToConverL3DataTableName.ColumnName = "Name";
            this.coldsInToConverL3DataTableName.Namespace = "";
            // 
            // coldsInToConverL3DataTableSteelGradeIndex
            // 
            this.coldsInToConverL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsInToConverL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsInToConverL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Temp_Min
            // 
            this.coldsInToConverL3DataTableIron_Temp_Min.Caption = "Iron_Temp_Min";
            this.coldsInToConverL3DataTableIron_Temp_Min.ColumnName = "Iron_Temp_Min";
            this.coldsInToConverL3DataTableIron_Temp_Min.DataType = typeof(int);
            this.coldsInToConverL3DataTableIron_Temp_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Temp_Max
            // 
            this.coldsInToConverL3DataTableIron_Temp_Max.Caption = "Iron_Temp_Max";
            this.coldsInToConverL3DataTableIron_Temp_Max.ColumnName = "Iron_Temp_Max";
            this.coldsInToConverL3DataTableIron_Temp_Max.DataType = typeof(int);
            this.coldsInToConverL3DataTableIron_Temp_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Weight_Max
            // 
            this.coldsInToConverL3DataTableIron_Weight_Max.Caption = "Iron_Weight_Max";
            this.coldsInToConverL3DataTableIron_Weight_Max.ColumnName = "Iron_Weight_Max";
            this.coldsInToConverL3DataTableIron_Weight_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Weight_Min
            // 
            this.coldsInToConverL3DataTableIron_Weight_Min.Caption = "Iron_Weight_Min";
            this.coldsInToConverL3DataTableIron_Weight_Min.ColumnName = "Iron_Weight_Min";
            this.coldsInToConverL3DataTableIron_Weight_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_S_Max
            // 
            this.coldsInToConverL3DataTableIron_S_Max.Caption = "Iron_S_Max";
            this.coldsInToConverL3DataTableIron_S_Max.ColumnName = "Iron_S_Max";
            this.coldsInToConverL3DataTableIron_S_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_S_Min
            // 
            this.coldsInToConverL3DataTableIron_S_Min.Caption = "Iron_S_Min";
            this.coldsInToConverL3DataTableIron_S_Min.ColumnName = "Iron_S_Min";
            this.coldsInToConverL3DataTableIron_S_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_P_Max
            // 
            this.coldsInToConverL3DataTableIron_P_Max.Caption = "Iron_P_Max";
            this.coldsInToConverL3DataTableIron_P_Max.ColumnName = "Iron_P_Max";
            this.coldsInToConverL3DataTableIron_P_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_P_Min
            // 
            this.coldsInToConverL3DataTableIron_P_Min.Caption = "Iron_P_Min";
            this.coldsInToConverL3DataTableIron_P_Min.ColumnName = "Iron_P_Min";
            this.coldsInToConverL3DataTableIron_P_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Si_Max
            // 
            this.coldsInToConverL3DataTableIron_Si_Max.Caption = "Iron_Si_Max";
            this.coldsInToConverL3DataTableIron_Si_Max.ColumnName = "Iron_Si_Max";
            this.coldsInToConverL3DataTableIron_Si_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Si_Min
            // 
            this.coldsInToConverL3DataTableIron_Si_Min.Caption = "Iron_Si_Min";
            this.coldsInToConverL3DataTableIron_Si_Min.ColumnName = "Iron_Si_Min";
            this.coldsInToConverL3DataTableIron_Si_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Ti_Min
            // 
            this.coldsInToConverL3DataTableIron_Ti_Min.Caption = "Iron_Ti_Min";
            this.coldsInToConverL3DataTableIron_Ti_Min.ColumnName = "Iron_Ti_Min";
            this.coldsInToConverL3DataTableIron_Ti_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableIron_Ti_Max
            // 
            this.coldsInToConverL3DataTableIron_Ti_Max.Caption = "Iron_Ti_Max";
            this.coldsInToConverL3DataTableIron_Ti_Max.ColumnName = "Iron_Ti_Max";
            this.coldsInToConverL3DataTableIron_Ti_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTableScrap_Type
            // 
            this.coldsInToConverL3DataTableScrap_Type.Caption = "Scrap_Type";
            this.coldsInToConverL3DataTableScrap_Type.ColumnName = "Scrap_Type";
            this.coldsInToConverL3DataTableScrap_Type.Namespace = "";
            // 
            // coldsInToConverL3DataTableScrap_Weight_Max
            // 
            this.coldsInToConverL3DataTableScrap_Weight_Max.Caption = "Scrap_Weight_Max";
            this.coldsInToConverL3DataTableScrap_Weight_Max.ColumnName = "Scrap_Weight_Max";
            this.coldsInToConverL3DataTableScrap_Weight_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTableScrap_Weight_Min
            // 
            this.coldsInToConverL3DataTableScrap_Weight_Min.Caption = "Scrap_Weight_Min";
            this.coldsInToConverL3DataTableScrap_Weight_Min.ColumnName = "Scrap_Weight_Min";
            this.coldsInToConverL3DataTableScrap_Weight_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTablePigIron_Weight_Max
            // 
            this.coldsInToConverL3DataTablePigIron_Weight_Max.Caption = "PigIron_Weight_Max";
            this.coldsInToConverL3DataTablePigIron_Weight_Max.ColumnName = "PigIron_Weight_Max";
            this.coldsInToConverL3DataTablePigIron_Weight_Max.Namespace = "";
            // 
            // coldsInToConverL3DataTablePigIron_Weight_Min
            // 
            this.coldsInToConverL3DataTablePigIron_Weight_Min.Caption = "PigIron_Weight_Min";
            this.coldsInToConverL3DataTablePigIron_Weight_Min.ColumnName = "PigIron_Weight_Min";
            this.coldsInToConverL3DataTablePigIron_Weight_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableTotal_Weight_Min
            // 
            this.coldsInToConverL3DataTableTotal_Weight_Min.Caption = "Total_Weight_Min";
            this.coldsInToConverL3DataTableTotal_Weight_Min.ColumnName = "Total_Weight_Min";
            this.coldsInToConverL3DataTableTotal_Weight_Min.Namespace = "";
            // 
            // coldsInToConverL3DataTableTotal_Weight_Max
            // 
            this.coldsInToConverL3DataTableTotal_Weight_Max.Caption = "Total_Weight_Max";
            this.coldsInToConverL3DataTableTotal_Weight_Max.ColumnName = "Total_Weight_Max";
            this.coldsInToConverL3DataTableTotal_Weight_Max.Namespace = "";
            // 
            // txtPigIronWeightMax
            // 
            this.txtPigIronWeightMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "PigIron_Weight_Max", true));
            //
            this.txtPigIronWeightMax.EnableNull = false;
            this.txtPigIronWeightMax.ErropPr = this.errorProvider1;
            //
            this.txtPigIronWeightMax.Length = 0;
            this.txtPigIronWeightMax.Location = new System.Drawing.Point(161, 42);
            this.txtPigIronWeightMax.Max = 99;
           // //
            //
            this.txtPigIronWeightMax.MaxStrLength = 0;
            this.txtPigIronWeightMax.Min = 0;
            ////
            //
            this.txtPigIronWeightMax.MinStrLength = 0;
            this.txtPigIronWeightMax.Name = "txtPigIronWeightMax";
            this.txtPigIronWeightMax.Precision = 0;
            //
            this.txtPigIronWeightMax.Size = new System.Drawing.Size(82, 21);
            this.txtPigIronWeightMax.TabIndex = 2;
            this.txtPigIronWeightMax.ToolTipValid = this.toolTip1;
          //
            this.txtPigIronWeightMax.ValidEable = true;
            this.txtPigIronWeightMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtScrapWeightMin
            // 
            this.txtScrapWeightMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Scrap_Weight_Min", true));
            //
            this.txtScrapWeightMin.EnableNull = false;
            this.txtScrapWeightMin.ErropPr = this.errorProvider1;
            //
            this.txtScrapWeightMin.Length = 0;
            this.txtScrapWeightMin.Location = new System.Drawing.Point(65, 72);
            this.txtScrapWeightMin.Max = 99;
           // //
            //
            this.txtScrapWeightMin.MaxStrLength = 0;
            this.txtScrapWeightMin.Min = 0;
            ////
            //
            this.txtScrapWeightMin.MinStrLength = 0;
            this.txtScrapWeightMin.Name = "txtScrapWeightMin";
            this.txtScrapWeightMin.Precision = 0;
            //
            this.txtScrapWeightMin.Size = new System.Drawing.Size(82, 21);
            this.txtScrapWeightMin.TabIndex = 1;
            this.txtScrapWeightMin.ToolTipValid = this.toolTip1;
          //
            this.txtScrapWeightMin.ValidEable = true;
            this.txtScrapWeightMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtPigIronWeightMin
            // 
            this.txtPigIronWeightMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "PigIron_Weight_Min", true));
            //
            this.txtPigIronWeightMin.EnableNull = false;
            this.txtPigIronWeightMin.ErropPr = this.errorProvider1;
            //
            this.txtPigIronWeightMin.Length = 0;
            this.txtPigIronWeightMin.Location = new System.Drawing.Point(161, 72);
            this.txtPigIronWeightMin.Max = 99;
            ////
            //
            this.txtPigIronWeightMin.MaxStrLength = 0;
            this.txtPigIronWeightMin.Min = 0;
            ////
            //
            this.txtPigIronWeightMin.MinStrLength = 0;
            this.txtPigIronWeightMin.Name = "txtPigIronWeightMin";
            this.txtPigIronWeightMin.Precision = 0;
            //
            this.txtPigIronWeightMin.Size = new System.Drawing.Size(82, 21);
            this.txtPigIronWeightMin.TabIndex = 3;
            this.txtPigIronWeightMin.ToolTipValid = this.toolTip1;
          //
            this.txtPigIronWeightMin.ValidEable = true;
            this.txtPigIronWeightMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTotalWeightMax
            // 
            this.txtTotalWeightMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Total_Weight_Max", true));
            //
            this.txtTotalWeightMax.EnableNull = false;
            this.txtTotalWeightMax.ErropPr = this.errorProvider1;
            //
            this.txtTotalWeightMax.Length = 0;
            this.txtTotalWeightMax.Location = new System.Drawing.Point(257, 41);
            this.txtTotalWeightMax.Max = 999;
            ////
            //
            this.txtTotalWeightMax.MaxStrLength = 0;
            this.txtTotalWeightMax.Min = 0;
            ////
            //
            this.txtTotalWeightMax.MinStrLength = 0;
            this.txtTotalWeightMax.Name = "txtTotalWeightMax";
            this.txtTotalWeightMax.Precision = 0;
            //
            this.txtTotalWeightMax.Size = new System.Drawing.Size(82, 21);
            this.txtTotalWeightMax.TabIndex = 4;
            this.txtTotalWeightMax.ToolTipValid = this.toolTip1;
          //
            this.txtTotalWeightMax.ValidEable = true;
            this.txtTotalWeightMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTotalWeightMin
            // 
            this.txtTotalWeightMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Total_Weight_Min", true));
            //
            this.txtTotalWeightMin.EnableNull = false;
            this.txtTotalWeightMin.ErropPr = this.errorProvider1;
            //
            this.txtTotalWeightMin.Length = 0;
            this.txtTotalWeightMin.Location = new System.Drawing.Point(257, 72);
            this.txtTotalWeightMin.Max = 999;
            ////
            //
            this.txtTotalWeightMin.MaxStrLength = 0;
            this.txtTotalWeightMin.Min = 0;
            ////
            //
            this.txtTotalWeightMin.MinStrLength = 0;
            this.txtTotalWeightMin.Name = "txtTotalWeightMin";
            this.txtTotalWeightMin.Precision = 0;
            //
            this.txtTotalWeightMin.Size = new System.Drawing.Size(82, 21);
            this.txtTotalWeightMin.TabIndex = 5;
            this.txtTotalWeightMin.ToolTipValid = this.toolTip1;
          //
            this.txtTotalWeightMin.ValidEable = true;
            this.txtTotalWeightMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label65);
            this.groupBox13.Controls.Add(this.label66);
            this.groupBox13.Controls.Add(this.label67);
            this.groupBox13.Controls.Add(this.label68);
            this.groupBox13.Controls.Add(this.label69);
            this.groupBox13.Controls.Add(this.label70);
            this.groupBox13.Controls.Add(this.txtIronTiMax);
            this.groupBox13.Controls.Add(this.txtIronSiMax);
            this.groupBox13.Controls.Add(this.label71);
            this.groupBox13.Controls.Add(this.txtIronPMax);
            this.groupBox13.Controls.Add(this.txtIronTiMin);
            this.groupBox13.Controls.Add(this.label72);
            this.groupBox13.Controls.Add(this.txtIronSiMin);
            this.groupBox13.Controls.Add(this.txtIronSMax);
            this.groupBox13.Controls.Add(this.txtIronPMin);
            this.groupBox13.Controls.Add(this.txtIronTempMin);
            this.groupBox13.Controls.Add(this.txtIronSMin);
            this.groupBox13.Controls.Add(this.txtIronWeightMax);
            this.groupBox13.Controls.Add(this.txtIronWeightMin);
            this.groupBox13.Controls.Add(this.txtIronTempMax);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox13.Location = new System.Drawing.Point(0, 54);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(650, 531);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "铁水区";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(556, 17);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(65, 12);
            this.label65.TabIndex = 5;
            this.label65.Text = "铁水Ti含量";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(460, 17);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(65, 12);
            this.label66.TabIndex = 4;
            this.label66.Text = "铁水Si含量";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(22, 75);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(35, 12);
            this.label67.TabIndex = 2;
            this.label67.Text = "最小:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(22, 44);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(35, 12);
            this.label68.TabIndex = 2;
            this.label68.Text = "最大:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(81, 17);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(53, 12);
            this.label69.TabIndex = 2;
            this.label69.Text = "铁水温度";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(367, 17);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(59, 12);
            this.label70.TabIndex = 2;
            this.label70.Text = "铁水P含量";
            // 
            // txtIronTiMax
            // 
            this.txtIronTiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Ti_Max", true));
            //
            this.txtIronTiMax.EnableNull = false;
            this.txtIronTiMax.ErropPr = this.errorProvider1;
            //
            this.txtIronTiMax.Length = 0;
            this.txtIronTiMax.Location = new System.Drawing.Point(547, 41);
            this.txtIronTiMax.Max = 99;
           // //
            //
            this.txtIronTiMax.MaxStrLength = 0;
            this.txtIronTiMax.Min = 0;
            ////
            //
            this.txtIronTiMax.MinStrLength = 0;
            this.txtIronTiMax.Name = "txtIronTiMax";
            this.txtIronTiMax.Precision = 0;
            //
            this.txtIronTiMax.Size = new System.Drawing.Size(82, 21);
            this.txtIronTiMax.TabIndex = 8;
            this.txtIronTiMax.ToolTipValid = this.toolTip1;
          //
            this.txtIronTiMax.ValidEable = true;
            this.txtIronTiMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronSiMax
            // 
            this.txtIronSiMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Si_Max", true));
            //
            this.txtIronSiMax.EnableNull = false;
            this.txtIronSiMax.ErropPr = this.errorProvider1;
            //
            this.txtIronSiMax.Length = 0;
            this.txtIronSiMax.Location = new System.Drawing.Point(451, 41);
            this.txtIronSiMax.Max = 99;
            ////
            //
            this.txtIronSiMax.MaxStrLength = 0;
            this.txtIronSiMax.Min = 0;
            ////
            //
            this.txtIronSiMax.MinStrLength = 0;
            this.txtIronSiMax.Name = "txtIronSiMax";
            this.txtIronSiMax.Precision = 0;
            //
            this.txtIronSiMax.Size = new System.Drawing.Size(82, 21);
            this.txtIronSiMax.TabIndex = 3;
            this.txtIronSiMax.ToolTipValid = this.toolTip1;
          //
            this.txtIronSiMax.ValidEable = true;
            this.txtIronSiMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(268, 17);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(65, 12);
            this.label71.TabIndex = 2;
            this.label71.Text = "铁水硫含量";
            // 
            // txtIronPMax
            // 
            this.txtIronPMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_P_Max", true));
            //
            this.txtIronPMax.EnableNull = false;
            this.txtIronPMax.ErropPr = this.errorProvider1;
            //
            this.txtIronPMax.Length = 0;
            this.txtIronPMax.Location = new System.Drawing.Point(355, 41);
            this.txtIronPMax.Max = 99;
            ////
            //
            this.txtIronPMax.MaxStrLength = 0;
            this.txtIronPMax.Min = 0;
           // //
            //
            this.txtIronPMax.MinStrLength = 0;
            this.txtIronPMax.Name = "txtIronPMax";
            this.txtIronPMax.Precision = 0;
            //
            this.txtIronPMax.Size = new System.Drawing.Size(82, 21);
            this.txtIronPMax.TabIndex = 6;
            this.txtIronPMax.ToolTipValid = this.toolTip1;
          //
            this.txtIronPMax.ValidEable = true;
            this.txtIronPMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronTiMin
            // 
            this.txtIronTiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Ti_Min", true));
            //
            this.txtIronTiMin.EnableNull = false;
            this.txtIronTiMin.ErropPr = this.errorProvider1;
            //
            this.txtIronTiMin.Length = 0;
            this.txtIronTiMin.Location = new System.Drawing.Point(547, 72);
            this.txtIronTiMin.Max = 99;
           // //
            //
            this.txtIronTiMin.MaxStrLength = 0;
            this.txtIronTiMin.Min = 0;
           // //
            //
            this.txtIronTiMin.MinStrLength = 0;
            this.txtIronTiMin.Name = "txtIronTiMin";
            this.txtIronTiMin.Precision = 0;
            //
            this.txtIronTiMin.Size = new System.Drawing.Size(82, 21);
            this.txtIronTiMin.TabIndex = 9;
            this.txtIronTiMin.ToolTipValid = this.toolTip1;
          //
            this.txtIronTiMin.ValidEable = true;
            this.txtIronTiMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(172, 18);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(65, 12);
            this.label72.TabIndex = 2;
            this.label72.Text = "铁水装入量";
            // 
            // txtIronSiMin
            // 
            this.txtIronSiMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Si_Min", true));
            //
            this.txtIronSiMin.EnableNull = false;
            this.txtIronSiMin.ErropPr = this.errorProvider1;
            //
            this.txtIronSiMin.Length = 0;
            this.txtIronSiMin.Location = new System.Drawing.Point(451, 72);
            this.txtIronSiMin.Max = 99;
           // //
            //
            this.txtIronSiMin.MaxStrLength = 0;
            this.txtIronSiMin.Min = 0;
           // //
            //
            this.txtIronSiMin.MinStrLength = 0;
            this.txtIronSiMin.Name = "txtIronSiMin";
            this.txtIronSiMin.Precision = 0;
            //
            this.txtIronSiMin.Size = new System.Drawing.Size(82, 21);
            this.txtIronSiMin.TabIndex = 3;
            this.txtIronSiMin.ToolTipValid = this.toolTip1;
          //
            this.txtIronSiMin.ValidEable = true;
            this.txtIronSiMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronSMax
            // 
            this.txtIronSMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_S_Max", true));
            //
            this.txtIronSMax.EnableNull = false;
            this.txtIronSMax.ErropPr = this.errorProvider1;
            //
            this.txtIronSMax.Length = 0;
            this.txtIronSMax.Location = new System.Drawing.Point(259, 41);
            this.txtIronSMax.Max = 99;
           // //
            //
            this.txtIronSMax.MaxStrLength = 0;
            this.txtIronSMax.Min = 0;
          //  //
            //
            this.txtIronSMax.MinStrLength = 0;
            this.txtIronSMax.Name = "txtIronSMax";
            this.txtIronSMax.Precision = 0;
            //
            this.txtIronSMax.Size = new System.Drawing.Size(82, 21);
            this.txtIronSMax.TabIndex = 4;
            this.txtIronSMax.ToolTipValid = this.toolTip1;
          //
            this.txtIronSMax.ValidEable = true;
            this.txtIronSMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronPMin
            // 
            this.txtIronPMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_P_Min", true));
            //
            this.txtIronPMin.EnableNull = false;
            this.txtIronPMin.ErropPr = this.errorProvider1;
            //
            this.txtIronPMin.Length = 0;
            this.txtIronPMin.Location = new System.Drawing.Point(355, 72);
            this.txtIronPMin.Max = 99;
           // //
            //
            this.txtIronPMin.MaxStrLength = 0;
            this.txtIronPMin.Min = 0;
           // //
            //
            this.txtIronPMin.MinStrLength = 0;
            this.txtIronPMin.Name = "txtIronPMin";
            this.txtIronPMin.Precision = 0;
            //
            this.txtIronPMin.Size = new System.Drawing.Size(82, 21);
            this.txtIronPMin.TabIndex = 7;
            this.txtIronPMin.ToolTipValid = this.toolTip1;
          //
            this.txtIronPMin.ValidEable = true;
            this.txtIronPMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronTempMin
            // 
            this.txtIronTempMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Temp_Max", true));
            //
            this.txtIronTempMin.EnableNull = false;
            this.txtIronTempMin.ErropPr = this.errorProvider1;
            //
            this.txtIronTempMin.Length = 0;
            this.txtIronTempMin.Location = new System.Drawing.Point(66, 72);
            this.txtIronTempMin.Max = 2000;
          //  //
            //
            this.txtIronTempMin.MaxStrLength = 0;
            this.txtIronTempMin.Min = 0;
         //   //
            //
            this.txtIronTempMin.MinStrLength = 0;
            this.txtIronTempMin.Name = "txtIronTempMin";
            this.txtIronTempMin.Precision = 0;
            //
            this.txtIronTempMin.Size = new System.Drawing.Size(82, 21);
            this.txtIronTempMin.TabIndex = 1;
            this.txtIronTempMin.ToolTipValid = this.toolTip1;
          //
            this.txtIronTempMin.ValidEable = true;
            this.txtIronTempMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronSMin
            // 
            this.txtIronSMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_S_Min", true));
            //
            this.txtIronSMin.EnableNull = false;
            this.txtIronSMin.ErropPr = this.errorProvider1;
            //
            this.txtIronSMin.Length = 0;
            this.txtIronSMin.Location = new System.Drawing.Point(259, 72);
            this.txtIronSMin.Max = 99;
           // //
            //
            this.txtIronSMin.MaxStrLength = 0;
            this.txtIronSMin.Min = 0;
          //  //
            //
            this.txtIronSMin.MinStrLength = 0;
            this.txtIronSMin.Name = "txtIronSMin";
            this.txtIronSMin.Precision = 0;
            //
            this.txtIronSMin.Size = new System.Drawing.Size(82, 21);
            this.txtIronSMin.TabIndex = 5;
            this.txtIronSMin.ToolTipValid = this.toolTip1;
          //
            this.txtIronSMin.ValidEable = true;
            this.txtIronSMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronWeightMax
            // 
            this.txtIronWeightMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Weight_Max", true));
            //
            this.txtIronWeightMax.EnableNull = false;
            this.txtIronWeightMax.ErropPr = this.errorProvider1;
            //
            this.txtIronWeightMax.Length = 0;
            this.txtIronWeightMax.Location = new System.Drawing.Point(163, 42);
            this.txtIronWeightMax.Max = 99;
           // //
            //
            this.txtIronWeightMax.MaxStrLength = 0;
            this.txtIronWeightMax.Min = 0;
          //  //
            //
            this.txtIronWeightMax.MinStrLength = 0;
            this.txtIronWeightMax.Name = "txtIronWeightMax";
            this.txtIronWeightMax.Precision = 0;
            //
            this.txtIronWeightMax.Size = new System.Drawing.Size(82, 21);
            this.txtIronWeightMax.TabIndex = 2;
            this.txtIronWeightMax.ToolTipValid = this.toolTip1;
          //
            this.txtIronWeightMax.ValidEable = true;
            this.txtIronWeightMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronWeightMin
            // 
            this.txtIronWeightMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Weight_Min", true));
            //
            this.txtIronWeightMin.EnableNull = false;
            this.txtIronWeightMin.ErropPr = this.errorProvider1;
            //
            this.txtIronWeightMin.Length = 0;
            this.txtIronWeightMin.Location = new System.Drawing.Point(163, 73);
            this.txtIronWeightMin.Max = 99;
            ////
            //
            this.txtIronWeightMin.MaxStrLength = 0;
            this.txtIronWeightMin.Min = 0;
           // //
            //
            this.txtIronWeightMin.MinStrLength = 0;
            this.txtIronWeightMin.Name = "txtIronWeightMin";
            this.txtIronWeightMin.Precision = 0;
            //
            this.txtIronWeightMin.Size = new System.Drawing.Size(82, 21);
            this.txtIronWeightMin.TabIndex = 3;
            this.txtIronWeightMin.ToolTipValid = this.toolTip1;
          //
            this.txtIronWeightMin.ValidEable = true;
            this.txtIronWeightMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtIronTempMax
            // 
            this.txtIronTempMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Iron_Temp_Min", true));
            //
            this.txtIronTempMax.EnableNull = false;
            this.txtIronTempMax.ErropPr = this.errorProvider1;
            //
            this.txtIronTempMax.Length = 0;
            this.txtIronTempMax.Location = new System.Drawing.Point(66, 41);
            this.txtIronTempMax.Max = 2000;
            ////
            //
            this.txtIronTempMax.MaxStrLength = 0;
            this.txtIronTempMax.Min = 0;
         //   //
            //
            this.txtIronTempMax.MinStrLength = 0;
            this.txtIronTempMax.Name = "txtIronTempMax";
            this.txtIronTempMax.Precision = 0;
            //
            this.txtIronTempMax.Size = new System.Drawing.Size(82, 21);
            this.txtIronTempMax.TabIndex = 0;
            this.txtIronTempMax.ToolTipValid = this.toolTip1;
          //
            this.txtIronTempMax.ValidEable = true;
            this.txtIronTempMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cmbScrapType);
            this.groupBox14.Controls.Add(this.label73);
            this.groupBox14.Controls.Add(this.txtSteelGradeIndexInToConver);
            this.groupBox14.Controls.Add(this.label74);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox14.Location = new System.Drawing.Point(0, 0);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1010, 54);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            // 
            // cmbScrapType
            // 
            this.cmbScrapType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbScrapType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbScrapType.BackColor = System.Drawing.SystemColors.Window;
            this.cmbScrapType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "Scrap_Type", true));
            this.cmbScrapType.EnableNull = true;
            this.cmbScrapType.ErropPr = null;
            this.cmbScrapType.FormattingEnabled = true;
            this.cmbScrapType.Location = new System.Drawing.Point(394, 17);
            this.cmbScrapType.Name = "cmbScrapType";
            //
            this.cmbScrapType.Size = new System.Drawing.Size(121, 20);
            this.cmbScrapType.TabIndex = 1;
            //
            this.cmbScrapType.ToolTipValid = null;
            this.cmbScrapType.ValidEable = false;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(322, 21);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(59, 12);
            this.label73.TabIndex = 19;
            this.label73.Text = "废钢区分:";
            // 
            // txtSteelGradeIndexInToConver
            // 
            this.txtSteelGradeIndexInToConver.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInToConver, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexInToConver.EnableNull = false;
            this.txtSteelGradeIndexInToConver.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexInToConver.Length = 8;
            this.txtSteelGradeIndexInToConver.Location = new System.Drawing.Point(94, 17);
            this.txtSteelGradeIndexInToConver.Max = 0;
            this.txtSteelGradeIndexInToConver.MaxLength = 8;
            ////
            //
            this.txtSteelGradeIndexInToConver.MaxStrLength = 0;
            this.txtSteelGradeIndexInToConver.Min = 0;
         //   //
            //
            this.txtSteelGradeIndexInToConver.MinStrLength = 0;
            this.txtSteelGradeIndexInToConver.Name = "txtSteelGradeIndexInToConver";
            this.txtSteelGradeIndexInToConver.Precision = 0;
            this.txtSteelGradeIndexInToConver.ReadOnly = true;
            //
            this.txtSteelGradeIndexInToConver.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexInToConver.TabIndex = 0;
            this.txtSteelGradeIndexInToConver.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexInToConver.ValidEable = true;
            this.txtSteelGradeIndexInToConver.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(22, 21);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(59, 12);
            this.label74.TabIndex = 14;
            this.label74.Text = "炼钢记号:";
            // 
            // tabLadle
            // 
            this.tabLadle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLadle.Controls.Add(this.hmiRootPanelLadle);
            this.tabLadle.Location = new System.Drawing.Point(4, 21);
            this.tabLadle.Name = "tabLadle";
            this.tabLadle.Size = new System.Drawing.Size(1012, 587);
            this.tabLadle.TabIndex = 7;
            this.tabLadle.Text = "钢包物料信息";
            this.tabLadle.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanelLadle
            // 
            this.hmiRootPanelLadle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanelLadle.Controls.Add(this.dvLadle);
            this.hmiRootPanelLadle.Controls.Add(this.bindingNavigator1);
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
            this.steelGradeIndexDataGridViewTextBoxColumn2,
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
            this.dvLadle.TabIndex = 3;
            this.dvLadle.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dv_DataBindingComplete);
            this.dvLadle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBulk_DataError);
            // 
            // steelGradeIndexDataGridViewTextBoxColumn2
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn2.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn2.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn2.Name = "steelGradeIndexDataGridViewTextBoxColumn2";
            this.steelGradeIndexDataGridViewTextBoxColumn2.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn2.Width = 78;
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
            this.dsLadle.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Ladle";
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
            this.coldsLadleL3DataTableGUID,
            this.coldsLadleL3DataTableName,
            this.coldsLadleL3DataTableSteelGradeIndex,
            this.coldsLadleL3DataTableLadle_Mat_Name,
            this.coldsLadleL3DataTableLadle_Mat_Min,
            this.coldsLadleL3DataTableLadle_Mat_Max,
            this.coldsLadleL3DataTableLadle_Mat_Aim});
            this.schemadsLadle.TableName = "L3DataTable";
            // 
            // coldsLadleL3DataTableGUID
            // 
            this.coldsLadleL3DataTableGUID.Caption = "GUID";
            this.coldsLadleL3DataTableGUID.ColumnName = "GUID";
            this.coldsLadleL3DataTableGUID.Namespace = "";
            // 
            // coldsLadleL3DataTableName
            // 
            this.coldsLadleL3DataTableName.Caption = "Name";
            this.coldsLadleL3DataTableName.ColumnName = "Name";
            this.coldsLadleL3DataTableName.Namespace = "";
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
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsLadle;
            this.bindingNavigator1.CountItem = this.toolStripLabel3;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator5,
            this.btnAddLadle,
            this.btnDelLadle});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1006, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator2";
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
            this.groupBox17.Controls.Add(this.label79);
            this.groupBox17.Controls.Add(this.label83);
            this.groupBox17.Controls.Add(this.txtTFeMax);
            this.groupBox17.Controls.Add(this.label102);
            this.groupBox17.Controls.Add(this.txtMgOMax);
            this.groupBox17.Controls.Add(this.txtTFeMin);
            this.groupBox17.Controls.Add(this.txtCaOMin);
            this.groupBox17.Controls.Add(this.txtMgOMin);
            this.groupBox17.Controls.Add(this.txtSiO2Max);
            this.groupBox17.Controls.Add(this.txtSiO2Min);
            this.groupBox17.Controls.Add(this.txtCaOMax);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox17.Location = new System.Drawing.Point(0, 54);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1010, 98);
            this.groupBox17.TabIndex = 1;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "转炉炉渣";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(57, 75);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 12);
            this.label39.TabIndex = 2;
            this.label39.Text = "最小:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(57, 44);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 12);
            this.label40.TabIndex = 2;
            this.label40.Text = "最大:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(137, 22);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(23, 12);
            this.label77.TabIndex = 2;
            this.label77.Text = "CaO";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(503, 21);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(23, 12);
            this.label79.TabIndex = 2;
            this.label79.Text = "TFe";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(381, 22);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(23, 12);
            this.label83.TabIndex = 2;
            this.label83.Text = "MgO";
            // 
            // txtTFeMax
            // 
            this.txtTFeMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "TFe_Max", true));
            //
            this.txtTFeMax.EnableNull = false;
            this.txtTFeMax.ErropPr = this.errorProvider1;
            //
            this.txtTFeMax.Length = 0;
            this.txtTFeMax.Location = new System.Drawing.Point(464, 41);
            this.txtTFeMax.Max = 999;
            ////
            //
            this.txtTFeMax.MaxStrLength = 0;
            this.txtTFeMax.Min = 0;
            ////
            //
            this.txtTFeMax.MinStrLength = 0;
            this.txtTFeMax.Name = "txtTFeMax";
            this.txtTFeMax.Precision = 0;
            //
            this.txtTFeMax.Size = new System.Drawing.Size(100, 21);
            this.txtTFeMax.TabIndex = 6;
            this.txtTFeMax.ToolTipValid = this.toolTip1;
          //
            this.txtTFeMax.ValidEable = true;
            this.txtTFeMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // bsSlagEle
            // 
            this.bsSlagEle.DataMember = "L3DataTable";
            this.bsSlagEle.DataSource = this.dsSlagEle;
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
            this.dsSlagEle.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Slag_Ele";
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
            this.coldsSlagEleL3DataTableTFe_Max,
            this.coldsSlagEleL3DataTableTFe_Min});
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
            // coldsSlagEleL3DataTableTFe_Max
            // 
            this.coldsSlagEleL3DataTableTFe_Max.Caption = "TFe_Max";
            this.coldsSlagEleL3DataTableTFe_Max.ColumnName = "TFe_Max";
            this.coldsSlagEleL3DataTableTFe_Max.Namespace = "";
            // 
            // coldsSlagEleL3DataTableTFe_Min
            // 
            this.coldsSlagEleL3DataTableTFe_Min.Caption = "TFe_Min";
            this.coldsSlagEleL3DataTableTFe_Min.ColumnName = "TFe_Min";
            this.coldsSlagEleL3DataTableTFe_Min.Namespace = "";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(256, 22);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(29, 12);
            this.label102.TabIndex = 2;
            this.label102.Text = "SiO2";
            // 
            // txtMgOMax
            // 
            this.txtMgOMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "MgO_Max", true));
            //
            this.txtMgOMax.EnableNull = false;
            this.txtMgOMax.ErropPr = this.errorProvider1;
            //
            this.txtMgOMax.Length = 0;
            this.txtMgOMax.Location = new System.Drawing.Point(342, 41);
            this.txtMgOMax.Max = 999;
           // //
            //
            this.txtMgOMax.MaxStrLength = 0;
            this.txtMgOMax.Min = 0;
          //  //
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
            // txtTFeMin
            // 
            this.txtTFeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "TFe_Min", true));
            //
            this.txtTFeMin.EnableNull = false;
            this.txtTFeMin.ErropPr = this.errorProvider1;
            //
            this.txtTFeMin.Length = 0;
            this.txtTFeMin.Location = new System.Drawing.Point(464, 72);
            this.txtTFeMin.Max = 999;
           // //
            //
            this.txtTFeMin.MaxStrLength = 0;
            this.txtTFeMin.Min = 0;
        //    //
            //
            this.txtTFeMin.MinStrLength = 0;
            this.txtTFeMin.Name = "txtTFeMin";
            this.txtTFeMin.Precision = 0;
            //
            this.txtTFeMin.Size = new System.Drawing.Size(100, 21);
            this.txtTFeMin.TabIndex = 7;
            this.txtTFeMin.ToolTipValid = this.toolTip1;
          //
            this.txtTFeMin.ValidEable = true;
            this.txtTFeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtCaOMin
            // 
            this.txtCaOMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSlagEle, "CaO_Min", true));
            //
            this.txtCaOMin.EnableNull = false;
            this.txtCaOMin.ErropPr = this.errorProvider1;
            //
            this.txtCaOMin.Length = 0;
            this.txtCaOMin.Location = new System.Drawing.Point(98, 72);
            this.txtCaOMin.Max = 999;
           // //
            //
            this.txtCaOMin.MaxStrLength = 0;
            this.txtCaOMin.Min = 0;
         //   //
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
            this.txtMgOMin.EnableNull = false;
            this.txtMgOMin.ErropPr = this.errorProvider1;
            //
            this.txtMgOMin.Length = 0;
            this.txtMgOMin.Location = new System.Drawing.Point(342, 72);
            this.txtMgOMin.Max = 999;
           // //
            //
            this.txtMgOMin.MaxStrLength = 0;
            this.txtMgOMin.Min = 0;
          //  //
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
            this.txtSiO2Max.EnableNull = false;
            this.txtSiO2Max.ErropPr = this.errorProvider1;
            //
            this.txtSiO2Max.Length = 0;
            this.txtSiO2Max.Location = new System.Drawing.Point(220, 41);
            this.txtSiO2Max.Max = 999;
          //  //
            //
            this.txtSiO2Max.MaxStrLength = 0;
            this.txtSiO2Max.Min = 0;
          //  //
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
            this.txtSiO2Min.EnableNull = false;
            this.txtSiO2Min.ErropPr = this.errorProvider1;
            //
            this.txtSiO2Min.Length = 0;
            this.txtSiO2Min.Location = new System.Drawing.Point(220, 72);
            this.txtSiO2Min.Max = 999;
          //  //
            //
            this.txtSiO2Min.MaxStrLength = 0;
            this.txtSiO2Min.Min = 0;
           // //
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
            this.txtCaOMax.EnableNull = false;
            this.txtCaOMax.ErropPr = this.errorProvider1;
            //
            this.txtCaOMax.Length = 0;
            this.txtCaOMax.Location = new System.Drawing.Point(98, 41);
            this.txtCaOMax.Max = 999;
           // //
            //
            this.txtCaOMax.MaxStrLength = 0;
            this.txtCaOMax.Min = 0;
          //  //
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
            this.txtSteelGradeIndexSlagEle.Length = 8;
            this.txtSteelGradeIndexSlagEle.Location = new System.Drawing.Point(98, 17);
            this.txtSteelGradeIndexSlagEle.Max = 0;
            this.txtSteelGradeIndexSlagEle.MaxLength = 8;
           // //
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
            // tabTap
            // 
            this.tabTap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTap.Controls.Add(this.groupBox18);
            this.tabTap.Controls.Add(this.groupBox9);
            this.tabTap.Location = new System.Drawing.Point(4, 21);
            this.tabTap.Name = "tabTap";
            this.tabTap.Size = new System.Drawing.Size(1012, 587);
            this.tabTap.TabIndex = 9;
            this.tabTap.Text = "出钢信息";
            this.tabTap.UseVisualStyleBackColor = true;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.label59);
            this.groupBox18.Controls.Add(this.label60);
            this.groupBox18.Controls.Add(this.label105);
            this.groupBox18.Controls.Add(this.label31);
            this.groupBox18.Controls.Add(this.label33);
            this.groupBox18.Controls.Add(this.label32);
            this.groupBox18.Controls.Add(this.label116);
            this.groupBox18.Controls.Add(this.label106);
            this.groupBox18.Controls.Add(this.label107);
            this.groupBox18.Controls.Add(this.label108);
            this.groupBox18.Controls.Add(this.txtTapArBlowMin);
            this.groupBox18.Controls.Add(this.txtTapArPressMin);
            this.groupBox18.Controls.Add(this.label113);
            this.groupBox18.Controls.Add(this.txtEndPUpLimit);
            this.groupBox18.Controls.Add(this.txtTapArBlowMax);
            this.groupBox18.Controls.Add(this.label114);
            this.groupBox18.Controls.Add(this.txtTapArPressMax);
            this.groupBox18.Controls.Add(this.txtEndCUpLimit);
            this.groupBox18.Controls.Add(this.txtEndMnUpLimit);
            this.groupBox18.Controls.Add(this.txtTappingTimeMin);
            this.groupBox18.Controls.Add(this.txtEndCLowLimit);
            this.groupBox18.Controls.Add(this.txtEndO2UpLimit);
            this.groupBox18.Controls.Add(this.txtEndSUpLimit);
            this.groupBox18.Controls.Add(this.txtTappingTempMin);
            this.groupBox18.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox18.Location = new System.Drawing.Point(0, 54);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(1010, 133);
            this.groupBox18.TabIndex = 1;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "转炉炉渣";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(240, 60);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(89, 12);
            this.label59.TabIndex = 2;
            this.label59.Text = "终点成份C下限:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(19, 60);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(83, 12);
            this.label60.TabIndex = 2;
            this.label60.Text = "出钢时间最小:";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(19, 35);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(83, 12);
            this.label105.TabIndex = 2;
            this.label105.Text = "出钢温度最小:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(457, 110);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 12);
            this.label31.TabIndex = 2;
            this.label31.Text = "出钢过程吹氩气量最大:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(457, 85);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(131, 12);
            this.label33.TabIndex = 2;
            this.label33.Text = "出钢过程吹氩气量最小:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(457, 35);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(131, 12);
            this.label32.TabIndex = 2;
            this.label32.Text = "出钢过程吹氩压力最小:";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(457, 60);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(131, 12);
            this.label116.TabIndex = 2;
            this.label116.Text = "出钢过程吹氩压力最大:";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(234, 110);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(95, 12);
            this.label106.TabIndex = 2;
            this.label106.Text = "终点成份Mn上限:";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(240, 85);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(89, 12);
            this.label107.TabIndex = 2;
            this.label107.Text = "终点成份P上限:";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(13, 110);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(89, 12);
            this.label108.TabIndex = 2;
            this.label108.Text = "终点成份S上限:";
            // 
            // txtTapArBlowMin
            // 
            this.txtTapArBlowMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "Ar_Blow_Min", true));
            //
            this.txtTapArBlowMin.EnableNull = false;
            this.txtTapArBlowMin.ErropPr = this.errorProvider1;
            //
            this.txtTapArBlowMin.Length = 0;
            this.txtTapArBlowMin.Location = new System.Drawing.Point(594, 81);
            this.txtTapArBlowMin.Max = 99999;
           // //
            //
            this.txtTapArBlowMin.MaxStrLength = 0;
            this.txtTapArBlowMin.Min = 0;
           // //
            //
            this.txtTapArBlowMin.MinStrLength = 0;
            this.txtTapArBlowMin.Name = "txtTapArBlowMin";
            this.txtTapArBlowMin.Precision = 0;
            //
            this.txtTapArBlowMin.Size = new System.Drawing.Size(100, 21);
            this.txtTapArBlowMin.TabIndex = 10;
            this.txtTapArBlowMin.ToolTipValid = this.toolTip1;
          //
            this.txtTapArBlowMin.ValidEable = true;
            this.txtTapArBlowMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // bsTap
            // 
            this.bsTap.DataMember = "L3DataTable";
            this.bsTap.DataSource = this.dsTap;
            // 
            // dsTap
            // 
            this.dsTap.AutoLoad = true;
            this.dsTap.AutoSubscribe = false;
            this.dsTap.DataSetName = "L3DataSet";
            this.dsTap.DeleteMethod = null;
            this.dsTap.InsertMethod = null;
            this.dsTap.L3DataAdapter = this.Adapter;
            this.dsTap.LoadEvent = "Click";
            this.dsTap.LoadTrigger = null;
            this.dsTap.RefreshValve = 1000;
            this.dsTap.SourceCommand = null;
            this.dsTap.SourceCondition = "1=2";
            this.dsTap.SourceMethod = "";
            this.dsTap.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTap.SourceURI = "XGMESLogic\\QualityMag\\CQA_BOF_Std_Tapping";
            this.dsTap.SubscribeTarget = null;
            this.dsTap.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTap});
            this.dsTap.UpdateEvent = "Click";
            this.dsTap.UpdateMethod = null;
            this.dsTap.UpdateTrigger = null;
            // 
            // schemadsTap
            // 
            this.schemadsTap.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTapL3DataTableGUID,
            this.coldsTapL3DataTableName,
            this.coldsTapL3DataTableSteelGradeIndex,
            this.coldsTapL3DataTableTapping_Temp_Min,
            this.coldsTapL3DataTableTapping_Time_Min,
            this.coldsTapL3DataTableEnd_O2_UpLimit,
            this.coldsTapL3DataTableEnd_C_UpLimit,
            this.coldsTapL3DataTableEnd_C_LowLimit,
            this.coldsTapL3DataTableEnd_S_UpLimit,
            this.coldsTapL3DataTableEnd_P_UpLimit,
            this.coldsTapL3DataTableEnd_Mn_UpLimit,
            this.coldsTapL3DataTableAr_Press_Max,
            this.coldsTapL3DataTableAr_Press_Min,
            this.coldsTapL3DataTableAr_Blow_Max,
            this.coldsTapL3DataTableAr_Blow_Min});
            this.schemadsTap.TableName = "L3DataTable";
            // 
            // coldsTapL3DataTableGUID
            // 
            this.coldsTapL3DataTableGUID.Caption = "GUID";
            this.coldsTapL3DataTableGUID.ColumnName = "GUID";
            this.coldsTapL3DataTableGUID.Namespace = "";
            // 
            // coldsTapL3DataTableName
            // 
            this.coldsTapL3DataTableName.Caption = "Name";
            this.coldsTapL3DataTableName.ColumnName = "Name";
            this.coldsTapL3DataTableName.Namespace = "";
            // 
            // coldsTapL3DataTableSteelGradeIndex
            // 
            this.coldsTapL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsTapL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsTapL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsTapL3DataTableTapping_Temp_Min
            // 
            this.coldsTapL3DataTableTapping_Temp_Min.Caption = "Tapping_Temp_Min";
            this.coldsTapL3DataTableTapping_Temp_Min.ColumnName = "Tapping_Temp_Min";
            this.coldsTapL3DataTableTapping_Temp_Min.DataType = typeof(int);
            this.coldsTapL3DataTableTapping_Temp_Min.Namespace = "";
            // 
            // coldsTapL3DataTableTapping_Time_Min
            // 
            this.coldsTapL3DataTableTapping_Time_Min.Caption = "Tapping_Time_Min";
            this.coldsTapL3DataTableTapping_Time_Min.ColumnName = "Tapping_Time_Min";
            this.coldsTapL3DataTableTapping_Time_Min.DataType = typeof(int);
            this.coldsTapL3DataTableTapping_Time_Min.Namespace = "";
            // 
            // coldsTapL3DataTableEnd_O2_UpLimit
            // 
            this.coldsTapL3DataTableEnd_O2_UpLimit.Caption = "End_O2_UpLimit";
            this.coldsTapL3DataTableEnd_O2_UpLimit.ColumnName = "End_O2_UpLimit";
            this.coldsTapL3DataTableEnd_O2_UpLimit.Namespace = "";
            // 
            // coldsTapL3DataTableEnd_C_UpLimit
            // 
            this.coldsTapL3DataTableEnd_C_UpLimit.Caption = "End_C_UpLimit";
            this.coldsTapL3DataTableEnd_C_UpLimit.ColumnName = "End_C_UpLimit";
            this.coldsTapL3DataTableEnd_C_UpLimit.Namespace = "";
            // 
            // coldsTapL3DataTableEnd_C_LowLimit
            // 
            this.coldsTapL3DataTableEnd_C_LowLimit.Caption = "End_C_LowLimit";
            this.coldsTapL3DataTableEnd_C_LowLimit.ColumnName = "End_C_LowLimit";
            this.coldsTapL3DataTableEnd_C_LowLimit.Namespace = "";
            // 
            // coldsTapL3DataTableEnd_S_UpLimit
            // 
            this.coldsTapL3DataTableEnd_S_UpLimit.Caption = "End_S_UpLimit";
            this.coldsTapL3DataTableEnd_S_UpLimit.ColumnName = "End_S_UpLimit";
            this.coldsTapL3DataTableEnd_S_UpLimit.Namespace = "";
            // 
            // coldsTapL3DataTableEnd_P_UpLimit
            // 
            this.coldsTapL3DataTableEnd_P_UpLimit.Caption = "End_P_UpLimit";
            this.coldsTapL3DataTableEnd_P_UpLimit.ColumnName = "End_P_UpLimit";
            this.coldsTapL3DataTableEnd_P_UpLimit.Namespace = "";
            // 
            // coldsTapL3DataTableEnd_Mn_UpLimit
            // 
            this.coldsTapL3DataTableEnd_Mn_UpLimit.Caption = "End_Mn_UpLimit";
            this.coldsTapL3DataTableEnd_Mn_UpLimit.ColumnName = "End_Mn_UpLimit";
            this.coldsTapL3DataTableEnd_Mn_UpLimit.Namespace = "";
            // 
            // coldsTapL3DataTableAr_Press_Max
            // 
            this.coldsTapL3DataTableAr_Press_Max.Caption = "Ar_Press_Max";
            this.coldsTapL3DataTableAr_Press_Max.ColumnName = "Ar_Press_Max";
            this.coldsTapL3DataTableAr_Press_Max.DataType = typeof(int);
            this.coldsTapL3DataTableAr_Press_Max.Namespace = "";
            // 
            // coldsTapL3DataTableAr_Press_Min
            // 
            this.coldsTapL3DataTableAr_Press_Min.Caption = "Ar_Press_Min";
            this.coldsTapL3DataTableAr_Press_Min.ColumnName = "Ar_Press_Min";
            this.coldsTapL3DataTableAr_Press_Min.DataType = typeof(int);
            this.coldsTapL3DataTableAr_Press_Min.Namespace = "";
            // 
            // coldsTapL3DataTableAr_Blow_Max
            // 
            this.coldsTapL3DataTableAr_Blow_Max.Caption = "Ar_Blow_Max";
            this.coldsTapL3DataTableAr_Blow_Max.ColumnName = "Ar_Blow_Max";
            this.coldsTapL3DataTableAr_Blow_Max.Namespace = "";
            // 
            // coldsTapL3DataTableAr_Blow_Min
            // 
            this.coldsTapL3DataTableAr_Blow_Min.Caption = "Ar_Blow_Min";
            this.coldsTapL3DataTableAr_Blow_Min.ColumnName = "Ar_Blow_Min";
            this.coldsTapL3DataTableAr_Blow_Min.Namespace = "";
            // 
            // txtTapArPressMin
            // 
            this.txtTapArPressMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "Ar_Press_Min", true));
            //
            this.txtTapArPressMin.EnableNull = false;
            this.txtTapArPressMin.ErropPr = this.errorProvider1;
            //
            this.txtTapArPressMin.Length = 0;
            this.txtTapArPressMin.Location = new System.Drawing.Point(594, 31);
            this.txtTapArPressMin.Max = 9999;
           // //
            //
            this.txtTapArPressMin.MaxStrLength = 0;
            this.txtTapArPressMin.Min = 0;
           // //
            //
            this.txtTapArPressMin.MinStrLength = 0;
            this.txtTapArPressMin.Name = "txtTapArPressMin";
            this.txtTapArPressMin.Precision = 0;
            //
            this.txtTapArPressMin.Size = new System.Drawing.Size(100, 21);
            this.txtTapArPressMin.TabIndex = 8;
            this.txtTapArPressMin.ToolTipValid = this.toolTip1;
          //
            this.txtTapArPressMin.ValidEable = true;
            this.txtTapArPressMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(240, 35);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(89, 12);
            this.label113.TabIndex = 2;
            this.label113.Text = "终点成份C上限:";
            // 
            // txtEndPUpLimit
            // 
            this.txtEndPUpLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "End_P_UpLimit", true));
            //
            this.txtEndPUpLimit.EnableNull = false;
            this.txtEndPUpLimit.ErropPr = this.errorProvider1;
            //
            this.txtEndPUpLimit.Length = 0;
            this.txtEndPUpLimit.Location = new System.Drawing.Point(335, 81);
            this.txtEndPUpLimit.Max = 9999;
           // //
            //
            this.txtEndPUpLimit.MaxStrLength = 0;
            this.txtEndPUpLimit.Min = 0;
         //   //
            //
            this.txtEndPUpLimit.MinStrLength = 0;
            this.txtEndPUpLimit.Name = "txtEndPUpLimit";
            this.txtEndPUpLimit.Precision = 0;
            //
            this.txtEndPUpLimit.Size = new System.Drawing.Size(100, 21);
            this.txtEndPUpLimit.TabIndex = 6;
            this.txtEndPUpLimit.ToolTipValid = this.toolTip1;
          //
            this.txtEndPUpLimit.ValidEable = true;
            this.txtEndPUpLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTapArBlowMax
            // 
            this.txtTapArBlowMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "Ar_Blow_Max", true));
            //
            this.txtTapArBlowMax.EnableNull = false;
            this.txtTapArBlowMax.ErropPr = this.errorProvider1;
            //
            this.txtTapArBlowMax.Length = 0;
            this.txtTapArBlowMax.Location = new System.Drawing.Point(594, 106);
            this.txtTapArBlowMax.Max = 99999;
           // //
            //
            this.txtTapArBlowMax.MaxStrLength = 0;
            this.txtTapArBlowMax.Min = 0;
          //  //
            //
            this.txtTapArBlowMax.MinStrLength = 0;
            this.txtTapArBlowMax.Name = "txtTapArBlowMax";
            this.txtTapArBlowMax.Precision = 0;
            //
            this.txtTapArBlowMax.Size = new System.Drawing.Size(100, 21);
            this.txtTapArBlowMax.TabIndex = 11;
            this.txtTapArBlowMax.ToolTipValid = this.toolTip1;
          //
            this.txtTapArBlowMax.ValidEable = true;
            this.txtTapArBlowMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(7, 85);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(95, 12);
            this.label114.TabIndex = 2;
            this.label114.Text = "终点氧含量上限:";
            // 
            // txtTapArPressMax
            // 
            this.txtTapArPressMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "Ar_Press_Max", true));
            //
            this.txtTapArPressMax.EnableNull = false;
            this.txtTapArPressMax.ErropPr = this.errorProvider1;
            //
            this.txtTapArPressMax.Length = 0;
            this.txtTapArPressMax.Location = new System.Drawing.Point(594, 56);
            this.txtTapArPressMax.Max = 9999;
            ////
            //
            this.txtTapArPressMax.MaxStrLength = 0;
            this.txtTapArPressMax.Min = 0;
          //  //
            //
            this.txtTapArPressMax.MinStrLength = 0;
            this.txtTapArPressMax.Name = "txtTapArPressMax";
            this.txtTapArPressMax.Precision = 0;
            //
            this.txtTapArPressMax.Size = new System.Drawing.Size(100, 21);
            this.txtTapArPressMax.TabIndex = 9;
            this.txtTapArPressMax.ToolTipValid = this.toolTip1;
          //
            this.txtTapArPressMax.ValidEable = true;
            this.txtTapArPressMax.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtEndCUpLimit
            // 
            this.txtEndCUpLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "End_C_UpLimit", true));
            //
            this.txtEndCUpLimit.EnableNull = false;
            this.txtEndCUpLimit.ErropPr = this.errorProvider1;
            //
            this.txtEndCUpLimit.Length = 0;
            this.txtEndCUpLimit.Location = new System.Drawing.Point(335, 31);
            this.txtEndCUpLimit.Max = 9999;
           // //
            //
            this.txtEndCUpLimit.MaxStrLength = 0;
            this.txtEndCUpLimit.Min = 0;
          //  //
            //
            this.txtEndCUpLimit.MinStrLength = 0;
            this.txtEndCUpLimit.Name = "txtEndCUpLimit";
            this.txtEndCUpLimit.Precision = 0;
            //
            this.txtEndCUpLimit.Size = new System.Drawing.Size(100, 21);
            this.txtEndCUpLimit.TabIndex = 4;
            this.txtEndCUpLimit.ToolTipValid = this.toolTip1;
          //
            this.txtEndCUpLimit.ValidEable = true;
            this.txtEndCUpLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtEndMnUpLimit
            // 
            this.txtEndMnUpLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "End_Mn_UpLimit", true));
            //
            this.txtEndMnUpLimit.EnableNull = false;
            this.txtEndMnUpLimit.ErropPr = this.errorProvider1;
            //
            this.txtEndMnUpLimit.Length = 0;
            this.txtEndMnUpLimit.Location = new System.Drawing.Point(335, 106);
            this.txtEndMnUpLimit.Max = 9999;
         //   //
            //
            this.txtEndMnUpLimit.MaxStrLength = 0;
            this.txtEndMnUpLimit.Min = 0;
          //  //
            //
            this.txtEndMnUpLimit.MinStrLength = 0;
            this.txtEndMnUpLimit.Name = "txtEndMnUpLimit";
            this.txtEndMnUpLimit.Precision = 0;
            //
            this.txtEndMnUpLimit.Size = new System.Drawing.Size(100, 21);
            this.txtEndMnUpLimit.TabIndex = 7;
            this.txtEndMnUpLimit.ToolTipValid = this.toolTip1;
          //
            this.txtEndMnUpLimit.ValidEable = true;
            this.txtEndMnUpLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTappingTimeMin
            // 
            this.txtTappingTimeMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "Tapping_Time_Min", true));
            //
            this.txtTappingTimeMin.EnableNull = false;
            this.txtTappingTimeMin.ErropPr = this.errorProvider1;
            //
            this.txtTappingTimeMin.Length = 0;
            this.txtTappingTimeMin.Location = new System.Drawing.Point(108, 56);
            this.txtTappingTimeMin.Max = 9999;
           // //
            //
            this.txtTappingTimeMin.MaxStrLength = 0;
            this.txtTappingTimeMin.Min = 0;
          //  //
            //
            this.txtTappingTimeMin.MinStrLength = 0;
            this.txtTappingTimeMin.Name = "txtTappingTimeMin";
            this.txtTappingTimeMin.Precision = 0;
            //
            this.txtTappingTimeMin.Size = new System.Drawing.Size(100, 21);
            this.txtTappingTimeMin.TabIndex = 1;
            this.txtTappingTimeMin.ToolTipValid = this.toolTip1;
          //
            this.txtTappingTimeMin.ValidEable = true;
            this.txtTappingTimeMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtEndCLowLimit
            // 
            this.txtEndCLowLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "End_C_LowLimit", true));
            //
            this.txtEndCLowLimit.EnableNull = false;
            this.txtEndCLowLimit.ErropPr = this.errorProvider1;
            //
            this.txtEndCLowLimit.Length = 0;
            this.txtEndCLowLimit.Location = new System.Drawing.Point(335, 56);
            this.txtEndCLowLimit.Max = 9999;
          //  //
            //
            this.txtEndCLowLimit.MaxStrLength = 0;
            this.txtEndCLowLimit.Min = 0;
           // //
            //
            this.txtEndCLowLimit.MinStrLength = 0;
            this.txtEndCLowLimit.Name = "txtEndCLowLimit";
            this.txtEndCLowLimit.Precision = 0;
            //
            this.txtEndCLowLimit.Size = new System.Drawing.Size(100, 21);
            this.txtEndCLowLimit.TabIndex = 5;
            this.txtEndCLowLimit.ToolTipValid = this.toolTip1;
          //
            this.txtEndCLowLimit.ValidEable = true;
            this.txtEndCLowLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtEndO2UpLimit
            // 
            this.txtEndO2UpLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "End_O2_UpLimit", true));
            //
            this.txtEndO2UpLimit.EnableNull = false;
            this.txtEndO2UpLimit.ErropPr = this.errorProvider1;
            //
            this.txtEndO2UpLimit.Length = 0;
            this.txtEndO2UpLimit.Location = new System.Drawing.Point(108, 81);
            this.txtEndO2UpLimit.Max = 9999;
           // //
            //
            this.txtEndO2UpLimit.MaxStrLength = 0;
            this.txtEndO2UpLimit.Min = 0;
          //  //
            //
            this.txtEndO2UpLimit.MinStrLength = 0;
            this.txtEndO2UpLimit.Name = "txtEndO2UpLimit";
            this.txtEndO2UpLimit.Precision = 0;
            //
            this.txtEndO2UpLimit.Size = new System.Drawing.Size(100, 21);
            this.txtEndO2UpLimit.TabIndex = 2;
            this.txtEndO2UpLimit.ToolTipValid = this.toolTip1;
          //
            this.txtEndO2UpLimit.ValidEable = true;
            this.txtEndO2UpLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtEndSUpLimit
            // 
            this.txtEndSUpLimit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "End_S_UpLimit", true));
            //
            this.txtEndSUpLimit.EnableNull = false;
            this.txtEndSUpLimit.ErropPr = this.errorProvider1;
            //
            this.txtEndSUpLimit.Length = 0;
            this.txtEndSUpLimit.Location = new System.Drawing.Point(108, 106);
            this.txtEndSUpLimit.Max = 9999;
            ////
            //
            this.txtEndSUpLimit.MaxStrLength = 0;
            this.txtEndSUpLimit.Min = 0;
          //  //
            //
            this.txtEndSUpLimit.MinStrLength = 0;
            this.txtEndSUpLimit.Name = "txtEndSUpLimit";
            this.txtEndSUpLimit.Precision = 0;
            //
            this.txtEndSUpLimit.Size = new System.Drawing.Size(100, 21);
            this.txtEndSUpLimit.TabIndex = 3;
            this.txtEndSUpLimit.ToolTipValid = this.toolTip1;
          //
            this.txtEndSUpLimit.ValidEable = true;
            this.txtEndSUpLimit.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtTappingTempMin
            // 
            this.txtTappingTempMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "Tapping_Temp_Min", true));
            //
            this.txtTappingTempMin.EnableNull = false;
            this.txtTappingTempMin.ErropPr = this.errorProvider1;
            //
            this.txtTappingTempMin.Length = 0;
            this.txtTappingTempMin.Location = new System.Drawing.Point(108, 31);
            this.txtTappingTempMin.Max = 9999;
           // //
            //
            this.txtTappingTempMin.MaxStrLength = 0;
            this.txtTappingTempMin.Min = 0;
           // //
            //
            this.txtTappingTempMin.MinStrLength = 0;
            this.txtTappingTempMin.Name = "txtTappingTempMin";
            this.txtTappingTempMin.Precision = 0;
            //
            this.txtTappingTempMin.Size = new System.Drawing.Size(100, 21);
            this.txtTappingTempMin.TabIndex = 0;
            this.txtTappingTempMin.ToolTipValid = this.toolTip1;
          //
            this.txtTappingTempMin.ValidEable = true;
            this.txtTappingTempMin.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtSteelGradeIndexTap);
            this.groupBox9.Controls.Add(this.label54);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1010, 54);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            // 
            // txtSteelGradeIndexTap
            // 
            this.txtSteelGradeIndexTap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTap, "SteelGradeIndex", true));
            //
            this.txtSteelGradeIndexTap.EnableNull = false;
            this.txtSteelGradeIndexTap.ErropPr = this.errorProvider1;
            //
            this.txtSteelGradeIndexTap.Length = 8;
            this.txtSteelGradeIndexTap.Location = new System.Drawing.Point(108, 17);
            this.txtSteelGradeIndexTap.Max = 0;
            this.txtSteelGradeIndexTap.MaxLength = 8;
          //  //
            //
            this.txtSteelGradeIndexTap.MaxStrLength = 0;
            this.txtSteelGradeIndexTap.Min = 0;
           // //
            //
            this.txtSteelGradeIndexTap.MinStrLength = 0;
            this.txtSteelGradeIndexTap.Name = "txtSteelGradeIndexTap";
            this.txtSteelGradeIndexTap.Precision = 0;
            this.txtSteelGradeIndexTap.ReadOnly = true;
            //
            this.txtSteelGradeIndexTap.Size = new System.Drawing.Size(181, 21);
            this.txtSteelGradeIndexTap.TabIndex = 0;
            this.txtSteelGradeIndexTap.ToolTipValid = this.toolTip1;
          //
            this.txtSteelGradeIndexTap.ValidEable = true;
            this.txtSteelGradeIndexTap.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(43, 20);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 12);
            this.label54.TabIndex = 14;
            this.label54.Text = "炼钢记号:";
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
            // l3Command1
            // 
            this.l3Command1.Adapter = null;
            this.l3Command1.MergeReturnTarget = false;
            this.l3Command1.Method = null;
            this.l3Command1.Object = null;
            this.l3Command1.Parameters.Add(this.l3CommandParameter1);
            this.l3Command1.ReturnTarget = null;
            this.l3Command1.ReturnTargetProperty = null;
            this.l3Command1.Trigger = null;
            this.l3Command1.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.tscmbSteelGradeIndex;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn1.HeaderText = "炼钢记号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Bulk_Code";
            this.dataGridViewTextBoxColumn2.HeaderText = "散状料名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Bulk_Weight_Min";
            this.dataGridViewTextBoxColumn3.HeaderText = "散状料1加入量最小";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 132;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Bulk_Weight_Max";
            this.dataGridViewTextBoxColumn4.HeaderText = "散状料1加入量最大";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 132;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn6.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 54;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn7.HeaderText = "炼钢记号";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Feed_Code";
            this.dataGridViewTextBoxColumn8.HeaderText = "喂丝线名称";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 90;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Feed_Weight_Min";
            this.dataGridViewTextBoxColumn9.HeaderText = "喂丝线用量最小";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 114;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Feed_Weight_Max";
            this.dataGridViewTextBoxColumn10.HeaderText = "喂丝线加入量最大";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 126;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn11.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 54;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn12.HeaderText = "Name";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 54;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn13.HeaderText = "炼钢记号";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 78;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Ladle_Mat_Name";
            this.dataGridViewTextBoxColumn14.HeaderText = "钢包物料名称";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 102;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Ladle_Mat_Min";
            this.dataGridViewTextBoxColumn15.HeaderText = "钢包物料数量最小";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 126;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Ladle_Mat_Max";
            this.dataGridViewTextBoxColumn16.HeaderText = "钢包物料数量最大";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 126;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Ladle_Mat_Aim";
            this.dataGridViewTextBoxColumn17.HeaderText = "钢包物料数量目标";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 126;
            // 
            // BOFStdMaintenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 680);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BOFStdMaintenFrm";
            this.TabText = "转炉制造标准维护";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BOFStdMaintenFrm_FormClosing);
            this.Load += new System.EventHandler(this.BOFStdMaintenFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabAr.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAr)).EndInit();
            this.gbxTemp.ResumeLayout(false);
            this.gbxTemp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabBlow.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlow)).EndInit();
            this.tabBlowO2.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlowO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlowO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlowO2)).EndInit();
            this.tabBulk.ResumeLayout(false);
            this.hmiRootPanelBulk.ResumeLayout(false);
            this.hmiRootPanelBulk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBulk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorBulk)).EndInit();
            this.bNavigatorBulk.ResumeLayout(false);
            this.bNavigatorBulk.PerformLayout();
            this.tabFeed.ResumeLayout(false);
            this.hmiRootPanelFeed.ResumeLayout(false);
            this.hmiRootPanelFeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigatorFeed)).EndInit();
            this.bNavigatorFeed.ResumeLayout(false);
            this.bNavigatorFeed.PerformLayout();
            this.tabInToConver.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInToConver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInToConver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInToConver)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tabLadle.ResumeLayout(false);
            this.hmiRootPanelLadle.ResumeLayout(false);
            this.hmiRootPanelLadle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabSlagEle.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSlagEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlagEle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlagEle)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabTap.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTap)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox tscmbSteelGradeIndex;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.TabPage tabBlow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.TabPage tabBlowO2;
        private System.Windows.Forms.TabPage tabBulk;
        private System.Windows.Forms.TabPage tabFeed;
        private System.Windows.Forms.TabPage tabLadle;
        private System.Windows.Forms.TabPage tabSlagEle;
        private System.Windows.Forms.TabPage tabTap;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.DateTimePicker dtValidDate;
        private PxDataValid.PxTextBox txtNewCode;
        private PxDataValid.PxTextBox txtSteelGradeIndexBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabAr;
        private PxDataValid.PxTextBox txtSteelGradeIndexAr;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxComboBox cmbOxyFlag;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private PxDataValid.PxTextBox txtBeArOxyMax;
        private System.Windows.Forms.Label label15;
        private PxDataValid.PxTextBox txtArBlowMax;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxTextBox txtBeArOxyMin;
        private PxDataValid.PxTextBox txtArPressMax;
        private PxDataValid.PxTextBox txtArBlowMin;
        private PxDataValid.PxTextBox txtPreArOxyMin;
        private PxDataValid.PxTextBox txtArPressMin;
        private PxDataValid.PxTextBox txtArTimeUpLimit;
        private PxDataValid.PxTextBox txtArTimeLowLimit;
        private PxDataValid.PxTextBox txtPreArOxyMax;
        private System.Windows.Forms.GroupBox gbxTemp;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private PxDataValid.PxTextBox txtBeArAim;
        private PxDataValid.PxTextBox txtPreArAim;
        private PxDataValid.PxTextBox txtBeArFirAim;
        private PxDataValid.PxTextBox txtPreArFirAim;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxTextBox txtBeArFirMin;
        private System.Windows.Forms.Label label13;
        private PxDataValid.PxTextBox txtBeArMax;
        private PxDataValid.PxTextBox txtPreArFirMin;
        private PxDataValid.PxTextBox txtBeArMin;
        private PxDataValid.PxTextBox txtPreArMax;
        private PxDataValid.PxTextBox txtBeArFirMax;
        private PxDataValid.PxTextBox txtPreArMin;
        private PxDataValid.PxTextBox txtPreArFirMax;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private PxDataValid.PxTextBox txtBottomBlowBase;
        private System.Windows.Forms.Label label11;
        private PxDataValid.PxTextBox txtReBlowTimeMax;
        private System.Windows.Forms.Label label10;
        private PxDataValid.PxTextBox txtCatchCTempMin;
        private System.Windows.Forms.Label label9;
        private PxDataValid.PxTextBox txtReBlowCntMax;
        private System.Windows.Forms.Label label8;
        private PxDataValid.PxTextBox txtSteelGradeIndexBlow;
        private System.Windows.Forms.Label label27;
        private PxDataValid.PxTextBox txtO2BlowCtr;
        private System.Windows.Forms.Label label28;
        private PxDataValid.PxTextBox txtWorkO2PressCtr;
        private System.Windows.Forms.Label label29;
        private PxDataValid.PxTextBox txtTotalO2PressCtr;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxTextBox txtSteelGradeIndexBlowO2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label38;
        private PxDataValid.PxTextBox txtSteelGradeIndexSlagEle;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label83;
        private PxDataValid.PxTextBox txtTFeMax;
        private System.Windows.Forms.Label label102;
        private PxDataValid.PxTextBox txtMgOMax;
        private PxDataValid.PxTextBox txtTFeMin;
        private PxDataValid.PxTextBox txtCaOMin;
        private PxDataValid.PxTextBox txtMgOMin;
        private PxDataValid.PxTextBox txtSiO2Max;
        private PxDataValid.PxTextBox txtSiO2Min;
        private PxDataValid.PxTextBox txtCaOMax;
        private System.Windows.Forms.GroupBox groupBox9;
        private PxDataValid.PxTextBox txtSteelGradeIndexTap;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private PxDataValid.PxTextBox txtTapArBlowMin;
        private PxDataValid.PxTextBox txtTapArPressMin;
        private System.Windows.Forms.Label label113;
        private PxDataValid.PxTextBox txtEndPUpLimit;
        private System.Windows.Forms.Label label114;
        private PxDataValid.PxTextBox txtEndCUpLimit;
        private PxDataValid.PxTextBox txtTappingTimeMin;
        private PxDataValid.PxTextBox txtEndCLowLimit;
        private PxDataValid.PxTextBox txtEndO2UpLimit;
        private PxDataValid.PxTextBox txtTappingTempMin;
        private System.Windows.Forms.Label label116;
        private PxDataValid.PxTextBox txtTapArBlowMax;
        private PxDataValid.PxTextBox txtTapArPressMax;
        private PxDataValid.PxTextBox txtEndMnUpLimit;
        private PxDataValid.PxTextBox txtEndSUpLimit;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox20;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private AppSvrHMI.L3DataSet dsBase;
        private AppSvrHMI.L3DataSet dsAr;
        private AppSvrHMI.L3DataSet dsBlow;
        private AppSvrHMI.L3DataSet dsBlowO2;
        private AppSvrHMI.L3DataSet dsBulk;
        private AppSvrHMI.L3DataSet dsFeed;
        private AppSvrHMI.L3DataSet dsInToConver;
        private AppSvrHMI.L3DataSet dsLadle;
        private AppSvrHMI.L3DataSet dsSlagEle;
        private AppSvrHMI.L3DataSet dsTap;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingSource bsAr;
        private System.Windows.Forms.BindingSource bsBlow;
        private System.Windows.Forms.BindingSource bsBlowO2;
        private System.Windows.Forms.BindingSource bsBulk;
        private System.Windows.Forms.BindingSource bsFeed;
        private System.Windows.Forms.BindingSource bsInToConver;
        private System.Windows.Forms.BindingSource bsLadle;
        private System.Windows.Forms.BindingSource bsSlagEle;
        private System.Windows.Forms.BindingSource bsTap;
        private System.Windows.Forms.TabPage tabInToConver;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private PxDataValid.PxTextBox txtScrapWeightMax;
        private PxDataValid.PxTextBox txtPigIronWeightMax;
        private PxDataValid.PxTextBox txtScrapWeightMin;
        private PxDataValid.PxTextBox txtPigIronWeightMin;
        private PxDataValid.PxTextBox txtTotalWeightMax;
        private PxDataValid.PxTextBox txtTotalWeightMin;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private PxDataValid.PxTextBox txtIronTiMax;
        private PxDataValid.PxTextBox txtIronSiMax;
        private System.Windows.Forms.Label label71;
        private PxDataValid.PxTextBox txtIronPMax;
        private PxDataValid.PxTextBox txtIronTiMin;
        private System.Windows.Forms.Label label72;
        private PxDataValid.PxTextBox txtIronSiMin;
        private PxDataValid.PxTextBox txtIronSMax;
        private PxDataValid.PxTextBox txtIronPMin;
        private PxDataValid.PxTextBox txtIronTempMin;
        private PxDataValid.PxTextBox txtIronSMin;
        private PxDataValid.PxTextBox txtIronWeightMax;
        private PxDataValid.PxTextBox txtIronWeightMin;
        private PxDataValid.PxTextBox txtIronTempMax;
        private System.Windows.Forms.GroupBox groupBox14;
        private PxDataValid.PxComboBox cmbScrapType;
        private System.Windows.Forms.Label label73;
        private PxDataValid.PxTextBox txtSteelGradeIndexInToConver;
        private System.Windows.Forms.Label label74;
        private HMIBase.HMIRootPanel hmiRootPanelBulk;
        private System.Windows.Forms.DataGridView dvBulk;
        private System.Windows.Forms.BindingNavigator bNavigatorBulk;
        private System.Windows.Forms.ToolStripButton btnAddBulk;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDelBulk;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
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
        private HMIBase.HMIRootPanel hmiRootPanelLadle;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private AppSvrHMI.L3Command l3Command1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTableValid_Date;
        private System.Data.DataColumn coldsBaseL3DataTableNew_Code;
        private System.Data.DataColumn coldsBaseL3DataTableNote;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
        private System.Data.DataTable schemadsAr;
        private System.Data.DataColumn coldsArL3DataTableGUID;
        private System.Data.DataColumn coldsArL3DataTableName;
        private System.Data.DataColumn coldsArL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsArL3DataTablePreAr_SteelTemp_Fir_Max;
        private System.Data.DataColumn coldsArL3DataTablePreAr_SteelTemp_Fir_Min;
        private System.Data.DataColumn coldsArL3DataTablePreAr_SteelTemp_Fir_Aim;
        private System.Data.DataColumn coldsArL3DataTablePreAr_SteelTemp_Max;
        private System.Data.DataColumn coldsArL3DataTablePreAr_SteelTemp_Min;
        private System.Data.DataColumn coldsArL3DataTablePreAr_SteelTemp_Aim;
        private System.Data.DataColumn coldsArL3DataTableBeAr_SteelTemp_Fir_Max;
        private System.Data.DataColumn coldsArL3DataTableBeAr_SteelTemp_Fir_Min;
        private System.Data.DataColumn coldsArL3DataTableBeAr_SteelTemp_Fir_Aim;
        private System.Data.DataColumn coldsArL3DataTableBeAr_SteelTemp_Max;
        private System.Data.DataColumn coldsArL3DataTableBeAr_SteelTemp_Min;
        private System.Data.DataColumn coldsArL3DataTableBeAr_SteelTemp_Aim;
        private System.Data.DataColumn coldsArL3DataTableOxy_Flag;
        private System.Data.DataColumn coldsArL3DataTablePreAr_Oxy_Max;
        private System.Data.DataColumn coldsArL3DataTablePreAr_Oxy_Min;
        private System.Data.DataColumn coldsArL3DataTableAr_Time_UpLimit;
        private System.Data.DataColumn coldsArL3DataTableAr_Time_LowLimit;
        private System.Data.DataColumn coldsArL3DataTableAr_Press_Max;
        private System.Data.DataColumn coldsArL3DataTableAr_Press_Min;
        private System.Data.DataColumn coldsArL3DataTableAr_Blow_Max;
        private System.Data.DataColumn coldsArL3DataTableAr_Blow_Min;
        private System.Data.DataColumn coldsArL3DataTableBeAr_Oxy_Max;
        private System.Data.DataColumn coldsArL3DataTableBeAr_Oxy_Min;
        private System.Data.DataTable schemadsBlow;
        private System.Data.DataColumn coldsBlowL3DataTableGUID;
        private System.Data.DataColumn coldsBlowL3DataTableName;
        private System.Data.DataColumn coldsBlowL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBlowL3DataTableReBlow_Cnt_Max;
        private System.Data.DataColumn coldsBlowL3DataTableCatch_C_Temp_Min;
        private System.Data.DataColumn coldsBlowL3DataTableReBlow_Time_Max;
        private System.Data.DataColumn coldsBlowL3DataTableBottom_Blow_Base;
        private System.Data.DataTable schemadsBulk;
        private System.Data.DataColumn coldsBulkL3DataTableGUID;
        private System.Data.DataColumn coldsBulkL3DataTableName;
        private System.Data.DataColumn coldsBulkL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBulkL3DataTableBulk_Code;
        private System.Data.DataColumn coldsBulkL3DataTableBulk_Weight_Min;
        private System.Data.DataColumn coldsBulkL3DataTableBulk_Weight_Max;
        private System.Data.DataTable schemadsFeed;
        private System.Data.DataColumn coldsFeedL3DataTableGUID;
        private System.Data.DataColumn coldsFeedL3DataTableName;
        private System.Data.DataColumn coldsFeedL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsFeedL3DataTableFeed_Code;
        private System.Data.DataColumn coldsFeedL3DataTableFeed_Weight_Min;
        private System.Data.DataColumn coldsFeedL3DataTableFeed_Weight_Max;
        private System.Data.DataTable schemadsInToConver;
        private System.Data.DataColumn coldsInToConverL3DataTableGUID;
        private System.Data.DataColumn coldsInToConverL3DataTableName;
        private System.Data.DataColumn coldsInToConverL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Temp_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Temp_Max;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Weight_Max;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Weight_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_S_Max;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_S_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_P_Max;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_P_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Si_Max;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Si_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Ti_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableIron_Ti_Max;
        private System.Data.DataColumn coldsInToConverL3DataTableScrap_Type;
        private System.Data.DataColumn coldsInToConverL3DataTableScrap_Weight_Max;
        private System.Data.DataColumn coldsInToConverL3DataTableScrap_Weight_Min;
        private System.Data.DataColumn coldsInToConverL3DataTablePigIron_Weight_Max;
        private System.Data.DataColumn coldsInToConverL3DataTablePigIron_Weight_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableTotal_Weight_Min;
        private System.Data.DataColumn coldsInToConverL3DataTableTotal_Weight_Max;
        private System.Data.DataTable schemadsLadle;
        private System.Data.DataColumn coldsLadleL3DataTableGUID;
        private System.Data.DataColumn coldsLadleL3DataTableName;
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
        private System.Data.DataColumn coldsSlagEleL3DataTableTFe_Max;
        private System.Data.DataColumn coldsSlagEleL3DataTableTFe_Min;
        private System.Data.DataTable schemadsTap;
        private System.Data.DataColumn coldsTapL3DataTableGUID;
        private System.Data.DataColumn coldsTapL3DataTableName;
        private System.Data.DataColumn coldsTapL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsTapL3DataTableTapping_Temp_Min;
        private System.Data.DataColumn coldsTapL3DataTableTapping_Time_Min;
        private System.Data.DataColumn coldsTapL3DataTableEnd_O2_UpLimit;
        private System.Data.DataColumn coldsTapL3DataTableEnd_C_UpLimit;
        private System.Data.DataColumn coldsTapL3DataTableEnd_C_LowLimit;
        private System.Data.DataColumn coldsTapL3DataTableEnd_S_UpLimit;
        private System.Data.DataColumn coldsTapL3DataTableEnd_P_UpLimit;
        private System.Data.DataColumn coldsTapL3DataTableEnd_Mn_UpLimit;
        private System.Data.DataColumn coldsTapL3DataTableAr_Press_Max;
        private System.Data.DataColumn coldsTapL3DataTableAr_Press_Min;
        private System.Data.DataColumn coldsTapL3DataTableAr_Blow_Max;
        private System.Data.DataColumn coldsTapL3DataTableAr_Blow_Min;
        private System.Windows.Forms.DataGridView dvLadle;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnAddLadle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnDelLadle;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Data.DataTable schemadsBlowO2;
        private System.Data.DataColumn coldsBlowO2L3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBlowO2L3DataTableGUID;
        private System.Data.DataColumn coldsBlowO2L3DataTableName;
        private System.Data.DataColumn coldsBlowO2L3DataTableTotal_O2_Press_Ctr;
        private System.Data.DataColumn coldsBlowO2L3DataTableWork_O2_Press_Ctr;
        private System.Data.DataColumn coldsBlowO2L3DataTableO2_Blow_Ctr;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkWeightMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkWeightMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedWeightMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedWeightMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatMinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatMaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleMatAimDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtSteelGrade;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}