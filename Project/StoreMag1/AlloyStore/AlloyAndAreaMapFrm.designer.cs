namespace StoreMag.AlloyStore
{
    partial class AlloyAndAreaMapFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlloyAndAreaMapFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsFire = new System.Windows.Forms.BindingSource(this.components);
            this.dsFire = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsFire = new System.Data.DataTable();
            this.coldsFireL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsFireL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsFireL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.coldsFireL3DataTableAlloy_Vendor = new System.Data.DataColumn();
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
            this.dsTopSlagFlag = new AppSvrHMI.L3DataSet();
            this.schemadsTopSlagFlag = new System.Data.DataTable();
            this.coldsTopSlagFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTopSlagFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvWire = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsWire = new System.Windows.Forms.BindingSource(this.components);
            this.dsWire = new AppSvrHMI.L3DataSet();
            this.schemadsWire = new System.Data.DataTable();
            this.coldsWireL3DataTableGUID = new System.Data.DataColumn();
            this.coldsWireL3DataTableName = new System.Data.DataColumn();
            this.coldsWireL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsWireL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsWireL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.coldsWireL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dvGround = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGround = new System.Windows.Forms.BindingSource(this.components);
            this.dsGround = new AppSvrHMI.L3DataSet();
            this.schemadsGround = new System.Data.DataTable();
            this.coldsGroundL3DataTableGUID = new System.Data.DataColumn();
            this.coldsGroundL3DataTableName = new System.Data.DataColumn();
            this.coldsGroundL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsGroundL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsGroundL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.AcoldsGroundL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvFire = new System.Windows.Forms.DataGridView();
            this.alloyAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.alloyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Alloy_Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldsGroundL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.dsForStoreMagQuery = new AppSvrHMI.L3DataSet();
            this.schemadsForStoreMagQuery = new System.Data.DataTable();
            this.coldsForStoreMagQueryL3DataTableGUID = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableName = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableStoreID = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableBeforeMaterialID = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableBeforMaterialName = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableOperateMode = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableOperater = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableOperatorTime = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableAfterMaterialID = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableAfterMaterialName = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableBeforeWeight = new System.Data.DataColumn();
            this.coldsForStoreMagQueryL3DataTableAfterWeight = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForStoreMagQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsForStoreMagQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFire
            // 
            this.bsFire.DataMember = "L3DataTable";
            this.bsFire.DataSource = this.dsFire;
            // 
            // dsFire
            // 
            this.dsFire.AutoLoad = true;
            this.dsFire.AutoSubscribe = false;
            this.dsFire.DataSetName = "L3DataSet";
            this.dsFire.DeleteMethod = null;
            this.dsFire.InsertMethod = null;
            this.dsFire.L3DataAdapter = this.Adapter;
            this.dsFire.LoadEvent = "Click";
            this.dsFire.LoadTrigger = null;
            this.dsFire.RefreshValve = 1000;
            this.dsFire.SourceCommand = null;
            this.dsFire.SourceCondition = "name = \'5\'";
            this.dsFire.SourceMethod = "";
            this.dsFire.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsFire.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsFire.SubscribeTarget = null;
            this.dsFire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFire});
            this.dsFire.UpdateEvent = "Click";
            this.dsFire.UpdateMethod = null;
            this.dsFire.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsFire
            // 
            this.schemadsFire.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFireL3DataTableAlloy_Area,
            this.coldsFireL3DataTableAlloy_Code,
            this.coldsFireL3DataTableTopSlagFlag,
            this.coldsFireL3DataTableAlloy_Vendor});
            this.schemadsFire.TableName = "L3DataTable";
            // 
            // coldsFireL3DataTableAlloy_Area
            // 
            this.coldsFireL3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsFireL3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsFireL3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsFireL3DataTableAlloy_Code
            // 
            this.coldsFireL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsFireL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsFireL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsFireL3DataTableTopSlagFlag
            // 
            this.coldsFireL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsFireL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsFireL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsFireL3DataTableTopSlagFlag.Namespace = "";
            // 
            // coldsFireL3DataTableAlloy_Vendor
            // 
            this.coldsFireL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsFireL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsFireL3DataTableAlloy_Vendor.Namespace = "";
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
            this.dsAlloyArea.AutoLoad = true;
            this.dsAlloyArea.AutoSubscribe = true;
            this.dsAlloyArea.DataSetName = "L3DataSet";
            this.dsAlloyArea.DeleteMethod = null;
            this.dsAlloyArea.InsertMethod = null;
            this.dsAlloyArea.L3DataAdapter = this.Adapter;
            this.dsAlloyArea.LoadEvent = "Click";
            this.dsAlloyArea.LoadTrigger = null;
            this.dsAlloyArea.RefreshValve = 1000;
            this.dsAlloyArea.SourceCommand = null;
            this.dsAlloyArea.SourceCondition = "(CODE_GROUP = \'AlloyArea\' or CODE_GROUP = \'AlloyGround\' or code_group = \'AlloyWir" +
                "e\') and CODE is not null";
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
            this.dsAlloyCode.AutoLoad = true;
            this.dsAlloyCode.AutoSubscribe = true;
            this.dsAlloyCode.DataSetName = "L3DataSet";
            this.dsAlloyCode.DeleteMethod = null;
            this.dsAlloyCode.InsertMethod = null;
            this.dsAlloyCode.L3DataAdapter = this.Adapter;
            this.dsAlloyCode.LoadEvent = "Click";
            this.dsAlloyCode.LoadTrigger = null;
            this.dsAlloyCode.RefreshValve = 1000;
            this.dsAlloyCode.SourceCommand = null;
            this.dsAlloyCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\' order by code_des";
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
            // dsTopSlagFlag
            // 
            this.dsTopSlagFlag.AutoLoad = true;
            this.dsTopSlagFlag.AutoSubscribe = true;
            this.dsTopSlagFlag.DataSetName = "L3DataSet";
            this.dsTopSlagFlag.DeleteMethod = null;
            this.dsTopSlagFlag.InsertMethod = null;
            this.dsTopSlagFlag.L3DataAdapter = this.Adapter;
            this.dsTopSlagFlag.LoadEvent = "Click";
            this.dsTopSlagFlag.LoadTrigger = null;
            this.dsTopSlagFlag.RefreshValve = 1000;
            this.dsTopSlagFlag.SourceCommand = null;
            this.dsTopSlagFlag.SourceCondition = "CODE_GROUP = \'TopSlagFlag\' and code is not null";
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
            this.hmiRootPanel1.Controls.Add(this.groupBox1);
            this.hmiRootPanel1.Controls.Add(this.groupBox6);
            this.hmiRootPanel1.Controls.Add(this.groupBox2);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1002, 703);
            this.hmiRootPanel1.TabIndex = 64;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dvWire);
            this.groupBox1.Location = new System.Drawing.Point(0, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 367);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1#转炉炉后喂丝机";
            // 
            // dvWire
            // 
            this.dvWire.AllowUserToAddRows = false;
            this.dvWire.AutoGenerateColumns = false;
            this.dvWire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvWire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvWire.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvWire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvWire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn4,
            this.dataGridViewComboBoxColumn5,
            this.dataGridViewComboBoxColumn6,
            this.dataGridViewTextBoxColumn1});
            this.dvWire.DataSource = this.bsWire;
            this.dvWire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWire.Location = new System.Drawing.Point(3, 17);
            this.dvWire.Name = "dvWire";
            this.dvWire.RowHeadersVisible = false;
            this.dvWire.RowTemplate.Height = 23;
            this.dvWire.Size = new System.Drawing.Size(487, 347);
            this.dvWire.TabIndex = 1;
            this.dvWire.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn4.DataPropertyName = "Alloy_Area";
            this.dataGridViewComboBoxColumn4.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewComboBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComboBoxColumn4.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn4.HeaderText = "合金堆放处";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.ReadOnly = true;
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.ValueMember = "L3DataTable.Code";
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn5.DataPropertyName = "Alloy_Code";
            this.dataGridViewComboBoxColumn5.DataSource = this.dsAlloyCode;
            this.dataGridViewComboBoxColumn5.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn5.HeaderText = "合金编码";
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            this.dataGridViewComboBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn5.ValueMember = "L3DataTable.Code";
            // 
            // dataGridViewComboBoxColumn6
            // 
            this.dataGridViewComboBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn6.DataPropertyName = "TopSlagFlag";
            this.dataGridViewComboBoxColumn6.DataSource = this.dsTopSlagFlag;
            this.dataGridViewComboBoxColumn6.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn6.HeaderText = "顶渣标志";
            this.dataGridViewComboBoxColumn6.Name = "dataGridViewComboBoxColumn6";
            this.dataGridViewComboBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn6.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Alloy_Vendor";
            this.dataGridViewTextBoxColumn1.HeaderText = "厂家";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // bsWire
            // 
            this.bsWire.DataMember = "L3DataTable";
            this.bsWire.DataSource = this.dsWire;
            // 
            // dsWire
            // 
            this.dsWire.AutoLoad = true;
            this.dsWire.AutoSubscribe = false;
            this.dsWire.DataSetName = "L3DataSet";
            this.dsWire.DeleteMethod = "";
            this.dsWire.InsertMethod = "";
            this.dsWire.L3DataAdapter = this.Adapter;
            this.dsWire.LoadEvent = "";
            this.dsWire.LoadTrigger = null;
            this.dsWire.RefreshValve = 1000;
            this.dsWire.SourceCommand = null;
            this.dsWire.SourceCondition = "Alloy_Area in (\'S81W01\',\'S81W02\',\'S81W03\',\'S81W04\',\'S81W05\',\'S81W06\',\'S81W07\',\'S8" +
                "1W08\')";
            this.dsWire.SourceMethod = "";
            this.dsWire.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWire.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsWire.SubscribeTarget = null;
            this.dsWire.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWire});
            this.dsWire.UpdateEvent = "";
            this.dsWire.UpdateMethod = "";
            this.dsWire.UpdateTrigger = null;
            // 
            // schemadsWire
            // 
            this.schemadsWire.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireL3DataTableGUID,
            this.coldsWireL3DataTableName,
            this.coldsWireL3DataTableAlloy_Area,
            this.coldsWireL3DataTableAlloy_Code,
            this.coldsWireL3DataTableTopSlagFlag,
            this.coldsWireL3DataTableAlloy_Vendor});
            this.schemadsWire.TableName = "L3DataTable";
            // 
            // coldsWireL3DataTableGUID
            // 
            this.coldsWireL3DataTableGUID.Caption = "GUID";
            this.coldsWireL3DataTableGUID.ColumnName = "GUID";
            this.coldsWireL3DataTableGUID.Namespace = "";
            // 
            // coldsWireL3DataTableName
            // 
            this.coldsWireL3DataTableName.Caption = "Name";
            this.coldsWireL3DataTableName.ColumnName = "Name";
            this.coldsWireL3DataTableName.Namespace = "";
            // 
            // coldsWireL3DataTableAlloy_Area
            // 
            this.coldsWireL3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsWireL3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsWireL3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsWireL3DataTableAlloy_Code
            // 
            this.coldsWireL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsWireL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsWireL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsWireL3DataTableTopSlagFlag
            // 
            this.coldsWireL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsWireL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsWireL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsWireL3DataTableTopSlagFlag.Namespace = "";
            // 
            // coldsWireL3DataTableAlloy_Vendor
            // 
            this.coldsWireL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsWireL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsWireL3DataTableAlloy_Vendor.Namespace = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.dvGround);
            this.groupBox6.Location = new System.Drawing.Point(499, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(500, 703);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "转炉袋装合金";
            // 
            // dvGround
            // 
            this.dvGround.AllowUserToAddRows = false;
            this.dvGround.AutoGenerateColumns = false;
            this.dvGround.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvGround.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvGround.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvGround.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvGround.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dvGround.DataSource = this.bsGround;
            this.dvGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGround.Location = new System.Drawing.Point(3, 17);
            this.dvGround.Name = "dvGround";
            this.dvGround.RowHeadersVisible = false;
            this.dvGround.RowTemplate.Height = 23;
            this.dvGround.Size = new System.Drawing.Size(494, 683);
            this.dvGround.TabIndex = 1;
            this.dvGround.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Alloy_Area";
            this.dataGridViewComboBoxColumn1.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewComboBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComboBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "合金堆放处";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "L3DataTable.Code";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Alloy_Code";
            this.dataGridViewComboBoxColumn2.DataSource = this.dsAlloyCode;
            this.dataGridViewComboBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "合金编码";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "L3DataTable.Code";
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn3.DataPropertyName = "TopSlagFlag";
            this.dataGridViewComboBoxColumn3.DataSource = this.dsTopSlagFlag;
            this.dataGridViewComboBoxColumn3.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn3.HeaderText = "顶渣标志";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn3.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Alloy_Vendor";
            this.dataGridViewTextBoxColumn5.HeaderText = "厂家";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 54;
            // 
            // bsGround
            // 
            this.bsGround.DataMember = "L3DataTable";
            this.bsGround.DataSource = this.dsGround;
            // 
            // dsGround
            // 
            this.dsGround.AutoLoad = true;
            this.dsGround.AutoSubscribe = false;
            this.dsGround.DataSetName = "L3DataSet";
            this.dsGround.DeleteMethod = null;
            this.dsGround.InsertMethod = null;
            this.dsGround.L3DataAdapter = this.Adapter;
            this.dsGround.LoadEvent = "Click";
            this.dsGround.LoadTrigger = null;
            this.dsGround.RefreshValve = 1000;
            this.dsGround.SourceCommand = null;
            this.dsGround.SourceCondition = "name = \'1\' order by Alloy_Area";
            this.dsGround.SourceMethod = "";
            this.dsGround.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGround.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsGround.SubscribeTarget = null;
            this.dsGround.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGround});
            this.dsGround.UpdateEvent = "Click";
            this.dsGround.UpdateMethod = null;
            this.dsGround.UpdateTrigger = null;
            // 
            // schemadsGround
            // 
            this.schemadsGround.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGroundL3DataTableGUID,
            this.coldsGroundL3DataTableName,
            this.coldsGroundL3DataTableAlloy_Area,
            this.coldsGroundL3DataTableAlloy_Code,
            this.coldsGroundL3DataTableTopSlagFlag,
            this.AcoldsGroundL3DataTableAlloy_Vendor});
            this.schemadsGround.TableName = "L3DataTable";
            // 
            // coldsGroundL3DataTableGUID
            // 
            this.coldsGroundL3DataTableGUID.Caption = "GUID";
            this.coldsGroundL3DataTableGUID.ColumnName = "GUID";
            this.coldsGroundL3DataTableGUID.Namespace = "";
            // 
            // coldsGroundL3DataTableName
            // 
            this.coldsGroundL3DataTableName.Caption = "Name";
            this.coldsGroundL3DataTableName.ColumnName = "Name";
            this.coldsGroundL3DataTableName.Namespace = "";
            // 
            // coldsGroundL3DataTableAlloy_Area
            // 
            this.coldsGroundL3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsGroundL3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsGroundL3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsGroundL3DataTableAlloy_Code
            // 
            this.coldsGroundL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsGroundL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsGroundL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsGroundL3DataTableTopSlagFlag
            // 
            this.coldsGroundL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsGroundL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsGroundL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsGroundL3DataTableTopSlagFlag.Namespace = "";
            // 
            // AcoldsGroundL3DataTableAlloy_Vendor
            // 
            this.AcoldsGroundL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.AcoldsGroundL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.AcoldsGroundL3DataTableAlloy_Vendor.Namespace = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvFire);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 307);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "合金烘烤炉";
            // 
            // dvFire
            // 
            this.dvFire.AllowUserToAddRows = false;
            this.dvFire.AutoGenerateColumns = false;
            this.dvFire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvFire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvFire.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvFire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvFire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alloyAreaDataGridViewTextBoxColumn,
            this.alloyCodeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.Alloy_Vendor});
            this.dvFire.DataSource = this.bsFire;
            this.dvFire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFire.Location = new System.Drawing.Point(3, 17);
            this.dvFire.Name = "dvFire";
            this.dvFire.RowHeadersVisible = false;
            this.dvFire.RowTemplate.Height = 23;
            this.dvFire.Size = new System.Drawing.Size(487, 287);
            this.dvFire.TabIndex = 0;
            this.dvFire.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // alloyAreaDataGridViewTextBoxColumn
            // 
            this.alloyAreaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alloyAreaDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Area";
            this.alloyAreaDataGridViewTextBoxColumn.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.alloyAreaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.alloyAreaDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.alloyAreaDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.alloyAreaDataGridViewTextBoxColumn.HeaderText = "合金料仓编码";
            this.alloyAreaDataGridViewTextBoxColumn.Name = "alloyAreaDataGridViewTextBoxColumn";
            this.alloyAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.alloyAreaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alloyAreaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alloyAreaDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // alloyCodeDataGridViewTextBoxColumn
            // 
            this.alloyCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alloyCodeDataGridViewTextBoxColumn.DataPropertyName = "Alloy_Code";
            this.alloyCodeDataGridViewTextBoxColumn.DataSource = this.dsAlloyCode;
            this.alloyCodeDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.alloyCodeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.alloyCodeDataGridViewTextBoxColumn.HeaderText = "合金编码";
            this.alloyCodeDataGridViewTextBoxColumn.Name = "alloyCodeDataGridViewTextBoxColumn";
            this.alloyCodeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alloyCodeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alloyCodeDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TopSlagFlag";
            this.dataGridViewTextBoxColumn4.DataSource = this.dsTopSlagFlag;
            this.dataGridViewTextBoxColumn4.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "顶渣标志";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // Alloy_Vendor
            // 
            this.Alloy_Vendor.DataPropertyName = "Alloy_Vendor";
            this.Alloy_Vendor.HeaderText = "厂家";
            this.Alloy_Vendor.Name = "Alloy_Vendor";
            this.Alloy_Vendor.Width = 54;
            // 
            // coldsGroundL3DataTableAlloy_Vendor
            // 
            this.coldsGroundL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsGroundL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsGroundL3DataTableAlloy_Vendor.Namespace = "";
            // 
            // dsForStoreMagQuery
            // 
            this.dsForStoreMagQuery.AutoLoad = true;
            this.dsForStoreMagQuery.AutoSubscribe = true;
            this.dsForStoreMagQuery.DataSetName = "L3DataSet";
            this.dsForStoreMagQuery.DeleteMethod = null;
            this.dsForStoreMagQuery.InsertMethod = null;
            this.dsForStoreMagQuery.L3DataAdapter = this.Adapter;
            this.dsForStoreMagQuery.LoadEvent = "Click";
            this.dsForStoreMagQuery.LoadTrigger = null;
            this.dsForStoreMagQuery.RefreshValve = 1000;
            this.dsForStoreMagQuery.SourceCommand = null;
            this.dsForStoreMagQuery.SourceCondition = "";
            this.dsForStoreMagQuery.SourceMethod = "";
            this.dsForStoreMagQuery.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsForStoreMagQuery.SourceURI = "XGMESLogic\\AlloyStoreMag\\CStoreOperateLog";
            this.dsForStoreMagQuery.SubscribeTarget = null;
            this.dsForStoreMagQuery.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsForStoreMagQuery});
            this.dsForStoreMagQuery.UpdateEvent = "Click";
            this.dsForStoreMagQuery.UpdateMethod = null;
            this.dsForStoreMagQuery.UpdateTrigger = null;
            // 
            // schemadsForStoreMagQuery
            // 
            this.schemadsForStoreMagQuery.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsForStoreMagQueryL3DataTableGUID,
            this.coldsForStoreMagQueryL3DataTableName,
            this.coldsForStoreMagQueryL3DataTableStoreID,
            this.coldsForStoreMagQueryL3DataTableBeforeMaterialID,
            this.coldsForStoreMagQueryL3DataTableBeforMaterialName,
            this.coldsForStoreMagQueryL3DataTableOperateMode,
            this.coldsForStoreMagQueryL3DataTableOperater,
            this.coldsForStoreMagQueryL3DataTableOperatorTime,
            this.coldsForStoreMagQueryL3DataTableAfterMaterialID,
            this.coldsForStoreMagQueryL3DataTableAfterMaterialName,
            this.coldsForStoreMagQueryL3DataTableBeforeWeight,
            this.coldsForStoreMagQueryL3DataTableAfterWeight});
            this.schemadsForStoreMagQuery.TableName = "L3DataTable";
            // 
            // coldsForStoreMagQueryL3DataTableGUID
            // 
            this.coldsForStoreMagQueryL3DataTableGUID.Caption = "GUID";
            this.coldsForStoreMagQueryL3DataTableGUID.ColumnName = "GUID";
            this.coldsForStoreMagQueryL3DataTableGUID.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableName
            // 
            this.coldsForStoreMagQueryL3DataTableName.Caption = "Name";
            this.coldsForStoreMagQueryL3DataTableName.ColumnName = "Name";
            this.coldsForStoreMagQueryL3DataTableName.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableStoreID
            // 
            this.coldsForStoreMagQueryL3DataTableStoreID.Caption = "StoreID";
            this.coldsForStoreMagQueryL3DataTableStoreID.ColumnName = "StoreID";
            this.coldsForStoreMagQueryL3DataTableStoreID.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableBeforeMaterialID
            // 
            this.coldsForStoreMagQueryL3DataTableBeforeMaterialID.Caption = "BeforeMaterialID";
            this.coldsForStoreMagQueryL3DataTableBeforeMaterialID.ColumnName = "BeforeMaterialID";
            this.coldsForStoreMagQueryL3DataTableBeforeMaterialID.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableBeforMaterialName
            // 
            this.coldsForStoreMagQueryL3DataTableBeforMaterialName.Caption = "BeforMaterialName";
            this.coldsForStoreMagQueryL3DataTableBeforMaterialName.ColumnName = "BeforMaterialName";
            this.coldsForStoreMagQueryL3DataTableBeforMaterialName.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableOperateMode
            // 
            this.coldsForStoreMagQueryL3DataTableOperateMode.Caption = "OperateMode";
            this.coldsForStoreMagQueryL3DataTableOperateMode.ColumnName = "OperateMode";
            this.coldsForStoreMagQueryL3DataTableOperateMode.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableOperater
            // 
            this.coldsForStoreMagQueryL3DataTableOperater.Caption = "Operater";
            this.coldsForStoreMagQueryL3DataTableOperater.ColumnName = "Operater";
            this.coldsForStoreMagQueryL3DataTableOperater.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableOperatorTime
            // 
            this.coldsForStoreMagQueryL3DataTableOperatorTime.Caption = "OperatorTime";
            this.coldsForStoreMagQueryL3DataTableOperatorTime.ColumnName = "OperatorTime";
            this.coldsForStoreMagQueryL3DataTableOperatorTime.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableAfterMaterialID
            // 
            this.coldsForStoreMagQueryL3DataTableAfterMaterialID.Caption = "AfterMaterialID";
            this.coldsForStoreMagQueryL3DataTableAfterMaterialID.ColumnName = "AfterMaterialID";
            this.coldsForStoreMagQueryL3DataTableAfterMaterialID.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableAfterMaterialName
            // 
            this.coldsForStoreMagQueryL3DataTableAfterMaterialName.Caption = "AfterMaterialName";
            this.coldsForStoreMagQueryL3DataTableAfterMaterialName.ColumnName = "AfterMaterialName";
            this.coldsForStoreMagQueryL3DataTableAfterMaterialName.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableBeforeWeight
            // 
            this.coldsForStoreMagQueryL3DataTableBeforeWeight.Caption = "BeforeWeight";
            this.coldsForStoreMagQueryL3DataTableBeforeWeight.ColumnName = "BeforeWeight";
            this.coldsForStoreMagQueryL3DataTableBeforeWeight.Namespace = "";
            // 
            // coldsForStoreMagQueryL3DataTableAfterWeight
            // 
            this.coldsForStoreMagQueryL3DataTableAfterWeight.Caption = "AfterWeight";
            this.coldsForStoreMagQueryL3DataTableAfterWeight.ColumnName = "AfterWeight";
            this.coldsForStoreMagQueryL3DataTableAfterWeight.Namespace = "";
            // 
            // AlloyAndAreaMapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 746);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AlloyAndAreaMapFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "合金烘烤炉料仓料种维护";
            this.Text = "合金维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyAndAreaMapFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyAndAreaMapFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWire)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForStoreMagQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsForStoreMagQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFire;
        private AppSvrHMI.L3DataSet dsFire;
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
        private System.Data.DataTable schemadsFire;
        private System.Data.DataColumn coldsFireL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsFireL3DataTableAlloy_Code;
        private AppSvrHMI.L3DataSet dsAlloyArea;
        private System.Data.DataTable schemadsAlloyArea;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coldsFireL3DataTableTopSlagFlag;
        private AppSvrHMI.L3DataSet dsTopSlagFlag;
        private System.Data.DataTable schemadsTopSlagFlag;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTableCode_Val_Long;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvFire;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox6;
        private AppSvrHMI.L3DataSet dsGround;
        private System.Data.DataTable schemadsGround;
        private System.Data.DataColumn coldsGroundL3DataTableGUID;
        private System.Data.DataColumn coldsGroundL3DataTableName;
        private System.Data.DataColumn coldsGroundL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsGroundL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsGroundL3DataTableTopSlagFlag;
        private System.Windows.Forms.DataGridView dvGround;
        private System.Windows.Forms.BindingSource bsGround;
        private System.Data.DataColumn coldsFireL3DataTableAlloy_Vendor;
        private System.Data.DataColumn coldsGroundL3DataTableAlloy_Vendor;
        private System.Windows.Forms.DataGridViewComboBoxColumn alloyAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn alloyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alloy_Vendor;
        private System.Data.DataColumn AcoldsGroundL3DataTableAlloy_Vendor;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvWire;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private AppSvrHMI.L3DataSet dsWire;
        private System.Data.DataTable schemadsWire;
        private System.Data.DataColumn coldsWireL3DataTableGUID;
        private System.Data.DataColumn coldsWireL3DataTableName;
        private System.Data.DataColumn coldsWireL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsWireL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsWireL3DataTableTopSlagFlag;
        private System.Data.DataColumn coldsWireL3DataTableAlloy_Vendor;
        private System.Windows.Forms.BindingSource bsWire;
        private AppSvrHMI.L3DataSet dsForStoreMagQuery;
        private System.Data.DataTable schemadsForStoreMagQuery;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableGUID;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableName;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableStoreID;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableBeforeMaterialID;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableBeforMaterialName;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableOperateMode;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableOperater;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableOperatorTime;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableAfterMaterialID;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableAfterMaterialName;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableBeforeWeight;
        private System.Data.DataColumn coldsForStoreMagQueryL3DataTableAfterWeight;
    }
}