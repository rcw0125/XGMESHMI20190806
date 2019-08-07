namespace PlanMag
{
    partial class UpdateControl

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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bsTapping = new System.Windows.Forms.BindingSource(this.components);
            this.dsTapping = new AppSvrHMI.L3DataSet();
            this.schemadsTapping = new System.Data.DataTable();
            this.coldsTappingL3DataTablePlanID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableContractID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableStatus = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePlanDept = new System.Data.DataColumn();
            this.coldsTappingL3DataTableExecuteDept = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCreateDate = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePlanExecuteDate = new System.Data.DataColumn();
            this.coldsTappingL3DataTableActualExecuteDate = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePlanner = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePre_LotNo = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePre_SteelGrade = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Tapped_Weight = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLFID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableRHID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableBOF_Status = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLF_Status = new System.Data.DataColumn();
            this.coldsTappingL3DataTableRH_Status = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCaster_Status = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSide_Status = new System.Data.DataColumn();
            this.coldsTappingL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCasting_No = new System.Data.DataColumn();
            this.coldsTappingL3DataTableCasting_Heat_Cnt = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_IronPrepared = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_BOFStart = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_BOFTapped = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_TappedSideEnd = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_LFArrival = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_LFStart = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_LFEnd = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_LFLeave = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_RHArrival = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_RHStart = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_RHEnd = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_RHLeave = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_CasterArrival = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_CastingStart = new System.Data.DataColumn();
            this.coldsTappingL3DataTableAim_Time_CastingEnd = new System.Data.DataColumn();
            this.coldsTappingL3DataTableFir_Heat_Flag = new System.Data.DataColumn();
            this.coldsTappingL3DataTableDiv_HeatID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsTappingL3DataTablePlan_Ord_ID = new System.Data.DataColumn();
            this.coldsTappingL3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSteel_Return_Flag = new System.Data.DataColumn();
            this.coldsTappingL3DataTableSteel_Back_Flag = new System.Data.DataColumn();
            this.coldsTappingL3DataTableTreat_Seq = new System.Data.DataColumn();
            this.coldsTappingL3DataTableDestitation = new System.Data.DataColumn();
            this.coldsTappingL3DataTableNew_BOF_Flag = new System.Data.DataColumn();
            this.coldsTappingL3DataTableRefine_Type = new System.Data.DataColumn();
            this.coldsTappingL3DataTableLength = new System.Data.DataColumn();
            this.coldsTappingL3DataTableWidth = new System.Data.DataColumn();
            this.coldsTappingL3DataTableThickness = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmdChangePlanTime = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapping)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bsTapping
            // 
            this.bsTapping.DataMember = "L3DataTable";
            this.bsTapping.DataSource = this.dsTapping;
            // 
            // dsTapping
            // 
            this.dsTapping.AutoLoad = true;
            this.dsTapping.AutoSubscribe = true;
            this.dsTapping.DataSetName = "L3DataSet";
            this.dsTapping.DeleteMethod = "";
            this.dsTapping.InsertMethod = "";
            this.dsTapping.L3DataAdapter = this.Adapter;
            this.dsTapping.LoadEvent = "Click";
            this.dsTapping.LoadTrigger = null;
            this.dsTapping.RefreshValve = 1000;
            this.dsTapping.SourceCommand = null;
            this.dsTapping.SourceCondition = "1=2";
            this.dsTapping.SourceMethod = "";
            this.dsTapping.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTapping.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Tapping";
            this.dsTapping.SubscribeTarget = "";
            this.dsTapping.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapping});
            this.dsTapping.UpdateEvent = "Click";
            this.dsTapping.UpdateMethod = "";
            this.dsTapping.UpdateTrigger = null;
            // 
            // schemadsTapping
            // 
            this.schemadsTapping.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTappingL3DataTablePlanID,
            this.coldsTappingL3DataTableContractID,
            this.coldsTappingL3DataTableStatus,
            this.coldsTappingL3DataTablePlanDept,
            this.coldsTappingL3DataTableExecuteDept,
            this.coldsTappingL3DataTableCreateDate,
            this.coldsTappingL3DataTablePlanExecuteDate,
            this.coldsTappingL3DataTableActualExecuteDate,
            this.coldsTappingL3DataTablePlanner,
            this.coldsTappingL3DataTablePre_LotNo,
            this.coldsTappingL3DataTablePreHeatID,
            this.coldsTappingL3DataTablePre_SteelGradeIndex,
            this.coldsTappingL3DataTablePre_SteelGrade,
            this.coldsTappingL3DataTableAim_Tapped_Weight,
            this.coldsTappingL3DataTableCasterID,
            this.coldsTappingL3DataTableBOFID,
            this.coldsTappingL3DataTableLFID,
            this.coldsTappingL3DataTableRHID,
            this.coldsTappingL3DataTableBOF_Status,
            this.coldsTappingL3DataTableLF_Status,
            this.coldsTappingL3DataTableRH_Status,
            this.coldsTappingL3DataTableCaster_Status,
            this.coldsTappingL3DataTableSide_Status,
            this.coldsTappingL3DataTableHeatID,
            this.coldsTappingL3DataTableCasting_No,
            this.coldsTappingL3DataTableCasting_Heat_Cnt,
            this.coldsTappingL3DataTableAim_Time_IronPrepared,
            this.coldsTappingL3DataTableAim_Time_BOFStart,
            this.coldsTappingL3DataTableAim_Time_BOFTapped,
            this.coldsTappingL3DataTableAim_Time_TappedSideEnd,
            this.coldsTappingL3DataTableAim_Time_LFArrival,
            this.coldsTappingL3DataTableAim_Time_LFStart,
            this.coldsTappingL3DataTableAim_Time_LFEnd,
            this.coldsTappingL3DataTableAim_Time_LFLeave,
            this.coldsTappingL3DataTableAim_Time_RHArrival,
            this.coldsTappingL3DataTableAim_Time_RHStart,
            this.coldsTappingL3DataTableAim_Time_RHEnd,
            this.coldsTappingL3DataTableAim_Time_RHLeave,
            this.coldsTappingL3DataTableAim_Time_CasterArrival,
            this.coldsTappingL3DataTableAim_Time_CastingStart,
            this.coldsTappingL3DataTableAim_Time_CastingEnd,
            this.coldsTappingL3DataTableFir_Heat_Flag,
            this.coldsTappingL3DataTableDiv_HeatID,
            this.coldsTappingL3DataTableTeamID,
            this.coldsTappingL3DataTableShiftID,
            this.coldsTappingL3DataTableSteelGradeIndex,
            this.coldsTappingL3DataTableSteelGrade,
            this.coldsTappingL3DataTablePlan_Ord_ID,
            this.coldsTappingL3DataTableHot_Send_Flag,
            this.coldsTappingL3DataTableSteel_Return_Flag,
            this.coldsTappingL3DataTableSteel_Back_Flag,
            this.coldsTappingL3DataTableTreat_Seq,
            this.coldsTappingL3DataTableDestitation,
            this.coldsTappingL3DataTableNew_BOF_Flag,
            this.coldsTappingL3DataTableRefine_Type,
            this.coldsTappingL3DataTableLength,
            this.coldsTappingL3DataTableWidth,
            this.coldsTappingL3DataTableThickness});
            this.schemadsTapping.TableName = "L3DataTable";
            // 
            // coldsTappingL3DataTablePlanID
            // 
            this.coldsTappingL3DataTablePlanID.Caption = "PlanID";
            this.coldsTappingL3DataTablePlanID.ColumnName = "PlanID";
            this.coldsTappingL3DataTablePlanID.Namespace = "";
            // 
            // coldsTappingL3DataTableContractID
            // 
            this.coldsTappingL3DataTableContractID.Caption = "ContractID";
            this.coldsTappingL3DataTableContractID.ColumnName = "ContractID";
            this.coldsTappingL3DataTableContractID.Namespace = "";
            // 
            // coldsTappingL3DataTableStatus
            // 
            this.coldsTappingL3DataTableStatus.Caption = "Status";
            this.coldsTappingL3DataTableStatus.ColumnName = "Status";
            this.coldsTappingL3DataTableStatus.DataType = typeof(int);
            this.coldsTappingL3DataTableStatus.Namespace = "";
            // 
            // coldsTappingL3DataTablePlanDept
            // 
            this.coldsTappingL3DataTablePlanDept.Caption = "PlanDept";
            this.coldsTappingL3DataTablePlanDept.ColumnName = "PlanDept";
            this.coldsTappingL3DataTablePlanDept.Namespace = "";
            // 
            // coldsTappingL3DataTableExecuteDept
            // 
            this.coldsTappingL3DataTableExecuteDept.Caption = "ExecuteDept";
            this.coldsTappingL3DataTableExecuteDept.ColumnName = "ExecuteDept";
            this.coldsTappingL3DataTableExecuteDept.Namespace = "";
            // 
            // coldsTappingL3DataTableCreateDate
            // 
            this.coldsTappingL3DataTableCreateDate.Caption = "CreateDate";
            this.coldsTappingL3DataTableCreateDate.ColumnName = "CreateDate";
            this.coldsTappingL3DataTableCreateDate.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableCreateDate.Namespace = "";
            // 
            // coldsTappingL3DataTablePlanExecuteDate
            // 
            this.coldsTappingL3DataTablePlanExecuteDate.Caption = "PlanExecuteDate";
            this.coldsTappingL3DataTablePlanExecuteDate.ColumnName = "PlanExecuteDate";
            this.coldsTappingL3DataTablePlanExecuteDate.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTablePlanExecuteDate.Namespace = "";
            // 
            // coldsTappingL3DataTableActualExecuteDate
            // 
            this.coldsTappingL3DataTableActualExecuteDate.Caption = "ActualExecuteDate";
            this.coldsTappingL3DataTableActualExecuteDate.ColumnName = "ActualExecuteDate";
            this.coldsTappingL3DataTableActualExecuteDate.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableActualExecuteDate.Namespace = "";
            // 
            // coldsTappingL3DataTablePlanner
            // 
            this.coldsTappingL3DataTablePlanner.Caption = "Planner";
            this.coldsTappingL3DataTablePlanner.ColumnName = "Planner";
            this.coldsTappingL3DataTablePlanner.Namespace = "";
            // 
            // coldsTappingL3DataTablePre_LotNo
            // 
            this.coldsTappingL3DataTablePre_LotNo.Caption = "Pre_LotNo";
            this.coldsTappingL3DataTablePre_LotNo.ColumnName = "Pre_LotNo";
            this.coldsTappingL3DataTablePre_LotNo.Namespace = "";
            // 
            // coldsTappingL3DataTablePreHeatID
            // 
            this.coldsTappingL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsTappingL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsTappingL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsTappingL3DataTablePre_SteelGradeIndex
            // 
            this.coldsTappingL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsTappingL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsTappingL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsTappingL3DataTablePre_SteelGrade
            // 
            this.coldsTappingL3DataTablePre_SteelGrade.Caption = "Pre_SteelGrade";
            this.coldsTappingL3DataTablePre_SteelGrade.ColumnName = "Pre_SteelGrade";
            this.coldsTappingL3DataTablePre_SteelGrade.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Tapped_Weight
            // 
            this.coldsTappingL3DataTableAim_Tapped_Weight.Caption = "Aim_Tapped_Weight";
            this.coldsTappingL3DataTableAim_Tapped_Weight.ColumnName = "Aim_Tapped_Weight";
            this.coldsTappingL3DataTableAim_Tapped_Weight.DataType = typeof(double);
            this.coldsTappingL3DataTableAim_Tapped_Weight.Namespace = "";
            // 
            // coldsTappingL3DataTableCasterID
            // 
            this.coldsTappingL3DataTableCasterID.Caption = "CasterID";
            this.coldsTappingL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsTappingL3DataTableCasterID.Namespace = "";
            // 
            // coldsTappingL3DataTableBOFID
            // 
            this.coldsTappingL3DataTableBOFID.Caption = "BOFID";
            this.coldsTappingL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsTappingL3DataTableBOFID.Namespace = "";
            // 
            // coldsTappingL3DataTableLFID
            // 
            this.coldsTappingL3DataTableLFID.Caption = "LFID";
            this.coldsTappingL3DataTableLFID.ColumnName = "LFID";
            this.coldsTappingL3DataTableLFID.Namespace = "";
            // 
            // coldsTappingL3DataTableRHID
            // 
            this.coldsTappingL3DataTableRHID.Caption = "RHID";
            this.coldsTappingL3DataTableRHID.ColumnName = "RHID";
            this.coldsTappingL3DataTableRHID.Namespace = "";
            // 
            // coldsTappingL3DataTableBOF_Status
            // 
            this.coldsTappingL3DataTableBOF_Status.Caption = "BOF_Status";
            this.coldsTappingL3DataTableBOF_Status.ColumnName = "BOF_Status";
            this.coldsTappingL3DataTableBOF_Status.Namespace = "";
            // 
            // coldsTappingL3DataTableLF_Status
            // 
            this.coldsTappingL3DataTableLF_Status.Caption = "LF_Status";
            this.coldsTappingL3DataTableLF_Status.ColumnName = "LF_Status";
            this.coldsTappingL3DataTableLF_Status.Namespace = "";
            // 
            // coldsTappingL3DataTableRH_Status
            // 
            this.coldsTappingL3DataTableRH_Status.Caption = "RH_Status";
            this.coldsTappingL3DataTableRH_Status.ColumnName = "RH_Status";
            this.coldsTappingL3DataTableRH_Status.Namespace = "";
            // 
            // coldsTappingL3DataTableCaster_Status
            // 
            this.coldsTappingL3DataTableCaster_Status.Caption = "Caster_Status";
            this.coldsTappingL3DataTableCaster_Status.ColumnName = "Caster_Status";
            this.coldsTappingL3DataTableCaster_Status.Namespace = "";
            // 
            // coldsTappingL3DataTableSide_Status
            // 
            this.coldsTappingL3DataTableSide_Status.Caption = "Side_Status";
            this.coldsTappingL3DataTableSide_Status.ColumnName = "Side_Status";
            this.coldsTappingL3DataTableSide_Status.Namespace = "";
            // 
            // coldsTappingL3DataTableHeatID
            // 
            this.coldsTappingL3DataTableHeatID.Caption = "HeatID";
            this.coldsTappingL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTappingL3DataTableHeatID.Namespace = "";
            // 
            // coldsTappingL3DataTableCasting_No
            // 
            this.coldsTappingL3DataTableCasting_No.Caption = "Casting_No";
            this.coldsTappingL3DataTableCasting_No.ColumnName = "Casting_No";
            this.coldsTappingL3DataTableCasting_No.Namespace = "";
            // 
            // coldsTappingL3DataTableCasting_Heat_Cnt
            // 
            this.coldsTappingL3DataTableCasting_Heat_Cnt.Caption = "Casting_Heat_Cnt";
            this.coldsTappingL3DataTableCasting_Heat_Cnt.ColumnName = "Casting_Heat_Cnt";
            this.coldsTappingL3DataTableCasting_Heat_Cnt.DataType = typeof(int);
            this.coldsTappingL3DataTableCasting_Heat_Cnt.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_IronPrepared
            // 
            this.coldsTappingL3DataTableAim_Time_IronPrepared.Caption = "Aim_Time_IronPrepared";
            this.coldsTappingL3DataTableAim_Time_IronPrepared.ColumnName = "Aim_Time_IronPrepared";
            this.coldsTappingL3DataTableAim_Time_IronPrepared.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_IronPrepared.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_BOFStart
            // 
            this.coldsTappingL3DataTableAim_Time_BOFStart.Caption = "Aim_Time_BOFStart";
            this.coldsTappingL3DataTableAim_Time_BOFStart.ColumnName = "Aim_Time_BOFStart";
            this.coldsTappingL3DataTableAim_Time_BOFStart.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_BOFStart.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_BOFTapped
            // 
            this.coldsTappingL3DataTableAim_Time_BOFTapped.Caption = "Aim_Time_BOFTapped";
            this.coldsTappingL3DataTableAim_Time_BOFTapped.ColumnName = "Aim_Time_BOFTapped";
            this.coldsTappingL3DataTableAim_Time_BOFTapped.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_BOFTapped.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_TappedSideEnd
            // 
            this.coldsTappingL3DataTableAim_Time_TappedSideEnd.Caption = "Aim_Time_TappedSideEnd";
            this.coldsTappingL3DataTableAim_Time_TappedSideEnd.ColumnName = "Aim_Time_TappedSideEnd";
            this.coldsTappingL3DataTableAim_Time_TappedSideEnd.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_TappedSideEnd.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_LFArrival
            // 
            this.coldsTappingL3DataTableAim_Time_LFArrival.Caption = "Aim_Time_LFArrival";
            this.coldsTappingL3DataTableAim_Time_LFArrival.ColumnName = "Aim_Time_LFArrival";
            this.coldsTappingL3DataTableAim_Time_LFArrival.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_LFArrival.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_LFStart
            // 
            this.coldsTappingL3DataTableAim_Time_LFStart.Caption = "Aim_Time_LFStart";
            this.coldsTappingL3DataTableAim_Time_LFStart.ColumnName = "Aim_Time_LFStart";
            this.coldsTappingL3DataTableAim_Time_LFStart.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_LFStart.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_LFEnd
            // 
            this.coldsTappingL3DataTableAim_Time_LFEnd.Caption = "Aim_Time_LFEnd";
            this.coldsTappingL3DataTableAim_Time_LFEnd.ColumnName = "Aim_Time_LFEnd";
            this.coldsTappingL3DataTableAim_Time_LFEnd.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_LFEnd.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_LFLeave
            // 
            this.coldsTappingL3DataTableAim_Time_LFLeave.Caption = "Aim_Time_LFLeave";
            this.coldsTappingL3DataTableAim_Time_LFLeave.ColumnName = "Aim_Time_LFLeave";
            this.coldsTappingL3DataTableAim_Time_LFLeave.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_LFLeave.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_RHArrival
            // 
            this.coldsTappingL3DataTableAim_Time_RHArrival.Caption = "Aim_Time_RHArrival";
            this.coldsTappingL3DataTableAim_Time_RHArrival.ColumnName = "Aim_Time_RHArrival";
            this.coldsTappingL3DataTableAim_Time_RHArrival.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_RHArrival.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_RHStart
            // 
            this.coldsTappingL3DataTableAim_Time_RHStart.Caption = "Aim_Time_RHStart";
            this.coldsTappingL3DataTableAim_Time_RHStart.ColumnName = "Aim_Time_RHStart";
            this.coldsTappingL3DataTableAim_Time_RHStart.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_RHStart.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_RHEnd
            // 
            this.coldsTappingL3DataTableAim_Time_RHEnd.Caption = "Aim_Time_RHEnd";
            this.coldsTappingL3DataTableAim_Time_RHEnd.ColumnName = "Aim_Time_RHEnd";
            this.coldsTappingL3DataTableAim_Time_RHEnd.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_RHEnd.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_RHLeave
            // 
            this.coldsTappingL3DataTableAim_Time_RHLeave.Caption = "Aim_Time_RHLeave";
            this.coldsTappingL3DataTableAim_Time_RHLeave.ColumnName = "Aim_Time_RHLeave";
            this.coldsTappingL3DataTableAim_Time_RHLeave.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_RHLeave.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_CasterArrival
            // 
            this.coldsTappingL3DataTableAim_Time_CasterArrival.Caption = "Aim_Time_CasterArrival";
            this.coldsTappingL3DataTableAim_Time_CasterArrival.ColumnName = "Aim_Time_CasterArrival";
            this.coldsTappingL3DataTableAim_Time_CasterArrival.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_CasterArrival.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_CastingStart
            // 
            this.coldsTappingL3DataTableAim_Time_CastingStart.Caption = "Aim_Time_CastingStart";
            this.coldsTappingL3DataTableAim_Time_CastingStart.ColumnName = "Aim_Time_CastingStart";
            this.coldsTappingL3DataTableAim_Time_CastingStart.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_CastingStart.Namespace = "";
            // 
            // coldsTappingL3DataTableAim_Time_CastingEnd
            // 
            this.coldsTappingL3DataTableAim_Time_CastingEnd.Caption = "Aim_Time_CastingEnd";
            this.coldsTappingL3DataTableAim_Time_CastingEnd.ColumnName = "Aim_Time_CastingEnd";
            this.coldsTappingL3DataTableAim_Time_CastingEnd.DataType = typeof(System.DateTime);
            this.coldsTappingL3DataTableAim_Time_CastingEnd.Namespace = "";
            // 
            // coldsTappingL3DataTableFir_Heat_Flag
            // 
            this.coldsTappingL3DataTableFir_Heat_Flag.Caption = "Fir_Heat_Flag";
            this.coldsTappingL3DataTableFir_Heat_Flag.ColumnName = "Fir_Heat_Flag";
            this.coldsTappingL3DataTableFir_Heat_Flag.DataType = typeof(int);
            this.coldsTappingL3DataTableFir_Heat_Flag.Namespace = "";
            // 
            // coldsTappingL3DataTableDiv_HeatID
            // 
            this.coldsTappingL3DataTableDiv_HeatID.Caption = "Div_HeatID";
            this.coldsTappingL3DataTableDiv_HeatID.ColumnName = "Div_HeatID";
            this.coldsTappingL3DataTableDiv_HeatID.Namespace = "";
            // 
            // coldsTappingL3DataTableTeamID
            // 
            this.coldsTappingL3DataTableTeamID.Caption = "TeamID";
            this.coldsTappingL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsTappingL3DataTableTeamID.Namespace = "";
            // 
            // coldsTappingL3DataTableShiftID
            // 
            this.coldsTappingL3DataTableShiftID.Caption = "ShiftID";
            this.coldsTappingL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsTappingL3DataTableShiftID.Namespace = "";
            // 
            // coldsTappingL3DataTableSteelGradeIndex
            // 
            this.coldsTappingL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsTappingL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsTappingL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsTappingL3DataTableSteelGrade
            // 
            this.coldsTappingL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsTappingL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsTappingL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsTappingL3DataTablePlan_Ord_ID
            // 
            this.coldsTappingL3DataTablePlan_Ord_ID.Caption = "Plan_Ord_ID";
            this.coldsTappingL3DataTablePlan_Ord_ID.ColumnName = "Plan_Ord_ID";
            this.coldsTappingL3DataTablePlan_Ord_ID.Namespace = "";
            // 
            // coldsTappingL3DataTableHot_Send_Flag
            // 
            this.coldsTappingL3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coldsTappingL3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coldsTappingL3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coldsTappingL3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coldsTappingL3DataTableSteel_Return_Flag
            // 
            this.coldsTappingL3DataTableSteel_Return_Flag.Caption = "Steel_Return_Flag";
            this.coldsTappingL3DataTableSteel_Return_Flag.ColumnName = "Steel_Return_Flag";
            this.coldsTappingL3DataTableSteel_Return_Flag.DataType = typeof(int);
            this.coldsTappingL3DataTableSteel_Return_Flag.Namespace = "";
            // 
            // coldsTappingL3DataTableSteel_Back_Flag
            // 
            this.coldsTappingL3DataTableSteel_Back_Flag.Caption = "Steel_Back_Flag";
            this.coldsTappingL3DataTableSteel_Back_Flag.ColumnName = "Steel_Back_Flag";
            this.coldsTappingL3DataTableSteel_Back_Flag.DataType = typeof(int);
            this.coldsTappingL3DataTableSteel_Back_Flag.Namespace = "";
            // 
            // coldsTappingL3DataTableTreat_Seq
            // 
            this.coldsTappingL3DataTableTreat_Seq.Caption = "Treat_Seq";
            this.coldsTappingL3DataTableTreat_Seq.ColumnName = "Treat_Seq";
            this.coldsTappingL3DataTableTreat_Seq.Namespace = "";
            // 
            // coldsTappingL3DataTableDestitation
            // 
            this.coldsTappingL3DataTableDestitation.Caption = "Destitation";
            this.coldsTappingL3DataTableDestitation.ColumnName = "Destitation";
            this.coldsTappingL3DataTableDestitation.Namespace = "";
            // 
            // coldsTappingL3DataTableNew_BOF_Flag
            // 
            this.coldsTappingL3DataTableNew_BOF_Flag.Caption = "New_BOF_Flag";
            this.coldsTappingL3DataTableNew_BOF_Flag.ColumnName = "New_BOF_Flag";
            this.coldsTappingL3DataTableNew_BOF_Flag.DataType = typeof(bool);
            this.coldsTappingL3DataTableNew_BOF_Flag.Namespace = "";
            // 
            // coldsTappingL3DataTableRefine_Type
            // 
            this.coldsTappingL3DataTableRefine_Type.Caption = "Refine_Type";
            this.coldsTappingL3DataTableRefine_Type.ColumnName = "Refine_Type";
            this.coldsTappingL3DataTableRefine_Type.Namespace = "";
            // 
            // coldsTappingL3DataTableLength
            // 
            this.coldsTappingL3DataTableLength.Caption = "Length";
            this.coldsTappingL3DataTableLength.ColumnName = "Length";
            this.coldsTappingL3DataTableLength.DataType = typeof(int);
            this.coldsTappingL3DataTableLength.Namespace = "";
            // 
            // coldsTappingL3DataTableWidth
            // 
            this.coldsTappingL3DataTableWidth.Caption = "Width";
            this.coldsTappingL3DataTableWidth.ColumnName = "Width";
            this.coldsTappingL3DataTableWidth.DataType = typeof(int);
            this.coldsTappingL3DataTableWidth.Namespace = "";
            // 
            // coldsTappingL3DataTableThickness
            // 
            this.coldsTappingL3DataTableThickness.Caption = "Thickness";
            this.coldsTappingL3DataTableThickness.ColumnName = "Thickness";
            this.coldsTappingL3DataTableThickness.DataType = typeof(int);
            this.coldsTappingL3DataTableThickness.Namespace = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "炉号:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTapping, "HeatID", true));
            this.textBox1.Location = new System.Drawing.Point(149, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 155;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "大包开浇时刻";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTapping, "Aim_Time_CastingStart", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(149, 126);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(188, 21);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // cmdChangePlanTime
            // 
            this.cmdChangePlanTime.Adapter = this.Adapter;
            this.cmdChangePlanTime.MergeReturnTarget = false;
            this.cmdChangePlanTime.Method = "ModifyTappingPlanTimeInfor";
            this.cmdChangePlanTime.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdChangePlanTime.Parameters.Add(this.l3CommandParameter1);
            this.cmdChangePlanTime.ReturnTarget = null;
            this.cmdChangePlanTime.ReturnTargetProperty = null;
            this.cmdChangePlanTime.Trigger = null;
            this.cmdChangePlanTime.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsTapping;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // UpdateControl
            // 
            this.ClientSize = new System.Drawing.Size(619, 325);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateControl";
            this.TabText = "修改大包开浇时刻";
            this.Text = "修改大包开浇时刻";
            this.Load += new System.EventHandler(this.UpdateControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsTapping;
        private AppSvrHMI.L3DataSet dsTapping;
        private System.Data.DataTable schemadsTapping;
        private System.Data.DataColumn coldsTappingL3DataTablePlanID;
        private System.Data.DataColumn coldsTappingL3DataTableContractID;
        private System.Data.DataColumn coldsTappingL3DataTableStatus;
        private System.Data.DataColumn coldsTappingL3DataTablePlanDept;
        private System.Data.DataColumn coldsTappingL3DataTableExecuteDept;
        private System.Data.DataColumn coldsTappingL3DataTableCreateDate;
        private System.Data.DataColumn coldsTappingL3DataTablePlanExecuteDate;
        private System.Data.DataColumn coldsTappingL3DataTableActualExecuteDate;
        private System.Data.DataColumn coldsTappingL3DataTablePlanner;
        private System.Data.DataColumn coldsTappingL3DataTablePre_LotNo;
        private System.Data.DataColumn coldsTappingL3DataTablePreHeatID;
        private System.Data.DataColumn coldsTappingL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsTappingL3DataTablePre_SteelGrade;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Tapped_Weight;
        private System.Data.DataColumn coldsTappingL3DataTableCasterID;
        private System.Data.DataColumn coldsTappingL3DataTableBOFID;
        private System.Data.DataColumn coldsTappingL3DataTableLFID;
        private System.Data.DataColumn coldsTappingL3DataTableRHID;
        private System.Data.DataColumn coldsTappingL3DataTableBOF_Status;
        private System.Data.DataColumn coldsTappingL3DataTableLF_Status;
        private System.Data.DataColumn coldsTappingL3DataTableRH_Status;
        private System.Data.DataColumn coldsTappingL3DataTableCaster_Status;
        private System.Data.DataColumn coldsTappingL3DataTableSide_Status;
        private System.Data.DataColumn coldsTappingL3DataTableHeatID;
        private System.Data.DataColumn coldsTappingL3DataTableCasting_No;
        private System.Data.DataColumn coldsTappingL3DataTableCasting_Heat_Cnt;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_IronPrepared;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_BOFStart;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_BOFTapped;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_TappedSideEnd;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_LFArrival;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_LFStart;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_LFEnd;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_LFLeave;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_RHArrival;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_RHStart;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_RHEnd;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_RHLeave;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_CasterArrival;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_CastingStart;
        private System.Data.DataColumn coldsTappingL3DataTableAim_Time_CastingEnd;
        private System.Data.DataColumn coldsTappingL3DataTableFir_Heat_Flag;
        private System.Data.DataColumn coldsTappingL3DataTableDiv_HeatID;
        private System.Data.DataColumn coldsTappingL3DataTableTeamID;
        private System.Data.DataColumn coldsTappingL3DataTableShiftID;
        private System.Data.DataColumn coldsTappingL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsTappingL3DataTableSteelGrade;
        private System.Data.DataColumn coldsTappingL3DataTablePlan_Ord_ID;
        private System.Data.DataColumn coldsTappingL3DataTableHot_Send_Flag;
        private System.Data.DataColumn coldsTappingL3DataTableSteel_Return_Flag;
        private System.Data.DataColumn coldsTappingL3DataTableSteel_Back_Flag;
        private System.Data.DataColumn coldsTappingL3DataTableTreat_Seq;
        private System.Data.DataColumn coldsTappingL3DataTableDestitation;
        private System.Data.DataColumn coldsTappingL3DataTableNew_BOF_Flag;
        private System.Data.DataColumn coldsTappingL3DataTableRefine_Type;
        private System.Data.DataColumn coldsTappingL3DataTableLength;
        private System.Data.DataColumn coldsTappingL3DataTableWidth;
        private System.Data.DataColumn coldsTappingL3DataTableThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private AppSvrHMI.L3Command cmdChangePlanTime;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
    }
}