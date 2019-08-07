namespace EquipMag.LadleMag
{
    partial class LadleAddShowFrm 
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIronLadleNo = new System.Windows.Forms.MaskedTextBox();
            this.cmbLadleType = new System.Windows.Forms.ComboBox();
            this.dsLadleType = new AppSvrHMI.L3DataSet();
            this.schemadsLadleType = new System.Data.DataTable();
            this.coldsLadleTypeL3DataTablecode = new System.Data.DataColumn();
            this.coldsLadleTypeL3DataTablecode_des = new System.Data.DataColumn();
            this.coldsLadleTypeL3DataTablecode_val_long = new System.Data.DataColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coldsMainL3DataTableNote = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsLadle = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadle = new System.Data.DataTable();
            this.coldsIronLadleL3DataTableGUID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableName = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableStatus = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableComFlag = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableTare_Weight = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableLadleID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableRefra_Facturer = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableLadle_Grade = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableLadle_Age = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableNew_BOF_Flag = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableTare_WT = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableLadleType = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableOnFireID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableWorkFireID = new System.Data.DataColumn();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadle)).BeginInit();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 45);
            this.panel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            this.tabControl1.Size = new System.Drawing.Size(306, 133);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtIronLadleNo);
            this.tabPage1.Controls.Add(this.cmbLadleType);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 108);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "铁包信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtIronLadleNo
            // 
            this.txtIronLadleNo.Location = new System.Drawing.Point(115, 29);
            this.txtIronLadleNo.Mask = "G999";
            this.txtIronLadleNo.Name = "txtIronLadleNo";
            this.txtIronLadleNo.Size = new System.Drawing.Size(131, 21);
            this.txtIronLadleNo.TabIndex = 4;
            // 
            // cmbLadleType
            // 
            this.cmbLadleType.DataSource = this.dsLadleType;
            this.cmbLadleType.DisplayMember = "L3DataTable.code_des";
            this.cmbLadleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadleType.FormattingEnabled = true;
            this.cmbLadleType.Location = new System.Drawing.Point(115, 63);
            this.cmbLadleType.Name = "cmbLadleType";
            this.cmbLadleType.Size = new System.Drawing.Size(131, 20);
            this.cmbLadleType.TabIndex = 3;
            this.cmbLadleType.ValueMember = "L3DataTable.code_val_long";
            // 
            // dsLadleType
            // 
            this.dsLadleType.AutoSubscribe = false;
            this.dsLadleType.DataSetName = "L3DataSet";
            this.dsLadleType.DeleteMethod = null;
            this.dsLadleType.InsertMethod = null;
            this.dsLadleType.L3DataAdapter = this.Adapter;
            this.dsLadleType.LoadEvent = "Click";
            this.dsLadleType.LoadTrigger = null;
            this.dsLadleType.RefreshValve = 1000;
            this.dsLadleType.SourceCommand = null;
            this.dsLadleType.SourceCondition = "Code_Group = \'LadleType\' and code is not null order by code";
            this.dsLadleType.SourceMethod = "";
            this.dsLadleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLadleType.SubscribeTarget = null;
            this.dsLadleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLadleType});
            this.dsLadleType.UpdateEvent = "Click";
            this.dsLadleType.UpdateMethod = null;
            this.dsLadleType.UpdateTrigger = null;
            // 
            // schemadsLadleType
            // 
            this.schemadsLadleType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLadleTypeL3DataTablecode,
            this.coldsLadleTypeL3DataTablecode_des,
            this.coldsLadleTypeL3DataTablecode_val_long});
            this.schemadsLadleType.TableName = "L3DataTable";
            // 
            // coldsLadleTypeL3DataTablecode
            // 
            this.coldsLadleTypeL3DataTablecode.Caption = "code";
            this.coldsLadleTypeL3DataTablecode.ColumnName = "code";
            this.coldsLadleTypeL3DataTablecode.Namespace = "";
            // 
            // coldsLadleTypeL3DataTablecode_des
            // 
            this.coldsLadleTypeL3DataTablecode_des.Caption = "code_des";
            this.coldsLadleTypeL3DataTablecode_des.ColumnName = "code_des";
            this.coldsLadleTypeL3DataTablecode_des.Namespace = "";
            // 
            // coldsLadleTypeL3DataTablecode_val_long
            // 
            this.coldsLadleTypeL3DataTablecode_val_long.Caption = "code_val_long";
            this.coldsLadleTypeL3DataTablecode_val_long.ColumnName = "code_val_long";
            this.coldsLadleTypeL3DataTablecode_val_long.DataType = typeof(int);
            this.coldsLadleTypeL3DataTablecode_val_long.Namespace = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "钢包类型:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "钢包号:";
            // 
            // coldsMainL3DataTableNote
            // 
            this.coldsMainL3DataTableNote.Caption = "Note";
            this.coldsMainL3DataTableNote.ColumnName = "Note";
            this.coldsMainL3DataTableNote.Namespace = "";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = null;
            this.l3CommandParameter1.SourceProperty = "Text";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dsLadle
            // 
            this.dsLadle.AutoSubscribe = false;
            this.dsLadle.DataSetName = "L3DataSet";
            this.dsLadle.DeleteMethod = "";
            this.dsLadle.InsertMethod = "";
            this.dsLadle.L3DataAdapter = this.Adapter;
            this.dsLadle.LoadEvent = "";
            this.dsLadle.LoadTrigger = null;
            this.dsLadle.RefreshValve = 1000;
            this.dsLadle.SourceCommand = null;
            this.dsLadle.SourceCondition = "1=2";
            this.dsLadle.SourceMethod = "";
            this.dsLadle.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLadle.SourceURI = "XGMESLogic\\LadleMag\\CLadle_Base";
            this.dsLadle.SubscribeTarget = "";
            this.dsLadle.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadle});
            this.dsLadle.UpdateEvent = "";
            this.dsLadle.UpdateMethod = "";
            this.dsLadle.UpdateTrigger = null;
            // 
            // schemadsIronLadle
            // 
            this.schemadsIronLadle.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadleL3DataTableGUID,
            this.coldsIronLadleL3DataTableName,
            this.coldsIronLadleL3DataTableStatus,
            this.coldsIronLadleL3DataTableComFlag,
            this.coldsIronLadleL3DataTableTare_Weight,
            this.coldsIronLadleL3DataTableLadleID,
            this.coldsIronLadleL3DataTableHeatID,
            this.coldsIronLadleL3DataTableRefra_Facturer,
            this.coldsIronLadleL3DataTableLadle_Grade,
            this.coldsIronLadleL3DataTableLadle_Age,
            this.coldsIronLadleL3DataTableNew_BOF_Flag,
            this.coldsIronLadleL3DataTableTare_WT,
            this.coldsIronLadleL3DataTableLadleType,
            this.coldsIronLadleL3DataTableInnerID,
            this.coldsIronLadleL3DataTableWorkID,
            this.coldsIronLadleL3DataTableOnFireID,
            this.coldsIronLadleL3DataTableWorkFireID});
            this.schemadsIronLadle.TableName = "L3DataTable";
            // 
            // coldsIronLadleL3DataTableGUID
            // 
            this.coldsIronLadleL3DataTableGUID.Caption = "GUID";
            this.coldsIronLadleL3DataTableGUID.ColumnName = "GUID";
            this.coldsIronLadleL3DataTableGUID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableName
            // 
            this.coldsIronLadleL3DataTableName.Caption = "Name";
            this.coldsIronLadleL3DataTableName.ColumnName = "Name";
            this.coldsIronLadleL3DataTableName.Namespace = "";
            // 
            // coldsIronLadleL3DataTableStatus
            // 
            this.coldsIronLadleL3DataTableStatus.Caption = "Status";
            this.coldsIronLadleL3DataTableStatus.ColumnName = "Status";
            this.coldsIronLadleL3DataTableStatus.Namespace = "";
            // 
            // coldsIronLadleL3DataTableComFlag
            // 
            this.coldsIronLadleL3DataTableComFlag.Caption = "ComFlag";
            this.coldsIronLadleL3DataTableComFlag.ColumnName = "ComFlag";
            this.coldsIronLadleL3DataTableComFlag.DataType = typeof(int);
            this.coldsIronLadleL3DataTableComFlag.Namespace = "";
            // 
            // coldsIronLadleL3DataTableTare_Weight
            // 
            this.coldsIronLadleL3DataTableTare_Weight.Caption = "Tare_Weight";
            this.coldsIronLadleL3DataTableTare_Weight.ColumnName = "Tare_Weight";
            this.coldsIronLadleL3DataTableTare_Weight.DataType = typeof(double);
            this.coldsIronLadleL3DataTableTare_Weight.Namespace = "";
            // 
            // coldsIronLadleL3DataTableLadleID
            // 
            this.coldsIronLadleL3DataTableLadleID.Caption = "LadleID";
            this.coldsIronLadleL3DataTableLadleID.ColumnName = "LadleID";
            this.coldsIronLadleL3DataTableLadleID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableHeatID
            // 
            this.coldsIronLadleL3DataTableHeatID.Caption = "HeatID";
            this.coldsIronLadleL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsIronLadleL3DataTableHeatID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableRefra_Facturer
            // 
            this.coldsIronLadleL3DataTableRefra_Facturer.Caption = "Refra_Facturer";
            this.coldsIronLadleL3DataTableRefra_Facturer.ColumnName = "Refra_Facturer";
            this.coldsIronLadleL3DataTableRefra_Facturer.Namespace = "";
            // 
            // coldsIronLadleL3DataTableLadle_Grade
            // 
            this.coldsIronLadleL3DataTableLadle_Grade.Caption = "Ladle_Grade";
            this.coldsIronLadleL3DataTableLadle_Grade.ColumnName = "Ladle_Grade";
            this.coldsIronLadleL3DataTableLadle_Grade.Namespace = "";
            // 
            // coldsIronLadleL3DataTableLadle_Age
            // 
            this.coldsIronLadleL3DataTableLadle_Age.Caption = "Ladle_Age";
            this.coldsIronLadleL3DataTableLadle_Age.ColumnName = "Ladle_Age";
            this.coldsIronLadleL3DataTableLadle_Age.DataType = typeof(int);
            this.coldsIronLadleL3DataTableLadle_Age.Namespace = "";
            // 
            // coldsIronLadleL3DataTableNew_BOF_Flag
            // 
            this.coldsIronLadleL3DataTableNew_BOF_Flag.Caption = "New_BOF_Flag";
            this.coldsIronLadleL3DataTableNew_BOF_Flag.ColumnName = "New_BOF_Flag";
            this.coldsIronLadleL3DataTableNew_BOF_Flag.DataType = typeof(int);
            this.coldsIronLadleL3DataTableNew_BOF_Flag.Namespace = "";
            // 
            // coldsIronLadleL3DataTableTare_WT
            // 
            this.coldsIronLadleL3DataTableTare_WT.Caption = "Tare_WT";
            this.coldsIronLadleL3DataTableTare_WT.ColumnName = "Tare_WT";
            this.coldsIronLadleL3DataTableTare_WT.DataType = typeof(int);
            this.coldsIronLadleL3DataTableTare_WT.Namespace = "";
            // 
            // coldsIronLadleL3DataTableLadleType
            // 
            this.coldsIronLadleL3DataTableLadleType.Caption = "LadleType";
            this.coldsIronLadleL3DataTableLadleType.ColumnName = "LadleType";
            this.coldsIronLadleL3DataTableLadleType.DataType = typeof(int);
            this.coldsIronLadleL3DataTableLadleType.Namespace = "";
            // 
            // coldsIronLadleL3DataTableInnerID
            // 
            this.coldsIronLadleL3DataTableInnerID.Caption = "InnerID";
            this.coldsIronLadleL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsIronLadleL3DataTableInnerID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableWorkID
            // 
            this.coldsIronLadleL3DataTableWorkID.Caption = "WorkID";
            this.coldsIronLadleL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsIronLadleL3DataTableWorkID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableOnFireID
            // 
            this.coldsIronLadleL3DataTableOnFireID.Caption = "OnFireID";
            this.coldsIronLadleL3DataTableOnFireID.ColumnName = "OnFireID";
            this.coldsIronLadleL3DataTableOnFireID.DataType = typeof(int);
            this.coldsIronLadleL3DataTableOnFireID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableWorkFireID
            // 
            this.coldsIronLadleL3DataTableWorkFireID.Caption = "WorkFireID";
            this.coldsIronLadleL3DataTableWorkFireID.ColumnName = "WorkFireID";
            this.coldsIronLadleL3DataTableWorkFireID.DataType = typeof(int);
            this.coldsIronLadleL3DataTableWorkFireID.Namespace = "";
            // 
            // LadleAddShowFrm
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(306, 178);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LadleAddShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "钢包新增";
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLadleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadle)).EndInit();
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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Data.DataColumn coldsMainL3DataTableNote;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataSet dsLadle;
        private System.Data.DataTable schemadsIronLadle;
        private System.Data.DataColumn coldsIronLadleL3DataTableGUID;
        private System.Data.DataColumn coldsIronLadleL3DataTableName;
        private System.Data.DataColumn coldsIronLadleL3DataTableStatus;
        private System.Data.DataColumn coldsIronLadleL3DataTableComFlag;
        private System.Data.DataColumn coldsIronLadleL3DataTableTare_Weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLadleType;
        private AppSvrHMI.L3DataSet dsLadleType;
        private System.Data.DataTable schemadsLadleType;
        private System.Data.DataColumn coldsLadleTypeL3DataTablecode;
        private System.Data.DataColumn coldsLadleTypeL3DataTablecode_des;
        private System.Data.DataColumn coldsLadleTypeL3DataTablecode_val_long;
        private System.Windows.Forms.MaskedTextBox txtIronLadleNo;
        private System.Data.DataColumn coldsIronLadleL3DataTableLadleID;
        private System.Data.DataColumn coldsIronLadleL3DataTableHeatID;
        private System.Data.DataColumn coldsIronLadleL3DataTableRefra_Facturer;
        private System.Data.DataColumn coldsIronLadleL3DataTableLadle_Grade;
        private System.Data.DataColumn coldsIronLadleL3DataTableLadle_Age;
        private System.Data.DataColumn coldsIronLadleL3DataTableNew_BOF_Flag;
        private System.Data.DataColumn coldsIronLadleL3DataTableTare_WT;
        private System.Data.DataColumn coldsIronLadleL3DataTableLadleType;
        private System.Data.DataColumn coldsIronLadleL3DataTableInnerID;
        private System.Data.DataColumn coldsIronLadleL3DataTableWorkID;
        private System.Data.DataColumn coldsIronLadleL3DataTableOnFireID;
        private System.Data.DataColumn coldsIronLadleL3DataTableWorkFireID;
    }
}