namespace UnitMag.BOFMag
{
    partial class BOFTechicsExceptionFrm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHeatID = new System.Windows.Forms.ComboBox();
            this.dsHeatID = new AppSvrHMI.L3DataSet();
            this.cmdHeatID = new AppSvrHMI.L3Command(this.components);
            this.cmdParUnitID = new AppSvrHMI.L3CommandParameter();
            this.schemadsHeatID = new System.Data.DataTable();
            this.coldsHeatIDL3DataTableHEATID = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbTechnicsException = new System.Windows.Forms.ComboBox();
            this.dsExcept = new AppSvrHMI.L3DataSet();
            this.schemadsExcept = new System.Data.DataTable();
            this.coldsExceptL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsExceptL3DataTableExceptional_Des = new System.Data.DataColumn();
            this.coldsExceptL3DataTableUnit = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dsHeatExcept = new AppSvrHMI.L3DataSet();
            this.schemadsHeatExcept = new System.Data.DataTable();
            this.coldsHeatExceptL3DataTableExceptional_Code = new System.Data.DataColumn();
            this.coldsHeatExceptL3DataTableExceptional_Time = new System.Data.DataColumn();
            this.cmdHeatExcept = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableERROR_CODE = new System.Data.DataColumn();
            this.coldsErrorL3DataTableERROR_DES = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbHeatID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 29);
            this.panel3.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 73;
            this.label1.Text = "炉号:";
            // 
            // cmbHeatID
            // 
            this.cmbHeatID.BackColor = System.Drawing.Color.White;
            this.cmbHeatID.DataSource = this.dsHeatID;
            this.cmbHeatID.DisplayMember = "L3DataTable.HEATID";
            this.cmbHeatID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHeatID.FormattingEnabled = true;
            this.cmbHeatID.Location = new System.Drawing.Point(91, 6);
            this.cmbHeatID.Name = "cmbHeatID";
            this.cmbHeatID.Size = new System.Drawing.Size(121, 20);
            this.cmbHeatID.TabIndex = 33;
            this.cmbHeatID.ValueMember = "L3DataTable.HEATID";
            // 
            // dsHeatID
            // 
            this.dsHeatID.DataSetName = "L3DataSet";
            this.dsHeatID.DeleteMethod = "";
            this.dsHeatID.InsertMethod = "";
            this.dsHeatID.L3DataAdapter = this.Adapter;
            this.dsHeatID.LoadEvent = "Click";
            this.dsHeatID.LoadTrigger = null;
            this.dsHeatID.RefreshValve = 1000;
            this.dsHeatID.SourceCommand = this.cmdHeatID;
            this.dsHeatID.SourceCondition = null;
            this.dsHeatID.SourceMethod = "GetExceptHeatID";
            this.dsHeatID.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsHeatID.SourceURI = "XGMESLogic\\BOFMag\\CBOF_Unit_Mag\\S21";
            this.dsHeatID.SubscribeTarget = null;
            this.dsHeatID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatID});
            this.dsHeatID.UpdateEvent = "Click";
            this.dsHeatID.UpdateMethod = "";
            this.dsHeatID.UpdateTrigger = null;
            // 
            // cmdHeatID
            // 
            this.cmdHeatID.Adapter = null;
            this.cmdHeatID.MergeReturnTarget = false;
            this.cmdHeatID.Method = null;
            this.cmdHeatID.Object = null;
            this.cmdHeatID.Parameters.Add(this.cmdParUnitID);
            this.cmdHeatID.ReturnTarget = null;
            this.cmdHeatID.ReturnTargetProperty = null;
            this.cmdHeatID.Trigger = null;
            this.cmdHeatID.TriggerEvent = "Click";
            // 
            // cmdParUnitID
            // 
            this.cmdParUnitID.AcceptAfterExecuted = false;
            this.cmdParUnitID.ConstantValue = null;
            this.cmdParUnitID.MergeTarget = false;
            this.cmdParUnitID.SourceFilter = null;
            this.cmdParUnitID.SourceObject = null;
            this.cmdParUnitID.SourceProperty = null;
            this.cmdParUnitID.TargetObject = null;
            this.cmdParUnitID.TargetProperty = null;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 41);
            this.flowLayoutPanel1.TabIndex = 82;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(286, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(205, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 84;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 100);
            this.tabControl1.TabIndex = 83;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbTechnicsException);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 75);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbTechnicsException
            // 
            this.cmbTechnicsException.DataSource = this.dsExcept;
            this.cmbTechnicsException.DisplayMember = "L3DataTable.Exceptional_Des";
            this.cmbTechnicsException.FormattingEnabled = true;
            this.cmbTechnicsException.Location = new System.Drawing.Point(86, 26);
            this.cmbTechnicsException.Name = "cmbTechnicsException";
            this.cmbTechnicsException.Size = new System.Drawing.Size(235, 20);
            this.cmbTechnicsException.TabIndex = 73;
            this.cmbTechnicsException.ValueMember = "L3DataTable.Exceptional_Code";
            // 
            // dsExcept
            // 
            this.dsExcept.DataSetName = "L3DataSet";
            this.dsExcept.DeleteMethod = null;
            this.dsExcept.InsertMethod = null;
            this.dsExcept.L3DataAdapter = this.Adapter;
            this.dsExcept.LoadEvent = "Click";
            this.dsExcept.LoadTrigger = null;
            this.dsExcept.RefreshValve = 1000;
            this.dsExcept.SourceCommand = null;
            this.dsExcept.SourceCondition = "Unit=\'{UnitID}\'";
            this.dsExcept.SourceMethod = "";
            this.dsExcept.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsExcept.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Except_Code";
            this.dsExcept.SubscribeTarget = null;
            this.dsExcept.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsExcept});
            this.dsExcept.UpdateEvent = "Click";
            this.dsExcept.UpdateMethod = null;
            this.dsExcept.UpdateTrigger = null;
            // 
            // schemadsExcept
            // 
            this.schemadsExcept.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsExceptL3DataTableExceptional_Code,
            this.coldsExceptL3DataTableExceptional_Des,
            this.coldsExceptL3DataTableUnit});
            this.schemadsExcept.TableName = "L3DataTable";
            // 
            // coldsExceptL3DataTableExceptional_Code
            // 
            this.coldsExceptL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsExceptL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsExceptL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsExceptL3DataTableExceptional_Des
            // 
            this.coldsExceptL3DataTableExceptional_Des.Caption = "Exceptional_Des";
            this.coldsExceptL3DataTableExceptional_Des.ColumnName = "Exceptional_Des";
            this.coldsExceptL3DataTableExceptional_Des.Namespace = "";
            // 
            // coldsExceptL3DataTableUnit
            // 
            this.coldsExceptL3DataTableUnit.Caption = "Unit";
            this.coldsExceptL3DataTableUnit.ColumnName = "Unit";
            this.coldsExceptL3DataTableUnit.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 72;
            this.label3.Text = "工艺异常:";
            // 
            // dsHeatExcept
            // 
            this.dsHeatExcept.DataSetName = "L3DataSet";
            this.dsHeatExcept.DeleteMethod = null;
            this.dsHeatExcept.InsertMethod = null;
            this.dsHeatExcept.L3DataAdapter = null;
            this.dsHeatExcept.LoadEvent = "Click";
            this.dsHeatExcept.LoadTrigger = null;
            this.dsHeatExcept.RefreshValve = 1000;
            this.dsHeatExcept.SourceCommand = null;
            this.dsHeatExcept.SourceCondition = null;
            this.dsHeatExcept.SourceMethod = "";
            this.dsHeatExcept.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsHeatExcept.SourceURI = "XGMESLogic\\QualityMag\\CQA_Heat_Prod_Except";
            this.dsHeatExcept.SubscribeTarget = null;
            this.dsHeatExcept.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHeatExcept});
            this.dsHeatExcept.UpdateEvent = "Click";
            this.dsHeatExcept.UpdateMethod = null;
            this.dsHeatExcept.UpdateTrigger = null;
            // 
            // schemadsHeatExcept
            // 
            this.schemadsHeatExcept.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHeatExceptL3DataTableExceptional_Code,
            this.coldsHeatExceptL3DataTableExceptional_Time});
            this.schemadsHeatExcept.TableName = "L3DataTable";
            // 
            // coldsHeatExceptL3DataTableExceptional_Code
            // 
            this.coldsHeatExceptL3DataTableExceptional_Code.Caption = "Exceptional_Code";
            this.coldsHeatExceptL3DataTableExceptional_Code.ColumnName = "Exceptional_Code";
            this.coldsHeatExceptL3DataTableExceptional_Code.Namespace = "";
            // 
            // coldsHeatExceptL3DataTableExceptional_Time
            // 
            this.coldsHeatExceptL3DataTableExceptional_Time.Caption = "Exceptional_Time";
            this.coldsHeatExceptL3DataTableExceptional_Time.ColumnName = "Exceptional_Time";
            this.coldsHeatExceptL3DataTableExceptional_Time.DataType = typeof(System.DateTime);
            this.coldsHeatExceptL3DataTableExceptional_Time.Namespace = "";
            // 
            // cmdHeatExcept
            // 
            this.cmdHeatExcept.Adapter = this.Adapter;
            this.cmdHeatExcept.MergeReturnTarget = false;
            this.cmdHeatExcept.Method = "NewHeatExceptionData";
            this.cmdHeatExcept.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdHeatExcept.Parameters.Add(this.l3CommandParameter1);
            this.cmdHeatExcept.Parameters.Add(this.l3CommandParameter2);
            this.cmdHeatExcept.Parameters.Add(this.l3CommandParameter3);
            this.cmdHeatExcept.Parameters.Add(this.l3CommandParameter4);
            this.cmdHeatExcept.ReturnTarget = null;
            this.cmdHeatExcept.ReturnTargetProperty = null;
            this.cmdHeatExcept.Trigger = null;
            this.cmdHeatExcept.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
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
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = null;
            this.l3CommandParameter4.SourceObject = null;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'UnitMag\'";
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
            // BOFTechicsExceptionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 170);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BOFTechicsExceptionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉次工艺异常";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatID)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHeatExcept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbHeatID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbTechnicsException;
        private System.Windows.Forms.Label label3;
        private AppSvrHMI.L3DataSet dsExcept;
        private System.Data.DataTable schemadsExcept;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsExceptL3DataTableExceptional_Des;
        private System.Data.DataColumn coldsExceptL3DataTableUnit;
        private AppSvrHMI.L3DataSet dsHeatID;
        private AppSvrHMI.L3Command cmdHeatID;
        private AppSvrHMI.L3CommandParameter cmdParUnitID;
        private System.Data.DataTable schemadsHeatID;
        private System.Data.DataColumn coldsHeatIDL3DataTableHEATID;
        private AppSvrHMI.L3DataSet dsHeatExcept;
        private System.Data.DataTable schemadsHeatExcept;
        private System.Data.DataColumn coldsHeatExceptL3DataTableExceptional_Code;
        private System.Data.DataColumn coldsHeatExceptL3DataTableExceptional_Time;
        private AppSvrHMI.L3Command cmdHeatExcept;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_CODE;
        private System.Data.DataColumn coldsErrorL3DataTableERROR_DES;
    }
}