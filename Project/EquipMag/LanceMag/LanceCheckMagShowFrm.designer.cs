namespace EquipMag.LanceMag
{
    partial class LanceCheckMagShowFrm
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
            this.coldsMainL3DataTableLANCE_HEAD_TYPE = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOZZLE_FACTURY = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOZZLE_ANGLE = new System.Data.DataColumn();
            this.coldsMainL3DataTableOFF_DATE = new System.Data.DataColumn();
            this.coldsMainL3DataTableNASAL_EROSION = new System.Data.DataColumn();
            this.coldsMainL3DataTableEXIT_SHAPE = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE = new System.Data.DataColumn();
            this.coldsMainL3DataTableLANCE_BODY_SHAP = new System.Data.DataColumn();
            this.coldsMainL3DataTableIN_MID_OUT_REPLACE = new System.Data.DataColumn();
            this.coldsMainL3DataTableWELD_CHECK = new System.Data.DataColumn();
            this.coldsMainL3DataTableN2_AND_BAFFLE_CHECK = new System.Data.DataColumn();
            this.coldsMainL3DataTableRING_CHECK = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEST_WATER_PRESSURE = new System.Data.DataColumn();
            this.coldsMainL3DataTableKEEP_PRESSURE_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEST_WATER_RESULT = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEST_WATER_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsMainL3DataTableRISE_LANCE_DATE = new System.Data.DataColumn();
            this.coldsMainL3DataTableON_LANCE_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableOFF_LANCE_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableFLANGE_CHECK = new System.Data.DataColumn();
            this.AcoldsMainL3DataTableMakeID = new System.Data.DataColumn();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTestWaterResult = new PxDataValid.PxTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel10 = new System.Windows.Forms.Panel();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.dtRiseLanceDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBofID = new PxDataValid.PxComboBox();
            this.dsBOFID = new AppSvrHMI.L3DataSet();
            this.schemadsBOFID = new System.Data.DataTable();
            this.coldsBOFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtOffLanceOperator = new PxDataValid.PxTextBox();
            this.txtOnLanceOperator = new PxDataValid.PxTextBox();
            this.txtTestWaterOperation = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTestWaterPressure = new PxDataValid.PxTextBox();
            this.txtKeepPressureTime = new PxDataValid.PxTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dtOffDate = new System.Windows.Forms.DateTimePicker();
            this.dtNozzleAssemblyDate = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtInputDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNozzleFactury = new PxDataValid.PxComboBox();
            this.dsNozzleFac = new AppSvrHMI.L3DataSet();
            this.schemadsNozzleFac = new System.Data.DataTable();
            this.coldsNozzleFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.cmbLanceID = new PxDataValid.PxComboBox();
            this.dsLanceID = new AppSvrHMI.L3DataSet();
            this.schemadsLanceID = new System.Data.DataTable();
            this.coldsLanceIDL3DataTableLanceID = new System.Data.DataColumn();
            this.txtNozzleAngle = new PxDataValid.PxTextBox();
            this.txtLanceType = new PxDataValid.PxTextBox();
            this.txtNozzleThroatDia = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dsMakeID = new AppSvrHMI.L3DataSet();
            this.schemadsMakeID = new System.Data.DataTable();
            this.coldsMakeIDL3DataTableLanceID = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableNozzle_Factury = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableLance_Head_Type = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableLance_Age = new System.Data.DataColumn();
            this.coldsMakeIDL3DataTableMakeID = new System.Data.DataColumn();
            this.coldsMainL3DataTableMakeID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNozzleFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNozzleFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMakeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMakeID)).BeginInit();
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
            this.dsMain.SubscribeTarget = null;
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
            this.coldsMainL3DataTableLANCE_HEAD_TYPE,
            this.coldsMainL3DataTableNOZZLE_FACTURY,
            this.coldsMainL3DataTableNOZZLE_THROAT_DIA,
            this.coldsMainL3DataTableNOZZLE_ANGLE,
            this.coldsMainL3DataTableOFF_DATE,
            this.coldsMainL3DataTableNASAL_EROSION,
            this.coldsMainL3DataTableEXIT_SHAPE,
            this.coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE,
            this.coldsMainL3DataTableLANCE_BODY_SHAP,
            this.coldsMainL3DataTableIN_MID_OUT_REPLACE,
            this.coldsMainL3DataTableWELD_CHECK,
            this.coldsMainL3DataTableN2_AND_BAFFLE_CHECK,
            this.coldsMainL3DataTableRING_CHECK,
            this.coldsMainL3DataTableTEST_WATER_PRESSURE,
            this.coldsMainL3DataTableKEEP_PRESSURE_TIME,
            this.coldsMainL3DataTableTEST_WATER_RESULT,
            this.coldsMainL3DataTableTEST_WATER_OPERATOR,
            this.coldsMainL3DataTableBOFID,
            this.coldsMainL3DataTableRISE_LANCE_DATE,
            this.coldsMainL3DataTableON_LANCE_OPERATOR,
            this.coldsMainL3DataTableOFF_LANCE_OPERATOR,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableOPERATOR,
            this.coldsMainL3DataTableNOTE,
            this.coldsMainL3DataTableFLANGE_CHECK,
            this.AcoldsMainL3DataTableMakeID});
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
            // coldsMainL3DataTableOFF_DATE
            // 
            this.coldsMainL3DataTableOFF_DATE.Caption = "OFF_DATE";
            this.coldsMainL3DataTableOFF_DATE.ColumnName = "OFF_DATE";
            this.coldsMainL3DataTableOFF_DATE.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableOFF_DATE.Namespace = "";
            // 
            // coldsMainL3DataTableNASAL_EROSION
            // 
            this.coldsMainL3DataTableNASAL_EROSION.Caption = "NASAL_EROSION";
            this.coldsMainL3DataTableNASAL_EROSION.ColumnName = "NASAL_EROSION";
            this.coldsMainL3DataTableNASAL_EROSION.DataType = typeof(int);
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
            // coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE
            // 
            this.coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE.Caption = "NOZZLE_ASSEMBLY_DATE";
            this.coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE.ColumnName = "NOZZLE_ASSEMBLY_DATE";
            this.coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE.Namespace = "";
            // 
            // coldsMainL3DataTableLANCE_BODY_SHAP
            // 
            this.coldsMainL3DataTableLANCE_BODY_SHAP.Caption = "LANCE_BODY_SHAP";
            this.coldsMainL3DataTableLANCE_BODY_SHAP.ColumnName = "LANCE_BODY_SHAP";
            this.coldsMainL3DataTableLANCE_BODY_SHAP.DataType = typeof(int);
            this.coldsMainL3DataTableLANCE_BODY_SHAP.DefaultValue = 0;
            this.coldsMainL3DataTableLANCE_BODY_SHAP.Namespace = "";
            // 
            // coldsMainL3DataTableIN_MID_OUT_REPLACE
            // 
            this.coldsMainL3DataTableIN_MID_OUT_REPLACE.Caption = "IN_MID_OUT_REPLACE";
            this.coldsMainL3DataTableIN_MID_OUT_REPLACE.ColumnName = "IN_MID_OUT_REPLACE";
            this.coldsMainL3DataTableIN_MID_OUT_REPLACE.DataType = typeof(int);
            this.coldsMainL3DataTableIN_MID_OUT_REPLACE.DefaultValue = 0;
            this.coldsMainL3DataTableIN_MID_OUT_REPLACE.Namespace = "";
            // 
            // coldsMainL3DataTableWELD_CHECK
            // 
            this.coldsMainL3DataTableWELD_CHECK.Caption = "WELD_CHECK";
            this.coldsMainL3DataTableWELD_CHECK.ColumnName = "WELD_CHECK";
            this.coldsMainL3DataTableWELD_CHECK.DataType = typeof(int);
            this.coldsMainL3DataTableWELD_CHECK.DefaultValue = 0;
            this.coldsMainL3DataTableWELD_CHECK.Namespace = "";
            // 
            // coldsMainL3DataTableN2_AND_BAFFLE_CHECK
            // 
            this.coldsMainL3DataTableN2_AND_BAFFLE_CHECK.Caption = "N2_AND_BAFFLE_CHECK";
            this.coldsMainL3DataTableN2_AND_BAFFLE_CHECK.ColumnName = "N2_AND_BAFFLE_CHECK";
            this.coldsMainL3DataTableN2_AND_BAFFLE_CHECK.DataType = typeof(int);
            this.coldsMainL3DataTableN2_AND_BAFFLE_CHECK.DefaultValue = 0;
            this.coldsMainL3DataTableN2_AND_BAFFLE_CHECK.Namespace = "";
            // 
            // coldsMainL3DataTableRING_CHECK
            // 
            this.coldsMainL3DataTableRING_CHECK.Caption = "RING_CHECK";
            this.coldsMainL3DataTableRING_CHECK.ColumnName = "RING_CHECK";
            this.coldsMainL3DataTableRING_CHECK.DataType = typeof(int);
            this.coldsMainL3DataTableRING_CHECK.DefaultValue = 0;
            this.coldsMainL3DataTableRING_CHECK.Namespace = "";
            // 
            // coldsMainL3DataTableTEST_WATER_PRESSURE
            // 
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.Caption = "TEST_WATER_PRESSURE";
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.ColumnName = "TEST_WATER_PRESSURE";
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.DataType = typeof(double);
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.DefaultValue = 0;
            this.coldsMainL3DataTableTEST_WATER_PRESSURE.Namespace = "";
            // 
            // coldsMainL3DataTableKEEP_PRESSURE_TIME
            // 
            this.coldsMainL3DataTableKEEP_PRESSURE_TIME.Caption = "KEEP_PRESSURE_TIME";
            this.coldsMainL3DataTableKEEP_PRESSURE_TIME.ColumnName = "KEEP_PRESSURE_TIME";
            this.coldsMainL3DataTableKEEP_PRESSURE_TIME.DataType = typeof(double);
            this.coldsMainL3DataTableKEEP_PRESSURE_TIME.DefaultValue = 0;
            this.coldsMainL3DataTableKEEP_PRESSURE_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableTEST_WATER_RESULT
            // 
            this.coldsMainL3DataTableTEST_WATER_RESULT.Caption = "TEST_WATER_RESULT";
            this.coldsMainL3DataTableTEST_WATER_RESULT.ColumnName = "TEST_WATER_RESULT";
            this.coldsMainL3DataTableTEST_WATER_RESULT.DataType = typeof(int);
            this.coldsMainL3DataTableTEST_WATER_RESULT.DefaultValue = 0;
            this.coldsMainL3DataTableTEST_WATER_RESULT.Namespace = "";
            // 
            // coldsMainL3DataTableTEST_WATER_OPERATOR
            // 
            this.coldsMainL3DataTableTEST_WATER_OPERATOR.Caption = "TEST_WATER_OPERATOR";
            this.coldsMainL3DataTableTEST_WATER_OPERATOR.ColumnName = "TEST_WATER_OPERATOR";
            this.coldsMainL3DataTableTEST_WATER_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableTEST_WATER_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableBOFID
            // 
            this.coldsMainL3DataTableBOFID.Caption = "BOFID";
            this.coldsMainL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsMainL3DataTableBOFID.DefaultValue = "";
            this.coldsMainL3DataTableBOFID.Namespace = "";
            // 
            // coldsMainL3DataTableRISE_LANCE_DATE
            // 
            this.coldsMainL3DataTableRISE_LANCE_DATE.Caption = "RISE_LANCE_DATE";
            this.coldsMainL3DataTableRISE_LANCE_DATE.ColumnName = "RISE_LANCE_DATE";
            this.coldsMainL3DataTableRISE_LANCE_DATE.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableRISE_LANCE_DATE.Namespace = "";
            // 
            // coldsMainL3DataTableON_LANCE_OPERATOR
            // 
            this.coldsMainL3DataTableON_LANCE_OPERATOR.Caption = "ON_LANCE_OPERATOR";
            this.coldsMainL3DataTableON_LANCE_OPERATOR.ColumnName = "ON_LANCE_OPERATOR";
            this.coldsMainL3DataTableON_LANCE_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableON_LANCE_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableOFF_LANCE_OPERATOR
            // 
            this.coldsMainL3DataTableOFF_LANCE_OPERATOR.Caption = "OFF_LANCE_OPERATOR";
            this.coldsMainL3DataTableOFF_LANCE_OPERATOR.ColumnName = "OFF_LANCE_OPERATOR";
            this.coldsMainL3DataTableOFF_LANCE_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableOFF_LANCE_OPERATOR.Namespace = "";
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
            // coldsMainL3DataTableFLANGE_CHECK
            // 
            this.coldsMainL3DataTableFLANGE_CHECK.Caption = "FLANGE_CHECK";
            this.coldsMainL3DataTableFLANGE_CHECK.ColumnName = "FLANGE_CHECK";
            this.coldsMainL3DataTableFLANGE_CHECK.DataType = typeof(int);
            this.coldsMainL3DataTableFLANGE_CHECK.DefaultValue = 0;
            this.coldsMainL3DataTableFLANGE_CHECK.Namespace = "";
            // 
            // AcoldsMainL3DataTableMakeID
            // 
            this.AcoldsMainL3DataTableMakeID.Caption = "MakeID";
            this.AcoldsMainL3DataTableMakeID.ColumnName = "MakeID";
            this.AcoldsMainL3DataTableMakeID.Namespace = "";
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(526, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(445, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Controls.Add(this.txtTestWaterResult);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 403);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(604, 58);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // txtTestWaterResult
            // 
            this.txtTestWaterResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TEST_WATER_RESULT", true));
            this.txtTestWaterResult.EnableNull = true;
            this.txtTestWaterResult.ErropPr = null;
            this.txtTestWaterResult.Length = 0;
            this.txtTestWaterResult.Location = new System.Drawing.Point(334, 3);
            this.txtTestWaterResult.Max = 0;
            this.txtTestWaterResult.MaxStrLength = 0;
            this.txtTestWaterResult.Min = 0;
            this.txtTestWaterResult.MinStrLength = 0;
            this.txtTestWaterResult.Name = "txtTestWaterResult";
            this.txtTestWaterResult.Precision = 0;
            this.txtTestWaterResult.Size = new System.Drawing.Size(105, 21);
            this.txtTestWaterResult.TabIndex = 18;
            this.txtTestWaterResult.ToolTipValid = null;
            this.txtTestWaterResult.ValidEable = true;
            this.txtTestWaterResult.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtTestWaterResult.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 403);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel11);
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.panel10);
            this.tabPage1.Controls.Add(this.panel9);
            this.tabPage1.Controls.Add(this.panel8);
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.dtRiseLanceDate);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbBofID);
            this.tabPage1.Controls.Add(this.txtOffLanceOperator);
            this.tabPage1.Controls.Add(this.txtOnLanceOperator);
            this.tabPage1.Controls.Add(this.txtTestWaterOperation);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtTestWaterPressure);
            this.tabPage1.Controls.Add(this.txtKeepPressureTime);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.dtOffDate);
            this.tabPage1.Controls.Add(this.dtNozzleAssemblyDate);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.dtInputDate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbNozzleFactury);
            this.tabPage1.Controls.Add(this.cmbLanceID);
            this.tabPage1.Controls.Add(this.txtNozzleAngle);
            this.tabPage1.Controls.Add(this.txtLanceType);
            this.tabPage1.Controls.Add(this.txtNozzleThroatDia);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "氧枪检查实绩信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.radioButton17);
            this.panel11.Controls.Add(this.radioButton18);
            this.panel11.Location = new System.Drawing.Point(416, 133);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(141, 21);
            this.panel11.TabIndex = 140;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Checked = true;
            this.radioButton17.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton17.Location = new System.Drawing.Point(80, 0);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(59, 19);
            this.radioButton17.TabIndex = 1;
            this.radioButton17.TabStop = true;
            this.radioButton17.Text = "不合格";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "TEST_WATER_RESULT", true));
            this.radioButton18.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton18.Location = new System.Drawing.Point(0, 0);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(47, 19);
            this.radioButton18.TabIndex = 0;
            this.radioButton18.Text = "合格";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOTE", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(124, 330);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(433, 40);
            this.rtxtNote.TabIndex = 139;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.radioButton15);
            this.panel10.Controls.Add(this.radioButton16);
            this.panel10.Location = new System.Drawing.Point(416, 110);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(141, 21);
            this.panel10.TabIndex = 138;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Checked = true;
            this.radioButton15.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton15.Location = new System.Drawing.Point(92, 0);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(47, 19);
            this.radioButton15.TabIndex = 1;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "否　";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "IN_MID_OUT_REPLACE", true));
            this.radioButton16.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton16.Location = new System.Drawing.Point(0, 0);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(47, 19);
            this.radioButton16.TabIndex = 0;
            this.radioButton16.Text = "是　";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.radioButton13);
            this.panel9.Controls.Add(this.radioButton14);
            this.panel9.Location = new System.Drawing.Point(416, 85);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(141, 21);
            this.panel9.TabIndex = 138;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Checked = true;
            this.radioButton13.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton13.Location = new System.Drawing.Point(92, 0);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(47, 19);
            this.radioButton13.TabIndex = 1;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "否　";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "LANCE_BODY_SHAP", true));
            this.radioButton14.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton14.Location = new System.Drawing.Point(0, 0);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(47, 19);
            this.radioButton14.TabIndex = 0;
            this.radioButton14.Text = "是　";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.radioButton11);
            this.panel8.Controls.Add(this.radioButton12);
            this.panel8.Location = new System.Drawing.Point(416, 34);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(141, 21);
            this.panel8.TabIndex = 138;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Checked = true;
            this.radioButton11.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton11.Location = new System.Drawing.Point(92, 0);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(47, 19);
            this.radioButton11.TabIndex = 1;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "否　";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "EXIT_SHAPE", true));
            this.radioButton12.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton12.Location = new System.Drawing.Point(0, 0);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(47, 19);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.Text = "是　";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.radioButton9);
            this.panel7.Controls.Add(this.radioButton10);
            this.panel7.Location = new System.Drawing.Point(416, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(141, 21);
            this.panel7.TabIndex = 138;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Checked = true;
            this.radioButton9.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton9.Location = new System.Drawing.Point(92, 0);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(47, 19);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "否　";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "NASAL_EROSION", true));
            this.radioButton10.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton10.Location = new System.Drawing.Point(0, 0);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(47, 19);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.Text = "是　";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.radioButton7);
            this.panel6.Controls.Add(this.radioButton8);
            this.panel6.Location = new System.Drawing.Point(124, 229);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(141, 21);
            this.panel6.TabIndex = 138;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Checked = true;
            this.radioButton7.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton7.Location = new System.Drawing.Point(68, 0);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(71, 19);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "不正常　";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "FLANGE_CHECK", true));
            this.radioButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton8.Location = new System.Drawing.Point(0, 0);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(47, 19);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.Text = "正常";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.radioButton5);
            this.panel5.Controls.Add(this.radioButton6);
            this.panel5.Location = new System.Drawing.Point(124, 203);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 21);
            this.panel5.TabIndex = 138;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton5.Location = new System.Drawing.Point(68, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(71, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "不正常　";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "RING_CHECK", true));
            this.radioButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton6.Location = new System.Drawing.Point(0, 0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(47, 19);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Text = "正常";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioButton3);
            this.panel4.Controls.Add(this.radioButton4);
            this.panel4.Location = new System.Drawing.Point(124, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(141, 21);
            this.panel4.TabIndex = 138;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton3.Location = new System.Drawing.Point(68, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 19);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "不正常　";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "N2_AND_BAFFLE_CHECK", true));
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton4.Location = new System.Drawing.Point(0, 0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 19);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "正常";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(124, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 21);
            this.panel3.TabIndex = 138;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton2.Location = new System.Drawing.Point(68, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "不正常　";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsMain, "WELD_CHECK", true));
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "正常";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(83, 333);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 137;
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
            this.cmbShiftID.Location = new System.Drawing.Point(416, 304);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 133;
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
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
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
            this.cmbTeamID.Location = new System.Drawing.Point(416, 279);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 132;
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
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(375, 307);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 135;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(375, 282);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 134;
            this.label45.Text = "班别:";
            // 
            // dtRiseLanceDate
            // 
            this.dtRiseLanceDate.CustomFormat = "yyyy-MM-dd";
            this.dtRiseLanceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "RISE_LANCE_DATE", true));
            this.dtRiseLanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRiseLanceDate.Location = new System.Drawing.Point(416, 203);
            this.dtRiseLanceDate.Name = "dtRiseLanceDate";
            this.dtRiseLanceDate.Size = new System.Drawing.Size(141, 21);
            this.dtRiseLanceDate.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(351, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 131;
            this.label5.Text = "上枪日期:";
            // 
            // cmbBofID
            // 
            this.cmbBofID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBofID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBofID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "BOFID", true));
            this.cmbBofID.DataSource = this.dsBOFID;
            this.cmbBofID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBofID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBofID.EnableNull = false;
            this.cmbBofID.ErropPr = this.errorProvider1;
            this.cmbBofID.FormattingEnabled = true;
            this.cmbBofID.Location = new System.Drawing.Point(416, 180);
            this.cmbBofID.Name = "cmbBofID";
            this.cmbBofID.Size = new System.Drawing.Size(141, 20);
            this.cmbBofID.TabIndex = 20;
            this.cmbBofID.ToolTipValid = this.toolTip1;
            this.cmbBofID.ValidEable = true;
            this.cmbBofID.ValueMember = "L3DataTable.Code";
            // 
            // dsBOFID
            // 
            this.dsBOFID.AutoLoad = true;
            this.dsBOFID.AutoSubscribe = false;
            this.dsBOFID.DataSetName = "L3DataSet";
            this.dsBOFID.DeleteMethod = null;
            this.dsBOFID.InsertMethod = null;
            this.dsBOFID.L3DataAdapter = this.Adapter;
            this.dsBOFID.LoadEvent = "Click";
            this.dsBOFID.LoadTrigger = null;
            this.dsBOFID.RefreshValve = 1000;
            this.dsBOFID.SourceCommand = null;
            this.dsBOFID.SourceCondition = "CODE_GROUP = \'BOF\'";
            this.dsBOFID.SourceMethod = "";
            this.dsBOFID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOFID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBOFID.SubscribeTarget = null;
            this.dsBOFID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOFID});
            this.dsBOFID.UpdateEvent = "Click";
            this.dsBOFID.UpdateMethod = null;
            this.dsBOFID.UpdateTrigger = null;
            // 
            // schemadsBOFID
            // 
            this.schemadsBOFID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFIDL3DataTableCode,
            this.coldsBOFIDL3DataTableCode_Des});
            this.schemadsBOFID.TableName = "L3DataTable";
            // 
            // coldsBOFIDL3DataTableCode
            // 
            this.coldsBOFIDL3DataTableCode.Caption = "Code";
            this.coldsBOFIDL3DataTableCode.ColumnName = "Code";
            this.coldsBOFIDL3DataTableCode.Namespace = "";
            // 
            // coldsBOFIDL3DataTableCode_Des
            // 
            this.coldsBOFIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFIDL3DataTableCode_Des.Namespace = "";
            // 
            // txtOffLanceOperator
            // 
            this.txtOffLanceOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "OFF_LANCE_OPERATOR", true));
            this.txtOffLanceOperator.EnableNull = true;
            this.txtOffLanceOperator.ErropPr = null;
            this.txtOffLanceOperator.Length = 0;
            this.txtOffLanceOperator.Location = new System.Drawing.Point(416, 253);
            this.txtOffLanceOperator.Max = 0;
            this.txtOffLanceOperator.MaxStrLength = 0;
            this.txtOffLanceOperator.Min = 0;
            this.txtOffLanceOperator.MinStrLength = 0;
            this.txtOffLanceOperator.Name = "txtOffLanceOperator";
            this.txtOffLanceOperator.Precision = 0;
            this.txtOffLanceOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOffLanceOperator.TabIndex = 23;
            this.txtOffLanceOperator.ToolTipValid = null;
            this.txtOffLanceOperator.ValidEable = true;
            this.txtOffLanceOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtOnLanceOperator
            // 
            this.txtOnLanceOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "ON_LANCE_OPERATOR", true));
            this.txtOnLanceOperator.EnableNull = true;
            this.txtOnLanceOperator.ErropPr = null;
            this.txtOnLanceOperator.Length = 0;
            this.txtOnLanceOperator.Location = new System.Drawing.Point(416, 229);
            this.txtOnLanceOperator.Max = 0;
            this.txtOnLanceOperator.MaxStrLength = 0;
            this.txtOnLanceOperator.Min = 0;
            this.txtOnLanceOperator.MinStrLength = 0;
            this.txtOnLanceOperator.Name = "txtOnLanceOperator";
            this.txtOnLanceOperator.Precision = 0;
            this.txtOnLanceOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOnLanceOperator.TabIndex = 22;
            this.txtOnLanceOperator.ToolTipValid = null;
            this.txtOnLanceOperator.ValidEable = true;
            this.txtOnLanceOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTestWaterOperation
            // 
            this.txtTestWaterOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TEST_WATER_OPERATOR", true));
            this.txtTestWaterOperation.EnableNull = true;
            this.txtTestWaterOperation.ErropPr = null;
            this.txtTestWaterOperation.Length = 0;
            this.txtTestWaterOperation.Location = new System.Drawing.Point(416, 156);
            this.txtTestWaterOperation.Max = 0;
            this.txtTestWaterOperation.MaxStrLength = 0;
            this.txtTestWaterOperation.Min = 0;
            this.txtTestWaterOperation.MinStrLength = 0;
            this.txtTestWaterOperation.Name = "txtTestWaterOperation";
            this.txtTestWaterOperation.Precision = 0;
            this.txtTestWaterOperation.Size = new System.Drawing.Size(141, 21);
            this.txtTestWaterOperation.TabIndex = 19;
            this.txtTestWaterOperation.ToolTipValid = null;
            this.txtTestWaterOperation.ValidEable = true;
            this.txtTestWaterOperation.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(327, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 122;
            this.label8.Text = "下枪作业人员:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(327, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 121;
            this.label7.Text = "上枪作业人员:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(339, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 123;
            this.label2.Text = "试水作业人:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(327, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 125;
            this.label4.Text = "试水作业结果:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(327, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 124;
            this.label9.Text = "使用转炉炉号:";
            // 
            // txtTestWaterPressure
            // 
            this.txtTestWaterPressure.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TEST_WATER_PRESSURE", true));
            this.txtTestWaterPressure.EnableNull = false;
            this.txtTestWaterPressure.ErropPr = this.errorProvider1;
            this.txtTestWaterPressure.Length = 0;
            this.txtTestWaterPressure.Location = new System.Drawing.Point(124, 254);
            this.txtTestWaterPressure.Max = 9999;
            this.txtTestWaterPressure.MaxStrLength = 0;
            this.txtTestWaterPressure.Min = 0;
            this.txtTestWaterPressure.MinStrLength = 0;
            this.txtTestWaterPressure.Name = "txtTestWaterPressure";
            this.txtTestWaterPressure.Precision = 0;
            this.txtTestWaterPressure.Size = new System.Drawing.Size(141, 21);
            this.txtTestWaterPressure.TabIndex = 10;
            this.txtTestWaterPressure.ToolTipValid = this.toolTip1;
            this.txtTestWaterPressure.ValidEable = true;
            this.txtTestWaterPressure.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtKeepPressureTime
            // 
            this.txtKeepPressureTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "KEEP_PRESSURE_TIME", true));
            this.txtKeepPressureTime.EnableNull = false;
            this.txtKeepPressureTime.ErropPr = this.errorProvider1;
            this.txtKeepPressureTime.Length = 0;
            this.txtKeepPressureTime.Location = new System.Drawing.Point(124, 278);
            this.txtKeepPressureTime.Max = 9999;
            this.txtKeepPressureTime.MaxStrLength = 0;
            this.txtKeepPressureTime.Min = 0;
            this.txtKeepPressureTime.MinStrLength = 0;
            this.txtKeepPressureTime.Name = "txtKeepPressureTime";
            this.txtKeepPressureTime.Precision = 0;
            this.txtKeepPressureTime.Size = new System.Drawing.Size(141, 21);
            this.txtKeepPressureTime.TabIndex = 11;
            this.txtKeepPressureTime.ToolTipValid = this.toolTip1;
            this.txtKeepPressureTime.ValidEable = true;
            this.txtKeepPressureTime.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(29, 258);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(89, 12);
            this.label33.TabIndex = 111;
            this.label33.Text = "试水压力[MPa]:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(59, 282);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 110;
            this.label34.Text = "保压时间:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(35, 232);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(83, 12);
            this.label32.TabIndex = 109;
            this.label32.Text = "氧枪法兰检查:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(59, 209);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 12);
            this.label31.TabIndex = 114;
            this.label31.Text = "吊挂检查:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(11, 185);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 12);
            this.label30.TabIndex = 113;
            this.label30.Text = "氮封孔及挡块检查:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(59, 162);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 112;
            this.label29.Text = "焊缝检查:";
            // 
            // dtOffDate
            // 
            this.dtOffDate.CustomFormat = "yyyy-MM-dd";
            this.dtOffDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "OFF_DATE", true));
            this.dtOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOffDate.Location = new System.Drawing.Point(124, 303);
            this.dtOffDate.Name = "dtOffDate";
            this.dtOffDate.Size = new System.Drawing.Size(141, 21);
            this.dtOffDate.TabIndex = 12;
            // 
            // dtNozzleAssemblyDate
            // 
            this.dtNozzleAssemblyDate.CustomFormat = "yyyy-MM-dd";
            this.dtNozzleAssemblyDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "NOZZLE_ASSEMBLY_DATE", true));
            this.dtNozzleAssemblyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNozzleAssemblyDate.Location = new System.Drawing.Point(416, 60);
            this.dtNozzleAssemblyDate.Name = "dtNozzleAssemblyDate";
            this.dtNozzleAssemblyDate.Size = new System.Drawing.Size(141, 21);
            this.dtNozzleAssemblyDate.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(59, 307);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 105;
            this.label23.Text = "下线日期:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(327, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 12);
            this.label26.TabIndex = 106;
            this.label26.Text = "喷头装配日期:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(279, 113);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(131, 12);
            this.label28.TabIndex = 98;
            this.label28.Text = "内、中、外管是否更换:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(327, 90);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 97;
            this.label27.Text = "枪身是否变形:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(327, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 12);
            this.label25.TabIndex = 100;
            this.label25.Text = "出口是否变形:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(327, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 99;
            this.label24.Text = "鼻区是否侵蚀:";
            // 
            // dtInputDate
            // 
            this.dtInputDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "INPUT_TIME", true));
            this.dtInputDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputDate.Location = new System.Drawing.Point(124, 10);
            this.dtInputDate.Name = "dtInputDate";
            this.dtInputDate.Size = new System.Drawing.Size(141, 21);
            this.dtInputDate.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(59, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 95;
            this.label3.Text = "录入时间:";
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
            this.cmbNozzleFactury.Location = new System.Drawing.Point(124, 85);
            this.cmbNozzleFactury.Name = "cmbNozzleFactury";
            this.cmbNozzleFactury.Size = new System.Drawing.Size(141, 20);
            this.cmbNozzleFactury.TabIndex = 3;
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
            this.cmbLanceID.Location = new System.Drawing.Point(124, 35);
            this.cmbLanceID.Name = "cmbLanceID";
            this.cmbLanceID.Size = new System.Drawing.Size(141, 20);
            this.cmbLanceID.TabIndex = 1;
            this.cmbLanceID.ToolTipValid = this.toolTip1;
            this.cmbLanceID.ValidEable = true;
            this.cmbLanceID.ValueMember = "L3DataTable.LanceID";
            this.cmbLanceID.SelectedValueChanged += new System.EventHandler(this.cmbLanceID_SelectedValueChanged);
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
            // schemadsLanceID
            // 
            this.schemadsLanceID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceIDL3DataTableLanceID});
            this.schemadsLanceID.TableName = "L3DataTable";
            // 
            // coldsLanceIDL3DataTableLanceID
            // 
            this.coldsLanceIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.Namespace = "";
            // 
            // txtNozzleAngle
            // 
            this.txtNozzleAngle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOZZLE_ANGLE", true));
            this.txtNozzleAngle.EnableNull = false;
            this.txtNozzleAngle.ErropPr = this.errorProvider1;
            this.txtNozzleAngle.Length = 0;
            this.txtNozzleAngle.Location = new System.Drawing.Point(124, 133);
            this.txtNozzleAngle.Max = 9999;
            this.txtNozzleAngle.MaxStrLength = 0;
            this.txtNozzleAngle.Min = 0;
            this.txtNozzleAngle.MinStrLength = 0;
            this.txtNozzleAngle.Name = "txtNozzleAngle";
            this.txtNozzleAngle.Precision = 0;
            this.txtNozzleAngle.Size = new System.Drawing.Size(141, 21);
            this.txtNozzleAngle.TabIndex = 5;
            this.txtNozzleAngle.ToolTipValid = this.toolTip1;
            this.txtNozzleAngle.ValidEable = true;
            this.txtNozzleAngle.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtLanceType
            // 
            this.txtLanceType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "LANCE_HEAD_TYPE", true));
            this.txtLanceType.EnableNull = true;
            this.txtLanceType.ErropPr = null;
            this.txtLanceType.Length = 0;
            this.txtLanceType.Location = new System.Drawing.Point(124, 59);
            this.txtLanceType.Max = 0;
            this.txtLanceType.MaxStrLength = 0;
            this.txtLanceType.Min = 0;
            this.txtLanceType.MinStrLength = 0;
            this.txtLanceType.Name = "txtLanceType";
            this.txtLanceType.Precision = 0;
            this.txtLanceType.ReadOnly = true;
            this.txtLanceType.Size = new System.Drawing.Size(141, 21);
            this.txtLanceType.TabIndex = 4;
            this.txtLanceType.ToolTipValid = null;
            this.txtLanceType.ValidEable = true;
            this.txtLanceType.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtNozzleThroatDia
            // 
            this.txtNozzleThroatDia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOZZLE_THROAT_DIA", true));
            this.txtNozzleThroatDia.EnableNull = false;
            this.txtNozzleThroatDia.ErropPr = this.errorProvider1;
            this.txtNozzleThroatDia.Length = 0;
            this.txtNozzleThroatDia.Location = new System.Drawing.Point(124, 110);
            this.txtNozzleThroatDia.Max = 9999;
            this.txtNozzleThroatDia.MaxStrLength = 9999;
            this.txtNozzleThroatDia.Min = 0;
            this.txtNozzleThroatDia.MinStrLength = 0;
            this.txtNozzleThroatDia.Name = "txtNozzleThroatDia";
            this.txtNozzleThroatDia.Precision = 0;
            this.txtNozzleThroatDia.Size = new System.Drawing.Size(141, 21);
            this.txtNozzleThroatDia.TabIndex = 4;
            this.txtNozzleThroatDia.ToolTipValid = this.toolTip1;
            this.txtNozzleThroatDia.ValidEable = true;
            this.txtNozzleThroatDia.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(59, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 85;
            this.label19.Text = "枪头型号:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(35, 137);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 12);
            this.label22.TabIndex = 86;
            this.label22.Text = "喷头夹角[°]:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(11, 114);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 12);
            this.label21.TabIndex = 87;
            this.label21.Text = "喷头喉口直径[mm]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(59, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 89;
            this.label1.Text = "喷头厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(59, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 88;
            this.label6.Text = "氧枪编号:";
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
            this.dsMakeID.SourceCondition = null;
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
            // schemadsMakeID
            // 
            this.schemadsMakeID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMakeIDL3DataTableLanceID,
            this.coldsMakeIDL3DataTableBOFID,
            this.coldsMakeIDL3DataTableNozzle_Factury,
            this.coldsMakeIDL3DataTableLance_Head_Type,
            this.coldsMakeIDL3DataTableLance_Age,
            this.coldsMakeIDL3DataTableMakeID});
            this.schemadsMakeID.TableName = "L3DataTable";
            // 
            // coldsMakeIDL3DataTableLanceID
            // 
            this.coldsMakeIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsMakeIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsMakeIDL3DataTableLanceID.Namespace = "";
            // 
            // coldsMakeIDL3DataTableBOFID
            // 
            this.coldsMakeIDL3DataTableBOFID.Caption = "BOFID";
            this.coldsMakeIDL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsMakeIDL3DataTableBOFID.Namespace = "";
            // 
            // coldsMakeIDL3DataTableNozzle_Factury
            // 
            this.coldsMakeIDL3DataTableNozzle_Factury.Caption = "Nozzle_Factury";
            this.coldsMakeIDL3DataTableNozzle_Factury.ColumnName = "Nozzle_Factury";
            this.coldsMakeIDL3DataTableNozzle_Factury.Namespace = "";
            // 
            // coldsMakeIDL3DataTableLance_Head_Type
            // 
            this.coldsMakeIDL3DataTableLance_Head_Type.Caption = "Lance_Head_Type";
            this.coldsMakeIDL3DataTableLance_Head_Type.ColumnName = "Lance_Head_Type";
            this.coldsMakeIDL3DataTableLance_Head_Type.Namespace = "";
            // 
            // coldsMakeIDL3DataTableLance_Age
            // 
            this.coldsMakeIDL3DataTableLance_Age.Caption = "Lance_Age";
            this.coldsMakeIDL3DataTableLance_Age.ColumnName = "Lance_Age";
            this.coldsMakeIDL3DataTableLance_Age.DataType = typeof(int);
            this.coldsMakeIDL3DataTableLance_Age.Namespace = "";
            // 
            // coldsMakeIDL3DataTableMakeID
            // 
            this.coldsMakeIDL3DataTableMakeID.Caption = "MakeID";
            this.coldsMakeIDL3DataTableMakeID.ColumnName = "MakeID";
            this.coldsMakeIDL3DataTableMakeID.Namespace = "";
            // 
            // coldsMainL3DataTableMakeID
            // 
            this.coldsMainL3DataTableMakeID.Caption = "MakeID";
            this.coldsMainL3DataTableMakeID.ColumnName = "MakeID";
            this.coldsMainL3DataTableMakeID.Namespace = "";
            // 
            // LanceCheckMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LanceCheckMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "氧枪检查实绩信息维护";
            this.Load += new System.EventHandler(this.LanceCheckMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNozzleFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNozzleFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMakeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMakeID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3DataSet dsMain;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtRiseLanceDate;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxComboBox cmbBofID;
        private PxDataValid.PxTextBox txtOffLanceOperator;
        private PxDataValid.PxTextBox txtOnLanceOperator;
        private PxDataValid.PxTextBox txtTestWaterOperation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private PxDataValid.PxTextBox txtTestWaterPressure;
        private PxDataValid.PxTextBox txtKeepPressureTime;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dtOffDate;
        private System.Windows.Forms.DateTimePicker dtNozzleAssemblyDate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtInputDate;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxComboBox cmbNozzleFactury;
        private PxDataValid.PxComboBox cmbLanceID;
        private PxDataValid.PxTextBox txtNozzleAngle;
        private PxDataValid.PxTextBox txtNozzleThroatDia;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private AppSvrHMI.L3DataSet dsLanceID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsLanceID;
        private System.Data.DataColumn coldsLanceIDL3DataTableLanceID;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableLANCEID;
        private System.Data.DataColumn coldsMainL3DataTableLANCE_HEAD_TYPE;
        private System.Data.DataColumn coldsMainL3DataTableNOZZLE_FACTURY;
        private System.Data.DataColumn coldsMainL3DataTableNOZZLE_THROAT_DIA;
        private System.Data.DataColumn coldsMainL3DataTableNOZZLE_ANGLE;
        private System.Data.DataColumn coldsMainL3DataTableOFF_DATE;
        private System.Data.DataColumn coldsMainL3DataTableNASAL_EROSION;
        private System.Data.DataColumn coldsMainL3DataTableEXIT_SHAPE;
        private System.Data.DataColumn coldsMainL3DataTableNOZZLE_ASSEMBLY_DATE;
        private System.Data.DataColumn coldsMainL3DataTableLANCE_BODY_SHAP;
        private System.Data.DataColumn coldsMainL3DataTableIN_MID_OUT_REPLACE;
        private System.Data.DataColumn coldsMainL3DataTableWELD_CHECK;
        private System.Data.DataColumn coldsMainL3DataTableN2_AND_BAFFLE_CHECK;
        private System.Data.DataColumn coldsMainL3DataTableRING_CHECK;
        private System.Data.DataColumn coldsMainL3DataTableTEST_WATER_PRESSURE;
        private System.Data.DataColumn coldsMainL3DataTableKEEP_PRESSURE_TIME;
        private System.Data.DataColumn coldsMainL3DataTableTEST_WATER_RESULT;
        private System.Data.DataColumn coldsMainL3DataTableTEST_WATER_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableBOFID;
        private System.Data.DataColumn coldsMainL3DataTableRISE_LANCE_DATE;
        private System.Data.DataColumn coldsMainL3DataTableON_LANCE_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableOFF_LANCE_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableOPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton6;
        private AppSvrHMI.L3DataSet dsBOFID;
        private System.Data.DataTable schemadsBOFID;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode_Des;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private AppSvrHMI.L3DataSet dsNozzleFac;
        private System.Data.DataTable schemadsNozzleFac;
        private System.Data.DataColumn coldsNozzleFacL3DataTableMatFactory;
        private PxDataValid.PxTextBox txtLanceType;
        private AppSvrHMI.L3DataSet dsMakeID;
        private System.Data.DataTable schemadsMakeID;
        private System.Data.DataColumn coldsMakeIDL3DataTableLanceID;
        private System.Data.DataColumn coldsMakeIDL3DataTableBOFID;
        private System.Data.DataColumn coldsMakeIDL3DataTableNozzle_Factury;
        private System.Data.DataColumn coldsMakeIDL3DataTableLance_Head_Type;
        private System.Data.DataColumn coldsMakeIDL3DataTableLance_Age;
        private System.Data.DataColumn coldsMakeIDL3DataTableMakeID;
        private System.Data.DataColumn coldsMainL3DataTableFLANGE_CHECK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private PxDataValid.PxTextBox txtTestWaterResult;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Data.DataColumn coldsMainL3DataTableMakeID;
        private System.Data.DataColumn AcoldsMainL3DataTableMakeID;
    }
}