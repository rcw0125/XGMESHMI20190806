namespace EquipMag.EquipAdjust
{
    partial class EquipAdjustMainFrm
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
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsEquipAdjustSet = new AppSvrHMI.L3DataSet();
            this.schemadsEquipAdjustSet = new System.Data.DataTable();
            this.coldsEquipAdjustSetL3DataTableGUID = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableName = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableLocation = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableLocation_Des = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableMeter = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableMeter_Size = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableRange = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTablePrecision = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableFactory = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableMeasure_ID = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableStandard_Equ = new System.Data.DataColumn();
            this.coldsEquipAdjustSetL3DataTableScale_Min = new System.Data.DataColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label42 = new System.Windows.Forms.Label();
            this.rtxtResult = new PxDataValid.PxRichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbLocation_Des = new PxDataValid.PxComboBox();
            this.txtMeasure_ID = new PxDataValid.PxTextBox();
            this.txtFactory = new PxDataValid.PxTextBox();
            this.txtScale_Min = new PxDataValid.PxTextBox();
            this.txtStandard_Equ = new PxDataValid.PxTextBox();
            this.txtPrecision = new PxDataValid.PxTextBox();
            this.txtRange = new PxDataValid.PxTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMeter_Size = new PxDataValid.PxTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOperator = new PxDataValid.PxTextBox();
            this.txtMeter = new PxDataValid.PxTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbLocation = new PxDataValid.PxComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dsLocation_Des = new AppSvrHMI.L3DataSet();
            this.schemadsLocation_Des = new System.Data.DataTable();
            this.coldsLocation_DesL3DataTableCode = new System.Data.DataColumn();
            this.coldsLocation_DesL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsLocation_DesL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsLocation_DesL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.dsLocation = new AppSvrHMI.L3DataSet();
            this.schemadsLocation = new System.Data.DataTable();
            this.coldsLocationL3DataTableCode = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Group = new System.Data.DataColumn();
            this.coldsLocationL3DataTableCode_Group_Des = new System.Data.DataColumn();
            this.dtCheck_Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquipAdjustSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEquipAdjustSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation_Des)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation_Des)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation)).BeginInit();
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
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsEquipAdjustSet;
            // 
            // dsEquipAdjustSet
            // 
            this.dsEquipAdjustSet.AutoSubscribe = false;
            this.dsEquipAdjustSet.DataSetName = "L3DataSet";
            this.dsEquipAdjustSet.DeleteMethod = null;
            this.dsEquipAdjustSet.InsertMethod = null;
            this.dsEquipAdjustSet.L3DataAdapter = this.Adapter;
            this.dsEquipAdjustSet.LoadEvent = "Click";
            this.dsEquipAdjustSet.LoadTrigger = null;
            this.dsEquipAdjustSet.RefreshValve = 1000;
            this.dsEquipAdjustSet.SourceCommand = null;
            this.dsEquipAdjustSet.SourceCondition = "Location is not null order by Location,Location_Des";
            this.dsEquipAdjustSet.SourceMethod = "";
            this.dsEquipAdjustSet.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsEquipAdjustSet.SourceURI = "XGMESLogic\\EquipMag\\CCalibration_Set";
            this.dsEquipAdjustSet.SubscribeTarget = "";
            this.dsEquipAdjustSet.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsEquipAdjustSet});
            this.dsEquipAdjustSet.UpdateEvent = "Click";
            this.dsEquipAdjustSet.UpdateMethod = null;
            this.dsEquipAdjustSet.UpdateTrigger = null;
            // 
            // schemadsEquipAdjustSet
            // 
            this.schemadsEquipAdjustSet.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsEquipAdjustSetL3DataTableGUID,
            this.coldsEquipAdjustSetL3DataTableName,
            this.coldsEquipAdjustSetL3DataTableLocation,
            this.coldsEquipAdjustSetL3DataTableLocation_Des,
            this.coldsEquipAdjustSetL3DataTableMeter,
            this.coldsEquipAdjustSetL3DataTableMeter_Size,
            this.coldsEquipAdjustSetL3DataTableRange,
            this.coldsEquipAdjustSetL3DataTablePrecision,
            this.coldsEquipAdjustSetL3DataTableFactory,
            this.coldsEquipAdjustSetL3DataTableMeasure_ID,
            this.coldsEquipAdjustSetL3DataTableStandard_Equ,
            this.coldsEquipAdjustSetL3DataTableScale_Min});
            this.schemadsEquipAdjustSet.TableName = "L3DataTable";
            // 
            // coldsEquipAdjustSetL3DataTableGUID
            // 
            this.coldsEquipAdjustSetL3DataTableGUID.Caption = "GUID";
            this.coldsEquipAdjustSetL3DataTableGUID.ColumnName = "GUID";
            this.coldsEquipAdjustSetL3DataTableGUID.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableName
            // 
            this.coldsEquipAdjustSetL3DataTableName.Caption = "Name";
            this.coldsEquipAdjustSetL3DataTableName.ColumnName = "Name";
            this.coldsEquipAdjustSetL3DataTableName.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableLocation
            // 
            this.coldsEquipAdjustSetL3DataTableLocation.Caption = "Location";
            this.coldsEquipAdjustSetL3DataTableLocation.ColumnName = "Location";
            this.coldsEquipAdjustSetL3DataTableLocation.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableLocation_Des
            // 
            this.coldsEquipAdjustSetL3DataTableLocation_Des.Caption = "Location_Des";
            this.coldsEquipAdjustSetL3DataTableLocation_Des.ColumnName = "Location_Des";
            this.coldsEquipAdjustSetL3DataTableLocation_Des.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableMeter
            // 
            this.coldsEquipAdjustSetL3DataTableMeter.Caption = "Meter";
            this.coldsEquipAdjustSetL3DataTableMeter.ColumnName = "Meter";
            this.coldsEquipAdjustSetL3DataTableMeter.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableMeter_Size
            // 
            this.coldsEquipAdjustSetL3DataTableMeter_Size.Caption = "Meter_Size";
            this.coldsEquipAdjustSetL3DataTableMeter_Size.ColumnName = "Meter_Size";
            this.coldsEquipAdjustSetL3DataTableMeter_Size.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableRange
            // 
            this.coldsEquipAdjustSetL3DataTableRange.Caption = "Range";
            this.coldsEquipAdjustSetL3DataTableRange.ColumnName = "Range";
            this.coldsEquipAdjustSetL3DataTableRange.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTablePrecision
            // 
            this.coldsEquipAdjustSetL3DataTablePrecision.Caption = "Precision";
            this.coldsEquipAdjustSetL3DataTablePrecision.ColumnName = "Precision";
            this.coldsEquipAdjustSetL3DataTablePrecision.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableFactory
            // 
            this.coldsEquipAdjustSetL3DataTableFactory.Caption = "Factory";
            this.coldsEquipAdjustSetL3DataTableFactory.ColumnName = "Factory";
            this.coldsEquipAdjustSetL3DataTableFactory.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableMeasure_ID
            // 
            this.coldsEquipAdjustSetL3DataTableMeasure_ID.Caption = "Measure_ID";
            this.coldsEquipAdjustSetL3DataTableMeasure_ID.ColumnName = "Measure_ID";
            this.coldsEquipAdjustSetL3DataTableMeasure_ID.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableStandard_Equ
            // 
            this.coldsEquipAdjustSetL3DataTableStandard_Equ.Caption = "Standard_Equ";
            this.coldsEquipAdjustSetL3DataTableStandard_Equ.ColumnName = "Standard_Equ";
            this.coldsEquipAdjustSetL3DataTableStandard_Equ.Namespace = "";
            // 
            // coldsEquipAdjustSetL3DataTableScale_Min
            // 
            this.coldsEquipAdjustSetL3DataTableScale_Min.Caption = "Scale_Min";
            this.coldsEquipAdjustSetL3DataTableScale_Min.ColumnName = "Scale_Min";
            this.coldsEquipAdjustSetL3DataTableScale_Min.Namespace = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 266);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dtCheck_Date);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.rtxtResult);
            this.tabPage1.Controls.Add(this.txtMeasure_ID);
            this.tabPage1.Controls.Add(this.txtFactory);
            this.tabPage1.Controls.Add(this.txtScale_Min);
            this.tabPage1.Controls.Add(this.txtStandard_Equ);
            this.tabPage1.Controls.Add(this.txtPrecision);
            this.tabPage1.Controls.Add(this.txtRange);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtMeter_Size);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtOperator);
            this.tabPage1.Controls.Add(this.txtMeter);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.cmbLocation);
            this.tabPage1.Controls.Add(this.cmbLocation_Des);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(486, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设备校准管理";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(28, 152);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(59, 12);
            this.label42.TabIndex = 74;
            this.label42.Text = "校准日期:";
            // 
            // rtxtResult
            // 
            this.rtxtResult.EnableNull = true;
            this.rtxtResult.ErropPr = this.errorProvider1;
            this.rtxtResult.Location = new System.Drawing.Point(93, 175);
            this.rtxtResult.MaxStrLength = 250;
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(364, 52);
            this.rtxtResult.TabIndex = 72;
            this.rtxtResult.Text = "";
            this.rtxtResult.ToolTipValid = this.toolTip1;
            this.rtxtResult.ValidEable = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // cmbLocation_Des
            // 
            this.cmbLocation_Des.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocation_Des.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation_Des.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Location_Des", true));
            this.cmbLocation_Des.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation_Des.EnableNull = true;
            this.cmbLocation_Des.ErropPr = this.errorProvider1;
            this.cmbLocation_Des.FormattingEnabled = true;
            this.cmbLocation_Des.Location = new System.Drawing.Point(93, 43);
            this.cmbLocation_Des.Name = "cmbLocation_Des";
            this.cmbLocation_Des.Size = new System.Drawing.Size(141, 20);
            this.cmbLocation_Des.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbLocation_Des, "必输项!");
            this.cmbLocation_Des.ToolTipValid = this.toolTip1;
            this.cmbLocation_Des.ValidEable = true;
            this.cmbLocation_Des.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_Des_SelectedIndexChanged);
            // 
            // txtMeasure_ID
            // 
            this.txtMeasure_ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Measure_ID", true));
            this.txtMeasure_ID.EnableNull = true;
            this.txtMeasure_ID.ErropPr = null;
            this.txtMeasure_ID.Length = 0;
            this.txtMeasure_ID.Location = new System.Drawing.Point(316, 95);
            this.txtMeasure_ID.Max = 0;
            this.txtMeasure_ID.MaxStrLength = 0;
            this.txtMeasure_ID.Min = 0;
            this.txtMeasure_ID.MinStrLength = 0;
            this.txtMeasure_ID.Name = "txtMeasure_ID";
            this.txtMeasure_ID.Precision = 0;
            this.txtMeasure_ID.ReadOnly = true;
            this.txtMeasure_ID.Size = new System.Drawing.Size(141, 21);
            this.txtMeasure_ID.TabIndex = 34;
            this.txtMeasure_ID.ToolTipValid = null;
            this.txtMeasure_ID.ValidEable = true;
            this.txtMeasure_ID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFactory
            // 
            this.txtFactory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Factory", true));
            this.txtFactory.EnableNull = true;
            this.txtFactory.ErropPr = null;
            this.txtFactory.Length = 0;
            this.txtFactory.Location = new System.Drawing.Point(316, 69);
            this.txtFactory.Max = 0;
            this.txtFactory.MaxStrLength = 0;
            this.txtFactory.Min = 0;
            this.txtFactory.MinStrLength = 0;
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Precision = 0;
            this.txtFactory.ReadOnly = true;
            this.txtFactory.Size = new System.Drawing.Size(141, 21);
            this.txtFactory.TabIndex = 34;
            this.txtFactory.ToolTipValid = null;
            this.txtFactory.ValidEable = true;
            this.txtFactory.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtScale_Min
            // 
            this.txtScale_Min.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Scale_Min", true));
            this.txtScale_Min.EnableNull = true;
            this.txtScale_Min.ErropPr = null;
            this.txtScale_Min.Length = 0;
            this.txtScale_Min.Location = new System.Drawing.Point(316, 121);
            this.txtScale_Min.Max = 0;
            this.txtScale_Min.MaxStrLength = 0;
            this.txtScale_Min.Min = 0;
            this.txtScale_Min.MinStrLength = 0;
            this.txtScale_Min.Name = "txtScale_Min";
            this.txtScale_Min.Precision = 0;
            this.txtScale_Min.ReadOnly = true;
            this.txtScale_Min.Size = new System.Drawing.Size(141, 21);
            this.txtScale_Min.TabIndex = 34;
            this.txtScale_Min.ToolTipValid = null;
            this.txtScale_Min.ValidEable = true;
            this.txtScale_Min.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtStandard_Equ
            // 
            this.txtStandard_Equ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Standard_Equ", true));
            this.txtStandard_Equ.EnableNull = true;
            this.txtStandard_Equ.ErropPr = null;
            this.txtStandard_Equ.Length = 0;
            this.txtStandard_Equ.Location = new System.Drawing.Point(93, 121);
            this.txtStandard_Equ.Max = 0;
            this.txtStandard_Equ.MaxStrLength = 0;
            this.txtStandard_Equ.Min = 0;
            this.txtStandard_Equ.MinStrLength = 0;
            this.txtStandard_Equ.Name = "txtStandard_Equ";
            this.txtStandard_Equ.Precision = 0;
            this.txtStandard_Equ.ReadOnly = true;
            this.txtStandard_Equ.Size = new System.Drawing.Size(141, 21);
            this.txtStandard_Equ.TabIndex = 34;
            this.txtStandard_Equ.ToolTipValid = null;
            this.txtStandard_Equ.ValidEable = true;
            this.txtStandard_Equ.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtPrecision
            // 
            this.txtPrecision.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Precision", true));
            this.txtPrecision.EnableNull = true;
            this.txtPrecision.ErropPr = null;
            this.txtPrecision.Length = 0;
            this.txtPrecision.Location = new System.Drawing.Point(93, 95);
            this.txtPrecision.Max = 0;
            this.txtPrecision.MaxStrLength = 0;
            this.txtPrecision.Min = 0;
            this.txtPrecision.MinStrLength = 0;
            this.txtPrecision.Name = "txtPrecision";
            this.txtPrecision.Precision = 0;
            this.txtPrecision.ReadOnly = true;
            this.txtPrecision.Size = new System.Drawing.Size(141, 21);
            this.txtPrecision.TabIndex = 34;
            this.txtPrecision.ToolTipValid = null;
            this.txtPrecision.ValidEable = true;
            this.txtPrecision.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtRange
            // 
            this.txtRange.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Range", true));
            this.txtRange.EnableNull = true;
            this.txtRange.ErropPr = null;
            this.txtRange.Length = 0;
            this.txtRange.Location = new System.Drawing.Point(93, 69);
            this.txtRange.Max = 0;
            this.txtRange.MaxStrLength = 0;
            this.txtRange.Min = 0;
            this.txtRange.MinStrLength = 0;
            this.txtRange.Name = "txtRange";
            this.txtRange.Precision = 0;
            this.txtRange.ReadOnly = true;
            this.txtRange.Size = new System.Drawing.Size(141, 21);
            this.txtRange.TabIndex = 34;
            this.txtRange.ToolTipValid = null;
            this.txtRange.ValidEable = true;
            this.txtRange.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(251, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 71;
            this.label7.Text = "计量编号:";
            // 
            // txtMeter_Size
            // 
            this.txtMeter_Size.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Meter_Size", true));
            this.txtMeter_Size.EnableNull = true;
            this.txtMeter_Size.ErropPr = null;
            this.txtMeter_Size.Length = 0;
            this.txtMeter_Size.Location = new System.Drawing.Point(316, 43);
            this.txtMeter_Size.Max = 0;
            this.txtMeter_Size.MaxStrLength = 0;
            this.txtMeter_Size.Min = 0;
            this.txtMeter_Size.MinStrLength = 0;
            this.txtMeter_Size.Name = "txtMeter_Size";
            this.txtMeter_Size.Precision = 0;
            this.txtMeter_Size.ReadOnly = true;
            this.txtMeter_Size.Size = new System.Drawing.Size(141, 21);
            this.txtMeter_Size.TabIndex = 34;
            this.txtMeter_Size.ToolTipValid = null;
            this.txtMeter_Size.ValidEable = true;
            this.txtMeter_Size.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(239, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 71;
            this.label9.Text = "最小分度值:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(275, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 71;
            this.label6.Text = "厂家:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(40, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 71;
            this.label8.Text = "标准器:";
            // 
            // txtOperator
            // 
            this.txtOperator.EnableNull = true;
            this.txtOperator.ErropPr = null;
            this.txtOperator.Length = 0;
            this.txtOperator.Location = new System.Drawing.Point(316, 148);
            this.txtOperator.Max = 0;
            this.txtOperator.MaxStrLength = 0;
            this.txtOperator.Min = 0;
            this.txtOperator.MinStrLength = 0;
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Precision = 0;
            this.txtOperator.ReadOnly = true;
            this.txtOperator.Size = new System.Drawing.Size(141, 21);
            this.txtOperator.TabIndex = 34;
            this.txtOperator.ToolTipValid = null;
            this.txtOperator.ValidEable = true;
            this.txtOperator.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtMeter
            // 
            this.txtMeter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Meter", true));
            this.txtMeter.EnableNull = true;
            this.txtMeter.ErropPr = null;
            this.txtMeter.Length = 0;
            this.txtMeter.Location = new System.Drawing.Point(316, 17);
            this.txtMeter.Max = 0;
            this.txtMeter.MaxStrLength = 0;
            this.txtMeter.Min = 0;
            this.txtMeter.MinStrLength = 0;
            this.txtMeter.Name = "txtMeter";
            this.txtMeter.Precision = 0;
            this.txtMeter.ReadOnly = true;
            this.txtMeter.Size = new System.Drawing.Size(141, 21);
            this.txtMeter.TabIndex = 34;
            this.txtMeter.ToolTipValid = null;
            this.txtMeter.ValidEable = true;
            this.txtMeter.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(40, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 71;
            this.label4.Text = "准确度:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 71;
            this.label3.Text = "测量范围:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(251, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 71;
            this.label2.Text = "仪表型号:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(263, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 12);
            this.label19.TabIndex = 71;
            this.label19.Text = "责任人:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Location = new System.Drawing.Point(28, 178);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(59, 12);
            this.label46.TabIndex = 60;
            this.label46.Text = "校验结论:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Location = new System.Drawing.Point(251, 21);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(59, 12);
            this.label47.TabIndex = 71;
            this.label47.Text = "仪表名称:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "Location", true));
            this.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocation.EnableNull = true;
            this.cmbLocation.ErropPr = this.errorProvider1;
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(93, 17);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(141, 20);
            this.cmbLocation.TabIndex = 1;
            this.cmbLocation.ToolTipValid = this.toolTip1;
            this.cmbLocation.ValidEable = true;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "处所描述:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(52, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 37;
            this.label5.Text = "处所:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(397, 275);
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
            this.btnConfirm.Location = new System.Drawing.Point(316, 275);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dsLocation_Des
            // 
            this.dsLocation_Des.AutoSubscribe = false;
            this.dsLocation_Des.DataSetName = "L3DataSet";
            this.dsLocation_Des.DeleteMethod = "";
            this.dsLocation_Des.InsertMethod = "";
            this.dsLocation_Des.L3DataAdapter = this.Adapter;
            this.dsLocation_Des.LoadEvent = "Click";
            this.dsLocation_Des.LoadTrigger = null;
            this.dsLocation_Des.RefreshValve = 1000;
            this.dsLocation_Des.SourceCommand = null;
            this.dsLocation_Des.SourceCondition = "Code_Group = \'Location_Des\' order by Code";
            this.dsLocation_Des.SourceMethod = "";
            this.dsLocation_Des.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLocation_Des.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLocation_Des.SubscribeTarget = "";
            this.dsLocation_Des.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLocation_Des});
            this.dsLocation_Des.UpdateEvent = "Click";
            this.dsLocation_Des.UpdateMethod = "";
            this.dsLocation_Des.UpdateTrigger = null;
            // 
            // schemadsLocation_Des
            // 
            this.schemadsLocation_Des.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLocation_DesL3DataTableCode,
            this.coldsLocation_DesL3DataTableCode_Des,
            this.coldsLocation_DesL3DataTableCode_Group,
            this.coldsLocation_DesL3DataTableCode_Group_Des});
            this.schemadsLocation_Des.TableName = "L3DataTable";
            // 
            // coldsLocation_DesL3DataTableCode
            // 
            this.coldsLocation_DesL3DataTableCode.Caption = "Code";
            this.coldsLocation_DesL3DataTableCode.ColumnName = "Code";
            this.coldsLocation_DesL3DataTableCode.Namespace = "";
            // 
            // coldsLocation_DesL3DataTableCode_Des
            // 
            this.coldsLocation_DesL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLocation_DesL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLocation_DesL3DataTableCode_Des.Namespace = "";
            // 
            // coldsLocation_DesL3DataTableCode_Group
            // 
            this.coldsLocation_DesL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsLocation_DesL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsLocation_DesL3DataTableCode_Group.Namespace = "";
            // 
            // coldsLocation_DesL3DataTableCode_Group_Des
            // 
            this.coldsLocation_DesL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsLocation_DesL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsLocation_DesL3DataTableCode_Group_Des.Namespace = "";
            // 
            // dsLocation
            // 
            this.dsLocation.AutoSubscribe = false;
            this.dsLocation.DataSetName = "L3DataSet";
            this.dsLocation.DeleteMethod = "";
            this.dsLocation.InsertMethod = "";
            this.dsLocation.L3DataAdapter = this.Adapter;
            this.dsLocation.LoadEvent = "Click";
            this.dsLocation.LoadTrigger = null;
            this.dsLocation.RefreshValve = 1000;
            this.dsLocation.SourceCommand = null;
            this.dsLocation.SourceCondition = "Code_Group = \'Location\' order by Code";
            this.dsLocation.SourceMethod = "";
            this.dsLocation.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLocation.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsLocation.SubscribeTarget = "";
            this.dsLocation.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLocation});
            this.dsLocation.UpdateEvent = "Click";
            this.dsLocation.UpdateMethod = "";
            this.dsLocation.UpdateTrigger = null;
            // 
            // schemadsLocation
            // 
            this.schemadsLocation.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLocationL3DataTableCode,
            this.coldsLocationL3DataTableCode_Des,
            this.coldsLocationL3DataTableCode_Group,
            this.coldsLocationL3DataTableCode_Group_Des});
            this.schemadsLocation.TableName = "L3DataTable";
            // 
            // coldsLocationL3DataTableCode
            // 
            this.coldsLocationL3DataTableCode.Caption = "Code";
            this.coldsLocationL3DataTableCode.ColumnName = "Code";
            this.coldsLocationL3DataTableCode.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Des
            // 
            this.coldsLocationL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsLocationL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsLocationL3DataTableCode_Des.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Group
            // 
            this.coldsLocationL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsLocationL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsLocationL3DataTableCode_Group.Namespace = "";
            // 
            // coldsLocationL3DataTableCode_Group_Des
            // 
            this.coldsLocationL3DataTableCode_Group_Des.Caption = "Code_Group_Des";
            this.coldsLocationL3DataTableCode_Group_Des.ColumnName = "Code_Group_Des";
            this.coldsLocationL3DataTableCode_Group_Des.Namespace = "";
            // 
            // dtCheck_Date
            // 
            this.dtCheck_Date.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtCheck_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheck_Date.Location = new System.Drawing.Point(93, 147);
            this.dtCheck_Date.Name = "dtCheck_Date";
            this.dtCheck_Date.Size = new System.Drawing.Size(141, 21);
            this.dtCheck_Date.TabIndex = 75;
            // 
            // EquipAdjustMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EquipAdjustMainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设备校准管理维护界面";
            this.Load += new System.EventHandler(this.FinLadleBuildShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquipAdjustSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsEquipAdjustSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation_Des)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation_Des)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLocation)).EndInit();
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
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private PxDataValid.PxRichTextBox rtxtResult;
        private PxDataValid.PxTextBox txtMeter;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private PxDataValid.PxTextBox txtFactory;
        private PxDataValid.PxTextBox txtPrecision;
        private PxDataValid.PxTextBox txtRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox txtMeasure_ID;
        private PxDataValid.PxTextBox txtScale_Min;
        private PxDataValid.PxTextBox txtStandard_Equ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label42;
        private PxDataValid.PxTextBox txtOperator;
        private System.Windows.Forms.Label label19;
        private AppSvrHMI.L3DataSet dsEquipAdjustSet;
        private System.Data.DataTable schemadsEquipAdjustSet;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableGUID;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableName;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableLocation;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableLocation_Des;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableMeter;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableMeter_Size;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableRange;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTablePrecision;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableFactory;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableMeasure_ID;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableStandard_Equ;
        private System.Data.DataColumn coldsEquipAdjustSetL3DataTableScale_Min;
        private PxDataValid.PxTextBox txtMeter_Size;
        private PxDataValid.PxComboBox cmbLocation;
        private PxDataValid.PxComboBox cmbLocation_Des;
        private AppSvrHMI.L3DataSet dsLocation_Des;
        private System.Data.DataTable schemadsLocation_Des;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode_Des;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode_Group;
        private System.Data.DataColumn coldsLocation_DesL3DataTableCode_Group_Des;
        private AppSvrHMI.L3DataSet dsLocation;
        private System.Data.DataTable schemadsLocation;
        private System.Data.DataColumn coldsLocationL3DataTableCode;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Des;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Group;
        private System.Data.DataColumn coldsLocationL3DataTableCode_Group_Des;
        private System.Windows.Forms.DateTimePicker dtCheck_Date;
    }
}