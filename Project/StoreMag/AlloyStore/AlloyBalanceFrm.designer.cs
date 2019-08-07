namespace StoreMag.AlloyStore
{
    partial class AlloyBalanceFrm
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
            this.bsBalance = new System.Windows.Forms.BindingSource(this.components);
            this.dsBalance = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBalance = new System.Data.DataTable();
            this.coldsBalanceL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePOSDIFF = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_C = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_SI = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_MN = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_P = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_S = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_CODE = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableOldAmount = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableBalanceFlag = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableStoreAreaID = new System.Data.DataColumn();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtWeight = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlloyCode = new PxDataValid.PxComboBox();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbStore = new PxDataValid.PxComboBox();
            this.dsPosition = new AppSvrHMI.L3DataSet();
            this.schemadsPosition = new System.Data.DataTable();
            this.coldsPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtCurAmount = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.cmdBalance = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBalance
            // 
            this.bsBalance.DataMember = "L3DataTable";
            this.bsBalance.DataSource = this.dsBalance;
            // 
            // dsBalance
            // 
            this.dsBalance.AutoLoad = true;
            this.dsBalance.AutoSubscribe = true;
            this.dsBalance.DataSetName = "L3DataSet";
            this.dsBalance.DeleteMethod = "";
            this.dsBalance.InsertMethod = "";
            this.dsBalance.L3DataAdapter = this.Adapter;
            this.dsBalance.LoadEvent = "Click";
            this.dsBalance.LoadTrigger = null;
            this.dsBalance.RefreshValve = 1000;
            this.dsBalance.SourceCommand = null;
            this.dsBalance.SourceCondition = null;
            this.dsBalance.SourceMethod = "GetAllMaterialOnStore";
            this.dsBalance.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsBalance.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.dsBalance.SubscribeTarget = null;
            this.dsBalance.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBalance});
            this.dsBalance.UpdateEvent = "Click";
            this.dsBalance.UpdateMethod = "";
            this.dsBalance.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBalance
            // 
            this.schemadsBalance.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBalanceL3DataTableMATERIALID,
            this.coldsBalanceL3DataTableMATERIALTYPE,
            this.coldsBalanceL3DataTablePOSITION,
            this.coldsBalanceL3DataTablePOSDIFF,
            this.coldsBalanceL3DataTableAMOUNT,
            this.coldsBalanceL3DataTableALLOY_C,
            this.coldsBalanceL3DataTableALLOY_SI,
            this.coldsBalanceL3DataTableALLOY_MN,
            this.coldsBalanceL3DataTableALLOY_P,
            this.coldsBalanceL3DataTableALLOY_S,
            this.coldsBalanceL3DataTableBATCH_ID,
            this.coldsBalanceL3DataTableALLOY_CODE,
            this.coldsBalanceL3DataTableOldAmount,
            this.coldsBalanceL3DataTableBalanceFlag,
            this.coldsBalanceL3DataTableStoreAreaID});
            this.schemadsBalance.TableName = "L3DataTable";
            // 
            // coldsBalanceL3DataTableMATERIALID
            // 
            this.coldsBalanceL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBalanceL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBalanceL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBalanceL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBalanceL3DataTableMATERIALTYPE
            // 
            this.coldsBalanceL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBalanceL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBalanceL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBalanceL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBalanceL3DataTablePOSITION
            // 
            this.coldsBalanceL3DataTablePOSITION.Caption = "POSITION";
            this.coldsBalanceL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsBalanceL3DataTablePOSITION.DefaultValue = "";
            this.coldsBalanceL3DataTablePOSITION.Namespace = "";
            // 
            // coldsBalanceL3DataTablePOSDIFF
            // 
            this.coldsBalanceL3DataTablePOSDIFF.Caption = "POSDIFF";
            this.coldsBalanceL3DataTablePOSDIFF.ColumnName = "POSDIFF";
            this.coldsBalanceL3DataTablePOSDIFF.DefaultValue = "";
            this.coldsBalanceL3DataTablePOSDIFF.Namespace = "";
            // 
            // coldsBalanceL3DataTableAMOUNT
            // 
            this.coldsBalanceL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBalanceL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBalanceL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBalanceL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBalanceL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBalanceL3DataTableALLOY_C
            // 
            this.coldsBalanceL3DataTableALLOY_C.Caption = "C";
            this.coldsBalanceL3DataTableALLOY_C.ColumnName = "C";
            this.coldsBalanceL3DataTableALLOY_C.DataType = typeof(double);
            this.coldsBalanceL3DataTableALLOY_C.DefaultValue = 0;
            this.coldsBalanceL3DataTableALLOY_C.Namespace = "";
            // 
            // coldsBalanceL3DataTableALLOY_SI
            // 
            this.coldsBalanceL3DataTableALLOY_SI.Caption = "SI";
            this.coldsBalanceL3DataTableALLOY_SI.ColumnName = "SI";
            this.coldsBalanceL3DataTableALLOY_SI.DataType = typeof(double);
            this.coldsBalanceL3DataTableALLOY_SI.DefaultValue = 0;
            this.coldsBalanceL3DataTableALLOY_SI.Namespace = "";
            // 
            // coldsBalanceL3DataTableALLOY_MN
            // 
            this.coldsBalanceL3DataTableALLOY_MN.Caption = "MN";
            this.coldsBalanceL3DataTableALLOY_MN.ColumnName = "MN";
            this.coldsBalanceL3DataTableALLOY_MN.DataType = typeof(double);
            this.coldsBalanceL3DataTableALLOY_MN.DefaultValue = 0;
            this.coldsBalanceL3DataTableALLOY_MN.Namespace = "";
            // 
            // coldsBalanceL3DataTableALLOY_P
            // 
            this.coldsBalanceL3DataTableALLOY_P.Caption = "P";
            this.coldsBalanceL3DataTableALLOY_P.ColumnName = "P";
            this.coldsBalanceL3DataTableALLOY_P.DataType = typeof(double);
            this.coldsBalanceL3DataTableALLOY_P.DefaultValue = 0;
            this.coldsBalanceL3DataTableALLOY_P.Namespace = "";
            // 
            // coldsBalanceL3DataTableALLOY_S
            // 
            this.coldsBalanceL3DataTableALLOY_S.Caption = "S";
            this.coldsBalanceL3DataTableALLOY_S.ColumnName = "S";
            this.coldsBalanceL3DataTableALLOY_S.DataType = typeof(double);
            this.coldsBalanceL3DataTableALLOY_S.DefaultValue = 0;
            this.coldsBalanceL3DataTableALLOY_S.Namespace = "";
            // 
            // coldsBalanceL3DataTableBATCH_ID
            // 
            this.coldsBalanceL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsBalanceL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsBalanceL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsBalanceL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsBalanceL3DataTableALLOY_CODE
            // 
            this.coldsBalanceL3DataTableALLOY_CODE.Caption = "ALLOY_CODE";
            this.coldsBalanceL3DataTableALLOY_CODE.ColumnName = "ALLOY_CODE";
            this.coldsBalanceL3DataTableALLOY_CODE.DefaultValue = "";
            this.coldsBalanceL3DataTableALLOY_CODE.Namespace = "";
            // 
            // coldsBalanceL3DataTableOldAmount
            // 
            this.coldsBalanceL3DataTableOldAmount.Caption = "OldAmount";
            this.coldsBalanceL3DataTableOldAmount.ColumnName = "OldAmount";
            this.coldsBalanceL3DataTableOldAmount.DataType = typeof(double);
            this.coldsBalanceL3DataTableOldAmount.Namespace = "";
            // 
            // coldsBalanceL3DataTableBalanceFlag
            // 
            this.coldsBalanceL3DataTableBalanceFlag.Caption = "BalanceFlag";
            this.coldsBalanceL3DataTableBalanceFlag.ColumnName = "BalanceFlag";
            this.coldsBalanceL3DataTableBalanceFlag.DataType = typeof(short);
            this.coldsBalanceL3DataTableBalanceFlag.Namespace = "";
            // 
            // coldsBalanceL3DataTableStoreAreaID
            // 
            this.coldsBalanceL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsBalanceL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsBalanceL3DataTableStoreAreaID.Namespace = "";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(368, 166);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtWeight);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbAlloyCode);
            this.tabPage1.Controls.Add(this.cmbStore);
            this.tabPage1.Controls.Add(this.txtCurAmount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "盘库信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBalance, "AMOUNT", true));
            //
            this.txtWeight.EnableNull = false;
            this.txtWeight.ErropPr = this.errorProvider1;
            //
            this.txtWeight.Length = 0;
            this.txtWeight.Location = new System.Drawing.Point(151, 98);
            this.txtWeight.Max = 99999;
            ////
            //
            this.txtWeight.MaxStrLength = 0;
            this.txtWeight.Min = 0;
            ////
            //
            this.txtWeight.MinStrLength = 0;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Precision = 0;
            //
            this.txtWeight.Size = new System.Drawing.Size(158, 21);
            this.txtWeight.TabIndex = 5;
            this.txtWeight.ToolTipValid = this.toolTip1;
          //
            this.txtWeight.ValidEable = true;
            this.txtWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "调差重量[Kg]:";
            // 
            // cmbAlloyCode
            // 
            this.cmbAlloyCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAlloyCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlloyCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBalance, "ALLOY_CODE", true));
            this.cmbAlloyCode.DataSource = this.dsAlloyCode;
            this.cmbAlloyCode.DisplayMember = "L3DataTable.Code_Des";
            this.cmbAlloyCode.Enabled = false;
            this.cmbAlloyCode.EnableNull = false;
            this.cmbAlloyCode.ErropPr = this.errorProvider1;
            this.cmbAlloyCode.FormattingEnabled = true;
            this.cmbAlloyCode.Location = new System.Drawing.Point(151, 45);
            this.cmbAlloyCode.Name = "cmbAlloyCode";
            //
            this.cmbAlloyCode.Size = new System.Drawing.Size(158, 20);
            this.cmbAlloyCode.TabIndex = 3;
            //
            this.cmbAlloyCode.ToolTipValid = this.toolTip1;
            this.cmbAlloyCode.ValidEable = true;
            this.cmbAlloyCode.ValueMember = "L3DataTable.Code";
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
            this.dsAlloyCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\' and CODE is not null";
            this.dsAlloyCode.SourceMethod = "";
            this.dsAlloyCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAlloyCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAlloyCode.SubscribeTarget = null;
            this.dsAlloyCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyCode});
            this.dsAlloyCode.UpdateEvent = "Click";
            this.dsAlloyCode.UpdateMethod = null;
            this.dsAlloyCode.UpdateTrigger = null;
            // 
            // schemadsAlloyCode
            // 
            this.schemadsAlloyCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyCodeL3DataTableCode,
            this.coldsAlloyCodeL3DataTableCode_Des});
            this.schemadsAlloyCode.TableName = "L3DataTable";
            // 
            // coldsAlloyCodeL3DataTableCode
            // 
            this.coldsAlloyCodeL3DataTableCode.Caption = "Code";
            this.coldsAlloyCodeL3DataTableCode.ColumnName = "Code";
            this.coldsAlloyCodeL3DataTableCode.Namespace = "";
            // 
            // coldsAlloyCodeL3DataTableCode_Des
            // 
            this.coldsAlloyCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.Namespace = "";
            // 
            // cmbStore
            // 
            this.cmbStore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbStore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStore.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBalance, "POSITION", true));
            this.cmbStore.DataSource = this.dsPosition;
            this.cmbStore.DisplayMember = "L3DataTable.Code_Des";
            this.cmbStore.Enabled = false;
            this.cmbStore.EnableNull = false;
            this.cmbStore.ErropPr = this.errorProvider1;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(151, 19);
            this.cmbStore.Name = "cmbStore";
            //
            this.cmbStore.Size = new System.Drawing.Size(158, 20);
            this.cmbStore.TabIndex = 3;
            //
            this.cmbStore.ToolTipValid = this.toolTip1;
            this.cmbStore.ValidEable = true;
            this.cmbStore.ValueMember = "L3DataTable.Code";
            // 
            // dsPosition
            // 
            this.dsPosition.AutoLoad = true;
            this.dsPosition.AutoSubscribe = true;
            this.dsPosition.DataSetName = "L3DataSet";
            this.dsPosition.DeleteMethod = null;
            this.dsPosition.InsertMethod = null;
            this.dsPosition.L3DataAdapter = this.Adapter;
            this.dsPosition.LoadEvent = "Click";
            this.dsPosition.LoadTrigger = null;
            this.dsPosition.RefreshValve = 1000;
            this.dsPosition.SourceCommand = null;
            this.dsPosition.SourceCondition = "(CODE_GROUP = \'AlloyArea\' or code_group = \'AlloyGround\' or code_group = \'AlloyWir" +
                "e\') and CODE is not null";
            this.dsPosition.SourceMethod = "";
            this.dsPosition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPosition.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPosition.SubscribeTarget = null;
            this.dsPosition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPosition});
            this.dsPosition.UpdateEvent = "Click";
            this.dsPosition.UpdateMethod = null;
            this.dsPosition.UpdateTrigger = null;
            // 
            // schemadsPosition
            // 
            this.schemadsPosition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPositionL3DataTableCode,
            this.coldsPositionL3DataTableCode_Des});
            this.schemadsPosition.TableName = "L3DataTable";
            // 
            // coldsPositionL3DataTableCode
            // 
            this.coldsPositionL3DataTableCode.Caption = "Code";
            this.coldsPositionL3DataTableCode.ColumnName = "Code";
            this.coldsPositionL3DataTableCode.Namespace = "";
            // 
            // coldsPositionL3DataTableCode_Des
            // 
            this.coldsPositionL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsPositionL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsPositionL3DataTableCode_Des.Namespace = "";
            // 
            // txtCurAmount
            // 
            this.txtCurAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBalance, "OldAmount", true));
            //
            this.txtCurAmount.Enabled = false;
            this.txtCurAmount.EnableNull = false;
            this.txtCurAmount.ErropPr = this.errorProvider1;
            //
            this.txtCurAmount.Length = 0;
            this.txtCurAmount.Location = new System.Drawing.Point(151, 71);
            //this.txtCurAmount.Max = 99999;
            //
            //
            this.txtCurAmount.MaxStrLength = 0;
            this.txtCurAmount.Min = 0;
            ////
            //
            this.txtCurAmount.MinStrLength = 0;
            this.txtCurAmount.Name = "txtCurAmount";
            this.txtCurAmount.Precision = 0;
            //
            this.txtCurAmount.Size = new System.Drawing.Size(158, 21);
            this.txtCurAmount.TabIndex = 1;
            this.txtCurAmount.ToolTipValid = this.toolTip1;
          //
            this.txtCurAmount.ValidEable = true;
            this.txtCurAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "现有合金量[Kg]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(86, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "合金名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "料仓:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(99, 172);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "盘亏";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(175, 172);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "盘盈";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(268, 172);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // cmdBalance
            // 
            this.cmdBalance.Adapter = this.Adapter;
            this.cmdBalance.MergeReturnTarget = false;
            this.cmdBalance.Method = "ModifyMaterialAmount";
            this.cmdBalance.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdBalance.Parameters.Add(this.l3CommandParameter1);
            this.cmdBalance.ReturnTarget = null;
            this.cmdBalance.ReturnTargetProperty = null;
            this.cmdBalance.Trigger = null;
            this.cmdBalance.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsBalance;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
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
            this.dsError.SourceCondition = "OWNER = \'ModifyMaterialAmount\'";
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
            // AlloyBalanceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 207);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlloyBalanceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合金盘库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyBalanceFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyBalanceFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBalance;
        private AppSvrHMI.L3DataSet dsBalance;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtCurAmount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancle;
        private PxDataValid.PxComboBox cmbStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Data.DataTable schemadsBalance;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBalanceL3DataTablePOSITION;
        private System.Data.DataColumn coldsBalanceL3DataTablePOSDIFF;
        private System.Data.DataColumn coldsBalanceL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_C;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_SI;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_MN;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_P;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_S;
        private System.Data.DataColumn coldsBalanceL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_CODE;
        private System.Data.DataColumn coldsBalanceL3DataTableOldAmount;
        private System.Data.DataColumn coldsBalanceL3DataTableBalanceFlag;
        private System.Data.DataColumn coldsBalanceL3DataTableStoreAreaID;
        private AppSvrHMI.L3DataSet dsPosition;
        private System.Data.DataTable schemadsPosition;
        private System.Data.DataColumn coldsPositionL3DataTableCode;
        private System.Data.DataColumn coldsPositionL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbAlloyCode;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdBalance;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
    }
}