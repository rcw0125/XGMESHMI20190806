namespace DispatchMag
{
    partial class ProcessTimeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessTimeFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvProcessTime = new System.Windows.Forms.DataGridView();
            this.ObjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.Team = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTablecode = new System.Data.DataColumn();
            this.coldsTeamL3DataTablecode_des = new System.Data.DataColumn();
            this.ProcessType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsProcessTimeType = new AppSvrHMI.L3DataSet();
            this.schemadsProcessTimeType = new System.Data.DataTable();
            this.coldsProcessTimeTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsProcessTimeTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.ProcessTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsProcessTime = new System.Windows.Forms.BindingSource(this.components);
            this.dsProcessTime = new AppSvrHMI.L3DataSet();
            this.schemadsProcessTime = new System.Data.DataTable();
            this.coldsProcessTimeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableName = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableProductDate = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableTeam = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableProcessType = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableProcessTime = new System.Data.DataColumn();
            this.coldsProcessTimeL3DataTableCreateTime = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtNoteEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtNoteData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProcessTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcessTimeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcessTimeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcessTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcessTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcessTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvProcessTime);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(908, 376);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvProcessTime
            // 
            this.dvProcessTime.AllowUserToAddRows = false;
            this.dvProcessTime.AutoGenerateColumns = false;
            this.dvProcessTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvProcessTime.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvProcessTime.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvProcessTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjectID,
            this.ProductDate,
            this.UnitID,
            this.Team,
            this.ProcessType,
            this.ProcessTime,
            this.CreateTime});
            this.dvProcessTime.DataSource = this.bsProcessTime;
            this.dvProcessTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvProcessTime.Location = new System.Drawing.Point(0, 25);
            this.dvProcessTime.Name = "dvProcessTime";
            this.dvProcessTime.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvProcessTime.RowTemplate.Height = 23;
            this.dvProcessTime.Size = new System.Drawing.Size(908, 351);
            this.dvProcessTime.TabIndex = 29;
            this.dvProcessTime.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDispAccount_DataError);
            // 
            // ObjectID
            // 
            this.ObjectID.DataPropertyName = "ObjectID";
            this.ObjectID.HeaderText = "对象ID";
            this.ObjectID.Name = "ObjectID";
            this.ObjectID.Visible = false;
            // 
            // ProductDate
            // 
            this.ProductDate.DataPropertyName = "ProductDate";
            this.ProductDate.HeaderText = "生产日期";
            this.ProductDate.Name = "ProductDate";
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.DataSource = this.dsUnitID;
            this.UnitID.DisplayMember = "L3DataTable.Code_Des";
            this.UnitID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UnitID.HeaderText = "机组";
            this.UnitID.Name = "UnitID";
            this.UnitID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitID.ValueMember = "L3DataTable.Code";
            // 
            // dsUnitID
            // 
            this.dsUnitID.AutoSubscribe = true;
            this.dsUnitID.DataSetName = "L3DataSet";
            this.dsUnitID.DeleteMethod = "";
            this.dsUnitID.InsertMethod = "";
            this.dsUnitID.L3DataAdapter = this.Adapter;
            this.dsUnitID.LoadEvent = "";
            this.dsUnitID.LoadTrigger = null;
            this.dsUnitID.RefreshValve = 1000;
            this.dsUnitID.SourceCommand = null;
            this.dsUnitID.SourceCondition = "(code_group =\'BOF\' or code_group =\'Caster\' or code_group =\'LF\' or code_group =\'RH" +
                "\') and code is not null";
            this.dsUnitID.SourceMethod = "";
            this.dsUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitID.SubscribeTarget = null;
            this.dsUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUnitID});
            this.dsUnitID.UpdateEvent = "";
            this.dsUnitID.UpdateMethod = "";
            this.dsUnitID.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsUnitID
            // 
            this.schemadsUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUnitIDL3DataTableCode,
            this.coldsUnitIDL3DataTableCode_Des});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTableCode
            // 
            this.coldsUnitIDL3DataTableCode.Caption = "Code";
            this.coldsUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsUnitIDL3DataTableCode_Des
            // 
            this.coldsUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // Team
            // 
            this.Team.DataPropertyName = "Team";
            this.Team.DataSource = this.dsTeam;
            this.Team.DisplayMember = "L3DataTable.code_des";
            this.Team.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Team.HeaderText = "班别";
            this.Team.Name = "Team";
            this.Team.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Team.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Team.ValueMember = "L3DataTable.code";
            // 
            // dsTeam
            // 
            this.dsTeam.AutoSubscribe = true;
            this.dsTeam.DataSetName = "L3DataSet";
            this.dsTeam.DeleteMethod = null;
            this.dsTeam.InsertMethod = null;
            this.dsTeam.L3DataAdapter = this.Adapter;
            this.dsTeam.LoadEvent = "Click";
            this.dsTeam.LoadTrigger = null;
            this.dsTeam.RefreshValve = 1000;
            this.dsTeam.SourceCommand = null;
            this.dsTeam.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeam.SourceMethod = "";
            this.dsTeam.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam.SubscribeTarget = null;
            this.dsTeam.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam});
            this.dsTeam.UpdateEvent = "Click";
            this.dsTeam.UpdateMethod = null;
            this.dsTeam.UpdateTrigger = null;
            // 
            // schemadsTeam
            // 
            this.schemadsTeam.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamL3DataTablecode,
            this.coldsTeamL3DataTablecode_des});
            this.schemadsTeam.TableName = "L3DataTable";
            // 
            // coldsTeamL3DataTablecode
            // 
            this.coldsTeamL3DataTablecode.Caption = "code";
            this.coldsTeamL3DataTablecode.ColumnName = "code";
            this.coldsTeamL3DataTablecode.Namespace = "";
            // 
            // coldsTeamL3DataTablecode_des
            // 
            this.coldsTeamL3DataTablecode_des.Caption = "code_des";
            this.coldsTeamL3DataTablecode_des.ColumnName = "code_des";
            this.coldsTeamL3DataTablecode_des.Namespace = "";
            // 
            // ProcessType
            // 
            this.ProcessType.DataPropertyName = "ProcessType";
            this.ProcessType.DataSource = this.dsProcessTimeType;
            this.ProcessType.DisplayMember = "L3DataTable.Code_Des";
            this.ProcessType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ProcessType.HeaderText = "作业类型";
            this.ProcessType.Name = "ProcessType";
            this.ProcessType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProcessType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProcessType.ValueMember = "L3DataTable.Code";
            // 
            // dsProcessTimeType
            // 
            this.dsProcessTimeType.AutoSubscribe = true;
            this.dsProcessTimeType.DataSetName = "L3DataSet";
            this.dsProcessTimeType.DeleteMethod = "";
            this.dsProcessTimeType.InsertMethod = "";
            this.dsProcessTimeType.L3DataAdapter = this.Adapter;
            this.dsProcessTimeType.LoadEvent = "";
            this.dsProcessTimeType.LoadTrigger = null;
            this.dsProcessTimeType.RefreshValve = 1000;
            this.dsProcessTimeType.SourceCommand = null;
            this.dsProcessTimeType.SourceCondition = "CODE_GROUP = \'Process_Time_Type\'";
            this.dsProcessTimeType.SourceMethod = "";
            this.dsProcessTimeType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcessTimeType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsProcessTimeType.SubscribeTarget = null;
            this.dsProcessTimeType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcessTimeType});
            this.dsProcessTimeType.UpdateEvent = "";
            this.dsProcessTimeType.UpdateMethod = "";
            this.dsProcessTimeType.UpdateTrigger = null;
            // 
            // schemadsProcessTimeType
            // 
            this.schemadsProcessTimeType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcessTimeTypeL3DataTableCode,
            this.coldsProcessTimeTypeL3DataTableCode_Des});
            this.schemadsProcessTimeType.TableName = "L3DataTable";
            // 
            // coldsProcessTimeTypeL3DataTableCode
            // 
            this.coldsProcessTimeTypeL3DataTableCode.Caption = "Code";
            this.coldsProcessTimeTypeL3DataTableCode.ColumnName = "Code";
            this.coldsProcessTimeTypeL3DataTableCode.Namespace = "";
            // 
            // coldsProcessTimeTypeL3DataTableCode_Des
            // 
            this.coldsProcessTimeTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsProcessTimeTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsProcessTimeTypeL3DataTableCode_Des.Namespace = "";
            // 
            // ProcessTime
            // 
            this.ProcessTime.DataPropertyName = "ProcessTime";
            this.ProcessTime.HeaderText = "作业时间";
            this.ProcessTime.Name = "ProcessTime";
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建日期";
            this.CreateTime.Name = "CreateTime";
            // 
            // bsProcessTime
            // 
            this.bsProcessTime.DataMember = "L3DataTable";
            this.bsProcessTime.DataSource = this.dsProcessTime;
            // 
            // dsProcessTime
            // 
            this.dsProcessTime.AutoSubscribe = true;
            this.dsProcessTime.DataSetName = "L3DataSet";
            this.dsProcessTime.DeleteMethod = "";
            this.dsProcessTime.InsertMethod = "";
            this.dsProcessTime.L3DataAdapter = this.Adapter;
            this.dsProcessTime.LoadEvent = "";
            this.dsProcessTime.LoadTrigger = null;
            this.dsProcessTime.RefreshValve = 1000;
            this.dsProcessTime.SourceCommand = null;
            this.dsProcessTime.SourceCondition = " 1=2";
            this.dsProcessTime.SourceMethod = "";
            this.dsProcessTime.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsProcessTime.SourceURI = "XGMESLogic\\DispatchMag\\CDisp_Unit_ProcessTime";
            this.dsProcessTime.SubscribeTarget = null;
            this.dsProcessTime.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsProcessTime});
            this.dsProcessTime.UpdateEvent = "";
            this.dsProcessTime.UpdateMethod = "";
            this.dsProcessTime.UpdateTrigger = null;
            // 
            // schemadsProcessTime
            // 
            this.schemadsProcessTime.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsProcessTimeL3DataTableGUID,
            this.coldsProcessTimeL3DataTableName,
            this.coldsProcessTimeL3DataTableObjectID,
            this.coldsProcessTimeL3DataTableProductDate,
            this.coldsProcessTimeL3DataTableUnitID,
            this.coldsProcessTimeL3DataTableTeam,
            this.coldsProcessTimeL3DataTableProcessType,
            this.coldsProcessTimeL3DataTableProcessTime,
            this.coldsProcessTimeL3DataTableCreateTime});
            this.schemadsProcessTime.TableName = "L3DataTable";
            // 
            // coldsProcessTimeL3DataTableGUID
            // 
            this.coldsProcessTimeL3DataTableGUID.Caption = "GUID";
            this.coldsProcessTimeL3DataTableGUID.ColumnName = "GUID";
            this.coldsProcessTimeL3DataTableGUID.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableName
            // 
            this.coldsProcessTimeL3DataTableName.Caption = "Name";
            this.coldsProcessTimeL3DataTableName.ColumnName = "Name";
            this.coldsProcessTimeL3DataTableName.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableObjectID
            // 
            this.coldsProcessTimeL3DataTableObjectID.Caption = "ObjectID";
            this.coldsProcessTimeL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsProcessTimeL3DataTableObjectID.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableProductDate
            // 
            this.coldsProcessTimeL3DataTableProductDate.Caption = "ProductDate";
            this.coldsProcessTimeL3DataTableProductDate.ColumnName = "ProductDate";
            this.coldsProcessTimeL3DataTableProductDate.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableUnitID
            // 
            this.coldsProcessTimeL3DataTableUnitID.Caption = "UnitID";
            this.coldsProcessTimeL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsProcessTimeL3DataTableUnitID.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableTeam
            // 
            this.coldsProcessTimeL3DataTableTeam.Caption = "Team";
            this.coldsProcessTimeL3DataTableTeam.ColumnName = "Team";
            this.coldsProcessTimeL3DataTableTeam.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableProcessType
            // 
            this.coldsProcessTimeL3DataTableProcessType.Caption = "ProcessType";
            this.coldsProcessTimeL3DataTableProcessType.ColumnName = "ProcessType";
            this.coldsProcessTimeL3DataTableProcessType.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableProcessTime
            // 
            this.coldsProcessTimeL3DataTableProcessTime.Caption = "ProcessTime";
            this.coldsProcessTimeL3DataTableProcessTime.ColumnName = "ProcessTime";
            this.coldsProcessTimeL3DataTableProcessTime.DataType = typeof(int);
            this.coldsProcessTimeL3DataTableProcessTime.Namespace = "";
            // 
            // coldsProcessTimeL3DataTableCreateTime
            // 
            this.coldsProcessTimeL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsProcessTimeL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsProcessTimeL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsProcessTimeL3DataTableCreateTime.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsProcessTime;
            this.bdN1.CountItem = null;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnQuery,
            this.dtNoteEndData,
            this.toolStripLabel3,
            this.dtNoteData,
            this.toolStripLabel6,
            this.btnAdd,
            this.btnDelete,
            this.btnConfirm,
            this.btnCancel});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = null;
            this.bdN1.MoveLastItem = null;
            this.bdN1.MoveNextItem = null;
            this.bdN1.MovePreviousItem = null;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = null;
            this.bdN1.Size = new System.Drawing.Size(908, 25);
            this.bdN1.TabIndex = 28;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtNoteEndData
            // 
            this.dtNoteEndData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtNoteEndData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtNoteEndData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtNoteEndData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtNoteEndData.CustomFormat = "yyyy-MM-dd";
            this.dtNoteEndData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNoteEndData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNoteEndData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtNoteEndData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNoteEndData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtNoteEndData.Name = "dtNoteEndData";
            this.dtNoteEndData.Size = new System.Drawing.Size(100, 22);
            this.dtNoteEndData.Text = "2009-01-04";
            this.dtNoteEndData.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel3.Text = "－";
            // 
            // dtNoteData
            // 
            this.dtNoteData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtNoteData.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtNoteData.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtNoteData.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtNoteData.CustomFormat = "yyyy-MM-dd";
            this.dtNoteData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNoteData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNoteData.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtNoteData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNoteData.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtNoteData.Name = "dtNoteData";
            this.dtNoteData.Size = new System.Drawing.Size(100, 22);
            this.dtNoteData.Text = "2008-11-16";
            this.dtNoteData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "生产日期:";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(49, 22);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 22);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProcessTimeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 376);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProcessTimeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "处理时间管理";
            this.Text = "处理时间管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessTimeFrm_FormClosing);
            this.Load += new System.EventHandler(this.ProcessTimeFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvProcessTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcessTimeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcessTimeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcessTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProcessTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsProcessTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtNoteData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dvProcessTime;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsProcessTime;
        private buttonHide.ToolStripToriDateTimePicker dtNoteEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTablecode;
        private System.Data.DataColumn coldsTeamL3DataTablecode_des;
        private AppSvrHMI.L3DataSet dsProcessTime;
        private System.Data.DataTable schemadsProcessTime;
        private System.Data.DataColumn coldsProcessTimeL3DataTableGUID;
        private System.Data.DataColumn coldsProcessTimeL3DataTableName;
        private System.Data.DataColumn coldsProcessTimeL3DataTableObjectID;
        private System.Data.DataColumn coldsProcessTimeL3DataTableProductDate;
        private System.Data.DataColumn coldsProcessTimeL3DataTableUnitID;
        private System.Data.DataColumn coldsProcessTimeL3DataTableTeam;
        private System.Data.DataColumn coldsProcessTimeL3DataTableProcessType;
        private System.Data.DataColumn coldsProcessTimeL3DataTableProcessTime;
        private System.Data.DataColumn coldsProcessTimeL3DataTableCreateTime;
        private AppSvrHMI.L3DataSet dsProcessTimeType;
        private System.Data.DataTable schemadsProcessTimeType;
        private System.Data.DataColumn coldsProcessTimeTypeL3DataTableCode;
        private System.Data.DataColumn coldsProcessTimeTypeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsUnitID;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsUnitIDL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Team;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProcessType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}