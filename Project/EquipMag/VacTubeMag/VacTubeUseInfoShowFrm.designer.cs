﻿namespace EquipMag.VacTubeMag
{
    partial class VacTubeUseInfoShowFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        

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
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableInstall_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTablePosition = new System.Data.DataColumn();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsMainL3DataTableVacTube_Code = new System.Data.DataColumn();
            this.coldsMainL3DataTableUp_Slot_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBel_Slot_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableUp_Total_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableBel_Total_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableCir_Total_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableAes_Soa_On_Len = new System.Data.DataColumn();
            this.coldsMainL3DataTableAes_Soa_Total_Len = new System.Data.DataColumn();
            this.coldsMainL3DataTableAes_Soa_Total_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableDes_Soa_On_Len = new System.Data.DataColumn();
            this.coldsMainL3DataTableDes_Soa_Total_Len = new System.Data.DataColumn();
            this.coldsMainL3DataTableDes_Soa_Total_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label46 = new System.Windows.Forms.Label();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label24 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
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
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableInput_Time,
            this.coldsMainL3DataTableInstall_ID,
            this.coldsMainL3DataTablePosition,
            this.coldsMainL3DataTableHeatID,
            this.coldsMainL3DataTableSteelGrade,
            this.coldsMainL3DataTableVacTube_Code,
            this.coldsMainL3DataTableUp_Slot_ID,
            this.coldsMainL3DataTableBel_Slot_ID,
            this.coldsMainL3DataTableUp_Total_Age,
            this.coldsMainL3DataTableBel_Total_Age,
            this.coldsMainL3DataTableCir_Total_Age,
            this.coldsMainL3DataTableAes_Soa_On_Len,
            this.coldsMainL3DataTableAes_Soa_Total_Len,
            this.coldsMainL3DataTableAes_Soa_Total_Age,
            this.coldsMainL3DataTableDes_Soa_On_Len,
            this.coldsMainL3DataTableDes_Soa_Total_Len,
            this.coldsMainL3DataTableDes_Soa_Total_Age,
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
            // coldsMainL3DataTableInstall_ID
            // 
            this.coldsMainL3DataTableInstall_ID.Caption = "Install_ID";
            this.coldsMainL3DataTableInstall_ID.ColumnName = "Install_ID";
            this.coldsMainL3DataTableInstall_ID.Namespace = "";
            // 
            // coldsMainL3DataTablePosition
            // 
            this.coldsMainL3DataTablePosition.Caption = "Position";
            this.coldsMainL3DataTablePosition.ColumnName = "Position";
            this.coldsMainL3DataTablePosition.Namespace = "";
            // 
            // coldsMainL3DataTableHeatID
            // 
            this.coldsMainL3DataTableHeatID.Caption = "HeatID";
            this.coldsMainL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMainL3DataTableHeatID.Namespace = "";
            // 
            // coldsMainL3DataTableSteelGrade
            // 
            this.coldsMainL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsMainL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsMainL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsMainL3DataTableVacTube_Code
            // 
            this.coldsMainL3DataTableVacTube_Code.Caption = "VacTube_Code";
            this.coldsMainL3DataTableVacTube_Code.ColumnName = "VacTube_Code";
            this.coldsMainL3DataTableVacTube_Code.Namespace = "";
            // 
            // coldsMainL3DataTableUp_Slot_ID
            // 
            this.coldsMainL3DataTableUp_Slot_ID.Caption = "Up_Slot_ID";
            this.coldsMainL3DataTableUp_Slot_ID.ColumnName = "Up_Slot_ID";
            this.coldsMainL3DataTableUp_Slot_ID.Namespace = "";
            // 
            // coldsMainL3DataTableBel_Slot_ID
            // 
            this.coldsMainL3DataTableBel_Slot_ID.Caption = "Bel_Slot_ID";
            this.coldsMainL3DataTableBel_Slot_ID.ColumnName = "Bel_Slot_ID";
            this.coldsMainL3DataTableBel_Slot_ID.Namespace = "";
            // 
            // coldsMainL3DataTableUp_Total_Age
            // 
            this.coldsMainL3DataTableUp_Total_Age.Caption = "Up_Total_Age";
            this.coldsMainL3DataTableUp_Total_Age.ColumnName = "Up_Total_Age";
            this.coldsMainL3DataTableUp_Total_Age.DataType = typeof(int);
            this.coldsMainL3DataTableUp_Total_Age.Namespace = "";
            // 
            // coldsMainL3DataTableBel_Total_Age
            // 
            this.coldsMainL3DataTableBel_Total_Age.Caption = "Bel_Total_Age";
            this.coldsMainL3DataTableBel_Total_Age.ColumnName = "Bel_Total_Age";
            this.coldsMainL3DataTableBel_Total_Age.DataType = typeof(int);
            this.coldsMainL3DataTableBel_Total_Age.Namespace = "";
            // 
            // coldsMainL3DataTableCir_Total_Age
            // 
            this.coldsMainL3DataTableCir_Total_Age.Caption = "Cir_Total_Age";
            this.coldsMainL3DataTableCir_Total_Age.ColumnName = "Cir_Total_Age";
            this.coldsMainL3DataTableCir_Total_Age.DataType = typeof(int);
            this.coldsMainL3DataTableCir_Total_Age.Namespace = "";
            // 
            // coldsMainL3DataTableAes_Soa_On_Len
            // 
            this.coldsMainL3DataTableAes_Soa_On_Len.Caption = "Aes_Soa_On_Len";
            this.coldsMainL3DataTableAes_Soa_On_Len.ColumnName = "Aes_Soa_On_Len";
            this.coldsMainL3DataTableAes_Soa_On_Len.DataType = typeof(int);
            this.coldsMainL3DataTableAes_Soa_On_Len.Namespace = "";
            // 
            // coldsMainL3DataTableAes_Soa_Total_Len
            // 
            this.coldsMainL3DataTableAes_Soa_Total_Len.Caption = "Aes_Soa_Total_Len";
            this.coldsMainL3DataTableAes_Soa_Total_Len.ColumnName = "Aes_Soa_Total_Len";
            this.coldsMainL3DataTableAes_Soa_Total_Len.DataType = typeof(int);
            this.coldsMainL3DataTableAes_Soa_Total_Len.Namespace = "";
            // 
            // coldsMainL3DataTableAes_Soa_Total_Age
            // 
            this.coldsMainL3DataTableAes_Soa_Total_Age.Caption = "Aes_Soa_Total_Age";
            this.coldsMainL3DataTableAes_Soa_Total_Age.ColumnName = "Aes_Soa_Total_Age";
            this.coldsMainL3DataTableAes_Soa_Total_Age.DataType = typeof(int);
            this.coldsMainL3DataTableAes_Soa_Total_Age.Namespace = "";
            // 
            // coldsMainL3DataTableDes_Soa_On_Len
            // 
            this.coldsMainL3DataTableDes_Soa_On_Len.Caption = "Des_Soa_On_Len";
            this.coldsMainL3DataTableDes_Soa_On_Len.ColumnName = "Des_Soa_On_Len";
            this.coldsMainL3DataTableDes_Soa_On_Len.DataType = typeof(int);
            this.coldsMainL3DataTableDes_Soa_On_Len.Namespace = "";
            // 
            // coldsMainL3DataTableDes_Soa_Total_Len
            // 
            this.coldsMainL3DataTableDes_Soa_Total_Len.Caption = "Des_Soa_Total_Len";
            this.coldsMainL3DataTableDes_Soa_Total_Len.ColumnName = "Des_Soa_Total_Len";
            this.coldsMainL3DataTableDes_Soa_Total_Len.DataType = typeof(int);
            this.coldsMainL3DataTableDes_Soa_Total_Len.Namespace = "";
            // 
            // coldsMainL3DataTableDes_Soa_Total_Age
            // 
            this.coldsMainL3DataTableDes_Soa_Total_Age.Caption = "Des_Soa_Total_Age";
            this.coldsMainL3DataTableDes_Soa_Total_Age.ColumnName = "Des_Soa_Total_Age";
            this.coldsMainL3DataTableDes_Soa_Total_Age.DataType = typeof(int);
            this.coldsMainL3DataTableDes_Soa_Total_Age.Namespace = "";
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
            this.btnCancel.Location = new System.Drawing.Point(486, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
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
            this.btnConfirm.Location = new System.Drawing.Point(405, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 404);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(581, 59);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox16);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox15);
            this.tabPage1.Controls.Add(this.textBox18);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox17);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox14);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox13);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "真空槽使用详细信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(54, 275);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 26;
            this.label46.Text = "备注:";
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = null;
            this.rtxtNote.Location = new System.Drawing.Point(95, 275);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(457, 94);
            this.rtxtNote.TabIndex = 20;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = null;
            this.rtxtNote.ValidEable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Position", true));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "A",
            "B"});
            this.comboBox1.Location = new System.Drawing.Point(95, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.textBox12.Location = new System.Drawing.Point(411, 249);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(141, 21);
            this.textBox12.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Up_Total_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox4.Location = new System.Drawing.Point(411, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 21);
            this.textBox4.TabIndex = 10;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "SteelGrade", true));
            this.textBox16.Location = new System.Drawing.Point(95, 194);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(141, 21);
            this.textBox16.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Des_Soa_Total_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox11.Location = new System.Drawing.Point(411, 222);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(141, 21);
            this.textBox11.TabIndex = 18;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Location = new System.Drawing.Point(30, 37);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(59, 12);
            this.label37.TabIndex = 21;
            this.label37.Text = "组装编号:";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Aes_Soa_Total_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox9.Location = new System.Drawing.Point(411, 141);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(141, 21);
            this.textBox9.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "真空槽编号:";
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "HeatID", true));
            this.textBox15.Location = new System.Drawing.Point(95, 167);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(141, 21);
            this.textBox15.TabIndex = 6;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Des_Soa_On_Len", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox18.Location = new System.Drawing.Point(411, 167);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(141, 21);
            this.textBox18.TabIndex = 16;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Des_Soa_Total_Len", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox10.Location = new System.Drawing.Point(411, 194);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(141, 21);
            this.textBox10.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(310, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "上部槽累计寿命:";
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Aes_Soa_On_Len", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox17.Location = new System.Drawing.Point(411, 87);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(141, 21);
            this.textBox17.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Aes_Soa_Total_Len", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox8.Location = new System.Drawing.Point(411, 114);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 21);
            this.textBox8.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(42, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "处理位:";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cir_Total_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox7.Location = new System.Drawing.Point(411, 60);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 21);
            this.textBox7.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(310, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "下部槽累计寿命:";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bel_Total_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox6.Location = new System.Drawing.Point(411, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 21);
            this.textBox6.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(358, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "责任人:";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bel_Slot_ID", true));
            this.textBox14.Location = new System.Drawing.Point(95, 141);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(141, 21);
            this.textBox14.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "VacTube_Code", true));
            this.textBox3.Location = new System.Drawing.Point(95, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(141, 21);
            this.textBox3.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(310, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 12);
            this.label19.TabIndex = 21;
            this.label19.Text = "环流管累计寿命:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(30, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "上部槽号:";
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Up_Slot_ID", true));
            this.textBox13.Location = new System.Drawing.Point(95, 114);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(141, 21);
            this.textBox13.TabIndex = 4;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(280, 91);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(125, 12);
            this.label27.TabIndex = 21;
            this.label27.Text = "上升管在线时长[min]:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Install_ID", true));
            this.textBox2.Location = new System.Drawing.Point(95, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(280, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 12);
            this.label21.TabIndex = 21;
            this.label21.Text = "上升管累计时长[min]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(30, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "下部槽号:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(54, 171);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 21;
            this.label26.Text = "炉号:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(280, 171);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(125, 12);
            this.label28.TabIndex = 21;
            this.label28.Text = "下降管在线时长[min]:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(280, 198);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(125, 12);
            this.label23.TabIndex = 21;
            this.label23.Text = "下降管累计时长[min]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(310, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 12);
            this.label22.TabIndex = 21;
            this.label22.Text = "上升管累计寿命:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(54, 198);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 21;
            this.label25.Text = "钢种:";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "TeamID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(95, 222);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 8;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = true;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
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
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(310, 226);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 12);
            this.label24.TabIndex = 21;
            this.label24.Text = "下降管累计寿命:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(54, 226);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 23;
            this.label45.Text = "班别:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(54, 253);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 24;
            this.label44.Text = "班次:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "录入时间:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(95, 6);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(95, 249);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 9;
            this.cmbShiftID.ToolTipValid = null;
            this.cmbShiftID.ValidEable = true;
            this.cmbShiftID.ValueMember = "L3DataTable.Code";
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
            // VacTubeUseInfoShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 463);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VacTubeUseInfoShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "真空槽使用详细实绩维护";
            this.Load += new System.EventHandler(this.VacTubeUseInfoMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
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
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxComboBox cmbShiftID;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label37;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableInstall_ID;
        private System.Data.DataColumn coldsMainL3DataTablePosition;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableSteelGrade;
        private System.Data.DataColumn coldsMainL3DataTableVacTube_Code;
        private System.Data.DataColumn coldsMainL3DataTableUp_Slot_ID;
        private System.Data.DataColumn coldsMainL3DataTableBel_Slot_ID;
        private System.Data.DataColumn coldsMainL3DataTableUp_Total_Age;
        private System.Data.DataColumn coldsMainL3DataTableBel_Total_Age;
        private System.Data.DataColumn coldsMainL3DataTableCir_Total_Age;
        private System.Data.DataColumn coldsMainL3DataTableAes_Soa_On_Len;
        private System.Data.DataColumn coldsMainL3DataTableAes_Soa_Total_Len;
        private System.Data.DataColumn coldsMainL3DataTableAes_Soa_Total_Age;
        private System.Data.DataColumn coldsMainL3DataTableDes_Soa_On_Len;
        private System.Data.DataColumn coldsMainL3DataTableDes_Soa_Total_Len;
        private System.Data.DataColumn coldsMainL3DataTableDes_Soa_Total_Age;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
    }
}