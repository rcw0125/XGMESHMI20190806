namespace StoreMag.BulkStore
{
    partial class BulkInStoreComfirmFrm
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
            this.bsBulkInStoreComfirmFrm = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulkInStoreConfirm = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBulkInStoreConfirm = new System.Data.DataTable();
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableIDX = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableBulk_CODE = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID = new System.Data.DataColumn();
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdBulkInStoreConfirm = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnGround = new System.Windows.Forms.RadioButton();
            this.rbtnAlloyArea = new System.Windows.Forms.RadioButton();
            this.cmbArea = new PxDataValid.PxComboBox();
            this.dsCodeArea = new AppSvrHMI.L3DataSet();
            this.cmdCodeArea = new AppSvrHMI.L3Command(this.components);
            this.l3cmdP = new AppSvrHMI.L3CommandParameter();
            this.schemadsCodeArea = new System.Data.DataTable();
            this.coldsCodeAreaL3DataTableBULK_AREA = new System.Data.DataColumn();
            this.coldsCodeAreaL3DataTableCODE_DES = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtAmount = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dsGround = new AppSvrHMI.L3DataSet();
            this.schemadsGround = new System.Data.DataTable();
            this.coldsGroundL3DataTableCode = new System.Data.DataColumn();
            this.coldsGroundL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkInStoreComfirmFrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCodeArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBulkInStoreComfirmFrm
            // 
            this.bsBulkInStoreComfirmFrm.DataMember = "L3DataTable";
            this.bsBulkInStoreComfirmFrm.DataSource = this.dsBulkInStoreConfirm;
            this.bsBulkInStoreComfirmFrm.CurrentChanged += new System.EventHandler(this.bsBulkInStoreComfirmFrm_CurrentChanged);
            // 
            // dsBulkInStoreConfirm
            // 
            this.dsBulkInStoreConfirm.AutoLoad = true;
            this.dsBulkInStoreConfirm.AutoSubscribe = true;
            this.dsBulkInStoreConfirm.DataSetName = "L3DataSet";
            this.dsBulkInStoreConfirm.DeleteMethod = "";
            this.dsBulkInStoreConfirm.InsertMethod = "";
            this.dsBulkInStoreConfirm.L3DataAdapter = this.Adapter;
            this.dsBulkInStoreConfirm.LoadEvent = "Click";
            this.dsBulkInStoreConfirm.LoadTrigger = null;
            this.dsBulkInStoreConfirm.RefreshValve = 1000;
            this.dsBulkInStoreConfirm.SourceCommand = null;
            this.dsBulkInStoreConfirm.SourceCondition = "";
            this.dsBulkInStoreConfirm.SourceMethod = "";
            this.dsBulkInStoreConfirm.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBulkInStoreConfirm.SourceURI = "";
            this.dsBulkInStoreConfirm.SubscribeTarget = "Version";
            this.dsBulkInStoreConfirm.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkInStoreConfirm});
            this.dsBulkInStoreConfirm.UpdateEvent = "Click";
            this.dsBulkInStoreConfirm.UpdateMethod = "";
            this.dsBulkInStoreConfirm.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBulkInStoreConfirm
            // 
            this.schemadsBulkInStoreConfirm.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE,
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID,
            this.coldsBulkInStoreConfirmL3DataTablePOSITION,
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT,
            this.coldsBulkInStoreConfirmL3DataTableIDX,
            this.coldsBulkInStoreConfirmL3DataTableBATCH_ID,
            this.coldsBulkInStoreConfirmL3DataTableBulk_CODE,
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID});
            this.schemadsBulkInStoreConfirm.TableName = "L3DataTable";
            // 
            // coldsBulkInStoreConfirmL3DataTableMATERIALTYPE
            // 
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableMATERIALID
            // 
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTablePOSITION
            // 
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.Caption = "POSITION";
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableAMOUNT
            // 
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableIDX
            // 
            this.coldsBulkInStoreConfirmL3DataTableIDX.Caption = "IDX";
            this.coldsBulkInStoreConfirmL3DataTableIDX.ColumnName = "IDX";
            this.coldsBulkInStoreConfirmL3DataTableIDX.DataType = typeof(int);
            this.coldsBulkInStoreConfirmL3DataTableIDX.DefaultValue = 0;
            this.coldsBulkInStoreConfirmL3DataTableIDX.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableBATCH_ID
            // 
            this.coldsBulkInStoreConfirmL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsBulkInStoreConfirmL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsBulkInStoreConfirmL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableBulk_CODE
            // 
            this.coldsBulkInStoreConfirmL3DataTableBulk_CODE.Caption = "BULK_CODE";
            this.coldsBulkInStoreConfirmL3DataTableBulk_CODE.ColumnName = "Bulk_CODE";
            this.coldsBulkInStoreConfirmL3DataTableBulk_CODE.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTableBulk_CODE.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableStoreAreaID
            // 
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID.Namespace = "";
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
            this.dsBulkArea.AutoLoad = true;
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(188, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdBulkInStoreConfirm
            // 
            this.cmdBulkInStoreConfirm.Adapter = this.Adapter;
            this.cmdBulkInStoreConfirm.MergeReturnTarget = false;
            this.cmdBulkInStoreConfirm.Method = "BulkInStore";
            this.cmdBulkInStoreConfirm.Object = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.cmdBulkInStoreConfirm.Parameters.Add(this.l3CommandParameter1);
            this.cmdBulkInStoreConfirm.ReturnTarget = null;
            this.cmdBulkInStoreConfirm.ReturnTargetProperty = null;
            this.cmdBulkInStoreConfirm.Trigger = null;
            this.cmdBulkInStoreConfirm.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsBulkInStoreConfirm;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(347, 48);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 154);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbtnGround);
            this.tabPage1.Controls.Add(this.rbtnAlloyArea);
            this.tabPage1.Controls.Add(this.cmbArea);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 129);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上料信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "入库位置:";
            // 
            // rbtnGround
            // 
            this.rbtnGround.AutoSize = true;
            this.rbtnGround.Location = new System.Drawing.Point(197, 15);
            this.rbtnGround.Name = "rbtnGround";
            this.rbtnGround.Size = new System.Drawing.Size(83, 16);
            this.rbtnGround.TabIndex = 7;
            this.rbtnGround.Text = "袋装散状料";
            this.rbtnGround.UseVisualStyleBackColor = true;
            this.rbtnGround.Visible = false;
            this.rbtnGround.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnAlloyArea
            // 
            this.rbtnAlloyArea.AutoSize = true;
            this.rbtnAlloyArea.Checked = true;
            this.rbtnAlloyArea.Location = new System.Drawing.Point(92, 15);
            this.rbtnAlloyArea.Name = "rbtnAlloyArea";
            this.rbtnAlloyArea.Size = new System.Drawing.Size(83, 16);
            this.rbtnAlloyArea.TabIndex = 6;
            this.rbtnAlloyArea.TabStop = true;
            this.rbtnAlloyArea.Text = "散状料料仓";
            this.rbtnAlloyArea.UseVisualStyleBackColor = true;
            this.rbtnAlloyArea.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // cmbArea
            // 
            this.cmbArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArea.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBulkInStoreComfirmFrm, "StoreAreaID", true));
            this.cmbArea.DataSource = this.dsCodeArea;
            this.cmbArea.DisplayMember = "L3DataTable.Code_Des";
            this.cmbArea.EnableNull = false;
            this.cmbArea.ErropPr = this.errorProvider1;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(98, 50);
            this.cmbArea.Name = "cmbArea";
            //
            this.cmbArea.Size = new System.Drawing.Size(215, 20);
            this.cmbArea.TabIndex = 3;
            //
            this.cmbArea.ToolTipValid = this.toolTip1;
            this.cmbArea.ValidEable = true;
            this.cmbArea.ValueMember = "L3DataTable.BULK_AREA";
            // 
            // dsCodeArea
            // 
            this.dsCodeArea.AutoLoad = true;
            this.dsCodeArea.AutoSubscribe = true;
            this.dsCodeArea.DataSetName = "L3DataSet";
            this.dsCodeArea.DeleteMethod = "";
            this.dsCodeArea.InsertMethod = "";
            this.dsCodeArea.L3DataAdapter = this.Adapter;
            this.dsCodeArea.LoadEvent = "Click";
            this.dsCodeArea.LoadTrigger = null;
            this.dsCodeArea.RefreshValve = 1000;
            this.dsCodeArea.SourceCommand = this.cmdCodeArea;
            this.dsCodeArea.SourceCondition = null;
            this.dsCodeArea.SourceMethod = "GetBulkArea";
            this.dsCodeArea.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsCodeArea.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.dsCodeArea.SubscribeTarget = null;
            this.dsCodeArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCodeArea});
            this.dsCodeArea.UpdateEvent = "Click";
            this.dsCodeArea.UpdateMethod = "";
            this.dsCodeArea.UpdateTrigger = null;
            // 
            // cmdCodeArea
            // 
            this.cmdCodeArea.Adapter = null;
            this.cmdCodeArea.MergeReturnTarget = false;
            this.cmdCodeArea.Method = null;
            this.cmdCodeArea.Object = null;
            this.cmdCodeArea.Parameters.Add(this.l3cmdP);
            this.cmdCodeArea.ReturnTarget = null;
            this.cmdCodeArea.ReturnTargetProperty = null;
            this.cmdCodeArea.Trigger = null;
            this.cmdCodeArea.TriggerEvent = "Click";
            // 
            // l3cmdP
            // 
            this.l3cmdP.AcceptAfterExecuted = false;
            this.l3cmdP.ConstantValue = null;
            this.l3cmdP.MergeTarget = false;
            this.l3cmdP.SourceFilter = null;
            this.l3cmdP.SourceObject = null;
            this.l3cmdP.SourceProperty = null;
            this.l3cmdP.TargetObject = null;
            this.l3cmdP.TargetProperty = null;
            // 
            // schemadsCodeArea
            // 
            this.schemadsCodeArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCodeAreaL3DataTableBULK_AREA,
            this.coldsCodeAreaL3DataTableCODE_DES});
            this.schemadsCodeArea.TableName = "L3DataTable";
            // 
            // coldsCodeAreaL3DataTableBULK_AREA
            // 
            this.coldsCodeAreaL3DataTableBULK_AREA.Caption = "BULK_AREA";
            this.coldsCodeAreaL3DataTableBULK_AREA.ColumnName = "BULK_AREA";
            this.coldsCodeAreaL3DataTableBULK_AREA.DefaultValue = "";
            this.coldsCodeAreaL3DataTableBULK_AREA.Namespace = "";
            // 
            // coldsCodeAreaL3DataTableCODE_DES
            // 
            this.coldsCodeAreaL3DataTableCODE_DES.Caption = "CODE_DES";
            this.coldsCodeAreaL3DataTableCODE_DES.ColumnName = "CODE_DES";
            this.coldsCodeAreaL3DataTableCODE_DES.DefaultValue = "";
            this.coldsCodeAreaL3DataTableCODE_DES.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBulkInStoreComfirmFrm, "AMOUNT", true));
            //
            this.txtAmount.EnableNull = false;
            this.txtAmount.ErropPr = this.errorProvider1;
            //
            this.txtAmount.Length = 0;
            this.txtAmount.Location = new System.Drawing.Point(98, 76);
            this.txtAmount.Max = 99999;
            ////
            //
            this.txtAmount.MaxStrLength = 0;
            this.txtAmount.Min = 0;
            ////
            //
            this.txtAmount.MinStrLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Precision = 0;
            //
            this.txtAmount.Size = new System.Drawing.Size(215, 21);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.ToolTipValid = this.toolTip1;
          //
            this.txtAmount.ValidEable = true;
            this.txtAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "散状料量:";
            // 
            // dsGround
            // 
            this.dsGround.AutoLoad = true;
            this.dsGround.AutoSubscribe = true;
            this.dsGround.DataSetName = "L3DataSet";
            this.dsGround.DeleteMethod = null;
            this.dsGround.InsertMethod = null;
            this.dsGround.L3DataAdapter = this.Adapter;
            this.dsGround.LoadEvent = "Click";
            this.dsGround.LoadTrigger = null;
            this.dsGround.RefreshValve = 1000;
            this.dsGround.SourceCommand = null;
            this.dsGround.SourceCondition = "CODE_GROUP =  \'BulkGround\' ORDER BY CODE";
            this.dsGround.SourceMethod = "";
            this.dsGround.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGround.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
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
            this.coldsGroundL3DataTableCode,
            this.coldsGroundL3DataTableCode_Des});
            this.schemadsGround.TableName = "L3DataTable";
            // 
            // coldsGroundL3DataTableCode
            // 
            this.coldsGroundL3DataTableCode.Caption = "Code";
            this.coldsGroundL3DataTableCode.ColumnName = "Code";
            this.coldsGroundL3DataTableCode.Namespace = "";
            // 
            // coldsGroundL3DataTableCode_Des
            // 
            this.coldsGroundL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsGroundL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsGroundL3DataTableCode_Des.Namespace = "";
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
            this.dsError.AutoSubscribe = true;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'BulkChangeStore\'";
            this.dsError.SourceMethod = "";
            this.dsError.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsError.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Error_Code";
            this.dsError.SubscribeTarget = null;
            this.dsError.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsError});
            this.dsError.UpdateEvent = "Click";
            this.dsError.UpdateMethod = null;
            this.dsError.UpdateTrigger = null;
            // 
            // schemadsError
            // 
            this.schemadsError.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // BulkInStoreComfirmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 202);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BulkInStoreComfirmFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "上料确认";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkInStoreComfirmFrm_FormClosing);
            this.Load += new System.EventHandler(this.BulkInStoreComfirmFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkInStoreComfirmFrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkInStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCodeArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBulkInStoreComfirmFrm;
        private AppSvrHMI.L3DataSet dsBulkInStoreConfirm;
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button3;
        private System.Data.DataTable schemadsBulkInStoreConfirm;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTablePOSITION;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableIDX;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableBulk_CODE;
        private AppSvrHMI.L3DataSet dsBulkArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdBulkInStoreConfirm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableStoreAreaID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbArea;
        private PxDataValid.PxTextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnGround;
        private System.Windows.Forms.RadioButton rbtnAlloyArea;
        private AppSvrHMI.L3DataSet dsCodeArea;
        private AppSvrHMI.L3Command cmdCodeArea;
        private System.Data.DataTable schemadsCodeArea;
        private System.Data.DataColumn coldsCodeAreaL3DataTableBULK_AREA;
        private System.Data.DataColumn coldsCodeAreaL3DataTableCODE_DES;
        private AppSvrHMI.L3CommandParameter l3cmdP;
        private AppSvrHMI.L3DataSet dsGround;
        private System.Data.DataTable schemadsGround;
        private System.Data.DataColumn coldsGroundL3DataTableCode;
        private System.Data.DataColumn coldsGroundL3DataTableCode_Des;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
    }
}