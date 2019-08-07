namespace EquipMag.TundishMag
{
    partial class TundishBaseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishBaseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsTundish = new System.Windows.Forms.BindingSource(this.components);
            this.dsTundish = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnInnerTieStart = new System.Windows.Forms.ToolStripButton();
            this.btnInnerTieEnd = new System.Windows.Forms.ToolStripButton();
            this.btnInnerFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnInnerFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnWorkBuildStart = new System.Windows.Forms.ToolStripButton();
            this.btnWorkBuildEnd = new System.Windows.Forms.ToolStripButton();
            this.btnWorkFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnWorkFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnConfirmCold = new System.Windows.Forms.ToolStripButton();
            this.btnInstallStart = new System.Windows.Forms.ToolStripButton();
            this.btnInstallEnd = new System.Windows.Forms.ToolStripButton();
            this.btnOnFireStart = new System.Windows.Forms.ToolStripButton();
            this.btnOnFireEnd = new System.Windows.Forms.ToolStripButton();
            this.btnONLine = new System.Windows.Forms.ToolStripButton();
            this.btnOFFLine = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnOffLineException = new System.Windows.Forms.ToolStripButton();
            this.schemadsTundish = new System.Data.DataTable();
            this.coldsTundishL3DataTableGUID = new System.Data.DataColumn();
            this.coldsTundishL3DataTableName = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsTundishL3DataTableCast_ID = new System.Data.DataColumn();
            this.coldsTundishL3DataTableRefra_Pro = new System.Data.DataColumn();
            this.coldsTundishL3DataTableStatus = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundish_Age = new System.Data.DataColumn();
            this.coldsTundishL3DataTableCheckFlag = new System.Data.DataColumn();
            this.coldsTundishL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsTundishL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundishNO = new System.Data.DataColumn();
            this.coldsTundishL3DataTableFlag = new System.Data.DataColumn();
            this.coldsTundishL3DataTableTundishType = new System.Data.DataColumn();
            this.coldsTundishL3DataTableVehicleID = new System.Data.DataColumn();
            this.menuS63 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuS64 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuS65 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCancelDire = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTundishDire = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuS67 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsStatus = new AppSvrHMI.L3DataSet();
            this.schemadsStatus = new System.Data.DataTable();
            this.coldsStatusL3DataTableCode = new System.Data.DataColumn();
            this.coldsStatusL3DataTableCode_Des = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bnTundish = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvTundish = new System.Windows.Forms.DataGridView();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TundishID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TundishType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTundishType = new AppSvrHMI.L3DataSet();
            this.schemadsTundishType = new System.Data.DataTable();
            this.coldsTundishTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsTundishTypeL3DataTableCode_Val_Long = new System.Data.DataColumn();
            this.castIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refraProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tundishNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemads = new System.Data.DataTable();
            this.coldsL3DataTableCode = new System.Data.DataColumn();
            this.coldsL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsCastID = new AppSvrHMI.L3DataSet();
            this.schemadsCastID = new System.Data.DataTable();
            this.coldsCastIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsCastIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsRefraPro = new AppSvrHMI.L3DataSet();
            this.cmdInnerTieStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTieStart = new AppSvrHMI.L3CommandParameter();
            this.cmdInnerTieEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTieEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdInnerFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpFireStart = new AppSvrHMI.L3CommandParameter();
            this.cmdInnerFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpFireEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkBuildStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkBuildStart = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkBuildEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkBuildEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkFireStart = new AppSvrHMI.L3CommandParameter();
            this.cmdWorkFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpWorkFireEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdOnFireStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOnFireStart = new AppSvrHMI.L3CommandParameter();
            this.cmdOnFireEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpOnFireEnd = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpCold = new AppSvrHMI.L3CommandParameter();
            this.cmdConfirmCold = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpConfirmCold = new AppSvrHMI.L3CommandParameter();
            this.cmdInstallStart = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpInstallStart = new AppSvrHMI.L3CommandParameter();
            this.cmdInstallEnd = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpInstallEnd = new AppSvrHMI.L3CommandParameter();
            this.cmdTundishDireCCMID = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpTundishID = new AppSvrHMI.L3CommandParameter();
            this.l3cmdpCCMID = new AppSvrHMI.L3CommandParameter();
            this.cmdOffLineException = new AppSvrHMI.L3Command(this.components);
            this.cmdpOffLineException = new AppSvrHMI.L3CommandParameter();
            this.menuS66 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsTundish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundish)).BeginInit();
            this.cmsTundishDire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTundish)).BeginInit();
            this.bnTundish.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTundish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraPro)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTundish
            // 
            this.bsTundish.DataMember = "L3DataTable";
            this.bsTundish.DataSource = this.dsTundish;
            // 
            // dsTundish
            // 
            this.dsTundish.AutoLoad = true;
            this.dsTundish.AutoSubscribe = true;
            this.dsTundish.DataSetName = "L3DataSet";
            this.dsTundish.DeleteMethod = null;
            this.dsTundish.InsertMethod = null;
            this.dsTundish.L3DataAdapter = this.Adapter;
            this.dsTundish.LoadEvent = "Click";
            this.dsTundish.LoadTrigger = null;
            this.dsTundish.RefreshValve = 1000;
            this.dsTundish.SourceCommand = null;
            this.dsTundish.SourceCondition = "TundishType = \'2\' or TundishType = \'3\' or TundishType = \'4\' or TundishType = \'5\' " +
                "order by TundishID";
            this.dsTundish.SourceMethod = "";
            this.dsTundish.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundish.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Base";
            this.dsTundish.SubscribeTarget = null;
            this.dsTundish.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundish});
            this.dsTundish.UpdateEvent = "Click";
            this.dsTundish.UpdateMethod = null;
            this.dsTundish.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnInnerTieStart
            // 
            this.Adapter.SetAccessRight(this.btnInnerTieStart, "TundishbtnInnerTieStart");
            this.btnInnerTieStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInnerTieStart.Image = ((System.Drawing.Image)(resources.GetObject("btnInnerTieStart.Image")));
            this.btnInnerTieStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInnerTieStart.Name = "btnInnerTieStart";
            this.btnInnerTieStart.Size = new System.Drawing.Size(96, 22);
            this.btnInnerTieStart.Text = "永久层打结开始";
            this.btnInnerTieStart.Click += new System.EventHandler(this.btnInnerTieStart_Click);
            // 
            // btnInnerTieEnd
            // 
            this.Adapter.SetAccessRight(this.btnInnerTieEnd, "TundishbtnInnerTieEnd");
            this.btnInnerTieEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInnerTieEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnInnerTieEnd.Image")));
            this.btnInnerTieEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInnerTieEnd.Name = "btnInnerTieEnd";
            this.btnInnerTieEnd.Size = new System.Drawing.Size(96, 22);
            this.btnInnerTieEnd.Text = "永久层打结结束";
            this.btnInnerTieEnd.Click += new System.EventHandler(this.btnInnerTieEnd_Click);
            // 
            // btnInnerFireStart
            // 
            this.Adapter.SetAccessRight(this.btnInnerFireStart, "TundishbtnInnerFireStart");
            this.btnInnerFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInnerFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnInnerFireStart.Image")));
            this.btnInnerFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInnerFireStart.Name = "btnInnerFireStart";
            this.btnInnerFireStart.Size = new System.Drawing.Size(96, 22);
            this.btnInnerFireStart.Text = "永久层烘烤开始";
            this.btnInnerFireStart.Click += new System.EventHandler(this.btnInnerFireStart_Click);
            // 
            // btnInnerFireEnd
            // 
            this.Adapter.SetAccessRight(this.btnInnerFireEnd, "TundishbtnInnerFireEnd");
            this.btnInnerFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInnerFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnInnerFireEnd.Image")));
            this.btnInnerFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInnerFireEnd.Name = "btnInnerFireEnd";
            this.btnInnerFireEnd.Size = new System.Drawing.Size(96, 22);
            this.btnInnerFireEnd.Text = "永久层烘烤结束";
            this.btnInnerFireEnd.Click += new System.EventHandler(this.btnInnerFireEnd_Click);
            // 
            // btnWorkBuildStart
            // 
            this.Adapter.SetAccessRight(this.btnWorkBuildStart, "TundishbtnWorkBuildStart");
            this.btnWorkBuildStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkBuildStart.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkBuildStart.Image")));
            this.btnWorkBuildStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkBuildStart.Name = "btnWorkBuildStart";
            this.btnWorkBuildStart.Size = new System.Drawing.Size(125, 22);
            this.btnWorkBuildStart.Text = "工作层涂抹/干振开始";
            this.btnWorkBuildStart.Click += new System.EventHandler(this.btnWorkBuildStart_Click);
            // 
            // btnWorkBuildEnd
            // 
            this.Adapter.SetAccessRight(this.btnWorkBuildEnd, "TundishbtnWorkBuildEnd");
            this.btnWorkBuildEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkBuildEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkBuildEnd.Image")));
            this.btnWorkBuildEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkBuildEnd.Name = "btnWorkBuildEnd";
            this.btnWorkBuildEnd.Size = new System.Drawing.Size(125, 22);
            this.btnWorkBuildEnd.Text = "工作层涂抹/干振结束";
            this.btnWorkBuildEnd.Click += new System.EventHandler(this.btnWorkBuildEnd_Click);
            // 
            // btnWorkFireStart
            // 
            this.Adapter.SetAccessRight(this.btnWorkFireStart, "TundishbtnWorkFireStart");
            this.btnWorkFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkFireStart.Image")));
            this.btnWorkFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkFireStart.Name = "btnWorkFireStart";
            this.btnWorkFireStart.Size = new System.Drawing.Size(96, 22);
            this.btnWorkFireStart.Text = "工作层烘烤开始";
            this.btnWorkFireStart.Click += new System.EventHandler(this.btnWorkFireStart_Click);
            // 
            // btnWorkFireEnd
            // 
            this.Adapter.SetAccessRight(this.btnWorkFireEnd, "TundishbtnWorkFireEnd");
            this.btnWorkFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWorkFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnWorkFireEnd.Image")));
            this.btnWorkFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWorkFireEnd.Name = "btnWorkFireEnd";
            this.btnWorkFireEnd.Size = new System.Drawing.Size(96, 22);
            this.btnWorkFireEnd.Text = "工作层烘烤结束";
            this.btnWorkFireEnd.Click += new System.EventHandler(this.btnWorkFireEnd_Click);
            // 
            // btnConfirmCold
            // 
            this.Adapter.SetAccessRight(this.btnConfirmCold, "TundishbtnConfirmCold");
            this.btnConfirmCold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConfirmCold.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmCold.Image")));
            this.btnConfirmCold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirmCold.Name = "btnConfirmCold";
            this.btnConfirmCold.Size = new System.Drawing.Size(60, 22);
            this.btnConfirmCold.Text = "确认冷备";
            this.btnConfirmCold.Click += new System.EventHandler(this.btnConfirmCold_Click);
            // 
            // btnInstallStart
            // 
            this.Adapter.SetAccessRight(this.btnInstallStart, "TundishbtnInstallStart");
            this.btnInstallStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInstallStart.Image = ((System.Drawing.Image)(resources.GetObject("btnInstallStart.Image")));
            this.btnInstallStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInstallStart.Name = "btnInstallStart";
            this.btnInstallStart.Size = new System.Drawing.Size(84, 22);
            this.btnInstallStart.Text = "中包上件开始";
            this.btnInstallStart.Click += new System.EventHandler(this.btnInstallStart_Click);
            // 
            // btnInstallEnd
            // 
            this.Adapter.SetAccessRight(this.btnInstallEnd, "TundishbtnInstallEnd");
            this.btnInstallEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInstallEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnInstallEnd.Image")));
            this.btnInstallEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInstallEnd.Name = "btnInstallEnd";
            this.btnInstallEnd.Size = new System.Drawing.Size(84, 22);
            this.btnInstallEnd.Text = "中包上件结束";
            this.btnInstallEnd.Click += new System.EventHandler(this.btnInstallEnd_Click);
            // 
            // btnOnFireStart
            // 
            this.Adapter.SetAccessRight(this.btnOnFireStart, "TundishbtnOnFireStart");
            this.btnOnFireStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOnFireStart.Image = ((System.Drawing.Image)(resources.GetObject("btnOnFireStart.Image")));
            this.btnOnFireStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOnFireStart.Name = "btnOnFireStart";
            this.btnOnFireStart.Size = new System.Drawing.Size(84, 22);
            this.btnOnFireStart.Text = "在线烘烤开始";
            this.btnOnFireStart.Click += new System.EventHandler(this.btnOnFireStart_Click);
            // 
            // btnOnFireEnd
            // 
            this.Adapter.SetAccessRight(this.btnOnFireEnd, "TundishbtnOnFireEnd");
            this.btnOnFireEnd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOnFireEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnOnFireEnd.Image")));
            this.btnOnFireEnd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOnFireEnd.Name = "btnOnFireEnd";
            this.btnOnFireEnd.Size = new System.Drawing.Size(84, 22);
            this.btnOnFireEnd.Text = "在线烘烤结束";
            this.btnOnFireEnd.Click += new System.EventHandler(this.btnOnFireEnd_Click);
            // 
            // btnONLine
            // 
            this.Adapter.SetAccessRight(this.btnONLine, "TundishbtnONLine");
            this.btnONLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnONLine.Image = ((System.Drawing.Image)(resources.GetObject("btnONLine.Image")));
            this.btnONLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnONLine.Name = "btnONLine";
            this.btnONLine.Size = new System.Drawing.Size(60, 22);
            this.btnONLine.Text = "中包上线";
            this.btnONLine.Click += new System.EventHandler(this.btnONLine_Click);
            // 
            // btnOFFLine
            // 
            this.Adapter.SetAccessRight(this.btnOFFLine, "TundishbtnOFFLine");
            this.btnOFFLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOFFLine.Image = ((System.Drawing.Image)(resources.GetObject("btnOFFLine.Image")));
            this.btnOFFLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOFFLine.Name = "btnOFFLine";
            this.btnOFFLine.Size = new System.Drawing.Size(60, 22);
            this.btnOFFLine.Text = "中包下线";
            this.btnOFFLine.Click += new System.EventHandler(this.btnOFFLine_Click);
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "btnAddTundish");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(52, 22);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.Adapter.SetAccessRight(this.btnDelete, "btnDeleteTundish");
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(52, 22);
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOffLineException
            // 
            this.Adapter.SetAccessRight(this.btnOffLineException, "TundishbtnOFFLine");
            this.btnOffLineException.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOffLineException.Image = ((System.Drawing.Image)(resources.GetObject("btnOffLineException.Image")));
            this.btnOffLineException.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOffLineException.Name = "btnOffLineException";
            this.btnOffLineException.Size = new System.Drawing.Size(84, 22);
            this.btnOffLineException.Text = "中包异常下线";
            this.btnOffLineException.ToolTipText = "只对状态在\"使用\"以前的中包有效";
            this.btnOffLineException.Click += new System.EventHandler(this.btnOffLineException_Click);
            // 
            // schemadsTundish
            // 
            this.schemadsTundish.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishL3DataTableGUID,
            this.coldsTundishL3DataTableName,
            this.coldsTundishL3DataTableTundishID,
            this.coldsTundishL3DataTableCast_ID,
            this.coldsTundishL3DataTableRefra_Pro,
            this.coldsTundishL3DataTableStatus,
            this.coldsTundishL3DataTableTundish_Age,
            this.coldsTundishL3DataTableCheckFlag,
            this.coldsTundishL3DataTableInnerID,
            this.coldsTundishL3DataTableWorkID,
            this.coldsTundishL3DataTableTundishNO,
            this.coldsTundishL3DataTableFlag,
            this.coldsTundishL3DataTableTundishType,
            this.coldsTundishL3DataTableVehicleID});
            this.schemadsTundish.TableName = "L3DataTable";
            // 
            // coldsTundishL3DataTableGUID
            // 
            this.coldsTundishL3DataTableGUID.Caption = "GUID";
            this.coldsTundishL3DataTableGUID.ColumnName = "GUID";
            this.coldsTundishL3DataTableGUID.Namespace = "";
            // 
            // coldsTundishL3DataTableName
            // 
            this.coldsTundishL3DataTableName.Caption = "Name";
            this.coldsTundishL3DataTableName.ColumnName = "Name";
            this.coldsTundishL3DataTableName.Namespace = "";
            // 
            // coldsTundishL3DataTableTundishID
            // 
            this.coldsTundishL3DataTableTundishID.Caption = "TundishID";
            this.coldsTundishL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsTundishL3DataTableTundishID.Namespace = "";
            // 
            // coldsTundishL3DataTableCast_ID
            // 
            this.coldsTundishL3DataTableCast_ID.Caption = "Cast_ID";
            this.coldsTundishL3DataTableCast_ID.ColumnName = "Cast_ID";
            this.coldsTundishL3DataTableCast_ID.Namespace = "";
            // 
            // coldsTundishL3DataTableRefra_Pro
            // 
            this.coldsTundishL3DataTableRefra_Pro.Caption = "Refra_Pro";
            this.coldsTundishL3DataTableRefra_Pro.ColumnName = "Refra_Pro";
            this.coldsTundishL3DataTableRefra_Pro.Namespace = "";
            // 
            // coldsTundishL3DataTableStatus
            // 
            this.coldsTundishL3DataTableStatus.Caption = "Status";
            this.coldsTundishL3DataTableStatus.ColumnName = "Status";
            this.coldsTundishL3DataTableStatus.Namespace = "";
            // 
            // coldsTundishL3DataTableTundish_Age
            // 
            this.coldsTundishL3DataTableTundish_Age.Caption = "Tundish_Age";
            this.coldsTundishL3DataTableTundish_Age.ColumnName = "Tundish_Age";
            this.coldsTundishL3DataTableTundish_Age.DataType = typeof(int);
            this.coldsTundishL3DataTableTundish_Age.Namespace = "";
            // 
            // coldsTundishL3DataTableCheckFlag
            // 
            this.coldsTundishL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsTundishL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsTundishL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsTundishL3DataTableCheckFlag.Namespace = "";
            // 
            // coldsTundishL3DataTableInnerID
            // 
            this.coldsTundishL3DataTableInnerID.Caption = "InnerID";
            this.coldsTundishL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsTundishL3DataTableInnerID.Namespace = "";
            // 
            // coldsTundishL3DataTableWorkID
            // 
            this.coldsTundishL3DataTableWorkID.Caption = "WorkID";
            this.coldsTundishL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsTundishL3DataTableWorkID.Namespace = "";
            // 
            // coldsTundishL3DataTableTundishNO
            // 
            this.coldsTundishL3DataTableTundishNO.Caption = "TundishNO";
            this.coldsTundishL3DataTableTundishNO.ColumnName = "TundishNO";
            this.coldsTundishL3DataTableTundishNO.Namespace = "";
            // 
            // coldsTundishL3DataTableFlag
            // 
            this.coldsTundishL3DataTableFlag.Caption = "Flag";
            this.coldsTundishL3DataTableFlag.ColumnName = "Flag";
            this.coldsTundishL3DataTableFlag.DataType = typeof(short);
            this.coldsTundishL3DataTableFlag.Namespace = "";
            // 
            // coldsTundishL3DataTableTundishType
            // 
            this.coldsTundishL3DataTableTundishType.Caption = "TundishType";
            this.coldsTundishL3DataTableTundishType.ColumnName = "TundishType";
            this.coldsTundishL3DataTableTundishType.DataType = typeof(short);
            this.coldsTundishL3DataTableTundishType.Namespace = "";
            // 
            // coldsTundishL3DataTableVehicleID
            // 
            this.coldsTundishL3DataTableVehicleID.Caption = "VehicleID";
            this.coldsTundishL3DataTableVehicleID.ColumnName = "VehicleID";
            this.coldsTundishL3DataTableVehicleID.Namespace = "";
            // 
            // menuS63
            // 
            this.menuS63.Name = "menuS63";
            this.menuS63.Size = new System.Drawing.Size(152, 22);
            this.menuS63.Tag = "3";
            this.menuS63.Text = "上3#铸机";
            this.menuS63.Visible = false;
            this.menuS63.Click += new System.EventHandler(this.menuDire_Click);
            // 
            // menuS64
            // 
            this.menuS64.Name = "menuS64";
            this.menuS64.Size = new System.Drawing.Size(152, 22);
            this.menuS64.Tag = "4";
            this.menuS64.Text = "上4#铸机";
            this.menuS64.Visible = false;
            this.menuS64.Click += new System.EventHandler(this.menuDire_Click);
            // 
            // menuS65
            // 
            this.menuS65.Name = "menuS65";
            this.menuS65.Size = new System.Drawing.Size(152, 22);
            this.menuS65.Tag = "5";
            this.menuS65.Text = "上5#铸机";
            this.menuS65.Visible = false;
            this.menuS65.Click += new System.EventHandler(this.menuDire_Click);
            // 
            // menuCancelDire
            // 
            this.menuCancelDire.Name = "menuCancelDire";
            this.menuCancelDire.Size = new System.Drawing.Size(152, 22);
            this.menuCancelDire.Tag = "0";
            this.menuCancelDire.Text = "取消去向";
            this.menuCancelDire.Visible = false;
            this.menuCancelDire.Click += new System.EventHandler(this.menuDire_Click);
            // 
            // cmsTundishDire
            // 
            this.cmsTundishDire.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuS63,
            this.menuS64,
            this.menuS65,
            this.menuCancelDire,
            this.menuS67,
            this.menuS66});
            this.cmsTundishDire.Name = "cmsTundishDire";
            this.cmsTundishDire.Size = new System.Drawing.Size(153, 158);
            this.cmsTundishDire.Text = "指定中包去向";
            // 
            // menuS67
            // 
            this.menuS67.Name = "menuS67";
            this.menuS67.Size = new System.Drawing.Size(152, 22);
            this.menuS67.Tag = "7";
            this.menuS67.Text = "上7#铸机";
            this.menuS67.Visible = false;
            this.menuS67.Click += new System.EventHandler(this.menuDire_Click);
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
            this.dsStatus.SourceCondition = "Code_Group = \'Tundish_Status\'";
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
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bnTundish, 0, 2);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 3);
            this.tbLPM.Controls.Add(this.bindingNavigator1, 0, 1);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 4;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 392);
            this.tbLPM.TabIndex = 0;
            // 
            // bnTundish
            // 
            this.bnTundish.AddNewItem = null;
            this.bnTundish.AutoSize = false;
            this.bnTundish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnTundish.BackgroundImage")));
            this.bnTundish.BindingSource = this.bsTundish;
            this.bnTundish.CountItem = this.bindingNavigatorCountItem;
            this.bnTundish.DeleteItem = null;
            this.bnTundish.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnTundish.Location = new System.Drawing.Point(0, 50);
            this.bnTundish.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnTundish.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnTundish.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnTundish.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnTundish.Name = "bnTundish";
            this.bnTundish.PositionItem = this.bindingNavigatorPositionItem;
            this.bnTundish.Size = new System.Drawing.Size(1000, 25);
            this.bnTundish.TabIndex = 27;
            this.bnTundish.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "  ";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInnerTieStart,
            this.btnInnerTieEnd,
            this.btnInnerFireStart,
            this.btnInnerFireEnd,
            this.btnWorkBuildStart,
            this.btnWorkBuildEnd});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 25);
            this.tSp1.TabIndex = 26;
            this.tSp1.Text = "toolStrip1";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvTundish);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 75);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 317);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvTundish
            // 
            this.dvTundish.AllowUserToAddRows = false;
            this.dvTundish.AutoGenerateColumns = false;
            this.dvTundish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvTundish.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvTundish.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dvTundish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.TundishID,
            this.TundishType,
            this.castIDDataGridViewTextBoxColumn,
            this.VehicleID,
            this.refraProDataGridViewTextBoxColumn,
            this.Status,
            this.Flag,
            this.tundishAgeDataGridViewTextBoxColumn,
            this.tundishNODataGridViewTextBoxColumn,
            this.innerIDDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn});
            this.dvTundish.ContextMenuStrip = this.cmsTundishDire;
            this.dvTundish.DataSource = this.bsTundish;
            this.dvTundish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTundish.Location = new System.Drawing.Point(0, 0);
            this.dvTundish.Margin = new System.Windows.Forms.Padding(0);
            this.dvTundish.MultiSelect = false;
            this.dvTundish.Name = "dvTundish";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvTundish.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvTundish.RowTemplate.Height = 23;
            this.dvTundish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvTundish.Size = new System.Drawing.Size(1000, 317);
            this.dvTundish.TabIndex = 31;
            this.dvTundish.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.dvTundish_CellContextMenuStripNeeded);
            this.dvTundish.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            this.dvTundish.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvTundish_DataBindingComplete);
            // 
            // CheckFlag
            // 
            this.CheckFlag.DataPropertyName = "CheckFlag";
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.Frozen = true;
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Width = 54;
            // 
            // TundishID
            // 
            this.TundishID.DataPropertyName = "TundishID";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.TundishID.DefaultCellStyle = dataGridViewCellStyle1;
            this.TundishID.Frozen = true;
            this.TundishID.HeaderText = "包号";
            this.TundishID.Name = "TundishID";
            this.TundishID.ReadOnly = true;
            this.TundishID.Width = 54;
            // 
            // TundishType
            // 
            this.TundishType.DataPropertyName = "TundishType";
            this.TundishType.DataSource = this.dsTundishType;
            this.TundishType.DisplayMember = "L3DataTable.Code_Des";
            this.TundishType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.TundishType.HeaderText = "中包类型";
            this.TundishType.Name = "TundishType";
            this.TundishType.ReadOnly = true;
            this.TundishType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TundishType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TundishType.ValueMember = "L3DataTable.Code_Val_Long";
            this.TundishType.Width = 78;
            // 
            // dsTundishType
            // 
            this.dsTundishType.AutoLoad = true;
            this.dsTundishType.AutoSubscribe = true;
            this.dsTundishType.DataSetName = "L3DataSet";
            this.dsTundishType.DeleteMethod = null;
            this.dsTundishType.InsertMethod = null;
            this.dsTundishType.L3DataAdapter = this.Adapter;
            this.dsTundishType.LoadEvent = "Click";
            this.dsTundishType.LoadTrigger = null;
            this.dsTundishType.RefreshValve = 1000;
            this.dsTundishType.SourceCommand = null;
            this.dsTundishType.SourceCondition = "Code_Group = \'TundishDirection\'";
            this.dsTundishType.SourceMethod = "";
            this.dsTundishType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTundishType.SubscribeTarget = null;
            this.dsTundishType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundishType});
            this.dsTundishType.UpdateEvent = "Click";
            this.dsTundishType.UpdateMethod = null;
            this.dsTundishType.UpdateTrigger = null;
            // 
            // schemadsTundishType
            // 
            this.schemadsTundishType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishTypeL3DataTableCode_Des,
            this.coldsTundishTypeL3DataTableCode_Val_Long});
            this.schemadsTundishType.TableName = "L3DataTable";
            // 
            // coldsTundishTypeL3DataTableCode_Des
            // 
            this.coldsTundishTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTundishTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTundishTypeL3DataTableCode_Des.Namespace = "";
            // 
            // coldsTundishTypeL3DataTableCode_Val_Long
            // 
            this.coldsTundishTypeL3DataTableCode_Val_Long.Caption = "Code_Val_Long";
            this.coldsTundishTypeL3DataTableCode_Val_Long.ColumnName = "Code_Val_Long";
            this.coldsTundishTypeL3DataTableCode_Val_Long.DataType = typeof(short);
            this.coldsTundishTypeL3DataTableCode_Val_Long.Namespace = "";
            // 
            // castIDDataGridViewTextBoxColumn
            // 
            this.castIDDataGridViewTextBoxColumn.DataPropertyName = "Cast_ID";
            this.castIDDataGridViewTextBoxColumn.HeaderText = "铸机号";
            this.castIDDataGridViewTextBoxColumn.Name = "castIDDataGridViewTextBoxColumn";
            this.castIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.castIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "车号";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            this.VehicleID.Width = 54;
            // 
            // refraProDataGridViewTextBoxColumn
            // 
            this.refraProDataGridViewTextBoxColumn.DataPropertyName = "Refra_Pro";
            this.refraProDataGridViewTextBoxColumn.HeaderText = "耐材产地";
            this.refraProDataGridViewTextBoxColumn.Name = "refraProDataGridViewTextBoxColumn";
            this.refraProDataGridViewTextBoxColumn.ReadOnly = true;
            this.refraProDataGridViewTextBoxColumn.Visible = false;
            this.refraProDataGridViewTextBoxColumn.Width = 78;
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
            // Flag
            // 
            this.Flag.DataPropertyName = "Flag";
            this.Flag.HeaderText = "完成标志";
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Width = 78;
            // 
            // tundishAgeDataGridViewTextBoxColumn
            // 
            this.tundishAgeDataGridViewTextBoxColumn.DataPropertyName = "Tundish_Age";
            this.tundishAgeDataGridViewTextBoxColumn.HeaderText = "包龄";
            this.tundishAgeDataGridViewTextBoxColumn.Name = "tundishAgeDataGridViewTextBoxColumn";
            this.tundishAgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tundishAgeDataGridViewTextBoxColumn.Width = 54;
            // 
            // tundishNODataGridViewTextBoxColumn
            // 
            this.tundishNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tundishNODataGridViewTextBoxColumn.DataPropertyName = "TundishNO";
            this.tundishNODataGridViewTextBoxColumn.HeaderText = "包次号";
            this.tundishNODataGridViewTextBoxColumn.Name = "tundishNODataGridViewTextBoxColumn";
            this.tundishNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // innerIDDataGridViewTextBoxColumn
            // 
            this.innerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.innerIDDataGridViewTextBoxColumn.DataPropertyName = "InnerID";
            this.innerIDDataGridViewTextBoxColumn.HeaderText = "永久层编号";
            this.innerIDDataGridViewTextBoxColumn.Name = "innerIDDataGridViewTextBoxColumn";
            this.innerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWorkFireStart,
            this.btnWorkFireEnd,
            this.btnConfirmCold,
            this.btnInstallStart,
            this.btnInstallEnd,
            this.btnOnFireStart,
            this.btnOnFireEnd,
            this.btnONLine,
            this.btnOFFLine,
            this.btnOffLineException});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 25);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1000, 25);
            this.bindingNavigator1.TabIndex = 31;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // dsTundishID
            // 
            this.dsTundishID.AutoLoad = true;
            this.dsTundishID.AutoSubscribe = true;
            this.dsTundishID.DataSetName = "L3DataSet";
            this.dsTundishID.DeleteMethod = null;
            this.dsTundishID.InsertMethod = null;
            this.dsTundishID.L3DataAdapter = this.Adapter;
            this.dsTundishID.LoadEvent = "Click";
            this.dsTundishID.LoadTrigger = null;
            this.dsTundishID.RefreshValve = 1000;
            this.dsTundishID.SourceCommand = null;
            this.dsTundishID.SourceCondition = "Code_Group = \'Tundish\'";
            this.dsTundishID.SourceMethod = "";
            this.dsTundishID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTundishID.SubscribeTarget = null;
            this.dsTundishID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemads});
            this.dsTundishID.UpdateEvent = "Click";
            this.dsTundishID.UpdateMethod = null;
            this.dsTundishID.UpdateTrigger = null;
            // 
            // schemads
            // 
            this.schemads.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsL3DataTableCode,
            this.coldsL3DataTableCode_Des});
            this.schemads.TableName = "L3DataTable";
            // 
            // coldsL3DataTableCode
            // 
            this.coldsL3DataTableCode.Caption = "Code";
            this.coldsL3DataTableCode.ColumnName = "Code";
            this.coldsL3DataTableCode.Namespace = "";
            // 
            // coldsL3DataTableCode_Des
            // 
            this.coldsL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsL3DataTableCode_Des.Namespace = "";
            // 
            // dsCastID
            // 
            this.dsCastID.AutoLoad = true;
            this.dsCastID.AutoSubscribe = true;
            this.dsCastID.DataSetName = "L3DataSet";
            this.dsCastID.DeleteMethod = null;
            this.dsCastID.InsertMethod = null;
            this.dsCastID.L3DataAdapter = this.Adapter;
            this.dsCastID.LoadEvent = "Click";
            this.dsCastID.LoadTrigger = null;
            this.dsCastID.RefreshValve = 1000;
            this.dsCastID.SourceCommand = null;
            this.dsCastID.SourceCondition = "Code_Group = \'Caster\'";
            this.dsCastID.SourceMethod = "";
            this.dsCastID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCastID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCastID.SubscribeTarget = null;
            this.dsCastID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCastID});
            this.dsCastID.UpdateEvent = "Click";
            this.dsCastID.UpdateMethod = null;
            this.dsCastID.UpdateTrigger = null;
            // 
            // schemadsCastID
            // 
            this.schemadsCastID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCastIDL3DataTableCode,
            this.coldsCastIDL3DataTableCode_Des});
            this.schemadsCastID.TableName = "L3DataTable";
            // 
            // coldsCastIDL3DataTableCode
            // 
            this.coldsCastIDL3DataTableCode.Caption = "Code";
            this.coldsCastIDL3DataTableCode.ColumnName = "Code";
            this.coldsCastIDL3DataTableCode.Namespace = "";
            // 
            // coldsCastIDL3DataTableCode_Des
            // 
            this.coldsCastIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCastIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCastIDL3DataTableCode_Des.Namespace = "";
            // 
            // dsRefraPro
            // 
            this.dsRefraPro.AutoLoad = true;
            this.dsRefraPro.AutoSubscribe = true;
            this.dsRefraPro.DataSetName = "L3DataSet";
            this.dsRefraPro.DeleteMethod = null;
            this.dsRefraPro.InsertMethod = null;
            this.dsRefraPro.L3DataAdapter = this.Adapter;
            this.dsRefraPro.LoadEvent = "Click";
            this.dsRefraPro.LoadTrigger = null;
            this.dsRefraPro.RefreshValve = 1000;
            this.dsRefraPro.SourceCommand = null;
            this.dsRefraPro.SourceCondition = null;
            this.dsRefraPro.SourceMethod = null;
            this.dsRefraPro.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsRefraPro.SourceURI = null;
            this.dsRefraPro.SubscribeTarget = null;
            this.dsRefraPro.UpdateEvent = "Click";
            this.dsRefraPro.UpdateMethod = null;
            this.dsRefraPro.UpdateTrigger = null;
            // 
            // cmdInnerTieStart
            // 
            this.cmdInnerTieStart.Adapter = this.Adapter;
            this.cmdInnerTieStart.MergeReturnTarget = false;
            this.cmdInnerTieStart.Method = "TundishInnerBuildStart";
            this.cmdInnerTieStart.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdInnerTieStart.Parameters.Add(this.l3cmdpTieStart);
            this.cmdInnerTieStart.ReturnTarget = null;
            this.cmdInnerTieStart.ReturnTargetProperty = null;
            this.cmdInnerTieStart.Trigger = null;
            this.cmdInnerTieStart.TriggerEvent = "Click";
            // 
            // l3cmdpTieStart
            // 
            this.l3cmdpTieStart.AcceptAfterExecuted = false;
            this.l3cmdpTieStart.ConstantValue = null;
            this.l3cmdpTieStart.MergeTarget = false;
            this.l3cmdpTieStart.SourceFilter = "";
            this.l3cmdpTieStart.SourceObject = this.dsTundish;
            this.l3cmdpTieStart.SourceProperty = "L3DataTable";
            this.l3cmdpTieStart.TargetObject = null;
            this.l3cmdpTieStart.TargetProperty = null;
            // 
            // cmdInnerTieEnd
            // 
            this.cmdInnerTieEnd.Adapter = this.Adapter;
            this.cmdInnerTieEnd.MergeReturnTarget = false;
            this.cmdInnerTieEnd.Method = "TundishInnerBuildEnd";
            this.cmdInnerTieEnd.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdInnerTieEnd.Parameters.Add(this.l3cmdpTieEnd);
            this.cmdInnerTieEnd.ReturnTarget = null;
            this.cmdInnerTieEnd.ReturnTargetProperty = null;
            this.cmdInnerTieEnd.Trigger = null;
            this.cmdInnerTieEnd.TriggerEvent = "Click";
            // 
            // l3cmdpTieEnd
            // 
            this.l3cmdpTieEnd.AcceptAfterExecuted = false;
            this.l3cmdpTieEnd.ConstantValue = null;
            this.l3cmdpTieEnd.MergeTarget = false;
            this.l3cmdpTieEnd.SourceFilter = "";
            this.l3cmdpTieEnd.SourceObject = this.dsTundish;
            this.l3cmdpTieEnd.SourceProperty = "L3DataTable";
            this.l3cmdpTieEnd.TargetObject = null;
            this.l3cmdpTieEnd.TargetProperty = null;
            // 
            // cmdInnerFireStart
            // 
            this.cmdInnerFireStart.Adapter = this.Adapter;
            this.cmdInnerFireStart.MergeReturnTarget = false;
            this.cmdInnerFireStart.Method = "TundishInnerFireStart";
            this.cmdInnerFireStart.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdInnerFireStart.Parameters.Add(this.l3cmdpFireStart);
            this.cmdInnerFireStart.ReturnTarget = null;
            this.cmdInnerFireStart.ReturnTargetProperty = null;
            this.cmdInnerFireStart.Trigger = null;
            this.cmdInnerFireStart.TriggerEvent = "Click";
            // 
            // l3cmdpFireStart
            // 
            this.l3cmdpFireStart.AcceptAfterExecuted = false;
            this.l3cmdpFireStart.ConstantValue = null;
            this.l3cmdpFireStart.MergeTarget = false;
            this.l3cmdpFireStart.SourceFilter = "";
            this.l3cmdpFireStart.SourceObject = this.dsTundish;
            this.l3cmdpFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpFireStart.TargetObject = null;
            this.l3cmdpFireStart.TargetProperty = null;
            // 
            // cmdInnerFireEnd
            // 
            this.cmdInnerFireEnd.Adapter = this.Adapter;
            this.cmdInnerFireEnd.MergeReturnTarget = false;
            this.cmdInnerFireEnd.Method = "TundishInnerFireEnd";
            this.cmdInnerFireEnd.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdInnerFireEnd.Parameters.Add(this.l3cmdpFireEnd);
            this.cmdInnerFireEnd.ReturnTarget = null;
            this.cmdInnerFireEnd.ReturnTargetProperty = null;
            this.cmdInnerFireEnd.Trigger = null;
            this.cmdInnerFireEnd.TriggerEvent = "Click";
            // 
            // l3cmdpFireEnd
            // 
            this.l3cmdpFireEnd.AcceptAfterExecuted = false;
            this.l3cmdpFireEnd.ConstantValue = null;
            this.l3cmdpFireEnd.MergeTarget = false;
            this.l3cmdpFireEnd.SourceFilter = "";
            this.l3cmdpFireEnd.SourceObject = this.dsTundish;
            this.l3cmdpFireEnd.SourceProperty = "L3DataTable";
            this.l3cmdpFireEnd.TargetObject = null;
            this.l3cmdpFireEnd.TargetProperty = null;
            // 
            // cmdWorkBuildStart
            // 
            this.cmdWorkBuildStart.Adapter = this.Adapter;
            this.cmdWorkBuildStart.MergeReturnTarget = false;
            this.cmdWorkBuildStart.Method = "TundishWorkBuildStart";
            this.cmdWorkBuildStart.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdWorkBuildStart.Parameters.Add(this.l3cmdpWorkBuildStart);
            this.cmdWorkBuildStart.ReturnTarget = null;
            this.cmdWorkBuildStart.ReturnTargetProperty = null;
            this.cmdWorkBuildStart.Trigger = null;
            this.cmdWorkBuildStart.TriggerEvent = "Click";
            // 
            // l3cmdpWorkBuildStart
            // 
            this.l3cmdpWorkBuildStart.AcceptAfterExecuted = false;
            this.l3cmdpWorkBuildStart.ConstantValue = "";
            this.l3cmdpWorkBuildStart.MergeTarget = false;
            this.l3cmdpWorkBuildStart.SourceFilter = "";
            this.l3cmdpWorkBuildStart.SourceObject = this.dsTundish;
            this.l3cmdpWorkBuildStart.SourceProperty = "L3DataTable";
            this.l3cmdpWorkBuildStart.TargetObject = null;
            this.l3cmdpWorkBuildStart.TargetProperty = null;
            // 
            // cmdWorkBuildEnd
            // 
            this.cmdWorkBuildEnd.Adapter = this.Adapter;
            this.cmdWorkBuildEnd.MergeReturnTarget = false;
            this.cmdWorkBuildEnd.Method = "TundishWorkBuildEnd";
            this.cmdWorkBuildEnd.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdWorkBuildEnd.Parameters.Add(this.l3cmdpWorkBuildEnd);
            this.cmdWorkBuildEnd.ReturnTarget = null;
            this.cmdWorkBuildEnd.ReturnTargetProperty = null;
            this.cmdWorkBuildEnd.Trigger = null;
            this.cmdWorkBuildEnd.TriggerEvent = "Click";
            // 
            // l3cmdpWorkBuildEnd
            // 
            this.l3cmdpWorkBuildEnd.AcceptAfterExecuted = false;
            this.l3cmdpWorkBuildEnd.ConstantValue = null;
            this.l3cmdpWorkBuildEnd.MergeTarget = false;
            this.l3cmdpWorkBuildEnd.SourceFilter = "";
            this.l3cmdpWorkBuildEnd.SourceObject = this.dsTundish;
            this.l3cmdpWorkBuildEnd.SourceProperty = "L3DataTable";
            this.l3cmdpWorkBuildEnd.TargetObject = null;
            this.l3cmdpWorkBuildEnd.TargetProperty = null;
            // 
            // cmdWorkFireStart
            // 
            this.cmdWorkFireStart.Adapter = this.Adapter;
            this.cmdWorkFireStart.MergeReturnTarget = false;
            this.cmdWorkFireStart.Method = "TundishWorkFireStart";
            this.cmdWorkFireStart.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdWorkFireStart.Parameters.Add(this.l3cmdpWorkFireStart);
            this.cmdWorkFireStart.ReturnTarget = null;
            this.cmdWorkFireStart.ReturnTargetProperty = null;
            this.cmdWorkFireStart.Trigger = null;
            this.cmdWorkFireStart.TriggerEvent = "Click";
            // 
            // l3cmdpWorkFireStart
            // 
            this.l3cmdpWorkFireStart.AcceptAfterExecuted = false;
            this.l3cmdpWorkFireStart.ConstantValue = null;
            this.l3cmdpWorkFireStart.MergeTarget = false;
            this.l3cmdpWorkFireStart.SourceFilter = "";
            this.l3cmdpWorkFireStart.SourceObject = this.dsTundish;
            this.l3cmdpWorkFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpWorkFireStart.TargetObject = null;
            this.l3cmdpWorkFireStart.TargetProperty = null;
            // 
            // cmdWorkFireEnd
            // 
            this.cmdWorkFireEnd.Adapter = this.Adapter;
            this.cmdWorkFireEnd.MergeReturnTarget = false;
            this.cmdWorkFireEnd.Method = "TundishWorkFireEnd";
            this.cmdWorkFireEnd.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdWorkFireEnd.Parameters.Add(this.l3cmdpWorkFireEnd);
            this.cmdWorkFireEnd.ReturnTarget = null;
            this.cmdWorkFireEnd.ReturnTargetProperty = null;
            this.cmdWorkFireEnd.Trigger = null;
            this.cmdWorkFireEnd.TriggerEvent = "Click";
            // 
            // l3cmdpWorkFireEnd
            // 
            this.l3cmdpWorkFireEnd.AcceptAfterExecuted = false;
            this.l3cmdpWorkFireEnd.ConstantValue = null;
            this.l3cmdpWorkFireEnd.MergeTarget = false;
            this.l3cmdpWorkFireEnd.SourceFilter = "";
            this.l3cmdpWorkFireEnd.SourceObject = this.dsTundish;
            this.l3cmdpWorkFireEnd.SourceProperty = "L3DataTable";
            this.l3cmdpWorkFireEnd.TargetObject = null;
            this.l3cmdpWorkFireEnd.TargetProperty = null;
            // 
            // cmdOnFireStart
            // 
            this.cmdOnFireStart.Adapter = this.Adapter;
            this.cmdOnFireStart.MergeReturnTarget = false;
            this.cmdOnFireStart.Method = "TundishOnFireStart";
            this.cmdOnFireStart.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdOnFireStart.Parameters.Add(this.l3cmdpOnFireStart);
            this.cmdOnFireStart.ReturnTarget = null;
            this.cmdOnFireStart.ReturnTargetProperty = null;
            this.cmdOnFireStart.Trigger = null;
            this.cmdOnFireStart.TriggerEvent = "Click";
            // 
            // l3cmdpOnFireStart
            // 
            this.l3cmdpOnFireStart.AcceptAfterExecuted = false;
            this.l3cmdpOnFireStart.ConstantValue = null;
            this.l3cmdpOnFireStart.MergeTarget = false;
            this.l3cmdpOnFireStart.SourceFilter = "";
            this.l3cmdpOnFireStart.SourceObject = this.dsTundish;
            this.l3cmdpOnFireStart.SourceProperty = "L3DataTable";
            this.l3cmdpOnFireStart.TargetObject = null;
            this.l3cmdpOnFireStart.TargetProperty = null;
            // 
            // cmdOnFireEnd
            // 
            this.cmdOnFireEnd.Adapter = this.Adapter;
            this.cmdOnFireEnd.MergeReturnTarget = false;
            this.cmdOnFireEnd.Method = "TundishOnFireEnd";
            this.cmdOnFireEnd.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdOnFireEnd.Parameters.Add(this.l3cmdpOnFireEnd);
            this.cmdOnFireEnd.ReturnTarget = null;
            this.cmdOnFireEnd.ReturnTargetProperty = null;
            this.cmdOnFireEnd.Trigger = null;
            this.cmdOnFireEnd.TriggerEvent = "Click";
            // 
            // l3cmdpOnFireEnd
            // 
            this.l3cmdpOnFireEnd.AcceptAfterExecuted = false;
            this.l3cmdpOnFireEnd.ConstantValue = null;
            this.l3cmdpOnFireEnd.MergeTarget = false;
            this.l3cmdpOnFireEnd.SourceFilter = "";
            this.l3cmdpOnFireEnd.SourceObject = this.dsTundish;
            this.l3cmdpOnFireEnd.SourceProperty = "L3DataTable";
            this.l3cmdpOnFireEnd.TargetObject = null;
            this.l3cmdpOnFireEnd.TargetProperty = null;
            // 
            // l3cmdpCold
            // 
            this.l3cmdpCold.AcceptAfterExecuted = false;
            this.l3cmdpCold.ConstantValue = null;
            this.l3cmdpCold.MergeTarget = false;
            this.l3cmdpCold.SourceFilter = null;
            this.l3cmdpCold.SourceObject = null;
            this.l3cmdpCold.SourceProperty = null;
            this.l3cmdpCold.TargetObject = null;
            this.l3cmdpCold.TargetProperty = null;
            // 
            // cmdConfirmCold
            // 
            this.cmdConfirmCold.Adapter = this.Adapter;
            this.cmdConfirmCold.MergeReturnTarget = false;
            this.cmdConfirmCold.Method = "TundishConfirmCold";
            this.cmdConfirmCold.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdConfirmCold.Parameters.Add(this.l3cmdpConfirmCold);
            this.cmdConfirmCold.ReturnTarget = null;
            this.cmdConfirmCold.ReturnTargetProperty = null;
            this.cmdConfirmCold.Trigger = null;
            this.cmdConfirmCold.TriggerEvent = "Click";
            // 
            // l3cmdpConfirmCold
            // 
            this.l3cmdpConfirmCold.AcceptAfterExecuted = false;
            this.l3cmdpConfirmCold.ConstantValue = null;
            this.l3cmdpConfirmCold.MergeTarget = false;
            this.l3cmdpConfirmCold.SourceFilter = null;
            this.l3cmdpConfirmCold.SourceObject = this.dsTundish;
            this.l3cmdpConfirmCold.SourceProperty = "L3DataTable";
            this.l3cmdpConfirmCold.TargetObject = null;
            this.l3cmdpConfirmCold.TargetProperty = null;
            // 
            // cmdInstallStart
            // 
            this.cmdInstallStart.Adapter = this.Adapter;
            this.cmdInstallStart.MergeReturnTarget = false;
            this.cmdInstallStart.Method = "TundishInstallStart";
            this.cmdInstallStart.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdInstallStart.Parameters.Add(this.l3cmdpInstallStart);
            this.cmdInstallStart.ReturnTarget = null;
            this.cmdInstallStart.ReturnTargetProperty = null;
            this.cmdInstallStart.Trigger = null;
            this.cmdInstallStart.TriggerEvent = "Click";
            // 
            // l3cmdpInstallStart
            // 
            this.l3cmdpInstallStart.AcceptAfterExecuted = false;
            this.l3cmdpInstallStart.ConstantValue = null;
            this.l3cmdpInstallStart.MergeTarget = false;
            this.l3cmdpInstallStart.SourceFilter = null;
            this.l3cmdpInstallStart.SourceObject = this.dsTundish;
            this.l3cmdpInstallStart.SourceProperty = "L3DataTable";
            this.l3cmdpInstallStart.TargetObject = null;
            this.l3cmdpInstallStart.TargetProperty = null;
            // 
            // cmdInstallEnd
            // 
            this.cmdInstallEnd.Adapter = this.Adapter;
            this.cmdInstallEnd.MergeReturnTarget = false;
            this.cmdInstallEnd.Method = "TundishInstallEnd";
            this.cmdInstallEnd.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdInstallEnd.Parameters.Add(this.l3cmdpInstallEnd);
            this.cmdInstallEnd.ReturnTarget = null;
            this.cmdInstallEnd.ReturnTargetProperty = null;
            this.cmdInstallEnd.Trigger = null;
            this.cmdInstallEnd.TriggerEvent = "Click";
            // 
            // l3cmdpInstallEnd
            // 
            this.l3cmdpInstallEnd.AcceptAfterExecuted = false;
            this.l3cmdpInstallEnd.ConstantValue = null;
            this.l3cmdpInstallEnd.MergeTarget = false;
            this.l3cmdpInstallEnd.SourceFilter = null;
            this.l3cmdpInstallEnd.SourceObject = this.dsTundish;
            this.l3cmdpInstallEnd.SourceProperty = "L3DataTable";
            this.l3cmdpInstallEnd.TargetObject = null;
            this.l3cmdpInstallEnd.TargetProperty = null;
            // 
            // cmdTundishDireCCMID
            // 
            this.cmdTundishDireCCMID.Adapter = this.Adapter;
            this.cmdTundishDireCCMID.MergeReturnTarget = false;
            this.cmdTundishDireCCMID.Method = "TundishDireCCMID";
            this.cmdTundishDireCCMID.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
            this.cmdTundishDireCCMID.Parameters.Add(this.l3cmdpTundishID);
            this.cmdTundishDireCCMID.Parameters.Add(this.l3cmdpCCMID);
            this.cmdTundishDireCCMID.ReturnTarget = null;
            this.cmdTundishDireCCMID.ReturnTargetProperty = null;
            this.cmdTundishDireCCMID.Trigger = null;
            this.cmdTundishDireCCMID.TriggerEvent = "Click";
            // 
            // l3cmdpTundishID
            // 
            this.l3cmdpTundishID.AcceptAfterExecuted = false;
            this.l3cmdpTundishID.ConstantValue = null;
            this.l3cmdpTundishID.MergeTarget = false;
            this.l3cmdpTundishID.SourceFilter = null;
            this.l3cmdpTundishID.SourceObject = null;
            this.l3cmdpTundishID.SourceProperty = null;
            this.l3cmdpTundishID.TargetObject = null;
            this.l3cmdpTundishID.TargetProperty = null;
            // 
            // l3cmdpCCMID
            // 
            this.l3cmdpCCMID.AcceptAfterExecuted = false;
            this.l3cmdpCCMID.ConstantValue = null;
            this.l3cmdpCCMID.MergeTarget = false;
            this.l3cmdpCCMID.SourceFilter = null;
            this.l3cmdpCCMID.SourceObject = null;
            this.l3cmdpCCMID.SourceProperty = null;
            this.l3cmdpCCMID.TargetObject = null;
            this.l3cmdpCCMID.TargetProperty = null;
            // 
            // cmdOffLineException
            // 
            this.cmdOffLineException.Adapter = this.Adapter;
            this.cmdOffLineException.MergeReturnTarget = false;
            this.cmdOffLineException.Method = "TundishOffLineException";
            this.cmdOffLineException.Object = "XGMESLogic\\TundishMag\\CTundish_Mag\\Tundish_Mag";
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
            this.cmdpOffLineException.SourceObject = this.dsTundish;
            this.cmdpOffLineException.SourceProperty = "L3DataTable";
            this.cmdpOffLineException.TargetObject = null;
            this.cmdpOffLineException.TargetProperty = null;
            // 
            // menuS66
            // 
            this.menuS66.Name = "menuS66";
            this.menuS66.Size = new System.Drawing.Size(152, 22);
            this.menuS66.Text = "上6#铸机";
            this.menuS66.Visible = false;
            this.menuS66.Click += new System.EventHandler(this.menuDire_Click);
            // 
            // TundishBaseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 392);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishBaseMagFrm";
            this.TabText = "3/4/5/7/6 #机中包基本信息管理";
            this.Text = "中包基本信息管理";
            this.Load += new System.EventHandler(this.TundishBaseMagFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TundishBaseMagFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsTundish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundish)).EndInit();
            this.cmsTundishDire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsStatus)).EndInit();
            this.tbLPM.ResumeLayout(false);
            this.tbLPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTundish)).EndInit();
            this.bnTundish.ResumeLayout(false);
            this.bnTundish.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTundish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCastID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCastID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRefraPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsTundish;
        private System.Windows.Forms.BindingSource bsTundish;
        private AppSvrHMI.L3DataSet dsStatus;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bnTundish;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip tSp1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvTundish;
        private System.Data.DataTable schemadsTundish;
        private System.Data.DataColumn coldsTundishL3DataTableGUID;
        private System.Data.DataColumn coldsTundishL3DataTableName;
        private System.Data.DataColumn coldsTundishL3DataTableTundishID;
        private System.Data.DataColumn coldsTundishL3DataTableCast_ID;
        private System.Data.DataColumn coldsTundishL3DataTableRefra_Pro;
        private System.Data.DataColumn coldsTundishL3DataTableStatus;
        private System.Data.DataColumn coldsTundishL3DataTableTundish_Age;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemads;
        private System.Data.DataColumn coldsL3DataTableCode;
        private System.Data.DataColumn coldsL3DataTableCode_Des;
        private System.Data.DataColumn coldsTundishL3DataTableCheckFlag;
        private AppSvrHMI.L3DataSet dsCastID;
        private System.Data.DataTable schemadsCastID;
        private System.Data.DataColumn coldsCastIDL3DataTableCode;
        private System.Data.DataColumn coldsCastIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsRefraPro;
        private System.Data.DataTable schemadsStatus;
        private System.Data.DataColumn coldsStatusL3DataTableCode;
        private System.Data.DataColumn coldsStatusL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdInnerTieStart;
        private AppSvrHMI.L3Command cmdInnerTieEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpTieEnd;
        private AppSvrHMI.L3Command cmdInnerFireStart;
        private AppSvrHMI.L3Command cmdInnerFireEnd;
        private AppSvrHMI.L3Command cmdWorkBuildStart;
        private AppSvrHMI.L3Command cmdWorkBuildEnd;
        private AppSvrHMI.L3Command cmdWorkFireStart;
        private AppSvrHMI.L3Command cmdWorkFireEnd;
        private AppSvrHMI.L3Command cmdOnFireStart;
        private AppSvrHMI.L3Command cmdOnFireEnd;
        private System.Data.DataColumn coldsTundishL3DataTableInnerID;
        private System.Data.DataColumn coldsTundishL3DataTableWorkID;
        private System.Data.DataColumn coldsTundishL3DataTableTundishNO;
        private AppSvrHMI.L3CommandParameter l3cmdpTieStart;
        private AppSvrHMI.L3CommandParameter l3cmdpFireEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkBuildStart;
        private AppSvrHMI.L3CommandParameter l3cmdpFireStart;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkBuildEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkFireStart;
        private AppSvrHMI.L3CommandParameter l3cmdpWorkFireEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpOnFireStart;
        private AppSvrHMI.L3CommandParameter l3cmdpOnFireEnd;
        private System.Data.DataColumn coldsTundishL3DataTableFlag;
        private System.Data.DataColumn coldsTundishL3DataTableTundishType;
        private AppSvrHMI.L3CommandParameter l3cmdpCold;
        private AppSvrHMI.L3DataSet dsTundishType;
        private System.Data.DataTable schemadsTundishType;
        private System.Data.DataColumn coldsTundishTypeL3DataTableCode_Des;
        private System.Data.DataColumn coldsTundishTypeL3DataTableCode_Val_Long;
        private AppSvrHMI.L3Command cmdConfirmCold;
        private AppSvrHMI.L3Command cmdInstallStart;
        private AppSvrHMI.L3Command cmdInstallEnd;
        private AppSvrHMI.L3CommandParameter l3cmdpConfirmCold;
        private AppSvrHMI.L3CommandParameter l3cmdpInstallStart;
        private AppSvrHMI.L3CommandParameter l3cmdpInstallEnd;
        private System.Windows.Forms.ToolStripButton btnInnerTieStart;
        private System.Windows.Forms.ToolStripButton btnInnerTieEnd;
        private System.Windows.Forms.ToolStripButton btnInnerFireStart;
        private System.Windows.Forms.ToolStripButton btnInnerFireEnd;
        private System.Windows.Forms.ToolStripButton btnWorkBuildStart;
        private System.Windows.Forms.ToolStripButton btnWorkBuildEnd;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btnConfirmCold;
        private System.Windows.Forms.ToolStripButton btnInstallStart;
        private System.Windows.Forms.ToolStripButton btnInstallEnd;
        private System.Windows.Forms.ToolStripButton btnOnFireStart;
        private System.Windows.Forms.ToolStripButton btnOnFireEnd;
        private System.Windows.Forms.ToolStripButton btnWorkFireStart;
        private System.Windows.Forms.ToolStripButton btnWorkFireEnd;
        private System.Windows.Forms.ContextMenuStrip cmsTundishDire;
        private System.Windows.Forms.ToolStripMenuItem menuS63;
        private System.Windows.Forms.ToolStripMenuItem menuS64;
        private System.Windows.Forms.ToolStripMenuItem menuS65;
        private System.Windows.Forms.ToolStripMenuItem menuCancelDire;
        private AppSvrHMI.L3Command cmdTundishDireCCMID;
        private AppSvrHMI.L3CommandParameter l3cmdpTundishID;
        private AppSvrHMI.L3CommandParameter l3cmdpCCMID;
        private System.Windows.Forms.ToolStripButton btnONLine;
        private System.Windows.Forms.ToolStripButton btnOFFLine;
        private System.Data.DataColumn coldsTundishL3DataTableVehicleID;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnOffLineException;
        private AppSvrHMI.L3Command cmdOffLineException;
        private AppSvrHMI.L3CommandParameter cmdpOffLineException;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn TundishID;
        private System.Windows.Forms.DataGridViewComboBoxColumn TundishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn castIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn refraProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem menuS67;
        private System.Windows.Forms.ToolStripMenuItem menuS66;
    }
}