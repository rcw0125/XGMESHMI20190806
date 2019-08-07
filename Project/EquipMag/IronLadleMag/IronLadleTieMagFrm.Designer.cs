namespace EquipMag.IronLadleMag
{
    partial class IronLadleTieMagFrm 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IronLadleTieMagFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsTieInfo = new System.Windows.Forms.BindingSource(this.components);
            this.dsTieInfo = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdTieInfo = new AppSvrHMI.L3Command(this.components);
            this.l3CommandParameter1 = new AppSvrHMI.L3CommandParameter();
            this.schemadsTieInfo = new System.Data.DataTable();
            this.coldsTieInfoL3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableIRONLADLEID = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableREFRA_PRODUCE = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableREFRA_ID = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableCONSUMPTION = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableTIE_START_TIME = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableTIE_END_TIME = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableNOTE = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableDoff_Mod_Time = new System.Data.DataColumn();
            this.coldsTieInfoL3DataTableTieID = new System.Data.DataColumn();
            this.tbLPM = new System.Windows.Forms.TableLayoutPanel();
            this.bnTieInfo = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOutPut = new System.Windows.Forms.ToolStripButton();
            this.hmiRootPanel1 = new HMIBase.HMIRootPanel();
            this.dvTieInfo = new System.Windows.Forms.DataGridView();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRONLADLEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFRAPRODUCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEFRAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSUMPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIESTARTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIEENDTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doff_Mod_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsIronLadleID = new AppSvrHMI.L3DataSet();
            this.schemadsIronLadleID = new System.Data.DataTable();
            this.coldsIronLadleIDL3DataTableIronLadleID = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsTieInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTieInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTieInfo)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnTieInfo)).BeginInit();
            this.bnTieInfo.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvTieInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTieInfo
            // 
            this.bsTieInfo.DataMember = "L3DataTable";
            this.bsTieInfo.DataSource = this.dsTieInfo;
            // 
            // dsTieInfo
            // 
            this.dsTieInfo.AutoSubscribe = false;
            this.dsTieInfo.DataSetName = "L3DataSet";
            this.dsTieInfo.DeleteMethod = "DeleteTieInfos";
            this.dsTieInfo.InsertMethod = "InsertTieInfos";
            this.dsTieInfo.L3DataAdapter = this.Adapter;
            this.dsTieInfo.LoadEvent = "Click";
            this.dsTieInfo.LoadTrigger = null;
            this.dsTieInfo.RefreshValve = 1000;
            this.dsTieInfo.SourceCommand = this.cmdTieInfo;
            this.dsTieInfo.SourceCondition = null;
            this.dsTieInfo.SourceMethod = "GetTieInfos";
            this.dsTieInfo.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsTieInfo.SourceURI = "XGMESLogic\\IronLadleMag\\CIronLadle_Mag\\IronLadle_Mag";
            this.dsTieInfo.SubscribeTarget = null;
            this.dsTieInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsTieInfo});
            this.dsTieInfo.UpdateEvent = "Click";
            this.dsTieInfo.UpdateMethod = "UpdateTieInfos";
            this.dsTieInfo.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdTieInfo
            // 
            this.cmdTieInfo.Adapter = null;
            this.cmdTieInfo.MergeReturnTarget = false;
            this.cmdTieInfo.Method = null;
            this.cmdTieInfo.Object = null;
            this.cmdTieInfo.Parameters.Add(this.l3CommandParameter1);
            this.cmdTieInfo.ReturnTarget = null;
            this.cmdTieInfo.ReturnTargetProperty = null;
            this.cmdTieInfo.Trigger = null;
            this.cmdTieInfo.TriggerEvent = "Click";
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
            // schemadsTieInfo
            // 
            this.schemadsTieInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsTieInfoL3DataTableINPUT_TIME,
            this.coldsTieInfoL3DataTableIRONLADLEID,
            this.coldsTieInfoL3DataTableREFRA_PRODUCE,
            this.coldsTieInfoL3DataTableREFRA_ID,
            this.coldsTieInfoL3DataTableCONSUMPTION,
            this.coldsTieInfoL3DataTableTIE_START_TIME,
            this.coldsTieInfoL3DataTableTIE_END_TIME,
            this.coldsTieInfoL3DataTableTEAMID,
            this.coldsTieInfoL3DataTableSHIFTID,
            this.coldsTieInfoL3DataTableOPERATOR,
            this.coldsTieInfoL3DataTableNOTE,
            this.coldsTieInfoL3DataTableDoff_Mod_Time,
            this.coldsTieInfoL3DataTableTieID});
            this.schemadsTieInfo.TableName = "L3DataTable";
            // 
            // coldsTieInfoL3DataTableINPUT_TIME
            // 
            this.coldsTieInfoL3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsTieInfoL3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsTieInfoL3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsTieInfoL3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsTieInfoL3DataTableIRONLADLEID
            // 
            this.coldsTieInfoL3DataTableIRONLADLEID.Caption = "IRONLADLEID";
            this.coldsTieInfoL3DataTableIRONLADLEID.ColumnName = "IRONLADLEID";
            this.coldsTieInfoL3DataTableIRONLADLEID.DefaultValue = "";
            this.coldsTieInfoL3DataTableIRONLADLEID.Namespace = "";
            // 
            // coldsTieInfoL3DataTableREFRA_PRODUCE
            // 
            this.coldsTieInfoL3DataTableREFRA_PRODUCE.Caption = "REFRA_PRODUCE";
            this.coldsTieInfoL3DataTableREFRA_PRODUCE.ColumnName = "REFRA_PRODUCE";
            this.coldsTieInfoL3DataTableREFRA_PRODUCE.DefaultValue = "";
            this.coldsTieInfoL3DataTableREFRA_PRODUCE.Namespace = "";
            // 
            // coldsTieInfoL3DataTableREFRA_ID
            // 
            this.coldsTieInfoL3DataTableREFRA_ID.Caption = "REFRA_ID";
            this.coldsTieInfoL3DataTableREFRA_ID.ColumnName = "REFRA_ID";
            this.coldsTieInfoL3DataTableREFRA_ID.DefaultValue = "";
            this.coldsTieInfoL3DataTableREFRA_ID.Namespace = "";
            // 
            // coldsTieInfoL3DataTableCONSUMPTION
            // 
            this.coldsTieInfoL3DataTableCONSUMPTION.Caption = "CONSUMPTION";
            this.coldsTieInfoL3DataTableCONSUMPTION.ColumnName = "CONSUMPTION";
            this.coldsTieInfoL3DataTableCONSUMPTION.DataType = typeof(double);
            this.coldsTieInfoL3DataTableCONSUMPTION.DefaultValue = 0;
            this.coldsTieInfoL3DataTableCONSUMPTION.Namespace = "";
            // 
            // coldsTieInfoL3DataTableTIE_START_TIME
            // 
            this.coldsTieInfoL3DataTableTIE_START_TIME.Caption = "TIE_START_TIME";
            this.coldsTieInfoL3DataTableTIE_START_TIME.ColumnName = "TIE_START_TIME";
            this.coldsTieInfoL3DataTableTIE_START_TIME.DataType = typeof(System.DateTime);
            this.coldsTieInfoL3DataTableTIE_START_TIME.Namespace = "";
            // 
            // coldsTieInfoL3DataTableTIE_END_TIME
            // 
            this.coldsTieInfoL3DataTableTIE_END_TIME.Caption = "TIE_END_TIME";
            this.coldsTieInfoL3DataTableTIE_END_TIME.ColumnName = "TIE_END_TIME";
            this.coldsTieInfoL3DataTableTIE_END_TIME.DataType = typeof(System.DateTime);
            this.coldsTieInfoL3DataTableTIE_END_TIME.Namespace = "";
            // 
            // coldsTieInfoL3DataTableTEAMID
            // 
            this.coldsTieInfoL3DataTableTEAMID.Caption = "TEAMID";
            this.coldsTieInfoL3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsTieInfoL3DataTableTEAMID.DefaultValue = "";
            this.coldsTieInfoL3DataTableTEAMID.Namespace = "";
            // 
            // coldsTieInfoL3DataTableSHIFTID
            // 
            this.coldsTieInfoL3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsTieInfoL3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsTieInfoL3DataTableSHIFTID.DefaultValue = "";
            this.coldsTieInfoL3DataTableSHIFTID.Namespace = "";
            // 
            // coldsTieInfoL3DataTableOPERATOR
            // 
            this.coldsTieInfoL3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsTieInfoL3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsTieInfoL3DataTableOPERATOR.DefaultValue = "";
            this.coldsTieInfoL3DataTableOPERATOR.Namespace = "";
            // 
            // coldsTieInfoL3DataTableNOTE
            // 
            this.coldsTieInfoL3DataTableNOTE.Caption = "NOTE";
            this.coldsTieInfoL3DataTableNOTE.ColumnName = "NOTE";
            this.coldsTieInfoL3DataTableNOTE.DefaultValue = "";
            this.coldsTieInfoL3DataTableNOTE.Namespace = "";
            // 
            // coldsTieInfoL3DataTableDoff_Mod_Time
            // 
            this.coldsTieInfoL3DataTableDoff_Mod_Time.Caption = "Doff_Mod_Time";
            this.coldsTieInfoL3DataTableDoff_Mod_Time.ColumnName = "Doff_Mod_Time";
            this.coldsTieInfoL3DataTableDoff_Mod_Time.DataType = typeof(System.DateTime);
            this.coldsTieInfoL3DataTableDoff_Mod_Time.Namespace = "";
            // 
            // coldsTieInfoL3DataTableTieID
            // 
            this.coldsTieInfoL3DataTableTieID.Caption = "TieID";
            this.coldsTieInfoL3DataTableTieID.ColumnName = "TieID";
            this.coldsTieInfoL3DataTableTieID.Namespace = "";
            // 
            // tbLPM
            // 
            this.tbLPM.ColumnCount = 1;
            this.tbLPM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPM.Controls.Add(this.bnTieInfo, 0, 1);
            this.tbLPM.Controls.Add(this.tSp1, 0, 0);
            this.tbLPM.Controls.Add(this.hmiRootPanel1, 0, 2);
            this.tbLPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPM.Location = new System.Drawing.Point(0, 0);
            this.tbLPM.Margin = new System.Windows.Forms.Padding(0);
            this.tbLPM.Name = "tbLPM";
            this.tbLPM.RowCount = 3;
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPM.Size = new System.Drawing.Size(1000, 700);
            this.tbLPM.TabIndex = 0;
            // 
            // bnTieInfo
            // 
            this.bnTieInfo.AddNewItem = null;
            this.bnTieInfo.AutoSize = false;
            this.bnTieInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnTieInfo.BackgroundImage")));
            this.bnTieInfo.BindingSource = this.bsTieInfo;
            this.bnTieInfo.CountItem = this.bindingNavigatorCountItem;
            this.bnTieInfo.DeleteItem = null;
            this.bnTieInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnTieInfo.Location = new System.Drawing.Point(0, 43);
            this.bnTieInfo.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnTieInfo.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnTieInfo.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnTieInfo.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnTieInfo.Name = "bnTieInfo";
            this.bnTieInfo.PositionItem = this.bindingNavigatorPositionItem;
            this.bnTieInfo.Size = new System.Drawing.Size(1000, 25);
            this.bnTieInfo.TabIndex = 27;
            this.bnTieInfo.Text = "bindingNavigator1";
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
            this.toolStripLabel1.Text = "　　";
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
            // btnAdd
            // 
            this.Adapter.SetAccessRight(this.btnAdd, "IronLadleTiebtnAdd");
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.Adapter.SetAccessRight(this.btnDel, "IronLadleTiebtnAdd");
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.Adapter.SetAccessRight(this.toolStripSeparator2, "IronLadleTiebtnAdd");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnConfirm
            // 
            this.Adapter.SetAccessRight(this.btnConfirm, "IronLadleTiebtnAdd");
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 40);
            this.btnConfirm.Text = "确定";
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
            // hmiRootPanel1
            // 
            this.hmiRootPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hmiRootPanel1.Controls.Add(this.dvTieInfo);
            this.hmiRootPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hmiRootPanel1.Location = new System.Drawing.Point(0, 68);
            this.hmiRootPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.hmiRootPanel1.Name = "hmiRootPanel1";
            this.hmiRootPanel1.Size = new System.Drawing.Size(1000, 632);
            this.hmiRootPanel1.TabIndex = 30;
            // 
            // dvTieInfo
            // 
            this.dvTieInfo.AllowUserToAddRows = false;
            this.dvTieInfo.AutoGenerateColumns = false;
            this.dvTieInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvTieInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dvTieInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iNPUTTIMEDataGridViewTextBoxColumn,
            this.iRONLADLEIDDataGridViewTextBoxColumn,
            this.rEFRAPRODUCEDataGridViewTextBoxColumn,
            this.TieID,
            this.rEFRAIDDataGridViewTextBoxColumn,
            this.cONSUMPTIONDataGridViewTextBoxColumn,
            this.tIESTARTTIMEDataGridViewTextBoxColumn,
            this.tIEENDTIMEDataGridViewTextBoxColumn,
            this.Doff_Mod_Time,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn});
            this.dvTieInfo.DataSource = this.bsTieInfo;
            this.dvTieInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvTieInfo.Location = new System.Drawing.Point(0, 0);
            this.dvTieInfo.Margin = new System.Windows.Forms.Padding(0);
            this.dvTieInfo.Name = "dvTieInfo";
            this.dvTieInfo.ReadOnly = true;
            this.dvTieInfo.RowTemplate.Height = 23;
            this.dvTieInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvTieInfo.Size = new System.Drawing.Size(996, 628);
            this.dvTieInfo.TabIndex = 31;
            this.dvTieInfo.Sorted += new System.EventHandler(this.dvTieInfo_Sorted);
            this.dvTieInfo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvMain_CellMouseDoubleClick);
            this.dvTieInfo.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dvTieInfo_DataError);
            // 
            // iNPUTTIMEDataGridViewTextBoxColumn
            // 
            this.iNPUTTIMEDataGridViewTextBoxColumn.DataPropertyName = "INPUT_TIME";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
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
            // rEFRAPRODUCEDataGridViewTextBoxColumn
            // 
            this.rEFRAPRODUCEDataGridViewTextBoxColumn.DataPropertyName = "REFRA_PRODUCE";
            this.rEFRAPRODUCEDataGridViewTextBoxColumn.HeaderText = "耐材厂家";
            this.rEFRAPRODUCEDataGridViewTextBoxColumn.Name = "rEFRAPRODUCEDataGridViewTextBoxColumn";
            this.rEFRAPRODUCEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEFRAPRODUCEDataGridViewTextBoxColumn.Width = 78;
            // 
            // TieID
            // 
            this.TieID.DataPropertyName = "TieID";
            this.TieID.HeaderText = "铁包打结编号";
            this.TieID.Name = "TieID";
            this.TieID.ReadOnly = true;
            this.TieID.Width = 102;
            // 
            // rEFRAIDDataGridViewTextBoxColumn
            // 
            this.rEFRAIDDataGridViewTextBoxColumn.DataPropertyName = "REFRA_ID";
            this.rEFRAIDDataGridViewTextBoxColumn.HeaderText = "耐材名称";
            this.rEFRAIDDataGridViewTextBoxColumn.Name = "rEFRAIDDataGridViewTextBoxColumn";
            this.rEFRAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rEFRAIDDataGridViewTextBoxColumn.Width = 78;
            // 
            // cONSUMPTIONDataGridViewTextBoxColumn
            // 
            this.cONSUMPTIONDataGridViewTextBoxColumn.DataPropertyName = "CONSUMPTION";
            this.cONSUMPTIONDataGridViewTextBoxColumn.HeaderText = "消耗量";
            this.cONSUMPTIONDataGridViewTextBoxColumn.Name = "cONSUMPTIONDataGridViewTextBoxColumn";
            this.cONSUMPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.cONSUMPTIONDataGridViewTextBoxColumn.Width = 66;
            // 
            // tIESTARTTIMEDataGridViewTextBoxColumn
            // 
            this.tIESTARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "TIE_START_TIME";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.tIESTARTTIMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.tIESTARTTIMEDataGridViewTextBoxColumn.HeaderText = "打结开始时间";
            this.tIESTARTTIMEDataGridViewTextBoxColumn.Name = "tIESTARTTIMEDataGridViewTextBoxColumn";
            this.tIESTARTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIESTARTTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // tIEENDTIMEDataGridViewTextBoxColumn
            // 
            this.tIEENDTIMEDataGridViewTextBoxColumn.DataPropertyName = "TIE_END_TIME";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.tIEENDTIMEDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tIEENDTIMEDataGridViewTextBoxColumn.HeaderText = "打结结束时间";
            this.tIEENDTIMEDataGridViewTextBoxColumn.Name = "tIEENDTIMEDataGridViewTextBoxColumn";
            this.tIEENDTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tIEENDTIMEDataGridViewTextBoxColumn.Width = 102;
            // 
            // Doff_Mod_Time
            // 
            this.Doff_Mod_Time.DataPropertyName = "Doff_Mod_Time";
            this.Doff_Mod_Time.HeaderText = "脱模时间";
            this.Doff_Mod_Time.Name = "Doff_Mod_Time";
            this.Doff_Mod_Time.ReadOnly = true;
            this.Doff_Mod_Time.Width = 78;
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
            // IronLadleTieMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IronLadleTieMagFrm";
            this.TabText = "铁包打结实绩管理";
            this.Text = "铁包打结实绩管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IronLadleTieMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.IronLadleTieMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTieInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTieInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTieInfo)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnTieInfo)).EndInit();
            this.bnTieInfo.ResumeLayout(false);
            this.bnTieInfo.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvTieInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIronLadleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsIronLadleID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsTieInfo;
        private System.Windows.Forms.BindingSource bsTieInfo;
        private System.Windows.Forms.TableLayoutPanel tbLPM;
        private System.Windows.Forms.BindingNavigator bnTieInfo;
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
        private System.Windows.Forms.DataGridView dvTieInfo;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Data.DataTable schemadsTieInfo;
        private System.Data.DataColumn coldsTieInfoL3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsTieInfoL3DataTableIRONLADLEID;
        private System.Data.DataColumn coldsTieInfoL3DataTableREFRA_PRODUCE;
        private System.Data.DataColumn coldsTieInfoL3DataTableREFRA_ID;
        private System.Data.DataColumn coldsTieInfoL3DataTableCONSUMPTION;
        private System.Data.DataColumn coldsTieInfoL3DataTableTIE_START_TIME;
        private System.Data.DataColumn coldsTieInfoL3DataTableTIE_END_TIME;
        private System.Data.DataColumn coldsTieInfoL3DataTableTEAMID;
        private System.Data.DataColumn coldsTieInfoL3DataTableSHIFTID;
        private System.Data.DataColumn coldsTieInfoL3DataTableOPERATOR;
        private System.Data.DataColumn coldsTieInfoL3DataTableNOTE;
        private AppSvrHMI.L3Command cmdTieInfo;
        private AppSvrHMI.L3CommandParameter l3CommandParameter1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbIronladleID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private AppSvrHMI.L3DataSet dsIronLadleID;
        private System.Data.DataTable schemadsIronLadleID;
        private System.Data.DataColumn coldsIronLadleIDL3DataTableIronLadleID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3DataSet dsShiftID;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataColumn coldsTieInfoL3DataTableDoff_Mod_Time;
        private System.Data.DataColumn coldsTieInfoL3DataTableTieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRONLADLEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFRAPRODUCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEFRAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSUMPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIESTARTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIEENDTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doff_Mod_Time;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
    }
}