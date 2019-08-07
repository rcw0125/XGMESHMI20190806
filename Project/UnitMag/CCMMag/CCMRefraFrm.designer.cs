namespace UnitMag.CCMMag
{
    partial class CCMRefraFrm
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
            this.dsSmoothBlock = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsSmoothBlock = new System.Data.DataTable();
            this.coldsSmoothBlockL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableBlockID = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableBlock_Life = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableFactory = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableEnd_Time = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableBlock_Size = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableReason = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsSmoothBlockL3DataTableEquipmentType = new System.Data.DataColumn();
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dbxTreatNO = new AppSvrHMI.L3DataBox();
            this.txtCCMID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdRefra = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpdsRefra = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myLine = new buttonHide.MyLine();
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.cmbFactory = new System.Windows.Forms.ComboBox();
            this.txtHeatID = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnStrandNo4 = new System.Windows.Forms.RadioButton();
            this.rbtnStrandNo3 = new System.Windows.Forms.RadioButton();
            this.rbtnStrandNo2 = new System.Windows.Forms.RadioButton();
            this.rbtnStrandNo1 = new System.Windows.Forms.RadioButton();
            this.dsOffLineReason = new AppSvrHMI.L3DataSet();
            this.schemadsOffLineReason = new System.Data.DataTable();
            this.coldsOffLineReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsOffLineReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsOffLineReasonL3DataTableCode_Group = new System.Data.DataColumn();
            this.bsSmoothBlockReason = new System.Windows.Forms.BindingSource(this.components);
            this.bsHurryGapReason = new System.Windows.Forms.BindingSource(this.components);
            this.bsBigGapReason = new System.Windows.Forms.BindingSource(this.components);
            this.dsRefraFac = new AppSvrHMI.L3DataSet();
            this.schemadsRefraFac = new System.Data.DataTable();
            this.coldsRefraFacL3DataTableMatFactory = new System.Data.DataColumn();
            this.coldsRefraFacL3DataTableMATNAME = new System.Data.DataColumn();
            this.bsSmoothBlockFac = new System.Windows.Forms.BindingSource(this.components);
            this.bsHurryGapFac = new System.Windows.Forms.BindingSource(this.components);
            this.bsBigGapFac = new System.Windows.Forms.BindingSource(this.components);
            this.dsHurryGap = new AppSvrHMI.L3DataSet();
            this.schemadsHurryGap = new System.Data.DataTable();
            this.coldsHurryGapL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableGapID = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableGapLife = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableFactory = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableStart_Time = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableReason = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableMatType = new System.Data.DataColumn();
            this.coldsHurryGapL3DataTableEquipmentType = new System.Data.DataColumn();
            this.dsBigGap = new AppSvrHMI.L3DataSet();
            this.schemadsBigGap = new System.Data.DataTable();
            this.coldsBigGapL3DataTableCCMID = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableStrandNo = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableGapID = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableFactory = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableMatType = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableGapLife = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableChangeTime = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableReason = new System.Data.DataColumn();
            this.coldsBigGapL3DataTableEquipmentType = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmoothBlockReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHurryGapReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmoothBlockFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHurryGapFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGap)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSmoothBlock
            // 
            this.dsSmoothBlock.AutoSubscribe = false;
            this.dsSmoothBlock.DataSetName = "L3DataSet";
            this.dsSmoothBlock.DeleteMethod = null;
            this.dsSmoothBlock.InsertMethod = null;
            this.dsSmoothBlock.L3DataAdapter = this.Adapter;
            this.dsSmoothBlock.LoadEvent = "Click";
            this.dsSmoothBlock.LoadTrigger = null;
            this.dsSmoothBlock.RefreshValve = 1000;
            this.dsSmoothBlock.SourceCommand = null;
            this.dsSmoothBlock.SourceCondition = "";
            this.dsSmoothBlock.SourceMethod = "";
            this.dsSmoothBlock.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsSmoothBlock.SourceURI = "";
            this.dsSmoothBlock.SubscribeTarget = null;
            this.dsSmoothBlock.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSmoothBlock});
            this.dsSmoothBlock.UpdateEvent = "Click";
            this.dsSmoothBlock.UpdateMethod = null;
            this.dsSmoothBlock.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsSmoothBlock
            // 
            this.schemadsSmoothBlock.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSmoothBlockL3DataTableCCMID,
            this.coldsSmoothBlockL3DataTableStrandNo,
            this.coldsSmoothBlockL3DataTableBlockID,
            this.coldsSmoothBlockL3DataTableBlock_Life,
            this.coldsSmoothBlockL3DataTableFactory,
            this.coldsSmoothBlockL3DataTableStart_Time,
            this.coldsSmoothBlockL3DataTableEnd_Time,
            this.coldsSmoothBlockL3DataTableBlock_Size,
            this.coldsSmoothBlockL3DataTableReason,
            this.coldsSmoothBlockL3DataTableHeatID,
            this.coldsSmoothBlockL3DataTableEquipmentType});
            this.schemadsSmoothBlock.TableName = "L3DataTable";
            // 
            // coldsSmoothBlockL3DataTableCCMID
            // 
            this.coldsSmoothBlockL3DataTableCCMID.Caption = "CCMID";
            this.coldsSmoothBlockL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsSmoothBlockL3DataTableCCMID.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableStrandNo
            // 
            this.coldsSmoothBlockL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsSmoothBlockL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsSmoothBlockL3DataTableStrandNo.DataType = typeof(int);
            this.coldsSmoothBlockL3DataTableStrandNo.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableBlockID
            // 
            this.coldsSmoothBlockL3DataTableBlockID.Caption = "BlockID";
            this.coldsSmoothBlockL3DataTableBlockID.ColumnName = "BlockID";
            this.coldsSmoothBlockL3DataTableBlockID.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableBlock_Life
            // 
            this.coldsSmoothBlockL3DataTableBlock_Life.Caption = "Block_Life";
            this.coldsSmoothBlockL3DataTableBlock_Life.ColumnName = "Block_Life";
            this.coldsSmoothBlockL3DataTableBlock_Life.DataType = typeof(int);
            this.coldsSmoothBlockL3DataTableBlock_Life.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableFactory
            // 
            this.coldsSmoothBlockL3DataTableFactory.Caption = "Factory";
            this.coldsSmoothBlockL3DataTableFactory.ColumnName = "Factory";
            this.coldsSmoothBlockL3DataTableFactory.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableStart_Time
            // 
            this.coldsSmoothBlockL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsSmoothBlockL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsSmoothBlockL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsSmoothBlockL3DataTableStart_Time.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableEnd_Time
            // 
            this.coldsSmoothBlockL3DataTableEnd_Time.Caption = "End_Time";
            this.coldsSmoothBlockL3DataTableEnd_Time.ColumnName = "End_Time";
            this.coldsSmoothBlockL3DataTableEnd_Time.DataType = typeof(System.DateTime);
            this.coldsSmoothBlockL3DataTableEnd_Time.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableBlock_Size
            // 
            this.coldsSmoothBlockL3DataTableBlock_Size.Caption = "Block_Size";
            this.coldsSmoothBlockL3DataTableBlock_Size.ColumnName = "Block_Size";
            this.coldsSmoothBlockL3DataTableBlock_Size.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableReason
            // 
            this.coldsSmoothBlockL3DataTableReason.Caption = "Reason";
            this.coldsSmoothBlockL3DataTableReason.ColumnName = "Reason";
            this.coldsSmoothBlockL3DataTableReason.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableHeatID
            // 
            this.coldsSmoothBlockL3DataTableHeatID.Caption = "HeatID";
            this.coldsSmoothBlockL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsSmoothBlockL3DataTableHeatID.Namespace = "";
            // 
            // coldsSmoothBlockL3DataTableEquipmentType
            // 
            this.coldsSmoothBlockL3DataTableEquipmentType.Caption = "EquipmentType";
            this.coldsSmoothBlockL3DataTableEquipmentType.ColumnName = "EquipmentType";
            this.coldsSmoothBlockL3DataTableEquipmentType.DataType = typeof(short);
            this.coldsSmoothBlockL3DataTableEquipmentType.Namespace = "";
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(276, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 75;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(357, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dbxTreatNO);
            this.panel3.Controls.Add(this.txtCCMID);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 29);
            this.panel3.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 76;
            this.label2.Text = "处理号:";
            // 
            // dbxTreatNO
            // 
            this.dbxTreatNO.DataFormat = null;
            this.dbxTreatNO.DataObject = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.dbxTreatNO.DataProperty = "TreatNo";
            this.dbxTreatNO.DataType = AppSvrHMI.L3DataBoxType.dtText;
            this.dbxTreatNO.L3DataAdapter = this.Adapter;
            this.dbxTreatNO.Location = new System.Drawing.Point(269, 4);
            this.dbxTreatNO.Name = "dbxTreatNO";
            this.dbxTreatNO.ReadOnly = true;
            this.dbxTreatNO.Size = new System.Drawing.Size(100, 21);
            this.dbxTreatNO.TabIndex = 75;
            this.dbxTreatNO.Value = null;
            // 
            // txtCCMID
            // 
            this.txtCCMID.Location = new System.Drawing.Point(110, 4);
            this.txtCCMID.Name = "txtCCMID";
            this.txtCCMID.ReadOnly = true;
            this.txtCCMID.Size = new System.Drawing.Size(100, 21);
            this.txtCCMID.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(60, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 73;
            this.label6.Text = "铸机号:";
            // 
            // cmdRefra
            // 
            this.cmdRefra.Adapter = this.Adapter;
            this.cmdRefra.MergeReturnTarget = false;
            this.cmdRefra.Method = "ChangeCCMEquipment";
            this.cmdRefra.Object = "XGMESLogic\\CCMMag\\CCCM_Unit_Mag\\{CCMID}";
            this.cmdRefra.Parameters.Add(this.l3cmdpdsRefra);
            this.cmdRefra.ReturnTarget = null;
            this.cmdRefra.ReturnTargetProperty = null;
            this.cmdRefra.Trigger = null;
            this.cmdRefra.TriggerEvent = "Click";
            // 
            // l3cmdpdsRefra
            // 
            this.l3cmdpdsRefra.AcceptAfterExecuted = false;
            this.l3cmdpdsRefra.ConstantValue = null;
            this.l3cmdpdsRefra.MergeTarget = false;
            this.l3cmdpdsRefra.SourceFilter = null;
            this.l3cmdpdsRefra.SourceObject = null;
            this.l3cmdpdsRefra.SourceProperty = "";
            this.l3cmdpdsRefra.TargetObject = null;
            this.l3cmdpdsRefra.TargetProperty = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 252);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 43);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 223);
            this.tabControl1.TabIndex = 84;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.myLine);
            this.tabPage1.Controls.Add(this.cmbReason);
            this.tabPage1.Controls.Add(this.cmbFactory);
            this.tabPage1.Controls.Add(this.txtHeatID);
            this.tabPage1.Controls.Add(this.txtSize);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.rbtnStrandNo4);
            this.tabPage1.Controls.Add(this.rbtnStrandNo3);
            this.tabPage1.Controls.Add(this.rbtnStrandNo2);
            this.tabPage1.Controls.Add(this.rbtnStrandNo1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "耐材信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myLine
            // 
            this.myLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.myLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.myLine.Location = new System.Drawing.Point(61, 39);
            this.myLine.Name = "myLine";
            this.myLine.Size = new System.Drawing.Size(300, 3);
            this.myLine.TabIndex = 5;
            // 
            // cmbReason
            // 
            this.cmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(142, 142);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(185, 20);
            this.cmbReason.TabIndex = 4;
            // 
            // cmbFactory
            // 
            this.cmbFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFactory.FormattingEnabled = true;
            this.cmbFactory.Location = new System.Drawing.Point(142, 89);
            this.cmbFactory.Name = "cmbFactory";
            this.cmbFactory.Size = new System.Drawing.Size(185, 20);
            this.cmbFactory.TabIndex = 4;
            // 
            // txtHeatID
            // 
            this.txtHeatID.Location = new System.Drawing.Point(142, 62);
            this.txtHeatID.Name = "txtHeatID";
            this.txtHeatID.ReadOnly = true;
            this.txtHeatID.Size = new System.Drawing.Size(185, 21);
            this.txtHeatID.TabIndex = 3;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(142, 115);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(185, 21);
            this.txtSize.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "换下原因:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "规格/材质:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "炉号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "耐材厂家:";
            // 
            // rbtnStrandNo4
            // 
            this.rbtnStrandNo4.AutoSize = true;
            this.rbtnStrandNo4.Location = new System.Drawing.Point(318, 18);
            this.rbtnStrandNo4.Name = "rbtnStrandNo4";
            this.rbtnStrandNo4.Size = new System.Drawing.Size(41, 16);
            this.rbtnStrandNo4.TabIndex = 1;
            this.rbtnStrandNo4.Text = "4流";
            this.rbtnStrandNo4.UseVisualStyleBackColor = true;
            this.rbtnStrandNo4.CheckedChanged += new System.EventHandler(this.rbtnStrandNo_CheckedChanged);
            // 
            // rbtnStrandNo3
            // 
            this.rbtnStrandNo3.AutoSize = true;
            this.rbtnStrandNo3.Location = new System.Drawing.Point(233, 18);
            this.rbtnStrandNo3.Name = "rbtnStrandNo3";
            this.rbtnStrandNo3.Size = new System.Drawing.Size(41, 16);
            this.rbtnStrandNo3.TabIndex = 1;
            this.rbtnStrandNo3.Text = "3流";
            this.rbtnStrandNo3.UseVisualStyleBackColor = true;
            this.rbtnStrandNo3.CheckedChanged += new System.EventHandler(this.rbtnStrandNo_CheckedChanged);
            // 
            // rbtnStrandNo2
            // 
            this.rbtnStrandNo2.AutoSize = true;
            this.rbtnStrandNo2.Location = new System.Drawing.Point(148, 18);
            this.rbtnStrandNo2.Name = "rbtnStrandNo2";
            this.rbtnStrandNo2.Size = new System.Drawing.Size(41, 16);
            this.rbtnStrandNo2.TabIndex = 1;
            this.rbtnStrandNo2.Text = "2流";
            this.rbtnStrandNo2.UseVisualStyleBackColor = true;
            this.rbtnStrandNo2.CheckedChanged += new System.EventHandler(this.rbtnStrandNo_CheckedChanged);
            // 
            // rbtnStrandNo1
            // 
            this.rbtnStrandNo1.AutoSize = true;
            this.rbtnStrandNo1.Location = new System.Drawing.Point(63, 18);
            this.rbtnStrandNo1.Name = "rbtnStrandNo1";
            this.rbtnStrandNo1.Size = new System.Drawing.Size(41, 16);
            this.rbtnStrandNo1.TabIndex = 0;
            this.rbtnStrandNo1.Text = "1流";
            this.rbtnStrandNo1.UseVisualStyleBackColor = true;
            this.rbtnStrandNo1.CheckedChanged += new System.EventHandler(this.rbtnStrandNo_CheckedChanged);
            // 
            // dsOffLineReason
            // 
            this.dsOffLineReason.AutoSubscribe = false;
            this.dsOffLineReason.DataSetName = "L3DataSet";
            this.dsOffLineReason.DeleteMethod = "";
            this.dsOffLineReason.InsertMethod = "";
            this.dsOffLineReason.L3DataAdapter = this.Adapter;
            this.dsOffLineReason.LoadEvent = "";
            this.dsOffLineReason.LoadTrigger = null;
            this.dsOffLineReason.RefreshValve = 1000;
            this.dsOffLineReason.SourceCommand = null;
            this.dsOffLineReason.SourceCondition = "Code_Group = \'SMOOTH_BLOCK_OFF_REASON\' or Code_Group = \'HURRYGAP_OFF_REASON\' or C" +
                "ode_Group = \'BIGGAP_OFF_REASON\'";
            this.dsOffLineReason.SourceMethod = "";
            this.dsOffLineReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOffLineReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsOffLineReason.SubscribeTarget = null;
            this.dsOffLineReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOffLineReason});
            this.dsOffLineReason.UpdateEvent = "";
            this.dsOffLineReason.UpdateMethod = "";
            this.dsOffLineReason.UpdateTrigger = null;
            // 
            // schemadsOffLineReason
            // 
            this.schemadsOffLineReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOffLineReasonL3DataTableCode,
            this.coldsOffLineReasonL3DataTableCode_Des,
            this.coldsOffLineReasonL3DataTableCode_Group});
            this.schemadsOffLineReason.TableName = "L3DataTable";
            // 
            // coldsOffLineReasonL3DataTableCode
            // 
            this.coldsOffLineReasonL3DataTableCode.Caption = "Code";
            this.coldsOffLineReasonL3DataTableCode.ColumnName = "Code";
            this.coldsOffLineReasonL3DataTableCode.Namespace = "";
            // 
            // coldsOffLineReasonL3DataTableCode_Des
            // 
            this.coldsOffLineReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.Namespace = "";
            // 
            // coldsOffLineReasonL3DataTableCode_Group
            // 
            this.coldsOffLineReasonL3DataTableCode_Group.Caption = "Code_Group";
            this.coldsOffLineReasonL3DataTableCode_Group.ColumnName = "Code_Group";
            this.coldsOffLineReasonL3DataTableCode_Group.Namespace = "";
            // 
            // bsSmoothBlockReason
            // 
            this.bsSmoothBlockReason.DataMember = "L3DataTable";
            this.bsSmoothBlockReason.DataSource = this.dsOffLineReason;
            this.bsSmoothBlockReason.Filter = "Code_Group = \'SMOOTH_BLOCK_OFF_REASON\'";
            this.bsSmoothBlockReason.Sort = "Code";
            // 
            // bsHurryGapReason
            // 
            this.bsHurryGapReason.DataMember = "L3DataTable";
            this.bsHurryGapReason.DataSource = this.dsOffLineReason;
            this.bsHurryGapReason.Filter = "Code_Group = \'HURRYGAP_OFF_REASON\'";
            this.bsHurryGapReason.Sort = "Code";
            // 
            // bsBigGapReason
            // 
            this.bsBigGapReason.DataMember = "L3DataTable";
            this.bsBigGapReason.DataSource = this.dsOffLineReason;
            this.bsBigGapReason.Filter = "Code_Group = \'BIGGAP_OFF_REASON\'";
            this.bsBigGapReason.Sort = "Code";
            // 
            // dsRefraFac
            // 
            this.dsRefraFac.AutoSubscribe = false;
            this.dsRefraFac.DataSetName = "L3DataSet";
            this.dsRefraFac.DeleteMethod = "";
            this.dsRefraFac.InsertMethod = "";
            this.dsRefraFac.L3DataAdapter = this.Adapter;
            this.dsRefraFac.LoadEvent = "";
            this.dsRefraFac.LoadTrigger = null;
            this.dsRefraFac.RefreshValve = 1000;
            this.dsRefraFac.SourceCommand = null;
            this.dsRefraFac.SourceCondition = "MATGROUP_CODE = \'TundishFac\' and (MATNAME = \'滑块\' or MATNAME = \'快换水口\' or MATNAME =" +
                " \'大包水口\')";
            this.dsRefraFac.SourceMethod = "";
            this.dsRefraFac.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsRefraFac.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_EQMatFac";
            this.dsRefraFac.SubscribeTarget = null;
            this.dsRefraFac.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRefraFac});
            this.dsRefraFac.UpdateEvent = "";
            this.dsRefraFac.UpdateMethod = "";
            this.dsRefraFac.UpdateTrigger = null;
            // 
            // schemadsRefraFac
            // 
            this.schemadsRefraFac.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRefraFacL3DataTableMatFactory,
            this.coldsRefraFacL3DataTableMATNAME});
            this.schemadsRefraFac.TableName = "L3DataTable";
            // 
            // coldsRefraFacL3DataTableMatFactory
            // 
            this.coldsRefraFacL3DataTableMatFactory.Caption = "MatFactory";
            this.coldsRefraFacL3DataTableMatFactory.ColumnName = "MatFactory";
            this.coldsRefraFacL3DataTableMatFactory.Namespace = "";
            // 
            // coldsRefraFacL3DataTableMATNAME
            // 
            this.coldsRefraFacL3DataTableMATNAME.Caption = "MATNAME";
            this.coldsRefraFacL3DataTableMATNAME.ColumnName = "MATNAME";
            this.coldsRefraFacL3DataTableMATNAME.Namespace = "";
            // 
            // bsSmoothBlockFac
            // 
            this.bsSmoothBlockFac.DataMember = "L3DataTable";
            this.bsSmoothBlockFac.DataSource = this.dsRefraFac;
            this.bsSmoothBlockFac.Filter = "MATNAME = \'滑块\'";
            // 
            // bsHurryGapFac
            // 
            this.bsHurryGapFac.DataMember = "L3DataTable";
            this.bsHurryGapFac.DataSource = this.dsRefraFac;
            this.bsHurryGapFac.Filter = "MATNAME = \'快换水口\'";
            // 
            // bsBigGapFac
            // 
            this.bsBigGapFac.DataMember = "L3DataTable";
            this.bsBigGapFac.DataSource = this.dsRefraFac;
            this.bsBigGapFac.Filter = "MATNAME = \'大包水口\'";
            // 
            // dsHurryGap
            // 
            this.dsHurryGap.AutoSubscribe = false;
            this.dsHurryGap.DataSetName = "L3DataSet";
            this.dsHurryGap.DeleteMethod = "";
            this.dsHurryGap.InsertMethod = "";
            this.dsHurryGap.L3DataAdapter = null;
            this.dsHurryGap.LoadEvent = "";
            this.dsHurryGap.LoadTrigger = null;
            this.dsHurryGap.RefreshValve = 1000;
            this.dsHurryGap.SourceCommand = null;
            this.dsHurryGap.SourceCondition = "";
            this.dsHurryGap.SourceMethod = "";
            this.dsHurryGap.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsHurryGap.SourceURI = "";
            this.dsHurryGap.SubscribeTarget = null;
            this.dsHurryGap.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsHurryGap});
            this.dsHurryGap.UpdateEvent = "";
            this.dsHurryGap.UpdateMethod = "";
            this.dsHurryGap.UpdateTrigger = null;
            // 
            // schemadsHurryGap
            // 
            this.schemadsHurryGap.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsHurryGapL3DataTableCCMID,
            this.coldsHurryGapL3DataTableStrandNo,
            this.coldsHurryGapL3DataTableGapID,
            this.coldsHurryGapL3DataTableGapLife,
            this.coldsHurryGapL3DataTableFactory,
            this.coldsHurryGapL3DataTableStart_Time,
            this.coldsHurryGapL3DataTableReason,
            this.coldsHurryGapL3DataTableHeatID,
            this.coldsHurryGapL3DataTableMatType,
            this.coldsHurryGapL3DataTableEquipmentType});
            this.schemadsHurryGap.TableName = "L3DataTable";
            // 
            // coldsHurryGapL3DataTableCCMID
            // 
            this.coldsHurryGapL3DataTableCCMID.Caption = "CCMID";
            this.coldsHurryGapL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsHurryGapL3DataTableCCMID.Namespace = "";
            // 
            // coldsHurryGapL3DataTableStrandNo
            // 
            this.coldsHurryGapL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsHurryGapL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsHurryGapL3DataTableStrandNo.DataType = typeof(int);
            this.coldsHurryGapL3DataTableStrandNo.Namespace = "";
            // 
            // coldsHurryGapL3DataTableGapID
            // 
            this.coldsHurryGapL3DataTableGapID.Caption = "GapID";
            this.coldsHurryGapL3DataTableGapID.ColumnName = "GapID";
            this.coldsHurryGapL3DataTableGapID.Namespace = "";
            // 
            // coldsHurryGapL3DataTableGapLife
            // 
            this.coldsHurryGapL3DataTableGapLife.Caption = "GapLife";
            this.coldsHurryGapL3DataTableGapLife.ColumnName = "GapLife";
            this.coldsHurryGapL3DataTableGapLife.DataType = typeof(int);
            this.coldsHurryGapL3DataTableGapLife.Namespace = "";
            // 
            // coldsHurryGapL3DataTableFactory
            // 
            this.coldsHurryGapL3DataTableFactory.Caption = "Factory";
            this.coldsHurryGapL3DataTableFactory.ColumnName = "Factory";
            this.coldsHurryGapL3DataTableFactory.Namespace = "";
            // 
            // coldsHurryGapL3DataTableStart_Time
            // 
            this.coldsHurryGapL3DataTableStart_Time.Caption = "Start_Time";
            this.coldsHurryGapL3DataTableStart_Time.ColumnName = "Start_Time";
            this.coldsHurryGapL3DataTableStart_Time.DataType = typeof(System.DateTime);
            this.coldsHurryGapL3DataTableStart_Time.Namespace = "";
            // 
            // coldsHurryGapL3DataTableReason
            // 
            this.coldsHurryGapL3DataTableReason.Caption = "Reason";
            this.coldsHurryGapL3DataTableReason.ColumnName = "Reason";
            this.coldsHurryGapL3DataTableReason.Namespace = "";
            // 
            // coldsHurryGapL3DataTableHeatID
            // 
            this.coldsHurryGapL3DataTableHeatID.Caption = "HeatID";
            this.coldsHurryGapL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsHurryGapL3DataTableHeatID.Namespace = "";
            // 
            // coldsHurryGapL3DataTableMatType
            // 
            this.coldsHurryGapL3DataTableMatType.Caption = "MatType";
            this.coldsHurryGapL3DataTableMatType.ColumnName = "MatType";
            this.coldsHurryGapL3DataTableMatType.Namespace = "";
            // 
            // coldsHurryGapL3DataTableEquipmentType
            // 
            this.coldsHurryGapL3DataTableEquipmentType.Caption = "EquipmentType";
            this.coldsHurryGapL3DataTableEquipmentType.ColumnName = "EquipmentType";
            this.coldsHurryGapL3DataTableEquipmentType.DataType = typeof(short);
            this.coldsHurryGapL3DataTableEquipmentType.Namespace = "";
            // 
            // dsBigGap
            // 
            this.dsBigGap.AutoSubscribe = false;
            this.dsBigGap.DataSetName = "L3DataSet";
            this.dsBigGap.DeleteMethod = "";
            this.dsBigGap.InsertMethod = "";
            this.dsBigGap.L3DataAdapter = null;
            this.dsBigGap.LoadEvent = "";
            this.dsBigGap.LoadTrigger = null;
            this.dsBigGap.RefreshValve = 1000;
            this.dsBigGap.SourceCommand = null;
            this.dsBigGap.SourceCondition = "";
            this.dsBigGap.SourceMethod = "";
            this.dsBigGap.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsBigGap.SourceURI = "";
            this.dsBigGap.SubscribeTarget = null;
            this.dsBigGap.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBigGap});
            this.dsBigGap.UpdateEvent = "";
            this.dsBigGap.UpdateMethod = "";
            this.dsBigGap.UpdateTrigger = null;
            // 
            // schemadsBigGap
            // 
            this.schemadsBigGap.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBigGapL3DataTableCCMID,
            this.coldsBigGapL3DataTableStrandNo,
            this.coldsBigGapL3DataTableGapID,
            this.coldsBigGapL3DataTableFactory,
            this.coldsBigGapL3DataTableMatType,
            this.coldsBigGapL3DataTableGapLife,
            this.coldsBigGapL3DataTableChangeTime,
            this.coldsBigGapL3DataTableHeatID,
            this.coldsBigGapL3DataTableReason,
            this.coldsBigGapL3DataTableEquipmentType});
            this.schemadsBigGap.TableName = "L3DataTable";
            // 
            // coldsBigGapL3DataTableCCMID
            // 
            this.coldsBigGapL3DataTableCCMID.Caption = "CCMID";
            this.coldsBigGapL3DataTableCCMID.ColumnName = "CCMID";
            this.coldsBigGapL3DataTableCCMID.Namespace = "";
            // 
            // coldsBigGapL3DataTableStrandNo
            // 
            this.coldsBigGapL3DataTableStrandNo.Caption = "StrandNo";
            this.coldsBigGapL3DataTableStrandNo.ColumnName = "StrandNo";
            this.coldsBigGapL3DataTableStrandNo.DataType = typeof(int);
            this.coldsBigGapL3DataTableStrandNo.Namespace = "";
            // 
            // coldsBigGapL3DataTableGapID
            // 
            this.coldsBigGapL3DataTableGapID.Caption = "GapID";
            this.coldsBigGapL3DataTableGapID.ColumnName = "GapID";
            this.coldsBigGapL3DataTableGapID.Namespace = "";
            // 
            // coldsBigGapL3DataTableFactory
            // 
            this.coldsBigGapL3DataTableFactory.Caption = "Factory";
            this.coldsBigGapL3DataTableFactory.ColumnName = "Factory";
            this.coldsBigGapL3DataTableFactory.Namespace = "";
            // 
            // coldsBigGapL3DataTableMatType
            // 
            this.coldsBigGapL3DataTableMatType.Caption = "MatType";
            this.coldsBigGapL3DataTableMatType.ColumnName = "MatType";
            this.coldsBigGapL3DataTableMatType.Namespace = "";
            // 
            // coldsBigGapL3DataTableGapLife
            // 
            this.coldsBigGapL3DataTableGapLife.Caption = "GapLife";
            this.coldsBigGapL3DataTableGapLife.ColumnName = "GapLife";
            this.coldsBigGapL3DataTableGapLife.DataType = typeof(int);
            this.coldsBigGapL3DataTableGapLife.Namespace = "";
            // 
            // coldsBigGapL3DataTableChangeTime
            // 
            this.coldsBigGapL3DataTableChangeTime.Caption = "ChangeTime";
            this.coldsBigGapL3DataTableChangeTime.ColumnName = "ChangeTime";
            this.coldsBigGapL3DataTableChangeTime.DataType = typeof(System.DateTime);
            this.coldsBigGapL3DataTableChangeTime.Namespace = "";
            // 
            // coldsBigGapL3DataTableHeatID
            // 
            this.coldsBigGapL3DataTableHeatID.Caption = "HeatID";
            this.coldsBigGapL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsBigGapL3DataTableHeatID.Namespace = "";
            // 
            // coldsBigGapL3DataTableReason
            // 
            this.coldsBigGapL3DataTableReason.Caption = "Reason";
            this.coldsBigGapL3DataTableReason.ColumnName = "Reason";
            this.coldsBigGapL3DataTableReason.Namespace = "";
            // 
            // coldsBigGapL3DataTableEquipmentType
            // 
            this.coldsBigGapL3DataTableEquipmentType.Caption = "EquipmentType";
            this.coldsBigGapL3DataTableEquipmentType.ColumnName = "EquipmentType";
            this.coldsBigGapL3DataTableEquipmentType.DataType = typeof(short);
            this.coldsBigGapL3DataTableEquipmentType.Namespace = "";
            // 
            // CCMRefraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 295);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CCMRefraFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "铸机耐材更换管理";
            this.Load += new System.EventHandler(this.CCMRefraFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSmoothBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSmoothBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmoothBlockReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHurryGapReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRefraFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSmoothBlockFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHurryGapFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBigGapFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHurryGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsHurryGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBigGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBigGap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3DataSet dsSmoothBlock;
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Data.DataTable schemadsSmoothBlock;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableCCMID;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableStrandNo;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableBlockID;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableBlock_Life;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableFactory;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableStart_Time;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableEnd_Time;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableBlock_Size;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableReason;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableHeatID;
        private System.Data.DataColumn coldsSmoothBlockL3DataTableEquipmentType;
        private AppSvrHMI.L3Command cmdRefra;
        private AppSvrHMI.L3CommandParameter l3cmdpdsRefra;
        private System.Windows.Forms.TextBox txtCCMID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.ComboBox cmbFactory;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnStrandNo4;
        private System.Windows.Forms.RadioButton rbtnStrandNo3;
        private System.Windows.Forms.RadioButton rbtnStrandNo2;
        private System.Windows.Forms.RadioButton rbtnStrandNo1;
        private System.Windows.Forms.TextBox txtHeatID;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataSet dsOffLineReason;
        private System.Data.DataTable schemadsOffLineReason;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode_Des;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode_Group;
        private System.Windows.Forms.BindingSource bsSmoothBlockReason;
        private System.Windows.Forms.BindingSource bsHurryGapReason;
        private System.Windows.Forms.BindingSource bsBigGapReason;
        private buttonHide.MyLine myLine;
        private AppSvrHMI.L3DataSet dsRefraFac;
        private System.Data.DataTable schemadsRefraFac;
        private System.Data.DataColumn coldsRefraFacL3DataTableMatFactory;
        private System.Windows.Forms.BindingSource bsSmoothBlockFac;
        private System.Windows.Forms.BindingSource bsHurryGapFac;
        private System.Windows.Forms.BindingSource bsBigGapFac;
        private AppSvrHMI.L3DataSet dsHurryGap;
        private System.Data.DataTable schemadsHurryGap;
        private System.Data.DataColumn coldsHurryGapL3DataTableCCMID;
        private System.Data.DataColumn coldsHurryGapL3DataTableStrandNo;
        private System.Data.DataColumn coldsHurryGapL3DataTableGapID;
        private System.Data.DataColumn coldsHurryGapL3DataTableGapLife;
        private System.Data.DataColumn coldsHurryGapL3DataTableFactory;
        private System.Data.DataColumn coldsHurryGapL3DataTableStart_Time;
        private System.Data.DataColumn coldsHurryGapL3DataTableReason;
        private System.Data.DataColumn coldsHurryGapL3DataTableHeatID;
        private System.Data.DataColumn coldsHurryGapL3DataTableMatType;
        private AppSvrHMI.L3DataSet dsBigGap;
        private System.Data.DataTable schemadsBigGap;
        private System.Data.DataColumn coldsBigGapL3DataTableCCMID;
        private System.Data.DataColumn coldsBigGapL3DataTableStrandNo;
        private System.Data.DataColumn coldsBigGapL3DataTableGapID;
        private System.Data.DataColumn coldsBigGapL3DataTableFactory;
        private System.Data.DataColumn coldsBigGapL3DataTableMatType;
        private System.Data.DataColumn coldsBigGapL3DataTableGapLife;
        private System.Data.DataColumn coldsBigGapL3DataTableChangeTime;
        private System.Data.DataColumn coldsBigGapL3DataTableHeatID;
        private System.Data.DataColumn coldsBigGapL3DataTableReason;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataBox dbxTreatNO;
        private System.Data.DataColumn coldsHurryGapL3DataTableEquipmentType;
        private System.Data.DataColumn coldsBigGapL3DataTableEquipmentType;
        private System.Data.DataColumn coldsRefraFacL3DataTableMATNAME;
    }
}