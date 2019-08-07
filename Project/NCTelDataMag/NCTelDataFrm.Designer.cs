namespace NCTelDataMag
{
    partial class NCTelDataFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCTelDataFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsLog = new System.Windows.Forms.BindingSource(this.components);
            this.dsLog = new AppSvrHMI.L3DataSet();
            this.schemadsLog = new System.Data.DataTable();
            this.coldsLogL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLogL3DataTableName = new System.Data.DataColumn();
            this.coldsLogL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsLogL3DataTableBillType = new System.Data.DataColumn();
            this.coldsLogL3DataTableFlag = new System.Data.DataColumn();
            this.coldsLogL3DataTableRemark = new System.Data.DataColumn();
            this.coldsLogL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsLogL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsLogL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsLogL3DataTableOther3 = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.txbHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tdtend = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tdtstart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bsType = new System.Windows.Forms.BindingSource(this.components);
            this.dsType = new AppSvrHMI.L3DataSet();
            this.schemadsType = new System.Data.DataTable();
            this.coldsTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsYesNo = new System.Windows.Forms.BindingSource(this.components);
            this.dsYesNo = new AppSvrHMI.L3DataSet();
            this.schemadsYesNo = new System.Data.DataTable();
            this.coldsYesNoL3DataTableCode = new System.Data.DataColumn();
            this.coldsYesNoL3DataTableCode_Des = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.dvTel = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
            this.bnM.BindingSource = this.bsLog;
            this.bnM.CountItem = this.bindingNavigatorCountItem;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.toolStripButton1,
            this.btnQuery,
            this.txbHeatID,
            this.toolStripLabel4,
            this.tdtend,
            this.toolStripLabel3,
            this.tdtstart,
            this.toolStripLabel1});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(895, 25);
            this.bnM.TabIndex = 31;
            this.bnM.Text = "bindingNavigator1";
            // 
            // bsLog
            // 
            this.bsLog.DataMember = "L3DataTable";
            this.bsLog.DataSource = this.dsLog;
            // 
            // dsLog
            // 
            this.dsLog.AutoLoad = true;
            this.dsLog.AutoSubscribe = false;
            this.dsLog.DataSetName = "L3DataSet";
            this.dsLog.DeleteMethod = "";
            this.dsLog.InsertMethod = "";
            this.dsLog.L3DataAdapter = this.Adapter;
            this.dsLog.LoadEvent = "";
            this.dsLog.LoadTrigger = null;
            this.dsLog.RefreshValve = 1000;
            this.dsLog.SourceCommand = null;
            this.dsLog.SourceCondition = "";
            this.dsLog.SourceMethod = "";
            this.dsLog.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsLog.SourceURI = "XGMESLogic\\BaseDataMag\\CRetrunData_NC";
            this.dsLog.SubscribeTarget = null;
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLog});
            this.dsLog.UpdateEvent = "";
            this.dsLog.UpdateMethod = "";
            this.dsLog.UpdateTrigger = null;
            // 
            // schemadsLog
            // 
            this.schemadsLog.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLogL3DataTableGUID,
            this.coldsLogL3DataTableName,
            this.coldsLogL3DataTableHeatID,
            this.coldsLogL3DataTableBillType,
            this.coldsLogL3DataTableFlag,
            this.coldsLogL3DataTableRemark,
            this.coldsLogL3DataTableCreateTime,
            this.coldsLogL3DataTableOther1,
            this.coldsLogL3DataTableOther2,
            this.coldsLogL3DataTableOther3});
            this.schemadsLog.TableName = "L3DataTable";
            // 
            // coldsLogL3DataTableGUID
            // 
            this.coldsLogL3DataTableGUID.Caption = "GUID";
            this.coldsLogL3DataTableGUID.ColumnName = "GUID";
            this.coldsLogL3DataTableGUID.Namespace = "";
            // 
            // coldsLogL3DataTableName
            // 
            this.coldsLogL3DataTableName.Caption = "Name";
            this.coldsLogL3DataTableName.ColumnName = "Name";
            this.coldsLogL3DataTableName.Namespace = "";
            // 
            // coldsLogL3DataTableHeatID
            // 
            this.coldsLogL3DataTableHeatID.Caption = "HeatID";
            this.coldsLogL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsLogL3DataTableHeatID.Namespace = "";
            // 
            // coldsLogL3DataTableBillType
            // 
            this.coldsLogL3DataTableBillType.Caption = "BillType";
            this.coldsLogL3DataTableBillType.ColumnName = "BillType";
            this.coldsLogL3DataTableBillType.Namespace = "";
            // 
            // coldsLogL3DataTableFlag
            // 
            this.coldsLogL3DataTableFlag.Caption = "Flag";
            this.coldsLogL3DataTableFlag.ColumnName = "Flag";
            this.coldsLogL3DataTableFlag.Namespace = "";
            // 
            // coldsLogL3DataTableRemark
            // 
            this.coldsLogL3DataTableRemark.Caption = "Remark";
            this.coldsLogL3DataTableRemark.ColumnName = "Remark";
            this.coldsLogL3DataTableRemark.Namespace = "";
            // 
            // coldsLogL3DataTableCreateTime
            // 
            this.coldsLogL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsLogL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsLogL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsLogL3DataTableCreateTime.Namespace = "";
            // 
            // coldsLogL3DataTableOther1
            // 
            this.coldsLogL3DataTableOther1.Caption = "Other1";
            this.coldsLogL3DataTableOther1.ColumnName = "Other1";
            this.coldsLogL3DataTableOther1.Namespace = "";
            // 
            // coldsLogL3DataTableOther2
            // 
            this.coldsLogL3DataTableOther2.Caption = "Other2";
            this.coldsLogL3DataTableOther2.ColumnName = "Other2";
            this.coldsLogL3DataTableOther2.Namespace = "";
            // 
            // coldsLogL3DataTableOther3
            // 
            this.coldsLogL3DataTableOther3.Caption = "Other3";
            this.coldsLogL3DataTableOther3.ColumnName = "Other3";
            this.coldsLogL3DataTableOther3.Namespace = "";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "高级查询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // txbHeatID
            // 
            this.txbHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbHeatID.Name = "txbHeatID";
            this.txbHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel4.Text = "炉号";
            // 
            // tdtend
            // 
            this.tdtend.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tdtend.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tdtend.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tdtend.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tdtend.CustomFormat = "yyyy-MM-dd";
            this.tdtend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdtend.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tdtend.MaximumSize = new System.Drawing.Size(0, 0);
            this.tdtend.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tdtend.MinimumSize = new System.Drawing.Size(0, 0);
            this.tdtend.Name = "tdtend";
            this.tdtend.Size = new System.Drawing.Size(93, 22);
            this.tdtend.Text = "2009-03-26";
            this.tdtend.Value = new System.DateTime(2009, 3, 26, 12, 18, 41, 239);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel3.Text = "-";
            // 
            // tdtstart
            // 
            this.tdtstart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tdtstart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tdtstart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tdtstart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tdtstart.CustomFormat = "yyyy-MM-dd";
            this.tdtstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdtstart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tdtstart.MaximumSize = new System.Drawing.Size(0, 0);
            this.tdtstart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tdtstart.MinimumSize = new System.Drawing.Size(0, 0);
            this.tdtstart.Name = "tdtstart";
            this.tdtstart.Size = new System.Drawing.Size(93, 22);
            this.tdtstart.Text = "2009-03-26";
            this.tdtstart.Value = new System.DateTime(2009, 3, 26, 12, 17, 30, 417);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel1.Text = "日期";
            // 
            // bsType
            // 
            this.bsType.DataMember = "L3DataTable";
            this.bsType.DataSource = this.dsType;
            // 
            // dsType
            // 
            this.dsType.AutoLoad = true;
            this.dsType.AutoSubscribe = true;
            this.dsType.DataSetName = "L3DataSet";
            this.dsType.DeleteMethod = "";
            this.dsType.InsertMethod = "";
            this.dsType.L3DataAdapter = this.Adapter;
            this.dsType.LoadEvent = "";
            this.dsType.LoadTrigger = null;
            this.dsType.RefreshValve = 1000;
            this.dsType.SourceCommand = null;
            this.dsType.SourceCondition = "Code_Group=\'NCTEL_TYPE\'";
            this.dsType.SourceMethod = "";
            this.dsType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsType.SubscribeTarget = null;
            this.dsType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsType});
            this.dsType.UpdateEvent = "";
            this.dsType.UpdateMethod = "";
            this.dsType.UpdateTrigger = null;
            // 
            // schemadsType
            // 
            this.schemadsType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTypeL3DataTableCode,
            this.coldsTypeL3DataTableCode_Des});
            this.schemadsType.TableName = "L3DataTable";
            // 
            // coldsTypeL3DataTableCode
            // 
            this.coldsTypeL3DataTableCode.Caption = "Code";
            this.coldsTypeL3DataTableCode.ColumnName = "Code";
            this.coldsTypeL3DataTableCode.Namespace = "";
            // 
            // coldsTypeL3DataTableCode_Des
            // 
            this.coldsTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTypeL3DataTableCode_Des.Namespace = "";
            // 
            // bsYesNo
            // 
            this.bsYesNo.DataMember = "L3DataTable";
            this.bsYesNo.DataSource = this.dsYesNo;
            // 
            // dsYesNo
            // 
            this.dsYesNo.AutoLoad = true;
            this.dsYesNo.AutoSubscribe = true;
            this.dsYesNo.DataSetName = "L3DataSet";
            this.dsYesNo.DeleteMethod = "";
            this.dsYesNo.InsertMethod = "";
            this.dsYesNo.L3DataAdapter = this.Adapter;
            this.dsYesNo.LoadEvent = "";
            this.dsYesNo.LoadTrigger = null;
            this.dsYesNo.RefreshValve = 1000;
            this.dsYesNo.SourceCommand = null;
            this.dsYesNo.SourceCondition = "Code_Group=\'NCTEL_YESNO\'";
            this.dsYesNo.SourceMethod = "";
            this.dsYesNo.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsYesNo.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsYesNo.SubscribeTarget = null;
            this.dsYesNo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsYesNo});
            this.dsYesNo.UpdateEvent = "";
            this.dsYesNo.UpdateMethod = "";
            this.dsYesNo.UpdateTrigger = null;
            // 
            // schemadsYesNo
            // 
            this.schemadsYesNo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsYesNoL3DataTableCode,
            this.coldsYesNoL3DataTableCode_Des});
            this.schemadsYesNo.TableName = "L3DataTable";
            // 
            // coldsYesNoL3DataTableCode
            // 
            this.coldsYesNoL3DataTableCode.Caption = "Code";
            this.coldsYesNoL3DataTableCode.ColumnName = "Code";
            this.coldsYesNoL3DataTableCode.Namespace = "";
            // 
            // coldsYesNoL3DataTableCode_Des
            // 
            this.coldsYesNoL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsYesNoL3DataTableCode_Des.Namespace = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 143);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "描述";
            // 
            // txtRemark
            // 
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Location = new System.Drawing.Point(3, 17);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(889, 123);
            this.txtRemark.TabIndex = 0;
            this.txtRemark.Text = "";
            // 
            // dvTel
            // 
            this.dvTel.AllowUserToAddRows = false;
            this.dvTel.AutoGenerateColumns = false;
            this.dvTel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTel.ColumnHeadersHeight = 35;
            this.dvTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvTel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.heatIDDataGridViewTextBoxColumn,
            this.other1DataGridViewTextBoxColumn,
            this.billTypeDataGridViewTextBoxColumn,
            this.flagDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.other2DataGridViewTextBoxColumn,
            this.other3DataGridViewTextBoxColumn});
            this.dvTel.DataSource = this.bsLog;
            this.dvTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTel.Location = new System.Drawing.Point(0, 25);
            this.dvTel.MultiSelect = false;
            this.dvTel.Name = "dvTel";
            this.dvTel.ReadOnly = true;
            this.dvTel.RowTemplate.Height = 23;
            this.dvTel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTel.Size = new System.Drawing.Size(895, 426);
            this.dvTel.TabIndex = 34;
            this.dvTel.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvTel_DataError);
            this.dvTel.CurrentCellChanged += new System.EventHandler(this.dvTel_CurrentCellChanged);
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "发送时间";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 105;
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // other1DataGridViewTextBoxColumn
            // 
            this.other1DataGridViewTextBoxColumn.DataPropertyName = "Other1";
            this.other1DataGridViewTextBoxColumn.DataSource = this.bsType;
            this.other1DataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.other1DataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.other1DataGridViewTextBoxColumn.HeaderText = "物料类型";
            this.other1DataGridViewTextBoxColumn.Name = "other1DataGridViewTextBoxColumn";
            this.other1DataGridViewTextBoxColumn.ReadOnly = true;
            this.other1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.other1DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.other1DataGridViewTextBoxColumn.ValueMember = "Code";
            this.other1DataGridViewTextBoxColumn.Width = 80;
            // 
            // billTypeDataGridViewTextBoxColumn
            // 
            this.billTypeDataGridViewTextBoxColumn.DataPropertyName = "BillType";
            this.billTypeDataGridViewTextBoxColumn.HeaderText = "单据类型";
            this.billTypeDataGridViewTextBoxColumn.Name = "billTypeDataGridViewTextBoxColumn";
            this.billTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.billTypeDataGridViewTextBoxColumn.Width = 80;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewTextBoxColumn.DataSource = this.bsYesNo;
            this.flagDataGridViewTextBoxColumn.DisplayMember = "Code_Des";
            this.flagDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.flagDataGridViewTextBoxColumn.HeaderText = "电文结果";
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.ReadOnly = true;
            this.flagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.flagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.flagDataGridViewTextBoxColumn.ValueMember = "Code";
            this.flagDataGridViewTextBoxColumn.Width = 80;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "失败原因";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarkDataGridViewTextBoxColumn.Width = 1500;
            // 
            // other2DataGridViewTextBoxColumn
            // 
            this.other2DataGridViewTextBoxColumn.DataPropertyName = "Other2";
            this.other2DataGridViewTextBoxColumn.HeaderText = "Other2";
            this.other2DataGridViewTextBoxColumn.Name = "other2DataGridViewTextBoxColumn";
            this.other2DataGridViewTextBoxColumn.ReadOnly = true;
            this.other2DataGridViewTextBoxColumn.Visible = false;
            this.other2DataGridViewTextBoxColumn.Width = 66;
            // 
            // other3DataGridViewTextBoxColumn
            // 
            this.other3DataGridViewTextBoxColumn.DataPropertyName = "Other3";
            this.other3DataGridViewTextBoxColumn.HeaderText = "Other3";
            this.other3DataGridViewTextBoxColumn.Name = "other3DataGridViewTextBoxColumn";
            this.other3DataGridViewTextBoxColumn.ReadOnly = true;
            this.other3DataGridViewTextBoxColumn.Visible = false;
            this.other3DataGridViewTextBoxColumn.Width = 66;
            // 
            // NCTelDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 594);
            this.Controls.Add(this.dvTel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnM);
            this.Name = "NCTelDataFrm";
            this.TabText = "NC电文实绩查询";
            this.Text = "NC电文实绩查询";
            this.Load += new System.EventHandler(this.NCTelDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsYesNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private AppSvrHMI.L3DataSet dsLog;
        private System.Windows.Forms.BindingSource bsLog;
        private System.Data.DataTable schemadsLog;
        private System.Data.DataColumn coldsLogL3DataTableGUID;
        private System.Data.DataColumn coldsLogL3DataTableName;
        private System.Data.DataColumn coldsLogL3DataTableHeatID;
        private System.Data.DataColumn coldsLogL3DataTableBillType;
        private System.Data.DataColumn coldsLogL3DataTableFlag;
        private System.Data.DataColumn coldsLogL3DataTableRemark;
        private System.Data.DataColumn coldsLogL3DataTableCreateTime;
        private System.Data.DataColumn coldsLogL3DataTableOther1;
        private System.Data.DataColumn coldsLogL3DataTableOther2;
        private System.Data.DataColumn coldsLogL3DataTableOther3;
        private AppSvrHMI.L3DataSet dsType;
        private AppSvrHMI.L3DataSet dsYesNo;
        private System.Data.DataTable schemadsType;
        private System.Data.DataColumn coldsTypeL3DataTableCode;
        private System.Data.DataColumn coldsTypeL3DataTableCode_Des;
        private System.Data.DataTable schemadsYesNo;
        private System.Data.DataColumn coldsYesNoL3DataTableCode;
        private System.Data.DataColumn coldsYesNoL3DataTableCode_Des;
        private System.Windows.Forms.BindingSource bsType;
        private System.Windows.Forms.BindingSource bsYesNo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private buttonHide.ToolStripToriDateTimePicker tdtstart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker tdtend;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txbHeatID;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvTel;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn other1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn other3DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}