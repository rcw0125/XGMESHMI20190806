namespace UnitMag.BFMag
{
    partial class PathInfoFrm
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
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsMainL3DataTableBFID = new System.Data.DataColumn();
            this.coldsMainL3DataTableTAP_No = new System.Data.DataColumn();
            this.coldsMainL3DataTableTPC_No = new System.Data.DataColumn();
            this.coldsMainL3DataTableSource = new System.Data.DataColumn();
            this.coldsMainL3DataTableDestination = new System.Data.DataColumn();
            this.coldsMainL3DataTableProduction_Date = new System.Data.DataColumn();
            this.coldsMainL3DataTableShift = new System.Data.DataColumn();
            this.coldsMainL3DataTableOperator = new System.Data.DataColumn();
            this.coldsMainL3DataTableSendFlag = new System.Data.DataColumn();
            this.coldsMainL3DataTableTeam = new System.Data.DataColumn();
            this.coldsMainL3DataTableResult = new System.Data.DataColumn();
            this.coldsMainL3DataTableSample_Place = new System.Data.DataColumn();
            this.coldsMainL3DataTableC = new System.Data.DataColumn();
            this.coldsMainL3DataTableSi = new System.Data.DataColumn();
            this.coldsMainL3DataTableMn = new System.Data.DataColumn();
            this.coldsMainL3DataTableS = new System.Data.DataColumn();
            this.coldsMainL3DataTableP = new System.Data.DataColumn();
            this.coldsMainL3DataTableTi = new System.Data.DataColumn();
            this.coldsMainL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableLast_Tare = new System.Data.DataColumn();
            this.coldsMainL3DataTableCurr_Tare = new System.Data.DataColumn();
            this.coldsMainL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableSpare_Weight = new System.Data.DataColumn();
            this.coldsMainL3DataTableIronStatus = new System.Data.DataColumn();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTAPNo = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtBFID = new PxDataValid.PxTextBox();
            this.txtTPCNo = new PxDataValid.PxTextBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.dsPath = new AppSvrHMI.L3DataSet();
            this.schemadsPath = new System.Data.DataTable();
            this.coldsPathL3DataTableCode = new System.Data.DataColumn();
            this.coldsPathL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsPathL3DataTableCode_Group = new System.Data.DataColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPath)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = null;
            this.dsMain.InsertMethod = null;
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "Click";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = null;
            this.dsMain.SourceCondition = null;
            this.dsMain.SourceMethod = "";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMain.SourceURI = "MES\\MaterialData\\CBFIron";
            this.dsMain.SubscribeTarget = null;
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "Click";
            this.dsMain.UpdateMethod = null;
            this.dsMain.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableMaterialID,
            this.coldsMainL3DataTableBFID,
            this.coldsMainL3DataTableTAP_No,
            this.coldsMainL3DataTableTPC_No,
            this.coldsMainL3DataTableSource,
            this.coldsMainL3DataTableDestination,
            this.coldsMainL3DataTableProduction_Date,
            this.coldsMainL3DataTableShift,
            this.coldsMainL3DataTableOperator,
            this.coldsMainL3DataTableSendFlag,
            this.coldsMainL3DataTableTeam,
            this.coldsMainL3DataTableResult,
            this.coldsMainL3DataTableSample_Place,
            this.coldsMainL3DataTableC,
            this.coldsMainL3DataTableSi,
            this.coldsMainL3DataTableMn,
            this.coldsMainL3DataTableS,
            this.coldsMainL3DataTableP,
            this.coldsMainL3DataTableTi,
            this.coldsMainL3DataTableGross_Weight,
            this.coldsMainL3DataTableLast_Tare,
            this.coldsMainL3DataTableCurr_Tare,
            this.coldsMainL3DataTableNet_Weight,
            this.coldsMainL3DataTableSpare_Weight,
            this.coldsMainL3DataTableIronStatus});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableMaterialID
            // 
            this.coldsMainL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsMainL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsMainL3DataTableMaterialID.Namespace = "";
            // 
            // coldsMainL3DataTableBFID
            // 
            this.coldsMainL3DataTableBFID.Caption = "BFID";
            this.coldsMainL3DataTableBFID.ColumnName = "BFID";
            this.coldsMainL3DataTableBFID.Namespace = "";
            // 
            // coldsMainL3DataTableTAP_No
            // 
            this.coldsMainL3DataTableTAP_No.Caption = "TAP_No";
            this.coldsMainL3DataTableTAP_No.ColumnName = "TAP_No";
            this.coldsMainL3DataTableTAP_No.Namespace = "";
            // 
            // coldsMainL3DataTableTPC_No
            // 
            this.coldsMainL3DataTableTPC_No.Caption = "TPC_No";
            this.coldsMainL3DataTableTPC_No.ColumnName = "TPC_No";
            this.coldsMainL3DataTableTPC_No.Namespace = "";
            // 
            // coldsMainL3DataTableSource
            // 
            this.coldsMainL3DataTableSource.Caption = "Source";
            this.coldsMainL3DataTableSource.ColumnName = "Source";
            this.coldsMainL3DataTableSource.DataType = typeof(int);
            this.coldsMainL3DataTableSource.Namespace = "";
            // 
            // coldsMainL3DataTableDestination
            // 
            this.coldsMainL3DataTableDestination.Caption = "Destination";
            this.coldsMainL3DataTableDestination.ColumnName = "Destination";
            this.coldsMainL3DataTableDestination.DataType = typeof(int);
            this.coldsMainL3DataTableDestination.Namespace = "";
            // 
            // coldsMainL3DataTableProduction_Date
            // 
            this.coldsMainL3DataTableProduction_Date.Caption = "Production_Date";
            this.coldsMainL3DataTableProduction_Date.ColumnName = "Production_Date";
            this.coldsMainL3DataTableProduction_Date.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableProduction_Date.Namespace = "";
            // 
            // coldsMainL3DataTableShift
            // 
            this.coldsMainL3DataTableShift.Caption = "Shift";
            this.coldsMainL3DataTableShift.ColumnName = "Shift";
            this.coldsMainL3DataTableShift.DataType = typeof(int);
            this.coldsMainL3DataTableShift.Namespace = "";
            // 
            // coldsMainL3DataTableOperator
            // 
            this.coldsMainL3DataTableOperator.Caption = "Operator";
            this.coldsMainL3DataTableOperator.ColumnName = "Operator";
            this.coldsMainL3DataTableOperator.Namespace = "";
            // 
            // coldsMainL3DataTableSendFlag
            // 
            this.coldsMainL3DataTableSendFlag.Caption = "SendFlag";
            this.coldsMainL3DataTableSendFlag.ColumnName = "SendFlag";
            this.coldsMainL3DataTableSendFlag.DataType = typeof(int);
            this.coldsMainL3DataTableSendFlag.Namespace = "";
            // 
            // coldsMainL3DataTableTeam
            // 
            this.coldsMainL3DataTableTeam.Caption = "Team";
            this.coldsMainL3DataTableTeam.ColumnName = "Team";
            this.coldsMainL3DataTableTeam.DataType = typeof(int);
            this.coldsMainL3DataTableTeam.Namespace = "";
            // 
            // coldsMainL3DataTableResult
            // 
            this.coldsMainL3DataTableResult.Caption = "Result";
            this.coldsMainL3DataTableResult.ColumnName = "Result";
            this.coldsMainL3DataTableResult.DataType = typeof(int);
            this.coldsMainL3DataTableResult.Namespace = "";
            // 
            // coldsMainL3DataTableSample_Place
            // 
            this.coldsMainL3DataTableSample_Place.Caption = "Sample_Place";
            this.coldsMainL3DataTableSample_Place.ColumnName = "Sample_Place";
            this.coldsMainL3DataTableSample_Place.Namespace = "";
            // 
            // coldsMainL3DataTableC
            // 
            this.coldsMainL3DataTableC.Caption = "C";
            this.coldsMainL3DataTableC.ColumnName = "C";
            this.coldsMainL3DataTableC.DataType = typeof(float);
            this.coldsMainL3DataTableC.Namespace = "";
            // 
            // coldsMainL3DataTableSi
            // 
            this.coldsMainL3DataTableSi.Caption = "Si";
            this.coldsMainL3DataTableSi.ColumnName = "Si";
            this.coldsMainL3DataTableSi.DataType = typeof(float);
            this.coldsMainL3DataTableSi.Namespace = "";
            // 
            // coldsMainL3DataTableMn
            // 
            this.coldsMainL3DataTableMn.Caption = "Mn";
            this.coldsMainL3DataTableMn.ColumnName = "Mn";
            this.coldsMainL3DataTableMn.DataType = typeof(float);
            this.coldsMainL3DataTableMn.Namespace = "";
            // 
            // coldsMainL3DataTableS
            // 
            this.coldsMainL3DataTableS.Caption = "S";
            this.coldsMainL3DataTableS.ColumnName = "S";
            this.coldsMainL3DataTableS.DataType = typeof(float);
            this.coldsMainL3DataTableS.Namespace = "";
            // 
            // coldsMainL3DataTableP
            // 
            this.coldsMainL3DataTableP.Caption = "P";
            this.coldsMainL3DataTableP.ColumnName = "P";
            this.coldsMainL3DataTableP.DataType = typeof(float);
            this.coldsMainL3DataTableP.Namespace = "";
            // 
            // coldsMainL3DataTableTi
            // 
            this.coldsMainL3DataTableTi.Caption = "Ti";
            this.coldsMainL3DataTableTi.ColumnName = "Ti";
            this.coldsMainL3DataTableTi.DataType = typeof(float);
            this.coldsMainL3DataTableTi.Namespace = "";
            // 
            // coldsMainL3DataTableGross_Weight
            // 
            this.coldsMainL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsMainL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsMainL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsMainL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableLast_Tare
            // 
            this.coldsMainL3DataTableLast_Tare.Caption = "Last_Tare";
            this.coldsMainL3DataTableLast_Tare.ColumnName = "Last_Tare";
            this.coldsMainL3DataTableLast_Tare.DataType = typeof(float);
            this.coldsMainL3DataTableLast_Tare.Namespace = "";
            // 
            // coldsMainL3DataTableCurr_Tare
            // 
            this.coldsMainL3DataTableCurr_Tare.Caption = "Curr_Tare";
            this.coldsMainL3DataTableCurr_Tare.ColumnName = "Curr_Tare";
            this.coldsMainL3DataTableCurr_Tare.DataType = typeof(float);
            this.coldsMainL3DataTableCurr_Tare.Namespace = "";
            // 
            // coldsMainL3DataTableNet_Weight
            // 
            this.coldsMainL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsMainL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsMainL3DataTableNet_Weight.DataType = typeof(float);
            this.coldsMainL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableSpare_Weight
            // 
            this.coldsMainL3DataTableSpare_Weight.Caption = "Spare_Weight";
            this.coldsMainL3DataTableSpare_Weight.ColumnName = "Spare_Weight";
            this.coldsMainL3DataTableSpare_Weight.DataType = typeof(double);
            this.coldsMainL3DataTableSpare_Weight.Namespace = "";
            // 
            // coldsMainL3DataTableIronStatus
            // 
            this.coldsMainL3DataTableIronStatus.Caption = "IronStatus";
            this.coldsMainL3DataTableIronStatus.ColumnName = "IronStatus";
            this.coldsMainL3DataTableIronStatus.DataType = typeof(int);
            this.coldsMainL3DataTableIronStatus.Namespace = "";
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
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(219, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(138, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
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
            this.tabControl1.Size = new System.Drawing.Size(306, 168);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtTAPNo);
            this.tabPage1.Controls.Add(this.txtBFID);
            this.tabPage1.Controls.Add(this.txtTPCNo);
            this.tabPage1.Controls.Add(this.cmbDestination);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 143);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "铁水信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTAPNo
            // 
            this.txtTAPNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TAP_No", true));
            this.txtTAPNo.EnableNull = false;
            this.txtTAPNo.ErropPr = this.errorProvider1;
            this.txtTAPNo.Length = 0;
            this.txtTAPNo.Location = new System.Drawing.Point(86, 13);
            this.txtTAPNo.Max = 0;
            this.txtTAPNo.MaxStrLength = 0;
            this.txtTAPNo.Min = -0.99;
            this.txtTAPNo.MinStrLength = 0;
            this.txtTAPNo.Name = "txtTAPNo";
            this.txtTAPNo.Precision = 0;
            this.txtTAPNo.ReadOnly = true;
            this.txtTAPNo.Size = new System.Drawing.Size(192, 21);
            this.txtTAPNo.TabIndex = 0;
            this.txtTAPNo.ToolTipValid = this.toolTip1;
            this.txtTAPNo.ValidEable = true;
            this.txtTAPNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBFID
            // 
            this.txtBFID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "BFID", true));
            this.txtBFID.EnableNull = false;
            this.txtBFID.ErropPr = this.errorProvider1;
            this.txtBFID.Length = 0;
            this.txtBFID.Location = new System.Drawing.Point(86, 76);
            this.txtBFID.Max = 0;
            this.txtBFID.MaxStrLength = 0;
            this.txtBFID.Min = -0.99;
            this.txtBFID.MinStrLength = 0;
            this.txtBFID.Name = "txtBFID";
            this.txtBFID.Precision = 0;
            this.txtBFID.ReadOnly = true;
            this.txtBFID.Size = new System.Drawing.Size(192, 21);
            this.txtBFID.TabIndex = 2;
            this.txtBFID.ToolTipValid = this.toolTip1;
            this.txtBFID.ValidEable = true;
            this.txtBFID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtTPCNo
            // 
            this.txtTPCNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "TPC_No", true));
            this.txtTPCNo.EnableNull = false;
            this.txtTPCNo.ErropPr = null;
            this.txtTPCNo.Length = 0;
            this.txtTPCNo.Location = new System.Drawing.Point(86, 45);
            this.txtTPCNo.Max = 0;
            this.txtTPCNo.MaxStrLength = 0;
            this.txtTPCNo.Min = -0.99;
            this.txtTPCNo.MinStrLength = 0;
            this.txtTPCNo.Name = "txtTPCNo";
            this.txtTPCNo.Precision = 0;
            this.txtTPCNo.ReadOnly = true;
            this.txtTPCNo.Size = new System.Drawing.Size(192, 21);
            this.txtTPCNo.TabIndex = 1;
            this.txtTPCNo.ToolTipValid = this.toolTip1;
            this.txtTPCNo.ValidEable = true;
            this.txtTPCNo.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // cmbDestination
            // 
            this.cmbDestination.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsMain, "Destination", true));
            this.cmbDestination.DataSource = this.dsPath;
            this.cmbDestination.DisplayMember = "L3DataTable.Code_Des";
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(86, 106);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(192, 20);
            this.cmbDestination.TabIndex = 3;
            this.cmbDestination.ValueMember = "L3DataTable.Code";
            // 
            // dsPath
            // 
            this.dsPath.DataSetName = "L3DataSet";
            this.dsPath.DeleteMethod = null;
            this.dsPath.InsertMethod = null;
            this.dsPath.L3DataAdapter = this.Adapter;
            this.dsPath.LoadEvent = "Click";
            this.dsPath.LoadTrigger = null;
            this.dsPath.RefreshValve = 1000;
            this.dsPath.SourceCommand = null;
            this.dsPath.SourceCondition = "Code_Group = \'IRON_PATH\'";
            this.dsPath.SourceMethod = "";
            this.dsPath.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPath.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPath.SubscribeTarget = null;
            this.dsPath.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPath});
            this.dsPath.UpdateEvent = "Click";
            this.dsPath.UpdateMethod = null;
            this.dsPath.UpdateTrigger = null;
            // 
            // schemadsPath
            // 
            this.schemadsPath.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPathL3DataTableCode,
            this.coldsPathL3DataTableCode_Des,
            this.coldsPathL3DataTableCode_Group});
            this.schemadsPath.TableName = "L3DataTable";
            // 
            // coldsPathL3DataTableCode
            // 
            this.coldsPathL3DataTableCode.Caption = "Code";
            this.coldsPathL3DataTableCode.ColumnName = "Code";
            this.coldsPathL3DataTableCode.Namespace = "";
            // 
            // coldsPathL3DataTableCode_Des
            // 
            this.coldsPathL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsPathL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsPathL3DataTableCode_Des.Namespace = "";
            // 
            // coldsPathL3DataTableCode_Group
            // 
            this.coldsPathL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsPathL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsPathL3DataTableCode_Group.Namespace = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "去向:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "高炉炉号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "罐号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "铁次:";
            // 
            // PathInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 213);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PathInfoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "去向确定";
            this.Load += new System.EventHandler(this.PathInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsMain;
        private AppSvrHMI.L3DataSet dsMain;
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtTAPNo;
        private PxDataValid.PxTextBox txtTPCNo;
        private PxDataValid.PxTextBox txtBFID;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableMaterialID;
        private System.Data.DataColumn coldsMainL3DataTableBFID;
        private System.Data.DataColumn coldsMainL3DataTableTAP_No;
        private System.Data.DataColumn coldsMainL3DataTableTPC_No;
        private System.Data.DataColumn coldsMainL3DataTableSource;
        private System.Data.DataColumn coldsMainL3DataTableDestination;
        private System.Data.DataColumn coldsMainL3DataTableProduction_Date;
        private System.Data.DataColumn coldsMainL3DataTableShift;
        private System.Data.DataColumn coldsMainL3DataTableOperator;
        private System.Data.DataColumn coldsMainL3DataTableSendFlag;
        private System.Data.DataColumn coldsMainL3DataTableTeam;
        private System.Data.DataColumn coldsMainL3DataTableResult;
        private System.Data.DataColumn coldsMainL3DataTableSample_Place;
        private System.Data.DataColumn coldsMainL3DataTableC;
        private System.Data.DataColumn coldsMainL3DataTableSi;
        private System.Data.DataColumn coldsMainL3DataTableMn;
        private System.Data.DataColumn coldsMainL3DataTableS;
        private System.Data.DataColumn coldsMainL3DataTableP;
        private System.Data.DataColumn coldsMainL3DataTableTi;
        private System.Data.DataColumn coldsMainL3DataTableGross_Weight;
        private System.Data.DataColumn coldsMainL3DataTableLast_Tare;
        private System.Data.DataColumn coldsMainL3DataTableCurr_Tare;
        private System.Data.DataColumn coldsMainL3DataTableNet_Weight;
        private System.Data.DataColumn coldsMainL3DataTableSpare_Weight;
        private System.Data.DataColumn coldsMainL3DataTableIronStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3DataSet dsPath;
        private System.Data.DataTable schemadsPath;
        private System.Data.DataColumn coldsPathL3DataTableCode;
        private System.Data.DataColumn coldsPathL3DataTableCode_Des;
        private System.Data.DataColumn coldsPathL3DataTableCode_Group;
    }
}