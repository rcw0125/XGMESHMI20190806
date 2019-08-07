namespace PlanMag
{
    partial class DispAccountFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispAccountFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvDispAccount = new System.Windows.Forms.DataGridView();
            this.productDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCaster = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBOF = new System.Data.DataTable();
            this.coldsBOFL3DataTableCode = new System.Data.DataColumn();
            this.coldsBOFL3DataTableCode_Des = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeam = new AppSvrHMI.L3DataSet();
            this.schemadsTeam = new System.Data.DataTable();
            this.coldsTeamL3DataTablecode = new System.Data.DataColumn();
            this.coldsTeamL3DataTablecode_des = new System.Data.DataColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsAccountType = new AppSvrHMI.L3DataSet();
            this.schemadsAccountType = new System.Data.DataTable();
            this.coldsAccountTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAccountTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.AccountCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsibility_Organ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDispAccount = new System.Windows.Forms.BindingSource(this.components);
            this.dsDispAccount = new AppSvrHMI.L3DataSet();
            this.schemadsDispAccount = new System.Data.DataTable();
            this.coldsDispAccountL3DataTableGUID = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableName = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableProductDate = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableUnitID = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableTeam = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableAccountType = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableAccountCount = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableAccountReason = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableResponsibility_Organ = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsDispAccountL3DataTableAccountAmount = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtNoteEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtNoteData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbAccountType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtAccountType = new System.Windows.Forms.ToolStripTextBox();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.dsAccountReason = new AppSvrHMI.L3DataSet();
            this.schemadsAccountReasonUPRE = new System.Data.DataTable();
            this.coldsAccountReasonUPREL3DataTableCode = new System.Data.DataColumn();
            this.dsResponsibilityOrgan = new AppSvrHMI.L3DataSet();
            this.schemadsResponsibilityOrgan = new System.Data.DataTable();
            this.coldsResponsibilityOrganL3DataTableCode = new System.Data.DataColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDispAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAccountType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDispAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDispAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccountReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAccountReasonUPRE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResponsibilityOrgan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsResponsibilityOrgan)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvDispAccount);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(908, 376);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvDispAccount
            // 
            this.dvDispAccount.AllowUserToAddRows = false;
            this.dvDispAccount.AutoGenerateColumns = false;
            this.dvDispAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvDispAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvDispAccount.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvDispAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productDateDataGridViewTextBoxColumn,
            this.unitIDDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.accountTypeDataGridViewTextBoxColumn,
            this.AccountCount,
            this.AccountAmount,
            this.AccountReason,
            this.Responsibility_Organ,
            this.createTimeDataGridViewTextBoxColumn});
            this.dvDispAccount.DataSource = this.bsDispAccount;
            this.dvDispAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDispAccount.Location = new System.Drawing.Point(0, 25);
            this.dvDispAccount.Name = "dvDispAccount";
            this.dvDispAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvDispAccount.RowTemplate.Height = 23;
            this.dvDispAccount.Size = new System.Drawing.Size(908, 351);
            this.dvDispAccount.TabIndex = 29;
            this.dvDispAccount.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDispAccount_DataError);
            // 
            // productDateDataGridViewTextBoxColumn
            // 
            this.productDateDataGridViewTextBoxColumn.DataPropertyName = "ProductDate";
            this.productDateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.productDateDataGridViewTextBoxColumn.Name = "productDateDataGridViewTextBoxColumn";
            // 
            // unitIDDataGridViewTextBoxColumn
            // 
            this.unitIDDataGridViewTextBoxColumn.DataPropertyName = "UnitID";
            this.unitIDDataGridViewTextBoxColumn.DataSource = this.dsCaster;
            this.unitIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.unitIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIDDataGridViewTextBoxColumn.HeaderText = "机组";
            this.unitIDDataGridViewTextBoxColumn.Name = "unitIDDataGridViewTextBoxColumn";
            this.unitIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsCaster
            // 
            this.dsCaster.AutoLoad = true;
            this.dsCaster.AutoSubscribe = true;
            this.dsCaster.DataSetName = "L3DataSet";
            this.dsCaster.DeleteMethod = "";
            this.dsCaster.InsertMethod = "";
            this.dsCaster.L3DataAdapter = this.Adapter;
            this.dsCaster.LoadEvent = "";
            this.dsCaster.LoadTrigger = null;
            this.dsCaster.RefreshValve = 1000;
            this.dsCaster.SourceCommand = null;
            this.dsCaster.SourceCondition = "code_group = \'Caster\' order by code";
            this.dsCaster.SourceMethod = "";
            this.dsCaster.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCaster.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCaster.SubscribeTarget = null;
            this.dsCaster.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOF});
            this.dsCaster.UpdateEvent = "";
            this.dsCaster.UpdateMethod = "";
            this.dsCaster.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBOF
            // 
            this.schemadsBOF.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFL3DataTableCode,
            this.coldsBOFL3DataTableCode_Des});
            this.schemadsBOF.TableName = "L3DataTable";
            // 
            // coldsBOFL3DataTableCode
            // 
            this.coldsBOFL3DataTableCode.Caption = "Code";
            this.coldsBOFL3DataTableCode.ColumnName = "Code";
            this.coldsBOFL3DataTableCode.Namespace = "";
            // 
            // coldsBOFL3DataTableCode_Des
            // 
            this.coldsBOFL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBOFL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBOFL3DataTableCode_Des.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeam;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code";
            // 
            // dsTeam
            // 
            this.dsTeam.AutoLoad = true;
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
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountType";
            this.accountTypeDataGridViewTextBoxColumn.DataSource = this.dsAccountType;
            this.accountTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.accountTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "台帐类型";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accountTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accountTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsAccountType
            // 
            this.dsAccountType.AutoLoad = true;
            this.dsAccountType.AutoSubscribe = true;
            this.dsAccountType.DataSetName = "L3DataSet";
            this.dsAccountType.DeleteMethod = "";
            this.dsAccountType.InsertMethod = "";
            this.dsAccountType.L3DataAdapter = this.Adapter;
            this.dsAccountType.LoadEvent = "";
            this.dsAccountType.LoadTrigger = null;
            this.dsAccountType.RefreshValve = 1000;
            this.dsAccountType.SourceCommand = null;
            this.dsAccountType.SourceCondition = "CODE_GROUP = \'Account_Type\'";
            this.dsAccountType.SourceMethod = "";
            this.dsAccountType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAccountType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAccountType.SubscribeTarget = null;
            this.dsAccountType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAccountType});
            this.dsAccountType.UpdateEvent = "";
            this.dsAccountType.UpdateMethod = "";
            this.dsAccountType.UpdateTrigger = null;
            // 
            // schemadsAccountType
            // 
            this.schemadsAccountType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAccountTypeL3DataTableCode,
            this.coldsAccountTypeL3DataTableCode_Des});
            this.schemadsAccountType.TableName = "L3DataTable";
            // 
            // coldsAccountTypeL3DataTableCode
            // 
            this.coldsAccountTypeL3DataTableCode.Caption = "Code";
            this.coldsAccountTypeL3DataTableCode.ColumnName = "Code";
            this.coldsAccountTypeL3DataTableCode.Namespace = "";
            // 
            // coldsAccountTypeL3DataTableCode_Des
            // 
            this.coldsAccountTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAccountTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAccountTypeL3DataTableCode_Des.Namespace = "";
            // 
            // AccountCount
            // 
            this.AccountCount.DataPropertyName = "AccountCount";
            this.AccountCount.HeaderText = "台帐计数";
            this.AccountCount.Name = "AccountCount";
            // 
            // AccountAmount
            // 
            this.AccountAmount.DataPropertyName = "AccountAmount";
            this.AccountAmount.HeaderText = "台帐数量";
            this.AccountAmount.Name = "AccountAmount";
            // 
            // AccountReason
            // 
            this.AccountReason.DataPropertyName = "AccountReason";
            this.AccountReason.HeaderText = "原因";
            this.AccountReason.Name = "AccountReason";
            this.AccountReason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Responsibility_Organ
            // 
            this.Responsibility_Organ.DataPropertyName = "Responsibility_Organ";
            this.Responsibility_Organ.HeaderText = "责任单位";
            this.Responsibility_Organ.Name = "Responsibility_Organ";
            this.Responsibility_Organ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时刻";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // bsDispAccount
            // 
            this.bsDispAccount.DataMember = "L3DataTable";
            this.bsDispAccount.DataSource = this.dsDispAccount;
            // 
            // dsDispAccount
            // 
            this.dsDispAccount.AutoLoad = true;
            this.dsDispAccount.AutoSubscribe = true;
            this.dsDispAccount.DataSetName = "L3DataSet";
            this.dsDispAccount.DeleteMethod = "";
            this.dsDispAccount.InsertMethod = "";
            this.dsDispAccount.L3DataAdapter = this.Adapter;
            this.dsDispAccount.LoadEvent = "";
            this.dsDispAccount.LoadTrigger = null;
            this.dsDispAccount.RefreshValve = 1000;
            this.dsDispAccount.SourceCommand = null;
            this.dsDispAccount.SourceCondition = " 1=2";
            this.dsDispAccount.SourceMethod = "";
            this.dsDispAccount.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDispAccount.SourceURI = "XGMESLogic\\DispatchMag\\CDisp_Account";
            this.dsDispAccount.SubscribeTarget = null;
            this.dsDispAccount.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDispAccount});
            this.dsDispAccount.UpdateEvent = "";
            this.dsDispAccount.UpdateMethod = "";
            this.dsDispAccount.UpdateTrigger = null;
            // 
            // schemadsDispAccount
            // 
            this.schemadsDispAccount.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDispAccountL3DataTableGUID,
            this.coldsDispAccountL3DataTableName,
            this.coldsDispAccountL3DataTableProductDate,
            this.coldsDispAccountL3DataTableUnitID,
            this.coldsDispAccountL3DataTableTeam,
            this.coldsDispAccountL3DataTableAccountType,
            this.coldsDispAccountL3DataTableAccountCount,
            this.coldsDispAccountL3DataTableAccountReason,
            this.coldsDispAccountL3DataTableResponsibility_Organ,
            this.coldsDispAccountL3DataTableCreateTime,
            this.coldsDispAccountL3DataTableAccountAmount});
            this.schemadsDispAccount.TableName = "L3DataTable";
            // 
            // coldsDispAccountL3DataTableGUID
            // 
            this.coldsDispAccountL3DataTableGUID.Caption = "GUID";
            this.coldsDispAccountL3DataTableGUID.ColumnName = "GUID";
            this.coldsDispAccountL3DataTableGUID.Namespace = "";
            // 
            // coldsDispAccountL3DataTableName
            // 
            this.coldsDispAccountL3DataTableName.Caption = "Name";
            this.coldsDispAccountL3DataTableName.ColumnName = "Name";
            this.coldsDispAccountL3DataTableName.Namespace = "";
            // 
            // coldsDispAccountL3DataTableProductDate
            // 
            this.coldsDispAccountL3DataTableProductDate.Caption = "ProductDate";
            this.coldsDispAccountL3DataTableProductDate.ColumnName = "ProductDate";
            this.coldsDispAccountL3DataTableProductDate.Namespace = "";
            // 
            // coldsDispAccountL3DataTableUnitID
            // 
            this.coldsDispAccountL3DataTableUnitID.Caption = "UnitID";
            this.coldsDispAccountL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsDispAccountL3DataTableUnitID.Namespace = "";
            // 
            // coldsDispAccountL3DataTableTeam
            // 
            this.coldsDispAccountL3DataTableTeam.Caption = "Team";
            this.coldsDispAccountL3DataTableTeam.ColumnName = "Team";
            this.coldsDispAccountL3DataTableTeam.Namespace = "";
            // 
            // coldsDispAccountL3DataTableAccountType
            // 
            this.coldsDispAccountL3DataTableAccountType.Caption = "AccountType";
            this.coldsDispAccountL3DataTableAccountType.ColumnName = "AccountType";
            this.coldsDispAccountL3DataTableAccountType.Namespace = "";
            // 
            // coldsDispAccountL3DataTableAccountCount
            // 
            this.coldsDispAccountL3DataTableAccountCount.Caption = "AccountCount";
            this.coldsDispAccountL3DataTableAccountCount.ColumnName = "AccountCount";
            this.coldsDispAccountL3DataTableAccountCount.DataType = typeof(int);
            this.coldsDispAccountL3DataTableAccountCount.Namespace = "";
            // 
            // coldsDispAccountL3DataTableAccountReason
            // 
            this.coldsDispAccountL3DataTableAccountReason.Caption = "AccountReason";
            this.coldsDispAccountL3DataTableAccountReason.ColumnName = "AccountReason";
            this.coldsDispAccountL3DataTableAccountReason.Namespace = "";
            // 
            // coldsDispAccountL3DataTableResponsibility_Organ
            // 
            this.coldsDispAccountL3DataTableResponsibility_Organ.Caption = "Responsibility_Organ";
            this.coldsDispAccountL3DataTableResponsibility_Organ.ColumnName = "Responsibility_Organ";
            this.coldsDispAccountL3DataTableResponsibility_Organ.Namespace = "";
            // 
            // coldsDispAccountL3DataTableCreateTime
            // 
            this.coldsDispAccountL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsDispAccountL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsDispAccountL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsDispAccountL3DataTableCreateTime.Namespace = "";
            // 
            // coldsDispAccountL3DataTableAccountAmount
            // 
            this.coldsDispAccountL3DataTableAccountAmount.Caption = "AccountAmount";
            this.coldsDispAccountL3DataTableAccountAmount.ColumnName = "AccountAmount";
            this.coldsDispAccountL3DataTableAccountAmount.DataType = typeof(int);
            this.coldsDispAccountL3DataTableAccountAmount.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsDispAccount;
            this.bdN1.CountItem = null;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnQuery,
            this.dtNoteEndData,
            this.toolStripLabel3,
            this.dtNoteData,
            this.toolStripLabel6,
            this.cmbAccountType,
            this.toolStripLabel2,
            this.txtAccountType,
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
            this.btnQuery.Size = new System.Drawing.Size(52, 22);
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
            this.toolStripLabel3.Size = new System.Drawing.Size(20, 22);
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
            // cmbAccountType
            // 
            this.cmbAccountType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbAccountType.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(100, 25);
            this.cmbAccountType.SelectedIndexChanged += new System.EventHandler(this.cmbShiftID_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "台帐类型:";
            // 
            // txtAccountType
            // 
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(100, 25);
            this.txtAccountType.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(52, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(52, 22);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(52, 22);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dsAccountReason
            // 
            this.dsAccountReason.AutoLoad = true;
            this.dsAccountReason.AutoSubscribe = true;
            this.dsAccountReason.DataSetName = "L3DataSet";
            this.dsAccountReason.DeleteMethod = "";
            this.dsAccountReason.InsertMethod = "";
            this.dsAccountReason.L3DataAdapter = this.Adapter;
            this.dsAccountReason.LoadEvent = "";
            this.dsAccountReason.LoadTrigger = null;
            this.dsAccountReason.RefreshValve = 1000;
            this.dsAccountReason.SourceCommand = null;
            this.dsAccountReason.SourceCondition = "CODE_GROUP = \'Account_Reason_UPRE\' or CODE_GROUP = \'Account_Reason_Leak\'";
            this.dsAccountReason.SourceMethod = "";
            this.dsAccountReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAccountReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAccountReason.SubscribeTarget = null;
            this.dsAccountReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAccountReasonUPRE});
            this.dsAccountReason.UpdateEvent = "";
            this.dsAccountReason.UpdateMethod = "";
            this.dsAccountReason.UpdateTrigger = null;
            // 
            // schemadsAccountReasonUPRE
            // 
            this.schemadsAccountReasonUPRE.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAccountReasonUPREL3DataTableCode});
            this.schemadsAccountReasonUPRE.TableName = "L3DataTable";
            // 
            // coldsAccountReasonUPREL3DataTableCode
            // 
            this.coldsAccountReasonUPREL3DataTableCode.Caption = "Code";
            this.coldsAccountReasonUPREL3DataTableCode.ColumnName = "Code";
            this.coldsAccountReasonUPREL3DataTableCode.Namespace = "";
            // 
            // dsResponsibilityOrgan
            // 
            this.dsResponsibilityOrgan.AutoLoad = true;
            this.dsResponsibilityOrgan.AutoSubscribe = true;
            this.dsResponsibilityOrgan.DataSetName = "L3DataSet";
            this.dsResponsibilityOrgan.DeleteMethod = "";
            this.dsResponsibilityOrgan.InsertMethod = "";
            this.dsResponsibilityOrgan.L3DataAdapter = this.Adapter;
            this.dsResponsibilityOrgan.LoadEvent = "";
            this.dsResponsibilityOrgan.LoadTrigger = null;
            this.dsResponsibilityOrgan.RefreshValve = 1000;
            this.dsResponsibilityOrgan.SourceCommand = null;
            this.dsResponsibilityOrgan.SourceCondition = "CODE_GROUP = \'Responsibility_Organ\'";
            this.dsResponsibilityOrgan.SourceMethod = "";
            this.dsResponsibilityOrgan.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsResponsibilityOrgan.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsResponsibilityOrgan.SubscribeTarget = null;
            this.dsResponsibilityOrgan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsResponsibilityOrgan});
            this.dsResponsibilityOrgan.UpdateEvent = "";
            this.dsResponsibilityOrgan.UpdateMethod = "";
            this.dsResponsibilityOrgan.UpdateTrigger = null;
            // 
            // schemadsResponsibilityOrgan
            // 
            this.schemadsResponsibilityOrgan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsResponsibilityOrganL3DataTableCode});
            this.schemadsResponsibilityOrgan.TableName = "L3DataTable";
            // 
            // coldsResponsibilityOrganL3DataTableCode
            // 
            this.coldsResponsibilityOrganL3DataTableCode.Caption = "Code";
            this.coldsResponsibilityOrganL3DataTableCode.ColumnName = "Code";
            this.coldsResponsibilityOrganL3DataTableCode.Namespace = "";
            // 
            // DispAccountFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 376);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DispAccountFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "调度台账管理";
            this.Text = "调度台账管理";
            this.Load += new System.EventHandler(this.DispAccountFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DispAccountFrm_FormClosing);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDispAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAccountType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDispAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDispAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDispAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccountReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAccountReasonUPRE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResponsibilityOrgan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsResponsibilityOrgan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtNoteData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.DataGridView dvDispAccount;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsDispAccount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbAccountType;
        private System.Windows.Forms.ToolStripTextBox txtAccountType;
        private buttonHide.ToolStripToriDateTimePicker dtNoteEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private AppSvrHMI.L3DataSet dsAccountType;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Data.DataTable schemadsAccountType;
        private System.Data.DataColumn coldsAccountTypeL3DataTableCode;
        private System.Data.DataColumn coldsAccountTypeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeam;
        private System.Data.DataTable schemadsTeam;
        private System.Data.DataColumn coldsTeamL3DataTablecode;
        private System.Data.DataColumn coldsTeamL3DataTablecode_des;
        private AppSvrHMI.L3DataSet dsCaster;
        private System.Data.DataTable schemadsBOF;
        private System.Data.DataColumn coldsBOFL3DataTableCode;
        private System.Data.DataColumn coldsBOFL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsDispAccount;
        private System.Data.DataTable schemadsDispAccount;
        private System.Data.DataColumn coldsDispAccountL3DataTableGUID;
        private System.Data.DataColumn coldsDispAccountL3DataTableName;
        private System.Data.DataColumn coldsDispAccountL3DataTableProductDate;
        private System.Data.DataColumn coldsDispAccountL3DataTableUnitID;
        private System.Data.DataColumn coldsDispAccountL3DataTableTeam;
        private System.Data.DataColumn coldsDispAccountL3DataTableAccountType;
        private System.Data.DataColumn coldsDispAccountL3DataTableAccountCount;
        private System.Data.DataColumn coldsDispAccountL3DataTableAccountReason;
        private System.Data.DataColumn coldsDispAccountL3DataTableResponsibility_Organ;
        private System.Data.DataColumn coldsDispAccountL3DataTableCreateTime;
        private System.Data.DataColumn coldsDispAccountL3DataTableAccountAmount;
        private AppSvrHMI.L3DataSet dsAccountReason;
        private System.Data.DataTable schemadsAccountReasonUPRE;
        private System.Data.DataColumn coldsAccountReasonUPREL3DataTableCode;
        private AppSvrHMI.L3DataSet dsResponsibilityOrgan;
        private System.Data.DataTable schemadsResponsibilityOrgan;
        private System.Data.DataColumn coldsResponsibilityOrganL3DataTableCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsibility_Organ;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
    }
}