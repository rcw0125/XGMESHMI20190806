namespace UnitMag.DeSMag
{
    partial class LanceMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanceMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlDeSLanceDataAdd = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnChangeStatus = new System.Windows.Forms.ToolStripButton();
            this.btnChangeAge = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConfirm = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnLanceQuery = new System.Windows.Forms.ToolStripButton();
            this.btnIntoEXL = new System.Windows.Forms.ToolStripButton();
            this.dvLance = new System.Windows.Forms.DataGridView();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OpTime = new DataGridValid.CalendarColumn();
            this.lanceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.lanceAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanceVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsVendor = new AppSvrHMI.L3DataSet();
            this.schemadsVendor = new System.Data.DataTable();
            this.coldsVendorL3DataTableCode = new System.Data.DataColumn();
            this.coldsVendorL3DataTableCode_Des = new System.Data.DataColumn();
            this.processTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.coldsLanceL3DataTableOpTime = new System.Data.DataColumn();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.tlDeSLanceDataAdd,
            this.btnAdd,
            this.btnChangeStatus,
            this.btnChangeAge,
            this.tsbtnConfirm,
            this.tsbtnCancel,
            this.btnLanceQuery,
            this.btnIntoEXL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(816, 43);
            this.toolStrip1.TabIndex = 62;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(65, 40);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // tlDeSLanceDataAdd
            // 
            this.tlDeSLanceDataAdd.Image = ((System.Drawing.Image)(resources.GetObject("tlDeSLanceDataAdd.Image")));
            this.tlDeSLanceDataAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlDeSLanceDataAdd.Name = "tlDeSLanceDataAdd";
            this.tlDeSLanceDataAdd.Size = new System.Drawing.Size(125, 40);
            this.tlDeSLanceDataAdd.Text = "新增实绩(屏蔽)";
            this.tlDeSLanceDataAdd.Visible = false;
            this.tlDeSLanceDataAdd.Click += new System.EventHandler(this.tlDeSLanceDataAdd_Click);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnDeSLanceAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 40);
            this.btnAdd.Text = "新枪加入";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChangeStatus
            // 
            this.Adapter.SetAccessRight(this.btnChangeStatus, "btnDeSLanceChangeStatus");
            this.btnChangeStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeStatus.Image")));
            this.btnChangeStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(89, 40);
            this.btnChangeStatus.Text = "修改状态";
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnChangeAge
            // 
            this.Adapter.SetAccessRight(this.btnChangeAge, "btnDeSLanceChangeAge");
            this.btnChangeAge.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeAge.Image")));
            this.btnChangeAge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeAge.Name = "btnChangeAge";
            this.btnChangeAge.Size = new System.Drawing.Size(89, 40);
            this.btnChangeAge.Text = "修改枪龄";
            this.btnChangeAge.Click += new System.EventHandler(this.btnChangeAge_Click);
            // 
            // tsbtnConfirm
            // 
            this.Adapter.SetAccessRight(this.tsbtnConfirm, "btnDeSLanceConfirm");
            this.tsbtnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConfirm.Image")));
            this.tsbtnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConfirm.Name = "tsbtnConfirm";
            this.tsbtnConfirm.Size = new System.Drawing.Size(65, 40);
            this.tsbtnConfirm.Text = "确定";
            this.tsbtnConfirm.Click += new System.EventHandler(this.tsbtnConfirm_Click);
            // 
            // tsbtnCancel
            // 
            this.tsbtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancel.Image")));
            this.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancel.Name = "tsbtnCancel";
            this.tsbtnCancel.Size = new System.Drawing.Size(65, 40);
            this.tsbtnCancel.Text = "取消";
            this.tsbtnCancel.Click += new System.EventHandler(this.tsbtnCancel_Click);
            // 
            // btnLanceQuery
            // 
            this.Adapter.SetAccessRight(this.btnLanceQuery, "btnLanceQuery");
            this.btnLanceQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnLanceQuery.Image")));
            this.btnLanceQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLanceQuery.Name = "btnLanceQuery";
            this.btnLanceQuery.Size = new System.Drawing.Size(113, 40);
            this.btnLanceQuery.Text = "喷枪数据查询";
            this.btnLanceQuery.Click += new System.EventHandler(this.btnLanceQuery_Click);
            // 
            // btnIntoEXL
            // 
            this.btnIntoEXL.Image = ((System.Drawing.Image)(resources.GetObject("btnIntoEXL.Image")));
            this.btnIntoEXL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIntoEXL.Name = "btnIntoEXL";
            this.btnIntoEXL.Size = new System.Drawing.Size(95, 40);
            this.btnIntoEXL.Text = "导出到EXL";
            this.btnIntoEXL.Click += new System.EventHandler(this.btnIntoEXL_Click);
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
            this.CheckFlag,
            this.OpTime,
            this.lanceNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.lanceAgeDataGridViewTextBoxColumn,
            this.lanceVendorDataGridViewTextBoxColumn,
            this.processTimeDataGridViewTextBoxColumn,
            this.processAmountDataGridViewTextBoxColumn,
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
            this.dvLance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvLance.Location = new System.Drawing.Point(0, 68);
            this.dvLance.Name = "dvLance";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvLance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvLance.RowTemplate.Height = 23;
            this.dvLance.Size = new System.Drawing.Size(816, 333);
            this.dvLance.TabIndex = 64;
            // 
            // CheckFlag
            // 
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Width = 35;
            // 
            // OpTime
            // 
            this.OpTime.DataPropertyName = "OpTime";
            this.OpTime.HeaderText = "操作时间";
            this.OpTime.Name = "OpTime";
            this.OpTime.Width = 59;
            // 
            // lanceNoDataGridViewTextBoxColumn
            // 
            this.lanceNoDataGridViewTextBoxColumn.DataPropertyName = "LanceNo";
            this.lanceNoDataGridViewTextBoxColumn.HeaderText = "枪号";
            this.lanceNoDataGridViewTextBoxColumn.Name = "lanceNoDataGridViewTextBoxColumn";
            this.lanceNoDataGridViewTextBoxColumn.Width = 54;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsStatus;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "状态";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code_Val_Long";
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
            this.dsStatus.SourceCondition = "code_group = \'DeS_Lance_Status\' order by code_val_long";
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
            this.coldsStatusL3DataTableCode_Des,
            this.coldsStatusL3DataTableCode_Val_Long});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableCode_Des
            // 
            this.coldsStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.Namespace = "";
            // 
            // coldsStatusL3DataTableCode_Val_Long
            // 
            this.coldsStatusL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsStatusL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsStatusL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsStatusL3DataTableCode_Val_Long.Namespace = "";
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
            this.lanceVendorDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.lanceVendorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.lanceVendorDataGridViewTextBoxColumn.HeaderText = "厂家";
            this.lanceVendorDataGridViewTextBoxColumn.Name = "lanceVendorDataGridViewTextBoxColumn";
            this.lanceVendorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lanceVendorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.lanceVendorDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.coldsVendorL3DataTableCode,
            this.coldsVendorL3DataTableCode_Des});
            this.schemadsVendor.TableName = "L3DataTable";
            // 
            // coldsVendorL3DataTableCode
            // 
            this.coldsVendorL3DataTableCode.Caption = "Code";
            this.coldsVendorL3DataTableCode.ColumnName = "Code";
            this.coldsVendorL3DataTableCode.Namespace = "";
            // 
            // coldsVendorL3DataTableCode_Des
            // 
            this.coldsVendorL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsVendorL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsVendorL3DataTableCode_Des.Namespace = "";
            // 
            // processTimeDataGridViewTextBoxColumn
            // 
            this.processTimeDataGridViewTextBoxColumn.DataPropertyName = "ProcessTime";
            this.processTimeDataGridViewTextBoxColumn.HeaderText = "处理时间[M]";
            this.processTimeDataGridViewTextBoxColumn.Name = "processTimeDataGridViewTextBoxColumn";
            this.processTimeDataGridViewTextBoxColumn.Width = 96;
            // 
            // processAmountDataGridViewTextBoxColumn
            // 
            this.processAmountDataGridViewTextBoxColumn.DataPropertyName = "ProcessAmount";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.processAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.processAmountDataGridViewTextBoxColumn.HeaderText = "脱硫量[T]";
            this.processAmountDataGridViewTextBoxColumn.Name = "processAmountDataGridViewTextBoxColumn";
            this.processAmountDataGridViewTextBoxColumn.Width = 84;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
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
            this.dsLance.AutoSubscribe = true;
            this.dsLance.DataSetName = "L3DataSet";
            this.dsLance.DeleteMethod = "";
            this.dsLance.InsertMethod = "";
            this.dsLance.L3DataAdapter = this.Adapter;
            this.dsLance.LoadEvent = "";
            this.dsLance.LoadTrigger = null;
            this.dsLance.RefreshValve = 1000;
            this.dsLance.SourceCommand = null;
            this.dsLance.SourceCondition = " Status<5 order by LANCENO DESC";
            this.dsLance.SourceMethod = "";
            this.dsLance.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLance.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Lance_Data";
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
            this.coldsLanceL3DataTableOpTime});
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
            // coldsLanceL3DataTableOpTime
            // 
            this.coldsLanceL3DataTableOpTime.Caption = "OpTime";
            this.coldsLanceL3DataTableOpTime.ColumnName = "OpTime";
            this.coldsLanceL3DataTableOpTime.DataType = typeof(System.DateTime);
            this.coldsLanceL3DataTableOpTime.Namespace = "";
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
            this.btnDataModify});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(816, 25);
            this.bdN1.TabIndex = 63;
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
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LanceAge";
            this.dataGridViewTextBoxColumn3.HeaderText = "枪龄";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            this.dataGridViewTextBoxColumn5.HeaderText = "处理时间";
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
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn7.HeaderText = "备注";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 54;
            // 
            // LanceMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 401);
            this.Controls.Add(this.dvLance);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LanceMagFrm";
            this.TabText = "喷枪管理";
            this.Text = "喷枪管理";
            this.Shown += new System.EventHandler(this.LanceMagFrm_Shown);
            this.Load += new System.EventHandler(this.LanceMagFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnConfirm;
        private System.Windows.Forms.ToolStripButton tsbtnCancel;
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
        private AppSvrHMI.L3Adapter Adapter;
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
        private System.Windows.Forms.BindingSource bsLance;
        private System.Windows.Forms.ToolStripButton btnChangeStatus;
        private System.Windows.Forms.ToolStripButton btnChangeAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Val_Long;
        private AppSvrHMI.L3DataSet dsVendor;
        private System.Data.DataTable schemadsVendor;
        private System.Data.DataColumn coldsVendorL3DataTableCode;
        private System.Data.DataColumn coldsVendorL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnLanceQuery;
        private System.Windows.Forms.ToolStripButton btnIntoEXL;
        private System.Windows.Forms.ToolStripButton tlDeSLanceDataAdd;
        private System.Data.DataColumn coldsLanceL3DataTableOpTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private DataGridValid.CalendarColumn OpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn lanceVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}