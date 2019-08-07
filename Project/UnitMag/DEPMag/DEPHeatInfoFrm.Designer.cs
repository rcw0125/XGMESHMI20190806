namespace UnitMag.DEPMag
{
    partial class DEPHeatInfoFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DEPHeatInfoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIronLadle = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHeatID = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIronLadle1 = new PxDataValid.PxTextBox();
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
            this.coldsProcessL3DataTableIronLadle = new System.Data.DataColumn();
            this.coldsProcessL3DataTableFurnace_Surface = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSlag_Head = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadleAge = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Bi_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Line_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Bottom_Temp = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cmbShift = new PxDataValid.PxComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRemarkConfirm = new System.Windows.Forms.Button();
            this.btnRemarkAdd = new System.Windows.Forms.ToolStripButton();
            this.btnAlloyCanfirm = new System.Windows.Forms.Button();
            this.btnAddAlloy = new System.Windows.Forms.ToolStripButton();
            this.btnProcessConfirm = new System.Windows.Forms.Button();
            this.btnBaseConfirm = new System.Windows.Forms.Button();
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
            this.AcoldsBaseL3DataTableIronLadle = new System.Data.DataColumn();
            this.AcoldsBaseL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
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
            this.tbxAssistant = new PxDataValid.PxTextBox();
            this.tbxHeadFurnace = new PxDataValid.PxTextBox();
            this.tbxSteelGradeIndex = new PxDataValid.PxTextBox();
            this.tbxPreHeatID = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fLPBase = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseCancel = new System.Windows.Forms.Button();
            this.tabMainMat = new System.Windows.Forms.TabPage();
            this.pxTextBox18 = new PxDataValid.PxTextBox();
            this.bsMainMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsMainMat = new AppSvrHMI.L3DataSet();
            this.schemadsMainMat = new System.Data.DataTable();
            this.coldsMainMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableName = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableHeatID = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableWeight = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableDepart_Weight = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableC = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableSi = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableMn = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableP = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableS = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableTi = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableSn = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableSb = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableAs = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTablePb = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableNi = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableMo = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableCu = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableCr = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableB = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableV = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableAl = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableNb = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableZn = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableW = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableIronTemp = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableLogTime = new System.Data.DataColumn();
            this.AcoldsMainMatL3DataTableReturn_SteelGrade = new System.Data.DataColumn();
            this.label62 = new System.Windows.Forms.Label();
            this.tbxCr = new PxDataValid.PxTextBox();
            this.tbxIronTemp = new PxDataValid.PxTextBox();
            this.tbxTi = new PxDataValid.PxTextBox();
            this.tbxS = new PxDataValid.PxTextBox();
            this.tbxP = new PxDataValid.PxTextBox();
            this.tbxMn = new PxDataValid.PxTextBox();
            this.tbxSi = new PxDataValid.PxTextBox();
            this.tbxC = new PxDataValid.PxTextBox();
            this.tbxIronWeight = new PxDataValid.PxTextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.fLPMainMat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMainMatCancel = new System.Windows.Forms.Button();
            this.btnMainMatConfirm = new System.Windows.Forms.Button();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pxTextBox20 = new PxDataValid.PxTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pxTextBox17 = new PxDataValid.PxTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.pxTextBox23 = new PxDataValid.PxTextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.pxTextBox22 = new PxDataValid.PxTextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.pxTextBox21 = new PxDataValid.PxTextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.txtSplashingTime = new PxDataValid.PxTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTappingTemp = new PxDataValid.PxTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtTappingTime = new PxDataValid.PxTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtLaCTemp = new PxDataValid.PxTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtTappingEndTime = new System.Windows.Forms.DateTimePicker();
            this.pxTextBox19 = new PxDataValid.PxTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.dtChargingStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtBlowStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtSmeltPeriod = new PxDataValid.PxTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.pxTextBox12 = new PxDataValid.PxTextBox();
            this.pxTextBox16 = new PxDataValid.PxTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.pxTextBox13 = new PxDataValid.PxTextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.txtTappingWeight = new PxDataValid.PxTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFurnaceAge = new PxDataValid.PxTextBox();
            this.pxTextBox15 = new PxDataValid.PxTextBox();
            this.pxTextBox14 = new PxDataValid.PxTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtLanceAge = new PxDataValid.PxTextBox();
            this.txtTapholeLife = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
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
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAdditionType = new AppSvrHMI.L3DataSet();
            this.schemadsAdditionType = new System.Data.DataTable();
            this.coldsAdditionTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAdditionTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdditionTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.calendarColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.dvStatus = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDEPStatus = new AppSvrHMI.L3DataSet();
            this.schemadsDEPStatus = new System.Data.DataTable();
            this.coldsDEPStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableCode_Function_Group = new System.Data.DataColumn();
            this.coldsDEPStatusL3DataTableNC_Code = new System.Data.DataColumn();
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
            this.dsBOFUnitStatus = new AppSvrHMI.L3DataSet();
            this.schemadsBOFUnitStatus = new System.Data.DataTable();
            this.coldsBOFUnitStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBOFUnitStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
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
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.pxTextBox5 = new PxDataValid.PxTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.pxTextBox6 = new PxDataValid.PxTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSingleLaC = new PxDataValid.PxTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.pxTextBox7 = new PxDataValid.PxTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.pxTextBox8 = new PxDataValid.PxTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtReBlowCount = new PxDataValid.PxTextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.pxTextBox9 = new PxDataValid.PxTextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.pxTextBox10 = new PxDataValid.PxTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.pxTextBox11 = new PxDataValid.PxTextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtReBlowTime = new PxDataValid.PxTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.txtBlowO2Time = new PxDataValid.PxTextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label54 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.coldsMatL3DataTableArea = new System.Data.DataColumn();
            this.coldsBaseL3DataTableIronLadle = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableWeight = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableDepart_Weight = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableSn = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableSb = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableAs = new System.Data.DataColumn();
            this.coldsMainMatL3DataTablePb = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableNi = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableMo = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableCu = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableB = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableV = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableAl = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableNb = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableZn = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableW = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsMainMatL3DataTableReturn_SteelGrade = new System.Data.DataColumn();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.coldsSumAdditionL3DataTableTYPE = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).BeginInit();
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
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDEPStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDEPStatus)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).BeginInit();
            this.bnTemp.SuspendLayout();
            this.fLPTemp.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFUnitStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFUnitStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIronLadle
            // 
            this.txtIronLadle.Enabled = false;
            this.txtIronLadle.EnableNull = false;
            this.txtIronLadle.ErropPr = this.errorProvider1;
            this.txtIronLadle.Length = 0;
            this.txtIronLadle.Location = new System.Drawing.Point(132, 6);
            this.txtIronLadle.Max = 0;
            this.txtIronLadle.MaxStrLength = 0;
            this.txtIronLadle.Min = 0;
            this.txtIronLadle.MinStrLength = 0;
            this.txtIronLadle.Name = "txtIronLadle";
            this.txtIronLadle.Precision = 0;
            this.txtIronLadle.ReadOnly = true;
            this.txtIronLadle.Size = new System.Drawing.Size(143, 21);
            this.txtIronLadle.TabIndex = 76;
            this.txtIronLadle.ToolTipValid = this.toolTip1;
            this.txtIronLadle.ValidEable = true;
            this.txtIronLadle.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.txtIronLadle);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtHeatID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 29);
            this.panel3.TabIndex = 85;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(69, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 12);
            this.label16.TabIndex = 75;
            this.label16.Text = "铁包号：";
            // 
            // txtHeatID
            // 
            this.txtHeatID.Enabled = false;
            this.txtHeatID.EnableNull = false;
            this.txtHeatID.ErropPr = this.errorProvider1;
            this.txtHeatID.Length = 0;
            this.txtHeatID.Location = new System.Drawing.Point(368, 3);
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(318, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "炉号：";
            // 
            // txtIronLadle1
            // 
            this.txtIronLadle1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "IronLadle", true));
            this.txtIronLadle1.EnableNull = false;
            this.txtIronLadle1.ErropPr = this.errorProvider1;
            this.txtIronLadle1.Length = 0;
            this.txtIronLadle1.Location = new System.Drawing.Point(694, 77);
            this.txtIronLadle1.Max = 1E+17;
            this.txtIronLadle1.MaxStrLength = 0;
            this.txtIronLadle1.Min = 0;
            this.txtIronLadle1.MinStrLength = 0;
            this.txtIronLadle1.Name = "txtIronLadle1";
            this.txtIronLadle1.Precision = 0;
            this.txtIronLadle1.Size = new System.Drawing.Size(10, 21);
            this.txtIronLadle1.TabIndex = 6;
            this.txtIronLadle1.ToolTipValid = this.toolTip1;
            this.txtIronLadle1.ValidEable = false;
            this.txtIronLadle1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtIronLadle1.TextChanged += new System.EventHandler(this.txtIronLadle1_TextChanged);
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
            this.dsProcess.SourceURI = "XGMESLogic\\DePMag\\CDEP_Process_Data";
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
            this.coldsProcessL3DataTableIronLadle,
            this.coldsProcessL3DataTableFurnace_Surface,
            this.coldsProcessL3DataTableSlag_Head,
            this.coldsProcessL3DataTableLadleAge,
            this.coldsProcessL3DataTableLadle_Bi_Temp,
            this.coldsProcessL3DataTableLadle_Line_Temp,
            this.coldsProcessL3DataTableLadle_Bottom_Temp});
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
            this.coldsProcessL3DataTableReBlow_Count.DataType = typeof(int);
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
            this.coldsProcessL3DataTableSingle_LaC.DataType = typeof(int);
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
            // coldsProcessL3DataTableIronLadle
            // 
            this.coldsProcessL3DataTableIronLadle.Caption = "IronLadle";
            this.coldsProcessL3DataTableIronLadle.ColumnName = "IronLadle";
            this.coldsProcessL3DataTableIronLadle.Namespace = "";
            // 
            // coldsProcessL3DataTableFurnace_Surface
            // 
            this.coldsProcessL3DataTableFurnace_Surface.Caption = "Furnace_Surface";
            this.coldsProcessL3DataTableFurnace_Surface.ColumnName = "Furnace_Surface";
            this.coldsProcessL3DataTableFurnace_Surface.DataType = typeof(int);
            this.coldsProcessL3DataTableFurnace_Surface.Namespace = "";
            // 
            // coldsProcessL3DataTableSlag_Head
            // 
            this.coldsProcessL3DataTableSlag_Head.Caption = "Slag_Head";
            this.coldsProcessL3DataTableSlag_Head.ColumnName = "Slag_Head";
            this.coldsProcessL3DataTableSlag_Head.DataType = typeof(int);
            this.coldsProcessL3DataTableSlag_Head.Namespace = "";
            // 
            // coldsProcessL3DataTableLadleAge
            // 
            this.coldsProcessL3DataTableLadleAge.Caption = "LadleAge";
            this.coldsProcessL3DataTableLadleAge.ColumnName = "LadleAge";
            this.coldsProcessL3DataTableLadleAge.DataType = typeof(double);
            this.coldsProcessL3DataTableLadleAge.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Bi_Temp
            // 
            this.coldsProcessL3DataTableLadle_Bi_Temp.Caption = "Ladle_Bi_Temp";
            this.coldsProcessL3DataTableLadle_Bi_Temp.ColumnName = "Ladle_Bi_Temp";
            this.coldsProcessL3DataTableLadle_Bi_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableLadle_Bi_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Line_Temp
            // 
            this.coldsProcessL3DataTableLadle_Line_Temp.Caption = "Ladle_Line_Temp";
            this.coldsProcessL3DataTableLadle_Line_Temp.ColumnName = "Ladle_Line_Temp";
            this.coldsProcessL3DataTableLadle_Line_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableLadle_Line_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Bottom_Temp
            // 
            this.coldsProcessL3DataTableLadle_Bottom_Temp.Caption = "Ladle_Bottom_Temp";
            this.coldsProcessL3DataTableLadle_Bottom_Temp.ColumnName = "Ladle_Bottom_Temp";
            this.coldsProcessL3DataTableLadle_Bottom_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableLadle_Bottom_Temp.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tabCtrlMain);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 29);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(973, 533);
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
            this.tabCtrlMain.Controls.Add(this.tabStatus);
            this.tabCtrlMain.Controls.Add(this.tabTemp);
            this.tabCtrlMain.Controls.Add(this.tabRemark);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(973, 533);
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
            this.tabBase.Controls.Add(this.tbxAssistant);
            this.tabBase.Controls.Add(this.tbxHeadFurnace);
            this.tabBase.Controls.Add(this.tbxSteelGradeIndex);
            this.tabBase.Controls.Add(this.tbxPreHeatID);
            this.tabBase.Controls.Add(this.label9);
            this.tabBase.Controls.Add(this.label7);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.label3);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.label1);
            this.tabBase.Controls.Add(this.fLPBase);
            this.tabBase.Location = new System.Drawing.Point(4, 21);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(965, 508);
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
            this.dsBase.SourceURI = "XGMESLogic\\DePMag\\CDEP_Base_Data";
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
            // button2
            // 
            this.Adapter.SetAccessRight(this.button2, "BOFCheck");
            this.button2.Location = new System.Drawing.Point(794, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolStripButton13
            // 
            this.Adapter.SetAccessRight(this.toolStripButton13, "BOFCheck");
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "新添";
            // 
            // button4
            // 
            this.Adapter.SetAccessRight(this.button4, "BOFCheck");
            this.button4.Location = new System.Drawing.Point(794, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 86;
            this.button4.Text = "确认";
            this.button4.UseVisualStyleBackColor = true;
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
            this.coldsBaseL3DataTableLocked,
            this.AcoldsBaseL3DataTableIronLadle,
            this.AcoldsBaseL3DataTableNC_Confirm_Flag});
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
            this.coldsBaseL3DataTableLocked.DataType = typeof(bool);
            this.coldsBaseL3DataTableLocked.Namespace = "";
            // 
            // AcoldsBaseL3DataTableIronLadle
            // 
            this.AcoldsBaseL3DataTableIronLadle.Caption = "IronLadle";
            this.AcoldsBaseL3DataTableIronLadle.ColumnName = "IronLadle";
            this.AcoldsBaseL3DataTableIronLadle.Namespace = "";
            // 
            // AcoldsBaseL3DataTableNC_Confirm_Flag
            // 
            this.AcoldsBaseL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.AcoldsBaseL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.AcoldsBaseL3DataTableNC_Confirm_Flag.DataType = typeof(int);
            this.AcoldsBaseL3DataTableNC_Confirm_Flag.Namespace = "";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 102;
            this.label9.Text = "二助手:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "炼钢记号:";
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
            this.fLPBase.Location = new System.Drawing.Point(3, 470);
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
            this.tabMainMat.Controls.Add(this.pxTextBox18);
            this.tabMainMat.Controls.Add(this.label62);
            this.tabMainMat.Controls.Add(this.tbxCr);
            this.tabMainMat.Controls.Add(this.tbxIronTemp);
            this.tabMainMat.Controls.Add(this.tbxTi);
            this.tabMainMat.Controls.Add(this.tbxS);
            this.tabMainMat.Controls.Add(this.tbxP);
            this.tabMainMat.Controls.Add(this.tbxMn);
            this.tabMainMat.Controls.Add(this.tbxSi);
            this.tabMainMat.Controls.Add(this.tbxC);
            this.tabMainMat.Controls.Add(this.tbxIronWeight);
            this.tabMainMat.Controls.Add(this.label55);
            this.tabMainMat.Controls.Add(this.label19);
            this.tabMainMat.Controls.Add(this.label21);
            this.tabMainMat.Controls.Add(this.label22);
            this.tabMainMat.Controls.Add(this.label11);
            this.tabMainMat.Controls.Add(this.label12);
            this.tabMainMat.Controls.Add(this.label13);
            this.tabMainMat.Controls.Add(this.label14);
            this.tabMainMat.Controls.Add(this.label18);
            this.tabMainMat.Controls.Add(this.fLPMainMat);
            this.tabMainMat.Location = new System.Drawing.Point(4, 21);
            this.tabMainMat.Name = "tabMainMat";
            this.tabMainMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainMat.Size = new System.Drawing.Size(965, 508);
            this.tabMainMat.TabIndex = 5;
            this.tabMainMat.Text = "主原料数据";
            this.tabMainMat.UseVisualStyleBackColor = true;
            // 
            // pxTextBox18
            // 
            this.pxTextBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Depart_Weight", true));
            this.pxTextBox18.EnableNull = false;
            this.pxTextBox18.ErropPr = this.errorProvider1;
            this.pxTextBox18.Length = 0;
            this.pxTextBox18.Location = new System.Drawing.Point(141, 48);
            this.pxTextBox18.Max = 999;
            this.pxTextBox18.MaxStrLength = 0;
            this.pxTextBox18.Min = 0;
            this.pxTextBox18.MinStrLength = 0;
            this.pxTextBox18.Name = "pxTextBox18";
            this.pxTextBox18.Precision = 0;
            this.pxTextBox18.Size = new System.Drawing.Size(100, 21);
            this.pxTextBox18.TabIndex = 135;
            this.pxTextBox18.ToolTipValid = this.toolTip1;
            this.pxTextBox18.ValidEable = true;
            this.pxTextBox18.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // bsMainMat
            // 
            this.bsMainMat.AllowNew = true;
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
            this.dsMainMat.L3DataAdapter = this.Adapter;
            this.dsMainMat.LoadEvent = "Click";
            this.dsMainMat.LoadTrigger = null;
            this.dsMainMat.RefreshValve = 1000;
            this.dsMainMat.SourceCommand = null;
            this.dsMainMat.SourceCondition = "1=2";
            this.dsMainMat.SourceMethod = "";
            this.dsMainMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMainMat.SourceURI = "XGMESLogic\\DePMag\\CDEP_Feed_Data";
            this.dsMainMat.SubscribeTarget = null;
            this.dsMainMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMainMat});
            this.dsMainMat.UpdateEvent = "Click";
            this.dsMainMat.UpdateMethod = null;
            this.dsMainMat.UpdateTrigger = null;
            // 
            // schemadsMainMat
            // 
            this.schemadsMainMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainMatL3DataTableGUID,
            this.coldsMainMatL3DataTableName,
            this.coldsMainMatL3DataTableHeatID,
            this.AcoldsMainMatL3DataTableWeight,
            this.AcoldsMainMatL3DataTableDepart_Weight,
            this.coldsMainMatL3DataTableC,
            this.coldsMainMatL3DataTableSi,
            this.coldsMainMatL3DataTableMn,
            this.coldsMainMatL3DataTableP,
            this.coldsMainMatL3DataTableS,
            this.coldsMainMatL3DataTableTi,
            this.AcoldsMainMatL3DataTableSn,
            this.AcoldsMainMatL3DataTableSb,
            this.AcoldsMainMatL3DataTableAs,
            this.AcoldsMainMatL3DataTablePb,
            this.AcoldsMainMatL3DataTableNi,
            this.AcoldsMainMatL3DataTableMo,
            this.AcoldsMainMatL3DataTableCu,
            this.coldsMainMatL3DataTableCr,
            this.AcoldsMainMatL3DataTableB,
            this.AcoldsMainMatL3DataTableV,
            this.AcoldsMainMatL3DataTableAl,
            this.AcoldsMainMatL3DataTableNb,
            this.AcoldsMainMatL3DataTableZn,
            this.AcoldsMainMatL3DataTableW,
            this.coldsMainMatL3DataTableIronTemp,
            this.AcoldsMainMatL3DataTableLogTime,
            this.AcoldsMainMatL3DataTableReturn_SteelGrade});
            this.schemadsMainMat.TableName = "L3DataTable";
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
            // coldsMainMatL3DataTableHeatID
            // 
            this.coldsMainMatL3DataTableHeatID.Caption = "HeatID";
            this.coldsMainMatL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMainMatL3DataTableHeatID.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableWeight
            // 
            this.AcoldsMainMatL3DataTableWeight.Caption = "Weight";
            this.AcoldsMainMatL3DataTableWeight.ColumnName = "Weight";
            this.AcoldsMainMatL3DataTableWeight.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableWeight.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableDepart_Weight
            // 
            this.AcoldsMainMatL3DataTableDepart_Weight.Caption = "Depart_Weight";
            this.AcoldsMainMatL3DataTableDepart_Weight.ColumnName = "Depart_Weight";
            this.AcoldsMainMatL3DataTableDepart_Weight.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableDepart_Weight.Namespace = "";
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
            // AcoldsMainMatL3DataTableSn
            // 
            this.AcoldsMainMatL3DataTableSn.Caption = "Sn";
            this.AcoldsMainMatL3DataTableSn.ColumnName = "Sn";
            this.AcoldsMainMatL3DataTableSn.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableSn.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableSb
            // 
            this.AcoldsMainMatL3DataTableSb.Caption = "Sb";
            this.AcoldsMainMatL3DataTableSb.ColumnName = "Sb";
            this.AcoldsMainMatL3DataTableSb.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableSb.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableAs
            // 
            this.AcoldsMainMatL3DataTableAs.Caption = "As";
            this.AcoldsMainMatL3DataTableAs.ColumnName = "As";
            this.AcoldsMainMatL3DataTableAs.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableAs.Namespace = "";
            // 
            // AcoldsMainMatL3DataTablePb
            // 
            this.AcoldsMainMatL3DataTablePb.Caption = "Pb";
            this.AcoldsMainMatL3DataTablePb.ColumnName = "Pb";
            this.AcoldsMainMatL3DataTablePb.DataType = typeof(float);
            this.AcoldsMainMatL3DataTablePb.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableNi
            // 
            this.AcoldsMainMatL3DataTableNi.Caption = "Ni";
            this.AcoldsMainMatL3DataTableNi.ColumnName = "Ni";
            this.AcoldsMainMatL3DataTableNi.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableNi.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableMo
            // 
            this.AcoldsMainMatL3DataTableMo.Caption = "Mo";
            this.AcoldsMainMatL3DataTableMo.ColumnName = "Mo";
            this.AcoldsMainMatL3DataTableMo.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableMo.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableCu
            // 
            this.AcoldsMainMatL3DataTableCu.Caption = "Cu";
            this.AcoldsMainMatL3DataTableCu.ColumnName = "Cu";
            this.AcoldsMainMatL3DataTableCu.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableCu.Namespace = "";
            // 
            // coldsMainMatL3DataTableCr
            // 
            this.coldsMainMatL3DataTableCr.Caption = "Cr";
            this.coldsMainMatL3DataTableCr.ColumnName = "Cr";
            this.coldsMainMatL3DataTableCr.DataType = typeof(float);
            this.coldsMainMatL3DataTableCr.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableB
            // 
            this.AcoldsMainMatL3DataTableB.Caption = "B";
            this.AcoldsMainMatL3DataTableB.ColumnName = "B";
            this.AcoldsMainMatL3DataTableB.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableB.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableV
            // 
            this.AcoldsMainMatL3DataTableV.Caption = "V";
            this.AcoldsMainMatL3DataTableV.ColumnName = "V";
            this.AcoldsMainMatL3DataTableV.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableV.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableAl
            // 
            this.AcoldsMainMatL3DataTableAl.Caption = "Al";
            this.AcoldsMainMatL3DataTableAl.ColumnName = "Al";
            this.AcoldsMainMatL3DataTableAl.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableAl.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableNb
            // 
            this.AcoldsMainMatL3DataTableNb.Caption = "Nb";
            this.AcoldsMainMatL3DataTableNb.ColumnName = "Nb";
            this.AcoldsMainMatL3DataTableNb.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableNb.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableZn
            // 
            this.AcoldsMainMatL3DataTableZn.Caption = "Zn";
            this.AcoldsMainMatL3DataTableZn.ColumnName = "Zn";
            this.AcoldsMainMatL3DataTableZn.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableZn.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableW
            // 
            this.AcoldsMainMatL3DataTableW.Caption = "W";
            this.AcoldsMainMatL3DataTableW.ColumnName = "W";
            this.AcoldsMainMatL3DataTableW.DataType = typeof(float);
            this.AcoldsMainMatL3DataTableW.Namespace = "";
            // 
            // coldsMainMatL3DataTableIronTemp
            // 
            this.coldsMainMatL3DataTableIronTemp.Caption = "IronTemp";
            this.coldsMainMatL3DataTableIronTemp.ColumnName = "IronTemp";
            this.coldsMainMatL3DataTableIronTemp.DataType = typeof(int);
            this.coldsMainMatL3DataTableIronTemp.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableLogTime
            // 
            this.AcoldsMainMatL3DataTableLogTime.Caption = "LogTime";
            this.AcoldsMainMatL3DataTableLogTime.ColumnName = "LogTime";
            this.AcoldsMainMatL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.AcoldsMainMatL3DataTableLogTime.Namespace = "";
            // 
            // AcoldsMainMatL3DataTableReturn_SteelGrade
            // 
            this.AcoldsMainMatL3DataTableReturn_SteelGrade.Caption = "Return_SteelGrade";
            this.AcoldsMainMatL3DataTableReturn_SteelGrade.ColumnName = "Return_SteelGrade";
            this.AcoldsMainMatL3DataTableReturn_SteelGrade.Namespace = "";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(64, 52);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(77, 12);
            this.label62.TabIndex = 136;
            this.label62.Text = "接铁皮重[T]:";
            // 
            // tbxCr
            // 
            this.tbxCr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Mo", true));
            this.tbxCr.EnableNull = false;
            this.tbxCr.ErropPr = this.errorProvider1;
            this.tbxCr.Length = 0;
            this.tbxCr.Location = new System.Drawing.Point(747, 46);
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
            // tbxIronTemp
            // 
            this.tbxIronTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "IronTemp", true));
            this.tbxIronTemp.EnableNull = false;
            this.tbxIronTemp.ErropPr = this.errorProvider1;
            this.tbxIronTemp.Length = 0;
            this.tbxIronTemp.Location = new System.Drawing.Point(141, 76);
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
            // tbxTi
            // 
            this.tbxTi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Ni", true));
            this.tbxTi.EnableNull = false;
            this.tbxTi.ErropPr = this.errorProvider1;
            this.tbxTi.Length = 0;
            this.tbxTi.Location = new System.Drawing.Point(747, 19);
            this.tbxTi.Max = 5;
            this.tbxTi.MaxStrLength = 0;
            this.tbxTi.Min = 0;
            this.tbxTi.MinStrLength = 0;
            this.tbxTi.Name = "tbxTi";
            this.tbxTi.Precision = 0;
            this.tbxTi.ReadOnly = true;
            this.tbxTi.Size = new System.Drawing.Size(100, 21);
            this.tbxTi.TabIndex = 125;
            this.tbxTi.ToolTipValid = this.toolTip1;
            this.tbxTi.ValidEable = true;
            this.tbxTi.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // tbxS
            // 
            this.tbxS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "S", true));
            this.tbxS.EnableNull = false;
            this.tbxS.ErropPr = this.errorProvider1;
            this.tbxS.Length = 0;
            this.tbxS.Location = new System.Drawing.Point(534, 19);
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
            // tbxP
            // 
            this.tbxP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "P", true));
            this.tbxP.EnableNull = false;
            this.tbxP.ErropPr = this.errorProvider1;
            this.tbxP.Length = 0;
            this.tbxP.Location = new System.Drawing.Point(534, 46);
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
            // tbxMn
            // 
            this.tbxMn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Mn", true));
            this.tbxMn.EnableNull = false;
            this.tbxMn.ErropPr = this.errorProvider1;
            this.tbxMn.Length = 0;
            this.tbxMn.Location = new System.Drawing.Point(333, 70);
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
            // tbxSi
            // 
            this.tbxSi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Si", true));
            this.tbxSi.EnableNull = false;
            this.tbxSi.ErropPr = this.errorProvider1;
            this.tbxSi.Length = 0;
            this.tbxSi.Location = new System.Drawing.Point(333, 43);
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
            // tbxC
            // 
            this.tbxC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "C", true));
            this.tbxC.EnableNull = false;
            this.tbxC.ErropPr = this.errorProvider1;
            this.tbxC.Length = 0;
            this.tbxC.Location = new System.Drawing.Point(333, 19);
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
            // tbxIronWeight
            // 
            this.tbxIronWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMainMat, "Weight", true));
            this.tbxIronWeight.EnableNull = false;
            this.tbxIronWeight.ErropPr = this.errorProvider1;
            this.tbxIronWeight.Length = 0;
            this.tbxIronWeight.Location = new System.Drawing.Point(141, 19);
            this.tbxIronWeight.Max = 999;
            this.tbxIronWeight.MaxStrLength = 0;
            this.tbxIronWeight.Min = 0;
            this.tbxIronWeight.MinStrLength = 0;
            this.tbxIronWeight.Name = "tbxIronWeight";
            this.tbxIronWeight.Precision = 0;
            this.tbxIronWeight.Size = new System.Drawing.Size(100, 21);
            this.tbxIronWeight.TabIndex = 0;
            this.tbxIronWeight.ToolTipValid = this.toolTip1;
            this.tbxIronWeight.ValidEable = true;
            this.tbxIronWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(676, 49);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 12);
            this.label55.TabIndex = 133;
            this.label55.Text = "Mo成份[%]:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(52, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 12);
            this.label19.TabIndex = 128;
            this.label19.Text = "铁水温度[℃]:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(676, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 124;
            this.label21.Text = "Ni成份[%]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(463, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 122;
            this.label22.Text = "硫成份[%]:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 120;
            this.label11.Text = "磷成份[%]:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 118;
            this.label12.Text = "锰成份[%]:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 116;
            this.label13.Text = "硅成份[%]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 114;
            this.label14.Text = "碳成份[%]:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(76, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 106;
            this.label18.Text = "铁水量[T]:";
            // 
            // fLPMainMat
            // 
            this.fLPMainMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPMainMat.Controls.Add(this.btnMainMatCancel);
            this.fLPMainMat.Controls.Add(this.btnMainMatConfirm);
            this.fLPMainMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPMainMat.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPMainMat.Location = new System.Drawing.Point(3, 470);
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
            this.tabProcess.Controls.Add(this.groupBox7);
            this.tabProcess.Controls.Add(this.groupBox6);
            this.tabProcess.Controls.Add(this.groupBox4);
            this.tabProcess.Controls.Add(this.groupBox2);
            this.tabProcess.Controls.Add(this.fLPProcess);
            this.tabProcess.Controls.Add(this.txtIronLadle1);
            this.tabProcess.Location = new System.Drawing.Point(4, 21);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(965, 508);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "脱磷数据";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pxTextBox20);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Controls.Add(this.txtTappingTime);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.txtLaCTemp);
            this.groupBox7.Controls.Add(this.label37);
            this.groupBox7.Location = new System.Drawing.Point(270, 57);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(266, 319);
            this.groupBox7.TabIndex = 207;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "脱硅操作";
            // 
            // pxTextBox20
            // 
            this.pxTextBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LaC_Temp", true));
            this.pxTextBox20.EnableNull = false;
            this.pxTextBox20.ErropPr = this.errorProvider1;
            this.pxTextBox20.Length = 0;
            this.pxTextBox20.Location = new System.Drawing.Point(145, 84);
            this.pxTextBox20.Max = 2000;
            this.pxTextBox20.MaxStrLength = 0;
            this.pxTextBox20.Min = 0;
            this.pxTextBox20.MinStrLength = 0;
            this.pxTextBox20.Name = "pxTextBox20";
            this.pxTextBox20.Precision = 0;
            this.pxTextBox20.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox20.TabIndex = 208;
            this.pxTextBox20.ToolTipValid = this.toolTip1;
            this.pxTextBox20.ValidEable = true;
            this.pxTextBox20.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.pxTextBox17);
            this.groupBox8.Controls.Add(this.label40);
            this.groupBox8.Controls.Add(this.pxTextBox23);
            this.groupBox8.Controls.Add(this.label65);
            this.groupBox8.Controls.Add(this.pxTextBox22);
            this.groupBox8.Controls.Add(this.label64);
            this.groupBox8.Controls.Add(this.pxTextBox21);
            this.groupBox8.Controls.Add(this.label63);
            this.groupBox8.Controls.Add(this.txtSplashingTime);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Controls.Add(this.txtTappingTemp);
            this.groupBox8.Controls.Add(this.label36);
            this.groupBox8.Location = new System.Drawing.Point(0, 125);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(266, 194);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "脱磷操作";
            // 
            // pxTextBox17
            // 
            this.pxTextBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tapping_Oxygen", true));
            this.pxTextBox17.EnableNull = false;
            this.pxTextBox17.ErropPr = this.errorProvider1;
            this.pxTextBox17.Length = 0;
            this.pxTextBox17.Location = new System.Drawing.Point(142, 140);
            this.pxTextBox17.Max = 2000;
            this.pxTextBox17.MaxStrLength = 0;
            this.pxTextBox17.Min = 0;
            this.pxTextBox17.MinStrLength = 0;
            this.pxTextBox17.Name = "pxTextBox17";
            this.pxTextBox17.Precision = 0;
            this.pxTextBox17.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox17.TabIndex = 208;
            this.pxTextBox17.ToolTipValid = this.toolTip1;
            this.pxTextBox17.ValidEable = true;
            this.pxTextBox17.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(89, 143);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(47, 12);
            this.label40.TabIndex = 209;
            this.label40.Text = "保温剂:";
            // 
            // pxTextBox23
            // 
            this.pxTextBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tapping_Temp", true));
            this.pxTextBox23.EnableNull = false;
            this.pxTextBox23.ErropPr = this.errorProvider1;
            this.pxTextBox23.Length = 0;
            this.pxTextBox23.Location = new System.Drawing.Point(142, 167);
            this.pxTextBox23.Max = 2000;
            this.pxTextBox23.MaxStrLength = 0;
            this.pxTextBox23.Min = 0;
            this.pxTextBox23.MinStrLength = 0;
            this.pxTextBox23.Name = "pxTextBox23";
            this.pxTextBox23.Precision = 0;
            this.pxTextBox23.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox23.TabIndex = 167;
            this.pxTextBox23.ToolTipValid = this.toolTip1;
            this.pxTextBox23.ValidEable = true;
            this.pxTextBox23.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(41, 170);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(95, 12);
            this.label65.TabIndex = 168;
            this.label65.Text = "脱磷后温度[℃]:";
            // 
            // pxTextBox22
            // 
            this.pxTextBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Splashing_Time", true));
            this.pxTextBox22.EnableNull = false;
            this.pxTextBox22.ErropPr = this.errorProvider1;
            this.pxTextBox22.Length = 0;
            this.pxTextBox22.Location = new System.Drawing.Point(143, 103);
            this.pxTextBox22.Max = 9000;
            this.pxTextBox22.MaxStrLength = 0;
            this.pxTextBox22.Min = 0;
            this.pxTextBox22.MinStrLength = 0;
            this.pxTextBox22.Name = "pxTextBox22";
            this.pxTextBox22.Precision = 0;
            this.pxTextBox22.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox22.TabIndex = 165;
            this.pxTextBox22.ToolTipValid = this.toolTip1;
            this.pxTextBox22.ValidEable = true;
            this.pxTextBox22.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(89, 106);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(47, 12);
            this.label64.TabIndex = 166;
            this.label64.Text = "供氧量:";
            // 
            // pxTextBox21
            // 
            this.pxTextBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Single_LaC", true));
            this.pxTextBox21.EnableNull = false;
            this.pxTextBox21.ErropPr = this.errorProvider1;
            this.pxTextBox21.Length = 0;
            this.pxTextBox21.Location = new System.Drawing.Point(143, 72);
            this.pxTextBox21.Max = 2000;
            this.pxTextBox21.MaxStrLength = 0;
            this.pxTextBox21.Min = 0;
            this.pxTextBox21.MinStrLength = 0;
            this.pxTextBox21.Name = "pxTextBox21";
            this.pxTextBox21.Precision = 0;
            this.pxTextBox21.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox21.TabIndex = 163;
            this.pxTextBox21.ToolTipValid = this.toolTip1;
            this.pxTextBox21.ValidEable = true;
            this.pxTextBox21.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(77, 75);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(59, 12);
            this.label63.TabIndex = 164;
            this.label63.Text = "补吹时间:";
            // 
            // txtSplashingTime
            // 
            this.txtSplashingTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "ReBlow_Time", true));
            this.txtSplashingTime.EnableNull = true;
            this.txtSplashingTime.ErropPr = this.errorProvider1;
            this.txtSplashingTime.Length = 0;
            this.txtSplashingTime.Location = new System.Drawing.Point(142, 20);
            this.txtSplashingTime.Max = 9999;
            this.txtSplashingTime.MaxStrLength = 0;
            this.txtSplashingTime.Min = 0;
            this.txtSplashingTime.MinStrLength = 0;
            this.txtSplashingTime.Name = "txtSplashingTime";
            this.txtSplashingTime.Precision = 0;
            this.txtSplashingTime.ReadOnly = true;
            this.txtSplashingTime.Size = new System.Drawing.Size(65, 21);
            this.txtSplashingTime.TabIndex = 7;
            this.txtSplashingTime.ToolTipValid = this.toolTip1;
            this.txtSplashingTime.ValidEable = true;
            this.txtSplashingTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtSplashingTime.TextChanged += new System.EventHandler(this.txtSplashingTime_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(53, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 144;
            this.label27.Text = "脱磷喷吹时间:";
            // 
            // txtTappingTemp
            // 
            this.txtTappingTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "ReBlow_Count", true));
            this.txtTappingTemp.EnableNull = false;
            this.txtTappingTemp.ErropPr = this.errorProvider1;
            this.txtTappingTemp.Length = 0;
            this.txtTappingTemp.Location = new System.Drawing.Point(143, 47);
            this.txtTappingTemp.Max = 2000;
            this.txtTappingTemp.MaxStrLength = 0;
            this.txtTappingTemp.Min = 0;
            this.txtTappingTemp.MinStrLength = 0;
            this.txtTappingTemp.Name = "txtTappingTemp";
            this.txtTappingTemp.Precision = 0;
            this.txtTappingTemp.Size = new System.Drawing.Size(64, 21);
            this.txtTappingTemp.TabIndex = 18;
            this.txtTappingTemp.ToolTipValid = this.toolTip1;
            this.txtTappingTemp.ValidEable = true;
            this.txtTappingTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(77, 50);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 12);
            this.label36.TabIndex = 162;
            this.label36.Text = "补吹次数:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(50, 90);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 12);
            this.label32.TabIndex = 209;
            this.label32.Text = "脱硅后温度[℃]:";
            // 
            // txtTappingTime
            // 
            this.txtTappingTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "BlowO2_Time", true));
            this.txtTappingTime.EnableNull = false;
            this.txtTappingTime.ErropPr = this.errorProvider1;
            this.txtTappingTime.Length = 0;
            this.txtTappingTime.Location = new System.Drawing.Point(145, 26);
            this.txtTappingTime.Max = 9999;
            this.txtTappingTime.MaxStrLength = 0;
            this.txtTappingTime.Min = 0;
            this.txtTappingTime.MinStrLength = 0;
            this.txtTappingTime.Name = "txtTappingTime";
            this.txtTappingTime.Precision = 0;
            this.txtTappingTime.ReadOnly = true;
            this.txtTappingTime.Size = new System.Drawing.Size(65, 21);
            this.txtTappingTime.TabIndex = 6;
            this.txtTappingTime.ToolTipValid = this.toolTip1;
            this.txtTappingTime.ValidEable = true;
            this.txtTappingTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtTappingTime.TextChanged += new System.EventHandler(this.txtTappingTime_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(62, 29);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 12);
            this.label28.TabIndex = 142;
            this.label28.Text = "脱硅喷吹时间:";
            // 
            // txtLaCTemp
            // 
            this.txtLaCTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tapping_Time", true));
            this.txtLaCTemp.EnableNull = false;
            this.txtLaCTemp.ErropPr = this.errorProvider1;
            this.txtLaCTemp.Length = 0;
            this.txtLaCTemp.Location = new System.Drawing.Point(145, 53);
            this.txtLaCTemp.Max = 9000;
            this.txtLaCTemp.MaxStrLength = 0;
            this.txtLaCTemp.Min = 0;
            this.txtLaCTemp.MinStrLength = 0;
            this.txtLaCTemp.Name = "txtLaCTemp";
            this.txtLaCTemp.Precision = 0;
            this.txtLaCTemp.Size = new System.Drawing.Size(64, 21);
            this.txtLaCTemp.TabIndex = 17;
            this.txtLaCTemp.ToolTipValid = this.toolTip1;
            this.txtLaCTemp.ValidEable = true;
            this.txtLaCTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(94, 59);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(47, 12);
            this.label37.TabIndex = 160;
            this.label37.Text = "供氧量:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtTappingEndTime);
            this.groupBox6.Controls.Add(this.pxTextBox19);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.dtChargingStartTime);
            this.groupBox6.Controls.Add(this.dtBlowStartTime);
            this.groupBox6.Controls.Add(this.txtSmeltPeriod);
            this.groupBox6.Location = new System.Drawing.Point(7, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 211);
            this.groupBox6.TabIndex = 206;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "时间节点";
            // 
            // dtTappingEndTime
            // 
            this.dtTappingEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTappingEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Tapping_End_Time", true));
            this.dtTappingEndTime.Enabled = false;
            this.dtTappingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTappingEndTime.Location = new System.Drawing.Point(87, 91);
            this.dtTappingEndTime.Name = "dtTappingEndTime";
            this.dtTappingEndTime.Size = new System.Drawing.Size(144, 21);
            this.dtTappingEndTime.TabIndex = 3;
            // 
            // pxTextBox19
            // 
            this.pxTextBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Waiting_Time", true));
            this.pxTextBox19.EnableNull = false;
            this.pxTextBox19.ErropPr = this.errorProvider1;
            this.pxTextBox19.Length = 0;
            this.pxTextBox19.Location = new System.Drawing.Point(88, 124);
            this.pxTextBox19.Max = 999;
            this.pxTextBox19.MaxStrLength = 0;
            this.pxTextBox19.Min = 0;
            this.pxTextBox19.MinStrLength = 0;
            this.pxTextBox19.Name = "pxTextBox19";
            this.pxTextBox19.Precision = 0;
            this.pxTextBox19.Size = new System.Drawing.Size(74, 21);
            this.pxTextBox19.TabIndex = 204;
            this.pxTextBox19.ToolTipValid = this.toolTip1;
            this.pxTextBox19.ValidEable = true;
            this.pxTextBox19.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(5, 38);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 130;
            this.label34.Text = "到站时刻:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 205;
            this.label8.Text = "影响时间:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(5, 64);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 132;
            this.label33.Text = "座包时刻:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(5, 96);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 12);
            this.label31.TabIndex = 136;
            this.label31.Text = "离站时刻:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 164);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 146;
            this.label26.Text = "处理周期[\']:";
            // 
            // dtChargingStartTime
            // 
            this.dtChargingStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtChargingStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Charging_Start_Time", true));
            this.dtChargingStartTime.Enabled = false;
            this.dtChargingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtChargingStartTime.Location = new System.Drawing.Point(87, 31);
            this.dtChargingStartTime.Name = "dtChargingStartTime";
            this.dtChargingStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtChargingStartTime.TabIndex = 0;
            // 
            // dtBlowStartTime
            // 
            this.dtBlowStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBlowStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Blow_Start_Time", true));
            this.dtBlowStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBlowStartTime.Location = new System.Drawing.Point(87, 59);
            this.dtBlowStartTime.Name = "dtBlowStartTime";
            this.dtBlowStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtBlowStartTime.TabIndex = 1;
            // 
            // txtSmeltPeriod
            // 
            this.txtSmeltPeriod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Smelt_Period", true));
            this.txtSmeltPeriod.EnableNull = false;
            this.txtSmeltPeriod.ErropPr = this.errorProvider1;
            this.txtSmeltPeriod.Length = 0;
            this.txtSmeltPeriod.Location = new System.Drawing.Point(87, 161);
            this.txtSmeltPeriod.Max = 999;
            this.txtSmeltPeriod.MaxStrLength = 0;
            this.txtSmeltPeriod.Min = 0;
            this.txtSmeltPeriod.MinStrLength = 0;
            this.txtSmeltPeriod.Name = "txtSmeltPeriod";
            this.txtSmeltPeriod.Precision = 0;
            this.txtSmeltPeriod.Size = new System.Drawing.Size(75, 21);
            this.txtSmeltPeriod.TabIndex = 10;
            this.txtSmeltPeriod.ToolTipValid = this.toolTip1;
            this.txtSmeltPeriod.ValidEable = true;
            this.txtSmeltPeriod.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label66);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.pxTextBox12);
            this.groupBox4.Controls.Add(this.pxTextBox16);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.pxTextBox13);
            this.groupBox4.Controls.Add(this.label60);
            this.groupBox4.Controls.Add(this.label61);
            this.groupBox4.Controls.Add(this.txtTappingWeight);
            this.groupBox4.Location = new System.Drawing.Point(556, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 319);
            this.groupBox4.TabIndex = 203;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "铁包信息";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 21);
            this.textBox2.TabIndex = 211;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(62, 31);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(35, 12);
            this.label66.TabIndex = 210;
            this.label66.Text = "包号:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(0, 212);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 108);
            this.groupBox5.TabIndex = 208;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "包况确认情况";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Status", true));
            this.textBox1.Location = new System.Drawing.Point(13, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 54);
            this.textBox1.TabIndex = 0;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(62, 60);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 12);
            this.label39.TabIndex = 206;
            this.label39.Text = "包龄:";
            // 
            // pxTextBox12
            // 
            this.pxTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Line_Temp", true));
            this.pxTextBox12.EnableNull = false;
            this.pxTextBox12.ErropPr = this.errorProvider1;
            this.pxTextBox12.Length = 0;
            this.pxTextBox12.Location = new System.Drawing.Point(102, 119);
            this.pxTextBox12.Max = 9999;
            this.pxTextBox12.MaxStrLength = 0;
            this.pxTextBox12.Min = 0;
            this.pxTextBox12.MinStrLength = 0;
            this.pxTextBox12.Name = "pxTextBox12";
            this.pxTextBox12.Precision = 0;
            this.pxTextBox12.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox12.TabIndex = 198;
            this.pxTextBox12.ToolTipValid = this.toolTip1;
            this.pxTextBox12.ValidEable = true;
            this.pxTextBox12.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // pxTextBox16
            // 
            this.pxTextBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LadleAge", true));
            this.pxTextBox16.EnableNull = false;
            this.pxTextBox16.ErropPr = this.errorProvider1;
            this.pxTextBox16.Length = 0;
            this.pxTextBox16.Location = new System.Drawing.Point(102, 58);
            this.pxTextBox16.Max = 9999;
            this.pxTextBox16.MaxStrLength = 0;
            this.pxTextBox16.Min = 0;
            this.pxTextBox16.MinStrLength = 0;
            this.pxTextBox16.Name = "pxTextBox16";
            this.pxTextBox16.Precision = 0;
            this.pxTextBox16.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox16.TabIndex = 205;
            this.pxTextBox16.ToolTipValid = this.toolTip1;
            this.pxTextBox16.ValidEable = true;
            this.pxTextBox16.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(19, 93);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(83, 12);
            this.label43.TabIndex = 174;
            this.label43.Text = "包壁最高温度:";
            // 
            // pxTextBox13
            // 
            this.pxTextBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Bottom_Temp", true));
            this.pxTextBox13.EnableNull = false;
            this.pxTextBox13.ErropPr = this.errorProvider1;
            this.pxTextBox13.Length = 0;
            this.pxTextBox13.Location = new System.Drawing.Point(102, 153);
            this.pxTextBox13.Max = 9999;
            this.pxTextBox13.MaxStrLength = 0;
            this.pxTextBox13.Min = 0;
            this.pxTextBox13.MinStrLength = 0;
            this.pxTextBox13.Name = "pxTextBox13";
            this.pxTextBox13.Precision = 0;
            this.pxTextBox13.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox13.TabIndex = 200;
            this.pxTextBox13.ToolTipValid = this.toolTip1;
            this.pxTextBox13.ValidEable = true;
            this.pxTextBox13.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(19, 125);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(83, 12);
            this.label60.TabIndex = 199;
            this.label60.Text = "渣线最高温度:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(19, 159);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(83, 12);
            this.label61.TabIndex = 201;
            this.label61.Text = "包底最高温度:";
            // 
            // txtTappingWeight
            // 
            this.txtTappingWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Bi_Temp", true));
            this.txtTappingWeight.EnableNull = false;
            this.txtTappingWeight.ErropPr = this.errorProvider1;
            this.txtTappingWeight.Length = 0;
            this.txtTappingWeight.Location = new System.Drawing.Point(102, 87);
            this.txtTappingWeight.Max = 9999;
            this.txtTappingWeight.MaxStrLength = 0;
            this.txtTappingWeight.Min = 0;
            this.txtTappingWeight.MinStrLength = 0;
            this.txtTappingWeight.Name = "txtTappingWeight";
            this.txtTappingWeight.Precision = 0;
            this.txtTappingWeight.Size = new System.Drawing.Size(64, 21);
            this.txtTappingWeight.TabIndex = 15;
            this.txtTappingWeight.ToolTipValid = this.toolTip1;
            this.txtTappingWeight.ValidEable = true;
            this.txtTappingWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtFurnaceAge);
            this.groupBox2.Controls.Add(this.pxTextBox15);
            this.groupBox2.Controls.Add(this.pxTextBox14);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(747, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 261);
            this.groupBox2.TabIndex = 202;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "氧枪";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 207);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 12);
            this.label17.TabIndex = 204;
            this.label17.Text = "耙头使用寿命:";
            // 
            // txtFurnaceAge
            // 
            this.txtFurnaceAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Furnace_Age", true));
            this.txtFurnaceAge.EnableNull = false;
            this.txtFurnaceAge.ErropPr = this.errorProvider1;
            this.txtFurnaceAge.Length = 0;
            this.txtFurnaceAge.Location = new System.Drawing.Point(106, 27);
            this.txtFurnaceAge.Max = 99999;
            this.txtFurnaceAge.MaxStrLength = 0;
            this.txtFurnaceAge.Min = 0;
            this.txtFurnaceAge.MinStrLength = 0;
            this.txtFurnaceAge.Name = "txtFurnaceAge";
            this.txtFurnaceAge.Precision = 0;
            this.txtFurnaceAge.Size = new System.Drawing.Size(62, 21);
            this.txtFurnaceAge.TabIndex = 13;
            this.txtFurnaceAge.ToolTipValid = this.toolTip1;
            this.txtFurnaceAge.ValidEable = true;
            this.txtFurnaceAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // pxTextBox15
            // 
            this.pxTextBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Slag_Head", true));
            this.pxTextBox15.EnableNull = false;
            this.pxTextBox15.ErropPr = this.errorProvider1;
            this.pxTextBox15.Length = 0;
            this.pxTextBox15.Location = new System.Drawing.Point(106, 204);
            this.pxTextBox15.Max = 9000;
            this.pxTextBox15.MaxStrLength = 0;
            this.pxTextBox15.Min = 0;
            this.pxTextBox15.MinStrLength = 0;
            this.pxTextBox15.Name = "pxTextBox15";
            this.pxTextBox15.Precision = 0;
            this.pxTextBox15.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox15.TabIndex = 203;
            this.pxTextBox15.ToolTipValid = this.toolTip1;
            this.pxTextBox15.ValidEable = true;
            this.pxTextBox15.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // pxTextBox14
            // 
            this.pxTextBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Furnace_Surface", true));
            this.pxTextBox14.EnableNull = false;
            this.pxTextBox14.ErropPr = this.errorProvider1;
            this.pxTextBox14.Length = 0;
            this.pxTextBox14.Location = new System.Drawing.Point(106, 60);
            this.pxTextBox14.Max = 9999;
            this.pxTextBox14.MaxStrLength = 0;
            this.pxTextBox14.Min = 0;
            this.pxTextBox14.MinStrLength = 0;
            this.pxTextBox14.Name = "pxTextBox14";
            this.pxTextBox14.Precision = 0;
            this.pxTextBox14.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox14.TabIndex = 173;
            this.pxTextBox14.ToolTipValid = this.toolTip1;
            this.pxTextBox14.ValidEable = true;
            this.pxTextBox14.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(66, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 152;
            this.label23.Text = "枪龄:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 174;
            this.label15.Text = "铁水液面:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.txtLanceAge);
            this.groupBox3.Controls.Add(this.txtTapholeLife);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Location = new System.Drawing.Point(0, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 87);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "喷枪";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(66, 57);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 150;
            this.label24.Text = "枪龄:";
            // 
            // txtLanceAge
            // 
            this.txtLanceAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Lance_Age", true));
            this.txtLanceAge.EnableNull = false;
            this.txtLanceAge.ErropPr = this.errorProvider1;
            this.txtLanceAge.Length = 0;
            this.txtLanceAge.Location = new System.Drawing.Point(106, 55);
            this.txtLanceAge.Max = 9999;
            this.txtLanceAge.MaxStrLength = 0;
            this.txtLanceAge.Min = 0;
            this.txtLanceAge.MinStrLength = 0;
            this.txtLanceAge.Name = "txtLanceAge";
            this.txtLanceAge.Precision = 0;
            this.txtLanceAge.Size = new System.Drawing.Size(62, 21);
            this.txtLanceAge.TabIndex = 12;
            this.txtLanceAge.ToolTipValid = this.toolTip1;
            this.txtLanceAge.ValidEable = true;
            this.txtLanceAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtTapholeLife
            // 
            this.txtTapholeLife.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LanceNo", true));
            this.txtTapholeLife.EnableNull = false;
            this.txtTapholeLife.ErropPr = this.errorProvider1;
            this.txtTapholeLife.Length = 0;
            this.txtTapholeLife.Location = new System.Drawing.Point(106, 23);
            this.txtTapholeLife.Max = 999;
            this.txtTapholeLife.MaxStrLength = 0;
            this.txtTapholeLife.Min = 0;
            this.txtTapholeLife.MinStrLength = 0;
            this.txtTapholeLife.Name = "txtTapholeLife";
            this.txtTapholeLife.Precision = 0;
            this.txtTapholeLife.Size = new System.Drawing.Size(62, 21);
            this.txtTapholeLife.TabIndex = 9;
            this.txtTapholeLife.ToolTipValid = this.toolTip1;
            this.txtTapholeLife.ValidEable = true;
            this.txtTapholeLife.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(65, 26);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 172;
            this.label44.Text = "枪号:";
            // 
            // fLPProcess
            // 
            this.fLPProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPProcess.Controls.Add(this.btnProcessCancel);
            this.fLPProcess.Controls.Add(this.btnProcessConfirm);
            this.fLPProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPProcess.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPProcess.Location = new System.Drawing.Point(3, 470);
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
            this.tabAlloy.Size = new System.Drawing.Size(965, 508);
            this.tabAlloy.TabIndex = 12;
            this.tabAlloy.Text = "加料数据";
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
            this.hmiRootPanel4.Size = new System.Drawing.Size(957, 467);
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
            this.cmbBatchID.Location = new System.Drawing.Point(139, 50);
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
            this.Type,
            this.calendarColumn1,
            this.Batch_ID_Pre,
            this.Name1,
            this.EnableFlag});
            this.dvAlloy.DataSource = this.bsAlloy;
            this.dvAlloy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAlloy.Location = new System.Drawing.Point(0, 25);
            this.dvAlloy.Name = "dvAlloy";
            this.dvAlloy.RowTemplate.Height = 23;
            this.dvAlloy.Size = new System.Drawing.Size(953, 438);
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
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.DataSource = this.dsAdditionType;
            this.Type.DisplayMember = "L3DataTable.Code_Des";
            this.Type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Type.HeaderText = "加料性质";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.ValueMember = "L3DataTable.Code_Val_Long";
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
            this.dsAdditionType.SourceCondition = "CODE_GROUP = \'DEP_Addition_Type\' and code is not null order by code";
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
            this.coldsAdditionTypeL3DataTableCode,
            this.coldsAdditionTypeL3DataTableCode_Des,
            this.coldsAdditionTypeL3DataTableCode_Val_Long});
            this.schemadsAdditionType.TableName = "L3DataTable";
            // 
            // coldsAdditionTypeL3DataTableCode
            // 
            this.coldsAdditionTypeL3DataTableCode.Caption = "Code";
            this.coldsAdditionTypeL3DataTableCode.ColumnName = "Code";
            this.coldsAdditionTypeL3DataTableCode.Namespace = "";
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
            this.coldsAdditionTypeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsAdditionTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "Discharge_Time";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.calendarColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.calendarColumn1.HeaderText = "加料时刻";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.Width = 120;
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
            this.dsMat.SourceCondition = "1=2";
            this.dsMat.SourceMethod = "";
            this.dsMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMat.SourceURI = "XGMESLogic\\DePMag\\CDEP_Addition_Data";
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
            this.coldsMatL3DataTableBatch_ID});
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
            this.coldsMatL3DataTableType.DataType = typeof(int);
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
            this.fLPAlloy.Location = new System.Drawing.Point(3, 470);
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
            this.tabSumAddition.Size = new System.Drawing.Size(965, 508);
            this.tabSumAddition.TabIndex = 13;
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
            this.dataGridViewTextBoxColumn9});
            this.dataGridView3.DataSource = this.bsSumAddition;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(959, 502);
            this.dataGridView3.TabIndex = 1;
            // 
            // eLEMENTDataGridViewTextBoxColumn
            // 
            this.eLEMENTDataGridViewTextBoxColumn.DataPropertyName = "ELEMENT";
            this.eLEMENTDataGridViewTextBoxColumn.DataSource = this.dsCode;
            this.eLEMENTDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.eLEMENTDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.eLEMENTDataGridViewTextBoxColumn.HeaderText = "合金";
            this.eLEMENTDataGridViewTextBoxColumn.Name = "eLEMENTDataGridViewTextBoxColumn";
            this.eLEMENTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eLEMENTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eLEMENTDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // wEIGHTDataGridViewTextBoxColumn
            // 
            this.wEIGHTDataGridViewTextBoxColumn.DataPropertyName = "WEIGHT";
            this.wEIGHTDataGridViewTextBoxColumn.HeaderText = "重量";
            this.wEIGHTDataGridViewTextBoxColumn.Name = "wEIGHTDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TYPE";
            this.dataGridViewTextBoxColumn9.DataSource = this.dsAdditionType;
            this.dataGridViewTextBoxColumn9.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn9.HeaderText = "加料性质";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "L3DataTable.Code";
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
            this.tabChemical.Size = new System.Drawing.Size(965, 508);
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
            this.dvChemical.Size = new System.Drawing.Size(957, 442);
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
            dataGridViewCellStyle2.Format = "G";
            this.arriveDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arriveDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            dataGridViewCellStyle3.Format = "G";
            this.reportDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Format = "G";
            this.logTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.fLPChemical.Location = new System.Drawing.Point(3, 470);
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
            // tabStatus
            // 
            this.tabStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatus.Controls.Add(this.dvStatus);
            this.tabStatus.Controls.Add(this.bnStatus);
            this.tabStatus.Controls.Add(this.fLPStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 21);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(965, 508);
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
            this.dvStatus.Size = new System.Drawing.Size(957, 442);
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
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsDEPStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsDEPStatus
            // 
            this.dsDEPStatus.AutoLoad = true;
            this.dsDEPStatus.AutoSubscribe = false;
            this.dsDEPStatus.DataSetName = "L3DataSet";
            this.dsDEPStatus.DeleteMethod = null;
            this.dsDEPStatus.InsertMethod = null;
            this.dsDEPStatus.L3DataAdapter = this.Adapter;
            this.dsDEPStatus.LoadEvent = "Click";
            this.dsDEPStatus.LoadTrigger = null;
            this.dsDEPStatus.RefreshValve = 1000;
            this.dsDEPStatus.SourceCommand = null;
            this.dsDEPStatus.SourceCondition = "CODE_GROUP = \'DEPUnitStatus\'";
            this.dsDEPStatus.SourceMethod = "";
            this.dsDEPStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDEPStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDEPStatus.SubscribeTarget = null;
            this.dsDEPStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDEPStatus});
            this.dsDEPStatus.UpdateEvent = "Click";
            this.dsDEPStatus.UpdateMethod = null;
            this.dsDEPStatus.UpdateTrigger = null;
            // 
            // schemadsDEPStatus
            // 
            this.schemadsDEPStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDEPStatusL3DataTableCode,
            this.coldsDEPStatusL3DataTableCode_Des,
            this.coldsDEPStatusL3DataTableCode_Group,
            this.coldsDEPStatusL3DataTableCode_Group_Des,
            this.coldsDEPStatusL3DataTableCode_Val_Str,
            this.coldsDEPStatusL3DataTableCode_Val_Long,
            this.coldsDEPStatusL3DataTableCode_Val_Double,
            this.coldsDEPStatusL3DataTableCode_Function_Group,
            this.coldsDEPStatusL3DataTableNC_Code});
            this.schemadsDEPStatus.TableName = "L3DataTable";
            // 
            // coldsDEPStatusL3DataTableCode
            // 
            this.coldsDEPStatusL3DataTableCode.Caption = "Code";
            this.coldsDEPStatusL3DataTableCode.ColumnName = "Code";
            this.coldsDEPStatusL3DataTableCode.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableCode_Des
            // 
            this.coldsDEPStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsDEPStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsDEPStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableCode_Group
            // 
            this.coldsDEPStatusL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsDEPStatusL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsDEPStatusL3DataTableCode_Group.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableCode_Group_Des
            // 
            this.coldsDEPStatusL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsDEPStatusL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsDEPStatusL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableCode_Val_Str
            // 
            this.coldsDEPStatusL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsDEPStatusL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsDEPStatusL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableCode_Val_Long
            // 
            this.coldsDEPStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsDEPStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsDEPStatusL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsDEPStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableCode_Val_Double
            // 
            this.coldsDEPStatusL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsDEPStatusL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsDEPStatusL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsDEPStatusL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableCode_Function_Group
            // 
            this.coldsDEPStatusL3DataTableCode_Function_Group.Caption = "Code_Function_Group";
            this.coldsDEPStatusL3DataTableCode_Function_Group.ColumnName = "Code_Function_Group";
            this.coldsDEPStatusL3DataTableCode_Function_Group.Namespace = "";
            // 
            // coldsDEPStatusL3DataTableNC_Code
            // 
            this.coldsDEPStatusL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsDEPStatusL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsDEPStatusL3DataTableNC_Code.Namespace = "";
            // 
            // changeTimeDataGridViewTextBoxColumn
            // 
            this.changeTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeTimeDataGridViewTextBoxColumn.DataPropertyName = "Change_Time";
            dataGridViewCellStyle5.Format = "G";
            dataGridViewCellStyle5.NullValue = null;
            this.changeTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\DePMag\\CDEP_Process_Status";
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
            this.fLPStatus.Location = new System.Drawing.Point(3, 470);
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
            this.tabTemp.Size = new System.Drawing.Size(965, 508);
            this.tabTemp.TabIndex = 9;
            this.tabTemp.Text = "测温/定氧";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel6
            // 
            this.hmiRootPanel6.BackColor = System.Drawing.SystemColors.Control;
            this.hmiRootPanel6.Controls.Add(this.groupBox1);
            this.hmiRootPanel6.Controls.Add(this.fLPTemp);
            this.hmiRootPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel6.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel6.Name = "hmiRootPanel6";
            this.hmiRootPanel6.Size = new System.Drawing.Size(965, 508);
            this.hmiRootPanel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvTemp);
            this.groupBox1.Controls.Add(this.bnTemp);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(504, 159);
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
            this.dvTemp.Size = new System.Drawing.Size(504, 120);
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
            dataGridViewCellStyle6.Format = "G";
            this.tempTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.tempTimeDataGridViewTextBoxColumn.HeaderText = "测温时刻";
            this.tempTimeDataGridViewTextBoxColumn.Name = "tempTimeDataGridViewTextBoxColumn";
            this.tempTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tempTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.modeDataGridViewTextBoxColumn.HeaderText = "测温模式";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.dsTemp.SourceCondition = "1=2";
            this.dsTemp.SourceMethod = "";
            this.dsTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTemp.SourceURI = "XGMESLogic\\DePMag\\CDEP_Temp_Data";
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
            this.bnTemp.Size = new System.Drawing.Size(504, 25);
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
            this.fLPTemp.Location = new System.Drawing.Point(0, 475);
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
            // tabRemark
            // 
            this.tabRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRemark.Controls.Add(this.hmiRootPanel3);
            this.tabRemark.Location = new System.Drawing.Point(4, 21);
            this.tabRemark.Name = "tabRemark";
            this.tabRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemark.Size = new System.Drawing.Size(965, 508);
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
            this.hmiRootPanel3.Size = new System.Drawing.Size(957, 500);
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
            this.dvRemark.Size = new System.Drawing.Size(957, 442);
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
            dataGridViewCellStyle7.Format = "G";
            this.logTimeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.dsRemark.SourceURI = "XGMESLogic\\DePMag\\CDEP_HeatRemark";
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
            this.fLPRemark.Location = new System.Drawing.Point(0, 467);
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
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(653, 257);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(83, 12);
            this.label49.TabIndex = 223;
            this.label49.Text = "包底最高温度:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(653, 221);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(83, 12);
            this.label51.TabIndex = 222;
            this.label51.Text = "渣线最高温度:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox1.Location = new System.Drawing.Point(742, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 20);
            this.comboBox1.TabIndex = 227;
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Bottom_Temp", true));
            this.pxTextBox4.EnableNull = false;
            this.pxTextBox4.ErropPr = this.errorProvider1;
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(742, 250);
            this.pxTextBox4.Max = 2000;
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0;
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            this.pxTextBox4.ReadOnly = true;
            this.pxTextBox4.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox4.TabIndex = 226;
            this.pxTextBox4.ToolTipValid = this.toolTip1;
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Dreg_Line_Temp", true));
            this.pxTextBox3.EnableNull = false;
            this.pxTextBox3.ErropPr = this.errorProvider1;
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(742, 214);
            this.pxTextBox3.Max = 2000;
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0;
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            this.pxTextBox3.ReadOnly = true;
            this.pxTextBox3.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox3.TabIndex = 225;
            this.pxTextBox3.ToolTipValid = this.toolTip1;
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox5
            // 
            this.pxTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Lance_No", true));
            this.pxTextBox5.EnableNull = false;
            this.pxTextBox5.ErropPr = this.errorProvider1;
            this.pxTextBox5.Length = 0;
            this.pxTextBox5.Location = new System.Drawing.Point(543, 109);
            this.pxTextBox5.Max = 999;
            this.pxTextBox5.MaxStrLength = 0;
            this.pxTextBox5.Min = 0;
            this.pxTextBox5.MinStrLength = 0;
            this.pxTextBox5.Name = "pxTextBox5";
            this.pxTextBox5.Precision = 0;
            this.pxTextBox5.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox5.TabIndex = 221;
            this.pxTextBox5.ToolTipValid = this.toolTip1;
            this.pxTextBox5.ValidEable = true;
            this.pxTextBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(475, 110);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(59, 12);
            this.label46.TabIndex = 224;
            this.label46.Text = "氧枪枪号:";
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Spray_Lance_Age", true));
            this.pxTextBox1.EnableNull = false;
            this.pxTextBox1.ErropPr = this.errorProvider1;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(543, 217);
            this.pxTextBox1.Max = 99;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.ReadOnly = true;
            this.pxTextBox1.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox1.TabIndex = 203;
            this.pxTextBox1.ToolTipValid = this.toolTip1;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(476, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 220;
            this.label20.Text = "喷枪枪龄:";
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Wall_Temp", true));
            this.pxTextBox2.EnableNull = false;
            this.pxTextBox2.ErropPr = this.errorProvider1;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(742, 178);
            this.pxTextBox2.Max = 999;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            this.pxTextBox2.ReadOnly = true;
            this.pxTextBox2.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox2.TabIndex = 198;
            this.pxTextBox2.ToolTipValid = this.toolTip1;
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(653, 185);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 12);
            this.label25.TabIndex = 219;
            this.label25.Text = "包壁最高温度:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(701, 150);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 12);
            this.label29.TabIndex = 218;
            this.label29.Text = "包况:";
            // 
            // pxTextBox6
            // 
            this.pxTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LadleNo", true));
            this.pxTextBox6.EnableNull = false;
            this.pxTextBox6.ErropPr = this.errorProvider1;
            this.pxTextBox6.Length = 0;
            this.pxTextBox6.Location = new System.Drawing.Point(742, 71);
            this.pxTextBox6.Max = 0;
            this.pxTextBox6.MaxStrLength = 0;
            this.pxTextBox6.Min = 0;
            this.pxTextBox6.MinStrLength = 0;
            this.pxTextBox6.Name = "pxTextBox6";
            this.pxTextBox6.Precision = 0;
            this.pxTextBox6.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox6.TabIndex = 202;
            this.pxTextBox6.ToolTipValid = this.toolTip1;
            this.pxTextBox6.ValidEable = true;
            this.pxTextBox6.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(689, 73);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 12);
            this.label30.TabIndex = 217;
            this.label30.Text = "铁包号:";
            // 
            // txtSingleLaC
            // 
            this.txtSingleLaC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Spray_Lance_No", true));
            this.txtSingleLaC.EnableNull = false;
            this.txtSingleLaC.ErropPr = this.errorProvider1;
            this.txtSingleLaC.Length = 0;
            this.txtSingleLaC.Location = new System.Drawing.Point(543, 181);
            this.txtSingleLaC.Max = 999;
            this.txtSingleLaC.MaxStrLength = 0;
            this.txtSingleLaC.Min = 0;
            this.txtSingleLaC.MinStrLength = 0;
            this.txtSingleLaC.Name = "txtSingleLaC";
            this.txtSingleLaC.Precision = 0;
            this.txtSingleLaC.ReadOnly = true;
            this.txtSingleLaC.Size = new System.Drawing.Size(62, 21);
            this.txtSingleLaC.TabIndex = 207;
            this.txtSingleLaC.ToolTipValid = this.toolTip1;
            this.txtSingleLaC.ValidEable = true;
            this.txtSingleLaC.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(475, 184);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 216;
            this.label35.Text = "喷枪枪号:";
            // 
            // pxTextBox7
            // 
            this.pxTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Dep_Temp", true));
            this.pxTextBox7.EnableNull = false;
            this.pxTextBox7.ErropPr = this.errorProvider1;
            this.pxTextBox7.Length = 0;
            this.pxTextBox7.Location = new System.Drawing.Point(373, 104);
            this.pxTextBox7.Max = 2000;
            this.pxTextBox7.MaxStrLength = 0;
            this.pxTextBox7.Min = 0;
            this.pxTextBox7.MinStrLength = 0;
            this.pxTextBox7.Name = "pxTextBox7";
            this.pxTextBox7.Precision = 0;
            this.pxTextBox7.ReadOnly = true;
            this.pxTextBox7.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox7.TabIndex = 206;
            this.pxTextBox7.ToolTipValid = this.toolTip1;
            this.pxTextBox7.ValidEable = true;
            this.pxTextBox7.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(272, 110);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(95, 12);
            this.label38.TabIndex = 215;
            this.label38.Text = "脱磷后温度[℃]:";
            // 
            // pxTextBox8
            // 
            this.pxTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Desi_Temp", true));
            this.pxTextBox8.EnableNull = false;
            this.pxTextBox8.ErropPr = this.errorProvider1;
            this.pxTextBox8.Length = 0;
            this.pxTextBox8.Location = new System.Drawing.Point(373, 76);
            this.pxTextBox8.Max = 2000;
            this.pxTextBox8.MaxStrLength = 0;
            this.pxTextBox8.Min = 0;
            this.pxTextBox8.MinStrLength = 0;
            this.pxTextBox8.Name = "pxTextBox8";
            this.pxTextBox8.Precision = 0;
            this.pxTextBox8.ReadOnly = true;
            this.pxTextBox8.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox8.TabIndex = 205;
            this.pxTextBox8.ToolTipValid = this.toolTip1;
            this.pxTextBox8.ValidEable = true;
            this.pxTextBox8.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(272, 82);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(95, 12);
            this.label41.TabIndex = 214;
            this.label41.Text = "脱硅后温度[℃]:";
            // 
            // txtReBlowCount
            // 
            this.txtReBlowCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Iron_Level", true));
            this.txtReBlowCount.EnableNull = false;
            this.txtReBlowCount.ErropPr = this.errorProvider1;
            this.txtReBlowCount.Length = 0;
            this.txtReBlowCount.Location = new System.Drawing.Point(543, 145);
            this.txtReBlowCount.Max = 99;
            this.txtReBlowCount.MaxStrLength = 0;
            this.txtReBlowCount.Min = 0;
            this.txtReBlowCount.MinStrLength = 0;
            this.txtReBlowCount.Name = "txtReBlowCount";
            this.txtReBlowCount.Precision = 0;
            this.txtReBlowCount.ReadOnly = true;
            this.txtReBlowCount.Size = new System.Drawing.Size(62, 21);
            this.txtReBlowCount.TabIndex = 204;
            this.txtReBlowCount.ToolTipValid = this.toolTip1;
            this.txtReBlowCount.ValidEable = true;
            this.txtReBlowCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(475, 148);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(59, 12);
            this.label42.TabIndex = 213;
            this.label42.Text = "铁水液位:";
            // 
            // pxTextBox9
            // 
            this.pxTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Age", true));
            this.pxTextBox9.EnableNull = false;
            this.pxTextBox9.ErropPr = this.errorProvider1;
            this.pxTextBox9.Length = 0;
            this.pxTextBox9.Location = new System.Drawing.Point(742, 107);
            this.pxTextBox9.Max = 99999;
            this.pxTextBox9.MaxStrLength = 0;
            this.pxTextBox9.Min = 0;
            this.pxTextBox9.MinStrLength = 0;
            this.pxTextBox9.Name = "pxTextBox9";
            this.pxTextBox9.Precision = 0;
            this.pxTextBox9.ReadOnly = true;
            this.pxTextBox9.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox9.TabIndex = 201;
            this.pxTextBox9.ToolTipValid = this.toolTip1;
            this.pxTextBox9.ValidEable = true;
            this.pxTextBox9.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(701, 115);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 212;
            this.label45.Text = "包龄:";
            // 
            // pxTextBox10
            // 
            this.pxTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Lance_Age", true));
            this.pxTextBox10.EnableNull = false;
            this.pxTextBox10.ErropPr = this.errorProvider1;
            this.pxTextBox10.Length = 0;
            this.pxTextBox10.Location = new System.Drawing.Point(543, 73);
            this.pxTextBox10.Max = 999;
            this.pxTextBox10.MaxStrLength = 0;
            this.pxTextBox10.Min = 0;
            this.pxTextBox10.MinStrLength = 0;
            this.pxTextBox10.Name = "pxTextBox10";
            this.pxTextBox10.Precision = 0;
            this.pxTextBox10.ReadOnly = true;
            this.pxTextBox10.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox10.TabIndex = 200;
            this.pxTextBox10.ToolTipValid = this.toolTip1;
            this.pxTextBox10.ValidEable = true;
            this.pxTextBox10.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(476, 76);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(59, 12);
            this.label47.TabIndex = 211;
            this.label47.Text = "氧枪枪龄:";
            // 
            // pxTextBox11
            // 
            this.pxTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "TotalTime", true));
            this.pxTextBox11.EnableNull = false;
            this.pxTextBox11.ErropPr = this.errorProvider1;
            this.pxTextBox11.Length = 0;
            this.pxTextBox11.Location = new System.Drawing.Point(373, 191);
            this.pxTextBox11.Max = 999;
            this.pxTextBox11.MaxStrLength = 0;
            this.pxTextBox11.Min = 0;
            this.pxTextBox11.MinStrLength = 0;
            this.pxTextBox11.Name = "pxTextBox11";
            this.pxTextBox11.Precision = 0;
            this.pxTextBox11.ReadOnly = true;
            this.pxTextBox11.Size = new System.Drawing.Size(64, 21);
            this.pxTextBox11.TabIndex = 199;
            this.pxTextBox11.ToolTipValid = this.toolTip1;
            this.pxTextBox11.ValidEable = true;
            this.pxTextBox11.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(290, 197);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(77, 12);
            this.label48.TabIndex = 210;
            this.label48.Text = "处理周期[\']:";
            // 
            // txtReBlowTime
            // 
            this.txtReBlowTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "RemovePBlowTimeTotal", true));
            this.txtReBlowTime.EnableNull = false;
            this.txtReBlowTime.ErropPr = this.errorProvider1;
            this.txtReBlowTime.Length = 0;
            this.txtReBlowTime.Location = new System.Drawing.Point(372, 163);
            this.txtReBlowTime.Max = 999;
            this.txtReBlowTime.MaxStrLength = 0;
            this.txtReBlowTime.Min = 0;
            this.txtReBlowTime.MinStrLength = 0;
            this.txtReBlowTime.Name = "txtReBlowTime";
            this.txtReBlowTime.Precision = 0;
            this.txtReBlowTime.ReadOnly = true;
            this.txtReBlowTime.Size = new System.Drawing.Size(65, 21);
            this.txtReBlowTime.TabIndex = 197;
            this.txtReBlowTime.ToolTipValid = this.toolTip1;
            this.txtReBlowTime.ValidEable = true;
            this.txtReBlowTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(260, 170);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(107, 12);
            this.label50.TabIndex = 209;
            this.label50.Text = "脱磷喷吹时间[″]:";
            // 
            // txtBlowO2Time
            // 
            this.txtBlowO2Time.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "RemoveSiBlowTimeTotal", true));
            this.txtBlowO2Time.EnableNull = false;
            this.txtBlowO2Time.ErropPr = this.errorProvider1;
            this.txtBlowO2Time.Length = 0;
            this.txtBlowO2Time.Location = new System.Drawing.Point(372, 136);
            this.txtBlowO2Time.Max = 999;
            this.txtBlowO2Time.MaxStrLength = 0;
            this.txtBlowO2Time.Min = 0;
            this.txtBlowO2Time.MinStrLength = 0;
            this.txtBlowO2Time.Name = "txtBlowO2Time";
            this.txtBlowO2Time.Precision = 0;
            this.txtBlowO2Time.ReadOnly = true;
            this.txtBlowO2Time.Size = new System.Drawing.Size(65, 21);
            this.txtBlowO2Time.TabIndex = 196;
            this.txtBlowO2Time.ToolTipValid = this.toolTip1;
            this.txtBlowO2Time.ValidEable = true;
            this.txtBlowO2Time.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(260, 142);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(107, 12);
            this.label52.TabIndex = 208;
            this.label52.Text = "脱硅喷吹时间[″]:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(27, 223);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(59, 12);
            this.label53.TabIndex = 180;
            this.label53.Text = "离站时刻:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Dep_End_Time", true));
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(92, 190);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker2.TabIndex = 178;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(92, 218);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker3.TabIndex = 177;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(3, 194);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 12);
            this.label54.TabIndex = 179;
            this.label54.Text = "脱磷结束时刻:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Dep_Start_Time", true));
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(92, 162);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker4.TabIndex = 3;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Desi_End_Time", true));
            this.dateTimePicker6.Enabled = false;
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(92, 134);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker6.TabIndex = 2;
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker7.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Desi_Start_Time", true));
            this.dateTimePicker7.Enabled = false;
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker7.Location = new System.Drawing.Point(92, 106);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker7.TabIndex = 1;
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker8.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Charging_Start_Time", true));
            this.dateTimePicker8.Enabled = false;
            this.dateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker8.Location = new System.Drawing.Point(92, 78);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker8.TabIndex = 0;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(3, 166);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(83, 12);
            this.label56.TabIndex = 136;
            this.label56.Text = "脱磷开始时刻:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(3, 138);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(83, 12);
            this.label57.TabIndex = 134;
            this.label57.Text = "脱硅结束时刻:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(3, 110);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(83, 12);
            this.label58.TabIndex = 132;
            this.label58.Text = "脱硅开始时刻:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(27, 82);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(59, 12);
            this.label59.TabIndex = 130;
            this.label59.Text = "装料时刻:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 348);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(957, 33);
            this.flowLayoutPanel1.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(875, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel2.Controls.Add(this.comboBox2);
            this.hmiRootPanel2.Controls.Add(this.dataGridView1);
            this.hmiRootPanel2.Controls.Add(this.bindingNavigator1);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(957, 345);
            this.hmiRootPanel2.TabIndex = 90;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.dsMat_Alloy_Add_Man;
            this.comboBox2.DisplayMember = "L3DataTable.Code_Des";
            this.comboBox2.DropDownHeight = 200;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownWidth = 200;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(141, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 20);
            this.comboBox2.TabIndex = 95;
            this.comboBox2.ValueMember = "L3DataTable.Code";
            this.comboBox2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.bsAlloy;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(953, 316);
            this.dataGridView1.TabIndex = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Element";
            this.dataGridViewComboBoxColumn1.DataSource = this.bsAlloyCode;
            this.dataGridViewComboBoxColumn1.DisplayMember = "Code_Des";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "合金代码";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "Code";
            this.dataGridViewComboBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "合金量[Kg]";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discharge_Time";
            dataGridViewCellStyle8.Format = "G";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "加料时刻";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Type";
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "加料性质";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Batch_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "批次号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "人工录入标志";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EnableFlag";
            this.dataGridViewTextBoxColumn8.HeaderText = "EnableFlag";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsAlloy;
            this.bindingNavigator1.CountItem = this.toolStripLabel3;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator9,
            this.toolStripButton13,
            this.toolStripButton14,
            this.toolStripButton15});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton9;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton12;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton11;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton10;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator1.Size = new System.Drawing.Size(953, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "/ {0}";
            this.toolStripLabel3.ToolTipText = "总项数";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到第一条记录";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "移到上一条记录";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "位置";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "当前位置";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "移到下一条记录";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "移到最后一条记录";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "删除";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "toolStripButton25";
            this.toolStripButton15.ToolTipText = "刷新";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 348);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(957, 33);
            this.flowLayoutPanel2.TabIndex = 89;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(875, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 87;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // coldsSumAdditionL3DataTableTYPE
            // 
            this.coldsSumAdditionL3DataTableTYPE.Caption = "TYPE";
            this.coldsSumAdditionL3DataTableTYPE.ColumnName = "TYPE";
            this.coldsSumAdditionL3DataTableTYPE.DataType = typeof(short);
            this.coldsSumAdditionL3DataTableTYPE.Namespace = "";
            // 
            // DEPHeatInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 562);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.panel3);
            this.Name = "DEPHeatInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "脱磷炉次数据";
            this.Load += new System.EventHandler(this.BOFHeatInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).EndInit();
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDEPStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDEPStatus)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).EndInit();
            this.bnTemp.ResumeLayout(false);
            this.bnTemp.PerformLayout();
            this.fLPTemp.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFUnitStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFUnitStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.hmiRootPanel2.ResumeLayout(false);
            this.hmiRootPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxTextBox txtHeatID;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMat;
        private AppSvrHMI.L3DataSet dsProcess;
        private AppSvrHMI.L3DataSet dsChemical;
        private AppSvrHMI.L3DataSet dsStatus;
        private AppSvrHMI.L3DataSet dsTemp;
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
        private System.Data.DataColumn coldsMatL3DataTableGUID;
        private System.Data.DataColumn coldsMatL3DataTableName;
        private System.Data.DataColumn coldsChemicalL3DataTableGUID;
        private System.Data.DataColumn coldsChemicalL3DataTableName;
        private System.Data.DataColumn coldsStatusL3DataTableGUID;
        private System.Data.DataColumn coldsStatusL3DataTableName;
        private System.Data.DataColumn coldsTempL3DataTableGUID;
        private System.Data.DataColumn coldsTempL3DataTableName;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingSource bsProcess;
        private System.Windows.Forms.BindingSource bsChemical;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.BindingSource bsTemp;
        private System.Data.DataColumn coldsMatL3DataTableBatch_ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsDataLogMode;
        private System.Data.DataTable schemadsDataLogMode;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsRemark;
        private System.Data.DataTable schemadsRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableGUID;
        private System.Data.DataColumn coldsRemarkL3DataTableName;
        private System.Data.DataColumn coldsRemarkL3DataTableHeatID;
        private System.Data.DataColumn coldsRemarkL3DataTableTypeID;
        private System.Data.DataColumn coldsRemarkL3DataTableRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableLog_Time;
        private System.Windows.Forms.BindingSource bsRemark;
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
        private System.Windows.Forms.BindingSource bsAlloy;
        private System.Data.DataColumn coldsCodeL3DataTableCODE_GROUP;
        private System.Windows.Forms.BindingSource bsAlloyCode;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Grade;
        private System.Data.DataColumn coldsProcessL3DataTableScrapStatus;
        private AppSvrHMI.L3CommandParameter l3cmdpHeatID;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitType;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitID;
        private AppSvrHMI.L3CommandParameter l3cmdprsData;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Data.DataColumn AcoldsMatL3DataTableBatch_ID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsMat_Alloy_Add_Man;
        private System.Data.DataTable schemadsMat_Alloy_Add_Man;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableBatch_ID;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableCode;
        private System.Data.DataColumn coldsMat_Alloy_Add_ManL3DataTableCode_Des;
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
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Data.DataColumn coldsProcessL3DataTableReturn_Start_Time;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Stop;
        private System.Data.DataColumn coldsProcessL3DataTableLanceNo;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox comboBox1;
        private PxDataValid.PxTextBox pxTextBox4;
        private PxDataValid.PxTextBox pxTextBox3;
        private PxDataValid.PxTextBox pxTextBox5;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label20;
        private PxDataValid.PxTextBox pxTextBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label29;
        private PxDataValid.PxTextBox pxTextBox6;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxTextBox txtSingleLaC;
        private System.Windows.Forms.Label label35;
        private PxDataValid.PxTextBox pxTextBox7;
        private System.Windows.Forms.Label label38;
        private PxDataValid.PxTextBox pxTextBox8;
        private System.Windows.Forms.Label label41;
        private PxDataValid.PxTextBox txtReBlowCount;
        private System.Windows.Forms.Label label42;
        private PxDataValid.PxTextBox pxTextBox9;
        private System.Windows.Forms.Label label45;
        private PxDataValid.PxTextBox pxTextBox10;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxTextBox pxTextBox11;
        private System.Windows.Forms.Label label48;
        private PxDataValid.PxTextBox txtReBlowTime;
        private System.Windows.Forms.Label label50;
        private PxDataValid.PxTextBox txtBlowO2Time;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Data.DataColumn coldsMatL3DataTableArea;
        private System.Data.DataColumn coldsBaseL3DataTableIronLadle;
        private System.Data.DataColumn coldsBaseL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsMainMatL3DataTableWeight;
        private System.Data.DataColumn coldsMainMatL3DataTableDepart_Weight;
        private System.Data.DataColumn coldsMainMatL3DataTableSn;
        private System.Data.DataColumn coldsMainMatL3DataTableSb;
        private System.Data.DataColumn coldsMainMatL3DataTableAs;
        private System.Data.DataColumn coldsMainMatL3DataTablePb;
        private System.Data.DataColumn coldsMainMatL3DataTableNi;
        private System.Data.DataColumn coldsMainMatL3DataTableMo;
        private System.Data.DataColumn coldsMainMatL3DataTableCu;
        private System.Data.DataColumn coldsMainMatL3DataTableB;
        private System.Data.DataColumn coldsMainMatL3DataTableV;
        private System.Data.DataColumn coldsMainMatL3DataTableAl;
        private System.Data.DataColumn coldsMainMatL3DataTableNb;
        private System.Data.DataColumn coldsMainMatL3DataTableZn;
        private System.Data.DataColumn coldsMainMatL3DataTableW;
        private System.Data.DataColumn coldsMainMatL3DataTableLogTime;
        private System.Data.DataColumn coldsMainMatL3DataTableReturn_SteelGrade;
        private AppSvrHMI.L3DataSet dsMainMat;
        private System.Data.DataTable schemadsMainMat;
        private System.Data.DataColumn coldsMainMatL3DataTableGUID;
        private System.Data.DataColumn coldsMainMatL3DataTableName;
        private System.Data.DataColumn coldsMainMatL3DataTableHeatID;
        private System.Data.DataColumn AcoldsMainMatL3DataTableWeight;
        private System.Data.DataColumn AcoldsMainMatL3DataTableDepart_Weight;
        private System.Data.DataColumn coldsMainMatL3DataTableC;
        private System.Data.DataColumn coldsMainMatL3DataTableSi;
        private System.Data.DataColumn coldsMainMatL3DataTableMn;
        private System.Data.DataColumn coldsMainMatL3DataTableP;
        private System.Data.DataColumn coldsMainMatL3DataTableS;
        private System.Data.DataColumn coldsMainMatL3DataTableTi;
        private System.Data.DataColumn AcoldsMainMatL3DataTableSn;
        private System.Data.DataColumn AcoldsMainMatL3DataTableSb;
        private System.Data.DataColumn AcoldsMainMatL3DataTableAs;
        private System.Data.DataColumn AcoldsMainMatL3DataTablePb;
        private System.Data.DataColumn AcoldsMainMatL3DataTableNi;
        private System.Data.DataColumn AcoldsMainMatL3DataTableMo;
        private System.Data.DataColumn AcoldsMainMatL3DataTableCu;
        private System.Data.DataColumn coldsMainMatL3DataTableCr;
        private System.Data.DataColumn AcoldsMainMatL3DataTableB;
        private System.Data.DataColumn AcoldsMainMatL3DataTableV;
        private System.Data.DataColumn AcoldsMainMatL3DataTableAl;
        private System.Data.DataColumn AcoldsMainMatL3DataTableNb;
        private System.Data.DataColumn AcoldsMainMatL3DataTableZn;
        private System.Data.DataColumn AcoldsMainMatL3DataTableW;
        private System.Data.DataColumn coldsMainMatL3DataTableIronTemp;
        private System.Data.DataColumn AcoldsMainMatL3DataTableLogTime;
        private System.Data.DataColumn AcoldsMainMatL3DataTableReturn_SteelGrade;
        private System.Windows.Forms.BindingSource bsMainMat;
        private PxDataValid.PxTextBox txtIronLadle;
        private System.Windows.Forms.Label label16;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabBase;
        private PxDataValid.PxComboBox cmbShift;
        private PxDataValid.PxComboBox cmbTeam;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label10;
        private PxDataValid.PxTextBox tbxSecondHand;
        private PxDataValid.PxTextBox tbxAssistant;
        private PxDataValid.PxTextBox tbxHeadFurnace;
        private PxDataValid.PxTextBox tbxSteelGradeIndex;
        private PxDataValid.PxTextBox tbxPreHeatID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel fLPBase;
        private System.Windows.Forms.Button btnBaseCancel;
        private System.Windows.Forms.Button btnBaseConfirm;
        private System.Windows.Forms.TabPage tabMainMat;
        private PxDataValid.PxTextBox tbxCr;
        private PxDataValid.PxTextBox tbxIronTemp;
        private PxDataValid.PxTextBox tbxTi;
        private PxDataValid.PxTextBox tbxS;
        private PxDataValid.PxTextBox tbxP;
        private PxDataValid.PxTextBox tbxMn;
        private PxDataValid.PxTextBox tbxSi;
        private PxDataValid.PxTextBox tbxC;
        private PxDataValid.PxTextBox tbxIronWeight;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel fLPMainMat;
        private System.Windows.Forms.Button btnMainMatCancel;
        private System.Windows.Forms.Button btnMainMatConfirm;
        private System.Windows.Forms.TabPage tabProcess;
        private PxDataValid.PxTextBox pxTextBox13;
        private PxDataValid.PxTextBox pxTextBox12;
        private PxDataValid.PxTextBox txtTappingWeight;
        private PxDataValid.PxTextBox txtTapholeLife;
        private PxDataValid.PxTextBox txtTappingTemp;
        private PxDataValid.PxTextBox txtLaCTemp;
        private PxDataValid.PxTextBox txtFurnaceAge;
        private PxDataValid.PxTextBox txtLanceAge;
        private PxDataValid.PxTextBox txtSmeltPeriod;
        private PxDataValid.PxTextBox txtSplashingTime;
        private PxDataValid.PxTextBox txtTappingTime;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DateTimePicker dtTappingEndTime;
        private System.Windows.Forms.DateTimePicker dtBlowStartTime;
        private System.Windows.Forms.DateTimePicker dtChargingStartTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.FlowLayoutPanel fLPProcess;
        private System.Windows.Forms.Button btnProcessCancel;
        private System.Windows.Forms.Button btnProcessConfirm;
        private System.Windows.Forms.TabPage tabAlloy;
        private HMIBase.HMIRootPanel hmiRootPanel4;
        private System.Windows.Forms.ComboBox cmbBatchID;
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
        private System.Windows.Forms.ToolStripButton btnDelAlloy;
        private System.Windows.Forms.ToolStripButton btnRefAlloy;
        private System.Windows.Forms.FlowLayoutPanel fLPAlloy;
        private System.Windows.Forms.Button btnAlloyCancel;
        private System.Windows.Forms.Button btnAlloyCanfirm;
        private System.Windows.Forms.TabPage tabChemical;
        private System.Windows.Forms.DataGridView dvChemical;
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
        private System.Windows.Forms.ToolStripButton btnDelChemical;
        private System.Windows.Forms.ToolStripButton btnRefEle;
        private System.Windows.Forms.FlowLayoutPanel fLPChemical;
        private System.Windows.Forms.Button btnChemicalCancel;
        private System.Windows.Forms.Button btnChemicalConfirm;
        private System.Windows.Forms.TabPage tabStatus;
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
        private System.Windows.Forms.ToolStripButton btnDelStatus;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.FlowLayoutPanel fLPStatus;
        private System.Windows.Forms.Button btnStatusCancel;
        private System.Windows.Forms.Button btnStatusConfirm;
        private System.Windows.Forms.TabPage tabTemp;
        private HMIBase.HMIRootPanel hmiRootPanel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name4;
        private System.Windows.Forms.BindingNavigator bnTemp;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
        private System.Windows.Forms.ToolStripButton btnAddTemp;
        private System.Windows.Forms.ToolStripButton btnDelTemp;
        private System.Windows.Forms.FlowLayoutPanel fLPTemp;
        private System.Windows.Forms.Button btnTempCancel;
        private System.Windows.Forms.Button btnTempConfirm;
        private System.Windows.Forms.TabPage tabRemark;
        private HMIBase.HMIRootPanel hmiRootPanel3;
        private System.Windows.Forms.DataGridView dvRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeIDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.ToolStripButton btnRemarkDel;
        private System.Windows.Forms.FlowLayoutPanel fLPRemark;
        private System.Windows.Forms.Button btnRemarkCancel;
        private System.Windows.Forms.Button btnRemarkConfirm;
        private System.Windows.Forms.TabPage tabSumAddition;
        private System.Windows.Forms.DataGridView dataGridView3;
        private AppSvrHMI.L3DataSet dsSumAddition;
        private System.Data.DataTable schemadsSumAddition;
        private System.Data.DataColumn coldsSumAdditionL3DataTableWEIGHT;
        private System.Data.DataColumn coldsSumAdditionL3DataTableELEMENT;
        private System.Windows.Forms.BindingSource bsSumAddition;
        private AppSvrHMI.L3DataSet dsDEPStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Data.DataTable schemadsDEPStatus;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode_Group;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsDEPStatusL3DataTableCode_Function_Group;
        private System.Data.DataColumn coldsDEPStatusL3DataTableNC_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTimeDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsProcessL3DataTableIronLadle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dvcmbAlloyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private AppSvrHMI.L3DataSet dsAdditionType;
        private System.Data.DataTable schemadsAdditionType;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID_Pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnableFlag;
        private System.Data.DataColumn coldsSumAdditionL3DataTableTYPE;
        private System.Data.DataColumn AcoldsSumAdditionL3DataTableTYPE;
        private System.Windows.Forms.DataGridViewComboBoxColumn eLEMENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wEIGHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBox2;
        private PxDataValid.PxTextBox pxTextBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private PxDataValid.PxTextBox pxTextBox15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label39;
        private PxDataValid.PxTextBox pxTextBox16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox1;
        private PxDataValid.PxTextBox pxTextBox18;
        private System.Windows.Forms.Label label62;
        private PxDataValid.PxTextBox pxTextBox19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private PxDataValid.PxTextBox pxTextBox20;
        private System.Windows.Forms.Label label32;
        private PxDataValid.PxTextBox pxTextBox22;
        private System.Windows.Forms.Label label64;
        private PxDataValid.PxTextBox pxTextBox21;
        private System.Windows.Forms.Label label63;
        private PxDataValid.PxTextBox pxTextBox23;
        private System.Windows.Forms.Label label65;
        private System.Data.DataColumn coldsProcessL3DataTableFurnace_Surface;
        private System.Data.DataColumn coldsProcessL3DataTableSlag_Head;
        private System.Data.DataColumn coldsProcessL3DataTableLadleAge;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Bi_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Line_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Bottom_Temp;
        private PxDataValid.PxTextBox pxTextBox17;
        private System.Windows.Forms.Label label40;
        private System.Data.DataColumn AcoldsBaseL3DataTableIronLadle;
        private System.Data.DataColumn AcoldsBaseL3DataTableNC_Confirm_Flag;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox textBox2;
        private PxDataValid.PxTextBox txtIronLadle1;
    }
}