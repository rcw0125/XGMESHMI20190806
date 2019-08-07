namespace QualityMag.QualityJudge
{
    partial class SteelWaterToBXGJudgeQueryFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteelWaterToBXGJudgeQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvFinalJudge = new System.Windows.Forms.DataGridView();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.HeatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCaster = new AppSvrHMI.L3DataSet();
            this.schemadsCaster = new System.Data.DataTable();
            this.coldsCasterL3DataTableCode = new System.Data.DataColumn();
            this.coldsCasterL3DataTableCode_Des = new System.Data.DataColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloomCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsWasterReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWasterReason = new AppSvrHMI.L3DataSet();
            this.schemadsWasterReason = new System.Data.DataTable();
            this.coldsWasterReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWasterReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.wasterCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsWasterReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.wasterCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasterReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsWasterReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.wrongCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongCount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsWrongReason1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWrongReason = new AppSvrHMI.L3DataSet();
            this.schemadsWrongReason = new System.Data.DataTable();
            this.coldsWrongReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsWrongReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.wrongCount2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsWrongReason2 = new System.Windows.Forms.BindingSource(this.components);
            this.wrongCount3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongWeight3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrongReason3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsWrongReason3 = new System.Windows.Forms.BindingSource(this.components);
            this.sufaceDefactDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalJudgeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decideCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sample_Address = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleAddr = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.Sample_Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleType = new AppSvrHMI.L3DataSet();
            this.schemadsSampleType = new System.Data.DataTable();
            this.coldsSampleTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.Sample_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Si = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.V = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.As = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Re = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CrNiCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operator_lab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFinalJudge = new System.Windows.Forms.BindingSource(this.components);
            this.dsFinalJudge = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet9 = new System.Data.DataTable();
            this.coll3DataSet9L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableOperator = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableShift = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableTeam = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableLength = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWidth = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableThickness = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableBloom_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableCal_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableRight_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableRight_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Reason1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Reason2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Count3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Weight3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWaster_Reason3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Reason1 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Reason2 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Count3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Weight3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableWrong_Reason3 = new System.Data.DataColumn();
            this.coldsHotJudgeL3DataTableSufaceDefactDes = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableCut_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableFinal_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableFinishedTime = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableFinalJudge_Time = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableProcess_Type = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableDecide_Code = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableAppID = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableSample_Code = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableArrive_Date = new System.Data.DataColumn();
            this.coldsElementL3DataTableReport_Date = new System.Data.DataColumn();
            this.coldsElementL3DataTableUnitTypeID = new System.Data.DataColumn();
            this.coldsElementL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsElementL3DataTableSample_Address = new System.Data.DataColumn();
            this.coldsElementL3DataTableSample_Type = new System.Data.DataColumn();
            this.coldsElementL3DataTableSample_Count = new System.Data.DataColumn();
            this.coldsElementL3DataTableC = new System.Data.DataColumn();
            this.coldsElementL3DataTableSi = new System.Data.DataColumn();
            this.coldsElementL3DataTableMn = new System.Data.DataColumn();
            this.coldsElementL3DataTableP = new System.Data.DataColumn();
            this.coldsElementL3DataTableS = new System.Data.DataColumn();
            this.coldsElementL3DataTableCu = new System.Data.DataColumn();
            this.coldsElementL3DataTableNi = new System.Data.DataColumn();
            this.coldsElementL3DataTableCr = new System.Data.DataColumn();
            this.coldsElementL3DataTableMo = new System.Data.DataColumn();
            this.coldsElementL3DataTableV = new System.Data.DataColumn();
            this.coldsElementL3DataTableNb = new System.Data.DataColumn();
            this.coldsElementL3DataTableAl = new System.Data.DataColumn();
            this.coldsElementL3DataTableAlS = new System.Data.DataColumn();
            this.coldsElementL3DataTableTi = new System.Data.DataColumn();
            this.coldsElementL3DataTableB = new System.Data.DataColumn();
            this.coldsElementL3DataTableSb = new System.Data.DataColumn();
            this.coldsElementL3DataTableAs = new System.Data.DataColumn();
            this.coldsElementL3DataTableSn = new System.Data.DataColumn();
            this.coldsElementL3DataTableZn = new System.Data.DataColumn();
            this.coldsElementL3DataTableCa = new System.Data.DataColumn();
            this.coldsElementL3DataTableW = new System.Data.DataColumn();
            this.coldsElementL3DataTablePb = new System.Data.DataColumn();
            this.coldsElementL3DataTableRe = new System.Data.DataColumn();
            this.coldsElementL3DataTableCeq = new System.Data.DataColumn();
            this.coldsElementL3DataTableN = new System.Data.DataColumn();
            this.coldsElementL3DataTableH = new System.Data.DataColumn();
            this.coldsElementL3DataTableO = new System.Data.DataColumn();
            this.coldsElementL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsElementL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsElementL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsElementL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsElementL3DataTableLogTime = new System.Data.DataColumn();
            this.coldsElementL3DataTableDataLogMode = new System.Data.DataColumn();
            this.coldsElementL3DataTableFinalJudgeFlag = new System.Data.DataColumn();
            this.coldsFinalJudgeL3DataTableoperator_lab = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.txtHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbSteelGradeIndex = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.dsUnitType = new AppSvrHMI.L3DataSet();
            this.schemadsUnitType = new System.Data.DataTable();
            this.coldsUnitTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnitTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsElementL3DataTableHeatID = new System.Data.DataColumn();
            this.dsProduct = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableC_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSi_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableMn_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableP_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableS_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCu_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableNi_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCr_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableMo_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableV_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableNb_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAl_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAlS_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableTi_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableB_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSb_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSn_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableAs_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableZn_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableZr_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCa_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableW_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTablePb_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableRe_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCeq_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableN_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableH_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableO_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCrNi_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCrCu_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCrNiCu_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther1_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther2_Max = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther3_Max = new System.Data.DataColumn();
            this.dsID = new AppSvrHMI.L3DataSet();
            this.dsSteelGradeIndex = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGradeIndex = new System.Data.DataTable();
            this.coldsSteelGradeIndexL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFinalJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinalJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinalJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvFinalJudge);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1028, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvFinalJudge
            // 
            this.dvFinalJudge.AllowUserToAddRows = false;
            this.dvFinalJudge.AutoGenerateColumns = false;
            this.dvFinalJudge.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvFinalJudge.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvFinalJudge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvFinalJudge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.HeatID,
            this.casterIDDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn,
            this.bloomCountDataGridViewTextBoxColumn,
            this.calWeightDataGridViewTextBoxColumn,
            this.rightCountDataGridViewTextBoxColumn,
            this.rightWeightDataGridViewTextBoxColumn,
            this.wasterCountDataGridViewTextBoxColumn,
            this.wasterWeightDataGridViewTextBoxColumn,
            this.wasterCount1DataGridViewTextBoxColumn,
            this.wasterWeight1DataGridViewTextBoxColumn,
            this.wasterReason1DataGridViewTextBoxColumn,
            this.wasterCount2DataGridViewTextBoxColumn,
            this.wasterWeight2DataGridViewTextBoxColumn,
            this.wasterReason2DataGridViewTextBoxColumn,
            this.wasterCount3DataGridViewTextBoxColumn,
            this.wasterWeight3DataGridViewTextBoxColumn,
            this.wasterReason3DataGridViewTextBoxColumn,
            this.wrongCountDataGridViewTextBoxColumn,
            this.wrongWeightDataGridViewTextBoxColumn,
            this.wrongCount1DataGridViewTextBoxColumn,
            this.wrongWeight1DataGridViewTextBoxColumn,
            this.wrongReason1DataGridViewTextBoxColumn,
            this.wrongCount2DataGridViewTextBoxColumn,
            this.wrongWeight2DataGridViewTextBoxColumn,
            this.wrongReason2DataGridViewTextBoxColumn,
            this.wrongCount3DataGridViewTextBoxColumn,
            this.wrongWeight3DataGridViewTextBoxColumn,
            this.wrongReason3DataGridViewTextBoxColumn,
            this.sufaceDefactDesDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.cutSteelGradeIndexDataGridViewTextBoxColumn,
            this.finalSteelGradeIndexDataGridViewTextBoxColumn,
            this.finishedTimeDataGridViewTextBoxColumn,
            this.finalJudgeTimeDataGridViewTextBoxColumn,
            this.processTypeDataGridViewTextBoxColumn,
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.decideCodeDataGridViewTextBoxColumn,
            this.Sample_Address,
            this.Sample_Type,
            this.Sample_Count,
            this.C,
            this.Si,
            this.Mn,
            this.P,
            this.S,
            this.Cu,
            this.Ni,
            this.Cr,
            this.Mo,
            this.V,
            this.Nb,
            this.Al,
            this.AlS,
            this.Ti,
            this.B,
            this.Sb,
            this.As,
            this.Sn,
            this.Zn,
            this.Ca,
            this.W,
            this.Pb,
            this.Re,
            this.Ceq,
            this.N,
            this.H,
            this.O,
            this.CrNi,
            this.CrCu,
            this.CrNiCu,
            this.Other1,
            this.Other2,
            this.Other3,
            this.operator_lab});
            this.dvFinalJudge.DataSource = this.bsFinalJudge;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvFinalJudge.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvFinalJudge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFinalJudge.Location = new System.Drawing.Point(0, 25);
            this.dvFinalJudge.MultiSelect = false;
            this.dvFinalJudge.Name = "dvFinalJudge";
            this.dvFinalJudge.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvFinalJudge.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvFinalJudge.RowTemplate.Height = 23;
            this.dvFinalJudge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvFinalJudge.Size = new System.Drawing.Size(1028, 508);
            this.dvFinalJudge.TabIndex = 31;
            this.dvFinalJudge.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvFinalJudge_RowPostPaint);
            this.dvFinalJudge.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFinalJudge_DataError);
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.Frozen = true;
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.Frozen = true;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\'";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.Frozen = true;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // HeatID
            // 
            this.HeatID.DataPropertyName = "HeatID";
            this.HeatID.Frozen = true;
            this.HeatID.HeaderText = "炉号";
            this.HeatID.Name = "HeatID";
            this.HeatID.ReadOnly = true;
            this.HeatID.Width = 80;
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.DataSource = this.dsCaster;
            this.casterIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.casterIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.casterIDDataGridViewTextBoxColumn.Frozen = true;
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.casterIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.casterIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.casterIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.casterIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // dsCaster
            // 
            this.dsCaster.AutoLoad = true;
            this.dsCaster.AutoSubscribe = false;
            this.dsCaster.DataSetName = "L3DataSet";
            this.dsCaster.DeleteMethod = null;
            this.dsCaster.InsertMethod = null;
            this.dsCaster.L3DataAdapter = this.Adapter;
            this.dsCaster.LoadEvent = "Click";
            this.dsCaster.LoadTrigger = null;
            this.dsCaster.RefreshValve = 1000;
            this.dsCaster.SourceCommand = null;
            this.dsCaster.SourceCondition = "CODE_GROUP = \'Caster\'";
            this.dsCaster.SourceMethod = "";
            this.dsCaster.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCaster.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCaster.SubscribeTarget = null;
            this.dsCaster.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCaster});
            this.dsCaster.UpdateEvent = "Click";
            this.dsCaster.UpdateMethod = null;
            this.dsCaster.UpdateTrigger = null;
            // 
            // schemadsCaster
            // 
            this.schemadsCaster.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCasterL3DataTableCode,
            this.coldsCasterL3DataTableCode_Des});
            this.schemadsCaster.TableName = "L3DataTable";
            // 
            // coldsCasterL3DataTableCode
            // 
            this.coldsCasterL3DataTableCode.Caption = "Code";
            this.coldsCasterL3DataTableCode.ColumnName = "Code";
            this.coldsCasterL3DataTableCode.Namespace = "";
            // 
            // coldsCasterL3DataTableCode_Des
            // 
            this.coldsCasterL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCasterL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCasterL3DataTableCode_Des.Namespace = "";
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 78;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 78;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 78;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            this.thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            this.thicknessDataGridViewTextBoxColumn.Width = 78;
            // 
            // bloomCountDataGridViewTextBoxColumn
            // 
            this.bloomCountDataGridViewTextBoxColumn.DataPropertyName = "Bloom_Count";
            this.bloomCountDataGridViewTextBoxColumn.HeaderText = "钢坯支数";
            this.bloomCountDataGridViewTextBoxColumn.Name = "bloomCountDataGridViewTextBoxColumn";
            this.bloomCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloomCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // calWeightDataGridViewTextBoxColumn
            // 
            this.calWeightDataGridViewTextBoxColumn.DataPropertyName = "Cal_Weight";
            this.calWeightDataGridViewTextBoxColumn.HeaderText = "理论重量";
            this.calWeightDataGridViewTextBoxColumn.Name = "calWeightDataGridViewTextBoxColumn";
            this.calWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.calWeightDataGridViewTextBoxColumn.Width = 78;
            // 
            // rightCountDataGridViewTextBoxColumn
            // 
            this.rightCountDataGridViewTextBoxColumn.DataPropertyName = "Right_Count";
            this.rightCountDataGridViewTextBoxColumn.HeaderText = "合格支数";
            this.rightCountDataGridViewTextBoxColumn.Name = "rightCountDataGridViewTextBoxColumn";
            this.rightCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.rightCountDataGridViewTextBoxColumn.Width = 78;
            // 
            // rightWeightDataGridViewTextBoxColumn
            // 
            this.rightWeightDataGridViewTextBoxColumn.DataPropertyName = "Right_Weight";
            this.rightWeightDataGridViewTextBoxColumn.HeaderText = "合格重量";
            this.rightWeightDataGridViewTextBoxColumn.Name = "rightWeightDataGridViewTextBoxColumn";
            this.rightWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.rightWeightDataGridViewTextBoxColumn.Width = 78;
            // 
            // wasterCountDataGridViewTextBoxColumn
            // 
            this.wasterCountDataGridViewTextBoxColumn.DataPropertyName = "Waster_Count";
            this.wasterCountDataGridViewTextBoxColumn.HeaderText = "甩废总长度";
            this.wasterCountDataGridViewTextBoxColumn.Name = "wasterCountDataGridViewTextBoxColumn";
            this.wasterCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCountDataGridViewTextBoxColumn.Width = 90;
            // 
            // wasterWeightDataGridViewTextBoxColumn
            // 
            this.wasterWeightDataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight";
            this.wasterWeightDataGridViewTextBoxColumn.HeaderText = "甩废总重量";
            this.wasterWeightDataGridViewTextBoxColumn.Name = "wasterWeightDataGridViewTextBoxColumn";
            this.wasterWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // wasterCount1DataGridViewTextBoxColumn
            // 
            this.wasterCount1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count1";
            this.wasterCount1DataGridViewTextBoxColumn.HeaderText = "甩废长度1";
            this.wasterCount1DataGridViewTextBoxColumn.Name = "wasterCount1DataGridViewTextBoxColumn";
            this.wasterCount1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCount1DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterWeight1DataGridViewTextBoxColumn
            // 
            this.wasterWeight1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight1";
            this.wasterWeight1DataGridViewTextBoxColumn.HeaderText = "甩废重量1";
            this.wasterWeight1DataGridViewTextBoxColumn.Name = "wasterWeight1DataGridViewTextBoxColumn";
            this.wasterWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight1DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason1DataGridViewTextBoxColumn
            // 
            this.wasterReason1DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason1";
            this.wasterReason1DataGridViewTextBoxColumn.DataSource = this.bsWasterReason1;
            this.wasterReason1DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason1DataGridViewTextBoxColumn.HeaderText = "甩废原因1";
            this.wasterReason1DataGridViewTextBoxColumn.Name = "wasterReason1DataGridViewTextBoxColumn";
            this.wasterReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason1DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wasterReason1DataGridViewTextBoxColumn.Width = 84;
            // 
            // bsWasterReason1
            // 
            this.bsWasterReason1.DataMember = "L3DataTable";
            this.bsWasterReason1.DataSource = this.dsWasterReason;
            // 
            // dsWasterReason
            // 
            this.dsWasterReason.AutoLoad = true;
            this.dsWasterReason.AutoSubscribe = false;
            this.dsWasterReason.DataSetName = "L3DataSet";
            this.dsWasterReason.DeleteMethod = null;
            this.dsWasterReason.InsertMethod = null;
            this.dsWasterReason.L3DataAdapter = this.Adapter;
            this.dsWasterReason.LoadEvent = "Click";
            this.dsWasterReason.LoadTrigger = null;
            this.dsWasterReason.RefreshValve = 1000;
            this.dsWasterReason.SourceCommand = null;
            this.dsWasterReason.SourceCondition = "CODE_GROUP = \'WASTE_REASON_CODE\' and 1=2";
            this.dsWasterReason.SourceMethod = "";
            this.dsWasterReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWasterReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWasterReason.SubscribeTarget = null;
            this.dsWasterReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWasterReason});
            this.dsWasterReason.UpdateEvent = "Click";
            this.dsWasterReason.UpdateMethod = null;
            this.dsWasterReason.UpdateTrigger = null;
            // 
            // schemadsWasterReason
            // 
            this.schemadsWasterReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWasterReasonL3DataTableCode,
            this.coldsWasterReasonL3DataTableCode_Des});
            this.schemadsWasterReason.TableName = "L3DataTable";
            // 
            // coldsWasterReasonL3DataTableCode
            // 
            this.coldsWasterReasonL3DataTableCode.Caption = "Code";
            this.coldsWasterReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWasterReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWasterReasonL3DataTableCode_Des
            // 
            this.coldsWasterReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWasterReasonL3DataTableCode_Des.Namespace = "";
            // 
            // wasterCount2DataGridViewTextBoxColumn
            // 
            this.wasterCount2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count2";
            this.wasterCount2DataGridViewTextBoxColumn.HeaderText = "甩废长度2";
            this.wasterCount2DataGridViewTextBoxColumn.Name = "wasterCount2DataGridViewTextBoxColumn";
            this.wasterCount2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCount2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterWeight2DataGridViewTextBoxColumn
            // 
            this.wasterWeight2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight2";
            this.wasterWeight2DataGridViewTextBoxColumn.HeaderText = "甩废重量2";
            this.wasterWeight2DataGridViewTextBoxColumn.Name = "wasterWeight2DataGridViewTextBoxColumn";
            this.wasterWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight2DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason2DataGridViewTextBoxColumn
            // 
            this.wasterReason2DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason2";
            this.wasterReason2DataGridViewTextBoxColumn.DataSource = this.bsWasterReason2;
            this.wasterReason2DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason2DataGridViewTextBoxColumn.HeaderText = "甩废原因2";
            this.wasterReason2DataGridViewTextBoxColumn.Name = "wasterReason2DataGridViewTextBoxColumn";
            this.wasterReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason2DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wasterReason2DataGridViewTextBoxColumn.Width = 84;
            // 
            // bsWasterReason2
            // 
            this.bsWasterReason2.DataMember = "L3DataTable";
            this.bsWasterReason2.DataSource = this.dsWasterReason;
            // 
            // wasterCount3DataGridViewTextBoxColumn
            // 
            this.wasterCount3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Count3";
            this.wasterCount3DataGridViewTextBoxColumn.HeaderText = "甩废长度3";
            this.wasterCount3DataGridViewTextBoxColumn.Name = "wasterCount3DataGridViewTextBoxColumn";
            this.wasterCount3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterCount3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterWeight3DataGridViewTextBoxColumn
            // 
            this.wasterWeight3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Weight3";
            this.wasterWeight3DataGridViewTextBoxColumn.HeaderText = "甩废重量3";
            this.wasterWeight3DataGridViewTextBoxColumn.Name = "wasterWeight3DataGridViewTextBoxColumn";
            this.wasterWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterWeight3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterWeight3DataGridViewTextBoxColumn.Width = 84;
            // 
            // wasterReason3DataGridViewTextBoxColumn
            // 
            this.wasterReason3DataGridViewTextBoxColumn.DataPropertyName = "Waster_Reason3";
            this.wasterReason3DataGridViewTextBoxColumn.DataSource = this.bsWasterReason3;
            this.wasterReason3DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wasterReason3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wasterReason3DataGridViewTextBoxColumn.HeaderText = "甩废原因3";
            this.wasterReason3DataGridViewTextBoxColumn.Name = "wasterReason3DataGridViewTextBoxColumn";
            this.wasterReason3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wasterReason3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wasterReason3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wasterReason3DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wasterReason3DataGridViewTextBoxColumn.Width = 84;
            // 
            // bsWasterReason3
            // 
            this.bsWasterReason3.DataMember = "L3DataTable";
            this.bsWasterReason3.DataSource = this.dsWasterReason;
            // 
            // wrongCountDataGridViewTextBoxColumn
            // 
            this.wrongCountDataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count";
            this.wrongCountDataGridViewTextBoxColumn.HeaderText = "不合格总支数";
            this.wrongCountDataGridViewTextBoxColumn.Name = "wrongCountDataGridViewTextBoxColumn";
            this.wrongCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCountDataGridViewTextBoxColumn.Width = 102;
            // 
            // wrongWeightDataGridViewTextBoxColumn
            // 
            this.wrongWeightDataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight";
            this.wrongWeightDataGridViewTextBoxColumn.HeaderText = "不合格总重量";
            this.wrongWeightDataGridViewTextBoxColumn.Name = "wrongWeightDataGridViewTextBoxColumn";
            this.wrongWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeightDataGridViewTextBoxColumn.Width = 102;
            // 
            // wrongCount1DataGridViewTextBoxColumn
            // 
            this.wrongCount1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count1";
            this.wrongCount1DataGridViewTextBoxColumn.HeaderText = "不合格支数1";
            this.wrongCount1DataGridViewTextBoxColumn.Name = "wrongCount1DataGridViewTextBoxColumn";
            this.wrongCount1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCount1DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongWeight1DataGridViewTextBoxColumn
            // 
            this.wrongWeight1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight1";
            this.wrongWeight1DataGridViewTextBoxColumn.HeaderText = "不合格重量1";
            this.wrongWeight1DataGridViewTextBoxColumn.Name = "wrongWeight1DataGridViewTextBoxColumn";
            this.wrongWeight1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeight1DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongReason1DataGridViewTextBoxColumn
            // 
            this.wrongReason1DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason1";
            this.wrongReason1DataGridViewTextBoxColumn.DataSource = this.bsWrongReason1;
            this.wrongReason1DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongReason1DataGridViewTextBoxColumn.HeaderText = "不合格原因1";
            this.wrongReason1DataGridViewTextBoxColumn.Name = "wrongReason1DataGridViewTextBoxColumn";
            this.wrongReason1DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason1DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wrongReason1DataGridViewTextBoxColumn.Width = 96;
            // 
            // bsWrongReason1
            // 
            this.bsWrongReason1.DataMember = "L3DataTable";
            this.bsWrongReason1.DataSource = this.dsWrongReason;
            // 
            // dsWrongReason
            // 
            this.dsWrongReason.AutoLoad = true;
            this.dsWrongReason.AutoSubscribe = false;
            this.dsWrongReason.DataSetName = "L3DataSet";
            this.dsWrongReason.DeleteMethod = null;
            this.dsWrongReason.InsertMethod = null;
            this.dsWrongReason.L3DataAdapter = this.Adapter;
            this.dsWrongReason.LoadEvent = "Click";
            this.dsWrongReason.LoadTrigger = null;
            this.dsWrongReason.RefreshValve = 1000;
            this.dsWrongReason.SourceCommand = null;
            this.dsWrongReason.SourceCondition = "CODE_GROUP = \'WRONG_REASON_CODE\' and 1=2";
            this.dsWrongReason.SourceMethod = "";
            this.dsWrongReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWrongReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWrongReason.SubscribeTarget = null;
            this.dsWrongReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWrongReason});
            this.dsWrongReason.UpdateEvent = "Click";
            this.dsWrongReason.UpdateMethod = null;
            this.dsWrongReason.UpdateTrigger = null;
            // 
            // schemadsWrongReason
            // 
            this.schemadsWrongReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWrongReasonL3DataTableCode,
            this.coldsWrongReasonL3DataTableCode_Des});
            this.schemadsWrongReason.TableName = "L3DataTable";
            // 
            // coldsWrongReasonL3DataTableCode
            // 
            this.coldsWrongReasonL3DataTableCode.Caption = "Code";
            this.coldsWrongReasonL3DataTableCode.ColumnName = "Code";
            this.coldsWrongReasonL3DataTableCode.Namespace = "";
            // 
            // coldsWrongReasonL3DataTableCode_Des
            // 
            this.coldsWrongReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWrongReasonL3DataTableCode_Des.Namespace = "";
            // 
            // wrongCount2DataGridViewTextBoxColumn
            // 
            this.wrongCount2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count2";
            this.wrongCount2DataGridViewTextBoxColumn.HeaderText = "不合格支数2";
            this.wrongCount2DataGridViewTextBoxColumn.Name = "wrongCount2DataGridViewTextBoxColumn";
            this.wrongCount2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCount2DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongWeight2DataGridViewTextBoxColumn
            // 
            this.wrongWeight2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight2";
            this.wrongWeight2DataGridViewTextBoxColumn.HeaderText = "不合格重量2";
            this.wrongWeight2DataGridViewTextBoxColumn.Name = "wrongWeight2DataGridViewTextBoxColumn";
            this.wrongWeight2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeight2DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongReason2DataGridViewTextBoxColumn
            // 
            this.wrongReason2DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason2";
            this.wrongReason2DataGridViewTextBoxColumn.DataSource = this.bsWrongReason2;
            this.wrongReason2DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason2DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongReason2DataGridViewTextBoxColumn.HeaderText = "不合格原因2";
            this.wrongReason2DataGridViewTextBoxColumn.Name = "wrongReason2DataGridViewTextBoxColumn";
            this.wrongReason2DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason2DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason2DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wrongReason2DataGridViewTextBoxColumn.Width = 96;
            // 
            // bsWrongReason2
            // 
            this.bsWrongReason2.DataMember = "L3DataTable";
            this.bsWrongReason2.DataSource = this.dsWrongReason;
            // 
            // wrongCount3DataGridViewTextBoxColumn
            // 
            this.wrongCount3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Count3";
            this.wrongCount3DataGridViewTextBoxColumn.HeaderText = "不合格支数3";
            this.wrongCount3DataGridViewTextBoxColumn.Name = "wrongCount3DataGridViewTextBoxColumn";
            this.wrongCount3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongCount3DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongWeight3DataGridViewTextBoxColumn
            // 
            this.wrongWeight3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Weight3";
            this.wrongWeight3DataGridViewTextBoxColumn.HeaderText = "不合格重量3";
            this.wrongWeight3DataGridViewTextBoxColumn.Name = "wrongWeight3DataGridViewTextBoxColumn";
            this.wrongWeight3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongWeight3DataGridViewTextBoxColumn.Width = 96;
            // 
            // wrongReason3DataGridViewTextBoxColumn
            // 
            this.wrongReason3DataGridViewTextBoxColumn.DataPropertyName = "Wrong_Reason3";
            this.wrongReason3DataGridViewTextBoxColumn.DataSource = this.bsWrongReason3;
            this.wrongReason3DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.wrongReason3DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wrongReason3DataGridViewTextBoxColumn.HeaderText = "不合格原因3";
            this.wrongReason3DataGridViewTextBoxColumn.Name = "wrongReason3DataGridViewTextBoxColumn";
            this.wrongReason3DataGridViewTextBoxColumn.ReadOnly = true;
            this.wrongReason3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrongReason3DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wrongReason3DataGridViewTextBoxColumn.ValueMember = "Code";
            this.wrongReason3DataGridViewTextBoxColumn.Width = 96;
            // 
            // bsWrongReason3
            // 
            this.bsWrongReason3.DataMember = "L3DataTable";
            this.bsWrongReason3.DataSource = this.dsWrongReason;
            // 
            // sufaceDefactDesDataGridViewTextBoxColumn
            // 
            this.sufaceDefactDesDataGridViewTextBoxColumn.DataPropertyName = "SufaceDefactDes";
            this.sufaceDefactDesDataGridViewTextBoxColumn.HeaderText = "表面缺陷描述";
            this.sufaceDefactDesDataGridViewTextBoxColumn.Name = "sufaceDefactDesDataGridViewTextBoxColumn";
            this.sufaceDefactDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.sufaceDefactDesDataGridViewTextBoxColumn.Width = 102;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // cutSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Cut_SteelGradeIndex";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "切断炼钢记号";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.Name = "cutSteelGradeIndexDataGridViewTextBoxColumn";
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.cutSteelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // finalSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Final_SteelGradeIndex";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "最终炼钢记号";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.Name = "finalSteelGradeIndexDataGridViewTextBoxColumn";
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalSteelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // finishedTimeDataGridViewTextBoxColumn
            // 
            this.finishedTimeDataGridViewTextBoxColumn.DataPropertyName = "FinishedTime";
            this.finishedTimeDataGridViewTextBoxColumn.HeaderText = "精整时间";
            this.finishedTimeDataGridViewTextBoxColumn.Name = "finishedTimeDataGridViewTextBoxColumn";
            this.finishedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.finishedTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // finalJudgeTimeDataGridViewTextBoxColumn
            // 
            this.finalJudgeTimeDataGridViewTextBoxColumn.DataPropertyName = "FinalJudge_Time";
            this.finalJudgeTimeDataGridViewTextBoxColumn.HeaderText = "终判时间";
            this.finalJudgeTimeDataGridViewTextBoxColumn.Name = "finalJudgeTimeDataGridViewTextBoxColumn";
            this.finalJudgeTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.finalJudgeTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // processTypeDataGridViewTextBoxColumn
            // 
            this.processTypeDataGridViewTextBoxColumn.DataPropertyName = "Process_Type";
            this.processTypeDataGridViewTextBoxColumn.HeaderText = "轧制方式";
            this.processTypeDataGridViewTextBoxColumn.Name = "processTypeDataGridViewTextBoxColumn";
            this.processTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.processTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // exceptionalCodeDataGridViewTextBoxColumn
            // 
            this.exceptionalCodeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Code";
            this.exceptionalCodeDataGridViewTextBoxColumn.HeaderText = "异常代码";
            this.exceptionalCodeDataGridViewTextBoxColumn.Name = "exceptionalCodeDataGridViewTextBoxColumn";
            this.exceptionalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.exceptionalCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // decideCodeDataGridViewTextBoxColumn
            // 
            this.decideCodeDataGridViewTextBoxColumn.DataPropertyName = "Decide_Code";
            this.decideCodeDataGridViewTextBoxColumn.HeaderText = "处理代码";
            this.decideCodeDataGridViewTextBoxColumn.Name = "decideCodeDataGridViewTextBoxColumn";
            this.decideCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.decideCodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // Sample_Address
            // 
            this.Sample_Address.DataPropertyName = "Sample_Address";
            this.Sample_Address.DataSource = this.dsSampleAddr;
            this.Sample_Address.DisplayMember = "L3DataTable.Code_Des";
            this.Sample_Address.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Sample_Address.HeaderText = "取样地点";
            this.Sample_Address.Name = "Sample_Address";
            this.Sample_Address.ReadOnly = true;
            this.Sample_Address.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sample_Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sample_Address.ValueMember = "L3DataTable.Code";
            this.Sample_Address.Width = 78;
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
            this.dsSampleAddr.SourceCondition = "CODE_GROUP = \'QA_Sample_Addr\' ";
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
            // Sample_Type
            // 
            this.Sample_Type.DataPropertyName = "Sample_Type";
            this.Sample_Type.DataSource = this.dsSampleType;
            this.Sample_Type.DisplayMember = "L3DataTable.Code_Des";
            this.Sample_Type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Sample_Type.HeaderText = "试样类别";
            this.Sample_Type.Name = "Sample_Type";
            this.Sample_Type.ReadOnly = true;
            this.Sample_Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sample_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sample_Type.ValueMember = "L3DataTable.Code";
            this.Sample_Type.Width = 78;
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
            this.dsSampleType.SourceCondition = "CODE_GROUP = \'QA_Sample_Type\' ";
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
            // Sample_Count
            // 
            this.Sample_Count.DataPropertyName = "Sample_Count";
            this.Sample_Count.HeaderText = "取样次数";
            this.Sample_Count.Name = "Sample_Count";
            this.Sample_Count.ReadOnly = true;
            this.Sample_Count.Width = 78;
            // 
            // C
            // 
            this.C.DataPropertyName = "C";
            this.C.HeaderText = "C";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 60;
            // 
            // Si
            // 
            this.Si.DataPropertyName = "Si";
            this.Si.HeaderText = "Si";
            this.Si.Name = "Si";
            this.Si.ReadOnly = true;
            this.Si.Width = 60;
            // 
            // Mn
            // 
            this.Mn.DataPropertyName = "Mn";
            this.Mn.HeaderText = "Mn";
            this.Mn.Name = "Mn";
            this.Mn.ReadOnly = true;
            this.Mn.Width = 60;
            // 
            // P
            // 
            this.P.DataPropertyName = "P";
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.ReadOnly = true;
            this.P.Width = 60;
            // 
            // S
            // 
            this.S.DataPropertyName = "S";
            this.S.HeaderText = "S";
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Width = 60;
            // 
            // Cu
            // 
            this.Cu.DataPropertyName = "Cu";
            this.Cu.HeaderText = "Cu";
            this.Cu.Name = "Cu";
            this.Cu.ReadOnly = true;
            this.Cu.Width = 60;
            // 
            // Ni
            // 
            this.Ni.DataPropertyName = "Ni";
            this.Ni.HeaderText = "Ni";
            this.Ni.Name = "Ni";
            this.Ni.ReadOnly = true;
            this.Ni.Width = 60;
            // 
            // Cr
            // 
            this.Cr.DataPropertyName = "Cr";
            this.Cr.HeaderText = "Cr";
            this.Cr.Name = "Cr";
            this.Cr.ReadOnly = true;
            this.Cr.Width = 60;
            // 
            // Mo
            // 
            this.Mo.DataPropertyName = "Mo";
            this.Mo.HeaderText = "Mo";
            this.Mo.Name = "Mo";
            this.Mo.ReadOnly = true;
            this.Mo.Width = 60;
            // 
            // V
            // 
            this.V.DataPropertyName = "V";
            this.V.HeaderText = "V";
            this.V.Name = "V";
            this.V.ReadOnly = true;
            this.V.Width = 60;
            // 
            // Nb
            // 
            this.Nb.DataPropertyName = "Nb";
            this.Nb.HeaderText = "Nb";
            this.Nb.Name = "Nb";
            this.Nb.ReadOnly = true;
            this.Nb.Width = 60;
            // 
            // Al
            // 
            this.Al.DataPropertyName = "Al";
            this.Al.HeaderText = "Al";
            this.Al.Name = "Al";
            this.Al.ReadOnly = true;
            this.Al.Width = 60;
            // 
            // AlS
            // 
            this.AlS.DataPropertyName = "AlS";
            this.AlS.HeaderText = "AlS";
            this.AlS.Name = "AlS";
            this.AlS.ReadOnly = true;
            this.AlS.Width = 60;
            // 
            // Ti
            // 
            this.Ti.DataPropertyName = "Ti";
            this.Ti.HeaderText = "Ti";
            this.Ti.Name = "Ti";
            this.Ti.ReadOnly = true;
            this.Ti.Width = 60;
            // 
            // B
            // 
            this.B.DataPropertyName = "B";
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            this.B.Width = 60;
            // 
            // Sb
            // 
            this.Sb.DataPropertyName = "Sb";
            this.Sb.HeaderText = "Sb";
            this.Sb.Name = "Sb";
            this.Sb.ReadOnly = true;
            this.Sb.Width = 60;
            // 
            // As
            // 
            this.As.DataPropertyName = "As";
            this.As.HeaderText = "As";
            this.As.Name = "As";
            this.As.ReadOnly = true;
            this.As.Width = 60;
            // 
            // Sn
            // 
            this.Sn.DataPropertyName = "Sn";
            this.Sn.HeaderText = "Sn";
            this.Sn.Name = "Sn";
            this.Sn.ReadOnly = true;
            this.Sn.Width = 60;
            // 
            // Zn
            // 
            this.Zn.DataPropertyName = "Zn";
            this.Zn.HeaderText = "Zn";
            this.Zn.Name = "Zn";
            this.Zn.ReadOnly = true;
            this.Zn.Width = 60;
            // 
            // Ca
            // 
            this.Ca.DataPropertyName = "Ca";
            this.Ca.HeaderText = "Ca";
            this.Ca.Name = "Ca";
            this.Ca.ReadOnly = true;
            this.Ca.Width = 60;
            // 
            // W
            // 
            this.W.DataPropertyName = "W";
            this.W.HeaderText = "W";
            this.W.Name = "W";
            this.W.ReadOnly = true;
            this.W.Width = 60;
            // 
            // Pb
            // 
            this.Pb.DataPropertyName = "Pb";
            this.Pb.HeaderText = "Pb";
            this.Pb.Name = "Pb";
            this.Pb.ReadOnly = true;
            this.Pb.Width = 60;
            // 
            // Re
            // 
            this.Re.DataPropertyName = "Re";
            this.Re.HeaderText = "Re";
            this.Re.Name = "Re";
            this.Re.ReadOnly = true;
            this.Re.Width = 60;
            // 
            // Ceq
            // 
            this.Ceq.DataPropertyName = "Ceq";
            this.Ceq.HeaderText = "Ceq";
            this.Ceq.Name = "Ceq";
            this.Ceq.ReadOnly = true;
            this.Ceq.Width = 60;
            // 
            // N
            // 
            this.N.DataPropertyName = "N";
            this.N.HeaderText = "N";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Width = 60;
            // 
            // H
            // 
            this.H.DataPropertyName = "H";
            this.H.HeaderText = "H";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            this.H.Width = 60;
            // 
            // O
            // 
            this.O.DataPropertyName = "O";
            this.O.HeaderText = "O";
            this.O.Name = "O";
            this.O.ReadOnly = true;
            this.O.Width = 60;
            // 
            // CrNi
            // 
            this.CrNi.DataPropertyName = "CrNi";
            this.CrNi.HeaderText = "CrNi";
            this.CrNi.Name = "CrNi";
            this.CrNi.ReadOnly = true;
            this.CrNi.Width = 60;
            // 
            // CrCu
            // 
            this.CrCu.DataPropertyName = "CrCu";
            this.CrCu.HeaderText = "CrCu";
            this.CrCu.Name = "CrCu";
            this.CrCu.ReadOnly = true;
            this.CrCu.Width = 60;
            // 
            // CrNiCu
            // 
            this.CrNiCu.DataPropertyName = "CrNiCu";
            this.CrNiCu.HeaderText = "CrNiCu";
            this.CrNiCu.Name = "CrNiCu";
            this.CrNiCu.ReadOnly = true;
            this.CrNiCu.Width = 66;
            // 
            // Other1
            // 
            this.Other1.DataPropertyName = "Other1";
            this.Other1.HeaderText = "Other1";
            this.Other1.Name = "Other1";
            this.Other1.ReadOnly = true;
            this.Other1.Width = 66;
            // 
            // Other2
            // 
            this.Other2.DataPropertyName = "Other2";
            this.Other2.HeaderText = "Other2";
            this.Other2.Name = "Other2";
            this.Other2.ReadOnly = true;
            this.Other2.Width = 66;
            // 
            // Other3
            // 
            this.Other3.DataPropertyName = "Other3";
            this.Other3.HeaderText = "Other3";
            this.Other3.Name = "Other3";
            this.Other3.ReadOnly = true;
            this.Other3.Width = 66;
            // 
            // operator_lab
            // 
            this.operator_lab.DataPropertyName = "operator_lab";
            this.operator_lab.HeaderText = "检验员";
            this.operator_lab.Name = "operator_lab";
            this.operator_lab.ReadOnly = true;
            this.operator_lab.Width = 66;
            // 
            // bsFinalJudge
            // 
            this.bsFinalJudge.DataMember = "L3DataTable";
            this.bsFinalJudge.DataSource = this.dsFinalJudge;
            // 
            // dsFinalJudge
            // 
            this.dsFinalJudge.AutoLoad = true;
            this.dsFinalJudge.AutoSubscribe = false;
            this.dsFinalJudge.DataSetName = "L3DataSet";
            this.dsFinalJudge.DeleteMethod = null;
            this.dsFinalJudge.InsertMethod = null;
            this.dsFinalJudge.L3DataAdapter = this.Adapter;
            this.dsFinalJudge.LoadEvent = "Click";
            this.dsFinalJudge.LoadTrigger = null;
            this.dsFinalJudge.RefreshValve = 1000;
            this.dsFinalJudge.SourceCommand = null;
            this.dsFinalJudge.SourceCondition = "";
            this.dsFinalJudge.SourceMethod = "";
            this.dsFinalJudge.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsFinalJudge.SourceURI = "";
            this.dsFinalJudge.SubscribeTarget = null;
            this.dsFinalJudge.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet9});
            this.dsFinalJudge.UpdateEvent = "Click";
            this.dsFinalJudge.UpdateMethod = null;
            this.dsFinalJudge.UpdateTrigger = null;
            // 
            // schemal3DataSet9
            // 
            this.schemal3DataSet9.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet9L3DataTableGUID,
            this.coll3DataSet9L3DataTableName,
            this.coll3DataSet9L3DataTableOperator,
            this.coll3DataSet9L3DataTableShift,
            this.coll3DataSet9L3DataTableTeam,
            this.coldsHotJudgeL3DataTableHeatID,
            this.coldsHotJudgeL3DataTableCasterID,
            this.coldsHotJudgeL3DataTableSteelGradeIndex,
            this.coldsHotJudgeL3DataTableLength,
            this.coldsHotJudgeL3DataTableWidth,
            this.coldsHotJudgeL3DataTableThickness,
            this.coldsHotJudgeL3DataTableBloom_Count,
            this.coldsHotJudgeL3DataTableCal_Weight,
            this.coldsHotJudgeL3DataTableRight_Count,
            this.coldsHotJudgeL3DataTableRight_Weight,
            this.coldsHotJudgeL3DataTableWaster_Count,
            this.coldsHotJudgeL3DataTableWaster_Weight,
            this.coldsHotJudgeL3DataTableWaster_Count1,
            this.coldsHotJudgeL3DataTableWaster_Weight1,
            this.coldsHotJudgeL3DataTableWaster_Reason1,
            this.coldsHotJudgeL3DataTableWaster_Count2,
            this.coldsHotJudgeL3DataTableWaster_Weight2,
            this.coldsHotJudgeL3DataTableWaster_Reason2,
            this.coldsHotJudgeL3DataTableWaster_Count3,
            this.coldsHotJudgeL3DataTableWaster_Weight3,
            this.coldsHotJudgeL3DataTableWaster_Reason3,
            this.coldsHotJudgeL3DataTableWrong_Count,
            this.coldsHotJudgeL3DataTableWrong_Weight,
            this.coldsHotJudgeL3DataTableWrong_Count1,
            this.coldsHotJudgeL3DataTableWrong_Weight1,
            this.coldsHotJudgeL3DataTableWrong_Reason1,
            this.coldsHotJudgeL3DataTableWrong_Count2,
            this.coldsHotJudgeL3DataTableWrong_Weight2,
            this.coldsHotJudgeL3DataTableWrong_Reason2,
            this.coldsHotJudgeL3DataTableWrong_Count3,
            this.coldsHotJudgeL3DataTableWrong_Weight3,
            this.coldsHotJudgeL3DataTableWrong_Reason3,
            this.coldsHotJudgeL3DataTableSufaceDefactDes,
            this.coldsFinalJudgeL3DataTablePre_SteelGradeIndex,
            this.coldsFinalJudgeL3DataTableCut_SteelGradeIndex,
            this.coldsFinalJudgeL3DataTableFinal_SteelGradeIndex,
            this.coldsFinalJudgeL3DataTableFinishedTime,
            this.coldsFinalJudgeL3DataTableFinalJudge_Time,
            this.coldsFinalJudgeL3DataTableProcess_Type,
            this.coldsFinalJudgeL3DataTableExceptional_Code,
            this.coldsFinalJudgeL3DataTableDecide_Code,
            this.coldsFinalJudgeL3DataTableAppID,
            this.coldsFinalJudgeL3DataTableSample_Code,
            this.coldsFinalJudgeL3DataTableArrive_Date,
            this.coldsElementL3DataTableReport_Date,
            this.coldsElementL3DataTableUnitTypeID,
            this.coldsElementL3DataTableUnitID,
            this.coldsElementL3DataTableSample_Address,
            this.coldsElementL3DataTableSample_Type,
            this.coldsElementL3DataTableSample_Count,
            this.coldsElementL3DataTableC,
            this.coldsElementL3DataTableSi,
            this.coldsElementL3DataTableMn,
            this.coldsElementL3DataTableP,
            this.coldsElementL3DataTableS,
            this.coldsElementL3DataTableCu,
            this.coldsElementL3DataTableNi,
            this.coldsElementL3DataTableCr,
            this.coldsElementL3DataTableMo,
            this.coldsElementL3DataTableV,
            this.coldsElementL3DataTableNb,
            this.coldsElementL3DataTableAl,
            this.coldsElementL3DataTableAlS,
            this.coldsElementL3DataTableTi,
            this.coldsElementL3DataTableB,
            this.coldsElementL3DataTableSb,
            this.coldsElementL3DataTableAs,
            this.coldsElementL3DataTableSn,
            this.coldsElementL3DataTableZn,
            this.coldsElementL3DataTableCa,
            this.coldsElementL3DataTableW,
            this.coldsElementL3DataTablePb,
            this.coldsElementL3DataTableRe,
            this.coldsElementL3DataTableCeq,
            this.coldsElementL3DataTableN,
            this.coldsElementL3DataTableH,
            this.coldsElementL3DataTableO,
            this.coldsElementL3DataTableCrNi,
            this.coldsElementL3DataTableCrCu,
            this.coldsElementL3DataTableCrNiCu,
            this.coldsElementL3DataTableOther1,
            this.coldsElementL3DataTableOther2,
            this.coldsElementL3DataTableOther3,
            this.coldsElementL3DataTableLogTime,
            this.coldsElementL3DataTableDataLogMode,
            this.coldsElementL3DataTableFinalJudgeFlag,
            this.coldsFinalJudgeL3DataTableoperator_lab});
            this.schemal3DataSet9.TableName = "L3DataTable";
            // 
            // coll3DataSet9L3DataTableGUID
            // 
            this.coll3DataSet9L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet9L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet9L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet9L3DataTableName
            // 
            this.coll3DataSet9L3DataTableName.Caption = "Name";
            this.coll3DataSet9L3DataTableName.ColumnName = "Name";
            this.coll3DataSet9L3DataTableName.Namespace = "";
            // 
            // coll3DataSet9L3DataTableOperator
            // 
            this.coll3DataSet9L3DataTableOperator.Caption = "Operator";
            this.coll3DataSet9L3DataTableOperator.ColumnName = "Operator";
            this.coll3DataSet9L3DataTableOperator.Namespace = "";
            // 
            // coll3DataSet9L3DataTableShift
            // 
            this.coll3DataSet9L3DataTableShift.Caption = "Shift";
            this.coll3DataSet9L3DataTableShift.ColumnName = "Shift";
            this.coll3DataSet9L3DataTableShift.Namespace = "";
            // 
            // coll3DataSet9L3DataTableTeam
            // 
            this.coll3DataSet9L3DataTableTeam.Caption = "Team";
            this.coll3DataSet9L3DataTableTeam.ColumnName = "Team";
            this.coll3DataSet9L3DataTableTeam.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableHeatID
            // 
            this.coldsHotJudgeL3DataTableHeatID.Caption = "HeatID";
            this.coldsHotJudgeL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHotJudgeL3DataTableHeatID.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableCasterID
            // 
            this.coldsHotJudgeL3DataTableCasterID.Caption = "CasterID";
            this.coldsHotJudgeL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsHotJudgeL3DataTableCasterID.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableSteelGradeIndex
            // 
            this.coldsHotJudgeL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsHotJudgeL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsHotJudgeL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableLength
            // 
            this.coldsHotJudgeL3DataTableLength.Caption = "Length";
            this.coldsHotJudgeL3DataTableLength.ColumnName = "Length";
            this.coldsHotJudgeL3DataTableLength.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableLength.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWidth
            // 
            this.coldsHotJudgeL3DataTableWidth.Caption = "Width";
            this.coldsHotJudgeL3DataTableWidth.ColumnName = "Width";
            this.coldsHotJudgeL3DataTableWidth.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWidth.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableThickness
            // 
            this.coldsHotJudgeL3DataTableThickness.Caption = "Thickness";
            this.coldsHotJudgeL3DataTableThickness.ColumnName = "Thickness";
            this.coldsHotJudgeL3DataTableThickness.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableThickness.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableBloom_Count
            // 
            this.coldsHotJudgeL3DataTableBloom_Count.Caption = "Bloom_Count";
            this.coldsHotJudgeL3DataTableBloom_Count.ColumnName = "Bloom_Count";
            this.coldsHotJudgeL3DataTableBloom_Count.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableBloom_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableCal_Weight
            // 
            this.coldsHotJudgeL3DataTableCal_Weight.Caption = "Cal_Weight";
            this.coldsHotJudgeL3DataTableCal_Weight.ColumnName = "Cal_Weight";
            this.coldsHotJudgeL3DataTableCal_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableCal_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableRight_Count
            // 
            this.coldsHotJudgeL3DataTableRight_Count.Caption = "Right_Count";
            this.coldsHotJudgeL3DataTableRight_Count.ColumnName = "Right_Count";
            this.coldsHotJudgeL3DataTableRight_Count.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableRight_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableRight_Weight
            // 
            this.coldsHotJudgeL3DataTableRight_Weight.Caption = "Right_Weight";
            this.coldsHotJudgeL3DataTableRight_Weight.ColumnName = "Right_Weight";
            this.coldsHotJudgeL3DataTableRight_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableRight_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count
            // 
            this.coldsHotJudgeL3DataTableWaster_Count.Caption = "Waster_Count";
            this.coldsHotJudgeL3DataTableWaster_Count.ColumnName = "Waster_Count";
            this.coldsHotJudgeL3DataTableWaster_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight.Caption = "Waster_Weight";
            this.coldsHotJudgeL3DataTableWaster_Weight.ColumnName = "Waster_Weight";
            this.coldsHotJudgeL3DataTableWaster_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count1
            // 
            this.coldsHotJudgeL3DataTableWaster_Count1.Caption = "Waster_Count1";
            this.coldsHotJudgeL3DataTableWaster_Count1.ColumnName = "Waster_Count1";
            this.coldsHotJudgeL3DataTableWaster_Count1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight1
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight1.Caption = "Waster_Weight1";
            this.coldsHotJudgeL3DataTableWaster_Weight1.ColumnName = "Waster_Weight1";
            this.coldsHotJudgeL3DataTableWaster_Weight1.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Reason1
            // 
            this.coldsHotJudgeL3DataTableWaster_Reason1.Caption = "Waster_Reason1";
            this.coldsHotJudgeL3DataTableWaster_Reason1.ColumnName = "Waster_Reason1";
            this.coldsHotJudgeL3DataTableWaster_Reason1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count2
            // 
            this.coldsHotJudgeL3DataTableWaster_Count2.Caption = "Waster_Count2";
            this.coldsHotJudgeL3DataTableWaster_Count2.ColumnName = "Waster_Count2";
            this.coldsHotJudgeL3DataTableWaster_Count2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight2
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight2.Caption = "Waster_Weight2";
            this.coldsHotJudgeL3DataTableWaster_Weight2.ColumnName = "Waster_Weight2";
            this.coldsHotJudgeL3DataTableWaster_Weight2.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Reason2
            // 
            this.coldsHotJudgeL3DataTableWaster_Reason2.Caption = "Waster_Reason2";
            this.coldsHotJudgeL3DataTableWaster_Reason2.ColumnName = "Waster_Reason2";
            this.coldsHotJudgeL3DataTableWaster_Reason2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Count3
            // 
            this.coldsHotJudgeL3DataTableWaster_Count3.Caption = "Waster_Count3";
            this.coldsHotJudgeL3DataTableWaster_Count3.ColumnName = "Waster_Count3";
            this.coldsHotJudgeL3DataTableWaster_Count3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Weight3
            // 
            this.coldsHotJudgeL3DataTableWaster_Weight3.Caption = "Waster_Weight3";
            this.coldsHotJudgeL3DataTableWaster_Weight3.ColumnName = "Waster_Weight3";
            this.coldsHotJudgeL3DataTableWaster_Weight3.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWaster_Weight3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWaster_Reason3
            // 
            this.coldsHotJudgeL3DataTableWaster_Reason3.Caption = "Waster_Reason3";
            this.coldsHotJudgeL3DataTableWaster_Reason3.ColumnName = "Waster_Reason3";
            this.coldsHotJudgeL3DataTableWaster_Reason3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count
            // 
            this.coldsHotJudgeL3DataTableWrong_Count.Caption = "Wrong_Count";
            this.coldsHotJudgeL3DataTableWrong_Count.ColumnName = "Wrong_Count";
            this.coldsHotJudgeL3DataTableWrong_Count.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight.Caption = "Wrong_Weight";
            this.coldsHotJudgeL3DataTableWrong_Weight.ColumnName = "Wrong_Weight";
            this.coldsHotJudgeL3DataTableWrong_Weight.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count1
            // 
            this.coldsHotJudgeL3DataTableWrong_Count1.Caption = "Wrong_Count1";
            this.coldsHotJudgeL3DataTableWrong_Count1.ColumnName = "Wrong_Count1";
            this.coldsHotJudgeL3DataTableWrong_Count1.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight1
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight1.Caption = "Wrong_Weight1";
            this.coldsHotJudgeL3DataTableWrong_Weight1.ColumnName = "Wrong_Weight1";
            this.coldsHotJudgeL3DataTableWrong_Weight1.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Reason1
            // 
            this.coldsHotJudgeL3DataTableWrong_Reason1.Caption = "Wrong_Reason1";
            this.coldsHotJudgeL3DataTableWrong_Reason1.ColumnName = "Wrong_Reason1";
            this.coldsHotJudgeL3DataTableWrong_Reason1.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count2
            // 
            this.coldsHotJudgeL3DataTableWrong_Count2.Caption = "Wrong_Count2";
            this.coldsHotJudgeL3DataTableWrong_Count2.ColumnName = "Wrong_Count2";
            this.coldsHotJudgeL3DataTableWrong_Count2.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight2
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight2.Caption = "Wrong_Weight2";
            this.coldsHotJudgeL3DataTableWrong_Weight2.ColumnName = "Wrong_Weight2";
            this.coldsHotJudgeL3DataTableWrong_Weight2.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Reason2
            // 
            this.coldsHotJudgeL3DataTableWrong_Reason2.Caption = "Wrong_Reason2";
            this.coldsHotJudgeL3DataTableWrong_Reason2.ColumnName = "Wrong_Reason2";
            this.coldsHotJudgeL3DataTableWrong_Reason2.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Count3
            // 
            this.coldsHotJudgeL3DataTableWrong_Count3.Caption = "Wrong_Count3";
            this.coldsHotJudgeL3DataTableWrong_Count3.ColumnName = "Wrong_Count3";
            this.coldsHotJudgeL3DataTableWrong_Count3.DataType = typeof(int);
            this.coldsHotJudgeL3DataTableWrong_Count3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Weight3
            // 
            this.coldsHotJudgeL3DataTableWrong_Weight3.Caption = "Wrong_Weight3";
            this.coldsHotJudgeL3DataTableWrong_Weight3.ColumnName = "Wrong_Weight3";
            this.coldsHotJudgeL3DataTableWrong_Weight3.DataType = typeof(double);
            this.coldsHotJudgeL3DataTableWrong_Weight3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableWrong_Reason3
            // 
            this.coldsHotJudgeL3DataTableWrong_Reason3.Caption = "Wrong_Reason3";
            this.coldsHotJudgeL3DataTableWrong_Reason3.ColumnName = "Wrong_Reason3";
            this.coldsHotJudgeL3DataTableWrong_Reason3.Namespace = "";
            // 
            // coldsHotJudgeL3DataTableSufaceDefactDes
            // 
            this.coldsHotJudgeL3DataTableSufaceDefactDes.Caption = "SufaceDefactDes";
            this.coldsHotJudgeL3DataTableSufaceDefactDes.ColumnName = "SufaceDefactDes";
            this.coldsHotJudgeL3DataTableSufaceDefactDes.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTablePre_SteelGradeIndex
            // 
            this.coldsFinalJudgeL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsFinalJudgeL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsFinalJudgeL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableCut_SteelGradeIndex
            // 
            this.coldsFinalJudgeL3DataTableCut_SteelGradeIndex.Caption = "Cut_SteelGradeIndex";
            this.coldsFinalJudgeL3DataTableCut_SteelGradeIndex.ColumnName = "Cut_SteelGradeIndex";
            this.coldsFinalJudgeL3DataTableCut_SteelGradeIndex.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableFinal_SteelGradeIndex
            // 
            this.coldsFinalJudgeL3DataTableFinal_SteelGradeIndex.Caption = "Final_SteelGradeIndex";
            this.coldsFinalJudgeL3DataTableFinal_SteelGradeIndex.ColumnName = "Final_SteelGradeIndex";
            this.coldsFinalJudgeL3DataTableFinal_SteelGradeIndex.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableFinishedTime
            // 
            this.coldsFinalJudgeL3DataTableFinishedTime.Caption = "FinishedTime";
            this.coldsFinalJudgeL3DataTableFinishedTime.ColumnName = "FinishedTime";
            this.coldsFinalJudgeL3DataTableFinishedTime.DataType = typeof(System.DateTime);
            this.coldsFinalJudgeL3DataTableFinishedTime.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableFinalJudge_Time
            // 
            this.coldsFinalJudgeL3DataTableFinalJudge_Time.Caption = "FinalJudge_Time";
            this.coldsFinalJudgeL3DataTableFinalJudge_Time.ColumnName = "FinalJudge_Time";
            this.coldsFinalJudgeL3DataTableFinalJudge_Time.DataType = typeof(System.DateTime);
            this.coldsFinalJudgeL3DataTableFinalJudge_Time.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableProcess_Type
            // 
            this.coldsFinalJudgeL3DataTableProcess_Type.Caption = "Process_Type";
            this.coldsFinalJudgeL3DataTableProcess_Type.ColumnName = "Process_Type";
            this.coldsFinalJudgeL3DataTableProcess_Type.DataType = typeof(int);
            this.coldsFinalJudgeL3DataTableProcess_Type.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableExceptional_Code
            // 
            this.coldsFinalJudgeL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsFinalJudgeL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsFinalJudgeL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableDecide_Code
            // 
            this.coldsFinalJudgeL3DataTableDecide_Code.Caption = "Decide_Code";
            this.coldsFinalJudgeL3DataTableDecide_Code.ColumnName = "Decide_Code";
            this.coldsFinalJudgeL3DataTableDecide_Code.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableAppID
            // 
            this.coldsFinalJudgeL3DataTableAppID.Caption = "AppID";
            this.coldsFinalJudgeL3DataTableAppID.ColumnName = "AppID";
            this.coldsFinalJudgeL3DataTableAppID.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableSample_Code
            // 
            this.coldsFinalJudgeL3DataTableSample_Code.Caption = "Sample_Code";
            this.coldsFinalJudgeL3DataTableSample_Code.ColumnName = "Sample_Code";
            this.coldsFinalJudgeL3DataTableSample_Code.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableArrive_Date
            // 
            this.coldsFinalJudgeL3DataTableArrive_Date.Caption = "Arrive_Date";
            this.coldsFinalJudgeL3DataTableArrive_Date.ColumnName = "Arrive_Date";
            this.coldsFinalJudgeL3DataTableArrive_Date.DataType = typeof(System.DateTime);
            this.coldsFinalJudgeL3DataTableArrive_Date.Namespace = "";
            // 
            // coldsElementL3DataTableReport_Date
            // 
            this.coldsElementL3DataTableReport_Date.Caption = "Report_Date";
            this.coldsElementL3DataTableReport_Date.ColumnName = "Report_Date";
            this.coldsElementL3DataTableReport_Date.DataType = typeof(System.DateTime);
            this.coldsElementL3DataTableReport_Date.Namespace = "";
            // 
            // coldsElementL3DataTableUnitTypeID
            // 
            this.coldsElementL3DataTableUnitTypeID.Caption = "UnitTypeID";
            this.coldsElementL3DataTableUnitTypeID.ColumnName = "UnitTypeID";
            this.coldsElementL3DataTableUnitTypeID.DataType = typeof(int);
            this.coldsElementL3DataTableUnitTypeID.Namespace = "";
            // 
            // coldsElementL3DataTableUnitID
            // 
            this.coldsElementL3DataTableUnitID.Caption = "UnitID";
            this.coldsElementL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsElementL3DataTableUnitID.DataType = typeof(int);
            this.coldsElementL3DataTableUnitID.Namespace = "";
            // 
            // coldsElementL3DataTableSample_Address
            // 
            this.coldsElementL3DataTableSample_Address.Caption = "Sample_Address";
            this.coldsElementL3DataTableSample_Address.ColumnName = "Sample_Address";
            this.coldsElementL3DataTableSample_Address.Namespace = "";
            // 
            // coldsElementL3DataTableSample_Type
            // 
            this.coldsElementL3DataTableSample_Type.Caption = "Sample_Type";
            this.coldsElementL3DataTableSample_Type.ColumnName = "Sample_Type";
            this.coldsElementL3DataTableSample_Type.Namespace = "";
            // 
            // coldsElementL3DataTableSample_Count
            // 
            this.coldsElementL3DataTableSample_Count.Caption = "Sample_Count";
            this.coldsElementL3DataTableSample_Count.ColumnName = "Sample_Count";
            this.coldsElementL3DataTableSample_Count.Namespace = "";
            // 
            // coldsElementL3DataTableC
            // 
            this.coldsElementL3DataTableC.Caption = "C";
            this.coldsElementL3DataTableC.ColumnName = "C";
            this.coldsElementL3DataTableC.Namespace = "";
            // 
            // coldsElementL3DataTableSi
            // 
            this.coldsElementL3DataTableSi.Caption = "Si";
            this.coldsElementL3DataTableSi.ColumnName = "Si";
            this.coldsElementL3DataTableSi.Namespace = "";
            // 
            // coldsElementL3DataTableMn
            // 
            this.coldsElementL3DataTableMn.Caption = "Mn";
            this.coldsElementL3DataTableMn.ColumnName = "Mn";
            this.coldsElementL3DataTableMn.Namespace = "";
            // 
            // coldsElementL3DataTableP
            // 
            this.coldsElementL3DataTableP.Caption = "P";
            this.coldsElementL3DataTableP.ColumnName = "P";
            this.coldsElementL3DataTableP.Namespace = "";
            // 
            // coldsElementL3DataTableS
            // 
            this.coldsElementL3DataTableS.Caption = "S";
            this.coldsElementL3DataTableS.ColumnName = "S";
            this.coldsElementL3DataTableS.Namespace = "";
            // 
            // coldsElementL3DataTableCu
            // 
            this.coldsElementL3DataTableCu.Caption = "Cu";
            this.coldsElementL3DataTableCu.ColumnName = "Cu";
            this.coldsElementL3DataTableCu.Namespace = "";
            // 
            // coldsElementL3DataTableNi
            // 
            this.coldsElementL3DataTableNi.Caption = "Ni";
            this.coldsElementL3DataTableNi.ColumnName = "Ni";
            this.coldsElementL3DataTableNi.Namespace = "";
            // 
            // coldsElementL3DataTableCr
            // 
            this.coldsElementL3DataTableCr.Caption = "Cr";
            this.coldsElementL3DataTableCr.ColumnName = "Cr";
            this.coldsElementL3DataTableCr.Namespace = "";
            // 
            // coldsElementL3DataTableMo
            // 
            this.coldsElementL3DataTableMo.Caption = "Mo";
            this.coldsElementL3DataTableMo.ColumnName = "Mo";
            this.coldsElementL3DataTableMo.Namespace = "";
            // 
            // coldsElementL3DataTableV
            // 
            this.coldsElementL3DataTableV.Caption = "V";
            this.coldsElementL3DataTableV.ColumnName = "V";
            this.coldsElementL3DataTableV.Namespace = "";
            // 
            // coldsElementL3DataTableNb
            // 
            this.coldsElementL3DataTableNb.Caption = "Nb";
            this.coldsElementL3DataTableNb.ColumnName = "Nb";
            this.coldsElementL3DataTableNb.Namespace = "";
            // 
            // coldsElementL3DataTableAl
            // 
            this.coldsElementL3DataTableAl.Caption = "Al";
            this.coldsElementL3DataTableAl.ColumnName = "Al";
            this.coldsElementL3DataTableAl.Namespace = "";
            // 
            // coldsElementL3DataTableAlS
            // 
            this.coldsElementL3DataTableAlS.Caption = "AlS";
            this.coldsElementL3DataTableAlS.ColumnName = "AlS";
            this.coldsElementL3DataTableAlS.Namespace = "";
            // 
            // coldsElementL3DataTableTi
            // 
            this.coldsElementL3DataTableTi.Caption = "Ti";
            this.coldsElementL3DataTableTi.ColumnName = "Ti";
            this.coldsElementL3DataTableTi.Namespace = "";
            // 
            // coldsElementL3DataTableB
            // 
            this.coldsElementL3DataTableB.Caption = "B";
            this.coldsElementL3DataTableB.ColumnName = "B";
            this.coldsElementL3DataTableB.Namespace = "";
            // 
            // coldsElementL3DataTableSb
            // 
            this.coldsElementL3DataTableSb.Caption = "Sb";
            this.coldsElementL3DataTableSb.ColumnName = "Sb";
            this.coldsElementL3DataTableSb.Namespace = "";
            // 
            // coldsElementL3DataTableAs
            // 
            this.coldsElementL3DataTableAs.Caption = "As";
            this.coldsElementL3DataTableAs.ColumnName = "As";
            this.coldsElementL3DataTableAs.Namespace = "";
            // 
            // coldsElementL3DataTableSn
            // 
            this.coldsElementL3DataTableSn.Caption = "Sn";
            this.coldsElementL3DataTableSn.ColumnName = "Sn";
            this.coldsElementL3DataTableSn.Namespace = "";
            // 
            // coldsElementL3DataTableZn
            // 
            this.coldsElementL3DataTableZn.Caption = "Zn";
            this.coldsElementL3DataTableZn.ColumnName = "Zn";
            this.coldsElementL3DataTableZn.Namespace = "";
            // 
            // coldsElementL3DataTableCa
            // 
            this.coldsElementL3DataTableCa.Caption = "Ca";
            this.coldsElementL3DataTableCa.ColumnName = "Ca";
            this.coldsElementL3DataTableCa.Namespace = "";
            // 
            // coldsElementL3DataTableW
            // 
            this.coldsElementL3DataTableW.Caption = "W";
            this.coldsElementL3DataTableW.ColumnName = "W";
            this.coldsElementL3DataTableW.Namespace = "";
            // 
            // coldsElementL3DataTablePb
            // 
            this.coldsElementL3DataTablePb.Caption = "Pb";
            this.coldsElementL3DataTablePb.ColumnName = "Pb";
            this.coldsElementL3DataTablePb.Namespace = "";
            // 
            // coldsElementL3DataTableRe
            // 
            this.coldsElementL3DataTableRe.Caption = "Re";
            this.coldsElementL3DataTableRe.ColumnName = "Re";
            this.coldsElementL3DataTableRe.Namespace = "";
            // 
            // coldsElementL3DataTableCeq
            // 
            this.coldsElementL3DataTableCeq.Caption = "Ceq";
            this.coldsElementL3DataTableCeq.ColumnName = "Ceq";
            this.coldsElementL3DataTableCeq.Namespace = "";
            // 
            // coldsElementL3DataTableN
            // 
            this.coldsElementL3DataTableN.Caption = "N";
            this.coldsElementL3DataTableN.ColumnName = "N";
            this.coldsElementL3DataTableN.Namespace = "";
            // 
            // coldsElementL3DataTableH
            // 
            this.coldsElementL3DataTableH.Caption = "H";
            this.coldsElementL3DataTableH.ColumnName = "H";
            this.coldsElementL3DataTableH.Namespace = "";
            // 
            // coldsElementL3DataTableO
            // 
            this.coldsElementL3DataTableO.Caption = "O";
            this.coldsElementL3DataTableO.ColumnName = "O";
            this.coldsElementL3DataTableO.Namespace = "";
            // 
            // coldsElementL3DataTableCrNi
            // 
            this.coldsElementL3DataTableCrNi.Caption = "CrNi";
            this.coldsElementL3DataTableCrNi.ColumnName = "CrNi";
            this.coldsElementL3DataTableCrNi.Namespace = "";
            // 
            // coldsElementL3DataTableCrCu
            // 
            this.coldsElementL3DataTableCrCu.Caption = "CrCu";
            this.coldsElementL3DataTableCrCu.ColumnName = "CrCu";
            this.coldsElementL3DataTableCrCu.Namespace = "";
            // 
            // coldsElementL3DataTableCrNiCu
            // 
            this.coldsElementL3DataTableCrNiCu.Caption = "CrNiCu";
            this.coldsElementL3DataTableCrNiCu.ColumnName = "CrNiCu";
            this.coldsElementL3DataTableCrNiCu.Namespace = "";
            // 
            // coldsElementL3DataTableOther1
            // 
            this.coldsElementL3DataTableOther1.Caption = "Other1";
            this.coldsElementL3DataTableOther1.ColumnName = "Other1";
            this.coldsElementL3DataTableOther1.Namespace = "";
            // 
            // coldsElementL3DataTableOther2
            // 
            this.coldsElementL3DataTableOther2.Caption = "Other2";
            this.coldsElementL3DataTableOther2.ColumnName = "Other2";
            this.coldsElementL3DataTableOther2.Namespace = "";
            // 
            // coldsElementL3DataTableOther3
            // 
            this.coldsElementL3DataTableOther3.Caption = "Other3";
            this.coldsElementL3DataTableOther3.ColumnName = "Other3";
            this.coldsElementL3DataTableOther3.Namespace = "";
            // 
            // coldsElementL3DataTableLogTime
            // 
            this.coldsElementL3DataTableLogTime.Caption = "LogTime";
            this.coldsElementL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsElementL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsElementL3DataTableLogTime.Namespace = "";
            // 
            // coldsElementL3DataTableDataLogMode
            // 
            this.coldsElementL3DataTableDataLogMode.Caption = "DataLogMode";
            this.coldsElementL3DataTableDataLogMode.ColumnName = "DataLogMode";
            this.coldsElementL3DataTableDataLogMode.DataType = typeof(int);
            this.coldsElementL3DataTableDataLogMode.Namespace = "";
            // 
            // coldsElementL3DataTableFinalJudgeFlag
            // 
            this.coldsElementL3DataTableFinalJudgeFlag.Caption = "FinalJudgeFlag";
            this.coldsElementL3DataTableFinalJudgeFlag.ColumnName = "FinalJudgeFlag";
            this.coldsElementL3DataTableFinalJudgeFlag.DataType = typeof(int);
            this.coldsElementL3DataTableFinalJudgeFlag.Namespace = "";
            // 
            // coldsFinalJudgeL3DataTableoperator_lab
            // 
            this.coldsFinalJudgeL3DataTableoperator_lab.Caption = "operator_lab";
            this.coldsFinalJudgeL3DataTableoperator_lab.ColumnName = "operator_lab";
            this.coldsFinalJudgeL3DataTableoperator_lab.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsFinalJudge;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.txtHeatID,
            this.toolStripLabel5,
            this.cmbSteelGradeIndex,
            this.toolStripLabel4,
            this.btnOutput,
            this.btnExport});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1028, 25);
            this.bdN1.TabIndex = 28;
            this.bdN1.Text = "bindingNavigator1";
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel1.Text = " ";
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
            // txtHeatID
            // 
            this.txtHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtHeatID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeatID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "炉号:";
            // 
            // cmbSteelGradeIndex
            // 
            this.cmbSteelGradeIndex.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbSteelGradeIndex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSteelGradeIndex.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.cmbSteelGradeIndex.Name = "cmbSteelGradeIndex";
            this.cmbSteelGradeIndex.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel4.Text = "炼钢记号";
            // 
            // btnOutput
            // 
            this.btnOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(81, 22);
            this.btnExport.Text = "打印送钢卡片";
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.dsUnitType.SourceCondition = "CODE_GROUP = \'UnitType\' ";
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
            this.coldsUnitTypeL3DataTableCode,
            this.coldsUnitTypeL3DataTableCode_Des,
            this.coldsUnitTypeL3DataTableCode_Val_Long});
            this.schemadsUnitType.TableName = "L3DataTable";
            // 
            // coldsUnitTypeL3DataTableCode
            // 
            this.coldsUnitTypeL3DataTableCode.Caption = "Code";
            this.coldsUnitTypeL3DataTableCode.ColumnName = "Code";
            this.coldsUnitTypeL3DataTableCode.Namespace = "";
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
            // coldsElementL3DataTableHeatID
            // 
            this.coldsElementL3DataTableHeatID.Caption = "HeatID";
            this.coldsElementL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsElementL3DataTableHeatID.Namespace = "";
            // 
            // dsProduct
            // 
            this.dsProduct.AutoLoad = true;
            this.dsProduct.AutoSubscribe = false;
            this.dsProduct.DataSetName = "L3DataSet";
            this.dsProduct.DeleteMethod = null;
            this.dsProduct.InsertMethod = null;
            this.dsProduct.L3DataAdapter = this.Adapter;
            this.dsProduct.LoadEvent = "Click";
            this.dsProduct.LoadTrigger = null;
            this.dsProduct.RefreshValve = 1000;
            this.dsProduct.SourceCommand = null;
            this.dsProduct.SourceCondition = "";
            this.dsProduct.SourceMethod = "";
            this.dsProduct.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProduct.SourceURI = "XGMESLogic\\QualityMag\\CQA_Product_Sheet";
            this.dsProduct.SubscribeTarget = null;
            this.dsProduct.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsProduct.UpdateEvent = "Click";
            this.dsProduct.UpdateMethod = null;
            this.dsProduct.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableSteelGradeIndex,
            this.coll3DataSet1L3DataTableC_Max,
            this.coll3DataSet1L3DataTableSi_Max,
            this.coll3DataSet1L3DataTableMn_Max,
            this.coll3DataSet1L3DataTableP_Max,
            this.coll3DataSet1L3DataTableS_Max,
            this.coll3DataSet1L3DataTableCu_Max,
            this.coll3DataSet1L3DataTableNi_Max,
            this.coll3DataSet1L3DataTableCr_Max,
            this.coll3DataSet1L3DataTableMo_Max,
            this.coll3DataSet1L3DataTableV_Max,
            this.coll3DataSet1L3DataTableNb_Max,
            this.coll3DataSet1L3DataTableAl_Max,
            this.coll3DataSet1L3DataTableAlS_Max,
            this.coll3DataSet1L3DataTableTi_Max,
            this.coll3DataSet1L3DataTableB_Max,
            this.coll3DataSet1L3DataTableSb_Max,
            this.coll3DataSet1L3DataTableSn_Max,
            this.coll3DataSet1L3DataTableAs_Max,
            this.coll3DataSet1L3DataTableZn_Max,
            this.coll3DataSet1L3DataTableZr_Max,
            this.coll3DataSet1L3DataTableCa_Max,
            this.coll3DataSet1L3DataTableW_Max,
            this.coll3DataSet1L3DataTablePb_Max,
            this.coll3DataSet1L3DataTableRe_Max,
            this.coll3DataSet1L3DataTableCeq_Max,
            this.coll3DataSet1L3DataTableN_Max,
            this.coll3DataSet1L3DataTableH_Max,
            this.coll3DataSet1L3DataTableO_Max,
            this.coll3DataSet1L3DataTableCrNi_Max,
            this.coll3DataSet1L3DataTableCrCu_Max,
            this.coll3DataSet1L3DataTableCrNiCu_Max,
            this.coll3DataSet1L3DataTableOther1_Max,
            this.coll3DataSet1L3DataTableOther2_Max,
            this.coll3DataSet1L3DataTableOther3_Max});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableSteelGradeIndex
            // 
            this.coll3DataSet1L3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coll3DataSet1L3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coll3DataSet1L3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coll3DataSet1L3DataTableC_Max
            // 
            this.coll3DataSet1L3DataTableC_Max.Caption = "C_Max";
            this.coll3DataSet1L3DataTableC_Max.ColumnName = "C_Max";
            this.coll3DataSet1L3DataTableC_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSi_Max
            // 
            this.coll3DataSet1L3DataTableSi_Max.Caption = "Si_Max";
            this.coll3DataSet1L3DataTableSi_Max.ColumnName = "Si_Max";
            this.coll3DataSet1L3DataTableSi_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableMn_Max
            // 
            this.coll3DataSet1L3DataTableMn_Max.Caption = "Mn_Max";
            this.coll3DataSet1L3DataTableMn_Max.ColumnName = "Mn_Max";
            this.coll3DataSet1L3DataTableMn_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableP_Max
            // 
            this.coll3DataSet1L3DataTableP_Max.Caption = "P_Max";
            this.coll3DataSet1L3DataTableP_Max.ColumnName = "P_Max";
            this.coll3DataSet1L3DataTableP_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableS_Max
            // 
            this.coll3DataSet1L3DataTableS_Max.Caption = "S_Max";
            this.coll3DataSet1L3DataTableS_Max.ColumnName = "S_Max";
            this.coll3DataSet1L3DataTableS_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCu_Max
            // 
            this.coll3DataSet1L3DataTableCu_Max.Caption = "Cu_Max";
            this.coll3DataSet1L3DataTableCu_Max.ColumnName = "Cu_Max";
            this.coll3DataSet1L3DataTableCu_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableNi_Max
            // 
            this.coll3DataSet1L3DataTableNi_Max.Caption = "Ni_Max";
            this.coll3DataSet1L3DataTableNi_Max.ColumnName = "Ni_Max";
            this.coll3DataSet1L3DataTableNi_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCr_Max
            // 
            this.coll3DataSet1L3DataTableCr_Max.Caption = "Cr_Max";
            this.coll3DataSet1L3DataTableCr_Max.ColumnName = "Cr_Max";
            this.coll3DataSet1L3DataTableCr_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableMo_Max
            // 
            this.coll3DataSet1L3DataTableMo_Max.Caption = "Mo_Max";
            this.coll3DataSet1L3DataTableMo_Max.ColumnName = "Mo_Max";
            this.coll3DataSet1L3DataTableMo_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableV_Max
            // 
            this.coll3DataSet1L3DataTableV_Max.Caption = "V_Max";
            this.coll3DataSet1L3DataTableV_Max.ColumnName = "V_Max";
            this.coll3DataSet1L3DataTableV_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableNb_Max
            // 
            this.coll3DataSet1L3DataTableNb_Max.Caption = "Nb_Max";
            this.coll3DataSet1L3DataTableNb_Max.ColumnName = "Nb_Max";
            this.coll3DataSet1L3DataTableNb_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAl_Max
            // 
            this.coll3DataSet1L3DataTableAl_Max.Caption = "Al_Max";
            this.coll3DataSet1L3DataTableAl_Max.ColumnName = "Al_Max";
            this.coll3DataSet1L3DataTableAl_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAlS_Max
            // 
            this.coll3DataSet1L3DataTableAlS_Max.Caption = "AlS_Max";
            this.coll3DataSet1L3DataTableAlS_Max.ColumnName = "AlS_Max";
            this.coll3DataSet1L3DataTableAlS_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableTi_Max
            // 
            this.coll3DataSet1L3DataTableTi_Max.Caption = "Ti_Max";
            this.coll3DataSet1L3DataTableTi_Max.ColumnName = "Ti_Max";
            this.coll3DataSet1L3DataTableTi_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableB_Max
            // 
            this.coll3DataSet1L3DataTableB_Max.Caption = "B_Max";
            this.coll3DataSet1L3DataTableB_Max.ColumnName = "B_Max";
            this.coll3DataSet1L3DataTableB_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSb_Max
            // 
            this.coll3DataSet1L3DataTableSb_Max.Caption = "Sb_Max";
            this.coll3DataSet1L3DataTableSb_Max.ColumnName = "Sb_Max";
            this.coll3DataSet1L3DataTableSb_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSn_Max
            // 
            this.coll3DataSet1L3DataTableSn_Max.Caption = "Sn_Max";
            this.coll3DataSet1L3DataTableSn_Max.ColumnName = "Sn_Max";
            this.coll3DataSet1L3DataTableSn_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableAs_Max
            // 
            this.coll3DataSet1L3DataTableAs_Max.Caption = "As_Max";
            this.coll3DataSet1L3DataTableAs_Max.ColumnName = "As_Max";
            this.coll3DataSet1L3DataTableAs_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableZn_Max
            // 
            this.coll3DataSet1L3DataTableZn_Max.Caption = "Zn_Max";
            this.coll3DataSet1L3DataTableZn_Max.ColumnName = "Zn_Max";
            this.coll3DataSet1L3DataTableZn_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableZr_Max
            // 
            this.coll3DataSet1L3DataTableZr_Max.Caption = "Zr_Max";
            this.coll3DataSet1L3DataTableZr_Max.ColumnName = "Zr_Max";
            this.coll3DataSet1L3DataTableZr_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCa_Max
            // 
            this.coll3DataSet1L3DataTableCa_Max.Caption = "Ca_Max";
            this.coll3DataSet1L3DataTableCa_Max.ColumnName = "Ca_Max";
            this.coll3DataSet1L3DataTableCa_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableW_Max
            // 
            this.coll3DataSet1L3DataTableW_Max.Caption = "W_Max";
            this.coll3DataSet1L3DataTableW_Max.ColumnName = "W_Max";
            this.coll3DataSet1L3DataTableW_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTablePb_Max
            // 
            this.coll3DataSet1L3DataTablePb_Max.Caption = "Pb_Max";
            this.coll3DataSet1L3DataTablePb_Max.ColumnName = "Pb_Max";
            this.coll3DataSet1L3DataTablePb_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableRe_Max
            // 
            this.coll3DataSet1L3DataTableRe_Max.Caption = "Re_Max";
            this.coll3DataSet1L3DataTableRe_Max.ColumnName = "Re_Max";
            this.coll3DataSet1L3DataTableRe_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCeq_Max
            // 
            this.coll3DataSet1L3DataTableCeq_Max.Caption = "Ceq_Max";
            this.coll3DataSet1L3DataTableCeq_Max.ColumnName = "Ceq_Max";
            this.coll3DataSet1L3DataTableCeq_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableN_Max
            // 
            this.coll3DataSet1L3DataTableN_Max.Caption = "N_Max";
            this.coll3DataSet1L3DataTableN_Max.ColumnName = "N_Max";
            this.coll3DataSet1L3DataTableN_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableH_Max
            // 
            this.coll3DataSet1L3DataTableH_Max.Caption = "H_Max";
            this.coll3DataSet1L3DataTableH_Max.ColumnName = "H_Max";
            this.coll3DataSet1L3DataTableH_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableO_Max
            // 
            this.coll3DataSet1L3DataTableO_Max.Caption = "O_Max";
            this.coll3DataSet1L3DataTableO_Max.ColumnName = "O_Max";
            this.coll3DataSet1L3DataTableO_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCrNi_Max
            // 
            this.coll3DataSet1L3DataTableCrNi_Max.Caption = "CrNi_Max";
            this.coll3DataSet1L3DataTableCrNi_Max.ColumnName = "CrNi_Max";
            this.coll3DataSet1L3DataTableCrNi_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCrCu_Max
            // 
            this.coll3DataSet1L3DataTableCrCu_Max.Caption = "CrCu_Max";
            this.coll3DataSet1L3DataTableCrCu_Max.ColumnName = "CrCu_Max";
            this.coll3DataSet1L3DataTableCrCu_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCrNiCu_Max
            // 
            this.coll3DataSet1L3DataTableCrNiCu_Max.Caption = "CrNiCu_Max";
            this.coll3DataSet1L3DataTableCrNiCu_Max.ColumnName = "CrNiCu_Max";
            this.coll3DataSet1L3DataTableCrNiCu_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther1_Max
            // 
            this.coll3DataSet1L3DataTableOther1_Max.Caption = "Other1_Max";
            this.coll3DataSet1L3DataTableOther1_Max.ColumnName = "Other1_Max";
            this.coll3DataSet1L3DataTableOther1_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther2_Max
            // 
            this.coll3DataSet1L3DataTableOther2_Max.Caption = "Other2_Max";
            this.coll3DataSet1L3DataTableOther2_Max.ColumnName = "Other2_Max";
            this.coll3DataSet1L3DataTableOther2_Max.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther3_Max
            // 
            this.coll3DataSet1L3DataTableOther3_Max.Caption = "Other3_Max";
            this.coll3DataSet1L3DataTableOther3_Max.ColumnName = "Other3_Max";
            this.coll3DataSet1L3DataTableOther3_Max.Namespace = "";
            // 
            // dsID
            // 
            this.dsID.AutoLoad = true;
            this.dsID.AutoSubscribe = false;
            this.dsID.DataSetName = "L3DataSet";
            this.dsID.DeleteMethod = null;
            this.dsID.InsertMethod = null;
            this.dsID.L3DataAdapter = this.Adapter;
            this.dsID.LoadEvent = "Click";
            this.dsID.LoadTrigger = null;
            this.dsID.RefreshValve = 1000;
            this.dsID.SourceCommand = null;
            this.dsID.SourceCondition = "";
            this.dsID.SourceMethod = "";
            this.dsID.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsID.SourceURI = "";
            this.dsID.SubscribeTarget = null;
            this.dsID.UpdateEvent = "Click";
            this.dsID.UpdateMethod = null;
            this.dsID.UpdateTrigger = null;
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
            this.dsSteelGradeIndex.SourceCondition = null;
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
            // SteelWaterToBXGJudgeQueryFrm
            // 
            this.Adapter.SetAccessRight(this, "BofSteelWaterToBXGJudgeQuery");
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "SteelWaterToBXGJudgeQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "转炉钢水直送不锈钢质量判定查询";
            this.Text = "转炉钢水直送不锈钢质量判定查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HeatFinalJudgeQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.InStoreQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFinalJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWasterReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWasterReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWrongReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWrongReason3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinalJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinalJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGradeIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGradeIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsFinalJudge;
        private AppSvrHMI.L3DataSet dsFinalJudge;
        private System.Data.DataTable schemal3DataSet9;
        private System.Data.DataColumn coll3DataSet9L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet9L3DataTableName;
        private System.Data.DataColumn coll3DataSet9L3DataTableOperator;
        private System.Data.DataColumn coll3DataSet9L3DataTableShift;
        private System.Data.DataColumn coll3DataSet9L3DataTableTeam;
        private System.Data.DataColumn coldsHotJudgeL3DataTableHeatID;
        private System.Data.DataColumn coldsHotJudgeL3DataTableCasterID;
        private System.Data.DataColumn coldsHotJudgeL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsHotJudgeL3DataTableLength;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWidth;
        private System.Data.DataColumn coldsHotJudgeL3DataTableThickness;
        private System.Data.DataColumn coldsHotJudgeL3DataTableBloom_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableCal_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableRight_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableRight_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Reason1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Reason2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Count3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Weight3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWaster_Reason3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Reason1;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Reason2;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Count3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Weight3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableWrong_Reason3;
        private System.Data.DataColumn coldsHotJudgeL3DataTableSufaceDefactDes;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsCaster;
        private System.Data.DataTable schemadsCaster;
        private System.Data.DataColumn coldsCasterL3DataTableCode;
        private System.Data.DataColumn coldsCasterL3DataTableCode_Des;
        private System.Data.DataColumn coldsFinalJudgeL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableCut_SteelGradeIndex;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableFinal_SteelGradeIndex;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableFinishedTime;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableFinalJudge_Time;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableProcess_Type;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableDecide_Code;
        private System.Windows.Forms.BindingSource bsWrongReason3;
        private AppSvrHMI.L3DataSet dsWrongReason;
        private System.Data.DataTable schemadsWrongReason;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode;
        private System.Data.DataColumn coldsWrongReasonL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsWrongReason2;
        private System.Windows.Forms.BindingSource bsWrongReason1;
        private System.Windows.Forms.BindingSource bsWasterReason3;
        private AppSvrHMI.L3DataSet dsWasterReason;
        private System.Data.DataTable schemadsWasterReason;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode;
        private System.Data.DataColumn coldsWasterReasonL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsWasterReason2;
        private System.Windows.Forms.BindingSource bsWasterReason1;
        private System.Windows.Forms.ToolStripComboBox cmbSteelGradeIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox txtHeatID;
        private System.Windows.Forms.DataGridView dvFinalJudge;
        private System.Data.DataColumn coldsElementL3DataTableReport_Date;
        private System.Data.DataColumn coldsElementL3DataTableHeatID;
        private System.Data.DataColumn coldsElementL3DataTableUnitTypeID;
        private System.Data.DataColumn coldsElementL3DataTableUnitID;
        private System.Data.DataColumn coldsElementL3DataTableSample_Address;
        private System.Data.DataColumn coldsElementL3DataTableSample_Type;
        private System.Data.DataColumn coldsElementL3DataTableSample_Count;
        private System.Data.DataColumn coldsElementL3DataTableC;
        private System.Data.DataColumn coldsElementL3DataTableSi;
        private System.Data.DataColumn coldsElementL3DataTableMn;
        private System.Data.DataColumn coldsElementL3DataTableP;
        private System.Data.DataColumn coldsElementL3DataTableS;
        private System.Data.DataColumn coldsElementL3DataTableCu;
        private System.Data.DataColumn coldsElementL3DataTableNi;
        private System.Data.DataColumn coldsElementL3DataTableCr;
        private System.Data.DataColumn coldsElementL3DataTableMo;
        private System.Data.DataColumn coldsElementL3DataTableV;
        private System.Data.DataColumn coldsElementL3DataTableNb;
        private System.Data.DataColumn coldsElementL3DataTableAl;
        private System.Data.DataColumn coldsElementL3DataTableAlS;
        private System.Data.DataColumn coldsElementL3DataTableTi;
        private System.Data.DataColumn coldsElementL3DataTableB;
        private System.Data.DataColumn coldsElementL3DataTableSb;
        private System.Data.DataColumn coldsElementL3DataTableAs;
        private System.Data.DataColumn coldsElementL3DataTableSn;
        private System.Data.DataColumn coldsElementL3DataTableZn;
        private System.Data.DataColumn coldsElementL3DataTableCa;
        private System.Data.DataColumn coldsElementL3DataTableW;
        private System.Data.DataColumn coldsElementL3DataTablePb;
        private System.Data.DataColumn coldsElementL3DataTableRe;
        private System.Data.DataColumn coldsElementL3DataTableCeq;
        private System.Data.DataColumn coldsElementL3DataTableN;
        private System.Data.DataColumn coldsElementL3DataTableH;
        private System.Data.DataColumn coldsElementL3DataTableO;
        private System.Data.DataColumn coldsElementL3DataTableCrNi;
        private System.Data.DataColumn coldsElementL3DataTableCrCu;
        private System.Data.DataColumn coldsElementL3DataTableCrNiCu;
        private System.Data.DataColumn coldsElementL3DataTableOther1;
        private System.Data.DataColumn coldsElementL3DataTableOther2;
        private System.Data.DataColumn coldsElementL3DataTableOther3;
        private System.Data.DataColumn coldsElementL3DataTableLogTime;
        private System.Data.DataColumn coldsElementL3DataTableDataLogMode;
        private System.Data.DataColumn coldsElementL3DataTableFinalJudgeFlag;
        private AppSvrHMI.L3DataSet dsUnitType;
        private AppSvrHMI.L3DataSet dsSampleType;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsUnitType;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsUnitTypeL3DataTableCode_Val_Long;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableAppID;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableSample_Code;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableArrive_Date;
        private System.Windows.Forms.ToolStripButton btnExport;
        private AppSvrHMI.L3DataSet dsProduct;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableSteelGradeIndex;
        private System.Data.DataColumn coll3DataSet1L3DataTableC_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableSi_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableMn_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableP_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableS_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableCu_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableNi_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableCr_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableMo_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableV_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableNb_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableAl_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableAlS_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableTi_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableB_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableSb_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableSn_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableAs_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableZn_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableZr_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableCa_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableW_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTablePb_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableRe_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableCeq_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableN_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableH_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableO_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableCrNi_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableCrCu_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableCrNiCu_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther1_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther2_Max;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther3_Max;
        private System.Data.DataColumn coldsFinalJudgeL3DataTableoperator_lab;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeatID;
        private System.Windows.Forms.DataGridViewComboBoxColumn casterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloomCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wasterWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wasterReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongCount3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrongWeight3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wrongReason3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sufaceDefactDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalJudgeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decideCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sample_Address;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sample_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sample_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn Si;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mn;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mo;
        private System.Windows.Forms.DataGridViewTextBoxColumn V;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Al;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ti;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sb;
        private System.Windows.Forms.DataGridViewTextBoxColumn As;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Re;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ceq;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.DataGridViewTextBoxColumn O;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrNiCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other3;
        private System.Windows.Forms.DataGridViewTextBoxColumn operator_lab;
        private AppSvrHMI.L3DataSet dsID;
        private AppSvrHMI.L3DataSet dsSteelGradeIndex;
        private System.Data.DataTable schemadsSteelGradeIndex;
        private System.Data.DataColumn coldsSteelGradeIndexL3DataTableSteelGradeIndex;
    }
}