namespace PlanMag
{
    partial class TappingPlanQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TappingPlanQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executeDeptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualExecuteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preLotNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTappedWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rHStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.casterStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castingNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castingHeatCntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeIronPreparedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeBOFStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeBOFTappedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeTappedSideEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeLFArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeLFStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeLFEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeLFLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeRHArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeRHStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeRHEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeRHLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeCasterArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeCastingStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aimTimeCastingEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firHeatFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planOrdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotSendFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelReturnFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelBackFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatSeqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destitationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBOFFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thicknessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsInStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsInStore = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet9 = new System.Data.DataTable();
            this.coll3DataSet9L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableName = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePlanID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableContractID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableStatus = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePlanDept = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableExecuteDept = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCreateDate = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePlanExecuteDate = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableActualExecuteDate = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePlanner = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePre_LotNo = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePre_SteelGradeIndex = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePre_SteelGrade = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Tapped_Weight = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCasterID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableLFID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableRHID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableBOF_Status = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableLF_Status = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableRH_Status = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCaster_Status = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSide_Status = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCasting_No = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCasting_Heat_Cnt = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_IronPrepared = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_BOFStart = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_BOFTapped = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_TappedSideEnd = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_LFArrival = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_LFStart = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_LFEnd = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_LFLeave = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_RHArrival = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_RHStart = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_RHEnd = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_RHLeave = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_CasterArrival = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_CastingStart = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAim_Time_CastingEnd = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableFir_Heat_Flag = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableDiv_HeatID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePlan_Ord_ID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableHot_Send_Flag = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSteel_Return_Flag = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableSteel_Back_Flag = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableTreat_Seq = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableDestitation = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableNew_BOF_Flag = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableRefine_Type = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableLength = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableWidth = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableThickness = new System.Data.DataColumn();
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
            this.dtInStoreEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtInStoreData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.dsStoreArea = new AppSvrHMI.L3DataSet();
            this.schemadsStoreArea = new System.Data.DataTable();
            this.coldsStoreAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(887, 533);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInStore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.planIDDataGridViewTextBoxColumn,
            this.contractIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.planDeptDataGridViewTextBoxColumn,
            this.executeDeptDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.actualExecuteDateDataGridViewTextBoxColumn,
            this.plannerDataGridViewTextBoxColumn,
            this.preLotNoDataGridViewTextBoxColumn,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.preSteelGradeDataGridViewTextBoxColumn,
            this.aimTappedWeightDataGridViewTextBoxColumn,
            this.casterIDDataGridViewTextBoxColumn,
            this.bOFIDDataGridViewTextBoxColumn,
            this.lFIDDataGridViewTextBoxColumn,
            this.rHIDDataGridViewTextBoxColumn,
            this.bOFStatusDataGridViewTextBoxColumn,
            this.lFStatusDataGridViewTextBoxColumn,
            this.rHStatusDataGridViewTextBoxColumn,
            this.casterStatusDataGridViewTextBoxColumn,
            this.sideStatusDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.castingNoDataGridViewTextBoxColumn,
            this.castingHeatCntDataGridViewTextBoxColumn,
            this.aimTimeIronPreparedDataGridViewTextBoxColumn,
            this.aimTimeBOFStartDataGridViewTextBoxColumn,
            this.aimTimeBOFTappedDataGridViewTextBoxColumn,
            this.aimTimeTappedSideEndDataGridViewTextBoxColumn,
            this.aimTimeLFArrivalDataGridViewTextBoxColumn,
            this.aimTimeLFStartDataGridViewTextBoxColumn,
            this.aimTimeLFEndDataGridViewTextBoxColumn,
            this.aimTimeLFLeaveDataGridViewTextBoxColumn,
            this.aimTimeRHArrivalDataGridViewTextBoxColumn,
            this.aimTimeRHStartDataGridViewTextBoxColumn,
            this.aimTimeRHEndDataGridViewTextBoxColumn,
            this.aimTimeRHLeaveDataGridViewTextBoxColumn,
            this.aimTimeCasterArrivalDataGridViewTextBoxColumn,
            this.aimTimeCastingStartDataGridViewTextBoxColumn,
            this.aimTimeCastingEndDataGridViewTextBoxColumn,
            this.firHeatFlagDataGridViewTextBoxColumn,
            this.divHeatIDDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.planOrdIDDataGridViewTextBoxColumn,
            this.hotSendFlagDataGridViewTextBoxColumn,
            this.steelReturnFlagDataGridViewTextBoxColumn,
            this.steelBackFlagDataGridViewTextBoxColumn,
            this.treatSeqDataGridViewTextBoxColumn,
            this.destitationDataGridViewTextBoxColumn,
            this.newBOFFlagDataGridViewCheckBoxColumn,
            this.refineTypeDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.thicknessDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsInStore;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.ReadOnly = true;
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(887, 508);
            this.dvInStore.TabIndex = 29;
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
            // planIDDataGridViewTextBoxColumn
            // 
            this.planIDDataGridViewTextBoxColumn.DataPropertyName = "PlanID";
            this.planIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.planIDDataGridViewTextBoxColumn.Name = "planIDDataGridViewTextBoxColumn";
            this.planIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.planIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // contractIDDataGridViewTextBoxColumn
            // 
            this.contractIDDataGridViewTextBoxColumn.DataPropertyName = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.HeaderText = "合同号";
            this.contractIDDataGridViewTextBoxColumn.Name = "contractIDDataGridViewTextBoxColumn";
            this.contractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractIDDataGridViewTextBoxColumn.Visible = false;
            this.contractIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "计划状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 78;
            // 
            // planDeptDataGridViewTextBoxColumn
            // 
            this.planDeptDataGridViewTextBoxColumn.DataPropertyName = "PlanDept";
            this.planDeptDataGridViewTextBoxColumn.HeaderText = "计划制订单位";
            this.planDeptDataGridViewTextBoxColumn.Name = "planDeptDataGridViewTextBoxColumn";
            this.planDeptDataGridViewTextBoxColumn.ReadOnly = true;
            this.planDeptDataGridViewTextBoxColumn.Visible = false;
            this.planDeptDataGridViewTextBoxColumn.Width = 102;
            // 
            // executeDeptDataGridViewTextBoxColumn
            // 
            this.executeDeptDataGridViewTextBoxColumn.DataPropertyName = "ExecuteDept";
            this.executeDeptDataGridViewTextBoxColumn.HeaderText = "计划执行单位";
            this.executeDeptDataGridViewTextBoxColumn.Name = "executeDeptDataGridViewTextBoxColumn";
            this.executeDeptDataGridViewTextBoxColumn.ReadOnly = true;
            this.executeDeptDataGridViewTextBoxColumn.Visible = false;
            this.executeDeptDataGridViewTextBoxColumn.Width = 102;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "计划日期";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 78;
            // 
            // actualExecuteDateDataGridViewTextBoxColumn
            // 
            this.actualExecuteDateDataGridViewTextBoxColumn.DataPropertyName = "ActualExecuteDate";
            this.actualExecuteDateDataGridViewTextBoxColumn.HeaderText = "实际执行日期";
            this.actualExecuteDateDataGridViewTextBoxColumn.Name = "actualExecuteDateDataGridViewTextBoxColumn";
            this.actualExecuteDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.actualExecuteDateDataGridViewTextBoxColumn.Visible = false;
            this.actualExecuteDateDataGridViewTextBoxColumn.Width = 102;
            // 
            // plannerDataGridViewTextBoxColumn
            // 
            this.plannerDataGridViewTextBoxColumn.DataPropertyName = "Planner";
            this.plannerDataGridViewTextBoxColumn.HeaderText = "计划员";
            this.plannerDataGridViewTextBoxColumn.Name = "plannerDataGridViewTextBoxColumn";
            this.plannerDataGridViewTextBoxColumn.ReadOnly = true;
            this.plannerDataGridViewTextBoxColumn.Width = 66;
            // 
            // preLotNoDataGridViewTextBoxColumn
            // 
            this.preLotNoDataGridViewTextBoxColumn.DataPropertyName = "Pre_LotNo";
            this.preLotNoDataGridViewTextBoxColumn.HeaderText = "预定包次号";
            this.preLotNoDataGridViewTextBoxColumn.Name = "preLotNoDataGridViewTextBoxColumn";
            this.preLotNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.preLotNoDataGridViewTextBoxColumn.Visible = false;
            this.preLotNoDataGridViewTextBoxColumn.Width = 90;
            // 
            // preHeatIDDataGridViewTextBoxColumn
            // 
            this.preHeatIDDataGridViewTextBoxColumn.DataPropertyName = "PreHeatID";
            this.preHeatIDDataGridViewTextBoxColumn.HeaderText = "预定炉号";
            this.preHeatIDDataGridViewTextBoxColumn.Name = "preHeatIDDataGridViewTextBoxColumn";
            this.preHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.preHeatIDDataGridViewTextBoxColumn.Visible = false;
            this.preHeatIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // preSteelGradeIndexDataGridViewTextBoxColumn
            // 
            this.preSteelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGradeIndex";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.HeaderText = "预定炼钢记号";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Name = "preSteelGradeIndexDataGridViewTextBoxColumn";
            this.preSteelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.preSteelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // preSteelGradeDataGridViewTextBoxColumn
            // 
            this.preSteelGradeDataGridViewTextBoxColumn.DataPropertyName = "Pre_SteelGrade";
            this.preSteelGradeDataGridViewTextBoxColumn.HeaderText = "预定钢种";
            this.preSteelGradeDataGridViewTextBoxColumn.Name = "preSteelGradeDataGridViewTextBoxColumn";
            this.preSteelGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.preSteelGradeDataGridViewTextBoxColumn.Width = 78;
            // 
            // aimTappedWeightDataGridViewTextBoxColumn
            // 
            this.aimTappedWeightDataGridViewTextBoxColumn.DataPropertyName = "Aim_Tapped_Weight";
            this.aimTappedWeightDataGridViewTextBoxColumn.HeaderText = "目标出钢量";
            this.aimTappedWeightDataGridViewTextBoxColumn.Name = "aimTappedWeightDataGridViewTextBoxColumn";
            this.aimTappedWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTappedWeightDataGridViewTextBoxColumn.Width = 90;
            // 
            // casterIDDataGridViewTextBoxColumn
            // 
            this.casterIDDataGridViewTextBoxColumn.DataPropertyName = "CasterID";
            this.casterIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.casterIDDataGridViewTextBoxColumn.Name = "casterIDDataGridViewTextBoxColumn";
            this.casterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.casterIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "转炉炉座号";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOFIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // lFIDDataGridViewTextBoxColumn
            // 
            this.lFIDDataGridViewTextBoxColumn.DataPropertyName = "LFID";
            this.lFIDDataGridViewTextBoxColumn.HeaderText = "LF炉座号";
            this.lFIDDataGridViewTextBoxColumn.Name = "lFIDDataGridViewTextBoxColumn";
            this.lFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lFIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // rHIDDataGridViewTextBoxColumn
            // 
            this.rHIDDataGridViewTextBoxColumn.DataPropertyName = "RHID";
            this.rHIDDataGridViewTextBoxColumn.HeaderText = "RH炉座号";
            this.rHIDDataGridViewTextBoxColumn.Name = "rHIDDataGridViewTextBoxColumn";
            this.rHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rHIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // bOFStatusDataGridViewTextBoxColumn
            // 
            this.bOFStatusDataGridViewTextBoxColumn.DataPropertyName = "BOF_Status";
            this.bOFStatusDataGridViewTextBoxColumn.HeaderText = "转炉状态";
            this.bOFStatusDataGridViewTextBoxColumn.Name = "bOFStatusDataGridViewTextBoxColumn";
            this.bOFStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOFStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // lFStatusDataGridViewTextBoxColumn
            // 
            this.lFStatusDataGridViewTextBoxColumn.DataPropertyName = "LF_Status";
            this.lFStatusDataGridViewTextBoxColumn.HeaderText = "LF炉状态";
            this.lFStatusDataGridViewTextBoxColumn.Name = "lFStatusDataGridViewTextBoxColumn";
            this.lFStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.lFStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // rHStatusDataGridViewTextBoxColumn
            // 
            this.rHStatusDataGridViewTextBoxColumn.DataPropertyName = "RH_Status";
            this.rHStatusDataGridViewTextBoxColumn.HeaderText = "RH炉状态";
            this.rHStatusDataGridViewTextBoxColumn.Name = "rHStatusDataGridViewTextBoxColumn";
            this.rHStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.rHStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // casterStatusDataGridViewTextBoxColumn
            // 
            this.casterStatusDataGridViewTextBoxColumn.DataPropertyName = "Caster_Status";
            this.casterStatusDataGridViewTextBoxColumn.HeaderText = "铸机状态";
            this.casterStatusDataGridViewTextBoxColumn.Name = "casterStatusDataGridViewTextBoxColumn";
            this.casterStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.casterStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // sideStatusDataGridViewTextBoxColumn
            // 
            this.sideStatusDataGridViewTextBoxColumn.DataPropertyName = "Side_Status";
            this.sideStatusDataGridViewTextBoxColumn.HeaderText = "炉后状态";
            this.sideStatusDataGridViewTextBoxColumn.Name = "sideStatusDataGridViewTextBoxColumn";
            this.sideStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.sideStatusDataGridViewTextBoxColumn.Width = 78;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // castingNoDataGridViewTextBoxColumn
            // 
            this.castingNoDataGridViewTextBoxColumn.DataPropertyName = "Casting_No";
            this.castingNoDataGridViewTextBoxColumn.HeaderText = "浇次号";
            this.castingNoDataGridViewTextBoxColumn.Name = "castingNoDataGridViewTextBoxColumn";
            this.castingNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.castingNoDataGridViewTextBoxColumn.Width = 66;
            // 
            // castingHeatCntDataGridViewTextBoxColumn
            // 
            this.castingHeatCntDataGridViewTextBoxColumn.DataPropertyName = "Casting_Heat_Cnt";
            this.castingHeatCntDataGridViewTextBoxColumn.HeaderText = "浇次内炉数";
            this.castingHeatCntDataGridViewTextBoxColumn.Name = "castingHeatCntDataGridViewTextBoxColumn";
            this.castingHeatCntDataGridViewTextBoxColumn.ReadOnly = true;
            this.castingHeatCntDataGridViewTextBoxColumn.Width = 90;
            // 
            // aimTimeIronPreparedDataGridViewTextBoxColumn
            // 
            this.aimTimeIronPreparedDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_IronPrepared";
            this.aimTimeIronPreparedDataGridViewTextBoxColumn.HeaderText = "主原料装入时刻（铁水准备终）";
            this.aimTimeIronPreparedDataGridViewTextBoxColumn.Name = "aimTimeIronPreparedDataGridViewTextBoxColumn";
            this.aimTimeIronPreparedDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeIronPreparedDataGridViewTextBoxColumn.Width = 198;
            // 
            // aimTimeBOFStartDataGridViewTextBoxColumn
            // 
            this.aimTimeBOFStartDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_BOFStart";
            this.aimTimeBOFStartDataGridViewTextBoxColumn.HeaderText = "吹炼始";
            this.aimTimeBOFStartDataGridViewTextBoxColumn.Name = "aimTimeBOFStartDataGridViewTextBoxColumn";
            this.aimTimeBOFStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeBOFStartDataGridViewTextBoxColumn.Width = 66;
            // 
            // aimTimeBOFTappedDataGridViewTextBoxColumn
            // 
            this.aimTimeBOFTappedDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_BOFTapped";
            this.aimTimeBOFTappedDataGridViewTextBoxColumn.HeaderText = "出钢终";
            this.aimTimeBOFTappedDataGridViewTextBoxColumn.Name = "aimTimeBOFTappedDataGridViewTextBoxColumn";
            this.aimTimeBOFTappedDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeBOFTappedDataGridViewTextBoxColumn.Width = 66;
            // 
            // aimTimeTappedSideEndDataGridViewTextBoxColumn
            // 
            this.aimTimeTappedSideEndDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_TappedSideEnd";
            this.aimTimeTappedSideEndDataGridViewTextBoxColumn.HeaderText = "炉后处理结束";
            this.aimTimeTappedSideEndDataGridViewTextBoxColumn.Name = "aimTimeTappedSideEndDataGridViewTextBoxColumn";
            this.aimTimeTappedSideEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeTappedSideEndDataGridViewTextBoxColumn.Width = 102;
            // 
            // aimTimeLFArrivalDataGridViewTextBoxColumn
            // 
            this.aimTimeLFArrivalDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_LFArrival";
            this.aimTimeLFArrivalDataGridViewTextBoxColumn.HeaderText = "LF进站时刻";
            this.aimTimeLFArrivalDataGridViewTextBoxColumn.Name = "aimTimeLFArrivalDataGridViewTextBoxColumn";
            this.aimTimeLFArrivalDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeLFArrivalDataGridViewTextBoxColumn.Width = 90;
            // 
            // aimTimeLFStartDataGridViewTextBoxColumn
            // 
            this.aimTimeLFStartDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_LFStart";
            this.aimTimeLFStartDataGridViewTextBoxColumn.HeaderText = "LF始";
            this.aimTimeLFStartDataGridViewTextBoxColumn.Name = "aimTimeLFStartDataGridViewTextBoxColumn";
            this.aimTimeLFStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeLFStartDataGridViewTextBoxColumn.Width = 54;
            // 
            // aimTimeLFEndDataGridViewTextBoxColumn
            // 
            this.aimTimeLFEndDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_LFEnd";
            this.aimTimeLFEndDataGridViewTextBoxColumn.HeaderText = "LF终";
            this.aimTimeLFEndDataGridViewTextBoxColumn.Name = "aimTimeLFEndDataGridViewTextBoxColumn";
            this.aimTimeLFEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeLFEndDataGridViewTextBoxColumn.Width = 54;
            // 
            // aimTimeLFLeaveDataGridViewTextBoxColumn
            // 
            this.aimTimeLFLeaveDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_LFLeave";
            this.aimTimeLFLeaveDataGridViewTextBoxColumn.HeaderText = "LF出站时刻";
            this.aimTimeLFLeaveDataGridViewTextBoxColumn.Name = "aimTimeLFLeaveDataGridViewTextBoxColumn";
            this.aimTimeLFLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeLFLeaveDataGridViewTextBoxColumn.Width = 90;
            // 
            // aimTimeRHArrivalDataGridViewTextBoxColumn
            // 
            this.aimTimeRHArrivalDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_RHArrival";
            this.aimTimeRHArrivalDataGridViewTextBoxColumn.HeaderText = "RH进站时刻";
            this.aimTimeRHArrivalDataGridViewTextBoxColumn.Name = "aimTimeRHArrivalDataGridViewTextBoxColumn";
            this.aimTimeRHArrivalDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeRHArrivalDataGridViewTextBoxColumn.Width = 90;
            // 
            // aimTimeRHStartDataGridViewTextBoxColumn
            // 
            this.aimTimeRHStartDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_RHStart";
            this.aimTimeRHStartDataGridViewTextBoxColumn.HeaderText = "RH始";
            this.aimTimeRHStartDataGridViewTextBoxColumn.Name = "aimTimeRHStartDataGridViewTextBoxColumn";
            this.aimTimeRHStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeRHStartDataGridViewTextBoxColumn.Width = 54;
            // 
            // aimTimeRHEndDataGridViewTextBoxColumn
            // 
            this.aimTimeRHEndDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_RHEnd";
            this.aimTimeRHEndDataGridViewTextBoxColumn.HeaderText = "RH终";
            this.aimTimeRHEndDataGridViewTextBoxColumn.Name = "aimTimeRHEndDataGridViewTextBoxColumn";
            this.aimTimeRHEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeRHEndDataGridViewTextBoxColumn.Width = 54;
            // 
            // aimTimeRHLeaveDataGridViewTextBoxColumn
            // 
            this.aimTimeRHLeaveDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_RHLeave";
            this.aimTimeRHLeaveDataGridViewTextBoxColumn.HeaderText = "RH出站时刻";
            this.aimTimeRHLeaveDataGridViewTextBoxColumn.Name = "aimTimeRHLeaveDataGridViewTextBoxColumn";
            this.aimTimeRHLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeRHLeaveDataGridViewTextBoxColumn.Width = 90;
            // 
            // aimTimeCasterArrivalDataGridViewTextBoxColumn
            // 
            this.aimTimeCasterArrivalDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_CasterArrival";
            this.aimTimeCasterArrivalDataGridViewTextBoxColumn.HeaderText = "铸机到达时刻";
            this.aimTimeCasterArrivalDataGridViewTextBoxColumn.Name = "aimTimeCasterArrivalDataGridViewTextBoxColumn";
            this.aimTimeCasterArrivalDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeCasterArrivalDataGridViewTextBoxColumn.Width = 102;
            // 
            // aimTimeCastingStartDataGridViewTextBoxColumn
            // 
            this.aimTimeCastingStartDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_CastingStart";
            this.aimTimeCastingStartDataGridViewTextBoxColumn.HeaderText = "注入始";
            this.aimTimeCastingStartDataGridViewTextBoxColumn.Name = "aimTimeCastingStartDataGridViewTextBoxColumn";
            this.aimTimeCastingStartDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeCastingStartDataGridViewTextBoxColumn.Width = 66;
            // 
            // aimTimeCastingEndDataGridViewTextBoxColumn
            // 
            this.aimTimeCastingEndDataGridViewTextBoxColumn.DataPropertyName = "Aim_Time_CastingEnd";
            this.aimTimeCastingEndDataGridViewTextBoxColumn.HeaderText = "注入终";
            this.aimTimeCastingEndDataGridViewTextBoxColumn.Name = "aimTimeCastingEndDataGridViewTextBoxColumn";
            this.aimTimeCastingEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.aimTimeCastingEndDataGridViewTextBoxColumn.Width = 66;
            // 
            // firHeatFlagDataGridViewTextBoxColumn
            // 
            this.firHeatFlagDataGridViewTextBoxColumn.DataPropertyName = "Fir_Heat_Flag";
            this.firHeatFlagDataGridViewTextBoxColumn.HeaderText = "浇次第一炉标志";
            this.firHeatFlagDataGridViewTextBoxColumn.Name = "firHeatFlagDataGridViewTextBoxColumn";
            this.firHeatFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.firHeatFlagDataGridViewTextBoxColumn.Width = 114;
            // 
            // divHeatIDDataGridViewTextBoxColumn
            // 
            this.divHeatIDDataGridViewTextBoxColumn.DataPropertyName = "Div_HeatID";
            this.divHeatIDDataGridViewTextBoxColumn.HeaderText = "虚拟熔炼号";
            this.divHeatIDDataGridViewTextBoxColumn.Name = "divHeatIDDataGridViewTextBoxColumn";
            this.divHeatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.divHeatIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamIDDataGridViewTextBoxColumn.Width = 54;
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // shiftIDDataGridViewTextBoxColumn
            // 
            this.shiftIDDataGridViewTextBoxColumn.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftIDDataGridViewTextBoxColumn.Name = "shiftIDDataGridViewTextBoxColumn";
            this.shiftIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftIDDataGridViewTextBoxColumn.Width = 54;
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
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // steelGradeIndexDataGridViewTextBoxColumn
            // 
            this.steelGradeIndexDataGridViewTextBoxColumn.DataPropertyName = "SteelGradeIndex";
            this.steelGradeIndexDataGridViewTextBoxColumn.HeaderText = "实际炼钢记号";
            this.steelGradeIndexDataGridViewTextBoxColumn.Name = "steelGradeIndexDataGridViewTextBoxColumn";
            this.steelGradeIndexDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeIndexDataGridViewTextBoxColumn.Width = 102;
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "实际钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelGradeDataGridViewTextBoxColumn.Width = 78;
            // 
            // planOrdIDDataGridViewTextBoxColumn
            // 
            this.planOrdIDDataGridViewTextBoxColumn.DataPropertyName = "Plan_Ord_ID";
            this.planOrdIDDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.planOrdIDDataGridViewTextBoxColumn.Name = "planOrdIDDataGridViewTextBoxColumn";
            this.planOrdIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.planOrdIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // hotSendFlagDataGridViewTextBoxColumn
            // 
            this.hotSendFlagDataGridViewTextBoxColumn.DataPropertyName = "Hot_Send_Flag";
            this.hotSendFlagDataGridViewTextBoxColumn.HeaderText = "热送标志";
            this.hotSendFlagDataGridViewTextBoxColumn.Name = "hotSendFlagDataGridViewTextBoxColumn";
            this.hotSendFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotSendFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // steelReturnFlagDataGridViewTextBoxColumn
            // 
            this.steelReturnFlagDataGridViewTextBoxColumn.DataPropertyName = "Steel_Return_Flag";
            this.steelReturnFlagDataGridViewTextBoxColumn.HeaderText = "回炉标志";
            this.steelReturnFlagDataGridViewTextBoxColumn.Name = "steelReturnFlagDataGridViewTextBoxColumn";
            this.steelReturnFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelReturnFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // steelBackFlagDataGridViewTextBoxColumn
            // 
            this.steelBackFlagDataGridViewTextBoxColumn.DataPropertyName = "Steel_Back_Flag";
            this.steelBackFlagDataGridViewTextBoxColumn.HeaderText = "返送标志";
            this.steelBackFlagDataGridViewTextBoxColumn.Name = "steelBackFlagDataGridViewTextBoxColumn";
            this.steelBackFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.steelBackFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // treatSeqDataGridViewTextBoxColumn
            // 
            this.treatSeqDataGridViewTextBoxColumn.DataPropertyName = "Treat_Seq";
            this.treatSeqDataGridViewTextBoxColumn.HeaderText = "铸机处理顺序号";
            this.treatSeqDataGridViewTextBoxColumn.Name = "treatSeqDataGridViewTextBoxColumn";
            this.treatSeqDataGridViewTextBoxColumn.ReadOnly = true;
            this.treatSeqDataGridViewTextBoxColumn.Width = 114;
            // 
            // destitationDataGridViewTextBoxColumn
            // 
            this.destitationDataGridViewTextBoxColumn.DataPropertyName = "Destitation";
            this.destitationDataGridViewTextBoxColumn.HeaderText = "去向";
            this.destitationDataGridViewTextBoxColumn.Name = "destitationDataGridViewTextBoxColumn";
            this.destitationDataGridViewTextBoxColumn.ReadOnly = true;
            this.destitationDataGridViewTextBoxColumn.Width = 54;
            // 
            // newBOFFlagDataGridViewCheckBoxColumn
            // 
            this.newBOFFlagDataGridViewCheckBoxColumn.DataPropertyName = "New_BOF_Flag";
            this.newBOFFlagDataGridViewCheckBoxColumn.HeaderText = "转炉标志";
            this.newBOFFlagDataGridViewCheckBoxColumn.Name = "newBOFFlagDataGridViewCheckBoxColumn";
            this.newBOFFlagDataGridViewCheckBoxColumn.ReadOnly = true;
            this.newBOFFlagDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.newBOFFlagDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.newBOFFlagDataGridViewCheckBoxColumn.Width = 59;
            // 
            // refineTypeDataGridViewTextBoxColumn
            // 
            this.refineTypeDataGridViewTextBoxColumn.DataPropertyName = "Refine_Type";
            this.refineTypeDataGridViewTextBoxColumn.HeaderText = "精炼区分";
            this.refineTypeDataGridViewTextBoxColumn.Name = "refineTypeDataGridViewTextBoxColumn";
            this.refineTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.refineTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthDataGridViewTextBoxColumn.Width = 54;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "宽度";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 54;
            // 
            // thicknessDataGridViewTextBoxColumn
            // 
            this.thicknessDataGridViewTextBoxColumn.DataPropertyName = "Thickness";
            this.thicknessDataGridViewTextBoxColumn.HeaderText = "厚度";
            this.thicknessDataGridViewTextBoxColumn.Name = "thicknessDataGridViewTextBoxColumn";
            this.thicknessDataGridViewTextBoxColumn.ReadOnly = true;
            this.thicknessDataGridViewTextBoxColumn.Width = 54;
            // 
            // bsInStore
            // 
            this.bsInStore.DataMember = "L3DataTable";
            this.bsInStore.DataSource = this.dsInStore;
            // 
            // dsInStore
            // 
            this.dsInStore.AutoLoad = true;
            this.dsInStore.AutoSubscribe = false;
            this.dsInStore.DataSetName = "L3DataSet";
            this.dsInStore.DeleteMethod = null;
            this.dsInStore.InsertMethod = null;
            this.dsInStore.L3DataAdapter = this.Adapter;
            this.dsInStore.LoadEvent = "Click";
            this.dsInStore.LoadTrigger = null;
            this.dsInStore.RefreshValve = 1000;
            this.dsInStore.SourceCommand = null;
            this.dsInStore.SourceCondition = "1=2";
            this.dsInStore.SourceMethod = "";
            this.dsInStore.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInStore.SourceURI = "XGMESLogic\\PlanMag\\CPlan_Tapping";
            this.dsInStore.SubscribeTarget = null;
            this.dsInStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet9});
            this.dsInStore.UpdateEvent = "Click";
            this.dsInStore.UpdateMethod = null;
            this.dsInStore.UpdateTrigger = null;
            // 
            // schemal3DataSet9
            // 
            this.schemal3DataSet9.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet9L3DataTableGUID,
            this.coll3DataSet9L3DataTableName,
            this.coldsInStoreL3DataTablePlanID,
            this.coldsInStoreL3DataTableContractID,
            this.coldsInStoreL3DataTableStatus,
            this.coldsInStoreL3DataTablePlanDept,
            this.coldsInStoreL3DataTableExecuteDept,
            this.coldsInStoreL3DataTableCreateDate,
            this.coldsInStoreL3DataTablePlanExecuteDate,
            this.coldsInStoreL3DataTableActualExecuteDate,
            this.coldsInStoreL3DataTablePlanner,
            this.coldsInStoreL3DataTablePre_LotNo,
            this.coldsInStoreL3DataTablePreHeatID,
            this.coldsInStoreL3DataTablePre_SteelGradeIndex,
            this.coldsInStoreL3DataTablePre_SteelGrade,
            this.coldsInStoreL3DataTableAim_Tapped_Weight,
            this.coldsInStoreL3DataTableCasterID,
            this.coldsInStoreL3DataTableBOFID,
            this.coldsInStoreL3DataTableLFID,
            this.coldsInStoreL3DataTableRHID,
            this.coldsInStoreL3DataTableBOF_Status,
            this.coldsInStoreL3DataTableLF_Status,
            this.coldsInStoreL3DataTableRH_Status,
            this.coldsInStoreL3DataTableCaster_Status,
            this.coldsInStoreL3DataTableSide_Status,
            this.coldsInStoreL3DataTableHeatID,
            this.coldsInStoreL3DataTableCasting_No,
            this.coldsInStoreL3DataTableCasting_Heat_Cnt,
            this.coldsInStoreL3DataTableAim_Time_IronPrepared,
            this.coldsInStoreL3DataTableAim_Time_BOFStart,
            this.coldsInStoreL3DataTableAim_Time_BOFTapped,
            this.coldsInStoreL3DataTableAim_Time_TappedSideEnd,
            this.coldsInStoreL3DataTableAim_Time_LFArrival,
            this.coldsInStoreL3DataTableAim_Time_LFStart,
            this.coldsInStoreL3DataTableAim_Time_LFEnd,
            this.coldsInStoreL3DataTableAim_Time_LFLeave,
            this.coldsInStoreL3DataTableAim_Time_RHArrival,
            this.coldsInStoreL3DataTableAim_Time_RHStart,
            this.coldsInStoreL3DataTableAim_Time_RHEnd,
            this.coldsInStoreL3DataTableAim_Time_RHLeave,
            this.coldsInStoreL3DataTableAim_Time_CasterArrival,
            this.coldsInStoreL3DataTableAim_Time_CastingStart,
            this.coldsInStoreL3DataTableAim_Time_CastingEnd,
            this.coldsInStoreL3DataTableFir_Heat_Flag,
            this.coldsInStoreL3DataTableDiv_HeatID,
            this.coldsInStoreL3DataTableTeamID,
            this.coldsInStoreL3DataTableShiftID,
            this.coldsInStoreL3DataTableSteelGradeIndex,
            this.coldsInStoreL3DataTableSteelGrade,
            this.coldsInStoreL3DataTablePlan_Ord_ID,
            this.coldsInStoreL3DataTableHot_Send_Flag,
            this.coldsInStoreL3DataTableSteel_Return_Flag,
            this.coldsInStoreL3DataTableSteel_Back_Flag,
            this.coldsInStoreL3DataTableTreat_Seq,
            this.coldsInStoreL3DataTableDestitation,
            this.coldsInStoreL3DataTableNew_BOF_Flag,
            this.coldsInStoreL3DataTableRefine_Type,
            this.coldsInStoreL3DataTableLength,
            this.coldsInStoreL3DataTableWidth,
            this.coldsInStoreL3DataTableThickness});
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
            // coldsInStoreL3DataTablePlanID
            // 
            this.coldsInStoreL3DataTablePlanID.Caption = "PlanID";
            this.coldsInStoreL3DataTablePlanID.ColumnName = "PlanID";
            this.coldsInStoreL3DataTablePlanID.Namespace = "";
            // 
            // coldsInStoreL3DataTableContractID
            // 
            this.coldsInStoreL3DataTableContractID.Caption = "ContractID";
            this.coldsInStoreL3DataTableContractID.ColumnName = "ContractID";
            this.coldsInStoreL3DataTableContractID.Namespace = "";
            // 
            // coldsInStoreL3DataTableStatus
            // 
            this.coldsInStoreL3DataTableStatus.Caption = "Status";
            this.coldsInStoreL3DataTableStatus.ColumnName = "Status";
            this.coldsInStoreL3DataTableStatus.DataType = typeof(int);
            this.coldsInStoreL3DataTableStatus.Namespace = "";
            // 
            // coldsInStoreL3DataTablePlanDept
            // 
            this.coldsInStoreL3DataTablePlanDept.Caption = "PlanDept";
            this.coldsInStoreL3DataTablePlanDept.ColumnName = "PlanDept";
            this.coldsInStoreL3DataTablePlanDept.Namespace = "";
            // 
            // coldsInStoreL3DataTableExecuteDept
            // 
            this.coldsInStoreL3DataTableExecuteDept.Caption = "ExecuteDept";
            this.coldsInStoreL3DataTableExecuteDept.ColumnName = "ExecuteDept";
            this.coldsInStoreL3DataTableExecuteDept.Namespace = "";
            // 
            // coldsInStoreL3DataTableCreateDate
            // 
            this.coldsInStoreL3DataTableCreateDate.Caption = "CreateDate";
            this.coldsInStoreL3DataTableCreateDate.ColumnName = "CreateDate";
            this.coldsInStoreL3DataTableCreateDate.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableCreateDate.Namespace = "";
            // 
            // coldsInStoreL3DataTablePlanExecuteDate
            // 
            this.coldsInStoreL3DataTablePlanExecuteDate.Caption = "PlanExecuteDate";
            this.coldsInStoreL3DataTablePlanExecuteDate.ColumnName = "PlanExecuteDate";
            this.coldsInStoreL3DataTablePlanExecuteDate.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTablePlanExecuteDate.Namespace = "";
            // 
            // coldsInStoreL3DataTableActualExecuteDate
            // 
            this.coldsInStoreL3DataTableActualExecuteDate.Caption = "ActualExecuteDate";
            this.coldsInStoreL3DataTableActualExecuteDate.ColumnName = "ActualExecuteDate";
            this.coldsInStoreL3DataTableActualExecuteDate.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableActualExecuteDate.Namespace = "";
            // 
            // coldsInStoreL3DataTablePlanner
            // 
            this.coldsInStoreL3DataTablePlanner.Caption = "Planner";
            this.coldsInStoreL3DataTablePlanner.ColumnName = "Planner";
            this.coldsInStoreL3DataTablePlanner.Namespace = "";
            // 
            // coldsInStoreL3DataTablePre_LotNo
            // 
            this.coldsInStoreL3DataTablePre_LotNo.Caption = "Pre_LotNo";
            this.coldsInStoreL3DataTablePre_LotNo.ColumnName = "Pre_LotNo";
            this.coldsInStoreL3DataTablePre_LotNo.Namespace = "";
            // 
            // coldsInStoreL3DataTablePreHeatID
            // 
            this.coldsInStoreL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsInStoreL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsInStoreL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsInStoreL3DataTablePre_SteelGradeIndex
            // 
            this.coldsInStoreL3DataTablePre_SteelGradeIndex.Caption = "Pre_SteelGradeIndex";
            this.coldsInStoreL3DataTablePre_SteelGradeIndex.ColumnName = "Pre_SteelGradeIndex";
            this.coldsInStoreL3DataTablePre_SteelGradeIndex.Namespace = "";
            // 
            // coldsInStoreL3DataTablePre_SteelGrade
            // 
            this.coldsInStoreL3DataTablePre_SteelGrade.Caption = "Pre_SteelGrade";
            this.coldsInStoreL3DataTablePre_SteelGrade.ColumnName = "Pre_SteelGrade";
            this.coldsInStoreL3DataTablePre_SteelGrade.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Tapped_Weight
            // 
            this.coldsInStoreL3DataTableAim_Tapped_Weight.Caption = "Aim_Tapped_Weight";
            this.coldsInStoreL3DataTableAim_Tapped_Weight.ColumnName = "Aim_Tapped_Weight";
            this.coldsInStoreL3DataTableAim_Tapped_Weight.DataType = typeof(double);
            this.coldsInStoreL3DataTableAim_Tapped_Weight.Namespace = "";
            // 
            // coldsInStoreL3DataTableCasterID
            // 
            this.coldsInStoreL3DataTableCasterID.Caption = "CasterID";
            this.coldsInStoreL3DataTableCasterID.ColumnName = "CasterID";
            this.coldsInStoreL3DataTableCasterID.Namespace = "";
            // 
            // coldsInStoreL3DataTableBOFID
            // 
            this.coldsInStoreL3DataTableBOFID.Caption = "BOFID";
            this.coldsInStoreL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsInStoreL3DataTableBOFID.Namespace = "";
            // 
            // coldsInStoreL3DataTableLFID
            // 
            this.coldsInStoreL3DataTableLFID.Caption = "LFID";
            this.coldsInStoreL3DataTableLFID.ColumnName = "LFID";
            this.coldsInStoreL3DataTableLFID.Namespace = "";
            // 
            // coldsInStoreL3DataTableRHID
            // 
            this.coldsInStoreL3DataTableRHID.Caption = "RHID";
            this.coldsInStoreL3DataTableRHID.ColumnName = "RHID";
            this.coldsInStoreL3DataTableRHID.Namespace = "";
            // 
            // coldsInStoreL3DataTableBOF_Status
            // 
            this.coldsInStoreL3DataTableBOF_Status.Caption = "BOF_Status";
            this.coldsInStoreL3DataTableBOF_Status.ColumnName = "BOF_Status";
            this.coldsInStoreL3DataTableBOF_Status.Namespace = "";
            // 
            // coldsInStoreL3DataTableLF_Status
            // 
            this.coldsInStoreL3DataTableLF_Status.Caption = "LF_Status";
            this.coldsInStoreL3DataTableLF_Status.ColumnName = "LF_Status";
            this.coldsInStoreL3DataTableLF_Status.Namespace = "";
            // 
            // coldsInStoreL3DataTableRH_Status
            // 
            this.coldsInStoreL3DataTableRH_Status.Caption = "RH_Status";
            this.coldsInStoreL3DataTableRH_Status.ColumnName = "RH_Status";
            this.coldsInStoreL3DataTableRH_Status.Namespace = "";
            // 
            // coldsInStoreL3DataTableCaster_Status
            // 
            this.coldsInStoreL3DataTableCaster_Status.Caption = "Caster_Status";
            this.coldsInStoreL3DataTableCaster_Status.ColumnName = "Caster_Status";
            this.coldsInStoreL3DataTableCaster_Status.Namespace = "";
            // 
            // coldsInStoreL3DataTableSide_Status
            // 
            this.coldsInStoreL3DataTableSide_Status.Caption = "Side_Status";
            this.coldsInStoreL3DataTableSide_Status.ColumnName = "Side_Status";
            this.coldsInStoreL3DataTableSide_Status.Namespace = "";
            // 
            // coldsInStoreL3DataTableHeatID
            // 
            this.coldsInStoreL3DataTableHeatID.Caption = "HeatID";
            this.coldsInStoreL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsInStoreL3DataTableHeatID.Namespace = "";
            // 
            // coldsInStoreL3DataTableCasting_No
            // 
            this.coldsInStoreL3DataTableCasting_No.Caption = "Casting_No";
            this.coldsInStoreL3DataTableCasting_No.ColumnName = "Casting_No";
            this.coldsInStoreL3DataTableCasting_No.Namespace = "";
            // 
            // coldsInStoreL3DataTableCasting_Heat_Cnt
            // 
            this.coldsInStoreL3DataTableCasting_Heat_Cnt.Caption = "Casting_Heat_Cnt";
            this.coldsInStoreL3DataTableCasting_Heat_Cnt.ColumnName = "Casting_Heat_Cnt";
            this.coldsInStoreL3DataTableCasting_Heat_Cnt.DataType = typeof(int);
            this.coldsInStoreL3DataTableCasting_Heat_Cnt.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_IronPrepared
            // 
            this.coldsInStoreL3DataTableAim_Time_IronPrepared.Caption = "Aim_Time_IronPrepared";
            this.coldsInStoreL3DataTableAim_Time_IronPrepared.ColumnName = "Aim_Time_IronPrepared";
            this.coldsInStoreL3DataTableAim_Time_IronPrepared.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_IronPrepared.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_BOFStart
            // 
            this.coldsInStoreL3DataTableAim_Time_BOFStart.Caption = "Aim_Time_BOFStart";
            this.coldsInStoreL3DataTableAim_Time_BOFStart.ColumnName = "Aim_Time_BOFStart";
            this.coldsInStoreL3DataTableAim_Time_BOFStart.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_BOFStart.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_BOFTapped
            // 
            this.coldsInStoreL3DataTableAim_Time_BOFTapped.Caption = "Aim_Time_BOFTapped";
            this.coldsInStoreL3DataTableAim_Time_BOFTapped.ColumnName = "Aim_Time_BOFTapped";
            this.coldsInStoreL3DataTableAim_Time_BOFTapped.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_BOFTapped.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_TappedSideEnd
            // 
            this.coldsInStoreL3DataTableAim_Time_TappedSideEnd.Caption = "Aim_Time_TappedSideEnd";
            this.coldsInStoreL3DataTableAim_Time_TappedSideEnd.ColumnName = "Aim_Time_TappedSideEnd";
            this.coldsInStoreL3DataTableAim_Time_TappedSideEnd.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_TappedSideEnd.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_LFArrival
            // 
            this.coldsInStoreL3DataTableAim_Time_LFArrival.Caption = "Aim_Time_LFArrival";
            this.coldsInStoreL3DataTableAim_Time_LFArrival.ColumnName = "Aim_Time_LFArrival";
            this.coldsInStoreL3DataTableAim_Time_LFArrival.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_LFArrival.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_LFStart
            // 
            this.coldsInStoreL3DataTableAim_Time_LFStart.Caption = "Aim_Time_LFStart";
            this.coldsInStoreL3DataTableAim_Time_LFStart.ColumnName = "Aim_Time_LFStart";
            this.coldsInStoreL3DataTableAim_Time_LFStart.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_LFStart.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_LFEnd
            // 
            this.coldsInStoreL3DataTableAim_Time_LFEnd.Caption = "Aim_Time_LFEnd";
            this.coldsInStoreL3DataTableAim_Time_LFEnd.ColumnName = "Aim_Time_LFEnd";
            this.coldsInStoreL3DataTableAim_Time_LFEnd.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_LFEnd.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_LFLeave
            // 
            this.coldsInStoreL3DataTableAim_Time_LFLeave.Caption = "Aim_Time_LFLeave";
            this.coldsInStoreL3DataTableAim_Time_LFLeave.ColumnName = "Aim_Time_LFLeave";
            this.coldsInStoreL3DataTableAim_Time_LFLeave.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_LFLeave.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_RHArrival
            // 
            this.coldsInStoreL3DataTableAim_Time_RHArrival.Caption = "Aim_Time_RHArrival";
            this.coldsInStoreL3DataTableAim_Time_RHArrival.ColumnName = "Aim_Time_RHArrival";
            this.coldsInStoreL3DataTableAim_Time_RHArrival.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_RHArrival.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_RHStart
            // 
            this.coldsInStoreL3DataTableAim_Time_RHStart.Caption = "Aim_Time_RHStart";
            this.coldsInStoreL3DataTableAim_Time_RHStart.ColumnName = "Aim_Time_RHStart";
            this.coldsInStoreL3DataTableAim_Time_RHStart.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_RHStart.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_RHEnd
            // 
            this.coldsInStoreL3DataTableAim_Time_RHEnd.Caption = "Aim_Time_RHEnd";
            this.coldsInStoreL3DataTableAim_Time_RHEnd.ColumnName = "Aim_Time_RHEnd";
            this.coldsInStoreL3DataTableAim_Time_RHEnd.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_RHEnd.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_RHLeave
            // 
            this.coldsInStoreL3DataTableAim_Time_RHLeave.Caption = "Aim_Time_RHLeave";
            this.coldsInStoreL3DataTableAim_Time_RHLeave.ColumnName = "Aim_Time_RHLeave";
            this.coldsInStoreL3DataTableAim_Time_RHLeave.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_RHLeave.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_CasterArrival
            // 
            this.coldsInStoreL3DataTableAim_Time_CasterArrival.Caption = "Aim_Time_CasterArrival";
            this.coldsInStoreL3DataTableAim_Time_CasterArrival.ColumnName = "Aim_Time_CasterArrival";
            this.coldsInStoreL3DataTableAim_Time_CasterArrival.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_CasterArrival.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_CastingStart
            // 
            this.coldsInStoreL3DataTableAim_Time_CastingStart.Caption = "Aim_Time_CastingStart";
            this.coldsInStoreL3DataTableAim_Time_CastingStart.ColumnName = "Aim_Time_CastingStart";
            this.coldsInStoreL3DataTableAim_Time_CastingStart.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_CastingStart.Namespace = "";
            // 
            // coldsInStoreL3DataTableAim_Time_CastingEnd
            // 
            this.coldsInStoreL3DataTableAim_Time_CastingEnd.Caption = "Aim_Time_CastingEnd";
            this.coldsInStoreL3DataTableAim_Time_CastingEnd.ColumnName = "Aim_Time_CastingEnd";
            this.coldsInStoreL3DataTableAim_Time_CastingEnd.DataType = typeof(System.DateTime);
            this.coldsInStoreL3DataTableAim_Time_CastingEnd.Namespace = "";
            // 
            // coldsInStoreL3DataTableFir_Heat_Flag
            // 
            this.coldsInStoreL3DataTableFir_Heat_Flag.Caption = "Fir_Heat_Flag";
            this.coldsInStoreL3DataTableFir_Heat_Flag.ColumnName = "Fir_Heat_Flag";
            this.coldsInStoreL3DataTableFir_Heat_Flag.DataType = typeof(int);
            this.coldsInStoreL3DataTableFir_Heat_Flag.Namespace = "";
            // 
            // coldsInStoreL3DataTableDiv_HeatID
            // 
            this.coldsInStoreL3DataTableDiv_HeatID.Caption = "Div_HeatID";
            this.coldsInStoreL3DataTableDiv_HeatID.ColumnName = "Div_HeatID";
            this.coldsInStoreL3DataTableDiv_HeatID.Namespace = "";
            // 
            // coldsInStoreL3DataTableTeamID
            // 
            this.coldsInStoreL3DataTableTeamID.Caption = "TeamID";
            this.coldsInStoreL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsInStoreL3DataTableTeamID.Namespace = "";
            // 
            // coldsInStoreL3DataTableShiftID
            // 
            this.coldsInStoreL3DataTableShiftID.Caption = "ShiftID";
            this.coldsInStoreL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsInStoreL3DataTableShiftID.Namespace = "";
            // 
            // coldsInStoreL3DataTableSteelGradeIndex
            // 
            this.coldsInStoreL3DataTableSteelGradeIndex.Caption = "SteelGradeIndex";
            this.coldsInStoreL3DataTableSteelGradeIndex.ColumnName = "SteelGradeIndex";
            this.coldsInStoreL3DataTableSteelGradeIndex.Namespace = "";
            // 
            // coldsInStoreL3DataTableSteelGrade
            // 
            this.coldsInStoreL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsInStoreL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsInStoreL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsInStoreL3DataTablePlan_Ord_ID
            // 
            this.coldsInStoreL3DataTablePlan_Ord_ID.Caption = "Plan_Ord_ID";
            this.coldsInStoreL3DataTablePlan_Ord_ID.ColumnName = "Plan_Ord_ID";
            this.coldsInStoreL3DataTablePlan_Ord_ID.Namespace = "";
            // 
            // coldsInStoreL3DataTableHot_Send_Flag
            // 
            this.coldsInStoreL3DataTableHot_Send_Flag.Caption = "Hot_Send_Flag";
            this.coldsInStoreL3DataTableHot_Send_Flag.ColumnName = "Hot_Send_Flag";
            this.coldsInStoreL3DataTableHot_Send_Flag.DataType = typeof(int);
            this.coldsInStoreL3DataTableHot_Send_Flag.Namespace = "";
            // 
            // coldsInStoreL3DataTableSteel_Return_Flag
            // 
            this.coldsInStoreL3DataTableSteel_Return_Flag.Caption = "Steel_Return_Flag";
            this.coldsInStoreL3DataTableSteel_Return_Flag.ColumnName = "Steel_Return_Flag";
            this.coldsInStoreL3DataTableSteel_Return_Flag.DataType = typeof(int);
            this.coldsInStoreL3DataTableSteel_Return_Flag.Namespace = "";
            // 
            // coldsInStoreL3DataTableSteel_Back_Flag
            // 
            this.coldsInStoreL3DataTableSteel_Back_Flag.Caption = "Steel_Back_Flag";
            this.coldsInStoreL3DataTableSteel_Back_Flag.ColumnName = "Steel_Back_Flag";
            this.coldsInStoreL3DataTableSteel_Back_Flag.DataType = typeof(int);
            this.coldsInStoreL3DataTableSteel_Back_Flag.Namespace = "";
            // 
            // coldsInStoreL3DataTableTreat_Seq
            // 
            this.coldsInStoreL3DataTableTreat_Seq.Caption = "Treat_Seq";
            this.coldsInStoreL3DataTableTreat_Seq.ColumnName = "Treat_Seq";
            this.coldsInStoreL3DataTableTreat_Seq.Namespace = "";
            // 
            // coldsInStoreL3DataTableDestitation
            // 
            this.coldsInStoreL3DataTableDestitation.Caption = "Destitation";
            this.coldsInStoreL3DataTableDestitation.ColumnName = "Destitation";
            this.coldsInStoreL3DataTableDestitation.Namespace = "";
            // 
            // coldsInStoreL3DataTableNew_BOF_Flag
            // 
            this.coldsInStoreL3DataTableNew_BOF_Flag.Caption = "New_BOF_Flag";
            this.coldsInStoreL3DataTableNew_BOF_Flag.ColumnName = "New_BOF_Flag";
            this.coldsInStoreL3DataTableNew_BOF_Flag.DataType = typeof(short);
            this.coldsInStoreL3DataTableNew_BOF_Flag.Namespace = "";
            // 
            // coldsInStoreL3DataTableRefine_Type
            // 
            this.coldsInStoreL3DataTableRefine_Type.Caption = "Refine_Type";
            this.coldsInStoreL3DataTableRefine_Type.ColumnName = "Refine_Type";
            this.coldsInStoreL3DataTableRefine_Type.Namespace = "";
            // 
            // coldsInStoreL3DataTableLength
            // 
            this.coldsInStoreL3DataTableLength.Caption = "Length";
            this.coldsInStoreL3DataTableLength.ColumnName = "Length";
            this.coldsInStoreL3DataTableLength.DataType = typeof(int);
            this.coldsInStoreL3DataTableLength.Namespace = "";
            // 
            // coldsInStoreL3DataTableWidth
            // 
            this.coldsInStoreL3DataTableWidth.Caption = "Width";
            this.coldsInStoreL3DataTableWidth.ColumnName = "Width";
            this.coldsInStoreL3DataTableWidth.DataType = typeof(int);
            this.coldsInStoreL3DataTableWidth.Namespace = "";
            // 
            // coldsInStoreL3DataTableThickness
            // 
            this.coldsInStoreL3DataTableThickness.Caption = "Thickness";
            this.coldsInStoreL3DataTableThickness.ColumnName = "Thickness";
            this.coldsInStoreL3DataTableThickness.DataType = typeof(int);
            this.coldsInStoreL3DataTableThickness.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsInStore;
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
            this.dtInStoreEndData,
            this.toolStripLabel2,
            this.dtInStoreData,
            this.toolStripLabel6,
            this.btnOutput});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(887, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "  ";
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
            // dtInStoreEndData
            // 
            this.dtInStoreEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreEndData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreEndData.Name = "dtInStoreEndData";
            this.dtInStoreEndData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreEndData.Text = "2009-01-04";
            this.dtInStoreEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel2.Text = "－";
            // 
            // dtInStoreData
            // 
            this.dtInStoreData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtInStoreData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtInStoreData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtInStoreData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtInStoreData.CustomFormat = "yyyy-MM-dd";
            this.dtInStoreData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInStoreData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtInStoreData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtInStoreData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtInStoreData.Name = "dtInStoreData";
            this.dtInStoreData.Size = new System.Drawing.Size(100, 22);
            this.dtInStoreData.Text = "2008-11-16";
            this.dtInStoreData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "创建日期:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // dsStoreArea
            // 
            this.dsStoreArea.AutoLoad = true;
            this.dsStoreArea.AutoSubscribe = false;
            this.dsStoreArea.DataSetName = "L3DataSet";
            this.dsStoreArea.DeleteMethod = null;
            this.dsStoreArea.InsertMethod = null;
            this.dsStoreArea.L3DataAdapter = this.Adapter;
            this.dsStoreArea.LoadEvent = "Click";
            this.dsStoreArea.LoadTrigger = null;
            this.dsStoreArea.RefreshValve = 1000;
            this.dsStoreArea.SourceCommand = null;
            this.dsStoreArea.SourceCondition = "CODE_GROUP = \'AlloyArea\'";
            this.dsStoreArea.SourceMethod = "";
            this.dsStoreArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreArea.SubscribeTarget = null;
            this.dsStoreArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreArea});
            this.dsStoreArea.UpdateEvent = "Click";
            this.dsStoreArea.UpdateMethod = null;
            this.dsStoreArea.UpdateTrigger = null;
            // 
            // schemadsStoreArea
            // 
            this.schemadsStoreArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreAreaL3DataTableCode,
            this.coldsStoreAreaL3DataTableCode_Des});
            this.schemadsStoreArea.TableName = "L3DataTable";
            // 
            // coldsStoreAreaL3DataTableCode
            // 
            this.coldsStoreAreaL3DataTableCode.Caption = "Code";
            this.coldsStoreAreaL3DataTableCode.ColumnName = "Code";
            this.coldsStoreAreaL3DataTableCode.Namespace = "";
            // 
            // coldsStoreAreaL3DataTableCode_Des
            // 
            this.coldsStoreAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreAreaL3DataTableCode_Des.Namespace = "";
            // 
            // dsAlloyCode
            // 
            this.dsAlloyCode.AutoLoad = true;
            this.dsAlloyCode.AutoSubscribe = false;
            this.dsAlloyCode.DataSetName = "L3DataSet";
            this.dsAlloyCode.DeleteMethod = null;
            this.dsAlloyCode.InsertMethod = null;
            this.dsAlloyCode.L3DataAdapter = this.Adapter;
            this.dsAlloyCode.LoadEvent = "Click";
            this.dsAlloyCode.LoadTrigger = null;
            this.dsAlloyCode.RefreshValve = 1000;
            this.dsAlloyCode.SourceCommand = null;
            this.dsAlloyCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\'";
            this.dsAlloyCode.SourceMethod = "";
            this.dsAlloyCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyCode.SubscribeTarget = null;
            this.dsAlloyCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyCode});
            this.dsAlloyCode.UpdateEvent = "Click";
            this.dsAlloyCode.UpdateMethod = null;
            this.dsAlloyCode.UpdateTrigger = null;
            // 
            // schemadsAlloyCode
            // 
            this.schemadsAlloyCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyCodeL3DataTableCode,
            this.coldsAlloyCodeL3DataTableCode_Des});
            this.schemadsAlloyCode.TableName = "L3DataTable";
            // 
            // coldsAlloyCodeL3DataTableCode
            // 
            this.coldsAlloyCodeL3DataTableCode.Caption = "Code";
            this.coldsAlloyCodeL3DataTableCode.ColumnName = "Code";
            this.coldsAlloyCodeL3DataTableCode.Namespace = "";
            // 
            // coldsAlloyCodeL3DataTableCode_Des
            // 
            this.coldsAlloyCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.Namespace = "";
            // 
            // TappingPlanQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "TappingPlanQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "出钢计划查询";
            this.Text = "出钢计划查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TappingPlanQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.TappingPlanQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtInStoreData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsInStore;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsStoreArea;
        private System.Data.DataTable schemadsStoreArea;
        private System.Data.DataColumn coldsStoreAreaL3DataTableCode;
        private System.Data.DataColumn coldsStoreAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private AppSvrHMI.L3DataSet dsInStore;
        private System.Data.DataTable schemal3DataSet9;
        private System.Data.DataColumn coll3DataSet9L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet9L3DataTableName;
        private System.Data.DataColumn coldsInStoreL3DataTablePlanID;
        private System.Data.DataColumn coldsInStoreL3DataTableContractID;
        private System.Data.DataColumn coldsInStoreL3DataTableStatus;
        private System.Data.DataColumn coldsInStoreL3DataTablePlanDept;
        private System.Data.DataColumn coldsInStoreL3DataTableExecuteDept;
        private System.Data.DataColumn coldsInStoreL3DataTableCreateDate;
        private System.Data.DataColumn coldsInStoreL3DataTablePlanExecuteDate;
        private System.Data.DataColumn coldsInStoreL3DataTableActualExecuteDate;
        private System.Data.DataColumn coldsInStoreL3DataTablePlanner;
        private System.Data.DataColumn coldsInStoreL3DataTablePre_LotNo;
        private System.Data.DataColumn coldsInStoreL3DataTablePreHeatID;
        private System.Data.DataColumn coldsInStoreL3DataTablePre_SteelGradeIndex;
        private System.Data.DataColumn coldsInStoreL3DataTablePre_SteelGrade;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Tapped_Weight;
        private System.Data.DataColumn coldsInStoreL3DataTableCasterID;
        private System.Data.DataColumn coldsInStoreL3DataTableBOFID;
        private System.Data.DataColumn coldsInStoreL3DataTableLFID;
        private System.Data.DataColumn coldsInStoreL3DataTableRHID;
        private System.Data.DataColumn coldsInStoreL3DataTableBOF_Status;
        private System.Data.DataColumn coldsInStoreL3DataTableLF_Status;
        private System.Data.DataColumn coldsInStoreL3DataTableRH_Status;
        private System.Data.DataColumn coldsInStoreL3DataTableCaster_Status;
        private System.Data.DataColumn coldsInStoreL3DataTableSide_Status;
        private System.Data.DataColumn coldsInStoreL3DataTableHeatID;
        private System.Data.DataColumn coldsInStoreL3DataTableCasting_No;
        private System.Data.DataColumn coldsInStoreL3DataTableCasting_Heat_Cnt;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_IronPrepared;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_BOFStart;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_BOFTapped;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_TappedSideEnd;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_LFArrival;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_LFStart;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_LFEnd;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_LFLeave;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_RHArrival;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_RHStart;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_RHEnd;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_RHLeave;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_CasterArrival;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_CastingStart;
        private System.Data.DataColumn coldsInStoreL3DataTableAim_Time_CastingEnd;
        private System.Data.DataColumn coldsInStoreL3DataTableFir_Heat_Flag;
        private System.Data.DataColumn coldsInStoreL3DataTableDiv_HeatID;
        private System.Data.DataColumn coldsInStoreL3DataTableTeamID;
        private System.Data.DataColumn coldsInStoreL3DataTableShiftID;
        private System.Data.DataColumn coldsInStoreL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsInStoreL3DataTableSteelGrade;
        private System.Data.DataColumn coldsInStoreL3DataTablePlan_Ord_ID;
        private System.Data.DataColumn coldsInStoreL3DataTableHot_Send_Flag;
        private System.Data.DataColumn coldsInStoreL3DataTableSteel_Return_Flag;
        private System.Data.DataColumn coldsInStoreL3DataTableSteel_Back_Flag;
        private System.Data.DataColumn coldsInStoreL3DataTableTreat_Seq;
        private System.Data.DataColumn coldsInStoreL3DataTableDestitation;
        private System.Data.DataColumn coldsInStoreL3DataTableNew_BOF_Flag;
        private System.Data.DataColumn coldsInStoreL3DataTableRefine_Type;
        private System.Data.DataColumn coldsInStoreL3DataTableLength;
        private System.Data.DataColumn coldsInStoreL3DataTableWidth;
        private System.Data.DataColumn coldsInStoreL3DataTableThickness;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtInStoreEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executeDeptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualExecuteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preLotNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTappedWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rHStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn casterStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sideStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castingNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castingHeatCntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeIronPreparedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeBOFStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeBOFTappedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeTappedSideEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeLFArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeLFStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeLFEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeLFLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeRHArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeRHStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeRHEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeRHLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeCasterArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeCastingStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aimTimeCastingEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firHeatFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planOrdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotSendFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelReturnFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelBackFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatSeqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destitationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newBOFFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thicknessDataGridViewTextBoxColumn;
    }
}