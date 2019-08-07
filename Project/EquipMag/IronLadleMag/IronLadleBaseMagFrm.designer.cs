namespace EquipMag.IronLadleMag
{
    partial class IronLadleBaseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronLadleBaseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsIronLadle = new System.Windows.Forms.BindingSource(this.components);
            this.dsIronLadle = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnTieStart = new System.Windows.Forms.ToolStripButton();
            this.btnTieEnd = new System.Windows.Forms.ToolStripButton();
            this.btnSmallFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnSmallFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnMidFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnMidFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnBigFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnBigFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnHot = new System.Windows.Forms.ToolStripButton();
            this.btnUse = new System.Windows.Forms.ToolStripButton();
            this.btnStopUse = new System.Windows.Forms.ToolStripButton();
            this.btnWaitRepair = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnOffLineException = new System.Windows.Forms.ToolStripButton();
            this.schemadsIronLadle = new System.Data.DataTable();
            this.coldsIronLadleL3DataTableIronLadleID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableStatus = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableTare_Weight = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableGross_Weight = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableNet_Weight = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableRefra_Produce = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableRefra_ID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableIronLadle_Age = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableTieID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableComFlag = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableSmall_FireID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableMiddle_FireID = new System.Data.DataColumn();
            this.coldsIronLadleL3DataTableBig_FireID = new System.Data.DataColumn();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvIronLadle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IronLadleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.ComFlag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ironLadleAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Small_FireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Middle_FireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Big_FireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refraProduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refraIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnIronLadle = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.dsLadleGrade = new AppSvrHMI.L3DataSet();
            this.dsRefraFac = new AppSvrHMI.L3DataSet();
            this.cmdTieStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTieStart = new AppSvrHMI.L3CommandParameter();
            this.cmdTieEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTieEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdSmallFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpSmallFireStart = new AppSvrHMI.L3CommandParameter();
            this.cmdSmallFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.cmdMiddleFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter5 = new AppSvrHMI.L3CommandParameter();
            this.cmdMiddleFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter6 = new AppSvrHMI.L3CommandParameter();
            this.cmdBigFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter7 = new AppSvrHMI.L3CommandParameter();
            this.cmdBigFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter9 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter8 = new AppSvrHMI.L3CommandParameter();
            this.cmdStopUse = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpStopUse = new AppSvrHMI.L3CommandParameter();
            this.cmdWaitRepair = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWaitRepair = new AppSvrHMI.L3CommandParameter();
            this.cmdUse = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpUse = new AppSvrHMI.L3CommandParameter();
            this.cmdHot = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpHot = new AppSvrHMI.L3CommandParameter();
            this.cmdOffLineException = new AppSvrHMI.L3Command(this.components);
            this.cmdpOffLineException = new AppSvrHMI.L3CommandParameter();
            ((System.ComponentModel.ISupportInitialize)(this.bsIronLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadle)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvIronLadle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnIronLadle)).BeginInit();
            this.bnIronLadle.SuspendLayout();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraFac)).BeginInit();
            this.SuspendLayout();
            // 
            // bsIronLadle
            // 
            this.bsIronLadle.DataMember = "L3DataTable";
            this.bsIronLadle.DataSource = this.dsIronLadle;
            // 
            // dsIronLadle
            // 
            this.dsIronLadle.AutoLoad = true;
            this.dsIronLadle.AutoSubscribe = true;
            this.dsIronLadle.DataSetName = "L3DataSet";
            this.dsIronLadle.DeleteMethod = null;
            this.dsIronLadle.InsertMethod = null;
            this.dsIronLadle.L3DataAdapter = this.Adapter;
            this.dsIronLadle.LoadEvent = "Click";
            this.dsIronLadle.LoadTrigger = null;
            this.dsIronLadle.RefreshValve = 1000;
            this.dsIronLadle.SourceCommand = null;
            this.dsIronLadle.SourceCondition = null;
            this.dsIronLadle.SourceMethod = "";
            this.dsIronLadle.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadle.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Base";
            this.dsIronLadle.SubscribeTarget = null;
            this.dsIronLadle.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadle});
            this.dsIronLadle.UpdateEvent = "Click";
            this.dsIronLadle.UpdateMethod = null;
            this.dsIronLadle.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnTieStart
            // 
            this.Adapter.SetAccessRight(this.btnTieStart, "IronLadebtnTieStart");
            this.btnTieStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTieStart.Image = ((System.Drawing.Image)(resources.GetObject("btnTieStart.Image")));
            this.btnTieStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTieStart.Name = "btnTieStart";
            this.btnTieStart.Size = new System.Drawing.Size(81, 40);
            this.btnTieStart.Text = "铁包打结开始";
            this.btnTieStart.Click += new System.EventHandler(this.btnTieStart_Click);
            // 
            // btnTieEnd
            // 
            this.Adapter.SetAccessRight(this.btnTieEnd, "IronLadebtnTieEnd");
            this.btnTieEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTieEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnTieEnd.Image")));
            this.btnTieEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTieEnd.Name = "btnTieEnd";
            this.btnTieEnd.Size = new System.Drawing.Size(81, 40);
            this.btnTieEnd.Text = "铁包打结结束";
            this.btnTieEnd.Click += new System.EventHandler(this.btnTieEnd_Click);
            // 
            // btnSmallFireStart
            // 
            this.Adapter.SetAccessRight(this.btnSmallFireStart, "IronLadebtnSmallFireStart");
            this.btnSmallFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSmallFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnSmallFireStart.Image")));
            this.btnSmallFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSmallFireStart.Name = "btnSmallFireStart";
            this.btnSmallFireStart.Size = new System.Drawing.Size(57, 40);
            this.btnSmallFireStart.Text = "小火开始";
            this.btnSmallFireStart.Click += new System.EventHandler(this.btnSmallFireStart_Click);
            // 
            // btnSmallFireEnd
            // 
            this.Adapter.SetAccessRight(this.btnSmallFireEnd, "IronLadebtnSmallFireEnd");
            this.btnSmallFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSmallFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnSmallFireEnd.Image")));
            this.btnSmallFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSmallFireEnd.Name = "btnSmallFireEnd";
            this.btnSmallFireEnd.Size = new System.Drawing.Size(57, 40);
            this.btnSmallFireEnd.Text = "小火结束";
            this.btnSmallFireEnd.Click += new System.EventHandler(this.btnSmallFireEnd_Click);
            // 
            // btnMidFireStart
            // 
            this.Adapter.SetAccessRight(this.btnMidFireStart, "IronLadebtnMidFireStart");
            this.btnMidFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMidFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnMidFireStart.Image")));
            this.btnMidFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMidFireStart.Name = "btnMidFireStart";
            this.btnMidFireStart.Size = new System.Drawing.Size(57, 40);
            this.btnMidFireStart.Text = "中火开始";
            this.btnMidFireStart.Click += new System.EventHandler(this.btnMidFireStart_Click);
            // 
            // btnMidFireEnd
            // 
            this.Adapter.SetAccessRight(this.btnMidFireEnd, "IronLadebtnMidFireEnd");
            this.btnMidFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMidFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnMidFireEnd.Image")));
            this.btnMidFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMidFireEnd.Name = "btnMidFireEnd";
            this.btnMidFireEnd.Size = new System.Drawing.Size(57, 40);
            this.btnMidFireEnd.Text = "中火结束";
            this.btnMidFireEnd.Click += new System.EventHandler(this.btnMidFireEnd_Click);
            // 
            // btnBigFireStart
            // 
            this.Adapter.SetAccessRight(this.btnBigFireStart, "IronLadebtnBigFireStart");
            this.btnBigFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBigFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnBigFireStart.Image")));
            this.btnBigFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBigFireStart.Name = "btnBigFireStart";
            this.btnBigFireStart.Size = new System.Drawing.Size(57, 40);
            this.btnBigFireStart.Text = "大火开始";
            this.btnBigFireStart.Click += new System.EventHandler(this.btnBigFireStart_Click);
            // 
            // btnBigFireEnd
            // 
            this.Adapter.SetAccessRight(this.btnBigFireEnd, "IronLadebtnBigFireEnd");
            this.btnBigFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBigFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnBigFireEnd.Image")));
            this.btnBigFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBigFireEnd.Name = "btnBigFireEnd";
            this.btnBigFireEnd.Size = new System.Drawing.Size(57, 40);
            this.btnBigFireEnd.Text = "大火结束";
            this.btnBigFireEnd.Click += new System.EventHandler(this.btnBigFireEnd_Click);
            // 
            // btnHot
            // 
            this.Adapter.SetAccessRight(this.btnHot, "IronLadebtnHot");
            this.btnHot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHot.Image = ((System.Drawing.Image)(resources.GetObject("btnHot.Image")));
            this.btnHot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHot.Name = "btnHot";
            this.btnHot.Size = new System.Drawing.Size(57, 40);
            this.btnHot.Text = "转为热备";
            this.btnHot.Click += new System.EventHandler(this.btnHot_Click);
            // 
            // btnUse
            // 
            this.Adapter.SetAccessRight(this.btnUse, "IronLadebtnUse");
            this.btnUse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUse.Image = ((System.Drawing.Image)(resources.GetObject("btnUse.Image")));
            this.btnUse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUse.Name = "btnUse";
            this.btnUse.Size = new System.Drawing.Size(57, 40);
            this.btnUse.Text = "转为使用";
            this.btnUse.Click += new System.EventHandler(this.btnUse_Click);
            // 
            // btnStopUse
            // 
            this.Adapter.SetAccessRight(this.btnStopUse, "IronLadebtnStopUse");
            this.btnStopUse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnStopUse.Image = ((System.Drawing.Image)(resources.GetObject("btnStopUse.Image")));
            this.btnStopUse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStopUse.Name = "btnStopUse";
            this.btnStopUse.Size = new System.Drawing.Size(57, 40);
            this.btnStopUse.Text = "下线维护";
            this.btnStopUse.Click += new System.EventHandler(this.btnStopUse_Click);
            // 
            // btnWaitRepair
            // 
            this.Adapter.SetAccessRight(this.btnWaitRepair, "IronLadebtnWaitRepair");
            this.btnWaitRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWaitRepair.Image = ((System.Drawing.Image)(resources.GetObject("btnWaitRepair.Image")));
            this.btnWaitRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWaitRepair.Name = "btnWaitRepair";
            this.btnWaitRepair.Size = new System.Drawing.Size(57, 40);
            this.btnWaitRepair.Text = "离线待修";
            this.btnWaitRepair.Click += new System.EventHandler(this.btnWaitRepair_Click);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnAddIronLadle");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(49, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.Adapter.SetAccessRight(this.btnDelete, "btnDeleteIronLadle");
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(49, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOffLineException
            // 
            this.Adapter.SetAccessRight(this.btnOffLineException, "IronLadebtnBigFireEnd");
            this.btnOffLineException.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOffLineException.Image = ((System.Drawing.Image)(resources.GetObject("btnOffLineException.Image")));
            this.btnOffLineException.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffLineException.Name = "btnOffLineException";
            this.btnOffLineException.Size = new System.Drawing.Size(57, 40);
            this.btnOffLineException.Text = "异常下线";
            this.btnOffLineException.ToolTipText = "只对状态在\"使用\"以前的铁包有效";
            this.btnOffLineException.Click += new System.EventHandler(this.btnOffLineException_Click);
            // 
            // schemadsIronLadle
            // 
            this.schemadsIronLadle.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadleL3DataTableIronLadleID,
            this.coldsIronLadleL3DataTableStatus,
            this.coldsIronLadleL3DataTableTare_Weight,
            this.coldsIronLadleL3DataTableGross_Weight,
            this.coldsIronLadleL3DataTableNet_Weight,
            this.coldsIronLadleL3DataTableRefra_Produce,
            this.coldsIronLadleL3DataTableRefra_ID,
            this.coldsIronLadleL3DataTableIronLadle_Age,
            this.coldsIronLadleL3DataTableTieID,
            this.coldsIronLadleL3DataTableComFlag,
            this.coldsIronLadleL3DataTableCheckFlag,
            this.coldsIronLadleL3DataTableSmall_FireID,
            this.coldsIronLadleL3DataTableMiddle_FireID,
            this.coldsIronLadleL3DataTableBig_FireID});
            this.schemadsIronLadle.TableName = "L3DataTable";
            // 
            // coldsIronLadleL3DataTableIronLadleID
            // 
            this.coldsIronLadleL3DataTableIronLadleID.Caption = "IronLadleID";
            this.coldsIronLadleL3DataTableIronLadleID.ColumnName = "IronLadleID";
            this.coldsIronLadleL3DataTableIronLadleID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableStatus
            // 
            this.coldsIronLadleL3DataTableStatus.Caption = "Status";
            this.coldsIronLadleL3DataTableStatus.ColumnName = "Status";
            this.coldsIronLadleL3DataTableStatus.Namespace = "";
            // 
            // coldsIronLadleL3DataTableTare_Weight
            // 
            this.coldsIronLadleL3DataTableTare_Weight.Caption = "Tare_Weight";
            this.coldsIronLadleL3DataTableTare_Weight.ColumnName = "Tare_Weight";
            this.coldsIronLadleL3DataTableTare_Weight.DataType = typeof(float);
            this.coldsIronLadleL3DataTableTare_Weight.Namespace = "";
            // 
            // coldsIronLadleL3DataTableGross_Weight
            // 
            this.coldsIronLadleL3DataTableGross_Weight.Caption = "Gross_Weight";
            this.coldsIronLadleL3DataTableGross_Weight.ColumnName = "Gross_Weight";
            this.coldsIronLadleL3DataTableGross_Weight.DataType = typeof(float);
            this.coldsIronLadleL3DataTableGross_Weight.Namespace = "";
            // 
            // coldsIronLadleL3DataTableNet_Weight
            // 
            this.coldsIronLadleL3DataTableNet_Weight.Caption = "Net_Weight";
            this.coldsIronLadleL3DataTableNet_Weight.ColumnName = "Net_Weight";
            this.coldsIronLadleL3DataTableNet_Weight.DataType = typeof(float);
            this.coldsIronLadleL3DataTableNet_Weight.Namespace = "";
            // 
            // coldsIronLadleL3DataTableRefra_Produce
            // 
            this.coldsIronLadleL3DataTableRefra_Produce.Caption = "Refra_Produce";
            this.coldsIronLadleL3DataTableRefra_Produce.ColumnName = "Refra_Produce";
            this.coldsIronLadleL3DataTableRefra_Produce.Namespace = "";
            // 
            // coldsIronLadleL3DataTableRefra_ID
            // 
            this.coldsIronLadleL3DataTableRefra_ID.Caption = "Refra_ID";
            this.coldsIronLadleL3DataTableRefra_ID.ColumnName = "Refra_ID";
            this.coldsIronLadleL3DataTableRefra_ID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableIronLadle_Age
            // 
            this.coldsIronLadleL3DataTableIronLadle_Age.Caption = "IronLadle_Age";
            this.coldsIronLadleL3DataTableIronLadle_Age.ColumnName = "IronLadle_Age";
            this.coldsIronLadleL3DataTableIronLadle_Age.DataType = typeof(int);
            this.coldsIronLadleL3DataTableIronLadle_Age.Namespace = "";
            // 
            // coldsIronLadleL3DataTableTieID
            // 
            this.coldsIronLadleL3DataTableTieID.Caption = "TieID";
            this.coldsIronLadleL3DataTableTieID.ColumnName = "TieID";
            this.coldsIronLadleL3DataTableTieID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableComFlag
            // 
            this.coldsIronLadleL3DataTableComFlag.Caption = "ComFlag";
            this.coldsIronLadleL3DataTableComFlag.ColumnName = "ComFlag";
            this.coldsIronLadleL3DataTableComFlag.DataType = typeof(int);
            this.coldsIronLadleL3DataTableComFlag.Namespace = "";
            // 
            // coldsIronLadleL3DataTableCheckFlag
            // 
            this.coldsIronLadleL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsIronLadleL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsIronLadleL3DataTableCheckFlag.DataType = typeof(int);
            this.coldsIronLadleL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsIronLadleL3DataTableSmall_FireID
            // 
            this.coldsIronLadleL3DataTableSmall_FireID.Caption = "Small_FireID";
            this.coldsIronLadleL3DataTableSmall_FireID.ColumnName = "Small_FireID";
            this.coldsIronLadleL3DataTableSmall_FireID.DataType = typeof(int);
            this.coldsIronLadleL3DataTableSmall_FireID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableMiddle_FireID
            // 
            this.coldsIronLadleL3DataTableMiddle_FireID.Caption = "Middle_FireID";
            this.coldsIronLadleL3DataTableMiddle_FireID.ColumnName = "Middle_FireID";
            this.coldsIronLadleL3DataTableMiddle_FireID.DataType = typeof(int);
            this.coldsIronLadleL3DataTableMiddle_FireID.Namespace = "";
            // 
            // coldsIronLadleL3DataTableBig_FireID
            // 
            this.coldsIronLadleL3DataTableBig_FireID.Caption = "Big_FireID";
            this.coldsIronLadleL3DataTableBig_FireID.ColumnName = "Big_FireID";
            this.coldsIronLadleL3DataTableBig_FireID.DataType = typeof(int);
            this.coldsIronLadleL3DataTableBig_FireID.Namespace = "";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvIronLadle);
            this.hmiRootPanel1.Controls.Add(this.bnIronLadle);
            this.hmiRootPanel1.Controls.Add(this.tSp1);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 0);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 700);
            this.hmiRootPanel1.TabIndex = 25;
            // 
            // dvIronLadle
            // 
            this.dvIronLadle.AllowUserToAddRows = false;
            this.dvIronLadle.AutoGenerateColumns = false;
            this.dvIronLadle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvIronLadle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvIronLadle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvIronLadle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.IronLadleID,
            this.Status,
            this.ComFlag,
            this.ironLadleAgeDataGridViewTextBoxColumn,
            this.tareWeightDataGridViewTextBoxColumn,
            this.grossWeightDataGridViewTextBoxColumn,
            this.netWeightDataGridViewTextBoxColumn,
            this.TieID,
            this.Small_FireID,
            this.Middle_FireID,
            this.Big_FireID,
            this.refraProduceDataGridViewTextBoxColumn,
            this.refraIDDataGridViewTextBoxColumn});
            this.dvIronLadle.DataSource = this.bsIronLadle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvIronLadle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvIronLadle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvIronLadle.Location = new System.Drawing.Point(0, 68);
            this.dvIronLadle.Margin = new System.Windows.Forms.Padding(0);
            this.dvIronLadle.Name = "dvIronLadle";
            this.dvIronLadle.RowTemplate.Height = 23;
            this.dvIronLadle.Size = new System.Drawing.Size(1000, 632);
            this.dvIronLadle.TabIndex = 30;
            this.dvIronLadle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvIronLadle_DataError);
            this.dvIronLadle.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvIronLadle_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CheckFlag";
            this.Column1.FalseValue = "0";
            this.Column1.HeaderText = "选择";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "1";
            this.Column1.Width = 35;
            // 
            // IronLadleID
            // 
            this.IronLadleID.DataPropertyName = "IronLadleID";
            this.IronLadleID.HeaderText = "铁包号";
            this.IronLadleID.Name = "IronLadleID";
            this.IronLadleID.ReadOnly = true;
            this.IronLadleID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.IronLadleID.Width = 66;
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
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Status.ValueMember = "L3DataTable.Code";
            this.Status.Width = 54;
            // 
            // dsStatus
            // 
            this.dsStatus.AutoLoad = true;
            this.dsStatus.AutoSubscribe = true;
            this.dsStatus.DataSetName = "L3DataSet";
            this.dsStatus.DeleteMethod = null;
            this.dsStatus.InsertMethod = null;
            this.dsStatus.L3DataAdapter = this.Adapter;
            this.dsStatus.LoadEvent = "Click";
            this.dsStatus.LoadTrigger = null;
            this.dsStatus.RefreshValve = 1000;
            this.dsStatus.SourceCommand = null;
            this.dsStatus.SourceCondition = "Code_Group = \'IRONLADLE_STATUS\' order by Code";
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
            // ComFlag
            // 
            this.ComFlag.DataPropertyName = "ComFlag";
            this.ComFlag.HeaderText = "完成标志";
            this.ComFlag.Name = "ComFlag";
            this.ComFlag.ReadOnly = true;
            this.ComFlag.Width = 78;
            // 
            // ironLadleAgeDataGridViewTextBoxColumn
            // 
            this.ironLadleAgeDataGridViewTextBoxColumn.DataPropertyName = "IronLadle_Age";
            this.ironLadleAgeDataGridViewTextBoxColumn.HeaderText = "包龄";
            this.ironLadleAgeDataGridViewTextBoxColumn.Name = "ironLadleAgeDataGridViewTextBoxColumn";
            this.ironLadleAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.ironLadleAgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ironLadleAgeDataGridViewTextBoxColumn.Width = 54;
            // 
            // tareWeightDataGridViewTextBoxColumn
            // 
            this.tareWeightDataGridViewTextBoxColumn.DataPropertyName = "Tare_Weight";
            this.tareWeightDataGridViewTextBoxColumn.HeaderText = "皮重";
            this.tareWeightDataGridViewTextBoxColumn.Name = "tareWeightDataGridViewTextBoxColumn";
            this.tareWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.tareWeightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.tareWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // grossWeightDataGridViewTextBoxColumn
            // 
            this.grossWeightDataGridViewTextBoxColumn.DataPropertyName = "Gross_Weight";
            this.grossWeightDataGridViewTextBoxColumn.HeaderText = "毛重";
            this.grossWeightDataGridViewTextBoxColumn.Name = "grossWeightDataGridViewTextBoxColumn";
            this.grossWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.grossWeightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grossWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // netWeightDataGridViewTextBoxColumn
            // 
            this.netWeightDataGridViewTextBoxColumn.DataPropertyName = "Net_Weight";
            this.netWeightDataGridViewTextBoxColumn.HeaderText = "净重";
            this.netWeightDataGridViewTextBoxColumn.Name = "netWeightDataGridViewTextBoxColumn";
            this.netWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.netWeightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.netWeightDataGridViewTextBoxColumn.Width = 54;
            // 
            // TieID
            // 
            this.TieID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TieID.DataPropertyName = "TieID";
            this.TieID.HeaderText = "打结编号";
            this.TieID.Name = "TieID";
            this.TieID.ReadOnly = true;
            // 
            // Small_FireID
            // 
            this.Small_FireID.DataPropertyName = "Small_FireID";
            this.Small_FireID.HeaderText = "小火烘烤次数";
            this.Small_FireID.Name = "Small_FireID";
            this.Small_FireID.ReadOnly = true;
            this.Small_FireID.Width = 102;
            // 
            // Middle_FireID
            // 
            this.Middle_FireID.DataPropertyName = "Middle_FireID";
            this.Middle_FireID.HeaderText = "中火烘烤次数";
            this.Middle_FireID.Name = "Middle_FireID";
            this.Middle_FireID.ReadOnly = true;
            this.Middle_FireID.Width = 102;
            // 
            // Big_FireID
            // 
            this.Big_FireID.DataPropertyName = "Big_FireID";
            this.Big_FireID.HeaderText = "大火烘烤次数";
            this.Big_FireID.Name = "Big_FireID";
            this.Big_FireID.ReadOnly = true;
            this.Big_FireID.Width = 102;
            // 
            // refraProduceDataGridViewTextBoxColumn
            // 
            this.refraProduceDataGridViewTextBoxColumn.DataPropertyName = "Refra_Produce";
            this.refraProduceDataGridViewTextBoxColumn.HeaderText = "耐材厂家";
            this.refraProduceDataGridViewTextBoxColumn.Name = "refraProduceDataGridViewTextBoxColumn";
            this.refraProduceDataGridViewTextBoxColumn.ReadOnly = true;
            this.refraProduceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.refraProduceDataGridViewTextBoxColumn.Visible = false;
            this.refraProduceDataGridViewTextBoxColumn.Width = 78;
            // 
            // refraIDDataGridViewTextBoxColumn
            // 
            this.refraIDDataGridViewTextBoxColumn.DataPropertyName = "Refra_ID";
            this.refraIDDataGridViewTextBoxColumn.HeaderText = "耐材名称";
            this.refraIDDataGridViewTextBoxColumn.Name = "refraIDDataGridViewTextBoxColumn";
            this.refraIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.refraIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.refraIDDataGridViewTextBoxColumn.Visible = false;
            this.refraIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // bnIronLadle
            // 
            this.bnIronLadle.AddNewItem = null;
            this.bnIronLadle.AutoSize = false;
            this.bnIronLadle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnIronLadle.BackgroundImage")));
            this.bnIronLadle.CountItem = this.bindingNavigatorCountItem;
            this.bnIronLadle.DeleteItem = null;
            this.bnIronLadle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnIronLadle.Location = new System.Drawing.Point(0, 43);
            this.bnIronLadle.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnIronLadle.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnIronLadle.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnIronLadle.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnIronLadle.Name = "bnIronLadle";
            this.bnIronLadle.PositionItem = this.bindingNavigatorPositionItem;
            this.bnIronLadle.Size = new System.Drawing.Size(1000, 25);
            this.bnIronLadle.TabIndex = 29;
            this.bnIronLadle.Text = "bindingNavigator1";
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
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnTieStart,
            this.btnTieEnd,
            this.btnSmallFireStart,
            this.btnSmallFireEnd,
            this.btnMidFireStart,
            this.btnMidFireEnd,
            this.btnBigFireStart,
            this.btnBigFireEnd,
            this.btnHot,
            this.btnUse,
            this.btnStopUse,
            this.btnWaitRepair,
            this.btnOffLineException});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 28;
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
            // dsLadleGrade
            // 
            this.dsLadleGrade.AutoLoad = true;
            this.dsLadleGrade.AutoSubscribe = true;
            this.dsLadleGrade.DataSetName = "L3DataSet";
            this.dsLadleGrade.DeleteMethod = null;
            this.dsLadleGrade.InsertMethod = null;
            this.dsLadleGrade.L3DataAdapter = null;
            this.dsLadleGrade.LoadEvent = "Click";
            this.dsLadleGrade.LoadTrigger = null;
            this.dsLadleGrade.RefreshValve = 1000;
            this.dsLadleGrade.SourceCommand = null;
            this.dsLadleGrade.SourceCondition = null;
            this.dsLadleGrade.SourceMethod = null;
            this.dsLadleGrade.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsLadleGrade.SourceURI = null;
            this.dsLadleGrade.SubscribeTarget = null;
            this.dsLadleGrade.UpdateEvent = "Click";
            this.dsLadleGrade.UpdateMethod = null;
            this.dsLadleGrade.UpdateTrigger = null;
            // 
            // dsRefraFac
            // 
            this.dsRefraFac.AutoLoad = true;
            this.dsRefraFac.AutoSubscribe = true;
            this.dsRefraFac.DataSetName = "L3DataSet";
            this.dsRefraFac.DeleteMethod = null;
            this.dsRefraFac.InsertMethod = null;
            this.dsRefraFac.L3DataAdapter = null;
            this.dsRefraFac.LoadEvent = "Click";
            this.dsRefraFac.LoadTrigger = null;
            this.dsRefraFac.RefreshValve = 1000;
            this.dsRefraFac.SourceCommand = null;
            this.dsRefraFac.SourceCondition = null;
            this.dsRefraFac.SourceMethod = null;
            this.dsRefraFac.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsRefraFac.SourceURI = null;
            this.dsRefraFac.SubscribeTarget = null;
            this.dsRefraFac.UpdateEvent = "Click";
            this.dsRefraFac.UpdateMethod = null;
            this.dsRefraFac.UpdateTrigger = null;
            // 
            // cmdTieStart
            // 
            this.cmdTieStart.Adapter = this.Adapter;
            this.cmdTieStart.MergeReturnTarget = false;
            this.cmdTieStart.Method = "IronLadleTieStart";
            this.cmdTieStart.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdTieStart.Parameters.Add(this.l3cmdpTieStart);
            this.cmdTieStart.ReturnTarget = null;
            this.cmdTieStart.ReturnTargetProperty = null;
            this.cmdTieStart.Trigger = null;
            this.cmdTieStart.TriggerEvent = "Click";
            // 
            // l3cmdpTieStart
            // 
            this.l3cmdpTieStart.AcceptAfterExecuted = false;
            this.l3cmdpTieStart.ConstantValue = null;
            this.l3cmdpTieStart.MergeTarget = false;
            this.l3cmdpTieStart.SourceFilter = "";
            this.l3cmdpTieStart.SourceObject = this.dsIronLadle;
            this.l3cmdpTieStart.SourceProperty = "L3DataTable";
            this.l3cmdpTieStart.TargetObject = null;
            this.l3cmdpTieStart.TargetProperty = null;
            // 
            // cmdTieEnd
            // 
            this.cmdTieEnd.Adapter = this.Adapter;
            this.cmdTieEnd.MergeReturnTarget = false;
            this.cmdTieEnd.Method = "IronLadleTieEnd";
            this.cmdTieEnd.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdTieEnd.Parameters.Add(this.l3cmdpTieEnd);
            this.cmdTieEnd.ReturnTarget = null;
            this.cmdTieEnd.ReturnTargetProperty = null;
            this.cmdTieEnd.Trigger = null;
            this.cmdTieEnd.TriggerEvent = "Click";
            // 
            // l3cmdpTieEnd
            // 
            this.l3cmdpTieEnd.AcceptAfterExecuted = false;
            this.l3cmdpTieEnd.ConstantValue = null;
            this.l3cmdpTieEnd.MergeTarget = false;
            this.l3cmdpTieEnd.SourceFilter = "";
            this.l3cmdpTieEnd.SourceObject = this.dsIronLadle;
            this.l3cmdpTieEnd.SourceProperty = "L3DataTable";
            this.l3cmdpTieEnd.TargetObject = null;
            this.l3cmdpTieEnd.TargetProperty = null;
            // 
            // cmdSmallFireStart
            // 
            this.cmdSmallFireStart.Adapter = this.Adapter;
            this.cmdSmallFireStart.MergeReturnTarget = false;
            this.cmdSmallFireStart.Method = "IronLadleSmallFireStart";
            this.cmdSmallFireStart.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdSmallFireStart.Parameters.Add(this.l3cmdpSmallFireStart);
            this.cmdSmallFireStart.ReturnTarget = null;
            this.cmdSmallFireStart.ReturnTargetProperty = null;
            this.cmdSmallFireStart.Trigger = null;
            this.cmdSmallFireStart.TriggerEvent = "Click";
            // 
            // l3cmdpSmallFireStart
            // 
            this.l3cmdpSmallFireStart.AcceptAfterExecuted = false;
            this.l3cmdpSmallFireStart.ConstantValue = null;
            this.l3cmdpSmallFireStart.MergeTarget = false;
            this.l3cmdpSmallFireStart.SourceFilter = "";
            this.l3cmdpSmallFireStart.SourceObject = this.dsIronLadle;
            this.l3cmdpSmallFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpSmallFireStart.TargetObject = null;
            this.l3cmdpSmallFireStart.TargetProperty = null;
            // 
            // cmdSmallFireEnd
            // 
            this.cmdSmallFireEnd.Adapter = this.Adapter;
            this.cmdSmallFireEnd.MergeReturnTarget = false;
            this.cmdSmallFireEnd.Method = "IronLadleSmallFireEnd";
            this.cmdSmallFireEnd.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdSmallFireEnd.Parameters.Add(this.l3CommandParameter4);
            this.cmdSmallFireEnd.ReturnTarget = null;
            this.cmdSmallFireEnd.ReturnTargetProperty = null;
            this.cmdSmallFireEnd.Trigger = null;
            this.cmdSmallFireEnd.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter4.SourceObject = this.dsIronLadle;
            this.l3CommandParameter4.SourceProperty = "L3DataTable";
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // cmdMiddleFireStart
            // 
            this.cmdMiddleFireStart.Adapter = this.Adapter;
            this.cmdMiddleFireStart.MergeReturnTarget = false;
            this.cmdMiddleFireStart.Method = "IronLadleMiddleFireStart";
            this.cmdMiddleFireStart.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdMiddleFireStart.Parameters.Add(this.l3CommandParameter5);
            this.cmdMiddleFireStart.ReturnTarget = null;
            this.cmdMiddleFireStart.ReturnTargetProperty = null;
            this.cmdMiddleFireStart.Trigger = null;
            this.cmdMiddleFireStart.TriggerEvent = "Click";
            // 
            // l3CommandParameter5
            // 
            this.l3CommandParameter5.AcceptAfterExecuted = false;
            this.l3CommandParameter5.ConstantValue = null;
            this.l3CommandParameter5.MergeTarget = false;
            this.l3CommandParameter5.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter5.SourceObject = this.dsIronLadle;
            this.l3CommandParameter5.SourceProperty = "L3DataTable";
            this.l3CommandParameter5.TargetObject = null;
            this.l3CommandParameter5.TargetProperty = null;
            // 
            // cmdMiddleFireEnd
            // 
            this.cmdMiddleFireEnd.Adapter = this.Adapter;
            this.cmdMiddleFireEnd.MergeReturnTarget = false;
            this.cmdMiddleFireEnd.Method = "IronLadleMiddleFireEnd";
            this.cmdMiddleFireEnd.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdMiddleFireEnd.Parameters.Add(this.l3CommandParameter6);
            this.cmdMiddleFireEnd.ReturnTarget = null;
            this.cmdMiddleFireEnd.ReturnTargetProperty = null;
            this.cmdMiddleFireEnd.Trigger = null;
            this.cmdMiddleFireEnd.TriggerEvent = "Click";
            // 
            // l3CommandParameter6
            // 
            this.l3CommandParameter6.AcceptAfterExecuted = false;
            this.l3CommandParameter6.ConstantValue = null;
            this.l3CommandParameter6.MergeTarget = false;
            this.l3CommandParameter6.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter6.SourceObject = this.dsIronLadle;
            this.l3CommandParameter6.SourceProperty = "L3DataTable";
            this.l3CommandParameter6.TargetObject = null;
            this.l3CommandParameter6.TargetProperty = null;
            // 
            // cmdBigFireStart
            // 
            this.cmdBigFireStart.Adapter = this.Adapter;
            this.cmdBigFireStart.MergeReturnTarget = false;
            this.cmdBigFireStart.Method = "IronLadleBigFireStart";
            this.cmdBigFireStart.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdBigFireStart.Parameters.Add(this.l3CommandParameter7);
            this.cmdBigFireStart.ReturnTarget = null;
            this.cmdBigFireStart.ReturnTargetProperty = null;
            this.cmdBigFireStart.Trigger = null;
            this.cmdBigFireStart.TriggerEvent = "Click";
            // 
            // l3CommandParameter7
            // 
            this.l3CommandParameter7.AcceptAfterExecuted = false;
            this.l3CommandParameter7.ConstantValue = null;
            this.l3CommandParameter7.MergeTarget = false;
            this.l3CommandParameter7.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter7.SourceObject = this.dsIronLadle;
            this.l3CommandParameter7.SourceProperty = "L3DataTable";
            this.l3CommandParameter7.TargetObject = null;
            this.l3CommandParameter7.TargetProperty = null;
            // 
            // cmdBigFireEnd
            // 
            this.cmdBigFireEnd.Adapter = this.Adapter;
            this.cmdBigFireEnd.MergeReturnTarget = false;
            this.cmdBigFireEnd.Method = "IronLadleBigFireEnd";
            this.cmdBigFireEnd.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdBigFireEnd.Parameters.Add(this.l3CommandParameter9);
            this.cmdBigFireEnd.ReturnTarget = null;
            this.cmdBigFireEnd.ReturnTargetProperty = null;
            this.cmdBigFireEnd.Trigger = null;
            this.cmdBigFireEnd.TriggerEvent = "Click";
            // 
            // l3CommandParameter9
            // 
            this.l3CommandParameter9.AcceptAfterExecuted = false;
            this.l3CommandParameter9.ConstantValue = null;
            this.l3CommandParameter9.MergeTarget = false;
            this.l3CommandParameter9.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter9.SourceObject = this.dsIronLadle;
            this.l3CommandParameter9.SourceProperty = "L3DataTable";
            this.l3CommandParameter9.TargetObject = null;
            this.l3CommandParameter9.TargetProperty = null;
            // 
            // l3CommandParameter8
            // 
            this.l3CommandParameter8.AcceptAfterExecuted = false;
            this.l3CommandParameter8.ConstantValue = null;
            this.l3CommandParameter8.MergeTarget = false;
            this.l3CommandParameter8.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter8.SourceObject = this.dsIronLadle;
            this.l3CommandParameter8.SourceProperty = "L3DataTable";
            this.l3CommandParameter8.TargetObject = null;
            this.l3CommandParameter8.TargetProperty = null;
            // 
            // cmdStopUse
            // 
            this.cmdStopUse.Adapter = this.Adapter;
            this.cmdStopUse.MergeReturnTarget = false;
            this.cmdStopUse.Method = "IronLaldeStopUse";
            this.cmdStopUse.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdStopUse.Parameters.Add(this.l3cmdpStopUse);
            this.cmdStopUse.ReturnTarget = null;
            this.cmdStopUse.ReturnTargetProperty = null;
            this.cmdStopUse.Trigger = null;
            this.cmdStopUse.TriggerEvent = "Click";
            // 
            // l3cmdpStopUse
            // 
            this.l3cmdpStopUse.AcceptAfterExecuted = false;
            this.l3cmdpStopUse.ConstantValue = null;
            this.l3cmdpStopUse.MergeTarget = false;
            this.l3cmdpStopUse.SourceFilter = null;
            this.l3cmdpStopUse.SourceObject = this.dsIronLadle;
            this.l3cmdpStopUse.SourceProperty = "L3DataTable";
            this.l3cmdpStopUse.TargetObject = null;
            this.l3cmdpStopUse.TargetProperty = null;
            // 
            // cmdWaitRepair
            // 
            this.cmdWaitRepair.Adapter = this.Adapter;
            this.cmdWaitRepair.MergeReturnTarget = false;
            this.cmdWaitRepair.Method = "IronLadleWaitRepair";
            this.cmdWaitRepair.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdWaitRepair.Parameters.Add(this.l3cmdpWaitRepair);
            this.cmdWaitRepair.ReturnTarget = null;
            this.cmdWaitRepair.ReturnTargetProperty = null;
            this.cmdWaitRepair.Trigger = null;
            this.cmdWaitRepair.TriggerEvent = "Click";
            // 
            // l3cmdpWaitRepair
            // 
            this.l3cmdpWaitRepair.AcceptAfterExecuted = false;
            this.l3cmdpWaitRepair.ConstantValue = null;
            this.l3cmdpWaitRepair.MergeTarget = false;
            this.l3cmdpWaitRepair.SourceFilter = null;
            this.l3cmdpWaitRepair.SourceObject = this.dsIronLadle;
            this.l3cmdpWaitRepair.SourceProperty = "L3DataTable";
            this.l3cmdpWaitRepair.TargetObject = null;
            this.l3cmdpWaitRepair.TargetProperty = null;
            // 
            // cmdUse
            // 
            this.cmdUse.Adapter = this.Adapter;
            this.cmdUse.MergeReturnTarget = false;
            this.cmdUse.Method = "IronLadleUse";
            this.cmdUse.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdUse.Parameters.Add(this.l3cmdpUse);
            this.cmdUse.ReturnTarget = null;
            this.cmdUse.ReturnTargetProperty = null;
            this.cmdUse.Trigger = null;
            this.cmdUse.TriggerEvent = "Click";
            // 
            // l3cmdpUse
            // 
            this.l3cmdpUse.AcceptAfterExecuted = false;
            this.l3cmdpUse.ConstantValue = null;
            this.l3cmdpUse.MergeTarget = false;
            this.l3cmdpUse.SourceFilter = null;
            this.l3cmdpUse.SourceObject = this.dsIronLadle;
            this.l3cmdpUse.SourceProperty = "L3DataTable";
            this.l3cmdpUse.TargetObject = null;
            this.l3cmdpUse.TargetProperty = null;
            // 
            // cmdHot
            // 
            this.cmdHot.Adapter = this.Adapter;
            this.cmdHot.MergeReturnTarget = false;
            this.cmdHot.Method = "IronLadleHot";
            this.cmdHot.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdHot.Parameters.Add(this.l3cmdpHot);
            this.cmdHot.ReturnTarget = null;
            this.cmdHot.ReturnTargetProperty = null;
            this.cmdHot.Trigger = null;
            this.cmdHot.TriggerEvent = "Click";
            // 
            // l3cmdpHot
            // 
            this.l3cmdpHot.AcceptAfterExecuted = false;
            this.l3cmdpHot.ConstantValue = null;
            this.l3cmdpHot.MergeTarget = false;
            this.l3cmdpHot.SourceFilter = null;
            this.l3cmdpHot.SourceObject = this.dsIronLadle;
            this.l3cmdpHot.SourceProperty = "L3DataTable";
            this.l3cmdpHot.TargetObject = null;
            this.l3cmdpHot.TargetProperty = null;
            // 
            // cmdOffLineException
            // 
            this.cmdOffLineException.Adapter = this.Adapter;
            this.cmdOffLineException.MergeReturnTarget = false;
            this.cmdOffLineException.Method = "IronLadleOffLineException";
            this.cmdOffLineException.Object = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.cmdOffLineException.Parameters.Add(this.cmdpOffLineException);
            this.cmdOffLineException.ReturnTarget = null;
            this.cmdOffLineException.ReturnTargetProperty = null;
            this.cmdOffLineException.Trigger = null;
            this.cmdOffLineException.TriggerEvent = "Click";
            // 
            // cmdpOffLineException
            // 
            this.cmdpOffLineException.AcceptAfterExecuted = false;
            this.cmdpOffLineException.ConstantValue = null;
            this.cmdpOffLineException.MergeTarget = false;
            this.cmdpOffLineException.SourceFilter = null;
            this.cmdpOffLineException.SourceObject = this.dsIronLadle;
            this.cmdpOffLineException.SourceProperty = "L3DataTable";
            this.cmdpOffLineException.TargetObject = null;
            this.cmdpOffLineException.TargetProperty = null;
            // 
            // IronLadleBaseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IronLadleBaseMagFrm";
            this.TabText = "铁包基本信息管理";
            this.Text = "多记录显示";
            this.Load += new System.EventHandler(this.IronLadleBaseMagFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IronLadleBaseMagFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsIronLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadle)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvIronLadle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnIronLadle)).EndInit();
            this.bnIronLadle.ResumeLayout(false);
            this.bnIronLadle.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsLadleGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraFac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsIronLadle;
        private System.Windows.Forms.BindingSource bsIronLadle;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private AppSvrHMI.L3DataSet dsLadleGrade;
        private AppSvrHMI.L3DataSet dsRefraFac;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Windows.Forms.DataGridView dvIronLadle;
        private System.Windows.Forms.BindingNavigator bnIronLadle;
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
        private System.Data.DataTable schemadsIronLadle;
        private System.Data.DataColumn coldsIronLadleL3DataTableIronLadleID;
        private System.Data.DataColumn coldsIronLadleL3DataTableStatus;
        private System.Data.DataColumn coldsIronLadleL3DataTableTare_Weight;
        private System.Data.DataColumn coldsIronLadleL3DataTableGross_Weight;
        private System.Data.DataColumn coldsIronLadleL3DataTableNet_Weight;
        private System.Data.DataColumn coldsIronLadleL3DataTableRefra_Produce;
        private System.Data.DataColumn coldsIronLadleL3DataTableRefra_ID;
        private System.Data.DataColumn coldsIronLadleL3DataTableIronLadle_Age;
        private System.Data.DataColumn coldsIronLadleL3DataTableCheckFlag;
        private AppSvrHMI.L3Command cmdTieStart;
        private AppSvrHMI.L3CommandParameter l3cmdpTieStart;
        private AppSvrHMI.L3Command cmdTieEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpTieEnd;
        private AppSvrHMI.L3Command cmdSmallFireStart;
        private AppSvrHMI.L3Command cmdSmallFireEnd;
        private AppSvrHMI.L3Command cmdMiddleFireStart;
        private AppSvrHMI.L3Command cmdMiddleFireEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpSmallFireStart;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private AppSvrHMI.L3CommandParameter l3CommandParameter5;
        private AppSvrHMI.L3CommandParameter l3CommandParameter6;
        private AppSvrHMI.L3Command cmdBigFireStart;
        private AppSvrHMI.L3CommandParameter l3CommandParameter7;
        private AppSvrHMI.L3Command cmdBigFireEnd;
        private AppSvrHMI.L3CommandParameter l3CommandParameter8;
        private AppSvrHMI.L3CommandParameter l3CommandParameter9;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnTieStart;
        private System.Windows.Forms.ToolStripButton btnTieEnd;
        private System.Windows.Forms.ToolStripButton btnSmallFireStart;
        private System.Windows.Forms.ToolStripButton btnSmallFireEnd;
        private System.Windows.Forms.ToolStripButton btnMidFireStart;
        private System.Windows.Forms.ToolStripButton btnMidFireEnd;
        private System.Windows.Forms.ToolStripButton btnBigFireStart;
        private System.Windows.Forms.ToolStripButton btnBigFireEnd;
        private System.Windows.Forms.ToolStripButton btnStopUse;
        private System.Windows.Forms.ToolStripButton btnWaitRepair;
        private AppSvrHMI.L3Command cmdStopUse;
        private AppSvrHMI.L3Command cmdWaitRepair;
        private System.Data.DataColumn coldsIronLadleL3DataTableTieID;
        private System.Data.DataColumn coldsIronLadleL3DataTableComFlag;
        private AppSvrHMI.L3CommandParameter l3cmdpStopUse;
        private AppSvrHMI.L3CommandParameter l3cmdpWaitRepair;
        private System.Windows.Forms.ToolStripButton btnHot;
        private System.Windows.Forms.ToolStripButton btnUse;
        private AppSvrHMI.L3Command cmdUse;
        private AppSvrHMI.L3CommandParameter l3cmdpUse;
        private AppSvrHMI.L3Command cmdHot;
        private AppSvrHMI.L3CommandParameter l3cmdpHot;
        private System.Data.DataColumn coldsIronLadleL3DataTableSmall_FireID;
        private System.Data.DataColumn coldsIronLadleL3DataTableMiddle_FireID;
        private System.Data.DataColumn coldsIronLadleL3DataTableBig_FireID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IronLadleID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn ironLadleAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Small_FireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Middle_FireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Big_FireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn refraProduceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refraIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnOffLineException;
        private AppSvrHMI.L3Command cmdOffLineException;
        private AppSvrHMI.L3CommandParameter cmdpOffLineException;
    }
}