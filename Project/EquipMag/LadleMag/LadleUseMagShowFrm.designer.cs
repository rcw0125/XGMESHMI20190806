namespace EquipMag.LadleMag
{
    partial class LadleUseMagShowFrm
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableInput_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableLadleID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableUse_Date = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableLadle_Age = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBOFID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSteel_Grade = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSeat_OK_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableTap_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOff_Ladle_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableArrive_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableComplete_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFire_Time_Len = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableStop_Time_Len = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableLadle_Check = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOff_Reason = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSk_Board_Keep = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableTeamID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableShiftID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOperator = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableNote = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHot_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFrame = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSplint = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableSpringBox = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableJoint = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableJoint_Safety_Pin = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableLong_Axes = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableShort_Axes = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableChassis = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableProtect_Board = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableUp_Tighten_Machine = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBreathe_Bri_Up = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBreathe_Bri_Low = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableWater_Gap = new System.Data.DataColumn();
            this.coldsMainL3DataTableIrr_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableIrr_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsMainL3DataTableRemnantWT = new System.Data.DataColumn();
            this.coldsMainL3DataTableWall_Temp = new System.Data.DataColumn();
            this.coldsMainL3DataTableNewLadleFirst = new System.Data.DataColumn();
            this.coldsMainL3DataTableNewLadleSecond = new System.Data.DataColumn();
            this.coldsMainL3DataTableFireLadleFirst = new System.Data.DataColumn();
            this.coldsMainL3DataTableFireLadleSecond = new System.Data.DataColumn();
            this.coldsMainL3DataTableReturnLadle = new System.Data.DataColumn();
            this.coldsMainL3DataTableHookEdgeLadle = new System.Data.DataColumn();
            this.coldsMainL3DataTableRemnantLadle = new System.Data.DataColumn();
            this.coldsMainL3DataTableComFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.AcoldsMainL3DataTableAct_Ladle_Grade = new System.Data.DataColumn();
            this.AcoldsMainL3DataTableLadle_Check1 = new System.Data.DataColumn();
            this.AcoldsMainL3DataTableAuto_Flow = new System.Data.DataColumn();
            this.coldsMainL3DataTableTime_After_Steel = new System.Data.DataColumn();
            this.coldsMainL3DataTableWorkStation = new System.Data.DataColumn();
            this.coldsMainL3DataTableCd_Temp = new System.Data.DataColumn();
            this.coldsMainL3DataTableCasting_Stop_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableSlagWire = new System.Data.DataColumn();
            this.coldsMainL3DataTableLADLE_GRADE = new System.Data.DataColumn();
            this.coldsMainL3DataTableDump_LadleID = new System.Data.DataColumn();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsLadleIDL3DataTableLadleType = new System.Data.DataColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdAutoFlow = new PxDataValid.PxComboBox();
            this.dsAutoFlow = new AppSvrHMI.L3DataSet();
            this.schemadsAutoFlow = new System.Data.DataTable();
            this.coldsAutoFlowL3DataTableCode = new System.Data.DataColumn();
            this.coldsAutoFlowL3DataTableCode_Des = new System.Data.DataColumn();
            this.label54 = new System.Windows.Forms.Label();
            this.txtWallTemp = new PxDataValid.PxTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label53 = new System.Windows.Forms.Label();
            this.pxComboBox1 = new PxDataValid.PxComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.cmbLableOutCheck = new PxDataValid.PxComboBox();
            this.dsLadleChcke1 = new AppSvrHMI.L3DataSet();
            this.schemadsLadleChcke1 = new System.Data.DataTable();
            this.coldsLadleChcke1L3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleChcke1L3DataTableCode_Des = new System.Data.DataColumn();
            this.label51 = new System.Windows.Forms.Label();
            this.txtStopTimeLen = new AppSvrHMI.L3DataBox();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLadleGrade_Act = new PxDataValid.PxComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbLadleGrade = new PxDataValid.PxComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSkBoardKeep = new PxDataValid.PxComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label48 = new System.Windows.Forms.Label();
            this.cmbOffReason = new PxDataValid.PxComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label49 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.pxTextBox5 = new PxDataValid.PxTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.dtTapTime = new System.Windows.Forms.DateTimePicker();
            this.cmbBOFID = new PxDataValid.PxComboBox();
            this.dsBOFID = new AppSvrHMI.L3DataSet();
            this.schemadsBOFID = new System.Data.DataTable();
            this.coldsBOFIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtSteelGrade = new PxDataValid.PxTextBox();
            this.cmbLadleID = new PxDataValid.PxComboBox();
            this.dtIrrTime = new System.Windows.Forms.DateTimePicker();
            this.cmbLadleCheck = new PxDataValid.PxComboBox();
            this.dsLadleChcke = new AppSvrHMI.L3DataSet();
            this.schemadsLadleChcke = new System.Data.DataTable();
            this.coldsLadleChckeL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleChckeL3DataTableCode_Des = new System.Data.DataColumn();
            this.dtIrrEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtBOFID = new PxDataValid.PxTextBox();
            this.dtSeatOKTime = new System.Windows.Forms.DateTimePicker();
            this.dtOffLadleTime = new System.Windows.Forms.DateTimePicker();
            this.txtFireTimeLen = new PxDataValid.PxTextBox();
            this.dtArriveTime = new System.Windows.Forms.DateTimePicker();
            this.txtLadleAge = new PxDataValid.PxTextBox();
            this.dtUseDate = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dtCompleteTime = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNote = new System.Windows.Forms.ComboBox();
            this.dsLadleNote = new AppSvrHMI.L3DataSet();
            this.schemadsLadleNote = new System.Data.DataTable();
            this.coldsLadleNoteL3DataTableCode = new System.Data.DataColumn();
            this.coldsLadleNoteL3DataTableCode_Des = new System.Data.DataColumn();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.txtRemnantWT = new PxDataValid.PxTextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.gbxAge = new System.Windows.Forms.GroupBox();
            this.txtProtectBoard = new PxDataValid.PxTextBox();
            this.txtJointSafetyPin = new PxDataValid.PxTextBox();
            this.txtUpTightenMachine = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtFrame = new PxDataValid.PxTextBox();
            this.txtLongAxes = new PxDataValid.PxTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtSplint = new PxDataValid.PxTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtWaterGap = new PxDataValid.PxTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtBreatheBriLow = new PxDataValid.PxTextBox();
            this.txtShortAxes = new PxDataValid.PxTextBox();
            this.txtBreatheBriUp = new PxDataValid.PxTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtChassis = new PxDataValid.PxTextBox();
            this.txtSpringBox = new PxDataValid.PxTextBox();
            this.txtJoint = new PxDataValid.PxTextBox();
            this.dsLadleGrade = new AppSvrHMI.L3DataSet();
            this.schemadsLadleGrade = new System.Data.DataTable();
            this.coldsLadleGradeL3DataTableCode = new System.Data.DataColumn();
            this.dsGetTime = new AppSvrHMI.L3DataSet();
            this.cmdGetTime = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpGetTime = new AppSvrHMI.L3CommandParameter();
            this.schemadsGetTime = new System.Data.DataTable();
            this.coldsGetTimeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableNAME = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableTREATNO = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableLADLEID = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableWEIGHT = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableREMAINWEIGHT = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableARRIVAL_TIME = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableLADLETYPE = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableDEPARTURE_TIME = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableCASTING_START_TIME = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableCASTING_STOP_TIME = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableHOLDTIME = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableTEMP = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableTEMPUPTO = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableHOLDTIME_REASON = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTablePROTECTION = new System.Data.DataColumn();
            this.coldsGetTimeL3DataTableUNPROTECTION_REASON = new System.Data.DataColumn();
            this.dsComLadleThrow = new AppSvrHMI.L3DataSet();
            this.schemadsComLadleThrow = new System.Data.DataTable();
            this.coldsComLadleThrowL3DataTableCode = new System.Data.DataColumn();
            this.coldsComLadleThrowL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsFinLadleThrow = new AppSvrHMI.L3DataSet();
            this.schemadsFinLadleThrow = new System.Data.DataTable();
            this.coldsFinLadleThrowL3DataTableCode = new System.Data.DataColumn();
            this.coldsFinLadleThrowL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsMainL3DataTableAct_Ladle_Grade = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Check1 = new System.Data.DataColumn();
            this.coldsMainL3DataTableAuto_Flow = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleNote)).BeginInit();
            this.gbxAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGetTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGetTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComLadleThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsComLadleThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinLadleThrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFinLadleThrow)).BeginInit();
            this.SuspendLayout();
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
            // Adapter
            // 
            this.Adapter.Session = null;
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
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Use";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = null;
            this.dsMain.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableName,
            this.coll3DataSet1L3DataTableInput_Time,
            this.coll3DataSet1L3DataTableLadleID,
            this.coll3DataSet1L3DataTableUse_Date,
            this.coll3DataSet1L3DataTableLadle_Age,
            this.coll3DataSet1L3DataTableBOFID,
            this.coll3DataSet1L3DataTableHeatID,
            this.coll3DataSet1L3DataTableSteel_Grade,
            this.coll3DataSet1L3DataTableSeat_OK_Time,
            this.coll3DataSet1L3DataTableTap_Time,
            this.coll3DataSet1L3DataTableOff_Ladle_Time,
            this.coll3DataSet1L3DataTableArrive_Time,
            this.coll3DataSet1L3DataTableComplete_Time,
            this.coll3DataSet1L3DataTableFire_Time_Len,
            this.coll3DataSet1L3DataTableStop_Time_Len,
            this.coll3DataSet1L3DataTableLadle_Check,
            this.coll3DataSet1L3DataTableOff_Reason,
            this.coll3DataSet1L3DataTableSk_Board_Keep,
            this.coll3DataSet1L3DataTableTeamID,
            this.coll3DataSet1L3DataTableShiftID,
            this.coll3DataSet1L3DataTableOperator,
            this.coll3DataSet1L3DataTableNote,
            this.coll3DataSet1L3DataTableHot_Time,
            this.coll3DataSet1L3DataTableFrame,
            this.coll3DataSet1L3DataTableSplint,
            this.coll3DataSet1L3DataTableSpringBox,
            this.coll3DataSet1L3DataTableJoint,
            this.coll3DataSet1L3DataTableJoint_Safety_Pin,
            this.coll3DataSet1L3DataTableLong_Axes,
            this.coll3DataSet1L3DataTableShort_Axes,
            this.coll3DataSet1L3DataTableChassis,
            this.coll3DataSet1L3DataTableProtect_Board,
            this.coll3DataSet1L3DataTableUp_Tighten_Machine,
            this.coll3DataSet1L3DataTableBreathe_Bri_Up,
            this.coll3DataSet1L3DataTableBreathe_Bri_Low,
            this.coll3DataSet1L3DataTableWater_Gap,
            this.coldsMainL3DataTableIrr_Start_Time,
            this.coldsMainL3DataTableIrr_End_Time,
            this.coldsMainL3DataTableWorkID,
            this.coldsMainL3DataTableRemnantWT,
            this.coldsMainL3DataTableWall_Temp,
            this.coldsMainL3DataTableNewLadleFirst,
            this.coldsMainL3DataTableNewLadleSecond,
            this.coldsMainL3DataTableFireLadleFirst,
            this.coldsMainL3DataTableFireLadleSecond,
            this.coldsMainL3DataTableReturnLadle,
            this.coldsMainL3DataTableHookEdgeLadle,
            this.coldsMainL3DataTableRemnantLadle,
            this.coldsMainL3DataTableComFlag,
            this.coldsMainL3DataTableConfirm_Flag,
            this.AcoldsMainL3DataTableAct_Ladle_Grade,
            this.AcoldsMainL3DataTableLadle_Check1,
            this.AcoldsMainL3DataTableAuto_Flow,
            this.coldsMainL3DataTableTime_After_Steel,
            this.coldsMainL3DataTableWorkStation,
            this.coldsMainL3DataTableCd_Temp,
            this.coldsMainL3DataTableCasting_Stop_Time,
            this.coldsMainL3DataTableSlagWire,
            this.coldsMainL3DataTableLADLE_GRADE,
            this.coldsMainL3DataTableDump_LadleID});
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
            // coll3DataSet1L3DataTableInput_Time
            // 
            this.coll3DataSet1L3DataTableInput_Time.Caption = "Input_Time";
            this.coll3DataSet1L3DataTableInput_Time.ColumnName = "Input_Time";
            this.coll3DataSet1L3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableInput_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableLadleID
            // 
            this.coll3DataSet1L3DataTableLadleID.Caption = "LadleID";
            this.coll3DataSet1L3DataTableLadleID.ColumnName = "LadleID";
            this.coll3DataSet1L3DataTableLadleID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableUse_Date
            // 
            this.coll3DataSet1L3DataTableUse_Date.Caption = "Use_Date";
            this.coll3DataSet1L3DataTableUse_Date.ColumnName = "Use_Date";
            this.coll3DataSet1L3DataTableUse_Date.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableUse_Date.Namespace = "";
            // 
            // coll3DataSet1L3DataTableLadle_Age
            // 
            this.coll3DataSet1L3DataTableLadle_Age.Caption = "Ladle_Age";
            this.coll3DataSet1L3DataTableLadle_Age.ColumnName = "Ladle_Age";
            this.coll3DataSet1L3DataTableLadle_Age.DataType = typeof(int);
            this.coll3DataSet1L3DataTableLadle_Age.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBOFID
            // 
            this.coll3DataSet1L3DataTableBOFID.Caption = "BOFID";
            this.coll3DataSet1L3DataTableBOFID.ColumnName = "BOFID";
            this.coll3DataSet1L3DataTableBOFID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableHeatID
            // 
            this.coll3DataSet1L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSteel_Grade
            // 
            this.coll3DataSet1L3DataTableSteel_Grade.Caption = "Steel_Grade";
            this.coll3DataSet1L3DataTableSteel_Grade.ColumnName = "Steel_Grade";
            this.coll3DataSet1L3DataTableSteel_Grade.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSeat_OK_Time
            // 
            this.coll3DataSet1L3DataTableSeat_OK_Time.Caption = "Seat_OK_Time";
            this.coll3DataSet1L3DataTableSeat_OK_Time.ColumnName = "Seat_OK_Time";
            this.coll3DataSet1L3DataTableSeat_OK_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableSeat_OK_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableTap_Time
            // 
            this.coll3DataSet1L3DataTableTap_Time.Caption = "Tap_Time";
            this.coll3DataSet1L3DataTableTap_Time.ColumnName = "Tap_Time";
            this.coll3DataSet1L3DataTableTap_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableTap_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOff_Ladle_Time
            // 
            this.coll3DataSet1L3DataTableOff_Ladle_Time.Caption = "Off_Ladle_Time";
            this.coll3DataSet1L3DataTableOff_Ladle_Time.ColumnName = "Off_Ladle_Time";
            this.coll3DataSet1L3DataTableOff_Ladle_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableOff_Ladle_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableArrive_Time
            // 
            this.coll3DataSet1L3DataTableArrive_Time.Caption = "Arrive_Time";
            this.coll3DataSet1L3DataTableArrive_Time.ColumnName = "Arrive_Time";
            this.coll3DataSet1L3DataTableArrive_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableArrive_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableComplete_Time
            // 
            this.coll3DataSet1L3DataTableComplete_Time.Caption = "Complete_Time";
            this.coll3DataSet1L3DataTableComplete_Time.ColumnName = "Complete_Time";
            this.coll3DataSet1L3DataTableComplete_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableComplete_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFire_Time_Len
            // 
            this.coll3DataSet1L3DataTableFire_Time_Len.Caption = "Fire_Time_Len";
            this.coll3DataSet1L3DataTableFire_Time_Len.ColumnName = "Fire_Time_Len";
            this.coll3DataSet1L3DataTableFire_Time_Len.DataType = typeof(double);
            this.coll3DataSet1L3DataTableFire_Time_Len.Namespace = "";
            // 
            // coll3DataSet1L3DataTableStop_Time_Len
            // 
            this.coll3DataSet1L3DataTableStop_Time_Len.Caption = "Stop_Time_Len";
            this.coll3DataSet1L3DataTableStop_Time_Len.ColumnName = "Stop_Time_Len";
            this.coll3DataSet1L3DataTableStop_Time_Len.DataType = typeof(double);
            this.coll3DataSet1L3DataTableStop_Time_Len.Namespace = "";
            // 
            // coll3DataSet1L3DataTableLadle_Check
            // 
            this.coll3DataSet1L3DataTableLadle_Check.Caption = "Ladle_Check";
            this.coll3DataSet1L3DataTableLadle_Check.ColumnName = "Ladle_Check";
            this.coll3DataSet1L3DataTableLadle_Check.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOff_Reason
            // 
            this.coll3DataSet1L3DataTableOff_Reason.Caption = "Off_Reason";
            this.coll3DataSet1L3DataTableOff_Reason.ColumnName = "Off_Reason";
            this.coll3DataSet1L3DataTableOff_Reason.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSk_Board_Keep
            // 
            this.coll3DataSet1L3DataTableSk_Board_Keep.Caption = "Sk_Board_Keep";
            this.coll3DataSet1L3DataTableSk_Board_Keep.ColumnName = "Sk_Board_Keep";
            this.coll3DataSet1L3DataTableSk_Board_Keep.Namespace = "";
            // 
            // coll3DataSet1L3DataTableTeamID
            // 
            this.coll3DataSet1L3DataTableTeamID.Caption = "TeamID";
            this.coll3DataSet1L3DataTableTeamID.ColumnName = "TeamID";
            this.coll3DataSet1L3DataTableTeamID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableShiftID
            // 
            this.coll3DataSet1L3DataTableShiftID.Caption = "ShiftID";
            this.coll3DataSet1L3DataTableShiftID.ColumnName = "ShiftID";
            this.coll3DataSet1L3DataTableShiftID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOperator
            // 
            this.coll3DataSet1L3DataTableOperator.Caption = "Operator";
            this.coll3DataSet1L3DataTableOperator.ColumnName = "Operator";
            this.coll3DataSet1L3DataTableOperator.Namespace = "";
            // 
            // coll3DataSet1L3DataTableNote
            // 
            this.coll3DataSet1L3DataTableNote.Caption = "Note";
            this.coll3DataSet1L3DataTableNote.ColumnName = "Note";
            this.coll3DataSet1L3DataTableNote.Namespace = "";
            // 
            // coll3DataSet1L3DataTableHot_Time
            // 
            this.coll3DataSet1L3DataTableHot_Time.Caption = "Hot_Time";
            this.coll3DataSet1L3DataTableHot_Time.ColumnName = "Hot_Time";
            this.coll3DataSet1L3DataTableHot_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableHot_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFrame
            // 
            this.coll3DataSet1L3DataTableFrame.Caption = "Frame";
            this.coll3DataSet1L3DataTableFrame.ColumnName = "Frame";
            this.coll3DataSet1L3DataTableFrame.DataType = typeof(int);
            this.coll3DataSet1L3DataTableFrame.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSplint
            // 
            this.coll3DataSet1L3DataTableSplint.Caption = "Splint";
            this.coll3DataSet1L3DataTableSplint.ColumnName = "Splint";
            this.coll3DataSet1L3DataTableSplint.DataType = typeof(int);
            this.coll3DataSet1L3DataTableSplint.Namespace = "";
            // 
            // coll3DataSet1L3DataTableSpringBox
            // 
            this.coll3DataSet1L3DataTableSpringBox.Caption = "SpringBox";
            this.coll3DataSet1L3DataTableSpringBox.ColumnName = "SpringBox";
            this.coll3DataSet1L3DataTableSpringBox.DataType = typeof(int);
            this.coll3DataSet1L3DataTableSpringBox.Namespace = "";
            // 
            // coll3DataSet1L3DataTableJoint
            // 
            this.coll3DataSet1L3DataTableJoint.Caption = "Joint";
            this.coll3DataSet1L3DataTableJoint.ColumnName = "Joint";
            this.coll3DataSet1L3DataTableJoint.DataType = typeof(int);
            this.coll3DataSet1L3DataTableJoint.Namespace = "";
            // 
            // coll3DataSet1L3DataTableJoint_Safety_Pin
            // 
            this.coll3DataSet1L3DataTableJoint_Safety_Pin.Caption = "Joint_Safety_Pin";
            this.coll3DataSet1L3DataTableJoint_Safety_Pin.ColumnName = "Joint_Safety_Pin";
            this.coll3DataSet1L3DataTableJoint_Safety_Pin.DataType = typeof(int);
            this.coll3DataSet1L3DataTableJoint_Safety_Pin.Namespace = "";
            // 
            // coll3DataSet1L3DataTableLong_Axes
            // 
            this.coll3DataSet1L3DataTableLong_Axes.Caption = "Long_Axes";
            this.coll3DataSet1L3DataTableLong_Axes.ColumnName = "Long_Axes";
            this.coll3DataSet1L3DataTableLong_Axes.DataType = typeof(int);
            this.coll3DataSet1L3DataTableLong_Axes.Namespace = "";
            // 
            // coll3DataSet1L3DataTableShort_Axes
            // 
            this.coll3DataSet1L3DataTableShort_Axes.Caption = "Short_Axes";
            this.coll3DataSet1L3DataTableShort_Axes.ColumnName = "Short_Axes";
            this.coll3DataSet1L3DataTableShort_Axes.DataType = typeof(int);
            this.coll3DataSet1L3DataTableShort_Axes.Namespace = "";
            // 
            // coll3DataSet1L3DataTableChassis
            // 
            this.coll3DataSet1L3DataTableChassis.Caption = "Chassis";
            this.coll3DataSet1L3DataTableChassis.ColumnName = "Chassis";
            this.coll3DataSet1L3DataTableChassis.DataType = typeof(int);
            this.coll3DataSet1L3DataTableChassis.Namespace = "";
            // 
            // coll3DataSet1L3DataTableProtect_Board
            // 
            this.coll3DataSet1L3DataTableProtect_Board.Caption = "Protect_Board";
            this.coll3DataSet1L3DataTableProtect_Board.ColumnName = "Protect_Board";
            this.coll3DataSet1L3DataTableProtect_Board.DataType = typeof(int);
            this.coll3DataSet1L3DataTableProtect_Board.Namespace = "";
            // 
            // coll3DataSet1L3DataTableUp_Tighten_Machine
            // 
            this.coll3DataSet1L3DataTableUp_Tighten_Machine.Caption = "Up_Tighten_Machine";
            this.coll3DataSet1L3DataTableUp_Tighten_Machine.ColumnName = "Up_Tighten_Machine";
            this.coll3DataSet1L3DataTableUp_Tighten_Machine.DataType = typeof(int);
            this.coll3DataSet1L3DataTableUp_Tighten_Machine.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBreathe_Bri_Up
            // 
            this.coll3DataSet1L3DataTableBreathe_Bri_Up.Caption = "Breathe_Bri_Up";
            this.coll3DataSet1L3DataTableBreathe_Bri_Up.ColumnName = "Breathe_Bri_Up";
            this.coll3DataSet1L3DataTableBreathe_Bri_Up.DataType = typeof(int);
            this.coll3DataSet1L3DataTableBreathe_Bri_Up.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBreathe_Bri_Low
            // 
            this.coll3DataSet1L3DataTableBreathe_Bri_Low.Caption = "Breathe_Bri_Low";
            this.coll3DataSet1L3DataTableBreathe_Bri_Low.ColumnName = "Breathe_Bri_Low";
            this.coll3DataSet1L3DataTableBreathe_Bri_Low.DataType = typeof(int);
            this.coll3DataSet1L3DataTableBreathe_Bri_Low.Namespace = "";
            // 
            // coll3DataSet1L3DataTableWater_Gap
            // 
            this.coll3DataSet1L3DataTableWater_Gap.Caption = "Water_Gap";
            this.coll3DataSet1L3DataTableWater_Gap.ColumnName = "Water_Gap";
            this.coll3DataSet1L3DataTableWater_Gap.DataType = typeof(int);
            this.coll3DataSet1L3DataTableWater_Gap.Namespace = "";
            // 
            // coldsMainL3DataTableIrr_Start_Time
            // 
            this.coldsMainL3DataTableIrr_Start_Time.Caption = "Irr_Start_Time";
            this.coldsMainL3DataTableIrr_Start_Time.ColumnName = "Irr_Start_Time";
            this.coldsMainL3DataTableIrr_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableIrr_Start_Time.Namespace = "";
            // 
            // coldsMainL3DataTableIrr_End_Time
            // 
            this.coldsMainL3DataTableIrr_End_Time.Caption = "Irr_End_Time";
            this.coldsMainL3DataTableIrr_End_Time.ColumnName = "Irr_End_Time";
            this.coldsMainL3DataTableIrr_End_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableIrr_End_Time.Namespace = "";
            // 
            // coldsMainL3DataTableWorkID
            // 
            this.coldsMainL3DataTableWorkID.Caption = "WorkID";
            this.coldsMainL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsMainL3DataTableWorkID.Namespace = "";
            // 
            // coldsMainL3DataTableRemnantWT
            // 
            this.coldsMainL3DataTableRemnantWT.Caption = "RemnantWT";
            this.coldsMainL3DataTableRemnantWT.ColumnName = "RemnantWT";
            this.coldsMainL3DataTableRemnantWT.DataType = typeof(double);
            this.coldsMainL3DataTableRemnantWT.Namespace = "";
            // 
            // coldsMainL3DataTableWall_Temp
            // 
            this.coldsMainL3DataTableWall_Temp.Caption = "Wall_Temp";
            this.coldsMainL3DataTableWall_Temp.ColumnName = "Wall_Temp";
            this.coldsMainL3DataTableWall_Temp.DataType = typeof(int);
            this.coldsMainL3DataTableWall_Temp.Namespace = "";
            // 
            // coldsMainL3DataTableNewLadleFirst
            // 
            this.coldsMainL3DataTableNewLadleFirst.Caption = "NewLadleFirst";
            this.coldsMainL3DataTableNewLadleFirst.ColumnName = "NewLadleFirst";
            this.coldsMainL3DataTableNewLadleFirst.DataType = typeof(int);
            this.coldsMainL3DataTableNewLadleFirst.Namespace = "";
            // 
            // coldsMainL3DataTableNewLadleSecond
            // 
            this.coldsMainL3DataTableNewLadleSecond.Caption = "NewLadleSecond";
            this.coldsMainL3DataTableNewLadleSecond.ColumnName = "NewLadleSecond";
            this.coldsMainL3DataTableNewLadleSecond.DataType = typeof(int);
            this.coldsMainL3DataTableNewLadleSecond.Namespace = "";
            // 
            // coldsMainL3DataTableFireLadleFirst
            // 
            this.coldsMainL3DataTableFireLadleFirst.Caption = "FireLadleFirst";
            this.coldsMainL3DataTableFireLadleFirst.ColumnName = "FireLadleFirst";
            this.coldsMainL3DataTableFireLadleFirst.DataType = typeof(int);
            this.coldsMainL3DataTableFireLadleFirst.Namespace = "";
            // 
            // coldsMainL3DataTableFireLadleSecond
            // 
            this.coldsMainL3DataTableFireLadleSecond.Caption = "FireLadleSecond";
            this.coldsMainL3DataTableFireLadleSecond.ColumnName = "FireLadleSecond";
            this.coldsMainL3DataTableFireLadleSecond.DataType = typeof(int);
            this.coldsMainL3DataTableFireLadleSecond.Namespace = "";
            // 
            // coldsMainL3DataTableReturnLadle
            // 
            this.coldsMainL3DataTableReturnLadle.Caption = "ReturnLadle";
            this.coldsMainL3DataTableReturnLadle.ColumnName = "ReturnLadle";
            this.coldsMainL3DataTableReturnLadle.DataType = typeof(int);
            this.coldsMainL3DataTableReturnLadle.Namespace = "";
            // 
            // coldsMainL3DataTableHookEdgeLadle
            // 
            this.coldsMainL3DataTableHookEdgeLadle.Caption = "HookEdgeLadle";
            this.coldsMainL3DataTableHookEdgeLadle.ColumnName = "HookEdgeLadle";
            this.coldsMainL3DataTableHookEdgeLadle.DataType = typeof(int);
            this.coldsMainL3DataTableHookEdgeLadle.Namespace = "";
            // 
            // coldsMainL3DataTableRemnantLadle
            // 
            this.coldsMainL3DataTableRemnantLadle.Caption = "RemnantLadle";
            this.coldsMainL3DataTableRemnantLadle.ColumnName = "RemnantLadle";
            this.coldsMainL3DataTableRemnantLadle.DataType = typeof(int);
            this.coldsMainL3DataTableRemnantLadle.Namespace = "";
            // 
            // coldsMainL3DataTableComFlag
            // 
            this.coldsMainL3DataTableComFlag.Caption = "ComFlag";
            this.coldsMainL3DataTableComFlag.ColumnName = "ComFlag";
            this.coldsMainL3DataTableComFlag.DataType = typeof(int);
            this.coldsMainL3DataTableComFlag.Namespace = "";
            // 
            // coldsMainL3DataTableConfirm_Flag
            // 
            this.coldsMainL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsMainL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsMainL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsMainL3DataTableConfirm_Flag.Namespace = "";
            // 
            // AcoldsMainL3DataTableAct_Ladle_Grade
            // 
            this.AcoldsMainL3DataTableAct_Ladle_Grade.Caption = "Act_Ladle_Grade";
            this.AcoldsMainL3DataTableAct_Ladle_Grade.ColumnName = "Act_Ladle_Grade";
            this.AcoldsMainL3DataTableAct_Ladle_Grade.Namespace = "";
            // 
            // AcoldsMainL3DataTableLadle_Check1
            // 
            this.AcoldsMainL3DataTableLadle_Check1.Caption = "Ladle_Check1";
            this.AcoldsMainL3DataTableLadle_Check1.ColumnName = "Ladle_Check1";
            this.AcoldsMainL3DataTableLadle_Check1.Namespace = "";
            // 
            // AcoldsMainL3DataTableAuto_Flow
            // 
            this.AcoldsMainL3DataTableAuto_Flow.Caption = "Auto_Flow";
            this.AcoldsMainL3DataTableAuto_Flow.ColumnName = "Auto_Flow";
            this.AcoldsMainL3DataTableAuto_Flow.DataType = typeof(int);
            this.AcoldsMainL3DataTableAuto_Flow.Namespace = "";
            // 
            // coldsMainL3DataTableTime_After_Steel
            // 
            this.coldsMainL3DataTableTime_After_Steel.Caption = "Time_After_Steel";
            this.coldsMainL3DataTableTime_After_Steel.ColumnName = "Time_After_Steel";
            this.coldsMainL3DataTableTime_After_Steel.DataType = typeof(double);
            this.coldsMainL3DataTableTime_After_Steel.Namespace = "";
            // 
            // coldsMainL3DataTableWorkStation
            // 
            this.coldsMainL3DataTableWorkStation.Caption = "WorkStation";
            this.coldsMainL3DataTableWorkStation.ColumnName = "WorkStation";
            this.coldsMainL3DataTableWorkStation.Namespace = "";
            // 
            // coldsMainL3DataTableCd_Temp
            // 
            this.coldsMainL3DataTableCd_Temp.Caption = "Cd_Temp";
            this.coldsMainL3DataTableCd_Temp.ColumnName = "Cd_Temp";
            this.coldsMainL3DataTableCd_Temp.DataType = typeof(int);
            this.coldsMainL3DataTableCd_Temp.Namespace = "";
            // 
            // coldsMainL3DataTableCasting_Stop_Time
            // 
            this.coldsMainL3DataTableCasting_Stop_Time.Caption = "Casting_Stop_Time";
            this.coldsMainL3DataTableCasting_Stop_Time.ColumnName = "Casting_Stop_Time";
            this.coldsMainL3DataTableCasting_Stop_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableCasting_Stop_Time.Namespace = "";
            // 
            // coldsMainL3DataTableSlagWire
            // 
            this.coldsMainL3DataTableSlagWire.Caption = "SlagWire";
            this.coldsMainL3DataTableSlagWire.ColumnName = "SlagWire";
            this.coldsMainL3DataTableSlagWire.Namespace = "";
            // 
            // coldsMainL3DataTableLADLE_GRADE
            // 
            this.coldsMainL3DataTableLADLE_GRADE.Caption = "LADLE_GRADE";
            this.coldsMainL3DataTableLADLE_GRADE.ColumnName = "LADLE_GRADE";
            this.coldsMainL3DataTableLADLE_GRADE.Namespace = "";
            // 
            // coldsMainL3DataTableDump_LadleID
            // 
            this.coldsMainL3DataTableDump_LadleID.Caption = "Dump_LadleID";
            this.coldsMainL3DataTableDump_LadleID.ColumnName = "Dump_LadleID";
            this.coldsMainL3DataTableDump_LadleID.Namespace = "";
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoLoad = true;
            this.dsLadleID.AutoSubscribe = false;
            this.dsLadleID.DataSetName = "L3DataSet";
            this.dsLadleID.DeleteMethod = null;
            this.dsLadleID.InsertMethod = null;
            this.dsLadleID.L3DataAdapter = this.Adapter;
            this.dsLadleID.LoadEvent = "Click";
            this.dsLadleID.LoadTrigger = null;
            this.dsLadleID.RefreshValve = 1000;
            this.dsLadleID.SourceCommand = null;
            this.dsLadleID.SourceCondition = "";
            this.dsLadleID.SourceMethod = "";
            this.dsLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleID.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
            this.dsLadleID.SubscribeTarget = null;
            this.dsLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleID});
            this.dsLadleID.UpdateEvent = "Click";
            this.dsLadleID.UpdateMethod = null;
            this.dsLadleID.UpdateTrigger = null;
            // 
            // schemadsLadleID
            // 
            this.schemadsLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleIDL3DataTableLadleID,
            this.coldsLadleIDL3DataTableLadleType});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableLadleID
            // 
            this.coldsLadleIDL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.Namespace = "";
            // 
            // coldsLadleIDL3DataTableLadleType
            // 
            this.coldsLadleIDL3DataTableLadleType.Caption = "LadleType";
            this.coldsLadleIDL3DataTableLadleType.ColumnName = "LadleType";
            this.coldsLadleIDL3DataTableLadleType.DataType = typeof(int);
            this.coldsLadleIDL3DataTableLadleType.Namespace = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(837, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(762, 0);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 26);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 442);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(942, 49);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.gbxAge);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上件使用实绩";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdAutoFlow);
            this.groupBox3.Controls.Add(this.label54);
            this.groupBox3.Controls.Add(this.txtWallTemp);
            this.groupBox3.Controls.Add(this.label53);
            this.groupBox3.Controls.Add(this.pxComboBox1);
            this.groupBox3.Controls.Add(this.label52);
            this.groupBox3.Controls.Add(this.cmbLableOutCheck);
            this.groupBox3.Controls.Add(this.label51);
            this.groupBox3.Controls.Add(this.txtStopTimeLen);
            this.groupBox3.Controls.Add(this.dtInputTime);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Controls.Add(this.label34);
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbLadleGrade_Act);
            this.groupBox3.Controls.Add(this.cmbLadleGrade);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbSkBoardKeep);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbShiftID);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.cmbOffReason);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbTeamID);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.pxTextBox1);
            this.groupBox3.Controls.Add(this.pxTextBox5);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.dtTapTime);
            this.groupBox3.Controls.Add(this.cmbBOFID);
            this.groupBox3.Controls.Add(this.txtSteelGrade);
            this.groupBox3.Controls.Add(this.cmbLadleID);
            this.groupBox3.Controls.Add(this.dtIrrTime);
            this.groupBox3.Controls.Add(this.cmbLadleCheck);
            this.groupBox3.Controls.Add(this.dtIrrEndTime);
            this.groupBox3.Controls.Add(this.txtBOFID);
            this.groupBox3.Controls.Add(this.dtSeatOKTime);
            this.groupBox3.Controls.Add(this.dtOffLadleTime);
            this.groupBox3.Controls.Add(this.txtFireTimeLen);
            this.groupBox3.Controls.Add(this.dtArriveTime);
            this.groupBox3.Controls.Add(this.txtLadleAge);
            this.groupBox3.Controls.Add(this.dtUseDate);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.dtCompleteTime);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 285);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // cmdAutoFlow
            // 
            this.cmdAutoFlow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmdAutoFlow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmdAutoFlow.BackColor = System.Drawing.SystemColors.Window;
            this.cmdAutoFlow.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Auto_Flow", true));
            this.cmdAutoFlow.DataSource = this.dsAutoFlow;
            this.cmdAutoFlow.DisplayMember = "L3DataTable.Code_Des";
            this.cmdAutoFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmdAutoFlow.Enabled = false;
            this.cmdAutoFlow.EnableNull = true;
            this.cmdAutoFlow.ErropPr = null;
            this.cmdAutoFlow.FormattingEnabled = true;
            this.cmdAutoFlow.Location = new System.Drawing.Point(335, 256);
            this.cmdAutoFlow.Name = "cmdAutoFlow";
            this.cmdAutoFlow.ReadOnly = false;
            this.cmdAutoFlow.Size = new System.Drawing.Size(141, 20);
            this.cmdAutoFlow.TabIndex = 60;
            this.cmdAutoFlow.TMpEnabled = true;
            this.cmdAutoFlow.ToolTipValid = null;
            this.cmdAutoFlow.ValidEable = true;
            this.cmdAutoFlow.ValueMember = "L3DataTable.Code";
            // 
            // dsAutoFlow
            // 
            this.dsAutoFlow.AutoLoad = true;
            this.dsAutoFlow.AutoSubscribe = false;
            this.dsAutoFlow.DataSetName = "L3DataSet";
            this.dsAutoFlow.DeleteMethod = null;
            this.dsAutoFlow.InsertMethod = null;
            this.dsAutoFlow.L3DataAdapter = this.Adapter;
            this.dsAutoFlow.LoadEvent = "Click";
            this.dsAutoFlow.LoadTrigger = null;
            this.dsAutoFlow.RefreshValve = 1000;
            this.dsAutoFlow.SourceCommand = null;
            this.dsAutoFlow.SourceCondition = "Code_Group = \'CCM_AutoFlow\' order by Code";
            this.dsAutoFlow.SourceMethod = "";
            this.dsAutoFlow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAutoFlow.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAutoFlow.SubscribeTarget = null;
            this.dsAutoFlow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAutoFlow});
            this.dsAutoFlow.UpdateEvent = "Click";
            this.dsAutoFlow.UpdateMethod = null;
            this.dsAutoFlow.UpdateTrigger = null;
            // 
            // schemadsAutoFlow
            // 
            this.schemadsAutoFlow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAutoFlowL3DataTableCode,
            this.coldsAutoFlowL3DataTableCode_Des});
            this.schemadsAutoFlow.TableName = "L3DataTable";
            // 
            // coldsAutoFlowL3DataTableCode
            // 
            this.coldsAutoFlowL3DataTableCode.Caption = "Code";
            this.coldsAutoFlowL3DataTableCode.ColumnName = "Code";
            this.coldsAutoFlowL3DataTableCode.Namespace = "";
            // 
            // coldsAutoFlowL3DataTableCode_Des
            // 
            this.coldsAutoFlowL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAutoFlowL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAutoFlowL3DataTableCode_Des.Namespace = "";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Location = new System.Drawing.Point(246, 260);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 12);
            this.label54.TabIndex = 61;
            this.label54.Text = "是否自动开浇:";
            // 
            // txtWallTemp
            // 
            this.txtWallTemp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Wall_Temp", true));
            this.txtWallTemp.DisplayPrecision = 0;
            this.txtWallTemp.Enabled = false;
            this.txtWallTemp.EnableNull = true;
            this.txtWallTemp.ErropPr = null;
            this.txtWallTemp.FixedLength = 0;
            this.txtWallTemp.Length = 0;
            this.txtWallTemp.Location = new System.Drawing.Point(96, 251);
            this.txtWallTemp.Max = 999;
            this.txtWallTemp.MaxNull = 999;
            this.txtWallTemp.MaxStringLength = 0;
            this.txtWallTemp.MaxStrLength = 0;
            this.txtWallTemp.Min = 0;
            this.txtWallTemp.MinNull = 0;
            this.txtWallTemp.MinStringLength = 0;
            this.txtWallTemp.MinStrLength = 0;
            this.txtWallTemp.Name = "txtWallTemp";
            this.txtWallTemp.Precision = 0;
            this.txtWallTemp.Regex = "";
            this.txtWallTemp.Size = new System.Drawing.Size(141, 21);
            this.txtWallTemp.TabIndex = 58;
            this.txtWallTemp.Tag = "";
            this.toolTip1.SetToolTip(this.txtWallTemp, "必输项,不大于999的数字!");
            this.txtWallTemp.ToolTipValid = this.toolTip1;
            this.txtWallTemp.VaildWarning = "";
            this.txtWallTemp.ValidEable = true;
            this.txtWallTemp.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWallTemp.TextChanged += new System.EventHandler(this.txtWallTemp_TextChanged);
            this.txtWallTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWallTemp_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Location = new System.Drawing.Point(1, 254);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(95, 12);
            this.label53.TabIndex = 59;
            this.label53.Text = "出钢前包壁温度:";
            // 
            // pxComboBox1
            // 
            this.pxComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pxComboBox1.EnableNull = true;
            this.pxComboBox1.ErropPr = null;
            this.pxComboBox1.FormattingEnabled = true;
            this.pxComboBox1.Items.AddRange(new object[] {
            "",
            "换渣线第二炉",
            "新包第二炉"});
            this.pxComboBox1.Location = new System.Drawing.Point(334, 176);
            this.pxComboBox1.Name = "pxComboBox1";
            this.pxComboBox1.ReadOnly = false;
            this.pxComboBox1.Size = new System.Drawing.Size(141, 20);
            this.pxComboBox1.TabIndex = 56;
            this.pxComboBox1.TMpEnabled = true;
            this.pxComboBox1.ToolTipValid = null;
            this.pxComboBox1.ValidEable = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Location = new System.Drawing.Point(234, 179);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(95, 12);
            this.label52.TabIndex = 57;
            this.label52.Text = "渣线及其他情况:";
            // 
            // cmbLableOutCheck
            // 
            this.cmbLableOutCheck.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLableOutCheck.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLableOutCheck.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLableOutCheck.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Ladle_Check1", true));
            this.cmbLableOutCheck.DataSource = this.dsLadleChcke1;
            this.cmbLableOutCheck.DisplayMember = "L3DataTable.Code_Des";
            this.cmbLableOutCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLableOutCheck.EnableNull = true;
            this.cmbLableOutCheck.ErropPr = null;
            this.cmbLableOutCheck.FormattingEnabled = true;
            this.cmbLableOutCheck.Location = new System.Drawing.Point(568, 44);
            this.cmbLableOutCheck.Name = "cmbLableOutCheck";
            this.cmbLableOutCheck.ReadOnly = false;
            this.cmbLableOutCheck.Size = new System.Drawing.Size(141, 20);
            this.cmbLableOutCheck.TabIndex = 54;
            this.cmbLableOutCheck.TMpEnabled = true;
            this.cmbLableOutCheck.ToolTipValid = null;
            this.cmbLableOutCheck.ValidEable = true;
            this.cmbLableOutCheck.ValueMember = "L3DataTable.Code";
            this.cmbLableOutCheck.SelectedIndexChanged += new System.EventHandler(this.cmbLableOutCheck_SelectedIndexChanged);
            // 
            // dsLadleChcke1
            // 
            this.dsLadleChcke1.AutoLoad = true;
            this.dsLadleChcke1.AutoSubscribe = false;
            this.dsLadleChcke1.DataSetName = "L3DataSet";
            this.dsLadleChcke1.DeleteMethod = null;
            this.dsLadleChcke1.InsertMethod = null;
            this.dsLadleChcke1.L3DataAdapter = this.Adapter;
            this.dsLadleChcke1.LoadEvent = "Click";
            this.dsLadleChcke1.LoadTrigger = null;
            this.dsLadleChcke1.RefreshValve = 1000;
            this.dsLadleChcke1.SourceCommand = null;
            this.dsLadleChcke1.SourceCondition = "Code_Group = \'LadleChcke1\' order by Code";
            this.dsLadleChcke1.SourceMethod = "";
            this.dsLadleChcke1.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleChcke1.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleChcke1.SubscribeTarget = null;
            this.dsLadleChcke1.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleChcke1});
            this.dsLadleChcke1.UpdateEvent = "Click";
            this.dsLadleChcke1.UpdateMethod = null;
            this.dsLadleChcke1.UpdateTrigger = null;
            // 
            // schemadsLadleChcke1
            // 
            this.schemadsLadleChcke1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleChcke1L3DataTableCode,
            this.coldsLadleChcke1L3DataTableCode_Des});
            this.schemadsLadleChcke1.TableName = "L3DataTable";
            // 
            // coldsLadleChcke1L3DataTableCode
            // 
            this.coldsLadleChcke1L3DataTableCode.Caption = "Code";
            this.coldsLadleChcke1L3DataTableCode.ColumnName = "Code";
            this.coldsLadleChcke1L3DataTableCode.Namespace = "";
            // 
            // coldsLadleChcke1L3DataTableCode_Des
            // 
            this.coldsLadleChcke1L3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleChcke1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleChcke1L3DataTableCode_Des.Namespace = "";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Location = new System.Drawing.Point(479, 48);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(83, 12);
            this.label51.TabIndex = 55;
            this.label51.Text = "钢包外部检查:";
            // 
            // txtStopTimeLen
            // 
            this.txtStopTimeLen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Stop_Time_Len", true));
            this.txtStopTimeLen.DataFormat = "D2";
            this.txtStopTimeLen.DataObject = null;
            this.txtStopTimeLen.DataProperty = null;
            this.txtStopTimeLen.DataType = AppSvrHMI.L3DataBoxType.dtFloat;
            this.txtStopTimeLen.L3DataAdapter = null;
            this.txtStopTimeLen.Location = new System.Drawing.Point(335, 229);
            this.txtStopTimeLen.Name = "txtStopTimeLen";
            this.txtStopTimeLen.Size = new System.Drawing.Size(103, 21);
            this.txtStopTimeLen.TabIndex = 15;
            this.txtStopTimeLen.Value = null;
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(96, 18);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "钢包号:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(270, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 25;
            this.label19.Text = "出钢时间:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(441, 228);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(35, 20);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "算";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(31, 99);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 12);
            this.label34.TabIndex = 23;
            this.label34.Text = "转炉炉座:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(202, 70);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(35, 20);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "使用日期:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Location = new System.Drawing.Point(515, 99);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(47, 12);
            this.label55.TabIndex = 53;
            this.label55.Text = "甩包号:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(515, 230);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 12);
            this.label32.TabIndex = 53;
            this.label32.Text = "责任人:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(31, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "录入时间:";
            // 
            // cmbLadleGrade_Act
            // 
            this.cmbLadleGrade_Act.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleGrade_Act.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleGrade_Act.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLadleGrade_Act.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Act_Ladle_Grade", true));
            this.cmbLadleGrade_Act.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleGrade_Act.EnableNull = false;
            this.cmbLadleGrade_Act.ErropPr = this.errorProvider1;
            this.cmbLadleGrade_Act.FormattingEnabled = true;
            this.cmbLadleGrade_Act.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "A1",
            "A2",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "D1",
            "D2"});
            this.cmbLadleGrade_Act.Location = new System.Drawing.Point(568, 200);
            this.cmbLadleGrade_Act.Name = "cmbLadleGrade_Act";
            this.cmbLadleGrade_Act.ReadOnly = false;
            this.cmbLadleGrade_Act.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleGrade_Act.TabIndex = 20;
            this.cmbLadleGrade_Act.TMpEnabled = true;
            this.cmbLadleGrade_Act.ToolTipValid = this.toolTip1;
            this.cmbLadleGrade_Act.ValidEable = true;
            this.cmbLadleGrade_Act.TextChanged += new System.EventHandler(this.pxControls_TextChangedFact);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbLadleGrade
            // 
            this.cmbLadleGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleGrade.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLadleGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "LADLE_GRADE", true));
            this.cmbLadleGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleGrade.EnableNull = true;
            this.cmbLadleGrade.ErropPr = this.errorProvider1;
            this.cmbLadleGrade.FormattingEnabled = true;
            this.cmbLadleGrade.Items.AddRange(new object[] {
            "",
            "A",
            "B",
            "C",
            "D",
            "A1",
            "A2",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "D1",
            "D2"});
            this.cmbLadleGrade.Location = new System.Drawing.Point(568, 174);
            this.cmbLadleGrade.Name = "cmbLadleGrade";
            this.cmbLadleGrade.ReadOnly = false;
            this.cmbLadleGrade.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleGrade.TabIndex = 20;
            this.cmbLadleGrade.TMpEnabled = true;
            this.cmbLadleGrade.ToolTipValid = null;
            this.cmbLadleGrade.ValidEable = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(270, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "开浇时间:";
            // 
            // cmbSkBoardKeep
            // 
            this.cmbSkBoardKeep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSkBoardKeep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSkBoardKeep.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSkBoardKeep.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Sk_Board_Keep", true));
            this.cmbSkBoardKeep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSkBoardKeep.EnableNull = false;
            this.cmbSkBoardKeep.ErropPr = this.errorProvider1;
            this.cmbSkBoardKeep.FormattingEnabled = true;
            this.cmbSkBoardKeep.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.cmbSkBoardKeep.Location = new System.Drawing.Point(568, 121);
            this.cmbSkBoardKeep.Name = "cmbSkBoardKeep";
            this.cmbSkBoardKeep.ReadOnly = false;
            this.cmbSkBoardKeep.Size = new System.Drawing.Size(141, 20);
            this.cmbSkBoardKeep.TabIndex = 18;
            this.cmbSkBoardKeep.TMpEnabled = true;
            this.cmbSkBoardKeep.ToolTipValid = this.toolTip1;
            this.cmbSkBoardKeep.ValidEable = true;
            this.cmbSkBoardKeep.TextChanged += new System.EventHandler(this.pxControls_TextChangedFact);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(258, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "座好包时间:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(568, 256);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.ReadOnly = false;
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 22;
            this.cmbShiftID.TMpEnabled = true;
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
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Location = new System.Drawing.Point(7, 204);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(83, 12);
            this.label48.TabIndex = 26;
            this.label48.Text = "上炉停浇时间:";
            // 
            // cmbOffReason
            // 
            this.cmbOffReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOffReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOffReason.BackColor = System.Drawing.SystemColors.Window;
            this.cmbOffReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Off_Reason", true));
            this.cmbOffReason.EnableNull = true;
            this.cmbOffReason.ErropPr = null;
            this.cmbOffReason.FormattingEnabled = true;
            this.cmbOffReason.Location = new System.Drawing.Point(568, 69);
            this.cmbOffReason.Name = "cmbOffReason";
            this.cmbOffReason.ReadOnly = false;
            this.cmbOffReason.Size = new System.Drawing.Size(141, 20);
            this.cmbOffReason.TabIndex = 17;
            this.cmbOffReason.TMpEnabled = true;
            this.cmbOffReason.ToolTipValid = null;
            this.cmbOffReason.ValidEable = true;
            this.cmbOffReason.SelectedIndexChanged += new System.EventHandler(this.cmbOffReason_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(246, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "上炉下包时间:";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TeamID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(96, 224);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.ReadOnly = false;
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 21;
            this.cmbTeamID.TMpEnabled = true;
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
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Location = new System.Drawing.Point(503, 203);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(59, 12);
            this.label49.TabIndex = 42;
            this.label49.Text = "实际包况:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(55, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "钢种:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(503, 178);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(59, 12);
            this.label26.TabIndex = 42;
            this.label26.Text = "计算包况:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(258, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "到上件时间:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(503, 125);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 43;
            this.label27.Text = "滑板连用:";
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Dump_LadleID", true));
            this.pxTextBox1.DisplayPrecision = 0;
            this.pxTextBox1.EnableNull = true;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.FixedLength = 0;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(568, 95);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxNull = 0;
            this.pxTextBox1.MaxStringLength = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            this.pxTextBox1.MinNull = 0;
            this.pxTextBox1.MinStringLength = 0;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Regex = "";
            this.pxTextBox1.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox1.TabIndex = 23;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.VaildWarning = "";
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // pxTextBox5
            // 
            this.pxTextBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.pxTextBox5.DisplayPrecision = 0;
            this.pxTextBox5.EnableNull = true;
            this.pxTextBox5.ErropPr = null;
            this.pxTextBox5.FixedLength = 0;
            this.pxTextBox5.Length = 0;
            this.pxTextBox5.Location = new System.Drawing.Point(568, 226);
            this.pxTextBox5.Max = 0;
            this.pxTextBox5.MaxNull = 0;
            this.pxTextBox5.MaxStringLength = 0;
            this.pxTextBox5.MaxStrLength = 0;
            this.pxTextBox5.Min = 0;
            this.pxTextBox5.MinNull = 0;
            this.pxTextBox5.MinStringLength = 0;
            this.pxTextBox5.MinStrLength = 0;
            this.pxTextBox5.Name = "pxTextBox5";
            this.pxTextBox5.Precision = 0;
            this.pxTextBox5.Regex = "";
            this.pxTextBox5.Size = new System.Drawing.Size(141, 21);
            this.pxTextBox5.TabIndex = 23;
            this.pxTextBox5.ToolTipValid = null;
            this.pxTextBox5.VaildWarning = "";
            this.pxTextBox5.ValidEable = true;
            this.pxTextBox5.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(527, 260);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 12);
            this.label28.TabIndex = 46;
            this.label28.Text = "班次:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(258, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "上好件时间:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(503, 72);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 12);
            this.label29.TabIndex = 45;
            this.label29.Text = "甩包原因:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(491, 150);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(71, 12);
            this.label33.TabIndex = 23;
            this.label33.Text = "去烘烤时间:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(55, 228);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 12);
            this.label30.TabIndex = 44;
            this.label30.Text = "班别:";
            // 
            // dtTapTime
            // 
            this.dtTapTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTapTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Tap_Time", true));
            this.dtTapTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTapTime.Location = new System.Drawing.Point(335, 123);
            this.dtTapTime.Name = "dtTapTime";
            this.dtTapTime.Size = new System.Drawing.Size(141, 21);
            this.dtTapTime.TabIndex = 12;
            // 
            // cmbBOFID
            // 
            this.cmbBOFID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBOFID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBOFID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBOFID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "BOFID", true));
            this.cmbBOFID.DataSource = this.dsBOFID;
            this.cmbBOFID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBOFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBOFID.EnableNull = true;
            this.cmbBOFID.ErropPr = this.errorProvider1;
            this.cmbBOFID.FormattingEnabled = true;
            this.cmbBOFID.Location = new System.Drawing.Point(96, 95);
            this.cmbBOFID.Name = "cmbBOFID";
            this.cmbBOFID.ReadOnly = false;
            this.cmbBOFID.Size = new System.Drawing.Size(141, 20);
            this.cmbBOFID.TabIndex = 3;
            this.cmbBOFID.TMpEnabled = true;
            this.cmbBOFID.ToolTipValid = this.toolTip1;
            this.cmbBOFID.ValidEable = true;
            this.cmbBOFID.ValueMember = "L3DataTable.Code";
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
            this.dsBOFID.SourceCondition = "Code_Group = \'BOF\' order by Code";
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
            // txtSteelGrade
            // 
            this.txtSteelGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Steel_Grade", true));
            this.txtSteelGrade.DisplayPrecision = 0;
            this.txtSteelGrade.EnableNull = true;
            this.txtSteelGrade.ErropPr = null;
            this.txtSteelGrade.FixedLength = 0;
            this.txtSteelGrade.Length = 0;
            this.txtSteelGrade.Location = new System.Drawing.Point(96, 175);
            this.txtSteelGrade.Max = 0;
            this.txtSteelGrade.MaxNull = 0;
            this.txtSteelGrade.MaxStringLength = 0;
            this.txtSteelGrade.MaxStrLength = 0;
            this.txtSteelGrade.Min = 0;
            this.txtSteelGrade.MinNull = 0;
            this.txtSteelGrade.MinStringLength = 0;
            this.txtSteelGrade.MinStrLength = 0;
            this.txtSteelGrade.Name = "txtSteelGrade";
            this.txtSteelGrade.Precision = 0;
            this.txtSteelGrade.Regex = "";
            this.txtSteelGrade.Size = new System.Drawing.Size(141, 21);
            this.txtSteelGrade.TabIndex = 6;
            this.txtSteelGrade.ToolTipValid = null;
            this.txtSteelGrade.VaildWarning = "";
            this.txtSteelGrade.ValidEable = true;
            this.txtSteelGrade.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleID.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLadleID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "LadleID", true));
            this.cmbLadleID.DataSource = this.dsLadleID;
            this.cmbLadleID.DisplayMember = "L3DataTable.LadleID";
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.EnableNull = false;
            this.cmbLadleID.ErropPr = this.errorProvider1;
            this.cmbLadleID.FormattingEnabled = true;
            this.cmbLadleID.Location = new System.Drawing.Point(96, 70);
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.ReadOnly = false;
            this.cmbLadleID.Size = new System.Drawing.Size(103, 20);
            this.cmbLadleID.TabIndex = 2;
            this.cmbLadleID.TMpEnabled = true;
            this.cmbLadleID.ToolTipValid = this.toolTip1;
            this.cmbLadleID.ValidEable = true;
            this.cmbLadleID.ValueMember = "L3DataTable.LadleID";
            this.cmbLadleID.SelectedIndexChanged += new System.EventHandler(this.cmbLadleID_SelectedIndexChanged);
            // 
            // dtIrrTime
            // 
            this.dtIrrTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtIrrTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Irr_Start_Time", true));
            this.dtIrrTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIrrTime.Location = new System.Drawing.Point(335, 149);
            this.dtIrrTime.Name = "dtIrrTime";
            this.dtIrrTime.Size = new System.Drawing.Size(141, 21);
            this.dtIrrTime.TabIndex = 13;
            // 
            // cmbLadleCheck
            // 
            this.cmbLadleCheck.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleCheck.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleCheck.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLadleCheck.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Ladle_Check", true));
            this.cmbLadleCheck.DataSource = this.dsLadleChcke;
            this.cmbLadleCheck.DisplayMember = "L3DataTable.Code_Des";
            this.cmbLadleCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleCheck.EnableNull = true;
            this.cmbLadleCheck.ErropPr = null;
            this.cmbLadleCheck.FormattingEnabled = true;
            this.cmbLadleCheck.Location = new System.Drawing.Point(568, 18);
            this.cmbLadleCheck.Name = "cmbLadleCheck";
            this.cmbLadleCheck.ReadOnly = false;
            this.cmbLadleCheck.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleCheck.TabIndex = 16;
            this.cmbLadleCheck.TMpEnabled = true;
            this.cmbLadleCheck.ToolTipValid = null;
            this.cmbLadleCheck.ValidEable = true;
            this.cmbLadleCheck.ValueMember = "L3DataTable.Code";
            this.cmbLadleCheck.SelectedIndexChanged += new System.EventHandler(this.cmbLadleCheck_SelectedIndexChanged);
            // 
            // dsLadleChcke
            // 
            this.dsLadleChcke.AutoLoad = true;
            this.dsLadleChcke.AutoSubscribe = false;
            this.dsLadleChcke.DataSetName = "L3DataSet";
            this.dsLadleChcke.DeleteMethod = null;
            this.dsLadleChcke.InsertMethod = null;
            this.dsLadleChcke.L3DataAdapter = this.Adapter;
            this.dsLadleChcke.LoadEvent = "Click";
            this.dsLadleChcke.LoadTrigger = null;
            this.dsLadleChcke.RefreshValve = 1000;
            this.dsLadleChcke.SourceCommand = null;
            this.dsLadleChcke.SourceCondition = "Code_Group = \'LadleChcke\' order by Code";
            this.dsLadleChcke.SourceMethod = "";
            this.dsLadleChcke.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleChcke.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleChcke.SubscribeTarget = null;
            this.dsLadleChcke.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleChcke});
            this.dsLadleChcke.UpdateEvent = "Click";
            this.dsLadleChcke.UpdateMethod = null;
            this.dsLadleChcke.UpdateTrigger = null;
            // 
            // schemadsLadleChcke
            // 
            this.schemadsLadleChcke.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleChckeL3DataTableCode,
            this.coldsLadleChckeL3DataTableCode_Des});
            this.schemadsLadleChcke.TableName = "L3DataTable";
            // 
            // coldsLadleChckeL3DataTableCode
            // 
            this.coldsLadleChckeL3DataTableCode.Caption = "Code";
            this.coldsLadleChckeL3DataTableCode.ColumnName = "Code";
            this.coldsLadleChckeL3DataTableCode.Namespace = "";
            // 
            // coldsLadleChckeL3DataTableCode_Des
            // 
            this.coldsLadleChckeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleChckeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleChckeL3DataTableCode_Des.Namespace = "";
            // 
            // dtIrrEndTime
            // 
            this.dtIrrEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtIrrEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Irr_End_Time", true));
            this.dtIrrEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIrrEndTime.Location = new System.Drawing.Point(96, 200);
            this.dtIrrEndTime.Name = "dtIrrEndTime";
            this.dtIrrEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtIrrEndTime.TabIndex = 7;
            // 
            // txtBOFID
            // 
            this.txtBOFID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "HeatID", true));
            this.txtBOFID.DisplayPrecision = 0;
            this.txtBOFID.EnableNull = true;
            this.txtBOFID.ErropPr = this.errorProvider1;
            this.txtBOFID.FixedLength = 9;
            this.txtBOFID.Length = 9;
            this.txtBOFID.Location = new System.Drawing.Point(96, 149);
            this.txtBOFID.Max = 0;
            this.txtBOFID.MaxLength = 9;
            this.txtBOFID.MaxNull = 0;
            this.txtBOFID.MaxStringLength = 0;
            this.txtBOFID.MaxStrLength = 0;
            this.txtBOFID.Min = 0;
            this.txtBOFID.MinNull = 0;
            this.txtBOFID.MinStringLength = 0;
            this.txtBOFID.MinStrLength = 0;
            this.txtBOFID.Name = "txtBOFID";
            this.txtBOFID.Precision = 0;
            this.txtBOFID.Regex = "";
            this.txtBOFID.Size = new System.Drawing.Size(141, 21);
            this.txtBOFID.TabIndex = 5;
            this.txtBOFID.ToolTipValid = this.toolTip1;
            this.txtBOFID.VaildWarning = "";
            this.txtBOFID.ValidEable = true;
            this.txtBOFID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // dtSeatOKTime
            // 
            this.dtSeatOKTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtSeatOKTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Seat_OK_Time", true));
            this.dtSeatOKTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSeatOKTime.Location = new System.Drawing.Point(335, 95);
            this.dtSeatOKTime.Name = "dtSeatOKTime";
            this.dtSeatOKTime.Size = new System.Drawing.Size(141, 21);
            this.dtSeatOKTime.TabIndex = 11;
            this.dtSeatOKTime.ValueChanged += new System.EventHandler(this.dtSeatOKTime_ValueChanged);
            // 
            // dtOffLadleTime
            // 
            this.dtOffLadleTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtOffLadleTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Off_Ladle_Time", true));
            this.dtOffLadleTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOffLadleTime.Location = new System.Drawing.Point(335, 18);
            this.dtOffLadleTime.Name = "dtOffLadleTime";
            this.dtOffLadleTime.Size = new System.Drawing.Size(141, 21);
            this.dtOffLadleTime.TabIndex = 8;
            // 
            // txtFireTimeLen
            // 
            this.txtFireTimeLen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Fire_Time_Len", true));
            this.txtFireTimeLen.DisplayPrecision = 0;
            this.txtFireTimeLen.EnableNull = false;
            this.txtFireTimeLen.ErropPr = this.errorProvider1;
            this.txtFireTimeLen.FixedLength = 0;
            this.txtFireTimeLen.Length = 0;
            this.txtFireTimeLen.Location = new System.Drawing.Point(335, 203);
            this.txtFireTimeLen.Max = 999;
            this.txtFireTimeLen.MaxNull = 999;
            this.txtFireTimeLen.MaxStringLength = 0;
            this.txtFireTimeLen.MaxStrLength = 0;
            this.txtFireTimeLen.Min = 0;
            this.txtFireTimeLen.MinNull = 0;
            this.txtFireTimeLen.MinStringLength = 0;
            this.txtFireTimeLen.MinStrLength = 0;
            this.txtFireTimeLen.Name = "txtFireTimeLen";
            this.txtFireTimeLen.Precision = 2;
            this.txtFireTimeLen.Regex = "";
            this.txtFireTimeLen.Size = new System.Drawing.Size(141, 21);
            this.txtFireTimeLen.TabIndex = 14;
            this.txtFireTimeLen.ToolTipValid = this.toolTip1;
            this.txtFireTimeLen.VaildWarning = "";
            this.txtFireTimeLen.ValidEable = true;
            this.txtFireTimeLen.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // dtArriveTime
            // 
            this.dtArriveTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtArriveTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Arrive_Time", true));
            this.dtArriveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArriveTime.Location = new System.Drawing.Point(335, 44);
            this.dtArriveTime.Name = "dtArriveTime";
            this.dtArriveTime.Size = new System.Drawing.Size(141, 21);
            this.dtArriveTime.TabIndex = 9;
            // 
            // txtLadleAge
            // 
            this.txtLadleAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Ladle_Age", true));
            this.txtLadleAge.DisplayPrecision = 0;
            this.txtLadleAge.EnableNull = false;
            this.txtLadleAge.ErropPr = this.errorProvider1;
            this.txtLadleAge.FixedLength = 0;
            this.txtLadleAge.Length = 0;
            this.txtLadleAge.Location = new System.Drawing.Point(96, 123);
            this.txtLadleAge.Max = 9999;
            this.txtLadleAge.MaxNull = 9999;
            this.txtLadleAge.MaxStringLength = 0;
            this.txtLadleAge.MaxStrLength = 0;
            this.txtLadleAge.Min = 0;
            this.txtLadleAge.MinNull = 0;
            this.txtLadleAge.MinStringLength = 0;
            this.txtLadleAge.MinStrLength = 0;
            this.txtLadleAge.Name = "txtLadleAge";
            this.txtLadleAge.Precision = 0;
            this.txtLadleAge.Regex = "";
            this.txtLadleAge.Size = new System.Drawing.Size(141, 21);
            this.txtLadleAge.TabIndex = 4;
            this.txtLadleAge.ToolTipValid = this.toolTip1;
            this.txtLadleAge.VaildWarning = "";
            this.txtLadleAge.ValidEable = true;
            this.txtLadleAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // dtUseDate
            // 
            this.dtUseDate.CustomFormat = "yyyy-MM-dd";
            this.dtUseDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Use_Date", true));
            this.dtUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtUseDate.Location = new System.Drawing.Point(96, 44);
            this.dtUseDate.Name = "dtUseDate";
            this.dtUseDate.Size = new System.Drawing.Size(141, 21);
            this.dtUseDate.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(55, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 32;
            this.label21.Text = "炉号:";
            // 
            // dtCompleteTime
            // 
            this.dtCompleteTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtCompleteTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Complete_Time", true));
            this.dtCompleteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCompleteTime.Location = new System.Drawing.Point(335, 70);
            this.dtCompleteTime.Name = "dtCompleteTime";
            this.dtCompleteTime.Size = new System.Drawing.Size(141, 21);
            this.dtCompleteTime.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(479, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 12);
            this.label22.TabIndex = 36;
            this.label22.Text = "钢包包衬检查:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Hot_Time", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(55, 127);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 33;
            this.label23.Text = "包龄:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(240, 206);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 12);
            this.label25.TabIndex = 34;
            this.label25.Text = "烘烤时间[min]:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(240, 232);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 12);
            this.label24.TabIndex = 35;
            this.label24.Text = "停用时间[min]:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNote);
            this.groupBox2.Controls.Add(this.rtxtNote);
            this.groupBox2.Controls.Add(this.txtRemnantWT);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 124);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "备注";
            // 
            // cmbNote
            // 
            this.cmbNote.DataSource = this.dsLadleNote;
            this.cmbNote.DisplayMember = "L3DataTable.Code_Des";
            this.cmbNote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNote.FormattingEnabled = true;
            this.cmbNote.Location = new System.Drawing.Point(81, 26);
            this.cmbNote.Name = "cmbNote";
            this.cmbNote.Size = new System.Drawing.Size(141, 20);
            this.cmbNote.TabIndex = 34;
            this.cmbNote.ValueMember = "L3DataTable.Code_Des";
            this.cmbNote.SelectedIndexChanged += new System.EventHandler(this.cmbNote_SelectedIndexChanged);
            this.cmbNote.TextChanged += new System.EventHandler(this.pxControls_TextChangedFact);
            // 
            // dsLadleNote
            // 
            this.dsLadleNote.AutoLoad = true;
            this.dsLadleNote.AutoSubscribe = false;
            this.dsLadleNote.DataSetName = "L3DataSet";
            this.dsLadleNote.DeleteMethod = "";
            this.dsLadleNote.InsertMethod = "";
            this.dsLadleNote.L3DataAdapter = this.Adapter;
            this.dsLadleNote.LoadEvent = "";
            this.dsLadleNote.LoadTrigger = null;
            this.dsLadleNote.RefreshValve = 1000;
            this.dsLadleNote.SourceCommand = null;
            this.dsLadleNote.SourceCondition = "code_group = \'LadleNote\' order by Code";
            this.dsLadleNote.SourceMethod = "";
            this.dsLadleNote.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleNote.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleNote.SubscribeTarget = "";
            this.dsLadleNote.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleNote});
            this.dsLadleNote.UpdateEvent = "";
            this.dsLadleNote.UpdateMethod = "";
            this.dsLadleNote.UpdateTrigger = null;
            // 
            // schemadsLadleNote
            // 
            this.schemadsLadleNote.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleNoteL3DataTableCode,
            this.coldsLadleNoteL3DataTableCode_Des});
            this.schemadsLadleNote.TableName = "L3DataTable";
            // 
            // coldsLadleNoteL3DataTableCode
            // 
            this.coldsLadleNoteL3DataTableCode.Caption = "Code";
            this.coldsLadleNoteL3DataTableCode.ColumnName = "Code";
            this.coldsLadleNoteL3DataTableCode.Namespace = "";
            // 
            // coldsLadleNoteL3DataTableCode_Des
            // 
            this.coldsLadleNoteL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLadleNoteL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLadleNoteL3DataTableCode_Des.Namespace = "";
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(3, 52);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(720, 69);
            this.rtxtNote.TabIndex = 8;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // txtRemnantWT
            // 
            this.txtRemnantWT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "RemnantWT", true));
            this.txtRemnantWT.DisplayPrecision = 0;
            this.txtRemnantWT.EnableNull = false;
            this.txtRemnantWT.ErropPr = this.errorProvider1;
            this.txtRemnantWT.FixedLength = 0;
            this.txtRemnantWT.Length = 0;
            this.txtRemnantWT.Location = new System.Drawing.Point(320, 26);
            this.txtRemnantWT.Max = 9999;
            this.txtRemnantWT.MaxNull = 9999;
            this.txtRemnantWT.MaxStringLength = 0;
            this.txtRemnantWT.MaxStrLength = 0;
            this.txtRemnantWT.Min = 0;
            this.txtRemnantWT.MinNull = 0;
            this.txtRemnantWT.MinStringLength = 0;
            this.txtRemnantWT.MinStrLength = 0;
            this.txtRemnantWT.Name = "txtRemnantWT";
            this.txtRemnantWT.Precision = 2;
            this.txtRemnantWT.Regex = "";
            this.txtRemnantWT.Size = new System.Drawing.Size(141, 21);
            this.txtRemnantWT.TabIndex = 7;
            this.txtRemnantWT.ToolTipValid = this.toolTip1;
            this.txtRemnantWT.VaildWarning = "";
            this.txtRemnantWT.ValidEable = true;
            this.txtRemnantWT.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Location = new System.Drawing.Point(24, 30);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(59, 12);
            this.label50.TabIndex = 33;
            this.label50.Text = "选择备注:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(243, 30);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(71, 12);
            this.label31.TabIndex = 33;
            this.label31.Text = "包底重[Kg]:";
            // 
            // gbxAge
            // 
            this.gbxAge.Controls.Add(this.txtProtectBoard);
            this.gbxAge.Controls.Add(this.txtJointSafetyPin);
            this.gbxAge.Controls.Add(this.txtUpTightenMachine);
            this.gbxAge.Controls.Add(this.label44);
            this.gbxAge.Controls.Add(this.label46);
            this.gbxAge.Controls.Add(this.label42);
            this.gbxAge.Controls.Add(this.txtFrame);
            this.gbxAge.Controls.Add(this.txtLongAxes);
            this.gbxAge.Controls.Add(this.label47);
            this.gbxAge.Controls.Add(this.label45);
            this.gbxAge.Controls.Add(this.label36);
            this.gbxAge.Controls.Add(this.label41);
            this.gbxAge.Controls.Add(this.txtSplint);
            this.gbxAge.Controls.Add(this.label40);
            this.gbxAge.Controls.Add(this.label43);
            this.gbxAge.Controls.Add(this.label38);
            this.gbxAge.Controls.Add(this.label39);
            this.gbxAge.Controls.Add(this.txtWaterGap);
            this.gbxAge.Controls.Add(this.label35);
            this.gbxAge.Controls.Add(this.txtBreatheBriLow);
            this.gbxAge.Controls.Add(this.txtShortAxes);
            this.gbxAge.Controls.Add(this.txtBreatheBriUp);
            this.gbxAge.Controls.Add(this.label37);
            this.gbxAge.Controls.Add(this.txtChassis);
            this.gbxAge.Controls.Add(this.txtSpringBox);
            this.gbxAge.Controls.Add(this.txtJoint);
            this.gbxAge.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbxAge.Location = new System.Drawing.Point(729, 3);
            this.gbxAge.Name = "gbxAge";
            this.gbxAge.Size = new System.Drawing.Size(200, 409);
            this.gbxAge.TabIndex = 1;
            this.gbxAge.TabStop = false;
            this.gbxAge.Text = "机件寿命";
            // 
            // txtProtectBoard
            // 
            this.txtProtectBoard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Protect_Board", true));
            this.txtProtectBoard.DisplayPrecision = 0;
            this.txtProtectBoard.EnableNull = false;
            this.txtProtectBoard.ErropPr = this.errorProvider1;
            this.txtProtectBoard.FixedLength = 0;
            this.txtProtectBoard.Length = 0;
            this.txtProtectBoard.Location = new System.Drawing.Point(79, 224);
            this.txtProtectBoard.Max = 9999;
            this.txtProtectBoard.MaxNull = 9999;
            this.txtProtectBoard.MaxStringLength = 0;
            this.txtProtectBoard.MaxStrLength = 0;
            this.txtProtectBoard.Min = 0;
            this.txtProtectBoard.MinNull = 0;
            this.txtProtectBoard.MinStringLength = 0;
            this.txtProtectBoard.MinStrLength = 0;
            this.txtProtectBoard.Name = "txtProtectBoard";
            this.txtProtectBoard.Precision = 0;
            this.txtProtectBoard.Regex = "";
            this.txtProtectBoard.Size = new System.Drawing.Size(100, 21);
            this.txtProtectBoard.TabIndex = 8;
            this.txtProtectBoard.ToolTipValid = this.toolTip1;
            this.txtProtectBoard.VaildWarning = "";
            this.txtProtectBoard.ValidEable = true;
            this.txtProtectBoard.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtJointSafetyPin
            // 
            this.txtJointSafetyPin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Joint_Safety_Pin", true));
            this.txtJointSafetyPin.DisplayPrecision = 0;
            this.txtJointSafetyPin.EnableNull = false;
            this.txtJointSafetyPin.ErropPr = this.errorProvider1;
            this.txtJointSafetyPin.FixedLength = 0;
            this.txtJointSafetyPin.Length = 0;
            this.txtJointSafetyPin.Location = new System.Drawing.Point(79, 120);
            this.txtJointSafetyPin.Max = 9999;
            this.txtJointSafetyPin.MaxNull = 9999;
            this.txtJointSafetyPin.MaxStringLength = 0;
            this.txtJointSafetyPin.MaxStrLength = 0;
            this.txtJointSafetyPin.Min = 0;
            this.txtJointSafetyPin.MinNull = 0;
            this.txtJointSafetyPin.MinStringLength = 0;
            this.txtJointSafetyPin.MinStrLength = 0;
            this.txtJointSafetyPin.Name = "txtJointSafetyPin";
            this.txtJointSafetyPin.Precision = 0;
            this.txtJointSafetyPin.Regex = "";
            this.txtJointSafetyPin.Size = new System.Drawing.Size(100, 21);
            this.txtJointSafetyPin.TabIndex = 4;
            this.txtJointSafetyPin.ToolTipValid = this.toolTip1;
            this.txtJointSafetyPin.VaildWarning = "";
            this.txtJointSafetyPin.ValidEable = true;
            this.txtJointSafetyPin.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtUpTightenMachine
            // 
            this.txtUpTightenMachine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Up_Tighten_Machine", true));
            this.txtUpTightenMachine.DisplayPrecision = 0;
            this.txtUpTightenMachine.EnableNull = false;
            this.txtUpTightenMachine.ErropPr = this.errorProvider1;
            this.txtUpTightenMachine.FixedLength = 0;
            this.txtUpTightenMachine.Length = 0;
            this.txtUpTightenMachine.Location = new System.Drawing.Point(79, 331);
            this.txtUpTightenMachine.Max = 9999;
            this.txtUpTightenMachine.MaxNull = 9999;
            this.txtUpTightenMachine.MaxStringLength = 0;
            this.txtUpTightenMachine.MaxStrLength = 0;
            this.txtUpTightenMachine.Min = 0;
            this.txtUpTightenMachine.MinNull = 0;
            this.txtUpTightenMachine.MinStringLength = 0;
            this.txtUpTightenMachine.MinStrLength = 0;
            this.txtUpTightenMachine.Name = "txtUpTightenMachine";
            this.txtUpTightenMachine.Precision = 0;
            this.txtUpTightenMachine.Regex = "";
            this.txtUpTightenMachine.Size = new System.Drawing.Size(100, 21);
            this.txtUpTightenMachine.TabIndex = 12;
            this.txtUpTightenMachine.ToolTipValid = this.toolTip1;
            this.txtUpTightenMachine.VaildWarning = "";
            this.txtUpTightenMachine.ValidEable = true;
            this.txtUpTightenMachine.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(26, 335);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(47, 12);
            this.label44.TabIndex = 53;
            this.label44.Text = "顶紧器:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(38, 227);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 53;
            this.label46.Text = "护板:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(2, 123);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 12);
            this.label42.TabIndex = 53;
            this.label42.Text = "关节保险销:";
            // 
            // txtFrame
            // 
            this.txtFrame.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Frame", true));
            this.txtFrame.DisplayPrecision = 0;
            this.txtFrame.EnableNull = false;
            this.txtFrame.ErropPr = this.errorProvider1;
            this.txtFrame.FixedLength = 0;
            this.txtFrame.Length = 0;
            this.txtFrame.Location = new System.Drawing.Point(79, 16);
            this.txtFrame.Max = 9999;
            this.txtFrame.MaxNull = 9999;
            this.txtFrame.MaxStringLength = 0;
            this.txtFrame.MaxStrLength = 0;
            this.txtFrame.Min = 0;
            this.txtFrame.MinNull = 0;
            this.txtFrame.MinStringLength = 0;
            this.txtFrame.MinStrLength = 0;
            this.txtFrame.Name = "txtFrame";
            this.txtFrame.Precision = 0;
            this.txtFrame.Regex = "";
            this.txtFrame.Size = new System.Drawing.Size(100, 21);
            this.txtFrame.TabIndex = 0;
            this.txtFrame.ToolTipValid = this.toolTip1;
            this.txtFrame.VaildWarning = "";
            this.txtFrame.ValidEable = true;
            this.txtFrame.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLongAxes
            // 
            this.txtLongAxes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Long_Axes", true));
            this.txtLongAxes.DisplayPrecision = 0;
            this.txtLongAxes.EnableNull = false;
            this.txtLongAxes.ErropPr = this.errorProvider1;
            this.txtLongAxes.FixedLength = 0;
            this.txtLongAxes.Length = 0;
            this.txtLongAxes.Location = new System.Drawing.Point(79, 146);
            this.txtLongAxes.Max = 9999;
            this.txtLongAxes.MaxNull = 9999;
            this.txtLongAxes.MaxStringLength = 0;
            this.txtLongAxes.MaxStrLength = 0;
            this.txtLongAxes.Min = 0;
            this.txtLongAxes.MinNull = 0;
            this.txtLongAxes.MinStringLength = 0;
            this.txtLongAxes.MinStrLength = 0;
            this.txtLongAxes.Name = "txtLongAxes";
            this.txtLongAxes.Precision = 0;
            this.txtLongAxes.Regex = "";
            this.txtLongAxes.Size = new System.Drawing.Size(100, 21);
            this.txtLongAxes.TabIndex = 5;
            this.txtLongAxes.ToolTipValid = this.toolTip1;
            this.txtLongAxes.VaildWarning = "";
            this.txtLongAxes.ValidEable = true;
            this.txtLongAxes.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(14, 307);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(59, 12);
            this.label47.TabIndex = 53;
            this.label47.Text = "透气砖下:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(14, 280);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(59, 12);
            this.label45.TabIndex = 53;
            this.label45.Text = "透气砖上:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(38, 19);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(35, 12);
            this.label36.TabIndex = 53;
            this.label36.Text = "框架:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(38, 201);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(35, 12);
            this.label41.TabIndex = 53;
            this.label41.Text = "底盘:";
            // 
            // txtSplint
            // 
            this.txtSplint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Splint", true));
            this.txtSplint.DisplayPrecision = 0;
            this.txtSplint.EnableNull = false;
            this.txtSplint.ErropPr = this.errorProvider1;
            this.txtSplint.FixedLength = 0;
            this.txtSplint.Length = 0;
            this.txtSplint.Location = new System.Drawing.Point(79, 42);
            this.txtSplint.Max = 9999;
            this.txtSplint.MaxNull = 9999;
            this.txtSplint.MaxStringLength = 0;
            this.txtSplint.MaxStrLength = 0;
            this.txtSplint.Min = 0;
            this.txtSplint.MinNull = 0;
            this.txtSplint.MinStringLength = 0;
            this.txtSplint.MinStrLength = 0;
            this.txtSplint.Name = "txtSplint";
            this.txtSplint.Precision = 0;
            this.txtSplint.Regex = "";
            this.txtSplint.Size = new System.Drawing.Size(100, 21);
            this.txtSplint.TabIndex = 1;
            this.txtSplint.ToolTipValid = this.toolTip1;
            this.txtSplint.VaildWarning = "";
            this.txtSplint.ValidEable = true;
            this.txtSplint.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(38, 149);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 12);
            this.label40.TabIndex = 53;
            this.label40.Text = "长轴:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(26, 254);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(47, 12);
            this.label43.TabIndex = 53;
            this.label43.Text = "上水口:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(38, 97);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 12);
            this.label38.TabIndex = 53;
            this.label38.Text = "关节:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(38, 175);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(35, 12);
            this.label39.TabIndex = 53;
            this.label39.Text = "短轴:";
            // 
            // txtWaterGap
            // 
            this.txtWaterGap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_Gap", true));
            this.txtWaterGap.DisplayPrecision = 0;
            this.txtWaterGap.EnableNull = false;
            this.txtWaterGap.ErropPr = this.errorProvider1;
            this.txtWaterGap.FixedLength = 0;
            this.txtWaterGap.Length = 0;
            this.txtWaterGap.Location = new System.Drawing.Point(79, 251);
            this.txtWaterGap.Max = 9999;
            this.txtWaterGap.MaxNull = 9999;
            this.txtWaterGap.MaxStringLength = 0;
            this.txtWaterGap.MaxStrLength = 0;
            this.txtWaterGap.Min = 0;
            this.txtWaterGap.MinNull = 0;
            this.txtWaterGap.MinStringLength = 0;
            this.txtWaterGap.MinStrLength = 0;
            this.txtWaterGap.Name = "txtWaterGap";
            this.txtWaterGap.Precision = 0;
            this.txtWaterGap.Regex = "";
            this.txtWaterGap.Size = new System.Drawing.Size(100, 21);
            this.txtWaterGap.TabIndex = 9;
            this.txtWaterGap.ToolTipValid = this.toolTip1;
            this.txtWaterGap.VaildWarning = "";
            this.txtWaterGap.ValidEable = true;
            this.txtWaterGap.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(38, 45);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(35, 12);
            this.label35.TabIndex = 53;
            this.label35.Text = "托板:";
            // 
            // txtBreatheBriLow
            // 
            this.txtBreatheBriLow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Low", true));
            this.txtBreatheBriLow.DisplayPrecision = 0;
            this.txtBreatheBriLow.EnableNull = false;
            this.txtBreatheBriLow.ErropPr = this.errorProvider1;
            this.txtBreatheBriLow.FixedLength = 0;
            this.txtBreatheBriLow.Length = 0;
            this.txtBreatheBriLow.Location = new System.Drawing.Point(79, 304);
            this.txtBreatheBriLow.Max = 9999;
            this.txtBreatheBriLow.MaxNull = 9999;
            this.txtBreatheBriLow.MaxStringLength = 0;
            this.txtBreatheBriLow.MaxStrLength = 0;
            this.txtBreatheBriLow.Min = 0;
            this.txtBreatheBriLow.MinNull = 0;
            this.txtBreatheBriLow.MinStringLength = 0;
            this.txtBreatheBriLow.MinStrLength = 0;
            this.txtBreatheBriLow.Name = "txtBreatheBriLow";
            this.txtBreatheBriLow.Precision = 0;
            this.txtBreatheBriLow.Regex = "";
            this.txtBreatheBriLow.Size = new System.Drawing.Size(100, 21);
            this.txtBreatheBriLow.TabIndex = 11;
            this.txtBreatheBriLow.ToolTipValid = this.toolTip1;
            this.txtBreatheBriLow.VaildWarning = "";
            this.txtBreatheBriLow.ValidEable = true;
            this.txtBreatheBriLow.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtShortAxes
            // 
            this.txtShortAxes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Short_Axes", true));
            this.txtShortAxes.DisplayPrecision = 0;
            this.txtShortAxes.EnableNull = false;
            this.txtShortAxes.ErropPr = this.errorProvider1;
            this.txtShortAxes.FixedLength = 0;
            this.txtShortAxes.Length = 0;
            this.txtShortAxes.Location = new System.Drawing.Point(79, 172);
            this.txtShortAxes.Max = 9999;
            this.txtShortAxes.MaxNull = 9999;
            this.txtShortAxes.MaxStringLength = 0;
            this.txtShortAxes.MaxStrLength = 0;
            this.txtShortAxes.Min = 0;
            this.txtShortAxes.MinNull = 0;
            this.txtShortAxes.MinStringLength = 0;
            this.txtShortAxes.MinStrLength = 0;
            this.txtShortAxes.Name = "txtShortAxes";
            this.txtShortAxes.Precision = 0;
            this.txtShortAxes.Regex = "";
            this.txtShortAxes.Size = new System.Drawing.Size(100, 21);
            this.txtShortAxes.TabIndex = 6;
            this.txtShortAxes.ToolTipValid = this.toolTip1;
            this.txtShortAxes.VaildWarning = "";
            this.txtShortAxes.ValidEable = true;
            this.txtShortAxes.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtBreatheBriUp
            // 
            this.txtBreatheBriUp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Up", true));
            this.txtBreatheBriUp.DisplayPrecision = 0;
            this.txtBreatheBriUp.EnableNull = false;
            this.txtBreatheBriUp.ErropPr = this.errorProvider1;
            this.txtBreatheBriUp.FixedLength = 0;
            this.txtBreatheBriUp.Length = 0;
            this.txtBreatheBriUp.Location = new System.Drawing.Point(79, 277);
            this.txtBreatheBriUp.Max = 9999;
            this.txtBreatheBriUp.MaxNull = 9999;
            this.txtBreatheBriUp.MaxStringLength = 0;
            this.txtBreatheBriUp.MaxStrLength = 0;
            this.txtBreatheBriUp.Min = 0;
            this.txtBreatheBriUp.MinNull = 0;
            this.txtBreatheBriUp.MinStringLength = 0;
            this.txtBreatheBriUp.MinStrLength = 0;
            this.txtBreatheBriUp.Name = "txtBreatheBriUp";
            this.txtBreatheBriUp.Precision = 0;
            this.txtBreatheBriUp.Regex = "";
            this.txtBreatheBriUp.Size = new System.Drawing.Size(100, 21);
            this.txtBreatheBriUp.TabIndex = 10;
            this.txtBreatheBriUp.ToolTipValid = this.toolTip1;
            this.txtBreatheBriUp.VaildWarning = "";
            this.txtBreatheBriUp.ValidEable = true;
            this.txtBreatheBriUp.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(38, 71);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(35, 12);
            this.label37.TabIndex = 53;
            this.label37.Text = "簧盒:";
            // 
            // txtChassis
            // 
            this.txtChassis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Chassis", true));
            this.txtChassis.DisplayPrecision = 0;
            this.txtChassis.EnableNull = false;
            this.txtChassis.ErropPr = this.errorProvider1;
            this.txtChassis.FixedLength = 0;
            this.txtChassis.Length = 0;
            this.txtChassis.Location = new System.Drawing.Point(79, 198);
            this.txtChassis.Max = 9999;
            this.txtChassis.MaxNull = 9999;
            this.txtChassis.MaxStringLength = 0;
            this.txtChassis.MaxStrLength = 0;
            this.txtChassis.Min = 0;
            this.txtChassis.MinNull = 0;
            this.txtChassis.MinStringLength = 0;
            this.txtChassis.MinStrLength = 0;
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Precision = 0;
            this.txtChassis.Regex = "";
            this.txtChassis.Size = new System.Drawing.Size(100, 21);
            this.txtChassis.TabIndex = 7;
            this.txtChassis.ToolTipValid = this.toolTip1;
            this.txtChassis.VaildWarning = "";
            this.txtChassis.ValidEable = true;
            this.txtChassis.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtSpringBox
            // 
            this.txtSpringBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "SpringBox", true));
            this.txtSpringBox.DisplayPrecision = 0;
            this.txtSpringBox.EnableNull = false;
            this.txtSpringBox.ErropPr = this.errorProvider1;
            this.txtSpringBox.FixedLength = 0;
            this.txtSpringBox.Length = 0;
            this.txtSpringBox.Location = new System.Drawing.Point(79, 68);
            this.txtSpringBox.Max = 9999;
            this.txtSpringBox.MaxNull = 9999;
            this.txtSpringBox.MaxStringLength = 0;
            this.txtSpringBox.MaxStrLength = 0;
            this.txtSpringBox.Min = 0;
            this.txtSpringBox.MinNull = 0;
            this.txtSpringBox.MinStringLength = 0;
            this.txtSpringBox.MinStrLength = 0;
            this.txtSpringBox.Name = "txtSpringBox";
            this.txtSpringBox.Precision = 0;
            this.txtSpringBox.Regex = "";
            this.txtSpringBox.Size = new System.Drawing.Size(100, 21);
            this.txtSpringBox.TabIndex = 2;
            this.txtSpringBox.ToolTipValid = this.toolTip1;
            this.txtSpringBox.VaildWarning = "";
            this.txtSpringBox.ValidEable = true;
            this.txtSpringBox.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtJoint
            // 
            this.txtJoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Joint", true));
            this.txtJoint.DisplayPrecision = 0;
            this.txtJoint.EnableNull = false;
            this.txtJoint.ErropPr = this.errorProvider1;
            this.txtJoint.FixedLength = 0;
            this.txtJoint.Length = 0;
            this.txtJoint.Location = new System.Drawing.Point(79, 94);
            this.txtJoint.Max = 9999;
            this.txtJoint.MaxNull = 9999;
            this.txtJoint.MaxStringLength = 0;
            this.txtJoint.MaxStrLength = 0;
            this.txtJoint.Min = 0;
            this.txtJoint.MinNull = 0;
            this.txtJoint.MinStringLength = 0;
            this.txtJoint.MinStrLength = 0;
            this.txtJoint.Name = "txtJoint";
            this.txtJoint.Precision = 0;
            this.txtJoint.Regex = "";
            this.txtJoint.Size = new System.Drawing.Size(100, 21);
            this.txtJoint.TabIndex = 3;
            this.txtJoint.ToolTipValid = this.toolTip1;
            this.txtJoint.VaildWarning = "";
            this.txtJoint.ValidEable = true;
            this.txtJoint.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // dsLadleGrade
            // 
            this.dsLadleGrade.AutoLoad = true;
            this.dsLadleGrade.AutoSubscribe = false;
            this.dsLadleGrade.DataSetName = "L3DataSet";
            this.dsLadleGrade.DeleteMethod = null;
            this.dsLadleGrade.InsertMethod = null;
            this.dsLadleGrade.L3DataAdapter = this.Adapter;
            this.dsLadleGrade.LoadEvent = "Click";
            this.dsLadleGrade.LoadTrigger = null;
            this.dsLadleGrade.RefreshValve = 1000;
            this.dsLadleGrade.SourceCommand = null;
            this.dsLadleGrade.SourceCondition = "Code_Group = \'LadleGrade\' order by Code";
            this.dsLadleGrade.SourceMethod = "";
            this.dsLadleGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleGrade.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleGrade.SubscribeTarget = null;
            this.dsLadleGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleGrade});
            this.dsLadleGrade.UpdateEvent = "Click";
            this.dsLadleGrade.UpdateMethod = null;
            this.dsLadleGrade.UpdateTrigger = null;
            // 
            // schemadsLadleGrade
            // 
            this.schemadsLadleGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleGradeL3DataTableCode});
            this.schemadsLadleGrade.TableName = "L3DataTable";
            // 
            // coldsLadleGradeL3DataTableCode
            // 
            this.coldsLadleGradeL3DataTableCode.Caption = "Code";
            this.coldsLadleGradeL3DataTableCode.ColumnName = "Code";
            this.coldsLadleGradeL3DataTableCode.Namespace = "";
            // 
            // dsGetTime
            // 
            this.dsGetTime.AutoLoad = true;
            this.dsGetTime.AutoSubscribe = false;
            this.dsGetTime.DataSetName = "L3DataSet";
            this.dsGetTime.DeleteMethod = "";
            this.dsGetTime.InsertMethod = "";
            this.dsGetTime.L3DataAdapter = null;
            this.dsGetTime.LoadEvent = "Click";
            this.dsGetTime.LoadTrigger = null;
            this.dsGetTime.RefreshValve = 1000;
            this.dsGetTime.SourceCommand = this.cmdGetTime;
            this.dsGetTime.SourceCondition = null;
            this.dsGetTime.SourceMethod = "GetIrrEndTime";
            this.dsGetTime.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsGetTime.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Mag\\Ladle_Mag";
            this.dsGetTime.SubscribeTarget = null;
            this.dsGetTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGetTime});
            this.dsGetTime.UpdateEvent = "Click";
            this.dsGetTime.UpdateMethod = "";
            this.dsGetTime.UpdateTrigger = null;
            // 
            // cmdGetTime
            // 
            this.cmdGetTime.Adapter = null;
            this.cmdGetTime.MergeReturnTarget = false;
            this.cmdGetTime.Method = null;
            this.cmdGetTime.Object = null;
            this.cmdGetTime.Parameters.Add(this.l3cmdpGetTime);
            this.cmdGetTime.ReturnTarget = null;
            this.cmdGetTime.ReturnTargetProperty = null;
            this.cmdGetTime.Trigger = null;
            this.cmdGetTime.TriggerEvent = "Click";
            // 
            // l3cmdpGetTime
            // 
            this.l3cmdpGetTime.AcceptAfterExecuted = false;
            this.l3cmdpGetTime.ConstantValue = null;
            this.l3cmdpGetTime.MergeTarget = false;
            this.l3cmdpGetTime.SourceFilter = null;
            this.l3cmdpGetTime.SourceObject = null;
            this.l3cmdpGetTime.SourceProperty = null;
            this.l3cmdpGetTime.TargetObject = null;
            this.l3cmdpGetTime.TargetProperty = null;
            // 
            // schemadsGetTime
            // 
            this.schemadsGetTime.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGetTimeL3DataTableGUID,
            this.coldsGetTimeL3DataTableNAME,
            this.coldsGetTimeL3DataTableHEATID,
            this.coldsGetTimeL3DataTableTREATNO,
            this.coldsGetTimeL3DataTableCCMID,
            this.coldsGetTimeL3DataTableLADLEID,
            this.coldsGetTimeL3DataTableWEIGHT,
            this.coldsGetTimeL3DataTableREMAINWEIGHT,
            this.coldsGetTimeL3DataTableARRIVAL_TIME,
            this.coldsGetTimeL3DataTableLADLETYPE,
            this.coldsGetTimeL3DataTableDEPARTURE_TIME,
            this.coldsGetTimeL3DataTableCASTING_START_TIME,
            this.coldsGetTimeL3DataTableCASTING_STOP_TIME,
            this.coldsGetTimeL3DataTableHOLDTIME,
            this.coldsGetTimeL3DataTableTEMP,
            this.coldsGetTimeL3DataTableTEMPUPTO,
            this.coldsGetTimeL3DataTableHOLDTIME_REASON,
            this.coldsGetTimeL3DataTablePROTECTION,
            this.coldsGetTimeL3DataTableUNPROTECTION_REASON});
            this.schemadsGetTime.TableName = "L3DataTable";
            // 
            // coldsGetTimeL3DataTableGUID
            // 
            this.coldsGetTimeL3DataTableGUID.Caption = "GUID";
            this.coldsGetTimeL3DataTableGUID.ColumnName = "GUID";
            this.coldsGetTimeL3DataTableGUID.DefaultValue = "";
            this.coldsGetTimeL3DataTableGUID.Namespace = "";
            // 
            // coldsGetTimeL3DataTableNAME
            // 
            this.coldsGetTimeL3DataTableNAME.Caption = "NAME";
            this.coldsGetTimeL3DataTableNAME.ColumnName = "NAME";
            this.coldsGetTimeL3DataTableNAME.DefaultValue = "";
            this.coldsGetTimeL3DataTableNAME.Namespace = "";
            // 
            // coldsGetTimeL3DataTableHEATID
            // 
            this.coldsGetTimeL3DataTableHEATID.Caption = "HEATID";
            this.coldsGetTimeL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsGetTimeL3DataTableHEATID.DefaultValue = "";
            this.coldsGetTimeL3DataTableHEATID.Namespace = "";
            // 
            // coldsGetTimeL3DataTableTREATNO
            // 
            this.coldsGetTimeL3DataTableTREATNO.Caption = "TREATNO";
            this.coldsGetTimeL3DataTableTREATNO.ColumnName = "TREATNO";
            this.coldsGetTimeL3DataTableTREATNO.DefaultValue = "";
            this.coldsGetTimeL3DataTableTREATNO.Namespace = "";
            // 
            // coldsGetTimeL3DataTableCCMID
            // 
            this.coldsGetTimeL3DataTableCCMID.Caption = "CCMID";
            this.coldsGetTimeL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsGetTimeL3DataTableCCMID.DefaultValue = "";
            this.coldsGetTimeL3DataTableCCMID.Namespace = "";
            // 
            // coldsGetTimeL3DataTableLADLEID
            // 
            this.coldsGetTimeL3DataTableLADLEID.Caption = "LADLEID";
            this.coldsGetTimeL3DataTableLADLEID.ColumnName = "LADLEID";
            this.coldsGetTimeL3DataTableLADLEID.DefaultValue = "";
            this.coldsGetTimeL3DataTableLADLEID.Namespace = "";
            // 
            // coldsGetTimeL3DataTableWEIGHT
            // 
            this.coldsGetTimeL3DataTableWEIGHT.Caption = "WEIGHT";
            this.coldsGetTimeL3DataTableWEIGHT.ColumnName = "WEIGHT";
            this.coldsGetTimeL3DataTableWEIGHT.DataType = typeof(double);
            this.coldsGetTimeL3DataTableWEIGHT.DefaultValue = 0;
            this.coldsGetTimeL3DataTableWEIGHT.Namespace = "";
            // 
            // coldsGetTimeL3DataTableREMAINWEIGHT
            // 
            this.coldsGetTimeL3DataTableREMAINWEIGHT.Caption = "REMAINWEIGHT";
            this.coldsGetTimeL3DataTableREMAINWEIGHT.ColumnName = "REMAINWEIGHT";
            this.coldsGetTimeL3DataTableREMAINWEIGHT.DataType = typeof(double);
            this.coldsGetTimeL3DataTableREMAINWEIGHT.DefaultValue = 0;
            this.coldsGetTimeL3DataTableREMAINWEIGHT.Namespace = "";
            // 
            // coldsGetTimeL3DataTableARRIVAL_TIME
            // 
            this.coldsGetTimeL3DataTableARRIVAL_TIME.Caption = "ARRIVAL_TIME";
            this.coldsGetTimeL3DataTableARRIVAL_TIME.ColumnName = "ARRIVAL_TIME";
            this.coldsGetTimeL3DataTableARRIVAL_TIME.DataType = typeof(System.DateTime);
            this.coldsGetTimeL3DataTableARRIVAL_TIME.Namespace = "";
            // 
            // coldsGetTimeL3DataTableLADLETYPE
            // 
            this.coldsGetTimeL3DataTableLADLETYPE.Caption = "LADLETYPE";
            this.coldsGetTimeL3DataTableLADLETYPE.ColumnName = "LADLETYPE";
            this.coldsGetTimeL3DataTableLADLETYPE.DefaultValue = "";
            this.coldsGetTimeL3DataTableLADLETYPE.Namespace = "";
            // 
            // coldsGetTimeL3DataTableDEPARTURE_TIME
            // 
            this.coldsGetTimeL3DataTableDEPARTURE_TIME.Caption = "DEPARTURE_TIME";
            this.coldsGetTimeL3DataTableDEPARTURE_TIME.ColumnName = "DEPARTURE_TIME";
            this.coldsGetTimeL3DataTableDEPARTURE_TIME.DataType = typeof(System.DateTime);
            this.coldsGetTimeL3DataTableDEPARTURE_TIME.Namespace = "";
            // 
            // coldsGetTimeL3DataTableCASTING_START_TIME
            // 
            this.coldsGetTimeL3DataTableCASTING_START_TIME.Caption = "CASTING_START_TIME";
            this.coldsGetTimeL3DataTableCASTING_START_TIME.ColumnName = "CASTING_START_TIME";
            this.coldsGetTimeL3DataTableCASTING_START_TIME.DataType = typeof(System.DateTime);
            this.coldsGetTimeL3DataTableCASTING_START_TIME.Namespace = "";
            // 
            // coldsGetTimeL3DataTableCASTING_STOP_TIME
            // 
            this.coldsGetTimeL3DataTableCASTING_STOP_TIME.Caption = "CASTING_STOP_TIME";
            this.coldsGetTimeL3DataTableCASTING_STOP_TIME.ColumnName = "CASTING_STOP_TIME";
            this.coldsGetTimeL3DataTableCASTING_STOP_TIME.DataType = typeof(System.DateTime);
            this.coldsGetTimeL3DataTableCASTING_STOP_TIME.Namespace = "";
            // 
            // coldsGetTimeL3DataTableHOLDTIME
            // 
            this.coldsGetTimeL3DataTableHOLDTIME.Caption = "HOLDTIME";
            this.coldsGetTimeL3DataTableHOLDTIME.ColumnName = "HOLDTIME";
            this.coldsGetTimeL3DataTableHOLDTIME.DataType = typeof(int);
            this.coldsGetTimeL3DataTableHOLDTIME.DefaultValue = 0;
            this.coldsGetTimeL3DataTableHOLDTIME.Namespace = "";
            // 
            // coldsGetTimeL3DataTableTEMP
            // 
            this.coldsGetTimeL3DataTableTEMP.Caption = "TEMP";
            this.coldsGetTimeL3DataTableTEMP.ColumnName = "TEMP";
            this.coldsGetTimeL3DataTableTEMP.DataType = typeof(int);
            this.coldsGetTimeL3DataTableTEMP.DefaultValue = 0;
            this.coldsGetTimeL3DataTableTEMP.Namespace = "";
            // 
            // coldsGetTimeL3DataTableTEMPUPTO
            // 
            this.coldsGetTimeL3DataTableTEMPUPTO.Caption = "TEMPUPTO";
            this.coldsGetTimeL3DataTableTEMPUPTO.ColumnName = "TEMPUPTO";
            this.coldsGetTimeL3DataTableTEMPUPTO.DataType = typeof(int);
            this.coldsGetTimeL3DataTableTEMPUPTO.DefaultValue = 0;
            this.coldsGetTimeL3DataTableTEMPUPTO.Namespace = "";
            // 
            // coldsGetTimeL3DataTableHOLDTIME_REASON
            // 
            this.coldsGetTimeL3DataTableHOLDTIME_REASON.Caption = "HOLDTIME_REASON";
            this.coldsGetTimeL3DataTableHOLDTIME_REASON.ColumnName = "HOLDTIME_REASON";
            this.coldsGetTimeL3DataTableHOLDTIME_REASON.DefaultValue = "";
            this.coldsGetTimeL3DataTableHOLDTIME_REASON.Namespace = "";
            // 
            // coldsGetTimeL3DataTablePROTECTION
            // 
            this.coldsGetTimeL3DataTablePROTECTION.Caption = "PROTECTION";
            this.coldsGetTimeL3DataTablePROTECTION.ColumnName = "PROTECTION";
            this.coldsGetTimeL3DataTablePROTECTION.DataType = typeof(int);
            this.coldsGetTimeL3DataTablePROTECTION.DefaultValue = 0;
            this.coldsGetTimeL3DataTablePROTECTION.Namespace = "";
            // 
            // coldsGetTimeL3DataTableUNPROTECTION_REASON
            // 
            this.coldsGetTimeL3DataTableUNPROTECTION_REASON.Caption = "UNPROTECTION_REASON";
            this.coldsGetTimeL3DataTableUNPROTECTION_REASON.ColumnName = "UNPROTECTION_REASON";
            this.coldsGetTimeL3DataTableUNPROTECTION_REASON.DefaultValue = "";
            this.coldsGetTimeL3DataTableUNPROTECTION_REASON.Namespace = "";
            // 
            // dsComLadleThrow
            // 
            this.dsComLadleThrow.AutoLoad = true;
            this.dsComLadleThrow.AutoSubscribe = false;
            this.dsComLadleThrow.DataSetName = "L3DataSet";
            this.dsComLadleThrow.DeleteMethod = null;
            this.dsComLadleThrow.InsertMethod = null;
            this.dsComLadleThrow.L3DataAdapter = this.Adapter;
            this.dsComLadleThrow.LoadEvent = "Click";
            this.dsComLadleThrow.LoadTrigger = null;
            this.dsComLadleThrow.RefreshValve = 1000;
            this.dsComLadleThrow.SourceCommand = null;
            this.dsComLadleThrow.SourceCondition = " Code_Group = \'ComLadleThrow\' order by Code_Val_Long";
            this.dsComLadleThrow.SourceMethod = "";
            this.dsComLadleThrow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsComLadleThrow.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsComLadleThrow.SubscribeTarget = null;
            this.dsComLadleThrow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsComLadleThrow});
            this.dsComLadleThrow.UpdateEvent = "Click";
            this.dsComLadleThrow.UpdateMethod = null;
            this.dsComLadleThrow.UpdateTrigger = null;
            // 
            // schemadsComLadleThrow
            // 
            this.schemadsComLadleThrow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsComLadleThrowL3DataTableCode,
            this.coldsComLadleThrowL3DataTableCode_Des});
            this.schemadsComLadleThrow.TableName = "L3DataTable";
            // 
            // coldsComLadleThrowL3DataTableCode
            // 
            this.coldsComLadleThrowL3DataTableCode.Caption = "Code";
            this.coldsComLadleThrowL3DataTableCode.ColumnName = "Code";
            this.coldsComLadleThrowL3DataTableCode.Namespace = "";
            // 
            // coldsComLadleThrowL3DataTableCode_Des
            // 
            this.coldsComLadleThrowL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsComLadleThrowL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsComLadleThrowL3DataTableCode_Des.Namespace = "";
            // 
            // dsFinLadleThrow
            // 
            this.dsFinLadleThrow.AutoLoad = true;
            this.dsFinLadleThrow.AutoSubscribe = false;
            this.dsFinLadleThrow.DataSetName = "L3DataSet";
            this.dsFinLadleThrow.DeleteMethod = null;
            this.dsFinLadleThrow.InsertMethod = null;
            this.dsFinLadleThrow.L3DataAdapter = this.Adapter;
            this.dsFinLadleThrow.LoadEvent = "Click";
            this.dsFinLadleThrow.LoadTrigger = null;
            this.dsFinLadleThrow.RefreshValve = 1000;
            this.dsFinLadleThrow.SourceCommand = null;
            this.dsFinLadleThrow.SourceCondition = " Code_Group = \'FinLadleThrow\' order by Code_Val_Long";
            this.dsFinLadleThrow.SourceMethod = "";
            this.dsFinLadleThrow.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFinLadleThrow.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsFinLadleThrow.SubscribeTarget = null;
            this.dsFinLadleThrow.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFinLadleThrow});
            this.dsFinLadleThrow.UpdateEvent = "Click";
            this.dsFinLadleThrow.UpdateMethod = null;
            this.dsFinLadleThrow.UpdateTrigger = null;
            // 
            // schemadsFinLadleThrow
            // 
            this.schemadsFinLadleThrow.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFinLadleThrowL3DataTableCode,
            this.coldsFinLadleThrowL3DataTableCode_Des});
            this.schemadsFinLadleThrow.TableName = "L3DataTable";
            // 
            // coldsFinLadleThrowL3DataTableCode
            // 
            this.coldsFinLadleThrowL3DataTableCode.Caption = "Code";
            this.coldsFinLadleThrowL3DataTableCode.ColumnName = "Code";
            this.coldsFinLadleThrowL3DataTableCode.Namespace = "";
            // 
            // coldsFinLadleThrowL3DataTableCode_Des
            // 
            this.coldsFinLadleThrowL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFinLadleThrowL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFinLadleThrowL3DataTableCode_Des.Namespace = "";
            // 
            // coldsMainL3DataTableAct_Ladle_Grade
            // 
            this.coldsMainL3DataTableAct_Ladle_Grade.Caption = "Act_Ladle_Grade";
            this.coldsMainL3DataTableAct_Ladle_Grade.ColumnName = "Act_Ladle_Grade";
            this.coldsMainL3DataTableAct_Ladle_Grade.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Check1
            // 
            this.coldsMainL3DataTableLadle_Check1.Caption = "Ladle_Check1";
            this.coldsMainL3DataTableLadle_Check1.ColumnName = "Ladle_Check1";
            this.coldsMainL3DataTableLadle_Check1.Namespace = "";
            // 
            // coldsMainL3DataTableAuto_Flow
            // 
            this.coldsMainL3DataTableAuto_Flow.Caption = "Auto_Flow";
            this.coldsMainL3DataTableAuto_Flow.ColumnName = "Auto_Flow";
            this.coldsMainL3DataTableAuto_Flow.DataType = typeof(short);
            this.coldsMainL3DataTableAuto_Flow.Namespace = "";
            // 
            // LadleUseMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 491);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LadleUseMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "钢包使用实绩绩维护界面";
            this.Load += new System.EventHandler(this.LadleUseMagShowFrm_Load);
            this.TextChanged += new System.EventHandler(this.pxControls_TextChangedFact);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAutoFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAutoFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOFID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleChcke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleChcke)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleNote)).EndInit();
            this.gbxAge.ResumeLayout(false);
            this.gbxAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGetTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGetTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsComLadleThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsComLadleThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinLadleThrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFinLadleThrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.Label label32;
        private PxDataValid.PxComboBox cmbLadleGrade;
        private PxDataValid.PxComboBox cmbSkBoardKeep;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbOffReason;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private PxDataValid.PxComboBox cmbLadleID;
        private PxDataValid.PxComboBox cmbLadleCheck;
        private PxDataValid.PxTextBox txtBOFID;
        private PxDataValid.PxTextBox txtFireTimeLen;
        private PxDataValid.PxTextBox txtLadleAge;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dtCompleteTime;
        private System.Windows.Forms.DateTimePicker dtUseDate;
        private System.Windows.Forms.DateTimePicker dtArriveTime;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.DateTimePicker dtOffLadleTime;
        private System.Windows.Forms.DateTimePicker dtSeatOKTime;
        private System.Windows.Forms.DateTimePicker dtIrrTime;
        private PxDataValid.PxTextBox txtSteelGrade;
        private System.Windows.Forms.DateTimePicker dtTapTime;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxTextBox pxTextBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label33;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbBOFID;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private PxDataValid.PxTextBox txtJoint;
        private PxDataValid.PxTextBox txtSpringBox;
        private PxDataValid.PxTextBox txtFrame;
        private PxDataValid.PxTextBox txtSplint;
        private System.Windows.Forms.GroupBox gbxAge;
        private PxDataValid.PxTextBox txtProtectBoard;
        private PxDataValid.PxTextBox txtJointSafetyPin;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label42;
        private PxDataValid.PxTextBox txtUpTightenMachine;
        private PxDataValid.PxTextBox txtLongAxes;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label39;
        private PxDataValid.PxTextBox txtWaterGap;
        private PxDataValid.PxTextBox txtShortAxes;
        private PxDataValid.PxTextBox txtBreatheBriUp;
        private PxDataValid.PxTextBox txtChassis;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxTextBox txtBreatheBriLow;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableName;
        private System.Data.DataColumn coll3DataSet1L3DataTableInput_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableLadleID;
        private System.Data.DataColumn coll3DataSet1L3DataTableUse_Date;
        private System.Data.DataColumn coll3DataSet1L3DataTableLadle_Age;
        private System.Data.DataColumn coll3DataSet1L3DataTableBOFID;
        private System.Data.DataColumn coll3DataSet1L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet1L3DataTableSteel_Grade;
        private System.Data.DataColumn coll3DataSet1L3DataTableSeat_OK_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableTap_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableOff_Ladle_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableArrive_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableComplete_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableFire_Time_Len;
        private System.Data.DataColumn coll3DataSet1L3DataTableStop_Time_Len;
        private System.Data.DataColumn coll3DataSet1L3DataTableLadle_Check;
        private System.Data.DataColumn coll3DataSet1L3DataTableOff_Reason;
        private System.Data.DataColumn coll3DataSet1L3DataTableSk_Board_Keep;
        private System.Data.DataColumn coll3DataSet1L3DataTableTeamID;
        private System.Data.DataColumn coll3DataSet1L3DataTableShiftID;
        private System.Data.DataColumn coll3DataSet1L3DataTableOperator;
        private System.Data.DataColumn coll3DataSet1L3DataTableNote;
        private System.Data.DataColumn coll3DataSet1L3DataTableHot_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableFrame;
        private System.Data.DataColumn coll3DataSet1L3DataTableSplint;
        private System.Data.DataColumn coll3DataSet1L3DataTableSpringBox;
        private System.Data.DataColumn coll3DataSet1L3DataTableJoint;
        private System.Data.DataColumn coll3DataSet1L3DataTableJoint_Safety_Pin;
        private System.Data.DataColumn coll3DataSet1L3DataTableLong_Axes;
        private System.Data.DataColumn coll3DataSet1L3DataTableShort_Axes;
        private System.Data.DataColumn coll3DataSet1L3DataTableChassis;
        private System.Data.DataColumn coll3DataSet1L3DataTableProtect_Board;
        private System.Data.DataColumn coll3DataSet1L3DataTableUp_Tighten_Machine;
        private System.Data.DataColumn coll3DataSet1L3DataTableBreathe_Bri_Up;
        private System.Data.DataColumn coll3DataSet1L3DataTableBreathe_Bri_Low;
        private System.Data.DataColumn coll3DataSet1L3DataTableWater_Gap;
        private AppSvrHMI.L3DataSet dsBOFID;
        private System.Data.DataTable schemadsBOFID;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode;
        private System.Data.DataColumn coldsBOFIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DateTimePicker dtIrrEndTime;
        private System.Windows.Forms.Label label48;
        private AppSvrHMI.L3DataSet dsGetTime;
        private AppSvrHMI.L3Command cmdGetTime;
        private System.Data.DataTable schemadsGetTime;
        private System.Data.DataColumn coldsGetTimeL3DataTableGUID;
        private System.Data.DataColumn coldsGetTimeL3DataTableNAME;
        private System.Data.DataColumn coldsGetTimeL3DataTableHEATID;
        private System.Data.DataColumn coldsGetTimeL3DataTableTREATNO;
        private System.Data.DataColumn coldsGetTimeL3DataTableCCMID;
        private System.Data.DataColumn coldsGetTimeL3DataTableLADLEID;
        private System.Data.DataColumn coldsGetTimeL3DataTableWEIGHT;
        private System.Data.DataColumn coldsGetTimeL3DataTableREMAINWEIGHT;
        private System.Data.DataColumn coldsGetTimeL3DataTableARRIVAL_TIME;
        private System.Data.DataColumn coldsGetTimeL3DataTableLADLETYPE;
        private System.Data.DataColumn coldsGetTimeL3DataTableDEPARTURE_TIME;
        private System.Data.DataColumn coldsGetTimeL3DataTableCASTING_START_TIME;
        private System.Data.DataColumn coldsGetTimeL3DataTableCASTING_STOP_TIME;
        private System.Data.DataColumn coldsGetTimeL3DataTableHOLDTIME;
        private System.Data.DataColumn coldsGetTimeL3DataTableTEMP;
        private System.Data.DataColumn coldsGetTimeL3DataTableTEMPUPTO;
        private System.Data.DataColumn coldsGetTimeL3DataTableHOLDTIME_REASON;
        private System.Data.DataColumn coldsGetTimeL3DataTablePROTECTION;
        private System.Data.DataColumn coldsGetTimeL3DataTableUNPROTECTION_REASON;
        private AppSvrHMI.L3CommandParameter l3cmdpGetTime;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private PxDataValid.PxTextBox txtRemnantWT;
        private System.Windows.Forms.Label label31;
        private System.Data.DataColumn coldsMainL3DataTableIrr_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableIrr_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableWorkID;
        private System.Data.DataColumn coldsMainL3DataTableRemnantWT;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsLadleChcke;
        private System.Data.DataTable schemadsLadleChcke;
        private System.Data.DataColumn coldsLadleChckeL3DataTableCode;
        private System.Data.DataColumn coldsLadleChckeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsComLadleThrow;
        private System.Data.DataTable schemadsComLadleThrow;
        private System.Data.DataColumn coldsComLadleThrowL3DataTableCode;
        private System.Data.DataColumn coldsComLadleThrowL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsFinLadleThrow;
        private System.Data.DataTable schemadsFinLadleThrow;
        private System.Data.DataColumn coldsFinLadleThrowL3DataTableCode;
        private System.Data.DataColumn coldsFinLadleThrowL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsLadleGrade;
        private System.Data.DataTable schemadsLadleGrade;
        private System.Data.DataColumn coldsLadleGradeL3DataTableCode;
        private AppSvrHMI.L3DataBox txtStopTimeLen;
        private PxDataValid.PxComboBox cmbLadleGrade_Act;
        private System.Windows.Forms.Label label49;
        private System.Data.DataColumn coldsMainL3DataTableAct_Ladle_Grade;
        private System.Windows.Forms.ComboBox cmbNote;
        private System.Windows.Forms.Label label50;
        private AppSvrHMI.L3DataSet dsLadleNote;
        private System.Data.DataTable schemadsLadleNote;
        private System.Data.DataColumn coldsLadleNoteL3DataTableCode;
        private System.Data.DataColumn coldsLadleNoteL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbLableOutCheck;
        private System.Windows.Forms.Label label51;
        private AppSvrHMI.L3DataSet dsLadleChcke1;
        private System.Data.DataTable schemadsLadleChcke1;
        private System.Data.DataColumn coldsLadleChcke1L3DataTableCode;
        private System.Data.DataColumn coldsLadleChcke1L3DataTableCode_Des;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Check1;
        private PxDataValid.PxComboBox pxComboBox1;
        private System.Windows.Forms.Label label52;
        private PxDataValid.PxTextBox txtWallTemp;
        private System.Windows.Forms.Label label53;
        private System.Data.DataColumn coldsMainL3DataTableWall_Temp;
        private PxDataValid.PxComboBox cmdAutoFlow;
        private System.Windows.Forms.Label label54;
        private AppSvrHMI.L3DataSet dsAutoFlow;
        private System.Data.DataTable schemadsAutoFlow;
        private System.Data.DataColumn coldsAutoFlowL3DataTableCode;
        private System.Data.DataColumn coldsAutoFlowL3DataTableCode_Des;
        private System.Data.DataColumn coldsMainL3DataTableAuto_Flow;
        private System.Data.DataColumn coldsMainL3DataTableNewLadleFirst;
        private System.Data.DataColumn coldsMainL3DataTableNewLadleSecond;
        private System.Data.DataColumn coldsMainL3DataTableFireLadleFirst;
        private System.Data.DataColumn coldsMainL3DataTableFireLadleSecond;
        private System.Data.DataColumn coldsMainL3DataTableReturnLadle;
        private System.Data.DataColumn coldsMainL3DataTableHookEdgeLadle;
        private System.Data.DataColumn coldsMainL3DataTableRemnantLadle;
        private System.Data.DataColumn coldsMainL3DataTableComFlag;
        private System.Data.DataColumn coldsMainL3DataTableConfirm_Flag;
        private System.Data.DataColumn AcoldsMainL3DataTableAct_Ladle_Grade;
        private System.Data.DataColumn AcoldsMainL3DataTableLadle_Check1;
        private System.Data.DataColumn AcoldsMainL3DataTableAuto_Flow;
        private System.Data.DataColumn coldsMainL3DataTableTime_After_Steel;
        private System.Data.DataColumn coldsMainL3DataTableWorkStation;
        private System.Data.DataColumn coldsMainL3DataTableCd_Temp;
        private System.Data.DataColumn coldsMainL3DataTableCasting_Stop_Time;
        private System.Data.DataColumn coldsMainL3DataTableSlagWire;
        private System.Data.DataColumn coldsMainL3DataTableLADLE_GRADE;
        private System.Data.DataColumn coldsMainL3DataTableDump_LadleID;
        private System.Windows.Forms.Label label55;
        private PxDataValid.PxTextBox pxTextBox1;
        

    }
}