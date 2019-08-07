namespace StoreMag.AlloyStore
{
    partial class AlloyAndAreaRHMapFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlloyAndAreaRHMapFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.bsPublic = new System.Windows.Forms.BindingSource(this.components);
            this.dsPublic = new AppSvrHMI.L3DataSet();
            this.schemadsPublic = new System.Data.DataTable();
            this.coldsPublicL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsPublicL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsPublicL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.coldsPublicL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.dsTopSlagFlag = new AppSvrHMI.L3DataSet();
            this.schemadsTopSlagFlag = new System.Data.DataTable();
            this.coldsTopSlagFlagL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTopSlagFlagL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dvWireRH = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsWireRH = new System.Windows.Forms.BindingSource(this.components);
            this.dsWireRH = new AppSvrHMI.L3DataSet();
            this.schemadsWireRH = new System.Data.DataTable();
            this.coldsWireRHL3DataTableGUID = new System.Data.DataColumn();
            this.coldsWireRHL3DataTableName = new System.Data.DataColumn();
            this.coldsWireRHL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsWireRHL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsWireRHL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.coldsWireRHL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvWireLF3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsWireLF3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsWireLF3 = new AppSvrHMI.L3DataSet();
            this.schemadsWireLF3 = new System.Data.DataTable();
            this.coldsWireLF3L3DataTableGUID = new System.Data.DataColumn();
            this.coldsWireLF3L3DataTableName = new System.Data.DataColumn();
            this.coldsWireLF3L3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsWireLF3L3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsWireLF3L3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.coldsWireLF3L3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvGroundPublic = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGroundPublic = new System.Windows.Forms.BindingSource(this.components);
            this.dsGroundPublic = new AppSvrHMI.L3DataSet();
            this.schemadsGroundPublic = new System.Data.DataTable();
            this.coldsGroundPublicL3DataTableGUID = new System.Data.DataColumn();
            this.coldsGroundPublicL3DataTableName = new System.Data.DataColumn();
            this.coldsGroundPublicL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsGroundPublicL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsGroundPublicL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.coldsGroundPublicL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dvGroundLF3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGroundLF3 = new System.Windows.Forms.BindingSource(this.components);
            this.dsGroundLF3 = new AppSvrHMI.L3DataSet();
            this.schemadsGround = new System.Data.DataTable();
            this.coldsGroundL3DataTableGUID = new System.Data.DataColumn();
            this.coldsGroundL3DataTableName = new System.Data.DataColumn();
            this.coldsGroundL3DataTableAlloy_Area = new System.Data.DataColumn();
            this.coldsGroundL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsGroundL3DataTableTopSlagFlag = new System.Data.DataColumn();
            this.AcoldsGroundL3DataTableAlloy_Vendor = new System.Data.DataColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dvPublic = new System.Windows.Forms.DataGridView();
            this.alloyAreaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.alloyCodeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWireRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWireRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireRH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireRH)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvWireLF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWireLF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireLF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireLF3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGroundPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroundPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroundPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGroundPublic)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGroundLF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroundLF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroundLF3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForStoreMagQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsForStoreMagQuery)).BeginInit();
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
            // bsPublic
            // 
            this.bsPublic.DataMember = "L3DataTable";
            this.bsPublic.DataSource = this.dsPublic;
            // 
            // dsPublic
            // 
            this.dsPublic.AutoLoad = true;
            this.dsPublic.AutoSubscribe = true;
            this.dsPublic.DataSetName = "L3DataSet";
            this.dsPublic.DeleteMethod = null;
            this.dsPublic.InsertMethod = null;
            this.dsPublic.L3DataAdapter = this.Adapter;
            this.dsPublic.LoadEvent = "Click";
            this.dsPublic.LoadTrigger = null;
            this.dsPublic.RefreshValve = 1000;
            this.dsPublic.SourceCommand = null;
            this.dsPublic.SourceCondition = "name = \'8\'";
            this.dsPublic.SourceMethod = "";
            this.dsPublic.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPublic.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsPublic.SubscribeTarget = null;
            this.dsPublic.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPublic});
            this.dsPublic.UpdateEvent = "Click";
            this.dsPublic.UpdateMethod = null;
            this.dsPublic.UpdateTrigger = null;
            // 
            // schemadsPublic
            // 
            this.schemadsPublic.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPublicL3DataTableAlloy_Area,
            this.coldsPublicL3DataTableAlloy_Code,
            this.coldsPublicL3DataTableTopSlagFlag,
            this.coldsPublicL3DataTableAlloy_Vendor});
            this.schemadsPublic.TableName = "L3DataTable";
            // 
            // coldsPublicL3DataTableAlloy_Area
            // 
            this.coldsPublicL3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsPublicL3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsPublicL3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsPublicL3DataTableAlloy_Code
            // 
            this.coldsPublicL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsPublicL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsPublicL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsPublicL3DataTableTopSlagFlag
            // 
            this.coldsPublicL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsPublicL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsPublicL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsPublicL3DataTableTopSlagFlag.Namespace = "";
            // 
            // coldsPublicL3DataTableAlloy_Vendor
            // 
            this.coldsPublicL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsPublicL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsPublicL3DataTableAlloy_Vendor.Namespace = "";
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
            this.hmiRootPanel1.Controls.Add(this.groupBox3);
            this.hmiRootPanel1.Controls.Add(this.groupBox2);
            this.hmiRootPanel1.Controls.Add(this.groupBox1);
            this.hmiRootPanel1.Controls.Add(this.groupBox6);
            this.hmiRootPanel1.Controls.Add(this.groupBox5);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 43);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1002, 703);
            this.hmiRootPanel1.TabIndex = 64;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.dvWireRH);
            this.groupBox3.Location = new System.Drawing.Point(362, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 280);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RH喂丝机";
            // 
            // dvWireRH
            // 
            this.dvWireRH.AllowUserToAddRows = false;
            this.dvWireRH.AutoGenerateColumns = false;
            this.dvWireRH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvWireRH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvWireRH.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvWireRH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvWireRH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn10,
            this.dataGridViewComboBoxColumn11,
            this.dataGridViewComboBoxColumn12,
            this.dataGridViewTextBoxColumn4});
            this.dvWireRH.DataSource = this.bsWireRH;
            this.dvWireRH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWireRH.Location = new System.Drawing.Point(3, 17);
            this.dvWireRH.Name = "dvWireRH";
            this.dvWireRH.RowHeadersVisible = false;
            this.dvWireRH.RowTemplate.Height = 23;
            this.dvWireRH.Size = new System.Drawing.Size(315, 260);
            this.dvWireRH.TabIndex = 1;
            this.dvWireRH.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // dataGridViewComboBoxColumn10
            // 
            this.dataGridViewComboBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn10.DataPropertyName = "Alloy_Area";
            this.dataGridViewComboBoxColumn10.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewComboBoxColumn10.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComboBoxColumn10.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn10.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn10.HeaderText = "合金堆放处";
            this.dataGridViewComboBoxColumn10.Name = "dataGridViewComboBoxColumn10";
            this.dataGridViewComboBoxColumn10.ReadOnly = true;
            this.dataGridViewComboBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn10.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn10.Width = 90;
            // 
            // dataGridViewComboBoxColumn11
            // 
            this.dataGridViewComboBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn11.DataPropertyName = "Alloy_Code";
            this.dataGridViewComboBoxColumn11.DataSource = this.dsAlloyCode;
            this.dataGridViewComboBoxColumn11.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn11.HeaderText = "合金编码";
            this.dataGridViewComboBoxColumn11.Name = "dataGridViewComboBoxColumn11";
            this.dataGridViewComboBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn11.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn11.Width = 78;
            // 
            // dataGridViewComboBoxColumn12
            // 
            this.dataGridViewComboBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn12.DataPropertyName = "TopSlagFlag";
            this.dataGridViewComboBoxColumn12.DataSource = this.dsTopSlagFlag;
            this.dataGridViewComboBoxColumn12.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn12.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn12.HeaderText = "顶渣标志";
            this.dataGridViewComboBoxColumn12.Name = "dataGridViewComboBoxColumn12";
            this.dataGridViewComboBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn12.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Alloy_Vendor";
            this.dataGridViewTextBoxColumn4.HeaderText = "厂家";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // bsWireRH
            // 
            this.bsWireRH.DataMember = "L3DataTable";
            this.bsWireRH.DataSource = this.dsWireRH;
            // 
            // dsWireRH
            // 
            this.dsWireRH.AutoLoad = true;
            this.dsWireRH.AutoSubscribe = false;
            this.dsWireRH.DataSetName = "L3DataSet";
            this.dsWireRH.DeleteMethod = "";
            this.dsWireRH.InsertMethod = "";
            this.dsWireRH.L3DataAdapter = this.Adapter;
            this.dsWireRH.LoadEvent = "";
            this.dsWireRH.LoadTrigger = null;
            this.dsWireRH.RefreshValve = 1000;
            this.dsWireRH.SourceCommand = null;
            this.dsWireRH.SourceCondition = "Alloy_Area IN (\'S81W21\',\'S81W22\',\'S81W23\',\'S81W24\')";
            this.dsWireRH.SourceMethod = "";
            this.dsWireRH.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWireRH.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsWireRH.SubscribeTarget = null;
            this.dsWireRH.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWireRH});
            this.dsWireRH.UpdateEvent = "";
            this.dsWireRH.UpdateMethod = "";
            this.dsWireRH.UpdateTrigger = null;
            // 
            // schemadsWireRH
            // 
            this.schemadsWireRH.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireRHL3DataTableGUID,
            this.coldsWireRHL3DataTableName,
            this.coldsWireRHL3DataTableAlloy_Area,
            this.coldsWireRHL3DataTableAlloy_Code,
            this.coldsWireRHL3DataTableTopSlagFlag,
            this.coldsWireRHL3DataTableAlloy_Vendor});
            this.schemadsWireRH.TableName = "L3DataTable";
            // 
            // coldsWireRHL3DataTableGUID
            // 
            this.coldsWireRHL3DataTableGUID.Caption = "GUID";
            this.coldsWireRHL3DataTableGUID.ColumnName = "GUID";
            this.coldsWireRHL3DataTableGUID.Namespace = "";
            // 
            // coldsWireRHL3DataTableName
            // 
            this.coldsWireRHL3DataTableName.Caption = "Name";
            this.coldsWireRHL3DataTableName.ColumnName = "Name";
            this.coldsWireRHL3DataTableName.Namespace = "";
            // 
            // coldsWireRHL3DataTableAlloy_Area
            // 
            this.coldsWireRHL3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsWireRHL3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsWireRHL3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsWireRHL3DataTableAlloy_Code
            // 
            this.coldsWireRHL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsWireRHL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsWireRHL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsWireRHL3DataTableTopSlagFlag
            // 
            this.coldsWireRHL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsWireRHL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsWireRHL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsWireRHL3DataTableTopSlagFlag.Namespace = "";
            // 
            // coldsWireRHL3DataTableAlloy_Vendor
            // 
            this.coldsWireRHL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsWireRHL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsWireRHL3DataTableAlloy_Vendor.Namespace = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvWireLF3);
            this.groupBox2.Location = new System.Drawing.Point(362, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 180);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3#LF喂丝机";
            // 
            // dvWireLF3
            // 
            this.dvWireLF3.AllowUserToAddRows = false;
            this.dvWireLF3.AutoGenerateColumns = false;
            this.dvWireLF3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvWireLF3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvWireLF3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvWireLF3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvWireLF3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn7,
            this.dataGridViewComboBoxColumn8,
            this.dataGridViewComboBoxColumn9,
            this.dataGridViewTextBoxColumn3});
            this.dvWireLF3.DataSource = this.bsWireLF3;
            this.dvWireLF3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvWireLF3.Location = new System.Drawing.Point(3, 17);
            this.dvWireLF3.Name = "dvWireLF3";
            this.dvWireLF3.RowHeadersVisible = false;
            this.dvWireLF3.RowTemplate.Height = 23;
            this.dvWireLF3.Size = new System.Drawing.Size(315, 160);
            this.dvWireLF3.TabIndex = 1;
            this.dvWireLF3.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // dataGridViewComboBoxColumn7
            // 
            this.dataGridViewComboBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn7.DataPropertyName = "Alloy_Area";
            this.dataGridViewComboBoxColumn7.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewComboBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComboBoxColumn7.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn7.HeaderText = "合金堆放处";
            this.dataGridViewComboBoxColumn7.Name = "dataGridViewComboBoxColumn7";
            this.dataGridViewComboBoxColumn7.ReadOnly = true;
            this.dataGridViewComboBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn7.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn7.Width = 90;
            // 
            // dataGridViewComboBoxColumn8
            // 
            this.dataGridViewComboBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn8.DataPropertyName = "Alloy_Code";
            this.dataGridViewComboBoxColumn8.DataSource = this.dsAlloyCode;
            this.dataGridViewComboBoxColumn8.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn8.HeaderText = "合金编码";
            this.dataGridViewComboBoxColumn8.Name = "dataGridViewComboBoxColumn8";
            this.dataGridViewComboBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn8.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn8.Width = 78;
            // 
            // dataGridViewComboBoxColumn9
            // 
            this.dataGridViewComboBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn9.DataPropertyName = "TopSlagFlag";
            this.dataGridViewComboBoxColumn9.DataSource = this.dsTopSlagFlag;
            this.dataGridViewComboBoxColumn9.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn9.HeaderText = "顶渣标志";
            this.dataGridViewComboBoxColumn9.Name = "dataGridViewComboBoxColumn9";
            this.dataGridViewComboBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn9.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Alloy_Vendor";
            this.dataGridViewTextBoxColumn3.HeaderText = "厂家";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // bsWireLF3
            // 
            this.bsWireLF3.DataMember = "L3DataTable";
            this.bsWireLF3.DataSource = this.dsWireLF3;
            // 
            // dsWireLF3
            // 
            this.dsWireLF3.AutoLoad = true;
            this.dsWireLF3.AutoSubscribe = false;
            this.dsWireLF3.DataSetName = "L3DataSet";
            this.dsWireLF3.DeleteMethod = "";
            this.dsWireLF3.InsertMethod = "";
            this.dsWireLF3.L3DataAdapter = this.Adapter;
            this.dsWireLF3.LoadEvent = "";
            this.dsWireLF3.LoadTrigger = null;
            this.dsWireLF3.RefreshValve = 1000;
            this.dsWireLF3.SourceCommand = null;
            this.dsWireLF3.SourceCondition = "Alloy_Area IN (\'S81W17\',\'S81W18\',\'S81W19\',\'S81W20\')";
            this.dsWireLF3.SourceMethod = "";
            this.dsWireLF3.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWireLF3.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsWireLF3.SubscribeTarget = null;
            this.dsWireLF3.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWireLF3});
            this.dsWireLF3.UpdateEvent = "";
            this.dsWireLF3.UpdateMethod = "";
            this.dsWireLF3.UpdateTrigger = null;
            // 
            // schemadsWireLF3
            // 
            this.schemadsWireLF3.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWireLF3L3DataTableGUID,
            this.coldsWireLF3L3DataTableName,
            this.coldsWireLF3L3DataTableAlloy_Area,
            this.coldsWireLF3L3DataTableAlloy_Code,
            this.coldsWireLF3L3DataTableTopSlagFlag,
            this.coldsWireLF3L3DataTableAlloy_Vendor});
            this.schemadsWireLF3.TableName = "L3DataTable";
            // 
            // coldsWireLF3L3DataTableGUID
            // 
            this.coldsWireLF3L3DataTableGUID.Caption = "GUID";
            this.coldsWireLF3L3DataTableGUID.ColumnName = "GUID";
            this.coldsWireLF3L3DataTableGUID.Namespace = "";
            // 
            // coldsWireLF3L3DataTableName
            // 
            this.coldsWireLF3L3DataTableName.Caption = "Name";
            this.coldsWireLF3L3DataTableName.ColumnName = "Name";
            this.coldsWireLF3L3DataTableName.Namespace = "";
            // 
            // coldsWireLF3L3DataTableAlloy_Area
            // 
            this.coldsWireLF3L3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsWireLF3L3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsWireLF3L3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsWireLF3L3DataTableAlloy_Code
            // 
            this.coldsWireLF3L3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsWireLF3L3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsWireLF3L3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsWireLF3L3DataTableTopSlagFlag
            // 
            this.coldsWireLF3L3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsWireLF3L3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsWireLF3L3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsWireLF3L3DataTableTopSlagFlag.Namespace = "";
            // 
            // coldsWireLF3L3DataTableAlloy_Vendor
            // 
            this.coldsWireLF3L3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsWireLF3L3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsWireLF3L3DataTableAlloy_Vendor.Namespace = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dvGroundPublic);
            this.groupBox1.Location = new System.Drawing.Point(686, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 702);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3#LF/RH袋装合金";
            // 
            // dvGroundPublic
            // 
            this.dvGroundPublic.AllowUserToAddRows = false;
            this.dvGroundPublic.AutoGenerateColumns = false;
            this.dvGroundPublic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvGroundPublic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvGroundPublic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvGroundPublic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvGroundPublic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn4,
            this.dataGridViewComboBoxColumn5,
            this.dataGridViewComboBoxColumn6,
            this.dataGridViewTextBoxColumn1});
            this.dvGroundPublic.DataSource = this.bsGroundPublic;
            this.dvGroundPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGroundPublic.Location = new System.Drawing.Point(3, 17);
            this.dvGroundPublic.Name = "dvGroundPublic";
            this.dvGroundPublic.RowHeadersVisible = false;
            this.dvGroundPublic.RowTemplate.Height = 23;
            this.dvGroundPublic.Size = new System.Drawing.Size(306, 682);
            this.dvGroundPublic.TabIndex = 1;
            this.dvGroundPublic.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn4.DataPropertyName = "Alloy_Area";
            this.dataGridViewComboBoxColumn4.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewComboBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewComboBoxColumn4.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn4.HeaderText = "合金堆放处";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.ReadOnly = true;
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn4.Width = 90;
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn5.DataPropertyName = "Alloy_Code";
            this.dataGridViewComboBoxColumn5.DataSource = this.dsAlloyCode;
            this.dataGridViewComboBoxColumn5.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn5.HeaderText = "合金编码";
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            this.dataGridViewComboBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn5.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn5.Width = 78;
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
            // bsGroundPublic
            // 
            this.bsGroundPublic.DataMember = "L3DataTable";
            this.bsGroundPublic.DataSource = this.dsGroundPublic;
            // 
            // dsGroundPublic
            // 
            this.dsGroundPublic.AutoLoad = true;
            this.dsGroundPublic.AutoSubscribe = false;
            this.dsGroundPublic.DataSetName = "L3DataSet";
            this.dsGroundPublic.DeleteMethod = "";
            this.dsGroundPublic.InsertMethod = "";
            this.dsGroundPublic.L3DataAdapter = this.Adapter;
            this.dsGroundPublic.LoadEvent = "";
            this.dsGroundPublic.LoadTrigger = null;
            this.dsGroundPublic.RefreshValve = 1000;
            this.dsGroundPublic.SourceCommand = null;
            this.dsGroundPublic.SourceCondition = resources.GetString("dsGroundPublic.SourceCondition");
            this.dsGroundPublic.SourceMethod = "";
            this.dsGroundPublic.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGroundPublic.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsGroundPublic.SubscribeTarget = null;
            this.dsGroundPublic.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGroundPublic});
            this.dsGroundPublic.UpdateEvent = "";
            this.dsGroundPublic.UpdateMethod = "";
            this.dsGroundPublic.UpdateTrigger = null;
            // 
            // schemadsGroundPublic
            // 
            this.schemadsGroundPublic.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGroundPublicL3DataTableGUID,
            this.coldsGroundPublicL3DataTableName,
            this.coldsGroundPublicL3DataTableAlloy_Area,
            this.coldsGroundPublicL3DataTableAlloy_Code,
            this.coldsGroundPublicL3DataTableTopSlagFlag,
            this.coldsGroundPublicL3DataTableAlloy_Vendor});
            this.schemadsGroundPublic.TableName = "L3DataTable";
            // 
            // coldsGroundPublicL3DataTableGUID
            // 
            this.coldsGroundPublicL3DataTableGUID.Caption = "GUID";
            this.coldsGroundPublicL3DataTableGUID.ColumnName = "GUID";
            this.coldsGroundPublicL3DataTableGUID.Namespace = "";
            // 
            // coldsGroundPublicL3DataTableName
            // 
            this.coldsGroundPublicL3DataTableName.Caption = "Name";
            this.coldsGroundPublicL3DataTableName.ColumnName = "Name";
            this.coldsGroundPublicL3DataTableName.Namespace = "";
            // 
            // coldsGroundPublicL3DataTableAlloy_Area
            // 
            this.coldsGroundPublicL3DataTableAlloy_Area.Caption = "Alloy_Area";
            this.coldsGroundPublicL3DataTableAlloy_Area.ColumnName = "Alloy_Area";
            this.coldsGroundPublicL3DataTableAlloy_Area.Namespace = "";
            // 
            // coldsGroundPublicL3DataTableAlloy_Code
            // 
            this.coldsGroundPublicL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsGroundPublicL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsGroundPublicL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsGroundPublicL3DataTableTopSlagFlag
            // 
            this.coldsGroundPublicL3DataTableTopSlagFlag.Caption = "TopSlagFlag";
            this.coldsGroundPublicL3DataTableTopSlagFlag.ColumnName = "TopSlagFlag";
            this.coldsGroundPublicL3DataTableTopSlagFlag.DataType = typeof(int);
            this.coldsGroundPublicL3DataTableTopSlagFlag.Namespace = "";
            // 
            // coldsGroundPublicL3DataTableAlloy_Vendor
            // 
            this.coldsGroundPublicL3DataTableAlloy_Vendor.Caption = "Alloy_Vendor";
            this.coldsGroundPublicL3DataTableAlloy_Vendor.ColumnName = "Alloy_Vendor";
            this.coldsGroundPublicL3DataTableAlloy_Vendor.Namespace = "";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dvGroundLF3);
            this.groupBox6.Location = new System.Drawing.Point(362, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(321, 220);
            this.groupBox6.TabIndex = 43;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "3#LF平台电子秤料斗";
            // 
            // dvGroundLF3
            // 
            this.dvGroundLF3.AllowUserToAddRows = false;
            this.dvGroundLF3.AutoGenerateColumns = false;
            this.dvGroundLF3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvGroundLF3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvGroundLF3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvGroundLF3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvGroundLF3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewComboBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.dvGroundLF3.DataSource = this.bsGroundLF3;
            this.dvGroundLF3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvGroundLF3.Location = new System.Drawing.Point(3, 17);
            this.dvGroundLF3.Name = "dvGroundLF3";
            this.dvGroundLF3.RowHeadersVisible = false;
            this.dvGroundLF3.RowTemplate.Height = 23;
            this.dvGroundLF3.Size = new System.Drawing.Size(315, 200);
            this.dvGroundLF3.TabIndex = 1;
            this.dvGroundLF3.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Alloy_Area";
            this.dataGridViewComboBoxColumn1.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewComboBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewComboBoxColumn1.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "合金堆放处";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.ReadOnly = true;
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn1.Width = 90;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Alloy_Code";
            this.dataGridViewComboBoxColumn2.DataSource = this.dsAlloyCode;
            this.dataGridViewComboBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn2.HeaderText = "合金编码";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "L3DataTable.Code";
            this.dataGridViewComboBoxColumn2.Width = 78;
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
            // bsGroundLF3
            // 
            this.bsGroundLF3.DataMember = "L3DataTable";
            this.bsGroundLF3.DataSource = this.dsGroundLF3;
            // 
            // dsGroundLF3
            // 
            this.dsGroundLF3.AutoLoad = true;
            this.dsGroundLF3.AutoSubscribe = true;
            this.dsGroundLF3.DataSetName = "L3DataSet";
            this.dsGroundLF3.DeleteMethod = null;
            this.dsGroundLF3.InsertMethod = null;
            this.dsGroundLF3.L3DataAdapter = this.Adapter;
            this.dsGroundLF3.LoadEvent = "Click";
            this.dsGroundLF3.LoadTrigger = null;
            this.dsGroundLF3.RefreshValve = 1000;
            this.dsGroundLF3.SourceCommand = null;
            this.dsGroundLF3.SourceCondition = "Alloy_Area IN (\'S81Z13\',\'S81Z14\',\'S81Z15\',\'S81Z16\')";
            this.dsGroundLF3.SourceMethod = "";
            this.dsGroundLF3.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGroundLF3.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Bulk_Relation";
            this.dsGroundLF3.SubscribeTarget = null;
            this.dsGroundLF3.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGround});
            this.dsGroundLF3.UpdateEvent = "Click";
            this.dsGroundLF3.UpdateMethod = null;
            this.dsGroundLF3.UpdateTrigger = null;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dvPublic);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(358, 703);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "3#LF、1#RH合金公用仓";
            // 
            // dvPublic
            // 
            this.dvPublic.AllowUserToAddRows = false;
            this.dvPublic.AutoGenerateColumns = false;
            this.dvPublic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvPublic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvPublic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvPublic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvPublic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alloyAreaDataGridViewTextBoxColumn2,
            this.alloyCodeDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7});
            this.dvPublic.DataSource = this.bsPublic;
            this.dvPublic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvPublic.Location = new System.Drawing.Point(3, 17);
            this.dvPublic.Name = "dvPublic";
            this.dvPublic.RowHeadersVisible = false;
            this.dvPublic.RowTemplate.Height = 23;
            this.dvPublic.Size = new System.Drawing.Size(352, 683);
            this.dvPublic.TabIndex = 0;
            this.dvPublic.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFire_DataError);
            // 
            // alloyAreaDataGridViewTextBoxColumn2
            // 
            this.alloyAreaDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alloyAreaDataGridViewTextBoxColumn2.DataPropertyName = "Alloy_Area";
            this.alloyAreaDataGridViewTextBoxColumn2.DataSource = this.dsAlloyArea;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.alloyAreaDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.alloyAreaDataGridViewTextBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.alloyAreaDataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.alloyAreaDataGridViewTextBoxColumn2.HeaderText = "合金料仓编码";
            this.alloyAreaDataGridViewTextBoxColumn2.Name = "alloyAreaDataGridViewTextBoxColumn2";
            this.alloyAreaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.alloyAreaDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alloyAreaDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alloyAreaDataGridViewTextBoxColumn2.ValueMember = "L3DataTable.Code";
            this.alloyAreaDataGridViewTextBoxColumn2.Width = 102;
            // 
            // alloyCodeDataGridViewTextBoxColumn2
            // 
            this.alloyCodeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alloyCodeDataGridViewTextBoxColumn2.DataPropertyName = "Alloy_Code";
            this.alloyCodeDataGridViewTextBoxColumn2.DataSource = this.dsAlloyCode;
            this.alloyCodeDataGridViewTextBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.alloyCodeDataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.alloyCodeDataGridViewTextBoxColumn2.HeaderText = "合金编码";
            this.alloyCodeDataGridViewTextBoxColumn2.Name = "alloyCodeDataGridViewTextBoxColumn2";
            this.alloyCodeDataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alloyCodeDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.alloyCodeDataGridViewTextBoxColumn2.ValueMember = "L3DataTable.Code";
            this.alloyCodeDataGridViewTextBoxColumn2.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TopSlagFlag";
            this.dataGridViewTextBoxColumn2.DataSource = this.dsTopSlagFlag;
            this.dataGridViewTextBoxColumn2.DisplayMember = "L3DataTable.Code_Des";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "顶渣标志";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Alloy_Vendor";
            this.dataGridViewTextBoxColumn7.HeaderText = "厂家";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 54;
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
            // AlloyAndAreaRHMapFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 746);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AlloyAndAreaRHMapFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "3#LF、RH合金料仓料种维护";
            this.Text = "合金维护";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyAndAreaRHMapFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyAndAreaRHMapFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopSlagFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTopSlagFlag)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvWireRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWireRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireRH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireRH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvWireLF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWireLF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWireLF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWireLF3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGroundPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroundPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroundPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGroundPublic)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGroundLF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroundLF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroundLF3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForStoreMagQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsForStoreMagQuery)).EndInit();
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
        private AppSvrHMI.L3DataSet dsPublic;
        private System.Windows.Forms.BindingSource bsPublic;
        private System.Data.DataTable schemadsPublic;
        private System.Data.DataColumn coldsPublicL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsPublicL3DataTableAlloy_Code;
        private AppSvrHMI.L3DataSet dsAlloyArea;
        private System.Data.DataTable schemadsAlloyArea;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coldsPublicL3DataTableTopSlagFlag;
        private AppSvrHMI.L3DataSet dsTopSlagFlag;
        private System.Data.DataTable schemadsTopSlagFlag;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTableCode_Des;
        private System.Data.DataColumn coldsTopSlagFlagL3DataTableCode_Val_Long;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dvPublic;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox6;
        private AppSvrHMI.L3DataSet dsGroundLF3;
        private System.Data.DataTable schemadsGround;
        private System.Data.DataColumn coldsGroundL3DataTableGUID;
        private System.Data.DataColumn coldsGroundL3DataTableName;
        private System.Data.DataColumn coldsGroundL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsGroundL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsGroundL3DataTableTopSlagFlag;
        private System.Windows.Forms.DataGridView dvGroundLF3;
        private System.Windows.Forms.BindingSource bsGroundLF3;
        private System.Data.DataColumn coldsPublicL3DataTableAlloy_Vendor;
        private System.Data.DataColumn coldsGroundL3DataTableAlloy_Vendor;
        private System.Data.DataColumn AcoldsGroundL3DataTableAlloy_Vendor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvGroundPublic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dvWireRH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvWireLF3;
        private AppSvrHMI.L3DataSet dsGroundPublic;
        private AppSvrHMI.L3DataSet dsWireLF3;
        private AppSvrHMI.L3DataSet dsWireRH;
        private System.Windows.Forms.BindingSource bsWireRH;
        private System.Data.DataTable schemadsWireRH;
        private System.Data.DataColumn coldsWireRHL3DataTableGUID;
        private System.Data.DataColumn coldsWireRHL3DataTableName;
        private System.Data.DataColumn coldsWireRHL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsWireRHL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsWireRHL3DataTableTopSlagFlag;
        private System.Data.DataColumn coldsWireRHL3DataTableAlloy_Vendor;
        private System.Windows.Forms.BindingSource bsWireLF3;
        private System.Data.DataTable schemadsWireLF3;
        private System.Data.DataColumn coldsWireLF3L3DataTableGUID;
        private System.Data.DataColumn coldsWireLF3L3DataTableName;
        private System.Data.DataColumn coldsWireLF3L3DataTableAlloy_Area;
        private System.Data.DataColumn coldsWireLF3L3DataTableAlloy_Code;
        private System.Data.DataColumn coldsWireLF3L3DataTableTopSlagFlag;
        private System.Data.DataColumn coldsWireLF3L3DataTableAlloy_Vendor;
        private System.Windows.Forms.BindingSource bsGroundPublic;
        private System.Data.DataTable schemadsGroundPublic;
        private System.Data.DataColumn coldsGroundPublicL3DataTableGUID;
        private System.Data.DataColumn coldsGroundPublicL3DataTableName;
        private System.Data.DataColumn coldsGroundPublicL3DataTableAlloy_Area;
        private System.Data.DataColumn coldsGroundPublicL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsGroundPublicL3DataTableTopSlagFlag;
        private System.Data.DataColumn coldsGroundPublicL3DataTableAlloy_Vendor;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn alloyAreaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn alloyCodeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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