namespace EquipMag.LanceMag
{
    partial class LanceBaseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanceBaseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
            this.dsBase = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.schemadsBase = new System.Data.DataTable();
            this.coldsBaseL3DataTableGUID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableName = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLanceID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableBOFID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableStatus = new System.Data.DataColumn();
            this.coldsBaseL3DataTableNozzle_Factury = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLance_Head_Type = new System.Data.DataColumn();
            this.coldsBaseL3DataTableLance_Age = new System.Data.DataColumn();
            this.coldsBaseL3DataTableMakeID = new System.Data.DataColumn();
            this.coldsBaseL3DataTableMake_Start_Time = new System.Data.DataColumn();
            this.coldsBaseL3DataTableMake_End_Time = new System.Data.DataColumn();
            this.coldsBaseL3DataTableCheckFlag = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnDefendStrat = new System.Windows.Forms.ToolStripButton();
            this.btnDefendEnd = new System.Windows.Forms.ToolStripButton();
            this.btnOn = new System.Windows.Forms.ToolStripButton();
            this.btnOff = new System.Windows.Forms.ToolStripButton();
            this.btnCheckCom = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnUseAgain = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWaitRepair = new System.Windows.Forms.ToolStripMenuItem();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBase = new System.Windows.Forms.DataGridView();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.nozzleFacturyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanceHeadTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanceAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeEndTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdDefendStrat = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpDefendStrat = new AppSvrHMI.L3CommandParameter();
            this.cmdDefendEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpDefendEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdChangeOn = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpChangeOn = new AppSvrHMI.L3CommandParameter();
            this.cmdOffCheck = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOffCheck = new AppSvrHMI.L3CommandParameter();
            this.cmdOffLine = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOffLine = new AppSvrHMI.L3CommandParameter();
            this.cmdFree = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpFree = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "L3DataTable";
            this.bsBase.DataSource = this.dsBase;
            // 
            // dsBase
            // 
            this.dsBase.AutoSubscribe = true;
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
            this.dsBase.SourceURI = "XGMESLogic\\LanceMag\\CLance_Base";
            this.dsBase.SubscribeTarget = null;
            this.dsBase.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBase});
            this.dsBase.UpdateEvent = "Click";
            this.dsBase.UpdateMethod = null;
            this.dsBase.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnAddLance");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // schemadsBase
            // 
            this.schemadsBase.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBaseL3DataTableGUID,
            this.coldsBaseL3DataTableName,
            this.coldsBaseL3DataTableLanceID,
            this.coldsBaseL3DataTableBOFID,
            this.coldsBaseL3DataTableStatus,
            this.coldsBaseL3DataTableNozzle_Factury,
            this.coldsBaseL3DataTableLance_Head_Type,
            this.coldsBaseL3DataTableLance_Age,
            this.coldsBaseL3DataTableMakeID,
            this.coldsBaseL3DataTableMake_Start_Time,
            this.coldsBaseL3DataTableMake_End_Time,
            this.coldsBaseL3DataTableCheckFlag});
            this.schemadsBase.TableName = "L3DataTable";
            // 
            // coldsBaseL3DataTableGUID
            // 
            this.coldsBaseL3DataTableGUID.Caption = "GUID";
            this.coldsBaseL3DataTableGUID.ColumnName = "GUID";
            this.coldsBaseL3DataTableGUID.Namespace = "";
            // 
            // coldsBaseL3DataTableName
            // 
            this.coldsBaseL3DataTableName.Caption = "Name";
            this.coldsBaseL3DataTableName.ColumnName = "Name";
            this.coldsBaseL3DataTableName.Namespace = "";
            // 
            // coldsBaseL3DataTableLanceID
            // 
            this.coldsBaseL3DataTableLanceID.Caption = "LanceID";
            this.coldsBaseL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsBaseL3DataTableLanceID.Namespace = "";
            // 
            // coldsBaseL3DataTableBOFID
            // 
            this.coldsBaseL3DataTableBOFID.Caption = "BOFID";
            this.coldsBaseL3DataTableBOFID.ColumnName = "BOFID";
            this.coldsBaseL3DataTableBOFID.Namespace = "";
            // 
            // coldsBaseL3DataTableStatus
            // 
            this.coldsBaseL3DataTableStatus.Caption = "Status";
            this.coldsBaseL3DataTableStatus.ColumnName = "Status";
            this.coldsBaseL3DataTableStatus.Namespace = "";
            // 
            // coldsBaseL3DataTableNozzle_Factury
            // 
            this.coldsBaseL3DataTableNozzle_Factury.Caption = "Nozzle_Factury";
            this.coldsBaseL3DataTableNozzle_Factury.ColumnName = "Nozzle_Factury";
            this.coldsBaseL3DataTableNozzle_Factury.Namespace = "";
            // 
            // coldsBaseL3DataTableLance_Head_Type
            // 
            this.coldsBaseL3DataTableLance_Head_Type.Caption = "Lance_Head_Type";
            this.coldsBaseL3DataTableLance_Head_Type.ColumnName = "Lance_Head_Type";
            this.coldsBaseL3DataTableLance_Head_Type.Namespace = "";
            // 
            // coldsBaseL3DataTableLance_Age
            // 
            this.coldsBaseL3DataTableLance_Age.Caption = "Lance_Age";
            this.coldsBaseL3DataTableLance_Age.ColumnName = "Lance_Age";
            this.coldsBaseL3DataTableLance_Age.DataType = typeof(int);
            this.coldsBaseL3DataTableLance_Age.Namespace = "";
            // 
            // coldsBaseL3DataTableMakeID
            // 
            this.coldsBaseL3DataTableMakeID.Caption = "MakeID";
            this.coldsBaseL3DataTableMakeID.ColumnName = "MakeID";
            this.coldsBaseL3DataTableMakeID.Namespace = "";
            // 
            // coldsBaseL3DataTableMake_Start_Time
            // 
            this.coldsBaseL3DataTableMake_Start_Time.Caption = "Make_Start_Time";
            this.coldsBaseL3DataTableMake_Start_Time.ColumnName = "Make_Start_Time";
            this.coldsBaseL3DataTableMake_Start_Time.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableMake_Start_Time.Namespace = "";
            // 
            // coldsBaseL3DataTableMake_End_Time
            // 
            this.coldsBaseL3DataTableMake_End_Time.Caption = "Make_End_Time";
            this.coldsBaseL3DataTableMake_End_Time.ColumnName = "Make_End_Time";
            this.coldsBaseL3DataTableMake_End_Time.DataType = typeof(System.DateTime);
            this.coldsBaseL3DataTableMake_End_Time.Namespace = "";
            // 
            // coldsBaseL3DataTableCheckFlag
            // 
            this.coldsBaseL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsBaseL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsBaseL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsBaseL3DataTableCheckFlag.Namespace = "";
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bdN1, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsBase;
            this.bdN1.CountItem = this.bindingNavigatorCountItem;
            this.bdN1.DeleteItem = null;
            this.bdN1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnAdd,
            this.btnDelete});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 27;
            this.bdN1.Text = "bindingNavigator1";
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // btnDelete
            // 
            this.Adapter.SetAccessRight(this.btnDelete, "btnDeleteLance");
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnDefendStrat,
            this.btnDefendEnd,
            this.btnOn,
            this.btnOff,
            this.btnCheckCom});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 26;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 40);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDefendStrat
            // 
            this.btnDefendStrat.Image = ((System.Drawing.Image)(resources.GetObject("btnDefendStrat.Image")));
            this.btnDefendStrat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDefendStrat.Name = "btnDefendStrat";
            this.btnDefendStrat.Size = new System.Drawing.Size(113, 40);
            this.btnDefendStrat.Text = "氧枪制作开始";
            this.btnDefendStrat.Click += new System.EventHandler(this.btnDefendStrat_Click);
            // 
            // btnDefendEnd
            // 
            this.btnDefendEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnDefendEnd.Image")));
            this.btnDefendEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDefendEnd.Name = "btnDefendEnd";
            this.btnDefendEnd.Size = new System.Drawing.Size(113, 40);
            this.btnDefendEnd.Text = "氧枪制作结束";
            this.btnDefendEnd.Click += new System.EventHandler(this.btnDefendEnd_Click);
            // 
            // btnOn
            // 
            this.btnOn.Image = ((System.Drawing.Image)(resources.GetObject("btnOn.Image")));
            this.btnOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(113, 40);
            this.btnOn.Text = "人工换上氧枪";
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.Image")));
            this.btnOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(137, 40);
            this.btnOff.Text = "人工换下氧枪检查";
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnCheckCom
            // 
            this.btnCheckCom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUseAgain,
            this.btnWaitRepair});
            this.btnCheckCom.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckCom.Image")));
            this.btnCheckCom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckCom.Name = "btnCheckCom";
            this.btnCheckCom.Size = new System.Drawing.Size(122, 40);
            this.btnCheckCom.Text = "下线检查完毕";
            // 
            // btnUseAgain
            // 
            this.btnUseAgain.Name = "btnUseAgain";
            this.btnUseAgain.Size = new System.Drawing.Size(142, 22);
            this.btnUseAgain.Text = "准备再次上线";
            this.btnUseAgain.Click += new System.EventHandler(this.btnUseAgain_Click);
            // 
            // btnWaitRepair
            // 
            this.btnWaitRepair.Name = "btnWaitRepair";
            this.btnWaitRepair.Size = new System.Drawing.Size(142, 22);
            this.btnWaitRepair.Text = "离线待修";
            this.btnWaitRepair.Click += new System.EventHandler(this.btnWaitRepair_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBase);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvBase
            // 
            this.dvBase.AllowUserToAddRows = false;
            this.dvBase.AutoGenerateColumns = false;
            this.dvBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.LanceID,
            this.bOFIDDataGridViewTextBoxColumn,
            this.Status,
            this.nozzleFacturyDataGridViewTextBoxColumn,
            this.lanceHeadTypeDataGridViewTextBoxColumn,
            this.lanceAgeDataGridViewTextBoxColumn,
            this.makeIDDataGridViewTextBoxColumn,
            this.makeStartTimeDataGridViewTextBoxColumn,
            this.makeEndTimeDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dvBase.DataSource = this.bsBase;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvBase.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBase.Location = new System.Drawing.Point(0, 0);
            this.dvBase.Margin = new System.Windows.Forms.Padding(0);
            this.dvBase.Name = "dvBase";
            this.dvBase.RowTemplate.Height = 23;
            this.dvBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvBase.Size = new System.Drawing.Size(1000, 632);
            this.dvBase.TabIndex = 31;
            this.dvBase.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvBase_DataBindingComplete);
            // 
            // checkFlagDataGridViewTextBoxColumn
            // 
            this.checkFlagDataGridViewTextBoxColumn.DataPropertyName = "CheckFlag";
            this.checkFlagDataGridViewTextBoxColumn.FalseValue = "0";
            this.checkFlagDataGridViewTextBoxColumn.HeaderText = "选择";
            this.checkFlagDataGridViewTextBoxColumn.Name = "checkFlagDataGridViewTextBoxColumn";
            this.checkFlagDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkFlagDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkFlagDataGridViewTextBoxColumn.TrueValue = "1";
            this.checkFlagDataGridViewTextBoxColumn.Width = 54;
            // 
            // LanceID
            // 
            this.LanceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LanceID.DataPropertyName = "LanceID";
            this.LanceID.HeaderText = "氧枪编号";
            this.LanceID.Name = "LanceID";
            this.LanceID.ReadOnly = true;
            // 
            // bOFIDDataGridViewTextBoxColumn
            // 
            this.bOFIDDataGridViewTextBoxColumn.DataPropertyName = "BOFID";
            this.bOFIDDataGridViewTextBoxColumn.HeaderText = "炉座";
            this.bOFIDDataGridViewTextBoxColumn.Name = "bOFIDDataGridViewTextBoxColumn";
            this.bOFIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOFIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.DataSource = this.dsStatus;
            this.Status.DisplayMember = "L3DataTable.Code_Des";
            this.Status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.ValueMember = "L3DataTable.Code";
            this.Status.Width = 54;
            // 
            // dsStatus
            // 
            this.dsStatus.AutoSubscribe = true;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "Code_Group = \'LanceStatus\'";
            this.dsStatus.SourceMethod = "";
            this.dsStatus.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsStatus.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsStatus.SubscribeTarget = null;
            this.dsStatus.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsStatus});
            this.dsStatus.UpdateEvent = "Click";
            this.dsStatus.UpdateMethod = null;
            this.dsStatus.UpdateTrigger = null;
            // 
            // schemadsStatus
            // 
            this.schemadsStatus.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsStatusL3DataTableCode,
            this.coldsStatusL3DataTableCode_Des});
            this.schemadsStatus.TableName = "L3DataTable";
            // 
            // coldsStatusL3DataTableCode
            // 
            this.coldsStatusL3DataTableCode.Caption = "Code";
            this.coldsStatusL3DataTableCode.ColumnName = "Code";
            this.coldsStatusL3DataTableCode.Namespace = "";
            // 
            // coldsStatusL3DataTableCode_Des
            // 
            this.coldsStatusL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsStatusL3DataTableCode_Des.Namespace = "";
            // 
            // nozzleFacturyDataGridViewTextBoxColumn
            // 
            this.nozzleFacturyDataGridViewTextBoxColumn.DataPropertyName = "Nozzle_Factury";
            this.nozzleFacturyDataGridViewTextBoxColumn.HeaderText = "喷头厂家";
            this.nozzleFacturyDataGridViewTextBoxColumn.Name = "nozzleFacturyDataGridViewTextBoxColumn";
            this.nozzleFacturyDataGridViewTextBoxColumn.ReadOnly = true;
            this.nozzleFacturyDataGridViewTextBoxColumn.Visible = false;
            this.nozzleFacturyDataGridViewTextBoxColumn.Width = 78;
            // 
            // lanceHeadTypeDataGridViewTextBoxColumn
            // 
            this.lanceHeadTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lanceHeadTypeDataGridViewTextBoxColumn.DataPropertyName = "Lance_Head_Type";
            this.lanceHeadTypeDataGridViewTextBoxColumn.HeaderText = "枪头型号\r\n";
            this.lanceHeadTypeDataGridViewTextBoxColumn.Name = "lanceHeadTypeDataGridViewTextBoxColumn";
            this.lanceHeadTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lanceAgeDataGridViewTextBoxColumn
            // 
            this.lanceAgeDataGridViewTextBoxColumn.DataPropertyName = "Lance_Age";
            this.lanceAgeDataGridViewTextBoxColumn.HeaderText = "枪龄";
            this.lanceAgeDataGridViewTextBoxColumn.Name = "lanceAgeDataGridViewTextBoxColumn";
            this.lanceAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lanceAgeDataGridViewTextBoxColumn.Width = 54;
            // 
            // makeIDDataGridViewTextBoxColumn
            // 
            this.makeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makeIDDataGridViewTextBoxColumn.DataPropertyName = "MakeID";
            this.makeIDDataGridViewTextBoxColumn.HeaderText = "氧枪制作编号";
            this.makeIDDataGridViewTextBoxColumn.Name = "makeIDDataGridViewTextBoxColumn";
            this.makeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makeStartTimeDataGridViewTextBoxColumn
            // 
            this.makeStartTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makeStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Make_Start_Time";
            this.makeStartTimeDataGridViewTextBoxColumn.HeaderText = "氧枪制作开始时间";
            this.makeStartTimeDataGridViewTextBoxColumn.Name = "makeStartTimeDataGridViewTextBoxColumn";
            this.makeStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makeEndTimeDataGridViewTextBoxColumn
            // 
            this.makeEndTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.makeEndTimeDataGridViewTextBoxColumn.DataPropertyName = "Make_End_Time";
            this.makeEndTimeDataGridViewTextBoxColumn.HeaderText = "氧枪制作结束时间";
            this.makeEndTimeDataGridViewTextBoxColumn.Name = "makeEndTimeDataGridViewTextBoxColumn";
            this.makeEndTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // cmdDefendStrat
            // 
            this.cmdDefendStrat.Adapter = this.Adapter;
            this.cmdDefendStrat.MergeReturnTarget = false;
            this.cmdDefendStrat.Method = "LanceDefendStrat";
            this.cmdDefendStrat.Object = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.cmdDefendStrat.Parameters.Add(this.l3cmdpDefendStrat);
            this.cmdDefendStrat.ReturnTarget = null;
            this.cmdDefendStrat.ReturnTargetProperty = null;
            this.cmdDefendStrat.Trigger = null;
            this.cmdDefendStrat.TriggerEvent = "Click";
            // 
            // l3cmdpDefendStrat
            // 
            this.l3cmdpDefendStrat.AcceptAfterExecuted = false;
            this.l3cmdpDefendStrat.ConstantValue = null;
            this.l3cmdpDefendStrat.MergeTarget = false;
            this.l3cmdpDefendStrat.SourceFilter = null;
            this.l3cmdpDefendStrat.SourceObject = this.dsBase;
            this.l3cmdpDefendStrat.SourceProperty = "L3DataTable";
            this.l3cmdpDefendStrat.TargetObject = null;
            this.l3cmdpDefendStrat.TargetProperty = null;
            // 
            // cmdDefendEnd
            // 
            this.cmdDefendEnd.Adapter = this.Adapter;
            this.cmdDefendEnd.MergeReturnTarget = false;
            this.cmdDefendEnd.Method = "LanceDefendEnd";
            this.cmdDefendEnd.Object = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.cmdDefendEnd.Parameters.Add(this.l3cmdpDefendEnd);
            this.cmdDefendEnd.ReturnTarget = null;
            this.cmdDefendEnd.ReturnTargetProperty = null;
            this.cmdDefendEnd.Trigger = null;
            this.cmdDefendEnd.TriggerEvent = "Click";
            // 
            // l3cmdpDefendEnd
            // 
            this.l3cmdpDefendEnd.AcceptAfterExecuted = false;
            this.l3cmdpDefendEnd.ConstantValue = null;
            this.l3cmdpDefendEnd.MergeTarget = false;
            this.l3cmdpDefendEnd.SourceFilter = null;
            this.l3cmdpDefendEnd.SourceObject = this.dsBase;
            this.l3cmdpDefendEnd.SourceProperty = "L3DataTable";
            this.l3cmdpDefendEnd.TargetObject = null;
            this.l3cmdpDefendEnd.TargetProperty = null;
            // 
            // cmdChangeOn
            // 
            this.cmdChangeOn.Adapter = this.Adapter;
            this.cmdChangeOn.MergeReturnTarget = false;
            this.cmdChangeOn.Method = "LanceChangeOn";
            this.cmdChangeOn.Object = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.cmdChangeOn.Parameters.Add(this.l3cmdpChangeOn);
            this.cmdChangeOn.ReturnTarget = null;
            this.cmdChangeOn.ReturnTargetProperty = null;
            this.cmdChangeOn.Trigger = null;
            this.cmdChangeOn.TriggerEvent = "Click";
            // 
            // l3cmdpChangeOn
            // 
            this.l3cmdpChangeOn.AcceptAfterExecuted = false;
            this.l3cmdpChangeOn.ConstantValue = null;
            this.l3cmdpChangeOn.MergeTarget = false;
            this.l3cmdpChangeOn.SourceFilter = null;
            this.l3cmdpChangeOn.SourceObject = this.dsBase;
            this.l3cmdpChangeOn.SourceProperty = "L3DataTable";
            this.l3cmdpChangeOn.TargetObject = null;
            this.l3cmdpChangeOn.TargetProperty = "";
            // 
            // cmdOffCheck
            // 
            this.cmdOffCheck.Adapter = this.Adapter;
            this.cmdOffCheck.MergeReturnTarget = false;
            this.cmdOffCheck.Method = "LanceOffLineCheck";
            this.cmdOffCheck.Object = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.cmdOffCheck.Parameters.Add(this.l3cmdpOffCheck);
            this.cmdOffCheck.ReturnTarget = null;
            this.cmdOffCheck.ReturnTargetProperty = null;
            this.cmdOffCheck.Trigger = null;
            this.cmdOffCheck.TriggerEvent = "Click";
            // 
            // l3cmdpOffCheck
            // 
            this.l3cmdpOffCheck.AcceptAfterExecuted = false;
            this.l3cmdpOffCheck.ConstantValue = null;
            this.l3cmdpOffCheck.MergeTarget = false;
            this.l3cmdpOffCheck.SourceFilter = null;
            this.l3cmdpOffCheck.SourceObject = this.dsBase;
            this.l3cmdpOffCheck.SourceProperty = "L3DataTable";
            this.l3cmdpOffCheck.TargetObject = null;
            this.l3cmdpOffCheck.TargetProperty = null;
            // 
            // cmdOffLine
            // 
            this.cmdOffLine.Adapter = this.Adapter;
            this.cmdOffLine.MergeReturnTarget = false;
            this.cmdOffLine.Method = "LanceChangeOff";
            this.cmdOffLine.Object = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.cmdOffLine.Parameters.Add(this.l3cmdpOffLine);
            this.cmdOffLine.ReturnTarget = null;
            this.cmdOffLine.ReturnTargetProperty = null;
            this.cmdOffLine.Trigger = null;
            this.cmdOffLine.TriggerEvent = "Click";
            // 
            // l3cmdpOffLine
            // 
            this.l3cmdpOffLine.AcceptAfterExecuted = false;
            this.l3cmdpOffLine.ConstantValue = null;
            this.l3cmdpOffLine.MergeTarget = false;
            this.l3cmdpOffLine.SourceFilter = null;
            this.l3cmdpOffLine.SourceObject = this.dsBase;
            this.l3cmdpOffLine.SourceProperty = "L3DataTable";
            this.l3cmdpOffLine.TargetObject = null;
            this.l3cmdpOffLine.TargetProperty = null;
            // 
            // cmdFree
            // 
            this.cmdFree.Adapter = this.Adapter;
            this.cmdFree.MergeReturnTarget = false;
            this.cmdFree.Method = "LanceFree";
            this.cmdFree.Object = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.cmdFree.Parameters.Add(this.l3cmdpFree);
            this.cmdFree.ReturnTarget = null;
            this.cmdFree.ReturnTargetProperty = null;
            this.cmdFree.Trigger = null;
            this.cmdFree.TriggerEvent = "Click";
            // 
            // l3cmdpFree
            // 
            this.l3cmdpFree.AcceptAfterExecuted = false;
            this.l3cmdpFree.ConstantValue = null;
            this.l3cmdpFree.MergeTarget = false;
            this.l3cmdpFree.SourceFilter = null;
            this.l3cmdpFree.SourceObject = this.dsBase;
            this.l3cmdpFree.SourceProperty = "L3DataTable";
            this.l3cmdpFree.TargetObject = null;
            this.l3cmdpFree.TargetProperty = null;
            // 
            // LanceBaseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LanceBaseMagFrm";
            this.TabText = "氧枪基本信息管理";
            this.Text = "氧枪基本信息管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanceBaseMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LanceBaseMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBase)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBase;
        private System.Windows.Forms.ToolStripButton btnDefendStrat;
        private System.Windows.Forms.ToolStripButton btnDefendEnd;
        private System.Windows.Forms.ToolStripButton btnOn;
        private System.Windows.Forms.ToolStripButton btnOff;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdDefendStrat;
        private AppSvrHMI.L3CommandParameter l3cmdpDefendStrat;
        private AppSvrHMI.L3Command cmdDefendEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpDefendEnd;
        private AppSvrHMI.L3Command cmdChangeOn;
        private AppSvrHMI.L3CommandParameter l3cmdpChangeOn;
        private AppSvrHMI.L3Command cmdOffCheck;
        private AppSvrHMI.L3CommandParameter l3cmdpOffCheck;
        private AppSvrHMI.L3DataSet dsBase;
        private System.Data.DataTable schemadsBase;
        private System.Data.DataColumn coldsBaseL3DataTableGUID;
        private System.Data.DataColumn coldsBaseL3DataTableName;
        private System.Data.DataColumn coldsBaseL3DataTableLanceID;
        private System.Data.DataColumn coldsBaseL3DataTableBOFID;
        private System.Data.DataColumn coldsBaseL3DataTableStatus;
        private System.Data.DataColumn coldsBaseL3DataTableNozzle_Factury;
        private System.Data.DataColumn coldsBaseL3DataTableLance_Head_Type;
        private System.Data.DataColumn coldsBaseL3DataTableLance_Age;
        private System.Data.DataColumn coldsBaseL3DataTableMakeID;
        private System.Data.DataColumn coldsBaseL3DataTableMake_Start_Time;
        private System.Data.DataColumn coldsBaseL3DataTableMake_End_Time;
        private System.Data.DataColumn coldsBaseL3DataTableCheckFlag;
        private System.Windows.Forms.ToolStripDropDownButton btnCheckCom;
        private System.Windows.Forms.ToolStripMenuItem btnUseAgain;
        private System.Windows.Forms.ToolStripMenuItem btnWaitRepair;
        private AppSvrHMI.L3Command cmdOffLine;
        private AppSvrHMI.L3CommandParameter l3cmdpOffLine;
        private AppSvrHMI.L3Command cmdFree;
        private AppSvrHMI.L3CommandParameter l3cmdpFree;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn nozzleFacturyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceHeadTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanceAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeEndTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
    }
}