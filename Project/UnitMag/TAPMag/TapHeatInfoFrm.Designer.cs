namespace UnitMag.TAPMag
{
    partial class TapHeatInfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TapHeatInfoFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHeatID = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCtrlMain = new System.Windows.Forms.TabControl();
            this.tabBase = new System.Windows.Forms.TabPage();
            this.cmbTeam = new PxDataValid.PxComboBox();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGradeIndex = new System.Data.DataColumn();
            this.coldsBaseL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLadleNo = new System.Data.DataColumn();
            this.coldsBaseL3DataTablePreHeatID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsBaseL3DataTableShift = new System.Data.DataColumn();
            this.coldsBaseL3DataTableTeam = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLocked = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbShift = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSteelGradeIndex = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseCancel = new System.Windows.Forms.Button();
            this.btnBaseConfirm = new System.Windows.Forms.Button();
            this.tabMat = new System.Windows.Forms.TabPage();
            this.hmiRootPanel2 = new HMIBase.HMIRootPanel();
            this.dvMat = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTapAddtionType = new AppSvrHMI.L3DataSet();
            this.schemadsTapAddtionType = new System.Data.DataTable();
            this.coldsTapAddtionTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsTapAddtionTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischargeTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.typeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTapAddtionPropert = new AppSvrHMI.L3DataSet();
            this.schemadsTapAddtionPropert = new System.Data.DataTable();
            this.coldsTapAddtionPropertL3DataTableCode = new System.Data.DataColumn();
            this.coldsTapAddtionPropertL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTapAddtionPropertL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsMat = new System.Windows.Forms.BindingSource(this.components);
            this.dsMat = new AppSvrHMI.L3DataSet();
            this.schemadsMat = new System.Data.DataTable();
            this.coldsMatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatL3DataTableName = new System.Data.DataColumn();
            this.coldsMatL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMatL3DataTableElement = new System.Data.DataColumn();
            this.coldsMatL3DataTableWeight = new System.Data.DataColumn();
            this.coldsMatL3DataTableLength = new System.Data.DataColumn();
            this.coldsMatL3DataTableDischarge_Time = new System.Data.DataColumn();
            this.coldsMatL3DataTableType = new System.Data.DataColumn();
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
            this.btnAddMat = new System.Windows.Forms.ToolStripButton();
            this.pnlMat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMatCancel = new System.Windows.Forms.Button();
            this.btnMatOK = new System.Windows.Forms.Button();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.pxComboBox2 = new PxDataValid.PxComboBox();
            this.bsProcess = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcess = new AppSvrHMI.L3DataSet();
            this.schemadsProcess = new System.Data.DataTable();
            this.coldsProcessL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableName = new System.Data.DataColumn();
            this.coldsProcessL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTemp_Before_BlowAr = new System.Data.DataColumn();
            this.coldsProcessL3DataTableO2_Before_BlowAr = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTemp_BlownAr = new System.Data.DataColumn();
            this.coldsProcessL3DataTableO2_BlownAr = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlow_Mode = new System.Data.DataColumn();
            this.coldsProcessL3DataTableTune_Flag = new System.Data.DataColumn();
            this.coldsProcessL3DataTableBlowAr_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsProcessL3DataTableEnd_Time = new System.Data.DataColumn();
            this.dsTuneFlag = new AppSvrHMI.L3DataSet();
            this.schemadsTuneFlag = new System.Data.DataTable();
            this.coldsTuneFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTuneFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.pxComboBox1 = new PxDataValid.PxComboBox();
            this.dsBlowMode = new AppSvrHMI.L3DataSet();
            this.schemadsBlowMode = new System.Data.DataTable();
            this.coldsBlowModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBlowModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.pxTextBox4 = new PxDataValid.PxTextBox();
            this.pxTextBox3 = new PxDataValid.PxTextBox();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.txtTappingOxygen = new PxDataValid.PxTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.dtTappingEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtTappingStartTime = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.txtTappingTime = new PxDataValid.PxTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.pnlProcess = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProcessCancel = new System.Windows.Forms.Button();
            this.btnProcessOK = new System.Windows.Forms.Button();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.hmiRootPanel6 = new HMIBase.HMIRootPanel();
            this.dvTemp = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn = new DataGridValid.CalendarColumn();
            this.measureTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBOFTempMode = new AppSvrHMI.L3DataSet();
            this.schemadsBOFTempMode = new System.Data.DataTable();
            this.coldsBOFTempModeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBOFTempModeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsTemp = new System.Windows.Forms.BindingSource(this.components);
            this.dsTemp = new AppSvrHMI.L3DataSet();
            this.schemadsTemp = new System.Data.DataTable();
            this.coldsTempL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTempL3DataTableName = new System.Data.DataColumn();
            this.coldsTempL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsTempL3DataTableTemperature = new System.Data.DataColumn();
            this.coldsTempL3DataTableMeasureTime = new System.Data.DataColumn();
            this.coldsTempL3DataTableMeasureType = new System.Data.DataColumn();
            this.bnTemp = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTempAdd = new System.Windows.Forms.ToolStripButton();
            this.pnlTemp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTempCancel = new System.Windows.Forms.Button();
            this.btnTempOK = new System.Windows.Forms.Button();
            this.tabOxygen = new System.Windows.Forms.TabPage();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvOxygen = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxygenContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measureTimeDataGridViewTextBoxColumn1 = new DataGridValid.CalendarColumn();
            this.bsOxygen = new System.Windows.Forms.BindingSource(this.components);
            this.dsOxygen = new AppSvrHMI.L3DataSet();
            this.schemadsOxygen = new System.Data.DataTable();
            this.coldsOxygenL3DataTableGUID = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableName = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableOxygen_Content = new System.Data.DataColumn();
            this.coldsOxygenL3DataTableMeasureTime = new System.Data.DataColumn();
            this.bnOxygen = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddOxygen = new System.Windows.Forms.ToolStripButton();
            this.pnlOxygen = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOxygenCancel = new System.Windows.Forms.Button();
            this.btnOxygenOK = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.tabBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlBase.SuspendLayout();
            this.tabMat.SuspendLayout();
            this.hmiRootPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapAddtionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapAddtionType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapAddtionPropert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapAddtionPropert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMat)).BeginInit();
            this.bnMat.SuspendLayout();
            this.pnlMat.SuspendLayout();
            this.tabProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuneFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuneFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlowMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlowMode)).BeginInit();
            this.pnlProcess.SuspendLayout();
            this.tabTemp.SuspendLayout();
            this.hmiRootPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).BeginInit();
            this.bnTemp.SuspendLayout();
            this.pnlTemp.SuspendLayout();
            this.tabOxygen.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOxygen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOxygen)).BeginInit();
            this.bnOxygen.SuspendLayout();
            this.pnlOxygen.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(724, 29);
            this.panel3.TabIndex = 86;
            // 
            // txtHeatID
            // 
            this.txtHeatID.Enabled = false;
            this.txtHeatID.EnableNull = true;
            this.txtHeatID.ErropPr = null;
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
            this.txtHeatID.ToolTipValid = null;
            this.txtHeatID.ValidEable = true;
            this.txtHeatID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
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
            // tabCtrlMain
            // 
            this.tabCtrlMain.Controls.Add(this.tabBase);
            this.tabCtrlMain.Controls.Add(this.tabMat);
            this.tabCtrlMain.Controls.Add(this.tabProcess);
            this.tabCtrlMain.Controls.Add(this.tabTemp);
            this.tabCtrlMain.Controls.Add(this.tabOxygen);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 29);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(724, 263);
            this.tabCtrlMain.TabIndex = 87;
            // 
            // tabBase
            // 
            this.tabBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBase.Controls.Add(this.cmbTeam);
            this.tabBase.Controls.Add(this.cmbShift);
            this.tabBase.Controls.Add(this.pxTextBox1);
            this.tabBase.Controls.Add(this.label5);
            this.tabBase.Controls.Add(this.dateTimePicker5);
            this.tabBase.Controls.Add(this.label10);
            this.tabBase.Controls.Add(this.label4);
            this.tabBase.Controls.Add(this.label3);
            this.tabBase.Controls.Add(this.tbxSteelGradeIndex);
            this.tabBase.Controls.Add(this.label2);
            this.tabBase.Controls.Add(this.pnlBase);
            this.tabBase.Location = new System.Drawing.Point(4, 21);
            this.tabBase.Name = "tabBase";
            this.tabBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabBase.Size = new System.Drawing.Size(716, 238);
            this.tabBase.TabIndex = 0;
            this.tabBase.Text = "基本数据";
            this.tabBase.UseVisualStyleBackColor = true;
            // 
            // cmbTeam
            // 
            this.cmbTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Team", true));
            this.cmbTeam.DataSource = this.dsTeamID;
            this.cmbTeam.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeam.EnableNull = true;
            this.cmbTeam.ErropPr = null;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(235, 136);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(152, 20);
            this.cmbTeam.TabIndex = 109;
            this.cmbTeam.ToolTipValid = null;
            this.cmbTeam.ValidEable = true;
            this.cmbTeam.ValueMember = "L3DataTable.Code";
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = null;
            this.dsBase.InsertMethod = null;
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = null;
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Base_Data";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableGUID,
            this.coldsBaseL3DataTableName,
            this.coldsBaseL3DataTableHeatID,
            this.coldsBaseL3DataTableSteelGradeIndex,
            this.coldsBaseL3DataTableSteelGrade,
            this.coldsBaseL3DataTableLadleNo,
            this.coldsBaseL3DataTablePreHeatID,
            this.coldsBaseL3DataTableProductionDate,
            this.coldsBaseL3DataTableShift,
            this.coldsBaseL3DataTableTeam,
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
            // coldsBaseL3DataTablePreHeatID
            // 
            this.coldsBaseL3DataTablePreHeatID.Caption = "PreHeatID";
            this.coldsBaseL3DataTablePreHeatID.ColumnName = "PreHeatID";
            this.coldsBaseL3DataTablePreHeatID.Namespace = "";
            // 
            // coldsBaseL3DataTableProductionDate
            // 
            this.coldsBaseL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsBaseL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableProductionDate.Namespace = "";
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
            // coldsBaseL3DataTableLocked
            // 
            this.coldsBaseL3DataTableLocked.Caption = "Locked";
            this.coldsBaseL3DataTableLocked.ColumnName = "Locked";
            this.coldsBaseL3DataTableLocked.DataType = typeof(short);
            this.coldsBaseL3DataTableLocked.Namespace = "";
            // 
            // dsTeamID
            // 
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
            // cmbShift
            // 
            this.cmbShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShift.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBase, "Shift", true));
            this.cmbShift.DataSource = this.dsShiftID;
            this.cmbShift.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShift.EnableNull = true;
            this.cmbShift.ErropPr = null;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(235, 109);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(152, 20);
            this.cmbShift.TabIndex = 109;
            this.cmbShift.ToolTipValid = null;
            this.cmbShift.ValidEable = true;
            this.cmbShift.ValueMember = "L3DataTable.Code";
            // 
            // dsShiftID
            // 
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
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "LadleNo", true));
            this.pxTextBox1.EnableNull = false;
            this.pxTextBox1.ErropPr = this.errorProvider1;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(235, 54);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Size = new System.Drawing.Size(152, 21);
            this.pxTextBox1.TabIndex = 108;
            this.pxTextBox1.ToolTipValid = this.toolTip1;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 107;
            this.label5.Text = "钢包号:";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBase, "ProductionDate", true));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(235, 80);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(152, 21);
            this.dateTimePicker5.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 104;
            this.label10.Text = "生产日期:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 96;
            this.label4.Text = "班别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 112);
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
            this.tbxSteelGradeIndex.Length = 8;
            this.tbxSteelGradeIndex.Location = new System.Drawing.Point(235, 28);
            this.tbxSteelGradeIndex.Max = 0;
            this.tbxSteelGradeIndex.MaxStrLength = 0;
            this.tbxSteelGradeIndex.Min = 0;
            this.tbxSteelGradeIndex.MinStrLength = 0;
            this.tbxSteelGradeIndex.Name = "tbxSteelGradeIndex";
            this.tbxSteelGradeIndex.Precision = 0;
            this.tbxSteelGradeIndex.Size = new System.Drawing.Size(152, 21);
            this.tbxSteelGradeIndex.TabIndex = 93;
            this.tbxSteelGradeIndex.ToolTipValid = this.toolTip1;
            this.tbxSteelGradeIndex.ValidEable = true;
            this.tbxSteelGradeIndex.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 92;
            this.label2.Text = "炼钢记号:";
            // 
            // pnlBase
            // 
            this.pnlBase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBase.Controls.Add(this.btnBaseCancel);
            this.pnlBase.Controls.Add(this.btnBaseConfirm);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlBase.Location = new System.Drawing.Point(3, 200);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(708, 33);
            this.pnlBase.TabIndex = 89;
            // 
            // btnBaseCancel
            // 
            this.btnBaseCancel.Location = new System.Drawing.Point(626, 3);
            this.btnBaseCancel.Name = "btnBaseCancel";
            this.btnBaseCancel.Size = new System.Drawing.Size(75, 23);
            this.btnBaseCancel.TabIndex = 87;
            this.btnBaseCancel.Text = "取消";
            this.btnBaseCancel.UseVisualStyleBackColor = true;
            this.btnBaseCancel.Click += new System.EventHandler(this.btnBaseCancel_Click);
            // 
            // btnBaseConfirm
            // 
            this.btnBaseConfirm.Location = new System.Drawing.Point(545, 3);
            this.btnBaseConfirm.Name = "btnBaseConfirm";
            this.btnBaseConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnBaseConfirm.TabIndex = 86;
            this.btnBaseConfirm.Text = "确认";
            this.btnBaseConfirm.UseVisualStyleBackColor = true;
            this.btnBaseConfirm.Click += new System.EventHandler(this.btnBaseConfirm_Click);
            // 
            // tabMat
            // 
            this.tabMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMat.Controls.Add(this.hmiRootPanel2);
            this.tabMat.Controls.Add(this.pnlMat);
            this.tabMat.Location = new System.Drawing.Point(4, 21);
            this.tabMat.Name = "tabMat";
            this.tabMat.Padding = new System.Windows.Forms.Padding(3);
            this.tabMat.Size = new System.Drawing.Size(716, 238);
            this.tabMat.TabIndex = 1;
            this.tabMat.Text = "加料数据";
            this.tabMat.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel2
            // 
            this.hmiRootPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel2.Controls.Add(this.dvMat);
            this.hmiRootPanel2.Controls.Add(this.bnMat);
            this.hmiRootPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel2.Location = new System.Drawing.Point(3, 3);
            this.hmiRootPanel2.Name = "hmiRootPanel2";
            this.hmiRootPanel2.Size = new System.Drawing.Size(708, 197);
            this.hmiRootPanel2.TabIndex = 90;
            // 
            // dvMat
            // 
            this.dvMat.AllowUserToAddRows = false;
            this.dvMat.AutoGenerateColumns = false;
            this.dvMat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn,
            this.elementDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.dischargeTimeDataGridViewTextBoxColumn,
            this.typeDataGridViewCheckBoxColumn});
            this.dvMat.DataSource = this.bsMat;
            this.dvMat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMat.Location = new System.Drawing.Point(0, 25);
            this.dvMat.Name = "dvMat";
            this.dvMat.RowTemplate.Height = 23;
            this.dvMat.Size = new System.Drawing.Size(704, 168);
            this.dvMat.TabIndex = 96;
            this.dvMat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            // 
            // elementDataGridViewTextBoxColumn
            // 
            this.elementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.elementDataGridViewTextBoxColumn.DataPropertyName = "Element";
            this.elementDataGridViewTextBoxColumn.DataSource = this.dsTapAddtionType;
            this.elementDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.elementDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.elementDataGridViewTextBoxColumn.HeaderText = "加料代码";
            this.elementDataGridViewTextBoxColumn.Name = "elementDataGridViewTextBoxColumn";
            this.elementDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.elementDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.elementDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsTapAddtionType
            // 
            this.dsTapAddtionType.DataSetName = "L3DataSet";
            this.dsTapAddtionType.DeleteMethod = null;
            this.dsTapAddtionType.InsertMethod = null;
            this.dsTapAddtionType.L3DataAdapter = this.Adapter;
            this.dsTapAddtionType.LoadEvent = "Click";
            this.dsTapAddtionType.LoadTrigger = null;
            this.dsTapAddtionType.RefreshValve = 1000;
            this.dsTapAddtionType.SourceCommand = null;
            this.dsTapAddtionType.SourceCondition = "Code_Group = \'TAP_Addtion_Type\'";
            this.dsTapAddtionType.SourceMethod = "";
            this.dsTapAddtionType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTapAddtionType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTapAddtionType.SubscribeTarget = null;
            this.dsTapAddtionType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapAddtionType});
            this.dsTapAddtionType.UpdateEvent = "Click";
            this.dsTapAddtionType.UpdateMethod = null;
            this.dsTapAddtionType.UpdateTrigger = null;
            // 
            // schemadsTapAddtionType
            // 
            this.schemadsTapAddtionType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTapAddtionTypeL3DataTableCode,
            this.coldsTapAddtionTypeL3DataTableCode_Des});
            this.schemadsTapAddtionType.TableName = "L3DataTable";
            // 
            // coldsTapAddtionTypeL3DataTableCode
            // 
            this.coldsTapAddtionTypeL3DataTableCode.Caption = "Code";
            this.coldsTapAddtionTypeL3DataTableCode.ColumnName = "Code";
            this.coldsTapAddtionTypeL3DataTableCode.Namespace = "";
            // 
            // coldsTapAddtionTypeL3DataTableCode_Des
            // 
            this.coldsTapAddtionTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTapAddtionTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTapAddtionTypeL3DataTableCode_Des.Namespace = "";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "加料量";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "长度";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // dischargeTimeDataGridViewTextBoxColumn
            // 
            this.dischargeTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dischargeTimeDataGridViewTextBoxColumn.DataPropertyName = "Discharge_Time";
            dataGridViewCellStyle1.Format = "g";
            this.dischargeTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dischargeTimeDataGridViewTextBoxColumn.HeaderText = "加料时刻";
            this.dischargeTimeDataGridViewTextBoxColumn.Name = "dischargeTimeDataGridViewTextBoxColumn";
            this.dischargeTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dischargeTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dischargeTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // typeDataGridViewCheckBoxColumn
            // 
            this.typeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewCheckBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewCheckBoxColumn.DataSource = this.dsTapAddtionPropert;
            this.typeDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.typeDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewCheckBoxColumn.HeaderText = "加料性质";
            this.typeDataGridViewCheckBoxColumn.Name = "typeDataGridViewCheckBoxColumn";
            this.typeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsTapAddtionPropert
            // 
            this.dsTapAddtionPropert.DataSetName = "L3DataSet";
            this.dsTapAddtionPropert.DeleteMethod = null;
            this.dsTapAddtionPropert.InsertMethod = null;
            this.dsTapAddtionPropert.L3DataAdapter = this.Adapter;
            this.dsTapAddtionPropert.LoadEvent = "Click";
            this.dsTapAddtionPropert.LoadTrigger = null;
            this.dsTapAddtionPropert.RefreshValve = 1000;
            this.dsTapAddtionPropert.SourceCommand = null;
            this.dsTapAddtionPropert.SourceCondition = "Code_Group = \'TAP_Addtion_Propert\'";
            this.dsTapAddtionPropert.SourceMethod = "";
            this.dsTapAddtionPropert.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTapAddtionPropert.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTapAddtionPropert.SubscribeTarget = null;
            this.dsTapAddtionPropert.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapAddtionPropert});
            this.dsTapAddtionPropert.UpdateEvent = "Click";
            this.dsTapAddtionPropert.UpdateMethod = null;
            this.dsTapAddtionPropert.UpdateTrigger = null;
            // 
            // schemadsTapAddtionPropert
            // 
            this.schemadsTapAddtionPropert.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTapAddtionPropertL3DataTableCode,
            this.coldsTapAddtionPropertL3DataTableCode_Des,
            this.coldsTapAddtionPropertL3DataTableCode_Val_Long});
            this.schemadsTapAddtionPropert.TableName = "L3DataTable";
            // 
            // coldsTapAddtionPropertL3DataTableCode
            // 
            this.coldsTapAddtionPropertL3DataTableCode.Caption = "Code";
            this.coldsTapAddtionPropertL3DataTableCode.ColumnName = "Code";
            this.coldsTapAddtionPropertL3DataTableCode.Namespace = "";
            // 
            // coldsTapAddtionPropertL3DataTableCode_Des
            // 
            this.coldsTapAddtionPropertL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTapAddtionPropertL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTapAddtionPropertL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTapAddtionPropertL3DataTableCode_Val_Long
            // 
            this.coldsTapAddtionPropertL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTapAddtionPropertL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTapAddtionPropertL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsTapAddtionPropertL3DataTableCode_Val_Long.Namespace = "";
            // 
            // bsMat
            // 
            this.bsMat.DataMember = "L3DataTable";
            this.bsMat.DataSource = this.dsMat;
            // 
            // dsMat
            // 
            this.dsMat.DataSetName = "L3DataSet";
            this.dsMat.DeleteMethod = null;
            this.dsMat.InsertMethod = null;
            this.dsMat.L3DataAdapter = this.Adapter;
            this.dsMat.LoadEvent = "Click";
            this.dsMat.LoadTrigger = null;
            this.dsMat.RefreshValve = 1000;
            this.dsMat.SourceCommand = null;
            this.dsMat.SourceCondition = null;
            this.dsMat.SourceMethod = "";
            this.dsMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMat.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Addition_Data";
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
            this.coldsMatL3DataTableHeatID,
            this.coldsMatL3DataTableElement,
            this.coldsMatL3DataTableWeight,
            this.coldsMatL3DataTableLength,
            this.coldsMatL3DataTableDischarge_Time,
            this.coldsMatL3DataTableType});
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
            // coldsMatL3DataTableLength
            // 
            this.coldsMatL3DataTableLength.Caption = "Length";
            this.coldsMatL3DataTableLength.ColumnName = "Length";
            this.coldsMatL3DataTableLength.DataType = typeof(float);
            this.coldsMatL3DataTableLength.Namespace = "";
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
            this.bnMat.Size = new System.Drawing.Size(704, 25);
            this.bnMat.TabIndex = 95;
            this.bnMat.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
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
            // btnAddMat
            // 
            this.btnAddMat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddMat.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMat.Image")));
            this.btnAddMat.Name = "btnAddMat";
            this.btnAddMat.RightToLeftAutoMirrorImage = true;
            this.btnAddMat.Size = new System.Drawing.Size(23, 22);
            this.btnAddMat.Text = "新添";
            this.btnAddMat.Click += new System.EventHandler(this.btnAddMat_Click);
            // 
            // pnlMat
            // 
            this.pnlMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMat.Controls.Add(this.btnMatCancel);
            this.pnlMat.Controls.Add(this.btnMatOK);
            this.pnlMat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMat.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlMat.Location = new System.Drawing.Point(3, 200);
            this.pnlMat.Name = "pnlMat";
            this.pnlMat.Size = new System.Drawing.Size(708, 33);
            this.pnlMat.TabIndex = 89;
            // 
            // btnMatCancel
            // 
            this.btnMatCancel.Location = new System.Drawing.Point(626, 3);
            this.btnMatCancel.Name = "btnMatCancel";
            this.btnMatCancel.Size = new System.Drawing.Size(75, 23);
            this.btnMatCancel.TabIndex = 87;
            this.btnMatCancel.Text = "取消";
            this.btnMatCancel.UseVisualStyleBackColor = true;
            this.btnMatCancel.Click += new System.EventHandler(this.btnMatCancel_Click);
            // 
            // btnMatOK
            // 
            this.btnMatOK.Location = new System.Drawing.Point(545, 3);
            this.btnMatOK.Name = "btnMatOK";
            this.btnMatOK.Size = new System.Drawing.Size(75, 23);
            this.btnMatOK.TabIndex = 86;
            this.btnMatOK.Text = "确认";
            this.btnMatOK.UseVisualStyleBackColor = true;
            this.btnMatOK.Click += new System.EventHandler(this.btnMatOK_Click);
            // 
            // tabProcess
            // 
            this.tabProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProcess.Controls.Add(this.pxComboBox2);
            this.tabProcess.Controls.Add(this.pxComboBox1);
            this.tabProcess.Controls.Add(this.pxTextBox4);
            this.tabProcess.Controls.Add(this.pxTextBox3);
            this.tabProcess.Controls.Add(this.pxTextBox2);
            this.tabProcess.Controls.Add(this.txtTappingOxygen);
            this.tabProcess.Controls.Add(this.label41);
            this.tabProcess.Controls.Add(this.dtTappingEndTime);
            this.tabProcess.Controls.Add(this.dtTappingStartTime);
            this.tabProcess.Controls.Add(this.label27);
            this.tabProcess.Controls.Add(this.txtTappingTime);
            this.tabProcess.Controls.Add(this.label28);
            this.tabProcess.Controls.Add(this.label29);
            this.tabProcess.Controls.Add(this.label30);
            this.tabProcess.Controls.Add(this.label31);
            this.tabProcess.Controls.Add(this.label32);
            this.tabProcess.Controls.Add(this.label33);
            this.tabProcess.Controls.Add(this.label34);
            this.tabProcess.Controls.Add(this.pnlProcess);
            this.tabProcess.Location = new System.Drawing.Point(4, 21);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(716, 238);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "冶炼数据";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // pxComboBox2
            // 
            this.pxComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "Tune_Flag", true));
            this.pxComboBox2.DataSource = this.dsTuneFlag;
            this.pxComboBox2.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox2.EnableNull = true;
            this.pxComboBox2.ErropPr = null;
            this.pxComboBox2.FormattingEnabled = true;
            this.pxComboBox2.Location = new System.Drawing.Point(328, 83);
            this.pxComboBox2.Name = "pxComboBox2";
            this.pxComboBox2.Size = new System.Drawing.Size(62, 20);
            this.pxComboBox2.TabIndex = 170;
            this.pxComboBox2.ToolTipValid = null;
            this.pxComboBox2.ValidEable = true;
            this.pxComboBox2.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // bsProcess
            // 
            this.bsProcess.DataMember = "L3DataTable";
            this.bsProcess.DataSource = this.dsProcess;
            // 
            // dsProcess
            // 
            this.dsProcess.DataSetName = "L3DataSet";
            this.dsProcess.DeleteMethod = null;
            this.dsProcess.InsertMethod = null;
            this.dsProcess.L3DataAdapter = this.Adapter;
            this.dsProcess.LoadEvent = "Click";
            this.dsProcess.LoadTrigger = null;
            this.dsProcess.RefreshValve = 1000;
            this.dsProcess.SourceCommand = null;
            this.dsProcess.SourceCondition = null;
            this.dsProcess.SourceMethod = "";
            this.dsProcess.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcess.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Process_Data";
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
            this.coldsProcessL3DataTableTemp_Before_BlowAr,
            this.coldsProcessL3DataTableO2_Before_BlowAr,
            this.coldsProcessL3DataTableTemp_BlownAr,
            this.coldsProcessL3DataTableO2_BlownAr,
            this.coldsProcessL3DataTableBlow_Mode,
            this.coldsProcessL3DataTableTune_Flag,
            this.coldsProcessL3DataTableBlowAr_Time,
            this.coldsProcessL3DataTableStart_Time,
            this.coldsProcessL3DataTableEnd_Time});
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
            // coldsProcessL3DataTableTemp_Before_BlowAr
            // 
            this.coldsProcessL3DataTableTemp_Before_BlowAr.Caption = "Temp_Before_BlowAr";
            this.coldsProcessL3DataTableTemp_Before_BlowAr.ColumnName = "Temp_Before_BlowAr";
            this.coldsProcessL3DataTableTemp_Before_BlowAr.DataType = typeof(int);
            this.coldsProcessL3DataTableTemp_Before_BlowAr.Namespace = "";
            // 
            // coldsProcessL3DataTableO2_Before_BlowAr
            // 
            this.coldsProcessL3DataTableO2_Before_BlowAr.Caption = "O2_Before_BlowAr";
            this.coldsProcessL3DataTableO2_Before_BlowAr.ColumnName = "O2_Before_BlowAr";
            this.coldsProcessL3DataTableO2_Before_BlowAr.DataType = typeof(float);
            this.coldsProcessL3DataTableO2_Before_BlowAr.Namespace = "";
            // 
            // coldsProcessL3DataTableTemp_BlownAr
            // 
            this.coldsProcessL3DataTableTemp_BlownAr.Caption = "Temp_BlownAr";
            this.coldsProcessL3DataTableTemp_BlownAr.ColumnName = "Temp_BlownAr";
            this.coldsProcessL3DataTableTemp_BlownAr.DataType = typeof(int);
            this.coldsProcessL3DataTableTemp_BlownAr.Namespace = "";
            // 
            // coldsProcessL3DataTableO2_BlownAr
            // 
            this.coldsProcessL3DataTableO2_BlownAr.Caption = "O2_BlownAr";
            this.coldsProcessL3DataTableO2_BlownAr.ColumnName = "O2_BlownAr";
            this.coldsProcessL3DataTableO2_BlownAr.DataType = typeof(float);
            this.coldsProcessL3DataTableO2_BlownAr.Namespace = "";
            // 
            // coldsProcessL3DataTableBlow_Mode
            // 
            this.coldsProcessL3DataTableBlow_Mode.Caption = "Blow_Mode";
            this.coldsProcessL3DataTableBlow_Mode.ColumnName = "Blow_Mode";
            this.coldsProcessL3DataTableBlow_Mode.DataType = typeof(short);
            this.coldsProcessL3DataTableBlow_Mode.Namespace = "";
            // 
            // coldsProcessL3DataTableTune_Flag
            // 
            this.coldsProcessL3DataTableTune_Flag.Caption = "Tune_Flag";
            this.coldsProcessL3DataTableTune_Flag.ColumnName = "Tune_Flag";
            this.coldsProcessL3DataTableTune_Flag.DataType = typeof(short);
            this.coldsProcessL3DataTableTune_Flag.Namespace = "";
            // 
            // coldsProcessL3DataTableBlowAr_Time
            // 
            this.coldsProcessL3DataTableBlowAr_Time.Caption = "BlowAr_Time";
            this.coldsProcessL3DataTableBlowAr_Time.ColumnName = "BlowAr_Time";
            this.coldsProcessL3DataTableBlowAr_Time.DataType = typeof(int);
            this.coldsProcessL3DataTableBlowAr_Time.Namespace = "";
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
            // dsTuneFlag
            // 
            this.dsTuneFlag.DataSetName = "L3DataSet";
            this.dsTuneFlag.DeleteMethod = null;
            this.dsTuneFlag.InsertMethod = null;
            this.dsTuneFlag.L3DataAdapter = this.Adapter;
            this.dsTuneFlag.LoadEvent = "Click";
            this.dsTuneFlag.LoadTrigger = null;
            this.dsTuneFlag.RefreshValve = 1000;
            this.dsTuneFlag.SourceCommand = null;
            this.dsTuneFlag.SourceCondition = "CODE_GROUP = \'Tune_Flag\'";
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
            // pxComboBox1
            // 
            this.pxComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcess, "Blow_Mode", true));
            this.pxComboBox1.DataSource = this.dsBlowMode;
            this.pxComboBox1.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox1.EnableNull = true;
            this.pxComboBox1.ErropPr = null;
            this.pxComboBox1.FormattingEnabled = true;
            this.pxComboBox1.Location = new System.Drawing.Point(477, 109);
            this.pxComboBox1.Name = "pxComboBox1";
            this.pxComboBox1.Size = new System.Drawing.Size(62, 20);
            this.pxComboBox1.TabIndex = 170;
            this.pxComboBox1.ToolTipValid = null;
            this.pxComboBox1.ValidEable = true;
            this.pxComboBox1.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsBlowMode
            // 
            this.dsBlowMode.DataSetName = "L3DataSet";
            this.dsBlowMode.DeleteMethod = null;
            this.dsBlowMode.InsertMethod = null;
            this.dsBlowMode.L3DataAdapter = this.Adapter;
            this.dsBlowMode.LoadEvent = "Click";
            this.dsBlowMode.LoadTrigger = null;
            this.dsBlowMode.RefreshValve = 1000;
            this.dsBlowMode.SourceCommand = null;
            this.dsBlowMode.SourceCondition = "CODE_GROUP = \'Blow_Mode\'";
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
            this.coldsBlowModeL3DataTableCode_Des,
            this.coldsBlowModeL3DataTableCode_Val_Long});
            this.schemadsBlowMode.TableName = "L3DataTable";
            // 
            // coldsBlowModeL3DataTableCode_Des
            // 
            this.coldsBlowModeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBlowModeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBlowModeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBlowModeL3DataTableCode_Val_Long
            // 
            this.coldsBlowModeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsBlowModeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsBlowModeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsBlowModeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // pxTextBox4
            // 
            this.pxTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "O2_BlownAr", true));
            this.pxTextBox4.EnableNull = false;
            this.pxTextBox4.ErropPr = this.errorProvider1;
            this.pxTextBox4.Length = 0;
            this.pxTextBox4.Location = new System.Drawing.Point(477, 55);
            this.pxTextBox4.Max = 0;
            this.pxTextBox4.MaxStrLength = 0;
            this.pxTextBox4.Min = 0;
            this.pxTextBox4.MinStrLength = 0;
            this.pxTextBox4.Name = "pxTextBox4";
            this.pxTextBox4.Precision = 0;
            this.pxTextBox4.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox4.TabIndex = 169;
            this.pxTextBox4.ToolTipValid = this.toolTip1;
            this.pxTextBox4.ValidEable = true;
            this.pxTextBox4.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox3
            // 
            this.pxTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "O2_Before_BlowAr", true));
            this.pxTextBox3.EnableNull = false;
            this.pxTextBox3.ErropPr = this.errorProvider1;
            this.pxTextBox3.Length = 0;
            this.pxTextBox3.Location = new System.Drawing.Point(477, 28);
            this.pxTextBox3.Max = 0;
            this.pxTextBox3.MaxStrLength = 0;
            this.pxTextBox3.Min = 0;
            this.pxTextBox3.MinStrLength = 0;
            this.pxTextBox3.Name = "pxTextBox3";
            this.pxTextBox3.Precision = 0;
            this.pxTextBox3.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox3.TabIndex = 168;
            this.pxTextBox3.ToolTipValid = this.toolTip1;
            this.pxTextBox3.ValidEable = true;
            this.pxTextBox3.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Temp_BlownAr", true));
            this.pxTextBox2.EnableNull = false;
            this.pxTextBox2.ErropPr = this.errorProvider1;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(328, 55);
            this.pxTextBox2.Max = 0;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = 0;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            this.pxTextBox2.Size = new System.Drawing.Size(62, 21);
            this.pxTextBox2.TabIndex = 167;
            this.pxTextBox2.ToolTipValid = this.toolTip1;
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtTappingOxygen
            // 
            this.txtTappingOxygen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "Temp_Before_BlowAr", true));
            this.txtTappingOxygen.EnableNull = false;
            this.txtTappingOxygen.ErropPr = this.errorProvider1;
            this.txtTappingOxygen.Length = 0;
            this.txtTappingOxygen.Location = new System.Drawing.Point(328, 28);
            this.txtTappingOxygen.Max = 0;
            this.txtTappingOxygen.MaxStrLength = 0;
            this.txtTappingOxygen.Min = 0;
            this.txtTappingOxygen.MinStrLength = 0;
            this.txtTappingOxygen.Name = "txtTappingOxygen";
            this.txtTappingOxygen.Precision = 0;
            this.txtTappingOxygen.Size = new System.Drawing.Size(62, 21);
            this.txtTappingOxygen.TabIndex = 8;
            this.txtTappingOxygen.ToolTipValid = this.toolTip1;
            this.txtTappingOxygen.ValidEable = true;
            this.txtTappingOxygen.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 59);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(83, 12);
            this.label41.TabIndex = 166;
            this.label41.Text = "处理结束时刻:";
            // 
            // dtTappingEndTime
            // 
            this.dtTappingEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTappingEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "Start_Time", true));
            this.dtTappingEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTappingEndTime.Location = new System.Drawing.Point(98, 28);
            this.dtTappingEndTime.Name = "dtTappingEndTime";
            this.dtTappingEndTime.Size = new System.Drawing.Size(144, 21);
            this.dtTappingEndTime.TabIndex = 3;
            // 
            // dtTappingStartTime
            // 
            this.dtTappingStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTappingStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsProcess, "End_Time", true));
            this.dtTappingStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTappingStartTime.Location = new System.Drawing.Point(98, 55);
            this.dtTappingStartTime.Name = "dtTappingStartTime";
            this.dtTappingStartTime.Size = new System.Drawing.Size(144, 21);
            this.dtTappingStartTime.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 144;
            this.label27.Text = "处理开始时刻:";
            // 
            // txtTappingTime
            // 
            this.txtTappingTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcess, "BlowAr_Time", true));
            this.txtTappingTime.EnableNull = false;
            this.txtTappingTime.ErropPr = this.errorProvider1;
            this.txtTappingTime.Length = 0;
            this.txtTappingTime.Location = new System.Drawing.Point(477, 82);
            this.txtTappingTime.Max = 0;
            this.txtTappingTime.MaxStrLength = 0;
            this.txtTappingTime.Min = 0;
            this.txtTappingTime.MinStrLength = 0;
            this.txtTappingTime.Name = "txtTappingTime";
            this.txtTappingTime.Precision = 0;
            this.txtTappingTime.Size = new System.Drawing.Size(62, 21);
            this.txtTappingTime.TabIndex = 6;
            this.txtTappingTime.ToolTipValid = this.toolTip1;
            this.txtTappingTime.ValidEable = true;
            this.txtTappingTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(414, 86);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 12);
            this.label28.TabIndex = 142;
            this.label28.Text = "吹氩时间:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(263, 85);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 140;
            this.label29.Text = "是否调温:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(406, 112);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 12);
            this.label30.TabIndex = 138;
            this.label30.Text = "顶吹/底吹:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(402, 59);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 12);
            this.label31.TabIndex = 136;
            this.label31.Text = "氩后氧含量:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(263, 58);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 12);
            this.label32.TabIndex = 134;
            this.label32.Text = "氩后温度:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(402, 32);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 12);
            this.label33.TabIndex = 132;
            this.label33.Text = "氩前氧含量:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(263, 31);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 130;
            this.label34.Text = "氩前温度:";
            // 
            // pnlProcess
            // 
            this.pnlProcess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProcess.Controls.Add(this.btnProcessCancel);
            this.pnlProcess.Controls.Add(this.btnProcessOK);
            this.pnlProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProcess.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlProcess.Location = new System.Drawing.Point(3, 200);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(708, 33);
            this.pnlProcess.TabIndex = 89;
            // 
            // btnProcessCancel
            // 
            this.btnProcessCancel.Location = new System.Drawing.Point(626, 3);
            this.btnProcessCancel.Name = "btnProcessCancel";
            this.btnProcessCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProcessCancel.TabIndex = 87;
            this.btnProcessCancel.Text = "取消";
            this.btnProcessCancel.UseVisualStyleBackColor = true;
            this.btnProcessCancel.Click += new System.EventHandler(this.btnProcessCancel_Click);
            // 
            // btnProcessOK
            // 
            this.btnProcessOK.Location = new System.Drawing.Point(545, 3);
            this.btnProcessOK.Name = "btnProcessOK";
            this.btnProcessOK.Size = new System.Drawing.Size(75, 23);
            this.btnProcessOK.TabIndex = 86;
            this.btnProcessOK.Text = "确认";
            this.btnProcessOK.UseVisualStyleBackColor = true;
            this.btnProcessOK.Click += new System.EventHandler(this.btnProcessOK_Click);
            // 
            // tabTemp
            // 
            this.tabTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTemp.Controls.Add(this.hmiRootPanel6);
            this.tabTemp.Location = new System.Drawing.Point(4, 21);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemp.Size = new System.Drawing.Size(716, 238);
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
            this.hmiRootPanel6.Size = new System.Drawing.Size(708, 230);
            this.hmiRootPanel6.TabIndex = 0;
            // 
            // dvTemp
            // 
            this.dvTemp.AllowUserToAddRows = false;
            this.dvTemp.AutoGenerateColumns = false;
            this.dvTemp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn1,
            this.temperatureDataGridViewTextBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn,
            this.measureTypeDataGridViewCheckBoxColumn});
            this.dvTemp.DataSource = this.bsTemp;
            this.dvTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTemp.Location = new System.Drawing.Point(0, 25);
            this.dvTemp.Name = "dvTemp";
            this.dvTemp.RowTemplate.Height = 23;
            this.dvTemp.Size = new System.Drawing.Size(708, 172);
            this.dvTemp.TabIndex = 99;
            this.dvTemp.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn1
            // 
            this.heatIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heatIDDataGridViewTextBoxColumn1.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn1.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn1.Name = "heatIDDataGridViewTextBoxColumn1";
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "测温值";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // measureTimeDataGridViewTextBoxColumn
            // 
            this.measureTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.measureTimeDataGridViewTextBoxColumn.DataPropertyName = "MeasureTime";
            dataGridViewCellStyle2.Format = "g";
            this.measureTimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.measureTimeDataGridViewTextBoxColumn.HeaderText = "测温时刻";
            this.measureTimeDataGridViewTextBoxColumn.Name = "measureTimeDataGridViewTextBoxColumn";
            this.measureTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.measureTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // measureTypeDataGridViewCheckBoxColumn
            // 
            this.measureTypeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.measureTypeDataGridViewCheckBoxColumn.DataPropertyName = "MeasureType";
            this.measureTypeDataGridViewCheckBoxColumn.DataSource = this.dsBOFTempMode;
            this.measureTypeDataGridViewCheckBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.measureTypeDataGridViewCheckBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.measureTypeDataGridViewCheckBoxColumn.HeaderText = "测温类型";
            this.measureTypeDataGridViewCheckBoxColumn.Name = "measureTypeDataGridViewCheckBoxColumn";
            this.measureTypeDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTypeDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.measureTypeDataGridViewCheckBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsBOFTempMode
            // 
            this.dsBOFTempMode.DataSetName = "L3DataSet";
            this.dsBOFTempMode.DeleteMethod = null;
            this.dsBOFTempMode.InsertMethod = null;
            this.dsBOFTempMode.L3DataAdapter = this.Adapter;
            this.dsBOFTempMode.LoadEvent = "Click";
            this.dsBOFTempMode.LoadTrigger = null;
            this.dsBOFTempMode.RefreshValve = 1000;
            this.dsBOFTempMode.SourceCommand = null;
            this.dsBOFTempMode.SourceCondition = "CODE_GROUP = \'BOF_Temp_Mode\'";
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
            // bsTemp
            // 
            this.bsTemp.DataMember = "L3DataTable";
            this.bsTemp.DataSource = this.dsTemp;
            // 
            // dsTemp
            // 
            this.dsTemp.DataSetName = "L3DataSet";
            this.dsTemp.DeleteMethod = null;
            this.dsTemp.InsertMethod = null;
            this.dsTemp.L3DataAdapter = this.Adapter;
            this.dsTemp.LoadEvent = "Click";
            this.dsTemp.LoadTrigger = null;
            this.dsTemp.RefreshValve = 1000;
            this.dsTemp.SourceCommand = null;
            this.dsTemp.SourceCondition = null;
            this.dsTemp.SourceMethod = "";
            this.dsTemp.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTemp.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Temp_Data";
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
            this.coldsTempL3DataTableGUID,
            this.coldsTempL3DataTableName,
            this.coldsTempL3DataTableHeatID,
            this.coldsTempL3DataTableTemperature,
            this.coldsTempL3DataTableMeasureTime,
            this.coldsTempL3DataTableMeasureType});
            this.schemadsTemp.TableName = "L3DataTable";
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
            // coldsTempL3DataTableHeatID
            // 
            this.coldsTempL3DataTableHeatID.Caption = "HeatID";
            this.coldsTempL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsTempL3DataTableHeatID.Namespace = "";
            // 
            // coldsTempL3DataTableTemperature
            // 
            this.coldsTempL3DataTableTemperature.Caption = "Temperature";
            this.coldsTempL3DataTableTemperature.ColumnName = "Temperature";
            this.coldsTempL3DataTableTemperature.DataType = typeof(int);
            this.coldsTempL3DataTableTemperature.Namespace = "";
            // 
            // coldsTempL3DataTableMeasureTime
            // 
            this.coldsTempL3DataTableMeasureTime.Caption = "MeasureTime";
            this.coldsTempL3DataTableMeasureTime.ColumnName = "MeasureTime";
            this.coldsTempL3DataTableMeasureTime.DataType = typeof(System.DateTime);
            this.coldsTempL3DataTableMeasureTime.Namespace = "";
            // 
            // coldsTempL3DataTableMeasureType
            // 
            this.coldsTempL3DataTableMeasureType.Caption = "MeasureType";
            this.coldsTempL3DataTableMeasureType.ColumnName = "MeasureType";
            this.coldsTempL3DataTableMeasureType.DataType = typeof(short);
            this.coldsTempL3DataTableMeasureType.Namespace = "";
            // 
            // bnTemp
            // 
            this.bnTemp.AddNewItem = null;
            this.bnTemp.BindingSource = this.bsTemp;
            this.bnTemp.CountItem = this.toolStripLabel3;
            this.bnTemp.DeleteItem = null;
            this.bnTemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator9,
            this.btnTempAdd});
            this.bnTemp.Location = new System.Drawing.Point(0, 0);
            this.bnTemp.MoveFirstItem = this.toolStripButton9;
            this.bnTemp.MoveLastItem = this.toolStripButton12;
            this.bnTemp.MoveNextItem = this.toolStripButton11;
            this.bnTemp.MovePreviousItem = this.toolStripButton10;
            this.bnTemp.Name = "bnTemp";
            this.bnTemp.PositionItem = this.toolStripTextBox3;
            this.bnTemp.Size = new System.Drawing.Size(708, 25);
            this.bnTemp.TabIndex = 98;
            this.bnTemp.Text = "bindingNavigator1";
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
            // btnTempAdd
            // 
            this.btnTempAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTempAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnTempAdd.Image")));
            this.btnTempAdd.Name = "btnTempAdd";
            this.btnTempAdd.RightToLeftAutoMirrorImage = true;
            this.btnTempAdd.Size = new System.Drawing.Size(23, 22);
            this.btnTempAdd.Text = "新添";
            this.btnTempAdd.Click += new System.EventHandler(this.btnTempAdd_Click);
            // 
            // pnlTemp
            // 
            this.pnlTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTemp.Controls.Add(this.btnTempCancel);
            this.pnlTemp.Controls.Add(this.btnTempOK);
            this.pnlTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTemp.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlTemp.Location = new System.Drawing.Point(0, 197);
            this.pnlTemp.Name = "pnlTemp";
            this.pnlTemp.Size = new System.Drawing.Size(708, 33);
            this.pnlTemp.TabIndex = 92;
            // 
            // btnTempCancel
            // 
            this.btnTempCancel.Location = new System.Drawing.Point(626, 3);
            this.btnTempCancel.Name = "btnTempCancel";
            this.btnTempCancel.Size = new System.Drawing.Size(75, 23);
            this.btnTempCancel.TabIndex = 87;
            this.btnTempCancel.Text = "取消";
            this.btnTempCancel.UseVisualStyleBackColor = true;
            this.btnTempCancel.Click += new System.EventHandler(this.btnTempCancel_Click);
            // 
            // btnTempOK
            // 
            this.btnTempOK.Location = new System.Drawing.Point(545, 3);
            this.btnTempOK.Name = "btnTempOK";
            this.btnTempOK.Size = new System.Drawing.Size(75, 23);
            this.btnTempOK.TabIndex = 86;
            this.btnTempOK.Text = "确认";
            this.btnTempOK.UseVisualStyleBackColor = true;
            this.btnTempOK.Click += new System.EventHandler(this.btnTempOK_Click);
            // 
            // tabOxygen
            // 
            this.tabOxygen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabOxygen.Controls.Add(this.hmiRootPanel1);
            this.tabOxygen.Controls.Add(this.bnOxygen);
            this.tabOxygen.Controls.Add(this.pnlOxygen);
            this.tabOxygen.Location = new System.Drawing.Point(4, 21);
            this.tabOxygen.Name = "tabOxygen";
            this.tabOxygen.Padding = new System.Windows.Forms.Padding(3);
            this.tabOxygen.Size = new System.Drawing.Size(716, 238);
            this.tabOxygen.TabIndex = 10;
            this.tabOxygen.Text = "定氧数据";
            this.tabOxygen.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvOxygen);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(3, 28);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(708, 172);
            this.hmiRootPanel1.TabIndex = 102;
            // 
            // dvOxygen
            // 
            this.dvOxygen.AllowUserToAddRows = false;
            this.dvOxygen.AutoGenerateColumns = false;
            this.dvOxygen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvOxygen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvOxygen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn2,
            this.oxygenContentDataGridViewTextBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn1});
            this.dvOxygen.DataSource = this.bsOxygen;
            this.dvOxygen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvOxygen.Location = new System.Drawing.Point(0, 0);
            this.dvOxygen.Name = "dvOxygen";
            this.dvOxygen.RowTemplate.Height = 23;
            this.dvOxygen.Size = new System.Drawing.Size(708, 172);
            this.dvOxygen.TabIndex = 104;
            this.dvOxygen.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMat_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn2
            // 
            this.heatIDDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heatIDDataGridViewTextBoxColumn2.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn2.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn2.Name = "heatIDDataGridViewTextBoxColumn2";
            // 
            // oxygenContentDataGridViewTextBoxColumn
            // 
            this.oxygenContentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oxygenContentDataGridViewTextBoxColumn.DataPropertyName = "Oxygen_Content";
            this.oxygenContentDataGridViewTextBoxColumn.HeaderText = "定氧值";
            this.oxygenContentDataGridViewTextBoxColumn.Name = "oxygenContentDataGridViewTextBoxColumn";
            // 
            // measureTimeDataGridViewTextBoxColumn1
            // 
            this.measureTimeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.measureTimeDataGridViewTextBoxColumn1.DataPropertyName = "MeasureTime";
            dataGridViewCellStyle3.Format = "g";
            this.measureTimeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.measureTimeDataGridViewTextBoxColumn1.HeaderText = "定氧时刻";
            this.measureTimeDataGridViewTextBoxColumn1.Name = "measureTimeDataGridViewTextBoxColumn1";
            this.measureTimeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measureTimeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.measureTimeDataGridViewTextBoxColumn1.Width = 78;
            // 
            // bsOxygen
            // 
            this.bsOxygen.DataMember = "L3DataTable";
            this.bsOxygen.DataSource = this.dsOxygen;
            // 
            // dsOxygen
            // 
            this.dsOxygen.DataSetName = "L3DataSet";
            this.dsOxygen.DeleteMethod = null;
            this.dsOxygen.InsertMethod = null;
            this.dsOxygen.L3DataAdapter = this.Adapter;
            this.dsOxygen.LoadEvent = "Click";
            this.dsOxygen.LoadTrigger = null;
            this.dsOxygen.RefreshValve = 1000;
            this.dsOxygen.SourceCommand = null;
            this.dsOxygen.SourceCondition = null;
            this.dsOxygen.SourceMethod = "";
            this.dsOxygen.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOxygen.SourceURI = "XGMESLogic\\TapSideMag\\CTap_Oxygen_Data";
            this.dsOxygen.SubscribeTarget = null;
            this.dsOxygen.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOxygen});
            this.dsOxygen.UpdateEvent = "Click";
            this.dsOxygen.UpdateMethod = null;
            this.dsOxygen.UpdateTrigger = null;
            // 
            // schemadsOxygen
            // 
            this.schemadsOxygen.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOxygenL3DataTableGUID,
            this.coldsOxygenL3DataTableName,
            this.coldsOxygenL3DataTableHeatID,
            this.coldsOxygenL3DataTableOxygen_Content,
            this.coldsOxygenL3DataTableMeasureTime});
            this.schemadsOxygen.TableName = "L3DataTable";
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
            // coldsOxygenL3DataTableHeatID
            // 
            this.coldsOxygenL3DataTableHeatID.Caption = "HeatID";
            this.coldsOxygenL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsOxygenL3DataTableHeatID.Namespace = "";
            // 
            // coldsOxygenL3DataTableOxygen_Content
            // 
            this.coldsOxygenL3DataTableOxygen_Content.Caption = "Oxygen_Content";
            this.coldsOxygenL3DataTableOxygen_Content.ColumnName = "Oxygen_Content";
            this.coldsOxygenL3DataTableOxygen_Content.DataType = typeof(float);
            this.coldsOxygenL3DataTableOxygen_Content.Namespace = "";
            // 
            // coldsOxygenL3DataTableMeasureTime
            // 
            this.coldsOxygenL3DataTableMeasureTime.Caption = "MeasureTime";
            this.coldsOxygenL3DataTableMeasureTime.ColumnName = "MeasureTime";
            this.coldsOxygenL3DataTableMeasureTime.DataType = typeof(System.DateTime);
            this.coldsOxygenL3DataTableMeasureTime.Namespace = "";
            // 
            // bnOxygen
            // 
            this.bnOxygen.AddNewItem = null;
            this.bnOxygen.BindingSource = this.bsOxygen;
            this.bnOxygen.CountItem = this.toolStripLabel5;
            this.bnOxygen.DeleteItem = null;
            this.bnOxygen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator13,
            this.toolStripTextBox5,
            this.toolStripLabel5,
            this.toolStripSeparator14,
            this.toolStripButton19,
            this.toolStripButton20,
            this.toolStripSeparator15,
            this.btnAddOxygen});
            this.bnOxygen.Location = new System.Drawing.Point(3, 3);
            this.bnOxygen.MoveFirstItem = this.toolStripButton17;
            this.bnOxygen.MoveLastItem = this.toolStripButton20;
            this.bnOxygen.MoveNextItem = this.toolStripButton19;
            this.bnOxygen.MovePreviousItem = this.toolStripButton18;
            this.bnOxygen.Name = "bnOxygen";
            this.bnOxygen.PositionItem = this.toolStripTextBox5;
            this.bnOxygen.Size = new System.Drawing.Size(708, 25);
            this.bnOxygen.TabIndex = 101;
            this.bnOxygen.Text = "bindingNavigator4";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel5.Text = "/ {0}";
            this.toolStripLabel5.ToolTipText = "总项数";
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
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddOxygen
            // 
            this.btnAddOxygen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddOxygen.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOxygen.Image")));
            this.btnAddOxygen.Name = "btnAddOxygen";
            this.btnAddOxygen.RightToLeftAutoMirrorImage = true;
            this.btnAddOxygen.Size = new System.Drawing.Size(23, 22);
            this.btnAddOxygen.Text = "新添";
            this.btnAddOxygen.Click += new System.EventHandler(this.btnOxygenAdd_Click);
            // 
            // pnlOxygen
            // 
            this.pnlOxygen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOxygen.Controls.Add(this.btnOxygenCancel);
            this.pnlOxygen.Controls.Add(this.btnOxygenOK);
            this.pnlOxygen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOxygen.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlOxygen.Location = new System.Drawing.Point(3, 200);
            this.pnlOxygen.Name = "pnlOxygen";
            this.pnlOxygen.Size = new System.Drawing.Size(708, 33);
            this.pnlOxygen.TabIndex = 92;
            // 
            // btnOxygenCancel
            // 
            this.btnOxygenCancel.Location = new System.Drawing.Point(626, 3);
            this.btnOxygenCancel.Name = "btnOxygenCancel";
            this.btnOxygenCancel.Size = new System.Drawing.Size(75, 23);
            this.btnOxygenCancel.TabIndex = 87;
            this.btnOxygenCancel.Text = "取消";
            this.btnOxygenCancel.UseVisualStyleBackColor = true;
            this.btnOxygenCancel.Click += new System.EventHandler(this.btnOxygenCancel_Click);
            // 
            // btnOxygenOK
            // 
            this.btnOxygenOK.Location = new System.Drawing.Point(545, 3);
            this.btnOxygenOK.Name = "btnOxygenOK";
            this.btnOxygenOK.Size = new System.Drawing.Size(75, 23);
            this.btnOxygenOK.TabIndex = 86;
            this.btnOxygenOK.Text = "确认";
            this.btnOxygenOK.UseVisualStyleBackColor = true;
            this.btnOxygenOK.Click += new System.EventHandler(this.btnOxygenOK_Click);
            // 
            // TapHeatInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 292);
            this.Controls.Add(this.tabCtrlMain);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TapHeatInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉后炉次数据";
            this.Load += new System.EventHandler(this.TapHeatInfoFrm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabCtrlMain.ResumeLayout(false);
            this.tabBase.ResumeLayout(false);
            this.tabBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlBase.ResumeLayout(false);
            this.tabMat.ResumeLayout(false);
            this.hmiRootPanel2.ResumeLayout(false);
            this.hmiRootPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapAddtionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapAddtionType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapAddtionPropert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapAddtionPropert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnMat)).EndInit();
            this.bnMat.ResumeLayout(false);
            this.bnMat.PerformLayout();
            this.pnlMat.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.tabProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTuneFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTuneFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBlowMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBlowMode)).EndInit();
            this.pnlProcess.ResumeLayout(false);
            this.tabTemp.ResumeLayout(false);
            this.hmiRootPanel6.ResumeLayout(false);
            this.hmiRootPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFTempMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnTemp)).EndInit();
            this.bnTemp.ResumeLayout(false);
            this.bnTemp.PerformLayout();
            this.pnlTemp.ResumeLayout(false);
            this.tabOxygen.ResumeLayout(false);
            this.tabOxygen.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOxygen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnOxygen)).EndInit();
            this.bnOxygen.ResumeLayout(false);
            this.bnOxygen.PerformLayout();
            this.pnlOxygen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private PxDataValid.PxTextBox txtHeatID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabCtrlMain;
        private System.Windows.Forms.TabPage tabBase;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxTextBox tbxSteelGradeIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlBase;
        private System.Windows.Forms.Button btnBaseCancel;
        private System.Windows.Forms.Button btnBaseConfirm;
        private System.Windows.Forms.TabPage tabMat;
        private HMIBase.HMIRootPanel hmiRootPanel2;
        private System.Windows.Forms.FlowLayoutPanel pnlMat;
        private System.Windows.Forms.Button btnMatCancel;
        private System.Windows.Forms.Button btnMatOK;
        private System.Windows.Forms.TabPage tabProcess;
        private PxDataValid.PxTextBox txtTappingOxygen;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker dtTappingEndTime;
        private System.Windows.Forms.DateTimePicker dtTappingStartTime;
        private System.Windows.Forms.Label label27;
        private PxDataValid.PxTextBox txtTappingTime;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.FlowLayoutPanel pnlProcess;
        private System.Windows.Forms.Button btnProcessCancel;
        private System.Windows.Forms.Button btnProcessOK;
        private System.Windows.Forms.TabPage tabTemp;
        private HMIBase.HMIRootPanel hmiRootPanel6;
        private System.Windows.Forms.FlowLayoutPanel pnlTemp;
        private System.Windows.Forms.Button btnTempCancel;
        private System.Windows.Forms.Button btnTempOK;
        private System.Windows.Forms.TabPage tabOxygen;
        private System.Windows.Forms.FlowLayoutPanel pnlOxygen;
        private System.Windows.Forms.Button btnOxygenCancel;
        private System.Windows.Forms.Button btnOxygenOK;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxTextBox pxTextBox4;
        private PxDataValid.PxTextBox pxTextBox3;
        private PxDataValid.PxTextBox pxTextBox2;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Windows.Forms.BindingSource bsBase;
        private AppSvrHMI.L3DataSet dsMat;
        private System.Windows.Forms.BindingSource bsMat;
        private AppSvrHMI.L3DataSet dsProcess;
        private System.Windows.Forms.BindingSource bsProcess;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableHeatID;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGradeIndex;
        private System.Data.DataColumn coldsBaseL3DataTableSteelGrade;
        private System.Data.DataColumn coldsBaseL3DataTableLadleNo;
        private System.Data.DataColumn coldsBaseL3DataTablePreHeatID;
        private System.Data.DataColumn coldsBaseL3DataTableProductionDate;
        private System.Data.DataColumn coldsBaseL3DataTableShift;
        private System.Data.DataColumn coldsBaseL3DataTableTeam;
        private System.Data.DataColumn coldsBaseL3DataTableLocked;
        private AppSvrHMI.L3DataSet dsTemp;
        private System.Windows.Forms.BindingSource bsTemp;
        private AppSvrHMI.L3DataSet dsOxygen;
        private System.Windows.Forms.BindingSource bsOxygen;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsMat;
        private System.Data.DataColumn coldsMatL3DataTableGUID;
        private System.Data.DataColumn coldsMatL3DataTableName;
        private System.Data.DataColumn coldsMatL3DataTableHeatID;
        private System.Data.DataColumn coldsMatL3DataTableElement;
        private System.Data.DataColumn coldsMatL3DataTableWeight;
        private System.Data.DataColumn coldsMatL3DataTableLength;
        private System.Data.DataColumn coldsMatL3DataTableDischarge_Time;
        private System.Data.DataColumn coldsMatL3DataTableType;
        private System.Data.DataTable schemadsProcess;
        private System.Data.DataColumn coldsProcessL3DataTableGUID;
        private System.Data.DataColumn coldsProcessL3DataTableName;
        private System.Data.DataColumn coldsProcessL3DataTableHeatID;
        private System.Data.DataColumn coldsProcessL3DataTableTemp_Before_BlowAr;
        private System.Data.DataColumn coldsProcessL3DataTableO2_Before_BlowAr;
        private System.Data.DataColumn coldsProcessL3DataTableTemp_BlownAr;
        private System.Data.DataColumn coldsProcessL3DataTableO2_BlownAr;
        private System.Data.DataColumn coldsProcessL3DataTableBlow_Mode;
        private System.Data.DataColumn coldsProcessL3DataTableTune_Flag;
        private System.Data.DataColumn coldsProcessL3DataTableBlowAr_Time;
        private System.Data.DataColumn coldsProcessL3DataTableStart_Time;
        private System.Data.DataColumn coldsProcessL3DataTableEnd_Time;
        private System.Data.DataTable schemadsTemp;
        private System.Data.DataColumn coldsTempL3DataTableGUID;
        private System.Data.DataColumn coldsTempL3DataTableName;
        private System.Data.DataColumn coldsTempL3DataTableHeatID;
        private System.Data.DataColumn coldsTempL3DataTableTemperature;
        private System.Data.DataColumn coldsTempL3DataTableMeasureTime;
        private System.Data.DataColumn coldsTempL3DataTableMeasureType;
        private System.Data.DataTable schemadsOxygen;
        private System.Data.DataColumn coldsOxygenL3DataTableGUID;
        private System.Data.DataColumn coldsOxygenL3DataTableName;
        private System.Data.DataColumn coldsOxygenL3DataTableHeatID;
        private System.Data.DataColumn coldsOxygenL3DataTableOxygen_Content;
        private System.Data.DataColumn coldsOxygenL3DataTableMeasureTime;
        private System.Windows.Forms.DataGridView dvMat;
        private System.Windows.Forms.BindingNavigator bnMat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAddMat;
        private System.Windows.Forms.DataGridView dvTemp;
        private System.Windows.Forms.BindingNavigator bnTemp;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnTempAdd;
        private System.Windows.Forms.BindingNavigator bnOxygen;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton toolStripButton19;
        private System.Windows.Forms.ToolStripButton toolStripButton20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton btnAddOxygen;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvOxygen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxComboBox cmbTeam;
        private PxDataValid.PxComboBox cmbShift;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTapAddtionType;
        private System.Data.DataTable schemadsTapAddtionType;
        private System.Data.DataColumn coldsTapAddtionTypeL3DataTableCode;
        private System.Data.DataColumn coldsTapAddtionTypeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTapAddtionPropert;
        private System.Data.DataTable schemadsTapAddtionPropert;
        private System.Data.DataColumn coldsTapAddtionPropertL3DataTableCode;
        private System.Data.DataColumn coldsTapAddtionPropertL3DataTableCode_Des;
        private System.Data.DataColumn coldsTapAddtionPropertL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsBOFTempMode;
        private System.Data.DataTable schemadsBOFTempMode;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsBOFTempModeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsTuneFlag;
        private System.Data.DataTable schemadsTuneFlag;
        private System.Data.DataColumn coldsTuneFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsTuneFlagL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsBlowMode;
        private System.Data.DataTable schemadsBlowMode;
        private System.Data.DataColumn coldsBlowModeL3DataTableCode_Des;
        private System.Data.DataColumn coldsBlowModeL3DataTableCode_Val_Long;
        private PxDataValid.PxComboBox pxComboBox2;
        private PxDataValid.PxComboBox pxComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn elementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn dischargeTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn measureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn measureTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oxygenContentDataGridViewTextBoxColumn;
        private DataGridValid.CalendarColumn measureTimeDataGridViewTextBoxColumn1;
    }
}