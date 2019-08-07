namespace BaseDataMag
{
    partial class UnitConsumeMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitConsumeMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.btnIncludeExcel = new System.Windows.Forms.ToolStripButton();
            this.bsUnitConsume = new System.Windows.Forms.BindingSource(this.components);
            this.dsUnitConsume = new AppSvrHMI.L3DataSet();
            this.schemadsMatPrice = new System.Data.DataTable();
            this.coldsMatPriceL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatPriceL3DataTableNAME = new System.Data.DataColumn();
            this.coldsUnitPriceL3DataTableEle_Code = new System.Data.DataColumn();
            this.coldsUnitPriceL3DataTableEle_Des = new System.Data.DataColumn();
            this.coldsUnitConsumeL3DataTableSteelType = new System.Data.DataColumn();
            this.coldsUnitConsumeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.coldsUnitConsumeL3DataTableUnit_Consume = new System.Data.DataColumn();
            this.coldsUnitConsumeL3DataTableCheckFlag = new System.Data.DataColumn();
            this.cmdpMatPrice = new AppSvrHMI.L3CommandParameter();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvUnitConsume = new System.Windows.Forms.DataGridView();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ele_Code = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsUnitCode = new AppSvrHMI.L3DataSet();
            this.schemadsMatCode = new System.Data.DataTable();
            this.coldsMatCodeL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableName = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Str = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Val_Double = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableNC_Code = new System.Data.DataColumn();
            this.Ele_Des = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.steelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.steelGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelGrade = new AppSvrHMI.L3DataSet();
            this.schemadsSteelGrade = new System.Data.DataTable();
            this.coldsSteelGradeL3DataTableSteelGrade = new System.Data.DataColumn();
            this.unitConsumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsSelectAll = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatPrice)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvUnitConsume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).BeginInit();
            this.cmsSelectAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator5,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut,
            this.btnIncludeExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 43);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // btnIncludeExcel
            // 
            this.btnIncludeExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnIncludeExcel.Image")));
            this.btnIncludeExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncludeExcel.Name = "btnIncludeExcel";
            this.btnIncludeExcel.Size = new System.Drawing.Size(95, 40);
            this.btnIncludeExcel.Text = "导入Excel";
            this.btnIncludeExcel.Click += new System.EventHandler(this.btnIncludeExcel_Click);
            // 
            // bsUnitConsume
            // 
            this.bsUnitConsume.DataMember = "L3DataTable";
            this.bsUnitConsume.DataSource = this.dsUnitConsume;
            // 
            // dsUnitConsume
            // 
            this.dsUnitConsume.AutoLoad = true;
            this.dsUnitConsume.AutoSubscribe = false;
            this.dsUnitConsume.DataSetName = "L3DataSet";
            this.dsUnitConsume.DeleteMethod = "";
            this.dsUnitConsume.InsertMethod = "";
            this.dsUnitConsume.L3DataAdapter = this.Adapter;
            this.dsUnitConsume.LoadEvent = "";
            this.dsUnitConsume.LoadTrigger = null;
            this.dsUnitConsume.RefreshValve = 1000;
            this.dsUnitConsume.SourceCommand = null;
            this.dsUnitConsume.SourceCondition = "";
            this.dsUnitConsume.SourceMethod = "";
            this.dsUnitConsume.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnitConsume.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Unit_Consume";
            this.dsUnitConsume.SubscribeTarget = "";
            this.dsUnitConsume.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatPrice});
            this.dsUnitConsume.UpdateEvent = "";
            this.dsUnitConsume.UpdateMethod = "";
            this.dsUnitConsume.UpdateTrigger = null;
            // 
            // schemadsMatPrice
            // 
            this.schemadsMatPrice.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatPriceL3DataTableGUID,
            this.coldsMatPriceL3DataTableNAME,
            this.coldsUnitPriceL3DataTableEle_Code,
            this.coldsUnitPriceL3DataTableEle_Des,
            this.coldsUnitConsumeL3DataTableSteelType,
            this.coldsUnitConsumeL3DataTableSteelGrade,
            this.coldsUnitConsumeL3DataTableUnit_Consume,
            this.coldsUnitConsumeL3DataTableCheckFlag});
            this.schemadsMatPrice.TableName = "L3DataTable";
            // 
            // coldsMatPriceL3DataTableGUID
            // 
            this.coldsMatPriceL3DataTableGUID.Caption = "GUID";
            this.coldsMatPriceL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatPriceL3DataTableGUID.Namespace = "";
            // 
            // coldsMatPriceL3DataTableNAME
            // 
            this.coldsMatPriceL3DataTableNAME.Caption = "Name";
            this.coldsMatPriceL3DataTableNAME.ColumnName = "NAME";
            this.coldsMatPriceL3DataTableNAME.Namespace = "";
            // 
            // coldsUnitPriceL3DataTableEle_Code
            // 
            this.coldsUnitPriceL3DataTableEle_Code.Caption = "Ele_Code";
            this.coldsUnitPriceL3DataTableEle_Code.ColumnName = "Ele_Code";
            this.coldsUnitPriceL3DataTableEle_Code.Namespace = "";
            // 
            // coldsUnitPriceL3DataTableEle_Des
            // 
            this.coldsUnitPriceL3DataTableEle_Des.Caption = "Ele_Des";
            this.coldsUnitPriceL3DataTableEle_Des.ColumnName = "Ele_Des";
            this.coldsUnitPriceL3DataTableEle_Des.Namespace = "";
            // 
            // coldsUnitConsumeL3DataTableSteelType
            // 
            this.coldsUnitConsumeL3DataTableSteelType.Caption = "SteelType";
            this.coldsUnitConsumeL3DataTableSteelType.ColumnName = "SteelType";
            this.coldsUnitConsumeL3DataTableSteelType.Namespace = "";
            // 
            // coldsUnitConsumeL3DataTableSteelGrade
            // 
            this.coldsUnitConsumeL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsUnitConsumeL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsUnitConsumeL3DataTableSteelGrade.Namespace = "";
            // 
            // coldsUnitConsumeL3DataTableUnit_Consume
            // 
            this.coldsUnitConsumeL3DataTableUnit_Consume.Caption = "Unit_Consume";
            this.coldsUnitConsumeL3DataTableUnit_Consume.ColumnName = "Unit_Consume";
            this.coldsUnitConsumeL3DataTableUnit_Consume.DataType = typeof(float);
            this.coldsUnitConsumeL3DataTableUnit_Consume.Namespace = "";
            // 
            // coldsUnitConsumeL3DataTableCheckFlag
            // 
            this.coldsUnitConsumeL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsUnitConsumeL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsUnitConsumeL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsUnitConsumeL3DataTableCheckFlag.Namespace = "";
            // 
            // cmdpMatPrice
            // 
            this.cmdpMatPrice.AcceptAfterExecuted = false;
            this.cmdpMatPrice.ConstantValue = null;
            this.cmdpMatPrice.MergeTarget = false;
            this.cmdpMatPrice.SourceFilter = null;
            this.cmdpMatPrice.SourceObject = null;
            this.cmdpMatPrice.SourceProperty = null;
            this.cmdpMatPrice.TargetObject = null;
            this.cmdpMatPrice.TargetProperty = null;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvUnitConsume);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 657);
            this.hmiRootPanel1.TabIndex = 26;
            // 
            // dvUnitConsume
            // 
            this.dvUnitConsume.AllowUserToAddRows = false;
            this.dvUnitConsume.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvUnitConsume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvUnitConsume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvUnitConsume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.Ele_Code,
            this.Ele_Des,
            this.steelTypeDataGridViewTextBoxColumn,
            this.steelGradeDataGridViewTextBoxColumn,
            this.unitConsumeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dvUnitConsume.ContextMenuStrip = this.cmsSelectAll;
            this.dvUnitConsume.DataSource = this.bsUnitConsume;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvUnitConsume.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvUnitConsume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvUnitConsume.Location = new System.Drawing.Point(0, 0);
            this.dvUnitConsume.Name = "dvUnitConsume";
            this.dvUnitConsume.RowTemplate.Height = 23;
            this.dvUnitConsume.Size = new System.Drawing.Size(1000, 657);
            this.dvUnitConsume.TabIndex = 0;
            this.dvUnitConsume.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvMatPrice_CurrentCellDirtyStateChanged);
            this.dvUnitConsume.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMatPrice_DataError);
            // 
            // CheckFlag
            // 
            this.CheckFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Width = 54;
            // 
            // Ele_Code
            // 
            this.Ele_Code.DataPropertyName = "Ele_Code";
            this.Ele_Code.DataSource = this.dsUnitCode;
            this.Ele_Code.DisplayMember = "L3DataTable.Code";
            this.Ele_Code.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Ele_Code.HeaderText = "合金编码";
            this.Ele_Code.Name = "Ele_Code";
            this.Ele_Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ele_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ele_Code.ValueMember = "L3DataTable.Code";
            // 
            // dsUnitCode
            // 
            this.dsUnitCode.AutoLoad = true;
            this.dsUnitCode.AutoSubscribe = false;
            this.dsUnitCode.DataSetName = "L3DataSet";
            this.dsUnitCode.DeleteMethod = "";
            this.dsUnitCode.InsertMethod = "";
            this.dsUnitCode.L3DataAdapter = this.Adapter;
            this.dsUnitCode.LoadEvent = "";
            this.dsUnitCode.LoadTrigger = null;
            this.dsUnitCode.RefreshValve = 1000;
            this.dsUnitCode.SourceCommand = null;
            this.dsUnitCode.SourceCondition = "";
            this.dsUnitCode.SourceMethod = "";
            this.dsUnitCode.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsUnitCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnitCode.SubscribeTarget = "";
            this.dsUnitCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatCode});
            this.dsUnitCode.UpdateEvent = "";
            this.dsUnitCode.UpdateMethod = "";
            this.dsUnitCode.UpdateTrigger = null;
            // 
            // schemadsMatCode
            // 
            this.schemadsMatCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatCodeL3DataTableGUID,
            this.coldsMatCodeL3DataTableName,
            this.coldsMatCodeL3DataTableCode,
            this.coldsMatCodeL3DataTableCode_Des,
            this.coldsMatCodeL3DataTableCode_Group,
            this.coldsMatCodeL3DataTableCode_Group_Des,
            this.coldsMatCodeL3DataTableCode_Val_Str,
            this.coldsMatCodeL3DataTableCode_Val_Long,
            this.coldsMatCodeL3DataTableCode_Val_Double,
            this.coldsMatCodeL3DataTableNC_Code});
            this.schemadsMatCode.TableName = "L3DataTable";
            // 
            // coldsMatCodeL3DataTableGUID
            // 
            this.coldsMatCodeL3DataTableGUID.Caption = "GUID";
            this.coldsMatCodeL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatCodeL3DataTableGUID.Namespace = "";
            // 
            // coldsMatCodeL3DataTableName
            // 
            this.coldsMatCodeL3DataTableName.Caption = "Name";
            this.coldsMatCodeL3DataTableName.ColumnName = "Name";
            this.coldsMatCodeL3DataTableName.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode
            // 
            this.coldsMatCodeL3DataTableCode.Caption = "Code";
            this.coldsMatCodeL3DataTableCode.ColumnName = "Code";
            this.coldsMatCodeL3DataTableCode.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Des
            // 
            this.coldsMatCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Group
            // 
            this.coldsMatCodeL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsMatCodeL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsMatCodeL3DataTableCode_Group.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Group_Des
            // 
            this.coldsMatCodeL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsMatCodeL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsMatCodeL3DataTableCode_Group_Des.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Str
            // 
            this.coldsMatCodeL3DataTableCode_Val_Str.Caption = "Code_Val_Str";
            this.coldsMatCodeL3DataTableCode_Val_Str.ColumnName = "Code_Val_Str";
            this.coldsMatCodeL3DataTableCode_Val_Str.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Long
            // 
            this.coldsMatCodeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsMatCodeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsMatCodeL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsMatCodeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Val_Double
            // 
            this.coldsMatCodeL3DataTableCode_Val_Double.Caption = "Code_Val_Double";
            this.coldsMatCodeL3DataTableCode_Val_Double.ColumnName = "Code_Val_Double";
            this.coldsMatCodeL3DataTableCode_Val_Double.DataType = typeof(double);
            this.coldsMatCodeL3DataTableCode_Val_Double.Namespace = "";
            // 
            // coldsMatCodeL3DataTableNC_Code
            // 
            this.coldsMatCodeL3DataTableNC_Code.Caption = "NC_Code";
            this.coldsMatCodeL3DataTableNC_Code.ColumnName = "NC_Code";
            this.coldsMatCodeL3DataTableNC_Code.Namespace = "";
            // 
            // Ele_Des
            // 
            this.Ele_Des.DataPropertyName = "Ele_Des";
            this.Ele_Des.DataSource = this.dsUnitCode;
            this.Ele_Des.DisplayMember = "L3DataTable.Code_Des";
            this.Ele_Des.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Ele_Des.HeaderText = "合金名称";
            this.Ele_Des.Name = "Ele_Des";
            this.Ele_Des.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ele_Des.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ele_Des.ValueMember = "L3DataTable.Code";
            // 
            // steelTypeDataGridViewTextBoxColumn
            // 
            this.steelTypeDataGridViewTextBoxColumn.DataPropertyName = "SteelType";
            this.steelTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.steelTypeDataGridViewTextBoxColumn.HeaderText = "类别";
            this.steelTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "F",
            "J",
            "P"});
            this.steelTypeDataGridViewTextBoxColumn.Name = "steelTypeDataGridViewTextBoxColumn";
            this.steelTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.steelTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // steelGradeDataGridViewTextBoxColumn
            // 
            this.steelGradeDataGridViewTextBoxColumn.DataPropertyName = "SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.DataSource = this.dsSteelGrade;
            this.steelGradeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.SteelGrade";
            this.steelGradeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.steelGradeDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.steelGradeDataGridViewTextBoxColumn.Name = "steelGradeDataGridViewTextBoxColumn";
            this.steelGradeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.steelGradeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.steelGradeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.SteelGrade";
            // 
            // dsSteelGrade
            // 
            this.dsSteelGrade.AutoLoad = true;
            this.dsSteelGrade.AutoSubscribe = false;
            this.dsSteelGrade.DataSetName = "L3DataSet";
            this.dsSteelGrade.DeleteMethod = "";
            this.dsSteelGrade.InsertMethod = "";
            this.dsSteelGrade.L3DataAdapter = this.Adapter;
            this.dsSteelGrade.LoadEvent = "";
            this.dsSteelGrade.LoadTrigger = null;
            this.dsSteelGrade.RefreshValve = 1000;
            this.dsSteelGrade.SourceCommand = null;
            this.dsSteelGrade.SourceCondition = "";
            this.dsSteelGrade.SourceMethod = "";
            this.dsSteelGrade.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsSteelGrade.SourceURI = "";
            this.dsSteelGrade.SubscribeTarget = "";
            this.dsSteelGrade.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelGrade});
            this.dsSteelGrade.UpdateEvent = "";
            this.dsSteelGrade.UpdateMethod = "";
            this.dsSteelGrade.UpdateTrigger = null;
            // 
            // schemadsSteelGrade
            // 
            this.schemadsSteelGrade.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelGradeL3DataTableSteelGrade});
            this.schemadsSteelGrade.TableName = "L3DataTable";
            // 
            // coldsSteelGradeL3DataTableSteelGrade
            // 
            this.coldsSteelGradeL3DataTableSteelGrade.Caption = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.ColumnName = "SteelGrade";
            this.coldsSteelGradeL3DataTableSteelGrade.Namespace = "";
            // 
            // unitConsumeDataGridViewTextBoxColumn
            // 
            this.unitConsumeDataGridViewTextBoxColumn.DataPropertyName = "Unit_Consume";
            this.unitConsumeDataGridViewTextBoxColumn.HeaderText = "合金单耗";
            this.unitConsumeDataGridViewTextBoxColumn.Name = "unitConsumeDataGridViewTextBoxColumn";
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmsSelectAll
            // 
            this.cmsSelectAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全选ToolStripMenuItem});
            this.cmsSelectAll.Name = "cmsSelectAll";
            this.cmsSelectAll.Size = new System.Drawing.Size(95, 26);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ele_Code";
            this.dataGridViewTextBoxColumn1.HeaderText = "合金编码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ele_Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "合金单价";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GUID";
            this.dataGridViewTextBoxColumn3.HeaderText = "GUID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NAME";
            this.dataGridViewTextBoxColumn4.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // UnitConsumeMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnitConsumeMagFrm";
            this.TabText = "合金计划单耗管理";
            this.Text = "合金计划单耗管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnitConsumeMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.UnitConsumeMagFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatPrice)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvUnitConsume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelGrade)).EndInit();
            this.cmsSelectAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvUnitConsume;
        private AppSvrHMI.L3DataSet dsUnitConsume;
        private AppSvrHMI.L3CommandParameter cmdpMatPrice;
        private System.Data.DataTable schemadsMatPrice;
        private System.Data.DataColumn coldsMatPriceL3DataTableGUID;
        private System.Data.DataColumn coldsMatPriceL3DataTableNAME;
        private System.Windows.Forms.BindingSource bsUnitConsume;
        private AppSvrHMI.L3DataSet dsUnitCode;
        private System.Data.DataTable schemadsMatCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableGUID;
        private System.Data.DataColumn coldsMatCodeL3DataTableName;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Des;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Group;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Group_Des;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Str;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Long;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Val_Double;
        private System.Data.DataColumn coldsMatCodeL3DataTableNC_Code;
        private System.Windows.Forms.ToolStripButton btnIncludeExcel;
        private System.Windows.Forms.ContextMenuStrip cmsSelectAll;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Data.DataColumn coldsUnitPriceL3DataTableEle_Code;
        private System.Data.DataColumn coldsUnitPriceL3DataTableEle_Des;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Data.DataColumn coldsUnitConsumeL3DataTableSteelType;
        private System.Data.DataColumn coldsUnitConsumeL3DataTableSteelGrade;
        private System.Data.DataColumn coldsUnitConsumeL3DataTableUnit_Consume;
        private AppSvrHMI.L3DataSet dsSteelGrade;
        private System.Data.DataTable schemadsSteelGrade;
        private System.Data.DataColumn coldsSteelGradeL3DataTableSteelGrade;
        private System.Data.DataColumn coldsUnitConsumeL3DataTableCheckFlag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ele_Code;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ele_Des;
        private System.Windows.Forms.DataGridViewComboBoxColumn steelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn steelGradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitConsumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
    }
}