namespace EquipMag.VacTubeMag
{
    partial class HotSypUseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotSypUseMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.dsMain = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdMain = new AppSvrHMI.L3Command(this.components);
            this.cmdpMain = new AppSvrHMI.L3CommandParameter();
            this.schemadsMain = new System.Data.DataTable();
            this.coldsMainL3DataTableGUID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNAME = new System.Data.DataColumn();
            this.coldsMainL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableBUILD_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableHOT_SYP_ID = new System.Data.DataColumn();
            this.coldsMainL3DataTableREFRA_FAC = new System.Data.DataColumn();
            this.coldsMainL3DataTableON_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTablePOSITION = new System.Data.DataColumn();
            this.coldsMainL3DataTableON_TEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableON_SHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableON_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableON_AGE = new System.Data.DataColumn();
            this.coldsMainL3DataTableCUR_AGE = new System.Data.DataColumn();
            this.coldsMainL3DataTableTOTAL_AGE = new System.Data.DataColumn();
            this.coldsMainL3DataTableOFFLINE_TIME = new System.Data.DataColumn();
            this.coldsMainL3DataTableOFF_TEAMID = new System.Data.DataColumn();
            this.coldsMainL3DataTableOFF_REASON = new System.Data.DataColumn();
            this.coldsMainL3DataTableONLINE_LEN = new System.Data.DataColumn();
            this.coldsMainL3DataTableOFF_OPERATOR = new System.Data.DataColumn();
            this.coldsMainL3DataTableOFF_SHIFTID = new System.Data.DataColumn();
            this.coldsMainL3DataTableNOTE = new System.Data.DataColumn();
            this.l3cmdp = new AppSvrHMI.L3CommandParameter();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bdN1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.cmbVacTubeID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.tSp1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvM = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUILDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTSYPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFRAFACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNTEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.oNSHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.oNOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cURAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oNLINELENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFLINETIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oFFREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsOffLineReason = new AppSvrHMI.L3DataSet();
            this.schemadsOffLineReason = new System.Data.DataTable();
            this.coldsOffLineReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsOffLineReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.oFFTEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oFFSHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oFFOPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldsVacTubeIDL3DataTableVacTube_ID = new System.Data.DataColumn();
            this.schemadsVacTubeID = new System.Data.DataTable();
            this.dsVacTubeID = new AppSvrHMI.L3DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsVacTubeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVacTubeID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataMember = "L3DataTable";
            this.bsMain.DataSource = this.dsMain;
            // 
            // dsMain
            // 
            this.dsMain.AutoSubscribe = false;
            this.dsMain.DataSetName = "L3DataSet";
            this.dsMain.DeleteMethod = "DeleteHotSypUseInfo";
            this.dsMain.InsertMethod = "InsertHotSypUseInfo";
            this.dsMain.L3DataAdapter = this.Adapter;
            this.dsMain.LoadEvent = "";
            this.dsMain.LoadTrigger = null;
            this.dsMain.RefreshValve = 1000;
            this.dsMain.SourceCommand = this.cmdMain;
            this.dsMain.SourceCondition = "";
            this.dsMain.SourceMethod = "GetHotSypUseInfo";
            this.dsMain.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsMain.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Mag\\VacTubeMag";
            this.dsMain.SubscribeTarget = "";
            this.dsMain.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsMain});
            this.dsMain.UpdateEvent = "";
            this.dsMain.UpdateMethod = "UpdateHotSypUseInfo";
            this.dsMain.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdMain
            // 
            this.cmdMain.Adapter = null;
            this.cmdMain.MergeReturnTarget = false;
            this.cmdMain.Method = null;
            this.cmdMain.Object = null;
            this.cmdMain.Parameters.Add(this.cmdpMain);
            this.cmdMain.ReturnTarget = null;
            this.cmdMain.ReturnTargetProperty = null;
            this.cmdMain.Trigger = null;
            this.cmdMain.TriggerEvent = "Click";
            // 
            // cmdpMain
            // 
            this.cmdpMain.AcceptAfterExecuted = false;
            this.cmdpMain.ConstantValue = null;
            this.cmdpMain.MergeTarget = false;
            this.cmdpMain.SourceFilter = null;
            this.cmdpMain.SourceObject = null;
            this.cmdpMain.SourceProperty = null;
            this.cmdpMain.TargetObject = null;
            this.cmdpMain.TargetProperty = null;
            // 
            // schemadsMain
            // 
            this.schemadsMain.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsMainL3DataTableGUID,
            this.coldsMainL3DataTableNAME,
            this.coldsMainL3DataTableINPUT_TIME,
            this.coldsMainL3DataTableBUILD_ID,
            this.coldsMainL3DataTableHOT_SYP_ID,
            this.coldsMainL3DataTableREFRA_FAC,
            this.coldsMainL3DataTableON_TIME,
            this.coldsMainL3DataTablePOSITION,
            this.coldsMainL3DataTableON_TEAMID,
            this.coldsMainL3DataTableON_SHIFTID,
            this.coldsMainL3DataTableON_OPERATOR,
            this.coldsMainL3DataTableON_AGE,
            this.coldsMainL3DataTableCUR_AGE,
            this.coldsMainL3DataTableTOTAL_AGE,
            this.coldsMainL3DataTableOFFLINE_TIME,
            this.coldsMainL3DataTableOFF_TEAMID,
            this.coldsMainL3DataTableOFF_REASON,
            this.coldsMainL3DataTableONLINE_LEN,
            this.coldsMainL3DataTableOFF_OPERATOR,
            this.coldsMainL3DataTableOFF_SHIFTID,
            this.coldsMainL3DataTableNOTE});
            this.schemadsMain.TableName = "L3DataTable";
            // 
            // coldsMainL3DataTableGUID
            // 
            this.coldsMainL3DataTableGUID.Caption = "GUID";
            this.coldsMainL3DataTableGUID.ColumnName = "GUID";
            this.coldsMainL3DataTableGUID.DefaultValue = "";
            this.coldsMainL3DataTableGUID.Namespace = "";
            // 
            // coldsMainL3DataTableNAME
            // 
            this.coldsMainL3DataTableNAME.Caption = "NAME";
            this.coldsMainL3DataTableNAME.ColumnName = "NAME";
            this.coldsMainL3DataTableNAME.DefaultValue = "";
            this.coldsMainL3DataTableNAME.Namespace = "";
            // 
            // coldsMainL3DataTableINPUT_TIME
            // 
            this.coldsMainL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsMainL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableBUILD_ID
            // 
            this.coldsMainL3DataTableBUILD_ID.Caption = "BUILD_ID";
            this.coldsMainL3DataTableBUILD_ID.ColumnName = "BUILD_ID";
            this.coldsMainL3DataTableBUILD_ID.DefaultValue = "";
            this.coldsMainL3DataTableBUILD_ID.Namespace = "";
            // 
            // coldsMainL3DataTableHOT_SYP_ID
            // 
            this.coldsMainL3DataTableHOT_SYP_ID.Caption = "HOT_SYP_ID";
            this.coldsMainL3DataTableHOT_SYP_ID.ColumnName = "HOT_SYP_ID";
            this.coldsMainL3DataTableHOT_SYP_ID.DefaultValue = "";
            this.coldsMainL3DataTableHOT_SYP_ID.Namespace = "";
            // 
            // coldsMainL3DataTableREFRA_FAC
            // 
            this.coldsMainL3DataTableREFRA_FAC.Caption = "REFRA_FAC";
            this.coldsMainL3DataTableREFRA_FAC.ColumnName = "REFRA_FAC";
            this.coldsMainL3DataTableREFRA_FAC.DefaultValue = "";
            this.coldsMainL3DataTableREFRA_FAC.Namespace = "";
            // 
            // coldsMainL3DataTableON_TIME
            // 
            this.coldsMainL3DataTableON_TIME.Caption = "ON_TIME";
            this.coldsMainL3DataTableON_TIME.ColumnName = "ON_TIME";
            this.coldsMainL3DataTableON_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableON_TIME.Namespace = "";
            // 
            // coldsMainL3DataTablePOSITION
            // 
            this.coldsMainL3DataTablePOSITION.Caption = "POSITION";
            this.coldsMainL3DataTablePOSITION.ColumnName = "POSITION";
            this.coldsMainL3DataTablePOSITION.DefaultValue = "";
            this.coldsMainL3DataTablePOSITION.Namespace = "";
            // 
            // coldsMainL3DataTableON_TEAMID
            // 
            this.coldsMainL3DataTableON_TEAMID.Caption = "ON_TEAMID";
            this.coldsMainL3DataTableON_TEAMID.ColumnName = "ON_TEAMID";
            this.coldsMainL3DataTableON_TEAMID.DefaultValue = "";
            this.coldsMainL3DataTableON_TEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableON_SHIFTID
            // 
            this.coldsMainL3DataTableON_SHIFTID.Caption = "ON_SHIFTID";
            this.coldsMainL3DataTableON_SHIFTID.ColumnName = "ON_SHIFTID";
            this.coldsMainL3DataTableON_SHIFTID.DefaultValue = "";
            this.coldsMainL3DataTableON_SHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableON_OPERATOR
            // 
            this.coldsMainL3DataTableON_OPERATOR.Caption = "ON_OPERATOR";
            this.coldsMainL3DataTableON_OPERATOR.ColumnName = "ON_OPERATOR";
            this.coldsMainL3DataTableON_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableON_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableON_AGE
            // 
            this.coldsMainL3DataTableON_AGE.Caption = "ON_AGE";
            this.coldsMainL3DataTableON_AGE.ColumnName = "ON_AGE";
            this.coldsMainL3DataTableON_AGE.DataType = typeof(int);
            this.coldsMainL3DataTableON_AGE.DefaultValue = 0;
            this.coldsMainL3DataTableON_AGE.Namespace = "";
            // 
            // coldsMainL3DataTableCUR_AGE
            // 
            this.coldsMainL3DataTableCUR_AGE.Caption = "CUR_AGE";
            this.coldsMainL3DataTableCUR_AGE.ColumnName = "CUR_AGE";
            this.coldsMainL3DataTableCUR_AGE.DataType = typeof(int);
            this.coldsMainL3DataTableCUR_AGE.DefaultValue = 0;
            this.coldsMainL3DataTableCUR_AGE.Namespace = "";
            // 
            // coldsMainL3DataTableTOTAL_AGE
            // 
            this.coldsMainL3DataTableTOTAL_AGE.Caption = "TOTAL_AGE";
            this.coldsMainL3DataTableTOTAL_AGE.ColumnName = "TOTAL_AGE";
            this.coldsMainL3DataTableTOTAL_AGE.DataType = typeof(int);
            this.coldsMainL3DataTableTOTAL_AGE.DefaultValue = 0;
            this.coldsMainL3DataTableTOTAL_AGE.Namespace = "";
            // 
            // coldsMainL3DataTableOFFLINE_TIME
            // 
            this.coldsMainL3DataTableOFFLINE_TIME.Caption = "OFFLINE_TIME";
            this.coldsMainL3DataTableOFFLINE_TIME.ColumnName = "OFFLINE_TIME";
            this.coldsMainL3DataTableOFFLINE_TIME.DataType = typeof(System.DateTime);
            this.coldsMainL3DataTableOFFLINE_TIME.Namespace = "";
            // 
            // coldsMainL3DataTableOFF_TEAMID
            // 
            this.coldsMainL3DataTableOFF_TEAMID.Caption = "OFF_TEAMID";
            this.coldsMainL3DataTableOFF_TEAMID.ColumnName = "OFF_TEAMID";
            this.coldsMainL3DataTableOFF_TEAMID.DefaultValue = "";
            this.coldsMainL3DataTableOFF_TEAMID.Namespace = "";
            // 
            // coldsMainL3DataTableOFF_REASON
            // 
            this.coldsMainL3DataTableOFF_REASON.Caption = "OFF_REASON";
            this.coldsMainL3DataTableOFF_REASON.ColumnName = "OFF_REASON";
            this.coldsMainL3DataTableOFF_REASON.DefaultValue = "";
            this.coldsMainL3DataTableOFF_REASON.Namespace = "";
            // 
            // coldsMainL3DataTableONLINE_LEN
            // 
            this.coldsMainL3DataTableONLINE_LEN.Caption = "ONLINE_LEN";
            this.coldsMainL3DataTableONLINE_LEN.ColumnName = "ONLINE_LEN";
            this.coldsMainL3DataTableONLINE_LEN.DataType = typeof(double);
            this.coldsMainL3DataTableONLINE_LEN.DefaultValue = 0;
            this.coldsMainL3DataTableONLINE_LEN.Namespace = "";
            // 
            // coldsMainL3DataTableOFF_OPERATOR
            // 
            this.coldsMainL3DataTableOFF_OPERATOR.Caption = "OFF_OPERATOR";
            this.coldsMainL3DataTableOFF_OPERATOR.ColumnName = "OFF_OPERATOR";
            this.coldsMainL3DataTableOFF_OPERATOR.DefaultValue = "";
            this.coldsMainL3DataTableOFF_OPERATOR.Namespace = "";
            // 
            // coldsMainL3DataTableOFF_SHIFTID
            // 
            this.coldsMainL3DataTableOFF_SHIFTID.Caption = "OFF_SHIFTID";
            this.coldsMainL3DataTableOFF_SHIFTID.ColumnName = "OFF_SHIFTID";
            this.coldsMainL3DataTableOFF_SHIFTID.DefaultValue = "";
            this.coldsMainL3DataTableOFF_SHIFTID.Namespace = "";
            // 
            // coldsMainL3DataTableNOTE
            // 
            this.coldsMainL3DataTableNOTE.Caption = "NOTE";
            this.coldsMainL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsMainL3DataTableNOTE.DefaultValue = "";
            this.coldsMainL3DataTableNOTE.Namespace = "";
            // 
            // l3cmdp
            // 
            this.l3cmdp.AcceptAfterExecuted = false;
            this.l3cmdp.ConstantValue = null;
            this.l3cmdp.MergeTarget = false;
            this.l3cmdp.SourceFilter = null;
            this.l3cmdp.SourceObject = null;
            this.l3cmdp.SourceProperty = null;
            this.l3cmdp.TargetObject = null;
            this.l3cmdp.TargetProperty = null;
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bdN1, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bdN1
            // 
            this.bdN1.AddNewItem = null;
            this.bdN1.AutoSize = false;
            this.bdN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdN1.BackgroundImage")));
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
            this.cmbVacTubeID,
            this.toolStripLabel3,
            this.toolStripLabel5,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel6});
            this.bdN1.Location = new System.Drawing.Point(0, 43);
            this.bdN1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdN1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdN1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdN1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdN1.Name = "bdN1";
            this.bdN1.PositionItem = this.bindingNavigatorPositionItem;
            this.bdN1.Size = new System.Drawing.Size(1000, 25);
            this.bdN1.TabIndex = 27;
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
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
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
            // cmbVacTubeID
            // 
            this.cmbVacTubeID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbVacTubeID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbVacTubeID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVacTubeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacTubeID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVacTubeID.Name = "cmbVacTubeID";
            this.cmbVacTubeID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(71, 22);
            this.toolStripLabel3.Text = "热弯管编号:";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.AutoSize = false;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 22);
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
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "HotSypUsebtn");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "HotSypUsebtn");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "HotSypUsebtn");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "HotSypUsebtn");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.Adapter.SetAccessRight(this.btnCancel, "HotSypUsebtn");
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 40);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator3, "HotSypUsebtn");
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
            this.hmiRootPanel1.Controls.Add(this.dvM);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvM
            // 
            this.dvM.AllowUserToAddRows = false;
            this.dvM.AutoGenerateColumns = false;
            this.dvM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.bUILDIDDataGridViewTextBoxColumn,
            this.hOTSYPIDDataGridViewTextBoxColumn,
            this.rEFRAFACDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.oNTIMEDataGridViewTextBoxColumn,
            this.pOSITIONDataGridViewTextBoxColumn,
            this.oNTEAMIDDataGridViewTextBoxColumn,
            this.oNSHIFTIDDataGridViewTextBoxColumn,
            this.oNOPERATORDataGridViewTextBoxColumn,
            this.oNAGEDataGridViewTextBoxColumn,
            this.cURAGEDataGridViewTextBoxColumn,
            this.tOTALAGEDataGridViewTextBoxColumn,
            this.oNLINELENDataGridViewTextBoxColumn,
            this.oFFLINETIMEDataGridViewTextBoxColumn,
            this.oFFREASONDataGridViewTextBoxColumn,
            this.oFFTEAMIDDataGridViewTextBoxColumn,
            this.oFFSHIFTIDDataGridViewTextBoxColumn,
            this.oFFOPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsMain;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.Margin = new System.Windows.Forms.Padding(0);
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(1000, 632);
            this.dvM.TabIndex = 31;
            this.dvM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvM_CellDoubleClick);
            this.dvM.Sorted += new System.EventHandler(this.dvM_Sorted);
            this.dvM.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvM_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Frozen = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.HeaderText = "录入时间";
            this.iNPUTTIMEDataGridViewTextBoxColumn.Name = "iNPUTTIMEDataGridViewTextBoxColumn";
            this.iNPUTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iNPUTTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // bUILDIDDataGridViewTextBoxColumn
            // 
            this.bUILDIDDataGridViewTextBoxColumn.DataPropertyName = "BUILD_ID";
            this.bUILDIDDataGridViewTextBoxColumn.Frozen = true;
            this.bUILDIDDataGridViewTextBoxColumn.HeaderText = "砌筑编号";
            this.bUILDIDDataGridViewTextBoxColumn.Name = "bUILDIDDataGridViewTextBoxColumn";
            this.bUILDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bUILDIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // hOTSYPIDDataGridViewTextBoxColumn
            // 
            this.hOTSYPIDDataGridViewTextBoxColumn.DataPropertyName = "HOT_SYP_ID";
            this.hOTSYPIDDataGridViewTextBoxColumn.Frozen = true;
            this.hOTSYPIDDataGridViewTextBoxColumn.HeaderText = "热弯管编号";
            this.hOTSYPIDDataGridViewTextBoxColumn.Name = "hOTSYPIDDataGridViewTextBoxColumn";
            this.hOTSYPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hOTSYPIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // rEFRAFACDataGridViewTextBoxColumn
            // 
            this.rEFRAFACDataGridViewTextBoxColumn.DataPropertyName = "REFRA_FAC";
            this.rEFRAFACDataGridViewTextBoxColumn.HeaderText = "耐材厂家";
            this.rEFRAFACDataGridViewTextBoxColumn.Name = "rEFRAFACDataGridViewTextBoxColumn";
            this.rEFRAFACDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEFRAFACDataGridViewTextBoxColumn.Width = 78;
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
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // oNTIMEDataGridViewTextBoxColumn
            // 
            this.oNTIMEDataGridViewTextBoxColumn.DataPropertyName = "ON_TIME";
            this.oNTIMEDataGridViewTextBoxColumn.HeaderText = "上线时间";
            this.oNTIMEDataGridViewTextBoxColumn.Name = "oNTIMEDataGridViewTextBoxColumn";
            this.oNTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oNTIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // pOSITIONDataGridViewTextBoxColumn
            // 
            this.pOSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION";
            this.pOSITIONDataGridViewTextBoxColumn.HeaderText = "上线工位";
            this.pOSITIONDataGridViewTextBoxColumn.Name = "pOSITIONDataGridViewTextBoxColumn";
            this.pOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.pOSITIONDataGridViewTextBoxColumn.Width = 78;
            // 
            // oNTEAMIDDataGridViewTextBoxColumn
            // 
            this.oNTEAMIDDataGridViewTextBoxColumn.DataPropertyName = "ON_TEAMID";
            this.oNTEAMIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.oNTEAMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.oNTEAMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oNTEAMIDDataGridViewTextBoxColumn.HeaderText = "上线班组";
            this.oNTEAMIDDataGridViewTextBoxColumn.Name = "oNTEAMIDDataGridViewTextBoxColumn";
            this.oNTEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oNTEAMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oNTEAMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oNTEAMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.oNTEAMIDDataGridViewTextBoxColumn.Width = 78;
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
            // oNSHIFTIDDataGridViewTextBoxColumn
            // 
            this.oNSHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "ON_SHIFTID";
            this.oNSHIFTIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.oNSHIFTIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.oNSHIFTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oNSHIFTIDDataGridViewTextBoxColumn.HeaderText = "上线班次";
            this.oNSHIFTIDDataGridViewTextBoxColumn.Name = "oNSHIFTIDDataGridViewTextBoxColumn";
            this.oNSHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oNSHIFTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oNSHIFTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oNSHIFTIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.oNSHIFTIDDataGridViewTextBoxColumn.Width = 78;
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
            // oNOPERATORDataGridViewTextBoxColumn
            // 
            this.oNOPERATORDataGridViewTextBoxColumn.DataPropertyName = "ON_OPERATOR";
            this.oNOPERATORDataGridViewTextBoxColumn.HeaderText = "上线操作员";
            this.oNOPERATORDataGridViewTextBoxColumn.Name = "oNOPERATORDataGridViewTextBoxColumn";
            this.oNOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oNOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // oNAGEDataGridViewTextBoxColumn
            // 
            this.oNAGEDataGridViewTextBoxColumn.DataPropertyName = "ON_AGE";
            this.oNAGEDataGridViewTextBoxColumn.HeaderText = "上线寿命";
            this.oNAGEDataGridViewTextBoxColumn.Name = "oNAGEDataGridViewTextBoxColumn";
            this.oNAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oNAGEDataGridViewTextBoxColumn.Width = 78;
            // 
            // cURAGEDataGridViewTextBoxColumn
            // 
            this.cURAGEDataGridViewTextBoxColumn.DataPropertyName = "CUR_AGE";
            this.cURAGEDataGridViewTextBoxColumn.HeaderText = "在线寿命";
            this.cURAGEDataGridViewTextBoxColumn.Name = "cURAGEDataGridViewTextBoxColumn";
            this.cURAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cURAGEDataGridViewTextBoxColumn.Width = 78;
            // 
            // tOTALAGEDataGridViewTextBoxColumn
            // 
            this.tOTALAGEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_AGE";
            this.tOTALAGEDataGridViewTextBoxColumn.HeaderText = "累计寿命";
            this.tOTALAGEDataGridViewTextBoxColumn.Name = "tOTALAGEDataGridViewTextBoxColumn";
            this.tOTALAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALAGEDataGridViewTextBoxColumn.Width = 78;
            // 
            // oNLINELENDataGridViewTextBoxColumn
            // 
            this.oNLINELENDataGridViewTextBoxColumn.DataPropertyName = "ONLINE_LEN";
            dataGridViewCellStyle1.Format = "N1";
            this.oNLINELENDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.oNLINELENDataGridViewTextBoxColumn.HeaderText = "在线时长[天]";
            this.oNLINELENDataGridViewTextBoxColumn.Name = "oNLINELENDataGridViewTextBoxColumn";
            this.oNLINELENDataGridViewTextBoxColumn.ReadOnly = true;
            this.oNLINELENDataGridViewTextBoxColumn.Width = 102;
            // 
            // oFFLINETIMEDataGridViewTextBoxColumn
            // 
            this.oFFLINETIMEDataGridViewTextBoxColumn.DataPropertyName = "OFFLINE_TIME";
            this.oFFLINETIMEDataGridViewTextBoxColumn.HeaderText = "下线时间";
            this.oFFLINETIMEDataGridViewTextBoxColumn.Name = "oFFLINETIMEDataGridViewTextBoxColumn";
            this.oFFLINETIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFLINETIMEDataGridViewTextBoxColumn.Width = 78;
            // 
            // oFFREASONDataGridViewTextBoxColumn
            // 
            this.oFFREASONDataGridViewTextBoxColumn.DataPropertyName = "OFF_REASON";
            this.oFFREASONDataGridViewTextBoxColumn.DataSource = this.dsOffLineReason;
            this.oFFREASONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.oFFREASONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oFFREASONDataGridViewTextBoxColumn.HeaderText = "下线原因";
            this.oFFREASONDataGridViewTextBoxColumn.Name = "oFFREASONDataGridViewTextBoxColumn";
            this.oFFREASONDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFREASONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oFFREASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oFFREASONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.oFFREASONDataGridViewTextBoxColumn.Width = 78;
            // 
            // dsOffLineReason
            // 
            this.dsOffLineReason.AutoSubscribe = false;
            this.dsOffLineReason.DataSetName = "L3DataSet";
            this.dsOffLineReason.DeleteMethod = null;
            this.dsOffLineReason.InsertMethod = null;
            this.dsOffLineReason.L3DataAdapter = this.Adapter;
            this.dsOffLineReason.LoadEvent = "Click";
            this.dsOffLineReason.LoadTrigger = null;
            this.dsOffLineReason.RefreshValve = 1000;
            this.dsOffLineReason.SourceCommand = null;
            this.dsOffLineReason.SourceCondition = "CODE_GROUP = \'CVACTUBE_OFF_REASON\'";
            this.dsOffLineReason.SourceMethod = "";
            this.dsOffLineReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsOffLineReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsOffLineReason.SubscribeTarget = null;
            this.dsOffLineReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsOffLineReason});
            this.dsOffLineReason.UpdateEvent = "Click";
            this.dsOffLineReason.UpdateMethod = null;
            this.dsOffLineReason.UpdateTrigger = null;
            // 
            // schemadsOffLineReason
            // 
            this.schemadsOffLineReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsOffLineReasonL3DataTableCode,
            this.coldsOffLineReasonL3DataTableCode_Des});
            this.schemadsOffLineReason.TableName = "L3DataTable";
            // 
            // coldsOffLineReasonL3DataTableCode
            // 
            this.coldsOffLineReasonL3DataTableCode.Caption = "Code";
            this.coldsOffLineReasonL3DataTableCode.ColumnName = "Code";
            this.coldsOffLineReasonL3DataTableCode.Namespace = "";
            // 
            // coldsOffLineReasonL3DataTableCode_Des
            // 
            this.coldsOffLineReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsOffLineReasonL3DataTableCode_Des.Namespace = "";
            // 
            // oFFTEAMIDDataGridViewTextBoxColumn
            // 
            this.oFFTEAMIDDataGridViewTextBoxColumn.DataPropertyName = "OFF_TEAMID";
            this.oFFTEAMIDDataGridViewTextBoxColumn.DataSource = this.dsTeamID;
            this.oFFTEAMIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.oFFTEAMIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oFFTEAMIDDataGridViewTextBoxColumn.HeaderText = "下线班组";
            this.oFFTEAMIDDataGridViewTextBoxColumn.Name = "oFFTEAMIDDataGridViewTextBoxColumn";
            this.oFFTEAMIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFTEAMIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oFFTEAMIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oFFTEAMIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.oFFTEAMIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // oFFSHIFTIDDataGridViewTextBoxColumn
            // 
            this.oFFSHIFTIDDataGridViewTextBoxColumn.DataPropertyName = "OFF_SHIFTID";
            this.oFFSHIFTIDDataGridViewTextBoxColumn.DataSource = this.dsShiftID;
            this.oFFSHIFTIDDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.oFFSHIFTIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.oFFSHIFTIDDataGridViewTextBoxColumn.HeaderText = "下线班次";
            this.oFFSHIFTIDDataGridViewTextBoxColumn.Name = "oFFSHIFTIDDataGridViewTextBoxColumn";
            this.oFFSHIFTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFSHIFTIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.oFFSHIFTIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.oFFSHIFTIDDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.oFFSHIFTIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // oFFOPERATORDataGridViewTextBoxColumn
            // 
            this.oFFOPERATORDataGridViewTextBoxColumn.DataPropertyName = "OFF_OPERATOR";
            this.oFFOPERATORDataGridViewTextBoxColumn.HeaderText = "下线操作员";
            this.oFFOPERATORDataGridViewTextBoxColumn.Name = "oFFOPERATORDataGridViewTextBoxColumn";
            this.oFFOPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oFFOPERATORDataGridViewTextBoxColumn.Width = 90;
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "备注";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            this.nOTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOTEDataGridViewTextBoxColumn.Width = 54;
            // 
            // coldsVacTubeIDL3DataTableVacTube_ID
            // 
            this.coldsVacTubeIDL3DataTableVacTube_ID.Caption = "VacTube_ID";
            this.coldsVacTubeIDL3DataTableVacTube_ID.ColumnName = "VacTube_ID";
            this.coldsVacTubeIDL3DataTableVacTube_ID.Namespace = "";
            // 
            // schemadsVacTubeID
            // 
            this.schemadsVacTubeID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsVacTubeIDL3DataTableVacTube_ID});
            this.schemadsVacTubeID.TableName = "L3DataTable";
            // 
            // dsVacTubeID
            // 
            this.dsVacTubeID.AutoSubscribe = false;
            this.dsVacTubeID.DataSetName = "L3DataSet";
            this.dsVacTubeID.DeleteMethod = null;
            this.dsVacTubeID.InsertMethod = null;
            this.dsVacTubeID.L3DataAdapter = this.Adapter;
            this.dsVacTubeID.LoadEvent = "Click";
            this.dsVacTubeID.LoadTrigger = null;
            this.dsVacTubeID.RefreshValve = 1000;
            this.dsVacTubeID.SourceCommand = null;
            this.dsVacTubeID.SourceCondition = "VACTUBE_NAME = \'3\'";
            this.dsVacTubeID.SourceMethod = "";
            this.dsVacTubeID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsVacTubeID.SourceURI = "XGMESLogic\\VacTubeMag\\CVacTube_Base";
            this.dsVacTubeID.SubscribeTarget = null;
            this.dsVacTubeID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsVacTubeID});
            this.dsVacTubeID.UpdateEvent = "Click";
            this.dsVacTubeID.UpdateMethod = null;
            this.dsVacTubeID.UpdateTrigger = null;
            // 
            // HotSypUseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HotSypUseMagFrm";
            this.TabText = "热弯管使用实绩管理";
            this.Text = "热弯管使用实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotSpyUseMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.HotSpyUseMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsMain)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsOffLineReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsVacTubeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVacTubeID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bdN1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tSp1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnConfirm;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private HMIBase.HMIRootPanel hmiRootPanel1;
        private System.Windows.Forms.DataGridView dvM;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripComboBox cmbVacTubeID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private AppSvrHMI.L3DataSet dsOffLineReason;
        private System.Data.DataTable schemadsOffLineReason;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode;
        private System.Data.DataColumn coldsOffLineReasonL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private AppSvrHMI.L3CommandParameter l3cmdp;
        private System.Data.DataColumn coldsVacTubeIDL3DataTableVacTube_ID;
        private System.Data.DataTable schemadsVacTubeID;
        private AppSvrHMI.L3DataSet dsVacTubeID;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private AppSvrHMI.L3DataSet dsMain;
        private AppSvrHMI.L3Command cmdMain;
        private AppSvrHMI.L3CommandParameter cmdpMain;
        private System.Data.DataTable schemadsMain;
        private System.Data.DataColumn coldsMainL3DataTableGUID;
        private System.Data.DataColumn coldsMainL3DataTableNAME;
        private System.Data.DataColumn coldsMainL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsMainL3DataTableBUILD_ID;
        private System.Data.DataColumn coldsMainL3DataTableHOT_SYP_ID;
        private System.Data.DataColumn coldsMainL3DataTableREFRA_FAC;
        private System.Data.DataColumn coldsMainL3DataTableON_TIME;
        private System.Data.DataColumn coldsMainL3DataTablePOSITION;
        private System.Data.DataColumn coldsMainL3DataTableON_TEAMID;
        private System.Data.DataColumn coldsMainL3DataTableON_SHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableON_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableON_AGE;
        private System.Data.DataColumn coldsMainL3DataTableCUR_AGE;
        private System.Data.DataColumn coldsMainL3DataTableTOTAL_AGE;
        private System.Data.DataColumn coldsMainL3DataTableOFFLINE_TIME;
        private System.Data.DataColumn coldsMainL3DataTableOFF_TEAMID;
        private System.Data.DataColumn coldsMainL3DataTableOFF_REASON;
        private System.Data.DataColumn coldsMainL3DataTableONLINE_LEN;
        private System.Data.DataColumn coldsMainL3DataTableOFF_OPERATOR;
        private System.Data.DataColumn coldsMainL3DataTableOFF_SHIFTID;
        private System.Data.DataColumn coldsMainL3DataTableNOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bUILDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOTSYPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFRAFACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oNTEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oNSHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cURAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oNLINELENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFLINETIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oFFREASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oFFTEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn oFFSHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oFFOPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
    }
}