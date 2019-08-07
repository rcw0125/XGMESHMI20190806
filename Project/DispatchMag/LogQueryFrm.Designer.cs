namespace DispatchMag
{
    partial class LogQueryFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogQueryFrm));
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.shiftIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsNote = new System.Windows.Forms.BindingSource(this.components);
            this.dsNotte = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableName = new System.Data.DataColumn();
            this.coldsNotteL3DataTableTeamID = new System.Data.DataColumn();
            this.coldsNotteL3DataTableShiftID = new System.Data.DataColumn();
            this.coldsNotteL3DataTableCreateDate = new System.Data.DataColumn();
            this.coldsNotteL3DataTableNote = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtNoteEndData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtNoteData = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbShiftID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtShiftID = new System.Windows.Forms.ToolStripTextBox();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.dsScrapArea = new AppSvrHMI.L3DataSet();
            this.schemadsScrapArea = new System.Data.DataTable();
            this.coldsScrapAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).BeginInit();
            this.SuspendLayout();
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Controls.Add(this.bdN1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1127, 366);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.teamIDDataGridViewTextBoxColumn,
            this.shiftIDDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsNote;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 25);
            this.dvInStore.Name = "dvInStore";
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(1127, 341);
            this.dvInStore.TabIndex = 29;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // teamIDDataGridViewTextBoxColumn
            // 
            this.teamIDDataGridViewTextBoxColumn.DataPropertyName = "TeamID";
            this.teamIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.teamIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.teamIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamIDDataGridViewTextBoxColumn.Name = "teamIDDataGridViewTextBoxColumn";
            this.teamIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.teamIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoSubscribe = true;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode_Des,
            this.coldsTeamIDL3DataTableCode});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // shiftIDDataGridViewTextBoxColumn
            // 
            this.shiftIDDataGridViewTextBoxColumn.DataPropertyName = "ShiftID";
            this.shiftIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.shiftIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.shiftIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftIDDataGridViewTextBoxColumn.Name = "shiftIDDataGridViewTextBoxColumn";
            this.shiftIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.shiftIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoSubscribe = true;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "CODE_GROUP = \'ShiftID\'";
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
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.createDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.createDateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Width = 70;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "记事";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // bsNote
            // 
            this.bsNote.DataMember = "L3DataTable";
            this.bsNote.DataSource = this.dsNotte;
            // 
            // dsNotte
            // 
            this.dsNotte.AutoSubscribe = true;
            this.dsNotte.DataSetName = "L3DataSet";
            this.dsNotte.DeleteMethod = null;
            this.dsNotte.InsertMethod = null;
            this.dsNotte.L3DataAdapter = this.Adapter;
            this.dsNotte.LoadEvent = "Click";
            this.dsNotte.LoadTrigger = null;
            this.dsNotte.RefreshValve = 1000;
            this.dsNotte.SourceCommand = null;
            this.dsNotte.SourceCondition = "1=2";
            this.dsNotte.SourceMethod = "";
            this.dsNotte.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsNotte.SourceURI = "XGMESLogic\\DispatchMag\\CDisp_Duty_Note";
            this.dsNotte.SubscribeTarget = null;
            this.dsNotte.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsNotte.UpdateEvent = "Click";
            this.dsNotte.UpdateMethod = null;
            this.dsNotte.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableGUID,
            this.coldsInStoreL3DataTableName,
            this.coldsNotteL3DataTableTeamID,
            this.coldsNotteL3DataTableShiftID,
            this.coldsNotteL3DataTableCreateDate,
            this.coldsNotteL3DataTableNote});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsInStoreL3DataTableGUID
            // 
            this.coldsInStoreL3DataTableGUID.Caption = "GUID";
            this.coldsInStoreL3DataTableGUID.ColumnName = "GUID";
            this.coldsInStoreL3DataTableGUID.Namespace = "";
            // 
            // coldsInStoreL3DataTableName
            // 
            this.coldsInStoreL3DataTableName.Caption = "Name";
            this.coldsInStoreL3DataTableName.ColumnName = "Name";
            this.coldsInStoreL3DataTableName.Namespace = "";
            // 
            // coldsNotteL3DataTableTeamID
            // 
            this.coldsNotteL3DataTableTeamID.Caption = "TeamID";
            this.coldsNotteL3DataTableTeamID.ColumnName = "TeamID";
            this.coldsNotteL3DataTableTeamID.Namespace = "";
            // 
            // coldsNotteL3DataTableShiftID
            // 
            this.coldsNotteL3DataTableShiftID.Caption = "ShiftID";
            this.coldsNotteL3DataTableShiftID.ColumnName = "ShiftID";
            this.coldsNotteL3DataTableShiftID.Namespace = "";
            // 
            // coldsNotteL3DataTableCreateDate
            // 
            this.coldsNotteL3DataTableCreateDate.Caption = "CreateDate";
            this.coldsNotteL3DataTableCreateDate.ColumnName = "CreateDate";
            this.coldsNotteL3DataTableCreateDate.DataType = typeof(System.DateTime);
            this.coldsNotteL3DataTableCreateDate.Namespace = "";
            // 
            // coldsNotteL3DataTableNote
            // 
            this.coldsNotteL3DataTableNote.Caption = "Note";
            this.coldsNotteL3DataTableNote.ColumnName = "Note";
            this.coldsNotteL3DataTableNote.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsNote;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnOutput,
            this.toolStripLabel1,
            this.btnQuery,
            this.dtNoteEndData,
            this.toolStripLabel3,
            this.dtNoteData,
            this.toolStripLabel6,
            this.cmbShiftID,
            this.toolStripLabel2,
            this.txtShiftID,
            this.btnAdd,
            this.btnDelete,
            this.btnConfirm,
            this.btnCancel});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1127, 25);
            this.bdN1.TabIndex = 28;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
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
            this.dtNoteEndData.Size = new System.Drawing.Size(85, 22);
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
            this.dtNoteData.Size = new System.Drawing.Size(85, 22);
            this.dtNoteData.Text = "2008-11-16";
            this.dtNoteData.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "记事日期:";
            // 
            // cmbShiftID
            // 
            this.cmbShiftID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbShiftID.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbShiftID.Name = "cmbShiftID";
            this.cmbShiftID.Size = new System.Drawing.Size(80, 25);
            this.cmbShiftID.SelectedIndexChanged += new System.EventHandler(this.cmbShiftID_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "班次:";
            // 
            // txtShiftID
            // 
            this.txtShiftID.Name = "txtShiftID";
            this.txtShiftID.Size = new System.Drawing.Size(100, 25);
            this.txtShiftID.Visible = false;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "BtnDispathLog");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.Adapter.SetAccessRight(this.btnDelete, "BtnDispathLog");
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "BtnDispathLog");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(49, 22);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "BtnDispathLog");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 22);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dsScrapArea
            // 
            this.dsScrapArea.AutoSubscribe = true;
            this.dsScrapArea.DataSetName = "L3DataSet";
            this.dsScrapArea.DeleteMethod = null;
            this.dsScrapArea.InsertMethod = null;
            this.dsScrapArea.L3DataAdapter = this.Adapter;
            this.dsScrapArea.LoadEvent = "Click";
            this.dsScrapArea.LoadTrigger = null;
            this.dsScrapArea.RefreshValve = 1000;
            this.dsScrapArea.SourceCommand = null;
            this.dsScrapArea.SourceCondition = "CODE_GROUP = \'ScrapArea\'";
            this.dsScrapArea.SourceMethod = "";
            this.dsScrapArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapArea.SubscribeTarget = null;
            this.dsScrapArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapArea});
            this.dsScrapArea.UpdateEvent = "Click";
            this.dsScrapArea.UpdateMethod = null;
            this.dsScrapArea.UpdateTrigger = null;
            // 
            // schemadsScrapArea
            // 
            this.schemadsScrapArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapAreaL3DataTableCode,
            this.coldsScrapAreaL3DataTableCode_Des});
            this.schemadsScrapArea.TableName = "L3DataTable";
            // 
            // coldsScrapAreaL3DataTableCode
            // 
            this.coldsScrapAreaL3DataTableCode.Caption = "Code";
            this.coldsScrapAreaL3DataTableCode.ColumnName = "Code";
            this.coldsScrapAreaL3DataTableCode.Namespace = "";
            // 
            // coldsScrapAreaL3DataTableCode_Des
            // 
            this.coldsScrapAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.Namespace = "";
            // 
            // LogQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 366);
            this.Controls.Add(this.hmiRootPanel1);
            this.Name = "LogQueryFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "调度记事管理";
            this.Text = "调度记事管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.LogQueryFrm_Load);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtNoteData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsNotte;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableGUID;
        private System.Data.DataColumn coldsInStoreL3DataTableName;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsNote;
        private AppSvrHMI.L3DataSet dsScrapArea;
        private System.Data.DataTable schemadsScrapArea;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbShiftID;
        private System.Windows.Forms.ToolStripTextBox txtShiftID;
        private System.Data.DataColumn coldsNotteL3DataTableTeamID;
        private System.Data.DataColumn coldsNotteL3DataTableShiftID;
        private System.Data.DataColumn coldsNotteL3DataTableCreateDate;
        private System.Data.DataColumn coldsNotteL3DataTableNote;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private buttonHide.ToolStripToriDateTimePicker dtNoteEndData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}