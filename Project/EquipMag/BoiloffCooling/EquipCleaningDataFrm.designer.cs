namespace EquipMag.BoiloffCooling
{
    partial class EquipCleaningDataFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipCleaningDataFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsCleaningData = new System.Windows.Forms.BindingSource(this.components);
            this.dsCleaningData = new AppSvrHMI.L3DataSet();
            this.schemadsEnergyData = new System.Data.DataTable();
            this.coldsEnergyDataL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEnergyDataL3DataTableName = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableTagName = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableTagType = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableTagValue = new System.Data.DataColumn();
            this.coldsAdjustSetL3DataTableCatch_Time = new System.Data.DataColumn();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dtStartTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtEndTime = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTagName = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dvCleaningData = new System.Windows.Forms.DataGridView();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCode = new AppSvrHMI.L3DataSet();
            this.schemadsCode = new System.Data.DataTable();
            this.coldsCodeL3DataTableID = new System.Data.DataColumn();
            this.coldsCodeL3DataTableDesc = new System.Data.DataColumn();
            this.tagTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catchTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCleaningData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCleaningData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvCleaningData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsCleaningData;
            this.bindingNavigator1.CountItem = this.toolStripLabel4;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripButton4,
            this.toolStripButton5,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel5,
            this.btnQuery,
            this.cmbTagName,
            this.toolStripLabel6,
            this.toolStripLabel3,
            this.dtEndTime,
            this.toolStripLabel2,
            this.dtStartTime,
            this.toolStripLabel1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton2;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton5;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton4;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton3;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 19;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bsCleaningData
            // 
            this.bsCleaningData.DataMember = "L3DataTable";
            this.bsCleaningData.DataSource = this.dsCleaningData;
            // 
            // dsCleaningData
            // 
            this.dsCleaningData.AutoLoad = true;
            this.dsCleaningData.AutoSubscribe = false;
            this.dsCleaningData.DataSetName = "L3DataSet";
            this.dsCleaningData.DeleteMethod = "";
            this.dsCleaningData.InsertMethod = "";
            this.dsCleaningData.L3DataAdapter = this.Adapter;
            this.dsCleaningData.LoadEvent = "";
            this.dsCleaningData.LoadTrigger = null;
            this.dsCleaningData.RefreshValve = 1000;
            this.dsCleaningData.SourceCommand = null;
            this.dsCleaningData.SourceCondition = "1=2";
            this.dsCleaningData.SourceMethod = "";
            this.dsCleaningData.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCleaningData.SourceURI = "XGMESLogic\\EquipMag\\CEquip_Cleaning_Data";
            this.dsCleaningData.SubscribeTarget = null;
            this.dsCleaningData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEnergyData});
            this.dsCleaningData.UpdateEvent = "";
            this.dsCleaningData.UpdateMethod = "";
            this.dsCleaningData.UpdateTrigger = null;
            // 
            // schemadsEnergyData
            // 
            this.schemadsEnergyData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEnergyDataL3DataTableGUID,
            this.coldsEnergyDataL3DataTableName,
            this.coldsAdjustSetL3DataTableTagName,
            this.coldsAdjustSetL3DataTableTagType,
            this.coldsAdjustSetL3DataTableTagValue,
            this.coldsAdjustSetL3DataTableCatch_Time});
            this.schemadsEnergyData.TableName = "L3DataTable";
            // 
            // coldsEnergyDataL3DataTableGUID
            // 
            this.coldsEnergyDataL3DataTableGUID.Caption = "GUID";
            this.coldsEnergyDataL3DataTableGUID.ColumnName = "GUID";
            this.coldsEnergyDataL3DataTableGUID.Namespace = "";
            // 
            // coldsEnergyDataL3DataTableName
            // 
            this.coldsEnergyDataL3DataTableName.Caption = "Name";
            this.coldsEnergyDataL3DataTableName.ColumnName = "Name";
            this.coldsEnergyDataL3DataTableName.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableTagName
            // 
            this.coldsAdjustSetL3DataTableTagName.Caption = "TagName";
            this.coldsAdjustSetL3DataTableTagName.ColumnName = "TagName";
            this.coldsAdjustSetL3DataTableTagName.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableTagType
            // 
            this.coldsAdjustSetL3DataTableTagType.Caption = "TagType";
            this.coldsAdjustSetL3DataTableTagType.ColumnName = "TagType";
            this.coldsAdjustSetL3DataTableTagType.DataType = typeof(int);
            this.coldsAdjustSetL3DataTableTagType.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableTagValue
            // 
            this.coldsAdjustSetL3DataTableTagValue.Caption = "TagValue";
            this.coldsAdjustSetL3DataTableTagValue.ColumnName = "TagValue";
            this.coldsAdjustSetL3DataTableTagValue.DataType = typeof(int);
            this.coldsAdjustSetL3DataTableTagValue.Namespace = "";
            // 
            // coldsAdjustSetL3DataTableCatch_Time
            // 
            this.coldsAdjustSetL3DataTableCatch_Time.Caption = "Catch_Time";
            this.coldsAdjustSetL3DataTableCatch_Time.ColumnName = "Catch_Time";
            this.coldsAdjustSetL3DataTableCatch_Time.DataType = typeof(System.DateTime);
            this.coldsAdjustSetL3DataTableCatch_Time.Namespace = "";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel4.Text = "/ {0}";
            this.toolStripLabel4.ToolTipText = "总项数";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到第一条记录";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到上一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到下一条记录";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(25, 22);
            this.toolStripLabel3.Text = "          ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "选择时间:";
            // 
            // dtStartTime
            // 
            this.dtStartTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStartTime.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtStartTime.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStartTime.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStartTime.CustomFormat = "yyyy-MM-dd";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStartTime.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStartTime.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(100, 22);
            this.dtStartTime.Text = "2009-04-14";
            this.dtStartTime.Value = new System.DateTime(2009, 4, 14, 16, 49, 54, 308);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel2.Text = "-";
            // 
            // dtEndTime
            // 
            this.dtEndTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEndTime.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtEndTime.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEndTime.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEndTime.CustomFormat = "yyyy-MM-dd";
            this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEndTime.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEndTime.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(100, 22);
            this.dtEndTime.Text = "2009-04-14";
            this.dtEndTime.Value = new System.DateTime(2009, 4, 14, 16, 50, 9, 19);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel6.Text = "标签名:";
            // 
            // cmbTagName
            // 
            this.cmbTagName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTagName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTagName.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbTagName.Items.AddRange(new object[] {
            "",
            "1#汽包排污事件",
            "2#汽包排污事件",
            "3#汽包排污事件",
            "4#汽包排污事件",
            "1#烟道排污事件",
            "2#烟道排污事件",
            "3#烟道排污事件",
            "4#烟道排污事件"});
            this.cmbTagName.Name = "cmbTagName";
            this.cmbTagName.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel5.Text = "     ";
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
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dvCleaningData
            // 
            this.dvCleaningData.AllowUserToAddRows = false;
            this.dvCleaningData.AllowUserToDeleteRows = false;
            this.dvCleaningData.AllowUserToResizeRows = false;
            this.dvCleaningData.AutoGenerateColumns = false;
            this.dvCleaningData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvCleaningData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCleaningData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCleaningData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagNameDataGridViewTextBoxColumn,
            this.tagTypeDataGridViewTextBoxColumn,
            this.tagValueDataGridViewTextBoxColumn,
            this.catchTimeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvCleaningData.DataSource = this.bsCleaningData;
            this.dvCleaningData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCleaningData.Location = new System.Drawing.Point(0, 25);
            this.dvCleaningData.Name = "dvCleaningData";
            this.dvCleaningData.ReadOnly = true;
            this.dvCleaningData.RowTemplate.Height = 23;
            this.dvCleaningData.Size = new System.Drawing.Size(1000, 575);
            this.dvCleaningData.TabIndex = 20;
            this.dvCleaningData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvCleaningData_DataError);
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "TagName";
            this.tagNameDataGridViewTextBoxColumn.DataSource = this.dsCode;
            this.tagNameDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Desc";
            this.tagNameDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "标签名";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tagNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tagNameDataGridViewTextBoxColumn.ValueMember = "L3DataTable.ID";
            // 
            // dsCode
            // 
            this.dsCode.AutoLoad = true;
            this.dsCode.AutoSubscribe = false;
            this.dsCode.DataSetName = "L3DataSet";
            this.dsCode.DeleteMethod = "";
            this.dsCode.InsertMethod = "";
            this.dsCode.L3DataAdapter = null;
            this.dsCode.LoadEvent = "";
            this.dsCode.LoadTrigger = null;
            this.dsCode.RefreshValve = 1000;
            this.dsCode.SourceCommand = null;
            this.dsCode.SourceCondition = "";
            this.dsCode.SourceMethod = "";
            this.dsCode.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsCode.SourceURI = "";
            this.dsCode.SubscribeTarget = "";
            this.dsCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCode});
            this.dsCode.UpdateEvent = "";
            this.dsCode.UpdateMethod = "";
            this.dsCode.UpdateTrigger = null;
            // 
            // schemadsCode
            // 
            this.schemadsCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCodeL3DataTableID,
            this.coldsCodeL3DataTableDesc});
            this.schemadsCode.TableName = "L3DataTable";
            // 
            // coldsCodeL3DataTableID
            // 
            this.coldsCodeL3DataTableID.Caption = "ID";
            this.coldsCodeL3DataTableID.ColumnName = "ID";
            this.coldsCodeL3DataTableID.Namespace = "";
            // 
            // coldsCodeL3DataTableDesc
            // 
            this.coldsCodeL3DataTableDesc.Caption = "Desc";
            this.coldsCodeL3DataTableDesc.ColumnName = "Desc";
            this.coldsCodeL3DataTableDesc.Namespace = "";
            // 
            // tagTypeDataGridViewTextBoxColumn
            // 
            this.tagTypeDataGridViewTextBoxColumn.DataPropertyName = "TagType";
            this.tagTypeDataGridViewTextBoxColumn.HeaderText = "标签类型";
            this.tagTypeDataGridViewTextBoxColumn.Name = "tagTypeDataGridViewTextBoxColumn";
            this.tagTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagValueDataGridViewTextBoxColumn
            // 
            this.tagValueDataGridViewTextBoxColumn.DataPropertyName = "TagValue";
            this.tagValueDataGridViewTextBoxColumn.HeaderText = "标签值";
            this.tagValueDataGridViewTextBoxColumn.Name = "tagValueDataGridViewTextBoxColumn";
            this.tagValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // catchTimeDataGridViewTextBoxColumn
            // 
            this.catchTimeDataGridViewTextBoxColumn.DataPropertyName = "Catch_Time";
            this.catchTimeDataGridViewTextBoxColumn.HeaderText = "采集时刻";
            this.catchTimeDataGridViewTextBoxColumn.Name = "catchTimeDataGridViewTextBoxColumn";
            this.catchTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // EquipCleaningDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dvCleaningData);
            this.Controls.Add(this.bindingNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EquipCleaningDataFrm";
            this.TabText = "汽化冷却排污管理";
            this.Text = "汽化冷却排污管理";
            this.Load += new System.EventHandler(this.EnergyDataManageFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCleaningData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCleaningData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEnergyData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvCleaningData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dvCleaningData;
        private AppSvrHMI.L3DataSet dsCleaningData;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemadsEnergyData;
        private System.Data.DataColumn coldsEnergyDataL3DataTableGUID;
        private System.Data.DataColumn coldsEnergyDataL3DataTableName;
        private System.Windows.Forms.BindingSource bsCleaningData;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Data.DataColumn coldsAdjustSetL3DataTableTagName;
        private System.Data.DataColumn coldsAdjustSetL3DataTableTagType;
        private System.Data.DataColumn coldsAdjustSetL3DataTableTagValue;
        private System.Data.DataColumn coldsAdjustSetL3DataTableCatch_Time;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private buttonHide.ToolStripToriDateTimePicker dtStartTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEndTime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox cmbTagName;
        private AppSvrHMI.L3DataSet dsCode;
        private System.Data.DataTable schemadsCode;
        private System.Data.DataColumn coldsCodeL3DataTableID;
        private System.Data.DataColumn coldsCodeL3DataTableDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn tagNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catchTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}