namespace UnitMag.BOFMag
{
    partial class BOFStackMagFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeamID = new PxDataValid.PxComboBox();
            this.dsStack = new AppSvrHMI.L3DataSet();
            this.schemadsStack = new System.Data.DataTable();
            this.coldsStackL3DataTableGUID = new System.Data.DataColumn();
            this.coldsStackL3DataTableName = new System.Data.DataColumn();
            this.coldsStackL3DataTableProductionDate = new System.Data.DataColumn();
            this.coldsStackL3DataTableTeam = new System.Data.DataColumn();
            this.coldsStackL3DataTableContent = new System.Data.DataColumn();
            this.coldsStackL3DataTableMateriel = new System.Data.DataColumn();
            this.coldsStackL3DataTableTaphole_Vendor = new System.Data.DataColumn();
            this.coldsStackL3DataTableMateriel_Vendor = new System.Data.DataColumn();
            this.coldsStackL3DataTableWastage = new System.Data.DataColumn();
            this.coldsStackL3DataTableBOFID = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.cmbContent = new PxDataValid.PxComboBox();
            this.dsStackContent = new AppSvrHMI.L3DataSet();
            this.schemadsStackContent = new System.Data.DataTable();
            this.coldsStackContentL3DataTableCode = new System.Data.DataColumn();
            this.coldsStackContentL3DataTableCode_Des = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMateriel = new PxDataValid.PxComboBox();
            this.dsStackMaterial = new AppSvrHMI.L3DataSet();
            this.schemadsStackMaterial = new System.Data.DataTable();
            this.coldsStackMaterialL3DataTableCode = new System.Data.DataColumn();
            this.coldsStackMaterialL3DataTableCode_Des = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTapholeVendor = new PxDataValid.PxComboBox();
            this.dsTapholeVender = new AppSvrHMI.L3DataSet();
            this.schemadsTapholeVender = new System.Data.DataTable();
            this.coldsTapholeVenderL3DataTableCode = new System.Data.DataColumn();
            this.coldsTapholeVenderL3DataTableCode_Des = new System.Data.DataColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStack = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWastage = new System.Windows.Forms.TextBox();
            this.cmbMereielVonder = new PxDataValid.PxComboBox();
            this.dsMaterielVonder = new AppSvrHMI.L3DataSet();
            this.schemadsMaterielVonder = new System.Data.DataTable();
            this.coldsMaterielVonderL3DataTableCode = new System.Data.DataColumn();
            this.coldsMaterielVonderL3DataTableCode_Des = new System.Data.DataColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmdSetStack = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.coldsStackL3DataTableSintering_Time = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStackContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStackContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStackMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStackMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapholeVender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapholeVender)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpStack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterielVonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterielVonder)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "班别:";
            // 
            // cmbTeamID
            // 
            this.cmbTeamID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTeamID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTeamID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsStack, "L3DataTable.Team", true));
            this.cmbTeamID.DataSource = this.dsTeamID;
            this.cmbTeamID.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTeamID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamID.EnableNull = true;
            this.cmbTeamID.ErropPr = null;
            this.cmbTeamID.FormattingEnabled = true;
            this.cmbTeamID.Location = new System.Drawing.Point(157, 19);
            this.cmbTeamID.Name = "cmbTeamID";
            this.cmbTeamID.Size = new System.Drawing.Size(178, 20);
            this.cmbTeamID.TabIndex = 0;
            this.cmbTeamID.ToolTipValid = null;
            this.cmbTeamID.ValidEable = false;
            this.cmbTeamID.ValueMember = "L3DataTable.Code";
            // 
            // dsStack
            // 
            this.dsStack.AutoLoad = true;
            this.dsStack.AutoSubscribe = false;
            this.dsStack.DataSetName = "L3DataSet";
            this.dsStack.DeleteMethod = null;
            this.dsStack.InsertMethod = null;
            this.dsStack.L3DataAdapter = null;
            this.dsStack.LoadEvent = "Click";
            this.dsStack.LoadTrigger = null;
            this.dsStack.RefreshValve = 1000;
            this.dsStack.SourceCommand = null;
            this.dsStack.SourceCondition = "";
            this.dsStack.SourceMethod = "";
            this.dsStack.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStack.SourceURI = "";
            this.dsStack.SubscribeTarget = "";
            this.dsStack.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStack});
            this.dsStack.UpdateEvent = "Click";
            this.dsStack.UpdateMethod = null;
            this.dsStack.UpdateTrigger = null;
            // 
            // schemadsStack
            // 
            this.schemadsStack.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStackL3DataTableGUID,
            this.coldsStackL3DataTableName,
            this.coldsStackL3DataTableProductionDate,
            this.coldsStackL3DataTableTeam,
            this.coldsStackL3DataTableContent,
            this.coldsStackL3DataTableMateriel,
            this.coldsStackL3DataTableTaphole_Vendor,
            this.coldsStackL3DataTableMateriel_Vendor,
            this.coldsStackL3DataTableWastage,
            this.coldsStackL3DataTableBOFID,
            this.coldsStackL3DataTableSintering_Time});
            this.schemadsStack.TableName = "L3DataTable";
            // 
            // coldsStackL3DataTableGUID
            // 
            this.coldsStackL3DataTableGUID.Caption = "GUID";
            this.coldsStackL3DataTableGUID.ColumnName = "GUID";
            this.coldsStackL3DataTableGUID.Namespace = "";
            // 
            // coldsStackL3DataTableName
            // 
            this.coldsStackL3DataTableName.Caption = "Name";
            this.coldsStackL3DataTableName.ColumnName = "Name";
            this.coldsStackL3DataTableName.Namespace = "";
            // 
            // coldsStackL3DataTableProductionDate
            // 
            this.coldsStackL3DataTableProductionDate.Caption = "ProductionDate";
            this.coldsStackL3DataTableProductionDate.ColumnName = "ProductionDate";
            this.coldsStackL3DataTableProductionDate.DataType = typeof(System.DateTime);
            this.coldsStackL3DataTableProductionDate.Namespace = "";
            // 
            // coldsStackL3DataTableTeam
            // 
            this.coldsStackL3DataTableTeam.Caption = "Team";
            this.coldsStackL3DataTableTeam.ColumnName = "Team";
            this.coldsStackL3DataTableTeam.Namespace = "";
            // 
            // coldsStackL3DataTableContent
            // 
            this.coldsStackL3DataTableContent.Caption = "Content";
            this.coldsStackL3DataTableContent.ColumnName = "Content";
            this.coldsStackL3DataTableContent.Namespace = "";
            // 
            // coldsStackL3DataTableMateriel
            // 
            this.coldsStackL3DataTableMateriel.Caption = "Materiel";
            this.coldsStackL3DataTableMateriel.ColumnName = "Materiel";
            this.coldsStackL3DataTableMateriel.Namespace = "";
            // 
            // coldsStackL3DataTableTaphole_Vendor
            // 
            this.coldsStackL3DataTableTaphole_Vendor.Caption = "Taphole_Vendor";
            this.coldsStackL3DataTableTaphole_Vendor.ColumnName = "Taphole_Vendor";
            this.coldsStackL3DataTableTaphole_Vendor.Namespace = "";
            // 
            // coldsStackL3DataTableMateriel_Vendor
            // 
            this.coldsStackL3DataTableMateriel_Vendor.Caption = "Materiel_Vendor";
            this.coldsStackL3DataTableMateriel_Vendor.ColumnName = "Materiel_Vendor";
            this.coldsStackL3DataTableMateriel_Vendor.Namespace = "";
            // 
            // coldsStackL3DataTableWastage
            // 
            this.coldsStackL3DataTableWastage.Caption = "Wastage";
            this.coldsStackL3DataTableWastage.ColumnName = "Wastage";
            this.coldsStackL3DataTableWastage.DataType = typeof(float);
            this.coldsStackL3DataTableWastage.Namespace = "";
            // 
            // coldsStackL3DataTableBOFID
            // 
            this.coldsStackL3DataTableBOFID.Caption = "BOFID";
            this.coldsStackL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsStackL3DataTableBOFID.Namespace = "";
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoLoad = true;
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "CODE_GROUP = \'TeamID\'";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // cmbContent
            // 
            this.cmbContent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbContent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbContent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsStack, "L3DataTable.Content", true));
            this.cmbContent.DataSource = this.dsStackContent;
            this.cmbContent.DisplayMember = "L3DataTable.Code_Des";
            this.cmbContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContent.EnableNull = true;
            this.cmbContent.ErropPr = null;
            this.cmbContent.FormattingEnabled = true;
            this.cmbContent.Location = new System.Drawing.Point(157, 45);
            this.cmbContent.Name = "cmbContent";
            this.cmbContent.Size = new System.Drawing.Size(178, 20);
            this.cmbContent.TabIndex = 1;
            this.cmbContent.ToolTipValid = null;
            this.cmbContent.ValidEable = false;
            this.cmbContent.ValueMember = "L3DataTable.Code";
            // 
            // dsStackContent
            // 
            this.dsStackContent.AutoLoad = true;
            this.dsStackContent.AutoSubscribe = false;
            this.dsStackContent.DataSetName = "L3DataSet";
            this.dsStackContent.DeleteMethod = null;
            this.dsStackContent.InsertMethod = null;
            this.dsStackContent.L3DataAdapter = this.Adapter;
            this.dsStackContent.LoadEvent = "Click";
            this.dsStackContent.LoadTrigger = null;
            this.dsStackContent.RefreshValve = 1000;
            this.dsStackContent.SourceCommand = null;
            this.dsStackContent.SourceCondition = "CODE_GROUP = \'BOF_Stack_Content\'";
            this.dsStackContent.SourceMethod = "";
            this.dsStackContent.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStackContent.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStackContent.SubscribeTarget = null;
            this.dsStackContent.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStackContent});
            this.dsStackContent.UpdateEvent = "Click";
            this.dsStackContent.UpdateMethod = null;
            this.dsStackContent.UpdateTrigger = null;
            // 
            // schemadsStackContent
            // 
            this.schemadsStackContent.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStackContentL3DataTableCode,
            this.coldsStackContentL3DataTableCode_Des});
            this.schemadsStackContent.TableName = "L3DataTable";
            // 
            // coldsStackContentL3DataTableCode
            // 
            this.coldsStackContentL3DataTableCode.Caption = "Code";
            this.coldsStackContentL3DataTableCode.ColumnName = "Code";
            this.coldsStackContentL3DataTableCode.Namespace = "";
            // 
            // coldsStackContentL3DataTableCode_Des
            // 
            this.coldsStackContentL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStackContentL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStackContentL3DataTableCode_Des.Namespace = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "内容:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "用料量[Kg]:";
            // 
            // cmbMateriel
            // 
            this.cmbMateriel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMateriel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMateriel.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsStack, "L3DataTable.Materiel", true));
            this.cmbMateriel.DataSource = this.dsStackMaterial;
            this.cmbMateriel.DisplayMember = "L3DataTable.Code_Des";
            this.cmbMateriel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriel.EnableNull = true;
            this.cmbMateriel.ErropPr = null;
            this.cmbMateriel.FormattingEnabled = true;
            this.cmbMateriel.Location = new System.Drawing.Point(157, 98);
            this.cmbMateriel.Name = "cmbMateriel";
            this.cmbMateriel.Size = new System.Drawing.Size(178, 20);
            this.cmbMateriel.TabIndex = 3;
            this.cmbMateriel.ToolTipValid = null;
            this.cmbMateriel.ValidEable = false;
            this.cmbMateriel.ValueMember = "L3DataTable.Code";
            // 
            // dsStackMaterial
            // 
            this.dsStackMaterial.AutoLoad = true;
            this.dsStackMaterial.AutoSubscribe = false;
            this.dsStackMaterial.DataSetName = "L3DataSet";
            this.dsStackMaterial.DeleteMethod = null;
            this.dsStackMaterial.InsertMethod = null;
            this.dsStackMaterial.L3DataAdapter = this.Adapter;
            this.dsStackMaterial.LoadEvent = "Click";
            this.dsStackMaterial.LoadTrigger = null;
            this.dsStackMaterial.RefreshValve = 1000;
            this.dsStackMaterial.SourceCommand = null;
            this.dsStackMaterial.SourceCondition = "CODE_GROUP = \'BOF_Stack_Materiel\'";
            this.dsStackMaterial.SourceMethod = "";
            this.dsStackMaterial.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStackMaterial.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStackMaterial.SubscribeTarget = null;
            this.dsStackMaterial.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStackMaterial});
            this.dsStackMaterial.UpdateEvent = "Click";
            this.dsStackMaterial.UpdateMethod = null;
            this.dsStackMaterial.UpdateTrigger = null;
            // 
            // schemadsStackMaterial
            // 
            this.schemadsStackMaterial.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStackMaterialL3DataTableCode,
            this.coldsStackMaterialL3DataTableCode_Des});
            this.schemadsStackMaterial.TableName = "L3DataTable";
            // 
            // coldsStackMaterialL3DataTableCode
            // 
            this.coldsStackMaterialL3DataTableCode.Caption = "Code";
            this.coldsStackMaterialL3DataTableCode.ColumnName = "Code";
            this.coldsStackMaterialL3DataTableCode.Namespace = "";
            // 
            // coldsStackMaterialL3DataTableCode_Des
            // 
            this.coldsStackMaterialL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStackMaterialL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStackMaterialL3DataTableCode_Des.Namespace = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "使用物料:";
            // 
            // cmbTapholeVendor
            // 
            this.cmbTapholeVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTapholeVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTapholeVendor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsStack, "L3DataTable.Taphole_Vendor", true));
            this.cmbTapholeVendor.DataSource = this.dsTapholeVender;
            this.cmbTapholeVendor.DisplayMember = "L3DataTable.Code_Des";
            this.cmbTapholeVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTapholeVendor.EnableNull = true;
            this.cmbTapholeVendor.ErropPr = null;
            this.cmbTapholeVendor.FormattingEnabled = true;
            this.cmbTapholeVendor.Location = new System.Drawing.Point(157, 174);
            this.cmbTapholeVendor.Name = "cmbTapholeVendor";
            this.cmbTapholeVendor.Size = new System.Drawing.Size(178, 20);
            this.cmbTapholeVendor.TabIndex = 4;
            this.cmbTapholeVendor.ToolTipValid = null;
            this.cmbTapholeVendor.ValidEable = false;
            this.cmbTapholeVendor.ValueMember = "L3DataTable.Code";
            // 
            // dsTapholeVender
            // 
            this.dsTapholeVender.AutoLoad = true;
            this.dsTapholeVender.AutoSubscribe = false;
            this.dsTapholeVender.DataSetName = "L3DataSet";
            this.dsTapholeVender.DeleteMethod = null;
            this.dsTapholeVender.InsertMethod = null;
            this.dsTapholeVender.L3DataAdapter = this.Adapter;
            this.dsTapholeVender.LoadEvent = "Click";
            this.dsTapholeVender.LoadTrigger = null;
            this.dsTapholeVender.RefreshValve = 1000;
            this.dsTapholeVender.SourceCommand = null;
            this.dsTapholeVender.SourceCondition = "CODE_GROUP = \'BOF_Stack_Taphole_Vendor\'";
            this.dsTapholeVender.SourceMethod = "";
            this.dsTapholeVender.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTapholeVender.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTapholeVender.SubscribeTarget = null;
            this.dsTapholeVender.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTapholeVender});
            this.dsTapholeVender.UpdateEvent = "Click";
            this.dsTapholeVender.UpdateMethod = null;
            this.dsTapholeVender.UpdateTrigger = null;
            // 
            // schemadsTapholeVender
            // 
            this.schemadsTapholeVender.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTapholeVenderL3DataTableCode,
            this.coldsTapholeVenderL3DataTableCode_Des});
            this.schemadsTapholeVender.TableName = "L3DataTable";
            // 
            // coldsTapholeVenderL3DataTableCode
            // 
            this.coldsTapholeVenderL3DataTableCode.Caption = "Code";
            this.coldsTapholeVenderL3DataTableCode.ColumnName = "Code";
            this.coldsTapholeVenderL3DataTableCode.Namespace = "";
            // 
            // coldsTapholeVenderL3DataTableCode_Des
            // 
            this.coldsTapholeVenderL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTapholeVenderL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTapholeVenderL3DataTableCode_Des.Namespace = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "物料厂家:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStack);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 232);
            this.tabControl1.TabIndex = 82;
            // 
            // tpStack
            // 
            this.tpStack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpStack.Controls.Add(this.label8);
            this.tpStack.Controls.Add(this.textBox2);
            this.tpStack.Controls.Add(this.label7);
            this.tpStack.Controls.Add(this.txtWastage);
            this.tpStack.Controls.Add(this.cmbMateriel);
            this.tpStack.Controls.Add(this.label2);
            this.tpStack.Controls.Add(this.cmbMereielVonder);
            this.tpStack.Controls.Add(this.cmbTapholeVendor);
            this.tpStack.Controls.Add(this.label6);
            this.tpStack.Controls.Add(this.cmbTeamID);
            this.tpStack.Controls.Add(this.label5);
            this.tpStack.Controls.Add(this.label3);
            this.tpStack.Controls.Add(this.cmbContent);
            this.tpStack.Controls.Add(this.label1);
            this.tpStack.Controls.Add(this.label4);
            this.tpStack.Location = new System.Drawing.Point(4, 21);
            this.tpStack.Name = "tpStack";
            this.tpStack.Padding = new System.Windows.Forms.Padding(3);
            this.tpStack.Size = new System.Drawing.Size(417, 207);
            this.tpStack.TabIndex = 0;
            this.tpStack.Text = "维护信息";
            this.tpStack.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "烧结时间:";
            // 
            // txtWastage
            // 
            this.txtWastage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsStack, "L3DataTable.Wastage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "0", "N2"));
            this.txtWastage.Location = new System.Drawing.Point(157, 71);
            this.txtWastage.Name = "txtWastage";
            this.txtWastage.Size = new System.Drawing.Size(178, 21);
            this.txtWastage.TabIndex = 10;
            // 
            // cmbMereielVonder
            // 
            this.cmbMereielVonder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMereielVonder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMereielVonder.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsStack, "L3DataTable.Materiel_Vendor", true));
            this.cmbMereielVonder.DataSource = this.dsMaterielVonder;
            this.cmbMereielVonder.DisplayMember = "L3DataTable.Code_Des";
            this.cmbMereielVonder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMereielVonder.EnableNull = true;
            this.cmbMereielVonder.ErropPr = null;
            this.cmbMereielVonder.FormattingEnabled = true;
            this.cmbMereielVonder.Location = new System.Drawing.Point(157, 125);
            this.cmbMereielVonder.Name = "cmbMereielVonder";
            this.cmbMereielVonder.Size = new System.Drawing.Size(178, 20);
            this.cmbMereielVonder.TabIndex = 4;
            this.cmbMereielVonder.ToolTipValid = null;
            this.cmbMereielVonder.ValidEable = false;
            this.cmbMereielVonder.ValueMember = "L3DataTable.Code";
            // 
            // dsMaterielVonder
            // 
            this.dsMaterielVonder.AutoLoad = true;
            this.dsMaterielVonder.AutoSubscribe = false;
            this.dsMaterielVonder.DataSetName = "L3DataSet";
            this.dsMaterielVonder.DeleteMethod = null;
            this.dsMaterielVonder.InsertMethod = null;
            this.dsMaterielVonder.L3DataAdapter = this.Adapter;
            this.dsMaterielVonder.LoadEvent = "Click";
            this.dsMaterielVonder.LoadTrigger = null;
            this.dsMaterielVonder.RefreshValve = 1000;
            this.dsMaterielVonder.SourceCommand = null;
            this.dsMaterielVonder.SourceCondition = "CODE_GROUP = \'BOF_Stack_Materiel_Vendor\'";
            this.dsMaterielVonder.SourceMethod = "";
            this.dsMaterielVonder.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMaterielVonder.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsMaterielVonder.SubscribeTarget = null;
            this.dsMaterielVonder.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterielVonder});
            this.dsMaterielVonder.UpdateEvent = "Click";
            this.dsMaterielVonder.UpdateMethod = null;
            this.dsMaterielVonder.UpdateTrigger = null;
            // 
            // schemadsMaterielVonder
            // 
            this.schemadsMaterielVonder.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterielVonderL3DataTableCode,
            this.coldsMaterielVonderL3DataTableCode_Des});
            this.schemadsMaterielVonder.TableName = "L3DataTable";
            // 
            // coldsMaterielVonderL3DataTableCode
            // 
            this.coldsMaterielVonderL3DataTableCode.Caption = "Code";
            this.coldsMaterielVonderL3DataTableCode.ColumnName = "Code";
            this.coldsMaterielVonderL3DataTableCode.Namespace = "";
            // 
            // coldsMaterielVonderL3DataTableCode_Des
            // 
            this.coldsMaterielVonderL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsMaterielVonderL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsMaterielVonderL3DataTableCode_Des.Namespace = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "出钢口厂家:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 22);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(255, 238);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 22);
            this.btnConfirm.TabIndex = 84;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdSetStack
            // 
            this.cmdSetStack.Adapter = this.Adapter;
            this.cmdSetStack.MergeReturnTarget = false;
            this.cmdSetStack.Method = "SetStackData";
            this.cmdSetStack.Object = "";
            this.cmdSetStack.Parameters.Add(this.l3CommandParameter1);
            this.cmdSetStack.ReturnTarget = null;
            this.cmdSetStack.ReturnTargetProperty = null;
            this.cmdSetStack.Trigger = null;
            this.cmdSetStack.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsStack;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsStack, "L3DataTable.Sintering_Time", true));
            this.textBox2.Location = new System.Drawing.Point(157, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 21);
            this.textBox2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "\'";
            // 
            // coldsStackL3DataTableSintering_Time
            // 
            this.coldsStackL3DataTableSintering_Time.Caption = "Sintering_Time";
            this.coldsStackL3DataTableSintering_Time.ColumnName = "Sintering_Time";
            this.coldsStackL3DataTableSintering_Time.DataType = typeof(int);
            this.coldsStackL3DataTableSintering_Time.Namespace = "";
            // 
            // BOFStackMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 271);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.Name = "BOFStackMagFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "炉衬维护管理";
            this.Load += new System.EventHandler(this.BOFStackMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStackContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStackContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStackMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStackMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTapholeVender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTapholeVender)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpStack.ResumeLayout(false);
            this.tpStack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterielVonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterielVonder)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxComboBox cmbTeamID;
        private PxDataValid.PxComboBox cmbContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private PxDataValid.PxComboBox cmbMateriel;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxComboBox cmbTapholeVendor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpStack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private AppSvrHMI.L3DataSet dsTeamID;
        private AppSvrHMI.L3DataSet dsStack;
        private System.Data.DataTable schemadsStack;
        private System.Data.DataColumn coldsStackL3DataTableGUID;
        private System.Data.DataColumn coldsStackL3DataTableName;
        private System.Data.DataColumn coldsStackL3DataTableProductionDate;
        private System.Data.DataColumn coldsStackL3DataTableTeam;
        private System.Data.DataColumn coldsStackL3DataTableContent;
        private System.Data.DataColumn coldsStackL3DataTableMateriel;
        private System.Data.DataColumn coldsStackL3DataTableTaphole_Vendor;
        private System.Data.DataColumn coldsStackL3DataTableMateriel_Vendor;
        private System.Data.DataColumn coldsStackL3DataTableWastage;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdSetStack;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsStackContent;
        private System.Data.DataTable schemadsStackContent;
        private System.Data.DataColumn coldsStackContentL3DataTableCode;
        private System.Data.DataColumn coldsStackContentL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsStackMaterial;
        private System.Data.DataTable schemadsStackMaterial;
        private System.Data.DataColumn coldsStackMaterialL3DataTableCode;
        private System.Data.DataColumn coldsStackMaterialL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsMaterielVonder;
        private System.Data.DataTable schemadsMaterielVonder;
        private System.Data.DataColumn coldsMaterielVonderL3DataTableCode;
        private System.Data.DataColumn coldsMaterielVonderL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbMereielVonder;
        private System.Windows.Forms.Label label6;
        private AppSvrHMI.L3DataSet dsTapholeVender;
        private System.Data.DataTable schemadsTapholeVender;
        private System.Data.DataColumn coldsTapholeVenderL3DataTableCode;
        private System.Data.DataColumn coldsTapholeVenderL3DataTableCode_Des;
        private System.Windows.Forms.TextBox txtWastage;
        private System.Data.DataColumn coldsStackL3DataTableBOFID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Data.DataColumn coldsStackL3DataTableSintering_Time;
    }
}