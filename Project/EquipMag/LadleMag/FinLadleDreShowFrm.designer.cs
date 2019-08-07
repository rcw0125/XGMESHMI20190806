namespace EquipMag.LadleMag
{
    partial class FinLadleDreShowFrm
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
            this.coldsMainL3DataTableChaID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableCha_Slag_Line_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_gap_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableWater_gap_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableBreathe_Bri_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpi_Cast_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpi_Cast_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableSeat_Bri_Installer = new System.Data.DataColumn();
            this.coldsMainL3DataTableButtom_Builder = new System.Data.DataColumn();
            this.coldsMainL3DataTableWall_Builder = new System.Data.DataColumn();
            this.coldsMainL3DataTableRep_Ladle_Bot = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableThr_Ladle_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.coldsMainL3DataTableCha_Dre_Lin_Per = new System.Data.DataColumn();
            this.coldsMainL3DataTableCha_Dre_Lin_Wast = new System.Data.DataColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtFireEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtFireStartTime = new System.Windows.Forms.DateTimePicker();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
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
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbSpiCastFac = new PxDataValid.PxComboBox();
            this.dsCastMat = new AppSvrHMI.L3DataSet();
            this.schemadsCastMat = new System.Data.DataTable();
            this.coldsCastMatL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbBotWallRepMatFac = new PxDataValid.PxComboBox();
            this.dsBotWallRepMatFac = new AppSvrHMI.L3DataSet();
            this.schemadsBotWallRepMatFac = new System.Data.DataTable();
            this.coldsBotWallRepMatFacL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbBreatheBriFac = new PxDataValid.PxComboBox();
            this.dsBreBri = new AppSvrHMI.L3DataSet();
            this.schemadsBreBri = new System.Data.DataTable();
            this.coldsBreBriL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.cmbWaterGapBriFac = new PxDataValid.PxComboBox();
            this.dsGapBri = new AppSvrHMI.L3DataSet();
            this.schemadsGapBri = new System.Data.DataTable();
            this.coldsGapBriL3DataTableMATFACTORY = new System.Data.DataColumn();
            this.dtChalagLineTime = new System.Windows.Forms.DateTimePicker();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepLadleBot = new PxDataValid.PxTextBox();
            this.txtWallBuilder = new PxDataValid.PxTextBox();
            this.txtLadleID = new PxDataValid.PxTextBox();
            this.txtChangLinePer = new PxDataValid.PxTextBox();
            this.txtSeatBriInstaller = new PxDataValid.PxTextBox();
            this.txtSpiCastWast = new PxDataValid.PxTextBox();
            this.txtBotWallRepMatWast = new PxDataValid.PxTextBox();
            this.txtBreatheBriWast = new PxDataValid.PxTextBox();
            this.txtWaterGapBriWast = new PxDataValid.PxTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dsLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsLadleID = new System.Data.DataTable();
            this.coldsLadleIDL3DataTableLadleID = new System.Data.DataColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotWallRepMatFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotWallRepMatFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).BeginInit();
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
            this.dsMain.AutoSubscribe = true;
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
            this.coldsMainL3DataTableChaID,
            this.coldsMainL3DataTableLadleID,
            this.coldsMainL3DataTableCha_Slag_Line_Time,
            this.coldsMainL3DataTableWater_gap_Bri_Fac,
            this.coldsMainL3DataTableWater_gap_Bri_Wast,
            this.coldsMainL3DataTableBreathe_Bri_Fac,
            this.coldsMainL3DataTableBreathe_Bri_Wast,
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Fac,
            this.coldsMainL3DataTableBot_Wall_Rep_Mat_Wast,
            this.coldsMainL3DataTableSpi_Cast_Fac,
            this.coldsMainL3DataTableSpi_Cast_Wast,
            this.coldsMainL3DataTableSeat_Bri_Installer,
            this.coldsMainL3DataTableButtom_Builder,
            this.coldsMainL3DataTableWall_Builder,
            this.coldsMainL3DataTableRep_Ladle_Bot,
            this.coldsMainL3DataTableFire_Start_Time,
            this.coldsMainL3DataTableFire_End_Time,
            this.coldsMainL3DataTableThr_Ladle_Time,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableNote,
            this.coldsMainL3DataTableCha_Dre_Lin_Per,
            this.coldsMainL3DataTableCha_Dre_Lin_Wast});
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
            // coldsMainL3DataTableChaID
            // 
            this.coldsMainL3DataTableChaID.Caption = "ChaID";
            this.coldsMainL3DataTableChaID.ColumnName = "ChaID";
            this.coldsMainL3DataTableChaID.DataType = typeof(int);
            this.coldsMainL3DataTableChaID.Namespace = "";
            // 
            // coldsMainL3DataTableLadleID
            // 
            this.coldsMainL3DataTableLadleID.Caption = "LadleID";
            this.coldsMainL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsMainL3DataTableLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableCha_Slag_Line_Time
            // 
            this.coldsMainL3DataTableCha_Slag_Line_Time.Caption = "Cha_Slag_Line_Time";
            this.coldsMainL3DataTableCha_Slag_Line_Time.ColumnName = "Cha_Slag_Line_Time";
            this.coldsMainL3DataTableCha_Slag_Line_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableCha_Slag_Line_Time.Namespace = "";
            // 
            // coldsMainL3DataTableWater_gap_Bri_Fac
            // 
            this.coldsMainL3DataTableWater_gap_Bri_Fac.Caption = "Water_gap_Bri_Fac";
            this.coldsMainL3DataTableWater_gap_Bri_Fac.ColumnName = "Water_gap_Bri_Fac";
            this.coldsMainL3DataTableWater_gap_Bri_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableWater_gap_Bri_Wast
            // 
            this.coldsMainL3DataTableWater_gap_Bri_Wast.Caption = "Water_gap_Bri_Wast";
            this.coldsMainL3DataTableWater_gap_Bri_Wast.ColumnName = "Water_gap_Bri_Wast";
            this.coldsMainL3DataTableWater_gap_Bri_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableWater_gap_Bri_Wast.Namespace = "";
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
            // coldsMainL3DataTableCha_Dre_Lin_Per
            // 
            this.coldsMainL3DataTableCha_Dre_Lin_Per.Caption = "Cha_Dre_Lin_Per";
            this.coldsMainL3DataTableCha_Dre_Lin_Per.ColumnName = "Cha_Dre_Lin_Per";
            this.coldsMainL3DataTableCha_Dre_Lin_Per.Namespace = "";
            // 
            // coldsMainL3DataTableCha_Dre_Lin_Wast
            // 
            this.coldsMainL3DataTableCha_Dre_Lin_Wast.Caption = "Cha_Dre_Lin_Wast";
            this.coldsMainL3DataTableCha_Dre_Lin_Wast.ColumnName = "Cha_Dre_Lin_Wast";
            this.coldsMainL3DataTableCha_Dre_Lin_Wast.DataType = typeof(double);
            this.coldsMainL3DataTableCha_Dre_Lin_Wast.Namespace = "";
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
            this.tabControl1.Size = new System.Drawing.Size(779, 261);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.dtFireEndTime);
            this.tabPage1.Controls.Add(this.dtFireStartTime);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbSpiCastFac);
            this.tabPage1.Controls.Add(this.cmbBotWallRepMatFac);
            this.tabPage1.Controls.Add(this.cmbBreatheBriFac);
            this.tabPage1.Controls.Add(this.cmbWaterGapBriFac);
            this.tabPage1.Controls.Add(this.dtChalagLineTime);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtRepLadleBot);
            this.tabPage1.Controls.Add(this.txtWallBuilder);
            this.tabPage1.Controls.Add(this.txtLadleID);
            this.tabPage1.Controls.Add(this.txtChangLinePer);
            this.tabPage1.Controls.Add(this.txtSeatBriInstaller);
            this.tabPage1.Controls.Add(this.txtSpiCastWast);
            this.tabPage1.Controls.Add(this.txtBotWallRepMatWast);
            this.tabPage1.Controls.Add(this.txtBreatheBriWast);
            this.tabPage1.Controls.Add(this.txtWaterGapBriWast);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "换渣线实绩";
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "NOTE", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(96, 182);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(668, 46);
            this.rtxtNote.TabIndex = 151;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            this.rtxtNote.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtFireEndTime
            // 
            this.dtFireEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_End_Time", true));
            this.dtFireEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireEndTime.Location = new System.Drawing.Point(96, 106);
            this.dtFireEndTime.Name = "dtFireEndTime";
            this.dtFireEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtFireEndTime.TabIndex = 4;
            // 
            // dtFireStartTime
            // 
            this.dtFireStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtFireStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_Start_Time", true));
            this.dtFireStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFireStartTime.Location = new System.Drawing.Point(96, 81);
            this.dtFireStartTime.Name = "dtFireStartTime";
            this.dtFireStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtFireStartTime.TabIndex = 3;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(7, 106);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 12);
            this.label42.TabIndex = 149;
            this.label42.Text = "烘烤结束时间:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(7, 82);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(83, 12);
            this.label41.TabIndex = 150;
            this.label41.Text = "烘烤开始时间:";
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
            this.cmbShiftID.Location = new System.Drawing.Point(96, 156);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 18;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoLoad = true;
            this.dsShiftID.AutoSubscribe = true;
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
            this.cmbTeamID.Location = new System.Drawing.Point(655, 127);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(109, 20);
            this.cmbTeamID.TabIndex = 17;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = true;
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
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(360, 156);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 19;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(55, 154);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 143;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(614, 130);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 144;
            this.label45.Text = "班别:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(55, 178);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 141;
            this.label46.Text = "备注:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(307, 158);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 142;
            this.label47.Text = "责任人:";
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
            this.cmbSpiCastFac.Location = new System.Drawing.Point(360, 78);
            this.cmbSpiCastFac.Name = "cmbSpiCastFac";
            this.cmbSpiCastFac.Size = new System.Drawing.Size(141, 20);
            this.cmbSpiCastFac.TabIndex = 11;
            this.cmbSpiCastFac.ToolTipValid = null;
            this.cmbSpiCastFac.ValidEable = true;
            this.cmbSpiCastFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsCastMat
            // 
            this.dsCastMat.AutoLoad = true;
            this.dsCastMat.AutoSubscribe = true;
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
            this.cmbBotWallRepMatFac.Location = new System.Drawing.Point(360, 54);
            this.cmbBotWallRepMatFac.Name = "cmbBotWallRepMatFac";
            this.cmbBotWallRepMatFac.Size = new System.Drawing.Size(141, 20);
            this.cmbBotWallRepMatFac.TabIndex = 9;
            this.cmbBotWallRepMatFac.ToolTipValid = null;
            this.cmbBotWallRepMatFac.ValidEable = true;
            this.cmbBotWallRepMatFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsBotWallRepMatFac
            // 
            this.dsBotWallRepMatFac.AutoLoad = true;
            this.dsBotWallRepMatFac.AutoSubscribe = true;
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
            this.cmbBreatheBriFac.Location = new System.Drawing.Point(360, 30);
            this.cmbBreatheBriFac.Name = "cmbBreatheBriFac";
            this.cmbBreatheBriFac.Size = new System.Drawing.Size(141, 20);
            this.cmbBreatheBriFac.TabIndex = 7;
            this.cmbBreatheBriFac.ToolTipValid = null;
            this.cmbBreatheBriFac.ValidEable = true;
            this.cmbBreatheBriFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsBreBri
            // 
            this.dsBreBri.AutoLoad = true;
            this.dsBreBri.AutoSubscribe = true;
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
            this.cmbWaterGapBriFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_gap_Bri_Fac", true));
            this.cmbWaterGapBriFac.DataSource = this.dsGapBri;
            this.cmbWaterGapBriFac.DisplayMember = "L3DataTable.MATFACTORY";
            this.cmbWaterGapBriFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaterGapBriFac.EnableNull = true;
            this.cmbWaterGapBriFac.ErropPr = null;
            this.cmbWaterGapBriFac.FormattingEnabled = true;
            this.cmbWaterGapBriFac.Location = new System.Drawing.Point(360, 6);
            this.cmbWaterGapBriFac.Name = "cmbWaterGapBriFac";
            this.cmbWaterGapBriFac.Size = new System.Drawing.Size(141, 20);
            this.cmbWaterGapBriFac.TabIndex = 5;
            this.cmbWaterGapBriFac.ToolTipValid = null;
            this.cmbWaterGapBriFac.ValidEable = true;
            this.cmbWaterGapBriFac.ValueMember = "L3DataTable.MATFACTORY";
            // 
            // dsGapBri
            // 
            this.dsGapBri.AutoLoad = true;
            this.dsGapBri.AutoSubscribe = true;
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
            // dtChalagLineTime
            // 
            this.dtChalagLineTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtChalagLineTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Cha_Slag_Line_Time", true));
            this.dtChalagLineTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtChalagLineTime.Location = new System.Drawing.Point(96, 56);
            this.dtChalagLineTime.Name = "dtChalagLineTime";
            this.dtChalagLineTime.Size = new System.Drawing.Size(141, 21);
            this.dtChalagLineTime.TabIndex = 2;
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(96, 6);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 133;
            this.label3.Text = "换渣线时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 134;
            this.label1.Text = "录入时间:";
            // 
            // txtRepLadleBot
            // 
            this.txtRepLadleBot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Rep_Ladle_Bot", true));
            this.txtRepLadleBot.EnableNull = true;
            this.txtRepLadleBot.ErropPr = null;
            this.txtRepLadleBot.Length = 0;
            this.txtRepLadleBot.Location = new System.Drawing.Point(360, 130);
            this.txtRepLadleBot.Max = 0;
            this.txtRepLadleBot.MaxStrLength = 0;
            this.txtRepLadleBot.Min = 0;
            this.txtRepLadleBot.MinStrLength = 0;
            this.txtRepLadleBot.Name = "txtRepLadleBot";
            this.txtRepLadleBot.Precision = 0;
            this.txtRepLadleBot.Size = new System.Drawing.Size(141, 21);
            this.txtRepLadleBot.TabIndex = 15;
            this.txtRepLadleBot.ToolTipValid = null;
            this.txtRepLadleBot.ValidEable = true;
            this.txtRepLadleBot.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtWallBuilder
            // 
            this.txtWallBuilder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cha_Dre_Lin_Wast", true));
            this.txtWallBuilder.EnableNull = false;
            this.txtWallBuilder.ErropPr = this.errorProvider1;
            this.txtWallBuilder.Length = 0;
            this.txtWallBuilder.Location = new System.Drawing.Point(655, 103);
            this.txtWallBuilder.Max = 9999;
            this.txtWallBuilder.MaxStrLength = 0;
            this.txtWallBuilder.Min = 0;
            this.txtWallBuilder.MinStrLength = 0;
            this.txtWallBuilder.Name = "txtWallBuilder";
            this.txtWallBuilder.Precision = 3;
            this.txtWallBuilder.Size = new System.Drawing.Size(109, 21);
            this.txtWallBuilder.TabIndex = 16;
            this.txtWallBuilder.ToolTipValid = this.toolTip1;
            this.txtWallBuilder.ValidEable = true;
            this.txtWallBuilder.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtLadleID
            // 
            this.txtLadleID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "LadleID", true));
            this.txtLadleID.EnableNull = false;
            this.txtLadleID.ErropPr = this.errorProvider1;
            this.txtLadleID.Length = 0;
            this.txtLadleID.Location = new System.Drawing.Point(96, 31);
            this.txtLadleID.Max = 0;
            this.txtLadleID.MaxStrLength = 0;
            this.txtLadleID.Min = 0;
            this.txtLadleID.MinStrLength = 0;
            this.txtLadleID.Name = "txtLadleID";
            this.txtLadleID.Precision = 0;
            this.txtLadleID.ReadOnly = true;
            this.txtLadleID.Size = new System.Drawing.Size(141, 21);
            this.txtLadleID.TabIndex = 13;
            this.txtLadleID.ToolTipValid = this.toolTip1;
            this.txtLadleID.ValidEable = true;
            this.txtLadleID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtLadleID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtChangLinePer
            // 
            this.txtChangLinePer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cha_Dre_Lin_Per", true));
            this.txtChangLinePer.EnableNull = true;
            this.txtChangLinePer.ErropPr = null;
            this.txtChangLinePer.Length = 0;
            this.txtChangLinePer.Location = new System.Drawing.Point(360, 103);
            this.txtChangLinePer.Max = 0;
            this.txtChangLinePer.MaxStrLength = 0;
            this.txtChangLinePer.Min = 0;
            this.txtChangLinePer.MinStrLength = 0;
            this.txtChangLinePer.Name = "txtChangLinePer";
            this.txtChangLinePer.Precision = 0;
            this.txtChangLinePer.Size = new System.Drawing.Size(141, 21);
            this.txtChangLinePer.TabIndex = 13;
            this.txtChangLinePer.ToolTipValid = null;
            this.txtChangLinePer.ValidEable = true;
            this.txtChangLinePer.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSeatBriInstaller
            // 
            this.txtSeatBriInstaller.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Seat_Bri_Installer", true));
            this.txtSeatBriInstaller.EnableNull = true;
            this.txtSeatBriInstaller.ErropPr = null;
            this.txtSeatBriInstaller.Length = 0;
            this.txtSeatBriInstaller.Location = new System.Drawing.Point(96, 131);
            this.txtSeatBriInstaller.Max = 0;
            this.txtSeatBriInstaller.MaxStrLength = 0;
            this.txtSeatBriInstaller.Min = 0;
            this.txtSeatBriInstaller.MinStrLength = 0;
            this.txtSeatBriInstaller.Name = "txtSeatBriInstaller";
            this.txtSeatBriInstaller.Precision = 0;
            this.txtSeatBriInstaller.Size = new System.Drawing.Size(141, 21);
            this.txtSeatBriInstaller.TabIndex = 14;
            this.txtSeatBriInstaller.ToolTipValid = null;
            this.txtSeatBriInstaller.ValidEable = true;
            this.txtSeatBriInstaller.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSpiCastWast
            // 
            this.txtSpiCastWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Spi_Cast_Wast", true));
            this.txtSpiCastWast.EnableNull = false;
            this.txtSpiCastWast.ErropPr = this.errorProvider1;
            this.txtSpiCastWast.Length = 0;
            this.txtSpiCastWast.Location = new System.Drawing.Point(655, 79);
            this.txtSpiCastWast.Max = 9999;
            this.txtSpiCastWast.MaxStrLength = 0;
            this.txtSpiCastWast.Min = 0;
            this.txtSpiCastWast.MinStrLength = 0;
            this.txtSpiCastWast.Name = "txtSpiCastWast";
            this.txtSpiCastWast.Precision = 3;
            this.txtSpiCastWast.Size = new System.Drawing.Size(109, 21);
            this.txtSpiCastWast.TabIndex = 12;
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
            this.txtBotWallRepMatWast.Location = new System.Drawing.Point(655, 55);
            this.txtBotWallRepMatWast.Max = 9999;
            this.txtBotWallRepMatWast.MaxStrLength = 0;
            this.txtBotWallRepMatWast.Min = 0;
            this.txtBotWallRepMatWast.MinStrLength = 0;
            this.txtBotWallRepMatWast.Name = "txtBotWallRepMatWast";
            this.txtBotWallRepMatWast.Precision = 3;
            this.txtBotWallRepMatWast.Size = new System.Drawing.Size(109, 21);
            this.txtBotWallRepMatWast.TabIndex = 10;
            this.txtBotWallRepMatWast.ToolTipValid = this.toolTip1;
            this.txtBotWallRepMatWast.ValidEable = true;
            this.txtBotWallRepMatWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtBotWallRepMatWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtBreatheBriWast
            // 
            this.txtBreatheBriWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Breathe_Bri_Wast", true));
            this.txtBreatheBriWast.EnableNull = false;
            this.txtBreatheBriWast.ErropPr = this.errorProvider1;
            this.txtBreatheBriWast.Length = 0;
            this.txtBreatheBriWast.Location = new System.Drawing.Point(655, 31);
            this.txtBreatheBriWast.Max = 9999;
            this.txtBreatheBriWast.MaxStrLength = 0;
            this.txtBreatheBriWast.Min = 0;
            this.txtBreatheBriWast.MinStrLength = 0;
            this.txtBreatheBriWast.Name = "txtBreatheBriWast";
            this.txtBreatheBriWast.Precision = 3;
            this.txtBreatheBriWast.Size = new System.Drawing.Size(109, 21);
            this.txtBreatheBriWast.TabIndex = 8;
            this.txtBreatheBriWast.ToolTipValid = this.toolTip1;
            this.txtBreatheBriWast.ValidEable = true;
            this.txtBreatheBriWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtBreatheBriWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // txtWaterGapBriWast
            // 
            this.txtWaterGapBriWast.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Water_gap_Bri_Wast", true));
            this.txtWaterGapBriWast.EnableNull = false;
            this.txtWaterGapBriWast.ErropPr = this.errorProvider1;
            this.txtWaterGapBriWast.Length = 0;
            this.txtWaterGapBriWast.Location = new System.Drawing.Point(655, 7);
            this.txtWaterGapBriWast.Max = 9999;
            this.txtWaterGapBriWast.MaxStrLength = 0;
            this.txtWaterGapBriWast.Min = 0;
            this.txtWaterGapBriWast.MinStrLength = 0;
            this.txtWaterGapBriWast.Name = "txtWaterGapBriWast";
            this.txtWaterGapBriWast.Precision = 3;
            this.txtWaterGapBriWast.Size = new System.Drawing.Size(109, 21);
            this.txtWaterGapBriWast.TabIndex = 6;
            this.txtWaterGapBriWast.ToolTipValid = this.toolTip1;
            this.txtWaterGapBriWast.ValidEable = true;
            this.txtWaterGapBriWast.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            this.txtWaterGapBriWast.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(307, 134);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 12);
            this.label39.TabIndex = 114;
            this.label39.Text = "补包底:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(560, 106);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(89, 12);
            this.label37.TabIndex = 117;
            this.label37.Text = "渣线消耗量[t]:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Location = new System.Drawing.Point(295, 107);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(59, 12);
            this.label36.TabIndex = 116;
            this.label36.Text = "渣线砌筑:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Location = new System.Drawing.Point(31, 135);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(59, 12);
            this.label35.TabIndex = 115;
            this.label35.Text = "座砖安装:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(512, 82);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(137, 12);
            this.label31.TabIndex = 112;
            this.label31.Text = "尖晶石浇铸料消耗量[t]:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(524, 58);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 12);
            this.label29.TabIndex = 111;
            this.label29.Text = "包底修补料消耗量[t]:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(247, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(107, 12);
            this.label30.TabIndex = 113;
            this.label30.Text = "尖晶石浇铸料厂家:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(247, 58);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 12);
            this.label28.TabIndex = 122;
            this.label28.Text = "包底壁修补料厂家:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(536, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 12);
            this.label7.TabIndex = 123;
            this.label7.Text = "透气座砖消耗量[t]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(271, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 118;
            this.label6.Text = "透气座砖厂家:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Location = new System.Drawing.Point(536, 10);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(113, 12);
            this.label33.TabIndex = 121;
            this.label33.Text = "水口座砖消耗量[t]:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(271, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 12);
            this.label21.TabIndex = 120;
            this.label21.Text = "水口座砖厂家:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(43, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 119;
            this.label5.Text = "钢包号:";
            // 
            // dsLadleID
            // 
            this.dsLadleID.AutoLoad = true;
            this.dsLadleID.AutoSubscribe = true;
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(660, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(579, 268);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 64;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FinLadleDreShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 313);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FinLadleDreShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "精炼钢包换渣线维护界面";
            this.Load += new System.EventHandler(this.FinLadleDreShowFrm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBotWallRepMatFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBotWallRepMatFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBreBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGapBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGapBri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleID)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtFireEndTime;
        private System.Windows.Forms.DateTimePicker dtFireStartTime;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxComboBox cmbSpiCastFac;
        private PxDataValid.PxComboBox cmbBotWallRepMatFac;
        private PxDataValid.PxComboBox cmbBreatheBriFac;
        private PxDataValid.PxComboBox cmbWaterGapBriFac;
        private System.Windows.Forms.DateTimePicker dtChalagLineTime;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtRepLadleBot;
        private PxDataValid.PxTextBox txtWallBuilder;
        private PxDataValid.PxTextBox txtChangLinePer;
        private PxDataValid.PxTextBox txtSeatBriInstaller;
        private PxDataValid.PxTextBox txtSpiCastWast;
        private PxDataValid.PxTextBox txtBotWallRepMatWast;
        private PxDataValid.PxTextBox txtBreatheBriWast;
        private PxDataValid.PxTextBox txtWaterGapBriWast;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableChaID;
        private System.Data.DataColumn coldsMainL3DataTableLadleID;
        private System.Data.DataColumn coldsMainL3DataTableCha_Slag_Line_Time;
        private System.Data.DataColumn coldsMainL3DataTableWater_gap_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableWater_gap_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Fac;
        private System.Data.DataColumn coldsMainL3DataTableBreathe_Bri_Wast;
        private System.Data.DataColumn coldsMainL3DataTableBot_Wall_Rep_Mat_Fac;
        private System.Data.DataColumn coldsMainL3DataTableBot_Wall_Rep_Mat_Wast;
        private System.Data.DataColumn coldsMainL3DataTableSpi_Cast_Fac;
        private System.Data.DataColumn coldsMainL3DataTableSpi_Cast_Wast;
        private System.Data.DataColumn coldsMainL3DataTableSeat_Bri_Installer;
        private System.Data.DataColumn coldsMainL3DataTableButtom_Builder;
        private System.Data.DataColumn coldsMainL3DataTableWall_Builder;
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
        private PxDataValid.PxTextBox txtLadleID;
        private AppSvrHMI.L3DataSet dsBreBri;
        private AppSvrHMI.L3DataSet dsGapBri;
        private AppSvrHMI.L3DataSet dsBotWallRepMatFac;
        private AppSvrHMI.L3DataSet dsCastMat;
        private System.Data.DataTable schemadsBreBri;
        private System.Data.DataColumn coldsBreBriL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsGapBri;
        private System.Data.DataColumn coldsGapBriL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsBotWallRepMatFac;
        private System.Data.DataColumn coldsBotWallRepMatFacL3DataTableMATFACTORY;
        private System.Data.DataTable schemadsCastMat;
        private System.Data.DataColumn coldsCastMatL3DataTableMATFACTORY;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Data.DataColumn coldsMainL3DataTableCha_Dre_Lin_Per;
        private System.Data.DataColumn coldsMainL3DataTableCha_Dre_Lin_Wast;
    }
}