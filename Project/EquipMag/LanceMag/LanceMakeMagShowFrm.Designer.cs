namespace EquipMag.LanceMag
{
    partial class LanceMakeMagShowFrm
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
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableLANCEID = new System.Data.DataColumn();
            this.coldsMainL3DataTableCHECK_DATE = new System.Data.DataColumn();
            this.coldsMainL3DataTableLANCE_HEAD_TYPE = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOZZLE_FACTURY = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOZZLE_ANGLE = new System.Data.DataColumn();
            this.coldsMainL3DataTableWELD_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableSUPPRESS_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEST_WATER_PRESSURE = new System.Data.DataColumn();
            this.coldsMainL3DataTableASSEMBLY_STARTE_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableASSEMBLY_END_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableNASAL_EROSION = new System.Data.DataColumn();
            this.coldsMainL3DataTableEXIT_SHAPE = new System.Data.DataColumn();
            this.coldsMainL3DataTableSUNDRY = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableMakeID = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtTestWaterPressure = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtMakeID = new PxDataValid.PxTextBox();
            this.txtLanceHeadType = new PxDataValid.PxTextBox();
            this.txtSuppressOperator = new PxDataValid.PxTextBox();
            this.txtNozzleAngle = new PxDataValid.PxTextBox();
            this.txtNozzleThroatDia = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWeldOperator = new PxDataValid.PxTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.coldsMakeIDL3DataTableLanceID = new System.Data.DataColumn();
            this.schemadsMakeID = new System.Data.DataTable();
            this.coldsMakeIDL3DataTableMakeID = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableMake_Start_Time = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableMake_End_Time = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableLance_Head_Type = new System.Data.DataColumn();
            this.dsMakeID = new AppSvrHMI.L3DataSet();
            this.coldsLanceIDL3DataTableLanceID = new System.Data.DataColumn();
            this.schemadsLanceID = new System.Data.DataTable();
            this.dsLanceID = new AppSvrHMI.L3DataSet();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbNozzleFactury = new PxDataValid.PxComboBox();
            this.dsNozzleFac = new AppSvrHMI.L3DataSet();
            this.schemadsNozzleFac = new System.Data.DataTable();
            this.coldsNozzleFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.cmbLanceID = new PxDataValid.PxComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtCheckDate = new System.Windows.Forms.DateTimePicker();
            this.dtAssemblyEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtAssemblyStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtInputDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMakeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMakeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNozzleFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNozzleFac)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableNAME,
            this.coldsMainL3DataTableINPUT_TIME,
            this.coldsMainL3DataTableLANCEID,
            this.coldsMainL3DataTableCHECK_DATE,
            this.coldsMainL3DataTableLANCE_HEAD_TYPE,
            this.coldsMainL3DataTableNOZZLE_FACTURY,
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA,
            this.coldsMainL3DataTableNOZZLE_ANGLE,
            this.coldsMainL3DataTableWELD_OPERATOR,
            this.coldsMainL3DataTableSUPPRESS_OPERATOR,
            this.coldsMainL3DataTableTEST_WATER_PRESSURE,
            this.coldsMainL3DataTableASSEMBLY_STARTE_TIME,
            this.coldsMainL3DataTableASSEMBLY_END_TIME,
            this.coldsMainL3DataTableNASAL_EROSION,
            this.coldsMainL3DataTableEXIT_SHAPE,
            this.coldsMainL3DataTableSUNDRY,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableOPERATOR,
            this.coldsMainL3DataTableNOTE,
            this.coldsMainL3DataTableMakeID});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.DefaultValue = "";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableNAME
            // 
            this.coldsMainL3DataTableNAME.Caption = "NAME";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.DefaultValue = "";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableINPUT_TIME
            // 
            this.coldsMainL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableLANCEID
            // 
            this.coldsMainL3DataTableLANCEID.Caption = "LANCEID";
            this.coldsMainL3DataTableLANCEID.ColumnName = "LANCEID";
            this.coldsMainL3DataTableLANCEID.DefaultValue = "";
            this.coldsMainL3DataTableLANCEID.Namespace = "";
            // 
            // coldsMainL3DataTableCHECK_DATE
            // 
            this.coldsMainL3DataTableCHECK_DATE.Caption = "CHECK_DATE";
            this.coldsMainL3DataTableCHECK_DATE.ColumnName = "CHECK_DATE";
            this.coldsMainL3DataTableCHECK_DATE.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableCHECK_DATE.Namespace = "";
            // 
            // coldsMainL3DataTableLANCE_HEAD_TYPE
            // 
            this.coldsMainL3DataTableLANCE_HEAD_TYPE.Caption = "LANCE_HEAD_TYPE";
            this.coldsMainL3DataTableLANCE_HEAD_TYPE.ColumnName = "LANCE_HEAD_TYPE";
            this.coldsMainL3DataTableLANCE_HEAD_TYPE.DefaultValue = "";
            this.coldsMainL3DataTableLANCE_HEAD_TYPE.Namespace = "";
            // 
            // coldsMainL3DataTableNOZZLE_FACTURY
            // 
            this.coldsMainL3DataTableNOZZLE_FACTURY.Caption = "NOZZLE_FACTURY";
            this.coldsMainL3DataTableNOZZLE_FACTURY.ColumnName = "NOZZLE_FACTURY";
            this.coldsMainL3DataTableNOZZLE_FACTURY.DefaultValue = "";
            this.coldsMainL3DataTableNOZZLE_FACTURY.Namespace = "";
            // 
            // coldsMainL3DataTableNOZZLE_THROAT_DIA
            // 
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA.Caption = "NOZZLE_THROAT_DIA";
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA.ColumnName = "NOZZLE_THROAT_DIA";
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA.DataType = typeof(double);
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA.DefaultValue = 0;
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA.Namespace = "";
            // 
            // coldsMainL3DataTableNOZZLE_ANGLE
            // 
            this.coldsMainL3DataTableNOZZLE_ANGLE.Caption = "NOZZLE_ANGLE";
            this.coldsMainL3DataTableNOZZLE_ANGLE.ColumnName = "NOZZLE_ANGLE";
            this.coldsMainL3DataTableNOZZLE_ANGLE.DataType = typeof(double);
            this.coldsMainL3DataTableNOZZLE_ANGLE.DefaultValue = 0;
            this.coldsMainL3DataTableNOZZLE_ANGLE.Namespace = "";
            // 
            // coldsMainL3DataTableWELD_OPERATOR
            // 
            this.coldsMainL3DataTableWELD_OPERATOR.Caption = "WELD_OPERATOR";
            this.coldsMainL3DataTableWELD_OPERATOR.ColumnName = "WELD_OPERATOR";
            this.coldsMainL3DataTableWELD_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableWELD_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableSUPPRESS_OPERATOR
            // 
            this.coldsMainL3DataTableSUPPRESS_OPERATOR.Caption = "SUPPRESS_OPERATOR";
            this.coldsMainL3DataTableSUPPRESS_OPERATOR.ColumnName = "SUPPRESS_OPERATOR";
            this.coldsMainL3DataTableSUPPRESS_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableSUPPRESS_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableTEST_WATER_PRESSURE
            // 
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.Caption = "TEST_WATER_PRESSURE";
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.ColumnName = "TEST_WATER_PRESSURE";
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.DataType = typeof(double);
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.DefaultValue = 0;
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.Namespace = "";
            // 
            // coldsMainL3DataTableASSEMBLY_STARTE_TIME
            // 
            this.coldsMainL3DataTableASSEMBLY_STARTE_TIME.Caption = "ASSEMBLY_STARTE_TIME";
            this.coldsMainL3DataTableASSEMBLY_STARTE_TIME.ColumnName = "ASSEMBLY_STARTE_TIME";
            this.coldsMainL3DataTableASSEMBLY_STARTE_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableASSEMBLY_STARTE_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableASSEMBLY_END_TIME
            // 
            this.coldsMainL3DataTableASSEMBLY_END_TIME.Caption = "ASSEMBLY_END_TIME";
            this.coldsMainL3DataTableASSEMBLY_END_TIME.ColumnName = "ASSEMBLY_END_TIME";
            this.coldsMainL3DataTableASSEMBLY_END_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableASSEMBLY_END_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableNASAL_EROSION
            // 
            this.coldsMainL3DataTableNASAL_EROSION.Caption = "NASAL_EROSION";
            this.coldsMainL3DataTableNASAL_EROSION.ColumnName = "NASAL_EROSION";
            this.coldsMainL3DataTableNASAL_EROSION.DataType = typeof(double);
            this.coldsMainL3DataTableNASAL_EROSION.DefaultValue = 0;
            this.coldsMainL3DataTableNASAL_EROSION.Namespace = "";
            // 
            // coldsMainL3DataTableEXIT_SHAPE
            // 
            this.coldsMainL3DataTableEXIT_SHAPE.Caption = "EXIT_SHAPE";
            this.coldsMainL3DataTableEXIT_SHAPE.ColumnName = "EXIT_SHAPE";
            this.coldsMainL3DataTableEXIT_SHAPE.DataType = typeof(int);
            this.coldsMainL3DataTableEXIT_SHAPE.DefaultValue = 0;
            this.coldsMainL3DataTableEXIT_SHAPE.Namespace = "";
            // 
            // coldsMainL3DataTableSUNDRY
            // 
            this.coldsMainL3DataTableSUNDRY.Caption = "SUNDRY";
            this.coldsMainL3DataTableSUNDRY.ColumnName = "SUNDRY";
            this.coldsMainL3DataTableSUNDRY.DataType = typeof(int);
            this.coldsMainL3DataTableSUNDRY.DefaultValue = 0;
            this.coldsMainL3DataTableSUNDRY.Namespace = "";
            // 
            // coldsMainL3DataTableTEAMID
            // 
            this.coldsMainL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsMainL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsMainL3DataTableTEAMID.DefaultValue = "";
            this.coldsMainL3DataTableTEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableSHIFTID
            // 
            this.coldsMainL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.DefaultValue = "";
            this.coldsMainL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableOPERATOR
            // 
            this.coldsMainL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsMainL3DataTableOPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "NOTE";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.DefaultValue = "";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // coldsMainL3DataTableMakeID
            // 
            this.coldsMainL3DataTableMakeID.Caption = "MakeID";
            this.coldsMainL3DataTableMakeID.ColumnName = "MakeID";
            this.coldsMainL3DataTableMakeID.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TEAMID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(378, 132);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 140;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
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
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
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
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(338, 160);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 143;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(338, 136);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 142;
            this.label45.Text = "班别:";
            // 
            // txtTestWaterPressure
            // 
            this.txtTestWaterPressure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TEST_WATER_PRESSURE", true));
            this.txtTestWaterPressure.EnableNull = false;
            this.txtTestWaterPressure.ErropPr = this.errorProvider1;
            this.txtTestWaterPressure.Length = 0;
            this.txtTestWaterPressure.Location = new System.Drawing.Point(379, 60);
            this.txtTestWaterPressure.Max = 9999;
            this.txtTestWaterPressure.MaxStrLength = 0;
            this.txtTestWaterPressure.Min = 0;
            this.txtTestWaterPressure.MinStrLength = 0;
            this.txtTestWaterPressure.Name = "txtTestWaterPressure";
            this.txtTestWaterPressure.Precision = 2;
            this.txtTestWaterPressure.Size = new System.Drawing.Size(141, 21);
            this.txtTestWaterPressure.TabIndex = 12;
            this.txtTestWaterPressure.ToolTipValid = this.toolTip1;
            this.txtTestWaterPressure.ValidEable = true;
            this.txtTestWaterPressure.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMakeID
            // 
            this.txtMakeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "MakeID", true));
            this.txtMakeID.EnableNull = true;
            this.txtMakeID.ErropPr = null;
            this.txtMakeID.Length = 0;
            this.txtMakeID.Location = new System.Drawing.Point(251, 3);
            this.txtMakeID.Max = 0;
            this.txtMakeID.MaxStrLength = 0;
            this.txtMakeID.Min = 0;
            this.txtMakeID.MinStrLength = 0;
            this.txtMakeID.Name = "txtMakeID";
            this.txtMakeID.Precision = 0;
            this.txtMakeID.ReadOnly = true;
            this.txtMakeID.Size = new System.Drawing.Size(141, 21);
            this.txtMakeID.TabIndex = 11;
            this.txtMakeID.ToolTipValid = null;
            this.txtMakeID.ValidEable = true;
            this.txtMakeID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtMakeID.Visible = false;
            // 
            // txtLanceHeadType
            // 
            this.txtLanceHeadType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "LANCE_HEAD_TYPE", true));
            this.txtLanceHeadType.EnableNull = true;
            this.txtLanceHeadType.ErropPr = null;
            this.txtLanceHeadType.Length = 0;
            this.txtLanceHeadType.Location = new System.Drawing.Point(107, 60);
            this.txtLanceHeadType.Max = 0;
            this.txtLanceHeadType.MaxStrLength = 0;
            this.txtLanceHeadType.Min = 0;
            this.txtLanceHeadType.MinStrLength = 0;
            this.txtLanceHeadType.Name = "txtLanceHeadType";
            this.txtLanceHeadType.Precision = 0;
            this.txtLanceHeadType.ReadOnly = true;
            this.txtLanceHeadType.Size = new System.Drawing.Size(141, 21);
            this.txtLanceHeadType.TabIndex = 11;
            this.txtLanceHeadType.ToolTipValid = null;
            this.txtLanceHeadType.ValidEable = true;
            this.txtLanceHeadType.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSuppressOperator
            // 
            this.txtSuppressOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "SUPPRESS_OPERATOR", true));
            this.txtSuppressOperator.EnableNull = true;
            this.txtSuppressOperator.ErropPr = null;
            this.txtSuppressOperator.Length = 0;
            this.txtSuppressOperator.Location = new System.Drawing.Point(379, 108);
            this.txtSuppressOperator.Max = 0;
            this.txtSuppressOperator.MaxStrLength = 0;
            this.txtSuppressOperator.Min = 0;
            this.txtSuppressOperator.MinStrLength = 0;
            this.txtSuppressOperator.Name = "txtSuppressOperator";
            this.txtSuppressOperator.Precision = 0;
            this.txtSuppressOperator.Size = new System.Drawing.Size(141, 21);
            this.txtSuppressOperator.TabIndex = 11;
            this.txtSuppressOperator.ToolTipValid = null;
            this.txtSuppressOperator.ValidEable = true;
            this.txtSuppressOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtNozzleAngle
            // 
            this.txtNozzleAngle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOZZLE_ANGLE", true));
            this.txtNozzleAngle.EnableNull = false;
            this.txtNozzleAngle.ErropPr = this.errorProvider1;
            this.txtNozzleAngle.Length = 0;
            this.txtNozzleAngle.Location = new System.Drawing.Point(379, 36);
            this.txtNozzleAngle.Max = 9999;
            this.txtNozzleAngle.MaxStrLength = 0;
            this.txtNozzleAngle.Min = 0;
            this.txtNozzleAngle.MinStrLength = 0;
            this.txtNozzleAngle.Name = "txtNozzleAngle";
            this.txtNozzleAngle.Precision = 2;
            this.txtNozzleAngle.Size = new System.Drawing.Size(141, 21);
            this.txtNozzleAngle.TabIndex = 9;
            this.txtNozzleAngle.ToolTipValid = this.toolTip1;
            this.txtNozzleAngle.ValidEable = true;
            this.txtNozzleAngle.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtNozzleThroatDia
            // 
            this.txtNozzleThroatDia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOZZLE_THROAT_DIA", true));
            this.txtNozzleThroatDia.EnableNull = false;
            this.txtNozzleThroatDia.ErropPr = this.errorProvider1;
            this.txtNozzleThroatDia.Length = 0;
            this.txtNozzleThroatDia.Location = new System.Drawing.Point(379, 12);
            this.txtNozzleThroatDia.Max = 9999;
            this.txtNozzleThroatDia.MaxStrLength = 0;
            this.txtNozzleThroatDia.Min = 0;
            this.txtNozzleThroatDia.MinStrLength = 0;
            this.txtNozzleThroatDia.Name = "txtNozzleThroatDia";
            this.txtNozzleThroatDia.Precision = 2;
            this.txtNozzleThroatDia.Size = new System.Drawing.Size(141, 21);
            this.txtNozzleThroatDia.TabIndex = 8;
            this.txtNozzleThroatDia.ToolTipValid = this.toolTip1;
            this.txtNozzleThroatDia.ValidEable = true;
            this.txtNozzleThroatDia.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(303, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "装配焊接人:";
            // 
            // txtWeldOperator
            // 
            this.txtWeldOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "WELD_OPERATOR", true));
            this.txtWeldOperator.EnableNull = true;
            this.txtWeldOperator.ErropPr = null;
            this.txtWeldOperator.Length = 0;
            this.txtWeldOperator.Location = new System.Drawing.Point(379, 84);
            this.txtWeldOperator.Max = 0;
            this.txtWeldOperator.MaxStrLength = 0;
            this.txtWeldOperator.Min = 0;
            this.txtWeldOperator.MinStrLength = 0;
            this.txtWeldOperator.Name = "txtWeldOperator";
            this.txtWeldOperator.Precision = 0;
            this.txtWeldOperator.Size = new System.Drawing.Size(141, 21);
            this.txtWeldOperator.TabIndex = 10;
            this.txtWeldOperator.ToolTipValid = null;
            this.txtWeldOperator.ValidEable = true;
            this.txtWeldOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(285, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 12);
            this.label25.TabIndex = 64;
            this.label25.Text = "试水压力[MPa]:";
            // 
            // coldsMakeIDL3DataTableLanceID
            // 
            this.coldsMakeIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsMakeIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsMakeIDL3DataTableLanceID.Namespace = "";
            // 
            // schemadsMakeID
            // 
            this.schemadsMakeID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMakeIDL3DataTableLanceID,
            this.coldsMakeIDL3DataTableMakeID,
            this.coldsMakeIDL3DataTableMake_Start_Time,
            this.coldsMakeIDL3DataTableMake_End_Time,
            this.coldsMakeIDL3DataTableLance_Head_Type});
            this.schemadsMakeID.TableName = "L3DataTable";
            // 
            // coldsMakeIDL3DataTableMakeID
            // 
            this.coldsMakeIDL3DataTableMakeID.Caption = "MakeID";
            this.coldsMakeIDL3DataTableMakeID.ColumnName = "MakeID";
            this.coldsMakeIDL3DataTableMakeID.Namespace = "";
            // 
            // coldsMakeIDL3DataTableMake_Start_Time
            // 
            this.coldsMakeIDL3DataTableMake_Start_Time.Caption = "Make_Start_Time";
            this.coldsMakeIDL3DataTableMake_Start_Time.ColumnName = "Make_Start_Time";
            this.coldsMakeIDL3DataTableMake_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMakeIDL3DataTableMake_Start_Time.Namespace = "";
            // 
            // coldsMakeIDL3DataTableMake_End_Time
            // 
            this.coldsMakeIDL3DataTableMake_End_Time.Caption = "Make_End_Time";
            this.coldsMakeIDL3DataTableMake_End_Time.ColumnName = "Make_End_Time";
            this.coldsMakeIDL3DataTableMake_End_Time.DataType = typeof(System.DateTime);
            this.coldsMakeIDL3DataTableMake_End_Time.Namespace = "";
            // 
            // coldsMakeIDL3DataTableLance_Head_Type
            // 
            this.coldsMakeIDL3DataTableLance_Head_Type.Caption = "Lance_Head_Type";
            this.coldsMakeIDL3DataTableLance_Head_Type.ColumnName = "Lance_Head_Type";
            this.coldsMakeIDL3DataTableLance_Head_Type.Namespace = "";
            // 
            // dsMakeID
            // 
            this.dsMakeID.AutoLoad = true;
            this.dsMakeID.AutoSubscribe = false;
            this.dsMakeID.DataSetName = "L3DataSet";
            this.dsMakeID.DeleteMethod = null;
            this.dsMakeID.InsertMethod = null;
            this.dsMakeID.L3DataAdapter = null;
            this.dsMakeID.LoadEvent = "Click";
            this.dsMakeID.LoadTrigger = null;
            this.dsMakeID.RefreshValve = 1000;
            this.dsMakeID.SourceCommand = null;
            this.dsMakeID.SourceCondition = "";
            this.dsMakeID.SourceMethod = "";
            this.dsMakeID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMakeID.SourceURI = "XGMESLogic\\LanceMag\\CLance_Base";
            this.dsMakeID.SubscribeTarget = null;
            this.dsMakeID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMakeID});
            this.dsMakeID.UpdateEvent = "Click";
            this.dsMakeID.UpdateMethod = null;
            this.dsMakeID.UpdateTrigger = null;
            // 
            // coldsLanceIDL3DataTableLanceID
            // 
            this.coldsLanceIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.Namespace = "";
            // 
            // schemadsLanceID
            // 
            this.schemadsLanceID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceIDL3DataTableLanceID});
            this.schemadsLanceID.TableName = "L3DataTable";
            // 
            // dsLanceID
            // 
            this.dsLanceID.AutoLoad = true;
            this.dsLanceID.AutoSubscribe = false;
            this.dsLanceID.DataSetName = "L3DataSet";
            this.dsLanceID.DeleteMethod = null;
            this.dsLanceID.InsertMethod = null;
            this.dsLanceID.L3DataAdapter = this.Adapter;
            this.dsLanceID.LoadEvent = "Click";
            this.dsLanceID.LoadTrigger = null;
            this.dsLanceID.RefreshValve = 1000;
            this.dsLanceID.SourceCommand = null;
            this.dsLanceID.SourceCondition = null;
            this.dsLanceID.SourceMethod = "";
            this.dsLanceID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLanceID.SourceURI = "XGMESLogic\\LanceMag\\CLance_Base";
            this.dsLanceID.SubscribeTarget = null;
            this.dsLanceID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLanceID});
            this.dsLanceID.UpdateEvent = "Click";
            this.dsLanceID.UpdateMethod = null;
            this.dsLanceID.UpdateTrigger = null;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(303, 112);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 53;
            this.label19.Text = "装配打压人:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(293, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 56;
            this.label21.Text = "喷头夹角[°]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(269, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 12);
            this.label22.TabIndex = 55;
            this.label22.Text = "喷头喉口直径[mm]:";
            // 
            // cmbNozzleFactury
            // 
            this.cmbNozzleFactury.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNozzleFactury.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNozzleFactury.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOZZLE_FACTURY", true));
            this.cmbNozzleFactury.DataSource = this.dsNozzleFac;
            this.cmbNozzleFactury.DisplayMember = "L3DataTable.MatFactory";
            this.cmbNozzleFactury.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNozzleFactury.EnableNull = true;
            this.cmbNozzleFactury.ErropPr = null;
            this.cmbNozzleFactury.FormattingEnabled = true;
            this.cmbNozzleFactury.Location = new System.Drawing.Point(107, 156);
            this.cmbNozzleFactury.Name = "cmbNozzleFactury";
            this.cmbNozzleFactury.Size = new System.Drawing.Size(141, 20);
            this.cmbNozzleFactury.TabIndex = 7;
            this.cmbNozzleFactury.ToolTipValid = null;
            this.cmbNozzleFactury.ValidEable = true;
            this.cmbNozzleFactury.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsNozzleFac
            // 
            this.dsNozzleFac.AutoLoad = true;
            this.dsNozzleFac.AutoSubscribe = false;
            this.dsNozzleFac.DataSetName = "L3DataSet";
            this.dsNozzleFac.DeleteMethod = null;
            this.dsNozzleFac.InsertMethod = null;
            this.dsNozzleFac.L3DataAdapter = this.Adapter;
            this.dsNozzleFac.LoadEvent = "Click";
            this.dsNozzleFac.LoadTrigger = null;
            this.dsNozzleFac.RefreshValve = 1000;
            this.dsNozzleFac.SourceCommand = null;
            this.dsNozzleFac.SourceCondition = "MATGROUP_CODE = \'LanceFac\' and MATNAME = \'喷头\'";
            this.dsNozzleFac.SourceMethod = "";
            this.dsNozzleFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNozzleFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsNozzleFac.SubscribeTarget = null;
            this.dsNozzleFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsNozzleFac});
            this.dsNozzleFac.UpdateEvent = "Click";
            this.dsNozzleFac.UpdateMethod = null;
            this.dsNozzleFac.UpdateTrigger = null;
            // 
            // schemadsNozzleFac
            // 
            this.schemadsNozzleFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNozzleFacL3DataTableMatFactory});
            this.schemadsNozzleFac.TableName = "L3DataTable";
            // 
            // coldsNozzleFacL3DataTableMatFactory
            // 
            this.coldsNozzleFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsNozzleFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsNozzleFacL3DataTableMatFactory.Namespace = "";
            // 
            // cmbLanceID
            // 
            this.cmbLanceID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLanceID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLanceID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "LANCEID", true));
            this.cmbLanceID.DataSource = this.dsLanceID;
            this.cmbLanceID.DisplayMember = "L3DataTable.LanceID";
            this.cmbLanceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanceID.EnableNull = false;
            this.cmbLanceID.ErropPr = this.errorProvider1;
            this.cmbLanceID.FormattingEnabled = true;
            this.cmbLanceID.Location = new System.Drawing.Point(107, 36);
            this.cmbLanceID.Name = "cmbLanceID";
            this.cmbLanceID.Size = new System.Drawing.Size(141, 20);
            this.cmbLanceID.TabIndex = 4;
            this.cmbLanceID.ToolTipValid = this.toolTip1;
            this.cmbLanceID.ValidEable = true;
            this.cmbLanceID.ValueMember = "L3DataTable.LanceID";
            this.cmbLanceID.SelectedIndexChanged += new System.EventHandler(this.cmbLanceID_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(45, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 45;
            this.label7.Text = "枪头型号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(45, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "喷头厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(45, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 46;
            this.label6.Text = "氧枪编号:";
            // 
            // dtCheckDate
            // 
            this.dtCheckDate.CustomFormat = "yyyy-MM-dd";
            this.dtCheckDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "CHECK_DATE", true));
            this.dtCheckDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckDate.Location = new System.Drawing.Point(107, 84);
            this.dtCheckDate.Name = "dtCheckDate";
            this.dtCheckDate.Size = new System.Drawing.Size(141, 21);
            this.dtCheckDate.TabIndex = 1;
            // 
            // dtAssemblyEndTime
            // 
            this.dtAssemblyEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtAssemblyEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "ASSEMBLY_END_TIME", true));
            this.dtAssemblyEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAssemblyEndTime.Location = new System.Drawing.Point(107, 132);
            this.dtAssemblyEndTime.Name = "dtAssemblyEndTime";
            this.dtAssemblyEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtAssemblyEndTime.TabIndex = 3;
            // 
            // dtAssemblyStartTime
            // 
            this.dtAssemblyStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtAssemblyStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "ASSEMBLY_STARTE_TIME", true));
            this.dtAssemblyStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAssemblyStartTime.Location = new System.Drawing.Point(107, 108);
            this.dtAssemblyStartTime.Name = "dtAssemblyStartTime";
            this.dtAssemblyStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtAssemblyStartTime.TabIndex = 2;
            // 
            // dtInputDate
            // 
            this.dtInputDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "INPUT_TIME", true));
            this.dtInputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputDate.Location = new System.Drawing.Point(107, 12);
            this.dtInputDate.Name = "dtInputDate";
            this.dtInputDate.Size = new System.Drawing.Size(141, 21);
            this.dtInputDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 38;
            this.label2.Text = "检查日期:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "制作结束时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "制作开始时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(45, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "录入时间:";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(398, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 256);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.txtTestWaterPressure);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.txtWeldOperator);
            this.tabPage1.Controls.Add(this.txtLanceHeadType);
            this.tabPage1.Controls.Add(this.txtSuppressOperator);
            this.tabPage1.Controls.Add(this.txtNozzleAngle);
            this.tabPage1.Controls.Add(this.txtNozzleThroatDia);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.cmbNozzleFactury);
            this.tabPage1.Controls.Add(this.cmbLanceID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtCheckDate);
            this.tabPage1.Controls.Add(this.dtAssemblyEndTime);
            this.tabPage1.Controls.Add(this.dtAssemblyStartTime);
            this.tabPage1.Controls.Add(this.dtInputDate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "制作实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOTE", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(106, 180);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(414, 43);
            this.rtxtNote.TabIndex = 146;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(66, 183);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 145;
            this.label46.Text = "备注:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "SHIFTID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(378, 156);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 141;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
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
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Controls.Add(this.txtMakeID);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 256);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 50);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(479, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 36;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 48;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 47;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 46;
            this.label10.Text = "XXXXXXX:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 51;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 50;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 49;
            this.label16.Text = "计划号:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 45;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 41;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "合同号:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "钢种:";
            // 
            // LanceMakeMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 306);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LanceMakeMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "氧枪制作";
            this.Load += new System.EventHandler(this.LanceMakeMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMakeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMakeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNozzleFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNozzleFac)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableLANCEID;
        private System.Data.DataColumn coldsMainL3DataTableCHECK_DATE;
        private System.Data.DataColumn coldsMainL3DataTableLANCE_HEAD_TYPE;
        private System.Data.DataColumn coldsMainL3DataTableNOZZLE_FACTURY;
        private System.Data.DataColumn coldsMainL3DataTableNOZZLE_THROAT_DIA;
        private System.Data.DataColumn coldsMainL3DataTableNOZZLE_ANGLE;
        private System.Data.DataColumn coldsMainL3DataTableWELD_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableSUPPRESS_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableTEST_WATER_PRESSURE;
        private System.Data.DataColumn coldsMainL3DataTableASSEMBLY_STARTE_TIME;
        private System.Data.DataColumn coldsMainL3DataTableASSEMBLY_END_TIME;
        private System.Data.DataColumn coldsMainL3DataTableNASAL_EROSION;
        private System.Data.DataColumn coldsMainL3DataTableEXIT_SHAPE;
        private System.Data.DataColumn coldsMainL3DataTableSUNDRY;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableOPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private System.Data.DataColumn coldsMainL3DataTableMakeID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbTeamID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private PxDataValid.PxTextBox txtTestWaterPressure;
        private PxDataValid.PxTextBox txtMakeID;
        private PxDataValid.PxTextBox txtLanceHeadType;
        private PxDataValid.PxTextBox txtSuppressOperator;
        private PxDataValid.PxTextBox txtNozzleAngle;
        private PxDataValid.PxTextBox txtNozzleThroatDia;
        private System.Windows.Forms.Label label8;
        private PxDataValid.PxTextBox txtWeldOperator;
        private System.Windows.Forms.Label label25;
        private System.Data.DataColumn coldsMakeIDL3DataTableLanceID;
        private System.Data.DataTable schemadsMakeID;
        private System.Data.DataColumn coldsMakeIDL3DataTableMakeID;
        private System.Data.DataColumn coldsMakeIDL3DataTableMake_Start_Time;
        private System.Data.DataColumn coldsMakeIDL3DataTableMake_End_Time;
        private System.Data.DataColumn coldsMakeIDL3DataTableLance_Head_Type;
        private AppSvrHMI.L3DataSet dsMakeID;
        private System.Data.DataColumn coldsLanceIDL3DataTableLanceID;
        private System.Data.DataTable schemadsLanceID;
        private AppSvrHMI.L3DataSet dsLanceID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private PxDataValid.PxComboBox cmbNozzleFactury;
        private PxDataValid.PxComboBox cmbLanceID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtCheckDate;
        private System.Windows.Forms.DateTimePicker dtAssemblyEndTime;
        private System.Windows.Forms.DateTimePicker dtAssemblyStartTime;
        private System.Windows.Forms.DateTimePicker dtInputDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private AppSvrHMI.L3DataSet dsNozzleFac;
        private System.Data.DataTable schemadsNozzleFac;
        private System.Data.DataColumn coldsNozzleFacL3DataTableMatFactory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}