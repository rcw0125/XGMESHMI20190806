namespace StoreMag.AlloyStore
{
    partial class AlloyInStoreComfirmFrm
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
            this.bsAlloyInStoreComfirmFrm = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlloyInStoreConfirm = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyInStoreConfirm = new System.Data.DataTable();
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableIDX = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_C = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_SI = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_MN = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_P = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_S = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_CODE = new System.Data.DataColumn();
            this.coldsAlloyInStoreConfirmL3DataTableStoreAreaID = new System.Data.DataColumn();
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdAlloyInStoreConfirm = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3cmdp = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myLine1 = new buttonHide.MyLine();
            this.cmbArea = new PxDataValid.PxComboBox();
            this.dsPossition = new AppSvrHMI.L3DataSet();
            this.cmdPossition = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableALLOY_AREA = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCODE_DES = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rbtnGround = new System.Windows.Forms.RadioButton();
            this.rbtnAlloyArea = new System.Windows.Forms.RadioButton();
            this.txtOldAmount = new PxDataValid.PxTextBox();
            this.txtAmount = new PxDataValid.PxTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsGround = new AppSvrHMI.L3DataSet();
            this.schemadsGround = new System.Data.DataTable();
            this.coldsGroundL3DataTableCode = new System.Data.DataColumn();
            this.coldsGroundL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyInStoreComfirmFrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyInStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyInStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPossition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsAlloyInStoreComfirmFrm
            // 
            this.bsAlloyInStoreComfirmFrm.DataMember = "L3DataTable";
            this.bsAlloyInStoreComfirmFrm.DataSource = this.dsAlloyInStoreConfirm;
            // 
            // dsAlloyInStoreConfirm
            // 
            this.dsAlloyInStoreConfirm.AutoLoad = true;
            this.dsAlloyInStoreConfirm.AutoSubscribe = true;
            this.dsAlloyInStoreConfirm.DataSetName = "L3DataSet";
            this.dsAlloyInStoreConfirm.DeleteMethod = "";
            this.dsAlloyInStoreConfirm.InsertMethod = "";
            this.dsAlloyInStoreConfirm.L3DataAdapter = null;
            this.dsAlloyInStoreConfirm.LoadEvent = "Click";
            this.dsAlloyInStoreConfirm.LoadTrigger = null;
            this.dsAlloyInStoreConfirm.RefreshValve = 1000;
            this.dsAlloyInStoreConfirm.SourceCommand = null;
            this.dsAlloyInStoreConfirm.SourceCondition = "";
            this.dsAlloyInStoreConfirm.SourceMethod = "";
            this.dsAlloyInStoreConfirm.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsAlloyInStoreConfirm.SourceURI = "";
            this.dsAlloyInStoreConfirm.SubscribeTarget = null;
            this.dsAlloyInStoreConfirm.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyInStoreConfirm});
            this.dsAlloyInStoreConfirm.UpdateEvent = "Click";
            this.dsAlloyInStoreConfirm.UpdateMethod = "";
            this.dsAlloyInStoreConfirm.UpdateTrigger = null;
            // 
            // schemadsAlloyInStoreConfirm
            // 
            this.schemadsAlloyInStoreConfirm.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE,
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALID,
            this.coldsAlloyInStoreConfirmL3DataTablePOSITION,
            this.coldsAlloyInStoreConfirmL3DataTableAMOUNT,
            this.coldsAlloyInStoreConfirmL3DataTableIDX,
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_C,
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_SI,
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_MN,
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_P,
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_S,
            this.coldsAlloyInStoreConfirmL3DataTableBATCH_ID,
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_CODE,
            this.coldsAlloyInStoreConfirmL3DataTableStoreAreaID});
            this.schemadsAlloyInStoreConfirm.TableName = "L3DataTable";
            // 
            // coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE
            // 
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableMATERIALID
            // 
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALID.DefaultValue = "";
            this.coldsAlloyInStoreConfirmL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTablePOSITION
            // 
            this.coldsAlloyInStoreConfirmL3DataTablePOSITION.Caption = "POSITION";
            this.coldsAlloyInStoreConfirmL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsAlloyInStoreConfirmL3DataTablePOSITION.DefaultValue = "";
            this.coldsAlloyInStoreConfirmL3DataTablePOSITION.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableAMOUNT
            // 
            this.coldsAlloyInStoreConfirmL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsAlloyInStoreConfirmL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsAlloyInStoreConfirmL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsAlloyInStoreConfirmL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsAlloyInStoreConfirmL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableIDX
            // 
            this.coldsAlloyInStoreConfirmL3DataTableIDX.Caption = "IDX";
            this.coldsAlloyInStoreConfirmL3DataTableIDX.ColumnName = "IDX";
            this.coldsAlloyInStoreConfirmL3DataTableIDX.DataType = typeof(int);
            this.coldsAlloyInStoreConfirmL3DataTableIDX.DefaultValue = 0;
            this.coldsAlloyInStoreConfirmL3DataTableIDX.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableALLOY_C
            // 
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_C.Caption = "ALLOY_C";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_C.ColumnName = "ALLOY_C";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_C.DataType = typeof(double);
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_C.DefaultValue = 0;
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_C.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableALLOY_SI
            // 
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_SI.Caption = "ALLOY_SI";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_SI.ColumnName = "ALLOY_SI";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_SI.DataType = typeof(double);
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_SI.DefaultValue = 0;
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_SI.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableALLOY_MN
            // 
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_MN.Caption = "ALLOY_MN";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_MN.ColumnName = "ALLOY_MN";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_MN.DataType = typeof(double);
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_MN.DefaultValue = 0;
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_MN.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableALLOY_P
            // 
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_P.Caption = "ALLOY_P";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_P.ColumnName = "ALLOY_P";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_P.DataType = typeof(double);
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_P.DefaultValue = 0;
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_P.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableALLOY_S
            // 
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_S.Caption = "ALLOY_S";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_S.ColumnName = "ALLOY_S";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_S.DataType = typeof(double);
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_S.DefaultValue = 0;
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_S.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableBATCH_ID
            // 
            this.coldsAlloyInStoreConfirmL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsAlloyInStoreConfirmL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsAlloyInStoreConfirmL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsAlloyInStoreConfirmL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableALLOY_CODE
            // 
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_CODE.Caption = "ALLOY_CODE";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_CODE.ColumnName = "ALLOY_CODE";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_CODE.DefaultValue = "";
            this.coldsAlloyInStoreConfirmL3DataTableALLOY_CODE.Namespace = "";
            // 
            // coldsAlloyInStoreConfirmL3DataTableStoreAreaID
            // 
            this.coldsAlloyInStoreConfirmL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsAlloyInStoreConfirmL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsAlloyInStoreConfirmL3DataTableStoreAreaID.Namespace = "";
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
            this.dsAlloyArea.AutoSubscribe = false;
            this.dsAlloyArea.DataSetName = "L3DataSet";
            this.dsAlloyArea.DeleteMethod = null;
            this.dsAlloyArea.InsertMethod = null;
            this.dsAlloyArea.L3DataAdapter = this.Adapter;
            this.dsAlloyArea.LoadEvent = "Click";
            this.dsAlloyArea.LoadTrigger = null;
            this.dsAlloyArea.RefreshValve = 1000;
            this.dsAlloyArea.SourceCommand = null;
            this.dsAlloyArea.SourceCondition = "CODE_GROUP = \'AlloyArea\' or CODE_GROUP = \'\'";
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(219, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdAlloyInStoreConfirm
            // 
            this.cmdAlloyInStoreConfirm.Adapter = this.Adapter;
            this.cmdAlloyInStoreConfirm.MergeReturnTarget = false;
            this.cmdAlloyInStoreConfirm.Method = "AlloyInStore";
            this.cmdAlloyInStoreConfirm.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdAlloyInStoreConfirm.Parameters.Add(this.l3CommandParameter1);
            this.cmdAlloyInStoreConfirm.ReturnTarget = null;
            this.cmdAlloyInStoreConfirm.ReturnTargetProperty = null;
            this.cmdAlloyInStoreConfirm.Trigger = null;
            this.cmdAlloyInStoreConfirm.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsAlloyInStoreConfirm;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3cmdp
            // 
            this.l3cmdp.AcceptAfterExecuted = false;
            this.l3cmdp.ConstantValue = null;
            this.l3cmdp.MergeTarget = false;
            this.l3cmdp.SourceFilter = null;
            this.l3cmdp.SourceObject = null;
            this.l3cmdp.SourceProperty = null;
            this.l3cmdp.TargetObject = null;
            this.l3cmdp.TargetProperty = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 155);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 42);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 155);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.cmbArea);
            this.tabPage1.Controls.Add(this.rbtnGround);
            this.tabPage1.Controls.Add(this.rbtnAlloyArea);
            this.tabPage1.Controls.Add(this.txtOldAmount);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 130);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上料信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(29, 24);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(320, 2);
            this.myLine1.TabIndex = 7;
            // 
            // cmbArea
            // 
            this.cmbArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbArea.BackColor = System.Drawing.SystemColors.Window;
            this.cmbArea.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAlloyInStoreComfirmFrm, "StoreAreaID", true));
            this.cmbArea.DataSource = this.dsPossition;
            this.cmbArea.DisplayMember = "L3DataTable.CODE_DES";
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.EnableNull = true;
            this.cmbArea.ErropPr = this.errorProvider1;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(120, 31);
            this.cmbArea.Name = "cmbArea";
            //
            this.cmbArea.Size = new System.Drawing.Size(239, 20);
            this.cmbArea.TabIndex = 6;
            //
            this.cmbArea.ToolTipValid = this.toolTip1;
            this.cmbArea.ValidEable = true;
            this.cmbArea.ValueMember = "L3DataTable.ALLOY_AREA";
            // 
            // dsPossition
            // 
            this.dsPossition.AutoLoad = true;
            this.dsPossition.AutoSubscribe = false;
            this.dsPossition.DataSetName = "L3DataSet";
            this.dsPossition.DeleteMethod = "";
            this.dsPossition.InsertMethod = "";
            this.dsPossition.L3DataAdapter = null;
            this.dsPossition.LoadEvent = "Click";
            this.dsPossition.LoadTrigger = null;
            this.dsPossition.RefreshValve = 1000;
            this.dsPossition.SourceCommand = this.cmdPossition;
            this.dsPossition.SourceCondition = null;
            this.dsPossition.SourceMethod = "GetAlloyArea";
            this.dsPossition.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsPossition.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.dsPossition.SubscribeTarget = null;
            this.dsPossition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsPossition.UpdateEvent = "Click";
            this.dsPossition.UpdateMethod = "";
            this.dsPossition.UpdateTrigger = null;
            // 
            // cmdPossition
            // 
            this.cmdPossition.Adapter = null;
            this.cmdPossition.MergeReturnTarget = false;
            this.cmdPossition.Method = null;
            this.cmdPossition.Object = null;
            this.cmdPossition.Parameters.Add(this.l3CommandParameter2);
            this.cmdPossition.ReturnTarget = null;
            this.cmdPossition.ReturnTargetProperty = null;
            this.cmdPossition.Trigger = null;
            this.cmdPossition.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableALLOY_AREA,
            this.coll3DataSet1L3DataTableCODE_DES});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableALLOY_AREA
            // 
            this.coll3DataSet1L3DataTableALLOY_AREA.Caption = "ALLOY_AREA";
            this.coll3DataSet1L3DataTableALLOY_AREA.ColumnName = "ALLOY_AREA";
            this.coll3DataSet1L3DataTableALLOY_AREA.DefaultValue = "";
            this.coll3DataSet1L3DataTableALLOY_AREA.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCODE_DES
            // 
            this.coll3DataSet1L3DataTableCODE_DES.Caption = "CODE_DES";
            this.coll3DataSet1L3DataTableCODE_DES.ColumnName = "CODE_DES";
            this.coll3DataSet1L3DataTableCODE_DES.DefaultValue = "";
            this.coll3DataSet1L3DataTableCODE_DES.Namespace = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // rbtnGround
            // 
            this.rbtnGround.AutoSize = true;
            this.rbtnGround.Location = new System.Drawing.Point(232, 5);
            this.rbtnGround.Name = "rbtnGround";
            this.rbtnGround.Size = new System.Drawing.Size(71, 16);
            this.rbtnGround.TabIndex = 5;
            this.rbtnGround.Text = "袋装合金";
            this.rbtnGround.UseVisualStyleBackColor = true;
            this.rbtnGround.Visible = false;
            this.rbtnGround.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnAlloyArea
            // 
            this.rbtnAlloyArea.AutoSize = true;
            this.rbtnAlloyArea.Checked = true;
            this.rbtnAlloyArea.Location = new System.Drawing.Point(117, 5);
            this.rbtnAlloyArea.Name = "rbtnAlloyArea";
            this.rbtnAlloyArea.Size = new System.Drawing.Size(71, 16);
            this.rbtnAlloyArea.TabIndex = 4;
            this.rbtnAlloyArea.TabStop = true;
            this.rbtnAlloyArea.Text = "合金料仓";
            this.rbtnAlloyArea.UseVisualStyleBackColor = true;
            this.rbtnAlloyArea.Visible = false;
            this.rbtnAlloyArea.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // txtOldAmount
            // 
            //
            this.txtOldAmount.Enabled = false;
            this.txtOldAmount.EnableNull = false;
            this.txtOldAmount.ErropPr = null;
            //
            this.txtOldAmount.Length = 0;
            this.txtOldAmount.Location = new System.Drawing.Point(119, 61);
            this.txtOldAmount.Max = 0;
            ////
            //
            this.txtOldAmount.MaxStrLength = 0;
            this.txtOldAmount.Min = -0.99;
            //
            //
            this.txtOldAmount.MinStrLength = 0;
            this.txtOldAmount.Name = "txtOldAmount";
            this.txtOldAmount.Precision = 0;
            //
            this.txtOldAmount.Size = new System.Drawing.Size(239, 21);
            this.txtOldAmount.TabIndex = 1;
            this.txtOldAmount.ToolTipValid = null;
          //
            this.txtOldAmount.ValidEable = true;
            this.txtOldAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAlloyInStoreComfirmFrm, "AMOUNT", true));
            //
            this.txtAmount.EnableNull = false;
            this.txtAmount.ErropPr = this.errorProvider1;
            //
            this.txtAmount.Length = 0;
            this.txtAmount.Location = new System.Drawing.Point(119, 93);
            this.txtAmount.Max = 99999;
            //this.txtAmount.MaxNull = null;
            //
            this.txtAmount.MaxStrLength = 0;
            this.txtAmount.Min = 0;
            //this.txtAmount.MinNull = null;
            //
            this.txtAmount.MinStrLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Precision = 0;
            //
            this.txtAmount.Size = new System.Drawing.Size(239, 21);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.ToolTipValid = this.toolTip1;
          //
            this.txtAmount.ValidEable = true;
            this.txtAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "现有合金量[Kg]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "上料合金量[Kg]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "入库位置:";
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
            this.dsGround.SourceCondition = "CODE_GROUP =  \'AlloyGround\' ORDER BY CODE";
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
            this.dsError.AutoSubscribe = false;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'AlloyInStore\'";
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
            this.coldsErrorL3DataTableERROR_CODE,
            this.coldsErrorL3DataTableERROR_DES});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableERROR_CODE
            // 
            this.coldsErrorL3DataTableERROR_CODE.Caption = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.ColumnName = "ERROR_CODE";
            this.coldsErrorL3DataTableERROR_CODE.Namespace = "";
            // 
            // coldsErrorL3DataTableERROR_DES
            // 
            this.coldsErrorL3DataTableERROR_DES.Caption = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.ColumnName = "ERROR_DES";
            this.coldsErrorL3DataTableERROR_DES.Namespace = "";
            // 
            // AlloyInStoreComfirmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 197);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlloyInStoreComfirmFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "上料确认";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyInStoreComfirmFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyInStoreComfirmFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyInStoreComfirmFrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyInStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyInStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPossition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAlloyInStoreComfirmFrm;
        private AppSvrHMI.L3DataSet dsAlloyInStoreConfirm;
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
        private System.Data.DataTable schemadsAlloyInStoreConfirm;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableMATERIALID;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTablePOSITION;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableAMOUNT;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableIDX;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableALLOY_C;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableALLOY_SI;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableALLOY_MN;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableALLOY_P;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableALLOY_S;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableALLOY_CODE;
        private AppSvrHMI.L3DataSet dsAlloyArea;
        private System.Data.DataTable schemadsAlloyArea;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode_Des;
        private System.Data.DataColumn coldsAlloyInStoreConfirmL3DataTableStoreAreaID;
        private AppSvrHMI.L3Command cmdAlloyInStoreConfirm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3cmdp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbtnGround;
        private System.Windows.Forms.RadioButton rbtnAlloyArea;
        private PxDataValid.PxTextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataSet dsGround;
        private System.Data.DataTable schemadsGround;
        private System.Data.DataColumn coldsGroundL3DataTableCode;
        private System.Data.DataColumn coldsGroundL3DataTableCode_Des;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsPossition;
        private AppSvrHMI.L3Command cmdPossition;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableALLOY_AREA;
        private System.Data.DataColumn coll3DataSet1L3DataTableCODE_DES;
        private PxDataValid.PxComboBox cmbArea;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
        private buttonHide.MyLine myLine1;
        private PxDataValid.PxTextBox txtOldAmount;
        private System.Windows.Forms.Label label1;
    }
}