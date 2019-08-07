namespace EquipMag.IronLadleMag
{
    partial class IronLadleFireMagFrm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronLadleFireMagFrm));
            this.bsFireInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsFireInfo = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.cmdFireInfo = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter2 = new AppSvrHMI.L3CommandParameter();
            this.schemadsFireInfo = new System.Data.DataTable();
            this.coldsFireInfoL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableIRONLADLEID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableFIRE_TYPE = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableFIRE_START_TIME = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableFIRE_END_TIME = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableFIRE_LENGTH = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableTieID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableObject_ID = new System.Data.DataColumn();
            this.coldsFireInfoL3DataTableFireID = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bgFireInfo = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
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
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvFireInfo = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRONLADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRETYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsIronLadleFireType = new AppSvrHMI.L3DataSet();
            this.schemal3DataSet1 = new System.Data.DataTable();
            this.coll3DataSet1L3DataTableCode = new System.Data.DataColumn();
            this.coll3DataSet1L3DataTableCode_Des = new System.Data.DataColumn();
            this.FireID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Object_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRESTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIREENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRELENGTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsIronladleID = new AppSvrHMI.L3DataSet();
            this.schemadsIronladleID = new System.Data.DataTable();
            this.coldsIronladleIDL3DataTableIronLadleID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFireInfo)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgFireInfo)).BeginInit();
            this.bgFireInfo.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvFireInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleFireType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronladleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronladleID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFireInfo
            // 
            this.bsFireInfo.DataMember = "L3DataTable";
            this.bsFireInfo.DataSource = this.dsFireInfo;
            // 
            // dsFireInfo
            // 
            this.dsFireInfo.AutoSubscribe = false;
            this.dsFireInfo.DataSetName = "L3DataSet";
            this.dsFireInfo.DeleteMethod = "DeleteFireInfos";
            this.dsFireInfo.InsertMethod = "InsertFireInfos";
            this.dsFireInfo.L3DataAdapter = this.Adapter;
            this.dsFireInfo.LoadEvent = "Click";
            this.dsFireInfo.LoadTrigger = null;
            this.dsFireInfo.RefreshValve = 1000;
            this.dsFireInfo.SourceCommand = this.cmdFireInfo;
            this.dsFireInfo.SourceCondition = null;
            this.dsFireInfo.SourceMethod = "GetFireInfos";
            this.dsFireInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsFireInfo.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.dsFireInfo.SubscribeTarget = null;
            this.dsFireInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsFireInfo});
            this.dsFireInfo.UpdateEvent = "Click";
            this.dsFireInfo.UpdateMethod = "UpdateFireInfos";
            this.dsFireInfo.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "IronLadleFirebtnAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "IronLadleFirebtnAdd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "IronLadleFirebtnAdd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "IronLadleFirebtnAdd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmdFireInfo
            // 
            this.cmdFireInfo.Adapter = null;
            this.cmdFireInfo.MergeReturnTarget = false;
            this.cmdFireInfo.Method = null;
            this.cmdFireInfo.Object = null;
            this.cmdFireInfo.Parameters.Add(this.l3CommandParameter2);
            this.cmdFireInfo.ReturnTarget = null;
            this.cmdFireInfo.ReturnTargetProperty = null;
            this.cmdFireInfo.Trigger = null;
            this.cmdFireInfo.TriggerEvent = "Click";
            // 
            // l3CommandParameter2
            // 
            this.l3CommandParameter2.AcceptAfterExecuted = false;
            this.l3CommandParameter2.ConstantValue = null;
            this.l3CommandParameter2.MergeTarget = false;
            this.l3CommandParameter2.SourceFilter = null;
            this.l3CommandParameter2.SourceObject = null;
            this.l3CommandParameter2.SourceProperty = null;
            this.l3CommandParameter2.TargetObject = null;
            this.l3CommandParameter2.TargetProperty = null;
            // 
            // schemadsFireInfo
            // 
            this.schemadsFireInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsFireInfoL3DataTableINPUT_TIME,
            this.coldsFireInfoL3DataTableIRONLADLEID,
            this.coldsFireInfoL3DataTableFIRE_TYPE,
            this.coldsFireInfoL3DataTableFIRE_START_TIME,
            this.coldsFireInfoL3DataTableFIRE_END_TIME,
            this.coldsFireInfoL3DataTableFIRE_LENGTH,
            this.coldsFireInfoL3DataTableOPERATOR,
            this.coldsFireInfoL3DataTableNOTE,
            this.coldsFireInfoL3DataTableTEAMID,
            this.coldsFireInfoL3DataTableSHIFTID,
            this.coldsFireInfoL3DataTableTieID,
            this.coldsFireInfoL3DataTableObject_ID,
            this.coldsFireInfoL3DataTableFireID});
            this.schemadsFireInfo.TableName = "L3DataTable";
            // 
            // coldsFireInfoL3DataTableINPUT_TIME
            // 
            this.coldsFireInfoL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsFireInfoL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsFireInfoL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsFireInfoL3DataTableIRONLADLEID
            // 
            this.coldsFireInfoL3DataTableIRONLADLEID.Caption = "IRONLADLEID";
            this.coldsFireInfoL3DataTableIRONLADLEID.ColumnName = "IRONLADLEID";
            this.coldsFireInfoL3DataTableIRONLADLEID.DefaultValue = "";
            this.coldsFireInfoL3DataTableIRONLADLEID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableFIRE_TYPE
            // 
            this.coldsFireInfoL3DataTableFIRE_TYPE.Caption = "FIRE_TYPE";
            this.coldsFireInfoL3DataTableFIRE_TYPE.ColumnName = "FIRE_TYPE";
            this.coldsFireInfoL3DataTableFIRE_TYPE.DefaultValue = "";
            this.coldsFireInfoL3DataTableFIRE_TYPE.Namespace = "";
            // 
            // coldsFireInfoL3DataTableFIRE_START_TIME
            // 
            this.coldsFireInfoL3DataTableFIRE_START_TIME.Caption = "FIRE_START_TIME";
            this.coldsFireInfoL3DataTableFIRE_START_TIME.ColumnName = "FIRE_START_TIME";
            this.coldsFireInfoL3DataTableFIRE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableFIRE_START_TIME.Namespace = "";
            // 
            // coldsFireInfoL3DataTableFIRE_END_TIME
            // 
            this.coldsFireInfoL3DataTableFIRE_END_TIME.Caption = "FIRE_END_TIME";
            this.coldsFireInfoL3DataTableFIRE_END_TIME.ColumnName = "FIRE_END_TIME";
            this.coldsFireInfoL3DataTableFIRE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsFireInfoL3DataTableFIRE_END_TIME.Namespace = "";
            // 
            // coldsFireInfoL3DataTableFIRE_LENGTH
            // 
            this.coldsFireInfoL3DataTableFIRE_LENGTH.Caption = "FIRE_LENGTH";
            this.coldsFireInfoL3DataTableFIRE_LENGTH.ColumnName = "FIRE_LENGTH";
            this.coldsFireInfoL3DataTableFIRE_LENGTH.DataType = typeof(double);
            this.coldsFireInfoL3DataTableFIRE_LENGTH.DefaultValue = 0;
            this.coldsFireInfoL3DataTableFIRE_LENGTH.Namespace = "";
            // 
            // coldsFireInfoL3DataTableOPERATOR
            // 
            this.coldsFireInfoL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsFireInfoL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsFireInfoL3DataTableOPERATOR.DefaultValue = "";
            this.coldsFireInfoL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsFireInfoL3DataTableNOTE
            // 
            this.coldsFireInfoL3DataTableNOTE.Caption = "NOTE";
            this.coldsFireInfoL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsFireInfoL3DataTableNOTE.DefaultValue = "";
            this.coldsFireInfoL3DataTableNOTE.Namespace = "";
            // 
            // coldsFireInfoL3DataTableTEAMID
            // 
            this.coldsFireInfoL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsFireInfoL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsFireInfoL3DataTableTEAMID.DefaultValue = "";
            this.coldsFireInfoL3DataTableTEAMID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableSHIFTID
            // 
            this.coldsFireInfoL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsFireInfoL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsFireInfoL3DataTableSHIFTID.DefaultValue = "";
            this.coldsFireInfoL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableTieID
            // 
            this.coldsFireInfoL3DataTableTieID.Caption = "TieID";
            this.coldsFireInfoL3DataTableTieID.ColumnName = "TieID";
            this.coldsFireInfoL3DataTableTieID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableObject_ID
            // 
            this.coldsFireInfoL3DataTableObject_ID.Caption = "Object_ID";
            this.coldsFireInfoL3DataTableObject_ID.ColumnName = "Object_ID";
            this.coldsFireInfoL3DataTableObject_ID.Namespace = "";
            // 
            // coldsFireInfoL3DataTableFireID
            // 
            this.coldsFireInfoL3DataTableFireID.Caption = "FireID";
            this.coldsFireInfoL3DataTableFireID.ColumnName = "FireID";
            this.coldsFireInfoL3DataTableFireID.DataType = typeof(int);
            this.coldsFireInfoL3DataTableFireID.Namespace = "";
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bgFireInfo, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bgFireInfo
            // 
            this.bgFireInfo.AddNewItem = null;
            this.bgFireInfo.AutoSize = false;
            this.bgFireInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bgFireInfo.BackgroundImage")));
            this.bgFireInfo.BindingSource = this.bsFireInfo;
            this.bgFireInfo.CountItem = this.bindingNavigatorCountItem;
            this.bgFireInfo.DeleteItem = null;
            this.bgFireInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripLabel3});
            this.bgFireInfo.Location = new System.Drawing.Point(0, 43);
            this.bgFireInfo.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bgFireInfo.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bgFireInfo.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bgFireInfo.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bgFireInfo.Name = "bgFireInfo";
            this.bgFireInfo.PositionItem = this.bindingNavigatorPositionItem;
            this.bgFireInfo.Size = new System.Drawing.Size(1000, 25);
            this.bgFireInfo.TabIndex = 27;
            this.bgFireInfo.Text = "bindingNavigator1";
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
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel3.Text = "录入日期:";
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
            this.toolStripSeparator3,
            this.btnOutPut});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvFireInfo);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvFireInfo
            // 
            this.dvFireInfo.AllowUserToAddRows = false;
            this.dvFireInfo.AutoGenerateColumns = false;
            this.dvFireInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvFireInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvFireInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.iRONLADLEIDDataGridViewTextBoxColumn,
            this.TieID,
            this.fIRETYPEDataGridViewTextBoxColumn,
            this.FireID,
            this.Object_ID,
            this.fIRESTARTTIMEDataGridViewTextBoxColumn,
            this.fIREENDTIMEDataGridViewTextBoxColumn,
            this.fIRELENGTHDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvFireInfo.DataSource = this.bsFireInfo;
            this.dvFireInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvFireInfo.Location = new System.Drawing.Point(0, 0);
            this.dvFireInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dvFireInfo.Name = "dvFireInfo";
            this.dvFireInfo.ReadOnly = true;
            this.dvFireInfo.RowTemplate.Height = 23;
            this.dvFireInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvFireInfo.Size = new System.Drawing.Size(1000, 632);
            this.dvFireInfo.TabIndex = 31;
            this.dvFireInfo.Sorted += new System.EventHandler(this.dvFireInfo_Sorted);
            this.dvFireInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            this.dvFireInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvFireInfo_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // TieID
            // 
            this.TieID.DataPropertyName = "TieID";
            this.TieID.HeaderText = "铁包打结编号";
            this.TieID.Name = "TieID";
            this.TieID.ReadOnly = true;
            this.TieID.Width = 102;
            // 
            // fIRETYPEDataGridViewTextBoxColumn
            // 
            this.fIRETYPEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_TYPE";
            this.fIRETYPEDataGridViewTextBoxColumn.DataSource = this.dsIronLadleFireType;
            this.fIRETYPEDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.fIRETYPEDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.fIRETYPEDataGridViewTextBoxColumn.HeaderText = "烘烤类型";
            this.fIRETYPEDataGridViewTextBoxColumn.Name = "fIRETYPEDataGridViewTextBoxColumn";
            this.fIRETYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRETYPEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fIRETYPEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fIRETYPEDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.fIRETYPEDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsIronLadleFireType
            // 
            this.dsIronLadleFireType.AutoSubscribe = false;
            this.dsIronLadleFireType.DataSetName = "L3DataSet";
            this.dsIronLadleFireType.DeleteMethod = null;
            this.dsIronLadleFireType.InsertMethod = null;
            this.dsIronLadleFireType.L3DataAdapter = this.Adapter;
            this.dsIronLadleFireType.LoadEvent = "Click";
            this.dsIronLadleFireType.LoadTrigger = null;
            this.dsIronLadleFireType.RefreshValve = 1000;
            this.dsIronLadleFireType.SourceCommand = null;
            this.dsIronLadleFireType.SourceCondition = "Code_Group = \'IronLadleFireType\' order by Code";
            this.dsIronLadleFireType.SourceMethod = "";
            this.dsIronLadleFireType.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronLadleFireType.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsIronLadleFireType.SubscribeTarget = null;
            this.dsIronLadleFireType.Tables.AddRange(new System.Data.DataTable[] {
            this.schemal3DataSet1});
            this.dsIronLadleFireType.UpdateEvent = "Click";
            this.dsIronLadleFireType.UpdateMethod = null;
            this.dsIronLadleFireType.UpdateTrigger = null;
            // 
            // schemal3DataSet1
            // 
            this.schemal3DataSet1.Columns.AddRange(new System.Data.DataColumn[] {
            this.coll3DataSet1L3DataTableCode,
            this.coll3DataSet1L3DataTableCode_Des});
            this.schemal3DataSet1.TableName = "L3DataTable";
            // 
            // coll3DataSet1L3DataTableCode
            // 
            this.coll3DataSet1L3DataTableCode.Caption = "Code";
            this.coll3DataSet1L3DataTableCode.ColumnName = "Code";
            this.coll3DataSet1L3DataTableCode.Namespace = "";
            // 
            // coll3DataSet1L3DataTableCode_Des
            // 
            this.coll3DataSet1L3DataTableCode_Des.Caption = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.ColumnName = "Code_Des";
            this.coll3DataSet1L3DataTableCode_Des.Namespace = "";
            // 
            // FireID
            // 
            this.FireID.DataPropertyName = "FireID";
            this.FireID.HeaderText = "烘烤编号";
            this.FireID.Name = "FireID";
            this.FireID.ReadOnly = true;
            this.FireID.Width = 78;
            // 
            // Object_ID
            // 
            this.Object_ID.DataPropertyName = "Object_ID";
            this.Object_ID.HeaderText = "主键";
            this.Object_ID.Name = "Object_ID";
            this.Object_ID.ReadOnly = true;
            this.Object_ID.Visible = false;
            this.Object_ID.Width = 54;
            // 
            // fIRESTARTTIMEDataGridViewTextBoxColumn
            // 
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_START_TIME";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤开始时间";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Name = "fIRESTARTTIMEDataGridViewTextBoxColumn";
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRESTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // fIREENDTIMEDataGridViewTextBoxColumn
            // 
            this.fIREENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "FIRE_END_TIME";
            this.fIREENDTIMEDataGridViewTextBoxColumn.HeaderText = "烘烤结束时间";
            this.fIREENDTIMEDataGridViewTextBoxColumn.Name = "fIREENDTIMEDataGridViewTextBoxColumn";
            this.fIREENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIREENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // fIRELENGTHDataGridViewTextBoxColumn
            // 
            this.fIRELENGTHDataGridViewTextBoxColumn.DataPropertyName = "FIRE_LENGTH";
            this.fIRELENGTHDataGridViewTextBoxColumn.HeaderText = "烘烤时长";
            this.fIRELENGTHDataGridViewTextBoxColumn.Name = "fIRELENGTHDataGridViewTextBoxColumn";
            this.fIRELENGTHDataGridViewTextBoxColumn.ReadOnly = true;
            this.fIRELENGTHDataGridViewTextBoxColumn.Width = 78;
            // 
            // tEAMIDDataGridViewTextBoxColumn
            // 
            this.tEAMIDDataGridViewTextBoxColumn.DataPropertyName = "TEAMID";
            this.tEAMIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.tEAMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.tEAMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.tEAMIDDataGridViewTextBoxColumn.HeaderText = "班别";
            this.tEAMIDDataGridViewTextBoxColumn.Name = "tEAMIDDataGridViewTextBoxColumn";
            this.tEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tEAMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tEAMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tEAMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.tEAMIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsTeamID
            // 
            this.dsTeamID.AutoSubscribe = false;
            this.dsTeamID.DataSetName = "L3DataSet";
            this.dsTeamID.DeleteMethod = null;
            this.dsTeamID.InsertMethod = null;
            this.dsTeamID.L3DataAdapter = this.Adapter;
            this.dsTeamID.LoadEvent = "Click";
            this.dsTeamID.LoadTrigger = null;
            this.dsTeamID.RefreshValve = 1000;
            this.dsTeamID.SourceCommand = null;
            this.dsTeamID.SourceCondition = "Code_Group = \'TeamID\' order by Code";
            this.dsTeamID.SourceMethod = "";
            this.dsTeamID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTeamID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsTeamID.SubscribeTarget = null;
            this.dsTeamID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTeamID});
            this.dsTeamID.UpdateEvent = "Click";
            this.dsTeamID.UpdateMethod = null;
            this.dsTeamID.UpdateTrigger = null;
            // 
            // schemadsTeamID
            // 
            this.schemadsTeamID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTeamIDL3DataTableCode,
            this.coldsTeamIDL3DataTableCode_Des});
            this.schemadsTeamID.TableName = "L3DataTable";
            // 
            // coldsTeamIDL3DataTableCode
            // 
            this.coldsTeamIDL3DataTableCode.Caption = "Code";
            this.coldsTeamIDL3DataTableCode.ColumnName = "Code";
            this.coldsTeamIDL3DataTableCode.Namespace = "";
            // 
            // coldsTeamIDL3DataTableCode_Des
            // 
            this.coldsTeamIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsTeamIDL3DataTableCode_Des.Namespace = "";
            // 
            // sHIFTIDDataGridViewTextBoxColumn
            // 
            this.sHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "SHIFTID";
            this.sHIFTIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.sHIFTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.sHIFTIDDataGridViewTextBoxColumn.HeaderText = "班次";
            this.sHIFTIDDataGridViewTextBoxColumn.Name = "sHIFTIDDataGridViewTextBoxColumn";
            this.sHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHIFTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHIFTIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.sHIFTIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // dsShiftID
            // 
            this.dsShiftID.AutoSubscribe = false;
            this.dsShiftID.DataSetName = "L3DataSet";
            this.dsShiftID.DeleteMethod = null;
            this.dsShiftID.InsertMethod = null;
            this.dsShiftID.L3DataAdapter = this.Adapter;
            this.dsShiftID.LoadEvent = "Click";
            this.dsShiftID.LoadTrigger = null;
            this.dsShiftID.RefreshValve = 1000;
            this.dsShiftID.SourceCommand = null;
            this.dsShiftID.SourceCondition = "Code_Group = \'ShiftID\' order by Code";
            this.dsShiftID.SourceMethod = "";
            this.dsShiftID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsShiftID.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsShiftID.SubscribeTarget = null;
            this.dsShiftID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsShiftID});
            this.dsShiftID.UpdateEvent = "Click";
            this.dsShiftID.UpdateMethod = null;
            this.dsShiftID.UpdateTrigger = null;
            // 
            // schemadsShiftID
            // 
            this.schemadsShiftID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsShiftIDL3DataTableCode_Des,
            this.coldsShiftIDL3DataTableCode});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
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
            // dsIronladleID
            // 
            this.dsIronladleID.AutoSubscribe = false;
            this.dsIronladleID.DataSetName = "L3DataSet";
            this.dsIronladleID.DeleteMethod = null;
            this.dsIronladleID.InsertMethod = null;
            this.dsIronladleID.L3DataAdapter = this.Adapter;
            this.dsIronladleID.LoadEvent = "Click";
            this.dsIronladleID.LoadTrigger = null;
            this.dsIronladleID.RefreshValve = 1000;
            this.dsIronladleID.SourceCommand = null;
            this.dsIronladleID.SourceCondition = null;
            this.dsIronladleID.SourceMethod = "";
            this.dsIronladleID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsIronladleID.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Base";
            this.dsIronladleID.SubscribeTarget = null;
            this.dsIronladleID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsIronladleID});
            this.dsIronladleID.UpdateEvent = "Click";
            this.dsIronladleID.UpdateMethod = null;
            this.dsIronladleID.UpdateTrigger = null;
            // 
            // schemadsIronladleID
            // 
            this.schemadsIronladleID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsIronladleIDL3DataTableIronLadleID});
            this.schemadsIronladleID.TableName = "L3DataTable";
            // 
            // coldsIronladleIDL3DataTableIronLadleID
            // 
            this.coldsIronladleIDL3DataTableIronLadleID.Caption = "IronLadleID";
            this.coldsIronladleIDL3DataTableIronLadleID.ColumnName = "IronLadleID";
            this.coldsIronladleIDL3DataTableIronLadleID.Namespace = "";
            // 
            // IronLadleFireMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IronLadleFireMagFrm";
            this.TabText = "铁包烘烤实绩管理";
            this.Text = "铁包烘烤实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IronLadleFireMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.IronLadleFireMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsFireInfo)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bgFireInfo)).EndInit();
            this.bgFireInfo.ResumeLayout(false);
            this.bgFireInfo.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvFireInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleFireType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemal3DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronladleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronladleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsFireInfo;
        private System.Windows.Forms.BindingSource bsFireInfo;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bgFireInfo;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvFireInfo;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Data.DataTable schemadsFireInfo;
        private System.Data.DataColumn coldsFireInfoL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsFireInfoL3DataTableIRONLADLEID;
        private System.Data.DataColumn coldsFireInfoL3DataTableFIRE_TYPE;
        private System.Data.DataColumn coldsFireInfoL3DataTableFIRE_START_TIME;
        private System.Data.DataColumn coldsFireInfoL3DataTableFIRE_END_TIME;
        private System.Data.DataColumn coldsFireInfoL3DataTableFIRE_LENGTH;
        private System.Data.DataColumn coldsFireInfoL3DataTableOPERATOR;
        private System.Data.DataColumn coldsFireInfoL3DataTableNOTE;
        private System.Data.DataColumn coldsFireInfoL3DataTableTEAMID;
        private System.Data.DataColumn coldsFireInfoL3DataTableSHIFTID;
        private AppSvrHMI.L3Command cmdFireInfo;
        private AppSvrHMI.L3CommandParameter l3CommandParameter2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cmbIronladleID;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private AppSvrHMI.L3DataSet dsIronladleID;
        private System.Data.DataTable schemadsIronladleID;
        private System.Data.DataColumn coldsIronladleIDL3DataTableIronLadleID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsIronLadleFireType;
        private System.Data.DataTable schemal3DataSet1;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode;
        private System.Data.DataColumn coll3DataSet1L3DataTableCode_Des;
        private System.Data.DataColumn coldsFireInfoL3DataTableTieID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Data.DataColumn coldsFireInfoL3DataTableObject_ID;
        private System.Data.DataColumn coldsFireInfoL3DataTableFireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRONLADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieID;
        private System.Windows.Forms.DataGridViewComboBoxColumn fIRETYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FireID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Object_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRESTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIREENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRELENGTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
    }
}