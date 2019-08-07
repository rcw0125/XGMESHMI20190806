namespace EquipMag.LadleMag
{
    partial class FinLadleBuildShowFrm
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
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableWORKID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBuild_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableBuild_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_Gap_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_Gap_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBricklaying_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Pro_Refr_Name = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Pro_Refr_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Woke_Refr_Name = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Woke_Refr_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableWall_Refr_Name = new System.Data.DataColumn();
            this.coldsMainL3DataTableWall_Refr_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableSlag_Line_Refe_Name = new System.Data.DataColumn();
            this.coldsMainL3DataTableSlag_Line_Refe_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpi_Cast_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpi_Cast_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Inner_Checker = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadle_Inner_Use_Count = new System.Data.DataColumn();
            this.coldsMainL3DataTableSeat_Bri_Installer = new System.Data.DataColumn();
            this.coldsMainL3DataTableButtom_Builder = new System.Data.DataColumn();
            this.coldsMainL3DataTableWall_Builder = new System.Data.DataColumn();
            this.coldsMainL3DataTableLine_Refe_Builder = new System.Data.DataColumn();
            this.coldsMainL3DataTableRep_Ladle_Bot = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableThr_Ladle_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.txtLadleAge = new PxDataValid.PxTextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbBricklayingFac = new PxDataValid.PxComboBox();
            this.dsBricklayingFac = new AppSvrHMI.L3DataSet();
            this.schemadsBricklayingFac = new System.Data.DataTable();
            this.coldsBricklayingFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbSpiCastFac = new PxDataValid.PxComboBox();
            this.dsCastMat = new AppSvrHMI.L3DataSet();
            this.schemadsCastMat = new System.Data.DataTable();
            this.coldsCastMatL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbBotWallRepMatFac = new PxDataValid.PxComboBox();
            this.dsBotWallRepMatFac = new AppSvrHMI.L3DataSet();
            this.schemadsBotWallRepMatFac = new System.Data.DataTable();
            this.coldsBotWallRepMatFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbSlagLineRefeName = new PxDataValid.PxComboBox();
            this.dsSlagLineRefeName = new AppSvrHMI.L3DataSet();
            this.schemadsSlagLineRefeName = new System.Data.DataTable();
            this.coldsSlagLineRefeNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbWallRefrName = new PxDataValid.PxComboBox();
            this.dsWallRefrName = new AppSvrHMI.L3DataSet();
            this.schemadsWallRefrName = new System.Data.DataTable();
            this.coldsWallRefrNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbBotWokeRefrName = new PxDataValid.PxComboBox();
            this.dsBotWokeRefrName = new AppSvrHMI.L3DataSet();
            this.schemadsBotWokeRefrName = new System.Data.DataTable();
            this.coldsBotWokeRefrNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbBotProRefrName = new PxDataValid.PxComboBox();
            this.dsBotProRefrName = new AppSvrHMI.L3DataSet();
            this.schemadsBotProRefrName = new System.Data.DataTable();
            this.coldsBotProRefrNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbLadleID = new PxDataValid.PxComboBox();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
            this.cmbBreatheBriFac = new PxDataValid.PxComboBox();
            this.dsBreBri = new AppSvrHMI.L3DataSet();
            this.schemadsBreBri = new System.Data.DataTable();
            this.coldsBreBriL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbWaterGapBriFac = new PxDataValid.PxComboBox();
            this.dsGapBri = new AppSvrHMI.L3DataSet();
            this.schemadsGapBri = new System.Data.DataTable();
            this.coldsGapBriL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.dtThrLadleTime = new System.Windows.Forms.DateTimePicker();
            this.dtFireEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtBuildEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtFireStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtBuildStartTime = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label41 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepLadleBot = new PxDataValid.PxTextBox();
            this.txtLineRefeBuilder = new PxDataValid.PxTextBox();
            this.txtWallBuilder = new PxDataValid.PxTextBox();
            this.txtButtomBuilder = new PxDataValid.PxTextBox();
            this.txtSeatBriInstaller = new PxDataValid.PxTextBox();
            this.txtLadleInnerUseCount = new PxDataValid.PxTextBox();
            this.txtLadleInnerChecker = new PxDataValid.PxTextBox();
            this.txtSpiCastWast = new PxDataValid.PxTextBox();
            this.txtBotWallRepMatWast = new PxDataValid.PxTextBox();
            this.txtSlagLineRefeWast = new PxDataValid.PxTextBox();
            this.txtWallRefrWast = new PxDataValid.PxTextBox();
            this.txtBotWokeRefrWast = new PxDataValid.PxTextBox();
            this.txtBotProRefrWast = new PxDataValid.PxTextBox();
            this.txtBreatheBriWast = new PxDataValid.PxTextBox();
            this.txtWaterGapBriWast = new PxDataValid.PxTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBricklayingFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBricklayingFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotWallRepMatFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotWallRepMatFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlagLineRefeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlagLineRefeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWallRefrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWallRefrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotWokeRefrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotWokeRefrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotProRefrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotProRefrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).BeginInit();
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
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = null;
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableInput_Time,
            this.coldsMainL3DataTableWORKID,
            this.coldsMainL3DataTableLadleID,
            this.coldsMainL3DataTableBuild_Start_Time,
            this.coldsMainL3DataTableBuild_End_Time,
            this.coldsMainL3DataTableWater_Gap_Bri_Fac,
            this.coldsMainL3DataTableWater_Gap_Bri_Wast,
            this.coldsMainL3DataTableBreathe_Bri_Fac,
            this.coldsMainL3DataTableBreathe_Bri_Wast,
            this.coldsMainL3DataTableBricklaying_Fac,
            this.coldsMainL3DataTableBot_Pro_Refr_Name,
            this.coldsMainL3DataTableBot_Pro_Refr_Wast,
            this.coldsMainL3DataTableBot_Woke_Refr_Name,
            this.coldsMainL3DataTableBot_Woke_Refr_Wast,
            this.coldsMainL3DataTableWall_Refr_Name,
            this.coldsMainL3DataTableWall_Refr_Wast,
            this.coldsMainL3DataTableSlag_Line_Refe_Name,
            this.coldsMainL3DataTableSlag_Line_Refe_Wast,
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Fac,
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast,
            this.coldsMainL3DataTableSpi_Cast_Fac,
            this.coldsMainL3DataTableSpi_Cast_Wast,
            this.coldsMainL3DataTableLadle_Inner_Checker,
            this.coldsMainL3DataTableLadle_Inner_Use_Count,
            this.coldsMainL3DataTableSeat_Bri_Installer,
            this.coldsMainL3DataTableButtom_Builder,
            this.coldsMainL3DataTableWall_Builder,
            this.coldsMainL3DataTableLine_Refe_Builder,
            this.coldsMainL3DataTableRep_Ladle_Bot,
            this.coldsMainL3DataTableFire_Start_Time,
            this.coldsMainL3DataTableFire_End_Time,
            this.coldsMainL3DataTableThr_Ladle_Time,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableNote});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableName
            // 
            this.coldsMainL3DataTableName.Caption = "Name";
            this.coldsMainL3DataTableName.ColumnName = "Name";
            this.coldsMainL3DataTableName.Namespace = "";
            // 
            // coldsMainL3DataTableInput_Time
            // 
            this.coldsMainL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsMainL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsMainL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableInput_Time.Namespace = "";
            // 
            // coldsMainL3DataTableWORKID
            // 
            this.coldsMainL3DataTableWORKID.Caption = "WORKID";
            this.coldsMainL3DataTableWORKID.ColumnName = "WORKID";
            this.coldsMainL3DataTableWORKID.Namespace = "";
            // 
            // coldsMainL3DataTableLadleID
            // 
            this.coldsMainL3DataTableLadleID.Caption = "LadleID";
            this.coldsMainL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsMainL3DataTableLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableBuild_Start_Time
            // 
            this.coldsMainL3DataTableBuild_Start_Time.Caption = "Build_Start_Time";
            this.coldsMainL3DataTableBuild_Start_Time.ColumnName = "Build_Start_Time";
            this.coldsMainL3DataTableBuild_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableBuild_Start_Time.Namespace = "";
            // 
            // coldsMainL3DataTableBuild_End_Time
            // 
            this.coldsMainL3DataTableBuild_End_Time.Caption = "Build_End_Time";
            this.coldsMainL3DataTableBuild_End_Time.ColumnName = "Build_End_Time";
            this.coldsMainL3DataTableBuild_End_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableBuild_End_Time.Namespace = "";
            // 
            // coldsMainL3DataTableWater_Gap_Bri_Fac
            // 
            this.coldsMainL3DataTableWater_Gap_Bri_Fac.Caption = "Water_Gap_Bri_Fac";
            this.coldsMainL3DataTableWater_Gap_Bri_Fac.ColumnName = "Water_Gap_Bri_Fac";
            this.coldsMainL3DataTableWater_Gap_Bri_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableWater_Gap_Bri_Wast
            // 
            this.coldsMainL3DataTableWater_Gap_Bri_Wast.Caption = "Water_Gap_Bri_Wast";
            this.coldsMainL3DataTableWater_Gap_Bri_Wast.ColumnName = "Water_Gap_Bri_Wast";
            this.coldsMainL3DataTableWater_Gap_Bri_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableWater_Gap_Bri_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableBreathe_Bri_Fac
            // 
            this.coldsMainL3DataTableBreathe_Bri_Fac.Caption = "Breathe_Bri_Fac";
            this.coldsMainL3DataTableBreathe_Bri_Fac.ColumnName = "Breathe_Bri_Fac";
            this.coldsMainL3DataTableBreathe_Bri_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableBreathe_Bri_Wast
            // 
            this.coldsMainL3DataTableBreathe_Bri_Wast.Caption = "Breathe_Bri_Wast";
            this.coldsMainL3DataTableBreathe_Bri_Wast.ColumnName = "Breathe_Bri_Wast";
            this.coldsMainL3DataTableBreathe_Bri_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableBreathe_Bri_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableBricklaying_Fac
            // 
            this.coldsMainL3DataTableBricklaying_Fac.Caption = "Bricklaying_Fac";
            this.coldsMainL3DataTableBricklaying_Fac.ColumnName = "Bricklaying_Fac";
            this.coldsMainL3DataTableBricklaying_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableBot_Pro_Refr_Name
            // 
            this.coldsMainL3DataTableBot_Pro_Refr_Name.Caption = "Bot_Pro_Refr_Name";
            this.coldsMainL3DataTableBot_Pro_Refr_Name.ColumnName = "Bot_Pro_Refr_Name";
            this.coldsMainL3DataTableBot_Pro_Refr_Name.Namespace = "";
            // 
            // coldsMainL3DataTableBot_Pro_Refr_Wast
            // 
            this.coldsMainL3DataTableBot_Pro_Refr_Wast.Caption = "Bot_Pro_Refr_Wast";
            this.coldsMainL3DataTableBot_Pro_Refr_Wast.ColumnName = "Bot_Pro_Refr_Wast";
            this.coldsMainL3DataTableBot_Pro_Refr_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableBot_Pro_Refr_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableBot_Woke_Refr_Name
            // 
            this.coldsMainL3DataTableBot_Woke_Refr_Name.Caption = "Bot_Woke_Refr_Name";
            this.coldsMainL3DataTableBot_Woke_Refr_Name.ColumnName = "Bot_Woke_Refr_Name";
            this.coldsMainL3DataTableBot_Woke_Refr_Name.Namespace = "";
            // 
            // coldsMainL3DataTableBot_Woke_Refr_Wast
            // 
            this.coldsMainL3DataTableBot_Woke_Refr_Wast.Caption = "Bot_Woke_Refr_Wast";
            this.coldsMainL3DataTableBot_Woke_Refr_Wast.ColumnName = "Bot_Woke_Refr_Wast";
            this.coldsMainL3DataTableBot_Woke_Refr_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableBot_Woke_Refr_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableWall_Refr_Name
            // 
            this.coldsMainL3DataTableWall_Refr_Name.Caption = "Wall_Refr_Name";
            this.coldsMainL3DataTableWall_Refr_Name.ColumnName = "Wall_Refr_Name";
            this.coldsMainL3DataTableWall_Refr_Name.Namespace = "";
            // 
            // coldsMainL3DataTableWall_Refr_Wast
            // 
            this.coldsMainL3DataTableWall_Refr_Wast.Caption = "Wall_Refr_Wast";
            this.coldsMainL3DataTableWall_Refr_Wast.ColumnName = "Wall_Refr_Wast";
            this.coldsMainL3DataTableWall_Refr_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableWall_Refr_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableSlag_Line_Refe_Name
            // 
            this.coldsMainL3DataTableSlag_Line_Refe_Name.Caption = "Slag_Line_Refe_Name";
            this.coldsMainL3DataTableSlag_Line_Refe_Name.ColumnName = "Slag_Line_Refe_Name";
            this.coldsMainL3DataTableSlag_Line_Refe_Name.Namespace = "";
            // 
            // coldsMainL3DataTableSlag_Line_Refe_Wast
            // 
            this.coldsMainL3DataTableSlag_Line_Refe_Wast.Caption = "Slag_Line_Refe_Wast";
            this.coldsMainL3DataTableSlag_Line_Refe_Wast.ColumnName = "Slag_Line_Refe_Wast";
            this.coldsMainL3DataTableSlag_Line_Refe_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableSlag_Line_Refe_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableBot_Wall_Rep_Mat_Fac
            // 
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Fac.Caption = "Bot_Wall_Rep_Mat_Fac";
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Fac.ColumnName = "Bot_Wall_Rep_Mat_Fac";
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableBot_Wall_Rep_Mat_Wast
            // 
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast.Caption = "Bot_Wall_Rep_Mat_Wast";
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast.ColumnName = "Bot_Wall_Rep_Mat_Wast";
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableSpi_Cast_Fac
            // 
            this.coldsMainL3DataTableSpi_Cast_Fac.Caption = "Spi_Cast_Fac";
            this.coldsMainL3DataTableSpi_Cast_Fac.ColumnName = "Spi_Cast_Fac";
            this.coldsMainL3DataTableSpi_Cast_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableSpi_Cast_Wast
            // 
            this.coldsMainL3DataTableSpi_Cast_Wast.Caption = "Spi_Cast_Wast";
            this.coldsMainL3DataTableSpi_Cast_Wast.ColumnName = "Spi_Cast_Wast";
            this.coldsMainL3DataTableSpi_Cast_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableSpi_Cast_Wast.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Inner_Checker
            // 
            this.coldsMainL3DataTableLadle_Inner_Checker.Caption = "Ladle_Inner_Checker";
            this.coldsMainL3DataTableLadle_Inner_Checker.ColumnName = "Ladle_Inner_Checker";
            this.coldsMainL3DataTableLadle_Inner_Checker.Namespace = "";
            // 
            // coldsMainL3DataTableLadle_Inner_Use_Count
            // 
            this.coldsMainL3DataTableLadle_Inner_Use_Count.Caption = "Ladle_Inner_Use_Count";
            this.coldsMainL3DataTableLadle_Inner_Use_Count.ColumnName = "Ladle_Inner_Use_Count";
            this.coldsMainL3DataTableLadle_Inner_Use_Count.DataType = typeof(int);
            this.coldsMainL3DataTableLadle_Inner_Use_Count.Namespace = "";
            // 
            // coldsMainL3DataTableSeat_Bri_Installer
            // 
            this.coldsMainL3DataTableSeat_Bri_Installer.Caption = "Seat_Bri_Installer";
            this.coldsMainL3DataTableSeat_Bri_Installer.ColumnName = "Seat_Bri_Installer";
            this.coldsMainL3DataTableSeat_Bri_Installer.Namespace = "";
            // 
            // coldsMainL3DataTableButtom_Builder
            // 
            this.coldsMainL3DataTableButtom_Builder.Caption = "Buttom_Builder";
            this.coldsMainL3DataTableButtom_Builder.ColumnName = "Buttom_Builder";
            this.coldsMainL3DataTableButtom_Builder.Namespace = "";
            // 
            // coldsMainL3DataTableWall_Builder
            // 
            this.coldsMainL3DataTableWall_Builder.Caption = "Wall_Builder";
            this.coldsMainL3DataTableWall_Builder.ColumnName = "Wall_Builder";
            this.coldsMainL3DataTableWall_Builder.Namespace = "";
            // 
            // coldsMainL3DataTableLine_Refe_Builder
            // 
            this.coldsMainL3DataTableLine_Refe_Builder.Caption = "Line_Refe_Builder";
            this.coldsMainL3DataTableLine_Refe_Builder.ColumnName = "Line_Refe_Builder";
            this.coldsMainL3DataTableLine_Refe_Builder.Namespace = "";
            // 
            // coldsMainL3DataTableRep_Ladle_Bot
            // 
            this.coldsMainL3DataTableRep_Ladle_Bot.Caption = "Rep_Ladle_Bot";
            this.coldsMainL3DataTableRep_Ladle_Bot.ColumnName = "Rep_Ladle_Bot";
            this.coldsMainL3DataTableRep_Ladle_Bot.Namespace = "";
            // 
            // coldsMainL3DataTableFire_Start_Time
            // 
            this.coldsMainL3DataTableFire_Start_Time.Caption = "Fire_Start_Time";
            this.coldsMainL3DataTableFire_Start_Time.ColumnName = "Fire_Start_Time";
            this.coldsMainL3DataTableFire_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFire_Start_Time.Namespace = "";
            // 
            // coldsMainL3DataTableFire_End_Time
            // 
            this.coldsMainL3DataTableFire_End_Time.Caption = "Fire_End_Time";
            this.coldsMainL3DataTableFire_End_Time.ColumnName = "Fire_End_Time";
            this.coldsMainL3DataTableFire_End_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableFire_End_Time.Namespace = "";
            // 
            // coldsMainL3DataTableThr_Ladle_Time
            // 
            this.coldsMainL3DataTableThr_Ladle_Time.Caption = "Thr_Ladle_Time";
            this.coldsMainL3DataTableThr_Ladle_Time.ColumnName = "Thr_Ladle_Time";
            this.coldsMainL3DataTableThr_Ladle_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableThr_Ladle_Time.Namespace = "";
            // 
            // coldsMainL3DataTableTeamID
            // 
            this.coldsMainL3DataTableTeamID.Caption = "TeamID";
            this.coldsMainL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsMainL3DataTableTeamID.Namespace = "";
            // 
            // coldsMainL3DataTableShiftID
            // 
            this.coldsMainL3DataTableShiftID.Caption = "ShiftID";
            this.coldsMainL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsMainL3DataTableShiftID.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "Operator";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtLadleAge);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbBricklayingFac);
            this.tabPage1.Controls.Add(this.cmbSpiCastFac);
            this.tabPage1.Controls.Add(this.cmbBotWallRepMatFac);
            this.tabPage1.Controls.Add(this.cmbSlagLineRefeName);
            this.tabPage1.Controls.Add(this.cmbWallRefrName);
            this.tabPage1.Controls.Add(this.cmbBotWokeRefrName);
            this.tabPage1.Controls.Add(this.cmbBotProRefrName);
            this.tabPage1.Controls.Add(this.cmbLadleID);
            this.tabPage1.Controls.Add(this.cmbBreatheBriFac);
            this.tabPage1.Controls.Add(this.cmbWaterGapBriFac);
            this.tabPage1.Controls.Add(this.dtThrLadleTime);
            this.tabPage1.Controls.Add(this.dtFireEndTime);
            this.tabPage1.Controls.Add(this.dtBuildEndTime);
            this.tabPage1.Controls.Add(this.dtFireStartTime);
            this.tabPage1.Controls.Add(this.dtBuildStartTime);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtRepLadleBot);
            this.tabPage1.Controls.Add(this.txtLineRefeBuilder);
            this.tabPage1.Controls.Add(this.txtWallBuilder);
            this.tabPage1.Controls.Add(this.txtButtomBuilder);
            this.tabPage1.Controls.Add(this.txtSeatBriInstaller);
            this.tabPage1.Controls.Add(this.txtLadleInnerUseCount);
            this.tabPage1.Controls.Add(this.txtLadleInnerChecker);
            this.tabPage1.Controls.Add(this.txtSpiCastWast);
            this.tabPage1.Controls.Add(this.txtBotWallRepMatWast);
            this.tabPage1.Controls.Add(this.txtSlagLineRefeWast);
            this.tabPage1.Controls.Add(this.txtWallRefrWast);
            this.tabPage1.Controls.Add(this.txtBotWokeRefrWast);
            this.tabPage1.Controls.Add(this.txtBotProRefrWast);
            this.tabPage1.Controls.Add(this.txtBreatheBriWast);
            this.tabPage1.Controls.Add(this.txtWaterGapBriWast);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(821, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "砌筑实绩";
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(384, 274);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(416, 40);
            this.rtxtNote.TabIndex = 72;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            this.rtxtNote.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(689, 223);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(110, 20);
            this.cmbShiftID.TabIndex = 33;
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
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TeamID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(689, 200);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(110, 20);
            this.cmbTeamID.TabIndex = 32;
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
            // txtLadleAge
            // 
            this.txtLadleAge.EnableNull = false;
            this.txtLadleAge.ErropPr = this.errorProvider1;
            this.txtLadleAge.Length = 0;
            this.txtLadleAge.Location = new System.Drawing.Point(108, 299);
            this.txtLadleAge.Max = 9999;
            this.txtLadleAge.MaxStrLength = 0;
            this.txtLadleAge.Min = 0;
            this.txtLadleAge.MinStrLength = 0;
            this.txtLadleAge.Name = "txtLadleAge";
            this.txtLadleAge.Precision = 0;
            this.txtLadleAge.Size = new System.Drawing.Size(141, 21);
            this.txtLadleAge.TabIndex = 23;
            this.txtLadleAge.ToolTipValid = this.toolTip1;
            this.txtLadleAge.ValidEable = true;
            this.txtLadleAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtLadleAge.Visible = false;
            this.txtLadleAge.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Location = new System.Drawing.Point(64, 302);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(35, 12);
            this.label40.TabIndex = 59;
            this.label40.Text = "包龄:";
            this.label40.Visible = false;
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(689, 248);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(109, 21);
            this.txtOperator.TabIndex = 34;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(645, 225);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 70;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(645, 201);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 69;
            this.label45.Text = "班别:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(340, 275);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 60;
            this.label46.Text = "备注:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(633, 249);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 71;
            this.label47.Text = "责任人:";
            // 
            // cmbBricklayingFac
            // 
            this.cmbBricklayingFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBricklayingFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBricklayingFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bricklaying_Fac", true));
            this.cmbBricklayingFac.DataSource = this.dsBricklayingFac;
            this.cmbBricklayingFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbBricklayingFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBricklayingFac.EnableNull = true;
            this.cmbBricklayingFac.ErropPr = null;
            this.cmbBricklayingFac.FormattingEnabled = true;
            this.cmbBricklayingFac.Location = new System.Drawing.Point(108, 178);
            this.cmbBricklayingFac.Name = "cmbBricklayingFac";
            this.cmbBricklayingFac.Size = new System.Drawing.Size(141, 20);
            this.cmbBricklayingFac.TabIndex = 7;
            this.cmbBricklayingFac.ToolTipValid = null;
            this.cmbBricklayingFac.ValidEable = true;
            this.cmbBricklayingFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsBricklayingFac
            // 
            this.dsBricklayingFac.AutoLoad = true;
            this.dsBricklayingFac.AutoSubscribe = false;
            this.dsBricklayingFac.DataSetName = "L3DataSet";
            this.dsBricklayingFac.DeleteMethod = null;
            this.dsBricklayingFac.InsertMethod = null;
            this.dsBricklayingFac.L3DataAdapter = this.Adapter;
            this.dsBricklayingFac.LoadEvent = "Click";
            this.dsBricklayingFac.LoadTrigger = null;
            this.dsBricklayingFac.RefreshValve = 1000;
            this.dsBricklayingFac.SourceCommand = null;
            this.dsBricklayingFac.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'砌砖\'";
            this.dsBricklayingFac.SourceMethod = "";
            this.dsBricklayingFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBricklayingFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsBricklayingFac.SubscribeTarget = null;
            this.dsBricklayingFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBricklayingFac});
            this.dsBricklayingFac.UpdateEvent = "Click";
            this.dsBricklayingFac.UpdateMethod = null;
            this.dsBricklayingFac.UpdateTrigger = null;
            // 
            // schemadsBricklayingFac
            // 
            this.schemadsBricklayingFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBricklayingFacL3DataTableMATFACTORY});
            this.schemadsBricklayingFac.TableName = "L3DataTable";
            // 
            // coldsBricklayingFacL3DataTableMATFACTORY
            // 
            this.coldsBricklayingFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsBricklayingFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsBricklayingFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbSpiCastFac
            // 
            this.cmbSpiCastFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSpiCastFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSpiCastFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Spi_Cast_Fac", true));
            this.cmbSpiCastFac.DataSource = this.dsCastMat;
            this.cmbSpiCastFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbSpiCastFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpiCastFac.EnableNull = true;
            this.cmbSpiCastFac.ErropPr = null;
            this.cmbSpiCastFac.FormattingEnabled = true;
            this.cmbSpiCastFac.Location = new System.Drawing.Point(384, 178);
            this.cmbSpiCastFac.Name = "cmbSpiCastFac";
            this.cmbSpiCastFac.Size = new System.Drawing.Size(141, 20);
            this.cmbSpiCastFac.TabIndex = 20;
            this.cmbSpiCastFac.ToolTipValid = null;
            this.cmbSpiCastFac.ValidEable = true;
            this.cmbSpiCastFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsCastMat
            // 
            this.dsCastMat.AutoLoad = true;
            this.dsCastMat.AutoSubscribe = false;
            this.dsCastMat.DataSetName = "L3DataSet";
            this.dsCastMat.DeleteMethod = null;
            this.dsCastMat.InsertMethod = null;
            this.dsCastMat.L3DataAdapter = this.Adapter;
            this.dsCastMat.LoadEvent = "Click";
            this.dsCastMat.LoadTrigger = null;
            this.dsCastMat.RefreshValve = 1000;
            this.dsCastMat.SourceCommand = null;
            this.dsCastMat.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'尖晶石浇铸料\'";
            this.dsCastMat.SourceMethod = "";
            this.dsCastMat.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCastMat.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCastMat.SubscribeTarget = null;
            this.dsCastMat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCastMat});
            this.dsCastMat.UpdateEvent = "Click";
            this.dsCastMat.UpdateMethod = null;
            this.dsCastMat.UpdateTrigger = null;
            // 
            // schemadsCastMat
            // 
            this.schemadsCastMat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCastMatL3DataTableMATFACTORY});
            this.schemadsCastMat.TableName = "L3DataTable";
            // 
            // coldsCastMatL3DataTableMATFACTORY
            // 
            this.coldsCastMatL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsCastMatL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsCastMatL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbBotWallRepMatFac
            // 
            this.cmbBotWallRepMatFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBotWallRepMatFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBotWallRepMatFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bot_Wall_Rep_Mat_Fac", true));
            this.cmbBotWallRepMatFac.DataSource = this.dsBotWallRepMatFac;
            this.cmbBotWallRepMatFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbBotWallRepMatFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBotWallRepMatFac.EnableNull = true;
            this.cmbBotWallRepMatFac.ErropPr = null;
            this.cmbBotWallRepMatFac.FormattingEnabled = true;
            this.cmbBotWallRepMatFac.Location = new System.Drawing.Point(384, 154);
            this.cmbBotWallRepMatFac.Name = "cmbBotWallRepMatFac";
            this.cmbBotWallRepMatFac.Size = new System.Drawing.Size(141, 20);
            this.cmbBotWallRepMatFac.TabIndex = 19;
            this.cmbBotWallRepMatFac.ToolTipValid = null;
            this.cmbBotWallRepMatFac.ValidEable = true;
            this.cmbBotWallRepMatFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsBotWallRepMatFac
            // 
            this.dsBotWallRepMatFac.AutoLoad = true;
            this.dsBotWallRepMatFac.AutoSubscribe = false;
            this.dsBotWallRepMatFac.DataSetName = "L3DataSet";
            this.dsBotWallRepMatFac.DeleteMethod = null;
            this.dsBotWallRepMatFac.InsertMethod = null;
            this.dsBotWallRepMatFac.L3DataAdapter = this.Adapter;
            this.dsBotWallRepMatFac.LoadEvent = "Click";
            this.dsBotWallRepMatFac.LoadTrigger = null;
            this.dsBotWallRepMatFac.RefreshValve = 1000;
            this.dsBotWallRepMatFac.SourceCommand = null;
            this.dsBotWallRepMatFac.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'包底壁修补料\'";
            this.dsBotWallRepMatFac.SourceMethod = "";
            this.dsBotWallRepMatFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBotWallRepMatFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsBotWallRepMatFac.SubscribeTarget = null;
            this.dsBotWallRepMatFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBotWallRepMatFac});
            this.dsBotWallRepMatFac.UpdateEvent = "Click";
            this.dsBotWallRepMatFac.UpdateMethod = null;
            this.dsBotWallRepMatFac.UpdateTrigger = null;
            // 
            // schemadsBotWallRepMatFac
            // 
            this.schemadsBotWallRepMatFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBotWallRepMatFacL3DataTableMATFACTORY});
            this.schemadsBotWallRepMatFac.TableName = "L3DataTable";
            // 
            // coldsBotWallRepMatFacL3DataTableMATFACTORY
            // 
            this.coldsBotWallRepMatFacL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsBotWallRepMatFacL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsBotWallRepMatFacL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbSlagLineRefeName
            // 
            this.cmbSlagLineRefeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSlagLineRefeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSlagLineRefeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Slag_Line_Refe_Name", true));
            this.cmbSlagLineRefeName.DataSource = this.dsSlagLineRefeName;
            this.cmbSlagLineRefeName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbSlagLineRefeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSlagLineRefeName.EnableNull = true;
            this.cmbSlagLineRefeName.ErropPr = null;
            this.cmbSlagLineRefeName.FormattingEnabled = true;
            this.cmbSlagLineRefeName.Location = new System.Drawing.Point(384, 130);
            this.cmbSlagLineRefeName.Name = "cmbSlagLineRefeName";
            this.cmbSlagLineRefeName.Size = new System.Drawing.Size(141, 20);
            this.cmbSlagLineRefeName.TabIndex = 18;
            this.cmbSlagLineRefeName.ToolTipValid = null;
            this.cmbSlagLineRefeName.ValidEable = true;
            this.cmbSlagLineRefeName.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsSlagLineRefeName
            // 
            this.dsSlagLineRefeName.AutoLoad = true;
            this.dsSlagLineRefeName.AutoSubscribe = false;
            this.dsSlagLineRefeName.DataSetName = "L3DataSet";
            this.dsSlagLineRefeName.DeleteMethod = null;
            this.dsSlagLineRefeName.InsertMethod = null;
            this.dsSlagLineRefeName.L3DataAdapter = this.Adapter;
            this.dsSlagLineRefeName.LoadEvent = "Click";
            this.dsSlagLineRefeName.LoadTrigger = null;
            this.dsSlagLineRefeName.RefreshValve = 1000;
            this.dsSlagLineRefeName.SourceCommand = null;
            this.dsSlagLineRefeName.SourceCondition = "Code_Group = \'LadleSlag_MatName\'";
            this.dsSlagLineRefeName.SourceMethod = "";
            this.dsSlagLineRefeName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSlagLineRefeName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSlagLineRefeName.SubscribeTarget = null;
            this.dsSlagLineRefeName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSlagLineRefeName});
            this.dsSlagLineRefeName.UpdateEvent = "Click";
            this.dsSlagLineRefeName.UpdateMethod = null;
            this.dsSlagLineRefeName.UpdateTrigger = null;
            // 
            // schemadsSlagLineRefeName
            // 
            this.schemadsSlagLineRefeName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSlagLineRefeNameL3DataTableCode_Des});
            this.schemadsSlagLineRefeName.TableName = "L3DataTable";
            // 
            // coldsSlagLineRefeNameL3DataTableCode_Des
            // 
            this.coldsSlagLineRefeNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSlagLineRefeNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSlagLineRefeNameL3DataTableCode_Des.Namespace = "";
            // 
            // cmbWallRefrName
            // 
            this.cmbWallRefrName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWallRefrName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWallRefrName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Wall_Refr_Name", true));
            this.cmbWallRefrName.DataSource = this.dsWallRefrName;
            this.cmbWallRefrName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbWallRefrName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWallRefrName.EnableNull = true;
            this.cmbWallRefrName.ErropPr = null;
            this.cmbWallRefrName.FormattingEnabled = true;
            this.cmbWallRefrName.Location = new System.Drawing.Point(384, 106);
            this.cmbWallRefrName.Name = "cmbWallRefrName";
            this.cmbWallRefrName.Size = new System.Drawing.Size(141, 20);
            this.cmbWallRefrName.TabIndex = 17;
            this.cmbWallRefrName.ToolTipValid = null;
            this.cmbWallRefrName.ValidEable = true;
            this.cmbWallRefrName.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsWallRefrName
            // 
            this.dsWallRefrName.AutoLoad = true;
            this.dsWallRefrName.AutoSubscribe = false;
            this.dsWallRefrName.DataSetName = "L3DataSet";
            this.dsWallRefrName.DeleteMethod = null;
            this.dsWallRefrName.InsertMethod = null;
            this.dsWallRefrName.L3DataAdapter = this.Adapter;
            this.dsWallRefrName.LoadEvent = "Click";
            this.dsWallRefrName.LoadTrigger = null;
            this.dsWallRefrName.RefreshValve = 1000;
            this.dsWallRefrName.SourceCommand = null;
            this.dsWallRefrName.SourceCondition = "Code_Group = \'LadleWall_Work_MatName\'";
            this.dsWallRefrName.SourceMethod = "";
            this.dsWallRefrName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWallRefrName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsWallRefrName.SubscribeTarget = null;
            this.dsWallRefrName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWallRefrName});
            this.dsWallRefrName.UpdateEvent = "Click";
            this.dsWallRefrName.UpdateMethod = null;
            this.dsWallRefrName.UpdateTrigger = null;
            // 
            // schemadsWallRefrName
            // 
            this.schemadsWallRefrName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWallRefrNameL3DataTableCode_Des});
            this.schemadsWallRefrName.TableName = "L3DataTable";
            // 
            // coldsWallRefrNameL3DataTableCode_Des
            // 
            this.coldsWallRefrNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsWallRefrNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsWallRefrNameL3DataTableCode_Des.Namespace = "";
            // 
            // cmbBotWokeRefrName
            // 
            this.cmbBotWokeRefrName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBotWokeRefrName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBotWokeRefrName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bot_Woke_Refr_Name", true));
            this.cmbBotWokeRefrName.DataSource = this.dsBotWokeRefrName;
            this.cmbBotWokeRefrName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBotWokeRefrName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBotWokeRefrName.EnableNull = true;
            this.cmbBotWokeRefrName.ErropPr = null;
            this.cmbBotWokeRefrName.FormattingEnabled = true;
            this.cmbBotWokeRefrName.Location = new System.Drawing.Point(384, 82);
            this.cmbBotWokeRefrName.Name = "cmbBotWokeRefrName";
            this.cmbBotWokeRefrName.Size = new System.Drawing.Size(141, 20);
            this.cmbBotWokeRefrName.TabIndex = 16;
            this.cmbBotWokeRefrName.ToolTipValid = null;
            this.cmbBotWokeRefrName.ValidEable = true;
            this.cmbBotWokeRefrName.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsBotWokeRefrName
            // 
            this.dsBotWokeRefrName.AutoLoad = true;
            this.dsBotWokeRefrName.AutoSubscribe = false;
            this.dsBotWokeRefrName.DataSetName = "L3DataSet";
            this.dsBotWokeRefrName.DeleteMethod = null;
            this.dsBotWokeRefrName.InsertMethod = null;
            this.dsBotWokeRefrName.L3DataAdapter = this.Adapter;
            this.dsBotWokeRefrName.LoadEvent = "Click";
            this.dsBotWokeRefrName.LoadTrigger = null;
            this.dsBotWokeRefrName.RefreshValve = 1000;
            this.dsBotWokeRefrName.SourceCommand = null;
            this.dsBotWokeRefrName.SourceCondition = "Code_Group = \'LadleBottom_Work_MatName\'";
            this.dsBotWokeRefrName.SourceMethod = "";
            this.dsBotWokeRefrName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBotWokeRefrName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBotWokeRefrName.SubscribeTarget = null;
            this.dsBotWokeRefrName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBotWokeRefrName});
            this.dsBotWokeRefrName.UpdateEvent = "Click";
            this.dsBotWokeRefrName.UpdateMethod = null;
            this.dsBotWokeRefrName.UpdateTrigger = null;
            // 
            // schemadsBotWokeRefrName
            // 
            this.schemadsBotWokeRefrName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBotWokeRefrNameL3DataTableCode_Des});
            this.schemadsBotWokeRefrName.TableName = "L3DataTable";
            // 
            // coldsBotWokeRefrNameL3DataTableCode_Des
            // 
            this.coldsBotWokeRefrNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBotWokeRefrNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBotWokeRefrNameL3DataTableCode_Des.Namespace = "";
            // 
            // cmbBotProRefrName
            // 
            this.cmbBotProRefrName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBotProRefrName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBotProRefrName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bot_Pro_Refr_Name", true));
            this.cmbBotProRefrName.DataSource = this.dsBotProRefrName;
            this.cmbBotProRefrName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBotProRefrName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBotProRefrName.EnableNull = true;
            this.cmbBotProRefrName.ErropPr = null;
            this.cmbBotProRefrName.FormattingEnabled = true;
            this.cmbBotProRefrName.Location = new System.Drawing.Point(384, 58);
            this.cmbBotProRefrName.Name = "cmbBotProRefrName";
            this.cmbBotProRefrName.Size = new System.Drawing.Size(141, 20);
            this.cmbBotProRefrName.TabIndex = 15;
            this.cmbBotProRefrName.ToolTipValid = null;
            this.cmbBotProRefrName.ValidEable = true;
            this.cmbBotProRefrName.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsBotProRefrName
            // 
            this.dsBotProRefrName.AutoLoad = true;
            this.dsBotProRefrName.AutoSubscribe = false;
            this.dsBotProRefrName.DataSetName = "L3DataSet";
            this.dsBotProRefrName.DeleteMethod = null;
            this.dsBotProRefrName.InsertMethod = null;
            this.dsBotProRefrName.L3DataAdapter = this.Adapter;
            this.dsBotProRefrName.LoadEvent = "Click";
            this.dsBotProRefrName.LoadTrigger = null;
            this.dsBotProRefrName.RefreshValve = 1000;
            this.dsBotProRefrName.SourceCommand = null;
            this.dsBotProRefrName.SourceCondition = "Code_Group = \'LadleBottom_ProtectMatName\'";
            this.dsBotProRefrName.SourceMethod = "";
            this.dsBotProRefrName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBotProRefrName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBotProRefrName.SubscribeTarget = null;
            this.dsBotProRefrName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBotProRefrName});
            this.dsBotProRefrName.UpdateEvent = "Click";
            this.dsBotProRefrName.UpdateMethod = null;
            this.dsBotProRefrName.UpdateTrigger = null;
            // 
            // schemadsBotProRefrName
            // 
            this.schemadsBotProRefrName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBotProRefrNameL3DataTableCode_Des});
            this.schemadsBotProRefrName.TableName = "L3DataTable";
            // 
            // coldsBotProRefrNameL3DataTableCode_Des
            // 
            this.coldsBotProRefrNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBotProRefrNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBotProRefrNameL3DataTableCode_Des.Namespace = "";
            // 
            // cmbLadleID
            // 
            this.cmbLadleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLadleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLadleID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "LadleID", true));
            this.cmbLadleID.DataSource = this.dsLadleID;
            this.cmbLadleID.DisplayMember = "L3DataTable.LadleID";
            this.cmbLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleID.EnableNull = false;
            this.cmbLadleID.ErropPr = this.errorProvider1;
            this.cmbLadleID.FormattingEnabled = true;
            this.cmbLadleID.Location = new System.Drawing.Point(108, 34);
            this.cmbLadleID.Name = "cmbLadleID";
            this.cmbLadleID.Size = new System.Drawing.Size(141, 20);
            this.cmbLadleID.TabIndex = 1;
            this.cmbLadleID.ToolTipValid = this.toolTip1;
            this.cmbLadleID.ValidEable = true;
            this.cmbLadleID.ValueMember = "L3DataTable.LadleID";
            this.cmbLadleID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
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
            this.dsLadleID.SourceCondition = "LadleType <> \'1\'";
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
            this.coldsLadleIDL3DataTableLadleID});
            this.schemadsLadleID.TableName = "L3DataTable";
            // 
            // coldsLadleIDL3DataTableLadleID
            // 
            this.coldsLadleIDL3DataTableLadleID.Caption = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsLadleIDL3DataTableLadleID.Namespace = "";
            // 
            // cmbBreatheBriFac
            // 
            this.cmbBreatheBriFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBreatheBriFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBreatheBriFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Fac", true));
            this.cmbBreatheBriFac.DataSource = this.dsBreBri;
            this.cmbBreatheBriFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbBreatheBriFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBreatheBriFac.EnableNull = true;
            this.cmbBreatheBriFac.ErropPr = null;
            this.cmbBreatheBriFac.FormattingEnabled = true;
            this.cmbBreatheBriFac.Location = new System.Drawing.Point(384, 34);
            this.cmbBreatheBriFac.Name = "cmbBreatheBriFac";
            this.cmbBreatheBriFac.Size = new System.Drawing.Size(141, 20);
            this.cmbBreatheBriFac.TabIndex = 14;
            this.cmbBreatheBriFac.ToolTipValid = null;
            this.cmbBreatheBriFac.ValidEable = true;
            this.cmbBreatheBriFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsBreBri
            // 
            this.dsBreBri.AutoLoad = true;
            this.dsBreBri.AutoSubscribe = false;
            this.dsBreBri.DataSetName = "L3DataSet";
            this.dsBreBri.DeleteMethod = null;
            this.dsBreBri.InsertMethod = null;
            this.dsBreBri.L3DataAdapter = this.Adapter;
            this.dsBreBri.LoadEvent = "Click";
            this.dsBreBri.LoadTrigger = null;
            this.dsBreBri.RefreshValve = 1000;
            this.dsBreBri.SourceCommand = null;
            this.dsBreBri.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'透气座砖\'";
            this.dsBreBri.SourceMethod = "";
            this.dsBreBri.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBreBri.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsBreBri.SubscribeTarget = null;
            this.dsBreBri.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBreBri});
            this.dsBreBri.UpdateEvent = "Click";
            this.dsBreBri.UpdateMethod = null;
            this.dsBreBri.UpdateTrigger = null;
            // 
            // schemadsBreBri
            // 
            this.schemadsBreBri.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBreBriL3DataTableMATFACTORY});
            this.schemadsBreBri.TableName = "L3DataTable";
            // 
            // coldsBreBriL3DataTableMATFACTORY
            // 
            this.coldsBreBriL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsBreBriL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsBreBriL3DataTableMATFACTORY.Namespace = "";
            // 
            // cmbWaterGapBriFac
            // 
            this.cmbWaterGapBriFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbWaterGapBriFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWaterGapBriFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_Gap_Bri_Fac", true));
            this.cmbWaterGapBriFac.DataSource = this.dsGapBri;
            this.cmbWaterGapBriFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbWaterGapBriFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaterGapBriFac.EnableNull = true;
            this.cmbWaterGapBriFac.ErropPr = null;
            this.cmbWaterGapBriFac.FormattingEnabled = true;
            this.cmbWaterGapBriFac.Location = new System.Drawing.Point(384, 10);
            this.cmbWaterGapBriFac.Name = "cmbWaterGapBriFac";
            this.cmbWaterGapBriFac.Size = new System.Drawing.Size(141, 20);
            this.cmbWaterGapBriFac.TabIndex = 13;
            this.cmbWaterGapBriFac.ToolTipValid = null;
            this.cmbWaterGapBriFac.ValidEable = true;
            this.cmbWaterGapBriFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsGapBri
            // 
            this.dsGapBri.AutoLoad = true;
            this.dsGapBri.AutoSubscribe = false;
            this.dsGapBri.DataSetName = "L3DataSet";
            this.dsGapBri.DeleteMethod = null;
            this.dsGapBri.InsertMethod = null;
            this.dsGapBri.L3DataAdapter = this.Adapter;
            this.dsGapBri.LoadEvent = "Click";
            this.dsGapBri.LoadTrigger = null;
            this.dsGapBri.RefreshValve = 1000;
            this.dsGapBri.SourceCommand = null;
            this.dsGapBri.SourceCondition = "MATGROUP_CODE = \'LadleFac\' and MATNAME = \'水口座砖\'";
            this.dsGapBri.SourceMethod = "";
            this.dsGapBri.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGapBri.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsGapBri.SubscribeTarget = null;
            this.dsGapBri.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGapBri});
            this.dsGapBri.UpdateEvent = "Click";
            this.dsGapBri.UpdateMethod = null;
            this.dsGapBri.UpdateTrigger = null;
            // 
            // schemadsGapBri
            // 
            this.schemadsGapBri.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGapBriL3DataTableMATFACTORY});
            this.schemadsGapBri.TableName = "L3DataTable";
            // 
            // coldsGapBriL3DataTableMATFACTORY
            // 
            this.coldsGapBriL3DataTableMATFACTORY.Caption = "MATFACTORY";
            this.coldsGapBriL3DataTableMATFACTORY.ColumnName = "MATFACTORY";
            this.coldsGapBriL3DataTableMATFACTORY.Namespace = "";
            // 
            // dtThrLadleTime
            // 
            this.dtThrLadleTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtThrLadleTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Thr_Ladle_Time", true));
            this.dtThrLadleTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThrLadleTime.Location = new System.Drawing.Point(108, 154);
            this.dtThrLadleTime.Name = "dtThrLadleTime";
            this.dtThrLadleTime.Size = new System.Drawing.Size(141, 21);
            this.dtThrLadleTime.TabIndex = 6;
            // 
            // dtFireEndTime
            // 
            this.dtFireEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_End_Time", true));
            this.dtFireEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireEndTime.Location = new System.Drawing.Point(108, 130);
            this.dtFireEndTime.Name = "dtFireEndTime";
            this.dtFireEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtFireEndTime.TabIndex = 5;
            // 
            // dtBuildEndTime
            // 
            this.dtBuildEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Build_End_Time", true));
            this.dtBuildEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildEndTime.Location = new System.Drawing.Point(108, 82);
            this.dtBuildEndTime.Name = "dtBuildEndTime";
            this.dtBuildEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtBuildEndTime.TabIndex = 3;
            // 
            // dtFireStartTime
            // 
            this.dtFireStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_Start_Time", true));
            this.dtFireStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireStartTime.Location = new System.Drawing.Point(108, 106);
            this.dtFireStartTime.Name = "dtFireStartTime";
            this.dtFireStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtFireStartTime.TabIndex = 4;
            // 
            // dtBuildStartTime
            // 
            this.dtBuildStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Build_Start_Time", true));
            this.dtBuildStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildStartTime.Location = new System.Drawing.Point(108, 58);
            this.dtBuildStartTime.Name = "dtBuildStartTime";
            this.dtBuildStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtBuildStartTime.TabIndex = 2;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Location = new System.Drawing.Point(40, 155);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(59, 12);
            this.label43.TabIndex = 42;
            this.label43.Text = "甩包时间:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(16, 131);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 12);
            this.label42.TabIndex = 41;
            this.label42.Text = "烘烤结束时间:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(108, 10);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(16, 107);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(83, 12);
            this.label41.TabIndex = 40;
            this.label41.Text = "烘烤开始时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "砌筑结束时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "砌筑开始时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "录入时间:";
            // 
            // txtRepLadleBot
            // 
            this.txtRepLadleBot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Rep_Ladle_Bot", true));
            this.txtRepLadleBot.EnableNull = true;
            this.txtRepLadleBot.ErropPr = null;
            this.txtRepLadleBot.Length = 0;
            this.txtRepLadleBot.Location = new System.Drawing.Point(384, 251);
            this.txtRepLadleBot.Max = 0;
            this.txtRepLadleBot.MaxStrLength = 0;
            this.txtRepLadleBot.Min = 0;
            this.txtRepLadleBot.MinStrLength = 0;
            this.txtRepLadleBot.Name = "txtRepLadleBot";
            this.txtRepLadleBot.Precision = 0;
            this.txtRepLadleBot.Size = new System.Drawing.Size(141, 21);
            this.txtRepLadleBot.TabIndex = 12;
            this.txtRepLadleBot.ToolTipValid = null;
            this.txtRepLadleBot.ValidEable = true;
            this.txtRepLadleBot.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtLineRefeBuilder
            // 
            this.txtLineRefeBuilder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Line_Refe_Builder", true));
            this.txtLineRefeBuilder.EnableNull = true;
            this.txtLineRefeBuilder.ErropPr = null;
            this.txtLineRefeBuilder.Length = 0;
            this.txtLineRefeBuilder.Location = new System.Drawing.Point(108, 274);
            this.txtLineRefeBuilder.Max = 0;
            this.txtLineRefeBuilder.MaxStrLength = 0;
            this.txtLineRefeBuilder.Min = 0;
            this.txtLineRefeBuilder.MinStrLength = 0;
            this.txtLineRefeBuilder.Name = "txtLineRefeBuilder";
            this.txtLineRefeBuilder.Precision = 0;
            this.txtLineRefeBuilder.Size = new System.Drawing.Size(141, 21);
            this.txtLineRefeBuilder.TabIndex = 11;
            this.txtLineRefeBuilder.ToolTipValid = null;
            this.txtLineRefeBuilder.ValidEable = true;
            this.txtLineRefeBuilder.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtWallBuilder
            // 
            this.txtWallBuilder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Wall_Builder", true));
            this.txtWallBuilder.EnableNull = true;
            this.txtWallBuilder.ErropPr = null;
            this.txtWallBuilder.Length = 0;
            this.txtWallBuilder.Location = new System.Drawing.Point(108, 249);
            this.txtWallBuilder.Max = 0;
            this.txtWallBuilder.MaxStrLength = 0;
            this.txtWallBuilder.Min = 0;
            this.txtWallBuilder.MinStrLength = 0;
            this.txtWallBuilder.Name = "txtWallBuilder";
            this.txtWallBuilder.Precision = 0;
            this.txtWallBuilder.Size = new System.Drawing.Size(141, 21);
            this.txtWallBuilder.TabIndex = 10;
            this.txtWallBuilder.ToolTipValid = null;
            this.txtWallBuilder.ValidEable = true;
            this.txtWallBuilder.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtButtomBuilder
            // 
            this.txtButtomBuilder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Buttom_Builder", true));
            this.txtButtomBuilder.EnableNull = true;
            this.txtButtomBuilder.ErropPr = null;
            this.txtButtomBuilder.Length = 0;
            this.txtButtomBuilder.Location = new System.Drawing.Point(108, 225);
            this.txtButtomBuilder.Max = 0;
            this.txtButtomBuilder.MaxStrLength = 0;
            this.txtButtomBuilder.Min = 0;
            this.txtButtomBuilder.MinStrLength = 0;
            this.txtButtomBuilder.Name = "txtButtomBuilder";
            this.txtButtomBuilder.Precision = 0;
            this.txtButtomBuilder.Size = new System.Drawing.Size(141, 21);
            this.txtButtomBuilder.TabIndex = 9;
            this.txtButtomBuilder.ToolTipValid = null;
            this.txtButtomBuilder.ValidEable = true;
            this.txtButtomBuilder.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSeatBriInstaller
            // 
            this.txtSeatBriInstaller.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Seat_Bri_Installer", true));
            this.txtSeatBriInstaller.EnableNull = true;
            this.txtSeatBriInstaller.ErropPr = null;
            this.txtSeatBriInstaller.Length = 0;
            this.txtSeatBriInstaller.Location = new System.Drawing.Point(108, 201);
            this.txtSeatBriInstaller.Max = 0;
            this.txtSeatBriInstaller.MaxStrLength = 0;
            this.txtSeatBriInstaller.Min = 0;
            this.txtSeatBriInstaller.MinStrLength = 0;
            this.txtSeatBriInstaller.Name = "txtSeatBriInstaller";
            this.txtSeatBriInstaller.Precision = 0;
            this.txtSeatBriInstaller.Size = new System.Drawing.Size(141, 21);
            this.txtSeatBriInstaller.TabIndex = 8;
            this.txtSeatBriInstaller.ToolTipValid = null;
            this.txtSeatBriInstaller.ValidEable = true;
            this.txtSeatBriInstaller.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtLadleInnerUseCount
            // 
            this.txtLadleInnerUseCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Ladle_Inner_Use_Count", true));
            this.txtLadleInnerUseCount.EnableNull = false;
            this.txtLadleInnerUseCount.ErropPr = this.errorProvider1;
            this.txtLadleInnerUseCount.Length = 0;
            this.txtLadleInnerUseCount.Location = new System.Drawing.Point(384, 227);
            this.txtLadleInnerUseCount.Max = 9999;
            this.txtLadleInnerUseCount.MaxStrLength = 0;
            this.txtLadleInnerUseCount.Min = 0;
            this.txtLadleInnerUseCount.MinStrLength = 0;
            this.txtLadleInnerUseCount.Name = "txtLadleInnerUseCount";
            this.txtLadleInnerUseCount.Precision = 0;
            this.txtLadleInnerUseCount.Size = new System.Drawing.Size(141, 21);
            this.txtLadleInnerUseCount.TabIndex = 22;
            this.txtLadleInnerUseCount.ToolTipValid = this.toolTip1;
            this.txtLadleInnerUseCount.ValidEable = true;
            this.txtLadleInnerUseCount.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            this.txtLadleInnerUseCount.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtLadleInnerChecker
            // 
            this.txtLadleInnerChecker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Ladle_Inner_Checker", true));
            this.txtLadleInnerChecker.EnableNull = true;
            this.txtLadleInnerChecker.ErropPr = null;
            this.txtLadleInnerChecker.Length = 0;
            this.txtLadleInnerChecker.Location = new System.Drawing.Point(384, 202);
            this.txtLadleInnerChecker.Max = 0;
            this.txtLadleInnerChecker.MaxStrLength = 0;
            this.txtLadleInnerChecker.Min = 0;
            this.txtLadleInnerChecker.MinStrLength = 0;
            this.txtLadleInnerChecker.Name = "txtLadleInnerChecker";
            this.txtLadleInnerChecker.Precision = 0;
            this.txtLadleInnerChecker.Size = new System.Drawing.Size(141, 21);
            this.txtLadleInnerChecker.TabIndex = 21;
            this.txtLadleInnerChecker.ToolTipValid = null;
            this.txtLadleInnerChecker.ValidEable = true;
            this.txtLadleInnerChecker.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSpiCastWast
            // 
            this.txtSpiCastWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Spi_Cast_Wast", true));
            this.txtSpiCastWast.EnableNull = false;
            this.txtSpiCastWast.ErropPr = this.errorProvider1;
            this.txtSpiCastWast.Length = 0;
            this.txtSpiCastWast.Location = new System.Drawing.Point(689, 177);
            this.txtSpiCastWast.Max = 9999;
            this.txtSpiCastWast.MaxStrLength = 0;
            this.txtSpiCastWast.Min = 0;
            this.txtSpiCastWast.MinStrLength = 0;
            this.txtSpiCastWast.Name = "txtSpiCastWast";
            this.txtSpiCastWast.Precision = 2;
            this.txtSpiCastWast.Size = new System.Drawing.Size(109, 21);
            this.txtSpiCastWast.TabIndex = 31;
            this.txtSpiCastWast.ToolTipValid = this.toolTip1;
            this.txtSpiCastWast.ValidEable = true;
            this.txtSpiCastWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtSpiCastWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtBotWallRepMatWast
            // 
            this.txtBotWallRepMatWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bot_Wall_Rep_Mat_Wast", true));
            this.txtBotWallRepMatWast.EnableNull = false;
            this.txtBotWallRepMatWast.ErropPr = this.errorProvider1;
            this.txtBotWallRepMatWast.Length = 0;
            this.txtBotWallRepMatWast.Location = new System.Drawing.Point(689, 153);
            this.txtBotWallRepMatWast.Max = 9999;
            this.txtBotWallRepMatWast.MaxStrLength = 0;
            this.txtBotWallRepMatWast.Min = 0;
            this.txtBotWallRepMatWast.MinStrLength = 0;
            this.txtBotWallRepMatWast.Name = "txtBotWallRepMatWast";
            this.txtBotWallRepMatWast.Precision = 2;
            this.txtBotWallRepMatWast.Size = new System.Drawing.Size(109, 21);
            this.txtBotWallRepMatWast.TabIndex = 30;
            this.txtBotWallRepMatWast.ToolTipValid = this.toolTip1;
            this.txtBotWallRepMatWast.ValidEable = true;
            this.txtBotWallRepMatWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtBotWallRepMatWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtSlagLineRefeWast
            // 
            this.txtSlagLineRefeWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Slag_Line_Refe_Wast", true));
            this.txtSlagLineRefeWast.EnableNull = false;
            this.txtSlagLineRefeWast.ErropPr = this.errorProvider1;
            this.txtSlagLineRefeWast.Length = 0;
            this.txtSlagLineRefeWast.Location = new System.Drawing.Point(689, 129);
            this.txtSlagLineRefeWast.Max = 9999;
            this.txtSlagLineRefeWast.MaxStrLength = 0;
            this.txtSlagLineRefeWast.Min = 0;
            this.txtSlagLineRefeWast.MinStrLength = 0;
            this.txtSlagLineRefeWast.Name = "txtSlagLineRefeWast";
            this.txtSlagLineRefeWast.Precision = 2;
            this.txtSlagLineRefeWast.Size = new System.Drawing.Size(109, 21);
            this.txtSlagLineRefeWast.TabIndex = 29;
            this.txtSlagLineRefeWast.ToolTipValid = this.toolTip1;
            this.txtSlagLineRefeWast.ValidEable = true;
            this.txtSlagLineRefeWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtSlagLineRefeWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtWallRefrWast
            // 
            this.txtWallRefrWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Wall_Refr_Wast", true));
            this.txtWallRefrWast.EnableNull = false;
            this.txtWallRefrWast.ErropPr = this.errorProvider1;
            this.txtWallRefrWast.Length = 0;
            this.txtWallRefrWast.Location = new System.Drawing.Point(689, 105);
            this.txtWallRefrWast.Max = 9999;
            this.txtWallRefrWast.MaxStrLength = 0;
            this.txtWallRefrWast.Min = 0;
            this.txtWallRefrWast.MinStrLength = 0;
            this.txtWallRefrWast.Name = "txtWallRefrWast";
            this.txtWallRefrWast.Precision = 2;
            this.txtWallRefrWast.Size = new System.Drawing.Size(109, 21);
            this.txtWallRefrWast.TabIndex = 28;
            this.txtWallRefrWast.ToolTipValid = this.toolTip1;
            this.txtWallRefrWast.ValidEable = true;
            this.txtWallRefrWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWallRefrWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtBotWokeRefrWast
            // 
            this.txtBotWokeRefrWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bot_Woke_Refr_Wast", true));
            this.txtBotWokeRefrWast.EnableNull = false;
            this.txtBotWokeRefrWast.ErropPr = this.errorProvider1;
            this.txtBotWokeRefrWast.Length = 0;
            this.txtBotWokeRefrWast.Location = new System.Drawing.Point(689, 81);
            this.txtBotWokeRefrWast.Max = 9999;
            this.txtBotWokeRefrWast.MaxStrLength = 0;
            this.txtBotWokeRefrWast.Min = 0;
            this.txtBotWokeRefrWast.MinStrLength = 0;
            this.txtBotWokeRefrWast.Name = "txtBotWokeRefrWast";
            this.txtBotWokeRefrWast.Precision = 2;
            this.txtBotWokeRefrWast.Size = new System.Drawing.Size(109, 21);
            this.txtBotWokeRefrWast.TabIndex = 27;
            this.txtBotWokeRefrWast.ToolTipValid = this.toolTip1;
            this.txtBotWokeRefrWast.ValidEable = true;
            this.txtBotWokeRefrWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtBotWokeRefrWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtBotProRefrWast
            // 
            this.txtBotProRefrWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bot_Pro_Refr_Wast", true));
            this.txtBotProRefrWast.EnableNull = false;
            this.txtBotProRefrWast.ErropPr = this.errorProvider1;
            this.txtBotProRefrWast.Length = 0;
            this.txtBotProRefrWast.Location = new System.Drawing.Point(689, 57);
            this.txtBotProRefrWast.Max = 9999;
            this.txtBotProRefrWast.MaxStrLength = 0;
            this.txtBotProRefrWast.Min = 0;
            this.txtBotProRefrWast.MinStrLength = 0;
            this.txtBotProRefrWast.Name = "txtBotProRefrWast";
            this.txtBotProRefrWast.Precision = 2;
            this.txtBotProRefrWast.Size = new System.Drawing.Size(109, 21);
            this.txtBotProRefrWast.TabIndex = 26;
            this.txtBotProRefrWast.ToolTipValid = this.toolTip1;
            this.txtBotProRefrWast.ValidEable = true;
            this.txtBotProRefrWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtBotProRefrWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtBreatheBriWast
            // 
            this.txtBreatheBriWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Wast", true));
            this.txtBreatheBriWast.EnableNull = false;
            this.txtBreatheBriWast.ErropPr = this.errorProvider1;
            this.txtBreatheBriWast.Length = 0;
            this.txtBreatheBriWast.Location = new System.Drawing.Point(689, 33);
            this.txtBreatheBriWast.Max = 9999;
            this.txtBreatheBriWast.MaxStrLength = 0;
            this.txtBreatheBriWast.Min = 0;
            this.txtBreatheBriWast.MinStrLength = 0;
            this.txtBreatheBriWast.Name = "txtBreatheBriWast";
            this.txtBreatheBriWast.Precision = 2;
            this.txtBreatheBriWast.Size = new System.Drawing.Size(109, 21);
            this.txtBreatheBriWast.TabIndex = 25;
            this.txtBreatheBriWast.ToolTipValid = this.toolTip1;
            this.txtBreatheBriWast.ValidEable = true;
            this.txtBreatheBriWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtBreatheBriWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtWaterGapBriWast
            // 
            this.txtWaterGapBriWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_Gap_Bri_Wast", true));
            this.txtWaterGapBriWast.EnableNull = false;
            this.txtWaterGapBriWast.ErropPr = this.errorProvider1;
            this.txtWaterGapBriWast.Length = 0;
            this.txtWaterGapBriWast.Location = new System.Drawing.Point(689, 9);
            this.txtWaterGapBriWast.Max = 9999;
            this.txtWaterGapBriWast.MaxStrLength = 0;
            this.txtWaterGapBriWast.Min = 0;
            this.txtWaterGapBriWast.MinStrLength = 0;
            this.txtWaterGapBriWast.Name = "txtWaterGapBriWast";
            this.txtWaterGapBriWast.Precision = 2;
            this.txtWaterGapBriWast.Size = new System.Drawing.Size(109, 21);
            this.txtWaterGapBriWast.TabIndex = 24;
            this.txtWaterGapBriWast.ToolTipValid = this.toolTip1;
            this.txtWaterGapBriWast.ValidEable = true;
            this.txtWaterGapBriWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWaterGapBriWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(328, 251);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 12);
            this.label39.TabIndex = 48;
            this.label39.Text = "补包底:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Location = new System.Drawing.Point(40, 275);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(59, 12);
            this.label38.TabIndex = 47;
            this.label38.Text = "渣线砌筑:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(40, 251);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 12);
            this.label37.TabIndex = 46;
            this.label37.Text = "包壁砌筑:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(40, 227);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 12);
            this.label36.TabIndex = 45;
            this.label36.Text = "包底砌筑:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(40, 203);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 44;
            this.label35.Text = "座砖安装:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Location = new System.Drawing.Point(280, 227);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(95, 12);
            this.label34.TabIndex = 58;
            this.label34.Text = "永久层使用次数:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(304, 203);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(71, 12);
            this.label32.TabIndex = 57;
            this.label32.Text = "永久层检查:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(543, 178);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(137, 12);
            this.label31.TabIndex = 68;
            this.label31.Text = "尖晶石浇铸料消耗量[t]:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(555, 154);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 12);
            this.label29.TabIndex = 67;
            this.label29.Text = "包底修补料消耗量[t]:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(567, 130);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 12);
            this.label27.TabIndex = 66;
            this.label27.Text = "渣线耐材消耗量[t]:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(567, 106);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 12);
            this.label25.TabIndex = 65;
            this.label25.Text = "包壁耐材消耗量[t]:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(268, 179);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 12);
            this.label30.TabIndex = 56;
            this.label30.Text = "尖晶石浇铸料厂家:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(268, 155);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 12);
            this.label28.TabIndex = 55;
            this.label28.Text = "包底壁修补料厂家:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(531, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 12);
            this.label23.TabIndex = 64;
            this.label23.Text = "包底工作层耐材消耗量[t]:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(292, 131);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(83, 12);
            this.label26.TabIndex = 54;
            this.label26.Text = "渣线耐材名称:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(531, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(149, 12);
            this.label19.TabIndex = 63;
            this.label19.Text = "包底保护层耐材消耗量[t]:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(292, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 12);
            this.label24.TabIndex = 53;
            this.label24.Text = "包壁耐材名称:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(567, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 62;
            this.label7.Text = "透气座砖消耗量[t]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(256, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 12);
            this.label22.TabIndex = 52;
            this.label22.Text = "包底工作层耐材名称:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(40, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 43;
            this.label8.Text = "砌砖厂家:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(256, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "包底保护层耐材名称:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(292, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 50;
            this.label6.Text = "透气座砖厂家:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(567, 10);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(113, 12);
            this.label33.TabIndex = 61;
            this.label33.Text = "水口座砖消耗量[t]:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(292, 11);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 49;
            this.label21.Text = "水口座砖厂家:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(52, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "钢包号:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(728, 372);
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
            this.btnConfirm.Location = new System.Drawing.Point(647, 372);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FinLadleBuildShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 418);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FinLadleBuildShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "精炼钢包工作层砌筑实绩维护界面";
            this.Load += new System.EventHandler(this.FinLadleBuildShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBricklayingFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBricklayingFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotWallRepMatFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotWallRepMatFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSlagLineRefeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSlagLineRefeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWallRefrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWallRefrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotWokeRefrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotWokeRefrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotProRefrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotProRefrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).EndInit();
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
        private AppSvrHMI.L3DataSet dsMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxComboBox cmbBricklayingFac;
        private PxDataValid.PxComboBox cmbSpiCastFac;
        private PxDataValid.PxComboBox cmbBotWallRepMatFac;
        private PxDataValid.PxComboBox cmbSlagLineRefeName;
        private PxDataValid.PxComboBox cmbWallRefrName;
        private PxDataValid.PxComboBox cmbBotWokeRefrName;
        private PxDataValid.PxComboBox cmbBotProRefrName;
        private PxDataValid.PxComboBox cmbBreatheBriFac;
        private PxDataValid.PxComboBox cmbWaterGapBriFac;
        private System.Windows.Forms.DateTimePicker dtThrLadleTime;
        private System.Windows.Forms.DateTimePicker dtFireEndTime;
        private System.Windows.Forms.DateTimePicker dtBuildEndTime;
        private System.Windows.Forms.DateTimePicker dtFireStartTime;
        private System.Windows.Forms.DateTimePicker dtBuildStartTime;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtLadleAge;
        private PxDataValid.PxTextBox txtRepLadleBot;
        private PxDataValid.PxTextBox txtLineRefeBuilder;
        private PxDataValid.PxTextBox txtWallBuilder;
        private PxDataValid.PxTextBox txtButtomBuilder;
        private PxDataValid.PxTextBox txtSeatBriInstaller;
        private PxDataValid.PxTextBox txtLadleInnerUseCount;
        private PxDataValid.PxTextBox txtLadleInnerChecker;
        private PxDataValid.PxTextBox txtSpiCastWast;
        private PxDataValid.PxTextBox txtBotWallRepMatWast;
        private PxDataValid.PxTextBox txtSlagLineRefeWast;
        private PxDataValid.PxTextBox txtWallRefrWast;
        private PxDataValid.PxTextBox txtBotWokeRefrWast;
        private PxDataValid.PxTextBox txtBotProRefrWast;
        private PxDataValid.PxTextBox txtBreatheBriWast;
        private PxDataValid.PxTextBox txtWaterGapBriWast;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private PxDataValid.PxComboBox cmbLadleID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableWORKID;
        private System.Data.DataColumn coldsMainL3DataTableLadleID;
        private System.Data.DataColumn coldsMainL3DataTableBuild_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableBuild_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableWater_Gap_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableWater_Gap_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBricklaying_Fac;
        private System.Data.DataColumn coldsMainL3DataTableBot_Pro_Refr_Name;
        private System.Data.DataColumn coldsMainL3DataTableBot_Pro_Refr_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBot_Woke_Refr_Name;
        private System.Data.DataColumn coldsMainL3DataTableBot_Woke_Refr_Wast;
        private System.Data.DataColumn coldsMainL3DataTableWall_Refr_Name;
        private System.Data.DataColumn coldsMainL3DataTableWall_Refr_Wast;
        private System.Data.DataColumn coldsMainL3DataTableSlag_Line_Refe_Name;
        private System.Data.DataColumn coldsMainL3DataTableSlag_Line_Refe_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBot_Wall_Rep_Mat_Fac;
        private System.Data.DataColumn coldsMainL3DataTableBot_Wall_Rep_Mat_Wast;
        private System.Data.DataColumn coldsMainL3DataTableSpi_Cast_Fac;
        private System.Data.DataColumn coldsMainL3DataTableSpi_Cast_Wast;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Inner_Checker;
        private System.Data.DataColumn coldsMainL3DataTableLadle_Inner_Use_Count;
        private System.Data.DataColumn coldsMainL3DataTableSeat_Bri_Installer;
        private System.Data.DataColumn coldsMainL3DataTableButtom_Builder;
        private System.Data.DataColumn coldsMainL3DataTableWall_Builder;
        private System.Data.DataColumn coldsMainL3DataTableLine_Refe_Builder;
        private System.Data.DataColumn coldsMainL3DataTableRep_Ladle_Bot;
        private System.Data.DataColumn coldsMainL3DataTableFire_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableFire_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableThr_Ladle_Time;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3DataSet dsLadleID;
        private System.Data.DataTable schemadsLadleID;
        private System.Data.DataColumn coldsLadleIDL3DataTableLadleID;
        private AppSvrHMI.L3DataSet dsCastMat;
        private AppSvrHMI.L3DataSet dsBreBri;
        private AppSvrHMI.L3DataSet dsGapBri;
        private System.Data.DataTable schemadsCastMat;
        private System.Data.DataColumn coldsCastMatL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsBreBri;
        private System.Data.DataColumn coldsBreBriL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsGapBri;
        private System.Data.DataColumn coldsGapBriL3DataTableMATFACTORY;
        private AppSvrHMI.L3DataSet dsBricklayingFac;
        private AppSvrHMI.L3DataSet dsBotProRefrName;
        private AppSvrHMI.L3DataSet dsBotWokeRefrName;
        private AppSvrHMI.L3DataSet dsWallRefrName;
        private AppSvrHMI.L3DataSet dsSlagLineRefeName;
        private AppSvrHMI.L3DataSet dsBotWallRepMatFac;
        private System.Data.DataTable schemadsBricklayingFac;
        private System.Data.DataColumn coldsBricklayingFacL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsBotProRefrName;
        private System.Data.DataTable schemadsBotWokeRefrName;
        private System.Data.DataTable schemadsWallRefrName;
        private System.Data.DataTable schemadsSlagLineRefeName;
        private System.Data.DataTable schemadsBotWallRepMatFac;
        private System.Data.DataColumn coldsBotWallRepMatFacL3DataTableMATFACTORY;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Data.DataColumn coldsBotProRefrNameL3DataTableCode_Des;
        private System.Data.DataColumn coldsBotWokeRefrNameL3DataTableCode_Des;
        private System.Data.DataColumn coldsWallRefrNameL3DataTableCode_Des;
        private System.Data.DataColumn coldsSlagLineRefeNameL3DataTableCode_Des;
    }
}