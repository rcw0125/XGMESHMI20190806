namespace DispatchMag
{
    partial class DisExceptionalQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisExceptionalQueryFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.dsExceptional = new AppSvrHMI.L3DataSet();
            this.schemadsExceptional = new System.Data.DataTable();
            this.coldsExceptionalL3DataTablecreatedate = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTableunitid = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTableshift = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTableteam = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTableitems = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTablecreatetime = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTablebegintime = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTableendtime = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTabletimespan = new System.Data.DataColumn();
            this.coldsExceptionalL3DataTablenote = new System.Data.DataColumn();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsExceptional = new System.Windows.Forms.BindingSource(this.components);
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
            this.cmbUnitID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbShift = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.dvExceptional = new System.Windows.Forms.DataGridView();
            this.dsUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsUnitID = new System.Data.DataTable();
            this.coldsUnitIDL3DataTablepk_center = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTablecenter_name = new System.Data.DataColumn();
            this.coldsUnitIDL3DataTablecenter_code = new System.Data.DataColumn();
            this.dsShiftNC = new AppSvrHMI.L3DataSet();
            this.schemadsShiftNC = new System.Data.DataTable();
            this.coldsShiftNCL3DataTablepk_shift = new System.Data.DataColumn();
            this.coldsShiftNCL3DataTableshift_name = new System.Data.DataColumn();
            this.coldsShiftNCL3DataTableshift_code = new System.Data.DataColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.begintimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timespanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsExceptional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvExceptional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftNC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftNC)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // dsExceptional
            // 
            this.dsExceptional.AutoSubscribe = false;
            this.dsExceptional.DataSetName = "L3DataSet";
            this.dsExceptional.DeleteMethod = "";
            this.dsExceptional.InsertMethod = "";
            this.dsExceptional.L3DataAdapter = this.Adapter;
            this.dsExceptional.LoadEvent = "";
            this.dsExceptional.LoadTrigger = null;
            this.dsExceptional.RefreshValve = 1000;
            this.dsExceptional.SourceCommand = null;
            this.dsExceptional.SourceCondition = "";
            this.dsExceptional.SourceMethod = "";
            this.dsExceptional.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsExceptional.SourceURI = "";
            this.dsExceptional.SubscribeTarget = "";
            this.dsExceptional.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExceptional});
            this.dsExceptional.UpdateEvent = "";
            this.dsExceptional.UpdateMethod = "";
            this.dsExceptional.UpdateTrigger = null;
            // 
            // schemadsExceptional
            // 
            this.schemadsExceptional.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptionalL3DataTablecreatedate,
            this.coldsExceptionalL3DataTableunitid,
            this.coldsExceptionalL3DataTableshift,
            this.coldsExceptionalL3DataTableteam,
            this.coldsExceptionalL3DataTableOPERATOR,
            this.coldsExceptionalL3DataTableitems,
            this.coldsExceptionalL3DataTablecreatetime,
            this.coldsExceptionalL3DataTablebegintime,
            this.coldsExceptionalL3DataTableendtime,
            this.coldsExceptionalL3DataTabletimespan,
            this.coldsExceptionalL3DataTablenote});
            this.schemadsExceptional.TableName = "L3DataTable";
            // 
            // coldsExceptionalL3DataTablecreatedate
            // 
            this.coldsExceptionalL3DataTablecreatedate.Caption = "createdate";
            this.coldsExceptionalL3DataTablecreatedate.ColumnName = "createdate";
            this.coldsExceptionalL3DataTablecreatedate.Namespace = "";
            // 
            // coldsExceptionalL3DataTableunitid
            // 
            this.coldsExceptionalL3DataTableunitid.Caption = "unitid";
            this.coldsExceptionalL3DataTableunitid.ColumnName = "unitid";
            this.coldsExceptionalL3DataTableunitid.Namespace = "";
            // 
            // coldsExceptionalL3DataTableshift
            // 
            this.coldsExceptionalL3DataTableshift.Caption = "shift";
            this.coldsExceptionalL3DataTableshift.ColumnName = "shift";
            this.coldsExceptionalL3DataTableshift.Namespace = "";
            // 
            // coldsExceptionalL3DataTableteam
            // 
            this.coldsExceptionalL3DataTableteam.Caption = "team";
            this.coldsExceptionalL3DataTableteam.ColumnName = "team";
            this.coldsExceptionalL3DataTableteam.Namespace = "";
            // 
            // coldsExceptionalL3DataTableOPERATOR
            // 
            this.coldsExceptionalL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsExceptionalL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsExceptionalL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsExceptionalL3DataTableitems
            // 
            this.coldsExceptionalL3DataTableitems.Caption = "items";
            this.coldsExceptionalL3DataTableitems.ColumnName = "items";
            this.coldsExceptionalL3DataTableitems.Namespace = "";
            // 
            // coldsExceptionalL3DataTablecreatetime
            // 
            this.coldsExceptionalL3DataTablecreatetime.Caption = "createtime";
            this.coldsExceptionalL3DataTablecreatetime.ColumnName = "createtime";
            this.coldsExceptionalL3DataTablecreatetime.DataType = typeof(System.DateTime);
            this.coldsExceptionalL3DataTablecreatetime.Namespace = "";
            // 
            // coldsExceptionalL3DataTablebegintime
            // 
            this.coldsExceptionalL3DataTablebegintime.Caption = "begintime";
            this.coldsExceptionalL3DataTablebegintime.ColumnName = "begintime";
            this.coldsExceptionalL3DataTablebegintime.Namespace = "";
            // 
            // coldsExceptionalL3DataTableendtime
            // 
            this.coldsExceptionalL3DataTableendtime.Caption = "endtime";
            this.coldsExceptionalL3DataTableendtime.ColumnName = "endtime";
            this.coldsExceptionalL3DataTableendtime.Namespace = "";
            // 
            // coldsExceptionalL3DataTabletimespan
            // 
            this.coldsExceptionalL3DataTabletimespan.Caption = "timespan";
            this.coldsExceptionalL3DataTabletimespan.ColumnName = "timespan";
            this.coldsExceptionalL3DataTabletimespan.DataType = typeof(int);
            this.coldsExceptionalL3DataTabletimespan.DefaultValue = 0;
            this.coldsExceptionalL3DataTabletimespan.Namespace = "";
            // 
            // coldsExceptionalL3DataTablenote
            // 
            this.coldsExceptionalL3DataTablenote.Caption = "note";
            this.coldsExceptionalL3DataTablenote.ColumnName = "note";
            this.coldsExceptionalL3DataTablenote.Namespace = "";
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsExceptional;
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
            this.cmbUnitID,
            this.toolStripLabel2,
            this.cmbShift,
            this.toolStripLabel4,
            this.dtEnd,
            this.toolStripLabel3,
            this.dtStart,
            this.toolStripLabel6});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 29;
            this.bdN1.Text = "bindingNavigator1";
            // 
            // bsExceptional
            // 
            this.bsExceptional.DataMember = "L3DataTable";
            this.bsExceptional.DataSource = this.dsExceptional;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
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
            // cmbUnitID
            // 
            this.cmbUnitID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbUnitID.DropDownHeight = 150;
            this.cmbUnitID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitID.DropDownWidth = 150;
            this.cmbUnitID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbUnitID.IntegralHeight = false;
            this.cmbUnitID.Name = "cmbUnitID";
            this.cmbUnitID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "工作中心:";
            // 
            // cmbShift
            // 
            this.cmbShift.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbShift.DropDownHeight = 150;
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.DropDownWidth = 150;
            this.cmbShift.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbShift.IntegralHeight = false;
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "班次:";
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
            this.dtEnd.Size = new System.Drawing.Size(85, 22);
            this.dtEnd.Text = "2009-01-04";
            this.dtEnd.Value = new System.DateTime(2009, 1, 4, 10, 4, 31, 140);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel3.Text = "－";
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
            this.dtStart.Size = new System.Drawing.Size(85, 22);
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel6.Text = "日期:";
            // 
            // dvExceptional
            // 
            this.dvExceptional.AllowUserToAddRows = false;
            this.dvExceptional.AutoGenerateColumns = false;
            this.dvExceptional.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvExceptional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvExceptional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createdateDataGridViewTextBoxColumn,
            this.unitidDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.createtimeDataGridViewTextBoxColumn,
            this.begintimeDataGridViewTextBoxColumn,
            this.endtimeDataGridViewTextBoxColumn,
            this.timespanDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dvExceptional.DataSource = this.bsExceptional;
            this.dvExceptional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvExceptional.Location = new System.Drawing.Point(0, 25);
            this.dvExceptional.Name = "dvExceptional";
            this.dvExceptional.RowTemplate.Height = 23;
            this.dvExceptional.Size = new System.Drawing.Size(1000, 650);
            this.dvExceptional.TabIndex = 30;
            this.dvExceptional.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvExceptional_DataError);
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
            this.coldsUnitIDL3DataTablepk_center,
            this.coldsUnitIDL3DataTablecenter_name,
            this.coldsUnitIDL3DataTablecenter_code});
            this.schemadsUnitID.TableName = "L3DataTable";
            // 
            // coldsUnitIDL3DataTablepk_center
            // 
            this.coldsUnitIDL3DataTablepk_center.Caption = "pk_center";
            this.coldsUnitIDL3DataTablepk_center.ColumnName = "pk_center";
            this.coldsUnitIDL3DataTablepk_center.Namespace = "";
            // 
            // coldsUnitIDL3DataTablecenter_name
            // 
            this.coldsUnitIDL3DataTablecenter_name.Caption = "center_name";
            this.coldsUnitIDL3DataTablecenter_name.ColumnName = "center_name";
            this.coldsUnitIDL3DataTablecenter_name.Namespace = "";
            // 
            // coldsUnitIDL3DataTablecenter_code
            // 
            this.coldsUnitIDL3DataTablecenter_code.Caption = "center_code";
            this.coldsUnitIDL3DataTablecenter_code.ColumnName = "center_code";
            this.coldsUnitIDL3DataTablecenter_code.Namespace = "";
            // 
            // dsShiftNC
            // 
            this.dsShiftNC.AutoSubscribe = false;
            this.dsShiftNC.DataSetName = "L3DataSet";
            this.dsShiftNC.DeleteMethod = "";
            this.dsShiftNC.InsertMethod = "";
            this.dsShiftNC.L3DataAdapter = this.Adapter;
            this.dsShiftNC.LoadEvent = "";
            this.dsShiftNC.LoadTrigger = null;
            this.dsShiftNC.RefreshValve = 1000;
            this.dsShiftNC.SourceCommand = null;
            this.dsShiftNC.SourceCondition = "";
            this.dsShiftNC.SourceMethod = "";
            this.dsShiftNC.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsShiftNC.SourceURI = "";
            this.dsShiftNC.SubscribeTarget = "";
            this.dsShiftNC.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftNC});
            this.dsShiftNC.UpdateEvent = "";
            this.dsShiftNC.UpdateMethod = "";
            this.dsShiftNC.UpdateTrigger = null;
            // 
            // schemadsShiftNC
            // 
            this.schemadsShiftNC.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftNCL3DataTablepk_shift,
            this.coldsShiftNCL3DataTableshift_name,
            this.coldsShiftNCL3DataTableshift_code});
            this.schemadsShiftNC.TableName = "L3DataTable";
            // 
            // coldsShiftNCL3DataTablepk_shift
            // 
            this.coldsShiftNCL3DataTablepk_shift.Caption = "pk_shift";
            this.coldsShiftNCL3DataTablepk_shift.ColumnName = "pk_shift";
            this.coldsShiftNCL3DataTablepk_shift.Namespace = "";
            // 
            // coldsShiftNCL3DataTableshift_name
            // 
            this.coldsShiftNCL3DataTableshift_name.Caption = "shift_name";
            this.coldsShiftNCL3DataTableshift_name.ColumnName = "shift_name";
            this.coldsShiftNCL3DataTableshift_name.Namespace = "";
            // 
            // coldsShiftNCL3DataTableshift_code
            // 
            this.coldsShiftNCL3DataTableshift_code.Caption = "shift_code";
            this.coldsShiftNCL3DataTableshift_code.ColumnName = "shift_code";
            this.coldsShiftNCL3DataTableshift_code.Namespace = "";
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "createdate";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            this.createdateDataGridViewTextBoxColumn.Width = 80;
            // 
            // unitidDataGridViewTextBoxColumn
            // 
            this.unitidDataGridViewTextBoxColumn.DataPropertyName = "unitid";
            this.unitidDataGridViewTextBoxColumn.HeaderText = "工作中心";
            this.unitidDataGridViewTextBoxColumn.Name = "unitidDataGridViewTextBoxColumn";
            this.unitidDataGridViewTextBoxColumn.Width = 120;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.Width = 60;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "team";
            this.teamDataGridViewTextBoxColumn.HeaderText = "班组";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.Width = 60;
            // 
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.Width = 60;
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "items";
            this.itemsDataGridViewTextBoxColumn.HeaderText = "异常项目";
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            // 
            // createtimeDataGridViewTextBoxColumn
            // 
            this.createtimeDataGridViewTextBoxColumn.DataPropertyName = "createtime";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.createtimeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.createtimeDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.createtimeDataGridViewTextBoxColumn.Name = "createtimeDataGridViewTextBoxColumn";
            this.createtimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // begintimeDataGridViewTextBoxColumn
            // 
            this.begintimeDataGridViewTextBoxColumn.DataPropertyName = "begintime";
            this.begintimeDataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.begintimeDataGridViewTextBoxColumn.Name = "begintimeDataGridViewTextBoxColumn";
            this.begintimeDataGridViewTextBoxColumn.Width = 75;
            // 
            // endtimeDataGridViewTextBoxColumn
            // 
            this.endtimeDataGridViewTextBoxColumn.DataPropertyName = "endtime";
            this.endtimeDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.endtimeDataGridViewTextBoxColumn.Name = "endtimeDataGridViewTextBoxColumn";
            this.endtimeDataGridViewTextBoxColumn.Width = 75;
            // 
            // timespanDataGridViewTextBoxColumn
            // 
            this.timespanDataGridViewTextBoxColumn.DataPropertyName = "timespan";
            this.timespanDataGridViewTextBoxColumn.HeaderText = "异常时长[min]";
            this.timespanDataGridViewTextBoxColumn.Name = "timespanDataGridViewTextBoxColumn";
            this.timespanDataGridViewTextBoxColumn.Width = 120;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 200;
            // 
            // DisExceptionalQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 675);
            this.Controls.Add(this.dvExceptional);
            this.Controls.Add(this.bdN1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisExceptionalQueryFrm";
            this.TabText = "设备异常信息查询";
            this.Text = "设备异常信息查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisExceptionalQueryFrm_FormClosing);
            this.Load += new System.EventHandler(this.DisExceptionalQueryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsExceptional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExceptional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsExceptional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvExceptional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftNC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftNC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsExceptional;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Data.DataTable schemadsExceptional;
        private System.Data.DataColumn coldsExceptionalL3DataTablecreatedate;
        private System.Data.DataColumn coldsExceptionalL3DataTableunitid;
        private System.Data.DataColumn coldsExceptionalL3DataTableshift;
        private System.Data.DataColumn coldsExceptionalL3DataTableteam;
        private System.Data.DataColumn coldsExceptionalL3DataTableOPERATOR;
        private System.Data.DataColumn coldsExceptionalL3DataTableitems;
        private System.Data.DataColumn coldsExceptionalL3DataTablecreatetime;
        private System.Data.DataColumn coldsExceptionalL3DataTablebegintime;
        private System.Data.DataColumn coldsExceptionalL3DataTableendtime;
        private System.Data.DataColumn coldsExceptionalL3DataTabletimespan;
        private System.Data.DataColumn coldsExceptionalL3DataTablenote;
        private System.Windows.Forms.BindingSource bsExceptional;
        private System.Windows.Forms.DataGridView dvExceptional;
        private AppSvrHMI.L3DataSet dsUnitID;
        private AppSvrHMI.L3DataSet dsShiftNC;
        private System.Data.DataTable schemadsUnitID;
        private System.Data.DataColumn coldsUnitIDL3DataTablepk_center;
        private System.Data.DataColumn coldsUnitIDL3DataTablecenter_name;
        private System.Data.DataTable schemadsShiftNC;
        private System.Data.DataColumn coldsShiftNCL3DataTablepk_shift;
        private System.Data.DataColumn coldsShiftNCL3DataTableshift_name;
        private System.Data.DataColumn coldsShiftNCL3DataTableshift_code;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cmbUnitID;
        private System.Windows.Forms.ToolStripComboBox cmbShift;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Data.DataColumn coldsUnitIDL3DataTablecenter_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn begintimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timespanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}