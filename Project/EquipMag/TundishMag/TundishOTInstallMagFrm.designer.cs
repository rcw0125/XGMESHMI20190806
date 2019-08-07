namespace EquipMag.TundishMag
{
    partial class TundishOTInstallMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishOTInstallMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsInstall = new System.Windows.Forms.BindingSource(this.components);
            this.dsInstall = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsInstall = new System.Data.DataTable();
            this.coldsInstallL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNAME = new System.Data.DataColumn();
            this.coldsInstallL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableDAUB_FAC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableFRA_CASE = new System.Data.DataColumn();
            this.coldsInstallL3DataTableSLIP_BLO_FAC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableGAP_FAC = new System.Data.DataColumn();
            this.coldsInstallL3DataTableINSTALL_PER = new System.Data.DataColumn();
            this.coldsInstallL3DataTableINSTALL_TIME = new System.Data.DataColumn();
            this.coldsInstallL3DataTableNote = new System.Data.DataColumn();
            this.coldsInstallL3DataTableWorkID = new System.Data.DataColumn();
            this.coldsInstallL3DataTableConfirm_Flag = new System.Data.DataColumn();
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bnInstall = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmbTundishID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvInstall = new System.Windows.Forms.DataGridView();
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            this.tundishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUBFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fRACASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLIPBLOFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAPFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTALLPERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNSTALLTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnInstall)).BeginInit();
            this.bnInstall.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInstall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInstall
            // 
            this.bsInstall.DataMember = "L3DataTable";
            this.bsInstall.DataSource = this.dsInstall;
            // 
            // dsInstall
            // 
            this.dsInstall.AutoSubscribe = false;
            this.dsInstall.DataSetName = "L3DataSet";
            this.dsInstall.DeleteMethod = "";
            this.dsInstall.InsertMethod = "";
            this.dsInstall.L3DataAdapter = this.Adapter;
            this.dsInstall.LoadEvent = "Click";
            this.dsInstall.LoadTrigger = null;
            this.dsInstall.RefreshValve = 1000;
            this.dsInstall.SourceCommand = null;
            this.dsInstall.SourceCondition = "1=2";
            this.dsInstall.SourceMethod = "";
            this.dsInstall.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInstall.SourceURI = "XGMESLogic\\TundishMag\\CTundish_OT_Install";
            this.dsInstall.SubscribeTarget = null;
            this.dsInstall.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInstall});
            this.dsInstall.UpdateEvent = "Click";
            this.dsInstall.UpdateMethod = "UpdateTundishOTInstallInfo";
            this.dsInstall.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsInstall
            // 
            this.schemadsInstall.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInstallL3DataTableGUID,
            this.coldsInstallL3DataTableNAME,
            this.coldsInstallL3DataTableTundishID,
            this.coldsInstallL3DataTableDAUB_FAC,
            this.coldsInstallL3DataTableFRA_CASE,
            this.coldsInstallL3DataTableSLIP_BLO_FAC,
            this.coldsInstallL3DataTableGAP_FAC,
            this.coldsInstallL3DataTableINSTALL_PER,
            this.coldsInstallL3DataTableINSTALL_TIME,
            this.coldsInstallL3DataTableNote,
            this.coldsInstallL3DataTableWorkID,
            this.coldsInstallL3DataTableConfirm_Flag});
            this.schemadsInstall.TableName = "L3DataTable";
            // 
            // coldsInstallL3DataTableGUID
            // 
            this.coldsInstallL3DataTableGUID.Caption = "GUID";
            this.coldsInstallL3DataTableGUID.ColumnName = "GUID";
            this.coldsInstallL3DataTableGUID.Namespace = "";
            // 
            // coldsInstallL3DataTableNAME
            // 
            this.coldsInstallL3DataTableNAME.Caption = "Name";
            this.coldsInstallL3DataTableNAME.ColumnName = "NAME";
            this.coldsInstallL3DataTableNAME.Namespace = "";
            // 
            // coldsInstallL3DataTableTundishID
            // 
            this.coldsInstallL3DataTableTundishID.Caption = "TundishID";
            this.coldsInstallL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsInstallL3DataTableTundishID.Namespace = "";
            // 
            // coldsInstallL3DataTableDAUB_FAC
            // 
            this.coldsInstallL3DataTableDAUB_FAC.Caption = "Daub_Fac";
            this.coldsInstallL3DataTableDAUB_FAC.ColumnName = "DAUB_FAC";
            this.coldsInstallL3DataTableDAUB_FAC.Namespace = "";
            // 
            // coldsInstallL3DataTableFRA_CASE
            // 
            this.coldsInstallL3DataTableFRA_CASE.Caption = "Fra_Case";
            this.coldsInstallL3DataTableFRA_CASE.ColumnName = "FRA_CASE";
            this.coldsInstallL3DataTableFRA_CASE.Namespace = "";
            // 
            // coldsInstallL3DataTableSLIP_BLO_FAC
            // 
            this.coldsInstallL3DataTableSLIP_BLO_FAC.Caption = "Slip_Blo_Fac";
            this.coldsInstallL3DataTableSLIP_BLO_FAC.ColumnName = "SLIP_BLO_FAC";
            this.coldsInstallL3DataTableSLIP_BLO_FAC.Namespace = "";
            // 
            // coldsInstallL3DataTableGAP_FAC
            // 
            this.coldsInstallL3DataTableGAP_FAC.Caption = "Gap_Fac";
            this.coldsInstallL3DataTableGAP_FAC.ColumnName = "GAP_FAC";
            this.coldsInstallL3DataTableGAP_FAC.Namespace = "";
            // 
            // coldsInstallL3DataTableINSTALL_PER
            // 
            this.coldsInstallL3DataTableINSTALL_PER.Caption = "Install_Per";
            this.coldsInstallL3DataTableINSTALL_PER.ColumnName = "INSTALL_PER";
            this.coldsInstallL3DataTableINSTALL_PER.Namespace = "";
            // 
            // coldsInstallL3DataTableINSTALL_TIME
            // 
            this.coldsInstallL3DataTableINSTALL_TIME.Caption = "Install_Time";
            this.coldsInstallL3DataTableINSTALL_TIME.ColumnName = "INSTALL_TIME";
            this.coldsInstallL3DataTableINSTALL_TIME.DataType = typeof(System.DateTime);
            this.coldsInstallL3DataTableINSTALL_TIME.Namespace = "";
            // 
            // coldsInstallL3DataTableNote
            // 
            this.coldsInstallL3DataTableNote.Caption = "Note";
            this.coldsInstallL3DataTableNote.ColumnName = "Note";
            this.coldsInstallL3DataTableNote.Namespace = "";
            // 
            // coldsInstallL3DataTableWorkID
            // 
            this.coldsInstallL3DataTableWorkID.Caption = "WorkID";
            this.coldsInstallL3DataTableWorkID.ColumnName = "WorkID";
            this.coldsInstallL3DataTableWorkID.Namespace = "";
            // 
            // coldsInstallL3DataTableConfirm_Flag
            // 
            this.coldsInstallL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsInstallL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsInstallL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsInstallL3DataTableConfirm_Flag.Namespace = "";
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
            this.dsShiftID.SourceCondition = "code_group = \'ShiftID\'";
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
            this.coldsShiftIDL3DataTableCode,
            this.coldsShiftIDL3DataTableCode_Des});
            this.schemadsShiftID.TableName = "L3DataTable";
            // 
            // coldsShiftIDL3DataTableCode
            // 
            this.coldsShiftIDL3DataTableCode.Caption = "Code";
            this.coldsShiftIDL3DataTableCode.ColumnName = "Code";
            this.coldsShiftIDL3DataTableCode.Namespace = "";
            // 
            // coldsShiftIDL3DataTableCode_Des
            // 
            this.coldsShiftIDL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsShiftIDL3DataTableCode_Des.Namespace = "";
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
            this.dsTeamID.SourceCondition = "code_group = \'TeamID\'";
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
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bnInstall, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 1);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 2;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 289F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 2;
            // 
            // bnInstall
            // 
            this.bnInstall.AddNewItem = null;
            this.bnInstall.AutoSize = false;
            this.bnInstall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnInstall.BackgroundImage")));
            this.bnInstall.BindingSource = this.bsInstall;
            this.bnInstall.CountItem = this.bindingNavigatorCountItem;
            this.bnInstall.DeleteItem = null;
            this.bnInstall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.btnQuery,
            this.toolStripLabel4,
            this.dtEnd,
            this.toolStripLabel3,
            this.dtStart,
            this.toolStripLabel2,
            this.cmbTundishID,
            this.toolStripLabel5,
            this.btnOutput});
            this.bnInstall.Location = new System.Drawing.Point(0, 0);
            this.bnInstall.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnInstall.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnInstall.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnInstall.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnInstall.Name = "bnInstall";
            this.bnInstall.PositionItem = this.bindingNavigatorPositionItem;
            this.bnInstall.Size = new System.Drawing.Size(1000, 25);
            this.bnInstall.TabIndex = 27;
            this.bnInstall.Text = "bindingNavigator1";
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
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.AutoSize = false;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel4.Text = " ";
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
            this.dtEnd.Text = "2008-11-18";
            this.dtEnd.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 197);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(11, 22);
            this.toolStripLabel3.Text = "-";
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
            this.dtStart.Text = "2008-11-18";
            this.dtStart.Value = new System.DateTime(2008, 11, 18, 19, 59, 16, 147);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "录入日期:";
            // 
            // cmbTundishID
            // 
            this.cmbTundishID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbTundishID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTundishID.Name = "cmbTundishID";
            this.cmbTundishID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(47, 22);
            this.toolStripLabel5.Text = "中包号:";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(91, 22);
            this.btnOutput.Text = "导出到Excel";
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.Controls.Add(this.dvInstall);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 675);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvInstall
            // 
            this.dvInstall.AllowUserToAddRows = false;
            this.dvInstall.AutoGenerateColumns = false;
            this.dvInstall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInstall.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvInstall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tundishIDDataGridViewTextBoxColumn,
            this.workIDDataGridViewTextBoxColumn,
            this.dAUBFACDataGridViewTextBoxColumn,
            this.fRACASEDataGridViewTextBoxColumn,
            this.sLIPBLOFACDataGridViewTextBoxColumn,
            this.gAPFACDataGridViewTextBoxColumn,
            this.iNSTALLPERDataGridViewTextBoxColumn,
            this.iNSTALLTIMEDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.confirmFlagDataGridViewTextBoxColumn});
            this.dvInstall.DataSource = this.bsInstall;
            this.dvInstall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInstall.Location = new System.Drawing.Point(0, 0);
            this.dvInstall.Margin = new System.Windows.Forms.Padding(0);
            this.dvInstall.Name = "dvInstall";
            this.dvInstall.ReadOnly = true;
            this.dvInstall.RowTemplate.Height = 23;
            this.dvInstall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInstall.Size = new System.Drawing.Size(1000, 675);
            this.dvInstall.TabIndex = 31;
            this.dvInstall.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInstall_DataError);
            // 
            // dsTundishID
            // 
            this.dsTundishID.AutoSubscribe = false;
            this.dsTundishID.DataSetName = "L3DataSet";
            this.dsTundishID.DeleteMethod = null;
            this.dsTundishID.InsertMethod = null;
            this.dsTundishID.L3DataAdapter = this.Adapter;
            this.dsTundishID.LoadEvent = "Click";
            this.dsTundishID.LoadTrigger = null;
            this.dsTundishID.RefreshValve = 1000;
            this.dsTundishID.SourceCommand = null;
            this.dsTundishID.SourceCondition = "";
            this.dsTundishID.SourceMethod = "";
            this.dsTundishID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsTundishID.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Base";
            this.dsTundishID.SubscribeTarget = null;
            this.dsTundishID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTundishID});
            this.dsTundishID.UpdateEvent = "Click";
            this.dsTundishID.UpdateMethod = null;
            this.dsTundishID.UpdateTrigger = null;
            // 
            // schemadsTundishID
            // 
            this.schemadsTundishID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTundishIDL3DataTableTundishID});
            this.schemadsTundishID.TableName = "L3DataTable";
            // 
            // coldsTundishIDL3DataTableTundishID
            // 
            this.coldsTundishIDL3DataTableTundishID.Caption = "TundishID";
            this.coldsTundishIDL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsTundishIDL3DataTableTundishID.Namespace = "";
            // 
            // tundishIDDataGridViewTextBoxColumn
            // 
            this.tundishIDDataGridViewTextBoxColumn.DataPropertyName = "TundishID";
            this.tundishIDDataGridViewTextBoxColumn.Frozen = true;
            this.tundishIDDataGridViewTextBoxColumn.HeaderText = "包号";
            this.tundishIDDataGridViewTextBoxColumn.Name = "tundishIDDataGridViewTextBoxColumn";
            this.tundishIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tundishIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // workIDDataGridViewTextBoxColumn
            // 
            this.workIDDataGridViewTextBoxColumn.DataPropertyName = "WorkID";
            this.workIDDataGridViewTextBoxColumn.HeaderText = "工作层编号";
            this.workIDDataGridViewTextBoxColumn.Name = "workIDDataGridViewTextBoxColumn";
            this.workIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.workIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // dAUBFACDataGridViewTextBoxColumn
            // 
            this.dAUBFACDataGridViewTextBoxColumn.DataPropertyName = "DAUB_FAC";
            this.dAUBFACDataGridViewTextBoxColumn.HeaderText = "涂料厂家";
            this.dAUBFACDataGridViewTextBoxColumn.Name = "dAUBFACDataGridViewTextBoxColumn";
            this.dAUBFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.dAUBFACDataGridViewTextBoxColumn.Width = 78;
            // 
            // fRACASEDataGridViewTextBoxColumn
            // 
            this.fRACASEDataGridViewTextBoxColumn.DataPropertyName = "FRA_CASE";
            this.fRACASEDataGridViewTextBoxColumn.HeaderText = "机构情况";
            this.fRACASEDataGridViewTextBoxColumn.Name = "fRACASEDataGridViewTextBoxColumn";
            this.fRACASEDataGridViewTextBoxColumn.ReadOnly = true;
            this.fRACASEDataGridViewTextBoxColumn.Width = 78;
            // 
            // sLIPBLOFACDataGridViewTextBoxColumn
            // 
            this.sLIPBLOFACDataGridViewTextBoxColumn.DataPropertyName = "SLIP_BLO_FAC";
            this.sLIPBLOFACDataGridViewTextBoxColumn.HeaderText = "滑块厂家";
            this.sLIPBLOFACDataGridViewTextBoxColumn.Name = "sLIPBLOFACDataGridViewTextBoxColumn";
            this.sLIPBLOFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.sLIPBLOFACDataGridViewTextBoxColumn.Width = 78;
            // 
            // gAPFACDataGridViewTextBoxColumn
            // 
            this.gAPFACDataGridViewTextBoxColumn.DataPropertyName = "GAP_FAC";
            this.gAPFACDataGridViewTextBoxColumn.HeaderText = "上水口厂家";
            this.gAPFACDataGridViewTextBoxColumn.Name = "gAPFACDataGridViewTextBoxColumn";
            this.gAPFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.gAPFACDataGridViewTextBoxColumn.Width = 90;
            // 
            // iNSTALLPERDataGridViewTextBoxColumn
            // 
            this.iNSTALLPERDataGridViewTextBoxColumn.DataPropertyName = "INSTALL_PER";
            this.iNSTALLPERDataGridViewTextBoxColumn.HeaderText = "安装人";
            this.iNSTALLPERDataGridViewTextBoxColumn.Name = "iNSTALLPERDataGridViewTextBoxColumn";
            this.iNSTALLPERDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSTALLPERDataGridViewTextBoxColumn.Width = 66;
            // 
            // iNSTALLTIMEDataGridViewTextBoxColumn
            // 
            this.iNSTALLTIMEDataGridViewTextBoxColumn.DataPropertyName = "INSTALL_TIME";
            dataGridViewCellStyle1.Format = "d";
            this.iNSTALLTIMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.iNSTALLTIMEDataGridViewTextBoxColumn.HeaderText = "安装日期";
            this.iNSTALLTIMEDataGridViewTextBoxColumn.Name = "iNSTALLTIMEDataGridViewTextBoxColumn";
            this.iNSTALLTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNSTALLTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 54;
            // 
            // confirmFlagDataGridViewTextBoxColumn
            // 
            this.confirmFlagDataGridViewTextBoxColumn.DataPropertyName = "Confirm_Flag";
            this.confirmFlagDataGridViewTextBoxColumn.HeaderText = "实绩确认标志";
            this.confirmFlagDataGridViewTextBoxColumn.Name = "confirmFlagDataGridViewTextBoxColumn";
            this.confirmFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.confirmFlagDataGridViewTextBoxColumn.Visible = false;
            this.confirmFlagDataGridViewTextBoxColumn.Width = 102;
            // 
            // TundishOTInstallMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishOTInstallMagFrm";
            this.TabText = "1、2#铸机中包上件实绩";
            this.Text = "中包上件实绩查询";
            this.Load += new System.EventHandler(this.TundishInstallMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnInstall)).EndInit();
            this.bnInstall.ResumeLayout(false);
            this.bnInstall.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInstall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsInstall;
        private System.Windows.Forms.BindingSource bsInstall;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bnInstall;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvInstall;
        private System.Data.DataTable schemadsInstall;
        private System.Data.DataColumn coldsInstallL3DataTableGUID;
        private System.Data.DataColumn coldsInstallL3DataTableNAME;
        private System.Data.DataColumn coldsInstallL3DataTableTundishID;
        private System.Data.DataColumn coldsInstallL3DataTableDAUB_FAC;
        private System.Data.DataColumn coldsInstallL3DataTableFRA_CASE;
        private System.Data.DataColumn coldsInstallL3DataTableSLIP_BLO_FAC;
        private System.Data.DataColumn coldsInstallL3DataTableGAP_FAC;
        private System.Data.DataColumn coldsInstallL3DataTableINSTALL_PER;
        private System.Data.DataColumn coldsInstallL3DataTableINSTALL_TIME;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Data.DataColumn coldsInstallL3DataTableNote;
        private System.Windows.Forms.ToolStripComboBox cmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Data.DataColumn coldsInstallL3DataTableWorkID;
        private System.Data.DataColumn coldsInstallL3DataTableConfirm_Flag;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAUBFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fRACASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLIPBLOFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gAPFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTALLPERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNSTALLTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmFlagDataGridViewTextBoxColumn;
    }
}