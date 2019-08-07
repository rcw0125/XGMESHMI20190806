namespace StoreMag.AlloyStore
{
    partial class AlloyAppFrm
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
            this.bsAlloyApp = new System.Windows.Forms.BindingSource(this.components);
            this.dsAlloyApp = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsAlloyApp = new System.Data.DataTable();
            this.coldsAlloyAppL3DataTableAlloy_Code = new System.Data.DataColumn();
            this.coldsAlloyAppL3DataTableAmount = new System.Data.DataColumn();
            this.coldsAlloyAppL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsAlloyAppL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsAlloyAppL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsAlloyAppL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.coldsAlloyAppL3DataTableConfirm_Operator = new System.Data.DataColumn();
            this.coldsAlloyAppL3DataTableConfirm_Time = new System.Data.DataColumn();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbAlloyAppUnitID = new PxDataValid.PxComboBox();
            this.dsAlloyArea = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyArea = new System.Data.DataTable();
            this.coldsAlloyAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbAlloyCode = new PxDataValid.PxComboBox();
            this.dsAlloyCode = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtAlloyAmount = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAlloyApp = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // bsAlloyApp
            // 
            this.bsAlloyApp.DataMember = "L3DataTable";
            this.bsAlloyApp.DataSource = this.dsAlloyApp;
            // 
            // dsAlloyApp
            // 
            this.dsAlloyApp.AutoLoad = true;
            this.dsAlloyApp.AutoSubscribe = true;
            this.dsAlloyApp.DataSetName = "L3DataSet";
            this.dsAlloyApp.DeleteMethod = null;
            this.dsAlloyApp.InsertMethod = null;
            this.dsAlloyApp.L3DataAdapter = this.Adapter;
            this.dsAlloyApp.LoadEvent = "Click";
            this.dsAlloyApp.LoadTrigger = null;
            this.dsAlloyApp.RefreshValve = 1000;
            this.dsAlloyApp.SourceCommand = null;
            this.dsAlloyApp.SourceCondition = "";
            this.dsAlloyApp.SourceMethod = "";
            this.dsAlloyApp.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsAlloyApp.SourceURI = "";
            this.dsAlloyApp.SubscribeTarget = "Version";
            this.dsAlloyApp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyApp});
            this.dsAlloyApp.UpdateEvent = "Click";
            this.dsAlloyApp.UpdateMethod = null;
            this.dsAlloyApp.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsAlloyApp
            // 
            this.schemadsAlloyApp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyAppL3DataTableAlloy_Code,
            this.coldsAlloyAppL3DataTableAmount,
            this.coldsAlloyAppL3DataTableApp_Time,
            this.coldsAlloyAppL3DataTableApp_UnitID,
            this.coldsAlloyAppL3DataTableApp_Operator,
            this.coldsAlloyAppL3DataTableConfirm_Flag,
            this.coldsAlloyAppL3DataTableConfirm_Operator,
            this.coldsAlloyAppL3DataTableConfirm_Time});
            this.schemadsAlloyApp.TableName = "L3DataTable";
            // 
            // coldsAlloyAppL3DataTableAlloy_Code
            // 
            this.coldsAlloyAppL3DataTableAlloy_Code.Caption = "Alloy_Code";
            this.coldsAlloyAppL3DataTableAlloy_Code.ColumnName = "Alloy_Code";
            this.coldsAlloyAppL3DataTableAlloy_Code.Namespace = "";
            // 
            // coldsAlloyAppL3DataTableAmount
            // 
            this.coldsAlloyAppL3DataTableAmount.Caption = "Amount";
            this.coldsAlloyAppL3DataTableAmount.ColumnName = "Amount";
            this.coldsAlloyAppL3DataTableAmount.DataType = typeof(double);
            this.coldsAlloyAppL3DataTableAmount.Namespace = "";
            // 
            // coldsAlloyAppL3DataTableApp_Time
            // 
            this.coldsAlloyAppL3DataTableApp_Time.Caption = "App_Time";
            this.coldsAlloyAppL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsAlloyAppL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsAlloyAppL3DataTableApp_Time.Namespace = "";
            // 
            // coldsAlloyAppL3DataTableApp_UnitID
            // 
            this.coldsAlloyAppL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsAlloyAppL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsAlloyAppL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsAlloyAppL3DataTableApp_Operator
            // 
            this.coldsAlloyAppL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsAlloyAppL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsAlloyAppL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsAlloyAppL3DataTableConfirm_Flag
            // 
            this.coldsAlloyAppL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsAlloyAppL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsAlloyAppL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsAlloyAppL3DataTableConfirm_Flag.Namespace = "";
            // 
            // coldsAlloyAppL3DataTableConfirm_Operator
            // 
            this.coldsAlloyAppL3DataTableConfirm_Operator.Caption = "Confirm_Operator";
            this.coldsAlloyAppL3DataTableConfirm_Operator.ColumnName = "Confirm_Operator";
            this.coldsAlloyAppL3DataTableConfirm_Operator.Namespace = "";
            // 
            // coldsAlloyAppL3DataTableConfirm_Time
            // 
            this.coldsAlloyAppL3DataTableConfirm_Time.Caption = "Confirm_Time";
            this.coldsAlloyAppL3DataTableConfirm_Time.ColumnName = "Confirm_Time";
            this.coldsAlloyAppL3DataTableConfirm_Time.DataType = typeof(System.DateTime);
            this.coldsAlloyAppL3DataTableConfirm_Time.Namespace = "";
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(139, 179);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 166);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbAlloyAppUnitID);
            this.tabPage1.Controls.Add(this.cmbAlloyCode);
            this.tabPage1.Controls.Add(this.txtAlloyAmount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "申请信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbAlloyAppUnitID
            // 
            this.cmbAlloyAppUnitID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAlloyAppUnitID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlloyAppUnitID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAlloyApp, "App_UnitID", true));
            this.cmbAlloyAppUnitID.DataSource = this.dsAlloyArea;
            this.cmbAlloyAppUnitID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbAlloyAppUnitID.EnableNull = false;
            this.cmbAlloyAppUnitID.ErropPr = this.errorProvider1;
            this.cmbAlloyAppUnitID.FormattingEnabled = true;
            this.cmbAlloyAppUnitID.Location = new System.Drawing.Point(101, 33);
            this.cmbAlloyAppUnitID.Name = "cmbAlloyAppUnitID";
            //
            this.cmbAlloyAppUnitID.Size = new System.Drawing.Size(173, 20);
            this.cmbAlloyAppUnitID.TabIndex = 3;
            //
            this.cmbAlloyAppUnitID.ToolTipValid = this.toolTip1;
            this.cmbAlloyAppUnitID.ValidEable = true;
            this.cmbAlloyAppUnitID.ValueMember = "L3DataTable.Code";
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
            this.dsAlloyArea.SourceCondition = "CODE_GROUP = \'AlloyArea\' and CODE is not null";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbAlloyCode
            // 
            this.cmbAlloyCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAlloyCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAlloyCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAlloyApp, "Alloy_Code", true));
            this.cmbAlloyCode.DataSource = this.dsAlloyCode;
            this.cmbAlloyCode.DisplayMember = "L3DataTable.Code_Des";
            this.cmbAlloyCode.EnableNull = false;
            this.cmbAlloyCode.ErropPr = this.errorProvider1;
            this.cmbAlloyCode.FormattingEnabled = true;
            this.cmbAlloyCode.Location = new System.Drawing.Point(101, 59);
            this.cmbAlloyCode.Name = "cmbAlloyCode";
            //
            this.cmbAlloyCode.Size = new System.Drawing.Size(173, 20);
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
            // txtAlloyAmount
            // 
            this.txtAlloyAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAlloyApp, "Amount", true));
            //
            this.txtAlloyAmount.EnableNull = false;
            this.txtAlloyAmount.ErropPr = this.errorProvider1;
            //
            this.txtAlloyAmount.Length = 0;
            this.txtAlloyAmount.Location = new System.Drawing.Point(101, 85);
            this.txtAlloyAmount.Max = 99999;
            ////
            //
            this.txtAlloyAmount.MaxStrLength = 0;
            this.txtAlloyAmount.Min = 0;
            ////
            //
            this.txtAlloyAmount.MinStrLength = 0;
            this.txtAlloyAmount.Name = "txtAlloyAmount";
            this.txtAlloyAmount.Precision = 0;
            //
            this.txtAlloyAmount.Size = new System.Drawing.Size(173, 21);
            this.txtAlloyAmount.TabIndex = 1;
            this.txtAlloyAmount.ToolTipValid = this.toolTip1;
          //
            this.txtAlloyAmount.ValidEable = true;
            this.txtAlloyAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "合金量:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(36, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "合金名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "申请料仓:";
            // 
            // cmdAlloyApp
            // 
            this.cmdAlloyApp.Adapter = this.Adapter;
            this.cmdAlloyApp.MergeReturnTarget = false;
            this.cmdAlloyApp.Method = "AlloyApp";
            this.cmdAlloyApp.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdAlloyApp.Parameters.Add(this.l3CommandParameter1);
            this.cmdAlloyApp.ReturnTarget = null;
            this.cmdAlloyApp.ReturnTargetProperty = null;
            this.cmdAlloyApp.Trigger = null;
            this.cmdAlloyApp.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsAlloyApp;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // AlloyAppFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 214);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlloyAppFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合金申请";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyAppFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyAppFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAlloyApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAlloyApp;
        private AppSvrHMI.L3DataSet dsAlloyApp;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxComboBox cmbAlloyCode;
        private PxDataValid.PxTextBox txtAlloyAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxComboBox cmbAlloyAppUnitID;
        private System.Data.DataTable schemadsAlloyApp;
        private System.Data.DataColumn coldsAlloyAppL3DataTableAlloy_Code;
        private System.Data.DataColumn coldsAlloyAppL3DataTableAmount;
        private System.Data.DataColumn coldsAlloyAppL3DataTableApp_Time;
        private System.Data.DataColumn coldsAlloyAppL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsAlloyAppL3DataTableApp_Operator;
        private System.Data.DataColumn coldsAlloyAppL3DataTableConfirm_Flag;
        private System.Data.DataColumn coldsAlloyAppL3DataTableConfirm_Operator;
        private System.Data.DataColumn coldsAlloyAppL3DataTableConfirm_Time;
        private AppSvrHMI.L3DataSet dsAlloyArea;
        private System.Data.DataTable schemadsAlloyArea;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode;
        private System.Data.DataColumn coldsAlloyAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsAlloyCode;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdAlloyApp;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}