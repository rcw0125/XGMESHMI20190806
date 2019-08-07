namespace NCTelDataMag
{
    partial class InStoreInforFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InStoreInforFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateSend = new System.Windows.Forms.ToolStripButton();
            this.btnAddSend = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvMaterial = new System.Windows.Forms.DataGridView();
            this.cwarehouseidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsStore2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsStore = new AppSvrHMI.L3DataSet();
            this.schemadsStore = new System.Data.DataTable();
            this.coldsStoreL3DataTablePk_Stock = new System.Data.DataColumn();
            this.coldsStoreL3DataTableStock_Name = new System.Data.DataColumn();
            this.taccounttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coperatoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccheckstatebidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsJudge = new AppSvrHMI.L3DataSet();
            this.schemadsJudge = new System.Data.DataTable();
            this.coldsJudgeL3DataTablePk_Qua_Grade = new System.Data.DataColumn();
            this.coldsJudgeL3DataTableQua_Grade_Code = new System.Data.DataColumn();
            this.cworkcenteridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWorkCenter = new AppSvrHMI.L3DataSet();
            this.schemadsWorkCenter = new System.Data.DataTable();
            this.coldsWorkCenterL3DataTableCenter_Code = new System.Data.DataColumn();
            this.coldsWorkCenterL3DataTableCenter_Name = new System.Data.DataColumn();
            this.coldsWorkCenterL3DataTablePk_Center = new System.Data.DataColumn();
            this.dbizdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbatchcodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinvbasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMaterialID = new AppSvrHMI.L3DataSet();
            this.schemadsMaterialID = new System.Data.DataTable();
            this.coldsMaterialIDL3DataTablePk_Material_Bas = new System.Data.DataColumn();
            this.coldsMaterialIDL3DataTableMaterial_Name = new System.Data.DataColumn();
            this.pkproduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ninnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ninassistnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castunitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuserdef10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vfree5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkcorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.dsMaterial = new AppSvrHMI.L3DataSet();
            this.schemadsMaterial = new System.Data.DataTable();
            this.coldsMaterialL3DataTablecwarehouseid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTabletaccounttime = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablecoperatorid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableccheckstate_bid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablecworkcenterid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTabledbizdate = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevbatchcode = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablecinvbasid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepk_produce = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableninnum = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableninassistnum = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablecastunitid = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef6 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef7 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef8 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef9 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevuserdef10 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree1 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree2 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree3 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree4 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablevfree5 = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsMaterialL3DataTablegcbm = new System.Data.DataColumn();
            this.coldsMaterialL3DataTableObjectID = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvMain = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbatchcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cwarehouseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsStore1 = new System.Windows.Forms.BindingSource(this.components);
            this.nCConfirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsMainL3DataTableFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTablevbatchcode = new System.Data.DataColumn();
            this.coldsMainL3DataTablecwarehouseid = new System.Data.DataColumn();
            this.coldsMainL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableTreatNo = new System.Data.DataColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsStore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJudge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWorkCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStore1)).BeginInit();
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
            this.tSp1.Size = new System.Drawing.Size(886, 43);
            this.tSp1.TabIndex = 35;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdateSend
            // 
            this.btnUpdateSend.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSend.Image")));
            this.btnUpdateSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateSend.Name = "btnUpdateSend";
            this.btnUpdateSend.Size = new System.Drawing.Size(135, 40);
            this.btnUpdateSend.Text = "Update类型补发";
            this.btnUpdateSend.Click += new System.EventHandler(this.btnUpdateSend_Click);
            // 
            // btnAddSend
            // 
            this.btnAddSend.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSend.Image")));
            this.btnAddSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSend.Name = "btnAddSend";
            this.btnAddSend.Size = new System.Drawing.Size(116, 40);
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
            this.panel1.Size = new System.Drawing.Size(886, 304);
            this.panel1.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvMaterial);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 207);
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
            this.cwarehouseidDataGridViewTextBoxColumn1,
            this.taccounttimeDataGridViewTextBoxColumn,
            this.coperatoridDataGridViewTextBoxColumn,
            this.ccheckstatebidDataGridViewTextBoxColumn,
            this.cworkcenteridDataGridViewTextBoxColumn,
            this.dbizdateDataGridViewTextBoxColumn,
            this.vbatchcodeDataGridViewTextBoxColumn1,
            this.cinvbasidDataGridViewTextBoxColumn,
            this.pkproduceDataGridViewTextBoxColumn,
            this.ninnumDataGridViewTextBoxColumn,
            this.ninassistnumDataGridViewTextBoxColumn,
            this.castunitidDataGridViewTextBoxColumn,
            this.vuserdef1DataGridViewTextBoxColumn,
            this.vuserdef2DataGridViewTextBoxColumn,
            this.vuserdef3DataGridViewTextBoxColumn,
            this.vuserdef4DataGridViewTextBoxColumn,
            this.vuserdef5DataGridViewTextBoxColumn,
            this.vuserdef6DataGridViewTextBoxColumn,
            this.vuserdef7DataGridViewTextBoxColumn,
            this.vuserdef8DataGridViewTextBoxColumn,
            this.vuserdef9DataGridViewTextBoxColumn,
            this.vuserdef10DataGridViewTextBoxColumn,
            this.vfree1DataGridViewTextBoxColumn,
            this.vfree2DataGridViewTextBoxColumn,
            this.vfree3DataGridViewTextBoxColumn,
            this.vfree4DataGridViewTextBoxColumn,
            this.vfree5DataGridViewTextBoxColumn,
            this.pkcorpDataGridViewTextBoxColumn,
            this.gcbmDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn1});
            this.dvMaterial.DataSource = this.bsMaterial;
            this.dvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMaterial.Location = new System.Drawing.Point(3, 17);
            this.dvMaterial.Name = "dvMaterial";
            this.dvMaterial.ReadOnly = true;
            this.dvMaterial.RowTemplate.Height = 23;
            this.dvMaterial.Size = new System.Drawing.Size(880, 187);
            this.dvMaterial.TabIndex = 0;
            this.dvMaterial.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvMain_DataError);
            // 
            // cwarehouseidDataGridViewTextBoxColumn1
            // 
            this.cwarehouseidDataGridViewTextBoxColumn1.DataPropertyName = "cwarehouseid";
            this.cwarehouseidDataGridViewTextBoxColumn1.DataSource = this.bsStore2;
            this.cwarehouseidDataGridViewTextBoxColumn1.DisplayMember = "Stock_Name";
            this.cwarehouseidDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cwarehouseidDataGridViewTextBoxColumn1.HeaderText = "入库仓库";
            this.cwarehouseidDataGridViewTextBoxColumn1.Name = "cwarehouseidDataGridViewTextBoxColumn1";
            this.cwarehouseidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cwarehouseidDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cwarehouseidDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cwarehouseidDataGridViewTextBoxColumn1.ValueMember = "Pk_Stock";
            this.cwarehouseidDataGridViewTextBoxColumn1.Width = 61;
            // 
            // bsStore2
            // 
            this.bsStore2.DataMember = "L3DataTable";
            this.bsStore2.DataSource = this.dsStore;
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
            // taccounttimeDataGridViewTextBoxColumn
            // 
            this.taccounttimeDataGridViewTextBoxColumn.DataPropertyName = "taccounttime";
            this.taccounttimeDataGridViewTextBoxColumn.HeaderText = "库房签字时间";
            this.taccounttimeDataGridViewTextBoxColumn.Name = "taccounttimeDataGridViewTextBoxColumn";
            this.taccounttimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.taccounttimeDataGridViewTextBoxColumn.Width = 72;
            // 
            // coperatoridDataGridViewTextBoxColumn
            // 
            this.coperatoridDataGridViewTextBoxColumn.DataPropertyName = "coperatorid";
            this.coperatoridDataGridViewTextBoxColumn.HeaderText = "操作员编码";
            this.coperatoridDataGridViewTextBoxColumn.Name = "coperatoridDataGridViewTextBoxColumn";
            this.coperatoridDataGridViewTextBoxColumn.ReadOnly = true;
            this.coperatoridDataGridViewTextBoxColumn.Width = 72;
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
            this.dsJudge.AutoLoad = true;
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
            // cworkcenteridDataGridViewTextBoxColumn
            // 
            this.cworkcenteridDataGridViewTextBoxColumn.DataPropertyName = "cworkcenterid";
            this.cworkcenteridDataGridViewTextBoxColumn.DataSource = this.dsWorkCenter;
            this.cworkcenteridDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Pk_Center";
            this.cworkcenteridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cworkcenteridDataGridViewTextBoxColumn.HeaderText = "工作中心主键";
            this.cworkcenteridDataGridViewTextBoxColumn.Name = "cworkcenteridDataGridViewTextBoxColumn";
            this.cworkcenteridDataGridViewTextBoxColumn.ReadOnly = true;
            this.cworkcenteridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cworkcenteridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cworkcenteridDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Center_Code";
            this.cworkcenteridDataGridViewTextBoxColumn.Width = 72;
            // 
            // dsWorkCenter
            // 
            this.dsWorkCenter.AutoLoad = true;
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
            this.coldsWorkCenterL3DataTableCenter_Name,
            this.coldsWorkCenterL3DataTablePk_Center});
            this.schemadsWorkCenter.TableName = "L3DataTable";
            // 
            // coldsWorkCenterL3DataTableCenter_Code
            // 
            this.coldsWorkCenterL3DataTableCenter_Code.Caption = "Center_Code";
            this.coldsWorkCenterL3DataTableCenter_Code.ColumnName = "Center_Code";
            this.coldsWorkCenterL3DataTableCenter_Code.Namespace = "";
            // 
            // coldsWorkCenterL3DataTableCenter_Name
            // 
            this.coldsWorkCenterL3DataTableCenter_Name.Caption = "Center_Name";
            this.coldsWorkCenterL3DataTableCenter_Name.ColumnName = "Center_Name";
            this.coldsWorkCenterL3DataTableCenter_Name.Namespace = "";
            // 
            // coldsWorkCenterL3DataTablePk_Center
            // 
            this.coldsWorkCenterL3DataTablePk_Center.Caption = "Pk_Center";
            this.coldsWorkCenterL3DataTablePk_Center.ColumnName = "Pk_Center";
            this.coldsWorkCenterL3DataTablePk_Center.Namespace = "";
            // 
            // dbizdateDataGridViewTextBoxColumn
            // 
            this.dbizdateDataGridViewTextBoxColumn.DataPropertyName = "dbizdate";
            this.dbizdateDataGridViewTextBoxColumn.HeaderText = "业务日期";
            this.dbizdateDataGridViewTextBoxColumn.Name = "dbizdateDataGridViewTextBoxColumn";
            this.dbizdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dbizdateDataGridViewTextBoxColumn.Width = 61;
            // 
            // vbatchcodeDataGridViewTextBoxColumn1
            // 
            this.vbatchcodeDataGridViewTextBoxColumn1.DataPropertyName = "vbatchcode";
            this.vbatchcodeDataGridViewTextBoxColumn1.HeaderText = "批次号";
            this.vbatchcodeDataGridViewTextBoxColumn1.Name = "vbatchcodeDataGridViewTextBoxColumn1";
            this.vbatchcodeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.vbatchcodeDataGridViewTextBoxColumn1.Width = 61;
            // 
            // cinvbasidDataGridViewTextBoxColumn
            // 
            this.cinvbasidDataGridViewTextBoxColumn.DataPropertyName = "cinvbasid";
            this.cinvbasidDataGridViewTextBoxColumn.DataSource = this.dsMaterialID;
            this.cinvbasidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Material_Name";
            this.cinvbasidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cinvbasidDataGridViewTextBoxColumn.HeaderText = "入库存货";
            this.cinvbasidDataGridViewTextBoxColumn.Name = "cinvbasidDataGridViewTextBoxColumn";
            this.cinvbasidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cinvbasidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cinvbasidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cinvbasidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Material_Bas";
            this.cinvbasidDataGridViewTextBoxColumn.Width = 61;
            // 
            // dsMaterialID
            // 
            this.dsMaterialID.AutoLoad = true;
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
            // pkproduceDataGridViewTextBoxColumn
            // 
            this.pkproduceDataGridViewTextBoxColumn.DataPropertyName = "pk_produce";
            this.pkproduceDataGridViewTextBoxColumn.HeaderText = "入库产品";
            this.pkproduceDataGridViewTextBoxColumn.Name = "pkproduceDataGridViewTextBoxColumn";
            this.pkproduceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkproduceDataGridViewTextBoxColumn.Width = 61;
            // 
            // ninnumDataGridViewTextBoxColumn
            // 
            this.ninnumDataGridViewTextBoxColumn.DataPropertyName = "ninnum";
            this.ninnumDataGridViewTextBoxColumn.HeaderText = "入库数量";
            this.ninnumDataGridViewTextBoxColumn.Name = "ninnumDataGridViewTextBoxColumn";
            this.ninnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ninnumDataGridViewTextBoxColumn.Width = 61;
            // 
            // ninassistnumDataGridViewTextBoxColumn
            // 
            this.ninassistnumDataGridViewTextBoxColumn.DataPropertyName = "ninassistnum";
            this.ninassistnumDataGridViewTextBoxColumn.HeaderText = "入库辅数量";
            this.ninassistnumDataGridViewTextBoxColumn.Name = "ninassistnumDataGridViewTextBoxColumn";
            this.ninassistnumDataGridViewTextBoxColumn.ReadOnly = true;
            this.ninassistnumDataGridViewTextBoxColumn.Width = 72;
            // 
            // castunitidDataGridViewTextBoxColumn
            // 
            this.castunitidDataGridViewTextBoxColumn.DataPropertyName = "castunitid";
            this.castunitidDataGridViewTextBoxColumn.HeaderText = "辅计量单位id";
            this.castunitidDataGridViewTextBoxColumn.Name = "castunitidDataGridViewTextBoxColumn";
            this.castunitidDataGridViewTextBoxColumn.ReadOnly = true;
            this.castunitidDataGridViewTextBoxColumn.Width = 72;
            // 
            // vuserdef1DataGridViewTextBoxColumn
            // 
            this.vuserdef1DataGridViewTextBoxColumn.DataPropertyName = "vuserdef1";
            this.vuserdef1DataGridViewTextBoxColumn.HeaderText = "自定义1";
            this.vuserdef1DataGridViewTextBoxColumn.Name = "vuserdef1DataGridViewTextBoxColumn";
            this.vuserdef1DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef1DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef2DataGridViewTextBoxColumn
            // 
            this.vuserdef2DataGridViewTextBoxColumn.DataPropertyName = "vuserdef2";
            this.vuserdef2DataGridViewTextBoxColumn.HeaderText = "自定义2";
            this.vuserdef2DataGridViewTextBoxColumn.Name = "vuserdef2DataGridViewTextBoxColumn";
            this.vuserdef2DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef2DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef3DataGridViewTextBoxColumn
            // 
            this.vuserdef3DataGridViewTextBoxColumn.DataPropertyName = "vuserdef3";
            this.vuserdef3DataGridViewTextBoxColumn.HeaderText = "自定义3";
            this.vuserdef3DataGridViewTextBoxColumn.Name = "vuserdef3DataGridViewTextBoxColumn";
            this.vuserdef3DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef3DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef4DataGridViewTextBoxColumn
            // 
            this.vuserdef4DataGridViewTextBoxColumn.DataPropertyName = "vuserdef4";
            this.vuserdef4DataGridViewTextBoxColumn.HeaderText = "自定义4";
            this.vuserdef4DataGridViewTextBoxColumn.Name = "vuserdef4DataGridViewTextBoxColumn";
            this.vuserdef4DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef4DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef5DataGridViewTextBoxColumn
            // 
            this.vuserdef5DataGridViewTextBoxColumn.DataPropertyName = "vuserdef5";
            this.vuserdef5DataGridViewTextBoxColumn.HeaderText = "自定义5";
            this.vuserdef5DataGridViewTextBoxColumn.Name = "vuserdef5DataGridViewTextBoxColumn";
            this.vuserdef5DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef5DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef6DataGridViewTextBoxColumn
            // 
            this.vuserdef6DataGridViewTextBoxColumn.DataPropertyName = "vuserdef6";
            this.vuserdef6DataGridViewTextBoxColumn.HeaderText = "自定义6";
            this.vuserdef6DataGridViewTextBoxColumn.Name = "vuserdef6DataGridViewTextBoxColumn";
            this.vuserdef6DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef6DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef7DataGridViewTextBoxColumn
            // 
            this.vuserdef7DataGridViewTextBoxColumn.DataPropertyName = "vuserdef7";
            this.vuserdef7DataGridViewTextBoxColumn.HeaderText = "自定义7";
            this.vuserdef7DataGridViewTextBoxColumn.Name = "vuserdef7DataGridViewTextBoxColumn";
            this.vuserdef7DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef7DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef8DataGridViewTextBoxColumn
            // 
            this.vuserdef8DataGridViewTextBoxColumn.DataPropertyName = "vuserdef8";
            this.vuserdef8DataGridViewTextBoxColumn.HeaderText = "自定义8";
            this.vuserdef8DataGridViewTextBoxColumn.Name = "vuserdef8DataGridViewTextBoxColumn";
            this.vuserdef8DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef8DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef9DataGridViewTextBoxColumn
            // 
            this.vuserdef9DataGridViewTextBoxColumn.DataPropertyName = "vuserdef9";
            this.vuserdef9DataGridViewTextBoxColumn.HeaderText = "自定义9";
            this.vuserdef9DataGridViewTextBoxColumn.Name = "vuserdef9DataGridViewTextBoxColumn";
            this.vuserdef9DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef9DataGridViewTextBoxColumn.Width = 61;
            // 
            // vuserdef10DataGridViewTextBoxColumn
            // 
            this.vuserdef10DataGridViewTextBoxColumn.DataPropertyName = "vuserdef10";
            this.vuserdef10DataGridViewTextBoxColumn.HeaderText = "自定义10";
            this.vuserdef10DataGridViewTextBoxColumn.Name = "vuserdef10DataGridViewTextBoxColumn";
            this.vuserdef10DataGridViewTextBoxColumn.ReadOnly = true;
            this.vuserdef10DataGridViewTextBoxColumn.Width = 61;
            // 
            // vfree1DataGridViewTextBoxColumn
            // 
            this.vfree1DataGridViewTextBoxColumn.DataPropertyName = "vfree1";
            this.vfree1DataGridViewTextBoxColumn.HeaderText = "产品标准";
            this.vfree1DataGridViewTextBoxColumn.Name = "vfree1DataGridViewTextBoxColumn";
            this.vfree1DataGridViewTextBoxColumn.ReadOnly = true;
            this.vfree1DataGridViewTextBoxColumn.Width = 61;
            // 
            // vfree2DataGridViewTextBoxColumn
            // 
            this.vfree2DataGridViewTextBoxColumn.DataPropertyName = "vfree2";
            this.vfree2DataGridViewTextBoxColumn.HeaderText = "技术要求";
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
            // objectIDDataGridViewTextBoxColumn1
            // 
            this.objectIDDataGridViewTextBoxColumn1.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn1.HeaderText = "MaterialID";
            this.objectIDDataGridViewTextBoxColumn1.Name = "objectIDDataGridViewTextBoxColumn1";
            this.objectIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn1.Visible = false;
            this.objectIDDataGridViewTextBoxColumn1.Width = 90;
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
            this.coldsMaterialL3DataTablecwarehouseid,
            this.coldsMaterialL3DataTabletaccounttime,
            this.coldsMaterialL3DataTablecoperatorid,
            this.coldsMaterialL3DataTableccheckstate_bid,
            this.coldsMaterialL3DataTablecworkcenterid,
            this.coldsMaterialL3DataTabledbizdate,
            this.coldsMaterialL3DataTablevbatchcode,
            this.coldsMaterialL3DataTablecinvbasid,
            this.coldsMaterialL3DataTablepk_produce,
            this.coldsMaterialL3DataTableninnum,
            this.coldsMaterialL3DataTableninassistnum,
            this.coldsMaterialL3DataTablecastunitid,
            this.coldsMaterialL3DataTablevuserdef1,
            this.coldsMaterialL3DataTablevuserdef2,
            this.coldsMaterialL3DataTablevuserdef3,
            this.coldsMaterialL3DataTablevuserdef4,
            this.coldsMaterialL3DataTablevuserdef5,
            this.coldsMaterialL3DataTablevuserdef6,
            this.coldsMaterialL3DataTablevuserdef7,
            this.coldsMaterialL3DataTablevuserdef8,
            this.coldsMaterialL3DataTablevuserdef9,
            this.coldsMaterialL3DataTablevuserdef10,
            this.coldsMaterialL3DataTablevfree1,
            this.coldsMaterialL3DataTablevfree2,
            this.coldsMaterialL3DataTablevfree3,
            this.coldsMaterialL3DataTablevfree4,
            this.coldsMaterialL3DataTablevfree5,
            this.coldsMaterialL3DataTablepk_corp,
            this.coldsMaterialL3DataTablegcbm,
            this.coldsMaterialL3DataTableObjectID});
            this.schemadsMaterial.TableName = "L3DataTable";
            // 
            // coldsMaterialL3DataTablecwarehouseid
            // 
            this.coldsMaterialL3DataTablecwarehouseid.Caption = "cwarehouseid";
            this.coldsMaterialL3DataTablecwarehouseid.ColumnName = "cwarehouseid";
            this.coldsMaterialL3DataTablecwarehouseid.Namespace = "";
            // 
            // coldsMaterialL3DataTabletaccounttime
            // 
            this.coldsMaterialL3DataTabletaccounttime.Caption = "taccounttime";
            this.coldsMaterialL3DataTabletaccounttime.ColumnName = "taccounttime";
            this.coldsMaterialL3DataTabletaccounttime.Namespace = "";
            // 
            // coldsMaterialL3DataTablecoperatorid
            // 
            this.coldsMaterialL3DataTablecoperatorid.Caption = "coperatorid";
            this.coldsMaterialL3DataTablecoperatorid.ColumnName = "coperatorid";
            this.coldsMaterialL3DataTablecoperatorid.Namespace = "";
            // 
            // coldsMaterialL3DataTableccheckstate_bid
            // 
            this.coldsMaterialL3DataTableccheckstate_bid.Caption = "ccheckstate_bid";
            this.coldsMaterialL3DataTableccheckstate_bid.ColumnName = "ccheckstate_bid";
            this.coldsMaterialL3DataTableccheckstate_bid.Namespace = "";
            // 
            // coldsMaterialL3DataTablecworkcenterid
            // 
            this.coldsMaterialL3DataTablecworkcenterid.Caption = "cworkcenterid";
            this.coldsMaterialL3DataTablecworkcenterid.ColumnName = "cworkcenterid";
            this.coldsMaterialL3DataTablecworkcenterid.Namespace = "";
            // 
            // coldsMaterialL3DataTabledbizdate
            // 
            this.coldsMaterialL3DataTabledbizdate.Caption = "dbizdate";
            this.coldsMaterialL3DataTabledbizdate.ColumnName = "dbizdate";
            this.coldsMaterialL3DataTabledbizdate.Namespace = "";
            // 
            // coldsMaterialL3DataTablevbatchcode
            // 
            this.coldsMaterialL3DataTablevbatchcode.Caption = "vbatchcode";
            this.coldsMaterialL3DataTablevbatchcode.ColumnName = "vbatchcode";
            this.coldsMaterialL3DataTablevbatchcode.Namespace = "";
            // 
            // coldsMaterialL3DataTablecinvbasid
            // 
            this.coldsMaterialL3DataTablecinvbasid.Caption = "cinvbasid";
            this.coldsMaterialL3DataTablecinvbasid.ColumnName = "cinvbasid";
            this.coldsMaterialL3DataTablecinvbasid.Namespace = "";
            // 
            // coldsMaterialL3DataTablepk_produce
            // 
            this.coldsMaterialL3DataTablepk_produce.Caption = "pk_produce";
            this.coldsMaterialL3DataTablepk_produce.ColumnName = "pk_produce";
            this.coldsMaterialL3DataTablepk_produce.Namespace = "";
            // 
            // coldsMaterialL3DataTableninnum
            // 
            this.coldsMaterialL3DataTableninnum.Caption = "ninnum";
            this.coldsMaterialL3DataTableninnum.ColumnName = "ninnum";
            this.coldsMaterialL3DataTableninnum.Namespace = "";
            // 
            // coldsMaterialL3DataTableninassistnum
            // 
            this.coldsMaterialL3DataTableninassistnum.Caption = "ninassistnum";
            this.coldsMaterialL3DataTableninassistnum.ColumnName = "ninassistnum";
            this.coldsMaterialL3DataTableninassistnum.Namespace = "";
            // 
            // coldsMaterialL3DataTablecastunitid
            // 
            this.coldsMaterialL3DataTablecastunitid.Caption = "castunitid";
            this.coldsMaterialL3DataTablecastunitid.ColumnName = "castunitid";
            this.coldsMaterialL3DataTablecastunitid.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef1
            // 
            this.coldsMaterialL3DataTablevuserdef1.Caption = "vuserdef1";
            this.coldsMaterialL3DataTablevuserdef1.ColumnName = "vuserdef1";
            this.coldsMaterialL3DataTablevuserdef1.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef2
            // 
            this.coldsMaterialL3DataTablevuserdef2.Caption = "vuserdef2";
            this.coldsMaterialL3DataTablevuserdef2.ColumnName = "vuserdef2";
            this.coldsMaterialL3DataTablevuserdef2.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef3
            // 
            this.coldsMaterialL3DataTablevuserdef3.Caption = "vuserdef3";
            this.coldsMaterialL3DataTablevuserdef3.ColumnName = "vuserdef3";
            this.coldsMaterialL3DataTablevuserdef3.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef4
            // 
            this.coldsMaterialL3DataTablevuserdef4.Caption = "vuserdef4";
            this.coldsMaterialL3DataTablevuserdef4.ColumnName = "vuserdef4";
            this.coldsMaterialL3DataTablevuserdef4.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef5
            // 
            this.coldsMaterialL3DataTablevuserdef5.Caption = "vuserdef5";
            this.coldsMaterialL3DataTablevuserdef5.ColumnName = "vuserdef5";
            this.coldsMaterialL3DataTablevuserdef5.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef6
            // 
            this.coldsMaterialL3DataTablevuserdef6.Caption = "vuserdef6";
            this.coldsMaterialL3DataTablevuserdef6.ColumnName = "vuserdef6";
            this.coldsMaterialL3DataTablevuserdef6.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef7
            // 
            this.coldsMaterialL3DataTablevuserdef7.Caption = "vuserdef7";
            this.coldsMaterialL3DataTablevuserdef7.ColumnName = "vuserdef7";
            this.coldsMaterialL3DataTablevuserdef7.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef8
            // 
            this.coldsMaterialL3DataTablevuserdef8.Caption = "vuserdef8";
            this.coldsMaterialL3DataTablevuserdef8.ColumnName = "vuserdef8";
            this.coldsMaterialL3DataTablevuserdef8.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef9
            // 
            this.coldsMaterialL3DataTablevuserdef9.Caption = "vuserdef9";
            this.coldsMaterialL3DataTablevuserdef9.ColumnName = "vuserdef9";
            this.coldsMaterialL3DataTablevuserdef9.Namespace = "";
            // 
            // coldsMaterialL3DataTablevuserdef10
            // 
            this.coldsMaterialL3DataTablevuserdef10.Caption = "vuserdef10";
            this.coldsMaterialL3DataTablevuserdef10.ColumnName = "vuserdef10";
            this.coldsMaterialL3DataTablevuserdef10.Namespace = "";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 72);
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
            this.vbatchcodeDataGridViewTextBoxColumn,
            this.cwarehouseidDataGridViewTextBoxColumn,
            this.nCConfirmFlagDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.treatNoDataGridViewTextBoxColumn,
            this.objectIDDataGridViewTextBoxColumn});
            this.dvMain.DataSource = this.bsMain;
            this.dvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvMain.Location = new System.Drawing.Point(3, 17);
            this.dvMain.Name = "dvMain";
            this.dvMain.ReadOnly = true;
            this.dvMain.RowTemplate.Height = 23;
            this.dvMain.Size = new System.Drawing.Size(880, 52);
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
            // vbatchcodeDataGridViewTextBoxColumn
            // 
            this.vbatchcodeDataGridViewTextBoxColumn.DataPropertyName = "vbatchcode";
            this.vbatchcodeDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.vbatchcodeDataGridViewTextBoxColumn.Name = "vbatchcodeDataGridViewTextBoxColumn";
            this.vbatchcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.vbatchcodeDataGridViewTextBoxColumn.Width = 66;
            // 
            // cwarehouseidDataGridViewTextBoxColumn
            // 
            this.cwarehouseidDataGridViewTextBoxColumn.DataPropertyName = "cwarehouseid";
            this.cwarehouseidDataGridViewTextBoxColumn.DataSource = this.bsStore1;
            this.cwarehouseidDataGridViewTextBoxColumn.DisplayMember = "Stock_Name";
            this.cwarehouseidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cwarehouseidDataGridViewTextBoxColumn.HeaderText = "入库仓库";
            this.cwarehouseidDataGridViewTextBoxColumn.Name = "cwarehouseidDataGridViewTextBoxColumn";
            this.cwarehouseidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cwarehouseidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cwarehouseidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cwarehouseidDataGridViewTextBoxColumn.ValueMember = "Pk_Stock";
            this.cwarehouseidDataGridViewTextBoxColumn.Width = 78;
            // 
            // bsStore1
            // 
            this.bsStore1.DataMember = "L3DataTable";
            this.bsStore1.DataSource = this.dsStore;
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
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "主键";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // treatNoDataGridViewTextBoxColumn
            // 
            this.treatNoDataGridViewTextBoxColumn.DataPropertyName = "TreatNo";
            this.treatNoDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.treatNoDataGridViewTextBoxColumn.Name = "treatNoDataGridViewTextBoxColumn";
            this.treatNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.treatNoDataGridViewTextBoxColumn.Visible = false;
            this.treatNoDataGridViewTextBoxColumn.Width = 90;
            // 
            // objectIDDataGridViewTextBoxColumn
            // 
            this.objectIDDataGridViewTextBoxColumn.DataPropertyName = "ObjectID";
            this.objectIDDataGridViewTextBoxColumn.HeaderText = "MaterialID";
            this.objectIDDataGridViewTextBoxColumn.Name = "objectIDDataGridViewTextBoxColumn";
            this.objectIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.objectIDDataGridViewTextBoxColumn.Visible = false;
            this.objectIDDataGridViewTextBoxColumn.Width = 90;
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
            this.coldsMainL3DataTablevbatchcode,
            this.coldsMainL3DataTablecwarehouseid,
            this.coldsMainL3DataTableNC_Confirm_Flag,
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableTreatNo,
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
            // coldsMainL3DataTablevbatchcode
            // 
            this.coldsMainL3DataTablevbatchcode.Caption = "vbatchcode";
            this.coldsMainL3DataTablevbatchcode.ColumnName = "vbatchcode";
            this.coldsMainL3DataTablevbatchcode.Namespace = "";
            // 
            // coldsMainL3DataTablecwarehouseid
            // 
            this.coldsMainL3DataTablecwarehouseid.Caption = "cwarehouseid";
            this.coldsMainL3DataTablecwarehouseid.ColumnName = "cwarehouseid";
            this.coldsMainL3DataTablecwarehouseid.Namespace = "";
            // 
            // coldsMainL3DataTableNC_Confirm_Flag
            // 
            this.coldsMainL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsMainL3DataTableNC_Confirm_Flag.Namespace = "";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableTreatNo
            // 
            this.coldsMainL3DataTableTreatNo.Caption = "TreatNo";
            this.coldsMainL3DataTableTreatNo.ColumnName = "TreatNo";
            this.coldsMainL3DataTableTreatNo.Namespace = "";
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
            this.toolStripLabel4});
            this.bnM.Location = new System.Drawing.Point(0, 0);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(886, 25);
            this.bnM.TabIndex = 36;
            this.bnM.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
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
            this.toolStripLabel4.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel4.Text = "炉号";
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
            this.dsLog.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
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
            this.cmdMain.Method = "SendBloomInStoreInfor";
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
            // InStoreInforFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tSp1);
            this.Name = "InStoreInforFrm";
            this.TabText = "钢坯入库电文补发";
            this.Text = "钢坯入库电文补发";
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsJudge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWorkCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStore1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3DataSet dsLog;
        private AppSvrHMI.L3DataSet dsMaterial;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.BindingSource bsMaterial;
        private AppSvrHMI.L3Command cmdMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableHeatID;
        private System.Data.DataColumn coldsMainL3DataTableFlag;
        private System.Data.DataColumn coldsMainL3DataTablevbatchcode;
        private System.Data.DataColumn coldsMainL3DataTablecwarehouseid;
        private System.Data.DataColumn coldsMainL3DataTableNC_Confirm_Flag;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableTreatNo;
        private System.Data.DataColumn coldsMainL3DataTableObjectID;
        private System.Data.DataTable schemadsMaterial;
        private System.Data.DataColumn coldsMaterialL3DataTablecwarehouseid;
        private System.Data.DataColumn coldsMaterialL3DataTabletaccounttime;
        private System.Data.DataColumn coldsMaterialL3DataTablecoperatorid;
        private System.Data.DataColumn coldsMaterialL3DataTableccheckstate_bid;
        private System.Data.DataColumn coldsMaterialL3DataTablecworkcenterid;
        private System.Data.DataColumn coldsMaterialL3DataTabledbizdate;
        private System.Data.DataColumn coldsMaterialL3DataTablevbatchcode;
        private System.Data.DataColumn coldsMaterialL3DataTablecinvbasid;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_produce;
        private System.Data.DataColumn coldsMaterialL3DataTableninnum;
        private System.Data.DataColumn coldsMaterialL3DataTableninassistnum;
        private System.Data.DataColumn coldsMaterialL3DataTablecastunitid;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef1;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef2;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef3;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef4;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef5;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef6;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef7;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef8;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef9;
        private System.Data.DataColumn coldsMaterialL3DataTablevuserdef10;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree1;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree2;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree3;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree4;
        private System.Data.DataColumn coldsMaterialL3DataTablevfree5;
        private System.Data.DataColumn coldsMaterialL3DataTablepk_corp;
        private System.Data.DataColumn coldsMaterialL3DataTablegcbm;
        private System.Data.DataColumn coldsMaterialL3DataTableObjectID;
        private System.Windows.Forms.DataGridView dvMaterial;
        private System.Windows.Forms.DataGridView dvMain;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
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
        private AppSvrHMI.L3DataSet dsStore;
        private System.Data.DataTable schemadsStore;
        private System.Data.DataColumn coldsStoreL3DataTablePk_Stock;
        private System.Data.DataColumn coldsStoreL3DataTableStock_Name;
        private System.Windows.Forms.BindingSource bsStore1;
        private System.Windows.Forms.BindingSource bsStore2;
        private AppSvrHMI.L3DataSet dsJudge;
        private System.Data.DataTable schemadsJudge;
        private System.Data.DataColumn coldsJudgeL3DataTablePk_Qua_Grade;
        private System.Data.DataColumn coldsJudgeL3DataTableQua_Grade_Code;
        private AppSvrHMI.L3DataSet dsWorkCenter;
        private System.Data.DataTable schemadsWorkCenter;
        private System.Data.DataColumn coldsWorkCenterL3DataTableCenter_Code;
        private System.Data.DataColumn coldsWorkCenterL3DataTableCenter_Name;
        private System.Data.DataColumn coldsWorkCenterL3DataTablePk_Center;
        private AppSvrHMI.L3DataSet dsMaterialID;
        private System.Data.DataTable schemadsMaterialID;
        private System.Data.DataColumn coldsMaterialIDL3DataTablePk_Material_Bas;
        private System.Data.DataColumn coldsMaterialIDL3DataTableMaterial_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbatchcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cwarehouseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCConfirmFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cwarehouseidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taccounttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coperatoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ccheckstatebidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cworkcenteridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbizdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vbatchcodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cinvbasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkproduceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninassistnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castunitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vuserdef10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vfree5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkcorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectIDDataGridViewTextBoxColumn1;
    }
}