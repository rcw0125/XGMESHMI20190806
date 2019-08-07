namespace StoreMag.ScrapStore
{
    partial class ScrapStoreMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapStoreMagFrm));
            this.bsScrap = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrap = new AppSvrHMI.L3DataSet();
            this.cmdQuery = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpScrap = new AppSvrHMI.L3CommandParameter();
            this.schemadsScrap = new System.Data.DataTable();
            this.coldsScrapL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsScrapL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsScrapL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsScrapL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsScrapL3DataTableIDX = new System.Data.DataColumn();
            this.coldsScrapL3DataTableCheckFlag = new System.Data.DataColumn();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnInStore = new System.Windows.Forms.ToolStripButton();
            this.btnOutStore = new System.Windows.Forms.ToolStripButton();
            this.btnCancelOutStore = new System.Windows.Forms.ToolStripButton();
            this.btnBalanceStore = new System.Windows.Forms.ToolStripButton();
            this.btnScarpInformationInput = new System.Windows.Forms.ToolStripButton();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.dsStoreID = new AppSvrHMI.L3DataSet();
            this.schemadsStoreID = new System.Data.DataTable();
            this.coldsStoreIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsScrapSend = new AppSvrHMI.L3DataSet();
            this.schemadsScrapSend = new System.Data.DataTable();
            this.coldsScrapSendL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsScrapSendL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsScrapSendL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsScrapSendL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsScrapSendL3DataTableIDX = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsScrapCode = new AppSvrHMI.L3DataSet();
            this.schemadsScrapCode = new System.Data.DataTable();
            this.coldsScrapCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3dbxGetStore = new AppSvrHMI.L3DataBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsScrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrap)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapSend)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsScrap
            // 
            this.bsScrap.DataMember = "L3DataTable";
            this.bsScrap.DataSource = this.dsScrap;
            // 
            // dsScrap
            // 
            this.dsScrap.AutoLoad = true;
            this.dsScrap.AutoSubscribe = true;
            this.dsScrap.DataSetName = "L3DataSet";
            this.dsScrap.DeleteMethod = "";
            this.dsScrap.InsertMethod = "";
            this.dsScrap.L3DataAdapter = null;
            this.dsScrap.LoadEvent = "Click";
            this.dsScrap.LoadTrigger = null;
            this.dsScrap.RefreshValve = 1000;
            this.dsScrap.SourceCommand = this.cmdQuery;
            this.dsScrap.SourceCondition = null;
            this.dsScrap.SourceMethod = "GetMaterialOnStore";
            this.dsScrap.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsScrap.SourceURI = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.dsScrap.SubscribeTarget = null;
            this.dsScrap.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrap});
            this.dsScrap.UpdateEvent = "Click";
            this.dsScrap.UpdateMethod = "";
            this.dsScrap.UpdateTrigger = null;
            // 
            // cmdQuery
            // 
            this.cmdQuery.Adapter = null;
            this.cmdQuery.MergeReturnTarget = false;
            this.cmdQuery.Method = "";
            this.cmdQuery.Object = "";
            this.cmdQuery.Parameters.Add(this.l3cmdpScrap);
            this.cmdQuery.ReturnTarget = null;
            this.cmdQuery.ReturnTargetProperty = null;
            this.cmdQuery.Trigger = null;
            this.cmdQuery.TriggerEvent = "Click";
            // 
            // l3cmdpScrap
            // 
            this.l3cmdpScrap.AcceptAfterExecuted = false;
            this.l3cmdpScrap.ConstantValue = null;
            this.l3cmdpScrap.MergeTarget = false;
            this.l3cmdpScrap.SourceFilter = null;
            this.l3cmdpScrap.SourceObject = null;
            this.l3cmdpScrap.SourceProperty = "";
            this.l3cmdpScrap.TargetObject = null;
            this.l3cmdpScrap.TargetProperty = null;
            // 
            // schemadsScrap
            // 
            this.schemadsScrap.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapL3DataTableMATERIALTYPE,
            this.coldsScrapL3DataTableMATERIALID,
            this.coldsScrapL3DataTablePOSITION,
            this.coldsScrapL3DataTableAMOUNT,
            this.coldsScrapL3DataTableIDX,
            this.coldsScrapL3DataTableCheckFlag});
            this.schemadsScrap.TableName = "L3DataTable";
            // 
            // coldsScrapL3DataTableMATERIALTYPE
            // 
            this.coldsScrapL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsScrapL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsScrapL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsScrapL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsScrapL3DataTableMATERIALID
            // 
            this.coldsScrapL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsScrapL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsScrapL3DataTableMATERIALID.DefaultValue = "";
            this.coldsScrapL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsScrapL3DataTablePOSITION
            // 
            this.coldsScrapL3DataTablePOSITION.Caption = "POSITION";
            this.coldsScrapL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsScrapL3DataTablePOSITION.DefaultValue = "";
            this.coldsScrapL3DataTablePOSITION.Namespace = "";
            // 
            // coldsScrapL3DataTableAMOUNT
            // 
            this.coldsScrapL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsScrapL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsScrapL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsScrapL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsScrapL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsScrapL3DataTableIDX
            // 
            this.coldsScrapL3DataTableIDX.Caption = "IDX";
            this.coldsScrapL3DataTableIDX.ColumnName = "IDX";
            this.coldsScrapL3DataTableIDX.DataType = typeof(int);
            this.coldsScrapL3DataTableIDX.DefaultValue = 0;
            this.coldsScrapL3DataTableIDX.Namespace = "";
            // 
            // coldsScrapL3DataTableCheckFlag
            // 
            this.coldsScrapL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsScrapL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsScrapL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsScrapL3DataTableCheckFlag.Namespace = "";
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnInStore
            // 
            this.Adapter.SetAccessRight(this.btnInStore, "BtnScrapInStore");
            this.btnInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnInStore.Image")));
            this.btnInStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInStore.Name = "btnInStore";
            this.btnInStore.Size = new System.Drawing.Size(67, 40);
            this.btnInStore.Text = "入库";
            this.btnInStore.Click += new System.EventHandler(this.btnInStore_Click);
            // 
            // btnOutStore
            // 
            this.Adapter.SetAccessRight(this.btnOutStore, "BtnScrapOutStore");
            this.btnOutStore.Image = ((System.Drawing.Image)(resources.GetObject("btnOutStore.Image")));
            this.btnOutStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutStore.Name = "btnOutStore";
            this.btnOutStore.Size = new System.Drawing.Size(67, 40);
            this.btnOutStore.Text = "出库";
            this.btnOutStore.Click += new System.EventHandler(this.btnOutStore_Click);
            // 
            // btnCancelOutStore
            // 
            this.Adapter.SetAccessRight(this.btnCancelOutStore, "BtnScrapOutStoreCanel");
            this.btnCancelOutStore.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelOutStore.Image")));
            this.btnCancelOutStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelOutStore.Name = "btnCancelOutStore";
            this.btnCancelOutStore.Size = new System.Drawing.Size(91, 40);
            this.btnCancelOutStore.Text = "撤销出库";
            this.btnCancelOutStore.Click += new System.EventHandler(this.btnCancelOutStore_Click);
            // 
            // btnBalanceStore
            // 
            this.Adapter.SetAccessRight(this.btnBalanceStore, "BtnScrapBanlance");
            this.btnBalanceStore.Image = ((System.Drawing.Image)(resources.GetObject("btnBalanceStore.Image")));
            this.btnBalanceStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBalanceStore.Name = "btnBalanceStore";
            this.btnBalanceStore.Size = new System.Drawing.Size(67, 40);
            this.btnBalanceStore.Text = "盘库";
            this.btnBalanceStore.Click += new System.EventHandler(this.btnBalanceStore_Click);
            // 
            // btnScarpInformationInput
            // 
            this.Adapter.SetAccessRight(this.btnScarpInformationInput, "BtnScrapExl");
            this.btnScarpInformationInput.Image = ((System.Drawing.Image)(resources.GetObject("btnScarpInformationInput.Image")));
            this.btnScarpInformationInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScarpInformationInput.Name = "btnScarpInformationInput";
            this.btnScarpInformationInput.Size = new System.Drawing.Size(84, 40);
            this.btnScarpInformationInput.Text = "EXL导入";
            this.btnScarpInformationInput.Click += new System.EventHandler(this.btnScarpInformationInput_Click);
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnInStore,
            this.btnOutStore,
            this.btnCancelOutStore,
            this.btnBalanceStore,
            this.btnScarpInformationInput});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 27;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dsStoreID
            // 
            this.dsStoreID.AutoLoad = true;
            this.dsStoreID.AutoSubscribe = true;
            this.dsStoreID.DataSetName = "L3DataSet";
            this.dsStoreID.DeleteMethod = null;
            this.dsStoreID.InsertMethod = null;
            this.dsStoreID.L3DataAdapter = this.Adapter;
            this.dsStoreID.LoadEvent = "Click";
            this.dsStoreID.LoadTrigger = null;
            this.dsStoreID.RefreshValve = 1000;
            this.dsStoreID.SourceCommand = null;
            this.dsStoreID.SourceCondition = "CODE_GROUP = \'ScrapArea\'";
            this.dsStoreID.SourceMethod = "";
            this.dsStoreID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreID.SubscribeTarget = null;
            this.dsStoreID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreID});
            this.dsStoreID.UpdateEvent = "Click";
            this.dsStoreID.UpdateMethod = null;
            this.dsStoreID.UpdateTrigger = null;
            // 
            // schemadsStoreID
            // 
            this.schemadsStoreID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreIDL3DataTableCode,
            this.coldsStoreIDL3DataTableCode_Des});
            this.schemadsStoreID.TableName = "L3DataTable";
            // 
            // coldsStoreIDL3DataTableCode
            // 
            this.coldsStoreIDL3DataTableCode.Caption = "Code";
            this.coldsStoreIDL3DataTableCode.ColumnName = "Code";
            this.coldsStoreIDL3DataTableCode.Namespace = "";
            // 
            // coldsStoreIDL3DataTableCode_Des
            // 
            this.coldsStoreIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsScrapSend
            // 
            this.dsScrapSend.AutoLoad = true;
            this.dsScrapSend.AutoSubscribe = true;
            this.dsScrapSend.DataSetName = "L3DataSet";
            this.dsScrapSend.DeleteMethod = "";
            this.dsScrapSend.InsertMethod = "";
            this.dsScrapSend.L3DataAdapter = null;
            this.dsScrapSend.LoadEvent = "Click";
            this.dsScrapSend.LoadTrigger = null;
            this.dsScrapSend.RefreshValve = 1000;
            this.dsScrapSend.SourceCommand = null;
            this.dsScrapSend.SourceCondition = "";
            this.dsScrapSend.SourceMethod = "";
            this.dsScrapSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsScrapSend.SourceURI = "";
            this.dsScrapSend.SubscribeTarget = "Version";
            this.dsScrapSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapSend});
            this.dsScrapSend.UpdateEvent = "Click";
            this.dsScrapSend.UpdateMethod = "";
            this.dsScrapSend.UpdateTrigger = null;
            // 
            // schemadsScrapSend
            // 
            this.schemadsScrapSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapSendL3DataTableMATERIALTYPE,
            this.coldsScrapSendL3DataTableMATERIALID,
            this.coldsScrapSendL3DataTablePOSITION,
            this.coldsScrapSendL3DataTableAMOUNT,
            this.coldsScrapSendL3DataTableIDX});
            this.schemadsScrapSend.TableName = "L3DataTable";
            // 
            // coldsScrapSendL3DataTableMATERIALTYPE
            // 
            this.coldsScrapSendL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsScrapSendL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsScrapSendL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsScrapSendL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsScrapSendL3DataTableMATERIALID
            // 
            this.coldsScrapSendL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsScrapSendL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsScrapSendL3DataTableMATERIALID.DefaultValue = "";
            this.coldsScrapSendL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsScrapSendL3DataTablePOSITION
            // 
            this.coldsScrapSendL3DataTablePOSITION.Caption = "POSITION";
            this.coldsScrapSendL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsScrapSendL3DataTablePOSITION.DefaultValue = "";
            this.coldsScrapSendL3DataTablePOSITION.Namespace = "";
            // 
            // coldsScrapSendL3DataTableAMOUNT
            // 
            this.coldsScrapSendL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsScrapSendL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsScrapSendL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsScrapSendL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsScrapSendL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsScrapSendL3DataTableIDX
            // 
            this.coldsScrapSendL3DataTableIDX.Caption = "IDX";
            this.coldsScrapSendL3DataTableIDX.ColumnName = "IDX";
            this.coldsScrapSendL3DataTableIDX.DataType = typeof(int);
            this.coldsScrapSendL3DataTableIDX.DefaultValue = 0;
            this.coldsScrapSendL3DataTableIDX.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 33;
            // 
            // dvM
            // 
            this.dvM.AllowUserToAddRows = false;
            this.dvM.AutoGenerateColumns = false;
            this.dvM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.mATERIALTYPEDataGridViewTextBoxColumn,
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.iDXDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsScrap;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.Margin = new System.Windows.Forms.Padding(0);
            this.dvM.Name = "dvM";
            this.dvM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvM.Size = new System.Drawing.Size(1000, 632);
            this.dvM.TabIndex = 32;
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // mATERIALTYPEDataGridViewTextBoxColumn
            // 
            this.mATERIALTYPEDataGridViewTextBoxColumn.DataPropertyName = "MATERIALTYPE";
            this.mATERIALTYPEDataGridViewTextBoxColumn.HeaderText = "材料类型";
            this.mATERIALTYPEDataGridViewTextBoxColumn.Name = "mATERIALTYPEDataGridViewTextBoxColumn";
            this.mATERIALTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.DataSource = this.dsScrapCode;
            this.mATERIALIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.mATERIALIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "材料";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            this.mATERIALIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mATERIALIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mATERIALIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mATERIALIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dsScrapCode
            // 
            this.dsScrapCode.AutoLoad = true;
            this.dsScrapCode.AutoSubscribe = true;
            this.dsScrapCode.DataSetName = "L3DataSet";
            this.dsScrapCode.DeleteMethod = null;
            this.dsScrapCode.InsertMethod = null;
            this.dsScrapCode.L3DataAdapter = this.Adapter;
            this.dsScrapCode.LoadEvent = "Click";
            this.dsScrapCode.LoadTrigger = null;
            this.dsScrapCode.RefreshValve = 1000;
            this.dsScrapCode.SourceCommand = null;
            this.dsScrapCode.SourceCondition = "CODE_GROUP = \'SCRAP_CODE\'";
            this.dsScrapCode.SourceMethod = "";
            this.dsScrapCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapCode.SubscribeTarget = null;
            this.dsScrapCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapCode});
            this.dsScrapCode.UpdateEvent = "Click";
            this.dsScrapCode.UpdateMethod = null;
            this.dsScrapCode.UpdateTrigger = null;
            // 
            // schemadsScrapCode
            // 
            this.schemadsScrapCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapCodeL3DataTableCode,
            this.coldsScrapCodeL3DataTableCode_Des});
            this.schemadsScrapCode.TableName = "L3DataTable";
            // 
            // coldsScrapCodeL3DataTableCode
            // 
            this.coldsScrapCodeL3DataTableCode.Caption = "Code";
            this.coldsScrapCodeL3DataTableCode.ColumnName = "Code";
            this.coldsScrapCodeL3DataTableCode.Namespace = "";
            // 
            // coldsScrapCodeL3DataTableCode_Des
            // 
            this.coldsScrapCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapCodeL3DataTableCode_Des.Namespace = "";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.DataSource = this.dsStoreID;
            this.pOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "位置";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOSITIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "重量";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            this.aMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDXDataGridViewTextBoxColumn
            // 
            this.iDXDataGridViewTextBoxColumn.DataPropertyName = "IDX";
            this.iDXDataGridViewTextBoxColumn.HeaderText = "IDX";
            this.iDXDataGridViewTextBoxColumn.Name = "iDXDataGridViewTextBoxColumn";
            this.iDXDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDXDataGridViewTextBoxColumn.Visible = false;
            // 
            // l3dbxGetStore
            // 
            this.l3dbxGetStore.DataFormat = null;
            this.l3dbxGetStore.DataObject = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.l3dbxGetStore.DataProperty = "MaterialInputted";
            this.l3dbxGetStore.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.l3dbxGetStore.L3DataAdapter = this.Adapter;
            this.l3dbxGetStore.Location = new System.Drawing.Point(497, 12);
            this.l3dbxGetStore.Name = "l3dbxGetStore";
            this.l3dbxGetStore.Size = new System.Drawing.Size(100, 21);
            this.l3dbxGetStore.TabIndex = 33;
            this.l3dbxGetStore.Value = null;
            this.l3dbxGetStore.Visible = false;
            this.l3dbxGetStore.TextChanged += new System.EventHandler(this.l3dbxGetStore_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "移到第一条记录";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到上一条记录";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel2.Text = "/ {0}";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到下一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到最后一条记录";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel3.Text = "               ";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator1.BackgroundImage")));
            this.bindingNavigator1.BindingSource = this.bsScrap;
            this.bindingNavigator1.CountItem = this.toolStripLabel2;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripTextBox1,
            this.toolStripLabel2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 43);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 32;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // ScrapStoreMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.l3dbxGetStore);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScrapStoreMagFrm";
            this.TabText = "废钢管理";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapStoreMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.ScrapStoreMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsScrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrap)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapSend)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsScrap;
        private System.Windows.Forms.BindingSource bsScrap;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnInStore;
        private System.Windows.Forms.ToolStripButton btnOutStore;
        private System.Windows.Forms.ToolStripButton btnBalanceStore;
        private AppSvrHMI.L3DataSet dsStoreID;
        private System.Data.DataTable schemadsStoreID;
        private System.Data.DataColumn coldsStoreIDL3DataTableCode;
        private System.Data.DataColumn coldsStoreIDL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdQuery;
        private AppSvrHMI.L3CommandParameter l3cmdpScrap;
        private System.Data.DataTable schemadsScrap;
        private System.Data.DataColumn coldsScrapL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsScrapL3DataTableMATERIALID;
        private System.Data.DataColumn coldsScrapL3DataTablePOSITION;
        private System.Data.DataColumn coldsScrapL3DataTableAMOUNT;
        private System.Data.DataColumn coldsScrapL3DataTableIDX;
        private System.Data.DataColumn coldsScrapL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsScrapSend;
        private System.Data.DataTable schemadsScrapSend;
        private System.Data.DataColumn coldsScrapSendL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsScrapSendL3DataTableMATERIALID;
        private System.Data.DataColumn coldsScrapSendL3DataTablePOSITION;
        private System.Data.DataColumn coldsScrapSendL3DataTableAMOUNT;
        private System.Data.DataColumn coldsScrapSendL3DataTableIDX;
        private System.Windows.Forms.ToolStripButton btnScarpInformationInput;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private AppSvrHMI.L3DataSet dsScrapCode;
        private System.Data.DataTable schemadsScrapCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDXDataGridViewTextBoxColumn;
        private AppSvrHMI.L3DataBox l3dbxGetStore;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnCancelOutStore;
    }
}