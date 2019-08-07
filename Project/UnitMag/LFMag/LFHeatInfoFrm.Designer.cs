namespace UnitMag.LFMag
{
    partial class LFHeatInfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LFHeatInfoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProcessCancel = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.dtSoftBlowStartTime = new System.Windows.Forms.DateTimePicker();
            this.bsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcess = new AppSvrHMI.L3DataSet();
            this.schemadsProcess = new System.Data.DataTable();
            this.coldsProcessL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableName = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLogDate = new System.Data.DataColumn();
            this.coldsProcessL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsProcessL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableAmount = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTargetArea = new System.Data.DataColumn();
            this.coldsProcessL3DataTableOperator = new System.Data.DataColumn();
            this.coldsProcessL3DataTableShift = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTeam = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableArrival_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableArrival_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableEnd_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableProcess_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableHeat_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableHeat_Count = new System.Data.DataColumn();
            this.coldsProcessL3DataTableProbe_Vonder = new System.Data.DataColumn();
            this.coldsProcessL3DataTableFeedWire_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableDeparture_Temp = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoftBlow_StartTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoftBlow_EndTime = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSoftBlow_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLid_Life = new System.Data.DataColumn();
            this.coldsProcessL3DataTableHoldBack_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSteel_Weight = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadleNo = new System.Data.DataColumn();
            this.coldsProcessL3DataTableSlag_Thickness = new System.Data.DataColumn();
            this.coldsProcessL3DataTableLadle_Grade = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnPaocessOK = new System.Windows.Forms.Button();
            this.btnBaseOK = new System.Windows.Forms.Button();
            this.btnConfirmExcept = new System.Windows.Forms.Button();
            this.btnAddExcept = new System.Windows.Forms.ToolStripButton();
            this.btnAddRemark = new System.Windows.Forms.ToolStripButton();
            this.btnNoteConfirm = new System.Windows.Forms.Button();
            this.btnAddMat = new System.Windows.Forms.ToolStripButton();
            this.btnMatOK = new System.Windows.Forms.Button();
            this.btnWireConfirm = new System.Windows.Forms.Button();
            this.btnWireAdd = new System.Windows.Forms.ToolStripButton();
            this.btnLadleInfoOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.txtHoldBackTime = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.txtLidLife = new PxDataValid.PxTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSoftBlowTime = new PxDataValid.PxTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDepartureTemp = new PxDataValid.PxTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtHeatCount = new PxDataValid.PxTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtHeatTime = new PxDataValid.PxTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtProcessTime = new PxDataValid.PxTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtArrivalTemp = new PxDataValid.PxTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.pnlProcess = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTempCancel = new System.Windows.Forms.Button();
            this.btnTempOK = new System.Windows.Forms.Button();
            this.btnOxygenCancel = new System.Windows.Forms.Button();
            this.pnlOxygen = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOxygenOK = new System.Windows.Forms.Button();
            this.pnlTemp = new System.Windows.Forms.FlowLayoutPanel();
            this.bsOxygen = new System.Windows.Forms.BindingSource(this.components);
            this.dsOxygen = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet2 = new System.Data.DataTable();
            this.coll3DataSet2L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableTreatNo = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableOxygen_Content = new System.Data.DataColumn();
            this.coll3DataSet2L3DataTableMeasure_Time = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cmbShift = new PxDataValid.PxComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLadleNo = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeadFurnace = new System.Data.DataColumn();
            this.coldsBaseL3DataTableAssistant = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSecondHand = new System.Data.DataColumn();
            this.coldsBaseL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLocked = new System.Data.DataColumn();
            this.coldsBaseL3DataTableShift = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTeam = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeam = new PxDataValid.PxComboBox();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
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
            this.pnlBase = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseCancel = new System.Windows.Forms.Button();
            this.tabLFAddMat = new System.Windows.Forms.TabPage();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.cmbBatch_Mat = new System.Windows.Forms.ComboBox();
            this.bsBatchID_Mat = new System.Windows.Forms.BindingSource(this.components);
            this.dsBatchID_Mat = new AppSvrHMI.L3DataSet();
            this.schemadsBatchID = new System.Data.DataTable();
            this.coldsBatchIDL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsBatchID_MatL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsBatchID_MatL3DataTableCode = new System.Data.DataColumn();
            this.coldsBatchID_MatL3DataTableCode_Des = new System.Data.DataColumn();
            this.dvMat = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.schemadsCode = new System.Data.DataTable();
            this.coldsCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAdditionType = new AppSvrHMI.L3DataSet();
            this.schemadsAdditionType = new System.Data.DataTable();
            this.coldsAdditionTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsAdditionTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischargeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_ID_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsMat = new AppSvrHMI.L3DataSet();
            this.schemadsMat = new System.Data.DataTable();
            this.coldsMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatL3DataTableName = new System.Data.DataColumn();
            this.coldsMatL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsMatL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMatL3DataTableElement = new System.Data.DataColumn();
            this.coldsMatL3DataTableWeight = new System.Data.DataColumn();
            this.coldsMatL3DataTableDischarge_Time = new System.Data.DataColumn();
            this.coldsMatL3DataTableType = new System.Data.DataColumn();
            this.coldsMatL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsMatL3DataTableVendor = new System.Data.DataColumn();
            this.coldsMatL3DataTableEnableFlag = new System.Data.DataColumn();
            this.bnMat = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlMat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMatCancel = new System.Windows.Forms.Button();
            this.tabWire = new System.Windows.Forms.TabPage();
            this.hmiRootPanel3 = new HMIBase.HMIRootPanel();
            this.cmb_Wire = new System.Windows.Forms.ComboBox();
            this.bsBatchID_Wire = new System.Windows.Forms.BindingSource(this.components);
            this.dsBatchID_Wire = new AppSvrHMI.L3DataSet();
            this.schemadsBatchID_Wire = new System.Data.DataTable();
            this.coldsBatchID_WireL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsBatchID_WireL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsBatchID_WireL3DataTableCode = new System.Data.DataColumn();
            this.coldsBatchID_WireL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBatchID_WireL3DataTablecode_function_group = new System.Data.DataColumn();
            this.dvWire = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WireCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWireCode = new AppSvrHMI.L3DataSet();
            this.schemadsWireCode = new System.Data.DataTable();
            this.coldsWireCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsWireCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wireTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_ID_Wire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID_Wire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Wire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnableFlagWire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsWire = new System.Windows.Forms.BindingSource(this.components);
            this.dsWire = new AppSvrHMI.L3DataSet();
            this.schemadsWire = new System.Data.DataTable();
            this.coldsWireL3DataTableGUID = new System.Data.DataColumn();
            this.coldsWireL3DataTableName = new System.Data.DataColumn();
            this.coldsWireL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsWireL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsWireL3DataTableWireCode = new System.Data.DataColumn();
            this.coldsWireL3DataTableWeight = new System.Data.DataColumn();
            this.coldsWireL3DataTableSpeed = new System.Data.DataColumn();
            this.coldsWireL3DataTableWireTime = new System.Data.DataColumn();
            this.coldsWireL3DataTableVendor = new System.Data.DataColumn();
            this.AcoldsWireL3DataTableBatch_ID = new System.Data.DataColumn();
            this.coldsWireL3DataTableEnableFlag = new System.Data.DataColumn();
            this.coldsWireL3DataTableAmount = new System.Data.DataColumn();
            this.pnlWire = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWireCancel = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbProbe_Vonder = new System.Windows.Forms.ComboBox();
            this.dsProbe_Vonder = new AppSvrHMI.L3DataSet();
            this.schemadsProbe_Vonder = new System.Data.DataTable();
            this.coldsProbe_VonderL3DataTableCode = new System.Data.DataColumn();
            this.coldsProbe_VonderL3DataTableCode_Des = new System.Data.DataColumn();
            this.dtSoftBlowEndTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSteelWeight = new PxDataValid.PxTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.txtFeedWireTemp = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtLadleGrade = new PxDataValid.PxTextBox();
            this.txtLadleNo = new PxDataValid.PxTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtProbeVonder = new PxDataValid.PxTextBox();
            this.ptbSlag_Thickness = new PxDataValid.PxTextBox();
            this.txtHoldBackTimeDis = new PxDataValid.PxTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSoftBlowTimeDis = new PxDataValid.PxTextBox();
            this.txtHeatTimeDis = new PxDataValid.PxTextBox();
            this.txtProcessTimeDis = new PxDataValid.PxTextBox();
            this.tabLadleInfo = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.bsLadleInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsLadleInfo = new AppSvrHMI.L3DataSet();
            this.schemadsLadleInfo = new System.Data.DataTable();
            this.coldsLadleInfoL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableTemp = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLast_SteelGrade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableCur_SteelGrade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableStop_Time_Len = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableLadle_Age = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableSmall_Fire = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableMiddle_Fire = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableBig_Fire = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableNote = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableOther3 = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableMaxTemp = new System.Data.DataColumn();
            this.coldsLadleInfoL3DataTableWall_Temp = new System.Data.DataColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.pnlLadleInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLadleInfoCancel = new System.Windows.Forms.Button();
            this.tabExcept = new System.Windows.Forms.TabPage();
            this.dvExcept = new System.Windows.Forms.DataGridView();
            this.exceptionalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsExceptCode = new AppSvrHMI.L3DataSet();
            this.schemadsExceptCode = new System.Data.DataTable();
            this.coldsExceptCodeL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableExceptional_Des = new System.Data.DataColumn();
            this.coldsExceptCodeL3DataTableUnit = new System.Data.DataColumn();
            this.iDObjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preHeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preSteelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.steelGradeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.txtExcept = new System.Windows.Forms.ToolStripTextBox();
            this.tabChemical = new System.Windows.Forms.TabPage();
            this.dvChemical = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitType = new AppSvrHMI.L3DataSet();
            this.schemadsUnitType = new System.Data.DataTable();
            this.coldsUnitTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsUnitTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
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
            this.dataLogModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDataLogMode = new AppSvrHMI.L3DataSet();
            this.schemadsDataLogMode = new System.Data.DataTable();
            this.coldsDataLogModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsDataLogModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.appIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sampleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriveDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.logTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.coldsChemicalL3DataTableCrNi = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableCrNiCu = new System.Data.DataColumn();
            this.coldsChemicalL3DataTableOther3 = new System.Data.DataColumn();
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
            this.treatNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsLFStatus = new AppSvrHMI.L3DataSet();
            this.schemadsLFStatus = new System.Data.DataTable();
            this.coldsLFStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsLFStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.changeTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gears = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hot_Length_Cur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hot_Length_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableTreatNo = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableStatus = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableChange_Time = new System.Data.DataColumn();
            this.coldsStatusL3DataTableGears = new System.Data.DataColumn();
            this.coldsStatusL3DataTableHot_Length_Cur = new System.Data.DataColumn();
            this.coldsStatusL3DataTableHot_Length_Total = new System.Data.DataColumn();
            this.bnStatus = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddStatus = new System.Windows.Forms.ToolStripButton();
            this.pnlStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStatusCancel = new System.Windows.Forms.Button();
            this.btnStatusOK = new System.Windows.Forms.Button();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.hmiRootPanel6 = new HMIBase.HMIRootPanel();
            this.dvTemp = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBOFTempMode = new AppSvrHMI.L3DataSet();
            this.schemadsBOFTempMode = new System.Data.DataTable();
            this.coldsBOFTempModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBOFTempModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTemp = new System.Windows.Forms.BindingSource(this.components);
            this.dsTemp = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet5 = new System.Data.DataTable();
            this.coll3DataSet5L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet5L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet5L3DataTableTreatNo = new System.Data.DataColumn();
            this.coll3DataSet5L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet5L3DataTableTemperature = new System.Data.DataColumn();
            this.coll3DataSet5L3DataTableMeasureTime = new System.Data.DataColumn();
            this.coll3DataSet5L3DataTableMode = new System.Data.DataColumn();
            this.bnTemp = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tabOxygen = new System.Windows.Forms.TabPage();
            this.dvOxygen = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxygenContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnOxygen = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tabRemark = new System.Windows.Forms.TabPage();
            this.dvRemark = new System.Windows.Forms.DataGridView();
            this.treatNoDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsRemarkType = new AppSvrHMI.L3DataSet();
            this.schemadsRemarkType = new System.Data.DataTable();
            this.coldsRemarkTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsRemarkTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRemark = new System.Windows.Forms.BindingSource(this.components);
            this.dsRemark = new AppSvrHMI.L3DataSet();
            this.schemadsRemark = new System.Data.DataTable();
            this.coldsRemarkL3DataTableGUID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableName = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableType = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableRemark = new System.Data.DataColumn();
            this.coldsRemarkL3DataTableLogTime = new System.Data.DataColumn();
            this.bnRemark = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlNote = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNoteCancel = new System.Windows.Forms.Button();
            this.tabMidLandleTemp = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCCMTempMode = new AppSvrHMI.L3DataSet();
            this.schemadsCCMTempMode = new System.Data.DataTable();
            this.coldsCCMTempModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsCCMTempModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.tempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn2 = new DataGridValid.CalendarColumn();
            this.inValidFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTundishTemp = new System.Windows.Forms.BindingSource(this.components);
            this.dsTundishTemp = new AppSvrHMI.L3DataSet();
            this.schemadsTundishTemp = new System.Data.DataTable();
            this.coldsTundishTempL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableName = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableTempID = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableTemp = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableMeasure_Time = new System.Data.DataColumn();
            this.coldsTundishTempL3DataTableInValidFlag = new System.Data.DataColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsControlCode = new AppSvrHMI.L3DataSet();
            this.schemadsControlCode = new System.Data.DataTable();
            this.coldsControlCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableCode_Function_Group = new System.Data.DataColumn();
            this.coldsControlCodeL3DataTableNC_Code = new System.Data.DataColumn();
            this.reasionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTempControl = new System.Windows.Forms.BindingSource(this.components);
            this.dsTempControl = new AppSvrHMI.L3DataSet();
            this.schemadsTempControl = new System.Data.DataTable();
            this.coldsTempControlL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTempControlL3DataTableReasion = new System.Data.DataColumn();
            this.coldsTempControlL3DataTableFlagValue = new System.Data.DataColumn();
            this.coldsTempControlL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsTempControlL3DataTableOperator = new System.Data.DataColumn();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox8 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton33 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton34 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.panl = new System.Windows.Forms.Panel();
            this.tbxTreatNo = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxHeatID = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsStatusL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStatusL3DataTableName = new System.Data.DataColumn();
            this.coldsTempL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTempL3DataTableName = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableGUID = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableName = new System.Data.DataColumn();
            this.coldsNoteL3DataTableGUID = new System.Data.DataColumn();
            this.coldsNoteL3DataTableName = new System.Data.DataColumn();
            this.schemadsNote = new System.Data.DataTable();
            this.schemadsStatus = new System.Data.DataTable();
            this.l3DataSet9 = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet9 = new System.Data.DataTable();
            this.coll3DataSet9L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableTreatNo = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableType = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableRemark = new System.Data.DataColumn();
            this.coll3DataSet9L3DataTableLogTime = new System.Data.DataColumn();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.cmdHeatExcept = new AppSvrHMI.L3Command(this.components);
            this.l3cmdHeatID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpUnitType = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpUnitID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdprsData = new AppSvrHMI.L3CommandParameter();
            this.coldsWireL3DataTableBatch_ID = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsHeatGears = new AppSvrHMI.L3DataSet();
            this.schemadsHeatGears = new System.Data.DataTable();
            this.coldsHeatGearsL3DataTableGEARS = new System.Data.DataColumn();
            this.cmdExcept = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
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
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlProcess.SuspendLayout();
            this.pnlOxygen.SuspendLayout();
            this.pnlTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet2)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.tabLFAddMat.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchID_Mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchID_Mat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBatchID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMat)).BeginInit();
            this.bnMat.SuspendLayout();
            this.pnlMat.SuspendLayout();
            this.tabWire.SuspendLayout();
            this.hmiRootPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchID_Wire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchID_Wire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBatchID_Wire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire)).BeginInit();
            this.pnlWire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProbe_Vonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProbe_Vonder)).BeginInit();
            this.tabLadleInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleInfo)).BeginInit();
            this.pnlLadleInfo.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsLFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).BeginInit();
            this.bnStatus.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.tabTemp.SuspendLayout();
            this.hmiRootPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).BeginInit();
            this.bnTemp.SuspendLayout();
            this.tabOxygen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOxygen)).BeginInit();
            this.bnOxygen.SuspendLayout();
            this.tabRemark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).BeginInit();
            this.bnRemark.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.tabMidLandleTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsControlCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsControlCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTempControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTempControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.panl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatGears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatGears)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcessCancel
            // 
            this.btnProcessCancel.Location = new System.Drawing.Point(919, 3);
            this.btnProcessCancel.Name = "btnProcessCancel";
            this.btnProcessCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProcessCancel.TabIndex = 87;
            this.btnProcessCancel.Text = "取消";
            this.btnProcessCancel.UseVisualStyleBackColor = true;
            this.btnProcessCancel.Click += new System.EventHandler(this.btnProcessCancel_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(356, 132);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 12);
            this.label41.TabIndex = 166;
            this.label41.Text = "探头厂家:";
            // 
            // dtSoftBlowStartTime
            // 
            this.dtSoftBlowStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSoftBlowStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "SoftBlow_StartTime", true));
            this.dtSoftBlowStartTime.Enabled = false;
            this.dtSoftBlowStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSoftBlowStartTime.Location = new System.Drawing.Point(184, 97);
            this.dtSoftBlowStartTime.Name = "dtSoftBlowStartTime";
            this.dtSoftBlowStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtSoftBlowStartTime.TabIndex = 3;
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
            this.dsProcess.SourceURI = "XGMESLogic\\LFMag\\CLF_Process_Data";
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
            this.coldsProcessL3DataTableLogDate,
            this.coldsProcessL3DataTableMaterialType,
            this.coldsProcessL3DataTableMaterialID,
            this.coldsProcessL3DataTableAmount,
            this.coldsProcessL3DataTableTargetArea,
            this.coldsProcessL3DataTableOperator,
            this.coldsProcessL3DataTableShift,
            this.coldsProcessL3DataTableTeam,
            this.coldsProcessL3DataTableTreatNo,
            this.coldsProcessL3DataTableHeatID,
            this.coldsProcessL3DataTableArrival_Time,
            this.coldsProcessL3DataTableArrival_Temp,
            this.coldsProcessL3DataTableStart_Time,
            this.coldsProcessL3DataTableEnd_Time,
            this.coldsProcessL3DataTableProcess_Time,
            this.coldsProcessL3DataTableHeat_Time,
            this.coldsProcessL3DataTableHeat_Count,
            this.coldsProcessL3DataTableProbe_Vonder,
            this.coldsProcessL3DataTableFeedWire_Temp,
            this.coldsProcessL3DataTableDeparture_Temp,
            this.coldsProcessL3DataTableSoftBlow_StartTime,
            this.coldsProcessL3DataTableSoftBlow_EndTime,
            this.coldsProcessL3DataTableSoftBlow_Time,
            this.coldsProcessL3DataTableLid_Life,
            this.coldsProcessL3DataTableHoldBack_Time,
            this.coldsProcessL3DataTableSteel_Weight,
            this.coldsProcessL3DataTableLadleNo,
            this.coldsProcessL3DataTableSlag_Thickness,
            this.coldsProcessL3DataTableLadle_Grade});
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
            // coldsProcessL3DataTableLogDate
            // 
            this.coldsProcessL3DataTableLogDate.Caption = "LogDate";
            this.coldsProcessL3DataTableLogDate.ColumnName = "LogDate";
            this.coldsProcessL3DataTableLogDate.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableLogDate.Namespace = "";
            // 
            // coldsProcessL3DataTableMaterialType
            // 
            this.coldsProcessL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsProcessL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsProcessL3DataTableMaterialType.Namespace = "";
            // 
            // coldsProcessL3DataTableMaterialID
            // 
            this.coldsProcessL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsProcessL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsProcessL3DataTableMaterialID.Namespace = "";
            // 
            // coldsProcessL3DataTableAmount
            // 
            this.coldsProcessL3DataTableAmount.Caption = "Amount";
            this.coldsProcessL3DataTableAmount.ColumnName = "Amount";
            this.coldsProcessL3DataTableAmount.DataType = typeof(double);
            this.coldsProcessL3DataTableAmount.Namespace = "";
            // 
            // coldsProcessL3DataTableTargetArea
            // 
            this.coldsProcessL3DataTableTargetArea.Caption = "TargetArea";
            this.coldsProcessL3DataTableTargetArea.ColumnName = "TargetArea";
            this.coldsProcessL3DataTableTargetArea.Namespace = "";
            // 
            // coldsProcessL3DataTableOperator
            // 
            this.coldsProcessL3DataTableOperator.Caption = "Operator";
            this.coldsProcessL3DataTableOperator.ColumnName = "Operator";
            this.coldsProcessL3DataTableOperator.Namespace = "";
            // 
            // coldsProcessL3DataTableShift
            // 
            this.coldsProcessL3DataTableShift.Caption = "Shift";
            this.coldsProcessL3DataTableShift.ColumnName = "Shift";
            this.coldsProcessL3DataTableShift.Namespace = "";
            // 
            // coldsProcessL3DataTableTeam
            // 
            this.coldsProcessL3DataTableTeam.Caption = "Team";
            this.coldsProcessL3DataTableTeam.ColumnName = "Team";
            this.coldsProcessL3DataTableTeam.Namespace = "";
            // 
            // coldsProcessL3DataTableTreatNo
            // 
            this.coldsProcessL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsProcessL3DataTableTreatNo.Namespace = "";
            // 
            // coldsProcessL3DataTableHeatID
            // 
            this.coldsProcessL3DataTableHeatID.Caption = "HeatID";
            this.coldsProcessL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsProcessL3DataTableHeatID.Namespace = "";
            // 
            // coldsProcessL3DataTableArrival_Time
            // 
            this.coldsProcessL3DataTableArrival_Time.Caption = "Arrival_Time";
            this.coldsProcessL3DataTableArrival_Time.ColumnName = "Arrival_Time";
            this.coldsProcessL3DataTableArrival_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableArrival_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableArrival_Temp
            // 
            this.coldsProcessL3DataTableArrival_Temp.Caption = "Arrival_Temp";
            this.coldsProcessL3DataTableArrival_Temp.ColumnName = "Arrival_Temp";
            this.coldsProcessL3DataTableArrival_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableArrival_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableStart_Time
            // 
            this.coldsProcessL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsProcessL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsProcessL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableStart_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableEnd_Time
            // 
            this.coldsProcessL3DataTableEnd_Time.Caption = "End_Time";
            this.coldsProcessL3DataTableEnd_Time.ColumnName = "End_Time";
            this.coldsProcessL3DataTableEnd_Time.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableEnd_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableProcess_Time
            // 
            this.coldsProcessL3DataTableProcess_Time.Caption = "Process_Time";
            this.coldsProcessL3DataTableProcess_Time.ColumnName = "Process_Time";
            this.coldsProcessL3DataTableProcess_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableProcess_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableHeat_Time
            // 
            this.coldsProcessL3DataTableHeat_Time.Caption = "Heat_Time";
            this.coldsProcessL3DataTableHeat_Time.ColumnName = "Heat_Time";
            this.coldsProcessL3DataTableHeat_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableHeat_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableHeat_Count
            // 
            this.coldsProcessL3DataTableHeat_Count.Caption = "Heat_Count";
            this.coldsProcessL3DataTableHeat_Count.ColumnName = "Heat_Count";
            this.coldsProcessL3DataTableHeat_Count.DataType = typeof(int);
            this.coldsProcessL3DataTableHeat_Count.Namespace = "";
            // 
            // coldsProcessL3DataTableProbe_Vonder
            // 
            this.coldsProcessL3DataTableProbe_Vonder.Caption = "Probe_Vonder";
            this.coldsProcessL3DataTableProbe_Vonder.ColumnName = "Probe_Vonder";
            this.coldsProcessL3DataTableProbe_Vonder.Namespace = "";
            // 
            // coldsProcessL3DataTableFeedWire_Temp
            // 
            this.coldsProcessL3DataTableFeedWire_Temp.Caption = "FeedWire_Temp";
            this.coldsProcessL3DataTableFeedWire_Temp.ColumnName = "FeedWire_Temp";
            this.coldsProcessL3DataTableFeedWire_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableFeedWire_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableDeparture_Temp
            // 
            this.coldsProcessL3DataTableDeparture_Temp.Caption = "Departure_Temp";
            this.coldsProcessL3DataTableDeparture_Temp.ColumnName = "Departure_Temp";
            this.coldsProcessL3DataTableDeparture_Temp.DataType = typeof(int);
            this.coldsProcessL3DataTableDeparture_Temp.Namespace = "";
            // 
            // coldsProcessL3DataTableSoftBlow_StartTime
            // 
            this.coldsProcessL3DataTableSoftBlow_StartTime.Caption = "SoftBlow_StartTime";
            this.coldsProcessL3DataTableSoftBlow_StartTime.ColumnName = "SoftBlow_StartTime";
            this.coldsProcessL3DataTableSoftBlow_StartTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableSoftBlow_StartTime.Namespace = "";
            // 
            // coldsProcessL3DataTableSoftBlow_EndTime
            // 
            this.coldsProcessL3DataTableSoftBlow_EndTime.Caption = "SoftBlow_EndTime";
            this.coldsProcessL3DataTableSoftBlow_EndTime.ColumnName = "SoftBlow_EndTime";
            this.coldsProcessL3DataTableSoftBlow_EndTime.DataType = typeof(System.DateTime);
            this.coldsProcessL3DataTableSoftBlow_EndTime.Namespace = "";
            // 
            // coldsProcessL3DataTableSoftBlow_Time
            // 
            this.coldsProcessL3DataTableSoftBlow_Time.Caption = "SoftBlow_Time";
            this.coldsProcessL3DataTableSoftBlow_Time.ColumnName = "SoftBlow_Time";
            this.coldsProcessL3DataTableSoftBlow_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableSoftBlow_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableLid_Life
            // 
            this.coldsProcessL3DataTableLid_Life.Caption = "Lid_Life";
            this.coldsProcessL3DataTableLid_Life.ColumnName = "Lid_Life";
            this.coldsProcessL3DataTableLid_Life.DataType = typeof(int);
            this.coldsProcessL3DataTableLid_Life.Namespace = "";
            // 
            // coldsProcessL3DataTableHoldBack_Time
            // 
            this.coldsProcessL3DataTableHoldBack_Time.Caption = "HoldBack_Time";
            this.coldsProcessL3DataTableHoldBack_Time.ColumnName = "HoldBack_Time";
            this.coldsProcessL3DataTableHoldBack_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableHoldBack_Time.Namespace = "";
            // 
            // coldsProcessL3DataTableSteel_Weight
            // 
            this.coldsProcessL3DataTableSteel_Weight.Caption = "Steel_Weight";
            this.coldsProcessL3DataTableSteel_Weight.ColumnName = "Steel_Weight";
            this.coldsProcessL3DataTableSteel_Weight.DataType = typeof(float);
            this.coldsProcessL3DataTableSteel_Weight.Namespace = "";
            // 
            // coldsProcessL3DataTableLadleNo
            // 
            this.coldsProcessL3DataTableLadleNo.Caption = "LadleNo";
            this.coldsProcessL3DataTableLadleNo.ColumnName = "LadleNo";
            this.coldsProcessL3DataTableLadleNo.Namespace = "";
            // 
            // coldsProcessL3DataTableSlag_Thickness
            // 
            this.coldsProcessL3DataTableSlag_Thickness.Caption = "Slag_Thickness";
            this.coldsProcessL3DataTableSlag_Thickness.ColumnName = "Slag_Thickness";
            this.coldsProcessL3DataTableSlag_Thickness.Namespace = "";
            // 
            // coldsProcessL3DataTableLadle_Grade
            // 
            this.coldsProcessL3DataTableLadle_Grade.Caption = "Ladle_Grade";
            this.coldsProcessL3DataTableLadle_Grade.ColumnName = "Ladle_Grade";
            this.coldsProcessL3DataTableLadle_Grade.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnPaocessOK
            // 
            this.Adapter.SetAccessRight(this.btnPaocessOK, "LFCheck");
            this.btnPaocessOK.Location = new System.Drawing.Point(838, 3);
            this.btnPaocessOK.Name = "btnPaocessOK";
            this.btnPaocessOK.Size = new System.Drawing.Size(75, 23);
            this.btnPaocessOK.TabIndex = 86;
            this.btnPaocessOK.Text = "确认";
            this.btnPaocessOK.UseVisualStyleBackColor = true;
            this.btnPaocessOK.Click += new System.EventHandler(this.btnPaocessOK_Click);
            // 
            // btnBaseOK
            // 
            this.Adapter.SetAccessRight(this.btnBaseOK, "LFCheck");
            this.btnBaseOK.Location = new System.Drawing.Point(838, 3);
            this.btnBaseOK.Name = "btnBaseOK";
            this.btnBaseOK.Size = new System.Drawing.Size(75, 23);
            this.btnBaseOK.TabIndex = 86;
            this.btnBaseOK.Text = "确认";
            this.btnBaseOK.UseVisualStyleBackColor = true;
            this.btnBaseOK.Click += new System.EventHandler(this.btnBaseOK_Click);
            // 
            // btnConfirmExcept
            // 
            this.Adapter.SetAccessRight(this.btnConfirmExcept, "LFCheck");
            this.btnConfirmExcept.Location = new System.Drawing.Point(846, 3);
            this.btnConfirmExcept.Name = "btnConfirmExcept";
            this.btnConfirmExcept.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmExcept.TabIndex = 86;
            this.btnConfirmExcept.Text = "确认";
            this.btnConfirmExcept.UseVisualStyleBackColor = true;
            this.btnConfirmExcept.Click += new System.EventHandler(this.btnConfirmExcept_Click);
            // 
            // btnAddExcept
            // 
            this.Adapter.SetAccessRight(this.btnAddExcept, "LFCheck");
            this.btnAddExcept.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddExcept.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExcept.Image")));
            this.btnAddExcept.Name = "btnAddExcept";
            this.btnAddExcept.RightToLeftAutoMirrorImage = true;
            this.btnAddExcept.Size = new System.Drawing.Size(23, 22);
            this.btnAddExcept.Text = "新添";
            this.btnAddExcept.Click += new System.EventHandler(this.btnAddExcept_Click);
            // 
            // btnAddRemark
            // 
            this.Adapter.SetAccessRight(this.btnAddRemark, "LFCheck");
            this.btnAddRemark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRemark.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRemark.Image")));
            this.btnAddRemark.Name = "btnAddRemark";
            this.btnAddRemark.RightToLeftAutoMirrorImage = true;
            this.btnAddRemark.Size = new System.Drawing.Size(23, 22);
            this.btnAddRemark.Text = "新添";
            this.btnAddRemark.Click += new System.EventHandler(this.btnNoteAdd_Click);
            // 
            // btnNoteConfirm
            // 
            this.Adapter.SetAccessRight(this.btnNoteConfirm, "LFCheck");
            this.btnNoteConfirm.Location = new System.Drawing.Point(838, 3);
            this.btnNoteConfirm.Name = "btnNoteConfirm";
            this.btnNoteConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnNoteConfirm.TabIndex = 86;
            this.btnNoteConfirm.Text = "确认";
            this.btnNoteConfirm.UseVisualStyleBackColor = true;
            this.btnNoteConfirm.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnAddMat
            // 
            this.Adapter.SetAccessRight(this.btnAddMat, "LFCheck");
            this.btnAddMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddMat.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMat.Image")));
            this.btnAddMat.Name = "btnAddMat";
            this.btnAddMat.RightToLeftAutoMirrorImage = true;
            this.btnAddMat.Size = new System.Drawing.Size(23, 22);
            this.btnAddMat.Text = "新添";
            this.btnAddMat.Click += new System.EventHandler(this.btnAddMat_Click);
            // 
            // btnMatOK
            // 
            this.Adapter.SetAccessRight(this.btnMatOK, "LFCheck");
            this.btnMatOK.Location = new System.Drawing.Point(840, 3);
            this.btnMatOK.Name = "btnMatOK";
            this.btnMatOK.Size = new System.Drawing.Size(75, 23);
            this.btnMatOK.TabIndex = 86;
            this.btnMatOK.Text = "确认";
            this.btnMatOK.UseVisualStyleBackColor = true;
            this.btnMatOK.Click += new System.EventHandler(this.btnMatOK_Click);
            // 
            // btnWireConfirm
            // 
            this.Adapter.SetAccessRight(this.btnWireConfirm, "LFCheck");
            this.btnWireConfirm.Location = new System.Drawing.Point(840, 3);
            this.btnWireConfirm.Name = "btnWireConfirm";
            this.btnWireConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnWireConfirm.TabIndex = 86;
            this.btnWireConfirm.Text = "确认";
            this.btnWireConfirm.UseVisualStyleBackColor = true;
            this.btnWireConfirm.Click += new System.EventHandler(this.btnWireConfirm_Click);
            // 
            // btnWireAdd
            // 
            this.Adapter.SetAccessRight(this.btnWireAdd, "LFCheck");
            this.btnWireAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWireAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnWireAdd.Image")));
            this.btnWireAdd.Name = "btnWireAdd";
            this.btnWireAdd.RightToLeftAutoMirrorImage = true;
            this.btnWireAdd.Size = new System.Drawing.Size(23, 22);
            this.btnWireAdd.Text = "新添";
            this.btnWireAdd.Click += new System.EventHandler(this.btnWireAdd_Click);
            // 
            // btnLadleInfoOK
            // 
            this.Adapter.SetAccessRight(this.btnLadleInfoOK, "LFCheck");
            this.btnLadleInfoOK.Location = new System.Drawing.Point(844, 3);
            this.btnLadleInfoOK.Name = "btnLadleInfoOK";
            this.btnLadleInfoOK.Size = new System.Drawing.Size(75, 23);
            this.btnLadleInfoOK.TabIndex = 86;
            this.btnLadleInfoOK.Text = "确认";
            this.btnLadleInfoOK.UseVisualStyleBackColor = true;
            this.btnLadleInfoOK.Click += new System.EventHandler(this.btnLadleInfoOK_Click);
            // 
            // button2
            // 
            this.Adapter.SetAccessRight(this.button2, "LFCheck");
            this.button2.Location = new System.Drawing.Point(840, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 86;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "End_Time", true));
            this.dtEndTime.Enabled = false;
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.Location = new System.Drawing.Point(184, 70);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(144, 21);
            this.dtEndTime.TabIndex = 2;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Start_Time", true));
            this.dtStartTime.Enabled = false;
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(184, 43);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtStartTime.TabIndex = 1;
            // 
            // dtArrivalTime
            // 
            this.dtArrivalTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtArrivalTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Arrival_Time", true));
            this.dtArrivalTime.Enabled = false;
            this.dtArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalTime.Location = new System.Drawing.Point(184, 19);
            this.dtArrivalTime.Name = "dtArrivalTime";
            this.dtArrivalTime.Size = new System.Drawing.Size(144, 21);
            this.dtArrivalTime.TabIndex = 0;
            // 
            // txtHoldBackTime
            // 
            this.txtHoldBackTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "HoldBack_Time", true));
            this.txtHoldBackTime.DisplayPrecision = 0;
            this.txtHoldBackTime.EnableNull = false;
            this.txtHoldBackTime.ErropPr = this.errorProvider1;
            this.txtHoldBackTime.FixedLength = 0;
            this.txtHoldBackTime.Length = 0;
            this.txtHoldBackTime.Location = new System.Drawing.Point(726, 77);
            this.txtHoldBackTime.Max = 9999D;
            this.txtHoldBackTime.MaxNull = 9999D;
            this.txtHoldBackTime.MaxStringLength = 0;
            this.txtHoldBackTime.MaxStrLength = 0;
            this.txtHoldBackTime.Min = 0D;
            this.txtHoldBackTime.MinNull = 0D;
            this.txtHoldBackTime.MinStringLength = 0;
            this.txtHoldBackTime.MinStrLength = 0;
            this.txtHoldBackTime.Name = "txtHoldBackTime";
            this.txtHoldBackTime.Precision = 0;
            this.txtHoldBackTime.Regex = "";
            this.txtHoldBackTime.Size = new System.Drawing.Size(10, 21);
            this.txtHoldBackTime.TabIndex = 14;
            this.txtHoldBackTime.ToolTipValid = this.toolTip1;
            this.txtHoldBackTime.VaildWarning = "";
            this.txtHoldBackTime.ValidEable = false;
            this.txtHoldBackTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtHoldBackTime.TextChanged += new System.EventHandler(this.txtHoldBackTime_TextChanged);
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
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(520, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 12);
            this.label23.TabIndex = 152;
            this.label23.Text = "等压钢时间:";
            // 
            // txtLidLife
            // 
            this.txtLidLife.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Lid_Life", true));
            this.txtLidLife.DisplayPrecision = 0;
            this.txtLidLife.EnableNull = false;
            this.txtLidLife.ErropPr = this.errorProvider1;
            this.txtLidLife.FixedLength = 0;
            this.txtLidLife.Length = 0;
            this.txtLidLife.Location = new System.Drawing.Point(597, 74);
            this.txtLidLife.Max = 99999D;
            this.txtLidLife.MaxNull = 99999D;
            this.txtLidLife.MaxStringLength = 0;
            this.txtLidLife.MaxStrLength = 0;
            this.txtLidLife.Min = 0D;
            this.txtLidLife.MinNull = 0D;
            this.txtLidLife.MinStringLength = 0;
            this.txtLidLife.MinStrLength = 0;
            this.txtLidLife.Name = "txtLidLife";
            this.txtLidLife.Precision = 0;
            this.txtLidLife.ReadOnly = true;
            this.txtLidLife.Regex = "";
            this.txtLidLife.Size = new System.Drawing.Size(85, 21);
            this.txtLidLife.TabIndex = 13;
            this.txtLidLife.ToolTipValid = this.toolTip1;
            this.txtLidLife.VaildWarning = "";
            this.txtLidLife.ValidEable = true;
            this.txtLidLife.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(532, 77);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 12);
            this.label24.TabIndex = 150;
            this.label24.Text = "炉盖寿命:";
            // 
            // txtSoftBlowTime
            // 
            this.txtSoftBlowTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "SoftBlow_Time", true));
            this.txtSoftBlowTime.DisplayPrecision = 0;
            this.txtSoftBlowTime.EnableNull = false;
            this.txtSoftBlowTime.ErropPr = this.errorProvider1;
            this.txtSoftBlowTime.FixedLength = 0;
            this.txtSoftBlowTime.Length = 0;
            this.txtSoftBlowTime.Location = new System.Drawing.Point(742, 77);
            this.txtSoftBlowTime.Max = 9999D;
            this.txtSoftBlowTime.MaxNull = 9999D;
            this.txtSoftBlowTime.MaxStringLength = 0;
            this.txtSoftBlowTime.MaxStrLength = 0;
            this.txtSoftBlowTime.Min = 0D;
            this.txtSoftBlowTime.MinNull = 0D;
            this.txtSoftBlowTime.MinStringLength = 0;
            this.txtSoftBlowTime.MinStrLength = 0;
            this.txtSoftBlowTime.Name = "txtSoftBlowTime";
            this.txtSoftBlowTime.Precision = 0;
            this.txtSoftBlowTime.Regex = "";
            this.txtSoftBlowTime.Size = new System.Drawing.Size(10, 21);
            this.txtSoftBlowTime.TabIndex = 12;
            this.txtSoftBlowTime.ToolTipValid = this.toolTip1;
            this.txtSoftBlowTime.VaildWarning = "";
            this.txtSoftBlowTime.ValidEable = false;
            this.txtSoftBlowTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtSoftBlowTime.TextChanged += new System.EventHandler(this.txtSoftBlowTime_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(532, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 12);
            this.label25.TabIndex = 148;
            this.label25.Text = "软吹时间:";
            // 
            // txtDepartureTemp
            // 
            this.txtDepartureTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Departure_Temp", true));
            this.txtDepartureTemp.DisplayPrecision = 0;
            this.txtDepartureTemp.EnableNull = false;
            this.txtDepartureTemp.ErropPr = this.errorProvider1;
            this.txtDepartureTemp.FixedLength = 0;
            this.txtDepartureTemp.Length = 0;
            this.txtDepartureTemp.Location = new System.Drawing.Point(597, 20);
            this.txtDepartureTemp.Max = 2000D;
            this.txtDepartureTemp.MaxNull = 2000D;
            this.txtDepartureTemp.MaxStringLength = 0;
            this.txtDepartureTemp.MaxStrLength = 0;
            this.txtDepartureTemp.Min = 0D;
            this.txtDepartureTemp.MinNull = 0D;
            this.txtDepartureTemp.MinStringLength = 0;
            this.txtDepartureTemp.MinStrLength = 0;
            this.txtDepartureTemp.Name = "txtDepartureTemp";
            this.txtDepartureTemp.Precision = 0;
            this.txtDepartureTemp.ReadOnly = true;
            this.txtDepartureTemp.Regex = "";
            this.txtDepartureTemp.Size = new System.Drawing.Size(85, 21);
            this.txtDepartureTemp.TabIndex = 11;
            this.txtDepartureTemp.ToolTipValid = this.toolTip1;
            this.txtDepartureTemp.VaildWarning = "";
            this.txtDepartureTemp.ValidEable = true;
            this.txtDepartureTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(508, 23);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 12);
            this.label26.TabIndex = 146;
            this.label26.Text = "离站温度[℃]:";
            // 
            // txtHeatCount
            // 
            this.txtHeatCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Heat_Count", true));
            this.txtHeatCount.DisplayPrecision = 0;
            this.txtHeatCount.EnableNull = false;
            this.txtHeatCount.ErropPr = this.errorProvider1;
            this.txtHeatCount.FixedLength = 0;
            this.txtHeatCount.Length = 0;
            this.txtHeatCount.Location = new System.Drawing.Point(421, 98);
            this.txtHeatCount.Max = 99D;
            this.txtHeatCount.MaxNull = 99D;
            this.txtHeatCount.MaxStringLength = 0;
            this.txtHeatCount.MaxStrLength = 0;
            this.txtHeatCount.Min = 0D;
            this.txtHeatCount.MinNull = 0D;
            this.txtHeatCount.MinStringLength = 0;
            this.txtHeatCount.MinStrLength = 0;
            this.txtHeatCount.Name = "txtHeatCount";
            this.txtHeatCount.Precision = 0;
            this.txtHeatCount.ReadOnly = true;
            this.txtHeatCount.Regex = "";
            this.txtHeatCount.Size = new System.Drawing.Size(85, 21);
            this.txtHeatCount.TabIndex = 8;
            this.txtHeatCount.ToolTipValid = this.toolTip1;
            this.txtHeatCount.VaildWarning = "";
            this.txtHeatCount.ValidEable = true;
            this.txtHeatCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(356, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 144;
            this.label27.Text = "加热次数:";
            // 
            // txtHeatTime
            // 
            this.txtHeatTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Heat_Time", true));
            this.txtHeatTime.DisplayPrecision = 0;
            this.txtHeatTime.EnableNull = false;
            this.txtHeatTime.ErropPr = this.errorProvider1;
            this.txtHeatTime.FixedLength = 0;
            this.txtHeatTime.Length = 0;
            this.txtHeatTime.Location = new System.Drawing.Point(710, 77);
            this.txtHeatTime.Max = 9999D;
            this.txtHeatTime.MaxNull = 9999D;
            this.txtHeatTime.MaxStringLength = 0;
            this.txtHeatTime.MaxStrLength = 0;
            this.txtHeatTime.Min = 0D;
            this.txtHeatTime.MinNull = 0D;
            this.txtHeatTime.MinStringLength = 0;
            this.txtHeatTime.MinStrLength = 0;
            this.txtHeatTime.Name = "txtHeatTime";
            this.txtHeatTime.Precision = 0;
            this.txtHeatTime.Regex = "";
            this.txtHeatTime.Size = new System.Drawing.Size(10, 21);
            this.txtHeatTime.TabIndex = 7;
            this.txtHeatTime.ToolTipValid = this.toolTip1;
            this.txtHeatTime.VaildWarning = "";
            this.txtHeatTime.ValidEable = false;
            this.txtHeatTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtHeatTime.TextChanged += new System.EventHandler(this.txtHeatTime_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(356, 77);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 12);
            this.label28.TabIndex = 142;
            this.label28.Text = "加热时间:";
            // 
            // txtProcessTime
            // 
            this.txtProcessTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Process_Time", true));
            this.txtProcessTime.DisplayPrecision = 0;
            this.txtProcessTime.EnableNull = false;
            this.txtProcessTime.ErropPr = this.errorProvider1;
            this.txtProcessTime.FixedLength = 0;
            this.txtProcessTime.Length = 0;
            this.txtProcessTime.Location = new System.Drawing.Point(694, 77);
            this.txtProcessTime.Max = 9999D;
            this.txtProcessTime.MaxNull = 9999D;
            this.txtProcessTime.MaxStringLength = 0;
            this.txtProcessTime.MaxStrLength = 0;
            this.txtProcessTime.Min = 0D;
            this.txtProcessTime.MinNull = 0D;
            this.txtProcessTime.MinStringLength = 0;
            this.txtProcessTime.MinStrLength = 0;
            this.txtProcessTime.Name = "txtProcessTime";
            this.txtProcessTime.Precision = 0;
            this.txtProcessTime.Regex = "";
            this.txtProcessTime.Size = new System.Drawing.Size(10, 21);
            this.txtProcessTime.TabIndex = 6;
            this.txtProcessTime.ToolTipValid = this.toolTip1;
            this.txtProcessTime.VaildWarning = "";
            this.txtProcessTime.ValidEable = false;
            this.txtProcessTime.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtProcessTime.TextChanged += new System.EventHandler(this.txtProcessTime_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(356, 50);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 140;
            this.label29.Text = "处理时间:";
            // 
            // txtArrivalTemp
            // 
            this.txtArrivalTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Arrival_Temp", true));
            this.txtArrivalTemp.DisplayPrecision = 0;
            this.txtArrivalTemp.EnableNull = false;
            this.txtArrivalTemp.ErropPr = this.errorProvider1;
            this.txtArrivalTemp.FixedLength = 0;
            this.txtArrivalTemp.Length = 0;
            this.txtArrivalTemp.Location = new System.Drawing.Point(421, 20);
            this.txtArrivalTemp.Max = 2000D;
            this.txtArrivalTemp.MaxNull = 2000D;
            this.txtArrivalTemp.MaxStringLength = 0;
            this.txtArrivalTemp.MaxStrLength = 0;
            this.txtArrivalTemp.Min = 0D;
            this.txtArrivalTemp.MinNull = 0D;
            this.txtArrivalTemp.MinStringLength = 0;
            this.txtArrivalTemp.MinStrLength = 0;
            this.txtArrivalTemp.Name = "txtArrivalTemp";
            this.txtArrivalTemp.Precision = 0;
            this.txtArrivalTemp.ReadOnly = true;
            this.txtArrivalTemp.Regex = "";
            this.txtArrivalTemp.Size = new System.Drawing.Size(85, 21);
            this.txtArrivalTemp.TabIndex = 5;
            this.txtArrivalTemp.ToolTipValid = this.toolTip1;
            this.txtArrivalTemp.VaildWarning = "";
            this.txtArrivalTemp.ValidEable = true;
            this.txtArrivalTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(334, 23);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 12);
            this.label30.TabIndex = 138;
            this.label30.Text = "进站温度[℃]:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(95, 101);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(83, 12);
            this.label31.TabIndex = 136;
            this.label31.Text = "软吹开始时刻:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(95, 74);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 12);
            this.label32.TabIndex = 134;
            this.label32.Text = "处理结束时刻:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(95, 47);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(83, 12);
            this.label33.TabIndex = 132;
            this.label33.Text = "处理开始时刻:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(119, 20);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 130;
            this.label34.Text = "到达时刻:";
            // 
            // pnlProcess
            // 
            this.pnlProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProcess.Controls.Add(this.btnProcessCancel);
            this.pnlProcess.Controls.Add(this.btnPaocessOK);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProcess.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlProcess.Location = new System.Drawing.Point(3, 337);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(1001, 33);
            this.pnlProcess.TabIndex = 89;
            // 
            // btnTempCancel
            // 
            this.btnTempCancel.Location = new System.Drawing.Point(919, 3);
            this.btnTempCancel.Name = "btnTempCancel";
            this.btnTempCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTempCancel.TabIndex = 87;
            this.btnTempCancel.Text = "取消";
            this.btnTempCancel.UseVisualStyleBackColor = true;
            this.btnTempCancel.Click += new System.EventHandler(this.btnTempCancel_Click);
            // 
            // btnTempOK
            // 
            this.btnTempOK.Location = new System.Drawing.Point(838, 3);
            this.btnTempOK.Name = "btnTempOK";
            this.btnTempOK.Size = new System.Drawing.Size(75, 23);
            this.btnTempOK.TabIndex = 86;
            this.btnTempOK.Text = "确认";
            this.btnTempOK.UseVisualStyleBackColor = true;
            this.btnTempOK.Click += new System.EventHandler(this.btnTempOK_Click);
            // 
            // btnOxygenCancel
            // 
            this.btnOxygenCancel.Location = new System.Drawing.Point(919, 3);
            this.btnOxygenCancel.Name = "btnOxygenCancel";
            this.btnOxygenCancel.Size = new System.Drawing.Size(75, 23);
            this.btnOxygenCancel.TabIndex = 87;
            this.btnOxygenCancel.Text = "取消";
            this.btnOxygenCancel.UseVisualStyleBackColor = true;
            this.btnOxygenCancel.Click += new System.EventHandler(this.btnOxygenCancel_Click);
            // 
            // pnlOxygen
            // 
            this.pnlOxygen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOxygen.Controls.Add(this.btnOxygenCancel);
            this.pnlOxygen.Controls.Add(this.btnOxygenOK);
            this.pnlOxygen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOxygen.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlOxygen.Location = new System.Drawing.Point(3, 337);
            this.pnlOxygen.Name = "pnlOxygen";
            this.pnlOxygen.Size = new System.Drawing.Size(1001, 33);
            this.pnlOxygen.TabIndex = 92;
            // 
            // btnOxygenOK
            // 
            this.btnOxygenOK.Location = new System.Drawing.Point(838, 3);
            this.btnOxygenOK.Name = "btnOxygenOK";
            this.btnOxygenOK.Size = new System.Drawing.Size(75, 23);
            this.btnOxygenOK.TabIndex = 86;
            this.btnOxygenOK.Text = "确认";
            this.btnOxygenOK.UseVisualStyleBackColor = true;
            this.btnOxygenOK.Click += new System.EventHandler(this.btnOxygenOK_Click);
            // 
            // pnlTemp
            // 
            this.pnlTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTemp.Controls.Add(this.btnTempCancel);
            this.pnlTemp.Controls.Add(this.btnTempOK);
            this.pnlTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTemp.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlTemp.Location = new System.Drawing.Point(0, 334);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(1001, 33);
            this.pnlTemp.TabIndex = 92;
            // 
            // bsOxygen
            // 
            this.bsOxygen.DataMember = "L3DataTable";
            this.bsOxygen.DataSource = this.dsOxygen;
            // 
            // dsOxygen
            // 
            this.dsOxygen.AutoLoad = true;
            this.dsOxygen.AutoSubscribe = false;
            this.dsOxygen.DataSetName = "L3DataSet";
            this.dsOxygen.DeleteMethod = null;
            this.dsOxygen.InsertMethod = null;
            this.dsOxygen.L3DataAdapter = null;
            this.dsOxygen.LoadEvent = "Click";
            this.dsOxygen.LoadTrigger = null;
            this.dsOxygen.RefreshValve = 1000;
            this.dsOxygen.SourceCommand = null;
            this.dsOxygen.SourceCondition = "1=2";
            this.dsOxygen.SourceMethod = "";
            this.dsOxygen.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOxygen.SourceURI = "XGMESLogic\\LFMag\\CLF_Oxygen_Data";
            this.dsOxygen.SubscribeTarget = null;
            this.dsOxygen.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet2});
            this.dsOxygen.UpdateEvent = "Click";
            this.dsOxygen.UpdateMethod = null;
            this.dsOxygen.UpdateTrigger = null;
            // 
            // schemal3DataSet2
            // 
            this.schemal3DataSet2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet2L3DataTableGUID,
            this.coll3DataSet2L3DataTableName,
            this.coll3DataSet2L3DataTableTreatNo,
            this.coll3DataSet2L3DataTableHeatID,
            this.coll3DataSet2L3DataTableOxygen_Content,
            this.coll3DataSet2L3DataTableMeasure_Time});
            this.schemal3DataSet2.TableName = "L3DataTable";
            // 
            // coll3DataSet2L3DataTableGUID
            // 
            this.coll3DataSet2L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet2L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet2L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet2L3DataTableName
            // 
            this.coll3DataSet2L3DataTableName.Caption = "Name";
            this.coll3DataSet2L3DataTableName.ColumnName = "Name";
            this.coll3DataSet2L3DataTableName.Namespace = "";
            // 
            // coll3DataSet2L3DataTableTreatNo
            // 
            this.coll3DataSet2L3DataTableTreatNo.Caption = "TreatNo";
            this.coll3DataSet2L3DataTableTreatNo.ColumnName = "TreatNo";
            this.coll3DataSet2L3DataTableTreatNo.Namespace = "";
            // 
            // coll3DataSet2L3DataTableHeatID
            // 
            this.coll3DataSet2L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet2L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet2L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet2L3DataTableOxygen_Content
            // 
            this.coll3DataSet2L3DataTableOxygen_Content.Caption = "Oxygen_Content";
            this.coll3DataSet2L3DataTableOxygen_Content.ColumnName = "Oxygen_Content";
            this.coll3DataSet2L3DataTableOxygen_Content.DataType = typeof(float);
            this.coll3DataSet2L3DataTableOxygen_Content.Namespace = "";
            // 
            // coll3DataSet2L3DataTableMeasure_Time
            // 
            this.coll3DataSet2L3DataTableMeasure_Time.Caption = "Measure_Time";
            this.coll3DataSet2L3DataTableMeasure_Time.ColumnName = "Measure_Time";
            this.coll3DataSet2L3DataTableMeasure_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet2L3DataTableMeasure_Time.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.tabCtrlMain);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 29);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1017, 401);
            this.hmiRootPanel1.TabIndex = 88;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabBase);
            this.tabCtrlMain.Controls.Add(this.tabLFAddMat);
            this.tabCtrlMain.Controls.Add(this.tabWire);
            this.tabCtrlMain.Controls.Add(this.tabProcess);
            this.tabCtrlMain.Controls.Add(this.tabLadleInfo);
            this.tabCtrlMain.Controls.Add(this.tabExcept);
            this.tabCtrlMain.Controls.Add(this.tabChemical);
            this.tabCtrlMain.Controls.Add(this.tabStatus);
            this.tabCtrlMain.Controls.Add(this.tabTemp);
            this.tabCtrlMain.Controls.Add(this.tabOxygen);
            this.tabCtrlMain.Controls.Add(this.tabRemark);
            this.tabCtrlMain.Controls.Add(this.tabMidLandleTemp);
            this.tabCtrlMain.Controls.Add(this.tabPage1);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(1017, 401);
            this.tabCtrlMain.TabIndex = 91;
            this.tabCtrlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCtrlMain_Selected);
            // 
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.cmbShift);
            this.tabBase.Controls.Add(this.cmbTeam);
            this.tabBase.Controls.Add(this.dateTimePicker6);
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
            this.tabBase.Controls.Add(this.pnlBase);
            this.tabBase.Location = new System.Drawing.Point(4, 22);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(1009, 375);
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
            this.cmbShift.DataSource = this.dsShiftID;
            this.cmbShift.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShift.EnableNull = true;
            this.cmbShift.ErropPr = null;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(257, 89);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.ReadOnly = false;
            this.cmbShift.Size = new System.Drawing.Size(100, 20);
            this.cmbShift.TabIndex = 105;
            this.cmbShift.TMpEnabled = true;
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
            this.dsBase.SourceURI = "XGMESLogic\\LFMag\\CLF_Base_Data";
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
            this.coldsBaseL3DataTableTreatNo,
            this.coldsBaseL3DataTableHeatID,
            this.coldsBaseL3DataTablePreHeatID,
            this.coldsBaseL3DataTableSteelGradeIndex,
            this.coldsBaseL3DataTableSteelGrade,
            this.coldsBaseL3DataTableLadleNo,
            this.coldsBaseL3DataTableHeadFurnace,
            this.coldsBaseL3DataTableAssistant,
            this.coldsBaseL3DataTableSecondHand,
            this.coldsBaseL3DataTableProductionDate,
            this.coldsBaseL3DataTableLocked,
            this.coldsBaseL3DataTableShift,
            this.coldsBaseL3DataTableTeam});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableTreatNo
            // 
            this.coldsBaseL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsBaseL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsBaseL3DataTableTreatNo.Namespace = "";
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
            // coldsBaseL3DataTableLadleNo
            // 
            this.coldsBaseL3DataTableLadleNo.Caption = "LadleNo";
            this.coldsBaseL3DataTableLadleNo.ColumnName = "LadleNo";
            this.coldsBaseL3DataTableLadleNo.Namespace = "";
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
            this.cmbTeam.Location = new System.Drawing.Point(257, 115);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.ReadOnly = false;
            this.cmbTeam.Size = new System.Drawing.Size(100, 20);
            this.cmbTeam.TabIndex = 105;
            this.cmbTeam.TMpEnabled = true;
            this.cmbTeam.ToolTipValid = null;
            this.cmbTeam.ValidEable = true;
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
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "ProductionDate", true));
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(447, 115);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(145, 21);
            this.dateTimePicker6.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 104;
            this.label10.Text = "生产日期:";
            // 
            // tbxSecondHand
            // 
            this.tbxSecondHand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SecondHand", true));
            this.tbxSecondHand.DisplayPrecision = 0;
            this.tbxSecondHand.EnableNull = true;
            this.tbxSecondHand.ErropPr = null;
            this.tbxSecondHand.FixedLength = 0;
            this.tbxSecondHand.Length = 0;
            this.tbxSecondHand.Location = new System.Drawing.Point(447, 89);
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
            this.tbxSecondHand.TabIndex = 6;
            this.tbxSecondHand.ToolTipValid = null;
            this.tbxSecondHand.VaildWarning = "";
            this.tbxSecondHand.ValidEable = true;
            this.tbxSecondHand.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 102;
            this.label9.Text = "二助手:";
            // 
            // tbxAssistant
            // 
            this.tbxAssistant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "Assistant", true));
            this.tbxAssistant.DisplayPrecision = 0;
            this.tbxAssistant.EnableNull = true;
            this.tbxAssistant.ErropPr = null;
            this.tbxAssistant.FixedLength = 0;
            this.tbxAssistant.Length = 0;
            this.tbxAssistant.Location = new System.Drawing.Point(447, 63);
            this.tbxAssistant.Max = 0D;
            this.tbxAssistant.MaxNull = 0D;
            this.tbxAssistant.MaxStringLength = 0;
            this.tbxAssistant.MaxStrLength = 0;
            this.tbxAssistant.Min = 0D;
            this.tbxAssistant.MinNull = 0D;
            this.tbxAssistant.MinStringLength = 0;
            this.tbxAssistant.MinStrLength = 0;
            this.tbxAssistant.Name = "tbxAssistant";
            this.tbxAssistant.Precision = 0;
            this.tbxAssistant.Regex = "";
            this.tbxAssistant.Size = new System.Drawing.Size(145, 21);
            this.tbxAssistant.TabIndex = 5;
            this.tbxAssistant.ToolTipValid = null;
            this.tbxAssistant.VaildWarning = "";
            this.tbxAssistant.ValidEable = true;
            this.tbxAssistant.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 100;
            this.label7.Text = "一助手:";
            // 
            // tbxHeadFurnace
            // 
            this.tbxHeadFurnace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "HeadFurnace", true));
            this.tbxHeadFurnace.DisplayPrecision = 0;
            this.tbxHeadFurnace.EnableNull = true;
            this.tbxHeadFurnace.ErropPr = null;
            this.tbxHeadFurnace.FixedLength = 0;
            this.tbxHeadFurnace.Length = 0;
            this.tbxHeadFurnace.Location = new System.Drawing.Point(447, 37);
            this.tbxHeadFurnace.Max = 0D;
            this.tbxHeadFurnace.MaxNull = 0D;
            this.tbxHeadFurnace.MaxStringLength = 0;
            this.tbxHeadFurnace.MaxStrLength = 0;
            this.tbxHeadFurnace.Min = 0D;
            this.tbxHeadFurnace.MinNull = 0D;
            this.tbxHeadFurnace.MinStringLength = 0;
            this.tbxHeadFurnace.MinStrLength = 0;
            this.tbxHeadFurnace.Name = "tbxHeadFurnace";
            this.tbxHeadFurnace.Precision = 0;
            this.tbxHeadFurnace.Regex = "";
            this.tbxHeadFurnace.Size = new System.Drawing.Size(145, 21);
            this.tbxHeadFurnace.TabIndex = 4;
            this.tbxHeadFurnace.ToolTipValid = null;
            this.tbxHeadFurnace.VaildWarning = "";
            this.tbxHeadFurnace.ValidEable = true;
            this.tbxHeadFurnace.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 98;
            this.label5.Text = "炉长:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "班别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 94;
            this.label3.Text = "班次:";
            // 
            // tbxSteelGradeIndex
            // 
            this.tbxSteelGradeIndex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "SteelGradeIndex", true));
            this.tbxSteelGradeIndex.DisplayPrecision = 0;
            this.tbxSteelGradeIndex.EnableNull = false;
            this.tbxSteelGradeIndex.ErropPr = this.errorProvider1;
            this.tbxSteelGradeIndex.FixedLength = 0;
            this.tbxSteelGradeIndex.Length = 0;
            this.tbxSteelGradeIndex.Location = new System.Drawing.Point(257, 63);
            this.tbxSteelGradeIndex.Max = 0D;
            this.tbxSteelGradeIndex.MaxNull = 0D;
            this.tbxSteelGradeIndex.MaxStringLength = 0;
            this.tbxSteelGradeIndex.MaxStrLength = 0;
            this.tbxSteelGradeIndex.Min = 0D;
            this.tbxSteelGradeIndex.MinNull = 0D;
            this.tbxSteelGradeIndex.MinStringLength = 0;
            this.tbxSteelGradeIndex.MinStrLength = 0;
            this.tbxSteelGradeIndex.Name = "tbxSteelGradeIndex";
            this.tbxSteelGradeIndex.Precision = 0;
            this.tbxSteelGradeIndex.ReadOnly = true;
            this.tbxSteelGradeIndex.Regex = "";
            this.tbxSteelGradeIndex.Size = new System.Drawing.Size(100, 21);
            this.tbxSteelGradeIndex.TabIndex = 1;
            this.tbxSteelGradeIndex.ToolTipValid = this.toolTip1;
            this.tbxSteelGradeIndex.VaildWarning = "";
            this.tbxSteelGradeIndex.ValidEable = false;
            this.tbxSteelGradeIndex.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "炼钢记号:";
            // 
            // tbxPreHeatID
            // 
            this.tbxPreHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "PreHeatID", true));
            this.tbxPreHeatID.DisplayPrecision = 0;
            this.tbxPreHeatID.EnableNull = false;
            this.tbxPreHeatID.ErropPr = this.errorProvider1;
            this.tbxPreHeatID.FixedLength = 0;
            this.tbxPreHeatID.Length = 0;
            this.tbxPreHeatID.Location = new System.Drawing.Point(257, 37);
            this.tbxPreHeatID.Max = 0D;
            this.tbxPreHeatID.MaxNull = 0D;
            this.tbxPreHeatID.MaxStringLength = 0;
            this.tbxPreHeatID.MaxStrLength = 0;
            this.tbxPreHeatID.Min = 0D;
            this.tbxPreHeatID.MinNull = 0D;
            this.tbxPreHeatID.MinStringLength = 0;
            this.tbxPreHeatID.MinStrLength = 0;
            this.tbxPreHeatID.Name = "tbxPreHeatID";
            this.tbxPreHeatID.Precision = 0;
            this.tbxPreHeatID.ReadOnly = true;
            this.tbxPreHeatID.Regex = "";
            this.tbxPreHeatID.Size = new System.Drawing.Size(100, 21);
            this.tbxPreHeatID.TabIndex = 0;
            this.tbxPreHeatID.ToolTipValid = this.toolTip1;
            this.tbxPreHeatID.VaildWarning = "";
            this.tbxPreHeatID.ValidEable = true;
            this.tbxPreHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 90;
            this.label1.Text = "预定炉号:";
            // 
            // pnlBase
            // 
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBase.Controls.Add(this.btnBaseCancel);
            this.pnlBase.Controls.Add(this.btnBaseOK);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBase.Location = new System.Drawing.Point(3, 337);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(1001, 33);
            this.pnlBase.TabIndex = 89;
            // 
            // btnBaseCancel
            // 
            this.btnBaseCancel.Location = new System.Drawing.Point(919, 3);
            this.btnBaseCancel.Name = "btnBaseCancel";
            this.btnBaseCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBaseCancel.TabIndex = 87;
            this.btnBaseCancel.Text = "取消";
            this.btnBaseCancel.UseVisualStyleBackColor = true;
            this.btnBaseCancel.Click += new System.EventHandler(this.btnBaseCancel_Click);
            // 
            // tabLFAddMat
            // 
            this.tabLFAddMat.Controls.Add(this.hmiRootPanel2);
            this.tabLFAddMat.Controls.Add(this.pnlMat);
            this.tabLFAddMat.Location = new System.Drawing.Point(4, 22);
            this.tabLFAddMat.Name = "tabLFAddMat";
            this.tabLFAddMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabLFAddMat.Size = new System.Drawing.Size(1009, 375);
            this.tabLFAddMat.TabIndex = 1;
            this.tabLFAddMat.Text = "加料数据";
            this.tabLFAddMat.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.Controls.Add(this.cmbBatch_Mat);
            this.hmiRootPanel2.Controls.Add(this.dvMat);
            this.hmiRootPanel2.Controls.Add(this.bnMat);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(1003, 336);
            this.hmiRootPanel2.TabIndex = 90;
            // 
            // cmbBatch_Mat
            // 
            this.cmbBatch_Mat.DataSource = this.bsBatchID_Mat;
            this.cmbBatch_Mat.DisplayMember = "Code_Des";
            this.cmbBatch_Mat.DropDownHeight = 200;
            this.cmbBatch_Mat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch_Mat.DropDownWidth = 200;
            this.cmbBatch_Mat.FormattingEnabled = true;
            this.cmbBatch_Mat.IntegralHeight = false;
            this.cmbBatch_Mat.Location = new System.Drawing.Point(234, 104);
            this.cmbBatch_Mat.Name = "cmbBatch_Mat";
            this.cmbBatch_Mat.Size = new System.Drawing.Size(104, 20);
            this.cmbBatch_Mat.TabIndex = 96;
            this.cmbBatch_Mat.ValueMember = "Code";
            this.cmbBatch_Mat.Visible = false;
            this.cmbBatch_Mat.SelectedIndexChanged += new System.EventHandler(this.cmbBatch_Mat_SelectedIndexChanged);
            // 
            // bsBatchID_Mat
            // 
            this.bsBatchID_Mat.DataMember = "L3DataTable";
            this.bsBatchID_Mat.DataSource = this.dsBatchID_Mat;
            // 
            // dsBatchID_Mat
            // 
            this.dsBatchID_Mat.AutoLoad = true;
            this.dsBatchID_Mat.AutoSubscribe = false;
            this.dsBatchID_Mat.DataSetName = "L3DataSet";
            this.dsBatchID_Mat.DeleteMethod = "";
            this.dsBatchID_Mat.InsertMethod = "";
            this.dsBatchID_Mat.L3DataAdapter = this.Adapter;
            this.dsBatchID_Mat.LoadEvent = "";
            this.dsBatchID_Mat.LoadTrigger = null;
            this.dsBatchID_Mat.RefreshValve = 1000;
            this.dsBatchID_Mat.SourceCommand = null;
            this.dsBatchID_Mat.SourceCondition = "";
            this.dsBatchID_Mat.SourceMethod = "";
            this.dsBatchID_Mat.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsBatchID_Mat.SourceURI = "";
            this.dsBatchID_Mat.SubscribeTarget = "";
            this.dsBatchID_Mat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBatchID});
            this.dsBatchID_Mat.UpdateEvent = "";
            this.dsBatchID_Mat.UpdateMethod = "";
            this.dsBatchID_Mat.UpdateTrigger = null;
            // 
            // schemadsBatchID
            // 
            this.schemadsBatchID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBatchIDL3DataTableBatch_ID,
            this.coldsBatchID_MatL3DataTableAlloy_Code,
            this.coldsBatchID_MatL3DataTableCode,
            this.coldsBatchID_MatL3DataTableCode_Des});
            this.schemadsBatchID.TableName = "L3DataTable";
            // 
            // coldsBatchIDL3DataTableBatch_ID
            // 
            this.coldsBatchIDL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsBatchIDL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsBatchIDL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsBatchID_MatL3DataTableAlloy_Code
            // 
            this.coldsBatchID_MatL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsBatchID_MatL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsBatchID_MatL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsBatchID_MatL3DataTableCode
            // 
            this.coldsBatchID_MatL3DataTableCode.Caption = "Code";
            this.coldsBatchID_MatL3DataTableCode.ColumnName = "Code";
            this.coldsBatchID_MatL3DataTableCode.Namespace = "";
            // 
            // coldsBatchID_MatL3DataTableCode_Des
            // 
            this.coldsBatchID_MatL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBatchID_MatL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBatchID_MatL3DataTableCode_Des.Namespace = "";
            // 
            // dvMat
            // 
            this.dvMat.AllowUserToAddRows = false;
            this.dvMat.AllowUserToDeleteRows = false;
            this.dvMat.AutoGenerateColumns = false;
            this.dvMat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.Element,
            this.typeDataGridViewCheckBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.dischargeTimeDataGridViewTextBoxColumn,
            this.Batch_ID_Mat,
            this.GUID_Mat,
            this.Name_Mat,
            this.Vendor,
            this.EnableFlag});
            this.dvMat.DataSource = this.bsMat;
            this.dvMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMat.Location = new System.Drawing.Point(0, 25);
            this.dvMat.Name = "dvMat";
            this.dvMat.RowTemplate.Height = 23;
            this.dvMat.Size = new System.Drawing.Size(1003, 311);
            this.dvMat.TabIndex = 95;
            this.dvMat.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvBatchID_CurrentCellDirtyStateChanged);
            this.dvMat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvBatchID_DataBindingComplete);
            this.dvMat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn
            // 
            this.treatNoDataGridViewTextBoxColumn.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn.Frozen = true;
            this.treatNoDataGridViewTextBoxColumn.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn.Name = "treatNoDataGridViewTextBoxColumn";
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            // 
            // Element
            // 
            this.Element.DataPropertyName = "Element";
            this.Element.DataSource = this.dsCode;
            this.Element.DisplayMember = "L3DataTable.Code_Des";
            this.Element.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Element.Frozen = true;
            this.Element.HeaderText = "辅料代码";
            this.Element.Name = "Element";
            this.Element.ReadOnly = true;
            this.Element.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Element.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Element.ValueMember = "L3DataTable.Code";
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
            this.dsCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\' OR CODE_GROUP = \'BULK_CODE\' order by code_des";
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
            this.coldsCodeL3DataTableCode_Des});
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
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn.DataSource = this.dsAdditionType;
            this.typeDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.typeDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewCheckBoxColumn.Frozen = true;
            this.typeDataGridViewCheckBoxColumn.HeaderText = "分类";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.typeDataGridViewCheckBoxColumn.Width = 84;
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
            this.dsAdditionType.SourceCondition = "CODE_GROUP = \'ADDITION_TYPE\' and code is not null order by code";
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
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.Frozen = true;
            this.weightDataGridViewTextBoxColumn.HeaderText = "加料量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // dischargeTimeDataGridViewTextBoxColumn
            // 
            this.dischargeTimeDataGridViewTextBoxColumn.DataPropertyName = "Discharge_Time";
            dataGridViewCellStyle1.Format = "G";
            this.dischargeTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dischargeTimeDataGridViewTextBoxColumn.Frozen = true;
            this.dischargeTimeDataGridViewTextBoxColumn.HeaderText = "加料时刻";
            this.dischargeTimeDataGridViewTextBoxColumn.Name = "dischargeTimeDataGridViewTextBoxColumn";
            this.dischargeTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dischargeTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // Batch_ID_Mat
            // 
            this.Batch_ID_Mat.DataPropertyName = "Batch_ID";
            this.Batch_ID_Mat.Frozen = true;
            this.Batch_ID_Mat.HeaderText = "批次号";
            this.Batch_ID_Mat.Name = "Batch_ID_Mat";
            this.Batch_ID_Mat.ReadOnly = true;
            // 
            // GUID_Mat
            // 
            this.GUID_Mat.DataPropertyName = "GUID";
            this.GUID_Mat.Frozen = true;
            this.GUID_Mat.HeaderText = "GUID";
            this.GUID_Mat.Name = "GUID_Mat";
            this.GUID_Mat.Visible = false;
            // 
            // Name_Mat
            // 
            this.Name_Mat.DataPropertyName = "Name";
            this.Name_Mat.Frozen = true;
            this.Name_Mat.HeaderText = "人工录入标志";
            this.Name_Mat.Name = "Name_Mat";
            this.Name_Mat.ReadOnly = true;
            // 
            // Vendor
            // 
            this.Vendor.DataPropertyName = "Vendor";
            this.Vendor.HeaderText = "厂家";
            this.Vendor.Name = "Vendor";
            this.Vendor.Visible = false;
            // 
            // EnableFlag
            // 
            this.EnableFlag.DataPropertyName = "EnableFlag";
            this.EnableFlag.HeaderText = "EnableFlag";
            this.EnableFlag.Name = "EnableFlag";
            this.EnableFlag.Visible = false;
            // 
            // bsMat
            // 
            this.bsMat.DataMember = "L3DataTable";
            this.bsMat.DataSource = this.dsMat;
            this.bsMat.CurrentChanged += new System.EventHandler(this.bsBatchID_CurrentChanged);
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
            this.dsMat.SourceURI = "XGMESLogic\\LFMag\\CLF_Addition_Data";
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
            this.coldsMatL3DataTableGUID,
            this.coldsMatL3DataTableName,
            this.coldsMatL3DataTableTreatNo,
            this.coldsMatL3DataTableHeatID,
            this.coldsMatL3DataTableElement,
            this.coldsMatL3DataTableWeight,
            this.coldsMatL3DataTableDischarge_Time,
            this.coldsMatL3DataTableType,
            this.coldsMatL3DataTableBatch_ID,
            this.coldsMatL3DataTableVendor,
            this.coldsMatL3DataTableEnableFlag});
            this.schemadsMat.TableName = "L3DataTable";
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
            // coldsMatL3DataTableTreatNo
            // 
            this.coldsMatL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsMatL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsMatL3DataTableTreatNo.Namespace = "";
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
            // coldsMatL3DataTableBatch_ID
            // 
            this.coldsMatL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsMatL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsMatL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsMatL3DataTableVendor
            // 
            this.coldsMatL3DataTableVendor.Caption = "Vendor";
            this.coldsMatL3DataTableVendor.ColumnName = "Vendor";
            this.coldsMatL3DataTableVendor.Namespace = "";
            // 
            // coldsMatL3DataTableEnableFlag
            // 
            this.coldsMatL3DataTableEnableFlag.Caption = "EnableFlag";
            this.coldsMatL3DataTableEnableFlag.ColumnName = "EnableFlag";
            this.coldsMatL3DataTableEnableFlag.Namespace = "";
            // 
            // bnMat
            // 
            this.bnMat.AddNewItem = null;
            this.bnMat.BindingSource = this.bsMat;
            this.bnMat.CountItem = this.toolStripLabel1;
            this.bnMat.DeleteItem = null;
            this.bnMat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.btnAddMat});
            this.bnMat.Location = new System.Drawing.Point(0, 0);
            this.bnMat.MoveFirstItem = this.toolStripButton2;
            this.bnMat.MoveLastItem = this.toolStripButton5;
            this.bnMat.MoveNextItem = this.toolStripButton4;
            this.bnMat.MovePreviousItem = this.toolStripButton3;
            this.bnMat.Name = "bnMat";
            this.bnMat.PositionItem = this.toolStripTextBox1;
            this.bnMat.Size = new System.Drawing.Size(1003, 25);
            this.bnMat.TabIndex = 94;
            this.bnMat.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlMat
            // 
            this.pnlMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMat.Controls.Add(this.btnMatCancel);
            this.pnlMat.Controls.Add(this.btnMatOK);
            this.pnlMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMat.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlMat.Location = new System.Drawing.Point(3, 339);
            this.pnlMat.Name = "pnlMat";
            this.pnlMat.Size = new System.Drawing.Size(1003, 33);
            this.pnlMat.TabIndex = 89;
            // 
            // btnMatCancel
            // 
            this.btnMatCancel.Location = new System.Drawing.Point(921, 3);
            this.btnMatCancel.Name = "btnMatCancel";
            this.btnMatCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMatCancel.TabIndex = 87;
            this.btnMatCancel.Text = "取消";
            this.btnMatCancel.UseVisualStyleBackColor = true;
            this.btnMatCancel.Click += new System.EventHandler(this.btnMatCancel_Click);
            // 
            // tabWire
            // 
            this.tabWire.Controls.Add(this.hmiRootPanel3);
            this.tabWire.Location = new System.Drawing.Point(4, 22);
            this.tabWire.Name = "tabWire";
            this.tabWire.Padding = new System.Windows.Forms.Padding(3);
            this.tabWire.Size = new System.Drawing.Size(1009, 375);
            this.tabWire.TabIndex = 12;
            this.tabWire.Text = "喂线数据";
            this.tabWire.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel3
            // 
            this.hmiRootPanel3.Controls.Add(this.cmb_Wire);
            this.hmiRootPanel3.Controls.Add(this.dvWire);
            this.hmiRootPanel3.Controls.Add(this.pnlWire);
            this.hmiRootPanel3.Controls.Add(this.bindingNavigator1);
            this.hmiRootPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel3.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel3.Name = "hmiRootPanel3";
            this.hmiRootPanel3.Size = new System.Drawing.Size(1003, 369);
            this.hmiRootPanel3.TabIndex = 1;
            // 
            // cmb_Wire
            // 
            this.cmb_Wire.DataSource = this.bsBatchID_Wire;
            this.cmb_Wire.DisplayMember = "Code_Des";
            this.cmb_Wire.DropDownHeight = 200;
            this.cmb_Wire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Wire.DropDownWidth = 200;
            this.cmb_Wire.FormattingEnabled = true;
            this.cmb_Wire.IntegralHeight = false;
            this.cmb_Wire.Location = new System.Drawing.Point(238, 47);
            this.cmb_Wire.Name = "cmb_Wire";
            this.cmb_Wire.Size = new System.Drawing.Size(102, 20);
            this.cmb_Wire.TabIndex = 101;
            this.cmb_Wire.ValueMember = "Code";
            this.cmb_Wire.Visible = false;
            this.cmb_Wire.SelectedIndexChanged += new System.EventHandler(this.cmb_Wire_SelectedIndexChanged);
            // 
            // bsBatchID_Wire
            // 
            this.bsBatchID_Wire.DataMember = "L3DataTable";
            this.bsBatchID_Wire.DataSource = this.dsBatchID_Wire;
            // 
            // dsBatchID_Wire
            // 
            this.dsBatchID_Wire.AutoLoad = true;
            this.dsBatchID_Wire.AutoSubscribe = false;
            this.dsBatchID_Wire.DataSetName = "L3DataSet";
            this.dsBatchID_Wire.DeleteMethod = "";
            this.dsBatchID_Wire.InsertMethod = "";
            this.dsBatchID_Wire.L3DataAdapter = this.Adapter;
            this.dsBatchID_Wire.LoadEvent = "";
            this.dsBatchID_Wire.LoadTrigger = null;
            this.dsBatchID_Wire.RefreshValve = 1000;
            this.dsBatchID_Wire.SourceCommand = null;
            this.dsBatchID_Wire.SourceCondition = "";
            this.dsBatchID_Wire.SourceMethod = "";
            this.dsBatchID_Wire.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsBatchID_Wire.SourceURI = "";
            this.dsBatchID_Wire.SubscribeTarget = null;
            this.dsBatchID_Wire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBatchID_Wire});
            this.dsBatchID_Wire.UpdateEvent = "";
            this.dsBatchID_Wire.UpdateMethod = "";
            this.dsBatchID_Wire.UpdateTrigger = null;
            // 
            // schemadsBatchID_Wire
            // 
            this.schemadsBatchID_Wire.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBatchID_WireL3DataTableBatch_ID,
            this.coldsBatchID_WireL3DataTableAlloy_Code,
            this.coldsBatchID_WireL3DataTableCode,
            this.coldsBatchID_WireL3DataTableCode_Des,
            this.coldsBatchID_WireL3DataTablecode_function_group});
            this.schemadsBatchID_Wire.TableName = "L3DataTable";
            // 
            // coldsBatchID_WireL3DataTableBatch_ID
            // 
            this.coldsBatchID_WireL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsBatchID_WireL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsBatchID_WireL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsBatchID_WireL3DataTableAlloy_Code
            // 
            this.coldsBatchID_WireL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsBatchID_WireL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsBatchID_WireL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsBatchID_WireL3DataTableCode
            // 
            this.coldsBatchID_WireL3DataTableCode.Caption = "Code";
            this.coldsBatchID_WireL3DataTableCode.ColumnName = "Code";
            this.coldsBatchID_WireL3DataTableCode.Namespace = "";
            // 
            // coldsBatchID_WireL3DataTableCode_Des
            // 
            this.coldsBatchID_WireL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBatchID_WireL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBatchID_WireL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBatchID_WireL3DataTablecode_function_group
            // 
            this.coldsBatchID_WireL3DataTablecode_function_group.Caption = "code_function_group";
            this.coldsBatchID_WireL3DataTablecode_function_group.ColumnName = "code_function_group";
            this.coldsBatchID_WireL3DataTablecode_function_group.Namespace = "";
            // 
            // dvWire
            // 
            this.dvWire.AllowUserToAddRows = false;
            this.dvWire.AllowUserToDeleteRows = false;
            this.dvWire.AutoGenerateColumns = false;
            this.dvWire.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvWire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvWire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn5,
            this.heatIDDataGridViewTextBoxColumn6,
            this.WireCode,
            this.Weight,
            this.Amount,
            this.speedDataGridViewTextBoxColumn,
            this.wireTimeDataGridViewTextBoxColumn,
            this.Batch_ID_Wire,
            this.GUID_Wire,
            this.Name_Wire,
            this.EnableFlagWire});
            this.dvWire.DataSource = this.bsWire;
            this.dvWire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWire.Location = new System.Drawing.Point(0, 25);
            this.dvWire.Name = "dvWire";
            this.dvWire.RowTemplate.Height = 23;
            this.dvWire.Size = new System.Drawing.Size(1003, 311);
            this.dvWire.TabIndex = 100;
            this.dvWire.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvBatchID_CurrentCellDirtyStateChanged);
            this.dvWire.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvBatchID_DataBindingComplete);
            this.dvWire.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn5
            // 
            this.treatNoDataGridViewTextBoxColumn5.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn5.Frozen = true;
            this.treatNoDataGridViewTextBoxColumn5.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn5.Name = "treatNoDataGridViewTextBoxColumn5";
            // 
            // heatIDDataGridViewTextBoxColumn6
            // 
            this.heatIDDataGridViewTextBoxColumn6.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn6.Frozen = true;
            this.heatIDDataGridViewTextBoxColumn6.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn6.Name = "heatIDDataGridViewTextBoxColumn6";
            // 
            // WireCode
            // 
            this.WireCode.DataPropertyName = "WireCode";
            this.WireCode.DataSource = this.dsWireCode;
            this.WireCode.DisplayMember = "L3DataTable.Code_Des";
            this.WireCode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.WireCode.Frozen = true;
            this.WireCode.HeaderText = "喂线代码";
            this.WireCode.Name = "WireCode";
            this.WireCode.ReadOnly = true;
            this.WireCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WireCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WireCode.ValueMember = "L3DataTable.Code";
            // 
            // dsWireCode
            // 
            this.dsWireCode.AutoLoad = true;
            this.dsWireCode.AutoSubscribe = false;
            this.dsWireCode.DataSetName = "L3DataSet";
            this.dsWireCode.DeleteMethod = "";
            this.dsWireCode.InsertMethod = "";
            this.dsWireCode.L3DataAdapter = this.Adapter;
            this.dsWireCode.LoadEvent = "";
            this.dsWireCode.LoadTrigger = null;
            this.dsWireCode.RefreshValve = 1000;
            this.dsWireCode.SourceCommand = null;
            this.dsWireCode.SourceCondition = "CODE_FUNCTION_GROUP = \'FeedWire\' order by code";
            this.dsWireCode.SourceMethod = "";
            this.dsWireCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWireCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWireCode.SubscribeTarget = null;
            this.dsWireCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWireCode});
            this.dsWireCode.UpdateEvent = "";
            this.dsWireCode.UpdateMethod = "";
            this.dsWireCode.UpdateTrigger = null;
            // 
            // schemadsWireCode
            // 
            this.schemadsWireCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireCodeL3DataTableCode,
            this.coldsWireCodeL3DataTableCode_Des});
            this.schemadsWireCode.TableName = "L3DataTable";
            // 
            // coldsWireCodeL3DataTableCode
            // 
            this.coldsWireCodeL3DataTableCode.Caption = "Code";
            this.coldsWireCodeL3DataTableCode.ColumnName = "Code";
            this.coldsWireCodeL3DataTableCode.Namespace = "";
            // 
            // coldsWireCodeL3DataTableCode_Des
            // 
            this.coldsWireCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWireCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWireCodeL3DataTableCode_Des.Namespace = "";
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.Frozen = true;
            this.Weight.HeaderText = "喂线长度[m]";
            this.Weight.Name = "Weight";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.Frozen = true;
            this.Amount.HeaderText = "喂线重量[Kg]";
            this.Amount.Name = "Amount";
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.Frozen = true;
            this.speedDataGridViewTextBoxColumn.HeaderText = "喂线速度";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            // 
            // wireTimeDataGridViewTextBoxColumn
            // 
            this.wireTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.wireTimeDataGridViewTextBoxColumn.DataPropertyName = "WireTime";
            dataGridViewCellStyle2.Format = "G";
            this.wireTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.wireTimeDataGridViewTextBoxColumn.Frozen = true;
            this.wireTimeDataGridViewTextBoxColumn.HeaderText = "喂线时刻";
            this.wireTimeDataGridViewTextBoxColumn.Name = "wireTimeDataGridViewTextBoxColumn";
            this.wireTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wireTimeDataGridViewTextBoxColumn.Width = 114;
            // 
            // Batch_ID_Wire
            // 
            this.Batch_ID_Wire.DataPropertyName = "Batch_ID";
            this.Batch_ID_Wire.Frozen = true;
            this.Batch_ID_Wire.HeaderText = "批次号";
            this.Batch_ID_Wire.Name = "Batch_ID_Wire";
            this.Batch_ID_Wire.ReadOnly = true;
            // 
            // GUID_Wire
            // 
            this.GUID_Wire.DataPropertyName = "GUID";
            this.GUID_Wire.HeaderText = "GUID";
            this.GUID_Wire.Name = "GUID_Wire";
            this.GUID_Wire.Visible = false;
            // 
            // Name_Wire
            // 
            this.Name_Wire.DataPropertyName = "Name";
            this.Name_Wire.HeaderText = "人工录入标志";
            this.Name_Wire.Name = "Name_Wire";
            this.Name_Wire.ReadOnly = true;
            // 
            // EnableFlagWire
            // 
            this.EnableFlagWire.DataPropertyName = "EnableFlag";
            this.EnableFlagWire.HeaderText = "EnableFlag";
            this.EnableFlagWire.Name = "EnableFlagWire";
            this.EnableFlagWire.Visible = false;
            // 
            // bsWire
            // 
            this.bsWire.DataMember = "L3DataTable";
            this.bsWire.DataSource = this.dsWire;
            this.bsWire.CurrentChanged += new System.EventHandler(this.bsBatchID_CurrentChanged);
            // 
            // dsWire
            // 
            this.dsWire.AutoLoad = true;
            this.dsWire.AutoSubscribe = false;
            this.dsWire.DataSetName = "L3DataSet";
            this.dsWire.DeleteMethod = null;
            this.dsWire.InsertMethod = null;
            this.dsWire.L3DataAdapter = null;
            this.dsWire.LoadEvent = "Click";
            this.dsWire.LoadTrigger = null;
            this.dsWire.RefreshValve = 1000;
            this.dsWire.SourceCommand = null;
            this.dsWire.SourceCondition = "1=2";
            this.dsWire.SourceMethod = "";
            this.dsWire.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWire.SourceURI = "XGMESLogic\\LFMag\\CLF_Wire_Data";
            this.dsWire.SubscribeTarget = null;
            this.dsWire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWire});
            this.dsWire.UpdateEvent = "Click";
            this.dsWire.UpdateMethod = null;
            this.dsWire.UpdateTrigger = null;
            // 
            // schemadsWire
            // 
            this.schemadsWire.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireL3DataTableGUID,
            this.coldsWireL3DataTableName,
            this.coldsWireL3DataTableTreatNo,
            this.coldsWireL3DataTableHeatID,
            this.coldsWireL3DataTableWireCode,
            this.coldsWireL3DataTableWeight,
            this.coldsWireL3DataTableSpeed,
            this.coldsWireL3DataTableWireTime,
            this.coldsWireL3DataTableVendor,
            this.AcoldsWireL3DataTableBatch_ID,
            this.coldsWireL3DataTableEnableFlag,
            this.coldsWireL3DataTableAmount});
            this.schemadsWire.TableName = "L3DataTable";
            // 
            // coldsWireL3DataTableGUID
            // 
            this.coldsWireL3DataTableGUID.Caption = "GUID";
            this.coldsWireL3DataTableGUID.ColumnName = "GUID";
            this.coldsWireL3DataTableGUID.Namespace = "";
            // 
            // coldsWireL3DataTableName
            // 
            this.coldsWireL3DataTableName.Caption = "Name";
            this.coldsWireL3DataTableName.ColumnName = "Name";
            this.coldsWireL3DataTableName.Namespace = "";
            // 
            // coldsWireL3DataTableTreatNo
            // 
            this.coldsWireL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsWireL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsWireL3DataTableTreatNo.Namespace = "";
            // 
            // coldsWireL3DataTableHeatID
            // 
            this.coldsWireL3DataTableHeatID.Caption = "HeatID";
            this.coldsWireL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsWireL3DataTableHeatID.Namespace = "";
            // 
            // coldsWireL3DataTableWireCode
            // 
            this.coldsWireL3DataTableWireCode.Caption = "WireCode";
            this.coldsWireL3DataTableWireCode.ColumnName = "WireCode";
            this.coldsWireL3DataTableWireCode.Namespace = "";
            // 
            // coldsWireL3DataTableWeight
            // 
            this.coldsWireL3DataTableWeight.Caption = "Weight";
            this.coldsWireL3DataTableWeight.ColumnName = "Weight";
            this.coldsWireL3DataTableWeight.DataType = typeof(float);
            this.coldsWireL3DataTableWeight.Namespace = "";
            // 
            // coldsWireL3DataTableSpeed
            // 
            this.coldsWireL3DataTableSpeed.Caption = "Speed";
            this.coldsWireL3DataTableSpeed.ColumnName = "Speed";
            this.coldsWireL3DataTableSpeed.DataType = typeof(float);
            this.coldsWireL3DataTableSpeed.Namespace = "";
            // 
            // coldsWireL3DataTableWireTime
            // 
            this.coldsWireL3DataTableWireTime.Caption = "WireTime";
            this.coldsWireL3DataTableWireTime.ColumnName = "WireTime";
            this.coldsWireL3DataTableWireTime.DataType = typeof(System.DateTime);
            this.coldsWireL3DataTableWireTime.Namespace = "";
            // 
            // coldsWireL3DataTableVendor
            // 
            this.coldsWireL3DataTableVendor.Caption = "Vendor";
            this.coldsWireL3DataTableVendor.ColumnName = "Vendor";
            this.coldsWireL3DataTableVendor.Namespace = "";
            // 
            // AcoldsWireL3DataTableBatch_ID
            // 
            this.AcoldsWireL3DataTableBatch_ID.Caption = "Batch_ID";
            this.AcoldsWireL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.AcoldsWireL3DataTableBatch_ID.Namespace = "";
            // 
            // coldsWireL3DataTableEnableFlag
            // 
            this.coldsWireL3DataTableEnableFlag.Caption = "EnableFlag";
            this.coldsWireL3DataTableEnableFlag.ColumnName = "EnableFlag";
            this.coldsWireL3DataTableEnableFlag.Namespace = "";
            // 
            // coldsWireL3DataTableAmount
            // 
            this.coldsWireL3DataTableAmount.Caption = "Amount";
            this.coldsWireL3DataTableAmount.ColumnName = "Amount";
            this.coldsWireL3DataTableAmount.DataType = typeof(double);
            this.coldsWireL3DataTableAmount.Namespace = "";
            // 
            // pnlWire
            // 
            this.pnlWire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWire.Controls.Add(this.btnWireCancel);
            this.pnlWire.Controls.Add(this.btnWireConfirm);
            this.pnlWire.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWire.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlWire.Location = new System.Drawing.Point(0, 336);
            this.pnlWire.Name = "pnlWire";
            this.pnlWire.Size = new System.Drawing.Size(1003, 33);
            this.pnlWire.TabIndex = 99;
            // 
            // btnWireCancel
            // 
            this.btnWireCancel.Location = new System.Drawing.Point(921, 3);
            this.btnWireCancel.Name = "btnWireCancel";
            this.btnWireCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWireCancel.TabIndex = 87;
            this.btnWireCancel.Text = "取消";
            this.btnWireCancel.UseVisualStyleBackColor = true;
            this.btnWireCancel.Click += new System.EventHandler(this.btnWireCancel_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsWire;
            this.bindingNavigator1.CountItem = this.toolStripLabel5;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton22,
            this.toolStripSeparator13,
            this.toolStripTextBox5,
            this.toolStripLabel5,
            this.toolStripSeparator14,
            this.toolStripButton23,
            this.toolStripButton24,
            this.toolStripSeparator15,
            this.btnWireAdd});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton24;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton23;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton22;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox5;
            this.bindingNavigator1.Size = new System.Drawing.Size(1003, 25);
            this.bindingNavigator1.TabIndex = 97;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel5.Text = "/ {0}";
            this.toolStripLabel5.ToolTipText = "总项数";
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
            // toolStripButton22
            // 
            this.toolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton22.Image")));
            this.toolStripButton22.Name = "toolStripButton22";
            this.toolStripButton22.RightToLeftAutoMirrorImage = true;
            this.toolStripButton22.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton22.Text = "移到上一条记录";
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
            // toolStripButton23
            // 
            this.toolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton23.Image")));
            this.toolStripButton23.Name = "toolStripButton23";
            this.toolStripButton23.RightToLeftAutoMirrorImage = true;
            this.toolStripButton23.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton23.Text = "移到下一条记录";
            // 
            // toolStripButton24
            // 
            this.toolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton24.Image")));
            this.toolStripButton24.Name = "toolStripButton24";
            this.toolStripButton24.RightToLeftAutoMirrorImage = true;
            this.toolStripButton24.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton24.Text = "移到最后一条记录";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // tabProcess
            // 
            this.tabProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProcess.Controls.Add(this.label12);
            this.tabProcess.Controls.Add(this.txtHoldBackTime);
            this.tabProcess.Controls.Add(this.txtProcessTime);
            this.tabProcess.Controls.Add(this.txtHeatTime);
            this.tabProcess.Controls.Add(this.cmbProbe_Vonder);
            this.tabProcess.Controls.Add(this.txtSoftBlowTime);
            this.tabProcess.Controls.Add(this.dtSoftBlowEndTime);
            this.tabProcess.Controls.Add(this.label11);
            this.tabProcess.Controls.Add(this.txtSteelWeight);
            this.tabProcess.Controls.Add(this.label43);
            this.tabProcess.Controls.Add(this.txtFeedWireTemp);
            this.tabProcess.Controls.Add(this.label44);
            this.tabProcess.Controls.Add(this.txtLadleGrade);
            this.tabProcess.Controls.Add(this.txtLadleNo);
            this.tabProcess.Controls.Add(this.label13);
            this.tabProcess.Controls.Add(this.label40);
            this.tabProcess.Controls.Add(this.txtProbeVonder);
            this.tabProcess.Controls.Add(this.label41);
            this.tabProcess.Controls.Add(this.dtSoftBlowStartTime);
            this.tabProcess.Controls.Add(this.dtEndTime);
            this.tabProcess.Controls.Add(this.dtStartTime);
            this.tabProcess.Controls.Add(this.dtArrivalTime);
            this.tabProcess.Controls.Add(this.ptbSlag_Thickness);
            this.tabProcess.Controls.Add(this.txtHoldBackTimeDis);
            this.tabProcess.Controls.Add(this.label16);
            this.tabProcess.Controls.Add(this.label23);
            this.tabProcess.Controls.Add(this.txtLidLife);
            this.tabProcess.Controls.Add(this.label24);
            this.tabProcess.Controls.Add(this.txtSoftBlowTimeDis);
            this.tabProcess.Controls.Add(this.label25);
            this.tabProcess.Controls.Add(this.txtDepartureTemp);
            this.tabProcess.Controls.Add(this.label26);
            this.tabProcess.Controls.Add(this.txtHeatCount);
            this.tabProcess.Controls.Add(this.label27);
            this.tabProcess.Controls.Add(this.txtHeatTimeDis);
            this.tabProcess.Controls.Add(this.label28);
            this.tabProcess.Controls.Add(this.txtProcessTimeDis);
            this.tabProcess.Controls.Add(this.label29);
            this.tabProcess.Controls.Add(this.txtArrivalTemp);
            this.tabProcess.Controls.Add(this.label30);
            this.tabProcess.Controls.Add(this.label31);
            this.tabProcess.Controls.Add(this.label32);
            this.tabProcess.Controls.Add(this.label33);
            this.tabProcess.Controls.Add(this.label34);
            this.tabProcess.Controls.Add(this.pnlProcess);
            this.tabProcess.Location = new System.Drawing.Point(4, 22);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(1009, 375);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "精炼数据";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(688, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 44);
            this.label12.TabIndex = 180;
            // 
            // cmbProbe_Vonder
            // 
            this.cmbProbe_Vonder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Probe_Vonder", true));
            this.cmbProbe_Vonder.DataSource = this.dsProbe_Vonder;
            this.cmbProbe_Vonder.DisplayMember = "L3DataTable.Code_Des";
            this.cmbProbe_Vonder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProbe_Vonder.FormattingEnabled = true;
            this.cmbProbe_Vonder.Location = new System.Drawing.Point(512, 126);
            this.cmbProbe_Vonder.Name = "cmbProbe_Vonder";
            this.cmbProbe_Vonder.Size = new System.Drawing.Size(15, 20);
            this.cmbProbe_Vonder.TabIndex = 179;
            this.cmbProbe_Vonder.ValueMember = "L3DataTable.Code";
            this.cmbProbe_Vonder.Visible = false;
            // 
            // dsProbe_Vonder
            // 
            this.dsProbe_Vonder.AutoLoad = true;
            this.dsProbe_Vonder.AutoSubscribe = false;
            this.dsProbe_Vonder.DataSetName = "L3DataSet";
            this.dsProbe_Vonder.DeleteMethod = "";
            this.dsProbe_Vonder.InsertMethod = "";
            this.dsProbe_Vonder.L3DataAdapter = this.Adapter;
            this.dsProbe_Vonder.LoadEvent = "";
            this.dsProbe_Vonder.LoadTrigger = null;
            this.dsProbe_Vonder.RefreshValve = 1000;
            this.dsProbe_Vonder.SourceCommand = null;
            this.dsProbe_Vonder.SourceCondition = "CODE_GROUP = \'Probe_Vonder\'";
            this.dsProbe_Vonder.SourceMethod = "";
            this.dsProbe_Vonder.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProbe_Vonder.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsProbe_Vonder.SubscribeTarget = null;
            this.dsProbe_Vonder.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProbe_Vonder});
            this.dsProbe_Vonder.UpdateEvent = "";
            this.dsProbe_Vonder.UpdateMethod = "";
            this.dsProbe_Vonder.UpdateTrigger = null;
            // 
            // schemadsProbe_Vonder
            // 
            this.schemadsProbe_Vonder.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProbe_VonderL3DataTableCode,
            this.coldsProbe_VonderL3DataTableCode_Des});
            this.schemadsProbe_Vonder.TableName = "L3DataTable";
            // 
            // coldsProbe_VonderL3DataTableCode
            // 
            this.coldsProbe_VonderL3DataTableCode.Caption = "Code";
            this.coldsProbe_VonderL3DataTableCode.ColumnName = "Code";
            this.coldsProbe_VonderL3DataTableCode.Namespace = "";
            // 
            // coldsProbe_VonderL3DataTableCode_Des
            // 
            this.coldsProbe_VonderL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsProbe_VonderL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsProbe_VonderL3DataTableCode_Des.Namespace = "";
            // 
            // dtSoftBlowEndTime
            // 
            this.dtSoftBlowEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSoftBlowEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "SoftBlow_EndTime", true));
            this.dtSoftBlowEndTime.Enabled = false;
            this.dtSoftBlowEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSoftBlowEndTime.Location = new System.Drawing.Point(184, 126);
            this.dtSoftBlowEndTime.Name = "dtSoftBlowEndTime";
            this.dtSoftBlowEndTime.Size = new System.Drawing.Size(144, 21);
            this.dtSoftBlowEndTime.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 178;
            this.label11.Text = "软吹结束时刻:";
            // 
            // txtSteelWeight
            // 
            this.txtSteelWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Steel_Weight", true));
            this.txtSteelWeight.DisplayPrecision = 0;
            this.txtSteelWeight.EnableNull = false;
            this.txtSteelWeight.ErropPr = this.errorProvider1;
            this.txtSteelWeight.FixedLength = 0;
            this.txtSteelWeight.Length = 0;
            this.txtSteelWeight.Location = new System.Drawing.Point(421, 155);
            this.txtSteelWeight.Max = 99D;
            this.txtSteelWeight.MaxNull = 99D;
            this.txtSteelWeight.MaxStringLength = 0;
            this.txtSteelWeight.MaxStrLength = 0;
            this.txtSteelWeight.Min = 0D;
            this.txtSteelWeight.MinNull = 0D;
            this.txtSteelWeight.MinStringLength = 0;
            this.txtSteelWeight.MinStrLength = 0;
            this.txtSteelWeight.Name = "txtSteelWeight";
            this.txtSteelWeight.Precision = 0;
            this.txtSteelWeight.ReadOnly = true;
            this.txtSteelWeight.Regex = "";
            this.txtSteelWeight.Size = new System.Drawing.Size(85, 21);
            this.txtSteelWeight.TabIndex = 16;
            this.txtSteelWeight.ToolTipValid = this.toolTip1;
            this.txtSteelWeight.VaildWarning = "";
            this.txtSteelWeight.ValidEable = true;
            this.txtSteelWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(350, 158);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(65, 12);
            this.label43.TabIndex = 174;
            this.label43.Text = "钢水量[t]:";
            // 
            // txtFeedWireTemp
            // 
            this.txtFeedWireTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "FeedWire_Temp", true));
            this.txtFeedWireTemp.DisplayPrecision = 0;
            this.txtFeedWireTemp.EnableNull = false;
            this.txtFeedWireTemp.ErropPr = this.errorProvider1;
            this.txtFeedWireTemp.FixedLength = 0;
            this.txtFeedWireTemp.Length = 0;
            this.txtFeedWireTemp.Location = new System.Drawing.Point(184, 155);
            this.txtFeedWireTemp.Max = 2000D;
            this.txtFeedWireTemp.MaxNull = 2000D;
            this.txtFeedWireTemp.MaxStringLength = 0;
            this.txtFeedWireTemp.MaxStrLength = 0;
            this.txtFeedWireTemp.Min = 0D;
            this.txtFeedWireTemp.MinNull = 0D;
            this.txtFeedWireTemp.MinStringLength = 0;
            this.txtFeedWireTemp.MinStrLength = 0;
            this.txtFeedWireTemp.Name = "txtFeedWireTemp";
            this.txtFeedWireTemp.Precision = 0;
            this.txtFeedWireTemp.ReadOnly = true;
            this.txtFeedWireTemp.Regex = "";
            this.txtFeedWireTemp.Size = new System.Drawing.Size(144, 21);
            this.txtFeedWireTemp.TabIndex = 10;
            this.txtFeedWireTemp.ToolTipValid = this.toolTip1;
            this.txtFeedWireTemp.VaildWarning = "";
            this.txtFeedWireTemp.ValidEable = true;
            this.txtFeedWireTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(71, 158);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(107, 12);
            this.label44.TabIndex = 172;
            this.label44.Text = "软吹开始温度[℃]:";
            // 
            // txtLadleGrade
            // 
            this.txtLadleGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Ladle_Grade", true));
            this.txtLadleGrade.DisplayPrecision = 0;
            this.txtLadleGrade.EnableNull = false;
            this.txtLadleGrade.ErropPr = null;
            this.txtLadleGrade.FixedLength = 0;
            this.txtLadleGrade.Length = 0;
            this.txtLadleGrade.Location = new System.Drawing.Point(597, 155);
            this.txtLadleGrade.Max = 0D;
            this.txtLadleGrade.MaxNull = 0D;
            this.txtLadleGrade.MaxStringLength = 0;
            this.txtLadleGrade.MaxStrLength = 0;
            this.txtLadleGrade.Min = 0D;
            this.txtLadleGrade.MinNull = 0D;
            this.txtLadleGrade.MinStringLength = 0;
            this.txtLadleGrade.MinStrLength = 0;
            this.txtLadleGrade.Name = "txtLadleGrade";
            this.txtLadleGrade.Precision = 0;
            this.txtLadleGrade.ReadOnly = true;
            this.txtLadleGrade.Regex = "";
            this.txtLadleGrade.Size = new System.Drawing.Size(85, 21);
            this.txtLadleGrade.TabIndex = 15;
            this.txtLadleGrade.ToolTipValid = null;
            this.txtLadleGrade.VaildWarning = "";
            this.txtLadleGrade.ValidEable = true;
            this.txtLadleGrade.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtLadleNo
            // 
            this.txtLadleNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "LadleNo", true));
            this.txtLadleNo.DisplayPrecision = 0;
            this.txtLadleNo.EnableNull = false;
            this.txtLadleNo.ErropPr = this.errorProvider1;
            this.txtLadleNo.FixedLength = 0;
            this.txtLadleNo.Length = 0;
            this.txtLadleNo.Location = new System.Drawing.Point(597, 127);
            this.txtLadleNo.Max = 0D;
            this.txtLadleNo.MaxNull = 0D;
            this.txtLadleNo.MaxStringLength = 0;
            this.txtLadleNo.MaxStrLength = 0;
            this.txtLadleNo.Min = 0D;
            this.txtLadleNo.MinNull = 0D;
            this.txtLadleNo.MinStringLength = 0;
            this.txtLadleNo.MinStrLength = 0;
            this.txtLadleNo.Name = "txtLadleNo";
            this.txtLadleNo.Precision = 0;
            this.txtLadleNo.ReadOnly = true;
            this.txtLadleNo.Regex = "";
            this.txtLadleNo.Size = new System.Drawing.Size(85, 21);
            this.txtLadleNo.TabIndex = 15;
            this.txtLadleNo.ToolTipValid = this.toolTip1;
            this.txtLadleNo.VaildWarning = "";
            this.txtLadleNo.ValidEable = true;
            this.txtLadleNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(532, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 168;
            this.label13.Text = "钢包状况:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(544, 132);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(47, 12);
            this.label40.TabIndex = 168;
            this.label40.Text = "钢包号:";
            // 
            // txtProbeVonder
            // 
            this.txtProbeVonder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Probe_Vonder", true));
            this.txtProbeVonder.DisplayPrecision = 0;
            this.txtProbeVonder.EnableNull = false;
            this.txtProbeVonder.ErropPr = this.errorProvider1;
            this.txtProbeVonder.FixedLength = 0;
            this.txtProbeVonder.Length = 0;
            this.txtProbeVonder.Location = new System.Drawing.Point(421, 126);
            this.txtProbeVonder.Max = 0D;
            this.txtProbeVonder.MaxNull = 0D;
            this.txtProbeVonder.MaxStringLength = 0;
            this.txtProbeVonder.MaxStrLength = 0;
            this.txtProbeVonder.Min = 0D;
            this.txtProbeVonder.MinNull = 0D;
            this.txtProbeVonder.MinStringLength = 0;
            this.txtProbeVonder.MinStrLength = 0;
            this.txtProbeVonder.Name = "txtProbeVonder";
            this.txtProbeVonder.Precision = 0;
            this.txtProbeVonder.ReadOnly = true;
            this.txtProbeVonder.Regex = "";
            this.txtProbeVonder.Size = new System.Drawing.Size(85, 21);
            this.txtProbeVonder.TabIndex = 9;
            this.txtProbeVonder.ToolTipValid = this.toolTip1;
            this.txtProbeVonder.VaildWarning = "";
            this.txtProbeVonder.ValidEable = true;
            this.txtProbeVonder.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // ptbSlag_Thickness
            // 
            this.ptbSlag_Thickness.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Slag_Thickness", true));
            this.ptbSlag_Thickness.DisplayPrecision = 0;
            this.ptbSlag_Thickness.EnableNull = false;
            this.ptbSlag_Thickness.ErropPr = null;
            this.ptbSlag_Thickness.FixedLength = 0;
            this.ptbSlag_Thickness.Length = 0;
            this.ptbSlag_Thickness.Location = new System.Drawing.Point(597, 208);
            this.ptbSlag_Thickness.Max = 0D;
            this.ptbSlag_Thickness.MaxNull = 0D;
            this.ptbSlag_Thickness.MaxStringLength = 0;
            this.ptbSlag_Thickness.MaxStrLength = 0;
            this.ptbSlag_Thickness.Min = 0D;
            this.ptbSlag_Thickness.MinNull = 0D;
            this.ptbSlag_Thickness.MinStringLength = 0;
            this.ptbSlag_Thickness.MinStrLength = 0;
            this.ptbSlag_Thickness.Name = "ptbSlag_Thickness";
            this.ptbSlag_Thickness.Precision = 0;
            this.ptbSlag_Thickness.Regex = "";
            this.ptbSlag_Thickness.Size = new System.Drawing.Size(85, 21);
            this.ptbSlag_Thickness.TabIndex = 14;
            this.ptbSlag_Thickness.ToolTipValid = null;
            this.ptbSlag_Thickness.VaildWarning = "";
            this.ptbSlag_Thickness.ValidEable = true;
            this.ptbSlag_Thickness.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtHoldBackTimeDis
            // 
            this.txtHoldBackTimeDis.DisplayPrecision = 0;
            this.txtHoldBackTimeDis.EnableNull = false;
            this.txtHoldBackTimeDis.ErropPr = null;
            this.txtHoldBackTimeDis.FixedLength = 0;
            this.txtHoldBackTimeDis.Length = 0;
            this.txtHoldBackTimeDis.Location = new System.Drawing.Point(597, 101);
            this.txtHoldBackTimeDis.Max = 9999D;
            this.txtHoldBackTimeDis.MaxNull = 9999D;
            this.txtHoldBackTimeDis.MaxStringLength = 0;
            this.txtHoldBackTimeDis.MaxStrLength = 0;
            this.txtHoldBackTimeDis.Min = 0D;
            this.txtHoldBackTimeDis.MinNull = 0D;
            this.txtHoldBackTimeDis.MinStringLength = 0;
            this.txtHoldBackTimeDis.MinStrLength = 0;
            this.txtHoldBackTimeDis.Name = "txtHoldBackTimeDis";
            this.txtHoldBackTimeDis.Precision = 0;
            this.txtHoldBackTimeDis.Regex = "";
            this.txtHoldBackTimeDis.Size = new System.Drawing.Size(85, 21);
            this.txtHoldBackTimeDis.TabIndex = 14;
            this.txtHoldBackTimeDis.ToolTipValid = null;
            this.txtHoldBackTimeDis.VaildWarning = "";
            this.txtHoldBackTimeDis.ValidEable = true;
            this.txtHoldBackTimeDis.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(484, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 12);
            this.label16.TabIndex = 152;
            this.label16.Text = "渣层厚度(不锈钢):";
            // 
            // txtSoftBlowTimeDis
            // 
            this.txtSoftBlowTimeDis.DisplayPrecision = 0;
            this.txtSoftBlowTimeDis.EnableNull = false;
            this.txtSoftBlowTimeDis.ErropPr = null;
            this.txtSoftBlowTimeDis.FixedLength = 0;
            this.txtSoftBlowTimeDis.Length = 0;
            this.txtSoftBlowTimeDis.Location = new System.Drawing.Point(597, 47);
            this.txtSoftBlowTimeDis.Max = 9999D;
            this.txtSoftBlowTimeDis.MaxNull = 9999D;
            this.txtSoftBlowTimeDis.MaxStringLength = 0;
            this.txtSoftBlowTimeDis.MaxStrLength = 0;
            this.txtSoftBlowTimeDis.Min = 0D;
            this.txtSoftBlowTimeDis.MinNull = 0D;
            this.txtSoftBlowTimeDis.MinStringLength = 0;
            this.txtSoftBlowTimeDis.MinStrLength = 0;
            this.txtSoftBlowTimeDis.Name = "txtSoftBlowTimeDis";
            this.txtSoftBlowTimeDis.Precision = 0;
            this.txtSoftBlowTimeDis.ReadOnly = true;
            this.txtSoftBlowTimeDis.Regex = "";
            this.txtSoftBlowTimeDis.Size = new System.Drawing.Size(85, 21);
            this.txtSoftBlowTimeDis.TabIndex = 12;
            this.txtSoftBlowTimeDis.ToolTipValid = null;
            this.txtSoftBlowTimeDis.VaildWarning = "";
            this.txtSoftBlowTimeDis.ValidEable = false;
            this.txtSoftBlowTimeDis.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtHeatTimeDis
            // 
            this.txtHeatTimeDis.DisplayPrecision = 0;
            this.txtHeatTimeDis.EnableNull = false;
            this.txtHeatTimeDis.ErropPr = null;
            this.txtHeatTimeDis.FixedLength = 0;
            this.txtHeatTimeDis.Length = 0;
            this.txtHeatTimeDis.Location = new System.Drawing.Point(421, 74);
            this.txtHeatTimeDis.Max = 9999D;
            this.txtHeatTimeDis.MaxNull = 9999D;
            this.txtHeatTimeDis.MaxStringLength = 0;
            this.txtHeatTimeDis.MaxStrLength = 0;
            this.txtHeatTimeDis.Min = 0D;
            this.txtHeatTimeDis.MinNull = 0D;
            this.txtHeatTimeDis.MinStringLength = 0;
            this.txtHeatTimeDis.MinStrLength = 0;
            this.txtHeatTimeDis.Name = "txtHeatTimeDis";
            this.txtHeatTimeDis.Precision = 0;
            this.txtHeatTimeDis.ReadOnly = true;
            this.txtHeatTimeDis.Regex = "";
            this.txtHeatTimeDis.Size = new System.Drawing.Size(85, 21);
            this.txtHeatTimeDis.TabIndex = 7;
            this.txtHeatTimeDis.ToolTipValid = null;
            this.txtHeatTimeDis.VaildWarning = "";
            this.txtHeatTimeDis.ValidEable = true;
            this.txtHeatTimeDis.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtProcessTimeDis
            // 
            this.txtProcessTimeDis.DisplayPrecision = 0;
            this.txtProcessTimeDis.EnableNull = false;
            this.txtProcessTimeDis.ErropPr = null;
            this.txtProcessTimeDis.FixedLength = 0;
            this.txtProcessTimeDis.Length = 0;
            this.txtProcessTimeDis.Location = new System.Drawing.Point(421, 47);
            this.txtProcessTimeDis.Max = 9999D;
            this.txtProcessTimeDis.MaxNull = 9999D;
            this.txtProcessTimeDis.MaxStringLength = 0;
            this.txtProcessTimeDis.MaxStrLength = 0;
            this.txtProcessTimeDis.Min = 0D;
            this.txtProcessTimeDis.MinNull = 0D;
            this.txtProcessTimeDis.MinStringLength = 0;
            this.txtProcessTimeDis.MinStrLength = 0;
            this.txtProcessTimeDis.Name = "txtProcessTimeDis";
            this.txtProcessTimeDis.Precision = 0;
            this.txtProcessTimeDis.ReadOnly = true;
            this.txtProcessTimeDis.Regex = "";
            this.txtProcessTimeDis.Size = new System.Drawing.Size(85, 21);
            this.txtProcessTimeDis.TabIndex = 6;
            this.txtProcessTimeDis.ToolTipValid = null;
            this.txtProcessTimeDis.VaildWarning = "";
            this.txtProcessTimeDis.ValidEable = true;
            this.txtProcessTimeDis.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // tabLadleInfo
            // 
            this.tabLadleInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLadleInfo.Controls.Add(this.textBox10);
            this.tabLadleInfo.Controls.Add(this.label15);
            this.tabLadleInfo.Controls.Add(this.richTextBox1);
            this.tabLadleInfo.Controls.Add(this.comboBox3);
            this.tabLadleInfo.Controls.Add(this.comboBox2);
            this.tabLadleInfo.Controls.Add(this.comboBox1);
            this.tabLadleInfo.Controls.Add(this.textBox7);
            this.tabLadleInfo.Controls.Add(this.textBox6);
            this.tabLadleInfo.Controls.Add(this.textBox5);
            this.tabLadleInfo.Controls.Add(this.textBox4);
            this.tabLadleInfo.Controls.Add(this.textBox3);
            this.tabLadleInfo.Controls.Add(this.textBox9);
            this.tabLadleInfo.Controls.Add(this.textBox2);
            this.tabLadleInfo.Controls.Add(this.textBox8);
            this.tabLadleInfo.Controls.Add(this.textBox1);
            this.tabLadleInfo.Controls.Add(this.label14);
            this.tabLadleInfo.Controls.Add(this.label22);
            this.tabLadleInfo.Controls.Add(this.label68);
            this.tabLadleInfo.Controls.Add(this.label70);
            this.tabLadleInfo.Controls.Add(this.label72);
            this.tabLadleInfo.Controls.Add(this.label53);
            this.tabLadleInfo.Controls.Add(this.label54);
            this.tabLadleInfo.Controls.Add(this.label55);
            this.tabLadleInfo.Controls.Add(this.label56);
            this.tabLadleInfo.Controls.Add(this.label57);
            this.tabLadleInfo.Controls.Add(this.label58);
            this.tabLadleInfo.Controls.Add(this.label59);
            this.tabLadleInfo.Controls.Add(this.label60);
            this.tabLadleInfo.Controls.Add(this.pnlLadleInfo);
            this.tabLadleInfo.Location = new System.Drawing.Point(4, 22);
            this.tabLadleInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tabLadleInfo.Name = "tabLadleInfo";
            this.tabLadleInfo.Size = new System.Drawing.Size(1009, 375);
            this.tabLadleInfo.TabIndex = 17;
            this.tabLadleInfo.Text = "钢包信息";
            this.tabLadleInfo.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Wall_Temp", true));
            this.textBox10.Location = new System.Drawing.Point(196, 149);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 107;
            // 
            // bsLadleInfo
            // 
            this.bsLadleInfo.DataMember = "L3DataTable";
            this.bsLadleInfo.DataSource = this.dsLadleInfo;
            // 
            // dsLadleInfo
            // 
            this.dsLadleInfo.AutoLoad = true;
            this.dsLadleInfo.AutoSubscribe = true;
            this.dsLadleInfo.DataSetName = "L3DataSet";
            this.dsLadleInfo.DeleteMethod = "";
            this.dsLadleInfo.InsertMethod = "";
            this.dsLadleInfo.L3DataAdapter = null;
            this.dsLadleInfo.LoadEvent = "";
            this.dsLadleInfo.LoadTrigger = null;
            this.dsLadleInfo.RefreshValve = 1000;
            this.dsLadleInfo.SourceCommand = null;
            this.dsLadleInfo.SourceCondition = "1=2";
            this.dsLadleInfo.SourceMethod = "";
            this.dsLadleInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleInfo.SourceURI = "XGMESLogic\\LFMag\\CLF_Ladle_Info";
            this.dsLadleInfo.SubscribeTarget = "";
            this.dsLadleInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleInfo});
            this.dsLadleInfo.UpdateEvent = "";
            this.dsLadleInfo.UpdateMethod = "";
            this.dsLadleInfo.UpdateTrigger = null;
            // 
            // schemadsLadleInfo
            // 
            this.schemadsLadleInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleInfoL3DataTableTreatNo,
            this.coldsLadleInfoL3DataTableHeatID,
            this.coldsLadleInfoL3DataTableLadleID,
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade,
            this.coldsLadleInfoL3DataTableTemp,
            this.coldsLadleInfoL3DataTableLast_SteelGrade,
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade,
            this.coldsLadleInfoL3DataTableCur_SteelGrade,
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade,
            this.coldsLadleInfoL3DataTableStop_Time_Len,
            this.coldsLadleInfoL3DataTableLadle_Age,
            this.coldsLadleInfoL3DataTableSmall_Fire,
            this.coldsLadleInfoL3DataTableMiddle_Fire,
            this.coldsLadleInfoL3DataTableBig_Fire,
            this.coldsLadleInfoL3DataTableNote,
            this.coldsLadleInfoL3DataTableOther1,
            this.coldsLadleInfoL3DataTableOther2,
            this.coldsLadleInfoL3DataTableOther3,
            this.coldsLadleInfoL3DataTableMaxTemp,
            this.coldsLadleInfoL3DataTableWall_Temp});
            this.schemadsLadleInfo.TableName = "L3DataTable";
            // 
            // coldsLadleInfoL3DataTableTreatNo
            // 
            this.coldsLadleInfoL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsLadleInfoL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsLadleInfoL3DataTableTreatNo.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableHeatID
            // 
            this.coldsLadleInfoL3DataTableHeatID.Caption = "HeatID";
            this.coldsLadleInfoL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsLadleInfoL3DataTableHeatID.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLadleID
            // 
            this.coldsLadleInfoL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleInfoL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleInfoL3DataTableLadleID.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLast_Ladle_Grade
            // 
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade.Caption = "Last_Ladle_Grade";
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade.ColumnName = "Last_Ladle_Grade";
            this.coldsLadleInfoL3DataTableLast_Ladle_Grade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableTemp
            // 
            this.coldsLadleInfoL3DataTableTemp.Caption = "Temp";
            this.coldsLadleInfoL3DataTableTemp.ColumnName = "Temp";
            this.coldsLadleInfoL3DataTableTemp.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableTemp.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLast_SteelGrade
            // 
            this.coldsLadleInfoL3DataTableLast_SteelGrade.Caption = "Last_SteelGrade";
            this.coldsLadleInfoL3DataTableLast_SteelGrade.ColumnName = "Last_SteelGrade";
            this.coldsLadleInfoL3DataTableLast_SteelGrade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableAct_Ladle_Grade
            // 
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade.Caption = "Act_Ladle_Grade";
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade.ColumnName = "Act_Ladle_Grade";
            this.coldsLadleInfoL3DataTableAct_Ladle_Grade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableCur_SteelGrade
            // 
            this.coldsLadleInfoL3DataTableCur_SteelGrade.Caption = "Cur_SteelGrade";
            this.coldsLadleInfoL3DataTableCur_SteelGrade.ColumnName = "Cur_SteelGrade";
            this.coldsLadleInfoL3DataTableCur_SteelGrade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableIn_Ladle_Grade
            // 
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade.Caption = "In_Ladle_Grade";
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade.ColumnName = "In_Ladle_Grade";
            this.coldsLadleInfoL3DataTableIn_Ladle_Grade.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableStop_Time_Len
            // 
            this.coldsLadleInfoL3DataTableStop_Time_Len.Caption = "Stop_Time_Len";
            this.coldsLadleInfoL3DataTableStop_Time_Len.ColumnName = "Stop_Time_Len";
            this.coldsLadleInfoL3DataTableStop_Time_Len.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableStop_Time_Len.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableLadle_Age
            // 
            this.coldsLadleInfoL3DataTableLadle_Age.Caption = "Ladle_Age";
            this.coldsLadleInfoL3DataTableLadle_Age.ColumnName = "Ladle_Age";
            this.coldsLadleInfoL3DataTableLadle_Age.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableLadle_Age.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableSmall_Fire
            // 
            this.coldsLadleInfoL3DataTableSmall_Fire.Caption = "Small_Fire";
            this.coldsLadleInfoL3DataTableSmall_Fire.ColumnName = "Small_Fire";
            this.coldsLadleInfoL3DataTableSmall_Fire.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableSmall_Fire.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableMiddle_Fire
            // 
            this.coldsLadleInfoL3DataTableMiddle_Fire.Caption = "Middle_Fire";
            this.coldsLadleInfoL3DataTableMiddle_Fire.ColumnName = "Middle_Fire";
            this.coldsLadleInfoL3DataTableMiddle_Fire.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableMiddle_Fire.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableBig_Fire
            // 
            this.coldsLadleInfoL3DataTableBig_Fire.Caption = "Big_Fire";
            this.coldsLadleInfoL3DataTableBig_Fire.ColumnName = "Big_Fire";
            this.coldsLadleInfoL3DataTableBig_Fire.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableBig_Fire.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableNote
            // 
            this.coldsLadleInfoL3DataTableNote.Caption = "Note";
            this.coldsLadleInfoL3DataTableNote.ColumnName = "Note";
            this.coldsLadleInfoL3DataTableNote.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableOther1
            // 
            this.coldsLadleInfoL3DataTableOther1.Caption = "Other1";
            this.coldsLadleInfoL3DataTableOther1.ColumnName = "Other1";
            this.coldsLadleInfoL3DataTableOther1.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableOther2
            // 
            this.coldsLadleInfoL3DataTableOther2.Caption = "Other2";
            this.coldsLadleInfoL3DataTableOther2.ColumnName = "Other2";
            this.coldsLadleInfoL3DataTableOther2.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableOther3
            // 
            this.coldsLadleInfoL3DataTableOther3.Caption = "Other3";
            this.coldsLadleInfoL3DataTableOther3.ColumnName = "Other3";
            this.coldsLadleInfoL3DataTableOther3.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableMaxTemp
            // 
            this.coldsLadleInfoL3DataTableMaxTemp.Caption = "MaxTemp";
            this.coldsLadleInfoL3DataTableMaxTemp.ColumnName = "MaxTemp";
            this.coldsLadleInfoL3DataTableMaxTemp.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableMaxTemp.Namespace = "";
            // 
            // coldsLadleInfoL3DataTableWall_Temp
            // 
            this.coldsLadleInfoL3DataTableWall_Temp.Caption = "Wall_Temp";
            this.coldsLadleInfoL3DataTableWall_Temp.ColumnName = "Wall_Temp";
            this.coldsLadleInfoL3DataTableWall_Temp.DataType = typeof(int);
            this.coldsLadleInfoL3DataTableWall_Temp.Namespace = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 12);
            this.label15.TabIndex = 106;
            this.label15.Text = "出钢前包壁温度:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Note", true));
            this.richTextBox1.Location = new System.Drawing.Point(196, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(554, 96);
            this.richTextBox1.TabIndex = 105;
            this.richTextBox1.Text = "";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Act_Ladle_Grade", true));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox3.Location = new System.Drawing.Point(426, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 20);
            this.comboBox3.TabIndex = 104;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "In_Ladle_Grade", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox2.Location = new System.Drawing.Point(426, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 20);
            this.comboBox2.TabIndex = 104;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Last_Ladle_Grade", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D"});
            this.comboBox1.Location = new System.Drawing.Point(196, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 104;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Big_Fire", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox7.Location = new System.Drawing.Point(650, 123);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 21);
            this.textBox7.TabIndex = 103;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Middle_Fire", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox6.Location = new System.Drawing.Point(650, 97);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 21);
            this.textBox6.TabIndex = 103;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Small_Fire", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox5.Location = new System.Drawing.Point(650, 71);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 103;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Stop_Time_Len", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox4.Location = new System.Drawing.Point(650, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 103;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Ladle_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox3.Location = new System.Drawing.Point(426, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 103;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "MaxTemp", true));
            this.textBox9.Location = new System.Drawing.Point(426, 123);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 103;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Temp", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.textBox2.Location = new System.Drawing.Point(196, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 103;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "Last_SteelGrade", true));
            this.textBox8.Location = new System.Drawing.Point(196, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 103;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLadleInfo, "LadleID", true));
            this.textBox1.Location = new System.Drawing.Point(196, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 103;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 101;
            this.label14.Text = "上次转包温降:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(113, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 12);
            this.label22.TabIndex = 101;
            this.label22.Text = "上次20\'温降:";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(131, 101);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(59, 12);
            this.label68.TabIndex = 102;
            this.label68.Text = "上次包况:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(107, 74);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(83, 12);
            this.label70.TabIndex = 99;
            this.label70.Text = "上次使用钢种:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(143, 48);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(47, 12);
            this.label72.TabIndex = 100;
            this.label72.Text = "钢包号:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(361, 48);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(59, 12);
            this.label53.TabIndex = 94;
            this.label53.Text = "进站包况:";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(131, 178);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(59, 12);
            this.label54.TabIndex = 93;
            this.label54.Text = "钢包备注:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(337, 74);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(83, 12);
            this.label55.TabIndex = 95;
            this.label55.Text = "当前钢包状况:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(361, 101);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(59, 12);
            this.label56.TabIndex = 98;
            this.label56.Text = "钢包包龄:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(555, 127);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(89, 12);
            this.label57.TabIndex = 97;
            this.label57.Text = "大火时间[min]:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(555, 101);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(89, 12);
            this.label58.TabIndex = 96;
            this.label58.Text = "中火时间[min]:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(555, 75);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(89, 12);
            this.label59.TabIndex = 91;
            this.label59.Text = "小火时间[min]:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(555, 49);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(89, 12);
            this.label60.TabIndex = 92;
            this.label60.Text = "停用时长[min]:";
            // 
            // pnlLadleInfo
            // 
            this.pnlLadleInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLadleInfo.Controls.Add(this.btnLadleInfoCancel);
            this.pnlLadleInfo.Controls.Add(this.btnLadleInfoOK);
            this.pnlLadleInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLadleInfo.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlLadleInfo.Location = new System.Drawing.Point(0, 340);
            this.pnlLadleInfo.Name = "pnlLadleInfo";
            this.pnlLadleInfo.Size = new System.Drawing.Size(1007, 33);
            this.pnlLadleInfo.TabIndex = 90;
            // 
            // btnLadleInfoCancel
            // 
            this.btnLadleInfoCancel.Location = new System.Drawing.Point(925, 3);
            this.btnLadleInfoCancel.Name = "btnLadleInfoCancel";
            this.btnLadleInfoCancel.Size = new System.Drawing.Size(75, 23);
            this.btnLadleInfoCancel.TabIndex = 87;
            this.btnLadleInfoCancel.Text = "取消";
            this.btnLadleInfoCancel.UseVisualStyleBackColor = true;
            this.btnLadleInfoCancel.Click += new System.EventHandler(this.btnLadleInfoCancel_Click);
            // 
            // tabExcept
            // 
            this.tabExcept.Controls.Add(this.dvExcept);
            this.tabExcept.Controls.Add(this.fLPExcept);
            this.tabExcept.Controls.Add(this.bdExcept);
            this.tabExcept.Location = new System.Drawing.Point(4, 22);
            this.tabExcept.Margin = new System.Windows.Forms.Padding(0);
            this.tabExcept.Name = "tabExcept";
            this.tabExcept.Size = new System.Drawing.Size(1009, 375);
            this.tabExcept.TabIndex = 16;
            this.tabExcept.Text = "炉次工艺异常";
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
            this.exceptionalCodeDataGridViewTextBoxColumn,
            this.iDObjectDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn12,
            this.processCountDataGridViewTextBoxColumn,
            this.unitTypeIDDataGridViewTextBoxColumn1,
            this.unitIDDataGridViewTextBoxColumn1,
            this.preHeatIDDataGridViewTextBoxColumn,
            this.preSteelGradeIndexDataGridViewTextBoxColumn,
            this.steelGradeIndexDataGridViewTextBoxColumn,
            this.exceptionalTimeDataGridViewTextBoxColumn});
            this.dvExcept.DataSource = this.bsExcept;
            this.dvExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvExcept.Location = new System.Drawing.Point(0, 25);
            this.dvExcept.Name = "dvExcept";
            this.dvExcept.RowTemplate.Height = 23;
            this.dvExcept.Size = new System.Drawing.Size(1009, 317);
            this.dvExcept.TabIndex = 91;
            this.dvExcept.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
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
            this.dsExceptCode.SourceCondition = "Unit=\'4\'";
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
            this.coldsExceptCodeL3DataTableExceptional_Code,
            this.coldsExceptCodeL3DataTableExceptional_Des,
            this.coldsExceptCodeL3DataTableUnit});
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
            // exceptionalTimeDataGridViewTextBoxColumn
            // 
            this.exceptionalTimeDataGridViewTextBoxColumn.DataPropertyName = "Exceptional_Time";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.exceptionalTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.fLPExcept.Location = new System.Drawing.Point(0, 342);
            this.fLPExcept.Name = "fLPExcept";
            this.fLPExcept.Size = new System.Drawing.Size(1009, 33);
            this.fLPExcept.TabIndex = 90;
            // 
            // btnCancelExcept
            // 
            this.btnCancelExcept.Location = new System.Drawing.Point(927, 3);
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
            this.toolStripSeparator22,
            this.toolStripLabel8,
            this.txtExcept});
            this.bdExcept.Location = new System.Drawing.Point(0, 0);
            this.bdExcept.MoveFirstItem = this.bindingNavigatorMoveFirstItem7;
            this.bdExcept.MoveLastItem = this.bindingNavigatorMoveLastItem7;
            this.bdExcept.MoveNextItem = this.bindingNavigatorMoveNextItem7;
            this.bdExcept.MovePreviousItem = this.bindingNavigatorMovePreviousItem7;
            this.bdExcept.Name = "bdExcept";
            this.bdExcept.PositionItem = this.bindingNavigatorPositionItem7;
            this.bdExcept.Size = new System.Drawing.Size(1009, 25);
            this.bdExcept.TabIndex = 0;
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
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel8.Text = "  异常代码维护:";
            // 
            // txtExcept
            // 
            this.txtExcept.Name = "txtExcept";
            this.txtExcept.Size = new System.Drawing.Size(160, 25);
            this.txtExcept.Leave += new System.EventHandler(this.txtExcept_Leave);
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
            this.tabChemical.Size = new System.Drawing.Size(1009, 375);
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
            this.heatIDDataGridViewTextBoxColumn5,
            this.unitTypeIDDataGridViewTextBoxColumn,
            this.sampleAddressDataGridViewTextBoxColumn,
            this.sampleTypeDataGridViewTextBoxColumn,
            this.dataLogModeDataGridViewTextBoxColumn,
            this.appIDDataGridViewTextBoxColumn,
            this.sampleCodeDataGridViewTextBoxColumn,
            this.arriveDateDataGridViewTextBoxColumn,
            this.reportDateDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
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
            this.logTimeDataGridViewTextBoxColumn1});
            this.dvChemical.DataSource = this.bsChemical;
            this.dvChemical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvChemical.Location = new System.Drawing.Point(3, 28);
            this.dvChemical.Name = "dvChemical";
            this.dvChemical.RowTemplate.Height = 23;
            this.dvChemical.Size = new System.Drawing.Size(1001, 309);
            this.dvChemical.TabIndex = 101;
            this.dvChemical.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvChemical_DataBindingComplete);
            this.dvChemical.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn5
            // 
            this.heatIDDataGridViewTextBoxColumn5.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn5.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn5.Name = "heatIDDataGridViewTextBoxColumn5";
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
            dataGridViewCellStyle4.Format = "G";
            this.arriveDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.arriveDateDataGridViewTextBoxColumn.HeaderText = "到样时间";
            this.arriveDateDataGridViewTextBoxColumn.Name = "arriveDateDataGridViewTextBoxColumn";
            this.arriveDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.arriveDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // reportDateDataGridViewTextBoxColumn
            // 
            this.reportDateDataGridViewTextBoxColumn.DataPropertyName = "Report_Date";
            dataGridViewCellStyle5.Format = "G";
            this.reportDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.reportDateDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.reportDateDataGridViewTextBoxColumn.Name = "reportDateDataGridViewTextBoxColumn";
            this.reportDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reportDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "工位";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
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
            // logTimeDataGridViewTextBoxColumn1
            // 
            this.logTimeDataGridViewTextBoxColumn1.DataPropertyName = "LogTime";
            dataGridViewCellStyle6.Format = "G";
            this.logTimeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.logTimeDataGridViewTextBoxColumn1.HeaderText = "数据记录时间";
            this.logTimeDataGridViewTextBoxColumn1.Name = "logTimeDataGridViewTextBoxColumn1";
            this.logTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn1.Width = 130;
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
            this.coldsChemicalL3DataTableDataLogMode,
            this.coldsChemicalL3DataTableCrNi,
            this.coldsChemicalL3DataTableCrCu,
            this.coldsChemicalL3DataTableCrNiCu,
            this.coldsChemicalL3DataTableOther3});
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
            this.bnChemical.Size = new System.Drawing.Size(1001, 25);
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
            this.btnAddChemical.Visible = false;
            this.btnAddChemical.Click += new System.EventHandler(this.btnAddChemical_Click);
            // 
            // pnlChemical
            // 
            this.pnlChemical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChemical.Controls.Add(this.btnChemicalCancel);
            this.pnlChemical.Controls.Add(this.btnChemicalOK);
            this.pnlChemical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChemical.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlChemical.Location = new System.Drawing.Point(3, 337);
            this.pnlChemical.Name = "pnlChemical";
            this.pnlChemical.Size = new System.Drawing.Size(1001, 33);
            this.pnlChemical.TabIndex = 90;
            // 
            // btnChemicalCancel
            // 
            this.btnChemicalCancel.Location = new System.Drawing.Point(919, 3);
            this.btnChemicalCancel.Name = "btnChemicalCancel";
            this.btnChemicalCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChemicalCancel.TabIndex = 87;
            this.btnChemicalCancel.Text = "取消";
            this.btnChemicalCancel.UseVisualStyleBackColor = true;
            this.btnChemicalCancel.Click += new System.EventHandler(this.btnChemicalCancel_Click);
            // 
            // btnChemicalOK
            // 
            this.btnChemicalOK.Location = new System.Drawing.Point(838, 3);
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
            this.tabStatus.Size = new System.Drawing.Size(1009, 375);
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
            this.treatNoDataGridViewTextBoxColumn1,
            this.heatIDDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.changeTimeDataGridViewTextBoxColumn,
            this.Gears,
            this.Hot_Length_Cur,
            this.Hot_Length_Total});
            this.dvStatus.DataSource = this.bsStatus;
            this.dvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvStatus.Location = new System.Drawing.Point(3, 28);
            this.dvStatus.Name = "dvStatus";
            this.dvStatus.RowTemplate.Height = 23;
            this.dvStatus.Size = new System.Drawing.Size(1001, 309);
            this.dvStatus.TabIndex = 103;
            this.dvStatus.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvStatus_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn1
            // 
            this.treatNoDataGridViewTextBoxColumn1.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn1.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn1.Name = "treatNoDataGridViewTextBoxColumn1";
            // 
            // heatIDDataGridViewTextBoxColumn1
            // 
            this.heatIDDataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn1.Name = "heatIDDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsLFStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsLFStatus
            // 
            this.dsLFStatus.AutoLoad = true;
            this.dsLFStatus.AutoSubscribe = false;
            this.dsLFStatus.DataSetName = "L3DataSet";
            this.dsLFStatus.DeleteMethod = null;
            this.dsLFStatus.InsertMethod = null;
            this.dsLFStatus.L3DataAdapter = this.Adapter;
            this.dsLFStatus.LoadEvent = "Click";
            this.dsLFStatus.LoadTrigger = null;
            this.dsLFStatus.RefreshValve = 1000;
            this.dsLFStatus.SourceCommand = null;
            this.dsLFStatus.SourceCondition = "CODE_GROUP = \'LFUnitStatus\' and code is not null order by code";
            this.dsLFStatus.SourceMethod = "";
            this.dsLFStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLFStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLFStatus.SubscribeTarget = null;
            this.dsLFStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLFStatus});
            this.dsLFStatus.UpdateEvent = "Click";
            this.dsLFStatus.UpdateMethod = null;
            this.dsLFStatus.UpdateTrigger = null;
            // 
            // schemadsLFStatus
            // 
            this.schemadsLFStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLFStatusL3DataTableCode_Des,
            this.coldsLFStatusL3DataTableCode_Val_Long});
            this.schemadsLFStatus.TableName = "L3DataTable";
            // 
            // coldsLFStatusL3DataTableCode_Des
            // 
            this.coldsLFStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLFStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLFStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsLFStatusL3DataTableCode_Val_Long
            // 
            this.coldsLFStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsLFStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsLFStatusL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsLFStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // changeTimeDataGridViewTextBoxColumn
            // 
            this.changeTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.changeTimeDataGridViewTextBoxColumn.DataPropertyName = "Change_Time";
            dataGridViewCellStyle7.Format = "G";
            this.changeTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.changeTimeDataGridViewTextBoxColumn.HeaderText = "状态变化时刻";
            this.changeTimeDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.changeTimeDataGridViewTextBoxColumn.Name = "changeTimeDataGridViewTextBoxColumn";
            this.changeTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Gears
            // 
            this.Gears.DataPropertyName = "Gears";
            this.Gears.HeaderText = "加热档位";
            this.Gears.MinimumWidth = 50;
            this.Gears.Name = "Gears";
            this.Gears.ReadOnly = true;
            // 
            // Hot_Length_Cur
            // 
            this.Hot_Length_Cur.DataPropertyName = "Hot_Length_Cur";
            this.Hot_Length_Cur.HeaderText = "分段加热时间[min]";
            this.Hot_Length_Cur.MinimumWidth = 150;
            this.Hot_Length_Cur.Name = "Hot_Length_Cur";
            this.Hot_Length_Cur.ReadOnly = true;
            this.Hot_Length_Cur.Width = 150;
            // 
            // Hot_Length_Total
            // 
            this.Hot_Length_Total.DataPropertyName = "Hot_Length_Total";
            this.Hot_Length_Total.HeaderText = "累计加热时间[min]";
            this.Hot_Length_Total.MinimumWidth = 150;
            this.Hot_Length_Total.Name = "Hot_Length_Total";
            this.Hot_Length_Total.ReadOnly = true;
            this.Hot_Length_Total.Width = 150;
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
            this.dsStatus.SourceURI = "XGMESLogic\\LFMag\\CLF_Process_Satus";
            this.dsStatus.SubscribeTarget = null;
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = null;
            this.dsStatus.UpdateTrigger = null;
            this.dsStatus.OnDataLoaded += new AppSvrHMI.Delegate_OnDataLoaded(this.dsStatus_OnDataLoaded);
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableName,
            this.coll3DataSet1L3DataTableTreatNo,
            this.coll3DataSet1L3DataTableHeatID,
            this.coll3DataSet1L3DataTableStatus,
            this.coll3DataSet1L3DataTableChange_Time,
            this.coldsStatusL3DataTableGears,
            this.coldsStatusL3DataTableHot_Length_Cur,
            this.coldsStatusL3DataTableHot_Length_Total});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableGUID
            // 
            this.coll3DataSet1L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet1L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet1L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableName
            // 
            this.coll3DataSet1L3DataTableName.Caption = "Name";
            this.coll3DataSet1L3DataTableName.ColumnName = "Name";
            this.coll3DataSet1L3DataTableName.Namespace = "";
            // 
            // coll3DataSet1L3DataTableTreatNo
            // 
            this.coll3DataSet1L3DataTableTreatNo.Caption = "TreatNo";
            this.coll3DataSet1L3DataTableTreatNo.ColumnName = "TreatNo";
            this.coll3DataSet1L3DataTableTreatNo.Namespace = "";
            // 
            // coll3DataSet1L3DataTableHeatID
            // 
            this.coll3DataSet1L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableStatus
            // 
            this.coll3DataSet1L3DataTableStatus.Caption = "Status";
            this.coll3DataSet1L3DataTableStatus.ColumnName = "Status";
            this.coll3DataSet1L3DataTableStatus.DataType = typeof(short);
            this.coll3DataSet1L3DataTableStatus.Namespace = "";
            // 
            // coll3DataSet1L3DataTableChange_Time
            // 
            this.coll3DataSet1L3DataTableChange_Time.Caption = "Change_Time";
            this.coll3DataSet1L3DataTableChange_Time.ColumnName = "Change_Time";
            this.coll3DataSet1L3DataTableChange_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableChange_Time.Namespace = "";
            // 
            // coldsStatusL3DataTableGears
            // 
            this.coldsStatusL3DataTableGears.Caption = "Gears";
            this.coldsStatusL3DataTableGears.ColumnName = "Gears";
            this.coldsStatusL3DataTableGears.DataType = typeof(int);
            this.coldsStatusL3DataTableGears.DefaultValue = 0;
            this.coldsStatusL3DataTableGears.Namespace = "";
            // 
            // coldsStatusL3DataTableHot_Length_Cur
            // 
            this.coldsStatusL3DataTableHot_Length_Cur.Caption = "Hot_Length_Cur";
            this.coldsStatusL3DataTableHot_Length_Cur.ColumnName = "Hot_Length_Cur";
            this.coldsStatusL3DataTableHot_Length_Cur.DataType = typeof(decimal);
            this.coldsStatusL3DataTableHot_Length_Cur.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.coldsStatusL3DataTableHot_Length_Cur.Namespace = "";
            // 
            // coldsStatusL3DataTableHot_Length_Total
            // 
            this.coldsStatusL3DataTableHot_Length_Total.Caption = "Hot_Length_Total";
            this.coldsStatusL3DataTableHot_Length_Total.ColumnName = "Hot_Length_Total";
            this.coldsStatusL3DataTableHot_Length_Total.DataType = typeof(decimal);
            this.coldsStatusL3DataTableHot_Length_Total.DefaultValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.coldsStatusL3DataTableHot_Length_Total.Namespace = "";
            // 
            // bnStatus
            // 
            this.bnStatus.AddNewItem = null;
            this.bnStatus.BindingSource = this.bsStatus;
            this.bnStatus.CountItem = this.toolStripLabel7;
            this.bnStatus.DeleteItem = null;
            this.bnStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton6,
            this.toolStripButton11,
            this.toolStripSeparator19,
            this.toolStripTextBox7,
            this.toolStripLabel7,
            this.toolStripSeparator20,
            this.toolStripButton16,
            this.toolStripButton21,
            this.toolStripSeparator21,
            this.btnAddStatus});
            this.bnStatus.Location = new System.Drawing.Point(3, 3);
            this.bnStatus.MoveFirstItem = this.toolStripButton6;
            this.bnStatus.MoveLastItem = this.toolStripButton21;
            this.bnStatus.MoveNextItem = this.toolStripButton16;
            this.bnStatus.MovePreviousItem = this.toolStripButton11;
            this.bnStatus.Name = "bnStatus";
            this.bnStatus.PositionItem = this.toolStripTextBox7;
            this.bnStatus.Size = new System.Drawing.Size(1001, 25);
            this.bnStatus.TabIndex = 101;
            this.bnStatus.Text = "bindingNavigator4";
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel7.Text = "/ {0}";
            this.toolStripLabel7.ToolTipText = "总项数";
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
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "移到上一条记录";
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
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "移到下一条记录";
            // 
            // toolStripButton21
            // 
            this.toolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton21.Image")));
            this.toolStripButton21.Name = "toolStripButton21";
            this.toolStripButton21.RightToLeftAutoMirrorImage = true;
            this.toolStripButton21.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton21.Text = "移到最后一条记录";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStatus.Image")));
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.RightToLeftAutoMirrorImage = true;
            this.btnAddStatus.Size = new System.Drawing.Size(23, 22);
            this.btnAddStatus.Text = "新添";
            this.btnAddStatus.Visible = false;
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatus.Controls.Add(this.btnStatusCancel);
            this.pnlStatus.Controls.Add(this.btnStatusOK);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlStatus.Location = new System.Drawing.Point(3, 337);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1001, 33);
            this.pnlStatus.TabIndex = 91;
            // 
            // btnStatusCancel
            // 
            this.btnStatusCancel.Location = new System.Drawing.Point(919, 3);
            this.btnStatusCancel.Name = "btnStatusCancel";
            this.btnStatusCancel.Size = new System.Drawing.Size(75, 23);
            this.btnStatusCancel.TabIndex = 87;
            this.btnStatusCancel.Text = "取消";
            this.btnStatusCancel.UseVisualStyleBackColor = true;
            this.btnStatusCancel.Click += new System.EventHandler(this.btnStatusCancel_Click);
            // 
            // btnStatusOK
            // 
            this.btnStatusOK.Location = new System.Drawing.Point(838, 3);
            this.btnStatusOK.Name = "btnStatusOK";
            this.btnStatusOK.Size = new System.Drawing.Size(75, 23);
            this.btnStatusOK.TabIndex = 86;
            this.btnStatusOK.Text = "确认";
            this.btnStatusOK.UseVisualStyleBackColor = true;
            this.btnStatusOK.Click += new System.EventHandler(this.btnStatusOK_Click);
            // 
            // tabTemp
            // 
            this.tabTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTemp.Controls.Add(this.hmiRootPanel6);
            this.tabTemp.Location = new System.Drawing.Point(4, 22);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemp.Size = new System.Drawing.Size(1009, 375);
            this.tabTemp.TabIndex = 9;
            this.tabTemp.Text = "测温数据";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel6
            // 
            this.hmiRootPanel6.Controls.Add(this.dvTemp);
            this.hmiRootPanel6.Controls.Add(this.bnTemp);
            this.hmiRootPanel6.Controls.Add(this.pnlTemp);
            this.hmiRootPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel6.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel6.Name = "hmiRootPanel6";
            this.hmiRootPanel6.Size = new System.Drawing.Size(1001, 367);
            this.hmiRootPanel6.TabIndex = 0;
            // 
            // dvTemp
            // 
            this.dvTemp.AllowUserToAddRows = false;
            this.dvTemp.AllowUserToDeleteRows = false;
            this.dvTemp.AutoGenerateColumns = false;
            this.dvTemp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn2,
            this.heatIDDataGridViewTextBoxColumn2,
            this.modeDataGridViewCheckBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn});
            this.dvTemp.DataSource = this.bsTemp;
            this.dvTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTemp.Location = new System.Drawing.Point(0, 25);
            this.dvTemp.Name = "dvTemp";
            this.dvTemp.RowTemplate.Height = 23;
            this.dvTemp.Size = new System.Drawing.Size(1001, 309);
            this.dvTemp.TabIndex = 100;
            this.dvTemp.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn2
            // 
            this.treatNoDataGridViewTextBoxColumn2.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn2.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn2.Name = "treatNoDataGridViewTextBoxColumn2";
            // 
            // heatIDDataGridViewTextBoxColumn2
            // 
            this.heatIDDataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn2.Name = "heatIDDataGridViewTextBoxColumn2";
            // 
            // modeDataGridViewCheckBoxColumn
            // 
            this.modeDataGridViewCheckBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewCheckBoxColumn.DataSource = this.dsBOFTempMode;
            this.modeDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.modeDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.modeDataGridViewCheckBoxColumn.HeaderText = "测温模式";
            this.modeDataGridViewCheckBoxColumn.Name = "modeDataGridViewCheckBoxColumn";
            this.modeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.modeDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            this.modeDataGridViewCheckBoxColumn.Width = 160;
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
            this.dsBOFTempMode.SourceCondition = "CODE_GROUP = \'LF_TEMP_MODE\' and code is not null order by code";
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
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "测温值";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // measureTimeDataGridViewTextBoxColumn
            // 
            this.measureTimeDataGridViewTextBoxColumn.DataPropertyName = "MeasureTime";
            dataGridViewCellStyle8.Format = "G";
            this.measureTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.measureTimeDataGridViewTextBoxColumn.HeaderText = "测温时刻";
            this.measureTimeDataGridViewTextBoxColumn.Name = "measureTimeDataGridViewTextBoxColumn";
            this.measureTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTimeDataGridViewTextBoxColumn.Width = 130;
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
            this.dsTemp.SourceCondition = null;
            this.dsTemp.SourceMethod = "";
            this.dsTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTemp.SourceURI = "XGMESLogic\\LFMag\\CLF_Temp_Data";
            this.dsTemp.SubscribeTarget = null;
            this.dsTemp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet5});
            this.dsTemp.UpdateEvent = "Click";
            this.dsTemp.UpdateMethod = null;
            this.dsTemp.UpdateTrigger = null;
            // 
            // schemal3DataSet5
            // 
            this.schemal3DataSet5.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet5L3DataTableGUID,
            this.coll3DataSet5L3DataTableName,
            this.coll3DataSet5L3DataTableTreatNo,
            this.coll3DataSet5L3DataTableHeatID,
            this.coll3DataSet5L3DataTableTemperature,
            this.coll3DataSet5L3DataTableMeasureTime,
            this.coll3DataSet5L3DataTableMode});
            this.schemal3DataSet5.TableName = "L3DataTable";
            // 
            // coll3DataSet5L3DataTableGUID
            // 
            this.coll3DataSet5L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet5L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet5L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet5L3DataTableName
            // 
            this.coll3DataSet5L3DataTableName.Caption = "Name";
            this.coll3DataSet5L3DataTableName.ColumnName = "Name";
            this.coll3DataSet5L3DataTableName.Namespace = "";
            // 
            // coll3DataSet5L3DataTableTreatNo
            // 
            this.coll3DataSet5L3DataTableTreatNo.Caption = "TreatNo";
            this.coll3DataSet5L3DataTableTreatNo.ColumnName = "TreatNo";
            this.coll3DataSet5L3DataTableTreatNo.Namespace = "";
            // 
            // coll3DataSet5L3DataTableHeatID
            // 
            this.coll3DataSet5L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet5L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet5L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet5L3DataTableTemperature
            // 
            this.coll3DataSet5L3DataTableTemperature.Caption = "Temperature";
            this.coll3DataSet5L3DataTableTemperature.ColumnName = "Temperature";
            this.coll3DataSet5L3DataTableTemperature.DataType = typeof(int);
            this.coll3DataSet5L3DataTableTemperature.Namespace = "";
            // 
            // coll3DataSet5L3DataTableMeasureTime
            // 
            this.coll3DataSet5L3DataTableMeasureTime.Caption = "MeasureTime";
            this.coll3DataSet5L3DataTableMeasureTime.ColumnName = "MeasureTime";
            this.coll3DataSet5L3DataTableMeasureTime.DataType = typeof(System.DateTime);
            this.coll3DataSet5L3DataTableMeasureTime.Namespace = "";
            // 
            // coll3DataSet5L3DataTableMode
            // 
            this.coll3DataSet5L3DataTableMode.Caption = "Mode";
            this.coll3DataSet5L3DataTableMode.ColumnName = "Mode";
            this.coll3DataSet5L3DataTableMode.DataType = typeof(short);
            this.coll3DataSet5L3DataTableMode.Namespace = "";
            // 
            // bnTemp
            // 
            this.bnTemp.AddNewItem = null;
            this.bnTemp.BindingSource = this.bsTemp;
            this.bnTemp.CountItem = this.toolStripLabel4;
            this.bnTemp.DeleteItem = null;
            this.bnTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator10,
            this.toolStripTextBox4,
            this.toolStripLabel4,
            this.toolStripSeparator11,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator12});
            this.bnTemp.Location = new System.Drawing.Point(0, 0);
            this.bnTemp.MoveFirstItem = this.toolStripButton17;
            this.bnTemp.MoveLastItem = this.toolStripButton20;
            this.bnTemp.MoveNextItem = this.toolStripButton19;
            this.bnTemp.MovePreviousItem = this.toolStripButton18;
            this.bnTemp.Name = "bnTemp";
            this.bnTemp.PositionItem = this.toolStripTextBox4;
            this.bnTemp.Size = new System.Drawing.Size(1001, 25);
            this.bnTemp.TabIndex = 98;
            this.bnTemp.Text = "bindingNavigator4";
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
            // tabOxygen
            // 
            this.tabOxygen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabOxygen.Controls.Add(this.dvOxygen);
            this.tabOxygen.Controls.Add(this.bnOxygen);
            this.tabOxygen.Controls.Add(this.pnlOxygen);
            this.tabOxygen.Location = new System.Drawing.Point(4, 22);
            this.tabOxygen.Name = "tabOxygen";
            this.tabOxygen.Padding = new System.Windows.Forms.Padding(3);
            this.tabOxygen.Size = new System.Drawing.Size(1009, 375);
            this.tabOxygen.TabIndex = 10;
            this.tabOxygen.Text = "定氧数据";
            this.tabOxygen.UseVisualStyleBackColor = true;
            // 
            // dvOxygen
            // 
            this.dvOxygen.AllowUserToAddRows = false;
            this.dvOxygen.AllowUserToDeleteRows = false;
            this.dvOxygen.AutoGenerateColumns = false;
            this.dvOxygen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvOxygen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvOxygen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn3,
            this.heatIDDataGridViewTextBoxColumn3,
            this.oxygenContentDataGridViewTextBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn1});
            this.dvOxygen.DataSource = this.bsOxygen;
            this.dvOxygen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvOxygen.Location = new System.Drawing.Point(3, 28);
            this.dvOxygen.Name = "dvOxygen";
            this.dvOxygen.RowTemplate.Height = 23;
            this.dvOxygen.Size = new System.Drawing.Size(1001, 309);
            this.dvOxygen.TabIndex = 99;
            this.dvOxygen.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn3
            // 
            this.treatNoDataGridViewTextBoxColumn3.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn3.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn3.Name = "treatNoDataGridViewTextBoxColumn3";
            // 
            // heatIDDataGridViewTextBoxColumn3
            // 
            this.heatIDDataGridViewTextBoxColumn3.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn3.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn3.Name = "heatIDDataGridViewTextBoxColumn3";
            // 
            // oxygenContentDataGridViewTextBoxColumn
            // 
            this.oxygenContentDataGridViewTextBoxColumn.DataPropertyName = "Oxygen_Content";
            this.oxygenContentDataGridViewTextBoxColumn.HeaderText = "氧含量";
            this.oxygenContentDataGridViewTextBoxColumn.Name = "oxygenContentDataGridViewTextBoxColumn";
            // 
            // measureTimeDataGridViewTextBoxColumn1
            // 
            this.measureTimeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.measureTimeDataGridViewTextBoxColumn1.DataPropertyName = "Measure_Time";
            dataGridViewCellStyle9.Format = "G";
            this.measureTimeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.measureTimeDataGridViewTextBoxColumn1.HeaderText = "定氧时刻";
            this.measureTimeDataGridViewTextBoxColumn1.Name = "measureTimeDataGridViewTextBoxColumn1";
            this.measureTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bnOxygen
            // 
            this.bnOxygen.AddNewItem = null;
            this.bnOxygen.BindingSource = this.bsOxygen;
            this.bnOxygen.CountItem = this.toolStripLabel3;
            this.bnOxygen.DeleteItem = null;
            this.bnOxygen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton14,
            this.toolStripButton15,
            this.toolStripSeparator9});
            this.bnOxygen.Location = new System.Drawing.Point(3, 3);
            this.bnOxygen.MoveFirstItem = this.toolStripButton12;
            this.bnOxygen.MoveLastItem = this.toolStripButton15;
            this.bnOxygen.MoveNextItem = this.toolStripButton14;
            this.bnOxygen.MovePreviousItem = this.toolStripButton13;
            this.bnOxygen.Name = "bnOxygen";
            this.bnOxygen.PositionItem = this.toolStripTextBox3;
            this.bnOxygen.Size = new System.Drawing.Size(1001, 25);
            this.bnOxygen.TabIndex = 97;
            this.bnOxygen.Text = "bindingNavigator3";
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
            // tabRemark
            // 
            this.tabRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRemark.Controls.Add(this.dvRemark);
            this.tabRemark.Controls.Add(this.bnRemark);
            this.tabRemark.Controls.Add(this.pnlNote);
            this.tabRemark.Location = new System.Drawing.Point(4, 22);
            this.tabRemark.Name = "tabRemark";
            this.tabRemark.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemark.Size = new System.Drawing.Size(1009, 375);
            this.tabRemark.TabIndex = 11;
            this.tabRemark.Text = "记事数据";
            this.tabRemark.UseVisualStyleBackColor = true;
            // 
            // dvRemark
            // 
            this.dvRemark.AllowUserToAddRows = false;
            this.dvRemark.AllowUserToDeleteRows = false;
            this.dvRemark.AutoGenerateColumns = false;
            this.dvRemark.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvRemark.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatNoDataGridViewTextBoxColumn4,
            this.heatIDDataGridViewTextBoxColumn4,
            this.typeDataGridViewCheckBoxColumn1,
            this.logTimeDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dvRemark.DataSource = this.bsRemark;
            this.dvRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvRemark.Location = new System.Drawing.Point(3, 28);
            this.dvRemark.Name = "dvRemark";
            this.dvRemark.RowTemplate.Height = 23;
            this.dvRemark.Size = new System.Drawing.Size(1001, 309);
            this.dvRemark.TabIndex = 97;
            this.dvRemark.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvStatus_DataError);
            // 
            // treatNoDataGridViewTextBoxColumn4
            // 
            this.treatNoDataGridViewTextBoxColumn4.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn4.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn4.Name = "treatNoDataGridViewTextBoxColumn4";
            // 
            // heatIDDataGridViewTextBoxColumn4
            // 
            this.heatIDDataGridViewTextBoxColumn4.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn4.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn4.Name = "heatIDDataGridViewTextBoxColumn4";
            // 
            // typeDataGridViewCheckBoxColumn1
            // 
            this.typeDataGridViewCheckBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn1.DataSource = this.dsRemarkType;
            this.typeDataGridViewCheckBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.typeDataGridViewCheckBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewCheckBoxColumn1.HeaderText = "分类";
            this.typeDataGridViewCheckBoxColumn1.Name = "typeDataGridViewCheckBoxColumn1";
            this.typeDataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewCheckBoxColumn1.ValueMember = "L3DataTable.Code_Val_Long";
            this.typeDataGridViewCheckBoxColumn1.Width = 54;
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
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "LogTime";
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "数据记录时间";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            this.logTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logTimeDataGridViewTextBoxColumn.Width = 130;
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
            this.dsRemark.SourceURI = "XGMESLogic\\LFMag\\CLF_HeatRemark";
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
            this.coldsRemarkL3DataTableTreatNo,
            this.coldsRemarkL3DataTableHeatID,
            this.coldsRemarkL3DataTableType,
            this.coldsRemarkL3DataTableRemark,
            this.coldsRemarkL3DataTableLogTime});
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
            // coldsRemarkL3DataTableTreatNo
            // 
            this.coldsRemarkL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsRemarkL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsRemarkL3DataTableTreatNo.Namespace = "";
            // 
            // coldsRemarkL3DataTableHeatID
            // 
            this.coldsRemarkL3DataTableHeatID.Caption = "HeatID";
            this.coldsRemarkL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsRemarkL3DataTableHeatID.Namespace = "";
            // 
            // coldsRemarkL3DataTableType
            // 
            this.coldsRemarkL3DataTableType.Caption = "Type";
            this.coldsRemarkL3DataTableType.ColumnName = "Type";
            this.coldsRemarkL3DataTableType.DataType = typeof(short);
            this.coldsRemarkL3DataTableType.Namespace = "";
            // 
            // coldsRemarkL3DataTableRemark
            // 
            this.coldsRemarkL3DataTableRemark.Caption = "Remark";
            this.coldsRemarkL3DataTableRemark.ColumnName = "Remark";
            this.coldsRemarkL3DataTableRemark.Namespace = "";
            // 
            // coldsRemarkL3DataTableLogTime
            // 
            this.coldsRemarkL3DataTableLogTime.Caption = "LogTime";
            this.coldsRemarkL3DataTableLogTime.ColumnName = "LogTime";
            this.coldsRemarkL3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coldsRemarkL3DataTableLogTime.Namespace = "";
            // 
            // bnRemark
            // 
            this.bnRemark.AddNewItem = null;
            this.bnRemark.BindingSource = this.bsRemark;
            this.bnRemark.CountItem = this.toolStripLabel2;
            this.bnRemark.DeleteItem = null;
            this.bnRemark.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.btnAddRemark});
            this.bnRemark.Location = new System.Drawing.Point(3, 3);
            this.bnRemark.MoveFirstItem = this.toolStripButton7;
            this.bnRemark.MoveLastItem = this.toolStripButton10;
            this.bnRemark.MoveNextItem = this.toolStripButton9;
            this.bnRemark.MovePreviousItem = this.toolStripButton8;
            this.bnRemark.Name = "bnRemark";
            this.bnRemark.PositionItem = this.toolStripTextBox2;
            this.bnRemark.Size = new System.Drawing.Size(1001, 25);
            this.bnRemark.TabIndex = 96;
            this.bnRemark.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "/ {0}";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到第一条记录";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到上一条记录";
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
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到下一条记录";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "移到最后一条记录";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlNote
            // 
            this.pnlNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlNote.Controls.Add(this.btnNoteCancel);
            this.pnlNote.Controls.Add(this.btnNoteConfirm);
            this.pnlNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNote.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlNote.Location = new System.Drawing.Point(3, 337);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(1001, 33);
            this.pnlNote.TabIndex = 95;
            // 
            // btnNoteCancel
            // 
            this.btnNoteCancel.Location = new System.Drawing.Point(919, 3);
            this.btnNoteCancel.Name = "btnNoteCancel";
            this.btnNoteCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNoteCancel.TabIndex = 87;
            this.btnNoteCancel.Text = "取消";
            this.btnNoteCancel.UseVisualStyleBackColor = true;
            this.btnNoteCancel.Click += new System.EventHandler(this.btnNoteCancel_Click);
            // 
            // tabMidLandleTemp
            // 
            this.tabMidLandleTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMidLandleTemp.Controls.Add(this.dataGridView1);
            this.tabMidLandleTemp.Controls.Add(this.bindingNavigator2);
            this.tabMidLandleTemp.Location = new System.Drawing.Point(4, 22);
            this.tabMidLandleTemp.Name = "tabMidLandleTemp";
            this.tabMidLandleTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabMidLandleTemp.Size = new System.Drawing.Size(1009, 375);
            this.tabMidLandleTemp.TabIndex = 18;
            this.tabMidLandleTemp.Text = "中包温度";
            this.tabMidLandleTemp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn7,
            this.cCMIDDataGridViewTextBoxColumn,
            this.tempIDDataGridViewTextBoxColumn,
            this.tempDataGridViewTextBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn2,
            this.inValidFlagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsTundishTemp;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 342);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn7
            // 
            this.heatIDDataGridViewTextBoxColumn7.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn7.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn7.Name = "heatIDDataGridViewTextBoxColumn7";
            // 
            // cCMIDDataGridViewTextBoxColumn
            // 
            this.cCMIDDataGridViewTextBoxColumn.DataPropertyName = "CCMID";
            this.cCMIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.cCMIDDataGridViewTextBoxColumn.Name = "cCMIDDataGridViewTextBoxColumn";
            // 
            // tempIDDataGridViewTextBoxColumn
            // 
            this.tempIDDataGridViewTextBoxColumn.DataPropertyName = "TempID";
            this.tempIDDataGridViewTextBoxColumn.DataSource = this.dsCCMTempMode;
            this.tempIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tempIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tempIDDataGridViewTextBoxColumn.HeaderText = "测温模式";
            this.tempIDDataGridViewTextBoxColumn.Name = "tempIDDataGridViewTextBoxColumn";
            this.tempIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tempIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tempIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
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
            this.coldsCCMTempModeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsCCMTempModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // tempDataGridViewTextBoxColumn
            // 
            this.tempDataGridViewTextBoxColumn.DataPropertyName = "Temp";
            this.tempDataGridViewTextBoxColumn.HeaderText = "测温值";
            this.tempDataGridViewTextBoxColumn.Name = "tempDataGridViewTextBoxColumn";
            // 
            // measureTimeDataGridViewTextBoxColumn2
            // 
            this.measureTimeDataGridViewTextBoxColumn2.DataPropertyName = "Measure_Time";
            this.measureTimeDataGridViewTextBoxColumn2.HeaderText = "测温时刻";
            this.measureTimeDataGridViewTextBoxColumn2.Name = "measureTimeDataGridViewTextBoxColumn2";
            this.measureTimeDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTimeDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // inValidFlagDataGridViewTextBoxColumn
            // 
            this.inValidFlagDataGridViewTextBoxColumn.DataPropertyName = "InValidFlag";
            this.inValidFlagDataGridViewTextBoxColumn.HeaderText = "是否有效";
            this.inValidFlagDataGridViewTextBoxColumn.Name = "inValidFlagDataGridViewTextBoxColumn";
            // 
            // bsTundishTemp
            // 
            this.bsTundishTemp.DataMember = "L3DataTable";
            this.bsTundishTemp.DataSource = this.dsTundishTemp;
            // 
            // dsTundishTemp
            // 
            this.dsTundishTemp.AutoLoad = true;
            this.dsTundishTemp.AutoSubscribe = false;
            this.dsTundishTemp.DataSetName = "L3DataSet";
            this.dsTundishTemp.DeleteMethod = null;
            this.dsTundishTemp.InsertMethod = null;
            this.dsTundishTemp.L3DataAdapter = null;
            this.dsTundishTemp.LoadEvent = "Click";
            this.dsTundishTemp.LoadTrigger = null;
            this.dsTundishTemp.RefreshValve = 1000;
            this.dsTundishTemp.SourceCommand = null;
            this.dsTundishTemp.SourceCondition = "1=2";
            this.dsTundishTemp.SourceMethod = "";
            this.dsTundishTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishTemp.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Heat_TundishTemp";
            this.dsTundishTemp.SubscribeTarget = null;
            this.dsTundishTemp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundishTemp});
            this.dsTundishTemp.UpdateEvent = "Click";
            this.dsTundishTemp.UpdateMethod = null;
            this.dsTundishTemp.UpdateTrigger = null;
            // 
            // schemadsTundishTemp
            // 
            this.schemadsTundishTemp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishTempL3DataTableGUID,
            this.coldsTundishTempL3DataTableName,
            this.coldsTundishTempL3DataTableHeatID,
            this.coldsTundishTempL3DataTableCCMID,
            this.coldsTundishTempL3DataTableTempID,
            this.coldsTundishTempL3DataTableTemp,
            this.coldsTundishTempL3DataTableMeasure_Time,
            this.coldsTundishTempL3DataTableInValidFlag});
            this.schemadsTundishTemp.TableName = "L3DataTable";
            // 
            // coldsTundishTempL3DataTableGUID
            // 
            this.coldsTundishTempL3DataTableGUID.Caption = "GUID";
            this.coldsTundishTempL3DataTableGUID.ColumnName = "GUID";
            this.coldsTundishTempL3DataTableGUID.Namespace = "";
            // 
            // coldsTundishTempL3DataTableName
            // 
            this.coldsTundishTempL3DataTableName.Caption = "Name";
            this.coldsTundishTempL3DataTableName.ColumnName = "Name";
            this.coldsTundishTempL3DataTableName.Namespace = "";
            // 
            // coldsTundishTempL3DataTableHeatID
            // 
            this.coldsTundishTempL3DataTableHeatID.Caption = "HeatID";
            this.coldsTundishTempL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTundishTempL3DataTableHeatID.Namespace = "";
            // 
            // coldsTundishTempL3DataTableCCMID
            // 
            this.coldsTundishTempL3DataTableCCMID.Caption = "CCMID";
            this.coldsTundishTempL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsTundishTempL3DataTableCCMID.Namespace = "";
            // 
            // coldsTundishTempL3DataTableTempID
            // 
            this.coldsTundishTempL3DataTableTempID.Caption = "TempID";
            this.coldsTundishTempL3DataTableTempID.ColumnName = "TempID";
            this.coldsTundishTempL3DataTableTempID.DataType = typeof(short);
            this.coldsTundishTempL3DataTableTempID.Namespace = "";
            // 
            // coldsTundishTempL3DataTableTemp
            // 
            this.coldsTundishTempL3DataTableTemp.Caption = "Temp";
            this.coldsTundishTempL3DataTableTemp.ColumnName = "Temp";
            this.coldsTundishTempL3DataTableTemp.DataType = typeof(int);
            this.coldsTundishTempL3DataTableTemp.Namespace = "";
            // 
            // coldsTundishTempL3DataTableMeasure_Time
            // 
            this.coldsTundishTempL3DataTableMeasure_Time.Caption = "Measure_Time";
            this.coldsTundishTempL3DataTableMeasure_Time.ColumnName = "Measure_Time";
            this.coldsTundishTempL3DataTableMeasure_Time.DataType = typeof(System.DateTime);
            this.coldsTundishTempL3DataTableMeasure_Time.Namespace = "";
            // 
            // coldsTundishTempL3DataTableInValidFlag
            // 
            this.coldsTundishTempL3DataTableInValidFlag.Caption = "InValidFlag";
            this.coldsTundishTempL3DataTableInValidFlag.ColumnName = "InValidFlag";
            this.coldsTundishTempL3DataTableInValidFlag.DataType = typeof(int);
            this.coldsTundishTempL3DataTableInValidFlag.Namespace = "";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.bsTundishTemp;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator2.Size = new System.Drawing.Size(1001, 25);
            this.bindingNavigator2.TabIndex = 2;
            this.bindingNavigator2.Text = "bindingNavigator2";
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.bindingNavigator3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1009, 375);
            this.tabPage1.TabIndex = 19;
            this.tabPage1.Text = "中包温度跟踪";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 339);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1003, 33);
            this.flowLayoutPanel1.TabIndex = 96;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(921, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn8,
            this.flagValueDataGridViewTextBoxColumn,
            this.reasionDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bsTempControl;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1003, 344);
            this.dataGridView2.TabIndex = 4;
            // 
            // heatIDDataGridViewTextBoxColumn8
            // 
            this.heatIDDataGridViewTextBoxColumn8.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn8.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn8.Name = "heatIDDataGridViewTextBoxColumn8";
            // 
            // flagValueDataGridViewTextBoxColumn
            // 
            this.flagValueDataGridViewTextBoxColumn.DataPropertyName = "FlagValue";
            this.flagValueDataGridViewTextBoxColumn.DataSource = this.dsControlCode;
            this.flagValueDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.flagValueDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.flagValueDataGridViewTextBoxColumn.HeaderText = "影响因素";
            this.flagValueDataGridViewTextBoxColumn.Name = "flagValueDataGridViewTextBoxColumn";
            this.flagValueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.flagValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.flagValueDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.flagValueDataGridViewTextBoxColumn.Width = 200;
            // 
            // dsControlCode
            // 
            this.dsControlCode.AutoLoad = true;
            this.dsControlCode.AutoSubscribe = false;
            this.dsControlCode.DataSetName = "L3DataSet";
            this.dsControlCode.DeleteMethod = null;
            this.dsControlCode.InsertMethod = null;
            this.dsControlCode.L3DataAdapter = this.Adapter;
            this.dsControlCode.LoadEvent = "Click";
            this.dsControlCode.LoadTrigger = null;
            this.dsControlCode.RefreshValve = 1000;
            this.dsControlCode.SourceCommand = null;
            this.dsControlCode.SourceCondition = "CODE_GROUP = \'TundishTemp\'";
            this.dsControlCode.SourceMethod = "";
            this.dsControlCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsControlCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsControlCode.SubscribeTarget = null;
            this.dsControlCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsControlCode});
            this.dsControlCode.UpdateEvent = "Click";
            this.dsControlCode.UpdateMethod = null;
            this.dsControlCode.UpdateTrigger = null;
            // 
            // schemadsControlCode
            // 
            this.schemadsControlCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsControlCodeL3DataTableCode,
            this.coldsControlCodeL3DataTableCode_Des,
            this.coldsControlCodeL3DataTableCode_Group,
            this.coldsControlCodeL3DataTableCode_Group_Des,
            this.coldsControlCodeL3DataTableCode_Val_Str,
            this.coldsControlCodeL3DataTableCode_Val_Long,
            this.coldsControlCodeL3DataTableCode_Val_Double,
            this.coldsControlCodeL3DataTableCode_Function_Group,
            this.coldsControlCodeL3DataTableNC_Code});
            this.schemadsControlCode.TableName = "L3DataTable";
            // 
            // coldsControlCodeL3DataTableCode
            // 
            this.coldsControlCodeL3DataTableCode.Caption = "Code";
            this.coldsControlCodeL3DataTableCode.ColumnName = "Code";
            this.coldsControlCodeL3DataTableCode.Namespace = "";
            // 
            // coldsControlCodeL3DataTableCode_Des
            // 
            this.coldsControlCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsControlCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsControlCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsControlCodeL3DataTableCode_Group
            // 
            this.coldsControlCodeL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsControlCodeL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsControlCodeL3DataTableCode_Group.Namespace = "";
            // 
            // coldsControlCodeL3DataTableCode_Group_Des
            // 
            this.coldsControlCodeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsControlCodeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsControlCodeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsControlCodeL3DataTableCode_Val_Str
            // 
            this.coldsControlCodeL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsControlCodeL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsControlCodeL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsControlCodeL3DataTableCode_Val_Long
            // 
            this.coldsControlCodeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsControlCodeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsControlCodeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsControlCodeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsControlCodeL3DataTableCode_Val_Double
            // 
            this.coldsControlCodeL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsControlCodeL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsControlCodeL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsControlCodeL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsControlCodeL3DataTableCode_Function_Group
            // 
            this.coldsControlCodeL3DataTableCode_Function_Group.Caption = "Code_Function_Group";
            this.coldsControlCodeL3DataTableCode_Function_Group.ColumnName = "Code_Function_Group";
            this.coldsControlCodeL3DataTableCode_Function_Group.Namespace = "";
            // 
            // coldsControlCodeL3DataTableNC_Code
            // 
            this.coldsControlCodeL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsControlCodeL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsControlCodeL3DataTableNC_Code.Namespace = "";
            // 
            // reasionDataGridViewTextBoxColumn
            // 
            this.reasionDataGridViewTextBoxColumn.DataPropertyName = "Reasion";
            this.reasionDataGridViewTextBoxColumn.HeaderText = "原因";
            this.reasionDataGridViewTextBoxColumn.Name = "reasionDataGridViewTextBoxColumn";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "记录时间";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "记录人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            // 
            // bsTempControl
            // 
            this.bsTempControl.DataMember = "L3DataTable";
            this.bsTempControl.DataSource = this.dsTempControl;
            // 
            // dsTempControl
            // 
            this.dsTempControl.AutoLoad = true;
            this.dsTempControl.AutoSubscribe = false;
            this.dsTempControl.DataSetName = "L3DataSet";
            this.dsTempControl.DeleteMethod = null;
            this.dsTempControl.InsertMethod = null;
            this.dsTempControl.L3DataAdapter = this.Adapter;
            this.dsTempControl.LoadEvent = "Click";
            this.dsTempControl.LoadTrigger = null;
            this.dsTempControl.RefreshValve = 1000;
            this.dsTempControl.SourceCommand = null;
            this.dsTempControl.SourceCondition = "1=2";
            this.dsTempControl.SourceMethod = "";
            this.dsTempControl.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTempControl.SourceURI = "XGMESLogic\\EnergyMag\\CLF_Temp_Control";
            this.dsTempControl.SubscribeTarget = null;
            this.dsTempControl.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTempControl});
            this.dsTempControl.UpdateEvent = "Click";
            this.dsTempControl.UpdateMethod = null;
            this.dsTempControl.UpdateTrigger = null;
            // 
            // schemadsTempControl
            // 
            this.schemadsTempControl.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTempControlL3DataTableHeatID,
            this.coldsTempControlL3DataTableReasion,
            this.coldsTempControlL3DataTableFlagValue,
            this.coldsTempControlL3DataTableCreateTime,
            this.coldsTempControlL3DataTableOperator});
            this.schemadsTempControl.TableName = "L3DataTable";
            // 
            // coldsTempControlL3DataTableHeatID
            // 
            this.coldsTempControlL3DataTableHeatID.Caption = "HeatID";
            this.coldsTempControlL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTempControlL3DataTableHeatID.Namespace = "";
            // 
            // coldsTempControlL3DataTableReasion
            // 
            this.coldsTempControlL3DataTableReasion.Caption = "Reasion";
            this.coldsTempControlL3DataTableReasion.ColumnName = "Reasion";
            this.coldsTempControlL3DataTableReasion.Namespace = "";
            // 
            // coldsTempControlL3DataTableFlagValue
            // 
            this.coldsTempControlL3DataTableFlagValue.Caption = "FlagValue";
            this.coldsTempControlL3DataTableFlagValue.ColumnName = "FlagValue";
            this.coldsTempControlL3DataTableFlagValue.Namespace = "";
            // 
            // coldsTempControlL3DataTableCreateTime
            // 
            this.coldsTempControlL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsTempControlL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsTempControlL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsTempControlL3DataTableCreateTime.Namespace = "";
            // 
            // coldsTempControlL3DataTableOperator
            // 
            this.coldsTempControlL3DataTableOperator.Caption = "Operator";
            this.coldsTempControlL3DataTableOperator.ColumnName = "Operator";
            this.coldsTempControlL3DataTableOperator.Namespace = "";
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.toolStripButton25;
            this.bindingNavigator3.BindingSource = this.bsTundishTemp;
            this.bindingNavigator3.CountItem = this.toolStripLabel9;
            this.bindingNavigator3.DeleteItem = null;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton31,
            this.toolStripButton32,
            this.toolStripSeparator23,
            this.toolStripTextBox8,
            this.toolStripLabel9,
            this.toolStripSeparator24,
            this.toolStripButton33,
            this.toolStripButton34,
            this.toolStripSeparator25,
            this.toolStripButton25});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton31;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton34;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton33;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton32;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox8;
            this.bindingNavigator3.Size = new System.Drawing.Size(1003, 25);
            this.bindingNavigator3.TabIndex = 3;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripButton25
            // 
            this.toolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton25.Image")));
            this.toolStripButton25.Name = "toolStripButton25";
            this.toolStripButton25.RightToLeftAutoMirrorImage = true;
            this.toolStripButton25.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton25.Text = "新添";
            this.toolStripButton25.Click += new System.EventHandler(this.toolStripButton25_Click);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel9.Text = "/ {0}";
            this.toolStripLabel9.ToolTipText = "总项数";
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
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(6, 25);
            // 
            // panl
            // 
            this.panl.BackColor = System.Drawing.Color.SteelBlue;
            this.panl.Controls.Add(this.tbxTreatNo);
            this.panl.Controls.Add(this.label8);
            this.panl.Controls.Add(this.tbxHeatID);
            this.panl.Controls.Add(this.label6);
            this.panl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panl.Location = new System.Drawing.Point(0, 0);
            this.panl.Margin = new System.Windows.Forms.Padding(0);
            this.panl.Name = "panl";
            this.panl.Size = new System.Drawing.Size(1017, 29);
            this.panl.TabIndex = 87;
            // 
            // tbxTreatNo
            // 
            this.tbxTreatNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "TreatNo", true));
            this.tbxTreatNo.DisplayPrecision = 0;
            this.tbxTreatNo.Enabled = false;
            this.tbxTreatNo.EnableNull = false;
            this.tbxTreatNo.ErropPr = this.errorProvider1;
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
            this.tbxTreatNo.ToolTipValid = this.toolTip1;
            this.tbxTreatNo.VaildWarning = "";
            this.tbxTreatNo.ValidEable = true;
            this.tbxTreatNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(11, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 75;
            this.label8.Text = "处理号:";
            // 
            // tbxHeatID
            // 
            this.tbxHeatID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "HeatID", true));
            this.tbxHeatID.DisplayPrecision = 0;
            this.tbxHeatID.Enabled = false;
            this.tbxHeatID.EnableNull = false;
            this.tbxHeatID.ErropPr = this.errorProvider1;
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
            this.tbxHeatID.ToolTipValid = this.toolTip1;
            this.tbxHeatID.VaildWarning = "";
            this.tbxHeatID.ValidEable = true;
            this.tbxHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(197, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "炉号:";
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
            // coldsOxygenL3DataTableGUID
            // 
            this.coldsOxygenL3DataTableGUID.Caption = "GUID";
            this.coldsOxygenL3DataTableGUID.ColumnName = "GUID";
            this.coldsOxygenL3DataTableGUID.Namespace = "";
            // 
            // coldsOxygenL3DataTableName
            // 
            this.coldsOxygenL3DataTableName.Caption = "Name";
            this.coldsOxygenL3DataTableName.ColumnName = "Name";
            this.coldsOxygenL3DataTableName.Namespace = "";
            // 
            // coldsNoteL3DataTableGUID
            // 
            this.coldsNoteL3DataTableGUID.Caption = "GUID";
            this.coldsNoteL3DataTableGUID.ColumnName = "GUID";
            this.coldsNoteL3DataTableGUID.Namespace = "";
            // 
            // coldsNoteL3DataTableName
            // 
            this.coldsNoteL3DataTableName.Caption = "Name";
            this.coldsNoteL3DataTableName.ColumnName = "Name";
            this.coldsNoteL3DataTableName.Namespace = "";
            // 
            // schemadsNote
            // 
            this.schemadsNote.TableName = "L3DataTable";
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // l3DataSet9
            // 
            this.l3DataSet9.AutoLoad = true;
            this.l3DataSet9.AutoSubscribe = false;
            this.l3DataSet9.DataSetName = "L3DataSet";
            this.l3DataSet9.DeleteMethod = null;
            this.l3DataSet9.InsertMethod = null;
            this.l3DataSet9.L3DataAdapter = null;
            this.l3DataSet9.LoadEvent = "Click";
            this.l3DataSet9.LoadTrigger = null;
            this.l3DataSet9.RefreshValve = 1000;
            this.l3DataSet9.SourceCommand = null;
            this.l3DataSet9.SourceCondition = null;
            this.l3DataSet9.SourceMethod = "";
            this.l3DataSet9.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.l3DataSet9.SourceURI = "XGMESLogic\\LFMag\\CLF_HeatRemark";
            this.l3DataSet9.SubscribeTarget = null;
            this.l3DataSet9.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet9});
            this.l3DataSet9.UpdateEvent = "Click";
            this.l3DataSet9.UpdateMethod = null;
            this.l3DataSet9.UpdateTrigger = null;
            // 
            // schemal3DataSet9
            // 
            this.schemal3DataSet9.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet9L3DataTableGUID,
            this.coll3DataSet9L3DataTableName,
            this.coll3DataSet9L3DataTableTreatNo,
            this.coll3DataSet9L3DataTableHeatID,
            this.coll3DataSet9L3DataTableType,
            this.coll3DataSet9L3DataTableRemark,
            this.coll3DataSet9L3DataTableLogTime});
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
            // coll3DataSet9L3DataTableTreatNo
            // 
            this.coll3DataSet9L3DataTableTreatNo.Caption = "TreatNo";
            this.coll3DataSet9L3DataTableTreatNo.ColumnName = "TreatNo";
            this.coll3DataSet9L3DataTableTreatNo.Namespace = "";
            // 
            // coll3DataSet9L3DataTableHeatID
            // 
            this.coll3DataSet9L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet9L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet9L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet9L3DataTableType
            // 
            this.coll3DataSet9L3DataTableType.Caption = "Type";
            this.coll3DataSet9L3DataTableType.ColumnName = "Type";
            this.coll3DataSet9L3DataTableType.DataType = typeof(bool);
            this.coll3DataSet9L3DataTableType.Namespace = "";
            // 
            // coll3DataSet9L3DataTableRemark
            // 
            this.coll3DataSet9L3DataTableRemark.Caption = "Remark";
            this.coll3DataSet9L3DataTableRemark.ColumnName = "Remark";
            this.coll3DataSet9L3DataTableRemark.Namespace = "";
            // 
            // coll3DataSet9L3DataTableLogTime
            // 
            this.coll3DataSet9L3DataTableLogTime.Caption = "LogTime";
            this.coll3DataSet9L3DataTableLogTime.ColumnName = "LogTime";
            this.coll3DataSet9L3DataTableLogTime.DataType = typeof(System.DateTime);
            this.coll3DataSet9L3DataTableLogTime.Namespace = "";
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
            // cmdHeatExcept
            // 
            this.cmdHeatExcept.Adapter = this.Adapter;
            this.cmdHeatExcept.MergeReturnTarget = false;
            this.cmdHeatExcept.Method = "NewHeatExceptionData";
            this.cmdHeatExcept.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdHeatExcept.Parameters.Add(this.l3cmdHeatID);
            this.cmdHeatExcept.Parameters.Add(this.l3cmdpUnitType);
            this.cmdHeatExcept.Parameters.Add(this.l3cmdpUnitID);
            this.cmdHeatExcept.Parameters.Add(this.l3cmdprsData);
            this.cmdHeatExcept.ReturnTarget = null;
            this.cmdHeatExcept.ReturnTargetProperty = null;
            this.cmdHeatExcept.Trigger = null;
            this.cmdHeatExcept.TriggerEvent = "Click";
            // 
            // l3cmdHeatID
            // 
            this.l3cmdHeatID.AcceptAfterExecuted = false;
            this.l3cmdHeatID.ConstantValue = null;
            this.l3cmdHeatID.MergeTarget = false;
            this.l3cmdHeatID.SourceFilter = null;
            this.l3cmdHeatID.SourceObject = null;
            this.l3cmdHeatID.SourceProperty = null;
            this.l3cmdHeatID.TargetObject = null;
            this.l3cmdHeatID.TargetProperty = null;
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
            // coldsWireL3DataTableBatch_ID
            // 
            this.coldsWireL3DataTableBatch_ID.Caption = "Batch_ID";
            this.coldsWireL3DataTableBatch_ID.ColumnName = "Batch_ID";
            this.coldsWireL3DataTableBatch_ID.Namespace = "";
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
            // dsHeatGears
            // 
            this.dsHeatGears.AutoLoad = false;
            this.dsHeatGears.AutoSubscribe = false;
            this.dsHeatGears.DataSetName = "L3DataSet";
            this.dsHeatGears.DeleteMethod = "";
            this.dsHeatGears.InsertMethod = "";
            this.dsHeatGears.L3DataAdapter = this.Adapter;
            this.dsHeatGears.LoadEvent = "";
            this.dsHeatGears.LoadTrigger = null;
            this.dsHeatGears.RefreshValve = 1000;
            this.dsHeatGears.SourceCommand = null;
            this.dsHeatGears.SourceCondition = "";
            this.dsHeatGears.SourceMethod = "select gears from clf_heat_gears where 1=2";
            this.dsHeatGears.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsHeatGears.SourceURI = "";
            this.dsHeatGears.SubscribeTarget = "";
            this.dsHeatGears.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatGears});
            this.dsHeatGears.UpdateEvent = "";
            this.dsHeatGears.UpdateMethod = "";
            this.dsHeatGears.UpdateTrigger = null;
            // 
            // schemadsHeatGears
            // 
            this.schemadsHeatGears.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatGearsL3DataTableGEARS});
            this.schemadsHeatGears.TableName = "L3DataTable";
            // 
            // coldsHeatGearsL3DataTableGEARS
            // 
            this.coldsHeatGearsL3DataTableGEARS.Caption = "GEARS";
            this.coldsHeatGearsL3DataTableGEARS.ColumnName = "GEARS";
            this.coldsHeatGearsL3DataTableGEARS.DataType = typeof(int);
            this.coldsHeatGearsL3DataTableGEARS.DefaultValue = 0;
            this.coldsHeatGearsL3DataTableGEARS.Namespace = "";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TreatNo";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "处理号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "加料量";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Discharge_Time";
            dataGridViewCellStyle10.Format = "G";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "加料时刻";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Batch_ID";
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "批次号";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "人工录入标志";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Vendor";
            this.dataGridViewTextBoxColumn8.HeaderText = "厂家";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EnableFlag";
            this.dataGridViewTextBoxColumn9.HeaderText = "EnableFlag";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TreatNo";
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "处理号";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "喂线长度[m]";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn13.Frozen = true;
            this.dataGridViewTextBoxColumn13.HeaderText = "喂线重量[Kg]";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Speed";
            this.dataGridViewTextBoxColumn14.Frozen = true;
            this.dataGridViewTextBoxColumn14.HeaderText = "喂线速度";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "WireTime";
            dataGridViewCellStyle11.Format = "G";
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn15.Frozen = true;
            this.dataGridViewTextBoxColumn15.HeaderText = "喂线时刻";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.Width = 114;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Batch_ID";
            this.dataGridViewTextBoxColumn16.Frozen = true;
            this.dataGridViewTextBoxColumn16.HeaderText = "批次号";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn17.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn18.HeaderText = "人工录入标志";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "EnableFlag";
            this.dataGridViewTextBoxColumn19.HeaderText = "EnableFlag";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ID_Object";
            this.dataGridViewTextBoxColumn20.HeaderText = "身份标识";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn21.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Process_Count";
            this.dataGridViewTextBoxColumn22.HeaderText = "处理次数";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "UnitTypeID";
            this.dataGridViewTextBoxColumn23.HeaderText = "工序";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn24.HeaderText = "工位";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "PreHeatID";
            this.dataGridViewTextBoxColumn25.HeaderText = "预定炉号";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Visible = false;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Pre_SteelGradeIndex";
            this.dataGridViewTextBoxColumn26.HeaderText = "预定炼钢记号";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "SteelGradeIndex";
            this.dataGridViewTextBoxColumn27.HeaderText = "炼钢记号";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Exceptional_Time";
            dataGridViewCellStyle12.Format = "G";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn28.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn28.HeaderText = "异常产生时间";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 200;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "AppID";
            this.dataGridViewTextBoxColumn29.HeaderText = "委托单编号";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Sample_Code";
            this.dataGridViewTextBoxColumn30.HeaderText = "试样编码";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Arrive_Date";
            dataGridViewCellStyle13.Format = "G";
            this.dataGridViewTextBoxColumn31.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn31.HeaderText = "到样时间";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn31.Width = 130;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Report_Date";
            dataGridViewCellStyle14.Format = "G";
            this.dataGridViewTextBoxColumn32.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn32.HeaderText = "报告时间";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn32.Width = 130;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn33.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "UnitID";
            this.dataGridViewTextBoxColumn34.HeaderText = "工位";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Sample_Count";
            this.dataGridViewTextBoxColumn35.HeaderText = "取样次数";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "C";
            this.dataGridViewTextBoxColumn36.HeaderText = "C";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Si";
            this.dataGridViewTextBoxColumn37.HeaderText = "Si";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Mn";
            this.dataGridViewTextBoxColumn38.HeaderText = "Mn";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "P";
            this.dataGridViewTextBoxColumn39.HeaderText = "P";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn40.HeaderText = "S";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "Al";
            this.dataGridViewTextBoxColumn41.HeaderText = "Al";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Cr";
            this.dataGridViewTextBoxColumn42.HeaderText = "Cr";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Ti";
            this.dataGridViewTextBoxColumn43.HeaderText = "Ti";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "V";
            this.dataGridViewTextBoxColumn44.HeaderText = "V";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "B";
            this.dataGridViewTextBoxColumn45.HeaderText = "B";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Mo";
            this.dataGridViewTextBoxColumn46.HeaderText = "Mo";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Ni";
            this.dataGridViewTextBoxColumn47.HeaderText = "Ni";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Ca";
            this.dataGridViewTextBoxColumn48.HeaderText = "Ca";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Cu";
            this.dataGridViewTextBoxColumn49.HeaderText = "Cu";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Nb";
            this.dataGridViewTextBoxColumn50.HeaderText = "Nb";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Sn";
            this.dataGridViewTextBoxColumn51.HeaderText = "Sn";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "W";
            this.dataGridViewTextBoxColumn52.HeaderText = "W";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "Pb";
            this.dataGridViewTextBoxColumn53.HeaderText = "Pb";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Zn";
            this.dataGridViewTextBoxColumn54.HeaderText = "Zn";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "N";
            this.dataGridViewTextBoxColumn55.HeaderText = "N";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "H";
            this.dataGridViewTextBoxColumn56.HeaderText = "H";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "O";
            this.dataGridViewTextBoxColumn57.HeaderText = "O";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "As";
            this.dataGridViewTextBoxColumn58.HeaderText = "As";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "AlS";
            this.dataGridViewTextBoxColumn59.HeaderText = "AlS";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "Sb";
            this.dataGridViewTextBoxColumn60.HeaderText = "Sb";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "Re";
            this.dataGridViewTextBoxColumn61.HeaderText = "Re";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Ceq";
            this.dataGridViewTextBoxColumn62.HeaderText = "Ceq";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "CrNi";
            this.dataGridViewTextBoxColumn63.HeaderText = "CrNi";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "CrCu";
            this.dataGridViewTextBoxColumn64.HeaderText = "CrCu";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "CrNiCu";
            this.dataGridViewTextBoxColumn65.HeaderText = "CrNiCu";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "Other1";
            this.dataGridViewTextBoxColumn66.HeaderText = "其他1";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "Other2";
            this.dataGridViewTextBoxColumn67.HeaderText = "其他2";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "Other3";
            this.dataGridViewTextBoxColumn68.HeaderText = "其他3";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "LogTime";
            dataGridViewCellStyle15.Format = "G";
            this.dataGridViewTextBoxColumn69.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn69.HeaderText = "数据记录时间";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn69.Width = 130;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "TreatNo";
            this.dataGridViewTextBoxColumn70.HeaderText = "处理号";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn71.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn72.DataPropertyName = "Change_Time";
            dataGridViewCellStyle16.Format = "G";
            this.dataGridViewTextBoxColumn72.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn72.HeaderText = "状态变化时刻";
            this.dataGridViewTextBoxColumn72.MinimumWidth = 120;
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "Gears";
            this.dataGridViewTextBoxColumn73.HeaderText = "加热档位";
            this.dataGridViewTextBoxColumn73.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "Hot_Length_Cur";
            this.dataGridViewTextBoxColumn74.HeaderText = "分段加热时间[min]";
            this.dataGridViewTextBoxColumn74.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            this.dataGridViewTextBoxColumn74.Width = 150;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "Hot_Length_Total";
            this.dataGridViewTextBoxColumn75.HeaderText = "累计加热时间[min]";
            this.dataGridViewTextBoxColumn75.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            this.dataGridViewTextBoxColumn75.Width = 150;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "TreatNo";
            this.dataGridViewTextBoxColumn76.HeaderText = "处理号";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn77.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "Temperature";
            this.dataGridViewTextBoxColumn78.HeaderText = "测温值";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "MeasureTime";
            dataGridViewCellStyle17.Format = "G";
            this.dataGridViewTextBoxColumn79.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn79.HeaderText = "测温时刻";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn79.Width = 130;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "TreatNo";
            this.dataGridViewTextBoxColumn80.HeaderText = "处理号";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn81.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.DataPropertyName = "Oxygen_Content";
            this.dataGridViewTextBoxColumn82.HeaderText = "氧含量";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn83.DataPropertyName = "Measure_Time";
            dataGridViewCellStyle18.Format = "G";
            this.dataGridViewTextBoxColumn83.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn83.HeaderText = "定氧时刻";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.DataPropertyName = "TreatNo";
            this.dataGridViewTextBoxColumn84.HeaderText = "处理号";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn85.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "LogTime";
            this.dataGridViewTextBoxColumn86.HeaderText = "数据记录时间";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn86.Width = 130;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn87.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn87.HeaderText = "备注";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.DataPropertyName = "HeatID";
            this.dataGridViewTextBoxColumn88.HeaderText = "炉号";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "CCMID";
            this.dataGridViewTextBoxColumn89.HeaderText = "铸机号";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "Temp";
            this.dataGridViewTextBoxColumn90.HeaderText = "测温值";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.DataPropertyName = "InValidFlag";
            this.dataGridViewTextBoxColumn91.HeaderText = "是否有效";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            // 
            // LFHeatInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 430);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.panl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LFHeatInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LF炉次数据";
            this.Load += new System.EventHandler(this.LFHeatInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlProcess.ResumeLayout(false);
            this.pnlOxygen.ResumeLayout(false);
            this.pnlTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet2)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.tabLFAddMat.ResumeLayout(false);
            this.hmiRootPanel2.ResumeLayout(false);
            this.hmiRootPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchID_Mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchID_Mat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBatchID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAdditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAdditionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMat)).EndInit();
            this.bnMat.ResumeLayout(false);
            this.bnMat.PerformLayout();
            this.pnlMat.ResumeLayout(false);
            this.tabWire.ResumeLayout(false);
            this.hmiRootPanel3.ResumeLayout(false);
            this.hmiRootPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBatchID_Wire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBatchID_Wire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBatchID_Wire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire)).EndInit();
            this.pnlWire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsProbe_Vonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProbe_Vonder)).EndInit();
            this.tabLadleInfo.ResumeLayout(false);
            this.tabLadleInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLadleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleInfo)).EndInit();
            this.pnlLadleInfo.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsLFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnStatus)).EndInit();
            this.bnStatus.ResumeLayout(false);
            this.bnStatus.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.tabTemp.ResumeLayout(false);
            this.hmiRootPanel6.ResumeLayout(false);
            this.hmiRootPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).EndInit();
            this.bnTemp.ResumeLayout(false);
            this.bnTemp.PerformLayout();
            this.tabOxygen.ResumeLayout(false);
            this.tabOxygen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOxygen)).EndInit();
            this.bnOxygen.ResumeLayout(false);
            this.bnOxygen.PerformLayout();
            this.tabRemark.ResumeLayout(false);
            this.tabRemark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemarkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemarkType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRemark)).EndInit();
            this.bnRemark.ResumeLayout(false);
            this.bnRemark.PerformLayout();
            this.pnlNote.ResumeLayout(false);
            this.tabMidLandleTemp.ResumeLayout(false);
            this.tabMidLandleTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsControlCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsControlCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTempControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTempControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTempControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.panl.ResumeLayout(false);
            this.panl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l3DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatGears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatGears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcessCancel;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker dtSoftBlowStartTime;
        private System.Windows.Forms.DateTimePicker dtEndTime;
        private System.Windows.Forms.DateTimePicker dtStartTime;
        private System.Windows.Forms.DateTimePicker dtArrivalTime;
        private PxDataValid.PxTextBox txtHoldBackTime;
        private System.Windows.Forms.Label label23;
        private PxDataValid.PxTextBox txtLidLife;
        private System.Windows.Forms.Label label24;
        private PxDataValid.PxTextBox txtSoftBlowTime;
        private System.Windows.Forms.Label label25;
        private PxDataValid.PxTextBox txtDepartureTemp;
        private System.Windows.Forms.Label label26;
        private PxDataValid.PxTextBox txtHeatCount;
        private System.Windows.Forms.Label label27;
        private PxDataValid.PxTextBox txtHeatTime;
        private System.Windows.Forms.Label label28;
        private PxDataValid.PxTextBox txtProcessTime;
        private System.Windows.Forms.Label label29;
        private PxDataValid.PxTextBox txtArrivalTemp;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.FlowLayoutPanel pnlProcess;
        private System.Windows.Forms.Button btnPaocessOK;
        private System.Windows.Forms.Button btnTempCancel;
        private System.Windows.Forms.Button btnTempOK;
        private System.Windows.Forms.Button btnOxygenCancel;
        private System.Windows.Forms.FlowLayoutPanel pnlOxygen;
        private System.Windows.Forms.Button btnOxygenOK;
        private System.Windows.Forms.FlowLayoutPanel pnlTemp;
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
        private System.Windows.Forms.FlowLayoutPanel pnlBase;
        private System.Windows.Forms.Button btnBaseCancel;
        private System.Windows.Forms.Button btnBaseOK;
        private System.Windows.Forms.TabPage tabLFAddMat;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.FlowLayoutPanel pnlMat;
        private System.Windows.Forms.Button btnMatCancel;
        private System.Windows.Forms.Button btnMatOK;
        private System.Windows.Forms.TabPage tabProcess;
        private PxDataValid.PxTextBox txtSteelWeight;
        private System.Windows.Forms.Label label43;
        private PxDataValid.PxTextBox txtFeedWireTemp;
        private System.Windows.Forms.Label label44;
        private PxDataValid.PxTextBox txtLadleNo;
        private System.Windows.Forms.Label label40;
        private PxDataValid.PxTextBox txtProbeVonder;
        private System.Windows.Forms.TabPage tabChemical;
        private System.Windows.Forms.FlowLayoutPanel pnlChemical;
        private System.Windows.Forms.Button btnChemicalCancel;
        private System.Windows.Forms.Button btnChemicalOK;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.FlowLayoutPanel pnlStatus;
        private System.Windows.Forms.Button btnStatusCancel;
        private System.Windows.Forms.Button btnStatusOK;
        private System.Windows.Forms.TabPage tabTemp;
        private HMIBase.HMIRootPanel hmiRootPanel6;
        private System.Windows.Forms.TabPage tabOxygen;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Panel panl;
        private PxDataValid.PxTextBox tbxHeatID;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxTextBox tbxTreatNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtSoftBlowEndTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabRemark;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableTreatNo;
        private System.Data.DataColumn coldsBaseL3DataTableHeatID;
        private System.Data.DataColumn coldsBaseL3DataTablePreHeatID;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGrade;
        private System.Data.DataColumn coldsBaseL3DataTableLadleNo;
        private System.Data.DataColumn coldsBaseL3DataTableHeadFurnace;
        private System.Data.DataColumn coldsBaseL3DataTableAssistant;
        private System.Data.DataColumn coldsBaseL3DataTableSecondHand;
        private System.Data.DataColumn coldsBaseL3DataTableProductionDate;
        private System.Data.DataColumn coldsBaseL3DataTableLocked;
        private System.Data.DataColumn coldsBaseL3DataTableShift;
        private System.Data.DataColumn coldsBaseL3DataTableTeam;
        private System.Windows.Forms.BindingSource bsMat;
        private AppSvrHMI.L3DataSet dsProcess;
        private System.Windows.Forms.BindingSource bsProcess;
        private AppSvrHMI.L3DataSet dsChemical;
        private System.Windows.Forms.BindingSource bsChemical;
        private System.Windows.Forms.BindingSource bsStatus;
        private System.Windows.Forms.BindingSource bsTemp;
        private System.Windows.Forms.BindingSource bsOxygen;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataTable schemadsProcess;
        private System.Data.DataColumn coldsProcessL3DataTableGUID;
        private System.Data.DataColumn coldsProcessL3DataTableName;
        private System.Data.DataColumn coldsProcessL3DataTableLogDate;
        private System.Data.DataColumn coldsProcessL3DataTableMaterialType;
        private System.Data.DataColumn coldsProcessL3DataTableMaterialID;
        private System.Data.DataColumn coldsProcessL3DataTableAmount;
        private System.Data.DataColumn coldsProcessL3DataTableTargetArea;
        private System.Data.DataColumn coldsProcessL3DataTableOperator;
        private System.Data.DataColumn coldsProcessL3DataTableShift;
        private System.Data.DataColumn coldsProcessL3DataTableTeam;
        private System.Data.DataColumn coldsProcessL3DataTableTreatNo;
        private System.Data.DataColumn coldsProcessL3DataTableHeatID;
        private System.Data.DataColumn coldsProcessL3DataTableArrival_Time;
        private System.Data.DataColumn coldsProcessL3DataTableArrival_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableStart_Time;
        private System.Data.DataColumn coldsProcessL3DataTableEnd_Time;
        private System.Data.DataColumn coldsProcessL3DataTableProcess_Time;
        private System.Data.DataColumn coldsProcessL3DataTableHeat_Time;
        private System.Data.DataColumn coldsProcessL3DataTableHeat_Count;
        private System.Data.DataColumn coldsProcessL3DataTableProbe_Vonder;
        private System.Data.DataColumn coldsProcessL3DataTableFeedWire_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableDeparture_Temp;
        private System.Data.DataColumn coldsProcessL3DataTableSoftBlow_StartTime;
        private System.Data.DataColumn coldsProcessL3DataTableSoftBlow_EndTime;
        private System.Data.DataColumn coldsProcessL3DataTableSoftBlow_Time;
        private System.Data.DataColumn coldsProcessL3DataTableLid_Life;
        private System.Data.DataColumn coldsProcessL3DataTableHoldBack_Time;
        private System.Data.DataColumn coldsProcessL3DataTableSteel_Weight;
        private System.Data.DataColumn coldsProcessL3DataTableLadleNo;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingNavigator bnMat;
        private System.Windows.Forms.ToolStripButton btnAddMat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dvMat;
        private System.Data.DataTable schemadsMat;
        private System.Data.DataColumn coldsMatL3DataTableGUID;
        private System.Data.DataColumn coldsMatL3DataTableName;
        private System.Data.DataColumn coldsMatL3DataTableTreatNo;
        private System.Data.DataColumn coldsMatL3DataTableHeatID;
        private System.Data.DataColumn coldsMatL3DataTableElement;
        private System.Data.DataColumn coldsMatL3DataTableWeight;
        private System.Data.DataColumn coldsMatL3DataTableDischarge_Time;
        private System.Data.DataColumn coldsMatL3DataTableType;
        private System.Windows.Forms.BindingNavigator bnChemical;
        private System.Windows.Forms.ToolStripButton btnAddChemical;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton27;
        private System.Windows.Forms.ToolStripButton toolStripButton28;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripButton toolStripButton29;
        private System.Windows.Forms.ToolStripButton toolStripButton30;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.BindingNavigator bnTemp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.BindingNavigator bnOxygen;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.BindingNavigator bnRemark;
        private System.Windows.Forms.ToolStripButton btnAddRemark;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.FlowLayoutPanel pnlNote;
        private System.Windows.Forms.Button btnNoteCancel;
        private System.Windows.Forms.Button btnNoteConfirm;
        private System.Data.DataColumn coldsStatusL3DataTableGUID;
        private System.Data.DataColumn coldsStatusL3DataTableName;
        private System.Data.DataColumn coldsTempL3DataTableGUID;
        private System.Data.DataColumn coldsTempL3DataTableName;
        private System.Data.DataColumn coldsOxygenL3DataTableGUID;
        private System.Data.DataColumn coldsOxygenL3DataTableName;
        private System.Data.DataColumn coldsNoteL3DataTableGUID;
        private System.Data.DataColumn coldsNoteL3DataTableName;
        private System.Data.DataTable schemadsNote;
        private AppSvrHMI.L3DataSet dsRemark;
        private System.Windows.Forms.DataGridView dvRemark;
        private System.Windows.Forms.BindingSource bsRemark;
        private System.Data.DataTable schemadsRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableGUID;
        private System.Data.DataColumn coldsRemarkL3DataTableName;
        private System.Data.DataColumn coldsRemarkL3DataTableTreatNo;
        private System.Data.DataColumn coldsRemarkL3DataTableHeatID;
        private System.Data.DataColumn coldsRemarkL3DataTableType;
        private System.Data.DataColumn coldsRemarkL3DataTableRemark;
        private System.Data.DataColumn coldsRemarkL3DataTableLogTime;
        private System.Windows.Forms.BindingNavigator bnStatus;
        private System.Windows.Forms.ToolStripButton btnAddStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripButton toolStripButton21;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
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
        private System.Windows.Forms.DataGridView dvChemical;
        private System.Data.DataTable schemadsStatus;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableName;
        private System.Data.DataColumn coll3DataSet1L3DataTableTreatNo;
        private System.Data.DataColumn coll3DataSet1L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet1L3DataTableStatus;
        private System.Data.DataColumn coll3DataSet1L3DataTableChange_Time;
        private AppSvrHMI.L3DataSet dsTemp;
        private System.Data.DataTable schemal3DataSet5;
        private System.Data.DataColumn coll3DataSet5L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet5L3DataTableName;
        private System.Data.DataColumn coll3DataSet5L3DataTableTreatNo;
        private System.Data.DataColumn coll3DataSet5L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet5L3DataTableTemperature;
        private System.Data.DataColumn coll3DataSet5L3DataTableMeasureTime;
        private System.Data.DataColumn coll3DataSet5L3DataTableMode;
        private AppSvrHMI.L3DataSet dsOxygen;
        private System.Data.DataTable schemal3DataSet2;
        private System.Data.DataColumn coll3DataSet2L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet2L3DataTableName;
        private System.Data.DataColumn coll3DataSet2L3DataTableTreatNo;
        private System.Data.DataColumn coll3DataSet2L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet2L3DataTableOxygen_Content;
        private System.Data.DataColumn coll3DataSet2L3DataTableMeasure_Time;
        private AppSvrHMI.L3DataSet l3DataSet9;
        private System.Data.DataTable schemal3DataSet9;
        private System.Data.DataColumn coll3DataSet9L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet9L3DataTableName;
        private System.Data.DataColumn coll3DataSet9L3DataTableTreatNo;
        private System.Data.DataColumn coll3DataSet9L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet9L3DataTableType;
        private System.Data.DataColumn coll3DataSet9L3DataTableRemark;
        private System.Data.DataColumn coll3DataSet9L3DataTableLogTime;
        private System.Windows.Forms.DataGridView dvStatus;
        private System.Windows.Forms.DataGridView dvOxygen;
        private System.Windows.Forms.DataGridView dvTemp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsAdditionType;
        private System.Data.DataTable schemadsAdditionType;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsAdditionTypeL3DataTableCode_Val_Long;
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
        private AppSvrHMI.L3DataSet dsLFStatus;
        private System.Data.DataTable schemadsLFStatus;
        private System.Data.DataColumn coldsLFStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsLFStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsBOFTempMode;
        private System.Data.DataTable schemadsBOFTempMode;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsRemarkType;
        private System.Data.DataTable schemadsRemarkType;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsRemarkTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsCode;
        private System.Data.DataTable schemadsCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode;
        private System.Data.DataColumn coldsCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsMat;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNi;
        private System.Data.DataColumn coldsChemicalL3DataTableCrCu;
        private System.Data.DataColumn coldsChemicalL3DataTableCrNiCu;
        private System.Data.DataColumn coldsChemicalL3DataTableOther3;
        private System.Windows.Forms.TabPage tabWire;
        private HMIBase.HMIRootPanel hmiRootPanel3;
        private System.Windows.Forms.DataGridView dvWire;
        private System.Windows.Forms.FlowLayoutPanel pnlWire;
        private System.Windows.Forms.Button btnWireCancel;
        private System.Windows.Forms.Button btnWireConfirm;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton22;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton23;
        private System.Windows.Forms.ToolStripButton toolStripButton24;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton btnWireAdd;
        private AppSvrHMI.L3DataSet dsWire;
        private System.Data.DataTable schemadsWire;
        private System.Data.DataColumn coldsWireL3DataTableGUID;
        private System.Data.DataColumn coldsWireL3DataTableName;
        private System.Data.DataColumn coldsWireL3DataTableTreatNo;
        private System.Data.DataColumn coldsWireL3DataTableHeatID;
        private System.Data.DataColumn coldsWireL3DataTableWireCode;
        private System.Data.DataColumn coldsWireL3DataTableWeight;
        private System.Data.DataColumn coldsWireL3DataTableSpeed;
        private System.Data.DataColumn coldsWireL3DataTableWireTime;
        private System.Windows.Forms.BindingSource bsWire;
        private PxDataValid.PxComboBox cmbShift;
        private PxDataValid.PxComboBox cmbTeam;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private AppSvrHMI.L3Command cmdHeatExcept;
        private AppSvrHMI.L3CommandParameter l3cmdHeatID;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitType;
        private AppSvrHMI.L3CommandParameter l3cmdpUnitID;
        private AppSvrHMI.L3CommandParameter l3cmdprsData;
        private AppSvrHMI.L3DataSet dsExceptCode;
        private System.Data.DataTable schemadsExceptCode;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptCodeL3DataTableExceptional_Des;
        private System.Data.DataColumn coldsExceptCodeL3DataTableUnit;
        private AppSvrHMI.L3DataSet dsExcept;
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
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Time;
        private System.Windows.Forms.BindingSource bsExcept;
        private System.Windows.Forms.TabPage tabExcept;
        private System.Windows.Forms.DataGridView dvExcept;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn processCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preHeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preSteelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn steelGradeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn exceptionalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exceptionalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel fLPExcept;
        private System.Windows.Forms.Button btnCancelExcept;
        private System.Windows.Forms.Button btnConfirmExcept;
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
        private AppSvrHMI.L3DataSet dsWireCode;
        private System.Data.DataTable schemadsWireCode;
        private System.Data.DataColumn coldsWireCodeL3DataTableCode;
        private System.Data.DataColumn coldsWireCodeL3DataTableCode_Des;
        private PxDataValid.PxTextBox txtProcessTimeDis;
        private PxDataValid.PxTextBox txtHeatTimeDis;
        private PxDataValid.PxTextBox txtSoftBlowTimeDis;
        private System.Data.DataColumn coldsMatL3DataTableBatch_ID;
        private System.Data.DataColumn coldsMatL3DataTableVendor;
        private AppSvrHMI.L3DataSet dsProbe_Vonder;
        private System.Data.DataTable schemadsProbe_Vonder;
        private System.Data.DataColumn coldsProbe_VonderL3DataTableCode;
        private System.Data.DataColumn coldsProbe_VonderL3DataTableCode_Des;
        private System.Windows.Forms.ComboBox cmbProbe_Vonder;
        private PxDataValid.PxTextBox txtHoldBackTimeDis;
        private System.Data.DataColumn coldsWireL3DataTableVendor;
        private System.Data.DataColumn coldsWireL3DataTableBatch_ID;
        private System.Data.DataColumn AcoldsWireL3DataTableBatch_ID;
        private AppSvrHMI.L3DataSet dsBatchID_Mat;
        private System.Data.DataTable schemadsBatchID;
        private System.Data.DataColumn coldsBatchIDL3DataTableBatch_ID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ComboBox cmbBatch_Mat;
        private System.Windows.Forms.ComboBox cmb_Wire;
        private AppSvrHMI.L3DataSet dsBatchID_Wire;
        private System.Data.DataTable schemadsBatchID_Wire;
        private System.Data.DataColumn coldsBatchID_WireL3DataTableBatch_ID;
        private System.Data.DataColumn coldsMatL3DataTableEnableFlag;
        private System.Data.DataColumn coldsWireL3DataTableEnableFlag;
        private PxDataValid.PxTextBox txtLadleGrade;
        private System.Windows.Forms.Label label13;
        private System.Data.DataColumn coldsProcessL3DataTableSlag_Thickness;
        private System.Data.DataColumn coldsProcessL3DataTableLadle_Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn oxygenContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bsBatchID_Wire;
        private System.Windows.Forms.BindingSource bsBatchID_Mat;
        private System.Data.DataColumn coldsBatchID_MatL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsBatchID_MatL3DataTableCode;
        private System.Data.DataColumn coldsBatchID_MatL3DataTableCode_Des;
        private System.Data.DataColumn coldsBatchID_WireL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsBatchID_WireL3DataTableCode;
        private System.Data.DataColumn coldsBatchID_WireL3DataTableCode_Des;
        private System.Data.DataColumn coldsBatchID_WireL3DataTablecode_function_group;
        private System.Data.DataColumn coldsWireL3DataTableAmount;
        private System.Windows.Forms.BindingSource bsLadleInfo;
        private AppSvrHMI.L3DataSet dsLadleInfo;
        private System.Data.DataTable schemadsLadleInfo;
        private System.Data.DataColumn coldsLadleInfoL3DataTableTreatNo;
        private System.Data.DataColumn coldsLadleInfoL3DataTableHeatID;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLadleID;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLast_Ladle_Grade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableTemp;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLast_SteelGrade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableAct_Ladle_Grade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableCur_SteelGrade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableIn_Ladle_Grade;
        private System.Data.DataColumn coldsLadleInfoL3DataTableStop_Time_Len;
        private System.Data.DataColumn coldsLadleInfoL3DataTableLadle_Age;
        private System.Data.DataColumn coldsLadleInfoL3DataTableSmall_Fire;
        private System.Data.DataColumn coldsLadleInfoL3DataTableMiddle_Fire;
        private System.Data.DataColumn coldsLadleInfoL3DataTableBig_Fire;
        private System.Data.DataColumn coldsLadleInfoL3DataTableNote;
        private System.Data.DataColumn coldsLadleInfoL3DataTableOther1;
        private System.Data.DataColumn coldsLadleInfoL3DataTableOther2;
        private System.Data.DataColumn coldsLadleInfoL3DataTableOther3;
        private System.Windows.Forms.TabPage tabLadleInfo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.FlowLayoutPanel pnlLadleInfo;
        private System.Windows.Forms.Button btnLadleInfoCancel;
        private System.Windows.Forms.Button btnLadleInfoOK;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Data.DataColumn coldsLadleInfoL3DataTableMaxTemp;
        private AppSvrHMI.L3DataSet dsHeatGears;
        private System.Data.DataTable schemadsHeatGears;
        private System.Data.DataColumn coldsHeatGearsL3DataTableGEARS;
        private System.Data.DataColumn coldsStatusL3DataTableGears;
        private System.Data.DataColumn coldsStatusL3DataTableHot_Length_Cur;
        private System.Data.DataColumn coldsStatusL3DataTableHot_Length_Total;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripTextBox txtExcept;
        private AppSvrHMI.L3Command cmdExcept;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Windows.Forms.TabPage tabMidLandleTemp;
        private AppSvrHMI.L3DataSet dsTundishTemp;
        private System.Data.DataTable schemadsTundishTemp;
        private System.Data.DataColumn coldsTundishTempL3DataTableGUID;
        private System.Data.DataColumn coldsTundishTempL3DataTableName;
        private System.Data.DataColumn coldsTundishTempL3DataTableHeatID;
        private System.Data.DataColumn coldsTundishTempL3DataTableCCMID;
        private System.Data.DataColumn coldsTundishTempL3DataTableTempID;
        private System.Data.DataColumn coldsTundishTempL3DataTableTemp;
        private System.Data.DataColumn coldsTundishTempL3DataTableMeasure_Time;
        private System.Data.DataColumn coldsTundishTempL3DataTableInValidFlag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsTundishTemp;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private AppSvrHMI.L3DataSet dsCCMTempMode;
        private System.Data.DataTable schemadsCCMTempMode;
        private System.Data.DataColumn coldsCCMTempModeL3DataTableCode_Des;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Data.DataColumn coldsCCMTempModeL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tempIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn measureTimeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inValidFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Element;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dischargeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnableFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn WireCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wireTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_ID_Wire;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID_Wire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Wire;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnableFlagWire;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sampleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataLogModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriveDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gears;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hot_Length_Cur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hot_Length_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn modeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton toolStripButton25;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripButton toolStripButton31;
        private System.Windows.Forms.ToolStripButton toolStripButton32;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripButton toolStripButton33;
        private System.Windows.Forms.ToolStripButton toolStripButton34;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.BindingSource bsTempControl;
        private AppSvrHMI.L3DataSet dsTempControl;
        private System.Data.DataTable schemadsTempControl;
        private System.Data.DataColumn coldsTempControlL3DataTableHeatID;
        private System.Data.DataColumn coldsTempControlL3DataTableReasion;
        private System.Data.DataColumn coldsTempControlL3DataTableFlagValue;
        private System.Data.DataColumn coldsTempControlL3DataTableCreateTime;
        private System.Data.DataColumn coldsTempControlL3DataTableOperator;
        private AppSvrHMI.L3DataSet dsControlCode;
        private System.Data.DataTable schemadsControlCode;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode_Des;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode_Group;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsControlCodeL3DataTableCode_Function_Group;
        private System.Data.DataColumn coldsControlCodeL3DataTableNC_Code;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn flagValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Data.DataColumn coldsLadleInfoL3DataTableWall_Temp;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label15;
        private PxDataValid.PxTextBox ptbSlag_Thickness;
        private System.Windows.Forms.Label label16;
    }
}