namespace UnitMag.DeSMag
{
    partial class DeSStatusQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeSStatusQueryFrm));
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsDeSStatus = new System.Windows.Forms.BindingSource(this.components);
            this.dsDeSStatus = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableDeSID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableStatus = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableLog_Time = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableReason = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnDataModify = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbDeSID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dvDeSStatus = new System.Windows.Forms.DataGridView();
            this.deSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDeSUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsDeSUnitID = new System.Data.DataTable();
            this.coldsDeSUnitIDL3DataTablecode_des = new System.Data.DataColumn();
            this.coldsDeSUnitIDL3DataTablecode_val_long = new System.Data.DataColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsEquStatus = new AppSvrHMI.L3DataSet();
            this.schemadsEquStatus = new System.Data.DataTable();
            this.coldsEquStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsEquStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.logTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInExl = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDeSStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEquStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsDeSStatus;
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
            this.toolStripLabel1,
            this.btnDataModify,
            this.btnQuery,
            this.dtEnd,
            this.toolStripLabel5,
            this.dtStart,
            this.toolStripLabel3,
            this.cmbDeSID,
            this.toolStripLabel2,
            this.btnInExl});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(899, 25);
            this.bdN1.TabIndex = 24;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bsDeSStatus
            // 
            this.bsDeSStatus.DataMember = "L3DataTable";
            this.bsDeSStatus.DataSource = this.dsDeSStatus;
            // 
            // dsDeSStatus
            // 
            this.dsDeSStatus.AutoLoad = true;
            this.dsDeSStatus.AutoSubscribe = false;
            this.dsDeSStatus.DataSetName = "L3DataSet";
            this.dsDeSStatus.DeleteMethod = "";
            this.dsDeSStatus.InsertMethod = "";
            this.dsDeSStatus.L3DataAdapter = this.Adapter;
            this.dsDeSStatus.LoadEvent = "";
            this.dsDeSStatus.LoadTrigger = null;
            this.dsDeSStatus.RefreshValve = 1000;
            this.dsDeSStatus.SourceCommand = null;
            this.dsDeSStatus.SourceCondition = "1=2";
            this.dsDeSStatus.SourceMethod = "";
            this.dsDeSStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDeSStatus.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Equipment_Status";
            this.dsDeSStatus.SubscribeTarget = "";
            this.dsDeSStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsDeSStatus.UpdateEvent = "";
            this.dsDeSStatus.UpdateMethod = "";
            this.dsDeSStatus.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableName,
            this.coll3DataSet1L3DataTableDeSID,
            this.coll3DataSet1L3DataTableStatus,
            this.coll3DataSet1L3DataTableLog_Time,
            this.coll3DataSet1L3DataTableReason});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableGUID
            // 
            this.coll3DataSet1L3DataTableGUID.Caption = "GUID";
            this.coll3DataSet1L3DataTableGUID.ColumnName = "GUID";
            this.coll3DataSet1L3DataTableGUID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableName
            // 
            this.coll3DataSet1L3DataTableName.Caption = "Name";
            this.coll3DataSet1L3DataTableName.ColumnName = "Name";
            this.coll3DataSet1L3DataTableName.Namespace = "";
            // 
            // coll3DataSet1L3DataTableDeSID
            // 
            this.coll3DataSet1L3DataTableDeSID.Caption = "DeSID";
            this.coll3DataSet1L3DataTableDeSID.ColumnName = "DeSID";
            this.coll3DataSet1L3DataTableDeSID.DataType = typeof(short);
            this.coll3DataSet1L3DataTableDeSID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableStatus
            // 
            this.coll3DataSet1L3DataTableStatus.Caption = "Status";
            this.coll3DataSet1L3DataTableStatus.ColumnName = "Status";
            this.coll3DataSet1L3DataTableStatus.DataType = typeof(short);
            this.coll3DataSet1L3DataTableStatus.Namespace = "";
            // 
            // coll3DataSet1L3DataTableLog_Time
            // 
            this.coll3DataSet1L3DataTableLog_Time.Caption = "Log_Time";
            this.coll3DataSet1L3DataTableLog_Time.ColumnName = "Log_Time";
            this.coll3DataSet1L3DataTableLog_Time.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableLog_Time.Namespace = "";
            // 
            // coll3DataSet1L3DataTableReason
            // 
            this.coll3DataSet1L3DataTableReason.Caption = "Reason";
            this.coll3DataSet1L3DataTableReason.ColumnName = "Reason";
            this.coll3DataSet1L3DataTableReason.Namespace = "";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "       ";
            // 
            // btnDataModify
            // 
            this.btnDataModify.Name = "btnDataModify";
            this.btnDataModify.Size = new System.Drawing.Size(0, 22);
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
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 22);
            this.dtEnd.Text = "2009-01-04";
            this.dtEnd.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel5.Text = "－";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "日期:";
            // 
            // cmbDeSID
            // 
            this.cmbDeSID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbDeSID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeSID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbDeSID.Items.AddRange(new object[] {
            "I部脱硫",
            "II部脱硫",
            "所有"});
            this.cmbDeSID.Name = "cmbDeSID";
            this.cmbDeSID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "工位:";
            // 
            // dvDeSStatus
            // 
            this.dvDeSStatus.AllowUserToAddRows = false;
            this.dvDeSStatus.AutoGenerateColumns = false;
            this.dvDeSStatus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvDeSStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDeSStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deSIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.logTimeDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn});
            this.dvDeSStatus.DataSource = this.bsDeSStatus;
            this.dvDeSStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDeSStatus.Location = new System.Drawing.Point(0, 25);
            this.dvDeSStatus.Name = "dvDeSStatus";
            this.dvDeSStatus.RowTemplate.Height = 23;
            this.dvDeSStatus.Size = new System.Drawing.Size(899, 401);
            this.dvDeSStatus.TabIndex = 25;
            this.dvDeSStatus.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvDeSStatus_DataError);
            // 
            // deSIDDataGridViewTextBoxColumn
            // 
            this.deSIDDataGridViewTextBoxColumn.DataPropertyName = "DeSID";
            this.deSIDDataGridViewTextBoxColumn.DataSource = this.dsDeSUnitID;
            this.deSIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.deSIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.deSIDDataGridViewTextBoxColumn.HeaderText = "工位号";
            this.deSIDDataGridViewTextBoxColumn.Name = "deSIDDataGridViewTextBoxColumn";
            this.deSIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deSIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deSIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code_val_long";
            // 
            // dsDeSUnitID
            // 
            this.dsDeSUnitID.AutoLoad = true;
            this.dsDeSUnitID.AutoSubscribe = false;
            this.dsDeSUnitID.DataSetName = "L3DataSet";
            this.dsDeSUnitID.DeleteMethod = "";
            this.dsDeSUnitID.InsertMethod = "";
            this.dsDeSUnitID.L3DataAdapter = this.Adapter;
            this.dsDeSUnitID.LoadEvent = "";
            this.dsDeSUnitID.LoadTrigger = null;
            this.dsDeSUnitID.RefreshValve = 1000;
            this.dsDeSUnitID.SourceCommand = null;
            this.dsDeSUnitID.SourceCondition = "code_group = \'DeS\'";
            this.dsDeSUnitID.SourceMethod = "";
            this.dsDeSUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDeSUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsDeSUnitID.SubscribeTarget = "";
            this.dsDeSUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDeSUnitID});
            this.dsDeSUnitID.UpdateEvent = "";
            this.dsDeSUnitID.UpdateMethod = "";
            this.dsDeSUnitID.UpdateTrigger = null;
            // 
            // schemadsDeSUnitID
            // 
            this.schemadsDeSUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDeSUnitIDL3DataTablecode_des,
            this.coldsDeSUnitIDL3DataTablecode_val_long});
            this.schemadsDeSUnitID.TableName = "L3DataTable";
            // 
            // coldsDeSUnitIDL3DataTablecode_des
            // 
            this.coldsDeSUnitIDL3DataTablecode_des.Caption = "code_des";
            this.coldsDeSUnitIDL3DataTablecode_des.ColumnName = "code_des";
            this.coldsDeSUnitIDL3DataTablecode_des.Namespace = "";
            // 
            // coldsDeSUnitIDL3DataTablecode_val_long
            // 
            this.coldsDeSUnitIDL3DataTablecode_val_long.Caption = "code_val_long";
            this.coldsDeSUnitIDL3DataTablecode_val_long.ColumnName = "code_val_long";
            this.coldsDeSUnitIDL3DataTablecode_val_long.DataType = typeof(short);
            this.coldsDeSUnitIDL3DataTablecode_val_long.Namespace = "";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsEquStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "设备状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dsEquStatus
            // 
            this.dsEquStatus.AutoLoad = true;
            this.dsEquStatus.AutoSubscribe = false;
            this.dsEquStatus.DataSetName = "L3DataSet";
            this.dsEquStatus.DeleteMethod = "";
            this.dsEquStatus.InsertMethod = "";
            this.dsEquStatus.L3DataAdapter = this.Adapter;
            this.dsEquStatus.LoadEvent = "";
            this.dsEquStatus.LoadTrigger = null;
            this.dsEquStatus.RefreshValve = 1000;
            this.dsEquStatus.SourceCommand = null;
            this.dsEquStatus.SourceCondition = "code_group = \'DeSEquipmentStatus\'";
            this.dsEquStatus.SourceMethod = "";
            this.dsEquStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsEquStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsEquStatus.SubscribeTarget = "";
            this.dsEquStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEquStatus});
            this.dsEquStatus.UpdateEvent = "";
            this.dsEquStatus.UpdateMethod = "";
            this.dsEquStatus.UpdateTrigger = null;
            // 
            // schemadsEquStatus
            // 
            this.schemadsEquStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEquStatusL3DataTableCode_Des,
            this.coldsEquStatusL3DataTableCode_Val_Long});
            this.schemadsEquStatus.TableName = "L3DataTable";
            // 
            // coldsEquStatusL3DataTableCode_Des
            // 
            this.coldsEquStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsEquStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsEquStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsEquStatusL3DataTableCode_Val_Long
            // 
            this.coldsEquStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsEquStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsEquStatusL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsEquStatusL3DataTableCode_Val_Long.Namespace = "";
            // 
            // logTimeDataGridViewTextBoxColumn
            // 
            this.logTimeDataGridViewTextBoxColumn.DataPropertyName = "Log_Time";
            this.logTimeDataGridViewTextBoxColumn.HeaderText = "记录时刻";
            this.logTimeDataGridViewTextBoxColumn.Name = "logTimeDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "原因";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // btnInExl
            // 
            this.btnInExl.Image = ((System.Drawing.Image)(resources.GetObject("btnInExl.Image")));
            this.btnInExl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInExl.Name = "btnInExl";
            this.btnInExl.Size = new System.Drawing.Size(79, 22);
            this.btnInExl.Text = "导出到EXL";
            this.btnInExl.Click += new System.EventHandler(this.btnInExl_Click);
            // 
            // DeSStatusQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 426);
            this.Controls.Add(this.dvDeSStatus);
            this.Controls.Add(this.bdN1);
            this.Name = "DeSStatusQueryFrm";
            this.TabText = "设备状态查询";
            this.Text = "设备状态查询";
            this.Load += new System.EventHandler(this.DeSStatusQueryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDeSStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDeSUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDeSUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEquStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel btnDataModify;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox cmbDeSID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsDeSStatus;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableName;
        private System.Data.DataColumn coll3DataSet1L3DataTableDeSID;
        private System.Data.DataColumn coll3DataSet1L3DataTableStatus;
        private System.Data.DataColumn coll3DataSet1L3DataTableLog_Time;
        private System.Data.DataColumn coll3DataSet1L3DataTableReason;
        private System.Windows.Forms.DataGridView dvDeSStatus;
        private System.Windows.Forms.BindingSource bsDeSStatus;
        private AppSvrHMI.L3DataSet dsDeSUnitID;
        private System.Data.DataTable schemadsDeSUnitID;
        private System.Data.DataColumn coldsDeSUnitIDL3DataTablecode_des;
        private System.Data.DataColumn coldsDeSUnitIDL3DataTablecode_val_long;
        private AppSvrHMI.L3DataSet dsEquStatus;
        private System.Data.DataTable schemadsEquStatus;
        private System.Data.DataColumn coldsEquStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsEquStatusL3DataTableCode_Val_Long;
        private System.Windows.Forms.DataGridViewComboBoxColumn deSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnInExl;
    }
}