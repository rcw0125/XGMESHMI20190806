namespace StoreMag.BulkStore
{
    partial class BulkToAlloyFrm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3cmdp = new AppSvrHMI.L3CommandParameter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtOldAmount = new PxDataValid.PxTextBox();
            this.txtAmount = new PxDataValid.PxTextBox();
            this.bsBulkToAlloy = new System.Windows.Forms.BindingSource(this.components);
            this.dsBulkToAlloy = new AppSvrHMI.L3DataSet();
            this.schemadsAlloyToBulk = new System.Data.DataTable();
            this.coldsAlloyToBulkL3DataTableGUID = new System.Data.DataColumn();
            this.coldsAlloyToBulkL3DataTableNAME = new System.Data.DataColumn();
            this.coldsAlloyToBulkL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsAlloyToBulkL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsAlloyToBulkL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsAlloyToBulkL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsAlloyToBulkL3DataTableIDX = new System.Data.DataColumn();
            this.coldsAlloyToBulkL3DataTableBATCH_ID = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.cmdBulkToAlloy = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.coldsBulkToAlloyL3DataTableBULK_CODE = new System.Data.DataColumn();
            this.coldsBulkToAlloyL3DataTableOldAmount = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkToAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkToAlloy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyToBulk)).BeginInit();
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
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(219, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // l3cmdp
            // 
            this.l3cmdp.AcceptAfterExecuted = false;
            this.l3cmdp.ConstantValue = null;
            this.l3cmdp.MergeTarget = false;
            this.l3cmdp.SourceFilter = null;
            this.l3cmdp.SourceObject = null;
            this.l3cmdp.SourceProperty = null;
            this.l3cmdp.TargetObject = null;
            this.l3cmdp.TargetProperty = null;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 42);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 132);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtOldAmount);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 107);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "散状料信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtOldAmount
            // 
            this.txtOldAmount.Enabled = false;
            this.txtOldAmount.EnableNull = false;
            this.txtOldAmount.ErropPr = null;
            this.txtOldAmount.Length = 0;
            this.txtOldAmount.Location = new System.Drawing.Point(127, 25);
            this.txtOldAmount.Max = 0;
            this.txtOldAmount.MaxStrLength = 0;
            this.txtOldAmount.Min = -0.99;
            this.txtOldAmount.MinStrLength = 0;
            this.txtOldAmount.Name = "txtOldAmount";
            this.txtOldAmount.Precision = 0;
            this.txtOldAmount.Size = new System.Drawing.Size(239, 21);
            this.txtOldAmount.TabIndex = 1;
            this.txtOldAmount.ToolTipValid = null;
            this.txtOldAmount.ValidEable = true;
            this.txtOldAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBulkToAlloy, "AMOUNT", true));
            this.txtAmount.EnableNull = false;
            this.txtAmount.ErropPr = null;
            this.txtAmount.Length = 0;
            this.txtAmount.Location = new System.Drawing.Point(127, 57);
            this.txtAmount.Max = 0;
            this.txtAmount.MaxStrLength = 0;
            this.txtAmount.Min = -0.99;
            this.txtAmount.MinStrLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Precision = 0;
            this.txtAmount.Size = new System.Drawing.Size(239, 21);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.ToolTipValid = null;
            this.txtAmount.ValidEable = true;
            this.txtAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // bsBulkToAlloy
            // 
            this.bsBulkToAlloy.DataMember = "L3DataTable";
            this.bsBulkToAlloy.DataSource = this.dsBulkToAlloy;
            // 
            // dsBulkToAlloy
            // 
            this.dsBulkToAlloy.AutoSubscribe = false;
            this.dsBulkToAlloy.DataSetName = "L3DataSet";
            this.dsBulkToAlloy.DeleteMethod = "";
            this.dsBulkToAlloy.InsertMethod = "";
            this.dsBulkToAlloy.L3DataAdapter = null;
            this.dsBulkToAlloy.LoadEvent = "";
            this.dsBulkToAlloy.LoadTrigger = null;
            this.dsBulkToAlloy.RefreshValve = 1000;
            this.dsBulkToAlloy.SourceCommand = null;
            this.dsBulkToAlloy.SourceCondition = "";
            this.dsBulkToAlloy.SourceMethod = "GetMaterialOnInputCache";
            this.dsBulkToAlloy.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsBulkToAlloy.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.dsBulkToAlloy.SubscribeTarget = "";
            this.dsBulkToAlloy.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAlloyToBulk});
            this.dsBulkToAlloy.UpdateEvent = "";
            this.dsBulkToAlloy.UpdateMethod = "";
            this.dsBulkToAlloy.UpdateTrigger = null;
            // 
            // schemadsAlloyToBulk
            // 
            this.schemadsAlloyToBulk.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAlloyToBulkL3DataTableGUID,
            this.coldsAlloyToBulkL3DataTableNAME,
            this.coldsAlloyToBulkL3DataTableMATERIALTYPE,
            this.coldsAlloyToBulkL3DataTableMATERIALID,
            this.coldsAlloyToBulkL3DataTablePOSITION,
            this.coldsAlloyToBulkL3DataTableAMOUNT,
            this.coldsAlloyToBulkL3DataTableIDX,
            this.coldsAlloyToBulkL3DataTableBATCH_ID,
            this.coldsBulkToAlloyL3DataTableBULK_CODE,
            this.coldsBulkToAlloyL3DataTableOldAmount});
            this.schemadsAlloyToBulk.TableName = "L3DataTable";
            // 
            // coldsAlloyToBulkL3DataTableGUID
            // 
            this.coldsAlloyToBulkL3DataTableGUID.Caption = "GUID";
            this.coldsAlloyToBulkL3DataTableGUID.ColumnName = "GUID";
            this.coldsAlloyToBulkL3DataTableGUID.DefaultValue = "";
            this.coldsAlloyToBulkL3DataTableGUID.Namespace = "";
            // 
            // coldsAlloyToBulkL3DataTableNAME
            // 
            this.coldsAlloyToBulkL3DataTableNAME.Caption = "NAME";
            this.coldsAlloyToBulkL3DataTableNAME.ColumnName = "NAME";
            this.coldsAlloyToBulkL3DataTableNAME.DefaultValue = "";
            this.coldsAlloyToBulkL3DataTableNAME.Namespace = "";
            // 
            // coldsAlloyToBulkL3DataTableMATERIALTYPE
            // 
            this.coldsAlloyToBulkL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsAlloyToBulkL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsAlloyToBulkL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsAlloyToBulkL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsAlloyToBulkL3DataTableMATERIALID
            // 
            this.coldsAlloyToBulkL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsAlloyToBulkL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsAlloyToBulkL3DataTableMATERIALID.DefaultValue = "";
            this.coldsAlloyToBulkL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsAlloyToBulkL3DataTablePOSITION
            // 
            this.coldsAlloyToBulkL3DataTablePOSITION.Caption = "POSITION";
            this.coldsAlloyToBulkL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsAlloyToBulkL3DataTablePOSITION.DefaultValue = "";
            this.coldsAlloyToBulkL3DataTablePOSITION.Namespace = "";
            // 
            // coldsAlloyToBulkL3DataTableAMOUNT
            // 
            this.coldsAlloyToBulkL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsAlloyToBulkL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsAlloyToBulkL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsAlloyToBulkL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsAlloyToBulkL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsAlloyToBulkL3DataTableIDX
            // 
            this.coldsAlloyToBulkL3DataTableIDX.Caption = "IDX";
            this.coldsAlloyToBulkL3DataTableIDX.ColumnName = "IDX";
            this.coldsAlloyToBulkL3DataTableIDX.DataType = typeof(int);
            this.coldsAlloyToBulkL3DataTableIDX.DefaultValue = 0;
            this.coldsAlloyToBulkL3DataTableIDX.Namespace = "";
            // 
            // coldsAlloyToBulkL3DataTableBATCH_ID
            // 
            this.coldsAlloyToBulkL3DataTableBATCH_ID.Caption = "BATCH_ID";
            this.coldsAlloyToBulkL3DataTableBATCH_ID.ColumnName = "BATCH_ID";
            this.coldsAlloyToBulkL3DataTableBATCH_ID.DefaultValue = "";
            this.coldsAlloyToBulkL3DataTableBATCH_ID.Namespace = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "现有散状料量[Kg]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "转化散状料量[Kg]:";
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
            // cmdBulkToAlloy
            // 
            this.cmdBulkToAlloy.Adapter = this.Adapter;
            this.cmdBulkToAlloy.MergeReturnTarget = false;
            this.cmdBulkToAlloy.Method = "BulkTransToAlloy";
            this.cmdBulkToAlloy.Object = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.cmdBulkToAlloy.Parameters.Add(this.l3CommandParameter3);
            this.cmdBulkToAlloy.ReturnTarget = null;
            this.cmdBulkToAlloy.ReturnTargetProperty = null;
            this.cmdBulkToAlloy.Trigger = null;
            this.cmdBulkToAlloy.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.dsBulkToAlloy;
            this.l3CommandParameter3.SourceProperty = "L3DataTable";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // coldsBulkToAlloyL3DataTableBULK_CODE
            // 
            this.coldsBulkToAlloyL3DataTableBULK_CODE.Caption = "BULK_CODE";
            this.coldsBulkToAlloyL3DataTableBULK_CODE.ColumnName = "BULK_CODE";
            this.coldsBulkToAlloyL3DataTableBULK_CODE.DefaultValue = "";
            this.coldsBulkToAlloyL3DataTableBULK_CODE.Namespace = "";
            // 
            // coldsBulkToAlloyL3DataTableOldAmount
            // 
            this.coldsBulkToAlloyL3DataTableOldAmount.Caption = "OldAmount";
            this.coldsBulkToAlloyL3DataTableOldAmount.ColumnName = "OldAmount";
            this.coldsBulkToAlloyL3DataTableOldAmount.DataType = typeof(double);
            this.coldsBulkToAlloyL3DataTableOldAmount.Namespace = "";
            // 
            // BulkToAlloyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 174);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BulkToAlloyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "散状料转合金";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkToAlloyFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkToAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkToAlloy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAlloyToBulk)).EndInit();
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3cmdp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private PxDataValid.PxTextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private PxDataValid.PxTextBox txtOldAmount;
        private System.Windows.Forms.Label label1;
        private AppSvrHMI.L3DataSet dsBulkToAlloy;
        private System.Data.DataTable schemadsAlloyToBulk;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTableGUID;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTableNAME;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTableMATERIALID;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTablePOSITION;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTableAMOUNT;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTableIDX;
        private System.Data.DataColumn coldsAlloyToBulkL3DataTableBATCH_ID;
        private System.Windows.Forms.BindingSource bsBulkToAlloy;
        private AppSvrHMI.L3Command cmdBulkToAlloy;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Data.DataColumn coldsBulkToAlloyL3DataTableBULK_CODE;
        private System.Data.DataColumn coldsBulkToAlloyL3DataTableOldAmount;
    }
}