namespace StoreMag.BulkStore
{
    partial class BulkAndAreaMapFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkAndAreaMapFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dsBulkArea = new AppSvrHMI.L3DataSet();
            this.schemadsBulkArea = new System.Data.DataTable();
            this.coldsBulkAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsBulkCode = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTopSlagFlag = new AppSvrHMI.L3DataSet();
            this.schemadsTopSlagFlag = new System.Data.DataTable();
            this.coldsTopSlagFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTopSlagFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.bsBOF = new System.Windows.Forms.BindingSource(this.components);
            this.dsBOF = new AppSvrHMI.L3DataSet();
            this.schemadsBOF = new System.Data.DataTable();
            this.coldsBOFL3DataTableBulk_Area = new System.Data.DataColumn();
            this.coldsBOFL3DataTableBulk_Code = new System.Data.DataColumn();
            this.coldsBOFL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBOF = new System.Windows.Forms.DataGridView();
            this.BulkAreaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BulkCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TopSlagFlag = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBOF)).BeginInit();
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
            // dsBulkArea
            // 
            this.dsBulkArea.AutoSubscribe = true;
            this.dsBulkArea.DataSetName = "L3DataSet";
            this.dsBulkArea.DeleteMethod = null;
            this.dsBulkArea.InsertMethod = null;
            this.dsBulkArea.L3DataAdapter = this.Adapter;
            this.dsBulkArea.LoadEvent = "Click";
            this.dsBulkArea.LoadTrigger = null;
            this.dsBulkArea.RefreshValve = 1000;
            this.dsBulkArea.SourceCommand = null;
            this.dsBulkArea.SourceCondition = "CODE_GROUP = \'BulkArea\' and CODE is not null";
            this.dsBulkArea.SourceMethod = "";
            this.dsBulkArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkArea.SubscribeTarget = null;
            this.dsBulkArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkArea});
            this.dsBulkArea.UpdateEvent = "Click";
            this.dsBulkArea.UpdateMethod = null;
            this.dsBulkArea.UpdateTrigger = null;
            // 
            // schemadsBulkArea
            // 
            this.schemadsBulkArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkAreaL3DataTableCode,
            this.coldsBulkAreaL3DataTableCode_Des});
            this.schemadsBulkArea.TableName = "L3DataTable";
            // 
            // coldsBulkAreaL3DataTableCode
            // 
            this.coldsBulkAreaL3DataTableCode.Caption = "Code";
            this.coldsBulkAreaL3DataTableCode.ColumnName = "Code";
            this.coldsBulkAreaL3DataTableCode.Namespace = "";
            // 
            // coldsBulkAreaL3DataTableCode_Des
            // 
            this.coldsBulkAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.Namespace = "";
            // 
            // dsBulkCode
            // 
            this.dsBulkCode.AutoSubscribe = true;
            this.dsBulkCode.DataSetName = "L3DataSet";
            this.dsBulkCode.DeleteMethod = null;
            this.dsBulkCode.InsertMethod = null;
            this.dsBulkCode.L3DataAdapter = this.Adapter;
            this.dsBulkCode.LoadEvent = "Click";
            this.dsBulkCode.LoadTrigger = null;
            this.dsBulkCode.RefreshValve = 1000;
            this.dsBulkCode.SourceCommand = null;
            this.dsBulkCode.SourceCondition = "CODE_GROUP = \'BULK_CODE\' and CODE is not null";
            this.dsBulkCode.SourceMethod = "";
            this.dsBulkCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkCode.SubscribeTarget = null;
            this.dsBulkCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsBulkCode.UpdateEvent = "Click";
            this.dsBulkCode.UpdateMethod = null;
            this.dsBulkCode.UpdateTrigger = null;
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
            this.dsTopSlagFlag.SourceCondition = "CODE_GROUP = \'TopSlagFlag\'";
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
            this.coldsTopSlagFlagL3DataTableCode_Des,
            this.coldsTopSlagFlagL3DataTableCode_Val_Long});
            this.schemadsTopSlagFlag.TableName = "L3DataTable";
            // 
            // coldsTopSlagFlagL3DataTableCode_Des
            // 
            this.coldsTopSlagFlagL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTopSlagFlagL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTopSlagFlagL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTopSlagFlagL3DataTableCode_Val_Long
            // 
            this.coldsTopSlagFlagL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTopSlagFlagL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTopSlagFlagL3DataTableCode_Val_Long.DataType = typeof(int);
            this.coldsTopSlagFlagL3DataTableCode_Val_Long.Namespace = "";
            // 
            // bsBOF
            // 
            this.bsBOF.DataMember = "L3DataTable";
            this.bsBOF.DataSource = this.dsBOF;
            // 
            // dsBOF
            // 
            this.dsBOF.AutoSubscribe = true;
            this.dsBOF.DataSetName = "L3DataSet";
            this.dsBOF.DeleteMethod = null;
            this.dsBOF.InsertMethod = null;
            this.dsBOF.L3DataAdapter = this.Adapter;
            this.dsBOF.LoadEvent = "Click";
            this.dsBOF.LoadTrigger = null;
            this.dsBOF.RefreshValve = 1000;
            this.dsBOF.SourceCommand = null;
            this.dsBOF.SourceCondition = "SubStr(Bulk_Area,4,1) in (\'A\',\'B\',\'C\',\'D\')  ";
            this.dsBOF.SourceMethod = "";
            this.dsBOF.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBOF.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Bulk_Relation";
            this.dsBOF.SubscribeTarget = null;
            this.dsBOF.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBOF});
            this.dsBOF.UpdateEvent = "Click";
            this.dsBOF.UpdateMethod = null;
            this.dsBOF.UpdateTrigger = null;
            // 
            // schemadsBOF
            // 
            this.schemadsBOF.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBOFL3DataTableBulk_Area,
            this.coldsBOFL3DataTableBulk_Code,
            this.coldsBOFL3DataTableTopSlagFlag});
            this.schemadsBOF.TableName = "L3DataTable";
            // 
            // coldsBOFL3DataTableBulk_Area
            // 
            this.coldsBOFL3DataTableBulk_Area.Caption = "Bulk_Area";
            this.coldsBOFL3DataTableBulk_Area.ColumnName = "Bulk_Area";
            this.coldsBOFL3DataTableBulk_Area.Namespace = "";
            // 
            // coldsBOFL3DataTableBulk_Code
            // 
            this.coldsBOFL3DataTableBulk_Code.Caption = "Bulk_Code";
            this.coldsBOFL3DataTableBulk_Code.ColumnName = "Bulk_Code";
            this.coldsBOFL3DataTableBulk_Code.Namespace = "";
            // 
            // coldsBOFL3DataTableTopSlagFlag
            // 
            this.coldsBOFL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsBOFL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsBOFL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsBOFL3DataTableTopSlagFlag.Namespace = "";
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
            this.toolStrip1.Size = new System.Drawing.Size(464, 43);
            this.toolStrip1.TabIndex = 64;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hmiRootPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 438);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "散状料料仓";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBOF);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(3, 17);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(458, 418);
            this.hmiRootPanel1.TabIndex = 0;
            // 
            // dvBOF
            // 
            this.dvBOF.AllowUserToAddRows = false;
            this.dvBOF.AutoGenerateColumns = false;
            this.dvBOF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvBOF.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBOF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBOF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BulkAreaDataGridViewTextBoxColumn1,
            this.BulkCodeDataGridViewTextBoxColumn1,
            this.TopSlagFlag});
            this.dvBOF.DataSource = this.bsBOF;
            this.dvBOF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBOF.Location = new System.Drawing.Point(0, 0);
            this.dvBOF.Name = "dvBOF";
            this.dvBOF.RowHeadersVisible = false;
            this.dvBOF.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBOF.RowTemplate.Height = 23;
            this.dvBOF.Size = new System.Drawing.Size(458, 418);
            this.dvBOF.TabIndex = 1;
            this.dvBOF.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBOF_DataError);
            // 
            // BulkAreaDataGridViewTextBoxColumn1
            // 
            this.BulkAreaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BulkAreaDataGridViewTextBoxColumn1.DataPropertyName = "Bulk_Area";
            this.BulkAreaDataGridViewTextBoxColumn1.DataSource = this.dsBulkArea;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.BulkAreaDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.BulkAreaDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.BulkAreaDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.BulkAreaDataGridViewTextBoxColumn1.HeaderText = "散状料料仓";
            this.BulkAreaDataGridViewTextBoxColumn1.Name = "BulkAreaDataGridViewTextBoxColumn1";
            this.BulkAreaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.BulkAreaDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BulkAreaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BulkAreaDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            // 
            // BulkCodeDataGridViewTextBoxColumn1
            // 
            this.BulkCodeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BulkCodeDataGridViewTextBoxColumn1.DataPropertyName = "Bulk_Code";
            this.BulkCodeDataGridViewTextBoxColumn1.DataSource = this.dsBulkCode;
            this.BulkCodeDataGridViewTextBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.BulkCodeDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.BulkCodeDataGridViewTextBoxColumn1.HeaderText = "散状料编码";
            this.BulkCodeDataGridViewTextBoxColumn1.Name = "BulkCodeDataGridViewTextBoxColumn1";
            this.BulkCodeDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BulkCodeDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BulkCodeDataGridViewTextBoxColumn1.ValueMember = "L3DataTable.Code";
            // 
            // TopSlagFlag
            // 
            this.TopSlagFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TopSlagFlag.DataPropertyName = "TopSlagFlag";
            this.TopSlagFlag.DataSource = this.dsTopSlagFlag;
            this.TopSlagFlag.DisplayMember = "L3DataTable.Code_Des";
            this.TopSlagFlag.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TopSlagFlag.HeaderText = "顶渣标志";
            this.TopSlagFlag.Name = "TopSlagFlag";
            this.TopSlagFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TopSlagFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TopSlagFlag.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // BulkAndAreaMapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BulkAndAreaMapFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "散状料维护";
            this.Text = "散状料维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkAndAreaMapFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBOF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBOF)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBOF)).EndInit();
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
        private AppSvrHMI.L3DataSet dsBOF;
        private System.Windows.Forms.BindingSource bsBOF;
        private System.Data.DataTable schemadsBOF;
        private System.Data.DataColumn coldsBOFL3DataTableBulk_Area;
        private System.Data.DataColumn coldsBOFL3DataTableBulk_Code;
        private AppSvrHMI.L3DataSet dsBulkArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBulkCode;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coldsBOFL3DataTableTopSlagFlag;
        private AppSvrHMI.L3DataSet dsTopSlagFlag;
        private System.Data.DataTable schemadsTopSlagFlag;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTableCode_Val_Long;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBOF;
        private System.Windows.Forms.DataGridViewComboBoxColumn BulkAreaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn BulkCodeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn TopSlagFlag;
    }
}