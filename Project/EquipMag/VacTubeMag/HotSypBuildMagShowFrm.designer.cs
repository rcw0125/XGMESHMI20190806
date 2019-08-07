namespace EquipMag.VacTubeMag
{
    partial class HotSypBuildMagShowFrm
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
            this.coldsMainL3DataTableHot_Syp_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBuild_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableBuild_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableRefra_Fac = new System.Data.DataColumn();
            this.coldsMainL3DataTableHot_Syp_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableBear_Fir_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableSi_Ca_Boa_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableLight_Mat_Bri_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableMaintain_Case = new System.Data.DataColumn();
            this.coldsMainL3DataTableMaintain_Per = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste = new System.Data.DataColumn();
            this.coldsMainL3DataTableCast_Wast = new System.Data.DataColumn();
            this.coldsMainL3DataTableBuild_ID = new System.Data.DataColumn();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
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
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtBuildEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtBuildStartTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRefraFac = new PxDataValid.PxComboBox();
            this.dsFac = new AppSvrHMI.L3DataSet();
            this.schemadsFac = new System.Data.DataTable();
            this.coldsFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.cmbHotSypID = new PxDataValid.PxComboBox();
            this.dsHotSpyID = new AppSvrHMI.L3DataSet();
            this.schemadsHotSpyID = new System.Data.DataTable();
            this.coldsHotSpyIDL3DataTableVacTube_Id = new System.Data.DataColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHotSpyID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHotSpyID)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = null;
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Hot_Syp_Bui";
            this.dsMain.SubscribeTarget = null;
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
            this.coldsMainL3DataTableHot_Syp_ID,
            this.coldsMainL3DataTableBuild_Start_Time,
            this.coldsMainL3DataTableBuild_End_Time,
            this.coldsMainL3DataTableRefra_Fac,
            this.coldsMainL3DataTableHot_Syp_Age,
            this.coldsMainL3DataTableBear_Fir_Waste,
            this.coldsMainL3DataTableSi_Ca_Boa_Waste,
            this.coldsMainL3DataTableLight_Mat_Bri_Waste,
            this.coldsMainL3DataTableMaintain_Case,
            this.coldsMainL3DataTableMaintain_Per,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableNote,
            this.coldsMainL3DataTableMg_Cr_Bri_Dir_Waste,
            this.coldsMainL3DataTableMg_Cr_Bri_Half_Waste,
            this.coldsMainL3DataTableCast_Wast,
            this.coldsMainL3DataTableBuild_ID});
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
            // coldsMainL3DataTableHot_Syp_ID
            // 
            this.coldsMainL3DataTableHot_Syp_ID.Caption = "Hot_Syp_ID";
            this.coldsMainL3DataTableHot_Syp_ID.ColumnName = "Hot_Syp_ID";
            this.coldsMainL3DataTableHot_Syp_ID.Namespace = "";
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
            // coldsMainL3DataTableRefra_Fac
            // 
            this.coldsMainL3DataTableRefra_Fac.Caption = "Refra_Fac";
            this.coldsMainL3DataTableRefra_Fac.ColumnName = "Refra_Fac";
            this.coldsMainL3DataTableRefra_Fac.Namespace = "";
            // 
            // coldsMainL3DataTableHot_Syp_Age
            // 
            this.coldsMainL3DataTableHot_Syp_Age.Caption = "Hot_Syp_Age";
            this.coldsMainL3DataTableHot_Syp_Age.ColumnName = "Hot_Syp_Age";
            this.coldsMainL3DataTableHot_Syp_Age.DataType = typeof(int);
            this.coldsMainL3DataTableHot_Syp_Age.Namespace = "";
            // 
            // coldsMainL3DataTableBear_Fir_Waste
            // 
            this.coldsMainL3DataTableBear_Fir_Waste.Caption = "Bear_Fir_Waste";
            this.coldsMainL3DataTableBear_Fir_Waste.ColumnName = "Bear_Fir_Waste";
            this.coldsMainL3DataTableBear_Fir_Waste.DataType = typeof(double);
            this.coldsMainL3DataTableBear_Fir_Waste.Namespace = "";
            // 
            // coldsMainL3DataTableSi_Ca_Boa_Waste
            // 
            this.coldsMainL3DataTableSi_Ca_Boa_Waste.Caption = "Si_Ca_Boa_Waste";
            this.coldsMainL3DataTableSi_Ca_Boa_Waste.ColumnName = "Si_Ca_Boa_Waste";
            this.coldsMainL3DataTableSi_Ca_Boa_Waste.DataType = typeof(double);
            this.coldsMainL3DataTableSi_Ca_Boa_Waste.Namespace = "";
            // 
            // coldsMainL3DataTableLight_Mat_Bri_Waste
            // 
            this.coldsMainL3DataTableLight_Mat_Bri_Waste.Caption = "Light_Mat_Bri_Waste";
            this.coldsMainL3DataTableLight_Mat_Bri_Waste.ColumnName = "Light_Mat_Bri_Waste";
            this.coldsMainL3DataTableLight_Mat_Bri_Waste.DataType = typeof(double);
            this.coldsMainL3DataTableLight_Mat_Bri_Waste.Namespace = "";
            // 
            // coldsMainL3DataTableMaintain_Case
            // 
            this.coldsMainL3DataTableMaintain_Case.Caption = "Maintain_Case";
            this.coldsMainL3DataTableMaintain_Case.ColumnName = "Maintain_Case";
            this.coldsMainL3DataTableMaintain_Case.Namespace = "";
            // 
            // coldsMainL3DataTableMaintain_Per
            // 
            this.coldsMainL3DataTableMaintain_Per.Caption = "Maintain_Per";
            this.coldsMainL3DataTableMaintain_Per.ColumnName = "Maintain_Per";
            this.coldsMainL3DataTableMaintain_Per.Namespace = "";
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
            this.btnCancel.Location = new System.Drawing.Point(462, 3);
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
            this.btnConfirm.Location = new System.Drawing.Point(381, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.textBox9);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dtBuildEndTime);
            this.tabPage1.Controls.Add(this.dtBuildStartTime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbRefraFac);
            this.tabPage1.Controls.Add(this.cmbHotSypID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RH炉热弯管砌筑实绩信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Mg_Cr_Bri_Half_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox7.Location = new System.Drawing.Point(375, 86);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(141, 21);
            this.textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Mg_Cr_Bri_Dir_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox6.Location = new System.Drawing.Point(375, 59);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 21);
            this.textBox6.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bear_Fir_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox4.Location = new System.Drawing.Point(375, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 21);
            this.textBox4.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Si_Ca_Boa_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox10.Location = new System.Drawing.Point(375, 113);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(141, 21);
            this.textBox10.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Cast_Wast", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox9.Location = new System.Drawing.Point(375, 167);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(141, 21);
            this.textBox9.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Light_Mat_Bri_Waste", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N3"));
            this.textBox8.Location = new System.Drawing.Point(375, 140);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(141, 21);
            this.textBox8.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Hot_Syp_Age", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N0"));
            this.textBox3.Location = new System.Drawing.Point(104, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 21);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Build_ID", true));
            this.textBox2.Location = new System.Drawing.Point(104, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 21);
            this.textBox2.TabIndex = 1;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = null;
            this.rtxtNote.Location = new System.Drawing.Point(104, 221);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(412, 88);
            this.rtxtNote.TabIndex = 16;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = null;
            this.rtxtNote.ValidEable = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(304, 171);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 12);
            this.label28.TabIndex = 124;
            this.label28.Text = "浇注料[t]:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(250, 90);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 12);
            this.label31.TabIndex = 122;
            this.label31.Text = "半再结合Mg-Cr砖[t]:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(250, 63);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(119, 12);
            this.label30.TabIndex = 121;
            this.label30.Text = "直接结合Mg-Cr砖[t]:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(63, 221);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 116;
            this.label46.Text = "备注:";
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
            this.cmbShiftID.Location = new System.Drawing.Point(104, 195);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 7;
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
            this.cmbTeamID.Location = new System.Drawing.Point(104, 167);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 6;
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
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(375, 195);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 15;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(63, 199);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 111;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(63, 171);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 112;
            this.label45.Text = "班别:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(322, 199);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(47, 12);
            this.label26.TabIndex = 110;
            this.label26.Text = "责任人:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(304, 144);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 104;
            this.label24.Text = "轻质砖[t]:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(304, 117);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 103;
            this.label25.Text = "硅钙板[t]:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(304, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 92;
            this.label8.Text = "耐火泥[t]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(63, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 94;
            this.label9.Text = "寿命:";
            // 
            // dtBuildEndTime
            // 
            this.dtBuildEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Build_End_Time", true));
            this.dtBuildEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildEndTime.Location = new System.Drawing.Point(104, 113);
            this.dtBuildEndTime.Name = "dtBuildEndTime";
            this.dtBuildEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtBuildEndTime.TabIndex = 4;
            // 
            // dtBuildStartTime
            // 
            this.dtBuildStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtBuildStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Build_Start_Time", true));
            this.dtBuildStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBuildStartTime.Location = new System.Drawing.Point(104, 86);
            this.dtBuildStartTime.Name = "dtBuildStartTime";
            this.dtBuildStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtBuildStartTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 86;
            this.label1.Text = "砌筑结束时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 87;
            this.label2.Text = "砌筑开始时间:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(104, 6);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 84;
            this.label3.Text = "录入时间:";
            // 
            // cmbRefraFac
            // 
            this.cmbRefraFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefraFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefraFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Refra_Fac", true));
            this.cmbRefraFac.DataSource = this.dsFac;
            this.cmbRefraFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbRefraFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefraFac.EnableNull = true;
            this.cmbRefraFac.ErropPr = null;
            this.cmbRefraFac.FormattingEnabled = true;
            this.cmbRefraFac.Location = new System.Drawing.Point(375, 6);
            this.cmbRefraFac.Name = "cmbRefraFac";
            this.cmbRefraFac.Size = new System.Drawing.Size(141, 20);
            this.cmbRefraFac.TabIndex = 8;
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
            // cmbHotSypID
            // 
            this.cmbHotSypID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbHotSypID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHotSypID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Hot_Syp_ID", true));
            this.cmbHotSypID.DataSource = this.dsHotSpyID;
            this.cmbHotSypID.DisplayMember = "L3DataTable.VacTube_Id";
            this.cmbHotSypID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotSypID.EnableNull = false;
            this.cmbHotSypID.ErropPr = null;
            this.cmbHotSypID.FormattingEnabled = true;
            this.cmbHotSypID.Location = new System.Drawing.Point(104, 59);
            this.cmbHotSypID.Name = "cmbHotSypID";
            this.cmbHotSypID.Size = new System.Drawing.Size(141, 20);
            this.cmbHotSypID.TabIndex = 2;
            this.cmbHotSypID.ToolTipValid = null;
            this.cmbHotSypID.ValidEable = true;
            this.cmbHotSypID.ValueMember = "L3DataTable.VacTube_Id";
            // 
            // dsHotSpyID
            // 
            this.dsHotSpyID.AutoSubscribe = false;
            this.dsHotSpyID.DataSetName = "L3DataSet";
            this.dsHotSpyID.DeleteMethod = null;
            this.dsHotSpyID.InsertMethod = null;
            this.dsHotSpyID.L3DataAdapter = this.Adapter;
            this.dsHotSpyID.LoadEvent = "Click";
            this.dsHotSpyID.LoadTrigger = null;
            this.dsHotSpyID.RefreshValve = 1000;
            this.dsHotSpyID.SourceCommand = null;
            this.dsHotSpyID.SourceCondition = "VACTUBE_NAME = \'3\'";
            this.dsHotSpyID.SourceMethod = "";
            this.dsHotSpyID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHotSpyID.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsHotSpyID.SubscribeTarget = null;
            this.dsHotSpyID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHotSpyID});
            this.dsHotSpyID.UpdateEvent = "Click";
            this.dsHotSpyID.UpdateMethod = null;
            this.dsHotSpyID.UpdateTrigger = null;
            // 
            // schemadsHotSpyID
            // 
            this.schemadsHotSpyID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHotSpyIDL3DataTableVacTube_Id});
            this.schemadsHotSpyID.TableName = "L3DataTable";
            // 
            // coldsHotSpyIDL3DataTableVacTube_Id
            // 
            this.coldsHotSpyIDL3DataTableVacTube_Id.Caption = "VacTube_Id";
            this.coldsHotSpyIDL3DataTableVacTube_Id.ColumnName = "VacTube_Id";
            this.coldsHotSpyIDL3DataTableVacTube_Id.Namespace = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(310, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 80;
            this.label4.Text = "耐材厂家:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(39, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 81;
            this.label6.Text = "砌筑编号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(27, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 81;
            this.label5.Text = "热弯管编号:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 347);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(540, 43);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // HotSypBuildMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 390);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HotSypBuildMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RH炉热弯管砌筑实绩信息维护";
            this.Load += new System.EventHandler(this.HotSypBuildMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHotSpyID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHotSpyID)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker dtBuildEndTime;
        private System.Windows.Forms.DateTimePicker dtBuildStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxComboBox cmbRefraFac;
        private PxDataValid.PxComboBox cmbHotSypID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label26;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsHotSpyID;
        private System.Data.DataTable schemadsHotSpyID;
        private System.Data.DataColumn coldsHotSpyIDL3DataTableVacTube_Id;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableHot_Syp_ID;
        private System.Data.DataColumn coldsMainL3DataTableBuild_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableBuild_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableRefra_Fac;
        private System.Data.DataColumn coldsMainL3DataTableHot_Syp_Age;
        private System.Data.DataColumn coldsMainL3DataTableBear_Fir_Waste;
        private System.Data.DataColumn coldsMainL3DataTableSi_Ca_Boa_Waste;
        private System.Data.DataColumn coldsMainL3DataTableLight_Mat_Bri_Waste;
        private System.Data.DataColumn coldsMainL3DataTableMaintain_Case;
        private System.Data.DataColumn coldsMainL3DataTableMaintain_Per;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label28;
        private System.Data.DataColumn coldsMainL3DataTableMg_Cr_Bri_Dir_Waste;
        private System.Data.DataColumn coldsMainL3DataTableMg_Cr_Bri_Half_Waste;
        private System.Data.DataColumn coldsMainL3DataTableCast_Wast;
        private AppSvrHMI.L3DataSet dsFac;
        private System.Data.DataTable schemadsFac;
        private System.Data.DataColumn coldsFacL3DataTableMatFactory;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Data.DataColumn coldsMainL3DataTableBuild_ID;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}