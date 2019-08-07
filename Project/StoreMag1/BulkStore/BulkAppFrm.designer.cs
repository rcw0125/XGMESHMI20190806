namespace StoreMag.BulkStore
{
    partial class BulkAppFrm
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
            this.bsBulkApp = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulkApp = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBulkApp = new System.Data.DataTable();
            this.coldsBulkAppL3DataTableBulk_Code = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableAmount = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableApp_Time = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableApp_UnitID = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableApp_Operator = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableConfirm_Operator = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableConfirm_Time = new System.Data.DataColumn();
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
            this.cmbBulkAppUnitID = new PxDataValid.PxComboBox();
            this.dsBulkArea = new AppSvrHMI.L3DataSet();
            this.schemadsBulkArea = new System.Data.DataTable();
            this.coldsBulkAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbBulkName = new PxDataValid.PxComboBox();
            this.dsBulkCode = new AppSvrHMI.L3DataSet();
            this.schemadsBulkCode = new System.Data.DataTable();
            this.coldsBulkCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtBulkWeight = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBulkApp = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.coldsBulkAppL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBulkAppL3DataTableName = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBulkApp
            // 
            this.bsBulkApp.DataMember = "L3DataTable";
            this.bsBulkApp.DataSource = this.dsBulkApp;
            // 
            // dsBulkApp
            // 
            this.dsBulkApp.AutoLoad = true;
            this.dsBulkApp.AutoSubscribe = true;
            this.dsBulkApp.DataSetName = "L3DataSet";
            this.dsBulkApp.DeleteMethod = null;
            this.dsBulkApp.InsertMethod = null;
            this.dsBulkApp.L3DataAdapter = this.Adapter;
            this.dsBulkApp.LoadEvent = "Click";
            this.dsBulkApp.LoadTrigger = null;
            this.dsBulkApp.RefreshValve = 1000;
            this.dsBulkApp.SourceCommand = null;
            this.dsBulkApp.SourceCondition = "";
            this.dsBulkApp.SourceMethod = "";
            this.dsBulkApp.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBulkApp.SourceURI = "";
            this.dsBulkApp.SubscribeTarget = "Version";
            this.dsBulkApp.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkApp});
            this.dsBulkApp.UpdateEvent = "Click";
            this.dsBulkApp.UpdateMethod = null;
            this.dsBulkApp.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBulkApp
            // 
            this.schemadsBulkApp.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkAppL3DataTableBulk_Code,
            this.coldsBulkAppL3DataTableAmount,
            this.coldsBulkAppL3DataTableApp_Time,
            this.coldsBulkAppL3DataTableApp_UnitID,
            this.coldsBulkAppL3DataTableApp_Operator,
            this.coldsBulkAppL3DataTableConfirm_Flag,
            this.coldsBulkAppL3DataTableConfirm_Operator,
            this.coldsBulkAppL3DataTableConfirm_Time});
            this.schemadsBulkApp.TableName = "L3DataTable";
            // 
            // coldsBulkAppL3DataTableBulk_Code
            // 
            this.coldsBulkAppL3DataTableBulk_Code.Caption = "Bulk_Code";
            this.coldsBulkAppL3DataTableBulk_Code.ColumnName = "Bulk_Code";
            this.coldsBulkAppL3DataTableBulk_Code.Namespace = "";
            // 
            // coldsBulkAppL3DataTableAmount
            // 
            this.coldsBulkAppL3DataTableAmount.Caption = "Amount";
            this.coldsBulkAppL3DataTableAmount.ColumnName = "Amount";
            this.coldsBulkAppL3DataTableAmount.DataType = typeof(double);
            this.coldsBulkAppL3DataTableAmount.Namespace = "";
            // 
            // coldsBulkAppL3DataTableApp_Time
            // 
            this.coldsBulkAppL3DataTableApp_Time.Caption = "App_Time";
            this.coldsBulkAppL3DataTableApp_Time.ColumnName = "App_Time";
            this.coldsBulkAppL3DataTableApp_Time.DataType = typeof(System.DateTime);
            this.coldsBulkAppL3DataTableApp_Time.Namespace = "";
            // 
            // coldsBulkAppL3DataTableApp_UnitID
            // 
            this.coldsBulkAppL3DataTableApp_UnitID.Caption = "App_UnitID";
            this.coldsBulkAppL3DataTableApp_UnitID.ColumnName = "App_UnitID";
            this.coldsBulkAppL3DataTableApp_UnitID.Namespace = "";
            // 
            // coldsBulkAppL3DataTableApp_Operator
            // 
            this.coldsBulkAppL3DataTableApp_Operator.Caption = "App_Operator";
            this.coldsBulkAppL3DataTableApp_Operator.ColumnName = "App_Operator";
            this.coldsBulkAppL3DataTableApp_Operator.Namespace = "";
            // 
            // coldsBulkAppL3DataTableConfirm_Flag
            // 
            this.coldsBulkAppL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsBulkAppL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsBulkAppL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsBulkAppL3DataTableConfirm_Flag.Namespace = "";
            // 
            // coldsBulkAppL3DataTableConfirm_Operator
            // 
            this.coldsBulkAppL3DataTableConfirm_Operator.Caption = "Confirm_Operator";
            this.coldsBulkAppL3DataTableConfirm_Operator.ColumnName = "Confirm_Operator";
            this.coldsBulkAppL3DataTableConfirm_Operator.Namespace = "";
            // 
            // coldsBulkAppL3DataTableConfirm_Time
            // 
            this.coldsBulkAppL3DataTableConfirm_Time.Caption = "Confirm_Time";
            this.coldsBulkAppL3DataTableConfirm_Time.ColumnName = "Confirm_Time";
            this.coldsBulkAppL3DataTableConfirm_Time.DataType = typeof(System.DateTime);
            this.coldsBulkAppL3DataTableConfirm_Time.Namespace = "";
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
            this.btnCancel.Location = new System.Drawing.Point(180, 148);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(99, 148);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 142);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbBulkAppUnitID);
            this.tabPage1.Controls.Add(this.cmbBulkName);
            this.tabPage1.Controls.Add(this.txtBulkWeight);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(273, 117);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "申请信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbBulkAppUnitID
            // 
            this.cmbBulkAppUnitID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBulkAppUnitID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBulkAppUnitID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBulkApp, "App_UnitID", true));
            this.cmbBulkAppUnitID.DataSource = this.dsBulkArea;
            this.cmbBulkAppUnitID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBulkAppUnitID.EnableNull = false;
            this.cmbBulkAppUnitID.ErropPr = this.errorProvider1;
            this.cmbBulkAppUnitID.FormattingEnabled = true;
            this.cmbBulkAppUnitID.Location = new System.Drawing.Point(103, 20);
            this.cmbBulkAppUnitID.Name = "cmbBulkAppUnitID";
            //
            this.cmbBulkAppUnitID.Size = new System.Drawing.Size(121, 20);
            this.cmbBulkAppUnitID.TabIndex = 3;
            //
            this.cmbBulkAppUnitID.ToolTipValid = this.toolTip1;
            this.cmbBulkAppUnitID.ValidEable = true;
            this.cmbBulkAppUnitID.ValueMember = "L3DataTable.Code";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbBulkName
            // 
            this.cmbBulkName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBulkName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBulkName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBulkApp, "Bulk_Code", true));
            this.cmbBulkName.DataSource = this.dsBulkCode;
            this.cmbBulkName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbBulkName.EnableNull = false;
            this.cmbBulkName.ErropPr = this.errorProvider1;
            this.cmbBulkName.FormattingEnabled = true;
            this.cmbBulkName.Location = new System.Drawing.Point(103, 46);
            this.cmbBulkName.Name = "cmbBulkName";
            //
            this.cmbBulkName.Size = new System.Drawing.Size(121, 20);
            this.cmbBulkName.TabIndex = 3;
            //
            this.cmbBulkName.ToolTipValid = this.toolTip1;
            this.cmbBulkName.ValidEable = true;
            this.cmbBulkName.ValueMember = "L3DataTable.Code";
            // 
            // dsBulkCode
            // 
            this.dsBulkCode.AutoLoad = true;
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
            // txtBulkWeight
            // 
            this.txtBulkWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBulkApp, "Amount", true));
            //
            this.txtBulkWeight.EnableNull = false;
            this.txtBulkWeight.ErropPr = this.errorProvider1;
            //
            this.txtBulkWeight.Length = 0;
            this.txtBulkWeight.Location = new System.Drawing.Point(103, 72);
            this.txtBulkWeight.Max = 999999;
            ////
            //
            this.txtBulkWeight.MaxStrLength = 0;
            this.txtBulkWeight.Min = 0;
            ////
            //
            this.txtBulkWeight.MinStrLength = 0;
            this.txtBulkWeight.Name = "txtBulkWeight";
            this.txtBulkWeight.Precision = 0;
            //
            this.txtBulkWeight.Size = new System.Drawing.Size(121, 21);
            this.txtBulkWeight.TabIndex = 1;
            this.txtBulkWeight.ToolTipValid = this.toolTip1;
          //
            this.txtBulkWeight.ValidEable = true;
            this.txtBulkWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "散状料量:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(29, 50);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "散状料名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "申请料仓:";
            // 
            // cmdBulkApp
            // 
            this.cmdBulkApp.Adapter = this.Adapter;
            this.cmdBulkApp.MergeReturnTarget = false;
            this.cmdBulkApp.Method = "BulkApp";
            this.cmdBulkApp.Object = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.cmdBulkApp.Parameters.Add(this.l3CommandParameter2);
            this.cmdBulkApp.ReturnTarget = null;
            this.cmdBulkApp.ReturnTargetProperty = null;
            this.cmdBulkApp.Trigger = null;
            this.cmdBulkApp.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsBulkApp;
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
            this.l3CommandParameter1.SourceObject = this.dsBulkApp;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // coldsBulkAppL3DataTableGUID
            // 
            this.coldsBulkAppL3DataTableGUID.Caption = "GUID";
            this.coldsBulkAppL3DataTableGUID.ColumnName = "GUID";
            this.coldsBulkAppL3DataTableGUID.Namespace = "";
            // 
            // coldsBulkAppL3DataTableName
            // 
            this.coldsBulkAppL3DataTableName.Caption = "Name";
            this.coldsBulkAppL3DataTableName.ColumnName = "Name";
            this.coldsBulkAppL3DataTableName.Namespace = "";
            // 
            // BulkAppFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 199);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BulkAppFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "散状料申请";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkAppFrm_FormClosing);
            this.Load += new System.EventHandler(this.BulkAppFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBulkApp;
        private AppSvrHMI.L3DataSet dsBulkApp;
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
        private PxDataValid.PxComboBox cmbBulkName;
        private PxDataValid.PxTextBox txtBulkWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxComboBox cmbBulkAppUnitID;
        private System.Data.DataTable schemadsBulkApp;
        private System.Data.DataColumn coldsBulkAppL3DataTableBulk_Code;
        private System.Data.DataColumn coldsBulkAppL3DataTableAmount;
        private System.Data.DataColumn coldsBulkAppL3DataTableApp_Time;
        private System.Data.DataColumn coldsBulkAppL3DataTableApp_UnitID;
        private System.Data.DataColumn coldsBulkAppL3DataTableApp_Operator;
        private System.Data.DataColumn coldsBulkAppL3DataTableConfirm_Flag;
        private System.Data.DataColumn coldsBulkAppL3DataTableConfirm_Operator;
        private System.Data.DataColumn coldsBulkAppL3DataTableConfirm_Time;
        private AppSvrHMI.L3DataSet dsBulkArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsBulkCode;
        private System.Data.DataTable schemadsBulkCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdBulkApp;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsBulkAppL3DataTableGUID;
        private System.Data.DataColumn coldsBulkAppL3DataTableName;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}