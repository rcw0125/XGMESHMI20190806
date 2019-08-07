namespace EquipMag.IronLadleMag
{
    partial class IronLadleUseShowFrm 
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableName = new System.Data.DataColumn();
            this.coldsMainL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableIronLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableCheck_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableIronLadle_Age = new System.Data.DataColumn();
            this.coldsMainL3DataTableWall_TEMP = new System.Data.DataColumn();
            this.coldsMainL3DataTableBottom_TEMP = new System.Data.DataColumn();
            this.coldsMainL3DataTableStop_Reason = new System.Data.DataColumn();
            this.coldsMainL3DataTableThrow_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtThrow = new System.Windows.Forms.DateTimePicker();
            this.cmbShiftID = new PxDataValid.PxComboBox();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtThrow = new PxDataValid.PxTextBox();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.label45 = new System.Windows.Forms.Label();
            this.txtAge = new PxDataValid.PxTextBox();
            this.txtBottomTEMP = new PxDataValid.PxTextBox();
            this.txtWallTEMP = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStopReason = new PxDataValid.PxComboBox();
            this.dsStopReason = new AppSvrHMI.L3DataSet();
            this.schemadsStopReason = new System.Data.DataTable();
            this.coldsStopReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsStopReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIronLadleID = new PxDataValid.PxComboBox();
            this.dsIronLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadleID = new System.Data.DataTable();
            this.coldsIronLadleIDL3DataTableIronLadleID = new System.Data.DataColumn();
            this.dtCheck = new System.Windows.Forms.DateTimePicker();
            this.dtInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.cmdGetAge = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStopReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStopReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).BeginInit();
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
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = this.Adapter;
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableName,
            this.coldsMainL3DataTableInput_Time,
            this.coldsMainL3DataTableIronLadleID,
            this.coldsMainL3DataTableCheck_Time,
            this.coldsMainL3DataTableIronLadle_Age,
            this.coldsMainL3DataTableWall_TEMP,
            this.coldsMainL3DataTableBottom_TEMP,
            this.coldsMainL3DataTableStop_Reason,
            this.coldsMainL3DataTableThrow_Time,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableOperator});
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
            // coldsMainL3DataTableIronLadleID
            // 
            this.coldsMainL3DataTableIronLadleID.Caption = "IronLadleID";
            this.coldsMainL3DataTableIronLadleID.ColumnName = "IronLadleID";
            this.coldsMainL3DataTableIronLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableCheck_Time
            // 
            this.coldsMainL3DataTableCheck_Time.Caption = "Check_Time";
            this.coldsMainL3DataTableCheck_Time.ColumnName = "Check_Time";
            this.coldsMainL3DataTableCheck_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableCheck_Time.Namespace = "";
            // 
            // coldsMainL3DataTableIronLadle_Age
            // 
            this.coldsMainL3DataTableIronLadle_Age.Caption = "IronLadle_Age";
            this.coldsMainL3DataTableIronLadle_Age.ColumnName = "IronLadle_Age";
            this.coldsMainL3DataTableIronLadle_Age.DataType = typeof(int);
            this.coldsMainL3DataTableIronLadle_Age.Namespace = "";
            // 
            // coldsMainL3DataTableWall_TEMP
            // 
            this.coldsMainL3DataTableWall_TEMP.Caption = "Wall_TEMP";
            this.coldsMainL3DataTableWall_TEMP.ColumnName = "Wall_TEMP";
            this.coldsMainL3DataTableWall_TEMP.DataType = typeof(float);
            this.coldsMainL3DataTableWall_TEMP.Namespace = "";
            // 
            // coldsMainL3DataTableBottom_TEMP
            // 
            this.coldsMainL3DataTableBottom_TEMP.Caption = "Bottom_TEMP";
            this.coldsMainL3DataTableBottom_TEMP.ColumnName = "Bottom_TEMP";
            this.coldsMainL3DataTableBottom_TEMP.DataType = typeof(float);
            this.coldsMainL3DataTableBottom_TEMP.Namespace = "";
            // 
            // coldsMainL3DataTableStop_Reason
            // 
            this.coldsMainL3DataTableStop_Reason.Caption = "Stop_Reason";
            this.coldsMainL3DataTableStop_Reason.ColumnName = "Stop_Reason";
            this.coldsMainL3DataTableStop_Reason.Namespace = "";
            // 
            // coldsMainL3DataTableThrow_Time
            // 
            this.coldsMainL3DataTableThrow_Time.Caption = "Throw_Time";
            this.coldsMainL3DataTableThrow_Time.ColumnName = "Throw_Time";
            this.coldsMainL3DataTableThrow_Time.Namespace = "";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(464, 10);
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
            this.btnConfirm.Location = new System.Drawing.Point(383, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
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
            this.tabControl1.Size = new System.Drawing.Size(551, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.dtThrow);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.txtThrow);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.txtBottomTEMP);
            this.tabPage1.Controls.Add(this.txtWallTEMP);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbStopReason);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmbIronLadleID);
            this.tabPage1.Controls.Add(this.dtCheck);
            this.tabPage1.Controls.Add(this.dtInput);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "使用信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(98, 164);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(404, 96);
            this.rtxtNote.TabIndex = 106;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtThrow
            // 
            this.dtThrow.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtThrow.Enabled = false;
            this.dtThrow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThrow.Location = new System.Drawing.Point(364, 39);
            this.dtThrow.Name = "dtThrow";
            this.dtThrow.Size = new System.Drawing.Size(138, 21);
            this.dtThrow.TabIndex = 7;
            this.dtThrow.ValueChanged += new System.EventHandler(this.dtThrow_ValueChanged);
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
            this.cmbShiftID.Location = new System.Drawing.Point(364, 90);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(138, 20);
            this.cmbShiftID.TabIndex = 9;
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
            // txtThrow
            // 
            this.txtThrow.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Throw_Time", true));
            this.txtThrow.EnableNull = true;
            this.txtThrow.ErropPr = null;
            this.txtThrow.Length = 0;
            this.txtThrow.Location = new System.Drawing.Point(419, 45);
            this.txtThrow.Max = 0;
            this.txtThrow.MaxStrLength = 0;
            this.txtThrow.Min = 0;
            this.txtThrow.MinStrLength = 0;
            this.txtThrow.Multiline = true;
            this.txtThrow.Name = "txtThrow";
            this.txtThrow.Precision = 0;
            this.txtThrow.Size = new System.Drawing.Size(10, 10);
            this.txtThrow.TabIndex = 10;
            this.txtThrow.ToolTipValid = null;
            this.txtThrow.ValidEable = true;
            this.txtThrow.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtThrow.TextChanged += new System.EventHandler(this.txtThrow_TextChanged);
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(364, 115);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Size = new System.Drawing.Size(138, 21);
            this.txtOperator.TabIndex = 10;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(323, 93);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 105;
            this.label44.Text = "班次:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(56, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 104;
            this.label8.Text = "备注:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(299, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 104;
            this.label9.Text = "甩包时间:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(311, 118);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 104;
            this.label47.Text = "责任人:";
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
            this.cmbTeamID.Location = new System.Drawing.Point(364, 65);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(138, 20);
            this.cmbTeamID.TabIndex = 8;
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
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(323, 68);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 102;
            this.label45.Text = "班别:";
            // 
            // txtAge
            // 
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "IronLadle_Age", true));
            this.txtAge.EnableNull = true;
            this.txtAge.ErropPr = this.errorProvider1;
            this.txtAge.Length = 0;
            this.txtAge.Location = new System.Drawing.Point(98, 138);
            this.txtAge.Max = 9999;
            this.txtAge.MaxStrLength = 0;
            this.txtAge.Min = 0;
            this.txtAge.MinStrLength = 0;
            this.txtAge.Name = "txtAge";
            this.txtAge.Precision = 0;
            this.txtAge.Size = new System.Drawing.Size(138, 21);
            this.txtAge.TabIndex = 4;
            this.txtAge.ToolTipValid = this.toolTip1;
            this.txtAge.ValidEable = true;
            this.txtAge.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtBottomTEMP
            // 
            this.txtBottomTEMP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Bottom_TEMP", true));
            this.txtBottomTEMP.EnableNull = false;
            this.txtBottomTEMP.ErropPr = this.errorProvider1;
            this.txtBottomTEMP.Length = 0;
            this.txtBottomTEMP.Location = new System.Drawing.Point(98, 113);
            this.txtBottomTEMP.Max = 2000;
            this.txtBottomTEMP.MaxStrLength = 0;
            this.txtBottomTEMP.Min = 0;
            this.txtBottomTEMP.MinStrLength = 0;
            this.txtBottomTEMP.Name = "txtBottomTEMP";
            this.txtBottomTEMP.Precision = 2;
            this.txtBottomTEMP.Size = new System.Drawing.Size(138, 21);
            this.txtBottomTEMP.TabIndex = 4;
            this.txtBottomTEMP.ToolTipValid = this.toolTip1;
            this.txtBottomTEMP.ValidEable = true;
            this.txtBottomTEMP.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtWallTEMP
            // 
            this.txtWallTEMP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Wall_TEMP", true));
            this.txtWallTEMP.EnableNull = false;
            this.txtWallTEMP.ErropPr = this.errorProvider1;
            this.txtWallTEMP.Length = 0;
            this.txtWallTEMP.Location = new System.Drawing.Point(98, 88);
            this.txtWallTEMP.Max = 2000;
            this.txtWallTEMP.MaxStrLength = 0;
            this.txtWallTEMP.Min = 0;
            this.txtWallTEMP.MinStrLength = 0;
            this.txtWallTEMP.Name = "txtWallTEMP";
            this.txtWallTEMP.Precision = 2;
            this.txtWallTEMP.Size = new System.Drawing.Size(138, 21);
            this.txtWallTEMP.TabIndex = 3;
            this.txtWallTEMP.ToolTipValid = this.toolTip1;
            this.txtWallTEMP.ValidEable = true;
            this.txtWallTEMP.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(55, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 96;
            this.label2.Text = "包龄:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(31, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 96;
            this.label6.Text = "包底温度:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 97;
            this.label4.Text = "包壁温度:";
            // 
            // cmbStopReason
            // 
            this.cmbStopReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStopReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStopReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Stop_Reason", true));
            this.cmbStopReason.DataSource = this.dsStopReason;
            this.cmbStopReason.DisplayMember = "L3DataTable.Code_Des";
            this.cmbStopReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopReason.EnableNull = true;
            this.cmbStopReason.ErropPr = null;
            this.cmbStopReason.FormattingEnabled = true;
            this.cmbStopReason.Location = new System.Drawing.Point(364, 14);
            this.cmbStopReason.Name = "cmbStopReason";
            this.cmbStopReason.Size = new System.Drawing.Size(138, 20);
            this.cmbStopReason.TabIndex = 6;
            this.cmbStopReason.ToolTipValid = null;
            this.cmbStopReason.ValidEable = true;
            this.cmbStopReason.ValueMember = "L3DataTable.Code";
            this.cmbStopReason.SelectedIndexChanged += new System.EventHandler(this.cmbStopReason_SelectedIndexChanged);
            // 
            // dsStopReason
            // 
            this.dsStopReason.AutoLoad = true;
            this.dsStopReason.AutoSubscribe = false;
            this.dsStopReason.DataSetName = "L3DataSet";
            this.dsStopReason.DeleteMethod = null;
            this.dsStopReason.InsertMethod = null;
            this.dsStopReason.L3DataAdapter = this.Adapter;
            this.dsStopReason.LoadEvent = "Click";
            this.dsStopReason.LoadTrigger = null;
            this.dsStopReason.RefreshValve = 1000;
            this.dsStopReason.SourceCommand = null;
            this.dsStopReason.SourceCondition = "Code_Group = \'Iron_Down_Reason\'";
            this.dsStopReason.SourceMethod = "";
            this.dsStopReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStopReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStopReason.SubscribeTarget = null;
            this.dsStopReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStopReason});
            this.dsStopReason.UpdateEvent = "Click";
            this.dsStopReason.UpdateMethod = null;
            this.dsStopReason.UpdateTrigger = null;
            // 
            // schemadsStopReason
            // 
            this.schemadsStopReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStopReasonL3DataTableCode,
            this.coldsStopReasonL3DataTableCode_Des});
            this.schemadsStopReason.TableName = "L3DataTable";
            // 
            // coldsStopReasonL3DataTableCode
            // 
            this.coldsStopReasonL3DataTableCode.Caption = "Code";
            this.coldsStopReasonL3DataTableCode.ColumnName = "Code";
            this.coldsStopReasonL3DataTableCode.Namespace = "";
            // 
            // coldsStopReasonL3DataTableCode_Des
            // 
            this.coldsStopReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStopReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStopReasonL3DataTableCode_Des.Namespace = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(299, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 94;
            this.label7.Text = "下线原因:";
            // 
            // cmbIronLadleID
            // 
            this.cmbIronLadleID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbIronLadleID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbIronLadleID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "IronLadleID", true));
            this.cmbIronLadleID.DataSource = this.dsIronLadleID;
            this.cmbIronLadleID.DisplayMember = "L3DataTable.IronLadleID";
            this.cmbIronLadleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIronLadleID.EnableNull = true;
            this.cmbIronLadleID.ErropPr = null;
            this.cmbIronLadleID.FormattingEnabled = true;
            this.cmbIronLadleID.Location = new System.Drawing.Point(98, 39);
            this.cmbIronLadleID.Name = "cmbIronLadleID";
            this.cmbIronLadleID.Size = new System.Drawing.Size(138, 20);
            this.cmbIronLadleID.TabIndex = 1;
            this.cmbIronLadleID.ToolTipValid = null;
            this.cmbIronLadleID.ValidEable = true;
            this.cmbIronLadleID.ValueMember = "L3DataTable.IronLadleID";
            this.cmbIronLadleID.SelectedIndexChanged += new System.EventHandler(this.cmbIronLadleID_SelectedIndexChanged);
            // 
            // dsIronLadleID
            // 
            this.dsIronLadleID.AutoLoad = true;
            this.dsIronLadleID.AutoSubscribe = false;
            this.dsIronLadleID.DataSetName = "L3DataSet";
            this.dsIronLadleID.DeleteMethod = null;
            this.dsIronLadleID.InsertMethod = null;
            this.dsIronLadleID.L3DataAdapter = this.Adapter;
            this.dsIronLadleID.LoadEvent = "Click";
            this.dsIronLadleID.LoadTrigger = null;
            this.dsIronLadleID.RefreshValve = 1000;
            this.dsIronLadleID.SourceCommand = null;
            this.dsIronLadleID.SourceCondition = "";
            this.dsIronLadleID.SourceMethod = "";
            this.dsIronLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadleID.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Base";
            this.dsIronLadleID.SubscribeTarget = "";
            this.dsIronLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadleID});
            this.dsIronLadleID.UpdateEvent = "Click";
            this.dsIronLadleID.UpdateMethod = null;
            this.dsIronLadleID.UpdateTrigger = null;
            // 
            // schemadsIronLadleID
            // 
            this.schemadsIronLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadleIDL3DataTableIronLadleID});
            this.schemadsIronLadleID.TableName = "L3DataTable";
            // 
            // coldsIronLadleIDL3DataTableIronLadleID
            // 
            this.coldsIronLadleIDL3DataTableIronLadleID.Caption = "IronLadleID";
            this.coldsIronLadleIDL3DataTableIronLadleID.ColumnName = "IronLadleID";
            this.coldsIronLadleIDL3DataTableIronLadleID.Namespace = "";
            // 
            // dtCheck
            // 
            this.dtCheck.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtCheck.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Check_Time", true));
            this.dtCheck.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheck.Location = new System.Drawing.Point(98, 63);
            this.dtCheck.Name = "dtCheck";
            this.dtCheck.Size = new System.Drawing.Size(138, 21);
            this.dtCheck.TabIndex = 2;
            // 
            // dtInput
            // 
            this.dtInput.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInput.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Input_Time", true));
            this.dtInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInput.Location = new System.Drawing.Point(98, 14);
            this.dtInput.Name = "dtInput";
            this.dtInput.Size = new System.Drawing.Size(138, 21);
            this.dtInput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(31, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 89;
            this.label3.Text = "检查时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 90;
            this.label1.Text = "录入时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(43, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 88;
            this.label5.Text = "铁包号:";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // cmdGetAge
            // 
            this.cmdGetAge.Adapter = this.Adapter;
            this.cmdGetAge.MergeReturnTarget = false;
            this.cmdGetAge.Method = "GetIronLadle_Age";
            this.cmdGetAge.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdGetAge.Parameters.Add(this.l3CommandParameter1);
            this.cmdGetAge.ReturnTarget = null;
            this.cmdGetAge.ReturnTargetProperty = "";
            this.cmdGetAge.Trigger = null;
            this.cmdGetAge.TriggerEvent = "";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.cmbIronLadleID;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // IronLadleUseShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 352);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IronLadleUseShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铁包使用信息维护";
            this.Load += new System.EventHandler(this.IronLadleUseDefendFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStopReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStopReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbStopReason;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxComboBox cmbIronLadleID;
        private System.Windows.Forms.DateTimePicker dtCheck;
        private System.Windows.Forms.DateTimePicker dtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.DateTimePicker dtThrow;
        private PxDataValid.PxTextBox txtBottomTEMP;
        private PxDataValid.PxTextBox txtWallTEMP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label8;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableName;
        private System.Data.DataColumn coldsMainL3DataTableInput_Time;
        private System.Data.DataColumn coldsMainL3DataTableIronLadleID;
        private System.Data.DataColumn coldsMainL3DataTableCheck_Time;
        private System.Data.DataColumn coldsMainL3DataTableIronLadle_Age;
        private System.Data.DataColumn coldsMainL3DataTableWall_TEMP;
        private System.Data.DataColumn coldsMainL3DataTableBottom_TEMP;
        private System.Data.DataColumn coldsMainL3DataTableStop_Reason;
        private System.Data.DataColumn coldsMainL3DataTableThrow_Time;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private AppSvrHMI.L3DataSet dsIronLadleID;
        private System.Data.DataTable schemadsIronLadleID;
        private System.Data.DataColumn coldsIronLadleIDL3DataTableIronLadleID;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3Command cmdGetAge;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private PxDataValid.PxTextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private AppSvrHMI.L3DataSet dsStopReason;
        private System.Data.DataTable schemadsStopReason;
        private System.Data.DataColumn coldsStopReasonL3DataTableCode;
        private System.Data.DataColumn coldsStopReasonL3DataTableCode_Des;
        private PxDataValid.PxTextBox txtThrow;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxRichTextBox rtxtNote;
    }
}