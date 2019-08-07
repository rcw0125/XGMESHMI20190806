namespace UnitMag.DeSMag
{
    partial class DeSMatSetShow
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDeSI = new System.Windows.Forms.TabPage();
            this.cmbMatVendor1 = new System.Windows.Forms.ComboBox();
            this.dsMatSet1 = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsMatSet = new System.Data.DataTable();
            this.coldsMatSetL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatSetL3DataTableName = new System.Data.DataColumn();
            this.coldsMatSetL3DataTableMat_Code = new System.Data.DataColumn();
            this.coldsMatSetL3DataTableMat_Vendor = new System.Data.DataColumn();
            this.dsMatVendor = new AppSvrHMI.L3DataSet();
            this.schemadsMatVendor = new System.Data.DataTable();
            this.coldsMatVendorL3DataTableCode = new System.Data.DataColumn();
            this.coldsMatVendorL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbMatCode1 = new System.Windows.Forms.ComboBox();
            this.dsMatCode = new AppSvrHMI.L3DataSet();
            this.schemadsMatCode = new System.Data.DataTable();
            this.coldsMatCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsMatCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpDeSII = new System.Windows.Forms.TabPage();
            this.cmbMatVendor2 = new System.Windows.Forms.ComboBox();
            this.cmbMatCode2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.pxComboBox1 = new PxDataValid.PxComboBox();
            this.pxTextBox2 = new PxDataValid.PxTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dsMatSet2 = new AppSvrHMI.L3DataSet();
            this.schemadsMatSet2 = new System.Data.DataTable();
            this.coldsMatSet2L3DataTableGUID = new System.Data.DataColumn();
            this.coldsMatSet2L3DataTableName = new System.Data.DataColumn();
            this.coldsMatSet2L3DataTableMat_Code = new System.Data.DataColumn();
            this.coldsMatSet2L3DataTableMat_Vendor = new System.Data.DataColumn();
            this.bsMatSet1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsMatSet2 = new System.Windows.Forms.BindingSource(this.components);
            this.tcMain.SuspendLayout();
            this.tpDeSI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).BeginInit();
            this.tpDeSII.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpDeSI);
            this.tcMain.Controls.Add(this.tpDeSII);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(381, 141);
            this.tcMain.TabIndex = 4;
            // 
            // tpDeSI
            // 
            this.tpDeSI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDeSI.Controls.Add(this.cmbMatVendor1);
            this.tpDeSI.Controls.Add(this.cmbMatCode1);
            this.tpDeSI.Controls.Add(this.label5);
            this.tpDeSI.Controls.Add(this.label4);
            this.tpDeSI.Location = new System.Drawing.Point(4, 21);
            this.tpDeSI.Name = "tpDeSI";
            this.tpDeSI.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeSI.Size = new System.Drawing.Size(373, 116);
            this.tpDeSI.TabIndex = 0;
            this.tpDeSI.Text = "I部脱硫";
            this.tpDeSI.UseVisualStyleBackColor = true;
            // 
            // cmbMatVendor1
            // 
            this.cmbMatVendor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMatSet1, "Mat_Vendor", true));
            this.cmbMatVendor1.DataSource = this.dsMatVendor;
            this.cmbMatVendor1.DisplayMember = "L3DataTable.Code_Des";
            this.cmbMatVendor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatVendor1.FormattingEnabled = true;
            this.cmbMatVendor1.Location = new System.Drawing.Point(147, 67);
            this.cmbMatVendor1.Name = "cmbMatVendor1";
            this.cmbMatVendor1.Size = new System.Drawing.Size(153, 20);
            this.cmbMatVendor1.TabIndex = 1;
            this.cmbMatVendor1.ValueMember = "L3DataTable.Code";
            // 
            // dsMatSet1
            // 
            this.dsMatSet1.AutoLoad = true;
            this.dsMatSet1.AutoSubscribe = true;
            this.dsMatSet1.DataSetName = "L3DataSet";
            this.dsMatSet1.DeleteMethod = "";
            this.dsMatSet1.InsertMethod = "";
            this.dsMatSet1.L3DataAdapter = this.Adapter;
            this.dsMatSet1.LoadEvent = "";
            this.dsMatSet1.LoadTrigger = null;
            this.dsMatSet1.RefreshValve = 1000;
            this.dsMatSet1.SourceCommand = null;
            this.dsMatSet1.SourceCondition = "name = \'S02\'";
            this.dsMatSet1.SourceMethod = "";
            this.dsMatSet1.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatSet1.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag";
            this.dsMatSet1.SubscribeTarget = "";
            this.dsMatSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatSet});
            this.dsMatSet1.UpdateEvent = "";
            this.dsMatSet1.UpdateMethod = "";
            this.dsMatSet1.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsMatSet
            // 
            this.schemadsMatSet.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatSetL3DataTableGUID,
            this.coldsMatSetL3DataTableName,
            this.coldsMatSetL3DataTableMat_Code,
            this.coldsMatSetL3DataTableMat_Vendor});
            this.schemadsMatSet.TableName = "L3DataTable";
            // 
            // coldsMatSetL3DataTableGUID
            // 
            this.coldsMatSetL3DataTableGUID.Caption = "GUID";
            this.coldsMatSetL3DataTableGUID.ColumnName = "GUID";
            this.coldsMatSetL3DataTableGUID.Namespace = "";
            // 
            // coldsMatSetL3DataTableName
            // 
            this.coldsMatSetL3DataTableName.Caption = "Name";
            this.coldsMatSetL3DataTableName.ColumnName = "Name";
            this.coldsMatSetL3DataTableName.Namespace = "";
            // 
            // coldsMatSetL3DataTableMat_Code
            // 
            this.coldsMatSetL3DataTableMat_Code.Caption = "Mat_Code";
            this.coldsMatSetL3DataTableMat_Code.ColumnName = "Mat_Code";
            this.coldsMatSetL3DataTableMat_Code.Namespace = "";
            // 
            // coldsMatSetL3DataTableMat_Vendor
            // 
            this.coldsMatSetL3DataTableMat_Vendor.Caption = "Mat_Vendor";
            this.coldsMatSetL3DataTableMat_Vendor.ColumnName = "Mat_Vendor";
            this.coldsMatSetL3DataTableMat_Vendor.Namespace = "";
            // 
            // dsMatVendor
            // 
            this.dsMatVendor.AutoLoad = true;
            this.dsMatVendor.AutoSubscribe = false;
            this.dsMatVendor.DataSetName = "L3DataSet";
            this.dsMatVendor.DeleteMethod = "";
            this.dsMatVendor.InsertMethod = "";
            this.dsMatVendor.L3DataAdapter = this.Adapter;
            this.dsMatVendor.LoadEvent = "";
            this.dsMatVendor.LoadTrigger = null;
            this.dsMatVendor.RefreshValve = 1000;
            this.dsMatVendor.SourceCommand = null;
            this.dsMatVendor.SourceCondition = "code_group = \'DeS_Mat_Vendor\'";
            this.dsMatVendor.SourceMethod = "";
            this.dsMatVendor.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatVendor.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMatVendor.SubscribeTarget = "";
            this.dsMatVendor.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatVendor});
            this.dsMatVendor.UpdateEvent = "";
            this.dsMatVendor.UpdateMethod = "";
            this.dsMatVendor.UpdateTrigger = null;
            // 
            // schemadsMatVendor
            // 
            this.schemadsMatVendor.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatVendorL3DataTableCode,
            this.coldsMatVendorL3DataTableCode_Des});
            this.schemadsMatVendor.TableName = "L3DataTable";
            // 
            // coldsMatVendorL3DataTableCode
            // 
            this.coldsMatVendorL3DataTableCode.Caption = "Code";
            this.coldsMatVendorL3DataTableCode.ColumnName = "Code";
            this.coldsMatVendorL3DataTableCode.Namespace = "";
            // 
            // coldsMatVendorL3DataTableCode_Des
            // 
            this.coldsMatVendorL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMatVendorL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMatVendorL3DataTableCode_Des.Namespace = "";
            // 
            // cmbMatCode1
            // 
            this.cmbMatCode1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMatSet1, "Mat_Code", true));
            this.cmbMatCode1.DataSource = this.dsMatCode;
            this.cmbMatCode1.DisplayMember = "L3DataTable.Code_Des";
            this.cmbMatCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMatCode1.FormattingEnabled = true;
            this.cmbMatCode1.Location = new System.Drawing.Point(147, 28);
            this.cmbMatCode1.Name = "cmbMatCode1";
            this.cmbMatCode1.Size = new System.Drawing.Size(153, 20);
            this.cmbMatCode1.TabIndex = 1;
            this.cmbMatCode1.ValueMember = "L3DataTable.Code";
            // 
            // dsMatCode
            // 
            this.dsMatCode.AutoLoad = true;
            this.dsMatCode.AutoSubscribe = false;
            this.dsMatCode.DataSetName = "L3DataSet";
            this.dsMatCode.DeleteMethod = "";
            this.dsMatCode.InsertMethod = "";
            this.dsMatCode.L3DataAdapter = this.Adapter;
            this.dsMatCode.LoadEvent = "";
            this.dsMatCode.LoadTrigger = null;
            this.dsMatCode.RefreshValve = 1000;
            this.dsMatCode.SourceCommand = null;
            this.dsMatCode.SourceCondition = "code_group = \'DeS_Mat_Code\'";
            this.dsMatCode.SourceMethod = "";
            this.dsMatCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMatCode.SubscribeTarget = "";
            this.dsMatCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatCode});
            this.dsMatCode.UpdateEvent = "";
            this.dsMatCode.UpdateMethod = "";
            this.dsMatCode.UpdateTrigger = null;
            // 
            // schemadsMatCode
            // 
            this.schemadsMatCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatCodeL3DataTableCode,
            this.coldsMatCodeL3DataTableCode_Des});
            this.schemadsMatCode.TableName = "L3DataTable";
            // 
            // coldsMatCodeL3DataTableCode
            // 
            this.coldsMatCodeL3DataTableCode.Caption = "Code";
            this.coldsMatCodeL3DataTableCode.ColumnName = "Code";
            this.coldsMatCodeL3DataTableCode.Namespace = "";
            // 
            // coldsMatCodeL3DataTableCode_Des
            // 
            this.coldsMatCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMatCodeL3DataTableCode_Des.Namespace = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "脱硫剂厂家:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "脱硫剂代码:";
            // 
            // tpDeSII
            // 
            this.tpDeSII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDeSII.Controls.Add(this.cmbMatVendor2);
            this.tpDeSII.Controls.Add(this.cmbMatCode2);
            this.tpDeSII.Controls.Add(this.label6);
            this.tpDeSII.Controls.Add(this.label7);
            this.tpDeSII.Location = new System.Drawing.Point(4, 21);
            this.tpDeSII.Name = "tpDeSII";
            this.tpDeSII.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeSII.Size = new System.Drawing.Size(373, 116);
            this.tpDeSII.TabIndex = 1;
            this.tpDeSII.Text = "II部脱硫";
            this.tpDeSII.UseVisualStyleBackColor = true;
            // 
            // cmbMatVendor2
            // 
            this.cmbMatVendor2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMatSet2, "Mat_Vendor", true));
            this.cmbMatVendor2.DataSource = this.dsMatVendor;
            this.cmbMatVendor2.DisplayMember = "L3DataTable.Code_Des";
            this.cmbMatVendor2.FormattingEnabled = true;
            this.cmbMatVendor2.Location = new System.Drawing.Point(147, 67);
            this.cmbMatVendor2.Name = "cmbMatVendor2";
            this.cmbMatVendor2.Size = new System.Drawing.Size(153, 20);
            this.cmbMatVendor2.TabIndex = 4;
            this.cmbMatVendor2.ValueMember = "L3DataTable.Code";
            // 
            // cmbMatCode2
            // 
            this.cmbMatCode2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMatSet2, "Mat_Code", true));
            this.cmbMatCode2.DataSource = this.dsMatCode;
            this.cmbMatCode2.DisplayMember = "L3DataTable.Code_Des";
            this.cmbMatCode2.FormattingEnabled = true;
            this.cmbMatCode2.Location = new System.Drawing.Point(147, 28);
            this.cmbMatCode2.Name = "cmbMatCode2";
            this.cmbMatCode2.Size = new System.Drawing.Size(153, 20);
            this.cmbMatCode2.TabIndex = 5;
            this.cmbMatCode2.ValueMember = "L3DataTable.Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "脱硫剂厂家:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "脱硫剂代码:";
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(294, 149);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(202, 149);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pxTextBox1
            // 
            this.pxTextBox1.Enabled = false;
            this.pxTextBox1.EnableNull = false;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(113, 22);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = -0.99;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Size = new System.Drawing.Size(209, 21);
            this.pxTextBox1.TabIndex = 4;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // pxComboBox1
            // 
            this.pxComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pxComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pxComboBox1.DisplayMember = "L3DataTable.Code_Des";
            this.pxComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pxComboBox1.EnableNull = false;
            this.pxComboBox1.ErropPr = null;
            this.pxComboBox1.FormattingEnabled = true;
            this.pxComboBox1.Location = new System.Drawing.Point(113, 74);
            this.pxComboBox1.Name = "pxComboBox1";
            this.pxComboBox1.Size = new System.Drawing.Size(209, 20);
            this.pxComboBox1.TabIndex = 3;
            this.pxComboBox1.ToolTipValid = null;
            this.pxComboBox1.ValidEable = true;
            this.pxComboBox1.ValueMember = "L3DataTable.Code_Val_Long";
            // 
            // pxTextBox2
            // 
            this.pxTextBox2.Enabled = false;
            this.pxTextBox2.EnableNull = false;
            this.pxTextBox2.ErropPr = null;
            this.pxTextBox2.Length = 0;
            this.pxTextBox2.Location = new System.Drawing.Point(113, 48);
            this.pxTextBox2.Max = 0;
            this.pxTextBox2.MaxStrLength = 0;
            this.pxTextBox2.Min = -0.99;
            this.pxTextBox2.MinStrLength = 0;
            this.pxTextBox2.Name = "pxTextBox2";
            this.pxTextBox2.Precision = 0;
            this.pxTextBox2.Size = new System.Drawing.Size(209, 21);
            this.pxTextBox2.TabIndex = 1;
            this.pxTextBox2.ToolTipValid = null;
            this.pxTextBox2.ValidEable = true;
            this.pxTextBox2.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "去向:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "罐号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "铁次号:";
            // 
            // dsMatSet2
            // 
            this.dsMatSet2.AutoLoad = true;
            this.dsMatSet2.AutoSubscribe = true;
            this.dsMatSet2.DataSetName = "L3DataSet";
            this.dsMatSet2.DeleteMethod = "";
            this.dsMatSet2.InsertMethod = "";
            this.dsMatSet2.L3DataAdapter = this.Adapter;
            this.dsMatSet2.LoadEvent = "";
            this.dsMatSet2.LoadTrigger = null;
            this.dsMatSet2.RefreshValve = 1000;
            this.dsMatSet2.SourceCommand = null;
            this.dsMatSet2.SourceCondition = "name = \'S03\'";
            this.dsMatSet2.SourceMethod = "";
            this.dsMatSet2.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMatSet2.SourceURI = "XGMESLogic\\DeSMag\\CDeS_Unit_Mag";
            this.dsMatSet2.SubscribeTarget = "";
            this.dsMatSet2.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMatSet2});
            this.dsMatSet2.UpdateEvent = "";
            this.dsMatSet2.UpdateMethod = "";
            this.dsMatSet2.UpdateTrigger = null;
            // 
            // schemadsMatSet2
            // 
            this.schemadsMatSet2.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMatSet2L3DataTableGUID,
            this.coldsMatSet2L3DataTableName,
            this.coldsMatSet2L3DataTableMat_Code,
            this.coldsMatSet2L3DataTableMat_Vendor});
            this.schemadsMatSet2.TableName = "L3DataTable";
            // 
            // coldsMatSet2L3DataTableGUID
            // 
            this.coldsMatSet2L3DataTableGUID.Caption = "GUID";
            this.coldsMatSet2L3DataTableGUID.ColumnName = "GUID";
            this.coldsMatSet2L3DataTableGUID.Namespace = "";
            // 
            // coldsMatSet2L3DataTableName
            // 
            this.coldsMatSet2L3DataTableName.Caption = "Name";
            this.coldsMatSet2L3DataTableName.ColumnName = "Name";
            this.coldsMatSet2L3DataTableName.Namespace = "";
            // 
            // coldsMatSet2L3DataTableMat_Code
            // 
            this.coldsMatSet2L3DataTableMat_Code.Caption = "Mat_Code";
            this.coldsMatSet2L3DataTableMat_Code.ColumnName = "Mat_Code";
            this.coldsMatSet2L3DataTableMat_Code.Namespace = "";
            // 
            // coldsMatSet2L3DataTableMat_Vendor
            // 
            this.coldsMatSet2L3DataTableMat_Vendor.Caption = "Mat_Vendor";
            this.coldsMatSet2L3DataTableMat_Vendor.ColumnName = "Mat_Vendor";
            this.coldsMatSet2L3DataTableMat_Vendor.Namespace = "";
            // 
            // bsMatSet1
            // 
            this.bsMatSet1.DataMember = "L3DataTable";
            this.bsMatSet1.DataSource = this.dsMatSet1;
            // 
            // bsMatSet2
            // 
            this.bsMatSet2.DataMember = "L3DataTable";
            this.bsMatSet2.DataSource = this.dsMatSet2;
            // 
            // DeSMatSetShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 184);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tcMain);
            this.MaximizeBox = false;
            this.Name = "DeSMatSetShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "脱硫剂代码厂家设定";
            this.Load += new System.EventHandler(this.DeSMatSetShow_Load);
            this.tcMain.ResumeLayout(false);
            this.tpDeSI.ResumeLayout(false);
            this.tpDeSI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatCode)).EndInit();
            this.tpDeSII.ResumeLayout(false);
            this.tpDeSII.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMatSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMatSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMatSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDeSI;
        private System.Windows.Forms.TabPage tpDeSII;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnConfirm;
        private PxDataValid.PxTextBox pxTextBox1;
        private PxDataValid.PxComboBox pxComboBox1;
        private PxDataValid.PxTextBox pxTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMatVendor1;
        private System.Windows.Forms.ComboBox cmbMatCode1;
        private System.Windows.Forms.ComboBox cmbMatVendor2;
        private System.Windows.Forms.ComboBox cmbMatCode2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsMatCode;
        private AppSvrHMI.L3DataSet dsMatVendor;
        private System.Data.DataTable schemadsMatCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode;
        private System.Data.DataColumn coldsMatCodeL3DataTableCode_Des;
        private System.Data.DataTable schemadsMatVendor;
        private System.Data.DataColumn coldsMatVendorL3DataTableCode;
        private System.Data.DataColumn coldsMatVendorL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsMatSet1;
        private System.Data.DataTable schemadsMatSet;
        private System.Data.DataColumn coldsMatSetL3DataTableGUID;
        private System.Data.DataColumn coldsMatSetL3DataTableName;
        private System.Data.DataColumn coldsMatSetL3DataTableMat_Code;
        private System.Data.DataColumn coldsMatSetL3DataTableMat_Vendor;
        private AppSvrHMI.L3DataSet dsMatSet2;
        private System.Data.DataTable schemadsMatSet2;
        private System.Data.DataColumn coldsMatSet2L3DataTableGUID;
        private System.Data.DataColumn coldsMatSet2L3DataTableName;
        private System.Data.DataColumn coldsMatSet2L3DataTableMat_Code;
        private System.Data.DataColumn coldsMatSet2L3DataTableMat_Vendor;
        private System.Windows.Forms.BindingSource bsMatSet1;
        private System.Windows.Forms.BindingSource bsMatSet2;
    }
}