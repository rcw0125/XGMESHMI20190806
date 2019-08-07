namespace EquipMag.VacTubeMag
{
    partial class VacTubeFireMagShowFrm
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
            this.coldsMainL3DataTableVacTube_Code = new System.Data.DataColumn();
            this.coldsMainL3DataTableInstall_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTablePosition = new System.Data.DataColumn();
            this.coldsMainL3DataTableUp_Slot_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBel_Slot_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableLog_Per = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.coldsMainL3DataTableObject_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFire_Soruce = new System.Data.DataColumn();
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
            this.cmbUpSlotID = new PxDataValid.PxComboBox();
            this.dsUpSlotID = new AppSvrHMI.L3DataSet();
            this.schemadsUpSlotID = new System.Data.DataTable();
            this.coldsUpSlotIDL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBelSlotID = new PxDataValid.PxComboBox();
            this.dsBelSlotID = new AppSvrHMI.L3DataSet();
            this.schemadsBelSlotID = new System.Data.DataTable();
            this.coldsBelSlotIDL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label44 = new System.Windows.Forms.Label();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label45 = new System.Windows.Forms.Label();
            this.txtLogPer = new PxDataValid.PxTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPosition = new PxDataValid.PxComboBox();
            this.dsPossition = new AppSvrHMI.L3DataSet();
            this.schemadsPossition = new System.Data.DataTable();
            this.coldsPossitionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPossitionL3DataTableCode_Des = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsUpSlotID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUpSlotID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBelSlotID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBelSlotID)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPossition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPossition)).BeginInit();
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
            this.coldsMainL3DataTableVacTube_Code,
            this.coldsMainL3DataTableInstall_ID,
            this.coldsMainL3DataTablePosition,
            this.coldsMainL3DataTableUp_Slot_ID,
            this.coldsMainL3DataTableBel_Slot_ID,
            this.coldsMainL3DataTableFire_Start_Time,
            this.coldsMainL3DataTableFire_End_Time,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableLog_Per,
            this.coldsMainL3DataTableNote,
            this.coldsMainL3DataTableObject_ID,
            this.coldsMainL3DataTableFire_Soruce});
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
            // coldsMainL3DataTableVacTube_Code
            // 
            this.coldsMainL3DataTableVacTube_Code.Caption = "VacTube_Code";
            this.coldsMainL3DataTableVacTube_Code.ColumnName = "VacTube_Code";
            this.coldsMainL3DataTableVacTube_Code.Namespace = "";
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
            // coldsMainL3DataTableLog_Per
            // 
            this.coldsMainL3DataTableLog_Per.Caption = "Log_Per";
            this.coldsMainL3DataTableLog_Per.ColumnName = "Log_Per";
            this.coldsMainL3DataTableLog_Per.Namespace = "";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // coldsMainL3DataTableObject_ID
            // 
            this.coldsMainL3DataTableObject_ID.Caption = "Object_ID";
            this.coldsMainL3DataTableObject_ID.ColumnName = "Object_ID";
            this.coldsMainL3DataTableObject_ID.Namespace = "";
            // 
            // coldsMainL3DataTableFire_Soruce
            // 
            this.coldsMainL3DataTableFire_Soruce.Caption = "Fire_Soruce";
            this.coldsMainL3DataTableFire_Soruce.ColumnName = "Fire_Soruce";
            this.coldsMainL3DataTableFire_Soruce.DataType = typeof(int);
            this.coldsMainL3DataTableFire_Soruce.Namespace = "";
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
            this.btnCancel.Location = new System.Drawing.Point(401, 3);
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
            this.btnConfirm.Location = new System.Drawing.Point(320, 3);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 284);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(479, 67);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cmbUpSlotID
            // 
            this.cmbUpSlotID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUpSlotID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUpSlotID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "UP_SLOT_ID", true));
            this.cmbUpSlotID.DataSource = this.dsUpSlotID;
            this.cmbUpSlotID.DisplayMember = "L3DataTable.VacTube_ID";
            this.cmbUpSlotID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpSlotID.EnableNull = false;
            this.cmbUpSlotID.ErropPr = null;
            this.cmbUpSlotID.FormattingEnabled = true;
            this.cmbUpSlotID.Location = new System.Drawing.Point(86, 125);
            this.cmbUpSlotID.Name = "cmbUpSlotID";
            this.cmbUpSlotID.Size = new System.Drawing.Size(141, 20);
            this.cmbUpSlotID.TabIndex = 4;
            this.cmbUpSlotID.ToolTipValid = null;
            this.cmbUpSlotID.ValidEable = true;
            this.cmbUpSlotID.ValueMember = "L3DataTable.VacTube_ID";
            // 
            // dsUpSlotID
            // 
            this.dsUpSlotID.AutoSubscribe = false;
            this.dsUpSlotID.DataSetName = "L3DataSet";
            this.dsUpSlotID.DeleteMethod = null;
            this.dsUpSlotID.InsertMethod = null;
            this.dsUpSlotID.L3DataAdapter = this.Adapter;
            this.dsUpSlotID.LoadEvent = "Click";
            this.dsUpSlotID.LoadTrigger = null;
            this.dsUpSlotID.RefreshValve = 1000;
            this.dsUpSlotID.SourceCommand = null;
            this.dsUpSlotID.SourceCondition = "VACTUBE_NAME = \'1\'";
            this.dsUpSlotID.SourceMethod = "";
            this.dsUpSlotID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUpSlotID.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsUpSlotID.SubscribeTarget = null;
            this.dsUpSlotID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUpSlotID});
            this.dsUpSlotID.UpdateEvent = "Click";
            this.dsUpSlotID.UpdateMethod = null;
            this.dsUpSlotID.UpdateTrigger = null;
            // 
            // schemadsUpSlotID
            // 
            this.schemadsUpSlotID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUpSlotIDL3DataTableVacTube_ID});
            this.schemadsUpSlotID.TableName = "L3DataTable";
            // 
            // coldsUpSlotIDL3DataTableVacTube_ID
            // 
            this.coldsUpSlotIDL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsUpSlotIDL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsUpSlotIDL3DataTableVacTube_ID.Namespace = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(13, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 12);
            this.label21.TabIndex = 64;
            this.label21.Text = "下部槽编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "上部槽编号:";
            // 
            // cmbBelSlotID
            // 
            this.cmbBelSlotID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBelSlotID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBelSlotID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "BEL_SLOT_ID", true));
            this.cmbBelSlotID.DataSource = this.dsBelSlotID;
            this.cmbBelSlotID.DisplayMember = "L3DataTable.VacTube_ID";
            this.cmbBelSlotID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBelSlotID.EnableNull = false;
            this.cmbBelSlotID.ErropPr = null;
            this.cmbBelSlotID.FormattingEnabled = true;
            this.cmbBelSlotID.Location = new System.Drawing.Point(86, 151);
            this.cmbBelSlotID.Name = "cmbBelSlotID";
            this.cmbBelSlotID.Size = new System.Drawing.Size(141, 20);
            this.cmbBelSlotID.TabIndex = 5;
            this.cmbBelSlotID.ToolTipValid = null;
            this.cmbBelSlotID.ValidEable = true;
            this.cmbBelSlotID.ValueMember = "L3DataTable.VacTube_ID";
            // 
            // dsBelSlotID
            // 
            this.dsBelSlotID.AutoSubscribe = false;
            this.dsBelSlotID.DataSetName = "L3DataSet";
            this.dsBelSlotID.DeleteMethod = null;
            this.dsBelSlotID.InsertMethod = null;
            this.dsBelSlotID.L3DataAdapter = this.Adapter;
            this.dsBelSlotID.LoadEvent = "Click";
            this.dsBelSlotID.LoadTrigger = null;
            this.dsBelSlotID.RefreshValve = 1000;
            this.dsBelSlotID.SourceCommand = null;
            this.dsBelSlotID.SourceCondition = "VACTUBE_NAME = \'2\'";
            this.dsBelSlotID.SourceMethod = "";
            this.dsBelSlotID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBelSlotID.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsBelSlotID.SubscribeTarget = null;
            this.dsBelSlotID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBelSlotID});
            this.dsBelSlotID.UpdateEvent = "Click";
            this.dsBelSlotID.UpdateMethod = null;
            this.dsBelSlotID.UpdateTrigger = null;
            // 
            // schemadsBelSlotID
            // 
            this.schemadsBelSlotID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBelSlotIDL3DataTableVacTube_ID});
            this.schemadsBelSlotID.TableName = "L3DataTable";
            // 
            // coldsBelSlotIDL3DataTableVacTube_ID
            // 
            this.coldsBelSlotIDL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsBelSlotIDL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsBelSlotIDL3DataTableVacTube_ID.Namespace = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbUpSlotID);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.cmbBelSlotID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtLogPer);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cmbPosition);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "烘烤信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = null;
            this.rtxtNote.Location = new System.Drawing.Point(86, 176);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(374, 74);
            this.rtxtNote.TabIndex = 11;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = null;
            this.rtxtNote.ValidEable = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(49, 179);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 82;
            this.label46.Text = "备注:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(319, 99);
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
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(278, 103);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 80;
            this.label44.Text = "班次:";
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
            this.cmbTeamID.Location = new System.Drawing.Point(319, 74);
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
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(278, 78);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 78;
            this.label45.Text = "班别:";
            // 
            // txtLogPer
            // 
            this.txtLogPer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "LOG_PER", true));
            this.txtLogPer.EnableNull = true;
            this.txtLogPer.ErropPr = null;
            this.txtLogPer.Length = 0;
            this.txtLogPer.Location = new System.Drawing.Point(319, 125);
            this.txtLogPer.Max = 0;
            this.txtLogPer.MaxStrLength = 0;
            this.txtLogPer.Min = 0;
            this.txtLogPer.MinStrLength = 0;
            this.txtLogPer.Name = "txtLogPer";
            this.txtLogPer.Precision = 0;
            this.txtLogPer.Size = new System.Drawing.Size(141, 21);
            this.txtLogPer.TabIndex = 10;
            this.txtLogPer.ToolTipValid = null;
            this.txtLogPer.ValidEable = true;
            this.txtLogPer.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Install_ID", true));
            this.textBox3.Location = new System.Drawing.Point(86, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(141, 21);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(266, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "记录人:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_End_Time", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(319, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Fire_Start_Time", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(254, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 12);
            this.label23.TabIndex = 60;
            this.label23.Text = "停火时间:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "INPUT_TIME", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(86, 22);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(254, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 60;
            this.label22.Text = "点火时间:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "VacTube_Code", true));
            this.textBox2.Location = new System.Drawing.Point(86, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "录入时间:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(13, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 57;
            this.label7.Text = "真空槽编号:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(25, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 57;
            this.label9.Text = "组装编号:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "POSITION", true));
            this.cmbPosition.DataSource = this.dsPossition;
            this.cmbPosition.DisplayMember = "L3DataTable.Code_Des";
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.EnableNull = false;
            this.cmbPosition.ErropPr = null;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(86, 99);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(141, 20);
            this.cmbPosition.TabIndex = 3;
            this.cmbPosition.ToolTipValid = null;
            this.cmbPosition.ValidEable = true;
            this.cmbPosition.ValueMember = "L3DataTable.Code";
            // 
            // dsPossition
            // 
            this.dsPossition.AutoSubscribe = false;
            this.dsPossition.DataSetName = "L3DataSet";
            this.dsPossition.DeleteMethod = null;
            this.dsPossition.InsertMethod = null;
            this.dsPossition.L3DataAdapter = this.Adapter;
            this.dsPossition.LoadEvent = "Click";
            this.dsPossition.LoadTrigger = null;
            this.dsPossition.RefreshValve = 1000;
            this.dsPossition.SourceCommand = null;
            this.dsPossition.SourceCondition = "CODE_GROUP = \'VacTube_Position\' and CODE <> \'1\'";
            this.dsPossition.SourceMethod = "";
            this.dsPossition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPossition.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPossition.SubscribeTarget = null;
            this.dsPossition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPossition});
            this.dsPossition.UpdateEvent = "Click";
            this.dsPossition.UpdateMethod = null;
            this.dsPossition.UpdateTrigger = null;
            // 
            // schemadsPossition
            // 
            this.schemadsPossition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPossitionL3DataTableCode,
            this.coldsPossitionL3DataTableCode_Des});
            this.schemadsPossition.TableName = "L3DataTable";
            // 
            // coldsPossitionL3DataTableCode
            // 
            this.coldsPossitionL3DataTableCode.Caption = "Code";
            this.coldsPossitionL3DataTableCode.ColumnName = "Code";
            this.coldsPossitionL3DataTableCode.Namespace = "";
            // 
            // coldsPossitionL3DataTableCode_Des
            // 
            this.coldsPossitionL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsPossitionL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsPossitionL3DataTableCode_Des.Namespace = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(49, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "位置:";
            // 
            // VacTubeFireMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 351);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VacTubeFireMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "真空槽烘烤主信息";
            this.Load += new System.EventHandler(this.VacTubeFireMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsUpSlotID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUpSlotID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBelSlotID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBelSlotID)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPossition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPossition)).EndInit();
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
        private AppSvrHMI.L3DataSet dsUpSlotID;
        private AppSvrHMI.L3DataSet dsBelSlotID;
        private System.Data.DataTable schemadsUpSlotID;
        private System.Data.DataColumn coldsUpSlotIDL3DataTableVacTube_ID;
        private System.Data.DataTable schemadsBelSlotID;
        private System.Data.DataColumn coldsBelSlotIDL3DataTableVacTube_ID;
        private AppSvrHMI.L3DataSet dsPossition;
        private System.Data.DataTable schemadsPossition;
        private System.Data.DataColumn coldsPossitionL3DataTableCode;
        private System.Data.DataColumn coldsPossitionL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbBelSlotID;
        private PxDataValid.PxComboBox cmbUpSlotID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxComboBox cmbShiftID;
        private System.Windows.Forms.Label label44;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label45;
        private PxDataValid.PxTextBox txtLogPer;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private PxDataValid.PxComboBox cmbPosition;
        private System.Windows.Forms.Label label5;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableVacTube_Code;
        private System.Data.DataColumn coldsMainL3DataTableInstall_ID;
        private System.Data.DataColumn coldsMainL3DataTablePosition;
        private System.Data.DataColumn coldsMainL3DataTableUp_Slot_ID;
        private System.Data.DataColumn coldsMainL3DataTableBel_Slot_ID;
        private System.Data.DataColumn coldsMainL3DataTableFire_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableFire_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableLog_Per;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private System.Data.DataColumn coldsMainL3DataTableObject_ID;
        private System.Data.DataColumn coldsMainL3DataTableFire_Soruce;
    }
}