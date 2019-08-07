namespace EquipMag.TundishMag
{
    partial class TundishInnerBuildMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TundishInnerBuildMagFrm));
            this.bsInnerBuild = new System.Windows.Forms.BindingSource(this.components);
            this.dsInnerBuild = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.schemadsInnerBuild = new System.Data.DataTable();
            this.coldsInnerBuildL3DataTableGUID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableNAME = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTundishID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTIE_START_TIME = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTIE_END_TIME = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableREFRA_FAC = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableREFRA_ID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableWASTE = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableCHECK_DATE = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableInnerID = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableInner_Use_Count = new System.Data.DataColumn();
            this.coldsInnerBuildL3DataTableConfirm_Flag = new System.Data.DataColumn();
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
            this.bnInnerBuild = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dvInnerBuild = new System.Windows.Forms.DataGridView();
            this.dsTundishID = new AppSvrHMI.L3DataSet();
            this.schemadsTundishID = new System.Data.DataTable();
            this.coldsTundishIDL3DataTableTundishID = new System.Data.DataColumn();
            this.tundishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerUseCountDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIESTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIEENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFRAFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFRAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wASTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHECKDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmFlagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnInnerBuild)).BeginInit();
            this.bnInnerBuild.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInnerBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsInnerBuild
            // 
            this.bsInnerBuild.DataMember = "L3DataTable";
            this.bsInnerBuild.DataSource = this.dsInnerBuild;
            this.bsInnerBuild.Sort = "";
            // 
            // dsInnerBuild
            // 
            this.dsInnerBuild.AutoSubscribe = false;
            this.dsInnerBuild.DataSetName = "L3DataSet";
            this.dsInnerBuild.DeleteMethod = "";
            this.dsInnerBuild.InsertMethod = "";
            this.dsInnerBuild.L3DataAdapter = this.Adapter;
            this.dsInnerBuild.LoadEvent = "Click";
            this.dsInnerBuild.LoadTrigger = null;
            this.dsInnerBuild.RefreshValve = 1000;
            this.dsInnerBuild.SourceCommand = null;
            this.dsInnerBuild.SourceCondition = "1=2";
            this.dsInnerBuild.SourceMethod = "";
            this.dsInnerBuild.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsInnerBuild.SourceURI = "XGMESLogic\\TundishMag\\CTundish_Inner_Build";
            this.dsInnerBuild.SubscribeTarget = null;
            this.dsInnerBuild.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsInnerBuild});
            this.dsInnerBuild.UpdateEvent = "Click";
            this.dsInnerBuild.UpdateMethod = "";
            this.dsInnerBuild.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // schemadsInnerBuild
            // 
            this.schemadsInnerBuild.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsInnerBuildL3DataTableGUID,
            this.coldsInnerBuildL3DataTableNAME,
            this.coldsInnerBuildL3DataTableTundishID,
            this.coldsInnerBuildL3DataTableTIE_START_TIME,
            this.coldsInnerBuildL3DataTableTIE_END_TIME,
            this.coldsInnerBuildL3DataTableREFRA_FAC,
            this.coldsInnerBuildL3DataTableREFRA_ID,
            this.coldsInnerBuildL3DataTableWASTE,
            this.coldsInnerBuildL3DataTableCHECK_DATE,
            this.coldsInnerBuildL3DataTableTEAMID,
            this.coldsInnerBuildL3DataTableSHIFTID,
            this.coldsInnerBuildL3DataTableOPERATOR,
            this.coldsInnerBuildL3DataTableNOTE,
            this.coldsInnerBuildL3DataTableInnerID,
            this.coldsInnerBuildL3DataTableInner_Use_Count,
            this.coldsInnerBuildL3DataTableConfirm_Flag});
            this.schemadsInnerBuild.TableName = "L3DataTable";
            // 
            // coldsInnerBuildL3DataTableGUID
            // 
            this.coldsInnerBuildL3DataTableGUID.Caption = "GUID";
            this.coldsInnerBuildL3DataTableGUID.ColumnName = "GUID";
            this.coldsInnerBuildL3DataTableGUID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableNAME
            // 
            this.coldsInnerBuildL3DataTableNAME.Caption = "Name";
            this.coldsInnerBuildL3DataTableNAME.ColumnName = "NAME";
            this.coldsInnerBuildL3DataTableNAME.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableTundishID
            // 
            this.coldsInnerBuildL3DataTableTundishID.Caption = "TundishID";
            this.coldsInnerBuildL3DataTableTundishID.ColumnName = "TundishID";
            this.coldsInnerBuildL3DataTableTundishID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableTIE_START_TIME
            // 
            this.coldsInnerBuildL3DataTableTIE_START_TIME.Caption = "Tie_Start_Time";
            this.coldsInnerBuildL3DataTableTIE_START_TIME.ColumnName = "TIE_START_TIME";
            this.coldsInnerBuildL3DataTableTIE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsInnerBuildL3DataTableTIE_START_TIME.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableTIE_END_TIME
            // 
            this.coldsInnerBuildL3DataTableTIE_END_TIME.Caption = "Tie_End_Time";
            this.coldsInnerBuildL3DataTableTIE_END_TIME.ColumnName = "TIE_END_TIME";
            this.coldsInnerBuildL3DataTableTIE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsInnerBuildL3DataTableTIE_END_TIME.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableREFRA_FAC
            // 
            this.coldsInnerBuildL3DataTableREFRA_FAC.Caption = "Refra_Fac";
            this.coldsInnerBuildL3DataTableREFRA_FAC.ColumnName = "REFRA_FAC";
            this.coldsInnerBuildL3DataTableREFRA_FAC.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableREFRA_ID
            // 
            this.coldsInnerBuildL3DataTableREFRA_ID.Caption = "Refra_ID";
            this.coldsInnerBuildL3DataTableREFRA_ID.ColumnName = "REFRA_ID";
            this.coldsInnerBuildL3DataTableREFRA_ID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableWASTE
            // 
            this.coldsInnerBuildL3DataTableWASTE.Caption = "Waste";
            this.coldsInnerBuildL3DataTableWASTE.ColumnName = "WASTE";
            this.coldsInnerBuildL3DataTableWASTE.DataType = typeof(double);
            this.coldsInnerBuildL3DataTableWASTE.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableCHECK_DATE
            // 
            this.coldsInnerBuildL3DataTableCHECK_DATE.Caption = "Check_Date";
            this.coldsInnerBuildL3DataTableCHECK_DATE.ColumnName = "CHECK_DATE";
            this.coldsInnerBuildL3DataTableCHECK_DATE.DataType = typeof(System.DateTime);
            this.coldsInnerBuildL3DataTableCHECK_DATE.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableTEAMID
            // 
            this.coldsInnerBuildL3DataTableTEAMID.Caption = "TeamID";
            this.coldsInnerBuildL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsInnerBuildL3DataTableTEAMID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableSHIFTID
            // 
            this.coldsInnerBuildL3DataTableSHIFTID.Caption = "ShiftID";
            this.coldsInnerBuildL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsInnerBuildL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableOPERATOR
            // 
            this.coldsInnerBuildL3DataTableOPERATOR.Caption = "Operator";
            this.coldsInnerBuildL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsInnerBuildL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableNOTE
            // 
            this.coldsInnerBuildL3DataTableNOTE.Caption = "Note";
            this.coldsInnerBuildL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsInnerBuildL3DataTableNOTE.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableInnerID
            // 
            this.coldsInnerBuildL3DataTableInnerID.Caption = "InnerID";
            this.coldsInnerBuildL3DataTableInnerID.ColumnName = "InnerID";
            this.coldsInnerBuildL3DataTableInnerID.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableInner_Use_Count
            // 
            this.coldsInnerBuildL3DataTableInner_Use_Count.Caption = "Inner_Use_Count";
            this.coldsInnerBuildL3DataTableInner_Use_Count.ColumnName = "Inner_Use_Count";
            this.coldsInnerBuildL3DataTableInner_Use_Count.DataType = typeof(short);
            this.coldsInnerBuildL3DataTableInner_Use_Count.Namespace = "";
            // 
            // coldsInnerBuildL3DataTableConfirm_Flag
            // 
            this.coldsInnerBuildL3DataTableConfirm_Flag.Caption = "Confirm_Flag";
            this.coldsInnerBuildL3DataTableConfirm_Flag.ColumnName = "Confirm_Flag";
            this.coldsInnerBuildL3DataTableConfirm_Flag.DataType = typeof(int);
            this.coldsInnerBuildL3DataTableConfirm_Flag.Namespace = "";
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
            this.tbLPM.Controls.Add(this.bnInnerBuild, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 1);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 2;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bnInnerBuild
            // 
            this.bnInnerBuild.AddNewItem = null;
            this.bnInnerBuild.AutoSize = false;
            this.bnInnerBuild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnInnerBuild.BackgroundImage")));
            this.bnInnerBuild.BindingSource = this.bsInnerBuild;
            this.bnInnerBuild.CountItem = this.bindingNavigatorCountItem;
            this.bnInnerBuild.DeleteItem = null;
            this.bnInnerBuild.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnInnerBuild.Location = new System.Drawing.Point(0, 0);
            this.bnInnerBuild.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnInnerBuild.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnInnerBuild.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnInnerBuild.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnInnerBuild.Name = "bnInnerBuild";
            this.bnInnerBuild.PositionItem = this.bindingNavigatorPositionItem;
            this.bnInnerBuild.Size = new System.Drawing.Size(1000, 25);
            this.bnInnerBuild.TabIndex = 27;
            this.bnInnerBuild.Text = "bindingNavigator1";
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
            this.hmiRootPanel1.Controls.Add(this.dvInnerBuild);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 25);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 675);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvInnerBuild
            // 
            this.dvInnerBuild.AllowUserToAddRows = false;
            this.dvInnerBuild.AutoGenerateColumns = false;
            this.dvInnerBuild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvInnerBuild.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dvInnerBuild.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tundishIDDataGridViewTextBoxColumn,
            this.innerIDDataGridViewTextBoxColumn,
            this.innerUseCountDataGridViewCheckBoxColumn,
            this.tIESTARTTIMEDataGridViewTextBoxColumn,
            this.tIEENDTIMEDataGridViewTextBoxColumn,
            this.rEFRAFACDataGridViewTextBoxColumn,
            this.rEFRAIDDataGridViewTextBoxColumn,
            this.wASTEDataGridViewTextBoxColumn,
            this.cHECKDATEDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.confirmFlagDataGridViewTextBoxColumn});
            this.dvInnerBuild.DataSource = this.bsInnerBuild;
            this.dvInnerBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvInnerBuild.Location = new System.Drawing.Point(0, 0);
            this.dvInnerBuild.Margin = new System.Windows.Forms.Padding(0);
            this.dvInnerBuild.Name = "dvInnerBuild";
            this.dvInnerBuild.ReadOnly = true;
            this.dvInnerBuild.RowTemplate.Height = 23;
            this.dvInnerBuild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvInnerBuild.Size = new System.Drawing.Size(1000, 675);
            this.dvInnerBuild.TabIndex = 31;
            this.dvInnerBuild.Sorted += new System.EventHandler(this.dvInnerBuild_Sorted);
            this.dvInnerBuild.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvInnerBuild_DataError);
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
            // innerIDDataGridViewTextBoxColumn
            // 
            this.innerIDDataGridViewTextBoxColumn.DataPropertyName = "InnerID";
            this.innerIDDataGridViewTextBoxColumn.HeaderText = "永久层编号";
            this.innerIDDataGridViewTextBoxColumn.Name = "innerIDDataGridViewTextBoxColumn";
            this.innerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.innerIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // innerUseCountDataGridViewCheckBoxColumn
            // 
            this.innerUseCountDataGridViewCheckBoxColumn.DataPropertyName = "Inner_Use_Count";
            this.innerUseCountDataGridViewCheckBoxColumn.HeaderText = "永久层使用次数";
            this.innerUseCountDataGridViewCheckBoxColumn.Name = "innerUseCountDataGridViewCheckBoxColumn";
            this.innerUseCountDataGridViewCheckBoxColumn.ReadOnly = true;
            this.innerUseCountDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.innerUseCountDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.innerUseCountDataGridViewCheckBoxColumn.Width = 95;
            // 
            // tIESTARTTIMEDataGridViewTextBoxColumn
            // 
            this.tIESTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "TIE_START_TIME";
            this.tIESTARTTIMEDataGridViewTextBoxColumn.HeaderText = "开始打结时间";
            this.tIESTARTTIMEDataGridViewTextBoxColumn.Name = "tIESTARTTIMEDataGridViewTextBoxColumn";
            this.tIESTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIESTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // tIEENDTIMEDataGridViewTextBoxColumn
            // 
            this.tIEENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "TIE_END_TIME";
            this.tIEENDTIMEDataGridViewTextBoxColumn.HeaderText = "结束打结时间";
            this.tIEENDTIMEDataGridViewTextBoxColumn.Name = "tIEENDTIMEDataGridViewTextBoxColumn";
            this.tIEENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIEENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // rEFRAFACDataGridViewTextBoxColumn
            // 
            this.rEFRAFACDataGridViewTextBoxColumn.DataPropertyName = "REFRA_FAC";
            this.rEFRAFACDataGridViewTextBoxColumn.HeaderText = "耐材产地";
            this.rEFRAFACDataGridViewTextBoxColumn.Name = "rEFRAFACDataGridViewTextBoxColumn";
            this.rEFRAFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEFRAFACDataGridViewTextBoxColumn.Width = 78;
            // 
            // rEFRAIDDataGridViewTextBoxColumn
            // 
            this.rEFRAIDDataGridViewTextBoxColumn.DataPropertyName = "REFRA_ID";
            this.rEFRAIDDataGridViewTextBoxColumn.HeaderText = "耐材名称";
            this.rEFRAIDDataGridViewTextBoxColumn.Name = "rEFRAIDDataGridViewTextBoxColumn";
            this.rEFRAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEFRAIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // wASTEDataGridViewTextBoxColumn
            // 
            this.wASTEDataGridViewTextBoxColumn.DataPropertyName = "WASTE";
            this.wASTEDataGridViewTextBoxColumn.HeaderText = "消耗量";
            this.wASTEDataGridViewTextBoxColumn.Name = "wASTEDataGridViewTextBoxColumn";
            this.wASTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.wASTEDataGridViewTextBoxColumn.Width = 66;
            // 
            // cHECKDATEDataGridViewTextBoxColumn
            // 
            this.cHECKDATEDataGridViewTextBoxColumn.DataPropertyName = "CHECK_DATE";
            this.cHECKDATEDataGridViewTextBoxColumn.HeaderText = "检查日期";
            this.cHECKDATEDataGridViewTextBoxColumn.Name = "cHECKDATEDataGridViewTextBoxColumn";
            this.cHECKDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHECKDATEDataGridViewTextBoxColumn.Width = 78;
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
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "责任人";
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
            // confirmFlagDataGridViewTextBoxColumn
            // 
            this.confirmFlagDataGridViewTextBoxColumn.DataPropertyName = "Confirm_Flag";
            this.confirmFlagDataGridViewTextBoxColumn.HeaderText = "实绩确认标志";
            this.confirmFlagDataGridViewTextBoxColumn.Name = "confirmFlagDataGridViewTextBoxColumn";
            this.confirmFlagDataGridViewTextBoxColumn.ReadOnly = true;
            this.confirmFlagDataGridViewTextBoxColumn.Visible = false;
            this.confirmFlagDataGridViewTextBoxColumn.Width = 102;
            // 
            // TundishInnerBuildMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TundishInnerBuildMagFrm";
            this.TabText = "中包永久层打结实绩管理";
            this.Text = "中包永久层打结实绩查询";
            this.Load += new System.EventHandler(this.TundishInnerBuildMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsInnerBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInnerBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsInnerBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnInnerBuild)).EndInit();
            this.bnInnerBuild.ResumeLayout(false);
            this.bnInnerBuild.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvInnerBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTundishID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTundishID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsInnerBuild;
        private System.Windows.Forms.BindingSource bsInnerBuild;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bnInnerBuild;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvInnerBuild;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Data.DataTable schemadsInnerBuild;
        private System.Data.DataColumn coldsInnerBuildL3DataTableGUID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableNAME;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTundishID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTIE_START_TIME;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTIE_END_TIME;
        private System.Data.DataColumn coldsInnerBuildL3DataTableREFRA_FAC;
        private System.Data.DataColumn coldsInnerBuildL3DataTableREFRA_ID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableWASTE;
        private System.Data.DataColumn coldsInnerBuildL3DataTableCHECK_DATE;
        private System.Data.DataColumn coldsInnerBuildL3DataTableTEAMID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableSHIFTID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableOPERATOR;
        private System.Data.DataColumn coldsInnerBuildL3DataTableNOTE;
        private AppSvrHMI.L3DataSet dsTundishID;
        private System.Data.DataTable schemadsTundishID;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox cmbTundishID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Data.DataColumn coldsTundishIDL3DataTableTundishID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableInnerID;
        private System.Data.DataColumn coldsInnerBuildL3DataTableInner_Use_Count;
        private System.Data.DataColumn coldsInnerBuildL3DataTableConfirm_Flag;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn tundishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innerUseCountDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIESTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIEENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFRAFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFRAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wASTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHECKDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmFlagDataGridViewTextBoxColumn;
    }
}