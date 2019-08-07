namespace DispatchMag
{
    partial class DisExcepitonalShowFrm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbTeam = new System.Windows.Forms.ComboBox();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableIDObject = new System.Data.DataColumn();
            this.coldsMainL3DataTableCreateDate = new System.Data.DataColumn();
            this.coldsMainL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsMainL3DataTableShift = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeam = new System.Data.DataColumn();
            this.coldsMainL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSendFlag = new System.Data.DataColumn();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.bsShift = new System.Windows.Forms.BindingSource(this.components);
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTablePK_SHIFT = new System.Data.DataColumn();
            this.coldsShiftL3DataTableSHIFT_CODE = new System.Data.DataColumn();
            this.coldsShiftL3DataTableSHIFT_NAME = new System.Data.DataColumn();
            this.cmbUnitID = new System.Windows.Forms.ComboBox();
            this.bsUnitID = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTablePK_CENTER = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCENTER_NAME = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCENTER_CODE = new System.Data.DataColumn();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.dtCreatTime = new System.Windows.Forms.DateTimePicker();
            this.dtCreatDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTablePK_TEAM = new System.Data.DataColumn();
            this.coldsTeamL3DataTableTEAM_CODE = new System.Data.DataColumn();
            this.coldsTeamL3DataTableteam_name = new System.Data.DataColumn();
            this.coldsTeamL3DataTablepk_center = new System.Data.DataColumn();
            this.bsTeam = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 230);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(357, 56);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(188, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
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
            this.tabControl1.Size = new System.Drawing.Size(357, 230);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbTeam);
            this.tabPage1.Controls.Add(this.cmbShift);
            this.tabPage1.Controls.Add(this.cmbUnitID);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.dtCreatTime);
            this.tabPage1.Controls.Add(this.dtCreatDate);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(349, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbTeam
            // 
            this.cmbTeam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Team", true));
            this.cmbTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam.FormattingEnabled = true;
            this.cmbTeam.Location = new System.Drawing.Point(108, 127);
            this.cmbTeam.Name = "cmbTeam";
            this.cmbTeam.Size = new System.Drawing.Size(173, 20);
            this.cmbTeam.TabIndex = 3;
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
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
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
            this.coldsMainL3DataTableIDObject,
            this.coldsMainL3DataTableCreateDate,
            this.coldsMainL3DataTableUnitID,
            this.coldsMainL3DataTableShift,
            this.coldsMainL3DataTableTeam,
            this.coldsMainL3DataTableCreateTime,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableSendFlag});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableIDObject
            // 
            this.coldsMainL3DataTableIDObject.Caption = "IDObject";
            this.coldsMainL3DataTableIDObject.ColumnName = "IDObject";
            this.coldsMainL3DataTableIDObject.Namespace = "";
            // 
            // coldsMainL3DataTableCreateDate
            // 
            this.coldsMainL3DataTableCreateDate.Caption = "CreateDate";
            this.coldsMainL3DataTableCreateDate.ColumnName = "CreateDate";
            this.coldsMainL3DataTableCreateDate.Namespace = "";
            // 
            // coldsMainL3DataTableUnitID
            // 
            this.coldsMainL3DataTableUnitID.Caption = "UnitID";
            this.coldsMainL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsMainL3DataTableUnitID.Namespace = "";
            // 
            // coldsMainL3DataTableShift
            // 
            this.coldsMainL3DataTableShift.Caption = "Shift";
            this.coldsMainL3DataTableShift.ColumnName = "Shift";
            this.coldsMainL3DataTableShift.Namespace = "";
            // 
            // coldsMainL3DataTableTeam
            // 
            this.coldsMainL3DataTableTeam.Caption = "Team";
            this.coldsMainL3DataTableTeam.ColumnName = "Team";
            this.coldsMainL3DataTableTeam.Namespace = "";
            // 
            // coldsMainL3DataTableCreateTime
            // 
            this.coldsMainL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsMainL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsMainL3DataTableCreateTime.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "Operator";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // coldsMainL3DataTableSendFlag
            // 
            this.coldsMainL3DataTableSendFlag.Caption = "SendFlag";
            this.coldsMainL3DataTableSendFlag.ColumnName = "SendFlag";
            this.coldsMainL3DataTableSendFlag.DataType = typeof(int);
            this.coldsMainL3DataTableSendFlag.DefaultValue = 0;
            this.coldsMainL3DataTableSendFlag.Namespace = "";
            // 
            // cmbShift
            // 
            this.cmbShift.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Shift", true));
            this.cmbShift.DataSource = this.bsShift;
            this.cmbShift.DisplayMember = "SHIFT_NAME";
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(108, 102);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(173, 20);
            this.cmbShift.TabIndex = 3;
            this.cmbShift.ValueMember = "PK_SHIFT";
            // 
            // bsShift
            // 
            this.bsShift.DataMember = "L3DataTable";
            this.bsShift.DataSource = this.dsShift;
            // 
            // dsShift
            // 
            this.dsShift.AutoSubscribe = false;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = "";
            this.dsShift.InsertMethod = "";
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsShift.SourceURI = "";
            this.dsShift.SubscribeTarget = "";
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "";
            this.dsShift.UpdateMethod = "";
            this.dsShift.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTablePK_SHIFT,
            this.coldsShiftL3DataTableSHIFT_CODE,
            this.coldsShiftL3DataTableSHIFT_NAME});
            this.schemadsShift.TableName = "L3DataTable";
            // 
            // coldsShiftL3DataTablePK_SHIFT
            // 
            this.coldsShiftL3DataTablePK_SHIFT.Caption = "PK_SHIFT";
            this.coldsShiftL3DataTablePK_SHIFT.ColumnName = "PK_SHIFT";
            this.coldsShiftL3DataTablePK_SHIFT.Namespace = "";
            // 
            // coldsShiftL3DataTableSHIFT_CODE
            // 
            this.coldsShiftL3DataTableSHIFT_CODE.Caption = "SHIFT_CODE";
            this.coldsShiftL3DataTableSHIFT_CODE.ColumnName = "SHIFT_CODE";
            this.coldsShiftL3DataTableSHIFT_CODE.Namespace = "";
            // 
            // coldsShiftL3DataTableSHIFT_NAME
            // 
            this.coldsShiftL3DataTableSHIFT_NAME.Caption = "SHIFT_NAME";
            this.coldsShiftL3DataTableSHIFT_NAME.ColumnName = "SHIFT_NAME";
            this.coldsShiftL3DataTableSHIFT_NAME.Namespace = "";
            // 
            // cmbUnitID
            // 
            this.cmbUnitID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "UnitID", true));
            this.cmbUnitID.DataSource = this.bsUnitID;
            this.cmbUnitID.DisplayMember = "CENTER_CODE";
            this.cmbUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitID.FormattingEnabled = true;
            this.cmbUnitID.Location = new System.Drawing.Point(108, 77);
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(173, 20);
            this.cmbUnitID.TabIndex = 3;
            this.cmbUnitID.ValueMember = "PK_CENTER";
            this.cmbUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbUnitID_SelectedIndexChanged);
            // 
            // bsUnitID
            // 
            this.bsUnitID.DataMember = "L3DataTable";
            this.bsUnitID.DataSource = this.dsUnitID;
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoSubscribe = false;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsUnitID.SourceURI = "";
            this.dsUnitID.SubscribeTarget = "";
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTablePK_CENTER,
            this.coldsUnitIDL3DataTableCENTER_NAME,
            this.coldsUnitIDL3DataTableCENTER_CODE});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTablePK_CENTER
            // 
            this.coldsUnitIDL3DataTablePK_CENTER.Caption = "PK_CENTER";
            this.coldsUnitIDL3DataTablePK_CENTER.ColumnName = "PK_CENTER";
            this.coldsUnitIDL3DataTablePK_CENTER.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCENTER_NAME
            // 
            this.coldsUnitIDL3DataTableCENTER_NAME.Caption = "CENTER_NAME";
            this.coldsUnitIDL3DataTableCENTER_NAME.ColumnName = "CENTER_NAME";
            this.coldsUnitIDL3DataTableCENTER_NAME.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCENTER_CODE
            // 
            this.coldsUnitIDL3DataTableCENTER_CODE.Caption = "CENTER_CODE";
            this.coldsUnitIDL3DataTableCENTER_CODE.ColumnName = "CENTER_CODE";
            this.coldsUnitIDL3DataTableCENTER_CODE.Namespace = "";
            // 
            // txtOperator
            // 
            this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Operator", true));
            this.txtOperator.Location = new System.Drawing.Point(108, 152);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(173, 21);
            this.txtOperator.TabIndex = 2;
            // 
            // dtCreatTime
            // 
            this.dtCreatTime.CustomFormat = "HH:mm:ss";
            this.dtCreatTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "CreateTime", true));
            this.dtCreatTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatTime.Location = new System.Drawing.Point(108, 51);
            this.dtCreatTime.Name = "dtCreatTime";
            this.dtCreatTime.ShowUpDown = true;
            this.dtCreatTime.Size = new System.Drawing.Size(173, 21);
            this.dtCreatTime.TabIndex = 1;
            // 
            // dtCreatDate
            // 
            this.dtCreatDate.CustomFormat = "yyyy-MM-dd";
            this.dtCreatDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "CreateDate", true));
            this.dtCreatDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreatDate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtCreatDate.Location = new System.Drawing.Point(108, 25);
            this.dtCreatDate.Name = "dtCreatDate";
            this.dtCreatDate.Size = new System.Drawing.Size(173, 21);
            this.dtCreatDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "创建时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "责任人:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "班别:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "班次:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "工作中心:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期:";
            // 
            // dsTeam
            // 
            this.dsTeam.AutoSubscribe = false;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = "";
            this.dsTeam.InsertMethod = "";
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsTeam.SourceURI = "";
            this.dsTeam.SubscribeTarget = "";
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "";
            this.dsTeam.UpdateMethod = "";
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTablePK_TEAM,
            this.coldsTeamL3DataTableTEAM_CODE,
            this.coldsTeamL3DataTableteam_name,
            this.coldsTeamL3DataTablepk_center});
            this.schemadsTeam.TableName = "L3DataTable";
            // 
            // coldsTeamL3DataTablePK_TEAM
            // 
            this.coldsTeamL3DataTablePK_TEAM.Caption = "PK_TEAM";
            this.coldsTeamL3DataTablePK_TEAM.ColumnName = "PK_TEAM";
            this.coldsTeamL3DataTablePK_TEAM.Namespace = "";
            // 
            // coldsTeamL3DataTableTEAM_CODE
            // 
            this.coldsTeamL3DataTableTEAM_CODE.Caption = "TEAM_CODE";
            this.coldsTeamL3DataTableTEAM_CODE.ColumnName = "TEAM_CODE";
            this.coldsTeamL3DataTableTEAM_CODE.Namespace = "";
            // 
            // coldsTeamL3DataTableteam_name
            // 
            this.coldsTeamL3DataTableteam_name.Caption = "team_name";
            this.coldsTeamL3DataTableteam_name.ColumnName = "team_name";
            this.coldsTeamL3DataTableteam_name.Namespace = "";
            // 
            // coldsTeamL3DataTablepk_center
            // 
            this.coldsTeamL3DataTablepk_center.Caption = "pk_center";
            this.coldsTeamL3DataTablepk_center.ColumnName = "pk_center";
            this.coldsTeamL3DataTablepk_center.Namespace = "";
            // 
            // bsTeam
            // 
            this.bsTeam.DataMember = "L3DataTable";
            this.bsTeam.DataSource = this.dsTeam;
            this.bsTeam.Filter = "pk_center = \'\'";
            // 
            // DisExcepitonalShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 286);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DisExcepitonalShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备异常主信息";
            this.Load += new System.EventHandler(this.DisExcepitonalShowFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbUnitID;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.DateTimePicker dtCreatDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.DateTimePicker dtCreatTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTablePK_CENTER;
        private System.Data.DataColumn coldsUnitIDL3DataTableCENTER_NAME;
        private System.Data.DataColumn coldsUnitIDL3DataTableCENTER_CODE;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTablePK_SHIFT;
        private System.Data.DataColumn coldsShiftL3DataTableSHIFT_CODE;
        private System.Data.DataColumn coldsShiftL3DataTableSHIFT_NAME;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTablePK_TEAM;
        private System.Data.DataColumn coldsTeamL3DataTableTEAM_CODE;
        private System.Data.DataColumn coldsTeamL3DataTableteam_name;
        private System.Data.DataColumn coldsTeamL3DataTablepk_center;
        private AppSvrHMI.L3DataSet dsMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableIDObject;
        private System.Data.DataColumn coldsMainL3DataTableCreateDate;
        private System.Data.DataColumn coldsMainL3DataTableUnitID;
        private System.Data.DataColumn coldsMainL3DataTableShift;
        private System.Data.DataColumn coldsMainL3DataTableTeam;
        private System.Data.DataColumn coldsMainL3DataTableCreateTime;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableSendFlag;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsTeam;
        private System.Windows.Forms.ComboBox cmbTeam;
        private System.Windows.Forms.BindingSource bsShift;
        private System.Windows.Forms.BindingSource bsUnitID;
    }
}