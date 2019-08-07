namespace StoreMag.BulkStore
{
    partial class BulkAppConfirmFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkAppConfirmFrm));
            this.bsBulkAppConfirm = new System.Windows.Forms.BindingSource(this.components);
            this.dsyAPPConfirm = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmdQurey = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter3 = new AppSvrHMI.L3CommandParameter();
            this.tstpDate = new buttonHide.ToolStripToriDateTimePicker();
            this.schemadsyAPPConfirm = new System.Data.DataTable();
            this.coldsyAPPConfirmL3DataTableBulk_CODE = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableAPP_TIME = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableAPP_UNITID = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableAPP_OPERATOR = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableCONFIRM_FLAG = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableCONFIRM_TIME = new System.Data.DataColumn();
            this.coldsyAPPConfirmL3DataTableCheckFlag = new System.Data.DataColumn();
            this.cmdBulkAppConfirm = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter4 = new AppSvrHMI.L3CommandParameter();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.ds = new AppSvrHMI.L3DataSet();
            this.schemadsBulkAppConfirm = new System.Data.DataTable();
            this.coldsBulkAppConfirmL3DataTableBulk_CODE = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableAMOUNT = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableAPP_TIME = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableAPP_UNITID = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableAPP_OPERATOR = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableCONFIRM_FLAG = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableCONFIRM_TIME = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableCheckFlag = new System.Data.DataColumn();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvBulkAppConfirm = new System.Windows.Forms.DataGridView();
            this.dsBulkCode = new AppSvrHMI.L3DataSet();
            this.schemadsBulkCode = new System.Data.DataTable();
            this.coldsBulkCodeL3DataTableCode = new System.Data.DataColumn();
            this.coldsBulkCodeL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsAppUnitID = new AppSvrHMI.L3DataSet();
            this.schemadsAppUnitID = new System.Data.DataTable();
            this.coldsAppUnitIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsAppUnitIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsBulkAppConfirmL3DataTableGUID = new System.Data.DataColumn();
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.checkFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bulkCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPUNITIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONFIRMFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONFIRMOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONFIRMTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkAppConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsyAPPConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsyAPPConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkAppConfirm)).BeginInit();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkAppConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppUnitID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAppUnitID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsBulkAppConfirm
            // 
            this.bsBulkAppConfirm.DataMember = "L3DataTable";
            this.bsBulkAppConfirm.DataSource = this.dsyAPPConfirm;
            // 
            // dsyAPPConfirm
            // 
            this.dsyAPPConfirm.AutoSubscribe = true;
            this.dsyAPPConfirm.DataSetName = "L3DataSet";
            this.dsyAPPConfirm.DeleteMethod = "";
            this.dsyAPPConfirm.InsertMethod = "";
            this.dsyAPPConfirm.L3DataAdapter = this.Adapter;
            this.dsyAPPConfirm.LoadEvent = "Click";
            this.dsyAPPConfirm.LoadTrigger = this.btnQuery;
            this.dsyAPPConfirm.RefreshValve = 1000;
            this.dsyAPPConfirm.SourceCommand = this.cmdQurey;
            this.dsyAPPConfirm.SourceCondition = null;
            this.dsyAPPConfirm.SourceMethod = "GetBulkAppInfor";
            this.dsyAPPConfirm.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsyAPPConfirm.SourceURI = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.dsyAPPConfirm.SubscribeTarget = null;
            this.dsyAPPConfirm.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsyAPPConfirm});
            this.dsyAPPConfirm.UpdateEvent = "Click";
            this.dsyAPPConfirm.UpdateMethod = "";
            this.dsyAPPConfirm.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            // 
            // cmdQurey
            // 
            this.cmdQurey.Adapter = null;
            this.cmdQurey.MergeReturnTarget = false;
            this.cmdQurey.Method = "";
            this.cmdQurey.Object = "";
            this.cmdQurey.Parameters.Add(this.l3CommandParameter3);
            this.cmdQurey.ReturnTarget = null;
            this.cmdQurey.ReturnTargetProperty = null;
            this.cmdQurey.Trigger = null;
            this.cmdQurey.TriggerEvent = "Click";
            // 
            // l3CommandParameter3
            // 
            this.l3CommandParameter3.AcceptAfterExecuted = false;
            this.l3CommandParameter3.ConstantValue = null;
            this.l3CommandParameter3.MergeTarget = false;
            this.l3CommandParameter3.SourceFilter = null;
            this.l3CommandParameter3.SourceObject = this.tstpDate;
            this.l3CommandParameter3.SourceProperty = "Text";
            this.l3CommandParameter3.TargetObject = null;
            this.l3CommandParameter3.TargetProperty = null;
            // 
            // tstpDate
            // 
            this.tstpDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstpDate.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.tstpDate.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.tstpDate.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.tstpDate.CustomFormat = "yyyy-MM-dd";
            this.tstpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tstpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.tstpDate.MaximumSize = new System.Drawing.Size(0, 0);
            this.tstpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.tstpDate.MinimumSize = new System.Drawing.Size(0, 0);
            this.tstpDate.Name = "tstpDate";
            this.tstpDate.Size = new System.Drawing.Size(100, 22);
            this.tstpDate.Text = "2008-10-29";
            this.tstpDate.Value = new System.DateTime(2008, 10, 29, 20, 3, 56, 515);
            // 
            // schemadsyAPPConfirm
            // 
            this.schemadsyAPPConfirm.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsyAPPConfirmL3DataTableBulk_CODE,
            this.coldsyAPPConfirmL3DataTableAMOUNT,
            this.coldsyAPPConfirmL3DataTableAPP_TIME,
            this.coldsyAPPConfirmL3DataTableAPP_UNITID,
            this.coldsyAPPConfirmL3DataTableAPP_OPERATOR,
            this.coldsyAPPConfirmL3DataTableCONFIRM_FLAG,
            this.coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR,
            this.coldsyAPPConfirmL3DataTableCONFIRM_TIME,
            this.coldsyAPPConfirmL3DataTableCheckFlag});
            this.schemadsyAPPConfirm.TableName = "L3DataTable";
            // 
            // coldsyAPPConfirmL3DataTableBulk_CODE
            // 
            this.coldsyAPPConfirmL3DataTableBulk_CODE.Caption = "BULK_CODE";
            this.coldsyAPPConfirmL3DataTableBulk_CODE.ColumnName = "Bulk_CODE";
            this.coldsyAPPConfirmL3DataTableBulk_CODE.DefaultValue = "";
            this.coldsyAPPConfirmL3DataTableBulk_CODE.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableAMOUNT
            // 
            this.coldsyAPPConfirmL3DataTableAMOUNT.Caption = "AMOUNT";
            this.coldsyAPPConfirmL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsyAPPConfirmL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsyAPPConfirmL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsyAPPConfirmL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableAPP_TIME
            // 
            this.coldsyAPPConfirmL3DataTableAPP_TIME.Caption = "APP_TIME";
            this.coldsyAPPConfirmL3DataTableAPP_TIME.ColumnName = "APP_TIME";
            this.coldsyAPPConfirmL3DataTableAPP_TIME.DataType = typeof(System.DateTime);
            this.coldsyAPPConfirmL3DataTableAPP_TIME.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableAPP_UNITID
            // 
            this.coldsyAPPConfirmL3DataTableAPP_UNITID.Caption = "APP_UNITID";
            this.coldsyAPPConfirmL3DataTableAPP_UNITID.ColumnName = "APP_UNITID";
            this.coldsyAPPConfirmL3DataTableAPP_UNITID.DefaultValue = "";
            this.coldsyAPPConfirmL3DataTableAPP_UNITID.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableAPP_OPERATOR
            // 
            this.coldsyAPPConfirmL3DataTableAPP_OPERATOR.Caption = "APP_OPERATOR";
            this.coldsyAPPConfirmL3DataTableAPP_OPERATOR.ColumnName = "APP_OPERATOR";
            this.coldsyAPPConfirmL3DataTableAPP_OPERATOR.DefaultValue = "";
            this.coldsyAPPConfirmL3DataTableAPP_OPERATOR.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableCONFIRM_FLAG
            // 
            this.coldsyAPPConfirmL3DataTableCONFIRM_FLAG.Caption = "CONFIRM_FLAG";
            this.coldsyAPPConfirmL3DataTableCONFIRM_FLAG.ColumnName = "CONFIRM_FLAG";
            this.coldsyAPPConfirmL3DataTableCONFIRM_FLAG.DefaultValue = "";
            this.coldsyAPPConfirmL3DataTableCONFIRM_FLAG.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR
            // 
            this.coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR.Caption = "CONFIRM_OPERATOR";
            this.coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR.ColumnName = "CONFIRM_OPERATOR";
            this.coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR.DefaultValue = "";
            this.coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableCONFIRM_TIME
            // 
            this.coldsyAPPConfirmL3DataTableCONFIRM_TIME.Caption = "CONFIRM_TIME";
            this.coldsyAPPConfirmL3DataTableCONFIRM_TIME.ColumnName = "CONFIRM_TIME";
            this.coldsyAPPConfirmL3DataTableCONFIRM_TIME.DataType = typeof(System.DateTime);
            this.coldsyAPPConfirmL3DataTableCONFIRM_TIME.Namespace = "";
            // 
            // coldsyAPPConfirmL3DataTableCheckFlag
            // 
            this.coldsyAPPConfirmL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsyAPPConfirmL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsyAPPConfirmL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsyAPPConfirmL3DataTableCheckFlag.Namespace = "";
            // 
            // cmdBulkAppConfirm
            // 
            this.cmdBulkAppConfirm.Adapter = this.Adapter;
            this.cmdBulkAppConfirm.MergeReturnTarget = false;
            this.cmdBulkAppConfirm.Method = "BulkAppConfirm";
            this.cmdBulkAppConfirm.Object = "XGMESLogic\\BulkStoreMag\\CBulk_Store_Mag\\S83";
            this.cmdBulkAppConfirm.Parameters.Add(this.l3CommandParameter4);
            this.cmdBulkAppConfirm.ReturnTarget = null;
            this.cmdBulkAppConfirm.ReturnTargetProperty = null;
            this.cmdBulkAppConfirm.Trigger = null;
            this.cmdBulkAppConfirm.TriggerEvent = "Click";
            // 
            // l3CommandParameter4
            // 
            this.l3CommandParameter4.AcceptAfterExecuted = false;
            this.l3CommandParameter4.ConstantValue = null;
            this.l3CommandParameter4.MergeTarget = false;
            this.l3CommandParameter4.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter4.SourceObject = this.dsyAPPConfirm;
            this.l3CommandParameter4.SourceProperty = null;
            this.l3CommandParameter4.TargetObject = null;
            this.l3CommandParameter4.TargetProperty = null;
            // 
            // l3CommandParameter1
            // 
            this.l3CommandParameter1.AcceptAfterExecuted = false;
            this.l3CommandParameter1.ConstantValue = null;
            this.l3CommandParameter1.MergeTarget = false;
            this.l3CommandParameter1.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter1.SourceObject = this.dsyAPPConfirm;
            this.l3CommandParameter1.SourceProperty = null;
            this.l3CommandParameter1.TargetObject = null;
            this.l3CommandParameter1.TargetProperty = null;
            // 
            // ds
            // 
            this.ds.AutoSubscribe = true;
            this.ds.DataSetName = "L3DataSet";
            this.ds.DeleteMethod = "";
            this.ds.InsertMethod = "";
            this.ds.L3DataAdapter = this.Adapter;
            this.ds.LoadEvent = "Click";
            this.ds.LoadTrigger = null;
            this.ds.RefreshValve = 1000;
            this.ds.SourceCommand = null;
            this.ds.SourceCondition = null;
            this.ds.SourceMethod = "GetBulkAppInfor";
            this.ds.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.ds.SourceURI = "";
            this.ds.SubscribeTarget = null;
            this.ds.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkAppConfirm});
            this.ds.UpdateEvent = "Click";
            this.ds.UpdateMethod = "";
            this.ds.UpdateTrigger = null;
            // 
            // schemadsBulkAppConfirm
            // 
            this.schemadsBulkAppConfirm.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkAppConfirmL3DataTableBulk_CODE,
            this.coldsBulkAppConfirmL3DataTableAMOUNT,
            this.coldsBulkAppConfirmL3DataTableAPP_TIME,
            this.coldsBulkAppConfirmL3DataTableAPP_UNITID,
            this.coldsBulkAppConfirmL3DataTableAPP_OPERATOR,
            this.coldsBulkAppConfirmL3DataTableCONFIRM_FLAG,
            this.coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR,
            this.coldsBulkAppConfirmL3DataTableCONFIRM_TIME,
            this.coldsBulkAppConfirmL3DataTableCheckFlag});
            this.schemadsBulkAppConfirm.TableName = "L3DataTable";
            // 
            // coldsBulkAppConfirmL3DataTableBulk_CODE
            // 
            this.coldsBulkAppConfirmL3DataTableBulk_CODE.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableBulk_CODE.ColumnName = "Bulk_CODE";
            this.coldsBulkAppConfirmL3DataTableBulk_CODE.DefaultValue = "";
            this.coldsBulkAppConfirmL3DataTableBulk_CODE.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableAMOUNT
            // 
            this.coldsBulkAppConfirmL3DataTableAMOUNT.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableAMOUNT.ColumnName = "AMOUNT";
            this.coldsBulkAppConfirmL3DataTableAMOUNT.DataType = typeof(double);
            this.coldsBulkAppConfirmL3DataTableAMOUNT.DefaultValue = 0;
            this.coldsBulkAppConfirmL3DataTableAMOUNT.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableAPP_TIME
            // 
            this.coldsBulkAppConfirmL3DataTableAPP_TIME.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableAPP_TIME.ColumnName = "APP_TIME";
            this.coldsBulkAppConfirmL3DataTableAPP_TIME.DataType = typeof(System.DateTime);
            this.coldsBulkAppConfirmL3DataTableAPP_TIME.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableAPP_UNITID
            // 
            this.coldsBulkAppConfirmL3DataTableAPP_UNITID.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableAPP_UNITID.ColumnName = "APP_UNITID";
            this.coldsBulkAppConfirmL3DataTableAPP_UNITID.DefaultValue = "";
            this.coldsBulkAppConfirmL3DataTableAPP_UNITID.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableAPP_OPERATOR
            // 
            this.coldsBulkAppConfirmL3DataTableAPP_OPERATOR.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableAPP_OPERATOR.ColumnName = "APP_OPERATOR";
            this.coldsBulkAppConfirmL3DataTableAPP_OPERATOR.DefaultValue = "";
            this.coldsBulkAppConfirmL3DataTableAPP_OPERATOR.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableCONFIRM_FLAG
            // 
            this.coldsBulkAppConfirmL3DataTableCONFIRM_FLAG.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableCONFIRM_FLAG.ColumnName = "CONFIRM_FLAG";
            this.coldsBulkAppConfirmL3DataTableCONFIRM_FLAG.DataType = typeof(int);
            this.coldsBulkAppConfirmL3DataTableCONFIRM_FLAG.DefaultValue = 0;
            this.coldsBulkAppConfirmL3DataTableCONFIRM_FLAG.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR
            // 
            this.coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR.ColumnName = "CONFIRM_OPERATOR";
            this.coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR.DefaultValue = "";
            this.coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableCONFIRM_TIME
            // 
            this.coldsBulkAppConfirmL3DataTableCONFIRM_TIME.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableCONFIRM_TIME.ColumnName = "CONFIRM_TIME";
            this.coldsBulkAppConfirmL3DataTableCONFIRM_TIME.DataType = typeof(System.DateTime);
            this.coldsBulkAppConfirmL3DataTableCONFIRM_TIME.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableCheckFlag
            // 
            this.coldsBulkAppConfirmL3DataTableCheckFlag.Caption = "OLDCOLUMN_SHOULD_BE_DELETED";
            this.coldsBulkAppConfirmL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsBulkAppConfirmL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsBulkAppConfirmL3DataTableCheckFlag.Namespace = "";
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnConfirm});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
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
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
            this.bdN1.BindingSource = this.bsBulkAppConfirm;
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
            this.btnQuery,
            this.tstpDate,
            this.toolStripLabel2});
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
            this.toolStripLabel1.Size = new System.Drawing.Size(95, 22);
            this.toolStripLabel1.Text = "               ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "日期:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvBulkAppConfirm);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 31;
            // 
            // dvBulkAppConfirm
            // 
            this.dvBulkAppConfirm.AllowUserToAddRows = false;
            this.dvBulkAppConfirm.AutoGenerateColumns = false;
            this.dvBulkAppConfirm.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBulkAppConfirm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkFlagDataGridViewTextBoxColumn,
            this.bulkCODEDataGridViewTextBoxColumn,
            this.aMOUNTDataGridViewTextBoxColumn,
            this.aPPTIMEDataGridViewTextBoxColumn,
            this.aPPUNITIDDataGridViewTextBoxColumn,
            this.aPPOPERATORDataGridViewTextBoxColumn,
            this.cONFIRMFLAGDataGridViewTextBoxColumn,
            this.cONFIRMOPERATORDataGridViewTextBoxColumn,
            this.cONFIRMTIMEDataGridViewTextBoxColumn});
            this.dvBulkAppConfirm.DataSource = this.bsBulkAppConfirm;
            this.dvBulkAppConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvBulkAppConfirm.Location = new System.Drawing.Point(0, 0);
            this.dvBulkAppConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.dvBulkAppConfirm.Name = "dvBulkAppConfirm";
            this.dvBulkAppConfirm.RowHeadersVisible = false;
            this.dvBulkAppConfirm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvBulkAppConfirm.RowTemplate.Height = 23;
            this.dvBulkAppConfirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dvBulkAppConfirm.Size = new System.Drawing.Size(1000, 632);
            this.dvBulkAppConfirm.TabIndex = 31;
            // 
            // dsBulkCode
            // 
            this.dsBulkCode.AutoSubscribe = true;
            this.dsBulkCode.DataSetName = "L3DataSet";
            this.dsBulkCode.DeleteMethod = null;
            this.dsBulkCode.InsertMethod = null;
            this.dsBulkCode.L3DataAdapter = this.Adapter;
            this.dsBulkCode.LoadEvent = "Click";
            this.dsBulkCode.LoadTrigger = null;
            this.dsBulkCode.RefreshValve = 1000;
            this.dsBulkCode.SourceCommand = null;
            this.dsBulkCode.SourceCondition = "CODE_GROUP = \'Bulk_CODE\' and CODE is not null";
            this.dsBulkCode.SourceMethod = "";
            this.dsBulkCode.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsBulkCode.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsBulkCode.SubscribeTarget = null;
            this.dsBulkCode.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsBulkCode});
            this.dsBulkCode.UpdateEvent = "Click";
            this.dsBulkCode.UpdateMethod = null;
            this.dsBulkCode.UpdateTrigger = null;
            // 
            // schemadsBulkCode
            // 
            this.schemadsBulkCode.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsBulkCodeL3DataTableCode,
            this.coldsBulkCodeL3DataTableCode_Des});
            this.schemadsBulkCode.TableName = "L3DataTable";
            // 
            // coldsBulkCodeL3DataTableCode
            // 
            this.coldsBulkCodeL3DataTableCode.Caption = "Code";
            this.coldsBulkCodeL3DataTableCode.ColumnName = "Code";
            this.coldsBulkCodeL3DataTableCode.Namespace = "";
            // 
            // coldsBulkCodeL3DataTableCode_Des
            // 
            this.coldsBulkCodeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsBulkCodeL3DataTableCode_Des.Namespace = "";
            // 
            // dsAppUnitID
            // 
            this.dsAppUnitID.AutoSubscribe = true;
            this.dsAppUnitID.DataSetName = "L3DataSet";
            this.dsAppUnitID.DeleteMethod = null;
            this.dsAppUnitID.InsertMethod = null;
            this.dsAppUnitID.L3DataAdapter = this.Adapter;
            this.dsAppUnitID.LoadEvent = "Click";
            this.dsAppUnitID.LoadTrigger = null;
            this.dsAppUnitID.RefreshValve = 1000;
            this.dsAppUnitID.SourceCommand = null;
            this.dsAppUnitID.SourceCondition = "CODE_GROUP = \'BulkArea\' and CODE is not null";
            this.dsAppUnitID.SourceMethod = "";
            this.dsAppUnitID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsAppUnitID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsAppUnitID.SubscribeTarget = null;
            this.dsAppUnitID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsAppUnitID});
            this.dsAppUnitID.UpdateEvent = "Click";
            this.dsAppUnitID.UpdateMethod = null;
            this.dsAppUnitID.UpdateTrigger = null;
            // 
            // schemadsAppUnitID
            // 
            this.schemadsAppUnitID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsAppUnitIDL3DataTableCode,
            this.coldsAppUnitIDL3DataTableCode_Des});
            this.schemadsAppUnitID.TableName = "L3DataTable";
            // 
            // coldsAppUnitIDL3DataTableCode
            // 
            this.coldsAppUnitIDL3DataTableCode.Caption = "Code";
            this.coldsAppUnitIDL3DataTableCode.ColumnName = "Code";
            this.coldsAppUnitIDL3DataTableCode.Namespace = "";
            // 
            // coldsAppUnitIDL3DataTableCode_Des
            // 
            this.coldsAppUnitIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsAppUnitIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsAppUnitIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsBulkAppConfirmL3DataTableGUID
            // 
            this.coldsBulkAppConfirmL3DataTableGUID.Caption = "GUID";
            this.coldsBulkAppConfirmL3DataTableGUID.ColumnName = "GUID";
            this.coldsBulkAppConfirmL3DataTableGUID.Namespace = "";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = "CheckFlag = 1";
            this.l3CommandParameter2.SourceObject = this.dsyAPPConfirm;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
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
            // 
            // bulkCODEDataGridViewTextBoxColumn
            // 
            this.bulkCODEDataGridViewTextBoxColumn.DataPropertyName = "Bulk_CODE";
            this.bulkCODEDataGridViewTextBoxColumn.HeaderText = "合金代码";
            this.bulkCODEDataGridViewTextBoxColumn.Name = "bulkCODEDataGridViewTextBoxColumn";
            // 
            // aMOUNTDataGridViewTextBoxColumn
            // 
            this.aMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMOUNT";
            this.aMOUNTDataGridViewTextBoxColumn.HeaderText = "材料量";
            this.aMOUNTDataGridViewTextBoxColumn.Name = "aMOUNTDataGridViewTextBoxColumn";
            // 
            // aPPTIMEDataGridViewTextBoxColumn
            // 
            this.aPPTIMEDataGridViewTextBoxColumn.DataPropertyName = "APP_TIME";
            this.aPPTIMEDataGridViewTextBoxColumn.HeaderText = "接收时间";
            this.aPPTIMEDataGridViewTextBoxColumn.Name = "aPPTIMEDataGridViewTextBoxColumn";
            // 
            // aPPUNITIDDataGridViewTextBoxColumn
            // 
            this.aPPUNITIDDataGridViewTextBoxColumn.DataPropertyName = "APP_UNITID";
            this.aPPUNITIDDataGridViewTextBoxColumn.HeaderText = "接收时间";
            this.aPPUNITIDDataGridViewTextBoxColumn.Name = "aPPUNITIDDataGridViewTextBoxColumn";
            // 
            // aPPOPERATORDataGridViewTextBoxColumn
            // 
            this.aPPOPERATORDataGridViewTextBoxColumn.DataPropertyName = "APP_OPERATOR";
            this.aPPOPERATORDataGridViewTextBoxColumn.HeaderText = "申请人";
            this.aPPOPERATORDataGridViewTextBoxColumn.Name = "aPPOPERATORDataGridViewTextBoxColumn";
            // 
            // cONFIRMFLAGDataGridViewTextBoxColumn
            // 
            this.cONFIRMFLAGDataGridViewTextBoxColumn.DataPropertyName = "CONFIRM_FLAG";
            this.cONFIRMFLAGDataGridViewTextBoxColumn.HeaderText = "确认标记";
            this.cONFIRMFLAGDataGridViewTextBoxColumn.Name = "cONFIRMFLAGDataGridViewTextBoxColumn";
            // 
            // cONFIRMOPERATORDataGridViewTextBoxColumn
            // 
            this.cONFIRMOPERATORDataGridViewTextBoxColumn.DataPropertyName = "CONFIRM_OPERATOR";
            this.cONFIRMOPERATORDataGridViewTextBoxColumn.HeaderText = "确认人";
            this.cONFIRMOPERATORDataGridViewTextBoxColumn.Name = "cONFIRMOPERATORDataGridViewTextBoxColumn";
            // 
            // cONFIRMTIMEDataGridViewTextBoxColumn
            // 
            this.cONFIRMTIMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cONFIRMTIMEDataGridViewTextBoxColumn.DataPropertyName = "CONFIRM_TIME";
            this.cONFIRMTIMEDataGridViewTextBoxColumn.HeaderText = "接收时间";
            this.cONFIRMTIMEDataGridViewTextBoxColumn.Name = "cONFIRMTIMEDataGridViewTextBoxColumn";
            // 
            // BulkAppConfirmFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bdN1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BulkAppConfirmFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "散状料申请确认";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BulkAppConfirmFrm_FormClosing);
            this.Load += new System.EventHandler(this.BulkAppConfirmFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsBulkAppConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsyAPPConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsyAPPConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkAppConfirm)).EndInit();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvBulkAppConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsBulkCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAppUnitID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsAppUnitID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet ds;
        private System.Windows.Forms.BindingSource bsBulkAppConfirm;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvBulkAppConfirm;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker tstpDate;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Data.DataTable schemadsBulkAppConfirm;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableBulk_CODE;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableAMOUNT;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableAPP_TIME;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableAPP_UNITID;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableAPP_OPERATOR;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableCONFIRM_FLAG;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableCONFIRM_OPERATOR;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableCONFIRM_TIME;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableCheckFlag;
        private AppSvrHMI.L3Command cmdBulkAppConfirm;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private AppSvrHMI.L3DataSet dsBulkCode;
        private System.Data.DataTable schemadsBulkCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode;
        private System.Data.DataColumn coldsBulkCodeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsAppUnitID;
        private System.Data.DataTable schemadsAppUnitID;
        private System.Data.DataColumn coldsAppUnitIDL3DataTableCode;
        private System.Data.DataColumn coldsAppUnitIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsBulkAppConfirmL3DataTableGUID;
        private AppSvrHMI.L3DataSet dsyAPPConfirm;
        private System.Data.DataTable schemadsyAPPConfirm;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableBulk_CODE;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableAMOUNT;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableAPP_TIME;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableAPP_UNITID;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableAPP_OPERATOR;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableCONFIRM_FLAG;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableCONFIRM_OPERATOR;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableCONFIRM_TIME;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private AppSvrHMI.L3Command cmdQurey;
        private AppSvrHMI.L3CommandParameter l3CommandParameter3;
        private System.Data.DataColumn coldsyAPPConfirmL3DataTableCheckFlag;
        private AppSvrHMI.L3CommandParameter l3CommandParameter4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkFlagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulkCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPUNITIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONFIRMFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONFIRMOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONFIRMTIMEDataGridViewTextBoxColumn;
    }
}