namespace UnitMag.AODMag
{
    partial class AODHeatInfoFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AODHeatInfoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHeatID = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cmbShift = new PxDataValid.PxComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnProcessConfirm = new System.Windows.Forms.Button();
            this.btnBaseConfirm = new System.Windows.Forms.Button();
            this.btnRemarkConfirm = new System.Windows.Forms.Button();
            this.btnConfirmExcept = new System.Windows.Forms.Button();
            this.btnAddExcept = new System.Windows.Forms.ToolStripButton();
            this.btnAddAlloy = new System.Windows.Forms.ToolStripButton();
            this.btnAlloyCanfirm = new System.Windows.Forms.Button();
            this.btnRemarkAdd = new System.Windows.Forms.ToolStripButton();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsBaseL3DataTableShift = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTeam = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeadFurnace = new System.Data.DataColumn();
            this.coldsBaseL3DataTableAssistant = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSecondHand = new System.Data.DataColumn();
            this.coldsBaseL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsBaseL3DataTableStatisticsDate = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLocked = new System.Data.DataColumn();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeam = new PxDataValid.PxComboBox();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxSecondHand = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxAssistant = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxHeadFurnace = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSteelGradeIndex = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPreHeatID = new PxDataValid.PxTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fLPBase = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseCancel = new System.Windows.Forms.Button();
            this.tabMainMat = new System.Windows.Forms.TabPage();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsMainMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsMainMat = new AppSvrHMI.L3DataSet();
            this.schemadsMainMat = new System.Data.DataTable();
            this.coldsMainMatL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableIronWeight = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableScrapWeight = new System.Data.DataColumn();
            this.coldsMainMatL3DataTablePigIronWeight = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableReHeatAmount = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableC = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableSi = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableMn = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableP = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableS = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableTi = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableIronTemp = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableName = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableCr = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableReturn_SteelGrade = new System.Data.DataColumn();
            this.tbxCr = new PxDataValid.PxTextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.tbxIronTemp = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxS = new PxDataValid.PxTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbxP = new PxDataValid.PxTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxMn = new PxDataValid.PxTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxSi = new PxDataValid.PxTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxC = new PxDataValid.PxTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxReHeatAmount = new PxDataValid.PxTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxPigIronWeight = new PxDataValid.PxTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxScrapWeight = new PxDataValid.PxTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxIronWeight = new PxDataValid.PxTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.fLPMainMat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMainMatCancel = new System.Windows.Forms.Button();
            this.btnMainMatConfirm = new System.Windows.Forms.Button();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.label52 = new System.Windows.Forms.Label();
            this.cmbScrapStatus = new PxDataValid.PxComboBox();
            this.bsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcess = new AppSvrHMI.L3DataSet();
            this.schemadsProcess = new System.Data.DataTable();
            this.coldsProcessL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCharging_Start_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlow_Start_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTapping_Strat_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTapping_End_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlowO2_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableReBlow_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTapping_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSplashing_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSmelt_Period = new System.Data.DataColumn();
            this.coldsProcessL3DataTableWaiting_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLance_Age = new System.Data.DataColumn();
            this.coldsProcessL3DataTableFurnace_Age = new System.Data.DataColumn();
            this.coldsProcessL3DataTableReBlow_Count = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLaC_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTapping_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSingle_LaC = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTapping_Oxygen = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadleNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Status = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTaphole_Life = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTapping_Weight = new System.Data.DataColumn();
            this.coldsProcessL3DataTableFurnace_Line_Status = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Grade = new System.Data.DataColumn();
            this.coldsProcessL3DataTableScrapStatus = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCarpolite = new System.Data.DataColumn();
            this.coldsProcessL3DataTableReturn_Start_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Stop = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLanceNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableName = new System.Data.DataColumn();
            this.coldsProcessL3DataTableFurnaceNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableIn_Delay_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableShebei_Delay_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableJiezhi_Delay_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableGongfu_Delay_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableZhunbei_Delay_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableJianxiu_Delay_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableO2_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableN2_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableAr_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableN2_Ar_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlow_O2_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableDec1_O2_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableDec2_O2_Consume = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCr2O3 = new System.Data.DataColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pxTextBox15 = new PxDataValid.PxTextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.pxTextBox14 = new PxDataValid.PxTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.pxTextBox13 = new PxDataValid.PxTextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.pxTextBox12 = new PxDataValid.PxTextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.pxTextBox11 = new PxDataValid.PxTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.pxTextBox10 = new PxDataValid.PxTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.pxTextBox9 = new PxDataValid.PxTextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pxTextBox6 = new PxDataValid.PxTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.pxTextBox7 = new PxDataValid.PxTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtWaitingTime = new PxDataValid.PxTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.pxTextBox5 = new PxDataValid.PxTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLadleGrade = new System.Windows.Forms.ComboBox();
            this.txtTappingWeight = new PxDataValid.PxTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtTapholeLife = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtLadleNo = new PxDataValid.PxTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtTappingTemp = new PxDataValid.PxTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtLaCTemp = new PxDataValid.PxTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.dtTappingEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtTappingStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtBlowStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtChargingStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtFurnaceAge = new PxDataValid.PxTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtLanceAge = new PxDataValid.PxTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSmeltPeriod = new PxDataValid.PxTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSplashingTime = new PxDataValid.PxTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTappingTime = new PxDataValid.PxTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.fLPProcess = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcessCancel = new System.Windows.Forms.Button();
            this.tabAlloy = new System.Windows.Forms.TabPage();
            this.hmiRootPanel4 = new HMIBase.HMIRootPanel();
            this.cmbBatchID = new System.Windows.Forms.ComboBox();
            this.dsMat_Alloy_Add_Man = new AppSvrHMI.L3DataSet();
            this.schemadsMat_Alloy_Add_Man = new System.Data.DataTable();
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsMat_Alloy_Add_ManL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsMat_Alloy_Add_ManL3DataTableCode = new System.Data.DataColumn();
            this.coldsMat_Alloy_Add_ManL3DataTableCode_Des = new System.Data.DataColumn();
            this.dvAlloy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvcmbAlloyCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsAlloyCode = new System.Windows.Forms.BindingSource(this.components);
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.schemadsCode = new System.Data.DataTable();
            this.coldsCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCODE_GROUP = new System.Data.DataColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAdditionType = new AppSvrHMI.L3DataSet();
            this.schemadsAdditionType = new System.Data.DataTable();
            this.coldsAdditionTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdditionTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.Batch_ID_Pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAlloy = new System.Windows.Forms.BindingSource(this.components);
            this.dsMat = new AppSvrHMI.L3DataSet();
            this.schemadsMat = new System.Data.DataTable();
            this.coldsMatL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMatL3DataTableElement = new System.Data.DataColumn();
            this.coldsMatL3DataTableWeight = new System.Data.DataColumn();
            this.coldsMatL3DataTableDischarge_Time = new System.Data.DataColumn();
            this.coldsMatL3DataTableType = new System.Data.DataColumn();
            this.coldsMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatL3DataTableName = new System.Data.DataColumn();
            this.coldsMatL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsMatL3DataTableEnableFlag = new System.Data.DataColumn();
            this.bdAlloy = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelAlloy = new System.Windows.Forms.ToolStripButton();
            this.btnRefAlloy = new System.Windows.Forms.ToolStripButton();
            this.fLPAlloy = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAlloyCancel = new System.Windows.Forms.Button();
            this.tabSumAddition = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.eLEMENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wEIGHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsSumAddition = new System.Windows.Forms.BindingSource(this.components);
            this.dsSumAddition = new AppSvrHMI.L3DataSet();
            this.schemadsSumAddition = new System.Data.DataTable();
            this.coldsSumAdditionL3DataTableWEIGHT = new System.Data.DataColumn();
            this.coldsSumAdditionL3DataTableELEMENT = new System.Data.DataColumn();
            this.AcoldsSumAdditionL3DataTableTYPE = new System.Data.DataColumn();
            this.tabChemical = new System.Windows.Forms.TabPage();
            this.dvChemical = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitType = new AppSvrHMI.L3DataSet();
            this.schemadsUnitType = new System.Data.DataTable();
            this.coldsUnitTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnitTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleAddr = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.sampleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleType = new AppSvrHMI.L3DataSet();
            this.schemadsSampleType = new System.Data.DataTable();
            this.coldsSampleTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.sampleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.znDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ceqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDataLogMode = new AppSvrHMI.L3DataSet();
            this.schemadsDataLogMode = new System.Data.DataTable();
            this.coldsDataLogModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDataLogModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsChemical = new System.Windows.Forms.BindingSource(this.components);
            this.dsChemical = new AppSvrHMI.L3DataSet();
            this.schemadsChemical = new System.Data.DataTable();
            this.coldsChemicalL3DataTableAppID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableC = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableMn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableP = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableS = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCr = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableMo = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableV = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableNb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAl = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAlS = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableTi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableB = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableAs = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableSn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableZn = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCa = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableW = new System.Data.DataColumn();
            this.coldsChemicalL3DataTablePb = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableRe = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCeq = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableN = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableH = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableO = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableGUID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableName = new System.Data.DataColumn();
            this.bnChemical = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddChemical = new System.Windows.Forms.ToolStripButton();
            this.btnDelChemical = new System.Windows.Forms.ToolStripButton();
            this.btnRefEle = new System.Windows.Forms.ToolStripButton();
            this.fLPChemical = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChemicalCancel = new System.Windows.Forms.Button();
            this.btnChemicalConfirm = new System.Windows.Forms.Button();
            this.tabBottomBlow = new System.Windows.Forms.TabPage();
            this.dvBottomBlow = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressure1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressure2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressure3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressure4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressure5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flow6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressure6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.catchTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBottomBlow = new System.Windows.Forms.BindingSource(this.components);
            this.dsBottomBlow = new AppSvrHMI.L3DataSet();
            this.schemadsBottomBlow = new System.Data.DataTable();
            this.coldsBottomBlowL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableFlow1 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTablePressure1 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableFlow2 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTablePressure2 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableFlow3 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTablePressure3 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableFlow4 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTablePressure4 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableFlow5 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTablePressure5 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableFlow6 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTablePressure6 = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableGas_Type = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableCatch_Time = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBottomBlowL3DataTableName = new System.Data.DataColumn();
            this.bnBottomBlow = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddBottomBlow = new System.Windows.Forms.ToolStripButton();
            this.btnDelBottomBlow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.fLPBottomBlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBottomBlowCancel = new System.Windows.Forms.Button();
            this.btnBottomBlowConfirm = new System.Windows.Forms.Button();
            this.tabTopBlow = new System.Windows.Forms.TabPage();
            this.dvTopBlow = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Press_MainPipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTopBlow = new System.Windows.Forms.BindingSource(this.components);
            this.dsTopBlow = new AppSvrHMI.L3DataSet();
            this.schemadsTopBlow = new System.Data.DataTable();
            this.coldsTopBlowL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTopBlowL3DataTableFlow = new System.Data.DataColumn();
            this.coldsTopBlowL3DataTablePressure = new System.Data.DataColumn();
            this.coldsTopBlowL3DataTableCatch_Time = new System.Data.DataColumn();
            this.coldsTopBlowL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTopBlowL3DataTableName = new System.Data.DataColumn();
            this.coldsTopBlowL3DataTablePress_MainPipe = new System.Data.DataColumn();
            this.bnTopBlow = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddTopBlow = new System.Windows.Forms.ToolStripButton();
            this.btnDelTopBlow = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.fLPTopBlow = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTopBlowCancel = new System.Windows.Forms.Button();
            this.btnTopBlowConfirm = new System.Windows.Forms.Button();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.dvStatus = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableStatus = new System.Data.DataColumn();
            this.coldsStatusL3DataTableChange_Time = new System.Data.DataColumn();
            this.coldsStatusL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableName = new System.Data.DataColumn();
            this.bnStatus = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStatus = new System.Windows.Forms.ToolStripButton();
            this.btnDelStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.fLPStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStatusCancel = new System.Windows.Forms.Button();
            this.btnStatusConfirm = new System.Windows.Forms.Button();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.hmiRootPanel6 = new HMIBase.HMIRootPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvTemp = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsBOFTempMode1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBOFTempMode = new AppSvrHMI.L3DataSet();
            this.schemadsBOFTempMode = new System.Data.DataTable();
            this.coldsBOFTempModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBOFTempModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.Name4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTemp = new System.Windows.Forms.BindingSource(this.components);
            this.dsTemp = new AppSvrHMI.L3DataSet();
            this.schemadsTemp = new System.Data.DataTable();
            this.coldsTempL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTempL3DataTableTemp = new System.Data.DataColumn();
            this.coldsTempL3DataTableTemp_Time = new System.Data.DataColumn();
            this.coldsTempL3DataTableMode = new System.Data.DataColumn();
            this.coldsTempL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTempL3DataTableName = new System.Data.DataColumn();
            this.bnTemp = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddTemp = new System.Windows.Forms.ToolStripButton();
            this.btnDelTemp = new System.Windows.Forms.ToolStripButton();
            this.fLPTemp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTempCancel = new System.Windows.Forms.Button();
            this.btnTempConfirm = new System.Windows.Forms.Button();
            this.tabExcept = new System.Windows.Forms.TabPage();
            this.dvExcept = new System.Windows.Forms.DataGridView();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsExceptCode = new AppSvrHMI.L3DataSet();
            this.schemadsExceptCode = new System.Data.DataTable();
            this.coldsExceptCodeL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableExceptional_Des = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableUnit = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableName = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag = new System.Data.DataColumn();
            this.classifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsExcept = new System.Windows.Forms.BindingSource(this.components);
            this.dsExcept = new AppSvrHMI.L3DataSet();
            this.schemadsExcept = new System.Data.DataTable();
            this.coldsExceptL3DataTableID_Object = new System.Data.DataColumn();
            this.coldsExceptL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableProcess_Count = new System.Data.DataColumn();
            this.coldsExceptL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsExceptL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsExceptL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsExceptL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsExceptL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptL3DataTableClassify = new System.Data.DataColumn();
            this.coldsExceptL3DataTableExceptional_Time = new System.Data.DataColumn();
            this.fLPExcept = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelExcept = new System.Windows.Forms.Button();
            this.bdExcept = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem7 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem7 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem7 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelExcept = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.txtExcept = new System.Windows.Forms.ToolStripTextBox();
            this.tabRemark = new System.Windows.Forms.TabPage();
            this.hmiRootPanel3 = new HMIBase.HMIRootPanel();
            this.dvRemark = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeIDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsRemarkType = new AppSvrHMI.L3DataSet();
            this.schemadsRemarkType = new System.Data.DataTable();
            this.coldsRemarkTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsRemarkTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.logTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRemark = new System.Windows.Forms.BindingSource(this.components);
            this.dsRemark = new AppSvrHMI.L3DataSet();
            this.schemadsRemark = new System.Data.DataTable();
            this.coldsRemarkL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableName = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableTypeID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableRemark = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableLog_Time = new System.Data.DataColumn();
            this.bnRemark = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemarkDel = new System.Windows.Forms.ToolStripButton();
            this.fLPRemark = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemarkCancel = new System.Windows.Forms.Button();
            this.dsBulk_Add_Man = new AppSvrHMI.L3DataSet();
            this.schemadsBulk_Add_Man = new System.Data.DataTable();
            this.coldsBulk_Add_ManL3DataTableBulk_Code = new System.Data.DataColumn();
            this.coldsBulk_Add_ManL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsBulk_Add_ManL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulk_Add_ManL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsBulkCode = new System.Windows.Forms.BindingSource(this.components);
            this.bsMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsBOFUnitStatus = new AppSvrHMI.L3DataSet();
            this.schemadsBOFUnitStatus = new System.Data.DataTable();
            this.coldsBOFUnitStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBOFUnitStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsTuneFlag = new AppSvrHMI.L3DataSet();
            this.schemadsTuneFlag = new System.Data.DataTable();
            this.coldsTuneFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTuneFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsFurnaceLineStatus = new AppSvrHMI.L3DataSet();
            this.schemadsFurnaceLineStatus = new System.Data.DataTable();
            this.coldsFurnaceLineStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsFurnaceLineStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsBlowMode = new AppSvrHMI.L3DataSet();
            this.schemadsBlowMode = new System.Data.DataTable();
            this.coldsBlowModeL3DataTableCode_des = new System.Data.DataColumn();
            this.coldsBlowModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsWire_Add_man = new AppSvrHMI.L3DataSet();
            this.schemadsWire_Add_man = new System.Data.DataTable();
            this.coldsWire_Add_manL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTableCode = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsWire_Add_manL3DataTablecode_function_group = new System.Data.DataColumn();
            this.bsTapAlloy = new System.Windows.Forms.BindingSource(this.components);
            this.bsBOFTempMode2 = new System.Windows.Forms.BindingSource(this.components);
            this.coldsChemicalL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther3 = new System.Data.DataColumn();
            this.dsDuty = new AppSvrHMI.L3DataSet();
            this.schemadsDuty = new System.Data.DataTable();
            this.coldsDutyL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDutyL3DataTableName = new System.Data.DataColumn();
            this.coldsDutyL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsDutyL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsDutyL3DataTableTeam = new System.Data.DataColumn();
            this.coldsDutyL3DataTableHeadFurnace = new System.Data.DataColumn();
            this.coldsDutyL3DataTableAssistant = new System.Data.DataColumn();
            this.coldsDutyL3DataTableSecondHand = new System.Data.DataColumn();
            this.cmdHeatExcept = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHeatID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpUnitType = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpUnitID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdprsData = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.AcoldsMatL3DataTableBatch_ID = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.coldsSCRAP_SLOT_IDL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableName = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableNo = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableAmount = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableType = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableReason = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableTarget = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableOperator = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableShift = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableTeam = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableCar_ID = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableCar_Type = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableTare_Weight = new System.Data.DataColumn();
            this.coldsSCRAP_SLOT_IDL3DataTableIron_Flag = new System.Data.DataColumn();
            this.coldsddL3DataTableGUID = new System.Data.DataColumn();
            this.coldsddL3DataTableName = new System.Data.DataColumn();
            this.coldsddL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsddL3DataTableStatus = new System.Data.DataColumn();
            this.coldsddL3DataTablePosition = new System.Data.DataColumn();
            this.coldsddL3DataTableQAStatus = new System.Data.DataColumn();
            this.coldsddL3DataTableQALevel = new System.Data.DataColumn();
            this.coldsddL3DataTableOrderContractID = new System.Data.DataColumn();
            this.coldsddL3DataTableProduceContractID = new System.Data.DataColumn();
            this.coldsddL3DataTableSalesContractID = new System.Data.DataColumn();
            this.coldsddL3DataTableWeight = new System.Data.DataColumn();
            this.coldsddL3DataTableC = new System.Data.DataColumn();
            this.coldsddL3DataTableSi = new System.Data.DataColumn();
            this.coldsddL3DataTableMn = new System.Data.DataColumn();
            this.coldsddL3DataTableP = new System.Data.DataColumn();
            this.coldsddL3DataTableS = new System.Data.DataColumn();
            this.coldsddL3DataTableTi = new System.Data.DataColumn();
            this.coldsddL3DataTableIronTemp = new System.Data.DataColumn();
            this.coldsddL3DataTableShift = new System.Data.DataColumn();
            this.coldsddL3DataTableTeam = new System.Data.DataColumn();
            this.coldsddL3DataTableOperator = new System.Data.DataColumn();
            this.coldsddL3DataTableTare = new System.Data.DataColumn();
            this.coldsddL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsddL3DataTableTap_Time = new System.Data.DataColumn();
            this.coldsddL3DataTableIronLadleNo = new System.Data.DataColumn();
            this.coldsddL3DataTableObject1 = new System.Data.DataColumn();
            this.coldsddL3DataTableWeight1 = new System.Data.DataColumn();
            this.coldsddL3DataTableObject2 = new System.Data.DataColumn();
            this.coldsddL3DataTableWeight2 = new System.Data.DataColumn();
            this.coldsddL3DataTableObject3 = new System.Data.DataColumn();
            this.coldsddL3DataTableWeight3 = new System.Data.DataColumn();
            this.coldsddL3DataTableReturn_Steel_Weight = new System.Data.DataColumn();
            this.coldsddL3DataTableIsDes = new System.Data.DataColumn();
            this.cmdExcept = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.coldsSumAdditionL3DataTabletype = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Age = new System.Data.DataColumn();
            this.pxTextBox8 = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            this.fLPBase.SuspendLayout();
            this.tabMainMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMainMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMainMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMainMat)).BeginInit();
            this.fLPMainMat.SuspendLayout();
            this.tabProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.fLPProcess.SuspendLayout();
            this.tabAlloy.SuspendLayout();
            this.hmiRootPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat_Alloy_Add_Man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat_Alloy_Add_Man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAlloy)).BeginInit();
            this.bdAlloy.SuspendLayout();
            this.fLPAlloy.SuspendLayout();
            this.tabSumAddition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSumAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSumAddition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSumAddition)).BeginInit();
            this.tabChemical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataLogMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDataLogMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnChemical)).BeginInit();
            this.bnChemical.SuspendLayout();
            this.fLPChemical.SuspendLayout();
            this.tabBottomBlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBottomBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBottomBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBottomBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBottomBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBottomBlow)).BeginInit();
            this.bnBottomBlow.SuspendLayout();
            this.fLPBottomBlow.SuspendLayout();
            this.tabTopBlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTopBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTopBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopBlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTopBlow)).BeginInit();
            this.bnTopBlow.SuspendLayout();
            this.fLPTopBlow.SuspendLayout();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).BeginInit();
            this.bnStatus.SuspendLayout();
            this.fLPStatus.SuspendLayout();
            this.tabTemp.SuspendLayout();
            this.hmiRootPanel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFTempMode1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).BeginInit();
            this.bnTemp.SuspendLayout();
            this.fLPTemp.SuspendLayout();
            this.tabExcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).BeginInit();
            this.fLPExcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcept)).BeginInit();
            this.bdExcept.SuspendLayout();
            this.tabRemark.SuspendLayout();
            this.hmiRootPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).BeginInit();
            this.bnRemark.SuspendLayout();
            this.fLPRemark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulk_Add_Man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulk_Add_Man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFUnitStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFUnitStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuneFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuneFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFurnaceLineStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFurnaceLineStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlowMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlowMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire_Add_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire_Add_man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFTempMode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.txtHeatID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 29);
            this.panel3.TabIndex = 85;
            // 
            // txtHeatID
            // 
            this.txtHeatID.Enabled = false;
            this.txtHeatID.EnableNull = false;
            this.txtHeatID.ErropPr = this.errorProvider1;
            this.txtHeatID.Length = 0;
            this.txtHeatID.Location = new System.Drawing.Point(64, 3);
            this.txtHeatID.Max = 0;
            this.txtHeatID.MaxStrLength = 0;
            this.txtHeatID.Min = 0;
            this.txtHeatID.MinStrLength = 0;
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Precision = 0;
            this.txtHeatID.ReadOnly = true;
            this.txtHeatID.Size = new System.Drawing.Size(106, 21);
            this.txtHeatID.TabIndex = 74;
            this.txtHeatID.ToolTipValid = this.toolTip1;
            this.txtHeatID.ValidEable = true;
            this.txtHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtHeatID.TextChanged += new System.EventHandler(this.txtHeatID_TextChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "炉号：";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tabCtrlMain);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 29);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(973, 737);
            this.hmiRootPanel1.TabIndex = 86;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabBase);
            this.tabCtrlMain.Controls.Add(this.tabMainMat);
            this.tabCtrlMain.Controls.Add(this.tabProcess);
            this.tabCtrlMain.Controls.Add(this.tabAlloy);
            this.tabCtrlMain.Controls.Add(this.tabSumAddition);
            this.tabCtrlMain.Controls.Add(this.tabChemical);
            this.tabCtrlMain.Controls.Add(this.tabBottomBlow);
            this.tabCtrlMain.Controls.Add(this.tabTopBlow);
            this.tabCtrlMain.Controls.Add(this.tabStatus);
            this.tabCtrlMain.Controls.Add(this.tabTemp);
            this.tabCtrlMain.Controls.Add(this.tabExcept);
            this.tabCtrlMain.Controls.Add(this.tabRemark);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(973, 737);
            this.tabCtrlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabCtrlMain.TabIndex = 0;
            this.tabCtrlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlMain_Selected);
            // 
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.cmbShift);
            this.tabBase.Controls.Add(this.cmbTeam);
            this.tabBase.Controls.Add(this.dateTimePicker5);
            this.tabBase.Controls.Add(this.label10);
            this.tabBase.Controls.Add(this.tbxSecondHand);
            this.tabBase.Controls.Add(this.label9);
            this.tabBase.Controls.Add(this.tbxAssistant);
            this.tabBase.Controls.Add(this.label7);
            this.tabBase.Controls.Add(this.tbxHeadFurnace);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.label3);
            this.tabBase.Controls.Add(this.tbxSteelGradeIndex);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.tbxPreHeatID);
            this.tabBase.Controls.Add(this.label1);
            this.tabBase.Controls.Add(this.fLPBase);
            this.tabBase.Location = new System.Drawing.Point(4, 21);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(965, 712);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本数据";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // cmbShift
            // 
            this.cmbShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShift.BackColor = System.Drawing.SystemColors.Window;
            this.cmbShift.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Shift", true));
            this.cmbShift.DataSource = this.dsShift;
            this.cmbShift.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShift.EnableNull = true;
            this.cmbShift.ErropPr = null;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(257, 87);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(100, 20);
            this.cmbShift.TabIndex = 107;
            this.cmbShift.ToolTipValid = null;
            this.cmbShift.ValidEable = true;
            this.cmbShift.ValueMember = "L3DataTable.Code";
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
            this.dsBase.SourceURI = "XGMESLogic\\AODMag\\CAOD_Base_Data";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            this.dsBase.OnDataLoaded += new AppSvrHMI.Delegate_OnDataLoaded(this.dsBase_OnDataLoaded);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnProcessConfirm
            // 
            this.Adapter.SetAccessRight(this.btnProcessConfirm, "BOFCheck");
            this.btnProcessConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnProcessConfirm.Name = "btnProcessConfirm";
            this.btnProcessConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnProcessConfirm.TabIndex = 86;
            this.btnProcessConfirm.Text = "确认";
            this.btnProcessConfirm.UseVisualStyleBackColor = true;
            this.btnProcessConfirm.Click += new System.EventHandler(this.btnProcessConfirm_Click);
            // 
            // btnBaseConfirm
            // 
            this.Adapter.SetAccessRight(this.btnBaseConfirm, "BOFCheck");
            this.btnBaseConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnBaseConfirm.Name = "btnBaseConfirm";
            this.btnBaseConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnBaseConfirm.TabIndex = 86;
            this.btnBaseConfirm.Text = "确认";
            this.btnBaseConfirm.UseVisualStyleBackColor = true;
            this.btnBaseConfirm.Click += new System.EventHandler(this.btnBaseConfirm_Click);
            // 
            // btnRemarkConfirm
            // 
            this.Adapter.SetAccessRight(this.btnRemarkConfirm, "BOFCheck");
            this.btnRemarkConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnRemarkConfirm.Name = "btnRemarkConfirm";
            this.btnRemarkConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnRemarkConfirm.TabIndex = 86;
            this.btnRemarkConfirm.Text = "确认";
            this.btnRemarkConfirm.UseVisualStyleBackColor = true;
            this.btnRemarkConfirm.Visible = false;
            this.btnRemarkConfirm.Click += new System.EventHandler(this.btnRemarkConfirm_Click);
            // 
            // btnConfirmExcept
            // 
            this.Adapter.SetAccessRight(this.btnConfirmExcept, "BOFCheck");
            this.btnConfirmExcept.Location = new System.Drawing.Point(802, 3);
            this.btnConfirmExcept.Name = "btnConfirmExcept";
            this.btnConfirmExcept.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmExcept.TabIndex = 86;
            this.btnConfirmExcept.Text = "确认";
            this.btnConfirmExcept.UseVisualStyleBackColor = true;
            this.btnConfirmExcept.Click += new System.EventHandler(this.btnConfirmExcept_Click);
            // 
            // btnAddExcept
            // 
            this.Adapter.SetAccessRight(this.btnAddExcept, "BOFCheck");
            this.btnAddExcept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddExcept.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExcept.Image")));
            this.btnAddExcept.Name = "btnAddExcept";
            this.btnAddExcept.RightToLeftAutoMirrorImage = true;
            this.btnAddExcept.Size = new System.Drawing.Size(23, 22);
            this.btnAddExcept.Text = "新添";
            this.btnAddExcept.Click += new System.EventHandler(this.btnAddExcept_Click);
            // 
            // btnAddAlloy
            // 
            this.Adapter.SetAccessRight(this.btnAddAlloy, "BOFCheck");
            this.btnAddAlloy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddAlloy.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAlloy.Image")));
            this.btnAddAlloy.Name = "btnAddAlloy";
            this.btnAddAlloy.RightToLeftAutoMirrorImage = true;
            this.btnAddAlloy.Size = new System.Drawing.Size(23, 22);
            this.btnAddAlloy.Text = "新添";
            this.btnAddAlloy.Click += new System.EventHandler(this.btnAdAlloy_Click);
            // 
            // btnAlloyCanfirm
            // 
            this.Adapter.SetAccessRight(this.btnAlloyCanfirm, "BOFCheck");
            this.btnAlloyCanfirm.Location = new System.Drawing.Point(794, 3);
            this.btnAlloyCanfirm.Name = "btnAlloyCanfirm";
            this.btnAlloyCanfirm.Size = new System.Drawing.Size(75, 23);
            this.btnAlloyCanfirm.TabIndex = 86;
            this.btnAlloyCanfirm.Text = "确认";
            this.btnAlloyCanfirm.UseVisualStyleBackColor = true;
            this.btnAlloyCanfirm.Click += new System.EventHandler(this.btnAlloyConfirm_Click);
            // 
            // btnRemarkAdd
            // 
            this.Adapter.SetAccessRight(this.btnRemarkAdd, "BOFCheck");
            this.btnRemarkAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemarkAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnRemarkAdd.Image")));
            this.btnRemarkAdd.Name = "btnRemarkAdd";
            this.btnRemarkAdd.RightToLeftAutoMirrorImage = true;
            this.btnRemarkAdd.Size = new System.Drawing.Size(23, 22);
            this.btnRemarkAdd.Text = "新添";
            this.btnRemarkAdd.Click += new System.EventHandler(this.btnRemarkAdd_Click);
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableGUID,
            this.coldsBaseL3DataTableName,
            this.coldsBaseL3DataTableHeatID,
            this.coldsBaseL3DataTablePreHeatID,
            this.coldsBaseL3DataTableSteelGradeIndex,
            this.coldsBaseL3DataTableSteelGrade,
            this.coldsBaseL3DataTableShift,
            this.coldsBaseL3DataTableTeam,
            this.coldsBaseL3DataTableHeadFurnace,
            this.coldsBaseL3DataTableAssistant,
            this.coldsBaseL3DataTableSecondHand,
            this.coldsBaseL3DataTableProductionDate,
            this.coldsBaseL3DataTableStatisticsDate,
            this.coldsBaseL3DataTableLocked});
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
            // coldsBaseL3DataTableHeatID
            // 
            this.coldsBaseL3DataTableHeatID.Caption = "HeatID";
            this.coldsBaseL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBaseL3DataTableHeatID.Namespace = "";
            // 
            // coldsBaseL3DataTablePreHeatID
            // 
            this.coldsBaseL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsBaseL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsBaseL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsBaseL3DataTableSteelGradeIndex
            // 
            this.coldsBaseL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBaseL3DataTableSteelGrade
            // 
            this.coldsBaseL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsBaseL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsBaseL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsBaseL3DataTableShift
            // 
            this.coldsBaseL3DataTableShift.Caption = "Shift";
            this.coldsBaseL3DataTableShift.ColumnName = "Shift";
            this.coldsBaseL3DataTableShift.Namespace = "";
            // 
            // coldsBaseL3DataTableTeam
            // 
            this.coldsBaseL3DataTableTeam.Caption = "Team";
            this.coldsBaseL3DataTableTeam.ColumnName = "Team";
            this.coldsBaseL3DataTableTeam.Namespace = "";
            // 
            // coldsBaseL3DataTableHeadFurnace
            // 
            this.coldsBaseL3DataTableHeadFurnace.Caption = "HeadFurnace";
            this.coldsBaseL3DataTableHeadFurnace.ColumnName = "HeadFurnace";
            this.coldsBaseL3DataTableHeadFurnace.Namespace = "";
            // 
            // coldsBaseL3DataTableAssistant
            // 
            this.coldsBaseL3DataTableAssistant.Caption = "Assistant";
            this.coldsBaseL3DataTableAssistant.ColumnName = "Assistant";
            this.coldsBaseL3DataTableAssistant.Namespace = "";
            // 
            // coldsBaseL3DataTableSecondHand
            // 
            this.coldsBaseL3DataTableSecondHand.Caption = "SecondHand";
            this.coldsBaseL3DataTableSecondHand.ColumnName = "SecondHand";
            this.coldsBaseL3DataTableSecondHand.Namespace = "";
            // 
            // coldsBaseL3DataTableProductionDate
            // 
            this.coldsBaseL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableProductionDate.Namespace = "";
            // 
            // coldsBaseL3DataTableStatisticsDate
            // 
            this.coldsBaseL3DataTableStatisticsDate.Caption = "StatisticsDate";
            this.coldsBaseL3DataTableStatisticsDate.ColumnName = "StatisticsDate";
            this.coldsBaseL3DataTableStatisticsDate.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableStatisticsDate.Namespace = "";
            // 
            // coldsBaseL3DataTableLocked
            // 
            this.coldsBaseL3DataTableLocked.Caption = "Locked";
            this.coldsBaseL3DataTableLocked.ColumnName = "Locked";
            this.coldsBaseL3DataTableLocked.DataType = typeof(short);
            this.coldsBaseL3DataTableLocked.Namespace = "";
            // 
            // dsShift
            // 
            this.dsShift.AutoLoad = true;
            this.dsShift.AutoSubscribe = false;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = null;
            this.dsShift.InsertMethod = null;
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "Click";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "CODE_GROUP = \'ShiftID\'";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift.SubscribeTarget = null;
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "Click";
            this.dsShift.UpdateMethod = null;
            this.dsShift.UpdateTrigger = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTableCode,
            this.coldsShiftL3DataTableCode_Des});
            this.schemadsShift.TableName = "L3DataTable";
            // 
            // coldsShiftL3DataTableCode
            // 
            this.coldsShiftL3DataTableCode.Caption = "Code";
            this.coldsShiftL3DataTableCode.ColumnName = "Code";
            this.coldsShiftL3DataTableCode.Namespace = "";
            // 
            // coldsShiftL3DataTableCode_Des
            // 
            this.coldsShiftL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftL3DataTableCode_Des.Namespace = "";
            // 
            // cmbTeam
            // 
            this.cmbTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeam.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTeam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Team", true));
            this.cmbTeam.DataSource = this.dsTeam;
            this.cmbTeam.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeam.EnableNull = true;
            this.cmbTeam.ErropPr = null;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(257, 114);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(100, 20);
            this.cmbTeam.TabIndex = 107;
            this.cmbTeam.ToolTipValid = null;
            this.cmbTeam.ValidEable = true;
            this.cmbTeam.ValueMember = "L3DataTable.Code";
            this.cmbTeam.SelectedIndexChanged += new System.EventHandler(this.cmbTeam_SelectedIndexChanged);
            // 
            // dsTeam
            // 
            this.dsTeam.AutoLoad = true;
            this.dsTeam.AutoSubscribe = false;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = null;
            this.dsTeam.InsertMethod = null;
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "Click";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam.SubscribeTarget = null;
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "Click";
            this.dsTeam.UpdateMethod = null;
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTableCode,
            this.coldsTeamL3DataTableCode_Des});
            this.schemadsTeam.TableName = "L3DataTable";
            // 
            // coldsTeamL3DataTableCode
            // 
            this.coldsTeamL3DataTableCode.Caption = "Code";
            this.coldsTeamL3DataTableCode.ColumnName = "Code";
            this.coldsTeamL3DataTableCode.Namespace = "";
            // 
            // coldsTeamL3DataTableCode_Des
            // 
            this.coldsTeamL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamL3DataTableCode_Des.Namespace = "";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBase, "ProductionDate", true));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(437, 114);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker5.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 104;
            this.label10.Text = "生产日期:";
            // 
            // tbxSecondHand
            // 
            this.tbxSecondHand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SecondHand", true));
            this.tbxSecondHand.EnableNull = true;
            this.tbxSecondHand.ErropPr = null;
            this.tbxSecondHand.Length = 0;
            this.tbxSecondHand.Location = new System.Drawing.Point(437, 87);
            this.tbxSecondHand.Max = 0;
            this.tbxSecondHand.MaxStrLength = 0;
            this.tbxSecondHand.Min = 0;
            this.tbxSecondHand.MinStrLength = 0;
            this.tbxSecondHand.Name = "tbxSecondHand";
            this.tbxSecondHand.Precision = 0;
            this.tbxSecondHand.Size = new System.Drawing.Size(100, 21);
            this.tbxSecondHand.TabIndex = 103;
            this.tbxSecondHand.ToolTipValid = null;
            this.tbxSecondHand.ValidEable = true;
            this.tbxSecondHand.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 102;
            this.label9.Text = "二助手:";
            // 
            // tbxAssistant
            // 
            this.tbxAssistant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Assistant", true));
            this.tbxAssistant.EnableNull = true;
            this.tbxAssistant.ErropPr = null;
            this.tbxAssistant.Length = 0;
            this.tbxAssistant.Location = new System.Drawing.Point(437, 60);
            this.tbxAssistant.Max = 0;
            this.tbxAssistant.MaxStrLength = 0;
            this.tbxAssistant.Min = 0;
            this.tbxAssistant.MinStrLength = 0;
            this.tbxAssistant.Name = "tbxAssistant";
            this.tbxAssistant.Precision = 0;
            this.tbxAssistant.Size = new System.Drawing.Size(100, 21);
            this.tbxAssistant.TabIndex = 101;
            this.tbxAssistant.ToolTipValid = null;
            this.tbxAssistant.ValidEable = true;
            this.tbxAssistant.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 100;
            this.label7.Text = "一助手:";
            // 
            // tbxHeadFurnace
            // 
            this.tbxHeadFurnace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "HeadFurnace", true));
            this.tbxHeadFurnace.EnableNull = true;
            this.tbxHeadFurnace.ErropPr = null;
            this.tbxHeadFurnace.Length = 0;
            this.tbxHeadFurnace.Location = new System.Drawing.Point(437, 33);
            this.tbxHeadFurnace.Max = 0;
            this.tbxHeadFurnace.MaxStrLength = 0;
            this.tbxHeadFurnace.Min = 0;
            this.tbxHeadFurnace.MinStrLength = 0;
            this.tbxHeadFurnace.Name = "tbxHeadFurnace";
            this.tbxHeadFurnace.Precision = 0;
            this.tbxHeadFurnace.Size = new System.Drawing.Size(100, 21);
            this.tbxHeadFurnace.TabIndex = 99;
            this.tbxHeadFurnace.ToolTipValid = null;
            this.tbxHeadFurnace.ValidEable = true;
            this.tbxHeadFurnace.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 98;
            this.label5.Text = "炉长:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "班别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 94;
            this.label3.Text = "班次:";
            // 
            // tbxSteelGradeIndex
            // 
            this.tbxSteelGradeIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SteelGradeIndex", true));
            this.tbxSteelGradeIndex.EnableNull = false;
            this.tbxSteelGradeIndex.ErropPr = this.errorProvider1;
            this.tbxSteelGradeIndex.Length = 0;
            this.tbxSteelGradeIndex.Location = new System.Drawing.Point(257, 60);
            this.tbxSteelGradeIndex.Max = 0;
            this.tbxSteelGradeIndex.MaxStrLength = 0;
            this.tbxSteelGradeIndex.Min = 0;
            this.tbxSteelGradeIndex.MinStrLength = 0;
            this.tbxSteelGradeIndex.Name = "tbxSteelGradeIndex";
            this.tbxSteelGradeIndex.Precision = 0;
            this.tbxSteelGradeIndex.ReadOnly = true;
            this.tbxSteelGradeIndex.Size = new System.Drawing.Size(100, 21);
            this.tbxSteelGradeIndex.TabIndex = 93;
            this.tbxSteelGradeIndex.ToolTipValid = this.toolTip1;
            this.tbxSteelGradeIndex.ValidEable = true;
            this.tbxSteelGradeIndex.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "炼钢记号:";
            // 
            // tbxPreHeatID
            // 
            this.tbxPreHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "PreHeatID", true));
            this.tbxPreHeatID.EnableNull = false;
            this.tbxPreHeatID.ErropPr = this.errorProvider1;
            this.tbxPreHeatID.Length = 0;
            this.tbxPreHeatID.Location = new System.Drawing.Point(257, 33);
            this.tbxPreHeatID.Max = 0;
            this.tbxPreHeatID.MaxStrLength = 0;
            this.tbxPreHeatID.Min = 0;
            this.tbxPreHeatID.MinStrLength = 0;
            this.tbxPreHeatID.Name = "tbxPreHeatID";
            this.tbxPreHeatID.Precision = 0;
            this.tbxPreHeatID.ReadOnly = true;
            this.tbxPreHeatID.Size = new System.Drawing.Size(100, 21);
            this.tbxPreHeatID.TabIndex = 91;
            this.tbxPreHeatID.ToolTipValid = this.toolTip1;
            this.tbxPreHeatID.ValidEable = true;
            this.tbxPreHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 90;
            this.label1.Text = "预定炉号:";
            // 
            // fLPBase
            // 
            this.fLPBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPBase.Controls.Add(this.btnBaseCancel);
            this.fLPBase.Controls.Add(this.btnBaseConfirm);
            this.fLPBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPBase.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPBase.Location = new System.Drawing.Point(3, 674);
            this.fLPBase.Name = "fLPBase";
            this.fLPBase.Size = new System.Drawing.Size(957, 33);
            this.fLPBase.TabIndex = 89;
            // 
            // btnBaseCancel
            // 
            this.btnBaseCancel.Location = new System.Drawing.Point(875, 3);
            this.btnBaseCancel.Name = "btnBaseCancel";
            this.btnBaseCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBaseCancel.TabIndex = 87;
            this.btnBaseCancel.Text = "取消";
            this.btnBaseCancel.UseVisualStyleBackColor = true;
            this.btnBaseCancel.Click += new System.EventHandler(this.btnBaseCancel_Click);
            // 
            // tabMainMat
            // 
            this.tabMainMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMainMat.Controls.Add(this.label54);
            this.tabMainMat.Controls.Add(this.textBox1);
            this.tabMainMat.Controls.Add(this.tbxCr);
            this.tabMainMat.Controls.Add(this.label55);
            this.tabMainMat.Controls.Add(this.tbxIronTemp);
            this.tabMainMat.Controls.Add(this.label19);
            this.tabMainMat.Controls.Add(this.tbxS);
            this.tabMainMat.Controls.Add(this.label22);
            this.tabMainMat.Controls.Add(this.tbxP);
            this.tabMainMat.Controls.Add(this.label11);
            this.tabMainMat.Controls.Add(this.tbxMn);
            this.tabMainMat.Controls.Add(this.label12);
            this.tabMainMat.Controls.Add(this.tbxSi);
            this.tabMainMat.Controls.Add(this.label13);
            this.tabMainMat.Controls.Add(this.tbxC);
            this.tabMainMat.Controls.Add(this.label14);
            this.tabMainMat.Controls.Add(this.tbxReHeatAmount);
            this.tabMainMat.Controls.Add(this.label15);
            this.tabMainMat.Controls.Add(this.tbxPigIronWeight);
            this.tabMainMat.Controls.Add(this.label16);
            this.tabMainMat.Controls.Add(this.tbxScrapWeight);
            this.tabMainMat.Controls.Add(this.label17);
            this.tabMainMat.Controls.Add(this.tbxIronWeight);
            this.tabMainMat.Controls.Add(this.label18);
            this.tabMainMat.Controls.Add(this.fLPMainMat);
            this.tabMainMat.Location = new System.Drawing.Point(4, 21);
            this.tabMainMat.Name = "tabMainMat";
            this.tabMainMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMat.Size = new System.Drawing.Size(965, 712);
            this.tabMainMat.TabIndex = 5;
            this.tabMainMat.Text = "主原料数据";
            this.tabMainMat.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(73, 160);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 12);
            this.label54.TabIndex = 136;
            this.label54.Text = "天车名称:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Return_SteelGrade", true));
            this.textBox1.Location = new System.Drawing.Point(138, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 135;
            // 
            // bsMainMat
            // 
            this.bsMainMat.DataMember = "L3DataTable";
            this.bsMainMat.DataSource = this.dsMainMat;
            // 
            // dsMainMat
            // 
            this.dsMainMat.AutoLoad = true;
            this.dsMainMat.AutoSubscribe = false;
            this.dsMainMat.DataSetName = "L3DataSet";
            this.dsMainMat.DeleteMethod = null;
            this.dsMainMat.InsertMethod = null;
            this.dsMainMat.L3DataAdapter = null;
            this.dsMainMat.LoadEvent = "Click";
            this.dsMainMat.LoadTrigger = null;
            this.dsMainMat.RefreshValve = 1000;
            this.dsMainMat.SourceCommand = null;
            this.dsMainMat.SourceCondition = "";
            this.dsMainMat.SourceMethod = "";
            this.dsMainMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMainMat.SourceURI = "XGMESLogic\\AODMag\\CAOD_Feed_Data";
            this.dsMainMat.SubscribeTarget = null;
            this.dsMainMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMainMat});
            this.dsMainMat.UpdateEvent = "Click";
            this.dsMainMat.UpdateMethod = null;
            this.dsMainMat.UpdateTrigger = null;
            this.dsMainMat.OnDataLoaded += new AppSvrHMI.Delegate_OnDataLoaded(this.dsMainMat_OnDataLoaded);
            // 
            // schemadsMainMat
            // 
            this.schemadsMainMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainMatL3DataTableHeatID,
            this.coldsMainMatL3DataTableIronWeight,
            this.coldsMainMatL3DataTableScrapWeight,
            this.coldsMainMatL3DataTablePigIronWeight,
            this.coldsMainMatL3DataTableReHeatAmount,
            this.coldsMainMatL3DataTableC,
            this.coldsMainMatL3DataTableSi,
            this.coldsMainMatL3DataTableMn,
            this.coldsMainMatL3DataTableP,
            this.coldsMainMatL3DataTableS,
            this.coldsMainMatL3DataTableTi,
            this.coldsMainMatL3DataTableIronTemp,
            this.coldsMainMatL3DataTableGUID,
            this.coldsMainMatL3DataTableName,
            this.coldsMainMatL3DataTableReturn_Steel_Weight,
            this.coldsMainMatL3DataTableCr,
            this.coldsMainMatL3DataTableReturn_SteelGrade});
            this.schemadsMainMat.TableName = "L3DataTable";
            // 
            // coldsMainMatL3DataTableHeatID
            // 
            this.coldsMainMatL3DataTableHeatID.Caption = "HeatID";
            this.coldsMainMatL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMainMatL3DataTableHeatID.Namespace = "";
            // 
            // coldsMainMatL3DataTableIronWeight
            // 
            this.coldsMainMatL3DataTableIronWeight.Caption = "IronWeight";
            this.coldsMainMatL3DataTableIronWeight.ColumnName = "IronWeight";
            this.coldsMainMatL3DataTableIronWeight.DataType = typeof(float);
            this.coldsMainMatL3DataTableIronWeight.Namespace = "";
            // 
            // coldsMainMatL3DataTableScrapWeight
            // 
            this.coldsMainMatL3DataTableScrapWeight.Caption = "ScrapWeight";
            this.coldsMainMatL3DataTableScrapWeight.ColumnName = "ScrapWeight";
            this.coldsMainMatL3DataTableScrapWeight.DataType = typeof(float);
            this.coldsMainMatL3DataTableScrapWeight.Namespace = "";
            // 
            // coldsMainMatL3DataTablePigIronWeight
            // 
            this.coldsMainMatL3DataTablePigIronWeight.Caption = "PigIronWeight";
            this.coldsMainMatL3DataTablePigIronWeight.ColumnName = "PigIronWeight";
            this.coldsMainMatL3DataTablePigIronWeight.DataType = typeof(float);
            this.coldsMainMatL3DataTablePigIronWeight.Namespace = "";
            // 
            // coldsMainMatL3DataTableReHeatAmount
            // 
            this.coldsMainMatL3DataTableReHeatAmount.Caption = "ReHeatAmount";
            this.coldsMainMatL3DataTableReHeatAmount.ColumnName = "ReHeatAmount";
            this.coldsMainMatL3DataTableReHeatAmount.DataType = typeof(float);
            this.coldsMainMatL3DataTableReHeatAmount.Namespace = "";
            // 
            // coldsMainMatL3DataTableC
            // 
            this.coldsMainMatL3DataTableC.Caption = "C";
            this.coldsMainMatL3DataTableC.ColumnName = "C";
            this.coldsMainMatL3DataTableC.DataType = typeof(float);
            this.coldsMainMatL3DataTableC.Namespace = "";
            // 
            // coldsMainMatL3DataTableSi
            // 
            this.coldsMainMatL3DataTableSi.Caption = "Si";
            this.coldsMainMatL3DataTableSi.ColumnName = "Si";
            this.coldsMainMatL3DataTableSi.DataType = typeof(float);
            this.coldsMainMatL3DataTableSi.Namespace = "";
            // 
            // coldsMainMatL3DataTableMn
            // 
            this.coldsMainMatL3DataTableMn.Caption = "Mn";
            this.coldsMainMatL3DataTableMn.ColumnName = "Mn";
            this.coldsMainMatL3DataTableMn.DataType = typeof(float);
            this.coldsMainMatL3DataTableMn.Namespace = "";
            // 
            // coldsMainMatL3DataTableP
            // 
            this.coldsMainMatL3DataTableP.Caption = "P";
            this.coldsMainMatL3DataTableP.ColumnName = "P";
            this.coldsMainMatL3DataTableP.DataType = typeof(float);
            this.coldsMainMatL3DataTableP.Namespace = "";
            // 
            // coldsMainMatL3DataTableS
            // 
            this.coldsMainMatL3DataTableS.Caption = "S";
            this.coldsMainMatL3DataTableS.ColumnName = "S";
            this.coldsMainMatL3DataTableS.DataType = typeof(float);
            this.coldsMainMatL3DataTableS.Namespace = "";
            // 
            // coldsMainMatL3DataTableTi
            // 
            this.coldsMainMatL3DataTableTi.Caption = "Ti";
            this.coldsMainMatL3DataTableTi.ColumnName = "Ti";
            this.coldsMainMatL3DataTableTi.DataType = typeof(float);
            this.coldsMainMatL3DataTableTi.Namespace = "";
            // 
            // coldsMainMatL3DataTableIronTemp
            // 
            this.coldsMainMatL3DataTableIronTemp.Caption = "IronTemp";
            this.coldsMainMatL3DataTableIronTemp.ColumnName = "IronTemp";
            this.coldsMainMatL3DataTableIronTemp.DataType = typeof(int);
            this.coldsMainMatL3DataTableIronTemp.Namespace = "";
            // 
            // coldsMainMatL3DataTableGUID
            // 
            this.coldsMainMatL3DataTableGUID.Caption = "GUID";
            this.coldsMainMatL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainMatL3DataTableGUID.Namespace = "";
            // 
            // coldsMainMatL3DataTableName
            // 
            this.coldsMainMatL3DataTableName.Caption = "Name";
            this.coldsMainMatL3DataTableName.ColumnName = "Name";
            this.coldsMainMatL3DataTableName.Namespace = "";
            // 
            // coldsMainMatL3DataTableReturn_Steel_Weight
            // 
            this.coldsMainMatL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsMainMatL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsMainMatL3DataTableReturn_Steel_Weight.DataType = typeof(double);
            this.coldsMainMatL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // coldsMainMatL3DataTableCr
            // 
            this.coldsMainMatL3DataTableCr.Caption = "Cr";
            this.coldsMainMatL3DataTableCr.ColumnName = "Cr";
            this.coldsMainMatL3DataTableCr.Namespace = "";
            // 
            // coldsMainMatL3DataTableReturn_SteelGrade
            // 
            this.coldsMainMatL3DataTableReturn_SteelGrade.Caption = "Return_SteelGrade";
            this.coldsMainMatL3DataTableReturn_SteelGrade.ColumnName = "Return_SteelGrade";
            this.coldsMainMatL3DataTableReturn_SteelGrade.Namespace = "";
            // 
            // tbxCr
            // 
            this.tbxCr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Cr", true));
            this.tbxCr.EnableNull = false;
            this.tbxCr.ErropPr = this.errorProvider1;
            this.tbxCr.Length = 0;
            this.tbxCr.Location = new System.Drawing.Point(760, 157);
            this.tbxCr.Max = 5;
            this.tbxCr.MaxStrLength = 0;
            this.tbxCr.Min = 0;
            this.tbxCr.MinStrLength = 0;
            this.tbxCr.Name = "tbxCr";
            this.tbxCr.Precision = 0;
            this.tbxCr.ReadOnly = true;
            this.tbxCr.Size = new System.Drawing.Size(100, 21);
            this.tbxCr.TabIndex = 134;
            this.tbxCr.ToolTipValid = this.toolTip1;
            this.tbxCr.ValidEable = true;
            this.tbxCr.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(689, 160);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 12);
            this.label55.TabIndex = 133;
            this.label55.Text = "铬成份[%]:";
            // 
            // tbxIronTemp
            // 
            this.tbxIronTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "IronTemp", true));
            this.tbxIronTemp.EnableNull = false;
            this.tbxIronTemp.ErropPr = this.errorProvider1;
            this.tbxIronTemp.Length = 0;
            this.tbxIronTemp.Location = new System.Drawing.Point(352, 85);
            this.tbxIronTemp.Max = 2000;
            this.tbxIronTemp.MaxStrLength = 0;
            this.tbxIronTemp.Min = 0;
            this.tbxIronTemp.MinStrLength = 0;
            this.tbxIronTemp.Name = "tbxIronTemp";
            this.tbxIronTemp.Precision = 0;
            this.tbxIronTemp.ReadOnly = true;
            this.tbxIronTemp.Size = new System.Drawing.Size(100, 21);
            this.tbxIronTemp.TabIndex = 129;
            this.tbxIronTemp.ToolTipValid = this.toolTip1;
            this.tbxIronTemp.ValidEable = true;
            this.tbxIronTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(263, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 128;
            this.label19.Text = "铁水温度[℃]:";
            // 
            // tbxS
            // 
            this.tbxS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "S", true));
            this.tbxS.EnableNull = false;
            this.tbxS.ErropPr = this.errorProvider1;
            this.tbxS.Length = 0;
            this.tbxS.Location = new System.Drawing.Point(760, 88);
            this.tbxS.Max = 5;
            this.tbxS.MaxStrLength = 0;
            this.tbxS.Min = 0;
            this.tbxS.MinStrLength = 0;
            this.tbxS.Name = "tbxS";
            this.tbxS.Precision = 0;
            this.tbxS.ReadOnly = true;
            this.tbxS.Size = new System.Drawing.Size(100, 21);
            this.tbxS.TabIndex = 123;
            this.tbxS.ToolTipValid = this.toolTip1;
            this.tbxS.ValidEable = true;
            this.tbxS.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(689, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 122;
            this.label22.Text = "硫成份[%]:";
            // 
            // tbxP
            // 
            this.tbxP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "P", true));
            this.tbxP.EnableNull = false;
            this.tbxP.ErropPr = this.errorProvider1;
            this.tbxP.Length = 0;
            this.tbxP.Location = new System.Drawing.Point(760, 124);
            this.tbxP.Max = 5;
            this.tbxP.MaxStrLength = 0;
            this.tbxP.Min = 0;
            this.tbxP.MinStrLength = 0;
            this.tbxP.Name = "tbxP";
            this.tbxP.Precision = 0;
            this.tbxP.ReadOnly = true;
            this.tbxP.Size = new System.Drawing.Size(100, 21);
            this.tbxP.TabIndex = 7;
            this.tbxP.ToolTipValid = this.toolTip1;
            this.tbxP.ValidEable = true;
            this.tbxP.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 120;
            this.label11.Text = "磷成份[%]:";
            // 
            // tbxMn
            // 
            this.tbxMn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Mn", true));
            this.tbxMn.EnableNull = false;
            this.tbxMn.ErropPr = this.errorProvider1;
            this.tbxMn.Length = 0;
            this.tbxMn.Location = new System.Drawing.Point(559, 157);
            this.tbxMn.Max = 5;
            this.tbxMn.MaxStrLength = 0;
            this.tbxMn.Min = 0;
            this.tbxMn.MinStrLength = 0;
            this.tbxMn.Name = "tbxMn";
            this.tbxMn.Precision = 0;
            this.tbxMn.ReadOnly = true;
            this.tbxMn.Size = new System.Drawing.Size(100, 21);
            this.tbxMn.TabIndex = 6;
            this.tbxMn.ToolTipValid = this.toolTip1;
            this.tbxMn.ValidEable = true;
            this.tbxMn.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 118;
            this.label12.Text = "锰成份[%]:";
            // 
            // tbxSi
            // 
            this.tbxSi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Si", true));
            this.tbxSi.EnableNull = false;
            this.tbxSi.ErropPr = this.errorProvider1;
            this.tbxSi.Length = 0;
            this.tbxSi.Location = new System.Drawing.Point(559, 121);
            this.tbxSi.Max = 5;
            this.tbxSi.MaxStrLength = 0;
            this.tbxSi.Min = 0;
            this.tbxSi.MinStrLength = 0;
            this.tbxSi.Name = "tbxSi";
            this.tbxSi.Precision = 0;
            this.tbxSi.ReadOnly = true;
            this.tbxSi.Size = new System.Drawing.Size(100, 21);
            this.tbxSi.TabIndex = 5;
            this.tbxSi.ToolTipValid = this.toolTip1;
            this.tbxSi.ValidEable = true;
            this.tbxSi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(488, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 116;
            this.label13.Text = "硅成份[%]:";
            // 
            // tbxC
            // 
            this.tbxC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "C", true));
            this.tbxC.EnableNull = false;
            this.tbxC.ErropPr = this.errorProvider1;
            this.tbxC.Length = 0;
            this.tbxC.Location = new System.Drawing.Point(559, 88);
            this.tbxC.Max = 5;
            this.tbxC.MaxStrLength = 0;
            this.tbxC.Min = 0;
            this.tbxC.MinStrLength = 0;
            this.tbxC.Name = "tbxC";
            this.tbxC.Precision = 0;
            this.tbxC.ReadOnly = true;
            this.tbxC.Size = new System.Drawing.Size(100, 21);
            this.tbxC.TabIndex = 4;
            this.tbxC.ToolTipValid = this.toolTip1;
            this.tbxC.ValidEable = true;
            this.tbxC.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(488, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 114;
            this.label14.Text = "碳成份[%]:";
            // 
            // tbxReHeatAmount
            // 
            this.tbxReHeatAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Return_Steel_Weight", true));
            this.tbxReHeatAmount.EnableNull = false;
            this.tbxReHeatAmount.ErropPr = this.errorProvider1;
            this.tbxReHeatAmount.Length = 0;
            this.tbxReHeatAmount.Location = new System.Drawing.Point(352, 157);
            this.tbxReHeatAmount.Max = 11;
            this.tbxReHeatAmount.MaxStrLength = 0;
            this.tbxReHeatAmount.Min = 0;
            this.tbxReHeatAmount.MinStrLength = 0;
            this.tbxReHeatAmount.Name = "tbxReHeatAmount";
            this.tbxReHeatAmount.Precision = 0;
            this.tbxReHeatAmount.Size = new System.Drawing.Size(100, 21);
            this.tbxReHeatAmount.TabIndex = 3;
            this.tbxReHeatAmount.ToolTipValid = this.toolTip1;
            this.tbxReHeatAmount.ValidEable = true;
            this.tbxReHeatAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(275, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 112;
            this.label15.Text = "修磨屑[Kg]:";
            // 
            // tbxPigIronWeight
            // 
            this.tbxPigIronWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "PigIronWeight", true));
            this.tbxPigIronWeight.EnableNull = false;
            this.tbxPigIronWeight.ErropPr = this.errorProvider1;
            this.tbxPigIronWeight.Length = 0;
            this.tbxPigIronWeight.Location = new System.Drawing.Point(352, 121);
            this.tbxPigIronWeight.Max = 11;
            this.tbxPigIronWeight.MaxStrLength = 0;
            this.tbxPigIronWeight.Min = 0;
            this.tbxPigIronWeight.MinStrLength = 0;
            this.tbxPigIronWeight.Name = "tbxPigIronWeight";
            this.tbxPigIronWeight.Precision = 0;
            this.tbxPigIronWeight.Size = new System.Drawing.Size(100, 21);
            this.tbxPigIronWeight.TabIndex = 2;
            this.tbxPigIronWeight.ToolTipValid = this.toolTip1;
            this.tbxPigIronWeight.ValidEable = true;
            this.tbxPigIronWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(287, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 110;
            this.label16.Text = "渣钢[Kg]:";
            // 
            // tbxScrapWeight
            // 
            this.tbxScrapWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "ScrapWeight", true));
            this.tbxScrapWeight.EnableNull = false;
            this.tbxScrapWeight.ErropPr = this.errorProvider1;
            this.tbxScrapWeight.Length = 0;
            this.tbxScrapWeight.Location = new System.Drawing.Point(138, 121);
            this.tbxScrapWeight.Max = 99;
            this.tbxScrapWeight.MaxStrLength = 0;
            this.tbxScrapWeight.Min = 0;
            this.tbxScrapWeight.MinStrLength = 0;
            this.tbxScrapWeight.Name = "tbxScrapWeight";
            this.tbxScrapWeight.Precision = 0;
            this.tbxScrapWeight.Size = new System.Drawing.Size(100, 21);
            this.tbxScrapWeight.TabIndex = 1;
            this.tbxScrapWeight.ToolTipValid = this.toolTip1;
            this.tbxScrapWeight.ValidEable = true;
            this.tbxScrapWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 12);
            this.label17.TabIndex = 108;
            this.label17.Text = "天车称重铁水[T]:";
            // 
            // tbxIronWeight
            // 
            this.tbxIronWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "IronWeight", true));
            this.tbxIronWeight.EnableNull = false;
            this.tbxIronWeight.ErropPr = this.errorProvider1;
            this.tbxIronWeight.Length = 0;
            this.tbxIronWeight.Location = new System.Drawing.Point(138, 85);
            this.tbxIronWeight.Max = 99;
            this.tbxIronWeight.MaxStrLength = 0;
            this.tbxIronWeight.Min = 0;
            this.tbxIronWeight.MinStrLength = 0;
            this.tbxIronWeight.Name = "tbxIronWeight";
            this.tbxIronWeight.Precision = 0;
            this.tbxIronWeight.ReadOnly = true;
            this.tbxIronWeight.Size = new System.Drawing.Size(100, 21);
            this.tbxIronWeight.TabIndex = 0;
            this.tbxIronWeight.ToolTipValid = this.toolTip1;
            this.tbxIronWeight.ValidEable = true;
            this.tbxIronWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 12);
            this.label18.TabIndex = 106;
            this.label18.Text = "脱磷发送铁水量[T]:";
            // 
            // fLPMainMat
            // 
            this.fLPMainMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPMainMat.Controls.Add(this.btnMainMatCancel);
            this.fLPMainMat.Controls.Add(this.btnMainMatConfirm);
            this.fLPMainMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPMainMat.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPMainMat.Location = new System.Drawing.Point(3, 674);
            this.fLPMainMat.Name = "fLPMainMat";
            this.fLPMainMat.Size = new System.Drawing.Size(957, 33);
            this.fLPMainMat.TabIndex = 90;
            // 
            // btnMainMatCancel
            // 
            this.btnMainMatCancel.Location = new System.Drawing.Point(875, 3);
            this.btnMainMatCancel.Name = "btnMainMatCancel";
            this.btnMainMatCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMainMatCancel.TabIndex = 87;
            this.btnMainMatCancel.Text = "取消";
            this.btnMainMatCancel.UseVisualStyleBackColor = true;
            this.btnMainMatCancel.Click += new System.EventHandler(this.btnMainMatCancel_Click);
            // 
            // btnMainMatConfirm
            // 
            this.btnMainMatConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnMainMatConfirm.Name = "btnMainMatConfirm";
            this.btnMainMatConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnMainMatConfirm.TabIndex = 86;
            this.btnMainMatConfirm.Text = "确认";
            this.btnMainMatConfirm.UseVisualStyleBackColor = true;
            this.btnMainMatConfirm.Click += new System.EventHandler(this.btnMainMatConfirm_Click);
            // 
            // tabProcess
            // 
            this.tabProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProcess.Controls.Add(this.pxTextBox8);
            this.tabProcess.Controls.Add(this.label21);
            this.tabProcess.Controls.Add(this.label52);
            this.tabProcess.Controls.Add(this.cmbScrapStatus);
            this.tabProcess.Controls.Add(this.groupBox6);
            this.tabProcess.Controls.Add(this.groupBox2);
            this.tabProcess.Controls.Add(this.pxTextBox1);
            this.tabProcess.Controls.Add(this.label20);
            this.tabProcess.Controls.Add(this.dateTimePicker1);
            this.tabProcess.Controls.Add(this.label8);
            this.tabProcess.Controls.Add(this.cmbLadleGrade);
            this.tabProcess.Controls.Add(this.txtTappingWeight);
            this.tabProcess.Controls.Add(this.label43);
            this.tabProcess.Controls.Add(this.txtTapholeLife);
            this.tabProcess.Controls.Add(this.label44);
            this.tabProcess.Controls.Add(this.label39);
            this.tabProcess.Controls.Add(this.txtLadleNo);
            this.tabProcess.Controls.Add(this.label40);
            this.tabProcess.Controls.Add(this.txtTappingTemp);
            this.tabProcess.Controls.Add(this.label36);
            this.tabProcess.Controls.Add(this.txtLaCTemp);
            this.tabProcess.Controls.Add(this.label37);
            this.tabProcess.Controls.Add(this.dtTappingEndTime);
            this.tabProcess.Controls.Add(this.dtTappingStartTime);
            this.tabProcess.Controls.Add(this.dtBlowStartTime);
            this.tabProcess.Controls.Add(this.dtChargingStartTime);
            this.tabProcess.Controls.Add(this.txtFurnaceAge);
            this.tabProcess.Controls.Add(this.label23);
            this.tabProcess.Controls.Add(this.txtLanceAge);
            this.tabProcess.Controls.Add(this.label24);
            this.tabProcess.Controls.Add(this.txtSmeltPeriod);
            this.tabProcess.Controls.Add(this.label26);
            this.tabProcess.Controls.Add(this.txtSplashingTime);
            this.tabProcess.Controls.Add(this.label27);
            this.tabProcess.Controls.Add(this.txtTappingTime);
            this.tabProcess.Controls.Add(this.label28);
            this.tabProcess.Controls.Add(this.label31);
            this.tabProcess.Controls.Add(this.label32);
            this.tabProcess.Controls.Add(this.label33);
            this.tabProcess.Controls.Add(this.label34);
            this.tabProcess.Controls.Add(this.fLPProcess);
            this.tabProcess.Location = new System.Drawing.Point(4, 21);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(965, 712);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "AOD数据";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(81, 237);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 12);
            this.label52.TabIndex = 205;
            this.label52.Text = "合金渣料检查:";
            // 
            // cmbScrapStatus
            // 
            this.cmbScrapStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbScrapStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbScrapStatus.BackColor = System.Drawing.SystemColors.Window;
            this.cmbScrapStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "ScrapStatus", true));
            this.cmbScrapStatus.EnableNull = true;
            this.cmbScrapStatus.ErropPr = null;
            this.cmbScrapStatus.FormattingEnabled = true;
            this.cmbScrapStatus.Items.AddRange(new object[] {
            "正常",
            "潮湿",
            "其它"});
            this.cmbScrapStatus.Location = new System.Drawing.Point(172, 234);
            this.cmbScrapStatus.Name = "cmbScrapStatus";
            this.cmbScrapStatus.Size = new System.Drawing.Size(62, 20);
            this.cmbScrapStatus.TabIndex = 204;
            this.cmbScrapStatus.ToolTipValid = null;
            this.cmbScrapStatus.ValidEable = true;
            // 
            // bsProcess
            // 
            this.bsProcess.DataMember = "L3DataTable";
            this.bsProcess.DataSource = this.dsProcess;
            // 
            // dsProcess
            // 
            this.dsProcess.AutoLoad = true;
            this.dsProcess.AutoSubscribe = false;
            this.dsProcess.DataSetName = "L3DataSet";
            this.dsProcess.DeleteMethod = null;
            this.dsProcess.InsertMethod = null;
            this.dsProcess.L3DataAdapter = null;
            this.dsProcess.LoadEvent = "Click";
            this.dsProcess.LoadTrigger = null;
            this.dsProcess.RefreshValve = 1000;
            this.dsProcess.SourceCommand = null;
            this.dsProcess.SourceCondition = "";
            this.dsProcess.SourceMethod = "";
            this.dsProcess.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcess.SourceURI = "XGMESLogic\\AODMag\\CAOD_Process_Data";
            this.dsProcess.SubscribeTarget = null;
            this.dsProcess.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcess});
            this.dsProcess.UpdateEvent = "Click";
            this.dsProcess.UpdateMethod = null;
            this.dsProcess.UpdateTrigger = null;
            // 
            // schemadsProcess
            // 
            this.schemadsProcess.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcessL3DataTableHeatID,
            this.coldsProcessL3DataTableCharging_Start_Time,
            this.coldsProcessL3DataTableBlow_Start_Time,
            this.coldsProcessL3DataTableTapping_Strat_Time,
            this.coldsProcessL3DataTableTapping_End_Time,
            this.coldsProcessL3DataTableBlowO2_Time,
            this.coldsProcessL3DataTableReBlow_Time,
            this.coldsProcessL3DataTableTapping_Time,
            this.coldsProcessL3DataTableSplashing_Time,
            this.coldsProcessL3DataTableSmelt_Period,
            this.coldsProcessL3DataTableWaiting_Time,
            this.coldsProcessL3DataTableLance_Age,
            this.coldsProcessL3DataTableFurnace_Age,
            this.coldsProcessL3DataTableReBlow_Count,
            this.coldsProcessL3DataTableLaC_Temp,
            this.coldsProcessL3DataTableTapping_Temp,
            this.coldsProcessL3DataTableSingle_LaC,
            this.coldsProcessL3DataTableTapping_Oxygen,
            this.coldsProcessL3DataTableLadleNo,
            this.coldsProcessL3DataTableLadle_Status,
            this.coldsProcessL3DataTableTaphole_Life,
            this.coldsProcessL3DataTableTapping_Weight,
            this.coldsProcessL3DataTableFurnace_Line_Status,
            this.coldsProcessL3DataTableLadle_Grade,
            this.coldsProcessL3DataTableScrapStatus,
            this.coldsProcessL3DataTableCarpolite,
            this.coldsProcessL3DataTableReturn_Start_Time,
            this.coldsProcessL3DataTableLadle_Stop,
            this.coldsProcessL3DataTableLanceNo,
            this.coldsProcessL3DataTableGUID,
            this.coldsProcessL3DataTableName,
            this.coldsProcessL3DataTableFurnaceNo,
            this.coldsProcessL3DataTableIn_Delay_Time,
            this.coldsProcessL3DataTableShebei_Delay_Time,
            this.coldsProcessL3DataTableJiezhi_Delay_Time,
            this.coldsProcessL3DataTableGongfu_Delay_Time,
            this.coldsProcessL3DataTableZhunbei_Delay_Time,
            this.coldsProcessL3DataTableJianxiu_Delay_Time,
            this.coldsProcessL3DataTableO2_Consume,
            this.coldsProcessL3DataTableN2_Consume,
            this.coldsProcessL3DataTableAr_Consume,
            this.coldsProcessL3DataTableN2_Ar_Consume,
            this.coldsProcessL3DataTableBlow_O2_Consume,
            this.coldsProcessL3DataTableDec1_O2_Consume,
            this.coldsProcessL3DataTableDec2_O2_Consume,
            this.coldsProcessL3DataTableCr2O3,
            this.coldsProcessL3DataTableLadle_Age});
            this.schemadsProcess.TableName = "L3DataTable";
            // 
            // coldsProcessL3DataTableHeatID
            // 
            this.coldsProcessL3DataTableHeatID.Caption = "HeatID";
            this.coldsProcessL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProcessL3DataTableHeatID.Namespace = "";
            // 
            // coldsProcessL3DataTableCharging_Start_Time
            // 
            this.coldsProcessL3DataTableCharging_Start_Time.Caption = "Charging_Start_Time";
            this.coldsProcessL3DataTableCharging_Start_Time.ColumnName = "Charging_Start_Time";
            this.coldsProcessL3DataTableCharging_Start_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableCharging_Start_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableBlow_Start_Time
            // 
            this.coldsProcessL3DataTableBlow_Start_Time.Caption = "Blow_Start_Time";
            this.coldsProcessL3DataTableBlow_Start_Time.ColumnName = "Blow_Start_Time";
            this.coldsProcessL3DataTableBlow_Start_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableBlow_Start_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableTapping_Strat_Time
            // 
            this.coldsProcessL3DataTableTapping_Strat_Time.Caption = "Tapping_Strat_Time";
            this.coldsProcessL3DataTableTapping_Strat_Time.ColumnName = "Tapping_Strat_Time";
            this.coldsProcessL3DataTableTapping_Strat_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableTapping_Strat_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableTapping_End_Time
            // 
            this.coldsProcessL3DataTableTapping_End_Time.Caption = "Tapping_End_Time";
            this.coldsProcessL3DataTableTapping_End_Time.ColumnName = "Tapping_End_Time";
            this.coldsProcessL3DataTableTapping_End_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableTapping_End_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableBlowO2_Time
            // 
            this.coldsProcessL3DataTableBlowO2_Time.Caption = "BlowO2_Time";
            this.coldsProcessL3DataTableBlowO2_Time.ColumnName = "BlowO2_Time";
            this.coldsProcessL3DataTableBlowO2_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableBlowO2_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableReBlow_Time
            // 
            this.coldsProcessL3DataTableReBlow_Time.Caption = "ReBlow_Time";
            this.coldsProcessL3DataTableReBlow_Time.ColumnName = "ReBlow_Time";
            this.coldsProcessL3DataTableReBlow_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableReBlow_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableTapping_Time
            // 
            this.coldsProcessL3DataTableTapping_Time.Caption = "Tapping_Time";
            this.coldsProcessL3DataTableTapping_Time.ColumnName = "Tapping_Time";
            this.coldsProcessL3DataTableTapping_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableTapping_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableSplashing_Time
            // 
            this.coldsProcessL3DataTableSplashing_Time.Caption = "Splashing_Time";
            this.coldsProcessL3DataTableSplashing_Time.ColumnName = "Splashing_Time";
            this.coldsProcessL3DataTableSplashing_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableSplashing_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableSmelt_Period
            // 
            this.coldsProcessL3DataTableSmelt_Period.Caption = "Smelt_Period";
            this.coldsProcessL3DataTableSmelt_Period.ColumnName = "Smelt_Period";
            this.coldsProcessL3DataTableSmelt_Period.DataType = typeof(int);
            this.coldsProcessL3DataTableSmelt_Period.Namespace = "";
            // 
            // coldsProcessL3DataTableWaiting_Time
            // 
            this.coldsProcessL3DataTableWaiting_Time.Caption = "Waiting_Time";
            this.coldsProcessL3DataTableWaiting_Time.ColumnName = "Waiting_Time";
            this.coldsProcessL3DataTableWaiting_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableWaiting_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableLance_Age
            // 
            this.coldsProcessL3DataTableLance_Age.Caption = "Lance_Age";
            this.coldsProcessL3DataTableLance_Age.ColumnName = "Lance_Age";
            this.coldsProcessL3DataTableLance_Age.DataType = typeof(int);
            this.coldsProcessL3DataTableLance_Age.Namespace = "";
            // 
            // coldsProcessL3DataTableFurnace_Age
            // 
            this.coldsProcessL3DataTableFurnace_Age.Caption = "Furnace_Age";
            this.coldsProcessL3DataTableFurnace_Age.ColumnName = "Furnace_Age";
            this.coldsProcessL3DataTableFurnace_Age.DataType = typeof(int);
            this.coldsProcessL3DataTableFurnace_Age.Namespace = "";
            // 
            // coldsProcessL3DataTableReBlow_Count
            // 
            this.coldsProcessL3DataTableReBlow_Count.Caption = "ReBlow_Count";
            this.coldsProcessL3DataTableReBlow_Count.ColumnName = "ReBlow_Count";
            this.coldsProcessL3DataTableReBlow_Count.DataType = typeof(bool);
            this.coldsProcessL3DataTableReBlow_Count.Namespace = "";
            // 
            // coldsProcessL3DataTableLaC_Temp
            // 
            this.coldsProcessL3DataTableLaC_Temp.Caption = "LaC_Temp";
            this.coldsProcessL3DataTableLaC_Temp.ColumnName = "LaC_Temp";
            this.coldsProcessL3DataTableLaC_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableLaC_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableTapping_Temp
            // 
            this.coldsProcessL3DataTableTapping_Temp.Caption = "Tapping_Temp";
            this.coldsProcessL3DataTableTapping_Temp.ColumnName = "Tapping_Temp";
            this.coldsProcessL3DataTableTapping_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableTapping_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableSingle_LaC
            // 
            this.coldsProcessL3DataTableSingle_LaC.Caption = "Single_LaC";
            this.coldsProcessL3DataTableSingle_LaC.ColumnName = "Single_LaC";
            this.coldsProcessL3DataTableSingle_LaC.DataType = typeof(bool);
            this.coldsProcessL3DataTableSingle_LaC.Namespace = "";
            // 
            // coldsProcessL3DataTableTapping_Oxygen
            // 
            this.coldsProcessL3DataTableTapping_Oxygen.Caption = "Tapping_Oxygen";
            this.coldsProcessL3DataTableTapping_Oxygen.ColumnName = "Tapping_Oxygen";
            this.coldsProcessL3DataTableTapping_Oxygen.DataType = typeof(float);
            this.coldsProcessL3DataTableTapping_Oxygen.Namespace = "";
            // 
            // coldsProcessL3DataTableLadleNo
            // 
            this.coldsProcessL3DataTableLadleNo.Caption = "LadleNo";
            this.coldsProcessL3DataTableLadleNo.ColumnName = "LadleNo";
            this.coldsProcessL3DataTableLadleNo.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Status
            // 
            this.coldsProcessL3DataTableLadle_Status.Caption = "Ladle_Status";
            this.coldsProcessL3DataTableLadle_Status.ColumnName = "Ladle_Status";
            this.coldsProcessL3DataTableLadle_Status.Namespace = "";
            // 
            // coldsProcessL3DataTableTaphole_Life
            // 
            this.coldsProcessL3DataTableTaphole_Life.Caption = "Taphole_Life";
            this.coldsProcessL3DataTableTaphole_Life.ColumnName = "Taphole_Life";
            this.coldsProcessL3DataTableTaphole_Life.DataType = typeof(int);
            this.coldsProcessL3DataTableTaphole_Life.Namespace = "";
            // 
            // coldsProcessL3DataTableTapping_Weight
            // 
            this.coldsProcessL3DataTableTapping_Weight.Caption = "Tapping_Weight";
            this.coldsProcessL3DataTableTapping_Weight.ColumnName = "Tapping_Weight";
            this.coldsProcessL3DataTableTapping_Weight.DataType = typeof(float);
            this.coldsProcessL3DataTableTapping_Weight.Namespace = "";
            // 
            // coldsProcessL3DataTableFurnace_Line_Status
            // 
            this.coldsProcessL3DataTableFurnace_Line_Status.Caption = "Furnace_Line_Status";
            this.coldsProcessL3DataTableFurnace_Line_Status.ColumnName = "Furnace_Line_Status";
            this.coldsProcessL3DataTableFurnace_Line_Status.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Grade
            // 
            this.coldsProcessL3DataTableLadle_Grade.Caption = "Ladle_Grade";
            this.coldsProcessL3DataTableLadle_Grade.ColumnName = "Ladle_Grade";
            this.coldsProcessL3DataTableLadle_Grade.Namespace = "";
            // 
            // coldsProcessL3DataTableScrapStatus
            // 
            this.coldsProcessL3DataTableScrapStatus.Caption = "ScrapStatus";
            this.coldsProcessL3DataTableScrapStatus.ColumnName = "ScrapStatus";
            this.coldsProcessL3DataTableScrapStatus.Namespace = "";
            // 
            // coldsProcessL3DataTableCarpolite
            // 
            this.coldsProcessL3DataTableCarpolite.Caption = "Carpolite";
            this.coldsProcessL3DataTableCarpolite.ColumnName = "Carpolite";
            this.coldsProcessL3DataTableCarpolite.DataType = typeof(float);
            this.coldsProcessL3DataTableCarpolite.Namespace = "";
            // 
            // coldsProcessL3DataTableReturn_Start_Time
            // 
            this.coldsProcessL3DataTableReturn_Start_Time.Caption = "Return_Start_Time";
            this.coldsProcessL3DataTableReturn_Start_Time.ColumnName = "Return_Start_Time";
            this.coldsProcessL3DataTableReturn_Start_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableReturn_Start_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Stop
            // 
            this.coldsProcessL3DataTableLadle_Stop.Caption = "Ladle_Stop";
            this.coldsProcessL3DataTableLadle_Stop.ColumnName = "Ladle_Stop";
            this.coldsProcessL3DataTableLadle_Stop.DataType = typeof(double);
            this.coldsProcessL3DataTableLadle_Stop.Namespace = "";
            // 
            // coldsProcessL3DataTableLanceNo
            // 
            this.coldsProcessL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsProcessL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsProcessL3DataTableLanceNo.DataType = typeof(int);
            this.coldsProcessL3DataTableLanceNo.Namespace = "";
            // 
            // coldsProcessL3DataTableGUID
            // 
            this.coldsProcessL3DataTableGUID.Caption = "GUID";
            this.coldsProcessL3DataTableGUID.ColumnName = "GUID";
            this.coldsProcessL3DataTableGUID.Namespace = "";
            // 
            // coldsProcessL3DataTableName
            // 
            this.coldsProcessL3DataTableName.Caption = "Name";
            this.coldsProcessL3DataTableName.ColumnName = "Name";
            this.coldsProcessL3DataTableName.Namespace = "";
            // 
            // coldsProcessL3DataTableFurnaceNo
            // 
            this.coldsProcessL3DataTableFurnaceNo.Caption = "FurnaceNo";
            this.coldsProcessL3DataTableFurnaceNo.ColumnName = "FurnaceNo";
            this.coldsProcessL3DataTableFurnaceNo.DataType = typeof(int);
            this.coldsProcessL3DataTableFurnaceNo.Namespace = "";
            // 
            // coldsProcessL3DataTableIn_Delay_Time
            // 
            this.coldsProcessL3DataTableIn_Delay_Time.Caption = "In_Delay_Time";
            this.coldsProcessL3DataTableIn_Delay_Time.ColumnName = "In_Delay_Time";
            this.coldsProcessL3DataTableIn_Delay_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableIn_Delay_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableShebei_Delay_Time
            // 
            this.coldsProcessL3DataTableShebei_Delay_Time.Caption = "Shebei_Delay_Time";
            this.coldsProcessL3DataTableShebei_Delay_Time.ColumnName = "Shebei_Delay_Time";
            this.coldsProcessL3DataTableShebei_Delay_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableShebei_Delay_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableJiezhi_Delay_Time
            // 
            this.coldsProcessL3DataTableJiezhi_Delay_Time.Caption = "Jiezhi_Delay_Time";
            this.coldsProcessL3DataTableJiezhi_Delay_Time.ColumnName = "Jiezhi_Delay_Time";
            this.coldsProcessL3DataTableJiezhi_Delay_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableJiezhi_Delay_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableGongfu_Delay_Time
            // 
            this.coldsProcessL3DataTableGongfu_Delay_Time.Caption = "Gongfu_Delay_Time";
            this.coldsProcessL3DataTableGongfu_Delay_Time.ColumnName = "Gongfu_Delay_Time";
            this.coldsProcessL3DataTableGongfu_Delay_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableGongfu_Delay_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableZhunbei_Delay_Time
            // 
            this.coldsProcessL3DataTableZhunbei_Delay_Time.Caption = "Zhunbei_Delay_Time";
            this.coldsProcessL3DataTableZhunbei_Delay_Time.ColumnName = "Zhunbei_Delay_Time";
            this.coldsProcessL3DataTableZhunbei_Delay_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableZhunbei_Delay_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableJianxiu_Delay_Time
            // 
            this.coldsProcessL3DataTableJianxiu_Delay_Time.Caption = "Jianxiu_Delay_Time";
            this.coldsProcessL3DataTableJianxiu_Delay_Time.ColumnName = "Jianxiu_Delay_Time";
            this.coldsProcessL3DataTableJianxiu_Delay_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableJianxiu_Delay_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableO2_Consume
            // 
            this.coldsProcessL3DataTableO2_Consume.Caption = "O2_Consume";
            this.coldsProcessL3DataTableO2_Consume.ColumnName = "O2_Consume";
            this.coldsProcessL3DataTableO2_Consume.DataType = typeof(float);
            this.coldsProcessL3DataTableO2_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableN2_Consume
            // 
            this.coldsProcessL3DataTableN2_Consume.Caption = "N2_Consume";
            this.coldsProcessL3DataTableN2_Consume.ColumnName = "N2_Consume";
            this.coldsProcessL3DataTableN2_Consume.DataType = typeof(float);
            this.coldsProcessL3DataTableN2_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableAr_Consume
            // 
            this.coldsProcessL3DataTableAr_Consume.Caption = "Ar_Consume";
            this.coldsProcessL3DataTableAr_Consume.ColumnName = "Ar_Consume";
            this.coldsProcessL3DataTableAr_Consume.DataType = typeof(float);
            this.coldsProcessL3DataTableAr_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableN2_Ar_Consume
            // 
            this.coldsProcessL3DataTableN2_Ar_Consume.Caption = "N2_Ar_Consume";
            this.coldsProcessL3DataTableN2_Ar_Consume.ColumnName = "N2_Ar_Consume";
            this.coldsProcessL3DataTableN2_Ar_Consume.DataType = typeof(float);
            this.coldsProcessL3DataTableN2_Ar_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableBlow_O2_Consume
            // 
            this.coldsProcessL3DataTableBlow_O2_Consume.Caption = "Blow_O2_Consume";
            this.coldsProcessL3DataTableBlow_O2_Consume.ColumnName = "Blow_O2_Consume";
            this.coldsProcessL3DataTableBlow_O2_Consume.DataType = typeof(float);
            this.coldsProcessL3DataTableBlow_O2_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableDec1_O2_Consume
            // 
            this.coldsProcessL3DataTableDec1_O2_Consume.Caption = "Dec1_O2_Consume";
            this.coldsProcessL3DataTableDec1_O2_Consume.ColumnName = "Dec1_O2_Consume";
            this.coldsProcessL3DataTableDec1_O2_Consume.DataType = typeof(float);
            this.coldsProcessL3DataTableDec1_O2_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableDec2_O2_Consume
            // 
            this.coldsProcessL3DataTableDec2_O2_Consume.Caption = "Dec2_O2_Consume";
            this.coldsProcessL3DataTableDec2_O2_Consume.ColumnName = "Dec2_O2_Consume";
            this.coldsProcessL3DataTableDec2_O2_Consume.DataType = typeof(float);
            this.coldsProcessL3DataTableDec2_O2_Consume.Namespace = "";
            // 
            // coldsProcessL3DataTableCr2O3
            // 
            this.coldsProcessL3DataTableCr2O3.Caption = "Cr2O3";
            this.coldsProcessL3DataTableCr2O3.ColumnName = "Cr2O3";
            this.coldsProcessL3DataTableCr2O3.DataType = typeof(float);
            this.coldsProcessL3DataTableCr2O3.Namespace = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.pxTextBox12);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.pxTextBox11);
            this.groupBox6.Controls.Add(this.label47);
            this.groupBox6.Controls.Add(this.pxTextBox10);
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.pxTextBox9);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Location = new System.Drawing.Point(489, 76);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(161, 310);
            this.groupBox6.TabIndex = 203;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "气体消耗";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pxTextBox15);
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.pxTextBox14);
            this.groupBox7.Controls.Add(this.label50);
            this.groupBox7.Controls.Add(this.pxTextBox13);
            this.groupBox7.Controls.Add(this.label49);
            this.groupBox7.Location = new System.Drawing.Point(0, 161);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(161, 149);
            this.groupBox7.TabIndex = 204;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "O2消耗";
            // 
            // pxTextBox15
            // 
            this.pxTextBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Dec2_O2_Consume", true));
            this.pxTextBox15.EnableNull = false;
            this.pxTextBox15.ErropPr = this.errorProvider1;
            this.pxTextBox15.Length = 0;
            this.pxTextBox15.Location = new System.Drawing.Point(72, 109);
            this.pxTextBox15.Max = 9999;
            this.pxTextBox15.MaxStrLength = 0;
            this.pxTextBox15.Min = 0;
            this.pxTextBox15.MinStrLength = 0;
            this.pxTextBox15.Name = "pxTextBox15";
            this.pxTextBox15.Precision = 0;
            this.pxTextBox15.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox15.TabIndex = 159;
            this.pxTextBox15.ToolTipValid = this.toolTip1;
            this.pxTextBox15.ValidEable = true;
            this.pxTextBox15.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(22, 112);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(35, 12);
            this.label51.TabIndex = 158;
            this.label51.Text = "DEC2:";
            // 
            // pxTextBox14
            // 
            this.pxTextBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Dec1_O2_Consume", true));
            this.pxTextBox14.EnableNull = false;
            this.pxTextBox14.ErropPr = this.errorProvider1;
            this.pxTextBox14.Length = 0;
            this.pxTextBox14.Location = new System.Drawing.Point(72, 72);
            this.pxTextBox14.Max = 9999;
            this.pxTextBox14.MaxStrLength = 0;
            this.pxTextBox14.Min = 0;
            this.pxTextBox14.MinStrLength = 0;
            this.pxTextBox14.Name = "pxTextBox14";
            this.pxTextBox14.Precision = 0;
            this.pxTextBox14.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox14.TabIndex = 157;
            this.pxTextBox14.ToolTipValid = this.toolTip1;
            this.pxTextBox14.ValidEable = true;
            this.pxTextBox14.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(22, 75);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(35, 12);
            this.label50.TabIndex = 156;
            this.label50.Text = "DEC1:";
            // 
            // pxTextBox13
            // 
            this.pxTextBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Blow_O2_Consume", true));
            this.pxTextBox13.EnableNull = false;
            this.pxTextBox13.ErropPr = this.errorProvider1;
            this.pxTextBox13.Length = 0;
            this.pxTextBox13.Location = new System.Drawing.Point(72, 32);
            this.pxTextBox13.Max = 9999;
            this.pxTextBox13.MaxStrLength = 0;
            this.pxTextBox13.Min = 0;
            this.pxTextBox13.MinStrLength = 0;
            this.pxTextBox13.Name = "pxTextBox13";
            this.pxTextBox13.Precision = 0;
            this.pxTextBox13.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox13.TabIndex = 155;
            this.pxTextBox13.ToolTipValid = this.toolTip1;
            this.pxTextBox13.ValidEable = true;
            this.pxTextBox13.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(7, 41);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(59, 12);
            this.label49.TabIndex = 154;
            this.label49.Text = "主吹提枪:";
            // 
            // pxTextBox12
            // 
            this.pxTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ar_Consume", true));
            this.pxTextBox12.EnableNull = false;
            this.pxTextBox12.ErropPr = this.errorProvider1;
            this.pxTextBox12.Length = 0;
            this.pxTextBox12.Location = new System.Drawing.Point(72, 95);
            this.pxTextBox12.Max = 9999;
            this.pxTextBox12.MaxStrLength = 0;
            this.pxTextBox12.Min = 0;
            this.pxTextBox12.MinStrLength = 0;
            this.pxTextBox12.Name = "pxTextBox12";
            this.pxTextBox12.Precision = 0;
            this.pxTextBox12.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox12.TabIndex = 159;
            this.pxTextBox12.ToolTipValid = this.toolTip1;
            this.pxTextBox12.ValidEable = true;
            this.pxTextBox12.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(28, 98);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(23, 12);
            this.label48.TabIndex = 158;
            this.label48.Text = "Ar:";
            // 
            // pxTextBox11
            // 
            this.pxTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "N2_Ar_Consume", true));
            this.pxTextBox11.EnableNull = false;
            this.pxTextBox11.ErropPr = this.errorProvider1;
            this.pxTextBox11.Length = 0;
            this.pxTextBox11.Location = new System.Drawing.Point(72, 134);
            this.pxTextBox11.Max = 9999;
            this.pxTextBox11.MaxStrLength = 0;
            this.pxTextBox11.Min = 0;
            this.pxTextBox11.MinStrLength = 0;
            this.pxTextBox11.Name = "pxTextBox11";
            this.pxTextBox11.Precision = 0;
            this.pxTextBox11.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox11.TabIndex = 157;
            this.pxTextBox11.ToolTipValid = this.toolTip1;
            this.pxTextBox11.ValidEable = true;
            this.pxTextBox11.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(11, 134);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 156;
            this.label47.Text = "N2→Ar:";
            // 
            // pxTextBox10
            // 
            this.pxTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "N2_Consume", true));
            this.pxTextBox10.EnableNull = false;
            this.pxTextBox10.ErropPr = this.errorProvider1;
            this.pxTextBox10.Length = 0;
            this.pxTextBox10.Location = new System.Drawing.Point(72, 56);
            this.pxTextBox10.Max = 9999;
            this.pxTextBox10.MaxStrLength = 0;
            this.pxTextBox10.Min = 0;
            this.pxTextBox10.MinStrLength = 0;
            this.pxTextBox10.Name = "pxTextBox10";
            this.pxTextBox10.Precision = 0;
            this.pxTextBox10.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox10.TabIndex = 155;
            this.pxTextBox10.ToolTipValid = this.toolTip1;
            this.pxTextBox10.ValidEable = true;
            this.pxTextBox10.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(28, 59);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(23, 12);
            this.label46.TabIndex = 154;
            this.label46.Text = "N2:";
            // 
            // pxTextBox9
            // 
            this.pxTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "O2_Consume", true));
            this.pxTextBox9.EnableNull = false;
            this.pxTextBox9.ErropPr = this.errorProvider1;
            this.pxTextBox9.Length = 0;
            this.pxTextBox9.Location = new System.Drawing.Point(72, 20);
            this.pxTextBox9.Max = 9999;
            this.pxTextBox9.MaxStrLength = 0;
            this.pxTextBox9.Min = 0;
            this.pxTextBox9.MinStrLength = 0;
            this.pxTextBox9.Name = "pxTextBox9";
            this.pxTextBox9.Precision = 0;
            this.pxTextBox9.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox9.TabIndex = 153;
            this.pxTextBox9.ToolTipValid = this.toolTip1;
            this.pxTextBox9.ValidEable = true;
            this.pxTextBox9.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(28, 23);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(23, 12);
            this.label45.TabIndex = 152;
            this.label45.Text = "O2:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.pxTextBox4);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new System.Drawing.Point(669, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 310);
            this.groupBox2.TabIndex = 200;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "影响时间";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pxTextBox6);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.pxTextBox7);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Location = new System.Drawing.Point(0, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 100);
            this.groupBox5.TabIndex = 151;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "计划";
            // 
            // pxTextBox6
            // 
            this.pxTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Jianxiu_Delay_Time", true));
            this.pxTextBox6.EnableNull = false;
            this.pxTextBox6.ErropPr = this.errorProvider1;
            this.pxTextBox6.Length = 0;
            this.pxTextBox6.Location = new System.Drawing.Point(130, 47);
            this.pxTextBox6.Max = 999;
            this.pxTextBox6.MaxStrLength = 0;
            this.pxTextBox6.Min = 0;
            this.pxTextBox6.MinStrLength = 0;
            this.pxTextBox6.Name = "pxTextBox6";
            this.pxTextBox6.Precision = 0;
            this.pxTextBox6.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox6.TabIndex = 157;
            this.pxTextBox6.ToolTipValid = this.toolTip1;
            this.pxTextBox6.ValidEable = true;
            this.pxTextBox6.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(76, 56);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 12);
            this.label38.TabIndex = 156;
            this.label38.Text = "检修:";
            // 
            // pxTextBox7
            // 
            this.pxTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Zhunbei_Delay_Time", true));
            this.pxTextBox7.EnableNull = false;
            this.pxTextBox7.ErropPr = this.errorProvider1;
            this.pxTextBox7.Length = 0;
            this.pxTextBox7.Location = new System.Drawing.Point(130, 20);
            this.pxTextBox7.Max = 999;
            this.pxTextBox7.MaxStrLength = 0;
            this.pxTextBox7.Min = 0;
            this.pxTextBox7.MinStrLength = 0;
            this.pxTextBox7.Name = "pxTextBox7";
            this.pxTextBox7.Precision = 0;
            this.pxTextBox7.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox7.TabIndex = 155;
            this.pxTextBox7.ToolTipValid = this.toolTip1;
            this.pxTextBox7.ValidEable = true;
            this.pxTextBox7.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(76, 29);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(35, 12);
            this.label41.TabIndex = 154;
            this.label41.Text = "准备:";
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "In_Delay_Time", true));
            this.pxTextBox4.EnableNull = false;
            this.pxTextBox4.ErropPr = this.errorProvider1;
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(130, 27);
            this.pxTextBox4.Max = 999;
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0;
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            this.pxTextBox4.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox4.TabIndex = 150;
            this.pxTextBox4.ToolTipValid = this.toolTip1;
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtWaitingTime);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.pxTextBox5);
            this.groupBox4.Controls.Add(this.label35);
            this.groupBox4.Controls.Add(this.pxTextBox3);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.pxTextBox2);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Location = new System.Drawing.Point(0, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 139);
            this.groupBox4.TabIndex = 149;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "外部影响时间";
            // 
            // txtWaitingTime
            // 
            this.txtWaitingTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Waiting_Time", true));
            this.txtWaitingTime.EnableNull = false;
            this.txtWaitingTime.ErropPr = this.errorProvider1;
            this.txtWaitingTime.Length = 0;
            this.txtWaitingTime.Location = new System.Drawing.Point(130, 114);
            this.txtWaitingTime.Max = 999;
            this.txtWaitingTime.MaxStrLength = 0;
            this.txtWaitingTime.Min = 0;
            this.txtWaitingTime.MinStrLength = 0;
            this.txtWaitingTime.Name = "txtWaitingTime";
            this.txtWaitingTime.Precision = 0;
            this.txtWaitingTime.Size = new System.Drawing.Size(64, 21);
            this.txtWaitingTime.TabIndex = 206;
            this.txtWaitingTime.ToolTipValid = this.toolTip1;
            this.txtWaitingTime.ValidEable = true;
            this.txtWaitingTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(35, 119);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(89, 12);
            this.label53.TabIndex = 207;
            this.label53.Text = "等节奏时间[\']:";
            // 
            // pxTextBox5
            // 
            this.pxTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Gongfu_Delay_Time", true));
            this.pxTextBox5.EnableNull = false;
            this.pxTextBox5.ErropPr = this.errorProvider1;
            this.pxTextBox5.Length = 0;
            this.pxTextBox5.Location = new System.Drawing.Point(130, 86);
            this.pxTextBox5.Max = 999;
            this.pxTextBox5.MaxStrLength = 0;
            this.pxTextBox5.Min = 0;
            this.pxTextBox5.MinStrLength = 0;
            this.pxTextBox5.Name = "pxTextBox5";
            this.pxTextBox5.Precision = 0;
            this.pxTextBox5.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox5.TabIndex = 155;
            this.pxTextBox5.ToolTipValid = this.toolTip1;
            this.pxTextBox5.ValidEable = true;
            this.pxTextBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(52, 90);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 154;
            this.label35.Text = "供辅系统:";
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Jiezhi_Delay_Time", true));
            this.pxTextBox3.EnableNull = false;
            this.pxTextBox3.ErropPr = this.errorProvider1;
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(130, 50);
            this.pxTextBox3.Max = 999;
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0;
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            this.pxTextBox3.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox3.TabIndex = 153;
            this.pxTextBox3.ToolTipValid = this.toolTip1;
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(76, 59);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 152;
            this.label30.Text = "介质:";
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Shebei_Delay_Time", true));
            this.pxTextBox2.EnableNull = false;
            this.pxTextBox2.ErropPr = this.errorProvider1;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(130, 23);
            this.pxTextBox2.Max = 999;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            this.pxTextBox2.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox2.TabIndex = 151;
            this.pxTextBox2.ToolTipValid = this.toolTip1;
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(76, 32);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 12);
            this.label29.TabIndex = 149;
            this.label29.Text = "设备:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(28, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 12);
            this.label25.TabIndex = 147;
            this.label25.Text = "内部影响时间:";
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "FurnaceNo", true));
            this.pxTextBox1.EnableNull = false;
            this.pxTextBox1.ErropPr = this.errorProvider1;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(173, 266);
            this.pxTextBox1.Max = 99999;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.ReadOnly = true;
            this.pxTextBox1.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox1.TabIndex = 198;
            this.pxTextBox1.ToolTipValid = this.toolTip1;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(120, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 12);
            this.label20.TabIndex = 199;
            this.label20.Text = "炉壳号:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Return_Start_Time", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker1.TabIndex = 197;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 196;
            this.label8.Text = "还原时刻:";
            // 
            // cmbLadleGrade
            // 
            this.cmbLadleGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Grade", true));
            this.cmbLadleGrade.FormattingEnabled = true;
            this.cmbLadleGrade.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.cmbLadleGrade.Location = new System.Drawing.Point(358, 320);
            this.cmbLadleGrade.Name = "cmbLadleGrade";
            this.cmbLadleGrade.Size = new System.Drawing.Size(62, 20);
            this.cmbLadleGrade.TabIndex = 195;
            // 
            // txtTappingWeight
            // 
            this.txtTappingWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tapping_Weight", true));
            this.txtTappingWeight.EnableNull = false;
            this.txtTappingWeight.ErropPr = this.errorProvider1;
            this.txtTappingWeight.Length = 0;
            this.txtTappingWeight.Location = new System.Drawing.Point(358, 247);
            this.txtTappingWeight.Max = 99;
            this.txtTappingWeight.MaxStrLength = 0;
            this.txtTappingWeight.Min = 0;
            this.txtTappingWeight.MinStrLength = 0;
            this.txtTappingWeight.Name = "txtTappingWeight";
            this.txtTappingWeight.Precision = 0;
            this.txtTappingWeight.ReadOnly = true;
            this.txtTappingWeight.Size = new System.Drawing.Size(64, 21);
            this.txtTappingWeight.TabIndex = 15;
            this.txtTappingWeight.ToolTipValid = this.toolTip1;
            this.txtTappingWeight.ValidEable = true;
            this.txtTappingWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(287, 252);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(65, 12);
            this.label43.TabIndex = 174;
            this.label43.Text = "出钢量[T]:";
            // 
            // txtTapholeLife
            // 
            this.txtTapholeLife.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LanceNo", true));
            this.txtTapholeLife.EnableNull = false;
            this.txtTapholeLife.ErropPr = this.errorProvider1;
            this.txtTapholeLife.Length = 0;
            this.txtTapholeLife.Location = new System.Drawing.Point(173, 340);
            this.txtTapholeLife.Max = 999;
            this.txtTapholeLife.MaxStrLength = 0;
            this.txtTapholeLife.Min = 0;
            this.txtTapholeLife.MinStrLength = 0;
            this.txtTapholeLife.Name = "txtTapholeLife";
            this.txtTapholeLife.Precision = 0;
            this.txtTapholeLife.ReadOnly = true;
            this.txtTapholeLife.Size = new System.Drawing.Size(62, 21);
            this.txtTapholeLife.TabIndex = 9;
            this.txtTapholeLife.ToolTipValid = this.toolTip1;
            this.txtTapholeLife.ValidEable = true;
            this.txtTapholeLife.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(129, 343);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 172;
            this.label44.Text = "枪号:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(294, 322);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 12);
            this.label39.TabIndex = 170;
            this.label39.Text = "钢包状况:";
            // 
            // txtLadleNo
            // 
            this.txtLadleNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LadleNo", true));
            this.txtLadleNo.EnableNull = false;
            this.txtLadleNo.ErropPr = this.errorProvider1;
            this.txtLadleNo.Length = 0;
            this.txtLadleNo.Location = new System.Drawing.Point(358, 292);
            this.txtLadleNo.Max = 0;
            this.txtLadleNo.MaxStrLength = 0;
            this.txtLadleNo.Min = 0;
            this.txtLadleNo.MinStrLength = 0;
            this.txtLadleNo.Name = "txtLadleNo";
            this.txtLadleNo.Precision = 0;
            this.txtLadleNo.ReadOnly = true;
            this.txtLadleNo.Size = new System.Drawing.Size(62, 21);
            this.txtLadleNo.TabIndex = 14;
            this.txtLadleNo.ToolTipValid = this.toolTip1;
            this.txtLadleNo.ValidEable = true;
            this.txtLadleNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(306, 294);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(47, 12);
            this.label40.TabIndex = 168;
            this.label40.Text = "钢包号:";
            // 
            // txtTappingTemp
            // 
            this.txtTappingTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tapping_Temp", true));
            this.txtTappingTemp.EnableNull = false;
            this.txtTappingTemp.ErropPr = this.errorProvider1;
            this.txtTappingTemp.Length = 0;
            this.txtTappingTemp.Location = new System.Drawing.Point(358, 210);
            this.txtTappingTemp.Max = 2000;
            this.txtTappingTemp.MaxStrLength = 0;
            this.txtTappingTemp.Min = 0;
            this.txtTappingTemp.MinStrLength = 0;
            this.txtTappingTemp.Name = "txtTappingTemp";
            this.txtTappingTemp.Precision = 0;
            this.txtTappingTemp.ReadOnly = true;
            this.txtTappingTemp.Size = new System.Drawing.Size(64, 21);
            this.txtTappingTemp.TabIndex = 18;
            this.txtTappingTemp.ToolTipValid = this.toolTip1;
            this.txtTappingTemp.ValidEable = true;
            this.txtTappingTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(269, 215);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 12);
            this.label36.TabIndex = 162;
            this.label36.Text = "出钢温度[℃]:";
            // 
            // txtLaCTemp
            // 
            this.txtLaCTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LaC_Temp", true));
            this.txtLaCTemp.EnableNull = false;
            this.txtLaCTemp.ErropPr = this.errorProvider1;
            this.txtLaCTemp.Length = 0;
            this.txtLaCTemp.Location = new System.Drawing.Point(358, 182);
            this.txtLaCTemp.Max = 2000;
            this.txtLaCTemp.MaxStrLength = 0;
            this.txtLaCTemp.Min = 0;
            this.txtLaCTemp.MinStrLength = 0;
            this.txtLaCTemp.Name = "txtLaCTemp";
            this.txtLaCTemp.Precision = 0;
            this.txtLaCTemp.ReadOnly = true;
            this.txtLaCTemp.Size = new System.Drawing.Size(64, 21);
            this.txtLaCTemp.TabIndex = 17;
            this.txtLaCTemp.ToolTipValid = this.toolTip1;
            this.txtLaCTemp.ValidEable = true;
            this.txtLaCTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(251, 187);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(107, 12);
            this.label37.TabIndex = 160;
            this.label37.Text = "脱碳末期温度[℃]:";
            // 
            // dtTappingEndTime
            // 
            this.dtTappingEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTappingEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Tapping_End_Time", true));
            this.dtTappingEndTime.Enabled = false;
            this.dtTappingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTappingEndTime.Location = new System.Drawing.Point(92, 200);
            this.dtTappingEndTime.Name = "dtTappingEndTime";
            this.dtTappingEndTime.Size = new System.Drawing.Size(144, 21);
            this.dtTappingEndTime.TabIndex = 3;
            // 
            // dtTappingStartTime
            // 
            this.dtTappingStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTappingStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Tapping_Strat_Time", true));
            this.dtTappingStartTime.Enabled = false;
            this.dtTappingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTappingStartTime.Location = new System.Drawing.Point(92, 172);
            this.dtTappingStartTime.Name = "dtTappingStartTime";
            this.dtTappingStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtTappingStartTime.TabIndex = 2;
            // 
            // dtBlowStartTime
            // 
            this.dtBlowStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBlowStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Blow_Start_Time", true));
            this.dtBlowStartTime.Enabled = false;
            this.dtBlowStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBlowStartTime.Location = new System.Drawing.Point(92, 106);
            this.dtBlowStartTime.Name = "dtBlowStartTime";
            this.dtBlowStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtBlowStartTime.TabIndex = 1;
            // 
            // dtChargingStartTime
            // 
            this.dtChargingStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtChargingStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Charging_Start_Time", true));
            this.dtChargingStartTime.Enabled = false;
            this.dtChargingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtChargingStartTime.Location = new System.Drawing.Point(92, 78);
            this.dtChargingStartTime.Name = "dtChargingStartTime";
            this.dtChargingStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtChargingStartTime.TabIndex = 0;
            // 
            // txtFurnaceAge
            // 
            this.txtFurnaceAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Furnace_Age", true));
            this.txtFurnaceAge.EnableNull = false;
            this.txtFurnaceAge.ErropPr = this.errorProvider1;
            this.txtFurnaceAge.Length = 0;
            this.txtFurnaceAge.Location = new System.Drawing.Point(173, 298);
            this.txtFurnaceAge.Max = 99999;
            this.txtFurnaceAge.MaxStrLength = 0;
            this.txtFurnaceAge.Min = 0;
            this.txtFurnaceAge.MinStrLength = 0;
            this.txtFurnaceAge.Name = "txtFurnaceAge";
            this.txtFurnaceAge.Precision = 0;
            this.txtFurnaceAge.ReadOnly = true;
            this.txtFurnaceAge.Size = new System.Drawing.Size(62, 21);
            this.txtFurnaceAge.TabIndex = 13;
            this.txtFurnaceAge.ToolTipValid = this.toolTip1;
            this.txtFurnaceAge.ValidEable = true;
            this.txtFurnaceAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(130, 301);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 152;
            this.label23.Text = "炉龄:";
            // 
            // txtLanceAge
            // 
            this.txtLanceAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Lance_Age", true));
            this.txtLanceAge.EnableNull = false;
            this.txtLanceAge.ErropPr = this.errorProvider1;
            this.txtLanceAge.Length = 0;
            this.txtLanceAge.Location = new System.Drawing.Point(173, 377);
            this.txtLanceAge.Max = 999;
            this.txtLanceAge.MaxStrLength = 0;
            this.txtLanceAge.Min = 0;
            this.txtLanceAge.MinStrLength = 0;
            this.txtLanceAge.Name = "txtLanceAge";
            this.txtLanceAge.Precision = 0;
            this.txtLanceAge.ReadOnly = true;
            this.txtLanceAge.Size = new System.Drawing.Size(62, 21);
            this.txtLanceAge.TabIndex = 12;
            this.txtLanceAge.ToolTipValid = this.toolTip1;
            this.txtLanceAge.ValidEable = true;
            this.txtLanceAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(129, 380);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 150;
            this.label24.Text = "枪龄:";
            // 
            // txtSmeltPeriod
            // 
            this.txtSmeltPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Smelt_Period", true));
            this.txtSmeltPeriod.EnableNull = false;
            this.txtSmeltPeriod.ErropPr = this.errorProvider1;
            this.txtSmeltPeriod.Length = 0;
            this.txtSmeltPeriod.Location = new System.Drawing.Point(358, 132);
            this.txtSmeltPeriod.Max = 9999;
            this.txtSmeltPeriod.MaxStrLength = 0;
            this.txtSmeltPeriod.Min = 0;
            this.txtSmeltPeriod.MinStrLength = 0;
            this.txtSmeltPeriod.Name = "txtSmeltPeriod";
            this.txtSmeltPeriod.Precision = 0;
            this.txtSmeltPeriod.Size = new System.Drawing.Size(64, 21);
            this.txtSmeltPeriod.TabIndex = 10;
            this.txtSmeltPeriod.ToolTipValid = this.toolTip1;
            this.txtSmeltPeriod.ValidEable = true;
            this.txtSmeltPeriod.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(275, 137);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 146;
            this.label26.Text = "冶炼周期[\']:";
            // 
            // txtSplashingTime
            // 
            this.txtSplashingTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "ReBlow_Time", true));
            this.txtSplashingTime.EnableNull = true;
            this.txtSplashingTime.ErropPr = this.errorProvider1;
            this.txtSplashingTime.Length = 0;
            this.txtSplashingTime.Location = new System.Drawing.Point(358, 104);
            this.txtSplashingTime.Max = 9999;
            this.txtSplashingTime.MaxStrLength = 0;
            this.txtSplashingTime.Min = 0;
            this.txtSplashingTime.MinStrLength = 0;
            this.txtSplashingTime.Name = "txtSplashingTime";
            this.txtSplashingTime.Precision = 0;
            this.txtSplashingTime.Size = new System.Drawing.Size(65, 21);
            this.txtSplashingTime.TabIndex = 7;
            this.txtSplashingTime.ToolTipValid = this.toolTip1;
            this.txtSplashingTime.ValidEable = true;
            this.txtSplashingTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(269, 109);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 144;
            this.label27.Text = "还原时间[″]:";
            // 
            // txtTappingTime
            // 
            this.txtTappingTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tapping_Time", true));
            this.txtTappingTime.EnableNull = false;
            this.txtTappingTime.ErropPr = this.errorProvider1;
            this.txtTappingTime.Length = 0;
            this.txtTappingTime.Location = new System.Drawing.Point(358, 76);
            this.txtTappingTime.Max = 9999;
            this.txtTappingTime.MaxStrLength = 0;
            this.txtTappingTime.Min = 0;
            this.txtTappingTime.MinStrLength = 0;
            this.txtTappingTime.Name = "txtTappingTime";
            this.txtTappingTime.Precision = 0;
            this.txtTappingTime.Size = new System.Drawing.Size(65, 21);
            this.txtTappingTime.TabIndex = 6;
            this.txtTappingTime.ToolTipValid = this.toolTip1;
            this.txtTappingTime.ValidEable = true;
            this.txtTappingTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(269, 81);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 12);
            this.label28.TabIndex = 142;
            this.label28.Text = "出钢时间[″]:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(27, 204);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 12);
            this.label31.TabIndex = 136;
            this.label31.Text = "出钢结束:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(27, 176);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 12);
            this.label32.TabIndex = 134;
            this.label32.Text = "出钢开始:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(27, 110);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 132;
            this.label33.Text = "开吹时刻:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(27, 82);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 130;
            this.label34.Text = "兑铁时刻:";
            // 
            // fLPProcess
            // 
            this.fLPProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPProcess.Controls.Add(this.btnProcessCancel);
            this.fLPProcess.Controls.Add(this.btnProcessConfirm);
            this.fLPProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPProcess.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPProcess.Location = new System.Drawing.Point(3, 674);
            this.fLPProcess.Name = "fLPProcess";
            this.fLPProcess.Size = new System.Drawing.Size(957, 33);
            this.fLPProcess.TabIndex = 89;
            // 
            // btnProcessCancel
            // 
            this.btnProcessCancel.Location = new System.Drawing.Point(875, 3);
            this.btnProcessCancel.Name = "btnProcessCancel";
            this.btnProcessCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProcessCancel.TabIndex = 87;
            this.btnProcessCancel.Text = "取消";
            this.btnProcessCancel.UseVisualStyleBackColor = true;
            this.btnProcessCancel.Click += new System.EventHandler(this.btnProcessCancel_Click);
            // 
            // tabAlloy
            // 
            this.tabAlloy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAlloy.Controls.Add(this.hmiRootPanel4);
            this.tabAlloy.Controls.Add(this.fLPAlloy);
            this.tabAlloy.Location = new System.Drawing.Point(4, 21);
            this.tabAlloy.Name = "tabAlloy";
            this.tabAlloy.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlloy.Size = new System.Drawing.Size(965, 712);
            this.tabAlloy.TabIndex = 12;
            this.tabAlloy.Text = "合金及废钢数据";
            this.tabAlloy.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel4
            // 
            this.hmiRootPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel4.Controls.Add(this.cmbBatchID);
            this.hmiRootPanel4.Controls.Add(this.dvAlloy);
            this.hmiRootPanel4.Controls.Add(this.bdAlloy);
            this.hmiRootPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel4.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel4.Name = "hmiRootPanel4";
            this.hmiRootPanel4.Size = new System.Drawing.Size(957, 671);
            this.hmiRootPanel4.TabIndex = 90;
            // 
            // cmbBatchID
            // 
            this.cmbBatchID.DataSource = this.dsMat_Alloy_Add_Man;
            this.cmbBatchID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBatchID.DropDownHeight = 200;
            this.cmbBatchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchID.DropDownWidth = 200;
            this.cmbBatchID.FormattingEnabled = true;
            this.cmbBatchID.IntegralHeight = false;
            this.cmbBatchID.Location = new System.Drawing.Point(141, 47);
            this.cmbBatchID.Name = "cmbBatchID";
            this.cmbBatchID.Size = new System.Drawing.Size(151, 20);
            this.cmbBatchID.TabIndex = 95;
            this.cmbBatchID.ValueMember = "L3DataTable.Code";
            this.cmbBatchID.Visible = false;
            this.cmbBatchID.SelectedIndexChanged += new System.EventHandler(this.cmbBatchID_SelectedIndexChanged);
            // 
            // dsMat_Alloy_Add_Man
            // 
            this.dsMat_Alloy_Add_Man.AutoLoad = true;
            this.dsMat_Alloy_Add_Man.AutoSubscribe = false;
            this.dsMat_Alloy_Add_Man.DataSetName = "L3DataSet";
            this.dsMat_Alloy_Add_Man.DeleteMethod = "";
            this.dsMat_Alloy_Add_Man.InsertMethod = "";
            this.dsMat_Alloy_Add_Man.L3DataAdapter = this.Adapter;
            this.dsMat_Alloy_Add_Man.LoadEvent = "";
            this.dsMat_Alloy_Add_Man.LoadTrigger = null;
            this.dsMat_Alloy_Add_Man.RefreshValve = 1000;
            this.dsMat_Alloy_Add_Man.SourceCommand = null;
            this.dsMat_Alloy_Add_Man.SourceCondition = "";
            this.dsMat_Alloy_Add_Man.SourceMethod = "";
            this.dsMat_Alloy_Add_Man.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsMat_Alloy_Add_Man.SourceURI = "";
            this.dsMat_Alloy_Add_Man.SubscribeTarget = "";
            this.dsMat_Alloy_Add_Man.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMat_Alloy_Add_Man});
            this.dsMat_Alloy_Add_Man.UpdateEvent = "";
            this.dsMat_Alloy_Add_Man.UpdateMethod = "";
            this.dsMat_Alloy_Add_Man.UpdateTrigger = null;
            // 
            // schemadsMat_Alloy_Add_Man
            // 
            this.schemadsMat_Alloy_Add_Man.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code,
            this.coldsMat_Alloy_Add_ManL3DataTableBatch_ID,
            this.coldsMat_Alloy_Add_ManL3DataTableCode,
            this.coldsMat_Alloy_Add_ManL3DataTableCode_Des});
            this.schemadsMat_Alloy_Add_Man.TableName = "L3DataTable";
            // 
            // coldsMat_Alloy_Add_ManL3DataTableAlloy_Code
            // 
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsMat_Alloy_Add_ManL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsMat_Alloy_Add_ManL3DataTableBatch_ID
            // 
            this.coldsMat_Alloy_Add_ManL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsMat_Alloy_Add_ManL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsMat_Alloy_Add_ManL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsMat_Alloy_Add_ManL3DataTableCode
            // 
            this.coldsMat_Alloy_Add_ManL3DataTableCode.Caption = "Code";
            this.coldsMat_Alloy_Add_ManL3DataTableCode.ColumnName = "Code";
            this.coldsMat_Alloy_Add_ManL3DataTableCode.Namespace = "";
            // 
            // coldsMat_Alloy_Add_ManL3DataTableCode_Des
            // 
            this.coldsMat_Alloy_Add_ManL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMat_Alloy_Add_ManL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMat_Alloy_Add_ManL3DataTableCode_Des.Namespace = "";
            // 
            // dvAlloy
            // 
            this.dvAlloy.AllowUserToAddRows = false;
            this.dvAlloy.AllowUserToDeleteRows = false;
            this.dvAlloy.AutoGenerateColumns = false;
            this.dvAlloy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvAlloy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvAlloy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dvcmbAlloyCode,
            this.dataGridViewTextBoxColumn2,
            this.calendarColumn1,
            this.dataGridViewComboBoxColumn2,
            this.Batch_ID_Pre,
            this.Name1,
            this.EnableFlag});
            this.dvAlloy.DataSource = this.bsAlloy;
            this.dvAlloy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAlloy.Location = new System.Drawing.Point(0, 25);
            this.dvAlloy.Name = "dvAlloy";
            this.dvAlloy.RowTemplate.Height = 23;
            this.dvAlloy.Size = new System.Drawing.Size(953, 642);
            this.dvAlloy.TabIndex = 94;
            this.dvAlloy.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvAlloy_CurrentCellDirtyStateChanged);
            this.dvAlloy.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            this.dvAlloy.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvAlloy_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dvcmbAlloyCode
            // 
            this.dvcmbAlloyCode.DataPropertyName = "Element";
            this.dvcmbAlloyCode.DataSource = this.bsAlloyCode;
            this.dvcmbAlloyCode.DisplayMember = "Code_Des";
            this.dvcmbAlloyCode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dvcmbAlloyCode.HeaderText = "合金代码";
            this.dvcmbAlloyCode.Name = "dvcmbAlloyCode";
            this.dvcmbAlloyCode.ReadOnly = true;
            this.dvcmbAlloyCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvcmbAlloyCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dvcmbAlloyCode.ValueMember = "Code";
            this.dvcmbAlloyCode.Width = 150;
            // 
            // bsAlloyCode
            // 
            this.bsAlloyCode.DataMember = "L3DataTable";
            this.bsAlloyCode.DataSource = this.dsCode;
            this.bsAlloyCode.Filter = "CODE_GROUP = \'ALLOY_CODE\'";
            // 
            // dsCode
            // 
            this.dsCode.AutoLoad = true;
            this.dsCode.AutoSubscribe = false;
            this.dsCode.DataSetName = "L3DataSet";
            this.dsCode.DeleteMethod = null;
            this.dsCode.InsertMethod = null;
            this.dsCode.L3DataAdapter = this.Adapter;
            this.dsCode.LoadEvent = "Click";
            this.dsCode.LoadTrigger = null;
            this.dsCode.RefreshValve = 1000;
            this.dsCode.SourceCommand = null;
            this.dsCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\' OR CODE_GROUP = \'BULK_CODE\' order by CODE_DES";
            this.dsCode.SourceMethod = "";
            this.dsCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCode.SubscribeTarget = null;
            this.dsCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCode});
            this.dsCode.UpdateEvent = "Click";
            this.dsCode.UpdateMethod = null;
            this.dsCode.UpdateTrigger = null;
            // 
            // schemadsCode
            // 
            this.schemadsCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCodeL3DataTableCode,
            this.coldsCodeL3DataTableCode_Des,
            this.coldsCodeL3DataTableCODE_GROUP});
            this.schemadsCode.TableName = "L3DataTable";
            // 
            // coldsCodeL3DataTableCode
            // 
            this.coldsCodeL3DataTableCode.Caption = "Code";
            this.coldsCodeL3DataTableCode.ColumnName = "Code";
            this.coldsCodeL3DataTableCode.Namespace = "";
            // 
            // coldsCodeL3DataTableCode_Des
            // 
            this.coldsCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCodeL3DataTableCODE_GROUP
            // 
            this.coldsCodeL3DataTableCODE_GROUP.Caption = "CODE_GROUP";
            this.coldsCodeL3DataTableCODE_GROUP.ColumnName = "CODE_GROUP";
            this.coldsCodeL3DataTableCODE_GROUP.Namespace = "";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn2.HeaderText = "合金量[Kg]";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "Discharge_Time";
            dataGridViewCellStyle12.Format = "G";
            dataGridViewCellStyle12.NullValue = null;
            this.calendarColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.calendarColumn1.HeaderText = "加料时刻";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.Width = 120;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewComboBoxColumn2.DataSource = this.dsAdditionType;
            this.dataGridViewComboBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "加料性质";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "L3DataTable.Code_Val_Long";
            this.dataGridViewComboBoxColumn2.Width = 150;
            // 
            // dsAdditionType
            // 
            this.dsAdditionType.AutoLoad = true;
            this.dsAdditionType.AutoSubscribe = false;
            this.dsAdditionType.DataSetName = "L3DataSet";
            this.dsAdditionType.DeleteMethod = null;
            this.dsAdditionType.InsertMethod = null;
            this.dsAdditionType.L3DataAdapter = this.Adapter;
            this.dsAdditionType.LoadEvent = "Click";
            this.dsAdditionType.LoadTrigger = null;
            this.dsAdditionType.RefreshValve = 1000;
            this.dsAdditionType.SourceCommand = null;
            this.dsAdditionType.SourceCondition = "CODE_GROUP = \'AOD_Addition_Type\' and code is not null order by code";
            this.dsAdditionType.SourceMethod = "";
            this.dsAdditionType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAdditionType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAdditionType.SubscribeTarget = null;
            this.dsAdditionType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAdditionType});
            this.dsAdditionType.UpdateEvent = "Click";
            this.dsAdditionType.UpdateMethod = null;
            this.dsAdditionType.UpdateTrigger = null;
            // 
            // schemadsAdditionType
            // 
            this.schemadsAdditionType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAdditionTypeL3DataTableCode_Des,
            this.coldsAdditionTypeL3DataTableCode_Val_Long});
            this.schemadsAdditionType.TableName = "L3DataTable";
            // 
            // coldsAdditionTypeL3DataTableCode_Des
            // 
            this.coldsAdditionTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAdditionTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAdditionTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAdditionTypeL3DataTableCode_Val_Long
            // 
            this.coldsAdditionTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsAdditionTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsAdditionTypeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsAdditionTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // Batch_ID_Pre
            // 
            this.Batch_ID_Pre.DataPropertyName = "Batch_ID";
            this.Batch_ID_Pre.HeaderText = "批次号";
            this.Batch_ID_Pre.Name = "Batch_ID_Pre";
            this.Batch_ID_Pre.ReadOnly = true;
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name";
            this.Name1.HeaderText = "人工录入标志";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Width = 120;
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.HeaderText = "EnableFlag";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.Visible = false;
            // 
            // bsAlloy
            // 
            this.bsAlloy.DataMember = "L3DataTable";
            this.bsAlloy.DataSource = this.dsMat;
            this.bsAlloy.Filter = "";
            this.bsAlloy.CurrentChanged += new System.EventHandler(this.bsAlloy_CurrentChanged);
            // 
            // dsMat
            // 
            this.dsMat.AutoLoad = true;
            this.dsMat.AutoSubscribe = false;
            this.dsMat.DataSetName = "L3DataSet";
            this.dsMat.DeleteMethod = null;
            this.dsMat.InsertMethod = null;
            this.dsMat.L3DataAdapter = null;
            this.dsMat.LoadEvent = "Click";
            this.dsMat.LoadTrigger = null;
            this.dsMat.RefreshValve = 1000;
            this.dsMat.SourceCommand = null;
            this.dsMat.SourceCondition = "";
            this.dsMat.SourceMethod = "";
            this.dsMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMat.SourceURI = "XGMESLogic\\AODMag\\CAOD_Addition_Data";
            this.dsMat.SubscribeTarget = null;
            this.dsMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMat});
            this.dsMat.UpdateEvent = "Click";
            this.dsMat.UpdateMethod = null;
            this.dsMat.UpdateTrigger = null;
            // 
            // schemadsMat
            // 
            this.schemadsMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatL3DataTableHeatID,
            this.coldsMatL3DataTableElement,
            this.coldsMatL3DataTableWeight,
            this.coldsMatL3DataTableDischarge_Time,
            this.coldsMatL3DataTableType,
            this.coldsMatL3DataTableGUID,
            this.coldsMatL3DataTableName,
            this.coldsMatL3DataTableBatch_ID,
            this.coldsMatL3DataTableEnableFlag});
            this.schemadsMat.TableName = "L3DataTable";
            // 
            // coldsMatL3DataTableHeatID
            // 
            this.coldsMatL3DataTableHeatID.Caption = "HeatID";
            this.coldsMatL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMatL3DataTableHeatID.Namespace = "";
            // 
            // coldsMatL3DataTableElement
            // 
            this.coldsMatL3DataTableElement.Caption = "Element";
            this.coldsMatL3DataTableElement.ColumnName = "Element";
            this.coldsMatL3DataTableElement.Namespace = "";
            // 
            // coldsMatL3DataTableWeight
            // 
            this.coldsMatL3DataTableWeight.Caption = "Weight";
            this.coldsMatL3DataTableWeight.ColumnName = "Weight";
            this.coldsMatL3DataTableWeight.DataType = typeof(float);
            this.coldsMatL3DataTableWeight.Namespace = "";
            // 
            // coldsMatL3DataTableDischarge_Time
            // 
            this.coldsMatL3DataTableDischarge_Time.Caption = "Discharge_Time";
            this.coldsMatL3DataTableDischarge_Time.ColumnName = "Discharge_Time";
            this.coldsMatL3DataTableDischarge_Time.DataType = typeof(System.DateTime);
            this.coldsMatL3DataTableDischarge_Time.Namespace = "";
            // 
            // coldsMatL3DataTableType
            // 
            this.coldsMatL3DataTableType.Caption = "Type";
            this.coldsMatL3DataTableType.ColumnName = "Type";
            this.coldsMatL3DataTableType.DataType = typeof(short);
            this.coldsMatL3DataTableType.Namespace = "";
            // 
            // coldsMatL3DataTableGUID
            // 
            this.coldsMatL3DataTableGUID.Caption = "GUID";
            this.coldsMatL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatL3DataTableGUID.Namespace = "";
            // 
            // coldsMatL3DataTableName
            // 
            this.coldsMatL3DataTableName.Caption = "Name";
            this.coldsMatL3DataTableName.ColumnName = "Name";
            this.coldsMatL3DataTableName.Namespace = "";
            // 
            // coldsMatL3DataTableBatch_ID
            // 
            this.coldsMatL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsMatL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsMatL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsMatL3DataTableEnableFlag
            // 
            this.coldsMatL3DataTableEnableFlag.Caption = "EnableFlag";
            this.coldsMatL3DataTableEnableFlag.ColumnName = "EnableFlag";
            this.coldsMatL3DataTableEnableFlag.Namespace = "";
            // 
            // bdAlloy
            // 
            this.bdAlloy.AddNewItem = null;
            this.bdAlloy.BindingSource = this.bsAlloy;
            this.bdAlloy.CountItem = this.toolStripLabel2;
            this.bdAlloy.DeleteItem = null;
            this.bdAlloy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator6,
            this.btnAddAlloy,
            this.btnDelAlloy,
            this.btnRefAlloy});
            this.bdAlloy.Location = new System.Drawing.Point(0, 0);
            this.bdAlloy.MoveFirstItem = this.toolStripButton5;
            this.bdAlloy.MoveLastItem = this.toolStripButton8;
            this.bdAlloy.MoveNextItem = this.toolStripButton7;
            this.bdAlloy.MovePreviousItem = this.toolStripButton6;
            this.bdAlloy.Name = "bdAlloy";
            this.bdAlloy.PositionItem = this.toolStripTextBox2;
            this.bdAlloy.Size = new System.Drawing.Size(953, 25);
            this.bdAlloy.TabIndex = 0;
            this.bdAlloy.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "/ {0}";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到第一条记录";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到上一条记录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "位置";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "当前位置";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到下一条记录";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到最后一条记录";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelAlloy
            // 
            this.btnDelAlloy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelAlloy.Image = ((System.Drawing.Image)(resources.GetObject("btnDelAlloy.Image")));
            this.btnDelAlloy.Name = "btnDelAlloy";
            this.btnDelAlloy.RightToLeftAutoMirrorImage = true;
            this.btnDelAlloy.Size = new System.Drawing.Size(23, 22);
            this.btnDelAlloy.Text = "删除";
            this.btnDelAlloy.Click += new System.EventHandler(this.btnDelAlloy_Click);
            // 
            // btnRefAlloy
            // 
            this.btnRefAlloy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefAlloy.Image = ((System.Drawing.Image)(resources.GetObject("btnRefAlloy.Image")));
            this.btnRefAlloy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefAlloy.Name = "btnRefAlloy";
            this.btnRefAlloy.Size = new System.Drawing.Size(23, 22);
            this.btnRefAlloy.Text = "toolStripButton25";
            this.btnRefAlloy.ToolTipText = "刷新";
            this.btnRefAlloy.Click += new System.EventHandler(this.btnAlloyCancel_Click);
            // 
            // fLPAlloy
            // 
            this.fLPAlloy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPAlloy.Controls.Add(this.btnAlloyCancel);
            this.fLPAlloy.Controls.Add(this.btnAlloyCanfirm);
            this.fLPAlloy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPAlloy.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPAlloy.Location = new System.Drawing.Point(3, 674);
            this.fLPAlloy.Name = "fLPAlloy";
            this.fLPAlloy.Size = new System.Drawing.Size(957, 33);
            this.fLPAlloy.TabIndex = 89;
            // 
            // btnAlloyCancel
            // 
            this.btnAlloyCancel.Location = new System.Drawing.Point(875, 3);
            this.btnAlloyCancel.Name = "btnAlloyCancel";
            this.btnAlloyCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAlloyCancel.TabIndex = 87;
            this.btnAlloyCancel.Text = "取消";
            this.btnAlloyCancel.UseVisualStyleBackColor = true;
            this.btnAlloyCancel.Click += new System.EventHandler(this.btnAlloyCancel_Click);
            // 
            // tabSumAddition
            // 
            this.tabSumAddition.Controls.Add(this.dataGridView3);
            this.tabSumAddition.Location = new System.Drawing.Point(4, 21);
            this.tabSumAddition.Name = "tabSumAddition";
            this.tabSumAddition.Padding = new System.Windows.Forms.Padding(3);
            this.tabSumAddition.Size = new System.Drawing.Size(965, 712);
            this.tabSumAddition.TabIndex = 16;
            this.tabSumAddition.Text = "加料统计";
            this.tabSumAddition.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eLEMENTDataGridViewTextBoxColumn,
            this.wEIGHTDataGridViewTextBoxColumn,
            this.type});
            this.dataGridView3.DataSource = this.bsSumAddition;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(959, 706);
            this.dataGridView3.TabIndex = 0;
            // 
            // eLEMENTDataGridViewTextBoxColumn
            // 
            this.eLEMENTDataGridViewTextBoxColumn.DataPropertyName = "ELEMENT";
            this.eLEMENTDataGridViewTextBoxColumn.DataSource = this.dsCode;
            this.eLEMENTDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.eLEMENTDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.eLEMENTDataGridViewTextBoxColumn.HeaderText = "合金";
            this.eLEMENTDataGridViewTextBoxColumn.Name = "eLEMENTDataGridViewTextBoxColumn";
            this.eLEMENTDataGridViewTextBoxColumn.ReadOnly = true;
            this.eLEMENTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eLEMENTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eLEMENTDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.eLEMENTDataGridViewTextBoxColumn.Width = 200;
            // 
            // wEIGHTDataGridViewTextBoxColumn
            // 
            this.wEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT";
            this.wEIGHTDataGridViewTextBoxColumn.HeaderText = "加入量[KG]";
            this.wEIGHTDataGridViewTextBoxColumn.Name = "wEIGHTDataGridViewTextBoxColumn";
            this.wEIGHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // type
            // 
            this.type.DataPropertyName = "TYPE";
            this.type.DataSource = this.dsAdditionType;
            this.type.DisplayMember = "L3DataTable.Code_Des";
            this.type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.type.HeaderText = "合金类型";
            this.type.Name = "type";
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.type.ValueMember = "L3DataTable.Code_Val_Long";
            this.type.Width = 150;
            // 
            // bsSumAddition
            // 
            this.bsSumAddition.DataMember = "L3DataTable";
            this.bsSumAddition.DataSource = this.dsSumAddition;
            // 
            // dsSumAddition
            // 
            this.dsSumAddition.AutoLoad = true;
            this.dsSumAddition.AutoSubscribe = false;
            this.dsSumAddition.DataSetName = "L3DataSet";
            this.dsSumAddition.DeleteMethod = null;
            this.dsSumAddition.InsertMethod = null;
            this.dsSumAddition.L3DataAdapter = this.Adapter;
            this.dsSumAddition.LoadEvent = "Click";
            this.dsSumAddition.LoadTrigger = null;
            this.dsSumAddition.RefreshValve = 1000;
            this.dsSumAddition.SourceCommand = null;
            this.dsSumAddition.SourceCondition = "";
            this.dsSumAddition.SourceMethod = "";
            this.dsSumAddition.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsSumAddition.SourceURI = null;
            this.dsSumAddition.SubscribeTarget = null;
            this.dsSumAddition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSumAddition});
            this.dsSumAddition.UpdateEvent = "Click";
            this.dsSumAddition.UpdateMethod = null;
            this.dsSumAddition.UpdateTrigger = null;
            // 
            // schemadsSumAddition
            // 
            this.schemadsSumAddition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSumAdditionL3DataTableWEIGHT,
            this.coldsSumAdditionL3DataTableELEMENT,
            this.AcoldsSumAdditionL3DataTableTYPE});
            this.schemadsSumAddition.TableName = "L3DataTable";
            // 
            // coldsSumAdditionL3DataTableWEIGHT
            // 
            this.coldsSumAdditionL3DataTableWEIGHT.Caption = "WEIGHT";
            this.coldsSumAdditionL3DataTableWEIGHT.ColumnName = "WEIGHT";
            this.coldsSumAdditionL3DataTableWEIGHT.Namespace = "";
            // 
            // coldsSumAdditionL3DataTableELEMENT
            // 
            this.coldsSumAdditionL3DataTableELEMENT.Caption = "ELEMENT";
            this.coldsSumAdditionL3DataTableELEMENT.ColumnName = "ELEMENT";
            this.coldsSumAdditionL3DataTableELEMENT.Namespace = "";
            // 
            // AcoldsSumAdditionL3DataTableTYPE
            // 
            this.AcoldsSumAdditionL3DataTableTYPE.Caption = "TYPE";
            this.AcoldsSumAdditionL3DataTableTYPE.ColumnName = "TYPE";
            this.AcoldsSumAdditionL3DataTableTYPE.DataType = typeof(short);
            this.AcoldsSumAdditionL3DataTableTYPE.Namespace = "";
            // 
            // tabChemical
            // 
            this.tabChemical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabChemical.Controls.Add(this.dvChemical);
            this.tabChemical.Controls.Add(this.bnChemical);
            this.tabChemical.Controls.Add(this.fLPChemical);
            this.tabChemical.Location = new System.Drawing.Point(4, 21);
            this.tabChemical.Name = "tabChemical";
            this.tabChemical.Padding = new System.Windows.Forms.Padding(3);
            this.tabChemical.Size = new System.Drawing.Size(965, 712);
            this.tabChemical.TabIndex = 3;
            this.tabChemical.Text = "成份数据";
            this.tabChemical.UseVisualStyleBackColor = true;
            // 
            // dvChemical
            // 
            this.dvChemical.AllowUserToAddRows = false;
            this.dvChemical.AllowUserToDeleteRows = false;
            this.dvChemical.AutoGenerateColumns = false;
            this.dvChemical.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvChemical.ColumnHeadersHeight = 30;
            this.dvChemical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn1,
            this.appIDDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.C,
            this.siDataGridViewTextBoxColumn,
            this.mnDataGridViewTextBoxColumn,
            this.pDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.alDataGridViewTextBoxColumn,
            this.crDataGridViewTextBoxColumn,
            this.tiDataGridViewTextBoxColumn,
            this.vDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.moDataGridViewTextBoxColumn,
            this.niDataGridViewTextBoxColumn,
            this.caDataGridViewTextBoxColumn,
            this.cuDataGridViewTextBoxColumn,
            this.nbDataGridViewTextBoxColumn,
            this.snDataGridViewTextBoxColumn,
            this.wDataGridViewTextBoxColumn,
            this.pbDataGridViewTextBoxColumn,
            this.znDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.asDataGridViewTextBoxColumn,
            this.alSDataGridViewTextBoxColumn,
            this.sbDataGridViewTextBoxColumn,
            this.reDataGridViewTextBoxColumn,
            this.ceqDataGridViewTextBoxColumn,
            this.CrNi,
            this.CrCu,
            this.CrNiCu,
            this.other1DataGridViewTextBoxColumn,
            this.other2DataGridViewTextBoxColumn,
            this.Other3,
            this.logTimeDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn});
            this.dvChemical.DataSource = this.bsChemical;
            this.dvChemical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvChemical.Location = new System.Drawing.Point(3, 28);
            this.dvChemical.Name = "dvChemical";
            this.dvChemical.RowTemplate.Height = 23;
            this.dvChemical.Size = new System.Drawing.Size(957, 646);
            this.dvChemical.TabIndex = 92;
            this.dvChemical.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            this.dvChemical.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvChemical_DataBindingComplete);
            // 
            // heatIDDataGridViewTextBoxColumn1
            // 
            this.heatIDDataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn1.Name = "heatIDDataGridViewTextBoxColumn1";
            // 
            // appIDDataGridViewTextBoxColumn
            // 
            this.appIDDataGridViewTextBoxColumn.DataPropertyName = "AppID";
            this.appIDDataGridViewTextBoxColumn.HeaderText = "委托单编号";
            this.appIDDataGridViewTextBoxColumn.Name = "appIDDataGridViewTextBoxColumn";
            // 
            // sampleCodeDataGridViewTextBoxColumn
            // 
            this.sampleCodeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Code";
            this.sampleCodeDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sampleCodeDataGridViewTextBoxColumn.Name = "sampleCodeDataGridViewTextBoxColumn";
            // 
            // arriveDateDataGridViewTextBoxColumn
            // 
            this.arriveDateDataGridViewTextBoxColumn.DataPropertyName = "Arrive_Date";
            dataGridViewCellStyle13.Format = "G";
            this.arriveDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arriveDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            dataGridViewCellStyle14.Format = "G";
            this.reportDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // unitTypeIDDataGridViewTextBoxColumn
            // 
            this.unitTypeIDDataGridViewTextBoxColumn.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn.DataSource = this.dsUnitType;
            this.unitTypeIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.unitTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitTypeIDDataGridViewTextBoxColumn.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn.Name = "unitTypeIDDataGridViewTextBoxColumn";
            this.unitTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitTypeIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.unitTypeIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dsUnitType
            // 
            this.dsUnitType.AutoLoad = true;
            this.dsUnitType.AutoSubscribe = false;
            this.dsUnitType.DataSetName = "L3DataSet";
            this.dsUnitType.DeleteMethod = null;
            this.dsUnitType.InsertMethod = null;
            this.dsUnitType.L3DataAdapter = this.Adapter;
            this.dsUnitType.LoadEvent = "Click";
            this.dsUnitType.LoadTrigger = null;
            this.dsUnitType.RefreshValve = 1000;
            this.dsUnitType.SourceCommand = null;
            this.dsUnitType.SourceCondition = "CODE_GROUP = \'UnitType\' and code is not null order by code";
            this.dsUnitType.SourceMethod = "";
            this.dsUnitType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitType.SubscribeTarget = null;
            this.dsUnitType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitType});
            this.dsUnitType.UpdateEvent = "Click";
            this.dsUnitType.UpdateMethod = null;
            this.dsUnitType.UpdateTrigger = null;
            // 
            // schemadsUnitType
            // 
            this.schemadsUnitType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitTypeL3DataTableCode_Des,
            this.coldsUnitTypeL3DataTableCode_Val_Long});
            this.schemadsUnitType.TableName = "L3DataTable";
            // 
            // coldsUnitTypeL3DataTableCode_Des
            // 
            this.coldsUnitTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsUnitTypeL3DataTableCode_Val_Long
            // 
            this.coldsUnitTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsUnitTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsUnitTypeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsUnitTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // sampleAddressDataGridViewTextBoxColumn
            // 
            this.sampleAddressDataGridViewTextBoxColumn.DataPropertyName = "Sample_Address";
            this.sampleAddressDataGridViewTextBoxColumn.DataSource = this.dsSampleAddr;
            this.sampleAddressDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sampleAddressDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sampleAddressDataGridViewTextBoxColumn.HeaderText = "取样地点";
            this.sampleAddressDataGridViewTextBoxColumn.Name = "sampleAddressDataGridViewTextBoxColumn";
            this.sampleAddressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sampleAddressDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsSampleAddr
            // 
            this.dsSampleAddr.AutoLoad = true;
            this.dsSampleAddr.AutoSubscribe = false;
            this.dsSampleAddr.DataSetName = "L3DataSet";
            this.dsSampleAddr.DeleteMethod = null;
            this.dsSampleAddr.InsertMethod = null;
            this.dsSampleAddr.L3DataAdapter = this.Adapter;
            this.dsSampleAddr.LoadEvent = "Click";
            this.dsSampleAddr.LoadTrigger = null;
            this.dsSampleAddr.RefreshValve = 1000;
            this.dsSampleAddr.SourceCommand = null;
            this.dsSampleAddr.SourceCondition = "Code_Group = \'QA_Sample_Addr\'";
            this.dsSampleAddr.SourceMethod = "";
            this.dsSampleAddr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleAddr.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleAddr.SubscribeTarget = null;
            this.dsSampleAddr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddr});
            this.dsSampleAddr.UpdateEvent = "Click";
            this.dsSampleAddr.UpdateMethod = null;
            this.dsSampleAddr.UpdateTrigger = null;
            // 
            // schemadsSampleAddr
            // 
            this.schemadsSampleAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddrL3DataTableCode,
            this.coldsSampleAddrL3DataTableCode_Des});
            this.schemadsSampleAddr.TableName = "L3DataTable";
            // 
            // coldsSampleAddrL3DataTableCode
            // 
            this.coldsSampleAddrL3DataTableCode.Caption = "Code";
            this.coldsSampleAddrL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddrL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddrL3DataTableCode_Des
            // 
            this.coldsSampleAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.Namespace = "";
            // 
            // sampleTypeDataGridViewTextBoxColumn
            // 
            this.sampleTypeDataGridViewTextBoxColumn.DataPropertyName = "Sample_Type";
            this.sampleTypeDataGridViewTextBoxColumn.DataSource = this.dsSampleType;
            this.sampleTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sampleTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sampleTypeDataGridViewTextBoxColumn.HeaderText = "试样类别";
            this.sampleTypeDataGridViewTextBoxColumn.Name = "sampleTypeDataGridViewTextBoxColumn";
            this.sampleTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sampleTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sampleTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsSampleType
            // 
            this.dsSampleType.AutoLoad = true;
            this.dsSampleType.AutoSubscribe = false;
            this.dsSampleType.DataSetName = "L3DataSet";
            this.dsSampleType.DeleteMethod = null;
            this.dsSampleType.InsertMethod = null;
            this.dsSampleType.L3DataAdapter = this.Adapter;
            this.dsSampleType.LoadEvent = "Click";
            this.dsSampleType.LoadTrigger = null;
            this.dsSampleType.RefreshValve = 1000;
            this.dsSampleType.SourceCommand = null;
            this.dsSampleType.SourceCondition = "CODE_GROUP = \'QA_Sample_Type\'";
            this.dsSampleType.SourceMethod = "";
            this.dsSampleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleType.SubscribeTarget = null;
            this.dsSampleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleType});
            this.dsSampleType.UpdateEvent = "Click";
            this.dsSampleType.UpdateMethod = null;
            this.dsSampleType.UpdateTrigger = null;
            // 
            // schemadsSampleType
            // 
            this.schemadsSampleType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleTypeL3DataTableCode,
            this.coldsSampleTypeL3DataTableCode_Des});
            this.schemadsSampleType.TableName = "L3DataTable";
            // 
            // coldsSampleTypeL3DataTableCode
            // 
            this.coldsSampleTypeL3DataTableCode.Caption = "Code";
            this.coldsSampleTypeL3DataTableCode.ColumnName = "Code";
            this.coldsSampleTypeL3DataTableCode.Namespace = "";
            // 
            // coldsSampleTypeL3DataTableCode_Des
            // 
            this.coldsSampleTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.Namespace = "";
            // 
            // sampleCountDataGridViewTextBoxColumn
            // 
            this.sampleCountDataGridViewTextBoxColumn.DataPropertyName = "Sample_Count";
            this.sampleCountDataGridViewTextBoxColumn.HeaderText = "取样次数";
            this.sampleCountDataGridViewTextBoxColumn.Name = "sampleCountDataGridViewTextBoxColumn";
            // 
            // C
            // 
            this.C.DataPropertyName = "C";
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.Width = 50;
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            this.siDataGridViewTextBoxColumn.Width = 50;
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            this.mnDataGridViewTextBoxColumn.Width = 50;
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            this.pDataGridViewTextBoxColumn.Width = 50;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 50;
            // 
            // alDataGridViewTextBoxColumn
            // 
            this.alDataGridViewTextBoxColumn.DataPropertyName = "Al";
            this.alDataGridViewTextBoxColumn.HeaderText = "Al";
            this.alDataGridViewTextBoxColumn.Name = "alDataGridViewTextBoxColumn";
            this.alDataGridViewTextBoxColumn.Width = 50;
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            this.crDataGridViewTextBoxColumn.Width = 50;
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            this.tiDataGridViewTextBoxColumn.Width = 50;
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            this.vDataGridViewTextBoxColumn.Width = 50;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.Width = 50;
            // 
            // moDataGridViewTextBoxColumn
            // 
            this.moDataGridViewTextBoxColumn.DataPropertyName = "Mo";
            this.moDataGridViewTextBoxColumn.HeaderText = "Mo";
            this.moDataGridViewTextBoxColumn.Name = "moDataGridViewTextBoxColumn";
            this.moDataGridViewTextBoxColumn.Width = 50;
            // 
            // niDataGridViewTextBoxColumn
            // 
            this.niDataGridViewTextBoxColumn.DataPropertyName = "Ni";
            this.niDataGridViewTextBoxColumn.HeaderText = "Ni";
            this.niDataGridViewTextBoxColumn.Name = "niDataGridViewTextBoxColumn";
            this.niDataGridViewTextBoxColumn.Width = 50;
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            this.caDataGridViewTextBoxColumn.Width = 50;
            // 
            // cuDataGridViewTextBoxColumn
            // 
            this.cuDataGridViewTextBoxColumn.DataPropertyName = "Cu";
            this.cuDataGridViewTextBoxColumn.HeaderText = "Cu";
            this.cuDataGridViewTextBoxColumn.Name = "cuDataGridViewTextBoxColumn";
            this.cuDataGridViewTextBoxColumn.Width = 50;
            // 
            // nbDataGridViewTextBoxColumn
            // 
            this.nbDataGridViewTextBoxColumn.DataPropertyName = "Nb";
            this.nbDataGridViewTextBoxColumn.HeaderText = "Nb";
            this.nbDataGridViewTextBoxColumn.Name = "nbDataGridViewTextBoxColumn";
            this.nbDataGridViewTextBoxColumn.Width = 50;
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "Sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            this.snDataGridViewTextBoxColumn.Width = 50;
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            this.wDataGridViewTextBoxColumn.Width = 50;
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "Pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "Pb";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            this.pbDataGridViewTextBoxColumn.Width = 50;
            // 
            // znDataGridViewTextBoxColumn
            // 
            this.znDataGridViewTextBoxColumn.DataPropertyName = "Zn";
            this.znDataGridViewTextBoxColumn.HeaderText = "Zn";
            this.znDataGridViewTextBoxColumn.Name = "znDataGridViewTextBoxColumn";
            this.znDataGridViewTextBoxColumn.Width = 50;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.Width = 50;
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            this.hDataGridViewTextBoxColumn.Width = 50;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.Width = 50;
            // 
            // asDataGridViewTextBoxColumn
            // 
            this.asDataGridViewTextBoxColumn.DataPropertyName = "As";
            this.asDataGridViewTextBoxColumn.HeaderText = "As";
            this.asDataGridViewTextBoxColumn.Name = "asDataGridViewTextBoxColumn";
            this.asDataGridViewTextBoxColumn.Width = 50;
            // 
            // alSDataGridViewTextBoxColumn
            // 
            this.alSDataGridViewTextBoxColumn.DataPropertyName = "AlS";
            this.alSDataGridViewTextBoxColumn.HeaderText = "AlS";
            this.alSDataGridViewTextBoxColumn.Name = "alSDataGridViewTextBoxColumn";
            this.alSDataGridViewTextBoxColumn.Width = 50;
            // 
            // sbDataGridViewTextBoxColumn
            // 
            this.sbDataGridViewTextBoxColumn.DataPropertyName = "Sb";
            this.sbDataGridViewTextBoxColumn.HeaderText = "Sb";
            this.sbDataGridViewTextBoxColumn.Name = "sbDataGridViewTextBoxColumn";
            this.sbDataGridViewTextBoxColumn.Width = 50;
            // 
            // reDataGridViewTextBoxColumn
            // 
            this.reDataGridViewTextBoxColumn.DataPropertyName = "Re";
            this.reDataGridViewTextBoxColumn.HeaderText = "Re";
            this.reDataGridViewTextBoxColumn.Name = "reDataGridViewTextBoxColumn";
            this.reDataGridViewTextBoxColumn.Width = 50;
            // 
            // ceqDataGridViewTextBoxColumn
            // 
            this.ceqDataGridViewTextBoxColumn.DataPropertyName = "Ceq";
            this.ceqDataGridViewTextBoxColumn.HeaderText = "Ceq";
            this.ceqDataGridViewTextBoxColumn.Name = "ceqDataGridViewTextBoxColumn";
            this.ceqDataGridViewTextBoxColumn.Width = 50;
            // 
            // CrNi
            // 
            this.CrNi.DataPropertyName = "CrNi";
            this.CrNi.HeaderText = "CrNi";
            this.CrNi.Name = "CrNi";
            this.CrNi.Width = 50;
            // 
            // CrCu
            // 
            this.CrCu.DataPropertyName = "CrCu";
            this.CrCu.HeaderText = "CrCu";
            this.CrCu.Name = "CrCu";
            this.CrCu.Width = 50;
            // 
            // CrNiCu
            // 
            this.CrNiCu.DataPropertyName = "CrNiCu";
            this.CrNiCu.HeaderText = "CrNiCu";
            this.CrNiCu.Name = "CrNiCu";
            this.CrNiCu.Width = 50;
            // 
            // other1DataGridViewTextBoxColumn
            // 
            this.other1DataGridViewTextBoxColumn.DataPropertyName = "Other1";
            this.other1DataGridViewTextBoxColumn.HeaderText = "其他1";
            this.other1DataGridViewTextBoxColumn.Name = "other1DataGridViewTextBoxColumn";
            this.other1DataGridViewTextBoxColumn.Width = 50;
            // 
            // other2DataGridViewTextBoxColumn
            // 
            this.other2DataGridViewTextBoxColumn.DataPropertyName = "Other2";
            this.other2DataGridViewTextBoxColumn.HeaderText = "其他2";
            this.other2DataGridViewTextBoxColumn.Name = "other2DataGridViewTextBoxColumn";
            this.other2DataGridViewTextBoxColumn.Width = 50;
            // 
            // Other3
            // 
            this.Other3.DataPropertyName = "Other3";
            this.Other3.HeaderText = "其他3";
            this.Other3.Name = "Other3";
            this.Other3.Width = 50;
            // 
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime";
            dataGridViewCellStyle15.Format = "G";
            this.logTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "数据记录时间";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            this.logTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // dataLogModeDataGridViewTextBoxColumn
            // 
            this.dataLogModeDataGridViewTextBoxColumn.DataPropertyName = "DataLogMode";
            this.dataLogModeDataGridViewTextBoxColumn.DataSource = this.dsDataLogMode;
            this.dataLogModeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.dataLogModeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataLogModeDataGridViewTextBoxColumn.HeaderText = "数据产生方式";
            this.dataLogModeDataGridViewTextBoxColumn.Name = "dataLogModeDataGridViewTextBoxColumn";
            this.dataLogModeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLogModeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataLogModeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsDataLogMode
            // 
            this.dsDataLogMode.AutoLoad = true;
            this.dsDataLogMode.AutoSubscribe = false;
            this.dsDataLogMode.DataSetName = "L3DataSet";
            this.dsDataLogMode.DeleteMethod = null;
            this.dsDataLogMode.InsertMethod = null;
            this.dsDataLogMode.L3DataAdapter = this.Adapter;
            this.dsDataLogMode.LoadEvent = "Click";
            this.dsDataLogMode.LoadTrigger = null;
            this.dsDataLogMode.RefreshValve = 1000;
            this.dsDataLogMode.SourceCommand = null;
            this.dsDataLogMode.SourceCondition = "CODE_GROUP = \'DataLogMode\' and code is not null order by code";
            this.dsDataLogMode.SourceMethod = "";
            this.dsDataLogMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDataLogMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDataLogMode.SubscribeTarget = null;
            this.dsDataLogMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDataLogMode});
            this.dsDataLogMode.UpdateEvent = "Click";
            this.dsDataLogMode.UpdateMethod = null;
            this.dsDataLogMode.UpdateTrigger = null;
            // 
            // schemadsDataLogMode
            // 
            this.schemadsDataLogMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDataLogModeL3DataTableCode_Des,
            this.coldsDataLogModeL3DataTableCode_Val_Long});
            this.schemadsDataLogMode.TableName = "L3DataTable";
            // 
            // coldsDataLogModeL3DataTableCode_Des
            // 
            this.coldsDataLogModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDataLogModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDataLogModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDataLogModeL3DataTableCode_Val_Long
            // 
            this.coldsDataLogModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDataLogModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDataLogModeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsDataLogModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // bsChemical
            // 
            this.bsChemical.DataMember = "L3DataTable";
            this.bsChemical.DataSource = this.dsChemical;
            // 
            // dsChemical
            // 
            this.dsChemical.AutoLoad = true;
            this.dsChemical.AutoSubscribe = false;
            this.dsChemical.DataSetName = "L3DataSet";
            this.dsChemical.DeleteMethod = null;
            this.dsChemical.InsertMethod = null;
            this.dsChemical.L3DataAdapter = null;
            this.dsChemical.LoadEvent = "Click";
            this.dsChemical.LoadTrigger = null;
            this.dsChemical.RefreshValve = 1000;
            this.dsChemical.SourceCommand = null;
            this.dsChemical.SourceCondition = "";
            this.dsChemical.SourceMethod = "";
            this.dsChemical.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsChemical.SourceURI = "XGMESLogic\\QualityMag\\CQA_Lab_Element";
            this.dsChemical.SubscribeTarget = null;
            this.dsChemical.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsChemical});
            this.dsChemical.UpdateEvent = "Click";
            this.dsChemical.UpdateMethod = null;
            this.dsChemical.UpdateTrigger = null;
            // 
            // schemadsChemical
            // 
            this.schemadsChemical.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChemicalL3DataTableAppID,
            this.coldsChemicalL3DataTableSample_Code,
            this.coldsChemicalL3DataTableArrive_Date,
            this.coldsChemicalL3DataTableReport_Date,
            this.coldsChemicalL3DataTableHeatID,
            this.coldsChemicalL3DataTableUnitTypeID,
            this.coldsChemicalL3DataTableUnitID,
            this.coldsChemicalL3DataTableSample_Address,
            this.coldsChemicalL3DataTableSample_Type,
            this.coldsChemicalL3DataTableSample_Count,
            this.coldsChemicalL3DataTableC,
            this.coldsChemicalL3DataTableSi,
            this.coldsChemicalL3DataTableMn,
            this.coldsChemicalL3DataTableP,
            this.coldsChemicalL3DataTableS,
            this.coldsChemicalL3DataTableCu,
            this.coldsChemicalL3DataTableNi,
            this.coldsChemicalL3DataTableCr,
            this.coldsChemicalL3DataTableMo,
            this.coldsChemicalL3DataTableV,
            this.coldsChemicalL3DataTableNb,
            this.coldsChemicalL3DataTableAl,
            this.coldsChemicalL3DataTableAlS,
            this.coldsChemicalL3DataTableTi,
            this.coldsChemicalL3DataTableB,
            this.coldsChemicalL3DataTableSb,
            this.coldsChemicalL3DataTableAs,
            this.coldsChemicalL3DataTableSn,
            this.coldsChemicalL3DataTableZn,
            this.coldsChemicalL3DataTableCa,
            this.coldsChemicalL3DataTableW,
            this.coldsChemicalL3DataTablePb,
            this.coldsChemicalL3DataTableRe,
            this.coldsChemicalL3DataTableCeq,
            this.coldsChemicalL3DataTableN,
            this.coldsChemicalL3DataTableH,
            this.coldsChemicalL3DataTableO,
            this.coldsChemicalL3DataTableOther1,
            this.coldsChemicalL3DataTableOther2,
            this.coldsChemicalL3DataTableLogTime,
            this.coldsChemicalL3DataTableDataLogMode,
            this.coldsChemicalL3DataTableGUID,
            this.coldsChemicalL3DataTableName});
            this.schemadsChemical.TableName = "L3DataTable";
            // 
            // coldsChemicalL3DataTableAppID
            // 
            this.coldsChemicalL3DataTableAppID.Caption = "AppID";
            this.coldsChemicalL3DataTableAppID.ColumnName = "AppID";
            this.coldsChemicalL3DataTableAppID.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Code
            // 
            this.coldsChemicalL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsChemicalL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsChemicalL3DataTableSample_Code.Namespace = "";
            // 
            // coldsChemicalL3DataTableArrive_Date
            // 
            this.coldsChemicalL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsChemicalL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsChemicalL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsChemicalL3DataTableReport_Date
            // 
            this.coldsChemicalL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsChemicalL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsChemicalL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableReport_Date.Namespace = "";
            // 
            // coldsChemicalL3DataTableHeatID
            // 
            this.coldsChemicalL3DataTableHeatID.Caption = "HeatID";
            this.coldsChemicalL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsChemicalL3DataTableHeatID.Namespace = "";
            // 
            // coldsChemicalL3DataTableUnitTypeID
            // 
            this.coldsChemicalL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsChemicalL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsChemicalL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsChemicalL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsChemicalL3DataTableUnitID
            // 
            this.coldsChemicalL3DataTableUnitID.Caption = "UnitID";
            this.coldsChemicalL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsChemicalL3DataTableUnitID.DataType = typeof(int);
            this.coldsChemicalL3DataTableUnitID.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Address
            // 
            this.coldsChemicalL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsChemicalL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsChemicalL3DataTableSample_Address.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Type
            // 
            this.coldsChemicalL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsChemicalL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsChemicalL3DataTableSample_Type.Namespace = "";
            // 
            // coldsChemicalL3DataTableSample_Count
            // 
            this.coldsChemicalL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsChemicalL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsChemicalL3DataTableSample_Count.Namespace = "";
            // 
            // coldsChemicalL3DataTableC
            // 
            this.coldsChemicalL3DataTableC.Caption = "C";
            this.coldsChemicalL3DataTableC.ColumnName = "C";
            this.coldsChemicalL3DataTableC.Namespace = "";
            // 
            // coldsChemicalL3DataTableSi
            // 
            this.coldsChemicalL3DataTableSi.Caption = "Si";
            this.coldsChemicalL3DataTableSi.ColumnName = "Si";
            this.coldsChemicalL3DataTableSi.Namespace = "";
            // 
            // coldsChemicalL3DataTableMn
            // 
            this.coldsChemicalL3DataTableMn.Caption = "Mn";
            this.coldsChemicalL3DataTableMn.ColumnName = "Mn";
            this.coldsChemicalL3DataTableMn.Namespace = "";
            // 
            // coldsChemicalL3DataTableP
            // 
            this.coldsChemicalL3DataTableP.Caption = "P";
            this.coldsChemicalL3DataTableP.ColumnName = "P";
            this.coldsChemicalL3DataTableP.Namespace = "";
            // 
            // coldsChemicalL3DataTableS
            // 
            this.coldsChemicalL3DataTableS.Caption = "S";
            this.coldsChemicalL3DataTableS.ColumnName = "S";
            this.coldsChemicalL3DataTableS.Namespace = "";
            // 
            // coldsChemicalL3DataTableCu
            // 
            this.coldsChemicalL3DataTableCu.Caption = "Cu";
            this.coldsChemicalL3DataTableCu.ColumnName = "Cu";
            this.coldsChemicalL3DataTableCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableNi
            // 
            this.coldsChemicalL3DataTableNi.Caption = "Ni";
            this.coldsChemicalL3DataTableNi.ColumnName = "Ni";
            this.coldsChemicalL3DataTableNi.Namespace = "";
            // 
            // coldsChemicalL3DataTableCr
            // 
            this.coldsChemicalL3DataTableCr.Caption = "Cr";
            this.coldsChemicalL3DataTableCr.ColumnName = "Cr";
            this.coldsChemicalL3DataTableCr.Namespace = "";
            // 
            // coldsChemicalL3DataTableMo
            // 
            this.coldsChemicalL3DataTableMo.Caption = "Mo";
            this.coldsChemicalL3DataTableMo.ColumnName = "Mo";
            this.coldsChemicalL3DataTableMo.Namespace = "";
            // 
            // coldsChemicalL3DataTableV
            // 
            this.coldsChemicalL3DataTableV.Caption = "V";
            this.coldsChemicalL3DataTableV.ColumnName = "V";
            this.coldsChemicalL3DataTableV.Namespace = "";
            // 
            // coldsChemicalL3DataTableNb
            // 
            this.coldsChemicalL3DataTableNb.Caption = "Nb";
            this.coldsChemicalL3DataTableNb.ColumnName = "Nb";
            this.coldsChemicalL3DataTableNb.Namespace = "";
            // 
            // coldsChemicalL3DataTableAl
            // 
            this.coldsChemicalL3DataTableAl.Caption = "Al";
            this.coldsChemicalL3DataTableAl.ColumnName = "Al";
            this.coldsChemicalL3DataTableAl.Namespace = "";
            // 
            // coldsChemicalL3DataTableAlS
            // 
            this.coldsChemicalL3DataTableAlS.Caption = "AlS";
            this.coldsChemicalL3DataTableAlS.ColumnName = "AlS";
            this.coldsChemicalL3DataTableAlS.Namespace = "";
            // 
            // coldsChemicalL3DataTableTi
            // 
            this.coldsChemicalL3DataTableTi.Caption = "Ti";
            this.coldsChemicalL3DataTableTi.ColumnName = "Ti";
            this.coldsChemicalL3DataTableTi.Namespace = "";
            // 
            // coldsChemicalL3DataTableB
            // 
            this.coldsChemicalL3DataTableB.Caption = "B";
            this.coldsChemicalL3DataTableB.ColumnName = "B";
            this.coldsChemicalL3DataTableB.Namespace = "";
            // 
            // coldsChemicalL3DataTableSb
            // 
            this.coldsChemicalL3DataTableSb.Caption = "Sb";
            this.coldsChemicalL3DataTableSb.ColumnName = "Sb";
            this.coldsChemicalL3DataTableSb.Namespace = "";
            // 
            // coldsChemicalL3DataTableAs
            // 
            this.coldsChemicalL3DataTableAs.Caption = "As";
            this.coldsChemicalL3DataTableAs.ColumnName = "As";
            this.coldsChemicalL3DataTableAs.Namespace = "";
            // 
            // coldsChemicalL3DataTableSn
            // 
            this.coldsChemicalL3DataTableSn.Caption = "Sn";
            this.coldsChemicalL3DataTableSn.ColumnName = "Sn";
            this.coldsChemicalL3DataTableSn.Namespace = "";
            // 
            // coldsChemicalL3DataTableZn
            // 
            this.coldsChemicalL3DataTableZn.Caption = "Zn";
            this.coldsChemicalL3DataTableZn.ColumnName = "Zn";
            this.coldsChemicalL3DataTableZn.Namespace = "";
            // 
            // coldsChemicalL3DataTableCa
            // 
            this.coldsChemicalL3DataTableCa.Caption = "Ca";
            this.coldsChemicalL3DataTableCa.ColumnName = "Ca";
            this.coldsChemicalL3DataTableCa.Namespace = "";
            // 
            // coldsChemicalL3DataTableW
            // 
            this.coldsChemicalL3DataTableW.Caption = "W";
            this.coldsChemicalL3DataTableW.ColumnName = "W";
            this.coldsChemicalL3DataTableW.Namespace = "";
            // 
            // coldsChemicalL3DataTablePb
            // 
            this.coldsChemicalL3DataTablePb.Caption = "Pb";
            this.coldsChemicalL3DataTablePb.ColumnName = "Pb";
            this.coldsChemicalL3DataTablePb.Namespace = "";
            // 
            // coldsChemicalL3DataTableRe
            // 
            this.coldsChemicalL3DataTableRe.Caption = "Re";
            this.coldsChemicalL3DataTableRe.ColumnName = "Re";
            this.coldsChemicalL3DataTableRe.Namespace = "";
            // 
            // coldsChemicalL3DataTableCeq
            // 
            this.coldsChemicalL3DataTableCeq.Caption = "Ceq";
            this.coldsChemicalL3DataTableCeq.ColumnName = "Ceq";
            this.coldsChemicalL3DataTableCeq.Namespace = "";
            // 
            // coldsChemicalL3DataTableN
            // 
            this.coldsChemicalL3DataTableN.Caption = "N";
            this.coldsChemicalL3DataTableN.ColumnName = "N";
            this.coldsChemicalL3DataTableN.Namespace = "";
            // 
            // coldsChemicalL3DataTableH
            // 
            this.coldsChemicalL3DataTableH.Caption = "H";
            this.coldsChemicalL3DataTableH.ColumnName = "H";
            this.coldsChemicalL3DataTableH.Namespace = "";
            // 
            // coldsChemicalL3DataTableO
            // 
            this.coldsChemicalL3DataTableO.Caption = "O";
            this.coldsChemicalL3DataTableO.ColumnName = "O";
            this.coldsChemicalL3DataTableO.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther1
            // 
            this.coldsChemicalL3DataTableOther1.Caption = "Other1";
            this.coldsChemicalL3DataTableOther1.ColumnName = "Other1";
            this.coldsChemicalL3DataTableOther1.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther2
            // 
            this.coldsChemicalL3DataTableOther2.Caption = "Other2";
            this.coldsChemicalL3DataTableOther2.ColumnName = "Other2";
            this.coldsChemicalL3DataTableOther2.Namespace = "";
            // 
            // coldsChemicalL3DataTableLogTime
            // 
            this.coldsChemicalL3DataTableLogTime.Caption = "LogTime";
            this.coldsChemicalL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsChemicalL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsChemicalL3DataTableLogTime.Namespace = "";
            // 
            // coldsChemicalL3DataTableDataLogMode
            // 
            this.coldsChemicalL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsChemicalL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsChemicalL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsChemicalL3DataTableDataLogMode.Namespace = "";
            // 
            // coldsChemicalL3DataTableGUID
            // 
            this.coldsChemicalL3DataTableGUID.Caption = "GUID";
            this.coldsChemicalL3DataTableGUID.ColumnName = "GUID";
            this.coldsChemicalL3DataTableGUID.Namespace = "";
            // 
            // coldsChemicalL3DataTableName
            // 
            this.coldsChemicalL3DataTableName.Caption = "Name";
            this.coldsChemicalL3DataTableName.ColumnName = "Name";
            this.coldsChemicalL3DataTableName.Namespace = "";
            // 
            // bnChemical
            // 
            this.bnChemical.AddNewItem = null;
            this.bnChemical.BindingSource = this.bsChemical;
            this.bnChemical.CountItem = this.bindingNavigatorCountItem1;
            this.bnChemical.DeleteItem = null;
            this.bnChemical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.btnAddChemical,
            this.btnDelChemical,
            this.btnRefEle});
            this.bnChemical.Location = new System.Drawing.Point(3, 3);
            this.bnChemical.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bnChemical.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bnChemical.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bnChemical.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bnChemical.Name = "bnChemical";
            this.bnChemical.PositionItem = this.bindingNavigatorPositionItem1;
            this.bnChemical.Size = new System.Drawing.Size(957, 25);
            this.bnChemical.TabIndex = 91;
            this.bnChemical.Text = "bindingNavigator1";
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
            // btnAddChemical
            // 
            this.btnAddChemical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddChemical.Image = ((System.Drawing.Image)(resources.GetObject("btnAddChemical.Image")));
            this.btnAddChemical.Name = "btnAddChemical";
            this.btnAddChemical.RightToLeftAutoMirrorImage = true;
            this.btnAddChemical.Size = new System.Drawing.Size(23, 22);
            this.btnAddChemical.Text = "新添";
            this.btnAddChemical.Click += new System.EventHandler(this.btnAddChemical_Click);
            // 
            // btnDelChemical
            // 
            this.btnDelChemical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelChemical.Image = ((System.Drawing.Image)(resources.GetObject("btnDelChemical.Image")));
            this.btnDelChemical.Name = "btnDelChemical";
            this.btnDelChemical.RightToLeftAutoMirrorImage = true;
            this.btnDelChemical.Size = new System.Drawing.Size(23, 22);
            this.btnDelChemical.Text = "删除";
            this.btnDelChemical.Click += new System.EventHandler(this.btnDelChemical_Click);
            // 
            // btnRefEle
            // 
            this.btnRefEle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefEle.Image = ((System.Drawing.Image)(resources.GetObject("btnRefEle.Image")));
            this.btnRefEle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefEle.Name = "btnRefEle";
            this.btnRefEle.Size = new System.Drawing.Size(23, 22);
            this.btnRefEle.Text = "toolStripButton25";
            this.btnRefEle.ToolTipText = "刷新";
            this.btnRefEle.Click += new System.EventHandler(this.btnChemicalCancel_Click);
            // 
            // fLPChemical
            // 
            this.fLPChemical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPChemical.Controls.Add(this.btnChemicalCancel);
            this.fLPChemical.Controls.Add(this.btnChemicalConfirm);
            this.fLPChemical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPChemical.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPChemical.Location = new System.Drawing.Point(3, 674);
            this.fLPChemical.Name = "fLPChemical";
            this.fLPChemical.Size = new System.Drawing.Size(957, 33);
            this.fLPChemical.TabIndex = 90;
            // 
            // btnChemicalCancel
            // 
            this.btnChemicalCancel.Location = new System.Drawing.Point(875, 3);
            this.btnChemicalCancel.Name = "btnChemicalCancel";
            this.btnChemicalCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChemicalCancel.TabIndex = 87;
            this.btnChemicalCancel.Text = "取消";
            this.btnChemicalCancel.UseVisualStyleBackColor = true;
            this.btnChemicalCancel.Click += new System.EventHandler(this.btnChemicalCancel_Click);
            // 
            // btnChemicalConfirm
            // 
            this.btnChemicalConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnChemicalConfirm.Name = "btnChemicalConfirm";
            this.btnChemicalConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnChemicalConfirm.TabIndex = 86;
            this.btnChemicalConfirm.Text = "确认";
            this.btnChemicalConfirm.UseVisualStyleBackColor = true;
            this.btnChemicalConfirm.Click += new System.EventHandler(this.btnChemicalConfirm_Click);
            // 
            // tabBottomBlow
            // 
            this.tabBottomBlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBottomBlow.Controls.Add(this.dvBottomBlow);
            this.tabBottomBlow.Controls.Add(this.bnBottomBlow);
            this.tabBottomBlow.Controls.Add(this.fLPBottomBlow);
            this.tabBottomBlow.Location = new System.Drawing.Point(4, 21);
            this.tabBottomBlow.Name = "tabBottomBlow";
            this.tabBottomBlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabBottomBlow.Size = new System.Drawing.Size(965, 712);
            this.tabBottomBlow.TabIndex = 8;
            this.tabBottomBlow.Text = "底吹数据";
            this.tabBottomBlow.UseVisualStyleBackColor = true;
            // 
            // dvBottomBlow
            // 
            this.dvBottomBlow.AllowUserToAddRows = false;
            this.dvBottomBlow.AllowUserToDeleteRows = false;
            this.dvBottomBlow.AutoGenerateColumns = false;
            this.dvBottomBlow.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvBottomBlow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dvBottomBlow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvBottomBlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn2,
            this.flow1DataGridViewTextBoxColumn,
            this.pressure1DataGridViewTextBoxColumn,
            this.flow2DataGridViewTextBoxColumn,
            this.pressure2DataGridViewTextBoxColumn,
            this.flow3DataGridViewTextBoxColumn,
            this.pressure3DataGridViewTextBoxColumn,
            this.flow4DataGridViewTextBoxColumn,
            this.pressure4DataGridViewTextBoxColumn,
            this.flow5DataGridViewTextBoxColumn,
            this.pressure5DataGridViewTextBoxColumn,
            this.flow6DataGridViewTextBoxColumn,
            this.pressure6DataGridViewTextBoxColumn,
            this.gasTypeDataGridViewTextBoxColumn,
            this.catchTimeDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn1});
            this.dvBottomBlow.DataSource = this.bsBottomBlow;
            this.dvBottomBlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBottomBlow.Location = new System.Drawing.Point(3, 28);
            this.dvBottomBlow.Name = "dvBottomBlow";
            this.dvBottomBlow.RowTemplate.Height = 23;
            this.dvBottomBlow.Size = new System.Drawing.Size(957, 646);
            this.dvBottomBlow.TabIndex = 94;
            this.dvBottomBlow.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn2
            // 
            this.heatIDDataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn2.Name = "heatIDDataGridViewTextBoxColumn2";
            // 
            // flow1DataGridViewTextBoxColumn
            // 
            this.flow1DataGridViewTextBoxColumn.DataPropertyName = "Flow1";
            this.flow1DataGridViewTextBoxColumn.HeaderText = "流量1[Nm3/min]";
            this.flow1DataGridViewTextBoxColumn.Name = "flow1DataGridViewTextBoxColumn";
            this.flow1DataGridViewTextBoxColumn.Width = 114;
            // 
            // pressure1DataGridViewTextBoxColumn
            // 
            this.pressure1DataGridViewTextBoxColumn.DataPropertyName = "Pressure1";
            this.pressure1DataGridViewTextBoxColumn.HeaderText = "压力1[MPa]";
            this.pressure1DataGridViewTextBoxColumn.Name = "pressure1DataGridViewTextBoxColumn";
            this.pressure1DataGridViewTextBoxColumn.Width = 90;
            // 
            // flow2DataGridViewTextBoxColumn
            // 
            this.flow2DataGridViewTextBoxColumn.DataPropertyName = "Flow2";
            this.flow2DataGridViewTextBoxColumn.HeaderText = "流量2[Nm3/min]";
            this.flow2DataGridViewTextBoxColumn.Name = "flow2DataGridViewTextBoxColumn";
            this.flow2DataGridViewTextBoxColumn.Width = 114;
            // 
            // pressure2DataGridViewTextBoxColumn
            // 
            this.pressure2DataGridViewTextBoxColumn.DataPropertyName = "Pressure2";
            this.pressure2DataGridViewTextBoxColumn.HeaderText = "压力2[MPa]";
            this.pressure2DataGridViewTextBoxColumn.Name = "pressure2DataGridViewTextBoxColumn";
            this.pressure2DataGridViewTextBoxColumn.Width = 90;
            // 
            // flow3DataGridViewTextBoxColumn
            // 
            this.flow3DataGridViewTextBoxColumn.DataPropertyName = "Flow3";
            this.flow3DataGridViewTextBoxColumn.HeaderText = "流量3[Nm3/min]";
            this.flow3DataGridViewTextBoxColumn.Name = "flow3DataGridViewTextBoxColumn";
            this.flow3DataGridViewTextBoxColumn.Width = 114;
            // 
            // pressure3DataGridViewTextBoxColumn
            // 
            this.pressure3DataGridViewTextBoxColumn.DataPropertyName = "Pressure3";
            this.pressure3DataGridViewTextBoxColumn.HeaderText = "压力3[MPa]";
            this.pressure3DataGridViewTextBoxColumn.Name = "pressure3DataGridViewTextBoxColumn";
            this.pressure3DataGridViewTextBoxColumn.Width = 90;
            // 
            // flow4DataGridViewTextBoxColumn
            // 
            this.flow4DataGridViewTextBoxColumn.DataPropertyName = "Flow4";
            this.flow4DataGridViewTextBoxColumn.HeaderText = "流量4[Nm3/min]";
            this.flow4DataGridViewTextBoxColumn.Name = "flow4DataGridViewTextBoxColumn";
            this.flow4DataGridViewTextBoxColumn.Width = 114;
            // 
            // pressure4DataGridViewTextBoxColumn
            // 
            this.pressure4DataGridViewTextBoxColumn.DataPropertyName = "Pressure4";
            this.pressure4DataGridViewTextBoxColumn.HeaderText = "压力4[MPa]";
            this.pressure4DataGridViewTextBoxColumn.Name = "pressure4DataGridViewTextBoxColumn";
            this.pressure4DataGridViewTextBoxColumn.Width = 90;
            // 
            // flow5DataGridViewTextBoxColumn
            // 
            this.flow5DataGridViewTextBoxColumn.DataPropertyName = "Flow5";
            this.flow5DataGridViewTextBoxColumn.HeaderText = "流量5[Nm3/min]";
            this.flow5DataGridViewTextBoxColumn.Name = "flow5DataGridViewTextBoxColumn";
            this.flow5DataGridViewTextBoxColumn.Width = 114;
            // 
            // pressure5DataGridViewTextBoxColumn
            // 
            this.pressure5DataGridViewTextBoxColumn.DataPropertyName = "Pressure5";
            this.pressure5DataGridViewTextBoxColumn.HeaderText = "压力5[MPa]";
            this.pressure5DataGridViewTextBoxColumn.Name = "pressure5DataGridViewTextBoxColumn";
            this.pressure5DataGridViewTextBoxColumn.Width = 90;
            // 
            // flow6DataGridViewTextBoxColumn
            // 
            this.flow6DataGridViewTextBoxColumn.DataPropertyName = "Flow6";
            this.flow6DataGridViewTextBoxColumn.HeaderText = "流量6[Nm3/min]";
            this.flow6DataGridViewTextBoxColumn.Name = "flow6DataGridViewTextBoxColumn";
            this.flow6DataGridViewTextBoxColumn.Width = 114;
            // 
            // pressure6DataGridViewTextBoxColumn
            // 
            this.pressure6DataGridViewTextBoxColumn.DataPropertyName = "Pressure6";
            this.pressure6DataGridViewTextBoxColumn.HeaderText = "压力6[MPa]";
            this.pressure6DataGridViewTextBoxColumn.Name = "pressure6DataGridViewTextBoxColumn";
            this.pressure6DataGridViewTextBoxColumn.Width = 90;
            // 
            // gasTypeDataGridViewTextBoxColumn
            // 
            this.gasTypeDataGridViewTextBoxColumn.DataPropertyName = "Gas_Type";
            this.gasTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.gasTypeDataGridViewTextBoxColumn.HeaderText = "介质";
            this.gasTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "",
            "N2",
            "Ar"});
            this.gasTypeDataGridViewTextBoxColumn.Name = "gasTypeDataGridViewTextBoxColumn";
            this.gasTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gasTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gasTypeDataGridViewTextBoxColumn.Width = 54;
            // 
            // catchTimeDataGridViewTextBoxColumn
            // 
            this.catchTimeDataGridViewTextBoxColumn.DataPropertyName = "Catch_Time";
            dataGridViewCellStyle17.Format = "G";
            this.catchTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.catchTimeDataGridViewTextBoxColumn.HeaderText = "采集时刻";
            this.catchTimeDataGridViewTextBoxColumn.Name = "catchTimeDataGridViewTextBoxColumn";
            this.catchTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.catchTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // objectIDDataGridViewTextBoxColumn1
            // 
            this.objectIDDataGridViewTextBoxColumn1.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn1.HeaderText = "";
            this.objectIDDataGridViewTextBoxColumn1.Name = "objectIDDataGridViewTextBoxColumn1";
            this.objectIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bsBottomBlow
            // 
            this.bsBottomBlow.DataMember = "L3DataTable";
            this.bsBottomBlow.DataSource = this.dsBottomBlow;
            // 
            // dsBottomBlow
            // 
            this.dsBottomBlow.AutoLoad = true;
            this.dsBottomBlow.AutoSubscribe = false;
            this.dsBottomBlow.DataSetName = "L3DataSet";
            this.dsBottomBlow.DeleteMethod = null;
            this.dsBottomBlow.InsertMethod = null;
            this.dsBottomBlow.L3DataAdapter = null;
            this.dsBottomBlow.LoadEvent = "Click";
            this.dsBottomBlow.LoadTrigger = null;
            this.dsBottomBlow.RefreshValve = 1000;
            this.dsBottomBlow.SourceCommand = null;
            this.dsBottomBlow.SourceCondition = "";
            this.dsBottomBlow.SourceMethod = "";
            this.dsBottomBlow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBottomBlow.SourceURI = "XGMESLogic\\AODMag\\CAOD_Bottom_Blowing";
            this.dsBottomBlow.SubscribeTarget = null;
            this.dsBottomBlow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBottomBlow});
            this.dsBottomBlow.UpdateEvent = "Click";
            this.dsBottomBlow.UpdateMethod = null;
            this.dsBottomBlow.UpdateTrigger = null;
            // 
            // schemadsBottomBlow
            // 
            this.schemadsBottomBlow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBottomBlowL3DataTableHeatID,
            this.coldsBottomBlowL3DataTableFlow1,
            this.coldsBottomBlowL3DataTablePressure1,
            this.coldsBottomBlowL3DataTableFlow2,
            this.coldsBottomBlowL3DataTablePressure2,
            this.coldsBottomBlowL3DataTableFlow3,
            this.coldsBottomBlowL3DataTablePressure3,
            this.coldsBottomBlowL3DataTableFlow4,
            this.coldsBottomBlowL3DataTablePressure4,
            this.coldsBottomBlowL3DataTableFlow5,
            this.coldsBottomBlowL3DataTablePressure5,
            this.coldsBottomBlowL3DataTableFlow6,
            this.coldsBottomBlowL3DataTablePressure6,
            this.coldsBottomBlowL3DataTableGas_Type,
            this.coldsBottomBlowL3DataTableCatch_Time,
            this.coldsBottomBlowL3DataTableObjectID,
            this.coldsBottomBlowL3DataTableGUID,
            this.coldsBottomBlowL3DataTableName});
            this.schemadsBottomBlow.TableName = "L3DataTable";
            // 
            // coldsBottomBlowL3DataTableHeatID
            // 
            this.coldsBottomBlowL3DataTableHeatID.Caption = "HeatID";
            this.coldsBottomBlowL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBottomBlowL3DataTableHeatID.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableFlow1
            // 
            this.coldsBottomBlowL3DataTableFlow1.Caption = "Flow1";
            this.coldsBottomBlowL3DataTableFlow1.ColumnName = "Flow1";
            this.coldsBottomBlowL3DataTableFlow1.DataType = typeof(double);
            this.coldsBottomBlowL3DataTableFlow1.Namespace = "";
            // 
            // coldsBottomBlowL3DataTablePressure1
            // 
            this.coldsBottomBlowL3DataTablePressure1.Caption = "Pressure1";
            this.coldsBottomBlowL3DataTablePressure1.ColumnName = "Pressure1";
            this.coldsBottomBlowL3DataTablePressure1.DataType = typeof(double);
            this.coldsBottomBlowL3DataTablePressure1.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableFlow2
            // 
            this.coldsBottomBlowL3DataTableFlow2.Caption = "Flow2";
            this.coldsBottomBlowL3DataTableFlow2.ColumnName = "Flow2";
            this.coldsBottomBlowL3DataTableFlow2.DataType = typeof(double);
            this.coldsBottomBlowL3DataTableFlow2.Namespace = "";
            // 
            // coldsBottomBlowL3DataTablePressure2
            // 
            this.coldsBottomBlowL3DataTablePressure2.Caption = "Pressure2";
            this.coldsBottomBlowL3DataTablePressure2.ColumnName = "Pressure2";
            this.coldsBottomBlowL3DataTablePressure2.DataType = typeof(double);
            this.coldsBottomBlowL3DataTablePressure2.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableFlow3
            // 
            this.coldsBottomBlowL3DataTableFlow3.Caption = "Flow3";
            this.coldsBottomBlowL3DataTableFlow3.ColumnName = "Flow3";
            this.coldsBottomBlowL3DataTableFlow3.DataType = typeof(double);
            this.coldsBottomBlowL3DataTableFlow3.Namespace = "";
            // 
            // coldsBottomBlowL3DataTablePressure3
            // 
            this.coldsBottomBlowL3DataTablePressure3.Caption = "Pressure3";
            this.coldsBottomBlowL3DataTablePressure3.ColumnName = "Pressure3";
            this.coldsBottomBlowL3DataTablePressure3.DataType = typeof(double);
            this.coldsBottomBlowL3DataTablePressure3.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableFlow4
            // 
            this.coldsBottomBlowL3DataTableFlow4.Caption = "Flow4";
            this.coldsBottomBlowL3DataTableFlow4.ColumnName = "Flow4";
            this.coldsBottomBlowL3DataTableFlow4.DataType = typeof(double);
            this.coldsBottomBlowL3DataTableFlow4.Namespace = "";
            // 
            // coldsBottomBlowL3DataTablePressure4
            // 
            this.coldsBottomBlowL3DataTablePressure4.Caption = "Pressure4";
            this.coldsBottomBlowL3DataTablePressure4.ColumnName = "Pressure4";
            this.coldsBottomBlowL3DataTablePressure4.DataType = typeof(double);
            this.coldsBottomBlowL3DataTablePressure4.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableFlow5
            // 
            this.coldsBottomBlowL3DataTableFlow5.Caption = "Flow5";
            this.coldsBottomBlowL3DataTableFlow5.ColumnName = "Flow5";
            this.coldsBottomBlowL3DataTableFlow5.DataType = typeof(double);
            this.coldsBottomBlowL3DataTableFlow5.Namespace = "";
            // 
            // coldsBottomBlowL3DataTablePressure5
            // 
            this.coldsBottomBlowL3DataTablePressure5.Caption = "Pressure5";
            this.coldsBottomBlowL3DataTablePressure5.ColumnName = "Pressure5";
            this.coldsBottomBlowL3DataTablePressure5.DataType = typeof(double);
            this.coldsBottomBlowL3DataTablePressure5.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableFlow6
            // 
            this.coldsBottomBlowL3DataTableFlow6.Caption = "Flow6";
            this.coldsBottomBlowL3DataTableFlow6.ColumnName = "Flow6";
            this.coldsBottomBlowL3DataTableFlow6.DataType = typeof(double);
            this.coldsBottomBlowL3DataTableFlow6.Namespace = "";
            // 
            // coldsBottomBlowL3DataTablePressure6
            // 
            this.coldsBottomBlowL3DataTablePressure6.Caption = "Pressure6";
            this.coldsBottomBlowL3DataTablePressure6.ColumnName = "Pressure6";
            this.coldsBottomBlowL3DataTablePressure6.DataType = typeof(double);
            this.coldsBottomBlowL3DataTablePressure6.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableGas_Type
            // 
            this.coldsBottomBlowL3DataTableGas_Type.Caption = "Gas_Type";
            this.coldsBottomBlowL3DataTableGas_Type.ColumnName = "Gas_Type";
            this.coldsBottomBlowL3DataTableGas_Type.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableCatch_Time
            // 
            this.coldsBottomBlowL3DataTableCatch_Time.Caption = "Catch_Time";
            this.coldsBottomBlowL3DataTableCatch_Time.ColumnName = "Catch_Time";
            this.coldsBottomBlowL3DataTableCatch_Time.DataType = typeof(System.DateTime);
            this.coldsBottomBlowL3DataTableCatch_Time.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableObjectID
            // 
            this.coldsBottomBlowL3DataTableObjectID.Caption = "ObjectID";
            this.coldsBottomBlowL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsBottomBlowL3DataTableObjectID.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableGUID
            // 
            this.coldsBottomBlowL3DataTableGUID.Caption = "GUID";
            this.coldsBottomBlowL3DataTableGUID.ColumnName = "GUID";
            this.coldsBottomBlowL3DataTableGUID.Namespace = "";
            // 
            // coldsBottomBlowL3DataTableName
            // 
            this.coldsBottomBlowL3DataTableName.Caption = "Name";
            this.coldsBottomBlowL3DataTableName.ColumnName = "Name";
            this.coldsBottomBlowL3DataTableName.Namespace = "";
            // 
            // bnBottomBlow
            // 
            this.bnBottomBlow.AddNewItem = null;
            this.bnBottomBlow.BindingSource = this.bsBottomBlow;
            this.bnBottomBlow.CountItem = this.bindingNavigatorCountItem2;
            this.bnBottomBlow.DeleteItem = null;
            this.bnBottomBlow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.btnAddBottomBlow,
            this.btnDelBottomBlow,
            this.toolStripButton26});
            this.bnBottomBlow.Location = new System.Drawing.Point(3, 3);
            this.bnBottomBlow.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bnBottomBlow.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bnBottomBlow.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bnBottomBlow.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bnBottomBlow.Name = "bnBottomBlow";
            this.bnBottomBlow.PositionItem = this.bindingNavigatorPositionItem2;
            this.bnBottomBlow.Size = new System.Drawing.Size(957, 25);
            this.bnBottomBlow.TabIndex = 93;
            this.bnBottomBlow.Text = "bindingNavigator1";
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
            // btnAddBottomBlow
            // 
            this.btnAddBottomBlow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddBottomBlow.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBottomBlow.Image")));
            this.btnAddBottomBlow.Name = "btnAddBottomBlow";
            this.btnAddBottomBlow.RightToLeftAutoMirrorImage = true;
            this.btnAddBottomBlow.Size = new System.Drawing.Size(23, 22);
            this.btnAddBottomBlow.Text = "新添";
            this.btnAddBottomBlow.Click += new System.EventHandler(this.btnAddBottomBlow_Click);
            // 
            // btnDelBottomBlow
            // 
            this.btnDelBottomBlow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelBottomBlow.Image = ((System.Drawing.Image)(resources.GetObject("btnDelBottomBlow.Image")));
            this.btnDelBottomBlow.Name = "btnDelBottomBlow";
            this.btnDelBottomBlow.RightToLeftAutoMirrorImage = true;
            this.btnDelBottomBlow.Size = new System.Drawing.Size(23, 22);
            this.btnDelBottomBlow.Text = "删除";
            this.btnDelBottomBlow.Click += new System.EventHandler(this.btnDelBottomBlow_Click);
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton26.Text = "toolStripButton25";
            this.toolStripButton26.ToolTipText = "刷新";
            this.toolStripButton26.Click += new System.EventHandler(this.btnBottomBlowCancel_Click);
            // 
            // fLPBottomBlow
            // 
            this.fLPBottomBlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPBottomBlow.Controls.Add(this.btnBottomBlowCancel);
            this.fLPBottomBlow.Controls.Add(this.btnBottomBlowConfirm);
            this.fLPBottomBlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPBottomBlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPBottomBlow.Location = new System.Drawing.Point(3, 674);
            this.fLPBottomBlow.Name = "fLPBottomBlow";
            this.fLPBottomBlow.Size = new System.Drawing.Size(957, 33);
            this.fLPBottomBlow.TabIndex = 92;
            // 
            // btnBottomBlowCancel
            // 
            this.btnBottomBlowCancel.Location = new System.Drawing.Point(875, 3);
            this.btnBottomBlowCancel.Name = "btnBottomBlowCancel";
            this.btnBottomBlowCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBottomBlowCancel.TabIndex = 87;
            this.btnBottomBlowCancel.Text = "取消";
            this.btnBottomBlowCancel.UseVisualStyleBackColor = true;
            this.btnBottomBlowCancel.Click += new System.EventHandler(this.btnBottomBlowCancel_Click);
            // 
            // btnBottomBlowConfirm
            // 
            this.btnBottomBlowConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnBottomBlowConfirm.Name = "btnBottomBlowConfirm";
            this.btnBottomBlowConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnBottomBlowConfirm.TabIndex = 86;
            this.btnBottomBlowConfirm.Text = "确认";
            this.btnBottomBlowConfirm.UseVisualStyleBackColor = true;
            this.btnBottomBlowConfirm.Visible = false;
            this.btnBottomBlowConfirm.Click += new System.EventHandler(this.btnBottomBlowConfirm_Click);
            // 
            // tabTopBlow
            // 
            this.tabTopBlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTopBlow.Controls.Add(this.dvTopBlow);
            this.tabTopBlow.Controls.Add(this.bnTopBlow);
            this.tabTopBlow.Controls.Add(this.fLPTopBlow);
            this.tabTopBlow.Location = new System.Drawing.Point(4, 21);
            this.tabTopBlow.Name = "tabTopBlow";
            this.tabTopBlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopBlow.Size = new System.Drawing.Size(965, 712);
            this.tabTopBlow.TabIndex = 7;
            this.tabTopBlow.Text = "顶吹数据";
            this.tabTopBlow.UseVisualStyleBackColor = true;
            // 
            // dvTopBlow
            // 
            this.dvTopBlow.AllowUserToAddRows = false;
            this.dvTopBlow.AllowUserToDeleteRows = false;
            this.dvTopBlow.AutoGenerateColumns = false;
            this.dvTopBlow.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTopBlow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn3,
            this.flowDataGridViewTextBoxColumn,
            this.pressureDataGridViewTextBoxColumn,
            this.Press_MainPipe,
            this.catchTimeDataGridViewTextBoxColumn1});
            this.dvTopBlow.DataSource = this.bsTopBlow;
            this.dvTopBlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTopBlow.Location = new System.Drawing.Point(3, 28);
            this.dvTopBlow.Name = "dvTopBlow";
            this.dvTopBlow.RowTemplate.Height = 23;
            this.dvTopBlow.Size = new System.Drawing.Size(957, 646);
            this.dvTopBlow.TabIndex = 94;
            this.dvTopBlow.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn3
            // 
            this.heatIDDataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn3.Name = "heatIDDataGridViewTextBoxColumn3";
            // 
            // flowDataGridViewTextBoxColumn
            // 
            this.flowDataGridViewTextBoxColumn.DataPropertyName = "Flow";
            this.flowDataGridViewTextBoxColumn.HeaderText = "流量[Nm3/min]";
            this.flowDataGridViewTextBoxColumn.Name = "flowDataGridViewTextBoxColumn";
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            this.pressureDataGridViewTextBoxColumn.HeaderText = "压力[MPa]";
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            // 
            // Press_MainPipe
            // 
            this.Press_MainPipe.DataPropertyName = "Press_MainPipe";
            this.Press_MainPipe.HeaderText = "主管压力[MPa]";
            this.Press_MainPipe.Name = "Press_MainPipe";
            // 
            // catchTimeDataGridViewTextBoxColumn1
            // 
            this.catchTimeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catchTimeDataGridViewTextBoxColumn1.DataPropertyName = "Catch_Time";
            dataGridViewCellStyle18.Format = "G";
            this.catchTimeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            this.catchTimeDataGridViewTextBoxColumn1.HeaderText = "采集时刻";
            this.catchTimeDataGridViewTextBoxColumn1.Name = "catchTimeDataGridViewTextBoxColumn1";
            this.catchTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bsTopBlow
            // 
            this.bsTopBlow.DataMember = "L3DataTable";
            this.bsTopBlow.DataSource = this.dsTopBlow;
            // 
            // dsTopBlow
            // 
            this.dsTopBlow.AutoLoad = true;
            this.dsTopBlow.AutoSubscribe = false;
            this.dsTopBlow.DataSetName = "L3DataSet";
            this.dsTopBlow.DeleteMethod = null;
            this.dsTopBlow.InsertMethod = null;
            this.dsTopBlow.L3DataAdapter = null;
            this.dsTopBlow.LoadEvent = "Click";
            this.dsTopBlow.LoadTrigger = null;
            this.dsTopBlow.RefreshValve = 1000;
            this.dsTopBlow.SourceCommand = null;
            this.dsTopBlow.SourceCondition = "";
            this.dsTopBlow.SourceMethod = "";
            this.dsTopBlow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTopBlow.SourceURI = "XGMESLogic\\AODMag\\CAOD_Top_Blowing";
            this.dsTopBlow.SubscribeTarget = null;
            this.dsTopBlow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTopBlow});
            this.dsTopBlow.UpdateEvent = "Click";
            this.dsTopBlow.UpdateMethod = null;
            this.dsTopBlow.UpdateTrigger = null;
            // 
            // schemadsTopBlow
            // 
            this.schemadsTopBlow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTopBlowL3DataTableHeatID,
            this.coldsTopBlowL3DataTableFlow,
            this.coldsTopBlowL3DataTablePressure,
            this.coldsTopBlowL3DataTableCatch_Time,
            this.coldsTopBlowL3DataTableGUID,
            this.coldsTopBlowL3DataTableName,
            this.coldsTopBlowL3DataTablePress_MainPipe});
            this.schemadsTopBlow.TableName = "L3DataTable";
            // 
            // coldsTopBlowL3DataTableHeatID
            // 
            this.coldsTopBlowL3DataTableHeatID.Caption = "HeatID";
            this.coldsTopBlowL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTopBlowL3DataTableHeatID.Namespace = "";
            // 
            // coldsTopBlowL3DataTableFlow
            // 
            this.coldsTopBlowL3DataTableFlow.Caption = "Flow";
            this.coldsTopBlowL3DataTableFlow.ColumnName = "Flow";
            this.coldsTopBlowL3DataTableFlow.DataType = typeof(float);
            this.coldsTopBlowL3DataTableFlow.Namespace = "";
            // 
            // coldsTopBlowL3DataTablePressure
            // 
            this.coldsTopBlowL3DataTablePressure.Caption = "Pressure";
            this.coldsTopBlowL3DataTablePressure.ColumnName = "Pressure";
            this.coldsTopBlowL3DataTablePressure.DataType = typeof(float);
            this.coldsTopBlowL3DataTablePressure.Namespace = "";
            // 
            // coldsTopBlowL3DataTableCatch_Time
            // 
            this.coldsTopBlowL3DataTableCatch_Time.Caption = "Catch_Time";
            this.coldsTopBlowL3DataTableCatch_Time.ColumnName = "Catch_Time";
            this.coldsTopBlowL3DataTableCatch_Time.DataType = typeof(System.DateTime);
            this.coldsTopBlowL3DataTableCatch_Time.Namespace = "";
            // 
            // coldsTopBlowL3DataTableGUID
            // 
            this.coldsTopBlowL3DataTableGUID.Caption = "GUID";
            this.coldsTopBlowL3DataTableGUID.ColumnName = "GUID";
            this.coldsTopBlowL3DataTableGUID.Namespace = "";
            // 
            // coldsTopBlowL3DataTableName
            // 
            this.coldsTopBlowL3DataTableName.Caption = "Name";
            this.coldsTopBlowL3DataTableName.ColumnName = "Name";
            this.coldsTopBlowL3DataTableName.Namespace = "";
            // 
            // coldsTopBlowL3DataTablePress_MainPipe
            // 
            this.coldsTopBlowL3DataTablePress_MainPipe.Caption = "Press_MainPipe";
            this.coldsTopBlowL3DataTablePress_MainPipe.ColumnName = "Press_MainPipe";
            this.coldsTopBlowL3DataTablePress_MainPipe.DataType = typeof(double);
            this.coldsTopBlowL3DataTablePress_MainPipe.Namespace = "";
            // 
            // bnTopBlow
            // 
            this.bnTopBlow.AddNewItem = null;
            this.bnTopBlow.BindingSource = this.bsTopBlow;
            this.bnTopBlow.CountItem = this.bindingNavigatorCountItem3;
            this.bnTopBlow.DeleteItem = null;
            this.bnTopBlow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.btnAddTopBlow,
            this.btnDelTopBlow,
            this.toolStripButton27});
            this.bnTopBlow.Location = new System.Drawing.Point(3, 3);
            this.bnTopBlow.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bnTopBlow.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bnTopBlow.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bnTopBlow.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bnTopBlow.Name = "bnTopBlow";
            this.bnTopBlow.PositionItem = this.bindingNavigatorPositionItem3;
            this.bnTopBlow.Size = new System.Drawing.Size(957, 25);
            this.bnTopBlow.TabIndex = 93;
            this.bnTopBlow.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem3.Text = "/ {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "位置";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddTopBlow
            // 
            this.btnAddTopBlow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTopBlow.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTopBlow.Image")));
            this.btnAddTopBlow.Name = "btnAddTopBlow";
            this.btnAddTopBlow.RightToLeftAutoMirrorImage = true;
            this.btnAddTopBlow.Size = new System.Drawing.Size(23, 22);
            this.btnAddTopBlow.Text = "新添";
            this.btnAddTopBlow.Click += new System.EventHandler(this.btnAddTopBlow_Click);
            // 
            // btnDelTopBlow
            // 
            this.btnDelTopBlow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelTopBlow.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTopBlow.Image")));
            this.btnDelTopBlow.Name = "btnDelTopBlow";
            this.btnDelTopBlow.RightToLeftAutoMirrorImage = true;
            this.btnDelTopBlow.Size = new System.Drawing.Size(23, 22);
            this.btnDelTopBlow.Text = "删除";
            this.btnDelTopBlow.Click += new System.EventHandler(this.btnDelTopBlow_Click);
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton27.Text = "toolStripButton25";
            this.toolStripButton27.ToolTipText = "刷新";
            this.toolStripButton27.Click += new System.EventHandler(this.btnTopBlowCancel_Click);
            // 
            // fLPTopBlow
            // 
            this.fLPTopBlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPTopBlow.Controls.Add(this.btnTopBlowCancel);
            this.fLPTopBlow.Controls.Add(this.btnTopBlowConfirm);
            this.fLPTopBlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPTopBlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPTopBlow.Location = new System.Drawing.Point(3, 674);
            this.fLPTopBlow.Name = "fLPTopBlow";
            this.fLPTopBlow.Size = new System.Drawing.Size(957, 33);
            this.fLPTopBlow.TabIndex = 92;
            // 
            // btnTopBlowCancel
            // 
            this.btnTopBlowCancel.Location = new System.Drawing.Point(875, 3);
            this.btnTopBlowCancel.Name = "btnTopBlowCancel";
            this.btnTopBlowCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTopBlowCancel.TabIndex = 87;
            this.btnTopBlowCancel.Text = "取消";
            this.btnTopBlowCancel.UseVisualStyleBackColor = true;
            this.btnTopBlowCancel.Click += new System.EventHandler(this.btnTopBlowCancel_Click);
            // 
            // btnTopBlowConfirm
            // 
            this.btnTopBlowConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnTopBlowConfirm.Name = "btnTopBlowConfirm";
            this.btnTopBlowConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnTopBlowConfirm.TabIndex = 86;
            this.btnTopBlowConfirm.Text = "确认";
            this.btnTopBlowConfirm.UseVisualStyleBackColor = true;
            this.btnTopBlowConfirm.Visible = false;
            this.btnTopBlowConfirm.Click += new System.EventHandler(this.btnTopBlowConfirm_Click);
            // 
            // tabStatus
            // 
            this.tabStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatus.Controls.Add(this.dvStatus);
            this.tabStatus.Controls.Add(this.bnStatus);
            this.tabStatus.Controls.Add(this.fLPStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 21);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(965, 712);
            this.tabStatus.TabIndex = 6;
            this.tabStatus.Text = "状态数据";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // dvStatus
            // 
            this.dvStatus.AllowUserToAddRows = false;
            this.dvStatus.AllowUserToDeleteRows = false;
            this.dvStatus.AutoGenerateColumns = false;
            this.dvStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn4,
            this.statusDataGridViewTextBoxColumn,
            this.changeTimeDataGridViewTextBoxColumn});
            this.dvStatus.DataSource = this.bsStatus;
            this.dvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStatus.Location = new System.Drawing.Point(3, 28);
            this.dvStatus.Name = "dvStatus";
            this.dvStatus.RowTemplate.Height = 23;
            this.dvStatus.Size = new System.Drawing.Size(957, 646);
            this.dvStatus.TabIndex = 93;
            this.dvStatus.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn4
            // 
            this.heatIDDataGridViewTextBoxColumn4.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn4.Name = "heatIDDataGridViewTextBoxColumn4";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // changeTimeDataGridViewTextBoxColumn
            // 
            this.changeTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeTimeDataGridViewTextBoxColumn.DataPropertyName = "Change_Time";
            dataGridViewCellStyle19.Format = "G";
            dataGridViewCellStyle19.NullValue = null;
            this.changeTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.changeTimeDataGridViewTextBoxColumn.HeaderText = "状态变化时刻";
            this.changeTimeDataGridViewTextBoxColumn.Name = "changeTimeDataGridViewTextBoxColumn";
            this.changeTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bsStatus
            // 
            this.bsStatus.DataMember = "L3DataTable";
            this.bsStatus.DataSource = this.dsStatus;
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = null;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsStatus.SourceURI = "XGMESLogic\\AODMag\\CAOD_Process_Status";
            this.dsStatus.SubscribeTarget = null;
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = null;
            this.dsStatus.UpdateTrigger = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableHeatID,
            this.coldsStatusL3DataTableStatus,
            this.coldsStatusL3DataTableChange_Time,
            this.coldsStatusL3DataTableGUID,
            this.coldsStatusL3DataTableName});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableHeatID
            // 
            this.coldsStatusL3DataTableHeatID.Caption = "HeatID";
            this.coldsStatusL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsStatusL3DataTableHeatID.Namespace = "";
            // 
            // coldsStatusL3DataTableStatus
            // 
            this.coldsStatusL3DataTableStatus.Caption = "Status";
            this.coldsStatusL3DataTableStatus.ColumnName = "Status";
            this.coldsStatusL3DataTableStatus.Namespace = "";
            // 
            // coldsStatusL3DataTableChange_Time
            // 
            this.coldsStatusL3DataTableChange_Time.Caption = "Change_Time";
            this.coldsStatusL3DataTableChange_Time.ColumnName = "Change_Time";
            this.coldsStatusL3DataTableChange_Time.DataType = typeof(System.DateTime);
            this.coldsStatusL3DataTableChange_Time.Namespace = "";
            // 
            // coldsStatusL3DataTableGUID
            // 
            this.coldsStatusL3DataTableGUID.Caption = "GUID";
            this.coldsStatusL3DataTableGUID.ColumnName = "GUID";
            this.coldsStatusL3DataTableGUID.Namespace = "";
            // 
            // coldsStatusL3DataTableName
            // 
            this.coldsStatusL3DataTableName.Caption = "Name";
            this.coldsStatusL3DataTableName.ColumnName = "Name";
            this.coldsStatusL3DataTableName.Namespace = "";
            // 
            // bnStatus
            // 
            this.bnStatus.AddNewItem = null;
            this.bnStatus.BindingSource = this.bsStatus;
            this.bnStatus.CountItem = this.bindingNavigatorCountItem4;
            this.bnStatus.DeleteItem = null;
            this.bnStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.btnAddStatus,
            this.btnDelStatus,
            this.toolStripButton28});
            this.bnStatus.Location = new System.Drawing.Point(3, 3);
            this.bnStatus.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bnStatus.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bnStatus.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bnStatus.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bnStatus.Name = "bnStatus";
            this.bnStatus.PositionItem = this.bindingNavigatorPositionItem4;
            this.bnStatus.Size = new System.Drawing.Size(957, 25);
            this.bnStatus.TabIndex = 92;
            this.bnStatus.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem4.Text = "/ {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "位置";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStatus.Image")));
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.RightToLeftAutoMirrorImage = true;
            this.btnAddStatus.Size = new System.Drawing.Size(23, 22);
            this.btnAddStatus.Text = "新添";
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // btnDelStatus
            // 
            this.btnDelStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnDelStatus.Image")));
            this.btnDelStatus.Name = "btnDelStatus";
            this.btnDelStatus.RightToLeftAutoMirrorImage = true;
            this.btnDelStatus.Size = new System.Drawing.Size(23, 22);
            this.btnDelStatus.Text = "删除";
            this.btnDelStatus.Click += new System.EventHandler(this.btnDelStatus_Click);
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton28.Image")));
            this.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton28.Text = "toolStripButton25";
            this.toolStripButton28.ToolTipText = "刷新";
            this.toolStripButton28.Click += new System.EventHandler(this.btnStatusCancel_Click);
            // 
            // fLPStatus
            // 
            this.fLPStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPStatus.Controls.Add(this.btnStatusCancel);
            this.fLPStatus.Controls.Add(this.btnStatusConfirm);
            this.fLPStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPStatus.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPStatus.Location = new System.Drawing.Point(3, 674);
            this.fLPStatus.Name = "fLPStatus";
            this.fLPStatus.Size = new System.Drawing.Size(957, 33);
            this.fLPStatus.TabIndex = 91;
            // 
            // btnStatusCancel
            // 
            this.btnStatusCancel.Location = new System.Drawing.Point(875, 3);
            this.btnStatusCancel.Name = "btnStatusCancel";
            this.btnStatusCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStatusCancel.TabIndex = 87;
            this.btnStatusCancel.Text = "取消";
            this.btnStatusCancel.UseVisualStyleBackColor = true;
            this.btnStatusCancel.Click += new System.EventHandler(this.btnStatusCancel_Click);
            // 
            // btnStatusConfirm
            // 
            this.btnStatusConfirm.Location = new System.Drawing.Point(794, 3);
            this.btnStatusConfirm.Name = "btnStatusConfirm";
            this.btnStatusConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnStatusConfirm.TabIndex = 86;
            this.btnStatusConfirm.Text = "确认";
            this.btnStatusConfirm.UseVisualStyleBackColor = true;
            this.btnStatusConfirm.Visible = false;
            this.btnStatusConfirm.Click += new System.EventHandler(this.btnStatusConfirm_Click);
            // 
            // tabTemp
            // 
            this.tabTemp.Controls.Add(this.hmiRootPanel6);
            this.tabTemp.Location = new System.Drawing.Point(4, 21);
            this.tabTemp.Margin = new System.Windows.Forms.Padding(0);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Size = new System.Drawing.Size(965, 712);
            this.tabTemp.TabIndex = 9;
            this.tabTemp.Text = "测温/定氧";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel6
            // 
            this.hmiRootPanel6.Controls.Add(this.groupBox1);
            this.hmiRootPanel6.Controls.Add(this.fLPTemp);
            this.hmiRootPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel6.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel6.Name = "hmiRootPanel6";
            this.hmiRootPanel6.Size = new System.Drawing.Size(965, 712);
            this.hmiRootPanel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvTemp);
            this.groupBox1.Controls.Add(this.bnTemp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(965, 679);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // dvTemp
            // 
            this.dvTemp.AllowUserToAddRows = false;
            this.dvTemp.AllowUserToDeleteRows = false;
            this.dvTemp.AutoGenerateColumns = false;
            this.dvTemp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn5,
            this.tempDataGridViewTextBoxColumn,
            this.tempTimeDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.Name4});
            this.dvTemp.DataSource = this.bsTemp;
            this.dvTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTemp.Location = new System.Drawing.Point(0, 39);
            this.dvTemp.Name = "dvTemp";
            this.dvTemp.RowTemplate.Height = 23;
            this.dvTemp.Size = new System.Drawing.Size(965, 640);
            this.dvTemp.TabIndex = 94;
            this.dvTemp.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            this.dvTemp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvTemp_DataBindingComplete);
            // 
            // heatIDDataGridViewTextBoxColumn5
            // 
            this.heatIDDataGridViewTextBoxColumn5.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn5.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn5.Name = "heatIDDataGridViewTextBoxColumn5";
            this.heatIDDataGridViewTextBoxColumn5.Width = 80;
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "测温值[℃]";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            // 
            // tempTimeDataGridViewTextBoxColumn
            // 
            this.tempTimeDataGridViewTextBoxColumn.DataPropertyName = "Temp_Time";
            dataGridViewCellStyle20.Format = "G";
            this.tempTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.tempTimeDataGridViewTextBoxColumn.HeaderText = "测温时刻";
            this.tempTimeDataGridViewTextBoxColumn.Name = "tempTimeDataGridViewTextBoxColumn";
            this.tempTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tempTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.DataSource = this.bsBOFTempMode1;
            this.modeDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.modeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.modeDataGridViewTextBoxColumn.HeaderText = "测温模式";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modeDataGridViewTextBoxColumn.ValueMember = "Code_Val_Long";
            // 
            // bsBOFTempMode1
            // 
            this.bsBOFTempMode1.DataMember = "L3DataTable";
            this.bsBOFTempMode1.DataSource = this.dsBOFTempMode;
            // 
            // dsBOFTempMode
            // 
            this.dsBOFTempMode.AutoLoad = true;
            this.dsBOFTempMode.AutoSubscribe = false;
            this.dsBOFTempMode.DataSetName = "L3DataSet";
            this.dsBOFTempMode.DeleteMethod = null;
            this.dsBOFTempMode.InsertMethod = null;
            this.dsBOFTempMode.L3DataAdapter = this.Adapter;
            this.dsBOFTempMode.LoadEvent = "Click";
            this.dsBOFTempMode.LoadTrigger = null;
            this.dsBOFTempMode.RefreshValve = 1000;
            this.dsBOFTempMode.SourceCommand = null;
            this.dsBOFTempMode.SourceCondition = "CODE_GROUP = \'BOF_Temp_Mode\' and code is not null order by code";
            this.dsBOFTempMode.SourceMethod = "";
            this.dsBOFTempMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFTempMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFTempMode.SubscribeTarget = null;
            this.dsBOFTempMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFTempMode});
            this.dsBOFTempMode.UpdateEvent = "Click";
            this.dsBOFTempMode.UpdateMethod = null;
            this.dsBOFTempMode.UpdateTrigger = null;
            // 
            // schemadsBOFTempMode
            // 
            this.schemadsBOFTempMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFTempModeL3DataTableCode_Des,
            this.coldsBOFTempModeL3DataTableCode_Val_Long});
            this.schemadsBOFTempMode.TableName = "L3DataTable";
            // 
            // coldsBOFTempModeL3DataTableCode_Des
            // 
            this.coldsBOFTempModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFTempModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFTempModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBOFTempModeL3DataTableCode_Val_Long
            // 
            this.coldsBOFTempModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBOFTempModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBOFTempModeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsBOFTempModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // Name4
            // 
            this.Name4.DataPropertyName = "Name";
            this.Name4.HeaderText = "Name";
            this.Name4.Name = "Name4";
            this.Name4.Visible = false;
            // 
            // bsTemp
            // 
            this.bsTemp.DataMember = "L3DataTable";
            this.bsTemp.DataSource = this.dsTemp;
            // 
            // dsTemp
            // 
            this.dsTemp.AutoLoad = true;
            this.dsTemp.AutoSubscribe = false;
            this.dsTemp.DataSetName = "L3DataSet";
            this.dsTemp.DeleteMethod = null;
            this.dsTemp.InsertMethod = null;
            this.dsTemp.L3DataAdapter = null;
            this.dsTemp.LoadEvent = "Click";
            this.dsTemp.LoadTrigger = null;
            this.dsTemp.RefreshValve = 1000;
            this.dsTemp.SourceCommand = null;
            this.dsTemp.SourceCondition = "";
            this.dsTemp.SourceMethod = "";
            this.dsTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTemp.SourceURI = "XGMESLogic\\AODMag\\CAOD_Temp_Data";
            this.dsTemp.SubscribeTarget = null;
            this.dsTemp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTemp});
            this.dsTemp.UpdateEvent = "Click";
            this.dsTemp.UpdateMethod = null;
            this.dsTemp.UpdateTrigger = null;
            // 
            // schemadsTemp
            // 
            this.schemadsTemp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTempL3DataTableHeatID,
            this.coldsTempL3DataTableTemp,
            this.coldsTempL3DataTableTemp_Time,
            this.coldsTempL3DataTableMode,
            this.coldsTempL3DataTableGUID,
            this.coldsTempL3DataTableName});
            this.schemadsTemp.TableName = "L3DataTable";
            // 
            // coldsTempL3DataTableHeatID
            // 
            this.coldsTempL3DataTableHeatID.Caption = "HeatID";
            this.coldsTempL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTempL3DataTableHeatID.Namespace = "";
            // 
            // coldsTempL3DataTableTemp
            // 
            this.coldsTempL3DataTableTemp.Caption = "Temp";
            this.coldsTempL3DataTableTemp.ColumnName = "Temp";
            this.coldsTempL3DataTableTemp.DataType = typeof(int);
            this.coldsTempL3DataTableTemp.Namespace = "";
            // 
            // coldsTempL3DataTableTemp_Time
            // 
            this.coldsTempL3DataTableTemp_Time.Caption = "Temp_Time";
            this.coldsTempL3DataTableTemp_Time.ColumnName = "Temp_Time";
            this.coldsTempL3DataTableTemp_Time.DataType = typeof(System.DateTime);
            this.coldsTempL3DataTableTemp_Time.Namespace = "";
            // 
            // coldsTempL3DataTableMode
            // 
            this.coldsTempL3DataTableMode.Caption = "Mode";
            this.coldsTempL3DataTableMode.ColumnName = "Mode";
            this.coldsTempL3DataTableMode.DataType = typeof(short);
            this.coldsTempL3DataTableMode.Namespace = "";
            // 
            // coldsTempL3DataTableGUID
            // 
            this.coldsTempL3DataTableGUID.Caption = "GUID";
            this.coldsTempL3DataTableGUID.ColumnName = "GUID";
            this.coldsTempL3DataTableGUID.Namespace = "";
            // 
            // coldsTempL3DataTableName
            // 
            this.coldsTempL3DataTableName.Caption = "Name";
            this.coldsTempL3DataTableName.ColumnName = "Name";
            this.coldsTempL3DataTableName.Namespace = "";
            // 
            // bnTemp
            // 
            this.bnTemp.AddNewItem = null;
            this.bnTemp.BindingSource = this.bsTemp;
            this.bnTemp.CountItem = this.bindingNavigatorCountItem5;
            this.bnTemp.DeleteItem = null;
            this.bnTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.btnAddTemp,
            this.btnDelTemp});
            this.bnTemp.Location = new System.Drawing.Point(0, 14);
            this.bnTemp.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
            this.bnTemp.MoveLastItem = this.bindingNavigatorMoveLastItem5;
            this.bnTemp.MoveNextItem = this.bindingNavigatorMoveNextItem5;
            this.bnTemp.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
            this.bnTemp.Name = "bnTemp";
            this.bnTemp.PositionItem = this.bindingNavigatorPositionItem5;
            this.bnTemp.Size = new System.Drawing.Size(965, 25);
            this.bnTemp.TabIndex = 93;
            this.bnTemp.Text = "bindingNavigator1";
            this.bnTemp.RefreshItems += new System.EventHandler(this.bnTemp_RefreshItems);
            // 
            // bindingNavigatorCountItem5
            // 
            this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
            this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem5.Text = "/ {0}";
            this.bindingNavigatorCountItem5.ToolTipText = "总项数";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel4.Text = "测温数据";
            // 
            // bindingNavigatorMoveFirstItem5
            // 
            this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
            this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
            this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem5.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem5
            // 
            this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
            this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
            this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem5.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator15
            // 
            this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
            this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem5
            // 
            this.bindingNavigatorPositionItem5.AccessibleName = "位置";
            this.bindingNavigatorPositionItem5.AutoSize = false;
            this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
            this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem5.Text = "0";
            this.bindingNavigatorPositionItem5.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator16
            // 
            this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
            this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem5
            // 
            this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
            this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
            this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem5.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem5
            // 
            this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
            this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
            this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem5.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator17
            // 
            this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
            this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddTemp
            // 
            this.btnAddTemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTemp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTemp.Image")));
            this.btnAddTemp.Name = "btnAddTemp";
            this.btnAddTemp.RightToLeftAutoMirrorImage = true;
            this.btnAddTemp.Size = new System.Drawing.Size(23, 22);
            this.btnAddTemp.Text = "新添";
            this.btnAddTemp.Click += new System.EventHandler(this.btnAddTemp_Click);
            // 
            // btnDelTemp
            // 
            this.btnDelTemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelTemp.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTemp.Image")));
            this.btnDelTemp.Name = "btnDelTemp";
            this.btnDelTemp.RightToLeftAutoMirrorImage = true;
            this.btnDelTemp.Size = new System.Drawing.Size(23, 22);
            this.btnDelTemp.Text = "删除";
            this.btnDelTemp.Click += new System.EventHandler(this.btnDelTemp_Click);
            // 
            // fLPTemp
            // 
            this.fLPTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPTemp.Controls.Add(this.btnTempCancel);
            this.fLPTemp.Controls.Add(this.btnTempConfirm);
            this.fLPTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPTemp.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPTemp.Location = new System.Drawing.Point(0, 679);
            this.fLPTemp.Name = "fLPTemp";
            this.fLPTemp.Size = new System.Drawing.Size(965, 33);
            this.fLPTemp.TabIndex = 92;
            // 
            // btnTempCancel
            // 
            this.btnTempCancel.Location = new System.Drawing.Point(883, 3);
            this.btnTempCancel.Name = "btnTempCancel";
            this.btnTempCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTempCancel.TabIndex = 87;
            this.btnTempCancel.Text = "取消";
            this.btnTempCancel.UseVisualStyleBackColor = true;
            this.btnTempCancel.Click += new System.EventHandler(this.btnTempCancel_Click);
            // 
            // btnTempConfirm
            // 
            this.btnTempConfirm.Location = new System.Drawing.Point(802, 3);
            this.btnTempConfirm.Name = "btnTempConfirm";
            this.btnTempConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnTempConfirm.TabIndex = 86;
            this.btnTempConfirm.Text = "确认";
            this.btnTempConfirm.UseVisualStyleBackColor = true;
            this.btnTempConfirm.Visible = false;
            this.btnTempConfirm.Click += new System.EventHandler(this.btnTempConfirm_Click);
            // 
            // tabExcept
            // 
            this.tabExcept.Controls.Add(this.dvExcept);
            this.tabExcept.Controls.Add(this.fLPExcept);
            this.tabExcept.Controls.Add(this.bdExcept);
            this.tabExcept.Location = new System.Drawing.Point(4, 21);
            this.tabExcept.Margin = new System.Windows.Forms.Padding(0);
            this.tabExcept.Name = "tabExcept";
            this.tabExcept.Size = new System.Drawing.Size(965, 712);
            this.tabExcept.TabIndex = 15;
            this.tabExcept.Text = "工艺异常";
            this.tabExcept.UseVisualStyleBackColor = true;
            // 
            // dvExcept
            // 
            this.dvExcept.AllowUserToAddRows = false;
            this.dvExcept.AllowUserToDeleteRows = false;
            this.dvExcept.AutoGenerateColumns = false;
            this.dvExcept.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvExcept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvExcept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvExcept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDObjectDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn12,
            this.processCountDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn1,
            this.unitIDDataGridViewTextBoxColumn1,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.classifyDataGridViewTextBoxColumn,
            this.exceptionalTimeDataGridViewTextBoxColumn});
            this.dvExcept.DataSource = this.bsExcept;
            this.dvExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvExcept.Location = new System.Drawing.Point(0, 25);
            this.dvExcept.Name = "dvExcept";
            this.dvExcept.RowTemplate.Height = 23;
            this.dvExcept.Size = new System.Drawing.Size(965, 654);
            this.dvExcept.TabIndex = 91;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "身份标识";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            this.iDObjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDObjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // heatIDDataGridViewTextBoxColumn12
            // 
            this.heatIDDataGridViewTextBoxColumn12.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn12.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn12.Name = "heatIDDataGridViewTextBoxColumn12";
            this.heatIDDataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // processCountDataGridViewTextBoxColumn
            // 
            this.processCountDataGridViewTextBoxColumn.DataPropertyName = "Process_Count";
            this.processCountDataGridViewTextBoxColumn.HeaderText = "处理次数";
            this.processCountDataGridViewTextBoxColumn.Name = "processCountDataGridViewTextBoxColumn";
            this.processCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.processCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitTypeIDDataGridViewTextBoxColumn1
            // 
            this.unitTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn1.HeaderText = "工序";
            this.unitTypeIDDataGridViewTextBoxColumn1.Name = "unitTypeIDDataGridViewTextBoxColumn1";
            this.unitTypeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitTypeIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // unitIDDataGridViewTextBoxColumn1
            // 
            this.unitIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn1.Name = "unitIDDataGridViewTextBoxColumn1";
            this.unitIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.preHeatIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.DataSource = this.dsExceptCode;
            this.exceptionalCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Exceptional_Des";
            this.exceptionalCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.exceptionalCodeDataGridViewTextBoxColumn.DropDownWidth = 200;
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            this.exceptionalCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exceptionalCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exceptionalCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dsExceptCode
            // 
            this.dsExceptCode.AutoLoad = true;
            this.dsExceptCode.AutoSubscribe = false;
            this.dsExceptCode.DataSetName = "L3DataSet";
            this.dsExceptCode.DeleteMethod = "";
            this.dsExceptCode.InsertMethod = "";
            this.dsExceptCode.L3DataAdapter = this.Adapter;
            this.dsExceptCode.LoadEvent = "";
            this.dsExceptCode.LoadTrigger = null;
            this.dsExceptCode.RefreshValve = 1000;
            this.dsExceptCode.SourceCommand = null;
            this.dsExceptCode.SourceCondition = " unit=\'2\' order by EXCEPTIONAL_CODE desc ";
            this.dsExceptCode.SourceMethod = "";
            this.dsExceptCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsExceptCode.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
            this.dsExceptCode.SubscribeTarget = null;
            this.dsExceptCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExceptCode});
            this.dsExceptCode.UpdateEvent = "Click";
            this.dsExceptCode.UpdateMethod = "";
            this.dsExceptCode.UpdateTrigger = null;
            // 
            // schemadsExceptCode
            // 
            this.schemadsExceptCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptCodeL3DataTableExceptional_Code,
            this.coldsExceptCodeL3DataTableExceptional_Des,
            this.coldsExceptCodeL3DataTableUnit,
            this.coldsExceptCodeL3DataTableGUID,
            this.coldsExceptCodeL3DataTableName,
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag});
            this.schemadsExceptCode.TableName = "L3DataTable";
            // 
            // coldsExceptCodeL3DataTableExceptional_Code
            // 
            this.coldsExceptCodeL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsExceptCodeL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsExceptCodeL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableExceptional_Des
            // 
            this.coldsExceptCodeL3DataTableExceptional_Des.Caption = "Exceptional_Des";
            this.coldsExceptCodeL3DataTableExceptional_Des.ColumnName = "Exceptional_Des";
            this.coldsExceptCodeL3DataTableExceptional_Des.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableUnit
            // 
            this.coldsExceptCodeL3DataTableUnit.Caption = "Unit";
            this.coldsExceptCodeL3DataTableUnit.ColumnName = "Unit";
            this.coldsExceptCodeL3DataTableUnit.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableGUID
            // 
            this.coldsExceptCodeL3DataTableGUID.Caption = "GUID";
            this.coldsExceptCodeL3DataTableGUID.ColumnName = "GUID";
            this.coldsExceptCodeL3DataTableGUID.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableName
            // 
            this.coldsExceptCodeL3DataTableName.Caption = "Name";
            this.coldsExceptCodeL3DataTableName.ColumnName = "Name";
            this.coldsExceptCodeL3DataTableName.Namespace = "";
            // 
            // coldsExceptCodeL3DataTableAuto_Judge_Flag
            // 
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.Caption = "Auto_Judge_Flag";
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.ColumnName = "Auto_Judge_Flag";
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.DataType = typeof(int);
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.Namespace = "";
            // 
            // classifyDataGridViewTextBoxColumn
            // 
            this.classifyDataGridViewTextBoxColumn.DataPropertyName = "Classify";
            this.classifyDataGridViewTextBoxColumn.HeaderText = "优先级";
            this.classifyDataGridViewTextBoxColumn.Name = "classifyDataGridViewTextBoxColumn";
            this.classifyDataGridViewTextBoxColumn.ReadOnly = true;
            this.classifyDataGridViewTextBoxColumn.Visible = false;
            // 
            // exceptionalTimeDataGridViewTextBoxColumn
            // 
            this.exceptionalTimeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Time";
            dataGridViewCellStyle21.Format = "G";
            dataGridViewCellStyle21.NullValue = null;
            this.exceptionalTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.exceptionalTimeDataGridViewTextBoxColumn.HeaderText = "异常产生时间";
            this.exceptionalTimeDataGridViewTextBoxColumn.Name = "exceptionalTimeDataGridViewTextBoxColumn";
            this.exceptionalTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // bsExcept
            // 
            this.bsExcept.DataMember = "L3DataTable";
            this.bsExcept.DataSource = this.dsExcept;
            // 
            // dsExcept
            // 
            this.dsExcept.AutoLoad = true;
            this.dsExcept.AutoSubscribe = false;
            this.dsExcept.DataSetName = "L3DataSet";
            this.dsExcept.DeleteMethod = "";
            this.dsExcept.InsertMethod = "";
            this.dsExcept.L3DataAdapter = null;
            this.dsExcept.LoadEvent = "";
            this.dsExcept.LoadTrigger = null;
            this.dsExcept.RefreshValve = 1000;
            this.dsExcept.SourceCommand = null;
            this.dsExcept.SourceCondition = "1=2";
            this.dsExcept.SourceMethod = "";
            this.dsExcept.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsExcept.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Prod_Except";
            this.dsExcept.SubscribeTarget = null;
            this.dsExcept.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExcept});
            this.dsExcept.UpdateEvent = "";
            this.dsExcept.UpdateMethod = "";
            this.dsExcept.UpdateTrigger = null;
            // 
            // schemadsExcept
            // 
            this.schemadsExcept.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptL3DataTableID_Object,
            this.coldsExceptL3DataTableHeatID,
            this.coldsExceptL3DataTableProcess_Count,
            this.coldsExceptL3DataTableUnitTypeID,
            this.coldsExceptL3DataTableUnitID,
            this.coldsExceptL3DataTablePreHeatID,
            this.coldsExceptL3DataTablePre_SteelGradeIndex,
            this.coldsExceptL3DataTableSteelGradeIndex,
            this.coldsExceptL3DataTableExceptional_Code,
            this.coldsExceptL3DataTableClassify,
            this.coldsExceptL3DataTableExceptional_Time});
            this.schemadsExcept.TableName = "L3DataTable";
            // 
            // coldsExceptL3DataTableID_Object
            // 
            this.coldsExceptL3DataTableID_Object.Caption = "ID_Object";
            this.coldsExceptL3DataTableID_Object.ColumnName = "ID_Object";
            this.coldsExceptL3DataTableID_Object.Namespace = "";
            // 
            // coldsExceptL3DataTableHeatID
            // 
            this.coldsExceptL3DataTableHeatID.Caption = "HeatID";
            this.coldsExceptL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsExceptL3DataTableHeatID.Namespace = "";
            // 
            // coldsExceptL3DataTableProcess_Count
            // 
            this.coldsExceptL3DataTableProcess_Count.Caption = "Process_Count";
            this.coldsExceptL3DataTableProcess_Count.ColumnName = "Process_Count";
            this.coldsExceptL3DataTableProcess_Count.DataType = typeof(int);
            this.coldsExceptL3DataTableProcess_Count.Namespace = "";
            // 
            // coldsExceptL3DataTableUnitTypeID
            // 
            this.coldsExceptL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsExceptL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsExceptL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsExceptL3DataTableUnitID
            // 
            this.coldsExceptL3DataTableUnitID.Caption = "UnitID";
            this.coldsExceptL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsExceptL3DataTableUnitID.Namespace = "";
            // 
            // coldsExceptL3DataTablePreHeatID
            // 
            this.coldsExceptL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsExceptL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsExceptL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsExceptL3DataTablePre_SteelGradeIndex
            // 
            this.coldsExceptL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsExceptL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsExceptL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsExceptL3DataTableSteelGradeIndex
            // 
            this.coldsExceptL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsExceptL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsExceptL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsExceptL3DataTableExceptional_Code
            // 
            this.coldsExceptL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsExceptL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsExceptL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsExceptL3DataTableClassify
            // 
            this.coldsExceptL3DataTableClassify.Caption = "Classify";
            this.coldsExceptL3DataTableClassify.ColumnName = "Classify";
            this.coldsExceptL3DataTableClassify.DataType = typeof(int);
            this.coldsExceptL3DataTableClassify.Namespace = "";
            // 
            // coldsExceptL3DataTableExceptional_Time
            // 
            this.coldsExceptL3DataTableExceptional_Time.Caption = "Exceptional_Time";
            this.coldsExceptL3DataTableExceptional_Time.ColumnName = "Exceptional_Time";
            this.coldsExceptL3DataTableExceptional_Time.DataType = typeof(System.DateTime);
            this.coldsExceptL3DataTableExceptional_Time.Namespace = "";
            // 
            // fLPExcept
            // 
            this.fLPExcept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPExcept.Controls.Add(this.btnCancelExcept);
            this.fLPExcept.Controls.Add(this.btnConfirmExcept);
            this.fLPExcept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPExcept.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPExcept.Location = new System.Drawing.Point(0, 679);
            this.fLPExcept.Name = "fLPExcept";
            this.fLPExcept.Size = new System.Drawing.Size(965, 33);
            this.fLPExcept.TabIndex = 90;
            // 
            // btnCancelExcept
            // 
            this.btnCancelExcept.Location = new System.Drawing.Point(883, 3);
            this.btnCancelExcept.Name = "btnCancelExcept";
            this.btnCancelExcept.Size = new System.Drawing.Size(75, 23);
            this.btnCancelExcept.TabIndex = 87;
            this.btnCancelExcept.Text = "取消";
            this.btnCancelExcept.UseVisualStyleBackColor = true;
            this.btnCancelExcept.Click += new System.EventHandler(this.btnCancelExcept_Click);
            // 
            // bdExcept
            // 
            this.bdExcept.AddNewItem = null;
            this.bdExcept.BindingSource = this.bsExcept;
            this.bdExcept.CountItem = this.bindingNavigatorCountItem7;
            this.bdExcept.DeleteItem = null;
            this.bdExcept.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem7,
            this.bindingNavigatorMovePreviousItem7,
            this.bindingNavigatorSeparator21,
            this.bindingNavigatorPositionItem7,
            this.bindingNavigatorCountItem7,
            this.bindingNavigatorSeparator22,
            this.bindingNavigatorMoveNextItem7,
            this.bindingNavigatorMoveLastItem7,
            this.bindingNavigatorSeparator23,
            this.btnAddExcept,
            this.btnDelExcept,
            this.toolStripSeparator19,
            this.toolStripLabel11,
            this.txtExcept});
            this.bdExcept.Location = new System.Drawing.Point(0, 0);
            this.bdExcept.MoveFirstItem = this.bindingNavigatorMoveFirstItem7;
            this.bdExcept.MoveLastItem = this.bindingNavigatorMoveLastItem7;
            this.bdExcept.MoveNextItem = this.bindingNavigatorMoveNextItem7;
            this.bdExcept.MovePreviousItem = this.bindingNavigatorMovePreviousItem7;
            this.bdExcept.Name = "bdExcept";
            this.bdExcept.PositionItem = this.bindingNavigatorPositionItem7;
            this.bdExcept.Size = new System.Drawing.Size(965, 25);
            this.bdExcept.TabIndex = 0;
            this.bdExcept.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem7
            // 
            this.bindingNavigatorCountItem7.Name = "bindingNavigatorCountItem7";
            this.bindingNavigatorCountItem7.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem7.Text = "/ {0}";
            this.bindingNavigatorCountItem7.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem7
            // 
            this.bindingNavigatorMoveFirstItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem7.Image")));
            this.bindingNavigatorMoveFirstItem7.Name = "bindingNavigatorMoveFirstItem7";
            this.bindingNavigatorMoveFirstItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem7.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem7
            // 
            this.bindingNavigatorMovePreviousItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem7.Image")));
            this.bindingNavigatorMovePreviousItem7.Name = "bindingNavigatorMovePreviousItem7";
            this.bindingNavigatorMovePreviousItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem7.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator21
            // 
            this.bindingNavigatorSeparator21.Name = "bindingNavigatorSeparator21";
            this.bindingNavigatorSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem7
            // 
            this.bindingNavigatorPositionItem7.AccessibleName = "位置";
            this.bindingNavigatorPositionItem7.AutoSize = false;
            this.bindingNavigatorPositionItem7.Name = "bindingNavigatorPositionItem7";
            this.bindingNavigatorPositionItem7.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem7.Text = "0";
            this.bindingNavigatorPositionItem7.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator22
            // 
            this.bindingNavigatorSeparator22.Name = "bindingNavigatorSeparator22";
            this.bindingNavigatorSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem7
            // 
            this.bindingNavigatorMoveNextItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem7.Image")));
            this.bindingNavigatorMoveNextItem7.Name = "bindingNavigatorMoveNextItem7";
            this.bindingNavigatorMoveNextItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem7.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem7
            // 
            this.bindingNavigatorMoveLastItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem7.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem7.Image")));
            this.bindingNavigatorMoveLastItem7.Name = "bindingNavigatorMoveLastItem7";
            this.bindingNavigatorMoveLastItem7.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem7.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem7.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator23
            // 
            this.bindingNavigatorSeparator23.Name = "bindingNavigatorSeparator23";
            this.bindingNavigatorSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelExcept
            // 
            this.btnDelExcept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelExcept.Image = ((System.Drawing.Image)(resources.GetObject("btnDelExcept.Image")));
            this.btnDelExcept.Name = "btnDelExcept";
            this.btnDelExcept.RightToLeftAutoMirrorImage = true;
            this.btnDelExcept.Size = new System.Drawing.Size(23, 22);
            this.btnDelExcept.Text = "删除";
            this.btnDelExcept.Click += new System.EventHandler(this.btnDelExcept_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(95, 22);
            this.toolStripLabel11.Text = "  异常代码维护:";
            // 
            // txtExcept
            // 
            this.txtExcept.Name = "txtExcept";
            this.txtExcept.Size = new System.Drawing.Size(160, 25);
            this.txtExcept.Leave += new System.EventHandler(this.txtExcept_Leave);
            // 
            // tabRemark
            // 
            this.tabRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRemark.Controls.Add(this.hmiRootPanel3);
            this.tabRemark.Location = new System.Drawing.Point(4, 21);
            this.tabRemark.Name = "tabRemark";
            this.tabRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemark.Size = new System.Drawing.Size(965, 712);
            this.tabRemark.TabIndex = 11;
            this.tabRemark.Text = "炉次记事";
            this.tabRemark.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel3
            // 
            this.hmiRootPanel3.Controls.Add(this.dvRemark);
            this.hmiRootPanel3.Controls.Add(this.bnRemark);
            this.hmiRootPanel3.Controls.Add(this.fLPRemark);
            this.hmiRootPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel3.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel3.Name = "hmiRootPanel3";
            this.hmiRootPanel3.Size = new System.Drawing.Size(957, 704);
            this.hmiRootPanel3.TabIndex = 91;
            // 
            // dvRemark
            // 
            this.dvRemark.AllowUserToAddRows = false;
            this.dvRemark.AllowUserToDeleteRows = false;
            this.dvRemark.AutoGenerateColumns = false;
            this.dvRemark.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvRemark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRemark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn7,
            this.typeIDDataGridViewCheckBoxColumn,
            this.logTimeDataGridViewTextBoxColumn1,
            this.remarkDataGridViewTextBoxColumn});
            this.dvRemark.DataSource = this.bsRemark;
            this.dvRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRemark.Location = new System.Drawing.Point(0, 25);
            this.dvRemark.Name = "dvRemark";
            this.dvRemark.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvRemark.RowTemplate.Height = 23;
            this.dvRemark.Size = new System.Drawing.Size(957, 646);
            this.dvRemark.TabIndex = 94;
            this.dvRemark.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dv_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn7
            // 
            this.heatIDDataGridViewTextBoxColumn7.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn7.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn7.Name = "heatIDDataGridViewTextBoxColumn7";
            this.heatIDDataGridViewTextBoxColumn7.Width = 54;
            // 
            // typeIDDataGridViewCheckBoxColumn
            // 
            this.typeIDDataGridViewCheckBoxColumn.DataPropertyName = "TypeID";
            this.typeIDDataGridViewCheckBoxColumn.DataSource = this.dsRemarkType;
            this.typeIDDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.typeIDDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeIDDataGridViewCheckBoxColumn.HeaderText = "分类";
            this.typeIDDataGridViewCheckBoxColumn.Name = "typeIDDataGridViewCheckBoxColumn";
            this.typeIDDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeIDDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeIDDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.typeIDDataGridViewCheckBoxColumn.Width = 54;
            // 
            // dsRemarkType
            // 
            this.dsRemarkType.AutoLoad = true;
            this.dsRemarkType.AutoSubscribe = false;
            this.dsRemarkType.DataSetName = "L3DataSet";
            this.dsRemarkType.DeleteMethod = null;
            this.dsRemarkType.InsertMethod = null;
            this.dsRemarkType.L3DataAdapter = this.Adapter;
            this.dsRemarkType.LoadEvent = "Click";
            this.dsRemarkType.LoadTrigger = null;
            this.dsRemarkType.RefreshValve = 1000;
            this.dsRemarkType.SourceCommand = null;
            this.dsRemarkType.SourceCondition = "CODE_GROUP = \'REMARK_TYPE\' and code is not null order by code";
            this.dsRemarkType.SourceMethod = "";
            this.dsRemarkType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRemarkType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRemarkType.SubscribeTarget = null;
            this.dsRemarkType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRemarkType});
            this.dsRemarkType.UpdateEvent = "Click";
            this.dsRemarkType.UpdateMethod = null;
            this.dsRemarkType.UpdateTrigger = null;
            // 
            // schemadsRemarkType
            // 
            this.schemadsRemarkType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRemarkTypeL3DataTableCode_Des,
            this.coldsRemarkTypeL3DataTableCode_Val_Long});
            this.schemadsRemarkType.TableName = "L3DataTable";
            // 
            // coldsRemarkTypeL3DataTableCode_Des
            // 
            this.coldsRemarkTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRemarkTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRemarkTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsRemarkTypeL3DataTableCode_Val_Long
            // 
            this.coldsRemarkTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsRemarkTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsRemarkTypeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsRemarkTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // logTimeDataGridViewTextBoxColumn1
            // 
            this.logTimeDataGridViewTextBoxColumn1.DataPropertyName = "Log_Time";
            dataGridViewCellStyle22.Format = "G";
            this.logTimeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle22;
            this.logTimeDataGridViewTextBoxColumn1.HeaderText = "记录时刻";
            this.logTimeDataGridViewTextBoxColumn1.Name = "logTimeDataGridViewTextBoxColumn1";
            this.logTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // bsRemark
            // 
            this.bsRemark.DataMember = "L3DataTable";
            this.bsRemark.DataSource = this.dsRemark;
            // 
            // dsRemark
            // 
            this.dsRemark.AutoLoad = true;
            this.dsRemark.AutoSubscribe = false;
            this.dsRemark.DataSetName = "L3DataSet";
            this.dsRemark.DeleteMethod = null;
            this.dsRemark.InsertMethod = null;
            this.dsRemark.L3DataAdapter = null;
            this.dsRemark.LoadEvent = "Click";
            this.dsRemark.LoadTrigger = null;
            this.dsRemark.RefreshValve = 1000;
            this.dsRemark.SourceCommand = null;
            this.dsRemark.SourceCondition = "1=2";
            this.dsRemark.SourceMethod = "";
            this.dsRemark.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRemark.SourceURI = "XGMESLogic\\AODMag\\CAOD_HeatRemark";
            this.dsRemark.SubscribeTarget = null;
            this.dsRemark.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRemark});
            this.dsRemark.UpdateEvent = "Click";
            this.dsRemark.UpdateMethod = null;
            this.dsRemark.UpdateTrigger = null;
            // 
            // schemadsRemark
            // 
            this.schemadsRemark.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRemarkL3DataTableGUID,
            this.coldsRemarkL3DataTableName,
            this.coldsRemarkL3DataTableHeatID,
            this.coldsRemarkL3DataTableTypeID,
            this.coldsRemarkL3DataTableRemark,
            this.coldsRemarkL3DataTableLog_Time});
            this.schemadsRemark.TableName = "L3DataTable";
            // 
            // coldsRemarkL3DataTableGUID
            // 
            this.coldsRemarkL3DataTableGUID.Caption = "GUID";
            this.coldsRemarkL3DataTableGUID.ColumnName = "GUID";
            this.coldsRemarkL3DataTableGUID.Namespace = "";
            // 
            // coldsRemarkL3DataTableName
            // 
            this.coldsRemarkL3DataTableName.Caption = "Name";
            this.coldsRemarkL3DataTableName.ColumnName = "Name";
            this.coldsRemarkL3DataTableName.Namespace = "";
            // 
            // coldsRemarkL3DataTableHeatID
            // 
            this.coldsRemarkL3DataTableHeatID.Caption = "HeatID";
            this.coldsRemarkL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsRemarkL3DataTableHeatID.Namespace = "";
            // 
            // coldsRemarkL3DataTableTypeID
            // 
            this.coldsRemarkL3DataTableTypeID.Caption = "TypeID";
            this.coldsRemarkL3DataTableTypeID.ColumnName = "TypeID";
            this.coldsRemarkL3DataTableTypeID.DataType = typeof(short);
            this.coldsRemarkL3DataTableTypeID.Namespace = "";
            // 
            // coldsRemarkL3DataTableRemark
            // 
            this.coldsRemarkL3DataTableRemark.Caption = "Remark";
            this.coldsRemarkL3DataTableRemark.ColumnName = "Remark";
            this.coldsRemarkL3DataTableRemark.Namespace = "";
            // 
            // coldsRemarkL3DataTableLog_Time
            // 
            this.coldsRemarkL3DataTableLog_Time.Caption = "Log_Time";
            this.coldsRemarkL3DataTableLog_Time.ColumnName = "Log_Time";
            this.coldsRemarkL3DataTableLog_Time.DataType = typeof(System.DateTime);
            this.coldsRemarkL3DataTableLog_Time.Namespace = "";
            // 
            // bnRemark
            // 
            this.bnRemark.AddNewItem = null;
            this.bnRemark.BindingSource = this.bsRemark;
            this.bnRemark.CountItem = this.toolStripLabel1;
            this.bnRemark.DeleteItem = null;
            this.bnRemark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.btnRemarkAdd,
            this.btnRemarkDel});
            this.bnRemark.Location = new System.Drawing.Point(0, 0);
            this.bnRemark.MoveFirstItem = this.toolStripButton1;
            this.bnRemark.MoveLastItem = this.toolStripButton4;
            this.bnRemark.MoveNextItem = this.toolStripButton3;
            this.bnRemark.MovePreviousItem = this.toolStripButton2;
            this.bnRemark.Name = "bnRemark";
            this.bnRemark.PositionItem = this.toolStripTextBox1;
            this.bnRemark.Size = new System.Drawing.Size(957, 25);
            this.bnRemark.TabIndex = 93;
            this.bnRemark.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRemarkDel
            // 
            this.btnRemarkDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemarkDel.Image = ((System.Drawing.Image)(resources.GetObject("btnRemarkDel.Image")));
            this.btnRemarkDel.Name = "btnRemarkDel";
            this.btnRemarkDel.RightToLeftAutoMirrorImage = true;
            this.btnRemarkDel.Size = new System.Drawing.Size(23, 22);
            this.btnRemarkDel.Text = "删除";
            this.btnRemarkDel.Click += new System.EventHandler(this.btnRemarkDel_Click);
            // 
            // fLPRemark
            // 
            this.fLPRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPRemark.Controls.Add(this.btnRemarkCancel);
            this.fLPRemark.Controls.Add(this.btnRemarkConfirm);
            this.fLPRemark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPRemark.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPRemark.Location = new System.Drawing.Point(0, 671);
            this.fLPRemark.Name = "fLPRemark";
            this.fLPRemark.Size = new System.Drawing.Size(957, 33);
            this.fLPRemark.TabIndex = 92;
            // 
            // btnRemarkCancel
            // 
            this.btnRemarkCancel.Location = new System.Drawing.Point(875, 3);
            this.btnRemarkCancel.Name = "btnRemarkCancel";
            this.btnRemarkCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRemarkCancel.TabIndex = 87;
            this.btnRemarkCancel.Text = "取消";
            this.btnRemarkCancel.UseVisualStyleBackColor = true;
            this.btnRemarkCancel.Click += new System.EventHandler(this.btnRemarkCancel_Click);
            // 
            // dsBulk_Add_Man
            // 
            this.dsBulk_Add_Man.AutoLoad = true;
            this.dsBulk_Add_Man.AutoSubscribe = false;
            this.dsBulk_Add_Man.DataSetName = "L3DataSet";
            this.dsBulk_Add_Man.DeleteMethod = "";
            this.dsBulk_Add_Man.InsertMethod = "";
            this.dsBulk_Add_Man.L3DataAdapter = this.Adapter;
            this.dsBulk_Add_Man.LoadEvent = "";
            this.dsBulk_Add_Man.LoadTrigger = null;
            this.dsBulk_Add_Man.RefreshValve = 1000;
            this.dsBulk_Add_Man.SourceCommand = null;
            this.dsBulk_Add_Man.SourceCondition = "";
            this.dsBulk_Add_Man.SourceMethod = "";
            this.dsBulk_Add_Man.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsBulk_Add_Man.SourceURI = "";
            this.dsBulk_Add_Man.SubscribeTarget = "";
            this.dsBulk_Add_Man.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulk_Add_Man});
            this.dsBulk_Add_Man.UpdateEvent = "";
            this.dsBulk_Add_Man.UpdateMethod = "";
            this.dsBulk_Add_Man.UpdateTrigger = null;
            // 
            // schemadsBulk_Add_Man
            // 
            this.schemadsBulk_Add_Man.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulk_Add_ManL3DataTableBulk_Code,
            this.coldsBulk_Add_ManL3DataTableBatch_ID,
            this.coldsBulk_Add_ManL3DataTableCode,
            this.coldsBulk_Add_ManL3DataTableCode_Des});
            this.schemadsBulk_Add_Man.TableName = "L3DataTable";
            // 
            // coldsBulk_Add_ManL3DataTableBulk_Code
            // 
            this.coldsBulk_Add_ManL3DataTableBulk_Code.Caption = "Bulk_Code";
            this.coldsBulk_Add_ManL3DataTableBulk_Code.ColumnName = "Bulk_Code";
            this.coldsBulk_Add_ManL3DataTableBulk_Code.Namespace = "";
            // 
            // coldsBulk_Add_ManL3DataTableBatch_ID
            // 
            this.coldsBulk_Add_ManL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsBulk_Add_ManL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsBulk_Add_ManL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsBulk_Add_ManL3DataTableCode
            // 
            this.coldsBulk_Add_ManL3DataTableCode.Caption = "Code";
            this.coldsBulk_Add_ManL3DataTableCode.ColumnName = "Code";
            this.coldsBulk_Add_ManL3DataTableCode.Namespace = "";
            // 
            // coldsBulk_Add_ManL3DataTableCode_Des
            // 
            this.coldsBulk_Add_ManL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulk_Add_ManL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulk_Add_ManL3DataTableCode_Des.Namespace = "";
            // 
            // bsBulkCode
            // 
            this.bsBulkCode.DataMember = "L3DataTable";
            this.bsBulkCode.DataSource = this.dsCode;
            this.bsBulkCode.Filter = "CODE_GROUP = \'BULK_CODE\' or CODE_GROUP = \'ALLOY_CODE\'";
            // 
            // dsBOFUnitStatus
            // 
            this.dsBOFUnitStatus.AutoLoad = true;
            this.dsBOFUnitStatus.AutoSubscribe = false;
            this.dsBOFUnitStatus.DataSetName = "L3DataSet";
            this.dsBOFUnitStatus.DeleteMethod = null;
            this.dsBOFUnitStatus.InsertMethod = null;
            this.dsBOFUnitStatus.L3DataAdapter = this.Adapter;
            this.dsBOFUnitStatus.LoadEvent = "Click";
            this.dsBOFUnitStatus.LoadTrigger = null;
            this.dsBOFUnitStatus.RefreshValve = 1000;
            this.dsBOFUnitStatus.SourceCommand = null;
            this.dsBOFUnitStatus.SourceCondition = "CODE_GROUP = \'BOFUnitStatus\' and code is not null order by code";
            this.dsBOFUnitStatus.SourceMethod = "";
            this.dsBOFUnitStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFUnitStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFUnitStatus.SubscribeTarget = null;
            this.dsBOFUnitStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFUnitStatus});
            this.dsBOFUnitStatus.UpdateEvent = "Click";
            this.dsBOFUnitStatus.UpdateMethod = null;
            this.dsBOFUnitStatus.UpdateTrigger = null;
            // 
            // schemadsBOFUnitStatus
            // 
            this.schemadsBOFUnitStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFUnitStatusL3DataTableCode_Des,
            this.coldsBOFUnitStatusL3DataTableCode_Val_Long});
            this.schemadsBOFUnitStatus.TableName = "L3DataTable";
            // 
            // coldsBOFUnitStatusL3DataTableCode_Des
            // 
            this.coldsBOFUnitStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFUnitStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFUnitStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBOFUnitStatusL3DataTableCode_Val_Long
            // 
            this.coldsBOFUnitStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBOFUnitStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBOFUnitStatusL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsBOFUnitStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsTuneFlag
            // 
            this.dsTuneFlag.AutoLoad = true;
            this.dsTuneFlag.AutoSubscribe = false;
            this.dsTuneFlag.DataSetName = "L3DataSet";
            this.dsTuneFlag.DeleteMethod = null;
            this.dsTuneFlag.InsertMethod = null;
            this.dsTuneFlag.L3DataAdapter = this.Adapter;
            this.dsTuneFlag.LoadEvent = "Click";
            this.dsTuneFlag.LoadTrigger = null;
            this.dsTuneFlag.RefreshValve = 1000;
            this.dsTuneFlag.SourceCommand = null;
            this.dsTuneFlag.SourceCondition = "CODE_GROUP = \'Tune_Flag\' and code is not null";
            this.dsTuneFlag.SourceMethod = "";
            this.dsTuneFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTuneFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTuneFlag.SubscribeTarget = null;
            this.dsTuneFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTuneFlag});
            this.dsTuneFlag.UpdateEvent = "Click";
            this.dsTuneFlag.UpdateMethod = null;
            this.dsTuneFlag.UpdateTrigger = null;
            // 
            // schemadsTuneFlag
            // 
            this.schemadsTuneFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTuneFlagL3DataTableCode_Des,
            this.coldsTuneFlagL3DataTableCode_Val_Long});
            this.schemadsTuneFlag.TableName = "L3DataTable";
            // 
            // coldsTuneFlagL3DataTableCode_Des
            // 
            this.coldsTuneFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTuneFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTuneFlagL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTuneFlagL3DataTableCode_Val_Long
            // 
            this.coldsTuneFlagL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTuneFlagL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTuneFlagL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsTuneFlagL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsFurnaceLineStatus
            // 
            this.dsFurnaceLineStatus.AutoLoad = true;
            this.dsFurnaceLineStatus.AutoSubscribe = false;
            this.dsFurnaceLineStatus.DataSetName = "L3DataSet";
            this.dsFurnaceLineStatus.DeleteMethod = null;
            this.dsFurnaceLineStatus.InsertMethod = null;
            this.dsFurnaceLineStatus.L3DataAdapter = this.Adapter;
            this.dsFurnaceLineStatus.LoadEvent = "Click";
            this.dsFurnaceLineStatus.LoadTrigger = null;
            this.dsFurnaceLineStatus.RefreshValve = 1000;
            this.dsFurnaceLineStatus.SourceCommand = null;
            this.dsFurnaceLineStatus.SourceCondition = "Code_Group = \'Furnace_Line_Status\' order by Code";
            this.dsFurnaceLineStatus.SourceMethod = "";
            this.dsFurnaceLineStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFurnaceLineStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsFurnaceLineStatus.SubscribeTarget = null;
            this.dsFurnaceLineStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFurnaceLineStatus});
            this.dsFurnaceLineStatus.UpdateEvent = "Click";
            this.dsFurnaceLineStatus.UpdateMethod = null;
            this.dsFurnaceLineStatus.UpdateTrigger = null;
            // 
            // schemadsFurnaceLineStatus
            // 
            this.schemadsFurnaceLineStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFurnaceLineStatusL3DataTableCode,
            this.coldsFurnaceLineStatusL3DataTableCode_Des});
            this.schemadsFurnaceLineStatus.TableName = "L3DataTable";
            // 
            // coldsFurnaceLineStatusL3DataTableCode
            // 
            this.coldsFurnaceLineStatusL3DataTableCode.Caption = "Code";
            this.coldsFurnaceLineStatusL3DataTableCode.ColumnName = "Code";
            this.coldsFurnaceLineStatusL3DataTableCode.Namespace = "";
            // 
            // coldsFurnaceLineStatusL3DataTableCode_Des
            // 
            this.coldsFurnaceLineStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFurnaceLineStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFurnaceLineStatusL3DataTableCode_Des.Namespace = "";
            // 
            // dsBlowMode
            // 
            this.dsBlowMode.AutoLoad = true;
            this.dsBlowMode.AutoSubscribe = false;
            this.dsBlowMode.DataSetName = "L3DataSet";
            this.dsBlowMode.DeleteMethod = null;
            this.dsBlowMode.InsertMethod = null;
            this.dsBlowMode.L3DataAdapter = this.Adapter;
            this.dsBlowMode.LoadEvent = "Click";
            this.dsBlowMode.LoadTrigger = null;
            this.dsBlowMode.RefreshValve = 1000;
            this.dsBlowMode.SourceCommand = null;
            this.dsBlowMode.SourceCondition = "CODE_GROUP = \'Blow_Mode\' and code is not null order by code ";
            this.dsBlowMode.SourceMethod = "";
            this.dsBlowMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBlowMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBlowMode.SubscribeTarget = null;
            this.dsBlowMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBlowMode});
            this.dsBlowMode.UpdateEvent = "Click";
            this.dsBlowMode.UpdateMethod = null;
            this.dsBlowMode.UpdateTrigger = null;
            // 
            // schemadsBlowMode
            // 
            this.schemadsBlowMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBlowModeL3DataTableCode_des,
            this.coldsBlowModeL3DataTableCode_Val_Long});
            this.schemadsBlowMode.TableName = "L3DataTable";
            // 
            // coldsBlowModeL3DataTableCode_des
            // 
            this.coldsBlowModeL3DataTableCode_des.Caption = "Code_des";
            this.coldsBlowModeL3DataTableCode_des.ColumnName = "Code_des";
            this.coldsBlowModeL3DataTableCode_des.Namespace = "";
            // 
            // coldsBlowModeL3DataTableCode_Val_Long
            // 
            this.coldsBlowModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBlowModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBlowModeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsBlowModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsWire_Add_man
            // 
            this.dsWire_Add_man.AutoLoad = true;
            this.dsWire_Add_man.AutoSubscribe = false;
            this.dsWire_Add_man.DataSetName = "L3DataSet";
            this.dsWire_Add_man.DeleteMethod = "";
            this.dsWire_Add_man.InsertMethod = "";
            this.dsWire_Add_man.L3DataAdapter = this.Adapter;
            this.dsWire_Add_man.LoadEvent = "";
            this.dsWire_Add_man.LoadTrigger = null;
            this.dsWire_Add_man.RefreshValve = 1000;
            this.dsWire_Add_man.SourceCommand = null;
            this.dsWire_Add_man.SourceCondition = "";
            this.dsWire_Add_man.SourceMethod = "";
            this.dsWire_Add_man.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsWire_Add_man.SourceURI = "";
            this.dsWire_Add_man.SubscribeTarget = "";
            this.dsWire_Add_man.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWire_Add_man});
            this.dsWire_Add_man.UpdateEvent = "";
            this.dsWire_Add_man.UpdateMethod = "";
            this.dsWire_Add_man.UpdateTrigger = null;
            // 
            // schemadsWire_Add_man
            // 
            this.schemadsWire_Add_man.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWire_Add_manL3DataTableAlloy_Code,
            this.coldsWire_Add_manL3DataTableBatch_ID,
            this.coldsWire_Add_manL3DataTableCode,
            this.coldsWire_Add_manL3DataTableCode_Des,
            this.coldsWire_Add_manL3DataTablecode_function_group});
            this.schemadsWire_Add_man.TableName = "L3DataTable";
            // 
            // coldsWire_Add_manL3DataTableAlloy_Code
            // 
            this.coldsWire_Add_manL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsWire_Add_manL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsWire_Add_manL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTableBatch_ID
            // 
            this.coldsWire_Add_manL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsWire_Add_manL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsWire_Add_manL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTableCode
            // 
            this.coldsWire_Add_manL3DataTableCode.Caption = "Code";
            this.coldsWire_Add_manL3DataTableCode.ColumnName = "Code";
            this.coldsWire_Add_manL3DataTableCode.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTableCode_Des
            // 
            this.coldsWire_Add_manL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWire_Add_manL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWire_Add_manL3DataTableCode_Des.Namespace = "";
            // 
            // coldsWire_Add_manL3DataTablecode_function_group
            // 
            this.coldsWire_Add_manL3DataTablecode_function_group.Caption = "code_function_group";
            this.coldsWire_Add_manL3DataTablecode_function_group.ColumnName = "code_function_group";
            this.coldsWire_Add_manL3DataTablecode_function_group.Namespace = "";
            // 
            // bsBOFTempMode2
            // 
            this.bsBOFTempMode2.DataMember = "L3DataTable";
            this.bsBOFTempMode2.DataSource = this.dsBOFTempMode;
            // 
            // coldsChemicalL3DataTableCrNi
            // 
            this.coldsChemicalL3DataTableCrNi.Caption = "CrNi";
            this.coldsChemicalL3DataTableCrNi.ColumnName = "CrNi";
            this.coldsChemicalL3DataTableCrNi.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrCu
            // 
            this.coldsChemicalL3DataTableCrCu.Caption = "CrCu";
            this.coldsChemicalL3DataTableCrCu.ColumnName = "CrCu";
            this.coldsChemicalL3DataTableCrCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableCrNiCu
            // 
            this.coldsChemicalL3DataTableCrNiCu.Caption = "CrNiCu";
            this.coldsChemicalL3DataTableCrNiCu.ColumnName = "CrNiCu";
            this.coldsChemicalL3DataTableCrNiCu.Namespace = "";
            // 
            // coldsChemicalL3DataTableOther3
            // 
            this.coldsChemicalL3DataTableOther3.Caption = "Other3";
            this.coldsChemicalL3DataTableOther3.ColumnName = "Other3";
            this.coldsChemicalL3DataTableOther3.Namespace = "";
            // 
            // dsDuty
            // 
            this.dsDuty.AutoLoad = true;
            this.dsDuty.AutoSubscribe = false;
            this.dsDuty.DataSetName = "L3DataSet";
            this.dsDuty.DeleteMethod = null;
            this.dsDuty.InsertMethod = null;
            this.dsDuty.L3DataAdapter = this.Adapter;
            this.dsDuty.LoadEvent = "Click";
            this.dsDuty.LoadTrigger = null;
            this.dsDuty.RefreshValve = 1000;
            this.dsDuty.SourceCommand = null;
            this.dsDuty.SourceCondition = "1=2";
            this.dsDuty.SourceMethod = "";
            this.dsDuty.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDuty.SourceURI = "XGMESLogic\\BOFMag\\CDuty_Definition";
            this.dsDuty.SubscribeTarget = null;
            this.dsDuty.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDuty});
            this.dsDuty.UpdateEvent = "Click";
            this.dsDuty.UpdateMethod = null;
            this.dsDuty.UpdateTrigger = null;
            // 
            // schemadsDuty
            // 
            this.schemadsDuty.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDutyL3DataTableGUID,
            this.coldsDutyL3DataTableName,
            this.coldsDutyL3DataTableObjectID,
            this.coldsDutyL3DataTableUnitID,
            this.coldsDutyL3DataTableTeam,
            this.coldsDutyL3DataTableHeadFurnace,
            this.coldsDutyL3DataTableAssistant,
            this.coldsDutyL3DataTableSecondHand});
            this.schemadsDuty.TableName = "L3DataTable";
            // 
            // coldsDutyL3DataTableGUID
            // 
            this.coldsDutyL3DataTableGUID.Caption = "GUID";
            this.coldsDutyL3DataTableGUID.ColumnName = "GUID";
            this.coldsDutyL3DataTableGUID.Namespace = "";
            // 
            // coldsDutyL3DataTableName
            // 
            this.coldsDutyL3DataTableName.Caption = "Name";
            this.coldsDutyL3DataTableName.ColumnName = "Name";
            this.coldsDutyL3DataTableName.Namespace = "";
            // 
            // coldsDutyL3DataTableObjectID
            // 
            this.coldsDutyL3DataTableObjectID.Caption = "ObjectID";
            this.coldsDutyL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsDutyL3DataTableObjectID.Namespace = "";
            // 
            // coldsDutyL3DataTableUnitID
            // 
            this.coldsDutyL3DataTableUnitID.Caption = "UnitID";
            this.coldsDutyL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsDutyL3DataTableUnitID.Namespace = "";
            // 
            // coldsDutyL3DataTableTeam
            // 
            this.coldsDutyL3DataTableTeam.Caption = "Team";
            this.coldsDutyL3DataTableTeam.ColumnName = "Team";
            this.coldsDutyL3DataTableTeam.Namespace = "";
            // 
            // coldsDutyL3DataTableHeadFurnace
            // 
            this.coldsDutyL3DataTableHeadFurnace.Caption = "HeadFurnace";
            this.coldsDutyL3DataTableHeadFurnace.ColumnName = "HeadFurnace";
            this.coldsDutyL3DataTableHeadFurnace.Namespace = "";
            // 
            // coldsDutyL3DataTableAssistant
            // 
            this.coldsDutyL3DataTableAssistant.Caption = "Assistant";
            this.coldsDutyL3DataTableAssistant.ColumnName = "Assistant";
            this.coldsDutyL3DataTableAssistant.Namespace = "";
            // 
            // coldsDutyL3DataTableSecondHand
            // 
            this.coldsDutyL3DataTableSecondHand.Caption = "SecondHand";
            this.coldsDutyL3DataTableSecondHand.ColumnName = "SecondHand";
            this.coldsDutyL3DataTableSecondHand.Namespace = "";
            // 
            // cmdHeatExcept
            // 
            this.cmdHeatExcept.Adapter = this.Adapter;
            this.cmdHeatExcept.MergeReturnTarget = false;
            this.cmdHeatExcept.Method = "NewHeatExceptionData";
            this.cmdHeatExcept.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdHeatExcept.Parameters.Add(this.l3cmdpHeatID);
            this.cmdHeatExcept.Parameters.Add(this.l3cmdpUnitType);
            this.cmdHeatExcept.Parameters.Add(this.l3cmdpUnitID);
            this.cmdHeatExcept.Parameters.Add(this.l3cmdprsData);
            this.cmdHeatExcept.ReturnTarget = null;
            this.cmdHeatExcept.ReturnTargetProperty = null;
            this.cmdHeatExcept.Trigger = null;
            this.cmdHeatExcept.TriggerEvent = "Click";
            // 
            // l3cmdpHeatID
            // 
            this.l3cmdpHeatID.AcceptAfterExecuted = false;
            this.l3cmdpHeatID.ConstantValue = null;
            this.l3cmdpHeatID.MergeTarget = false;
            this.l3cmdpHeatID.SourceFilter = null;
            this.l3cmdpHeatID.SourceObject = null;
            this.l3cmdpHeatID.SourceProperty = null;
            this.l3cmdpHeatID.TargetObject = null;
            this.l3cmdpHeatID.TargetProperty = null;
            // 
            // l3cmdpUnitType
            // 
            this.l3cmdpUnitType.AcceptAfterExecuted = false;
            this.l3cmdpUnitType.ConstantValue = null;
            this.l3cmdpUnitType.MergeTarget = false;
            this.l3cmdpUnitType.SourceFilter = null;
            this.l3cmdpUnitType.SourceObject = null;
            this.l3cmdpUnitType.SourceProperty = null;
            this.l3cmdpUnitType.TargetObject = null;
            this.l3cmdpUnitType.TargetProperty = null;
            // 
            // l3cmdpUnitID
            // 
            this.l3cmdpUnitID.AcceptAfterExecuted = false;
            this.l3cmdpUnitID.ConstantValue = null;
            this.l3cmdpUnitID.MergeTarget = false;
            this.l3cmdpUnitID.SourceFilter = null;
            this.l3cmdpUnitID.SourceObject = null;
            this.l3cmdpUnitID.SourceProperty = null;
            this.l3cmdpUnitID.TargetObject = null;
            this.l3cmdpUnitID.TargetProperty = null;
            // 
            // l3cmdprsData
            // 
            this.l3cmdprsData.AcceptAfterExecuted = false;
            this.l3cmdprsData.ConstantValue = null;
            this.l3cmdprsData.MergeTarget = false;
            this.l3cmdprsData.SourceFilter = null;
            this.l3cmdprsData.SourceObject = null;
            this.l3cmdprsData.SourceProperty = null;
            this.l3cmdprsData.TargetObject = null;
            this.l3cmdprsData.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = false;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'UnitMag\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // AcoldsMatL3DataTableBatch_ID
            // 
            this.AcoldsMatL3DataTableBatch_ID.Caption = "Batch_ID";
            this.AcoldsMatL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.AcoldsMatL3DataTableBatch_ID.Namespace = "";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // coldsSCRAP_SLOT_IDL3DataTableGUID
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableGUID.Caption = "GUID";
            this.coldsSCRAP_SLOT_IDL3DataTableGUID.ColumnName = "GUID";
            this.coldsSCRAP_SLOT_IDL3DataTableGUID.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableName
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableName.Caption = "Name";
            this.coldsSCRAP_SLOT_IDL3DataTableName.ColumnName = "Name";
            this.coldsSCRAP_SLOT_IDL3DataTableName.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableNo
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableNo.Caption = "No";
            this.coldsSCRAP_SLOT_IDL3DataTableNo.ColumnName = "No";
            this.coldsSCRAP_SLOT_IDL3DataTableNo.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableMaterialType
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialType.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableMaterialID
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsSCRAP_SLOT_IDL3DataTableMaterialID.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableLogDate
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableLogDate.Caption = "LogDate";
            this.coldsSCRAP_SLOT_IDL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsSCRAP_SLOT_IDL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsSCRAP_SLOT_IDL3DataTableLogDate.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableAmount
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableAmount.Caption = "Amount";
            this.coldsSCRAP_SLOT_IDL3DataTableAmount.ColumnName = "Amount";
            this.coldsSCRAP_SLOT_IDL3DataTableAmount.DataType = typeof(double);
            this.coldsSCRAP_SLOT_IDL3DataTableAmount.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableType
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableType.Caption = "Type";
            this.coldsSCRAP_SLOT_IDL3DataTableType.ColumnName = "Type";
            this.coldsSCRAP_SLOT_IDL3DataTableType.DataType = typeof(int);
            this.coldsSCRAP_SLOT_IDL3DataTableType.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableReason
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableReason.Caption = "Reason";
            this.coldsSCRAP_SLOT_IDL3DataTableReason.ColumnName = "Reason";
            this.coldsSCRAP_SLOT_IDL3DataTableReason.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableTarget
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableTarget.Caption = "Target";
            this.coldsSCRAP_SLOT_IDL3DataTableTarget.ColumnName = "Target";
            this.coldsSCRAP_SLOT_IDL3DataTableTarget.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableStoreAreaID
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsSCRAP_SLOT_IDL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsSCRAP_SLOT_IDL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableOperator
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableOperator.Caption = "Operator";
            this.coldsSCRAP_SLOT_IDL3DataTableOperator.ColumnName = "Operator";
            this.coldsSCRAP_SLOT_IDL3DataTableOperator.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableShift
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableShift.Caption = "Shift";
            this.coldsSCRAP_SLOT_IDL3DataTableShift.ColumnName = "Shift";
            this.coldsSCRAP_SLOT_IDL3DataTableShift.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableTeam
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableTeam.Caption = "Team";
            this.coldsSCRAP_SLOT_IDL3DataTableTeam.ColumnName = "Team";
            this.coldsSCRAP_SLOT_IDL3DataTableTeam.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableCar_ID
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableCar_ID.Caption = "Car_ID";
            this.coldsSCRAP_SLOT_IDL3DataTableCar_ID.ColumnName = "Car_ID";
            this.coldsSCRAP_SLOT_IDL3DataTableCar_ID.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableCar_Type
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableCar_Type.Caption = "Car_Type";
            this.coldsSCRAP_SLOT_IDL3DataTableCar_Type.ColumnName = "Car_Type";
            this.coldsSCRAP_SLOT_IDL3DataTableCar_Type.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableNet_Weight
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsSCRAP_SLOT_IDL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsSCRAP_SLOT_IDL3DataTableNet_Weight.DataType = typeof(double);
            this.coldsSCRAP_SLOT_IDL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableGross_Weight
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsSCRAP_SLOT_IDL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsSCRAP_SLOT_IDL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsSCRAP_SLOT_IDL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableTare_Weight
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableTare_Weight.Caption = "Tare_Weight";
            this.coldsSCRAP_SLOT_IDL3DataTableTare_Weight.ColumnName = "Tare_Weight";
            this.coldsSCRAP_SLOT_IDL3DataTableTare_Weight.DataType = typeof(double);
            this.coldsSCRAP_SLOT_IDL3DataTableTare_Weight.Namespace = "";
            // 
            // coldsSCRAP_SLOT_IDL3DataTableIron_Flag
            // 
            this.coldsSCRAP_SLOT_IDL3DataTableIron_Flag.Caption = "Iron_Flag";
            this.coldsSCRAP_SLOT_IDL3DataTableIron_Flag.ColumnName = "Iron_Flag";
            this.coldsSCRAP_SLOT_IDL3DataTableIron_Flag.DataType = typeof(int);
            this.coldsSCRAP_SLOT_IDL3DataTableIron_Flag.Namespace = "";
            // 
            // coldsddL3DataTableGUID
            // 
            this.coldsddL3DataTableGUID.Caption = "GUID";
            this.coldsddL3DataTableGUID.ColumnName = "GUID";
            this.coldsddL3DataTableGUID.Namespace = "";
            // 
            // coldsddL3DataTableName
            // 
            this.coldsddL3DataTableName.Caption = "Name";
            this.coldsddL3DataTableName.ColumnName = "Name";
            this.coldsddL3DataTableName.Namespace = "";
            // 
            // coldsddL3DataTableMaterialID
            // 
            this.coldsddL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsddL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsddL3DataTableMaterialID.Namespace = "";
            // 
            // coldsddL3DataTableStatus
            // 
            this.coldsddL3DataTableStatus.Caption = "Status";
            this.coldsddL3DataTableStatus.ColumnName = "Status";
            this.coldsddL3DataTableStatus.DataType = typeof(int);
            this.coldsddL3DataTableStatus.Namespace = "";
            // 
            // coldsddL3DataTablePosition
            // 
            this.coldsddL3DataTablePosition.Caption = "Position";
            this.coldsddL3DataTablePosition.ColumnName = "Position";
            this.coldsddL3DataTablePosition.Namespace = "";
            // 
            // coldsddL3DataTableQAStatus
            // 
            this.coldsddL3DataTableQAStatus.Caption = "QAStatus";
            this.coldsddL3DataTableQAStatus.ColumnName = "QAStatus";
            this.coldsddL3DataTableQAStatus.DataType = typeof(int);
            this.coldsddL3DataTableQAStatus.Namespace = "";
            // 
            // coldsddL3DataTableQALevel
            // 
            this.coldsddL3DataTableQALevel.Caption = "QALevel";
            this.coldsddL3DataTableQALevel.ColumnName = "QALevel";
            this.coldsddL3DataTableQALevel.DataType = typeof(int);
            this.coldsddL3DataTableQALevel.Namespace = "";
            // 
            // coldsddL3DataTableOrderContractID
            // 
            this.coldsddL3DataTableOrderContractID.Caption = "OrderContractID";
            this.coldsddL3DataTableOrderContractID.ColumnName = "OrderContractID";
            this.coldsddL3DataTableOrderContractID.Namespace = "";
            // 
            // coldsddL3DataTableProduceContractID
            // 
            this.coldsddL3DataTableProduceContractID.Caption = "ProduceContractID";
            this.coldsddL3DataTableProduceContractID.ColumnName = "ProduceContractID";
            this.coldsddL3DataTableProduceContractID.Namespace = "";
            // 
            // coldsddL3DataTableSalesContractID
            // 
            this.coldsddL3DataTableSalesContractID.Caption = "SalesContractID";
            this.coldsddL3DataTableSalesContractID.ColumnName = "SalesContractID";
            this.coldsddL3DataTableSalesContractID.Namespace = "";
            // 
            // coldsddL3DataTableWeight
            // 
            this.coldsddL3DataTableWeight.Caption = "Weight";
            this.coldsddL3DataTableWeight.ColumnName = "Weight";
            this.coldsddL3DataTableWeight.DataType = typeof(double);
            this.coldsddL3DataTableWeight.Namespace = "";
            // 
            // coldsddL3DataTableC
            // 
            this.coldsddL3DataTableC.Caption = "C";
            this.coldsddL3DataTableC.ColumnName = "C";
            this.coldsddL3DataTableC.DataType = typeof(float);
            this.coldsddL3DataTableC.Namespace = "";
            // 
            // coldsddL3DataTableSi
            // 
            this.coldsddL3DataTableSi.Caption = "Si";
            this.coldsddL3DataTableSi.ColumnName = "Si";
            this.coldsddL3DataTableSi.DataType = typeof(float);
            this.coldsddL3DataTableSi.Namespace = "";
            // 
            // coldsddL3DataTableMn
            // 
            this.coldsddL3DataTableMn.Caption = "Mn";
            this.coldsddL3DataTableMn.ColumnName = "Mn";
            this.coldsddL3DataTableMn.DataType = typeof(float);
            this.coldsddL3DataTableMn.Namespace = "";
            // 
            // coldsddL3DataTableP
            // 
            this.coldsddL3DataTableP.Caption = "P";
            this.coldsddL3DataTableP.ColumnName = "P";
            this.coldsddL3DataTableP.DataType = typeof(float);
            this.coldsddL3DataTableP.Namespace = "";
            // 
            // coldsddL3DataTableS
            // 
            this.coldsddL3DataTableS.Caption = "S";
            this.coldsddL3DataTableS.ColumnName = "S";
            this.coldsddL3DataTableS.DataType = typeof(float);
            this.coldsddL3DataTableS.Namespace = "";
            // 
            // coldsddL3DataTableTi
            // 
            this.coldsddL3DataTableTi.Caption = "Ti";
            this.coldsddL3DataTableTi.ColumnName = "Ti";
            this.coldsddL3DataTableTi.DataType = typeof(float);
            this.coldsddL3DataTableTi.Namespace = "";
            // 
            // coldsddL3DataTableIronTemp
            // 
            this.coldsddL3DataTableIronTemp.Caption = "IronTemp";
            this.coldsddL3DataTableIronTemp.ColumnName = "IronTemp";
            this.coldsddL3DataTableIronTemp.DataType = typeof(int);
            this.coldsddL3DataTableIronTemp.Namespace = "";
            // 
            // coldsddL3DataTableShift
            // 
            this.coldsddL3DataTableShift.Caption = "Shift";
            this.coldsddL3DataTableShift.ColumnName = "Shift";
            this.coldsddL3DataTableShift.DataType = typeof(bool);
            this.coldsddL3DataTableShift.Namespace = "";
            // 
            // coldsddL3DataTableTeam
            // 
            this.coldsddL3DataTableTeam.Caption = "Team";
            this.coldsddL3DataTableTeam.ColumnName = "Team";
            this.coldsddL3DataTableTeam.DataType = typeof(bool);
            this.coldsddL3DataTableTeam.Namespace = "";
            // 
            // coldsddL3DataTableOperator
            // 
            this.coldsddL3DataTableOperator.Caption = "Operator";
            this.coldsddL3DataTableOperator.ColumnName = "Operator";
            this.coldsddL3DataTableOperator.Namespace = "";
            // 
            // coldsddL3DataTableTare
            // 
            this.coldsddL3DataTableTare.Caption = "Tare";
            this.coldsddL3DataTableTare.ColumnName = "Tare";
            this.coldsddL3DataTableTare.DataType = typeof(double);
            this.coldsddL3DataTableTare.Namespace = "";
            // 
            // coldsddL3DataTableGross_Weight
            // 
            this.coldsddL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsddL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsddL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsddL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsddL3DataTableTap_Time
            // 
            this.coldsddL3DataTableTap_Time.Caption = "Tap_Time";
            this.coldsddL3DataTableTap_Time.ColumnName = "Tap_Time";
            this.coldsddL3DataTableTap_Time.DataType = typeof(System.DateTime);
            this.coldsddL3DataTableTap_Time.Namespace = "";
            // 
            // coldsddL3DataTableIronLadleNo
            // 
            this.coldsddL3DataTableIronLadleNo.Caption = "IronLadleNo";
            this.coldsddL3DataTableIronLadleNo.ColumnName = "IronLadleNo";
            this.coldsddL3DataTableIronLadleNo.Namespace = "";
            // 
            // coldsddL3DataTableObject1
            // 
            this.coldsddL3DataTableObject1.Caption = "Object1";
            this.coldsddL3DataTableObject1.ColumnName = "Object1";
            this.coldsddL3DataTableObject1.Namespace = "";
            // 
            // coldsddL3DataTableWeight1
            // 
            this.coldsddL3DataTableWeight1.Caption = "Weight1";
            this.coldsddL3DataTableWeight1.ColumnName = "Weight1";
            this.coldsddL3DataTableWeight1.DataType = typeof(double);
            this.coldsddL3DataTableWeight1.Namespace = "";
            // 
            // coldsddL3DataTableObject2
            // 
            this.coldsddL3DataTableObject2.Caption = "Object2";
            this.coldsddL3DataTableObject2.ColumnName = "Object2";
            this.coldsddL3DataTableObject2.Namespace = "";
            // 
            // coldsddL3DataTableWeight2
            // 
            this.coldsddL3DataTableWeight2.Caption = "Weight2";
            this.coldsddL3DataTableWeight2.ColumnName = "Weight2";
            this.coldsddL3DataTableWeight2.DataType = typeof(double);
            this.coldsddL3DataTableWeight2.Namespace = "";
            // 
            // coldsddL3DataTableObject3
            // 
            this.coldsddL3DataTableObject3.Caption = "Object3";
            this.coldsddL3DataTableObject3.ColumnName = "Object3";
            this.coldsddL3DataTableObject3.Namespace = "";
            // 
            // coldsddL3DataTableWeight3
            // 
            this.coldsddL3DataTableWeight3.Caption = "Weight3";
            this.coldsddL3DataTableWeight3.ColumnName = "Weight3";
            this.coldsddL3DataTableWeight3.DataType = typeof(double);
            this.coldsddL3DataTableWeight3.Namespace = "";
            // 
            // coldsddL3DataTableReturn_Steel_Weight
            // 
            this.coldsddL3DataTableReturn_Steel_Weight.Caption = "Return_Steel_Weight";
            this.coldsddL3DataTableReturn_Steel_Weight.ColumnName = "Return_Steel_Weight";
            this.coldsddL3DataTableReturn_Steel_Weight.DataType = typeof(float);
            this.coldsddL3DataTableReturn_Steel_Weight.Namespace = "";
            // 
            // coldsddL3DataTableIsDes
            // 
            this.coldsddL3DataTableIsDes.Caption = "IsDes";
            this.coldsddL3DataTableIsDes.ColumnName = "IsDes";
            this.coldsddL3DataTableIsDes.DataType = typeof(float);
            this.coldsddL3DataTableIsDes.Namespace = "";
            // 
            // cmdExcept
            // 
            this.cmdExcept.Adapter = this.Adapter;
            this.cmdExcept.MergeReturnTarget = false;
            this.cmdExcept.Method = "InsertBaseParameter";
            this.cmdExcept.Object = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
            this.cmdExcept.Parameters.Add(this.l3CommandParameter2);
            this.cmdExcept.Parameters.Add(this.l3CommandParameter3);
            this.cmdExcept.ReturnTarget = null;
            this.cmdExcept.ReturnTargetProperty = null;
            this.cmdExcept.Trigger = null;
            this.cmdExcept.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // coldsSumAdditionL3DataTabletype
            // 
            this.coldsSumAdditionL3DataTabletype.Caption = "type";
            this.coldsSumAdditionL3DataTabletype.ColumnName = "type";
            this.coldsSumAdditionL3DataTabletype.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Age
            // 
            this.coldsProcessL3DataTableLadle_Age.Caption = "Ladle_Age";
            this.coldsProcessL3DataTableLadle_Age.ColumnName = "Ladle_Age";
            this.coldsProcessL3DataTableLadle_Age.DataType = typeof(int);
            this.coldsProcessL3DataTableLadle_Age.Namespace = "";
            // 
            // pxTextBox8
            // 
            this.pxTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Age", true));
            this.pxTextBox8.EnableNull = false;
            this.pxTextBox8.ErropPr = this.errorProvider1;
            this.pxTextBox8.Length = 0;
            this.pxTextBox8.Location = new System.Drawing.Point(358, 347);
            this.pxTextBox8.Max = 0;
            this.pxTextBox8.MaxStrLength = 0;
            this.pxTextBox8.Min = 0;
            this.pxTextBox8.MinStrLength = 0;
            this.pxTextBox8.Name = "pxTextBox8";
            this.pxTextBox8.Precision = 0;
            this.pxTextBox8.ReadOnly = true;
            this.pxTextBox8.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox8.TabIndex = 206;
            this.pxTextBox8.ToolTipValid = this.toolTip1;
            this.pxTextBox8.ValidEable = true;
            this.pxTextBox8.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(306, 349);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 207;
            this.label21.Text = "包龄:";
            // 
            // AODHeatInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 766);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "AODHeatInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AOD炉次数据";
            this.Load += new System.EventHandler(this.BOFHeatInfoFrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            this.fLPBase.ResumeLayout(false);
            this.tabMainMat.ResumeLayout(false);
            this.tabMainMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMainMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMainMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMainMat)).EndInit();
            this.fLPMainMat.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.fLPProcess.ResumeLayout(false);
            this.tabAlloy.ResumeLayout(false);
            this.hmiRootPanel4.ResumeLayout(false);
            this.hmiRootPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat_Alloy_Add_Man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat_Alloy_Add_Man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAlloy)).EndInit();
            this.bdAlloy.ResumeLayout(false);
            this.bdAlloy.PerformLayout();
            this.fLPAlloy.ResumeLayout(false);
            this.tabSumAddition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSumAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSumAddition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSumAddition)).EndInit();
            this.tabChemical.ResumeLayout(false);
            this.tabChemical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDataLogMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDataLogMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChemical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnChemical)).EndInit();
            this.bnChemical.ResumeLayout(false);
            this.bnChemical.PerformLayout();
            this.fLPChemical.ResumeLayout(false);
            this.tabBottomBlow.ResumeLayout(false);
            this.tabBottomBlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBottomBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBottomBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBottomBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBottomBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnBottomBlow)).EndInit();
            this.bnBottomBlow.ResumeLayout(false);
            this.bnBottomBlow.PerformLayout();
            this.fLPBottomBlow.ResumeLayout(false);
            this.tabTopBlow.ResumeLayout(false);
            this.tabTopBlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTopBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTopBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopBlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTopBlow)).EndInit();
            this.bnTopBlow.ResumeLayout(false);
            this.bnTopBlow.PerformLayout();
            this.fLPTopBlow.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).EndInit();
            this.bnStatus.ResumeLayout(false);
            this.bnStatus.PerformLayout();
            this.fLPStatus.ResumeLayout(false);
            this.tabTemp.ResumeLayout(false);
            this.hmiRootPanel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFTempMode1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).EndInit();
            this.bnTemp.ResumeLayout(false);
            this.bnTemp.PerformLayout();
            this.fLPTemp.ResumeLayout(false);
            this.tabExcept.ResumeLayout(false);
            this.tabExcept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).EndInit();
            this.fLPExcept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdExcept)).EndInit();
            this.bdExcept.ResumeLayout(false);
            this.bdExcept.PerformLayout();
            this.tabRemark.ResumeLayout(false);
            this.hmiRootPanel3.ResumeLayout(false);
            this.hmiRootPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).EndInit();
            this.bnRemark.ResumeLayout(false);
            this.bnRemark.PerformLayout();
            this.fLPRemark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsBulk_Add_Man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulk_Add_Man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFUnitStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFUnitStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuneFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuneFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFurnaceLineStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFurnaceLineStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlowMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlowMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire_Add_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire_Add_man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOFTempMode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxTextBox txtHeatID;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.Label label10;
        private PxDataValid.PxTextBox tbxSecondHand;
        private System.Windows.Forms.Label label9;
        private PxDataValid.PxTextBox tbxAssistant;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxTextBox tbxHeadFurnace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxTextBox tbxSteelGradeIndex;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox tbxPreHeatID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fLPBase;
        private System.Windows.Forms.Button btnBaseCancel;
        private System.Windows.Forms.Button btnBaseConfirm;
        private System.Windows.Forms.TabPage tabMainMat;
        private PxDataValid.PxTextBox tbxIronTemp;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxTextBox tbxS;
        private System.Windows.Forms.Label label22;
        private PxDataValid.PxTextBox tbxP;
        private System.Windows.Forms.Label label11;
        private PxDataValid.PxTextBox tbxMn;
        private System.Windows.Forms.Label label12;
        private PxDataValid.PxTextBox tbxSi;
        private System.Windows.Forms.Label label13;
        private PxDataValid.PxTextBox tbxC;
        private System.Windows.Forms.Label label14;
        private PxDataValid.PxTextBox tbxReHeatAmount;
        private System.Windows.Forms.Label label15;
        private PxDataValid.PxTextBox tbxPigIronWeight;
        private System.Windows.Forms.Label label16;
        private PxDataValid.PxTextBox tbxScrapWeight;
        private System.Windows.Forms.Label label17;
        private PxDataValid.PxTextBox tbxIronWeight;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel fLPMainMat;
        private System.Windows.Forms.Button btnRemarkCancel;
        private System.Windows.Forms.Button btnRemarkConfirm;
        private System.Windows.Forms.TabPage tabProcess;
        private PxDataValid.PxTextBox txtTappingWeight;
        private System.Windows.Forms.Label label43;
        private PxDataValid.PxTextBox txtTapholeLife;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label39;
        private PxDataValid.PxTextBox txtLadleNo;
        private System.Windows.Forms.Label label40;
        private PxDataValid.PxTextBox txtTappingTemp;
        private System.Windows.Forms.Label label36;
        private PxDataValid.PxTextBox txtLaCTemp;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DateTimePicker dtTappingEndTime;
        private System.Windows.Forms.DateTimePicker dtTappingStartTime;
        private System.Windows.Forms.DateTimePicker dtBlowStartTime;
        private System.Windows.Forms.DateTimePicker dtChargingStartTime;
        private PxDataValid.PxTextBox txtFurnaceAge;
        private System.Windows.Forms.Label label23;
        private PxDataValid.PxTextBox txtLanceAge;
        private System.Windows.Forms.Label label24;
        private PxDataValid.PxTextBox txtSmeltPeriod;
        private System.Windows.Forms.Label label26;
        private PxDataValid.PxTextBox txtSplashingTime;
        private System.Windows.Forms.Label label27;
        private PxDataValid.PxTextBox txtTappingTime;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.FlowLayoutPanel fLPProcess;
        private System.Windows.Forms.Button btnProcessCancel;
        private System.Windows.Forms.Button btnProcessConfirm;
        private System.Windows.Forms.TabPage tabChemical;
        private System.Windows.Forms.FlowLayoutPanel fLPChemical;
        private System.Windows.Forms.Button btnChemicalCancel;
        private System.Windows.Forms.Button btnChemicalConfirm;
        private System.Windows.Forms.TabPage tabBottomBlow;
        private System.Windows.Forms.FlowLayoutPanel fLPBottomBlow;
        private System.Windows.Forms.Button btnBottomBlowCancel;
        private System.Windows.Forms.Button btnBottomBlowConfirm;
        private System.Windows.Forms.TabPage tabTopBlow;
        private System.Windows.Forms.FlowLayoutPanel fLPTopBlow;
        private System.Windows.Forms.Button btnTopBlowCancel;
        private System.Windows.Forms.Button btnTopBlowConfirm;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.FlowLayoutPanel fLPStatus;
        private System.Windows.Forms.Button btnStatusCancel;
        private System.Windows.Forms.Button btnStatusConfirm;
        private System.Windows.Forms.TabPage tabTemp;
        private HMIBase.HMIRootPanel hmiRootPanel6;
        private System.Windows.Forms.FlowLayoutPanel fLPTemp;
        private System.Windows.Forms.Button btnTempCancel;
        private System.Windows.Forms.Button btnTempConfirm;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMainMat;
        private AppSvrHMI.L3DataSet dsMat;
        private AppSvrHMI.L3DataSet dsProcess;
        private AppSvrHMI.L3DataSet dsChemical;
        private AppSvrHMI.L3DataSet dsBottomBlow;
        private AppSvrHMI.L3DataSet dsTopBlow;
        private AppSvrHMI.L3DataSet dsStatus;
        private AppSvrHMI.L3DataSet dsTemp;
        private System.Data.DataTable schemadsMainMat;
        private System.Data.DataColumn coldsMainMatL3DataTableHeatID;
        private System.Data.DataColumn coldsMainMatL3DataTableIronWeight;
        private System.Data.DataColumn coldsMainMatL3DataTableScrapWeight;
        private System.Data.DataColumn coldsMainMatL3DataTablePigIronWeight;
        private System.Data.DataColumn coldsMainMatL3DataTableReHeatAmount;
        private System.Data.DataColumn coldsMainMatL3DataTableC;
        private System.Data.DataColumn coldsMainMatL3DataTableSi;
        private System.Data.DataColumn coldsMainMatL3DataTableMn;
        private System.Data.DataColumn coldsMainMatL3DataTableP;
        private System.Data.DataColumn coldsMainMatL3DataTableS;
        private System.Data.DataColumn coldsMainMatL3DataTableTi;
        private System.Data.DataColumn coldsMainMatL3DataTableIronTemp;
        private System.Data.DataTable schemadsMat;
        private System.Data.DataColumn coldsMatL3DataTableHeatID;
        private System.Data.DataColumn coldsMatL3DataTableElement;
        private System.Data.DataColumn coldsMatL3DataTableWeight;
        private System.Data.DataColumn coldsMatL3DataTableDischarge_Time;
        private System.Data.DataColumn coldsMatL3DataTableType;
        private System.Data.DataTable schemadsProcess;
        private System.Data.DataColumn coldsProcessL3DataTableHeatID;
        private System.Data.DataColumn coldsProcessL3DataTableCharging_Start_Time;
        private System.Data.DataColumn coldsProcessL3DataTableBlow_Start_Time;
        private System.Data.DataColumn coldsProcessL3DataTableTapping_Strat_Time;
        private System.Data.DataColumn coldsProcessL3DataTableTapping_End_Time;
        private System.Data.DataColumn coldsProcessL3DataTableBlowO2_Time;
        private System.Data.DataColumn coldsProcessL3DataTableReBlow_Time;
        private System.Data.DataColumn coldsProcessL3DataTableTapping_Time;
        private System.Data.DataColumn coldsProcessL3DataTableSplashing_Time;
        private System.Data.DataColumn coldsProcessL3DataTableSmelt_Period;
        private System.Data.DataColumn coldsProcessL3DataTableWaiting_Time;
        private System.Data.DataColumn coldsProcessL3DataTableLance_Age;
        private System.Data.DataColumn coldsProcessL3DataTableFurnace_Age;
        private System.Data.DataColumn coldsProcessL3DataTableReBlow_Count;
        private System.Data.DataColumn coldsProcessL3DataTableLaC_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableTapping_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableSingle_LaC;
        private System.Data.DataColumn coldsProcessL3DataTableTapping_Oxygen;
        private System.Data.DataColumn coldsProcessL3DataTableLadleNo;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Status;
        private System.Data.DataColumn coldsProcessL3DataTableTaphole_Life;
        private System.Data.DataColumn coldsProcessL3DataTableTapping_Weight;
        private System.Data.DataColumn coldsProcessL3DataTableFurnace_Line_Status;
        private System.Data.DataTable schemadsChemical;
        private System.Data.DataColumn coldsChemicalL3DataTableAppID;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Code;
        private System.Data.DataColumn coldsChemicalL3DataTableArrive_Date;
        private System.Data.DataColumn coldsChemicalL3DataTableReport_Date;
        private System.Data.DataColumn coldsChemicalL3DataTableHeatID;
        private System.Data.DataColumn coldsChemicalL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsChemicalL3DataTableUnitID;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Address;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Type;
        private System.Data.DataColumn coldsChemicalL3DataTableSample_Count;
        private System.Data.DataColumn coldsChemicalL3DataTableC;
        private System.Data.DataColumn coldsChemicalL3DataTableSi;
        private System.Data.DataColumn coldsChemicalL3DataTableMn;
        private System.Data.DataColumn coldsChemicalL3DataTableP;
        private System.Data.DataColumn coldsChemicalL3DataTableS;
        private System.Data.DataColumn coldsChemicalL3DataTableCu;
        private System.Data.DataColumn coldsChemicalL3DataTableNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCr;
        private System.Data.DataColumn coldsChemicalL3DataTableMo;
        private System.Data.DataColumn coldsChemicalL3DataTableV;
        private System.Data.DataColumn coldsChemicalL3DataTableNb;
        private System.Data.DataColumn coldsChemicalL3DataTableAl;
        private System.Data.DataColumn coldsChemicalL3DataTableAlS;
        private System.Data.DataColumn coldsChemicalL3DataTableTi;
        private System.Data.DataColumn coldsChemicalL3DataTableB;
        private System.Data.DataColumn coldsChemicalL3DataTableSb;
        private System.Data.DataColumn coldsChemicalL3DataTableAs;
        private System.Data.DataColumn coldsChemicalL3DataTableSn;
        private System.Data.DataColumn coldsChemicalL3DataTableZn;
        private System.Data.DataColumn coldsChemicalL3DataTableCa;
        private System.Data.DataColumn coldsChemicalL3DataTableW;
        private System.Data.DataColumn coldsChemicalL3DataTablePb;
        private System.Data.DataColumn coldsChemicalL3DataTableRe;
        private System.Data.DataColumn coldsChemicalL3DataTableCeq;
        private System.Data.DataColumn coldsChemicalL3DataTableN;
        private System.Data.DataColumn coldsChemicalL3DataTableH;
        private System.Data.DataColumn coldsChemicalL3DataTableO;
        private System.Data.DataColumn coldsChemicalL3DataTableOther1;
        private System.Data.DataColumn coldsChemicalL3DataTableOther2;
        private System.Data.DataColumn coldsChemicalL3DataTableLogTime;
        private System.Data.DataColumn coldsChemicalL3DataTableDataLogMode;
        private System.Data.DataTable schemadsBottomBlow;
        private System.Data.DataColumn coldsBottomBlowL3DataTableHeatID;
        private System.Data.DataColumn coldsBottomBlowL3DataTableFlow1;
        private System.Data.DataColumn coldsBottomBlowL3DataTablePressure1;
        private System.Data.DataColumn coldsBottomBlowL3DataTableFlow2;
        private System.Data.DataColumn coldsBottomBlowL3DataTablePressure2;
        private System.Data.DataColumn coldsBottomBlowL3DataTableFlow3;
        private System.Data.DataColumn coldsBottomBlowL3DataTablePressure3;
        private System.Data.DataColumn coldsBottomBlowL3DataTableFlow4;
        private System.Data.DataColumn coldsBottomBlowL3DataTablePressure4;
        private System.Data.DataColumn coldsBottomBlowL3DataTableFlow5;
        private System.Data.DataColumn coldsBottomBlowL3DataTablePressure5;
        private System.Data.DataColumn coldsBottomBlowL3DataTableFlow6;
        private System.Data.DataColumn coldsBottomBlowL3DataTablePressure6;
        private System.Data.DataColumn coldsBottomBlowL3DataTableGas_Type;
        private System.Data.DataColumn coldsBottomBlowL3DataTableCatch_Time;
        private System.Data.DataColumn coldsBottomBlowL3DataTableObjectID;
        private System.Data.DataTable schemadsTopBlow;
        private System.Data.DataColumn coldsTopBlowL3DataTableHeatID;
        private System.Data.DataColumn coldsTopBlowL3DataTableFlow;
        private System.Data.DataColumn coldsTopBlowL3DataTablePressure;
        private System.Data.DataColumn coldsTopBlowL3DataTableCatch_Time;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableHeatID;
        private System.Data.DataColumn coldsStatusL3DataTableStatus;
        private System.Data.DataColumn coldsStatusL3DataTableChange_Time;
        private System.Data.DataTable schemadsTemp;
        private System.Data.DataColumn coldsTempL3DataTableHeatID;
        private System.Data.DataColumn coldsTempL3DataTableTemp;
        private System.Data.DataColumn coldsTempL3DataTableTemp_Time;
        private System.Data.DataColumn coldsTempL3DataTableMode;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableHeatID;
        private System.Data.DataColumn coldsBaseL3DataTablePreHeatID;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGrade;
        private System.Data.DataColumn coldsBaseL3DataTableShift;
        private System.Data.DataColumn coldsBaseL3DataTableTeam;
        private System.Data.DataColumn coldsBaseL3DataTableHeadFurnace;
        private System.Data.DataColumn coldsBaseL3DataTableAssistant;
        private System.Data.DataColumn coldsBaseL3DataTableSecondHand;
        private System.Data.DataColumn coldsBaseL3DataTableProductionDate;
        private System.Data.DataColumn coldsBaseL3DataTableStatisticsDate;
        private System.Data.DataColumn coldsBaseL3DataTableLocked;
        private System.Data.DataColumn coldsMainMatL3DataTableGUID;
        private System.Data.DataColumn coldsMainMatL3DataTableName;
        private System.Data.DataColumn coldsMatL3DataTableGUID;
        private System.Data.DataColumn coldsMatL3DataTableName;
        private System.Data.DataColumn coldsChemicalL3DataTableGUID;
        private System.Data.DataColumn coldsChemicalL3DataTableName;
        private System.Data.DataColumn coldsBottomBlowL3DataTableGUID;
        private System.Data.DataColumn coldsBottomBlowL3DataTableName;
        private System.Data.DataColumn coldsTopBlowL3DataTableGUID;
        private System.Data.DataColumn coldsTopBlowL3DataTableName;
        private System.Data.DataColumn coldsStatusL3DataTableGUID;
        private System.Data.DataColumn coldsStatusL3DataTableName;
        private System.Data.DataColumn coldsTempL3DataTableGUID;
        private System.Data.DataColumn coldsTempL3DataTableName;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingSource bsMainMat;
        private System.Windows.Forms.BindingSource bsMat;
        private System.Windows.Forms.BindingSource bsProcess;
        private System.Windows.Forms.BindingSource bsChemical;
        private System.Windows.Forms.BindingSource bsBottomBlow;
        private System.Windows.Forms.BindingSource bsTopBlow;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.BindingSource bsTemp;
        private System.Windows.Forms.DataGridView dvChemical;
        private System.Windows.Forms.BindingNavigator bnChemical;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton btnAddChemical;
        private System.Windows.Forms.DataGridView dvBottomBlow;
        private System.Windows.Forms.BindingNavigator bnBottomBlow;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.ToolStripButton btnAddBottomBlow;
        private System.Windows.Forms.DataGridView dvTopBlow;
        private System.Windows.Forms.BindingNavigator bnTopBlow;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.ToolStripButton btnAddTopBlow;
        private System.Windows.Forms.DataGridView dvStatus;
        private System.Windows.Forms.BindingNavigator bnStatus;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.ToolStripButton btnAddStatus;
        private System.Windows.Forms.DataGridView dvTemp;
        private System.Windows.Forms.BindingNavigator bnTemp;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
        private System.Windows.Forms.ToolStripButton btnAddTemp;
        private System.Data.DataColumn coldsMatL3DataTableBatch_ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsAdditionType;
        private System.Data.DataTable schemadsAdditionType;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsDataLogMode;
        private System.Data.DataTable schemadsDataLogMode;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsBOFTempMode;
        private System.Data.DataTable schemadsBOFTempMode;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Val_Long;
        private System.Windows.Forms.TabPage tabRemark;
        private AppSvrHMI.L3DataSet dsRemark;
        private System.Data.DataTable schemadsRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableGUID;
        private System.Data.DataColumn coldsRemarkL3DataTableName;
        private System.Data.DataColumn coldsRemarkL3DataTableHeatID;
        private System.Data.DataColumn coldsRemarkL3DataTableTypeID;
        private System.Data.DataColumn coldsRemarkL3DataTableRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableLog_Time;
        private System.Windows.Forms.BindingSource bsRemark;
        private HMIBase.HMIRootPanel hmiRootPanel3;
        private System.Windows.Forms.DataGridView dvRemark;
        private System.Windows.Forms.BindingNavigator bnRemark;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRemarkAdd;
        private System.Windows.Forms.FlowLayoutPanel fLPRemark;
        private System.Windows.Forms.Button btnMainMatCancel;
        private System.Windows.Forms.Button btnMainMatConfirm;
        private AppSvrHMI.L3DataSet dsRemarkType;
        private System.Data.DataTable schemadsRemarkType;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsCode;
        private System.Data.DataTable schemadsCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBOFUnitStatus;
        private System.Data.DataTable schemadsBOFUnitStatus;
        private System.Data.DataColumn coldsBOFUnitStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsBOFUnitStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsUnitType;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsUnitType;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCrCu;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNiCu;
        private System.Data.DataColumn coldsChemicalL3DataTableOther3;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTableCode;
        private System.Data.DataColumn coldsShiftL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbShift;
        private PxDataValid.PxComboBox cmbTeam;
        private AppSvrHMI.L3DataSet dsDuty;
        private System.Data.DataTable schemadsDuty;
        private System.Data.DataColumn coldsDutyL3DataTableGUID;
        private System.Data.DataColumn coldsDutyL3DataTableName;
        private System.Data.DataColumn coldsDutyL3DataTableObjectID;
        private System.Data.DataColumn coldsDutyL3DataTableUnitID;
        private System.Data.DataColumn coldsDutyL3DataTableTeam;
        private System.Data.DataColumn coldsDutyL3DataTableHeadFurnace;
        private System.Data.DataColumn coldsDutyL3DataTableAssistant;
        private System.Data.DataColumn coldsDutyL3DataTableSecondHand;
        private System.Windows.Forms.TabPage tabAlloy;
        private HMIBase.HMIRootPanel hmiRootPanel4;
        private System.Windows.Forms.DataGridView dvAlloy;
        private System.Windows.Forms.BindingNavigator bdAlloy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAddAlloy;
        private System.Windows.Forms.FlowLayoutPanel fLPAlloy;
        private System.Windows.Forms.Button btnAlloyCancel;
        private System.Windows.Forms.Button btnAlloyCanfirm;
        private System.Windows.Forms.BindingSource bsAlloy;
        private System.Windows.Forms.BindingSource bsBulkCode;
        private System.Data.DataColumn coldsCodeL3DataTableCODE_GROUP;
        private System.Windows.Forms.BindingSource bsAlloyCode;
        private System.Windows.Forms.BindingSource bsTapAlloy;
        private AppSvrHMI.L3DataSet dsBlowMode;
        private System.Data.DataTable schemadsBlowMode;
        private System.Data.DataColumn coldsBlowModeL3DataTableCode_des;
        private System.Data.DataColumn coldsBlowModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsTuneFlag;
        private System.Data.DataTable schemadsTuneFlag;
        private System.Data.DataColumn coldsTuneFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsTuneFlagL3DataTableCode_Val_Long;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.BindingSource bsBOFTempMode1;
        private System.Windows.Forms.BindingSource bsBOFTempMode2;
        private AppSvrHMI.L3DataSet dsFurnaceLineStatus;
        private System.Data.DataTable schemadsFurnaceLineStatus;
        private System.Data.DataColumn coldsFurnaceLineStatusL3DataTableCode;
        private System.Data.DataColumn coldsFurnaceLineStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Grade;
        private System.Windows.Forms.ComboBox cmbLadleGrade;
        private System.Data.DataColumn coldsProcessL3DataTableScrapStatus;
        private System.Windows.Forms.ToolStripButton btnDelAlloy;
        private System.Windows.Forms.ToolStripButton btnDelChemical;
        private System.Windows.Forms.ToolStripButton btnDelBottomBlow;
        private System.Windows.Forms.ToolStripButton btnDelTopBlow;
        private System.Windows.Forms.ToolStripButton btnDelStatus;
        private System.Windows.Forms.ToolStripButton btnDelTemp;
        private System.Windows.Forms.ToolStripButton btnRemarkDel;
        private System.Data.DataColumn coldsMainMatL3DataTableReturn_Steel_Weight;
        private System.Windows.Forms.TabPage tabExcept;
        private System.Windows.Forms.BindingNavigator bdExcept;
        private System.Windows.Forms.ToolStripButton btnAddExcept;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem7;
        private System.Windows.Forms.ToolStripButton btnDelExcept;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator21;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator22;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator23;
        private System.Windows.Forms.BindingSource bsExcept;
        private AppSvrHMI.L3DataSet dsExcept;
        private AppSvrHMI.L3Command cmdHeatExcept;
        private System.Data.DataTable schemadsExcept;
        private System.Data.DataColumn coldsExceptL3DataTableID_Object;
        private System.Data.DataColumn coldsExceptL3DataTableHeatID;
        private System.Data.DataColumn coldsExceptL3DataTableProcess_Count;
        private System.Data.DataColumn coldsExceptL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsExceptL3DataTableUnitID;
        private System.Data.DataColumn coldsExceptL3DataTablePreHeatID;
        private System.Data.DataColumn coldsExceptL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsExceptL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptL3DataTableClassify;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Time;
        private AppSvrHMI.L3CommandParameter l3cmdpHeatID;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitType;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitID;
        private AppSvrHMI.L3CommandParameter l3cmdprsData;
        private System.Windows.Forms.DataGridView dvExcept;
        private System.Windows.Forms.FlowLayoutPanel fLPExcept;
        private System.Windows.Forms.Button btnCancelExcept;
        private System.Windows.Forms.Button btnConfirmExcept;
        private AppSvrHMI.L3DataSet dsExceptCode;
        private System.Data.DataTable schemadsExceptCode;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Des;
        private System.Data.DataColumn coldsExceptCodeL3DataTableUnit;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalTimeDataGridViewTextBoxColumn;
        private System.Data.DataColumn AcoldsMatL3DataTableBatch_ID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ComboBox cmbBatchID;
        private System.Data.DataColumn coldsMatL3DataTableEnableFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flow6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gasTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catchTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeIDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name4;
        private System.Data.DataColumn coldsTopBlowL3DataTablePress_MainPipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Press_MainPipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn catchTimeDataGridViewTextBoxColumn1;
        private AppSvrHMI.L3DataSet dsMat_Alloy_Add_Man;
        private System.Data.DataTable schemadsMat_Alloy_Add_Man;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableBatch_ID;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableCode;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsWire_Add_man;
        private AppSvrHMI.L3DataSet dsBulk_Add_Man;
        private System.Data.DataTable schemadsWire_Add_man;
        private System.Data.DataColumn coldsWire_Add_manL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsWire_Add_manL3DataTableBatch_ID;
        private System.Data.DataColumn coldsWire_Add_manL3DataTableCode;
        private System.Data.DataColumn coldsWire_Add_manL3DataTableCode_Des;
        private System.Data.DataTable schemadsBulk_Add_Man;
        private System.Data.DataColumn coldsBulk_Add_ManL3DataTableBulk_Code;
        private System.Data.DataColumn coldsBulk_Add_ManL3DataTableBatch_ID;
        private System.Data.DataColumn coldsBulk_Add_ManL3DataTableCode;
        private System.Data.DataColumn coldsBulk_Add_ManL3DataTableCode_Des;
        private System.Data.DataColumn coldsWire_Add_manL3DataTablecode_function_group;
        private System.Windows.Forms.ToolStripButton btnRefEle;
        private System.Windows.Forms.ToolStripButton btnRefAlloy;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Data.DataColumn coldsProcessL3DataTableCarpolite;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableGUID;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableName;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableNo;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableMaterialType;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableMaterialID;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableLogDate;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableAmount;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableType;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableReason;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableTarget;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableOperator;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableShift;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableTeam;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableCar_ID;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableCar_Type;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableNet_Weight;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableGross_Weight;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableTare_Weight;
        private System.Data.DataColumn coldsSCRAP_SLOT_IDL3DataTableIron_Flag;
        private System.Data.DataColumn coldsddL3DataTableGUID;
        private System.Data.DataColumn coldsddL3DataTableName;
        private System.Data.DataColumn coldsddL3DataTableMaterialID;
        private System.Data.DataColumn coldsddL3DataTableStatus;
        private System.Data.DataColumn coldsddL3DataTablePosition;
        private System.Data.DataColumn coldsddL3DataTableQAStatus;
        private System.Data.DataColumn coldsddL3DataTableQALevel;
        private System.Data.DataColumn coldsddL3DataTableOrderContractID;
        private System.Data.DataColumn coldsddL3DataTableProduceContractID;
        private System.Data.DataColumn coldsddL3DataTableSalesContractID;
        private System.Data.DataColumn coldsddL3DataTableWeight;
        private System.Data.DataColumn coldsddL3DataTableC;
        private System.Data.DataColumn coldsddL3DataTableSi;
        private System.Data.DataColumn coldsddL3DataTableMn;
        private System.Data.DataColumn coldsddL3DataTableP;
        private System.Data.DataColumn coldsddL3DataTableS;
        private System.Data.DataColumn coldsddL3DataTableTi;
        private System.Data.DataColumn coldsddL3DataTableIronTemp;
        private System.Data.DataColumn coldsddL3DataTableShift;
        private System.Data.DataColumn coldsddL3DataTableTeam;
        private System.Data.DataColumn coldsddL3DataTableOperator;
        private System.Data.DataColumn coldsddL3DataTableTare;
        private System.Data.DataColumn coldsddL3DataTableGross_Weight;
        private System.Data.DataColumn coldsddL3DataTableTap_Time;
        private System.Data.DataColumn coldsddL3DataTableIronLadleNo;
        private System.Data.DataColumn coldsddL3DataTableObject1;
        private System.Data.DataColumn coldsddL3DataTableWeight1;
        private System.Data.DataColumn coldsddL3DataTableObject2;
        private System.Data.DataColumn coldsddL3DataTableWeight2;
        private System.Data.DataColumn coldsddL3DataTableObject3;
        private System.Data.DataColumn coldsddL3DataTableWeight3;
        private System.Data.DataColumn coldsddL3DataTableReturn_Steel_Weight;
        private System.Data.DataColumn coldsddL3DataTableIsDes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripTextBox txtExcept;
        private System.Data.DataColumn coldsExceptCodeL3DataTableGUID;
        private System.Data.DataColumn coldsExceptCodeL3DataTableName;
        private System.Data.DataColumn coldsExceptCodeL3DataTableAuto_Judge_Flag;
        private AppSvrHMI.L3Command cmdExcept;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn siDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn znDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ceqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn other1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private PxDataValid.PxTextBox tbxCr;
        private System.Windows.Forms.Label label55;
        private System.Data.DataColumn coldsMainMatL3DataTableCr;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Data.DataColumn coldsProcessL3DataTableReturn_Start_Time;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Stop;
        private System.Windows.Forms.Label label8;
        private System.Data.DataColumn coldsProcessL3DataTableLanceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabSumAddition;
        private System.Windows.Forms.DataGridView dataGridView3;
        private AppSvrHMI.L3DataSet dsSumAddition;
        private System.Data.DataTable schemadsSumAddition;
        private System.Data.DataColumn coldsSumAdditionL3DataTableWEIGHT;
        private System.Data.DataColumn coldsSumAdditionL3DataTableELEMENT;
        private System.Windows.Forms.BindingSource bsSumAddition;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label25;
        private PxDataValid.PxTextBox pxTextBox4;
        private PxDataValid.PxTextBox pxTextBox3;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxTextBox pxTextBox2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox5;
        private PxDataValid.PxTextBox pxTextBox6;
        private System.Windows.Forms.Label label38;
        private PxDataValid.PxTextBox pxTextBox7;
        private System.Windows.Forms.Label label41;
        private PxDataValid.PxTextBox pxTextBox5;
        private System.Windows.Forms.Label label35;
        private System.Data.DataColumn coldsProcessL3DataTableGUID;
        private System.Data.DataColumn coldsProcessL3DataTableName;
        private System.Data.DataColumn coldsProcessL3DataTableFurnaceNo;
        private System.Data.DataColumn coldsProcessL3DataTableIn_Delay_Time;
        private System.Data.DataColumn coldsProcessL3DataTableShebei_Delay_Time;
        private System.Data.DataColumn coldsProcessL3DataTableJiezhi_Delay_Time;
        private System.Data.DataColumn coldsProcessL3DataTableGongfu_Delay_Time;
        private System.Data.DataColumn coldsProcessL3DataTableZhunbei_Delay_Time;
        private System.Data.DataColumn coldsProcessL3DataTableJianxiu_Delay_Time;
        private System.Data.DataColumn coldsProcessL3DataTableO2_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableN2_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableAr_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableN2_Ar_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableBlow_O2_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableDec1_O2_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableDec2_O2_Consume;
        private System.Data.DataColumn coldsProcessL3DataTableCr2O3;
        private System.Windows.Forms.GroupBox groupBox6;
        private PxDataValid.PxTextBox pxTextBox11;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxTextBox pxTextBox10;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxTextBox pxTextBox9;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.GroupBox groupBox7;
        private PxDataValid.PxTextBox pxTextBox15;
        private System.Windows.Forms.Label label51;
        private PxDataValid.PxTextBox pxTextBox14;
        private System.Windows.Forms.Label label50;
        private PxDataValid.PxTextBox pxTextBox13;
        private System.Windows.Forms.Label label49;
        private PxDataValid.PxTextBox pxTextBox12;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label52;
        private PxDataValid.PxComboBox cmbScrapStatus;
        private PxDataValid.PxTextBox txtWaitingTime;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dvcmbAlloyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID_Pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnableFlag;
        private System.Data.DataColumn coldsMainMatL3DataTableReturn_SteelGrade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label54;
        private System.Data.DataColumn coldsSumAdditionL3DataTabletype;
        private System.Data.DataColumn AcoldsSumAdditionL3DataTableTYPE;
        private System.Windows.Forms.DataGridViewComboBoxColumn eLEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private PxDataValid.PxTextBox pxTextBox8;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Age;
        private System.Windows.Forms.Label label21;
    }
}