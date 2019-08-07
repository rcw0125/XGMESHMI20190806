namespace StoreMag.AlloyStore
{
    partial class AlloyOutStoreFrm
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
            this.bsOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsOutStroe = new AppSvrHMI.L3DataSet();
            this.schemadsBalance = new System.Data.DataTable();
            this.coldsBalanceL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePOSDIFF = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_CODE = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableOldAmount = new System.Data.DataColumn();
            this.coldsChangeL3DataTableTarget = new System.Data.DataColumn();
            this.coldsChangeL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsChangeL3DataTableUnitID = new System.Data.DataColumn();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAmount = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTarget = new PxDataValid.PxComboBox();
            this.dsHeatID = new AppSvrHMI.L3DataSet();
            this.cmbUnit = new PxDataValid.PxComboBox();
            this.dsUnit = new AppSvrHMI.L3DataSet();
            this.schemadsTraget = new System.Data.DataTable();
            this.coldsTragetL3DataTableCode = new System.Data.DataColumn();
            this.coldsTragetL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmdHeatID = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.schemadsHeatID = new System.Data.DataTable();
            this.coldsHeatIDL3DataTableHEATID = new System.Data.DataColumn();
            this.cmbAlloyCode = new PxDataValid.PxComboBox();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbCurPosition = new PxDataValid.PxComboBox();
            this.dsPosition = new AppSvrHMI.L3DataSet();
            this.schemadsPosition = new System.Data.DataTable();
            this.coldsPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurAmount = new PxDataValid.PxTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.cmdOutStore = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOutStore = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.cmdOut = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStroe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTraget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // bsOutStore
            // 
            this.bsOutStore.DataMember = "L3DataTable";
            this.bsOutStore.DataSource = this.dsOutStroe;
            // 
            // dsOutStroe
            // 
            this.dsOutStroe.AutoLoad = true;
            this.dsOutStroe.AutoSubscribe = true;
            this.dsOutStroe.DataSetName = "L3DataSet";
            this.dsOutStroe.DeleteMethod = "";
            this.dsOutStroe.InsertMethod = "";
            this.dsOutStroe.L3DataAdapter = null;
            this.dsOutStroe.LoadEvent = "Click";
            this.dsOutStroe.LoadTrigger = null;
            this.dsOutStroe.RefreshValve = 1000;
            this.dsOutStroe.SourceCommand = null;
            this.dsOutStroe.SourceCondition = "";
            this.dsOutStroe.SourceMethod = "";
            this.dsOutStroe.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsOutStroe.SourceURI = "";
            this.dsOutStroe.SubscribeTarget = "Version";
            this.dsOutStroe.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBalance});
            this.dsOutStroe.UpdateEvent = "Click";
            this.dsOutStroe.UpdateMethod = "";
            this.dsOutStroe.UpdateTrigger = null;
            // 
            // schemadsBalance
            // 
            this.schemadsBalance.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBalanceL3DataTableMATERIALID,
            this.coldsBalanceL3DataTableMATERIALTYPE,
            this.coldsBalanceL3DataTablePOSITION,
            this.coldsBalanceL3DataTablePOSDIFF,
            this.coldsBalanceL3DataTableAMOUNT,
            this.coldsBalanceL3DataTableBATCH_ID,
            this.coldsBalanceL3DataTableALLOY_CODE,
            this.coldsBalanceL3DataTableOldAmount,
            this.coldsChangeL3DataTableTarget,
            this.coldsChangeL3DataTableStoreAreaID,
            this.coldsChangeL3DataTableUnitID});
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
            // coldsChangeL3DataTableTarget
            // 
            this.coldsChangeL3DataTableTarget.Caption = "Target";
            this.coldsChangeL3DataTableTarget.ColumnName = "Target";
            this.coldsChangeL3DataTableTarget.Namespace = "";
            // 
            // coldsChangeL3DataTableStoreAreaID
            // 
            this.coldsChangeL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsChangeL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsChangeL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsChangeL3DataTableUnitID
            // 
            this.coldsChangeL3DataTableUnitID.Caption = "UnitID";
            this.coldsChangeL3DataTableUnitID.ColumnName = "UnitID";
            this.coldsChangeL3DataTableUnitID.Namespace = "";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 177);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbTarget);
            this.tabPage1.Controls.Add(this.cmbUnit);
            this.tabPage1.Controls.Add(this.cmbAlloyCode);
            this.tabPage1.Controls.Add(this.cmbCurPosition);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCurAmount);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 152);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "转库信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOutStore, "AMOUNT", true));
            this.txtAmount.EnableNull = false;
            this.txtAmount.ErropPr = this.errorProvider1;
            this.txtAmount.Length = 0;
            this.txtAmount.Location = new System.Drawing.Point(117, 112);
            this.txtAmount.Max = 0;
            this.txtAmount.MaxStrLength = 0;
            this.txtAmount.Min = -0.99;
            this.txtAmount.MinStrLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Precision = 0;
            this.txtAmount.Size = new System.Drawing.Size(195, 21);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.ToolTipValid = this.toolTip1;
            this.txtAmount.ValidEable = true;
            this.txtAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "出库重量[Kg]:";
            // 
            // cmbTarget
            // 
            this.cmbTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTarget.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOutStore, "Target", true));
            this.cmbTarget.DataSource = this.dsHeatID;
            this.cmbTarget.DisplayMember = "L3DataTable.HEATID";
            this.cmbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarget.EnableNull = false;
            this.cmbTarget.ErropPr = this.errorProvider1;
            this.cmbTarget.FormattingEnabled = true;
            this.cmbTarget.Location = new System.Drawing.Point(8, 18);
            this.cmbTarget.Name = "cmbTarget";
            this.cmbTarget.Size = new System.Drawing.Size(33, 20);
            this.cmbTarget.TabIndex = 3;
            this.cmbTarget.ToolTipValid = this.toolTip1;
            this.cmbTarget.ValidEable = true;
            this.cmbTarget.ValueMember = "L3DataTable.HEATID";
            this.cmbTarget.Visible = false;
            // 
            // dsHeatID
            // 
            this.dsHeatID.AutoLoad = true;
            this.dsHeatID.AutoSubscribe = true;
            this.dsHeatID.DataSetName = "L3DataSet";
            this.dsHeatID.DeleteMethod = "";
            this.dsHeatID.InsertMethod = "";
            this.dsHeatID.L3DataAdapter = this.Adapter;
            this.dsHeatID.LoadEvent = "";
            this.dsHeatID.LoadTrigger = this.cmbUnit;
            this.dsHeatID.RefreshValve = 1000;
            this.dsHeatID.SourceCommand = this.cmdHeatID;
            this.dsHeatID.SourceCondition = null;
            this.dsHeatID.SourceMethod = "GetUnitClosedHeatID";
            this.dsHeatID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHeatID.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.dsHeatID.SubscribeTarget = null;
            this.dsHeatID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatID});
            this.dsHeatID.UpdateEvent = "Click";
            this.dsHeatID.UpdateMethod = "";
            this.dsHeatID.UpdateTrigger = null;
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOutStore, "UnitID", true));
            this.cmbUnit.DataSource = this.dsUnit;
            this.cmbUnit.DisplayMember = "L3DataTable.Code_Des";
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.EnableNull = false;
            this.cmbUnit.ErropPr = this.errorProvider1;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(117, 58);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(195, 20);
            this.cmbUnit.TabIndex = 3;
            this.cmbUnit.ToolTipValid = this.toolTip1;
            this.cmbUnit.ValidEable = true;
            this.cmbUnit.ValueMember = "L3DataTable.Code";
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // dsUnit
            // 
            this.dsUnit.AutoLoad = true;
            this.dsUnit.AutoSubscribe = true;
            this.dsUnit.DataSetName = "L3DataSet";
            this.dsUnit.DeleteMethod = null;
            this.dsUnit.InsertMethod = null;
            this.dsUnit.L3DataAdapter = this.Adapter;
            this.dsUnit.LoadEvent = "Click";
            this.dsUnit.LoadTrigger = null;
            this.dsUnit.RefreshValve = 1000;
            this.dsUnit.SourceCommand = null;
            this.dsUnit.SourceCondition = "1=2";
            this.dsUnit.SourceMethod = "";
            this.dsUnit.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsUnit.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsUnit.SubscribeTarget = null;
            this.dsUnit.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTraget});
            this.dsUnit.UpdateEvent = "Click";
            this.dsUnit.UpdateMethod = null;
            this.dsUnit.UpdateTrigger = null;
            // 
            // schemadsTraget
            // 
            this.schemadsTraget.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTragetL3DataTableCode,
            this.coldsTragetL3DataTableCode_Des});
            this.schemadsTraget.TableName = "L3DataTable";
            // 
            // coldsTragetL3DataTableCode
            // 
            this.coldsTragetL3DataTableCode.Caption = "Code";
            this.coldsTragetL3DataTableCode.ColumnName = "Code";
            this.coldsTragetL3DataTableCode.Namespace = "";
            // 
            // coldsTragetL3DataTableCode_Des
            // 
            this.coldsTragetL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTragetL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTragetL3DataTableCode_Des.Namespace = "";
            // 
            // cmdHeatID
            // 
            this.cmdHeatID.Adapter = null;
            this.cmdHeatID.MergeReturnTarget = false;
            this.cmdHeatID.Method = null;
            this.cmdHeatID.Object = null;
            this.cmdHeatID.Parameters.Add(this.l3CommandParameter3);
            this.cmdHeatID.ReturnTarget = null;
            this.cmdHeatID.ReturnTargetProperty = null;
            this.cmdHeatID.Trigger = null;
            this.cmdHeatID.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = "";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // schemadsHeatID
            // 
            this.schemadsHeatID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatIDL3DataTableHEATID});
            this.schemadsHeatID.TableName = "L3DataTable";
            // 
            // coldsHeatIDL3DataTableHEATID
            // 
            this.coldsHeatIDL3DataTableHEATID.Caption = "HEATID";
            this.coldsHeatIDL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsHeatIDL3DataTableHEATID.DefaultValue = "";
            this.coldsHeatIDL3DataTableHEATID.Namespace = "";
            // 
            // cmbAlloyCode
            // 
            this.cmbAlloyCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAlloyCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlloyCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOutStore, "ALLOY_CODE", true));
            this.cmbAlloyCode.DataSource = this.dsAlloyCode;
            this.cmbAlloyCode.DisplayMember = "L3DataTable.Code_Des";
            this.cmbAlloyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlloyCode.Enabled = false;
            this.cmbAlloyCode.EnableNull = false;
            this.cmbAlloyCode.ErropPr = null;
            this.cmbAlloyCode.FormattingEnabled = true;
            this.cmbAlloyCode.Location = new System.Drawing.Point(117, 32);
            this.cmbAlloyCode.Name = "cmbAlloyCode";
            this.cmbAlloyCode.Size = new System.Drawing.Size(195, 20);
            this.cmbAlloyCode.TabIndex = 3;
            this.cmbAlloyCode.ToolTipValid = null;
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
            this.dsAlloyCode.SourceCondition = "CODE_GROUP = \'ALLOY_CODE\'";
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
            // cmbCurPosition
            // 
            this.cmbCurPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCurPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCurPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOutStore, "POSITION", true));
            this.cmbCurPosition.DataSource = this.dsPosition;
            this.cmbCurPosition.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCurPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurPosition.Enabled = false;
            this.cmbCurPosition.EnableNull = false;
            this.cmbCurPosition.ErropPr = this.errorProvider1;
            this.cmbCurPosition.FormattingEnabled = true;
            this.cmbCurPosition.Location = new System.Drawing.Point(117, 6);
            this.cmbCurPosition.Name = "cmbCurPosition";
            this.cmbCurPosition.Size = new System.Drawing.Size(195, 20);
            this.cmbCurPosition.TabIndex = 3;
            this.cmbCurPosition.ToolTipValid = this.toolTip1;
            this.cmbCurPosition.ValidEable = true;
            this.cmbCurPosition.ValueMember = "L3DataTable.Code";
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
            this.dsPosition.SourceCondition = "CODE_GROUP = \'AlloyGround\' and CODE is not null";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "炉号:";
            this.label5.Visible = false;
            // 
            // txtCurAmount
            // 
            this.txtCurAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOutStore, "OldAmount", true));
            this.txtCurAmount.Enabled = false;
            this.txtCurAmount.EnableNull = false;
            this.txtCurAmount.ErropPr = this.errorProvider1;
            this.txtCurAmount.Length = 0;
            this.txtCurAmount.Location = new System.Drawing.Point(117, 85);
            this.txtCurAmount.Max = 0;
            this.txtCurAmount.MaxStrLength = 0;
            this.txtCurAmount.Min = -0.99;
            this.txtCurAmount.MinStrLength = 0;
            this.txtCurAmount.Name = "txtCurAmount";
            this.txtCurAmount.Precision = 0;
            this.txtCurAmount.Size = new System.Drawing.Size(195, 21);
            this.txtCurAmount.TabIndex = 1;
            this.txtCurAmount.ToolTipValid = this.toolTip1;
            this.txtCurAmount.ValidEable = true;
            this.txtCurAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "机组:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "现有合金量[Kg]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(76, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "合金:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "料仓:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(212, 183);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(293, 183);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // cmdOutStore
            // 
            this.cmdOutStore.Adapter = this.Adapter;
            this.cmdOutStore.MergeReturnTarget = false;
            this.cmdOutStore.Method = "OutputMaterials";
            this.cmdOutStore.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdOutStore.Parameters.Add(this.l3cmdpOutStore);
            this.cmdOutStore.ReturnTarget = null;
            this.cmdOutStore.ReturnTargetProperty = null;
            this.cmdOutStore.Trigger = null;
            this.cmdOutStore.TriggerEvent = "Click";
            // 
            // l3cmdpOutStore
            // 
            this.l3cmdpOutStore.AcceptAfterExecuted = false;
            this.l3cmdpOutStore.ConstantValue = null;
            this.l3cmdpOutStore.MergeTarget = false;
            this.l3cmdpOutStore.SourceFilter = null;
            this.l3cmdpOutStore.SourceObject = this.dsOutStroe;
            this.l3cmdpOutStore.SourceProperty = "L3DataTable";
            this.l3cmdpOutStore.TargetObject = null;
            this.l3cmdpOutStore.TargetProperty = null;
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsOutStroe;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsOutStroe;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // cmdOut
            // 
            this.cmdOut.Adapter = this.Adapter;
            this.cmdOut.MergeReturnTarget = false;
            this.cmdOut.Method = "OutputMaterials";
            this.cmdOut.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdOut.Parameters.Add(this.l3CommandParameter4);
            this.cmdOut.ReturnTarget = null;
            this.cmdOut.ReturnTargetProperty = null;
            this.cmdOut.Trigger = null;
            this.cmdOut.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = this.dsOutStroe;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // AlloyOutStoreFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 220);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlloyOutStoreFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合金出库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyOutStoreFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyOutStoreFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutStroe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTraget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsOutStore;
        private AppSvrHMI.L3DataSet dsOutStroe;
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancle;
        private PxDataValid.PxComboBox cmbCurPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Data.DataTable schemadsBalance;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBalanceL3DataTablePOSITION;
        private System.Data.DataColumn coldsBalanceL3DataTablePOSDIFF;
        private System.Data.DataColumn coldsBalanceL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBalanceL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_CODE;
        private System.Data.DataColumn coldsBalanceL3DataTableOldAmount;
        private AppSvrHMI.L3DataSet dsPosition;
        private System.Data.DataTable schemadsPosition;
        private System.Data.DataColumn coldsPositionL3DataTableCode;
        private System.Data.DataColumn coldsPositionL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdOutStore;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxComboBox cmbAlloyCode;
        private PxDataValid.PxComboBox cmbTarget;
        private PxDataValid.PxComboBox cmbUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Data.DataColumn coldsChangeL3DataTableTarget;
        private System.Data.DataColumn coldsChangeL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsChangeL3DataTableUnitID;
        private AppSvrHMI.L3DataSet dsHeatID;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsUnit;
        private System.Data.DataTable schemadsTraget;
        private System.Data.DataColumn coldsTragetL3DataTableCode;
        private System.Data.DataColumn coldsTragetL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdHeatID;
        private System.Data.DataTable schemadsHeatID;
        private System.Data.DataColumn coldsHeatIDL3DataTableHEATID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3Command cmdOut;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3cmdpOutStore;
    }
}