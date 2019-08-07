namespace NCTelDataMag
{
    partial class MeterialInfoFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>dsLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeterialInfoFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateSend = new System.Windows.Forms.ToolStripButton();
            this.btnAddSend = new System.Windows.Forms.ToolStripButton();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvMaterial = new System.Windows.Forms.DataGridView();
            this.kgyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckckidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStore = new AppSvrHMI.L3DataSet();
            this.schemadsStore = new System.Data.DataTable();
            this.coldsStoreL3DataTablePk_Stock = new System.Data.DataColumn();
            this.coldsStoreL3DataTableStock_Name = new System.Data.DataColumn();
            this.ckckbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wlbmidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMaterID = new AppSvrHMI.L3DataSet();
            this.schemadsMaterID = new System.Data.DataTable();
            this.coldsMaterIDL3DataTablePk_Material_Bas = new System.Data.DataColumn();
            this.coldsMaterIDL3DataTableMaterial_Name = new System.Data.DataColumn();
            this.jldwidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjldwidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ljckslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fljckslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gzzxidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCenter = new AppSvrHMI.L3DataSet();
            this.schemadsCenter = new System.Data.DataTable();
            this.coldsCenterL3DataTablePk_Center = new System.Data.DataColumn();
            this.coldsCenterL3DataTableCenter_Code = new System.Data.DataColumn();
            this.gxhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkcorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccostobjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkmoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterial = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial = new System.Data.DataTable();
            this.coldsMaterialL3DataTablekgyid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableckckid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableckckbm = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablewlbmid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablejldwid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefjldwid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableljcksl = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablefljcksl = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepch = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegzzxid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegxh = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegcbm = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccostobject = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableflrq = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepk_moid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableObjectID = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scddhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wlbmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jldwidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ylbmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bljhdhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeitemvalue5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCConfirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTablescddh = new System.Data.DataColumn();
            this.coldsMainL3DataTablezdrid = new System.Data.DataColumn();
            this.coldsMainL3DataTablepch = new System.Data.DataColumn();
            this.coldsMainL3DataTablewlbmid = new System.Data.DataColumn();
            this.coldsMainL3DataTablejldwid = new System.Data.DataColumn();
            this.coldsMainL3DataTableylbmid = new System.Data.DataColumn();
            this.coldsMainL3DataTablebljhdh = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue1 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue2 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue3 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue4 = new System.Data.DataColumn();
            this.coldsMainL3DataTablefreeitemvalue5 = new System.Data.DataColumn();
            this.coldsMainL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableTreatNo = new System.Data.DataColumn();
            this.coldsMainL3DataTablezdrq = new System.Data.DataColumn();
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.dsLog = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableGUID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableName = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableHeatID = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableBillType = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableFlag = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableRemark = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCreateTime = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther1 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther2 = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableOther3 = new System.Data.DataColumn();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
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
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
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
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
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
            this.bnM.Location = new System.Drawing.Point(0, 43);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(1000, 25);
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
            this.toolStripLabel4.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel4.Text = "炉号";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 330);
            this.panel1.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvMaterial);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 203);
            this.groupBox2.TabIndex = 1;
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
            this.kgyidDataGridViewTextBoxColumn,
            this.ckckidDataGridViewTextBoxColumn,
            this.ckckbmDataGridViewTextBoxColumn,
            this.wlbmidDataGridViewTextBoxColumn1,
            this.jldwidDataGridViewTextBoxColumn1,
            this.fjldwidDataGridViewTextBoxColumn,
            this.ljckslDataGridViewTextBoxColumn,
            this.fljckslDataGridViewTextBoxColumn,
            this.pchDataGridViewTextBoxColumn1,
            this.gzzxidDataGridViewTextBoxColumn,
            this.gxhDataGridViewTextBoxColumn,
            this.zdy1DataGridViewTextBoxColumn,
            this.zdy2DataGridViewTextBoxColumn,
            this.zdy3DataGridViewTextBoxColumn,
            this.zdy4DataGridViewTextBoxColumn,
            this.zdy5DataGridViewTextBoxColumn,
            this.zyx1DataGridViewTextBoxColumn,
            this.zyx2DataGridViewTextBoxColumn,
            this.zyx3DataGridViewTextBoxColumn,
            this.zyx4DataGridViewTextBoxColumn,
            this.zyx5DataGridViewTextBoxColumn,
            this.pkcorpDataGridViewTextBoxColumn,
            this.gcbmDataGridViewTextBoxColumn,
            this.ccostobjectDataGridViewTextBoxColumn,
            this.flrqDataGridViewTextBoxColumn,
            this.pkmoidDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn1});
            this.dvMaterial.DataSource = this.bsMaterial;
            this.dvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMaterial.Location = new System.Drawing.Point(3, 17);
            this.dvMaterial.Name = "dvMaterial";
            this.dvMaterial.ReadOnly = true;
            this.dvMaterial.RowTemplate.Height = 23;
            this.dvMaterial.Size = new System.Drawing.Size(994, 183);
            this.dvMaterial.TabIndex = 0;
            this.dvMaterial.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMaterial_DataError);
            // 
            // kgyidDataGridViewTextBoxColumn
            // 
            this.kgyidDataGridViewTextBoxColumn.DataPropertyName = "kgyid";
            this.kgyidDataGridViewTextBoxColumn.HeaderText = "投料操作员编码";
            this.kgyidDataGridViewTextBoxColumn.Name = "kgyidDataGridViewTextBoxColumn";
            this.kgyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kgyidDataGridViewTextBoxColumn.Width = 83;
            // 
            // ckckidDataGridViewTextBoxColumn
            // 
            this.ckckidDataGridViewTextBoxColumn.DataPropertyName = "ckckid";
            this.ckckidDataGridViewTextBoxColumn.DataSource = this.dsStore;
            this.ckckidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Stock_Name";
            this.ckckidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ckckidDataGridViewTextBoxColumn.HeaderText = "发料仓库";
            this.ckckidDataGridViewTextBoxColumn.Name = "ckckidDataGridViewTextBoxColumn";
            this.ckckidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ckckidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ckckidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ckckidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Stock";
            this.ckckidDataGridViewTextBoxColumn.Width = 61;
            // 
            // dsStore
            // 
            this.dsStore.AutoLoad = true;
            this.dsStore.AutoSubscribe = false;
            this.dsStore.DataSetName = "L3DataSet";
            this.dsStore.DeleteMethod = "";
            this.dsStore.InsertMethod = "";
            this.dsStore.L3DataAdapter = this.Adapter;
            this.dsStore.LoadEvent = "";
            this.dsStore.LoadTrigger = null;
            this.dsStore.RefreshValve = 1000;
            this.dsStore.SourceCommand = null;
            this.dsStore.SourceCondition = "";
            this.dsStore.SourceMethod = "";
            this.dsStore.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStore.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Stock_Infor";
            this.dsStore.SubscribeTarget = "";
            this.dsStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStore});
            this.dsStore.UpdateEvent = "";
            this.dsStore.UpdateMethod = "";
            this.dsStore.UpdateTrigger = null;
            // 
            // schemadsStore
            // 
            this.schemadsStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreL3DataTablePk_Stock,
            this.coldsStoreL3DataTableStock_Name});
            this.schemadsStore.TableName = "L3DataTable";
            // 
            // coldsStoreL3DataTablePk_Stock
            // 
            this.coldsStoreL3DataTablePk_Stock.Caption = "Pk_Stock";
            this.coldsStoreL3DataTablePk_Stock.ColumnName = "Pk_Stock";
            this.coldsStoreL3DataTablePk_Stock.Namespace = "";
            // 
            // coldsStoreL3DataTableStock_Name
            // 
            this.coldsStoreL3DataTableStock_Name.Caption = "Stock_Name";
            this.coldsStoreL3DataTableStock_Name.ColumnName = "Stock_Name";
            this.coldsStoreL3DataTableStock_Name.Namespace = "";
            // 
            // ckckbmDataGridViewTextBoxColumn
            // 
            this.ckckbmDataGridViewTextBoxColumn.DataPropertyName = "ckckbm";
            this.ckckbmDataGridViewTextBoxColumn.HeaderText = "发料仓库编码";
            this.ckckbmDataGridViewTextBoxColumn.Name = "ckckbmDataGridViewTextBoxColumn";
            this.ckckbmDataGridViewTextBoxColumn.ReadOnly = true;
            this.ckckbmDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ckckbmDataGridViewTextBoxColumn.Width = 72;
            // 
            // wlbmidDataGridViewTextBoxColumn1
            // 
            this.wlbmidDataGridViewTextBoxColumn1.DataPropertyName = "wlbmid";
            this.wlbmidDataGridViewTextBoxColumn1.DataSource = this.dsMaterID;
            this.wlbmidDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Material_Name";
            this.wlbmidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wlbmidDataGridViewTextBoxColumn1.HeaderText = "物料编码id";
            this.wlbmidDataGridViewTextBoxColumn1.Name = "wlbmidDataGridViewTextBoxColumn1";
            this.wlbmidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.wlbmidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wlbmidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wlbmidDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Pk_Material_Bas";
            this.wlbmidDataGridViewTextBoxColumn1.Width = 72;
            // 
            // dsMaterID
            // 
            this.dsMaterID.AutoLoad = true;
            this.dsMaterID.AutoSubscribe = false;
            this.dsMaterID.DataSetName = "L3DataSet";
            this.dsMaterID.DeleteMethod = "";
            this.dsMaterID.InsertMethod = "";
            this.dsMaterID.L3DataAdapter = this.Adapter;
            this.dsMaterID.LoadEvent = "";
            this.dsMaterID.LoadTrigger = null;
            this.dsMaterID.RefreshValve = 1000;
            this.dsMaterID.SourceCommand = null;
            this.dsMaterID.SourceCondition = " SUBSTR (material_code, 1, 1) = \'1\'  OR SUBSTR (material_code, 1, 1) = \'5\'  OR SU" +
                "BSTR (material_code, 1, 1) = \'6\'";
            this.dsMaterID.SourceMethod = "";
            this.dsMaterID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMaterID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Material_Base_Infor";
            this.dsMaterID.SubscribeTarget = "";
            this.dsMaterID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterID});
            this.dsMaterID.UpdateEvent = "";
            this.dsMaterID.UpdateMethod = "";
            this.dsMaterID.UpdateTrigger = null;
            // 
            // schemadsMaterID
            // 
            this.schemadsMaterID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterIDL3DataTablePk_Material_Bas,
            this.coldsMaterIDL3DataTableMaterial_Name});
            this.schemadsMaterID.TableName = "L3DataTable";
            // 
            // coldsMaterIDL3DataTablePk_Material_Bas
            // 
            this.coldsMaterIDL3DataTablePk_Material_Bas.Caption = "Pk_Material_Bas";
            this.coldsMaterIDL3DataTablePk_Material_Bas.ColumnName = "Pk_Material_Bas";
            this.coldsMaterIDL3DataTablePk_Material_Bas.Namespace = "";
            // 
            // coldsMaterIDL3DataTableMaterial_Name
            // 
            this.coldsMaterIDL3DataTableMaterial_Name.Caption = "Material_Name";
            this.coldsMaterIDL3DataTableMaterial_Name.ColumnName = "Material_Name";
            this.coldsMaterIDL3DataTableMaterial_Name.Namespace = "";
            // 
            // jldwidDataGridViewTextBoxColumn1
            // 
            this.jldwidDataGridViewTextBoxColumn1.DataPropertyName = "jldwid";
            this.jldwidDataGridViewTextBoxColumn1.HeaderText = "计量单位id";
            this.jldwidDataGridViewTextBoxColumn1.Name = "jldwidDataGridViewTextBoxColumn1";
            this.jldwidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.jldwidDataGridViewTextBoxColumn1.Width = 72;
            // 
            // fjldwidDataGridViewTextBoxColumn
            // 
            this.fjldwidDataGridViewTextBoxColumn.DataPropertyName = "fjldwid";
            this.fjldwidDataGridViewTextBoxColumn.HeaderText = "辅计量单位id";
            this.fjldwidDataGridViewTextBoxColumn.Name = "fjldwidDataGridViewTextBoxColumn";
            this.fjldwidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fjldwidDataGridViewTextBoxColumn.Width = 72;
            // 
            // ljckslDataGridViewTextBoxColumn
            // 
            this.ljckslDataGridViewTextBoxColumn.DataPropertyName = "ljcksl";
            this.ljckslDataGridViewTextBoxColumn.HeaderText = "投料数量";
            this.ljckslDataGridViewTextBoxColumn.Name = "ljckslDataGridViewTextBoxColumn";
            this.ljckslDataGridViewTextBoxColumn.ReadOnly = true;
            this.ljckslDataGridViewTextBoxColumn.Width = 61;
            // 
            // fljckslDataGridViewTextBoxColumn
            // 
            this.fljckslDataGridViewTextBoxColumn.DataPropertyName = "fljcksl";
            this.fljckslDataGridViewTextBoxColumn.HeaderText = "投料辅数量";
            this.fljckslDataGridViewTextBoxColumn.Name = "fljckslDataGridViewTextBoxColumn";
            this.fljckslDataGridViewTextBoxColumn.ReadOnly = true;
            this.fljckslDataGridViewTextBoxColumn.Width = 72;
            // 
            // pchDataGridViewTextBoxColumn1
            // 
            this.pchDataGridViewTextBoxColumn1.DataPropertyName = "pch";
            this.pchDataGridViewTextBoxColumn1.HeaderText = "投料物料批次号";
            this.pchDataGridViewTextBoxColumn1.Name = "pchDataGridViewTextBoxColumn1";
            this.pchDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pchDataGridViewTextBoxColumn1.Width = 83;
            // 
            // gzzxidDataGridViewTextBoxColumn
            // 
            this.gzzxidDataGridViewTextBoxColumn.DataPropertyName = "gzzxid";
            this.gzzxidDataGridViewTextBoxColumn.DataSource = this.dsCenter;
            this.gzzxidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Center_Code";
            this.gzzxidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.gzzxidDataGridViewTextBoxColumn.HeaderText = "投料工作中心";
            this.gzzxidDataGridViewTextBoxColumn.Name = "gzzxidDataGridViewTextBoxColumn";
            this.gzzxidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gzzxidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gzzxidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gzzxidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Center";
            this.gzzxidDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsCenter
            // 
            this.dsCenter.AutoLoad = true;
            this.dsCenter.AutoSubscribe = false;
            this.dsCenter.DataSetName = "L3DataSet";
            this.dsCenter.DeleteMethod = "";
            this.dsCenter.InsertMethod = "";
            this.dsCenter.L3DataAdapter = this.Adapter;
            this.dsCenter.LoadEvent = "";
            this.dsCenter.LoadTrigger = null;
            this.dsCenter.RefreshValve = 1000;
            this.dsCenter.SourceCommand = null;
            this.dsCenter.SourceCondition = "";
            this.dsCenter.SourceMethod = "";
            this.dsCenter.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCenter.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Prod_Center_Infor";
            this.dsCenter.SubscribeTarget = "";
            this.dsCenter.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCenter});
            this.dsCenter.UpdateEvent = "";
            this.dsCenter.UpdateMethod = "";
            this.dsCenter.UpdateTrigger = null;
            // 
            // schemadsCenter
            // 
            this.schemadsCenter.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCenterL3DataTablePk_Center,
            this.coldsCenterL3DataTableCenter_Code});
            this.schemadsCenter.TableName = "L3DataTable";
            // 
            // coldsCenterL3DataTablePk_Center
            // 
            this.coldsCenterL3DataTablePk_Center.Caption = "Pk_Center";
            this.coldsCenterL3DataTablePk_Center.ColumnName = "Pk_Center";
            this.coldsCenterL3DataTablePk_Center.Namespace = "";
            // 
            // coldsCenterL3DataTableCenter_Code
            // 
            this.coldsCenterL3DataTableCenter_Code.Caption = "Center_Code";
            this.coldsCenterL3DataTableCenter_Code.ColumnName = "Center_Code";
            this.coldsCenterL3DataTableCenter_Code.Namespace = "";
            // 
            // gxhDataGridViewTextBoxColumn
            // 
            this.gxhDataGridViewTextBoxColumn.DataPropertyName = "gxh";
            this.gxhDataGridViewTextBoxColumn.HeaderText = "工序号";
            this.gxhDataGridViewTextBoxColumn.Name = "gxhDataGridViewTextBoxColumn";
            this.gxhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gxhDataGridViewTextBoxColumn.Width = 61;
            // 
            // zdy1DataGridViewTextBoxColumn
            // 
            this.zdy1DataGridViewTextBoxColumn.DataPropertyName = "zdy1";
            this.zdy1DataGridViewTextBoxColumn.HeaderText = "自定义1";
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
            // zyx1DataGridViewTextBoxColumn
            // 
            this.zyx1DataGridViewTextBoxColumn.DataPropertyName = "zyx1";
            this.zyx1DataGridViewTextBoxColumn.HeaderText = "产品标准";
            this.zyx1DataGridViewTextBoxColumn.Name = "zyx1DataGridViewTextBoxColumn";
            this.zyx1DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx1DataGridViewTextBoxColumn.Width = 61;
            // 
            // zyx2DataGridViewTextBoxColumn
            // 
            this.zyx2DataGridViewTextBoxColumn.DataPropertyName = "zyx2";
            this.zyx2DataGridViewTextBoxColumn.HeaderText = "技术要求";
            this.zyx2DataGridViewTextBoxColumn.Name = "zyx2DataGridViewTextBoxColumn";
            this.zyx2DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx2DataGridViewTextBoxColumn.Width = 61;
            // 
            // zyx3DataGridViewTextBoxColumn
            // 
            this.zyx3DataGridViewTextBoxColumn.DataPropertyName = "zyx3";
            this.zyx3DataGridViewTextBoxColumn.HeaderText = "自由项3";
            this.zyx3DataGridViewTextBoxColumn.Name = "zyx3DataGridViewTextBoxColumn";
            this.zyx3DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx3DataGridViewTextBoxColumn.Width = 61;
            // 
            // zyx4DataGridViewTextBoxColumn
            // 
            this.zyx4DataGridViewTextBoxColumn.DataPropertyName = "zyx4";
            this.zyx4DataGridViewTextBoxColumn.HeaderText = "自由项4";
            this.zyx4DataGridViewTextBoxColumn.Name = "zyx4DataGridViewTextBoxColumn";
            this.zyx4DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx4DataGridViewTextBoxColumn.Width = 61;
            // 
            // zyx5DataGridViewTextBoxColumn
            // 
            this.zyx5DataGridViewTextBoxColumn.DataPropertyName = "zyx5";
            this.zyx5DataGridViewTextBoxColumn.HeaderText = "自由项5";
            this.zyx5DataGridViewTextBoxColumn.Name = "zyx5DataGridViewTextBoxColumn";
            this.zyx5DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx5DataGridViewTextBoxColumn.Width = 61;
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
            // ccostobjectDataGridViewTextBoxColumn
            // 
            this.ccostobjectDataGridViewTextBoxColumn.DataPropertyName = "ccostobject";
            this.ccostobjectDataGridViewTextBoxColumn.HeaderText = "成本对象";
            this.ccostobjectDataGridViewTextBoxColumn.Name = "ccostobjectDataGridViewTextBoxColumn";
            this.ccostobjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccostobjectDataGridViewTextBoxColumn.Width = 61;
            // 
            // flrqDataGridViewTextBoxColumn
            // 
            this.flrqDataGridViewTextBoxColumn.DataPropertyName = "flrq";
            this.flrqDataGridViewTextBoxColumn.HeaderText = "发料日期";
            this.flrqDataGridViewTextBoxColumn.Name = "flrqDataGridViewTextBoxColumn";
            this.flrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.flrqDataGridViewTextBoxColumn.Width = 61;
            // 
            // pkmoidDataGridViewTextBoxColumn
            // 
            this.pkmoidDataGridViewTextBoxColumn.DataPropertyName = "pk_moid";
            this.pkmoidDataGridViewTextBoxColumn.HeaderText = "备料计划单主键";
            this.pkmoidDataGridViewTextBoxColumn.Name = "pkmoidDataGridViewTextBoxColumn";
            this.pkmoidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkmoidDataGridViewTextBoxColumn.Width = 83;
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
            // bsMaterial
            // 
            this.bsMaterial.DataMember = "L3DataTable";
            this.bsMaterial.DataSource = this.dsMaterial;
            // 
            // dsMaterial
            // 
            this.dsMaterial.AutoLoad = true;
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
            this.coldsMaterialL3DataTablekgyid,
            this.coldsMaterialL3DataTableckckid,
            this.coldsMaterialL3DataTableckckbm,
            this.coldsMaterialL3DataTablewlbmid,
            this.coldsMaterialL3DataTablejldwid,
            this.coldsMaterialL3DataTablefjldwid,
            this.coldsMaterialL3DataTableljcksl,
            this.coldsMaterialL3DataTablefljcksl,
            this.coldsMaterialL3DataTablepch,
            this.coldsMaterialL3DataTablegzzxid,
            this.coldsMaterialL3DataTablegxh,
            this.coldsMaterialL3DataTablezdy1,
            this.coldsMaterialL3DataTablezdy2,
            this.coldsMaterialL3DataTablezdy3,
            this.coldsMaterialL3DataTablezdy4,
            this.coldsMaterialL3DataTablezdy5,
            this.coldsMaterialL3DataTablezyx1,
            this.coldsMaterialL3DataTablezyx2,
            this.coldsMaterialL3DataTablezyx3,
            this.coldsMaterialL3DataTablezyx4,
            this.coldsMaterialL3DataTablezyx5,
            this.coldsMaterialL3DataTablepk_corp,
            this.coldsMaterialL3DataTablegcbm,
            this.coldsMaterialL3DataTableccostobject,
            this.coldsMaterialL3DataTableflrq,
            this.coldsMaterialL3DataTablepk_moid,
            this.coldsMaterialL3DataTableObjectID});
            this.schemadsMaterial.TableName = "L3DataTable";
            // 
            // coldsMaterialL3DataTablekgyid
            // 
            this.coldsMaterialL3DataTablekgyid.Caption = "kgyid";
            this.coldsMaterialL3DataTablekgyid.ColumnName = "kgyid";
            this.coldsMaterialL3DataTablekgyid.Namespace = "";
            // 
            // coldsMaterialL3DataTableckckid
            // 
            this.coldsMaterialL3DataTableckckid.Caption = "ckckid";
            this.coldsMaterialL3DataTableckckid.ColumnName = "ckckid";
            this.coldsMaterialL3DataTableckckid.Namespace = "";
            // 
            // coldsMaterialL3DataTableckckbm
            // 
            this.coldsMaterialL3DataTableckckbm.Caption = "ckckbm";
            this.coldsMaterialL3DataTableckckbm.ColumnName = "ckckbm";
            this.coldsMaterialL3DataTableckckbm.Namespace = "";
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
            // coldsMaterialL3DataTablefjldwid
            // 
            this.coldsMaterialL3DataTablefjldwid.Caption = "fjldwid";
            this.coldsMaterialL3DataTablefjldwid.ColumnName = "fjldwid";
            this.coldsMaterialL3DataTablefjldwid.Namespace = "";
            // 
            // coldsMaterialL3DataTableljcksl
            // 
            this.coldsMaterialL3DataTableljcksl.Caption = "ljcksl";
            this.coldsMaterialL3DataTableljcksl.ColumnName = "ljcksl";
            this.coldsMaterialL3DataTableljcksl.Namespace = "";
            // 
            // coldsMaterialL3DataTablefljcksl
            // 
            this.coldsMaterialL3DataTablefljcksl.Caption = "fljcksl";
            this.coldsMaterialL3DataTablefljcksl.ColumnName = "fljcksl";
            this.coldsMaterialL3DataTablefljcksl.Namespace = "";
            // 
            // coldsMaterialL3DataTablepch
            // 
            this.coldsMaterialL3DataTablepch.Caption = "pch";
            this.coldsMaterialL3DataTablepch.ColumnName = "pch";
            this.coldsMaterialL3DataTablepch.Namespace = "";
            // 
            // coldsMaterialL3DataTablegzzxid
            // 
            this.coldsMaterialL3DataTablegzzxid.Caption = "gzzxid";
            this.coldsMaterialL3DataTablegzzxid.ColumnName = "gzzxid";
            this.coldsMaterialL3DataTablegzzxid.Namespace = "";
            // 
            // coldsMaterialL3DataTablegxh
            // 
            this.coldsMaterialL3DataTablegxh.Caption = "gxh";
            this.coldsMaterialL3DataTablegxh.ColumnName = "gxh";
            this.coldsMaterialL3DataTablegxh.Namespace = "";
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
            // coldsMaterialL3DataTablezyx1
            // 
            this.coldsMaterialL3DataTablezyx1.Caption = "zyx1";
            this.coldsMaterialL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsMaterialL3DataTablezyx1.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx2
            // 
            this.coldsMaterialL3DataTablezyx2.Caption = "zyx2";
            this.coldsMaterialL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsMaterialL3DataTablezyx2.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx3
            // 
            this.coldsMaterialL3DataTablezyx3.Caption = "zyx3";
            this.coldsMaterialL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsMaterialL3DataTablezyx3.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx4
            // 
            this.coldsMaterialL3DataTablezyx4.Caption = "zyx4";
            this.coldsMaterialL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsMaterialL3DataTablezyx4.Namespace = "";
            // 
            // coldsMaterialL3DataTablezyx5
            // 
            this.coldsMaterialL3DataTablezyx5.Caption = "zyx5";
            this.coldsMaterialL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsMaterialL3DataTablezyx5.Namespace = "";
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
            // coldsMaterialL3DataTableccostobject
            // 
            this.coldsMaterialL3DataTableccostobject.Caption = "ccostobject";
            this.coldsMaterialL3DataTableccostobject.ColumnName = "ccostobject";
            this.coldsMaterialL3DataTableccostobject.Namespace = "";
            // 
            // coldsMaterialL3DataTableflrq
            // 
            this.coldsMaterialL3DataTableflrq.Caption = "flrq";
            this.coldsMaterialL3DataTableflrq.ColumnName = "flrq";
            this.coldsMaterialL3DataTableflrq.Namespace = "";
            // 
            // coldsMaterialL3DataTablepk_moid
            // 
            this.coldsMaterialL3DataTablepk_moid.Caption = "pk_moid";
            this.coldsMaterialL3DataTablepk_moid.ColumnName = "pk_moid";
            this.coldsMaterialL3DataTablepk_moid.Namespace = "";
            // 
            // coldsMaterialL3DataTableObjectID
            // 
            this.coldsMaterialL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.Namespace = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 127);
            this.groupBox1.TabIndex = 0;
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
            this.scddhDataGridViewTextBoxColumn,
            this.zdridDataGridViewTextBoxColumn,
            this.pchDataGridViewTextBoxColumn,
            this.wlbmidDataGridViewTextBoxColumn,
            this.jldwidDataGridViewTextBoxColumn,
            this.ylbmidDataGridViewTextBoxColumn,
            this.bljhdhDataGridViewTextBoxColumn,
            this.freeitemvalue1DataGridViewTextBoxColumn,
            this.freeitemvalue2DataGridViewTextBoxColumn,
            this.freeitemvalue3DataGridViewTextBoxColumn,
            this.freeitemvalue4DataGridViewTextBoxColumn,
            this.freeitemvalue5DataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn,
            this.nCConfirmFlagDataGridViewTextBoxColumn,
            this.treatNoDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(3, 17);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.Size = new System.Drawing.Size(994, 107);
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
            // scddhDataGridViewTextBoxColumn
            // 
            this.scddhDataGridViewTextBoxColumn.DataPropertyName = "scddh";
            this.scddhDataGridViewTextBoxColumn.HeaderText = "生产订单号";
            this.scddhDataGridViewTextBoxColumn.Name = "scddhDataGridViewTextBoxColumn";
            this.scddhDataGridViewTextBoxColumn.ReadOnly = true;
            this.scddhDataGridViewTextBoxColumn.Width = 72;
            // 
            // zdridDataGridViewTextBoxColumn
            // 
            this.zdridDataGridViewTextBoxColumn.DataPropertyName = "zdrid";
            this.zdridDataGridViewTextBoxColumn.HeaderText = "操作员编号";
            this.zdridDataGridViewTextBoxColumn.Name = "zdridDataGridViewTextBoxColumn";
            this.zdridDataGridViewTextBoxColumn.ReadOnly = true;
            this.zdridDataGridViewTextBoxColumn.Width = 72;
            // 
            // pchDataGridViewTextBoxColumn
            // 
            this.pchDataGridViewTextBoxColumn.DataPropertyName = "pch";
            this.pchDataGridViewTextBoxColumn.HeaderText = "生产批次号";
            this.pchDataGridViewTextBoxColumn.Name = "pchDataGridViewTextBoxColumn";
            this.pchDataGridViewTextBoxColumn.ReadOnly = true;
            this.pchDataGridViewTextBoxColumn.Width = 72;
            // 
            // wlbmidDataGridViewTextBoxColumn
            // 
            this.wlbmidDataGridViewTextBoxColumn.DataPropertyName = "wlbmid";
            this.wlbmidDataGridViewTextBoxColumn.DataSource = this.dsMaterID;
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
            // jldwidDataGridViewTextBoxColumn
            // 
            this.jldwidDataGridViewTextBoxColumn.DataPropertyName = "jldwid";
            this.jldwidDataGridViewTextBoxColumn.HeaderText = "计量单位id";
            this.jldwidDataGridViewTextBoxColumn.Name = "jldwidDataGridViewTextBoxColumn";
            this.jldwidDataGridViewTextBoxColumn.ReadOnly = true;
            this.jldwidDataGridViewTextBoxColumn.Width = 72;
            // 
            // ylbmidDataGridViewTextBoxColumn
            // 
            this.ylbmidDataGridViewTextBoxColumn.DataPropertyName = "ylbmid";
            this.ylbmidDataGridViewTextBoxColumn.HeaderText = "用料部门id";
            this.ylbmidDataGridViewTextBoxColumn.Name = "ylbmidDataGridViewTextBoxColumn";
            this.ylbmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ylbmidDataGridViewTextBoxColumn.Width = 72;
            // 
            // bljhdhDataGridViewTextBoxColumn
            // 
            this.bljhdhDataGridViewTextBoxColumn.DataPropertyName = "bljhdh";
            this.bljhdhDataGridViewTextBoxColumn.HeaderText = "备料计划单号";
            this.bljhdhDataGridViewTextBoxColumn.Name = "bljhdhDataGridViewTextBoxColumn";
            this.bljhdhDataGridViewTextBoxColumn.ReadOnly = true;
            this.bljhdhDataGridViewTextBoxColumn.Width = 72;
            // 
            // freeitemvalue1DataGridViewTextBoxColumn
            // 
            this.freeitemvalue1DataGridViewTextBoxColumn.DataPropertyName = "freeitemvalue1";
            this.freeitemvalue1DataGridViewTextBoxColumn.HeaderText = "产品标准";
            this.freeitemvalue1DataGridViewTextBoxColumn.Name = "freeitemvalue1DataGridViewTextBoxColumn";
            this.freeitemvalue1DataGridViewTextBoxColumn.ReadOnly = true;
            this.freeitemvalue1DataGridViewTextBoxColumn.Width = 61;
            // 
            // freeitemvalue2DataGridViewTextBoxColumn
            // 
            this.freeitemvalue2DataGridViewTextBoxColumn.DataPropertyName = "freeitemvalue2";
            this.freeitemvalue2DataGridViewTextBoxColumn.HeaderText = "技术要求";
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
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            this.objectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn.Visible = false;
            this.objectIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // nCConfirmFlagDataGridViewTextBoxColumn
            // 
            this.nCConfirmFlagDataGridViewTextBoxColumn.DataPropertyName = "NC_Confirm_Flag";
            this.nCConfirmFlagDataGridViewTextBoxColumn.HeaderText = "确认标志";
            this.nCConfirmFlagDataGridViewTextBoxColumn.Name = "nCConfirmFlagDataGridViewTextBoxColumn";
            this.nCConfirmFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.nCConfirmFlagDataGridViewTextBoxColumn.Visible = false;
            this.nCConfirmFlagDataGridViewTextBoxColumn.Width = 61;
            // 
            // treatNoDataGridViewTextBoxColumn
            // 
            this.treatNoDataGridViewTextBoxColumn.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn.HeaderText = "处理号";
            this.treatNoDataGridViewTextBoxColumn.Name = "treatNoDataGridViewTextBoxColumn";
            this.treatNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.treatNoDataGridViewTextBoxColumn.Visible = false;
            this.treatNoDataGridViewTextBoxColumn.Width = 61;
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoLoad = true;
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
            this.coldsMainL3DataTablescddh,
            this.coldsMainL3DataTablezdrid,
            this.coldsMainL3DataTablepch,
            this.coldsMainL3DataTablewlbmid,
            this.coldsMainL3DataTablejldwid,
            this.coldsMainL3DataTableylbmid,
            this.coldsMainL3DataTablebljhdh,
            this.coldsMainL3DataTablefreeitemvalue1,
            this.coldsMainL3DataTablefreeitemvalue2,
            this.coldsMainL3DataTablefreeitemvalue3,
            this.coldsMainL3DataTablefreeitemvalue4,
            this.coldsMainL3DataTablefreeitemvalue5,
            this.coldsMainL3DataTableObjectID,
            this.coldsMainL3DataTableNC_Confirm_Flag,
            this.coldsMainL3DataTableTreatNo,
            this.coldsMainL3DataTablezdrq});
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
            // coldsMainL3DataTablescddh
            // 
            this.coldsMainL3DataTablescddh.Caption = "scddh";
            this.coldsMainL3DataTablescddh.ColumnName = "scddh";
            this.coldsMainL3DataTablescddh.Namespace = "";
            // 
            // coldsMainL3DataTablezdrid
            // 
            this.coldsMainL3DataTablezdrid.Caption = "zdrid";
            this.coldsMainL3DataTablezdrid.ColumnName = "zdrid";
            this.coldsMainL3DataTablezdrid.Namespace = "";
            // 
            // coldsMainL3DataTablepch
            // 
            this.coldsMainL3DataTablepch.Caption = "pch";
            this.coldsMainL3DataTablepch.ColumnName = "pch";
            this.coldsMainL3DataTablepch.Namespace = "";
            // 
            // coldsMainL3DataTablewlbmid
            // 
            this.coldsMainL3DataTablewlbmid.Caption = "wlbmid";
            this.coldsMainL3DataTablewlbmid.ColumnName = "wlbmid";
            this.coldsMainL3DataTablewlbmid.Namespace = "";
            // 
            // coldsMainL3DataTablejldwid
            // 
            this.coldsMainL3DataTablejldwid.Caption = "jldwid";
            this.coldsMainL3DataTablejldwid.ColumnName = "jldwid";
            this.coldsMainL3DataTablejldwid.Namespace = "";
            // 
            // coldsMainL3DataTableylbmid
            // 
            this.coldsMainL3DataTableylbmid.Caption = "ylbmid";
            this.coldsMainL3DataTableylbmid.ColumnName = "ylbmid";
            this.coldsMainL3DataTableylbmid.Namespace = "";
            // 
            // coldsMainL3DataTablebljhdh
            // 
            this.coldsMainL3DataTablebljhdh.Caption = "bljhdh";
            this.coldsMainL3DataTablebljhdh.ColumnName = "bljhdh";
            this.coldsMainL3DataTablebljhdh.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue1
            // 
            this.coldsMainL3DataTablefreeitemvalue1.Caption = "freeitemvalue1";
            this.coldsMainL3DataTablefreeitemvalue1.ColumnName = "freeitemvalue1";
            this.coldsMainL3DataTablefreeitemvalue1.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue2
            // 
            this.coldsMainL3DataTablefreeitemvalue2.Caption = "freeitemvalue2";
            this.coldsMainL3DataTablefreeitemvalue2.ColumnName = "freeitemvalue2";
            this.coldsMainL3DataTablefreeitemvalue2.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue3
            // 
            this.coldsMainL3DataTablefreeitemvalue3.Caption = "freeitemvalue3";
            this.coldsMainL3DataTablefreeitemvalue3.ColumnName = "freeitemvalue3";
            this.coldsMainL3DataTablefreeitemvalue3.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue4
            // 
            this.coldsMainL3DataTablefreeitemvalue4.Caption = "freeitemvalue4";
            this.coldsMainL3DataTablefreeitemvalue4.ColumnName = "freeitemvalue4";
            this.coldsMainL3DataTablefreeitemvalue4.Namespace = "";
            // 
            // coldsMainL3DataTablefreeitemvalue5
            // 
            this.coldsMainL3DataTablefreeitemvalue5.Caption = "freeitemvalue5";
            this.coldsMainL3DataTablefreeitemvalue5.ColumnName = "freeitemvalue5";
            this.coldsMainL3DataTablefreeitemvalue5.Namespace = "";
            // 
            // coldsMainL3DataTableObjectID
            // 
            this.coldsMainL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMainL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMainL3DataTableObjectID.Namespace = "";
            // 
            // coldsMainL3DataTableNC_Confirm_Flag
            // 
            this.coldsMainL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsMainL3DataTableTreatNo
            // 
            this.coldsMainL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsMainL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsMainL3DataTableTreatNo.Namespace = "";
            // 
            // coldsMainL3DataTablezdrq
            // 
            this.coldsMainL3DataTablezdrq.Caption = "zdrq";
            this.coldsMainL3DataTablezdrq.ColumnName = "zdrq";
            this.coldsMainL3DataTablezdrq.Namespace = "";
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = this.Adapter;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = "SendAddMaterialsInfor";
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
            this.l3CommandParameter2.SourceProperty = "";
            this.l3CommandParameter2.TargetObject = this.dsMain;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // dsLog
            // 
            this.dsLog.AutoLoad = true;
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
            this.dsLog.SubscribeTarget = "";
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsLog.UpdateEvent = "";
            this.dsLog.UpdateMethod = "";
            this.dsLog.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableGUID,
            this.coll3DataSet1L3DataTableName,
            this.coll3DataSet1L3DataTableHeatID,
            this.coll3DataSet1L3DataTableBillType,
            this.coll3DataSet1L3DataTableFlag,
            this.coll3DataSet1L3DataTableRemark,
            this.coll3DataSet1L3DataTableCreateTime,
            this.coll3DataSet1L3DataTableOther1,
            this.coll3DataSet1L3DataTableOther2,
            this.coll3DataSet1L3DataTableOther3});
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
            // coll3DataSet1L3DataTableHeatID
            // 
            this.coll3DataSet1L3DataTableHeatID.Caption = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.ColumnName = "HeatID";
            this.coll3DataSet1L3DataTableHeatID.Namespace = "";
            // 
            // coll3DataSet1L3DataTableBillType
            // 
            this.coll3DataSet1L3DataTableBillType.Caption = "BillType";
            this.coll3DataSet1L3DataTableBillType.ColumnName = "BillType";
            this.coll3DataSet1L3DataTableBillType.Namespace = "";
            // 
            // coll3DataSet1L3DataTableFlag
            // 
            this.coll3DataSet1L3DataTableFlag.Caption = "Flag";
            this.coll3DataSet1L3DataTableFlag.ColumnName = "Flag";
            this.coll3DataSet1L3DataTableFlag.Namespace = "";
            // 
            // coll3DataSet1L3DataTableRemark
            // 
            this.coll3DataSet1L3DataTableRemark.Caption = "Remark";
            this.coll3DataSet1L3DataTableRemark.ColumnName = "Remark";
            this.coll3DataSet1L3DataTableRemark.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCreateTime
            // 
            this.coll3DataSet1L3DataTableCreateTime.Caption = "CreateTime";
            this.coll3DataSet1L3DataTableCreateTime.ColumnName = "CreateTime";
            this.coll3DataSet1L3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coll3DataSet1L3DataTableCreateTime.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther1
            // 
            this.coll3DataSet1L3DataTableOther1.Caption = "Other1";
            this.coll3DataSet1L3DataTableOther1.ColumnName = "Other1";
            this.coll3DataSet1L3DataTableOther1.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther2
            // 
            this.coll3DataSet1L3DataTableOther2.Caption = "Other2";
            this.coll3DataSet1L3DataTableOther2.ColumnName = "Other2";
            this.coll3DataSet1L3DataTableOther2.Namespace = "";
            // 
            // coll3DataSet1L3DataTableOther3
            // 
            this.coll3DataSet1L3DataTableOther3.Caption = "Other3";
            this.coll3DataSet1L3DataTableOther3.ColumnName = "Other3";
            this.coll3DataSet1L3DataTableOther3.Namespace = "";
            // 
            // MeterialInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnM);
            this.Controls.Add(this.tSp1);
            this.Name = "MeterialInfoFrm";
            this.TabText = "钢坯投料电文补发";
            this.Text = "钢坯投料电文补发";
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnUpdateSend;
        private System.Windows.Forms.ToolStripButton btnAddSend;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvMaterial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvMain;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3DataSet dsMaterial;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableFlag;
        private System.Data.DataColumn coldsMainL3DataTablescddh;
        private System.Data.DataColumn coldsMainL3DataTablezdrid;
        private System.Data.DataColumn coldsMainL3DataTablepch;
        private System.Data.DataColumn coldsMainL3DataTablewlbmid;
        private System.Data.DataColumn coldsMainL3DataTablejldwid;
        private System.Data.DataColumn coldsMainL3DataTableylbmid;
        private System.Data.DataColumn coldsMainL3DataTablebljhdh;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue1;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue2;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue3;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue4;
        private System.Data.DataColumn coldsMainL3DataTablefreeitemvalue5;
        private System.Data.DataColumn coldsMainL3DataTableObjectID;
        private System.Data.DataColumn coldsMainL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsMainL3DataTableTreatNo;
        private System.Data.DataTable schemadsMaterial;
        private System.Data.DataColumn coldsMaterialL3DataTablekgyid;
        private System.Data.DataColumn coldsMaterialL3DataTableckckid;
        private System.Data.DataColumn coldsMaterialL3DataTableckckbm;
        private System.Data.DataColumn coldsMaterialL3DataTablewlbmid;
        private System.Data.DataColumn coldsMaterialL3DataTablejldwid;
        private System.Data.DataColumn coldsMaterialL3DataTablefjldwid;
        private System.Data.DataColumn coldsMaterialL3DataTableljcksl;
        private System.Data.DataColumn coldsMaterialL3DataTablefljcksl;
        private System.Data.DataColumn coldsMaterialL3DataTablepch;
        private System.Data.DataColumn coldsMaterialL3DataTablegzzxid;
        private System.Data.DataColumn coldsMaterialL3DataTablegxh;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy1;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy2;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy3;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy4;
        private System.Data.DataColumn coldsMaterialL3DataTablezdy5;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx1;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx2;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx3;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx4;
        private System.Data.DataColumn coldsMaterialL3DataTablezyx5;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_corp;
        private System.Data.DataColumn coldsMaterialL3DataTablegcbm;
        private System.Data.DataColumn coldsMaterialL3DataTableccostobject;
        private System.Data.DataColumn coldsMaterialL3DataTableflrq;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_moid;
        private System.Data.DataColumn coldsMaterialL3DataTableObjectID;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsMaterial;
        private AppSvrHMI.L3Command cmdMain;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataColumn coldsMainL3DataTablezdrq;
        private AppSvrHMI.L3DataSet dsLog;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableGUID;
        private System.Data.DataColumn coll3DataSet1L3DataTableName;
        private System.Data.DataColumn coll3DataSet1L3DataTableHeatID;
        private System.Data.DataColumn coll3DataSet1L3DataTableBillType;
        private System.Data.DataColumn coll3DataSet1L3DataTableFlag;
        private System.Data.DataColumn coll3DataSet1L3DataTableRemark;
        private System.Data.DataColumn coll3DataSet1L3DataTableCreateTime;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther1;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther2;
        private System.Data.DataColumn coll3DataSet1L3DataTableOther3;
        private AppSvrHMI.L3DataSet dsMaterID;
        private System.Data.DataTable schemadsMaterID;
        private AppSvrHMI.L3DataSet dsStore;
        private System.Data.DataTable schemadsStore;
        private System.Data.DataColumn coldsStoreL3DataTablePk_Stock;
        private System.Data.DataColumn coldsStoreL3DataTableStock_Name;
        private AppSvrHMI.L3DataSet dsCenter;
        private System.Data.DataTable schemadsCenter;
        private System.Data.DataColumn coldsCenterL3DataTablePk_Center;
        private System.Data.DataColumn coldsCenterL3DataTableCenter_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ckckidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckckbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wlbmidDataGridViewTextBoxColumn1;
        private System.Data.DataColumn coldsMaterIDL3DataTablePk_Material_Bas;
        private System.Data.DataColumn coldsMaterIDL3DataTableMaterial_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn jldwidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjldwidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ljckslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fljckslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn gzzxidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gxhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkcorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccostobjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkmoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scddhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wlbmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jldwidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ylbmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bljhdhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeitemvalue5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCConfirmFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn;
    }
}