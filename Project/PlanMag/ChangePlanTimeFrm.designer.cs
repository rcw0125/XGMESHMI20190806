namespace PlanMag
{
    partial class ChangePlanTimeFrm
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
            this.bsTapping = new System.Windows.Forms.BindingSource(this.components);
            this.dsTapping = new AppSvrHMI.L3DataSet();
            this.schemadsGrid1 = new System.Data.DataTable();
            this.coldsGrid1L3DataTableGUID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableName = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePlanID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableContractID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableStatus = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePlanDept = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableExecuteDept = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableCreateDate = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePlanExecuteDate = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableActualExecuteDate = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePlanner = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePre_LotNo = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePre_SteelGrade = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Tapped_Weight = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableCasterID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableBOFID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableLFID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableRHID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableBOF_Status = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableLF_Status = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableRH_Status = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableCaster_Status = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableSide_Status = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableHeatID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableCasting_No = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableCasting_Heat_Cnt = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_IronPrepared = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_BOFStart = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_BOFTapped = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_TappedSideEnd = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_LFArrival = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_LFStart = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_LFEnd = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_LFLeave = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_RHArrival = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_RHStart = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_RHEnd = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_RHLeave = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_CasterArrival = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_CastingStart = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableAim_Time_CastingEnd = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableFir_Heat_Flag = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableDiv_HeatID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableTeamID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableShiftID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsGrid1L3DataTablePlan_Ord_ID = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableSteel_Return_Flag = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableSteel_Back_Flag = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableTreat_Seq = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableDestitation = new System.Data.DataColumn();
            this.coldsGrid1L3DataTableNew_BOF_Flag = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbSteelGradeIndex = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dvActTimeCastingEnd = new System.Windows.Forms.DateTimePicker();
            this.dvActTimeCastingStart = new System.Windows.Forms.DateTimePicker();
            this.dvActTimeCasterArrival = new System.Windows.Forms.DateTimePicker();
            this.dtActTimeRHStart = new System.Windows.Forms.DateTimePicker();
            this.dtActTimeBOFTapped = new System.Windows.Forms.DateTimePicker();
            this.dtActTimeLFStart = new System.Windows.Forms.DateTimePicker();
            this.dtActTimeBOFStart = new System.Windows.Forms.DateTimePicker();
            this.dtActTimeTappedSideEnd = new System.Windows.Forms.DateTimePicker();
            this.dtActTimeIronPrepared = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tptime = new System.Windows.Forms.TabPage();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCastingTime = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtCasterWaitTime = new PxDataValid.PxTextBox();
            this.txtLFTime = new PxDataValid.PxTextBox();
            this.txtRHTime = new PxDataValid.PxTextBox();
            this.txtTippedSideTime = new PxDataValid.PxTextBox();
            this.txtStartToEndTime = new PxDataValid.PxTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmdChangePlanTime = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tptime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTapping
            // 
            this.bsTapping.DataMember = "L3DataTable";
            this.bsTapping.DataSource = this.dsTapping;
            // 
            // dsTapping
            // 
            this.dsTapping.DataSetName = "L3DataSet";
            this.dsTapping.DeleteMethod = null;
            this.dsTapping.InsertMethod = null;
            this.dsTapping.L3DataAdapter = null;
            this.dsTapping.LoadEvent = "Click";
            this.dsTapping.LoadTrigger = null;
            this.dsTapping.RefreshValve = 1000;
            this.dsTapping.SourceCommand = null;
            this.dsTapping.SourceCondition = "";
            this.dsTapping.SourceMethod = "";
            this.dsTapping.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsTapping.SourceURI = "";
            this.dsTapping.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGrid1});
            this.dsTapping.UpdateEvent = "Click";
            this.dsTapping.UpdateMethod = null;
            this.dsTapping.UpdateTrigger = null;
            // 
            // schemadsGrid1
            // 
            this.schemadsGrid1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGrid1L3DataTableGUID,
            this.coldsGrid1L3DataTableName,
            this.coldsGrid1L3DataTablePlanID,
            this.coldsGrid1L3DataTableContractID,
            this.coldsGrid1L3DataTableStatus,
            this.coldsGrid1L3DataTablePlanDept,
            this.coldsGrid1L3DataTableExecuteDept,
            this.coldsGrid1L3DataTableCreateDate,
            this.coldsGrid1L3DataTablePlanExecuteDate,
            this.coldsGrid1L3DataTableActualExecuteDate,
            this.coldsGrid1L3DataTablePlanner,
            this.coldsGrid1L3DataTablePre_LotNo,
            this.coldsGrid1L3DataTablePreHeatID,
            this.coldsGrid1L3DataTablePre_SteelGradeIndex,
            this.coldsGrid1L3DataTablePre_SteelGrade,
            this.coldsGrid1L3DataTableAim_Tapped_Weight,
            this.coldsGrid1L3DataTableCasterID,
            this.coldsGrid1L3DataTableBOFID,
            this.coldsGrid1L3DataTableLFID,
            this.coldsGrid1L3DataTableRHID,
            this.coldsGrid1L3DataTableBOF_Status,
            this.coldsGrid1L3DataTableLF_Status,
            this.coldsGrid1L3DataTableRH_Status,
            this.coldsGrid1L3DataTableCaster_Status,
            this.coldsGrid1L3DataTableSide_Status,
            this.coldsGrid1L3DataTableHeatID,
            this.coldsGrid1L3DataTableCasting_No,
            this.coldsGrid1L3DataTableCasting_Heat_Cnt,
            this.coldsGrid1L3DataTableAim_Time_IronPrepared,
            this.coldsGrid1L3DataTableAim_Time_BOFStart,
            this.coldsGrid1L3DataTableAim_Time_BOFTapped,
            this.coldsGrid1L3DataTableAim_Time_TappedSideEnd,
            this.coldsGrid1L3DataTableAim_Time_LFArrival,
            this.coldsGrid1L3DataTableAim_Time_LFStart,
            this.coldsGrid1L3DataTableAim_Time_LFEnd,
            this.coldsGrid1L3DataTableAim_Time_LFLeave,
            this.coldsGrid1L3DataTableAim_Time_RHArrival,
            this.coldsGrid1L3DataTableAim_Time_RHStart,
            this.coldsGrid1L3DataTableAim_Time_RHEnd,
            this.coldsGrid1L3DataTableAim_Time_RHLeave,
            this.coldsGrid1L3DataTableAim_Time_CasterArrival,
            this.coldsGrid1L3DataTableAim_Time_CastingStart,
            this.coldsGrid1L3DataTableAim_Time_CastingEnd,
            this.coldsGrid1L3DataTableFir_Heat_Flag,
            this.coldsGrid1L3DataTableDiv_HeatID,
            this.coldsGrid1L3DataTableTeamID,
            this.coldsGrid1L3DataTableShiftID,
            this.coldsGrid1L3DataTableSteelGradeIndex,
            this.coldsGrid1L3DataTableSteelGrade,
            this.coldsGrid1L3DataTablePlan_Ord_ID,
            this.coldsGrid1L3DataTableHot_Send_Flag,
            this.coldsGrid1L3DataTableSteel_Return_Flag,
            this.coldsGrid1L3DataTableSteel_Back_Flag,
            this.coldsGrid1L3DataTableTreat_Seq,
            this.coldsGrid1L3DataTableDestitation,
            this.coldsGrid1L3DataTableNew_BOF_Flag});
            this.schemadsGrid1.TableName = "L3DataTable";
            // 
            // coldsGrid1L3DataTableGUID
            // 
            this.coldsGrid1L3DataTableGUID.Caption = "GUID";
            this.coldsGrid1L3DataTableGUID.ColumnName = "GUID";
            this.coldsGrid1L3DataTableGUID.Namespace = "";
            // 
            // coldsGrid1L3DataTableName
            // 
            this.coldsGrid1L3DataTableName.Caption = "Name";
            this.coldsGrid1L3DataTableName.ColumnName = "Name";
            this.coldsGrid1L3DataTableName.Namespace = "";
            // 
            // coldsGrid1L3DataTablePlanID
            // 
            this.coldsGrid1L3DataTablePlanID.Caption = "PlanID";
            this.coldsGrid1L3DataTablePlanID.ColumnName = "PlanID";
            this.coldsGrid1L3DataTablePlanID.Namespace = "";
            // 
            // coldsGrid1L3DataTableContractID
            // 
            this.coldsGrid1L3DataTableContractID.Caption = "ContractID";
            this.coldsGrid1L3DataTableContractID.ColumnName = "ContractID";
            this.coldsGrid1L3DataTableContractID.Namespace = "";
            // 
            // coldsGrid1L3DataTableStatus
            // 
            this.coldsGrid1L3DataTableStatus.Caption = "Status";
            this.coldsGrid1L3DataTableStatus.ColumnName = "Status";
            this.coldsGrid1L3DataTableStatus.DataType = typeof(int);
            this.coldsGrid1L3DataTableStatus.Namespace = "";
            // 
            // coldsGrid1L3DataTablePlanDept
            // 
            this.coldsGrid1L3DataTablePlanDept.Caption = "PlanDept";
            this.coldsGrid1L3DataTablePlanDept.ColumnName = "PlanDept";
            this.coldsGrid1L3DataTablePlanDept.Namespace = "";
            // 
            // coldsGrid1L3DataTableExecuteDept
            // 
            this.coldsGrid1L3DataTableExecuteDept.Caption = "ExecuteDept";
            this.coldsGrid1L3DataTableExecuteDept.ColumnName = "ExecuteDept";
            this.coldsGrid1L3DataTableExecuteDept.Namespace = "";
            // 
            // coldsGrid1L3DataTableCreateDate
            // 
            this.coldsGrid1L3DataTableCreateDate.Caption = "CreateDate";
            this.coldsGrid1L3DataTableCreateDate.ColumnName = "CreateDate";
            this.coldsGrid1L3DataTableCreateDate.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableCreateDate.Namespace = "";
            // 
            // coldsGrid1L3DataTablePlanExecuteDate
            // 
            this.coldsGrid1L3DataTablePlanExecuteDate.Caption = "PlanExecuteDate";
            this.coldsGrid1L3DataTablePlanExecuteDate.ColumnName = "PlanExecuteDate";
            this.coldsGrid1L3DataTablePlanExecuteDate.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTablePlanExecuteDate.Namespace = "";
            // 
            // coldsGrid1L3DataTableActualExecuteDate
            // 
            this.coldsGrid1L3DataTableActualExecuteDate.Caption = "ActualExecuteDate";
            this.coldsGrid1L3DataTableActualExecuteDate.ColumnName = "ActualExecuteDate";
            this.coldsGrid1L3DataTableActualExecuteDate.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableActualExecuteDate.Namespace = "";
            // 
            // coldsGrid1L3DataTablePlanner
            // 
            this.coldsGrid1L3DataTablePlanner.Caption = "Planner";
            this.coldsGrid1L3DataTablePlanner.ColumnName = "Planner";
            this.coldsGrid1L3DataTablePlanner.Namespace = "";
            // 
            // coldsGrid1L3DataTablePre_LotNo
            // 
            this.coldsGrid1L3DataTablePre_LotNo.Caption = "Pre_LotNo";
            this.coldsGrid1L3DataTablePre_LotNo.ColumnName = "Pre_LotNo";
            this.coldsGrid1L3DataTablePre_LotNo.Namespace = "";
            // 
            // coldsGrid1L3DataTablePreHeatID
            // 
            this.coldsGrid1L3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsGrid1L3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsGrid1L3DataTablePreHeatID.Namespace = "";
            // 
            // coldsGrid1L3DataTablePre_SteelGradeIndex
            // 
            this.coldsGrid1L3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsGrid1L3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsGrid1L3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsGrid1L3DataTablePre_SteelGrade
            // 
            this.coldsGrid1L3DataTablePre_SteelGrade.Caption = "Pre_SteelGrade";
            this.coldsGrid1L3DataTablePre_SteelGrade.ColumnName = "Pre_SteelGrade";
            this.coldsGrid1L3DataTablePre_SteelGrade.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Tapped_Weight
            // 
            this.coldsGrid1L3DataTableAim_Tapped_Weight.Caption = "Aim_Tapped_Weight";
            this.coldsGrid1L3DataTableAim_Tapped_Weight.ColumnName = "Aim_Tapped_Weight";
            this.coldsGrid1L3DataTableAim_Tapped_Weight.DataType = typeof(double);
            this.coldsGrid1L3DataTableAim_Tapped_Weight.Namespace = "";
            // 
            // coldsGrid1L3DataTableCasterID
            // 
            this.coldsGrid1L3DataTableCasterID.Caption = "CasterID";
            this.coldsGrid1L3DataTableCasterID.ColumnName = "CasterID";
            this.coldsGrid1L3DataTableCasterID.Namespace = "";
            // 
            // coldsGrid1L3DataTableBOFID
            // 
            this.coldsGrid1L3DataTableBOFID.Caption = "BOFID";
            this.coldsGrid1L3DataTableBOFID.ColumnName = "BOFID";
            this.coldsGrid1L3DataTableBOFID.Namespace = "";
            // 
            // coldsGrid1L3DataTableLFID
            // 
            this.coldsGrid1L3DataTableLFID.Caption = "LFID";
            this.coldsGrid1L3DataTableLFID.ColumnName = "LFID";
            this.coldsGrid1L3DataTableLFID.Namespace = "";
            // 
            // coldsGrid1L3DataTableRHID
            // 
            this.coldsGrid1L3DataTableRHID.Caption = "RHID";
            this.coldsGrid1L3DataTableRHID.ColumnName = "RHID";
            this.coldsGrid1L3DataTableRHID.Namespace = "";
            // 
            // coldsGrid1L3DataTableBOF_Status
            // 
            this.coldsGrid1L3DataTableBOF_Status.Caption = "BOF_Status";
            this.coldsGrid1L3DataTableBOF_Status.ColumnName = "BOF_Status";
            this.coldsGrid1L3DataTableBOF_Status.Namespace = "";
            // 
            // coldsGrid1L3DataTableLF_Status
            // 
            this.coldsGrid1L3DataTableLF_Status.Caption = "LF_Status";
            this.coldsGrid1L3DataTableLF_Status.ColumnName = "LF_Status";
            this.coldsGrid1L3DataTableLF_Status.Namespace = "";
            // 
            // coldsGrid1L3DataTableRH_Status
            // 
            this.coldsGrid1L3DataTableRH_Status.Caption = "RH_Status";
            this.coldsGrid1L3DataTableRH_Status.ColumnName = "RH_Status";
            this.coldsGrid1L3DataTableRH_Status.Namespace = "";
            // 
            // coldsGrid1L3DataTableCaster_Status
            // 
            this.coldsGrid1L3DataTableCaster_Status.Caption = "Caster_Status";
            this.coldsGrid1L3DataTableCaster_Status.ColumnName = "Caster_Status";
            this.coldsGrid1L3DataTableCaster_Status.Namespace = "";
            // 
            // coldsGrid1L3DataTableSide_Status
            // 
            this.coldsGrid1L3DataTableSide_Status.Caption = "Side_Status";
            this.coldsGrid1L3DataTableSide_Status.ColumnName = "Side_Status";
            this.coldsGrid1L3DataTableSide_Status.Namespace = "";
            // 
            // coldsGrid1L3DataTableHeatID
            // 
            this.coldsGrid1L3DataTableHeatID.Caption = "HeatID";
            this.coldsGrid1L3DataTableHeatID.ColumnName = "HeatID";
            this.coldsGrid1L3DataTableHeatID.Namespace = "";
            // 
            // coldsGrid1L3DataTableCasting_No
            // 
            this.coldsGrid1L3DataTableCasting_No.Caption = "Casting_No";
            this.coldsGrid1L3DataTableCasting_No.ColumnName = "Casting_No";
            this.coldsGrid1L3DataTableCasting_No.Namespace = "";
            // 
            // coldsGrid1L3DataTableCasting_Heat_Cnt
            // 
            this.coldsGrid1L3DataTableCasting_Heat_Cnt.Caption = "Casting_Heat_Cnt";
            this.coldsGrid1L3DataTableCasting_Heat_Cnt.ColumnName = "Casting_Heat_Cnt";
            this.coldsGrid1L3DataTableCasting_Heat_Cnt.DataType = typeof(int);
            this.coldsGrid1L3DataTableCasting_Heat_Cnt.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_IronPrepared
            // 
            this.coldsGrid1L3DataTableAim_Time_IronPrepared.Caption = "Aim_Time_IronPrepared";
            this.coldsGrid1L3DataTableAim_Time_IronPrepared.ColumnName = "Aim_Time_IronPrepared";
            this.coldsGrid1L3DataTableAim_Time_IronPrepared.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_IronPrepared.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_BOFStart
            // 
            this.coldsGrid1L3DataTableAim_Time_BOFStart.Caption = "Aim_Time_BOFStart";
            this.coldsGrid1L3DataTableAim_Time_BOFStart.ColumnName = "Aim_Time_BOFStart";
            this.coldsGrid1L3DataTableAim_Time_BOFStart.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_BOFStart.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_BOFTapped
            // 
            this.coldsGrid1L3DataTableAim_Time_BOFTapped.Caption = "Aim_Time_BOFTapped";
            this.coldsGrid1L3DataTableAim_Time_BOFTapped.ColumnName = "Aim_Time_BOFTapped";
            this.coldsGrid1L3DataTableAim_Time_BOFTapped.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_BOFTapped.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_TappedSideEnd
            // 
            this.coldsGrid1L3DataTableAim_Time_TappedSideEnd.Caption = "Aim_Time_TappedSideEnd";
            this.coldsGrid1L3DataTableAim_Time_TappedSideEnd.ColumnName = "Aim_Time_TappedSideEnd";
            this.coldsGrid1L3DataTableAim_Time_TappedSideEnd.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_TappedSideEnd.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_LFArrival
            // 
            this.coldsGrid1L3DataTableAim_Time_LFArrival.Caption = "Aim_Time_LFArrival";
            this.coldsGrid1L3DataTableAim_Time_LFArrival.ColumnName = "Aim_Time_LFArrival";
            this.coldsGrid1L3DataTableAim_Time_LFArrival.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_LFArrival.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_LFStart
            // 
            this.coldsGrid1L3DataTableAim_Time_LFStart.Caption = "Aim_Time_LFStart";
            this.coldsGrid1L3DataTableAim_Time_LFStart.ColumnName = "Aim_Time_LFStart";
            this.coldsGrid1L3DataTableAim_Time_LFStart.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_LFStart.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_LFEnd
            // 
            this.coldsGrid1L3DataTableAim_Time_LFEnd.Caption = "Aim_Time_LFEnd";
            this.coldsGrid1L3DataTableAim_Time_LFEnd.ColumnName = "Aim_Time_LFEnd";
            this.coldsGrid1L3DataTableAim_Time_LFEnd.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_LFEnd.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_LFLeave
            // 
            this.coldsGrid1L3DataTableAim_Time_LFLeave.Caption = "Aim_Time_LFLeave";
            this.coldsGrid1L3DataTableAim_Time_LFLeave.ColumnName = "Aim_Time_LFLeave";
            this.coldsGrid1L3DataTableAim_Time_LFLeave.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_LFLeave.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_RHArrival
            // 
            this.coldsGrid1L3DataTableAim_Time_RHArrival.Caption = "Aim_Time_RHArrival";
            this.coldsGrid1L3DataTableAim_Time_RHArrival.ColumnName = "Aim_Time_RHArrival";
            this.coldsGrid1L3DataTableAim_Time_RHArrival.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_RHArrival.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_RHStart
            // 
            this.coldsGrid1L3DataTableAim_Time_RHStart.Caption = "Aim_Time_RHStart";
            this.coldsGrid1L3DataTableAim_Time_RHStart.ColumnName = "Aim_Time_RHStart";
            this.coldsGrid1L3DataTableAim_Time_RHStart.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_RHStart.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_RHEnd
            // 
            this.coldsGrid1L3DataTableAim_Time_RHEnd.Caption = "Aim_Time_RHEnd";
            this.coldsGrid1L3DataTableAim_Time_RHEnd.ColumnName = "Aim_Time_RHEnd";
            this.coldsGrid1L3DataTableAim_Time_RHEnd.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_RHEnd.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_RHLeave
            // 
            this.coldsGrid1L3DataTableAim_Time_RHLeave.Caption = "Aim_Time_RHLeave";
            this.coldsGrid1L3DataTableAim_Time_RHLeave.ColumnName = "Aim_Time_RHLeave";
            this.coldsGrid1L3DataTableAim_Time_RHLeave.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_RHLeave.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_CasterArrival
            // 
            this.coldsGrid1L3DataTableAim_Time_CasterArrival.Caption = "Aim_Time_CasterArrival";
            this.coldsGrid1L3DataTableAim_Time_CasterArrival.ColumnName = "Aim_Time_CasterArrival";
            this.coldsGrid1L3DataTableAim_Time_CasterArrival.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_CasterArrival.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_CastingStart
            // 
            this.coldsGrid1L3DataTableAim_Time_CastingStart.Caption = "Aim_Time_CastingStart";
            this.coldsGrid1L3DataTableAim_Time_CastingStart.ColumnName = "Aim_Time_CastingStart";
            this.coldsGrid1L3DataTableAim_Time_CastingStart.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_CastingStart.Namespace = "";
            // 
            // coldsGrid1L3DataTableAim_Time_CastingEnd
            // 
            this.coldsGrid1L3DataTableAim_Time_CastingEnd.Caption = "Aim_Time_CastingEnd";
            this.coldsGrid1L3DataTableAim_Time_CastingEnd.ColumnName = "Aim_Time_CastingEnd";
            this.coldsGrid1L3DataTableAim_Time_CastingEnd.DataType = typeof(System.DateTime);
            this.coldsGrid1L3DataTableAim_Time_CastingEnd.Namespace = "";
            // 
            // coldsGrid1L3DataTableFir_Heat_Flag
            // 
            this.coldsGrid1L3DataTableFir_Heat_Flag.Caption = "Fir_Heat_Flag";
            this.coldsGrid1L3DataTableFir_Heat_Flag.ColumnName = "Fir_Heat_Flag";
            this.coldsGrid1L3DataTableFir_Heat_Flag.DataType = typeof(int);
            this.coldsGrid1L3DataTableFir_Heat_Flag.Namespace = "";
            // 
            // coldsGrid1L3DataTableDiv_HeatID
            // 
            this.coldsGrid1L3DataTableDiv_HeatID.Caption = "Div_HeatID";
            this.coldsGrid1L3DataTableDiv_HeatID.ColumnName = "Div_HeatID";
            this.coldsGrid1L3DataTableDiv_HeatID.Namespace = "";
            // 
            // coldsGrid1L3DataTableTeamID
            // 
            this.coldsGrid1L3DataTableTeamID.Caption = "TeamID";
            this.coldsGrid1L3DataTableTeamID.ColumnName = "TeamID";
            this.coldsGrid1L3DataTableTeamID.Namespace = "";
            // 
            // coldsGrid1L3DataTableShiftID
            // 
            this.coldsGrid1L3DataTableShiftID.Caption = "ShiftID";
            this.coldsGrid1L3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsGrid1L3DataTableShiftID.Namespace = "";
            // 
            // coldsGrid1L3DataTableSteelGradeIndex
            // 
            this.coldsGrid1L3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsGrid1L3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsGrid1L3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsGrid1L3DataTableSteelGrade
            // 
            this.coldsGrid1L3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsGrid1L3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsGrid1L3DataTableSteelGrade.Namespace = "";
            // 
            // coldsGrid1L3DataTablePlan_Ord_ID
            // 
            this.coldsGrid1L3DataTablePlan_Ord_ID.Caption = "Plan_Ord_ID";
            this.coldsGrid1L3DataTablePlan_Ord_ID.ColumnName = "Plan_Ord_ID";
            this.coldsGrid1L3DataTablePlan_Ord_ID.Namespace = "";
            // 
            // coldsGrid1L3DataTableHot_Send_Flag
            // 
            this.coldsGrid1L3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coldsGrid1L3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coldsGrid1L3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coldsGrid1L3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coldsGrid1L3DataTableSteel_Return_Flag
            // 
            this.coldsGrid1L3DataTableSteel_Return_Flag.Caption = "Steel_Return_Flag";
            this.coldsGrid1L3DataTableSteel_Return_Flag.ColumnName = "Steel_Return_Flag";
            this.coldsGrid1L3DataTableSteel_Return_Flag.DataType = typeof(int);
            this.coldsGrid1L3DataTableSteel_Return_Flag.Namespace = "";
            // 
            // coldsGrid1L3DataTableSteel_Back_Flag
            // 
            this.coldsGrid1L3DataTableSteel_Back_Flag.Caption = "Steel_Back_Flag";
            this.coldsGrid1L3DataTableSteel_Back_Flag.ColumnName = "Steel_Back_Flag";
            this.coldsGrid1L3DataTableSteel_Back_Flag.DataType = typeof(int);
            this.coldsGrid1L3DataTableSteel_Back_Flag.Namespace = "";
            // 
            // coldsGrid1L3DataTableTreat_Seq
            // 
            this.coldsGrid1L3DataTableTreat_Seq.Caption = "Treat_Seq";
            this.coldsGrid1L3DataTableTreat_Seq.ColumnName = "Treat_Seq";
            this.coldsGrid1L3DataTableTreat_Seq.Namespace = "";
            // 
            // coldsGrid1L3DataTableDestitation
            // 
            this.coldsGrid1L3DataTableDestitation.Caption = "Destitation";
            this.coldsGrid1L3DataTableDestitation.ColumnName = "Destitation";
            this.coldsGrid1L3DataTableDestitation.Namespace = "";
            // 
            // coldsGrid1L3DataTableNew_BOF_Flag
            // 
            this.coldsGrid1L3DataTableNew_BOF_Flag.Caption = "New_BOF_Flag";
            this.coldsGrid1L3DataTableNew_BOF_Flag.ColumnName = "New_BOF_Flag";
            this.coldsGrid1L3DataTableNew_BOF_Flag.DataType = typeof(bool);
            this.coldsGrid1L3DataTableNew_BOF_Flag.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 135);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbSteelGradeIndex);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.dvActTimeCastingEnd);
            this.tabPage1.Controls.Add(this.dvActTimeCastingStart);
            this.tabPage1.Controls.Add(this.dvActTimeCasterArrival);
            this.tabPage1.Controls.Add(this.dtActTimeRHStart);
            this.tabPage1.Controls.Add(this.dtActTimeBOFTapped);
            this.tabPage1.Controls.Add(this.dtActTimeLFStart);
            this.tabPage1.Controls.Add(this.dtActTimeBOFStart);
            this.tabPage1.Controls.Add(this.dtActTimeTappedSideEnd);
            this.tabPage1.Controls.Add(this.dtActTimeIronPrepared);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 110);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "作业时间";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbSteelGradeIndex
            // 
            this.lbSteelGradeIndex.AutoSize = true;
            this.lbSteelGradeIndex.Location = new System.Drawing.Point(124, 10);
            this.lbSteelGradeIndex.Name = "lbSteelGradeIndex";
            this.lbSteelGradeIndex.Size = new System.Drawing.Size(47, 12);
            this.lbSteelGradeIndex.TabIndex = 10;
            this.lbSteelGradeIndex.Text = "xxxxxxx";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(59, 10);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 12);
            this.label32.TabIndex = 9;
            this.label32.Text = "炼钢记号:";
            // 
            // dvActTimeCastingEnd
            // 
            this.dvActTimeCastingEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_CastingEnd", true));
            this.dvActTimeCastingEnd.Enabled = false;
            this.dvActTimeCastingEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dvActTimeCastingEnd.Location = new System.Drawing.Point(630, 81);
            this.dvActTimeCastingEnd.Name = "dvActTimeCastingEnd";
            this.dvActTimeCastingEnd.ShowUpDown = true;
            this.dvActTimeCastingEnd.Size = new System.Drawing.Size(144, 21);
            this.dvActTimeCastingEnd.TabIndex = 8;
            // 
            // dvActTimeCastingStart
            // 
            this.dvActTimeCastingStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_CastingStart", true));
            this.dvActTimeCastingStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dvActTimeCastingStart.Location = new System.Drawing.Point(377, 81);
            this.dvActTimeCastingStart.Name = "dvActTimeCastingStart";
            this.dvActTimeCastingStart.ShowUpDown = true;
            this.dvActTimeCastingStart.Size = new System.Drawing.Size(144, 21);
            this.dvActTimeCastingStart.TabIndex = 5;
            // 
            // dvActTimeCasterArrival
            // 
            this.dvActTimeCasterArrival.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_CasterArrival", true));
            this.dvActTimeCasterArrival.Enabled = false;
            this.dvActTimeCasterArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dvActTimeCasterArrival.Location = new System.Drawing.Point(124, 81);
            this.dvActTimeCasterArrival.Name = "dvActTimeCasterArrival";
            this.dvActTimeCasterArrival.ShowUpDown = true;
            this.dvActTimeCasterArrival.Size = new System.Drawing.Size(144, 21);
            this.dvActTimeCasterArrival.TabIndex = 2;
            // 
            // dtActTimeRHStart
            // 
            this.dtActTimeRHStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_RHStart", true));
            this.dtActTimeRHStart.Enabled = false;
            this.dtActTimeRHStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActTimeRHStart.Location = new System.Drawing.Point(630, 55);
            this.dtActTimeRHStart.Name = "dtActTimeRHStart";
            this.dtActTimeRHStart.ShowUpDown = true;
            this.dtActTimeRHStart.Size = new System.Drawing.Size(144, 21);
            this.dtActTimeRHStart.TabIndex = 7;
            // 
            // dtActTimeBOFTapped
            // 
            this.dtActTimeBOFTapped.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_BOFTapped", true));
            this.dtActTimeBOFTapped.Enabled = false;
            this.dtActTimeBOFTapped.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActTimeBOFTapped.Location = new System.Drawing.Point(630, 29);
            this.dtActTimeBOFTapped.Name = "dtActTimeBOFTapped";
            this.dtActTimeBOFTapped.ShowUpDown = true;
            this.dtActTimeBOFTapped.Size = new System.Drawing.Size(144, 21);
            this.dtActTimeBOFTapped.TabIndex = 6;
            // 
            // dtActTimeLFStart
            // 
            this.dtActTimeLFStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_LFStart", true));
            this.dtActTimeLFStart.Enabled = false;
            this.dtActTimeLFStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActTimeLFStart.Location = new System.Drawing.Point(377, 55);
            this.dtActTimeLFStart.Name = "dtActTimeLFStart";
            this.dtActTimeLFStart.ShowUpDown = true;
            this.dtActTimeLFStart.Size = new System.Drawing.Size(144, 21);
            this.dtActTimeLFStart.TabIndex = 4;
            // 
            // dtActTimeBOFStart
            // 
            this.dtActTimeBOFStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_BOFStart", true));
            this.dtActTimeBOFStart.Enabled = false;
            this.dtActTimeBOFStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActTimeBOFStart.Location = new System.Drawing.Point(377, 29);
            this.dtActTimeBOFStart.Name = "dtActTimeBOFStart";
            this.dtActTimeBOFStart.ShowUpDown = true;
            this.dtActTimeBOFStart.Size = new System.Drawing.Size(144, 21);
            this.dtActTimeBOFStart.TabIndex = 3;
            // 
            // dtActTimeTappedSideEnd
            // 
            this.dtActTimeTappedSideEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_TappedSideEnd", true));
            this.dtActTimeTappedSideEnd.Enabled = false;
            this.dtActTimeTappedSideEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActTimeTappedSideEnd.Location = new System.Drawing.Point(124, 55);
            this.dtActTimeTappedSideEnd.Name = "dtActTimeTappedSideEnd";
            this.dtActTimeTappedSideEnd.ShowUpDown = true;
            this.dtActTimeTappedSideEnd.Size = new System.Drawing.Size(144, 21);
            this.dtActTimeTappedSideEnd.TabIndex = 1;
            // 
            // dtActTimeIronPrepared
            // 
            this.dtActTimeIronPrepared.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "Aim_Time_IronPrepared", true));
            this.dtActTimeIronPrepared.Enabled = false;
            this.dtActTimeIronPrepared.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtActTimeIronPrepared.Location = new System.Drawing.Point(124, 29);
            this.dtActTimeIronPrepared.Name = "dtActTimeIronPrepared";
            this.dtActTimeIronPrepared.ShowUpDown = true;
            this.dtActTimeIronPrepared.Size = new System.Drawing.Size(144, 21);
            this.dtActTimeIronPrepared.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "炉后处理结束时刻:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(531, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "钢包浇铸终时刻:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "钢包浇铸始时刻:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(567, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "RH始时刻:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(555, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "出钢终时刻:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "LF始时刻:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "吹炼开始时刻:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "铸机要求时刻:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "主原料装入时刻:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tptime);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 135);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(792, 90);
            this.tabControl2.TabIndex = 1;
            // 
            // tptime
            // 
            this.tptime.Controls.Add(this.label31);
            this.tptime.Controls.Add(this.label29);
            this.tptime.Controls.Add(this.label27);
            this.tptime.Controls.Add(this.label30);
            this.tptime.Controls.Add(this.label28);
            this.tptime.Controls.Add(this.label26);
            this.tptime.Controls.Add(this.txtCastingTime);
            this.tptime.Controls.Add(this.txtCasterWaitTime);
            this.tptime.Controls.Add(this.txtLFTime);
            this.tptime.Controls.Add(this.txtRHTime);
            this.tptime.Controls.Add(this.txtTippedSideTime);
            this.tptime.Controls.Add(this.txtStartToEndTime);
            this.tptime.Controls.Add(this.label23);
            this.tptime.Controls.Add(this.label6);
            this.tptime.Controls.Add(this.label5);
            this.tptime.Controls.Add(this.label25);
            this.tptime.Controls.Add(this.label24);
            this.tptime.Controls.Add(this.label7);
            this.tptime.Location = new System.Drawing.Point(4, 21);
            this.tptime.Name = "tptime";
            this.tptime.Padding = new System.Windows.Forms.Padding(3);
            this.tptime.Size = new System.Drawing.Size(784, 65);
            this.tptime.TabIndex = 0;
            this.tptime.Text = "工艺时间信息";
            this.tptime.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(760, 39);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 3;
            this.label31.Text = "分";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(511, 39);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 12);
            this.label29.TabIndex = 3;
            this.label29.Text = "分";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(248, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 12);
            this.label27.TabIndex = 3;
            this.label27.Text = "分";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(760, 13);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 12);
            this.label30.TabIndex = 3;
            this.label30.Text = "分";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(511, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 12);
            this.label28.TabIndex = 3;
            this.label28.Text = "分";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(248, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 12);
            this.label26.TabIndex = 3;
            this.label26.Text = "分";
            // 
            // txtCastingTime
            // 
            this.txtCastingTime.Enabled = false;
            this.txtCastingTime.EnableNull = false;
            this.txtCastingTime.ErropPr = this.errorProvider1;
            this.txtCastingTime.Length = 0;
            this.txtCastingTime.Location = new System.Drawing.Point(641, 35);
            this.txtCastingTime.Max = 0;
            this.txtCastingTime.MaxStrLength = 0;
            this.txtCastingTime.Min = -0.99;
            this.txtCastingTime.MinStrLength = 0;
            this.txtCastingTime.Name = "txtCastingTime";
            this.txtCastingTime.Precision = 0;
            this.txtCastingTime.Size = new System.Drawing.Size(109, 21);
            this.txtCastingTime.TabIndex = 5;
            this.txtCastingTime.ToolTipValid = this.toolTip1;
            this.txtCastingTime.ValidEable = true;
            this.txtCastingTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCasterWaitTime
            // 
            this.txtCasterWaitTime.Enabled = false;
            this.txtCasterWaitTime.EnableNull = false;
            this.txtCasterWaitTime.ErropPr = this.errorProvider1;
            this.txtCasterWaitTime.Length = 0;
            this.txtCasterWaitTime.Location = new System.Drawing.Point(396, 35);
            this.txtCasterWaitTime.Max = 0;
            this.txtCasterWaitTime.MaxStrLength = 0;
            this.txtCasterWaitTime.Min = -0.99;
            this.txtCasterWaitTime.MinStrLength = 0;
            this.txtCasterWaitTime.Name = "txtCasterWaitTime";
            this.txtCasterWaitTime.Precision = 0;
            this.txtCasterWaitTime.Size = new System.Drawing.Size(109, 21);
            this.txtCasterWaitTime.TabIndex = 3;
            this.txtCasterWaitTime.ToolTipValid = this.toolTip1;
            this.txtCasterWaitTime.ValidEable = true;
            this.txtCasterWaitTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtLFTime
            // 
            this.txtLFTime.Enabled = false;
            this.txtLFTime.EnableNull = false;
            this.txtLFTime.ErropPr = this.errorProvider1;
            this.txtLFTime.Length = 0;
            this.txtLFTime.Location = new System.Drawing.Point(641, 9);
            this.txtLFTime.Max = 0;
            this.txtLFTime.MaxStrLength = 0;
            this.txtLFTime.Min = -0.99;
            this.txtLFTime.MinStrLength = 0;
            this.txtLFTime.Name = "txtLFTime";
            this.txtLFTime.Precision = 0;
            this.txtLFTime.Size = new System.Drawing.Size(109, 21);
            this.txtLFTime.TabIndex = 4;
            this.txtLFTime.ToolTipValid = this.toolTip1;
            this.txtLFTime.ValidEable = true;
            this.txtLFTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtRHTime
            // 
            this.txtRHTime.Enabled = false;
            this.txtRHTime.EnableNull = false;
            this.txtRHTime.ErropPr = this.errorProvider1;
            this.txtRHTime.Length = 0;
            this.txtRHTime.Location = new System.Drawing.Point(133, 35);
            this.txtRHTime.Max = 0;
            this.txtRHTime.MaxStrLength = 0;
            this.txtRHTime.Min = -0.99;
            this.txtRHTime.MinStrLength = 0;
            this.txtRHTime.Name = "txtRHTime";
            this.txtRHTime.Precision = 0;
            this.txtRHTime.Size = new System.Drawing.Size(109, 21);
            this.txtRHTime.TabIndex = 1;
            this.txtRHTime.ToolTipValid = this.toolTip1;
            this.txtRHTime.ValidEable = true;
            this.txtRHTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTippedSideTime
            // 
            this.txtTippedSideTime.Enabled = false;
            this.txtTippedSideTime.EnableNull = false;
            this.txtTippedSideTime.ErropPr = this.errorProvider1;
            this.txtTippedSideTime.Length = 0;
            this.txtTippedSideTime.Location = new System.Drawing.Point(396, 9);
            this.txtTippedSideTime.Max = 0;
            this.txtTippedSideTime.MaxStrLength = 0;
            this.txtTippedSideTime.Min = -0.99;
            this.txtTippedSideTime.MinStrLength = 0;
            this.txtTippedSideTime.Name = "txtTippedSideTime";
            this.txtTippedSideTime.Precision = 0;
            this.txtTippedSideTime.Size = new System.Drawing.Size(109, 21);
            this.txtTippedSideTime.TabIndex = 2;
            this.txtTippedSideTime.ToolTipValid = this.toolTip1;
            this.txtTippedSideTime.ValidEable = true;
            this.txtTippedSideTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtStartToEndTime
            // 
            this.txtStartToEndTime.Enabled = false;
            this.txtStartToEndTime.EnableNull = false;
            this.txtStartToEndTime.ErropPr = this.errorProvider1;
            this.txtStartToEndTime.Length = 0;
            this.txtStartToEndTime.Location = new System.Drawing.Point(133, 9);
            this.txtStartToEndTime.Max = 0;
            this.txtStartToEndTime.MaxStrLength = 0;
            this.txtStartToEndTime.Min = -0.99;
            this.txtStartToEndTime.MinStrLength = 0;
            this.txtStartToEndTime.Name = "txtStartToEndTime";
            this.txtStartToEndTime.Precision = 0;
            this.txtStartToEndTime.Size = new System.Drawing.Size(109, 21);
            this.txtStartToEndTime.TabIndex = 0;
            this.txtStartToEndTime.ToolTipValid = this.toolTip1;
            this.txtStartToEndTime.ValidEable = true;
            this.txtStartToEndTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(119, 12);
            this.label23.TabIndex = 1;
            this.label23.Text = "吹炼开始至出钢结束:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "铸机等待时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "炉后处理时间:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(564, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "浇铸时间:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(564, 13);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "LF处理时间:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "RH处理时间:";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(598, 234);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "更改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(679, 234);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmdChangePlanTime
            // 
            this.cmdChangePlanTime.Adapter = this.Adapter;
            this.cmdChangePlanTime.MergeReturnTarget = false;
            this.cmdChangePlanTime.Method = "ModifyTappingPlanTimeInfor";
            this.cmdChangePlanTime.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdChangePlanTime.Parameters.Add(this.l3CommandParameter2);
            this.cmdChangePlanTime.ReturnTarget = null;
            this.cmdChangePlanTime.ReturnTargetProperty = null;
            this.cmdChangePlanTime.Trigger = null;
            this.cmdChangePlanTime.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsTapping;
            this.l3CommandParameter2.SourceProperty = "L3DataTable";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
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
            // ChangePlanTimeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 265);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangePlanTimeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改计划时间";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePlanTimeFrm_FormClosing);
            this.Load += new System.EventHandler(this.ChangePlanTimeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tptime.ResumeLayout(false);
            this.tptime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsTapping;
        private AppSvrHMI.L3DataSet dsTapping;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tptime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtActTimeIronPrepared;
        private System.Windows.Forms.DateTimePicker dvActTimeCastingEnd;
        private System.Windows.Forms.DateTimePicker dvActTimeCastingStart;
        private System.Windows.Forms.DateTimePicker dvActTimeCasterArrival;
        private System.Windows.Forms.DateTimePicker dtActTimeRHStart;
        private System.Windows.Forms.DateTimePicker dtActTimeBOFTapped;
        private System.Windows.Forms.DateTimePicker dtActTimeLFStart;
        private System.Windows.Forms.DateTimePicker dtActTimeBOFStart;
        private System.Windows.Forms.DateTimePicker dtActTimeTappedSideEnd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private PxDataValid.PxTextBox txtCastingTime;
        private PxDataValid.PxTextBox txtCasterWaitTime;
        private PxDataValid.PxTextBox txtLFTime;
        private PxDataValid.PxTextBox txtRHTime;
        private PxDataValid.PxTextBox txtTippedSideTime;
        private PxDataValid.PxTextBox txtStartToEndTime;
        private System.Data.DataTable schemadsGrid1;
        private System.Data.DataColumn coldsGrid1L3DataTableGUID;
        private System.Data.DataColumn coldsGrid1L3DataTableName;
        private System.Data.DataColumn coldsGrid1L3DataTablePlanID;
        private System.Data.DataColumn coldsGrid1L3DataTableContractID;
        private System.Data.DataColumn coldsGrid1L3DataTableStatus;
        private System.Data.DataColumn coldsGrid1L3DataTablePlanDept;
        private System.Data.DataColumn coldsGrid1L3DataTableExecuteDept;
        private System.Data.DataColumn coldsGrid1L3DataTableCreateDate;
        private System.Data.DataColumn coldsGrid1L3DataTablePlanExecuteDate;
        private System.Data.DataColumn coldsGrid1L3DataTableActualExecuteDate;
        private System.Data.DataColumn coldsGrid1L3DataTablePlanner;
        private System.Data.DataColumn coldsGrid1L3DataTablePre_LotNo;
        private System.Data.DataColumn coldsGrid1L3DataTablePreHeatID;
        private System.Data.DataColumn coldsGrid1L3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsGrid1L3DataTablePre_SteelGrade;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Tapped_Weight;
        private System.Data.DataColumn coldsGrid1L3DataTableCasterID;
        private System.Data.DataColumn coldsGrid1L3DataTableBOFID;
        private System.Data.DataColumn coldsGrid1L3DataTableLFID;
        private System.Data.DataColumn coldsGrid1L3DataTableRHID;
        private System.Data.DataColumn coldsGrid1L3DataTableBOF_Status;
        private System.Data.DataColumn coldsGrid1L3DataTableLF_Status;
        private System.Data.DataColumn coldsGrid1L3DataTableRH_Status;
        private System.Data.DataColumn coldsGrid1L3DataTableCaster_Status;
        private System.Data.DataColumn coldsGrid1L3DataTableSide_Status;
        private System.Data.DataColumn coldsGrid1L3DataTableHeatID;
        private System.Data.DataColumn coldsGrid1L3DataTableCasting_No;
        private System.Data.DataColumn coldsGrid1L3DataTableCasting_Heat_Cnt;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_IronPrepared;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_BOFStart;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_BOFTapped;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_TappedSideEnd;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_LFArrival;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_LFStart;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_LFEnd;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_LFLeave;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_RHArrival;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_RHStart;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_RHEnd;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_RHLeave;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_CasterArrival;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_CastingStart;
        private System.Data.DataColumn coldsGrid1L3DataTableAim_Time_CastingEnd;
        private System.Data.DataColumn coldsGrid1L3DataTableFir_Heat_Flag;
        private System.Data.DataColumn coldsGrid1L3DataTableDiv_HeatID;
        private System.Data.DataColumn coldsGrid1L3DataTableTeamID;
        private System.Data.DataColumn coldsGrid1L3DataTableShiftID;
        private System.Data.DataColumn coldsGrid1L3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsGrid1L3DataTableSteelGrade;
        private System.Data.DataColumn coldsGrid1L3DataTablePlan_Ord_ID;
        private System.Data.DataColumn coldsGrid1L3DataTableHot_Send_Flag;
        private System.Data.DataColumn coldsGrid1L3DataTableSteel_Return_Flag;
        private System.Data.DataColumn coldsGrid1L3DataTableSteel_Back_Flag;
        private System.Data.DataColumn coldsGrid1L3DataTableTreat_Seq;
        private System.Data.DataColumn coldsGrid1L3DataTableDestitation;
        private System.Data.DataColumn coldsGrid1L3DataTableNew_BOF_Flag;
        private AppSvrHMI.L3Command cmdChangePlanTime;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.Label lbSteelGradeIndex;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}