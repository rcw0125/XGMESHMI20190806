namespace EquipMag.BoiloffCooling
{
    partial class EquipRuntimeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipRuntimeFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsRuntime = new System.Windows.Forms.BindingSource(this.components);
            this.dsRuntime = new AppSvrHMI.L3DataSet();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableCatch_Time = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Before_CycPump_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_After_CycPump_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Regenerator1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Regenerator1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Regenerator2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Regenerator2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Supply_Regenerator = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_YiWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_YiWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_YiWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_YiWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_YiWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_YiWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_YiWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_YiWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_ErWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_ErWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_ErWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableLose_ErWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableRev_Fan_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableRev_Fan_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableRev_Fan_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableRev_Fan_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF1 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF2 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF3 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF4 = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableShift = new System.Data.DataColumn();
            this.coldsRuntimeL3DataTableTeam = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtStartTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtEndTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvRuntime = new System.Windows.Forms.DataGridView();
            this.catchTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBeforeCycPumpBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAfterCycPumpBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRegenerator1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRegenerator1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRegenerator2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRegenerator2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSupplyRegeneratorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYiWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYiWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYiWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYiWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseYiWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseYiWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseYiWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseYiWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWaterYiWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWaterYiWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWaterYiWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pWaterYiWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterJetYiWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterJetYiWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterJetYiWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterJetYiWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterSpillYiWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterSpillYiWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterSpillYiWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterSpillYiWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tWaterCycleBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tWaterCycleBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tWaterCycleBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tWaterCycleBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutYiWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutYiWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutYiWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutYiWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseErWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseErWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseErWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loseErWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterErWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterErWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterErWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fWaterErWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutErWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutErWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutErWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOutErWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanValveErWenBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanValveErWenBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanValveErWenBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spanValveErWenBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revFanBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revFanBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revFanBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revFanBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOGasBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOGasBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOGasBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCOGasBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cO2GasBOF1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cO2GasBOF2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cO2GasBOF3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cO2GasBOF4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRuntime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRuntime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvRuntime)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsRuntime;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel3,
            this.toolStripLabel1,
            this.dtStartTime,
            this.toolStripLabel2,
            this.dtEndTime,
            this.toolStripLabel5,
            this.btnQuery});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsRuntime
            // 
            this.bsRuntime.DataMember = "L3DataTable";
            this.bsRuntime.DataSource = this.dsRuntime;
            // 
            // dsRuntime
            // 
            this.dsRuntime.AutoSubscribe = false;
            this.dsRuntime.DataSetName = "L3DataSet";
            this.dsRuntime.DeleteMethod = "";
            this.dsRuntime.InsertMethod = "";
            this.dsRuntime.L3DataAdapter = null;
            this.dsRuntime.LoadEvent = "";
            this.dsRuntime.LoadTrigger = null;
            this.dsRuntime.RefreshValve = 1000;
            this.dsRuntime.SourceCommand = null;
            this.dsRuntime.SourceCondition = "";
            this.dsRuntime.SourceMethod = "";
            this.dsRuntime.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRuntime.SourceURI = "XGMESLogic\\EquipMag\\CEquip_Runtime_Data";
            this.dsRuntime.SubscribeTarget = null;
            this.dsRuntime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsRuntime.UpdateEvent = "";
            this.dsRuntime.UpdateMethod = "";
            this.dsRuntime.UpdateTrigger = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsRuntimeL3DataTableCatch_Time,
            this.coldsRuntimeL3DataTableP_Before_CycPump_BOF4,
            this.coldsRuntimeL3DataTableP_After_CycPump_BOF4,
            this.coldsRuntimeL3DataTableP_Regenerator1,
            this.coldsRuntimeL3DataTableT_Regenerator1,
            this.coldsRuntimeL3DataTableP_Regenerator2,
            this.coldsRuntimeL3DataTableT_Regenerator2,
            this.coldsRuntimeL3DataTableP_Supply_Regenerator,
            this.coldsRuntimeL3DataTableP_YiWen_BOF1,
            this.coldsRuntimeL3DataTableP_YiWen_BOF2,
            this.coldsRuntimeL3DataTableP_YiWen_BOF3,
            this.coldsRuntimeL3DataTableP_YiWen_BOF4,
            this.coldsRuntimeL3DataTableLose_YiWen_BOF1,
            this.coldsRuntimeL3DataTableLose_YiWen_BOF2,
            this.coldsRuntimeL3DataTableLose_YiWen_BOF3,
            this.coldsRuntimeL3DataTableLose_YiWen_BOF4,
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF1,
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF2,
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF3,
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF4,
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1,
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2,
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3,
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4,
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1,
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2,
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3,
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4,
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF1,
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF2,
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF3,
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF4,
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF1,
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF2,
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF3,
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF4,
            this.coldsRuntimeL3DataTableLose_ErWen_BOF1,
            this.coldsRuntimeL3DataTableLose_ErWen_BOF2,
            this.coldsRuntimeL3DataTableLose_ErWen_BOF3,
            this.coldsRuntimeL3DataTableLose_ErWen_BOF4,
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF1,
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF2,
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF3,
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF4,
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF1,
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF2,
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF3,
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF4,
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1,
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2,
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3,
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4,
            this.coldsRuntimeL3DataTableRev_Fan_BOF1,
            this.coldsRuntimeL3DataTableRev_Fan_BOF2,
            this.coldsRuntimeL3DataTableRev_Fan_BOF3,
            this.coldsRuntimeL3DataTableRev_Fan_BOF4,
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF1,
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF2,
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF3,
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF4,
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF1,
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF2,
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF3,
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF4,
            this.coldsRuntimeL3DataTableShift,
            this.coldsRuntimeL3DataTableTeam});
            this.schemadsEnergyData.TableName = "L3DataTable";
            // 
            // coldsEnergyDataL3DataTableGUID
            // 
            this.coldsEnergyDataL3DataTableGUID.Caption = "GUID";
            this.coldsEnergyDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsEnergyDataL3DataTableGUID.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableName
            // 
            this.coldsEnergyDataL3DataTableName.Caption = "Name";
            this.coldsEnergyDataL3DataTableName.ColumnName = "Name";
            this.coldsEnergyDataL3DataTableName.Namespace = "";
            // 
            // coldsRuntimeL3DataTableCatch_Time
            // 
            this.coldsRuntimeL3DataTableCatch_Time.Caption = "Catch_Time";
            this.coldsRuntimeL3DataTableCatch_Time.ColumnName = "Catch_Time";
            this.coldsRuntimeL3DataTableCatch_Time.DataType = typeof(System.DateTime);
            this.coldsRuntimeL3DataTableCatch_Time.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Before_CycPump_BOF4
            // 
            this.coldsRuntimeL3DataTableP_Before_CycPump_BOF4.Caption = "P_Before_CycPump_BOF4";
            this.coldsRuntimeL3DataTableP_Before_CycPump_BOF4.ColumnName = "P_Before_CycPump_BOF4";
            this.coldsRuntimeL3DataTableP_Before_CycPump_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Before_CycPump_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_After_CycPump_BOF4
            // 
            this.coldsRuntimeL3DataTableP_After_CycPump_BOF4.Caption = "P_After_CycPump_BOF4";
            this.coldsRuntimeL3DataTableP_After_CycPump_BOF4.ColumnName = "P_After_CycPump_BOF4";
            this.coldsRuntimeL3DataTableP_After_CycPump_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_After_CycPump_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Regenerator1
            // 
            this.coldsRuntimeL3DataTableP_Regenerator1.Caption = "P_Regenerator1";
            this.coldsRuntimeL3DataTableP_Regenerator1.ColumnName = "P_Regenerator1";
            this.coldsRuntimeL3DataTableP_Regenerator1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Regenerator1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Regenerator1
            // 
            this.coldsRuntimeL3DataTableT_Regenerator1.Caption = "T_Regenerator1";
            this.coldsRuntimeL3DataTableT_Regenerator1.ColumnName = "T_Regenerator1";
            this.coldsRuntimeL3DataTableT_Regenerator1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Regenerator1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Regenerator2
            // 
            this.coldsRuntimeL3DataTableP_Regenerator2.Caption = "P_Regenerator2";
            this.coldsRuntimeL3DataTableP_Regenerator2.ColumnName = "P_Regenerator2";
            this.coldsRuntimeL3DataTableP_Regenerator2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Regenerator2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Regenerator2
            // 
            this.coldsRuntimeL3DataTableT_Regenerator2.Caption = "T_Regenerator2";
            this.coldsRuntimeL3DataTableT_Regenerator2.ColumnName = "T_Regenerator2";
            this.coldsRuntimeL3DataTableT_Regenerator2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Regenerator2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Supply_Regenerator
            // 
            this.coldsRuntimeL3DataTableP_Supply_Regenerator.Caption = "P_Supply_Regenerator";
            this.coldsRuntimeL3DataTableP_Supply_Regenerator.ColumnName = "P_Supply_Regenerator";
            this.coldsRuntimeL3DataTableP_Supply_Regenerator.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Supply_Regenerator.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_YiWen_BOF1
            // 
            this.coldsRuntimeL3DataTableP_YiWen_BOF1.Caption = "P_YiWen_BOF1";
            this.coldsRuntimeL3DataTableP_YiWen_BOF1.ColumnName = "P_YiWen_BOF1";
            this.coldsRuntimeL3DataTableP_YiWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_YiWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_YiWen_BOF2
            // 
            this.coldsRuntimeL3DataTableP_YiWen_BOF2.Caption = "P_YiWen_BOF2";
            this.coldsRuntimeL3DataTableP_YiWen_BOF2.ColumnName = "P_YiWen_BOF2";
            this.coldsRuntimeL3DataTableP_YiWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_YiWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_YiWen_BOF3
            // 
            this.coldsRuntimeL3DataTableP_YiWen_BOF3.Caption = "P_YiWen_BOF3";
            this.coldsRuntimeL3DataTableP_YiWen_BOF3.ColumnName = "P_YiWen_BOF3";
            this.coldsRuntimeL3DataTableP_YiWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_YiWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_YiWen_BOF4
            // 
            this.coldsRuntimeL3DataTableP_YiWen_BOF4.Caption = "P_YiWen_BOF4";
            this.coldsRuntimeL3DataTableP_YiWen_BOF4.ColumnName = "P_YiWen_BOF4";
            this.coldsRuntimeL3DataTableP_YiWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_YiWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_YiWen_BOF1
            // 
            this.coldsRuntimeL3DataTableLose_YiWen_BOF1.Caption = "Lose_YiWen_BOF1";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF1.ColumnName = "Lose_YiWen_BOF1";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_YiWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_YiWen_BOF2
            // 
            this.coldsRuntimeL3DataTableLose_YiWen_BOF2.Caption = "Lose_YiWen_BOF2";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF2.ColumnName = "Lose_YiWen_BOF2";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_YiWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_YiWen_BOF3
            // 
            this.coldsRuntimeL3DataTableLose_YiWen_BOF3.Caption = "Lose_YiWen_BOF3";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF3.ColumnName = "Lose_YiWen_BOF3";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_YiWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_YiWen_BOF4
            // 
            this.coldsRuntimeL3DataTableLose_YiWen_BOF4.Caption = "Lose_YiWen_BOF4";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF4.ColumnName = "Lose_YiWen_BOF4";
            this.coldsRuntimeL3DataTableLose_YiWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_YiWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Water_YiWen_BOF1
            // 
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF1.Caption = "P_Water_YiWen_BOF1";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF1.ColumnName = "P_Water_YiWen_BOF1";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Water_YiWen_BOF2
            // 
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF2.Caption = "P_Water_YiWen_BOF2";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF2.ColumnName = "P_Water_YiWen_BOF2";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Water_YiWen_BOF3
            // 
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF3.Caption = "P_Water_YiWen_BOF3";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF3.ColumnName = "P_Water_YiWen_BOF3";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableP_Water_YiWen_BOF4
            // 
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF4.Caption = "P_Water_YiWen_BOF4";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF4.ColumnName = "P_Water_YiWen_BOF4";
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableP_Water_YiWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1
            // 
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1.Caption = "F_Water_Jet_YiWen_BOF1";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1.ColumnName = "F_Water_Jet_YiWen_BOF1";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2
            // 
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2.Caption = "F_Water_Jet_YiWen_BOF2";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2.ColumnName = "F_Water_Jet_YiWen_BOF2";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3
            // 
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3.Caption = "F_Water_Jet_YiWen_BOF3";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3.ColumnName = "F_Water_Jet_YiWen_BOF3";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4
            // 
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4.Caption = "F_Water_Jet_YiWen_BOF4";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4.ColumnName = "F_Water_Jet_YiWen_BOF4";
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1
            // 
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1.Caption = "F_Water_Spill_YiWen_BOF1";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1.ColumnName = "F_Water_Spill_YiWen_BOF1";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2
            // 
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2.Caption = "F_Water_Spill_YiWen_BOF2";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2.ColumnName = "F_Water_Spill_YiWen_BOF2";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3
            // 
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3.Caption = "F_Water_Spill_YiWen_BOF3";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3.ColumnName = "F_Water_Spill_YiWen_BOF3";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4
            // 
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4.Caption = "F_Water_Spill_YiWen_BOF4";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4.ColumnName = "F_Water_Spill_YiWen_BOF4";
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Water_Cycle_BOF1
            // 
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF1.Caption = "T_Water_Cycle_BOF1";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF1.ColumnName = "T_Water_Cycle_BOF1";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Water_Cycle_BOF2
            // 
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF2.Caption = "T_Water_Cycle_BOF2";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF2.ColumnName = "T_Water_Cycle_BOF2";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Water_Cycle_BOF3
            // 
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF3.Caption = "T_Water_Cycle_BOF3";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF3.ColumnName = "T_Water_Cycle_BOF3";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Water_Cycle_BOF4
            // 
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF4.Caption = "T_Water_Cycle_BOF4";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF4.ColumnName = "T_Water_Cycle_BOF4";
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Water_Cycle_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_YiWen_BOF1
            // 
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF1.Caption = "T_Out_YiWen_BOF1";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF1.ColumnName = "T_Out_YiWen_BOF1";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_YiWen_BOF2
            // 
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF2.Caption = "T_Out_YiWen_BOF2";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF2.ColumnName = "T_Out_YiWen_BOF2";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_YiWen_BOF3
            // 
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF3.Caption = "T_Out_YiWen_BOF3";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF3.ColumnName = "T_Out_YiWen_BOF3";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_YiWen_BOF4
            // 
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF4.Caption = "T_Out_YiWen_BOF4";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF4.ColumnName = "T_Out_YiWen_BOF4";
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_YiWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_ErWen_BOF1
            // 
            this.coldsRuntimeL3DataTableLose_ErWen_BOF1.Caption = "Lose_ErWen_BOF1";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF1.ColumnName = "Lose_ErWen_BOF1";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_ErWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_ErWen_BOF2
            // 
            this.coldsRuntimeL3DataTableLose_ErWen_BOF2.Caption = "Lose_ErWen_BOF2";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF2.ColumnName = "Lose_ErWen_BOF2";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_ErWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_ErWen_BOF3
            // 
            this.coldsRuntimeL3DataTableLose_ErWen_BOF3.Caption = "Lose_ErWen_BOF3";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF3.ColumnName = "Lose_ErWen_BOF3";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_ErWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableLose_ErWen_BOF4
            // 
            this.coldsRuntimeL3DataTableLose_ErWen_BOF4.Caption = "Lose_ErWen_BOF4";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF4.ColumnName = "Lose_ErWen_BOF4";
            this.coldsRuntimeL3DataTableLose_ErWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableLose_ErWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_ErWen_BOF1
            // 
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF1.Caption = "F_Water_ErWen_BOF1";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF1.ColumnName = "F_Water_ErWen_BOF1";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_ErWen_BOF2
            // 
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF2.Caption = "F_Water_ErWen_BOF2";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF2.ColumnName = "F_Water_ErWen_BOF2";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_ErWen_BOF3
            // 
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF3.Caption = "F_Water_ErWen_BOF3";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF3.ColumnName = "F_Water_ErWen_BOF3";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableF_Water_ErWen_BOF4
            // 
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF4.Caption = "F_Water_ErWen_BOF4";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF4.ColumnName = "F_Water_ErWen_BOF4";
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableF_Water_ErWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_ErWen_BOF1
            // 
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF1.Caption = "T_Out_ErWen_BOF1";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF1.ColumnName = "T_Out_ErWen_BOF1";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_ErWen_BOF2
            // 
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF2.Caption = "T_Out_ErWen_BOF2";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF2.ColumnName = "T_Out_ErWen_BOF2";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_ErWen_BOF3
            // 
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF3.Caption = "T_Out_ErWen_BOF3";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF3.ColumnName = "T_Out_ErWen_BOF3";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableT_Out_ErWen_BOF4
            // 
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF4.Caption = "T_Out_ErWen_BOF4";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF4.ColumnName = "T_Out_ErWen_BOF4";
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableT_Out_ErWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1
            // 
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1.Caption = "Span_Valve_ErWen_BOF1";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1.ColumnName = "Span_Valve_ErWen_BOF1";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2
            // 
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2.Caption = "Span_Valve_ErWen_BOF2";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2.ColumnName = "Span_Valve_ErWen_BOF2";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3
            // 
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3.Caption = "Span_Valve_ErWen_BOF3";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3.ColumnName = "Span_Valve_ErWen_BOF3";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4
            // 
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4.Caption = "Span_Valve_ErWen_BOF4";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4.ColumnName = "Span_Valve_ErWen_BOF4";
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableRev_Fan_BOF1
            // 
            this.coldsRuntimeL3DataTableRev_Fan_BOF1.Caption = "Rev_Fan_BOF1";
            this.coldsRuntimeL3DataTableRev_Fan_BOF1.ColumnName = "Rev_Fan_BOF1";
            this.coldsRuntimeL3DataTableRev_Fan_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableRev_Fan_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableRev_Fan_BOF2
            // 
            this.coldsRuntimeL3DataTableRev_Fan_BOF2.Caption = "Rev_Fan_BOF2";
            this.coldsRuntimeL3DataTableRev_Fan_BOF2.ColumnName = "Rev_Fan_BOF2";
            this.coldsRuntimeL3DataTableRev_Fan_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableRev_Fan_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableRev_Fan_BOF3
            // 
            this.coldsRuntimeL3DataTableRev_Fan_BOF3.Caption = "Rev_Fan_BOF3";
            this.coldsRuntimeL3DataTableRev_Fan_BOF3.ColumnName = "Rev_Fan_BOF3";
            this.coldsRuntimeL3DataTableRev_Fan_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableRev_Fan_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableRev_Fan_BOF4
            // 
            this.coldsRuntimeL3DataTableRev_Fan_BOF4.Caption = "Rev_Fan_BOF4";
            this.coldsRuntimeL3DataTableRev_Fan_BOF4.ColumnName = "Rev_Fan_BOF4";
            this.coldsRuntimeL3DataTableRev_Fan_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableRev_Fan_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_CO_Gas_BOF1
            // 
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF1.Caption = "C_CO_Gas_BOF1";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF1.ColumnName = "C_CO_Gas_BOF1";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_CO_Gas_BOF2
            // 
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF2.Caption = "C_CO_Gas_BOF2";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF2.ColumnName = "C_CO_Gas_BOF2";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_CO_Gas_BOF3
            // 
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF3.Caption = "C_CO_Gas_BOF3";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF3.ColumnName = "C_CO_Gas_BOF3";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_CO_Gas_BOF4
            // 
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF4.Caption = "C_CO_Gas_BOF4";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF4.ColumnName = "C_CO_Gas_BOF4";
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_CO_Gas_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_O2_Gas_BOF1
            // 
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF1.Caption = "C_O2_Gas_BOF1";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF1.ColumnName = "C_O2_Gas_BOF1";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF1.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF1.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_O2_Gas_BOF2
            // 
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF2.Caption = "C_O2_Gas_BOF2";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF2.ColumnName = "C_O2_Gas_BOF2";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF2.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF2.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_O2_Gas_BOF3
            // 
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF3.Caption = "C_O2_Gas_BOF3";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF3.ColumnName = "C_O2_Gas_BOF3";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF3.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF3.Namespace = "";
            // 
            // coldsRuntimeL3DataTableC_O2_Gas_BOF4
            // 
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF4.Caption = "C_O2_Gas_BOF4";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF4.ColumnName = "C_O2_Gas_BOF4";
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF4.DataType = typeof(float);
            this.coldsRuntimeL3DataTableC_O2_Gas_BOF4.Namespace = "";
            // 
            // coldsRuntimeL3DataTableShift
            // 
            this.coldsRuntimeL3DataTableShift.Caption = "Shift";
            this.coldsRuntimeL3DataTableShift.ColumnName = "Shift";
            this.coldsRuntimeL3DataTableShift.Namespace = "";
            // 
            // coldsRuntimeL3DataTableTeam
            // 
            this.coldsRuntimeL3DataTableTeam.Caption = "Team";
            this.coldsRuntimeL3DataTableTeam.ColumnName = "Team";
            this.coldsRuntimeL3DataTableTeam.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到第一条记录";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到上一条记录";
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
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到下一条记录";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel3.Text = "          ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "选择时间:";
            // 
            // dtStartTime
            // 
            this.dtStartTime.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtStartTime.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStartTime.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStartTime.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStartTime.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(140, 22);
            this.dtStartTime.Text = "2009-04-14 17:08";
            this.dtStartTime.Value = new System.DateTime(2009, 4, 14, 17, 8, 44, 153);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel2.Text = "-";
            // 
            // dtEndTime
            // 
            this.dtEndTime.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtEndTime.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEndTime.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEndTime.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEndTime.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(140, 22);
            this.dtEndTime.Text = "2009-04-14 17:08";
            this.dtEndTime.Value = new System.DateTime(2009, 4, 14, 17, 8, 49, 340);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabel5.Text = "     ";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(51, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            // dvRuntime
            // 
            this.dvRuntime.AllowUserToAddRows = false;
            this.dvRuntime.AllowUserToDeleteRows = false;
            this.dvRuntime.AllowUserToResizeRows = false;
            this.dvRuntime.AutoGenerateColumns = false;
            this.dvRuntime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvRuntime.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvRuntime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvRuntime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catchTimeDataGridViewTextBoxColumn,
            this.pBeforeCycPumpBOF4DataGridViewTextBoxColumn,
            this.pAfterCycPumpBOF4DataGridViewTextBoxColumn,
            this.pRegenerator1DataGridViewTextBoxColumn,
            this.tRegenerator1DataGridViewTextBoxColumn,
            this.pRegenerator2DataGridViewTextBoxColumn,
            this.tRegenerator2DataGridViewTextBoxColumn,
            this.pSupplyRegeneratorDataGridViewTextBoxColumn,
            this.pYiWenBOF1DataGridViewTextBoxColumn,
            this.pYiWenBOF2DataGridViewTextBoxColumn,
            this.pYiWenBOF3DataGridViewTextBoxColumn,
            this.pYiWenBOF4DataGridViewTextBoxColumn,
            this.loseYiWenBOF1DataGridViewTextBoxColumn,
            this.loseYiWenBOF2DataGridViewTextBoxColumn,
            this.loseYiWenBOF3DataGridViewTextBoxColumn,
            this.loseYiWenBOF4DataGridViewTextBoxColumn,
            this.pWaterYiWenBOF1DataGridViewTextBoxColumn,
            this.pWaterYiWenBOF2DataGridViewTextBoxColumn,
            this.pWaterYiWenBOF3DataGridViewTextBoxColumn,
            this.pWaterYiWenBOF4DataGridViewTextBoxColumn,
            this.fWaterJetYiWenBOF1DataGridViewTextBoxColumn,
            this.fWaterJetYiWenBOF2DataGridViewTextBoxColumn,
            this.fWaterJetYiWenBOF3DataGridViewTextBoxColumn,
            this.fWaterJetYiWenBOF4DataGridViewTextBoxColumn,
            this.fWaterSpillYiWenBOF1DataGridViewTextBoxColumn,
            this.fWaterSpillYiWenBOF2DataGridViewTextBoxColumn,
            this.fWaterSpillYiWenBOF3DataGridViewTextBoxColumn,
            this.fWaterSpillYiWenBOF4DataGridViewTextBoxColumn,
            this.tWaterCycleBOF1DataGridViewTextBoxColumn,
            this.tWaterCycleBOF2DataGridViewTextBoxColumn,
            this.tWaterCycleBOF3DataGridViewTextBoxColumn,
            this.tWaterCycleBOF4DataGridViewTextBoxColumn,
            this.tOutYiWenBOF1DataGridViewTextBoxColumn,
            this.tOutYiWenBOF2DataGridViewTextBoxColumn,
            this.tOutYiWenBOF3DataGridViewTextBoxColumn,
            this.tOutYiWenBOF4DataGridViewTextBoxColumn,
            this.loseErWenBOF1DataGridViewTextBoxColumn,
            this.loseErWenBOF2DataGridViewTextBoxColumn,
            this.loseErWenBOF3DataGridViewTextBoxColumn,
            this.loseErWenBOF4DataGridViewTextBoxColumn,
            this.fWaterErWenBOF1DataGridViewTextBoxColumn,
            this.fWaterErWenBOF2DataGridViewTextBoxColumn,
            this.fWaterErWenBOF3DataGridViewTextBoxColumn,
            this.fWaterErWenBOF4DataGridViewTextBoxColumn,
            this.tOutErWenBOF1DataGridViewTextBoxColumn,
            this.tOutErWenBOF2DataGridViewTextBoxColumn,
            this.tOutErWenBOF3DataGridViewTextBoxColumn,
            this.tOutErWenBOF4DataGridViewTextBoxColumn,
            this.spanValveErWenBOF1DataGridViewTextBoxColumn,
            this.spanValveErWenBOF2DataGridViewTextBoxColumn,
            this.spanValveErWenBOF3DataGridViewTextBoxColumn,
            this.spanValveErWenBOF4DataGridViewTextBoxColumn,
            this.revFanBOF1DataGridViewTextBoxColumn,
            this.revFanBOF2DataGridViewTextBoxColumn,
            this.revFanBOF3DataGridViewTextBoxColumn,
            this.revFanBOF4DataGridViewTextBoxColumn,
            this.cCOGasBOF1DataGridViewTextBoxColumn,
            this.cCOGasBOF2DataGridViewTextBoxColumn,
            this.cCOGasBOF3DataGridViewTextBoxColumn,
            this.cCOGasBOF4DataGridViewTextBoxColumn,
            this.cO2GasBOF1DataGridViewTextBoxColumn,
            this.cO2GasBOF2DataGridViewTextBoxColumn,
            this.cO2GasBOF3DataGridViewTextBoxColumn,
            this.cO2GasBOF4DataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvRuntime.DataSource = this.bsRuntime;
            this.dvRuntime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRuntime.Location = new System.Drawing.Point(0, 25);
            this.dvRuntime.Name = "dvRuntime";
            this.dvRuntime.ReadOnly = true;
            this.dvRuntime.RowHeadersVisible = false;
            this.dvRuntime.RowTemplate.Height = 23;
            this.dvRuntime.Size = new System.Drawing.Size(1000, 575);
            this.dvRuntime.TabIndex = 20;
            this.dvRuntime.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvRuntime_DataError);
            // 
            // catchTimeDataGridViewTextBoxColumn
            // 
            this.catchTimeDataGridViewTextBoxColumn.DataPropertyName = "Catch_Time";
            this.catchTimeDataGridViewTextBoxColumn.HeaderText = "采集时刻";
            this.catchTimeDataGridViewTextBoxColumn.Name = "catchTimeDataGridViewTextBoxColumn";
            this.catchTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.catchTimeDataGridViewTextBoxColumn.Width = 59;
            // 
            // pBeforeCycPumpBOF4DataGridViewTextBoxColumn
            // 
            this.pBeforeCycPumpBOF4DataGridViewTextBoxColumn.DataPropertyName = "P_Before_CycPump_BOF4";
            this.pBeforeCycPumpBOF4DataGridViewTextBoxColumn.HeaderText = "4#转炉烟罩循环泵后压力";
            this.pBeforeCycPumpBOF4DataGridViewTextBoxColumn.Name = "pBeforeCycPumpBOF4DataGridViewTextBoxColumn";
            this.pBeforeCycPumpBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.pBeforeCycPumpBOF4DataGridViewTextBoxColumn.Width = 103;
            // 
            // pAfterCycPumpBOF4DataGridViewTextBoxColumn
            // 
            this.pAfterCycPumpBOF4DataGridViewTextBoxColumn.DataPropertyName = "P_After_CycPump_BOF4";
            this.pAfterCycPumpBOF4DataGridViewTextBoxColumn.HeaderText = "4#转炉烟罩循环泵前压力";
            this.pAfterCycPumpBOF4DataGridViewTextBoxColumn.Name = "pAfterCycPumpBOF4DataGridViewTextBoxColumn";
            this.pAfterCycPumpBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.pAfterCycPumpBOF4DataGridViewTextBoxColumn.Width = 103;
            // 
            // pRegenerator1DataGridViewTextBoxColumn
            // 
            this.pRegenerator1DataGridViewTextBoxColumn.DataPropertyName = "P_Regenerator1";
            this.pRegenerator1DataGridViewTextBoxColumn.HeaderText = "1#蓄热器工作压力";
            this.pRegenerator1DataGridViewTextBoxColumn.Name = "pRegenerator1DataGridViewTextBoxColumn";
            this.pRegenerator1DataGridViewTextBoxColumn.ReadOnly = true;
            this.pRegenerator1DataGridViewTextBoxColumn.Width = 81;
            // 
            // tRegenerator1DataGridViewTextBoxColumn
            // 
            this.tRegenerator1DataGridViewTextBoxColumn.DataPropertyName = "T_Regenerator1";
            this.tRegenerator1DataGridViewTextBoxColumn.HeaderText = "1#蓄热器工作温度";
            this.tRegenerator1DataGridViewTextBoxColumn.Name = "tRegenerator1DataGridViewTextBoxColumn";
            this.tRegenerator1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tRegenerator1DataGridViewTextBoxColumn.Width = 81;
            // 
            // pRegenerator2DataGridViewTextBoxColumn
            // 
            this.pRegenerator2DataGridViewTextBoxColumn.DataPropertyName = "P_Regenerator2";
            this.pRegenerator2DataGridViewTextBoxColumn.HeaderText = "2#蓄热器工作压力";
            this.pRegenerator2DataGridViewTextBoxColumn.Name = "pRegenerator2DataGridViewTextBoxColumn";
            this.pRegenerator2DataGridViewTextBoxColumn.ReadOnly = true;
            this.pRegenerator2DataGridViewTextBoxColumn.Width = 81;
            // 
            // tRegenerator2DataGridViewTextBoxColumn
            // 
            this.tRegenerator2DataGridViewTextBoxColumn.DataPropertyName = "T_Regenerator2";
            this.tRegenerator2DataGridViewTextBoxColumn.HeaderText = "2#蓄热器工作温度";
            this.tRegenerator2DataGridViewTextBoxColumn.Name = "tRegenerator2DataGridViewTextBoxColumn";
            this.tRegenerator2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tRegenerator2DataGridViewTextBoxColumn.Width = 81;
            // 
            // pSupplyRegeneratorDataGridViewTextBoxColumn
            // 
            this.pSupplyRegeneratorDataGridViewTextBoxColumn.DataPropertyName = "P_Supply_Regenerator";
            this.pSupplyRegeneratorDataGridViewTextBoxColumn.HeaderText = "蓄热器供外网压力";
            this.pSupplyRegeneratorDataGridViewTextBoxColumn.Name = "pSupplyRegeneratorDataGridViewTextBoxColumn";
            this.pSupplyRegeneratorDataGridViewTextBoxColumn.ReadOnly = true;
            this.pSupplyRegeneratorDataGridViewTextBoxColumn.Width = 81;
            // 
            // pYiWenBOF1DataGridViewTextBoxColumn
            // 
            this.pYiWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "P_YiWen_BOF1";
            this.pYiWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#一文前负压";
            this.pYiWenBOF1DataGridViewTextBoxColumn.Name = "pYiWenBOF1DataGridViewTextBoxColumn";
            this.pYiWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.pYiWenBOF1DataGridViewTextBoxColumn.Width = 70;
            // 
            // pYiWenBOF2DataGridViewTextBoxColumn
            // 
            this.pYiWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "P_YiWen_BOF2";
            this.pYiWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#一文前负压";
            this.pYiWenBOF2DataGridViewTextBoxColumn.Name = "pYiWenBOF2DataGridViewTextBoxColumn";
            this.pYiWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.pYiWenBOF2DataGridViewTextBoxColumn.Width = 70;
            // 
            // pYiWenBOF3DataGridViewTextBoxColumn
            // 
            this.pYiWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "P_YiWen_BOF3";
            this.pYiWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#一文前负压";
            this.pYiWenBOF3DataGridViewTextBoxColumn.Name = "pYiWenBOF3DataGridViewTextBoxColumn";
            this.pYiWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.pYiWenBOF3DataGridViewTextBoxColumn.Width = 70;
            // 
            // pYiWenBOF4DataGridViewTextBoxColumn
            // 
            this.pYiWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "P_YiWen_BOF4";
            this.pYiWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#一文前负压";
            this.pYiWenBOF4DataGridViewTextBoxColumn.Name = "pYiWenBOF4DataGridViewTextBoxColumn";
            this.pYiWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.pYiWenBOF4DataGridViewTextBoxColumn.Width = 70;
            // 
            // loseYiWenBOF1DataGridViewTextBoxColumn
            // 
            this.loseYiWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "Lose_YiWen_BOF1";
            this.loseYiWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#一文阻损";
            this.loseYiWenBOF1DataGridViewTextBoxColumn.Name = "loseYiWenBOF1DataGridViewTextBoxColumn";
            this.loseYiWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseYiWenBOF1DataGridViewTextBoxColumn.Width = 70;
            // 
            // loseYiWenBOF2DataGridViewTextBoxColumn
            // 
            this.loseYiWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "Lose_YiWen_BOF2";
            this.loseYiWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#一文阻损";
            this.loseYiWenBOF2DataGridViewTextBoxColumn.Name = "loseYiWenBOF2DataGridViewTextBoxColumn";
            this.loseYiWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseYiWenBOF2DataGridViewTextBoxColumn.Width = 70;
            // 
            // loseYiWenBOF3DataGridViewTextBoxColumn
            // 
            this.loseYiWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "Lose_YiWen_BOF3";
            this.loseYiWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#一文阻损";
            this.loseYiWenBOF3DataGridViewTextBoxColumn.Name = "loseYiWenBOF3DataGridViewTextBoxColumn";
            this.loseYiWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseYiWenBOF3DataGridViewTextBoxColumn.Width = 70;
            // 
            // loseYiWenBOF4DataGridViewTextBoxColumn
            // 
            this.loseYiWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "Lose_YiWen_BOF4";
            this.loseYiWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#一文阻损";
            this.loseYiWenBOF4DataGridViewTextBoxColumn.Name = "loseYiWenBOF4DataGridViewTextBoxColumn";
            this.loseYiWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseYiWenBOF4DataGridViewTextBoxColumn.Width = 70;
            // 
            // pWaterYiWenBOF1DataGridViewTextBoxColumn
            // 
            this.pWaterYiWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "P_Water_YiWen_BOF1";
            this.pWaterYiWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#一文冷却水水压";
            this.pWaterYiWenBOF1DataGridViewTextBoxColumn.Name = "pWaterYiWenBOF1DataGridViewTextBoxColumn";
            this.pWaterYiWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.pWaterYiWenBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // pWaterYiWenBOF2DataGridViewTextBoxColumn
            // 
            this.pWaterYiWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "P_Water_YiWen_BOF2";
            this.pWaterYiWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#一文冷却水水压";
            this.pWaterYiWenBOF2DataGridViewTextBoxColumn.Name = "pWaterYiWenBOF2DataGridViewTextBoxColumn";
            this.pWaterYiWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.pWaterYiWenBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // pWaterYiWenBOF3DataGridViewTextBoxColumn
            // 
            this.pWaterYiWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "P_Water_YiWen_BOF3";
            this.pWaterYiWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#一文冷却水水压";
            this.pWaterYiWenBOF3DataGridViewTextBoxColumn.Name = "pWaterYiWenBOF3DataGridViewTextBoxColumn";
            this.pWaterYiWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.pWaterYiWenBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // pWaterYiWenBOF4DataGridViewTextBoxColumn
            // 
            this.pWaterYiWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "P_Water_YiWen_BOF4";
            this.pWaterYiWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#一文冷却水水压";
            this.pWaterYiWenBOF4DataGridViewTextBoxColumn.Name = "pWaterYiWenBOF4DataGridViewTextBoxColumn";
            this.pWaterYiWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.pWaterYiWenBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterJetYiWenBOF1DataGridViewTextBoxColumn
            // 
            this.fWaterJetYiWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Jet_YiWen_BOF1";
            this.fWaterJetYiWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#一文喷头水流量";
            this.fWaterJetYiWenBOF1DataGridViewTextBoxColumn.Name = "fWaterJetYiWenBOF1DataGridViewTextBoxColumn";
            this.fWaterJetYiWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterJetYiWenBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterJetYiWenBOF2DataGridViewTextBoxColumn
            // 
            this.fWaterJetYiWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Jet_YiWen_BOF2";
            this.fWaterJetYiWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#一文喷头水流量";
            this.fWaterJetYiWenBOF2DataGridViewTextBoxColumn.Name = "fWaterJetYiWenBOF2DataGridViewTextBoxColumn";
            this.fWaterJetYiWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterJetYiWenBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterJetYiWenBOF3DataGridViewTextBoxColumn
            // 
            this.fWaterJetYiWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Jet_YiWen_BOF3";
            this.fWaterJetYiWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#一文喷头水流量";
            this.fWaterJetYiWenBOF3DataGridViewTextBoxColumn.Name = "fWaterJetYiWenBOF3DataGridViewTextBoxColumn";
            this.fWaterJetYiWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterJetYiWenBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterJetYiWenBOF4DataGridViewTextBoxColumn
            // 
            this.fWaterJetYiWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Jet_YiWen_BOF4";
            this.fWaterJetYiWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#一文喷头水流量";
            this.fWaterJetYiWenBOF4DataGridViewTextBoxColumn.Name = "fWaterJetYiWenBOF4DataGridViewTextBoxColumn";
            this.fWaterJetYiWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterJetYiWenBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterSpillYiWenBOF1DataGridViewTextBoxColumn
            // 
            this.fWaterSpillYiWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Spill_YiWen_BOF1";
            this.fWaterSpillYiWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#一文溢流水流量";
            this.fWaterSpillYiWenBOF1DataGridViewTextBoxColumn.Name = "fWaterSpillYiWenBOF1DataGridViewTextBoxColumn";
            this.fWaterSpillYiWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterSpillYiWenBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterSpillYiWenBOF2DataGridViewTextBoxColumn
            // 
            this.fWaterSpillYiWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Spill_YiWen_BOF2";
            this.fWaterSpillYiWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#一文溢流水流量";
            this.fWaterSpillYiWenBOF2DataGridViewTextBoxColumn.Name = "fWaterSpillYiWenBOF2DataGridViewTextBoxColumn";
            this.fWaterSpillYiWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterSpillYiWenBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterSpillYiWenBOF3DataGridViewTextBoxColumn
            // 
            this.fWaterSpillYiWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Spill_YiWen_BOF3";
            this.fWaterSpillYiWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#一文溢流水流量";
            this.fWaterSpillYiWenBOF3DataGridViewTextBoxColumn.Name = "fWaterSpillYiWenBOF3DataGridViewTextBoxColumn";
            this.fWaterSpillYiWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterSpillYiWenBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterSpillYiWenBOF4DataGridViewTextBoxColumn
            // 
            this.fWaterSpillYiWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "F_Water_Spill_YiWen_BOF4";
            this.fWaterSpillYiWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#一文溢流水流量";
            this.fWaterSpillYiWenBOF4DataGridViewTextBoxColumn.Name = "fWaterSpillYiWenBOF4DataGridViewTextBoxColumn";
            this.fWaterSpillYiWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterSpillYiWenBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // tWaterCycleBOF1DataGridViewTextBoxColumn
            // 
            this.tWaterCycleBOF1DataGridViewTextBoxColumn.DataPropertyName = "T_Water_Cycle_BOF1";
            this.tWaterCycleBOF1DataGridViewTextBoxColumn.HeaderText = "1#转炉浊环水温度";
            this.tWaterCycleBOF1DataGridViewTextBoxColumn.Name = "tWaterCycleBOF1DataGridViewTextBoxColumn";
            this.tWaterCycleBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tWaterCycleBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // tWaterCycleBOF2DataGridViewTextBoxColumn
            // 
            this.tWaterCycleBOF2DataGridViewTextBoxColumn.DataPropertyName = "T_Water_Cycle_BOF2";
            this.tWaterCycleBOF2DataGridViewTextBoxColumn.HeaderText = "2#转炉浊环水温度";
            this.tWaterCycleBOF2DataGridViewTextBoxColumn.Name = "tWaterCycleBOF2DataGridViewTextBoxColumn";
            this.tWaterCycleBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tWaterCycleBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // tWaterCycleBOF3DataGridViewTextBoxColumn
            // 
            this.tWaterCycleBOF3DataGridViewTextBoxColumn.DataPropertyName = "T_Water_Cycle_BOF3";
            this.tWaterCycleBOF3DataGridViewTextBoxColumn.HeaderText = "3#转炉浊环水温度";
            this.tWaterCycleBOF3DataGridViewTextBoxColumn.Name = "tWaterCycleBOF3DataGridViewTextBoxColumn";
            this.tWaterCycleBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.tWaterCycleBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // tWaterCycleBOF4DataGridViewTextBoxColumn
            // 
            this.tWaterCycleBOF4DataGridViewTextBoxColumn.DataPropertyName = "T_Water_Cycle_BOF4";
            this.tWaterCycleBOF4DataGridViewTextBoxColumn.HeaderText = "4#转炉浊环水温度";
            this.tWaterCycleBOF4DataGridViewTextBoxColumn.Name = "tWaterCycleBOF4DataGridViewTextBoxColumn";
            this.tWaterCycleBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.tWaterCycleBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // tOutYiWenBOF1DataGridViewTextBoxColumn
            // 
            this.tOutYiWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "T_Out_YiWen_BOF1";
            this.tOutYiWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#一文出口烟气温度";
            this.tOutYiWenBOF1DataGridViewTextBoxColumn.Name = "tOutYiWenBOF1DataGridViewTextBoxColumn";
            this.tOutYiWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutYiWenBOF1DataGridViewTextBoxColumn.Width = 92;
            // 
            // tOutYiWenBOF2DataGridViewTextBoxColumn
            // 
            this.tOutYiWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "T_Out_YiWen_BOF2";
            this.tOutYiWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#一文出口烟气温度";
            this.tOutYiWenBOF2DataGridViewTextBoxColumn.Name = "tOutYiWenBOF2DataGridViewTextBoxColumn";
            this.tOutYiWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutYiWenBOF2DataGridViewTextBoxColumn.Width = 92;
            // 
            // tOutYiWenBOF3DataGridViewTextBoxColumn
            // 
            this.tOutYiWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "T_Out_YiWen_BOF3";
            this.tOutYiWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#一文出口烟气温度";
            this.tOutYiWenBOF3DataGridViewTextBoxColumn.Name = "tOutYiWenBOF3DataGridViewTextBoxColumn";
            this.tOutYiWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutYiWenBOF3DataGridViewTextBoxColumn.Width = 92;
            // 
            // tOutYiWenBOF4DataGridViewTextBoxColumn
            // 
            this.tOutYiWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "T_Out_YiWen_BOF4";
            this.tOutYiWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#一文出口烟气温度";
            this.tOutYiWenBOF4DataGridViewTextBoxColumn.Name = "tOutYiWenBOF4DataGridViewTextBoxColumn";
            this.tOutYiWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutYiWenBOF4DataGridViewTextBoxColumn.Width = 92;
            // 
            // loseErWenBOF1DataGridViewTextBoxColumn
            // 
            this.loseErWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "Lose_ErWen_BOF1";
            this.loseErWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#二文阻损";
            this.loseErWenBOF1DataGridViewTextBoxColumn.Name = "loseErWenBOF1DataGridViewTextBoxColumn";
            this.loseErWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseErWenBOF1DataGridViewTextBoxColumn.Width = 70;
            // 
            // loseErWenBOF2DataGridViewTextBoxColumn
            // 
            this.loseErWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "Lose_ErWen_BOF2";
            this.loseErWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#二文阻损";
            this.loseErWenBOF2DataGridViewTextBoxColumn.Name = "loseErWenBOF2DataGridViewTextBoxColumn";
            this.loseErWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseErWenBOF2DataGridViewTextBoxColumn.Width = 70;
            // 
            // loseErWenBOF3DataGridViewTextBoxColumn
            // 
            this.loseErWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "Lose_ErWen_BOF3";
            this.loseErWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#二文阻损";
            this.loseErWenBOF3DataGridViewTextBoxColumn.Name = "loseErWenBOF3DataGridViewTextBoxColumn";
            this.loseErWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseErWenBOF3DataGridViewTextBoxColumn.Width = 70;
            // 
            // loseErWenBOF4DataGridViewTextBoxColumn
            // 
            this.loseErWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "Lose_ErWen_BOF4";
            this.loseErWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#二文阻损";
            this.loseErWenBOF4DataGridViewTextBoxColumn.Name = "loseErWenBOF4DataGridViewTextBoxColumn";
            this.loseErWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.loseErWenBOF4DataGridViewTextBoxColumn.Width = 70;
            // 
            // fWaterErWenBOF1DataGridViewTextBoxColumn
            // 
            this.fWaterErWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "F_Water_ErWen_BOF1";
            this.fWaterErWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#二文冷却水流量";
            this.fWaterErWenBOF1DataGridViewTextBoxColumn.Name = "fWaterErWenBOF1DataGridViewTextBoxColumn";
            this.fWaterErWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterErWenBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterErWenBOF2DataGridViewTextBoxColumn
            // 
            this.fWaterErWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "F_Water_ErWen_BOF2";
            this.fWaterErWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#二文冷却水流量";
            this.fWaterErWenBOF2DataGridViewTextBoxColumn.Name = "fWaterErWenBOF2DataGridViewTextBoxColumn";
            this.fWaterErWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterErWenBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterErWenBOF3DataGridViewTextBoxColumn
            // 
            this.fWaterErWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "F_Water_ErWen_BOF3";
            this.fWaterErWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#二文冷却水流量";
            this.fWaterErWenBOF3DataGridViewTextBoxColumn.Name = "fWaterErWenBOF3DataGridViewTextBoxColumn";
            this.fWaterErWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterErWenBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // fWaterErWenBOF4DataGridViewTextBoxColumn
            // 
            this.fWaterErWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "F_Water_ErWen_BOF4";
            this.fWaterErWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#二文冷却水流量";
            this.fWaterErWenBOF4DataGridViewTextBoxColumn.Name = "fWaterErWenBOF4DataGridViewTextBoxColumn";
            this.fWaterErWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.fWaterErWenBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // tOutErWenBOF1DataGridViewTextBoxColumn
            // 
            this.tOutErWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "T_Out_ErWen_BOF1";
            this.tOutErWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#二文出口烟气温度";
            this.tOutErWenBOF1DataGridViewTextBoxColumn.Name = "tOutErWenBOF1DataGridViewTextBoxColumn";
            this.tOutErWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutErWenBOF1DataGridViewTextBoxColumn.Width = 92;
            // 
            // tOutErWenBOF2DataGridViewTextBoxColumn
            // 
            this.tOutErWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "T_Out_ErWen_BOF2";
            this.tOutErWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#二文出口烟气温度";
            this.tOutErWenBOF2DataGridViewTextBoxColumn.Name = "tOutErWenBOF2DataGridViewTextBoxColumn";
            this.tOutErWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutErWenBOF2DataGridViewTextBoxColumn.Width = 92;
            // 
            // tOutErWenBOF3DataGridViewTextBoxColumn
            // 
            this.tOutErWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "T_Out_ErWen_BOF3";
            this.tOutErWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#二文出口烟气温度";
            this.tOutErWenBOF3DataGridViewTextBoxColumn.Name = "tOutErWenBOF3DataGridViewTextBoxColumn";
            this.tOutErWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutErWenBOF3DataGridViewTextBoxColumn.Width = 92;
            // 
            // tOutErWenBOF4DataGridViewTextBoxColumn
            // 
            this.tOutErWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "T_Out_ErWen_BOF4";
            this.tOutErWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#二文出口烟气温度";
            this.tOutErWenBOF4DataGridViewTextBoxColumn.Name = "tOutErWenBOF4DataGridViewTextBoxColumn";
            this.tOutErWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.tOutErWenBOF4DataGridViewTextBoxColumn.Width = 92;
            // 
            // spanValveErWenBOF1DataGridViewTextBoxColumn
            // 
            this.spanValveErWenBOF1DataGridViewTextBoxColumn.DataPropertyName = "Span_Valve_ErWen_BOF1";
            this.spanValveErWenBOF1DataGridViewTextBoxColumn.HeaderText = "1#二文翻板开口度";
            this.spanValveErWenBOF1DataGridViewTextBoxColumn.Name = "spanValveErWenBOF1DataGridViewTextBoxColumn";
            this.spanValveErWenBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.spanValveErWenBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // spanValveErWenBOF2DataGridViewTextBoxColumn
            // 
            this.spanValveErWenBOF2DataGridViewTextBoxColumn.DataPropertyName = "Span_Valve_ErWen_BOF2";
            this.spanValveErWenBOF2DataGridViewTextBoxColumn.HeaderText = "2#二文翻板开口度";
            this.spanValveErWenBOF2DataGridViewTextBoxColumn.Name = "spanValveErWenBOF2DataGridViewTextBoxColumn";
            this.spanValveErWenBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.spanValveErWenBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // spanValveErWenBOF3DataGridViewTextBoxColumn
            // 
            this.spanValveErWenBOF3DataGridViewTextBoxColumn.DataPropertyName = "Span_Valve_ErWen_BOF3";
            this.spanValveErWenBOF3DataGridViewTextBoxColumn.HeaderText = "3#二文翻板开口度";
            this.spanValveErWenBOF3DataGridViewTextBoxColumn.Name = "spanValveErWenBOF3DataGridViewTextBoxColumn";
            this.spanValveErWenBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.spanValveErWenBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // spanValveErWenBOF4DataGridViewTextBoxColumn
            // 
            this.spanValveErWenBOF4DataGridViewTextBoxColumn.DataPropertyName = "Span_Valve_ErWen_BOF4";
            this.spanValveErWenBOF4DataGridViewTextBoxColumn.HeaderText = "4#二文翻板开口度";
            this.spanValveErWenBOF4DataGridViewTextBoxColumn.Name = "spanValveErWenBOF4DataGridViewTextBoxColumn";
            this.spanValveErWenBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.spanValveErWenBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // revFanBOF1DataGridViewTextBoxColumn
            // 
            this.revFanBOF1DataGridViewTextBoxColumn.DataPropertyName = "Rev_Fan_BOF1";
            this.revFanBOF1DataGridViewTextBoxColumn.HeaderText = "1#风机转速";
            this.revFanBOF1DataGridViewTextBoxColumn.Name = "revFanBOF1DataGridViewTextBoxColumn";
            this.revFanBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.revFanBOF1DataGridViewTextBoxColumn.Width = 70;
            // 
            // revFanBOF2DataGridViewTextBoxColumn
            // 
            this.revFanBOF2DataGridViewTextBoxColumn.DataPropertyName = "Rev_Fan_BOF2";
            this.revFanBOF2DataGridViewTextBoxColumn.HeaderText = "2#风机转速";
            this.revFanBOF2DataGridViewTextBoxColumn.Name = "revFanBOF2DataGridViewTextBoxColumn";
            this.revFanBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.revFanBOF2DataGridViewTextBoxColumn.Width = 70;
            // 
            // revFanBOF3DataGridViewTextBoxColumn
            // 
            this.revFanBOF3DataGridViewTextBoxColumn.DataPropertyName = "Rev_Fan_BOF3";
            this.revFanBOF3DataGridViewTextBoxColumn.HeaderText = "3#风机转速";
            this.revFanBOF3DataGridViewTextBoxColumn.Name = "revFanBOF3DataGridViewTextBoxColumn";
            this.revFanBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.revFanBOF3DataGridViewTextBoxColumn.Width = 70;
            // 
            // revFanBOF4DataGridViewTextBoxColumn
            // 
            this.revFanBOF4DataGridViewTextBoxColumn.DataPropertyName = "Rev_Fan_BOF4";
            this.revFanBOF4DataGridViewTextBoxColumn.HeaderText = "4#风机转速";
            this.revFanBOF4DataGridViewTextBoxColumn.Name = "revFanBOF4DataGridViewTextBoxColumn";
            this.revFanBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.revFanBOF4DataGridViewTextBoxColumn.Width = 70;
            // 
            // cCOGasBOF1DataGridViewTextBoxColumn
            // 
            this.cCOGasBOF1DataGridViewTextBoxColumn.DataPropertyName = "C_CO_Gas_BOF1";
            this.cCOGasBOF1DataGridViewTextBoxColumn.HeaderText = "1#转炉煤气CO含量";
            this.cCOGasBOF1DataGridViewTextBoxColumn.Name = "cCOGasBOF1DataGridViewTextBoxColumn";
            this.cCOGasBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cCOGasBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // cCOGasBOF2DataGridViewTextBoxColumn
            // 
            this.cCOGasBOF2DataGridViewTextBoxColumn.DataPropertyName = "C_CO_Gas_BOF2";
            this.cCOGasBOF2DataGridViewTextBoxColumn.HeaderText = "2#转炉煤气CO含量";
            this.cCOGasBOF2DataGridViewTextBoxColumn.Name = "cCOGasBOF2DataGridViewTextBoxColumn";
            this.cCOGasBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.cCOGasBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // cCOGasBOF3DataGridViewTextBoxColumn
            // 
            this.cCOGasBOF3DataGridViewTextBoxColumn.DataPropertyName = "C_CO_Gas_BOF3";
            this.cCOGasBOF3DataGridViewTextBoxColumn.HeaderText = "3#转炉煤气CO含量";
            this.cCOGasBOF3DataGridViewTextBoxColumn.Name = "cCOGasBOF3DataGridViewTextBoxColumn";
            this.cCOGasBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.cCOGasBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // cCOGasBOF4DataGridViewTextBoxColumn
            // 
            this.cCOGasBOF4DataGridViewTextBoxColumn.DataPropertyName = "C_CO_Gas_BOF4";
            this.cCOGasBOF4DataGridViewTextBoxColumn.HeaderText = "4#转炉煤气CO含量";
            this.cCOGasBOF4DataGridViewTextBoxColumn.Name = "cCOGasBOF4DataGridViewTextBoxColumn";
            this.cCOGasBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.cCOGasBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // cO2GasBOF1DataGridViewTextBoxColumn
            // 
            this.cO2GasBOF1DataGridViewTextBoxColumn.DataPropertyName = "C_O2_Gas_BOF1";
            this.cO2GasBOF1DataGridViewTextBoxColumn.HeaderText = "1#转炉煤气O2含量";
            this.cO2GasBOF1DataGridViewTextBoxColumn.Name = "cO2GasBOF1DataGridViewTextBoxColumn";
            this.cO2GasBOF1DataGridViewTextBoxColumn.ReadOnly = true;
            this.cO2GasBOF1DataGridViewTextBoxColumn.Width = 81;
            // 
            // cO2GasBOF2DataGridViewTextBoxColumn
            // 
            this.cO2GasBOF2DataGridViewTextBoxColumn.DataPropertyName = "C_O2_Gas_BOF2";
            this.cO2GasBOF2DataGridViewTextBoxColumn.HeaderText = "2#转炉煤气O2含量";
            this.cO2GasBOF2DataGridViewTextBoxColumn.Name = "cO2GasBOF2DataGridViewTextBoxColumn";
            this.cO2GasBOF2DataGridViewTextBoxColumn.ReadOnly = true;
            this.cO2GasBOF2DataGridViewTextBoxColumn.Width = 81;
            // 
            // cO2GasBOF3DataGridViewTextBoxColumn
            // 
            this.cO2GasBOF3DataGridViewTextBoxColumn.DataPropertyName = "C_O2_Gas_BOF3";
            this.cO2GasBOF3DataGridViewTextBoxColumn.HeaderText = "3#转炉煤气O2含量";
            this.cO2GasBOF3DataGridViewTextBoxColumn.Name = "cO2GasBOF3DataGridViewTextBoxColumn";
            this.cO2GasBOF3DataGridViewTextBoxColumn.ReadOnly = true;
            this.cO2GasBOF3DataGridViewTextBoxColumn.Width = 81;
            // 
            // cO2GasBOF4DataGridViewTextBoxColumn
            // 
            this.cO2GasBOF4DataGridViewTextBoxColumn.DataPropertyName = "C_O2_Gas_BOF4";
            this.cO2GasBOF4DataGridViewTextBoxColumn.HeaderText = "4#转炉煤气O2含量";
            this.cO2GasBOF4DataGridViewTextBoxColumn.Name = "cO2GasBOF4DataGridViewTextBoxColumn";
            this.cO2GasBOF4DataGridViewTextBoxColumn.ReadOnly = true;
            this.cO2GasBOF4DataGridViewTextBoxColumn.Width = 81;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Width = 49;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Width = 49;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 52;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 52;
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
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // EquipRuntimeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvRuntime);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipRuntimeFrm";
            this.TabText = "汽化冷却除尘管理";
            this.Text = "汽化冷却除尘管理";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRuntime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRuntime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvRuntime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dvRuntime;
        private AppSvrHMI.L3DataSet dsRuntime;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Windows.Forms.BindingSource bsRuntime;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsRuntimeL3DataTableCatch_Time;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Before_CycPump_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_After_CycPump_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Regenerator1;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Regenerator1;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Regenerator2;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Regenerator2;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Supply_Regenerator;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_YiWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_YiWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_YiWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_YiWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_YiWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_YiWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_YiWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_YiWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Water_YiWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Water_YiWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Water_YiWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableP_Water_YiWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Jet_YiWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_Spill_YiWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Water_Cycle_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Water_Cycle_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Water_Cycle_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Water_Cycle_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_YiWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_YiWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_YiWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_YiWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_ErWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_ErWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_ErWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableLose_ErWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_ErWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_ErWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_ErWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableF_Water_ErWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_ErWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_ErWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_ErWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableT_Out_ErWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableSpan_Valve_ErWen_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableRev_Fan_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableRev_Fan_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableRev_Fan_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableRev_Fan_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_CO_Gas_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_CO_Gas_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_CO_Gas_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_CO_Gas_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_O2_Gas_BOF1;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_O2_Gas_BOF2;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_O2_Gas_BOF3;
        private System.Data.DataColumn coldsRuntimeL3DataTableC_O2_Gas_BOF4;
        private System.Data.DataColumn coldsRuntimeL3DataTableShift;
        private System.Data.DataColumn coldsRuntimeL3DataTableTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn catchTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBeforeCycPumpBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAfterCycPumpBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRegenerator1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRegenerator1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRegenerator2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRegenerator2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pSupplyRegeneratorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pYiWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pYiWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pYiWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pYiWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseYiWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseYiWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseYiWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseYiWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWaterYiWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWaterYiWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWaterYiWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pWaterYiWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterJetYiWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterJetYiWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterJetYiWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterJetYiWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterSpillYiWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterSpillYiWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterSpillYiWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterSpillYiWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tWaterCycleBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tWaterCycleBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tWaterCycleBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tWaterCycleBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutYiWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutYiWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutYiWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutYiWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseErWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseErWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseErWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loseErWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterErWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterErWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterErWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fWaterErWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutErWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutErWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutErWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOutErWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spanValveErWenBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spanValveErWenBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spanValveErWenBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spanValveErWenBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revFanBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revFanBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revFanBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revFanBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOGasBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOGasBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOGasBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCOGasBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cO2GasBOF1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cO2GasBOF2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cO2GasBOF3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cO2GasBOF4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private buttonHide.ToolStripToriDateTimePicker dtStartTime;
        private buttonHide.ToolStripToriDateTimePicker dtEndTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
    }
}