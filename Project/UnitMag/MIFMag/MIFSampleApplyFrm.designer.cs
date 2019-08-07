namespace UnitMag.MIFMag
{
    partial class MIFSampleApplyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MIFSampleApplyFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnToLab = new System.Windows.Forms.ToolStripButton();
            this.bnIronLadle = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsSampleApply = new System.Windows.Forms.BindingSource(this.components);
            this.dsSampleApply = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdSampleApply = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpSampleApply = new AppSvrHMI.L3CommandParameter();
            this.schemadsSampleApply = new System.Data.DataTable();
            this.coldsSampleApplyL3DataTableAPPID = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSAMPLE_CODE = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSAMPLE_ADDRESS = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSAMPLE_TYPE = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSAMPLE_COUNT = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSAMPLE_DATE = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableFIN_PROD_FLAG = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableASIS_FLAG = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableTREATY = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableBACK_FLAG = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableBACK_DATE = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableRESAMPLE_FLAG = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableRESAMPLE_REASON = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableRESAMPLE_DATE = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableSENDFLAG = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableRESAMPLED = new System.Data.DataColumn();
            this.coldsSampleApplyL3DataTableCheckFlag = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvSampleApply = new System.Windows.Forms.DataGridView();
            this.CheckFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.APPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAMPLECODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAMPLEADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleAddr = new AppSvrHMI.L3DataSet();
            this.schemadsSampleAddr = new System.Data.DataTable();
            this.coldsSampleAddrL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleAddrL3DataTableCode_Des = new System.Data.DataColumn();
            this.sAMPLETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsSampleType = new AppSvrHMI.L3DataSet();
            this.schemadsSampleType = new System.Data.DataTable();
            this.coldsSampleTypeL3DataTableCode = new System.Data.DataColumn();
            this.coldsSampleTypeL3DataTableCode_Des = new System.Data.DataColumn();
            this.sAMPLECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAMPLEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINPRODFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSISFLAGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tREATYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BACK_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bACKDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESAMPLE_FLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESAMPLE_REASON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESAMPLEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENDFLAG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESAMPLEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsToLab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnConfirmSampleAgain = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirmMakeAgain = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdToLab = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpToLab = new AppSvrHMI.L3CommandParameter();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnIronLadle)).BeginInit();
            this.bnIronLadle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleApply)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvSampleApply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).BeginInit();
            this.cmsToLab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel,
            this.btnToLab});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(998, 36);
            this.tSp1.TabIndex = 29;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 33);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 33);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(68, 33);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(68, 33);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 33);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.MIFSampleApplyFrm_Load);
            // 
            // btnToLab
            // 
            this.btnToLab.Image = ((System.Drawing.Image)(resources.GetObject("btnToLab.Image")));
            this.btnToLab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToLab.Name = "btnToLab";
            this.btnToLab.Size = new System.Drawing.Size(92, 33);
            this.btnToLab.Text = "去检化验";
            this.btnToLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToLab.Click += new System.EventHandler(this.btnToLab_Click);
            // 
            // bnIronLadle
            // 
            this.bnIronLadle.AddNewItem = null;
            this.bnIronLadle.AutoSize = false;
            this.bnIronLadle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnIronLadle.BackgroundImage")));
            this.bnIronLadle.BindingSource = this.bsSampleApply;
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
            this.toolStripLabel1});
            this.bnIronLadle.Location = new System.Drawing.Point(0, 36);
            this.bnIronLadle.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnIronLadle.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnIronLadle.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnIronLadle.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnIronLadle.Name = "bnIronLadle";
            this.bnIronLadle.PositionItem = this.bindingNavigatorPositionItem;
            this.bnIronLadle.Size = new System.Drawing.Size(998, 25);
            this.bnIronLadle.TabIndex = 30;
            this.bnIronLadle.Text = "bindingNavigator1";
            // 
            // bsSampleApply
            // 
            this.bsSampleApply.DataMember = "L3DataTable";
            this.bsSampleApply.DataSource = this.dsSampleApply;
            // 
            // dsSampleApply
            // 
            this.dsSampleApply.AutoLoad = true;
            this.dsSampleApply.AutoSubscribe = false;
            this.dsSampleApply.DataSetName = "L3DataSet";
            this.dsSampleApply.DeleteMethod = "DeleteLabSheet";
            this.dsSampleApply.InsertMethod = "NewLabSheet";
            this.dsSampleApply.L3DataAdapter = this.Adapter;
            this.dsSampleApply.LoadEvent = "Click";
            this.dsSampleApply.LoadTrigger = null;
            this.dsSampleApply.RefreshValve = 1000;
            this.dsSampleApply.SourceCommand = this.cmdSampleApply;
            this.dsSampleApply.SourceCondition = null;
            this.dsSampleApply.SourceMethod = "";
            this.dsSampleApply.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsSampleApply.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.dsSampleApply.SubscribeTarget = null;
            this.dsSampleApply.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleApply});
            this.dsSampleApply.UpdateEvent = "Click";
            this.dsSampleApply.UpdateMethod = "ModifyLabSheet";
            this.dsSampleApply.UpdateTrigger = null;
            this.dsSampleApply.OnDataLoaded += new AppSvrHMI.Delegate_OnDataLoaded(this.dsSampleApply_OnDataLoaded);
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdSampleApply
            // 
            this.cmdSampleApply.Adapter = this.Adapter;
            this.cmdSampleApply.MergeReturnTarget = false;
            this.cmdSampleApply.Method = "GetSampleApplyData";
            this.cmdSampleApply.Object = "XGMESLogic\\QualityMag\\CQuality_Mag\\Quality_Mag";
            this.cmdSampleApply.Parameters.Add(this.l3cmdpSampleApply);
            this.cmdSampleApply.ReturnTarget = this.dsSampleApply;
            this.cmdSampleApply.ReturnTargetProperty = null;
            this.cmdSampleApply.Trigger = null;
            this.cmdSampleApply.TriggerEvent = "Click";
            // 
            // l3cmdpSampleApply
            // 
            this.l3cmdpSampleApply.AcceptAfterExecuted = false;
            this.l3cmdpSampleApply.ConstantValue = null;
            this.l3cmdpSampleApply.MergeTarget = false;
            this.l3cmdpSampleApply.SourceFilter = null;
            this.l3cmdpSampleApply.SourceObject = null;
            this.l3cmdpSampleApply.SourceProperty = null;
            this.l3cmdpSampleApply.TargetObject = null;
            this.l3cmdpSampleApply.TargetProperty = null;
            // 
            // schemadsSampleApply
            // 
            this.schemadsSampleApply.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleApplyL3DataTableAPPID,
            this.coldsSampleApplyL3DataTableHEATID,
            this.coldsSampleApplyL3DataTableSAMPLE_CODE,
            this.coldsSampleApplyL3DataTableSAMPLE_ADDRESS,
            this.coldsSampleApplyL3DataTableSAMPLE_TYPE,
            this.coldsSampleApplyL3DataTableSAMPLE_COUNT,
            this.coldsSampleApplyL3DataTableSAMPLE_DATE,
            this.coldsSampleApplyL3DataTableFIN_PROD_FLAG,
            this.coldsSampleApplyL3DataTableASIS_FLAG,
            this.coldsSampleApplyL3DataTableSTEELGRADE,
            this.coldsSampleApplyL3DataTableTREATY,
            this.coldsSampleApplyL3DataTableBACK_FLAG,
            this.coldsSampleApplyL3DataTableBACK_DATE,
            this.coldsSampleApplyL3DataTableRESAMPLE_FLAG,
            this.coldsSampleApplyL3DataTableRESAMPLE_REASON,
            this.coldsSampleApplyL3DataTableRESAMPLE_DATE,
            this.coldsSampleApplyL3DataTableSENDFLAG,
            this.coldsSampleApplyL3DataTableRESAMPLED,
            this.coldsSampleApplyL3DataTableCheckFlag});
            this.schemadsSampleApply.TableName = "L3DataTable";
            // 
            // coldsSampleApplyL3DataTableAPPID
            // 
            this.coldsSampleApplyL3DataTableAPPID.Caption = "APPID";
            this.coldsSampleApplyL3DataTableAPPID.ColumnName = "APPID";
            this.coldsSampleApplyL3DataTableAPPID.DefaultValue = "";
            this.coldsSampleApplyL3DataTableAPPID.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableHEATID
            // 
            this.coldsSampleApplyL3DataTableHEATID.Caption = "HEATID";
            this.coldsSampleApplyL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsSampleApplyL3DataTableHEATID.DefaultValue = "";
            this.coldsSampleApplyL3DataTableHEATID.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSAMPLE_CODE
            // 
            this.coldsSampleApplyL3DataTableSAMPLE_CODE.Caption = "SAMPLE_CODE";
            this.coldsSampleApplyL3DataTableSAMPLE_CODE.ColumnName = "SAMPLE_CODE";
            this.coldsSampleApplyL3DataTableSAMPLE_CODE.DefaultValue = "";
            this.coldsSampleApplyL3DataTableSAMPLE_CODE.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSAMPLE_ADDRESS
            // 
            this.coldsSampleApplyL3DataTableSAMPLE_ADDRESS.Caption = "SAMPLE_ADDRESS";
            this.coldsSampleApplyL3DataTableSAMPLE_ADDRESS.ColumnName = "SAMPLE_ADDRESS";
            this.coldsSampleApplyL3DataTableSAMPLE_ADDRESS.DefaultValue = "";
            this.coldsSampleApplyL3DataTableSAMPLE_ADDRESS.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSAMPLE_TYPE
            // 
            this.coldsSampleApplyL3DataTableSAMPLE_TYPE.Caption = "SAMPLE_TYPE";
            this.coldsSampleApplyL3DataTableSAMPLE_TYPE.ColumnName = "SAMPLE_TYPE";
            this.coldsSampleApplyL3DataTableSAMPLE_TYPE.DefaultValue = "";
            this.coldsSampleApplyL3DataTableSAMPLE_TYPE.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSAMPLE_COUNT
            // 
            this.coldsSampleApplyL3DataTableSAMPLE_COUNT.Caption = "SAMPLE_COUNT";
            this.coldsSampleApplyL3DataTableSAMPLE_COUNT.ColumnName = "SAMPLE_COUNT";
            this.coldsSampleApplyL3DataTableSAMPLE_COUNT.DefaultValue = "";
            this.coldsSampleApplyL3DataTableSAMPLE_COUNT.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSAMPLE_DATE
            // 
            this.coldsSampleApplyL3DataTableSAMPLE_DATE.Caption = "SAMPLE_DATE";
            this.coldsSampleApplyL3DataTableSAMPLE_DATE.ColumnName = "SAMPLE_DATE";
            this.coldsSampleApplyL3DataTableSAMPLE_DATE.DataType = typeof(System.DateTime);
            this.coldsSampleApplyL3DataTableSAMPLE_DATE.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableFIN_PROD_FLAG
            // 
            this.coldsSampleApplyL3DataTableFIN_PROD_FLAG.Caption = "FIN_PROD_FLAG";
            this.coldsSampleApplyL3DataTableFIN_PROD_FLAG.ColumnName = "FIN_PROD_FLAG";
            this.coldsSampleApplyL3DataTableFIN_PROD_FLAG.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableFIN_PROD_FLAG.DefaultValue = 0;
            this.coldsSampleApplyL3DataTableFIN_PROD_FLAG.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableASIS_FLAG
            // 
            this.coldsSampleApplyL3DataTableASIS_FLAG.Caption = "ASIS_FLAG";
            this.coldsSampleApplyL3DataTableASIS_FLAG.ColumnName = "ASIS_FLAG";
            this.coldsSampleApplyL3DataTableASIS_FLAG.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableASIS_FLAG.DefaultValue = 0;
            this.coldsSampleApplyL3DataTableASIS_FLAG.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSTEELGRADE
            // 
            this.coldsSampleApplyL3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coldsSampleApplyL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsSampleApplyL3DataTableSTEELGRADE.DefaultValue = "";
            this.coldsSampleApplyL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableTREATY
            // 
            this.coldsSampleApplyL3DataTableTREATY.Caption = "TREATY";
            this.coldsSampleApplyL3DataTableTREATY.ColumnName = "TREATY";
            this.coldsSampleApplyL3DataTableTREATY.DefaultValue = "";
            this.coldsSampleApplyL3DataTableTREATY.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableBACK_FLAG
            // 
            this.coldsSampleApplyL3DataTableBACK_FLAG.Caption = "BACK_FLAG";
            this.coldsSampleApplyL3DataTableBACK_FLAG.ColumnName = "BACK_FLAG";
            this.coldsSampleApplyL3DataTableBACK_FLAG.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableBACK_FLAG.DefaultValue = 0;
            this.coldsSampleApplyL3DataTableBACK_FLAG.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableBACK_DATE
            // 
            this.coldsSampleApplyL3DataTableBACK_DATE.Caption = "BACK_DATE";
            this.coldsSampleApplyL3DataTableBACK_DATE.ColumnName = "BACK_DATE";
            this.coldsSampleApplyL3DataTableBACK_DATE.DataType = typeof(System.DateTime);
            this.coldsSampleApplyL3DataTableBACK_DATE.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableRESAMPLE_FLAG
            // 
            this.coldsSampleApplyL3DataTableRESAMPLE_FLAG.Caption = "RESAMPLE_FLAG";
            this.coldsSampleApplyL3DataTableRESAMPLE_FLAG.ColumnName = "RESAMPLE_FLAG";
            this.coldsSampleApplyL3DataTableRESAMPLE_FLAG.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableRESAMPLE_FLAG.DefaultValue = 0;
            this.coldsSampleApplyL3DataTableRESAMPLE_FLAG.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableRESAMPLE_REASON
            // 
            this.coldsSampleApplyL3DataTableRESAMPLE_REASON.Caption = "RESAMPLE_REASON";
            this.coldsSampleApplyL3DataTableRESAMPLE_REASON.ColumnName = "RESAMPLE_REASON";
            this.coldsSampleApplyL3DataTableRESAMPLE_REASON.DefaultValue = "";
            this.coldsSampleApplyL3DataTableRESAMPLE_REASON.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableRESAMPLE_DATE
            // 
            this.coldsSampleApplyL3DataTableRESAMPLE_DATE.Caption = "RESAMPLE_DATE";
            this.coldsSampleApplyL3DataTableRESAMPLE_DATE.ColumnName = "RESAMPLE_DATE";
            this.coldsSampleApplyL3DataTableRESAMPLE_DATE.DataType = typeof(System.DateTime);
            this.coldsSampleApplyL3DataTableRESAMPLE_DATE.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableSENDFLAG
            // 
            this.coldsSampleApplyL3DataTableSENDFLAG.Caption = "SENDFLAG";
            this.coldsSampleApplyL3DataTableSENDFLAG.ColumnName = "SENDFLAG";
            this.coldsSampleApplyL3DataTableSENDFLAG.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableSENDFLAG.DefaultValue = 0;
            this.coldsSampleApplyL3DataTableSENDFLAG.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableRESAMPLED
            // 
            this.coldsSampleApplyL3DataTableRESAMPLED.Caption = "RESAMPLED";
            this.coldsSampleApplyL3DataTableRESAMPLED.ColumnName = "RESAMPLED";
            this.coldsSampleApplyL3DataTableRESAMPLED.DataType = typeof(int);
            this.coldsSampleApplyL3DataTableRESAMPLED.DefaultValue = 0;
            this.coldsSampleApplyL3DataTableRESAMPLED.Namespace = "";
            // 
            // coldsSampleApplyL3DataTableCheckFlag
            // 
            this.coldsSampleApplyL3DataTableCheckFlag.Caption = "CheckFlag";
            this.coldsSampleApplyL3DataTableCheckFlag.ColumnName = "CheckFlag";
            this.coldsSampleApplyL3DataTableCheckFlag.DataType = typeof(short);
            this.coldsSampleApplyL3DataTableCheckFlag.DefaultValue = ((short)(0));
            this.coldsSampleApplyL3DataTableCheckFlag.Namespace = "";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvSampleApply);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 61);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(998, 226);
            this.hmiRootPanel1.TabIndex = 31;
            // 
            // dvSampleApply
            // 
            this.dvSampleApply.AllowUserToAddRows = false;
            this.dvSampleApply.AutoGenerateColumns = false;
            this.dvSampleApply.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvSampleApply.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvSampleApply.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvSampleApply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckFlag,
            this.APPID,
            this.hEATIDDataGridViewTextBoxColumn,
            this.sAMPLECODEDataGridViewTextBoxColumn,
            this.sAMPLEADDRESSDataGridViewTextBoxColumn,
            this.sAMPLETYPEDataGridViewTextBoxColumn,
            this.sAMPLECOUNTDataGridViewTextBoxColumn,
            this.sAMPLEDATEDataGridViewTextBoxColumn,
            this.fINPRODFLAGDataGridViewTextBoxColumn,
            this.aSISFLAGDataGridViewTextBoxColumn,
            this.sTEELGRADEDataGridViewTextBoxColumn,
            this.tREATYDataGridViewTextBoxColumn,
            this.BACK_FLAG,
            this.bACKDATEDataGridViewTextBoxColumn,
            this.RESAMPLE_FLAG,
            this.RESAMPLE_REASON,
            this.rESAMPLEDATEDataGridViewTextBoxColumn,
            this.SENDFLAG,
            this.rESAMPLEDDataGridViewTextBoxColumn});
            this.dvSampleApply.ContextMenuStrip = this.cmsToLab;
            this.dvSampleApply.DataSource = this.bsSampleApply;
            this.dvSampleApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvSampleApply.Location = new System.Drawing.Point(0, 0);
            this.dvSampleApply.MultiSelect = false;
            this.dvSampleApply.Name = "dvSampleApply";
            this.dvSampleApply.RowTemplate.Height = 23;
            this.dvSampleApply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvSampleApply.Size = new System.Drawing.Size(998, 226);
            this.dvSampleApply.TabIndex = 0;
            this.dvSampleApply.Sorted += new System.EventHandler(this.dvSampleApply_Sorted);
            this.dvSampleApply.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvSampleApply_CellDoubleClick);
            this.dvSampleApply.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dvSampleApply_RowContextMenuStripNeeded);
            this.dvSampleApply.CurrentCellDirtyStateChanged += new System.EventHandler(this.dvSampleApply_CurrentCellDirtyStateChanged);
            this.dvSampleApply.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvSampleApply_DataError);
            this.dvSampleApply.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvSampleApply_DataBindingComplete);
            // 
            // CheckFlag
            // 
            this.CheckFlag.DataPropertyName = "CheckFlag";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.CheckFlag.DefaultCellStyle = dataGridViewCellStyle2;
            this.CheckFlag.FalseValue = "0";
            this.CheckFlag.HeaderText = "选择";
            this.CheckFlag.IndeterminateValue = "0";
            this.CheckFlag.Name = "CheckFlag";
            this.CheckFlag.TrueValue = "1";
            this.CheckFlag.Width = 35;
            // 
            // APPID
            // 
            this.APPID.DataPropertyName = "APPID";
            this.APPID.HeaderText = "委托单编号";
            this.APPID.Name = "APPID";
            this.APPID.ReadOnly = true;
            this.APPID.Width = 90;
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // sAMPLECODEDataGridViewTextBoxColumn
            // 
            this.sAMPLECODEDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_CODE";
            this.sAMPLECODEDataGridViewTextBoxColumn.HeaderText = "试样编码";
            this.sAMPLECODEDataGridViewTextBoxColumn.Name = "sAMPLECODEDataGridViewTextBoxColumn";
            this.sAMPLECODEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLECODEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sAMPLEADDRESSDataGridViewTextBoxColumn
            // 
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_ADDRESS";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.DataSource = this.dsSampleAddr;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.HeaderText = "取样地点";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.Name = "sAMPLEADDRESSDataGridViewTextBoxColumn";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sAMPLEADDRESSDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsSampleAddr
            // 
            this.dsSampleAddr.AutoLoad = true;
            this.dsSampleAddr.AutoSubscribe = false;
            this.dsSampleAddr.DataSetName = "L3DataSet";
            this.dsSampleAddr.DeleteMethod = null;
            this.dsSampleAddr.InsertMethod = null;
            this.dsSampleAddr.L3DataAdapter = this.Adapter;
            this.dsSampleAddr.LoadEvent = "Click";
            this.dsSampleAddr.LoadTrigger = null;
            this.dsSampleAddr.RefreshValve = 1000;
            this.dsSampleAddr.SourceCommand = null;
            this.dsSampleAddr.SourceCondition = "Code_Group = \'QA_Sample_Addr\'";
            this.dsSampleAddr.SourceMethod = "";
            this.dsSampleAddr.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleAddr.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleAddr.SubscribeTarget = null;
            this.dsSampleAddr.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleAddr});
            this.dsSampleAddr.UpdateEvent = "Click";
            this.dsSampleAddr.UpdateMethod = null;
            this.dsSampleAddr.UpdateTrigger = null;
            // 
            // schemadsSampleAddr
            // 
            this.schemadsSampleAddr.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleAddrL3DataTableCode,
            this.coldsSampleAddrL3DataTableCode_Des});
            this.schemadsSampleAddr.TableName = "L3DataTable";
            // 
            // coldsSampleAddrL3DataTableCode
            // 
            this.coldsSampleAddrL3DataTableCode.Caption = "Code";
            this.coldsSampleAddrL3DataTableCode.ColumnName = "Code";
            this.coldsSampleAddrL3DataTableCode.Namespace = "";
            // 
            // coldsSampleAddrL3DataTableCode_Des
            // 
            this.coldsSampleAddrL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleAddrL3DataTableCode_Des.Namespace = "";
            // 
            // sAMPLETYPEDataGridViewTextBoxColumn
            // 
            this.sAMPLETYPEDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_TYPE";
            this.sAMPLETYPEDataGridViewTextBoxColumn.DataSource = this.dsSampleType;
            this.sAMPLETYPEDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sAMPLETYPEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sAMPLETYPEDataGridViewTextBoxColumn.HeaderText = "试样类别";
            this.sAMPLETYPEDataGridViewTextBoxColumn.Name = "sAMPLETYPEDataGridViewTextBoxColumn";
            this.sAMPLETYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLETYPEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sAMPLETYPEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sAMPLETYPEDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sAMPLETYPEDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsSampleType
            // 
            this.dsSampleType.AutoLoad = true;
            this.dsSampleType.AutoSubscribe = false;
            this.dsSampleType.DataSetName = "L3DataSet";
            this.dsSampleType.DeleteMethod = null;
            this.dsSampleType.InsertMethod = null;
            this.dsSampleType.L3DataAdapter = this.Adapter;
            this.dsSampleType.LoadEvent = "Click";
            this.dsSampleType.LoadTrigger = null;
            this.dsSampleType.RefreshValve = 1000;
            this.dsSampleType.SourceCommand = null;
            this.dsSampleType.SourceCondition = "Code_Group =  \'QA_Sample_Type\'";
            this.dsSampleType.SourceMethod = "";
            this.dsSampleType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsSampleType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsSampleType.SubscribeTarget = null;
            this.dsSampleType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsSampleType});
            this.dsSampleType.UpdateEvent = "Click";
            this.dsSampleType.UpdateMethod = null;
            this.dsSampleType.UpdateTrigger = null;
            // 
            // schemadsSampleType
            // 
            this.schemadsSampleType.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsSampleTypeL3DataTableCode,
            this.coldsSampleTypeL3DataTableCode_Des});
            this.schemadsSampleType.TableName = "L3DataTable";
            // 
            // coldsSampleTypeL3DataTableCode
            // 
            this.coldsSampleTypeL3DataTableCode.Caption = "Code";
            this.coldsSampleTypeL3DataTableCode.ColumnName = "Code";
            this.coldsSampleTypeL3DataTableCode.Namespace = "";
            // 
            // coldsSampleTypeL3DataTableCode_Des
            // 
            this.coldsSampleTypeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsSampleTypeL3DataTableCode_Des.Namespace = "";
            // 
            // sAMPLECOUNTDataGridViewTextBoxColumn
            // 
            this.sAMPLECOUNTDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_COUNT";
            this.sAMPLECOUNTDataGridViewTextBoxColumn.HeaderText = "取样次数";
            this.sAMPLECOUNTDataGridViewTextBoxColumn.Name = "sAMPLECOUNTDataGridViewTextBoxColumn";
            this.sAMPLECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLECOUNTDataGridViewTextBoxColumn.Width = 78;
            // 
            // sAMPLEDATEDataGridViewTextBoxColumn
            // 
            this.sAMPLEDATEDataGridViewTextBoxColumn.DataPropertyName = "SAMPLE_DATE";
            this.sAMPLEDATEDataGridViewTextBoxColumn.HeaderText = "取样时间";
            this.sAMPLEDATEDataGridViewTextBoxColumn.Name = "sAMPLEDATEDataGridViewTextBoxColumn";
            this.sAMPLEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sAMPLEDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // fINPRODFLAGDataGridViewTextBoxColumn
            // 
            this.fINPRODFLAGDataGridViewTextBoxColumn.DataPropertyName = "FIN_PROD_FLAG";
            this.fINPRODFLAGDataGridViewTextBoxColumn.HeaderText = "成品样标志";
            this.fINPRODFLAGDataGridViewTextBoxColumn.Name = "fINPRODFLAGDataGridViewTextBoxColumn";
            this.fINPRODFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.fINPRODFLAGDataGridViewTextBoxColumn.Width = 90;
            // 
            // aSISFLAGDataGridViewTextBoxColumn
            // 
            this.aSISFLAGDataGridViewTextBoxColumn.DataPropertyName = "ASIS_FLAG";
            this.aSISFLAGDataGridViewTextBoxColumn.HeaderText = "正副样标志";
            this.aSISFLAGDataGridViewTextBoxColumn.Name = "aSISFLAGDataGridViewTextBoxColumn";
            this.aSISFLAGDataGridViewTextBoxColumn.ReadOnly = true;
            this.aSISFLAGDataGridViewTextBoxColumn.Width = 90;
            // 
            // sTEELGRADEDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADE";
            this.sTEELGRADEDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.sTEELGRADEDataGridViewTextBoxColumn.Name = "sTEELGRADEDataGridViewTextBoxColumn";
            this.sTEELGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTEELGRADEDataGridViewTextBoxColumn.Width = 54;
            // 
            // tREATYDataGridViewTextBoxColumn
            // 
            this.tREATYDataGridViewTextBoxColumn.DataPropertyName = "TREATY";
            this.tREATYDataGridViewTextBoxColumn.HeaderText = "协议";
            this.tREATYDataGridViewTextBoxColumn.Name = "tREATYDataGridViewTextBoxColumn";
            this.tREATYDataGridViewTextBoxColumn.ReadOnly = true;
            this.tREATYDataGridViewTextBoxColumn.Width = 54;
            // 
            // BACK_FLAG
            // 
            this.BACK_FLAG.DataPropertyName = "BACK_FLAG";
            this.BACK_FLAG.HeaderText = "回退标志";
            this.BACK_FLAG.Name = "BACK_FLAG";
            this.BACK_FLAG.ReadOnly = true;
            this.BACK_FLAG.Width = 78;
            // 
            // bACKDATEDataGridViewTextBoxColumn
            // 
            this.bACKDATEDataGridViewTextBoxColumn.DataPropertyName = "BACK_DATE";
            this.bACKDATEDataGridViewTextBoxColumn.HeaderText = "回退时间";
            this.bACKDATEDataGridViewTextBoxColumn.Name = "bACKDATEDataGridViewTextBoxColumn";
            this.bACKDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.bACKDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // RESAMPLE_FLAG
            // 
            this.RESAMPLE_FLAG.DataPropertyName = "RESAMPLE_FLAG";
            this.RESAMPLE_FLAG.HeaderText = "重新取样标志";
            this.RESAMPLE_FLAG.Name = "RESAMPLE_FLAG";
            this.RESAMPLE_FLAG.ReadOnly = true;
            this.RESAMPLE_FLAG.Width = 102;
            // 
            // RESAMPLE_REASON
            // 
            this.RESAMPLE_REASON.DataPropertyName = "RESAMPLE_REASON";
            this.RESAMPLE_REASON.HeaderText = "重新取样原因";
            this.RESAMPLE_REASON.Name = "RESAMPLE_REASON";
            this.RESAMPLE_REASON.ReadOnly = true;
            this.RESAMPLE_REASON.Width = 102;
            // 
            // rESAMPLEDATEDataGridViewTextBoxColumn
            // 
            this.rESAMPLEDATEDataGridViewTextBoxColumn.DataPropertyName = "RESAMPLE_DATE";
            this.rESAMPLEDATEDataGridViewTextBoxColumn.HeaderText = "重取样申请时间";
            this.rESAMPLEDATEDataGridViewTextBoxColumn.Name = "rESAMPLEDATEDataGridViewTextBoxColumn";
            this.rESAMPLEDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rESAMPLEDATEDataGridViewTextBoxColumn.Width = 114;
            // 
            // SENDFLAG
            // 
            this.SENDFLAG.DataPropertyName = "SENDFLAG";
            this.SENDFLAG.HeaderText = "发送标识";
            this.SENDFLAG.Name = "SENDFLAG";
            this.SENDFLAG.ReadOnly = true;
            this.SENDFLAG.Width = 78;
            // 
            // rESAMPLEDDataGridViewTextBoxColumn
            // 
            this.rESAMPLEDDataGridViewTextBoxColumn.DataPropertyName = "RESAMPLED";
            this.rESAMPLEDDataGridViewTextBoxColumn.HeaderText = "已重取样";
            this.rESAMPLEDDataGridViewTextBoxColumn.Name = "rESAMPLEDDataGridViewTextBoxColumn";
            this.rESAMPLEDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rESAMPLEDDataGridViewTextBoxColumn.Width = 78;
            // 
            // cmsToLab
            // 
            this.cmsToLab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirmSampleAgain,
            this.btnConfirmMakeAgain});
            this.cmsToLab.Name = "cmsToLab";
            this.cmsToLab.Size = new System.Drawing.Size(149, 48);
            // 
            // btnConfirmSampleAgain
            // 
            this.btnConfirmSampleAgain.Name = "btnConfirmSampleAgain";
            this.btnConfirmSampleAgain.Size = new System.Drawing.Size(148, 22);
            this.btnConfirmSampleAgain.Text = "确认已重取样";
            this.btnConfirmSampleAgain.Click += new System.EventHandler(this.btnConfirmSampleAgain_Click);
            // 
            // btnConfirmMakeAgain
            // 
            this.btnConfirmMakeAgain.Name = "btnConfirmMakeAgain";
            this.btnConfirmMakeAgain.Size = new System.Drawing.Size(148, 22);
            this.btnConfirmMakeAgain.Text = "确认已重制单";
            this.btnConfirmMakeAgain.Click += new System.EventHandler(this.btnConfirmMakeAgain_Click);
            // 
            // cmdToLab
            // 
            this.cmdToLab.Adapter = this.Adapter;
            this.cmdToLab.MergeReturnTarget = false;
            this.cmdToLab.Method = "SendSheetDataToLab";
            this.cmdToLab.Object = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.cmdToLab.Parameters.Add(this.l3cmdpToLab);
            this.cmdToLab.ReturnTarget = null;
            this.cmdToLab.ReturnTargetProperty = null;
            this.cmdToLab.Trigger = null;
            this.cmdToLab.TriggerEvent = "Click";
            // 
            // l3cmdpToLab
            // 
            this.l3cmdpToLab.AcceptAfterExecuted = false;
            this.l3cmdpToLab.ConstantValue = null;
            this.l3cmdpToLab.MergeTarget = false;
            this.l3cmdpToLab.SourceFilter = "";
            this.l3cmdpToLab.SourceObject = this.dsSampleApply;
            this.l3cmdpToLab.SourceProperty = "L3DataTable";
            this.l3cmdpToLab.TargetObject = null;
            this.l3cmdpToLab.TargetProperty = null;
            // 
            // MIFSampleApplyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 287);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bnIronLadle);
            this.Controls.Add(this.tSp1);
            this.Name = "MIFSampleApplyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "化验委托单管理";
            this.Load += new System.EventHandler(this.MIFSampleApplyFrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MIFSampleApplyFrm_FormClosing);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnIronLadle)).EndInit();
            this.bnIronLadle.ResumeLayout(false);
            this.bnIronLadle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleApply)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvSampleApply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSampleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsSampleType)).EndInit();
            this.cmsToLab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingNavigator bnIronLadle;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvSampleApply;
        private AppSvrHMI.L3DataSet dsSampleApply;
        private System.Windows.Forms.BindingSource bsSampleApply;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3Command cmdSampleApply;
        private System.Data.DataTable schemadsSampleApply;
        private System.Data.DataColumn coldsSampleApplyL3DataTableAPPID;
        private System.Data.DataColumn coldsSampleApplyL3DataTableHEATID;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSAMPLE_CODE;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSAMPLE_ADDRESS;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSAMPLE_TYPE;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSAMPLE_COUNT;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSAMPLE_DATE;
        private System.Data.DataColumn coldsSampleApplyL3DataTableFIN_PROD_FLAG;
        private System.Data.DataColumn coldsSampleApplyL3DataTableASIS_FLAG;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSTEELGRADE;
        private System.Data.DataColumn coldsSampleApplyL3DataTableTREATY;
        private System.Data.DataColumn coldsSampleApplyL3DataTableBACK_FLAG;
        private System.Data.DataColumn coldsSampleApplyL3DataTableBACK_DATE;
        private System.Data.DataColumn coldsSampleApplyL3DataTableRESAMPLE_FLAG;
        private System.Data.DataColumn coldsSampleApplyL3DataTableRESAMPLE_REASON;
        private System.Data.DataColumn coldsSampleApplyL3DataTableRESAMPLE_DATE;
        private System.Data.DataColumn coldsSampleApplyL3DataTableSENDFLAG;
        private System.Data.DataColumn coldsSampleApplyL3DataTableRESAMPLED;
        private AppSvrHMI.L3CommandParameter l3cmdpSampleApply;
        private AppSvrHMI.L3DataSet dsSampleType;
        private System.Data.DataTable schemadsSampleType;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode;
        private System.Data.DataColumn coldsSampleTypeL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsSampleAddr;
        private System.Data.DataTable schemadsSampleAddr;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode;
        private System.Data.DataColumn coldsSampleAddrL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnToLab;
        private AppSvrHMI.L3Command cmdToLab;
        private AppSvrHMI.L3CommandParameter l3cmdpToLab;
        private System.Data.DataColumn coldsSampleApplyL3DataTableCheckFlag;
        private System.Windows.Forms.ContextMenuStrip cmsToLab;
        private System.Windows.Forms.ToolStripMenuItem btnConfirmSampleAgain;
        private System.Windows.Forms.ToolStripMenuItem btnConfirmMakeAgain;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAMPLECODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sAMPLEADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sAMPLETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAMPLECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAMPLEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINPRODFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSISFLAGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tREATYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BACK_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn bACKDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESAMPLE_FLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESAMPLE_REASON;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESAMPLEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENDFLAG;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESAMPLEDDataGridViewTextBoxColumn;
    }
}