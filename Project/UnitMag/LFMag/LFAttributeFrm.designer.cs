namespace UnitMag.LFMag
{
    partial class LFAttributeFrm
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
            this.bsLFUnit = new System.Windows.Forms.BindingSource(this.components);
            this.dsLFUnit = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsLFUnit = new System.Data.DataTable();
            this.coldsLFUnitL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLFUnitL3DataTableName = new System.Data.DataColumn();
            this.coldsLFUnitL3DataTableLid_Life = new System.Data.DataColumn();
            this.coldsLFUnitL3DataTablePoleConsume = new System.Data.DataColumn();
            this.coldsLFUnitL3DataTablePole_Vendor = new System.Data.DataColumn();
            this.coldsLFUnitL3DataTableProbe_Vendor = new System.Data.DataColumn();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbOxy = new System.Windows.Forms.ComboBox();
            this.dsOxy = new AppSvrHMI.L3DataSet();
            this.schemadsOxy = new System.Data.DataTable();
            this.coldsOxyL3DataTableCode = new System.Data.DataColumn();
            this.coldsOxyL3DataTableCode_Des = new System.Data.DataColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPoleVendor = new System.Windows.Forms.ComboBox();
            this.dsPoleVendor = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.txtLidLife = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLFID = new PxDataValid.PxTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTreatNo = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsLFUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLFUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoleVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsLFUnit
            // 
            this.bsLFUnit.DataMember = "L3DataTable";
            this.bsLFUnit.DataSource = this.dsLFUnit;
            // 
            // dsLFUnit
            // 
            this.dsLFUnit.AutoLoad = true;
            this.dsLFUnit.AutoSubscribe = true;
            this.dsLFUnit.DataSetName = "L3DataSet";
            this.dsLFUnit.DeleteMethod = null;
            this.dsLFUnit.InsertMethod = null;
            this.dsLFUnit.L3DataAdapter = this.Adapter;
            this.dsLFUnit.LoadEvent = "Click";
            this.dsLFUnit.LoadTrigger = null;
            this.dsLFUnit.RefreshValve = 1000;
            this.dsLFUnit.SourceCommand = null;
            this.dsLFUnit.SourceCondition = null;
            this.dsLFUnit.SourceMethod = "";
            this.dsLFUnit.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLFUnit.SourceURI = "XGMESLogic\\LFMag\\CLF_Unit_Mag";
            this.dsLFUnit.SubscribeTarget = null;
            this.dsLFUnit.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLFUnit});
            this.dsLFUnit.UpdateEvent = "Click";
            this.dsLFUnit.UpdateMethod = null;
            this.dsLFUnit.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsLFUnit
            // 
            this.schemadsLFUnit.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLFUnitL3DataTableGUID,
            this.coldsLFUnitL3DataTableName,
            this.coldsLFUnitL3DataTableLid_Life,
            this.coldsLFUnitL3DataTablePoleConsume,
            this.coldsLFUnitL3DataTablePole_Vendor,
            this.coldsLFUnitL3DataTableProbe_Vendor});
            this.schemadsLFUnit.TableName = "L3DataTable";
            // 
            // coldsLFUnitL3DataTableGUID
            // 
            this.coldsLFUnitL3DataTableGUID.Caption = "GUID";
            this.coldsLFUnitL3DataTableGUID.ColumnName = "GUID";
            this.coldsLFUnitL3DataTableGUID.Namespace = "";
            // 
            // coldsLFUnitL3DataTableName
            // 
            this.coldsLFUnitL3DataTableName.Caption = "Name";
            this.coldsLFUnitL3DataTableName.ColumnName = "Name";
            this.coldsLFUnitL3DataTableName.Namespace = "";
            // 
            // coldsLFUnitL3DataTableLid_Life
            // 
            this.coldsLFUnitL3DataTableLid_Life.Caption = "Lid_Life";
            this.coldsLFUnitL3DataTableLid_Life.ColumnName = "Lid_Life";
            this.coldsLFUnitL3DataTableLid_Life.DataType = typeof(int);
            this.coldsLFUnitL3DataTableLid_Life.Namespace = "";
            // 
            // coldsLFUnitL3DataTablePoleConsume
            // 
            this.coldsLFUnitL3DataTablePoleConsume.Caption = "PoleConsume";
            this.coldsLFUnitL3DataTablePoleConsume.ColumnName = "PoleConsume";
            this.coldsLFUnitL3DataTablePoleConsume.DataType = typeof(int);
            this.coldsLFUnitL3DataTablePoleConsume.Namespace = "";
            // 
            // coldsLFUnitL3DataTablePole_Vendor
            // 
            this.coldsLFUnitL3DataTablePole_Vendor.Caption = "Pole_Vendor";
            this.coldsLFUnitL3DataTablePole_Vendor.ColumnName = "Pole_Vendor";
            this.coldsLFUnitL3DataTablePole_Vendor.Namespace = "";
            // 
            // coldsLFUnitL3DataTableProbe_Vendor
            // 
            this.coldsLFUnitL3DataTableProbe_Vendor.Caption = "Probe_Vendor";
            this.coldsLFUnitL3DataTableProbe_Vendor.ColumnName = "Probe_Vendor";
            this.coldsLFUnitL3DataTableProbe_Vendor.Namespace = "";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 235);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 46);
            this.flowLayoutPanel1.TabIndex = 75;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(261, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 77;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 235);
            this.tabControl1.TabIndex = 76;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbOxy);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cmbPoleVendor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pxTextBox1);
            this.tabPage1.Controls.Add(this.txtLidLife);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtLFID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtTreatNo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbOxy
            // 
            this.cmbOxy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsLFUnit, "Probe_Vendor", true));
            this.cmbOxy.DataSource = this.dsOxy;
            this.cmbOxy.DisplayMember = "L3DataTable.Code_Des";
            this.cmbOxy.FormattingEnabled = true;
            this.cmbOxy.Location = new System.Drawing.Point(100, 167);
            this.cmbOxy.Name = "cmbOxy";
            this.cmbOxy.Size = new System.Drawing.Size(264, 20);
            this.cmbOxy.TabIndex = 77;
            this.cmbOxy.ValueMember = "L3DataTable.Code";
            // 
            // dsOxy
            // 
            this.dsOxy.AutoLoad = true;
            this.dsOxy.AutoSubscribe = true;
            this.dsOxy.DataSetName = "L3DataSet";
            this.dsOxy.DeleteMethod = "";
            this.dsOxy.InsertMethod = "";
            this.dsOxy.L3DataAdapter = this.Adapter;
            this.dsOxy.LoadEvent = "";
            this.dsOxy.LoadTrigger = null;
            this.dsOxy.RefreshValve = 1000;
            this.dsOxy.SourceCommand = null;
            this.dsOxy.SourceCondition = "code_group = \'Probe_Vonder\' order by code";
            this.dsOxy.SourceMethod = "";
            this.dsOxy.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOxy.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsOxy.SubscribeTarget = null;
            this.dsOxy.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOxy});
            this.dsOxy.UpdateEvent = "";
            this.dsOxy.UpdateMethod = "";
            this.dsOxy.UpdateTrigger = null;
            // 
            // schemadsOxy
            // 
            this.schemadsOxy.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOxyL3DataTableCode,
            this.coldsOxyL3DataTableCode_Des});
            this.schemadsOxy.TableName = "L3DataTable";
            // 
            // coldsOxyL3DataTableCode
            // 
            this.coldsOxyL3DataTableCode.Caption = "Code";
            this.coldsOxyL3DataTableCode.ColumnName = "Code";
            this.coldsOxyL3DataTableCode.Namespace = "";
            // 
            // coldsOxyL3DataTableCode_Des
            // 
            this.coldsOxyL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsOxyL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsOxyL3DataTableCode_Des.Namespace = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 76;
            this.label6.Text = "定氧探头厂家:";
            // 
            // cmbPoleVendor
            // 
            this.cmbPoleVendor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLFUnit, "Pole_Vendor", true));
            this.cmbPoleVendor.DataSource = this.dsPoleVendor;
            this.cmbPoleVendor.DisplayMember = "L3DataTable.Code";
            this.cmbPoleVendor.FormattingEnabled = true;
            this.cmbPoleVendor.Location = new System.Drawing.Point(100, 133);
            this.cmbPoleVendor.Name = "cmbPoleVendor";
            this.cmbPoleVendor.Size = new System.Drawing.Size(264, 20);
            this.cmbPoleVendor.TabIndex = 77;
            this.cmbPoleVendor.ValueMember = "L3DataTable.Code";
            // 
            // dsPoleVendor
            // 
            this.dsPoleVendor.AutoLoad = true;
            this.dsPoleVendor.AutoSubscribe = true;
            this.dsPoleVendor.DataSetName = "L3DataSet";
            this.dsPoleVendor.DeleteMethod = null;
            this.dsPoleVendor.InsertMethod = null;
            this.dsPoleVendor.L3DataAdapter = this.Adapter;
            this.dsPoleVendor.LoadEvent = "Click";
            this.dsPoleVendor.LoadTrigger = null;
            this.dsPoleVendor.RefreshValve = 1000;
            this.dsPoleVendor.SourceCommand = null;
            this.dsPoleVendor.SourceCondition = "code_group = \'Pole_Vendor\' order by code";
            this.dsPoleVendor.SourceMethod = "";
            this.dsPoleVendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPoleVendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPoleVendor.SubscribeTarget = null;
            this.dsPoleVendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsPoleVendor.UpdateEvent = "Click";
            this.dsPoleVendor.UpdateMethod = null;
            this.dsPoleVendor.UpdateTrigger = null;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 76;
            this.label5.Text = "电极厂家:";
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLFUnit, "PoleConsume", true));
            //
            this.pxTextBox1.EnableNull = false;
            this.pxTextBox1.ErropPr = null;
            //
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(100, 97);
            this.pxTextBox1.Max = 9999999;
            //
            //
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = 0;
            //
            //
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            //
            this.pxTextBox1.Size = new System.Drawing.Size(264, 21);
            this.pxTextBox1.TabIndex = 2;
            this.pxTextBox1.ToolTipValid = null;
          //
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // txtLidLife
            // 
            this.txtLidLife.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLFUnit, "Lid_Life", true));
            //
            this.txtLidLife.EnableNull = false;
            this.txtLidLife.ErropPr = this.errorProvider1;
            //
            this.txtLidLife.Length = 0;
            this.txtLidLife.Location = new System.Drawing.Point(100, 65);
            this.txtLidLife.Max = 999999;
            //
            //
            this.txtLidLife.MaxStrLength = 0;
            this.txtLidLife.Min = 0;
            //
            //
            this.txtLidLife.MinStrLength = 0;
            this.txtLidLife.Name = "txtLidLife";
            this.txtLidLife.Precision = 0;
            //
            this.txtLidLife.Size = new System.Drawing.Size(264, 21);
            this.txtLidLife.TabIndex = 2;
            this.txtLidLife.ToolTipValid = this.toolTip1;
          //
            this.txtLidLife.ValidEable = true;
            this.txtLidLife.ValidType = PxDataValid.PxTextBox.TypeEnum.Integer;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 75;
            this.label4.Text = "电极消耗:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 75;
            this.label1.Text = "炉盖寿命:";
            // 
            // txtLFID
            // 
            //
            this.txtLFID.EnableNull = true;
            this.txtLFID.ErropPr = null;
            //
            this.txtLFID.Length = 0;
            this.txtLFID.Location = new System.Drawing.Point(100, 33);
            this.txtLFID.Max = 0;
            //
            //
            this.txtLFID.MaxStrLength = 0;
            this.txtLFID.Min = 0;
            //
            //
            this.txtLFID.MinStrLength = 0;
            this.txtLFID.Name = "txtLFID";
            this.txtLFID.Precision = 0;
            this.txtLFID.ReadOnly = true;
            //
            this.txtLFID.Size = new System.Drawing.Size(264, 21);
            this.txtLFID.TabIndex = 0;
            this.txtLFID.ToolTipValid = null;
          //
            this.txtLFID.ValidEable = true;
            this.txtLFID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 65;
            this.label2.Text = "炉座:";
            // 
            // txtTreatNo
            // 
            //
            this.txtTreatNo.EnableNull = false;
            this.txtTreatNo.ErropPr = this.errorProvider1;
            //
            this.txtTreatNo.Length = 0;
            this.txtTreatNo.Location = new System.Drawing.Point(101, 0);
            this.txtTreatNo.Max = 0;
            //
            //
            this.txtTreatNo.MaxStrLength = 0;
            this.txtTreatNo.Min = -0.99;
            //
            //
            this.txtTreatNo.MinStrLength = 0;
            this.txtTreatNo.Name = "txtTreatNo";
            this.txtTreatNo.Precision = 0;
            //
            this.txtTreatNo.Size = new System.Drawing.Size(264, 21);
            this.txtTreatNo.TabIndex = 1;
            this.txtTreatNo.ToolTipValid = this.toolTip1;
          //
            this.txtTreatNo.ValidEable = true;
            this.txtTreatNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            this.txtTreatNo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 67;
            this.label3.Text = "处理号:";
            this.label3.Visible = false;
            // 
            // LFAttributeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 281);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LFAttributeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LF炉属性设置";
            this.Load += new System.EventHandler(this.LFAttributeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLFUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLFUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLFUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoleVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsLFUnit;
        private AppSvrHMI.L3DataSet dsLFUnit;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtLidLife;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtLFID;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox txtTreatNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Data.DataTable schemadsLFUnit;
        private System.Data.DataColumn coldsLFUnitL3DataTableGUID;
        private System.Data.DataColumn coldsLFUnitL3DataTableName;
        private System.Data.DataColumn coldsLFUnitL3DataTableLid_Life;
        private System.Data.DataColumn coldsLFUnitL3DataTablePoleConsume;
        private System.Windows.Forms.ComboBox cmbPoleVendor;
        private System.Windows.Forms.Label label5;
        private System.Data.DataColumn coldsLFUnitL3DataTablePole_Vendor;
        private AppSvrHMI.L3DataSet dsPoleVendor;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Windows.Forms.ComboBox cmbOxy;
        private System.Windows.Forms.Label label6;
        private AppSvrHMI.L3DataSet dsOxy;
        private System.Data.DataTable schemadsOxy;
        private System.Data.DataColumn coldsOxyL3DataTableCode;
        private System.Data.DataColumn coldsOxyL3DataTableCode_Des;
        private System.Data.DataColumn coldsLFUnitL3DataTableProbe_Vendor;
    }
}