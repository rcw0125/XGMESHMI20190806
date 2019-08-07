namespace StoreMag.ScrapStore
{
    partial class ScrapOutStoreShowFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrapOutStoreShowFrm));
            this.bsScrapOutStore = new System.Windows.Forms.BindingSource(this.components);
            this.dsScrapOutStoreConfirm = new AppSvrHMI.L3DataSet();
            this.schemadsScrapOutStoreConfirm = new System.Data.DataTable();
            this.coldsScrapOutStoreConfirmL3DataTableMaterialType = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableMaterialID = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableAmount = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableStoreAreaID = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableScrap_Slot_ID = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableCar_ID = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableCar_Type = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsScrapOutStoreConfirmL3DataTableTare_Weight = new System.Data.DataColumn();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.myLine1 = new buttonHide.MyLine();
            this.txtTareWeight = new PxDataValid.PxTextBox();
            this.txtFGAmount = new PxDataValid.PxTextBox();
            this.txtSTAmount = new PxDataValid.PxTextBox();
            this.txtNetWeight = new PxDataValid.PxTextBox();
            this.txtGrossWeight = new PxDataValid.PxTextBox();
            this.txtScrapSlotID = new PxDataValid.PxTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dsStoreAreaID = new AppSvrHMI.L3DataSet();
            this.schemadsStoreAreaID = new System.Data.DataTable();
            this.coldsStoreAreaIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsStoreAreaIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.cmdScrapOutStore = new AppSvrHMI.L3Command(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddIron = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteIron = new System.Windows.Forms.ToolStripButton();
            this.dvIron = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIron = new AppSvrHMI.L3DataSet();
            this.schemadsIron = new System.Data.DataTable();
            this.coldsIronL3DataTableCode = new System.Data.DataColumn();
            this.coldsIronL3DataTableCode_Des = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddSteel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteSteel = new System.Windows.Forms.ToolStripButton();
            this.dvSteel = new System.Windows.Forms.DataGridView();
            this.ColName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSteelName = new AppSvrHMI.L3DataSet();
            this.schemadsSteelName = new System.Data.DataTable();
            this.coldsSteelNameL3DataTableCode = new System.Data.DataColumn();
            this.coldsSteelNameL3DataTableCode_Des = new System.Data.DataColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dsSend = new AppSvrHMI.L3DataSet();
            this.cmdSteelIron = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapOutStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapOutStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapOutStoreConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreAreaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIron)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelName)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSend)).BeginInit();
            this.SuspendLayout();
            // 
            // bsScrapOutStore
            // 
            this.bsScrapOutStore.DataMember = "L3DataTable";
            this.bsScrapOutStore.DataSource = this.dsScrapOutStoreConfirm;
            // 
            // dsScrapOutStoreConfirm
            // 
            this.dsScrapOutStoreConfirm.AutoLoad = true;
            this.dsScrapOutStoreConfirm.AutoSubscribe = true;
            this.dsScrapOutStoreConfirm.DataSetName = "L3DataSet";
            this.dsScrapOutStoreConfirm.DeleteMethod = null;
            this.dsScrapOutStoreConfirm.InsertMethod = null;
            this.dsScrapOutStoreConfirm.L3DataAdapter = null;
            this.dsScrapOutStoreConfirm.LoadEvent = "Click";
            this.dsScrapOutStoreConfirm.LoadTrigger = null;
            this.dsScrapOutStoreConfirm.RefreshValve = 1000;
            this.dsScrapOutStoreConfirm.SourceCommand = null;
            this.dsScrapOutStoreConfirm.SourceCondition = "";
            this.dsScrapOutStoreConfirm.SourceMethod = "";
            this.dsScrapOutStoreConfirm.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsScrapOutStoreConfirm.SourceURI = "";
            this.dsScrapOutStoreConfirm.SubscribeTarget = "";
            this.dsScrapOutStoreConfirm.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsScrapOutStoreConfirm});
            this.dsScrapOutStoreConfirm.UpdateEvent = "Click";
            this.dsScrapOutStoreConfirm.UpdateMethod = null;
            this.dsScrapOutStoreConfirm.UpdateTrigger = null;
            // 
            // schemadsScrapOutStoreConfirm
            // 
            this.schemadsScrapOutStoreConfirm.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsScrapOutStoreConfirmL3DataTableMaterialType,
            this.coldsScrapOutStoreConfirmL3DataTableMaterialID,
            this.coldsScrapOutStoreConfirmL3DataTableAmount,
            this.coldsScrapOutStoreConfirmL3DataTableStoreAreaID,
            this.coldsScrapOutStoreConfirmL3DataTableScrap_Slot_ID,
            this.coldsScrapOutStoreConfirmL3DataTableCar_ID,
            this.coldsScrapOutStoreConfirmL3DataTableCar_Type,
            this.coldsScrapOutStoreConfirmL3DataTableNet_Weight,
            this.coldsScrapOutStoreConfirmL3DataTableGross_Weight,
            this.coldsScrapOutStoreConfirmL3DataTableTare_Weight});
            this.schemadsScrapOutStoreConfirm.TableName = "L3DataTable";
            // 
            // coldsScrapOutStoreConfirmL3DataTableMaterialType
            // 
            this.coldsScrapOutStoreConfirmL3DataTableMaterialType.Caption = "MaterialType";
            this.coldsScrapOutStoreConfirmL3DataTableMaterialType.ColumnName = "MaterialType";
            this.coldsScrapOutStoreConfirmL3DataTableMaterialType.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableMaterialID
            // 
            this.coldsScrapOutStoreConfirmL3DataTableMaterialID.Caption = "MaterialID";
            this.coldsScrapOutStoreConfirmL3DataTableMaterialID.ColumnName = "MaterialID";
            this.coldsScrapOutStoreConfirmL3DataTableMaterialID.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableAmount
            // 
            this.coldsScrapOutStoreConfirmL3DataTableAmount.Caption = "Amount";
            this.coldsScrapOutStoreConfirmL3DataTableAmount.ColumnName = "Amount";
            this.coldsScrapOutStoreConfirmL3DataTableAmount.DataType = typeof(double);
            this.coldsScrapOutStoreConfirmL3DataTableAmount.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableStoreAreaID
            // 
            this.coldsScrapOutStoreConfirmL3DataTableStoreAreaID.Caption = "StoreAreaID";
            this.coldsScrapOutStoreConfirmL3DataTableStoreAreaID.ColumnName = "StoreAreaID";
            this.coldsScrapOutStoreConfirmL3DataTableStoreAreaID.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableScrap_Slot_ID
            // 
            this.coldsScrapOutStoreConfirmL3DataTableScrap_Slot_ID.Caption = "Scrap_Slot_ID";
            this.coldsScrapOutStoreConfirmL3DataTableScrap_Slot_ID.ColumnName = "Scrap_Slot_ID";
            this.coldsScrapOutStoreConfirmL3DataTableScrap_Slot_ID.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableCar_ID
            // 
            this.coldsScrapOutStoreConfirmL3DataTableCar_ID.Caption = "Car_ID";
            this.coldsScrapOutStoreConfirmL3DataTableCar_ID.ColumnName = "Car_ID";
            this.coldsScrapOutStoreConfirmL3DataTableCar_ID.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableCar_Type
            // 
            this.coldsScrapOutStoreConfirmL3DataTableCar_Type.Caption = "Car_Type";
            this.coldsScrapOutStoreConfirmL3DataTableCar_Type.ColumnName = "Car_Type";
            this.coldsScrapOutStoreConfirmL3DataTableCar_Type.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableNet_Weight
            // 
            this.coldsScrapOutStoreConfirmL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsScrapOutStoreConfirmL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsScrapOutStoreConfirmL3DataTableNet_Weight.DataType = typeof(double);
            this.coldsScrapOutStoreConfirmL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableGross_Weight
            // 
            this.coldsScrapOutStoreConfirmL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsScrapOutStoreConfirmL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsScrapOutStoreConfirmL3DataTableGross_Weight.DataType = typeof(double);
            this.coldsScrapOutStoreConfirmL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsScrapOutStoreConfirmL3DataTableTare_Weight
            // 
            this.coldsScrapOutStoreConfirmL3DataTableTare_Weight.Caption = "Tare_Weight";
            this.coldsScrapOutStoreConfirmL3DataTableTare_Weight.ColumnName = "Tare_Weight";
            this.coldsScrapOutStoreConfirmL3DataTableTare_Weight.DataType = typeof(double);
            this.coldsScrapOutStoreConfirmL3DataTableTare_Weight.Namespace = "";
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
            this.btnConfirm.Location = new System.Drawing.Point(11, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(105, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "新添";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "/ {0}";
            this.toolStripLabel1.ToolTipText = "总项数";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "移到第一条记录";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "移到上一条记录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "位置";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "当前位置";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "移到下一条记录";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "移到最后一条记录";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 165);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.myLine1);
            this.tabPage1.Controls.Add(this.txtTareWeight);
            this.tabPage1.Controls.Add(this.txtFGAmount);
            this.tabPage1.Controls.Add(this.txtSTAmount);
            this.tabPage1.Controls.Add(this.txtNetWeight);
            this.tabPage1.Controls.Add(this.txtGrossWeight);
            this.tabPage1.Controls.Add(this.txtScrapSlotID);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "确认信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // myLine1
            // 
            this.myLine1.BackColor = System.Drawing.SystemColors.Control;
            this.myLine1.Location = new System.Drawing.Point(4, 51);
            this.myLine1.Name = "myLine1";
            this.myLine1.Size = new System.Drawing.Size(433, 10);
            this.myLine1.TabIndex = 2;
            // 
            // txtTareWeight
            // 
            this.txtTareWeight.EnableNull = true;
            this.txtTareWeight.ErropPr = null;
            this.txtTareWeight.Length = 0;
            this.txtTareWeight.Location = new System.Drawing.Point(330, 102);
            this.txtTareWeight.Max = 0;
            this.txtTareWeight.MaxStrLength = 0;
            this.txtTareWeight.Min = 0;
            this.txtTareWeight.MinStrLength = 0;
            this.txtTareWeight.Name = "txtTareWeight";
            this.txtTareWeight.Precision = 0;
            this.txtTareWeight.Size = new System.Drawing.Size(100, 21);
            this.txtTareWeight.TabIndex = 1;
            this.txtTareWeight.ToolTipValid = null;
            this.txtTareWeight.ValidEable = true;
            this.txtTareWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtFGAmount
            // 
            this.txtFGAmount.EnableNull = true;
            this.txtFGAmount.ErropPr = null;
            this.txtFGAmount.Length = 0;
            this.txtFGAmount.Location = new System.Drawing.Point(111, 17);
            this.txtFGAmount.Max = 0;
            this.txtFGAmount.MaxStrLength = 0;
            this.txtFGAmount.Min = 0;
            this.txtFGAmount.MinStrLength = 0;
            this.txtFGAmount.Name = "txtFGAmount";
            this.txtFGAmount.Precision = 0;
            this.txtFGAmount.ReadOnly = true;
            this.txtFGAmount.Size = new System.Drawing.Size(100, 21);
            this.txtFGAmount.TabIndex = 1;
            this.txtFGAmount.ToolTipValid = null;
            this.txtFGAmount.ValidEable = true;
            this.txtFGAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtSTAmount
            // 
            this.txtSTAmount.EnableNull = true;
            this.txtSTAmount.ErropPr = null;
            this.txtSTAmount.Length = 0;
            this.txtSTAmount.Location = new System.Drawing.Point(330, 17);
            this.txtSTAmount.Max = 0;
            this.txtSTAmount.MaxStrLength = 0;
            this.txtSTAmount.Min = 0;
            this.txtSTAmount.MinStrLength = 0;
            this.txtSTAmount.Name = "txtSTAmount";
            this.txtSTAmount.Precision = 0;
            this.txtSTAmount.ReadOnly = true;
            this.txtSTAmount.Size = new System.Drawing.Size(100, 21);
            this.txtSTAmount.TabIndex = 1;
            this.txtSTAmount.ToolTipValid = null;
            this.txtSTAmount.ValidEable = true;
            this.txtSTAmount.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.EnableNull = true;
            this.txtNetWeight.ErropPr = null;
            this.txtNetWeight.Length = 0;
            this.txtNetWeight.Location = new System.Drawing.Point(111, 102);
            this.txtNetWeight.Max = 0;
            this.txtNetWeight.MaxStrLength = 0;
            this.txtNetWeight.Min = 0;
            this.txtNetWeight.MinStrLength = 0;
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.Precision = 0;
            this.txtNetWeight.Size = new System.Drawing.Size(100, 21);
            this.txtNetWeight.TabIndex = 1;
            this.txtNetWeight.ToolTipValid = null;
            this.txtNetWeight.ValidEable = true;
            this.txtNetWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtGrossWeight
            // 
            this.txtGrossWeight.EnableNull = true;
            this.txtGrossWeight.ErropPr = null;
            this.txtGrossWeight.Length = 0;
            this.txtGrossWeight.Location = new System.Drawing.Point(330, 71);
            this.txtGrossWeight.Max = 0;
            this.txtGrossWeight.MaxStrLength = 0;
            this.txtGrossWeight.Min = 0;
            this.txtGrossWeight.MinStrLength = 0;
            this.txtGrossWeight.Name = "txtGrossWeight";
            this.txtGrossWeight.Precision = 0;
            this.txtGrossWeight.Size = new System.Drawing.Size(100, 21);
            this.txtGrossWeight.TabIndex = 1;
            this.txtGrossWeight.ToolTipValid = null;
            this.txtGrossWeight.ValidEable = true;
            this.txtGrossWeight.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // txtScrapSlotID
            // 
            this.txtScrapSlotID.EnableNull = false;
            this.txtScrapSlotID.ErropPr = this.errorProvider1;
            this.txtScrapSlotID.Length = 0;
            this.txtScrapSlotID.Location = new System.Drawing.Point(111, 68);
            this.txtScrapSlotID.Max = 0;
            this.txtScrapSlotID.MaxStrLength = 0;
            this.txtScrapSlotID.Min = 0;
            this.txtScrapSlotID.MinStrLength = 0;
            this.txtScrapSlotID.Name = "txtScrapSlotID";
            this.txtScrapSlotID.Precision = 0;
            this.txtScrapSlotID.Size = new System.Drawing.Size(100, 21);
            this.txtScrapSlotID.TabIndex = 1;
            this.txtScrapSlotID.ToolTipValid = this.toolTip1;
            this.txtScrapSlotID.ValidEable = true;
            this.txtScrapSlotID.ValidType = PxDataValid.PxTextBox.TypeEnum.String;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(271, 104);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 0;
            this.label24.Text = "皮重[t]:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(57, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "净重[t]:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(271, 73);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "毛重[t]:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "废钢出库量[t]:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "废钢斗号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "生铁出库量[t]:";
            // 
            // dsStoreAreaID
            // 
            this.dsStoreAreaID.AutoLoad = true;
            this.dsStoreAreaID.AutoSubscribe = false;
            this.dsStoreAreaID.DataSetName = "L3DataSet";
            this.dsStoreAreaID.DeleteMethod = null;
            this.dsStoreAreaID.InsertMethod = null;
            this.dsStoreAreaID.L3DataAdapter = this.Adapter;
            this.dsStoreAreaID.LoadEvent = "Click";
            this.dsStoreAreaID.LoadTrigger = null;
            this.dsStoreAreaID.RefreshValve = 1000;
            this.dsStoreAreaID.SourceCommand = null;
            this.dsStoreAreaID.SourceCondition = "CODE_GROUP = \'ScrapArea\' and CODE is not null";
            this.dsStoreAreaID.SourceMethod = "";
            this.dsStoreAreaID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStoreAreaID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStoreAreaID.SubscribeTarget = "";
            this.dsStoreAreaID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStoreAreaID});
            this.dsStoreAreaID.UpdateEvent = "Click";
            this.dsStoreAreaID.UpdateMethod = null;
            this.dsStoreAreaID.UpdateTrigger = null;
            // 
            // schemadsStoreAreaID
            // 
            this.schemadsStoreAreaID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStoreAreaIDL3DataTableCode,
            this.coldsStoreAreaIDL3DataTableCode_Des});
            this.schemadsStoreAreaID.TableName = "L3DataTable";
            // 
            // coldsStoreAreaIDL3DataTableCode
            // 
            this.coldsStoreAreaIDL3DataTableCode.Caption = "Code";
            this.coldsStoreAreaIDL3DataTableCode.ColumnName = "Code";
            this.coldsStoreAreaIDL3DataTableCode.Namespace = "";
            // 
            // coldsStoreAreaIDL3DataTableCode_Des
            // 
            this.coldsStoreAreaIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStoreAreaIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStoreAreaIDL3DataTableCode_Des.Namespace = "";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "移到第一条记录";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "移到上一条记录";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "位置";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "当前位置";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel2.Text = "/ {0}";
            this.toolStripLabel2.ToolTipText = "总项数";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "移到下一条记录";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "移到最后一条记录";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "新添";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bsScrapOutStore;
            this.bindingNavigator1.CountItem = this.toolStripLabel2;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.btnAdd});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton7;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton10;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton9;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton8;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator1.Size = new System.Drawing.Size(585, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // cmdScrapOutStore
            // 
            this.cmdScrapOutStore.Adapter = this.Adapter;
            this.cmdScrapOutStore.MergeReturnTarget = false;
            this.cmdScrapOutStore.Method = "ScrapOutStore";
            this.cmdScrapOutStore.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.cmdScrapOutStore.Parameters.Add(this.l3CommandParameter3);
            this.cmdScrapOutStore.ReturnTarget = null;
            this.cmdScrapOutStore.ReturnTargetProperty = null;
            this.cmdScrapOutStore.Trigger = null;
            this.cmdScrapOutStore.TriggerEvent = "Click";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 167);
            this.panel3.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Controls.Add(this.dvIron);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(297, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生铁";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddIron,
            this.toolStripSeparator8,
            this.btnDeleteIron});
            this.toolStrip2.Location = new System.Drawing.Point(3, 17);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(282, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddIron
            // 
            this.btnAddIron.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddIron.Image = ((System.Drawing.Image)(resources.GetObject("btnAddIron.Image")));
            this.btnAddIron.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddIron.Name = "btnAddIron";
            this.btnAddIron.Size = new System.Drawing.Size(23, 22);
            this.btnAddIron.Text = "toolStripButton6";
            this.btnAddIron.Click += new System.EventHandler(this.btnAddIron_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteIron
            // 
            this.btnDeleteIron.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteIron.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteIron.Image")));
            this.btnDeleteIron.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteIron.Name = "btnDeleteIron";
            this.btnDeleteIron.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteIron.Text = "toolStripButton11";
            this.btnDeleteIron.Click += new System.EventHandler(this.btnDeleteIron_Click);
            // 
            // dvIron
            // 
            this.dvIron.AllowUserToAddRows = false;
            this.dvIron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvIron.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dvIron.Location = new System.Drawing.Point(3, 45);
            this.dvIron.Name = "dvIron";
            this.dvIron.RowTemplate.Height = 23;
            this.dvIron.Size = new System.Drawing.Size(282, 119);
            this.dvIron.TabIndex = 1;
            this.dvIron.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvIron_CellEndEdit);
            this.dvIron.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvIron_RowPostPaint);
            // 
            // Column3
            // 
            this.Column3.DataSource = this.dsIron;
            this.Column3.DisplayMember = "L3DataTable.Code_Des";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.HeaderText = "生铁名称";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.ValueMember = "L3DataTable.Code";
            // 
            // dsIron
            // 
            this.dsIron.AutoLoad = true;
            this.dsIron.AutoSubscribe = false;
            this.dsIron.DataSetName = "L3DataSet";
            this.dsIron.DeleteMethod = null;
            this.dsIron.InsertMethod = null;
            this.dsIron.L3DataAdapter = this.Adapter;
            this.dsIron.LoadEvent = "Click";
            this.dsIron.LoadTrigger = null;
            this.dsIron.RefreshValve = 1000;
            this.dsIron.SourceCommand = null;
            this.dsIron.SourceCondition = "CODE_GROUP = \'PigIronGroupName\' ";
            this.dsIron.SourceMethod = "";
            this.dsIron.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIron.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIron.SubscribeTarget = "";
            this.dsIron.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIron});
            this.dsIron.UpdateEvent = "Click";
            this.dsIron.UpdateMethod = null;
            this.dsIron.UpdateTrigger = null;
            // 
            // schemadsIron
            // 
            this.schemadsIron.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronL3DataTableCode,
            this.coldsIronL3DataTableCode_Des});
            this.schemadsIron.TableName = "L3DataTable";
            // 
            // coldsIronL3DataTableCode
            // 
            this.coldsIronL3DataTableCode.Caption = "Code";
            this.coldsIronL3DataTableCode.ColumnName = "Code";
            this.coldsIronL3DataTableCode.Namespace = "";
            // 
            // coldsIronL3DataTableCode_Des
            // 
            this.coldsIronL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsIronL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsIronL3DataTableCode_Des.Namespace = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.dvSteel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "废钢";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSteel,
            this.toolStripSeparator7,
            this.btnDeleteSteel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(291, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddSteel
            // 
            this.btnAddSteel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSteel.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSteel.Image")));
            this.btnAddSteel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSteel.Name = "btnAddSteel";
            this.btnAddSteel.Size = new System.Drawing.Size(23, 22);
            this.btnAddSteel.Text = "toolStripButton6";
            this.btnAddSteel.Click += new System.EventHandler(this.btnAddSteel_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteSteel
            // 
            this.btnDeleteSteel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteSteel.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSteel.Image")));
            this.btnDeleteSteel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSteel.Name = "btnDeleteSteel";
            this.btnDeleteSteel.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteSteel.Text = "toolStripButton11";
            this.btnDeleteSteel.Click += new System.EventHandler(this.btnDeleteSteel_Click);
            // 
            // dvSteel
            // 
            this.dvSteel.AllowUserToAddRows = false;
            this.dvSteel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSteel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.colWeight});
            this.dvSteel.Location = new System.Drawing.Point(0, 45);
            this.dvSteel.Name = "dvSteel";
            this.dvSteel.RowTemplate.Height = 23;
            this.dvSteel.Size = new System.Drawing.Size(291, 119);
            this.dvSteel.TabIndex = 1;
            
            this.dvSteel.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvSteel_CellEndEdit);
            this.dvSteel.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dvSteel_RowPostPaint);
            // 
            // ColName
            // 
            this.ColName.DataSource = this.dsSteelName;
            this.ColName.DisplayMember = "L3DataTable.Code_Des";
            this.ColName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.ColName.HeaderText = "废钢名称";
            this.ColName.Name = "ColName";
            this.ColName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColName.ValueMember = "L3DataTable.Code";
            // 
            // dsSteelName
            // 
            this.dsSteelName.AutoLoad = true;
            this.dsSteelName.AutoSubscribe = false;
            this.dsSteelName.DataSetName = "L3DataSet";
            this.dsSteelName.DeleteMethod = null;
            this.dsSteelName.InsertMethod = null;
            this.dsSteelName.L3DataAdapter = this.Adapter;
            this.dsSteelName.LoadEvent = "Click";
            this.dsSteelName.LoadTrigger = null;
            this.dsSteelName.RefreshValve = 1000;
            this.dsSteelName.SourceCommand = null;
            this.dsSteelName.SourceCondition = "CODE_GROUP = \'ScrapGroupName\' ";
            this.dsSteelName.SourceMethod = "";
            this.dsSteelName.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSteelName.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSteelName.SubscribeTarget = "";
            this.dsSteelName.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSteelName});
            this.dsSteelName.UpdateEvent = "Click";
            this.dsSteelName.UpdateMethod = null;
            this.dsSteelName.UpdateTrigger = null;
            // 
            // schemadsSteelName
            // 
            this.schemadsSteelName.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSteelNameL3DataTableCode,
            this.coldsSteelNameL3DataTableCode_Des});
            this.schemadsSteelName.TableName = "L3DataTable";
            // 
            // coldsSteelNameL3DataTableCode
            // 
            this.coldsSteelNameL3DataTableCode.Caption = "Code";
            this.coldsSteelNameL3DataTableCode.ColumnName = "Code";
            this.coldsSteelNameL3DataTableCode.Namespace = "";
            // 
            // coldsSteelNameL3DataTableCode_Des
            // 
            this.coldsSteelNameL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSteelNameL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSteelNameL3DataTableCode_Des.Namespace = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancel);
            this.panel4.Controls.Add(this.btnConfirm);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(389, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 29);
            this.panel4.TabIndex = 7;
            // 
            // dsSend
            // 
            this.dsSend.AutoLoad = true;
            this.dsSend.AutoSubscribe = false;
            this.dsSend.DataSetName = "L3DataSet";
            this.dsSend.DeleteMethod = null;
            this.dsSend.InsertMethod = null;
            this.dsSend.L3DataAdapter = this.Adapter;
            this.dsSend.LoadEvent = "Click";
            this.dsSend.LoadTrigger = null;
            this.dsSend.RefreshValve = 1000;
            this.dsSend.SourceCommand = null;
            this.dsSend.SourceCondition = "";
            this.dsSend.SourceMethod = "";
            this.dsSend.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsSend.SourceURI = "";
            this.dsSend.SubscribeTarget = "";
            this.dsSend.UpdateEvent = "Click";
            this.dsSend.UpdateMethod = null;
            this.dsSend.UpdateTrigger = null;
            // 
            // cmdSteelIron
            // 
            this.cmdSteelIron.Adapter = this.Adapter;
            this.cmdSteelIron.MergeReturnTarget = false;
            this.cmdSteelIron.Method = "SaveScrapOutDetail";
            this.cmdSteelIron.Object = "XGMESLogic\\ScrapStoreMag\\CScrap_Store_Mag\\S82";
            this.cmdSteelIron.Parameters.Add(this.l3CommandParameter2);
            this.cmdSteelIron.ReturnTarget = null;
            this.cmdSteelIron.ReturnTargetProperty = null;
            this.cmdSteelIron.Trigger = null;
            this.cmdSteelIron.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = this.dsSend;
            this.l3CommandParameter2.SourceProperty = "";
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsSend;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.dsScrapOutStoreConfirm;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "重量";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "重量";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "重量";
            this.Column4.Name = "Column4";
            // 
            // colWeight
            // 
            this.colWeight.HeaderText = "重量";
            this.colWeight.Name = "colWeight";
            // 
            // ScrapOutStoreShowFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 361);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "ScrapOutStoreShowFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "废钢生铁出库";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScrapOutStoreShowFrm_FormClosing);
            this.Load += new System.EventHandler(this.ScrapOutStoreShowFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsScrapOutStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsScrapOutStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsScrapOutStoreConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStoreAreaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStoreAreaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIron)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSteelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSteelName)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsScrapOutStore;
        private AppSvrHMI.L3DataSet dsScrapOutStoreConfirm;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private buttonHide.MyLine myLine1;
        private PxDataValid.PxTextBox txtTareWeight;
        private PxDataValid.PxTextBox txtSTAmount;
        private PxDataValid.PxTextBox txtNetWeight;
        private PxDataValid.PxTextBox txtGrossWeight;
        private PxDataValid.PxTextBox txtScrapSlotID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private AppSvrHMI.L3DataSet dsStoreAreaID;
        private System.Data.DataTable schemadsStoreAreaID;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode;
        private System.Data.DataColumn coldsStoreAreaIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsScrapOutStoreConfirm;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableMaterialType;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableMaterialID;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableAmount;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableStoreAreaID;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableScrap_Slot_ID;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableCar_ID;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableCar_Type;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableNet_Weight;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableGross_Weight;
        private System.Data.DataColumn coldsScrapOutStoreConfirmL3DataTableTare_Weight;
        private PxDataValid.PxTextBox txtFGAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private AppSvrHMI.L3Command cmdScrapOutStore;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvIron;
        private System.Windows.Forms.DataGridView dvSteel;
        private AppSvrHMI.L3DataSet dsSteelName;
        private System.Data.DataTable schemadsSteelName;
        private System.Data.DataColumn coldsSteelNameL3DataTableCode;
        private System.Data.DataColumn coldsSteelNameL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsIron;
        private System.Data.DataTable schemadsIron;
        private System.Data.DataColumn coldsIronL3DataTableCode;
        private System.Data.DataColumn coldsIronL3DataTableCode_Des;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddIron;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnDeleteIron;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddSteel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnDeleteSteel;
        private AppSvrHMI.L3DataSet dsSend;
        private AppSvrHMI.L3Command cmdSteelIron;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}