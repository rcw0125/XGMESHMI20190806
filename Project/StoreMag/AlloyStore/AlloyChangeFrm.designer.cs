namespace StoreMag.AlloyStore
{
    partial class AlloyChangeFrm
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
            this.bsChange = new System.Windows.Forms.BindingSource(this.components);
            this.dsChange = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBalance = new System.Data.DataTable();
            this.coldsBalanceL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBalanceL3DataTablePOSDIFF = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableALLOY_CODE = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableOldAmount = new System.Data.DataColumn();
            this.coldsBalanceL3DataTableTargetID = new System.Data.DataColumn();
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
            this.txtAmount = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPosition = new PxDataValid.PxComboBox();
            this.dsTraget = new AppSvrHMI.L3DataSet();
            this.cmdTraget = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTraget = new AppSvrHMI.L3CommandParameter();
            this.schemadsAlloyCode = new System.Data.DataTable();
            this.coldsAlloyCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTragetL3DataTableALLOY_AREA = new System.Data.DataColumn();
            this.cmbCurPosition = new PxDataValid.PxComboBox();
            this.dsPosition = new AppSvrHMI.L3DataSet();
            this.schemadsPosition = new System.Data.DataTable();
            this.coldsPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.txtCurAmount = new PxDataValid.PxTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.cmdChange = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsError = new AppSvrHMI.L3DataSet();
            this.schemadsError = new System.Data.DataTable();
            this.coldsErrorL3DataTableError_Code = new System.Data.DataColumn();
            this.coldsErrorL3DataTableError_Des = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTraget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).BeginInit();
            this.SuspendLayout();
            // 
            // bsChange
            // 
            this.bsChange.DataMember = "L3DataTable";
            this.bsChange.DataSource = this.dsChange;
            // 
            // dsChange
            // 
            this.dsChange.AutoLoad = true;
            this.dsChange.AutoSubscribe = true;
            this.dsChange.DataSetName = "L3DataSet";
            this.dsChange.DeleteMethod = "";
            this.dsChange.InsertMethod = "";
            this.dsChange.L3DataAdapter = this.Adapter;
            this.dsChange.LoadEvent = "Click";
            this.dsChange.LoadTrigger = null;
            this.dsChange.RefreshValve = 1000;
            this.dsChange.SourceCommand = null;
            this.dsChange.SourceCondition = null;
            this.dsChange.SourceMethod = "GetAllMaterialOnStore";
            this.dsChange.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsChange.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.dsChange.SubscribeTarget = null;
            this.dsChange.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBalance});
            this.dsChange.UpdateEvent = "Click";
            this.dsChange.UpdateMethod = "";
            this.dsChange.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBalance
            // 
            this.schemadsBalance.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBalanceL3DataTableMATERIALID,
            this.coldsBalanceL3DataTableMATERIALTYPE,
            this.coldsBalanceL3DataTablePOSITION,
            this.coldsBalanceL3DataTablePOSDIFF,
            this.coldsBalanceL3DataTableAMOUNT,
            this.coldsBalanceL3DataTableBATCH_ID,
            this.coldsBalanceL3DataTableALLOY_CODE,
            this.coldsBalanceL3DataTableOldAmount,
            this.coldsBalanceL3DataTableTargetID});
            this.schemadsBalance.TableName = "L3DataTable";
            // 
            // coldsBalanceL3DataTableMATERIALID
            // 
            this.coldsBalanceL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBalanceL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBalanceL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBalanceL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBalanceL3DataTableMATERIALTYPE
            // 
            this.coldsBalanceL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBalanceL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBalanceL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBalanceL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBalanceL3DataTablePOSITION
            // 
            this.coldsBalanceL3DataTablePOSITION.Caption = "POSITION";
            this.coldsBalanceL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsBalanceL3DataTablePOSITION.DefaultValue = "";
            this.coldsBalanceL3DataTablePOSITION.Namespace = "";
            // 
            // coldsBalanceL3DataTablePOSDIFF
            // 
            this.coldsBalanceL3DataTablePOSDIFF.Caption = "POSDIFF";
            this.coldsBalanceL3DataTablePOSDIFF.ColumnName = "POSDIFF";
            this.coldsBalanceL3DataTablePOSDIFF.DefaultValue = "";
            this.coldsBalanceL3DataTablePOSDIFF.Namespace = "";
            // 
            // coldsBalanceL3DataTableAMOUNT
            // 
            this.coldsBalanceL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBalanceL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBalanceL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBalanceL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBalanceL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBalanceL3DataTableBATCH_ID
            // 
            this.coldsBalanceL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsBalanceL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsBalanceL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsBalanceL3DataTableBATCH_ID.Namespace = "";
            // 
            // coldsBalanceL3DataTableALLOY_CODE
            // 
            this.coldsBalanceL3DataTableALLOY_CODE.Caption = "ALLOY_CODE";
            this.coldsBalanceL3DataTableALLOY_CODE.ColumnName = "ALLOY_CODE";
            this.coldsBalanceL3DataTableALLOY_CODE.DefaultValue = "";
            this.coldsBalanceL3DataTableALLOY_CODE.Namespace = "";
            // 
            // coldsBalanceL3DataTableOldAmount
            // 
            this.coldsBalanceL3DataTableOldAmount.Caption = "OldAmount";
            this.coldsBalanceL3DataTableOldAmount.ColumnName = "OldAmount";
            this.coldsBalanceL3DataTableOldAmount.DataType = typeof(double);
            this.coldsBalanceL3DataTableOldAmount.Namespace = "";
            // 
            // coldsBalanceL3DataTableTargetID
            // 
            this.coldsBalanceL3DataTableTargetID.Caption = "TargetID";
            this.coldsBalanceL3DataTableTargetID.ColumnName = "TargetID";
            this.coldsBalanceL3DataTableTargetID.Namespace = "";
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
            this.tabControl1.Size = new System.Drawing.Size(392, 174);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbPosition);
            this.tabPage1.Controls.Add(this.cmbCurPosition);
            this.tabPage1.Controls.Add(this.txtCurAmount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "转库信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChange, "AMOUNT", true));
            //
            this.txtAmount.EnableNull = false;
            this.txtAmount.ErropPr = this.errorProvider1;
            //
            this.txtAmount.Length = 0;
            this.txtAmount.Location = new System.Drawing.Point(113, 101);
            this.txtAmount.Max = 99999;
            ////
            //
            this.txtAmount.MaxStrLength = 0;
            this.txtAmount.Min = 0;
          //  //
            //
            this.txtAmount.MinStrLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Precision = 0;
            //
            this.txtAmount.Size = new System.Drawing.Size(209, 21);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.ToolTipValid = this.toolTip1;
          //
            this.txtAmount.ValidEable = true;
            this.txtAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "转入重量[Kg]:";
            // 
            // cmbPosition
            // 
            this.cmbPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsChange, "TargetID", true));
            this.cmbPosition.DataSource = this.dsTraget;
            this.cmbPosition.DisplayMember = "L3DataTable.Code_Des";
            this.cmbPosition.EnableNull = false;
            this.cmbPosition.ErropPr = this.errorProvider1;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(113, 48);
            this.cmbPosition.Name = "cmbPosition";
            //
            this.cmbPosition.Size = new System.Drawing.Size(209, 20);
            this.cmbPosition.TabIndex = 3;
            //
            this.cmbPosition.ToolTipValid = this.toolTip1;
            this.cmbPosition.ValidEable = true;
            this.cmbPosition.ValueMember = "L3DataTable.ALLOY_AREA";
            // 
            // dsTraget
            // 
            this.dsTraget.AutoLoad = true;
            this.dsTraget.AutoSubscribe = true;
            this.dsTraget.DataSetName = "L3DataSet";
            this.dsTraget.DeleteMethod = "";
            this.dsTraget.InsertMethod = "";
            this.dsTraget.L3DataAdapter = this.Adapter;
            this.dsTraget.LoadEvent = "Click";
            this.dsTraget.LoadTrigger = null;
            this.dsTraget.RefreshValve = 1000;
            this.dsTraget.SourceCommand = this.cmdTraget;
            this.dsTraget.SourceCondition = "";
            this.dsTraget.SourceMethod = "GetAlloyArea";
            this.dsTraget.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsTraget.SourceURI = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.dsTraget.SubscribeTarget = null;
            this.dsTraget.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyCode});
            this.dsTraget.UpdateEvent = "Click";
            this.dsTraget.UpdateMethod = "";
            this.dsTraget.UpdateTrigger = null;
            // 
            // cmdTraget
            // 
            this.cmdTraget.Adapter = null;
            this.cmdTraget.MergeReturnTarget = false;
            this.cmdTraget.Method = null;
            this.cmdTraget.Object = null;
            this.cmdTraget.Parameters.Add(this.l3cmdpTraget);
            this.cmdTraget.ReturnTarget = null;
            this.cmdTraget.ReturnTargetProperty = null;
            this.cmdTraget.Trigger = null;
            this.cmdTraget.TriggerEvent = "Click";
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
            // schemadsAlloyCode
            // 
            this.schemadsAlloyCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyCodeL3DataTableCode_Des,
            this.coldsTragetL3DataTableALLOY_AREA});
            this.schemadsAlloyCode.TableName = "L3DataTable";
            // 
            // coldsAlloyCodeL3DataTableCode_Des
            // 
            this.coldsAlloyCodeL3DataTableCode_Des.Caption = "CODE_DES";
            this.coldsAlloyCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAlloyCodeL3DataTableCode_Des.DefaultValue = "";
            this.coldsAlloyCodeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTragetL3DataTableALLOY_AREA
            // 
            this.coldsTragetL3DataTableALLOY_AREA.Caption = "ALLOY_AREA";
            this.coldsTragetL3DataTableALLOY_AREA.ColumnName = "ALLOY_AREA";
            this.coldsTragetL3DataTableALLOY_AREA.DefaultValue = "";
            this.coldsTragetL3DataTableALLOY_AREA.Namespace = "";
            // 
            // cmbCurPosition
            // 
            this.cmbCurPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCurPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCurPosition.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsChange, "POSITION", true));
            this.cmbCurPosition.DataSource = this.dsPosition;
            this.cmbCurPosition.DisplayMember = "L3DataTable.Code_Des";
            this.cmbCurPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbCurPosition.Enabled = false;
            this.cmbCurPosition.EnableNull = false;
            this.cmbCurPosition.ErropPr = this.errorProvider1;
            this.cmbCurPosition.FormattingEnabled = true;
            this.cmbCurPosition.Location = new System.Drawing.Point(113, 22);
            this.cmbCurPosition.Name = "cmbCurPosition";
            //
            this.cmbCurPosition.Size = new System.Drawing.Size(209, 20);
            this.cmbCurPosition.TabIndex = 3;
            //
            this.cmbCurPosition.ToolTipValid = this.toolTip1;
            this.cmbCurPosition.ValidEable = true;
            this.cmbCurPosition.ValueMember = "L3DataTable.Code";
            // 
            // dsPosition
            // 
            this.dsPosition.AutoLoad = true;
            this.dsPosition.AutoSubscribe = true;
            this.dsPosition.DataSetName = "L3DataSet";
            this.dsPosition.DeleteMethod = null;
            this.dsPosition.InsertMethod = null;
            this.dsPosition.L3DataAdapter = this.Adapter;
            this.dsPosition.LoadEvent = "Click";
            this.dsPosition.LoadTrigger = null;
            this.dsPosition.RefreshValve = 1000;
            this.dsPosition.SourceCommand = null;
            this.dsPosition.SourceCondition = "(CODE_GROUP = \'AlloyArea\' or code_group = \'AlloyGround\'  or code_group = \'AlloyWi" +
                "re\') and CODE is not null";
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
            // txtCurAmount
            // 
            this.txtCurAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsChange, "OldAmount", true));
            //
            this.txtCurAmount.Enabled = false;
            this.txtCurAmount.EnableNull = false;
            this.txtCurAmount.ErropPr = this.errorProvider1;
            //
            this.txtCurAmount.Length = 0;
            this.txtCurAmount.Location = new System.Drawing.Point(113, 74);
            this.txtCurAmount.Max = 99999;
            ////
            //
            this.txtCurAmount.MaxStrLength = 0;
            this.txtCurAmount.Min = 0;
            ////
            //
            this.txtCurAmount.MinStrLength = 0;
            this.txtCurAmount.Name = "txtCurAmount";
            this.txtCurAmount.Precision = 0;
            //
            this.txtCurAmount.Size = new System.Drawing.Size(209, 21);
            this.txtCurAmount.TabIndex = 1;
            this.txtCurAmount.ToolTipValid = this.toolTip1;
          //
            this.txtCurAmount.ValidEable = true;
            this.txtCurAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "现有合金量[Kg]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(48, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "转入料仓:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "料仓:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(187, 180);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(279, 180);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 2;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // cmdChange
            // 
            this.cmdChange.Adapter = this.Adapter;
            this.cmdChange.MergeReturnTarget = false;
            this.cmdChange.Method = "AlloyChangeStore";
            this.cmdChange.Object = "XGMESLogic\\AlloyStoreMag\\CAlloy_Store_Mag\\S81";
            this.cmdChange.Parameters.Add(this.l3CommandParameter2);
            this.cmdChange.ReturnTarget = null;
            this.cmdChange.ReturnTargetProperty = null;
            this.cmdChange.Trigger = null;
            this.cmdChange.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsChange;
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
            this.l3CommandParameter1.SourceObject = this.dsChange;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // dsError
            // 
            this.dsError.AutoLoad = true;
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
            // AlloyChangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 215);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AlloyChangeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "合金转库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlloyChangeFrm_FormClosing);
            this.Load += new System.EventHandler(this.AlloyChangeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTraget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsChange;
        private AppSvrHMI.L3DataSet dsChange;
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
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancle;
        private PxDataValid.PxComboBox cmbCurPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private PxDataValid.PxTextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Data.DataTable schemadsBalance;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBalanceL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBalanceL3DataTablePOSITION;
        private System.Data.DataColumn coldsBalanceL3DataTablePOSDIFF;
        private System.Data.DataColumn coldsBalanceL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBalanceL3DataTableBATCH_ID;
        private System.Data.DataColumn coldsBalanceL3DataTableALLOY_CODE;
        private System.Data.DataColumn coldsBalanceL3DataTableOldAmount;
        private AppSvrHMI.L3DataSet dsPosition;
        private System.Data.DataTable schemadsPosition;
        private System.Data.DataColumn coldsPositionL3DataTableCode;
        private System.Data.DataColumn coldsPositionL3DataTableCode_Des;
        private PxDataValid.PxComboBox cmbPosition;
        private AppSvrHMI.L3DataSet dsTraget;
        private System.Data.DataTable schemadsAlloyCode;
        private System.Data.DataColumn coldsAlloyCodeL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdChange;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsBalanceL3DataTableTargetID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private AppSvrHMI.L3Command cmdTraget;
        private System.Data.DataColumn coldsTragetL3DataTableALLOY_AREA;
        private AppSvrHMI.L3CommandParameter l3cmdpTraget;
        private AppSvrHMI.L3DataSet dsError;
        private System.Data.DataTable schemadsError;
        private System.Data.DataColumn coldsErrorL3DataTableError_Code;
        private System.Data.DataColumn coldsErrorL3DataTableError_Des;
    }
}