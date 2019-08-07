namespace PlanMag
{
    partial class PlanWriteInFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanWriteInFrm));
            this.bsPlan = new System.Windows.Forms.BindingSource(this.components);
            this.dsPlan = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsPlan = new System.Data.DataTable();
            this.coldsPlanL3DataTableGUID = new System.Data.DataColumn();
            this.coldsPlanL3DataTableNAME = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJhddh = new System.Data.DataColumn();
            this.coldsPlanL3DataTableXsddh = new System.Data.DataColumn();
            this.coldsPlanL3DataTablepk_invbasdoc = new System.Data.DataColumn();
            this.coldsPlanL3DataTablepk_produce = new System.Data.DataColumn();
            this.coldsPlanL3DataTableInvcode = new System.Data.DataColumn();
            this.coldsPlanL3DataTableInvname = new System.Data.DataColumn();
            this.coldsPlanL3DataTableInvspec = new System.Data.DataColumn();
            this.coldsPlanL3DataTableInvtype = new System.Data.DataColumn();
            this.coldsPlanL3DataTableScbmid = new System.Data.DataColumn();
            this.coldsPlanL3DataTableScbmbm = new System.Data.DataColumn();
            this.coldsPlanL3DataTableGzzxid = new System.Data.DataColumn();
            this.coldsPlanL3DataTableGzzxbm = new System.Data.DataColumn();
            this.coldsPlanL3DataTableZtshow = new System.Data.DataColumn();
            this.coldsPlanL3DataTableDdlx = new System.Data.DataColumn();
            this.coldsPlanL3DataTableKsid = new System.Data.DataColumn();
            this.coldsPlanL3DataTableSfjj = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJldwid = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJldwmc = new System.Data.DataColumn();
            this.coldsPlanL3DataTableFjlid = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJhwgsl = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJhxxsl = new System.Data.DataColumn();
            this.coldsPlanL3DataTableFjhsl = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJhksrq = new System.Data.DataColumn();
            this.coldsPlanL3DataTableXdrq = new System.Data.DataColumn();
            this.coldsPlanL3DataTableXqrq = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezdy1 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezdy2 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezdy3 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezdy4 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezdy5 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezyx1 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezyx2 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezyx3 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezyx4 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablezyx5 = new System.Data.DataColumn();
            this.coldsPlanL3DataTablepk_corp = new System.Data.DataColumn();
            this.coldsPlanL3DataTableGcbm = new System.Data.DataColumn();
            this.coldsPlanL3DataTablepk_poid = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJHBM = new System.Data.DataColumn();
            this.coldsPlanL3DataTableMRCK = new System.Data.DataColumn();
            this.coldsPlanL3DataTableJHY = new System.Data.DataColumn();
            this.coldsPlanL3DataTableProduct_Route = new System.Data.DataColumn();
            this.coldsPlanL3DataTableOther_Tech_Request = new System.Data.DataColumn();
            this.cmdPlan = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnIncludeExcel = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvPlan = new System.Windows.Forms.DataGridView();
            this.jhddhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xsddhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkinvbasdocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkproduceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JHBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scbmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JHY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scbmbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gzzxidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gzzxbmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ztshowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddlxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ksidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfjjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jldwidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jldwmcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjlidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhwgslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhxxslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fjhslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhksrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xdrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xqrqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pkpoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pk_invbasdoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // bsPlan
            // 
            this.bsPlan.DataMember = "L3DataTable";
            this.bsPlan.DataSource = this.dsPlan;
            // 
            // dsPlan
            // 
            this.dsPlan.AutoLoad = true;
            this.dsPlan.AutoSubscribe = true;
            this.dsPlan.DataSetName = "L3DataSet1";
            this.dsPlan.DeleteMethod = "";
            this.dsPlan.InsertMethod = "";
            this.dsPlan.L3DataAdapter = this.Adapter;
            this.dsPlan.LoadEvent = "Click";
            this.dsPlan.LoadTrigger = null;
            this.dsPlan.RefreshValve = 1000;
            this.dsPlan.SourceCommand = null;
            this.dsPlan.SourceCondition = "";
            this.dsPlan.SourceMethod = "";
            this.dsPlan.SourceType = AppSvrHMI.L3DataSetSourceType.SQL;
            this.dsPlan.SourceURI = "";
            this.dsPlan.SubscribeTarget = "";
            this.dsPlan.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsPlan});
            this.dsPlan.UpdateEvent = "Click";
            this.dsPlan.UpdateMethod = "";
            this.dsPlan.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsPlan
            // 
            this.schemadsPlan.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsPlanL3DataTableGUID,
            this.coldsPlanL3DataTableNAME,
            this.coldsPlanL3DataTableJhddh,
            this.coldsPlanL3DataTableXsddh,
            this.coldsPlanL3DataTablepk_invbasdoc,
            this.coldsPlanL3DataTablepk_produce,
            this.coldsPlanL3DataTableInvcode,
            this.coldsPlanL3DataTableInvname,
            this.coldsPlanL3DataTableInvspec,
            this.coldsPlanL3DataTableInvtype,
            this.coldsPlanL3DataTableScbmid,
            this.coldsPlanL3DataTableScbmbm,
            this.coldsPlanL3DataTableGzzxid,
            this.coldsPlanL3DataTableGzzxbm,
            this.coldsPlanL3DataTableZtshow,
            this.coldsPlanL3DataTableDdlx,
            this.coldsPlanL3DataTableKsid,
            this.coldsPlanL3DataTableSfjj,
            this.coldsPlanL3DataTableJldwid,
            this.coldsPlanL3DataTableJldwmc,
            this.coldsPlanL3DataTableFjlid,
            this.coldsPlanL3DataTableJhwgsl,
            this.coldsPlanL3DataTableJhxxsl,
            this.coldsPlanL3DataTableFjhsl,
            this.coldsPlanL3DataTableJhksrq,
            this.coldsPlanL3DataTableXdrq,
            this.coldsPlanL3DataTableXqrq,
            this.coldsPlanL3DataTablezdy1,
            this.coldsPlanL3DataTablezdy2,
            this.coldsPlanL3DataTablezdy3,
            this.coldsPlanL3DataTablezdy4,
            this.coldsPlanL3DataTablezdy5,
            this.coldsPlanL3DataTablezyx1,
            this.coldsPlanL3DataTablezyx2,
            this.coldsPlanL3DataTablezyx3,
            this.coldsPlanL3DataTablezyx4,
            this.coldsPlanL3DataTablezyx5,
            this.coldsPlanL3DataTablepk_corp,
            this.coldsPlanL3DataTableGcbm,
            this.coldsPlanL3DataTablepk_poid,
            this.coldsPlanL3DataTableJHBM,
            this.coldsPlanL3DataTableMRCK,
            this.coldsPlanL3DataTableJHY,
            this.coldsPlanL3DataTableProduct_Route,
            this.coldsPlanL3DataTableOther_Tech_Request});
            this.schemadsPlan.TableName = "L3DataTable";
            // 
            // coldsPlanL3DataTableGUID
            // 
            this.coldsPlanL3DataTableGUID.Caption = "GUID";
            this.coldsPlanL3DataTableGUID.ColumnName = "GUID";
            this.coldsPlanL3DataTableGUID.DefaultValue = "";
            this.coldsPlanL3DataTableGUID.Namespace = "";
            // 
            // coldsPlanL3DataTableNAME
            // 
            this.coldsPlanL3DataTableNAME.Caption = "NAME";
            this.coldsPlanL3DataTableNAME.ColumnName = "NAME";
            this.coldsPlanL3DataTableNAME.DefaultValue = "";
            this.coldsPlanL3DataTableNAME.Namespace = "";
            // 
            // coldsPlanL3DataTableJhddh
            // 
            this.coldsPlanL3DataTableJhddh.Caption = "Jhddh";
            this.coldsPlanL3DataTableJhddh.ColumnName = "Jhddh";
            this.coldsPlanL3DataTableJhddh.Namespace = "";
            // 
            // coldsPlanL3DataTableXsddh
            // 
            this.coldsPlanL3DataTableXsddh.Caption = "Xsddh";
            this.coldsPlanL3DataTableXsddh.ColumnName = "Xsddh";
            this.coldsPlanL3DataTableXsddh.Namespace = "";
            // 
            // coldsPlanL3DataTablepk_invbasdoc
            // 
            this.coldsPlanL3DataTablepk_invbasdoc.Caption = "pk_invbasdoc";
            this.coldsPlanL3DataTablepk_invbasdoc.ColumnName = "pk_invbasdoc";
            this.coldsPlanL3DataTablepk_invbasdoc.Namespace = "";
            // 
            // coldsPlanL3DataTablepk_produce
            // 
            this.coldsPlanL3DataTablepk_produce.Caption = "pk_produce";
            this.coldsPlanL3DataTablepk_produce.ColumnName = "pk_produce";
            this.coldsPlanL3DataTablepk_produce.Namespace = "";
            // 
            // coldsPlanL3DataTableInvcode
            // 
            this.coldsPlanL3DataTableInvcode.Caption = "Invcode";
            this.coldsPlanL3DataTableInvcode.ColumnName = "Invcode";
            this.coldsPlanL3DataTableInvcode.Namespace = "";
            // 
            // coldsPlanL3DataTableInvname
            // 
            this.coldsPlanL3DataTableInvname.Caption = "Invname";
            this.coldsPlanL3DataTableInvname.ColumnName = "Invname";
            this.coldsPlanL3DataTableInvname.Namespace = "";
            // 
            // coldsPlanL3DataTableInvspec
            // 
            this.coldsPlanL3DataTableInvspec.Caption = "Invspec";
            this.coldsPlanL3DataTableInvspec.ColumnName = "Invspec";
            this.coldsPlanL3DataTableInvspec.Namespace = "";
            // 
            // coldsPlanL3DataTableInvtype
            // 
            this.coldsPlanL3DataTableInvtype.Caption = "Invtype";
            this.coldsPlanL3DataTableInvtype.ColumnName = "Invtype";
            this.coldsPlanL3DataTableInvtype.Namespace = "";
            // 
            // coldsPlanL3DataTableScbmid
            // 
            this.coldsPlanL3DataTableScbmid.Caption = "Scbmid";
            this.coldsPlanL3DataTableScbmid.ColumnName = "Scbmid";
            this.coldsPlanL3DataTableScbmid.Namespace = "";
            // 
            // coldsPlanL3DataTableScbmbm
            // 
            this.coldsPlanL3DataTableScbmbm.Caption = "Scbmbm";
            this.coldsPlanL3DataTableScbmbm.ColumnName = "Scbmbm";
            this.coldsPlanL3DataTableScbmbm.Namespace = "";
            // 
            // coldsPlanL3DataTableGzzxid
            // 
            this.coldsPlanL3DataTableGzzxid.Caption = "Gzzxid";
            this.coldsPlanL3DataTableGzzxid.ColumnName = "Gzzxid";
            this.coldsPlanL3DataTableGzzxid.Namespace = "";
            // 
            // coldsPlanL3DataTableGzzxbm
            // 
            this.coldsPlanL3DataTableGzzxbm.Caption = "Gzzxbm";
            this.coldsPlanL3DataTableGzzxbm.ColumnName = "Gzzxbm";
            this.coldsPlanL3DataTableGzzxbm.Namespace = "";
            // 
            // coldsPlanL3DataTableZtshow
            // 
            this.coldsPlanL3DataTableZtshow.Caption = "Ztshow";
            this.coldsPlanL3DataTableZtshow.ColumnName = "Ztshow";
            this.coldsPlanL3DataTableZtshow.Namespace = "";
            // 
            // coldsPlanL3DataTableDdlx
            // 
            this.coldsPlanL3DataTableDdlx.Caption = "Ddlx";
            this.coldsPlanL3DataTableDdlx.ColumnName = "Ddlx";
            this.coldsPlanL3DataTableDdlx.Namespace = "";
            // 
            // coldsPlanL3DataTableKsid
            // 
            this.coldsPlanL3DataTableKsid.Caption = "Ksid";
            this.coldsPlanL3DataTableKsid.ColumnName = "Ksid";
            this.coldsPlanL3DataTableKsid.Namespace = "";
            // 
            // coldsPlanL3DataTableSfjj
            // 
            this.coldsPlanL3DataTableSfjj.Caption = "Sfjj";
            this.coldsPlanL3DataTableSfjj.ColumnName = "Sfjj";
            this.coldsPlanL3DataTableSfjj.Namespace = "";
            // 
            // coldsPlanL3DataTableJldwid
            // 
            this.coldsPlanL3DataTableJldwid.Caption = "Jldwid";
            this.coldsPlanL3DataTableJldwid.ColumnName = "Jldwid";
            this.coldsPlanL3DataTableJldwid.Namespace = "";
            // 
            // coldsPlanL3DataTableJldwmc
            // 
            this.coldsPlanL3DataTableJldwmc.Caption = "Jldwmc";
            this.coldsPlanL3DataTableJldwmc.ColumnName = "Jldwmc";
            this.coldsPlanL3DataTableJldwmc.Namespace = "";
            // 
            // coldsPlanL3DataTableFjlid
            // 
            this.coldsPlanL3DataTableFjlid.Caption = "Fjlid";
            this.coldsPlanL3DataTableFjlid.ColumnName = "Fjlid";
            this.coldsPlanL3DataTableFjlid.Namespace = "";
            // 
            // coldsPlanL3DataTableJhwgsl
            // 
            this.coldsPlanL3DataTableJhwgsl.Caption = "Jhwgsl";
            this.coldsPlanL3DataTableJhwgsl.ColumnName = "Jhwgsl";
            this.coldsPlanL3DataTableJhwgsl.DataType = typeof(double);
            this.coldsPlanL3DataTableJhwgsl.Namespace = "";
            // 
            // coldsPlanL3DataTableJhxxsl
            // 
            this.coldsPlanL3DataTableJhxxsl.Caption = "Jhxxsl";
            this.coldsPlanL3DataTableJhxxsl.ColumnName = "Jhxxsl";
            this.coldsPlanL3DataTableJhxxsl.DataType = typeof(double);
            this.coldsPlanL3DataTableJhxxsl.Namespace = "";
            // 
            // coldsPlanL3DataTableFjhsl
            // 
            this.coldsPlanL3DataTableFjhsl.Caption = "Fjhsl";
            this.coldsPlanL3DataTableFjhsl.ColumnName = "Fjhsl";
            this.coldsPlanL3DataTableFjhsl.DataType = typeof(int);
            this.coldsPlanL3DataTableFjhsl.Namespace = "";
            // 
            // coldsPlanL3DataTableJhksrq
            // 
            this.coldsPlanL3DataTableJhksrq.Caption = "Jhksrq";
            this.coldsPlanL3DataTableJhksrq.ColumnName = "Jhksrq";
            this.coldsPlanL3DataTableJhksrq.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableJhksrq.Namespace = "";
            // 
            // coldsPlanL3DataTableXdrq
            // 
            this.coldsPlanL3DataTableXdrq.Caption = "Xdrq";
            this.coldsPlanL3DataTableXdrq.ColumnName = "Xdrq";
            this.coldsPlanL3DataTableXdrq.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableXdrq.Namespace = "";
            // 
            // coldsPlanL3DataTableXqrq
            // 
            this.coldsPlanL3DataTableXqrq.Caption = "Xqrq";
            this.coldsPlanL3DataTableXqrq.ColumnName = "Xqrq";
            this.coldsPlanL3DataTableXqrq.DataType = typeof(System.DateTime);
            this.coldsPlanL3DataTableXqrq.Namespace = "";
            // 
            // coldsPlanL3DataTablezdy1
            // 
            this.coldsPlanL3DataTablezdy1.Caption = "zdy1";
            this.coldsPlanL3DataTablezdy1.ColumnName = "zdy1";
            this.coldsPlanL3DataTablezdy1.Namespace = "";
            // 
            // coldsPlanL3DataTablezdy2
            // 
            this.coldsPlanL3DataTablezdy2.Caption = "zdy2";
            this.coldsPlanL3DataTablezdy2.ColumnName = "zdy2";
            this.coldsPlanL3DataTablezdy2.Namespace = "";
            // 
            // coldsPlanL3DataTablezdy3
            // 
            this.coldsPlanL3DataTablezdy3.Caption = "zdy3";
            this.coldsPlanL3DataTablezdy3.ColumnName = "zdy3";
            this.coldsPlanL3DataTablezdy3.Namespace = "";
            // 
            // coldsPlanL3DataTablezdy4
            // 
            this.coldsPlanL3DataTablezdy4.Caption = "zdy4";
            this.coldsPlanL3DataTablezdy4.ColumnName = "zdy4";
            this.coldsPlanL3DataTablezdy4.Namespace = "";
            // 
            // coldsPlanL3DataTablezdy5
            // 
            this.coldsPlanL3DataTablezdy5.Caption = "zdy5";
            this.coldsPlanL3DataTablezdy5.ColumnName = "zdy5";
            this.coldsPlanL3DataTablezdy5.Namespace = "";
            // 
            // coldsPlanL3DataTablezyx1
            // 
            this.coldsPlanL3DataTablezyx1.Caption = "zyx1";
            this.coldsPlanL3DataTablezyx1.ColumnName = "zyx1";
            this.coldsPlanL3DataTablezyx1.Namespace = "";
            // 
            // coldsPlanL3DataTablezyx2
            // 
            this.coldsPlanL3DataTablezyx2.Caption = "zyx2";
            this.coldsPlanL3DataTablezyx2.ColumnName = "zyx2";
            this.coldsPlanL3DataTablezyx2.Namespace = "";
            // 
            // coldsPlanL3DataTablezyx3
            // 
            this.coldsPlanL3DataTablezyx3.Caption = "zyx3";
            this.coldsPlanL3DataTablezyx3.ColumnName = "zyx3";
            this.coldsPlanL3DataTablezyx3.Namespace = "";
            // 
            // coldsPlanL3DataTablezyx4
            // 
            this.coldsPlanL3DataTablezyx4.Caption = "zyx4";
            this.coldsPlanL3DataTablezyx4.ColumnName = "zyx4";
            this.coldsPlanL3DataTablezyx4.Namespace = "";
            // 
            // coldsPlanL3DataTablezyx5
            // 
            this.coldsPlanL3DataTablezyx5.Caption = "zyx5";
            this.coldsPlanL3DataTablezyx5.ColumnName = "zyx5";
            this.coldsPlanL3DataTablezyx5.Namespace = "";
            // 
            // coldsPlanL3DataTablepk_corp
            // 
            this.coldsPlanL3DataTablepk_corp.Caption = "pk_corp";
            this.coldsPlanL3DataTablepk_corp.ColumnName = "pk_corp";
            this.coldsPlanL3DataTablepk_corp.Namespace = "";
            // 
            // coldsPlanL3DataTableGcbm
            // 
            this.coldsPlanL3DataTableGcbm.Caption = "Gcbm";
            this.coldsPlanL3DataTableGcbm.ColumnName = "Gcbm";
            this.coldsPlanL3DataTableGcbm.Namespace = "";
            // 
            // coldsPlanL3DataTablepk_poid
            // 
            this.coldsPlanL3DataTablepk_poid.Caption = "pk_poid";
            this.coldsPlanL3DataTablepk_poid.ColumnName = "pk_poid";
            this.coldsPlanL3DataTablepk_poid.Namespace = "";
            // 
            // coldsPlanL3DataTableJHBM
            // 
            this.coldsPlanL3DataTableJHBM.Caption = "JHBM";
            this.coldsPlanL3DataTableJHBM.ColumnName = "JHBM";
            this.coldsPlanL3DataTableJHBM.Namespace = "";
            // 
            // coldsPlanL3DataTableMRCK
            // 
            this.coldsPlanL3DataTableMRCK.Caption = "MRCK";
            this.coldsPlanL3DataTableMRCK.ColumnName = "MRCK";
            this.coldsPlanL3DataTableMRCK.Namespace = "";
            // 
            // coldsPlanL3DataTableJHY
            // 
            this.coldsPlanL3DataTableJHY.Caption = "JHY";
            this.coldsPlanL3DataTableJHY.ColumnName = "JHY";
            this.coldsPlanL3DataTableJHY.Namespace = "";
            // 
            // coldsPlanL3DataTableProduct_Route
            // 
            this.coldsPlanL3DataTableProduct_Route.Caption = "Product_Route";
            this.coldsPlanL3DataTableProduct_Route.ColumnName = "Product_Route";
            this.coldsPlanL3DataTableProduct_Route.Namespace = "";
            // 
            // coldsPlanL3DataTableOther_Tech_Request
            // 
            this.coldsPlanL3DataTableOther_Tech_Request.Caption = "Other_Tech_Request";
            this.coldsPlanL3DataTableOther_Tech_Request.ColumnName = "Other_Tech_Request";
            this.coldsPlanL3DataTableOther_Tech_Request.Namespace = "";
            // 
            // cmdPlan
            // 
            this.cmdPlan.Adapter = this.Adapter;
            this.cmdPlan.MergeReturnTarget = false;
            this.cmdPlan.Method = "PlanOrdRec";
            this.cmdPlan.Object = "XGMESLogic\\PlanMag\\CPlan_Mag\\Plan_Mag";
            this.cmdPlan.Parameters.Add(this.l3CommandParameter1);
            this.cmdPlan.ReturnTarget = null;
            this.cmdPlan.ReturnTargetProperty = null;
            this.cmdPlan.Trigger = null;
            this.cmdPlan.TriggerEvent = "Click";
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = null;
            this.l3CommandParameter1.SourceObject = this.dsPlan;
            this.l3CommandParameter1.SourceProperty = "L3DataTable";
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnIncludeExcel,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(1000, 43);
            this.tSp1.TabIndex = 27;
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
            // btnIncludeExcel
            // 
            this.btnIncludeExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnIncludeExcel.Image")));
            this.btnIncludeExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncludeExcel.Name = "btnIncludeExcel";
            this.btnIncludeExcel.Size = new System.Drawing.Size(95, 40);
            this.btnIncludeExcel.Text = "导入Excel";
            this.btnIncludeExcel.Click += new System.EventHandler(this.btnIncludeExcel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsPlan;
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
            this.toolStripLabel3});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 28;
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel3.Text = "　　　　　";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvPlan);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 31;
            // 
            // dvPlan
            // 
            this.dvPlan.AllowUserToAddRows = false;
            this.dvPlan.AutoGenerateColumns = false;
            this.dvPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvPlan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jhddhDataGridViewTextBoxColumn,
            this.xsddhDataGridViewTextBoxColumn,
            this.pkinvbasdocDataGridViewTextBoxColumn,
            this.pkproduceDataGridViewTextBoxColumn,
            this.invcodeDataGridViewTextBoxColumn,
            this.invnameDataGridViewTextBoxColumn,
            this.invspecDataGridViewTextBoxColumn,
            this.JHBM,
            this.MRCK,
            this.invtypeDataGridViewTextBoxColumn,
            this.scbmidDataGridViewTextBoxColumn,
            this.JHY,
            this.scbmbmDataGridViewTextBoxColumn,
            this.gzzxidDataGridViewTextBoxColumn,
            this.gzzxbmDataGridViewTextBoxColumn,
            this.ztshowDataGridViewTextBoxColumn,
            this.ddlxDataGridViewTextBoxColumn,
            this.ksidDataGridViewTextBoxColumn,
            this.sfjjDataGridViewTextBoxColumn,
            this.jldwidDataGridViewTextBoxColumn,
            this.jldwmcDataGridViewTextBoxColumn,
            this.fjlidDataGridViewTextBoxColumn,
            this.jhwgslDataGridViewTextBoxColumn,
            this.jhxxslDataGridViewTextBoxColumn,
            this.fjhslDataGridViewTextBoxColumn,
            this.jhksrqDataGridViewTextBoxColumn,
            this.xdrqDataGridViewTextBoxColumn,
            this.xqrqDataGridViewTextBoxColumn,
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
            this.pkpoidDataGridViewTextBoxColumn,
            this.pk_invbasdoc});
            this.dvPlan.DataSource = this.bsPlan;
            this.dvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvPlan.Location = new System.Drawing.Point(0, 0);
            this.dvPlan.Name = "dvPlan";
            this.dvPlan.ReadOnly = true;
            this.dvPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvPlan.RowTemplate.Height = 23;
            this.dvPlan.Size = new System.Drawing.Size(996, 628);
            this.dvPlan.TabIndex = 0;
            // 
            // jhddhDataGridViewTextBoxColumn
            // 
            this.jhddhDataGridViewTextBoxColumn.DataPropertyName = "Jhddh";
            this.jhddhDataGridViewTextBoxColumn.HeaderText = "计划订单号";
            this.jhddhDataGridViewTextBoxColumn.Name = "jhddhDataGridViewTextBoxColumn";
            this.jhddhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xsddhDataGridViewTextBoxColumn
            // 
            this.xsddhDataGridViewTextBoxColumn.DataPropertyName = "Xsddh";
            this.xsddhDataGridViewTextBoxColumn.HeaderText = "销售订单号";
            this.xsddhDataGridViewTextBoxColumn.Name = "xsddhDataGridViewTextBoxColumn";
            this.xsddhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkinvbasdocDataGridViewTextBoxColumn
            // 
            this.pkinvbasdocDataGridViewTextBoxColumn.DataPropertyName = "pk_invbasdoc";
            this.pkinvbasdocDataGridViewTextBoxColumn.HeaderText = "产品";
            this.pkinvbasdocDataGridViewTextBoxColumn.Name = "pkinvbasdocDataGridViewTextBoxColumn";
            this.pkinvbasdocDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkinvbasdocDataGridViewTextBoxColumn.Visible = false;
            // 
            // pkproduceDataGridViewTextBoxColumn
            // 
            this.pkproduceDataGridViewTextBoxColumn.DataPropertyName = "pk_produce";
            this.pkproduceDataGridViewTextBoxColumn.HeaderText = "产品生产档案主键";
            this.pkproduceDataGridViewTextBoxColumn.Name = "pkproduceDataGridViewTextBoxColumn";
            this.pkproduceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkproduceDataGridViewTextBoxColumn.Visible = false;
            // 
            // invcodeDataGridViewTextBoxColumn
            // 
            this.invcodeDataGridViewTextBoxColumn.DataPropertyName = "Invcode";
            this.invcodeDataGridViewTextBoxColumn.HeaderText = "物料编码";
            this.invcodeDataGridViewTextBoxColumn.Name = "invcodeDataGridViewTextBoxColumn";
            this.invcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invnameDataGridViewTextBoxColumn
            // 
            this.invnameDataGridViewTextBoxColumn.DataPropertyName = "Invname";
            this.invnameDataGridViewTextBoxColumn.HeaderText = "物料名称";
            this.invnameDataGridViewTextBoxColumn.Name = "invnameDataGridViewTextBoxColumn";
            this.invnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invspecDataGridViewTextBoxColumn
            // 
            this.invspecDataGridViewTextBoxColumn.DataPropertyName = "Invspec";
            this.invspecDataGridViewTextBoxColumn.HeaderText = "物料规格";
            this.invspecDataGridViewTextBoxColumn.Name = "invspecDataGridViewTextBoxColumn";
            this.invspecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // JHBM
            // 
            this.JHBM.DataPropertyName = "JHBM";
            this.JHBM.HeaderText = "计划部门";
            this.JHBM.Name = "JHBM";
            this.JHBM.ReadOnly = true;
            // 
            // MRCK
            // 
            this.MRCK.DataPropertyName = "MRCK";
            this.MRCK.HeaderText = "默认仓库";
            this.MRCK.Name = "MRCK";
            this.MRCK.ReadOnly = true;
            // 
            // invtypeDataGridViewTextBoxColumn
            // 
            this.invtypeDataGridViewTextBoxColumn.DataPropertyName = "Invtype";
            this.invtypeDataGridViewTextBoxColumn.HeaderText = "物料型号";
            this.invtypeDataGridViewTextBoxColumn.Name = "invtypeDataGridViewTextBoxColumn";
            this.invtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scbmidDataGridViewTextBoxColumn
            // 
            this.scbmidDataGridViewTextBoxColumn.DataPropertyName = "Scbmid";
            this.scbmidDataGridViewTextBoxColumn.HeaderText = "生产部门";
            this.scbmidDataGridViewTextBoxColumn.Name = "scbmidDataGridViewTextBoxColumn";
            this.scbmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.scbmidDataGridViewTextBoxColumn.Visible = false;
            // 
            // JHY
            // 
            this.JHY.DataPropertyName = "JHY";
            this.JHY.HeaderText = "计划员";
            this.JHY.Name = "JHY";
            this.JHY.ReadOnly = true;
            // 
            // scbmbmDataGridViewTextBoxColumn
            // 
            this.scbmbmDataGridViewTextBoxColumn.DataPropertyName = "Scbmbm";
            this.scbmbmDataGridViewTextBoxColumn.HeaderText = "生产部门编码";
            this.scbmbmDataGridViewTextBoxColumn.Name = "scbmbmDataGridViewTextBoxColumn";
            this.scbmbmDataGridViewTextBoxColumn.ReadOnly = true;
            this.scbmbmDataGridViewTextBoxColumn.Visible = false;
            // 
            // gzzxidDataGridViewTextBoxColumn
            // 
            this.gzzxidDataGridViewTextBoxColumn.DataPropertyName = "Gzzxid";
            this.gzzxidDataGridViewTextBoxColumn.HeaderText = "工作中心";
            this.gzzxidDataGridViewTextBoxColumn.Name = "gzzxidDataGridViewTextBoxColumn";
            this.gzzxidDataGridViewTextBoxColumn.ReadOnly = true;
            this.gzzxidDataGridViewTextBoxColumn.Visible = false;
            // 
            // gzzxbmDataGridViewTextBoxColumn
            // 
            this.gzzxbmDataGridViewTextBoxColumn.DataPropertyName = "Gzzxbm";
            this.gzzxbmDataGridViewTextBoxColumn.HeaderText = "工作中心编码";
            this.gzzxbmDataGridViewTextBoxColumn.Name = "gzzxbmDataGridViewTextBoxColumn";
            this.gzzxbmDataGridViewTextBoxColumn.ReadOnly = true;
            this.gzzxbmDataGridViewTextBoxColumn.Visible = false;
            // 
            // ztshowDataGridViewTextBoxColumn
            // 
            this.ztshowDataGridViewTextBoxColumn.DataPropertyName = "Ztshow";
            this.ztshowDataGridViewTextBoxColumn.HeaderText = "订单状态";
            this.ztshowDataGridViewTextBoxColumn.Name = "ztshowDataGridViewTextBoxColumn";
            this.ztshowDataGridViewTextBoxColumn.ReadOnly = true;
            this.ztshowDataGridViewTextBoxColumn.Visible = false;
            // 
            // ddlxDataGridViewTextBoxColumn
            // 
            this.ddlxDataGridViewTextBoxColumn.DataPropertyName = "Ddlx";
            this.ddlxDataGridViewTextBoxColumn.HeaderText = "订单类型";
            this.ddlxDataGridViewTextBoxColumn.Name = "ddlxDataGridViewTextBoxColumn";
            this.ddlxDataGridViewTextBoxColumn.ReadOnly = true;
            this.ddlxDataGridViewTextBoxColumn.Visible = false;
            // 
            // ksidDataGridViewTextBoxColumn
            // 
            this.ksidDataGridViewTextBoxColumn.DataPropertyName = "Ksid";
            this.ksidDataGridViewTextBoxColumn.HeaderText = "客户";
            this.ksidDataGridViewTextBoxColumn.Name = "ksidDataGridViewTextBoxColumn";
            this.ksidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sfjjDataGridViewTextBoxColumn
            // 
            this.sfjjDataGridViewTextBoxColumn.DataPropertyName = "Sfjj";
            this.sfjjDataGridViewTextBoxColumn.HeaderText = "是否加急";
            this.sfjjDataGridViewTextBoxColumn.Name = "sfjjDataGridViewTextBoxColumn";
            this.sfjjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jldwidDataGridViewTextBoxColumn
            // 
            this.jldwidDataGridViewTextBoxColumn.DataPropertyName = "Jldwid";
            this.jldwidDataGridViewTextBoxColumn.HeaderText = "计量单位";
            this.jldwidDataGridViewTextBoxColumn.Name = "jldwidDataGridViewTextBoxColumn";
            this.jldwidDataGridViewTextBoxColumn.ReadOnly = true;
            this.jldwidDataGridViewTextBoxColumn.Visible = false;
            // 
            // jldwmcDataGridViewTextBoxColumn
            // 
            this.jldwmcDataGridViewTextBoxColumn.DataPropertyName = "Jldwmc";
            this.jldwmcDataGridViewTextBoxColumn.HeaderText = "计量单位名称";
            this.jldwmcDataGridViewTextBoxColumn.Name = "jldwmcDataGridViewTextBoxColumn";
            this.jldwmcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjlidDataGridViewTextBoxColumn
            // 
            this.fjlidDataGridViewTextBoxColumn.DataPropertyName = "Fjlid";
            this.fjlidDataGridViewTextBoxColumn.HeaderText = "辅计量单位";
            this.fjlidDataGridViewTextBoxColumn.Name = "fjlidDataGridViewTextBoxColumn";
            this.fjlidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jhwgslDataGridViewTextBoxColumn
            // 
            this.jhwgslDataGridViewTextBoxColumn.DataPropertyName = "Jhwgsl";
            this.jhwgslDataGridViewTextBoxColumn.HeaderText = "计划数量";
            this.jhwgslDataGridViewTextBoxColumn.Name = "jhwgslDataGridViewTextBoxColumn";
            this.jhwgslDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jhxxslDataGridViewTextBoxColumn
            // 
            this.jhxxslDataGridViewTextBoxColumn.DataPropertyName = "Jhxxsl";
            this.jhxxslDataGridViewTextBoxColumn.HeaderText = "计划下限数量";
            this.jhxxslDataGridViewTextBoxColumn.Name = "jhxxslDataGridViewTextBoxColumn";
            this.jhxxslDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fjhslDataGridViewTextBoxColumn
            // 
            this.fjhslDataGridViewTextBoxColumn.DataPropertyName = "Fjhsl";
            this.fjhslDataGridViewTextBoxColumn.HeaderText = "计划辅数量";
            this.fjhslDataGridViewTextBoxColumn.Name = "fjhslDataGridViewTextBoxColumn";
            this.fjhslDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jhksrqDataGridViewTextBoxColumn
            // 
            this.jhksrqDataGridViewTextBoxColumn.DataPropertyName = "Jhksrq";
            this.jhksrqDataGridViewTextBoxColumn.HeaderText = "计划开始日期";
            this.jhksrqDataGridViewTextBoxColumn.Name = "jhksrqDataGridViewTextBoxColumn";
            this.jhksrqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xdrqDataGridViewTextBoxColumn
            // 
            this.xdrqDataGridViewTextBoxColumn.DataPropertyName = "Xdrq";
            this.xdrqDataGridViewTextBoxColumn.HeaderText = "下单日期";
            this.xdrqDataGridViewTextBoxColumn.Name = "xdrqDataGridViewTextBoxColumn";
            this.xdrqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xqrqDataGridViewTextBoxColumn
            // 
            this.xqrqDataGridViewTextBoxColumn.DataPropertyName = "Xqrq";
            this.xqrqDataGridViewTextBoxColumn.HeaderText = "需求日期";
            this.xqrqDataGridViewTextBoxColumn.Name = "xqrqDataGridViewTextBoxColumn";
            this.xqrqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zdy1DataGridViewTextBoxColumn
            // 
            this.zdy1DataGridViewTextBoxColumn.DataPropertyName = "zdy1";
            this.zdy1DataGridViewTextBoxColumn.HeaderText = "自定义1";
            this.zdy1DataGridViewTextBoxColumn.Name = "zdy1DataGridViewTextBoxColumn";
            this.zdy1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zdy2DataGridViewTextBoxColumn
            // 
            this.zdy2DataGridViewTextBoxColumn.DataPropertyName = "zdy2";
            this.zdy2DataGridViewTextBoxColumn.HeaderText = "自定义2";
            this.zdy2DataGridViewTextBoxColumn.Name = "zdy2DataGridViewTextBoxColumn";
            this.zdy2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zdy3DataGridViewTextBoxColumn
            // 
            this.zdy3DataGridViewTextBoxColumn.DataPropertyName = "zdy3";
            this.zdy3DataGridViewTextBoxColumn.HeaderText = "自定义3";
            this.zdy3DataGridViewTextBoxColumn.Name = "zdy3DataGridViewTextBoxColumn";
            this.zdy3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zdy4DataGridViewTextBoxColumn
            // 
            this.zdy4DataGridViewTextBoxColumn.DataPropertyName = "zdy4";
            this.zdy4DataGridViewTextBoxColumn.HeaderText = "自定义4";
            this.zdy4DataGridViewTextBoxColumn.Name = "zdy4DataGridViewTextBoxColumn";
            this.zdy4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zdy5DataGridViewTextBoxColumn
            // 
            this.zdy5DataGridViewTextBoxColumn.DataPropertyName = "zdy5";
            this.zdy5DataGridViewTextBoxColumn.HeaderText = "自定义5";
            this.zdy5DataGridViewTextBoxColumn.Name = "zdy5DataGridViewTextBoxColumn";
            this.zdy5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zyx1DataGridViewTextBoxColumn
            // 
            this.zyx1DataGridViewTextBoxColumn.DataPropertyName = "zyx1";
            this.zyx1DataGridViewTextBoxColumn.HeaderText = "自由项1";
            this.zyx1DataGridViewTextBoxColumn.Name = "zyx1DataGridViewTextBoxColumn";
            this.zyx1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zyx2DataGridViewTextBoxColumn
            // 
            this.zyx2DataGridViewTextBoxColumn.DataPropertyName = "zyx2";
            this.zyx2DataGridViewTextBoxColumn.HeaderText = "自由项2";
            this.zyx2DataGridViewTextBoxColumn.Name = "zyx2DataGridViewTextBoxColumn";
            this.zyx2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zyx3DataGridViewTextBoxColumn
            // 
            this.zyx3DataGridViewTextBoxColumn.DataPropertyName = "zyx3";
            this.zyx3DataGridViewTextBoxColumn.HeaderText = "自由项3";
            this.zyx3DataGridViewTextBoxColumn.Name = "zyx3DataGridViewTextBoxColumn";
            this.zyx3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zyx4DataGridViewTextBoxColumn
            // 
            this.zyx4DataGridViewTextBoxColumn.DataPropertyName = "zyx4";
            this.zyx4DataGridViewTextBoxColumn.HeaderText = "自由项4";
            this.zyx4DataGridViewTextBoxColumn.Name = "zyx4DataGridViewTextBoxColumn";
            this.zyx4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zyx5DataGridViewTextBoxColumn
            // 
            this.zyx5DataGridViewTextBoxColumn.DataPropertyName = "zyx5";
            this.zyx5DataGridViewTextBoxColumn.HeaderText = "自由项5";
            this.zyx5DataGridViewTextBoxColumn.Name = "zyx5DataGridViewTextBoxColumn";
            this.zyx5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkcorpDataGridViewTextBoxColumn
            // 
            this.pkcorpDataGridViewTextBoxColumn.DataPropertyName = "pk_corp";
            this.pkcorpDataGridViewTextBoxColumn.HeaderText = "公司";
            this.pkcorpDataGridViewTextBoxColumn.Name = "pkcorpDataGridViewTextBoxColumn";
            this.pkcorpDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkcorpDataGridViewTextBoxColumn.Visible = false;
            // 
            // gcbmDataGridViewTextBoxColumn
            // 
            this.gcbmDataGridViewTextBoxColumn.DataPropertyName = "Gcbm";
            this.gcbmDataGridViewTextBoxColumn.HeaderText = "工厂";
            this.gcbmDataGridViewTextBoxColumn.Name = "gcbmDataGridViewTextBoxColumn";
            this.gcbmDataGridViewTextBoxColumn.ReadOnly = true;
            this.gcbmDataGridViewTextBoxColumn.Visible = false;
            // 
            // pkpoidDataGridViewTextBoxColumn
            // 
            this.pkpoidDataGridViewTextBoxColumn.DataPropertyName = "pk_poid";
            this.pkpoidDataGridViewTextBoxColumn.HeaderText = "计划订单主键";
            this.pkpoidDataGridViewTextBoxColumn.Name = "pkpoidDataGridViewTextBoxColumn";
            this.pkpoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pk_invbasdoc
            // 
            this.pk_invbasdoc.DataPropertyName = "pk_invbasdoc";
            this.pk_invbasdoc.HeaderText = "物料编码主键";
            this.pk_invbasdoc.Name = "pk_invbasdoc";
            this.pk_invbasdoc.ReadOnly = true;
            // 
            // PlanWriteInFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlanWriteInFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "计划订单录入";
            this.Text = "多记录显示";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlanWriteInFrm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanWriteInFrm_FormClosing);
            this.Load += new System.EventHandler(this.PlanWriteInFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsPlan)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvPlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsPlan;
        private System.Windows.Forms.BindingSource bsPlan;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvPlan;
        private System.Windows.Forms.ToolStripButton btnIncludeExcel;
        private AppSvrHMI.L3Command cmdPlan;
        private System.Data.DataTable schemadsPlan;
        private System.Data.DataColumn coldsPlanL3DataTableGUID;
        private System.Data.DataColumn coldsPlanL3DataTableNAME;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Data.DataColumn coldsPlanL3DataTableJhddh;
        private System.Data.DataColumn coldsPlanL3DataTableXsddh;
        private System.Data.DataColumn coldsPlanL3DataTablepk_invbasdoc;
        private System.Data.DataColumn coldsPlanL3DataTablepk_produce;
        private System.Data.DataColumn coldsPlanL3DataTableInvcode;
        private System.Data.DataColumn coldsPlanL3DataTableInvname;
        private System.Data.DataColumn coldsPlanL3DataTableInvspec;
        private System.Data.DataColumn coldsPlanL3DataTableInvtype;
        private System.Data.DataColumn coldsPlanL3DataTableScbmid;
        private System.Data.DataColumn coldsPlanL3DataTableScbmbm;
        private System.Data.DataColumn coldsPlanL3DataTableGzzxid;
        private System.Data.DataColumn coldsPlanL3DataTableGzzxbm;
        private System.Data.DataColumn coldsPlanL3DataTableZtshow;
        private System.Data.DataColumn coldsPlanL3DataTableDdlx;
        private System.Data.DataColumn coldsPlanL3DataTableKsid;
        private System.Data.DataColumn coldsPlanL3DataTableSfjj;
        private System.Data.DataColumn coldsPlanL3DataTableJldwid;
        private System.Data.DataColumn coldsPlanL3DataTableJldwmc;
        private System.Data.DataColumn coldsPlanL3DataTableFjlid;
        private System.Data.DataColumn coldsPlanL3DataTableJhwgsl;
        private System.Data.DataColumn coldsPlanL3DataTableJhxxsl;
        private System.Data.DataColumn coldsPlanL3DataTableFjhsl;
        private System.Data.DataColumn coldsPlanL3DataTableJhksrq;
        private System.Data.DataColumn coldsPlanL3DataTableXdrq;
        private System.Data.DataColumn coldsPlanL3DataTableXqrq;
        private System.Data.DataColumn coldsPlanL3DataTablezdy1;
        private System.Data.DataColumn coldsPlanL3DataTablezdy2;
        private System.Data.DataColumn coldsPlanL3DataTablezdy3;
        private System.Data.DataColumn coldsPlanL3DataTablezdy4;
        private System.Data.DataColumn coldsPlanL3DataTablezdy5;
        private System.Data.DataColumn coldsPlanL3DataTablezyx1;
        private System.Data.DataColumn coldsPlanL3DataTablezyx2;
        private System.Data.DataColumn coldsPlanL3DataTablezyx3;
        private System.Data.DataColumn coldsPlanL3DataTablezyx4;
        private System.Data.DataColumn coldsPlanL3DataTablezyx5;
        private System.Data.DataColumn coldsPlanL3DataTablepk_corp;
        private System.Data.DataColumn coldsPlanL3DataTableGcbm;
        private System.Data.DataColumn coldsPlanL3DataTablepk_poid;
        private System.Data.DataColumn coldsPlanL3DataTableJHBM;
        private System.Data.DataColumn coldsPlanL3DataTableMRCK;
        private System.Data.DataColumn coldsPlanL3DataTableJHY;
        private System.Data.DataColumn coldsPlanL3DataTableProduct_Route;
        private System.Data.DataColumn coldsPlanL3DataTableOther_Tech_Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhddhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xsddhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkinvbasdocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkproduceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JHBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn invtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scbmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JHY;
        private System.Windows.Forms.DataGridViewTextBoxColumn scbmbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gzzxidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gzzxbmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ztshowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddlxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ksidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfjjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jldwidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jldwmcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjlidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhwgslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhxxslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fjhslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhksrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xdrqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xqrqDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pkpoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pk_invbasdoc;
    }
}