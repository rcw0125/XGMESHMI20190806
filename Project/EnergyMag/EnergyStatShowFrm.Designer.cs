namespace EnergyMag
{
    partial class EnergyStatShowFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtProductionDate = new System.Windows.Forms.DateTimePicker();
            this.bsStat = new System.Windows.Forms.BindingSource(this.components);
            this.dsStat = new AppSvrHMI.L3DataSet();
            this.schemadsStat = new System.Data.DataTable();
            this.coldsStatL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStatL3DataTableName = new System.Data.DataColumn();
            this.coldsStatL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_CFCO = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_BOFCO = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_BOFCO_CallBack = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_N2 = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_N2_SpecialSteel = new System.Data.DataColumn();
            this.coldsStatL3DataTableFlow_O2 = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_D_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableCFCO_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableO2_M_Avg = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_M = new System.Data.DataColumn();
            this.coldsStatL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsStatL3DataTableOperator = new System.Data.DataColumn();
            this.coldsStatL3DataTableStatus = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_Special_D = new System.Data.DataColumn();
            this.coldsStatL3DataTableProduction_Special_M = new System.Data.DataColumn();
            this.myLine1 = new buttonHide.MyLine();
            this.txtProduction_Special_M = new System.Windows.Forms.TextBox();
            this.txtO2_M_Avg = new System.Windows.Forms.TextBox();
            this.txtO2_M = new System.Windows.Forms.TextBox();
            this.txtO2_D_Avg = new System.Windows.Forms.TextBox();
            this.txtO2_D = new System.Windows.Forms.TextBox();
            this.txtFlow_O2 = new System.Windows.Forms.TextBox();
            this.txtN2_M_Avg = new System.Windows.Forms.TextBox();
            this.txtN2_M = new System.Windows.Forms.TextBox();
            this.txtN2_D_Avg = new System.Windows.Forms.TextBox();
            this.txtN2_D = new System.Windows.Forms.TextBox();
            this.txtFlow_N2 = new System.Windows.Forms.TextBox();
            this.txtBOFCO_M_Avg = new System.Windows.Forms.TextBox();
            this.txtBOFCO_M = new System.Windows.Forms.TextBox();
            this.txtBOFCO_D_Avg = new System.Windows.Forms.TextBox();
            this.txtBOFCO_D = new System.Windows.Forms.TextBox();
            this.txtFlow_BOFCO = new System.Windows.Forms.TextBox();
            this.txtProduction_Special_D = new System.Windows.Forms.TextBox();
            this.txtProduction_M = new System.Windows.Forms.TextBox();
            this.txtN2_SpecialSteel_M_Avg = new System.Windows.Forms.TextBox();
            this.txtN2_SpecialSteel_M = new System.Windows.Forms.TextBox();
            this.txtN2_SpecialSteel_D_Avg = new System.Windows.Forms.TextBox();
            this.txtN2_SpecialSteel_D = new System.Windows.Forms.TextBox();
            this.txtFlow_N2_SpecialSteel = new System.Windows.Forms.TextBox();
            this.txtBOFCO_CallBack_M_Avg = new System.Windows.Forms.TextBox();
            this.txtBOFCO_CallBack_M = new System.Windows.Forms.TextBox();
            this.txtBOFCO_CallBack_D_Avg = new System.Windows.Forms.TextBox();
            this.txtBOFCO_CallBack_D = new System.Windows.Forms.TextBox();
            this.txtFlow_BOFCO_CallBack = new System.Windows.Forms.TextBox();
            this.txtCFCO_M_Avg = new System.Windows.Forms.TextBox();
            this.txtCFCO_M = new System.Windows.Forms.TextBox();
            this.txtCFCO_D_Avg = new System.Windows.Forms.TextBox();
            this.txtCFCO_D = new System.Windows.Forms.TextBox();
            this.txtFlow_CFCO = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProduction_D = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dsLastData = new AppSvrHMI.L3DataSet();
            this.schemadsLastData = new System.Data.DataTable();
            this.coldsLastDataL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableCFCO_M = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableBOFCO_M = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableBOFCO_CallBack_M = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableN2_M = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableN2_SpecialSteel_M = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableO2_M = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableProduction_M = new System.Data.DataColumn();
            this.coldsLastDataL3DataTableProduction_Special_M = new System.Data.DataColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLastData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLastData)).BeginInit();
            this.SuspendLayout();
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日    期:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(517, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(598, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 309);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(706, 68);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 309);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dtProductionDate);
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.txtProduction_Special_M);
            this.tabPage1.Controls.Add(this.txtO2_M_Avg);
            this.tabPage1.Controls.Add(this.txtO2_M);
            this.tabPage1.Controls.Add(this.txtO2_D_Avg);
            this.tabPage1.Controls.Add(this.txtO2_D);
            this.tabPage1.Controls.Add(this.txtFlow_O2);
            this.tabPage1.Controls.Add(this.txtN2_M_Avg);
            this.tabPage1.Controls.Add(this.txtN2_M);
            this.tabPage1.Controls.Add(this.txtN2_D_Avg);
            this.tabPage1.Controls.Add(this.txtN2_D);
            this.tabPage1.Controls.Add(this.txtFlow_N2);
            this.tabPage1.Controls.Add(this.txtBOFCO_M_Avg);
            this.tabPage1.Controls.Add(this.txtBOFCO_M);
            this.tabPage1.Controls.Add(this.txtBOFCO_D_Avg);
            this.tabPage1.Controls.Add(this.txtBOFCO_D);
            this.tabPage1.Controls.Add(this.txtFlow_BOFCO);
            this.tabPage1.Controls.Add(this.txtProduction_Special_D);
            this.tabPage1.Controls.Add(this.txtProduction_M);
            this.tabPage1.Controls.Add(this.txtN2_SpecialSteel_M_Avg);
            this.tabPage1.Controls.Add(this.txtN2_SpecialSteel_M);
            this.tabPage1.Controls.Add(this.txtN2_SpecialSteel_D_Avg);
            this.tabPage1.Controls.Add(this.txtN2_SpecialSteel_D);
            this.tabPage1.Controls.Add(this.txtFlow_N2_SpecialSteel);
            this.tabPage1.Controls.Add(this.txtBOFCO_CallBack_M_Avg);
            this.tabPage1.Controls.Add(this.txtBOFCO_CallBack_M);
            this.tabPage1.Controls.Add(this.txtBOFCO_CallBack_D_Avg);
            this.tabPage1.Controls.Add(this.txtBOFCO_CallBack_D);
            this.tabPage1.Controls.Add(this.txtFlow_BOFCO_CallBack);
            this.tabPage1.Controls.Add(this.txtCFCO_M_Avg);
            this.tabPage1.Controls.Add(this.txtCFCO_M);
            this.tabPage1.Controls.Add(this.txtCFCO_D_Avg);
            this.tabPage1.Controls.Add(this.txtCFCO_D);
            this.tabPage1.Controls.Add(this.txtFlow_CFCO);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txtProduction_D);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(698, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtProductionDate
            // 
            this.dtProductionDate.CustomFormat = "yyyy-MM-dd";
            this.dtProductionDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "ProductionDate", true));
            this.dtProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtProductionDate.Location = new System.Drawing.Point(110, 19);
            this.dtProductionDate.Name = "dtProductionDate";
            this.dtProductionDate.Size = new System.Drawing.Size(112, 21);
            this.dtProductionDate.TabIndex = 0;
            this.dtProductionDate.ValueChanged += new System.EventHandler(this.dtProductionDate_ValueChanged);
            // 
            // bsStat
            // 
            this.bsStat.DataMember = "L3DataTable";
            this.bsStat.DataSource = this.dsStat;
            // 
            // dsStat
            // 
            this.dsStat.AutoLoad = true;
            this.dsStat.AutoSubscribe = false;
            this.dsStat.DataSetName = "L3DataSet";
            this.dsStat.DeleteMethod = "";
            this.dsStat.InsertMethod = "";
            this.dsStat.L3DataAdapter = null;
            this.dsStat.LoadEvent = "";
            this.dsStat.LoadTrigger = null;
            this.dsStat.RefreshValve = 1000;
            this.dsStat.SourceCommand = null;
            this.dsStat.SourceCondition = "";
            this.dsStat.SourceMethod = "";
            this.dsStat.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsStat.SourceURI = "";
            this.dsStat.SubscribeTarget = "";
            this.dsStat.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStat});
            this.dsStat.UpdateEvent = "";
            this.dsStat.UpdateMethod = "";
            this.dsStat.UpdateTrigger = null;
            // 
            // schemadsStat
            // 
            this.schemadsStat.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatL3DataTableGUID,
            this.coldsStatL3DataTableName,
            this.coldsStatL3DataTableProductionDate,
            this.coldsStatL3DataTableFlow_CFCO,
            this.coldsStatL3DataTableFlow_BOFCO,
            this.coldsStatL3DataTableFlow_BOFCO_CallBack,
            this.coldsStatL3DataTableFlow_N2,
            this.coldsStatL3DataTableFlow_N2_SpecialSteel,
            this.coldsStatL3DataTableFlow_O2,
            this.coldsStatL3DataTableCFCO_D,
            this.coldsStatL3DataTableBOFCO_D,
            this.coldsStatL3DataTableBOFCO_CallBack_D,
            this.coldsStatL3DataTableN2_D,
            this.coldsStatL3DataTableN2_SpecialSteel_D,
            this.coldsStatL3DataTableO2_D,
            this.coldsStatL3DataTableCFCO_D_Avg,
            this.coldsStatL3DataTableBOFCO_D_Avg,
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg,
            this.coldsStatL3DataTableN2_D_Avg,
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg,
            this.coldsStatL3DataTableO2_D_Avg,
            this.coldsStatL3DataTableCFCO_M,
            this.coldsStatL3DataTableBOFCO_M,
            this.coldsStatL3DataTableBOFCO_CallBack_M,
            this.coldsStatL3DataTableN2_M,
            this.coldsStatL3DataTableN2_SpecialSteel_M,
            this.coldsStatL3DataTableO2_M,
            this.coldsStatL3DataTableCFCO_M_Avg,
            this.coldsStatL3DataTableBOFCO_M_Avg,
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg,
            this.coldsStatL3DataTableN2_M_Avg,
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg,
            this.coldsStatL3DataTableO2_M_Avg,
            this.coldsStatL3DataTableProduction_D,
            this.coldsStatL3DataTableProduction_M,
            this.coldsStatL3DataTableCreateTime,
            this.coldsStatL3DataTableOperator,
            this.coldsStatL3DataTableStatus,
            this.coldsStatL3DataTableProduction_Special_D,
            this.coldsStatL3DataTableProduction_Special_M});
            this.schemadsStat.TableName = "L3DataTable";
            // 
            // coldsStatL3DataTableGUID
            // 
            this.coldsStatL3DataTableGUID.Caption = "GUID";
            this.coldsStatL3DataTableGUID.ColumnName = "GUID";
            this.coldsStatL3DataTableGUID.Namespace = "";
            // 
            // coldsStatL3DataTableName
            // 
            this.coldsStatL3DataTableName.Caption = "Name";
            this.coldsStatL3DataTableName.ColumnName = "Name";
            this.coldsStatL3DataTableName.Namespace = "";
            // 
            // coldsStatL3DataTableProductionDate
            // 
            this.coldsStatL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsStatL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsStatL3DataTableProductionDate.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_CFCO
            // 
            this.coldsStatL3DataTableFlow_CFCO.Caption = "Flow_CFCO";
            this.coldsStatL3DataTableFlow_CFCO.ColumnName = "Flow_CFCO";
            this.coldsStatL3DataTableFlow_CFCO.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_CFCO.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_BOFCO
            // 
            this.coldsStatL3DataTableFlow_BOFCO.Caption = "Flow_BOFCO";
            this.coldsStatL3DataTableFlow_BOFCO.ColumnName = "Flow_BOFCO";
            this.coldsStatL3DataTableFlow_BOFCO.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_BOFCO.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_BOFCO_CallBack
            // 
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.Caption = "Flow_BOFCO_CallBack";
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.ColumnName = "Flow_BOFCO_CallBack";
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_BOFCO_CallBack.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_N2
            // 
            this.coldsStatL3DataTableFlow_N2.Caption = "Flow_N2";
            this.coldsStatL3DataTableFlow_N2.ColumnName = "Flow_N2";
            this.coldsStatL3DataTableFlow_N2.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_N2.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_N2_SpecialSteel
            // 
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.Caption = "Flow_N2_SpecialSteel";
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.ColumnName = "Flow_N2_SpecialSteel";
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_N2_SpecialSteel.Namespace = "";
            // 
            // coldsStatL3DataTableFlow_O2
            // 
            this.coldsStatL3DataTableFlow_O2.Caption = "Flow_O2";
            this.coldsStatL3DataTableFlow_O2.ColumnName = "Flow_O2";
            this.coldsStatL3DataTableFlow_O2.DataType = typeof(float);
            this.coldsStatL3DataTableFlow_O2.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_D
            // 
            this.coldsStatL3DataTableCFCO_D.Caption = "CFCO_D";
            this.coldsStatL3DataTableCFCO_D.ColumnName = "CFCO_D";
            this.coldsStatL3DataTableCFCO_D.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_D.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_D
            // 
            this.coldsStatL3DataTableBOFCO_D.Caption = "BOFCO_D";
            this.coldsStatL3DataTableBOFCO_D.ColumnName = "BOFCO_D";
            this.coldsStatL3DataTableBOFCO_D.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_D.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_D
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_D.Caption = "BOFCO_CallBack_D";
            this.coldsStatL3DataTableBOFCO_CallBack_D.ColumnName = "BOFCO_CallBack_D";
            this.coldsStatL3DataTableBOFCO_CallBack_D.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_D.Namespace = "";
            // 
            // coldsStatL3DataTableN2_D
            // 
            this.coldsStatL3DataTableN2_D.Caption = "N2_D";
            this.coldsStatL3DataTableN2_D.ColumnName = "N2_D";
            this.coldsStatL3DataTableN2_D.DataType = typeof(float);
            this.coldsStatL3DataTableN2_D.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_D
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_D.Caption = "N2_SpecialSteel_D";
            this.coldsStatL3DataTableN2_SpecialSteel_D.ColumnName = "N2_SpecialSteel_D";
            this.coldsStatL3DataTableN2_SpecialSteel_D.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_D.Namespace = "";
            // 
            // coldsStatL3DataTableO2_D
            // 
            this.coldsStatL3DataTableO2_D.Caption = "O2_D";
            this.coldsStatL3DataTableO2_D.ColumnName = "O2_D";
            this.coldsStatL3DataTableO2_D.DataType = typeof(float);
            this.coldsStatL3DataTableO2_D.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_D_Avg
            // 
            this.coldsStatL3DataTableCFCO_D_Avg.Caption = "CFCO_D_Avg";
            this.coldsStatL3DataTableCFCO_D_Avg.ColumnName = "CFCO_D_Avg";
            this.coldsStatL3DataTableCFCO_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_D_Avg
            // 
            this.coldsStatL3DataTableBOFCO_D_Avg.Caption = "BOFCO_D_Avg";
            this.coldsStatL3DataTableBOFCO_D_Avg.ColumnName = "BOFCO_D_Avg";
            this.coldsStatL3DataTableBOFCO_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_D_Avg
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.Caption = "BOFCO_CallBack_D_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.ColumnName = "BOFCO_CallBack_D_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_D_Avg
            // 
            this.coldsStatL3DataTableN2_D_Avg.Caption = "N2_D_Avg";
            this.coldsStatL3DataTableN2_D_Avg.ColumnName = "N2_D_Avg";
            this.coldsStatL3DataTableN2_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_D_Avg
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.Caption = "N2_SpecialSteel_D_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.ColumnName = "N2_SpecialSteel_D_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableO2_D_Avg
            // 
            this.coldsStatL3DataTableO2_D_Avg.Caption = "O2_D_Avg";
            this.coldsStatL3DataTableO2_D_Avg.ColumnName = "O2_D_Avg";
            this.coldsStatL3DataTableO2_D_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableO2_D_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_M
            // 
            this.coldsStatL3DataTableCFCO_M.Caption = "CFCO_M";
            this.coldsStatL3DataTableCFCO_M.ColumnName = "CFCO_M";
            this.coldsStatL3DataTableCFCO_M.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_M.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_M
            // 
            this.coldsStatL3DataTableBOFCO_M.Caption = "BOFCO_M";
            this.coldsStatL3DataTableBOFCO_M.ColumnName = "BOFCO_M";
            this.coldsStatL3DataTableBOFCO_M.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_M.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_M
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_M.Caption = "BOFCO_CallBack_M";
            this.coldsStatL3DataTableBOFCO_CallBack_M.ColumnName = "BOFCO_CallBack_M";
            this.coldsStatL3DataTableBOFCO_CallBack_M.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_M.Namespace = "";
            // 
            // coldsStatL3DataTableN2_M
            // 
            this.coldsStatL3DataTableN2_M.Caption = "N2_M";
            this.coldsStatL3DataTableN2_M.ColumnName = "N2_M";
            this.coldsStatL3DataTableN2_M.DataType = typeof(float);
            this.coldsStatL3DataTableN2_M.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_M
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_M.Caption = "N2_SpecialSteel_M";
            this.coldsStatL3DataTableN2_SpecialSteel_M.ColumnName = "N2_SpecialSteel_M";
            this.coldsStatL3DataTableN2_SpecialSteel_M.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_M.Namespace = "";
            // 
            // coldsStatL3DataTableO2_M
            // 
            this.coldsStatL3DataTableO2_M.Caption = "O2_M";
            this.coldsStatL3DataTableO2_M.ColumnName = "O2_M";
            this.coldsStatL3DataTableO2_M.DataType = typeof(float);
            this.coldsStatL3DataTableO2_M.Namespace = "";
            // 
            // coldsStatL3DataTableCFCO_M_Avg
            // 
            this.coldsStatL3DataTableCFCO_M_Avg.Caption = "CFCO_M_Avg";
            this.coldsStatL3DataTableCFCO_M_Avg.ColumnName = "CFCO_M_Avg";
            this.coldsStatL3DataTableCFCO_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableCFCO_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_M_Avg
            // 
            this.coldsStatL3DataTableBOFCO_M_Avg.Caption = "BOFCO_M_Avg";
            this.coldsStatL3DataTableBOFCO_M_Avg.ColumnName = "BOFCO_M_Avg";
            this.coldsStatL3DataTableBOFCO_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableBOFCO_CallBack_M_Avg
            // 
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.Caption = "BOFCO_CallBack_M_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.ColumnName = "BOFCO_CallBack_M_Avg";
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableBOFCO_CallBack_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_M_Avg
            // 
            this.coldsStatL3DataTableN2_M_Avg.Caption = "N2_M_Avg";
            this.coldsStatL3DataTableN2_M_Avg.ColumnName = "N2_M_Avg";
            this.coldsStatL3DataTableN2_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableN2_SpecialSteel_M_Avg
            // 
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.Caption = "N2_SpecialSteel_M_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.ColumnName = "N2_SpecialSteel_M_Avg";
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableN2_SpecialSteel_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableO2_M_Avg
            // 
            this.coldsStatL3DataTableO2_M_Avg.Caption = "O2_M_Avg";
            this.coldsStatL3DataTableO2_M_Avg.ColumnName = "O2_M_Avg";
            this.coldsStatL3DataTableO2_M_Avg.DataType = typeof(float);
            this.coldsStatL3DataTableO2_M_Avg.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_D
            // 
            this.coldsStatL3DataTableProduction_D.Caption = "Production_D";
            this.coldsStatL3DataTableProduction_D.ColumnName = "Production_D";
            this.coldsStatL3DataTableProduction_D.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_D.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_M
            // 
            this.coldsStatL3DataTableProduction_M.Caption = "Production_M";
            this.coldsStatL3DataTableProduction_M.ColumnName = "Production_M";
            this.coldsStatL3DataTableProduction_M.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_M.Namespace = "";
            // 
            // coldsStatL3DataTableCreateTime
            // 
            this.coldsStatL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsStatL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsStatL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsStatL3DataTableCreateTime.Namespace = "";
            // 
            // coldsStatL3DataTableOperator
            // 
            this.coldsStatL3DataTableOperator.Caption = "Operator";
            this.coldsStatL3DataTableOperator.ColumnName = "Operator";
            this.coldsStatL3DataTableOperator.Namespace = "";
            // 
            // coldsStatL3DataTableStatus
            // 
            this.coldsStatL3DataTableStatus.Caption = "Status";
            this.coldsStatL3DataTableStatus.ColumnName = "Status";
            this.coldsStatL3DataTableStatus.DataType = typeof(int);
            this.coldsStatL3DataTableStatus.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_Special_D
            // 
            this.coldsStatL3DataTableProduction_Special_D.Caption = "Production_Special_D";
            this.coldsStatL3DataTableProduction_Special_D.ColumnName = "Production_Special_D";
            this.coldsStatL3DataTableProduction_Special_D.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_Special_D.Namespace = "";
            // 
            // coldsStatL3DataTableProduction_Special_M
            // 
            this.coldsStatL3DataTableProduction_Special_M.Caption = "Production_Special_M";
            this.coldsStatL3DataTableProduction_Special_M.ColumnName = "Production_Special_M";
            this.coldsStatL3DataTableProduction_Special_M.DataType = typeof(float);
            this.coldsStatL3DataTableProduction_Special_M.Namespace = "";
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(21, 77);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(668, 10);
            this.myLine1.TabIndex = 6;
            // 
            // txtProduction_Special_M
            // 
            this.txtProduction_Special_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Production_Special_M", true));
            this.txtProduction_Special_M.Location = new System.Drawing.Point(578, 47);
            this.txtProduction_Special_M.Name = "txtProduction_Special_M";
            this.txtProduction_Special_M.ReadOnly = true;
            this.txtProduction_Special_M.Size = new System.Drawing.Size(111, 21);
            this.txtProduction_Special_M.TabIndex = 5;
            // 
            // txtO2_M_Avg
            // 
            this.txtO2_M_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "O2_M_Avg", true));
            this.txtO2_M_Avg.Location = new System.Drawing.Point(578, 243);
            this.txtO2_M_Avg.Name = "txtO2_M_Avg";
            this.txtO2_M_Avg.ReadOnly = true;
            this.txtO2_M_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtO2_M_Avg.TabIndex = 35;
            // 
            // txtO2_M
            // 
            this.txtO2_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "O2_M", true));
            this.txtO2_M.Location = new System.Drawing.Point(461, 243);
            this.txtO2_M.Name = "txtO2_M";
            this.txtO2_M.ReadOnly = true;
            this.txtO2_M.Size = new System.Drawing.Size(111, 21);
            this.txtO2_M.TabIndex = 29;
            // 
            // txtO2_D_Avg
            // 
            this.txtO2_D_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "O2_D_Avg", true));
            this.txtO2_D_Avg.Location = new System.Drawing.Point(344, 243);
            this.txtO2_D_Avg.Name = "txtO2_D_Avg";
            this.txtO2_D_Avg.ReadOnly = true;
            this.txtO2_D_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtO2_D_Avg.TabIndex = 23;
            // 
            // txtO2_D
            // 
            this.txtO2_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "O2_D", true));
            this.txtO2_D.Location = new System.Drawing.Point(227, 243);
            this.txtO2_D.Name = "txtO2_D";
            this.txtO2_D.ReadOnly = true;
            this.txtO2_D.Size = new System.Drawing.Size(111, 21);
            this.txtO2_D.TabIndex = 17;
            // 
            // txtFlow_O2
            // 
            this.txtFlow_O2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Flow_O2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtFlow_O2.Location = new System.Drawing.Point(110, 243);
            this.txtFlow_O2.Name = "txtFlow_O2";
            this.txtFlow_O2.Size = new System.Drawing.Size(111, 21);
            this.txtFlow_O2.TabIndex = 11;
            this.txtFlow_O2.TextChanged += new System.EventHandler(this.txtO2_TextChanged);
            // 
            // txtN2_M_Avg
            // 
            this.txtN2_M_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_M_Avg", true));
            this.txtN2_M_Avg.Location = new System.Drawing.Point(578, 197);
            this.txtN2_M_Avg.Name = "txtN2_M_Avg";
            this.txtN2_M_Avg.ReadOnly = true;
            this.txtN2_M_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtN2_M_Avg.TabIndex = 33;
            // 
            // txtN2_M
            // 
            this.txtN2_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_M", true));
            this.txtN2_M.Location = new System.Drawing.Point(461, 197);
            this.txtN2_M.Name = "txtN2_M";
            this.txtN2_M.ReadOnly = true;
            this.txtN2_M.Size = new System.Drawing.Size(111, 21);
            this.txtN2_M.TabIndex = 27;
            // 
            // txtN2_D_Avg
            // 
            this.txtN2_D_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_D_Avg", true));
            this.txtN2_D_Avg.Location = new System.Drawing.Point(344, 197);
            this.txtN2_D_Avg.Name = "txtN2_D_Avg";
            this.txtN2_D_Avg.ReadOnly = true;
            this.txtN2_D_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtN2_D_Avg.TabIndex = 21;
            // 
            // txtN2_D
            // 
            this.txtN2_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_D", true));
            this.txtN2_D.Location = new System.Drawing.Point(227, 197);
            this.txtN2_D.Name = "txtN2_D";
            this.txtN2_D.ReadOnly = true;
            this.txtN2_D.Size = new System.Drawing.Size(111, 21);
            this.txtN2_D.TabIndex = 15;
            // 
            // txtFlow_N2
            // 
            this.txtFlow_N2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Flow_N2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtFlow_N2.Location = new System.Drawing.Point(110, 197);
            this.txtFlow_N2.Name = "txtFlow_N2";
            this.txtFlow_N2.Size = new System.Drawing.Size(111, 21);
            this.txtFlow_N2.TabIndex = 9;
            this.txtFlow_N2.TextChanged += new System.EventHandler(this.txtFlow_N2_TextChanged);
            // 
            // txtBOFCO_M_Avg
            // 
            this.txtBOFCO_M_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_M_Avg", true));
            this.txtBOFCO_M_Avg.Location = new System.Drawing.Point(578, 151);
            this.txtBOFCO_M_Avg.Name = "txtBOFCO_M_Avg";
            this.txtBOFCO_M_Avg.ReadOnly = true;
            this.txtBOFCO_M_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_M_Avg.TabIndex = 31;
            // 
            // txtBOFCO_M
            // 
            this.txtBOFCO_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_M", true));
            this.txtBOFCO_M.Location = new System.Drawing.Point(461, 151);
            this.txtBOFCO_M.Name = "txtBOFCO_M";
            this.txtBOFCO_M.ReadOnly = true;
            this.txtBOFCO_M.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_M.TabIndex = 25;
            // 
            // txtBOFCO_D_Avg
            // 
            this.txtBOFCO_D_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_D_Avg", true));
            this.txtBOFCO_D_Avg.Location = new System.Drawing.Point(344, 151);
            this.txtBOFCO_D_Avg.Name = "txtBOFCO_D_Avg";
            this.txtBOFCO_D_Avg.ReadOnly = true;
            this.txtBOFCO_D_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_D_Avg.TabIndex = 19;
            // 
            // txtBOFCO_D
            // 
            this.txtBOFCO_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_D", true));
            this.txtBOFCO_D.Location = new System.Drawing.Point(227, 151);
            this.txtBOFCO_D.Name = "txtBOFCO_D";
            this.txtBOFCO_D.ReadOnly = true;
            this.txtBOFCO_D.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_D.TabIndex = 13;
            // 
            // txtFlow_BOFCO
            // 
            this.txtFlow_BOFCO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Flow_BOFCO", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtFlow_BOFCO.Location = new System.Drawing.Point(110, 151);
            this.txtFlow_BOFCO.Name = "txtFlow_BOFCO";
            this.txtFlow_BOFCO.Size = new System.Drawing.Size(111, 21);
            this.txtFlow_BOFCO.TabIndex = 7;
            this.txtFlow_BOFCO.TextChanged += new System.EventHandler(this.txtFlow_BOFCO_TextChanged);
            // 
            // txtProduction_Special_D
            // 
            this.txtProduction_Special_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Production_Special_D", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtProduction_Special_D.Location = new System.Drawing.Point(344, 47);
            this.txtProduction_Special_D.Name = "txtProduction_Special_D";
            this.txtProduction_Special_D.Size = new System.Drawing.Size(111, 21);
            this.txtProduction_Special_D.TabIndex = 3;
            this.txtProduction_Special_D.TextChanged += new System.EventHandler(this.txtProduction_Special_D_TextChanged);
            // 
            // txtProduction_M
            // 
            this.txtProduction_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Production_M", true));
            this.txtProduction_M.Location = new System.Drawing.Point(578, 19);
            this.txtProduction_M.Name = "txtProduction_M";
            this.txtProduction_M.ReadOnly = true;
            this.txtProduction_M.Size = new System.Drawing.Size(111, 21);
            this.txtProduction_M.TabIndex = 4;
            // 
            // txtN2_SpecialSteel_M_Avg
            // 
            this.txtN2_SpecialSteel_M_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_SpecialSteel_M_Avg", true));
            this.txtN2_SpecialSteel_M_Avg.Location = new System.Drawing.Point(578, 220);
            this.txtN2_SpecialSteel_M_Avg.Name = "txtN2_SpecialSteel_M_Avg";
            this.txtN2_SpecialSteel_M_Avg.ReadOnly = true;
            this.txtN2_SpecialSteel_M_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtN2_SpecialSteel_M_Avg.TabIndex = 34;
            // 
            // txtN2_SpecialSteel_M
            // 
            this.txtN2_SpecialSteel_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_SpecialSteel_M", true));
            this.txtN2_SpecialSteel_M.Location = new System.Drawing.Point(461, 220);
            this.txtN2_SpecialSteel_M.Name = "txtN2_SpecialSteel_M";
            this.txtN2_SpecialSteel_M.ReadOnly = true;
            this.txtN2_SpecialSteel_M.Size = new System.Drawing.Size(111, 21);
            this.txtN2_SpecialSteel_M.TabIndex = 28;
            // 
            // txtN2_SpecialSteel_D_Avg
            // 
            this.txtN2_SpecialSteel_D_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_SpecialSteel_D_Avg", true));
            this.txtN2_SpecialSteel_D_Avg.Location = new System.Drawing.Point(344, 220);
            this.txtN2_SpecialSteel_D_Avg.Name = "txtN2_SpecialSteel_D_Avg";
            this.txtN2_SpecialSteel_D_Avg.ReadOnly = true;
            this.txtN2_SpecialSteel_D_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtN2_SpecialSteel_D_Avg.TabIndex = 22;
            // 
            // txtN2_SpecialSteel_D
            // 
            this.txtN2_SpecialSteel_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "N2_SpecialSteel_D", true));
            this.txtN2_SpecialSteel_D.Location = new System.Drawing.Point(227, 220);
            this.txtN2_SpecialSteel_D.Name = "txtN2_SpecialSteel_D";
            this.txtN2_SpecialSteel_D.ReadOnly = true;
            this.txtN2_SpecialSteel_D.Size = new System.Drawing.Size(111, 21);
            this.txtN2_SpecialSteel_D.TabIndex = 16;
            // 
            // txtFlow_N2_SpecialSteel
            // 
            this.txtFlow_N2_SpecialSteel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Flow_N2_SpecialSteel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtFlow_N2_SpecialSteel.Location = new System.Drawing.Point(110, 220);
            this.txtFlow_N2_SpecialSteel.Name = "txtFlow_N2_SpecialSteel";
            this.txtFlow_N2_SpecialSteel.Size = new System.Drawing.Size(111, 21);
            this.txtFlow_N2_SpecialSteel.TabIndex = 10;
            this.txtFlow_N2_SpecialSteel.TextChanged += new System.EventHandler(this.txtFlow_N2_SpecialSteel_TextChanged);
            // 
            // txtBOFCO_CallBack_M_Avg
            // 
            this.txtBOFCO_CallBack_M_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_CallBack_M_Avg", true));
            this.txtBOFCO_CallBack_M_Avg.Location = new System.Drawing.Point(578, 174);
            this.txtBOFCO_CallBack_M_Avg.Name = "txtBOFCO_CallBack_M_Avg";
            this.txtBOFCO_CallBack_M_Avg.ReadOnly = true;
            this.txtBOFCO_CallBack_M_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_CallBack_M_Avg.TabIndex = 32;
            // 
            // txtBOFCO_CallBack_M
            // 
            this.txtBOFCO_CallBack_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_CallBack_M", true));
            this.txtBOFCO_CallBack_M.Location = new System.Drawing.Point(461, 174);
            this.txtBOFCO_CallBack_M.Name = "txtBOFCO_CallBack_M";
            this.txtBOFCO_CallBack_M.ReadOnly = true;
            this.txtBOFCO_CallBack_M.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_CallBack_M.TabIndex = 26;
            // 
            // txtBOFCO_CallBack_D_Avg
            // 
            this.txtBOFCO_CallBack_D_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_CallBack_D_Avg", true));
            this.txtBOFCO_CallBack_D_Avg.Location = new System.Drawing.Point(344, 174);
            this.txtBOFCO_CallBack_D_Avg.Name = "txtBOFCO_CallBack_D_Avg";
            this.txtBOFCO_CallBack_D_Avg.ReadOnly = true;
            this.txtBOFCO_CallBack_D_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_CallBack_D_Avg.TabIndex = 20;
            // 
            // txtBOFCO_CallBack_D
            // 
            this.txtBOFCO_CallBack_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "BOFCO_CallBack_D", true));
            this.txtBOFCO_CallBack_D.Location = new System.Drawing.Point(227, 174);
            this.txtBOFCO_CallBack_D.Name = "txtBOFCO_CallBack_D";
            this.txtBOFCO_CallBack_D.ReadOnly = true;
            this.txtBOFCO_CallBack_D.Size = new System.Drawing.Size(111, 21);
            this.txtBOFCO_CallBack_D.TabIndex = 14;
            // 
            // txtFlow_BOFCO_CallBack
            // 
            this.txtFlow_BOFCO_CallBack.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Flow_BOFCO_CallBack", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtFlow_BOFCO_CallBack.Location = new System.Drawing.Point(110, 174);
            this.txtFlow_BOFCO_CallBack.Name = "txtFlow_BOFCO_CallBack";
            this.txtFlow_BOFCO_CallBack.Size = new System.Drawing.Size(111, 21);
            this.txtFlow_BOFCO_CallBack.TabIndex = 8;
            this.txtFlow_BOFCO_CallBack.TextChanged += new System.EventHandler(this.txtFlow_BOFCO_CallBack_TextChanged);
            // 
            // txtCFCO_M_Avg
            // 
            this.txtCFCO_M_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "CFCO_M_Avg", true));
            this.txtCFCO_M_Avg.Location = new System.Drawing.Point(578, 128);
            this.txtCFCO_M_Avg.Name = "txtCFCO_M_Avg";
            this.txtCFCO_M_Avg.ReadOnly = true;
            this.txtCFCO_M_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtCFCO_M_Avg.TabIndex = 30;
            // 
            // txtCFCO_M
            // 
            this.txtCFCO_M.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "CFCO_M", true));
            this.txtCFCO_M.Location = new System.Drawing.Point(461, 128);
            this.txtCFCO_M.Name = "txtCFCO_M";
            this.txtCFCO_M.ReadOnly = true;
            this.txtCFCO_M.Size = new System.Drawing.Size(111, 21);
            this.txtCFCO_M.TabIndex = 24;
            // 
            // txtCFCO_D_Avg
            // 
            this.txtCFCO_D_Avg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "CFCO_D_Avg", true));
            this.txtCFCO_D_Avg.Location = new System.Drawing.Point(344, 128);
            this.txtCFCO_D_Avg.Name = "txtCFCO_D_Avg";
            this.txtCFCO_D_Avg.ReadOnly = true;
            this.txtCFCO_D_Avg.Size = new System.Drawing.Size(111, 21);
            this.txtCFCO_D_Avg.TabIndex = 18;
            // 
            // txtCFCO_D
            // 
            this.txtCFCO_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "CFCO_D", true));
            this.txtCFCO_D.Location = new System.Drawing.Point(227, 128);
            this.txtCFCO_D.Name = "txtCFCO_D";
            this.txtCFCO_D.ReadOnly = true;
            this.txtCFCO_D.Size = new System.Drawing.Size(111, 21);
            this.txtCFCO_D.TabIndex = 12;
            // 
            // txtFlow_CFCO
            // 
            this.txtFlow_CFCO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Flow_CFCO", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtFlow_CFCO.Location = new System.Drawing.Point(110, 128);
            this.txtFlow_CFCO.Name = "txtFlow_CFCO";
            this.txtFlow_CFCO.Size = new System.Drawing.Size(111, 21);
            this.txtFlow_CFCO.TabIndex = 6;
            this.txtFlow_CFCO.TextChanged += new System.EventHandler(this.txtFlow_CFCO_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Operator", true));
            this.textBox1.Location = new System.Drawing.Point(111, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 21);
            this.textBox1.TabIndex = 1;
            // 
            // txtProduction_D
            // 
            this.txtProduction_D.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStat, "Production_D", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtProduction_D.Location = new System.Drawing.Point(344, 19);
            this.txtProduction_D.Name = "txtProduction_D";
            this.txtProduction_D.Size = new System.Drawing.Size(111, 21);
            this.txtProduction_D.TabIndex = 2;
            this.txtProduction_D.TextChanged += new System.EventHandler(this.txtProduction_D_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(459, 51);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 12);
            this.label19.TabIndex = 4;
            this.label19.Text = "精品钢累计产量[t]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "操 作 员:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(237, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 12);
            this.label17.TabIndex = 4;
            this.label17.Text = "精品钢日产量[t]:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(495, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "累计产量[t]:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "日产量[t]:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "氧气:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "精品钢氮气:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "氮气:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "转炉煤气回收:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "转炉煤气:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "焦炉煤气:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(589, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "累计单耗[m3/t]";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(472, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 35);
            this.label16.TabIndex = 4;
            this.label16.Text = "累计消耗(回收)量[m3/t]";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(361, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 35);
            this.label15.TabIndex = 4;
            this.label15.Text = "日单耗[m3/t]";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(241, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 35);
            this.label14.TabIndex = 4;
            this.label14.Text = "日消耗(回收)量[m3]";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(120, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 35);
            this.label13.TabIndex = 4;
            this.label13.Text = "平均瞬时流量[m3/h]";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dsLastData
            // 
            this.dsLastData.AutoLoad = true;
            this.dsLastData.AutoSubscribe = false;
            this.dsLastData.DataSetName = "L3DataSet";
            this.dsLastData.DeleteMethod = "";
            this.dsLastData.InsertMethod = "";
            this.dsLastData.L3DataAdapter = this.Adapter;
            this.dsLastData.LoadEvent = "";
            this.dsLastData.LoadTrigger = null;
            this.dsLastData.RefreshValve = 1000;
            this.dsLastData.SourceCommand = null;
            this.dsLastData.SourceCondition = "";
            this.dsLastData.SourceMethod = "";
            this.dsLastData.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsLastData.SourceURI = "";
            this.dsLastData.SubscribeTarget = "";
            this.dsLastData.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLastData});
            this.dsLastData.UpdateEvent = "";
            this.dsLastData.UpdateMethod = "";
            this.dsLastData.UpdateTrigger = null;
            this.dsLastData.OnDataLoaded += new AppSvrHMI.Delegate_OnDataLoaded(this.dsLastData_OnDataLoaded);
            // 
            // schemadsLastData
            // 
            this.schemadsLastData.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLastDataL3DataTableProductionDate,
            this.coldsLastDataL3DataTableCFCO_M,
            this.coldsLastDataL3DataTableBOFCO_M,
            this.coldsLastDataL3DataTableBOFCO_CallBack_M,
            this.coldsLastDataL3DataTableN2_M,
            this.coldsLastDataL3DataTableN2_SpecialSteel_M,
            this.coldsLastDataL3DataTableO2_M,
            this.coldsLastDataL3DataTableProduction_M,
            this.coldsLastDataL3DataTableProduction_Special_M});
            this.schemadsLastData.TableName = "L3DataTable";
            // 
            // coldsLastDataL3DataTableProductionDate
            // 
            this.coldsLastDataL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsLastDataL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsLastDataL3DataTableProductionDate.Namespace = "";
            // 
            // coldsLastDataL3DataTableCFCO_M
            // 
            this.coldsLastDataL3DataTableCFCO_M.Caption = "CFCO_M";
            this.coldsLastDataL3DataTableCFCO_M.ColumnName = "CFCO_M";
            this.coldsLastDataL3DataTableCFCO_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableCFCO_M.Namespace = "";
            // 
            // coldsLastDataL3DataTableBOFCO_M
            // 
            this.coldsLastDataL3DataTableBOFCO_M.Caption = "BOFCO_M";
            this.coldsLastDataL3DataTableBOFCO_M.ColumnName = "BOFCO_M";
            this.coldsLastDataL3DataTableBOFCO_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableBOFCO_M.Namespace = "";
            // 
            // coldsLastDataL3DataTableBOFCO_CallBack_M
            // 
            this.coldsLastDataL3DataTableBOFCO_CallBack_M.Caption = "BOFCO_CallBack_M";
            this.coldsLastDataL3DataTableBOFCO_CallBack_M.ColumnName = "BOFCO_CallBack_M";
            this.coldsLastDataL3DataTableBOFCO_CallBack_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableBOFCO_CallBack_M.Namespace = "";
            // 
            // coldsLastDataL3DataTableN2_M
            // 
            this.coldsLastDataL3DataTableN2_M.Caption = "N2_M";
            this.coldsLastDataL3DataTableN2_M.ColumnName = "N2_M";
            this.coldsLastDataL3DataTableN2_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableN2_M.Namespace = "";
            // 
            // coldsLastDataL3DataTableN2_SpecialSteel_M
            // 
            this.coldsLastDataL3DataTableN2_SpecialSteel_M.Caption = "N2_SpecialSteel_M";
            this.coldsLastDataL3DataTableN2_SpecialSteel_M.ColumnName = "N2_SpecialSteel_M";
            this.coldsLastDataL3DataTableN2_SpecialSteel_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableN2_SpecialSteel_M.Namespace = "";
            // 
            // coldsLastDataL3DataTableO2_M
            // 
            this.coldsLastDataL3DataTableO2_M.Caption = "O2_M";
            this.coldsLastDataL3DataTableO2_M.ColumnName = "O2_M";
            this.coldsLastDataL3DataTableO2_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableO2_M.Namespace = "";
            // 
            // coldsLastDataL3DataTableProduction_M
            // 
            this.coldsLastDataL3DataTableProduction_M.Caption = "Production_M";
            this.coldsLastDataL3DataTableProduction_M.ColumnName = "Production_M";
            this.coldsLastDataL3DataTableProduction_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableProduction_M.Namespace = "";
            // 
            // coldsLastDataL3DataTableProduction_Special_M
            // 
            this.coldsLastDataL3DataTableProduction_Special_M.Caption = "Production_Special_M";
            this.coldsLastDataL3DataTableProduction_Special_M.ColumnName = "Production_Special_M";
            this.coldsLastDataL3DataTableProduction_Special_M.DataType = typeof(float);
            this.coldsLastDataL3DataTableProduction_Special_M.Namespace = "";
            // 
            // EnergyStatShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 377);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EnergyStatShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "能源数据操作";
            this.Load += new System.EventHandler(this.EnergyStatShowFrm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLastData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLastData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AppSvrHMI.L3DataSet dsStat;
        private System.Data.DataTable schemadsStat;
        private System.Data.DataColumn coldsStatL3DataTableGUID;
        private System.Data.DataColumn coldsStatL3DataTableName;
        private System.Data.DataColumn coldsStatL3DataTableProductionDate;
        private System.Data.DataColumn coldsStatL3DataTableFlow_CFCO;
        private System.Data.DataColumn coldsStatL3DataTableFlow_BOFCO;
        private System.Data.DataColumn coldsStatL3DataTableFlow_BOFCO_CallBack;
        private System.Data.DataColumn coldsStatL3DataTableFlow_N2;
        private System.Data.DataColumn coldsStatL3DataTableFlow_N2_SpecialSteel;
        private System.Data.DataColumn coldsStatL3DataTableFlow_O2;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_D;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_D;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_D;
        private System.Data.DataColumn coldsStatL3DataTableN2_D;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_D;
        private System.Data.DataColumn coldsStatL3DataTableO2_D;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableO2_D_Avg;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_M;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_M;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_M;
        private System.Data.DataColumn coldsStatL3DataTableN2_M;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_M;
        private System.Data.DataColumn coldsStatL3DataTableO2_M;
        private System.Data.DataColumn coldsStatL3DataTableCFCO_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableBOFCO_CallBack_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableN2_SpecialSteel_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableO2_M_Avg;
        private System.Data.DataColumn coldsStatL3DataTableProduction_D;
        private System.Data.DataColumn coldsStatL3DataTableProduction_M;
        private System.Data.DataColumn coldsStatL3DataTableCreateTime;
        private System.Data.DataColumn coldsStatL3DataTableOperator;
        private System.Data.DataColumn coldsStatL3DataTableStatus;
        private System.Windows.Forms.BindingSource bsStat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtProduction_Special_M;
        private System.Windows.Forms.TextBox txtFlow_O2;
        private System.Windows.Forms.TextBox txtFlow_N2;
        private System.Windows.Forms.TextBox txtFlow_BOFCO;
        private System.Windows.Forms.TextBox txtProduction_Special_D;
        private System.Windows.Forms.TextBox txtProduction_M;
        private System.Windows.Forms.TextBox txtFlow_N2_SpecialSteel;
        private System.Windows.Forms.TextBox txtFlow_BOFCO_CallBack;
        private System.Windows.Forms.TextBox txtFlow_CFCO;
        private System.Windows.Forms.TextBox txtProduction_D;
        private System.Data.DataColumn coldsStatL3DataTableProduction_Special_D;
        private System.Data.DataColumn coldsStatL3DataTableProduction_Special_M;
        private System.Windows.Forms.TextBox txtO2_M;
        private System.Windows.Forms.TextBox txtO2_D_Avg;
        private System.Windows.Forms.TextBox txtO2_D;
        private System.Windows.Forms.TextBox txtN2_M;
        private System.Windows.Forms.TextBox txtN2_D_Avg;
        private System.Windows.Forms.TextBox txtN2_D;
        private System.Windows.Forms.TextBox txtBOFCO_M;
        private System.Windows.Forms.TextBox txtBOFCO_D_Avg;
        private System.Windows.Forms.TextBox txtBOFCO_D;
        private System.Windows.Forms.TextBox txtN2_SpecialSteel_M;
        private System.Windows.Forms.TextBox txtN2_SpecialSteel_D_Avg;
        private System.Windows.Forms.TextBox txtN2_SpecialSteel_D;
        private System.Windows.Forms.TextBox txtBOFCO_CallBack_M;
        private System.Windows.Forms.TextBox txtBOFCO_CallBack_D_Avg;
        private System.Windows.Forms.TextBox txtBOFCO_CallBack_D;
        private System.Windows.Forms.TextBox txtCFCO_M;
        private System.Windows.Forms.TextBox txtCFCO_D_Avg;
        private System.Windows.Forms.TextBox txtCFCO_D;
        private buttonHide.MyLine myLine1;
        private AppSvrHMI.L3DataSet dsLastData;
        private System.Data.DataTable schemadsLastData;
        private System.Data.DataColumn coldsLastDataL3DataTableProductionDate;
        private System.Data.DataColumn coldsLastDataL3DataTableCFCO_M;
        private System.Data.DataColumn coldsLastDataL3DataTableBOFCO_M;
        private System.Data.DataColumn coldsLastDataL3DataTableBOFCO_CallBack_M;
        private System.Data.DataColumn coldsLastDataL3DataTableN2_M;
        private System.Data.DataColumn coldsLastDataL3DataTableN2_SpecialSteel_M;
        private System.Data.DataColumn coldsLastDataL3DataTableO2_M;
        private System.Data.DataColumn coldsLastDataL3DataTableProduction_M;
        private System.Data.DataColumn coldsLastDataL3DataTableProduction_Special_M;
        private System.Windows.Forms.TextBox txtO2_M_Avg;
        private System.Windows.Forms.TextBox txtN2_M_Avg;
        private System.Windows.Forms.TextBox txtBOFCO_M_Avg;
        private System.Windows.Forms.TextBox txtN2_SpecialSteel_M_Avg;
        private System.Windows.Forms.TextBox txtBOFCO_CallBack_M_Avg;
        private System.Windows.Forms.TextBox txtCFCO_M_Avg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtProductionDate;
    }
}