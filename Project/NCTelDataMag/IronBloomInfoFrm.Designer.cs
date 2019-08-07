namespace NCTelDataMag
{
    partial class IronBloomInfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronBloomInfoFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateSend = new System.Windows.Forms.ToolStripButton();
            this.btnAddSend = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvMaterial = new System.Windows.Forms.DataGridView();
            this.wlbmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMaterialID = new AppSvrHMI.L3DataSet();
            this.schemadsMaterialID = new System.Data.DataTable();
            this.coldsMaterialIDL3DataTablePk_Material_Bas = new System.Data.DataColumn();
            this.coldsMaterialIDL3DataTableMaterial_Name = new System.Data.DataColumn();
            this.jldwidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gzzxidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWorkCenter = new AppSvrHMI.L3DataSet();
            this.schemadsWorkCenter = new System.Data.DataTable();
            this.coldsWorkCenterL3DataTableCenter_Code = new System.Data.DataColumn();
            this.coldsWorkCenterL3DataTablePk_Center = new System.Data.DataColumn();
            this.ccxhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gxhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkproduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jsrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fhgslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sflfcpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sffsgpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkcorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterial = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial = new System.Data.DataTable();
            this.coldsMaterialL3DataTablepk_produce = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegcbm = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablewlbmid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablejldwid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegzzxid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccxh = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegxh = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableksrq = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablekssj = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablejsrq = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablejssj = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablehgsl = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefhgsl = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablesflfcp = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablesffsgp = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefreeitemvalue1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefreeitemvalue2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefreeitemvalue3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefreeitemvalue4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefreeitemvalue5 = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCConfirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTablepch = new System.Data.DataColumn();
            this.coldsMainL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsMainL3DataTablezdrid = new System.Data.DataColumn();
            this.coldsMainL3DataTablerq = new System.Data.DataColumn();
            this.coldsMainL3DataTablesj = new System.Data.DataColumn();
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txbHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
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
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.tSp1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWorkCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLog)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnUpdateSend,
            this.btnAddSend});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(552, 43);
            this.tSp1.TabIndex = 35;
            this.tSp1.Text = "toolStrip1";
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
            // btnUpdateSend
            // 
            this.btnUpdateSend.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSend.Image")));
            this.btnUpdateSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateSend.Name = "btnUpdateSend";
            this.btnUpdateSend.Size = new System.Drawing.Size(125, 40);
            this.btnUpdateSend.Text = "Update类型补发";
            this.btnUpdateSend.Click += new System.EventHandler(this.btnUpdateSend_Click);
            // 
            // btnAddSend
            // 
            this.btnAddSend.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSend.Image")));
            this.btnAddSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSend.Name = "btnAddSend";
            this.btnAddSend.Size = new System.Drawing.Size(107, 40);
            this.btnAddSend.Text = "Add类型补发";
            this.btnAddSend.Click += new System.EventHandler(this.btnAddSend_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bnM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 267);
            this.panel1.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvMaterial);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 148);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表体1数据";
            // 
            // dvMaterial
            // 
            this.dvMaterial.AllowUserToAddRows = false;
            this.dvMaterial.AutoGenerateColumns = false;
            this.dvMaterial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMaterial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMaterial.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wlbmidDataGridViewTextBoxColumn,
            this.jldwidDataGridViewTextBoxColumn,
            this.gzzxidDataGridViewTextBoxColumn,
            this.ccxhDataGridViewTextBoxColumn,
            this.gxhDataGridViewTextBoxColumn,
            this.pkproduceDataGridViewTextBoxColumn,
            this.ksrqDataGridViewTextBoxColumn,
            this.kssjDataGridViewTextBoxColumn,
            this.jsrqDataGridViewTextBoxColumn,
            this.jssjDataGridViewTextBoxColumn,
            this.hgslDataGridViewTextBoxColumn,
            this.fhgslDataGridViewTextBoxColumn,
            this.sflfcpDataGridViewTextBoxColumn,
            this.sffsgpDataGridViewTextBoxColumn,
            this.zdy1DataGridViewTextBoxColumn,
            this.zdy2DataGridViewTextBoxColumn,
            this.zdy3DataGridViewTextBoxColumn,
            this.zdy4DataGridViewTextBoxColumn,
            this.zdy5DataGridViewTextBoxColumn,
            this.freeitemvalue1DataGridViewTextBoxColumn,
            this.freeitemvalue2DataGridViewTextBoxColumn,
            this.freeitemvalue3DataGridViewTextBoxColumn,
            this.freeitemvalue4DataGridViewTextBoxColumn,
            this.freeitemvalue5DataGridViewTextBoxColumn,
            this.pkcorpDataGridViewTextBoxColumn,
            this.gcbmDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn});
            this.dvMaterial.DataSource = this.bsMaterial;
            this.dvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMaterial.Location = new System.Drawing.Point(3, 17);
            this.dvMaterial.Name = "dvMaterial";
            this.dvMaterial.ReadOnly = true;
            this.dvMaterial.RowTemplate.Height = 23;
            this.dvMaterial.Size = new System.Drawing.Size(546, 128);
            this.dvMaterial.TabIndex = 0;
            this.dvMaterial.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
            // 
            // wlbmidDataGridViewTextBoxColumn
            // 
            this.wlbmidDataGridViewTextBoxColumn.DataPropertyName = "wlbmid";
            this.wlbmidDataGridViewTextBoxColumn.DataSource = this.dsMaterialID;
            this.wlbmidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Material_Name";
            this.wlbmidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wlbmidDataGridViewTextBoxColumn.HeaderText = "物料编码id";
            this.wlbmidDataGridViewTextBoxColumn.Name = "wlbmidDataGridViewTextBoxColumn";
            this.wlbmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.wlbmidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wlbmidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wlbmidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Material_Bas";
            this.wlbmidDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsMaterialID
            // 
            this.dsMaterialID.AutoSubscribe = false;
            this.dsMaterialID.DataSetName = "L3DataSet";
            this.dsMaterialID.DeleteMethod = "";
            this.dsMaterialID.InsertMethod = "";
            this.dsMaterialID.L3DataAdapter = this.Adapter;
            this.dsMaterialID.LoadEvent = "";
            this.dsMaterialID.LoadTrigger = null;
            this.dsMaterialID.RefreshValve = 1000;
            this.dsMaterialID.SourceCommand = null;
            this.dsMaterialID.SourceCondition = " SUBSTR (material_code, 1, 1) = \'1\'  OR SUBSTR (material_code, 1, 1) = \'5\'  OR SU" +
                "BSTR (material_code, 1, 1) = \'6\'";
            this.dsMaterialID.SourceMethod = "";
            this.dsMaterialID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMaterialID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Material_Base_Infor";
            this.dsMaterialID.SubscribeTarget = "";
            this.dsMaterialID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterialID});
            this.dsMaterialID.UpdateEvent = "";
            this.dsMaterialID.UpdateMethod = "";
            this.dsMaterialID.UpdateTrigger = null;
            // 
            // schemadsMaterialID
            // 
            this.schemadsMaterialID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterialIDL3DataTablePk_Material_Bas,
            this.coldsMaterialIDL3DataTableMaterial_Name});
            this.schemadsMaterialID.TableName = "L3DataTable";
            // 
            // coldsMaterialIDL3DataTablePk_Material_Bas
            // 
            this.coldsMaterialIDL3DataTablePk_Material_Bas.Caption = "Pk_Material_Bas";
            this.coldsMaterialIDL3DataTablePk_Material_Bas.ColumnName = "Pk_Material_Bas";
            this.coldsMaterialIDL3DataTablePk_Material_Bas.Namespace = "";
            // 
            // coldsMaterialIDL3DataTableMaterial_Name
            // 
            this.coldsMaterialIDL3DataTableMaterial_Name.Caption = "Material_Name";
            this.coldsMaterialIDL3DataTableMaterial_Name.ColumnName = "Material_Name";
            this.coldsMaterialIDL3DataTableMaterial_Name.Namespace = "";
            // 
            // jldwidDataGridViewTextBoxColumn
            // 
            this.jldwidDataGridViewTextBoxColumn.DataPropertyName = "jldwid";
            this.jldwidDataGridViewTextBoxColumn.HeaderText = "计量单位id";
            this.jldwidDataGridViewTextBoxColumn.Name = "jldwidDataGridViewTextBoxColumn";
            this.jldwidDataGridViewTextBoxColumn.ReadOnly = true;
            this.jldwidDataGridViewTextBoxColumn.Width = 72;
            // 
            // gzzxidDataGridViewTextBoxColumn
            // 
            this.gzzxidDataGridViewTextBoxColumn.DataPropertyName = "gzzxid";
            this.gzzxidDataGridViewTextBoxColumn.DataSource = this.dsWorkCenter;
            this.gzzxidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Center_Code";
            this.gzzxidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.gzzxidDataGridViewTextBoxColumn.HeaderText = "工作中心id";
            this.gzzxidDataGridViewTextBoxColumn.Name = "gzzxidDataGridViewTextBoxColumn";
            this.gzzxidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gzzxidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gzzxidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gzzxidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Center";
            this.gzzxidDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsWorkCenter
            // 
            this.dsWorkCenter.AutoSubscribe = false;
            this.dsWorkCenter.DataSetName = "L3DataSet";
            this.dsWorkCenter.DeleteMethod = "";
            this.dsWorkCenter.InsertMethod = "";
            this.dsWorkCenter.L3DataAdapter = this.Adapter;
            this.dsWorkCenter.LoadEvent = "";
            this.dsWorkCenter.LoadTrigger = null;
            this.dsWorkCenter.RefreshValve = 1000;
            this.dsWorkCenter.SourceCommand = null;
            this.dsWorkCenter.SourceCondition = "";
            this.dsWorkCenter.SourceMethod = "";
            this.dsWorkCenter.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWorkCenter.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Prod_Center_Infor";
            this.dsWorkCenter.SubscribeTarget = "";
            this.dsWorkCenter.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWorkCenter});
            this.dsWorkCenter.UpdateEvent = "";
            this.dsWorkCenter.UpdateMethod = "";
            this.dsWorkCenter.UpdateTrigger = null;
            // 
            // schemadsWorkCenter
            // 
            this.schemadsWorkCenter.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWorkCenterL3DataTableCenter_Code,
            this.coldsWorkCenterL3DataTablePk_Center});
            this.schemadsWorkCenter.TableName = "L3DataTable";
            // 
            // coldsWorkCenterL3DataTableCenter_Code
            // 
            this.coldsWorkCenterL3DataTableCenter_Code.Caption = "Center_Code";
            this.coldsWorkCenterL3DataTableCenter_Code.ColumnName = "Center_Code";
            this.coldsWorkCenterL3DataTableCenter_Code.Namespace = "";
            // 
            // coldsWorkCenterL3DataTablePk_Center
            // 
            this.coldsWorkCenterL3DataTablePk_Center.Caption = "Pk_Center";
            this.coldsWorkCenterL3DataTablePk_Center.ColumnName = "Pk_Center";
            this.coldsWorkCenterL3DataTablePk_Center.Namespace = "";
            // 
            // ccxhDataGridViewTextBoxColumn
            // 
            this.ccxhDataGridViewTextBoxColumn.DataPropertyName = "ccxh";
            this.ccxhDataGridViewTextBoxColumn.HeaderText = "产出序号";
            this.ccxhDataGridViewTextBoxColumn.Name = "ccxhDataGridViewTextBoxColumn";
            this.ccxhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccxhDataGridViewTextBoxColumn.Width = 61;
            // 
            // gxhDataGridViewTextBoxColumn
            // 
            this.gxhDataGridViewTextBoxColumn.DataPropertyName = "gxh";
            this.gxhDataGridViewTextBoxColumn.HeaderText = "工序号";
            this.gxhDataGridViewTextBoxColumn.Name = "gxhDataGridViewTextBoxColumn";
            this.gxhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gxhDataGridViewTextBoxColumn.Width = 61;
            // 
            // pkproduceDataGridViewTextBoxColumn
            // 
            this.pkproduceDataGridViewTextBoxColumn.DataPropertyName = "pk_produce";
            this.pkproduceDataGridViewTextBoxColumn.HeaderText = "完工产品";
            this.pkproduceDataGridViewTextBoxColumn.Name = "pkproduceDataGridViewTextBoxColumn";
            this.pkproduceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkproduceDataGridViewTextBoxColumn.Width = 61;
            // 
            // ksrqDataGridViewTextBoxColumn
            // 
            this.ksrqDataGridViewTextBoxColumn.DataPropertyName = "ksrq";
            this.ksrqDataGridViewTextBoxColumn.HeaderText = "开始日期";
            this.ksrqDataGridViewTextBoxColumn.Name = "ksrqDataGridViewTextBoxColumn";
            this.ksrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.ksrqDataGridViewTextBoxColumn.Width = 61;
            // 
            // kssjDataGridViewTextBoxColumn
            // 
            this.kssjDataGridViewTextBoxColumn.DataPropertyName = "kssj";
            this.kssjDataGridViewTextBoxColumn.HeaderText = "开始时间";
            this.kssjDataGridViewTextBoxColumn.Name = "kssjDataGridViewTextBoxColumn";
            this.kssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.kssjDataGridViewTextBoxColumn.Width = 61;
            // 
            // jsrqDataGridViewTextBoxColumn
            // 
            this.jsrqDataGridViewTextBoxColumn.DataPropertyName = "jsrq";
            this.jsrqDataGridViewTextBoxColumn.HeaderText = "结束日期";
            this.jsrqDataGridViewTextBoxColumn.Name = "jsrqDataGridViewTextBoxColumn";
            this.jsrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.jsrqDataGridViewTextBoxColumn.Width = 61;
            // 
            // jssjDataGridViewTextBoxColumn
            // 
            this.jssjDataGridViewTextBoxColumn.DataPropertyName = "jssj";
            this.jssjDataGridViewTextBoxColumn.HeaderText = "结束时间";
            this.jssjDataGridViewTextBoxColumn.Name = "jssjDataGridViewTextBoxColumn";
            this.jssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.jssjDataGridViewTextBoxColumn.Width = 61;
            // 
            // hgslDataGridViewTextBoxColumn
            // 
            this.hgslDataGridViewTextBoxColumn.DataPropertyName = "hgsl";
            this.hgslDataGridViewTextBoxColumn.HeaderText = "实际完工数量";
            this.hgslDataGridViewTextBoxColumn.Name = "hgslDataGridViewTextBoxColumn";
            this.hgslDataGridViewTextBoxColumn.ReadOnly = true;
            this.hgslDataGridViewTextBoxColumn.Width = 72;
            // 
            // fhgslDataGridViewTextBoxColumn
            // 
            this.fhgslDataGridViewTextBoxColumn.DataPropertyName = "fhgsl";
            this.fhgslDataGridViewTextBoxColumn.HeaderText = "实际完工辅数量";
            this.fhgslDataGridViewTextBoxColumn.Name = "fhgslDataGridViewTextBoxColumn";
            this.fhgslDataGridViewTextBoxColumn.ReadOnly = true;
            this.fhgslDataGridViewTextBoxColumn.Width = 83;
            // 
            // sflfcpDataGridViewTextBoxColumn
            // 
            this.sflfcpDataGridViewTextBoxColumn.DataPropertyName = "sflfcp";
            this.sflfcpDataGridViewTextBoxColumn.HeaderText = "是否联副产品";
            this.sflfcpDataGridViewTextBoxColumn.Name = "sflfcpDataGridViewTextBoxColumn";
            this.sflfcpDataGridViewTextBoxColumn.ReadOnly = true;
            this.sflfcpDataGridViewTextBoxColumn.Width = 72;
            // 
            // sffsgpDataGridViewTextBoxColumn
            // 
            this.sffsgpDataGridViewTextBoxColumn.DataPropertyName = "sffsgp";
            this.sffsgpDataGridViewTextBoxColumn.HeaderText = "是否改判";
            this.sffsgpDataGridViewTextBoxColumn.Name = "sffsgpDataGridViewTextBoxColumn";
            this.sffsgpDataGridViewTextBoxColumn.ReadOnly = true;
            this.sffsgpDataGridViewTextBoxColumn.Width = 61;
            // 
            // zdy1DataGridViewTextBoxColumn
            // 
            this.zdy1DataGridViewTextBoxColumn.DataPropertyName = "zdy1";
            this.zdy1DataGridViewTextBoxColumn.HeaderText = "自定义";
            this.zdy1DataGridViewTextBoxColumn.Name = "zdy1DataGridViewTextBoxColumn";
            this.zdy1DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy1DataGridViewTextBoxColumn.Width = 61;
            // 
            // zdy2DataGridViewTextBoxColumn
            // 
            this.zdy2DataGridViewTextBoxColumn.DataPropertyName = "zdy2";
            this.zdy2DataGridViewTextBoxColumn.HeaderText = "自定义2";
            this.zdy2DataGridViewTextBoxColumn.Name = "zdy2DataGridViewTextBoxColumn";
            this.zdy2DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy2DataGridViewTextBoxColumn.Width = 61;
            // 
            // zdy3DataGridViewTextBoxColumn
            // 
            this.zdy3DataGridViewTextBoxColumn.DataPropertyName = "zdy3";
            this.zdy3DataGridViewTextBoxColumn.HeaderText = "自定义3";
            this.zdy3DataGridViewTextBoxColumn.Name = "zdy3DataGridViewTextBoxColumn";
            this.zdy3DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy3DataGridViewTextBoxColumn.Width = 61;
            // 
            // zdy4DataGridViewTextBoxColumn
            // 
            this.zdy4DataGridViewTextBoxColumn.DataPropertyName = "zdy4";
            this.zdy4DataGridViewTextBoxColumn.HeaderText = "自定义4";
            this.zdy4DataGridViewTextBoxColumn.Name = "zdy4DataGridViewTextBoxColumn";
            this.zdy4DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy4DataGridViewTextBoxColumn.Width = 61;
            // 
            // zdy5DataGridViewTextBoxColumn
            // 
            this.zdy5DataGridViewTextBoxColumn.DataPropertyName = "zdy5";
            this.zdy5DataGridViewTextBoxColumn.HeaderText = "自定义5";
            this.zdy5DataGridViewTextBoxColumn.Name = "zdy5DataGridViewTextBoxColumn";
            this.zdy5DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy5DataGridViewTextBoxColumn.Width = 61;
            // 
            // freeitemvalue1DataGridViewTextBoxColumn
            // 
            this.freeitemvalue1DataGridViewTextBoxColumn.DataPropertyName = "freeitemvalue1";
            this.freeitemvalue1DataGridViewTextBoxColumn.HeaderText = "自由项1";
            this.freeitemvalue1DataGridViewTextBoxColumn.Name = "freeitemvalue1DataGridViewTextBoxColumn";
            this.freeitemvalue1DataGridViewTextBoxColumn.ReadOnly = true;
            this.freeitemvalue1DataGridViewTextBoxColumn.Width = 61;
            // 
            // freeitemvalue2DataGridViewTextBoxColumn
            // 
            this.freeitemvalue2DataGridViewTextBoxColumn.DataPropertyName = "freeitemvalue2";
            this.freeitemvalue2DataGridViewTextBoxColumn.HeaderText = "自由项2";
            this.freeitemvalue2DataGridViewTextBoxColumn.Name = "freeitemvalue2DataGridViewTextBoxColumn";
            this.freeitemvalue2DataGridViewTextBoxColumn.ReadOnly = true;
            this.freeitemvalue2DataGridViewTextBoxColumn.Width = 61;
            // 
            // freeitemvalue3DataGridViewTextBoxColumn
            // 
            this.freeitemvalue3DataGridViewTextBoxColumn.DataPropertyName = "freeitemvalue3";
            this.freeitemvalue3DataGridViewTextBoxColumn.HeaderText = "自由项3";
            this.freeitemvalue3DataGridViewTextBoxColumn.Name = "freeitemvalue3DataGridViewTextBoxColumn";
            this.freeitemvalue3DataGridViewTextBoxColumn.ReadOnly = true;
            this.freeitemvalue3DataGridViewTextBoxColumn.Width = 61;
            // 
            // freeitemvalue4DataGridViewTextBoxColumn
            // 
            this.freeitemvalue4DataGridViewTextBoxColumn.DataPropertyName = "freeitemvalue4";
            this.freeitemvalue4DataGridViewTextBoxColumn.HeaderText = "自由项4";
            this.freeitemvalue4DataGridViewTextBoxColumn.Name = "freeitemvalue4DataGridViewTextBoxColumn";
            this.freeitemvalue4DataGridViewTextBoxColumn.ReadOnly = true;
            this.freeitemvalue4DataGridViewTextBoxColumn.Width = 61;
            // 
            // freeitemvalue5DataGridViewTextBoxColumn
            // 
            this.freeitemvalue5DataGridViewTextBoxColumn.DataPropertyName = "freeitemvalue5";
            this.freeitemvalue5DataGridViewTextBoxColumn.HeaderText = "自由项5";
            this.freeitemvalue5DataGridViewTextBoxColumn.Name = "freeitemvalue5DataGridViewTextBoxColumn";
            this.freeitemvalue5DataGridViewTextBoxColumn.ReadOnly = true;
            this.freeitemvalue5DataGridViewTextBoxColumn.Width = 61;
            // 
            // pkcorpDataGridViewTextBoxColumn
            // 
            this.pkcorpDataGridViewTextBoxColumn.DataPropertyName = "pk_corp";
            this.pkcorpDataGridViewTextBoxColumn.HeaderText = "公司";
            this.pkcorpDataGridViewTextBoxColumn.Name = "pkcorpDataGridViewTextBoxColumn";
            this.pkcorpDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkcorpDataGridViewTextBoxColumn.Width = 51;
            // 
            // gcbmDataGridViewTextBoxColumn
            // 
            this.gcbmDataGridViewTextBoxColumn.DataPropertyName = "gcbm";
            this.gcbmDataGridViewTextBoxColumn.HeaderText = "工厂";
            this.gcbmDataGridViewTextBoxColumn.Name = "gcbmDataGridViewTextBoxColumn";
            this.gcbmDataGridViewTextBoxColumn.ReadOnly = true;
            this.gcbmDataGridViewTextBoxColumn.Width = 51;
            // 
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            this.objectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn.Visible = false;
            this.objectIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // bsMaterial
            // 
            this.bsMaterial.DataMember = "L3DataTable";
            this.bsMaterial.DataSource = this.dsMaterial;
            // 
            // dsMaterial
            // 
            this.dsMaterial.AutoSubscribe = false;
            this.dsMaterial.DataSetName = "L3DataSet";
            this.dsMaterial.DeleteMethod = "";
            this.dsMaterial.InsertMethod = "";
            this.dsMaterial.L3DataAdapter = null;
            this.dsMaterial.LoadEvent = "";
            this.dsMaterial.LoadTrigger = null;
            this.dsMaterial.RefreshValve = 1000;
            this.dsMaterial.SourceCommand = null;
            this.dsMaterial.SourceCondition = "";
            this.dsMaterial.SourceMethod = "";
            this.dsMaterial.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMaterial.SourceURI = "";
            this.dsMaterial.SubscribeTarget = null;
            this.dsMaterial.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterial});
            this.dsMaterial.UpdateEvent = "";
            this.dsMaterial.UpdateMethod = "";
            this.dsMaterial.UpdateTrigger = null;
            // 
            // schemadsMaterial
            // 
            this.schemadsMaterial.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterialL3DataTablepk_produce,
            this.coldsMaterialL3DataTablepk_corp,
            this.coldsMaterialL3DataTablegcbm,
            this.coldsMaterialL3DataTableObjectID,
            this.coldsMaterialL3DataTablewlbmid,
            this.coldsMaterialL3DataTablejldwid,
            this.coldsMaterialL3DataTablegzzxid,
            this.coldsMaterialL3DataTableccxh,
            this.coldsMaterialL3DataTablegxh,
            this.coldsMaterialL3DataTableksrq,
            this.coldsMaterialL3DataTablekssj,
            this.coldsMaterialL3DataTablejsrq,
            this.coldsMaterialL3DataTablejssj,
            this.coldsMaterialL3DataTablehgsl,
            this.coldsMaterialL3DataTablefhgsl,
            this.coldsMaterialL3DataTablesflfcp,
            this.coldsMaterialL3DataTablesffsgp,
            this.coldsMaterialL3DataTablezdy1,
            this.coldsMaterialL3DataTablezdy2,
            this.coldsMaterialL3DataTablezdy3,
            this.coldsMaterialL3DataTablezdy4,
            this.coldsMaterialL3DataTablezdy5,
            this.coldsMaterialL3DataTablefreeitemvalue1,
            this.coldsMaterialL3DataTablefreeitemvalue2,
            this.coldsMaterialL3DataTablefreeitemvalue3,
            this.coldsMaterialL3DataTablefreeitemvalue4,
            this.coldsMaterialL3DataTablefreeitemvalue5});
            this.schemadsMaterial.TableName = "L3DataTable";
            // 
            // coldsMaterialL3DataTablepk_produce
            // 
            this.coldsMaterialL3DataTablepk_produce.Caption = "pk_produce";
            this.coldsMaterialL3DataTablepk_produce.ColumnName = "pk_produce";
            this.coldsMaterialL3DataTablepk_produce.Namespace = "";
            // 
            // coldsMaterialL3DataTablepk_corp
            // 
            this.coldsMaterialL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsMaterialL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsMaterialL3DataTablepk_corp.Namespace = "";
            // 
            // coldsMaterialL3DataTablegcbm
            // 
            this.coldsMaterialL3DataTablegcbm.Caption = "gcbm";
            this.coldsMaterialL3DataTablegcbm.ColumnName = "gcbm";
            this.coldsMaterialL3DataTablegcbm.Namespace = "";
            // 
            // coldsMaterialL3DataTableObjectID
            // 
            this.coldsMaterialL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.Namespace = "";
            // 
            // coldsMaterialL3DataTablewlbmid
            // 
            this.coldsMaterialL3DataTablewlbmid.Caption = "wlbmid";
            this.coldsMaterialL3DataTablewlbmid.ColumnName = "wlbmid";
            this.coldsMaterialL3DataTablewlbmid.Namespace = "";
            // 
            // coldsMaterialL3DataTablejldwid
            // 
            this.coldsMaterialL3DataTablejldwid.Caption = "jldwid";
            this.coldsMaterialL3DataTablejldwid.ColumnName = "jldwid";
            this.coldsMaterialL3DataTablejldwid.Namespace = "";
            // 
            // coldsMaterialL3DataTablegzzxid
            // 
            this.coldsMaterialL3DataTablegzzxid.Caption = "gzzxid";
            this.coldsMaterialL3DataTablegzzxid.ColumnName = "gzzxid";
            this.coldsMaterialL3DataTablegzzxid.Namespace = "";
            // 
            // coldsMaterialL3DataTableccxh
            // 
            this.coldsMaterialL3DataTableccxh.Caption = "ccxh";
            this.coldsMaterialL3DataTableccxh.ColumnName = "ccxh";
            this.coldsMaterialL3DataTableccxh.Namespace = "";
            // 
            // coldsMaterialL3DataTablegxh
            // 
            this.coldsMaterialL3DataTablegxh.Caption = "gxh";
            this.coldsMaterialL3DataTablegxh.ColumnName = "gxh";
            this.coldsMaterialL3DataTablegxh.Namespace = "";
            // 
            // coldsMaterialL3DataTableksrq
            // 
            this.coldsMaterialL3DataTableksrq.Caption = "ksrq";
            this.coldsMaterialL3DataTableksrq.ColumnName = "ksrq";
            this.coldsMaterialL3DataTableksrq.Namespace = "";
            // 
            // coldsMaterialL3DataTablekssj
            // 
            this.coldsMaterialL3DataTablekssj.Caption = "kssj";
            this.coldsMaterialL3DataTablekssj.ColumnName = "kssj";
            this.coldsMaterialL3DataTablekssj.Namespace = "";
            // 
            // coldsMaterialL3DataTablejsrq
            // 
            this.coldsMaterialL3DataTablejsrq.Caption = "jsrq";
            this.coldsMaterialL3DataTablejsrq.ColumnName = "jsrq";
            this.coldsMaterialL3DataTablejsrq.Namespace = "";
            // 
            // coldsMaterialL3DataTablejssj
            // 
            this.coldsMaterialL3DataTablejssj.Caption = "jssj";
            this.coldsMaterialL3DataTablejssj.ColumnName = "jssj";
            this.coldsMaterialL3DataTablejssj.Namespace = "";
            // 
            // coldsMaterialL3DataTablehgsl
            // 
            this.coldsMaterialL3DataTablehgsl.Caption = "hgsl";
            this.coldsMaterialL3DataTablehgsl.ColumnName = "hgsl";
            this.coldsMaterialL3DataTablehgsl.Namespace = "";
            // 
            // coldsMaterialL3DataTablefhgsl
            // 
            this.coldsMaterialL3DataTablefhgsl.Caption = "fhgsl";
            this.coldsMaterialL3DataTablefhgsl.ColumnName = "fhgsl";
            this.coldsMaterialL3DataTablefhgsl.Namespace = "";
            // 
            // coldsMaterialL3DataTablesflfcp
            // 
            this.coldsMaterialL3DataTablesflfcp.Caption = "sflfcp";
            this.coldsMaterialL3DataTablesflfcp.ColumnName = "sflfcp";
            this.coldsMaterialL3DataTablesflfcp.Namespace = "";
            // 
            // coldsMaterialL3DataTablesffsgp
            // 
            this.coldsMaterialL3DataTablesffsgp.Caption = "sffsgp";
            this.coldsMaterialL3DataTablesffsgp.ColumnName = "sffsgp";
            this.coldsMaterialL3DataTablesffsgp.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy1
            // 
            this.coldsMaterialL3DataTablezdy1.Caption = "zdy1";
            this.coldsMaterialL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsMaterialL3DataTablezdy1.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy2
            // 
            this.coldsMaterialL3DataTablezdy2.Caption = "zdy2";
            this.coldsMaterialL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsMaterialL3DataTablezdy2.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy3
            // 
            this.coldsMaterialL3DataTablezdy3.Caption = "zdy3";
            this.coldsMaterialL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsMaterialL3DataTablezdy3.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy4
            // 
            this.coldsMaterialL3DataTablezdy4.Caption = "zdy4";
            this.coldsMaterialL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsMaterialL3DataTablezdy4.Namespace = "";
            // 
            // coldsMaterialL3DataTablezdy5
            // 
            this.coldsMaterialL3DataTablezdy5.Caption = "zdy5";
            this.coldsMaterialL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsMaterialL3DataTablezdy5.Namespace = "";
            // 
            // coldsMaterialL3DataTablefreeitemvalue1
            // 
            this.coldsMaterialL3DataTablefreeitemvalue1.Caption = "freeitemvalue1";
            this.coldsMaterialL3DataTablefreeitemvalue1.ColumnName = "freeitemvalue1";
            this.coldsMaterialL3DataTablefreeitemvalue1.Namespace = "";
            // 
            // coldsMaterialL3DataTablefreeitemvalue2
            // 
            this.coldsMaterialL3DataTablefreeitemvalue2.Caption = "freeitemvalue2";
            this.coldsMaterialL3DataTablefreeitemvalue2.ColumnName = "freeitemvalue2";
            this.coldsMaterialL3DataTablefreeitemvalue2.Namespace = "";
            // 
            // coldsMaterialL3DataTablefreeitemvalue3
            // 
            this.coldsMaterialL3DataTablefreeitemvalue3.Caption = "freeitemvalue3";
            this.coldsMaterialL3DataTablefreeitemvalue3.ColumnName = "freeitemvalue3";
            this.coldsMaterialL3DataTablefreeitemvalue3.Namespace = "";
            // 
            // coldsMaterialL3DataTablefreeitemvalue4
            // 
            this.coldsMaterialL3DataTablefreeitemvalue4.Caption = "freeitemvalue4";
            this.coldsMaterialL3DataTablefreeitemvalue4.ColumnName = "freeitemvalue4";
            this.coldsMaterialL3DataTablefreeitemvalue4.Namespace = "";
            // 
            // coldsMaterialL3DataTablefreeitemvalue5
            // 
            this.coldsMaterialL3DataTablefreeitemvalue5.Caption = "freeitemvalue5";
            this.coldsMaterialL3DataTablefreeitemvalue5.ColumnName = "freeitemvalue5";
            this.coldsMaterialL3DataTablefreeitemvalue5.Namespace = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 94);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表头数据";
            // 
            // dvMain
            // 
            this.dvMain.AllowUserToAddRows = false;
            this.dvMain.AutoGenerateColumns = false;
            this.dvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn,
            this.flagDataGridViewTextBoxColumn,
            this.pchDataGridViewTextBoxColumn,
            this.zdridDataGridViewTextBoxColumn,
            this.rqDataGridViewTextBoxColumn,
            this.sjDataGridViewTextBoxColumn,
            this.nCConfirmFlagDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn1});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(3, 17);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.Size = new System.Drawing.Size(546, 74);
            this.dvMain.TabIndex = 0;
            this.dvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Visible = false;
            this.heatIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewTextBoxColumn.HeaderText = "Flag";
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.ReadOnly = true;
            this.flagDataGridViewTextBoxColumn.Visible = false;
            this.flagDataGridViewTextBoxColumn.Width = 54;
            // 
            // pchDataGridViewTextBoxColumn
            // 
            this.pchDataGridViewTextBoxColumn.DataPropertyName = "pch";
            this.pchDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.pchDataGridViewTextBoxColumn.Name = "pchDataGridViewTextBoxColumn";
            this.pchDataGridViewTextBoxColumn.ReadOnly = true;
            this.pchDataGridViewTextBoxColumn.Width = 66;
            // 
            // zdridDataGridViewTextBoxColumn
            // 
            this.zdridDataGridViewTextBoxColumn.DataPropertyName = "zdrid";
            this.zdridDataGridViewTextBoxColumn.HeaderText = "操作员编码";
            this.zdridDataGridViewTextBoxColumn.Name = "zdridDataGridViewTextBoxColumn";
            this.zdridDataGridViewTextBoxColumn.ReadOnly = true;
            this.zdridDataGridViewTextBoxColumn.Width = 90;
            // 
            // rqDataGridViewTextBoxColumn
            // 
            this.rqDataGridViewTextBoxColumn.DataPropertyName = "rq";
            this.rqDataGridViewTextBoxColumn.HeaderText = "报告日期";
            this.rqDataGridViewTextBoxColumn.Name = "rqDataGridViewTextBoxColumn";
            this.rqDataGridViewTextBoxColumn.ReadOnly = true;
            this.rqDataGridViewTextBoxColumn.Width = 78;
            // 
            // sjDataGridViewTextBoxColumn
            // 
            this.sjDataGridViewTextBoxColumn.DataPropertyName = "sj";
            this.sjDataGridViewTextBoxColumn.HeaderText = "报告时间";
            this.sjDataGridViewTextBoxColumn.Name = "sjDataGridViewTextBoxColumn";
            this.sjDataGridViewTextBoxColumn.ReadOnly = true;
            this.sjDataGridViewTextBoxColumn.Width = 78;
            // 
            // nCConfirmFlagDataGridViewTextBoxColumn
            // 
            this.nCConfirmFlagDataGridViewTextBoxColumn.DataPropertyName = "NC_Confirm_Flag";
            this.nCConfirmFlagDataGridViewTextBoxColumn.HeaderText = "确认标志";
            this.nCConfirmFlagDataGridViewTextBoxColumn.Name = "nCConfirmFlagDataGridViewTextBoxColumn";
            this.nCConfirmFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.nCConfirmFlagDataGridViewTextBoxColumn.Visible = false;
            this.nCConfirmFlagDataGridViewTextBoxColumn.Width = 78;
            // 
            // objectIDDataGridViewTextBoxColumn1
            // 
            this.objectIDDataGridViewTextBoxColumn1.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn1.HeaderText = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn1.Name = "objectIDDataGridViewTextBoxColumn1";
            this.objectIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn1.Visible = false;
            this.objectIDDataGridViewTextBoxColumn1.Width = 78;
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "";
            this.dsMain.InsertMethod = "";
            this.dsMain.L3DataAdapter = null;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMain.SourceURI = "";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "";
            this.dsMain.UpdateTrigger = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableHeatID,
            this.coldsMainL3DataTableFlag,
            this.coldsMainL3DataTablepch,
            this.coldsMainL3DataTableNC_Confirm_Flag,
            this.coldsMainL3DataTableObjectID,
            this.coldsMainL3DataTablezdrid,
            this.coldsMainL3DataTablerq,
            this.coldsMainL3DataTablesj});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableHeatID
            // 
            this.coldsMainL3DataTableHeatID.Caption = "HeatID";
            this.coldsMainL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsMainL3DataTableHeatID.Namespace = "";
            // 
            // coldsMainL3DataTableFlag
            // 
            this.coldsMainL3DataTableFlag.Caption = "Flag";
            this.coldsMainL3DataTableFlag.ColumnName = "Flag";
            this.coldsMainL3DataTableFlag.Namespace = "";
            // 
            // coldsMainL3DataTablepch
            // 
            this.coldsMainL3DataTablepch.Caption = "pch";
            this.coldsMainL3DataTablepch.ColumnName = "pch";
            this.coldsMainL3DataTablepch.Namespace = "";
            // 
            // coldsMainL3DataTableNC_Confirm_Flag
            // 
            this.coldsMainL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsMainL3DataTableObjectID
            // 
            this.coldsMainL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMainL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMainL3DataTableObjectID.Namespace = "";
            // 
            // coldsMainL3DataTablezdrid
            // 
            this.coldsMainL3DataTablezdrid.Caption = "zdrid";
            this.coldsMainL3DataTablezdrid.ColumnName = "zdrid";
            this.coldsMainL3DataTablezdrid.Namespace = "";
            // 
            // coldsMainL3DataTablerq
            // 
            this.coldsMainL3DataTablerq.Caption = "rq";
            this.coldsMainL3DataTablerq.ColumnName = "rq";
            this.coldsMainL3DataTablerq.Namespace = "";
            // 
            // coldsMainL3DataTablesj
            // 
            this.coldsMainL3DataTablesj.Caption = "sj";
            this.coldsMainL3DataTablesj.ColumnName = "sj";
            this.coldsMainL3DataTablesj.Namespace = "";
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
            this.bnM.BindingSource = this.bsMain;
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
            this.txbHeatID,
            this.toolStripLabel4});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(552, 25);
            this.bnM.TabIndex = 36;
            this.bnM.Text = "bindingNavigator1";
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
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "查询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.toolStripLabel4.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel4.Text = "铁次号";
            // 
            // dsLog
            // 
            this.dsLog.AutoSubscribe = false;
            this.dsLog.DataSetName = "L3DataSet";
            this.dsLog.DeleteMethod = "";
            this.dsLog.InsertMethod = "";
            this.dsLog.L3DataAdapter = null;
            this.dsLog.LoadEvent = "";
            this.dsLog.LoadTrigger = null;
            this.dsLog.RefreshValve = 1000;
            this.dsLog.SourceCommand = null;
            this.dsLog.SourceCondition = "";
            this.dsLog.SourceMethod = "";
            this.dsLog.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsLog.SourceURI = "";
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
            // cmdMain
            // 
            this.cmdMain.Adapter = this.Adapter;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = "SendIronBloomInfor";
            this.cmdMain.Object = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
            this.cmdMain.Parameters.Add(this.l3CommandParameter1);
            this.cmdMain.Parameters.Add(this.l3CommandParameter2);
            this.cmdMain.ReturnTarget = this.dsMaterial;
            this.cmdMain.ReturnTargetProperty = null;
            this.cmdMain.Trigger = null;
            this.cmdMain.TriggerEvent = "Click";
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
            this.l3CommandParameter2.SourceObject = this.dsMain;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = this.dsMain;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // IronBloomInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tSp1);
            this.Name = "IronBloomInfoFrm";
            this.TabText = "铁水完工电文补发";
            this.Text = "铁水完工电文补发";
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWorkCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnUpdateSend;
        private System.Windows.Forms.ToolStripButton btnAddSend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txbHeatID;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvMaterial;
        private System.Windows.Forms.DataGridView dvMain;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsMaterial;
        private AppSvrHMI.L3DataSet dsMaterial;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3DataSet dsLog;
        private AppSvrHMI.L3Command cmdMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableFlag;
        private System.Data.DataColumn coldsMainL3DataTablepch;
        private System.Data.DataColumn coldsMainL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsMainL3DataTableObjectID;
        private System.Data.DataTable schemadsMaterial;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_produce;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_corp;
        private System.Data.DataColumn coldsMaterialL3DataTablegcbm;
        private System.Data.DataColumn coldsMaterialL3DataTableObjectID;
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
        private System.Data.DataColumn coldsMainL3DataTablezdrid;
        private System.Data.DataColumn coldsMainL3DataTablerq;
        private System.Data.DataColumn coldsMainL3DataTablesj;
        private System.Data.DataColumn coldsMaterialL3DataTablewlbmid;
        private System.Data.DataColumn coldsMaterialL3DataTablejldwid;
        private System.Data.DataColumn coldsMaterialL3DataTablegzzxid;
        private System.Data.DataColumn coldsMaterialL3DataTableccxh;
        private System.Data.DataColumn coldsMaterialL3DataTablegxh;
        private System.Data.DataColumn coldsMaterialL3DataTableksrq;
        private System.Data.DataColumn coldsMaterialL3DataTablekssj;
        private System.Data.DataColumn coldsMaterialL3DataTablejsrq;
        private System.Data.DataColumn coldsMaterialL3DataTablejssj;
        private System.Data.DataColumn coldsMaterialL3DataTablehgsl;
        private System.Data.DataColumn coldsMaterialL3DataTablefhgsl;
        private System.Data.DataColumn coldsMaterialL3DataTablesflfcp;
        private System.Data.DataColumn coldsMaterialL3DataTablesffsgp;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy1;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy2;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy3;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy4;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy5;
        private System.Data.DataColumn coldsMaterialL3DataTablefreeitemvalue1;
        private System.Data.DataColumn coldsMaterialL3DataTablefreeitemvalue2;
        private System.Data.DataColumn coldsMaterialL3DataTablefreeitemvalue3;
        private System.Data.DataColumn coldsMaterialL3DataTablefreeitemvalue4;
        private System.Data.DataColumn coldsMaterialL3DataTablefreeitemvalue5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCConfirmFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn1;
        private AppSvrHMI.L3DataSet dsMaterialID;
        private AppSvrHMI.L3DataSet dsWorkCenter;
        private System.Windows.Forms.DataGridViewComboBoxColumn wlbmidDataGridViewTextBoxColumn;
        private System.Data.DataTable schemadsMaterialID;
        private System.Data.DataColumn coldsMaterialIDL3DataTablePk_Material_Bas;
        private System.Data.DataColumn coldsMaterialIDL3DataTableMaterial_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn jldwidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gzzxidDataGridViewTextBoxColumn;
        private System.Data.DataTable schemadsWorkCenter;
        private System.Data.DataColumn coldsWorkCenterL3DataTableCenter_Code;
        private System.Data.DataColumn coldsWorkCenterL3DataTablePk_Center;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccxhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gxhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkproduceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jsrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fhgslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sflfcpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sffsgpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkcorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
    }
}