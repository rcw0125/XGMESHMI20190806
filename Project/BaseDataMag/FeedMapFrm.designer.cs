namespace BaseDataMag
{
    partial class FeedMapFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedMapFrm));
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
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
            this.dsAlloyArea = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyArea = new System.Data.DataTable();
            this.coldsAlloyAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvFeed = new System.Windows.Forms.DataGridView();
            this.dsTopSlagFlag = new AppSvrHMI.L3DataSet();
            this.schemadsTopSlagFlag = new System.Data.DataTable();
            this.coldsTopSlagFlagL3DataTablecode_des = new System.Data.DataColumn();
            this.coldsTopSlagFlagL3DataTablecode_val_long = new System.Data.DataColumn();
            this.bsFeed = new System.Windows.Forms.BindingSource(this.components);
            this.dsFeed = new AppSvrHMI.L3DataSet();
            this.schemadsFeed = new System.Data.DataTable();
            this.coldsFeedL3DataTableGUID = new System.Data.DataColumn();
            this.coldsFeedL3DataTableName = new System.Data.DataColumn();
            this.coldsFeedL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsFeedL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsFeedL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.coldsFeedL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.alloyAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.alloyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.topSlagFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.alloyVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
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
            // dsAlloyArea
            // 
            this.dsAlloyArea.AutoSubscribe = true;
            this.dsAlloyArea.DataSetName = "L3DataSet";
            this.dsAlloyArea.DeleteMethod = null;
            this.dsAlloyArea.InsertMethod = null;
            this.dsAlloyArea.L3DataAdapter = this.Adapter;
            this.dsAlloyArea.LoadEvent = "Click";
            this.dsAlloyArea.LoadTrigger = null;
            this.dsAlloyArea.RefreshValve = 1000;
            this.dsAlloyArea.SourceCommand = null;
            this.dsAlloyArea.SourceCondition = "code_group = \'AlloyWire\' order by code";
            this.dsAlloyArea.SourceMethod = "";
            this.dsAlloyArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyArea.SubscribeTarget = null;
            this.dsAlloyArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyArea});
            this.dsAlloyArea.UpdateEvent = "Click";
            this.dsAlloyArea.UpdateMethod = null;
            this.dsAlloyArea.UpdateTrigger = null;
            // 
            // schemadsAlloyArea
            // 
            this.schemadsAlloyArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyAreaL3DataTableCode,
            this.coldsAlloyAreaL3DataTableCode_Des});
            this.schemadsAlloyArea.TableName = "L3DataTable";
            // 
            // coldsAlloyAreaL3DataTableCode
            // 
            this.coldsAlloyAreaL3DataTableCode.Caption = "Code";
            this.coldsAlloyAreaL3DataTableCode.ColumnName = "Code";
            this.coldsAlloyAreaL3DataTableCode.Namespace = "";
            // 
            // coldsAlloyAreaL3DataTableCode_Des
            // 
            this.coldsAlloyAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAlloyAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyAreaL3DataTableCode_Des.Namespace = "";
            // 
            // dsAlloyCode
            // 
            this.dsAlloyCode.AutoSubscribe = true;
            this.dsAlloyCode.DataSetName = "L3DataSet";
            this.dsAlloyCode.DeleteMethod = null;
            this.dsAlloyCode.InsertMethod = null;
            this.dsAlloyCode.L3DataAdapter = this.Adapter;
            this.dsAlloyCode.LoadEvent = "Click";
            this.dsAlloyCode.LoadTrigger = null;
            this.dsAlloyCode.RefreshValve = 1000;
            this.dsAlloyCode.SourceCommand = null;
            this.dsAlloyCode.SourceCondition = "CODE_FUNCTION_GROUP = \'FeedWire\' order by code";
            this.dsAlloyCode.SourceMethod = "";
            this.dsAlloyCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyCode.SubscribeTarget = null;
            this.dsAlloyCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsAlloyCode.UpdateEvent = "Click";
            this.dsAlloyCode.UpdateMethod = null;
            this.dsAlloyCode.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableCode,
            this.coll3DataSet1L3DataTableCode_Des});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableCode
            // 
            this.coll3DataSet1L3DataTableCode.Caption = "Code";
            this.coll3DataSet1L3DataTableCode.ColumnName = "Code";
            this.coll3DataSet1L3DataTableCode.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Des
            // 
            this.coll3DataSet1L3DataTableCode_Des.Caption = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.Namespace = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnConfirm,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1002, 43);
            this.toolStrip1.TabIndex = 63;
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
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.groupBox2);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1002, 703);
            this.hmiRootPanel1.TabIndex = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvFeed);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 703);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "喂丝机";
            // 
            // dvFeed
            // 
            this.dvFeed.AllowUserToAddRows = false;
            this.dvFeed.AutoGenerateColumns = false;
            this.dvFeed.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvFeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alloyAreaDataGridViewTextBoxColumn,
            this.alloyCodeDataGridViewTextBoxColumn,
            this.topSlagFlagDataGridViewTextBoxColumn,
            this.alloyVendorDataGridViewTextBoxColumn});
            this.dvFeed.DataSource = this.bsFeed;
            this.dvFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFeed.Location = new System.Drawing.Point(3, 17);
            this.dvFeed.Name = "dvFeed";
            this.dvFeed.RowHeadersVisible = false;
            this.dvFeed.RowTemplate.Height = 23;
            this.dvFeed.Size = new System.Drawing.Size(996, 683);
            this.dvFeed.TabIndex = 0;
            this.dvFeed.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // dsTopSlagFlag
            // 
            this.dsTopSlagFlag.AutoSubscribe = true;
            this.dsTopSlagFlag.DataSetName = "L3DataSet";
            this.dsTopSlagFlag.DeleteMethod = null;
            this.dsTopSlagFlag.InsertMethod = null;
            this.dsTopSlagFlag.L3DataAdapter = this.Adapter;
            this.dsTopSlagFlag.LoadEvent = "Click";
            this.dsTopSlagFlag.LoadTrigger = null;
            this.dsTopSlagFlag.RefreshValve = 1000;
            this.dsTopSlagFlag.SourceCommand = null;
            this.dsTopSlagFlag.SourceCondition = "CODE_GROUP = \'TopSlagFlag\'and code is not null";
            this.dsTopSlagFlag.SourceMethod = "";
            this.dsTopSlagFlag.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTopSlagFlag.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTopSlagFlag.SubscribeTarget = null;
            this.dsTopSlagFlag.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTopSlagFlag});
            this.dsTopSlagFlag.UpdateEvent = "Click";
            this.dsTopSlagFlag.UpdateMethod = null;
            this.dsTopSlagFlag.UpdateTrigger = null;
            // 
            // schemadsTopSlagFlag
            // 
            this.schemadsTopSlagFlag.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTopSlagFlagL3DataTablecode_des,
            this.coldsTopSlagFlagL3DataTablecode_val_long});
            this.schemadsTopSlagFlag.TableName = "L3DataTable";
            // 
            // coldsTopSlagFlagL3DataTablecode_des
            // 
            this.coldsTopSlagFlagL3DataTablecode_des.Caption = "code_des";
            this.coldsTopSlagFlagL3DataTablecode_des.ColumnName = "code_des";
            this.coldsTopSlagFlagL3DataTablecode_des.Namespace = "";
            // 
            // coldsTopSlagFlagL3DataTablecode_val_long
            // 
            this.coldsTopSlagFlagL3DataTablecode_val_long.Caption = "code_val_long";
            this.coldsTopSlagFlagL3DataTablecode_val_long.ColumnName = "code_val_long";
            this.coldsTopSlagFlagL3DataTablecode_val_long.DataType = typeof(int);
            this.coldsTopSlagFlagL3DataTablecode_val_long.Namespace = "";
            // 
            // bsFeed
            // 
            this.bsFeed.DataMember = "L3DataTable";
            this.bsFeed.DataSource = this.dsFeed;
            // 
            // dsFeed
            // 
            this.dsFeed.AutoSubscribe = true;
            this.dsFeed.DataSetName = "L3DataSet";
            this.dsFeed.DeleteMethod = "";
            this.dsFeed.InsertMethod = "";
            this.dsFeed.L3DataAdapter = this.Adapter;
            this.dsFeed.LoadEvent = "";
            this.dsFeed.LoadTrigger = null;
            this.dsFeed.RefreshValve = 1000;
            this.dsFeed.SourceCommand = null;
            this.dsFeed.SourceCondition = "substr(Alloy_Area,4,1) = \'W\'";
            this.dsFeed.SourceMethod = "";
            this.dsFeed.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFeed.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsFeed.SubscribeTarget = null;
            this.dsFeed.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFeed});
            this.dsFeed.UpdateEvent = "";
            this.dsFeed.UpdateMethod = "";
            this.dsFeed.UpdateTrigger = null;
            // 
            // schemadsFeed
            // 
            this.schemadsFeed.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFeedL3DataTableGUID,
            this.coldsFeedL3DataTableName,
            this.coldsFeedL3DataTableAlloy_Area,
            this.coldsFeedL3DataTableAlloy_Code,
            this.coldsFeedL3DataTableTopSlagFlag,
            this.coldsFeedL3DataTableAlloy_Vendor});
            this.schemadsFeed.TableName = "L3DataTable";
            // 
            // coldsFeedL3DataTableGUID
            // 
            this.coldsFeedL3DataTableGUID.Caption = "GUID";
            this.coldsFeedL3DataTableGUID.ColumnName = "GUID";
            this.coldsFeedL3DataTableGUID.Namespace = "";
            // 
            // coldsFeedL3DataTableName
            // 
            this.coldsFeedL3DataTableName.Caption = "Name";
            this.coldsFeedL3DataTableName.ColumnName = "Name";
            this.coldsFeedL3DataTableName.Namespace = "";
            // 
            // coldsFeedL3DataTableAlloy_Area
            // 
            this.coldsFeedL3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsFeedL3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsFeedL3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsFeedL3DataTableAlloy_Code
            // 
            this.coldsFeedL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsFeedL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsFeedL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsFeedL3DataTableTopSlagFlag
            // 
            this.coldsFeedL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsFeedL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsFeedL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsFeedL3DataTableTopSlagFlag.Namespace = "";
            // 
            // coldsFeedL3DataTableAlloy_Vendor
            // 
            this.coldsFeedL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsFeedL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsFeedL3DataTableAlloy_Vendor.Namespace = "";
            // 
            // alloyAreaDataGridViewTextBoxColumn
            // 
            this.alloyAreaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alloyAreaDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Area";
            this.alloyAreaDataGridViewTextBoxColumn.DataSource = this.dsAlloyArea;
            this.alloyAreaDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.alloyAreaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.alloyAreaDataGridViewTextBoxColumn.HeaderText = "喂丝机";
            this.alloyAreaDataGridViewTextBoxColumn.Name = "alloyAreaDataGridViewTextBoxColumn";
            this.alloyAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.alloyAreaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alloyAreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alloyAreaDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.alloyAreaDataGridViewTextBoxColumn.Width = 66;
            // 
            // alloyCodeDataGridViewTextBoxColumn
            // 
            this.alloyCodeDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Code";
            this.alloyCodeDataGridViewTextBoxColumn.DataSource = this.dsAlloyCode;
            this.alloyCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.alloyCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.alloyCodeDataGridViewTextBoxColumn.HeaderText = "喂丝编码";
            this.alloyCodeDataGridViewTextBoxColumn.Name = "alloyCodeDataGridViewTextBoxColumn";
            this.alloyCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alloyCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alloyCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // topSlagFlagDataGridViewTextBoxColumn
            // 
            this.topSlagFlagDataGridViewTextBoxColumn.DataPropertyName = "TopSlagFlag";
            this.topSlagFlagDataGridViewTextBoxColumn.DataSource = this.dsTopSlagFlag;
            this.topSlagFlagDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.code_des";
            this.topSlagFlagDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.topSlagFlagDataGridViewTextBoxColumn.HeaderText = "顶渣标志";
            this.topSlagFlagDataGridViewTextBoxColumn.Name = "topSlagFlagDataGridViewTextBoxColumn";
            this.topSlagFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.topSlagFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.topSlagFlagDataGridViewTextBoxColumn.ValueMember = "L3DataTable.code_val_long";
            // 
            // alloyVendorDataGridViewTextBoxColumn
            // 
            this.alloyVendorDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Vendor";
            this.alloyVendorDataGridViewTextBoxColumn.HeaderText = "厂家";
            this.alloyVendorDataGridViewTextBoxColumn.Name = "alloyVendorDataGridViewTextBoxColumn";
            // 
            // FeedMapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 746);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FeedMapFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "喂丝机与喂丝编码维护";
            this.Text = "喂丝机与喂丝编码维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedMapFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private AppSvrHMI.L3DataSet dsAlloyArea;
        private System.Data.DataTable schemadsAlloyArea;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvFeed;
        private AppSvrHMI.L3DataSet dsFeed;
        private System.Data.DataTable schemadsFeed;
        private System.Data.DataColumn coldsFeedL3DataTableGUID;
        private System.Data.DataColumn coldsFeedL3DataTableName;
        private System.Data.DataColumn coldsFeedL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsFeedL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsFeedL3DataTableTopSlagFlag;
        private System.Data.DataColumn coldsFeedL3DataTableAlloy_Vendor;
        private System.Windows.Forms.BindingSource bsFeed;
        private AppSvrHMI.L3DataSet dsTopSlagFlag;
        private System.Data.DataTable schemadsTopSlagFlag;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTablecode_des;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTablecode_val_long;
        private System.Windows.Forms.DataGridViewComboBoxColumn alloyAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn alloyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn topSlagFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alloyVendorDataGridViewTextBoxColumn;
    }
}