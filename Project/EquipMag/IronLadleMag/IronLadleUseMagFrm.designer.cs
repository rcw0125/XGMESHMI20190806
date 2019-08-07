namespace EquipMag.IronLadleMag
{
    partial class IronLadleUseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronLadleUseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsUseInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsUseInfo = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdUseInfo = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsUseInfo = new System.Data.DataTable();
            this.coldsUseInfoL3DataTableGUID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableNAME = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableIRONLADLEID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableCHECK_TIME = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableIRONLADLE_AGE = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableWALL_TEMP = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableBOTTOM_TEMP = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableSTOP_REASON = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableTHROW_TIME = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsUseInfoL3DataTableTieID = new System.Data.DataColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.bnUseInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbIronladleID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvUseInfo = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRONLADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRONLADLEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wALLTEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOTTOMTEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOPREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHROWTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsIronLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadleID = new System.Data.DataTable();
            this.coldsIronLadleIDL3DataTableIronLadleID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsUseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUseInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnUseInfo)).BeginInit();
            this.bnUseInfo.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvUseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsUseInfo
            // 
            this.bsUseInfo.DataMember = "L3DataTable";
            this.bsUseInfo.DataSource = this.dsUseInfo;
            // 
            // dsUseInfo
            // 
            this.dsUseInfo.AutoSubscribe = false;
            this.dsUseInfo.DataSetName = "L3DataSet";
            this.dsUseInfo.DeleteMethod = "DeleteUseInfos";
            this.dsUseInfo.InsertMethod = "InsertUseInfos";
            this.dsUseInfo.L3DataAdapter = this.Adapter;
            this.dsUseInfo.LoadEvent = "Click";
            this.dsUseInfo.LoadTrigger = null;
            this.dsUseInfo.RefreshValve = 1000;
            this.dsUseInfo.SourceCommand = this.cmdUseInfo;
            this.dsUseInfo.SourceCondition = null;
            this.dsUseInfo.SourceMethod = "GetUseInfos";
            this.dsUseInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsUseInfo.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.dsUseInfo.SubscribeTarget = null;
            this.dsUseInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsUseInfo});
            this.dsUseInfo.UpdateEvent = "Click";
            this.dsUseInfo.UpdateMethod = "UpdateUseInfos";
            this.dsUseInfo.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdUseInfo
            // 
            this.cmdUseInfo.Adapter = null;
            this.cmdUseInfo.MergeReturnTarget = false;
            this.cmdUseInfo.Method = null;
            this.cmdUseInfo.Object = null;
            this.cmdUseInfo.Parameters.Add(this.l3CommandParameter1);
            this.cmdUseInfo.ReturnTarget = null;
            this.cmdUseInfo.ReturnTargetProperty = null;
            this.cmdUseInfo.Trigger = null;
            this.cmdUseInfo.TriggerEvent = "Click";
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
            // schemadsUseInfo
            // 
            this.schemadsUseInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsUseInfoL3DataTableGUID,
            this.coldsUseInfoL3DataTableNAME,
            this.coldsUseInfoL3DataTableINPUT_TIME,
            this.coldsUseInfoL3DataTableIRONLADLEID,
            this.coldsUseInfoL3DataTableCHECK_TIME,
            this.coldsUseInfoL3DataTableIRONLADLE_AGE,
            this.coldsUseInfoL3DataTableWALL_TEMP,
            this.coldsUseInfoL3DataTableBOTTOM_TEMP,
            this.coldsUseInfoL3DataTableSTOP_REASON,
            this.coldsUseInfoL3DataTableTHROW_TIME,
            this.coldsUseInfoL3DataTableTEAMID,
            this.coldsUseInfoL3DataTableSHIFTID,
            this.coldsUseInfoL3DataTableOPERATOR,
            this.coldsUseInfoL3DataTableNOTE,
            this.coldsUseInfoL3DataTableTieID});
            this.schemadsUseInfo.TableName = "L3DataTable";
            // 
            // coldsUseInfoL3DataTableGUID
            // 
            this.coldsUseInfoL3DataTableGUID.Caption = "GUID";
            this.coldsUseInfoL3DataTableGUID.ColumnName = "GUID";
            this.coldsUseInfoL3DataTableGUID.DefaultValue = "";
            this.coldsUseInfoL3DataTableGUID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableNAME
            // 
            this.coldsUseInfoL3DataTableNAME.Caption = "NAME";
            this.coldsUseInfoL3DataTableNAME.ColumnName = "NAME";
            this.coldsUseInfoL3DataTableNAME.DefaultValue = "";
            this.coldsUseInfoL3DataTableNAME.Namespace = "";
            // 
            // coldsUseInfoL3DataTableINPUT_TIME
            // 
            this.coldsUseInfoL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsUseInfoL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsUseInfoL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsUseInfoL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsUseInfoL3DataTableIRONLADLEID
            // 
            this.coldsUseInfoL3DataTableIRONLADLEID.Caption = "IRONLADLEID";
            this.coldsUseInfoL3DataTableIRONLADLEID.ColumnName = "IRONLADLEID";
            this.coldsUseInfoL3DataTableIRONLADLEID.DefaultValue = "";
            this.coldsUseInfoL3DataTableIRONLADLEID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableCHECK_TIME
            // 
            this.coldsUseInfoL3DataTableCHECK_TIME.Caption = "CHECK_TIME";
            this.coldsUseInfoL3DataTableCHECK_TIME.ColumnName = "CHECK_TIME";
            this.coldsUseInfoL3DataTableCHECK_TIME.DataType = typeof(System.DateTime);
            this.coldsUseInfoL3DataTableCHECK_TIME.Namespace = "";
            // 
            // coldsUseInfoL3DataTableIRONLADLE_AGE
            // 
            this.coldsUseInfoL3DataTableIRONLADLE_AGE.Caption = "IRONLADLE_AGE";
            this.coldsUseInfoL3DataTableIRONLADLE_AGE.ColumnName = "IRONLADLE_AGE";
            this.coldsUseInfoL3DataTableIRONLADLE_AGE.DataType = typeof(int);
            this.coldsUseInfoL3DataTableIRONLADLE_AGE.DefaultValue = 0;
            this.coldsUseInfoL3DataTableIRONLADLE_AGE.Namespace = "";
            // 
            // coldsUseInfoL3DataTableWALL_TEMP
            // 
            this.coldsUseInfoL3DataTableWALL_TEMP.Caption = "WALL_TEMP";
            this.coldsUseInfoL3DataTableWALL_TEMP.ColumnName = "WALL_TEMP";
            this.coldsUseInfoL3DataTableWALL_TEMP.DataType = typeof(double);
            this.coldsUseInfoL3DataTableWALL_TEMP.DefaultValue = 0;
            this.coldsUseInfoL3DataTableWALL_TEMP.Namespace = "";
            // 
            // coldsUseInfoL3DataTableBOTTOM_TEMP
            // 
            this.coldsUseInfoL3DataTableBOTTOM_TEMP.Caption = "BOTTOM_TEMP";
            this.coldsUseInfoL3DataTableBOTTOM_TEMP.ColumnName = "BOTTOM_TEMP";
            this.coldsUseInfoL3DataTableBOTTOM_TEMP.DataType = typeof(double);
            this.coldsUseInfoL3DataTableBOTTOM_TEMP.DefaultValue = 0;
            this.coldsUseInfoL3DataTableBOTTOM_TEMP.Namespace = "";
            // 
            // coldsUseInfoL3DataTableSTOP_REASON
            // 
            this.coldsUseInfoL3DataTableSTOP_REASON.Caption = "STOP_REASON";
            this.coldsUseInfoL3DataTableSTOP_REASON.ColumnName = "STOP_REASON";
            this.coldsUseInfoL3DataTableSTOP_REASON.DefaultValue = "";
            this.coldsUseInfoL3DataTableSTOP_REASON.Namespace = "";
            // 
            // coldsUseInfoL3DataTableTHROW_TIME
            // 
            this.coldsUseInfoL3DataTableTHROW_TIME.Caption = "THROW_TIME";
            this.coldsUseInfoL3DataTableTHROW_TIME.ColumnName = "THROW_TIME";
            this.coldsUseInfoL3DataTableTHROW_TIME.Namespace = "";
            // 
            // coldsUseInfoL3DataTableTEAMID
            // 
            this.coldsUseInfoL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsUseInfoL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsUseInfoL3DataTableTEAMID.DefaultValue = "";
            this.coldsUseInfoL3DataTableTEAMID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableSHIFTID
            // 
            this.coldsUseInfoL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsUseInfoL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsUseInfoL3DataTableSHIFTID.DefaultValue = "";
            this.coldsUseInfoL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsUseInfoL3DataTableOPERATOR
            // 
            this.coldsUseInfoL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsUseInfoL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsUseInfoL3DataTableOPERATOR.DefaultValue = "";
            this.coldsUseInfoL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsUseInfoL3DataTableNOTE
            // 
            this.coldsUseInfoL3DataTableNOTE.Caption = "NOTE";
            this.coldsUseInfoL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsUseInfoL3DataTableNOTE.DefaultValue = "";
            this.coldsUseInfoL3DataTableNOTE.Namespace = "";
            // 
            // coldsUseInfoL3DataTableTieID
            // 
            this.coldsUseInfoL3DataTableTieID.Caption = "TieID";
            this.coldsUseInfoL3DataTableTieID.ColumnName = "TieID";
            this.coldsUseInfoL3DataTableTieID.Namespace = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator5,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnOutPut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1000, 43);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "IronLadleUsebtnAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "IronLadleUsebtnAdd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator5, "IronLadleUsebtnAdd");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "IronLadleUsebtnAdd");
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPut.Image")));
            this.btnOutPut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(107, 40);
            this.btnOutPut.Text = "导出到Excel";
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // bnUseInfo
            // 
            this.bnUseInfo.AddNewItem = null;
            this.bnUseInfo.AutoSize = false;
            this.bnUseInfo.BindingSource = this.bsUseInfo;
            this.bnUseInfo.CountItem = this.bindingNavigatorCountItem;
            this.bnUseInfo.DeleteItem = null;
            this.bnUseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel5,
            this.cmbIronladleID,
            this.toolStripLabel2,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel6});
            this.bnUseInfo.Location = new System.Drawing.Point(0, 43);
            this.bnUseInfo.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnUseInfo.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnUseInfo.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnUseInfo.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnUseInfo.Name = "bnUseInfo";
            this.bnUseInfo.PositionItem = this.bindingNavigatorPositionItem;
            this.bnUseInfo.Size = new System.Drawing.Size(1000, 25);
            this.bnUseInfo.TabIndex = 24;
            this.bnUseInfo.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // btnQuery
            // 
            this.btnQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(49, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
            // 
            // cmbIronladleID
            // 
            this.cmbIronladleID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbIronladleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIronladleID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbIronladleID.Name = "cmbIronladleID";
            this.cmbIronladleID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel2.Text = "铁包号:";
            // 
            // dtEnd
            // 
            this.dtEnd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtEnd.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtEnd.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtEnd.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtEnd.CustomFormat = "yyyy-MM-dd";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(100, 22);
            this.dtEnd.Text = "2008-11-16";
            this.dtEnd.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 884);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel4.Text = "-";
            // 
            // dtStart
            // 
            this.dtStart.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dtStart.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dtStart.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dtStart.CalendarMonthBackground = System.Drawing.SystemColors.Window;
            this.dtStart.CustomFormat = "yyyy-MM-dd";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MaximumSize = new System.Drawing.Size(0, 0);
            this.dtStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(100, 22);
            this.dtStart.Text = "2008-11-16";
            this.dtStart.Value = new System.DateTime(2008, 11, 16, 17, 55, 30, 834);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel6.Text = "录入日期:";
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvUseInfo);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 25;
            // 
            // dvUseInfo
            // 
            this.dvUseInfo.AllowUserToAddRows = false;
            this.dvUseInfo.AutoGenerateColumns = false;
            this.dvUseInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvUseInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvUseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.iRONLADLEIDDataGridViewTextBoxColumn,
            this.cHECKTIMEDataGridViewTextBoxColumn,
            this.TieID,
            this.iRONLADLEAGEDataGridViewTextBoxColumn,
            this.wALLTEMPDataGridViewTextBoxColumn,
            this.bOTTOMTEMPDataGridViewTextBoxColumn,
            this.sTOPREASONDataGridViewTextBoxColumn,
            this.tHROWTIMEDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvUseInfo.DataSource = this.bsUseInfo;
            this.dvUseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvUseInfo.Location = new System.Drawing.Point(0, 0);
            this.dvUseInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dvUseInfo.Name = "dvUseInfo";
            this.dvUseInfo.ReadOnly = true;
            this.dvUseInfo.RowTemplate.Height = 23;
            this.dvUseInfo.Size = new System.Drawing.Size(996, 628);
            this.dvUseInfo.TabIndex = 0;
            this.dvUseInfo.Sorted += new System.EventHandler(this.dvUseInfo_Sorted);
            this.dvUseInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvMain_CellMouseDoubleClick);
            this.dvUseInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvUseInfo_DataError);
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Visible = false;
            this.nAMEDataGridViewTextBoxColumn.Width = 54;
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            dataGridViewCellStyle1.Format = "G";
            this.iNPUTTIMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // iRONLADLEIDDataGridViewTextBoxColumn
            // 
            this.iRONLADLEIDDataGridViewTextBoxColumn.DataPropertyName = "IRONLADLEID";
            this.iRONLADLEIDDataGridViewTextBoxColumn.HeaderText = "铁包号";
            this.iRONLADLEIDDataGridViewTextBoxColumn.Name = "iRONLADLEIDDataGridViewTextBoxColumn";
            this.iRONLADLEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iRONLADLEIDDataGridViewTextBoxColumn.Width = 66;
            // 
            // cHECKTIMEDataGridViewTextBoxColumn
            // 
            this.cHECKTIMEDataGridViewTextBoxColumn.DataPropertyName = "CHECK_TIME";
            dataGridViewCellStyle2.Format = "G";
            this.cHECKTIMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cHECKTIMEDataGridViewTextBoxColumn.HeaderText = "检查时间";
            this.cHECKTIMEDataGridViewTextBoxColumn.Name = "cHECKTIMEDataGridViewTextBoxColumn";
            this.cHECKTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHECKTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // TieID
            // 
            this.TieID.DataPropertyName = "TieID";
            this.TieID.HeaderText = "铁包打结编号";
            this.TieID.Name = "TieID";
            this.TieID.ReadOnly = true;
            this.TieID.Width = 102;
            // 
            // iRONLADLEAGEDataGridViewTextBoxColumn
            // 
            this.iRONLADLEAGEDataGridViewTextBoxColumn.DataPropertyName = "IRONLADLE_AGE";
            this.iRONLADLEAGEDataGridViewTextBoxColumn.HeaderText = "包龄";
            this.iRONLADLEAGEDataGridViewTextBoxColumn.Name = "iRONLADLEAGEDataGridViewTextBoxColumn";
            this.iRONLADLEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iRONLADLEAGEDataGridViewTextBoxColumn.Width = 54;
            // 
            // wALLTEMPDataGridViewTextBoxColumn
            // 
            this.wALLTEMPDataGridViewTextBoxColumn.DataPropertyName = "WALL_TEMP";
            this.wALLTEMPDataGridViewTextBoxColumn.HeaderText = "包壁温度";
            this.wALLTEMPDataGridViewTextBoxColumn.Name = "wALLTEMPDataGridViewTextBoxColumn";
            this.wALLTEMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.wALLTEMPDataGridViewTextBoxColumn.Width = 78;
            // 
            // bOTTOMTEMPDataGridViewTextBoxColumn
            // 
            this.bOTTOMTEMPDataGridViewTextBoxColumn.DataPropertyName = "BOTTOM_TEMP";
            this.bOTTOMTEMPDataGridViewTextBoxColumn.HeaderText = "包底温度";
            this.bOTTOMTEMPDataGridViewTextBoxColumn.Name = "bOTTOMTEMPDataGridViewTextBoxColumn";
            this.bOTTOMTEMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOTTOMTEMPDataGridViewTextBoxColumn.Width = 78;
            // 
            // sTOPREASONDataGridViewTextBoxColumn
            // 
            this.sTOPREASONDataGridViewTextBoxColumn.DataPropertyName = "STOP_REASON";
            this.sTOPREASONDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.sTOPREASONDataGridViewTextBoxColumn.Name = "sTOPREASONDataGridViewTextBoxColumn";
            this.sTOPREASONDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTOPREASONDataGridViewTextBoxColumn.Width = 78;
            // 
            // tHROWTIMEDataGridViewTextBoxColumn
            // 
            this.tHROWTIMEDataGridViewTextBoxColumn.DataPropertyName = "THROW_TIME";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.tHROWTIMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tHROWTIMEDataGridViewTextBoxColumn.HeaderText = "甩包时间";
            this.tHROWTIMEDataGridViewTextBoxColumn.Name = "tHROWTIMEDataGridViewTextBoxColumn";
            this.tHROWTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tHROWTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "操作者";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn.Width = 66;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsIronLadleID
            // 
            this.dsIronLadleID.AutoSubscribe = false;
            this.dsIronLadleID.DataSetName = "L3DataSet";
            this.dsIronLadleID.DeleteMethod = null;
            this.dsIronLadleID.InsertMethod = null;
            this.dsIronLadleID.L3DataAdapter = this.Adapter;
            this.dsIronLadleID.LoadEvent = "Click";
            this.dsIronLadleID.LoadTrigger = null;
            this.dsIronLadleID.RefreshValve = 1000;
            this.dsIronLadleID.SourceCommand = null;
            this.dsIronLadleID.SourceCondition = null;
            this.dsIronLadleID.SourceMethod = "";
            this.dsIronLadleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadleID.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Base";
            this.dsIronLadleID.SubscribeTarget = null;
            this.dsIronLadleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronLadleID});
            this.dsIronLadleID.UpdateEvent = "Click";
            this.dsIronLadleID.UpdateMethod = null;
            this.dsIronLadleID.UpdateTrigger = null;
            // 
            // schemadsIronLadleID
            // 
            this.schemadsIronLadleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronLadleIDL3DataTableIronLadleID});
            this.schemadsIronLadleID.TableName = "L3DataTable";
            // 
            // coldsIronLadleIDL3DataTableIronLadleID
            // 
            this.coldsIronLadleIDL3DataTableIronLadleID.Caption = "IronLadleID";
            this.coldsIronLadleIDL3DataTableIronLadleID.ColumnName = "IronLadleID";
            this.coldsIronLadleIDL3DataTableIronLadleID.Namespace = "";
            // 
            // IronLadleUseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bnUseInfo);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IronLadleUseMagFrm";
            this.TabText = "铁包使用实绩管理";
            this.Text = "多记录显示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IronLadleUseMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.IronLadleUseMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsUseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsUseInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnUseInfo)).EndInit();
            this.bnUseInfo.ResumeLayout(false);
            this.bnUseInfo.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvUseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsUseInfo;
        private System.Windows.Forms.BindingSource bsUseInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingNavigator bnUseInfo;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvUseInfo;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private AppSvrHMI.L3Command cmdUseInfo;
        private System.Data.DataTable schemadsUseInfo;
        private System.Data.DataColumn coldsUseInfoL3DataTableGUID;
        private System.Data.DataColumn coldsUseInfoL3DataTableNAME;
        private System.Data.DataColumn coldsUseInfoL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsUseInfoL3DataTableIRONLADLEID;
        private System.Data.DataColumn coldsUseInfoL3DataTableCHECK_TIME;
        private System.Data.DataColumn coldsUseInfoL3DataTableIRONLADLE_AGE;
        private System.Data.DataColumn coldsUseInfoL3DataTableWALL_TEMP;
        private System.Data.DataColumn coldsUseInfoL3DataTableBOTTOM_TEMP;
        private System.Data.DataColumn coldsUseInfoL3DataTableSTOP_REASON;
        private System.Data.DataColumn coldsUseInfoL3DataTableTHROW_TIME;
        private System.Data.DataColumn coldsUseInfoL3DataTableTEAMID;
        private System.Data.DataColumn coldsUseInfoL3DataTableSHIFTID;
        private System.Data.DataColumn coldsUseInfoL3DataTableOPERATOR;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbIronladleID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsIronLadleID;
        private System.Data.DataTable schemadsIronLadleID;
        private System.Data.DataColumn coldsIronLadleIDL3DataTableIronLadleID;
        private System.Data.DataColumn coldsUseInfoL3DataTableNOTE;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataColumn coldsUseInfoL3DataTableTieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRONLADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHECKTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRONLADLEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wALLTEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOTTOMTEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTOPREASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHROWTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
    }
}