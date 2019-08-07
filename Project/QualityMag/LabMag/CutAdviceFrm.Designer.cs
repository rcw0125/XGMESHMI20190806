namespace QualityMag.LabMag
{
    partial class CutAdviceFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutAdviceFrm));
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bn1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsCutAdvice = new System.Windows.Forms.BindingSource(this.components);
            this.dsCutAdvice = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsCutAdvice = new System.Data.DataTable();
            this.coldsCutAdviceL3DataTableGUID = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableNAME = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableHEATID = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableSTEELGRADE = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableCUT_COUNT = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableCUT_POSITION = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableCUT_DIMEN = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableCUT_MARK = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableLOG_TIME = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableCASTERID = new System.Data.DataColumn();
            this.coldsCutAdviceL3DataTableSTEELGRADEINDEX = new System.Data.DataColumn();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvCutAdvice = new System.Windows.Forms.DataGridView();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTEELGRADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CASTERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STEELGRADEINDEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROTOCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUTCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUTPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCutPosition = new AppSvrHMI.L3DataSet();
            this.schemadsCutPosition = new System.Data.DataTable();
            this.coldsCutPositionL3DataTableCode = new System.Data.DataColumn();
            this.coldsCutPositionL3DataTableCode_Des = new System.Data.DataColumn();
            this.cUTDIMENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsCutSize = new AppSvrHMI.L3DataSet();
            this.schemadsCutSize = new System.Data.DataTable();
            this.coldsCutSizeL3DataTableCode = new System.Data.DataColumn();
            this.coldsCutSizeL3DataTableCode_Des = new System.Data.DataColumn();
            this.cUTMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldsCutAdviceL3DataTablePROTOCOL = new System.Data.DataColumn();
            this.tSp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).BeginInit();
            this.bn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCutAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutAdvice)).BeginInit();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCutAdvice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tSp1
            // 
            this.tSp1.AutoSize = false;
            this.tSp1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tSp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnAdd,
            this.btnDel,
            this.toolStripSeparator2,
            this.btnConfirm,
            this.btnCancel,
            this.toolStripSeparator1,
            this.btnRefresh});
            this.tSp1.Location = new System.Drawing.Point(0, 0);
            this.tSp1.Name = "tSp1";
            this.tSp1.Padding = new System.Windows.Forms.Padding(0);
            this.tSp1.Size = new System.Drawing.Size(905, 36);
            this.tSp1.TabIndex = 31;
            this.tSp1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 33);
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 33);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 33);
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
            this.btnConfirm.Size = new System.Drawing.Size(65, 33);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 33);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.CutAdviceFrm_Load);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 33);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // bn1
            // 
            this.bn1.AddNewItem = null;
            this.bn1.AutoSize = false;
            this.bn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bn1.BackgroundImage")));
            this.bn1.BindingSource = this.bsCutAdvice;
            this.bn1.CountItem = this.bindingNavigatorCountItem;
            this.bn1.DeleteItem = null;
            this.bn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1});
            this.bn1.Location = new System.Drawing.Point(0, 36);
            this.bn1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bn1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bn1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bn1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bn1.Name = "bn1";
            this.bn1.PositionItem = this.bindingNavigatorPositionItem;
            this.bn1.Size = new System.Drawing.Size(905, 25);
            this.bn1.TabIndex = 32;
            this.bn1.Text = "bindingNavigator1";
            // 
            // bsCutAdvice
            // 
            this.bsCutAdvice.DataMember = "L3DataTable";
            this.bsCutAdvice.DataSource = this.dsCutAdvice;
            // 
            // dsCutAdvice
            // 
            this.dsCutAdvice.DataSetName = "L3DataSet";
            this.dsCutAdvice.DeleteMethod = "DeleteCutAdvice";
            this.dsCutAdvice.InsertMethod = "LabCutAdvice";
            this.dsCutAdvice.L3DataAdapter = this.Adapter;
            this.dsCutAdvice.LoadEvent = "Click";
            this.dsCutAdvice.LoadTrigger = null;
            this.dsCutAdvice.RefreshValve = 1000;
            this.dsCutAdvice.SourceCommand = null;
            this.dsCutAdvice.SourceCondition = null;
            this.dsCutAdvice.SourceMethod = "GetCutAdviceData";
            this.dsCutAdvice.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsCutAdvice.SourceURI = "XGMESLogic\\QualityMag\\CQA_HeatChemicalData_Mag\\QA_HeatChemicalData_Mag";
            this.dsCutAdvice.SubscribeTarget = null;
            this.dsCutAdvice.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCutAdvice});
            this.dsCutAdvice.UpdateEvent = "Click";
            this.dsCutAdvice.UpdateMethod = "";
            this.dsCutAdvice.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsCutAdvice
            // 
            this.schemadsCutAdvice.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCutAdviceL3DataTableGUID,
            this.coldsCutAdviceL3DataTableNAME,
            this.coldsCutAdviceL3DataTableHEATID,
            this.coldsCutAdviceL3DataTableSTEELGRADE,
            this.coldsCutAdviceL3DataTableCUT_COUNT,
            this.coldsCutAdviceL3DataTableCUT_POSITION,
            this.coldsCutAdviceL3DataTableCUT_DIMEN,
            this.coldsCutAdviceL3DataTableCUT_MARK,
            this.coldsCutAdviceL3DataTableLOG_TIME,
            this.coldsCutAdviceL3DataTableCASTERID,
            this.coldsCutAdviceL3DataTableSTEELGRADEINDEX});
            this.schemadsCutAdvice.TableName = "L3DataTable";
            // 
            // coldsCutAdviceL3DataTableGUID
            // 
            this.coldsCutAdviceL3DataTableGUID.Caption = "GUID";
            this.coldsCutAdviceL3DataTableGUID.ColumnName = "GUID";
            this.coldsCutAdviceL3DataTableGUID.DefaultValue = "";
            this.coldsCutAdviceL3DataTableGUID.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableNAME
            // 
            this.coldsCutAdviceL3DataTableNAME.Caption = "NAME";
            this.coldsCutAdviceL3DataTableNAME.ColumnName = "NAME";
            this.coldsCutAdviceL3DataTableNAME.DefaultValue = "";
            this.coldsCutAdviceL3DataTableNAME.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableHEATID
            // 
            this.coldsCutAdviceL3DataTableHEATID.Caption = "HEATID";
            this.coldsCutAdviceL3DataTableHEATID.ColumnName = "HEATID";
            this.coldsCutAdviceL3DataTableHEATID.DefaultValue = "";
            this.coldsCutAdviceL3DataTableHEATID.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableSTEELGRADE
            // 
            this.coldsCutAdviceL3DataTableSTEELGRADE.Caption = "STEELGRADE";
            this.coldsCutAdviceL3DataTableSTEELGRADE.ColumnName = "STEELGRADE";
            this.coldsCutAdviceL3DataTableSTEELGRADE.DefaultValue = "";
            this.coldsCutAdviceL3DataTableSTEELGRADE.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableCUT_COUNT
            // 
            this.coldsCutAdviceL3DataTableCUT_COUNT.Caption = "CUT_COUNT";
            this.coldsCutAdviceL3DataTableCUT_COUNT.ColumnName = "CUT_COUNT";
            this.coldsCutAdviceL3DataTableCUT_COUNT.DataType = typeof(int);
            this.coldsCutAdviceL3DataTableCUT_COUNT.DefaultValue = 0;
            this.coldsCutAdviceL3DataTableCUT_COUNT.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableCUT_POSITION
            // 
            this.coldsCutAdviceL3DataTableCUT_POSITION.Caption = "CUT_POSITION";
            this.coldsCutAdviceL3DataTableCUT_POSITION.ColumnName = "CUT_POSITION";
            this.coldsCutAdviceL3DataTableCUT_POSITION.DefaultValue = "";
            this.coldsCutAdviceL3DataTableCUT_POSITION.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableCUT_DIMEN
            // 
            this.coldsCutAdviceL3DataTableCUT_DIMEN.Caption = "CUT_DIMEN";
            this.coldsCutAdviceL3DataTableCUT_DIMEN.ColumnName = "CUT_DIMEN";
            this.coldsCutAdviceL3DataTableCUT_DIMEN.DefaultValue = "";
            this.coldsCutAdviceL3DataTableCUT_DIMEN.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableCUT_MARK
            // 
            this.coldsCutAdviceL3DataTableCUT_MARK.Caption = "CUT_MARK";
            this.coldsCutAdviceL3DataTableCUT_MARK.ColumnName = "CUT_MARK";
            this.coldsCutAdviceL3DataTableCUT_MARK.DefaultValue = "";
            this.coldsCutAdviceL3DataTableCUT_MARK.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableLOG_TIME
            // 
            this.coldsCutAdviceL3DataTableLOG_TIME.Caption = "LOG_TIME";
            this.coldsCutAdviceL3DataTableLOG_TIME.ColumnName = "LOG_TIME";
            this.coldsCutAdviceL3DataTableLOG_TIME.DataType = typeof(System.DateTime);
            this.coldsCutAdviceL3DataTableLOG_TIME.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableCASTERID
            // 
            this.coldsCutAdviceL3DataTableCASTERID.Caption = "CASTERID";
            this.coldsCutAdviceL3DataTableCASTERID.ColumnName = "CASTERID";
            this.coldsCutAdviceL3DataTableCASTERID.Namespace = "";
            // 
            // coldsCutAdviceL3DataTableSTEELGRADEINDEX
            // 
            this.coldsCutAdviceL3DataTableSTEELGRADEINDEX.Caption = "STEELGRADEINDEX";
            this.coldsCutAdviceL3DataTableSTEELGRADEINDEX.ColumnName = "STEELGRADEINDEX";
            this.coldsCutAdviceL3DataTableSTEELGRADEINDEX.Namespace = "";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvCutAdvice);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 61);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(905, 503);
            this.hmiRootPanel1.TabIndex = 33;
            // 
            // dvCutAdvice
            // 
            this.dvCutAdvice.AllowUserToAddRows = false;
            this.dvCutAdvice.AutoGenerateColumns = false;
            this.dvCutAdvice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvCutAdvice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvCutAdvice.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvCutAdvice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.hEATIDDataGridViewTextBoxColumn,
            this.sTEELGRADEDataGridViewTextBoxColumn,
            this.CASTERID,
            this.STEELGRADEINDEX,
            this.PROTOCOL,
            this.cUTCOUNTDataGridViewTextBoxColumn,
            this.cUTPOSITIONDataGridViewTextBoxColumn,
            this.cUTDIMENDataGridViewTextBoxColumn,
            this.cUTMARKDataGridViewTextBoxColumn,
            this.lOGTIMEDataGridViewTextBoxColumn});
            this.dvCutAdvice.DataSource = this.bsCutAdvice;
            this.dvCutAdvice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCutAdvice.Location = new System.Drawing.Point(0, 0);
            this.dvCutAdvice.Name = "dvCutAdvice";
            this.dvCutAdvice.ReadOnly = true;
            this.dvCutAdvice.RowTemplate.Height = 23;
            this.dvCutAdvice.Size = new System.Drawing.Size(905, 503);
            this.dvCutAdvice.TabIndex = 34;
            this.dvCutAdvice.Sorted += new System.EventHandler(this.dvCutAdvice_Sorted);
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
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "取样代码";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // sTEELGRADEDataGridViewTextBoxColumn
            // 
            this.sTEELGRADEDataGridViewTextBoxColumn.DataPropertyName = "STEELGRADE";
            this.sTEELGRADEDataGridViewTextBoxColumn.HeaderText = "钢种";
            this.sTEELGRADEDataGridViewTextBoxColumn.Name = "sTEELGRADEDataGridViewTextBoxColumn";
            this.sTEELGRADEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTEELGRADEDataGridViewTextBoxColumn.Width = 54;
            // 
            // CASTERID
            // 
            this.CASTERID.DataPropertyName = "CASTERID";
            this.CASTERID.HeaderText = "铸机";
            this.CASTERID.Name = "CASTERID";
            this.CASTERID.ReadOnly = true;
            this.CASTERID.Width = 54;
            // 
            // STEELGRADEINDEX
            // 
            this.STEELGRADEINDEX.DataPropertyName = "STEELGRADEINDEX";
            this.STEELGRADEINDEX.HeaderText = "炼钢记号";
            this.STEELGRADEINDEX.Name = "STEELGRADEINDEX";
            this.STEELGRADEINDEX.ReadOnly = true;
            this.STEELGRADEINDEX.Width = 78;
            // 
            // PROTOCOL
            // 
            this.PROTOCOL.DataPropertyName = "PROTOCOL";
            this.PROTOCOL.HeaderText = "协议";
            this.PROTOCOL.Name = "PROTOCOL";
            this.PROTOCOL.ReadOnly = true;
            this.PROTOCOL.Width = 54;
            // 
            // cUTCOUNTDataGridViewTextBoxColumn
            // 
            this.cUTCOUNTDataGridViewTextBoxColumn.DataPropertyName = "CUT_COUNT";
            this.cUTCOUNTDataGridViewTextBoxColumn.HeaderText = "取样数量";
            this.cUTCOUNTDataGridViewTextBoxColumn.Name = "cUTCOUNTDataGridViewTextBoxColumn";
            this.cUTCOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUTCOUNTDataGridViewTextBoxColumn.Width = 78;
            // 
            // cUTPOSITIONDataGridViewTextBoxColumn
            // 
            this.cUTPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "CUT_POSITION";
            this.cUTPOSITIONDataGridViewTextBoxColumn.DataSource = this.dsCutPosition;
            this.cUTPOSITIONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cUTPOSITIONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cUTPOSITIONDataGridViewTextBoxColumn.HeaderText = "取样位置";
            this.cUTPOSITIONDataGridViewTextBoxColumn.Name = "cUTPOSITIONDataGridViewTextBoxColumn";
            this.cUTPOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUTPOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cUTPOSITIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cUTPOSITIONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.cUTPOSITIONDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsCutPosition
            // 
            this.dsCutPosition.DataSetName = "L3DataSet";
            this.dsCutPosition.DeleteMethod = null;
            this.dsCutPosition.InsertMethod = null;
            this.dsCutPosition.L3DataAdapter = this.Adapter;
            this.dsCutPosition.LoadEvent = "Click";
            this.dsCutPosition.LoadTrigger = null;
            this.dsCutPosition.RefreshValve = 1000;
            this.dsCutPosition.SourceCommand = null;
            this.dsCutPosition.SourceCondition = "Code_Group = \'CutAdvice_Position\'";
            this.dsCutPosition.SourceMethod = "";
            this.dsCutPosition.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCutPosition.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCutPosition.SubscribeTarget = null;
            this.dsCutPosition.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCutPosition});
            this.dsCutPosition.UpdateEvent = "Click";
            this.dsCutPosition.UpdateMethod = null;
            this.dsCutPosition.UpdateTrigger = null;
            // 
            // schemadsCutPosition
            // 
            this.schemadsCutPosition.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCutPositionL3DataTableCode,
            this.coldsCutPositionL3DataTableCode_Des});
            this.schemadsCutPosition.TableName = "L3DataTable";
            // 
            // coldsCutPositionL3DataTableCode
            // 
            this.coldsCutPositionL3DataTableCode.Caption = "Code";
            this.coldsCutPositionL3DataTableCode.ColumnName = "Code";
            this.coldsCutPositionL3DataTableCode.Namespace = "";
            // 
            // coldsCutPositionL3DataTableCode_Des
            // 
            this.coldsCutPositionL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCutPositionL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCutPositionL3DataTableCode_Des.Namespace = "";
            // 
            // cUTDIMENDataGridViewTextBoxColumn
            // 
            this.cUTDIMENDataGridViewTextBoxColumn.DataPropertyName = "CUT_DIMEN";
            this.cUTDIMENDataGridViewTextBoxColumn.DataSource = this.dsCutSize;
            this.cUTDIMENDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cUTDIMENDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cUTDIMENDataGridViewTextBoxColumn.HeaderText = "取样尺寸";
            this.cUTDIMENDataGridViewTextBoxColumn.Name = "cUTDIMENDataGridViewTextBoxColumn";
            this.cUTDIMENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUTDIMENDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cUTDIMENDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cUTDIMENDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.cUTDIMENDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsCutSize
            // 
            this.dsCutSize.DataSetName = "L3DataSet";
            this.dsCutSize.DeleteMethod = null;
            this.dsCutSize.InsertMethod = null;
            this.dsCutSize.L3DataAdapter = this.Adapter;
            this.dsCutSize.LoadEvent = "Click";
            this.dsCutSize.LoadTrigger = null;
            this.dsCutSize.RefreshValve = 1000;
            this.dsCutSize.SourceCommand = null;
            this.dsCutSize.SourceCondition = "Code_Group = \'CutAdvice_Size\'";
            this.dsCutSize.SourceMethod = "";
            this.dsCutSize.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsCutSize.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsCutSize.SubscribeTarget = null;
            this.dsCutSize.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsCutSize});
            this.dsCutSize.UpdateEvent = "Click";
            this.dsCutSize.UpdateMethod = null;
            this.dsCutSize.UpdateTrigger = null;
            // 
            // schemadsCutSize
            // 
            this.schemadsCutSize.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsCutSizeL3DataTableCode,
            this.coldsCutSizeL3DataTableCode_Des});
            this.schemadsCutSize.TableName = "L3DataTable";
            // 
            // coldsCutSizeL3DataTableCode
            // 
            this.coldsCutSizeL3DataTableCode.Caption = "Code";
            this.coldsCutSizeL3DataTableCode.ColumnName = "Code";
            this.coldsCutSizeL3DataTableCode.Namespace = "";
            // 
            // coldsCutSizeL3DataTableCode_Des
            // 
            this.coldsCutSizeL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsCutSizeL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsCutSizeL3DataTableCode_Des.Namespace = "";
            // 
            // cUTMARKDataGridViewTextBoxColumn
            // 
            this.cUTMARKDataGridViewTextBoxColumn.DataPropertyName = "CUT_MARK";
            this.cUTMARKDataGridViewTextBoxColumn.HeaderText = "取样标识";
            this.cUTMARKDataGridViewTextBoxColumn.Name = "cUTMARKDataGridViewTextBoxColumn";
            this.cUTMARKDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUTMARKDataGridViewTextBoxColumn.Width = 78;
            // 
            // lOGTIMEDataGridViewTextBoxColumn
            // 
            this.lOGTIMEDataGridViewTextBoxColumn.DataPropertyName = "LOG_TIME";
            this.lOGTIMEDataGridViewTextBoxColumn.HeaderText = "通知时刻";
            this.lOGTIMEDataGridViewTextBoxColumn.Name = "lOGTIMEDataGridViewTextBoxColumn";
            this.lOGTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOGTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // coldsCutAdviceL3DataTablePROTOCOL
            // 
            this.coldsCutAdviceL3DataTablePROTOCOL.Caption = "PROTOCOL";
            this.coldsCutAdviceL3DataTablePROTOCOL.ColumnName = "PROTOCOL";
            this.coldsCutAdviceL3DataTablePROTOCOL.Namespace = "";
            // 
            // CutAdviceFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 564);
            this.Controls.Add(this.hmiRootPanel1);
            this.Controls.Add(this.bn1);
            this.Controls.Add(this.tSp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CutAdviceFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "割样通知管理";
            this.Text = "CutAdviceFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CutAdviceFrm_FormClosing);
            this.Load += new System.EventHandler(this.CutAdviceFrm_Load);
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bn1)).EndInit();
            this.bn1.ResumeLayout(false);
            this.bn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCutAdvice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutAdvice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutAdvice)).EndInit();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCutAdvice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCutSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsCutSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.BindingNavigator bn1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvCutAdvice;
        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsCutAdvice;
        private System.Data.DataTable schemadsCutAdvice;
        private System.Data.DataColumn coldsCutAdviceL3DataTableGUID;
        private System.Data.DataColumn coldsCutAdviceL3DataTableNAME;
        private System.Data.DataColumn coldsCutAdviceL3DataTableHEATID;
        private System.Data.DataColumn coldsCutAdviceL3DataTableSTEELGRADE;
        private System.Data.DataColumn coldsCutAdviceL3DataTableCUT_COUNT;
        private System.Data.DataColumn coldsCutAdviceL3DataTableCUT_POSITION;
        private System.Data.DataColumn coldsCutAdviceL3DataTableCUT_DIMEN;
        private System.Data.DataColumn coldsCutAdviceL3DataTableCUT_MARK;
        private System.Data.DataColumn coldsCutAdviceL3DataTableLOG_TIME;
        private System.Windows.Forms.BindingSource bsCutAdvice;
        private System.Data.DataColumn coldsCutAdviceL3DataTableCASTERID;
        private AppSvrHMI.L3DataSet dsCutPosition;
        private AppSvrHMI.L3DataSet dsCutSize;
        private System.Data.DataTable schemadsCutSize;
        private System.Data.DataColumn coldsCutSizeL3DataTableCode;
        private System.Data.DataColumn coldsCutSizeL3DataTableCode_Des;
        private System.Data.DataTable schemadsCutPosition;
        private System.Data.DataColumn coldsCutPositionL3DataTableCode;
        private System.Data.DataColumn coldsCutPositionL3DataTableCode_Des;
        private System.Data.DataColumn coldsCutAdviceL3DataTableSTEELGRADEINDEX;
        private System.Data.DataColumn coldsCutAdviceL3DataTablePROTOCOL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTEELGRADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASTERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STEELGRADEINDEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROTOCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUTCOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cUTPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cUTDIMENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUTMARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGTIMEDataGridViewTextBoxColumn;
    }
}