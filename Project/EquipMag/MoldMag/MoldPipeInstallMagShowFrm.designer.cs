namespace EquipMag.MoldMag
{
    partial class MoldPipeInstallMagShowFrm
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
            this.bsInstall = new System.Windows.Forms.BindingSource(this.components);
            this.dsInstall = new AppSvrHMI.L3DataSet();
            this.schemadsInstall = new System.Data.DataTable();
            this.coldsInstallL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableName = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInput_Time = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInstall_Date = new System.Data.DataColumn();
            this.coldsInstallL3DataTableMoldID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableHit_Press_Flag = new System.Data.DataColumn();
            this.coldsInstallL3DataTableCopper_ID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableCopper_Fac = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInstall_Per = new System.Data.DataColumn();
            this.coldsInstallL3DataTableRepair_Start_Time = new System.Data.DataColumn();
            this.coldsInstallL3DataTableRepair_End_Time = new System.Data.DataColumn();
            this.coldsInstallL3DataTableRepair_Content = new System.Data.DataColumn();
            this.coldsInstallL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableOperator = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNote = new System.Data.DataColumn();
            this.coldsInstallL3DataTableInStallID = new System.Data.DataColumn();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxtNote = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label46 = new System.Windows.Forms.Label();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.label47 = new System.Windows.Forms.Label();
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
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtInstallPer = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRepairContent = new PxDataValid.PxTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCopperFac = new PxDataValid.PxComboBox();
            this.dsCopperFac = new AppSvrHMI.L3DataSet();
            this.schemadsCopperFac = new System.Data.DataTable();
            this.coldsCopperFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFlag = new PxDataValid.PxComboBox();
            this.dsFlag = new AppSvrHMI.L3DataSet();
            this.schemadsFlag = new System.Data.DataTable();
            this.coldsFlagL3DataTableCode = new System.Data.DataColumn();
            this.coldsFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbMoldID = new PxDataValid.PxComboBox();
            this.dsMoldID = new AppSvrHMI.L3DataSet();
            this.schemadsMoldID = new System.Data.DataTable();
            this.coldsMoldIDL3DataTableMoldID = new System.Data.DataColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCopperID = new PxDataValid.PxTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtRepairEndTime = new System.Windows.Forms.DateTimePicker();
            this.dtInstallDate = new System.Windows.Forms.DateTimePicker();
            this.dtRepairStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtInputTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInstall
            // 
            this.bsInstall.DataMember = "L3DataTable";
            this.bsInstall.DataSource = this.dsInstall;
            // 
            // dsInstall
            // 
            this.dsInstall.AutoLoad = true;
            this.dsInstall.AutoSubscribe = false;
            this.dsInstall.DataSetName = "L3DataSet";
            this.dsInstall.DeleteMethod = null;
            this.dsInstall.InsertMethod = null;
            this.dsInstall.L3DataAdapter = null;
            this.dsInstall.LoadEvent = "Click";
            this.dsInstall.LoadTrigger = null;
            this.dsInstall.RefreshValve = 1000;
            this.dsInstall.SourceCommand = null;
            this.dsInstall.SourceCondition = "";
            this.dsInstall.SourceMethod = "";
            this.dsInstall.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsInstall.SourceURI = "";
            this.dsInstall.SubscribeTarget = null;
            this.dsInstall.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInstall});
            this.dsInstall.UpdateEvent = "Click";
            this.dsInstall.UpdateMethod = null;
            this.dsInstall.UpdateTrigger = null;
            // 
            // schemadsInstall
            // 
            this.schemadsInstall.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInstallL3DataTableGUID,
            this.coldsInstallL3DataTableName,
            this.coldsInstallL3DataTableInput_Time,
            this.coldsInstallL3DataTableInstall_Date,
            this.coldsInstallL3DataTableMoldID,
            this.coldsInstallL3DataTableHit_Press_Flag,
            this.coldsInstallL3DataTableCopper_ID,
            this.coldsInstallL3DataTableCopper_Fac,
            this.coldsInstallL3DataTableInstall_Per,
            this.coldsInstallL3DataTableRepair_Start_Time,
            this.coldsInstallL3DataTableRepair_End_Time,
            this.coldsInstallL3DataTableRepair_Content,
            this.coldsInstallL3DataTableTeamID,
            this.coldsInstallL3DataTableShiftID,
            this.coldsInstallL3DataTableOperator,
            this.coldsInstallL3DataTableNote,
            this.coldsInstallL3DataTableInStallID});
            this.schemadsInstall.TableName = "L3DataTable";
            // 
            // coldsInstallL3DataTableGUID
            // 
            this.coldsInstallL3DataTableGUID.Caption = "GUID";
            this.coldsInstallL3DataTableGUID.ColumnName = "GUID";
            this.coldsInstallL3DataTableGUID.Namespace = "";
            // 
            // coldsInstallL3DataTableName
            // 
            this.coldsInstallL3DataTableName.Caption = "Name";
            this.coldsInstallL3DataTableName.ColumnName = "Name";
            this.coldsInstallL3DataTableName.Namespace = "";
            // 
            // coldsInstallL3DataTableInput_Time
            // 
            this.coldsInstallL3DataTableInput_Time.Caption = "Input_Time";
            this.coldsInstallL3DataTableInput_Time.ColumnName = "Input_Time";
            this.coldsInstallL3DataTableInput_Time.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableInput_Time.Namespace = "";
            // 
            // coldsInstallL3DataTableInstall_Date
            // 
            this.coldsInstallL3DataTableInstall_Date.Caption = "Install_Date";
            this.coldsInstallL3DataTableInstall_Date.ColumnName = "Install_Date";
            this.coldsInstallL3DataTableInstall_Date.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableInstall_Date.Namespace = "";
            // 
            // coldsInstallL3DataTableMoldID
            // 
            this.coldsInstallL3DataTableMoldID.Caption = "MoldID";
            this.coldsInstallL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsInstallL3DataTableMoldID.Namespace = "";
            // 
            // coldsInstallL3DataTableHit_Press_Flag
            // 
            this.coldsInstallL3DataTableHit_Press_Flag.Caption = "Hit_Press_Flag";
            this.coldsInstallL3DataTableHit_Press_Flag.ColumnName = "Hit_Press_Flag";
            this.coldsInstallL3DataTableHit_Press_Flag.Namespace = "";
            // 
            // coldsInstallL3DataTableCopper_ID
            // 
            this.coldsInstallL3DataTableCopper_ID.Caption = "Copper_ID";
            this.coldsInstallL3DataTableCopper_ID.ColumnName = "Copper_ID";
            this.coldsInstallL3DataTableCopper_ID.Namespace = "";
            // 
            // coldsInstallL3DataTableCopper_Fac
            // 
            this.coldsInstallL3DataTableCopper_Fac.Caption = "Copper_Fac";
            this.coldsInstallL3DataTableCopper_Fac.ColumnName = "Copper_Fac";
            this.coldsInstallL3DataTableCopper_Fac.Namespace = "";
            // 
            // coldsInstallL3DataTableInstall_Per
            // 
            this.coldsInstallL3DataTableInstall_Per.Caption = "Install_Per";
            this.coldsInstallL3DataTableInstall_Per.ColumnName = "Install_Per";
            this.coldsInstallL3DataTableInstall_Per.Namespace = "";
            // 
            // coldsInstallL3DataTableRepair_Start_Time
            // 
            this.coldsInstallL3DataTableRepair_Start_Time.Caption = "Repair_Start_Time";
            this.coldsInstallL3DataTableRepair_Start_Time.ColumnName = "Repair_Start_Time";
            this.coldsInstallL3DataTableRepair_Start_Time.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableRepair_Start_Time.Namespace = "";
            // 
            // coldsInstallL3DataTableRepair_End_Time
            // 
            this.coldsInstallL3DataTableRepair_End_Time.Caption = "Repair_End_Time";
            this.coldsInstallL3DataTableRepair_End_Time.ColumnName = "Repair_End_Time";
            this.coldsInstallL3DataTableRepair_End_Time.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableRepair_End_Time.Namespace = "";
            // 
            // coldsInstallL3DataTableRepair_Content
            // 
            this.coldsInstallL3DataTableRepair_Content.Caption = "Repair_Content";
            this.coldsInstallL3DataTableRepair_Content.ColumnName = "Repair_Content";
            this.coldsInstallL3DataTableRepair_Content.Namespace = "";
            // 
            // coldsInstallL3DataTableTeamID
            // 
            this.coldsInstallL3DataTableTeamID.Caption = "TeamID";
            this.coldsInstallL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsInstallL3DataTableTeamID.Namespace = "";
            // 
            // coldsInstallL3DataTableShiftID
            // 
            this.coldsInstallL3DataTableShiftID.Caption = "ShiftID";
            this.coldsInstallL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsInstallL3DataTableShiftID.Namespace = "";
            // 
            // coldsInstallL3DataTableOperator
            // 
            this.coldsInstallL3DataTableOperator.Caption = "Operator";
            this.coldsInstallL3DataTableOperator.ColumnName = "Operator";
            this.coldsInstallL3DataTableOperator.Namespace = "";
            // 
            // coldsInstallL3DataTableNote
            // 
            this.coldsInstallL3DataTableNote.Caption = "Note";
            this.coldsInstallL3DataTableNote.ColumnName = "Note";
            this.coldsInstallL3DataTableNote.Namespace = "";
            // 
            // coldsInstallL3DataTableInStallID
            // 
            this.coldsInstallL3DataTableInStallID.Caption = "InStallID";
            this.coldsInstallL3DataTableInStallID.ColumnName = "InStallID";
            this.coldsInstallL3DataTableInStallID.Namespace = "";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 296);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.rtxtNote);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbShiftID);
            this.tabPage1.Controls.Add(this.cmbTeamID);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.txtInstallPer);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtRepairContent);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cmbCopperFac);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbFlag);
            this.tabPage1.Controls.Add(this.cmbMoldID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtCopperID);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.dtRepairEndTime);
            this.tabPage1.Controls.Add(this.dtInstallDate);
            this.tabPage1.Controls.Add(this.dtRepairStartTime);
            this.tabPage1.Controls.Add(this.dtInputTime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "结晶器铜管装配实绩信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtNote
            // 
            this.rtxtNote.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Note", true));
            this.rtxtNote.EnableNull = true;
            this.rtxtNote.ErropPr = this.errorProvider1;
            this.rtxtNote.Location = new System.Drawing.Point(96, 195);
            this.rtxtNote.MaxStrLength = 125;
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(401, 62);
            this.rtxtNote.TabIndex = 12;
            this.rtxtNote.Text = "";
            this.rtxtNote.ToolTipValid = this.toolTip1;
            this.rtxtNote.ValidEable = true;
            this.rtxtNote.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(59, 198);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(35, 12);
            this.label46.TabIndex = 60;
            this.label46.Text = "备注:";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Operator", true));
            this.txtOperator.DisplayPrecision = 0;
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.FixedLength = 0;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(356, 139);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxNull = 0;
            this.txtOperator.MaxStringLength = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinNull = 0;
            this.txtOperator.MinStringLength = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.Regex = "";
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 10;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.VaildWarning = "";
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(304, 145);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 58;
            this.label47.Text = "责任人:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbShiftID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbShiftID.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbShiftID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "ShiftID", true));
            this.cmbShiftID.DataSource = this.dsShiftID;
            this.cmbShiftID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShiftID.EnableNull = true;
            this.cmbShiftID.ErropPr = null;
            this.cmbShiftID.FormattingEnabled = true;
            this.cmbShiftID.Location = new System.Drawing.Point(356, 114);
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.ReadOnly = false;
            this.cmbShiftID.Size = new System.Drawing.Size(141, 20);
            this.cmbShiftID.TabIndex = 9;
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
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "TeamID", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(356, 89);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.ReadOnly = false;
            this.cmbTeamID.Size = new System.Drawing.Size(141, 20);
            this.cmbTeamID.TabIndex = 8;
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
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Location = new System.Drawing.Point(316, 119);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(35, 12);
            this.label44.TabIndex = 54;
            this.label44.Text = "班次:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Location = new System.Drawing.Point(316, 93);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(35, 12);
            this.label45.TabIndex = 55;
            this.label45.Text = "班别:";
            // 
            // txtInstallPer
            // 
            this.txtInstallPer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Install_Per", true));
            this.txtInstallPer.DisplayPrecision = 0;
            this.txtInstallPer.EnableNull = true;
            this.txtInstallPer.ErropPr = null;
            this.txtInstallPer.FixedLength = 0;
            this.txtInstallPer.Length = 0;
            this.txtInstallPer.Location = new System.Drawing.Point(96, 167);
            this.txtInstallPer.Max = 0;
            this.txtInstallPer.MaxNull = 0;
            this.txtInstallPer.MaxStringLength = 0;
            this.txtInstallPer.MaxStrLength = 0;
            this.txtInstallPer.Min = 0;
            this.txtInstallPer.MinNull = 0;
            this.txtInstallPer.MinStringLength = 0;
            this.txtInstallPer.MinStrLength = 0;
            this.txtInstallPer.Multiline = true;
            this.txtInstallPer.Name = "txtInstallPer";
            this.txtInstallPer.Precision = 0;
            this.txtInstallPer.Regex = "";
            this.txtInstallPer.Size = new System.Drawing.Size(401, 21);
            this.txtInstallPer.TabIndex = 11;
            this.txtInstallPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInstallPer.ToolTipValid = null;
            this.txtInstallPer.VaildWarning = "";
            this.txtInstallPer.ValidEable = true;
            this.txtInstallPer.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(44, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "装配人:";
            // 
            // txtRepairContent
            // 
            this.txtRepairContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Repair_Content", true));
            this.txtRepairContent.DisplayPrecision = 0;
            this.txtRepairContent.EnableNull = true;
            this.txtRepairContent.ErropPr = null;
            this.txtRepairContent.FixedLength = 0;
            this.txtRepairContent.Length = 0;
            this.txtRepairContent.Location = new System.Drawing.Point(356, 63);
            this.txtRepairContent.Max = 0;
            this.txtRepairContent.MaxNull = 0;
            this.txtRepairContent.MaxStringLength = 0;
            this.txtRepairContent.MaxStrLength = 0;
            this.txtRepairContent.Min = 0;
            this.txtRepairContent.MinNull = 0;
            this.txtRepairContent.MinStringLength = 0;
            this.txtRepairContent.MinStrLength = 0;
            this.txtRepairContent.Name = "txtRepairContent";
            this.txtRepairContent.Precision = 0;
            this.txtRepairContent.Regex = "";
            this.txtRepairContent.Size = new System.Drawing.Size(141, 21);
            this.txtRepairContent.TabIndex = 7;
            this.txtRepairContent.ToolTipValid = null;
            this.txtRepairContent.VaildWarning = "";
            this.txtRepairContent.ValidEable = true;
            this.txtRepairContent.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(292, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 50;
            this.label8.Text = "维修内容:";
            // 
            // cmbCopperFac
            // 
            this.cmbCopperFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCopperFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCopperFac.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Copper_Fac", true));
            this.cmbCopperFac.DataSource = this.dsCopperFac;
            this.cmbCopperFac.DisplayMember = "L3DataTable.MatFactory";
            this.cmbCopperFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopperFac.EnableNull = true;
            this.cmbCopperFac.ErropPr = null;
            this.cmbCopperFac.FormattingEnabled = true;
            this.cmbCopperFac.Location = new System.Drawing.Point(97, 63);
            this.cmbCopperFac.Name = "cmbCopperFac";
            this.cmbCopperFac.ReadOnly = false;
            this.cmbCopperFac.Size = new System.Drawing.Size(141, 20);
            this.cmbCopperFac.TabIndex = 2;
            this.cmbCopperFac.TMpEnabled = true;
            this.cmbCopperFac.ToolTipValid = null;
            this.cmbCopperFac.ValidEable = true;
            this.cmbCopperFac.ValueMember = "L3DataTable.MatFactory";
            // 
            // dsCopperFac
            // 
            this.dsCopperFac.AutoLoad = true;
            this.dsCopperFac.AutoSubscribe = false;
            this.dsCopperFac.DataSetName = "L3DataSet";
            this.dsCopperFac.DeleteMethod = null;
            this.dsCopperFac.InsertMethod = null;
            this.dsCopperFac.L3DataAdapter = this.Adapter;
            this.dsCopperFac.LoadEvent = "Click";
            this.dsCopperFac.LoadTrigger = null;
            this.dsCopperFac.RefreshValve = 1000;
            this.dsCopperFac.SourceCommand = null;
            this.dsCopperFac.SourceCondition = "MATGROUP_CODE = \'MoldFac\' and MATNAME = \'铜管\'";
            this.dsCopperFac.SourceMethod = "";
            this.dsCopperFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCopperFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsCopperFac.SubscribeTarget = null;
            this.dsCopperFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCopperFac});
            this.dsCopperFac.UpdateEvent = "Click";
            this.dsCopperFac.UpdateMethod = null;
            this.dsCopperFac.UpdateTrigger = null;
            // 
            // schemadsCopperFac
            // 
            this.schemadsCopperFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCopperFacL3DataTableMatFactory});
            this.schemadsCopperFac.TableName = "L3DataTable";
            // 
            // coldsCopperFacL3DataTableMatFactory
            // 
            this.coldsCopperFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsCopperFacL3DataTableMatFactory.Namespace = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(35, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 48;
            this.label5.Text = "铜管厂家:";
            // 
            // cmbFlag
            // 
            this.cmbFlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFlag.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "Hit_Press_Flag", true));
            this.cmbFlag.DataSource = this.dsFlag;
            this.cmbFlag.DisplayMember = "L3DataTable.Code_Des";
            this.cmbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlag.EnableNull = false;
            this.cmbFlag.ErropPr = null;
            this.cmbFlag.FormattingEnabled = true;
            this.cmbFlag.Location = new System.Drawing.Point(96, 142);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.ReadOnly = false;
            this.cmbFlag.Size = new System.Drawing.Size(141, 20);
            this.cmbFlag.TabIndex = 3;
            this.cmbFlag.TMpEnabled = true;
            this.cmbFlag.ToolTipValid = null;
            this.cmbFlag.ValidEable = true;
            this.cmbFlag.ValueMember = "L3DataTable.Code";
            this.cmbFlag.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // dsFlag
            // 
            this.dsFlag.AutoLoad = true;
            this.dsFlag.AutoSubscribe = false;
            this.dsFlag.DataSetName = "L3DataSet";
            this.dsFlag.DeleteMethod = "";
            this.dsFlag.InsertMethod = "";
            this.dsFlag.L3DataAdapter = this.Adapter;
            this.dsFlag.LoadEvent = "";
            this.dsFlag.LoadTrigger = null;
            this.dsFlag.RefreshValve = 1000;
            this.dsFlag.SourceCommand = null;
            this.dsFlag.SourceCondition = "Code_Group = \'COMMON_YESNO\' order by Code desc";
            this.dsFlag.SourceMethod = "";
            this.dsFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsFlag.SubscribeTarget = null;
            this.dsFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFlag});
            this.dsFlag.UpdateEvent = "";
            this.dsFlag.UpdateMethod = "";
            this.dsFlag.UpdateTrigger = null;
            // 
            // schemadsFlag
            // 
            this.schemadsFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFlagL3DataTableCode,
            this.coldsFlagL3DataTableCode_Des});
            this.schemadsFlag.TableName = "L3DataTable";
            // 
            // coldsFlagL3DataTableCode
            // 
            this.coldsFlagL3DataTableCode.Caption = "Code";
            this.coldsFlagL3DataTableCode.ColumnName = "Code";
            this.coldsFlagL3DataTableCode.Namespace = "";
            // 
            // coldsFlagL3DataTableCode_Des
            // 
            this.coldsFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFlagL3DataTableCode_Des.Namespace = "";
            // 
            // cmbMoldID
            // 
            this.cmbMoldID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMoldID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMoldID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsInstall, "MoldID", true));
            this.cmbMoldID.DataSource = this.dsMoldID;
            this.cmbMoldID.DisplayMember = "L3DataTable.MoldID";
            this.cmbMoldID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoldID.EnableNull = false;
            this.cmbMoldID.ErropPr = this.errorProvider1;
            this.cmbMoldID.FormattingEnabled = true;
            this.cmbMoldID.Location = new System.Drawing.Point(97, 88);
            this.cmbMoldID.Name = "cmbMoldID";
            this.cmbMoldID.ReadOnly = false;
            this.cmbMoldID.Size = new System.Drawing.Size(141, 20);
            this.cmbMoldID.TabIndex = 3;
            this.cmbMoldID.TMpEnabled = true;
            this.cmbMoldID.ToolTipValid = this.toolTip1;
            this.cmbMoldID.ValidEable = true;
            this.cmbMoldID.ValueMember = "L3DataTable.MoldID";
            this.cmbMoldID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // dsMoldID
            // 
            this.dsMoldID.AutoLoad = true;
            this.dsMoldID.AutoSubscribe = false;
            this.dsMoldID.DataSetName = "L3DataSet";
            this.dsMoldID.DeleteMethod = null;
            this.dsMoldID.InsertMethod = null;
            this.dsMoldID.L3DataAdapter = this.Adapter;
            this.dsMoldID.LoadEvent = "Click";
            this.dsMoldID.LoadTrigger = null;
            this.dsMoldID.RefreshValve = 1000;
            this.dsMoldID.SourceCommand = null;
            this.dsMoldID.SourceCondition = "MoldID Like \'J0%\' or MoldID Like \'J9%\' order by MoldID ASC";
            this.dsMoldID.SourceMethod = "";
            this.dsMoldID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMoldID.SourceURI = "XGMESLogic\\MoldMag\\CMold_Base";
            this.dsMoldID.SubscribeTarget = null;
            this.dsMoldID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMoldID});
            this.dsMoldID.UpdateEvent = "Click";
            this.dsMoldID.UpdateMethod = null;
            this.dsMoldID.UpdateTrigger = null;
            // 
            // schemadsMoldID
            // 
            this.schemadsMoldID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMoldIDL3DataTableMoldID});
            this.schemadsMoldID.TableName = "L3DataTable";
            // 
            // coldsMoldIDL3DataTableMoldID
            // 
            this.coldsMoldIDL3DataTableMoldID.Caption = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.ColumnName = "MoldID";
            this.coldsMoldIDL3DataTableMoldID.Namespace = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "打压是否合格:";
            // 
            // txtCopperID
            // 
            this.txtCopperID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Copper_ID", true));
            this.txtCopperID.DisplayPrecision = 0;
            this.txtCopperID.EnableNull = false;
            this.txtCopperID.ErropPr = this.errorProvider1;
            this.txtCopperID.FixedLength = 0;
            this.txtCopperID.Length = 0;
            this.txtCopperID.Location = new System.Drawing.Point(97, 113);
            this.txtCopperID.Max = 0;
            this.txtCopperID.MaxNull = 0;
            this.txtCopperID.MaxStringLength = 0;
            this.txtCopperID.MaxStrLength = 0;
            this.txtCopperID.Min = 0;
            this.txtCopperID.MinNull = 0;
            this.txtCopperID.MinStringLength = 0;
            this.txtCopperID.MinStrLength = 0;
            this.txtCopperID.Name = "txtCopperID";
            this.txtCopperID.Precision = 0;
            this.txtCopperID.Regex = "";
            this.txtCopperID.Size = new System.Drawing.Size(141, 21);
            this.txtCopperID.TabIndex = 4;
            this.txtCopperID.ToolTipValid = this.toolTip1;
            this.txtCopperID.VaildWarning = "";
            this.txtCopperID.ValidEable = true;
            this.txtCopperID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtCopperID.TextChanged += new System.EventHandler(this.pxControls_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(35, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "铜管编号:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(23, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 43;
            this.label19.Text = "结晶器编号:";
            // 
            // dtRepairEndTime
            // 
            this.dtRepairEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtRepairEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInstall, "Repair_End_Time", true));
            this.dtRepairEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRepairEndTime.Location = new System.Drawing.Point(356, 37);
            this.dtRepairEndTime.Name = "dtRepairEndTime";
            this.dtRepairEndTime.Size = new System.Drawing.Size(141, 21);
            this.dtRepairEndTime.TabIndex = 6;
            // 
            // dtInstallDate
            // 
            this.dtInstallDate.CustomFormat = "yyyy-MM-dd";
            this.dtInstallDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsInstall, "Install_Date", true));
            this.dtInstallDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInstallDate.Location = new System.Drawing.Point(97, 37);
            this.dtInstallDate.Name = "dtInstallDate";
            this.dtInstallDate.Size = new System.Drawing.Size(141, 21);
            this.dtInstallDate.TabIndex = 1;
            // 
            // dtRepairStartTime
            // 
            this.dtRepairStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtRepairStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInstall, "Repair_Start_Time", true));
            this.dtRepairStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRepairStartTime.Location = new System.Drawing.Point(356, 11);
            this.dtRepairStartTime.Name = "dtRepairStartTime";
            this.dtRepairStartTime.Size = new System.Drawing.Size(141, 21);
            this.dtRepairStartTime.TabIndex = 5;
            // 
            // dtInputTime
            // 
            this.dtInputTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtInputTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsInstall, "Input_Time", true));
            this.dtInputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInputTime.Location = new System.Drawing.Point(97, 11);
            this.dtInputTime.Name = "dtInputTime";
            this.dtInputTime.Size = new System.Drawing.Size(141, 21);
            this.dtInputTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(268, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "维修结束时间:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(35, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "安装日期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(268, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 37;
            this.label2.Text = "维修开始时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(35, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "录入时间:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(410, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(329, 307);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // MoldPipeInstallMagShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MoldPipeInstallMagShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结晶器铜管装配实绩信息维护";
            this.Load += new System.EventHandler(this.MoldPipeInstallMagShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCopperFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMoldID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMoldID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsInstall;
        private AppSvrHMI.L3DataSet dsInstall;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DateTimePicker dtRepairEndTime;
        private System.Windows.Forms.DateTimePicker dtInstallDate;
        private System.Windows.Forms.DateTimePicker dtRepairStartTime;
        private System.Windows.Forms.DateTimePicker dtInputTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxComboBox cmbCopperFac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxTextBox txtCopperID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private PxDataValid.PxComboBox cmbShiftID;
        private PxDataValid.PxComboBox cmbTeamID;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private PxDataValid.PxTextBox txtInstallPer;
        private System.Windows.Forms.Label label7;
        private PxDataValid.PxTextBox txtRepairContent;
        private System.Windows.Forms.Label label8;
        private PxDataValid.PxRichTextBox rtxtNote;
        private System.Windows.Forms.Label label46;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label47;
        private System.Data.DataTable schemadsInstall;
        private System.Data.DataColumn coldsInstallL3DataTableGUID;
        private System.Data.DataColumn coldsInstallL3DataTableName;
        private System.Data.DataColumn coldsInstallL3DataTableInput_Time;
        private System.Data.DataColumn coldsInstallL3DataTableInstall_Date;
        private System.Data.DataColumn coldsInstallL3DataTableMoldID;
        private System.Data.DataColumn coldsInstallL3DataTableHit_Press_Flag;
        private System.Data.DataColumn coldsInstallL3DataTableCopper_ID;
        private System.Data.DataColumn coldsInstallL3DataTableCopper_Fac;
        private System.Data.DataColumn coldsInstallL3DataTableInstall_Per;
        private System.Data.DataColumn coldsInstallL3DataTableRepair_Start_Time;
        private System.Data.DataColumn coldsInstallL3DataTableRepair_End_Time;
        private System.Data.DataColumn coldsInstallL3DataTableRepair_Content;
        private System.Data.DataColumn coldsInstallL3DataTableTeamID;
        private System.Data.DataColumn coldsInstallL3DataTableShiftID;
        private System.Data.DataColumn coldsInstallL3DataTableOperator;
        private System.Data.DataColumn coldsInstallL3DataTableNote;
        private PxDataValid.PxComboBox cmbMoldID;
        private AppSvrHMI.L3DataSet dsMoldID;
        private System.Data.DataTable schemadsMoldID;
        private System.Data.DataColumn coldsMoldIDL3DataTableMoldID;
        private AppSvrHMI.L3DataSet dsCopperFac;
        private System.Data.DataTable schemadsCopperFac;
        private System.Data.DataColumn coldsCopperFacL3DataTableMatFactory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsInstallL3DataTableInStallID;
        private PxDataValid.PxComboBox cmbFlag;
        private AppSvrHMI.L3DataSet dsFlag;
        private System.Data.DataTable schemadsFlag;
        private System.Data.DataColumn coldsFlagL3DataTableCode;
        private System.Data.DataColumn coldsFlagL3DataTableCode_Des;
    }
}