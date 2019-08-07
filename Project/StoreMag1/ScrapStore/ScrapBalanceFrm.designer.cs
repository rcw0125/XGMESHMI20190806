namespace StoreMag.ScrapStore
{
    partial class ScrapBalanceFrm
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
            this.coldsBalanceL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableIDX = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableOldAmount = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableBalanceFlag = new System.Data.DataColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtWeight = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbScrap = new PxDataValid.PxComboBox();
            this.dsScrapArea = new AppSvrHMI.L3DataSet();
            this.schemadsScrapArea = new System.Data.DataTable();
            this.coldsScrapAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsScrapAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtCurWeight = new PxDataValid.PxTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmdBalance = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).BeginInit();
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
            this.dsBalance.SourceCondition = "";
            this.dsBalance.SourceMethod = "";
            this.dsBalance.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBalance.SourceURI = "";
            this.dsBalance.SubscribeTarget = "Version";
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
            this.coldsBalanceL3DataTableMATERIALTYPE,
            this.coldsBalanceL3DataTableMATERIALID,
            this.coldsBalanceL3DataTablePOSITION,
            this.coldsBalanceL3DataTableAMOUNT,
            this.coldsBalanceL3DataTableIDX,
            this.coldsBalanceL3DataTableOldAmount,
            this.coldsBalanceL3DataTableStoreAreaID,
            this.coldsBalanceL3DataTableBalanceFlag});
            this.schemadsBalance.TableName = "L3DataTable";
            // 
            // coldsBalanceL3DataTableMATERIALTYPE
            // 
            this.coldsBalanceL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBalanceL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBalanceL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBalanceL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBalanceL3DataTableMATERIALID
            // 
            this.coldsBalanceL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBalanceL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBalanceL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBalanceL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBalanceL3DataTablePOSITION
            // 
            this.coldsBalanceL3DataTablePOSITION.Caption = "POSITION";
            this.coldsBalanceL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsBalanceL3DataTablePOSITION.DefaultValue = "";
            this.coldsBalanceL3DataTablePOSITION.Namespace = "";
            // 
            // coldsBalanceL3DataTableAMOUNT
            // 
            this.coldsBalanceL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBalanceL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBalanceL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBalanceL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBalanceL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBalanceL3DataTableIDX
            // 
            this.coldsBalanceL3DataTableIDX.Caption = "IDX";
            this.coldsBalanceL3DataTableIDX.ColumnName = "IDX";
            this.coldsBalanceL3DataTableIDX.DataType = typeof(int);
            this.coldsBalanceL3DataTableIDX.DefaultValue = 0;
            this.coldsBalanceL3DataTableIDX.Namespace = "";
            // 
            // coldsBalanceL3DataTableOldAmount
            // 
            this.coldsBalanceL3DataTableOldAmount.Caption = "OldAmount";
            this.coldsBalanceL3DataTableOldAmount.ColumnName = "OldAmount";
            this.coldsBalanceL3DataTableOldAmount.Namespace = "";
            // 
            // coldsBalanceL3DataTableStoreAreaID
            // 
            this.coldsBalanceL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsBalanceL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsBalanceL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsBalanceL3DataTableBalanceFlag
            // 
            this.coldsBalanceL3DataTableBalanceFlag.Caption = "BalanceFlag";
            this.coldsBalanceL3DataTableBalanceFlag.ColumnName = "BalanceFlag";
            this.coldsBalanceL3DataTableBalanceFlag.DataType = typeof(int);
            this.coldsBalanceL3DataTableBalanceFlag.Namespace = "";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "废钢生铁:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(348, 138);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtWeight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbScrap);
            this.tabPage1.Controls.Add(this.txtCurWeight);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(340, 112);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "盘库信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBalance, "AMOUNT", true));
            //
            this.txtWeight.EnableNull = false;
            this.txtWeight.ErropPr = this.errorProvider1;
            //
            this.txtWeight.Length = 0;
            this.txtWeight.Location = new System.Drawing.Point(148, 74);
            this.txtWeight.Max = 9999;
            //
            //
            this.txtWeight.MaxStrLength = 0;
            this.txtWeight.Min = 0;
            //
            //
            this.txtWeight.MinStrLength = 0;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Precision = 0;
            //
            this.txtWeight.Size = new System.Drawing.Size(121, 21);
            this.txtWeight.TabIndex = 7;
            this.txtWeight.ToolTipValid = this.toolTip1;
          //
            this.txtWeight.ValidEable = true;
            this.txtWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "调差重量:";
            // 
            // cmbScrap
            // 
            this.cmbScrap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbScrap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbScrap.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBalance, "POSITION", true));
            this.cmbScrap.DataSource = this.dsScrapArea;
            this.cmbScrap.DisplayMember = "L3DataTable.Code_Des";
            this.cmbScrap.Enabled = false;
            this.cmbScrap.EnableNull = false;
            this.cmbScrap.ErropPr = this.errorProvider1;
            this.cmbScrap.FormattingEnabled = true;
            this.cmbScrap.Location = new System.Drawing.Point(148, 18);
            this.cmbScrap.Name = "cmbScrap";
            //
            this.cmbScrap.Size = new System.Drawing.Size(121, 20);
            this.cmbScrap.TabIndex = 3;
            //
            this.cmbScrap.ToolTipValid = this.toolTip1;
            this.cmbScrap.ValidEable = true;
            this.cmbScrap.ValueMember = "L3DataTable.Code";
            // 
            // dsScrapArea
            // 
            this.dsScrapArea.AutoLoad = true;
            this.dsScrapArea.AutoSubscribe = true;
            this.dsScrapArea.DataSetName = "L3DataSet";
            this.dsScrapArea.DeleteMethod = null;
            this.dsScrapArea.InsertMethod = null;
            this.dsScrapArea.L3DataAdapter = this.Adapter;
            this.dsScrapArea.LoadEvent = "Click";
            this.dsScrapArea.LoadTrigger = null;
            this.dsScrapArea.RefreshValve = 1000;
            this.dsScrapArea.SourceCommand = null;
            this.dsScrapArea.SourceCondition = "CODE_GROUP = \'ScrapArea\' and CODE is not null";
            this.dsScrapArea.SourceMethod = "";
            this.dsScrapArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapArea.SubscribeTarget = null;
            this.dsScrapArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapArea});
            this.dsScrapArea.UpdateEvent = "Click";
            this.dsScrapArea.UpdateMethod = null;
            this.dsScrapArea.UpdateTrigger = null;
            // 
            // schemadsScrapArea
            // 
            this.schemadsScrapArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapAreaL3DataTableCode,
            this.coldsScrapAreaL3DataTableCode_Des});
            this.schemadsScrapArea.TableName = "L3DataTable";
            // 
            // coldsScrapAreaL3DataTableCode
            // 
            this.coldsScrapAreaL3DataTableCode.Caption = "Code";
            this.coldsScrapAreaL3DataTableCode.ColumnName = "Code";
            this.coldsScrapAreaL3DataTableCode.Namespace = "";
            // 
            // coldsScrapAreaL3DataTableCode_Des
            // 
            this.coldsScrapAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsScrapAreaL3DataTableCode_Des.Namespace = "";
            // 
            // txtCurWeight
            // 
            this.txtCurWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBalance, "OldAmount", true));
            //
            this.txtCurWeight.Enabled = false;
            this.txtCurWeight.EnableNull = false;
            this.txtCurWeight.ErropPr = this.errorProvider1;
            //
            this.txtCurWeight.Length = 0;
            this.txtCurWeight.Location = new System.Drawing.Point(148, 46);
            this.txtCurWeight.Max = 9999;
            //
            //
            this.txtCurWeight.MaxStrLength = 0;
            this.txtCurWeight.Min = 0;
            //
            //
            this.txtCurWeight.MinStrLength = 0;
            this.txtCurWeight.Name = "txtCurWeight";
            this.txtCurWeight.Precision = 0;
            //
            this.txtCurWeight.Size = new System.Drawing.Size(121, 21);
            this.txtCurWeight.TabIndex = 1;
            this.txtCurWeight.ToolTipValid = this.toolTip1;
          //
            this.txtCurWeight.ValidEable = true;
            this.txtCurWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(71, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "现有重量:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(77, 144);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "盘亏";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(158, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "盘盈";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 144);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmdBalance
            // 
            this.cmdBalance.Adapter = this.Adapter;
            this.cmdBalance.MergeReturnTarget = false;
            this.cmdBalance.Method = "ModifyMaterialAmount";
            this.cmdBalance.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
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
            // ScrapBalanceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 192);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ScrapBalanceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "废钢盘库";
            this.Load += new System.EventHandler(this.ScrapBalanceFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapBalanceFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapArea)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtCurWeight;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private PxDataValid.PxComboBox cmbScrap;
        private System.Windows.Forms.Button btnCancel;
        private System.Data.DataTable schemadsBalance;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBalanceL3DataTablePOSITION;
        private System.Data.DataColumn coldsBalanceL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBalanceL3DataTableIDX;
        private System.Data.DataColumn coldsBalanceL3DataTableOldAmount;
        private System.Data.DataColumn coldsBalanceL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsBalanceL3DataTableBalanceFlag;
        private AppSvrHMI.L3DataSet dsScrapArea;
        private System.Data.DataTable schemadsScrapArea;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode;
        private System.Data.DataColumn coldsScrapAreaL3DataTableCode_Des;
        private PxDataValid.PxTextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3Command cmdBalance;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}