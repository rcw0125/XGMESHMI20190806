namespace StoreMag.ScrapStore
{
    partial class ScrapInStoreFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapInStoreFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInStore = new System.Windows.Forms.DataGridView();
            this.dsScrapCode = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsScrapCode = new System.Data.DataTable();
            this.coldsScrapCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.ScrapArea = new AppSvrHMI.L3DataSet();
            this.schemaScrapArea = new System.Data.DataTable();
            this.colScrapAreaL3DataTableCode = new System.Data.DataColumn();
            this.colScrapAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.bsInStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsInStore = new AppSvrHMI.L3DataSet();
            this.schemadsInStore = new System.Data.DataTable();
            this.coldsInStoreL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsInStoreL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableIDX = new System.Data.DataColumn();
            this.coldsInStoreL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdScrapInStore = new AppSvrHMI.L3Command(this.components);
            this.dsScrapInStoreSend = new AppSvrHMI.L3DataSet();
            this.schemadsScrapInStoreSend = new System.Data.DataTable();
            this.coldsScrapInStoreSendL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsScrapInStoreSendL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsScrapInStoreSendL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsScrapInStoreSendL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsScrapInStoreSendL3DataTableIDX = new System.Data.DataColumn();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mATERIALTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapInStoreSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapInStoreSend)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator5,
            this.toolStripButton11});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 43);
            this.toolStrip1.TabIndex = 61;
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton11.Text = "入库";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 389);
            this.tabControl1.TabIndex = 62;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hmiRootPanel1);
            this.tabPage2.Controls.Add(this.bindingNavigator2);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(855, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.hmiRootPanel1.Controls.Add(this.dvInStore);
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 28);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(855, 336);
            this.hmiRootPanel1.TabIndex = 17;
            // 
            // dvInStore
            // 
            this.dvInStore.AllowUserToAddRows = false;
            this.dvInStore.AutoGenerateColumns = false;
            this.dvInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvInStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.mATERIALTYPEDataGridViewTextBoxColumn,
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.iDXDataGridViewTextBoxColumn});
            this.dvInStore.DataSource = this.bsInStore;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvInStore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInStore.Location = new System.Drawing.Point(0, 0);
            this.dvInStore.Margin = new System.Windows.Forms.Padding(0);
            this.dvInStore.Name = "dvInStore";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvInStore.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvInStore.RowHeadersVisible = false;
            this.dvInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvInStore.RowTemplate.Height = 23;
            this.dvInStore.Size = new System.Drawing.Size(855, 336);
            this.dvInStore.TabIndex = 18;
            this.dvInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInStore_DataError);
            // 
            // dsScrapCode
            // 
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
            // Adapter
            // 
            this.Adapter.Session = null;
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
            // ScrapArea
            // 
            this.ScrapArea.AutoSubscribe = true;
            this.ScrapArea.DataSetName = "L3DataSet";
            this.ScrapArea.DeleteMethod = null;
            this.ScrapArea.InsertMethod = null;
            this.ScrapArea.L3DataAdapter = this.Adapter;
            this.ScrapArea.LoadEvent = "Click";
            this.ScrapArea.LoadTrigger = null;
            this.ScrapArea.RefreshValve = 1000;
            this.ScrapArea.SourceCommand = null;
            this.ScrapArea.SourceCondition = "CODE_GROUP = \'ScrapArea\'";
            this.ScrapArea.SourceMethod = "";
            this.ScrapArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.ScrapArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.ScrapArea.SubscribeTarget = null;
            this.ScrapArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemaScrapArea});
            this.ScrapArea.UpdateEvent = "Click";
            this.ScrapArea.UpdateMethod = null;
            this.ScrapArea.UpdateTrigger = null;
            // 
            // schemaScrapArea
            // 
            this.schemaScrapArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.colScrapAreaL3DataTableCode,
            this.colScrapAreaL3DataTableCode_Des});
            this.schemaScrapArea.TableName = "L3DataTable";
            // 
            // colScrapAreaL3DataTableCode
            // 
            this.colScrapAreaL3DataTableCode.Caption = "Code";
            this.colScrapAreaL3DataTableCode.ColumnName = "Code";
            this.colScrapAreaL3DataTableCode.Namespace = "";
            // 
            // colScrapAreaL3DataTableCode_Des
            // 
            this.colScrapAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.colScrapAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.colScrapAreaL3DataTableCode_Des.Namespace = "";
            // 
            // bsInStore
            // 
            this.bsInStore.DataMember = "L3DataTable";
            this.bsInStore.DataSource = this.dsInStore;
            // 
            // dsInStore
            // 
            this.dsInStore.AutoSubscribe = true;
            this.dsInStore.DataSetName = "L3DataSet";
            this.dsInStore.DeleteMethod = "";
            this.dsInStore.InsertMethod = "";
            this.dsInStore.L3DataAdapter = this.Adapter;
            this.dsInStore.LoadEvent = "Click";
            this.dsInStore.LoadTrigger = null;
            this.dsInStore.RefreshValve = 1000;
            this.dsInStore.SourceCommand = null;
            this.dsInStore.SourceCondition = null;
            this.dsInStore.SourceMethod = "GetMaterialOnInputCache";
            this.dsInStore.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsInStore.SourceURI = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.dsInStore.SubscribeTarget = null;
            this.dsInStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInStore});
            this.dsInStore.UpdateEvent = "Click";
            this.dsInStore.UpdateMethod = "";
            this.dsInStore.UpdateTrigger = null;
            // 
            // schemadsInStore
            // 
            this.schemadsInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInStoreL3DataTableMATERIALTYPE,
            this.coldsInStoreL3DataTableMATERIALID,
            this.coldsInStoreL3DataTablePOSITION,
            this.coldsInStoreL3DataTableAMOUNT,
            this.coldsInStoreL3DataTableIDX,
            this.coldsInStoreL3DataTableCheckFlag});
            this.schemadsInStore.TableName = "L3DataTable";
            // 
            // coldsInStoreL3DataTableMATERIALTYPE
            // 
            this.coldsInStoreL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsInStoreL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsInStoreL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsInStoreL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsInStoreL3DataTableMATERIALID
            // 
            this.coldsInStoreL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsInStoreL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsInStoreL3DataTableMATERIALID.DefaultValue = "";
            this.coldsInStoreL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsInStoreL3DataTablePOSITION
            // 
            this.coldsInStoreL3DataTablePOSITION.Caption = "POSITION";
            this.coldsInStoreL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsInStoreL3DataTablePOSITION.DefaultValue = "";
            this.coldsInStoreL3DataTablePOSITION.Namespace = "";
            // 
            // coldsInStoreL3DataTableAMOUNT
            // 
            this.coldsInStoreL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsInStoreL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsInStoreL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsInStoreL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsInStoreL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsInStoreL3DataTableIDX
            // 
            this.coldsInStoreL3DataTableIDX.Caption = "IDX";
            this.coldsInStoreL3DataTableIDX.ColumnName = "IDX";
            this.coldsInStoreL3DataTableIDX.DataType = typeof(int);
            this.coldsInStoreL3DataTableIDX.DefaultValue = 0;
            this.coldsInStoreL3DataTableIDX.Namespace = "";
            // 
            // coldsInStoreL3DataTableCheckFlag
            // 
            this.coldsInStoreL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsInStoreL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsInStoreL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsInStoreL3DataTableCheckFlag.Namespace = "";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bindingNavigator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bindingNavigator2.BackgroundImage")));
            this.bindingNavigator2.BindingSource = this.bsInStore;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(855, 25);
            this.bindingNavigator2.TabIndex = 16;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到第一条记录";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到上一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到下一条记录";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "移到最后一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(354, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(122, 21);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "O_P_005";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 21);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "P0900601005";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(298, 248);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "计划号:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(292, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 19;
            this.label18.Text = "重量[kg]:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(316, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 17;
            this.label20.Text = "库位:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(52, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "XXXXXXX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "原料宽度[mm]:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(22, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "原料厚度[mm]:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(242, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 2);
            this.panel2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "钢种:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(241, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "产品规范码(PSR):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(245, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 2);
            this.panel1.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(302, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 3;
            this.label15.Text = "合同号:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(243, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "卷号:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdScrapInStore
            // 
            this.cmdScrapInStore.Adapter = null;
            this.cmdScrapInStore.MergeReturnTarget = false;
            this.cmdScrapInStore.Method = null;
            this.cmdScrapInStore.Object = null;
            this.cmdScrapInStore.ReturnTarget = null;
            this.cmdScrapInStore.ReturnTargetProperty = null;
            this.cmdScrapInStore.Trigger = null;
            this.cmdScrapInStore.TriggerEvent = "Click";
            // 
            // dsScrapInStoreSend
            // 
            this.dsScrapInStoreSend.AutoSubscribe = true;
            this.dsScrapInStoreSend.DataSetName = "L3DataSet";
            this.dsScrapInStoreSend.DeleteMethod = "";
            this.dsScrapInStoreSend.InsertMethod = "";
            this.dsScrapInStoreSend.L3DataAdapter = null;
            this.dsScrapInStoreSend.LoadEvent = "Click";
            this.dsScrapInStoreSend.LoadTrigger = null;
            this.dsScrapInStoreSend.RefreshValve = 1000;
            this.dsScrapInStoreSend.SourceCommand = null;
            this.dsScrapInStoreSend.SourceCondition = "";
            this.dsScrapInStoreSend.SourceMethod = "";
            this.dsScrapInStoreSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsScrapInStoreSend.SourceURI = "";
            this.dsScrapInStoreSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapInStoreSend});
            this.dsScrapInStoreSend.UpdateEvent = "Click";
            this.dsScrapInStoreSend.UpdateMethod = "";
            this.dsScrapInStoreSend.UpdateTrigger = null;
            // 
            // schemadsScrapInStoreSend
            // 
            this.schemadsScrapInStoreSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapInStoreSendL3DataTableMATERIALTYPE,
            this.coldsScrapInStoreSendL3DataTableMATERIALID,
            this.coldsScrapInStoreSendL3DataTablePOSITION,
            this.coldsScrapInStoreSendL3DataTableAMOUNT,
            this.coldsScrapInStoreSendL3DataTableIDX});
            this.schemadsScrapInStoreSend.TableName = "L3DataTable";
            // 
            // coldsScrapInStoreSendL3DataTableMATERIALTYPE
            // 
            this.coldsScrapInStoreSendL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsScrapInStoreSendL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsScrapInStoreSendL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsScrapInStoreSendL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsScrapInStoreSendL3DataTableMATERIALID
            // 
            this.coldsScrapInStoreSendL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsScrapInStoreSendL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsScrapInStoreSendL3DataTableMATERIALID.DefaultValue = "";
            this.coldsScrapInStoreSendL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsScrapInStoreSendL3DataTablePOSITION
            // 
            this.coldsScrapInStoreSendL3DataTablePOSITION.Caption = "POSITION";
            this.coldsScrapInStoreSendL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsScrapInStoreSendL3DataTablePOSITION.DefaultValue = "";
            this.coldsScrapInStoreSendL3DataTablePOSITION.Namespace = "";
            // 
            // coldsScrapInStoreSendL3DataTableAMOUNT
            // 
            this.coldsScrapInStoreSendL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsScrapInStoreSendL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsScrapInStoreSendL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsScrapInStoreSendL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsScrapInStoreSendL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsScrapInStoreSendL3DataTableIDX
            // 
            this.coldsScrapInStoreSendL3DataTableIDX.Caption = "IDX";
            this.coldsScrapInStoreSendL3DataTableIDX.ColumnName = "IDX";
            this.coldsScrapInStoreSendL3DataTableIDX.DataType = typeof(int);
            this.coldsScrapInStoreSendL3DataTableIDX.DefaultValue = 0;
            this.coldsScrapInStoreSendL3DataTableIDX.Namespace = "";
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
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.DataSource = this.dsScrapCode;
            this.mATERIALIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.mATERIALIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "材料编码";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            this.mATERIALIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mATERIALIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mATERIALIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.DataSource = this.ScrapArea;
            this.pOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "当前位置";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOSITIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "重量";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            // 
            // iDXDataGridViewTextBoxColumn
            // 
            this.iDXDataGridViewTextBoxColumn.DataPropertyName = "IDX";
            this.iDXDataGridViewTextBoxColumn.HeaderText = "IDX";
            this.iDXDataGridViewTextBoxColumn.Name = "iDXDataGridViewTextBoxColumn";
            this.iDXDataGridViewTextBoxColumn.Visible = false;
            // 
            // ScrapInStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 432);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ScrapInStoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "废钢生铁入库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapInStoreFrm_FormClosing);
            this.Load += new System.EventHandler(this.ScrapInStoreFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemaScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapInStoreSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapInStoreSend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource bsInStore;
        private AppSvrHMI.L3DataSet dsInStore;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvInStore;
        private AppSvrHMI.L3Command cmdScrapInStore;
        private System.Data.DataTable schemadsInStore;
        private System.Data.DataColumn coldsInStoreL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsInStoreL3DataTableMATERIALID;
        private System.Data.DataColumn coldsInStoreL3DataTablePOSITION;
        private System.Data.DataColumn coldsInStoreL3DataTableAMOUNT;
        private System.Data.DataColumn coldsInStoreL3DataTableIDX;
        private System.Data.DataColumn coldsInStoreL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsScrapInStoreSend;
        private System.Data.DataTable schemadsScrapInStoreSend;
        private System.Data.DataColumn coldsScrapInStoreSendL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsScrapInStoreSendL3DataTableMATERIALID;
        private System.Data.DataColumn coldsScrapInStoreSendL3DataTablePOSITION;
        private System.Data.DataColumn coldsScrapInStoreSendL3DataTableAMOUNT;
        private System.Data.DataColumn coldsScrapInStoreSendL3DataTableIDX;
        private AppSvrHMI.L3DataSet dsScrapCode;
        private System.Data.DataTable schemadsScrapCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode;
        private System.Data.DataColumn coldsScrapCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet ScrapArea;
        private System.Data.DataTable schemaScrapArea;
        private System.Data.DataColumn colScrapAreaL3DataTableCode;
        private System.Data.DataColumn colScrapAreaL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDXDataGridViewTextBoxColumn;
    }
}