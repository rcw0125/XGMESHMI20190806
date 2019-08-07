namespace StoreMag.AlloyStore
{
    partial class AlloyRollBackFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbCurPosition = new PxDataValid.PxComboBox();
            this.dsRollBack = new AppSvrHMI.L3DataSet();
            this.schemadsRollBack = new System.Data.DataTable();
            this.coldsRollBackL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsRollBackL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsRollBackL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsRollBackL3DataTablePOSDIFF = new System.Data.DataColumn();
            this.coldsRollBackL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsRollBackL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsRollBackL3DataTableALLOY_CODE = new System.Data.DataColumn();
            this.coldsRollBackL3DataTableOldAmount = new System.Data.DataColumn();
            this.dsPosition = new AppSvrHMI.L3DataSet();
            this.schemadsPosition = new System.Data.DataTable();
            this.coldsPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pxTextBox1 = new PxDataValid.PxTextBox();
            this.bsRollBack = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurAmount = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l3cmdpTraget = new AppSvrHMI.L3CommandParameter();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            this.cmdRollBack = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRollBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRollBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRollBack)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 172);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.cmbCurPosition);
            this.tabPage1.Controls.Add(this.pxTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCurAmount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 147);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "转库信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbCurPosition
            // 
            this.cmbCurPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCurPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCurPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsRollBack, "L3DataTable.POSITION", true));
            this.cmbCurPosition.DataSource = this.dsPosition;
            this.cmbCurPosition.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCurPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCurPosition.Enabled = false;
            this.cmbCurPosition.EnableNull = false;
            this.cmbCurPosition.ErropPr = this.errorProvider1;
            this.cmbCurPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCurPosition.FormattingEnabled = true;
            this.cmbCurPosition.Location = new System.Drawing.Point(145, 37);
            this.cmbCurPosition.Name = "cmbCurPosition";
            this.cmbCurPosition.Size = new System.Drawing.Size(205, 20);
            this.cmbCurPosition.TabIndex = 3;
            this.cmbCurPosition.ToolTipValid = this.toolTip1;
            this.cmbCurPosition.ValidEable = true;
            this.cmbCurPosition.ValueMember = "L3DataTable.Code";
            // 
            // dsRollBack
            // 
            this.dsRollBack.AutoSubscribe = true;
            this.dsRollBack.DataSetName = "L3DataSet";
            this.dsRollBack.DeleteMethod = "";
            this.dsRollBack.InsertMethod = "";
            this.dsRollBack.L3DataAdapter = null;
            this.dsRollBack.LoadEvent = "";
            this.dsRollBack.LoadTrigger = null;
            this.dsRollBack.RefreshValve = 1000;
            this.dsRollBack.SourceCommand = null;
            this.dsRollBack.SourceCondition = "";
            this.dsRollBack.SourceMethod = "";
            this.dsRollBack.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsRollBack.SourceURI = "";
            this.dsRollBack.SubscribeTarget = "Version";
            this.dsRollBack.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsRollBack});
            this.dsRollBack.UpdateEvent = "";
            this.dsRollBack.UpdateMethod = "";
            this.dsRollBack.UpdateTrigger = null;
            // 
            // schemadsRollBack
            // 
            this.schemadsRollBack.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsRollBackL3DataTableMATERIALID,
            this.coldsRollBackL3DataTableMATERIALTYPE,
            this.coldsRollBackL3DataTablePOSITION,
            this.coldsRollBackL3DataTablePOSDIFF,
            this.coldsRollBackL3DataTableAMOUNT,
            this.coldsRollBackL3DataTableBATCH_ID,
            this.coldsRollBackL3DataTableALLOY_CODE,
            this.coldsRollBackL3DataTableOldAmount});
            this.schemadsRollBack.TableName = "L3DataTable";
            // 
            // coldsRollBackL3DataTableMATERIALID
            // 
            this.coldsRollBackL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsRollBackL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsRollBackL3DataTableMATERIALID.DefaultValue = "";
            this.coldsRollBackL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsRollBackL3DataTableMATERIALTYPE
            // 
            this.coldsRollBackL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsRollBackL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsRollBackL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsRollBackL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsRollBackL3DataTablePOSITION
            // 
            this.coldsRollBackL3DataTablePOSITION.Caption = "POSITION";
            this.coldsRollBackL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsRollBackL3DataTablePOSITION.DefaultValue = "";
            this.coldsRollBackL3DataTablePOSITION.Namespace = "";
            // 
            // coldsRollBackL3DataTablePOSDIFF
            // 
            this.coldsRollBackL3DataTablePOSDIFF.Caption = "POSDIFF";
            this.coldsRollBackL3DataTablePOSDIFF.ColumnName = "POSDIFF";
            this.coldsRollBackL3DataTablePOSDIFF.DefaultValue = "";
            this.coldsRollBackL3DataTablePOSDIFF.Namespace = "";
            // 
            // coldsRollBackL3DataTableAMOUNT
            // 
            this.coldsRollBackL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsRollBackL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsRollBackL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsRollBackL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsRollBackL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsRollBackL3DataTableBATCH_ID
            // 
            this.coldsRollBackL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsRollBackL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsRollBackL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsRollBackL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsRollBackL3DataTableALLOY_CODE
            // 
            this.coldsRollBackL3DataTableALLOY_CODE.Caption = "ALLOY_CODE";
            this.coldsRollBackL3DataTableALLOY_CODE.ColumnName = "ALLOY_CODE";
            this.coldsRollBackL3DataTableALLOY_CODE.DefaultValue = "";
            this.coldsRollBackL3DataTableALLOY_CODE.Namespace = "";
            // 
            // coldsRollBackL3DataTableOldAmount
            // 
            this.coldsRollBackL3DataTableOldAmount.Caption = "OldAmount";
            this.coldsRollBackL3DataTableOldAmount.ColumnName = "OldAmount";
            this.coldsRollBackL3DataTableOldAmount.DataType = typeof(double);
            this.coldsRollBackL3DataTableOldAmount.Namespace = "";
            // 
            // dsPosition
            // 
            this.dsPosition.AutoSubscribe = true;
            this.dsPosition.DataSetName = "L3DataSet";
            this.dsPosition.DeleteMethod = "";
            this.dsPosition.InsertMethod = "";
            this.dsPosition.L3DataAdapter = this.Adapter;
            this.dsPosition.LoadEvent = "";
            this.dsPosition.LoadTrigger = null;
            this.dsPosition.RefreshValve = 1000;
            this.dsPosition.SourceCommand = null;
            this.dsPosition.SourceCondition = "(CODE_GROUP = \'AlloyArea\' or code_group = \'AlloyGround\' or code_group = \'AlloyWir" +
                "e\') and CODE is not null";
            this.dsPosition.SourceMethod = "";
            this.dsPosition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsPosition.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsPosition.SubscribeTarget = null;
            this.dsPosition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPosition});
            this.dsPosition.UpdateEvent = "";
            this.dsPosition.UpdateMethod = "";
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
            // pxTextBox1
            // 
            this.pxTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRollBack, "AMOUNT", true));
            this.pxTextBox1.EnableNull = false;
            this.pxTextBox1.ErropPr = null;
            this.pxTextBox1.Length = 0;
            this.pxTextBox1.Location = new System.Drawing.Point(145, 102);
            this.pxTextBox1.Max = 0;
            this.pxTextBox1.MaxStrLength = 0;
            this.pxTextBox1.Min = -0.99;
            this.pxTextBox1.MinStrLength = 0;
            this.pxTextBox1.Name = "pxTextBox1";
            this.pxTextBox1.Precision = 0;
            this.pxTextBox1.Size = new System.Drawing.Size(204, 21);
            this.pxTextBox1.TabIndex = 1;
            this.pxTextBox1.ToolTipValid = null;
            this.pxTextBox1.ValidEable = true;
            this.pxTextBox1.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // bsRollBack
            // 
            this.bsRollBack.DataMember = "L3DataTable";
            this.bsRollBack.DataSource = this.dsRollBack;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "取消合金量[Kg]:";
            // 
            // txtCurAmount
            // 
            this.txtCurAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRollBack, "OldAmount", true));
            this.txtCurAmount.EnableNull = false;
            this.txtCurAmount.ErropPr = this.errorProvider1;
            this.txtCurAmount.Length = 0;
            this.txtCurAmount.Location = new System.Drawing.Point(145, 69);
            this.txtCurAmount.Max = 0;
            this.txtCurAmount.MaxStrLength = 0;
            this.txtCurAmount.Min = -0.99;
            this.txtCurAmount.MinStrLength = 0;
            this.txtCurAmount.Name = "txtCurAmount";
            this.txtCurAmount.Precision = 0;
            this.txtCurAmount.ReadOnly = true;
            this.txtCurAmount.Size = new System.Drawing.Size(204, 21);
            this.txtCurAmount.TabIndex = 1;
            this.txtCurAmount.ToolTipValid = this.toolTip1;
            this.txtCurAmount.ValidEable = true;
            this.txtCurAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "现有合金量[Kg]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "料仓:";
            // 
            // l3cmdpTraget
            // 
            this.l3cmdpTraget.AcceptAfterExecuted = false;
            this.l3cmdpTraget.ConstantValue = null;
            this.l3cmdpTraget.MergeTarget = false;
            this.l3cmdpTraget.SourceFilter = null;
            this.l3cmdpTraget.SourceObject = null;
            this.l3cmdpTraget.SourceProperty = null;
            this.l3cmdpTraget.TargetObject = null;
            this.l3cmdpTraget.TargetProperty = null;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(199, 178);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(280, 178);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
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
            // dsError
            // 
            this.dsError.AutoSubscribe = true;
            this.dsError.DataSetName = "L3DataSet";
            this.dsError.DeleteMethod = null;
            this.dsError.InsertMethod = null;
            this.dsError.L3DataAdapter = this.Adapter;
            this.dsError.LoadEvent = "Click";
            this.dsError.LoadTrigger = null;
            this.dsError.RefreshValve = 1000;
            this.dsError.SourceCommand = null;
            this.dsError.SourceCondition = "OWNER = \'AlloyChangeStore\'";
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
            this.coldsErrorL3DataTableError_Code,
            this.coldsErrorL3DataTableError_Des});
            this.schemadsError.TableName = "L3DataTable";
            // 
            // coldsErrorL3DataTableError_Code
            // 
            this.coldsErrorL3DataTableError_Code.Caption = "Error_Code";
            this.coldsErrorL3DataTableError_Code.ColumnName = "Error_Code";
            this.coldsErrorL3DataTableError_Code.Namespace = "";
            // 
            // coldsErrorL3DataTableError_Des
            // 
            this.coldsErrorL3DataTableError_Des.Caption = "Error_Des";
            this.coldsErrorL3DataTableError_Des.ColumnName = "Error_Des";
            this.coldsErrorL3DataTableError_Des.Namespace = "";
            // 
            // cmdRollBack
            // 
            this.cmdRollBack.Adapter = this.Adapter;
            this.cmdRollBack.MergeReturnTarget = false;
            this.cmdRollBack.Method = "AlloyInStoreCancel";
            this.cmdRollBack.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdRollBack.Parameters.Add(this.l3CommandParameter3);
            this.cmdRollBack.ReturnTarget = null;
            this.cmdRollBack.ReturnTargetProperty = null;
            this.cmdRollBack.Trigger = null;
            this.cmdRollBack.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.dsRollBack;
            this.l3CommandParameter3.SourceProperty = "L3DataTable";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // AlloyRollBackFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 238);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlloyRollBackFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "上料取消";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyRollBackFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyRollBackFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsRollBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsRollBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRollBack)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtCurAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancle;
        private PxDataValid.PxComboBox cmbCurPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3CommandParameter l3cmdpTraget;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
        private AppSvrHMI.L3DataSet dsRollBack;
        private System.Windows.Forms.BindingSource bsRollBack;
        private System.Data.DataTable schemadsRollBack;
        private System.Data.DataColumn coldsRollBackL3DataTableMATERIALID;
        private System.Data.DataColumn coldsRollBackL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsRollBackL3DataTablePOSITION;
        private System.Data.DataColumn coldsRollBackL3DataTablePOSDIFF;
        private System.Data.DataColumn coldsRollBackL3DataTableAMOUNT;
        private System.Data.DataColumn coldsRollBackL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsRollBackL3DataTableALLOY_CODE;
        private System.Data.DataColumn coldsRollBackL3DataTableOldAmount;
        private AppSvrHMI.L3Command cmdRollBack;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3DataSet dsPosition;
        private System.Data.DataTable schemadsPosition;
        private System.Data.DataColumn coldsPositionL3DataTableCode;
        private System.Data.DataColumn coldsPositionL3DataTableCode_Des;
        private PxDataValid.PxTextBox pxTextBox1;
        private System.Windows.Forms.Label label1;
    }
}