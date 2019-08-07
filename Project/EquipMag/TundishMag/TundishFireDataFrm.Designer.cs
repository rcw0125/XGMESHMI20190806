namespace EquipMag.TundishMag
{
    partial class TundishFireDataFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishFireDataFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsM = new System.Windows.Forms.BindingSource(this.components);
            this.dsM = new AppSvrHMI.L3DataSet();
            this.schemadsM = new System.Data.DataTable();
            this.coldsML3DataTableWorkID = new System.Data.DataColumn();
            this.coldsML3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsML3DataTableTundishID = new System.Data.DataColumn();
            this.coldsML3DataTableFlow_Gas = new System.Data.DataColumn();
            this.coldsML3DataTablePosition = new System.Data.DataColumn();
            this.coldsML3DataTableFire_Type = new System.Data.DataColumn();
            this.coldsML3DataTableMeasureTime = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTundishID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbCCMID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowGasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fireTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsFireType = new AppSvrHMI.L3DataSet();
            this.schemadsFireType = new System.Data.DataTable();
            this.coldsFireTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsFireTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.measureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsCCMID = new AppSvrHMI.L3DataSet();
            this.schemadsCCMID = new System.Data.DataTable();
            this.coldsCCMIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCCMIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFireType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFireType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.BindingSource = this.bsM;
            this.bnM.CountItem = this.bindingNavigatorCountItem;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.dtEnd,
            this.toolStripLabel5,
            this.dtStart,
            this.toolStripLabel3,
            this.cmbTundishID,
            this.toolStripLabel2,
            this.cmbCCMID,
            this.toolStripLabel4,
            this.btnOutPut});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(1000, 25);
            this.bnM.TabIndex = 0;
            this.bnM.Text = "bindingNavigator1";
            // 
            // bsM
            // 
            this.bsM.DataMember = "L3DataTable";
            this.bsM.DataSource = this.dsM;
            // 
            // dsM
            // 
            this.dsM.AutoSubscribe = false;
            this.dsM.DataSetName = "L3DataSet";
            this.dsM.DeleteMethod = "";
            this.dsM.InsertMethod = "";
            this.dsM.L3DataAdapter = this.Adapter;
            this.dsM.LoadEvent = "";
            this.dsM.LoadTrigger = null;
            this.dsM.RefreshValve = 1000;
            this.dsM.SourceCommand = null;
            this.dsM.SourceCondition = "1=2";
            this.dsM.SourceMethod = "";
            this.dsM.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsM.SourceURI = "XGMESLogic\\CCMMag\\CCCM_Tundish_Fire_Data";
            this.dsM.SubscribeTarget = null;
            this.dsM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsM});
            this.dsM.UpdateEvent = "";
            this.dsM.UpdateMethod = "";
            this.dsM.UpdateTrigger = null;
            // 
            // schemadsM
            // 
            this.schemadsM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsML3DataTableWorkID,
            this.coldsML3DataTableCast_ID,
            this.coldsML3DataTableTundishID,
            this.coldsML3DataTableFlow_Gas,
            this.coldsML3DataTablePosition,
            this.coldsML3DataTableFire_Type,
            this.coldsML3DataTableMeasureTime});
            this.schemadsM.TableName = "L3DataTable";
            // 
            // coldsML3DataTableWorkID
            // 
            this.coldsML3DataTableWorkID.Caption = "WorkID";
            this.coldsML3DataTableWorkID.ColumnName = "WorkID";
            this.coldsML3DataTableWorkID.Namespace = "";
            // 
            // coldsML3DataTableCast_ID
            // 
            this.coldsML3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsML3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsML3DataTableCast_ID.Namespace = "";
            // 
            // coldsML3DataTableTundishID
            // 
            this.coldsML3DataTableTundishID.Caption = "TundishID";
            this.coldsML3DataTableTundishID.ColumnName = "TundishID";
            this.coldsML3DataTableTundishID.Namespace = "";
            // 
            // coldsML3DataTableFlow_Gas
            // 
            this.coldsML3DataTableFlow_Gas.Caption = "Flow_Gas";
            this.coldsML3DataTableFlow_Gas.ColumnName = "Flow_Gas";
            this.coldsML3DataTableFlow_Gas.DataType = typeof(float);
            this.coldsML3DataTableFlow_Gas.Namespace = "";
            // 
            // coldsML3DataTablePosition
            // 
            this.coldsML3DataTablePosition.Caption = "Position";
            this.coldsML3DataTablePosition.ColumnName = "Position";
            this.coldsML3DataTablePosition.Namespace = "";
            // 
            // coldsML3DataTableFire_Type
            // 
            this.coldsML3DataTableFire_Type.Caption = "Fire_Type";
            this.coldsML3DataTableFire_Type.ColumnName = "Fire_Type";
            this.coldsML3DataTableFire_Type.Namespace = "";
            // 
            // coldsML3DataTableMeasureTime
            // 
            this.coldsML3DataTableMeasureTime.Caption = "MeasureTime";
            this.coldsML3DataTableMeasureTime.ColumnName = "MeasureTime";
            this.coldsML3DataTableMeasureTime.DataType = typeof(System.DateTime);
            this.coldsML3DataTableMeasureTime.Namespace = "";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.toolStripLabel1.Text = "　";
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
            this.dtEnd.Text = "2009-03-16";
            this.dtEnd.Value = new System.DateTime(2009, 3, 16, 18, 21, 29, 312);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel5.Text = "--";
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
            this.dtStart.Text = "2009-03-16";
            this.dtStart.Value = new System.DateTime(2009, 3, 16, 18, 21, 29, 312);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "日期:";
            // 
            // cmbTundishID
            // 
            this.cmbTundishID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTundishID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTundishID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTundishID.Name = "cmbTundishID";
            this.cmbTundishID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "中包:";
            // 
            // cmbCCMID
            // 
            this.cmbCCMID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbCCMID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCCMID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCCMID.Name = "cmbCCMID";
            this.cmbCCMID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "铸机:";
            // 
            // dvM
            // 
            this.dvM.AllowUserToAddRows = false;
            this.dvM.AutoGenerateColumns = false;
            this.dvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workIDDataGridViewTextBoxColumn,
            this.castIDDataGridViewTextBoxColumn,
            this.tundishIDDataGridViewTextBoxColumn,
            this.flowGasDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.fireTypeDataGridViewTextBoxColumn,
            this.measureTimeDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsM;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 25);
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.Size = new System.Drawing.Size(1000, 592);
            this.dvM.TabIndex = 1;
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // castIDDataGridViewTextBoxColumn
            // 
            this.castIDDataGridViewTextBoxColumn.DataPropertyName = "Cast_ID";
            this.castIDDataGridViewTextBoxColumn.HeaderText = "铸机";
            this.castIDDataGridViewTextBoxColumn.Name = "castIDDataGridViewTextBoxColumn";
            this.castIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tundishIDDataGridViewTextBoxColumn
            // 
            this.tundishIDDataGridViewTextBoxColumn.DataPropertyName = "TundishID";
            this.tundishIDDataGridViewTextBoxColumn.HeaderText = "中包";
            this.tundishIDDataGridViewTextBoxColumn.Name = "tundishIDDataGridViewTextBoxColumn";
            this.tundishIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowGasDataGridViewTextBoxColumn
            // 
            this.flowGasDataGridViewTextBoxColumn.DataPropertyName = "Flow_Gas";
            this.flowGasDataGridViewTextBoxColumn.HeaderText = "煤气流量[]";
            this.flowGasDataGridViewTextBoxColumn.Name = "flowGasDataGridViewTextBoxColumn";
            this.flowGasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "车号";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fireTypeDataGridViewTextBoxColumn
            // 
            this.fireTypeDataGridViewTextBoxColumn.DataPropertyName = "Fire_Type";
            this.fireTypeDataGridViewTextBoxColumn.DataSource = this.dsFireType;
            this.fireTypeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.fireTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fireTypeDataGridViewTextBoxColumn.HeaderText = "烘烤类型";
            this.fireTypeDataGridViewTextBoxColumn.Name = "fireTypeDataGridViewTextBoxColumn";
            this.fireTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fireTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fireTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fireTypeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsFireType
            // 
            this.dsFireType.AutoSubscribe = false;
            this.dsFireType.DataSetName = "L3DataSet";
            this.dsFireType.DeleteMethod = "";
            this.dsFireType.InsertMethod = "";
            this.dsFireType.L3DataAdapter = this.Adapter;
            this.dsFireType.LoadEvent = "";
            this.dsFireType.LoadTrigger = null;
            this.dsFireType.RefreshValve = 1000;
            this.dsFireType.SourceCommand = null;
            this.dsFireType.SourceCondition = "Code_Group = \'Tundish_HotFire_Type\'";
            this.dsFireType.SourceMethod = "";
            this.dsFireType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFireType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsFireType.SubscribeTarget = null;
            this.dsFireType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFireType});
            this.dsFireType.UpdateEvent = "";
            this.dsFireType.UpdateMethod = "";
            this.dsFireType.UpdateTrigger = null;
            // 
            // schemadsFireType
            // 
            this.schemadsFireType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFireTypeL3DataTableCode,
            this.coldsFireTypeL3DataTableCode_Des});
            this.schemadsFireType.TableName = "L3DataTable";
            // 
            // coldsFireTypeL3DataTableCode
            // 
            this.coldsFireTypeL3DataTableCode.Caption = "Code";
            this.coldsFireTypeL3DataTableCode.ColumnName = "Code";
            this.coldsFireTypeL3DataTableCode.Namespace = "";
            // 
            // coldsFireTypeL3DataTableCode_Des
            // 
            this.coldsFireTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsFireTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsFireTypeL3DataTableCode_Des.Namespace = "";
            // 
            // measureTimeDataGridViewTextBoxColumn
            // 
            this.measureTimeDataGridViewTextBoxColumn.DataPropertyName = "MeasureTime";
            this.measureTimeDataGridViewTextBoxColumn.HeaderText = "采集时间";
            this.measureTimeDataGridViewTextBoxColumn.Name = "measureTimeDataGridViewTextBoxColumn";
            this.measureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsCCMID
            // 
            this.dsCCMID.AutoSubscribe = false;
            this.dsCCMID.DataSetName = "L3DataSet";
            this.dsCCMID.DeleteMethod = "";
            this.dsCCMID.InsertMethod = "";
            this.dsCCMID.L3DataAdapter = this.Adapter;
            this.dsCCMID.LoadEvent = "";
            this.dsCCMID.LoadTrigger = null;
            this.dsCCMID.RefreshValve = 1000;
            this.dsCCMID.SourceCommand = null;
            this.dsCCMID.SourceCondition = "Code_Group = \'Caster\' order by Code";
            this.dsCCMID.SourceMethod = "";
            this.dsCCMID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCCMID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCCMID.SubscribeTarget = null;
            this.dsCCMID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCCMID});
            this.dsCCMID.UpdateEvent = "";
            this.dsCCMID.UpdateMethod = "";
            this.dsCCMID.UpdateTrigger = null;
            // 
            // schemadsCCMID
            // 
            this.schemadsCCMID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCCMIDL3DataTableCode,
            this.coldsCCMIDL3DataTableCode_Des});
            this.schemadsCCMID.TableName = "L3DataTable";
            // 
            // coldsCCMIDL3DataTableCode
            // 
            this.coldsCCMIDL3DataTableCode.Caption = "Code";
            this.coldsCCMIDL3DataTableCode.ColumnName = "Code";
            this.coldsCCMIDL3DataTableCode.Namespace = "";
            // 
            // coldsCCMIDL3DataTableCode_Des
            // 
            this.coldsCCMIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCCMIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCCMIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsTundishID
            // 
            this.dsTundishID.AutoSubscribe = false;
            this.dsTundishID.DataSetName = "L3DataSet";
            this.dsTundishID.DeleteMethod = "";
            this.dsTundishID.InsertMethod = "";
            this.dsTundishID.L3DataAdapter = this.Adapter;
            this.dsTundishID.LoadEvent = "";
            this.dsTundishID.LoadTrigger = null;
            this.dsTundishID.RefreshValve = 1000;
            this.dsTundishID.SourceCommand = null;
            this.dsTundishID.SourceCondition = "TundishID is not null order by TundishID";
            this.dsTundishID.SourceMethod = "";
            this.dsTundishID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishID.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Base";
            this.dsTundishID.SubscribeTarget = null;
            this.dsTundishID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundishID});
            this.dsTundishID.UpdateEvent = "";
            this.dsTundishID.UpdateMethod = "";
            this.dsTundishID.UpdateTrigger = null;
            // 
            // schemadsTundishID
            // 
            this.schemadsTundishID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishIDL3DataTableTundishID});
            this.schemadsTundishID.TableName = "L3DataTable";
            // 
            // coldsTundishIDL3DataTableTundishID
            // 
            this.coldsTundishIDL3DataTableTundishID.Caption = "TundishID";
            this.coldsTundishIDL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsTundishIDL3DataTableTundishID.Namespace = "";
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(91, 22);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // TundishFireDataFrm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 617);
            this.Controls.Add(this.dvM);
            this.Controls.Add(this.bnM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishFireDataFrm";
            this.TabText = "中包热备烘烤数据";
            this.Text = "中包热备烘烤数据";
            this.Load += new System.EventHandler(this.TundishFireDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFireType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFireType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCCMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCCMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox cmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.DataGridView dvM;
        private AppSvrHMI.L3DataSet dsM;
        private System.Windows.Forms.BindingSource bsM;
        private System.Windows.Forms.ToolStripComboBox cmbCCMID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Data.DataTable schemadsM;
        private System.Data.DataColumn coldsML3DataTableWorkID;
        private System.Data.DataColumn coldsML3DataTableCast_ID;
        private System.Data.DataColumn coldsML3DataTableTundishID;
        private System.Data.DataColumn coldsML3DataTableFlow_Gas;
        private System.Data.DataColumn coldsML3DataTablePosition;
        private System.Data.DataColumn coldsML3DataTableFire_Type;
        private System.Data.DataColumn coldsML3DataTableMeasureTime;
        private AppSvrHMI.L3DataSet dsFireType;
        private System.Data.DataTable schemadsFireType;
        private System.Data.DataColumn coldsFireTypeL3DataTableCode;
        private System.Data.DataColumn coldsFireTypeL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowGasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn fireTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measureTimeDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataSet dsCCMID;
        private System.Data.DataTable schemadsCCMID;
        private System.Data.DataColumn coldsCCMIDL3DataTableCode;
        private System.Data.DataColumn coldsCCMIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private System.Windows.Forms.ToolStripButton btnOutPut;
    }
}