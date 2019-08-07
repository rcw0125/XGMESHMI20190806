namespace EquipMag.EquipAdjust
{
    partial class EquipAdjustDetailFrm
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
            this.txtLoad_A_Std = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnLoad_A_Dif = new PxDataValid.PxTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtUnLoad_B_Dif = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnLoad_A_Act = new PxDataValid.PxTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtUnLoad_B_Act = new PxDataValid.PxTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnLoad_A_Std = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUnLoad_B_Std = new PxDataValid.PxTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoad_A_Dif = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoad_B_Dif = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoad_A_Act = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoad_B_Act = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoad_B_Std = new PxDataValid.PxTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(575, 216);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtLoad_A_Std);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtUnLoad_A_Dif);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.txtUnLoad_B_Dif);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtUnLoad_A_Act);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtUnLoad_B_Act);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtUnLoad_A_Std);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtUnLoad_B_Std);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLoad_A_Dif);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtLoad_B_Dif);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtLoad_A_Act);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtLoad_B_Act);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLoad_B_Std);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设备校准实绩";
            // 
            // txtLoad_A_Std
            // 
            this.txtLoad_A_Std.EnableNull = true;
            this.txtLoad_A_Std.ErropPr = this.errorProvider1;
            this.txtLoad_A_Std.Length = 0;
            this.txtLoad_A_Std.Location = new System.Drawing.Point(392, 16);
            this.txtLoad_A_Std.Max = 0;
            this.txtLoad_A_Std.MaxStrLength = 0;
            this.txtLoad_A_Std.Min = 0;
            this.txtLoad_A_Std.MinStrLength = 0;
            this.txtLoad_A_Std.Name = "txtLoad_A_Std";
            this.txtLoad_A_Std.Precision = 0;
            this.txtLoad_A_Std.Size = new System.Drawing.Size(141, 21);
            this.txtLoad_A_Std.TabIndex = 7;
            this.txtLoad_A_Std.ToolTipValid = this.toolTip1;
            this.txtLoad_A_Std.ValidEable = true;
            this.txtLoad_A_Std.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(291, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 114;
            this.label1.Text = "调整后加载标值:";
            // 
            // txtUnLoad_A_Dif
            // 
            this.txtUnLoad_A_Dif.EnableNull = true;
            this.txtUnLoad_A_Dif.ErropPr = this.errorProvider1;
            this.txtUnLoad_A_Dif.Length = 0;
            this.txtUnLoad_A_Dif.Location = new System.Drawing.Point(392, 151);
            this.txtUnLoad_A_Dif.Max = 0;
            this.txtUnLoad_A_Dif.MaxStrLength = 0;
            this.txtUnLoad_A_Dif.Min = 0;
            this.txtUnLoad_A_Dif.MinStrLength = 0;
            this.txtUnLoad_A_Dif.Name = "txtUnLoad_A_Dif";
            this.txtUnLoad_A_Dif.Precision = 0;
            this.txtUnLoad_A_Dif.Size = new System.Drawing.Size(141, 21);
            this.txtUnLoad_A_Dif.TabIndex = 12;
            this.txtUnLoad_A_Dif.ToolTipValid = this.toolTip1;
            this.txtUnLoad_A_Dif.ValidEable = true;
            this.txtUnLoad_A_Dif.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(291, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(95, 12);
            this.label21.TabIndex = 114;
            this.label21.Text = "调整后卸载差值:";
            // 
            // txtUnLoad_B_Dif
            // 
            this.txtUnLoad_B_Dif.EnableNull = true;
            this.txtUnLoad_B_Dif.ErropPr = this.errorProvider1;
            this.txtUnLoad_B_Dif.Length = 0;
            this.txtUnLoad_B_Dif.Location = new System.Drawing.Point(132, 151);
            this.txtUnLoad_B_Dif.Max = 0;
            this.txtUnLoad_B_Dif.MaxStrLength = 0;
            this.txtUnLoad_B_Dif.Min = 0;
            this.txtUnLoad_B_Dif.MinStrLength = 0;
            this.txtUnLoad_B_Dif.Name = "txtUnLoad_B_Dif";
            this.txtUnLoad_B_Dif.Precision = 0;
            this.txtUnLoad_B_Dif.Size = new System.Drawing.Size(141, 21);
            this.txtUnLoad_B_Dif.TabIndex = 6;
            this.txtUnLoad_B_Dif.ToolTipValid = this.toolTip1;
            this.txtUnLoad_B_Dif.ValidEable = true;
            this.txtUnLoad_B_Dif.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(31, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 114;
            this.label6.Text = "调整前卸载差值:";
            // 
            // txtUnLoad_A_Act
            // 
            this.txtUnLoad_A_Act.EnableNull = true;
            this.txtUnLoad_A_Act.ErropPr = this.errorProvider1;
            this.txtUnLoad_A_Act.Length = 0;
            this.txtUnLoad_A_Act.Location = new System.Drawing.Point(392, 124);
            this.txtUnLoad_A_Act.Max = 0;
            this.txtUnLoad_A_Act.MaxStrLength = 0;
            this.txtUnLoad_A_Act.Min = 0;
            this.txtUnLoad_A_Act.MinStrLength = 0;
            this.txtUnLoad_A_Act.Name = "txtUnLoad_A_Act";
            this.txtUnLoad_A_Act.Precision = 0;
            this.txtUnLoad_A_Act.Size = new System.Drawing.Size(141, 21);
            this.txtUnLoad_A_Act.TabIndex = 11;
            this.txtUnLoad_A_Act.ToolTipValid = this.toolTip1;
            this.txtUnLoad_A_Act.ValidEable = true;
            this.txtUnLoad_A_Act.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(291, 127);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 12);
            this.label19.TabIndex = 114;
            this.label19.Text = "调整后卸载示值:";
            // 
            // txtUnLoad_B_Act
            // 
            this.txtUnLoad_B_Act.EnableNull = true;
            this.txtUnLoad_B_Act.ErropPr = this.errorProvider1;
            this.txtUnLoad_B_Act.Length = 0;
            this.txtUnLoad_B_Act.Location = new System.Drawing.Point(132, 124);
            this.txtUnLoad_B_Act.Max = 0;
            this.txtUnLoad_B_Act.MaxStrLength = 0;
            this.txtUnLoad_B_Act.Min = 0;
            this.txtUnLoad_B_Act.MinStrLength = 0;
            this.txtUnLoad_B_Act.Name = "txtUnLoad_B_Act";
            this.txtUnLoad_B_Act.Precision = 0;
            this.txtUnLoad_B_Act.Size = new System.Drawing.Size(141, 21);
            this.txtUnLoad_B_Act.TabIndex = 5;
            this.txtUnLoad_B_Act.ToolTipValid = this.toolTip1;
            this.txtUnLoad_B_Act.ValidEable = true;
            this.txtUnLoad_B_Act.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(31, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 114;
            this.label5.Text = "调整前卸载示值:";
            // 
            // txtUnLoad_A_Std
            // 
            this.txtUnLoad_A_Std.EnableNull = true;
            this.txtUnLoad_A_Std.ErropPr = this.errorProvider1;
            this.txtUnLoad_A_Std.Length = 0;
            this.txtUnLoad_A_Std.Location = new System.Drawing.Point(392, 97);
            this.txtUnLoad_A_Std.Max = 0;
            this.txtUnLoad_A_Std.MaxStrLength = 0;
            this.txtUnLoad_A_Std.Min = 0;
            this.txtUnLoad_A_Std.MinStrLength = 0;
            this.txtUnLoad_A_Std.Name = "txtUnLoad_A_Std";
            this.txtUnLoad_A_Std.Precision = 0;
            this.txtUnLoad_A_Std.Size = new System.Drawing.Size(141, 21);
            this.txtUnLoad_A_Std.TabIndex = 10;
            this.txtUnLoad_A_Std.ToolTipValid = this.toolTip1;
            this.txtUnLoad_A_Std.ValidEable = true;
            this.txtUnLoad_A_Std.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(291, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 114;
            this.label9.Text = "调整后卸载标值:";
            // 
            // txtUnLoad_B_Std
            // 
            this.txtUnLoad_B_Std.EnableNull = true;
            this.txtUnLoad_B_Std.ErropPr = this.errorProvider1;
            this.txtUnLoad_B_Std.Length = 0;
            this.txtUnLoad_B_Std.Location = new System.Drawing.Point(132, 97);
            this.txtUnLoad_B_Std.Max = 0;
            this.txtUnLoad_B_Std.MaxStrLength = 0;
            this.txtUnLoad_B_Std.Min = 0;
            this.txtUnLoad_B_Std.MinStrLength = 0;
            this.txtUnLoad_B_Std.Name = "txtUnLoad_B_Std";
            this.txtUnLoad_B_Std.Precision = 0;
            this.txtUnLoad_B_Std.Size = new System.Drawing.Size(141, 21);
            this.txtUnLoad_B_Std.TabIndex = 4;
            this.txtUnLoad_B_Std.ToolTipValid = this.toolTip1;
            this.txtUnLoad_B_Std.ValidEable = true;
            this.txtUnLoad_B_Std.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 114;
            this.label4.Text = "调整前卸载标值:";
            // 
            // txtLoad_A_Dif
            // 
            this.txtLoad_A_Dif.EnableNull = true;
            this.txtLoad_A_Dif.ErropPr = this.errorProvider1;
            this.txtLoad_A_Dif.Length = 0;
            this.txtLoad_A_Dif.Location = new System.Drawing.Point(392, 70);
            this.txtLoad_A_Dif.Max = 0;
            this.txtLoad_A_Dif.MaxStrLength = 0;
            this.txtLoad_A_Dif.Min = 0;
            this.txtLoad_A_Dif.MinStrLength = 0;
            this.txtLoad_A_Dif.Name = "txtLoad_A_Dif";
            this.txtLoad_A_Dif.Precision = 0;
            this.txtLoad_A_Dif.Size = new System.Drawing.Size(141, 21);
            this.txtLoad_A_Dif.TabIndex = 9;
            this.txtLoad_A_Dif.ToolTipValid = this.toolTip1;
            this.txtLoad_A_Dif.ValidEable = true;
            this.txtLoad_A_Dif.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(291, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 114;
            this.label8.Text = "调整后加载差值:";
            // 
            // txtLoad_B_Dif
            // 
            this.txtLoad_B_Dif.EnableNull = true;
            this.txtLoad_B_Dif.ErropPr = this.errorProvider1;
            this.txtLoad_B_Dif.Length = 0;
            this.txtLoad_B_Dif.Location = new System.Drawing.Point(132, 70);
            this.txtLoad_B_Dif.Max = 0;
            this.txtLoad_B_Dif.MaxStrLength = 0;
            this.txtLoad_B_Dif.Min = 0;
            this.txtLoad_B_Dif.MinStrLength = 0;
            this.txtLoad_B_Dif.Name = "txtLoad_B_Dif";
            this.txtLoad_B_Dif.Precision = 0;
            this.txtLoad_B_Dif.Size = new System.Drawing.Size(141, 21);
            this.txtLoad_B_Dif.TabIndex = 3;
            this.txtLoad_B_Dif.ToolTipValid = this.toolTip1;
            this.txtLoad_B_Dif.ValidEable = true;
            this.txtLoad_B_Dif.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(31, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 114;
            this.label3.Text = "调整前加载差值:";
            // 
            // txtLoad_A_Act
            // 
            this.txtLoad_A_Act.EnableNull = true;
            this.txtLoad_A_Act.ErropPr = this.errorProvider1;
            this.txtLoad_A_Act.Length = 0;
            this.txtLoad_A_Act.Location = new System.Drawing.Point(392, 43);
            this.txtLoad_A_Act.Max = 0;
            this.txtLoad_A_Act.MaxStrLength = 0;
            this.txtLoad_A_Act.Min = 0;
            this.txtLoad_A_Act.MinStrLength = 0;
            this.txtLoad_A_Act.Name = "txtLoad_A_Act";
            this.txtLoad_A_Act.Precision = 0;
            this.txtLoad_A_Act.Size = new System.Drawing.Size(141, 21);
            this.txtLoad_A_Act.TabIndex = 8;
            this.txtLoad_A_Act.ToolTipValid = this.toolTip1;
            this.txtLoad_A_Act.ValidEable = true;
            this.txtLoad_A_Act.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(291, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 114;
            this.label7.Text = "调整后加载示值:";
            // 
            // txtLoad_B_Act
            // 
            this.txtLoad_B_Act.EnableNull = true;
            this.txtLoad_B_Act.ErropPr = this.errorProvider1;
            this.txtLoad_B_Act.Length = 0;
            this.txtLoad_B_Act.Location = new System.Drawing.Point(132, 43);
            this.txtLoad_B_Act.Max = 0;
            this.txtLoad_B_Act.MaxStrLength = 0;
            this.txtLoad_B_Act.Min = 0;
            this.txtLoad_B_Act.MinStrLength = 0;
            this.txtLoad_B_Act.Name = "txtLoad_B_Act";
            this.txtLoad_B_Act.Precision = 0;
            this.txtLoad_B_Act.Size = new System.Drawing.Size(141, 21);
            this.txtLoad_B_Act.TabIndex = 2;
            this.txtLoad_B_Act.ToolTipValid = this.toolTip1;
            this.txtLoad_B_Act.ValidEable = true;
            this.txtLoad_B_Act.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 114;
            this.label2.Text = "调整前加载示值:";
            // 
            // txtLoad_B_Std
            // 
            this.txtLoad_B_Std.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Rep_Ladle_Bot", true));
            this.txtLoad_B_Std.EnableNull = true;
            this.txtLoad_B_Std.ErropPr = this.errorProvider1;
            this.txtLoad_B_Std.Length = 0;
            this.txtLoad_B_Std.Location = new System.Drawing.Point(132, 16);
            this.txtLoad_B_Std.Max = 0;
            this.txtLoad_B_Std.MaxStrLength = 0;
            this.txtLoad_B_Std.Min = 0;
            this.txtLoad_B_Std.MinStrLength = 0;
            this.txtLoad_B_Std.Name = "txtLoad_B_Std";
            this.txtLoad_B_Std.Precision = 0;
            this.txtLoad_B_Std.Size = new System.Drawing.Size(141, 21);
            this.txtLoad_B_Std.TabIndex = 1;
            this.txtLoad_B_Std.ToolTipValid = this.toolTip1;
            this.txtLoad_B_Std.ValidEable = true;
            this.txtLoad_B_Std.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Location = new System.Drawing.Point(31, 19);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 12);
            this.label39.TabIndex = 114;
            this.label39.Text = "调整前加载标值:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(463, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(382, 230);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // EquipAdjustDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 265);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EquipAdjustDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备校准实绩维护界面";
            this.Load += new System.EventHandler(this.FinLadleDreShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private PxDataValid.PxTextBox txtLoad_B_Std;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Data.DataColumn coldsMainL3DataTableCha_Dre_Lin_Per;
        private System.Data.DataColumn coldsMainL3DataTableCha_Dre_Lin_Wast;
        private PxDataValid.PxTextBox txtLoad_A_Std;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtUnLoad_A_Dif;
        private System.Windows.Forms.Label label21;
        private PxDataValid.PxTextBox txtUnLoad_B_Dif;
        private System.Windows.Forms.Label label6;
        private PxDataValid.PxTextBox txtUnLoad_A_Act;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxTextBox txtUnLoad_B_Act;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxTextBox txtUnLoad_A_Std;
        private System.Windows.Forms.Label label9;
        private PxDataValid.PxTextBox txtUnLoad_B_Std;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxTextBox txtLoad_A_Dif;
        private System.Windows.Forms.Label label8;
        private PxDataValid.PxTextBox txtLoad_B_Dif;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxTextBox txtLoad_A_Act;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxTextBox txtLoad_B_Act;
        private System.Windows.Forms.Label label2;
    }
}