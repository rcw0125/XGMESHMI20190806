namespace UnitMag.DeSMag
{
    partial class LanceQueryFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanceQueryFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cmbStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtLanceNo = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnInExl = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dvLance = new System.Windows.Forms.DataGridView();
            this.lanceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTablecode_des = new System.Data.DataColumn();
            this.coldsStatusL3DataTablecode_Val_long = new System.Data.DataColumn();
            this.lanceAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanceVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsVendor = new AppSvrHMI.L3DataSet();
            this.schemadsVendor = new System.Data.DataTable();
            this.coldsVendorL3DataTablecode = new System.Data.DataColumn();
            this.coldsVendorL3DataTablecode_des = new System.Data.DataColumn();
            this.processTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShift2 = new AppSvrHMI.L3DataSet();
            this.schemadsShift2 = new System.Data.DataTable();
            this.coldsShift2L3DataTablecode = new System.Data.DataColumn();
            this.coldsShift2L3DataTablecode_des = new System.Data.DataColumn();
            this.teamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeam2 = new AppSvrHMI.L3DataSet();
            this.schemadsTeam2 = new System.Data.DataTable();
            this.coldsTeam2L3DataTablecode = new System.Data.DataColumn();
            this.coldsTeam2L3DataTablecode_des = new System.Data.DataColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLance = new System.Windows.Forms.BindingSource(this.components);
            this.dsLance = new AppSvrHMI.L3DataSet();
            this.schemadsLance = new System.Data.DataTable();
            this.coldsLanceL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLanceL3DataTableName = new System.Data.DataColumn();
            this.coldsLanceL3DataTableLanceNo = new System.Data.DataColumn();
            this.coldsLanceL3DataTableStatus = new System.Data.DataColumn();
            this.coldsLanceL3DataTableLanceAge = new System.Data.DataColumn();
            this.coldsLanceL3DataTableLanceVendor = new System.Data.DataColumn();
            this.coldsLanceL3DataTableProcessTime = new System.Data.DataColumn();
            this.coldsLanceL3DataTableProcessAmount = new System.Data.DataColumn();
            this.coldsLanceL3DataTableNote = new System.Data.DataColumn();
            this.coldsLanceL3DataTableAction = new System.Data.DataColumn();
            this.coldsLanceL3DataTableTime_Change = new System.Data.DataColumn();
            this.coldsLanceL3DataTableOperator = new System.Data.DataColumn();
            this.coldsLanceL3DataTableShift = new System.Data.DataColumn();
            this.coldsLanceL3DataTableTeam = new System.Data.DataColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lanceNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lanceAgeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanceVendorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.processTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFQ = new System.Windows.Forms.BindingSource(this.components);
            this.dsFQ = new AppSvrHMI.L3DataSet();
            this.schemadsFQ = new System.Data.DataTable();
            this.coldsFQL3DataTableLanceNo = new System.Data.DataColumn();
            this.coldsFQL3DataTableStatus = new System.Data.DataColumn();
            this.coldsFQL3DataTableLanceAge = new System.Data.DataColumn();
            this.coldsFQL3DataTableLanceVendor = new System.Data.DataColumn();
            this.coldsFQL3DataTableProcessTime = new System.Data.DataColumn();
            this.coldsFQL3DataTableProcessAmount = new System.Data.DataColumn();
            this.coldsFQL3DataTableNote = new System.Data.DataColumn();
            this.coldsFQL3DataTableOpTime = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFQ)).BeginInit();
            this.SuspendLayout();
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
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
            this.cmbStatus,
            this.toolStripLabel2,
            this.txtLanceNo,
            this.toolStripLabel4,
            this.btnInExl,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.bdN1.Location = new System.Drawing.Point(0, 0);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1200, 25);
            this.bdN1.TabIndex = 64;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 22);
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
            this.dtEnd.Size = new System.Drawing.Size(80, 22);
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
            this.dtStart.Size = new System.Drawing.Size(80, 22);
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
            // cmbStatus
            // 
            this.cmbStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "状态:";
            // 
            // txtLanceNo
            // 
            this.txtLanceNo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtLanceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLanceNo.Name = "txtLanceNo";
            this.txtLanceNo.Size = new System.Drawing.Size(60, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "枪号:";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(97, 22);
            this.toolStripButton1.Text = "废弃喷枪导出";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dvLance
            // 
            this.dvLance.AllowUserToAddRows = false;
            this.dvLance.AutoGenerateColumns = false;
            this.dvLance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvLance.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvLance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvLance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvLance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lanceNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.lanceAgeDataGridViewTextBoxColumn,
            this.lanceVendorDataGridViewTextBoxColumn,
            this.processTimeDataGridViewTextBoxColumn,
            this.processAmountDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.timeChangeDataGridViewTextBoxColumn,
            this.operatorDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.teamDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dvLance.DataSource = this.bsLance;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvLance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvLance.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvLance.Location = new System.Drawing.Point(0, 25);
            this.dvLance.Name = "dvLance";
            this.dvLance.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvLance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvLance.RowTemplate.Height = 23;
            this.dvLance.Size = new System.Drawing.Size(1200, 340);
            this.dvLance.TabIndex = 65;
            // 
            // lanceNoDataGridViewTextBoxColumn
            // 
            this.lanceNoDataGridViewTextBoxColumn.DataPropertyName = "LanceNo";
            this.lanceNoDataGridViewTextBoxColumn.HeaderText = "枪号";
            this.lanceNoDataGridViewTextBoxColumn.Name = "lanceNoDataGridViewTextBoxColumn";
            this.lanceNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.lanceNoDataGridViewTextBoxColumn.Width = 54;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code_Val_long";
            this.statusDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = false;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = "";
            this.dsStatus.InsertMethod = "";
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "code_group = \'DeS_Lance_Status\'order by code_val_long";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStatus.SubscribeTarget = "";
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "";
            this.dsStatus.UpdateMethod = "";
            this.dsStatus.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTablecode_des,
            this.coldsStatusL3DataTablecode_Val_long});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTablecode_des
            // 
            this.coldsStatusL3DataTablecode_des.Caption = "code_des";
            this.coldsStatusL3DataTablecode_des.ColumnName = "code_des";
            this.coldsStatusL3DataTablecode_des.Namespace = "";
            // 
            // coldsStatusL3DataTablecode_Val_long
            // 
            this.coldsStatusL3DataTablecode_Val_long.Caption = "code_Val_long";
            this.coldsStatusL3DataTablecode_Val_long.ColumnName = "code_Val_long";
            this.coldsStatusL3DataTablecode_Val_long.DataType = typeof(int);
            this.coldsStatusL3DataTablecode_Val_long.Namespace = "";
            // 
            // lanceAgeDataGridViewTextBoxColumn
            // 
            this.lanceAgeDataGridViewTextBoxColumn.DataPropertyName = "LanceAge";
            this.lanceAgeDataGridViewTextBoxColumn.HeaderText = "枪龄";
            this.lanceAgeDataGridViewTextBoxColumn.Name = "lanceAgeDataGridViewTextBoxColumn";
            this.lanceAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lanceAgeDataGridViewTextBoxColumn.Width = 54;
            // 
            // lanceVendorDataGridViewTextBoxColumn
            // 
            this.lanceVendorDataGridViewTextBoxColumn.DataPropertyName = "LanceVendor";
            this.lanceVendorDataGridViewTextBoxColumn.DataSource = this.dsVendor;
            this.lanceVendorDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.lanceVendorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lanceVendorDataGridViewTextBoxColumn.HeaderText = "厂家";
            this.lanceVendorDataGridViewTextBoxColumn.Name = "lanceVendorDataGridViewTextBoxColumn";
            this.lanceVendorDataGridViewTextBoxColumn.ReadOnly = true;
            this.lanceVendorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lanceVendorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lanceVendorDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code";
            this.lanceVendorDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsVendor
            // 
            this.dsVendor.AutoLoad = true;
            this.dsVendor.AutoSubscribe = false;
            this.dsVendor.DataSetName = "L3DataSet";
            this.dsVendor.DeleteMethod = "";
            this.dsVendor.InsertMethod = "";
            this.dsVendor.L3DataAdapter = this.Adapter;
            this.dsVendor.LoadEvent = "";
            this.dsVendor.LoadTrigger = null;
            this.dsVendor.RefreshValve = 1000;
            this.dsVendor.SourceCommand = null;
            this.dsVendor.SourceCondition = "";
            this.dsVendor.SourceMethod = "";
            this.dsVendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsVendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsVendor.SubscribeTarget = "";
            this.dsVendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsVendor});
            this.dsVendor.UpdateEvent = "";
            this.dsVendor.UpdateMethod = "";
            this.dsVendor.UpdateTrigger = null;
            // 
            // schemadsVendor
            // 
            this.schemadsVendor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsVendorL3DataTablecode,
            this.coldsVendorL3DataTablecode_des});
            this.schemadsVendor.TableName = "L3DataTable";
            // 
            // coldsVendorL3DataTablecode
            // 
            this.coldsVendorL3DataTablecode.Caption = "code";
            this.coldsVendorL3DataTablecode.ColumnName = "code";
            this.coldsVendorL3DataTablecode.Namespace = "";
            // 
            // coldsVendorL3DataTablecode_des
            // 
            this.coldsVendorL3DataTablecode_des.Caption = "code_des";
            this.coldsVendorL3DataTablecode_des.ColumnName = "code_des";
            this.coldsVendorL3DataTablecode_des.Namespace = "";
            // 
            // processTimeDataGridViewTextBoxColumn
            // 
            this.processTimeDataGridViewTextBoxColumn.DataPropertyName = "ProcessTime";
            this.processTimeDataGridViewTextBoxColumn.HeaderText = "喷吹时间";
            this.processTimeDataGridViewTextBoxColumn.Name = "processTimeDataGridViewTextBoxColumn";
            this.processTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.processTimeDataGridViewTextBoxColumn.Width = 78;
            // 
            // processAmountDataGridViewTextBoxColumn
            // 
            this.processAmountDataGridViewTextBoxColumn.DataPropertyName = "ProcessAmount";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.processAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.processAmountDataGridViewTextBoxColumn.HeaderText = "喷吹量[T]";
            this.processAmountDataGridViewTextBoxColumn.Name = "processAmountDataGridViewTextBoxColumn";
            this.processAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.processAmountDataGridViewTextBoxColumn.Width = 84;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "动作";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDataGridViewTextBoxColumn.Width = 54;
            // 
            // timeChangeDataGridViewTextBoxColumn
            // 
            this.timeChangeDataGridViewTextBoxColumn.DataPropertyName = "Time_Change";
            this.timeChangeDataGridViewTextBoxColumn.HeaderText = "更改时间";
            this.timeChangeDataGridViewTextBoxColumn.Name = "timeChangeDataGridViewTextBoxColumn";
            this.timeChangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeChangeDataGridViewTextBoxColumn.Width = 78;
            // 
            // operatorDataGridViewTextBoxColumn
            // 
            this.operatorDataGridViewTextBoxColumn.DataPropertyName = "Operator";
            this.operatorDataGridViewTextBoxColumn.HeaderText = "责任人";
            this.operatorDataGridViewTextBoxColumn.Name = "operatorDataGridViewTextBoxColumn";
            this.operatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatorDataGridViewTextBoxColumn.Width = 66;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.DataSource = this.dsShift2;
            this.shiftDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.shiftDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.shiftDataGridViewTextBoxColumn.HeaderText = "班次";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shiftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shiftDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code";
            this.shiftDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsShift2
            // 
            this.dsShift2.AutoLoad = true;
            this.dsShift2.AutoSubscribe = false;
            this.dsShift2.DataSetName = "L3DataSet";
            this.dsShift2.DeleteMethod = "";
            this.dsShift2.InsertMethod = "";
            this.dsShift2.L3DataAdapter = this.Adapter;
            this.dsShift2.LoadEvent = "";
            this.dsShift2.LoadTrigger = null;
            this.dsShift2.RefreshValve = 1000;
            this.dsShift2.SourceCommand = null;
            this.dsShift2.SourceCondition = "CODE_GROUP = \'ShiftID\'";
            this.dsShift2.SourceMethod = "";
            this.dsShift2.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift2.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShift2.SubscribeTarget = "";
            this.dsShift2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift2});
            this.dsShift2.UpdateEvent = "";
            this.dsShift2.UpdateMethod = "";
            this.dsShift2.UpdateTrigger = null;
            // 
            // schemadsShift2
            // 
            this.schemadsShift2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShift2L3DataTablecode,
            this.coldsShift2L3DataTablecode_des});
            this.schemadsShift2.TableName = "L3DataTable";
            // 
            // coldsShift2L3DataTablecode
            // 
            this.coldsShift2L3DataTablecode.Caption = "code";
            this.coldsShift2L3DataTablecode.ColumnName = "code";
            this.coldsShift2L3DataTablecode.Namespace = "";
            // 
            // coldsShift2L3DataTablecode_des
            // 
            this.coldsShift2L3DataTablecode_des.Caption = "code_des";
            this.coldsShift2L3DataTablecode_des.ColumnName = "code_des";
            this.coldsShift2L3DataTablecode_des.Namespace = "";
            // 
            // teamDataGridViewTextBoxColumn
            // 
            this.teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            this.teamDataGridViewTextBoxColumn.DataSource = this.dsTeam2;
            this.teamDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.teamDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.teamDataGridViewTextBoxColumn.HeaderText = "班别";
            this.teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            this.teamDataGridViewTextBoxColumn.ReadOnly = true;
            this.teamDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teamDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teamDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code";
            this.teamDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsTeam2
            // 
            this.dsTeam2.AutoLoad = true;
            this.dsTeam2.AutoSubscribe = false;
            this.dsTeam2.DataSetName = "L3DataSet";
            this.dsTeam2.DeleteMethod = "";
            this.dsTeam2.InsertMethod = "";
            this.dsTeam2.L3DataAdapter = this.Adapter;
            this.dsTeam2.LoadEvent = "";
            this.dsTeam2.LoadTrigger = null;
            this.dsTeam2.RefreshValve = 1000;
            this.dsTeam2.SourceCommand = null;
            this.dsTeam2.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeam2.SourceMethod = "";
            this.dsTeam2.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeam2.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeam2.SubscribeTarget = "";
            this.dsTeam2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeam2});
            this.dsTeam2.UpdateEvent = "";
            this.dsTeam2.UpdateMethod = "";
            this.dsTeam2.UpdateTrigger = null;
            // 
            // schemadsTeam2
            // 
            this.schemadsTeam2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeam2L3DataTablecode,
            this.coldsTeam2L3DataTablecode_des});
            this.schemadsTeam2.TableName = "L3DataTable";
            // 
            // coldsTeam2L3DataTablecode
            // 
            this.coldsTeam2L3DataTablecode.Caption = "code";
            this.coldsTeam2L3DataTablecode.ColumnName = "code";
            this.coldsTeam2L3DataTablecode.Namespace = "";
            // 
            // coldsTeam2L3DataTablecode_des
            // 
            this.coldsTeam2L3DataTablecode_des.Caption = "code_des";
            this.coldsTeam2L3DataTablecode_des.ColumnName = "code_des";
            this.coldsTeam2L3DataTablecode_des.Namespace = "";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 54;
            // 
            // bsLance
            // 
            this.bsLance.DataMember = "L3DataTable";
            this.bsLance.DataSource = this.dsLance;
            // 
            // dsLance
            // 
            this.dsLance.AutoLoad = true;
            this.dsLance.AutoSubscribe = false;
            this.dsLance.DataSetName = "L3DataSet";
            this.dsLance.DeleteMethod = "";
            this.dsLance.InsertMethod = "";
            this.dsLance.L3DataAdapter = this.Adapter;
            this.dsLance.LoadEvent = "";
            this.dsLance.LoadTrigger = null;
            this.dsLance.RefreshValve = 1000;
            this.dsLance.SourceCommand = null;
            this.dsLance.SourceCondition = "1=2";
            this.dsLance.SourceMethod = "";
            this.dsLance.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLance.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Lance_Log";
            this.dsLance.SubscribeTarget = "";
            this.dsLance.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLance});
            this.dsLance.UpdateEvent = "";
            this.dsLance.UpdateMethod = "";
            this.dsLance.UpdateTrigger = null;
            // 
            // schemadsLance
            // 
            this.schemadsLance.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceL3DataTableGUID,
            this.coldsLanceL3DataTableName,
            this.coldsLanceL3DataTableLanceNo,
            this.coldsLanceL3DataTableStatus,
            this.coldsLanceL3DataTableLanceAge,
            this.coldsLanceL3DataTableLanceVendor,
            this.coldsLanceL3DataTableProcessTime,
            this.coldsLanceL3DataTableProcessAmount,
            this.coldsLanceL3DataTableNote,
            this.coldsLanceL3DataTableAction,
            this.coldsLanceL3DataTableTime_Change,
            this.coldsLanceL3DataTableOperator,
            this.coldsLanceL3DataTableShift,
            this.coldsLanceL3DataTableTeam});
            this.schemadsLance.TableName = "L3DataTable";
            // 
            // coldsLanceL3DataTableGUID
            // 
            this.coldsLanceL3DataTableGUID.Caption = "GUID";
            this.coldsLanceL3DataTableGUID.ColumnName = "GUID";
            this.coldsLanceL3DataTableGUID.Namespace = "";
            // 
            // coldsLanceL3DataTableName
            // 
            this.coldsLanceL3DataTableName.Caption = "Name";
            this.coldsLanceL3DataTableName.ColumnName = "Name";
            this.coldsLanceL3DataTableName.Namespace = "";
            // 
            // coldsLanceL3DataTableLanceNo
            // 
            this.coldsLanceL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsLanceL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsLanceL3DataTableLanceNo.Namespace = "";
            // 
            // coldsLanceL3DataTableStatus
            // 
            this.coldsLanceL3DataTableStatus.Caption = "Status";
            this.coldsLanceL3DataTableStatus.ColumnName = "Status";
            this.coldsLanceL3DataTableStatus.DataType = typeof(int);
            this.coldsLanceL3DataTableStatus.Namespace = "";
            // 
            // coldsLanceL3DataTableLanceAge
            // 
            this.coldsLanceL3DataTableLanceAge.Caption = "LanceAge";
            this.coldsLanceL3DataTableLanceAge.ColumnName = "LanceAge";
            this.coldsLanceL3DataTableLanceAge.DataType = typeof(int);
            this.coldsLanceL3DataTableLanceAge.Namespace = "";
            // 
            // coldsLanceL3DataTableLanceVendor
            // 
            this.coldsLanceL3DataTableLanceVendor.Caption = "LanceVendor";
            this.coldsLanceL3DataTableLanceVendor.ColumnName = "LanceVendor";
            this.coldsLanceL3DataTableLanceVendor.Namespace = "";
            // 
            // coldsLanceL3DataTableProcessTime
            // 
            this.coldsLanceL3DataTableProcessTime.Caption = "ProcessTime";
            this.coldsLanceL3DataTableProcessTime.ColumnName = "ProcessTime";
            this.coldsLanceL3DataTableProcessTime.DataType = typeof(int);
            this.coldsLanceL3DataTableProcessTime.Namespace = "";
            // 
            // coldsLanceL3DataTableProcessAmount
            // 
            this.coldsLanceL3DataTableProcessAmount.Caption = "ProcessAmount";
            this.coldsLanceL3DataTableProcessAmount.ColumnName = "ProcessAmount";
            this.coldsLanceL3DataTableProcessAmount.DataType = typeof(double);
            this.coldsLanceL3DataTableProcessAmount.Namespace = "";
            // 
            // coldsLanceL3DataTableNote
            // 
            this.coldsLanceL3DataTableNote.Caption = "Note";
            this.coldsLanceL3DataTableNote.ColumnName = "Note";
            this.coldsLanceL3DataTableNote.Namespace = "";
            // 
            // coldsLanceL3DataTableAction
            // 
            this.coldsLanceL3DataTableAction.Caption = "Action";
            this.coldsLanceL3DataTableAction.ColumnName = "Action";
            this.coldsLanceL3DataTableAction.Namespace = "";
            // 
            // coldsLanceL3DataTableTime_Change
            // 
            this.coldsLanceL3DataTableTime_Change.Caption = "Time_Change";
            this.coldsLanceL3DataTableTime_Change.ColumnName = "Time_Change";
            this.coldsLanceL3DataTableTime_Change.DataType = typeof(System.DateTime);
            this.coldsLanceL3DataTableTime_Change.Namespace = "";
            // 
            // coldsLanceL3DataTableOperator
            // 
            this.coldsLanceL3DataTableOperator.Caption = "Operator";
            this.coldsLanceL3DataTableOperator.ColumnName = "Operator";
            this.coldsLanceL3DataTableOperator.Namespace = "";
            // 
            // coldsLanceL3DataTableShift
            // 
            this.coldsLanceL3DataTableShift.Caption = "Shift";
            this.coldsLanceL3DataTableShift.ColumnName = "Shift";
            this.coldsLanceL3DataTableShift.Namespace = "";
            // 
            // coldsLanceL3DataTableTeam
            // 
            this.coldsLanceL3DataTableTeam.Caption = "Team";
            this.coldsLanceL3DataTableTeam.ColumnName = "Team";
            this.coldsLanceL3DataTableTeam.Namespace = "";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LanceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "枪号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn2.HeaderText = "状态";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LanceAge";
            this.dataGridViewTextBoxColumn3.HeaderText = "枪龄";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LanceVendor";
            this.dataGridViewTextBoxColumn4.HeaderText = "厂家";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProcessTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "喷吹时间";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProcessAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "脱硫量";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Action";
            this.dataGridViewTextBoxColumn7.HeaderText = "动作";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 54;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Time_Change";
            this.dataGridViewTextBoxColumn8.HeaderText = "改变时间";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 78;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Operator";
            this.dataGridViewTextBoxColumn9.HeaderText = "责任人";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 66;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Shift";
            this.dataGridViewTextBoxColumn10.HeaderText = "班次";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 54;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Team";
            this.dataGridViewTextBoxColumn11.HeaderText = "班别";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 54;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn12.HeaderText = "备注";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 54;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 99);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "废弃喷枪";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lanceNoDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.lanceAgeDataGridViewTextBoxColumn1,
            this.lanceVendorDataGridViewTextBoxColumn1,
            this.processTimeDataGridViewTextBoxColumn1,
            this.processAmountDataGridViewTextBoxColumn1,
            this.OpTime,
            this.noteDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.bsFQ;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 79);
            this.dataGridView1.TabIndex = 0;
            // 
            // lanceNoDataGridViewTextBoxColumn1
            // 
            this.lanceNoDataGridViewTextBoxColumn1.DataPropertyName = "LanceNo";
            this.lanceNoDataGridViewTextBoxColumn1.HeaderText = "枪号";
            this.lanceNoDataGridViewTextBoxColumn1.Name = "lanceNoDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.DataSource = this.dsStatus;
            this.statusDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.code_des";
            this.statusDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn1.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.code_Val_long";
            // 
            // lanceAgeDataGridViewTextBoxColumn1
            // 
            this.lanceAgeDataGridViewTextBoxColumn1.DataPropertyName = "LanceAge";
            this.lanceAgeDataGridViewTextBoxColumn1.HeaderText = "枪龄";
            this.lanceAgeDataGridViewTextBoxColumn1.Name = "lanceAgeDataGridViewTextBoxColumn1";
            // 
            // lanceVendorDataGridViewTextBoxColumn1
            // 
            this.lanceVendorDataGridViewTextBoxColumn1.DataPropertyName = "LanceVendor";
            this.lanceVendorDataGridViewTextBoxColumn1.DataSource = this.dsVendor;
            this.lanceVendorDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.code_des";
            this.lanceVendorDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lanceVendorDataGridViewTextBoxColumn1.HeaderText = "厂家";
            this.lanceVendorDataGridViewTextBoxColumn1.Name = "lanceVendorDataGridViewTextBoxColumn1";
            this.lanceVendorDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lanceVendorDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lanceVendorDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.code";
            // 
            // processTimeDataGridViewTextBoxColumn1
            // 
            this.processTimeDataGridViewTextBoxColumn1.DataPropertyName = "ProcessTime";
            this.processTimeDataGridViewTextBoxColumn1.HeaderText = "处理时间";
            this.processTimeDataGridViewTextBoxColumn1.Name = "processTimeDataGridViewTextBoxColumn1";
            // 
            // processAmountDataGridViewTextBoxColumn1
            // 
            this.processAmountDataGridViewTextBoxColumn1.DataPropertyName = "ProcessAmount";
            this.processAmountDataGridViewTextBoxColumn1.HeaderText = "脱硫量";
            this.processAmountDataGridViewTextBoxColumn1.Name = "processAmountDataGridViewTextBoxColumn1";
            // 
            // OpTime
            // 
            this.OpTime.DataPropertyName = "OpTime";
            this.OpTime.HeaderText = "废弃时间";
            this.OpTime.Name = "OpTime";
            // 
            // noteDataGridViewTextBoxColumn1
            // 
            this.noteDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noteDataGridViewTextBoxColumn1.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn1.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn1.Name = "noteDataGridViewTextBoxColumn1";
            // 
            // bsFQ
            // 
            this.bsFQ.DataMember = "L3DataTable";
            this.bsFQ.DataSource = this.dsFQ;
            // 
            // dsFQ
            // 
            this.dsFQ.AutoLoad = true;
            this.dsFQ.AutoSubscribe = false;
            this.dsFQ.DataSetName = "L3DataSet";
            this.dsFQ.DeleteMethod = "";
            this.dsFQ.InsertMethod = "";
            this.dsFQ.L3DataAdapter = this.Adapter;
            this.dsFQ.LoadEvent = "";
            this.dsFQ.LoadTrigger = null;
            this.dsFQ.RefreshValve = 1000;
            this.dsFQ.SourceCommand = null;
            this.dsFQ.SourceCondition = "1=2";
            this.dsFQ.SourceMethod = "";
            this.dsFQ.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFQ.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Lance_Data";
            this.dsFQ.SubscribeTarget = "";
            this.dsFQ.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFQ});
            this.dsFQ.UpdateEvent = "";
            this.dsFQ.UpdateMethod = "";
            this.dsFQ.UpdateTrigger = null;
            // 
            // schemadsFQ
            // 
            this.schemadsFQ.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFQL3DataTableLanceNo,
            this.coldsFQL3DataTableStatus,
            this.coldsFQL3DataTableLanceAge,
            this.coldsFQL3DataTableLanceVendor,
            this.coldsFQL3DataTableProcessTime,
            this.coldsFQL3DataTableProcessAmount,
            this.coldsFQL3DataTableNote,
            this.coldsFQL3DataTableOpTime});
            this.schemadsFQ.TableName = "L3DataTable";
            // 
            // coldsFQL3DataTableLanceNo
            // 
            this.coldsFQL3DataTableLanceNo.Caption = "LanceNo";
            this.coldsFQL3DataTableLanceNo.ColumnName = "LanceNo";
            this.coldsFQL3DataTableLanceNo.Namespace = "";
            // 
            // coldsFQL3DataTableStatus
            // 
            this.coldsFQL3DataTableStatus.Caption = "Status";
            this.coldsFQL3DataTableStatus.ColumnName = "Status";
            this.coldsFQL3DataTableStatus.DataType = typeof(int);
            this.coldsFQL3DataTableStatus.Namespace = "";
            // 
            // coldsFQL3DataTableLanceAge
            // 
            this.coldsFQL3DataTableLanceAge.Caption = "LanceAge";
            this.coldsFQL3DataTableLanceAge.ColumnName = "LanceAge";
            this.coldsFQL3DataTableLanceAge.DataType = typeof(int);
            this.coldsFQL3DataTableLanceAge.Namespace = "";
            // 
            // coldsFQL3DataTableLanceVendor
            // 
            this.coldsFQL3DataTableLanceVendor.Caption = "LanceVendor";
            this.coldsFQL3DataTableLanceVendor.ColumnName = "LanceVendor";
            this.coldsFQL3DataTableLanceVendor.Namespace = "";
            // 
            // coldsFQL3DataTableProcessTime
            // 
            this.coldsFQL3DataTableProcessTime.Caption = "ProcessTime";
            this.coldsFQL3DataTableProcessTime.ColumnName = "ProcessTime";
            this.coldsFQL3DataTableProcessTime.DataType = typeof(int);
            this.coldsFQL3DataTableProcessTime.Namespace = "";
            // 
            // coldsFQL3DataTableProcessAmount
            // 
            this.coldsFQL3DataTableProcessAmount.Caption = "ProcessAmount";
            this.coldsFQL3DataTableProcessAmount.ColumnName = "ProcessAmount";
            this.coldsFQL3DataTableProcessAmount.DataType = typeof(double);
            this.coldsFQL3DataTableProcessAmount.Namespace = "";
            // 
            // coldsFQL3DataTableNote
            // 
            this.coldsFQL3DataTableNote.Caption = "Note";
            this.coldsFQL3DataTableNote.ColumnName = "Note";
            this.coldsFQL3DataTableNote.Namespace = "";
            // 
            // coldsFQL3DataTableOpTime
            // 
            this.coldsFQL3DataTableOpTime.Caption = "OpTime";
            this.coldsFQL3DataTableOpTime.ColumnName = "OpTime";
            this.coldsFQL3DataTableOpTime.DataType = typeof(System.DateTime);
            this.coldsFQL3DataTableOpTime.Namespace = "";
            // 
            // LanceQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvLance);
            this.Controls.Add(this.bdN1);
            this.Name = "LanceQueryFrm";
            this.TabText = "喷枪数据查询";
            this.Text = "喷枪数据查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LanceQueryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFQ)).EndInit();
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
        private System.Windows.Forms.DataGridView dvLance;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox cmbStatus;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripTextBox txtLanceNo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTablecode_des;
        private System.Data.DataColumn coldsStatusL3DataTablecode_Val_long;
        private AppSvrHMI.L3DataSet dsLance;
        private System.Data.DataTable schemadsLance;
        private System.Data.DataColumn coldsLanceL3DataTableGUID;
        private System.Data.DataColumn coldsLanceL3DataTableName;
        private System.Data.DataColumn coldsLanceL3DataTableLanceNo;
        private System.Data.DataColumn coldsLanceL3DataTableStatus;
        private System.Data.DataColumn coldsLanceL3DataTableLanceAge;
        private System.Data.DataColumn coldsLanceL3DataTableLanceVendor;
        private System.Data.DataColumn coldsLanceL3DataTableProcessTime;
        private System.Data.DataColumn coldsLanceL3DataTableProcessAmount;
        private System.Data.DataColumn coldsLanceL3DataTableNote;
        private System.Data.DataColumn coldsLanceL3DataTableAction;
        private System.Data.DataColumn coldsLanceL3DataTableTime_Change;
        private System.Data.DataColumn coldsLanceL3DataTableOperator;
        private System.Data.DataColumn coldsLanceL3DataTableShift;
        private System.Data.DataColumn coldsLanceL3DataTableTeam;
        private System.Windows.Forms.BindingSource bsLance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsShift2;
        private System.Data.DataTable schemadsShift2;
        private System.Data.DataColumn coldsShift2L3DataTablecode;
        private System.Data.DataColumn coldsShift2L3DataTablecode_des;
        private AppSvrHMI.L3DataSet dsTeam2;
        private System.Data.DataTable schemadsTeam2;
        private System.Data.DataColumn coldsTeam2L3DataTablecode;
        private System.Data.DataColumn coldsTeam2L3DataTablecode_des;
        private AppSvrHMI.L3DataSet dsVendor;
        private System.Data.DataTable schemadsVendor;
        private System.Data.DataColumn coldsVendorL3DataTablecode;
        private System.Data.DataColumn coldsVendorL3DataTablecode_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lanceVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeChangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn teamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnInExl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsFQ;
        private AppSvrHMI.L3DataSet dsFQ;
        private System.Data.DataTable schemadsFQ;
        private System.Data.DataColumn coldsFQL3DataTableLanceNo;
        private System.Data.DataColumn coldsFQL3DataTableStatus;
        private System.Data.DataColumn coldsFQL3DataTableLanceAge;
        private System.Data.DataColumn coldsFQL3DataTableLanceVendor;
        private System.Data.DataColumn coldsFQL3DataTableProcessTime;
        private System.Data.DataColumn coldsFQL3DataTableProcessAmount;
        private System.Data.DataColumn coldsFQL3DataTableNote;
        private System.Data.DataColumn coldsFQL3DataTableOpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceAgeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn lanceVendorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn processAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}