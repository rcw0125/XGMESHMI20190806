namespace EquipMag.VacTubeMag
{
    partial class VacTubeOnPositionFrm
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
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dsPosition = new AppSvrHMI.L3DataSet();
            this.schemadsPosition = new System.Data.DataTable();
            this.coldsPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPosition = new PxDataValid.PxComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVacTubeName = new PxDataValid.PxComboBox();
            this.cmbVacTubeID = new PxDataValid.PxComboBox();
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.bsTop = new System.Windows.Forms.BindingSource(this.components);
            this.bsLow = new System.Windows.Forms.BindingSource(this.components);
            this.bsHot = new System.Windows.Forms.BindingSource(this.components);
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableVacTube_Name = new System.Data.DataColumn();
            this.coldsBaseL3DataTableVacTube_Id = new System.Data.DataColumn();
            this.dsOnPosition = new AppSvrHMI.L3DataSet();
            this.schemadsOnPosition = new System.Data.DataTable();
            this.coldsOnPositionL3DataTableGUID = new System.Data.DataColumn();
            this.coldsOnPositionL3DataTableName = new System.Data.DataColumn();
            this.coldsOnPositionL3DataTableVacTube_Name = new System.Data.DataColumn();
            this.coldsOnPositionL3DataTableVacTube_Id = new System.Data.DataColumn();
            this.coldsOnPositionL3DataTableState = new System.Data.DataColumn();
            this.coldsOnPositionL3DataTableRefra_Fac = new System.Data.DataColumn();
            this.coldsOnPositionL3DataTablePosition = new System.Data.DataColumn();
            this.bsOnPosition = new System.Windows.Forms.BindingSource(this.components);
            this.dsName = new AppSvrHMI.L3DataSet();
            this.schemadsName = new System.Data.DataTable();
            this.coldsNameL3DataTableCode = new System.Data.DataColumn();
            this.coldsNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmdOnPosition = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOn = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOnPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOnPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOnPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).BeginInit();
            this.SuspendLayout();
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
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(203, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 49;
            this.btnConfirm.Text = "上位";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dsPosition
            // 
            this.dsPosition.DataSetName = "L3DataSet";
            this.dsPosition.DeleteMethod = null;
            this.dsPosition.InsertMethod = null;
            this.dsPosition.L3DataAdapter = this.Adapter;
            this.dsPosition.LoadEvent = "Click";
            this.dsPosition.LoadTrigger = null;
            this.dsPosition.RefreshValve = 1000;
            this.dsPosition.SourceCommand = null;
            this.dsPosition.SourceCondition = "Code_Group = \'VacTube_Position\' order by Code";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(369, 39);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 180);
            this.tabControl1.TabIndex = 52;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbPosition);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbVacTubeName);
            this.tabPage1.Controls.Add(this.cmbVacTubeID);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(361, 155);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上位信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(67, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(67, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "位置:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOnPosition, "Position", true));
            this.cmbPosition.DataSource = this.dsPosition;
            this.cmbPosition.DisplayMember = "L3DataTable.Code_Des";
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.EnableNull = true;
            this.cmbPosition.ErropPr = null;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(120, 91);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(171, 20);
            this.cmbPosition.TabIndex = 57;
            this.cmbPosition.ToolTipValid = null;
            this.cmbPosition.ValidEable = true;
            this.cmbPosition.ValueMember = "L3DataTable.Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(67, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = "名称:";
            // 
            // cmbVacTubeName
            // 
            this.cmbVacTubeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVacTubeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVacTubeName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsOnPosition, "VacTube_Name", true));
            this.cmbVacTubeName.DataSource = this.dsName;
            this.cmbVacTubeName.DisplayMember = "L3DataTable.Code_Des";
            this.cmbVacTubeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacTubeName.EnableNull = true;
            this.cmbVacTubeName.ErropPr = null;
            this.cmbVacTubeName.FormattingEnabled = true;
            this.cmbVacTubeName.Location = new System.Drawing.Point(120, 29);
            this.cmbVacTubeName.Name = "cmbVacTubeName";
            this.cmbVacTubeName.Size = new System.Drawing.Size(171, 20);
            this.cmbVacTubeName.TabIndex = 58;
            this.cmbVacTubeName.ToolTipValid = null;
            this.cmbVacTubeName.ValidEable = true;
            this.cmbVacTubeName.ValueMember = "L3DataTable.Code";
            this.cmbVacTubeName.SelectedIndexChanged += new System.EventHandler(this.cmbVacTubeName_SelectedIndexChanged);
            this.cmbVacTubeName.TextChanged += new System.EventHandler(this.cmbVacTubeName_TextChanged);
            // 
            // cmbVacTubeID
            // 
            this.cmbVacTubeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVacTubeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVacTubeID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOnPosition, "VacTube_Id", true));
            this.cmbVacTubeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacTubeID.EnableNull = true;
            this.cmbVacTubeID.ErropPr = null;
            this.cmbVacTubeID.FormattingEnabled = true;
            this.cmbVacTubeID.Location = new System.Drawing.Point(120, 60);
            this.cmbVacTubeID.Name = "cmbVacTubeID";
            this.cmbVacTubeID.Size = new System.Drawing.Size(171, 20);
            this.cmbVacTubeID.TabIndex = 58;
            this.cmbVacTubeID.ToolTipValid = null;
            this.cmbVacTubeID.ValidEable = true;
            // 
            // dsBase
            // 
            this.dsBase.DataSetName = "L3DataSet";
            this.dsBase.DeleteMethod = null;
            this.dsBase.InsertMethod = null;
            this.dsBase.L3DataAdapter = this.Adapter;
            this.dsBase.LoadEvent = "Click";
            this.dsBase.LoadTrigger = null;
            this.dsBase.RefreshValve = 1000;
            this.dsBase.SourceCommand = null;
            this.dsBase.SourceCondition = null;
            this.dsBase.SourceMethod = "";
            this.dsBase.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBase.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            // 
            // bsTop
            // 
            this.bsTop.DataMember = "L3DataTable";
            this.bsTop.DataSource = this.dsBase;
            this.bsTop.Filter = "VacTube_Name = \'1\'";
            // 
            // bsLow
            // 
            this.bsLow.DataMember = "L3DataTable";
            this.bsLow.DataSource = this.dsBase;
            this.bsLow.Filter = "VacTube_Name = \'2\'";
            // 
            // bsHot
            // 
            this.bsHot.DataMember = "L3DataTable";
            this.bsHot.DataSource = this.dsBase;
            this.bsHot.Filter = "VacTube_Name = \'3\'";
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableVacTube_Name,
            this.coldsBaseL3DataTableVacTube_Id});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableVacTube_Name
            // 
            this.coldsBaseL3DataTableVacTube_Name.Caption = "VacTube_Name";
            this.coldsBaseL3DataTableVacTube_Name.ColumnName = "VacTube_Name";
            this.coldsBaseL3DataTableVacTube_Name.Namespace = "";
            // 
            // coldsBaseL3DataTableVacTube_Id
            // 
            this.coldsBaseL3DataTableVacTube_Id.Caption = "VacTube_Id";
            this.coldsBaseL3DataTableVacTube_Id.ColumnName = "VacTube_Id";
            this.coldsBaseL3DataTableVacTube_Id.Namespace = "";
            // 
            // dsOnPosition
            // 
            this.dsOnPosition.DataSetName = "L3DataSet";
            this.dsOnPosition.DeleteMethod = null;
            this.dsOnPosition.InsertMethod = null;
            this.dsOnPosition.L3DataAdapter = null;
            this.dsOnPosition.LoadEvent = "Click";
            this.dsOnPosition.LoadTrigger = null;
            this.dsOnPosition.RefreshValve = 1000;
            this.dsOnPosition.SourceCommand = null;
            this.dsOnPosition.SourceCondition = "";
            this.dsOnPosition.SourceMethod = "";
            this.dsOnPosition.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsOnPosition.SourceURI = "";
            this.dsOnPosition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOnPosition});
            this.dsOnPosition.UpdateEvent = "Click";
            this.dsOnPosition.UpdateMethod = null;
            this.dsOnPosition.UpdateTrigger = null;
            // 
            // schemadsOnPosition
            // 
            this.schemadsOnPosition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOnPositionL3DataTableGUID,
            this.coldsOnPositionL3DataTableName,
            this.coldsOnPositionL3DataTableVacTube_Name,
            this.coldsOnPositionL3DataTableVacTube_Id,
            this.coldsOnPositionL3DataTableState,
            this.coldsOnPositionL3DataTableRefra_Fac,
            this.coldsOnPositionL3DataTablePosition});
            this.schemadsOnPosition.TableName = "L3DataTable";
            // 
            // coldsOnPositionL3DataTableGUID
            // 
            this.coldsOnPositionL3DataTableGUID.Caption = "GUID";
            this.coldsOnPositionL3DataTableGUID.ColumnName = "GUID";
            this.coldsOnPositionL3DataTableGUID.Namespace = "";
            // 
            // coldsOnPositionL3DataTableName
            // 
            this.coldsOnPositionL3DataTableName.Caption = "Name";
            this.coldsOnPositionL3DataTableName.ColumnName = "Name";
            this.coldsOnPositionL3DataTableName.Namespace = "";
            // 
            // coldsOnPositionL3DataTableVacTube_Name
            // 
            this.coldsOnPositionL3DataTableVacTube_Name.Caption = "VacTube_Name";
            this.coldsOnPositionL3DataTableVacTube_Name.ColumnName = "VacTube_Name";
            this.coldsOnPositionL3DataTableVacTube_Name.Namespace = "";
            // 
            // coldsOnPositionL3DataTableVacTube_Id
            // 
            this.coldsOnPositionL3DataTableVacTube_Id.Caption = "VacTube_Id";
            this.coldsOnPositionL3DataTableVacTube_Id.ColumnName = "VacTube_Id";
            this.coldsOnPositionL3DataTableVacTube_Id.Namespace = "";
            // 
            // coldsOnPositionL3DataTableState
            // 
            this.coldsOnPositionL3DataTableState.Caption = "State";
            this.coldsOnPositionL3DataTableState.ColumnName = "State";
            this.coldsOnPositionL3DataTableState.Namespace = "";
            // 
            // coldsOnPositionL3DataTableRefra_Fac
            // 
            this.coldsOnPositionL3DataTableRefra_Fac.Caption = "Refra_Fac";
            this.coldsOnPositionL3DataTableRefra_Fac.ColumnName = "Refra_Fac";
            this.coldsOnPositionL3DataTableRefra_Fac.Namespace = "";
            // 
            // coldsOnPositionL3DataTablePosition
            // 
            this.coldsOnPositionL3DataTablePosition.Caption = "Position";
            this.coldsOnPositionL3DataTablePosition.ColumnName = "Position";
            this.coldsOnPositionL3DataTablePosition.Namespace = "";
            // 
            // bsOnPosition
            // 
            this.bsOnPosition.DataMember = "L3DataTable";
            this.bsOnPosition.DataSource = this.dsOnPosition;
            // 
            // dsName
            // 
            this.dsName.DataSetName = "L3DataSet";
            this.dsName.DeleteMethod = null;
            this.dsName.InsertMethod = null;
            this.dsName.L3DataAdapter = this.Adapter;
            this.dsName.LoadEvent = "Click";
            this.dsName.LoadTrigger = null;
            this.dsName.RefreshValve = 1000;
            this.dsName.SourceCommand = null;
            this.dsName.SourceCondition = "Code_Group = \'VacTubeName\' order by Code";
            this.dsName.SourceMethod = "";
            this.dsName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsName.SubscribeTarget = null;
            this.dsName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsName});
            this.dsName.UpdateEvent = "Click";
            this.dsName.UpdateMethod = null;
            this.dsName.UpdateTrigger = null;
            // 
            // schemadsName
            // 
            this.schemadsName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsNameL3DataTableCode,
            this.coldsNameL3DataTableCode_Des});
            this.schemadsName.TableName = "L3DataTable";
            // 
            // coldsNameL3DataTableCode
            // 
            this.coldsNameL3DataTableCode.Caption = "Code";
            this.coldsNameL3DataTableCode.ColumnName = "Code";
            this.coldsNameL3DataTableCode.Namespace = "";
            // 
            // coldsNameL3DataTableCode_Des
            // 
            this.coldsNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsNameL3DataTableCode_Des.Namespace = "";
            // 
            // cmdOnPosition
            // 
            this.cmdOnPosition.Adapter = this.Adapter;
            this.cmdOnPosition.MergeReturnTarget = false;
            this.cmdOnPosition.Method = "VacTubeOnPosition";
            this.cmdOnPosition.Object = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTube_Mag";
            this.cmdOnPosition.Parameters.Add(this.l3cmdpOn);
            this.cmdOnPosition.ReturnTarget = null;
            this.cmdOnPosition.ReturnTargetProperty = null;
            this.cmdOnPosition.Trigger = null;
            this.cmdOnPosition.TriggerEvent = "Click";
            // 
            // l3cmdpOn
            // 
            this.l3cmdpOn.AcceptAfterExecuted = false;
            this.l3cmdpOn.ConstantValue = null;
            this.l3cmdpOn.MergeTarget = false;
            this.l3cmdpOn.SourceFilter = null;
            this.l3cmdpOn.SourceObject = this.dsOnPosition;
            this.l3cmdpOn.SourceProperty = "L3DataTable";
            this.l3cmdpOn.TargetObject = null;
            this.l3cmdpOn.TargetProperty = null;
            // 
            // VacTubeOnPositionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 219);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "VacTubeOnPositionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "上位管理";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOnPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOnPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOnPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsPosition;
        private System.Data.DataTable schemadsPosition;
        private System.Data.DataColumn coldsPositionL3DataTableCode;
        private System.Data.DataColumn coldsPositionL3DataTableCode_Des;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private PxDataValid.PxComboBox cmbPosition;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxComboBox cmbVacTubeName;
        private PxDataValid.PxComboBox cmbVacTubeID;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Windows.Forms.BindingSource bsTop;
        private System.Windows.Forms.BindingSource bsLow;
        private System.Windows.Forms.BindingSource bsHot;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_Name;
        private System.Data.DataColumn coldsBaseL3DataTableVacTube_Id;
        private AppSvrHMI.L3DataSet dsOnPosition;
        private System.Data.DataTable schemadsOnPosition;
        private System.Data.DataColumn coldsOnPositionL3DataTableGUID;
        private System.Data.DataColumn coldsOnPositionL3DataTableName;
        private System.Data.DataColumn coldsOnPositionL3DataTableVacTube_Name;
        private System.Data.DataColumn coldsOnPositionL3DataTableVacTube_Id;
        private System.Data.DataColumn coldsOnPositionL3DataTableState;
        private System.Data.DataColumn coldsOnPositionL3DataTableRefra_Fac;
        private System.Data.DataColumn coldsOnPositionL3DataTablePosition;
        private System.Windows.Forms.BindingSource bsOnPosition;
        private AppSvrHMI.L3DataSet dsName;
        private System.Data.DataTable schemadsName;
        private System.Data.DataColumn coldsNameL3DataTableCode;
        private System.Data.DataColumn coldsNameL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdOnPosition;
        private AppSvrHMI.L3CommandParameter l3cmdpOn;
    }
}