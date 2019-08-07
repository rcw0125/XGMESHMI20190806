namespace NCTelDataMag
{
    partial class QualityInforFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QualityInforFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateSend = new System.Windows.Forms.ToolStripButton();
            this.btnAddSend = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInStoreUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnInStoreAdd = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvMaterial2 = new System.Windows.Forms.DataGridView();
            this.cbaseidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcheckdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsamplecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckitemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsItem = new AppSvrHMI.L3DataSet();
            this.schemadsItem = new System.Data.DataTable();
            this.coldsItemL3DataTablePk_Check_Item = new System.Data.DataColumn();
            this.coldsItemL3DataTableCheck_Item_Name = new System.Data.DataColumn();
            this.ccheckstandardidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icheckstandardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cresultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMaterial2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterial2 = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial2 = new System.Data.DataTable();
            this.coldsMaterial2L3DataTablecbaseid = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTabledcheckdate = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTablevsamplecode = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTablennum = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTableccheckitemid = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTableccheckstandardid = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTableicheckstandard = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTablecresult = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTableccheckerid = new System.Data.DataColumn();
            this.coldsMaterial2L3DataTableObjectID = new System.Data.DataColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvMaterial1 = new System.Windows.Forms.DataGridView();
            this.pk_stordoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStore = new AppSvrHMI.L3DataSet();
            this.schemadsStore = new System.Data.DataTable();
            this.coldsStoreL3DataTablePk_Stock = new System.Data.DataColumn();
            this.coldsStoreL3DataTableStock_Name = new System.Data.DataColumn();
            this.vinvbatchcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckbillb1idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dproducedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbaseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsMaterID1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterialID = new AppSvrHMI.L3DataSet();
            this.schemadsMaterialID = new System.Data.DataTable();
            this.coldsMaterialIDL3DataTablePk_Material_Bas = new System.Data.DataColumn();
            this.coldsMaterialIDL3DataTableMaterial_Name = new System.Data.DataColumn();
            this.cchgbasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsMaterID2 = new System.Windows.Forms.BindingSource(this.components);
            this.cchgassistunitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdef1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdef2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdef3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdef4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vdef5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nassistnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcheckinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bqualifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckstatecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckstatenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vmemoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckstatebidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsJudge = new AppSvrHMI.L3DataSet();
            this.schemadsJudge = new System.Data.DataTable();
            this.coldsJudgeL3DataTablePk_Qua_Grade = new System.Data.DataColumn();
            this.coldsJudgeL3DataTableQua_Grade_Code = new System.Data.DataColumn();
            this.objectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMaterial1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterial1 = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial = new System.Data.DataTable();
            this.coldsMaterialL3DataTablevinvbatchcode = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccheckbill_b1id = new System.Data.DataColumn();
            this.coldsMaterialL3DataTabledproducedate = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablecbaseid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablecchgbasid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablecchgassistunitid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevdef1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevdef2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevdef3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevdef4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevdef5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablennum = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablenassistnum = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablebcheckin = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablebqualified = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablebchange = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccheckstatecode = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccheckstatename = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevmemo = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccheckstate_bid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableObjectID = new System.Data.DataColumn();
            this.coldsMaterial1L3DataTablepk_stordoc = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scddhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vproductbatchcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcheckbillcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcompcheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbatchcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpraydeptidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cprayeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creporteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpraydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nchecknumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nassistchecknumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cassistunitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cstoreorganizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpraycorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckbillidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCConfirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTablescddh = new System.Data.DataColumn();
            this.coldsMainL3DataTablevproductbatchcode = new System.Data.DataColumn();
            this.coldsMainL3DataTablevcheckbillcode = new System.Data.DataColumn();
            this.coldsMainL3DataTablebcompcheck = new System.Data.DataColumn();
            this.coldsMainL3DataTablevbatchcode = new System.Data.DataColumn();
            this.coldsMainL3DataTablecpraydeptid = new System.Data.DataColumn();
            this.coldsMainL3DataTablecprayerid = new System.Data.DataColumn();
            this.coldsMainL3DataTablecreporterid = new System.Data.DataColumn();
            this.coldsMainL3DataTabledpraydate = new System.Data.DataColumn();
            this.coldsMainL3DataTablenchecknum = new System.Data.DataColumn();
            this.coldsMainL3DataTablenassistchecknum = new System.Data.DataColumn();
            this.coldsMainL3DataTablecassistunitid = new System.Data.DataColumn();
            this.coldsMainL3DataTablecstoreorganization = new System.Data.DataColumn();
            this.coldsMainL3DataTablecpraycorp = new System.Data.DataColumn();
            this.coldsMainL3DataTableccheckbillid = new System.Data.DataColumn();
            this.coldsMainL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableObjectID = new System.Data.DataColumn();
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
            this.cmbType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
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
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.tSp1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial1)).BeginInit();
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
            this.btnAddSend,
            this.toolStripSeparator1,
            this.btnInStoreUpdate,
            this.btnInStoreAdd});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(731, 43);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnInStoreUpdate
            // 
            this.btnInStoreUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnInStoreUpdate.Image")));
            this.btnInStoreUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInStoreUpdate.Name = "btnInStoreUpdate";
            this.btnInStoreUpdate.Size = new System.Drawing.Size(125, 40);
            this.btnInStoreUpdate.Text = "Update入库补发";
            this.btnInStoreUpdate.Click += new System.EventHandler(this.btnInStoreUpdate_Click);
            // 
            // btnInStoreAdd
            // 
            this.btnInStoreAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnInStoreAdd.Image")));
            this.btnInStoreAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInStoreAdd.Name = "btnInStoreAdd";
            this.btnInStoreAdd.Size = new System.Drawing.Size(107, 40);
            this.btnInStoreAdd.Text = "Add入库补发";
            this.btnInStoreAdd.Visible = false;
            this.btnInStoreAdd.Click += new System.EventHandler(this.btnInStoreAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bnM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 426);
            this.panel1.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dvMaterial2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 157);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "表体2数据";
            // 
            // dvMaterial2
            // 
            this.dvMaterial2.AllowUserToAddRows = false;
            this.dvMaterial2.AutoGenerateColumns = false;
            this.dvMaterial2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMaterial2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMaterial2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMaterial2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMaterial2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbaseidDataGridViewTextBoxColumn1,
            this.dcheckdateDataGridViewTextBoxColumn,
            this.vsamplecodeDataGridViewTextBoxColumn,
            this.nnumDataGridViewTextBoxColumn1,
            this.ccheckitemidDataGridViewTextBoxColumn,
            this.ccheckstandardidDataGridViewTextBoxColumn,
            this.icheckstandardDataGridViewTextBoxColumn,
            this.cresultDataGridViewTextBoxColumn,
            this.ccheckeridDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn2});
            this.dvMaterial2.DataSource = this.bsMaterial2;
            this.dvMaterial2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMaterial2.Location = new System.Drawing.Point(3, 17);
            this.dvMaterial2.Name = "dvMaterial2";
            this.dvMaterial2.ReadOnly = true;
            this.dvMaterial2.RowTemplate.Height = 23;
            this.dvMaterial2.Size = new System.Drawing.Size(725, 137);
            this.dvMaterial2.TabIndex = 0;
            this.dvMaterial2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMaterial2_DataError);
            // 
            // cbaseidDataGridViewTextBoxColumn1
            // 
            this.cbaseidDataGridViewTextBoxColumn1.DataPropertyName = "cbaseid";
            this.cbaseidDataGridViewTextBoxColumn1.HeaderText = "检验产品";
            this.cbaseidDataGridViewTextBoxColumn1.Name = "cbaseidDataGridViewTextBoxColumn1";
            this.cbaseidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cbaseidDataGridViewTextBoxColumn1.Width = 61;
            // 
            // dcheckdateDataGridViewTextBoxColumn
            // 
            this.dcheckdateDataGridViewTextBoxColumn.DataPropertyName = "dcheckdate";
            this.dcheckdateDataGridViewTextBoxColumn.HeaderText = "检验日期";
            this.dcheckdateDataGridViewTextBoxColumn.Name = "dcheckdateDataGridViewTextBoxColumn";
            this.dcheckdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dcheckdateDataGridViewTextBoxColumn.Width = 61;
            // 
            // vsamplecodeDataGridViewTextBoxColumn
            // 
            this.vsamplecodeDataGridViewTextBoxColumn.DataPropertyName = "vsamplecode";
            this.vsamplecodeDataGridViewTextBoxColumn.HeaderText = "样本号";
            this.vsamplecodeDataGridViewTextBoxColumn.Name = "vsamplecodeDataGridViewTextBoxColumn";
            this.vsamplecodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vsamplecodeDataGridViewTextBoxColumn.Width = 61;
            // 
            // nnumDataGridViewTextBoxColumn1
            // 
            this.nnumDataGridViewTextBoxColumn1.DataPropertyName = "nnum";
            this.nnumDataGridViewTextBoxColumn1.HeaderText = "检验数量";
            this.nnumDataGridViewTextBoxColumn1.Name = "nnumDataGridViewTextBoxColumn1";
            this.nnumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nnumDataGridViewTextBoxColumn1.Width = 61;
            // 
            // ccheckitemidDataGridViewTextBoxColumn
            // 
            this.ccheckitemidDataGridViewTextBoxColumn.DataPropertyName = "ccheckitemid";
            this.ccheckitemidDataGridViewTextBoxColumn.DataSource = this.dsItem;
            this.ccheckitemidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Check_Item_Name";
            this.ccheckitemidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ccheckitemidDataGridViewTextBoxColumn.HeaderText = "检验项目";
            this.ccheckitemidDataGridViewTextBoxColumn.Name = "ccheckitemidDataGridViewTextBoxColumn";
            this.ccheckitemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckitemidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ccheckitemidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ccheckitemidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Check_Item";
            this.ccheckitemidDataGridViewTextBoxColumn.Width = 61;
            // 
            // dsItem
            // 
            this.dsItem.AutoSubscribe = false;
            this.dsItem.DataSetName = "L3DataSet";
            this.dsItem.DeleteMethod = "";
            this.dsItem.InsertMethod = "";
            this.dsItem.L3DataAdapter = this.Adapter;
            this.dsItem.LoadEvent = "";
            this.dsItem.LoadTrigger = null;
            this.dsItem.RefreshValve = 1000;
            this.dsItem.SourceCommand = null;
            this.dsItem.SourceCondition = "";
            this.dsItem.SourceMethod = "";
            this.dsItem.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsItem.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Check_Item_Infor";
            this.dsItem.SubscribeTarget = "";
            this.dsItem.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsItem});
            this.dsItem.UpdateEvent = "";
            this.dsItem.UpdateMethod = "";
            this.dsItem.UpdateTrigger = null;
            // 
            // schemadsItem
            // 
            this.schemadsItem.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsItemL3DataTablePk_Check_Item,
            this.coldsItemL3DataTableCheck_Item_Name});
            this.schemadsItem.TableName = "L3DataTable";
            // 
            // coldsItemL3DataTablePk_Check_Item
            // 
            this.coldsItemL3DataTablePk_Check_Item.Caption = "Pk_Check_Item";
            this.coldsItemL3DataTablePk_Check_Item.ColumnName = "Pk_Check_Item";
            this.coldsItemL3DataTablePk_Check_Item.Namespace = "";
            // 
            // coldsItemL3DataTableCheck_Item_Name
            // 
            this.coldsItemL3DataTableCheck_Item_Name.Caption = "Check_Item_Name";
            this.coldsItemL3DataTableCheck_Item_Name.ColumnName = "Check_Item_Name";
            this.coldsItemL3DataTableCheck_Item_Name.Namespace = "";
            // 
            // ccheckstandardidDataGridViewTextBoxColumn
            // 
            this.ccheckstandardidDataGridViewTextBoxColumn.DataPropertyName = "ccheckstandardid";
            this.ccheckstandardidDataGridViewTextBoxColumn.HeaderText = "检验标准主键";
            this.ccheckstandardidDataGridViewTextBoxColumn.Name = "ccheckstandardidDataGridViewTextBoxColumn";
            this.ccheckstandardidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckstandardidDataGridViewTextBoxColumn.Width = 72;
            // 
            // icheckstandardDataGridViewTextBoxColumn
            // 
            this.icheckstandardDataGridViewTextBoxColumn.DataPropertyName = "icheckstandard";
            this.icheckstandardDataGridViewTextBoxColumn.HeaderText = "检验标准类型";
            this.icheckstandardDataGridViewTextBoxColumn.Name = "icheckstandardDataGridViewTextBoxColumn";
            this.icheckstandardDataGridViewTextBoxColumn.ReadOnly = true;
            this.icheckstandardDataGridViewTextBoxColumn.Width = 72;
            // 
            // cresultDataGridViewTextBoxColumn
            // 
            this.cresultDataGridViewTextBoxColumn.DataPropertyName = "cresult";
            this.cresultDataGridViewTextBoxColumn.HeaderText = "检验值";
            this.cresultDataGridViewTextBoxColumn.Name = "cresultDataGridViewTextBoxColumn";
            this.cresultDataGridViewTextBoxColumn.ReadOnly = true;
            this.cresultDataGridViewTextBoxColumn.Width = 61;
            // 
            // ccheckeridDataGridViewTextBoxColumn
            // 
            this.ccheckeridDataGridViewTextBoxColumn.DataPropertyName = "ccheckerid";
            this.ccheckeridDataGridViewTextBoxColumn.HeaderText = "检验员";
            this.ccheckeridDataGridViewTextBoxColumn.Name = "ccheckeridDataGridViewTextBoxColumn";
            this.ccheckeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckeridDataGridViewTextBoxColumn.Width = 61;
            // 
            // objectIDDataGridViewTextBoxColumn2
            // 
            this.objectIDDataGridViewTextBoxColumn2.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn2.HeaderText = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn2.Name = "objectIDDataGridViewTextBoxColumn2";
            this.objectIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn2.Visible = false;
            this.objectIDDataGridViewTextBoxColumn2.Width = 78;
            // 
            // bsMaterial2
            // 
            this.bsMaterial2.DataMember = "L3DataTable";
            this.bsMaterial2.DataSource = this.dsMaterial2;
            // 
            // dsMaterial2
            // 
            this.dsMaterial2.AutoSubscribe = false;
            this.dsMaterial2.DataSetName = "L3DataSet";
            this.dsMaterial2.DeleteMethod = "";
            this.dsMaterial2.InsertMethod = "";
            this.dsMaterial2.L3DataAdapter = null;
            this.dsMaterial2.LoadEvent = "";
            this.dsMaterial2.LoadTrigger = null;
            this.dsMaterial2.RefreshValve = 1000;
            this.dsMaterial2.SourceCommand = null;
            this.dsMaterial2.SourceCondition = "";
            this.dsMaterial2.SourceMethod = "";
            this.dsMaterial2.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMaterial2.SourceURI = "";
            this.dsMaterial2.SubscribeTarget = null;
            this.dsMaterial2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterial2});
            this.dsMaterial2.UpdateEvent = "";
            this.dsMaterial2.UpdateMethod = "";
            this.dsMaterial2.UpdateTrigger = null;
            // 
            // schemadsMaterial2
            // 
            this.schemadsMaterial2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterial2L3DataTablecbaseid,
            this.coldsMaterial2L3DataTabledcheckdate,
            this.coldsMaterial2L3DataTablevsamplecode,
            this.coldsMaterial2L3DataTablennum,
            this.coldsMaterial2L3DataTableccheckitemid,
            this.coldsMaterial2L3DataTableccheckstandardid,
            this.coldsMaterial2L3DataTableicheckstandard,
            this.coldsMaterial2L3DataTablecresult,
            this.coldsMaterial2L3DataTableccheckerid,
            this.coldsMaterial2L3DataTableObjectID});
            this.schemadsMaterial2.TableName = "L3DataTable";
            // 
            // coldsMaterial2L3DataTablecbaseid
            // 
            this.coldsMaterial2L3DataTablecbaseid.Caption = "cbaseid";
            this.coldsMaterial2L3DataTablecbaseid.ColumnName = "cbaseid";
            this.coldsMaterial2L3DataTablecbaseid.Namespace = "";
            // 
            // coldsMaterial2L3DataTabledcheckdate
            // 
            this.coldsMaterial2L3DataTabledcheckdate.Caption = "dcheckdate";
            this.coldsMaterial2L3DataTabledcheckdate.ColumnName = "dcheckdate";
            this.coldsMaterial2L3DataTabledcheckdate.Namespace = "";
            // 
            // coldsMaterial2L3DataTablevsamplecode
            // 
            this.coldsMaterial2L3DataTablevsamplecode.Caption = "vsamplecode";
            this.coldsMaterial2L3DataTablevsamplecode.ColumnName = "vsamplecode";
            this.coldsMaterial2L3DataTablevsamplecode.Namespace = "";
            // 
            // coldsMaterial2L3DataTablennum
            // 
            this.coldsMaterial2L3DataTablennum.Caption = "nnum";
            this.coldsMaterial2L3DataTablennum.ColumnName = "nnum";
            this.coldsMaterial2L3DataTablennum.Namespace = "";
            // 
            // coldsMaterial2L3DataTableccheckitemid
            // 
            this.coldsMaterial2L3DataTableccheckitemid.Caption = "ccheckitemid";
            this.coldsMaterial2L3DataTableccheckitemid.ColumnName = "ccheckitemid";
            this.coldsMaterial2L3DataTableccheckitemid.Namespace = "";
            // 
            // coldsMaterial2L3DataTableccheckstandardid
            // 
            this.coldsMaterial2L3DataTableccheckstandardid.Caption = "ccheckstandardid";
            this.coldsMaterial2L3DataTableccheckstandardid.ColumnName = "ccheckstandardid";
            this.coldsMaterial2L3DataTableccheckstandardid.Namespace = "";
            // 
            // coldsMaterial2L3DataTableicheckstandard
            // 
            this.coldsMaterial2L3DataTableicheckstandard.Caption = "icheckstandard";
            this.coldsMaterial2L3DataTableicheckstandard.ColumnName = "icheckstandard";
            this.coldsMaterial2L3DataTableicheckstandard.Namespace = "";
            // 
            // coldsMaterial2L3DataTablecresult
            // 
            this.coldsMaterial2L3DataTablecresult.Caption = "cresult";
            this.coldsMaterial2L3DataTablecresult.ColumnName = "cresult";
            this.coldsMaterial2L3DataTablecresult.Namespace = "";
            // 
            // coldsMaterial2L3DataTableccheckerid
            // 
            this.coldsMaterial2L3DataTableccheckerid.Caption = "ccheckerid";
            this.coldsMaterial2L3DataTableccheckerid.ColumnName = "ccheckerid";
            this.coldsMaterial2L3DataTableccheckerid.Namespace = "";
            // 
            // coldsMaterial2L3DataTableObjectID
            // 
            this.coldsMaterial2L3DataTableObjectID.Caption = "ObjectID";
            this.coldsMaterial2L3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMaterial2L3DataTableObjectID.Namespace = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvMaterial1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 144);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "表体1数据";
            // 
            // dvMaterial1
            // 
            this.dvMaterial1.AllowUserToAddRows = false;
            this.dvMaterial1.AutoGenerateColumns = false;
            this.dvMaterial1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvMaterial1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvMaterial1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvMaterial1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMaterial1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pk_stordoc,
            this.vinvbatchcodeDataGridViewTextBoxColumn,
            this.ccheckbillb1idDataGridViewTextBoxColumn,
            this.dproducedateDataGridViewTextBoxColumn,
            this.cbaseidDataGridViewTextBoxColumn,
            this.cchgbasidDataGridViewTextBoxColumn,
            this.cchgassistunitidDataGridViewTextBoxColumn,
            this.vdef1DataGridViewTextBoxColumn,
            this.vdef2DataGridViewTextBoxColumn,
            this.vdef3DataGridViewTextBoxColumn,
            this.vdef4DataGridViewTextBoxColumn,
            this.vdef5DataGridViewTextBoxColumn,
            this.vfree1DataGridViewTextBoxColumn,
            this.vfree2DataGridViewTextBoxColumn,
            this.vfree3DataGridViewTextBoxColumn,
            this.vfree4DataGridViewTextBoxColumn,
            this.vfree5DataGridViewTextBoxColumn,
            this.nnumDataGridViewTextBoxColumn,
            this.nassistnumDataGridViewTextBoxColumn,
            this.bcheckinDataGridViewTextBoxColumn,
            this.bqualifiedDataGridViewTextBoxColumn,
            this.bchangeDataGridViewTextBoxColumn,
            this.ccheckstatecodeDataGridViewTextBoxColumn,
            this.ccheckstatenameDataGridViewTextBoxColumn,
            this.vmemoDataGridViewTextBoxColumn,
            this.ccheckstatebidDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn1});
            this.dvMaterial1.DataSource = this.bsMaterial1;
            this.dvMaterial1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMaterial1.Location = new System.Drawing.Point(3, 17);
            this.dvMaterial1.Name = "dvMaterial1";
            this.dvMaterial1.ReadOnly = true;
            this.dvMaterial1.RowTemplate.Height = 23;
            this.dvMaterial1.Size = new System.Drawing.Size(725, 124);
            this.dvMaterial1.TabIndex = 0;
            this.dvMaterial1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMaterial2_DataError);
            // 
            // pk_stordoc
            // 
            this.pk_stordoc.DataPropertyName = "pk_stordoc";
            this.pk_stordoc.DataSource = this.dsStore;
            this.pk_stordoc.DisplayMember = "L3DataTable.Stock_Name";
            this.pk_stordoc.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pk_stordoc.HeaderText = "仓库";
            this.pk_stordoc.Name = "pk_stordoc";
            this.pk_stordoc.ReadOnly = true;
            this.pk_stordoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pk_stordoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pk_stordoc.ValueMember = "L3DataTable.Pk_Stock";
            this.pk_stordoc.Width = 51;
            // 
            // dsStore
            // 
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
            // vinvbatchcodeDataGridViewTextBoxColumn
            // 
            this.vinvbatchcodeDataGridViewTextBoxColumn.DataPropertyName = "vinvbatchcode";
            this.vinvbatchcodeDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.vinvbatchcodeDataGridViewTextBoxColumn.Name = "vinvbatchcodeDataGridViewTextBoxColumn";
            this.vinvbatchcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vinvbatchcodeDataGridViewTextBoxColumn.Width = 61;
            // 
            // ccheckbillb1idDataGridViewTextBoxColumn
            // 
            this.ccheckbillb1idDataGridViewTextBoxColumn.DataPropertyName = "ccheckbill_b1id";
            this.ccheckbillb1idDataGridViewTextBoxColumn.HeaderText = "质检单表体主键";
            this.ccheckbillb1idDataGridViewTextBoxColumn.Name = "ccheckbillb1idDataGridViewTextBoxColumn";
            this.ccheckbillb1idDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckbillb1idDataGridViewTextBoxColumn.Width = 83;
            // 
            // dproducedateDataGridViewTextBoxColumn
            // 
            this.dproducedateDataGridViewTextBoxColumn.DataPropertyName = "dproducedate";
            this.dproducedateDataGridViewTextBoxColumn.HeaderText = "生产日期";
            this.dproducedateDataGridViewTextBoxColumn.Name = "dproducedateDataGridViewTextBoxColumn";
            this.dproducedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dproducedateDataGridViewTextBoxColumn.Width = 61;
            // 
            // cbaseidDataGridViewTextBoxColumn
            // 
            this.cbaseidDataGridViewTextBoxColumn.DataPropertyName = "cbaseid";
            this.cbaseidDataGridViewTextBoxColumn.DataSource = this.bsMaterID1;
            this.cbaseidDataGridViewTextBoxColumn.DisplayMember = "Material_Name";
            this.cbaseidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cbaseidDataGridViewTextBoxColumn.HeaderText = "检验产品";
            this.cbaseidDataGridViewTextBoxColumn.Name = "cbaseidDataGridViewTextBoxColumn";
            this.cbaseidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cbaseidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbaseidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbaseidDataGridViewTextBoxColumn.ValueMember = "Pk_Material_Bas";
            this.cbaseidDataGridViewTextBoxColumn.Width = 61;
            // 
            // bsMaterID1
            // 
            this.bsMaterID1.DataMember = "L3DataTable";
            this.bsMaterID1.DataSource = this.dsMaterialID;
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
            this.dsMaterialID.SourceCondition = " SUBSTR (material_code, 1, 1) = '1'  OR SUBSTR (material_code, 1, 1) = '5'  OR SUBSTR (material_code, 1, 1) = '6'";
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
            // cchgbasidDataGridViewTextBoxColumn
            // 
            this.cchgbasidDataGridViewTextBoxColumn.DataPropertyName = "cchgbasid";
            this.cchgbasidDataGridViewTextBoxColumn.DataSource = this.bsMaterID2;
            this.cchgbasidDataGridViewTextBoxColumn.DisplayMember = "Material_Name";
            this.cchgbasidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cchgbasidDataGridViewTextBoxColumn.HeaderText = "改判后产品";
            this.cchgbasidDataGridViewTextBoxColumn.Name = "cchgbasidDataGridViewTextBoxColumn";
            this.cchgbasidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cchgbasidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cchgbasidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cchgbasidDataGridViewTextBoxColumn.ValueMember = "Pk_Material_Bas";
            this.cchgbasidDataGridViewTextBoxColumn.Width = 72;
            // 
            // bsMaterID2
            // 
            this.bsMaterID2.DataMember = "L3DataTable";
            this.bsMaterID2.DataSource = this.dsMaterialID;
            this.bsMaterID2.CurrentChanged += new System.EventHandler(this.bsMaterID2_CurrentChanged);
            // 
            // cchgassistunitidDataGridViewTextBoxColumn
            // 
            this.cchgassistunitidDataGridViewTextBoxColumn.DataPropertyName = "cchgassistunitid";
            this.cchgassistunitidDataGridViewTextBoxColumn.HeaderText = "改判辅计量单位id";
            this.cchgassistunitidDataGridViewTextBoxColumn.Name = "cchgassistunitidDataGridViewTextBoxColumn";
            this.cchgassistunitidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cchgassistunitidDataGridViewTextBoxColumn.Width = 83;
            // 
            // vdef1DataGridViewTextBoxColumn
            // 
            this.vdef1DataGridViewTextBoxColumn.DataPropertyName = "vdef1";
            this.vdef1DataGridViewTextBoxColumn.HeaderText = "自定义1";
            this.vdef1DataGridViewTextBoxColumn.Name = "vdef1DataGridViewTextBoxColumn";
            this.vdef1DataGridViewTextBoxColumn.ReadOnly = true;
            this.vdef1DataGridViewTextBoxColumn.Width = 61;
            // 
            // vdef2DataGridViewTextBoxColumn
            // 
            this.vdef2DataGridViewTextBoxColumn.DataPropertyName = "vdef2";
            this.vdef2DataGridViewTextBoxColumn.HeaderText = "自定义2";
            this.vdef2DataGridViewTextBoxColumn.Name = "vdef2DataGridViewTextBoxColumn";
            this.vdef2DataGridViewTextBoxColumn.ReadOnly = true;
            this.vdef2DataGridViewTextBoxColumn.Width = 61;
            // 
            // vdef3DataGridViewTextBoxColumn
            // 
            this.vdef3DataGridViewTextBoxColumn.DataPropertyName = "vdef3";
            this.vdef3DataGridViewTextBoxColumn.HeaderText = "自定义3";
            this.vdef3DataGridViewTextBoxColumn.Name = "vdef3DataGridViewTextBoxColumn";
            this.vdef3DataGridViewTextBoxColumn.ReadOnly = true;
            this.vdef3DataGridViewTextBoxColumn.Width = 61;
            // 
            // vdef4DataGridViewTextBoxColumn
            // 
            this.vdef4DataGridViewTextBoxColumn.DataPropertyName = "vdef4";
            this.vdef4DataGridViewTextBoxColumn.HeaderText = "自定义4";
            this.vdef4DataGridViewTextBoxColumn.Name = "vdef4DataGridViewTextBoxColumn";
            this.vdef4DataGridViewTextBoxColumn.ReadOnly = true;
            this.vdef4DataGridViewTextBoxColumn.Width = 61;
            // 
            // vdef5DataGridViewTextBoxColumn
            // 
            this.vdef5DataGridViewTextBoxColumn.DataPropertyName = "vdef5";
            this.vdef5DataGridViewTextBoxColumn.HeaderText = "自定义5";
            this.vdef5DataGridViewTextBoxColumn.Name = "vdef5DataGridViewTextBoxColumn";
            this.vdef5DataGridViewTextBoxColumn.ReadOnly = true;
            this.vdef5DataGridViewTextBoxColumn.Width = 61;
            // 
            // vfree1DataGridViewTextBoxColumn
            // 
            this.vfree1DataGridViewTextBoxColumn.DataPropertyName = "vfree1";
            this.vfree1DataGridViewTextBoxColumn.HeaderText = "自由项1";
            this.vfree1DataGridViewTextBoxColumn.Name = "vfree1DataGridViewTextBoxColumn";
            this.vfree1DataGridViewTextBoxColumn.ReadOnly = true;
            this.vfree1DataGridViewTextBoxColumn.Width = 61;
            // 
            // vfree2DataGridViewTextBoxColumn
            // 
            this.vfree2DataGridViewTextBoxColumn.DataPropertyName = "vfree2";
            this.vfree2DataGridViewTextBoxColumn.HeaderText = "自由项2";
            this.vfree2DataGridViewTextBoxColumn.Name = "vfree2DataGridViewTextBoxColumn";
            this.vfree2DataGridViewTextBoxColumn.ReadOnly = true;
            this.vfree2DataGridViewTextBoxColumn.Width = 61;
            // 
            // vfree3DataGridViewTextBoxColumn
            // 
            this.vfree3DataGridViewTextBoxColumn.DataPropertyName = "vfree3";
            this.vfree3DataGridViewTextBoxColumn.HeaderText = "自由项3";
            this.vfree3DataGridViewTextBoxColumn.Name = "vfree3DataGridViewTextBoxColumn";
            this.vfree3DataGridViewTextBoxColumn.ReadOnly = true;
            this.vfree3DataGridViewTextBoxColumn.Width = 61;
            // 
            // vfree4DataGridViewTextBoxColumn
            // 
            this.vfree4DataGridViewTextBoxColumn.DataPropertyName = "vfree4";
            this.vfree4DataGridViewTextBoxColumn.HeaderText = "自由项4";
            this.vfree4DataGridViewTextBoxColumn.Name = "vfree4DataGridViewTextBoxColumn";
            this.vfree4DataGridViewTextBoxColumn.ReadOnly = true;
            this.vfree4DataGridViewTextBoxColumn.Width = 61;
            // 
            // vfree5DataGridViewTextBoxColumn
            // 
            this.vfree5DataGridViewTextBoxColumn.DataPropertyName = "vfree5";
            this.vfree5DataGridViewTextBoxColumn.HeaderText = "自由项5";
            this.vfree5DataGridViewTextBoxColumn.Name = "vfree5DataGridViewTextBoxColumn";
            this.vfree5DataGridViewTextBoxColumn.ReadOnly = true;
            this.vfree5DataGridViewTextBoxColumn.Width = 61;
            // 
            // nnumDataGridViewTextBoxColumn
            // 
            this.nnumDataGridViewTextBoxColumn.DataPropertyName = "nnum";
            this.nnumDataGridViewTextBoxColumn.HeaderText = "判定数量";
            this.nnumDataGridViewTextBoxColumn.Name = "nnumDataGridViewTextBoxColumn";
            this.nnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.nnumDataGridViewTextBoxColumn.Width = 61;
            // 
            // nassistnumDataGridViewTextBoxColumn
            // 
            this.nassistnumDataGridViewTextBoxColumn.DataPropertyName = "nassistnum";
            this.nassistnumDataGridViewTextBoxColumn.HeaderText = "判定辅数量";
            this.nassistnumDataGridViewTextBoxColumn.Name = "nassistnumDataGridViewTextBoxColumn";
            this.nassistnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.nassistnumDataGridViewTextBoxColumn.Width = 72;
            // 
            // bcheckinDataGridViewTextBoxColumn
            // 
            this.bcheckinDataGridViewTextBoxColumn.DataPropertyName = "bcheckin";
            this.bcheckinDataGridViewTextBoxColumn.HeaderText = "可否入库";
            this.bcheckinDataGridViewTextBoxColumn.Name = "bcheckinDataGridViewTextBoxColumn";
            this.bcheckinDataGridViewTextBoxColumn.ReadOnly = true;
            this.bcheckinDataGridViewTextBoxColumn.Width = 61;
            // 
            // bqualifiedDataGridViewTextBoxColumn
            // 
            this.bqualifiedDataGridViewTextBoxColumn.DataPropertyName = "bqualified";
            this.bqualifiedDataGridViewTextBoxColumn.HeaderText = "是否合格品";
            this.bqualifiedDataGridViewTextBoxColumn.Name = "bqualifiedDataGridViewTextBoxColumn";
            this.bqualifiedDataGridViewTextBoxColumn.ReadOnly = true;
            this.bqualifiedDataGridViewTextBoxColumn.Width = 72;
            // 
            // bchangeDataGridViewTextBoxColumn
            // 
            this.bchangeDataGridViewTextBoxColumn.DataPropertyName = "bchange";
            this.bchangeDataGridViewTextBoxColumn.HeaderText = "是否改判";
            this.bchangeDataGridViewTextBoxColumn.Name = "bchangeDataGridViewTextBoxColumn";
            this.bchangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bchangeDataGridViewTextBoxColumn.Width = 61;
            // 
            // ccheckstatecodeDataGridViewTextBoxColumn
            // 
            this.ccheckstatecodeDataGridViewTextBoxColumn.DataPropertyName = "ccheckstatecode";
            this.ccheckstatecodeDataGridViewTextBoxColumn.HeaderText = "质量等级编码";
            this.ccheckstatecodeDataGridViewTextBoxColumn.Name = "ccheckstatecodeDataGridViewTextBoxColumn";
            this.ccheckstatecodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckstatecodeDataGridViewTextBoxColumn.Width = 72;
            // 
            // ccheckstatenameDataGridViewTextBoxColumn
            // 
            this.ccheckstatenameDataGridViewTextBoxColumn.DataPropertyName = "ccheckstatename";
            this.ccheckstatenameDataGridViewTextBoxColumn.HeaderText = "质量等级名称";
            this.ccheckstatenameDataGridViewTextBoxColumn.Name = "ccheckstatenameDataGridViewTextBoxColumn";
            this.ccheckstatenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckstatenameDataGridViewTextBoxColumn.Width = 72;
            // 
            // vmemoDataGridViewTextBoxColumn
            // 
            this.vmemoDataGridViewTextBoxColumn.DataPropertyName = "vmemo";
            this.vmemoDataGridViewTextBoxColumn.HeaderText = "不合格说明";
            this.vmemoDataGridViewTextBoxColumn.Name = "vmemoDataGridViewTextBoxColumn";
            this.vmemoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vmemoDataGridViewTextBoxColumn.Width = 72;
            // 
            // ccheckstatebidDataGridViewTextBoxColumn
            // 
            this.ccheckstatebidDataGridViewTextBoxColumn.DataPropertyName = "ccheckstate_bid";
            this.ccheckstatebidDataGridViewTextBoxColumn.DataSource = this.dsJudge;
            this.ccheckstatebidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Qua_Grade_Code";
            this.ccheckstatebidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ccheckstatebidDataGridViewTextBoxColumn.HeaderText = "质量等级主键";
            this.ccheckstatebidDataGridViewTextBoxColumn.Name = "ccheckstatebidDataGridViewTextBoxColumn";
            this.ccheckstatebidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckstatebidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ccheckstatebidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ccheckstatebidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Qua_Grade";
            this.ccheckstatebidDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsJudge
            // 
            this.dsJudge.AutoSubscribe = false;
            this.dsJudge.DataSetName = "L3DataSet";
            this.dsJudge.DeleteMethod = "";
            this.dsJudge.InsertMethod = "";
            this.dsJudge.L3DataAdapter = this.Adapter;
            this.dsJudge.LoadEvent = "";
            this.dsJudge.LoadTrigger = null;
            this.dsJudge.RefreshValve = 1000;
            this.dsJudge.SourceCommand = null;
            this.dsJudge.SourceCondition = "";
            this.dsJudge.SourceMethod = "";
            this.dsJudge.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsJudge.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Quality_Grade_Infor";
            this.dsJudge.SubscribeTarget = "";
            this.dsJudge.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsJudge});
            this.dsJudge.UpdateEvent = "";
            this.dsJudge.UpdateMethod = "";
            this.dsJudge.UpdateTrigger = null;
            // 
            // schemadsJudge
            // 
            this.schemadsJudge.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsJudgeL3DataTablePk_Qua_Grade,
            this.coldsJudgeL3DataTableQua_Grade_Code});
            this.schemadsJudge.TableName = "L3DataTable";
            // 
            // coldsJudgeL3DataTablePk_Qua_Grade
            // 
            this.coldsJudgeL3DataTablePk_Qua_Grade.Caption = "Pk_Qua_Grade";
            this.coldsJudgeL3DataTablePk_Qua_Grade.ColumnName = "Pk_Qua_Grade";
            this.coldsJudgeL3DataTablePk_Qua_Grade.Namespace = "";
            // 
            // coldsJudgeL3DataTableQua_Grade_Code
            // 
            this.coldsJudgeL3DataTableQua_Grade_Code.Caption = "Qua_Grade_Code";
            this.coldsJudgeL3DataTableQua_Grade_Code.ColumnName = "Qua_Grade_Code";
            this.coldsJudgeL3DataTableQua_Grade_Code.Namespace = "";
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
            // bsMaterial1
            // 
            this.bsMaterial1.DataMember = "L3DataTable";
            this.bsMaterial1.DataSource = this.dsMaterial1;
            // 
            // dsMaterial1
            // 
            this.dsMaterial1.AutoSubscribe = false;
            this.dsMaterial1.DataSetName = "L3DataSet";
            this.dsMaterial1.DeleteMethod = "";
            this.dsMaterial1.InsertMethod = "";
            this.dsMaterial1.L3DataAdapter = null;
            this.dsMaterial1.LoadEvent = "";
            this.dsMaterial1.LoadTrigger = null;
            this.dsMaterial1.RefreshValve = 1000;
            this.dsMaterial1.SourceCommand = null;
            this.dsMaterial1.SourceCondition = "";
            this.dsMaterial1.SourceMethod = "";
            this.dsMaterial1.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsMaterial1.SourceURI = "";
            this.dsMaterial1.SubscribeTarget = null;
            this.dsMaterial1.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterial});
            this.dsMaterial1.UpdateEvent = "";
            this.dsMaterial1.UpdateMethod = "";
            this.dsMaterial1.UpdateTrigger = null;
            // 
            // schemadsMaterial
            // 
            this.schemadsMaterial.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterialL3DataTablevinvbatchcode,
            this.coldsMaterialL3DataTableccheckbill_b1id,
            this.coldsMaterialL3DataTabledproducedate,
            this.coldsMaterialL3DataTablecbaseid,
            this.coldsMaterialL3DataTablecchgbasid,
            this.coldsMaterialL3DataTablecchgassistunitid,
            this.coldsMaterialL3DataTablevdef1,
            this.coldsMaterialL3DataTablevdef2,
            this.coldsMaterialL3DataTablevdef3,
            this.coldsMaterialL3DataTablevdef4,
            this.coldsMaterialL3DataTablevdef5,
            this.coldsMaterialL3DataTablevfree1,
            this.coldsMaterialL3DataTablevfree2,
            this.coldsMaterialL3DataTablevfree3,
            this.coldsMaterialL3DataTablevfree4,
            this.coldsMaterialL3DataTablevfree5,
            this.coldsMaterialL3DataTablennum,
            this.coldsMaterialL3DataTablenassistnum,
            this.coldsMaterialL3DataTablebcheckin,
            this.coldsMaterialL3DataTablebqualified,
            this.coldsMaterialL3DataTablebchange,
            this.coldsMaterialL3DataTableccheckstatecode,
            this.coldsMaterialL3DataTableccheckstatename,
            this.coldsMaterialL3DataTablevmemo,
            this.coldsMaterialL3DataTableccheckstate_bid,
            this.coldsMaterialL3DataTableObjectID,
            this.coldsMaterial1L3DataTablepk_stordoc});
            this.schemadsMaterial.TableName = "L3DataTable";
            // 
            // coldsMaterialL3DataTablevinvbatchcode
            // 
            this.coldsMaterialL3DataTablevinvbatchcode.Caption = "vinvbatchcode";
            this.coldsMaterialL3DataTablevinvbatchcode.ColumnName = "vinvbatchcode";
            this.coldsMaterialL3DataTablevinvbatchcode.Namespace = "";
            // 
            // coldsMaterialL3DataTableccheckbill_b1id
            // 
            this.coldsMaterialL3DataTableccheckbill_b1id.Caption = "ccheckbill_b1id";
            this.coldsMaterialL3DataTableccheckbill_b1id.ColumnName = "ccheckbill_b1id";
            this.coldsMaterialL3DataTableccheckbill_b1id.Namespace = "";
            // 
            // coldsMaterialL3DataTabledproducedate
            // 
            this.coldsMaterialL3DataTabledproducedate.Caption = "dproducedate";
            this.coldsMaterialL3DataTabledproducedate.ColumnName = "dproducedate";
            this.coldsMaterialL3DataTabledproducedate.Namespace = "";
            // 
            // coldsMaterialL3DataTablecbaseid
            // 
            this.coldsMaterialL3DataTablecbaseid.Caption = "cbaseid";
            this.coldsMaterialL3DataTablecbaseid.ColumnName = "cbaseid";
            this.coldsMaterialL3DataTablecbaseid.Namespace = "";
            // 
            // coldsMaterialL3DataTablecchgbasid
            // 
            this.coldsMaterialL3DataTablecchgbasid.Caption = "cchgbasid";
            this.coldsMaterialL3DataTablecchgbasid.ColumnName = "cchgbasid";
            this.coldsMaterialL3DataTablecchgbasid.Namespace = "";
            // 
            // coldsMaterialL3DataTablecchgassistunitid
            // 
            this.coldsMaterialL3DataTablecchgassistunitid.Caption = "cchgassistunitid";
            this.coldsMaterialL3DataTablecchgassistunitid.ColumnName = "cchgassistunitid";
            this.coldsMaterialL3DataTablecchgassistunitid.Namespace = "";
            // 
            // coldsMaterialL3DataTablevdef1
            // 
            this.coldsMaterialL3DataTablevdef1.Caption = "vdef1";
            this.coldsMaterialL3DataTablevdef1.ColumnName = "vdef1";
            this.coldsMaterialL3DataTablevdef1.Namespace = "";
            // 
            // coldsMaterialL3DataTablevdef2
            // 
            this.coldsMaterialL3DataTablevdef2.Caption = "vdef2";
            this.coldsMaterialL3DataTablevdef2.ColumnName = "vdef2";
            this.coldsMaterialL3DataTablevdef2.Namespace = "";
            // 
            // coldsMaterialL3DataTablevdef3
            // 
            this.coldsMaterialL3DataTablevdef3.Caption = "vdef3";
            this.coldsMaterialL3DataTablevdef3.ColumnName = "vdef3";
            this.coldsMaterialL3DataTablevdef3.Namespace = "";
            // 
            // coldsMaterialL3DataTablevdef4
            // 
            this.coldsMaterialL3DataTablevdef4.Caption = "vdef4";
            this.coldsMaterialL3DataTablevdef4.ColumnName = "vdef4";
            this.coldsMaterialL3DataTablevdef4.Namespace = "";
            // 
            // coldsMaterialL3DataTablevdef5
            // 
            this.coldsMaterialL3DataTablevdef5.Caption = "vdef5";
            this.coldsMaterialL3DataTablevdef5.ColumnName = "vdef5";
            this.coldsMaterialL3DataTablevdef5.Namespace = "";
            // 
            // coldsMaterialL3DataTablevfree1
            // 
            this.coldsMaterialL3DataTablevfree1.Caption = "vfree1";
            this.coldsMaterialL3DataTablevfree1.ColumnName = "vfree1";
            this.coldsMaterialL3DataTablevfree1.Namespace = "";
            // 
            // coldsMaterialL3DataTablevfree2
            // 
            this.coldsMaterialL3DataTablevfree2.Caption = "vfree2";
            this.coldsMaterialL3DataTablevfree2.ColumnName = "vfree2";
            this.coldsMaterialL3DataTablevfree2.Namespace = "";
            // 
            // coldsMaterialL3DataTablevfree3
            // 
            this.coldsMaterialL3DataTablevfree3.Caption = "vfree3";
            this.coldsMaterialL3DataTablevfree3.ColumnName = "vfree3";
            this.coldsMaterialL3DataTablevfree3.Namespace = "";
            // 
            // coldsMaterialL3DataTablevfree4
            // 
            this.coldsMaterialL3DataTablevfree4.Caption = "vfree4";
            this.coldsMaterialL3DataTablevfree4.ColumnName = "vfree4";
            this.coldsMaterialL3DataTablevfree4.Namespace = "";
            // 
            // coldsMaterialL3DataTablevfree5
            // 
            this.coldsMaterialL3DataTablevfree5.Caption = "vfree5";
            this.coldsMaterialL3DataTablevfree5.ColumnName = "vfree5";
            this.coldsMaterialL3DataTablevfree5.Namespace = "";
            // 
            // coldsMaterialL3DataTablennum
            // 
            this.coldsMaterialL3DataTablennum.Caption = "nnum";
            this.coldsMaterialL3DataTablennum.ColumnName = "nnum";
            this.coldsMaterialL3DataTablennum.Namespace = "";
            // 
            // coldsMaterialL3DataTablenassistnum
            // 
            this.coldsMaterialL3DataTablenassistnum.Caption = "nassistnum";
            this.coldsMaterialL3DataTablenassistnum.ColumnName = "nassistnum";
            this.coldsMaterialL3DataTablenassistnum.Namespace = "";
            // 
            // coldsMaterialL3DataTablebcheckin
            // 
            this.coldsMaterialL3DataTablebcheckin.Caption = "bcheckin";
            this.coldsMaterialL3DataTablebcheckin.ColumnName = "bcheckin";
            this.coldsMaterialL3DataTablebcheckin.Namespace = "";
            // 
            // coldsMaterialL3DataTablebqualified
            // 
            this.coldsMaterialL3DataTablebqualified.Caption = "bqualified";
            this.coldsMaterialL3DataTablebqualified.ColumnName = "bqualified";
            this.coldsMaterialL3DataTablebqualified.Namespace = "";
            // 
            // coldsMaterialL3DataTablebchange
            // 
            this.coldsMaterialL3DataTablebchange.Caption = "bchange";
            this.coldsMaterialL3DataTablebchange.ColumnName = "bchange";
            this.coldsMaterialL3DataTablebchange.Namespace = "";
            // 
            // coldsMaterialL3DataTableccheckstatecode
            // 
            this.coldsMaterialL3DataTableccheckstatecode.Caption = "ccheckstatecode";
            this.coldsMaterialL3DataTableccheckstatecode.ColumnName = "ccheckstatecode";
            this.coldsMaterialL3DataTableccheckstatecode.Namespace = "";
            // 
            // coldsMaterialL3DataTableccheckstatename
            // 
            this.coldsMaterialL3DataTableccheckstatename.Caption = "ccheckstatename";
            this.coldsMaterialL3DataTableccheckstatename.ColumnName = "ccheckstatename";
            this.coldsMaterialL3DataTableccheckstatename.Namespace = "";
            // 
            // coldsMaterialL3DataTablevmemo
            // 
            this.coldsMaterialL3DataTablevmemo.Caption = "vmemo";
            this.coldsMaterialL3DataTablevmemo.ColumnName = "vmemo";
            this.coldsMaterialL3DataTablevmemo.Namespace = "";
            // 
            // coldsMaterialL3DataTableccheckstate_bid
            // 
            this.coldsMaterialL3DataTableccheckstate_bid.Caption = "ccheckstate_bid";
            this.coldsMaterialL3DataTableccheckstate_bid.ColumnName = "ccheckstate_bid";
            this.coldsMaterialL3DataTableccheckstate_bid.Namespace = "";
            // 
            // coldsMaterialL3DataTableObjectID
            // 
            this.coldsMaterialL3DataTableObjectID.Caption = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.ColumnName = "ObjectID";
            this.coldsMaterialL3DataTableObjectID.Namespace = "";
            // 
            // coldsMaterial1L3DataTablepk_stordoc
            // 
            this.coldsMaterial1L3DataTablepk_stordoc.Caption = "pk_stordoc";
            this.coldsMaterial1L3DataTablepk_stordoc.ColumnName = "pk_stordoc";
            this.coldsMaterial1L3DataTablepk_stordoc.Namespace = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 100);
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
            this.scddhDataGridViewTextBoxColumn,
            this.vproductbatchcodeDataGridViewTextBoxColumn,
            this.vcheckbillcodeDataGridViewTextBoxColumn,
            this.bcompcheckDataGridViewTextBoxColumn,
            this.vbatchcodeDataGridViewTextBoxColumn,
            this.cpraydeptidDataGridViewTextBoxColumn,
            this.cprayeridDataGridViewTextBoxColumn,
            this.creporteridDataGridViewTextBoxColumn,
            this.dpraydateDataGridViewTextBoxColumn,
            this.nchecknumDataGridViewTextBoxColumn,
            this.nassistchecknumDataGridViewTextBoxColumn,
            this.cassistunitidDataGridViewTextBoxColumn,
            this.cstoreorganizationDataGridViewTextBoxColumn,
            this.cpraycorpDataGridViewTextBoxColumn,
            this.ccheckbillidDataGridViewTextBoxColumn,
            this.nCConfirmFlagDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(3, 17);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.Size = new System.Drawing.Size(725, 80);
            this.dvMain.TabIndex = 0;
            this.dvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMaterial2_DataError);
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
            // vproductbatchcodeDataGridViewTextBoxColumn
            // 
            this.vproductbatchcodeDataGridViewTextBoxColumn.DataPropertyName = "vproductbatchcode";
            this.vproductbatchcodeDataGridViewTextBoxColumn.HeaderText = "产品批次";
            this.vproductbatchcodeDataGridViewTextBoxColumn.Name = "vproductbatchcodeDataGridViewTextBoxColumn";
            this.vproductbatchcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vproductbatchcodeDataGridViewTextBoxColumn.Width = 61;
            // 
            // vcheckbillcodeDataGridViewTextBoxColumn
            // 
            this.vcheckbillcodeDataGridViewTextBoxColumn.DataPropertyName = "vcheckbillcode";
            this.vcheckbillcodeDataGridViewTextBoxColumn.HeaderText = "检验单号";
            this.vcheckbillcodeDataGridViewTextBoxColumn.Name = "vcheckbillcodeDataGridViewTextBoxColumn";
            this.vcheckbillcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vcheckbillcodeDataGridViewTextBoxColumn.Width = 61;
            // 
            // bcompcheckDataGridViewTextBoxColumn
            // 
            this.bcompcheckDataGridViewTextBoxColumn.DataPropertyName = "bcompcheck";
            this.bcompcheckDataGridViewTextBoxColumn.HeaderText = "是否成分检验";
            this.bcompcheckDataGridViewTextBoxColumn.Name = "bcompcheckDataGridViewTextBoxColumn";
            this.bcompcheckDataGridViewTextBoxColumn.ReadOnly = true;
            this.bcompcheckDataGridViewTextBoxColumn.Width = 72;
            // 
            // vbatchcodeDataGridViewTextBoxColumn
            // 
            this.vbatchcodeDataGridViewTextBoxColumn.DataPropertyName = "vbatchcode";
            this.vbatchcodeDataGridViewTextBoxColumn.HeaderText = "检验批次";
            this.vbatchcodeDataGridViewTextBoxColumn.Name = "vbatchcodeDataGridViewTextBoxColumn";
            this.vbatchcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vbatchcodeDataGridViewTextBoxColumn.Width = 61;
            // 
            // cpraydeptidDataGridViewTextBoxColumn
            // 
            this.cpraydeptidDataGridViewTextBoxColumn.DataPropertyName = "cpraydeptid";
            this.cpraydeptidDataGridViewTextBoxColumn.HeaderText = "报检部门";
            this.cpraydeptidDataGridViewTextBoxColumn.Name = "cpraydeptidDataGridViewTextBoxColumn";
            this.cpraydeptidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpraydeptidDataGridViewTextBoxColumn.Width = 61;
            // 
            // cprayeridDataGridViewTextBoxColumn
            // 
            this.cprayeridDataGridViewTextBoxColumn.DataPropertyName = "cprayerid";
            this.cprayeridDataGridViewTextBoxColumn.HeaderText = "报检人";
            this.cprayeridDataGridViewTextBoxColumn.Name = "cprayeridDataGridViewTextBoxColumn";
            this.cprayeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.cprayeridDataGridViewTextBoxColumn.Width = 61;
            // 
            // creporteridDataGridViewTextBoxColumn
            // 
            this.creporteridDataGridViewTextBoxColumn.DataPropertyName = "creporterid";
            this.creporteridDataGridViewTextBoxColumn.HeaderText = "检验人";
            this.creporteridDataGridViewTextBoxColumn.Name = "creporteridDataGridViewTextBoxColumn";
            this.creporteridDataGridViewTextBoxColumn.ReadOnly = true;
            this.creporteridDataGridViewTextBoxColumn.Width = 61;
            // 
            // dpraydateDataGridViewTextBoxColumn
            // 
            this.dpraydateDataGridViewTextBoxColumn.DataPropertyName = "dpraydate";
            this.dpraydateDataGridViewTextBoxColumn.HeaderText = "报检日期";
            this.dpraydateDataGridViewTextBoxColumn.Name = "dpraydateDataGridViewTextBoxColumn";
            this.dpraydateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dpraydateDataGridViewTextBoxColumn.Width = 61;
            // 
            // nchecknumDataGridViewTextBoxColumn
            // 
            this.nchecknumDataGridViewTextBoxColumn.DataPropertyName = "nchecknum";
            this.nchecknumDataGridViewTextBoxColumn.HeaderText = "报检数量";
            this.nchecknumDataGridViewTextBoxColumn.Name = "nchecknumDataGridViewTextBoxColumn";
            this.nchecknumDataGridViewTextBoxColumn.ReadOnly = true;
            this.nchecknumDataGridViewTextBoxColumn.Width = 61;
            // 
            // nassistchecknumDataGridViewTextBoxColumn
            // 
            this.nassistchecknumDataGridViewTextBoxColumn.DataPropertyName = "nassistchecknum";
            this.nassistchecknumDataGridViewTextBoxColumn.HeaderText = "报检辅数量";
            this.nassistchecknumDataGridViewTextBoxColumn.Name = "nassistchecknumDataGridViewTextBoxColumn";
            this.nassistchecknumDataGridViewTextBoxColumn.ReadOnly = true;
            this.nassistchecknumDataGridViewTextBoxColumn.Width = 72;
            // 
            // cassistunitidDataGridViewTextBoxColumn
            // 
            this.cassistunitidDataGridViewTextBoxColumn.DataPropertyName = "cassistunitid";
            this.cassistunitidDataGridViewTextBoxColumn.HeaderText = "辅计量单位id";
            this.cassistunitidDataGridViewTextBoxColumn.Name = "cassistunitidDataGridViewTextBoxColumn";
            this.cassistunitidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cassistunitidDataGridViewTextBoxColumn.Width = 72;
            // 
            // cstoreorganizationDataGridViewTextBoxColumn
            // 
            this.cstoreorganizationDataGridViewTextBoxColumn.DataPropertyName = "cstoreorganization";
            this.cstoreorganizationDataGridViewTextBoxColumn.HeaderText = "库存组织";
            this.cstoreorganizationDataGridViewTextBoxColumn.Name = "cstoreorganizationDataGridViewTextBoxColumn";
            this.cstoreorganizationDataGridViewTextBoxColumn.ReadOnly = true;
            this.cstoreorganizationDataGridViewTextBoxColumn.Width = 61;
            // 
            // cpraycorpDataGridViewTextBoxColumn
            // 
            this.cpraycorpDataGridViewTextBoxColumn.DataPropertyName = "cpraycorp";
            this.cpraycorpDataGridViewTextBoxColumn.HeaderText = "报检公司";
            this.cpraycorpDataGridViewTextBoxColumn.Name = "cpraycorpDataGridViewTextBoxColumn";
            this.cpraycorpDataGridViewTextBoxColumn.ReadOnly = true;
            this.cpraycorpDataGridViewTextBoxColumn.Width = 61;
            // 
            // ccheckbillidDataGridViewTextBoxColumn
            // 
            this.ccheckbillidDataGridViewTextBoxColumn.DataPropertyName = "ccheckbillid";
            this.ccheckbillidDataGridViewTextBoxColumn.HeaderText = "质量检验单主键";
            this.ccheckbillidDataGridViewTextBoxColumn.Name = "ccheckbillidDataGridViewTextBoxColumn";
            this.ccheckbillidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccheckbillidDataGridViewTextBoxColumn.Width = 83;
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
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            this.objectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn.Visible = false;
            this.objectIDDataGridViewTextBoxColumn.Width = 78;
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
            this.coldsMainL3DataTablescddh,
            this.coldsMainL3DataTablevproductbatchcode,
            this.coldsMainL3DataTablevcheckbillcode,
            this.coldsMainL3DataTablebcompcheck,
            this.coldsMainL3DataTablevbatchcode,
            this.coldsMainL3DataTablecpraydeptid,
            this.coldsMainL3DataTablecprayerid,
            this.coldsMainL3DataTablecreporterid,
            this.coldsMainL3DataTabledpraydate,
            this.coldsMainL3DataTablenchecknum,
            this.coldsMainL3DataTablenassistchecknum,
            this.coldsMainL3DataTablecassistunitid,
            this.coldsMainL3DataTablecstoreorganization,
            this.coldsMainL3DataTablecpraycorp,
            this.coldsMainL3DataTableccheckbillid,
            this.coldsMainL3DataTableNC_Confirm_Flag,
            this.coldsMainL3DataTableObjectID});
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
            // coldsMainL3DataTablevproductbatchcode
            // 
            this.coldsMainL3DataTablevproductbatchcode.Caption = "vproductbatchcode";
            this.coldsMainL3DataTablevproductbatchcode.ColumnName = "vproductbatchcode";
            this.coldsMainL3DataTablevproductbatchcode.Namespace = "";
            // 
            // coldsMainL3DataTablevcheckbillcode
            // 
            this.coldsMainL3DataTablevcheckbillcode.Caption = "vcheckbillcode";
            this.coldsMainL3DataTablevcheckbillcode.ColumnName = "vcheckbillcode";
            this.coldsMainL3DataTablevcheckbillcode.Namespace = "";
            // 
            // coldsMainL3DataTablebcompcheck
            // 
            this.coldsMainL3DataTablebcompcheck.Caption = "bcompcheck";
            this.coldsMainL3DataTablebcompcheck.ColumnName = "bcompcheck";
            this.coldsMainL3DataTablebcompcheck.Namespace = "";
            // 
            // coldsMainL3DataTablevbatchcode
            // 
            this.coldsMainL3DataTablevbatchcode.Caption = "vbatchcode";
            this.coldsMainL3DataTablevbatchcode.ColumnName = "vbatchcode";
            this.coldsMainL3DataTablevbatchcode.Namespace = "";
            // 
            // coldsMainL3DataTablecpraydeptid
            // 
            this.coldsMainL3DataTablecpraydeptid.Caption = "cpraydeptid";
            this.coldsMainL3DataTablecpraydeptid.ColumnName = "cpraydeptid";
            this.coldsMainL3DataTablecpraydeptid.Namespace = "";
            // 
            // coldsMainL3DataTablecprayerid
            // 
            this.coldsMainL3DataTablecprayerid.Caption = "cprayerid";
            this.coldsMainL3DataTablecprayerid.ColumnName = "cprayerid";
            this.coldsMainL3DataTablecprayerid.Namespace = "";
            // 
            // coldsMainL3DataTablecreporterid
            // 
            this.coldsMainL3DataTablecreporterid.Caption = "creporterid";
            this.coldsMainL3DataTablecreporterid.ColumnName = "creporterid";
            this.coldsMainL3DataTablecreporterid.Namespace = "";
            // 
            // coldsMainL3DataTabledpraydate
            // 
            this.coldsMainL3DataTabledpraydate.Caption = "dpraydate";
            this.coldsMainL3DataTabledpraydate.ColumnName = "dpraydate";
            this.coldsMainL3DataTabledpraydate.Namespace = "";
            // 
            // coldsMainL3DataTablenchecknum
            // 
            this.coldsMainL3DataTablenchecknum.Caption = "nchecknum";
            this.coldsMainL3DataTablenchecknum.ColumnName = "nchecknum";
            this.coldsMainL3DataTablenchecknum.Namespace = "";
            // 
            // coldsMainL3DataTablenassistchecknum
            // 
            this.coldsMainL3DataTablenassistchecknum.Caption = "nassistchecknum";
            this.coldsMainL3DataTablenassistchecknum.ColumnName = "nassistchecknum";
            this.coldsMainL3DataTablenassistchecknum.Namespace = "";
            // 
            // coldsMainL3DataTablecassistunitid
            // 
            this.coldsMainL3DataTablecassistunitid.Caption = "cassistunitid";
            this.coldsMainL3DataTablecassistunitid.ColumnName = "cassistunitid";
            this.coldsMainL3DataTablecassistunitid.Namespace = "";
            // 
            // coldsMainL3DataTablecstoreorganization
            // 
            this.coldsMainL3DataTablecstoreorganization.Caption = "cstoreorganization";
            this.coldsMainL3DataTablecstoreorganization.ColumnName = "cstoreorganization";
            this.coldsMainL3DataTablecstoreorganization.Namespace = "";
            // 
            // coldsMainL3DataTablecpraycorp
            // 
            this.coldsMainL3DataTablecpraycorp.Caption = "cpraycorp";
            this.coldsMainL3DataTablecpraycorp.ColumnName = "cpraycorp";
            this.coldsMainL3DataTablecpraycorp.Namespace = "";
            // 
            // coldsMainL3DataTableccheckbillid
            // 
            this.coldsMainL3DataTableccheckbillid.Caption = "ccheckbillid";
            this.coldsMainL3DataTableccheckbillid.ColumnName = "ccheckbillid";
            this.coldsMainL3DataTableccheckbillid.Namespace = "";
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
            this.toolStripLabel4,
            this.cmbType,
            this.toolStripLabel1});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(731, 25);
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
            // cmbType
            // 
            this.cmbType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] {
            "过程终判补发",
            "库内改判补发"});
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 25);
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "电文类型";
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
            this.cmdMain.Method = "SendQualityJudgeInfor";
            this.cmdMain.Object = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
            this.cmdMain.Parameters.Add(this.l3CommandParameter1);
            this.cmdMain.Parameters.Add(this.l3CommandParameter2);
            this.cmdMain.Parameters.Add(this.l3CommandParameter3);
            this.cmdMain.Parameters.Add(this.l3CommandParameter4);
            this.cmdMain.ReturnTarget = this.dsMain;
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
            this.l3CommandParameter2.SourceObject = this.dsMaterial1;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = this.dsMaterial1;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.dsMaterial2;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = this.dsMaterial2;
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
            // QualityInforFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tSp1);
            this.Name = "QualityInforFrm";
            this.TabText = "钢坯质检电文补发";
            this.Text = "钢坯质检电文补发";
            this.Load += new System.EventHandler(this.QualityInforFrm_Load);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial1)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3DataSet dsMaterial1;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsMaterial1;
        private AppSvrHMI.L3DataSet dsLog;
        private AppSvrHMI.L3Command cmdMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableFlag;
        private System.Data.DataColumn coldsMainL3DataTablescddh;
        private System.Data.DataColumn coldsMainL3DataTablevproductbatchcode;
        private System.Data.DataColumn coldsMainL3DataTablevcheckbillcode;
        private System.Data.DataColumn coldsMainL3DataTablebcompcheck;
        private System.Data.DataColumn coldsMainL3DataTablevbatchcode;
        private System.Data.DataColumn coldsMainL3DataTablecpraydeptid;
        private System.Data.DataColumn coldsMainL3DataTablecprayerid;
        private System.Data.DataColumn coldsMainL3DataTablecreporterid;
        private System.Data.DataColumn coldsMainL3DataTabledpraydate;
        private System.Data.DataColumn coldsMainL3DataTablenchecknum;
        private System.Data.DataColumn coldsMainL3DataTablenassistchecknum;
        private System.Data.DataColumn coldsMainL3DataTablecassistunitid;
        private System.Data.DataColumn coldsMainL3DataTablecstoreorganization;
        private System.Data.DataColumn coldsMainL3DataTablecpraycorp;
        private System.Data.DataColumn coldsMainL3DataTableccheckbillid;
        private System.Data.DataColumn coldsMainL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsMainL3DataTableObjectID;
        private System.Data.DataTable schemadsMaterial;
        private System.Data.DataColumn coldsMaterialL3DataTablevinvbatchcode;
        private System.Data.DataColumn coldsMaterialL3DataTableccheckbill_b1id;
        private System.Data.DataColumn coldsMaterialL3DataTabledproducedate;
        private System.Data.DataColumn coldsMaterialL3DataTablecbaseid;
        private System.Data.DataColumn coldsMaterialL3DataTablecchgbasid;
        private System.Data.DataColumn coldsMaterialL3DataTablecchgassistunitid;
        private System.Data.DataColumn coldsMaterialL3DataTablevdef1;
        private System.Data.DataColumn coldsMaterialL3DataTablevdef2;
        private System.Data.DataColumn coldsMaterialL3DataTablevdef3;
        private System.Data.DataColumn coldsMaterialL3DataTablevdef4;
        private System.Data.DataColumn coldsMaterialL3DataTablevdef5;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree1;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree2;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree3;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree4;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree5;
        private System.Data.DataColumn coldsMaterialL3DataTablennum;
        private System.Data.DataColumn coldsMaterialL3DataTablenassistnum;
        private System.Data.DataColumn coldsMaterialL3DataTablebcheckin;
        private System.Data.DataColumn coldsMaterialL3DataTablebqualified;
        private System.Data.DataColumn coldsMaterialL3DataTablebchange;
        private System.Data.DataColumn coldsMaterialL3DataTableccheckstatecode;
        private System.Data.DataColumn coldsMaterialL3DataTableccheckstatename;
        private System.Data.DataColumn coldsMaterialL3DataTablevmemo;
        private System.Data.DataColumn coldsMaterialL3DataTableccheckstate_bid;
        private System.Data.DataColumn coldsMaterialL3DataTableObjectID;
        private AppSvrHMI.L3DataSet dsMaterial2;
        private System.Windows.Forms.BindingSource bsMaterial2;
        private System.Data.DataTable schemadsMaterial2;
        private System.Data.DataColumn coldsMaterial2L3DataTablecbaseid;
        private System.Data.DataColumn coldsMaterial2L3DataTabledcheckdate;
        private System.Data.DataColumn coldsMaterial2L3DataTablevsamplecode;
        private System.Data.DataColumn coldsMaterial2L3DataTablennum;
        private System.Data.DataColumn coldsMaterial2L3DataTableccheckitemid;
        private System.Data.DataColumn coldsMaterial2L3DataTableccheckstandardid;
        private System.Data.DataColumn coldsMaterial2L3DataTableicheckstandard;
        private System.Data.DataColumn coldsMaterial2L3DataTablecresult;
        private System.Data.DataColumn coldsMaterial2L3DataTableccheckerid;
        private System.Data.DataColumn coldsMaterial2L3DataTableObjectID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Windows.Forms.DataGridView dvMaterial2;
        private System.Windows.Forms.DataGridView dvMaterial1;
        private System.Windows.Forms.DataGridView dvMain;
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
        private System.Windows.Forms.ToolStripButton btnInStoreUpdate;
        private System.Windows.Forms.ToolStripButton btnInStoreAdd;
        private System.Data.DataColumn coldsMaterial1L3DataTablepk_stordoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scddhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vproductbatchcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcheckbillcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcompcheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbatchcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpraydeptidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cprayeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creporteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpraydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nchecknumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nassistchecknumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cassistunitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cstoreorganizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpraycorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckbillidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCConfirmFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.ToolStripComboBox cmbType;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private AppSvrHMI.L3DataSet dsStore;
        private System.Data.DataTable schemadsStore;
        private System.Data.DataColumn coldsStoreL3DataTablePk_Stock;
        private System.Data.DataColumn coldsStoreL3DataTableStock_Name;
        private AppSvrHMI.L3DataSet dsMaterialID;
        private System.Data.DataTable schemadsMaterialID;
        private System.Data.DataColumn coldsMaterialIDL3DataTablePk_Material_Bas;
        private System.Data.DataColumn coldsMaterialIDL3DataTableMaterial_Name;
        private System.Windows.Forms.BindingSource bsMaterID1;
        private System.Windows.Forms.BindingSource bsMaterID2;
        private AppSvrHMI.L3DataSet dsJudge;
        private System.Data.DataTable schemadsJudge;
        private System.Data.DataColumn coldsJudgeL3DataTablePk_Qua_Grade;
        private System.Data.DataColumn coldsJudgeL3DataTableQua_Grade_Code;
        private AppSvrHMI.L3DataSet dsItem;
        private System.Data.DataTable schemadsItem;
        private System.Data.DataColumn coldsItemL3DataTablePk_Check_Item;
        private System.Data.DataColumn coldsItemL3DataTableCheck_Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbaseidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcheckdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vsamplecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ccheckitemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckstandardidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icheckstandardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cresultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn pk_stordoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vinvbatchcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckbillb1idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dproducedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbaseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cchgbasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cchgassistunitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdef1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdef2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdef3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdef4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdef5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nassistnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bcheckinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bqualifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckstatecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccheckstatenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vmemoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ccheckstatebidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn1;
    }
}