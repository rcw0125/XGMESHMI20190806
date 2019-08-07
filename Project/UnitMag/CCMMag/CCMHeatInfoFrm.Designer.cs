namespace UnitMag.CCMMag
{
    partial class CCMHeatInfoFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCMHeatInfoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panl = new System.Windows.Forms.Panel();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.tbxTreatNo = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxHeatID = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cmbFourth = new System.Windows.Forms.ComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCastingNo = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatConfirm = new System.Data.DataColumn();
            this.coldsBaseL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePlan_SteelGrade = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeadFurnace = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLadle_Operator = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCut_Operator = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLocked = new System.Data.DataColumn();
            this.coldsBaseL3DataTableShift = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTeam = new System.Data.DataColumn();
            this.coldsBaseL3DataTableControl_Operator = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTundish_1ST_Officer = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTundish_2ST_Officer = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTundish_3ST_Officer = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTundish_4ST_Officer = new System.Data.DataColumn();
            this.coldsBaseL3DataTableThickness = new System.Data.DataColumn();
            this.coldsBaseL3DataTableWidth = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLength = new System.Data.DataColumn();
            this.bsTundishOfficer4 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDuty = new AppSvrHMI.L3DataSet();
            this.schemadsDuty = new System.Data.DataTable();
            this.coldsDutyL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDutyL3DataTableName = new System.Data.DataColumn();
            this.coldsDutyL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsDutyL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsDutyL3DataTableStation = new System.Data.DataColumn();
            this.coldsDutyL3DataTableOperator_name = new System.Data.DataColumn();
            this.cmbThirdth = new System.Windows.Forms.ComboBox();
            this.bsTundishOfficer3 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSecond = new System.Windows.Forms.ComboBox();
            this.bsTundishOfficer2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbFirst = new System.Windows.Forms.ComboBox();
            this.bsTundishOfficer1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAssistant = new System.Windows.Forms.ComboBox();
            this.bsAssistant = new System.Windows.Forms.BindingSource(this.components);
            this.cmbControlOperator = new System.Windows.Forms.ComboBox();
            this.bsControlOperator = new System.Windows.Forms.BindingSource(this.components);
            this.cmbHeadFurnace = new System.Windows.Forms.ComboBox();
            this.bsHeadFurnace = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnBaseOK = new System.Windows.Forms.Button();
            this.btnPaocessOK = new System.Windows.Forms.Button();
            this.btnConfirmExcept = new System.Windows.Forms.Button();
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
            this.btnAddExcept = new System.Windows.Forms.ToolStripButton();
            this.btnDelExcept = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator31 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.txtExcept = new System.Windows.Forms.ToolStripTextBox();
            this.btnAddHeatCover = new System.Windows.Forms.ToolStripButton();
            this.btnDelHeatCover = new System.Windows.Forms.ToolStripButton();
            this.btnCoverOK = new System.Windows.Forms.Button();
            this.btnAddLadle = new System.Windows.Forms.ToolStripButton();
            this.btnAddProtectMat = new System.Windows.Forms.ToolStripButton();
            this.btnDelProtectMat = new System.Windows.Forms.ToolStripButton();
            this.btnProtectMatOK = new System.Windows.Forms.Button();
            this.btnProtectSlagOK = new System.Windows.Forms.Button();
            this.btnAddProtectSlag = new System.Windows.Forms.ToolStripButton();
            this.btnDelProtectSlag = new System.Windows.Forms.ToolStripButton();
            this.btnHoldTempMatConfirm = new System.Windows.Forms.Button();
            this.btnAddHoldTempMat = new System.Windows.Forms.ToolStripButton();
            this.btnDelHoldTempMat = new System.Windows.Forms.ToolStripButton();
            this.btnRemarkOK = new System.Windows.Forms.Button();
            this.btnAddRemark = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSmoothBlockAdd = new System.Windows.Forms.ToolStripButton();
            this.btnSmoothBlockDel = new System.Windows.Forms.ToolStripButton();
            this.btnHurryGapConfirm = new System.Windows.Forms.Button();
            this.btnHurryGapAdd = new System.Windows.Forms.ToolStripButton();
            this.btnHurryGapDel = new System.Windows.Forms.ToolStripButton();
            this.btnBigGapConfirm = new System.Windows.Forms.Button();
            this.btnBigGapAdd = new System.Windows.Forms.ToolStripButton();
            this.btnBigGapDel = new System.Windows.Forms.ToolStripButton();
            this.btnStrandInfoOK = new System.Windows.Forms.Button();
            this.btnAddStrandInfo = new System.Windows.Forms.ToolStripButton();
            this.btnLadleCancel = new System.Windows.Forms.Button();
            this.btnLadleOK = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tbxSecondHand = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pxTextBox33 = new PxDataValid.PxTextBox();
            this.pxTextBox17 = new PxDataValid.PxTextBox();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.pxTextBox24 = new PxDataValid.PxTextBox();
            this.pxTextBox23 = new PxDataValid.PxTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.pxTextBox22 = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pxTextBox20 = new PxDataValid.PxTextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbxCCMID = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseCancel = new System.Windows.Forms.Button();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.pxTextBox27 = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label75 = new System.Windows.Forms.Label();
            this.pxTextBox26 = new PxDataValid.PxTextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.pxTextBox25 = new PxDataValid.PxTextBox();
            this.bsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcess = new AppSvrHMI.L3DataSet();
            this.schemadsProcess = new System.Data.DataTable();
            this.coldsProcessL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableName = new System.Data.DataColumn();
            this.coldsProcessL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCastingNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTundishNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCasting_HeatNum = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTundish_HeatNum = new System.Data.DataColumn();
            this.coldsProcessL3DataTableInjectionBar_BlowAr = new System.Data.DataColumn();
            this.coldsProcessL3DataTableWeight_Return = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSecond_Cooling_Mode = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSecond_Cooling_CurveNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableWeight_Cut_Head = new System.Data.DataColumn();
            this.coldsProcessL3DataTableWeight_Cut_Trail = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTundishCar_Type = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCastingStartTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableCastingStopTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableWeight_Return_Reason = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTundish_SlagThickness = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTundish_Bottom_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTundish_Wall_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTundish_Level_Mold = new System.Data.DataColumn();
            this.coldsProcessL3DataTablePlugBar_Control = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoft_Press_Flag_1 = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoft_Press_Flag_2 = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoft_Press_Flag_3 = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoft_Press_Flag_4 = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSpeedChange = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSpeedChange_Reason = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSpeedChange_Detailed = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBefore_Casting_Tundish_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1 = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2 = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3 = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4 = new System.Data.DataColumn();
            this.label72 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.cmbChangeReason = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.cmbSecondCoolingMode = new System.Windows.Forms.ComboBox();
            this.dsSecondCoolingMode = new AppSvrHMI.L3DataSet();
            this.schemadsSecondCoolingMode = new System.Data.DataTable();
            this.coldsSecondCoolingModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsSecondCoolingModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.cmbInjectionBar_BlowAr = new System.Windows.Forms.ComboBox();
            this.dsYesNo = new AppSvrHMI.L3DataSet();
            this.schemadsYesNo = new System.Data.DataTable();
            this.coldsYesNoL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsYesNoL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cmbSoftPressFlag2 = new System.Windows.Forms.ComboBox();
            this.cmbSoftPressFlag4 = new System.Windows.Forms.ComboBox();
            this.cmbSoftPressFlag1 = new System.Windows.Forms.ComboBox();
            this.cmbSoftPressFlag3 = new System.Windows.Forms.ComboBox();
            this.cmbSpeedChange = new System.Windows.Forms.ComboBox();
            this.cmbPlugBarControl = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.dsReturn_Reason = new AppSvrHMI.L3DataSet();
            this.schemadsReturn_Reason = new System.Data.DataTable();
            this.coldsReturn_ReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsReturn_ReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label39 = new System.Windows.Forms.Label();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.txtTundishBottomTemp = new PxDataValid.PxTextBox();
            this.ptbShuikou_Temp4 = new PxDataValid.PxTextBox();
            this.ptbShuikou_Temp3 = new PxDataValid.PxTextBox();
            this.ptbShuikou_Temp2 = new PxDataValid.PxTextBox();
            this.ptbShuikou_Temp1 = new PxDataValid.PxTextBox();
            this.ptbBef_tundish_temp = new PxDataValid.PxTextBox();
            this.txtTundishLevelMold = new PxDataValid.PxTextBox();
            this.txtTundishSlagThickness = new PxDataValid.PxTextBox();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.txtTundishNo = new PxDataValid.PxTextBox();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTundishWallTemp = new PxDataValid.PxTextBox();
            this.pxTextBox36 = new PxDataValid.PxTextBox();
            this.pxTextBox34 = new PxDataValid.PxTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txtCastingNo = new PxDataValid.PxTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.pnlProcess = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcessCancel = new System.Windows.Forms.Button();
            this.tabExcept = new System.Windows.Forms.TabPage();
            this.fLPExcept = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelExcept = new System.Windows.Forms.Button();
            this.dvExcept = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsExceptCode = new AppSvrHMI.L3DataSet();
            this.schemadsExceptCode = new System.Data.DataTable();
            this.coldsExceptCodeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableName = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableExceptional_Des = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableUnit = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag = new System.Data.DataColumn();
            this.exceptionalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decideCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classifyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsExcept = new System.Windows.Forms.BindingSource(this.components);
            this.dsExcept = new AppSvrHMI.L3DataSet();
            this.schemadsExcept = new System.Data.DataTable();
            this.coldsExceptL3DataTableGUID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableName = new System.Data.DataColumn();
            this.coldsExceptL3DataTableID_Object = new System.Data.DataColumn();
            this.coldsExceptL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableProcess_Count = new System.Data.DataColumn();
            this.coldsExceptL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsExceptL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsExceptL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsExceptL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsExceptL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsExceptL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptL3DataTableDecide_Code = new System.Data.DataColumn();
            this.coldsExceptL3DataTableClassify = new System.Data.DataColumn();
            this.coldsExceptL3DataTableExceptional_Time = new System.Data.DataColumn();
            this.tabChemical = new System.Windows.Forms.TabPage();
            this.dvChemical = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.reportDateDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
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
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.logTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDataLogMode = new AppSvrHMI.L3DataSet();
            this.schemadsDataLogMode = new System.Data.DataTable();
            this.coldsDataLogModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDataLogModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsChemical = new System.Windows.Forms.BindingSource(this.components);
            this.dsChemical = new AppSvrHMI.L3DataSet();
            this.schemadsChemical = new System.Data.DataTable();
            this.coldsChemicalL3DataTableGUID = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableName = new System.Data.DataColumn();
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
            this.bnChemical = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton29 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton30 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddChemical = new System.Windows.Forms.ToolStripButton();
            this.pnlChemical = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChemicalCancel = new System.Windows.Forms.Button();
            this.btnChemicalOK = new System.Windows.Forms.Button();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.dvStatus = new System.Windows.Forms.DataGridView();
            this.cCMIDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCasterStatus = new AppSvrHMI.L3DataSet();
            this.schemadsCasterStatus = new System.Data.DataTable();
            this.coldsCasterStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCasterStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.changeTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableName = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsStatusL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableStatus = new System.Data.DataColumn();
            this.coldsStatusL3DataTableChange_Time = new System.Data.DataColumn();
            this.bnStatus = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStatus = new System.Windows.Forms.ToolStripButton();
            this.pnlStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStatusCancel = new System.Windows.Forms.Button();
            this.btnStatusOK = new System.Windows.Forms.Button();
            this.tabHeatTundishTemp = new System.Windows.Forms.TabPage();
            this.hmiRootPanel6 = new HMIBase.HMIRootPanel();
            this.dvHeatTundishTemp = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempIDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCCMTempMode = new AppSvrHMI.L3DataSet();
            this.schemadsCCMTempMode = new System.Data.DataTable();
            this.coldsCCMTempModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCCMTempModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.tempDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.bsHeatTundishTemp = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatTundishTemp = new AppSvrHMI.L3DataSet();
            this.schemadsHeatTundishTemp = new System.Data.DataTable();
            this.coldsHeatTundishTempL3DataTableGUID = new System.Data.DataColumn();
            this.coldsHeatTundishTempL3DataTableName = new System.Data.DataColumn();
            this.coldsHeatTundishTempL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHeatTundishTempL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsHeatTundishTempL3DataTableTempID = new System.Data.DataColumn();
            this.coldsHeatTundishTempL3DataTableTemp = new System.Data.DataColumn();
            this.coldsHeatTundishTempL3DataTableMeasure_Time = new System.Data.DataColumn();
            this.bnHeatTundishTemp = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddHeatTundishTemp = new System.Windows.Forms.ToolStripButton();
            this.tabHeatCover = new System.Windows.Forms.TabPage();
            this.dvHeatCover = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCoverElement = new AppSvrHMI.L3DataSet();
            this.schemadsCoverElement = new System.Data.DataTable();
            this.coldsCoverElementL3DataTableCode = new System.Data.DataColumn();
            this.coldsCoverElementL3DataTableCode_Des = new System.Data.DataColumn();
            this.Batch_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsOrigin = new AppSvrHMI.L3DataSet();
            this.schemadsOrigin = new System.Data.DataTable();
            this.coldsOriginL3DataTableMatFactory = new System.Data.DataColumn();
            this.coldsOriginL3DataTableMatName = new System.Data.DataColumn();
            this.coldsOriginL3DataTableMatGroup_Code = new System.Data.DataColumn();
            this.coldsOriginL3DataTableMatGroup_Des = new System.Data.DataColumn();
            this.useInformationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHeatCoverUse = new AppSvrHMI.L3DataSet();
            this.schemadsHeatCoverUse = new System.Data.DataTable();
            this.coldsHeatCoverUseL3DataTableCode = new System.Data.DataColumn();
            this.coldsHeatCoverUseL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsHeatCover = new System.Windows.Forms.BindingSource(this.components);
            this.dsHeatCover = new AppSvrHMI.L3DataSet();
            this.schemadsHeatCover = new System.Data.DataTable();
            this.coldsHeatCoverL3DataTableGUID = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableName = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableElement = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableAmount = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableOrigin = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableUseInformation = new System.Data.DataColumn();
            this.coldsHeatCoverL3DataTableBatch_ID = new System.Data.DataColumn();
            this.bnHeatCover = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlHeatCover = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCoverCancel = new System.Windows.Forms.Button();
            this.tabLadle = new System.Windows.Forms.TabPage();
            this.dvLadle = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatNoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ladleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastingTundishWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.ladleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castingStartTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.castingStopTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.holdTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempUpTo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCommonYesNo = new AppSvrHMI.L3DataSet();
            this.schemadsCommonYesNo = new System.Data.DataTable();
            this.coldsCommonYesNoL3DataTableCode = new System.Data.DataColumn();
            this.coldsCommonYesNoL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCommonYesNoL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.holdTimeReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHoldTimeReason = new AppSvrHMI.L3DataSet();
            this.schemadsHoldTimeReason = new System.Data.DataTable();
            this.coldsHoldTimeReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsHoldTimeReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.AutoFlow = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAutoFlow = new AppSvrHMI.L3DataSet();
            this.schemadsAutoFlow = new System.Data.DataTable();
            this.coldsAutoFlowL3DataTableCode = new System.Data.DataColumn();
            this.coldsAutoFlowL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAutoFlowL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.UnAutoFlow_Reason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnAutoFlow_Reason = new AppSvrHMI.L3DataSet();
            this.schemadsUnAutoFlow_Reason = new System.Data.DataTable();
            this.coldsUnAutoFlow_ReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.Protection = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnProtection_Reason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnProtectionReason = new AppSvrHMI.L3DataSet();
            this.schemadsUnProtectionReason = new System.Data.DataTable();
            this.coldsUnProtectionReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnProtectionReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsLadle = new System.Windows.Forms.BindingSource(this.components);
            this.dsLadle = new AppSvrHMI.L3DataSet();
            this.schemadsLadle = new System.Data.DataTable();
            this.coldsLadleL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLadleL3DataTableName = new System.Data.DataColumn();
            this.coldsLadleL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsLadleL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsLadleL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsLadleL3DataTableWeight = new System.Data.DataColumn();
            this.coldsLadleL3DataTableRemainWeight = new System.Data.DataColumn();
            this.coldsLadleL3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsLadleL3DataTableLadleType = new System.Data.DataColumn();
            this.coldsLadleL3DataTableDeparture_Time = new System.Data.DataColumn();
            this.coldsLadleL3DataTableCasting_Start_Time = new System.Data.DataColumn();
            this.coldsLadleL3DataTableCasting_Stop_Time = new System.Data.DataColumn();
            this.coldsLadleL3DataTableHoldTime = new System.Data.DataColumn();
            this.coldsLadleL3DataTableTemp = new System.Data.DataColumn();
            this.coldsLadleL3DataTableTempUpTo = new System.Data.DataColumn();
            this.coldsLadleL3DataTableHoldTime_Reason = new System.Data.DataColumn();
            this.coldsLadleL3DataTableProtection = new System.Data.DataColumn();
            this.coldsLadleL3DataTableUnProtection_Reason = new System.Data.DataColumn();
            this.coldsLadleL3DataTableAutoFlow = new System.Data.DataColumn();
            this.coldsLadleL3DataTableUnAutoFlow_Reason = new System.Data.DataColumn();
            this.coldsLadleL3DataTableCastingTundishWeight = new System.Data.DataColumn();
            this.bnLadle = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTxtReason = new System.Windows.Forms.ToolStripTextBox();
            this.tsLblReason = new System.Windows.Forms.ToolStripLabel();
            this.pnlLadle = new System.Windows.Forms.FlowLayoutPanel();
            this.tabProtectCasting = new System.Windows.Forms.TabPage();
            this.dvProtectCasting = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.stopTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.arFlowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProtectCasting = new System.Windows.Forms.BindingSource(this.components);
            this.dsProtectCasting = new AppSvrHMI.L3DataSet();
            this.schemadsProtectCasting = new System.Data.DataTable();
            this.coldsProtectCastingL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProtectCastingL3DataTableName = new System.Data.DataColumn();
            this.coldsProtectCastingL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProtectCastingL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsProtectCastingL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsProtectCastingL3DataTableStop_Time = new System.Data.DataColumn();
            this.coldsProtectCastingL3DataTableAr_Flow = new System.Data.DataColumn();
            this.bnProtectCasting = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddProtectCasting = new System.Windows.Forms.ToolStripButton();
            this.pnlProtectCasting = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProtectCastingCancel = new System.Windows.Forms.Button();
            this.btnProtectCastingOK = new System.Windows.Forms.Button();
            this.tabProtectMat = new System.Windows.Forms.TabPage();
            this.dvProtectMat = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProtectMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsProtectMat = new AppSvrHMI.L3DataSet();
            this.schemadsProtectMat = new System.Data.DataTable();
            this.coldsProtectMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProtectMatL3DataTableName = new System.Data.DataColumn();
            this.coldsProtectMatL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProtectMatL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsProtectMatL3DataTableElement = new System.Data.DataColumn();
            this.coldsProtectMatL3DataTableFactory = new System.Data.DataColumn();
            this.bnProtectMat = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlProtectMat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProtectMatCancel = new System.Windows.Forms.Button();
            this.tabProtectSlag = new System.Windows.Forms.TabPage();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.dvProtectSlag = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandIDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsProtectSlagFac = new AppSvrHMI.L3DataSet();
            this.schemadsProtectSlagFac = new System.Data.DataTable();
            this.coldsProtectSlagFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.coldsProtectSlagFacL3DataTableMatName = new System.Data.DataColumn();
            this.coldsProtectSlagFacL3DataTableMatGroup_Code = new System.Data.DataColumn();
            this.coldsProtectSlagFacL3DataTableMatGroup_Des = new System.Data.DataColumn();
            this.elementDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsProtectSlagType = new AppSvrHMI.L3DataSet();
            this.schemadsProtectSlagType = new System.Data.DataTable();
            this.coldsProtectSlagTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsProtectSlagTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.batchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseInformation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsProtectSlagUse = new AppSvrHMI.L3DataSet();
            this.schemadsProtectSlagUse = new System.Data.DataTable();
            this.coldsProtectSlagUseL3DataTableCode = new System.Data.DataColumn();
            this.coldsProtectSlagUseL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsProtectSlag = new System.Windows.Forms.BindingSource(this.components);
            this.dsProtectSlag = new AppSvrHMI.L3DataSet();
            this.schemadsProtectSlag = new System.Data.DataTable();
            this.coldsProtectSlagL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableName = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableStrandID = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableElement = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableFactory = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableBatchNo = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableUseInformation = new System.Data.DataColumn();
            this.coldsProtectSlagL3DataTableAmount = new System.Data.DataColumn();
            this.pnlProtectSlag = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProtectSlagCancel = new System.Windows.Forms.Button();
            this.bnProtectSlag = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabHoldTempMat = new System.Windows.Forms.TabPage();
            this.pnlHoldTempMat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHoldTempMatCancel = new System.Windows.Forms.Button();
            this.dvHoldTempMat = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.weightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHoldTempOrigin = new AppSvrHMI.L3DataSet();
            this.schemadsHoldTempOrigin = new System.Data.DataTable();
            this.coldsHoldTempOriginL3DataTableMatFactory = new System.Data.DataColumn();
            this.batchIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHoldTempMatUse = new AppSvrHMI.L3DataSet();
            this.schemadsHoldTempMatUse = new System.Data.DataTable();
            this.coldsHoldTempMatUseL3DataTableCode = new System.Data.DataColumn();
            this.coldsHoldTempMatUseL3DataTableCode_Des = new System.Data.DataColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHoldTempMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsHoldTempMat = new AppSvrHMI.L3DataSet();
            this.schemadsHoldTempMat = new System.Data.DataTable();
            this.coldsHoldTempMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableName = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableElement = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableWeight = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableOrigin = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsHoldTempMatL3DataTableUseInformation = new System.Data.DataColumn();
            this.bnHoldTempMat = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox9 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.tabSpeed = new System.Windows.Forms.TabPage();
            this.hmiRootPanel3 = new HMIBase.HMIRootPanel();
            this.dvSpeed = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandIDDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.bsSpeed = new System.Windows.Forms.BindingSource(this.components);
            this.dsSpeed = new AppSvrHMI.L3DataSet();
            this.schemadsSpeed = new System.Data.DataTable();
            this.coldsSpeedL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableName = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableStrandID = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableSpeed = new System.Data.DataColumn();
            this.coldsSpeedL3DataTableChange_Time = new System.Data.DataColumn();
            this.pnlSpeed = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSpeedCancel = new System.Windows.Forms.Button();
            this.btnSpeedOk = new System.Windows.Forms.Button();
            this.bnSpeed = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddSpeed = new System.Windows.Forms.ToolStripButton();
            this.tabStrandInfo = new System.Windows.Forms.TabPage();
            this.hmiRootPanel4 = new HMIBase.HMIRootPanel();
            this.dvStrandInfo = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandIDDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softPressFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsYesNo32 = new AppSvrHMI.L3DataSet();
            this.schemadsYesNo32 = new System.Data.DataTable();
            this.coldsYesNo32L3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsYesNo32L3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.autoControlDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAutoContorl = new AppSvrHMI.L3DataSet();
            this.schemadsAutoContorl = new System.Data.DataTable();
            this.coldsAutoContorlL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAutoContorlL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castNumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterGapCenterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBlock_Up = new AppSvrHMI.L3DataSet();
            this.schemadsBlock_Up = new System.Data.DataTable();
            this.coldsBlock_UpL3DataTableCode = new System.Data.DataColumn();
            this.coldsBlock_UpL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBlock_UpL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.waterGapDeepnessDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liquid_level = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Block_Up = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Block_Up_Reason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBlock_Up_Reason = new AppSvrHMI.L3DataSet();
            this.schemadsBlock_Up_Reason = new System.Data.DataTable();
            this.coldsBlock_Up_ReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsBlock_Up_ReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBlock_Up_ReasonL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.BreakOut_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoldID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copper_Fac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCopper_Fac = new AppSvrHMI.L3DataSet();
            this.schemadsCopper_Fac = new System.Data.DataTable();
            this.coldsCopper_FacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.Copper_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heat_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStrandInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsStrandInfo = new AppSvrHMI.L3DataSet();
            this.schemadsStrandInfo = new System.Data.DataTable();
            this.coldsStrandInfoL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableName = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableStrandID = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableSoft_Press_Flag = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableAuto_Control = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableStop_Time = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableCast_Num = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableWaterGap_Center = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableWaterGap_Deepness = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableCastingStatus = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableCode = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableliquid_level = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableBlock_Up = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableBlock_Up_Reason = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableBreakOut_Num = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableMoldID = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableCopper_Fac = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableCopper_ID = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableHeat_Weight = new System.Data.DataColumn();
            this.coldsStrandInfoL3DataTableTotal_Weight = new System.Data.DataColumn();
            this.pnlStrandInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStrandInfoCancel = new System.Windows.Forms.Button();
            this.bnStrandInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton33 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton34 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelStrandInfo = new System.Windows.Forms.ToolStripButton();
            this.tabRemark = new System.Windows.Forms.TabPage();
            this.hmiRootPanel5 = new HMIBase.HMIRootPanel();
            this.dvRemark = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.typeIDDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsRemarkType = new AppSvrHMI.L3DataSet();
            this.schemadsRemarkType = new System.Data.DataTable();
            this.coldsRemarkTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsRemarkTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRemark = new System.Windows.Forms.BindingSource(this.components);
            this.dsRemark = new AppSvrHMI.L3DataSet();
            this.schemadsRemark = new System.Data.DataTable();
            this.coldsRemarkL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableName = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableTypeID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableRemark = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableLog_Time = new System.Data.DataColumn();
            this.pnlRemark = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemarkCancel = new System.Windows.Forms.Button();
            this.bnRemark = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton36 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton37 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox8 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton38 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton39 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.tabRef = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSmoothBlock = new System.Windows.Forms.TabPage();
            this.hmiRootPanel10 = new HMIBase.HMIRootPanel();
            this.dvHurryS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSmoothBlockFactory = new AppSvrHMI.L3DataSet();
            this.schemadsSmoothBlockFactory = new System.Data.DataTable();
            this.coldsSmoothBlockFactoryL3DataTableMatFactory = new System.Data.DataColumn();
            this.calendarColumn1 = new DataGridValid.CalendarColumn();
            this.calendarColumn2 = new DataGridValid.CalendarColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSmoothBlockOFFReason = new AppSvrHMI.L3DataSet();
            this.schemadsSmoothBlockOFFReason = new System.Data.DataTable();
            this.coldsSmoothBlockOFFReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsSmoothBlockOFFReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsSmoothBlock = new System.Windows.Forms.BindingSource(this.components);
            this.dsSmoothBlock = new AppSvrHMI.L3DataSet();
            this.schemadsSmoothBlock = new System.Data.DataTable();
            this.coldsSmoothBlockL3DataTableGUID = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableName = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableBlockID = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableBlock_Life = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableFactory = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableEnd_Time = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableBlock_Size = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableReason = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableHeatID = new System.Data.DataColumn();
            this.fLPSmoothBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton35 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox10 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator29 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton40 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton41 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.tabHurryGap = new System.Windows.Forms.TabPage();
            this.hmiRootPanel8 = new HMIBase.HMIRootPanel();
            this.dvHurryGap = new System.Windows.Forms.DataGridView();
            this.cCMIDDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.heatIDDataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandNoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gapLifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHurryGapFactory = new AppSvrHMI.L3DataSet();
            this.schemadsHurryGapFactory = new System.Data.DataTable();
            this.coldsHurryGapFactoryL3DataTableMatFactory = new System.Data.DataColumn();
            this.startTimeDataGridViewTextBoxColumn4 = new DataGridValid.CalendarColumn();
            this.endTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.reasonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsHurryGapOFFReason = new AppSvrHMI.L3DataSet();
            this.schemadsHurryGapOFFReason = new System.Data.DataTable();
            this.coldsHurryGapOFFReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsHurryGapOFFReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsHurryGap = new System.Windows.Forms.BindingSource(this.components);
            this.dsHurryGrap = new AppSvrHMI.L3DataSet();
            this.schemadsHurryGrap = new System.Data.DataTable();
            this.coldsHurryGrapL3DataTableGUID = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableName = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableGapID = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableGapLife = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableFactory = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableEnd_Time = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableReason = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHurryGrapL3DataTableMatType = new System.Data.DataColumn();
            this.pnlHurryGap = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHurryGapCancel = new System.Windows.Forms.Button();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton46 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton47 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator34 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox12 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton48 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton49 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator36 = new System.Windows.Forms.ToolStripSeparator();
            this.tabBigGap = new System.Windows.Forms.TabPage();
            this.hmiRootPanel9 = new HMIBase.HMIRootPanel();
            this.dvBigGap = new System.Windows.Forms.DataGridView();
            this.cCMIDDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandNoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gapIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBigGapFactory = new AppSvrHMI.L3DataSet();
            this.schemadsBigGapFactory = new System.Data.DataTable();
            this.coldsBigGapFactoryL3DataTableMatFactory = new System.Data.DataColumn();
            this.matTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gapLifeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTimeDataGridViewTextBoxColumn2 = new DataGridValid.CalendarColumn();
            this.reasonDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBigGapOFFReason = new AppSvrHMI.L3DataSet();
            this.schemadsBigGapOFFReason = new System.Data.DataTable();
            this.coldsBigGapOFFReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsBigGapOFFReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsBigGap = new System.Windows.Forms.BindingSource(this.components);
            this.dsBigGap = new AppSvrHMI.L3DataSet();
            this.schemadsBigGap = new System.Data.DataTable();
            this.coldsBigGapL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableName = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableGapID = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableFactory = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableMatType = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableGapLife = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableChangeTime = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableReason = new System.Data.DataColumn();
            this.pnlBigGap = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBigGapCancel = new System.Windows.Forms.Button();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel13 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton51 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton52 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator37 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox13 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator38 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton53 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton54 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator39 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTempUpTo = new System.Windows.Forms.BindingSource(this.components);
            this.bsProtection = new System.Windows.Forms.BindingSource(this.components);
            this.dsliquid_level = new AppSvrHMI.L3DataSet();
            this.schemadsliquid_level = new System.Data.DataTable();
            this.coldsliquid_levelL3DataTableCode = new System.Data.DataColumn();
            this.coldsliquid_levelL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsliquid_levelL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.dsCuFactory = new AppSvrHMI.L3DataSet();
            this.schemadsCuFactory = new System.Data.DataTable();
            this.coldsCuFactoryL3DataTableMatFactory = new System.Data.DataColumn();
            this.coldsCuFactoryL3DataTableMatName = new System.Data.DataColumn();
            this.coldsCuFactoryL3DataTableMatGroup_Code = new System.Data.DataColumn();
            this.coldsCuFactoryL3DataTableMatGroup_Des = new System.Data.DataColumn();
            this.dsInjectionBar = new AppSvrHMI.L3DataSet();
            this.schemadsInjectionBar = new System.Data.DataTable();
            this.coldsInjectionBarL3DataTableCode = new System.Data.DataColumn();
            this.coldsInjectionBarL3DataTableCode_Des = new System.Data.DataColumn();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.coldsChemicalL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther3 = new System.Data.DataColumn();
            this.dsWaterGapCenter = new AppSvrHMI.L3DataSet();
            this.schemadsWaterGapCenter = new System.Data.DataTable();
            this.coldsWaterGapCenterL3DataTableCode = new System.Data.DataColumn();
            this.coldsWaterGapCenterL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsWaterGapCenterL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.hmiRootPanel7 = new HMIBase.HMIRootPanel();
            this.dvSmoothBlock = new System.Windows.Forms.DataGridView();
            this.cCMIDDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strandNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.blockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockLifeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.startTimeDataGridViewTextBoxColumn3 = new DataGridValid.CalendarColumn();
            this.endTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.blockSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlSmoothBlock = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSmoothBlockConfirm = new System.Windows.Forms.Button();
            this.cmdHeatExcept = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHeatID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpUnitType = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpUnitID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdprsData = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.dsReason = new AppSvrHMI.L3DataSet();
            this.schemadsReason = new System.Data.DataTable();
            this.coldsReasonL3DataTableName = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsReasonL3DataTableCode_Function_Group = new System.Data.DataColumn();
            this.coldsReasonL3DataTableNC_Code = new System.Data.DataColumn();
            this.coldsReasonL3DataTableGUID = new System.Data.DataColumn();
            this.cmdExcept = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label46 = new System.Windows.Forms.Label();
            this.pxTextBox5 = new PxDataValid.PxTextBox();
            this.pxTextBox6 = new PxDataValid.PxTextBox();
            this.pxTextBox7 = new PxDataValid.PxTextBox();
            this.pxTextBox8 = new PxDataValid.PxTextBox();
            this.pxTextBox9 = new PxDataValid.PxTextBox();
            this.pxTextBox10 = new PxDataValid.PxTextBox();
            this.pxTextBox11 = new PxDataValid.PxTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.pxTextBox12 = new PxDataValid.PxTextBox();
            this.pxTextBox13 = new PxDataValid.PxTextBox();
            this.pxTextBox14 = new PxDataValid.PxTextBox();
            this.pxTextBox15 = new PxDataValid.PxTextBox();
            this.pxTextBox16 = new PxDataValid.PxTextBox();
            this.pxTextBox18 = new PxDataValid.PxTextBox();
            this.pxTextBox19 = new PxDataValid.PxTextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.pxTextBox21 = new PxDataValid.PxTextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.coldsProcessL3DataTableSoft_Press_Change = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoft_Press_Detailed = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoft_Press_Reason = new System.Data.DataColumn();
            this.coldsLadleUseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLadleUseL3DataTableHeatID = new System.Data.DataColumn();
            this.dsLadleUse = new AppSvrHMI.L3DataSet();
            this.schemadsLadleUse = new System.Data.DataTable();
            this.AcoldsLadleUseL3DataTableGUID = new System.Data.DataColumn();
            this.AcoldsLadleUseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsLadleUseL3DataTableAuto_Flow = new System.Data.DataColumn();
            this.l3DataSet1 = new AppSvrHMI.L3DataSet();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.panl.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControlOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeadFurnace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcept)).BeginInit();
            this.bdExcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.tabProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecondCoolingMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSecondCoolingMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturn_Reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReturn_Reason)).BeginInit();
            this.pnlProcess.SuspendLayout();
            this.tabExcept.SuspendLayout();
            this.fLPExcept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).BeginInit();
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
            this.pnlChemical.SuspendLayout();
            this.tabStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).BeginInit();
            this.bnStatus.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.tabHeatTundishTemp.SuspendLayout();
            this.hmiRootPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHeatTundishTemp)).BeginInit();
            this.bnHeatTundishTemp.SuspendLayout();
            this.tabHeatCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoverElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCoverElement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatCoverUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatCoverUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHeatCover)).BeginInit();
            this.bnHeatCover.SuspendLayout();
            this.pnlHeatCover.SuspendLayout();
            this.tabLadle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommonYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCommonYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTimeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTimeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnAutoFlow_Reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnAutoFlow_Reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnProtectionReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnProtectionReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnLadle)).BeginInit();
            this.bnLadle.SuspendLayout();
            this.pnlLadle.SuspendLayout();
            this.tabProtectCasting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProtectCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtectCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectCasting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnProtectCasting)).BeginInit();
            this.bnProtectCasting.SuspendLayout();
            this.pnlProtectCasting.SuspendLayout();
            this.tabProtectMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProtectMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtectMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnProtectMat)).BeginInit();
            this.bnProtectMat.SuspendLayout();
            this.pnlProtectMat.SuspendLayout();
            this.tabProtectSlag.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProtectSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlagFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlagFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlagType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlagType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlagUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlagUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtectSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlag)).BeginInit();
            this.pnlProtectSlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnProtectSlag)).BeginInit();
            this.bnProtectSlag.SuspendLayout();
            this.tabHoldTempMat.SuspendLayout();
            this.pnlHoldTempMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHoldTempMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMatUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMatUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHoldTempMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHoldTempMat)).BeginInit();
            this.bnHoldTempMat.SuspendLayout();
            this.tabSpeed.SuspendLayout();
            this.hmiRootPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpeed)).BeginInit();
            this.pnlSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnSpeed)).BeginInit();
            this.bnSpeed.SuspendLayout();
            this.tabStrandInfo.SuspendLayout();
            this.hmiRootPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStrandInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoContorl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoContorl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlock_Up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlock_Up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlock_Up_Reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlock_Up_Reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopper_Fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopper_Fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStrandInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStrandInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStrandInfo)).BeginInit();
            this.pnlStrandInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnStrandInfo)).BeginInit();
            this.bnStrandInfo.SuspendLayout();
            this.tabRemark.SuspendLayout();
            this.hmiRootPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).BeginInit();
            this.pnlRemark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).BeginInit();
            this.bnRemark.SuspendLayout();
            this.tabRef.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSmoothBlock.SuspendLayout();
            this.hmiRootPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHurryS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlockFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlockFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlockOFFReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlockOFFReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmoothBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlock)).BeginInit();
            this.fLPSmoothBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabHurryGap.SuspendLayout();
            this.hmiRootPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHurryGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGapFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGapFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGapOFFReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGapOFFReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHurryGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGrap)).BeginInit();
            this.pnlHurryGap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            this.tabBigGap.SuspendLayout();
            this.hmiRootPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBigGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapOFFReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapOFFReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGap)).BeginInit();
            this.pnlBigGap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTempUpTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsliquid_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsliquid_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCuFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCuFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInjectionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInjectionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWaterGapCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWaterGapCenter)).BeginInit();
            this.hmiRootPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSmoothBlock)).BeginInit();
            this.pnlSmoothBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReason)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panl
            // 
            this.panl.BackColor = System.Drawing.Color.SteelBlue;
            this.panl.Controls.Add(this.txtReason);
            this.panl.Controls.Add(this.lblReason);
            this.panl.Controls.Add(this.tbxTreatNo);
            this.panl.Controls.Add(this.label8);
            this.panl.Controls.Add(this.tbxHeatID);
            this.panl.Controls.Add(this.label6);
            this.panl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl.Location = new System.Drawing.Point(0, 0);
            this.panl.Margin = new System.Windows.Forms.Padding(0);
            this.panl.Name = "panl";
            this.panl.Size = new System.Drawing.Size(981, 29);
            this.panl.TabIndex = 93;
            // 
            // txtReason
            // 
            this.txtReason.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtReason.Location = new System.Drawing.Point(805, 3);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(168, 21);
            this.txtReason.TabIndex = 78;
            this.txtReason.Visible = false;
            this.txtReason.Leave += new System.EventHandler(this.txtReason_Leave);
            // 
            // lblReason
            // 
            this.lblReason.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReason.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReason.Location = new System.Drawing.Point(696, 8);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(103, 12);
            this.lblReason.TabIndex = 77;
            this.lblReason.Text = "等压钢超时原因:";
            this.lblReason.Visible = false;
            // 
            // tbxTreatNo
            // 
            this.tbxTreatNo.DisplayPrecision = 0;
            this.tbxTreatNo.Enabled = false;
            this.tbxTreatNo.EnableNull = true;
            this.tbxTreatNo.ErropPr = null;
            this.tbxTreatNo.FixedLength = 0;
            this.tbxTreatNo.Length = 0;
            this.tbxTreatNo.Location = new System.Drawing.Point(68, 5);
            this.tbxTreatNo.Max = 0D;
            this.tbxTreatNo.MaxNull = 0D;
            this.tbxTreatNo.MaxStringLength = 0;
            this.tbxTreatNo.MaxStrLength = 0;
            this.tbxTreatNo.Min = 0D;
            this.tbxTreatNo.MinNull = 0D;
            this.tbxTreatNo.MinStringLength = 0;
            this.tbxTreatNo.MinStrLength = 0;
            this.tbxTreatNo.Name = "tbxTreatNo";
            this.tbxTreatNo.Precision = 0;
            this.tbxTreatNo.Regex = "";
            this.tbxTreatNo.Size = new System.Drawing.Size(106, 21);
            this.tbxTreatNo.TabIndex = 76;
            this.tbxTreatNo.ToolTipValid = null;
            this.tbxTreatNo.VaildWarning = "";
            this.tbxTreatNo.ValidEable = true;
            this.tbxTreatNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 75;
            this.label8.Text = "处理号:";
            // 
            // tbxHeatID
            // 
            this.tbxHeatID.DisplayPrecision = 0;
            this.tbxHeatID.Enabled = false;
            this.tbxHeatID.EnableNull = true;
            this.tbxHeatID.ErropPr = null;
            this.tbxHeatID.FixedLength = 0;
            this.tbxHeatID.Length = 0;
            this.tbxHeatID.Location = new System.Drawing.Point(241, 5);
            this.tbxHeatID.Max = 0D;
            this.tbxHeatID.MaxNull = 0D;
            this.tbxHeatID.MaxStringLength = 0;
            this.tbxHeatID.MaxStrLength = 0;
            this.tbxHeatID.Min = 0D;
            this.tbxHeatID.MinNull = 0D;
            this.tbxHeatID.MinStringLength = 0;
            this.tbxHeatID.MinStrLength = 0;
            this.tbxHeatID.Name = "tbxHeatID";
            this.tbxHeatID.Precision = 0;
            this.tbxHeatID.Regex = "";
            this.tbxHeatID.Size = new System.Drawing.Size(106, 21);
            this.tbxHeatID.TabIndex = 74;
            this.tbxHeatID.ToolTipValid = null;
            this.tbxHeatID.VaildWarning = "";
            this.tbxHeatID.ValidEable = true;
            this.tbxHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(197, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "炉号:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tabCtrlMain);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 29);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(981, 458);
            this.hmiRootPanel1.TabIndex = 94;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabBase);
            this.tabCtrlMain.Controls.Add(this.tabProcess);
            this.tabCtrlMain.Controls.Add(this.tabExcept);
            this.tabCtrlMain.Controls.Add(this.tabChemical);
            this.tabCtrlMain.Controls.Add(this.tabStatus);
            this.tabCtrlMain.Controls.Add(this.tabHeatTundishTemp);
            this.tabCtrlMain.Controls.Add(this.tabHeatCover);
            this.tabCtrlMain.Controls.Add(this.tabLadle);
            this.tabCtrlMain.Controls.Add(this.tabProtectCasting);
            this.tabCtrlMain.Controls.Add(this.tabProtectMat);
            this.tabCtrlMain.Controls.Add(this.tabProtectSlag);
            this.tabCtrlMain.Controls.Add(this.tabHoldTempMat);
            this.tabCtrlMain.Controls.Add(this.tabSpeed);
            this.tabCtrlMain.Controls.Add(this.tabStrandInfo);
            this.tabCtrlMain.Controls.Add(this.tabRemark);
            this.tabCtrlMain.Controls.Add(this.tabRef);
            this.tabCtrlMain.Controls.Add(this.tabPage1);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(981, 458);
            this.tabCtrlMain.TabIndex = 93;
            this.tabCtrlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlMain_Selected);
            // 
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.cmbFourth);
            this.tabBase.Controls.Add(this.cmbThirdth);
            this.tabBase.Controls.Add(this.cmbSecond);
            this.tabBase.Controls.Add(this.cmbFirst);
            this.tabBase.Controls.Add(this.cmbAssistant);
            this.tabBase.Controls.Add(this.cmbControlOperator);
            this.tabBase.Controls.Add(this.cmbHeadFurnace);
            this.tabBase.Controls.Add(this.comboBox2);
            this.tabBase.Controls.Add(this.cmbTeam);
            this.tabBase.Controls.Add(this.dateTimePicker6);
            this.tabBase.Controls.Add(this.label10);
            this.tabBase.Controls.Add(this.label57);
            this.tabBase.Controls.Add(this.label56);
            this.tabBase.Controls.Add(this.label59);
            this.tabBase.Controls.Add(this.label55);
            this.tabBase.Controls.Add(this.label58);
            this.tabBase.Controls.Add(this.label54);
            this.tabBase.Controls.Add(this.label47);
            this.tabBase.Controls.Add(this.tbxSecondHand);
            this.tabBase.Controls.Add(this.label9);
            this.tabBase.Controls.Add(this.label7);
            this.tabBase.Controls.Add(this.label34);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.pxTextBox33);
            this.tabBase.Controls.Add(this.pxTextBox17);
            this.tabBase.Controls.Add(this.pxTextBox2);
            this.tabBase.Controls.Add(this.pxTextBox24);
            this.tabBase.Controls.Add(this.pxTextBox23);
            this.tabBase.Controls.Add(this.label33);
            this.tabBase.Controls.Add(this.pxTextBox22);
            this.tabBase.Controls.Add(this.label19);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.pxTextBox20);
            this.tabBase.Controls.Add(this.label36);
            this.tabBase.Controls.Add(this.label35);
            this.tabBase.Controls.Add(this.label22);
            this.tabBase.Controls.Add(this.label20);
            this.tabBase.Controls.Add(this.tbxCCMID);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.pnlBase);
            this.tabBase.Location = new System.Drawing.Point(4, 22);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(973, 432);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本数据";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // cmbFourth
            // 
            this.cmbFourth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Tundish_4ST_Officer", true));
            this.cmbFourth.DataSource = this.bsTundishOfficer4;
            this.cmbFourth.DisplayMember = "Operator_name";
            this.cmbFourth.FormattingEnabled = true;
            this.cmbFourth.Location = new System.Drawing.Point(733, 142);
            this.cmbFourth.Name = "cmbFourth";
            this.cmbFourth.Size = new System.Drawing.Size(145, 20);
            this.cmbFourth.TabIndex = 108;
            this.cmbFourth.ValueMember = "Operator_name";
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
            this.dsBase.L3DataAdapter = null;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = null;
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Base_Data";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            this.dsBase.OnDataLoaded += new AppSvrHMI.Delegate_OnDataLoaded(this.dsBase_OnDataLoaded);
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableGUID,
            this.coldsBaseL3DataTableName,
            this.coldsBaseL3DataTableHeatID,
            this.coldsBaseL3DataTableCastingNo,
            this.coldsBaseL3DataTableCCMID,
            this.coldsBaseL3DataTableTreatNo,
            this.coldsBaseL3DataTableHeatConfirm,
            this.coldsBaseL3DataTableProductionDate,
            this.coldsBaseL3DataTableSteelGrade,
            this.coldsBaseL3DataTableSteelGradeIndex,
            this.coldsBaseL3DataTablePre_SteelGradeIndex,
            this.coldsBaseL3DataTablePlan_SteelGrade,
            this.coldsBaseL3DataTableHeadFurnace,
            this.coldsBaseL3DataTableLadle_Operator,
            this.coldsBaseL3DataTableCut_Operator,
            this.coldsBaseL3DataTableLocked,
            this.coldsBaseL3DataTableShift,
            this.coldsBaseL3DataTableTeam,
            this.coldsBaseL3DataTableControl_Operator,
            this.coldsBaseL3DataTableTundish_1ST_Officer,
            this.coldsBaseL3DataTableTundish_2ST_Officer,
            this.coldsBaseL3DataTableTundish_3ST_Officer,
            this.coldsBaseL3DataTableTundish_4ST_Officer,
            this.coldsBaseL3DataTableThickness,
            this.coldsBaseL3DataTableWidth,
            this.coldsBaseL3DataTableLength});
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
            // coldsBaseL3DataTableCastingNo
            // 
            this.coldsBaseL3DataTableCastingNo.Caption = "CastingNo";
            this.coldsBaseL3DataTableCastingNo.ColumnName = "CastingNo";
            this.coldsBaseL3DataTableCastingNo.Namespace = "";
            // 
            // coldsBaseL3DataTableCCMID
            // 
            this.coldsBaseL3DataTableCCMID.Caption = "CCMID";
            this.coldsBaseL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsBaseL3DataTableCCMID.Namespace = "";
            // 
            // coldsBaseL3DataTableTreatNo
            // 
            this.coldsBaseL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsBaseL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsBaseL3DataTableTreatNo.Namespace = "";
            // 
            // coldsBaseL3DataTableHeatConfirm
            // 
            this.coldsBaseL3DataTableHeatConfirm.Caption = "HeatConfirm";
            this.coldsBaseL3DataTableHeatConfirm.ColumnName = "HeatConfirm";
            this.coldsBaseL3DataTableHeatConfirm.DataType = typeof(int);
            this.coldsBaseL3DataTableHeatConfirm.Namespace = "";
            // 
            // coldsBaseL3DataTableProductionDate
            // 
            this.coldsBaseL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableProductionDate.Namespace = "";
            // 
            // coldsBaseL3DataTableSteelGrade
            // 
            this.coldsBaseL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsBaseL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsBaseL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsBaseL3DataTableSteelGradeIndex
            // 
            this.coldsBaseL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsBaseL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsBaseL3DataTablePre_SteelGradeIndex
            // 
            this.coldsBaseL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsBaseL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsBaseL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsBaseL3DataTablePlan_SteelGrade
            // 
            this.coldsBaseL3DataTablePlan_SteelGrade.Caption = "Plan_SteelGrade";
            this.coldsBaseL3DataTablePlan_SteelGrade.ColumnName = "Plan_SteelGrade";
            this.coldsBaseL3DataTablePlan_SteelGrade.Namespace = "";
            // 
            // coldsBaseL3DataTableHeadFurnace
            // 
            this.coldsBaseL3DataTableHeadFurnace.Caption = "HeadFurnace";
            this.coldsBaseL3DataTableHeadFurnace.ColumnName = "HeadFurnace";
            this.coldsBaseL3DataTableHeadFurnace.Namespace = "";
            // 
            // coldsBaseL3DataTableLadle_Operator
            // 
            this.coldsBaseL3DataTableLadle_Operator.Caption = "Ladle_Operator";
            this.coldsBaseL3DataTableLadle_Operator.ColumnName = "Ladle_Operator";
            this.coldsBaseL3DataTableLadle_Operator.Namespace = "";
            // 
            // coldsBaseL3DataTableCut_Operator
            // 
            this.coldsBaseL3DataTableCut_Operator.Caption = "Cut_Operator";
            this.coldsBaseL3DataTableCut_Operator.ColumnName = "Cut_Operator";
            this.coldsBaseL3DataTableCut_Operator.Namespace = "";
            // 
            // coldsBaseL3DataTableLocked
            // 
            this.coldsBaseL3DataTableLocked.Caption = "Locked";
            this.coldsBaseL3DataTableLocked.ColumnName = "Locked";
            this.coldsBaseL3DataTableLocked.DataType = typeof(int);
            this.coldsBaseL3DataTableLocked.Namespace = "";
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
            // coldsBaseL3DataTableControl_Operator
            // 
            this.coldsBaseL3DataTableControl_Operator.Caption = "Control_Operator";
            this.coldsBaseL3DataTableControl_Operator.ColumnName = "Control_Operator";
            this.coldsBaseL3DataTableControl_Operator.Namespace = "";
            // 
            // coldsBaseL3DataTableTundish_1ST_Officer
            // 
            this.coldsBaseL3DataTableTundish_1ST_Officer.Caption = "Tundish_1ST_Officer";
            this.coldsBaseL3DataTableTundish_1ST_Officer.ColumnName = "Tundish_1ST_Officer";
            this.coldsBaseL3DataTableTundish_1ST_Officer.Namespace = "";
            // 
            // coldsBaseL3DataTableTundish_2ST_Officer
            // 
            this.coldsBaseL3DataTableTundish_2ST_Officer.Caption = "Tundish_2ST_Officer";
            this.coldsBaseL3DataTableTundish_2ST_Officer.ColumnName = "Tundish_2ST_Officer";
            this.coldsBaseL3DataTableTundish_2ST_Officer.Namespace = "";
            // 
            // coldsBaseL3DataTableTundish_3ST_Officer
            // 
            this.coldsBaseL3DataTableTundish_3ST_Officer.Caption = "Tundish_3ST_Officer";
            this.coldsBaseL3DataTableTundish_3ST_Officer.ColumnName = "Tundish_3ST_Officer";
            this.coldsBaseL3DataTableTundish_3ST_Officer.Namespace = "";
            // 
            // coldsBaseL3DataTableTundish_4ST_Officer
            // 
            this.coldsBaseL3DataTableTundish_4ST_Officer.Caption = "Tundish_4ST_Officer";
            this.coldsBaseL3DataTableTundish_4ST_Officer.ColumnName = "Tundish_4ST_Officer";
            this.coldsBaseL3DataTableTundish_4ST_Officer.Namespace = "";
            // 
            // coldsBaseL3DataTableThickness
            // 
            this.coldsBaseL3DataTableThickness.Caption = "Thickness";
            this.coldsBaseL3DataTableThickness.ColumnName = "Thickness";
            this.coldsBaseL3DataTableThickness.DataType = typeof(int);
            this.coldsBaseL3DataTableThickness.Namespace = "";
            // 
            // coldsBaseL3DataTableWidth
            // 
            this.coldsBaseL3DataTableWidth.Caption = "Width";
            this.coldsBaseL3DataTableWidth.ColumnName = "Width";
            this.coldsBaseL3DataTableWidth.DataType = typeof(int);
            this.coldsBaseL3DataTableWidth.Namespace = "";
            // 
            // coldsBaseL3DataTableLength
            // 
            this.coldsBaseL3DataTableLength.Caption = "Length";
            this.coldsBaseL3DataTableLength.ColumnName = "Length";
            this.coldsBaseL3DataTableLength.DataType = typeof(int);
            this.coldsBaseL3DataTableLength.Namespace = "";
            // 
            // bsTundishOfficer4
            // 
            this.bsTundishOfficer4.DataMember = "L3DataTable";
            this.bsTundishOfficer4.DataSource = this.dsDuty;
            this.bsTundishOfficer4.Filter = "STATION=\'中间罐浇钢\'";
            // 
            // dsDuty
            // 
            this.dsDuty.AutoLoad = true;
            this.dsDuty.AutoSubscribe = false;
            this.dsDuty.DataSetName = "L3DataSet";
            this.dsDuty.DeleteMethod = "";
            this.dsDuty.InsertMethod = "";
            this.dsDuty.L3DataAdapter = null;
            this.dsDuty.LoadEvent = "";
            this.dsDuty.LoadTrigger = null;
            this.dsDuty.RefreshValve = 1000;
            this.dsDuty.SourceCommand = null;
            this.dsDuty.SourceCondition = "1=2";
            this.dsDuty.SourceMethod = "";
            this.dsDuty.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDuty.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Duty";
            this.dsDuty.SubscribeTarget = null;
            this.dsDuty.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDuty});
            this.dsDuty.UpdateEvent = "";
            this.dsDuty.UpdateMethod = "";
            this.dsDuty.UpdateTrigger = null;
            // 
            // schemadsDuty
            // 
            this.schemadsDuty.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDutyL3DataTableGUID,
            this.coldsDutyL3DataTableName,
            this.coldsDutyL3DataTableCCMID,
            this.coldsDutyL3DataTableTeamID,
            this.coldsDutyL3DataTableStation,
            this.coldsDutyL3DataTableOperator_name});
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
            // coldsDutyL3DataTableCCMID
            // 
            this.coldsDutyL3DataTableCCMID.Caption = "CCMID";
            this.coldsDutyL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsDutyL3DataTableCCMID.Namespace = "";
            // 
            // coldsDutyL3DataTableTeamID
            // 
            this.coldsDutyL3DataTableTeamID.Caption = "TeamID";
            this.coldsDutyL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsDutyL3DataTableTeamID.Namespace = "";
            // 
            // coldsDutyL3DataTableStation
            // 
            this.coldsDutyL3DataTableStation.Caption = "Station";
            this.coldsDutyL3DataTableStation.ColumnName = "Station";
            this.coldsDutyL3DataTableStation.Namespace = "";
            // 
            // coldsDutyL3DataTableOperator_name
            // 
            this.coldsDutyL3DataTableOperator_name.Caption = "Operator_name";
            this.coldsDutyL3DataTableOperator_name.ColumnName = "Operator_name";
            this.coldsDutyL3DataTableOperator_name.Namespace = "";
            // 
            // cmbThirdth
            // 
            this.cmbThirdth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Tundish_3ST_Officer", true));
            this.cmbThirdth.DataSource = this.bsTundishOfficer3;
            this.cmbThirdth.DisplayMember = "Operator_name";
            this.cmbThirdth.FormattingEnabled = true;
            this.cmbThirdth.Location = new System.Drawing.Point(733, 114);
            this.cmbThirdth.Name = "cmbThirdth";
            this.cmbThirdth.Size = new System.Drawing.Size(145, 20);
            this.cmbThirdth.TabIndex = 108;
            this.cmbThirdth.ValueMember = "Operator_name";
            // 
            // bsTundishOfficer3
            // 
            this.bsTundishOfficer3.DataMember = "L3DataTable";
            this.bsTundishOfficer3.DataSource = this.dsDuty;
            this.bsTundishOfficer3.Filter = "STATION=\'中间罐浇钢\'";
            // 
            // cmbSecond
            // 
            this.cmbSecond.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Tundish_2ST_Officer", true));
            this.cmbSecond.DataSource = this.bsTundishOfficer2;
            this.cmbSecond.DisplayMember = "Operator_name";
            this.cmbSecond.FormattingEnabled = true;
            this.cmbSecond.Location = new System.Drawing.Point(733, 84);
            this.cmbSecond.Name = "cmbSecond";
            this.cmbSecond.Size = new System.Drawing.Size(145, 20);
            this.cmbSecond.TabIndex = 108;
            this.cmbSecond.ValueMember = "Operator_name";
            // 
            // bsTundishOfficer2
            // 
            this.bsTundishOfficer2.DataMember = "L3DataTable";
            this.bsTundishOfficer2.DataSource = this.dsDuty;
            this.bsTundishOfficer2.Filter = "STATION=\'中间罐浇钢\'";
            // 
            // cmbFirst
            // 
            this.cmbFirst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Tundish_1ST_Officer", true));
            this.cmbFirst.DataSource = this.bsTundishOfficer1;
            this.cmbFirst.DisplayMember = "Operator_name";
            this.cmbFirst.FormattingEnabled = true;
            this.cmbFirst.Location = new System.Drawing.Point(733, 55);
            this.cmbFirst.Name = "cmbFirst";
            this.cmbFirst.Size = new System.Drawing.Size(145, 20);
            this.cmbFirst.TabIndex = 108;
            this.cmbFirst.ValueMember = "Operator_name";
            // 
            // bsTundishOfficer1
            // 
            this.bsTundishOfficer1.DataMember = "L3DataTable";
            this.bsTundishOfficer1.DataSource = this.dsDuty;
            this.bsTundishOfficer1.Filter = "STATION=\'中间罐浇钢\'";
            // 
            // cmbAssistant
            // 
            this.cmbAssistant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Ladle_Operator", true));
            this.cmbAssistant.DataSource = this.bsAssistant;
            this.cmbAssistant.DisplayMember = "Operator_name";
            this.cmbAssistant.FormattingEnabled = true;
            this.cmbAssistant.Location = new System.Drawing.Point(535, 110);
            this.cmbAssistant.Name = "cmbAssistant";
            this.cmbAssistant.Size = new System.Drawing.Size(145, 20);
            this.cmbAssistant.TabIndex = 108;
            this.cmbAssistant.ValueMember = "Operator_name";
            // 
            // bsAssistant
            // 
            this.bsAssistant.DataMember = "L3DataTable";
            this.bsAssistant.DataSource = this.dsDuty;
            this.bsAssistant.Filter = "STATION = \'大罐浇钢\'";
            // 
            // cmbControlOperator
            // 
            this.cmbControlOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Control_Operator", true));
            this.cmbControlOperator.DataSource = this.bsControlOperator;
            this.cmbControlOperator.DisplayMember = "Operator_name";
            this.cmbControlOperator.FormattingEnabled = true;
            this.cmbControlOperator.Location = new System.Drawing.Point(535, 81);
            this.cmbControlOperator.Name = "cmbControlOperator";
            this.cmbControlOperator.Size = new System.Drawing.Size(145, 20);
            this.cmbControlOperator.TabIndex = 108;
            this.cmbControlOperator.ValueMember = "Operator_name";
            // 
            // bsControlOperator
            // 
            this.bsControlOperator.DataMember = "L3DataTable";
            this.bsControlOperator.DataSource = this.dsDuty;
            this.bsControlOperator.Filter = "STATION = \'主控室操作\'";
            // 
            // cmbHeadFurnace
            // 
            this.cmbHeadFurnace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "HeadFurnace", true));
            this.cmbHeadFurnace.DataSource = this.bsHeadFurnace;
            this.cmbHeadFurnace.DisplayMember = "Operator_name";
            this.cmbHeadFurnace.FormattingEnabled = true;
            this.cmbHeadFurnace.Location = new System.Drawing.Point(535, 54);
            this.cmbHeadFurnace.Name = "cmbHeadFurnace";
            this.cmbHeadFurnace.Size = new System.Drawing.Size(145, 20);
            this.cmbHeadFurnace.TabIndex = 107;
            this.cmbHeadFurnace.ValueMember = "Operator_name";
            // 
            // bsHeadFurnace
            // 
            this.bsHeadFurnace.DataMember = "L3DataTable";
            this.bsHeadFurnace.DataSource = this.dsDuty;
            this.bsHeadFurnace.Filter = "STATION = \'机长\'";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Shift", true));
            this.comboBox2.DataSource = this.dsShift;
            this.comboBox2.DisplayMember = "L3DataTable.Code_Des";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(321, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(125, 20);
            this.comboBox2.TabIndex = 106;
            this.comboBox2.ValueMember = "L3DataTable.Code";
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
            this.dsShift.SourceCondition = "Code_Group = \'ShiftID\'";
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnBaseOK
            // 
            this.Adapter.SetAccessRight(this.btnBaseOK, "CCMCheck");
            this.btnBaseOK.Location = new System.Drawing.Point(802, 3);
            this.btnBaseOK.Name = "btnBaseOK";
            this.btnBaseOK.Size = new System.Drawing.Size(75, 23);
            this.btnBaseOK.TabIndex = 86;
            this.btnBaseOK.Text = "确认";
            this.btnBaseOK.UseVisualStyleBackColor = true;
            this.btnBaseOK.Click += new System.EventHandler(this.btnBaseOK_Click);
            // 
            // btnPaocessOK
            // 
            this.Adapter.SetAccessRight(this.btnPaocessOK, "CCMCheck");
            this.btnPaocessOK.Location = new System.Drawing.Point(802, 3);
            this.btnPaocessOK.Name = "btnPaocessOK";
            this.btnPaocessOK.Size = new System.Drawing.Size(75, 23);
            this.btnPaocessOK.TabIndex = 86;
            this.btnPaocessOK.Text = "确认";
            this.btnPaocessOK.UseVisualStyleBackColor = true;
            this.btnPaocessOK.Click += new System.EventHandler(this.btnPaocessOK_Click);
            // 
            // btnConfirmExcept
            // 
            this.Adapter.SetAccessRight(this.btnConfirmExcept, "CCMCheck");
            this.btnConfirmExcept.Location = new System.Drawing.Point(804, 3);
            this.btnConfirmExcept.Name = "btnConfirmExcept";
            this.btnConfirmExcept.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmExcept.TabIndex = 86;
            this.btnConfirmExcept.Text = "确认";
            this.btnConfirmExcept.UseVisualStyleBackColor = true;
            this.btnConfirmExcept.Click += new System.EventHandler(this.btnConfirmExcept_Click);
            // 
            // bdExcept
            // 
            this.Adapter.SetAccessRight(this.bdExcept, "CCMCheck");
            this.bdExcept.AddNewItem = null;
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
            this.toolStripSeparator31,
            this.toolStripLabel11,
            this.txtExcept});
            this.bdExcept.Location = new System.Drawing.Point(3, 3);
            this.bdExcept.MoveFirstItem = this.bindingNavigatorMoveFirstItem7;
            this.bdExcept.MoveLastItem = this.bindingNavigatorMoveLastItem7;
            this.bdExcept.MoveNextItem = this.bindingNavigatorMoveNextItem7;
            this.bdExcept.MovePreviousItem = this.bindingNavigatorMovePreviousItem7;
            this.bdExcept.Name = "bdExcept";
            this.bdExcept.PositionItem = this.bindingNavigatorPositionItem7;
            this.bdExcept.Size = new System.Drawing.Size(967, 25);
            this.bdExcept.TabIndex = 1;
            this.bdExcept.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem7
            // 
            this.bindingNavigatorCountItem7.Name = "bindingNavigatorCountItem7";
            this.bindingNavigatorCountItem7.Size = new System.Drawing.Size(32, 22);
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
            // btnAddExcept
            // 
            this.Adapter.SetAccessRight(this.btnAddExcept, "CCMCheck");
            this.btnAddExcept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddExcept.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExcept.Image")));
            this.btnAddExcept.Name = "btnAddExcept";
            this.btnAddExcept.RightToLeftAutoMirrorImage = true;
            this.btnAddExcept.Size = new System.Drawing.Size(23, 22);
            this.btnAddExcept.Text = "新添";
            this.btnAddExcept.Click += new System.EventHandler(this.btnAddExcept_Click);
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
            // toolStripSeparator31
            // 
            this.toolStripSeparator31.Name = "toolStripSeparator31";
            this.toolStripSeparator31.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel11.Text = "  异常代码维护:";
            // 
            // txtExcept
            // 
            this.txtExcept.Name = "txtExcept";
            this.txtExcept.Size = new System.Drawing.Size(160, 25);
            this.txtExcept.Leave += new System.EventHandler(this.txtExcept_Leave);
            // 
            // btnAddHeatCover
            // 
            this.Adapter.SetAccessRight(this.btnAddHeatCover, "CCMCheck");
            this.btnAddHeatCover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddHeatCover.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHeatCover.Image")));
            this.btnAddHeatCover.Name = "btnAddHeatCover";
            this.btnAddHeatCover.RightToLeftAutoMirrorImage = true;
            this.btnAddHeatCover.Size = new System.Drawing.Size(23, 22);
            this.btnAddHeatCover.Text = "新添";
            this.btnAddHeatCover.Click += new System.EventHandler(this.btnAddHeatCover_Click);
            // 
            // btnDelHeatCover
            // 
            this.Adapter.SetAccessRight(this.btnDelHeatCover, "CCMCheck");
            this.btnDelHeatCover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelHeatCover.Image = ((System.Drawing.Image)(resources.GetObject("btnDelHeatCover.Image")));
            this.btnDelHeatCover.Name = "btnDelHeatCover";
            this.btnDelHeatCover.RightToLeftAutoMirrorImage = true;
            this.btnDelHeatCover.Size = new System.Drawing.Size(23, 22);
            this.btnDelHeatCover.Text = "删除";
            this.btnDelHeatCover.Click += new System.EventHandler(this.btnDelHeatCover_Click);
            // 
            // btnCoverOK
            // 
            this.Adapter.SetAccessRight(this.btnCoverOK, "CCMCheck");
            this.btnCoverOK.Location = new System.Drawing.Point(802, 3);
            this.btnCoverOK.Name = "btnCoverOK";
            this.btnCoverOK.Size = new System.Drawing.Size(75, 23);
            this.btnCoverOK.TabIndex = 86;
            this.btnCoverOK.Text = "确认";
            this.btnCoverOK.UseVisualStyleBackColor = true;
            this.btnCoverOK.Click += new System.EventHandler(this.btnCoverK_Click);
            // 
            // btnAddLadle
            // 
            this.Adapter.SetAccessRight(this.btnAddLadle, "CCMCheck");
            this.btnAddLadle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddLadle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLadle.Image")));
            this.btnAddLadle.Name = "btnAddLadle";
            this.btnAddLadle.RightToLeftAutoMirrorImage = true;
            this.btnAddLadle.Size = new System.Drawing.Size(23, 22);
            this.btnAddLadle.Text = "新添";
            this.btnAddLadle.Click += new System.EventHandler(this.btnAddLadle_Click);
            // 
            // btnAddProtectMat
            // 
            this.Adapter.SetAccessRight(this.btnAddProtectMat, "CCMCheck");
            this.btnAddProtectMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddProtectMat.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProtectMat.Image")));
            this.btnAddProtectMat.Name = "btnAddProtectMat";
            this.btnAddProtectMat.RightToLeftAutoMirrorImage = true;
            this.btnAddProtectMat.Size = new System.Drawing.Size(23, 22);
            this.btnAddProtectMat.Text = "新添";
            this.btnAddProtectMat.Click += new System.EventHandler(this.btnAddProtectMat_Click);
            // 
            // btnDelProtectMat
            // 
            this.Adapter.SetAccessRight(this.btnDelProtectMat, "CCMCheck");
            this.btnDelProtectMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelProtectMat.Image = ((System.Drawing.Image)(resources.GetObject("btnDelProtectMat.Image")));
            this.btnDelProtectMat.Name = "btnDelProtectMat";
            this.btnDelProtectMat.RightToLeftAutoMirrorImage = true;
            this.btnDelProtectMat.Size = new System.Drawing.Size(23, 22);
            this.btnDelProtectMat.Text = "删除";
            this.btnDelProtectMat.Click += new System.EventHandler(this.btnDelProtectMat_Click);
            // 
            // btnProtectMatOK
            // 
            this.Adapter.SetAccessRight(this.btnProtectMatOK, "CCMCheck");
            this.btnProtectMatOK.Location = new System.Drawing.Point(802, 3);
            this.btnProtectMatOK.Name = "btnProtectMatOK";
            this.btnProtectMatOK.Size = new System.Drawing.Size(75, 23);
            this.btnProtectMatOK.TabIndex = 86;
            this.btnProtectMatOK.Text = "确认";
            this.btnProtectMatOK.UseVisualStyleBackColor = true;
            this.btnProtectMatOK.Click += new System.EventHandler(this.btnProtectMatOK_Click);
            // 
            // btnProtectSlagOK
            // 
            this.Adapter.SetAccessRight(this.btnProtectSlagOK, "CCMCheck");
            this.btnProtectSlagOK.Location = new System.Drawing.Point(802, 3);
            this.btnProtectSlagOK.Name = "btnProtectSlagOK";
            this.btnProtectSlagOK.Size = new System.Drawing.Size(75, 23);
            this.btnProtectSlagOK.TabIndex = 86;
            this.btnProtectSlagOK.Text = "确认";
            this.btnProtectSlagOK.UseVisualStyleBackColor = true;
            this.btnProtectSlagOK.Click += new System.EventHandler(this.btnProtectSlagOK_Click);
            // 
            // btnAddProtectSlag
            // 
            this.Adapter.SetAccessRight(this.btnAddProtectSlag, "CCMCheck");
            this.btnAddProtectSlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddProtectSlag.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProtectSlag.Image")));
            this.btnAddProtectSlag.Name = "btnAddProtectSlag";
            this.btnAddProtectSlag.RightToLeftAutoMirrorImage = true;
            this.btnAddProtectSlag.Size = new System.Drawing.Size(23, 22);
            this.btnAddProtectSlag.Text = "新添";
            this.btnAddProtectSlag.Click += new System.EventHandler(this.btnAddProtectSlag_Click);
            // 
            // btnDelProtectSlag
            // 
            this.Adapter.SetAccessRight(this.btnDelProtectSlag, "CCMCheck");
            this.btnDelProtectSlag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelProtectSlag.Image = ((System.Drawing.Image)(resources.GetObject("btnDelProtectSlag.Image")));
            this.btnDelProtectSlag.Name = "btnDelProtectSlag";
            this.btnDelProtectSlag.RightToLeftAutoMirrorImage = true;
            this.btnDelProtectSlag.Size = new System.Drawing.Size(23, 22);
            this.btnDelProtectSlag.Text = "删除";
            this.btnDelProtectSlag.Click += new System.EventHandler(this.btnDelProtectSlag_Click);
            // 
            // btnHoldTempMatConfirm
            // 
            this.Adapter.SetAccessRight(this.btnHoldTempMatConfirm, "CCMCheck");
            this.btnHoldTempMatConfirm.Location = new System.Drawing.Point(804, 3);
            this.btnHoldTempMatConfirm.Name = "btnHoldTempMatConfirm";
            this.btnHoldTempMatConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnHoldTempMatConfirm.TabIndex = 86;
            this.btnHoldTempMatConfirm.Text = "确认";
            this.btnHoldTempMatConfirm.UseVisualStyleBackColor = true;
            this.btnHoldTempMatConfirm.Click += new System.EventHandler(this.btnCastingConfirm_Click);
            // 
            // btnAddHoldTempMat
            // 
            this.Adapter.SetAccessRight(this.btnAddHoldTempMat, "CCMCheck");
            this.btnAddHoldTempMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddHoldTempMat.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHoldTempMat.Image")));
            this.btnAddHoldTempMat.Name = "btnAddHoldTempMat";
            this.btnAddHoldTempMat.RightToLeftAutoMirrorImage = true;
            this.btnAddHoldTempMat.Size = new System.Drawing.Size(23, 22);
            this.btnAddHoldTempMat.Text = "新添";
            this.btnAddHoldTempMat.Click += new System.EventHandler(this.btnAddCasting_Click);
            // 
            // btnDelHoldTempMat
            // 
            this.Adapter.SetAccessRight(this.btnDelHoldTempMat, "CCMCheck");
            this.btnDelHoldTempMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelHoldTempMat.Image = ((System.Drawing.Image)(resources.GetObject("btnDelHoldTempMat.Image")));
            this.btnDelHoldTempMat.Name = "btnDelHoldTempMat";
            this.btnDelHoldTempMat.RightToLeftAutoMirrorImage = true;
            this.btnDelHoldTempMat.Size = new System.Drawing.Size(23, 22);
            this.btnDelHoldTempMat.Text = "删除";
            this.btnDelHoldTempMat.Click += new System.EventHandler(this.btnDelHoldTempMat_Click);
            // 
            // btnRemarkOK
            // 
            this.Adapter.SetAccessRight(this.btnRemarkOK, "CCMCheck");
            this.btnRemarkOK.Location = new System.Drawing.Point(802, 3);
            this.btnRemarkOK.Name = "btnRemarkOK";
            this.btnRemarkOK.Size = new System.Drawing.Size(75, 23);
            this.btnRemarkOK.TabIndex = 86;
            this.btnRemarkOK.Text = "确认";
            this.btnRemarkOK.UseVisualStyleBackColor = true;
            this.btnRemarkOK.Click += new System.EventHandler(this.btnRemarkOK_Click);
            // 
            // btnAddRemark
            // 
            this.Adapter.SetAccessRight(this.btnAddRemark, "CCMCheck");
            this.btnAddRemark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRemark.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRemark.Image")));
            this.btnAddRemark.Name = "btnAddRemark";
            this.btnAddRemark.RightToLeftAutoMirrorImage = true;
            this.btnAddRemark.Size = new System.Drawing.Size(23, 22);
            this.btnAddRemark.Text = "新添";
            this.btnAddRemark.Click += new System.EventHandler(this.btnAddRemark_Click);
            // 
            // button2
            // 
            this.Adapter.SetAccessRight(this.button2, "CCMCheck");
            this.button2.Location = new System.Drawing.Point(790, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSmoothBlockConfirm_Click);
            // 
            // btnSmoothBlockAdd
            // 
            this.Adapter.SetAccessRight(this.btnSmoothBlockAdd, "CCMCheck");
            this.btnSmoothBlockAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSmoothBlockAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnSmoothBlockAdd.Image")));
            this.btnSmoothBlockAdd.Name = "btnSmoothBlockAdd";
            this.btnSmoothBlockAdd.RightToLeftAutoMirrorImage = true;
            this.btnSmoothBlockAdd.Size = new System.Drawing.Size(23, 22);
            this.btnSmoothBlockAdd.Text = "新添";
            this.btnSmoothBlockAdd.Click += new System.EventHandler(this.btnSmoothBlockAdd_Click);
            // 
            // btnSmoothBlockDel
            // 
            this.Adapter.SetAccessRight(this.btnSmoothBlockDel, "CCMCheck");
            this.btnSmoothBlockDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSmoothBlockDel.Image = ((System.Drawing.Image)(resources.GetObject("btnSmoothBlockDel.Image")));
            this.btnSmoothBlockDel.Name = "btnSmoothBlockDel";
            this.btnSmoothBlockDel.RightToLeftAutoMirrorImage = true;
            this.btnSmoothBlockDel.Size = new System.Drawing.Size(23, 22);
            this.btnSmoothBlockDel.Text = "删除";
            this.btnSmoothBlockDel.Click += new System.EventHandler(this.btnSmoothBlockDel_Click);
            // 
            // btnHurryGapConfirm
            // 
            this.Adapter.SetAccessRight(this.btnHurryGapConfirm, "CCMCheck");
            this.btnHurryGapConfirm.Location = new System.Drawing.Point(790, 3);
            this.btnHurryGapConfirm.Name = "btnHurryGapConfirm";
            this.btnHurryGapConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnHurryGapConfirm.TabIndex = 86;
            this.btnHurryGapConfirm.Text = "确认";
            this.btnHurryGapConfirm.UseVisualStyleBackColor = true;
            this.btnHurryGapConfirm.Click += new System.EventHandler(this.btnHurryGapConfirm_Click);
            // 
            // btnHurryGapAdd
            // 
            this.Adapter.SetAccessRight(this.btnHurryGapAdd, "CCMCheck");
            this.btnHurryGapAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHurryGapAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnHurryGapAdd.Image")));
            this.btnHurryGapAdd.Name = "btnHurryGapAdd";
            this.btnHurryGapAdd.RightToLeftAutoMirrorImage = true;
            this.btnHurryGapAdd.Size = new System.Drawing.Size(23, 22);
            this.btnHurryGapAdd.Text = "新添";
            this.btnHurryGapAdd.Click += new System.EventHandler(this.btnHurryGapAdd_Click);
            // 
            // btnHurryGapDel
            // 
            this.Adapter.SetAccessRight(this.btnHurryGapDel, "CCMCheck");
            this.btnHurryGapDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHurryGapDel.Image = ((System.Drawing.Image)(resources.GetObject("btnHurryGapDel.Image")));
            this.btnHurryGapDel.Name = "btnHurryGapDel";
            this.btnHurryGapDel.RightToLeftAutoMirrorImage = true;
            this.btnHurryGapDel.Size = new System.Drawing.Size(23, 22);
            this.btnHurryGapDel.Text = "删除";
            this.btnHurryGapDel.Click += new System.EventHandler(this.btnHurryGapDel_Click);
            // 
            // btnBigGapConfirm
            // 
            this.Adapter.SetAccessRight(this.btnBigGapConfirm, "CCMCheck");
            this.btnBigGapConfirm.Location = new System.Drawing.Point(790, 3);
            this.btnBigGapConfirm.Name = "btnBigGapConfirm";
            this.btnBigGapConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnBigGapConfirm.TabIndex = 86;
            this.btnBigGapConfirm.Text = "确认";
            this.btnBigGapConfirm.UseVisualStyleBackColor = true;
            this.btnBigGapConfirm.Click += new System.EventHandler(this.btnBigGapConfirm_Click);
            // 
            // btnBigGapAdd
            // 
            this.Adapter.SetAccessRight(this.btnBigGapAdd, "CCMCheck");
            this.btnBigGapAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBigGapAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBigGapAdd.Image")));
            this.btnBigGapAdd.Name = "btnBigGapAdd";
            this.btnBigGapAdd.RightToLeftAutoMirrorImage = true;
            this.btnBigGapAdd.Size = new System.Drawing.Size(23, 22);
            this.btnBigGapAdd.Text = "新添";
            this.btnBigGapAdd.Click += new System.EventHandler(this.btnBigGapAdd_Click);
            // 
            // btnBigGapDel
            // 
            this.Adapter.SetAccessRight(this.btnBigGapDel, "CCMCheck");
            this.btnBigGapDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBigGapDel.Image = ((System.Drawing.Image)(resources.GetObject("btnBigGapDel.Image")));
            this.btnBigGapDel.Name = "btnBigGapDel";
            this.btnBigGapDel.RightToLeftAutoMirrorImage = true;
            this.btnBigGapDel.Size = new System.Drawing.Size(23, 22);
            this.btnBigGapDel.Text = "删除";
            this.btnBigGapDel.Click += new System.EventHandler(this.btnBigGapDel_Click);
            // 
            // btnStrandInfoOK
            // 
            this.Adapter.SetAccessRight(this.btnStrandInfoOK, "CCMCheck");
            this.btnStrandInfoOK.Location = new System.Drawing.Point(802, 3);
            this.btnStrandInfoOK.Name = "btnStrandInfoOK";
            this.btnStrandInfoOK.Size = new System.Drawing.Size(75, 23);
            this.btnStrandInfoOK.TabIndex = 86;
            this.btnStrandInfoOK.Text = "确认";
            this.btnStrandInfoOK.UseVisualStyleBackColor = true;
            this.btnStrandInfoOK.Click += new System.EventHandler(this.btnStrandInfoOK_Click);
            // 
            // btnAddStrandInfo
            // 
            this.Adapter.SetAccessRight(this.btnAddStrandInfo, "CCMCheck");
            this.btnAddStrandInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStrandInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStrandInfo.Image")));
            this.btnAddStrandInfo.Name = "btnAddStrandInfo";
            this.btnAddStrandInfo.RightToLeftAutoMirrorImage = true;
            this.btnAddStrandInfo.Size = new System.Drawing.Size(23, 22);
            this.btnAddStrandInfo.Text = "新添";
            this.btnAddStrandInfo.Click += new System.EventHandler(this.btnAddStrandInfo_Click);
            // 
            // btnLadleCancel
            // 
            this.Adapter.SetAccessRight(this.btnLadleCancel, "CCMbtnLadleCancel");
            this.btnLadleCancel.Location = new System.Drawing.Point(883, 3);
            this.btnLadleCancel.Name = "btnLadleCancel";
            this.btnLadleCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLadleCancel.TabIndex = 87;
            this.btnLadleCancel.Text = "取消";
            this.btnLadleCancel.UseVisualStyleBackColor = true;
            this.btnLadleCancel.Click += new System.EventHandler(this.btnLadleCancel_Click);
            // 
            // btnLadleOK
            // 
            this.Adapter.SetAccessRight(this.btnLadleOK, "CCMbtnLadleOk");
            this.btnLadleOK.Location = new System.Drawing.Point(802, 3);
            this.btnLadleOK.Name = "btnLadleOK";
            this.btnLadleOK.Size = new System.Drawing.Size(75, 23);
            this.btnLadleOK.TabIndex = 86;
            this.btnLadleOK.Text = "确认";
            this.btnLadleOK.UseVisualStyleBackColor = true;
            this.btnLadleOK.Click += new System.EventHandler(this.btnLadle_Click);
            // 
            // button6
            // 
            this.Adapter.SetAccessRight(this.button6, "CCMCheck");
            this.button6.Location = new System.Drawing.Point(802, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 86;
            this.button6.Text = "确认";
            this.button6.UseVisualStyleBackColor = true;
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
            this.cmbTeam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Team", true));
            this.cmbTeam.DataSource = this.dsTeam;
            this.cmbTeam.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(321, 114);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(125, 20);
            this.cmbTeam.TabIndex = 106;
            this.cmbTeam.ValueMember = "L3DataTable.Code";
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
            this.dsTeam.SourceCondition = "Code_Group = \'TeamID\'";
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
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBase, "ProductionDate", true));
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(535, 138);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(145, 21);
            this.dateTimePicker6.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 104;
            this.label10.Text = "生产日期:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(699, 146);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(29, 12);
            this.label57.TabIndex = 102;
            this.label57.Text = "4流:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(699, 118);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(29, 12);
            this.label56.TabIndex = 102;
            this.label56.Text = "3流:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(282, 145);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 12);
            this.label59.TabIndex = 102;
            this.label59.Text = "班次:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(699, 88);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(29, 12);
            this.label55.TabIndex = 102;
            this.label55.Text = "2流:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(282, 117);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(35, 12);
            this.label58.TabIndex = 102;
            this.label58.Text = "班别:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(699, 59);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(29, 12);
            this.label54.TabIndex = 102;
            this.label54.Text = "1流:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(766, 31);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(77, 12);
            this.label47.TabIndex = 102;
            this.label47.Text = "中间罐浇钢工";
            // 
            // tbxSecondHand
            // 
            this.tbxSecondHand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Cut_Operator", true));
            this.tbxSecondHand.DisplayPrecision = 0;
            this.tbxSecondHand.Enabled = false;
            this.tbxSecondHand.EnableNull = true;
            this.tbxSecondHand.ErropPr = null;
            this.tbxSecondHand.FixedLength = 0;
            this.tbxSecondHand.Length = 0;
            this.tbxSecondHand.Location = new System.Drawing.Point(519, 209);
            this.tbxSecondHand.Max = 0D;
            this.tbxSecondHand.MaxNull = 0D;
            this.tbxSecondHand.MaxStringLength = 0;
            this.tbxSecondHand.MaxStrLength = 0;
            this.tbxSecondHand.Min = 0D;
            this.tbxSecondHand.MinNull = 0D;
            this.tbxSecondHand.MinStringLength = 0;
            this.tbxSecondHand.MinStrLength = 0;
            this.tbxSecondHand.Name = "tbxSecondHand";
            this.tbxSecondHand.Precision = 0;
            this.tbxSecondHand.Regex = "";
            this.tbxSecondHand.Size = new System.Drawing.Size(145, 21);
            this.tbxSecondHand.TabIndex = 103;
            this.tbxSecondHand.ToolTipValid = null;
            this.tbxSecondHand.VaildWarning = "";
            this.tbxSecondHand.ValidEable = true;
            this.tbxSecondHand.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.tbxSecondHand.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 102;
            this.label9.Text = "出坯工:";
            this.label9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 100;
            this.label7.Text = "大罐浇钢工:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(485, 84);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(47, 12);
            this.label34.TabIndex = 98;
            this.label34.Text = "主控工:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 98;
            this.label5.Text = "机长:";
            // 
            // pxTextBox33
            // 
            this.pxTextBox33.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Length", true));
            this.pxTextBox33.DisplayPrecision = 0;
            this.pxTextBox33.EnableNull = true;
            this.pxTextBox33.ErropPr = null;
            this.pxTextBox33.FixedLength = 0;
            this.pxTextBox33.Length = 0;
            this.pxTextBox33.Location = new System.Drawing.Point(321, 84);
            this.pxTextBox33.Max = 0D;
            this.pxTextBox33.MaxNull = 0D;
            this.pxTextBox33.MaxStringLength = 0;
            this.pxTextBox33.MaxStrLength = 0;
            this.pxTextBox33.Min = 0D;
            this.pxTextBox33.MinNull = 0D;
            this.pxTextBox33.MinStringLength = 0;
            this.pxTextBox33.MinStrLength = 0;
            this.pxTextBox33.Name = "pxTextBox33";
            this.pxTextBox33.Precision = 0;
            this.pxTextBox33.ReadOnly = true;
            this.pxTextBox33.Regex = "";
            this.pxTextBox33.Size = new System.Drawing.Size(125, 21);
            this.pxTextBox33.TabIndex = 97;
            this.pxTextBox33.ToolTipValid = null;
            this.pxTextBox33.VaildWarning = "";
            this.pxTextBox33.ValidEable = true;
            this.pxTextBox33.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox17
            // 
            this.pxTextBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Width", true));
            this.pxTextBox17.DisplayPrecision = 0;
            this.pxTextBox17.EnableNull = true;
            this.pxTextBox17.ErropPr = null;
            this.pxTextBox17.FixedLength = 0;
            this.pxTextBox17.Length = 0;
            this.pxTextBox17.Location = new System.Drawing.Point(321, 55);
            this.pxTextBox17.Max = 0D;
            this.pxTextBox17.MaxNull = 0D;
            this.pxTextBox17.MaxStringLength = 0;
            this.pxTextBox17.MaxStrLength = 0;
            this.pxTextBox17.Min = 0D;
            this.pxTextBox17.MinNull = 0D;
            this.pxTextBox17.MinStringLength = 0;
            this.pxTextBox17.MinStrLength = 0;
            this.pxTextBox17.Name = "pxTextBox17";
            this.pxTextBox17.Precision = 0;
            this.pxTextBox17.ReadOnly = true;
            this.pxTextBox17.Regex = "";
            this.pxTextBox17.Size = new System.Drawing.Size(125, 21);
            this.pxTextBox17.TabIndex = 97;
            this.pxTextBox17.ToolTipValid = null;
            this.pxTextBox17.VaildWarning = "";
            this.pxTextBox17.ValidEable = true;
            this.pxTextBox17.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Thickness", true));
            this.pxTextBox2.DisplayPrecision = 0;
            this.pxTextBox2.EnableNull = true;
            this.pxTextBox2.ErropPr = null;
            this.pxTextBox2.FixedLength = 0;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(321, 27);
            this.pxTextBox2.Max = 0D;
            this.pxTextBox2.MaxNull = 0D;
            this.pxTextBox2.MaxStringLength = 0;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0D;
            this.pxTextBox2.MinNull = 0D;
            this.pxTextBox2.MinStringLength = 0;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            this.pxTextBox2.ReadOnly = true;
            this.pxTextBox2.Regex = "";
            this.pxTextBox2.Size = new System.Drawing.Size(125, 21);
            this.pxTextBox2.TabIndex = 97;
            this.pxTextBox2.ToolTipValid = null;
            this.pxTextBox2.VaildWarning = "";
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox24
            // 
            this.pxTextBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Plan_SteelGrade", true));
            this.pxTextBox24.DisplayPrecision = 0;
            this.pxTextBox24.EnableNull = true;
            this.pxTextBox24.ErropPr = null;
            this.pxTextBox24.FixedLength = 0;
            this.pxTextBox24.Length = 0;
            this.pxTextBox24.Location = new System.Drawing.Point(95, 83);
            this.pxTextBox24.Max = 0D;
            this.pxTextBox24.MaxNull = 0D;
            this.pxTextBox24.MaxStringLength = 0;
            this.pxTextBox24.MaxStrLength = 0;
            this.pxTextBox24.Min = 0D;
            this.pxTextBox24.MinNull = 0D;
            this.pxTextBox24.MinStringLength = 0;
            this.pxTextBox24.MinStrLength = 0;
            this.pxTextBox24.Name = "pxTextBox24";
            this.pxTextBox24.Precision = 0;
            this.pxTextBox24.ReadOnly = true;
            this.pxTextBox24.Regex = "";
            this.pxTextBox24.Size = new System.Drawing.Size(145, 21);
            this.pxTextBox24.TabIndex = 97;
            this.pxTextBox24.ToolTipValid = null;
            this.pxTextBox24.VaildWarning = "";
            this.pxTextBox24.ValidEable = true;
            this.pxTextBox24.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox23
            // 
            this.pxTextBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Pre_SteelGradeIndex", true));
            this.pxTextBox23.DisplayPrecision = 0;
            this.pxTextBox23.EnableNull = true;
            this.pxTextBox23.ErropPr = null;
            this.pxTextBox23.FixedLength = 0;
            this.pxTextBox23.Length = 0;
            this.pxTextBox23.Location = new System.Drawing.Point(95, 141);
            this.pxTextBox23.Max = 0D;
            this.pxTextBox23.MaxNull = 0D;
            this.pxTextBox23.MaxStringLength = 0;
            this.pxTextBox23.MaxStrLength = 0;
            this.pxTextBox23.Min = 0D;
            this.pxTextBox23.MinNull = 0D;
            this.pxTextBox23.MinStringLength = 0;
            this.pxTextBox23.MinStrLength = 0;
            this.pxTextBox23.Name = "pxTextBox23";
            this.pxTextBox23.Precision = 0;
            this.pxTextBox23.ReadOnly = true;
            this.pxTextBox23.Regex = "";
            this.pxTextBox23.Size = new System.Drawing.Size(145, 21);
            this.pxTextBox23.TabIndex = 97;
            this.pxTextBox23.ToolTipValid = null;
            this.pxTextBox23.VaildWarning = "";
            this.pxTextBox23.ValidEable = true;
            this.pxTextBox23.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(260, 87);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 96;
            this.label33.Text = "定尺[mm]:";
            // 
            // pxTextBox22
            // 
            this.pxTextBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SteelGradeIndex", true));
            this.pxTextBox22.DisplayPrecision = 0;
            this.pxTextBox22.EnableNull = true;
            this.pxTextBox22.ErropPr = null;
            this.pxTextBox22.FixedLength = 0;
            this.pxTextBox22.Length = 0;
            this.pxTextBox22.Location = new System.Drawing.Point(95, 113);
            this.pxTextBox22.Max = 0D;
            this.pxTextBox22.MaxNull = 0D;
            this.pxTextBox22.MaxStringLength = 0;
            this.pxTextBox22.MaxStrLength = 0;
            this.pxTextBox22.Min = 0D;
            this.pxTextBox22.MinNull = 0D;
            this.pxTextBox22.MinStringLength = 0;
            this.pxTextBox22.MinStrLength = 0;
            this.pxTextBox22.Name = "pxTextBox22";
            this.pxTextBox22.Precision = 0;
            this.pxTextBox22.ReadOnly = true;
            this.pxTextBox22.Regex = "";
            this.pxTextBox22.Size = new System.Drawing.Size(145, 21);
            this.pxTextBox22.TabIndex = 97;
            this.pxTextBox22.ToolTipValid = null;
            this.pxTextBox22.VaildWarning = "";
            this.pxTextBox22.ValidEable = true;
            this.pxTextBox22.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 96;
            this.label19.Text = "宽度[mm]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "厚度[mm]:";
            // 
            // pxTextBox20
            // 
            this.pxTextBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SteelGrade", true));
            this.pxTextBox20.DisplayPrecision = 0;
            this.pxTextBox20.EnableNull = true;
            this.pxTextBox20.ErropPr = null;
            this.pxTextBox20.FixedLength = 0;
            this.pxTextBox20.Length = 0;
            this.pxTextBox20.Location = new System.Drawing.Point(95, 54);
            this.pxTextBox20.Max = 0D;
            this.pxTextBox20.MaxNull = 0D;
            this.pxTextBox20.MaxStringLength = 0;
            this.pxTextBox20.MaxStrLength = 0;
            this.pxTextBox20.Min = 0D;
            this.pxTextBox20.MinNull = 0D;
            this.pxTextBox20.MinStringLength = 0;
            this.pxTextBox20.MinStrLength = 0;
            this.pxTextBox20.Name = "pxTextBox20";
            this.pxTextBox20.Precision = 0;
            this.pxTextBox20.ReadOnly = true;
            this.pxTextBox20.Regex = "";
            this.pxTextBox20.Size = new System.Drawing.Size(145, 21);
            this.pxTextBox20.TabIndex = 97;
            this.pxTextBox20.ToolTipValid = null;
            this.pxTextBox20.VaildWarning = "";
            this.pxTextBox20.ValidEable = true;
            this.pxTextBox20.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(37, 87);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 12);
            this.label36.TabIndex = 96;
            this.label36.Text = "计划钢种:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(13, 145);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 12);
            this.label35.TabIndex = 96;
            this.label35.Text = "预定炼钢记号:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(37, 117);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 96;
            this.label22.Text = "炼钢记号:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 96;
            this.label20.Text = "钢种:";
            // 
            // tbxCCMID
            // 
            this.tbxCCMID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "CCMID", true));
            this.tbxCCMID.DisplayPrecision = 0;
            this.tbxCCMID.EnableNull = true;
            this.tbxCCMID.ErropPr = null;
            this.tbxCCMID.FixedLength = 0;
            this.tbxCCMID.Length = 0;
            this.tbxCCMID.Location = new System.Drawing.Point(95, 26);
            this.tbxCCMID.Max = 0D;
            this.tbxCCMID.MaxNull = 0D;
            this.tbxCCMID.MaxStringLength = 0;
            this.tbxCCMID.MaxStrLength = 0;
            this.tbxCCMID.Min = 0D;
            this.tbxCCMID.MinNull = 0D;
            this.tbxCCMID.MinStringLength = 0;
            this.tbxCCMID.MinStrLength = 0;
            this.tbxCCMID.Name = "tbxCCMID";
            this.tbxCCMID.Precision = 0;
            this.tbxCCMID.ReadOnly = true;
            this.tbxCCMID.Regex = "";
            this.tbxCCMID.Size = new System.Drawing.Size(145, 21);
            this.tbxCCMID.TabIndex = 93;
            this.tbxCCMID.ToolTipValid = null;
            this.tbxCCMID.VaildWarning = "";
            this.tbxCCMID.ValidEable = true;
            this.tbxCCMID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "铸机号:";
            // 
            // pnlBase
            // 
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBase.Controls.Add(this.btnBaseCancel);
            this.pnlBase.Controls.Add(this.btnBaseOK);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBase.Location = new System.Drawing.Point(3, 394);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(965, 33);
            this.pnlBase.TabIndex = 89;
            // 
            // btnBaseCancel
            // 
            this.btnBaseCancel.Location = new System.Drawing.Point(883, 3);
            this.btnBaseCancel.Name = "btnBaseCancel";
            this.btnBaseCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBaseCancel.TabIndex = 87;
            this.btnBaseCancel.Text = "取消";
            this.btnBaseCancel.UseVisualStyleBackColor = true;
            this.btnBaseCancel.Click += new System.EventHandler(this.btnBaseCancel_Click);
            // 
            // tabProcess
            // 
            this.tabProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProcess.Controls.Add(this.pxTextBox27);
            this.tabProcess.Controls.Add(this.label75);
            this.tabProcess.Controls.Add(this.pxTextBox26);
            this.tabProcess.Controls.Add(this.label74);
            this.tabProcess.Controls.Add(this.label73);
            this.tabProcess.Controls.Add(this.comboBox14);
            this.tabProcess.Controls.Add(this.pxTextBox25);
            this.tabProcess.Controls.Add(this.label72);
            this.tabProcess.Controls.Add(this.label52);
            this.tabProcess.Controls.Add(this.cmbChangeReason);
            this.tabProcess.Controls.Add(this.textBox1);
            this.tabProcess.Controls.Add(this.label51);
            this.tabProcess.Controls.Add(this.label26);
            this.tabProcess.Controls.Add(this.label27);
            this.tabProcess.Controls.Add(this.label23);
            this.tabProcess.Controls.Add(this.label17);
            this.tabProcess.Controls.Add(this.label25);
            this.tabProcess.Controls.Add(this.label80);
            this.tabProcess.Controls.Add(this.label79);
            this.tabProcess.Controls.Add(this.label78);
            this.tabProcess.Controls.Add(this.label77);
            this.tabProcess.Controls.Add(this.label76);
            this.tabProcess.Controls.Add(this.label21);
            this.tabProcess.Controls.Add(this.label16);
            this.tabProcess.Controls.Add(this.label24);
            this.tabProcess.Controls.Add(this.label18);
            this.tabProcess.Controls.Add(this.lb);
            this.tabProcess.Controls.Add(this.cmbSecondCoolingMode);
            this.tabProcess.Controls.Add(this.cmbInjectionBar_BlowAr);
            this.tabProcess.Controls.Add(this.comboBox3);
            this.tabProcess.Controls.Add(this.cmbSoftPressFlag2);
            this.tabProcess.Controls.Add(this.cmbSoftPressFlag4);
            this.tabProcess.Controls.Add(this.cmbSoftPressFlag1);
            this.tabProcess.Controls.Add(this.cmbSoftPressFlag3);
            this.tabProcess.Controls.Add(this.cmbSpeedChange);
            this.tabProcess.Controls.Add(this.cmbPlugBarControl);
            this.tabProcess.Controls.Add(this.comboBox4);
            this.tabProcess.Controls.Add(this.dateTimePicker1);
            this.tabProcess.Controls.Add(this.label1);
            this.tabProcess.Controls.Add(this.dateTimePicker2);
            this.tabProcess.Controls.Add(this.label39);
            this.tabProcess.Controls.Add(this.pxTextBox4);
            this.tabProcess.Controls.Add(this.txtTundishBottomTemp);
            this.tabProcess.Controls.Add(this.ptbShuikou_Temp4);
            this.tabProcess.Controls.Add(this.ptbShuikou_Temp3);
            this.tabProcess.Controls.Add(this.ptbShuikou_Temp2);
            this.tabProcess.Controls.Add(this.ptbShuikou_Temp1);
            this.tabProcess.Controls.Add(this.ptbBef_tundish_temp);
            this.tabProcess.Controls.Add(this.txtTundishLevelMold);
            this.tabProcess.Controls.Add(this.txtTundishSlagThickness);
            this.tabProcess.Controls.Add(this.pxTextBox3);
            this.tabProcess.Controls.Add(this.txtTundishNo);
            this.tabProcess.Controls.Add(this.pxTextBox1);
            this.tabProcess.Controls.Add(this.label14);
            this.tabProcess.Controls.Add(this.label13);
            this.tabProcess.Controls.Add(this.label12);
            this.tabProcess.Controls.Add(this.label11);
            this.tabProcess.Controls.Add(this.txtTundishWallTemp);
            this.tabProcess.Controls.Add(this.pxTextBox36);
            this.tabProcess.Controls.Add(this.pxTextBox34);
            this.tabProcess.Controls.Add(this.label15);
            this.tabProcess.Controls.Add(this.label3);
            this.tabProcess.Controls.Add(this.label50);
            this.tabProcess.Controls.Add(this.label49);
            this.tabProcess.Controls.Add(this.label48);
            this.tabProcess.Controls.Add(this.label43);
            this.tabProcess.Controls.Add(this.txtCastingNo);
            this.tabProcess.Controls.Add(this.label30);
            this.tabProcess.Controls.Add(this.pnlProcess);
            this.tabProcess.Location = new System.Drawing.Point(4, 22);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(973, 432);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "连铸数据";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // pxTextBox27
            // 
            this.pxTextBox27.DisplayPrecision = 0;
            this.pxTextBox27.EnableNull = true;
            this.pxTextBox27.ErropPr = this.errorProvider1;
            this.errorProvider1.SetError(this.pxTextBox27, "请填写未投入的具体流号或辊号");
            this.pxTextBox27.FixedLength = 0;
            this.pxTextBox27.Length = 0;
            this.pxTextBox27.Location = new System.Drawing.Point(413, 295);
            this.pxTextBox27.Max = 0D;
            this.pxTextBox27.MaxNull = 0D;
            this.pxTextBox27.MaxStringLength = 0;
            this.pxTextBox27.MaxStrLength = 0;
            this.pxTextBox27.Min = 0D;
            this.pxTextBox27.MinNull = 0D;
            this.pxTextBox27.MinStringLength = 0;
            this.pxTextBox27.MinStrLength = 0;
            this.pxTextBox27.Multiline = true;
            this.pxTextBox27.Name = "pxTextBox27";
            this.pxTextBox27.Precision = 0;
            this.pxTextBox27.Regex = "";
            this.pxTextBox27.Size = new System.Drawing.Size(144, 50);
            this.pxTextBox27.TabIndex = 162;
            this.toolTip1.SetToolTip(this.pxTextBox27, "请填写未投入的具体流号或辊号");
            this.pxTextBox27.ToolTipValid = null;
            this.pxTextBox27.VaildWarning = "";
            this.pxTextBox27.ValidEable = true;
            this.pxTextBox27.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.pxTextBox27.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Tag = "";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(351, 298);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(107, 12);
            this.label75.TabIndex = 163;
            this.label75.Text = "轻压下未投入情况:";
            this.label75.Visible = false;
            // 
            // pxTextBox26
            // 
            this.pxTextBox26.DisplayPrecision = 0;
            this.pxTextBox26.EnableNull = true;
            this.pxTextBox26.ErropPr = null;
            this.pxTextBox26.FixedLength = 0;
            this.pxTextBox26.Length = 0;
            this.pxTextBox26.Location = new System.Drawing.Point(401, 342);
            this.pxTextBox26.Max = 0D;
            this.pxTextBox26.MaxNull = 0D;
            this.pxTextBox26.MaxStringLength = 0;
            this.pxTextBox26.MaxStrLength = 0;
            this.pxTextBox26.Min = 0D;
            this.pxTextBox26.MinNull = 0D;
            this.pxTextBox26.MinStringLength = 0;
            this.pxTextBox26.MinStrLength = 0;
            this.pxTextBox26.Multiline = true;
            this.pxTextBox26.Name = "pxTextBox26";
            this.pxTextBox26.Precision = 0;
            this.pxTextBox26.Regex = "";
            this.pxTextBox26.Size = new System.Drawing.Size(144, 50);
            this.pxTextBox26.TabIndex = 160;
            this.pxTextBox26.ToolTipValid = null;
            this.pxTextBox26.VaildWarning = "";
            this.pxTextBox26.ValidEable = true;
            this.pxTextBox26.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.pxTextBox26.Visible = false;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(353, 349);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(107, 12);
            this.label74.TabIndex = 161;
            this.label74.Text = "轻压下未投入原因:";
            this.label74.Visible = false;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(97, 345);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(95, 12);
            this.label73.TabIndex = 159;
            this.label73.Text = "轻压下是否投入:";
            this.label73.Visible = false;
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "",
            "是",
            "否"});
            this.comboBox14.Location = new System.Drawing.Point(198, 342);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(144, 20);
            this.comboBox14.TabIndex = 158;
            this.comboBox14.Visible = false;
            // 
            // pxTextBox25
            // 
            this.pxTextBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "SpeedChange_Detailed", true));
            this.pxTextBox25.DisplayPrecision = 0;
            this.pxTextBox25.EnableNull = true;
            this.pxTextBox25.ErropPr = null;
            this.pxTextBox25.FixedLength = 0;
            this.pxTextBox25.Length = 0;
            this.pxTextBox25.Location = new System.Drawing.Point(186, 245);
            this.pxTextBox25.Max = 0D;
            this.pxTextBox25.MaxNull = 0D;
            this.pxTextBox25.MaxStringLength = 0;
            this.pxTextBox25.MaxStrLength = 0;
            this.pxTextBox25.Min = 0D;
            this.pxTextBox25.MinNull = 0D;
            this.pxTextBox25.MinStringLength = 0;
            this.pxTextBox25.MinStrLength = 0;
            this.pxTextBox25.Multiline = true;
            this.pxTextBox25.Name = "pxTextBox25";
            this.pxTextBox25.Precision = 0;
            this.pxTextBox25.Regex = "";
            this.pxTextBox25.Size = new System.Drawing.Size(144, 65);
            this.pxTextBox25.TabIndex = 156;
            this.pxTextBox25.ToolTipValid = null;
            this.pxTextBox25.VaildWarning = "";
            this.pxTextBox25.ValidEable = true;
            this.pxTextBox25.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
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
            this.dsProcess.SourceCondition = null;
            this.dsProcess.SourceMethod = "";
            this.dsProcess.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcess.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Process_Data";
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
            this.coldsProcessL3DataTableGUID,
            this.coldsProcessL3DataTableName,
            this.coldsProcessL3DataTableHeatID,
            this.coldsProcessL3DataTableCastingNo,
            this.coldsProcessL3DataTableCCMID,
            this.coldsProcessL3DataTableTundishNo,
            this.coldsProcessL3DataTableTreatNo,
            this.coldsProcessL3DataTableCasting_HeatNum,
            this.coldsProcessL3DataTableTundish_HeatNum,
            this.coldsProcessL3DataTableInjectionBar_BlowAr,
            this.coldsProcessL3DataTableWeight_Return,
            this.coldsProcessL3DataTableSecond_Cooling_Mode,
            this.coldsProcessL3DataTableSecond_Cooling_CurveNo,
            this.coldsProcessL3DataTableWeight_Cut_Head,
            this.coldsProcessL3DataTableWeight_Cut_Trail,
            this.coldsProcessL3DataTableTundishCar_Type,
            this.coldsProcessL3DataTableCastingStartTime,
            this.coldsProcessL3DataTableCastingStopTime,
            this.coldsProcessL3DataTableWeight_Return_Reason,
            this.coldsProcessL3DataTableTundish_SlagThickness,
            this.coldsProcessL3DataTableTundish_Bottom_Temp,
            this.coldsProcessL3DataTableTundish_Wall_Temp,
            this.coldsProcessL3DataTableTundish_Level_Mold,
            this.coldsProcessL3DataTablePlugBar_Control,
            this.coldsProcessL3DataTableSoft_Press_Flag_1,
            this.coldsProcessL3DataTableSoft_Press_Flag_2,
            this.coldsProcessL3DataTableSoft_Press_Flag_3,
            this.coldsProcessL3DataTableSoft_Press_Flag_4,
            this.coldsProcessL3DataTableSpeedChange,
            this.coldsProcessL3DataTableSpeedChange_Reason,
            this.coldsProcessL3DataTableSpeedChange_Detailed,
            this.coldsProcessL3DataTableBefore_Casting_Tundish_Temp,
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1,
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2,
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3,
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4});
            this.schemadsProcess.TableName = "L3DataTable";
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
            // coldsProcessL3DataTableHeatID
            // 
            this.coldsProcessL3DataTableHeatID.Caption = "HeatID";
            this.coldsProcessL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProcessL3DataTableHeatID.Namespace = "";
            // 
            // coldsProcessL3DataTableCastingNo
            // 
            this.coldsProcessL3DataTableCastingNo.Caption = "CastingNo";
            this.coldsProcessL3DataTableCastingNo.ColumnName = "CastingNo";
            this.coldsProcessL3DataTableCastingNo.Namespace = "";
            // 
            // coldsProcessL3DataTableCCMID
            // 
            this.coldsProcessL3DataTableCCMID.Caption = "CCMID";
            this.coldsProcessL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsProcessL3DataTableCCMID.Namespace = "";
            // 
            // coldsProcessL3DataTableTundishNo
            // 
            this.coldsProcessL3DataTableTundishNo.Caption = "TundishNo";
            this.coldsProcessL3DataTableTundishNo.ColumnName = "TundishNo";
            this.coldsProcessL3DataTableTundishNo.Namespace = "";
            // 
            // coldsProcessL3DataTableTreatNo
            // 
            this.coldsProcessL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.Namespace = "";
            // 
            // coldsProcessL3DataTableCasting_HeatNum
            // 
            this.coldsProcessL3DataTableCasting_HeatNum.Caption = "Casting_HeatNum";
            this.coldsProcessL3DataTableCasting_HeatNum.ColumnName = "Casting_HeatNum";
            this.coldsProcessL3DataTableCasting_HeatNum.DataType = typeof(int);
            this.coldsProcessL3DataTableCasting_HeatNum.Namespace = "";
            // 
            // coldsProcessL3DataTableTundish_HeatNum
            // 
            this.coldsProcessL3DataTableTundish_HeatNum.Caption = "Tundish_HeatNum";
            this.coldsProcessL3DataTableTundish_HeatNum.ColumnName = "Tundish_HeatNum";
            this.coldsProcessL3DataTableTundish_HeatNum.DataType = typeof(int);
            this.coldsProcessL3DataTableTundish_HeatNum.Namespace = "";
            // 
            // coldsProcessL3DataTableInjectionBar_BlowAr
            // 
            this.coldsProcessL3DataTableInjectionBar_BlowAr.Caption = "InjectionBar_BlowAr";
            this.coldsProcessL3DataTableInjectionBar_BlowAr.ColumnName = "InjectionBar_BlowAr";
            this.coldsProcessL3DataTableInjectionBar_BlowAr.DataType = typeof(bool);
            this.coldsProcessL3DataTableInjectionBar_BlowAr.Namespace = "";
            // 
            // coldsProcessL3DataTableWeight_Return
            // 
            this.coldsProcessL3DataTableWeight_Return.Caption = "Weight_Return";
            this.coldsProcessL3DataTableWeight_Return.ColumnName = "Weight_Return";
            this.coldsProcessL3DataTableWeight_Return.DataType = typeof(double);
            this.coldsProcessL3DataTableWeight_Return.Namespace = "";
            // 
            // coldsProcessL3DataTableSecond_Cooling_Mode
            // 
            this.coldsProcessL3DataTableSecond_Cooling_Mode.Caption = "Second_Cooling_Mode";
            this.coldsProcessL3DataTableSecond_Cooling_Mode.ColumnName = "Second_Cooling_Mode";
            this.coldsProcessL3DataTableSecond_Cooling_Mode.DataType = typeof(bool);
            this.coldsProcessL3DataTableSecond_Cooling_Mode.Namespace = "";
            // 
            // coldsProcessL3DataTableSecond_Cooling_CurveNo
            // 
            this.coldsProcessL3DataTableSecond_Cooling_CurveNo.Caption = "Second_Cooling_CurveNo";
            this.coldsProcessL3DataTableSecond_Cooling_CurveNo.ColumnName = "Second_Cooling_CurveNo";
            this.coldsProcessL3DataTableSecond_Cooling_CurveNo.DataType = typeof(int);
            this.coldsProcessL3DataTableSecond_Cooling_CurveNo.Namespace = "";
            // 
            // coldsProcessL3DataTableWeight_Cut_Head
            // 
            this.coldsProcessL3DataTableWeight_Cut_Head.Caption = "Weight_Cut_Head";
            this.coldsProcessL3DataTableWeight_Cut_Head.ColumnName = "Weight_Cut_Head";
            this.coldsProcessL3DataTableWeight_Cut_Head.DataType = typeof(double);
            this.coldsProcessL3DataTableWeight_Cut_Head.Namespace = "";
            // 
            // coldsProcessL3DataTableWeight_Cut_Trail
            // 
            this.coldsProcessL3DataTableWeight_Cut_Trail.Caption = "Weight_Cut_Trail";
            this.coldsProcessL3DataTableWeight_Cut_Trail.ColumnName = "Weight_Cut_Trail";
            this.coldsProcessL3DataTableWeight_Cut_Trail.DataType = typeof(double);
            this.coldsProcessL3DataTableWeight_Cut_Trail.Namespace = "";
            // 
            // coldsProcessL3DataTableTundishCar_Type
            // 
            this.coldsProcessL3DataTableTundishCar_Type.Caption = "TundishCar_Type";
            this.coldsProcessL3DataTableTundishCar_Type.ColumnName = "TundishCar_Type";
            this.coldsProcessL3DataTableTundishCar_Type.Namespace = "";
            // 
            // coldsProcessL3DataTableCastingStartTime
            // 
            this.coldsProcessL3DataTableCastingStartTime.Caption = "CastingStartTime";
            this.coldsProcessL3DataTableCastingStartTime.ColumnName = "CastingStartTime";
            this.coldsProcessL3DataTableCastingStartTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableCastingStartTime.Namespace = "";
            // 
            // coldsProcessL3DataTableCastingStopTime
            // 
            this.coldsProcessL3DataTableCastingStopTime.Caption = "CastingStopTime";
            this.coldsProcessL3DataTableCastingStopTime.ColumnName = "CastingStopTime";
            this.coldsProcessL3DataTableCastingStopTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableCastingStopTime.Namespace = "";
            // 
            // coldsProcessL3DataTableWeight_Return_Reason
            // 
            this.coldsProcessL3DataTableWeight_Return_Reason.Caption = "Weight_Return_Reason";
            this.coldsProcessL3DataTableWeight_Return_Reason.ColumnName = "Weight_Return_Reason";
            this.coldsProcessL3DataTableWeight_Return_Reason.Namespace = "";
            // 
            // coldsProcessL3DataTableTundish_SlagThickness
            // 
            this.coldsProcessL3DataTableTundish_SlagThickness.Caption = "Tundish_SlagThickness";
            this.coldsProcessL3DataTableTundish_SlagThickness.ColumnName = "Tundish_SlagThickness";
            this.coldsProcessL3DataTableTundish_SlagThickness.DataType = typeof(int);
            this.coldsProcessL3DataTableTundish_SlagThickness.Namespace = "";
            // 
            // coldsProcessL3DataTableTundish_Bottom_Temp
            // 
            this.coldsProcessL3DataTableTundish_Bottom_Temp.Caption = "Tundish_Bottom_Temp";
            this.coldsProcessL3DataTableTundish_Bottom_Temp.ColumnName = "Tundish_Bottom_Temp";
            this.coldsProcessL3DataTableTundish_Bottom_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableTundish_Bottom_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableTundish_Wall_Temp
            // 
            this.coldsProcessL3DataTableTundish_Wall_Temp.Caption = "Tundish_Wall_Temp";
            this.coldsProcessL3DataTableTundish_Wall_Temp.ColumnName = "Tundish_Wall_Temp";
            this.coldsProcessL3DataTableTundish_Wall_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableTundish_Wall_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableTundish_Level_Mold
            // 
            this.coldsProcessL3DataTableTundish_Level_Mold.Caption = "Tundish_Level_Mold";
            this.coldsProcessL3DataTableTundish_Level_Mold.ColumnName = "Tundish_Level_Mold";
            this.coldsProcessL3DataTableTundish_Level_Mold.DataType = typeof(int);
            this.coldsProcessL3DataTableTundish_Level_Mold.Namespace = "";
            // 
            // coldsProcessL3DataTablePlugBar_Control
            // 
            this.coldsProcessL3DataTablePlugBar_Control.Caption = "PlugBar_Control";
            this.coldsProcessL3DataTablePlugBar_Control.ColumnName = "PlugBar_Control";
            this.coldsProcessL3DataTablePlugBar_Control.Namespace = "";
            // 
            // coldsProcessL3DataTableSoft_Press_Flag_1
            // 
            this.coldsProcessL3DataTableSoft_Press_Flag_1.Caption = "Soft_Press_Flag_1";
            this.coldsProcessL3DataTableSoft_Press_Flag_1.ColumnName = "Soft_Press_Flag_1";
            this.coldsProcessL3DataTableSoft_Press_Flag_1.Namespace = "";
            // 
            // coldsProcessL3DataTableSoft_Press_Flag_2
            // 
            this.coldsProcessL3DataTableSoft_Press_Flag_2.Caption = "Soft_Press_Flag_2";
            this.coldsProcessL3DataTableSoft_Press_Flag_2.ColumnName = "Soft_Press_Flag_2";
            this.coldsProcessL3DataTableSoft_Press_Flag_2.Namespace = "";
            // 
            // coldsProcessL3DataTableSoft_Press_Flag_3
            // 
            this.coldsProcessL3DataTableSoft_Press_Flag_3.Caption = "Soft_Press_Flag_3";
            this.coldsProcessL3DataTableSoft_Press_Flag_3.ColumnName = "Soft_Press_Flag_3";
            this.coldsProcessL3DataTableSoft_Press_Flag_3.Namespace = "";
            // 
            // coldsProcessL3DataTableSoft_Press_Flag_4
            // 
            this.coldsProcessL3DataTableSoft_Press_Flag_4.Caption = "Soft_Press_Flag_4";
            this.coldsProcessL3DataTableSoft_Press_Flag_4.ColumnName = "Soft_Press_Flag_4";
            this.coldsProcessL3DataTableSoft_Press_Flag_4.Namespace = "";
            // 
            // coldsProcessL3DataTableSpeedChange
            // 
            this.coldsProcessL3DataTableSpeedChange.Caption = "SpeedChange";
            this.coldsProcessL3DataTableSpeedChange.ColumnName = "SpeedChange";
            this.coldsProcessL3DataTableSpeedChange.Namespace = "";
            // 
            // coldsProcessL3DataTableSpeedChange_Reason
            // 
            this.coldsProcessL3DataTableSpeedChange_Reason.Caption = "SpeedChange_Reason";
            this.coldsProcessL3DataTableSpeedChange_Reason.ColumnName = "SpeedChange_Reason";
            this.coldsProcessL3DataTableSpeedChange_Reason.Namespace = "";
            // 
            // coldsProcessL3DataTableSpeedChange_Detailed
            // 
            this.coldsProcessL3DataTableSpeedChange_Detailed.Caption = "SpeedChange_Detailed";
            this.coldsProcessL3DataTableSpeedChange_Detailed.ColumnName = "SpeedChange_Detailed";
            this.coldsProcessL3DataTableSpeedChange_Detailed.Namespace = "";
            // 
            // coldsProcessL3DataTableBefore_Casting_Tundish_Temp
            // 
            this.coldsProcessL3DataTableBefore_Casting_Tundish_Temp.Caption = "Before_Casting_Tundish_Temp";
            this.coldsProcessL3DataTableBefore_Casting_Tundish_Temp.ColumnName = "Before_Casting_Tundish_Temp";
            this.coldsProcessL3DataTableBefore_Casting_Tundish_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableBefore_Casting_Tundish_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1
            // 
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1.Caption = "Before_Casting_Shuikou_Temp1";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1.ColumnName = "Before_Casting_Shuikou_Temp1";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1.DataType = typeof(int);
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1.Namespace = "";
            // 
            // coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2
            // 
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2.Caption = "Before_Casting_Shuikou_Temp2";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2.ColumnName = "Before_Casting_Shuikou_Temp2";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2.DataType = typeof(int);
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2.Namespace = "";
            // 
            // coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3
            // 
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3.Caption = "Before_Casting_Shuikou_Temp3";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3.ColumnName = "Before_Casting_Shuikou_Temp3";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3.DataType = typeof(int);
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3.Namespace = "";
            // 
            // coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4
            // 
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4.Caption = "Before_Casting_Shuikou_Temp4";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4.ColumnName = "Before_Casting_Shuikou_Temp4";
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4.DataType = typeof(int);
            this.coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4.Namespace = "";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(97, 249);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(83, 12);
            this.label72.TabIndex = 157;
            this.label72.Text = "调速详细备注:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(375, 272);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(83, 12);
            this.label52.TabIndex = 155;
            this.label52.Text = "拉速调整原因:";
            // 
            // cmbChangeReason
            // 
            this.cmbChangeReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "SpeedChange_Reason", true));
            this.cmbChangeReason.FormattingEnabled = true;
            this.cmbChangeReason.Items.AddRange(new object[] {
            "温高降速",
            "温低提速",
            "节奏调速",
            "其它调速"});
            this.cmbChangeReason.Location = new System.Drawing.Point(464, 269);
            this.cmbChangeReason.Name = "cmbChangeReason";
            this.cmbChangeReason.Size = new System.Drawing.Size(144, 20);
            this.cmbChangeReason.TabIndex = 154;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(738, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 21);
            this.textBox1.TabIndex = 153;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(684, 52);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(47, 12);
            this.label51.TabIndex = 152;
            this.label51.Text = "中包号:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(618, 189);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 12);
            this.label26.TabIndex = 151;
            this.label26.Text = "3流轻压下是否投用:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(375, 245);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 151;
            this.label27.Text = "拉速是否调整:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(399, 215);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 151;
            this.label23.Text = "塞棒控制:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(363, 187);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 12);
            this.label17.TabIndex = 151;
            this.label17.Text = "中包壁温度[℃]:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(618, 162);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 12);
            this.label25.TabIndex = 151;
            this.label25.Text = "2流轻压下是否投用:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(618, 353);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(113, 12);
            this.label80.TabIndex = 151;
            this.label80.Text = "开浇前4流水口温度:";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(618, 327);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(113, 12);
            this.label79.TabIndex = 151;
            this.label79.Text = "开浇前3流水口温度:";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(618, 301);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(113, 12);
            this.label78.TabIndex = 151;
            this.label78.Text = "开浇前2流水口温度:";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(618, 277);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(113, 12);
            this.label77.TabIndex = 151;
            this.label77.Text = "开浇前1流水口温度:";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(636, 250);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(95, 12);
            this.label76.TabIndex = 151;
            this.label76.Text = "开浇前中包温度:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(618, 216);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 12);
            this.label21.TabIndex = 151;
            this.label21.Text = "4流轻压下是否投用:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(363, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 12);
            this.label16.TabIndex = 151;
            this.label16.Text = "中包底温度[℃]:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(618, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(113, 12);
            this.label24.TabIndex = 150;
            this.label24.Text = "1流轻压下是否投用:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 12);
            this.label18.TabIndex = 150;
            this.label18.Text = "中包液面[mm]/中包重量[T]:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(73, 160);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(107, 12);
            this.lb.TabIndex = 150;
            this.lb.Text = "中包渣层厚度[mm]:";
            // 
            // cmbSecondCoolingMode
            // 
            this.cmbSecondCoolingMode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "Second_Cooling_Mode", true));
            this.cmbSecondCoolingMode.DataSource = this.dsSecondCoolingMode;
            this.cmbSecondCoolingMode.DisplayMember = "L3DataTable.Code_Des";
            this.cmbSecondCoolingMode.Enabled = false;
            this.cmbSecondCoolingMode.FormattingEnabled = true;
            this.cmbSecondCoolingMode.Location = new System.Drawing.Point(737, 77);
            this.cmbSecondCoolingMode.Name = "cmbSecondCoolingMode";
            this.cmbSecondCoolingMode.Size = new System.Drawing.Size(144, 20);
            this.cmbSecondCoolingMode.TabIndex = 149;
            this.cmbSecondCoolingMode.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsSecondCoolingMode
            // 
            this.dsSecondCoolingMode.AutoLoad = true;
            this.dsSecondCoolingMode.AutoSubscribe = false;
            this.dsSecondCoolingMode.DataSetName = "L3DataSet";
            this.dsSecondCoolingMode.DeleteMethod = "";
            this.dsSecondCoolingMode.InsertMethod = "";
            this.dsSecondCoolingMode.L3DataAdapter = this.Adapter;
            this.dsSecondCoolingMode.LoadEvent = "";
            this.dsSecondCoolingMode.LoadTrigger = null;
            this.dsSecondCoolingMode.RefreshValve = 1000;
            this.dsSecondCoolingMode.SourceCommand = null;
            this.dsSecondCoolingMode.SourceCondition = "CODE_GROUP = \'Second_Cooling_Mode\' and code is not null order by code";
            this.dsSecondCoolingMode.SourceMethod = "";
            this.dsSecondCoolingMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSecondCoolingMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSecondCoolingMode.SubscribeTarget = null;
            this.dsSecondCoolingMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSecondCoolingMode});
            this.dsSecondCoolingMode.UpdateEvent = "";
            this.dsSecondCoolingMode.UpdateMethod = "";
            this.dsSecondCoolingMode.UpdateTrigger = null;
            // 
            // schemadsSecondCoolingMode
            // 
            this.schemadsSecondCoolingMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSecondCoolingModeL3DataTableCode_Des,
            this.coldsSecondCoolingModeL3DataTableCode_Val_Long});
            this.schemadsSecondCoolingMode.TableName = "L3DataTable";
            // 
            // coldsSecondCoolingModeL3DataTableCode_Des
            // 
            this.coldsSecondCoolingModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSecondCoolingModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSecondCoolingModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsSecondCoolingModeL3DataTableCode_Val_Long
            // 
            this.coldsSecondCoolingModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsSecondCoolingModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsSecondCoolingModeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsSecondCoolingModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // cmbInjectionBar_BlowAr
            // 
            this.cmbInjectionBar_BlowAr.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "InjectionBar_BlowAr", true));
            this.cmbInjectionBar_BlowAr.DataSource = this.dsYesNo;
            this.cmbInjectionBar_BlowAr.DisplayMember = "L3DataTable.Code_Des";
            this.cmbInjectionBar_BlowAr.Enabled = false;
            this.cmbInjectionBar_BlowAr.FormattingEnabled = true;
            this.cmbInjectionBar_BlowAr.Location = new System.Drawing.Point(464, 75);
            this.cmbInjectionBar_BlowAr.Name = "cmbInjectionBar_BlowAr";
            this.cmbInjectionBar_BlowAr.Size = new System.Drawing.Size(144, 20);
            this.cmbInjectionBar_BlowAr.TabIndex = 148;
            this.cmbInjectionBar_BlowAr.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsYesNo
            // 
            this.dsYesNo.AutoLoad = true;
            this.dsYesNo.AutoSubscribe = false;
            this.dsYesNo.DataSetName = "L3DataSet";
            this.dsYesNo.DeleteMethod = "";
            this.dsYesNo.InsertMethod = "";
            this.dsYesNo.L3DataAdapter = this.Adapter;
            this.dsYesNo.LoadEvent = "";
            this.dsYesNo.LoadTrigger = null;
            this.dsYesNo.RefreshValve = 1000;
            this.dsYesNo.SourceCommand = null;
            this.dsYesNo.SourceCondition = "Code_Group = \'COMMON_YESNO\' and code is not null order by code";
            this.dsYesNo.SourceMethod = "";
            this.dsYesNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsYesNo.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsYesNo.SubscribeTarget = null;
            this.dsYesNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsYesNo});
            this.dsYesNo.UpdateEvent = "";
            this.dsYesNo.UpdateMethod = "";
            this.dsYesNo.UpdateTrigger = null;
            // 
            // schemadsYesNo
            // 
            this.schemadsYesNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsYesNoL3DataTableCode_Des,
            this.coldsYesNoL3DataTableCode_Val_Long});
            this.schemadsYesNo.TableName = "L3DataTable";
            // 
            // coldsYesNoL3DataTableCode_Des
            // 
            this.coldsYesNoL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.Namespace = "";
            // 
            // coldsYesNoL3DataTableCode_Val_Long
            // 
            this.coldsYesNoL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsYesNoL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsYesNoL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsYesNoL3DataTableCode_Val_Long.Namespace = "";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "TundishCar_Type", true));
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            ""});
            this.comboBox3.Location = new System.Drawing.Point(737, 21);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(144, 20);
            this.comboBox3.TabIndex = 147;
            // 
            // cmbSoftPressFlag2
            // 
            this.cmbSoftPressFlag2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_2", true));
            this.cmbSoftPressFlag2.FormattingEnabled = true;
            this.cmbSoftPressFlag2.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbSoftPressFlag2.Location = new System.Drawing.Point(737, 159);
            this.cmbSoftPressFlag2.Name = "cmbSoftPressFlag2";
            this.cmbSoftPressFlag2.Size = new System.Drawing.Size(144, 20);
            this.cmbSoftPressFlag2.TabIndex = 147;
            // 
            // cmbSoftPressFlag4
            // 
            this.cmbSoftPressFlag4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_4", true));
            this.cmbSoftPressFlag4.FormattingEnabled = true;
            this.cmbSoftPressFlag4.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbSoftPressFlag4.Location = new System.Drawing.Point(737, 213);
            this.cmbSoftPressFlag4.Name = "cmbSoftPressFlag4";
            this.cmbSoftPressFlag4.Size = new System.Drawing.Size(144, 20);
            this.cmbSoftPressFlag4.TabIndex = 147;
            // 
            // cmbSoftPressFlag1
            // 
            this.cmbSoftPressFlag1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_1", true));
            this.cmbSoftPressFlag1.FormattingEnabled = true;
            this.cmbSoftPressFlag1.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbSoftPressFlag1.Location = new System.Drawing.Point(737, 132);
            this.cmbSoftPressFlag1.Name = "cmbSoftPressFlag1";
            this.cmbSoftPressFlag1.Size = new System.Drawing.Size(144, 20);
            this.cmbSoftPressFlag1.TabIndex = 147;
            // 
            // cmbSoftPressFlag3
            // 
            this.cmbSoftPressFlag3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_3", true));
            this.cmbSoftPressFlag3.FormattingEnabled = true;
            this.cmbSoftPressFlag3.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbSoftPressFlag3.Location = new System.Drawing.Point(737, 186);
            this.cmbSoftPressFlag3.Name = "cmbSoftPressFlag3";
            this.cmbSoftPressFlag3.Size = new System.Drawing.Size(144, 20);
            this.cmbSoftPressFlag3.TabIndex = 147;
            // 
            // cmbSpeedChange
            // 
            this.cmbSpeedChange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "SpeedChange", true));
            this.cmbSpeedChange.FormattingEnabled = true;
            this.cmbSpeedChange.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbSpeedChange.Location = new System.Drawing.Point(464, 242);
            this.cmbSpeedChange.Name = "cmbSpeedChange";
            this.cmbSpeedChange.Size = new System.Drawing.Size(144, 20);
            this.cmbSpeedChange.TabIndex = 147;
            // 
            // cmbPlugBarControl
            // 
            this.cmbPlugBarControl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "PlugBar_Control", true));
            this.cmbPlugBarControl.Enabled = false;
            this.cmbPlugBarControl.FormattingEnabled = true;
            this.cmbPlugBarControl.Items.AddRange(new object[] {
            "自动",
            "手动"});
            this.cmbPlugBarControl.Location = new System.Drawing.Point(464, 212);
            this.cmbPlugBarControl.Name = "cmbPlugBarControl";
            this.cmbPlugBarControl.Size = new System.Drawing.Size(144, 20);
            this.cmbPlugBarControl.TabIndex = 147;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "Weight_Return_Reason", true));
            this.comboBox4.DataSource = this.dsReturn_Reason;
            this.comboBox4.DisplayMember = "L3DataTable.Code_Des";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(464, 128);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(144, 20);
            this.comboBox4.TabIndex = 147;
            this.comboBox4.ValueMember = "L3DataTable.Code";
            // 
            // dsReturn_Reason
            // 
            this.dsReturn_Reason.AutoLoad = true;
            this.dsReturn_Reason.AutoSubscribe = false;
            this.dsReturn_Reason.DataSetName = "L3DataSet";
            this.dsReturn_Reason.DeleteMethod = null;
            this.dsReturn_Reason.InsertMethod = null;
            this.dsReturn_Reason.L3DataAdapter = this.Adapter;
            this.dsReturn_Reason.LoadEvent = "Click";
            this.dsReturn_Reason.LoadTrigger = null;
            this.dsReturn_Reason.RefreshValve = 1000;
            this.dsReturn_Reason.SourceCommand = null;
            this.dsReturn_Reason.SourceCondition = "Code_Group = \'CCM_Pro_Return_Reason\'";
            this.dsReturn_Reason.SourceMethod = "";
            this.dsReturn_Reason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsReturn_Reason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsReturn_Reason.SubscribeTarget = null;
            this.dsReturn_Reason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsReturn_Reason});
            this.dsReturn_Reason.UpdateEvent = "Click";
            this.dsReturn_Reason.UpdateMethod = null;
            this.dsReturn_Reason.UpdateTrigger = null;
            // 
            // schemadsReturn_Reason
            // 
            this.schemadsReturn_Reason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsReturn_ReasonL3DataTableCode,
            this.coldsReturn_ReasonL3DataTableCode_Des});
            this.schemadsReturn_Reason.TableName = "L3DataTable";
            // 
            // coldsReturn_ReasonL3DataTableCode
            // 
            this.coldsReturn_ReasonL3DataTableCode.Caption = "Code";
            this.coldsReturn_ReasonL3DataTableCode.ColumnName = "Code";
            this.coldsReturn_ReasonL3DataTableCode.Namespace = "";
            // 
            // coldsReturn_ReasonL3DataTableCode_Des
            // 
            this.coldsReturn_ReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsReturn_ReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsReturn_ReasonL3DataTableCode_Des.Namespace = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "CastingStopTime", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker1.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 146;
            this.label1.Text = "停浇时间:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "CastingStartTime", true));
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(186, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker2.TabIndex = 144;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(121, 52);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 12);
            this.label39.TabIndex = 146;
            this.label39.Text = "开浇时间:";
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_HeatNum", true));
            this.pxTextBox4.DisplayPrecision = 0;
            this.pxTextBox4.EnableNull = true;
            this.pxTextBox4.ErropPr = null;
            this.pxTextBox4.FixedLength = 0;
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(464, 48);
            this.pxTextBox4.Max = 0D;
            this.pxTextBox4.MaxNull = 0D;
            this.pxTextBox4.MaxStringLength = 0;
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0D;
            this.pxTextBox4.MinNull = 0D;
            this.pxTextBox4.MinStringLength = 0;
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            this.pxTextBox4.ReadOnly = true;
            this.pxTextBox4.Regex = "";
            this.pxTextBox4.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox4.TabIndex = 142;
            this.pxTextBox4.ToolTipValid = null;
            this.pxTextBox4.VaildWarning = "";
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.pxTextBox4.TextChanged += new System.EventHandler(this.pxTextBox4_TextChanged);
            // 
            // txtTundishBottomTemp
            // 
            this.txtTundishBottomTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_Bottom_Temp", true));
            this.txtTundishBottomTemp.DisplayPrecision = 0;
            this.txtTundishBottomTemp.EnableNull = true;
            this.txtTundishBottomTemp.ErropPr = null;
            this.txtTundishBottomTemp.FixedLength = 0;
            this.txtTundishBottomTemp.Length = 0;
            this.txtTundishBottomTemp.Location = new System.Drawing.Point(464, 154);
            this.txtTundishBottomTemp.Max = 0D;
            this.txtTundishBottomTemp.MaxNull = 0D;
            this.txtTundishBottomTemp.MaxStringLength = 0;
            this.txtTundishBottomTemp.MaxStrLength = 0;
            this.txtTundishBottomTemp.Min = 0D;
            this.txtTundishBottomTemp.MinNull = 0D;
            this.txtTundishBottomTemp.MinStringLength = 0;
            this.txtTundishBottomTemp.MinStrLength = 0;
            this.txtTundishBottomTemp.Name = "txtTundishBottomTemp";
            this.txtTundishBottomTemp.Precision = 0;
            this.txtTundishBottomTemp.Regex = "";
            this.txtTundishBottomTemp.Size = new System.Drawing.Size(144, 21);
            this.txtTundishBottomTemp.TabIndex = 142;
            this.txtTundishBottomTemp.ToolTipValid = null;
            this.txtTundishBottomTemp.VaildWarning = "";
            this.txtTundishBottomTemp.ValidEable = true;
            this.txtTundishBottomTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // ptbShuikou_Temp4
            // 
            this.ptbShuikou_Temp4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Before_Casting_Shuikou_Temp4", true));
            this.ptbShuikou_Temp4.DisplayPrecision = 0;
            this.ptbShuikou_Temp4.EnableNull = true;
            this.ptbShuikou_Temp4.ErropPr = null;
            this.ptbShuikou_Temp4.FixedLength = 0;
            this.ptbShuikou_Temp4.Length = 0;
            this.ptbShuikou_Temp4.Location = new System.Drawing.Point(738, 350);
            this.ptbShuikou_Temp4.Max = 0D;
            this.ptbShuikou_Temp4.MaxNull = 0D;
            this.ptbShuikou_Temp4.MaxStringLength = 0;
            this.ptbShuikou_Temp4.MaxStrLength = 0;
            this.ptbShuikou_Temp4.Min = 0D;
            this.ptbShuikou_Temp4.MinNull = 0D;
            this.ptbShuikou_Temp4.MinStringLength = 0;
            this.ptbShuikou_Temp4.MinStrLength = 0;
            this.ptbShuikou_Temp4.Name = "ptbShuikou_Temp4";
            this.ptbShuikou_Temp4.Precision = 0;
            this.ptbShuikou_Temp4.Regex = "";
            this.ptbShuikou_Temp4.Size = new System.Drawing.Size(144, 21);
            this.ptbShuikou_Temp4.TabIndex = 142;
            this.ptbShuikou_Temp4.ToolTipValid = null;
            this.ptbShuikou_Temp4.VaildWarning = "";
            this.ptbShuikou_Temp4.ValidEable = true;
            this.ptbShuikou_Temp4.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // ptbShuikou_Temp3
            // 
            this.ptbShuikou_Temp3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Before_Casting_Shuikou_Temp3", true));
            this.ptbShuikou_Temp3.DisplayPrecision = 0;
            this.ptbShuikou_Temp3.EnableNull = true;
            this.ptbShuikou_Temp3.ErropPr = null;
            this.ptbShuikou_Temp3.FixedLength = 0;
            this.ptbShuikou_Temp3.Length = 0;
            this.ptbShuikou_Temp3.Location = new System.Drawing.Point(738, 324);
            this.ptbShuikou_Temp3.Max = 0D;
            this.ptbShuikou_Temp3.MaxNull = 0D;
            this.ptbShuikou_Temp3.MaxStringLength = 0;
            this.ptbShuikou_Temp3.MaxStrLength = 0;
            this.ptbShuikou_Temp3.Min = 0D;
            this.ptbShuikou_Temp3.MinNull = 0D;
            this.ptbShuikou_Temp3.MinStringLength = 0;
            this.ptbShuikou_Temp3.MinStrLength = 0;
            this.ptbShuikou_Temp3.Name = "ptbShuikou_Temp3";
            this.ptbShuikou_Temp3.Precision = 0;
            this.ptbShuikou_Temp3.Regex = "";
            this.ptbShuikou_Temp3.Size = new System.Drawing.Size(144, 21);
            this.ptbShuikou_Temp3.TabIndex = 142;
            this.ptbShuikou_Temp3.ToolTipValid = null;
            this.ptbShuikou_Temp3.VaildWarning = "";
            this.ptbShuikou_Temp3.ValidEable = true;
            this.ptbShuikou_Temp3.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // ptbShuikou_Temp2
            // 
            this.ptbShuikou_Temp2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Before_Casting_Shuikou_Temp2", true));
            this.ptbShuikou_Temp2.DisplayPrecision = 0;
            this.ptbShuikou_Temp2.EnableNull = true;
            this.ptbShuikou_Temp2.ErropPr = null;
            this.ptbShuikou_Temp2.FixedLength = 0;
            this.ptbShuikou_Temp2.Length = 0;
            this.ptbShuikou_Temp2.Location = new System.Drawing.Point(738, 298);
            this.ptbShuikou_Temp2.Max = 0D;
            this.ptbShuikou_Temp2.MaxNull = 0D;
            this.ptbShuikou_Temp2.MaxStringLength = 0;
            this.ptbShuikou_Temp2.MaxStrLength = 0;
            this.ptbShuikou_Temp2.Min = 0D;
            this.ptbShuikou_Temp2.MinNull = 0D;
            this.ptbShuikou_Temp2.MinStringLength = 0;
            this.ptbShuikou_Temp2.MinStrLength = 0;
            this.ptbShuikou_Temp2.Name = "ptbShuikou_Temp2";
            this.ptbShuikou_Temp2.Precision = 0;
            this.ptbShuikou_Temp2.Regex = "";
            this.ptbShuikou_Temp2.Size = new System.Drawing.Size(144, 21);
            this.ptbShuikou_Temp2.TabIndex = 142;
            this.ptbShuikou_Temp2.ToolTipValid = null;
            this.ptbShuikou_Temp2.VaildWarning = "";
            this.ptbShuikou_Temp2.ValidEable = true;
            this.ptbShuikou_Temp2.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // ptbShuikou_Temp1
            // 
            this.ptbShuikou_Temp1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Before_Casting_Shuikou_Temp1", true));
            this.ptbShuikou_Temp1.DisplayPrecision = 0;
            this.ptbShuikou_Temp1.EnableNull = true;
            this.ptbShuikou_Temp1.ErropPr = null;
            this.ptbShuikou_Temp1.FixedLength = 0;
            this.ptbShuikou_Temp1.Length = 0;
            this.ptbShuikou_Temp1.Location = new System.Drawing.Point(738, 272);
            this.ptbShuikou_Temp1.Max = 0D;
            this.ptbShuikou_Temp1.MaxNull = 0D;
            this.ptbShuikou_Temp1.MaxStringLength = 0;
            this.ptbShuikou_Temp1.MaxStrLength = 0;
            this.ptbShuikou_Temp1.Min = 0D;
            this.ptbShuikou_Temp1.MinNull = 0D;
            this.ptbShuikou_Temp1.MinStringLength = 0;
            this.ptbShuikou_Temp1.MinStrLength = 0;
            this.ptbShuikou_Temp1.Name = "ptbShuikou_Temp1";
            this.ptbShuikou_Temp1.Precision = 0;
            this.ptbShuikou_Temp1.Regex = "";
            this.ptbShuikou_Temp1.Size = new System.Drawing.Size(144, 21);
            this.ptbShuikou_Temp1.TabIndex = 142;
            this.ptbShuikou_Temp1.ToolTipValid = null;
            this.ptbShuikou_Temp1.VaildWarning = "";
            this.ptbShuikou_Temp1.ValidEable = true;
            this.ptbShuikou_Temp1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // ptbBef_tundish_temp
            // 
            this.ptbBef_tundish_temp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Before_Casting_Tundish_Temp", true));
            this.ptbBef_tundish_temp.DisplayPrecision = 0;
            this.ptbBef_tundish_temp.EnableNull = true;
            this.ptbBef_tundish_temp.ErropPr = null;
            this.ptbBef_tundish_temp.FixedLength = 0;
            this.ptbBef_tundish_temp.Length = 0;
            this.ptbBef_tundish_temp.Location = new System.Drawing.Point(738, 246);
            this.ptbBef_tundish_temp.Max = 0D;
            this.ptbBef_tundish_temp.MaxNull = 0D;
            this.ptbBef_tundish_temp.MaxStringLength = 0;
            this.ptbBef_tundish_temp.MaxStrLength = 0;
            this.ptbBef_tundish_temp.Min = 0D;
            this.ptbBef_tundish_temp.MinNull = 0D;
            this.ptbBef_tundish_temp.MinStringLength = 0;
            this.ptbBef_tundish_temp.MinStrLength = 0;
            this.ptbBef_tundish_temp.Name = "ptbBef_tundish_temp";
            this.ptbBef_tundish_temp.Precision = 0;
            this.ptbBef_tundish_temp.Regex = "";
            this.ptbBef_tundish_temp.Size = new System.Drawing.Size(144, 21);
            this.ptbBef_tundish_temp.TabIndex = 142;
            this.ptbBef_tundish_temp.ToolTipValid = null;
            this.ptbBef_tundish_temp.VaildWarning = "";
            this.ptbBef_tundish_temp.ValidEable = true;
            this.ptbBef_tundish_temp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTundishLevelMold
            // 
            this.txtTundishLevelMold.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_Level_Mold", true));
            this.txtTundishLevelMold.DisplayPrecision = 0;
            this.txtTundishLevelMold.EnableNull = true;
            this.txtTundishLevelMold.ErropPr = null;
            this.txtTundishLevelMold.FixedLength = 0;
            this.txtTundishLevelMold.Length = 0;
            this.txtTundishLevelMold.Location = new System.Drawing.Point(186, 183);
            this.txtTundishLevelMold.Max = 0D;
            this.txtTundishLevelMold.MaxNull = 0D;
            this.txtTundishLevelMold.MaxStringLength = 0;
            this.txtTundishLevelMold.MaxStrLength = 0;
            this.txtTundishLevelMold.Min = 0D;
            this.txtTundishLevelMold.MinNull = 0D;
            this.txtTundishLevelMold.MinStringLength = 0;
            this.txtTundishLevelMold.MinStrLength = 0;
            this.txtTundishLevelMold.Name = "txtTundishLevelMold";
            this.txtTundishLevelMold.Precision = 0;
            this.txtTundishLevelMold.Regex = "";
            this.txtTundishLevelMold.Size = new System.Drawing.Size(144, 21);
            this.txtTundishLevelMold.TabIndex = 142;
            this.txtTundishLevelMold.ToolTipValid = null;
            this.txtTundishLevelMold.VaildWarning = "";
            this.txtTundishLevelMold.ValidEable = true;
            this.txtTundishLevelMold.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTundishSlagThickness
            // 
            this.txtTundishSlagThickness.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_SlagThickness", true));
            this.txtTundishSlagThickness.DisplayPrecision = 0;
            this.txtTundishSlagThickness.EnableNull = true;
            this.txtTundishSlagThickness.ErropPr = null;
            this.txtTundishSlagThickness.FixedLength = 0;
            this.txtTundishSlagThickness.Length = 0;
            this.txtTundishSlagThickness.Location = new System.Drawing.Point(186, 156);
            this.txtTundishSlagThickness.Max = 0D;
            this.txtTundishSlagThickness.MaxNull = 0D;
            this.txtTundishSlagThickness.MaxStringLength = 0;
            this.txtTundishSlagThickness.MaxStrLength = 0;
            this.txtTundishSlagThickness.Min = 0D;
            this.txtTundishSlagThickness.MinNull = 0D;
            this.txtTundishSlagThickness.MinStringLength = 0;
            this.txtTundishSlagThickness.MinStrLength = 0;
            this.txtTundishSlagThickness.Name = "txtTundishSlagThickness";
            this.txtTundishSlagThickness.Precision = 0;
            this.txtTundishSlagThickness.Regex = "";
            this.txtTundishSlagThickness.Size = new System.Drawing.Size(144, 21);
            this.txtTundishSlagThickness.TabIndex = 142;
            this.txtTundishSlagThickness.ToolTipValid = null;
            this.txtTundishSlagThickness.VaildWarning = "";
            this.txtTundishSlagThickness.ValidEable = true;
            this.txtTundishSlagThickness.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Casting_HeatNum", true));
            this.pxTextBox3.DisplayPrecision = 0;
            this.pxTextBox3.EnableNull = true;
            this.pxTextBox3.ErropPr = null;
            this.pxTextBox3.FixedLength = 0;
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(186, 129);
            this.pxTextBox3.Max = 0D;
            this.pxTextBox3.MaxNull = 0D;
            this.pxTextBox3.MaxStringLength = 0;
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0D;
            this.pxTextBox3.MinNull = 0D;
            this.pxTextBox3.MinStringLength = 0;
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            this.pxTextBox3.ReadOnly = true;
            this.pxTextBox3.Regex = "";
            this.pxTextBox3.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox3.TabIndex = 142;
            this.pxTextBox3.ToolTipValid = null;
            this.pxTextBox3.VaildWarning = "";
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTundishNo
            // 
            this.txtTundishNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "TundishNo", true));
            this.txtTundishNo.DisplayPrecision = 0;
            this.txtTundishNo.EnableNull = true;
            this.txtTundishNo.ErropPr = null;
            this.txtTundishNo.FixedLength = 0;
            this.txtTundishNo.Length = 0;
            this.txtTundishNo.Location = new System.Drawing.Point(464, 21);
            this.txtTundishNo.Max = 0D;
            this.txtTundishNo.MaxNull = 0D;
            this.txtTundishNo.MaxStringLength = 0;
            this.txtTundishNo.MaxStrLength = 0;
            this.txtTundishNo.Min = 0D;
            this.txtTundishNo.MinNull = 0D;
            this.txtTundishNo.MinStringLength = 0;
            this.txtTundishNo.MinStrLength = 0;
            this.txtTundishNo.Name = "txtTundishNo";
            this.txtTundishNo.Precision = 0;
            this.txtTundishNo.ReadOnly = true;
            this.txtTundishNo.Regex = "";
            this.txtTundishNo.Size = new System.Drawing.Size(144, 21);
            this.txtTundishNo.TabIndex = 142;
            this.txtTundishNo.ToolTipValid = null;
            this.txtTundishNo.VaildWarning = "";
            this.txtTundishNo.ValidEable = true;
            this.txtTundishNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtTundishNo.TextChanged += new System.EventHandler(this.txtTundishNo_TextChanged);
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "CCMID", true));
            this.pxTextBox1.DisplayPrecision = 0;
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.FixedLength = 0;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(186, 21);
            this.pxTextBox1.Max = 0D;
            this.pxTextBox1.MaxNull = 0D;
            this.pxTextBox1.MaxStringLength = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0D;
            this.pxTextBox1.MinNull = 0D;
            this.pxTextBox1.MinStringLength = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.ReadOnly = true;
            this.pxTextBox1.Regex = "";
            this.pxTextBox1.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox1.TabIndex = 142;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.VaildWarning = "";
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 141;
            this.label14.Text = "包次内炉数:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 141;
            this.label13.Text = "浇次内炉数:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 141;
            this.label12.Text = "包次号:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 141;
            this.label11.Text = "铸机号:";
            // 
            // txtTundishWallTemp
            // 
            this.txtTundishWallTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_Wall_Temp", true));
            this.txtTundishWallTemp.DisplayPrecision = 0;
            this.txtTundishWallTemp.EnableNull = true;
            this.txtTundishWallTemp.ErropPr = null;
            this.txtTundishWallTemp.FixedLength = 0;
            this.txtTundishWallTemp.Length = 0;
            this.txtTundishWallTemp.Location = new System.Drawing.Point(464, 181);
            this.txtTundishWallTemp.Max = 0D;
            this.txtTundishWallTemp.MaxNull = 0D;
            this.txtTundishWallTemp.MaxStringLength = 0;
            this.txtTundishWallTemp.MaxStrLength = 0;
            this.txtTundishWallTemp.Min = 0D;
            this.txtTundishWallTemp.MinNull = 0D;
            this.txtTundishWallTemp.MinStringLength = 0;
            this.txtTundishWallTemp.MinStrLength = 0;
            this.txtTundishWallTemp.Name = "txtTundishWallTemp";
            this.txtTundishWallTemp.Precision = 0;
            this.txtTundishWallTemp.Regex = "";
            this.txtTundishWallTemp.Size = new System.Drawing.Size(144, 21);
            this.txtTundishWallTemp.TabIndex = 139;
            this.txtTundishWallTemp.ToolTipValid = null;
            this.txtTundishWallTemp.VaildWarning = "";
            this.txtTundishWallTemp.ValidEable = true;
            this.txtTundishWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox36
            // 
            this.pxTextBox36.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Second_Cooling_CurveNo", true));
            this.pxTextBox36.DisplayPrecision = 0;
            this.pxTextBox36.EnableNull = true;
            this.pxTextBox36.ErropPr = null;
            this.pxTextBox36.FixedLength = 0;
            this.pxTextBox36.Length = 0;
            this.pxTextBox36.Location = new System.Drawing.Point(737, 104);
            this.pxTextBox36.Max = 0D;
            this.pxTextBox36.MaxNull = 0D;
            this.pxTextBox36.MaxStringLength = 0;
            this.pxTextBox36.MaxStrLength = 0;
            this.pxTextBox36.Min = 0D;
            this.pxTextBox36.MinNull = 0D;
            this.pxTextBox36.MinStringLength = 0;
            this.pxTextBox36.MinStrLength = 0;
            this.pxTextBox36.Name = "pxTextBox36";
            this.pxTextBox36.Precision = 0;
            this.pxTextBox36.ReadOnly = true;
            this.pxTextBox36.Regex = "";
            this.pxTextBox36.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox36.TabIndex = 139;
            this.pxTextBox36.ToolTipValid = null;
            this.pxTextBox36.VaildWarning = "";
            this.pxTextBox36.ValidEable = true;
            this.pxTextBox36.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox34
            // 
            this.pxTextBox34.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Weight_Return", true));
            this.pxTextBox34.DisplayPrecision = 0;
            this.pxTextBox34.EnableNull = true;
            this.pxTextBox34.ErropPr = null;
            this.pxTextBox34.FixedLength = 0;
            this.pxTextBox34.Length = 0;
            this.pxTextBox34.Location = new System.Drawing.Point(464, 101);
            this.pxTextBox34.Max = 0D;
            this.pxTextBox34.MaxNull = 0D;
            this.pxTextBox34.MaxStringLength = 0;
            this.pxTextBox34.MaxStrLength = 0;
            this.pxTextBox34.Min = 0D;
            this.pxTextBox34.MinNull = 0D;
            this.pxTextBox34.MinStringLength = 0;
            this.pxTextBox34.MinStrLength = 0;
            this.pxTextBox34.Name = "pxTextBox34";
            this.pxTextBox34.Precision = 0;
            this.pxTextBox34.Regex = "";
            this.pxTextBox34.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox34.TabIndex = 139;
            this.pxTextBox34.ToolTipValid = null;
            this.pxTextBox34.VaildWarning = "";
            this.pxTextBox34.ValidEable = true;
            this.pxTextBox34.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(397, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 140;
            this.label15.Text = "回炉原因:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 140;
            this.label3.Text = "中包车别:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(648, 108);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(83, 12);
            this.label50.TabIndex = 140;
            this.label50.Text = "二冷水水表号:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(660, 81);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(71, 12);
            this.label49.TabIndex = 140;
            this.label49.Text = "二冷水模式:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(367, 106);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(89, 12);
            this.label48.TabIndex = 140;
            this.label48.Text = "回炉钢水量[t]:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(375, 79);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(83, 12);
            this.label43.TabIndex = 140;
            this.label43.Text = "是否塞棒吹氩:";
            // 
            // txtCastingNo
            // 
            this.txtCastingNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "CastingNo", true));
            this.txtCastingNo.DisplayPrecision = 0;
            this.txtCastingNo.EnableNull = true;
            this.txtCastingNo.ErropPr = null;
            this.txtCastingNo.FixedLength = 0;
            this.txtCastingNo.Length = 0;
            this.txtCastingNo.Location = new System.Drawing.Point(186, 102);
            this.txtCastingNo.Max = 0D;
            this.txtCastingNo.MaxNull = 0D;
            this.txtCastingNo.MaxStringLength = 0;
            this.txtCastingNo.MaxStrLength = 0;
            this.txtCastingNo.Min = 0D;
            this.txtCastingNo.MinNull = 0D;
            this.txtCastingNo.MinStringLength = 0;
            this.txtCastingNo.MinStrLength = 0;
            this.txtCastingNo.Name = "txtCastingNo";
            this.txtCastingNo.Precision = 0;
            this.txtCastingNo.ReadOnly = true;
            this.txtCastingNo.Regex = "";
            this.txtCastingNo.Size = new System.Drawing.Size(144, 21);
            this.txtCastingNo.TabIndex = 139;
            this.txtCastingNo.ToolTipValid = null;
            this.txtCastingNo.VaildWarning = "";
            this.txtCastingNo.ValidEable = true;
            this.txtCastingNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(133, 106);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 12);
            this.label30.TabIndex = 140;
            this.label30.Text = "浇次号:";
            // 
            // pnlProcess
            // 
            this.pnlProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProcess.Controls.Add(this.btnProcessCancel);
            this.pnlProcess.Controls.Add(this.btnPaocessOK);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProcess.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlProcess.Location = new System.Drawing.Point(3, 393);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(965, 34);
            this.pnlProcess.TabIndex = 89;
            // 
            // btnProcessCancel
            // 
            this.btnProcessCancel.Location = new System.Drawing.Point(883, 3);
            this.btnProcessCancel.Name = "btnProcessCancel";
            this.btnProcessCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProcessCancel.TabIndex = 87;
            this.btnProcessCancel.Text = "取消";
            this.btnProcessCancel.UseVisualStyleBackColor = true;
            this.btnProcessCancel.Click += new System.EventHandler(this.btnProcessCancel_Click);
            // 
            // tabExcept
            // 
            this.tabExcept.Controls.Add(this.fLPExcept);
            this.tabExcept.Controls.Add(this.dvExcept);
            this.tabExcept.Controls.Add(this.bdExcept);
            this.tabExcept.Location = new System.Drawing.Point(4, 22);
            this.tabExcept.Name = "tabExcept";
            this.tabExcept.Padding = new System.Windows.Forms.Padding(3);
            this.tabExcept.Size = new System.Drawing.Size(973, 432);
            this.tabExcept.TabIndex = 25;
            this.tabExcept.Text = "炉次异常";
            this.tabExcept.UseVisualStyleBackColor = true;
            // 
            // fLPExcept
            // 
            this.fLPExcept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPExcept.Controls.Add(this.btnCancelExcept);
            this.fLPExcept.Controls.Add(this.btnConfirmExcept);
            this.fLPExcept.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPExcept.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPExcept.Location = new System.Drawing.Point(3, 396);
            this.fLPExcept.Name = "fLPExcept";
            this.fLPExcept.Size = new System.Drawing.Size(967, 33);
            this.fLPExcept.TabIndex = 93;
            // 
            // btnCancelExcept
            // 
            this.btnCancelExcept.Location = new System.Drawing.Point(885, 3);
            this.btnCancelExcept.Name = "btnCancelExcept";
            this.btnCancelExcept.Size = new System.Drawing.Size(75, 23);
            this.btnCancelExcept.TabIndex = 87;
            this.btnCancelExcept.Text = "取消";
            this.btnCancelExcept.UseVisualStyleBackColor = true;
            this.btnCancelExcept.Click += new System.EventHandler(this.btnCancelExcept_Click);
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
            this.heatIDDataGridViewTextBoxColumn9,
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.exceptionalTimeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.iDObjectDataGridViewTextBoxColumn,
            this.processCountDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn1,
            this.unitIDDataGridViewTextBoxColumn1,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.decideCodeDataGridViewTextBoxColumn,
            this.classifyDataGridViewTextBoxColumn});
            this.dvExcept.DataSource = this.bsExcept;
            this.dvExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvExcept.Location = new System.Drawing.Point(3, 28);
            this.dvExcept.Name = "dvExcept";
            this.dvExcept.RowTemplate.Height = 23;
            this.dvExcept.Size = new System.Drawing.Size(967, 401);
            this.dvExcept.TabIndex = 92;
            this.dvExcept.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn9
            // 
            this.heatIDDataGridViewTextBoxColumn9.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn9.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn9.Name = "heatIDDataGridViewTextBoxColumn9";
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.DataSource = this.dsExceptCode;
            this.exceptionalCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Exceptional_Des";
            this.exceptionalCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            this.exceptionalCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exceptionalCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exceptionalCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Exceptional_Code";
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
            this.dsExceptCode.SourceCondition = "Unit=\'6\'";
            this.dsExceptCode.SourceMethod = "";
            this.dsExceptCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsExceptCode.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
            this.dsExceptCode.SubscribeTarget = null;
            this.dsExceptCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExceptCode});
            this.dsExceptCode.UpdateEvent = "";
            this.dsExceptCode.UpdateMethod = "";
            this.dsExceptCode.UpdateTrigger = null;
            // 
            // schemadsExceptCode
            // 
            this.schemadsExceptCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptCodeL3DataTableGUID,
            this.coldsExceptCodeL3DataTableName,
            this.coldsExceptCodeL3DataTableExceptional_Code,
            this.coldsExceptCodeL3DataTableExceptional_Des,
            this.coldsExceptCodeL3DataTableUnit,
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag});
            this.schemadsExceptCode.TableName = "L3DataTable";
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
            // coldsExceptCodeL3DataTableAuto_Judge_Flag
            // 
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.Caption = "Auto_Judge_Flag";
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.ColumnName = "Auto_Judge_Flag";
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.DataType = typeof(int);
            this.coldsExceptCodeL3DataTableAuto_Judge_Flag.Namespace = "";
            // 
            // exceptionalTimeDataGridViewTextBoxColumn
            // 
            this.exceptionalTimeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Time";
            this.exceptionalTimeDataGridViewTextBoxColumn.HeaderText = "异常产生时间";
            this.exceptionalTimeDataGridViewTextBoxColumn.Name = "exceptionalTimeDataGridViewTextBoxColumn";
            this.exceptionalTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // gUIDDataGridViewTextBoxColumn1
            // 
            this.gUIDDataGridViewTextBoxColumn1.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn1.Name = "gUIDDataGridViewTextBoxColumn1";
            this.gUIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iDObjectDataGridViewTextBoxColumn
            // 
            this.iDObjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.HeaderText = "ID_Object";
            this.iDObjectDataGridViewTextBoxColumn.Name = "iDObjectDataGridViewTextBoxColumn";
            this.iDObjectDataGridViewTextBoxColumn.Visible = false;
            // 
            // processCountDataGridViewTextBoxColumn
            // 
            this.processCountDataGridViewTextBoxColumn.DataPropertyName = "Process_Count";
            this.processCountDataGridViewTextBoxColumn.HeaderText = "Process_Count";
            this.processCountDataGridViewTextBoxColumn.Name = "processCountDataGridViewTextBoxColumn";
            this.processCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitTypeIDDataGridViewTextBoxColumn1
            // 
            this.unitTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn1.HeaderText = "UnitTypeID";
            this.unitTypeIDDataGridViewTextBoxColumn1.Name = "unitTypeIDDataGridViewTextBoxColumn1";
            this.unitTypeIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // unitIDDataGridViewTextBoxColumn1
            // 
            this.unitIDDataGridViewTextBoxColumn1.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.HeaderText = "UnitID";
            this.unitIDDataGridViewTextBoxColumn1.Name = "unitIDDataGridViewTextBoxColumn1";
            this.unitIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.Visible = false;
            // 
            // decideCodeDataGridViewTextBoxColumn
            // 
            this.decideCodeDataGridViewTextBoxColumn.DataPropertyName = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.HeaderText = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.Name = "decideCodeDataGridViewTextBoxColumn";
            this.decideCodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // classifyDataGridViewTextBoxColumn
            // 
            this.classifyDataGridViewTextBoxColumn.DataPropertyName = "Classify";
            this.classifyDataGridViewTextBoxColumn.HeaderText = "Classify";
            this.classifyDataGridViewTextBoxColumn.Name = "classifyDataGridViewTextBoxColumn";
            this.classifyDataGridViewTextBoxColumn.Visible = false;
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
            this.coldsExceptL3DataTableGUID,
            this.coldsExceptL3DataTableName,
            this.coldsExceptL3DataTableID_Object,
            this.coldsExceptL3DataTableHeatID,
            this.coldsExceptL3DataTableProcess_Count,
            this.coldsExceptL3DataTableUnitTypeID,
            this.coldsExceptL3DataTableUnitID,
            this.coldsExceptL3DataTablePreHeatID,
            this.coldsExceptL3DataTablePre_SteelGradeIndex,
            this.coldsExceptL3DataTableSteelGradeIndex,
            this.coldsExceptL3DataTableExceptional_Code,
            this.coldsExceptL3DataTableDecide_Code,
            this.coldsExceptL3DataTableClassify,
            this.coldsExceptL3DataTableExceptional_Time});
            this.schemadsExcept.TableName = "L3DataTable";
            // 
            // coldsExceptL3DataTableGUID
            // 
            this.coldsExceptL3DataTableGUID.Caption = "GUID";
            this.coldsExceptL3DataTableGUID.ColumnName = "GUID";
            this.coldsExceptL3DataTableGUID.Namespace = "";
            // 
            // coldsExceptL3DataTableName
            // 
            this.coldsExceptL3DataTableName.Caption = "Name";
            this.coldsExceptL3DataTableName.ColumnName = "Name";
            this.coldsExceptL3DataTableName.Namespace = "";
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
            // coldsExceptL3DataTableDecide_Code
            // 
            this.coldsExceptL3DataTableDecide_Code.Caption = "Decide_Code";
            this.coldsExceptL3DataTableDecide_Code.ColumnName = "Decide_Code";
            this.coldsExceptL3DataTableDecide_Code.Namespace = "";
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
            // tabChemical
            // 
            this.tabChemical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabChemical.Controls.Add(this.dvChemical);
            this.tabChemical.Controls.Add(this.bnChemical);
            this.tabChemical.Controls.Add(this.pnlChemical);
            this.tabChemical.Location = new System.Drawing.Point(4, 22);
            this.tabChemical.Name = "tabChemical";
            this.tabChemical.Padding = new System.Windows.Forms.Padding(3);
            this.tabChemical.Size = new System.Drawing.Size(973, 432);
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
            this.dvChemical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn,
            this.appIDDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.sampleCountDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
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
            this.dvChemical.RowHeadersVisible = false;
            this.dvChemical.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvChemical.RowTemplate.Height = 23;
            this.dvChemical.Size = new System.Drawing.Size(965, 367);
            this.dvChemical.TabIndex = 101;
            this.dvChemical.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvChemical_DataBindingComplete);
            this.dvChemical.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
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
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arriveDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDateDataGridViewTextBoxColumn.Width = 130;
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
            this.dsSampleAddr.SourceCondition = "CODE_GROUP = \'QA_Sample_Addr\'";
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
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            // 
            // siDataGridViewTextBoxColumn
            // 
            this.siDataGridViewTextBoxColumn.DataPropertyName = "Si";
            this.siDataGridViewTextBoxColumn.HeaderText = "Si";
            this.siDataGridViewTextBoxColumn.Name = "siDataGridViewTextBoxColumn";
            // 
            // mnDataGridViewTextBoxColumn
            // 
            this.mnDataGridViewTextBoxColumn.DataPropertyName = "Mn";
            this.mnDataGridViewTextBoxColumn.HeaderText = "Mn";
            this.mnDataGridViewTextBoxColumn.Name = "mnDataGridViewTextBoxColumn";
            // 
            // pDataGridViewTextBoxColumn
            // 
            this.pDataGridViewTextBoxColumn.DataPropertyName = "P";
            this.pDataGridViewTextBoxColumn.HeaderText = "P";
            this.pDataGridViewTextBoxColumn.Name = "pDataGridViewTextBoxColumn";
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            // 
            // alDataGridViewTextBoxColumn
            // 
            this.alDataGridViewTextBoxColumn.DataPropertyName = "Al";
            this.alDataGridViewTextBoxColumn.HeaderText = "Al";
            this.alDataGridViewTextBoxColumn.Name = "alDataGridViewTextBoxColumn";
            // 
            // crDataGridViewTextBoxColumn
            // 
            this.crDataGridViewTextBoxColumn.DataPropertyName = "Cr";
            this.crDataGridViewTextBoxColumn.HeaderText = "Cr";
            this.crDataGridViewTextBoxColumn.Name = "crDataGridViewTextBoxColumn";
            // 
            // tiDataGridViewTextBoxColumn
            // 
            this.tiDataGridViewTextBoxColumn.DataPropertyName = "Ti";
            this.tiDataGridViewTextBoxColumn.HeaderText = "Ti";
            this.tiDataGridViewTextBoxColumn.Name = "tiDataGridViewTextBoxColumn";
            // 
            // vDataGridViewTextBoxColumn
            // 
            this.vDataGridViewTextBoxColumn.DataPropertyName = "V";
            this.vDataGridViewTextBoxColumn.HeaderText = "V";
            this.vDataGridViewTextBoxColumn.Name = "vDataGridViewTextBoxColumn";
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            // 
            // moDataGridViewTextBoxColumn
            // 
            this.moDataGridViewTextBoxColumn.DataPropertyName = "Mo";
            this.moDataGridViewTextBoxColumn.HeaderText = "Mo";
            this.moDataGridViewTextBoxColumn.Name = "moDataGridViewTextBoxColumn";
            // 
            // niDataGridViewTextBoxColumn
            // 
            this.niDataGridViewTextBoxColumn.DataPropertyName = "Ni";
            this.niDataGridViewTextBoxColumn.HeaderText = "Ni";
            this.niDataGridViewTextBoxColumn.Name = "niDataGridViewTextBoxColumn";
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            // 
            // cuDataGridViewTextBoxColumn
            // 
            this.cuDataGridViewTextBoxColumn.DataPropertyName = "Cu";
            this.cuDataGridViewTextBoxColumn.HeaderText = "Cu";
            this.cuDataGridViewTextBoxColumn.Name = "cuDataGridViewTextBoxColumn";
            // 
            // nbDataGridViewTextBoxColumn
            // 
            this.nbDataGridViewTextBoxColumn.DataPropertyName = "Nb";
            this.nbDataGridViewTextBoxColumn.HeaderText = "Nb";
            this.nbDataGridViewTextBoxColumn.Name = "nbDataGridViewTextBoxColumn";
            // 
            // snDataGridViewTextBoxColumn
            // 
            this.snDataGridViewTextBoxColumn.DataPropertyName = "Sn";
            this.snDataGridViewTextBoxColumn.HeaderText = "Sn";
            this.snDataGridViewTextBoxColumn.Name = "snDataGridViewTextBoxColumn";
            // 
            // wDataGridViewTextBoxColumn
            // 
            this.wDataGridViewTextBoxColumn.DataPropertyName = "W";
            this.wDataGridViewTextBoxColumn.HeaderText = "W";
            this.wDataGridViewTextBoxColumn.Name = "wDataGridViewTextBoxColumn";
            // 
            // pbDataGridViewTextBoxColumn
            // 
            this.pbDataGridViewTextBoxColumn.DataPropertyName = "Pb";
            this.pbDataGridViewTextBoxColumn.HeaderText = "Pb";
            this.pbDataGridViewTextBoxColumn.Name = "pbDataGridViewTextBoxColumn";
            // 
            // znDataGridViewTextBoxColumn
            // 
            this.znDataGridViewTextBoxColumn.DataPropertyName = "Zn";
            this.znDataGridViewTextBoxColumn.HeaderText = "Zn";
            this.znDataGridViewTextBoxColumn.Name = "znDataGridViewTextBoxColumn";
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "N";
            this.nDataGridViewTextBoxColumn.HeaderText = "N";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "O";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            // 
            // asDataGridViewTextBoxColumn
            // 
            this.asDataGridViewTextBoxColumn.DataPropertyName = "As";
            this.asDataGridViewTextBoxColumn.HeaderText = "As";
            this.asDataGridViewTextBoxColumn.Name = "asDataGridViewTextBoxColumn";
            // 
            // alSDataGridViewTextBoxColumn
            // 
            this.alSDataGridViewTextBoxColumn.DataPropertyName = "AlS";
            this.alSDataGridViewTextBoxColumn.HeaderText = "AlS";
            this.alSDataGridViewTextBoxColumn.Name = "alSDataGridViewTextBoxColumn";
            // 
            // sbDataGridViewTextBoxColumn
            // 
            this.sbDataGridViewTextBoxColumn.DataPropertyName = "Sb";
            this.sbDataGridViewTextBoxColumn.HeaderText = "Sb";
            this.sbDataGridViewTextBoxColumn.Name = "sbDataGridViewTextBoxColumn";
            // 
            // reDataGridViewTextBoxColumn
            // 
            this.reDataGridViewTextBoxColumn.DataPropertyName = "Re";
            this.reDataGridViewTextBoxColumn.HeaderText = "Re";
            this.reDataGridViewTextBoxColumn.Name = "reDataGridViewTextBoxColumn";
            // 
            // ceqDataGridViewTextBoxColumn
            // 
            this.ceqDataGridViewTextBoxColumn.DataPropertyName = "Ceq";
            this.ceqDataGridViewTextBoxColumn.HeaderText = "Ceq";
            this.ceqDataGridViewTextBoxColumn.Name = "ceqDataGridViewTextBoxColumn";
            // 
            // CrNi
            // 
            this.CrNi.DataPropertyName = "CrNi";
            this.CrNi.HeaderText = "CrNi";
            this.CrNi.Name = "CrNi";
            // 
            // CrCu
            // 
            this.CrCu.DataPropertyName = "CrCu";
            this.CrCu.HeaderText = "CrCu";
            this.CrCu.Name = "CrCu";
            // 
            // CrNiCu
            // 
            this.CrNiCu.DataPropertyName = "CrNiCu";
            this.CrNiCu.HeaderText = "CrNiCu";
            this.CrNiCu.Name = "CrNiCu";
            // 
            // other1DataGridViewTextBoxColumn
            // 
            this.other1DataGridViewTextBoxColumn.DataPropertyName = "Other1";
            this.other1DataGridViewTextBoxColumn.HeaderText = "其他1";
            this.other1DataGridViewTextBoxColumn.Name = "other1DataGridViewTextBoxColumn";
            // 
            // other2DataGridViewTextBoxColumn
            // 
            this.other2DataGridViewTextBoxColumn.DataPropertyName = "Other2";
            this.other2DataGridViewTextBoxColumn.HeaderText = "其他2";
            this.other2DataGridViewTextBoxColumn.Name = "other2DataGridViewTextBoxColumn";
            // 
            // Other3
            // 
            this.Other3.DataPropertyName = "Other3";
            this.Other3.HeaderText = "其他3";
            this.Other3.Name = "Other3";
            // 
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "数据记录时间";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            this.logTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn.Width = 130;
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
            this.dsChemical.SourceCondition = null;
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
            this.coldsChemicalL3DataTableGUID,
            this.coldsChemicalL3DataTableName,
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
            this.coldsChemicalL3DataTableDataLogMode});
            this.schemadsChemical.TableName = "L3DataTable";
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
            // bnChemical
            // 
            this.bnChemical.AddNewItem = null;
            this.bnChemical.BindingSource = this.bsChemical;
            this.bnChemical.CountItem = this.toolStripLabel6;
            this.bnChemical.DeleteItem = null;
            this.bnChemical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton27,
            this.toolStripButton28,
            this.toolStripSeparator16,
            this.toolStripTextBox6,
            this.toolStripLabel6,
            this.toolStripSeparator17,
            this.toolStripButton29,
            this.toolStripButton30,
            this.toolStripSeparator18,
            this.btnAddChemical});
            this.bnChemical.Location = new System.Drawing.Point(3, 3);
            this.bnChemical.MoveFirstItem = this.toolStripButton27;
            this.bnChemical.MoveLastItem = this.toolStripButton30;
            this.bnChemical.MoveNextItem = this.toolStripButton29;
            this.bnChemical.MovePreviousItem = this.toolStripButton28;
            this.bnChemical.Name = "bnChemical";
            this.bnChemical.PositionItem = this.toolStripTextBox6;
            this.bnChemical.Size = new System.Drawing.Size(965, 25);
            this.bnChemical.TabIndex = 100;
            this.bnChemical.Text = "bindingNavigator6";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel6.Text = "/ {0}";
            this.toolStripLabel6.ToolTipText = "总项数";
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.RightToLeftAutoMirrorImage = true;
            this.toolStripButton27.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton27.Text = "移到第一条记录";
            // 
            // toolStripButton28
            // 
            this.toolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton28.Image")));
            this.toolStripButton28.Name = "toolStripButton28";
            this.toolStripButton28.RightToLeftAutoMirrorImage = true;
            this.toolStripButton28.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton28.Text = "移到上一条记录";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.AccessibleName = "位置";
            this.toolStripTextBox6.AutoSize = false;
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox6.Text = "0";
            this.toolStripTextBox6.ToolTipText = "当前位置";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton29
            // 
            this.toolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton29.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton29.Image")));
            this.toolStripButton29.Name = "toolStripButton29";
            this.toolStripButton29.RightToLeftAutoMirrorImage = true;
            this.toolStripButton29.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton29.Text = "移到下一条记录";
            // 
            // toolStripButton30
            // 
            this.toolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton30.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton30.Image")));
            this.toolStripButton30.Name = "toolStripButton30";
            this.toolStripButton30.RightToLeftAutoMirrorImage = true;
            this.toolStripButton30.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton30.Text = "移到最后一条记录";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
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
            // pnlChemical
            // 
            this.pnlChemical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChemical.Controls.Add(this.btnChemicalCancel);
            this.pnlChemical.Controls.Add(this.btnChemicalOK);
            this.pnlChemical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChemical.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlChemical.Location = new System.Drawing.Point(3, 395);
            this.pnlChemical.Name = "pnlChemical";
            this.pnlChemical.Size = new System.Drawing.Size(965, 32);
            this.pnlChemical.TabIndex = 90;
            // 
            // btnChemicalCancel
            // 
            this.btnChemicalCancel.Location = new System.Drawing.Point(883, 3);
            this.btnChemicalCancel.Name = "btnChemicalCancel";
            this.btnChemicalCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChemicalCancel.TabIndex = 87;
            this.btnChemicalCancel.Text = "取消";
            this.btnChemicalCancel.UseVisualStyleBackColor = true;
            this.btnChemicalCancel.Click += new System.EventHandler(this.btnChemicalCancel_Click);
            // 
            // btnChemicalOK
            // 
            this.btnChemicalOK.Location = new System.Drawing.Point(802, 3);
            this.btnChemicalOK.Name = "btnChemicalOK";
            this.btnChemicalOK.Size = new System.Drawing.Size(75, 23);
            this.btnChemicalOK.TabIndex = 86;
            this.btnChemicalOK.Text = "确认";
            this.btnChemicalOK.UseVisualStyleBackColor = true;
            this.btnChemicalOK.Click += new System.EventHandler(this.btnChemicalOK_Click);
            // 
            // tabStatus
            // 
            this.tabStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStatus.Controls.Add(this.dvStatus);
            this.tabStatus.Controls.Add(this.bnStatus);
            this.tabStatus.Controls.Add(this.pnlStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(973, 432);
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
            this.cCMIDDataGridViewCheckBoxColumn,
            this.treatNoDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn1,
            this.statusDataGridViewCheckBoxColumn,
            this.changeTimeDataGridViewTextBoxColumn});
            this.dvStatus.DataSource = this.bsStatus;
            this.dvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStatus.Location = new System.Drawing.Point(3, 28);
            this.dvStatus.Name = "dvStatus";
            this.dvStatus.RowHeadersVisible = false;
            this.dvStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvStatus.RowTemplate.Height = 23;
            this.dvStatus.Size = new System.Drawing.Size(965, 367);
            this.dvStatus.TabIndex = 101;
            this.dvStatus.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // cCMIDDataGridViewCheckBoxColumn
            // 
            this.cCMIDDataGridViewCheckBoxColumn.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewCheckBoxColumn.HeaderText = "铸机号";
            this.cCMIDDataGridViewCheckBoxColumn.Name = "cCMIDDataGridViewCheckBoxColumn";
            this.cCMIDDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // treatNoDataGridViewTextBoxColumn
            // 
            this.treatNoDataGridViewTextBoxColumn.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn.HeaderText = "连铸处理号";
            this.treatNoDataGridViewTextBoxColumn.Name = "treatNoDataGridViewTextBoxColumn";
            // 
            // heatIDDataGridViewTextBoxColumn1
            // 
            this.heatIDDataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn1.Name = "heatIDDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.DataSource = this.dsCasterStatus;
            this.statusDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewCheckBoxColumn.HeaderText = "状态";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsCasterStatus
            // 
            this.dsCasterStatus.AutoLoad = true;
            this.dsCasterStatus.AutoSubscribe = false;
            this.dsCasterStatus.DataSetName = "L3DataSet";
            this.dsCasterStatus.DeleteMethod = null;
            this.dsCasterStatus.InsertMethod = null;
            this.dsCasterStatus.L3DataAdapter = this.Adapter;
            this.dsCasterStatus.LoadEvent = "Click";
            this.dsCasterStatus.LoadTrigger = null;
            this.dsCasterStatus.RefreshValve = 1000;
            this.dsCasterStatus.SourceCommand = null;
            this.dsCasterStatus.SourceCondition = "CODE_GROUP = \'CasterUnitStatus\' and code is not null order by code";
            this.dsCasterStatus.SourceMethod = "";
            this.dsCasterStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCasterStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCasterStatus.SubscribeTarget = null;
            this.dsCasterStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCasterStatus});
            this.dsCasterStatus.UpdateEvent = "Click";
            this.dsCasterStatus.UpdateMethod = null;
            this.dsCasterStatus.UpdateTrigger = null;
            // 
            // schemadsCasterStatus
            // 
            this.schemadsCasterStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterStatusL3DataTableCode_Des,
            this.coldsCasterStatusL3DataTableCode_Val_Long});
            this.schemadsCasterStatus.TableName = "L3DataTable";
            // 
            // coldsCasterStatusL3DataTableCode_Des
            // 
            this.coldsCasterStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCasterStatusL3DataTableCode_Val_Long
            // 
            this.coldsCasterStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCasterStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCasterStatusL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsCasterStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // changeTimeDataGridViewTextBoxColumn
            // 
            this.changeTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeTimeDataGridViewTextBoxColumn.DataPropertyName = "Change_Time";
            this.changeTimeDataGridViewTextBoxColumn.HeaderText = "状态变化时刻";
            this.changeTimeDataGridViewTextBoxColumn.Name = "changeTimeDataGridViewTextBoxColumn";
            this.changeTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.changeTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.dsStatus.SourceCondition = null;
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Process_Status";
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
            this.coldsStatusL3DataTableGUID,
            this.coldsStatusL3DataTableName,
            this.coldsStatusL3DataTableCCMID,
            this.coldsStatusL3DataTableTreatNo,
            this.coldsStatusL3DataTableHeatID,
            this.coldsStatusL3DataTableStatus,
            this.coldsStatusL3DataTableChange_Time});
            this.schemadsStatus.TableName = "L3DataTable";
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
            // coldsStatusL3DataTableCCMID
            // 
            this.coldsStatusL3DataTableCCMID.Caption = "CCMID";
            this.coldsStatusL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsStatusL3DataTableCCMID.Namespace = "";
            // 
            // coldsStatusL3DataTableTreatNo
            // 
            this.coldsStatusL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsStatusL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsStatusL3DataTableTreatNo.Namespace = "";
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
            this.coldsStatusL3DataTableStatus.DataType = typeof(short);
            this.coldsStatusL3DataTableStatus.Namespace = "";
            // 
            // coldsStatusL3DataTableChange_Time
            // 
            this.coldsStatusL3DataTableChange_Time.Caption = "Change_Time";
            this.coldsStatusL3DataTableChange_Time.ColumnName = "Change_Time";
            this.coldsStatusL3DataTableChange_Time.DataType = typeof(System.DateTime);
            this.coldsStatusL3DataTableChange_Time.Namespace = "";
            // 
            // bnStatus
            // 
            this.bnStatus.AddNewItem = null;
            this.bnStatus.BindingSource = this.bsStatus;
            this.bnStatus.CountItem = this.toolStripLabel5;
            this.bnStatus.DeleteItem = null;
            this.bnStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton22,
            this.toolStripButton23,
            this.toolStripSeparator13,
            this.toolStripTextBox5,
            this.toolStripLabel5,
            this.toolStripSeparator14,
            this.toolStripButton24,
            this.toolStripButton25,
            this.toolStripSeparator15,
            this.btnAddStatus});
            this.bnStatus.Location = new System.Drawing.Point(3, 3);
            this.bnStatus.MoveFirstItem = this.toolStripButton22;
            this.bnStatus.MoveLastItem = this.toolStripButton25;
            this.bnStatus.MoveNextItem = this.toolStripButton24;
            this.bnStatus.MovePreviousItem = this.toolStripButton23;
            this.bnStatus.Name = "bnStatus";
            this.bnStatus.PositionItem = this.toolStripTextBox5;
            this.bnStatus.Size = new System.Drawing.Size(965, 25);
            this.bnStatus.TabIndex = 99;
            this.bnStatus.Text = "bindingNavigator5";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel5.Text = "/ {0}";
            this.toolStripLabel5.ToolTipText = "总项数";
            // 
            // toolStripButton22
            // 
            this.toolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.RightToLeftAutoMirrorImage = true;
            this.toolStripButton22.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton22.Text = "移到第一条记录";
            // 
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.RightToLeftAutoMirrorImage = true;
            this.toolStripButton23.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton23.Text = "移到上一条记录";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.AccessibleName = "位置";
            this.toolStripTextBox5.AutoSize = false;
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox5.Text = "0";
            this.toolStripTextBox5.ToolTipText = "当前位置";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton24.Text = "移到下一条记录";
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.RightToLeftAutoMirrorImage = true;
            this.toolStripButton25.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton25.Text = "移到最后一条记录";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
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
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatus.Controls.Add(this.btnStatusCancel);
            this.pnlStatus.Controls.Add(this.btnStatusOK);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlStatus.Location = new System.Drawing.Point(3, 395);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(965, 32);
            this.pnlStatus.TabIndex = 91;
            // 
            // btnStatusCancel
            // 
            this.btnStatusCancel.Location = new System.Drawing.Point(883, 3);
            this.btnStatusCancel.Name = "btnStatusCancel";
            this.btnStatusCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStatusCancel.TabIndex = 87;
            this.btnStatusCancel.Text = "取消";
            this.btnStatusCancel.UseVisualStyleBackColor = true;
            this.btnStatusCancel.Click += new System.EventHandler(this.btnStatusCancel_Click);
            // 
            // btnStatusOK
            // 
            this.btnStatusOK.Location = new System.Drawing.Point(802, 3);
            this.btnStatusOK.Name = "btnStatusOK";
            this.btnStatusOK.Size = new System.Drawing.Size(75, 23);
            this.btnStatusOK.TabIndex = 86;
            this.btnStatusOK.Text = "确认";
            this.btnStatusOK.UseVisualStyleBackColor = true;
            this.btnStatusOK.Click += new System.EventHandler(this.btnStatusOK_Click);
            // 
            // tabHeatTundishTemp
            // 
            this.tabHeatTundishTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHeatTundishTemp.Controls.Add(this.hmiRootPanel6);
            this.tabHeatTundishTemp.Location = new System.Drawing.Point(4, 22);
            this.tabHeatTundishTemp.Name = "tabHeatTundishTemp";
            this.tabHeatTundishTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeatTundishTemp.Size = new System.Drawing.Size(973, 432);
            this.tabHeatTundishTemp.TabIndex = 9;
            this.tabHeatTundishTemp.Text = "中包测温";
            this.tabHeatTundishTemp.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel6
            // 
            this.hmiRootPanel6.Controls.Add(this.dvHeatTundishTemp);
            this.hmiRootPanel6.Controls.Add(this.bnHeatTundishTemp);
            this.hmiRootPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel6.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel6.Name = "hmiRootPanel6";
            this.hmiRootPanel6.Size = new System.Drawing.Size(965, 424);
            this.hmiRootPanel6.TabIndex = 0;
            // 
            // dvHeatTundishTemp
            // 
            this.dvHeatTundishTemp.AllowUserToAddRows = false;
            this.dvHeatTundishTemp.AllowUserToDeleteRows = false;
            this.dvHeatTundishTemp.AutoGenerateColumns = false;
            this.dvHeatTundishTemp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatTundishTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn2,
            this.cCMIDDataGridViewCheckBoxColumn1,
            this.tempIDDataGridViewCheckBoxColumn,
            this.tempDataGridViewCheckBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn});
            this.dvHeatTundishTemp.DataSource = this.bsHeatTundishTemp;
            this.dvHeatTundishTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatTundishTemp.Location = new System.Drawing.Point(0, 25);
            this.dvHeatTundishTemp.Name = "dvHeatTundishTemp";
            this.dvHeatTundishTemp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvHeatTundishTemp.RowTemplate.Height = 23;
            this.dvHeatTundishTemp.Size = new System.Drawing.Size(965, 399);
            this.dvHeatTundishTemp.TabIndex = 99;
            this.dvHeatTundishTemp.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn2
            // 
            this.heatIDDataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn2.Name = "heatIDDataGridViewTextBoxColumn2";
            // 
            // cCMIDDataGridViewCheckBoxColumn1
            // 
            this.cCMIDDataGridViewCheckBoxColumn1.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewCheckBoxColumn1.HeaderText = "铸机号";
            this.cCMIDDataGridViewCheckBoxColumn1.Name = "cCMIDDataGridViewCheckBoxColumn1";
            this.cCMIDDataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tempIDDataGridViewCheckBoxColumn
            // 
            this.tempIDDataGridViewCheckBoxColumn.DataPropertyName = "TempID";
            this.tempIDDataGridViewCheckBoxColumn.DataSource = this.dsCCMTempMode;
            this.tempIDDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tempIDDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tempIDDataGridViewCheckBoxColumn.HeaderText = "测温模式";
            this.tempIDDataGridViewCheckBoxColumn.Name = "tempIDDataGridViewCheckBoxColumn";
            this.tempIDDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tempIDDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tempIDDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsCCMTempMode
            // 
            this.dsCCMTempMode.AutoLoad = true;
            this.dsCCMTempMode.AutoSubscribe = false;
            this.dsCCMTempMode.DataSetName = "L3DataSet";
            this.dsCCMTempMode.DeleteMethod = null;
            this.dsCCMTempMode.InsertMethod = null;
            this.dsCCMTempMode.L3DataAdapter = this.Adapter;
            this.dsCCMTempMode.LoadEvent = "Click";
            this.dsCCMTempMode.LoadTrigger = null;
            this.dsCCMTempMode.RefreshValve = 1000;
            this.dsCCMTempMode.SourceCommand = null;
            this.dsCCMTempMode.SourceCondition = "CODE_GROUP = \'CCM_TEMP_MODE\' and code is not null order by code";
            this.dsCCMTempMode.SourceMethod = "";
            this.dsCCMTempMode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCCMTempMode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCCMTempMode.SubscribeTarget = null;
            this.dsCCMTempMode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCCMTempMode});
            this.dsCCMTempMode.UpdateEvent = "Click";
            this.dsCCMTempMode.UpdateMethod = null;
            this.dsCCMTempMode.UpdateTrigger = null;
            // 
            // schemadsCCMTempMode
            // 
            this.schemadsCCMTempMode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCCMTempModeL3DataTableCode_Des,
            this.coldsCCMTempModeL3DataTableCode_Val_Long});
            this.schemadsCCMTempMode.TableName = "L3DataTable";
            // 
            // coldsCCMTempModeL3DataTableCode_Des
            // 
            this.coldsCCMTempModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCCMTempModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCCMTempModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCCMTempModeL3DataTableCode_Val_Long
            // 
            this.coldsCCMTempModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCCMTempModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCCMTempModeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsCCMTempModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // tempDataGridViewCheckBoxColumn
            // 
            this.tempDataGridViewCheckBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewCheckBoxColumn.HeaderText = "测温值[℃]";
            this.tempDataGridViewCheckBoxColumn.Name = "tempDataGridViewCheckBoxColumn";
            this.tempDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // measureTimeDataGridViewTextBoxColumn
            // 
            this.measureTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.measureTimeDataGridViewTextBoxColumn.DataPropertyName = "Measure_Time";
            this.measureTimeDataGridViewTextBoxColumn.HeaderText = "测温时刻";
            this.measureTimeDataGridViewTextBoxColumn.Name = "measureTimeDataGridViewTextBoxColumn";
            this.measureTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsHeatTundishTemp
            // 
            this.bsHeatTundishTemp.DataMember = "L3DataTable";
            this.bsHeatTundishTemp.DataSource = this.dsHeatTundishTemp;
            // 
            // dsHeatTundishTemp
            // 
            this.dsHeatTundishTemp.AutoLoad = true;
            this.dsHeatTundishTemp.AutoSubscribe = false;
            this.dsHeatTundishTemp.DataSetName = "L3DataSet";
            this.dsHeatTundishTemp.DeleteMethod = null;
            this.dsHeatTundishTemp.InsertMethod = null;
            this.dsHeatTundishTemp.L3DataAdapter = null;
            this.dsHeatTundishTemp.LoadEvent = "Click";
            this.dsHeatTundishTemp.LoadTrigger = null;
            this.dsHeatTundishTemp.RefreshValve = 1000;
            this.dsHeatTundishTemp.SourceCommand = null;
            this.dsHeatTundishTemp.SourceCondition = "1=2";
            this.dsHeatTundishTemp.SourceMethod = "";
            this.dsHeatTundishTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatTundishTemp.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_TundishTemp";
            this.dsHeatTundishTemp.SubscribeTarget = null;
            this.dsHeatTundishTemp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatTundishTemp});
            this.dsHeatTundishTemp.UpdateEvent = "Click";
            this.dsHeatTundishTemp.UpdateMethod = null;
            this.dsHeatTundishTemp.UpdateTrigger = null;
            // 
            // schemadsHeatTundishTemp
            // 
            this.schemadsHeatTundishTemp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatTundishTempL3DataTableGUID,
            this.coldsHeatTundishTempL3DataTableName,
            this.coldsHeatTundishTempL3DataTableHeatID,
            this.coldsHeatTundishTempL3DataTableCCMID,
            this.coldsHeatTundishTempL3DataTableTempID,
            this.coldsHeatTundishTempL3DataTableTemp,
            this.coldsHeatTundishTempL3DataTableMeasure_Time});
            this.schemadsHeatTundishTemp.TableName = "L3DataTable";
            // 
            // coldsHeatTundishTempL3DataTableGUID
            // 
            this.coldsHeatTundishTempL3DataTableGUID.Caption = "GUID";
            this.coldsHeatTundishTempL3DataTableGUID.ColumnName = "GUID";
            this.coldsHeatTundishTempL3DataTableGUID.Namespace = "";
            // 
            // coldsHeatTundishTempL3DataTableName
            // 
            this.coldsHeatTundishTempL3DataTableName.Caption = "Name";
            this.coldsHeatTundishTempL3DataTableName.ColumnName = "Name";
            this.coldsHeatTundishTempL3DataTableName.Namespace = "";
            // 
            // coldsHeatTundishTempL3DataTableHeatID
            // 
            this.coldsHeatTundishTempL3DataTableHeatID.Caption = "HeatID";
            this.coldsHeatTundishTempL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHeatTundishTempL3DataTableHeatID.Namespace = "";
            // 
            // coldsHeatTundishTempL3DataTableCCMID
            // 
            this.coldsHeatTundishTempL3DataTableCCMID.Caption = "CCMID";
            this.coldsHeatTundishTempL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsHeatTundishTempL3DataTableCCMID.Namespace = "";
            // 
            // coldsHeatTundishTempL3DataTableTempID
            // 
            this.coldsHeatTundishTempL3DataTableTempID.Caption = "TempID";
            this.coldsHeatTundishTempL3DataTableTempID.ColumnName = "TempID";
            this.coldsHeatTundishTempL3DataTableTempID.DataType = typeof(int);
            this.coldsHeatTundishTempL3DataTableTempID.Namespace = "";
            // 
            // coldsHeatTundishTempL3DataTableTemp
            // 
            this.coldsHeatTundishTempL3DataTableTemp.Caption = "Temp";
            this.coldsHeatTundishTempL3DataTableTemp.ColumnName = "Temp";
            this.coldsHeatTundishTempL3DataTableTemp.DataType = typeof(int);
            this.coldsHeatTundishTempL3DataTableTemp.Namespace = "";
            // 
            // coldsHeatTundishTempL3DataTableMeasure_Time
            // 
            this.coldsHeatTundishTempL3DataTableMeasure_Time.Caption = "Measure_Time";
            this.coldsHeatTundishTempL3DataTableMeasure_Time.ColumnName = "Measure_Time";
            this.coldsHeatTundishTempL3DataTableMeasure_Time.DataType = typeof(System.DateTime);
            this.coldsHeatTundishTempL3DataTableMeasure_Time.Namespace = "";
            // 
            // bnHeatTundishTemp
            // 
            this.bnHeatTundishTemp.AddNewItem = null;
            this.bnHeatTundishTemp.BindingSource = this.bsHeatTundishTemp;
            this.bnHeatTundishTemp.CountItem = this.toolStripLabel4;
            this.bnHeatTundishTemp.DeleteItem = null;
            this.bnHeatTundishTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator10,
            this.toolStripTextBox4,
            this.toolStripLabel4,
            this.toolStripSeparator11,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator12,
            this.btnAddHeatTundishTemp});
            this.bnHeatTundishTemp.Location = new System.Drawing.Point(0, 0);
            this.bnHeatTundishTemp.MoveFirstItem = this.toolStripButton17;
            this.bnHeatTundishTemp.MoveLastItem = this.toolStripButton20;
            this.bnHeatTundishTemp.MoveNextItem = this.toolStripButton19;
            this.bnHeatTundishTemp.MovePreviousItem = this.toolStripButton18;
            this.bnHeatTundishTemp.Name = "bnHeatTundishTemp";
            this.bnHeatTundishTemp.PositionItem = this.toolStripTextBox4;
            this.bnHeatTundishTemp.Size = new System.Drawing.Size(965, 25);
            this.bnHeatTundishTemp.TabIndex = 98;
            this.bnHeatTundishTemp.Text = "bindingNavigator4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "移到第一条记录";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "移到上一条记录";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.AccessibleName = "位置";
            this.toolStripTextBox4.AutoSize = false;
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox4.Text = "0";
            this.toolStripTextBox4.ToolTipText = "当前位置";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton19
            // 
            this.toolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton19.Image")));
            this.toolStripButton19.Name = "toolStripButton19";
            this.toolStripButton19.RightToLeftAutoMirrorImage = true;
            this.toolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton19.Text = "移到下一条记录";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "移到最后一条记录";
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddHeatTundishTemp
            // 
            this.btnAddHeatTundishTemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddHeatTundishTemp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHeatTundishTemp.Image")));
            this.btnAddHeatTundishTemp.Name = "btnAddHeatTundishTemp";
            this.btnAddHeatTundishTemp.RightToLeftAutoMirrorImage = true;
            this.btnAddHeatTundishTemp.Size = new System.Drawing.Size(23, 22);
            this.btnAddHeatTundishTemp.Text = "新添";
            this.btnAddHeatTundishTemp.Click += new System.EventHandler(this.btnAddHeatTundishTemp_Click);
            // 
            // tabHeatCover
            // 
            this.tabHeatCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabHeatCover.Controls.Add(this.dvHeatCover);
            this.tabHeatCover.Controls.Add(this.bnHeatCover);
            this.tabHeatCover.Controls.Add(this.pnlHeatCover);
            this.tabHeatCover.Location = new System.Drawing.Point(4, 22);
            this.tabHeatCover.Name = "tabHeatCover";
            this.tabHeatCover.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeatCover.Size = new System.Drawing.Size(973, 432);
            this.tabHeatCover.TabIndex = 10;
            this.tabHeatCover.Text = "覆盖剂";
            this.tabHeatCover.UseVisualStyleBackColor = true;
            // 
            // dvHeatCover
            // 
            this.dvHeatCover.AllowUserToAddRows = false;
            this.dvHeatCover.AllowUserToDeleteRows = false;
            this.dvHeatCover.AutoGenerateColumns = false;
            this.dvHeatCover.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHeatCover.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.heatIDDataGridViewTextBoxColumn3,
            this.cCMIDDataGridViewTextBoxColumn1,
            this.elementDataGridViewTextBoxColumn,
            this.Batch_ID,
            this.amountDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.useInformationDataGridViewTextBoxColumn1});
            this.dvHeatCover.DataSource = this.bsHeatCover;
            this.dvHeatCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHeatCover.Location = new System.Drawing.Point(3, 28);
            this.dvHeatCover.Name = "dvHeatCover";
            this.dvHeatCover.RowHeadersVisible = false;
            this.dvHeatCover.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvHeatCover.RowTemplate.Height = 23;
            this.dvHeatCover.Size = new System.Drawing.Size(965, 367);
            this.dvHeatCover.TabIndex = 98;
            this.dvHeatCover.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // gUIDDataGridViewTextBoxColumn2
            // 
            this.gUIDDataGridViewTextBoxColumn2.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn2.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn2.Name = "gUIDDataGridViewTextBoxColumn2";
            this.gUIDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Visible = false;
            // 
            // heatIDDataGridViewTextBoxColumn3
            // 
            this.heatIDDataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn3.Name = "heatIDDataGridViewTextBoxColumn3";
            // 
            // cCMIDDataGridViewTextBoxColumn1
            // 
            this.cCMIDDataGridViewTextBoxColumn1.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn1.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn1.Name = "cCMIDDataGridViewTextBoxColumn1";
            // 
            // elementDataGridViewTextBoxColumn
            // 
            this.elementDataGridViewTextBoxColumn.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn.DataSource = this.dsCoverElement;
            this.elementDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.elementDataGridViewTextBoxColumn.HeaderText = "中包覆盖剂名称";
            this.elementDataGridViewTextBoxColumn.Name = "elementDataGridViewTextBoxColumn";
            this.elementDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elementDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.elementDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsCoverElement
            // 
            this.dsCoverElement.AutoLoad = true;
            this.dsCoverElement.AutoSubscribe = false;
            this.dsCoverElement.DataSetName = "L3DataSet";
            this.dsCoverElement.DeleteMethod = null;
            this.dsCoverElement.InsertMethod = null;
            this.dsCoverElement.L3DataAdapter = this.Adapter;
            this.dsCoverElement.LoadEvent = "Click";
            this.dsCoverElement.LoadTrigger = null;
            this.dsCoverElement.RefreshValve = 1000;
            this.dsCoverElement.SourceCommand = null;
            this.dsCoverElement.SourceCondition = "code_group = \'Cover_Element\'";
            this.dsCoverElement.SourceMethod = "";
            this.dsCoverElement.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCoverElement.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCoverElement.SubscribeTarget = null;
            this.dsCoverElement.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCoverElement});
            this.dsCoverElement.UpdateEvent = "Click";
            this.dsCoverElement.UpdateMethod = null;
            this.dsCoverElement.UpdateTrigger = null;
            // 
            // schemadsCoverElement
            // 
            this.schemadsCoverElement.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCoverElementL3DataTableCode,
            this.coldsCoverElementL3DataTableCode_Des});
            this.schemadsCoverElement.TableName = "L3DataTable";
            // 
            // coldsCoverElementL3DataTableCode
            // 
            this.coldsCoverElementL3DataTableCode.Caption = "Code";
            this.coldsCoverElementL3DataTableCode.ColumnName = "Code";
            this.coldsCoverElementL3DataTableCode.Namespace = "";
            // 
            // coldsCoverElementL3DataTableCode_Des
            // 
            this.coldsCoverElementL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCoverElementL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCoverElementL3DataTableCode_Des.Namespace = "";
            // 
            // Batch_ID
            // 
            this.Batch_ID.DataPropertyName = "Batch_ID";
            this.Batch_ID.HeaderText = "物料批次";
            this.Batch_ID.Name = "Batch_ID";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "中包覆盖剂数量（kg）";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.DataSource = this.dsOrigin;
            this.originDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.MatFactory";
            this.originDataGridViewTextBoxColumn.HeaderText = "中包覆盖剂厂家";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.originDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.originDataGridViewTextBoxColumn.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsOrigin
            // 
            this.dsOrigin.AutoLoad = true;
            this.dsOrigin.AutoSubscribe = false;
            this.dsOrigin.DataSetName = "L3DataSet";
            this.dsOrigin.DeleteMethod = null;
            this.dsOrigin.InsertMethod = null;
            this.dsOrigin.L3DataAdapter = this.Adapter;
            this.dsOrigin.LoadEvent = "Click";
            this.dsOrigin.LoadTrigger = null;
            this.dsOrigin.RefreshValve = 1000;
            this.dsOrigin.SourceCommand = null;
            this.dsOrigin.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'覆盖剂\'";
            this.dsOrigin.SourceMethod = "";
            this.dsOrigin.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOrigin.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsOrigin.SubscribeTarget = null;
            this.dsOrigin.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOrigin});
            this.dsOrigin.UpdateEvent = "Click";
            this.dsOrigin.UpdateMethod = null;
            this.dsOrigin.UpdateTrigger = null;
            // 
            // schemadsOrigin
            // 
            this.schemadsOrigin.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOriginL3DataTableMatFactory,
            this.coldsOriginL3DataTableMatName,
            this.coldsOriginL3DataTableMatGroup_Code,
            this.coldsOriginL3DataTableMatGroup_Des});
            this.schemadsOrigin.TableName = "L3DataTable";
            // 
            // coldsOriginL3DataTableMatFactory
            // 
            this.coldsOriginL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsOriginL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsOriginL3DataTableMatFactory.Namespace = "";
            // 
            // coldsOriginL3DataTableMatName
            // 
            this.coldsOriginL3DataTableMatName.Caption = "MatName";
            this.coldsOriginL3DataTableMatName.ColumnName = "MatName";
            this.coldsOriginL3DataTableMatName.Namespace = "";
            // 
            // coldsOriginL3DataTableMatGroup_Code
            // 
            this.coldsOriginL3DataTableMatGroup_Code.Caption = "MatGroup_Code";
            this.coldsOriginL3DataTableMatGroup_Code.ColumnName = "MatGroup_Code";
            this.coldsOriginL3DataTableMatGroup_Code.Namespace = "";
            // 
            // coldsOriginL3DataTableMatGroup_Des
            // 
            this.coldsOriginL3DataTableMatGroup_Des.Caption = "MatGroup_Des";
            this.coldsOriginL3DataTableMatGroup_Des.ColumnName = "MatGroup_Des";
            this.coldsOriginL3DataTableMatGroup_Des.Namespace = "";
            // 
            // useInformationDataGridViewTextBoxColumn1
            // 
            this.useInformationDataGridViewTextBoxColumn1.DataPropertyName = "UseInformation";
            this.useInformationDataGridViewTextBoxColumn1.DataSource = this.dsHeatCoverUse;
            this.useInformationDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.useInformationDataGridViewTextBoxColumn1.HeaderText = "使用情况";
            this.useInformationDataGridViewTextBoxColumn1.Name = "useInformationDataGridViewTextBoxColumn1";
            this.useInformationDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.useInformationDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.useInformationDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            // 
            // dsHeatCoverUse
            // 
            this.dsHeatCoverUse.AutoLoad = true;
            this.dsHeatCoverUse.AutoSubscribe = false;
            this.dsHeatCoverUse.DataSetName = "L3DataSet";
            this.dsHeatCoverUse.DeleteMethod = null;
            this.dsHeatCoverUse.InsertMethod = null;
            this.dsHeatCoverUse.L3DataAdapter = this.Adapter;
            this.dsHeatCoverUse.LoadEvent = "Click";
            this.dsHeatCoverUse.LoadTrigger = null;
            this.dsHeatCoverUse.RefreshValve = 1000;
            this.dsHeatCoverUse.SourceCommand = null;
            this.dsHeatCoverUse.SourceCondition = "Code_Group = \'CCCM_Heat_Cover_UseInformation\' order by Code";
            this.dsHeatCoverUse.SourceMethod = "";
            this.dsHeatCoverUse.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatCoverUse.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsHeatCoverUse.SubscribeTarget = null;
            this.dsHeatCoverUse.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatCoverUse});
            this.dsHeatCoverUse.UpdateEvent = "Click";
            this.dsHeatCoverUse.UpdateMethod = null;
            this.dsHeatCoverUse.UpdateTrigger = null;
            // 
            // schemadsHeatCoverUse
            // 
            this.schemadsHeatCoverUse.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatCoverUseL3DataTableCode,
            this.coldsHeatCoverUseL3DataTableCode_Des});
            this.schemadsHeatCoverUse.TableName = "L3DataTable";
            // 
            // coldsHeatCoverUseL3DataTableCode
            // 
            this.coldsHeatCoverUseL3DataTableCode.Caption = "Code";
            this.coldsHeatCoverUseL3DataTableCode.ColumnName = "Code";
            this.coldsHeatCoverUseL3DataTableCode.Namespace = "";
            // 
            // coldsHeatCoverUseL3DataTableCode_Des
            // 
            this.coldsHeatCoverUseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsHeatCoverUseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsHeatCoverUseL3DataTableCode_Des.Namespace = "";
            // 
            // bsHeatCover
            // 
            this.bsHeatCover.DataMember = "L3DataTable";
            this.bsHeatCover.DataSource = this.dsHeatCover;
            // 
            // dsHeatCover
            // 
            this.dsHeatCover.AutoLoad = true;
            this.dsHeatCover.AutoSubscribe = false;
            this.dsHeatCover.DataSetName = "L3DataSet";
            this.dsHeatCover.DeleteMethod = null;
            this.dsHeatCover.InsertMethod = null;
            this.dsHeatCover.L3DataAdapter = null;
            this.dsHeatCover.LoadEvent = "Click";
            this.dsHeatCover.LoadTrigger = null;
            this.dsHeatCover.RefreshValve = 1000;
            this.dsHeatCover.SourceCommand = null;
            this.dsHeatCover.SourceCondition = null;
            this.dsHeatCover.SourceMethod = "";
            this.dsHeatCover.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatCover.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_Cover";
            this.dsHeatCover.SubscribeTarget = null;
            this.dsHeatCover.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatCover});
            this.dsHeatCover.UpdateEvent = "Click";
            this.dsHeatCover.UpdateMethod = null;
            this.dsHeatCover.UpdateTrigger = null;
            // 
            // schemadsHeatCover
            // 
            this.schemadsHeatCover.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatCoverL3DataTableGUID,
            this.coldsHeatCoverL3DataTableName,
            this.coldsHeatCoverL3DataTableHeatID,
            this.coldsHeatCoverL3DataTableCCMID,
            this.coldsHeatCoverL3DataTableElement,
            this.coldsHeatCoverL3DataTableAmount,
            this.coldsHeatCoverL3DataTableOrigin,
            this.coldsHeatCoverL3DataTableUseInformation,
            this.coldsHeatCoverL3DataTableBatch_ID});
            this.schemadsHeatCover.TableName = "L3DataTable";
            // 
            // coldsHeatCoverL3DataTableGUID
            // 
            this.coldsHeatCoverL3DataTableGUID.Caption = "GUID";
            this.coldsHeatCoverL3DataTableGUID.ColumnName = "GUID";
            this.coldsHeatCoverL3DataTableGUID.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableName
            // 
            this.coldsHeatCoverL3DataTableName.Caption = "Name";
            this.coldsHeatCoverL3DataTableName.ColumnName = "Name";
            this.coldsHeatCoverL3DataTableName.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableHeatID
            // 
            this.coldsHeatCoverL3DataTableHeatID.Caption = "HeatID";
            this.coldsHeatCoverL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHeatCoverL3DataTableHeatID.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableCCMID
            // 
            this.coldsHeatCoverL3DataTableCCMID.Caption = "CCMID";
            this.coldsHeatCoverL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsHeatCoverL3DataTableCCMID.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableElement
            // 
            this.coldsHeatCoverL3DataTableElement.Caption = "Element";
            this.coldsHeatCoverL3DataTableElement.ColumnName = "Element";
            this.coldsHeatCoverL3DataTableElement.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableAmount
            // 
            this.coldsHeatCoverL3DataTableAmount.Caption = "Amount";
            this.coldsHeatCoverL3DataTableAmount.ColumnName = "Amount";
            this.coldsHeatCoverL3DataTableAmount.DataType = typeof(float);
            this.coldsHeatCoverL3DataTableAmount.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableOrigin
            // 
            this.coldsHeatCoverL3DataTableOrigin.Caption = "Origin";
            this.coldsHeatCoverL3DataTableOrigin.ColumnName = "Origin";
            this.coldsHeatCoverL3DataTableOrigin.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableUseInformation
            // 
            this.coldsHeatCoverL3DataTableUseInformation.Caption = "UseInformation";
            this.coldsHeatCoverL3DataTableUseInformation.ColumnName = "UseInformation";
            this.coldsHeatCoverL3DataTableUseInformation.Namespace = "";
            // 
            // coldsHeatCoverL3DataTableBatch_ID
            // 
            this.coldsHeatCoverL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsHeatCoverL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsHeatCoverL3DataTableBatch_ID.Namespace = "";
            // 
            // bnHeatCover
            // 
            this.bnHeatCover.AddNewItem = null;
            this.bnHeatCover.BindingSource = this.bsHeatCover;
            this.bnHeatCover.CountItem = this.toolStripLabel3;
            this.bnHeatCover.DeleteItem = null;
            this.bnHeatCover.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripSeparator9,
            this.btnAddHeatCover,
            this.btnDelHeatCover});
            this.bnHeatCover.Location = new System.Drawing.Point(3, 3);
            this.bnHeatCover.MoveFirstItem = this.toolStripButton12;
            this.bnHeatCover.MoveLastItem = this.toolStripButton15;
            this.bnHeatCover.MoveNextItem = this.toolStripButton14;
            this.bnHeatCover.MovePreviousItem = this.toolStripButton13;
            this.bnHeatCover.Name = "bnHeatCover";
            this.bnHeatCover.PositionItem = this.toolStripTextBox3;
            this.bnHeatCover.Size = new System.Drawing.Size(965, 25);
            this.bnHeatCover.TabIndex = 97;
            this.bnHeatCover.Text = "bindingNavigator3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel3.Text = "/ {0}";
            this.toolStripLabel3.ToolTipText = "总项数";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "移到第一条记录";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "移到上一条记录";
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
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "移到下一条记录";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "移到最后一条记录";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlHeatCover
            // 
            this.pnlHeatCover.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeatCover.Controls.Add(this.btnCoverCancel);
            this.pnlHeatCover.Controls.Add(this.btnCoverOK);
            this.pnlHeatCover.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHeatCover.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlHeatCover.Location = new System.Drawing.Point(3, 395);
            this.pnlHeatCover.Name = "pnlHeatCover";
            this.pnlHeatCover.Size = new System.Drawing.Size(965, 32);
            this.pnlHeatCover.TabIndex = 92;
            // 
            // btnCoverCancel
            // 
            this.btnCoverCancel.Location = new System.Drawing.Point(883, 3);
            this.btnCoverCancel.Name = "btnCoverCancel";
            this.btnCoverCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCoverCancel.TabIndex = 87;
            this.btnCoverCancel.Text = "取消";
            this.btnCoverCancel.UseVisualStyleBackColor = true;
            this.btnCoverCancel.Click += new System.EventHandler(this.btnCoverCancel_Click);
            // 
            // tabLadle
            // 
            this.tabLadle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLadle.Controls.Add(this.dvLadle);
            this.tabLadle.Controls.Add(this.bnLadle);
            this.tabLadle.Controls.Add(this.pnlLadle);
            this.tabLadle.Location = new System.Drawing.Point(4, 22);
            this.tabLadle.Name = "tabLadle";
            this.tabLadle.Padding = new System.Windows.Forms.Padding(3);
            this.tabLadle.Size = new System.Drawing.Size(973, 432);
            this.tabLadle.TabIndex = 11;
            this.tabLadle.Text = "大包数据";
            this.tabLadle.UseVisualStyleBackColor = true;
            // 
            // dvLadle
            // 
            this.dvLadle.AllowUserToAddRows = false;
            this.dvLadle.AllowUserToDeleteRows = false;
            this.dvLadle.AutoGenerateColumns = false;
            this.dvLadle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvLadle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn8,
            this.treatNoDataGridViewTextBoxColumn2,
            this.cCMIDDataGridViewTextBoxColumn,
            this.ladleIDDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.CastingTundishWeight,
            this.remainWeightDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.ladleTypeDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.castingStartTimeDataGridViewTextBoxColumn,
            this.castingStopTimeDataGridViewTextBoxColumn,
            this.holdTimeDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.TempUpTo,
            this.holdTimeReasonDataGridViewTextBoxColumn,
            this.AutoFlow,
            this.UnAutoFlow_Reason,
            this.Protection,
            this.UnProtection_Reason});
            this.dvLadle.DataSource = this.bsLadle;
            this.dvLadle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvLadle.Location = new System.Drawing.Point(3, 3);
            this.dvLadle.MultiSelect = false;
            this.dvLadle.Name = "dvLadle";
            this.dvLadle.RowTemplate.Height = 23;
            this.dvLadle.Size = new System.Drawing.Size(965, 392);
            this.dvLadle.TabIndex = 97;
            this.dvLadle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn8
            // 
            this.heatIDDataGridViewTextBoxColumn8.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn8.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn8.Name = "heatIDDataGridViewTextBoxColumn8";
            this.heatIDDataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // treatNoDataGridViewTextBoxColumn2
            // 
            this.treatNoDataGridViewTextBoxColumn2.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn2.HeaderText = "连铸处理号";
            this.treatNoDataGridViewTextBoxColumn2.Name = "treatNoDataGridViewTextBoxColumn2";
            this.treatNoDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cCMIDDataGridViewTextBoxColumn
            // 
            this.cCMIDDataGridViewTextBoxColumn.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn.Name = "cCMIDDataGridViewTextBoxColumn";
            this.cCMIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ladleIDDataGridViewTextBoxColumn
            // 
            this.ladleIDDataGridViewTextBoxColumn.DataPropertyName = "LadleID";
            this.ladleIDDataGridViewTextBoxColumn.HeaderText = "钢包号";
            this.ladleIDDataGridViewTextBoxColumn.Name = "ladleIDDataGridViewTextBoxColumn";
            this.ladleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            dataGridViewCellStyle19.Format = "N3";
            this.weightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.weightDataGridViewTextBoxColumn.HeaderText = "大包重量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.Visible = false;
            // 
            // CastingTundishWeight
            // 
            this.CastingTundishWeight.DataPropertyName = "CastingTundishWeight";
            dataGridViewCellStyle20.Format = "N3";
            dataGridViewCellStyle20.NullValue = null;
            this.CastingTundishWeight.DefaultCellStyle = dataGridViewCellStyle20;
            this.CastingTundishWeight.HeaderText = "开浇时中包重量";
            this.CastingTundishWeight.Name = "CastingTundishWeight";
            this.CastingTundishWeight.ReadOnly = true;
            // 
            // remainWeightDataGridViewTextBoxColumn
            // 
            this.remainWeightDataGridViewTextBoxColumn.DataPropertyName = "RemainWeight";
            dataGridViewCellStyle21.Format = "N3";
            dataGridViewCellStyle21.NullValue = null;
            this.remainWeightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.remainWeightDataGridViewTextBoxColumn.HeaderText = "大包浇余[t]";
            this.remainWeightDataGridViewTextBoxColumn.Name = "remainWeightDataGridViewTextBoxColumn";
            this.remainWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "Arrival_Time";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "大包到达时刻";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrivalTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arrivalTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // ladleTypeDataGridViewTextBoxColumn
            // 
            this.ladleTypeDataGridViewTextBoxColumn.DataPropertyName = "LadleType";
            this.ladleTypeDataGridViewTextBoxColumn.HeaderText = "钢包包况";
            this.ladleTypeDataGridViewTextBoxColumn.Name = "ladleTypeDataGridViewTextBoxColumn";
            this.ladleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "Departure_Time";
            dataGridViewCellStyle22.Format = "G";
            dataGridViewCellStyle22.NullValue = null;
            this.departureTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "大包离开时刻";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.departureTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // castingStartTimeDataGridViewTextBoxColumn
            // 
            this.castingStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Casting_Start_Time";
            this.castingStartTimeDataGridViewTextBoxColumn.HeaderText = "大包开浇时间";
            this.castingStartTimeDataGridViewTextBoxColumn.Name = "castingStartTimeDataGridViewTextBoxColumn";
            this.castingStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.castingStartTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.castingStartTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.castingStartTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // castingStopTimeDataGridViewTextBoxColumn
            // 
            this.castingStopTimeDataGridViewTextBoxColumn.DataPropertyName = "Casting_Stop_Time";
            this.castingStopTimeDataGridViewTextBoxColumn.HeaderText = "大包停浇时间";
            this.castingStopTimeDataGridViewTextBoxColumn.Name = "castingStopTimeDataGridViewTextBoxColumn";
            this.castingStopTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.castingStopTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.castingStopTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.castingStopTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // holdTimeDataGridViewTextBoxColumn
            // 
            this.holdTimeDataGridViewTextBoxColumn.DataPropertyName = "HoldTime";
            this.holdTimeDataGridViewTextBoxColumn.HeaderText = "等压钢时间[″]";
            this.holdTimeDataGridViewTextBoxColumn.Name = "holdTimeDataGridViewTextBoxColumn";
            this.holdTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.holdTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "上机温度[℃]";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            this.tempDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempDataGridViewTextBoxColumn.Width = 110;
            // 
            // TempUpTo
            // 
            this.TempUpTo.DataPropertyName = "TempUpTo";
            this.TempUpTo.DataSource = this.dsCommonYesNo;
            this.TempUpTo.DisplayMember = "L3DataTable.Code_Des";
            this.TempUpTo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TempUpTo.HeaderText = "温度是否合格";
            this.TempUpTo.Name = "TempUpTo";
            this.TempUpTo.ReadOnly = true;
            this.TempUpTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TempUpTo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TempUpTo.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsCommonYesNo
            // 
            this.dsCommonYesNo.AutoLoad = true;
            this.dsCommonYesNo.AutoSubscribe = false;
            this.dsCommonYesNo.DataSetName = "L3DataSet";
            this.dsCommonYesNo.DeleteMethod = null;
            this.dsCommonYesNo.InsertMethod = null;
            this.dsCommonYesNo.L3DataAdapter = this.Adapter;
            this.dsCommonYesNo.LoadEvent = "Click";
            this.dsCommonYesNo.LoadTrigger = null;
            this.dsCommonYesNo.RefreshValve = 1000;
            this.dsCommonYesNo.SourceCommand = null;
            this.dsCommonYesNo.SourceCondition = "CODE_GROUP = \'COMMON_YESNO\' and code is not null order by code";
            this.dsCommonYesNo.SourceMethod = "";
            this.dsCommonYesNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCommonYesNo.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCommonYesNo.SubscribeTarget = null;
            this.dsCommonYesNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCommonYesNo});
            this.dsCommonYesNo.UpdateEvent = "Click";
            this.dsCommonYesNo.UpdateMethod = null;
            this.dsCommonYesNo.UpdateTrigger = null;
            // 
            // schemadsCommonYesNo
            // 
            this.schemadsCommonYesNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCommonYesNoL3DataTableCode,
            this.coldsCommonYesNoL3DataTableCode_Des,
            this.coldsCommonYesNoL3DataTableCode_Val_Long});
            this.schemadsCommonYesNo.TableName = "L3DataTable";
            // 
            // coldsCommonYesNoL3DataTableCode
            // 
            this.coldsCommonYesNoL3DataTableCode.Caption = "Code";
            this.coldsCommonYesNoL3DataTableCode.ColumnName = "Code";
            this.coldsCommonYesNoL3DataTableCode.Namespace = "";
            // 
            // coldsCommonYesNoL3DataTableCode_Des
            // 
            this.coldsCommonYesNoL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCommonYesNoL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCommonYesNoL3DataTableCode_Des.Namespace = "";
            // 
            // coldsCommonYesNoL3DataTableCode_Val_Long
            // 
            this.coldsCommonYesNoL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsCommonYesNoL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsCommonYesNoL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsCommonYesNoL3DataTableCode_Val_Long.Namespace = "";
            // 
            // holdTimeReasonDataGridViewTextBoxColumn
            // 
            this.holdTimeReasonDataGridViewTextBoxColumn.DataPropertyName = "HoldTime_Reason";
            this.holdTimeReasonDataGridViewTextBoxColumn.DataSource = this.dsHoldTimeReason;
            this.holdTimeReasonDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.holdTimeReasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.holdTimeReasonDataGridViewTextBoxColumn.HeaderText = "等压钢超时原因";
            this.holdTimeReasonDataGridViewTextBoxColumn.Name = "holdTimeReasonDataGridViewTextBoxColumn";
            this.holdTimeReasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.holdTimeReasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.holdTimeReasonDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsHoldTimeReason
            // 
            this.dsHoldTimeReason.AutoLoad = true;
            this.dsHoldTimeReason.AutoSubscribe = false;
            this.dsHoldTimeReason.DataSetName = "L3DataSet";
            this.dsHoldTimeReason.DeleteMethod = null;
            this.dsHoldTimeReason.InsertMethod = null;
            this.dsHoldTimeReason.L3DataAdapter = this.Adapter;
            this.dsHoldTimeReason.LoadEvent = "Click";
            this.dsHoldTimeReason.LoadTrigger = null;
            this.dsHoldTimeReason.RefreshValve = 1000;
            this.dsHoldTimeReason.SourceCommand = null;
            this.dsHoldTimeReason.SourceCondition = "CODE_GROUP = \'HoldTime_Reason\'";
            this.dsHoldTimeReason.SourceMethod = "";
            this.dsHoldTimeReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHoldTimeReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsHoldTimeReason.SubscribeTarget = null;
            this.dsHoldTimeReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHoldTimeReason});
            this.dsHoldTimeReason.UpdateEvent = "Click";
            this.dsHoldTimeReason.UpdateMethod = null;
            this.dsHoldTimeReason.UpdateTrigger = null;
            // 
            // schemadsHoldTimeReason
            // 
            this.schemadsHoldTimeReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHoldTimeReasonL3DataTableCode,
            this.coldsHoldTimeReasonL3DataTableCode_Des});
            this.schemadsHoldTimeReason.TableName = "L3DataTable";
            // 
            // coldsHoldTimeReasonL3DataTableCode
            // 
            this.coldsHoldTimeReasonL3DataTableCode.Caption = "Code";
            this.coldsHoldTimeReasonL3DataTableCode.ColumnName = "Code";
            this.coldsHoldTimeReasonL3DataTableCode.Namespace = "";
            // 
            // coldsHoldTimeReasonL3DataTableCode_Des
            // 
            this.coldsHoldTimeReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsHoldTimeReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsHoldTimeReasonL3DataTableCode_Des.Namespace = "";
            // 
            // AutoFlow
            // 
            this.AutoFlow.DataPropertyName = "AutoFlow";
            this.AutoFlow.DataSource = this.dsAutoFlow;
            this.AutoFlow.DisplayMember = "L3DataTable.Code_Des";
            this.AutoFlow.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.AutoFlow.HeaderText = "是否自动下流";
            this.AutoFlow.Name = "AutoFlow";
            this.AutoFlow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AutoFlow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AutoFlow.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsAutoFlow
            // 
            this.dsAutoFlow.AutoLoad = true;
            this.dsAutoFlow.AutoSubscribe = false;
            this.dsAutoFlow.DataSetName = "L3DataSet";
            this.dsAutoFlow.DeleteMethod = null;
            this.dsAutoFlow.InsertMethod = null;
            this.dsAutoFlow.L3DataAdapter = this.Adapter;
            this.dsAutoFlow.LoadEvent = "Click";
            this.dsAutoFlow.LoadTrigger = null;
            this.dsAutoFlow.RefreshValve = 1000;
            this.dsAutoFlow.SourceCommand = null;
            this.dsAutoFlow.SourceCondition = "Code_Group = \'CCM_AutoFlow\' and code is not null order by code";
            this.dsAutoFlow.SourceMethod = "";
            this.dsAutoFlow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAutoFlow.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAutoFlow.SubscribeTarget = null;
            this.dsAutoFlow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAutoFlow});
            this.dsAutoFlow.UpdateEvent = "Click";
            this.dsAutoFlow.UpdateMethod = null;
            this.dsAutoFlow.UpdateTrigger = null;
            // 
            // schemadsAutoFlow
            // 
            this.schemadsAutoFlow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAutoFlowL3DataTableCode,
            this.coldsAutoFlowL3DataTableCode_Des,
            this.coldsAutoFlowL3DataTableCode_Val_Long});
            this.schemadsAutoFlow.TableName = "L3DataTable";
            // 
            // coldsAutoFlowL3DataTableCode
            // 
            this.coldsAutoFlowL3DataTableCode.Caption = "Code";
            this.coldsAutoFlowL3DataTableCode.ColumnName = "Code";
            this.coldsAutoFlowL3DataTableCode.Namespace = "";
            // 
            // coldsAutoFlowL3DataTableCode_Des
            // 
            this.coldsAutoFlowL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAutoFlowL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAutoFlowL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAutoFlowL3DataTableCode_Val_Long
            // 
            this.coldsAutoFlowL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsAutoFlowL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsAutoFlowL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsAutoFlowL3DataTableCode_Val_Long.Namespace = "";
            // 
            // UnAutoFlow_Reason
            // 
            this.UnAutoFlow_Reason.DataPropertyName = "UnAutoFlow_Reason";
            this.UnAutoFlow_Reason.DataSource = this.dsUnAutoFlow_Reason;
            this.UnAutoFlow_Reason.DisplayMember = "L3DataTable.Code_Des";
            this.UnAutoFlow_Reason.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UnAutoFlow_Reason.HeaderText = "非自动下流原因";
            this.UnAutoFlow_Reason.Name = "UnAutoFlow_Reason";
            this.UnAutoFlow_Reason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnAutoFlow_Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnAutoFlow_Reason.ValueMember = "L3DataTable.Code";
            // 
            // dsUnAutoFlow_Reason
            // 
            this.dsUnAutoFlow_Reason.AutoLoad = true;
            this.dsUnAutoFlow_Reason.AutoSubscribe = false;
            this.dsUnAutoFlow_Reason.DataSetName = "L3DataSet";
            this.dsUnAutoFlow_Reason.DeleteMethod = null;
            this.dsUnAutoFlow_Reason.InsertMethod = null;
            this.dsUnAutoFlow_Reason.L3DataAdapter = this.Adapter;
            this.dsUnAutoFlow_Reason.LoadEvent = "Click";
            this.dsUnAutoFlow_Reason.LoadTrigger = null;
            this.dsUnAutoFlow_Reason.RefreshValve = 1000;
            this.dsUnAutoFlow_Reason.SourceCommand = null;
            this.dsUnAutoFlow_Reason.SourceCondition = "Code_Group = \'CCM_UnAutoFlow_Reason\' order by Code";
            this.dsUnAutoFlow_Reason.SourceMethod = "";
            this.dsUnAutoFlow_Reason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnAutoFlow_Reason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnAutoFlow_Reason.SubscribeTarget = null;
            this.dsUnAutoFlow_Reason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnAutoFlow_Reason});
            this.dsUnAutoFlow_Reason.UpdateEvent = "Click";
            this.dsUnAutoFlow_Reason.UpdateMethod = null;
            this.dsUnAutoFlow_Reason.UpdateTrigger = null;
            // 
            // schemadsUnAutoFlow_Reason
            // 
            this.schemadsUnAutoFlow_Reason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnAutoFlow_ReasonL3DataTableCode,
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Des,
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long});
            this.schemadsUnAutoFlow_Reason.TableName = "L3DataTable";
            // 
            // coldsUnAutoFlow_ReasonL3DataTableCode
            // 
            this.coldsUnAutoFlow_ReasonL3DataTableCode.Caption = "Code";
            this.coldsUnAutoFlow_ReasonL3DataTableCode.ColumnName = "Code";
            this.coldsUnAutoFlow_ReasonL3DataTableCode.Namespace = "";
            // 
            // coldsUnAutoFlow_ReasonL3DataTableCode_Des
            // 
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Des.Namespace = "";
            // 
            // coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long
            // 
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long.Namespace = "";
            // 
            // Protection
            // 
            this.Protection.DataPropertyName = "Protection";
            this.Protection.DataSource = this.dsCommonYesNo;
            this.Protection.DisplayMember = "L3DataTable.Code_Des";
            this.Protection.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Protection.HeaderText = "是否大包保护浇注";
            this.Protection.Name = "Protection";
            this.Protection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Protection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Protection.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // UnProtection_Reason
            // 
            this.UnProtection_Reason.DataPropertyName = "UnProtection_Reason";
            this.UnProtection_Reason.DataSource = this.dsUnProtectionReason;
            this.UnProtection_Reason.DisplayMember = "L3DataTable.Code_Des";
            this.UnProtection_Reason.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UnProtection_Reason.HeaderText = "未进行大包保护浇注原因";
            this.UnProtection_Reason.Name = "UnProtection_Reason";
            this.UnProtection_Reason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnProtection_Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnProtection_Reason.ValueMember = "L3DataTable.Code";
            this.UnProtection_Reason.Width = 162;
            // 
            // dsUnProtectionReason
            // 
            this.dsUnProtectionReason.AutoLoad = true;
            this.dsUnProtectionReason.AutoSubscribe = false;
            this.dsUnProtectionReason.DataSetName = "L3DataSet";
            this.dsUnProtectionReason.DeleteMethod = null;
            this.dsUnProtectionReason.InsertMethod = null;
            this.dsUnProtectionReason.L3DataAdapter = this.Adapter;
            this.dsUnProtectionReason.LoadEvent = "Click";
            this.dsUnProtectionReason.LoadTrigger = null;
            this.dsUnProtectionReason.RefreshValve = 1000;
            this.dsUnProtectionReason.SourceCommand = null;
            this.dsUnProtectionReason.SourceCondition = "CODE_GROUP = \'UnProtection_Reason\'";
            this.dsUnProtectionReason.SourceMethod = "";
            this.dsUnProtectionReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnProtectionReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnProtectionReason.SubscribeTarget = null;
            this.dsUnProtectionReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnProtectionReason});
            this.dsUnProtectionReason.UpdateEvent = "Click";
            this.dsUnProtectionReason.UpdateMethod = null;
            this.dsUnProtectionReason.UpdateTrigger = null;
            // 
            // schemadsUnProtectionReason
            // 
            this.schemadsUnProtectionReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnProtectionReasonL3DataTableCode,
            this.coldsUnProtectionReasonL3DataTableCode_Des});
            this.schemadsUnProtectionReason.TableName = "L3DataTable";
            // 
            // coldsUnProtectionReasonL3DataTableCode
            // 
            this.coldsUnProtectionReasonL3DataTableCode.Caption = "Code";
            this.coldsUnProtectionReasonL3DataTableCode.ColumnName = "Code";
            this.coldsUnProtectionReasonL3DataTableCode.Namespace = "";
            // 
            // coldsUnProtectionReasonL3DataTableCode_Des
            // 
            this.coldsUnProtectionReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnProtectionReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnProtectionReasonL3DataTableCode_Des.Namespace = "";
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
            this.dsLadle.L3DataAdapter = null;
            this.dsLadle.LoadEvent = "Click";
            this.dsLadle.LoadTrigger = null;
            this.dsLadle.RefreshValve = 1000;
            this.dsLadle.SourceCommand = null;
            this.dsLadle.SourceCondition = null;
            this.dsLadle.SourceMethod = "";
            this.dsLadle.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadle.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_Ladle";
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
            this.coldsLadleL3DataTableHeatID,
            this.coldsLadleL3DataTableTreatNo,
            this.coldsLadleL3DataTableCCMID,
            this.coldsLadleL3DataTableLadleID,
            this.coldsLadleL3DataTableWeight,
            this.coldsLadleL3DataTableRemainWeight,
            this.coldsLadleL3DataTableArrival_Time,
            this.coldsLadleL3DataTableLadleType,
            this.coldsLadleL3DataTableDeparture_Time,
            this.coldsLadleL3DataTableCasting_Start_Time,
            this.coldsLadleL3DataTableCasting_Stop_Time,
            this.coldsLadleL3DataTableHoldTime,
            this.coldsLadleL3DataTableTemp,
            this.coldsLadleL3DataTableTempUpTo,
            this.coldsLadleL3DataTableHoldTime_Reason,
            this.coldsLadleL3DataTableProtection,
            this.coldsLadleL3DataTableUnProtection_Reason,
            this.coldsLadleL3DataTableAutoFlow,
            this.coldsLadleL3DataTableUnAutoFlow_Reason,
            this.coldsLadleL3DataTableCastingTundishWeight});
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
            // coldsLadleL3DataTableHeatID
            // 
            this.coldsLadleL3DataTableHeatID.Caption = "HeatID";
            this.coldsLadleL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsLadleL3DataTableHeatID.Namespace = "";
            // 
            // coldsLadleL3DataTableTreatNo
            // 
            this.coldsLadleL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsLadleL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsLadleL3DataTableTreatNo.Namespace = "";
            // 
            // coldsLadleL3DataTableCCMID
            // 
            this.coldsLadleL3DataTableCCMID.Caption = "CCMID";
            this.coldsLadleL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsLadleL3DataTableCCMID.Namespace = "";
            // 
            // coldsLadleL3DataTableLadleID
            // 
            this.coldsLadleL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleL3DataTableLadleID.Namespace = "";
            // 
            // coldsLadleL3DataTableWeight
            // 
            this.coldsLadleL3DataTableWeight.Caption = "Weight";
            this.coldsLadleL3DataTableWeight.ColumnName = "Weight";
            this.coldsLadleL3DataTableWeight.DataType = typeof(float);
            this.coldsLadleL3DataTableWeight.Namespace = "";
            // 
            // coldsLadleL3DataTableRemainWeight
            // 
            this.coldsLadleL3DataTableRemainWeight.Caption = "RemainWeight";
            this.coldsLadleL3DataTableRemainWeight.ColumnName = "RemainWeight";
            this.coldsLadleL3DataTableRemainWeight.DataType = typeof(float);
            this.coldsLadleL3DataTableRemainWeight.Namespace = "";
            // 
            // coldsLadleL3DataTableArrival_Time
            // 
            this.coldsLadleL3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsLadleL3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsLadleL3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsLadleL3DataTableArrival_Time.Namespace = "";
            // 
            // coldsLadleL3DataTableLadleType
            // 
            this.coldsLadleL3DataTableLadleType.Caption = "LadleType";
            this.coldsLadleL3DataTableLadleType.ColumnName = "LadleType";
            this.coldsLadleL3DataTableLadleType.Namespace = "";
            // 
            // coldsLadleL3DataTableDeparture_Time
            // 
            this.coldsLadleL3DataTableDeparture_Time.Caption = "Departure_Time";
            this.coldsLadleL3DataTableDeparture_Time.ColumnName = "Departure_Time";
            this.coldsLadleL3DataTableDeparture_Time.DataType = typeof(System.DateTime);
            this.coldsLadleL3DataTableDeparture_Time.Namespace = "";
            // 
            // coldsLadleL3DataTableCasting_Start_Time
            // 
            this.coldsLadleL3DataTableCasting_Start_Time.Caption = "Casting_Start_Time";
            this.coldsLadleL3DataTableCasting_Start_Time.ColumnName = "Casting_Start_Time";
            this.coldsLadleL3DataTableCasting_Start_Time.DataType = typeof(System.DateTime);
            this.coldsLadleL3DataTableCasting_Start_Time.Namespace = "";
            // 
            // coldsLadleL3DataTableCasting_Stop_Time
            // 
            this.coldsLadleL3DataTableCasting_Stop_Time.Caption = "Casting_Stop_Time";
            this.coldsLadleL3DataTableCasting_Stop_Time.ColumnName = "Casting_Stop_Time";
            this.coldsLadleL3DataTableCasting_Stop_Time.DataType = typeof(System.DateTime);
            this.coldsLadleL3DataTableCasting_Stop_Time.Namespace = "";
            // 
            // coldsLadleL3DataTableHoldTime
            // 
            this.coldsLadleL3DataTableHoldTime.Caption = "HoldTime";
            this.coldsLadleL3DataTableHoldTime.ColumnName = "HoldTime";
            this.coldsLadleL3DataTableHoldTime.DataType = typeof(int);
            this.coldsLadleL3DataTableHoldTime.Namespace = "";
            // 
            // coldsLadleL3DataTableTemp
            // 
            this.coldsLadleL3DataTableTemp.Caption = "Temp";
            this.coldsLadleL3DataTableTemp.ColumnName = "Temp";
            this.coldsLadleL3DataTableTemp.DataType = typeof(int);
            this.coldsLadleL3DataTableTemp.Namespace = "";
            // 
            // coldsLadleL3DataTableTempUpTo
            // 
            this.coldsLadleL3DataTableTempUpTo.Caption = "TempUpTo";
            this.coldsLadleL3DataTableTempUpTo.ColumnName = "TempUpTo";
            this.coldsLadleL3DataTableTempUpTo.DataType = typeof(int);
            this.coldsLadleL3DataTableTempUpTo.Namespace = "";
            // 
            // coldsLadleL3DataTableHoldTime_Reason
            // 
            this.coldsLadleL3DataTableHoldTime_Reason.Caption = "HoldTime_Reason";
            this.coldsLadleL3DataTableHoldTime_Reason.ColumnName = "HoldTime_Reason";
            this.coldsLadleL3DataTableHoldTime_Reason.Namespace = "";
            // 
            // coldsLadleL3DataTableProtection
            // 
            this.coldsLadleL3DataTableProtection.Caption = "Protection";
            this.coldsLadleL3DataTableProtection.ColumnName = "Protection";
            this.coldsLadleL3DataTableProtection.DataType = typeof(int);
            this.coldsLadleL3DataTableProtection.Namespace = "";
            // 
            // coldsLadleL3DataTableUnProtection_Reason
            // 
            this.coldsLadleL3DataTableUnProtection_Reason.Caption = "UnProtection_Reason";
            this.coldsLadleL3DataTableUnProtection_Reason.ColumnName = "UnProtection_Reason";
            this.coldsLadleL3DataTableUnProtection_Reason.Namespace = "";
            // 
            // coldsLadleL3DataTableAutoFlow
            // 
            this.coldsLadleL3DataTableAutoFlow.Caption = "AutoFlow";
            this.coldsLadleL3DataTableAutoFlow.ColumnName = "AutoFlow";
            this.coldsLadleL3DataTableAutoFlow.DataType = typeof(int);
            this.coldsLadleL3DataTableAutoFlow.Namespace = "";
            // 
            // coldsLadleL3DataTableUnAutoFlow_Reason
            // 
            this.coldsLadleL3DataTableUnAutoFlow_Reason.Caption = "UnAutoFlow_Reason";
            this.coldsLadleL3DataTableUnAutoFlow_Reason.ColumnName = "UnAutoFlow_Reason";
            this.coldsLadleL3DataTableUnAutoFlow_Reason.Namespace = "";
            // 
            // coldsLadleL3DataTableCastingTundishWeight
            // 
            this.coldsLadleL3DataTableCastingTundishWeight.Caption = "CastingTundishWeight";
            this.coldsLadleL3DataTableCastingTundishWeight.ColumnName = "CastingTundishWeight";
            this.coldsLadleL3DataTableCastingTundishWeight.DataType = typeof(float);
            this.coldsLadleL3DataTableCastingTundishWeight.Namespace = "";
            // 
            // bnLadle
            // 
            this.bnLadle.AddNewItem = null;
            this.bnLadle.BindingSource = this.bsLadle;
            this.bnLadle.CountItem = this.bindingNavigatorCountItem;
            this.bnLadle.DeleteItem = null;
            this.bnLadle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAddLadle,
            this.tsTxtReason,
            this.tsLblReason});
            this.bnLadle.Location = new System.Drawing.Point(3, 3);
            this.bnLadle.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnLadle.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnLadle.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnLadle.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnLadle.Name = "bnLadle";
            this.bnLadle.PositionItem = this.bindingNavigatorPositionItem;
            this.bnLadle.Size = new System.Drawing.Size(965, 25);
            this.bnLadle.TabIndex = 96;
            this.bnLadle.Text = "bindingNavigator1";
            this.bnLadle.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            // tsTxtReason
            // 
            this.tsTxtReason.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsTxtReason.Name = "tsTxtReason";
            this.tsTxtReason.Size = new System.Drawing.Size(100, 25);
            // 
            // tsLblReason
            // 
            this.tsLblReason.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLblReason.Name = "tsLblReason";
            this.tsLblReason.Size = new System.Drawing.Size(95, 22);
            this.tsLblReason.Text = "等压钢超时原因:";
            // 
            // pnlLadle
            // 
            this.pnlLadle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLadle.Controls.Add(this.btnLadleCancel);
            this.pnlLadle.Controls.Add(this.btnLadleOK);
            this.pnlLadle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLadle.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlLadle.Location = new System.Drawing.Point(3, 395);
            this.pnlLadle.Name = "pnlLadle";
            this.pnlLadle.Size = new System.Drawing.Size(965, 32);
            this.pnlLadle.TabIndex = 95;
            // 
            // tabProtectCasting
            // 
            this.tabProtectCasting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProtectCasting.Controls.Add(this.dvProtectCasting);
            this.tabProtectCasting.Controls.Add(this.bnProtectCasting);
            this.tabProtectCasting.Controls.Add(this.pnlProtectCasting);
            this.tabProtectCasting.Location = new System.Drawing.Point(4, 22);
            this.tabProtectCasting.Name = "tabProtectCasting";
            this.tabProtectCasting.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtectCasting.Size = new System.Drawing.Size(973, 432);
            this.tabProtectCasting.TabIndex = 13;
            this.tabProtectCasting.Text = "保护浇注";
            this.tabProtectCasting.UseVisualStyleBackColor = true;
            // 
            // dvProtectCasting
            // 
            this.dvProtectCasting.AllowUserToAddRows = false;
            this.dvProtectCasting.AllowUserToDeleteRows = false;
            this.dvProtectCasting.AutoGenerateColumns = false;
            this.dvProtectCasting.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProtectCasting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn10,
            this.cCMIDDataGridViewTextBoxColumn2,
            this.startTimeDataGridViewTextBoxColumn1,
            this.stopTimeDataGridViewTextBoxColumn1,
            this.arFlowDataGridViewTextBoxColumn});
            this.dvProtectCasting.DataSource = this.bsProtectCasting;
            this.dvProtectCasting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProtectCasting.Location = new System.Drawing.Point(3, 28);
            this.dvProtectCasting.Name = "dvProtectCasting";
            this.dvProtectCasting.RowTemplate.Height = 23;
            this.dvProtectCasting.Size = new System.Drawing.Size(965, 367);
            this.dvProtectCasting.TabIndex = 95;
            this.dvProtectCasting.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn10
            // 
            this.heatIDDataGridViewTextBoxColumn10.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn10.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn10.Name = "heatIDDataGridViewTextBoxColumn10";
            // 
            // cCMIDDataGridViewTextBoxColumn2
            // 
            this.cCMIDDataGridViewTextBoxColumn2.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn2.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn2.Name = "cCMIDDataGridViewTextBoxColumn2";
            // 
            // startTimeDataGridViewTextBoxColumn1
            // 
            this.startTimeDataGridViewTextBoxColumn1.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn1.HeaderText = "中包开浇时刻";
            this.startTimeDataGridViewTextBoxColumn1.Name = "startTimeDataGridViewTextBoxColumn1";
            this.startTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.startTimeDataGridViewTextBoxColumn1.Width = 130;
            // 
            // stopTimeDataGridViewTextBoxColumn1
            // 
            this.stopTimeDataGridViewTextBoxColumn1.DataPropertyName = "Stop_Time";
            this.stopTimeDataGridViewTextBoxColumn1.HeaderText = "中包停浇时刻";
            this.stopTimeDataGridViewTextBoxColumn1.Name = "stopTimeDataGridViewTextBoxColumn1";
            this.stopTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stopTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stopTimeDataGridViewTextBoxColumn1.Width = 130;
            // 
            // arFlowDataGridViewTextBoxColumn
            // 
            this.arFlowDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arFlowDataGridViewTextBoxColumn.DataPropertyName = "Ar_Flow";
            this.arFlowDataGridViewTextBoxColumn.HeaderText = "保护浇注氩气流量";
            this.arFlowDataGridViewTextBoxColumn.Name = "arFlowDataGridViewTextBoxColumn";
            // 
            // bsProtectCasting
            // 
            this.bsProtectCasting.DataMember = "L3DataTable";
            this.bsProtectCasting.DataSource = this.dsProtectCasting;
            // 
            // dsProtectCasting
            // 
            this.dsProtectCasting.AutoLoad = true;
            this.dsProtectCasting.AutoSubscribe = false;
            this.dsProtectCasting.DataSetName = "L3DataSet";
            this.dsProtectCasting.DeleteMethod = null;
            this.dsProtectCasting.InsertMethod = null;
            this.dsProtectCasting.L3DataAdapter = null;
            this.dsProtectCasting.LoadEvent = "Click";
            this.dsProtectCasting.LoadTrigger = null;
            this.dsProtectCasting.RefreshValve = 1000;
            this.dsProtectCasting.SourceCommand = null;
            this.dsProtectCasting.SourceCondition = null;
            this.dsProtectCasting.SourceMethod = "";
            this.dsProtectCasting.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProtectCasting.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_ProtectCasting";
            this.dsProtectCasting.SubscribeTarget = null;
            this.dsProtectCasting.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProtectCasting});
            this.dsProtectCasting.UpdateEvent = "Click";
            this.dsProtectCasting.UpdateMethod = null;
            this.dsProtectCasting.UpdateTrigger = null;
            // 
            // schemadsProtectCasting
            // 
            this.schemadsProtectCasting.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProtectCastingL3DataTableGUID,
            this.coldsProtectCastingL3DataTableName,
            this.coldsProtectCastingL3DataTableHeatID,
            this.coldsProtectCastingL3DataTableCCMID,
            this.coldsProtectCastingL3DataTableStart_Time,
            this.coldsProtectCastingL3DataTableStop_Time,
            this.coldsProtectCastingL3DataTableAr_Flow});
            this.schemadsProtectCasting.TableName = "L3DataTable";
            // 
            // coldsProtectCastingL3DataTableGUID
            // 
            this.coldsProtectCastingL3DataTableGUID.Caption = "GUID";
            this.coldsProtectCastingL3DataTableGUID.ColumnName = "GUID";
            this.coldsProtectCastingL3DataTableGUID.Namespace = "";
            // 
            // coldsProtectCastingL3DataTableName
            // 
            this.coldsProtectCastingL3DataTableName.Caption = "Name";
            this.coldsProtectCastingL3DataTableName.ColumnName = "Name";
            this.coldsProtectCastingL3DataTableName.Namespace = "";
            // 
            // coldsProtectCastingL3DataTableHeatID
            // 
            this.coldsProtectCastingL3DataTableHeatID.Caption = "HeatID";
            this.coldsProtectCastingL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProtectCastingL3DataTableHeatID.Namespace = "";
            // 
            // coldsProtectCastingL3DataTableCCMID
            // 
            this.coldsProtectCastingL3DataTableCCMID.Caption = "CCMID";
            this.coldsProtectCastingL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsProtectCastingL3DataTableCCMID.Namespace = "";
            // 
            // coldsProtectCastingL3DataTableStart_Time
            // 
            this.coldsProtectCastingL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsProtectCastingL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsProtectCastingL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsProtectCastingL3DataTableStart_Time.Namespace = "";
            // 
            // coldsProtectCastingL3DataTableStop_Time
            // 
            this.coldsProtectCastingL3DataTableStop_Time.Caption = "Stop_Time";
            this.coldsProtectCastingL3DataTableStop_Time.ColumnName = "Stop_Time";
            this.coldsProtectCastingL3DataTableStop_Time.DataType = typeof(System.DateTime);
            this.coldsProtectCastingL3DataTableStop_Time.Namespace = "";
            // 
            // coldsProtectCastingL3DataTableAr_Flow
            // 
            this.coldsProtectCastingL3DataTableAr_Flow.Caption = "Ar_Flow";
            this.coldsProtectCastingL3DataTableAr_Flow.ColumnName = "Ar_Flow";
            this.coldsProtectCastingL3DataTableAr_Flow.DataType = typeof(float);
            this.coldsProtectCastingL3DataTableAr_Flow.Namespace = "";
            // 
            // bnProtectCasting
            // 
            this.bnProtectCasting.AddNewItem = null;
            this.bnProtectCasting.BindingSource = this.bsProtectCasting;
            this.bnProtectCasting.CountItem = this.bindingNavigatorCountItem2;
            this.bnProtectCasting.DeleteItem = null;
            this.bnProtectCasting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.btnAddProtectCasting});
            this.bnProtectCasting.Location = new System.Drawing.Point(3, 3);
            this.bnProtectCasting.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bnProtectCasting.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bnProtectCasting.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bnProtectCasting.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bnProtectCasting.Name = "bnProtectCasting";
            this.bnProtectCasting.PositionItem = this.bindingNavigatorPositionItem2;
            this.bnProtectCasting.Size = new System.Drawing.Size(965, 25);
            this.bnProtectCasting.TabIndex = 94;
            this.bnProtectCasting.Text = "bindingNavigator3";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(32, 22);
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
            // btnAddProtectCasting
            // 
            this.btnAddProtectCasting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddProtectCasting.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProtectCasting.Image")));
            this.btnAddProtectCasting.Name = "btnAddProtectCasting";
            this.btnAddProtectCasting.RightToLeftAutoMirrorImage = true;
            this.btnAddProtectCasting.Size = new System.Drawing.Size(23, 22);
            this.btnAddProtectCasting.Text = "新添";
            this.btnAddProtectCasting.Click += new System.EventHandler(this.btnAddProtectCasting_Click);
            // 
            // pnlProtectCasting
            // 
            this.pnlProtectCasting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProtectCasting.Controls.Add(this.btnProtectCastingCancel);
            this.pnlProtectCasting.Controls.Add(this.btnProtectCastingOK);
            this.pnlProtectCasting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProtectCasting.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlProtectCasting.Location = new System.Drawing.Point(3, 395);
            this.pnlProtectCasting.Name = "pnlProtectCasting";
            this.pnlProtectCasting.Size = new System.Drawing.Size(965, 32);
            this.pnlProtectCasting.TabIndex = 93;
            // 
            // btnProtectCastingCancel
            // 
            this.btnProtectCastingCancel.Location = new System.Drawing.Point(883, 3);
            this.btnProtectCastingCancel.Name = "btnProtectCastingCancel";
            this.btnProtectCastingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProtectCastingCancel.TabIndex = 87;
            this.btnProtectCastingCancel.Text = "取消";
            this.btnProtectCastingCancel.UseVisualStyleBackColor = true;
            this.btnProtectCastingCancel.Click += new System.EventHandler(this.btnProtectCastingCancel_Click);
            // 
            // btnProtectCastingOK
            // 
            this.btnProtectCastingOK.Location = new System.Drawing.Point(802, 3);
            this.btnProtectCastingOK.Name = "btnProtectCastingOK";
            this.btnProtectCastingOK.Size = new System.Drawing.Size(75, 23);
            this.btnProtectCastingOK.TabIndex = 86;
            this.btnProtectCastingOK.Text = "确认";
            this.btnProtectCastingOK.UseVisualStyleBackColor = true;
            this.btnProtectCastingOK.Click += new System.EventHandler(this.btnProtectCastingOK_Click);
            // 
            // tabProtectMat
            // 
            this.tabProtectMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProtectMat.Controls.Add(this.dvProtectMat);
            this.tabProtectMat.Controls.Add(this.bnProtectMat);
            this.tabProtectMat.Controls.Add(this.pnlProtectMat);
            this.tabProtectMat.Location = new System.Drawing.Point(4, 22);
            this.tabProtectMat.Name = "tabProtectMat";
            this.tabProtectMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtectMat.Size = new System.Drawing.Size(973, 432);
            this.tabProtectMat.TabIndex = 14;
            this.tabProtectMat.Text = "保护材质";
            this.tabProtectMat.UseVisualStyleBackColor = true;
            // 
            // dvProtectMat
            // 
            this.dvProtectMat.AllowUserToAddRows = false;
            this.dvProtectMat.AllowUserToDeleteRows = false;
            this.dvProtectMat.AutoGenerateColumns = false;
            this.dvProtectMat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProtectMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn11,
            this.cCMIDDataGridViewTextBoxColumn3,
            this.elementDataGridViewTextBoxColumn2,
            this.factoryDataGridViewTextBoxColumn1});
            this.dvProtectMat.DataSource = this.bsProtectMat;
            this.dvProtectMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProtectMat.Location = new System.Drawing.Point(3, 28);
            this.dvProtectMat.Name = "dvProtectMat";
            this.dvProtectMat.RowTemplate.Height = 23;
            this.dvProtectMat.Size = new System.Drawing.Size(965, 367);
            this.dvProtectMat.TabIndex = 95;
            this.dvProtectMat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn11
            // 
            this.heatIDDataGridViewTextBoxColumn11.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn11.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn11.Name = "heatIDDataGridViewTextBoxColumn11";
            // 
            // cCMIDDataGridViewTextBoxColumn3
            // 
            this.cCMIDDataGridViewTextBoxColumn3.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn3.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn3.Name = "cCMIDDataGridViewTextBoxColumn3";
            // 
            // elementDataGridViewTextBoxColumn2
            // 
            this.elementDataGridViewTextBoxColumn2.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn2.HeaderText = "保护套管材质";
            this.elementDataGridViewTextBoxColumn2.Name = "elementDataGridViewTextBoxColumn2";
            // 
            // factoryDataGridViewTextBoxColumn1
            // 
            this.factoryDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.factoryDataGridViewTextBoxColumn1.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn1.HeaderText = "保护套管产地";
            this.factoryDataGridViewTextBoxColumn1.Name = "factoryDataGridViewTextBoxColumn1";
            // 
            // bsProtectMat
            // 
            this.bsProtectMat.DataMember = "L3DataTable";
            this.bsProtectMat.DataSource = this.dsProtectMat;
            // 
            // dsProtectMat
            // 
            this.dsProtectMat.AutoLoad = true;
            this.dsProtectMat.AutoSubscribe = false;
            this.dsProtectMat.DataSetName = "L3DataSet";
            this.dsProtectMat.DeleteMethod = null;
            this.dsProtectMat.InsertMethod = null;
            this.dsProtectMat.L3DataAdapter = null;
            this.dsProtectMat.LoadEvent = "Click";
            this.dsProtectMat.LoadTrigger = null;
            this.dsProtectMat.RefreshValve = 1000;
            this.dsProtectMat.SourceCommand = null;
            this.dsProtectMat.SourceCondition = null;
            this.dsProtectMat.SourceMethod = "";
            this.dsProtectMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProtectMat.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_ProtectMat";
            this.dsProtectMat.SubscribeTarget = null;
            this.dsProtectMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProtectMat});
            this.dsProtectMat.UpdateEvent = "Click";
            this.dsProtectMat.UpdateMethod = null;
            this.dsProtectMat.UpdateTrigger = null;
            // 
            // schemadsProtectMat
            // 
            this.schemadsProtectMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProtectMatL3DataTableGUID,
            this.coldsProtectMatL3DataTableName,
            this.coldsProtectMatL3DataTableHeatID,
            this.coldsProtectMatL3DataTableCCMID,
            this.coldsProtectMatL3DataTableElement,
            this.coldsProtectMatL3DataTableFactory});
            this.schemadsProtectMat.TableName = "L3DataTable";
            // 
            // coldsProtectMatL3DataTableGUID
            // 
            this.coldsProtectMatL3DataTableGUID.Caption = "GUID";
            this.coldsProtectMatL3DataTableGUID.ColumnName = "GUID";
            this.coldsProtectMatL3DataTableGUID.Namespace = "";
            // 
            // coldsProtectMatL3DataTableName
            // 
            this.coldsProtectMatL3DataTableName.Caption = "Name";
            this.coldsProtectMatL3DataTableName.ColumnName = "Name";
            this.coldsProtectMatL3DataTableName.Namespace = "";
            // 
            // coldsProtectMatL3DataTableHeatID
            // 
            this.coldsProtectMatL3DataTableHeatID.Caption = "HeatID";
            this.coldsProtectMatL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProtectMatL3DataTableHeatID.Namespace = "";
            // 
            // coldsProtectMatL3DataTableCCMID
            // 
            this.coldsProtectMatL3DataTableCCMID.Caption = "CCMID";
            this.coldsProtectMatL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsProtectMatL3DataTableCCMID.Namespace = "";
            // 
            // coldsProtectMatL3DataTableElement
            // 
            this.coldsProtectMatL3DataTableElement.Caption = "Element";
            this.coldsProtectMatL3DataTableElement.ColumnName = "Element";
            this.coldsProtectMatL3DataTableElement.Namespace = "";
            // 
            // coldsProtectMatL3DataTableFactory
            // 
            this.coldsProtectMatL3DataTableFactory.Caption = "Factory";
            this.coldsProtectMatL3DataTableFactory.ColumnName = "Factory";
            this.coldsProtectMatL3DataTableFactory.Namespace = "";
            // 
            // bnProtectMat
            // 
            this.bnProtectMat.AddNewItem = null;
            this.bnProtectMat.BindingSource = this.bsProtectMat;
            this.bnProtectMat.CountItem = this.bindingNavigatorCountItem3;
            this.bnProtectMat.DeleteItem = null;
            this.bnProtectMat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.btnAddProtectMat,
            this.btnDelProtectMat});
            this.bnProtectMat.Location = new System.Drawing.Point(3, 3);
            this.bnProtectMat.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bnProtectMat.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bnProtectMat.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bnProtectMat.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bnProtectMat.Name = "bnProtectMat";
            this.bnProtectMat.PositionItem = this.bindingNavigatorPositionItem3;
            this.bnProtectMat.Size = new System.Drawing.Size(965, 25);
            this.bnProtectMat.TabIndex = 94;
            this.bnProtectMat.Text = "bindingNavigator4";
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(32, 22);
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
            // pnlProtectMat
            // 
            this.pnlProtectMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProtectMat.Controls.Add(this.btnProtectMatCancel);
            this.pnlProtectMat.Controls.Add(this.btnProtectMatOK);
            this.pnlProtectMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProtectMat.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlProtectMat.Location = new System.Drawing.Point(3, 395);
            this.pnlProtectMat.Name = "pnlProtectMat";
            this.pnlProtectMat.Size = new System.Drawing.Size(965, 32);
            this.pnlProtectMat.TabIndex = 93;
            // 
            // btnProtectMatCancel
            // 
            this.btnProtectMatCancel.Location = new System.Drawing.Point(883, 3);
            this.btnProtectMatCancel.Name = "btnProtectMatCancel";
            this.btnProtectMatCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProtectMatCancel.TabIndex = 87;
            this.btnProtectMatCancel.Text = "取消";
            this.btnProtectMatCancel.UseVisualStyleBackColor = true;
            this.btnProtectMatCancel.Click += new System.EventHandler(this.btnProtectMatCancel_Click);
            // 
            // tabProtectSlag
            // 
            this.tabProtectSlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProtectSlag.Controls.Add(this.hmiRootPanel2);
            this.tabProtectSlag.Controls.Add(this.pnlProtectSlag);
            this.tabProtectSlag.Controls.Add(this.bnProtectSlag);
            this.tabProtectSlag.Location = new System.Drawing.Point(4, 22);
            this.tabProtectSlag.Name = "tabProtectSlag";
            this.tabProtectSlag.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtectSlag.Size = new System.Drawing.Size(973, 432);
            this.tabProtectSlag.TabIndex = 15;
            this.tabProtectSlag.Text = "保护渣";
            this.tabProtectSlag.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.Controls.Add(this.dvProtectSlag);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(3, 28);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(965, 367);
            this.hmiRootPanel2.TabIndex = 100;
            // 
            // dvProtectSlag
            // 
            this.dvProtectSlag.AllowUserToAddRows = false;
            this.dvProtectSlag.AllowUserToDeleteRows = false;
            this.dvProtectSlag.AutoGenerateColumns = false;
            this.dvProtectSlag.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProtectSlag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn4,
            this.cCMIDDataGridViewCheckBoxColumn3,
            this.strandIDDataGridViewCheckBoxColumn,
            this.factoryDataGridViewTextBoxColumn,
            this.elementDataGridViewTextBoxColumn1,
            this.batchNoDataGridViewTextBoxColumn,
            this.Amount,
            this.UseInformation});
            this.dvProtectSlag.DataSource = this.bsProtectSlag;
            this.dvProtectSlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProtectSlag.Location = new System.Drawing.Point(0, 0);
            this.dvProtectSlag.Name = "dvProtectSlag";
            this.dvProtectSlag.RowHeadersVisible = false;
            this.dvProtectSlag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvProtectSlag.RowTemplate.Height = 23;
            this.dvProtectSlag.Size = new System.Drawing.Size(965, 367);
            this.dvProtectSlag.TabIndex = 0;
            this.dvProtectSlag.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn4
            // 
            this.heatIDDataGridViewTextBoxColumn4.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn4.Name = "heatIDDataGridViewTextBoxColumn4";
            // 
            // cCMIDDataGridViewCheckBoxColumn3
            // 
            this.cCMIDDataGridViewCheckBoxColumn3.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewCheckBoxColumn3.HeaderText = "铸机号";
            this.cCMIDDataGridViewCheckBoxColumn3.Name = "cCMIDDataGridViewCheckBoxColumn3";
            this.cCMIDDataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // strandIDDataGridViewCheckBoxColumn
            // 
            this.strandIDDataGridViewCheckBoxColumn.DataPropertyName = "StrandID";
            this.strandIDDataGridViewCheckBoxColumn.HeaderText = "结晶器流号";
            this.strandIDDataGridViewCheckBoxColumn.Name = "strandIDDataGridViewCheckBoxColumn";
            this.strandIDDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // factoryDataGridViewTextBoxColumn
            // 
            this.factoryDataGridViewTextBoxColumn.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn.DataSource = this.dsProtectSlagFac;
            this.factoryDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.MatFactory";
            this.factoryDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.factoryDataGridViewTextBoxColumn.HeaderText = "保护渣厂家";
            this.factoryDataGridViewTextBoxColumn.Name = "factoryDataGridViewTextBoxColumn";
            this.factoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.factoryDataGridViewTextBoxColumn.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsProtectSlagFac
            // 
            this.dsProtectSlagFac.AutoLoad = true;
            this.dsProtectSlagFac.AutoSubscribe = false;
            this.dsProtectSlagFac.DataSetName = "L3DataSet";
            this.dsProtectSlagFac.DeleteMethod = null;
            this.dsProtectSlagFac.InsertMethod = null;
            this.dsProtectSlagFac.L3DataAdapter = this.Adapter;
            this.dsProtectSlagFac.LoadEvent = "Click";
            this.dsProtectSlagFac.LoadTrigger = null;
            this.dsProtectSlagFac.RefreshValve = 1000;
            this.dsProtectSlagFac.SourceCommand = null;
            this.dsProtectSlagFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'保护渣\'";
            this.dsProtectSlagFac.SourceMethod = "";
            this.dsProtectSlagFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProtectSlagFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsProtectSlagFac.SubscribeTarget = null;
            this.dsProtectSlagFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProtectSlagFac});
            this.dsProtectSlagFac.UpdateEvent = "Click";
            this.dsProtectSlagFac.UpdateMethod = null;
            this.dsProtectSlagFac.UpdateTrigger = null;
            // 
            // schemadsProtectSlagFac
            // 
            this.schemadsProtectSlagFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProtectSlagFacL3DataTableMatFactory,
            this.coldsProtectSlagFacL3DataTableMatName,
            this.coldsProtectSlagFacL3DataTableMatGroup_Code,
            this.coldsProtectSlagFacL3DataTableMatGroup_Des});
            this.schemadsProtectSlagFac.TableName = "L3DataTable";
            // 
            // coldsProtectSlagFacL3DataTableMatFactory
            // 
            this.coldsProtectSlagFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsProtectSlagFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsProtectSlagFacL3DataTableMatFactory.Namespace = "";
            // 
            // coldsProtectSlagFacL3DataTableMatName
            // 
            this.coldsProtectSlagFacL3DataTableMatName.Caption = "MatName";
            this.coldsProtectSlagFacL3DataTableMatName.ColumnName = "MatName";
            this.coldsProtectSlagFacL3DataTableMatName.Namespace = "";
            // 
            // coldsProtectSlagFacL3DataTableMatGroup_Code
            // 
            this.coldsProtectSlagFacL3DataTableMatGroup_Code.Caption = "MatGroup_Code";
            this.coldsProtectSlagFacL3DataTableMatGroup_Code.ColumnName = "MatGroup_Code";
            this.coldsProtectSlagFacL3DataTableMatGroup_Code.Namespace = "";
            // 
            // coldsProtectSlagFacL3DataTableMatGroup_Des
            // 
            this.coldsProtectSlagFacL3DataTableMatGroup_Des.Caption = "MatGroup_Des";
            this.coldsProtectSlagFacL3DataTableMatGroup_Des.ColumnName = "MatGroup_Des";
            this.coldsProtectSlagFacL3DataTableMatGroup_Des.Namespace = "";
            // 
            // elementDataGridViewTextBoxColumn1
            // 
            this.elementDataGridViewTextBoxColumn1.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn1.DataSource = this.dsProtectSlagType;
            this.elementDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.elementDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.elementDataGridViewTextBoxColumn1.HeaderText = "保护渣型号";
            this.elementDataGridViewTextBoxColumn1.Name = "elementDataGridViewTextBoxColumn1";
            this.elementDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elementDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.elementDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            // 
            // dsProtectSlagType
            // 
            this.dsProtectSlagType.AutoLoad = true;
            this.dsProtectSlagType.AutoSubscribe = true;
            this.dsProtectSlagType.DataSetName = "L3DataSet";
            this.dsProtectSlagType.DeleteMethod = "";
            this.dsProtectSlagType.InsertMethod = "";
            this.dsProtectSlagType.L3DataAdapter = this.Adapter;
            this.dsProtectSlagType.LoadEvent = "";
            this.dsProtectSlagType.LoadTrigger = null;
            this.dsProtectSlagType.RefreshValve = 1000;
            this.dsProtectSlagType.SourceCommand = null;
            this.dsProtectSlagType.SourceCondition = "CODE_GROUP = \'Protect_Slag_Type\'";
            this.dsProtectSlagType.SourceMethod = "";
            this.dsProtectSlagType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProtectSlagType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsProtectSlagType.SubscribeTarget = null;
            this.dsProtectSlagType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProtectSlagType});
            this.dsProtectSlagType.UpdateEvent = "";
            this.dsProtectSlagType.UpdateMethod = "";
            this.dsProtectSlagType.UpdateTrigger = null;
            // 
            // schemadsProtectSlagType
            // 
            this.schemadsProtectSlagType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProtectSlagTypeL3DataTableCode,
            this.coldsProtectSlagTypeL3DataTableCode_Des});
            this.schemadsProtectSlagType.TableName = "L3DataTable";
            // 
            // coldsProtectSlagTypeL3DataTableCode
            // 
            this.coldsProtectSlagTypeL3DataTableCode.Caption = "Code";
            this.coldsProtectSlagTypeL3DataTableCode.ColumnName = "Code";
            this.coldsProtectSlagTypeL3DataTableCode.Namespace = "";
            // 
            // coldsProtectSlagTypeL3DataTableCode_Des
            // 
            this.coldsProtectSlagTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsProtectSlagTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsProtectSlagTypeL3DataTableCode_Des.Namespace = "";
            // 
            // batchNoDataGridViewTextBoxColumn
            // 
            this.batchNoDataGridViewTextBoxColumn.DataPropertyName = "BatchNo";
            this.batchNoDataGridViewTextBoxColumn.HeaderText = "保护渣验收批号";
            this.batchNoDataGridViewTextBoxColumn.Name = "batchNoDataGridViewTextBoxColumn";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "加入量[Kg]";
            this.Amount.Name = "Amount";
            // 
            // UseInformation
            // 
            this.UseInformation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UseInformation.DataPropertyName = "UseInformation";
            this.UseInformation.DataSource = this.dsProtectSlagUse;
            this.UseInformation.DisplayMember = "L3DataTable.Code_Des";
            this.UseInformation.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UseInformation.HeaderText = "使用情况";
            this.UseInformation.Name = "UseInformation";
            this.UseInformation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UseInformation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UseInformation.ValueMember = "L3DataTable.Code";
            // 
            // dsProtectSlagUse
            // 
            this.dsProtectSlagUse.AutoLoad = true;
            this.dsProtectSlagUse.AutoSubscribe = false;
            this.dsProtectSlagUse.DataSetName = "L3DataSet";
            this.dsProtectSlagUse.DeleteMethod = null;
            this.dsProtectSlagUse.InsertMethod = null;
            this.dsProtectSlagUse.L3DataAdapter = this.Adapter;
            this.dsProtectSlagUse.LoadEvent = "Click";
            this.dsProtectSlagUse.LoadTrigger = null;
            this.dsProtectSlagUse.RefreshValve = 1000;
            this.dsProtectSlagUse.SourceCommand = null;
            this.dsProtectSlagUse.SourceCondition = "Code_Group = \'Protect_Use_Case\' order by Code";
            this.dsProtectSlagUse.SourceMethod = "";
            this.dsProtectSlagUse.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProtectSlagUse.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsProtectSlagUse.SubscribeTarget = null;
            this.dsProtectSlagUse.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProtectSlagUse});
            this.dsProtectSlagUse.UpdateEvent = "Click";
            this.dsProtectSlagUse.UpdateMethod = null;
            this.dsProtectSlagUse.UpdateTrigger = null;
            // 
            // schemadsProtectSlagUse
            // 
            this.schemadsProtectSlagUse.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProtectSlagUseL3DataTableCode,
            this.coldsProtectSlagUseL3DataTableCode_Des});
            this.schemadsProtectSlagUse.TableName = "L3DataTable";
            // 
            // coldsProtectSlagUseL3DataTableCode
            // 
            this.coldsProtectSlagUseL3DataTableCode.Caption = "Code";
            this.coldsProtectSlagUseL3DataTableCode.ColumnName = "Code";
            this.coldsProtectSlagUseL3DataTableCode.Namespace = "";
            // 
            // coldsProtectSlagUseL3DataTableCode_Des
            // 
            this.coldsProtectSlagUseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsProtectSlagUseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsProtectSlagUseL3DataTableCode_Des.Namespace = "";
            // 
            // bsProtectSlag
            // 
            this.bsProtectSlag.DataMember = "L3DataTable";
            this.bsProtectSlag.DataSource = this.dsProtectSlag;
            // 
            // dsProtectSlag
            // 
            this.dsProtectSlag.AutoLoad = true;
            this.dsProtectSlag.AutoSubscribe = false;
            this.dsProtectSlag.DataSetName = "L3DataSet";
            this.dsProtectSlag.DeleteMethod = null;
            this.dsProtectSlag.InsertMethod = null;
            this.dsProtectSlag.L3DataAdapter = null;
            this.dsProtectSlag.LoadEvent = "Click";
            this.dsProtectSlag.LoadTrigger = null;
            this.dsProtectSlag.RefreshValve = 1000;
            this.dsProtectSlag.SourceCommand = null;
            this.dsProtectSlag.SourceCondition = null;
            this.dsProtectSlag.SourceMethod = "";
            this.dsProtectSlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProtectSlag.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_ProtectSlag";
            this.dsProtectSlag.SubscribeTarget = null;
            this.dsProtectSlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProtectSlag});
            this.dsProtectSlag.UpdateEvent = "Click";
            this.dsProtectSlag.UpdateMethod = null;
            this.dsProtectSlag.UpdateTrigger = null;
            // 
            // schemadsProtectSlag
            // 
            this.schemadsProtectSlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProtectSlagL3DataTableGUID,
            this.coldsProtectSlagL3DataTableName,
            this.coldsProtectSlagL3DataTableHeatID,
            this.coldsProtectSlagL3DataTableCCMID,
            this.coldsProtectSlagL3DataTableStrandID,
            this.coldsProtectSlagL3DataTableElement,
            this.coldsProtectSlagL3DataTableFactory,
            this.coldsProtectSlagL3DataTableBatchNo,
            this.coldsProtectSlagL3DataTableUseInformation,
            this.coldsProtectSlagL3DataTableAmount});
            this.schemadsProtectSlag.TableName = "L3DataTable";
            // 
            // coldsProtectSlagL3DataTableGUID
            // 
            this.coldsProtectSlagL3DataTableGUID.Caption = "GUID";
            this.coldsProtectSlagL3DataTableGUID.ColumnName = "GUID";
            this.coldsProtectSlagL3DataTableGUID.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableName
            // 
            this.coldsProtectSlagL3DataTableName.Caption = "Name";
            this.coldsProtectSlagL3DataTableName.ColumnName = "Name";
            this.coldsProtectSlagL3DataTableName.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableHeatID
            // 
            this.coldsProtectSlagL3DataTableHeatID.Caption = "HeatID";
            this.coldsProtectSlagL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProtectSlagL3DataTableHeatID.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableCCMID
            // 
            this.coldsProtectSlagL3DataTableCCMID.Caption = "CCMID";
            this.coldsProtectSlagL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsProtectSlagL3DataTableCCMID.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableStrandID
            // 
            this.coldsProtectSlagL3DataTableStrandID.Caption = "StrandID";
            this.coldsProtectSlagL3DataTableStrandID.ColumnName = "StrandID";
            this.coldsProtectSlagL3DataTableStrandID.DataType = typeof(int);
            this.coldsProtectSlagL3DataTableStrandID.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableElement
            // 
            this.coldsProtectSlagL3DataTableElement.Caption = "Element";
            this.coldsProtectSlagL3DataTableElement.ColumnName = "Element";
            this.coldsProtectSlagL3DataTableElement.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableFactory
            // 
            this.coldsProtectSlagL3DataTableFactory.Caption = "Factory";
            this.coldsProtectSlagL3DataTableFactory.ColumnName = "Factory";
            this.coldsProtectSlagL3DataTableFactory.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableBatchNo
            // 
            this.coldsProtectSlagL3DataTableBatchNo.Caption = "BatchNo";
            this.coldsProtectSlagL3DataTableBatchNo.ColumnName = "BatchNo";
            this.coldsProtectSlagL3DataTableBatchNo.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableUseInformation
            // 
            this.coldsProtectSlagL3DataTableUseInformation.Caption = "UseInformation";
            this.coldsProtectSlagL3DataTableUseInformation.ColumnName = "UseInformation";
            this.coldsProtectSlagL3DataTableUseInformation.Namespace = "";
            // 
            // coldsProtectSlagL3DataTableAmount
            // 
            this.coldsProtectSlagL3DataTableAmount.Caption = "Amount";
            this.coldsProtectSlagL3DataTableAmount.ColumnName = "Amount";
            this.coldsProtectSlagL3DataTableAmount.DataType = typeof(double);
            this.coldsProtectSlagL3DataTableAmount.Namespace = "";
            // 
            // pnlProtectSlag
            // 
            this.pnlProtectSlag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProtectSlag.Controls.Add(this.btnProtectSlagCancel);
            this.pnlProtectSlag.Controls.Add(this.btnProtectSlagOK);
            this.pnlProtectSlag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProtectSlag.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlProtectSlag.Location = new System.Drawing.Point(3, 395);
            this.pnlProtectSlag.Name = "pnlProtectSlag";
            this.pnlProtectSlag.Size = new System.Drawing.Size(965, 32);
            this.pnlProtectSlag.TabIndex = 99;
            // 
            // btnProtectSlagCancel
            // 
            this.btnProtectSlagCancel.Location = new System.Drawing.Point(883, 3);
            this.btnProtectSlagCancel.Name = "btnProtectSlagCancel";
            this.btnProtectSlagCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProtectSlagCancel.TabIndex = 87;
            this.btnProtectSlagCancel.Text = "取消";
            this.btnProtectSlagCancel.UseVisualStyleBackColor = true;
            this.btnProtectSlagCancel.Click += new System.EventHandler(this.btnProtectSlagCancel_Click);
            // 
            // bnProtectSlag
            // 
            this.bnProtectSlag.AddNewItem = null;
            this.bnProtectSlag.BindingSource = this.bsProtectSlag;
            this.bnProtectSlag.CountItem = this.toolStripLabel1;
            this.bnProtectSlag.DeleteItem = null;
            this.bnProtectSlag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.btnAddProtectSlag,
            this.btnDelProtectSlag});
            this.bnProtectSlag.Location = new System.Drawing.Point(3, 3);
            this.bnProtectSlag.MoveFirstItem = this.toolStripButton1;
            this.bnProtectSlag.MoveLastItem = this.toolStripButton4;
            this.bnProtectSlag.MoveNextItem = this.toolStripButton3;
            this.bnProtectSlag.MovePreviousItem = this.toolStripButton2;
            this.bnProtectSlag.Name = "bnProtectSlag";
            this.bnProtectSlag.PositionItem = this.toolStripTextBox1;
            this.bnProtectSlag.Size = new System.Drawing.Size(965, 25);
            this.bnProtectSlag.TabIndex = 98;
            this.bnProtectSlag.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
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
            // tabHoldTempMat
            // 
            this.tabHoldTempMat.Controls.Add(this.pnlHoldTempMat);
            this.tabHoldTempMat.Controls.Add(this.dvHoldTempMat);
            this.tabHoldTempMat.Controls.Add(this.bnHoldTempMat);
            this.tabHoldTempMat.Location = new System.Drawing.Point(4, 22);
            this.tabHoldTempMat.Name = "tabHoldTempMat";
            this.tabHoldTempMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoldTempMat.Size = new System.Drawing.Size(973, 432);
            this.tabHoldTempMat.TabIndex = 19;
            this.tabHoldTempMat.Text = "保温剂信息";
            this.tabHoldTempMat.UseVisualStyleBackColor = true;
            // 
            // pnlHoldTempMat
            // 
            this.pnlHoldTempMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHoldTempMat.Controls.Add(this.btnHoldTempMatCancel);
            this.pnlHoldTempMat.Controls.Add(this.btnHoldTempMatConfirm);
            this.pnlHoldTempMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHoldTempMat.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlHoldTempMat.Location = new System.Drawing.Point(3, 397);
            this.pnlHoldTempMat.Name = "pnlHoldTempMat";
            this.pnlHoldTempMat.Size = new System.Drawing.Size(967, 32);
            this.pnlHoldTempMat.TabIndex = 101;
            // 
            // btnHoldTempMatCancel
            // 
            this.btnHoldTempMatCancel.Location = new System.Drawing.Point(885, 3);
            this.btnHoldTempMatCancel.Name = "btnHoldTempMatCancel";
            this.btnHoldTempMatCancel.Size = new System.Drawing.Size(75, 23);
            this.btnHoldTempMatCancel.TabIndex = 87;
            this.btnHoldTempMatCancel.Text = "取消";
            this.btnHoldTempMatCancel.UseVisualStyleBackColor = true;
            this.btnHoldTempMatCancel.Click += new System.EventHandler(this.btnCastingCancel_Click);
            // 
            // dvHoldTempMat
            // 
            this.dvHoldTempMat.AllowUserToAddRows = false;
            this.dvHoldTempMat.AllowUserToDeleteRows = false;
            this.dvHoldTempMat.AutoGenerateColumns = false;
            this.dvHoldTempMat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvHoldTempMat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvHoldTempMat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHoldTempMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn15,
            this.cCMIDDataGridViewTextBoxColumn4,
            this.elementDataGridViewTextBoxColumn3,
            this.weightDataGridViewTextBoxColumn1,
            this.originDataGridViewTextBoxColumn1,
            this.batchIDDataGridViewTextBoxColumn,
            this.useInformationDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvHoldTempMat.DataSource = this.bsHoldTempMat;
            this.dvHoldTempMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHoldTempMat.Location = new System.Drawing.Point(3, 28);
            this.dvHoldTempMat.Name = "dvHoldTempMat";
            this.dvHoldTempMat.RowHeadersVisible = false;
            this.dvHoldTempMat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvHoldTempMat.RowTemplate.Height = 23;
            this.dvHoldTempMat.Size = new System.Drawing.Size(967, 401);
            this.dvHoldTempMat.TabIndex = 100;
            this.dvHoldTempMat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn15
            // 
            this.heatIDDataGridViewTextBoxColumn15.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn15.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn15.Name = "heatIDDataGridViewTextBoxColumn15";
            // 
            // cCMIDDataGridViewTextBoxColumn4
            // 
            this.cCMIDDataGridViewTextBoxColumn4.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn4.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn4.Name = "cCMIDDataGridViewTextBoxColumn4";
            // 
            // elementDataGridViewTextBoxColumn3
            // 
            this.elementDataGridViewTextBoxColumn3.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.elementDataGridViewTextBoxColumn3.HeaderText = "保温剂名称";
            this.elementDataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "碳化稻壳",
            "其他",
            ""});
            this.elementDataGridViewTextBoxColumn3.Name = "elementDataGridViewTextBoxColumn3";
            this.elementDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elementDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // weightDataGridViewTextBoxColumn1
            // 
            this.weightDataGridViewTextBoxColumn1.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn1.HeaderText = "保温剂数量[Kg]";
            this.weightDataGridViewTextBoxColumn1.Name = "weightDataGridViewTextBoxColumn1";
            // 
            // originDataGridViewTextBoxColumn1
            // 
            this.originDataGridViewTextBoxColumn1.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn1.DataSource = this.dsHoldTempOrigin;
            this.originDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.MatFactory";
            this.originDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.originDataGridViewTextBoxColumn1.HeaderText = "保温剂产地";
            this.originDataGridViewTextBoxColumn1.Name = "originDataGridViewTextBoxColumn1";
            this.originDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.originDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.originDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsHoldTempOrigin
            // 
            this.dsHoldTempOrigin.AutoLoad = true;
            this.dsHoldTempOrigin.AutoSubscribe = false;
            this.dsHoldTempOrigin.DataSetName = "L3DataSet";
            this.dsHoldTempOrigin.DeleteMethod = null;
            this.dsHoldTempOrigin.InsertMethod = null;
            this.dsHoldTempOrigin.L3DataAdapter = this.Adapter;
            this.dsHoldTempOrigin.LoadEvent = "Click";
            this.dsHoldTempOrigin.LoadTrigger = null;
            this.dsHoldTempOrigin.RefreshValve = 1000;
            this.dsHoldTempOrigin.SourceCommand = null;
            this.dsHoldTempOrigin.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and MATNAME = \'保温剂\'";
            this.dsHoldTempOrigin.SourceMethod = "";
            this.dsHoldTempOrigin.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHoldTempOrigin.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsHoldTempOrigin.SubscribeTarget = null;
            this.dsHoldTempOrigin.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHoldTempOrigin});
            this.dsHoldTempOrigin.UpdateEvent = "Click";
            this.dsHoldTempOrigin.UpdateMethod = null;
            this.dsHoldTempOrigin.UpdateTrigger = null;
            // 
            // schemadsHoldTempOrigin
            // 
            this.schemadsHoldTempOrigin.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHoldTempOriginL3DataTableMatFactory});
            this.schemadsHoldTempOrigin.TableName = "L3DataTable";
            // 
            // coldsHoldTempOriginL3DataTableMatFactory
            // 
            this.coldsHoldTempOriginL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsHoldTempOriginL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsHoldTempOriginL3DataTableMatFactory.Namespace = "";
            // 
            // batchIDDataGridViewTextBoxColumn
            // 
            this.batchIDDataGridViewTextBoxColumn.DataPropertyName = "Batch_ID";
            this.batchIDDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.batchIDDataGridViewTextBoxColumn.Name = "batchIDDataGridViewTextBoxColumn";
            // 
            // useInformationDataGridViewTextBoxColumn
            // 
            this.useInformationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.useInformationDataGridViewTextBoxColumn.DataPropertyName = "UseInformation";
            this.useInformationDataGridViewTextBoxColumn.DataSource = this.dsHoldTempMatUse;
            this.useInformationDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.useInformationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.useInformationDataGridViewTextBoxColumn.HeaderText = "使用情况";
            this.useInformationDataGridViewTextBoxColumn.Name = "useInformationDataGridViewTextBoxColumn";
            this.useInformationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.useInformationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.useInformationDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsHoldTempMatUse
            // 
            this.dsHoldTempMatUse.AutoLoad = true;
            this.dsHoldTempMatUse.AutoSubscribe = false;
            this.dsHoldTempMatUse.DataSetName = "L3DataSet";
            this.dsHoldTempMatUse.DeleteMethod = null;
            this.dsHoldTempMatUse.InsertMethod = null;
            this.dsHoldTempMatUse.L3DataAdapter = this.Adapter;
            this.dsHoldTempMatUse.LoadEvent = "Click";
            this.dsHoldTempMatUse.LoadTrigger = null;
            this.dsHoldTempMatUse.RefreshValve = 1000;
            this.dsHoldTempMatUse.SourceCommand = null;
            this.dsHoldTempMatUse.SourceCondition = "Code_Group = \'CCCM_Heat_HoldTempMat_UseInformation\' order by Code";
            this.dsHoldTempMatUse.SourceMethod = "";
            this.dsHoldTempMatUse.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHoldTempMatUse.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsHoldTempMatUse.SubscribeTarget = null;
            this.dsHoldTempMatUse.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHoldTempMatUse});
            this.dsHoldTempMatUse.UpdateEvent = "Click";
            this.dsHoldTempMatUse.UpdateMethod = null;
            this.dsHoldTempMatUse.UpdateTrigger = null;
            // 
            // schemadsHoldTempMatUse
            // 
            this.schemadsHoldTempMatUse.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHoldTempMatUseL3DataTableCode,
            this.coldsHoldTempMatUseL3DataTableCode_Des});
            this.schemadsHoldTempMatUse.TableName = "L3DataTable";
            // 
            // coldsHoldTempMatUseL3DataTableCode
            // 
            this.coldsHoldTempMatUseL3DataTableCode.Caption = "Code";
            this.coldsHoldTempMatUseL3DataTableCode.ColumnName = "Code";
            this.coldsHoldTempMatUseL3DataTableCode.Namespace = "";
            // 
            // coldsHoldTempMatUseL3DataTableCode_Des
            // 
            this.coldsHoldTempMatUseL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsHoldTempMatUseL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsHoldTempMatUseL3DataTableCode_Des.Namespace = "";
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsHoldTempMat
            // 
            this.bsHoldTempMat.DataMember = "L3DataTable";
            this.bsHoldTempMat.DataSource = this.dsHoldTempMat;
            // 
            // dsHoldTempMat
            // 
            this.dsHoldTempMat.AutoLoad = true;
            this.dsHoldTempMat.AutoSubscribe = false;
            this.dsHoldTempMat.DataSetName = "L3DataSet";
            this.dsHoldTempMat.DeleteMethod = null;
            this.dsHoldTempMat.InsertMethod = null;
            this.dsHoldTempMat.L3DataAdapter = null;
            this.dsHoldTempMat.LoadEvent = "Click";
            this.dsHoldTempMat.LoadTrigger = null;
            this.dsHoldTempMat.RefreshValve = 1000;
            this.dsHoldTempMat.SourceCommand = null;
            this.dsHoldTempMat.SourceCondition = "1=2";
            this.dsHoldTempMat.SourceMethod = "";
            this.dsHoldTempMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHoldTempMat.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_HoldTempMat";
            this.dsHoldTempMat.SubscribeTarget = null;
            this.dsHoldTempMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHoldTempMat});
            this.dsHoldTempMat.UpdateEvent = "Click";
            this.dsHoldTempMat.UpdateMethod = null;
            this.dsHoldTempMat.UpdateTrigger = null;
            // 
            // schemadsHoldTempMat
            // 
            this.schemadsHoldTempMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHoldTempMatL3DataTableGUID,
            this.coldsHoldTempMatL3DataTableName,
            this.coldsHoldTempMatL3DataTableHeatID,
            this.coldsHoldTempMatL3DataTableCCMID,
            this.coldsHoldTempMatL3DataTableElement,
            this.coldsHoldTempMatL3DataTableWeight,
            this.coldsHoldTempMatL3DataTableOrigin,
            this.coldsHoldTempMatL3DataTableBatch_ID,
            this.coldsHoldTempMatL3DataTableUseInformation});
            this.schemadsHoldTempMat.TableName = "L3DataTable";
            // 
            // coldsHoldTempMatL3DataTableGUID
            // 
            this.coldsHoldTempMatL3DataTableGUID.Caption = "GUID";
            this.coldsHoldTempMatL3DataTableGUID.ColumnName = "GUID";
            this.coldsHoldTempMatL3DataTableGUID.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableName
            // 
            this.coldsHoldTempMatL3DataTableName.Caption = "Name";
            this.coldsHoldTempMatL3DataTableName.ColumnName = "Name";
            this.coldsHoldTempMatL3DataTableName.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableHeatID
            // 
            this.coldsHoldTempMatL3DataTableHeatID.Caption = "HeatID";
            this.coldsHoldTempMatL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHoldTempMatL3DataTableHeatID.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableCCMID
            // 
            this.coldsHoldTempMatL3DataTableCCMID.Caption = "CCMID";
            this.coldsHoldTempMatL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsHoldTempMatL3DataTableCCMID.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableElement
            // 
            this.coldsHoldTempMatL3DataTableElement.Caption = "Element";
            this.coldsHoldTempMatL3DataTableElement.ColumnName = "Element";
            this.coldsHoldTempMatL3DataTableElement.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableWeight
            // 
            this.coldsHoldTempMatL3DataTableWeight.Caption = "Weight";
            this.coldsHoldTempMatL3DataTableWeight.ColumnName = "Weight";
            this.coldsHoldTempMatL3DataTableWeight.DataType = typeof(float);
            this.coldsHoldTempMatL3DataTableWeight.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableOrigin
            // 
            this.coldsHoldTempMatL3DataTableOrigin.Caption = "Origin";
            this.coldsHoldTempMatL3DataTableOrigin.ColumnName = "Origin";
            this.coldsHoldTempMatL3DataTableOrigin.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableBatch_ID
            // 
            this.coldsHoldTempMatL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsHoldTempMatL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsHoldTempMatL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsHoldTempMatL3DataTableUseInformation
            // 
            this.coldsHoldTempMatL3DataTableUseInformation.Caption = "UseInformation";
            this.coldsHoldTempMatL3DataTableUseInformation.ColumnName = "UseInformation";
            this.coldsHoldTempMatL3DataTableUseInformation.Namespace = "";
            // 
            // bnHoldTempMat
            // 
            this.bnHoldTempMat.AddNewItem = null;
            this.bnHoldTempMat.BindingSource = this.bsHoldTempMat;
            this.bnHoldTempMat.CountItem = this.toolStripLabel9;
            this.bnHoldTempMat.DeleteItem = null;
            this.bnHoldTempMat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton10,
            this.toolStripSeparator25,
            this.toolStripTextBox9,
            this.toolStripLabel9,
            this.toolStripSeparator26,
            this.toolStripButton11,
            this.toolStripButton16,
            this.toolStripSeparator27,
            this.btnAddHoldTempMat,
            this.btnDelHoldTempMat});
            this.bnHoldTempMat.Location = new System.Drawing.Point(3, 3);
            this.bnHoldTempMat.MoveFirstItem = this.toolStripButton5;
            this.bnHoldTempMat.MoveLastItem = this.toolStripButton16;
            this.bnHoldTempMat.MoveNextItem = this.toolStripButton11;
            this.bnHoldTempMat.MovePreviousItem = this.toolStripButton10;
            this.bnHoldTempMat.Name = "bnHoldTempMat";
            this.bnHoldTempMat.PositionItem = this.toolStripTextBox9;
            this.bnHoldTempMat.Size = new System.Drawing.Size(967, 25);
            this.bnHoldTempMat.TabIndex = 99;
            this.bnHoldTempMat.Text = "bindingNavigator7";
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel9.Text = "/ {0}";
            this.toolStripLabel9.ToolTipText = "总项数";
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
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "移到上一条记录";
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox9
            // 
            this.toolStripTextBox9.AccessibleName = "位置";
            this.toolStripTextBox9.AutoSize = false;
            this.toolStripTextBox9.Name = "toolStripTextBox9";
            this.toolStripTextBox9.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox9.Text = "0";
            this.toolStripTextBox9.ToolTipText = "当前位置";
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(6, 25);
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
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "移到最后一条记录";
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            this.toolStripSeparator27.Size = new System.Drawing.Size(6, 25);
            // 
            // tabSpeed
            // 
            this.tabSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSpeed.Controls.Add(this.hmiRootPanel3);
            this.tabSpeed.Controls.Add(this.pnlSpeed);
            this.tabSpeed.Controls.Add(this.bnSpeed);
            this.tabSpeed.Location = new System.Drawing.Point(4, 22);
            this.tabSpeed.Name = "tabSpeed";
            this.tabSpeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpeed.Size = new System.Drawing.Size(973, 432);
            this.tabSpeed.TabIndex = 16;
            this.tabSpeed.Text = "拉速";
            this.tabSpeed.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel3
            // 
            this.hmiRootPanel3.Controls.Add(this.dvSpeed);
            this.hmiRootPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel3.Location = new System.Drawing.Point(3, 28);
            this.hmiRootPanel3.Name = "hmiRootPanel3";
            this.hmiRootPanel3.Size = new System.Drawing.Size(965, 367);
            this.hmiRootPanel3.TabIndex = 100;
            // 
            // dvSpeed
            // 
            this.dvSpeed.AllowUserToAddRows = false;
            this.dvSpeed.AllowUserToDeleteRows = false;
            this.dvSpeed.AutoGenerateColumns = false;
            this.dvSpeed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSpeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn5,
            this.cCMIDDataGridViewCheckBoxColumn4,
            this.strandIDDataGridViewCheckBoxColumn1,
            this.speedDataGridViewTextBoxColumn,
            this.changeTimeDataGridViewTextBoxColumn1});
            this.dvSpeed.DataSource = this.bsSpeed;
            this.dvSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSpeed.Location = new System.Drawing.Point(0, 0);
            this.dvSpeed.Name = "dvSpeed";
            this.dvSpeed.RowHeadersVisible = false;
            this.dvSpeed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvSpeed.RowTemplate.Height = 23;
            this.dvSpeed.Size = new System.Drawing.Size(965, 367);
            this.dvSpeed.TabIndex = 0;
            this.dvSpeed.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn5
            // 
            this.heatIDDataGridViewTextBoxColumn5.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn5.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn5.Name = "heatIDDataGridViewTextBoxColumn5";
            // 
            // cCMIDDataGridViewCheckBoxColumn4
            // 
            this.cCMIDDataGridViewCheckBoxColumn4.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewCheckBoxColumn4.HeaderText = "铸机号";
            this.cCMIDDataGridViewCheckBoxColumn4.Name = "cCMIDDataGridViewCheckBoxColumn4";
            this.cCMIDDataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // strandIDDataGridViewCheckBoxColumn1
            // 
            this.strandIDDataGridViewCheckBoxColumn1.DataPropertyName = "StrandID";
            this.strandIDDataGridViewCheckBoxColumn1.HeaderText = "流号";
            this.strandIDDataGridViewCheckBoxColumn1.Name = "strandIDDataGridViewCheckBoxColumn1";
            this.strandIDDataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            this.speedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.speedDataGridViewTextBoxColumn.HeaderText = "拉速[m/min]";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            // 
            // changeTimeDataGridViewTextBoxColumn1
            // 
            this.changeTimeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeTimeDataGridViewTextBoxColumn1.DataPropertyName = "Change_Time";
            this.changeTimeDataGridViewTextBoxColumn1.HeaderText = "变化时刻";
            this.changeTimeDataGridViewTextBoxColumn1.Name = "changeTimeDataGridViewTextBoxColumn1";
            this.changeTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.changeTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsSpeed
            // 
            this.bsSpeed.DataMember = "L3DataTable";
            this.bsSpeed.DataSource = this.dsSpeed;
            // 
            // dsSpeed
            // 
            this.dsSpeed.AutoLoad = true;
            this.dsSpeed.AutoSubscribe = false;
            this.dsSpeed.DataSetName = "L3DataSet";
            this.dsSpeed.DeleteMethod = null;
            this.dsSpeed.InsertMethod = null;
            this.dsSpeed.L3DataAdapter = null;
            this.dsSpeed.LoadEvent = "Click";
            this.dsSpeed.LoadTrigger = null;
            this.dsSpeed.RefreshValve = 1000;
            this.dsSpeed.SourceCommand = null;
            this.dsSpeed.SourceCondition = null;
            this.dsSpeed.SourceMethod = "";
            this.dsSpeed.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSpeed.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_Speed";
            this.dsSpeed.SubscribeTarget = null;
            this.dsSpeed.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSpeed});
            this.dsSpeed.UpdateEvent = "Click";
            this.dsSpeed.UpdateMethod = null;
            this.dsSpeed.UpdateTrigger = null;
            // 
            // schemadsSpeed
            // 
            this.schemadsSpeed.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSpeedL3DataTableGUID,
            this.coldsSpeedL3DataTableName,
            this.coldsSpeedL3DataTableHeatID,
            this.coldsSpeedL3DataTableCCMID,
            this.coldsSpeedL3DataTableStrandID,
            this.coldsSpeedL3DataTableSpeed,
            this.coldsSpeedL3DataTableChange_Time});
            this.schemadsSpeed.TableName = "L3DataTable";
            // 
            // coldsSpeedL3DataTableGUID
            // 
            this.coldsSpeedL3DataTableGUID.Caption = "GUID";
            this.coldsSpeedL3DataTableGUID.ColumnName = "GUID";
            this.coldsSpeedL3DataTableGUID.Namespace = "";
            // 
            // coldsSpeedL3DataTableName
            // 
            this.coldsSpeedL3DataTableName.Caption = "Name";
            this.coldsSpeedL3DataTableName.ColumnName = "Name";
            this.coldsSpeedL3DataTableName.Namespace = "";
            // 
            // coldsSpeedL3DataTableHeatID
            // 
            this.coldsSpeedL3DataTableHeatID.Caption = "HeatID";
            this.coldsSpeedL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSpeedL3DataTableHeatID.Namespace = "";
            // 
            // coldsSpeedL3DataTableCCMID
            // 
            this.coldsSpeedL3DataTableCCMID.Caption = "CCMID";
            this.coldsSpeedL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsSpeedL3DataTableCCMID.Namespace = "";
            // 
            // coldsSpeedL3DataTableStrandID
            // 
            this.coldsSpeedL3DataTableStrandID.Caption = "StrandID";
            this.coldsSpeedL3DataTableStrandID.ColumnName = "StrandID";
            this.coldsSpeedL3DataTableStrandID.DataType = typeof(int);
            this.coldsSpeedL3DataTableStrandID.Namespace = "";
            // 
            // coldsSpeedL3DataTableSpeed
            // 
            this.coldsSpeedL3DataTableSpeed.Caption = "Speed";
            this.coldsSpeedL3DataTableSpeed.ColumnName = "Speed";
            this.coldsSpeedL3DataTableSpeed.DataType = typeof(float);
            this.coldsSpeedL3DataTableSpeed.Namespace = "";
            // 
            // coldsSpeedL3DataTableChange_Time
            // 
            this.coldsSpeedL3DataTableChange_Time.Caption = "Change_Time";
            this.coldsSpeedL3DataTableChange_Time.ColumnName = "Change_Time";
            this.coldsSpeedL3DataTableChange_Time.DataType = typeof(System.DateTime);
            this.coldsSpeedL3DataTableChange_Time.Namespace = "";
            // 
            // pnlSpeed
            // 
            this.pnlSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSpeed.Controls.Add(this.btnSpeedCancel);
            this.pnlSpeed.Controls.Add(this.btnSpeedOk);
            this.pnlSpeed.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpeed.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlSpeed.Location = new System.Drawing.Point(3, 395);
            this.pnlSpeed.Name = "pnlSpeed";
            this.pnlSpeed.Size = new System.Drawing.Size(965, 32);
            this.pnlSpeed.TabIndex = 99;
            // 
            // btnSpeedCancel
            // 
            this.btnSpeedCancel.Location = new System.Drawing.Point(883, 3);
            this.btnSpeedCancel.Name = "btnSpeedCancel";
            this.btnSpeedCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedCancel.TabIndex = 87;
            this.btnSpeedCancel.Text = "取消";
            this.btnSpeedCancel.UseVisualStyleBackColor = true;
            this.btnSpeedCancel.Click += new System.EventHandler(this.btnSpeedCancel_Click);
            // 
            // btnSpeedOk
            // 
            this.btnSpeedOk.Location = new System.Drawing.Point(802, 3);
            this.btnSpeedOk.Name = "btnSpeedOk";
            this.btnSpeedOk.Size = new System.Drawing.Size(75, 23);
            this.btnSpeedOk.TabIndex = 86;
            this.btnSpeedOk.Text = "确认";
            this.btnSpeedOk.UseVisualStyleBackColor = true;
            this.btnSpeedOk.Click += new System.EventHandler(this.btnSpeedOk_Click);
            // 
            // bnSpeed
            // 
            this.bnSpeed.AddNewItem = null;
            this.bnSpeed.BindingSource = this.bsSpeed;
            this.bnSpeed.CountItem = this.toolStripLabel2;
            this.bnSpeed.DeleteItem = null;
            this.bnSpeed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripSeparator6,
            this.btnAddSpeed,
            this.toolStripButton21});
            this.bnSpeed.Location = new System.Drawing.Point(3, 3);
            this.bnSpeed.MoveFirstItem = this.toolStripButton6;
            this.bnSpeed.MoveLastItem = this.toolStripButton9;
            this.bnSpeed.MoveNextItem = this.toolStripButton8;
            this.bnSpeed.MovePreviousItem = this.toolStripButton7;
            this.bnSpeed.Name = "bnSpeed";
            this.bnSpeed.PositionItem = this.toolStripTextBox2;
            this.bnSpeed.Size = new System.Drawing.Size(965, 25);
            this.bnSpeed.TabIndex = 98;
            this.bnSpeed.Text = "bindingNavigator2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "/ {0}";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到第一条记录";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到上一条记录";
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
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到下一条记录";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到最后一条记录";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddSpeed
            // 
            this.btnAddSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSpeed.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSpeed.Image")));
            this.btnAddSpeed.Name = "btnAddSpeed";
            this.btnAddSpeed.RightToLeftAutoMirrorImage = true;
            this.btnAddSpeed.Size = new System.Drawing.Size(23, 22);
            this.btnAddSpeed.Text = "新添";
            this.btnAddSpeed.Click += new System.EventHandler(this.btnAddSpeed_Click);
            // 
            // tabStrandInfo
            // 
            this.tabStrandInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabStrandInfo.Controls.Add(this.hmiRootPanel4);
            this.tabStrandInfo.Controls.Add(this.pnlStrandInfo);
            this.tabStrandInfo.Controls.Add(this.bnStrandInfo);
            this.tabStrandInfo.Location = new System.Drawing.Point(4, 22);
            this.tabStrandInfo.Name = "tabStrandInfo";
            this.tabStrandInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabStrandInfo.Size = new System.Drawing.Size(973, 432);
            this.tabStrandInfo.TabIndex = 17;
            this.tabStrandInfo.Text = "流数据";
            this.tabStrandInfo.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel4
            // 
            this.hmiRootPanel4.Controls.Add(this.dvStrandInfo);
            this.hmiRootPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel4.Location = new System.Drawing.Point(3, 28);
            this.hmiRootPanel4.Name = "hmiRootPanel4";
            this.hmiRootPanel4.Size = new System.Drawing.Size(965, 367);
            this.hmiRootPanel4.TabIndex = 100;
            // 
            // dvStrandInfo
            // 
            this.dvStrandInfo.AllowUserToAddRows = false;
            this.dvStrandInfo.AllowUserToDeleteRows = false;
            this.dvStrandInfo.AutoGenerateColumns = false;
            this.dvStrandInfo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvStrandInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn6,
            this.cCMIDDataGridViewCheckBoxColumn5,
            this.strandIDDataGridViewCheckBoxColumn2,
            this.softPressFlagDataGridViewCheckBoxColumn,
            this.autoControlDataGridViewCheckBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.stopTimeDataGridViewTextBoxColumn,
            this.castNumDataGridViewCheckBoxColumn,
            this.waterGapCenterDataGridViewCheckBoxColumn,
            this.waterGapDeepnessDataGridViewCheckBoxColumn,
            this.CastingStatus,
            this.Code,
            this.liquid_level,
            this.Block_Up,
            this.Block_Up_Reason,
            this.BreakOut_Num,
            this.MoldID,
            this.Copper_Fac,
            this.Copper_ID,
            this.Heat_Weight,
            this.Total_Weight});
            this.dvStrandInfo.DataSource = this.bsStrandInfo;
            this.dvStrandInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStrandInfo.Location = new System.Drawing.Point(0, 0);
            this.dvStrandInfo.Name = "dvStrandInfo";
            this.dvStrandInfo.RowHeadersVisible = false;
            this.dvStrandInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvStrandInfo.RowTemplate.Height = 23;
            this.dvStrandInfo.Size = new System.Drawing.Size(965, 367);
            this.dvStrandInfo.TabIndex = 0;
            this.dvStrandInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn6
            // 
            this.heatIDDataGridViewTextBoxColumn6.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn6.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn6.Name = "heatIDDataGridViewTextBoxColumn6";
            this.heatIDDataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // cCMIDDataGridViewCheckBoxColumn5
            // 
            this.cCMIDDataGridViewCheckBoxColumn5.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewCheckBoxColumn5.HeaderText = "铸机号";
            this.cCMIDDataGridViewCheckBoxColumn5.Name = "cCMIDDataGridViewCheckBoxColumn5";
            this.cCMIDDataGridViewCheckBoxColumn5.ReadOnly = true;
            this.cCMIDDataGridViewCheckBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // strandIDDataGridViewCheckBoxColumn2
            // 
            this.strandIDDataGridViewCheckBoxColumn2.DataPropertyName = "StrandID";
            this.strandIDDataGridViewCheckBoxColumn2.HeaderText = "流号";
            this.strandIDDataGridViewCheckBoxColumn2.Name = "strandIDDataGridViewCheckBoxColumn2";
            this.strandIDDataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // softPressFlagDataGridViewCheckBoxColumn
            // 
            this.softPressFlagDataGridViewCheckBoxColumn.DataPropertyName = "Soft_Press_Flag";
            this.softPressFlagDataGridViewCheckBoxColumn.DataSource = this.dsYesNo32;
            this.softPressFlagDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.softPressFlagDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.softPressFlagDataGridViewCheckBoxColumn.HeaderText = "轻压下";
            this.softPressFlagDataGridViewCheckBoxColumn.Name = "softPressFlagDataGridViewCheckBoxColumn";
            this.softPressFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            this.softPressFlagDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.softPressFlagDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.softPressFlagDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsYesNo32
            // 
            this.dsYesNo32.AutoLoad = true;
            this.dsYesNo32.AutoSubscribe = false;
            this.dsYesNo32.DataSetName = "L3DataSet";
            this.dsYesNo32.DeleteMethod = "";
            this.dsYesNo32.InsertMethod = "";
            this.dsYesNo32.L3DataAdapter = this.Adapter;
            this.dsYesNo32.LoadEvent = "";
            this.dsYesNo32.LoadTrigger = null;
            this.dsYesNo32.RefreshValve = 1000;
            this.dsYesNo32.SourceCommand = null;
            this.dsYesNo32.SourceCondition = "Code_Group = \'COMMON_YESNO\' and code is not null order by code";
            this.dsYesNo32.SourceMethod = "";
            this.dsYesNo32.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsYesNo32.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsYesNo32.SubscribeTarget = null;
            this.dsYesNo32.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsYesNo32});
            this.dsYesNo32.UpdateEvent = "";
            this.dsYesNo32.UpdateMethod = "";
            this.dsYesNo32.UpdateTrigger = null;
            // 
            // schemadsYesNo32
            // 
            this.schemadsYesNo32.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsYesNo32L3DataTableCode_Des,
            this.coldsYesNo32L3DataTableCode_Val_Long});
            this.schemadsYesNo32.TableName = "L3DataTable";
            // 
            // coldsYesNo32L3DataTableCode_Des
            // 
            this.coldsYesNo32L3DataTableCode_Des.Caption = "Code_Des";
            this.coldsYesNo32L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsYesNo32L3DataTableCode_Des.Namespace = "";
            // 
            // coldsYesNo32L3DataTableCode_Val_Long
            // 
            this.coldsYesNo32L3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsYesNo32L3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsYesNo32L3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsYesNo32L3DataTableCode_Val_Long.Namespace = "";
            // 
            // autoControlDataGridViewCheckBoxColumn
            // 
            this.autoControlDataGridViewCheckBoxColumn.DataPropertyName = "Auto_Control";
            this.autoControlDataGridViewCheckBoxColumn.DataSource = this.dsAutoContorl;
            this.autoControlDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.autoControlDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.autoControlDataGridViewCheckBoxColumn.HeaderText = "液面自动控制";
            this.autoControlDataGridViewCheckBoxColumn.Name = "autoControlDataGridViewCheckBoxColumn";
            this.autoControlDataGridViewCheckBoxColumn.ReadOnly = true;
            this.autoControlDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.autoControlDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.autoControlDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsAutoContorl
            // 
            this.dsAutoContorl.AutoLoad = true;
            this.dsAutoContorl.AutoSubscribe = false;
            this.dsAutoContorl.DataSetName = "L3DataSet";
            this.dsAutoContorl.DeleteMethod = "";
            this.dsAutoContorl.InsertMethod = "";
            this.dsAutoContorl.L3DataAdapter = this.Adapter;
            this.dsAutoContorl.LoadEvent = "";
            this.dsAutoContorl.LoadTrigger = null;
            this.dsAutoContorl.RefreshValve = 1000;
            this.dsAutoContorl.SourceCommand = null;
            this.dsAutoContorl.SourceCondition = "Code_Group = \'Auto_Control\' and code is not null order by code";
            this.dsAutoContorl.SourceMethod = "";
            this.dsAutoContorl.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAutoContorl.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAutoContorl.SubscribeTarget = null;
            this.dsAutoContorl.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAutoContorl});
            this.dsAutoContorl.UpdateEvent = "";
            this.dsAutoContorl.UpdateMethod = "";
            this.dsAutoContorl.UpdateTrigger = null;
            // 
            // schemadsAutoContorl
            // 
            this.schemadsAutoContorl.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAutoContorlL3DataTableCode_Des,
            this.coldsAutoContorlL3DataTableCode_Val_Long});
            this.schemadsAutoContorl.TableName = "L3DataTable";
            // 
            // coldsAutoContorlL3DataTableCode_Des
            // 
            this.coldsAutoContorlL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAutoContorlL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAutoContorlL3DataTableCode_Des.Namespace = "";
            // 
            // coldsAutoContorlL3DataTableCode_Val_Long
            // 
            this.coldsAutoContorlL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsAutoContorlL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsAutoContorlL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsAutoContorlL3DataTableCode_Val_Long.Namespace = "";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            dataGridViewCellStyle24.Format = "G";
            this.startTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "开浇时刻";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // stopTimeDataGridViewTextBoxColumn
            // 
            this.stopTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop_Time";
            dataGridViewCellStyle25.Format = "G";
            dataGridViewCellStyle25.NullValue = null;
            this.stopTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.stopTimeDataGridViewTextBoxColumn.HeaderText = "停浇时刻";
            this.stopTimeDataGridViewTextBoxColumn.Name = "stopTimeDataGridViewTextBoxColumn";
            this.stopTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stopTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // castNumDataGridViewCheckBoxColumn
            // 
            this.castNumDataGridViewCheckBoxColumn.DataPropertyName = "Cast_Num";
            this.castNumDataGridViewCheckBoxColumn.HeaderText = "流开浇次数";
            this.castNumDataGridViewCheckBoxColumn.Name = "castNumDataGridViewCheckBoxColumn";
            this.castNumDataGridViewCheckBoxColumn.ReadOnly = true;
            this.castNumDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // waterGapCenterDataGridViewCheckBoxColumn
            // 
            this.waterGapCenterDataGridViewCheckBoxColumn.DataPropertyName = "WaterGap_Center";
            this.waterGapCenterDataGridViewCheckBoxColumn.DataSource = this.dsBlock_Up;
            this.waterGapCenterDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.waterGapCenterDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.waterGapCenterDataGridViewCheckBoxColumn.HeaderText = "水口是否对中";
            this.waterGapCenterDataGridViewCheckBoxColumn.Name = "waterGapCenterDataGridViewCheckBoxColumn";
            this.waterGapCenterDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.waterGapCenterDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.waterGapCenterDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsBlock_Up
            // 
            this.dsBlock_Up.AutoLoad = true;
            this.dsBlock_Up.AutoSubscribe = false;
            this.dsBlock_Up.DataSetName = "L3DataSet";
            this.dsBlock_Up.DeleteMethod = null;
            this.dsBlock_Up.InsertMethod = null;
            this.dsBlock_Up.L3DataAdapter = this.Adapter;
            this.dsBlock_Up.LoadEvent = "Click";
            this.dsBlock_Up.LoadTrigger = null;
            this.dsBlock_Up.RefreshValve = 1000;
            this.dsBlock_Up.SourceCommand = null;
            this.dsBlock_Up.SourceCondition = "Code_Group = \'Block_Up\' and code is not null order by code";
            this.dsBlock_Up.SourceMethod = "";
            this.dsBlock_Up.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBlock_Up.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBlock_Up.SubscribeTarget = null;
            this.dsBlock_Up.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBlock_Up});
            this.dsBlock_Up.UpdateEvent = "Click";
            this.dsBlock_Up.UpdateMethod = null;
            this.dsBlock_Up.UpdateTrigger = null;
            // 
            // schemadsBlock_Up
            // 
            this.schemadsBlock_Up.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBlock_UpL3DataTableCode,
            this.coldsBlock_UpL3DataTableCode_Des,
            this.coldsBlock_UpL3DataTableCode_Val_Long});
            this.schemadsBlock_Up.TableName = "L3DataTable";
            // 
            // coldsBlock_UpL3DataTableCode
            // 
            this.coldsBlock_UpL3DataTableCode.Caption = "Code";
            this.coldsBlock_UpL3DataTableCode.ColumnName = "Code";
            this.coldsBlock_UpL3DataTableCode.Namespace = "";
            // 
            // coldsBlock_UpL3DataTableCode_Des
            // 
            this.coldsBlock_UpL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBlock_UpL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBlock_UpL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBlock_UpL3DataTableCode_Val_Long
            // 
            this.coldsBlock_UpL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBlock_UpL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBlock_UpL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsBlock_UpL3DataTableCode_Val_Long.Namespace = "";
            // 
            // waterGapDeepnessDataGridViewCheckBoxColumn
            // 
            this.waterGapDeepnessDataGridViewCheckBoxColumn.DataPropertyName = "WaterGap_Deepness";
            this.waterGapDeepnessDataGridViewCheckBoxColumn.HeaderText = "水口深度[mm]";
            this.waterGapDeepnessDataGridViewCheckBoxColumn.Name = "waterGapDeepnessDataGridViewCheckBoxColumn";
            this.waterGapDeepnessDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CastingStatus
            // 
            this.CastingStatus.DataPropertyName = "CastingStatus";
            this.CastingStatus.HeaderText = "开停机状态";
            this.CastingStatus.Name = "CastingStatus";
            this.CastingStatus.ReadOnly = true;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "机构编号";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // liquid_level
            // 
            this.liquid_level.DataPropertyName = "liquid_level";
            this.liquid_level.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.liquid_level.HeaderText = "液面波动";
            this.liquid_level.Items.AddRange(new object[] {
            "正常",
            "超标"});
            this.liquid_level.Name = "liquid_level";
            this.liquid_level.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.liquid_level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Block_Up
            // 
            this.Block_Up.DataPropertyName = "Block_Up";
            this.Block_Up.DataSource = this.dsYesNo32;
            this.Block_Up.DisplayMember = "L3DataTable.Code_Des";
            this.Block_Up.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Block_Up.HeaderText = "是否堵流";
            this.Block_Up.Name = "Block_Up";
            this.Block_Up.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // Block_Up_Reason
            // 
            this.Block_Up_Reason.DataPropertyName = "Block_Up_Reason";
            this.Block_Up_Reason.DataSource = this.dsBlock_Up_Reason;
            this.Block_Up_Reason.DisplayMember = "L3DataTable.Code_Des";
            this.Block_Up_Reason.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Block_Up_Reason.HeaderText = "堵流原因";
            this.Block_Up_Reason.Name = "Block_Up_Reason";
            this.Block_Up_Reason.ValueMember = "L3DataTable.Code";
            // 
            // dsBlock_Up_Reason
            // 
            this.dsBlock_Up_Reason.AutoLoad = true;
            this.dsBlock_Up_Reason.AutoSubscribe = false;
            this.dsBlock_Up_Reason.DataSetName = "L3DataSet";
            this.dsBlock_Up_Reason.DeleteMethod = null;
            this.dsBlock_Up_Reason.InsertMethod = null;
            this.dsBlock_Up_Reason.L3DataAdapter = this.Adapter;
            this.dsBlock_Up_Reason.LoadEvent = "Click";
            this.dsBlock_Up_Reason.LoadTrigger = null;
            this.dsBlock_Up_Reason.RefreshValve = 1000;
            this.dsBlock_Up_Reason.SourceCommand = null;
            this.dsBlock_Up_Reason.SourceCondition = "Code_Group = \'CCM_Block_Up_Reason\' order by Code";
            this.dsBlock_Up_Reason.SourceMethod = "";
            this.dsBlock_Up_Reason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBlock_Up_Reason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBlock_Up_Reason.SubscribeTarget = null;
            this.dsBlock_Up_Reason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBlock_Up_Reason});
            this.dsBlock_Up_Reason.UpdateEvent = "Click";
            this.dsBlock_Up_Reason.UpdateMethod = null;
            this.dsBlock_Up_Reason.UpdateTrigger = null;
            // 
            // schemadsBlock_Up_Reason
            // 
            this.schemadsBlock_Up_Reason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBlock_Up_ReasonL3DataTableCode,
            this.coldsBlock_Up_ReasonL3DataTableCode_Des,
            this.coldsBlock_Up_ReasonL3DataTableCode_Val_Long});
            this.schemadsBlock_Up_Reason.TableName = "L3DataTable";
            // 
            // coldsBlock_Up_ReasonL3DataTableCode
            // 
            this.coldsBlock_Up_ReasonL3DataTableCode.Caption = "Code";
            this.coldsBlock_Up_ReasonL3DataTableCode.ColumnName = "Code";
            this.coldsBlock_Up_ReasonL3DataTableCode.Namespace = "";
            // 
            // coldsBlock_Up_ReasonL3DataTableCode_Des
            // 
            this.coldsBlock_Up_ReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBlock_Up_ReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBlock_Up_ReasonL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBlock_Up_ReasonL3DataTableCode_Val_Long
            // 
            this.coldsBlock_Up_ReasonL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBlock_Up_ReasonL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBlock_Up_ReasonL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsBlock_Up_ReasonL3DataTableCode_Val_Long.Namespace = "";
            // 
            // BreakOut_Num
            // 
            this.BreakOut_Num.DataPropertyName = "BreakOut_Num";
            this.BreakOut_Num.HeaderText = "漏钢次数";
            this.BreakOut_Num.Name = "BreakOut_Num";
            // 
            // MoldID
            // 
            this.MoldID.DataPropertyName = "MoldID";
            this.MoldID.HeaderText = "结晶器编号";
            this.MoldID.Name = "MoldID";
            this.MoldID.ReadOnly = true;
            // 
            // Copper_Fac
            // 
            this.Copper_Fac.DataPropertyName = "Copper_Fac";
            this.Copper_Fac.DataSource = this.dsCopper_Fac;
            this.Copper_Fac.DisplayMember = "L3DataTable.MATFACTORY";
            this.Copper_Fac.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Copper_Fac.HeaderText = "铜管(板)厂家";
            this.Copper_Fac.Name = "Copper_Fac";
            this.Copper_Fac.ReadOnly = true;
            this.Copper_Fac.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Copper_Fac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Copper_Fac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsCopper_Fac
            // 
            this.dsCopper_Fac.AutoLoad = true;
            this.dsCopper_Fac.AutoSubscribe = false;
            this.dsCopper_Fac.DataSetName = "L3DataSet";
            this.dsCopper_Fac.DeleteMethod = null;
            this.dsCopper_Fac.InsertMethod = null;
            this.dsCopper_Fac.L3DataAdapter = this.Adapter;
            this.dsCopper_Fac.LoadEvent = "Click";
            this.dsCopper_Fac.LoadTrigger = null;
            this.dsCopper_Fac.RefreshValve = 1000;
            this.dsCopper_Fac.SourceCommand = null;
            this.dsCopper_Fac.SourceCondition = "(MatName = \'铜管\' or MatName = \'铜板\') and MatGroup_Code = \'MoldFac\'";
            this.dsCopper_Fac.SourceMethod = "";
            this.dsCopper_Fac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCopper_Fac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCopper_Fac.SubscribeTarget = null;
            this.dsCopper_Fac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCopper_Fac});
            this.dsCopper_Fac.UpdateEvent = "Click";
            this.dsCopper_Fac.UpdateMethod = null;
            this.dsCopper_Fac.UpdateTrigger = null;
            // 
            // schemadsCopper_Fac
            // 
            this.schemadsCopper_Fac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCopper_FacL3DataTableMATFACTORY});
            this.schemadsCopper_Fac.TableName = "L3DataTable";
            // 
            // coldsCopper_FacL3DataTableMATFACTORY
            // 
            this.coldsCopper_FacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsCopper_FacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsCopper_FacL3DataTableMATFACTORY.Namespace = "";
            // 
            // Copper_ID
            // 
            this.Copper_ID.DataPropertyName = "Copper_ID";
            this.Copper_ID.HeaderText = "铜管(板)编号";
            this.Copper_ID.Name = "Copper_ID";
            this.Copper_ID.ReadOnly = true;
            // 
            // Heat_Weight
            // 
            this.Heat_Weight.DataPropertyName = "Heat_Weight";
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = null;
            this.Heat_Weight.DefaultCellStyle = dataGridViewCellStyle26;
            this.Heat_Weight.HeaderText = "炉次通钢量[t]";
            this.Heat_Weight.Name = "Heat_Weight";
            this.Heat_Weight.ReadOnly = true;
            // 
            // Total_Weight
            // 
            this.Total_Weight.DataPropertyName = "Total_Weight";
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = null;
            this.Total_Weight.DefaultCellStyle = dataGridViewCellStyle27;
            this.Total_Weight.HeaderText = "累计通钢量[t]";
            this.Total_Weight.Name = "Total_Weight";
            this.Total_Weight.ReadOnly = true;
            // 
            // bsStrandInfo
            // 
            this.bsStrandInfo.DataMember = "L3DataTable";
            this.bsStrandInfo.DataSource = this.dsStrandInfo;
            // 
            // dsStrandInfo
            // 
            this.dsStrandInfo.AutoLoad = true;
            this.dsStrandInfo.AutoSubscribe = false;
            this.dsStrandInfo.DataSetName = "L3DataSet";
            this.dsStrandInfo.DeleteMethod = null;
            this.dsStrandInfo.InsertMethod = null;
            this.dsStrandInfo.L3DataAdapter = null;
            this.dsStrandInfo.LoadEvent = "Click";
            this.dsStrandInfo.LoadTrigger = null;
            this.dsStrandInfo.RefreshValve = 1000;
            this.dsStrandInfo.SourceCommand = null;
            this.dsStrandInfo.SourceCondition = null;
            this.dsStrandInfo.SourceMethod = "";
            this.dsStrandInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStrandInfo.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_StrandInfo";
            this.dsStrandInfo.SubscribeTarget = null;
            this.dsStrandInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStrandInfo});
            this.dsStrandInfo.UpdateEvent = "Click";
            this.dsStrandInfo.UpdateMethod = null;
            this.dsStrandInfo.UpdateTrigger = null;
            // 
            // schemadsStrandInfo
            // 
            this.schemadsStrandInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStrandInfoL3DataTableGUID,
            this.coldsStrandInfoL3DataTableName,
            this.coldsStrandInfoL3DataTableHeatID,
            this.coldsStrandInfoL3DataTableCCMID,
            this.coldsStrandInfoL3DataTableStrandID,
            this.coldsStrandInfoL3DataTableSoft_Press_Flag,
            this.coldsStrandInfoL3DataTableAuto_Control,
            this.coldsStrandInfoL3DataTableStart_Time,
            this.coldsStrandInfoL3DataTableStop_Time,
            this.coldsStrandInfoL3DataTableCast_Num,
            this.coldsStrandInfoL3DataTableWaterGap_Center,
            this.coldsStrandInfoL3DataTableWaterGap_Deepness,
            this.coldsStrandInfoL3DataTableCastingStatus,
            this.coldsStrandInfoL3DataTableCode,
            this.coldsStrandInfoL3DataTableliquid_level,
            this.coldsStrandInfoL3DataTableBlock_Up,
            this.coldsStrandInfoL3DataTableBlock_Up_Reason,
            this.coldsStrandInfoL3DataTableBreakOut_Num,
            this.coldsStrandInfoL3DataTableMoldID,
            this.coldsStrandInfoL3DataTableCopper_Fac,
            this.coldsStrandInfoL3DataTableCopper_ID,
            this.coldsStrandInfoL3DataTableHeat_Weight,
            this.coldsStrandInfoL3DataTableTotal_Weight});
            this.schemadsStrandInfo.TableName = "L3DataTable";
            // 
            // coldsStrandInfoL3DataTableGUID
            // 
            this.coldsStrandInfoL3DataTableGUID.Caption = "GUID";
            this.coldsStrandInfoL3DataTableGUID.ColumnName = "GUID";
            this.coldsStrandInfoL3DataTableGUID.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableName
            // 
            this.coldsStrandInfoL3DataTableName.Caption = "Name";
            this.coldsStrandInfoL3DataTableName.ColumnName = "Name";
            this.coldsStrandInfoL3DataTableName.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableHeatID
            // 
            this.coldsStrandInfoL3DataTableHeatID.Caption = "HeatID";
            this.coldsStrandInfoL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsStrandInfoL3DataTableHeatID.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableCCMID
            // 
            this.coldsStrandInfoL3DataTableCCMID.Caption = "CCMID";
            this.coldsStrandInfoL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsStrandInfoL3DataTableCCMID.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableStrandID
            // 
            this.coldsStrandInfoL3DataTableStrandID.Caption = "StrandID";
            this.coldsStrandInfoL3DataTableStrandID.ColumnName = "StrandID";
            this.coldsStrandInfoL3DataTableStrandID.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableStrandID.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableSoft_Press_Flag
            // 
            this.coldsStrandInfoL3DataTableSoft_Press_Flag.Caption = "Soft_Press_Flag";
            this.coldsStrandInfoL3DataTableSoft_Press_Flag.ColumnName = "Soft_Press_Flag";
            this.coldsStrandInfoL3DataTableSoft_Press_Flag.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableSoft_Press_Flag.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableAuto_Control
            // 
            this.coldsStrandInfoL3DataTableAuto_Control.Caption = "Auto_Control";
            this.coldsStrandInfoL3DataTableAuto_Control.ColumnName = "Auto_Control";
            this.coldsStrandInfoL3DataTableAuto_Control.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableAuto_Control.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableStart_Time
            // 
            this.coldsStrandInfoL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsStrandInfoL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsStrandInfoL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsStrandInfoL3DataTableStart_Time.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableStop_Time
            // 
            this.coldsStrandInfoL3DataTableStop_Time.Caption = "Stop_Time";
            this.coldsStrandInfoL3DataTableStop_Time.ColumnName = "Stop_Time";
            this.coldsStrandInfoL3DataTableStop_Time.DataType = typeof(System.DateTime);
            this.coldsStrandInfoL3DataTableStop_Time.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableCast_Num
            // 
            this.coldsStrandInfoL3DataTableCast_Num.Caption = "Cast_Num";
            this.coldsStrandInfoL3DataTableCast_Num.ColumnName = "Cast_Num";
            this.coldsStrandInfoL3DataTableCast_Num.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableCast_Num.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableWaterGap_Center
            // 
            this.coldsStrandInfoL3DataTableWaterGap_Center.Caption = "WaterGap_Center";
            this.coldsStrandInfoL3DataTableWaterGap_Center.ColumnName = "WaterGap_Center";
            this.coldsStrandInfoL3DataTableWaterGap_Center.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableWaterGap_Center.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableWaterGap_Deepness
            // 
            this.coldsStrandInfoL3DataTableWaterGap_Deepness.Caption = "WaterGap_Deepness";
            this.coldsStrandInfoL3DataTableWaterGap_Deepness.ColumnName = "WaterGap_Deepness";
            this.coldsStrandInfoL3DataTableWaterGap_Deepness.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableWaterGap_Deepness.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableCastingStatus
            // 
            this.coldsStrandInfoL3DataTableCastingStatus.Caption = "CastingStatus";
            this.coldsStrandInfoL3DataTableCastingStatus.ColumnName = "CastingStatus";
            this.coldsStrandInfoL3DataTableCastingStatus.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableCastingStatus.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableCode
            // 
            this.coldsStrandInfoL3DataTableCode.Caption = "Code";
            this.coldsStrandInfoL3DataTableCode.ColumnName = "Code";
            this.coldsStrandInfoL3DataTableCode.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableliquid_level
            // 
            this.coldsStrandInfoL3DataTableliquid_level.Caption = "liquid_level";
            this.coldsStrandInfoL3DataTableliquid_level.ColumnName = "liquid_level";
            this.coldsStrandInfoL3DataTableliquid_level.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableBlock_Up
            // 
            this.coldsStrandInfoL3DataTableBlock_Up.Caption = "Block_Up";
            this.coldsStrandInfoL3DataTableBlock_Up.ColumnName = "Block_Up";
            this.coldsStrandInfoL3DataTableBlock_Up.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableBlock_Up.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableBlock_Up_Reason
            // 
            this.coldsStrandInfoL3DataTableBlock_Up_Reason.Caption = "Block_Up_Reason";
            this.coldsStrandInfoL3DataTableBlock_Up_Reason.ColumnName = "Block_Up_Reason";
            this.coldsStrandInfoL3DataTableBlock_Up_Reason.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableBreakOut_Num
            // 
            this.coldsStrandInfoL3DataTableBreakOut_Num.Caption = "BreakOut_Num";
            this.coldsStrandInfoL3DataTableBreakOut_Num.ColumnName = "BreakOut_Num";
            this.coldsStrandInfoL3DataTableBreakOut_Num.DataType = typeof(int);
            this.coldsStrandInfoL3DataTableBreakOut_Num.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableMoldID
            // 
            this.coldsStrandInfoL3DataTableMoldID.Caption = "MoldID";
            this.coldsStrandInfoL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsStrandInfoL3DataTableMoldID.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableCopper_Fac
            // 
            this.coldsStrandInfoL3DataTableCopper_Fac.Caption = "Copper_Fac";
            this.coldsStrandInfoL3DataTableCopper_Fac.ColumnName = "Copper_Fac";
            this.coldsStrandInfoL3DataTableCopper_Fac.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableCopper_ID
            // 
            this.coldsStrandInfoL3DataTableCopper_ID.Caption = "Copper_ID";
            this.coldsStrandInfoL3DataTableCopper_ID.ColumnName = "Copper_ID";
            this.coldsStrandInfoL3DataTableCopper_ID.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableHeat_Weight
            // 
            this.coldsStrandInfoL3DataTableHeat_Weight.Caption = "Heat_Weight";
            this.coldsStrandInfoL3DataTableHeat_Weight.ColumnName = "Heat_Weight";
            this.coldsStrandInfoL3DataTableHeat_Weight.DataType = typeof(double);
            this.coldsStrandInfoL3DataTableHeat_Weight.Namespace = "";
            // 
            // coldsStrandInfoL3DataTableTotal_Weight
            // 
            this.coldsStrandInfoL3DataTableTotal_Weight.Caption = "Total_Weight";
            this.coldsStrandInfoL3DataTableTotal_Weight.ColumnName = "Total_Weight";
            this.coldsStrandInfoL3DataTableTotal_Weight.DataType = typeof(double);
            this.coldsStrandInfoL3DataTableTotal_Weight.Namespace = "";
            // 
            // pnlStrandInfo
            // 
            this.pnlStrandInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStrandInfo.Controls.Add(this.btnStrandInfoCancel);
            this.pnlStrandInfo.Controls.Add(this.btnStrandInfoOK);
            this.pnlStrandInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStrandInfo.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlStrandInfo.Location = new System.Drawing.Point(3, 395);
            this.pnlStrandInfo.Name = "pnlStrandInfo";
            this.pnlStrandInfo.Size = new System.Drawing.Size(965, 32);
            this.pnlStrandInfo.TabIndex = 99;
            // 
            // btnStrandInfoCancel
            // 
            this.btnStrandInfoCancel.Location = new System.Drawing.Point(883, 3);
            this.btnStrandInfoCancel.Name = "btnStrandInfoCancel";
            this.btnStrandInfoCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStrandInfoCancel.TabIndex = 87;
            this.btnStrandInfoCancel.Text = "取消";
            this.btnStrandInfoCancel.UseVisualStyleBackColor = true;
            this.btnStrandInfoCancel.Click += new System.EventHandler(this.btnStrandInfoCancel_Click);
            // 
            // bnStrandInfo
            // 
            this.bnStrandInfo.AddNewItem = null;
            this.bnStrandInfo.BindingSource = this.bsStrandInfo;
            this.bnStrandInfo.CountItem = this.toolStripLabel7;
            this.bnStrandInfo.DeleteItem = null;
            this.bnStrandInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton31,
            this.toolStripButton32,
            this.toolStripSeparator19,
            this.toolStripTextBox7,
            this.toolStripLabel7,
            this.toolStripSeparator20,
            this.toolStripButton33,
            this.toolStripButton34,
            this.toolStripSeparator21,
            this.btnAddStrandInfo,
            this.btnDelStrandInfo});
            this.bnStrandInfo.Location = new System.Drawing.Point(3, 3);
            this.bnStrandInfo.MoveFirstItem = this.toolStripButton31;
            this.bnStrandInfo.MoveLastItem = this.toolStripButton34;
            this.bnStrandInfo.MoveNextItem = this.toolStripButton33;
            this.bnStrandInfo.MovePreviousItem = this.toolStripButton32;
            this.bnStrandInfo.Name = "bnStrandInfo";
            this.bnStrandInfo.PositionItem = this.toolStripTextBox7;
            this.bnStrandInfo.Size = new System.Drawing.Size(965, 25);
            this.bnStrandInfo.TabIndex = 98;
            this.bnStrandInfo.Text = "bindingNavigator7";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel7.Text = "/ {0}";
            this.toolStripLabel7.ToolTipText = "总项数";
            // 
            // toolStripButton31
            // 
            this.toolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton31.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton31.Image")));
            this.toolStripButton31.Name = "toolStripButton31";
            this.toolStripButton31.RightToLeftAutoMirrorImage = true;
            this.toolStripButton31.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton31.Text = "移到第一条记录";
            // 
            // toolStripButton32
            // 
            this.toolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton32.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton32.Image")));
            this.toolStripButton32.Name = "toolStripButton32";
            this.toolStripButton32.RightToLeftAutoMirrorImage = true;
            this.toolStripButton32.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton32.Text = "移到上一条记录";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.AccessibleName = "位置";
            this.toolStripTextBox7.AutoSize = false;
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox7.Text = "0";
            this.toolStripTextBox7.ToolTipText = "当前位置";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton33
            // 
            this.toolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton33.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton33.Image")));
            this.toolStripButton33.Name = "toolStripButton33";
            this.toolStripButton33.RightToLeftAutoMirrorImage = true;
            this.toolStripButton33.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton33.Text = "移到下一条记录";
            // 
            // toolStripButton34
            // 
            this.toolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton34.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton34.Image")));
            this.toolStripButton34.Name = "toolStripButton34";
            this.toolStripButton34.RightToLeftAutoMirrorImage = true;
            this.toolStripButton34.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton34.Text = "移到最后一条记录";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelStrandInfo
            // 
            this.btnDelStrandInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelStrandInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnDelStrandInfo.Image")));
            this.btnDelStrandInfo.Name = "btnDelStrandInfo";
            this.btnDelStrandInfo.RightToLeftAutoMirrorImage = true;
            this.btnDelStrandInfo.Size = new System.Drawing.Size(23, 22);
            this.btnDelStrandInfo.Text = "删除";
            this.btnDelStrandInfo.Click += new System.EventHandler(this.btnDelStrandInfo_Click);
            // 
            // tabRemark
            // 
            this.tabRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRemark.Controls.Add(this.hmiRootPanel5);
            this.tabRemark.Controls.Add(this.pnlRemark);
            this.tabRemark.Controls.Add(this.bnRemark);
            this.tabRemark.Location = new System.Drawing.Point(4, 22);
            this.tabRemark.Name = "tabRemark";
            this.tabRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemark.Size = new System.Drawing.Size(973, 432);
            this.tabRemark.TabIndex = 18;
            this.tabRemark.Text = "记事数据";
            this.tabRemark.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel5
            // 
            this.hmiRootPanel5.Controls.Add(this.dvRemark);
            this.hmiRootPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel5.Location = new System.Drawing.Point(3, 28);
            this.hmiRootPanel5.Name = "hmiRootPanel5";
            this.hmiRootPanel5.Size = new System.Drawing.Size(965, 367);
            this.hmiRootPanel5.TabIndex = 101;
            // 
            // dvRemark
            // 
            this.dvRemark.AllowUserToAddRows = false;
            this.dvRemark.AllowUserToDeleteRows = false;
            this.dvRemark.AutoGenerateColumns = false;
            this.dvRemark.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvRemark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn7,
            this.treatNoDataGridViewTextBoxColumn1,
            this.logTimeDataGridViewTextBoxColumn1,
            this.typeIDDataGridViewCheckBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dvRemark.DataSource = this.bsRemark;
            this.dvRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRemark.Location = new System.Drawing.Point(0, 0);
            this.dvRemark.Name = "dvRemark";
            this.dvRemark.RowHeadersVisible = false;
            this.dvRemark.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvRemark.RowTemplate.Height = 23;
            this.dvRemark.Size = new System.Drawing.Size(965, 367);
            this.dvRemark.TabIndex = 0;
            this.dvRemark.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn7
            // 
            this.heatIDDataGridViewTextBoxColumn7.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn7.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn7.Name = "heatIDDataGridViewTextBoxColumn7";
            // 
            // treatNoDataGridViewTextBoxColumn1
            // 
            this.treatNoDataGridViewTextBoxColumn1.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn1.HeaderText = "连铸处理号";
            this.treatNoDataGridViewTextBoxColumn1.Name = "treatNoDataGridViewTextBoxColumn1";
            // 
            // logTimeDataGridViewTextBoxColumn1
            // 
            this.logTimeDataGridViewTextBoxColumn1.DataPropertyName = "Log_Time";
            this.logTimeDataGridViewTextBoxColumn1.HeaderText = "记录时刻";
            this.logTimeDataGridViewTextBoxColumn1.Name = "logTimeDataGridViewTextBoxColumn1";
            this.logTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.logTimeDataGridViewTextBoxColumn1.Width = 130;
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
            this.dsRemark.SourceCondition = null;
            this.dsRemark.SourceMethod = "";
            this.dsRemark.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRemark.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_Remark";
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
            this.coldsRemarkL3DataTableTreatNo,
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
            // coldsRemarkL3DataTableTreatNo
            // 
            this.coldsRemarkL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsRemarkL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsRemarkL3DataTableTreatNo.Namespace = "";
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
            // pnlRemark
            // 
            this.pnlRemark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRemark.Controls.Add(this.btnRemarkCancel);
            this.pnlRemark.Controls.Add(this.btnRemarkOK);
            this.pnlRemark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRemark.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlRemark.Location = new System.Drawing.Point(3, 395);
            this.pnlRemark.Name = "pnlRemark";
            this.pnlRemark.Size = new System.Drawing.Size(965, 32);
            this.pnlRemark.TabIndex = 100;
            // 
            // btnRemarkCancel
            // 
            this.btnRemarkCancel.Location = new System.Drawing.Point(883, 3);
            this.btnRemarkCancel.Name = "btnRemarkCancel";
            this.btnRemarkCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRemarkCancel.TabIndex = 87;
            this.btnRemarkCancel.Text = "取消";
            this.btnRemarkCancel.UseVisualStyleBackColor = true;
            this.btnRemarkCancel.Click += new System.EventHandler(this.btnRemarkCancel_Click);
            // 
            // bnRemark
            // 
            this.bnRemark.AddNewItem = null;
            this.bnRemark.BindingSource = this.bsRemark;
            this.bnRemark.CountItem = this.toolStripLabel8;
            this.bnRemark.DeleteItem = null;
            this.bnRemark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton36,
            this.toolStripButton37,
            this.toolStripSeparator22,
            this.toolStripTextBox8,
            this.toolStripLabel8,
            this.toolStripSeparator23,
            this.toolStripButton38,
            this.toolStripButton39,
            this.toolStripSeparator24,
            this.btnAddRemark});
            this.bnRemark.Location = new System.Drawing.Point(3, 3);
            this.bnRemark.MoveFirstItem = this.toolStripButton36;
            this.bnRemark.MoveLastItem = this.toolStripButton39;
            this.bnRemark.MoveNextItem = this.toolStripButton38;
            this.bnRemark.MovePreviousItem = this.toolStripButton37;
            this.bnRemark.Name = "bnRemark";
            this.bnRemark.PositionItem = this.toolStripTextBox8;
            this.bnRemark.Size = new System.Drawing.Size(965, 25);
            this.bnRemark.TabIndex = 99;
            this.bnRemark.Text = "bindingNavigator8";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel8.Text = "/ {0}";
            this.toolStripLabel8.ToolTipText = "总项数";
            // 
            // toolStripButton36
            // 
            this.toolStripButton36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton36.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton36.Image")));
            this.toolStripButton36.Name = "toolStripButton36";
            this.toolStripButton36.RightToLeftAutoMirrorImage = true;
            this.toolStripButton36.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton36.Text = "移到第一条记录";
            // 
            // toolStripButton37
            // 
            this.toolStripButton37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton37.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton37.Image")));
            this.toolStripButton37.Name = "toolStripButton37";
            this.toolStripButton37.RightToLeftAutoMirrorImage = true;
            this.toolStripButton37.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton37.Text = "移到上一条记录";
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox8
            // 
            this.toolStripTextBox8.AccessibleName = "位置";
            this.toolStripTextBox8.AutoSize = false;
            this.toolStripTextBox8.Name = "toolStripTextBox8";
            this.toolStripTextBox8.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox8.Text = "0";
            this.toolStripTextBox8.ToolTipText = "当前位置";
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton38
            // 
            this.toolStripButton38.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton38.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton38.Image")));
            this.toolStripButton38.Name = "toolStripButton38";
            this.toolStripButton38.RightToLeftAutoMirrorImage = true;
            this.toolStripButton38.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton38.Text = "移到下一条记录";
            // 
            // toolStripButton39
            // 
            this.toolStripButton39.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton39.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton39.Image")));
            this.toolStripButton39.Name = "toolStripButton39";
            this.toolStripButton39.RightToLeftAutoMirrorImage = true;
            this.toolStripButton39.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton39.Text = "移到最后一条记录";
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(6, 25);
            // 
            // tabRef
            // 
            this.tabRef.Controls.Add(this.tabControl1);
            this.tabRef.Location = new System.Drawing.Point(4, 22);
            this.tabRef.Name = "tabRef";
            this.tabRef.Padding = new System.Windows.Forms.Padding(3);
            this.tabRef.Size = new System.Drawing.Size(973, 432);
            this.tabRef.TabIndex = 24;
            this.tabRef.Text = "耐材";
            this.tabRef.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSmoothBlock);
            this.tabControl1.Controls.Add(this.tabHurryGap);
            this.tabControl1.Controls.Add(this.tabBigGap);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlMain_Selected);
            // 
            // tabSmoothBlock
            // 
            this.tabSmoothBlock.Controls.Add(this.hmiRootPanel10);
            this.tabSmoothBlock.Location = new System.Drawing.Point(4, 22);
            this.tabSmoothBlock.Name = "tabSmoothBlock";
            this.tabSmoothBlock.Padding = new System.Windows.Forms.Padding(3);
            this.tabSmoothBlock.Size = new System.Drawing.Size(959, 400);
            this.tabSmoothBlock.TabIndex = 22;
            this.tabSmoothBlock.Text = "滑块";
            this.tabSmoothBlock.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel10
            // 
            this.hmiRootPanel10.Controls.Add(this.dvHurryS);
            this.hmiRootPanel10.Controls.Add(this.fLPSmoothBlock);
            this.hmiRootPanel10.Controls.Add(this.bindingNavigator1);
            this.hmiRootPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel10.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel10.Name = "hmiRootPanel10";
            this.hmiRootPanel10.Size = new System.Drawing.Size(953, 394);
            this.hmiRootPanel10.TabIndex = 0;
            // 
            // dvHurryS
            // 
            this.dvHurryS.AllowUserToAddRows = false;
            this.dvHurryS.AllowUserToDeleteRows = false;
            this.dvHurryS.AutoGenerateColumns = false;
            this.dvHurryS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHurryS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewComboBoxColumn3,
            this.calendarColumn1,
            this.calendarColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewComboBoxColumn4});
            this.dvHurryS.DataSource = this.bsSmoothBlock;
            this.dvHurryS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHurryS.Location = new System.Drawing.Point(0, 25);
            this.dvHurryS.Name = "dvHurryS";
            this.dvHurryS.RowHeadersVisible = false;
            this.dvHurryS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvHurryS.RowTemplate.Height = 23;
            this.dvHurryS.Size = new System.Drawing.Size(953, 337);
            this.dvHurryS.TabIndex = 103;
            this.dvHurryS.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CCMID";
            this.dataGridViewTextBoxColumn1.HeaderText = "铸机号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "StrandNo";
            this.dataGridViewComboBoxColumn2.HeaderText = "流号";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BlockID";
            this.dataGridViewTextBoxColumn3.HeaderText = "滑块";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Block_Life";
            this.dataGridViewTextBoxColumn4.HeaderText = "滑块寿命[min]";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.DataPropertyName = "Factory";
            this.dataGridViewComboBoxColumn3.DataSource = this.dsSmoothBlockFactory;
            this.dataGridViewComboBoxColumn3.DisplayMember = "L3DataTable.MatFactory";
            this.dataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn3.HeaderText = "滑块厂家";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn3.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsSmoothBlockFactory
            // 
            this.dsSmoothBlockFactory.AutoLoad = true;
            this.dsSmoothBlockFactory.AutoSubscribe = false;
            this.dsSmoothBlockFactory.DataSetName = "L3DataSet";
            this.dsSmoothBlockFactory.DeleteMethod = null;
            this.dsSmoothBlockFactory.InsertMethod = null;
            this.dsSmoothBlockFactory.L3DataAdapter = this.Adapter;
            this.dsSmoothBlockFactory.LoadEvent = "Click";
            this.dsSmoothBlockFactory.LoadTrigger = null;
            this.dsSmoothBlockFactory.RefreshValve = 1000;
            this.dsSmoothBlockFactory.SourceCommand = null;
            this.dsSmoothBlockFactory.SourceCondition = "MatName = \'滑块\' and MatGroup_Code = \'TundishFac\'";
            this.dsSmoothBlockFactory.SourceMethod = "";
            this.dsSmoothBlockFactory.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSmoothBlockFactory.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsSmoothBlockFactory.SubscribeTarget = null;
            this.dsSmoothBlockFactory.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSmoothBlockFactory});
            this.dsSmoothBlockFactory.UpdateEvent = "Click";
            this.dsSmoothBlockFactory.UpdateMethod = null;
            this.dsSmoothBlockFactory.UpdateTrigger = null;
            // 
            // schemadsSmoothBlockFactory
            // 
            this.schemadsSmoothBlockFactory.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSmoothBlockFactoryL3DataTableMatFactory});
            this.schemadsSmoothBlockFactory.TableName = "L3DataTable";
            // 
            // coldsSmoothBlockFactoryL3DataTableMatFactory
            // 
            this.coldsSmoothBlockFactoryL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsSmoothBlockFactoryL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsSmoothBlockFactoryL3DataTableMatFactory.Namespace = "";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "Start_Time";
            this.calendarColumn1.HeaderText = "更换时刻";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.calendarColumn1.Width = 130;
            // 
            // calendarColumn2
            // 
            this.calendarColumn2.DataPropertyName = "End_Time";
            this.calendarColumn2.HeaderText = "滑块更换结束时刻";
            this.calendarColumn2.Name = "calendarColumn2";
            this.calendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.calendarColumn2.Visible = false;
            this.calendarColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Block_Size";
            this.dataGridViewTextBoxColumn5.HeaderText = "规格";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn4.DataPropertyName = "Reason";
            this.dataGridViewComboBoxColumn4.DataSource = this.dsSmoothBlockOFFReason;
            this.dataGridViewComboBoxColumn4.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn4.HeaderText = "更换原因";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.ValueMember = "L3DataTable.Code";
            // 
            // dsSmoothBlockOFFReason
            // 
            this.dsSmoothBlockOFFReason.AutoLoad = true;
            this.dsSmoothBlockOFFReason.AutoSubscribe = false;
            this.dsSmoothBlockOFFReason.DataSetName = "L3DataSet";
            this.dsSmoothBlockOFFReason.DeleteMethod = null;
            this.dsSmoothBlockOFFReason.InsertMethod = null;
            this.dsSmoothBlockOFFReason.L3DataAdapter = this.Adapter;
            this.dsSmoothBlockOFFReason.LoadEvent = "Click";
            this.dsSmoothBlockOFFReason.LoadTrigger = null;
            this.dsSmoothBlockOFFReason.RefreshValve = 1000;
            this.dsSmoothBlockOFFReason.SourceCommand = null;
            this.dsSmoothBlockOFFReason.SourceCondition = "Code_Group = \'SMOOTH_BLOCK_OFF_REASON\' order by Code";
            this.dsSmoothBlockOFFReason.SourceMethod = "";
            this.dsSmoothBlockOFFReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSmoothBlockOFFReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSmoothBlockOFFReason.SubscribeTarget = null;
            this.dsSmoothBlockOFFReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSmoothBlockOFFReason});
            this.dsSmoothBlockOFFReason.UpdateEvent = "Click";
            this.dsSmoothBlockOFFReason.UpdateMethod = null;
            this.dsSmoothBlockOFFReason.UpdateTrigger = null;
            // 
            // schemadsSmoothBlockOFFReason
            // 
            this.schemadsSmoothBlockOFFReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSmoothBlockOFFReasonL3DataTableCode,
            this.coldsSmoothBlockOFFReasonL3DataTableCode_Des});
            this.schemadsSmoothBlockOFFReason.TableName = "L3DataTable";
            // 
            // coldsSmoothBlockOFFReasonL3DataTableCode
            // 
            this.coldsSmoothBlockOFFReasonL3DataTableCode.Caption = "Code";
            this.coldsSmoothBlockOFFReasonL3DataTableCode.ColumnName = "Code";
            this.coldsSmoothBlockOFFReasonL3DataTableCode.Namespace = "";
            // 
            // coldsSmoothBlockOFFReasonL3DataTableCode_Des
            // 
            this.coldsSmoothBlockOFFReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSmoothBlockOFFReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSmoothBlockOFFReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsSmoothBlock
            // 
            this.bsSmoothBlock.DataMember = "L3DataTable";
            this.bsSmoothBlock.DataSource = this.dsSmoothBlock;
            // 
            // dsSmoothBlock
            // 
            this.dsSmoothBlock.AutoLoad = true;
            this.dsSmoothBlock.AutoSubscribe = false;
            this.dsSmoothBlock.DataSetName = "L3DataSet";
            this.dsSmoothBlock.DeleteMethod = null;
            this.dsSmoothBlock.InsertMethod = null;
            this.dsSmoothBlock.L3DataAdapter = null;
            this.dsSmoothBlock.LoadEvent = "Click";
            this.dsSmoothBlock.LoadTrigger = null;
            this.dsSmoothBlock.RefreshValve = 1000;
            this.dsSmoothBlock.SourceCommand = null;
            this.dsSmoothBlock.SourceCondition = null;
            this.dsSmoothBlock.SourceMethod = "";
            this.dsSmoothBlock.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSmoothBlock.SourceURI = "XGMESLogic\\CCMMag\\CCCM_SmoothBlock";
            this.dsSmoothBlock.SubscribeTarget = null;
            this.dsSmoothBlock.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSmoothBlock});
            this.dsSmoothBlock.UpdateEvent = "Click";
            this.dsSmoothBlock.UpdateMethod = null;
            this.dsSmoothBlock.UpdateTrigger = null;
            // 
            // schemadsSmoothBlock
            // 
            this.schemadsSmoothBlock.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSmoothBlockL3DataTableGUID,
            this.coldsSmoothBlockL3DataTableName,
            this.coldsSmoothBlockL3DataTableCCMID,
            this.coldsSmoothBlockL3DataTableStrandNo,
            this.coldsSmoothBlockL3DataTableBlockID,
            this.coldsSmoothBlockL3DataTableBlock_Life,
            this.coldsSmoothBlockL3DataTableFactory,
            this.coldsSmoothBlockL3DataTableStart_Time,
            this.coldsSmoothBlockL3DataTableEnd_Time,
            this.coldsSmoothBlockL3DataTableBlock_Size,
            this.coldsSmoothBlockL3DataTableReason,
            this.coldsSmoothBlockL3DataTableHeatID});
            this.schemadsSmoothBlock.TableName = "L3DataTable";
            // 
            // coldsSmoothBlockL3DataTableGUID
            // 
            this.coldsSmoothBlockL3DataTableGUID.Caption = "GUID";
            this.coldsSmoothBlockL3DataTableGUID.ColumnName = "GUID";
            this.coldsSmoothBlockL3DataTableGUID.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableName
            // 
            this.coldsSmoothBlockL3DataTableName.Caption = "Name";
            this.coldsSmoothBlockL3DataTableName.ColumnName = "Name";
            this.coldsSmoothBlockL3DataTableName.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableCCMID
            // 
            this.coldsSmoothBlockL3DataTableCCMID.Caption = "CCMID";
            this.coldsSmoothBlockL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsSmoothBlockL3DataTableCCMID.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableStrandNo
            // 
            this.coldsSmoothBlockL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsSmoothBlockL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsSmoothBlockL3DataTableStrandNo.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableBlockID
            // 
            this.coldsSmoothBlockL3DataTableBlockID.Caption = "BlockID";
            this.coldsSmoothBlockL3DataTableBlockID.ColumnName = "BlockID";
            this.coldsSmoothBlockL3DataTableBlockID.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableBlock_Life
            // 
            this.coldsSmoothBlockL3DataTableBlock_Life.Caption = "Block_Life";
            this.coldsSmoothBlockL3DataTableBlock_Life.ColumnName = "Block_Life";
            this.coldsSmoothBlockL3DataTableBlock_Life.DataType = typeof(int);
            this.coldsSmoothBlockL3DataTableBlock_Life.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableFactory
            // 
            this.coldsSmoothBlockL3DataTableFactory.Caption = "Factory";
            this.coldsSmoothBlockL3DataTableFactory.ColumnName = "Factory";
            this.coldsSmoothBlockL3DataTableFactory.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableStart_Time
            // 
            this.coldsSmoothBlockL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsSmoothBlockL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsSmoothBlockL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsSmoothBlockL3DataTableStart_Time.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableEnd_Time
            // 
            this.coldsSmoothBlockL3DataTableEnd_Time.Caption = "End_Time";
            this.coldsSmoothBlockL3DataTableEnd_Time.ColumnName = "End_Time";
            this.coldsSmoothBlockL3DataTableEnd_Time.DataType = typeof(System.DateTime);
            this.coldsSmoothBlockL3DataTableEnd_Time.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableBlock_Size
            // 
            this.coldsSmoothBlockL3DataTableBlock_Size.Caption = "Block_Size";
            this.coldsSmoothBlockL3DataTableBlock_Size.ColumnName = "Block_Size";
            this.coldsSmoothBlockL3DataTableBlock_Size.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableReason
            // 
            this.coldsSmoothBlockL3DataTableReason.Caption = "Reason";
            this.coldsSmoothBlockL3DataTableReason.ColumnName = "Reason";
            this.coldsSmoothBlockL3DataTableReason.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableHeatID
            // 
            this.coldsSmoothBlockL3DataTableHeatID.Caption = "HeatID";
            this.coldsSmoothBlockL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSmoothBlockL3DataTableHeatID.Namespace = "";
            // 
            // fLPSmoothBlock
            // 
            this.fLPSmoothBlock.AccessibleName = "`";
            this.fLPSmoothBlock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fLPSmoothBlock.Controls.Add(this.button1);
            this.fLPSmoothBlock.Controls.Add(this.button2);
            this.fLPSmoothBlock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fLPSmoothBlock.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fLPSmoothBlock.Location = new System.Drawing.Point(0, 362);
            this.fLPSmoothBlock.Name = "fLPSmoothBlock";
            this.fLPSmoothBlock.Size = new System.Drawing.Size(953, 32);
            this.fLPSmoothBlock.TabIndex = 102;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsSmoothBlock;
            this.bindingNavigator1.CountItem = this.toolStripLabel10;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton26,
            this.toolStripButton35,
            this.toolStripSeparator28,
            this.toolStripTextBox10,
            this.toolStripLabel10,
            this.toolStripSeparator29,
            this.toolStripButton40,
            this.toolStripButton41,
            this.toolStripSeparator30,
            this.btnSmoothBlockAdd,
            this.btnSmoothBlockDel});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton26;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton41;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton40;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton35;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox10;
            this.bindingNavigator1.Size = new System.Drawing.Size(953, 25);
            this.bindingNavigator1.TabIndex = 100;
            this.bindingNavigator1.Text = "bindingNavigator7";
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel10.Text = "/ {0}";
            this.toolStripLabel10.ToolTipText = "总项数";
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton26.Image")));
            this.toolStripButton26.Name = "toolStripButton26";
            this.toolStripButton26.RightToLeftAutoMirrorImage = true;
            this.toolStripButton26.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton26.Text = "移到第一条记录";
            // 
            // toolStripButton35
            // 
            this.toolStripButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton35.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton35.Image")));
            this.toolStripButton35.Name = "toolStripButton35";
            this.toolStripButton35.RightToLeftAutoMirrorImage = true;
            this.toolStripButton35.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton35.Text = "移到上一条记录";
            // 
            // toolStripSeparator28
            // 
            this.toolStripSeparator28.Name = "toolStripSeparator28";
            this.toolStripSeparator28.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox10
            // 
            this.toolStripTextBox10.AccessibleName = "位置";
            this.toolStripTextBox10.AutoSize = false;
            this.toolStripTextBox10.Name = "toolStripTextBox10";
            this.toolStripTextBox10.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox10.Text = "0";
            this.toolStripTextBox10.ToolTipText = "当前位置";
            // 
            // toolStripSeparator29
            // 
            this.toolStripSeparator29.Name = "toolStripSeparator29";
            this.toolStripSeparator29.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton40
            // 
            this.toolStripButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton40.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton40.Image")));
            this.toolStripButton40.Name = "toolStripButton40";
            this.toolStripButton40.RightToLeftAutoMirrorImage = true;
            this.toolStripButton40.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton40.Text = "移到下一条记录";
            // 
            // toolStripButton41
            // 
            this.toolStripButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton41.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton41.Image")));
            this.toolStripButton41.Name = "toolStripButton41";
            this.toolStripButton41.RightToLeftAutoMirrorImage = true;
            this.toolStripButton41.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton41.Text = "移到最后一条记录";
            // 
            // toolStripSeparator30
            // 
            this.toolStripSeparator30.Name = "toolStripSeparator30";
            this.toolStripSeparator30.Size = new System.Drawing.Size(6, 25);
            // 
            // tabHurryGap
            // 
            this.tabHurryGap.Controls.Add(this.hmiRootPanel8);
            this.tabHurryGap.Location = new System.Drawing.Point(4, 22);
            this.tabHurryGap.Name = "tabHurryGap";
            this.tabHurryGap.Padding = new System.Windows.Forms.Padding(3);
            this.tabHurryGap.Size = new System.Drawing.Size(959, 400);
            this.tabHurryGap.TabIndex = 23;
            this.tabHurryGap.Text = "中包水口";
            this.tabHurryGap.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel8
            // 
            this.hmiRootPanel8.Controls.Add(this.dvHurryGap);
            this.hmiRootPanel8.Controls.Add(this.pnlHurryGap);
            this.hmiRootPanel8.Controls.Add(this.bindingNavigator4);
            this.hmiRootPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel8.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel8.Name = "hmiRootPanel8";
            this.hmiRootPanel8.Size = new System.Drawing.Size(953, 394);
            this.hmiRootPanel8.TabIndex = 0;
            // 
            // dvHurryGap
            // 
            this.dvHurryGap.AllowUserToAddRows = false;
            this.dvHurryGap.AllowUserToDeleteRows = false;
            this.dvHurryGap.AutoGenerateColumns = false;
            this.dvHurryGap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvHurryGap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCMIDDataGridViewTextBoxColumn6,
            this.MatType,
            this.heatIDDataGridViewTextBoxColumn13,
            this.strandNoDataGridViewTextBoxColumn2,
            this.gapIDDataGridViewTextBoxColumn,
            this.gapLifeDataGridViewTextBoxColumn,
            this.factoryDataGridViewTextBoxColumn3,
            this.startTimeDataGridViewTextBoxColumn4,
            this.endTimeDataGridViewTextBoxColumn1,
            this.reasonDataGridViewTextBoxColumn1});
            this.dvHurryGap.DataSource = this.bsHurryGap;
            this.dvHurryGap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvHurryGap.Location = new System.Drawing.Point(0, 25);
            this.dvHurryGap.Name = "dvHurryGap";
            this.dvHurryGap.RowHeadersVisible = false;
            this.dvHurryGap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvHurryGap.RowTemplate.Height = 23;
            this.dvHurryGap.Size = new System.Drawing.Size(953, 337);
            this.dvHurryGap.TabIndex = 103;
            this.dvHurryGap.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // cCMIDDataGridViewTextBoxColumn6
            // 
            this.cCMIDDataGridViewTextBoxColumn6.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn6.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn6.Name = "cCMIDDataGridViewTextBoxColumn6";
            // 
            // MatType
            // 
            this.MatType.DataPropertyName = "MatType";
            this.MatType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MatType.HeaderText = "材质";
            this.MatType.Items.AddRange(new object[] {
            "石英水口",
            "铝碳水口"});
            this.MatType.Name = "MatType";
            this.MatType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MatType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // heatIDDataGridViewTextBoxColumn13
            // 
            this.heatIDDataGridViewTextBoxColumn13.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn13.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn13.Name = "heatIDDataGridViewTextBoxColumn13";
            // 
            // strandNoDataGridViewTextBoxColumn2
            // 
            this.strandNoDataGridViewTextBoxColumn2.DataPropertyName = "StrandNo";
            this.strandNoDataGridViewTextBoxColumn2.HeaderText = "流号";
            this.strandNoDataGridViewTextBoxColumn2.Name = "strandNoDataGridViewTextBoxColumn2";
            this.strandNoDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gapIDDataGridViewTextBoxColumn
            // 
            this.gapIDDataGridViewTextBoxColumn.DataPropertyName = "GapID";
            this.gapIDDataGridViewTextBoxColumn.HeaderText = "水口";
            this.gapIDDataGridViewTextBoxColumn.Name = "gapIDDataGridViewTextBoxColumn";
            this.gapIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // gapLifeDataGridViewTextBoxColumn
            // 
            this.gapLifeDataGridViewTextBoxColumn.DataPropertyName = "GapLife";
            this.gapLifeDataGridViewTextBoxColumn.HeaderText = "水口寿命";
            this.gapLifeDataGridViewTextBoxColumn.Name = "gapLifeDataGridViewTextBoxColumn";
            // 
            // factoryDataGridViewTextBoxColumn3
            // 
            this.factoryDataGridViewTextBoxColumn3.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn3.DataSource = this.dsHurryGapFactory;
            this.factoryDataGridViewTextBoxColumn3.DisplayMember = "L3DataTable.MatFactory";
            this.factoryDataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.factoryDataGridViewTextBoxColumn3.HeaderText = "水口厂家";
            this.factoryDataGridViewTextBoxColumn3.Name = "factoryDataGridViewTextBoxColumn3";
            this.factoryDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factoryDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.factoryDataGridViewTextBoxColumn3.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsHurryGapFactory
            // 
            this.dsHurryGapFactory.AutoLoad = true;
            this.dsHurryGapFactory.AutoSubscribe = false;
            this.dsHurryGapFactory.DataSetName = "L3DataSet";
            this.dsHurryGapFactory.DeleteMethod = null;
            this.dsHurryGapFactory.InsertMethod = null;
            this.dsHurryGapFactory.L3DataAdapter = this.Adapter;
            this.dsHurryGapFactory.LoadEvent = "Click";
            this.dsHurryGapFactory.LoadTrigger = null;
            this.dsHurryGapFactory.RefreshValve = 1000;
            this.dsHurryGapFactory.SourceCommand = null;
            this.dsHurryGapFactory.SourceCondition = "MatName = \'快换水口\' and MatGroup_Code = \'TundishFac\'";
            this.dsHurryGapFactory.SourceMethod = "";
            this.dsHurryGapFactory.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHurryGapFactory.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsHurryGapFactory.SubscribeTarget = null;
            this.dsHurryGapFactory.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHurryGapFactory});
            this.dsHurryGapFactory.UpdateEvent = "Click";
            this.dsHurryGapFactory.UpdateMethod = null;
            this.dsHurryGapFactory.UpdateTrigger = null;
            // 
            // schemadsHurryGapFactory
            // 
            this.schemadsHurryGapFactory.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHurryGapFactoryL3DataTableMatFactory});
            this.schemadsHurryGapFactory.TableName = "L3DataTable";
            // 
            // coldsHurryGapFactoryL3DataTableMatFactory
            // 
            this.coldsHurryGapFactoryL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsHurryGapFactoryL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsHurryGapFactoryL3DataTableMatFactory.Namespace = "";
            // 
            // startTimeDataGridViewTextBoxColumn4
            // 
            this.startTimeDataGridViewTextBoxColumn4.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn4.HeaderText = "更换时刻";
            this.startTimeDataGridViewTextBoxColumn4.Name = "startTimeDataGridViewTextBoxColumn4";
            this.startTimeDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startTimeDataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.startTimeDataGridViewTextBoxColumn4.Width = 130;
            // 
            // endTimeDataGridViewTextBoxColumn1
            // 
            this.endTimeDataGridViewTextBoxColumn1.DataPropertyName = "End_Time";
            this.endTimeDataGridViewTextBoxColumn1.HeaderText = "水口更换结束时刻";
            this.endTimeDataGridViewTextBoxColumn1.Name = "endTimeDataGridViewTextBoxColumn1";
            this.endTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.endTimeDataGridViewTextBoxColumn1.Visible = false;
            this.endTimeDataGridViewTextBoxColumn1.Width = 130;
            // 
            // reasonDataGridViewTextBoxColumn1
            // 
            this.reasonDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reasonDataGridViewTextBoxColumn1.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn1.DataSource = this.dsHurryGapOFFReason;
            this.reasonDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.reasonDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.reasonDataGridViewTextBoxColumn1.HeaderText = "更换原因";
            this.reasonDataGridViewTextBoxColumn1.Name = "reasonDataGridViewTextBoxColumn1";
            this.reasonDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reasonDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            // 
            // dsHurryGapOFFReason
            // 
            this.dsHurryGapOFFReason.AutoLoad = true;
            this.dsHurryGapOFFReason.AutoSubscribe = false;
            this.dsHurryGapOFFReason.DataSetName = "L3DataSet";
            this.dsHurryGapOFFReason.DeleteMethod = null;
            this.dsHurryGapOFFReason.InsertMethod = null;
            this.dsHurryGapOFFReason.L3DataAdapter = this.Adapter;
            this.dsHurryGapOFFReason.LoadEvent = "Click";
            this.dsHurryGapOFFReason.LoadTrigger = null;
            this.dsHurryGapOFFReason.RefreshValve = 1000;
            this.dsHurryGapOFFReason.SourceCommand = null;
            this.dsHurryGapOFFReason.SourceCondition = "Code_Group = \'HURRYGAP_OFF_REASON\' order by Code";
            this.dsHurryGapOFFReason.SourceMethod = "";
            this.dsHurryGapOFFReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHurryGapOFFReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsHurryGapOFFReason.SubscribeTarget = null;
            this.dsHurryGapOFFReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHurryGapOFFReason});
            this.dsHurryGapOFFReason.UpdateEvent = "Click";
            this.dsHurryGapOFFReason.UpdateMethod = null;
            this.dsHurryGapOFFReason.UpdateTrigger = null;
            // 
            // schemadsHurryGapOFFReason
            // 
            this.schemadsHurryGapOFFReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHurryGapOFFReasonL3DataTableCode,
            this.coldsHurryGapOFFReasonL3DataTableCode_Des});
            this.schemadsHurryGapOFFReason.TableName = "L3DataTable";
            // 
            // coldsHurryGapOFFReasonL3DataTableCode
            // 
            this.coldsHurryGapOFFReasonL3DataTableCode.Caption = "Code";
            this.coldsHurryGapOFFReasonL3DataTableCode.ColumnName = "Code";
            this.coldsHurryGapOFFReasonL3DataTableCode.Namespace = "";
            // 
            // coldsHurryGapOFFReasonL3DataTableCode_Des
            // 
            this.coldsHurryGapOFFReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsHurryGapOFFReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsHurryGapOFFReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsHurryGap
            // 
            this.bsHurryGap.DataMember = "L3DataTable";
            this.bsHurryGap.DataSource = this.dsHurryGrap;
            // 
            // dsHurryGrap
            // 
            this.dsHurryGrap.AutoLoad = true;
            this.dsHurryGrap.AutoSubscribe = false;
            this.dsHurryGrap.DataSetName = "L3DataSet";
            this.dsHurryGrap.DeleteMethod = null;
            this.dsHurryGrap.InsertMethod = null;
            this.dsHurryGrap.L3DataAdapter = null;
            this.dsHurryGrap.LoadEvent = "Click";
            this.dsHurryGrap.LoadTrigger = null;
            this.dsHurryGrap.RefreshValve = 1000;
            this.dsHurryGrap.SourceCommand = null;
            this.dsHurryGrap.SourceCondition = null;
            this.dsHurryGrap.SourceMethod = "";
            this.dsHurryGrap.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHurryGrap.SourceURI = "XGMESLogic\\CCMMag\\CCCM_WaterGap";
            this.dsHurryGrap.SubscribeTarget = null;
            this.dsHurryGrap.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHurryGrap});
            this.dsHurryGrap.UpdateEvent = "Click";
            this.dsHurryGrap.UpdateMethod = null;
            this.dsHurryGrap.UpdateTrigger = null;
            // 
            // schemadsHurryGrap
            // 
            this.schemadsHurryGrap.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHurryGrapL3DataTableGUID,
            this.coldsHurryGrapL3DataTableName,
            this.coldsHurryGrapL3DataTableCCMID,
            this.coldsHurryGrapL3DataTableStrandNo,
            this.coldsHurryGrapL3DataTableGapID,
            this.coldsHurryGrapL3DataTableGapLife,
            this.coldsHurryGrapL3DataTableFactory,
            this.coldsHurryGrapL3DataTableStart_Time,
            this.coldsHurryGrapL3DataTableEnd_Time,
            this.coldsHurryGrapL3DataTableReason,
            this.coldsHurryGrapL3DataTableHeatID,
            this.coldsHurryGrapL3DataTableMatType});
            this.schemadsHurryGrap.TableName = "L3DataTable";
            // 
            // coldsHurryGrapL3DataTableGUID
            // 
            this.coldsHurryGrapL3DataTableGUID.Caption = "GUID";
            this.coldsHurryGrapL3DataTableGUID.ColumnName = "GUID";
            this.coldsHurryGrapL3DataTableGUID.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableName
            // 
            this.coldsHurryGrapL3DataTableName.Caption = "Name";
            this.coldsHurryGrapL3DataTableName.ColumnName = "Name";
            this.coldsHurryGrapL3DataTableName.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableCCMID
            // 
            this.coldsHurryGrapL3DataTableCCMID.Caption = "CCMID";
            this.coldsHurryGrapL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsHurryGrapL3DataTableCCMID.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableStrandNo
            // 
            this.coldsHurryGrapL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsHurryGrapL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsHurryGrapL3DataTableStrandNo.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableGapID
            // 
            this.coldsHurryGrapL3DataTableGapID.Caption = "GapID";
            this.coldsHurryGrapL3DataTableGapID.ColumnName = "GapID";
            this.coldsHurryGrapL3DataTableGapID.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableGapLife
            // 
            this.coldsHurryGrapL3DataTableGapLife.Caption = "GapLife";
            this.coldsHurryGrapL3DataTableGapLife.ColumnName = "GapLife";
            this.coldsHurryGrapL3DataTableGapLife.DataType = typeof(int);
            this.coldsHurryGrapL3DataTableGapLife.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableFactory
            // 
            this.coldsHurryGrapL3DataTableFactory.Caption = "Factory";
            this.coldsHurryGrapL3DataTableFactory.ColumnName = "Factory";
            this.coldsHurryGrapL3DataTableFactory.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableStart_Time
            // 
            this.coldsHurryGrapL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsHurryGrapL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsHurryGrapL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsHurryGrapL3DataTableStart_Time.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableEnd_Time
            // 
            this.coldsHurryGrapL3DataTableEnd_Time.Caption = "End_Time";
            this.coldsHurryGrapL3DataTableEnd_Time.ColumnName = "End_Time";
            this.coldsHurryGrapL3DataTableEnd_Time.DataType = typeof(System.DateTime);
            this.coldsHurryGrapL3DataTableEnd_Time.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableReason
            // 
            this.coldsHurryGrapL3DataTableReason.Caption = "Reason";
            this.coldsHurryGrapL3DataTableReason.ColumnName = "Reason";
            this.coldsHurryGrapL3DataTableReason.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableHeatID
            // 
            this.coldsHurryGrapL3DataTableHeatID.Caption = "HeatID";
            this.coldsHurryGrapL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHurryGrapL3DataTableHeatID.Namespace = "";
            // 
            // coldsHurryGrapL3DataTableMatType
            // 
            this.coldsHurryGrapL3DataTableMatType.Caption = "MatType";
            this.coldsHurryGrapL3DataTableMatType.ColumnName = "MatType";
            this.coldsHurryGrapL3DataTableMatType.Namespace = "";
            // 
            // pnlHurryGap
            // 
            this.pnlHurryGap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHurryGap.Controls.Add(this.btnHurryGapCancel);
            this.pnlHurryGap.Controls.Add(this.btnHurryGapConfirm);
            this.pnlHurryGap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHurryGap.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlHurryGap.Location = new System.Drawing.Point(0, 362);
            this.pnlHurryGap.Name = "pnlHurryGap";
            this.pnlHurryGap.Size = new System.Drawing.Size(953, 32);
            this.pnlHurryGap.TabIndex = 102;
            // 
            // btnHurryGapCancel
            // 
            this.btnHurryGapCancel.Location = new System.Drawing.Point(871, 3);
            this.btnHurryGapCancel.Name = "btnHurryGapCancel";
            this.btnHurryGapCancel.Size = new System.Drawing.Size(75, 23);
            this.btnHurryGapCancel.TabIndex = 87;
            this.btnHurryGapCancel.Text = "取消";
            this.btnHurryGapCancel.UseVisualStyleBackColor = true;
            this.btnHurryGapCancel.Click += new System.EventHandler(this.btnHurryGapCancel_Click);
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = null;
            this.bindingNavigator4.BindingSource = this.bsHurryGap;
            this.bindingNavigator4.CountItem = this.toolStripLabel12;
            this.bindingNavigator4.DeleteItem = null;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton46,
            this.toolStripButton47,
            this.toolStripSeparator34,
            this.toolStripTextBox12,
            this.toolStripLabel12,
            this.toolStripSeparator35,
            this.toolStripButton48,
            this.toolStripButton49,
            this.toolStripSeparator36,
            this.btnHurryGapAdd,
            this.btnHurryGapDel});
            this.bindingNavigator4.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator4.MoveFirstItem = this.toolStripButton46;
            this.bindingNavigator4.MoveLastItem = this.toolStripButton49;
            this.bindingNavigator4.MoveNextItem = this.toolStripButton48;
            this.bindingNavigator4.MovePreviousItem = this.toolStripButton47;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.toolStripTextBox12;
            this.bindingNavigator4.Size = new System.Drawing.Size(953, 25);
            this.bindingNavigator4.TabIndex = 100;
            this.bindingNavigator4.Text = "bindingNavigator7";
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel12.Text = "/ {0}";
            this.toolStripLabel12.ToolTipText = "总项数";
            // 
            // toolStripButton46
            // 
            this.toolStripButton46.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton46.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton46.Image")));
            this.toolStripButton46.Name = "toolStripButton46";
            this.toolStripButton46.RightToLeftAutoMirrorImage = true;
            this.toolStripButton46.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton46.Text = "移到第一条记录";
            // 
            // toolStripButton47
            // 
            this.toolStripButton47.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton47.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton47.Image")));
            this.toolStripButton47.Name = "toolStripButton47";
            this.toolStripButton47.RightToLeftAutoMirrorImage = true;
            this.toolStripButton47.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton47.Text = "移到上一条记录";
            // 
            // toolStripSeparator34
            // 
            this.toolStripSeparator34.Name = "toolStripSeparator34";
            this.toolStripSeparator34.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox12
            // 
            this.toolStripTextBox12.AccessibleName = "位置";
            this.toolStripTextBox12.AutoSize = false;
            this.toolStripTextBox12.Name = "toolStripTextBox12";
            this.toolStripTextBox12.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox12.Text = "0";
            this.toolStripTextBox12.ToolTipText = "当前位置";
            // 
            // toolStripSeparator35
            // 
            this.toolStripSeparator35.Name = "toolStripSeparator35";
            this.toolStripSeparator35.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton48
            // 
            this.toolStripButton48.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton48.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton48.Image")));
            this.toolStripButton48.Name = "toolStripButton48";
            this.toolStripButton48.RightToLeftAutoMirrorImage = true;
            this.toolStripButton48.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton48.Text = "移到下一条记录";
            // 
            // toolStripButton49
            // 
            this.toolStripButton49.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton49.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton49.Image")));
            this.toolStripButton49.Name = "toolStripButton49";
            this.toolStripButton49.RightToLeftAutoMirrorImage = true;
            this.toolStripButton49.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton49.Text = "移到最后一条记录";
            // 
            // toolStripSeparator36
            // 
            this.toolStripSeparator36.Name = "toolStripSeparator36";
            this.toolStripSeparator36.Size = new System.Drawing.Size(6, 25);
            // 
            // tabBigGap
            // 
            this.tabBigGap.Controls.Add(this.hmiRootPanel9);
            this.tabBigGap.Location = new System.Drawing.Point(4, 22);
            this.tabBigGap.Name = "tabBigGap";
            this.tabBigGap.Padding = new System.Windows.Forms.Padding(3);
            this.tabBigGap.Size = new System.Drawing.Size(959, 400);
            this.tabBigGap.TabIndex = 24;
            this.tabBigGap.Text = "大包水口";
            this.tabBigGap.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel9
            // 
            this.hmiRootPanel9.Controls.Add(this.dvBigGap);
            this.hmiRootPanel9.Controls.Add(this.pnlBigGap);
            this.hmiRootPanel9.Controls.Add(this.bindingNavigator5);
            this.hmiRootPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel9.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel9.Name = "hmiRootPanel9";
            this.hmiRootPanel9.Size = new System.Drawing.Size(953, 394);
            this.hmiRootPanel9.TabIndex = 0;
            // 
            // dvBigGap
            // 
            this.dvBigGap.AllowUserToAddRows = false;
            this.dvBigGap.AllowUserToDeleteRows = false;
            this.dvBigGap.AutoGenerateColumns = false;
            this.dvBigGap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBigGap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCMIDDataGridViewTextBoxColumn7,
            this.heatIDDataGridViewTextBoxColumn14,
            this.strandNoDataGridViewTextBoxColumn3,
            this.gapIDDataGridViewTextBoxColumn1,
            this.factoryDataGridViewTextBoxColumn4,
            this.matTypeDataGridViewTextBoxColumn,
            this.gapLifeDataGridViewTextBoxColumn1,
            this.changeTimeDataGridViewTextBoxColumn2,
            this.reasonDataGridViewTextBoxColumn2});
            this.dvBigGap.DataSource = this.bsBigGap;
            this.dvBigGap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBigGap.Location = new System.Drawing.Point(0, 25);
            this.dvBigGap.Name = "dvBigGap";
            this.dvBigGap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBigGap.RowTemplate.Height = 23;
            this.dvBigGap.Size = new System.Drawing.Size(953, 337);
            this.dvBigGap.TabIndex = 103;
            this.dvBigGap.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvChemical_DataError);
            // 
            // cCMIDDataGridViewTextBoxColumn7
            // 
            this.cCMIDDataGridViewTextBoxColumn7.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn7.HeaderText = "铸机";
            this.cCMIDDataGridViewTextBoxColumn7.Name = "cCMIDDataGridViewTextBoxColumn7";
            // 
            // heatIDDataGridViewTextBoxColumn14
            // 
            this.heatIDDataGridViewTextBoxColumn14.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn14.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn14.Name = "heatIDDataGridViewTextBoxColumn14";
            // 
            // strandNoDataGridViewTextBoxColumn3
            // 
            this.strandNoDataGridViewTextBoxColumn3.DataPropertyName = "StrandNo";
            this.strandNoDataGridViewTextBoxColumn3.HeaderText = "流号";
            this.strandNoDataGridViewTextBoxColumn3.Name = "strandNoDataGridViewTextBoxColumn3";
            this.strandNoDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.strandNoDataGridViewTextBoxColumn3.Visible = false;
            // 
            // gapIDDataGridViewTextBoxColumn1
            // 
            this.gapIDDataGridViewTextBoxColumn1.DataPropertyName = "GapID";
            this.gapIDDataGridViewTextBoxColumn1.HeaderText = "水口";
            this.gapIDDataGridViewTextBoxColumn1.Name = "gapIDDataGridViewTextBoxColumn1";
            this.gapIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // factoryDataGridViewTextBoxColumn4
            // 
            this.factoryDataGridViewTextBoxColumn4.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn4.DataSource = this.dsBigGapFactory;
            this.factoryDataGridViewTextBoxColumn4.DisplayMember = "L3DataTable.MatFactory";
            this.factoryDataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.factoryDataGridViewTextBoxColumn4.HeaderText = "水口厂家";
            this.factoryDataGridViewTextBoxColumn4.Name = "factoryDataGridViewTextBoxColumn4";
            this.factoryDataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factoryDataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.factoryDataGridViewTextBoxColumn4.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsBigGapFactory
            // 
            this.dsBigGapFactory.AutoLoad = true;
            this.dsBigGapFactory.AutoSubscribe = false;
            this.dsBigGapFactory.DataSetName = "L3DataSet";
            this.dsBigGapFactory.DeleteMethod = null;
            this.dsBigGapFactory.InsertMethod = null;
            this.dsBigGapFactory.L3DataAdapter = this.Adapter;
            this.dsBigGapFactory.LoadEvent = "Click";
            this.dsBigGapFactory.LoadTrigger = null;
            this.dsBigGapFactory.RefreshValve = 1000;
            this.dsBigGapFactory.SourceCommand = null;
            this.dsBigGapFactory.SourceCondition = "MatName = \'大包水口\' and MatGroup_Code = \'TundishFac\'";
            this.dsBigGapFactory.SourceMethod = "";
            this.dsBigGapFactory.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBigGapFactory.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsBigGapFactory.SubscribeTarget = null;
            this.dsBigGapFactory.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBigGapFactory});
            this.dsBigGapFactory.UpdateEvent = "Click";
            this.dsBigGapFactory.UpdateMethod = null;
            this.dsBigGapFactory.UpdateTrigger = null;
            // 
            // schemadsBigGapFactory
            // 
            this.schemadsBigGapFactory.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBigGapFactoryL3DataTableMatFactory});
            this.schemadsBigGapFactory.TableName = "L3DataTable";
            // 
            // coldsBigGapFactoryL3DataTableMatFactory
            // 
            this.coldsBigGapFactoryL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsBigGapFactoryL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsBigGapFactoryL3DataTableMatFactory.Namespace = "";
            // 
            // matTypeDataGridViewTextBoxColumn
            // 
            this.matTypeDataGridViewTextBoxColumn.DataPropertyName = "MatType";
            this.matTypeDataGridViewTextBoxColumn.HeaderText = "材质";
            this.matTypeDataGridViewTextBoxColumn.Name = "matTypeDataGridViewTextBoxColumn";
            // 
            // gapLifeDataGridViewTextBoxColumn1
            // 
            this.gapLifeDataGridViewTextBoxColumn1.DataPropertyName = "GapLife";
            this.gapLifeDataGridViewTextBoxColumn1.HeaderText = "使用寿命";
            this.gapLifeDataGridViewTextBoxColumn1.Name = "gapLifeDataGridViewTextBoxColumn1";
            // 
            // changeTimeDataGridViewTextBoxColumn2
            // 
            this.changeTimeDataGridViewTextBoxColumn2.DataPropertyName = "ChangeTime";
            this.changeTimeDataGridViewTextBoxColumn2.HeaderText = "换上时间";
            this.changeTimeDataGridViewTextBoxColumn2.Name = "changeTimeDataGridViewTextBoxColumn2";
            this.changeTimeDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.changeTimeDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.changeTimeDataGridViewTextBoxColumn2.Width = 130;
            // 
            // reasonDataGridViewTextBoxColumn2
            // 
            this.reasonDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reasonDataGridViewTextBoxColumn2.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn2.DataSource = this.dsBigGapOFFReason;
            this.reasonDataGridViewTextBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.reasonDataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.reasonDataGridViewTextBoxColumn2.HeaderText = "换下原因";
            this.reasonDataGridViewTextBoxColumn2.Name = "reasonDataGridViewTextBoxColumn2";
            this.reasonDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reasonDataGridViewTextBoxColumn2.ValueMember = "L3DataTable.Code";
            // 
            // dsBigGapOFFReason
            // 
            this.dsBigGapOFFReason.AutoLoad = true;
            this.dsBigGapOFFReason.AutoSubscribe = false;
            this.dsBigGapOFFReason.DataSetName = "L3DataSet";
            this.dsBigGapOFFReason.DeleteMethod = null;
            this.dsBigGapOFFReason.InsertMethod = null;
            this.dsBigGapOFFReason.L3DataAdapter = this.Adapter;
            this.dsBigGapOFFReason.LoadEvent = "Click";
            this.dsBigGapOFFReason.LoadTrigger = null;
            this.dsBigGapOFFReason.RefreshValve = 1000;
            this.dsBigGapOFFReason.SourceCommand = null;
            this.dsBigGapOFFReason.SourceCondition = "Code_Group = \'BIGGAP_OFF_REASON\' order by Code";
            this.dsBigGapOFFReason.SourceMethod = "";
            this.dsBigGapOFFReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBigGapOFFReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBigGapOFFReason.SubscribeTarget = null;
            this.dsBigGapOFFReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBigGapOFFReason});
            this.dsBigGapOFFReason.UpdateEvent = "Click";
            this.dsBigGapOFFReason.UpdateMethod = null;
            this.dsBigGapOFFReason.UpdateTrigger = null;
            // 
            // schemadsBigGapOFFReason
            // 
            this.schemadsBigGapOFFReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBigGapOFFReasonL3DataTableCode,
            this.coldsBigGapOFFReasonL3DataTableCode_Des});
            this.schemadsBigGapOFFReason.TableName = "L3DataTable";
            // 
            // coldsBigGapOFFReasonL3DataTableCode
            // 
            this.coldsBigGapOFFReasonL3DataTableCode.Caption = "Code";
            this.coldsBigGapOFFReasonL3DataTableCode.ColumnName = "Code";
            this.coldsBigGapOFFReasonL3DataTableCode.Namespace = "";
            // 
            // coldsBigGapOFFReasonL3DataTableCode_Des
            // 
            this.coldsBigGapOFFReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBigGapOFFReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBigGapOFFReasonL3DataTableCode_Des.Namespace = "";
            // 
            // bsBigGap
            // 
            this.bsBigGap.DataMember = "L3DataTable";
            this.bsBigGap.DataSource = this.dsBigGap;
            // 
            // dsBigGap
            // 
            this.dsBigGap.AutoLoad = true;
            this.dsBigGap.AutoSubscribe = false;
            this.dsBigGap.DataSetName = "L3DataSet";
            this.dsBigGap.DeleteMethod = null;
            this.dsBigGap.InsertMethod = null;
            this.dsBigGap.L3DataAdapter = null;
            this.dsBigGap.LoadEvent = "Click";
            this.dsBigGap.LoadTrigger = null;
            this.dsBigGap.RefreshValve = 1000;
            this.dsBigGap.SourceCommand = null;
            this.dsBigGap.SourceCondition = null;
            this.dsBigGap.SourceMethod = "";
            this.dsBigGap.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBigGap.SourceURI = "XGMESLogic\\CCMMag\\CCCM_BigWaterGap";
            this.dsBigGap.SubscribeTarget = null;
            this.dsBigGap.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBigGap});
            this.dsBigGap.UpdateEvent = "Click";
            this.dsBigGap.UpdateMethod = null;
            this.dsBigGap.UpdateTrigger = null;
            // 
            // schemadsBigGap
            // 
            this.schemadsBigGap.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBigGapL3DataTableGUID,
            this.coldsBigGapL3DataTableName,
            this.coldsBigGapL3DataTableCCMID,
            this.coldsBigGapL3DataTableStrandNo,
            this.coldsBigGapL3DataTableGapID,
            this.coldsBigGapL3DataTableFactory,
            this.coldsBigGapL3DataTableMatType,
            this.coldsBigGapL3DataTableGapLife,
            this.coldsBigGapL3DataTableChangeTime,
            this.coldsBigGapL3DataTableHeatID,
            this.coldsBigGapL3DataTableReason});
            this.schemadsBigGap.TableName = "L3DataTable";
            // 
            // coldsBigGapL3DataTableGUID
            // 
            this.coldsBigGapL3DataTableGUID.Caption = "GUID";
            this.coldsBigGapL3DataTableGUID.ColumnName = "GUID";
            this.coldsBigGapL3DataTableGUID.Namespace = "";
            // 
            // coldsBigGapL3DataTableName
            // 
            this.coldsBigGapL3DataTableName.Caption = "Name";
            this.coldsBigGapL3DataTableName.ColumnName = "Name";
            this.coldsBigGapL3DataTableName.Namespace = "";
            // 
            // coldsBigGapL3DataTableCCMID
            // 
            this.coldsBigGapL3DataTableCCMID.Caption = "CCMID";
            this.coldsBigGapL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsBigGapL3DataTableCCMID.Namespace = "";
            // 
            // coldsBigGapL3DataTableStrandNo
            // 
            this.coldsBigGapL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsBigGapL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsBigGapL3DataTableStrandNo.Namespace = "";
            // 
            // coldsBigGapL3DataTableGapID
            // 
            this.coldsBigGapL3DataTableGapID.Caption = "GapID";
            this.coldsBigGapL3DataTableGapID.ColumnName = "GapID";
            this.coldsBigGapL3DataTableGapID.Namespace = "";
            // 
            // coldsBigGapL3DataTableFactory
            // 
            this.coldsBigGapL3DataTableFactory.Caption = "Factory";
            this.coldsBigGapL3DataTableFactory.ColumnName = "Factory";
            this.coldsBigGapL3DataTableFactory.Namespace = "";
            // 
            // coldsBigGapL3DataTableMatType
            // 
            this.coldsBigGapL3DataTableMatType.Caption = "MatType";
            this.coldsBigGapL3DataTableMatType.ColumnName = "MatType";
            this.coldsBigGapL3DataTableMatType.Namespace = "";
            // 
            // coldsBigGapL3DataTableGapLife
            // 
            this.coldsBigGapL3DataTableGapLife.Caption = "GapLife";
            this.coldsBigGapL3DataTableGapLife.ColumnName = "GapLife";
            this.coldsBigGapL3DataTableGapLife.DataType = typeof(int);
            this.coldsBigGapL3DataTableGapLife.Namespace = "";
            // 
            // coldsBigGapL3DataTableChangeTime
            // 
            this.coldsBigGapL3DataTableChangeTime.Caption = "ChangeTime";
            this.coldsBigGapL3DataTableChangeTime.ColumnName = "ChangeTime";
            this.coldsBigGapL3DataTableChangeTime.DataType = typeof(System.DateTime);
            this.coldsBigGapL3DataTableChangeTime.Namespace = "";
            // 
            // coldsBigGapL3DataTableHeatID
            // 
            this.coldsBigGapL3DataTableHeatID.Caption = "HeatID";
            this.coldsBigGapL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBigGapL3DataTableHeatID.Namespace = "";
            // 
            // coldsBigGapL3DataTableReason
            // 
            this.coldsBigGapL3DataTableReason.Caption = "Reason";
            this.coldsBigGapL3DataTableReason.ColumnName = "Reason";
            this.coldsBigGapL3DataTableReason.Namespace = "";
            // 
            // pnlBigGap
            // 
            this.pnlBigGap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBigGap.Controls.Add(this.btnBigGapCancel);
            this.pnlBigGap.Controls.Add(this.btnBigGapConfirm);
            this.pnlBigGap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBigGap.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBigGap.Location = new System.Drawing.Point(0, 362);
            this.pnlBigGap.Name = "pnlBigGap";
            this.pnlBigGap.Size = new System.Drawing.Size(953, 32);
            this.pnlBigGap.TabIndex = 102;
            // 
            // btnBigGapCancel
            // 
            this.btnBigGapCancel.Location = new System.Drawing.Point(871, 3);
            this.btnBigGapCancel.Name = "btnBigGapCancel";
            this.btnBigGapCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBigGapCancel.TabIndex = 87;
            this.btnBigGapCancel.Text = "取消";
            this.btnBigGapCancel.UseVisualStyleBackColor = true;
            this.btnBigGapCancel.Click += new System.EventHandler(this.btnBigGapCancel_Click);
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = null;
            this.bindingNavigator5.BindingSource = this.bsBigGap;
            this.bindingNavigator5.CountItem = this.toolStripLabel13;
            this.bindingNavigator5.DeleteItem = null;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton51,
            this.toolStripButton52,
            this.toolStripSeparator37,
            this.toolStripTextBox13,
            this.toolStripLabel13,
            this.toolStripSeparator38,
            this.toolStripButton53,
            this.toolStripButton54,
            this.toolStripSeparator39,
            this.btnBigGapAdd,
            this.btnBigGapDel});
            this.bindingNavigator5.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator5.MoveFirstItem = this.toolStripButton51;
            this.bindingNavigator5.MoveLastItem = this.toolStripButton54;
            this.bindingNavigator5.MoveNextItem = this.toolStripButton53;
            this.bindingNavigator5.MovePreviousItem = this.toolStripButton52;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.toolStripTextBox13;
            this.bindingNavigator5.Size = new System.Drawing.Size(953, 25);
            this.bindingNavigator5.TabIndex = 100;
            this.bindingNavigator5.Text = "bindingNavigator7";
            // 
            // toolStripLabel13
            // 
            this.toolStripLabel13.Name = "toolStripLabel13";
            this.toolStripLabel13.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel13.Text = "/ {0}";
            this.toolStripLabel13.ToolTipText = "总项数";
            // 
            // toolStripButton51
            // 
            this.toolStripButton51.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton51.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton51.Image")));
            this.toolStripButton51.Name = "toolStripButton51";
            this.toolStripButton51.RightToLeftAutoMirrorImage = true;
            this.toolStripButton51.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton51.Text = "移到第一条记录";
            // 
            // toolStripButton52
            // 
            this.toolStripButton52.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton52.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton52.Image")));
            this.toolStripButton52.Name = "toolStripButton52";
            this.toolStripButton52.RightToLeftAutoMirrorImage = true;
            this.toolStripButton52.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton52.Text = "移到上一条记录";
            // 
            // toolStripSeparator37
            // 
            this.toolStripSeparator37.Name = "toolStripSeparator37";
            this.toolStripSeparator37.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox13
            // 
            this.toolStripTextBox13.AccessibleName = "位置";
            this.toolStripTextBox13.AutoSize = false;
            this.toolStripTextBox13.Name = "toolStripTextBox13";
            this.toolStripTextBox13.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox13.Text = "0";
            this.toolStripTextBox13.ToolTipText = "当前位置";
            // 
            // toolStripSeparator38
            // 
            this.toolStripSeparator38.Name = "toolStripSeparator38";
            this.toolStripSeparator38.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton53
            // 
            this.toolStripButton53.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton53.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton53.Image")));
            this.toolStripButton53.Name = "toolStripButton53";
            this.toolStripButton53.RightToLeftAutoMirrorImage = true;
            this.toolStripButton53.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton53.Text = "移到下一条记录";
            // 
            // toolStripButton54
            // 
            this.toolStripButton54.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton54.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton54.Image")));
            this.toolStripButton54.Name = "toolStripButton54";
            this.toolStripButton54.RightToLeftAutoMirrorImage = true;
            this.toolStripButton54.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton54.Text = "移到最后一条记录";
            // 
            // toolStripSeparator39
            // 
            this.toolStripSeparator39.Name = "toolStripSeparator39";
            this.toolStripSeparator39.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 432);
            this.tabPage1.TabIndex = 26;
            this.tabPage1.Text = "跟踪值";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(967, 426);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(813, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "查询跟踪值";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(967, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "heatid";
            this.Column1.HeaderText = "炉号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "L1";
            this.Column2.HeaderText = "1流跟踪值";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "L2";
            this.Column3.HeaderText = "2流跟踪值";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "L3";
            this.Column4.HeaderText = "3流跟踪值";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "L4";
            this.Column5.HeaderText = "4流跟踪值";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "C_TS";
            this.Column6.HeaderText = "上传时间";
            this.Column6.Name = "Column6";
            // 
            // bsTempUpTo
            // 
            this.bsTempUpTo.DataMember = "L3DataTable";
            this.bsTempUpTo.DataSource = this.dsCommonYesNo;
            // 
            // bsProtection
            // 
            this.bsProtection.DataMember = "L3DataTable";
            this.bsProtection.DataSource = this.dsCommonYesNo;
            // 
            // dsliquid_level
            // 
            this.dsliquid_level.AutoLoad = true;
            this.dsliquid_level.AutoSubscribe = false;
            this.dsliquid_level.DataSetName = "L3DataSet";
            this.dsliquid_level.DeleteMethod = null;
            this.dsliquid_level.InsertMethod = null;
            this.dsliquid_level.L3DataAdapter = this.Adapter;
            this.dsliquid_level.LoadEvent = "Click";
            this.dsliquid_level.LoadTrigger = null;
            this.dsliquid_level.RefreshValve = 1000;
            this.dsliquid_level.SourceCommand = null;
            this.dsliquid_level.SourceCondition = "Code_Group = \'CCM_liquid_level\' order by Code";
            this.dsliquid_level.SourceMethod = "";
            this.dsliquid_level.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsliquid_level.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsliquid_level.SubscribeTarget = null;
            this.dsliquid_level.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsliquid_level});
            this.dsliquid_level.UpdateEvent = "Click";
            this.dsliquid_level.UpdateMethod = null;
            this.dsliquid_level.UpdateTrigger = null;
            // 
            // schemadsliquid_level
            // 
            this.schemadsliquid_level.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsliquid_levelL3DataTableCode,
            this.coldsliquid_levelL3DataTableCode_Des,
            this.coldsliquid_levelL3DataTableCode_Val_Long});
            this.schemadsliquid_level.TableName = "L3DataTable";
            // 
            // coldsliquid_levelL3DataTableCode
            // 
            this.coldsliquid_levelL3DataTableCode.Caption = "Code";
            this.coldsliquid_levelL3DataTableCode.ColumnName = "Code";
            this.coldsliquid_levelL3DataTableCode.Namespace = "";
            // 
            // coldsliquid_levelL3DataTableCode_Des
            // 
            this.coldsliquid_levelL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsliquid_levelL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsliquid_levelL3DataTableCode_Des.Namespace = "";
            // 
            // coldsliquid_levelL3DataTableCode_Val_Long
            // 
            this.coldsliquid_levelL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsliquid_levelL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsliquid_levelL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsliquid_levelL3DataTableCode_Val_Long.Namespace = "";
            // 
            // dsCuFactory
            // 
            this.dsCuFactory.AutoLoad = true;
            this.dsCuFactory.AutoSubscribe = false;
            this.dsCuFactory.DataSetName = "L3DataSet";
            this.dsCuFactory.DeleteMethod = null;
            this.dsCuFactory.InsertMethod = null;
            this.dsCuFactory.L3DataAdapter = this.Adapter;
            this.dsCuFactory.LoadEvent = "Click";
            this.dsCuFactory.LoadTrigger = null;
            this.dsCuFactory.RefreshValve = 1000;
            this.dsCuFactory.SourceCommand = null;
            this.dsCuFactory.SourceCondition = "MATGROUP_CODE = \'MoldFac\' and MATNAME = \'铜板\'";
            this.dsCuFactory.SourceMethod = "";
            this.dsCuFactory.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCuFactory.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCuFactory.SubscribeTarget = null;
            this.dsCuFactory.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCuFactory});
            this.dsCuFactory.UpdateEvent = "Click";
            this.dsCuFactory.UpdateMethod = null;
            this.dsCuFactory.UpdateTrigger = null;
            // 
            // schemadsCuFactory
            // 
            this.schemadsCuFactory.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCuFactoryL3DataTableMatFactory,
            this.coldsCuFactoryL3DataTableMatName,
            this.coldsCuFactoryL3DataTableMatGroup_Code,
            this.coldsCuFactoryL3DataTableMatGroup_Des});
            this.schemadsCuFactory.TableName = "L3DataTable";
            // 
            // coldsCuFactoryL3DataTableMatFactory
            // 
            this.coldsCuFactoryL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsCuFactoryL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsCuFactoryL3DataTableMatFactory.Namespace = "";
            // 
            // coldsCuFactoryL3DataTableMatName
            // 
            this.coldsCuFactoryL3DataTableMatName.Caption = "MatName";
            this.coldsCuFactoryL3DataTableMatName.ColumnName = "MatName";
            this.coldsCuFactoryL3DataTableMatName.Namespace = "";
            // 
            // coldsCuFactoryL3DataTableMatGroup_Code
            // 
            this.coldsCuFactoryL3DataTableMatGroup_Code.Caption = "MatGroup_Code";
            this.coldsCuFactoryL3DataTableMatGroup_Code.ColumnName = "MatGroup_Code";
            this.coldsCuFactoryL3DataTableMatGroup_Code.Namespace = "";
            // 
            // coldsCuFactoryL3DataTableMatGroup_Des
            // 
            this.coldsCuFactoryL3DataTableMatGroup_Des.Caption = "MatGroup_Des";
            this.coldsCuFactoryL3DataTableMatGroup_Des.ColumnName = "MatGroup_Des";
            this.coldsCuFactoryL3DataTableMatGroup_Des.Namespace = "";
            // 
            // dsInjectionBar
            // 
            this.dsInjectionBar.AutoLoad = true;
            this.dsInjectionBar.AutoSubscribe = false;
            this.dsInjectionBar.DataSetName = "L3DataSet";
            this.dsInjectionBar.DeleteMethod = null;
            this.dsInjectionBar.InsertMethod = null;
            this.dsInjectionBar.L3DataAdapter = this.Adapter;
            this.dsInjectionBar.LoadEvent = "Click";
            this.dsInjectionBar.LoadTrigger = null;
            this.dsInjectionBar.RefreshValve = 1000;
            this.dsInjectionBar.SourceCommand = null;
            this.dsInjectionBar.SourceCondition = "CODE_GROUP = \'Tuck_Stick_Case\'";
            this.dsInjectionBar.SourceMethod = "";
            this.dsInjectionBar.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInjectionBar.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsInjectionBar.SubscribeTarget = null;
            this.dsInjectionBar.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInjectionBar});
            this.dsInjectionBar.UpdateEvent = "Click";
            this.dsInjectionBar.UpdateMethod = null;
            this.dsInjectionBar.UpdateTrigger = null;
            // 
            // schemadsInjectionBar
            // 
            this.schemadsInjectionBar.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInjectionBarL3DataTableCode,
            this.coldsInjectionBarL3DataTableCode_Des});
            this.schemadsInjectionBar.TableName = "L3DataTable";
            // 
            // coldsInjectionBarL3DataTableCode
            // 
            this.coldsInjectionBarL3DataTableCode.Caption = "Code";
            this.coldsInjectionBarL3DataTableCode.ColumnName = "Code";
            this.coldsInjectionBarL3DataTableCode.Namespace = "";
            // 
            // coldsInjectionBarL3DataTableCode_Des
            // 
            this.coldsInjectionBarL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsInjectionBarL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsInjectionBarL3DataTableCode_Des.Namespace = "";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(708, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 87;
            this.button13.Text = "取消";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(627, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 86;
            this.button14.Text = "确认";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(807, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 87;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(726, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 86;
            this.button4.Text = "确认";
            this.button4.UseVisualStyleBackColor = true;
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
            // dsWaterGapCenter
            // 
            this.dsWaterGapCenter.AutoLoad = true;
            this.dsWaterGapCenter.AutoSubscribe = false;
            this.dsWaterGapCenter.DataSetName = "L3DataSet";
            this.dsWaterGapCenter.DeleteMethod = null;
            this.dsWaterGapCenter.InsertMethod = null;
            this.dsWaterGapCenter.L3DataAdapter = this.Adapter;
            this.dsWaterGapCenter.LoadEvent = "Click";
            this.dsWaterGapCenter.LoadTrigger = null;
            this.dsWaterGapCenter.RefreshValve = 1000;
            this.dsWaterGapCenter.SourceCommand = null;
            this.dsWaterGapCenter.SourceCondition = "Code_Group = \'CCM_WaterGap_Center\' order by Code";
            this.dsWaterGapCenter.SourceMethod = "";
            this.dsWaterGapCenter.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWaterGapCenter.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWaterGapCenter.SubscribeTarget = null;
            this.dsWaterGapCenter.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWaterGapCenter});
            this.dsWaterGapCenter.UpdateEvent = "Click";
            this.dsWaterGapCenter.UpdateMethod = null;
            this.dsWaterGapCenter.UpdateTrigger = null;
            // 
            // schemadsWaterGapCenter
            // 
            this.schemadsWaterGapCenter.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWaterGapCenterL3DataTableCode,
            this.coldsWaterGapCenterL3DataTableCode_Des,
            this.coldsWaterGapCenterL3DataTableCode_Val_Long});
            this.schemadsWaterGapCenter.TableName = "L3DataTable";
            // 
            // coldsWaterGapCenterL3DataTableCode
            // 
            this.coldsWaterGapCenterL3DataTableCode.Caption = "Code";
            this.coldsWaterGapCenterL3DataTableCode.ColumnName = "Code";
            this.coldsWaterGapCenterL3DataTableCode.Namespace = "";
            // 
            // coldsWaterGapCenterL3DataTableCode_Des
            // 
            this.coldsWaterGapCenterL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWaterGapCenterL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWaterGapCenterL3DataTableCode_Des.Namespace = "";
            // 
            // coldsWaterGapCenterL3DataTableCode_Val_Long
            // 
            this.coldsWaterGapCenterL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsWaterGapCenterL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsWaterGapCenterL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsWaterGapCenterL3DataTableCode_Val_Long.Namespace = "";
            // 
            // hmiRootPanel7
            // 
            this.hmiRootPanel7.Controls.Add(this.dvSmoothBlock);
            this.hmiRootPanel7.Controls.Add(this.pnlSmoothBlock);
            this.hmiRootPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel7.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel7.Name = "hmiRootPanel7";
            this.hmiRootPanel7.Size = new System.Drawing.Size(984, 320);
            this.hmiRootPanel7.TabIndex = 0;
            // 
            // dvSmoothBlock
            // 
            this.dvSmoothBlock.AllowUserToAddRows = false;
            this.dvSmoothBlock.AutoGenerateColumns = false;
            this.dvSmoothBlock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvSmoothBlock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvSmoothBlock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSmoothBlock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCMIDDataGridViewTextBoxColumn5,
            this.heatIDDataGridViewTextBoxColumn12,
            this.strandNoDataGridViewTextBoxColumn1,
            this.blockIDDataGridViewTextBoxColumn,
            this.blockLifeDataGridViewTextBoxColumn,
            this.factoryDataGridViewTextBoxColumn2,
            this.startTimeDataGridViewTextBoxColumn3,
            this.endTimeDataGridViewTextBoxColumn,
            this.blockSizeDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn});
            this.dvSmoothBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSmoothBlock.Location = new System.Drawing.Point(0, 0);
            this.dvSmoothBlock.Name = "dvSmoothBlock";
            this.dvSmoothBlock.RowHeadersVisible = false;
            this.dvSmoothBlock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvSmoothBlock.RowTemplate.Height = 23;
            this.dvSmoothBlock.Size = new System.Drawing.Size(984, 288);
            this.dvSmoothBlock.TabIndex = 103;
            // 
            // cCMIDDataGridViewTextBoxColumn5
            // 
            this.cCMIDDataGridViewTextBoxColumn5.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn5.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn5.Name = "cCMIDDataGridViewTextBoxColumn5";
            // 
            // heatIDDataGridViewTextBoxColumn12
            // 
            this.heatIDDataGridViewTextBoxColumn12.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn12.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn12.Name = "heatIDDataGridViewTextBoxColumn12";
            // 
            // strandNoDataGridViewTextBoxColumn1
            // 
            this.strandNoDataGridViewTextBoxColumn1.DataPropertyName = "StrandNo";
            this.strandNoDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.strandNoDataGridViewTextBoxColumn1.HeaderText = "流号";
            this.strandNoDataGridViewTextBoxColumn1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.strandNoDataGridViewTextBoxColumn1.Name = "strandNoDataGridViewTextBoxColumn1";
            this.strandNoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.strandNoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // blockIDDataGridViewTextBoxColumn
            // 
            this.blockIDDataGridViewTextBoxColumn.DataPropertyName = "BlockID";
            this.blockIDDataGridViewTextBoxColumn.HeaderText = "滑块";
            this.blockIDDataGridViewTextBoxColumn.Name = "blockIDDataGridViewTextBoxColumn";
            this.blockIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // blockLifeDataGridViewTextBoxColumn
            // 
            this.blockLifeDataGridViewTextBoxColumn.DataPropertyName = "Block_Life";
            this.blockLifeDataGridViewTextBoxColumn.HeaderText = "滑块寿命";
            this.blockLifeDataGridViewTextBoxColumn.Name = "blockLifeDataGridViewTextBoxColumn";
            // 
            // factoryDataGridViewTextBoxColumn2
            // 
            this.factoryDataGridViewTextBoxColumn2.DataPropertyName = "Factory";
            this.factoryDataGridViewTextBoxColumn2.DataSource = this.dsSmoothBlockFactory;
            this.factoryDataGridViewTextBoxColumn2.DisplayMember = "L3DataTable.MatFactory";
            this.factoryDataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.factoryDataGridViewTextBoxColumn2.HeaderText = "滑块厂家";
            this.factoryDataGridViewTextBoxColumn2.Name = "factoryDataGridViewTextBoxColumn2";
            this.factoryDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.factoryDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.factoryDataGridViewTextBoxColumn2.ValueMember = "L3DataTable.MatFactory";
            // 
            // startTimeDataGridViewTextBoxColumn3
            // 
            this.startTimeDataGridViewTextBoxColumn3.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn3.HeaderText = "滑块更换开始时刻";
            this.startTimeDataGridViewTextBoxColumn3.Name = "startTimeDataGridViewTextBoxColumn3";
            this.startTimeDataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.startTimeDataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "End_Time";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "滑块更换结束时刻";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // blockSizeDataGridViewTextBoxColumn
            // 
            this.blockSizeDataGridViewTextBoxColumn.DataPropertyName = "Block_Size";
            this.blockSizeDataGridViewTextBoxColumn.HeaderText = "规格";
            this.blockSizeDataGridViewTextBoxColumn.Name = "blockSizeDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.DataSource = this.dsSmoothBlockOFFReason;
            this.reasonDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.reasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.reasonDataGridViewTextBoxColumn.HeaderText = "更换原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reasonDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // pnlSmoothBlock
            // 
            this.pnlSmoothBlock.BackColor = System.Drawing.Color.Red;
            this.pnlSmoothBlock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSmoothBlock.Controls.Add(this.btnCancel);
            this.pnlSmoothBlock.Controls.Add(this.btnSmoothBlockConfirm);
            this.pnlSmoothBlock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSmoothBlock.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlSmoothBlock.Location = new System.Drawing.Point(0, 288);
            this.pnlSmoothBlock.Name = "pnlSmoothBlock";
            this.pnlSmoothBlock.Size = new System.Drawing.Size(984, 32);
            this.pnlSmoothBlock.TabIndex = 102;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(902, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 87;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSmoothBlockConfirm
            // 
            this.btnSmoothBlockConfirm.Location = new System.Drawing.Point(821, 3);
            this.btnSmoothBlockConfirm.Name = "btnSmoothBlockConfirm";
            this.btnSmoothBlockConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnSmoothBlockConfirm.TabIndex = 86;
            this.btnSmoothBlockConfirm.Text = "确认";
            this.btnSmoothBlockConfirm.UseVisualStyleBackColor = true;
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
            // dsReason
            // 
            this.dsReason.AutoLoad = true;
            this.dsReason.AutoSubscribe = false;
            this.dsReason.DataSetName = "L3DataSet";
            this.dsReason.DeleteMethod = null;
            this.dsReason.InsertMethod = null;
            this.dsReason.L3DataAdapter = this.Adapter;
            this.dsReason.LoadEvent = "Click";
            this.dsReason.LoadTrigger = null;
            this.dsReason.RefreshValve = 1000;
            this.dsReason.SourceCommand = null;
            this.dsReason.SourceCondition = "CODE_GROUP = \'HoldTime_Reason\'";
            this.dsReason.SourceMethod = "";
            this.dsReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsReason.SubscribeTarget = null;
            this.dsReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsReason});
            this.dsReason.UpdateEvent = "Click";
            this.dsReason.UpdateMethod = null;
            this.dsReason.UpdateTrigger = null;
            // 
            // schemadsReason
            // 
            this.schemadsReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsReasonL3DataTableName,
            this.coldsReasonL3DataTableCode,
            this.coldsReasonL3DataTableCode_Des,
            this.coldsReasonL3DataTableCode_Group,
            this.coldsReasonL3DataTableCode_Group_Des,
            this.coldsReasonL3DataTableCode_Val_Str,
            this.coldsReasonL3DataTableCode_Val_Long,
            this.coldsReasonL3DataTableCode_Val_Double,
            this.coldsReasonL3DataTableCode_Function_Group,
            this.coldsReasonL3DataTableNC_Code});
            this.schemadsReason.TableName = "L3DataTable";
            // 
            // coldsReasonL3DataTableName
            // 
            this.coldsReasonL3DataTableName.Caption = "Name";
            this.coldsReasonL3DataTableName.ColumnName = "Name";
            this.coldsReasonL3DataTableName.Namespace = "";
            // 
            // coldsReasonL3DataTableCode
            // 
            this.coldsReasonL3DataTableCode.Caption = "Code";
            this.coldsReasonL3DataTableCode.ColumnName = "Code";
            this.coldsReasonL3DataTableCode.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Des
            // 
            this.coldsReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsReasonL3DataTableCode_Des.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Group
            // 
            this.coldsReasonL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsReasonL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsReasonL3DataTableCode_Group.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Group_Des
            // 
            this.coldsReasonL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsReasonL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsReasonL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Val_Str
            // 
            this.coldsReasonL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsReasonL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsReasonL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Val_Long
            // 
            this.coldsReasonL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsReasonL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsReasonL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsReasonL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Val_Double
            // 
            this.coldsReasonL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsReasonL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsReasonL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsReasonL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsReasonL3DataTableCode_Function_Group
            // 
            this.coldsReasonL3DataTableCode_Function_Group.Caption = "Code_Function_Group";
            this.coldsReasonL3DataTableCode_Function_Group.ColumnName = "Code_Function_Group";
            this.coldsReasonL3DataTableCode_Function_Group.Namespace = "";
            // 
            // coldsReasonL3DataTableNC_Code
            // 
            this.coldsReasonL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsReasonL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsReasonL3DataTableNC_Code.Namespace = "";
            // 
            // coldsReasonL3DataTableGUID
            // 
            this.coldsReasonL3DataTableGUID.Caption = "GUID";
            this.coldsReasonL3DataTableGUID.ColumnName = "GUID";
            this.coldsReasonL3DataTableGUID.Namespace = "";
            // 
            // cmdExcept
            // 
            this.cmdExcept.Adapter = this.Adapter;
            this.cmdExcept.MergeReturnTarget = false;
            this.cmdExcept.Method = "InsertBaseParameter";
            this.cmdExcept.Object = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
            this.cmdExcept.Parameters.Add(this.l3CommandParameter1);
            this.cmdExcept.Parameters.Add(this.l3CommandParameter2);
            this.cmdExcept.ReturnTarget = null;
            this.cmdExcept.ReturnTargetProperty = null;
            this.cmdExcept.Trigger = null;
            this.cmdExcept.TriggerEvent = "Click";
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
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(369, 202);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(95, 12);
            this.label28.TabIndex = 151;
            this.label28.Text = "中包壁温度[℃]:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(369, 175);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(95, 12);
            this.label29.TabIndex = 151;
            this.label29.Text = "中包底温度[℃]:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(624, 175);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(113, 12);
            this.label31.TabIndex = 151;
            this.label31.Text = "3流轻压下是否投用:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(654, 230);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 12);
            this.label32.TabIndex = 151;
            this.label32.Text = "拉速是否调整:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(405, 230);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 12);
            this.label37.TabIndex = 151;
            this.label37.Text = "塞棒控制:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(624, 148);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(113, 12);
            this.label38.TabIndex = 151;
            this.label38.Text = "2流轻压下是否投用:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(624, 202);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(113, 12);
            this.label40.TabIndex = 151;
            this.label40.Text = "4流轻压下是否投用:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(624, 121);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(113, 12);
            this.label41.TabIndex = 150;
            this.label41.Text = "1流轻压下是否投用:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(31, 201);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(155, 12);
            this.label42.TabIndex = 150;
            this.label42.Text = "中包液面[mm]/中包重量[T]:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(79, 175);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(107, 12);
            this.label44.TabIndex = 150;
            this.label44.Text = "中包渣层厚度[mm]:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "Second_Cooling_Mode", true));
            this.comboBox1.DataSource = this.dsSecondCoolingMode;
            this.comboBox1.DisplayMember = "L3DataTable.Code_Des";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(743, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 20);
            this.comboBox1.TabIndex = 149;
            this.comboBox1.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "InjectionBar_BlowAr", true));
            this.comboBox5.DataSource = this.dsYesNo;
            this.comboBox5.DisplayMember = "L3DataTable.Code_Des";
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(470, 90);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(144, 20);
            this.comboBox5.TabIndex = 148;
            this.comboBox5.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "TundishCar_Type", true));
            this.comboBox6.Enabled = false;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            ""});
            this.comboBox6.Location = new System.Drawing.Point(743, 36);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(144, 20);
            this.comboBox6.TabIndex = 147;
            // 
            // comboBox7
            // 
            this.comboBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_2", true));
            this.comboBox7.Enabled = false;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox7.Location = new System.Drawing.Point(743, 145);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(144, 20);
            this.comboBox7.TabIndex = 147;
            // 
            // comboBox8
            // 
            this.comboBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_4", true));
            this.comboBox8.Enabled = false;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox8.Location = new System.Drawing.Point(743, 199);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(144, 20);
            this.comboBox8.TabIndex = 147;
            // 
            // comboBox9
            // 
            this.comboBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_1", true));
            this.comboBox9.Enabled = false;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox9.Location = new System.Drawing.Point(743, 118);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(144, 20);
            this.comboBox9.TabIndex = 147;
            // 
            // comboBox10
            // 
            this.comboBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Soft_Press_Flag_3", true));
            this.comboBox10.Enabled = false;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox10.Location = new System.Drawing.Point(743, 172);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(144, 20);
            this.comboBox10.TabIndex = 147;
            // 
            // comboBox11
            // 
            this.comboBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "SpeedChange", true));
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox11.Location = new System.Drawing.Point(743, 227);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(144, 20);
            this.comboBox11.TabIndex = 147;
            // 
            // comboBox12
            // 
            this.comboBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "PlugBar_Control", true));
            this.comboBox12.Enabled = false;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "自动",
            "手动"});
            this.comboBox12.Location = new System.Drawing.Point(470, 227);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(144, 20);
            this.comboBox12.TabIndex = 147;
            // 
            // comboBox13
            // 
            this.comboBox13.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "Weight_Return_Reason", true));
            this.comboBox13.DataSource = this.dsReturn_Reason;
            this.comboBox13.DisplayMember = "L3DataTable.Code_Des";
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(470, 143);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(144, 20);
            this.comboBox13.TabIndex = 147;
            this.comboBox13.ValueMember = "L3DataTable.Code";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "CastingStopTime", true));
            this.dateTimePicker3.Enabled = false;
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(192, 90);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker3.TabIndex = 144;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(127, 94);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(59, 12);
            this.label45.TabIndex = 146;
            this.label45.Text = "停浇时间:";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "CastingStartTime", true));
            this.dateTimePicker4.Enabled = false;
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(192, 63);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker4.TabIndex = 144;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(127, 67);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(59, 12);
            this.label46.TabIndex = 146;
            this.label46.Text = "开浇时间:";
            // 
            // pxTextBox5
            // 
            this.pxTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_HeatNum", true));
            this.pxTextBox5.DisplayPrecision = 0;
            this.pxTextBox5.EnableNull = true;
            this.pxTextBox5.ErropPr = null;
            this.pxTextBox5.FixedLength = 0;
            this.pxTextBox5.Length = 0;
            this.pxTextBox5.Location = new System.Drawing.Point(470, 63);
            this.pxTextBox5.Max = 0D;
            this.pxTextBox5.MaxNull = 0D;
            this.pxTextBox5.MaxStringLength = 0;
            this.pxTextBox5.MaxStrLength = 0;
            this.pxTextBox5.Min = 0D;
            this.pxTextBox5.MinNull = 0D;
            this.pxTextBox5.MinStringLength = 0;
            this.pxTextBox5.MinStrLength = 0;
            this.pxTextBox5.Name = "pxTextBox5";
            this.pxTextBox5.Precision = 0;
            this.pxTextBox5.ReadOnly = true;
            this.pxTextBox5.Regex = "";
            this.pxTextBox5.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox5.TabIndex = 142;
            this.pxTextBox5.ToolTipValid = null;
            this.pxTextBox5.VaildWarning = "";
            this.pxTextBox5.ValidEable = true;
            this.pxTextBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox6
            // 
            this.pxTextBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_Bottom_Temp", true));
            this.pxTextBox6.DisplayPrecision = 0;
            this.pxTextBox6.EnableNull = true;
            this.pxTextBox6.ErropPr = null;
            this.pxTextBox6.FixedLength = 0;
            this.pxTextBox6.Length = 0;
            this.pxTextBox6.Location = new System.Drawing.Point(470, 169);
            this.pxTextBox6.Max = 0D;
            this.pxTextBox6.MaxNull = 0D;
            this.pxTextBox6.MaxStringLength = 0;
            this.pxTextBox6.MaxStrLength = 0;
            this.pxTextBox6.Min = 0D;
            this.pxTextBox6.MinNull = 0D;
            this.pxTextBox6.MinStringLength = 0;
            this.pxTextBox6.MinStrLength = 0;
            this.pxTextBox6.Name = "pxTextBox6";
            this.pxTextBox6.Precision = 0;
            this.pxTextBox6.Regex = "";
            this.pxTextBox6.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox6.TabIndex = 142;
            this.pxTextBox6.ToolTipValid = null;
            this.pxTextBox6.VaildWarning = "";
            this.pxTextBox6.ValidEable = true;
            this.pxTextBox6.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox7
            // 
            this.pxTextBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_Level_Mold", true));
            this.pxTextBox7.DisplayPrecision = 0;
            this.pxTextBox7.EnableNull = true;
            this.pxTextBox7.ErropPr = null;
            this.pxTextBox7.FixedLength = 0;
            this.pxTextBox7.Length = 0;
            this.pxTextBox7.Location = new System.Drawing.Point(192, 198);
            this.pxTextBox7.Max = 0D;
            this.pxTextBox7.MaxNull = 0D;
            this.pxTextBox7.MaxStringLength = 0;
            this.pxTextBox7.MaxStrLength = 0;
            this.pxTextBox7.Min = 0D;
            this.pxTextBox7.MinNull = 0D;
            this.pxTextBox7.MinStringLength = 0;
            this.pxTextBox7.MinStrLength = 0;
            this.pxTextBox7.Name = "pxTextBox7";
            this.pxTextBox7.Precision = 0;
            this.pxTextBox7.Regex = "";
            this.pxTextBox7.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox7.TabIndex = 142;
            this.pxTextBox7.ToolTipValid = null;
            this.pxTextBox7.VaildWarning = "";
            this.pxTextBox7.ValidEable = true;
            this.pxTextBox7.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox8
            // 
            this.pxTextBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_SlagThickness", true));
            this.pxTextBox8.DisplayPrecision = 0;
            this.pxTextBox8.EnableNull = true;
            this.pxTextBox8.ErropPr = null;
            this.pxTextBox8.FixedLength = 0;
            this.pxTextBox8.Length = 0;
            this.pxTextBox8.Location = new System.Drawing.Point(192, 171);
            this.pxTextBox8.Max = 0D;
            this.pxTextBox8.MaxNull = 0D;
            this.pxTextBox8.MaxStringLength = 0;
            this.pxTextBox8.MaxStrLength = 0;
            this.pxTextBox8.Min = 0D;
            this.pxTextBox8.MinNull = 0D;
            this.pxTextBox8.MinStringLength = 0;
            this.pxTextBox8.MinStrLength = 0;
            this.pxTextBox8.Name = "pxTextBox8";
            this.pxTextBox8.Precision = 0;
            this.pxTextBox8.Regex = "";
            this.pxTextBox8.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox8.TabIndex = 142;
            this.pxTextBox8.ToolTipValid = null;
            this.pxTextBox8.VaildWarning = "";
            this.pxTextBox8.ValidEable = true;
            this.pxTextBox8.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox9
            // 
            this.pxTextBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Casting_HeatNum", true));
            this.pxTextBox9.DisplayPrecision = 0;
            this.pxTextBox9.EnableNull = true;
            this.pxTextBox9.ErropPr = null;
            this.pxTextBox9.FixedLength = 0;
            this.pxTextBox9.Length = 0;
            this.pxTextBox9.Location = new System.Drawing.Point(192, 144);
            this.pxTextBox9.Max = 0D;
            this.pxTextBox9.MaxNull = 0D;
            this.pxTextBox9.MaxStringLength = 0;
            this.pxTextBox9.MaxStrLength = 0;
            this.pxTextBox9.Min = 0D;
            this.pxTextBox9.MinNull = 0D;
            this.pxTextBox9.MinStringLength = 0;
            this.pxTextBox9.MinStrLength = 0;
            this.pxTextBox9.Name = "pxTextBox9";
            this.pxTextBox9.Precision = 0;
            this.pxTextBox9.ReadOnly = true;
            this.pxTextBox9.Regex = "";
            this.pxTextBox9.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox9.TabIndex = 142;
            this.pxTextBox9.ToolTipValid = null;
            this.pxTextBox9.VaildWarning = "";
            this.pxTextBox9.ValidEable = true;
            this.pxTextBox9.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox10
            // 
            this.pxTextBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "TundishNo", true));
            this.pxTextBox10.DisplayPrecision = 0;
            this.pxTextBox10.EnableNull = true;
            this.pxTextBox10.ErropPr = null;
            this.pxTextBox10.FixedLength = 0;
            this.pxTextBox10.Length = 0;
            this.pxTextBox10.Location = new System.Drawing.Point(470, 36);
            this.pxTextBox10.Max = 0D;
            this.pxTextBox10.MaxNull = 0D;
            this.pxTextBox10.MaxStringLength = 0;
            this.pxTextBox10.MaxStrLength = 0;
            this.pxTextBox10.Min = 0D;
            this.pxTextBox10.MinNull = 0D;
            this.pxTextBox10.MinStringLength = 0;
            this.pxTextBox10.MinStrLength = 0;
            this.pxTextBox10.Name = "pxTextBox10";
            this.pxTextBox10.Precision = 0;
            this.pxTextBox10.ReadOnly = true;
            this.pxTextBox10.Regex = "";
            this.pxTextBox10.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox10.TabIndex = 142;
            this.pxTextBox10.ToolTipValid = null;
            this.pxTextBox10.VaildWarning = "";
            this.pxTextBox10.ValidEable = true;
            this.pxTextBox10.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox11
            // 
            this.pxTextBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "CCMID", true));
            this.pxTextBox11.DisplayPrecision = 0;
            this.pxTextBox11.EnableNull = true;
            this.pxTextBox11.ErropPr = null;
            this.pxTextBox11.FixedLength = 0;
            this.pxTextBox11.Length = 0;
            this.pxTextBox11.Location = new System.Drawing.Point(192, 36);
            this.pxTextBox11.Max = 0D;
            this.pxTextBox11.MaxNull = 0D;
            this.pxTextBox11.MaxStringLength = 0;
            this.pxTextBox11.MaxStrLength = 0;
            this.pxTextBox11.Min = 0D;
            this.pxTextBox11.MinNull = 0D;
            this.pxTextBox11.MinStringLength = 0;
            this.pxTextBox11.MinStrLength = 0;
            this.pxTextBox11.Name = "pxTextBox11";
            this.pxTextBox11.Precision = 0;
            this.pxTextBox11.ReadOnly = true;
            this.pxTextBox11.Regex = "";
            this.pxTextBox11.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox11.TabIndex = 142;
            this.pxTextBox11.ToolTipValid = null;
            this.pxTextBox11.VaildWarning = "";
            this.pxTextBox11.ValidEable = true;
            this.pxTextBox11.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(393, 67);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(71, 12);
            this.label53.TabIndex = 141;
            this.label53.Text = "包次内炉数:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(115, 148);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(71, 12);
            this.label60.TabIndex = 141;
            this.label60.Text = "浇次内炉数:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(417, 40);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(47, 12);
            this.label61.TabIndex = 141;
            this.label61.Text = "包次号:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(139, 40);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(47, 12);
            this.label62.TabIndex = 141;
            this.label62.Text = "铸机号:";
            // 
            // pxTextBox12
            // 
            this.pxTextBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Tundish_Wall_Temp", true));
            this.pxTextBox12.DisplayPrecision = 0;
            this.pxTextBox12.EnableNull = true;
            this.pxTextBox12.ErropPr = null;
            this.pxTextBox12.FixedLength = 0;
            this.pxTextBox12.Length = 0;
            this.pxTextBox12.Location = new System.Drawing.Point(470, 196);
            this.pxTextBox12.Max = 0D;
            this.pxTextBox12.MaxNull = 0D;
            this.pxTextBox12.MaxStringLength = 0;
            this.pxTextBox12.MaxStrLength = 0;
            this.pxTextBox12.Min = 0D;
            this.pxTextBox12.MinNull = 0D;
            this.pxTextBox12.MinStringLength = 0;
            this.pxTextBox12.MinStrLength = 0;
            this.pxTextBox12.Name = "pxTextBox12";
            this.pxTextBox12.Precision = 0;
            this.pxTextBox12.Regex = "";
            this.pxTextBox12.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox12.TabIndex = 139;
            this.pxTextBox12.ToolTipValid = null;
            this.pxTextBox12.VaildWarning = "";
            this.pxTextBox12.ValidEable = true;
            this.pxTextBox12.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox13
            // 
            this.pxTextBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Weight_Cut_Trail", true));
            this.pxTextBox13.DisplayPrecision = 0;
            this.pxTextBox13.EnableNull = true;
            this.pxTextBox13.ErropPr = null;
            this.pxTextBox13.FixedLength = 0;
            this.pxTextBox13.Length = 0;
            this.pxTextBox13.Location = new System.Drawing.Point(60, 66);
            this.pxTextBox13.Max = 0D;
            this.pxTextBox13.MaxNull = 0D;
            this.pxTextBox13.MaxStringLength = 0;
            this.pxTextBox13.MaxStrLength = 0;
            this.pxTextBox13.Min = 0D;
            this.pxTextBox13.MinNull = 0D;
            this.pxTextBox13.MinStringLength = 0;
            this.pxTextBox13.MinStrLength = 0;
            this.pxTextBox13.Name = "pxTextBox13";
            this.pxTextBox13.Precision = 0;
            this.pxTextBox13.Regex = "";
            this.pxTextBox13.Size = new System.Drawing.Size(21, 21);
            this.pxTextBox13.TabIndex = 139;
            this.pxTextBox13.ToolTipValid = null;
            this.pxTextBox13.VaildWarning = "";
            this.pxTextBox13.ValidEable = true;
            this.pxTextBox13.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.pxTextBox13.Visible = false;
            // 
            // pxTextBox14
            // 
            this.pxTextBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Weight_Cut_Head", true));
            this.pxTextBox14.DisplayPrecision = 0;
            this.pxTextBox14.EnableNull = true;
            this.pxTextBox14.ErropPr = null;
            this.pxTextBox14.FixedLength = 0;
            this.pxTextBox14.Length = 0;
            this.pxTextBox14.Location = new System.Drawing.Point(60, 39);
            this.pxTextBox14.Max = 0D;
            this.pxTextBox14.MaxNull = 0D;
            this.pxTextBox14.MaxStringLength = 0;
            this.pxTextBox14.MaxStrLength = 0;
            this.pxTextBox14.Min = 0D;
            this.pxTextBox14.MinNull = 0D;
            this.pxTextBox14.MinStringLength = 0;
            this.pxTextBox14.MinStrLength = 0;
            this.pxTextBox14.Name = "pxTextBox14";
            this.pxTextBox14.Precision = 0;
            this.pxTextBox14.Regex = "";
            this.pxTextBox14.Size = new System.Drawing.Size(21, 21);
            this.pxTextBox14.TabIndex = 139;
            this.pxTextBox14.ToolTipValid = null;
            this.pxTextBox14.VaildWarning = "";
            this.pxTextBox14.ValidEable = true;
            this.pxTextBox14.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.pxTextBox14.Visible = false;
            // 
            // pxTextBox15
            // 
            this.pxTextBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Second_Cooling_CurveNo", true));
            this.pxTextBox15.DisplayPrecision = 0;
            this.pxTextBox15.EnableNull = true;
            this.pxTextBox15.ErropPr = null;
            this.pxTextBox15.FixedLength = 0;
            this.pxTextBox15.Length = 0;
            this.pxTextBox15.Location = new System.Drawing.Point(743, 90);
            this.pxTextBox15.Max = 0D;
            this.pxTextBox15.MaxNull = 0D;
            this.pxTextBox15.MaxStringLength = 0;
            this.pxTextBox15.MaxStrLength = 0;
            this.pxTextBox15.Min = 0D;
            this.pxTextBox15.MinNull = 0D;
            this.pxTextBox15.MinStringLength = 0;
            this.pxTextBox15.MinStrLength = 0;
            this.pxTextBox15.Name = "pxTextBox15";
            this.pxTextBox15.Precision = 0;
            this.pxTextBox15.ReadOnly = true;
            this.pxTextBox15.Regex = "";
            this.pxTextBox15.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox15.TabIndex = 139;
            this.pxTextBox15.ToolTipValid = null;
            this.pxTextBox15.VaildWarning = "";
            this.pxTextBox15.ValidEable = true;
            this.pxTextBox15.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox16
            // 
            this.pxTextBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Second_Cooling_Mode", true));
            this.pxTextBox16.DisplayPrecision = 0;
            this.pxTextBox16.EnableNull = true;
            this.pxTextBox16.ErropPr = null;
            this.pxTextBox16.FixedLength = 0;
            this.pxTextBox16.Length = 0;
            this.pxTextBox16.Location = new System.Drawing.Point(52, 6);
            this.pxTextBox16.Max = 0D;
            this.pxTextBox16.MaxNull = 0D;
            this.pxTextBox16.MaxStringLength = 0;
            this.pxTextBox16.MaxStrLength = 0;
            this.pxTextBox16.Min = 0D;
            this.pxTextBox16.MinNull = 0D;
            this.pxTextBox16.MinStringLength = 0;
            this.pxTextBox16.MinStrLength = 0;
            this.pxTextBox16.Name = "pxTextBox16";
            this.pxTextBox16.Precision = 0;
            this.pxTextBox16.Regex = "";
            this.pxTextBox16.Size = new System.Drawing.Size(29, 21);
            this.pxTextBox16.TabIndex = 139;
            this.pxTextBox16.ToolTipValid = null;
            this.pxTextBox16.VaildWarning = "";
            this.pxTextBox16.ValidEable = true;
            this.pxTextBox16.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.pxTextBox16.Visible = false;
            // 
            // pxTextBox18
            // 
            this.pxTextBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Weight_Return", true));
            this.pxTextBox18.DisplayPrecision = 0;
            this.pxTextBox18.EnableNull = true;
            this.pxTextBox18.ErropPr = null;
            this.pxTextBox18.FixedLength = 0;
            this.pxTextBox18.Length = 0;
            this.pxTextBox18.Location = new System.Drawing.Point(470, 116);
            this.pxTextBox18.Max = 0D;
            this.pxTextBox18.MaxNull = 0D;
            this.pxTextBox18.MaxStringLength = 0;
            this.pxTextBox18.MaxStrLength = 0;
            this.pxTextBox18.Min = 0D;
            this.pxTextBox18.MinNull = 0D;
            this.pxTextBox18.MinStringLength = 0;
            this.pxTextBox18.MinStrLength = 0;
            this.pxTextBox18.Name = "pxTextBox18";
            this.pxTextBox18.Precision = 0;
            this.pxTextBox18.Regex = "";
            this.pxTextBox18.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox18.TabIndex = 139;
            this.pxTextBox18.ToolTipValid = null;
            this.pxTextBox18.VaildWarning = "";
            this.pxTextBox18.ValidEable = true;
            this.pxTextBox18.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox19
            // 
            this.pxTextBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "InjectionBar_BlowAr", true));
            this.pxTextBox19.DisplayPrecision = 0;
            this.pxTextBox19.EnableNull = true;
            this.pxTextBox19.ErropPr = null;
            this.pxTextBox19.FixedLength = 0;
            this.pxTextBox19.Length = 0;
            this.pxTextBox19.Location = new System.Drawing.Point(22, 6);
            this.pxTextBox19.Max = 0D;
            this.pxTextBox19.MaxNull = 0D;
            this.pxTextBox19.MaxStringLength = 0;
            this.pxTextBox19.MaxStrLength = 0;
            this.pxTextBox19.Min = 0D;
            this.pxTextBox19.MinNull = 0D;
            this.pxTextBox19.MinStringLength = 0;
            this.pxTextBox19.MinStrLength = 0;
            this.pxTextBox19.Name = "pxTextBox19";
            this.pxTextBox19.Precision = 0;
            this.pxTextBox19.Regex = "";
            this.pxTextBox19.Size = new System.Drawing.Size(24, 21);
            this.pxTextBox19.TabIndex = 139;
            this.pxTextBox19.ToolTipValid = null;
            this.pxTextBox19.VaildWarning = "";
            this.pxTextBox19.ValidEable = true;
            this.pxTextBox19.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.pxTextBox19.Visible = false;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(403, 148);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(59, 12);
            this.label63.TabIndex = 140;
            this.label63.Text = "回炉原因:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(678, 40);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(59, 12);
            this.label64.TabIndex = 140;
            this.label64.Text = "中包车别:";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(7, 71);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(47, 12);
            this.label65.TabIndex = 140;
            this.label65.Text = "切尾量:";
            this.label65.Visible = false;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(7, 44);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(47, 12);
            this.label66.TabIndex = 140;
            this.label66.Text = "切头量:";
            this.label66.Visible = false;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(654, 94);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(83, 12);
            this.label67.TabIndex = 140;
            this.label67.Text = "二冷水水表号:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(666, 67);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(71, 12);
            this.label68.TabIndex = 140;
            this.label68.Text = "二冷水模式:";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(373, 121);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(89, 12);
            this.label69.TabIndex = 140;
            this.label69.Text = "回炉钢水量[t]:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(381, 94);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(83, 12);
            this.label70.TabIndex = 140;
            this.label70.Text = "是否塞棒吹氩:";
            // 
            // pxTextBox21
            // 
            this.pxTextBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "CastingNo", true));
            this.pxTextBox21.DisplayPrecision = 0;
            this.pxTextBox21.EnableNull = true;
            this.pxTextBox21.ErropPr = null;
            this.pxTextBox21.FixedLength = 0;
            this.pxTextBox21.Length = 0;
            this.pxTextBox21.Location = new System.Drawing.Point(192, 117);
            this.pxTextBox21.Max = 0D;
            this.pxTextBox21.MaxNull = 0D;
            this.pxTextBox21.MaxStringLength = 0;
            this.pxTextBox21.MaxStrLength = 0;
            this.pxTextBox21.Min = 0D;
            this.pxTextBox21.MinNull = 0D;
            this.pxTextBox21.MinStringLength = 0;
            this.pxTextBox21.MinStrLength = 0;
            this.pxTextBox21.Name = "pxTextBox21";
            this.pxTextBox21.Precision = 0;
            this.pxTextBox21.ReadOnly = true;
            this.pxTextBox21.Regex = "";
            this.pxTextBox21.Size = new System.Drawing.Size(144, 21);
            this.pxTextBox21.TabIndex = 139;
            this.pxTextBox21.ToolTipValid = null;
            this.pxTextBox21.VaildWarning = "";
            this.pxTextBox21.ValidEable = true;
            this.pxTextBox21.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(139, 121);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(47, 12);
            this.label71.TabIndex = 140;
            this.label71.Text = "浇次号:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 331);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(965, 34);
            this.flowLayoutPanel1.TabIndex = 89;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(883, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 87;
            this.button5.Text = "取消";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // coldsProcessL3DataTableSoft_Press_Change
            // 
            this.coldsProcessL3DataTableSoft_Press_Change.Caption = "Soft_Press_Change";
            this.coldsProcessL3DataTableSoft_Press_Change.ColumnName = "Soft_Press_Change";
            this.coldsProcessL3DataTableSoft_Press_Change.Namespace = "";
            // 
            // coldsProcessL3DataTableSoft_Press_Detailed
            // 
            this.coldsProcessL3DataTableSoft_Press_Detailed.Caption = "Soft_Press_Detailed";
            this.coldsProcessL3DataTableSoft_Press_Detailed.ColumnName = "Soft_Press_Detailed";
            this.coldsProcessL3DataTableSoft_Press_Detailed.Namespace = "";
            // 
            // coldsProcessL3DataTableSoft_Press_Reason
            // 
            this.coldsProcessL3DataTableSoft_Press_Reason.Caption = "Soft_Press_Reason";
            this.coldsProcessL3DataTableSoft_Press_Reason.ColumnName = "Soft_Press_Reason";
            this.coldsProcessL3DataTableSoft_Press_Reason.Namespace = "";
            // 
            // coldsLadleUseL3DataTableGUID
            // 
            this.coldsLadleUseL3DataTableGUID.Caption = "GUID";
            this.coldsLadleUseL3DataTableGUID.ColumnName = "GUID";
            this.coldsLadleUseL3DataTableGUID.Namespace = "";
            // 
            // coldsLadleUseL3DataTableHeatID
            // 
            this.coldsLadleUseL3DataTableHeatID.Caption = "HeatID";
            this.coldsLadleUseL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsLadleUseL3DataTableHeatID.Namespace = "";
            // 
            // dsLadleUse
            // 
            this.dsLadleUse.AutoLoad = true;
            this.dsLadleUse.AutoSubscribe = false;
            this.dsLadleUse.DataSetName = "L3DataSet";
            this.dsLadleUse.DeleteMethod = null;
            this.dsLadleUse.InsertMethod = null;
            this.dsLadleUse.L3DataAdapter = this.Adapter;
            this.dsLadleUse.LoadEvent = "";
            this.dsLadleUse.LoadTrigger = null;
            this.dsLadleUse.RefreshValve = 1000;
            this.dsLadleUse.SourceCommand = null;
            this.dsLadleUse.SourceCondition = "";
            this.dsLadleUse.SourceMethod = "";
            this.dsLadleUse.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsLadleUse.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Use";
            this.dsLadleUse.SubscribeTarget = null;
            this.dsLadleUse.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleUse});
            this.dsLadleUse.UpdateEvent = "";
            this.dsLadleUse.UpdateMethod = null;
            this.dsLadleUse.UpdateTrigger = null;
            // 
            // schemadsLadleUse
            // 
            this.schemadsLadleUse.Columns.AddRange(new System.Data.DataColumn[] {
            this.AcoldsLadleUseL3DataTableGUID,
            this.AcoldsLadleUseL3DataTableHeatID,
            this.coldsLadleUseL3DataTableAuto_Flow});
            this.schemadsLadleUse.TableName = "L3DataTable";
            // 
            // AcoldsLadleUseL3DataTableGUID
            // 
            this.AcoldsLadleUseL3DataTableGUID.Caption = "GUID";
            this.AcoldsLadleUseL3DataTableGUID.ColumnName = "GUID";
            this.AcoldsLadleUseL3DataTableGUID.Namespace = "";
            // 
            // AcoldsLadleUseL3DataTableHeatID
            // 
            this.AcoldsLadleUseL3DataTableHeatID.Caption = "HeatID";
            this.AcoldsLadleUseL3DataTableHeatID.ColumnName = "HeatID";
            this.AcoldsLadleUseL3DataTableHeatID.Namespace = "";
            // 
            // coldsLadleUseL3DataTableAuto_Flow
            // 
            this.coldsLadleUseL3DataTableAuto_Flow.Caption = "Auto_Flow";
            this.coldsLadleUseL3DataTableAuto_Flow.ColumnName = "Auto_Flow";
            this.coldsLadleUseL3DataTableAuto_Flow.DataType = typeof(int);
            this.coldsLadleUseL3DataTableAuto_Flow.Namespace = "";
            // 
            // l3DataSet1
            // 
            this.l3DataSet1.AutoLoad = true;
            this.l3DataSet1.AutoSubscribe = false;
            this.l3DataSet1.DataSetName = "L3DataSet";
            this.l3DataSet1.DeleteMethod = null;
            this.l3DataSet1.InsertMethod = null;
            this.l3DataSet1.L3DataAdapter = this.Adapter;
            this.l3DataSet1.LoadEvent = "";
            this.l3DataSet1.LoadTrigger = null;
            this.l3DataSet1.RefreshValve = 1000;
            this.l3DataSet1.SourceCommand = null;
            this.l3DataSet1.SourceCondition = "";
            this.l3DataSet1.SourceMethod = "";
            this.l3DataSet1.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.l3DataSet1.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Use";
            this.l3DataSet1.SubscribeTarget = null;
            this.l3DataSet1.UpdateEvent = "";
            this.l3DataSet1.UpdateMethod = null;
            this.l3DataSet1.UpdateTrigger = null;
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.BackColor = System.Drawing.Color.Coral;
            this.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.Size = new System.Drawing.Size(120, 22);
            this.toolStripButton21.Text = "从历史库中调取数据";
            this.toolStripButton21.Click += new System.EventHandler(this.toolStripButton21_Click);
            // 
            // CCMHeatInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 487);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.panl);
            this.MaximizeBox = false;
            this.Name = "CCMHeatInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "连铸炉次数据";
            this.Load += new System.EventHandler(this.CCMHeatInfoFrm_Load);
            this.panl.ResumeLayout(false);
            this.panl.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishOfficer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAssistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsControlOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeadFurnace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdExcept)).EndInit();
            this.bdExcept.ResumeLayout(false);
            this.bdExcept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSecondCoolingMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSecondCoolingMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReturn_Reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReturn_Reason)).EndInit();
            this.pnlProcess.ResumeLayout(false);
            this.tabExcept.ResumeLayout(false);
            this.tabExcept.PerformLayout();
            this.fLPExcept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).EndInit();
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
            this.pnlChemical.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCasterStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCasterStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).EndInit();
            this.bnStatus.ResumeLayout(false);
            this.bnStatus.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.tabHeatTundishTemp.ResumeLayout(false);
            this.hmiRootPanel6.ResumeLayout(false);
            this.hmiRootPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHeatTundishTemp)).EndInit();
            this.bnHeatTundishTemp.ResumeLayout(false);
            this.bnHeatTundishTemp.PerformLayout();
            this.tabHeatCover.ResumeLayout(false);
            this.tabHeatCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHeatCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCoverElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCoverElement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatCoverUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatCoverUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHeatCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHeatCover)).EndInit();
            this.bnHeatCover.ResumeLayout(false);
            this.bnHeatCover.PerformLayout();
            this.pnlHeatCover.ResumeLayout(false);
            this.tabLadle.ResumeLayout(false);
            this.tabLadle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCommonYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCommonYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTimeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTimeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnAutoFlow_Reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnAutoFlow_Reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnProtectionReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnProtectionReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnLadle)).EndInit();
            this.bnLadle.ResumeLayout(false);
            this.bnLadle.PerformLayout();
            this.pnlLadle.ResumeLayout(false);
            this.tabProtectCasting.ResumeLayout(false);
            this.tabProtectCasting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProtectCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtectCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectCasting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnProtectCasting)).EndInit();
            this.bnProtectCasting.ResumeLayout(false);
            this.bnProtectCasting.PerformLayout();
            this.pnlProtectCasting.ResumeLayout(false);
            this.tabProtectMat.ResumeLayout(false);
            this.tabProtectMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProtectMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtectMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnProtectMat)).EndInit();
            this.bnProtectMat.ResumeLayout(false);
            this.bnProtectMat.PerformLayout();
            this.pnlProtectMat.ResumeLayout(false);
            this.tabProtectSlag.ResumeLayout(false);
            this.tabProtectSlag.PerformLayout();
            this.hmiRootPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvProtectSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlagFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlagFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlagType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlagType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlagUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlagUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtectSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProtectSlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProtectSlag)).EndInit();
            this.pnlProtectSlag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnProtectSlag)).EndInit();
            this.bnProtectSlag.ResumeLayout(false);
            this.bnProtectSlag.PerformLayout();
            this.tabHoldTempMat.ResumeLayout(false);
            this.tabHoldTempMat.PerformLayout();
            this.pnlHoldTempMat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvHoldTempMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMatUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMatUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHoldTempMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHoldTempMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHoldTempMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnHoldTempMat)).EndInit();
            this.bnHoldTempMat.ResumeLayout(false);
            this.bnHoldTempMat.PerformLayout();
            this.tabSpeed.ResumeLayout(false);
            this.tabSpeed.PerformLayout();
            this.hmiRootPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSpeed)).EndInit();
            this.pnlSpeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnSpeed)).EndInit();
            this.bnSpeed.ResumeLayout(false);
            this.bnSpeed.PerformLayout();
            this.tabStrandInfo.ResumeLayout(false);
            this.tabStrandInfo.PerformLayout();
            this.hmiRootPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvStrandInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoContorl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoContorl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlock_Up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlock_Up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlock_Up_Reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlock_Up_Reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopper_Fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopper_Fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStrandInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStrandInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStrandInfo)).EndInit();
            this.pnlStrandInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnStrandInfo)).EndInit();
            this.bnStrandInfo.ResumeLayout(false);
            this.bnStrandInfo.PerformLayout();
            this.tabRemark.ResumeLayout(false);
            this.tabRemark.PerformLayout();
            this.hmiRootPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).EndInit();
            this.pnlRemark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).EndInit();
            this.bnRemark.ResumeLayout(false);
            this.bnRemark.PerformLayout();
            this.tabRef.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSmoothBlock.ResumeLayout(false);
            this.hmiRootPanel10.ResumeLayout(false);
            this.hmiRootPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHurryS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlockFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlockFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlockOFFReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlockOFFReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmoothBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlock)).EndInit();
            this.fLPSmoothBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabHurryGap.ResumeLayout(false);
            this.hmiRootPanel8.ResumeLayout(false);
            this.hmiRootPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvHurryGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGapFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGapFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGapOFFReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGapOFFReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHurryGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGrap)).EndInit();
            this.pnlHurryGap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            this.tabBigGap.ResumeLayout(false);
            this.hmiRootPanel9.ResumeLayout(false);
            this.hmiRootPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBigGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGapOFFReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGapOFFReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGap)).EndInit();
            this.pnlBigGap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTempUpTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProtection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsliquid_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsliquid_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCuFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCuFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInjectionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInjectionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWaterGapCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWaterGapCenter)).EndInit();
            this.hmiRootPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSmoothBlock)).EndInit();
            this.pnlSmoothBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsReason)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panl;
        private PxDataValid.PxTextBox tbxTreatNo;
        private System.Windows.Forms.Label label8;
        private PxDataValid.PxTextBox tbxHeatID;
        private System.Windows.Forms.Label label6;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label10;
        private PxDataValid.PxTextBox tbxSecondHand;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxTextBox tbxCCMID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlBase;
        private System.Windows.Forms.Button btnBaseCancel;
        private System.Windows.Forms.Button btnBaseOK;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.FlowLayoutPanel pnlProcess;
        private System.Windows.Forms.Button btnProcessCancel;
        private System.Windows.Forms.Button btnPaocessOK;
        private System.Windows.Forms.TabPage tabChemical;
        private System.Windows.Forms.DataGridView dvChemical;
        private System.Windows.Forms.BindingNavigator bnChemical;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton toolStripButton29;
        private System.Windows.Forms.ToolStripButton toolStripButton30;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripButton btnAddChemical;
        private System.Windows.Forms.FlowLayoutPanel pnlChemical;
        private System.Windows.Forms.Button btnChemicalCancel;
        private System.Windows.Forms.Button btnChemicalOK;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.BindingNavigator bnStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton btnAddStatus;
        private System.Windows.Forms.FlowLayoutPanel pnlStatus;
        private System.Windows.Forms.Button btnStatusCancel;
        private System.Windows.Forms.Button btnStatusOK;
        private System.Windows.Forms.TabPage tabHeatTundishTemp;
        private HMIBase.HMIRootPanel hmiRootPanel6;
        private System.Windows.Forms.DataGridView dvHeatTundishTemp;
        private System.Windows.Forms.BindingNavigator bnHeatTundishTemp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton btnAddHeatTundishTemp;
        private System.Windows.Forms.TabPage tabHeatCover;
        private System.Windows.Forms.DataGridView dvHeatCover;
        private System.Windows.Forms.BindingNavigator bnHeatCover;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnAddHeatCover;
        private System.Windows.Forms.FlowLayoutPanel pnlHeatCover;
        private System.Windows.Forms.Button btnCoverCancel;
        private System.Windows.Forms.TabPage tabLadle;
        private System.Windows.Forms.FlowLayoutPanel pnlLadle;
        private System.Windows.Forms.Button btnLadleCancel;
        private System.Windows.Forms.Button btnLadleOK;
        private AppSvrHMI.L3DataSet dsBase;
        private PxDataValid.PxTextBox pxTextBox24;
        private PxDataValid.PxTextBox pxTextBox23;
        private PxDataValid.PxTextBox pxTextBox22;
        private PxDataValid.PxTextBox pxTextBox20;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableHeatID;
        private System.Data.DataColumn coldsBaseL3DataTableCastingNo;
        private System.Data.DataColumn coldsBaseL3DataTableCCMID;
        private System.Data.DataColumn coldsBaseL3DataTableTreatNo;
        private System.Data.DataColumn coldsBaseL3DataTableHeatConfirm;
        private System.Data.DataColumn coldsBaseL3DataTableProductionDate;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGrade;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTablePlan_SteelGrade;
        private System.Data.DataColumn coldsBaseL3DataTableHeadFurnace;
        private System.Data.DataColumn coldsBaseL3DataTableLadle_Operator;
        private System.Data.DataColumn coldsBaseL3DataTableCut_Operator;
        private System.Data.DataColumn coldsBaseL3DataTableLocked;
        private System.Data.DataColumn coldsBaseL3DataTableShift;
        private System.Data.DataColumn coldsBaseL3DataTableTeam;
        private System.Windows.Forms.TabPage tabProtectCasting;
        private System.Windows.Forms.TabPage tabProtectMat;
        private System.Windows.Forms.TabPage tabProtectSlag;
        private System.Windows.Forms.TabPage tabSpeed;
        private System.Windows.Forms.TabPage tabStrandInfo;
        private System.Windows.Forms.BindingNavigator bnProtectSlag;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAddProtectSlag;
        private System.Windows.Forms.BindingNavigator bnSpeed;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAddSpeed;
        private System.Windows.Forms.BindingNavigator bnStrandInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton toolStripButton31;
        private System.Windows.Forms.ToolStripButton toolStripButton32;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton toolStripButton33;
        private System.Windows.Forms.ToolStripButton toolStripButton34;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripButton btnAddStrandInfo;
        private System.Windows.Forms.TabPage tabRemark;
        private System.Windows.Forms.BindingNavigator bnRemark;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripButton toolStripButton36;
        private System.Windows.Forms.ToolStripButton toolStripButton37;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripButton toolStripButton38;
        private System.Windows.Forms.ToolStripButton toolStripButton39;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripButton btnAddRemark;
        private AppSvrHMI.L3DataSet dsProcess;
        private System.Data.DataTable schemadsProcess;
        private System.Data.DataColumn coldsProcessL3DataTableGUID;
        private System.Data.DataColumn coldsProcessL3DataTableName;
        private System.Data.DataColumn coldsProcessL3DataTableHeatID;
        private System.Data.DataColumn coldsProcessL3DataTableCastingNo;
        private System.Data.DataColumn coldsProcessL3DataTableCCMID;
        private System.Data.DataColumn coldsProcessL3DataTableTundishNo;
        private System.Data.DataColumn coldsProcessL3DataTableTreatNo;
        private System.Data.DataColumn coldsProcessL3DataTableCasting_HeatNum;
        private System.Data.DataColumn coldsProcessL3DataTableTundish_HeatNum;
        private System.Data.DataColumn coldsProcessL3DataTableInjectionBar_BlowAr;
        private System.Data.DataColumn coldsProcessL3DataTableWeight_Return;
        private System.Data.DataColumn coldsProcessL3DataTableSecond_Cooling_Mode;
        private System.Data.DataColumn coldsProcessL3DataTableSecond_Cooling_CurveNo;
        private System.Data.DataColumn coldsProcessL3DataTableWeight_Cut_Head;
        private System.Data.DataColumn coldsProcessL3DataTableWeight_Cut_Trail;
        private System.Windows.Forms.BindingSource bsProcess;
        private PxDataValid.PxTextBox txtCastingNo;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxTextBox pxTextBox4;
        private PxDataValid.PxTextBox pxTextBox3;
        private PxDataValid.PxTextBox txtTundishNo;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private PxDataValid.PxTextBox pxTextBox36;
        private PxDataValid.PxTextBox pxTextBox34;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label43;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsChemical;
        private System.Windows.Forms.BindingSource bsChemical;
        private System.Data.DataTable schemadsChemical;
        private System.Data.DataColumn coldsChemicalL3DataTableGUID;
        private System.Data.DataColumn coldsChemicalL3DataTableName;
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
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableGUID;
        private System.Data.DataColumn coldsStatusL3DataTableName;
        private System.Data.DataColumn coldsStatusL3DataTableCCMID;
        private System.Data.DataColumn coldsStatusL3DataTableTreatNo;
        private System.Data.DataColumn coldsStatusL3DataTableHeatID;
        private System.Data.DataColumn coldsStatusL3DataTableStatus;
        private System.Data.DataColumn coldsStatusL3DataTableChange_Time;
        private System.Windows.Forms.BindingSource bsHeatTundishTemp;
        private AppSvrHMI.L3DataSet dsHeatTundishTemp;
        private System.Data.DataTable schemadsHeatTundishTemp;
        private System.Data.DataColumn coldsHeatTundishTempL3DataTableGUID;
        private System.Data.DataColumn coldsHeatTundishTempL3DataTableName;
        private System.Data.DataColumn coldsHeatTundishTempL3DataTableHeatID;
        private System.Data.DataColumn coldsHeatTundishTempL3DataTableCCMID;
        private System.Data.DataColumn coldsHeatTundishTempL3DataTableTempID;
        private System.Data.DataColumn coldsHeatTundishTempL3DataTableTemp;
        private System.Data.DataColumn coldsHeatTundishTempL3DataTableMeasure_Time;
        private AppSvrHMI.L3DataSet dsHeatCover;
        private System.Windows.Forms.BindingSource bsHeatCover;
        private System.Data.DataTable schemadsHeatCover;
        private System.Data.DataColumn coldsHeatCoverL3DataTableGUID;
        private System.Data.DataColumn coldsHeatCoverL3DataTableName;
        private System.Data.DataColumn coldsHeatCoverL3DataTableHeatID;
        private System.Data.DataColumn coldsHeatCoverL3DataTableCCMID;
        private System.Data.DataColumn coldsHeatCoverL3DataTableElement;
        private System.Data.DataColumn coldsHeatCoverL3DataTableAmount;
        private System.Data.DataColumn coldsHeatCoverL3DataTableOrigin;
        private AppSvrHMI.L3DataSet dsLadle;
        private System.Data.DataTable schemadsLadle;
        private System.Data.DataColumn coldsLadleL3DataTableGUID;
        private System.Data.DataColumn coldsLadleL3DataTableName;
        private System.Data.DataColumn coldsLadleL3DataTableHeatID;
        private System.Data.DataColumn coldsLadleL3DataTableTreatNo;
        private System.Data.DataColumn coldsLadleL3DataTableCCMID;
        private System.Data.DataColumn coldsLadleL3DataTableLadleID;
        private System.Data.DataColumn coldsLadleL3DataTableWeight;
        private System.Data.DataColumn coldsLadleL3DataTableRemainWeight;
        private System.Data.DataColumn coldsLadleL3DataTableArrival_Time;
        private System.Data.DataColumn coldsLadleL3DataTableLadleType;
        private System.Data.DataColumn coldsLadleL3DataTableDeparture_Time;
        private System.Data.DataColumn coldsLadleL3DataTableCasting_Start_Time;
        private System.Data.DataColumn coldsLadleL3DataTableCasting_Stop_Time;
        private System.Data.DataColumn coldsLadleL3DataTableHoldTime;
        private System.Data.DataColumn coldsLadleL3DataTableTemp;
        private System.Data.DataColumn coldsLadleL3DataTableTempUpTo;
        private System.Data.DataColumn coldsLadleL3DataTableHoldTime_Reason;
        private System.Data.DataColumn coldsLadleL3DataTableProtection;
        private System.Data.DataColumn coldsLadleL3DataTableUnProtection_Reason;
        private System.Windows.Forms.BindingSource bsLadle;
        private System.Windows.Forms.FlowLayoutPanel pnlProtectCasting;
        private System.Windows.Forms.Button btnProtectCastingCancel;
        private System.Windows.Forms.Button btnProtectCastingOK;
        private System.Windows.Forms.FlowLayoutPanel pnlProtectMat;
        private System.Windows.Forms.Button btnProtectMatCancel;
        private System.Windows.Forms.Button btnProtectMatOK;
        private System.Windows.Forms.FlowLayoutPanel pnlProtectSlag;
        private System.Windows.Forms.Button btnProtectSlagCancel;
        private System.Windows.Forms.Button btnProtectSlagOK;
        private System.Windows.Forms.FlowLayoutPanel pnlSpeed;
        private System.Windows.Forms.Button btnSpeedCancel;
        private System.Windows.Forms.Button btnSpeedOk;
        private System.Windows.Forms.FlowLayoutPanel pnlStrandInfo;
        private System.Windows.Forms.Button btnStrandInfoCancel;
        private System.Windows.Forms.Button btnStrandInfoOK;
        private System.Windows.Forms.FlowLayoutPanel pnlRemark;
        private System.Windows.Forms.Button btnRemarkCancel;
        private System.Windows.Forms.Button btnRemarkOK;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private AppSvrHMI.L3DataSet dsProtectCasting;
        private System.Data.DataTable schemadsProtectCasting;
        private System.Data.DataColumn coldsProtectCastingL3DataTableGUID;
        private System.Data.DataColumn coldsProtectCastingL3DataTableName;
        private System.Data.DataColumn coldsProtectCastingL3DataTableHeatID;
        private System.Data.DataColumn coldsProtectCastingL3DataTableCCMID;
        private System.Data.DataColumn coldsProtectCastingL3DataTableStart_Time;
        private System.Data.DataColumn coldsProtectCastingL3DataTableStop_Time;
        private System.Data.DataColumn coldsProtectCastingL3DataTableAr_Flow;
        private System.Windows.Forms.BindingSource bsProtectCasting;
        private AppSvrHMI.L3DataSet dsProtectMat;
        private System.Windows.Forms.BindingSource bsProtectMat;
        private System.Data.DataTable schemadsProtectMat;
        private System.Data.DataColumn coldsProtectMatL3DataTableGUID;
        private System.Data.DataColumn coldsProtectMatL3DataTableName;
        private System.Data.DataColumn coldsProtectMatL3DataTableHeatID;
        private System.Data.DataColumn coldsProtectMatL3DataTableCCMID;
        private System.Data.DataColumn coldsProtectMatL3DataTableElement;
        private System.Data.DataColumn coldsProtectMatL3DataTableFactory;
        private AppSvrHMI.L3DataSet dsProtectSlag;
        private System.Windows.Forms.BindingSource bsProtectSlag;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.DataGridView dvProtectSlag;
        private System.Data.DataTable schemadsProtectSlag;
        private System.Data.DataColumn coldsProtectSlagL3DataTableGUID;
        private System.Data.DataColumn coldsProtectSlagL3DataTableName;
        private System.Data.DataColumn coldsProtectSlagL3DataTableHeatID;
        private System.Data.DataColumn coldsProtectSlagL3DataTableCCMID;
        private System.Data.DataColumn coldsProtectSlagL3DataTableStrandID;
        private System.Data.DataColumn coldsProtectSlagL3DataTableElement;
        private System.Data.DataColumn coldsProtectSlagL3DataTableFactory;
        private System.Data.DataColumn coldsProtectSlagL3DataTableBatchNo;
        private HMIBase.HMIRootPanel hmiRootPanel3;
        private System.Windows.Forms.DataGridView dvSpeed;
        private AppSvrHMI.L3DataSet dsSpeed;
        private System.Windows.Forms.BindingSource bsSpeed;
        private System.Data.DataTable schemadsSpeed;
        private System.Data.DataColumn coldsSpeedL3DataTableGUID;
        private System.Data.DataColumn coldsSpeedL3DataTableName;
        private System.Data.DataColumn coldsSpeedL3DataTableHeatID;
        private System.Data.DataColumn coldsSpeedL3DataTableCCMID;
        private System.Data.DataColumn coldsSpeedL3DataTableStrandID;
        private System.Data.DataColumn coldsSpeedL3DataTableSpeed;
        private System.Data.DataColumn coldsSpeedL3DataTableChange_Time;
        private HMIBase.HMIRootPanel hmiRootPanel4;
        private System.Windows.Forms.DataGridView dvStrandInfo;
        private System.Windows.Forms.BindingSource bsStrandInfo;
        private AppSvrHMI.L3DataSet dsStrandInfo;
        private System.Data.DataTable schemadsStrandInfo;
        private System.Data.DataColumn coldsStrandInfoL3DataTableGUID;
        private System.Data.DataColumn coldsStrandInfoL3DataTableName;
        private System.Data.DataColumn coldsStrandInfoL3DataTableHeatID;
        private System.Data.DataColumn coldsStrandInfoL3DataTableCCMID;
        private System.Data.DataColumn coldsStrandInfoL3DataTableStrandID;
        private System.Data.DataColumn coldsStrandInfoL3DataTableSoft_Press_Flag;
        private System.Data.DataColumn coldsStrandInfoL3DataTableAuto_Control;
        private System.Data.DataColumn coldsStrandInfoL3DataTableStart_Time;
        private System.Data.DataColumn coldsStrandInfoL3DataTableStop_Time;
        private System.Data.DataColumn coldsStrandInfoL3DataTableCast_Num;
        private System.Data.DataColumn coldsStrandInfoL3DataTableWaterGap_Center;
        private System.Data.DataColumn coldsStrandInfoL3DataTableWaterGap_Deepness;
        private HMIBase.HMIRootPanel hmiRootPanel5;
        private System.Windows.Forms.DataGridView dvRemark;
        private System.Windows.Forms.BindingSource bsRemark;
        private AppSvrHMI.L3DataSet dsRemark;
        private System.Data.DataTable schemadsRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableGUID;
        private System.Data.DataColumn coldsRemarkL3DataTableName;
        private System.Data.DataColumn coldsRemarkL3DataTableHeatID;
        private System.Data.DataColumn coldsRemarkL3DataTableTreatNo;
        private System.Data.DataColumn coldsRemarkL3DataTableTypeID;
        private System.Data.DataColumn coldsRemarkL3DataTableRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableLog_Time;
        private System.Windows.Forms.DataGridView dvStatus;
        private System.Windows.Forms.DataGridView dvLadle;
        private System.Windows.Forms.BindingNavigator bnLadle;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddLadle;
        private System.Windows.Forms.DataGridView dvProtectCasting;
        private System.Windows.Forms.BindingNavigator bnProtectCasting;
        private System.Windows.Forms.ToolStripButton btnAddProtectCasting;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.DataGridView dvProtectMat;
        private System.Windows.Forms.BindingNavigator bnProtectMat;
        private System.Windows.Forms.ToolStripButton btnAddProtectMat;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.TabPage tabHoldTempMat;
        private System.Windows.Forms.DataGridView dvHoldTempMat;
        private System.Windows.Forms.BindingNavigator bnHoldTempMat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator26;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator27;
        private System.Windows.Forms.ToolStripButton btnAddHoldTempMat;
        private System.Windows.Forms.FlowLayoutPanel pnlHoldTempMat;
        private System.Windows.Forms.Button btnHoldTempMatCancel;
        private System.Windows.Forms.Button btnHoldTempMatConfirm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private AppSvrHMI.L3DataSet dsUnitType;
        private System.Data.DataTable schemadsUnitType;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsDataLogMode;
        private System.Data.DataTable schemadsDataLogMode;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsDataLogModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsOrigin;
        private System.Data.DataTable schemadsOrigin;
        private System.Data.DataColumn coldsOriginL3DataTableMatFactory;
        private System.Data.DataColumn coldsOriginL3DataTableMatName;
        private System.Data.DataColumn coldsOriginL3DataTableMatGroup_Code;
        private System.Data.DataColumn coldsOriginL3DataTableMatGroup_Des;
        private AppSvrHMI.L3DataSet dsProtectSlagFac;
        private AppSvrHMI.L3DataSet dsCuFactory;
        private System.Data.DataTable schemadsProtectSlagFac;
        private System.Data.DataColumn coldsProtectSlagFacL3DataTableMatFactory;
        private System.Data.DataColumn coldsProtectSlagFacL3DataTableMatName;
        private System.Data.DataColumn coldsProtectSlagFacL3DataTableMatGroup_Code;
        private System.Data.DataColumn coldsProtectSlagFacL3DataTableMatGroup_Des;
        private System.Data.DataTable schemadsCuFactory;
        private System.Data.DataColumn coldsCuFactoryL3DataTableMatFactory;
        private System.Data.DataColumn coldsCuFactoryL3DataTableMatName;
        private System.Data.DataColumn coldsCuFactoryL3DataTableMatGroup_Code;
        private System.Data.DataColumn coldsCuFactoryL3DataTableMatGroup_Des;
        private AppSvrHMI.L3DataSet dsCasterStatus;
        private System.Data.DataTable schemadsCasterStatus;
        private System.Data.DataColumn coldsCasterStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsCasterStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsRemarkType;
        private System.Data.DataTable schemadsRemarkType;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsInjectionBar;
        private System.Data.DataTable schemadsInjectionBar;
        private System.Data.DataColumn coldsInjectionBarL3DataTableCode;
        private System.Data.DataColumn coldsInjectionBarL3DataTableCode_Des;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCrCu;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNiCu;
        private System.Data.DataColumn coldsChemicalL3DataTableOther3;
        private AppSvrHMI.L3DataSet dsCommonYesNo;
        private System.Data.DataTable schemadsCommonYesNo;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode_Des;
        private System.Data.DataColumn coldsCommonYesNoL3DataTableCode_Val_Long;
        private System.Windows.Forms.BindingSource bsTempUpTo;
        private System.Windows.Forms.BindingSource bsProtection;
        private AppSvrHMI.L3DataSet dsHoldTimeReason;
        private System.Data.DataTable schemadsHoldTimeReason;
        private System.Data.DataColumn coldsHoldTimeReasonL3DataTableCode;
        private System.Data.DataColumn coldsHoldTimeReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsUnProtectionReason;
        private System.Data.DataTable schemadsUnProtectionReason;
        private System.Data.DataColumn coldsUnProtectionReasonL3DataTableCode;
        private System.Data.DataColumn coldsUnProtectionReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSmoothBlock;
        private System.Data.DataTable schemadsSmoothBlock;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableGUID;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableName;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableCCMID;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableStrandNo;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableBlockID;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableBlock_Life;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableFactory;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableStart_Time;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableEnd_Time;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableBlock_Size;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableReason;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableHeatID;
        private System.Windows.Forms.BindingSource bsSmoothBlock;
        private System.Windows.Forms.BindingSource bsHurryGap;
        private AppSvrHMI.L3DataSet dsHurryGrap;
        private System.Data.DataTable schemadsHurryGrap;
        private System.Data.DataColumn coldsHurryGrapL3DataTableGUID;
        private System.Data.DataColumn coldsHurryGrapL3DataTableName;
        private System.Data.DataColumn coldsHurryGrapL3DataTableCCMID;
        private System.Data.DataColumn coldsHurryGrapL3DataTableStrandNo;
        private System.Data.DataColumn coldsHurryGrapL3DataTableGapID;
        private System.Data.DataColumn coldsHurryGrapL3DataTableGapLife;
        private System.Data.DataColumn coldsHurryGrapL3DataTableFactory;
        private System.Data.DataColumn coldsHurryGrapL3DataTableStart_Time;
        private System.Data.DataColumn coldsHurryGrapL3DataTableEnd_Time;
        private System.Data.DataColumn coldsHurryGrapL3DataTableReason;
        private System.Data.DataColumn coldsHurryGrapL3DataTableHeatID;
        private System.Windows.Forms.BindingSource bsBigGap;
        private AppSvrHMI.L3DataSet dsBigGap;
        private System.Data.DataTable schemadsBigGap;
        private System.Data.DataColumn coldsBigGapL3DataTableGUID;
        private System.Data.DataColumn coldsBigGapL3DataTableName;
        private System.Data.DataColumn coldsBigGapL3DataTableCCMID;
        private System.Data.DataColumn coldsBigGapL3DataTableStrandNo;
        private System.Data.DataColumn coldsBigGapL3DataTableGapID;
        private System.Data.DataColumn coldsBigGapL3DataTableFactory;
        private System.Data.DataColumn coldsBigGapL3DataTableMatType;
        private System.Data.DataColumn coldsBigGapL3DataTableGapLife;
        private System.Data.DataColumn coldsBigGapL3DataTableChangeTime;
        private System.Data.DataColumn coldsBigGapL3DataTableHeatID;
        private System.Data.DataColumn coldsBigGapL3DataTableReason;
        private AppSvrHMI.L3DataSet dsSmoothBlockOFFReason;
        private System.Data.DataTable schemadsSmoothBlockOFFReason;
        private System.Data.DataColumn coldsSmoothBlockOFFReasonL3DataTableCode;
        private System.Data.DataColumn coldsSmoothBlockOFFReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsHurryGapOFFReason;
        private System.Data.DataTable schemadsHurryGapOFFReason;
        private System.Data.DataColumn coldsHurryGapOFFReasonL3DataTableCode;
        private System.Data.DataColumn coldsHurryGapOFFReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBigGapOFFReason;
        private System.Data.DataTable schemadsBigGapOFFReason;
        private System.Data.DataColumn coldsBigGapOFFReasonL3DataTableCode;
        private System.Data.DataColumn coldsBigGapOFFReasonL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBigGapFactory;
        private System.Data.DataTable schemadsBigGapFactory;
        private System.Data.DataColumn coldsBigGapFactoryL3DataTableMatFactory;
        private AppSvrHMI.L3DataSet dsSmoothBlockFactory;
        private System.Data.DataTable schemadsSmoothBlockFactory;
        private System.Data.DataColumn coldsSmoothBlockFactoryL3DataTableMatFactory;
        private AppSvrHMI.L3DataSet dsHurryGapFactory;
        private System.Data.DataTable schemadsHurryGapFactory;
        private System.Data.DataColumn coldsHurryGapFactoryL3DataTableMatFactory;
        private AppSvrHMI.L3DataSet dsCCMTempMode;
        private System.Data.DataTable schemadsCCMTempMode;
        private System.Data.DataColumn coldsCCMTempModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsCCMTempModeL3DataTableCode_Val_Long;
        private System.Windows.Forms.Label label34;
        private PxDataValid.PxTextBox pxTextBox33;
        private PxDataValid.PxTextBox pxTextBox17;
        private PxDataValid.PxTextBox pxTextBox2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Data.DataColumn coldsLadleL3DataTableAutoFlow;
        private System.Data.DataColumn coldsLadleL3DataTableUnAutoFlow_Reason;
        private AppSvrHMI.L3DataSet dsAutoFlow;
        private System.Data.DataTable schemadsAutoFlow;
        private System.Data.DataColumn coldsAutoFlowL3DataTableCode;
        private System.Data.DataColumn coldsAutoFlowL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsUnAutoFlow_Reason;
        private System.Data.DataTable schemadsUnAutoFlow_Reason;
        private System.Data.DataColumn coldsUnAutoFlow_ReasonL3DataTableCode;
        private System.Data.DataColumn coldsUnAutoFlow_ReasonL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnAutoFlow_ReasonL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsAutoFlowL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsBaseL3DataTableControl_Operator;
        private System.Data.DataColumn coldsBaseL3DataTableTundish_1ST_Officer;
        private System.Data.DataColumn coldsBaseL3DataTableTundish_2ST_Officer;
        private System.Data.DataColumn coldsBaseL3DataTableTundish_3ST_Officer;
        private System.Data.DataColumn coldsBaseL3DataTableTundish_4ST_Officer;
        private System.Data.DataColumn coldsBaseL3DataTableThickness;
        private System.Data.DataColumn coldsBaseL3DataTableWidth;
        private System.Data.DataColumn coldsBaseL3DataTableLength;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTableCode;
        private System.Data.DataColumn coldsShiftL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private System.Data.DataColumn coldsProcessL3DataTableTundishCar_Type;
        private System.Data.DataColumn coldsProcessL3DataTableCastingStartTime;
        private System.Data.DataColumn coldsProcessL3DataTableCastingStopTime;
        private System.Data.DataColumn coldsProcessL3DataTableWeight_Return_Reason;
        private AppSvrHMI.L3DataSet dsReturn_Reason;
        private System.Data.DataTable schemadsReturn_Reason;
        private System.Data.DataColumn coldsReturn_ReasonL3DataTableCode;
        private System.Data.DataColumn coldsReturn_ReasonL3DataTableCode_Des;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Data.DataColumn coldsProtectSlagL3DataTableUseInformation;
        private System.Data.DataColumn coldsProtectSlagL3DataTableAmount;
        private AppSvrHMI.L3DataSet dsProtectSlagUse;
        private System.Data.DataTable schemadsProtectSlagUse;
        private System.Data.DataColumn coldsProtectSlagUseL3DataTableCode;
        private System.Data.DataColumn coldsProtectSlagUseL3DataTableCode_Des;
        private System.Data.DataColumn coldsHeatCoverL3DataTableUseInformation;
        private AppSvrHMI.L3DataSet dsHeatCoverUse;
        private System.Data.DataTable schemadsHeatCoverUse;
        private System.Data.DataColumn coldsHeatCoverUseL3DataTableCode;
        private System.Data.DataColumn coldsHeatCoverUseL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsHoldTempMat;
        private System.Data.DataTable schemadsHoldTempMat;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableGUID;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableName;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableHeatID;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableCCMID;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableElement;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableWeight;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableOrigin;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableBatch_ID;
        private System.Data.DataColumn coldsHoldTempMatL3DataTableUseInformation;
        private System.Windows.Forms.BindingSource bsHoldTempMat;
        private AppSvrHMI.L3DataSet dsHoldTempMatUse;
        private System.Data.DataTable schemadsHoldTempMatUse;
        private System.Data.DataColumn coldsHoldTempMatUseL3DataTableCode;
        private System.Data.DataColumn coldsHoldTempMatUseL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsHoldTempOrigin;
        private System.Data.DataTable schemadsHoldTempOrigin;
        private System.Data.DataColumn coldsHoldTempOriginL3DataTableMatFactory;
        private System.Data.DataColumn coldsStrandInfoL3DataTableCastingStatus;
        private System.Data.DataColumn coldsStrandInfoL3DataTableCode;
        private System.Data.DataColumn coldsStrandInfoL3DataTableliquid_level;
        private System.Data.DataColumn coldsStrandInfoL3DataTableBlock_Up;
        private System.Data.DataColumn coldsStrandInfoL3DataTableBlock_Up_Reason;
        private System.Data.DataColumn coldsStrandInfoL3DataTableBreakOut_Num;
        private System.Data.DataColumn coldsStrandInfoL3DataTableMoldID;
        private System.Data.DataColumn coldsStrandInfoL3DataTableCopper_Fac;
        private System.Data.DataColumn coldsStrandInfoL3DataTableCopper_ID;
        private System.Data.DataColumn coldsStrandInfoL3DataTableHeat_Weight;
        private System.Data.DataColumn coldsStrandInfoL3DataTableTotal_Weight;
        private AppSvrHMI.L3DataSet dsBlock_Up;
        private System.Data.DataTable schemadsBlock_Up;
        private System.Data.DataColumn coldsBlock_UpL3DataTableCode;
        private System.Data.DataColumn coldsBlock_UpL3DataTableCode_Des;
        private System.Data.DataColumn coldsBlock_UpL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsWaterGapCenter;
        private AppSvrHMI.L3DataSet dsliquid_level;
        private AppSvrHMI.L3DataSet dsBlock_Up_Reason;
        private System.Data.DataTable schemadsWaterGapCenter;
        private System.Data.DataColumn coldsWaterGapCenterL3DataTableCode;
        private System.Data.DataColumn coldsWaterGapCenterL3DataTableCode_Des;
        private System.Data.DataColumn coldsWaterGapCenterL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsliquid_level;
        private System.Data.DataColumn coldsliquid_levelL3DataTableCode;
        private System.Data.DataColumn coldsliquid_levelL3DataTableCode_Des;
        private System.Data.DataColumn coldsliquid_levelL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsBlock_Up_Reason;
        private System.Data.DataColumn coldsBlock_Up_ReasonL3DataTableCode;
        private System.Data.DataColumn coldsBlock_Up_ReasonL3DataTableCode_Des;
        private System.Data.DataColumn coldsBlock_Up_ReasonL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsCopper_Fac;
        private System.Data.DataTable schemadsCopper_Fac;
        private System.Data.DataColumn coldsCopper_FacL3DataTableMATFACTORY;
        private System.Windows.Forms.TabPage tabRef;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSmoothBlock;
        private HMIBase.HMIRootPanel hmiRootPanel10;
        private System.Windows.Forms.DataGridView dvHurryS;
        private System.Windows.Forms.FlowLayoutPanel fLPSmoothBlock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripButton toolStripButton26;
        private System.Windows.Forms.ToolStripButton toolStripButton35;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator28;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator29;
        private System.Windows.Forms.ToolStripButton toolStripButton40;
        private System.Windows.Forms.ToolStripButton toolStripButton41;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator30;
        private System.Windows.Forms.ToolStripButton btnSmoothBlockAdd;
        private HMIBase.HMIRootPanel hmiRootPanel7;
        private System.Windows.Forms.DataGridView dvSmoothBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn strandNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockLifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn factoryDataGridViewTextBoxColumn2;
        private DataGridValid.CalendarColumn startTimeDataGridViewTextBoxColumn3;
        private DataGridValid.CalendarColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel pnlSmoothBlock;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSmoothBlockConfirm;
        private System.Windows.Forms.TabPage tabHurryGap;
        private System.Windows.Forms.TabPage tabBigGap;
        private HMIBase.HMIRootPanel hmiRootPanel9;
        private System.Windows.Forms.DataGridView dvBigGap;
        private System.Windows.Forms.FlowLayoutPanel pnlBigGap;
        private System.Windows.Forms.Button btnBigGapCancel;
        private System.Windows.Forms.Button btnBigGapConfirm;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel13;
        private System.Windows.Forms.ToolStripButton toolStripButton51;
        private System.Windows.Forms.ToolStripButton toolStripButton52;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator37;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator38;
        private System.Windows.Forms.ToolStripButton toolStripButton53;
        private System.Windows.Forms.ToolStripButton toolStripButton54;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator39;
        private System.Windows.Forms.ToolStripButton btnBigGapAdd;
        private HMIBase.HMIRootPanel hmiRootPanel8;
        private System.Windows.Forms.DataGridView dvHurryGap;
        private System.Windows.Forms.FlowLayoutPanel pnlHurryGap;
        private System.Windows.Forms.Button btnHurryGapCancel;
        private System.Windows.Forms.Button btnHurryGapConfirm;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripButton toolStripButton46;
        private System.Windows.Forms.ToolStripButton toolStripButton47;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator34;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator35;
        private System.Windows.Forms.ToolStripButton toolStripButton48;
        private System.Windows.Forms.ToolStripButton toolStripButton49;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator36;
        private System.Windows.Forms.ToolStripButton btnHurryGapAdd;
        private System.Windows.Forms.ComboBox cmbInjectionBar_BlowAr;
        private AppSvrHMI.L3DataSet dsYesNo;
        private System.Data.DataTable schemadsYesNo;
        private System.Data.DataColumn coldsYesNoL3DataTableCode_Des;
        private System.Data.DataColumn coldsYesNoL3DataTableCode_Val_Long;
        private System.Windows.Forms.ComboBox cmbSecondCoolingMode;
        private AppSvrHMI.L3DataSet dsSecondCoolingMode;
        private System.Data.DataTable schemadsSecondCoolingMode;
        private System.Data.DataColumn coldsSecondCoolingModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsSecondCoolingModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsAutoContorl;
        private System.Data.DataTable schemadsAutoContorl;
        private System.Data.DataColumn coldsAutoContorlL3DataTableCode_Des;
        private System.Data.DataColumn coldsAutoContorlL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsYesNo32;
        private System.Data.DataTable schemadsYesNo32;
        private System.Data.DataColumn coldsYesNo32L3DataTableCode_Des;
        private System.Data.DataColumn coldsYesNo32L3DataTableCode_Val_Long;
        private System.Windows.Forms.ComboBox cmbHeadFurnace;
        private AppSvrHMI.L3DataSet dsDuty;
        private System.Data.DataTable schemadsDuty;
        private System.Data.DataColumn coldsDutyL3DataTableGUID;
        private System.Data.DataColumn coldsDutyL3DataTableName;
        private System.Data.DataColumn coldsDutyL3DataTableCCMID;
        private System.Data.DataColumn coldsDutyL3DataTableTeamID;
        private System.Data.DataColumn coldsDutyL3DataTableStation;
        private System.Data.DataColumn coldsDutyL3DataTableOperator_name;
        private System.Windows.Forms.BindingSource bsHeadFurnace;
        private System.Windows.Forms.ComboBox cmbControlOperator;
        private System.Windows.Forms.BindingSource bsControlOperator;
        private System.Windows.Forms.ComboBox cmbAssistant;
        private System.Windows.Forms.BindingSource bsAssistant;
        private System.Windows.Forms.ComboBox cmbFirst;
        private System.Windows.Forms.BindingSource bsTundishOfficer1;
        private System.Windows.Forms.ComboBox cmbThirdth;
        private System.Windows.Forms.ComboBox cmbSecond;
        private System.Windows.Forms.ComboBox cmbFourth;
        private System.Windows.Forms.BindingSource bsTundishOfficer4;
        private System.Windows.Forms.BindingSource bsTundishOfficer3;
        private System.Windows.Forms.BindingSource bsTundishOfficer2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Data.DataColumn coldsProcessL3DataTableTundish_SlagThickness;
        private System.Data.DataColumn coldsProcessL3DataTableTundish_Bottom_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableTundish_Wall_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableBefore_Casting_Tundish_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableBefore_Casting_Shuikou_Temp1;
        private System.Data.DataColumn coldsProcessL3DataTableBefore_Casting_Shuikou_Temp2;
        private System.Data.DataColumn coldsProcessL3DataTableBefore_Casting_Shuikou_Temp3;
        private System.Data.DataColumn coldsProcessL3DataTableBefore_Casting_Shuikou_Temp4;
        private System.Data.DataColumn coldsProcessL3DataTableTundish_Level_Mold;
        private System.Data.DataColumn coldsProcessL3DataTablePlugBar_Control;
        private System.Data.DataColumn coldsProcessL3DataTableSoft_Press_Flag_1;
        private System.Data.DataColumn coldsProcessL3DataTableSoft_Press_Flag_2;
        private System.Data.DataColumn coldsProcessL3DataTableSoft_Press_Flag_3;
        private System.Data.DataColumn coldsProcessL3DataTableSoft_Press_Flag_4;
        private System.Windows.Forms.ComboBox cmbSoftPressFlag2;
        private System.Windows.Forms.ComboBox cmbSoftPressFlag4;
        private System.Windows.Forms.ComboBox cmbSoftPressFlag1;
        private System.Windows.Forms.ComboBox cmbSoftPressFlag3;
        private System.Windows.Forms.ComboBox cmbPlugBarControl;
        private PxDataValid.PxTextBox txtTundishBottomTemp;
        private PxDataValid.PxTextBox txtTundishLevelMold;
        private PxDataValid.PxTextBox txtTundishSlagThickness;
        private PxDataValid.PxTextBox txtTundishWallTemp;
        private System.Data.DataColumn coldsHurryGrapL3DataTableMatType;
        private AppSvrHMI.L3DataSet dsProtectSlagType;
        private System.Data.DataTable schemadsProtectSlagType;
        private System.Data.DataColumn coldsProtectSlagTypeL3DataTableCode;
        private System.Data.DataColumn coldsProtectSlagTypeL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnSmoothBlockDel;
        private System.Windows.Forms.ToolStripButton btnHurryGapDel;
        private System.Windows.Forms.ToolStripButton btnBigGapDel;
        private System.Windows.Forms.ToolStripButton btnDelHeatCover;
        private System.Windows.Forms.ToolStripButton btnDelProtectMat;
        private System.Windows.Forms.ToolStripButton btnDelProtectSlag;
        private System.Windows.Forms.ToolStripButton btnDelHoldTempMat;
        private System.Windows.Forms.ToolStripButton btnDelStrandInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewCheckBoxColumn;
        private DataGridValid.CalendarColumn changeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn2;
        private DataGridValid.CalendarColumn startTimeDataGridViewTextBoxColumn1;
        private DataGridValid.CalendarColumn stopTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn arFlowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn1;
        private DataGridValid.CalendarColumn logTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeIDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn MatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn strandNoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gapLifeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn factoryDataGridViewTextBoxColumn3;
        private DataGridValid.CalendarColumn startTimeDataGridViewTextBoxColumn4;
        private DataGridValid.CalendarColumn endTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn reasonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn strandNoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gapIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn factoryDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn matTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gapLifeDataGridViewTextBoxColumn1;
        private DataGridValid.CalendarColumn changeTimeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn reasonDataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabExcept;
        private System.Windows.Forms.BindingNavigator bdExcept;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator21;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator22;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem7;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator23;
        private System.Windows.Forms.ToolStripButton btnAddExcept;
        private System.Windows.Forms.DataGridView dvExcept;
        private AppSvrHMI.L3DataSet dsExcept;
        private System.Windows.Forms.BindingSource bsExcept;
        private System.Data.DataTable schemadsExcept;
        private System.Data.DataColumn coldsExceptL3DataTableGUID;
        private System.Data.DataColumn coldsExceptL3DataTableName;
        private System.Data.DataColumn coldsExceptL3DataTableID_Object;
        private System.Data.DataColumn coldsExceptL3DataTableHeatID;
        private System.Data.DataColumn coldsExceptL3DataTableProcess_Count;
        private System.Data.DataColumn coldsExceptL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsExceptL3DataTableUnitID;
        private System.Data.DataColumn coldsExceptL3DataTablePreHeatID;
        private System.Data.DataColumn coldsExceptL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsExceptL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptL3DataTableDecide_Code;
        private System.Data.DataColumn coldsExceptL3DataTableClassify;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Time;
        private System.Windows.Forms.FlowLayoutPanel fLPExcept;
        private System.Windows.Forms.Button btnCancelExcept;
        private System.Windows.Forms.Button btnConfirmExcept;
        private AppSvrHMI.L3DataSet dsExceptCode;
        private System.Data.DataTable schemadsExceptCode;
        private System.Data.DataColumn coldsExceptCodeL3DataTableGUID;
        private System.Data.DataColumn coldsExceptCodeL3DataTableName;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Des;
        private System.Data.DataColumn coldsExceptCodeL3DataTableUnit;
        private System.Data.DataColumn coldsExceptCodeL3DataTableAuto_Judge_Flag;
        private AppSvrHMI.L3Command cmdHeatExcept;
        private AppSvrHMI.L3CommandParameter l3cmdpHeatID;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitType;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitID;
        private AppSvrHMI.L3CommandParameter l3cmdprsData;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decideCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classifyDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnDelExcept;
        private System.Windows.Forms.Button btnCoverOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn arriveDateDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
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
        private DataGridValid.CalendarColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn tempIDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewCheckBoxColumn;
        private DataGridValid.CalendarColumn measureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn strandIDDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn factoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn elementDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewComboBoxColumn UseInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn elementDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn originDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn useInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn strandIDDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn changeTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn strandIDDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn softPressFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn autoControlDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castNumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn waterGapCenterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterGapDeepnessDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastingStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewComboBoxColumn liquid_level;
        private System.Windows.Forms.DataGridViewComboBoxColumn Block_Up;
        private System.Windows.Forms.DataGridViewComboBoxColumn Block_Up_Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn BreakOut_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoldID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Copper_Fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copper_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heat_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private DataGridValid.CalendarColumn calendarColumn1;
        private DataGridValid.CalendarColumn calendarColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private AppSvrHMI.L3DataSet dsCoverElement;
        private System.Data.DataTable schemadsCoverElement;
        private System.Data.DataColumn coldsCoverElementL3DataTableCode;
        private System.Data.DataColumn coldsCoverElementL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripLabel tsLblReason;
        private System.Windows.Forms.ToolStripTextBox tsTxtReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private AppSvrHMI.L3DataSet dsReason;
        private System.Data.DataTable schemadsReason;
        private System.Data.DataColumn coldsReasonL3DataTableName;
        private System.Data.DataColumn coldsReasonL3DataTableCode;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Des;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Group;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsReasonL3DataTableCode_Function_Group;
        private System.Data.DataColumn coldsReasonL3DataTableNC_Code;
        private System.Data.DataColumn coldsReasonL3DataTableGUID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator31;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripTextBox txtExcept;
        private AppSvrHMI.L3Command cmdExcept;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbSpeedChange;
        private System.Data.DataColumn coldsProcessL3DataTableSpeedChange;
        private System.Data.DataColumn coldsLadleL3DataTableCastingTundishWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastingTundishWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainWeightDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ladleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn castingStartTimeDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn castingStopTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TempUpTo;
        private System.Windows.Forms.DataGridViewComboBoxColumn holdTimeReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AutoFlow;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnAutoFlow_Reason;
        private System.Windows.Forms.DataGridViewComboBoxColumn Protection;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnProtection_Reason;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxTextBox pxTextBox5;
        private PxDataValid.PxTextBox pxTextBox6;
        private PxDataValid.PxTextBox pxTextBox7;
        private PxDataValid.PxTextBox pxTextBox8;
        private PxDataValid.PxTextBox pxTextBox9;
        private PxDataValid.PxTextBox pxTextBox10;
        private PxDataValid.PxTextBox pxTextBox11;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private PxDataValid.PxTextBox pxTextBox12;
        private PxDataValid.PxTextBox pxTextBox13;
        private PxDataValid.PxTextBox pxTextBox14;
        private PxDataValid.PxTextBox pxTextBox15;
        private PxDataValid.PxTextBox pxTextBox16;
        private PxDataValid.PxTextBox pxTextBox18;
        private PxDataValid.PxTextBox pxTextBox19;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private PxDataValid.PxTextBox pxTextBox21;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIDDataGridViewTextBoxColumn1;
        private System.Data.DataColumn coldsHeatCoverL3DataTableBatch_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn elementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn useInformationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.ComboBox cmbChangeReason;
        private PxDataValid.PxTextBox pxTextBox25;
        private System.Windows.Forms.Label label72;
        private System.Data.DataColumn coldsProcessL3DataTableSpeedChange_Reason;
        private System.Data.DataColumn coldsProcessL3DataTableSpeedChange_Detailed;
        private PxDataValid.PxTextBox pxTextBox26;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxTextBox pxTextBox27;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Data.DataColumn coldsProcessL3DataTableSoft_Press_Change;
        private System.Data.DataColumn coldsProcessL3DataTableSoft_Press_Detailed;
        private System.Data.DataColumn coldsProcessL3DataTableSoft_Press_Reason;
        private System.Data.DataColumn coldsLadleUseL3DataTableGUID;
        private System.Data.DataColumn coldsLadleUseL3DataTableHeatID;
        private AppSvrHMI.L3DataSet dsLadleUse;
        private System.Data.DataTable schemadsLadleUse;
        private System.Data.DataColumn AcoldsLadleUseL3DataTableGUID;
        private System.Data.DataColumn AcoldsLadleUseL3DataTableHeatID;
        private System.Data.DataColumn coldsLadleUseL3DataTableAuto_Flow;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label76;
        private PxDataValid.PxTextBox ptbShuikou_Temp4;
        private PxDataValid.PxTextBox ptbShuikou_Temp3;
        private PxDataValid.PxTextBox ptbShuikou_Temp2;
        private PxDataValid.PxTextBox ptbShuikou_Temp1;
        private PxDataValid.PxTextBox ptbBef_tundish_temp;
        private AppSvrHMI.L3DataSet l3DataSet1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
    }
}