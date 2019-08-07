namespace EquipMag.IronLadleMag
{
    partial class IronLadleTieShowFrm
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
            this.coldsMainL3DataTableInPut_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableIronLadleID = new System.Data.DataColumn();
            this.coldsMainL3DataTableRefra_Produce = new System.Data.DataColumn();
            this.coldsMainL3DataTableRefra_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableConsumption = new System.Data.DataColumn();
            this.coldsMainL3DataTableTie_Start_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableTie_End_Time = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.coldsMainL3DataTableDoff_Mod_Time = new System.Data.DataColumn();
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
            this.label23 = new System.Windows.Forms.Label();
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
            this.label47 = new System.Windows.Forms.Label();
            this.txtConsumption = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRefraID = new PxDataValid.PxComboBox();
            this.dsRefraID = new AppSvrHMI.L3DataSet();
            this.schemadsRefraID = new System.Data.DataTable();
            this.coldsRefraIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbIronLadleID = new PxDataValid.PxComboBox();
            this.dsIronLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadleID = new System.Data.DataTable();
            this.coldsIronLadleIDL3DataTableIronLadleID = new System.Data.DataColumn();
            this.cmbRefraProduce = new PxDataValid.PxComboBox();
            this.dsRefraProduce = new AppSvrHMI.L3DataSet();
            this.schemadsRefraProduce = new System.Data.DataTable();
            this.coldsRefraProduceL3DataTableCode_Des = new System.Data.DataColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtTieEnd = new System.Windows.Forms.DateTimePicker();
            this.dtTieStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraProduce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraProduce)).BeginInit();
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
            this.dsMain.SubscribeTarget = null;
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
            this.coldsMainL3DataTableInPut_Time,
            this.coldsMainL3DataTableIronLadleID,
            this.coldsMainL3DataTableRefra_Produce,
            this.coldsMainL3DataTableRefra_ID,
            this.coldsMainL3DataTableConsumption,
            this.coldsMainL3DataTableTie_Start_Time,
            this.coldsMainL3DataTableTie_End_Time,
            this.coldsMainL3DataTableTeamID,
            this.coldsMainL3DataTableShiftID,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableNote,
            this.coldsMainL3DataTableDoff_Mod_Time});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableInPut_Time
            // 
            this.coldsMainL3DataTableInPut_Time.Caption = "InPut_Time";
            this.coldsMainL3DataTableInPut_Time.ColumnName = "InPut_Time";
            this.coldsMainL3DataTableInPut_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableInPut_Time.Namespace = "";
            // 
            // coldsMainL3DataTableIronLadleID
            // 
            this.coldsMainL3DataTableIronLadleID.Caption = "IronLadleID";
            this.coldsMainL3DataTableIronLadleID.ColumnName = "IronLadleID";
            this.coldsMainL3DataTableIronLadleID.Namespace = "";
            // 
            // coldsMainL3DataTableRefra_Produce
            // 
            this.coldsMainL3DataTableRefra_Produce.Caption = "Refra_Produce";
            this.coldsMainL3DataTableRefra_Produce.ColumnName = "Refra_Produce";
            this.coldsMainL3DataTableRefra_Produce.Namespace = "";
            // 
            // coldsMainL3DataTableRefra_ID
            // 
            this.coldsMainL3DataTableRefra_ID.Caption = "Refra_ID";
            this.coldsMainL3DataTableRefra_ID.ColumnName = "Refra_ID";
            this.coldsMainL3DataTableRefra_ID.Namespace = "";
            // 
            // coldsMainL3DataTableConsumption
            // 
            this.coldsMainL3DataTableConsumption.Caption = "Consumption";
            this.coldsMainL3DataTableConsumption.ColumnName = "Consumption";
            this.coldsMainL3DataTableConsumption.DataType = typeof(float);
            this.coldsMainL3DataTableConsumption.Namespace = "";
            // 
            // coldsMainL3DataTableTie_Start_Time
            // 
            this.coldsMainL3DataTableTie_Start_Time.Caption = "Tie_Start_Time";
            this.coldsMainL3DataTableTie_Start_Time.ColumnName = "Tie_Start_Time";
            this.coldsMainL3DataTableTie_Start_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableTie_Start_Time.Namespace = "";
            // 
            // coldsMainL3DataTableTie_End_Time
            // 
            this.coldsMainL3DataTableTie_End_Time.Caption = "Tie_End_Time";
            this.coldsMainL3DataTableTie_End_Time.ColumnName = "Tie_End_Time";
            this.coldsMainL3DataTableTie_End_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableTie_End_Time.Namespace = "";
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
            // coldsMainL3DataTableDoff_Mod_Time
            // 
            this.coldsMainL3DataTableDoff_Mod_Time.Caption = "Doff_Mod_Time";
            this.coldsMainL3DataTableDoff_Mod_Time.ColumnName = "Doff_Mod_Time";
            this.coldsMainL3DataTableDoff_Mod_Time.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableDoff_Mod_Time.Namespace = "";
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
            this.panel3.Location = new System.Drawing.Point(0, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(438, 10);
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
            this.btnConfirm.Location = new System.Drawing.Point(357, 10);
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
            this.tabControl1.Size = new System.Drawing.Size(525, 298);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.txtConsumption);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbRefraID);
            this.tabPage1.Controls.Add(this.cmbIronLadleID);
            this.tabPage1.Controls.Add(this.cmbRefraProduce);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.dtTieEnd);
            this.tabPage1.Controls.Add(this.dtTieStart);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "打结信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(101, 169);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(382, 96);
            this.rtxtNote.TabIndex = 78;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(60, 172);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 77;
            this.label23.Text = "备注:";
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
            this.cmbShiftID.Location = new System.Drawing.Point(342, 116);
            this.cmbShiftID.Name = "cmbShiftID";
            //
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 8;
            //
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
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(342, 91);
            this.cmbTeamID.Name = "cmbTeamID";
            //
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 7;
            //
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
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            //
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            //
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(342, 142);
            this.txtOperator.Max = 0;
            ////
            //
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            ////
            //
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            //
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 9;
            this.txtOperator.ToolTipValid = null;
          //
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(301, 123);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 72;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(301, 97);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 73;
            this.label45.Text = "班别:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(289, 147);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 71;
            this.label47.Text = "责任人:";
            // 
            // txtConsumption
            // 
            this.txtConsumption.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Consumption", true));
            //
            this.txtConsumption.EnableNull = false;
            this.txtConsumption.ErropPr = this.errorProvider1;
            //
            this.txtConsumption.Length = 0;
            this.txtConsumption.Location = new System.Drawing.Point(342, 65);
            this.txtConsumption.Max = 9999;
            ////
            //
            this.txtConsumption.MaxStrLength = 0;
            this.txtConsumption.Min = 0;
            ////
            //
            this.txtConsumption.MinStrLength = 0;
            this.txtConsumption.Name = "txtConsumption";
            this.txtConsumption.Precision = 2;
            //
            this.txtConsumption.Size = new System.Drawing.Size(141, 21);
            this.txtConsumption.TabIndex = 6;
            this.txtConsumption.ToolTipValid = this.toolTip1;
          //
            this.txtConsumption.ValidEable = true;
            this.txtConsumption.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(289, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 69;
            this.label2.Text = "消耗量:";
            // 
            // cmbRefraID
            // 
            this.cmbRefraID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefraID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefraID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Refra_ID", true));
            this.cmbRefraID.DataSource = this.dsRefraID;
            this.cmbRefraID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbRefraID.EnableNull = true;
            this.cmbRefraID.ErropPr = null;
            this.cmbRefraID.FormattingEnabled = true;
            this.cmbRefraID.Location = new System.Drawing.Point(342, 40);
            this.cmbRefraID.Name = "cmbRefraID";
            //
            this.cmbRefraID.Size = new System.Drawing.Size(141, 20);
            this.cmbRefraID.TabIndex = 5;
            //
            this.cmbRefraID.ToolTipValid = null;
            this.cmbRefraID.ValidEable = true;
            this.cmbRefraID.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsRefraID
            // 
            this.dsRefraID.AutoLoad = true;
            this.dsRefraID.AutoSubscribe = false;
            this.dsRefraID.DataSetName = "L3DataSet";
            this.dsRefraID.DeleteMethod = "";
            this.dsRefraID.InsertMethod = "";
            this.dsRefraID.L3DataAdapter = this.Adapter;
            this.dsRefraID.LoadEvent = "";
            this.dsRefraID.LoadTrigger = null;
            this.dsRefraID.RefreshValve = 1000;
            this.dsRefraID.SourceCommand = null;
            this.dsRefraID.SourceCondition = "Code_Group = \'IronLadle_Refra_Name\' order by Code_Des";
            this.dsRefraID.SourceMethod = "";
            this.dsRefraID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRefraID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRefraID.SubscribeTarget = null;
            this.dsRefraID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRefraID});
            this.dsRefraID.UpdateEvent = "";
            this.dsRefraID.UpdateMethod = "";
            this.dsRefraID.UpdateTrigger = null;
            // 
            // schemadsRefraID
            // 
            this.schemadsRefraID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefraIDL3DataTableCode_Des});
            this.schemadsRefraID.TableName = "L3DataTable";
            // 
            // coldsRefraIDL3DataTableCode_Des
            // 
            this.coldsRefraIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRefraIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRefraIDL3DataTableCode_Des.Namespace = "";
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
            this.cmbIronLadleID.Location = new System.Drawing.Point(103, 41);
            this.cmbIronLadleID.Name = "cmbIronLadleID";
            //
            this.cmbIronLadleID.Size = new System.Drawing.Size(141, 20);
            this.cmbIronLadleID.TabIndex = 1;
            //
            this.cmbIronLadleID.ToolTipValid = null;
            this.cmbIronLadleID.ValidEable = true;
            this.cmbIronLadleID.ValueMember = "L3DataTable.IronLadleID";
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
            this.dsIronLadleID.SourceCondition = null;
            this.dsIronLadleID.SourceMethod = "";
            this.dsIronLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadleID.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Base";
            this.dsIronLadleID.SubscribeTarget = null;
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
            // cmbRefraProduce
            // 
            this.cmbRefraProduce.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbRefraProduce.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRefraProduce.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Refra_Produce", true));
            this.cmbRefraProduce.DataSource = this.dsRefraProduce;
            this.cmbRefraProduce.DisplayMember = "L3DataTable.Code_Des";
            this.cmbRefraProduce.EnableNull = true;
            this.cmbRefraProduce.ErropPr = null;
            this.cmbRefraProduce.FormattingEnabled = true;
            this.cmbRefraProduce.Location = new System.Drawing.Point(342, 15);
            this.cmbRefraProduce.Name = "cmbRefraProduce";
            //
            this.cmbRefraProduce.Size = new System.Drawing.Size(141, 20);
            this.cmbRefraProduce.TabIndex = 4;
            //
            this.cmbRefraProduce.ToolTipValid = null;
            this.cmbRefraProduce.ValidEable = true;
            this.cmbRefraProduce.ValueMember = "L3DataTable.Code_Des";
            // 
            // dsRefraProduce
            // 
            this.dsRefraProduce.AutoLoad = true;
            this.dsRefraProduce.AutoSubscribe = false;
            this.dsRefraProduce.DataSetName = "L3DataSet";
            this.dsRefraProduce.DeleteMethod = "";
            this.dsRefraProduce.InsertMethod = "";
            this.dsRefraProduce.L3DataAdapter = this.Adapter;
            this.dsRefraProduce.LoadEvent = "";
            this.dsRefraProduce.LoadTrigger = null;
            this.dsRefraProduce.RefreshValve = 1000;
            this.dsRefraProduce.SourceCommand = null;
            this.dsRefraProduce.SourceCondition = "Code_Group = \'IronLadle_Refra_Fac\' order by Code_Des";
            this.dsRefraProduce.SourceMethod = "";
            this.dsRefraProduce.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRefraProduce.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsRefraProduce.SubscribeTarget = null;
            this.dsRefraProduce.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRefraProduce});
            this.dsRefraProduce.UpdateEvent = "";
            this.dsRefraProduce.UpdateMethod = "";
            this.dsRefraProduce.UpdateTrigger = null;
            // 
            // schemadsRefraProduce
            // 
            this.schemadsRefraProduce.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefraProduceL3DataTableCode_Des});
            this.schemadsRefraProduce.TableName = "L3DataTable";
            // 
            // coldsRefraProduceL3DataTableCode_Des
            // 
            this.coldsRefraProduceL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsRefraProduceL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsRefraProduceL3DataTableCode_Des.Namespace = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(277, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "耐材名称:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(277, 19);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 46;
            this.label21.Text = "耐材厂家:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dtTieEnd
            // 
            this.dtTieEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTieEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Tie_End_Time", true));
            this.dtTieEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTieEnd.Location = new System.Drawing.Point(103, 92);
            this.dtTieEnd.Name = "dtTieEnd";
            this.dtTieEnd.Size = new System.Drawing.Size(141, 21);
            this.dtTieEnd.TabIndex = 3;
            // 
            // dtTieStart
            // 
            this.dtTieStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtTieStart.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "Tie_Start_Time", true));
            this.dtTieStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTieStart.Location = new System.Drawing.Point(103, 66);
            this.dtTieStart.Name = "dtTieStart";
            this.dtTieStart.Size = new System.Drawing.Size(141, 21);
            this.dtTieStart.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(36, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "脱模时间:";
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMain, "InPut_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(103, 15);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "打结结束时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "打结开始时间:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "录入时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(48, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "铁包号:";
            // 
            // IronLadleTieShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IronLadleTieShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铁包打结信息维护";
            this.Load += new System.EventHandler(this.IronLadleTieDefendFrm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraProduce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraProduce)).EndInit();
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
        private PxDataValid.PxComboBox cmbRefraID;
        private PxDataValid.PxComboBox cmbIronLadleID;
        private PxDataValid.PxComboBox cmbRefraProduce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtTieEnd;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private PxDataValid.PxTextBox txtConsumption;
        private System.Windows.Forms.Label label2;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableInPut_Time;
        private System.Data.DataColumn coldsMainL3DataTableIronLadleID;
        private System.Data.DataColumn coldsMainL3DataTableRefra_Produce;
        private System.Data.DataColumn coldsMainL3DataTableRefra_ID;
        private System.Data.DataColumn coldsMainL3DataTableConsumption;
        private System.Data.DataColumn coldsMainL3DataTableTie_Start_Time;
        private System.Data.DataColumn coldsMainL3DataTableTie_End_Time;
        private System.Data.DataColumn coldsMainL3DataTableTeamID;
        private System.Data.DataColumn coldsMainL3DataTableShiftID;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private AppSvrHMI.L3DataSet dsIronLadleID;
        private System.Data.DataTable schemadsIronLadleID;
        private System.Data.DataColumn coldsIronLadleIDL3DataTableIronLadleID;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private System.Windows.Forms.DateTimePicker dtTieStart;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Data.DataColumn coldsMainL3DataTableDoff_Mod_Time;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsRefraProduce;
        private System.Data.DataTable schemadsRefraProduce;
        private AppSvrHMI.L3DataSet dsRefraID;
        private System.Data.DataTable schemadsRefraID;
        private System.Data.DataColumn coldsRefraIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsRefraProduceL3DataTableCode_Des;
    }
}