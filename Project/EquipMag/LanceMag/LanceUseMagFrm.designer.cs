namespace EquipMag.LanceMag
{
    partial class LanceUseMagFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanceUseMagFrm));
            this.bsM = new System.Windows.Forms.BindingSource(this.components);
            this.dsM = new AppSvrHMI.L3DataSet();
            this.Adapter = new AppSvrHMI.L3Adapter(this.components);
            this.cmdM = new AppSvrHMI.L3Command(this.components);
            this.l3cmdpM = new AppSvrHMI.L3CommandParameter();
            this.schemadsM = new System.Data.DataTable();
            this.coldsML3DataTableGUID = new System.Data.DataColumn();
            this.coldsML3DataTableNAME = new System.Data.DataColumn();
            this.coldsML3DataTableINPUT_TIME = new System.Data.DataColumn();
            this.coldsML3DataTableLANCEID = new System.Data.DataColumn();
            this.coldsML3DataTableLANCE_HEAD_TYPE = new System.Data.DataColumn();
            this.coldsML3DataTableHEATID = new System.Data.DataColumn();
            this.coldsML3DataTableSHIFT_DATE = new System.Data.DataColumn();
            this.coldsML3DataTableCOOL_WATER_FLOW = new System.Data.DataColumn();
            this.coldsML3DataTableCOOL_WATER_TEMP = new System.Data.DataColumn();
            this.coldsML3DataTableOXYGEN_PRESSURE = new System.Data.DataColumn();
            this.coldsML3DataTableOXYGEN_FLOW = new System.Data.DataColumn();
            this.coldsML3DataTableFURNACE_COUNT = new System.Data.DataColumn();
            this.coldsML3DataTableCHANGE_LANCE_REASON = new System.Data.DataColumn();
            this.coldsML3DataTableTOTAL_LANCE_AGE = new System.Data.DataColumn();
            this.coldsML3DataTableAMELT_CONFIRM_PEPOLE = new System.Data.DataColumn();
            this.coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE = new System.Data.DataColumn();
            this.coldsML3DataTableTEAMID = new System.Data.DataColumn();
            this.coldsML3DataTableSHIFTID = new System.Data.DataColumn();
            this.coldsML3DataTableOPERATOR = new System.Data.DataColumn();
            this.coldsML3DataTableNOTE = new System.Data.DataColumn();
            this.coldsML3DataTableMakeID = new System.Data.DataColumn();
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
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cmbLanceID = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dtEnd = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.dtStart = new buttonHide.ToolStripToriDateTimePicker();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
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
            this.dsChangeReason = new AppSvrHMI.L3DataSet();
            this.schemadsChangeReason = new System.Data.DataTable();
            this.coldsChangeReasonL3DataTableCode = new System.Data.DataColumn();
            this.coldsChangeReasonL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsTeamID = new AppSvrHMI.L3DataSet();
            this.schemadsTeamID = new System.Data.DataTable();
            this.coldsTeamIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsTeamIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsShiftID = new AppSvrHMI.L3DataSet();
            this.schemadsShiftID = new System.Data.DataTable();
            this.coldsShiftIDL3DataTableCode = new System.Data.DataColumn();
            this.coldsShiftIDL3DataTableCode_Des = new System.Data.DataColumn();
            this.dsLanceID = new AppSvrHMI.L3DataSet();
            this.schemadsLanceID = new System.Data.DataTable();
            this.coldsLanceIDL3DataTableLanceID = new System.Data.DataColumn();
            this.iNPUTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANCEHEADTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEATIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHIFTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOOLWATERFLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOOLWATERTEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oXYGENPRESSUREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oXYGENFLOWDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fURNACECOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHANGELANCEREASONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tOTALLANCEAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEAMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sHIFTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).BeginInit();
            this.tbLPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).BeginInit();
            this.bdN1.SuspendLayout();
            this.tSp1.SuspendLayout();
            this.hmiRootPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChangeReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).BeginInit();
            this.SuspendLayout();
            // 
            // bsM
            // 
            this.bsM.DataMember = "L3DataTable";
            this.bsM.DataSource = this.dsM;
            // 
            // dsM
            // 
            this.dsM.AutoSubscribe = true;
            this.dsM.DataSetName = "L3DataSet";
            this.dsM.DeleteMethod = "DeleteLanceUseInfo";
            this.dsM.InsertMethod = "InsertLanceUseInfo";
            this.dsM.L3DataAdapter = this.Adapter;
            this.dsM.LoadEvent = "Click";
            this.dsM.LoadTrigger = null;
            this.dsM.RefreshValve = 1000;
            this.dsM.SourceCommand = this.cmdM;
            this.dsM.SourceCondition = null;
            this.dsM.SourceMethod = "GetLanceUseInfo";
            this.dsM.SourceType = AppSvrHMI.L3DataSetSourceType.Method;
            this.dsM.SourceURI = "XGMESLogic\\LanceMag\\CLance_Mag\\Lance_Mag";
            this.dsM.SubscribeTarget = null;
            this.dsM.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsM});
            this.dsM.UpdateEvent = "Click";
            this.dsM.UpdateMethod = "UpdateLanceUseInfo";
            this.dsM.UpdateTrigger = null;
            // 
            // Adapter
            // 
            this.Adapter.Session = null;
            // 
            // cmdM
            // 
            this.cmdM.Adapter = null;
            this.cmdM.MergeReturnTarget = false;
            this.cmdM.Method = null;
            this.cmdM.Object = null;
            this.cmdM.Parameters.Add(this.l3cmdpM);
            this.cmdM.ReturnTarget = null;
            this.cmdM.ReturnTargetProperty = null;
            this.cmdM.Trigger = null;
            this.cmdM.TriggerEvent = "Click";
            // 
            // l3cmdpM
            // 
            this.l3cmdpM.AcceptAfterExecuted = false;
            this.l3cmdpM.ConstantValue = null;
            this.l3cmdpM.MergeTarget = false;
            this.l3cmdpM.SourceFilter = null;
            this.l3cmdpM.SourceObject = null;
            this.l3cmdpM.SourceProperty = null;
            this.l3cmdpM.TargetObject = null;
            this.l3cmdpM.TargetProperty = null;
            // 
            // schemadsM
            // 
            this.schemadsM.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsML3DataTableGUID,
            this.coldsML3DataTableNAME,
            this.coldsML3DataTableINPUT_TIME,
            this.coldsML3DataTableLANCEID,
            this.coldsML3DataTableLANCE_HEAD_TYPE,
            this.coldsML3DataTableHEATID,
            this.coldsML3DataTableSHIFT_DATE,
            this.coldsML3DataTableCOOL_WATER_FLOW,
            this.coldsML3DataTableCOOL_WATER_TEMP,
            this.coldsML3DataTableOXYGEN_PRESSURE,
            this.coldsML3DataTableOXYGEN_FLOW,
            this.coldsML3DataTableFURNACE_COUNT,
            this.coldsML3DataTableCHANGE_LANCE_REASON,
            this.coldsML3DataTableTOTAL_LANCE_AGE,
            this.coldsML3DataTableAMELT_CONFIRM_PEPOLE,
            this.coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE,
            this.coldsML3DataTableTEAMID,
            this.coldsML3DataTableSHIFTID,
            this.coldsML3DataTableOPERATOR,
            this.coldsML3DataTableNOTE,
            this.coldsML3DataTableMakeID});
            this.schemadsM.TableName = "L3DataTable";
            // 
            // coldsML3DataTableGUID
            // 
            this.coldsML3DataTableGUID.Caption = "GUID";
            this.coldsML3DataTableGUID.ColumnName = "GUID";
            this.coldsML3DataTableGUID.DefaultValue = "";
            this.coldsML3DataTableGUID.Namespace = "";
            // 
            // coldsML3DataTableNAME
            // 
            this.coldsML3DataTableNAME.Caption = "NAME";
            this.coldsML3DataTableNAME.ColumnName = "NAME";
            this.coldsML3DataTableNAME.DefaultValue = "";
            this.coldsML3DataTableNAME.Namespace = "";
            // 
            // coldsML3DataTableINPUT_TIME
            // 
            this.coldsML3DataTableINPUT_TIME.Caption = "INPUT_TIME";
            this.coldsML3DataTableINPUT_TIME.ColumnName = "INPUT_TIME";
            this.coldsML3DataTableINPUT_TIME.DataType = typeof(System.DateTime);
            this.coldsML3DataTableINPUT_TIME.Namespace = "";
            // 
            // coldsML3DataTableLANCEID
            // 
            this.coldsML3DataTableLANCEID.Caption = "LANCEID";
            this.coldsML3DataTableLANCEID.ColumnName = "LANCEID";
            this.coldsML3DataTableLANCEID.DefaultValue = "";
            this.coldsML3DataTableLANCEID.Namespace = "";
            // 
            // coldsML3DataTableLANCE_HEAD_TYPE
            // 
            this.coldsML3DataTableLANCE_HEAD_TYPE.Caption = "LANCE_HEAD_TYPE";
            this.coldsML3DataTableLANCE_HEAD_TYPE.ColumnName = "LANCE_HEAD_TYPE";
            this.coldsML3DataTableLANCE_HEAD_TYPE.DefaultValue = "";
            this.coldsML3DataTableLANCE_HEAD_TYPE.Namespace = "";
            // 
            // coldsML3DataTableHEATID
            // 
            this.coldsML3DataTableHEATID.Caption = "HEATID";
            this.coldsML3DataTableHEATID.ColumnName = "HEATID";
            this.coldsML3DataTableHEATID.DefaultValue = "";
            this.coldsML3DataTableHEATID.Namespace = "";
            // 
            // coldsML3DataTableSHIFT_DATE
            // 
            this.coldsML3DataTableSHIFT_DATE.Caption = "SHIFT_DATE";
            this.coldsML3DataTableSHIFT_DATE.ColumnName = "SHIFT_DATE";
            this.coldsML3DataTableSHIFT_DATE.DataType = typeof(System.DateTime);
            this.coldsML3DataTableSHIFT_DATE.Namespace = "";
            // 
            // coldsML3DataTableCOOL_WATER_FLOW
            // 
            this.coldsML3DataTableCOOL_WATER_FLOW.Caption = "COOL_WATER_FLOW";
            this.coldsML3DataTableCOOL_WATER_FLOW.ColumnName = "COOL_WATER_FLOW";
            this.coldsML3DataTableCOOL_WATER_FLOW.DataType = typeof(double);
            this.coldsML3DataTableCOOL_WATER_FLOW.DefaultValue = 0;
            this.coldsML3DataTableCOOL_WATER_FLOW.Namespace = "";
            // 
            // coldsML3DataTableCOOL_WATER_TEMP
            // 
            this.coldsML3DataTableCOOL_WATER_TEMP.Caption = "COOL_WATER_TEMP";
            this.coldsML3DataTableCOOL_WATER_TEMP.ColumnName = "COOL_WATER_TEMP";
            this.coldsML3DataTableCOOL_WATER_TEMP.DataType = typeof(double);
            this.coldsML3DataTableCOOL_WATER_TEMP.DefaultValue = 0;
            this.coldsML3DataTableCOOL_WATER_TEMP.Namespace = "";
            // 
            // coldsML3DataTableOXYGEN_PRESSURE
            // 
            this.coldsML3DataTableOXYGEN_PRESSURE.Caption = "OXYGEN_PRESSURE";
            this.coldsML3DataTableOXYGEN_PRESSURE.ColumnName = "OXYGEN_PRESSURE";
            this.coldsML3DataTableOXYGEN_PRESSURE.DataType = typeof(double);
            this.coldsML3DataTableOXYGEN_PRESSURE.DefaultValue = 0;
            this.coldsML3DataTableOXYGEN_PRESSURE.Namespace = "";
            // 
            // coldsML3DataTableOXYGEN_FLOW
            // 
            this.coldsML3DataTableOXYGEN_FLOW.Caption = "OXYGEN_FLOW";
            this.coldsML3DataTableOXYGEN_FLOW.ColumnName = "OXYGEN_FLOW";
            this.coldsML3DataTableOXYGEN_FLOW.DataType = typeof(double);
            this.coldsML3DataTableOXYGEN_FLOW.DefaultValue = 0;
            this.coldsML3DataTableOXYGEN_FLOW.Namespace = "";
            // 
            // coldsML3DataTableFURNACE_COUNT
            // 
            this.coldsML3DataTableFURNACE_COUNT.Caption = "FURNACE_COUNT";
            this.coldsML3DataTableFURNACE_COUNT.ColumnName = "FURNACE_COUNT";
            this.coldsML3DataTableFURNACE_COUNT.DataType = typeof(int);
            this.coldsML3DataTableFURNACE_COUNT.DefaultValue = 0;
            this.coldsML3DataTableFURNACE_COUNT.Namespace = "";
            // 
            // coldsML3DataTableCHANGE_LANCE_REASON
            // 
            this.coldsML3DataTableCHANGE_LANCE_REASON.Caption = "CHANGE_LANCE_REASON";
            this.coldsML3DataTableCHANGE_LANCE_REASON.ColumnName = "CHANGE_LANCE_REASON";
            this.coldsML3DataTableCHANGE_LANCE_REASON.DefaultValue = "";
            this.coldsML3DataTableCHANGE_LANCE_REASON.Namespace = "";
            // 
            // coldsML3DataTableTOTAL_LANCE_AGE
            // 
            this.coldsML3DataTableTOTAL_LANCE_AGE.Caption = "TOTAL_LANCE_AGE";
            this.coldsML3DataTableTOTAL_LANCE_AGE.ColumnName = "TOTAL_LANCE_AGE";
            this.coldsML3DataTableTOTAL_LANCE_AGE.DataType = typeof(int);
            this.coldsML3DataTableTOTAL_LANCE_AGE.DefaultValue = 0;
            this.coldsML3DataTableTOTAL_LANCE_AGE.Namespace = "";
            // 
            // coldsML3DataTableAMELT_CONFIRM_PEPOLE
            // 
            this.coldsML3DataTableAMELT_CONFIRM_PEPOLE.Caption = "AMELT_CONFIRM_PEPOLE";
            this.coldsML3DataTableAMELT_CONFIRM_PEPOLE.ColumnName = "AMELT_CONFIRM_PEPOLE";
            this.coldsML3DataTableAMELT_CONFIRM_PEPOLE.DefaultValue = "";
            this.coldsML3DataTableAMELT_CONFIRM_PEPOLE.Namespace = "";
            // 
            // coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE
            // 
            this.coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE.Caption = "MAINTAIN_CONFIRM_PEPOLE";
            this.coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE.ColumnName = "MAINTAIN_CONFIRM_PEPOLE";
            this.coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE.DefaultValue = "";
            this.coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE.Namespace = "";
            // 
            // coldsML3DataTableTEAMID
            // 
            this.coldsML3DataTableTEAMID.Caption = "TEAMID";
            this.coldsML3DataTableTEAMID.ColumnName = "TEAMID";
            this.coldsML3DataTableTEAMID.DefaultValue = "";
            this.coldsML3DataTableTEAMID.Namespace = "";
            // 
            // coldsML3DataTableSHIFTID
            // 
            this.coldsML3DataTableSHIFTID.Caption = "SHIFTID";
            this.coldsML3DataTableSHIFTID.ColumnName = "SHIFTID";
            this.coldsML3DataTableSHIFTID.DefaultValue = "";
            this.coldsML3DataTableSHIFTID.Namespace = "";
            // 
            // coldsML3DataTableOPERATOR
            // 
            this.coldsML3DataTableOPERATOR.Caption = "OPERATOR";
            this.coldsML3DataTableOPERATOR.ColumnName = "OPERATOR";
            this.coldsML3DataTableOPERATOR.DefaultValue = "";
            this.coldsML3DataTableOPERATOR.Namespace = "";
            // 
            // coldsML3DataTableNOTE
            // 
            this.coldsML3DataTableNOTE.Caption = "NOTE";
            this.coldsML3DataTableNOTE.ColumnName = "NOTE";
            this.coldsML3DataTableNOTE.DefaultValue = "";
            this.coldsML3DataTableNOTE.Namespace = "";
            // 
            // coldsML3DataTableMakeID
            // 
            this.coldsML3DataTableMakeID.Caption = "MakeID";
            this.coldsML3DataTableMakeID.ColumnName = "MakeID";
            this.coldsML3DataTableMakeID.Namespace = "";
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
            this.tbLPM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 361F));
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
            this.toolStripLabel5,
            this.cmbLanceID,
            this.toolStripLabel2,
            this.dtEnd,
            this.toolStripLabel4,
            this.dtStart,
            this.toolStripLabel3});
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
            // cmbLanceID
            // 
            this.cmbLanceID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmbLanceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanceID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLanceID.Name = "cmbLanceID";
            this.cmbLanceID.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "枪号:";
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
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 40);
            this.btnAdd.Text = "新增";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 40);
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.lANCEIDDataGridViewTextBoxColumn,
            this.lANCEHEADTYPEDataGridViewTextBoxColumn,
            this.MakeID,
            this.hEATIDDataGridViewTextBoxColumn,
            this.sHIFTDATEDataGridViewTextBoxColumn,
            this.cOOLWATERFLOWDataGridViewTextBoxColumn,
            this.cOOLWATERTEMPDataGridViewTextBoxColumn,
            this.oXYGENPRESSUREDataGridViewTextBoxColumn,
            this.oXYGENFLOWDataGridViewTextBoxColumn,
            this.fURNACECOUNTDataGridViewTextBoxColumn,
            this.cHANGELANCEREASONDataGridViewTextBoxColumn,
            this.tOTALLANCEAGEDataGridViewTextBoxColumn,
            this.aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn,
            this.mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn,
            this.tEAMIDDataGridViewTextBoxColumn,
            this.sHIFTIDDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn});
            this.dvM.DataSource = this.bsM;
            this.dvM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvM.Location = new System.Drawing.Point(0, 0);
            this.dvM.Margin = new System.Windows.Forms.Padding(0);
            this.dvM.Name = "dvM";
            this.dvM.ReadOnly = true;
            this.dvM.RowTemplate.Height = 23;
            this.dvM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvM.Size = new System.Drawing.Size(1000, 632);
            this.dvM.TabIndex = 31;
            this.dvM.Sorted += new System.EventHandler(this.dvM_Sorted);
            this.dvM.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvM_CellMouseDoubleClick);
            // 
            // dsChangeReason
            // 
            this.dsChangeReason.AutoSubscribe = false;
            this.dsChangeReason.DataSetName = "L3DataSet";
            this.dsChangeReason.DeleteMethod = null;
            this.dsChangeReason.InsertMethod = null;
            this.dsChangeReason.L3DataAdapter = this.Adapter;
            this.dsChangeReason.LoadEvent = "Click";
            this.dsChangeReason.LoadTrigger = null;
            this.dsChangeReason.RefreshValve = 1000;
            this.dsChangeReason.SourceCommand = null;
            this.dsChangeReason.SourceCondition = "Code_Group = \'LanceChangeReason\' order by Code";
            this.dsChangeReason.SourceMethod = "";
            this.dsChangeReason.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsChangeReason.SourceURI = "XGMESLogic\\BaseDataMag\\CBase_All_Code";
            this.dsChangeReason.SubscribeTarget = null;
            this.dsChangeReason.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsChangeReason});
            this.dsChangeReason.UpdateEvent = "Click";
            this.dsChangeReason.UpdateMethod = null;
            this.dsChangeReason.UpdateTrigger = null;
            // 
            // schemadsChangeReason
            // 
            this.schemadsChangeReason.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsChangeReasonL3DataTableCode,
            this.coldsChangeReasonL3DataTableCode_Des});
            this.schemadsChangeReason.TableName = "L3DataTable";
            // 
            // coldsChangeReasonL3DataTableCode
            // 
            this.coldsChangeReasonL3DataTableCode.Caption = "Code";
            this.coldsChangeReasonL3DataTableCode.ColumnName = "Code";
            this.coldsChangeReasonL3DataTableCode.Namespace = "";
            // 
            // coldsChangeReasonL3DataTableCode_Des
            // 
            this.coldsChangeReasonL3DataTableCode_Des.Caption = "Code_Des";
            this.coldsChangeReasonL3DataTableCode_Des.ColumnName = "Code_Des";
            this.coldsChangeReasonL3DataTableCode_Des.Namespace = "";
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
            // dsLanceID
            // 
            this.dsLanceID.AutoSubscribe = false;
            this.dsLanceID.DataSetName = "L3DataSet";
            this.dsLanceID.DeleteMethod = null;
            this.dsLanceID.InsertMethod = null;
            this.dsLanceID.L3DataAdapter = this.Adapter;
            this.dsLanceID.LoadEvent = "Click";
            this.dsLanceID.LoadTrigger = null;
            this.dsLanceID.RefreshValve = 1000;
            this.dsLanceID.SourceCommand = null;
            this.dsLanceID.SourceCondition = null;
            this.dsLanceID.SourceMethod = "";
            this.dsLanceID.SourceType = AppSvrHMI.L3DataSetSourceType.Class;
            this.dsLanceID.SourceURI = "XGMESLogic\\LanceMag\\CLance_Base";
            this.dsLanceID.SubscribeTarget = null;
            this.dsLanceID.Tables.AddRange(new System.Data.DataTable[] {
            this.schemadsLanceID});
            this.dsLanceID.UpdateEvent = "Click";
            this.dsLanceID.UpdateMethod = null;
            this.dsLanceID.UpdateTrigger = null;
            // 
            // schemadsLanceID
            // 
            this.schemadsLanceID.Columns.AddRange(new System.Data.DataColumn[] {
            this.coldsLanceIDL3DataTableLanceID});
            this.schemadsLanceID.TableName = "L3DataTable";
            // 
            // coldsLanceIDL3DataTableLanceID
            // 
            this.coldsLanceIDL3DataTableLanceID.Caption = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.ColumnName = "LanceID";
            this.coldsLanceIDL3DataTableLanceID.Namespace = "";
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
            // lANCEIDDataGridViewTextBoxColumn
            // 
            this.lANCEIDDataGridViewTextBoxColumn.DataPropertyName = "LANCEID";
            this.lANCEIDDataGridViewTextBoxColumn.Frozen = true;
            this.lANCEIDDataGridViewTextBoxColumn.HeaderText = "枪号";
            this.lANCEIDDataGridViewTextBoxColumn.Name = "lANCEIDDataGridViewTextBoxColumn";
            this.lANCEIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANCEIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // lANCEHEADTYPEDataGridViewTextBoxColumn
            // 
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.DataPropertyName = "LANCE_HEAD_TYPE";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Frozen = true;
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.HeaderText = "枪头型号";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Name = "lANCEHEADTYPEDataGridViewTextBoxColumn";
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANCEHEADTYPEDataGridViewTextBoxColumn.Width = 78;
            // 
            // MakeID
            // 
            this.MakeID.DataPropertyName = "MakeID";
            this.MakeID.Frozen = true;
            this.MakeID.HeaderText = "氧枪制作编号";
            this.MakeID.Name = "MakeID";
            this.MakeID.ReadOnly = true;
            this.MakeID.Width = 102;
            // 
            // hEATIDDataGridViewTextBoxColumn
            // 
            this.hEATIDDataGridViewTextBoxColumn.DataPropertyName = "HEATID";
            this.hEATIDDataGridViewTextBoxColumn.Frozen = true;
            this.hEATIDDataGridViewTextBoxColumn.HeaderText = "炉号";
            this.hEATIDDataGridViewTextBoxColumn.Name = "hEATIDDataGridViewTextBoxColumn";
            this.hEATIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hEATIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // sHIFTDATEDataGridViewTextBoxColumn
            // 
            this.sHIFTDATEDataGridViewTextBoxColumn.DataPropertyName = "SHIFT_DATE";
            this.sHIFTDATEDataGridViewTextBoxColumn.HeaderText = "当班日期";
            this.sHIFTDATEDataGridViewTextBoxColumn.Name = "sHIFTDATEDataGridViewTextBoxColumn";
            this.sHIFTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIFTDATEDataGridViewTextBoxColumn.Width = 78;
            // 
            // cOOLWATERFLOWDataGridViewTextBoxColumn
            // 
            this.cOOLWATERFLOWDataGridViewTextBoxColumn.DataPropertyName = "COOL_WATER_FLOW";
            this.cOOLWATERFLOWDataGridViewTextBoxColumn.HeaderText = "冷却水流量";
            this.cOOLWATERFLOWDataGridViewTextBoxColumn.Name = "cOOLWATERFLOWDataGridViewTextBoxColumn";
            this.cOOLWATERFLOWDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOOLWATERFLOWDataGridViewTextBoxColumn.Width = 90;
            // 
            // cOOLWATERTEMPDataGridViewTextBoxColumn
            // 
            this.cOOLWATERTEMPDataGridViewTextBoxColumn.DataPropertyName = "COOL_WATER_TEMP";
            this.cOOLWATERTEMPDataGridViewTextBoxColumn.HeaderText = "冷却水温差";
            this.cOOLWATERTEMPDataGridViewTextBoxColumn.Name = "cOOLWATERTEMPDataGridViewTextBoxColumn";
            this.cOOLWATERTEMPDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOOLWATERTEMPDataGridViewTextBoxColumn.Width = 90;
            // 
            // oXYGENPRESSUREDataGridViewTextBoxColumn
            // 
            this.oXYGENPRESSUREDataGridViewTextBoxColumn.DataPropertyName = "OXYGEN_PRESSURE";
            this.oXYGENPRESSUREDataGridViewTextBoxColumn.HeaderText = "氧气(工作)压力";
            this.oXYGENPRESSUREDataGridViewTextBoxColumn.Name = "oXYGENPRESSUREDataGridViewTextBoxColumn";
            this.oXYGENPRESSUREDataGridViewTextBoxColumn.ReadOnly = true;
            this.oXYGENPRESSUREDataGridViewTextBoxColumn.Width = 114;
            // 
            // oXYGENFLOWDataGridViewTextBoxColumn
            // 
            this.oXYGENFLOWDataGridViewTextBoxColumn.DataPropertyName = "OXYGEN_FLOW";
            this.oXYGENFLOWDataGridViewTextBoxColumn.HeaderText = "氧气(工作)流量";
            this.oXYGENFLOWDataGridViewTextBoxColumn.Name = "oXYGENFLOWDataGridViewTextBoxColumn";
            this.oXYGENFLOWDataGridViewTextBoxColumn.ReadOnly = true;
            this.oXYGENFLOWDataGridViewTextBoxColumn.Width = 114;
            // 
            // fURNACECOUNTDataGridViewTextBoxColumn
            // 
            this.fURNACECOUNTDataGridViewTextBoxColumn.DataPropertyName = "FURNACE_COUNT";
            this.fURNACECOUNTDataGridViewTextBoxColumn.HeaderText = "当班使用炉数";
            this.fURNACECOUNTDataGridViewTextBoxColumn.Name = "fURNACECOUNTDataGridViewTextBoxColumn";
            this.fURNACECOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            this.fURNACECOUNTDataGridViewTextBoxColumn.Width = 102;
            // 
            // cHANGELANCEREASONDataGridViewTextBoxColumn
            // 
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.DataPropertyName = "CHANGE_LANCE_REASON";
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.DataSource = this.dsChangeReason;
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.DisplayMember = "L3DataTable.Code_Des";
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.HeaderText = "换枪原因";
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.Name = "cHANGELANCEREASONDataGridViewTextBoxColumn";
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.ReadOnly = true;
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.ValueMember = "L3DataTable.Code";
            this.cHANGELANCEREASONDataGridViewTextBoxColumn.Width = 78;
            // 
            // tOTALLANCEAGEDataGridViewTextBoxColumn
            // 
            this.tOTALLANCEAGEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_LANCE_AGE";
            this.tOTALLANCEAGEDataGridViewTextBoxColumn.HeaderText = "累计枪龄";
            this.tOTALLANCEAGEDataGridViewTextBoxColumn.Name = "tOTALLANCEAGEDataGridViewTextBoxColumn";
            this.tOTALLANCEAGEDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALLANCEAGEDataGridViewTextBoxColumn.Width = 78;
            // 
            // aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn
            // 
            this.aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn.DataPropertyName = "AMELT_CONFIRM_PEPOLE";
            this.aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn.HeaderText = "冶炼确认人";
            this.aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn.Name = "aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn";
            this.aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn.Width = 90;
            // 
            // mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn
            // 
            this.mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn.DataPropertyName = "MAINTAIN_CONFIRM_PEPOLE";
            this.mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn.HeaderText = "维修确认人";
            this.mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn.Name = "mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn";
            this.mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn.ReadOnly = true;
            this.mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn.Width = 90;
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
            // LanceUseMagFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tbLPM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LanceUseMagFrm";
            this.TabText = "氧枪使用实绩管理界面";
            this.Text = "氧枪维护实绩管理界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LanceUseMagFrm_FormClosing);
            this.Load += new System.EventHandler(this.LanceUseMagFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsM)).EndInit();
            this.tbLPM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdN1)).EndInit();
            this.bdN1.ResumeLayout(false);
            this.bdN1.PerformLayout();
            this.tSp1.ResumeLayout(false);
            this.tSp1.PerformLayout();
            this.hmiRootPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsChangeReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsTeamID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsShiftID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLanceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schemadsLanceID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AppSvrHMI.L3Adapter Adapter;
        private AppSvrHMI.L3DataSet dsM;
        private System.Windows.Forms.BindingSource bsM;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cmbLanceID;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private buttonHide.ToolStripToriDateTimePicker dtEnd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private buttonHide.ToolStripToriDateTimePicker dtStart;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private AppSvrHMI.L3DataSet dsLanceID;
        private System.Data.DataTable schemadsLanceID;
        private System.Data.DataColumn coldsLanceIDL3DataTableLanceID;
        private AppSvrHMI.L3DataSet dsChangeReason;
        private AppSvrHMI.L3DataSet dsShiftID;
        private AppSvrHMI.L3DataSet dsTeamID;
        private System.Data.DataTable schemadsChangeReason;
        private System.Data.DataColumn coldsChangeReasonL3DataTableCode;
        private System.Data.DataColumn coldsChangeReasonL3DataTableCode_Des;
        private System.Data.DataTable schemadsShiftID;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode;
        private System.Data.DataColumn coldsShiftIDL3DataTableCode_Des;
        private System.Data.DataTable schemadsTeamID;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode;
        private System.Data.DataColumn coldsTeamIDL3DataTableCode_Des;
        private AppSvrHMI.L3Command cmdM;
        private AppSvrHMI.L3CommandParameter l3cmdpM;
        private System.Data.DataTable schemadsM;
        private System.Data.DataColumn coldsML3DataTableGUID;
        private System.Data.DataColumn coldsML3DataTableNAME;
        private System.Data.DataColumn coldsML3DataTableINPUT_TIME;
        private System.Data.DataColumn coldsML3DataTableLANCEID;
        private System.Data.DataColumn coldsML3DataTableLANCE_HEAD_TYPE;
        private System.Data.DataColumn coldsML3DataTableHEATID;
        private System.Data.DataColumn coldsML3DataTableSHIFT_DATE;
        private System.Data.DataColumn coldsML3DataTableCOOL_WATER_FLOW;
        private System.Data.DataColumn coldsML3DataTableCOOL_WATER_TEMP;
        private System.Data.DataColumn coldsML3DataTableOXYGEN_PRESSURE;
        private System.Data.DataColumn coldsML3DataTableOXYGEN_FLOW;
        private System.Data.DataColumn coldsML3DataTableFURNACE_COUNT;
        private System.Data.DataColumn coldsML3DataTableCHANGE_LANCE_REASON;
        private System.Data.DataColumn coldsML3DataTableTOTAL_LANCE_AGE;
        private System.Data.DataColumn coldsML3DataTableAMELT_CONFIRM_PEPOLE;
        private System.Data.DataColumn coldsML3DataTableMAINTAIN_CONFIRM_PEPOLE;
        private System.Data.DataColumn coldsML3DataTableTEAMID;
        private System.Data.DataColumn coldsML3DataTableSHIFTID;
        private System.Data.DataColumn coldsML3DataTableOPERATOR;
        private System.Data.DataColumn coldsML3DataTableNOTE;
        private System.Data.DataColumn coldsML3DataTableMakeID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnOutPut;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNPUTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANCEHEADTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEATIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIFTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOOLWATERFLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOOLWATERTEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oXYGENPRESSUREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oXYGENFLOWDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fURNACECOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cHANGELANCEREASONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALLANCEAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMELTCONFIRMPEPOLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAINTAINCONFIRMPEPOLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tEAMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHIFTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
    }
}