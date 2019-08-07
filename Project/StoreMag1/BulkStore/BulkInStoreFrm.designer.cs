namespace StoreMag.BulkStore
{
    partial class BulkInStoreFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkInStoreFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsBulkInStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulkInStore = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBulkInStore = new System.Data.DataTable();
            this.coldsBulkInStoreL3DataTableNAME = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTableIDX = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTableBulk_CODE = new System.Data.DataColumn();
            this.coldsBulkInStoreL3DataTableCheckFlag = new System.Data.DataColumn();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnInStore = new System.Windows.Forms.ToolStripButton();
            this.btnBulkToAlloy = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBulkInStore = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bulkCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBulkCode = new AppSvrHMI.L3DataSet();
            this.schemadsBulkCode = new System.Data.DataTable();
            this.coldsBulkCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.bATCHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATERIALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsBulkArea = new AppSvrHMI.L3DataSet();
            this.schemadsBulkArea = new System.Data.DataTable();
            this.coldsBulkAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.iDXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dsBulkInStoreSend = new AppSvrHMI.L3DataSet();
            this.schemadsBulkInStoreSend = new System.Data.DataTable();
            this.coldsBulkInStoreSendL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBulkInStoreSendL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBulkInStoreSendL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBulkInStoreSendL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBulkInStoreSendL3DataTableIDX = new System.Data.DataColumn();
            this.coldsBulkInStoreSendL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsBulkInStoreSendL3DataTableBulk_CODE = new System.Data.DataColumn();
            this.txtBulkInStore = new AppSvrHMI.L3DataBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkInStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInStoreSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStoreSend)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBulkInStore
            // 
            this.bsBulkInStore.DataMember = "L3DataTable";
            this.bsBulkInStore.DataSource = this.dsBulkInStore;
            // 
            // dsBulkInStore
            // 
            this.dsBulkInStore.AutoSubscribe = true;
            this.dsBulkInStore.DataSetName = "L3DataSet";
            this.dsBulkInStore.DeleteMethod = "";
            this.dsBulkInStore.InsertMethod = "";
            this.dsBulkInStore.L3DataAdapter = this.Adapter;
            this.dsBulkInStore.LoadEvent = "Click";
            this.dsBulkInStore.LoadTrigger = null;
            this.dsBulkInStore.RefreshValve = 1000;
            this.dsBulkInStore.SourceCommand = null;
            this.dsBulkInStore.SourceCondition = null;
            this.dsBulkInStore.SourceMethod = "GetMaterialOnInputCache";
            this.dsBulkInStore.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsBulkInStore.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.dsBulkInStore.SubscribeTarget = null;
            this.dsBulkInStore.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkInStore});
            this.dsBulkInStore.UpdateEvent = "Click";
            this.dsBulkInStore.UpdateMethod = "";
            this.dsBulkInStore.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBulkInStore
            // 
            this.schemadsBulkInStore.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkInStoreL3DataTableNAME,
            this.coldsBulkInStoreL3DataTableMATERIALTYPE,
            this.coldsBulkInStoreL3DataTableMATERIALID,
            this.coldsBulkInStoreL3DataTablePOSITION,
            this.coldsBulkInStoreL3DataTableAMOUNT,
            this.coldsBulkInStoreL3DataTableIDX,
            this.coldsBulkInStoreL3DataTableBATCH_ID,
            this.coldsBulkInStoreL3DataTableBulk_CODE,
            this.coldsBulkInStoreL3DataTableCheckFlag});
            this.schemadsBulkInStore.TableName = "L3DataTable";
            // 
            // coldsBulkInStoreL3DataTableNAME
            // 
            this.coldsBulkInStoreL3DataTableNAME.Caption = "NAME";
            this.coldsBulkInStoreL3DataTableNAME.ColumnName = "NAME";
            this.coldsBulkInStoreL3DataTableNAME.DefaultValue = "";
            this.coldsBulkInStoreL3DataTableNAME.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTableMATERIALTYPE
            // 
            this.coldsBulkInStoreL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBulkInStoreL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBulkInStoreL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBulkInStoreL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTableMATERIALID
            // 
            this.coldsBulkInStoreL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBulkInStoreL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBulkInStoreL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBulkInStoreL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTablePOSITION
            // 
            this.coldsBulkInStoreL3DataTablePOSITION.Caption = "POSITION";
            this.coldsBulkInStoreL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsBulkInStoreL3DataTablePOSITION.DefaultValue = "";
            this.coldsBulkInStoreL3DataTablePOSITION.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTableAMOUNT
            // 
            this.coldsBulkInStoreL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBulkInStoreL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBulkInStoreL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBulkInStoreL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBulkInStoreL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTableIDX
            // 
            this.coldsBulkInStoreL3DataTableIDX.Caption = "IDX";
            this.coldsBulkInStoreL3DataTableIDX.ColumnName = "IDX";
            this.coldsBulkInStoreL3DataTableIDX.DataType = typeof(int);
            this.coldsBulkInStoreL3DataTableIDX.DefaultValue = 0;
            this.coldsBulkInStoreL3DataTableIDX.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTableBATCH_ID
            // 
            this.coldsBulkInStoreL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsBulkInStoreL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsBulkInStoreL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsBulkInStoreL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTableBulk_CODE
            // 
            this.coldsBulkInStoreL3DataTableBulk_CODE.Caption = "BULK_CODE";
            this.coldsBulkInStoreL3DataTableBulk_CODE.ColumnName = "Bulk_CODE";
            this.coldsBulkInStoreL3DataTableBulk_CODE.DefaultValue = "";
            this.coldsBulkInStoreL3DataTableBulk_CODE.Namespace = "";
            // 
            // coldsBulkInStoreL3DataTableCheckFlag
            // 
            this.coldsBulkInStoreL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsBulkInStoreL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsBulkInStoreL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsBulkInStoreL3DataTableCheckFlag.Namespace = "";
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
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripSeparator5,
            this.btnInStore,
            this.btnBulkToAlloy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 43);
            this.toolStrip1.TabIndex = 62;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(65, 40);
            this.toolStripButton9.Text = "退出";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnInStore
            // 
            this.btnInStore.Image = ((System.Drawing.Image)(resources.GetObject("btnInStore.Image")));
            this.btnInStore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInStore.Name = "btnInStore";
            this.btnInStore.Size = new System.Drawing.Size(65, 40);
            this.btnInStore.Text = "上料";
            this.btnInStore.Click += new System.EventHandler(this.btnInStore_Click);
            // 
            // btnBulkToAlloy
            // 
            this.btnBulkToAlloy.Image = ((System.Drawing.Image)(resources.GetObject("btnBulkToAlloy.Image")));
            this.btnBulkToAlloy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBulkToAlloy.Name = "btnBulkToAlloy";
            this.btnBulkToAlloy.Size = new System.Drawing.Size(113, 40);
            this.btnBulkToAlloy.Text = "散状料转合金";
            this.btnBulkToAlloy.Click += new System.EventHandler(this.btnBulkToAlloy_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 351);
            this.tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hmiRootPanel1);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(704, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上料信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBulkInStore);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(704, 301);
            this.hmiRootPanel1.TabIndex = 18;
            // 
            // dvBulkInStore
            // 
            this.dvBulkInStore.AllowUserToAddRows = false;
            this.dvBulkInStore.AutoGenerateColumns = false;
            this.dvBulkInStore.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvBulkInStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvBulkInStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.bulkCODEDataGridViewTextBoxColumn,
            this.bATCHIDDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.mATERIALTYPEDataGridViewTextBoxColumn,
            this.mATERIALIDDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.iDXDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dvBulkInStore.DataSource = this.bsBulkInStore;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvBulkInStore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvBulkInStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBulkInStore.Location = new System.Drawing.Point(0, 0);
            this.dvBulkInStore.Margin = new System.Windows.Forms.Padding(0);
            this.dvBulkInStore.Name = "dvBulkInStore";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvBulkInStore.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvBulkInStore.RowHeadersVisible = false;
            this.dvBulkInStore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBulkInStore.RowTemplate.Height = 23;
            this.dvBulkInStore.Size = new System.Drawing.Size(704, 301);
            this.dvBulkInStore.TabIndex = 18;
            this.dvBulkInStore.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvBulkInStore_DataError);
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
            // bulkCODEDataGridViewTextBoxColumn
            // 
            this.bulkCODEDataGridViewTextBoxColumn.DataPropertyName = "Bulk_CODE";
            this.bulkCODEDataGridViewTextBoxColumn.DataSource = this.dsBulkCode;
            this.bulkCODEDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.bulkCODEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bulkCODEDataGridViewTextBoxColumn.HeaderText = "散状料编码";
            this.bulkCODEDataGridViewTextBoxColumn.Name = "bulkCODEDataGridViewTextBoxColumn";
            this.bulkCODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bulkCODEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bulkCODEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bulkCODEDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
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
            this.dsBulkCode.SourceCondition = "CODE_GROUP = \'BULK_CODE\'";
            this.dsBulkCode.SourceMethod = "";
            this.dsBulkCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkCode.SubscribeTarget = null;
            this.dsBulkCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkCode});
            this.dsBulkCode.UpdateEvent = "Click";
            this.dsBulkCode.UpdateMethod = null;
            this.dsBulkCode.UpdateTrigger = null;
            // 
            // schemadsBulkCode
            // 
            this.schemadsBulkCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkCodeL3DataTableCode,
            this.coldsBulkCodeL3DataTableCode_Des});
            this.schemadsBulkCode.TableName = "L3DataTable";
            // 
            // coldsBulkCodeL3DataTableCode
            // 
            this.coldsBulkCodeL3DataTableCode.Caption = "Code";
            this.coldsBulkCodeL3DataTableCode.ColumnName = "Code";
            this.coldsBulkCodeL3DataTableCode.Namespace = "";
            // 
            // coldsBulkCodeL3DataTableCode_Des
            // 
            this.coldsBulkCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.Namespace = "";
            // 
            // bATCHIDDataGridViewTextBoxColumn
            // 
            this.bATCHIDDataGridViewTextBoxColumn.DataPropertyName = "BATCH_ID";
            this.bATCHIDDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.bATCHIDDataGridViewTextBoxColumn.Name = "bATCHIDDataGridViewTextBoxColumn";
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "重量";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            // 
            // mATERIALTYPEDataGridViewTextBoxColumn
            // 
            this.mATERIALTYPEDataGridViewTextBoxColumn.DataPropertyName = "MATERIALTYPE";
            this.mATERIALTYPEDataGridViewTextBoxColumn.HeaderText = "入库的材料类型";
            this.mATERIALTYPEDataGridViewTextBoxColumn.Name = "mATERIALTYPEDataGridViewTextBoxColumn";
            this.mATERIALTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // mATERIALIDDataGridViewTextBoxColumn
            // 
            this.mATERIALIDDataGridViewTextBoxColumn.DataPropertyName = "MATERIALID";
            this.mATERIALIDDataGridViewTextBoxColumn.HeaderText = "入库的材料编码";
            this.mATERIALIDDataGridViewTextBoxColumn.Name = "mATERIALIDDataGridViewTextBoxColumn";
            this.mATERIALIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mATERIALIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.DataSource = this.dsBulkArea;
            this.pOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.pOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "入库位置";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pOSITIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.pOSITIONDataGridViewTextBoxColumn.Visible = false;
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
            this.dsBulkArea.SourceCondition = "CODE_GROUP = \'BulkArea\'";
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
            // iDXDataGridViewTextBoxColumn
            // 
            this.iDXDataGridViewTextBoxColumn.DataPropertyName = "IDX";
            this.iDXDataGridViewTextBoxColumn.HeaderText = "IDX";
            this.iDXDataGridViewTextBoxColumn.Name = "iDXDataGridViewTextBoxColumn";
            this.iDXDataGridViewTextBoxColumn.Visible = false;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsBulkInStore;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(704, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // dsBulkInStoreSend
            // 
            this.dsBulkInStoreSend.AutoSubscribe = true;
            this.dsBulkInStoreSend.DataSetName = "L3DataSet";
            this.dsBulkInStoreSend.DeleteMethod = "";
            this.dsBulkInStoreSend.InsertMethod = "";
            this.dsBulkInStoreSend.L3DataAdapter = this.Adapter;
            this.dsBulkInStoreSend.LoadEvent = "Click";
            this.dsBulkInStoreSend.LoadTrigger = null;
            this.dsBulkInStoreSend.RefreshValve = 1000;
            this.dsBulkInStoreSend.SourceCommand = null;
            this.dsBulkInStoreSend.SourceCondition = "";
            this.dsBulkInStoreSend.SourceMethod = "";
            this.dsBulkInStoreSend.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBulkInStoreSend.SourceURI = "";
            this.dsBulkInStoreSend.SubscribeTarget = "Version";
            this.dsBulkInStoreSend.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkInStoreSend});
            this.dsBulkInStoreSend.UpdateEvent = "Click";
            this.dsBulkInStoreSend.UpdateMethod = "";
            this.dsBulkInStoreSend.UpdateTrigger = null;
            // 
            // schemadsBulkInStoreSend
            // 
            this.schemadsBulkInStoreSend.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkInStoreSendL3DataTableMATERIALTYPE,
            this.coldsBulkInStoreSendL3DataTableMATERIALID,
            this.coldsBulkInStoreSendL3DataTablePOSITION,
            this.coldsBulkInStoreSendL3DataTableAMOUNT,
            this.coldsBulkInStoreSendL3DataTableIDX,
            this.coldsBulkInStoreSendL3DataTableBATCH_ID,
            this.coldsBulkInStoreSendL3DataTableBulk_CODE});
            this.schemadsBulkInStoreSend.TableName = "L3DataTable";
            // 
            // coldsBulkInStoreSendL3DataTableMATERIALTYPE
            // 
            this.coldsBulkInStoreSendL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBulkInStoreSendL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBulkInStoreSendL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBulkInStoreSendL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBulkInStoreSendL3DataTableMATERIALID
            // 
            this.coldsBulkInStoreSendL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBulkInStoreSendL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBulkInStoreSendL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBulkInStoreSendL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBulkInStoreSendL3DataTablePOSITION
            // 
            this.coldsBulkInStoreSendL3DataTablePOSITION.Caption = "POSITION";
            this.coldsBulkInStoreSendL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsBulkInStoreSendL3DataTablePOSITION.DefaultValue = "";
            this.coldsBulkInStoreSendL3DataTablePOSITION.Namespace = "";
            // 
            // coldsBulkInStoreSendL3DataTableAMOUNT
            // 
            this.coldsBulkInStoreSendL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBulkInStoreSendL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBulkInStoreSendL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBulkInStoreSendL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBulkInStoreSendL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBulkInStoreSendL3DataTableIDX
            // 
            this.coldsBulkInStoreSendL3DataTableIDX.Caption = "IDX";
            this.coldsBulkInStoreSendL3DataTableIDX.ColumnName = "IDX";
            this.coldsBulkInStoreSendL3DataTableIDX.DataType = typeof(int);
            this.coldsBulkInStoreSendL3DataTableIDX.DefaultValue = 0;
            this.coldsBulkInStoreSendL3DataTableIDX.Namespace = "";
            // 
            // coldsBulkInStoreSendL3DataTableBATCH_ID
            // 
            this.coldsBulkInStoreSendL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsBulkInStoreSendL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsBulkInStoreSendL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsBulkInStoreSendL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsBulkInStoreSendL3DataTableBulk_CODE
            // 
            this.coldsBulkInStoreSendL3DataTableBulk_CODE.Caption = "Bulk_CODE";
            this.coldsBulkInStoreSendL3DataTableBulk_CODE.ColumnName = "Bulk_CODE";
            this.coldsBulkInStoreSendL3DataTableBulk_CODE.DefaultValue = "";
            this.coldsBulkInStoreSendL3DataTableBulk_CODE.Namespace = "";
            // 
            // txtBulkInStore
            // 
            this.txtBulkInStore.DataFormat = null;
            this.txtBulkInStore.DataObject = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.txtBulkInStore.DataProperty = "Bulk_Add_Material";
            this.txtBulkInStore.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.txtBulkInStore.L3DataAdapter = this.Adapter;
            this.txtBulkInStore.Location = new System.Drawing.Point(229, 12);
            this.txtBulkInStore.Name = "txtBulkInStore";
            this.txtBulkInStore.Size = new System.Drawing.Size(100, 21);
            this.txtBulkInStore.TabIndex = 64;
            this.txtBulkInStore.Value = null;
            this.txtBulkInStore.Visible = false;
            this.txtBulkInStore.TextChanged += new System.EventHandler(this.txtBulkInStore_TextChanged);
            // 
            // BulkInStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 394);
            this.Controls.Add(this.txtBulkInStore);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BulkInStoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "散状原料上料";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkInStoreFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkInStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInStoreSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStoreSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBulkInStore;
        private AppSvrHMI.L3DataSet dsBulkInStore;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnInStore;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBulkInStore;
        private System.Data.DataTable schemadsBulkInStore;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableNAME;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBulkInStoreL3DataTablePOSITION;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableIDX;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableBulk_CODE;
        private AppSvrHMI.L3DataSet dsBulkInStoreSend;
        private System.Data.DataTable schemadsBulkInStoreSend;
        private System.Data.DataColumn coldsBulkInStoreSendL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBulkInStoreSendL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBulkInStoreSendL3DataTablePOSITION;
        private System.Data.DataColumn coldsBulkInStoreSendL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBulkInStoreSendL3DataTableIDX;
        private System.Data.DataColumn coldsBulkInStoreSendL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsBulkInStoreSendL3DataTableBulk_CODE;
        private System.Data.DataColumn coldsBulkInStoreL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsBulkCode;
        private System.Data.DataTable schemadsBulkCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBulkArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bulkCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bATCHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATERIALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnBulkToAlloy;
        private AppSvrHMI.L3DataBox txtBulkInStore;
    }
}