namespace EquipMag.BoiloffCooling
{
    partial class EquipSupplyWaterFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipSupplyWaterFrm));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bsSupplyWater = new System.Windows.Forms.BindingSource(this.components);
            this.dsSupplyWater = new AppSvrHMI.L3DataSet();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableLevel_Boil = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableP_Boil = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableP_Pump_SupplyWater = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableP_Pump_SoftWater = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableLevel_DeO2Box = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableLevel_SoftWaterBox = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableP_MainPipe_Steam = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableTime_Start = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableTime_Stop = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableTime_Blow = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableEndFlag = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableShift = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableTeam = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableOperator = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvSupplyWater = new System.Windows.Forms.DataGridView();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelBoilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBoilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPumpSupplyWaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPumpSoftWaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDeO2BoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelSoftWaterBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMainPipeSteamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeBlowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsShiftL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsTeamL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtStartTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtEndTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplyWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplyWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvSupplyWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1024, 43);
            this.toolStripMain.TabIndex = 15;
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
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnEquipSupplyWaterFrm");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "btnEquipSupplyWaterFrm");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "btnEquipSupplyWaterFrm");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "btnEquipSupplyWaterFrm");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bsSupplyWater
            // 
            this.bsSupplyWater.DataMember = "L3DataTable";
            this.bsSupplyWater.DataSource = this.dsSupplyWater;
            // 
            // dsSupplyWater
            // 
            this.dsSupplyWater.AutoSubscribe = false;
            this.dsSupplyWater.DataSetName = "L3DataSet";
            this.dsSupplyWater.DeleteMethod = "";
            this.dsSupplyWater.InsertMethod = "";
            this.dsSupplyWater.L3DataAdapter = null;
            this.dsSupplyWater.LoadEvent = "";
            this.dsSupplyWater.LoadTrigger = null;
            this.dsSupplyWater.RefreshValve = 1000;
            this.dsSupplyWater.SourceCommand = null;
            this.dsSupplyWater.SourceCondition = "";
            this.dsSupplyWater.SourceMethod = "";
            this.dsSupplyWater.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSupplyWater.SourceURI = "XGMESLogic\\EquipMag\\CEquip_SupplyWater_Data";
            this.dsSupplyWater.SubscribeTarget = null;
            this.dsSupplyWater.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsSupplyWater.UpdateEvent = "";
            this.dsSupplyWater.UpdateMethod = "";
            this.dsSupplyWater.UpdateTrigger = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsAdjustSetL3DataTableBOFID,
            this.coldsAdjustSetL3DataTableHeatID,
            this.coldsAdjustSetL3DataTableLevel_Boil,
            this.coldsAdjustSetL3DataTableP_Boil,
            this.coldsAdjustSetL3DataTableP_Pump_SupplyWater,
            this.coldsAdjustSetL3DataTableP_Pump_SoftWater,
            this.coldsAdjustSetL3DataTableLevel_DeO2Box,
            this.coldsAdjustSetL3DataTableLevel_SoftWaterBox,
            this.coldsAdjustSetL3DataTableP_MainPipe_Steam,
            this.coldsAdjustSetL3DataTableTime_Start,
            this.coldsAdjustSetL3DataTableTime_Stop,
            this.coldsAdjustSetL3DataTableTime_Blow,
            this.coldsAdjustSetL3DataTableEndFlag,
            this.coldsAdjustSetL3DataTableShift,
            this.coldsAdjustSetL3DataTableTeam,
            this.coldsAdjustSetL3DataTableOperator});
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
            // coldsAdjustSetL3DataTableBOFID
            // 
            this.coldsAdjustSetL3DataTableBOFID.Caption = "BOFID";
            this.coldsAdjustSetL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsAdjustSetL3DataTableBOFID.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableHeatID
            // 
            this.coldsAdjustSetL3DataTableHeatID.Caption = "HeatID";
            this.coldsAdjustSetL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsAdjustSetL3DataTableHeatID.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableLevel_Boil
            // 
            this.coldsAdjustSetL3DataTableLevel_Boil.Caption = "Level_Boil";
            this.coldsAdjustSetL3DataTableLevel_Boil.ColumnName = "Level_Boil";
            this.coldsAdjustSetL3DataTableLevel_Boil.DataType = typeof(float);
            this.coldsAdjustSetL3DataTableLevel_Boil.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableP_Boil
            // 
            this.coldsAdjustSetL3DataTableP_Boil.Caption = "P_Boil";
            this.coldsAdjustSetL3DataTableP_Boil.ColumnName = "P_Boil";
            this.coldsAdjustSetL3DataTableP_Boil.DataType = typeof(float);
            this.coldsAdjustSetL3DataTableP_Boil.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableP_Pump_SupplyWater
            // 
            this.coldsAdjustSetL3DataTableP_Pump_SupplyWater.Caption = "P_Pump_SupplyWater";
            this.coldsAdjustSetL3DataTableP_Pump_SupplyWater.ColumnName = "P_Pump_SupplyWater";
            this.coldsAdjustSetL3DataTableP_Pump_SupplyWater.DataType = typeof(float);
            this.coldsAdjustSetL3DataTableP_Pump_SupplyWater.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableP_Pump_SoftWater
            // 
            this.coldsAdjustSetL3DataTableP_Pump_SoftWater.Caption = "P_Pump_SoftWater";
            this.coldsAdjustSetL3DataTableP_Pump_SoftWater.ColumnName = "P_Pump_SoftWater";
            this.coldsAdjustSetL3DataTableP_Pump_SoftWater.DataType = typeof(float);
            this.coldsAdjustSetL3DataTableP_Pump_SoftWater.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableLevel_DeO2Box
            // 
            this.coldsAdjustSetL3DataTableLevel_DeO2Box.Caption = "Level_DeO2Box";
            this.coldsAdjustSetL3DataTableLevel_DeO2Box.ColumnName = "Level_DeO2Box";
            this.coldsAdjustSetL3DataTableLevel_DeO2Box.DataType = typeof(float);
            this.coldsAdjustSetL3DataTableLevel_DeO2Box.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableLevel_SoftWaterBox
            // 
            this.coldsAdjustSetL3DataTableLevel_SoftWaterBox.Caption = "Level_SoftWaterBox";
            this.coldsAdjustSetL3DataTableLevel_SoftWaterBox.ColumnName = "Level_SoftWaterBox";
            this.coldsAdjustSetL3DataTableLevel_SoftWaterBox.DataType = typeof(float);
            this.coldsAdjustSetL3DataTableLevel_SoftWaterBox.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableP_MainPipe_Steam
            // 
            this.coldsAdjustSetL3DataTableP_MainPipe_Steam.Caption = "P_MainPipe_Steam";
            this.coldsAdjustSetL3DataTableP_MainPipe_Steam.ColumnName = "P_MainPipe_Steam";
            this.coldsAdjustSetL3DataTableP_MainPipe_Steam.DataType = typeof(float);
            this.coldsAdjustSetL3DataTableP_MainPipe_Steam.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableTime_Start
            // 
            this.coldsAdjustSetL3DataTableTime_Start.Caption = "Time_Start";
            this.coldsAdjustSetL3DataTableTime_Start.ColumnName = "Time_Start";
            this.coldsAdjustSetL3DataTableTime_Start.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableTime_Start.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableTime_Stop
            // 
            this.coldsAdjustSetL3DataTableTime_Stop.Caption = "Time_Stop";
            this.coldsAdjustSetL3DataTableTime_Stop.ColumnName = "Time_Stop";
            this.coldsAdjustSetL3DataTableTime_Stop.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableTime_Stop.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableTime_Blow
            // 
            this.coldsAdjustSetL3DataTableTime_Blow.Caption = "Time_Blow";
            this.coldsAdjustSetL3DataTableTime_Blow.ColumnName = "Time_Blow";
            this.coldsAdjustSetL3DataTableTime_Blow.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableTime_Blow.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableEndFlag
            // 
            this.coldsAdjustSetL3DataTableEndFlag.Caption = "EndFlag";
            this.coldsAdjustSetL3DataTableEndFlag.ColumnName = "EndFlag";
            this.coldsAdjustSetL3DataTableEndFlag.DataType = typeof(bool);
            this.coldsAdjustSetL3DataTableEndFlag.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableShift
            // 
            this.coldsAdjustSetL3DataTableShift.Caption = "Shift";
            this.coldsAdjustSetL3DataTableShift.ColumnName = "Shift";
            this.coldsAdjustSetL3DataTableShift.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableTeam
            // 
            this.coldsAdjustSetL3DataTableTeam.Caption = "Team";
            this.coldsAdjustSetL3DataTableTeam.ColumnName = "Team";
            this.coldsAdjustSetL3DataTableTeam.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableOperator
            // 
            this.coldsAdjustSetL3DataTableOperator.Caption = "Operator";
            this.coldsAdjustSetL3DataTableOperator.ColumnName = "Operator";
            this.coldsAdjustSetL3DataTableOperator.Namespace = "";
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
            // dvSupplyWater
            // 
            this.dvSupplyWater.AllowUserToAddRows = false;
            this.dvSupplyWater.AllowUserToDeleteRows = false;
            this.dvSupplyWater.AllowUserToResizeRows = false;
            this.dvSupplyWater.AutoGenerateColumns = false;
            this.dvSupplyWater.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvSupplyWater.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSupplyWater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSupplyWater.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOFIDDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.levelBoilDataGridViewTextBoxColumn,
            this.pBoilDataGridViewTextBoxColumn,
            this.pPumpSupplyWaterDataGridViewTextBoxColumn,
            this.pPumpSoftWaterDataGridViewTextBoxColumn,
            this.levelDeO2BoxDataGridViewTextBoxColumn,
            this.levelSoftWaterBoxDataGridViewTextBoxColumn,
            this.pMainPipeSteamDataGridViewTextBoxColumn,
            this.timeStartDataGridViewTextBoxColumn,
            this.timeStopDataGridViewTextBoxColumn,
            this.timeBlowDataGridViewTextBoxColumn,
            this.endFlagDataGridViewCheckBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvSupplyWater.DataSource = this.bsSupplyWater;
            this.dvSupplyWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSupplyWater.Location = new System.Drawing.Point(0, 68);
            this.dvSupplyWater.MultiSelect = false;
            this.dvSupplyWater.Name = "dvSupplyWater";
            this.dvSupplyWater.RowHeadersVisible = false;
            this.dvSupplyWater.RowTemplate.Height = 23;
            this.dvSupplyWater.Size = new System.Drawing.Size(1024, 532);
            this.dvSupplyWater.TabIndex = 20;
            this.dvSupplyWater.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvEnergyData_DataError);
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "炉座";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.Width = 51;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.Width = 51;
            // 
            // levelBoilDataGridViewTextBoxColumn
            // 
            this.levelBoilDataGridViewTextBoxColumn.DataPropertyName = "Level_Boil";
            this.levelBoilDataGridViewTextBoxColumn.HeaderText = "汽包水位";
            this.levelBoilDataGridViewTextBoxColumn.Name = "levelBoilDataGridViewTextBoxColumn";
            this.levelBoilDataGridViewTextBoxColumn.Width = 61;
            // 
            // pBoilDataGridViewTextBoxColumn
            // 
            this.pBoilDataGridViewTextBoxColumn.DataPropertyName = "P_Boil";
            this.pBoilDataGridViewTextBoxColumn.HeaderText = "汽包压力";
            this.pBoilDataGridViewTextBoxColumn.Name = "pBoilDataGridViewTextBoxColumn";
            this.pBoilDataGridViewTextBoxColumn.Width = 61;
            // 
            // pPumpSupplyWaterDataGridViewTextBoxColumn
            // 
            this.pPumpSupplyWaterDataGridViewTextBoxColumn.DataPropertyName = "P_Pump_SupplyWater";
            this.pPumpSupplyWaterDataGridViewTextBoxColumn.HeaderText = "给水泵压力";
            this.pPumpSupplyWaterDataGridViewTextBoxColumn.Name = "pPumpSupplyWaterDataGridViewTextBoxColumn";
            this.pPumpSupplyWaterDataGridViewTextBoxColumn.Width = 72;
            // 
            // pPumpSoftWaterDataGridViewTextBoxColumn
            // 
            this.pPumpSoftWaterDataGridViewTextBoxColumn.DataPropertyName = "P_Pump_SoftWater";
            this.pPumpSoftWaterDataGridViewTextBoxColumn.HeaderText = "软水泵压力";
            this.pPumpSoftWaterDataGridViewTextBoxColumn.Name = "pPumpSoftWaterDataGridViewTextBoxColumn";
            this.pPumpSoftWaterDataGridViewTextBoxColumn.Width = 72;
            // 
            // levelDeO2BoxDataGridViewTextBoxColumn
            // 
            this.levelDeO2BoxDataGridViewTextBoxColumn.DataPropertyName = "Level_DeO2Box";
            this.levelDeO2BoxDataGridViewTextBoxColumn.HeaderText = "除氧器水箱水位";
            this.levelDeO2BoxDataGridViewTextBoxColumn.Name = "levelDeO2BoxDataGridViewTextBoxColumn";
            this.levelDeO2BoxDataGridViewTextBoxColumn.Width = 83;
            // 
            // levelSoftWaterBoxDataGridViewTextBoxColumn
            // 
            this.levelSoftWaterBoxDataGridViewTextBoxColumn.DataPropertyName = "Level_SoftWaterBox";
            this.levelSoftWaterBoxDataGridViewTextBoxColumn.HeaderText = "软水箱水位";
            this.levelSoftWaterBoxDataGridViewTextBoxColumn.Name = "levelSoftWaterBoxDataGridViewTextBoxColumn";
            this.levelSoftWaterBoxDataGridViewTextBoxColumn.Width = 72;
            // 
            // pMainPipeSteamDataGridViewTextBoxColumn
            // 
            this.pMainPipeSteamDataGridViewTextBoxColumn.DataPropertyName = "P_MainPipe_Steam";
            this.pMainPipeSteamDataGridViewTextBoxColumn.HeaderText = "总蒸汽管压力";
            this.pMainPipeSteamDataGridViewTextBoxColumn.Name = "pMainPipeSteamDataGridViewTextBoxColumn";
            this.pMainPipeSteamDataGridViewTextBoxColumn.Width = 72;
            // 
            // timeStartDataGridViewTextBoxColumn
            // 
            this.timeStartDataGridViewTextBoxColumn.DataPropertyName = "Time_Start";
            this.timeStartDataGridViewTextBoxColumn.HeaderText = "补水开始时刻";
            this.timeStartDataGridViewTextBoxColumn.Name = "timeStartDataGridViewTextBoxColumn";
            this.timeStartDataGridViewTextBoxColumn.Width = 72;
            // 
            // timeStopDataGridViewTextBoxColumn
            // 
            this.timeStopDataGridViewTextBoxColumn.DataPropertyName = "Time_Stop";
            this.timeStopDataGridViewTextBoxColumn.HeaderText = "补水结束时刻";
            this.timeStopDataGridViewTextBoxColumn.Name = "timeStopDataGridViewTextBoxColumn";
            this.timeStopDataGridViewTextBoxColumn.Width = 72;
            // 
            // timeBlowDataGridViewTextBoxColumn
            // 
            this.timeBlowDataGridViewTextBoxColumn.DataPropertyName = "Time_Blow";
            this.timeBlowDataGridViewTextBoxColumn.HeaderText = "开吹时刻";
            this.timeBlowDataGridViewTextBoxColumn.Name = "timeBlowDataGridViewTextBoxColumn";
            this.timeBlowDataGridViewTextBoxColumn.Width = 61;
            // 
            // endFlagDataGridViewCheckBoxColumn
            // 
            this.endFlagDataGridViewCheckBoxColumn.DataPropertyName = "EndFlag";
            this.endFlagDataGridViewCheckBoxColumn.HeaderText = "结束标志";
            this.endFlagDataGridViewCheckBoxColumn.Name = "endFlagDataGridViewCheckBoxColumn";
            this.endFlagDataGridViewCheckBoxColumn.Width = 42;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShift;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftDataGridViewTextBoxColumn.Width = 51;
            // 
            // dsShift
            // 
            this.dsShift.AutoSubscribe = false;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = "";
            this.dsShift.InsertMethod = "";
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "CODE_GROUP_DES = \'班次\'";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift.SubscribeTarget = "";
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "";
            this.dsShift.UpdateMethod = "";
            this.dsShift.UpdateTrigger = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTableCode,
            this.coldsShiftL3DataTableCode_Des,
            this.coldsShiftL3DataTableCode_Group,
            this.coldsShiftL3DataTableCode_Group_Des});
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
            // coldsShiftL3DataTableCode_Group
            // 
            this.coldsShiftL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsShiftL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsShiftL3DataTableCode_Group.Namespace = "";
            // 
            // coldsShiftL3DataTableCode_Group_Des
            // 
            this.coldsShiftL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsShiftL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsShiftL3DataTableCode_Group_Des.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamDataGridViewTextBoxColumn.Width = 51;
            // 
            // dsTeam
            // 
            this.dsTeam.AutoSubscribe = false;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = "";
            this.dsTeam.InsertMethod = "";
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "CODE_GROUP_DES = \'班别\'";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam.SubscribeTarget = "";
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "";
            this.dsTeam.UpdateMethod = "";
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTableCode,
            this.coldsTeamL3DataTableCode_Des,
            this.coldsTeamL3DataTableCode_Group,
            this.coldsTeamL3DataTableCode_Group_Des});
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
            // coldsTeamL3DataTableCode_Group
            // 
            this.coldsTeamL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsTeamL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsTeamL3DataTableCode_Group.Namespace = "";
            // 
            // coldsTeamL3DataTableCode_Group_Des
            // 
            this.coldsTeamL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsTeamL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsTeamL3DataTableCode_Group_Des.Namespace = "";
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "操作员";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 61;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 52;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BindingSource = this.bsSupplyWater;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton6,
            this.toolStripSeparator1,
            this.toolStripTextBox2,
            this.toolStripLabel1,
            this.toolStripSeparator5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator6,
            this.toolStripLabel3,
            this.toolStripLabel2,
            this.dtStartTime,
            this.toolStripLabel5,
            this.dtEndTime,
            this.toolStripLabel6,
            this.btnQuery});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton8;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton7;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton6;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator2.Size = new System.Drawing.Size(1024, 25);
            this.bindingNavigator2.TabIndex = 21;
            this.bindingNavigator2.Text = "bindingNavigator2";
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
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到上一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel3.Text = "          ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "选择时间:";
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
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel5.Text = "-";
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
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel6.Text = "     ";
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // EquipSupplyWaterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dvSupplyWater);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.toolStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipSupplyWaterFrm";
            this.TabText = "汽化冷却补水管理";
            this.Text = "汽化冷却补水管理";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSupplyWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSupplyWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvSupplyWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.DataGridView dvSupplyWater;
        private AppSvrHMI.L3DataSet dsSupplyWater;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Windows.Forms.BindingSource bsSupplyWater;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsAdjustSetL3DataTableBOFID;
        private System.Data.DataColumn coldsAdjustSetL3DataTableHeatID;
        private System.Data.DataColumn coldsAdjustSetL3DataTableLevel_Boil;
        private System.Data.DataColumn coldsAdjustSetL3DataTableP_Boil;
        private System.Data.DataColumn coldsAdjustSetL3DataTableP_Pump_SupplyWater;
        private System.Data.DataColumn coldsAdjustSetL3DataTableP_Pump_SoftWater;
        private System.Data.DataColumn coldsAdjustSetL3DataTableLevel_DeO2Box;
        private System.Data.DataColumn coldsAdjustSetL3DataTableLevel_SoftWaterBox;
        private System.Data.DataColumn coldsAdjustSetL3DataTableP_MainPipe_Steam;
        private System.Data.DataColumn coldsAdjustSetL3DataTableTime_Start;
        private System.Data.DataColumn coldsAdjustSetL3DataTableTime_Stop;
        private System.Data.DataColumn coldsAdjustSetL3DataTableTime_Blow;
        private System.Data.DataColumn coldsAdjustSetL3DataTableEndFlag;
        private System.Data.DataColumn coldsAdjustSetL3DataTableShift;
        private System.Data.DataColumn coldsAdjustSetL3DataTableTeam;
        private System.Data.DataColumn coldsAdjustSetL3DataTableOperator;
        private AppSvrHMI.L3DataSet dsTeam;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTableCode;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Des;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Group;
        private System.Data.DataColumn coldsTeamL3DataTableCode_Group_Des;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTableCode;
        private System.Data.DataColumn coldsShiftL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftL3DataTableCode_Group;
        private System.Data.DataColumn coldsShiftL3DataTableCode_Group_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelBoilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBoilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPumpSupplyWaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPumpSoftWaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDeO2BoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelSoftWaterBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMainPipeSteamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeBlowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn endFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtStartTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtEndTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton btnQuery;
    }
}