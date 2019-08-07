namespace EquipMag.VacTubeMag
{
    partial class VacTubeRepairShowFrm
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
            this.coldsMainL3DataTableVACTUBE_NAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableVACTUBE_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableREFRA_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableRH_AGE = new System.Data.DataColumn();
            this.coldsMainL3DataTableINWALL_BRI_THICK = new System.Data.DataColumn();
            this.coldsMainL3DataTableINBOT_BRI_THICK = new System.Data.DataColumn();
            this.coldsMainL3DataTableMG_CR_FIR_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableBEAR_FIR_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableSI_CA_BOA_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsMainL3DataTableMg_Cr_Bri_Ele_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableCast_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBuild_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableCir_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableUp_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableDown_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableRepair_Position = new System.Data.DataColumn();
            this.coldsMainL3DataTableRepair_Case = new System.Data.DataColumn();
            this.coldsMainL3DataTableRepair_Per = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
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
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.cmbVacTubeName = new PxDataValid.PxComboBox();
            this.dsName = new AppSvrHMI.L3DataSet();
            this.schemadsName = new System.Data.DataTable();
            this.coldsNameL3DataTableCode = new System.Data.DataColumn();
            this.coldsNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbVacTubeID = new PxDataValid.PxComboBox();
            this.cmbRefraFac = new PxDataValid.PxComboBox();
            this.dsFac = new AppSvrHMI.L3DataSet();
            this.schemadsFac = new System.Data.DataTable();
            this.coldsFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.dsNo = new AppSvrHMI.L3DataSet();
            this.schemadsNo = new System.Data.DataTable();
            this.coldsNoL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.coldsNoL3DataTableVacTube_Name = new System.Data.DataColumn();
            this.bsTop = new System.Windows.Forms.BindingSource(this.components);
            this.bsLow = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLow)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
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
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Repair";
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
            this.coldsMainL3DataTableVACTUBE_NAME,
            this.coldsMainL3DataTableVACTUBE_ID,
            this.coldsMainL3DataTableREFRA_FAC,
            this.coldsMainL3DataTableRH_AGE,
            this.coldsMainL3DataTableINWALL_BRI_THICK,
            this.coldsMainL3DataTableINBOT_BRI_THICK,
            this.coldsMainL3DataTableMG_CR_FIR_WASTE,
            this.coldsMainL3DataTableBEAR_FIR_WASTE,
            this.coldsMainL3DataTableSI_CA_BOA_WASTE,
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE,
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE,
            this.coldsMainL3DataTableTEAMID,
            this.coldsMainL3DataTableSHIFTID,
            this.coldsMainL3DataTableNOTE,
            this.coldsMainL3DataTableMg_Cr_Bri_Ele_Waste,
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste,
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste,
            this.coldsMainL3DataTableCast_Wast,
            this.coldsMainL3DataTableBuild_ID,
            this.coldsMainL3DataTableCir_Age,
            this.coldsMainL3DataTableUp_Age,
            this.coldsMainL3DataTableDown_Age,
            this.coldsMainL3DataTableRepair_Position,
            this.coldsMainL3DataTableRepair_Case,
            this.coldsMainL3DataTableRepair_Per});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableNAME
            // 
            this.coldsMainL3DataTableNAME.Caption = "Name";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableINPUT_TIME
            // 
            this.coldsMainL3DataTableINPUT_TIME.Caption = "Input_Time";
            this.coldsMainL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableVACTUBE_NAME
            // 
            this.coldsMainL3DataTableVACTUBE_NAME.Caption = "VacTube_Name";
            this.coldsMainL3DataTableVACTUBE_NAME.ColumnName = "VACTUBE_NAME";
            this.coldsMainL3DataTableVACTUBE_NAME.Namespace = "";
            // 
            // coldsMainL3DataTableVACTUBE_ID
            // 
            this.coldsMainL3DataTableVACTUBE_ID.Caption = "VacTube_Id";
            this.coldsMainL3DataTableVACTUBE_ID.ColumnName = "VACTUBE_ID";
            this.coldsMainL3DataTableVACTUBE_ID.Namespace = "";
            // 
            // coldsMainL3DataTableREFRA_FAC
            // 
            this.coldsMainL3DataTableREFRA_FAC.Caption = "Refra_Fac";
            this.coldsMainL3DataTableREFRA_FAC.ColumnName = "REFRA_FAC";
            this.coldsMainL3DataTableREFRA_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableRH_AGE
            // 
            this.coldsMainL3DataTableRH_AGE.Caption = "RH_Age";
            this.coldsMainL3DataTableRH_AGE.ColumnName = "RH_AGE";
            this.coldsMainL3DataTableRH_AGE.DataType = typeof(int);
            this.coldsMainL3DataTableRH_AGE.Namespace = "";
            // 
            // coldsMainL3DataTableINWALL_BRI_THICK
            // 
            this.coldsMainL3DataTableINWALL_BRI_THICK.Caption = "InWall_Bri_Thick";
            this.coldsMainL3DataTableINWALL_BRI_THICK.ColumnName = "INWALL_BRI_THICK";
            this.coldsMainL3DataTableINWALL_BRI_THICK.DataType = typeof(double);
            this.coldsMainL3DataTableINWALL_BRI_THICK.Namespace = "";
            // 
            // coldsMainL3DataTableINBOT_BRI_THICK
            // 
            this.coldsMainL3DataTableINBOT_BRI_THICK.Caption = "InBot_Bri_Thick";
            this.coldsMainL3DataTableINBOT_BRI_THICK.ColumnName = "INBOT_BRI_THICK";
            this.coldsMainL3DataTableINBOT_BRI_THICK.DataType = typeof(double);
            this.coldsMainL3DataTableINBOT_BRI_THICK.Namespace = "";
            // 
            // coldsMainL3DataTableMG_CR_FIR_WASTE
            // 
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.Caption = "Mg_Cr_Fir_Waste";
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.ColumnName = "MG_CR_FIR_WASTE";
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableMG_CR_FIR_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableBEAR_FIR_WASTE
            // 
            this.coldsMainL3DataTableBEAR_FIR_WASTE.Caption = "Bear_Fir_Waste";
            this.coldsMainL3DataTableBEAR_FIR_WASTE.ColumnName = "BEAR_FIR_WASTE";
            this.coldsMainL3DataTableBEAR_FIR_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableBEAR_FIR_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableSI_CA_BOA_WASTE
            // 
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.Caption = "Si_Ca_Boa_Waste";
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.ColumnName = "SI_CA_BOA_WASTE";
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableSI_CA_BOA_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableLIGHT_MAT_BRI_WASTE
            // 
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.Caption = "Light_Mat_Bri_Waste";
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.ColumnName = "LIGHT_MAT_BRI_WASTE";
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTableLIGHT_MAT_BRI_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTablePUG_HIT_MAT_WASTE
            // 
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.Caption = "Pug_Hit_Mat_Waste";
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.ColumnName = "PUG_HIT_MAT_WASTE";
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.DataType = typeof(double);
            this.coldsMainL3DataTablePUG_HIT_MAT_WASTE.Namespace = "";
            // 
            // coldsMainL3DataTableTEAMID
            // 
            this.coldsMainL3DataTableTEAMID.Caption = "TeamID";
            this.coldsMainL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsMainL3DataTableTEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableSHIFTID
            // 
            this.coldsMainL3DataTableSHIFTID.Caption = "ShiftID";
            this.coldsMainL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsMainL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "Note";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // coldsMainL3DataTableMg_Cr_Bri_Ele_Waste
            // 
            this.coldsMainL3DataTableMg_Cr_Bri_Ele_Waste.Caption = "Mg_Cr_Bri_Ele_Waste";
            this.coldsMainL3DataTableMg_Cr_Bri_Ele_Waste.ColumnName = "Mg_Cr_Bri_Ele_Waste";
            this.coldsMainL3DataTableMg_Cr_Bri_Ele_Waste.DataType = typeof(double);
            this.coldsMainL3DataTableMg_Cr_Bri_Ele_Waste.Namespace = "";
            // 
            // coldsMainL3DataTableMg_Cr_Bri_Dir_Waste
            // 
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste.Caption = "Mg_Cr_Bri_Dir_Waste";
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste.ColumnName = "Mg_Cr_Bri_Dir_Waste";
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste.DataType = typeof(double);
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste.Namespace = "";
            // 
            // coldsMainL3DataTableMg_Cr_Bri_Half_Waste
            // 
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste.Caption = "Mg_Cr_Bri_Half_Waste";
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste.ColumnName = "Mg_Cr_Bri_Half_Waste";
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste.DataType = typeof(double);
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste.Namespace = "";
            // 
            // coldsMainL3DataTableCast_Wast
            // 
            this.coldsMainL3DataTableCast_Wast.Caption = "Cast_Wast";
            this.coldsMainL3DataTableCast_Wast.ColumnName = "Cast_Wast";
            this.coldsMainL3DataTableCast_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableCast_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableBuild_ID
            // 
            this.coldsMainL3DataTableBuild_ID.Caption = "Build_ID";
            this.coldsMainL3DataTableBuild_ID.ColumnName = "Build_ID";
            this.coldsMainL3DataTableBuild_ID.Namespace = "";
            // 
            // coldsMainL3DataTableCir_Age
            // 
            this.coldsMainL3DataTableCir_Age.Caption = "Cir_Age";
            this.coldsMainL3DataTableCir_Age.ColumnName = "Cir_Age";
            this.coldsMainL3DataTableCir_Age.DataType = typeof(int);
            this.coldsMainL3DataTableCir_Age.Namespace = "";
            // 
            // coldsMainL3DataTableUp_Age
            // 
            this.coldsMainL3DataTableUp_Age.Caption = "Up_Age";
            this.coldsMainL3DataTableUp_Age.ColumnName = "Up_Age";
            this.coldsMainL3DataTableUp_Age.DataType = typeof(int);
            this.coldsMainL3DataTableUp_Age.Namespace = "";
            // 
            // coldsMainL3DataTableDown_Age
            // 
            this.coldsMainL3DataTableDown_Age.Caption = "Down_Age";
            this.coldsMainL3DataTableDown_Age.ColumnName = "Down_Age";
            this.coldsMainL3DataTableDown_Age.DataType = typeof(int);
            this.coldsMainL3DataTableDown_Age.Namespace = "";
            // 
            // coldsMainL3DataTableRepair_Position
            // 
            this.coldsMainL3DataTableRepair_Position.Caption = "Repair_Position";
            this.coldsMainL3DataTableRepair_Position.ColumnName = "Repair_Position";
            this.coldsMainL3DataTableRepair_Position.Namespace = "";
            // 
            // coldsMainL3DataTableRepair_Case
            // 
            this.coldsMainL3DataTableRepair_Case.Caption = "Repair_Case";
            this.coldsMainL3DataTableRepair_Case.ColumnName = "Repair_Case";
            this.coldsMainL3DataTableRepair_Case.Namespace = "";
            // 
            // coldsMainL3DataTableRepair_Per
            // 
            this.coldsMainL3DataTableRepair_Per.Caption = "Repair_Per";
            this.coldsMainL3DataTableRepair_Per.ColumnName = "Repair_Per";
            this.coldsMainL3DataTableRepair_Per.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(519, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(438, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dsShiftID
            // 
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
            // dsTeamID
            // 
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 452);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(604, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox19);
            this.tabPage1.Controls.Add(this.textBox18);
            this.tabPage1.Controls.Add(this.textBox17);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox21);
            this.tabPage1.Controls.Add(this.textBox15);
            this.tabPage1.Controls.Add(this.textBox20);
            this.tabPage1.Controls.Add(this.textBox14);
            this.tabPage1.Controls.Add(this.textBox16);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.cmbVacTubeName);
            this.tabPage1.Controls.Add(this.cmbVacTubeID);
            this.tabPage1.Controls.Add(this.cmbRefraFac);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 427);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "砌筑信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "INBOT_BRI_THICK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N2"));
            this.textBox6.Location = new System.Drawing.Point(112, 264);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(142, 21);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "INWALL_BRI_THICK", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N2"));
            this.textBox5.Location = new System.Drawing.Point(112, 238);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 21);
            this.textBox5.TabIndex = 9;
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Down_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox19.Location = new System.Drawing.Point(112, 212);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(142, 21);
            this.textBox19.TabIndex = 8;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Up_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox18.Location = new System.Drawing.Point(112, 186);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(142, 21);
            this.textBox18.TabIndex = 7;
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cir_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox17.Location = new System.Drawing.Point(112, 160);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(142, 21);
            this.textBox17.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "RH_AGE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox4.Location = new System.Drawing.Point(112, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 21);
            this.textBox4.TabIndex = 5;
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Repair_Case", true));
            this.textBox21.Location = new System.Drawing.Point(428, 267);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(142, 21);
            this.textBox21.TabIndex = 23;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cast_Wast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox15.Location = new System.Drawing.Point(428, 215);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(142, 21);
            this.textBox15.TabIndex = 21;
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Repair_Position", true));
            this.textBox20.Location = new System.Drawing.Point(428, 241);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(142, 21);
            this.textBox20.TabIndex = 22;
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "PUG_HIT_MAT_WASTE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox14.Location = new System.Drawing.Point(428, 189);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(142, 21);
            this.textBox14.TabIndex = 20;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Build_ID", true));
            this.textBox16.Location = new System.Drawing.Point(112, 33);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(142, 21);
            this.textBox16.TabIndex = 1;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "LIGHT_MAT_BRI_WASTE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox13.Location = new System.Drawing.Point(428, 163);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(142, 21);
            this.textBox13.TabIndex = 19;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "SI_CA_BOA_WASTE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox12.Location = new System.Drawing.Point(428, 137);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(142, 21);
            this.textBox12.TabIndex = 18;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "BEAR_FIR_WASTE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox11.Location = new System.Drawing.Point(428, 111);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(142, 21);
            this.textBox11.TabIndex = 17;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "MG_CR_FIR_WASTE", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox10.Location = new System.Drawing.Point(428, 85);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(142, 21);
            this.textBox10.TabIndex = 16;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Mg_Cr_Bri_Half_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox9.Location = new System.Drawing.Point(428, 59);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(142, 21);
            this.textBox9.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Mg_Cr_Bri_Dir_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox8.Location = new System.Drawing.Point(428, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(142, 21);
            this.textBox8.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Mg_Cr_Bri_Ele_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox7.Location = new System.Drawing.Point(428, 7);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(142, 21);
            this.textBox7.TabIndex = 13;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(363, 271);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 90;
            this.label34.Text = "修补情况:";
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOTE", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = null;
            this.rtxtNote.Location = new System.Drawing.Point(112, 346);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(467, 69);
            this.rtxtNote.TabIndex = 25;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = null;
            this.rtxtNote.ValidEable = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(357, 219);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 12);
            this.label32.TabIndex = 90;
            this.label32.Text = "浇注料[t]:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(71, 346);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 88;
            this.label46.Text = "备注:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "SHIFTID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(112, 320);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(142, 20);
            this.cmbShiftID.TabIndex = 12;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TEAMID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(112, 290);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(142, 20);
            this.cmbTeamID.TabIndex = 11;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Repair_Per", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(428, 293);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(142, 21);
            this.txtOperator.TabIndex = 24;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(71, 323);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 83;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(71, 297);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 84;
            this.label45.Text = "班别:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(363, 245);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 12);
            this.label33.TabIndex = 69;
            this.label33.Text = "修补部位:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(375, 297);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 12);
            this.label28.TabIndex = 82;
            this.label28.Text = "修补人:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(357, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 69;
            this.label23.Text = "捣打料[t]:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(357, 167);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 68;
            this.label24.Text = "轻质砖[t]:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(357, 141);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 73;
            this.label25.Text = "硅钙板[t]:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(339, 89);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 12);
            this.label26.TabIndex = 72;
            this.label26.Text = "Mg-Cr火泥[t]:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(357, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 71;
            this.label27.Text = "耐火泥[t]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(47, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 58;
            this.label22.Text = "砌筑编号:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(23, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 58;
            this.label6.Text = "槽底残砖厚度:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(23, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 57;
            this.label9.Text = "槽壁残砖厚度:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(5, 219);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 12);
            this.label29.TabIndex = 61;
            this.label29.Text = "下降管寿命[min]:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(303, 63);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 12);
            this.label31.TabIndex = 60;
            this.label31.Text = "半再结合Mg-Cr砖[t]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 61;
            this.label2.Text = "上升管寿命[min]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(35, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "环流管寿命:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(303, 37);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(119, 12);
            this.label30.TabIndex = 60;
            this.label30.Text = "直接结合Mg-Cr砖[t]:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(59, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 61;
            this.label19.Text = "槽寿命:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(291, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 12);
            this.label21.TabIndex = 60;
            this.label21.Text = "电熔再结合Mg-Cr砖[t]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(47, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "录入时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(71, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 34;
            this.label5.Text = "名称:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(47, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "耐材厂家:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(71, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "编号:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "INPUT_TIME", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(112, 7);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(142, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // cmbVacTubeName
            // 
            this.cmbVacTubeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVacTubeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVacTubeName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "VACTUBE_NAME", true));
            this.cmbVacTubeName.DataSource = this.dsName;
            this.cmbVacTubeName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbVacTubeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacTubeName.EnableNull = true;
            this.cmbVacTubeName.ErropPr = null;
            this.cmbVacTubeName.FormattingEnabled = true;
            this.cmbVacTubeName.Location = new System.Drawing.Point(112, 59);
            this.cmbVacTubeName.Name = "cmbVacTubeName";
            this.cmbVacTubeName.Size = new System.Drawing.Size(142, 20);
            this.cmbVacTubeName.TabIndex = 2;
            this.cmbVacTubeName.ToolTipValid = null;
            this.cmbVacTubeName.ValidEable = true;
            this.cmbVacTubeName.ValueMember = "L3DataTable.Code";
            this.cmbVacTubeName.TextChanged += new System.EventHandler(this.cmbVacTubeName_TextChanged);
            // 
            // dsName
            // 
            this.dsName.AutoSubscribe = false;
            this.dsName.DataSetName = "L3DataSet";
            this.dsName.DeleteMethod = null;
            this.dsName.InsertMethod = null;
            this.dsName.L3DataAdapter = this.Adapter;
            this.dsName.LoadEvent = "Click";
            this.dsName.LoadTrigger = null;
            this.dsName.RefreshValve = 1000;
            this.dsName.SourceCommand = null;
            this.dsName.SourceCondition = "CODE_GROUP = \'VacTubeName\'  AND CODE < \'3\' order by Code";
            this.dsName.SourceMethod = "";
            this.dsName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsName.SubscribeTarget = null;
            this.dsName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsName});
            this.dsName.UpdateEvent = "Click";
            this.dsName.UpdateMethod = null;
            this.dsName.UpdateTrigger = null;
            // 
            // schemadsName
            // 
            this.schemadsName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNameL3DataTableCode,
            this.coldsNameL3DataTableCode_Des});
            this.schemadsName.TableName = "L3DataTable";
            // 
            // coldsNameL3DataTableCode
            // 
            this.coldsNameL3DataTableCode.Caption = "Code";
            this.coldsNameL3DataTableCode.ColumnName = "Code";
            this.coldsNameL3DataTableCode.Namespace = "";
            // 
            // coldsNameL3DataTableCode_Des
            // 
            this.coldsNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsNameL3DataTableCode_Des.Namespace = "";
            // 
            // cmbVacTubeID
            // 
            this.cmbVacTubeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVacTubeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVacTubeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "VACTUBE_ID", true));
            this.cmbVacTubeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacTubeID.EnableNull = true;
            this.cmbVacTubeID.ErropPr = null;
            this.cmbVacTubeID.FormattingEnabled = true;
            this.cmbVacTubeID.Location = new System.Drawing.Point(112, 84);
            this.cmbVacTubeID.Name = "cmbVacTubeID";
            this.cmbVacTubeID.Size = new System.Drawing.Size(142, 20);
            this.cmbVacTubeID.TabIndex = 3;
            this.cmbVacTubeID.ToolTipValid = null;
            this.cmbVacTubeID.ValidEable = true;
            // 
            // cmbRefraFac
            // 
            this.cmbRefraFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefraFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefraFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "REFRA_FAC", true));
            this.cmbRefraFac.DataSource = this.dsFac;
            this.cmbRefraFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbRefraFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefraFac.EnableNull = true;
            this.cmbRefraFac.ErropPr = null;
            this.cmbRefraFac.FormattingEnabled = true;
            this.cmbRefraFac.Location = new System.Drawing.Point(112, 109);
            this.cmbRefraFac.Name = "cmbRefraFac";
            this.cmbRefraFac.Size = new System.Drawing.Size(142, 20);
            this.cmbRefraFac.TabIndex = 4;
            this.cmbRefraFac.ToolTipValid = null;
            this.cmbRefraFac.ValidEable = true;
            this.cmbRefraFac.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsFac
            // 
            this.dsFac.AutoSubscribe = false;
            this.dsFac.DataSetName = "L3DataSet";
            this.dsFac.DeleteMethod = null;
            this.dsFac.InsertMethod = null;
            this.dsFac.L3DataAdapter = this.Adapter;
            this.dsFac.LoadEvent = "Click";
            this.dsFac.LoadTrigger = null;
            this.dsFac.RefreshValve = 1000;
            this.dsFac.SourceCommand = null;
            this.dsFac.SourceCondition = "MatGroup_Code = \'VacTubeFac\' and MatName = \'耐材\'";
            this.dsFac.SourceMethod = "";
            this.dsFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsFac.SubscribeTarget = null;
            this.dsFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFac});
            this.dsFac.UpdateEvent = "Click";
            this.dsFac.UpdateMethod = null;
            this.dsFac.UpdateTrigger = null;
            // 
            // schemadsFac
            // 
            this.schemadsFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFacL3DataTableMatFactory});
            this.schemadsFac.TableName = "L3DataTable";
            // 
            // coldsFacL3DataTableMatFactory
            // 
            this.coldsFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsFacL3DataTableMatFactory.Namespace = "";
            // 
            // dsNo
            // 
            this.dsNo.AutoSubscribe = false;
            this.dsNo.DataSetName = "L3DataSet";
            this.dsNo.DeleteMethod = null;
            this.dsNo.InsertMethod = null;
            this.dsNo.L3DataAdapter = this.Adapter;
            this.dsNo.LoadEvent = "Click";
            this.dsNo.LoadTrigger = null;
            this.dsNo.RefreshValve = 1000;
            this.dsNo.SourceCommand = null;
            this.dsNo.SourceCondition = null;
            this.dsNo.SourceMethod = "";
            this.dsNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNo.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsNo.SubscribeTarget = null;
            this.dsNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsNo});
            this.dsNo.UpdateEvent = "Click";
            this.dsNo.UpdateMethod = null;
            this.dsNo.UpdateTrigger = null;
            // 
            // schemadsNo
            // 
            this.schemadsNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNoL3DataTableVacTube_ID,
            this.coldsNoL3DataTableVacTube_Name});
            this.schemadsNo.TableName = "L3DataTable";
            // 
            // coldsNoL3DataTableVacTube_ID
            // 
            this.coldsNoL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsNoL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsNoL3DataTableVacTube_ID.Namespace = "";
            // 
            // coldsNoL3DataTableVacTube_Name
            // 
            this.coldsNoL3DataTableVacTube_Name.Caption = "VacTube_Name";
            this.coldsNoL3DataTableVacTube_Name.ColumnName = "VacTube_Name";
            this.coldsNoL3DataTableVacTube_Name.Namespace = "";
            // 
            // bsTop
            // 
            this.bsTop.DataMember = "L3DataTable";
            this.bsTop.DataSource = this.dsNo;
            this.bsTop.Filter = "VacTube_Name = \'1\'";
            // 
            // bsLow
            // 
            this.bsLow.DataMember = "L3DataTable";
            this.bsLow.DataSource = this.dsNo;
            this.bsLow.Filter = "VacTube_Name = \'2\'";
            // 
            // VacTubeRepairShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VacTubeRepairShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RH炉真空槽修补信息维护";
            this.Load += new System.EventHandler(this.VacTubeRepairShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3Adapter Adapter;
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
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private PxDataValid.PxComboBox cmbVacTubeName;
        private PxDataValid.PxComboBox cmbVacTubeID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableVACTUBE_NAME;
        private System.Data.DataColumn coldsMainL3DataTableVACTUBE_ID;
        private System.Data.DataColumn coldsMainL3DataTableREFRA_FAC;
        private System.Data.DataColumn coldsMainL3DataTableRH_AGE;
        private System.Data.DataColumn coldsMainL3DataTableINWALL_BRI_THICK;
        private System.Data.DataColumn coldsMainL3DataTableINBOT_BRI_THICK;
        private System.Data.DataColumn coldsMainL3DataTableMG_CR_FIR_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableBEAR_FIR_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableSI_CA_BOA_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableLIGHT_MAT_BRI_WASTE;
        private System.Data.DataColumn coldsMainL3DataTablePUG_HIT_MAT_WASTE;
        private System.Data.DataColumn coldsMainL3DataTableTEAMID;
        private System.Data.DataColumn coldsMainL3DataTableSHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private AppSvrHMI.L3DataSet dsName;
        private System.Data.DataTable schemadsName;
        private System.Data.DataColumn coldsNameL3DataTableCode;
        private System.Data.DataColumn coldsNameL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsNo;
        private System.Data.DataTable schemadsNo;
        private System.Data.DataColumn coldsNoL3DataTableVacTube_ID;
        private System.Windows.Forms.BindingSource bsTop;
        private System.Windows.Forms.BindingSource bsLow;
        private System.Data.DataColumn coldsNoL3DataTableVacTube_Name;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Data.DataColumn coldsMainL3DataTableMg_Cr_Bri_Ele_Waste;
        private System.Data.DataColumn coldsMainL3DataTableMg_Cr_Bri_Dir_Waste;
        private System.Data.DataColumn coldsMainL3DataTableMg_Cr_Bri_Half_Waste;
        private System.Data.DataColumn coldsMainL3DataTableCast_Wast;
        private AppSvrHMI.L3DataSet dsFac;
        private System.Data.DataTable schemadsFac;
        private System.Data.DataColumn coldsFacL3DataTableMatFactory;
        private PxDataValid.PxComboBox cmbRefraFac;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Data.DataColumn coldsMainL3DataTableBuild_ID;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox16;
        private System.Data.DataColumn coldsMainL3DataTableCir_Age;
        private System.Data.DataColumn coldsMainL3DataTableUp_Age;
        private System.Data.DataColumn coldsMainL3DataTableDown_Age;
        private System.Data.DataColumn coldsMainL3DataTableRepair_Position;
        private System.Data.DataColumn coldsMainL3DataTableRepair_Case;
        private System.Data.DataColumn coldsMainL3DataTableRepair_Per;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
    }
}