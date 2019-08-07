namespace StoreMag.ScrapStore
{
    partial class ScrapInStoreComfirmFrm
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
            this.bsScrapInStoreComfirmFrm = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrapInStoreConfirm = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsBulkInStoreConfirm = new System.Data.DataTable();
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableIDX = new System.Data.DataColumn();
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID = new System.Data.DataColumn();
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
            this.lbStoreArea = new System.Windows.Forms.Label();
            this.txtAmount = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsScrapArea = new AppSvrHMI.L3DataSet();
            this.schemadsBulkArea = new System.Data.DataTable();
            this.coldsBulkAreaL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkAreaL3DataTableCode_Des = new System.Data.DataColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmdScrapInStoreConfirm = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapInStoreComfirmFrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapInStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).BeginInit();
            this.SuspendLayout();
            // 
            // bsScrapInStoreComfirmFrm
            // 
            this.bsScrapInStoreComfirmFrm.DataMember = "L3DataTable";
            this.bsScrapInStoreComfirmFrm.DataSource = this.dsScrapInStoreConfirm;
            this.bsScrapInStoreComfirmFrm.CurrentChanged += new System.EventHandler(this.bsScrapInStoreComfirmFrm_CurrentChanged);
            // 
            // dsScrapInStoreConfirm
            // 
            this.dsScrapInStoreConfirm.AutoLoad = true;
            this.dsScrapInStoreConfirm.AutoSubscribe = true;
            this.dsScrapInStoreConfirm.DataSetName = "L3DataSet";
            this.dsScrapInStoreConfirm.DeleteMethod = "";
            this.dsScrapInStoreConfirm.InsertMethod = "";
            this.dsScrapInStoreConfirm.L3DataAdapter = this.Adapter;
            this.dsScrapInStoreConfirm.LoadEvent = "Click";
            this.dsScrapInStoreConfirm.LoadTrigger = null;
            this.dsScrapInStoreConfirm.RefreshValve = 1000;
            this.dsScrapInStoreConfirm.SourceCommand = null;
            this.dsScrapInStoreConfirm.SourceCondition = "";
            this.dsScrapInStoreConfirm.SourceMethod = "";
            this.dsScrapInStoreConfirm.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsScrapInStoreConfirm.SourceURI = "";
            this.dsScrapInStoreConfirm.SubscribeTarget = "Version";
            this.dsScrapInStoreConfirm.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkInStoreConfirm});
            this.dsScrapInStoreConfirm.UpdateEvent = "Click";
            this.dsScrapInStoreConfirm.UpdateMethod = "";
            this.dsScrapInStoreConfirm.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsBulkInStoreConfirm
            // 
            this.schemadsBulkInStoreConfirm.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE,
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID,
            this.coldsBulkInStoreConfirmL3DataTablePOSITION,
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT,
            this.coldsBulkInStoreConfirmL3DataTableIDX,
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID});
            this.schemadsBulkInStoreConfirm.TableName = "L3DataTable";
            // 
            // coldsBulkInStoreConfirmL3DataTableMATERIALTYPE
            // 
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.Caption = "MATERIALTYPE";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.ColumnName = "MATERIALTYPE";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALTYPE.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableMATERIALID
            // 
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.Caption = "MATERIALID";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.ColumnName = "MATERIALID";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTableMATERIALID.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTablePOSITION
            // 
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.Caption = "POSITION";
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.DefaultValue = "";
            this.coldsBulkInStoreConfirmL3DataTablePOSITION.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableAMOUNT
            // 
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBulkInStoreConfirmL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableIDX
            // 
            this.coldsBulkInStoreConfirmL3DataTableIDX.Caption = "IDX";
            this.coldsBulkInStoreConfirmL3DataTableIDX.ColumnName = "IDX";
            this.coldsBulkInStoreConfirmL3DataTableIDX.DataType = typeof(int);
            this.coldsBulkInStoreConfirmL3DataTableIDX.DefaultValue = 0;
            this.coldsBulkInStoreConfirmL3DataTableIDX.Namespace = "";
            // 
            // coldsBulkInStoreConfirmL3DataTableStoreAreaID
            // 
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsBulkInStoreConfirmL3DataTableStoreAreaID.Namespace = "";
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
            this.tabControl1.Size = new System.Drawing.Size(287, 125);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.lbStoreArea);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 99);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "上料信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbStoreArea
            // 
            this.lbStoreArea.AutoSize = true;
            this.lbStoreArea.Location = new System.Drawing.Point(113, 19);
            this.lbStoreArea.Name = "lbStoreArea";
            this.lbStoreArea.Size = new System.Drawing.Size(47, 12);
            this.lbStoreArea.TabIndex = 4;
            this.lbStoreArea.Text = "xxxxxxx";
            // 
            // txtAmount
            // 
            this.txtAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsScrapInStoreComfirmFrm, "AMOUNT", true));
            //
            this.txtAmount.EnableNull = false;
            this.txtAmount.ErropPr = this.errorProvider1;
            //
            this.txtAmount.Length = 0;
            this.txtAmount.Location = new System.Drawing.Point(111, 56);
            this.txtAmount.Max = 9999;
            //
            //
            this.txtAmount.MaxStrLength = 0;
            this.txtAmount.Min = 0;
            //
            //
            this.txtAmount.MinStrLength = 0;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Precision = 0;
            //
            this.txtAmount.Size = new System.Drawing.Size(121, 21);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.ToolTipValid = this.toolTip1;
          //
            this.txtAmount.ValidEable = true;
            this.txtAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.Float;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "废钢生铁量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "库区:";
            // 
            // dsScrapArea
            // 
            this.dsScrapArea.AutoLoad = true;
            this.dsScrapArea.AutoSubscribe = true;
            this.dsScrapArea.DataSetName = "L3DataSet";
            this.dsScrapArea.DeleteMethod = null;
            this.dsScrapArea.InsertMethod = null;
            this.dsScrapArea.L3DataAdapter = this.Adapter;
            this.dsScrapArea.LoadEvent = "Click";
            this.dsScrapArea.LoadTrigger = null;
            this.dsScrapArea.RefreshValve = 1000;
            this.dsScrapArea.SourceCommand = null;
            this.dsScrapArea.SourceCondition = "CODE_GROUP = \'ScrapArea\' and CODE is not null";
            this.dsScrapArea.SourceMethod = "";
            this.dsScrapArea.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsScrapArea.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsScrapArea.SubscribeTarget = null;
            this.dsScrapArea.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkArea});
            this.dsScrapArea.UpdateEvent = "Click";
            this.dsScrapArea.UpdateMethod = null;
            this.dsScrapArea.UpdateTrigger = null;
            // 
            // schemadsBulkArea
            // 
            this.schemadsBulkArea.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkAreaL3DataTableCode,
            this.coldsBulkAreaL3DataTableCode_Des});
            this.schemadsBulkArea.TableName = "L3DataTable";
            // 
            // coldsBulkAreaL3DataTableCode
            // 
            this.coldsBulkAreaL3DataTableCode.Caption = "Code";
            this.coldsBulkAreaL3DataTableCode.ColumnName = "Code";
            this.coldsBulkAreaL3DataTableCode.Namespace = "";
            // 
            // coldsBulkAreaL3DataTableCode_Des
            // 
            this.coldsBulkAreaL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkAreaL3DataTableCode_Des.Namespace = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(80, 143);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdScrapInStoreConfirm
            // 
            this.cmdScrapInStoreConfirm.Adapter = this.Adapter;
            this.cmdScrapInStoreConfirm.MergeReturnTarget = false;
            this.cmdScrapInStoreConfirm.Method = "ScrapInStore";
            this.cmdScrapInStoreConfirm.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.cmdScrapInStoreConfirm.Parameters.Add(this.l3CommandParameter2);
            this.cmdScrapInStoreConfirm.ReturnTarget = null;
            this.cmdScrapInStoreConfirm.ReturnTargetProperty = null;
            this.cmdScrapInStoreConfirm.Trigger = null;
            this.cmdScrapInStoreConfirm.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsScrapInStoreConfirm;
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
            this.l3CommandParameter1.SourceObject = this.dsScrapInStoreConfirm;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // ScrapInStoreComfirmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 195);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ScrapInStoreComfirmFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "入库确认";
            this.Load += new System.EventHandler(this.ScrapInStoreComfirmFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapInStoreComfirmFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapInStoreComfirmFrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapInStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkInStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsScrapInStoreComfirmFrm;
        private AppSvrHMI.L3DataSet dsScrapInStoreConfirm;
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
        private PxDataValid.PxTextBox txtAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Data.DataTable schemadsBulkInStoreConfirm;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableMATERIALTYPE;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableMATERIALID;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTablePOSITION;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableIDX;
        private AppSvrHMI.L3DataSet dsScrapArea;
        private System.Data.DataTable schemadsBulkArea;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode;
        private System.Data.DataColumn coldsBulkAreaL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdScrapInStoreConfirm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsBulkInStoreConfirmL3DataTableStoreAreaID;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.Label lbStoreArea;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}