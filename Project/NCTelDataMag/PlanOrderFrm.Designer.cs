namespace NCTelDataMag
{
    partial class PlanOrderFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanOrderFrm));
            this.dvTel = new System.Windows.Forms.DataGridView();
            this.bnM = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsPlanOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlanOrder = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsPlanOrder = new System.Data.DataTable();
            this.coldsPlanOrderL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTableFlag = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablescddh = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablepk_poid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablejhddh = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablewlbmid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablepk_produce = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTableinvcode = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablenvname = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablepch = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablescbmid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablegzzxid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablegzzxbm = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTableksid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablememo = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablesfjj = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTableyxj = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablebcid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablebzid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablejhkgrq = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablejhwgrq = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablejhkssj = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablejhjssj = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablesjkgrq = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablesjwgrq = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablesjkssj = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablesjjssj = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablejhwgsl = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablefjhsl = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablejldwid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablefjlid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablesjwgsl = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablefwcsl = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablegcbm = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablezdrid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablepk_moid = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTablePlanID = new System.Data.DataColumn();
            this.coldsPlanOrderL3DataTableNC_Confirm_Flag = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txbHeatID = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnUpdateSend = new System.Windows.Forms.ToolStripButton();
            this.btnAddSend = new System.Windows.Forms.ToolStripButton();
            this.dvPlanOrder = new System.Windows.Forms.DataGridView();
            this.heatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scddhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkpoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhddhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wlbmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsMaterialID = new AppSvrHMI.L3DataSet();
            this.schemadsMaterialID = new System.Data.DataTable();
            this.coldsMaterialIDL3DataTablePk_Material_Bas = new System.Data.DataColumn();
            this.coldsMaterialIDL3DataTableMaterial_Name = new System.Data.DataColumn();
            this.pkproduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scbmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsDepartment = new AppSvrHMI.L3DataSet();
            this.schemadsDepartment = new System.Data.DataTable();
            this.coldsDepartmentL3DataTablePk_Department = new System.Data.DataColumn();
            this.coldsDepartmentL3DataTableDepartment_Code = new System.Data.DataColumn();
            this.gzzxidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWorkCenter = new AppSvrHMI.L3DataSet();
            this.schemadsWorkCenter = new System.Data.DataTable();
            this.coldsWorkCenterL3DataTablePk_Center = new System.Data.DataColumn();
            this.coldsWorkCenterL3DataTableCenter_Code = new System.Data.DataColumn();
            this.gzzxbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfjjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yxjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bcidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShift = new AppSvrHMI.L3DataSet();
            this.schemadsShift = new System.Data.DataTable();
            this.coldsShiftL3DataTablePk_Shift = new System.Data.DataColumn();
            this.coldsShiftL3DataTableShift_Name = new System.Data.DataColumn();
            this.bzidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsGroup = new AppSvrHMI.L3DataSet();
            this.schemadsGroup = new System.Data.DataTable();
            this.coldsGroupL3DataTablePk_Team = new System.Data.DataColumn();
            this.coldsGroupL3DataTableTeam_Name = new System.Data.DataColumn();
            this.jhkgrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhwgrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhkssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhjssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjkgrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjwgrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjkssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjjssjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhwgslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjhslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jldwidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjlidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sjwgslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fwcslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdy5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zyx5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkcorpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkmoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCConfirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdPlanOrder = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsLog = new AppSvrHMI.L3DataSet();
            this.schemadsLog = new System.Data.DataTable();
            this.coldsLogL3DataTableGUID = new System.Data.DataColumn();
            this.coldsLogL3DataTableName = new System.Data.DataColumn();
            this.coldsLogL3DataTableHeatID = new System.Data.DataColumn();
            this.coldsLogL3DataTableBillType = new System.Data.DataColumn();
            this.coldsLogL3DataTableFlag = new System.Data.DataColumn();
            this.coldsLogL3DataTableRemark = new System.Data.DataColumn();
            this.coldsLogL3DataTableCreateTime = new System.Data.DataColumn();
            this.coldsLogL3DataTableOther1 = new System.Data.DataColumn();
            this.coldsLogL3DataTableOther2 = new System.Data.DataColumn();
            this.coldsLogL3DataTableOther3 = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).BeginInit();
            this.bnM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlanOrder)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWorkCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dvTel
            // 
            this.dvTel.AllowUserToAddRows = false;
            this.dvTel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvTel.ColumnHeadersHeight = 35;
            this.dvTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTel.Location = new System.Drawing.Point(0, 68);
            this.dvTel.MultiSelect = false;
            this.dvTel.Name = "dvTel";
            this.dvTel.RowTemplate.Height = 23;
            this.dvTel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTel.Size = new System.Drawing.Size(669, 283);
            this.dvTel.TabIndex = 35;
            // 
            // bnM
            // 
            this.bnM.AddNewItem = null;
            this.bnM.AutoSize = false;
            this.bnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnM.BackgroundImage")));
            this.bnM.BindingSource = this.bsPlanOrder;
            this.bnM.CountItem = this.bindingNavigatorCountItem;
            this.bnM.DeleteItem = null;
            this.bnM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel2,
            this.toolStripButton1,
            this.txbHeatID,
            this.toolStripLabel4});
            this.bnM.Location = new System.Drawing.Point(0, 43);
            this.bnM.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnM.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnM.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnM.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnM.Name = "bnM";
            this.bnM.PositionItem = this.bindingNavigatorPositionItem;
            this.bnM.Size = new System.Drawing.Size(669, 25);
            this.bnM.TabIndex = 34;
            this.bnM.Text = "bindingNavigator1";
            // 
            // bsPlanOrder
            // 
            this.bsPlanOrder.DataMember = "L3DataTable";
            this.bsPlanOrder.DataSource = this.dsPlanOrder;
            // 
            // dsPlanOrder
            // 
            this.dsPlanOrder.AutoLoad = true;
            this.dsPlanOrder.AutoSubscribe = true;
            this.dsPlanOrder.DataSetName = "L3DataSet";
            this.dsPlanOrder.DeleteMethod = "";
            this.dsPlanOrder.InsertMethod = "";
            this.dsPlanOrder.L3DataAdapter = this.Adapter;
            this.dsPlanOrder.LoadEvent = "";
            this.dsPlanOrder.LoadTrigger = null;
            this.dsPlanOrder.RefreshValve = 1000;
            this.dsPlanOrder.SourceCommand = null;
            this.dsPlanOrder.SourceCondition = "";
            this.dsPlanOrder.SourceMethod = "";
            this.dsPlanOrder.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsPlanOrder.SourceURI = "";
            this.dsPlanOrder.SubscribeTarget = "";
            this.dsPlanOrder.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPlanOrder});
            this.dsPlanOrder.UpdateEvent = "";
            this.dsPlanOrder.UpdateMethod = "";
            this.dsPlanOrder.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsPlanOrder
            // 
            this.schemadsPlanOrder.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPlanOrderL3DataTableHeatID,
            this.coldsPlanOrderL3DataTableFlag,
            this.coldsPlanOrderL3DataTablescddh,
            this.coldsPlanOrderL3DataTablepk_poid,
            this.coldsPlanOrderL3DataTablejhddh,
            this.coldsPlanOrderL3DataTablewlbmid,
            this.coldsPlanOrderL3DataTablepk_produce,
            this.coldsPlanOrderL3DataTableinvcode,
            this.coldsPlanOrderL3DataTablenvname,
            this.coldsPlanOrderL3DataTablepch,
            this.coldsPlanOrderL3DataTablescbmid,
            this.coldsPlanOrderL3DataTablegzzxid,
            this.coldsPlanOrderL3DataTablegzzxbm,
            this.coldsPlanOrderL3DataTableksid,
            this.coldsPlanOrderL3DataTablememo,
            this.coldsPlanOrderL3DataTablesfjj,
            this.coldsPlanOrderL3DataTableyxj,
            this.coldsPlanOrderL3DataTablebcid,
            this.coldsPlanOrderL3DataTablebzid,
            this.coldsPlanOrderL3DataTablejhkgrq,
            this.coldsPlanOrderL3DataTablejhwgrq,
            this.coldsPlanOrderL3DataTablejhkssj,
            this.coldsPlanOrderL3DataTablejhjssj,
            this.coldsPlanOrderL3DataTablesjkgrq,
            this.coldsPlanOrderL3DataTablesjwgrq,
            this.coldsPlanOrderL3DataTablesjkssj,
            this.coldsPlanOrderL3DataTablesjjssj,
            this.coldsPlanOrderL3DataTablejhwgsl,
            this.coldsPlanOrderL3DataTablefjhsl,
            this.coldsPlanOrderL3DataTablejldwid,
            this.coldsPlanOrderL3DataTablefjlid,
            this.coldsPlanOrderL3DataTablesjwgsl,
            this.coldsPlanOrderL3DataTablefwcsl,
            this.coldsPlanOrderL3DataTablezdy1,
            this.coldsPlanOrderL3DataTablezdy2,
            this.coldsPlanOrderL3DataTablezdy3,
            this.coldsPlanOrderL3DataTablezdy4,
            this.coldsPlanOrderL3DataTablezdy5,
            this.coldsPlanOrderL3DataTablezyx1,
            this.coldsPlanOrderL3DataTablezyx2,
            this.coldsPlanOrderL3DataTablezyx3,
            this.coldsPlanOrderL3DataTablezyx4,
            this.coldsPlanOrderL3DataTablezyx5,
            this.coldsPlanOrderL3DataTablepk_corp,
            this.coldsPlanOrderL3DataTablegcbm,
            this.coldsPlanOrderL3DataTablezdrid,
            this.coldsPlanOrderL3DataTablepk_moid,
            this.coldsPlanOrderL3DataTablePlanID,
            this.coldsPlanOrderL3DataTableNC_Confirm_Flag});
            this.schemadsPlanOrder.TableName = "L3DataTable";
            // 
            // coldsPlanOrderL3DataTableHeatID
            // 
            this.coldsPlanOrderL3DataTableHeatID.Caption = "HeatID";
            this.coldsPlanOrderL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsPlanOrderL3DataTableHeatID.Namespace = "";
            // 
            // coldsPlanOrderL3DataTableFlag
            // 
            this.coldsPlanOrderL3DataTableFlag.Caption = "Flag";
            this.coldsPlanOrderL3DataTableFlag.ColumnName = "Flag";
            this.coldsPlanOrderL3DataTableFlag.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablescddh
            // 
            this.coldsPlanOrderL3DataTablescddh.Caption = "scddh";
            this.coldsPlanOrderL3DataTablescddh.ColumnName = "scddh";
            this.coldsPlanOrderL3DataTablescddh.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablepk_poid
            // 
            this.coldsPlanOrderL3DataTablepk_poid.Caption = "pk_poid";
            this.coldsPlanOrderL3DataTablepk_poid.ColumnName = "pk_poid";
            this.coldsPlanOrderL3DataTablepk_poid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablejhddh
            // 
            this.coldsPlanOrderL3DataTablejhddh.Caption = "jhddh";
            this.coldsPlanOrderL3DataTablejhddh.ColumnName = "jhddh";
            this.coldsPlanOrderL3DataTablejhddh.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablewlbmid
            // 
            this.coldsPlanOrderL3DataTablewlbmid.Caption = "wlbmid";
            this.coldsPlanOrderL3DataTablewlbmid.ColumnName = "wlbmid";
            this.coldsPlanOrderL3DataTablewlbmid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablepk_produce
            // 
            this.coldsPlanOrderL3DataTablepk_produce.Caption = "pk_produce";
            this.coldsPlanOrderL3DataTablepk_produce.ColumnName = "pk_produce";
            this.coldsPlanOrderL3DataTablepk_produce.Namespace = "";
            // 
            // coldsPlanOrderL3DataTableinvcode
            // 
            this.coldsPlanOrderL3DataTableinvcode.Caption = "invcode";
            this.coldsPlanOrderL3DataTableinvcode.ColumnName = "invcode";
            this.coldsPlanOrderL3DataTableinvcode.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablenvname
            // 
            this.coldsPlanOrderL3DataTablenvname.Caption = "nvname";
            this.coldsPlanOrderL3DataTablenvname.ColumnName = "nvname";
            this.coldsPlanOrderL3DataTablenvname.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablepch
            // 
            this.coldsPlanOrderL3DataTablepch.Caption = "pch";
            this.coldsPlanOrderL3DataTablepch.ColumnName = "pch";
            this.coldsPlanOrderL3DataTablepch.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablescbmid
            // 
            this.coldsPlanOrderL3DataTablescbmid.Caption = "scbmid";
            this.coldsPlanOrderL3DataTablescbmid.ColumnName = "scbmid";
            this.coldsPlanOrderL3DataTablescbmid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablegzzxid
            // 
            this.coldsPlanOrderL3DataTablegzzxid.Caption = "gzzxid";
            this.coldsPlanOrderL3DataTablegzzxid.ColumnName = "gzzxid";
            this.coldsPlanOrderL3DataTablegzzxid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablegzzxbm
            // 
            this.coldsPlanOrderL3DataTablegzzxbm.Caption = "gzzxbm";
            this.coldsPlanOrderL3DataTablegzzxbm.ColumnName = "gzzxbm";
            this.coldsPlanOrderL3DataTablegzzxbm.Namespace = "";
            // 
            // coldsPlanOrderL3DataTableksid
            // 
            this.coldsPlanOrderL3DataTableksid.Caption = "ksid";
            this.coldsPlanOrderL3DataTableksid.ColumnName = "ksid";
            this.coldsPlanOrderL3DataTableksid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablememo
            // 
            this.coldsPlanOrderL3DataTablememo.Caption = "memo";
            this.coldsPlanOrderL3DataTablememo.ColumnName = "memo";
            this.coldsPlanOrderL3DataTablememo.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablesfjj
            // 
            this.coldsPlanOrderL3DataTablesfjj.Caption = "sfjj";
            this.coldsPlanOrderL3DataTablesfjj.ColumnName = "sfjj";
            this.coldsPlanOrderL3DataTablesfjj.Namespace = "";
            // 
            // coldsPlanOrderL3DataTableyxj
            // 
            this.coldsPlanOrderL3DataTableyxj.Caption = "yxj";
            this.coldsPlanOrderL3DataTableyxj.ColumnName = "yxj";
            this.coldsPlanOrderL3DataTableyxj.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablebcid
            // 
            this.coldsPlanOrderL3DataTablebcid.Caption = "bcid";
            this.coldsPlanOrderL3DataTablebcid.ColumnName = "bcid";
            this.coldsPlanOrderL3DataTablebcid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablebzid
            // 
            this.coldsPlanOrderL3DataTablebzid.Caption = "bzid";
            this.coldsPlanOrderL3DataTablebzid.ColumnName = "bzid";
            this.coldsPlanOrderL3DataTablebzid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablejhkgrq
            // 
            this.coldsPlanOrderL3DataTablejhkgrq.Caption = "jhkgrq";
            this.coldsPlanOrderL3DataTablejhkgrq.ColumnName = "jhkgrq";
            this.coldsPlanOrderL3DataTablejhkgrq.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablejhwgrq
            // 
            this.coldsPlanOrderL3DataTablejhwgrq.Caption = "jhwgrq";
            this.coldsPlanOrderL3DataTablejhwgrq.ColumnName = "jhwgrq";
            this.coldsPlanOrderL3DataTablejhwgrq.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablejhkssj
            // 
            this.coldsPlanOrderL3DataTablejhkssj.Caption = "jhkssj";
            this.coldsPlanOrderL3DataTablejhkssj.ColumnName = "jhkssj";
            this.coldsPlanOrderL3DataTablejhkssj.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablejhjssj
            // 
            this.coldsPlanOrderL3DataTablejhjssj.Caption = "jhjssj";
            this.coldsPlanOrderL3DataTablejhjssj.ColumnName = "jhjssj";
            this.coldsPlanOrderL3DataTablejhjssj.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablesjkgrq
            // 
            this.coldsPlanOrderL3DataTablesjkgrq.Caption = "sjkgrq";
            this.coldsPlanOrderL3DataTablesjkgrq.ColumnName = "sjkgrq";
            this.coldsPlanOrderL3DataTablesjkgrq.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablesjwgrq
            // 
            this.coldsPlanOrderL3DataTablesjwgrq.Caption = "sjwgrq";
            this.coldsPlanOrderL3DataTablesjwgrq.ColumnName = "sjwgrq";
            this.coldsPlanOrderL3DataTablesjwgrq.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablesjkssj
            // 
            this.coldsPlanOrderL3DataTablesjkssj.Caption = "sjkssj";
            this.coldsPlanOrderL3DataTablesjkssj.ColumnName = "sjkssj";
            this.coldsPlanOrderL3DataTablesjkssj.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablesjjssj
            // 
            this.coldsPlanOrderL3DataTablesjjssj.Caption = "sjjssj";
            this.coldsPlanOrderL3DataTablesjjssj.ColumnName = "sjjssj";
            this.coldsPlanOrderL3DataTablesjjssj.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablejhwgsl
            // 
            this.coldsPlanOrderL3DataTablejhwgsl.Caption = "jhwgsl";
            this.coldsPlanOrderL3DataTablejhwgsl.ColumnName = "jhwgsl";
            this.coldsPlanOrderL3DataTablejhwgsl.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablefjhsl
            // 
            this.coldsPlanOrderL3DataTablefjhsl.Caption = "fjhsl";
            this.coldsPlanOrderL3DataTablefjhsl.ColumnName = "fjhsl";
            this.coldsPlanOrderL3DataTablefjhsl.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablejldwid
            // 
            this.coldsPlanOrderL3DataTablejldwid.Caption = "jldwid";
            this.coldsPlanOrderL3DataTablejldwid.ColumnName = "jldwid";
            this.coldsPlanOrderL3DataTablejldwid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablefjlid
            // 
            this.coldsPlanOrderL3DataTablefjlid.Caption = "fjlid";
            this.coldsPlanOrderL3DataTablefjlid.ColumnName = "fjlid";
            this.coldsPlanOrderL3DataTablefjlid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablesjwgsl
            // 
            this.coldsPlanOrderL3DataTablesjwgsl.Caption = "sjwgsl";
            this.coldsPlanOrderL3DataTablesjwgsl.ColumnName = "sjwgsl";
            this.coldsPlanOrderL3DataTablesjwgsl.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablefwcsl
            // 
            this.coldsPlanOrderL3DataTablefwcsl.Caption = "fwcsl";
            this.coldsPlanOrderL3DataTablefwcsl.ColumnName = "fwcsl";
            this.coldsPlanOrderL3DataTablefwcsl.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezdy1
            // 
            this.coldsPlanOrderL3DataTablezdy1.Caption = "zdy1";
            this.coldsPlanOrderL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsPlanOrderL3DataTablezdy1.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezdy2
            // 
            this.coldsPlanOrderL3DataTablezdy2.Caption = "zdy2";
            this.coldsPlanOrderL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsPlanOrderL3DataTablezdy2.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezdy3
            // 
            this.coldsPlanOrderL3DataTablezdy3.Caption = "zdy3";
            this.coldsPlanOrderL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsPlanOrderL3DataTablezdy3.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezdy4
            // 
            this.coldsPlanOrderL3DataTablezdy4.Caption = "zdy4";
            this.coldsPlanOrderL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsPlanOrderL3DataTablezdy4.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezdy5
            // 
            this.coldsPlanOrderL3DataTablezdy5.Caption = "zdy5";
            this.coldsPlanOrderL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsPlanOrderL3DataTablezdy5.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezyx1
            // 
            this.coldsPlanOrderL3DataTablezyx1.Caption = "zyx1";
            this.coldsPlanOrderL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsPlanOrderL3DataTablezyx1.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezyx2
            // 
            this.coldsPlanOrderL3DataTablezyx2.Caption = "zyx2";
            this.coldsPlanOrderL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsPlanOrderL3DataTablezyx2.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezyx3
            // 
            this.coldsPlanOrderL3DataTablezyx3.Caption = "zyx3";
            this.coldsPlanOrderL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsPlanOrderL3DataTablezyx3.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezyx4
            // 
            this.coldsPlanOrderL3DataTablezyx4.Caption = "zyx4";
            this.coldsPlanOrderL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsPlanOrderL3DataTablezyx4.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezyx5
            // 
            this.coldsPlanOrderL3DataTablezyx5.Caption = "zyx5";
            this.coldsPlanOrderL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsPlanOrderL3DataTablezyx5.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablepk_corp
            // 
            this.coldsPlanOrderL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsPlanOrderL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsPlanOrderL3DataTablepk_corp.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablegcbm
            // 
            this.coldsPlanOrderL3DataTablegcbm.Caption = "gcbm";
            this.coldsPlanOrderL3DataTablegcbm.ColumnName = "gcbm";
            this.coldsPlanOrderL3DataTablegcbm.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablezdrid
            // 
            this.coldsPlanOrderL3DataTablezdrid.Caption = "zdrid";
            this.coldsPlanOrderL3DataTablezdrid.ColumnName = "zdrid";
            this.coldsPlanOrderL3DataTablezdrid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablepk_moid
            // 
            this.coldsPlanOrderL3DataTablepk_moid.Caption = "pk_moid";
            this.coldsPlanOrderL3DataTablepk_moid.ColumnName = "pk_moid";
            this.coldsPlanOrderL3DataTablepk_moid.Namespace = "";
            // 
            // coldsPlanOrderL3DataTablePlanID
            // 
            this.coldsPlanOrderL3DataTablePlanID.Caption = "PlanID";
            this.coldsPlanOrderL3DataTablePlanID.ColumnName = "PlanID";
            this.coldsPlanOrderL3DataTablePlanID.Namespace = "";
            // 
            // coldsPlanOrderL3DataTableNC_Confirm_Flag
            // 
            this.coldsPlanOrderL3DataTableNC_Confirm_Flag.Caption = "NC_Confirm_Flag";
            this.coldsPlanOrderL3DataTableNC_Confirm_Flag.ColumnName = "NC_Confirm_Flag";
            this.coldsPlanOrderL3DataTableNC_Confirm_Flag.Namespace = "";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton1.Text = "查询";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txbHeatID
            // 
            this.txbHeatID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbHeatID.Name = "txbHeatID";
            this.txbHeatID.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel4.Text = "炉号";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnUpdateSend,
            this.btnAddSend});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(669, 43);
            this.tSp1.TabIndex = 33;
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
            // btnUpdateSend
            // 
            this.btnUpdateSend.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSend.Image")));
            this.btnUpdateSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdateSend.Name = "btnUpdateSend";
            this.btnUpdateSend.Size = new System.Drawing.Size(125, 40);
            this.btnUpdateSend.Text = "Update类型补发";
            this.btnUpdateSend.Click += new System.EventHandler(this.btnUpdateSend_Click);
            // 
            // btnAddSend
            // 
            this.btnAddSend.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSend.Image")));
            this.btnAddSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSend.Name = "btnAddSend";
            this.btnAddSend.Size = new System.Drawing.Size(107, 40);
            this.btnAddSend.Text = "Add类型补发";
            this.btnAddSend.Click += new System.EventHandler(this.btnAddSend_Click);
            // 
            // dvPlanOrder
            // 
            this.dvPlanOrder.AllowUserToAddRows = false;
            this.dvPlanOrder.AutoGenerateColumns = false;
            this.dvPlanOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvPlanOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvPlanOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvPlanOrder.ColumnHeadersHeight = 20;
            this.dvPlanOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvPlanOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heatIDDataGridViewTextBoxColumn,
            this.flagDataGridViewTextBoxColumn,
            this.scddhDataGridViewTextBoxColumn,
            this.pkpoidDataGridViewTextBoxColumn,
            this.jhddhDataGridViewTextBoxColumn,
            this.wlbmidDataGridViewTextBoxColumn,
            this.pkproduceDataGridViewTextBoxColumn,
            this.invcodeDataGridViewTextBoxColumn,
            this.nvnameDataGridViewTextBoxColumn,
            this.pchDataGridViewTextBoxColumn,
            this.scbmidDataGridViewTextBoxColumn,
            this.gzzxidDataGridViewTextBoxColumn,
            this.gzzxbmDataGridViewTextBoxColumn,
            this.ksidDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.sfjjDataGridViewTextBoxColumn,
            this.yxjDataGridViewTextBoxColumn,
            this.bcidDataGridViewTextBoxColumn,
            this.bzidDataGridViewTextBoxColumn,
            this.jhkgrqDataGridViewTextBoxColumn,
            this.jhwgrqDataGridViewTextBoxColumn,
            this.jhkssjDataGridViewTextBoxColumn,
            this.jhjssjDataGridViewTextBoxColumn,
            this.sjkgrqDataGridViewTextBoxColumn,
            this.sjwgrqDataGridViewTextBoxColumn,
            this.sjkssjDataGridViewTextBoxColumn,
            this.sjjssjDataGridViewTextBoxColumn,
            this.jhwgslDataGridViewTextBoxColumn,
            this.fjhslDataGridViewTextBoxColumn,
            this.jldwidDataGridViewTextBoxColumn,
            this.fjlidDataGridViewTextBoxColumn,
            this.sjwgslDataGridViewTextBoxColumn,
            this.fwcslDataGridViewTextBoxColumn,
            this.zdy1DataGridViewTextBoxColumn,
            this.zdy2DataGridViewTextBoxColumn,
            this.zdy3DataGridViewTextBoxColumn,
            this.zdy4DataGridViewTextBoxColumn,
            this.zdy5DataGridViewTextBoxColumn,
            this.zyx1DataGridViewTextBoxColumn,
            this.zyx2DataGridViewTextBoxColumn,
            this.zyx3DataGridViewTextBoxColumn,
            this.zyx4DataGridViewTextBoxColumn,
            this.zyx5DataGridViewTextBoxColumn,
            this.pkcorpDataGridViewTextBoxColumn,
            this.gcbmDataGridViewTextBoxColumn,
            this.zdridDataGridViewTextBoxColumn,
            this.pkmoidDataGridViewTextBoxColumn,
            this.planIDDataGridViewTextBoxColumn,
            this.nCConfirmFlagDataGridViewTextBoxColumn});
            this.dvPlanOrder.DataSource = this.bsPlanOrder;
            this.dvPlanOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvPlanOrder.Location = new System.Drawing.Point(0, 68);
            this.dvPlanOrder.MultiSelect = false;
            this.dvPlanOrder.Name = "dvPlanOrder";
            this.dvPlanOrder.ReadOnly = true;
            this.dvPlanOrder.RowTemplate.Height = 23;
            this.dvPlanOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvPlanOrder.Size = new System.Drawing.Size(669, 283);
            this.dvPlanOrder.TabIndex = 36;
            this.dvPlanOrder.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvPlanOrder_DataError);
            // 
            // heatIDDataGridViewTextBoxColumn
            // 
            this.heatIDDataGridViewTextBoxColumn.DataPropertyName = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.HeaderText = "HeatID";
            this.heatIDDataGridViewTextBoxColumn.Name = "heatIDDataGridViewTextBoxColumn";
            this.heatIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.heatIDDataGridViewTextBoxColumn.Visible = false;
            this.heatIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewTextBoxColumn.HeaderText = "Flag";
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.ReadOnly = true;
            this.flagDataGridViewTextBoxColumn.Visible = false;
            this.flagDataGridViewTextBoxColumn.Width = 54;
            // 
            // scddhDataGridViewTextBoxColumn
            // 
            this.scddhDataGridViewTextBoxColumn.DataPropertyName = "scddh";
            this.scddhDataGridViewTextBoxColumn.HeaderText = "生产订单号";
            this.scddhDataGridViewTextBoxColumn.Name = "scddhDataGridViewTextBoxColumn";
            this.scddhDataGridViewTextBoxColumn.ReadOnly = true;
            this.scddhDataGridViewTextBoxColumn.Width = 90;
            // 
            // pkpoidDataGridViewTextBoxColumn
            // 
            this.pkpoidDataGridViewTextBoxColumn.DataPropertyName = "pk_poid";
            this.pkpoidDataGridViewTextBoxColumn.HeaderText = "计划订单号主键";
            this.pkpoidDataGridViewTextBoxColumn.Name = "pkpoidDataGridViewTextBoxColumn";
            this.pkpoidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkpoidDataGridViewTextBoxColumn.Width = 114;
            // 
            // jhddhDataGridViewTextBoxColumn
            // 
            this.jhddhDataGridViewTextBoxColumn.DataPropertyName = "jhddh";
            this.jhddhDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.jhddhDataGridViewTextBoxColumn.Name = "jhddhDataGridViewTextBoxColumn";
            this.jhddhDataGridViewTextBoxColumn.ReadOnly = true;
            this.jhddhDataGridViewTextBoxColumn.Width = 90;
            // 
            // wlbmidDataGridViewTextBoxColumn
            // 
            this.wlbmidDataGridViewTextBoxColumn.DataPropertyName = "wlbmid";
            this.wlbmidDataGridViewTextBoxColumn.DataSource = this.dsMaterialID;
            this.wlbmidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Material_Name";
            this.wlbmidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.wlbmidDataGridViewTextBoxColumn.HeaderText = "产品";
            this.wlbmidDataGridViewTextBoxColumn.Name = "wlbmidDataGridViewTextBoxColumn";
            this.wlbmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.wlbmidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wlbmidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.wlbmidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Material_Bas";
            this.wlbmidDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsMaterialID
            // 
            this.dsMaterialID.AutoLoad = true;
            this.dsMaterialID.AutoSubscribe = false;
            this.dsMaterialID.DataSetName = "L3DataSet";
            this.dsMaterialID.DeleteMethod = "";
            this.dsMaterialID.InsertMethod = "";
            this.dsMaterialID.L3DataAdapter = this.Adapter;
            this.dsMaterialID.LoadEvent = "";
            this.dsMaterialID.LoadTrigger = null;
            this.dsMaterialID.RefreshValve = 1000;
            this.dsMaterialID.SourceCommand = null;
            this.dsMaterialID.SourceCondition = " SUBSTR (material_code, 1, 1) = \'1\'  OR SUBSTR (material_code, 1, 1) = \'5\'  OR SU" +
                "BSTR (material_code, 1, 1) = \'6\'";
            this.dsMaterialID.SourceMethod = "";
            this.dsMaterialID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsMaterialID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Material_Base_Infor";
            this.dsMaterialID.SubscribeTarget = "";
            this.dsMaterialID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMaterialID});
            this.dsMaterialID.UpdateEvent = "";
            this.dsMaterialID.UpdateMethod = "";
            this.dsMaterialID.UpdateTrigger = null;
            // 
            // schemadsMaterialID
            // 
            this.schemadsMaterialID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMaterialIDL3DataTablePk_Material_Bas,
            this.coldsMaterialIDL3DataTableMaterial_Name});
            this.schemadsMaterialID.TableName = "L3DataTable";
            // 
            // coldsMaterialIDL3DataTablePk_Material_Bas
            // 
            this.coldsMaterialIDL3DataTablePk_Material_Bas.Caption = "Pk_Material_Bas";
            this.coldsMaterialIDL3DataTablePk_Material_Bas.ColumnName = "Pk_Material_Bas";
            this.coldsMaterialIDL3DataTablePk_Material_Bas.Namespace = "";
            // 
            // coldsMaterialIDL3DataTableMaterial_Name
            // 
            this.coldsMaterialIDL3DataTableMaterial_Name.Caption = "Material_Name";
            this.coldsMaterialIDL3DataTableMaterial_Name.ColumnName = "Material_Name";
            this.coldsMaterialIDL3DataTableMaterial_Name.Namespace = "";
            // 
            // pkproduceDataGridViewTextBoxColumn
            // 
            this.pkproduceDataGridViewTextBoxColumn.DataPropertyName = "pk_produce";
            this.pkproduceDataGridViewTextBoxColumn.HeaderText = "产品生产档案";
            this.pkproduceDataGridViewTextBoxColumn.Name = "pkproduceDataGridViewTextBoxColumn";
            this.pkproduceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkproduceDataGridViewTextBoxColumn.Width = 102;
            // 
            // invcodeDataGridViewTextBoxColumn
            // 
            this.invcodeDataGridViewTextBoxColumn.DataPropertyName = "invcode";
            this.invcodeDataGridViewTextBoxColumn.HeaderText = "物料编码";
            this.invcodeDataGridViewTextBoxColumn.Name = "invcodeDataGridViewTextBoxColumn";
            this.invcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.invcodeDataGridViewTextBoxColumn.Width = 78;
            // 
            // nvnameDataGridViewTextBoxColumn
            // 
            this.nvnameDataGridViewTextBoxColumn.DataPropertyName = "nvname";
            this.nvnameDataGridViewTextBoxColumn.HeaderText = "物料名称";
            this.nvnameDataGridViewTextBoxColumn.Name = "nvnameDataGridViewTextBoxColumn";
            this.nvnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nvnameDataGridViewTextBoxColumn.Width = 78;
            // 
            // pchDataGridViewTextBoxColumn
            // 
            this.pchDataGridViewTextBoxColumn.DataPropertyName = "pch";
            this.pchDataGridViewTextBoxColumn.HeaderText = "批次号";
            this.pchDataGridViewTextBoxColumn.Name = "pchDataGridViewTextBoxColumn";
            this.pchDataGridViewTextBoxColumn.ReadOnly = true;
            this.pchDataGridViewTextBoxColumn.Width = 66;
            // 
            // scbmidDataGridViewTextBoxColumn
            // 
            this.scbmidDataGridViewTextBoxColumn.DataPropertyName = "scbmid";
            this.scbmidDataGridViewTextBoxColumn.DataSource = this.dsDepartment;
            this.scbmidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Department_Code";
            this.scbmidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.scbmidDataGridViewTextBoxColumn.HeaderText = "生产部门";
            this.scbmidDataGridViewTextBoxColumn.Name = "scbmidDataGridViewTextBoxColumn";
            this.scbmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.scbmidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.scbmidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.scbmidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Department";
            this.scbmidDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsDepartment
            // 
            this.dsDepartment.AutoLoad = true;
            this.dsDepartment.AutoSubscribe = false;
            this.dsDepartment.DataSetName = "L3DataSet";
            this.dsDepartment.DeleteMethod = "";
            this.dsDepartment.InsertMethod = "";
            this.dsDepartment.L3DataAdapter = this.Adapter;
            this.dsDepartment.LoadEvent = "";
            this.dsDepartment.LoadTrigger = null;
            this.dsDepartment.RefreshValve = 1000;
            this.dsDepartment.SourceCommand = null;
            this.dsDepartment.SourceCondition = "";
            this.dsDepartment.SourceMethod = "";
            this.dsDepartment.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsDepartment.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Department_Infor";
            this.dsDepartment.SubscribeTarget = "";
            this.dsDepartment.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsDepartment});
            this.dsDepartment.UpdateEvent = "";
            this.dsDepartment.UpdateMethod = "";
            this.dsDepartment.UpdateTrigger = null;
            // 
            // schemadsDepartment
            // 
            this.schemadsDepartment.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsDepartmentL3DataTablePk_Department,
            this.coldsDepartmentL3DataTableDepartment_Code});
            this.schemadsDepartment.TableName = "L3DataTable";
            // 
            // coldsDepartmentL3DataTablePk_Department
            // 
            this.coldsDepartmentL3DataTablePk_Department.Caption = "Pk_Department";
            this.coldsDepartmentL3DataTablePk_Department.ColumnName = "Pk_Department";
            this.coldsDepartmentL3DataTablePk_Department.Namespace = "";
            // 
            // coldsDepartmentL3DataTableDepartment_Code
            // 
            this.coldsDepartmentL3DataTableDepartment_Code.Caption = "Department_Code";
            this.coldsDepartmentL3DataTableDepartment_Code.ColumnName = "Department_Code";
            this.coldsDepartmentL3DataTableDepartment_Code.Namespace = "";
            // 
            // gzzxidDataGridViewTextBoxColumn
            // 
            this.gzzxidDataGridViewTextBoxColumn.DataPropertyName = "gzzxid";
            this.gzzxidDataGridViewTextBoxColumn.DataSource = this.dsWorkCenter;
            this.gzzxidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Center_Code";
            this.gzzxidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.gzzxidDataGridViewTextBoxColumn.HeaderText = "工作中心";
            this.gzzxidDataGridViewTextBoxColumn.Name = "gzzxidDataGridViewTextBoxColumn";
            this.gzzxidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gzzxidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gzzxidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gzzxidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Center";
            this.gzzxidDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsWorkCenter
            // 
            this.dsWorkCenter.AutoLoad = true;
            this.dsWorkCenter.AutoSubscribe = false;
            this.dsWorkCenter.DataSetName = "L3DataSet";
            this.dsWorkCenter.DeleteMethod = "";
            this.dsWorkCenter.InsertMethod = "";
            this.dsWorkCenter.L3DataAdapter = this.Adapter;
            this.dsWorkCenter.LoadEvent = "";
            this.dsWorkCenter.LoadTrigger = null;
            this.dsWorkCenter.RefreshValve = 1000;
            this.dsWorkCenter.SourceCommand = null;
            this.dsWorkCenter.SourceCondition = "";
            this.dsWorkCenter.SourceMethod = "";
            this.dsWorkCenter.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsWorkCenter.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Prod_Center_Infor";
            this.dsWorkCenter.SubscribeTarget = "";
            this.dsWorkCenter.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsWorkCenter});
            this.dsWorkCenter.UpdateEvent = "";
            this.dsWorkCenter.UpdateMethod = "";
            this.dsWorkCenter.UpdateTrigger = null;
            // 
            // schemadsWorkCenter
            // 
            this.schemadsWorkCenter.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsWorkCenterL3DataTablePk_Center,
            this.coldsWorkCenterL3DataTableCenter_Code});
            this.schemadsWorkCenter.TableName = "L3DataTable";
            // 
            // coldsWorkCenterL3DataTablePk_Center
            // 
            this.coldsWorkCenterL3DataTablePk_Center.Caption = "Pk_Center";
            this.coldsWorkCenterL3DataTablePk_Center.ColumnName = "Pk_Center";
            this.coldsWorkCenterL3DataTablePk_Center.Namespace = "";
            // 
            // coldsWorkCenterL3DataTableCenter_Code
            // 
            this.coldsWorkCenterL3DataTableCenter_Code.Caption = "Center_Code";
            this.coldsWorkCenterL3DataTableCenter_Code.ColumnName = "Center_Code";
            this.coldsWorkCenterL3DataTableCenter_Code.Namespace = "";
            // 
            // gzzxbmDataGridViewTextBoxColumn
            // 
            this.gzzxbmDataGridViewTextBoxColumn.DataPropertyName = "gzzxbm";
            this.gzzxbmDataGridViewTextBoxColumn.HeaderText = "工作中心编码";
            this.gzzxbmDataGridViewTextBoxColumn.Name = "gzzxbmDataGridViewTextBoxColumn";
            this.gzzxbmDataGridViewTextBoxColumn.ReadOnly = true;
            this.gzzxbmDataGridViewTextBoxColumn.Width = 102;
            // 
            // ksidDataGridViewTextBoxColumn
            // 
            this.ksidDataGridViewTextBoxColumn.DataPropertyName = "ksid";
            this.ksidDataGridViewTextBoxColumn.HeaderText = "客户";
            this.ksidDataGridViewTextBoxColumn.Name = "ksidDataGridViewTextBoxColumn";
            this.ksidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ksidDataGridViewTextBoxColumn.Width = 54;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "备注";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoDataGridViewTextBoxColumn.Width = 54;
            // 
            // sfjjDataGridViewTextBoxColumn
            // 
            this.sfjjDataGridViewTextBoxColumn.DataPropertyName = "sfjj";
            this.sfjjDataGridViewTextBoxColumn.HeaderText = "是否加急";
            this.sfjjDataGridViewTextBoxColumn.Name = "sfjjDataGridViewTextBoxColumn";
            this.sfjjDataGridViewTextBoxColumn.ReadOnly = true;
            this.sfjjDataGridViewTextBoxColumn.Width = 78;
            // 
            // yxjDataGridViewTextBoxColumn
            // 
            this.yxjDataGridViewTextBoxColumn.DataPropertyName = "yxj";
            this.yxjDataGridViewTextBoxColumn.HeaderText = "优先级";
            this.yxjDataGridViewTextBoxColumn.Name = "yxjDataGridViewTextBoxColumn";
            this.yxjDataGridViewTextBoxColumn.ReadOnly = true;
            this.yxjDataGridViewTextBoxColumn.Width = 66;
            // 
            // bcidDataGridViewTextBoxColumn
            // 
            this.bcidDataGridViewTextBoxColumn.DataPropertyName = "bcid";
            this.bcidDataGridViewTextBoxColumn.DataSource = this.dsShift;
            this.bcidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Shift_Name";
            this.bcidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bcidDataGridViewTextBoxColumn.HeaderText = "班次";
            this.bcidDataGridViewTextBoxColumn.Name = "bcidDataGridViewTextBoxColumn";
            this.bcidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bcidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bcidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bcidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Shift";
            this.bcidDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsShift
            // 
            this.dsShift.AutoLoad = true;
            this.dsShift.AutoSubscribe = false;
            this.dsShift.DataSetName = "L3DataSet";
            this.dsShift.DeleteMethod = "";
            this.dsShift.InsertMethod = "";
            this.dsShift.L3DataAdapter = this.Adapter;
            this.dsShift.LoadEvent = "";
            this.dsShift.LoadTrigger = null;
            this.dsShift.RefreshValve = 1000;
            this.dsShift.SourceCommand = null;
            this.dsShift.SourceCondition = "";
            this.dsShift.SourceMethod = "";
            this.dsShift.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShift.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Shift_Infor";
            this.dsShift.SubscribeTarget = "";
            this.dsShift.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShift});
            this.dsShift.UpdateEvent = "";
            this.dsShift.UpdateMethod = "";
            this.dsShift.UpdateTrigger = null;
            // 
            // schemadsShift
            // 
            this.schemadsShift.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftL3DataTablePk_Shift,
            this.coldsShiftL3DataTableShift_Name});
            this.schemadsShift.TableName = "L3DataTable";
            // 
            // coldsShiftL3DataTablePk_Shift
            // 
            this.coldsShiftL3DataTablePk_Shift.Caption = "Pk_Shift";
            this.coldsShiftL3DataTablePk_Shift.ColumnName = "Pk_Shift";
            this.coldsShiftL3DataTablePk_Shift.Namespace = "";
            // 
            // coldsShiftL3DataTableShift_Name
            // 
            this.coldsShiftL3DataTableShift_Name.Caption = "Shift_Name";
            this.coldsShiftL3DataTableShift_Name.ColumnName = "Shift_Name";
            this.coldsShiftL3DataTableShift_Name.Namespace = "";
            // 
            // bzidDataGridViewTextBoxColumn
            // 
            this.bzidDataGridViewTextBoxColumn.DataPropertyName = "bzid";
            this.bzidDataGridViewTextBoxColumn.DataSource = this.dsGroup;
            this.bzidDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Team_Name";
            this.bzidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.bzidDataGridViewTextBoxColumn.HeaderText = "班组";
            this.bzidDataGridViewTextBoxColumn.Name = "bzidDataGridViewTextBoxColumn";
            this.bzidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bzidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bzidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bzidDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Pk_Team";
            this.bzidDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsGroup
            // 
            this.dsGroup.AutoLoad = true;
            this.dsGroup.AutoSubscribe = false;
            this.dsGroup.DataSetName = "L3DataSet";
            this.dsGroup.DeleteMethod = "";
            this.dsGroup.InsertMethod = "";
            this.dsGroup.L3DataAdapter = this.Adapter;
            this.dsGroup.LoadEvent = "";
            this.dsGroup.LoadTrigger = null;
            this.dsGroup.RefreshValve = 1000;
            this.dsGroup.SourceCommand = null;
            this.dsGroup.SourceCondition = "";
            this.dsGroup.SourceMethod = "";
            this.dsGroup.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsGroup.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_Team_Infor";
            this.dsGroup.SubscribeTarget = "";
            this.dsGroup.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsGroup});
            this.dsGroup.UpdateEvent = "";
            this.dsGroup.UpdateMethod = "";
            this.dsGroup.UpdateTrigger = null;
            // 
            // schemadsGroup
            // 
            this.schemadsGroup.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsGroupL3DataTablePk_Team,
            this.coldsGroupL3DataTableTeam_Name});
            this.schemadsGroup.TableName = "L3DataTable";
            // 
            // coldsGroupL3DataTablePk_Team
            // 
            this.coldsGroupL3DataTablePk_Team.Caption = "Pk_Team";
            this.coldsGroupL3DataTablePk_Team.ColumnName = "Pk_Team";
            this.coldsGroupL3DataTablePk_Team.Namespace = "";
            // 
            // coldsGroupL3DataTableTeam_Name
            // 
            this.coldsGroupL3DataTableTeam_Name.Caption = "Team_Name";
            this.coldsGroupL3DataTableTeam_Name.ColumnName = "Team_Name";
            this.coldsGroupL3DataTableTeam_Name.Namespace = "";
            // 
            // jhkgrqDataGridViewTextBoxColumn
            // 
            this.jhkgrqDataGridViewTextBoxColumn.DataPropertyName = "jhkgrq";
            this.jhkgrqDataGridViewTextBoxColumn.HeaderText = "计划开工日期";
            this.jhkgrqDataGridViewTextBoxColumn.Name = "jhkgrqDataGridViewTextBoxColumn";
            this.jhkgrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.jhkgrqDataGridViewTextBoxColumn.Width = 102;
            // 
            // jhwgrqDataGridViewTextBoxColumn
            // 
            this.jhwgrqDataGridViewTextBoxColumn.DataPropertyName = "jhwgrq";
            this.jhwgrqDataGridViewTextBoxColumn.HeaderText = "计划完工日期";
            this.jhwgrqDataGridViewTextBoxColumn.Name = "jhwgrqDataGridViewTextBoxColumn";
            this.jhwgrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.jhwgrqDataGridViewTextBoxColumn.Width = 102;
            // 
            // jhkssjDataGridViewTextBoxColumn
            // 
            this.jhkssjDataGridViewTextBoxColumn.DataPropertyName = "jhkssj";
            this.jhkssjDataGridViewTextBoxColumn.HeaderText = "计划开始时间";
            this.jhkssjDataGridViewTextBoxColumn.Name = "jhkssjDataGridViewTextBoxColumn";
            this.jhkssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.jhkssjDataGridViewTextBoxColumn.Width = 102;
            // 
            // jhjssjDataGridViewTextBoxColumn
            // 
            this.jhjssjDataGridViewTextBoxColumn.DataPropertyName = "jhjssj";
            this.jhjssjDataGridViewTextBoxColumn.HeaderText = "计划结束时间";
            this.jhjssjDataGridViewTextBoxColumn.Name = "jhjssjDataGridViewTextBoxColumn";
            this.jhjssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.jhjssjDataGridViewTextBoxColumn.Width = 102;
            // 
            // sjkgrqDataGridViewTextBoxColumn
            // 
            this.sjkgrqDataGridViewTextBoxColumn.DataPropertyName = "sjkgrq";
            this.sjkgrqDataGridViewTextBoxColumn.HeaderText = "实际开工日期";
            this.sjkgrqDataGridViewTextBoxColumn.Name = "sjkgrqDataGridViewTextBoxColumn";
            this.sjkgrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.sjkgrqDataGridViewTextBoxColumn.Width = 102;
            // 
            // sjwgrqDataGridViewTextBoxColumn
            // 
            this.sjwgrqDataGridViewTextBoxColumn.DataPropertyName = "sjwgrq";
            this.sjwgrqDataGridViewTextBoxColumn.HeaderText = "实际完工日期";
            this.sjwgrqDataGridViewTextBoxColumn.Name = "sjwgrqDataGridViewTextBoxColumn";
            this.sjwgrqDataGridViewTextBoxColumn.ReadOnly = true;
            this.sjwgrqDataGridViewTextBoxColumn.Width = 102;
            // 
            // sjkssjDataGridViewTextBoxColumn
            // 
            this.sjkssjDataGridViewTextBoxColumn.DataPropertyName = "sjkssj";
            this.sjkssjDataGridViewTextBoxColumn.HeaderText = "实际开始时间";
            this.sjkssjDataGridViewTextBoxColumn.Name = "sjkssjDataGridViewTextBoxColumn";
            this.sjkssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.sjkssjDataGridViewTextBoxColumn.Width = 102;
            // 
            // sjjssjDataGridViewTextBoxColumn
            // 
            this.sjjssjDataGridViewTextBoxColumn.DataPropertyName = "sjjssj";
            this.sjjssjDataGridViewTextBoxColumn.HeaderText = "实际结束时间";
            this.sjjssjDataGridViewTextBoxColumn.Name = "sjjssjDataGridViewTextBoxColumn";
            this.sjjssjDataGridViewTextBoxColumn.ReadOnly = true;
            this.sjjssjDataGridViewTextBoxColumn.Width = 102;
            // 
            // jhwgslDataGridViewTextBoxColumn
            // 
            this.jhwgslDataGridViewTextBoxColumn.DataPropertyName = "jhwgsl";
            this.jhwgslDataGridViewTextBoxColumn.HeaderText = "计划生产数量";
            this.jhwgslDataGridViewTextBoxColumn.Name = "jhwgslDataGridViewTextBoxColumn";
            this.jhwgslDataGridViewTextBoxColumn.ReadOnly = true;
            this.jhwgslDataGridViewTextBoxColumn.Width = 102;
            // 
            // fjhslDataGridViewTextBoxColumn
            // 
            this.fjhslDataGridViewTextBoxColumn.DataPropertyName = "fjhsl";
            this.fjhslDataGridViewTextBoxColumn.HeaderText = "辅计划数量";
            this.fjhslDataGridViewTextBoxColumn.Name = "fjhslDataGridViewTextBoxColumn";
            this.fjhslDataGridViewTextBoxColumn.ReadOnly = true;
            this.fjhslDataGridViewTextBoxColumn.Width = 90;
            // 
            // jldwidDataGridViewTextBoxColumn
            // 
            this.jldwidDataGridViewTextBoxColumn.DataPropertyName = "jldwid";
            this.jldwidDataGridViewTextBoxColumn.HeaderText = "计量单位ID";
            this.jldwidDataGridViewTextBoxColumn.Name = "jldwidDataGridViewTextBoxColumn";
            this.jldwidDataGridViewTextBoxColumn.ReadOnly = true;
            this.jldwidDataGridViewTextBoxColumn.Width = 90;
            // 
            // fjlidDataGridViewTextBoxColumn
            // 
            this.fjlidDataGridViewTextBoxColumn.DataPropertyName = "fjlid";
            this.fjlidDataGridViewTextBoxColumn.HeaderText = "辅计量单位ID";
            this.fjlidDataGridViewTextBoxColumn.Name = "fjlidDataGridViewTextBoxColumn";
            this.fjlidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fjlidDataGridViewTextBoxColumn.Width = 102;
            // 
            // sjwgslDataGridViewTextBoxColumn
            // 
            this.sjwgslDataGridViewTextBoxColumn.DataPropertyName = "sjwgsl";
            this.sjwgslDataGridViewTextBoxColumn.HeaderText = "实际生产数量";
            this.sjwgslDataGridViewTextBoxColumn.Name = "sjwgslDataGridViewTextBoxColumn";
            this.sjwgslDataGridViewTextBoxColumn.ReadOnly = true;
            this.sjwgslDataGridViewTextBoxColumn.Width = 102;
            // 
            // fwcslDataGridViewTextBoxColumn
            // 
            this.fwcslDataGridViewTextBoxColumn.DataPropertyName = "fwcsl";
            this.fwcslDataGridViewTextBoxColumn.HeaderText = "辅完工数量";
            this.fwcslDataGridViewTextBoxColumn.Name = "fwcslDataGridViewTextBoxColumn";
            this.fwcslDataGridViewTextBoxColumn.ReadOnly = true;
            this.fwcslDataGridViewTextBoxColumn.Width = 90;
            // 
            // zdy1DataGridViewTextBoxColumn
            // 
            this.zdy1DataGridViewTextBoxColumn.DataPropertyName = "zdy1";
            this.zdy1DataGridViewTextBoxColumn.HeaderText = "自定义1";
            this.zdy1DataGridViewTextBoxColumn.Name = "zdy1DataGridViewTextBoxColumn";
            this.zdy1DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy1DataGridViewTextBoxColumn.Width = 72;
            // 
            // zdy2DataGridViewTextBoxColumn
            // 
            this.zdy2DataGridViewTextBoxColumn.DataPropertyName = "zdy2";
            this.zdy2DataGridViewTextBoxColumn.HeaderText = "自定义2";
            this.zdy2DataGridViewTextBoxColumn.Name = "zdy2DataGridViewTextBoxColumn";
            this.zdy2DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy2DataGridViewTextBoxColumn.Width = 72;
            // 
            // zdy3DataGridViewTextBoxColumn
            // 
            this.zdy3DataGridViewTextBoxColumn.DataPropertyName = "zdy3";
            this.zdy3DataGridViewTextBoxColumn.HeaderText = "自定义3";
            this.zdy3DataGridViewTextBoxColumn.Name = "zdy3DataGridViewTextBoxColumn";
            this.zdy3DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy3DataGridViewTextBoxColumn.Width = 72;
            // 
            // zdy4DataGridViewTextBoxColumn
            // 
            this.zdy4DataGridViewTextBoxColumn.DataPropertyName = "zdy4";
            this.zdy4DataGridViewTextBoxColumn.HeaderText = "自定义4";
            this.zdy4DataGridViewTextBoxColumn.Name = "zdy4DataGridViewTextBoxColumn";
            this.zdy4DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy4DataGridViewTextBoxColumn.Width = 72;
            // 
            // zdy5DataGridViewTextBoxColumn
            // 
            this.zdy5DataGridViewTextBoxColumn.DataPropertyName = "zdy5";
            this.zdy5DataGridViewTextBoxColumn.HeaderText = "自定义5";
            this.zdy5DataGridViewTextBoxColumn.Name = "zdy5DataGridViewTextBoxColumn";
            this.zdy5DataGridViewTextBoxColumn.ReadOnly = true;
            this.zdy5DataGridViewTextBoxColumn.Width = 72;
            // 
            // zyx1DataGridViewTextBoxColumn
            // 
            this.zyx1DataGridViewTextBoxColumn.DataPropertyName = "zyx1";
            this.zyx1DataGridViewTextBoxColumn.HeaderText = "产品标准";
            this.zyx1DataGridViewTextBoxColumn.Name = "zyx1DataGridViewTextBoxColumn";
            this.zyx1DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx1DataGridViewTextBoxColumn.Width = 78;
            // 
            // zyx2DataGridViewTextBoxColumn
            // 
            this.zyx2DataGridViewTextBoxColumn.DataPropertyName = "zyx2";
            this.zyx2DataGridViewTextBoxColumn.HeaderText = "技术要求";
            this.zyx2DataGridViewTextBoxColumn.Name = "zyx2DataGridViewTextBoxColumn";
            this.zyx2DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx2DataGridViewTextBoxColumn.Width = 78;
            // 
            // zyx3DataGridViewTextBoxColumn
            // 
            this.zyx3DataGridViewTextBoxColumn.DataPropertyName = "zyx3";
            this.zyx3DataGridViewTextBoxColumn.HeaderText = "自由项3";
            this.zyx3DataGridViewTextBoxColumn.Name = "zyx3DataGridViewTextBoxColumn";
            this.zyx3DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx3DataGridViewTextBoxColumn.Width = 72;
            // 
            // zyx4DataGridViewTextBoxColumn
            // 
            this.zyx4DataGridViewTextBoxColumn.DataPropertyName = "zyx4";
            this.zyx4DataGridViewTextBoxColumn.HeaderText = "由项4";
            this.zyx4DataGridViewTextBoxColumn.Name = "zyx4DataGridViewTextBoxColumn";
            this.zyx4DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx4DataGridViewTextBoxColumn.Width = 60;
            // 
            // zyx5DataGridViewTextBoxColumn
            // 
            this.zyx5DataGridViewTextBoxColumn.DataPropertyName = "zyx5";
            this.zyx5DataGridViewTextBoxColumn.HeaderText = "自由项5";
            this.zyx5DataGridViewTextBoxColumn.Name = "zyx5DataGridViewTextBoxColumn";
            this.zyx5DataGridViewTextBoxColumn.ReadOnly = true;
            this.zyx5DataGridViewTextBoxColumn.Width = 72;
            // 
            // pkcorpDataGridViewTextBoxColumn
            // 
            this.pkcorpDataGridViewTextBoxColumn.DataPropertyName = "pk_corp";
            this.pkcorpDataGridViewTextBoxColumn.HeaderText = "公司";
            this.pkcorpDataGridViewTextBoxColumn.Name = "pkcorpDataGridViewTextBoxColumn";
            this.pkcorpDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkcorpDataGridViewTextBoxColumn.Width = 54;
            // 
            // gcbmDataGridViewTextBoxColumn
            // 
            this.gcbmDataGridViewTextBoxColumn.DataPropertyName = "gcbm";
            this.gcbmDataGridViewTextBoxColumn.HeaderText = "工厂";
            this.gcbmDataGridViewTextBoxColumn.Name = "gcbmDataGridViewTextBoxColumn";
            this.gcbmDataGridViewTextBoxColumn.ReadOnly = true;
            this.gcbmDataGridViewTextBoxColumn.Width = 54;
            // 
            // zdridDataGridViewTextBoxColumn
            // 
            this.zdridDataGridViewTextBoxColumn.DataPropertyName = "zdrid";
            this.zdridDataGridViewTextBoxColumn.HeaderText = "操作员工号";
            this.zdridDataGridViewTextBoxColumn.Name = "zdridDataGridViewTextBoxColumn";
            this.zdridDataGridViewTextBoxColumn.ReadOnly = true;
            this.zdridDataGridViewTextBoxColumn.Width = 90;
            // 
            // pkmoidDataGridViewTextBoxColumn
            // 
            this.pkmoidDataGridViewTextBoxColumn.DataPropertyName = "pk_moid";
            this.pkmoidDataGridViewTextBoxColumn.HeaderText = "生产订单主键";
            this.pkmoidDataGridViewTextBoxColumn.Name = "pkmoidDataGridViewTextBoxColumn";
            this.pkmoidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkmoidDataGridViewTextBoxColumn.Width = 102;
            // 
            // planIDDataGridViewTextBoxColumn
            // 
            this.planIDDataGridViewTextBoxColumn.DataPropertyName = "PlanID";
            this.planIDDataGridViewTextBoxColumn.HeaderText = "计划号";
            this.planIDDataGridViewTextBoxColumn.Name = "planIDDataGridViewTextBoxColumn";
            this.planIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.planIDDataGridViewTextBoxColumn.Visible = false;
            this.planIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // nCConfirmFlagDataGridViewTextBoxColumn
            // 
            this.nCConfirmFlagDataGridViewTextBoxColumn.DataPropertyName = "NC_Confirm_Flag";
            this.nCConfirmFlagDataGridViewTextBoxColumn.HeaderText = "NC确认标志";
            this.nCConfirmFlagDataGridViewTextBoxColumn.Name = "nCConfirmFlagDataGridViewTextBoxColumn";
            this.nCConfirmFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.nCConfirmFlagDataGridViewTextBoxColumn.Visible = false;
            this.nCConfirmFlagDataGridViewTextBoxColumn.Width = 90;
            // 
            // cmdPlanOrder
            // 
            this.cmdPlanOrder.Adapter = this.Adapter;
            this.cmdPlanOrder.MergeReturnTarget = false;
            this.cmdPlanOrder.Method = "SendPlanInfor";
            this.cmdPlanOrder.Object = "XGMESLogic\\BaseDataMag\\CBaseData_Mag\\BaseData_Mag";
            this.cmdPlanOrder.Parameters.Add(this.l3CommandParameter3);
            this.cmdPlanOrder.ReturnTarget = this.dsPlanOrder;
            this.cmdPlanOrder.ReturnTargetProperty = null;
            this.cmdPlanOrder.Trigger = null;
            this.cmdPlanOrder.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = null;
            this.l3CommandParameter3.SourceProperty = null;
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
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
            // dsLog
            // 
            this.dsLog.AutoLoad = true;
            this.dsLog.AutoSubscribe = false;
            this.dsLog.DataSetName = "L3DataSet";
            this.dsLog.DeleteMethod = "";
            this.dsLog.InsertMethod = "";
            this.dsLog.L3DataAdapter = null;
            this.dsLog.LoadEvent = "";
            this.dsLog.LoadTrigger = null;
            this.dsLog.RefreshValve = 1000;
            this.dsLog.SourceCommand = null;
            this.dsLog.SourceCondition = "";
            this.dsLog.SourceMethod = "";
            this.dsLog.SourceType = AppSvrHMI.L3DataSetSourceType.DataSet;
            this.dsLog.SourceURI = "";
            this.dsLog.SubscribeTarget = null;
            this.dsLog.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLog});
            this.dsLog.UpdateEvent = "";
            this.dsLog.UpdateMethod = "";
            this.dsLog.UpdateTrigger = null;
            // 
            // schemadsLog
            // 
            this.schemadsLog.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLogL3DataTableGUID,
            this.coldsLogL3DataTableName,
            this.coldsLogL3DataTableHeatID,
            this.coldsLogL3DataTableBillType,
            this.coldsLogL3DataTableFlag,
            this.coldsLogL3DataTableRemark,
            this.coldsLogL3DataTableCreateTime,
            this.coldsLogL3DataTableOther1,
            this.coldsLogL3DataTableOther2,
            this.coldsLogL3DataTableOther3});
            this.schemadsLog.TableName = "L3DataTable";
            // 
            // coldsLogL3DataTableGUID
            // 
            this.coldsLogL3DataTableGUID.Caption = "GUID";
            this.coldsLogL3DataTableGUID.ColumnName = "GUID";
            this.coldsLogL3DataTableGUID.Namespace = "";
            // 
            // coldsLogL3DataTableName
            // 
            this.coldsLogL3DataTableName.Caption = "Name";
            this.coldsLogL3DataTableName.ColumnName = "Name";
            this.coldsLogL3DataTableName.Namespace = "";
            // 
            // coldsLogL3DataTableHeatID
            // 
            this.coldsLogL3DataTableHeatID.Caption = "HeatID";
            this.coldsLogL3DataTableHeatID.ColumnName = "HeatID";
            this.coldsLogL3DataTableHeatID.Namespace = "";
            // 
            // coldsLogL3DataTableBillType
            // 
            this.coldsLogL3DataTableBillType.Caption = "BillType";
            this.coldsLogL3DataTableBillType.ColumnName = "BillType";
            this.coldsLogL3DataTableBillType.Namespace = "";
            // 
            // coldsLogL3DataTableFlag
            // 
            this.coldsLogL3DataTableFlag.Caption = "Flag";
            this.coldsLogL3DataTableFlag.ColumnName = "Flag";
            this.coldsLogL3DataTableFlag.Namespace = "";
            // 
            // coldsLogL3DataTableRemark
            // 
            this.coldsLogL3DataTableRemark.Caption = "Remark";
            this.coldsLogL3DataTableRemark.ColumnName = "Remark";
            this.coldsLogL3DataTableRemark.Namespace = "";
            // 
            // coldsLogL3DataTableCreateTime
            // 
            this.coldsLogL3DataTableCreateTime.Caption = "CreateTime";
            this.coldsLogL3DataTableCreateTime.ColumnName = "CreateTime";
            this.coldsLogL3DataTableCreateTime.DataType = typeof(System.DateTime);
            this.coldsLogL3DataTableCreateTime.Namespace = "";
            // 
            // coldsLogL3DataTableOther1
            // 
            this.coldsLogL3DataTableOther1.Caption = "Other1";
            this.coldsLogL3DataTableOther1.ColumnName = "Other1";
            this.coldsLogL3DataTableOther1.Namespace = "";
            // 
            // coldsLogL3DataTableOther2
            // 
            this.coldsLogL3DataTableOther2.Caption = "Other2";
            this.coldsLogL3DataTableOther2.ColumnName = "Other2";
            this.coldsLogL3DataTableOther2.Namespace = "";
            // 
            // coldsLogL3DataTableOther3
            // 
            this.coldsLogL3DataTableOther3.Caption = "Other3";
            this.coldsLogL3DataTableOther3.ColumnName = "Other3";
            this.coldsLogL3DataTableOther3.Namespace = "";
            // 
            // PlanOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 351);
            this.Controls.Add(this.dvPlanOrder);
            this.Controls.Add(this.dvTel);
            this.Controls.Add(this.bnM);
            this.Controls.Add(this.tSp1);
            this.Name = "PlanOrderFrm";
            this.TabText = "订单电文补发";
            this.Text = "钢坯订单电文补发";
            ((System.ComponentModel.ISupportInitialize)(this.dvTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnM)).EndInit();
            this.bnM.ResumeLayout(false);
            this.bnM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlanOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlanOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlanOrder)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlanOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMaterialID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsWorkCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvTel;
        private System.Windows.Forms.BindingNavigator bnM;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txbHeatID;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.ToolStripButton btnAddSend;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dvPlanOrder;
        private AppSvrHMI.L3DataSet dsPlanOrder;
        private System.Windows.Forms.ToolStripButton btnUpdateSend;
        private System.Windows.Forms.BindingSource bsPlanOrder;
        private System.Data.DataTable schemadsPlanOrder;
        private System.Data.DataColumn coldsPlanOrderL3DataTableHeatID;
        private System.Data.DataColumn coldsPlanOrderL3DataTableFlag;
        private System.Data.DataColumn coldsPlanOrderL3DataTablescddh;
        private System.Data.DataColumn coldsPlanOrderL3DataTablepk_poid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablejhddh;
        private System.Data.DataColumn coldsPlanOrderL3DataTablewlbmid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablepk_produce;
        private System.Data.DataColumn coldsPlanOrderL3DataTableinvcode;
        private System.Data.DataColumn coldsPlanOrderL3DataTablenvname;
        private System.Data.DataColumn coldsPlanOrderL3DataTablepch;
        private System.Data.DataColumn coldsPlanOrderL3DataTablescbmid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablegzzxid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablegzzxbm;
        private System.Data.DataColumn coldsPlanOrderL3DataTableksid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablememo;
        private System.Data.DataColumn coldsPlanOrderL3DataTablesfjj;
        private System.Data.DataColumn coldsPlanOrderL3DataTableyxj;
        private System.Data.DataColumn coldsPlanOrderL3DataTablebcid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablebzid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablejhkgrq;
        private System.Data.DataColumn coldsPlanOrderL3DataTablejhwgrq;
        private System.Data.DataColumn coldsPlanOrderL3DataTablejhkssj;
        private System.Data.DataColumn coldsPlanOrderL3DataTablejhjssj;
        private System.Data.DataColumn coldsPlanOrderL3DataTablesjkgrq;
        private System.Data.DataColumn coldsPlanOrderL3DataTablesjwgrq;
        private System.Data.DataColumn coldsPlanOrderL3DataTablesjkssj;
        private System.Data.DataColumn coldsPlanOrderL3DataTablesjjssj;
        private System.Data.DataColumn coldsPlanOrderL3DataTablejhwgsl;
        private System.Data.DataColumn coldsPlanOrderL3DataTablefjhsl;
        private AppSvrHMI.L3Command cmdPlanOrder;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private AppSvrHMI.L3DataSet dsLog;
        private System.Data.DataTable schemadsLog;
        private System.Data.DataColumn coldsLogL3DataTableGUID;
        private System.Data.DataColumn coldsLogL3DataTableName;
        private System.Data.DataColumn coldsLogL3DataTableHeatID;
        private System.Data.DataColumn coldsLogL3DataTableBillType;
        private System.Data.DataColumn coldsLogL3DataTableFlag;
        private System.Data.DataColumn coldsLogL3DataTableRemark;
        private System.Data.DataColumn coldsLogL3DataTableCreateTime;
        private System.Data.DataColumn coldsLogL3DataTableOther1;
        private System.Data.DataColumn coldsLogL3DataTableOther2;
        private System.Data.DataColumn coldsLogL3DataTableOther3;
        private System.Data.DataColumn coldsPlanOrderL3DataTablejldwid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablefjlid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablesjwgsl;
        private System.Data.DataColumn coldsPlanOrderL3DataTablefwcsl;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezdy1;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezdy2;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezdy3;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezdy4;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezdy5;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezyx1;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezyx2;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezyx3;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezyx4;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezyx5;
        private System.Data.DataColumn coldsPlanOrderL3DataTablepk_corp;
        private System.Data.DataColumn coldsPlanOrderL3DataTablegcbm;
        private System.Data.DataColumn coldsPlanOrderL3DataTablezdrid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablepk_moid;
        private System.Data.DataColumn coldsPlanOrderL3DataTablePlanID;
        private System.Data.DataColumn coldsPlanOrderL3DataTableNC_Confirm_Flag;
        private AppSvrHMI.L3DataSet dsDepartment;
        private System.Data.DataTable schemadsDepartment;
        private System.Data.DataColumn coldsDepartmentL3DataTablePk_Department;
        private System.Data.DataColumn coldsDepartmentL3DataTableDepartment_Code;
        private AppSvrHMI.L3DataSet dsWorkCenter;
        private System.Data.DataTable schemadsWorkCenter;
        private System.Data.DataColumn coldsWorkCenterL3DataTablePk_Center;
        private System.Data.DataColumn coldsWorkCenterL3DataTableCenter_Code;
        private AppSvrHMI.L3DataSet dsGroup;
        private AppSvrHMI.L3DataSet dsShift;
        private System.Data.DataTable schemadsGroup;
        private System.Data.DataColumn coldsGroupL3DataTablePk_Team;
        private System.Data.DataColumn coldsGroupL3DataTableTeam_Name;
        private System.Data.DataTable schemadsShift;
        private System.Data.DataColumn coldsShiftL3DataTablePk_Shift;
        private System.Data.DataColumn coldsShiftL3DataTableShift_Name;
        private AppSvrHMI.L3DataSet dsMaterialID;
        private System.Windows.Forms.DataGridViewTextBoxColumn heatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scddhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkpoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhddhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn wlbmidDataGridViewTextBoxColumn;
        private System.Data.DataTable schemadsMaterialID;
        private System.Data.DataColumn coldsMaterialIDL3DataTablePk_Material_Bas;
        private System.Data.DataColumn coldsMaterialIDL3DataTableMaterial_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkproduceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn scbmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gzzxidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gzzxbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfjjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yxjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bcidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn bzidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhkgrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhwgrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhkssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhjssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjkgrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjwgrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjkssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjjssjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhwgslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjhslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jldwidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjlidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sjwgslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fwcslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdy5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zyx5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkcorpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zdridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkmoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCConfirmFlagDataGridViewTextBoxColumn;
    }
}